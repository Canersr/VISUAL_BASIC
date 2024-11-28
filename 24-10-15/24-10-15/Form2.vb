Imports System.IO
Public Class Form2

    Dim dosya As StreamWriter
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        dosya = File.AppendText("bilgiler.txt")
        dosya.WriteLine(ComboBox1.SelectedItem)
        dosya.Close()
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)

    End Sub
    Dim i As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To 10
            ComboBox1.Items.Add(i * 2)
        Next i


    End Sub
End Class