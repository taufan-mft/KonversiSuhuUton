Public Class Form1
    'Konversi Rupiah ke Mata Uang lain
    'yang aku bingung aku tulis di komen ya ton
 
    Private Sub rumus()
        Dim hasil As Integer
        If txtIDR.Text = "IDR" And txtHasil.Text = "USD" Then  'ini berarti isi txtIDR = "IDR" kan ton
            hasil = Val(txtIDR.Text) / 14115 'terus ini kenapa nilai txtIDR, yaitu "IDR", dimasukkin rumus? harusnya kan angka. jadi aku menyarankan kode kaya di halaman paling bawah
        ElseIf txtIDR.Text = "IDR" And txtHasil.Text = "Poundsterling" Then
            hasil = Val(txtIDR.Text) / 18373
        ElseIf txtIDR.Text = "IDR" And txtHasil.Text = "Euro" Then
            hasil = Val(txtIDR.Text) / 15977
        End If
        txtHasil.Text = hasil
    End Sub
 
    Private Sub btnKonversikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonversikan.Click
        If txtIDR.Text = "" Then
            MsgBox("Anda belum menginput nominal uangnya. Silahkan input kembali.", vbInformation + vbOKOnly, "Peringatan")
        End If
        Call rumus()
    End Sub
 
    Private Sub mmKonversilain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmKonversilain.Click
        Form2.Show()
    End Sub
 
    Private Sub mmExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmExit.Click
        If MsgBox("Anda yakin mau keluar?", vbQuestion + vbYesNo, "Konfirmasi") = vbYes Then
        End If
    End Sub
 
    Private Sub mmHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmHelp.Click
        MsgBox("Program ini dirancang untuk mengkonversi mata uang IDR menjadi mata uang lain. Caranya dengan memasukkan senilai uang pada kolom 'IDR', kemudian memilih nilai mata uang yang ingin dikonversi, lalu dengan mengklik 'Konversikan' hasilnya akan keluar pada kolom 'Hasil'.", vbInformation + vbOKOnly, "Bantuan")
    End Sub
 
    Private Sub txtHasil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasil.TextChanged
        Call rumus()
    End Sub
End Class

-----------------------------------------------
Kode yang saya propose kepada uton:

'Kita punya textbox buat masukin nilai kita kasih nama txtNilai

 Private Sub rumus()
        Dim hasil As Integer
    nilai = txtNilai.Text
        If txtIDR.Text = "IDR" And txtHasil.Text = "USD" Then  
        hasil = txtNilai.Text / 14115 
        ElseIf txtIDR.Text = "IDR" And txtHasil.Text = "Poundsterling" Then
        hasil = txtNilai.Text / 18373
        ElseIf txtIDR.Text = "IDR" And txtHasil.Text = "Euro" Then
        hasil = txtNilai.Text / 15977
        End If
        txtHasil.Text = hasil
    End Sub

