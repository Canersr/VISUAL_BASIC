Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim taksittarihi As DateTime

        taksittarihi = DateTime.Now()

        For i = 1 To Form1.taksitsayisi
            taksittarihi = DateTime.Now.AddMonths(i)

            If (taksittarihi.DayOfWeek = DayOfWeek.Saturday) Then
                taksittarihi = taksittarihi.AddDays(2)
            End If
            If (taksittarihi.DayOfWeek = DayOfWeek.Sunday) Then
                taksittarihi = taksittarihi.AddDays(1)
            End If
            ListBox1.Items.Add(taksittarihi.ToLongDateString + ":" + Form1.tutar.ToString("C2"))
        Next
        Label1.Text = " Toplamda " & Form1.taksitsayisi & " ay taksit ve " & Form1.miktar & " ödemeniz vardır"
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        'Form1.TextBox1.Clear()
        'Form1.RadioButton1.Checked = False
        'Form1.RadioButton2.Checked = False
        'Form1.RadioButton3.Checked = False         //closed ve closeing fark etmeksezin ikisinde de çalışıyor
        'Form1.RadioButton4.Checked = False
        'Form1.RadioButton5.Checked = False
        'Form1.RadioButton6.Checked = False

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form1.TextBox1.Clear()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton4.Checked = False
        Form1.RadioButton5.Checked = False
        Form1.RadioButton6.Checked = False

    End Sub
End Class