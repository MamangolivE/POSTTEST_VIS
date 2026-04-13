Imports MySqlConnector
Imports System.IO

Public Class FormKelola
    Dim selectedID As String = ""
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=dbHotWheels")
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

    Function ValidasiInput() As Boolean
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!")
            txtNama.Focus()
            Return False
        End If

        If txtSeri.Text.Trim() = "" Then
            MessageBox.Show("Seri tidak boleh kosong!")
            txtSeri.Focus()
            Return False
        End If

        If txtHarga.Text.Trim() = "" Then
            MessageBox.Show("Harga tidak boleh kosong!")
            txtHarga.Focus()
            Return False
        End If

        If txtStok.Text.Trim() = "" Then
            MessageBox.Show("Stok tidak boleh kosong!")
            txtStok.Focus()
            Return False
        End If

        If txtTahun.Text.Trim() = "" Then
            MessageBox.Show("Tahun tidak boleh kosong!")
            txtTahun.Focus()
            Return False
        End If

        If fotoPath = "" Then
            MessageBox.Show("Foto belum dipilih!")
            Return False
        End If

        Return True
    End Function

    Sub TampilData()
        Try
            Dim da As New MySqlDataAdapter("SELECT * FROM produk", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvProduk.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FormKelola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
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
        If Not ValidasiInput() Then
            Exit Sub
        End If
        Try
            conn.Open()

            Dim query As String = "INSERT INTO produk (nama_produk, seri, harga, stok, tahun_rilis, foto) VALUES (@nama,@seri,@harga,@stok,@tahun,@foto)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@seri", txtSeri.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@stok", txtStok.Text)
            cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
            cmd.Parameters.AddWithValue("@foto", fotoPath)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil ditambahkan")
            TampilData()
            ClearInput()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            selectedID = dgvProduk.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
        If e.RowIndex >= 0 Then
            Dim i As Integer = e.RowIndex

            txtID.Text = dgvProduk.Rows(i).Cells(1).Value.ToString()
            txtNama.Text = dgvProduk.Rows(i).Cells(1).Value.ToString()
            txtSeri.Text = dgvProduk.Rows(i).Cells(2).Value.ToString()
            txtHarga.Text = dgvProduk.Rows(i).Cells(3).Value.ToString()
            txtStok.Text = dgvProduk.Rows(i).Cells(4).Value.ToString()
            txtTahun.Text = dgvProduk.Rows(i).Cells(5).Value.ToString()

            pbFoto.ImageLocation = dgvProduk.Rows(i).Cells(6).Value.ToString()
            fotoPath = pbFoto.ImageLocation
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If selectedID = "" Then
                MessageBox.Show("Pilih data dulu!")
                Exit Sub
            End If
            If Not ValidasiInput() Then Exit Sub
            conn.Open()

            Dim query As String = "UPDATE produk SET nama_produk=@nama, seri=@seri, harga=@harga, stok=@stok, tahun_rilis=@tahun, foto=@foto WHERE id_produk=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", selectedID)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@seri", txtSeri.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@stok", txtStok.Text)
            cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
            cmd.Parameters.AddWithValue("@foto", fotoPath)

            Dim result As Integer = cmd.ExecuteNonQuery()
            conn.Close()

            If result > 0 Then
                MessageBox.Show("Data berhasil diupdate")
            Else
                MessageBox.Show("Data gagal diupdate!")
            End If

            TampilData()
            ClearInput()
            selectedID = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If selectedID = "" Then
                MessageBox.Show("Pilih data dulu!")
                Exit Sub
            End If
            If MessageBox.Show("Yakin mau hapus?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                conn.Open()
                Dim query As String = "DELETE FROM produk WHERE id_produk=@id"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", selectedID)

                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Data berhasil dihapus")

                TampilData()
                ClearInput()
                selectedID = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim query As String = "SELECT * FROM produk WHERE nama_produk LIKE @cari OR seri LIKE @cari"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@cari", "%" & txtSearch.Text & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvProduk.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub ClearInput()
        txtNama.Clear()
        txtSeri.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtTahun.Clear()
        pbFoto.Image = Nothing
        fotoPath = ""
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
        f3.pbFotoDetail.ImageLocation = fotoPath

        f3.Show()
    End Sub
End Class