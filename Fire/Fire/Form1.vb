Imports System
Imports System.ComponentModel
Imports System.Management

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim info As New ProcessStartInfo
        info.WindowStyle = ProcessWindowStyle.Hidden
        info.FileName = "cmd.exe"
        info.Arguments = "/c netsh advfirewall reset"
        Process.Start(info).WaitForExit()
        Application.DoEvents()
        Dim info1 As New ProcessStartInfo
        info1.WindowStyle = ProcessWindowStyle.Hidden
        info1.FileName = "cmd.exe"
        info1.Arguments = "/c netsh advfirewall firewall delete rule name=all"
        Process.Start(info1).WaitForExit()
        Application.DoEvents()
        Dim info2 As New ProcessStartInfo
        info2.WindowStyle = ProcessWindowStyle.Hidden
        info2.FileName = "cmd.exe"
        info2.Arguments = "/c netsh advfirewall set allprofiles logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log"
        Process.Start(info2).WaitForExit()
        Application.DoEvents()
        Dim info3 As New ProcessStartInfo
        info3.WindowStyle = ProcessWindowStyle.Hidden
        info3.FileName = "cmd.exe"
        info3.Arguments = "/c netsh advfirewall set allprofiles logging maxfilesize 4096"
        Process.Start(info3).WaitForExit()
        Application.DoEvents()
        Dim info4 As New ProcessStartInfo
        info4.WindowStyle = ProcessWindowStyle.Hidden
        info4.FileName = "cmd.exe"
        info4.Arguments = "/c netsh advfirewall set allprofiles logging droppedconnections enable"
        Process.Start(info4).WaitForExit()
        Application.DoEvents()
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Hidden
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c netsh advfirewall set allprofiles firewallpolicy blockinbound,blockoutbound"
        Process.Start(info5).WaitForExit()
        Application.DoEvents()
        Dim cl() As String
        For Each p As Process In Process.GetProcesses
            Try
                Using searcher As New ManagementObjectSearcher("SELECT ExecutablePath FROM Win32_Process WHERE ProcessId = " & p.Id)
                    For Each mgmtObj As ManagementObject In searcher.Get()
                        Try
                            cl = mgmtObj.Item("ExecutablePath").ToString().Split("""")
                            Dim info6 As New ProcessStartInfo
                            info6.WindowStyle = ProcessWindowStyle.Hidden
                            info6.FileName = "cmd.exe"
                            info6.Arguments = "/c netsh advfirewall firewall add rule name=" & Chr(34) & cl(cl.Length - 1) & Chr(34) & " dir=out action=allow program=" & Chr(34) & cl(cl.Length - 1) & Chr(34) & " enable=yes"
                            Process.Start(info6).WaitForExit()
                            Application.DoEvents()
                        Catch ex As Exception

                        End Try
                    Next
                End Using
            Catch ex As Win32Exception
                'handle error
            End Try
        Next
        MsgBox("Operazione Completata")
        End
    End Sub
End Class
