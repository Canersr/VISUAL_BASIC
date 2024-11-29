

Public Class Form1
    'NEW ifadesi nesnelerin içine yazılmaz 

    Public miktar As Integer
    Public taksitsayisi As Integer
    Public tutar As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text.Trim() = "") Then
            MsgBox("LUTFEN TUTARI GIRINIZ", 0, "hata")
        End If

        miktar = TextBox1.Text.Trim()
        If (RadioButton1.Checked) Then taksitsayisi = 2
        If (RadioButton2.Checked) Then taksitsayisi = 3
        If (RadioButton3.Checked) Then taksitsayisi = 4
        If (RadioButton4.Checked) Then taksitsayisi = 5
        If (RadioButton5.Checked) Then taksitsayisi = 6
        If (RadioButton6.Checked) Then taksitsayisi = 7

        tutar = Math.Round((miktar / taksitsayisi), 2)


        Dim secim As DialogResult
        secim = MessageBox.Show(miktar.ToString("C2") + "olan ödemenizi " +
                              tutar.ToString("C2") + "olacak şekilde " + taksitsayisi.ToString() +
                              "ay taksitlendirme yapmak istiyormusunz?", "Onaylama", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If (secim = Windows.Forms.DialogResult.Yes) Then
            Dim Form2 As New Form2()
            Form2.ShowDialog()
        Else
            MessageBox.Show("İşlem iptal edilmiştir", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1)
            TextBox1.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            Exit Sub
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Char.IsLetter(e.KeyChar)
    End Sub
End Class
