<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtBukuTambah = New TextBox()
        txtGenre = New TextBox()
        txtBukuDihapus = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        dgvBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(95, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tambah Buku"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 1
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(95, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 2
        Label3.Text = "Genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(439, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Hapus Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(439, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 4
        Label5.Text = "Judul Buku"
        ' 
        ' txtBukuTambah
        ' 
        txtBukuTambah.Location = New Point(180, 78)
        txtBukuTambah.Name = "txtBukuTambah"
        txtBukuTambah.Size = New Size(175, 27)
        txtBukuTambah.TabIndex = 5
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(180, 122)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(175, 27)
        txtGenre.TabIndex = 6
        ' 
        ' txtBukuDihapus
        ' 
        txtBukuDihapus.Location = New Point(524, 78)
        txtBukuDihapus.Name = "txtBukuDihapus"
        txtBukuDihapus.Size = New Size(175, 27)
        txtBukuDihapus.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(261, 186)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(605, 186)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.Anchor = AnchorStyles.Top
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvBuku.BackgroundColor = SystemColors.Window
        dgvBuku.BorderStyle = BorderStyle.None
        dgvBuku.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvBuku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvBuku.Location = New Point(261, 263)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersVisible = False
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(300, 148)
        dgvBuku.TabIndex = 10
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Daftar Buku"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(800, 450)
        Controls.Add(dgvBuku)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(txtBukuDihapus)
        Controls.Add(txtGenre)
        Controls.Add(txtBukuTambah)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBukuTambah As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtBukuDihapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn

End Class
