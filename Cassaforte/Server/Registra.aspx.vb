﻿
Partial Class Registra
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim engine As New CABAL___Engine.Class1
        Dim email As String = TextBox1.Text
        If engine.CheckEmail(email) = "KO" Then
            Session.Item("Risultato") = "Attenzione! Immettere un indirizzo e-mail valido!"
            Response.Redirect("Risultato.aspx")
        End If
        Dim password As String = TextBox2.Text
        If engine.CheckPassword(password) = "KO" Then
            Session.Item("Risultato") = "Attenzione! Immettere una password valida!"
            Response.Redirect("Risultato.aspx")
        End If
    End Sub
End Class
