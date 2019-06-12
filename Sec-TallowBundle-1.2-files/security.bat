cmd.exe /c netsh advfirewall reset
cmd.exe /c netsh advfirewall firewall delete rule name=all
cd "%~dp0%" && tallow.exe