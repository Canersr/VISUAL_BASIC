Public Class Form1

    Dim soru As New DialogResult


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        soru = MessageBox.Show("ÇIKIŞ YAPILSIN MI ?", "KAPAT", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If (soru = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If




    End Sub
    Dim git As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'MsgBox("ÇIKIŞ YAPILIYOR")
        git = MsgBox("ÇIKIŞ YAPILSIN MI ?", 4 + 48 + 256, "KAPAT")

        If (git = 6) Then
            Application.Exit()

        else
        MsgBox("aaaaaaaa")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Form2.ShowDialog()
        Dim goster As New Form2
        goster.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (TextBox1.Text = "") Then
            MsgBox("adini giriniz")
            TextBox1.Select()
        ElseIf (TextBox2.Text = "") Then
            MsgBox("soyadını girinz")
            TextBox2.Select()
        Else
            TextBox3.Text = TextBox1.Text + " " + TextBox2.Text
            Label1.Text = TextBox1.Text + " " + TextBox2.Text
            MsgBox(TextBox1.Text + " " + TextBox2.Text)

            temizle()
        End If






    End Sub
    Sub temizle()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Select()
        Label1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button4.PerformClick()
        'Button4_Click(sender,e)

    End Sub
End Class
