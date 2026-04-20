Imports MySqlConnector
Imports System.IO

Public Class FormKelola
    Dim selectedID As String = ""
    Dim fotoPath As String = ""

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin mau logout?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            FormLogin.txtUsername.Clear()
            FormLogin.txtPassword.Clear()
            FormLogin.Show()

            Me.Close()
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTahun.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub TampilData()
        Using conn = GetConnection()
            dgvProduk.DataSource = GetAllProduk()
            dgvProduk.Columns("id_produk").Visible = False
            dgvProduk.Columns("foto").Visible = False
        End Using
    End Sub

    Private Sub FormKelola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        LoadKategori()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim namaFile As String = Path.GetFileName(ofd.FileName)
            Dim folderTujuan As String = Application.StartupPath & "\images\"

            If Not Directory.Exists(folderTujuan) Then
                Directory.CreateDirectory(folderTujuan)
            End If
            Dim pathTujuan As String = folderTujuan & namaFile
            File.Copy(ofd.FileName, pathTujuan, True)
            fotoPath = "images/" & namaFile

            pbFoto.ImageLocation = pathTujuan
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiProduk(ErrorProvider1, txtNama, txtSeri, txtHarga, txtStok, txtTahun, cbKategori) Then
            Exit Sub
        End If
        Using conn = GetConnection()
            Try
                SimpanProduk(txtNama.Text, txtSeri.Text, CInt(txtHarga.Text), CInt(txtStok.Text), CInt(txtTahun.Text), fotoPath,
                             cbKategori.SelectedValue)

                MessageBox.Show("Data berhasil ditambahkan")
                TampilData()
                ClearInput()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            selectedID = dgvProduk.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
        If e.RowIndex >= 0 Then
            Dim row = dgvProduk.Rows(e.RowIndex)

            selectedID = row.Cells("id_produk").Value
            txtNama.Text = row.Cells("nama_produk").Value.ToString()
            txtSeri.Text = row.Cells("seri").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()
            txtStok.Text = row.Cells("stok").Value.ToString()
            txtTahun.Text = row.Cells("tahun_rilis").Value.ToString()
            cbKategori.Text = row.Cells("nama_kategori").Value.ToString()

            pbFoto.ImageLocation = row.Cells("foto").Value.ToString()
            fotoPath = pbFoto.ImageLocation
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using conn = GetConnection()
            Try
                If selectedID = "" Then
                    MessageBox.Show("Pilih data dulu!")
                    Exit Sub
                End If
                If Not ValidasiProduk(ErrorProvider1, txtNama, txtSeri, txtHarga, txtStok, txtTahun, cbKategori) Then
                    Exit Sub
                End If
                If UpdateProduk(selectedID, txtNama.Text, txtSeri.Text, CInt(txtHarga.Text), CInt(txtStok.Text),
                                CInt(txtTahun.Text), fotoPath, cbKategori.SelectedValue) Then
                    MessageBox.Show("Data berhasil diupdate")
                    TampilData()
                    ClearInput()
                End If
                selectedID = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Using conn = GetConnection()
            Try
                If selectedID = "" Then
                    MessageBox.Show("Pilih data dulu!")
                    Exit Sub
                End If
                If MessageBox.Show("Yakin mau hapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If HapusProduk(selectedID) Then
                        MessageBox.Show("Data berhasil dihapus")
                        TampilData()
                        ClearInput()
                    End If
                    selectedID = ""
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using conn = GetConnection()
            dgvProduk.DataSource = SearchProduk(txtSearch.Text)
        End Using
    End Sub

    Sub ClearInput()
        txtNama.Clear()
        txtSeri.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtTahun.Clear()
        cbKategori.SelectedIndex = -1
        pbFoto.Image = Nothing
        fotoPath = ""
        selectedID = ""
        ErrorProvider1.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        Dim f3 As New FormDetail


        f3.lblNama.Text = txtNama.Text
        f3.lblSeri.Text = txtSeri.Text
        f3.lblHarga.Text = txtHarga.Text
        f3.lblTahun.Text = txtTahun.Text
        f3.lblStok.Text = txtStok.Text
        f3.lblKategori.Text = cbKategori.Text
        f3.pbFotoDetail.ImageLocation = fotoPath

        f3.Show()
    End Sub

    Sub LoadKategori()
        Dim dt As DataTable = GetKategori()

        cbKategori.DataSource = dt
        cbKategori.DisplayMember = "nama_kategori"
        cbKategori.ValueMember = "id_kategori"
    End Sub
End Class