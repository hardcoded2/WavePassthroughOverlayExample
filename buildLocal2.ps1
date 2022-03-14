
for (($i = 0); $i -lt 1; $i++)
{
#"C:\Program Files\Unity\Editor\Unity.exe" -quit -batchmode -projectPath "C:\Users\UserName\Documents\MyProject" -executeMethod MyEditorScript.PerformBuild
#Invoke-Expression -Command ""C:\Program Files\Unity\Hub\Editor\2019.4.30f1\Editor\Unity.exe"" -quit -batchmode -executeMethod TestBuilder.Build

Invoke-Expression -Command "C:\'Program Files'\Unity\Hub\Editor\2019.4.30f1\Editor\Unity.exe -batchmode -executeMethod TestBuilder.Build -quit -logFile -projectPath ."


#    Start-UnityEditor -ExecuteMethod TestBuilder.Build -BatchMode -Quit -LogFile .\build$(get-date -f yyyy-MM-dd-hh-ss).log -Wait
}
