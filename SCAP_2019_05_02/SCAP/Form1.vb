Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProcessDirADMX(Application.StartupPath & "\January 2019 DISA STIG GPO Package")
        ProcessDirENUS(Application.StartupPath & "\January 2019 DISA STIG GPO Package")
        ProcessDirGPOS()
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

    Public Sub ProcessDirGPOS()

        Process.Start("LGPO.bat").WaitForExit()
        MsgBox("DONE! Restart your computer for configurations take effects!")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Activate()
        Form2.Show()
        Me.Close()
    End Sub
End Class
