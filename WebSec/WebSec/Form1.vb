Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            Dim codice As String = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            If codice.Contains("<filteringRules>") Then
                codice = codice.Replace("<filteringRules>", Rules.RichTextBox2.Text)
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, codice, False)
                MsgBox("Operazione completata")
                Exit Sub
            Else
                If codice.Contains("<requestFiltering>") Then
                    codice = codice.Replace("<requestFiltering>", Rules.RichTextBox3.Text)
                    My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, codice, False)
                    MsgBox("Operazione completata")
                    Exit Sub
                Else
                    If codice.Contains("<security>") Then
                        codice = codice.Replace("<security>", Rules.RichTextBox4.Text)
                        My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, codice, False)
                        MsgBox("Operazione completata")
                        Exit Sub
                    Else
                        If codice.Contains("<system.webServer>") Then
                            codice = codice.Replace("<system.webServer>", Rules.RichTextBox5.Text)
                            My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, codice, False)
                            MsgBox("Operazione completata")
                            Exit Sub
                        Else
                            If codice.Contains("<configuration>") Then
                                codice = codice.Replace("<configuration>", Rules.RichTextBox6.Text)
                                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, codice, False)
                                MsgBox("Operazione completata")
                                Exit Sub
                            Else
                                MsgBox("Attenzione. Controllare manualmente il file web.config e riprovare")
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Per favore, seleziona un file valido.")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\web.config") Then
            MsgBox("Attenzione, il file di configurazione esiste già. Impossibile proseguire.")
        Else
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\web.config", Rules.RichTextBox1.Text, False)
            MsgBox("Operazione completata")
        End If
    End Sub
End Class
