@echo off
color a
title Unban by WeepingAngel
cls
echo Thats a Temporary fix for the Kick Bug
echo PLEASE READ THE .txt TO KNOW WHAT YOU ARE DOING!!
pause
cls
ipconfig /flushdns
cd C:\Users\%username%\AppData\Local\Roblox
del GlobalBasicSettings_13.xml
del frm.cfg
del AnalysticsSettings.xml
cd C:\Users\%username%\AppData\Local\Roblox\Versions\version-fc5e24b515354061
del AppSettings.xml
del kernel64.sys.dll
ipconfig /flushdns
cd C:\Windows\Temp
del *.temp
pause