$ModName = "ED-Embrasures"
$RimworldPath = "C:\Games\Steam\steamapps\common\RimWorld"

$ExePath = $RimworldPath + "\RimWorldWin64.exe"
$ModSource = "C:\~Git\Jaxxa-Rimworld\~SubModules\" + $ModName +"\" + $ModName
$ModDestination = $RimworldPath + "\Mods\" + $ModName

Remove-Item -Path $ModDestination -Recurse

Copy-Item -Path $ModSource -Destination $ModDestination -Recurse

start -FilePath $ExePath -ArgumentList "-savedatafolder=C:\~Git\RimworldSaves_1.1\ModTest"