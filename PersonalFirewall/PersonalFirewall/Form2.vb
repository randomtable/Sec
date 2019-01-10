Imports System.Net

Public Class Form2

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Form1.Activate()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Shell("cmd.exe /c netsh advfirewall set currentprofile logging filename %systemroot%\system32\LogFiles\Firewall\pfirewall.log", AppWinStyle.Hide)
        Shell("cmd.exe /c netsh advfirewall set currentprofile logging maxfilesize 4096", AppWinStyle.Hide)
        Shell("cmd.exe /c netsh advfirewall set currentprofile logging droppedconnections enable", AppWinStyle.Hide)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        
        If My.Computer.FileSystem.FileExists("C:\Windows\system32\LogFiles\Firewall\pfirewall.log") = False Then

        Else
            My.Computer.FileSystem.CopyFile("C:\Windows\system32\LogFiles\Firewall\pfirewall.log", Application.StartupPath & "\pfirewall.log", True)
            Dim data As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\pfirewall.log")
            Dim lines() As String = data.Split(Environment.NewLine)
            For i = 0 To lines.Length - 1
                Dim fields() As String = lines(i).Split(" ")
                Try
                    Dim ip As String = fields(4)
                    Dim ips As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\ips.txt")
                    If ips.Contains(ip) Then

                    Else
                        Dim Datas As String
                        Try
                            Using Client As New System.Net.WebClient()
                                ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                                Datas = Client.DownloadString("https://dshield.org/api/ip/" & ip)
                                Dim datafields() As String = Datas.Split("<")
                                For ii = 0 To datafields.Length - 1
                                    If datafields(ii).Contains("attacks") And Not datafields(ii).Contains("/") Then
                                        Dim attacksdata() As String = datafields(ii).Split(">")
                                        Dim attacks As String = attacksdata(1)
                                        Dim log As Double = Math.Log10(attacks) * 2
                                        If log > 0 Then
                                            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\ips.txt", ip, True)
                                            Shell("netsh advfirewall firewall add rule name=" & Chr(34) & "IP Block" & Chr(34) & " dir=in interface=any action=block remoteip=" & ip, AppWinStyle.Hide)
                                        End If
                                    End If
                                Next
                            End Using
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Catch ex As Exception

                End Try
            Next
        End If
        Timer1.Start()
    End Sub
End Class