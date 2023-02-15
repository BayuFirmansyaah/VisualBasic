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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Content = RichTextBox1.Text
        Dim delimiter As Char = " "
        Dim substrings As String() = Content.Split(delimiter)
        Dim Key As String = TextBox1.Text
        Dim count_key As Integer = 0

        For Each Data As String In substrings
            If Data = Key Then
                count_key += 1
            End If
        Next

        Label4.Text = $"{count_key} Jumlah suku kata ditemukan"


    End Sub


End Class
