Imports MySqlConnector

Module DataModule
    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT p.id_produk, p.nama_produk, p.seri, p.harga, p.stok, p.tahun_rilis, p.foto, k.nama_kategori 
                               FROM produk p JOIN kategori k ON p.id_kategori = k.id_kategori ORDER BY p.id_produk ASC"
        Try
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dt
    End Function

    Public Function SimpanProduk(nama As String, seri As String, harga As Integer, stok As Integer, tahun As Integer, foto As String, kategori As Integer) As Boolean
        Dim query As String = "INSERT INTO produk (nama_produk, seri, harga, stok, tahun_rilis, foto, id_kategori) " &
                              "VALUES (@nama, @seri, @harga, @stok, @tahun, @foto, @kategori)"

        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@seri", seri)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@foto", foto)
                    cmd.Parameters.AddWithValue("@kategori", kategori)

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function UpdateProduk(id As Integer, nama As String, seri As String, harga As Integer, stok As Integer, tahun As Integer, foto As String, kategori As Integer) As Boolean
        Dim query As String = "UPDATE produk SET nama_produk=@nama, seri=@seri, harga=@harga, stok=@stok, tahun_rilis=@tahun, foto=@foto, id_kategori=@kategori WHERE id_produk=@id"

        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@seri", seri)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@foto", foto)
                    cmd.Parameters.AddWithValue("@kategori", kategori)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusProduk(id As Integer) As Boolean
        Dim query As String = "DELETE FROM produk WHERE id_produk=@id"

        Try
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function GetKategori() As DataTable
        Dim dt As New DataTable
        Try
            Using conn = GetConnection()
                Dim query As String = "SELECT id_kategori, nama_kategori FROM kategori"

                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal load kategori: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchProduk(keyword As String) As DataTable
        Dim dt As New DataTable
        Try
            Using conn = GetConnection()
                Dim query As String = "SELECT p.id_produk, p.nama_produk, p.seri, p.harga, p.stok, p.tahun_rilis, p.foto, k.nama_kategori
                                       FROM produk p JOIN kategori k ON p.id_kategori = k.id_kategori 
                                       WHERE p.nama_produk LIKE @cari OR p.seri LIKE @cari"

                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@cari", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal search: " & ex.Message)
        End Try
        Return dt
    End Function
End Module
