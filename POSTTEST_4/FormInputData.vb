Public Class FormInputData
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Me.Show()
    End Sub

    Function AmbilCheckbox(parent As Control) As String
        Dim hasil As String = ""

        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hasil &= ctrl.Text & ", "
                End If
            End If

            If ctrl.HasChildren Then
                hasil &= AmbilCheckbox(ctrl)
            End If
        Next

        Return hasil
    End Function

    Private Sub SimpanData()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Dim sw As New IO.StreamWriter(sfd.FileName)

            sw.WriteLine(txtNama.Text)
            sw.WriteLine(txtID.Text)
            sw.WriteLine(dtpTanggalLahir.Value.ToShortDateString())

            Dim jk As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")
            sw.WriteLine(jk)

            sw.WriteLine(cmbKomunitas.Text)

            sw.WriteLine(mtxtTelepon.Text)
            sw.WriteLine(txtEmail.Text)
            sw.WriteLine(txtAlamat.Text)

            Dim peran As String = ""
            If rbKetua.Checked Then peran = "Ketua"
            If rbAnggota.Checked Then peran = "Anggota"
            If rbAdmin.Checked Then peran = "Admin"
            sw.WriteLine(peran)

            Dim aktivitas As String = ""
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is CheckBox Then
                    If CType(ctrl, CheckBox).Checked Then
                        aktivitas &= ctrl.Text & ","
                    End If
                End If
            Next

            sw.WriteLine(AmbilCheckbox(Me))

            sw.Close()
            MessageBox.Show("Data lengkap berhasil disimpan")
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SimpanData()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim f2 As New FormIDCard
        f2.Show()
    End Sub

    Function ResetCheckbox(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If

            If ctrl.HasChildren Then
                ResetCheckbox(ctrl)
            End If
        Next
    End Function

    Function SetCheckbox(parent As Control, listAktivitas() As String)
        For Each ctrl As Control In parent.Controls

            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)

                For Each item In listAktivitas
                    If cb.Text.Trim() = item.Trim() Then
                        cb.Checked = True
                    End If
                Next
            End If

            If ctrl.HasChildren Then
                SetCheckbox(ctrl, listAktivitas)
            End If

        Next
    End Function

    Private Sub BukaData()
        Dim ofd As New OpenFileDialog

        If ofd.ShowDialog = DialogResult.OK Then
            Dim sr As New IO.StreamReader(ofd.FileName)

            txtNama.Text = sr.ReadLine()
            txtID.Text = sr.ReadLine()
            dtpTanggalLahir.Value = Date.Parse(sr.ReadLine())

            Dim jk = sr.ReadLine()
            If jk = "Laki-laki" Then
                rbLaki.Checked = True
            Else
                rbPerempuan.Checked = True
            End If

            cmbKomunitas.Text = sr.ReadLine()

            mtxtTelepon.Text = sr.ReadLine()
            txtEmail.Text = sr.ReadLine()
            txtAlamat.Text = sr.ReadLine()

            Dim peran = sr.ReadLine()
            If peran = "Ketua" Then rbKetua.Checked = True
            If peran = "Anggota" Then rbAnggota.Checked = True
            If peran = "Admin" Then rbAdmin.Checked = True

            ResetCheckbox(Me)
            Dim aktivitas As String = sr.ReadLine()
            Dim listAktivitas() As String = aktivitas.Split(","c)
            SetCheckbox(Me, listAktivitas)

            sr.Close()
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        BukaData()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtxtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function AdaCheckboxDicentang(parent As Control) As Boolean
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    Return True
                End If
            End If

            If ctrl.HasChildren Then
                If AdaCheckboxDicentang(ctrl) Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    Function Validasi() As Boolean
        If txtNama.Text = "" Or txtID.Text = "" Or mtxtTelepon.Text.Contains("_") Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If cmbKomunitas.Text = "" Then
            MessageBox.Show("Pilih komunitas")
            Return False
        End If

        Dim cek As Boolean = False
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then cek = True
            End If
        Next

        If Not AdaCheckboxDicentang(Me) Then
            MessageBox.Show("Pilih minimal 1 aktivitas")
            Return False
        End If

        Return True
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not Validasi() Then Exit Sub
        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim f2 As New FormIDCard

            f2.lblNama.Text = txtNama.Text
            f2.lblID.Text = txtID.Text
            f2.lblKomunitas.Text = cmbKomunitas.Text

            f2.lblKontak.Text = mtxtTelepon.Text & " , " & txtEmail.Text

            f2.lblAktivitas.Text = AmbilCheckbox(Me)

            f2.pbFoto.Image = pbFoto.Image

            f2.Show()
        End If
    End Sub
End Class
