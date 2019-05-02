
Partial Class _Default
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
        Response.Redirect("GraphicEngine.aspx")
    End Sub
End Class
