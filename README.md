# [Fork of the original mod by **MonAmiral**!](https://thunderstore.io/c/lethal-company/p/MonAmiral/PlayerDogModel/)

> [!IMPORTANT]
> [Please report bugs, issues, and feature requests](https://github.com/wongnata/PlayerDogModel_Plus/issues/) and I will be happy to look into them when I have time!

![](https://i.imgur.com/s1SdJxD.png)

## Features

Use the helmets on the side of the suits rack to toggle dog mode, or install [TerminalAPI](https://thunderstore.io/c/lethal-company/p/NotAtomicBomb/TerminalApi/#creating-terminal-nodes) and use the command "switch model"!

- Model, first person camera, item anchor, health display, and ragdoll are updated in dog mode
- Snare fleas and tulip snakes attach to the dog model head
- Jetpacks are aligned to the dog model body
- Spectator cameras are recentered on dog players
- Body collected notification displays a dog model turnaround
- Hides any [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/) cosmetics and vanilla head cosmetics while in dog mode
- Custom overrides in config file to customize the [Verity-3rdPerson](https://thunderstore.io/c/lethal-company/p/Verity/3rdPerson/) camera in dog mode
- Masks attach to the dog model head during possession
- Belt bag position is adjusted to be useable (and kind of cute!) when pocketed in dog mode
- Masked enemies mimicking dog players will use the dog model
- [OpenBodyCams](https://thunderstore.io/c/lethal-company/p/Zaggy1024/OpenBodyCams/) shows the dog player's camera when monitoring a dog player

<details>

<summary>Click for more screenshots!</summary>

![](https://imgur.com/HqYB9te.png)
![](https://i.imgur.com/lJHsS3n.png)
![](https://i.imgur.com/dSnw0l3.png)
![](https://i.imgur.com/rnOUaUE.png)

</details>

## Limitations
- When crouching in dog mode, dropped items can fall through the ship
- When holding certain items in dog mode (dog ragdoll in particular), they may partially or fully obstruct your view ([Verity-3rdPerson](https://thunderstore.io/c/lethal-company/p/Verity/3rdPerson/) is a good fix for this)
- Masked enemies using the dog model that were not spawned from a possession do not have masks
- Masked enemies spawned from a dog model will not have a mask if [Mirage](https://thunderstore.io/c/lethal-company/p/qwbarch/Mirage/) is being used, regardless of config
- Some animations look a little funky for masked enemies using the dog model
- Blood spatter does not apply to dog players or their ragdolls
- [CruiserImproved](https://thunderstore.io/c/lethal-company/p/DiggC/CruiserImproved/) currently conflicts with this mod. When used together, by default the first person camera will either remain at human height or shake constantly while in dog mode. A workaround for using both mods together is documented [here](https://github.com/wongnata/PlayerDogModel_Plus/issues/47#issuecomment-2382134952)
- [MoreCompany](https://thunderstore.io/c/lethal-company/p/notnotnotswipez/MoreCompany/) cosmetics that you have equipped may be visible to you in third person while in dog mode depending on which mods you are using
- Mods which hide or alter the suits rack ([suitsTerminal](https://thunderstore.io/c/lethal-company/p/darmuh/suitsTerminal/) for example!) may prevent the "switch model" node on the suit rack from rendering correctly. Please install [TerminalAPI](https://thunderstore.io/c/lethal-company/p/NotAtomicBomb/TerminalApi/#creating-terminal-nodes) and use the terminal command ("switch model") to switch models if this happens!

## Credits
- Obviously [MonAmiral](https://thunderstore.io/c/lethal-company/p/MonAmiral/) and [all their supporters](https://github.com/MonAmiral/PlayerDogModel?tab=readme-ov-file#credits) for creating the original mod! It's awesome!
- Thanks to Andrew, Jaime, [90% Andy](https://www.90percentstudios.com/), and [90% Denny](https://www.90percentstudios.com/) for your help in testing and fixing multiplayer interactions! Dog bless you!
- Thanks to the entire Flodogs+ squad for dogfooding this mod with me! Bone-appetit!
- Thanks to [Zaggy](https://thunderstore.io/c/lethal-company/p/Zaggy1024/) and [Bunya](https://thunderstore.io/c/lethal-company/p/BunyaPineTree/?section=asset-replacements) for their advice in implementing the OpenBodyCams patch!