Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Dim ad, soyad As String
    Dim fark, gelir, gider As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text.Trim() = "") Then
            MsgBox("LUTFEN ADI BILGISINI GIRINIZ", 0, "HATA")
            Exit Sub
        End If
        If (TextBox2.Text.Trim() = "") Then
            MsgBox("LUTFEN SOYADI BILGISINI GIRINIZ", 0, "HATA")

            Exit Sub
        End If

        If (TextBox3.Text = "" Or TextBox4.Text = "") Then
            MsgBox("LUTFEN GELIR VE GIDER BILGILERINI GIRINIZ", 0, "HATA")


        End If
        ad = TextBox1.Text.Trim
        soyad = TextBox2.Text.Trim
        gelir = CInt(TextBox3.Text)
        gider = Convert.ToInt32(TextBox4.Text)
        fark = gelir - gider
        'ListBox1.Items.Add(ad + " " + soyad + " " & fark)  'tür dönüşümü için + yerine & koyuyoruz
        ListBox1.Items.Add(ad + " " + soyad + " " + fark.ToString("C2"))  'C2 TL SİMGESİ

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Select()





    End Sub
End Class