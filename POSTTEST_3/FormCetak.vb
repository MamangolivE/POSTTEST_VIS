Public Class FormCetak
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim ofd As New OpenFileDialog

        ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If ofd.ShowDialog = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
        End If

    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If pbFoto.Image Is Nothing Then
            MessageBox.Show("Foto harus diupload")
            Exit Sub
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        If Not cbMembaca.Checked And Not cbGaming.Checked And Not cbOlahraga.Checked And Not cbMusik.Checked And Not cbTravel.Checked Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Exit Sub
        End If

        Dim hobby As String = ""

        If cbMembaca.Checked Then hobby &= "Membaca "
        If cbGaming.Checked Then hobby &= "Gaming "
        If cbOlahraga.Checked Then hobby &= "Olahraga "
        If cbMusik.Checked Then hobby &= "Musik "
        If cbTravel.Checked Then hobby &= "Travel "

        Dim gender As String = If(rbLaki.Checked, "Laki-Laki", "Perempuan")

        Dim f As New Form2

        f.pbFotoHasil.Image = pbFoto.Image
        f.lblNama.Text = txtNama.Text
        f.lblUmur.Text = txtUmur.Text
        f.lblTelp.Text = txtTelp.Text
        f.lblAlamat.Text = txtAlamat.Text
        f.lblGender.Text = gender
        f.lblHobi.Text = hobby
        f.lblLahir.Text = dtpLahir.Value.ToShortDateString()

        f.Show()

    End Sub
End Class
