<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelola
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtNama = New TextBox()
        txtSeri = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtTahun = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TabControl1 = New TabControl()
        tcTambahProduk = New TabPage()
        cbKategori = New ComboBox()
        txtID = New TextBox()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        btnUpdate = New Button()
        btnTambah = New Button()
        btnClear = New Button()
        tcDataProduk = New TabPage()
        btnDetail = New Button()
        Label8 = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        btnHapus = New Button()
        dgvProduk = New DataGridView()
        MenuStrip1 = New MenuStrip()
        KelolaProdukToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1.SuspendLayout()
        tcTambahProduk.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        tcDataProduk.SuspendLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.WhiteSmoke
        txtNama.Location = New Point(147, 69)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(219, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtSeri
        ' 
        txtSeri.BackColor = Color.WhiteSmoke
        txtSeri.Location = New Point(147, 102)
        txtSeri.Name = "txtSeri"
        txtSeri.Size = New Size(219, 27)
        txtSeri.TabIndex = 2
        ' 
        ' txtHarga
        ' 
        txtHarga.BackColor = Color.WhiteSmoke
        txtHarga.Location = New Point(147, 135)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(219, 27)
        txtHarga.TabIndex = 3
        ' 
        ' txtStok
        ' 
        txtStok.BackColor = Color.WhiteSmoke
        txtStok.Location = New Point(147, 168)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(219, 27)
        txtStok.TabIndex = 4
        ' 
        ' txtTahun
        ' 
        txtTahun.BackColor = Color.WhiteSmoke
        txtTahun.Location = New Point(147, 201)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(219, 27)
        txtTahun.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(574, 33)
        Label1.TabIndex = 6
        Label1.Text = "Sistem Manajemen Produk HotWheels"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(33, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 8
        Label3.Text = "Nama Mobil"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(33, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 9
        Label4.Text = "Seri HotWheels"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(33, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 10
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.White
        Label6.Location = New Point(33, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 11
        Label6.Text = "Stok Produk"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(33, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 12
        Label7.Text = "Tahun Rilis"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcTambahProduk)
        TabControl1.Controls.Add(tcDataProduk)
        TabControl1.Location = New Point(12, 74)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 364)
        TabControl1.TabIndex = 13
        ' 
        ' tcTambahProduk
        ' 
        tcTambahProduk.BackColor = Color.WhiteSmoke
        tcTambahProduk.BackgroundImage = My.Resources.Resources.hot_wheels_background_1920_x_1080_nrrcx2xu6csycly7
        tcTambahProduk.BackgroundImageLayout = ImageLayout.Stretch
        tcTambahProduk.Controls.Add(cbKategori)
        tcTambahProduk.Controls.Add(txtID)
        tcTambahProduk.Controls.Add(btnBrowse)
        tcTambahProduk.Controls.Add(pbFoto)
        tcTambahProduk.Controls.Add(btnUpdate)
        tcTambahProduk.Controls.Add(btnTambah)
        tcTambahProduk.Controls.Add(btnClear)
        tcTambahProduk.Controls.Add(Label7)
        tcTambahProduk.Controls.Add(txtNama)
        tcTambahProduk.Controls.Add(Label6)
        tcTambahProduk.Controls.Add(txtSeri)
        tcTambahProduk.Controls.Add(Label5)
        tcTambahProduk.Controls.Add(txtHarga)
        tcTambahProduk.Controls.Add(Label4)
        tcTambahProduk.Controls.Add(txtStok)
        tcTambahProduk.Controls.Add(Label3)
        tcTambahProduk.Controls.Add(txtTahun)
        tcTambahProduk.Location = New Point(4, 29)
        tcTambahProduk.Name = "tcTambahProduk"
        tcTambahProduk.Padding = New Padding(3)
        tcTambahProduk.Size = New Size(768, 331)
        tcTambahProduk.TabIndex = 0
        tcTambahProduk.Text = "Tambah Produk"
        ' 
        ' cbKategori
        ' 
        cbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cbKategori.FormattingEnabled = True
        cbKategori.Location = New Point(372, 69)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(151, 28)
        cbKategori.TabIndex = 18
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(147, 36)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID"
        txtID.Size = New Size(43, 27)
        txtID.TabIndex = 17
        txtID.Visible = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkBlue
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(591, 230)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 16
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.WhiteSmoke
        pbFoto.Location = New Point(552, 36)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(170, 188)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 15
        pbFoto.TabStop = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(261, 253)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Green
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(372, 253)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 14
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Brown
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(147, 253)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' tcDataProduk
        ' 
        tcDataProduk.BackgroundImage = My.Resources.Resources.hot_wheels_background_1920_x_1080_nrrcx2xu6csycly7
        tcDataProduk.BackgroundImageLayout = ImageLayout.Stretch
        tcDataProduk.Controls.Add(btnDetail)
        tcDataProduk.Controls.Add(Label8)
        tcDataProduk.Controls.Add(btnSearch)
        tcDataProduk.Controls.Add(txtSearch)
        tcDataProduk.Controls.Add(btnHapus)
        tcDataProduk.Controls.Add(dgvProduk)
        tcDataProduk.Location = New Point(4, 29)
        tcDataProduk.Name = "tcDataProduk"
        tcDataProduk.Padding = New Padding(3)
        tcDataProduk.Size = New Size(768, 331)
        tcDataProduk.TabIndex = 1
        tcDataProduk.Text = "Data Produk"
        tcDataProduk.UseVisualStyleBackColor = True
        ' 
        ' btnDetail
        ' 
        btnDetail.BackColor = Color.DodgerBlue
        btnDetail.ForeColor = Color.White
        btnDetail.Location = New Point(549, 296)
        btnDetail.Name = "btnDetail"
        btnDetail.Size = New Size(94, 29)
        btnDetail.TabIndex = 7
        btnDetail.Text = "Detail"
        btnDetail.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.White
        Label8.Location = New Point(6, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 20)
        Label8.TabIndex = 6
        Label8.Text = "cari produk :"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(336, 6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(103, 8)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Nama Mobil/Seri HotWheels"
        txtSearch.Size = New Size(227, 27)
        txtSearch.TabIndex = 5
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.DarkRed
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(668, 296)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 1
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' dgvProduk
        ' 
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(15, 41)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 51
        dgvProduk.Size = New Size(738, 249)
        dgvProduk.TabIndex = 0
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DodgerBlue
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {KelolaProdukToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 14
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' KelolaProdukToolStripMenuItem
        ' 
        KelolaProdukToolStripMenuItem.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KelolaProdukToolStripMenuItem.ForeColor = Color.White
        KelolaProdukToolStripMenuItem.Name = "KelolaProdukToolStripMenuItem"
        KelolaProdukToolStripMenuItem.Size = New Size(158, 24)
        KelolaProdukToolStripMenuItem.Text = "Kelola Produk"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.BackColor = Color.Brown
        KeluarToolStripMenuItem.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KeluarToolStripMenuItem.ForeColor = Color.White
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(87, 24)
        KeluarToolStripMenuItem.Text = "LogOut"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormKelola
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.hot_wheels_background_1920_x_1080_nrrcx2xu6csycly7
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormKelola"
        Text = "FormKelola"
        TabControl1.ResumeLayout(False)
        tcTambahProduk.ResumeLayout(False)
        tcTambahProduk.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        tcDataProduk.ResumeLayout(False)
        tcDataProduk.PerformLayout()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtSeri As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcTambahProduk As TabPage
    Friend WithEvents tcDataProduk As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KelolaProdukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnDetail As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbKategori As ComboBox
End Class
