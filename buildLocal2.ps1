
for (($i = 0); $i -lt 1; $i++)
{
#"C:\Program Files\Unity\Editor\Unity.exe" -quit -batchmode -projectPath "C:\Users\UserName\Documents\MyProject" -executeMethod MyEditorScript.PerformBuild
"C:\Program Files\Unity\Hub\Editor\2019.4.30f1\Editor\Unity.exe" -quit -batchmode -executeMethod TestBuilder.Build
#    Start-UnityEditor -ExecuteMethod TestBuilder.Build -BatchMode -Quit -LogFile .\build$(get-date -f yyyy-MM-dd-hh-ss).log -Wait
}
