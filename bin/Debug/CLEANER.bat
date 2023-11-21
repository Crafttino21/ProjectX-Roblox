@echo off
rd autoexec
rd logs 
del exploit-main.dll
del finj.exe
del kernel64.sys.dll
del WRDAPICONF.json
del EasyExploitsDLL.dll
del settings
cd %tmp%
del *.*
color a
echo Cleaned Succssessfuly!
pause