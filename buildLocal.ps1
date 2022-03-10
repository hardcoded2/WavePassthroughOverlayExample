#requires -Modules UnitySetup

for (($i = 0); $i -lt 10; $i++)
{
    Start-UnityEditor -ExecuteMethod TestBuilder.Build -BatchMode -Quit -LogFile .\build$(get-date -f yyyy-MM-dd-hh-ss).log -Wait
}
