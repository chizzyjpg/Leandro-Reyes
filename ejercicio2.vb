Public Class Form1
    Dim contador#
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim num As Integer
        num = Val(txtNumero.Text)
        If txtNumero.Text > -1 And txtNumero.Text < 101 Then
            ListBox1.Items.Add(txtNumero.Text)
            contador += Val(txtNumero.Text)
            txtPorcentaje.Text = Math.Round(contador / Val(ListBox1.Items.Count), 2)
            'MsgBox(contador)
        Else
            MsgBox("Ingrece un número entre 1 y 100")
        End If
        txtNumero.Clear()
        txtNumero.Focus()
    End Sub
End Class
