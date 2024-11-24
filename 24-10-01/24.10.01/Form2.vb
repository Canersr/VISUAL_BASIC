Public Class Form2

    Dim sayi, fakt, i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fakt = 1
        If (TextBox1.Text = "") Then
            MsgBox("LUTFEN SAYIYI GIRINIZ")
            Exit Sub
        End If
        sayi = CInt(TextBox1.Text)

        If (sayi < 0) Then
            'sayi *= -1
            sayi = Math.Abs(sayi)

        End If

        If (sayi > 1 And sayi < 10) Then
            For i = 1 To sayi
                fakt *= i

            Next
            MsgBox("sonuc :" & fakt)
        Else
            MsgBox("selam hocaya çay")
        End If

    End Sub
    Sub hesapla()
        fakt = 1
        If (TextBox1.Text = "") Then
            MsgBox("LUTFEN SAYIYI GIRINIZ")
            Exit Sub
        End If
        sayi = CInt(TextBox1.Text)

        If (sayi < 0) Then
            'sayi *= -1
            sayi = Math.Abs(sayi)

        End If

        If (sayi > 1 And sayi < 10) Then
            For i = 1 To sayi
                fakt *= i

            Next
            MsgBox("sonuc :" & fakt)
        Else
            MsgBox("selam hocaya çay")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        hesapla()

    End Sub

    Function busefer(sayi)
        fakt = 1
        For i = 1 To sayi
            fakt *= i
        Next
        Return fakt
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sayi = CInt(TextBox1.Text)
        Label3.Text = "Islemin sonucu : " & busefer(sayi)

    End Sub
    Sub faktoriel()
        fakt = 1
        For i = 1 To sayi
            fakt *= i
        Next
        Label4.Text = "İşlemin sonucu : " & fakt
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sayi = CInt(TextBox1.Text)
        faktoriel()
    End Sub
End Class