
Partial Class Risultato
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session.Item("Risultato")
        Session.Clear()
    End Sub
End Class
