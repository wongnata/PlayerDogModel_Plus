﻿using GameNetcodeStuff;
using LethalNetworkAPI;
using PlayerDogModel_Plus.Source.Model;
using System;

namespace PlayerDogModel_Plus.Source
{
    static class Networking
    {
        public const string ModelSwitchMessageName = "modelswitch";
        public const string ModelInfoMessageName = "modelinfo";

        public static void Initialize()
        {
            LethalClientMessage<bool> selectedModelMessage = new LethalClientMessage<bool>(ModelSwitchMessageName);
            LethalClientEvent requestSelectedModelEvent = new LethalClientEvent(ModelInfoMessageName);
            selectedModelMessage.OnReceivedFromClient += HandleModelSwitchMessage;
            requestSelectedModelEvent.OnReceivedFromClient += HandleModelInfoMessage;
        }

        internal static void HandleModelSwitchMessage(bool isDog, ulong senderId)
        {
            Plugin.logger.LogDebug($"Got {ModelSwitchMessageName} network message from {senderId} with isDog={isDog}");
            PlayerModelReplacer replacer = senderId.GetPlayerController().GetComponent<PlayerModelReplacer>();

            if (replacer == null)
            {
                Plugin.logger.LogWarning($"{ModelSwitchMessageName} message from client {senderId} will be ignored because replacer with this ID is not registered");
                return;
            }

            if (!replacer.IsValid)
            {
                Plugin.logger.LogError("Dog encountered an error when it was initialized and it can't be toggled. Check the log for more info.");
                return;
            }

            replacer.ReceiveBroadcastAndToggle(false, isDog);
        }

        internal static void HandleModelInfoMessage(ulong senderId)
        {
            Plugin.logger.LogDebug($"Got {ModelInfoMessageName} network message from {senderId}");
            PlayerControllerB localPlayer = StartOfRound.Instance.localPlayerController;
            PlayerModelReplacer replacer = localPlayer.GetComponent<PlayerModelReplacer>();

            if (replacer != null)
            {
                try
                {
                    replacer.BroadcastSelectedModel(playAudio: false);
                }
                catch (Exception e)
                {
                    Plugin.logger.LogDebug($"Couldn't broadcast model for senderId={senderId} for some reason!");

                    if (!Plugin.boundConfig.suppressExceptions.Value) throw e;
                }
            }
        }
    }
}