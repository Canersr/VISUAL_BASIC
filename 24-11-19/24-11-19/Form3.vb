Public Class Form3

    Private Sub KESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KESToolStripMenuItem.Click

    End Sub

    Private Sub FARKLIKAYDETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FARKLIKAYDETToolStripMenuItem.Click

        MsgBox("CANER SURMELIOGLU", 0, "UYARI")

    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            MsgBox("MERHABA")
        End If
        If e.KeyData = Keys.F6 Then
            MsgBox("CANER SÜRMELİOĞLU")
        End If
    End Sub
End Class