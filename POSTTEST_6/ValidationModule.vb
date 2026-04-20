Imports System.Windows.Forms

Public Module ValidationModule

    ' ===============================
    ' INPUT RESTRICTION
    ' ===============================

    ' Hanya huruf & spasi
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' Hanya angka
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===============================
    ' VALIDASI UMUM
    ' ===============================

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    ' ===============================
    ' VALIDASI PRODUK HOTWHEELS 🔥
    ' ===============================

    Public Function ValidasiProduk(ep As ErrorProvider,
                                  txtNama As TextBox,
                                  txtSeri As TextBox,
                                  txtHarga As TextBox,
                                  txtStok As TextBox,
                                  txtTahun As TextBox,
                                  cbKategori As ComboBox) As Boolean

        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama produk wajib diisi!")
        Dim seriValid As Boolean = ValidasiTextBox(ep, txtSeri, "Seri wajib diisi!")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga wajib diisi!")
        Dim stokValid As Boolean = ValidasiTextBox(ep, txtStok, "Stok wajib diisi!")
        Dim tahunValid As Boolean = ValidasiTextBox(ep, txtTahun, "Tahun wajib diisi!")
        Dim kategoriValid As Boolean = ValidasiComboBox(ep, cbKategori, "Pilih kategori dulu!")

        ' Validasi tambahan angka
        Dim hargaAngka As Boolean = IsNumeric(txtHarga.Text)
        Dim stokAngka As Boolean = IsNumeric(txtStok.Text)
        Dim tahunAngka As Boolean = IsNumeric(txtTahun.Text)

        If Not hargaAngka Then ep.SetError(txtHarga, "Harga harus angka!")
        If Not stokAngka Then ep.SetError(txtStok, "Stok harus angka!")
        If Not tahunAngka Then ep.SetError(txtTahun, "Tahun harus angka!")

        ' Validasi panjang tahun
        Dim tahunValidLength As Boolean = txtTahun.Text.Length = 4
        If Not tahunValidLength Then ep.SetError(txtTahun, "Format tahun harus 4 digit!")

        Return namaValid And seriValid And hargaValid And stokValid And tahunValid And kategoriValid And
               hargaAngka And stokAngka And tahunAngka And tahunValidLength
    End Function

    ' ===============================
    ' HELPER
    ' ===============================

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)
    End Function

End Module