Imports System
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object,
                           ByVal e As System.EventArgs) Handles MyBase.Load
        Dim stickyFileDirectory As String = Application.StartupPath

        TextBox1.Text = stickyFileDirectory

        Try
            Dim readText() As String = File.ReadAllLines("H:\Visual Studio 2015\Projects\VB.Net-File-Reader-Writer-master\StickyNotes\TestFile.txt")
            Dim s As String
            Dim stickyText As String = ""
            For Each s In readText
                stickyText = stickyText + s
            Next
            TextBox1.Text = TextBox1.Text + vbNewLine + stickyText
        Catch
            TextBox1.Text = "File error"
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender as Object, e as FormClosingEventArgs) _ 
        Handles MyBase.FormClosing

        File.WriteAllText(("H:\Visual Studio 2015\Projects\VB.Net-File-Reader-Writer-master\StickyNotes\TestFile.txt"), TextBox1.Text)

    End Sub
End Class
