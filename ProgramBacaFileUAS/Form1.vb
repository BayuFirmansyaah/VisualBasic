Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = TextBox2.Text
        Dim delimiter As Char = "."
        Dim substrings As String() = path.Split(delimiter)
        Dim lastIndex As Integer = substrings.Length - 1

        If substrings(lastIndex) <> "txt" Then
            RichTextBox1.Text = "Format document diwajibkan dalam bentuk .txt"
        Else
            Dim reader As StreamReader = New StreamReader(path)
            Dim content As String = reader.ReadToEnd()
            RichTextBox1.Text = content
            reader.Close()
        End If
    End Sub
End Class
