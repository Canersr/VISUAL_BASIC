Imports System.IO


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Clear()

        ComboBox1.Items.Add("CANER")
        ComboBox1.Items.Add("SÜRMELİOĞLU")
        ComboBox1.Items.Add("SR")
        ComboBox1.Sorted = True


    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress

        If (e.KeyChar > Chr(47) And e.KeyChar < Chr(58) Or e.KeyChar = Chr(8)) Then
            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            TextBox2.Select()
        End If



        If (e.KeyChar > Chr(64) Or e.KeyChar < Chr(91) And e.KeyChar = Chr(8)) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked = True) Then
            TextBox4.PasswordChar = "*"
        Else
            TextBox4.PasswordChar = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim harfler() = {"A", "B", "C"}
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange(harfler)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()

        ListBox1.Items.AddRange(File.ReadAllLines("renkler.txt", System.Text.Encoding.Default))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox3.Items.Clear()

        Dim takım() As String = New String() {"GALATASARAY", "fb", "bjk"}
        For Each veriler As String In takım
            ComboBox3.Items.Add(veriler)

        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ComboBox4.Items.Clear()

        For i = 1 To 5
            ComboBox4.Items.Add(Choose(i, "FIRIN", "OCAK", "DOLAP", "ÜTÜ", "ÇORAP"))
        Next
        ComboBox4.Sorted = True


    End Sub
End Class
