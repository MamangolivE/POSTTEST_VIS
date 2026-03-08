Public Class Form1
    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
        jumlahBuku += 1
    End Sub

    Private Function CariBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).ToLower.Contains(judul.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtBukuTambah.Text
        Dim genre As String = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!")
            Exit Sub
        End If
        TambahBuku(judul, genre)
        TampilkanData()
        txtBukuTambah.Clear()
        txtGenre.Clear()
        dgvBuku.ClearSelection()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtBukuDihapus.Text
        Dim index As Integer = CariBuku(judul)

        If index = -1 Then
            MessageBox.Show("Buku tidak ditemukan")
            Exit Sub
        End If
        For i As Integer = index To jumlahBuku - 2
            daftarBuku(i) = daftarBuku(i + 1)
        Next
        jumlahBuku -= 1
        TampilkanData()
        txtBukuDihapus.Clear()
        dgvBuku.ClearSelection()
    End Sub

    Private Sub TampilkanData()
        dgvBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvBuku.Rows.Add(daftarBuku(i))
        Next
    End Sub
End Class
