# BetterSinkholes

BetterSinkholes is a plugin that makes **sinkhole environmental hazards** (found in Light Containment Zone - IX Intersections) more realistic and  similar to SCP: Containment Breach. With the use of this plugin, players who walk into sinkholes fall into the pocket dimension *and may never return*.

## Requirements
- This plugin uses [EXILED](https://github.com/galaxy119/EXILED/).
- Make sure the config option in `config_gameplay.txt` called `sinkhole_spawn_chance` is set to higher than 0.

## Releases
You can find the latest release [here](https://github.com/rby-blackruby/BetterSinkholes/releases).

## Configs

| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `bs_enable` | bool | true | Enables the BetterSinkholes plugin. Set it to false to disable it. |
| `bs_slow_distance` | float | 1.15 | The distance from the sinkhole where it starts slowing. Don't set it higher than 1.15! |
| `bs_teleport_distance` | float | 0.7 | The distance from the sinkhole where it teleports you to the pocket dimension. Set it higher than 0!|
| `bs_teleport_message` | string | null | Set it to null to disable sinkhole teleport message. Can use Unity's RichText. |
| `bs_teleport_message_duration` | uint | 5 | The duration of the sinkhole teleport message, when teleport message is not null. |

## Thank you!
Special thanks to [RogerFK](https://github.com/RogerFK/) and [SomewhatSane](https://github.com/SomewhatSane/) for helping me with this project, check out ther GitHub pages too by clicking on their name!

Thank you for being interested in this plugin and I wish you a great time using it! If you have any ideas/problems feel free to contact me on discord: `blackruby#6053`
