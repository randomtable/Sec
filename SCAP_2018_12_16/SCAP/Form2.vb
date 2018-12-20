Imports System.IO

Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("The Standalone environment describes individually managed devices (e.g., desktops, laptops, smartphones, tablets), as opposed to Managed environments (see Section 3.2), which are based on centrally managed devices (i.e., many devices managed by a single organization). Standalone environments are typically the least secured. The individuals who maintain Standalone systems are not assumed to use the same enterprise security controls and possess the same general security expertise as trained administrators. Less secure environments often occur when functionality is the main focus and not enough emphasis is placed on balancing device security and functionality. Accordingly, Standalone checklists should be relatively simple to understand and implement by home users or novice system administrators.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & Application.StartupPath & "\USGCB.inf" & Chr(34) & " /overwrite"
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
        MsgBox("Completed! Please Restart your System!")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox(Form3.RichTextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ProcessDirADMX(Application.StartupPath & "\MANAGED")
        ProcessDirENUS(Application.StartupPath & "\MANAGED")
        ProcessDirGPOSMANAGED()
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & Application.StartupPath & "\ULTRA.inf" & Chr(34) & " /overwrite"
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
        MsgBox("Completed! Please Restart your System!")
    End Sub

    Public Sub ProcessDirADMX(ByVal Dir As String)

        Dim fileEntries As String() = Directory.GetFiles(Dir)
        For Each fileName As String In fileEntries
            ProcessFileADMX(fileName)
        Next

        Dim subdirectoryEntries As String() = Directory.GetDirectories(Dir)
        For Each subdirectory As String In subdirectoryEntries
            ProcessDirADMX(subdirectory)
        Next

    End Sub

    Public Sub ProcessFileADMX(ByVal FilePath As String)

        Dim findextension() As String = FilePath.Split(".")
        If findextension(1) = "admx" Then
            Dim dirs() As String = FilePath.Split("\")
            Dim rootPath As String = Environment.GetEnvironmentVariable("systemroot")
            My.Computer.FileSystem.CopyFile(FilePath, rootPath & "\PolicyDefinitions\" & dirs(dirs.Length - 1), True)
        End If

    End Sub

    Public Sub ProcessDirENUS(ByVal Dir As String)

        Dim subdirectoryEntries As String() = Directory.GetDirectories(Dir)
        For Each subdirectory As String In subdirectoryEntries
            subdirectory = subdirectory.ToLower
            If subdirectory.Contains("en-us") Then
                Dim rootPath As String = Environment.GetEnvironmentVariable("systemroot")
                My.Computer.FileSystem.CopyDirectory(subdirectory, rootPath & "\PolicyDefinitions\en-us", True)
            End If
            ProcessDirENUS(subdirectory)
        Next

    End Sub

    Public Sub ProcessDirGPOSMANAGED()

        Process.Start("LGPOMANAGED.bat").WaitForExit()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MsgBox(Form3.RichTextBox2.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ProcessDirADMX(Application.StartupPath & "\November 2018 DISA STIG GPO Package")
        ProcessDirENUS(Application.StartupPath & "\November 2018 DISA STIG GPO Package")
        ProcessDirGPO()
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & Application.StartupPath & "\USGCB.inf" & Chr(34) & " /overwrite"
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
        MsgBox("Completed! Please Restart your System!")
    End Sub

    Public Sub ProcessDirGPO()

        Process.Start("LGPO.bat").WaitForExit()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("Use this configurations if you are in a Gov Environment. Use with caution.")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ProcessDirADMX(Application.StartupPath & "\November 2018 DISA STIG GPO Package")
        ProcessDirENUS(Application.StartupPath & "\November 2018 DISA STIG GPO Package")
        ProcessDirGPO()
        Dim info5 As New ProcessStartInfo
        info5.WindowStyle = ProcessWindowStyle.Normal
        info5.FileName = "cmd.exe"
        info5.Arguments = "/c secedit /configure /db secpol.sdb /cfg " & Chr(34) & Application.StartupPath & "\ULTRA.inf" & Chr(34) & " /overwrite"
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
        MsgBox("Completed! Please Restart your System!")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ProcessDirGPOBACKUP()
    End Sub

    Public Sub ProcessDirGPOBACKUP()

        Process.Start("LGPOBACKUP.bat").WaitForExit()

    End Sub

    Public Sub ProcessDirGPORESTORE()

        Process.Start("LGPORESTORE.bat").WaitForExit()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ProcessDirGPORESTORE()
    End Sub
End Class