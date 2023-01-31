#requires -Modules UnitySetup

$unityVersions = "2019.4.30f1"

foreach($unityVersion in $unityVersions)
{
    #install relevant version if not already present
    $alreadyHas = Get-UnitySetupInstance | Select-UnitySetupInstance -Version $unityVersion
    if(!$alreadyHas){
        Find-UnitySetupInstaller -Version $unityVersion -Components 'Android' | Install-UnitySetupInstance
    }

    #Start-UnityEditor -BuildTarget Android -ExecuteMethod TestBuilder.Build -BatchMode -Quit -LogFile ".\build$(get-date -f yyyy-MM-dd-hh-ss).log" -Wait -Version $unityVersion
}
foreach($unityVersion in $unityVersions)
{
    #build with each version
    #run only version sthat installed successfully
    $alreadyHas = Get-UnitySetupInstance | Select-UnitySetupInstance -Version $unityVersion
    if(!$alreadyHas){
        continue; #if installation of that version of unity failed, skip it
    }
    Start-UnityEditor -BuildTarget Android -ExecuteMethod TestBuilder.BuildNoVersionUpdate -BatchMode -Quit -LogFile ".\build$(get-date -f yyyy-MM-dd-hh-ss).log" -Wait -Version $unityVersion
}