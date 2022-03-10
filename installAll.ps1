#adb path because adb is janky and local setup has multlple adbs

$adb = "E:\env\AndroidSDK\platform-tools\adb.exe";

foreach ($file in Get-ChildItem -Path Builds -Filter *.apk)
{
  $cmd = "$adb install -r -g -d Builds\$file"
  Write-Host $cmd
  Invoke-Expression $cmd
}