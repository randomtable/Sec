Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("STANDALONE.bat").WaitForExit()
        MsgBox("Completed! Please restart your system!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("MANAGED.bat").WaitForExit()
        MsgBox("Completed! Please restart your system!")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Process.Start("SSLF.bat").WaitForExit()
        MsgBox("Completed! Please restart your system!")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start("GOVERNMENT.bat").WaitForExit()
        MsgBox("Completed! Please restart your system!")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Activate()
        Form2.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Process.Start("BASE.bat").WaitForExit()
        MsgBox("Completed! Please restart your system!")
    End Sub
End Class
