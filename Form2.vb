Public Class Form2
    'Konversi Mata Uang Lain ke Rupiah
 
    Private Sub rumus2()
        Dim IDR As Integer
        If txtMataUang.Text = "USD" And txtIDR.Text = "Rupiah" Then
            IDR = Val(txtMataUang.Text) * 14115
        ElseIf txtMataUang.Text = "Poundsterling" And txtIDR.Text = "Rupiah" Then
            IDR = Val(txtMataUang.Text) * 18373
        ElseIf txtMataUang.Text = "Euro" And txtIDR.Text = "Rupiah" Then
            IDR = Val(txtMataUang.Text) * 15977
        End If
        txtIDR.Text = IDR
    End Sub
 
    Private Sub btnKonversikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonversikan.Click
        If txtMataUang.Text = "" Then
            MsgBox("Anda belum menginput nominal uangnya. Silahkan input kembali.", vbInformation + vbRetryCancel, "Peringatan")
        End If
        Call rumus2()
    End Sub
 
    Private Sub txtIDR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDR.TextChanged
        Call rumus2()
    End Sub
End Class
