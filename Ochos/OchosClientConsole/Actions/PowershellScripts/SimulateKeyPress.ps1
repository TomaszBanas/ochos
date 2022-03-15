$wshShell = new-object -com wscript.shell
$wshShell.SendKeys([char]$args[0])



<#

Mute/Unmute: 173
Volume Down: 174
Volume Up: 175
Next Track: 176
Previous Track: 177
Stop Media: 178
Play/Pause: 179

#>