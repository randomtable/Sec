ECHO OFF
CLS


:MENU
ECHO.
ECHO ........................................................
ECHO PRESS 1, 2 OR 3 to select security rules, or 4 to EXIT
ECHO ........................................................
ECHO.
ECHO 1 - Set "BASE" rules
ECHO 2 - Set "USGCB" rules
ECHO 3 - Set "ULTRA" rules
ECHO 4 - EXIT
ECHO.


SET /P M=Type 1, 2, 3, or 4 then press ENTER:
IF %M%==1 GOTO BASE
IF %M%==2 GOTO USGCB
IF %M%==3 GOTO ULTRA
IF %M%==4 GOTO EOF

:BASE
cmd.exe /c secedit /configure /db secpol.sdb /cfg "%~dp0%\BASE.inf" /overwrite
cmd.exe /c netsh advfirewall reset
cmd.exe /c netsh advfirewall firewall delete rule name=all
cmd.exe /c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
cmd.exe /c netsh advfirewall set currentprofile logging maxfilesize 4096
cmd.exe /c netsh advfirewall set currentprofile logging droppedconnections enable
GOTO MENU
:USGCB
cmd.exe /c secedit /configure /db secpol.sdb /cfg "%~dp0%\USGCB.inf" /overwrite
cmd.exe /c netsh advfirewall reset
cmd.exe /c netsh advfirewall firewall delete rule name=all
cmd.exe /c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
cmd.exe /c netsh advfirewall set currentprofile logging maxfilesize 4096
cmd.exe /c netsh advfirewall set currentprofile logging droppedconnections enable
GOTO MENU
:ULTRA
cmd.exe /c secedit /configure /db secpol.sdb /cfg "%~dp0%\ULTRA.inf" /overwrite
cmd.exe /c netsh advfirewall reset
cmd.exe /c netsh advfirewall firewall delete rule name=all
cmd.exe /c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
cmd.exe /c netsh advfirewall set currentprofile logging maxfilesize 4096
cmd.exe /c netsh advfirewall set currentprofile logging droppedconnections enable
GOTO MENU