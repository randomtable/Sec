cmd.exe /c secedit /configure /db secpol.sdb /cfg "%~dp0%\MANAGED.inf" /overwrite
cmd.exe /c netsh advfirewall reset
cmd.exe /c netsh advfirewall firewall delete rule name=all
cmd.exe /c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
cmd.exe /c netsh advfirewall set currentprofile logging maxfilesize 4096
cmd.exe /c netsh advfirewall set currentprofile logging droppedconnections enable