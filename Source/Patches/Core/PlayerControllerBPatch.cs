﻿using GameNetcodeStuff;
using HarmonyLib;
using PlayerDogModel_Plus.Source.Model;
using UnityEngine;

namespace PlayerDogModel_Plus.Source.Patches.Core
{
    // PlayerModelReplacer handles the model and its toggling.
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        // SpawnPlayerAnimation is called when respawning.
        [HarmonyPatch("SpawnPlayerAnimation")]
        [HarmonyPostfix]
        public static void SpawnPlayerAnimationPatchPostfix(ref PlayerControllerB __instance)
        {
            // Find all the players and add the script to them if they don't have it yet.
            // This is done for every player every time a player spawns just to be sure.
            foreach (GameObject player in StartOfRound.Instance.allPlayerObjects)
            {
                if (!player.GetComponent<PlayerModelReplacer>())
                {
                    player.gameObject.AddComponent<PlayerModelReplacer>();
                }
            }

            // Request data regarding the other players' skins.
            PlayerModelReplacer.RequestSelectedModelBroadcast();
        }

        [HarmonyPatch("SetItemInElevator")]
        [HarmonyPostfix]
        public static void SetItemInElevatorPostfix(ref PlayerControllerB __instance, ref GrabbableObject gObject, bool droppedInShipRoom)
        {
            if (!droppedInShipRoom) return;

            RagdollGrabbableObject ragdollObject = gObject as RagdollGrabbableObject;
            if (ragdollObject == null) return;

            PlayerModelReplacer replacer = ragdollObject.ragdoll.playerScript.GetComponent<PlayerModelReplacer>(); // Get the replacer for this ragdoll

            if (replacer == null || !replacer.IsDog) return;

            Item dogRagdoll = GameObject.Instantiate(gObject.itemProperties);
            dogRagdoll.spawnPrefab = LC_API.BundleAPI.BundleLoader.GetLoadedAsset<GameObject>("assets/DogRagdoll.fbx");

            gObject.itemProperties = dogRagdoll; // We have to treat the item as immutable here
        }
    }
}
