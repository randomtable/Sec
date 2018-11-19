Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function AESE(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Dim ciphertext As String = ""
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = input
            Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
        End Try
    End Function

    Public Function AESD(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = input
            Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
        End Try
    End Function

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Dim encrypted As String = Convert.ToBase64String(AESE(System.Text.Encoding.ASCII.GetBytes(TextBox2.Text), TextBox1.Text))
            TextBox3.Text = encrypted
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            Dim decrypted As String = System.Text.Encoding.ASCII.GetString(AESD(Convert.FromBase64String(TextBox3.Text), TextBox1.Text))
            TextBox2.Text = decrypted
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
            Dim encrypted As String = Convert.ToBase64String(AESE(My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName), TextBox1.Text))
            SaveFileDialog1.ShowDialog()
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, encrypted, False)
            MsgBox("Operazione completata.")
        Else
            MsgBox("Attenzione! Immettere un file valido!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
        If My.Computer.FileSystem.FileExists(OpenFileDialog2.FileName) Then
            Dim decrypted As Byte() = AESD(Convert.FromBase64String(My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileName)), TextBox1.Text)
            SaveFileDialog2.ShowDialog()
            My.Computer.FileSystem.WriteAllBytes(SaveFileDialog2.FileName, decrypted, False)
            MsgBox("Operazione completata.")
        Else
            MsgBox("Attenzione! Immettere un file valido!")
        End If
    End Sub
End Class
