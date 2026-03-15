<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        pbFoto = New PictureBox()
        btnBrowse = New Button()
        dtpLahir = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        gbHobi = New GroupBox()
        cbTravel = New CheckBox()
        cbMusik = New CheckBox()
        cbOlahraga = New CheckBox()
        cbGaming = New CheckBox()
        cbMembaca = New CheckBox()
        Label6 = New Label()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        btnCetak = New Button()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        gbHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.Location = New Point(453, 39)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(277, 27)
        txtNama.TabIndex = 0
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.White
        txtUmur.Location = New Point(453, 72)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(277, 27)
        txtUmur.TabIndex = 1
        ' 
        ' txtTelp
        ' 
        txtTelp.BackColor = Color.White
        txtTelp.Location = New Point(453, 138)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(277, 27)
        txtTelp.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(453, 171)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(277, 27)
        txtAlamat.TabIndex = 3
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.White
        pbFoto.Location = New Point(23, 28)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(303, 372)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 5
        pbFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkBlue
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(125, 406)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 6
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(453, 105)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(277, 27)
        dtpLahir.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(353, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 8
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(353, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 9
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(350, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 10
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(353, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 11
        Label4.Text = "No. Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(353, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 12
        Label5.Text = "Alamat"
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.Transparent
        gbHobi.Controls.Add(cbTravel)
        gbHobi.Controls.Add(cbMusik)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbMembaca)
        gbHobi.Location = New Point(353, 218)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(250, 182)
        gbHobi.TabIndex = 13
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(126, 109)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(70, 24)
        cbTravel.TabIndex = 4
        cbTravel.Text = "Travel"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(126, 60)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(17, 131)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 2
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(17, 85)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 1
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(17, 35)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(609, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 14
        Label6.Text = "Jenis Kelamin"
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(609, 252)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 15
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(609, 302)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 16
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LimeGreen
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(671, 392)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(117, 43)
        btnCetak.TabIndex = 17
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetak)
        Controls.Add(rbPerempuan)
        Controls.Add(rbLaki)
        Controls.Add(Label6)
        Controls.Add(gbHobi)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpLahir)
        Controls.Add(btnBrowse)
        Controls.Add(pbFoto)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Name = "FormCetak"
        Text = "Form1"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents btnCetak As Button

End Class
