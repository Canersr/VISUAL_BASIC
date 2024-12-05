Public Class Form1

    Public Function sifre_yarat(seviye)

        Dim sifre As String
        sifre = ""

        Dim rastgele As New Random
        Dim i As Integer
        Dim dizi As Char() = "QWERTYUIOPASDFGHJKLZXCVBNM".ToArray()

        For i = 1 To seviye

            sifre = sifre + dizi(rastgele.Next(dizi.Count()))
        Next
        TextBox1.Text = sifre
        Return sifre
    End Function
    Public seviye As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("lütfen bir seçim yapınız", "0", "UYARI")
            Exit Sub 'RETURN ile aynı işlevi yapıyor.

        End If

        If ComboBox1.SelectedIndex = 0 Then

            seviye = 4
        End If
        If ComboBox1.SelectedIndex = 1 Then
            seviye = 8

        End If
        If ComboBox1.SelectedIndex = 2 Then
            seviye = 12

        End If
        sifre_yarat(seviye)

    End Sub
End Class
