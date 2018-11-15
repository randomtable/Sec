Imports System.Text

Public Class Form1
    Dim a As New StringBuilder

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.AppendLine("[Unicode]")
        a.AppendLine("Unicode=yes")
        a.AppendLine("[System Access]")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            a.AppendLine("PasswordHistorySize = " & TextBox1.Text)
        Else
            MsgBox("Attenzione! Vedere valore password memorizzate")
        End If
        If ComboBox1.Text = "Si" Then
            a.AppendLine("PasswordComplexity = 1")
        Else
            a.AppendLine("PasswordComplexity = 0")
        End If
        If IsNumeric(TextBox2.Text) Then
            a.AppendLine("MinimumPasswordLength = " & TextBox2.Text)
        Else
            MsgBox("Attenzione! Vedere valore Lunghezza minima password")
        End If
        If IsNumeric(TextBox3.Text) Then
            a.AppendLine("MaximumPasswordAge = " & TextBox3.Text)
        Else
            MsgBox("Attenzione! Vedere valore Validità massima password")
        End If
        If IsNumeric(TextBox4.Text) Then
            a.AppendLine("LockoutBadCount = " & TextBox4.Text)
            a.AppendLine("ResetLockoutCount = 10")
            a.AppendLine("LockoutDuration = 10")
            a.AppendLine("[Event Audit]")
        Else
            MsgBox("Attenzione! Vedere valore Tentativi Password Ammessi")
        End If
        Dim b As Integer = 0
        If CheckBox1.Checked = True Then
            b = b + 1
        End If
        If CheckBox2.Checked = True Then
            b = b + 2
        End If
        a.AppendLine("AuditObjectAccess = " & b)
        Dim c As Integer = 0
        If CheckBox4.Checked = True Then
            c = c + 1
        End If
        If CheckBox3.Checked = True Then
            c = c + 2
        End If
        a.AppendLine("AuditDSAccess = " & c)
        Dim d As Integer = 0
        If CheckBox6.Checked = True Then
            d = d + 1
        End If
        If CheckBox5.Checked = True Then
            d = d + 2
        End If
        a.AppendLine("AuditAccountLogon = " & d)
        Dim f As Integer = 0
        If CheckBox8.Checked = True Then
            f = f + 1
        End If
        If CheckBox7.Checked = True Then
            f = f + 2
        End If
        a.AppendLine("AuditLogonEvents = " & f)
        Dim g As Integer = 0
        If CheckBox10.Checked = True Then
            g = g + 1
        End If
        If CheckBox9.Checked = True Then
            g = g + 2
        End If
        a.AppendLine("AuditSystemEvents = " & g)
        Dim h As Integer = 0
        If CheckBox12.Checked = True Then
            h = h + 1
        End If
        If CheckBox11.Checked = True Then
            h = h + 2
        End If
        a.AppendLine("AuditAccountManage = " & h)
        Dim i As Integer = 0
        If CheckBox14.Checked = True Then
            i = i + 1
        End If
        If CheckBox13.Checked = True Then
            i = i + 2
        End If
        a.AppendLine("AuditPolicyChange = " & i)
        Dim j As Integer = 0
        If CheckBox16.Checked = True Then
            j = j + 1
        End If
        If CheckBox15.Checked = True Then
            j = j + 2
        End If
        a.AppendLine("AuditProcessTracking = " & j)
        Dim k As Integer = 0
        If CheckBox16.Checked = True Then
            k = k + 1
        End If
        If CheckBox15.Checked = True Then
            k = k + 2
        End If
        a.AppendLine("AuditPrivilegeUse = " & k)
        a.AppendLine("[Registry Values]")
        If CheckBox27.Checked = False Then
            a.AppendLine("MACHINE\System\CurrentControlSet\Control\Lsa\SCENoApplyLegacyAuditPolicy=4,0")
        Else
            a.AppendLine("MACHINE\System\CurrentControlSet\Control\Lsa\SCENoApplyLegacyAuditPolicy=4,1")
        End If
        a.AppendLine("[Privilege Rights]")
        If CheckBox19.Checked = True Then
            a.AppendLine("SeNetworkLogonRight =")
        Else
            a.AppendLine("SeNetworkLogonRight = *S-1-1-0,*S-1-5-32-544,*S-1-5-32-545,*S-1-5-32-551")
        End If
        If CheckBox20.Checked = True Then
            a.AppendLine("SeServiceLogonRight =")
        Else
            a.AppendLine("SeServiceLogonRight = *S-1-5-80-0")
        End If
        If CheckBox21.Checked = True Then
            a.AppendLine("SeBatchLogonRight =")
        Else
            a.AppendLine("SeBatchLogonRight = *S-1-5-32-544,*S-1-5-32-551,*S-1-5-32-559")
        End If
        If CheckBox22.Checked = True Then
            a.AppendLine("SeTakeOwnershipPrivilege =")
        Else
            a.AppendLine("SeTakeOwnershipPrivilege = *S-1-5-32-544")
        End If
        If CheckBox23.Checked = True Then
            a.AppendLine("SeRemoteShutdownPrivilege =")
        Else
            a.AppendLine("SeRemoteShutdownPrivilege = *S-1-5-32-544")
        End If
        If CheckBox24.Checked = True Then
            a.AppendLine("SeIncreaseBasePriorityPrivilege =")
        Else
            a.AppendLine("SeIncreaseBasePriorityPrivilege = *S-1-5-32-544")
        End If
        If CheckBox25.Checked = True Then
            a.AppendLine("SeBackupPrivilege =")
        Else
            a.AppendLine("SeBackupPrivilege = *S-1-5-32-544,*S-1-5-32-551")
        End If
        If CheckBox26.Checked = True Then
            a.AppendLine("SeLoadDriverPrivilege =")
        Else
            a.AppendLine("SeLoadDriverPrivilege = *S-1-5-32-544")
        End If
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
        info2.Arguments = "/c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log"
        Process.Start(info2).WaitForExit()
        Application.DoEvents()
        Dim info3 As New ProcessStartInfo
        info3.WindowStyle = ProcessWindowStyle.Hidden
        info3.FileName = "cmd.exe"
        info3.Arguments = "/c netsh advfirewall set currentprofile logging maxfilesize 4096"
        Process.Start(info3).WaitForExit()
        Application.DoEvents()
        Dim info4 As New ProcessStartInfo
        info4.WindowStyle = ProcessWindowStyle.Hidden
        info4.FileName = "cmd.exe"
        info4.Arguments = "/c netsh advfirewall set currentprofile logging droppedconnections enable"
        Process.Start(info4).WaitForExit()
        Application.DoEvents()
        a.AppendLine("[Version]")
        a.AppendLine("signature=" & Chr(34) & "$CHICAGO$" & Chr(34))
        a.AppendLine("Revision=1")
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\secpol.inf", a.ToString, False, System.Text.Encoding.Default)
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & Application.StartupPath & "\secpol.inf" & Chr(34) & " /overwrite"
        Process.Start(info5).WaitForExit()
        Application.DoEvents()
        MsgBox("Operazione Completata")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & OpenFileDialog1.FileName & Chr(34) & " /overwrite"
        Process.Start(info5).WaitForExit()
        Application.DoEvents()
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
        info2.Arguments = "/c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log"
        Process.Start(info2).WaitForExit()
        Application.DoEvents()
        Dim info3 As New ProcessStartInfo
        info3.WindowStyle = ProcessWindowStyle.Hidden
        info3.FileName = "cmd.exe"
        info3.Arguments = "/c netsh advfirewall set currentprofile logging maxfilesize 4096"
        Process.Start(info3).WaitForExit()
        Application.DoEvents()
        Dim info4 As New ProcessStartInfo
        info4.WindowStyle = ProcessWindowStyle.Hidden
        info4.FileName = "cmd.exe"
        info4.Arguments = "/c netsh advfirewall set currentprofile logging droppedconnections enable"
        Process.Start(info4).WaitForExit()
        Application.DoEvents()
        MsgBox("Operazione Completata")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start(Application.StartupPath & "\Fire.exe")
    End Sub
End Class
