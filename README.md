# BetterSinkholes

BetterSinkholes is a plugin that makes **sinkhole environmental hazards** (found in Light Containment Zone - IX Intersections) more realistic and  similar to SCP: Containment Breach. With the use of this plugin, players who walk into sinkholes fall into the pocket dimension *and may never return*.

## Requirements
- This plugin uses [EXILED](https://github.com/galaxy119/EXILED/).
- Make sure the config option in `config_gameplay.txt` called `sinkhole_spawn_chance` is set to higher than 0.

Note: **BetterSinkholes 2.0+ requires Exiled 2.0+ and SCP:SL 10.0+!** BetterSinkholes v1.0.1 works only with Exiled 1.x and SCP:SL 9.1.3 and is no longer receiving updates!

## Releases
You can find the latest release [here](https://github.com/rby-blackruby/BetterSinkholes/releases).

## SCP:SL 10.0+
The two versions of BetterSinkholes (1.0.1 (for SCP:SL 9.1.3) and 2.0 (for SCP:SL 10.0+)) have slightly different configs due to the changes made in Exiled 2.0. With Exiled 2.0 these configs are automatically added to your config file upon server startup.

| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `IsEnabled` | bool | true | Enables the BetterSinkholes plugin. Set it to false to disable it. |
| `SlowDistance` | float | 1.15f | Distance a the sinkhole where it starts slowing. Don't set it higher than 1.15! |
| `TeleportDistance` | float | 0.7f | Distance from a sinkhole where it teleports you to the pocket dimension. Set it to higher than 0!|
| `TeleportMessage` | string | '' | Set it to '' to disable sinkhole teleport message. Can use Unity's RichText. |
| `TeleportMessageDuration` | ushort | 0 | Duration of the sinkhole teleport message, when teleport message is not null. |

## SCP:SL 9.1.3

| Config option | Value type | Default value | Description |
| --- | --- | --- | --- |
| `bs_enable` | bool | true | Enables the BetterSinkholes plugin. Set it to false to disable it. |
| `bs_slow_distance` | float | 1.15f | The distance from the sinkhole where it starts slowing. Don't set it higher than 1.15! |
| `bs_teleport_distance` | float | 0.7f | The distance from the sinkhole where it teleports you to the pocket dimension. Set it to higher than 0!|
| `bs_teleport_message` | string | null | Set it to null to disable sinkhole teleport message. Can use Unity's RichText. |
| `bs_teleport_message_duration` | uint | 5 | The duration of the sinkhole teleport message, when teleport message is not null. |

## Thank you!

Thank you for being interested in this plugin and I wish you a great time using it! If you have any ideas/problems feel free to contact me on discord: `blackruby#9851`
