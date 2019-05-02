
Partial Class _Application
    Inherits System.Web.UI.Page

    'Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    '    ViewStateUserKey = Session.SessionID
    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each key In Request.QueryString.AllKeys
            Dim control As String = Request.QueryString.Item(key.ToString).ToString
            If UCase(control).Contains("SLEEP") Or UCase(control).Contains("SELECT") Or UCase(control).Contains("UPDATE") Or UCase(control).Contains("INSERT") Or UCase(control).Contains("DELETE") Or UCase(control).Contains("<") Or UCase(control).Contains("SCRIPT") Then
                Response.Redirect("0.html")
            End If
        Next
        For Each name In Request.Form.AllKeys
            Dim control As String = Request.Form.Item(name.ToString).ToString
            If UCase(control).Contains("SLEEP") Or UCase(control).Contains("SELECT") Or UCase(control).Contains("UPDATE") Or UCase(control).Contains("INSERT") Or UCase(control).Contains("DELETE") Or UCase(control).Contains("<") Or UCase(control).Contains("SCRIPT") Then
                Response.Redirect("0.html")
            End If
        Next
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim engine As New CABAL___Engine.Class1
        Dim username As String = TextBox1.Text
        If engine.CheckNull(username) = "KO" Then
            Session.Item("result") = "Insert username"
            Response.Redirect("Result.aspx")
        End If
        Dim password As String = TextBox2.Text
        If engine.CheckNull(password) = "KO" Then
            Session.Item("result") = "Insert password"
            Response.Redirect("Result.aspx")
        End If
        Session.Item("result") = username & ";" & password
        Response.Redirect("Result.aspx")
    End Sub
End Class
