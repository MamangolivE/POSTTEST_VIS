<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputData
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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        tcDataUtama = New TabPage()
        Label1 = New Label()
        cmbKomunitas = New ComboBox()
        GroupBox1 = New GroupBox()
        txtNama = New TextBox()
        rbPerempuan = New RadioButton()
        txtID = New TextBox()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        tcKontak = New TabPage()
        Label2 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtTelepon = New MaskedTextBox()
        tcProfil = New TabPage()
        GroupBox3 = New GroupBox()
        cbCatur = New CheckBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbMusik = New CheckBox()
        cbFutsal = New CheckBox()
        cbBadminton = New CheckBox()
        GroupBox2 = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        btnSimpanCetak = New Button()
        cbMembaca = New CheckBox()
        cbBasket = New CheckBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tcDataUtama.SuspendLayout()
        GroupBox1.SuspendLayout()
        tcKontak.SuspendLayout()
        tcProfil.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightGray
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.BackColor = Color.Silver
        InputDataToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(98, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.BackColor = Color.Silver
        LihatKartuToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(101, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.BackColor = Color.Silver
        SimpanDataToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(112, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.BackColor = Color.Silver
        BukaDataToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(95, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.BackColor = Color.Firebrick
        KeluarToolStripMenuItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        KeluarToolStripMenuItem.ForeColor = Color.White
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(68, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblJudul.Location = New Point(28, 32)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(305, 41)
        lblJudul.TabIndex = 1
        lblJudul.Text = "KARTU KOMUNITAS"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.Fierce_black_stallion_logo
        PictureBox1.Location = New Point(12, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(336, 353)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcDataUtama)
        TabControl1.Controls.Add(tcKontak)
        TabControl1.Controls.Add(tcProfil)
        TabControl1.Location = New Point(370, 76)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(408, 289)
        TabControl1.TabIndex = 3
        ' 
        ' tcDataUtama
        ' 
        tcDataUtama.BackColor = Color.Silver
        tcDataUtama.BorderStyle = BorderStyle.FixedSingle
        tcDataUtama.Controls.Add(Label1)
        tcDataUtama.Controls.Add(cmbKomunitas)
        tcDataUtama.Controls.Add(GroupBox1)
        tcDataUtama.Location = New Point(4, 29)
        tcDataUtama.Name = "tcDataUtama"
        tcDataUtama.Padding = New Padding(3)
        tcDataUtama.Size = New Size(400, 256)
        tcDataUtama.TabIndex = 0
        tcDataUtama.Text = "Data Utama"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(6, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 7
        Label1.Text = "Komunitas"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.BackColor = Color.WhiteSmoke
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Gaming", "Musik", "Coding", "Sport", "Catur"})
        cmbKomunitas.Location = New Point(6, 218)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(266, 28)
        cmbKomunitas.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Controls.Add(txtID)
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Controls.Add(dtpTanggalLahir)
        GroupBox1.Location = New Point(6, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(387, 168)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Biodata"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.WhiteSmoke
        txtNama.Location = New Point(26, 38)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(230, 27)
        txtNama.TabIndex = 0
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(162, 137)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.WhiteSmoke
        txtID.Location = New Point(26, 71)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID"
        txtID.Size = New Size(230, 27)
        txtID.TabIndex = 1
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(26, 137)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(26, 104)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(257, 27)
        dtpTanggalLahir.TabIndex = 2
        dtpTanggalLahir.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        ' 
        ' tcKontak
        ' 
        tcKontak.BackColor = Color.Silver
        tcKontak.Controls.Add(Label2)
        tcKontak.Controls.Add(txtAlamat)
        tcKontak.Controls.Add(txtEmail)
        tcKontak.Controls.Add(mtxtTelepon)
        tcKontak.Location = New Point(4, 29)
        tcKontak.Name = "tcKontak"
        tcKontak.Padding = New Padding(3)
        tcKontak.Size = New Size(400, 256)
        tcKontak.TabIndex = 1
        tcKontak.Text = "Kontak"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 5
        Label2.Text = "No. HP:"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.WhiteSmoke
        txtAlamat.Location = New Point(86, 77)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(234, 98)
        txtAlamat.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.WhiteSmoke
        txtEmail.Location = New Point(86, 181)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(234, 27)
        txtEmail.TabIndex = 1
        ' 
        ' mtxtTelepon
        ' 
        mtxtTelepon.BackColor = Color.WhiteSmoke
        mtxtTelepon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        mtxtTelepon.Location = New Point(150, 44)
        mtxtTelepon.Mask = "0000-0000-0000"
        mtxtTelepon.Name = "mtxtTelepon"
        mtxtTelepon.Size = New Size(170, 27)
        mtxtTelepon.TabIndex = 0
        ' 
        ' tcProfil
        ' 
        tcProfil.BackColor = Color.Silver
        tcProfil.Controls.Add(GroupBox3)
        tcProfil.Controls.Add(GroupBox2)
        tcProfil.Controls.Add(btnBrowse)
        tcProfil.Controls.Add(pbFoto)
        tcProfil.Location = New Point(4, 29)
        tcProfil.Name = "tcProfil"
        tcProfil.Padding = New Padding(3)
        tcProfil.Size = New Size(400, 256)
        tcProfil.TabIndex = 2
        tcProfil.Text = "Profil & Aktivitas"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(cbBasket)
        GroupBox3.Controls.Add(cbMembaca)
        GroupBox3.Controls.Add(cbCatur)
        GroupBox3.Controls.Add(cbGaming)
        GroupBox3.Controls.Add(cbCoding)
        GroupBox3.Controls.Add(cbMusik)
        GroupBox3.Controls.Add(cbFutsal)
        GroupBox3.Controls.Add(cbBadminton)
        GroupBox3.Location = New Point(140, 86)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(254, 164)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Pilih Aktivitas"
        ' 
        ' cbCatur
        ' 
        cbCatur.AutoSize = True
        cbCatur.Location = New Point(137, 95)
        cbCatur.Name = "cbCatur"
        cbCatur.Size = New Size(66, 24)
        cbCatur.TabIndex = 8
        cbCatur.Text = "Catur"
        cbCatur.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(36, 26)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 3
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(36, 61)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 5
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(137, 26)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 4
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbFutsal
        ' 
        cbFutsal.AutoSize = True
        cbFutsal.Location = New Point(36, 95)
        cbFutsal.Name = "cbFutsal"
        cbFutsal.Size = New Size(69, 24)
        cbFutsal.TabIndex = 7
        cbFutsal.Text = "Futsal"
        cbFutsal.UseVisualStyleBackColor = True
        ' 
        ' cbBadminton
        ' 
        cbBadminton.AutoSize = True
        cbBadminton.Location = New Point(137, 61)
        cbBadminton.Name = "cbBadminton"
        cbBadminton.Size = New Size(104, 24)
        cbBadminton.TabIndex = 6
        cbBadminton.Text = "Badminton"
        cbBadminton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbAdmin)
        GroupBox2.Controls.Add(rbAnggota)
        GroupBox2.Controls.Add(rbKetua)
        GroupBox2.Location = New Point(140, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(254, 69)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Peran"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(178, 31)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(74, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(84, 31)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(10, 31)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(68, 24)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkBlue
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(23, 167)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.WhiteSmoke
        pbFoto.Location = New Point(6, 13)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(128, 148)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.ForestGreen
        btnSimpanCetak.ForeColor = Color.White
        btnSimpanCetak.Location = New Point(504, 367)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(150, 35)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan dan Cetak"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(36, 131)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 9
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbBasket
        ' 
        cbBasket.AutoSize = True
        cbBasket.Location = New Point(137, 131)
        cbBasket.Name = "cbBasket"
        cbBasket.Size = New Size(74, 24)
        cbBasket.TabIndex = 10
        cbBasket.Text = "Basket"
        cbBasket.UseVisualStyleBackColor = True
        ' 
        ' FormInputData
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(800, 450)
        Controls.Add(btnSimpanCetak)
        Controls.Add(TabControl1)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        MainMenuStrip = MenuStrip1
        Name = "FormInputData"
        Text = "Input Data"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tcDataUtama.ResumeLayout(False)
        tcDataUtama.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tcKontak.ResumeLayout(False)
        tcKontak.PerformLayout()
        tcProfil.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tcDataUtama As TabPage
    Friend WithEvents tcKontak As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mtxtTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tcProfil As TabPage
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbCatur As CheckBox
    Friend WithEvents cbFutsal As CheckBox
    Friend WithEvents cbBadminton As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBasket As CheckBox

End Class
