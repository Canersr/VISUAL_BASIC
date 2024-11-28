Imports System.IO

Public Class Form1
    Dim dosya As StreamWriter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("LUTFEN ADINIZI VE SOYADINIZI GIRINIZ", 0, "HATA")
        Else
            dosya = File.AppendText("bilgiler.txt")
            dosya.WriteLine(TextBox1.Text & " " & TextBox2.Text)
            dosya.WriteLine("-------------------")
            dosya.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("BILGILER BASARIYLA KAYDEDILMISTIR", 0, "KAYIT BASARILI")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim soru 'sorunun tipini dosyayı okuyup kendisi algılıyor string veya int yazmaya gerek yok


        soru = MsgBox("KAYIT YAPILSIN MI ?", 4)
        If (soru = 6) Then
            ListBox1.Items.Clear()
            Dim dosya2 = File.ReadLines("bilgiler.txt")
            For Each okunan As String In dosya2
                ListBox1.Items.Add(okunan)
            Next
      

        End If





       


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dosya3 As New StreamReader("bilgiler.txt")
        Dim veriler = dosya3.ReadToEnd()
        ListBox2.Items.Add(veriler)
        RichTextBox1.Text = (veriler)
    End Sub
End Class
