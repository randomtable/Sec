do
{
     $input = Read-Host "Select '1' for BASE config, '2' for USGCB config, '3' for ULTRA config, 'q' for exit"
     switch ($input)
     {
           '1' {
                cls
                $PSScriptRoot = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
secedit /configure /db secpol.sdb /cfg "$PSScriptRoot\BASE.inf" /overwrite
netsh advfirewall reset
netsh advfirewall firewall delete rule name=all
netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
netsh advfirewall set currentprofile logging maxfilesize 4096
netsh advfirewall set currentprofile logging droppedconnections enable
           } '2' {
                cls
                $PSScriptRoot = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
secedit /configure /db secpol.sdb /cfg "$PSScriptRoot\USGCB.inf" /overwrite
netsh advfirewall reset
netsh advfirewall firewall delete rule name=all
netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
netsh advfirewall set currentprofile logging maxfilesize 4096
netsh advfirewall set currentprofile logging droppedconnections enable
           } '3' {
                cls
                $PSScriptRoot = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
secedit /configure /db secpol.sdb /cfg "$PSScriptRoot\ULTRA.inf" /overwrite
netsh advfirewall reset
netsh advfirewall firewall delete rule name=all
netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log
netsh advfirewall set currentprofile logging maxfilesize 4096
netsh advfirewall set currentprofile logging droppedconnections enable
           } 'q' {
                return
           }
     }
}
until ($input -eq 'q')