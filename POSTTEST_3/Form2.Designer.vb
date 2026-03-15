<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        pbFotoHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblLahir = New Label()
        lblTelp = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        lblGender = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoHasil
        ' 
        pbFotoHasil.BackColor = Color.LightCyan
        pbFotoHasil.BackgroundImageLayout = ImageLayout.None
        pbFotoHasil.Location = New Point(24, 23)
        pbFotoHasil.Name = "pbFotoHasil"
        pbFotoHasil.Size = New Size(300, 402)
        pbFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoHasil.TabIndex = 0
        pbFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 12F)
        lblNama.Location = New Point(502, 113)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(72, 28)
        lblNama.TabIndex = 1
        lblNama.Text = "*Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 12F)
        lblUmur.Location = New Point(502, 154)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(69, 28)
        lblUmur.TabIndex = 2
        lblUmur.Text = "*Umur"
        ' 
        ' lblLahir
        ' 
        lblLahir.AutoSize = True
        lblLahir.Font = New Font("Segoe UI", 12F)
        lblLahir.Location = New Point(502, 193)
        lblLahir.Name = "lblLahir"
        lblLahir.Size = New Size(72, 28)
        lblLahir.TabIndex = 3
        lblLahir.Text = "*TglLhr"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Font = New Font("Segoe UI", 12F)
        lblTelp.Location = New Point(502, 239)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(55, 28)
        lblTelp.TabIndex = 4
        lblTelp.Text = "*Telp"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 12F)
        lblAlamat.Location = New Point(502, 281)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(82, 28)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "*Alamat"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Font = New Font("Segoe UI", 12F)
        lblHobi.Location = New Point(358, 397)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(63, 28)
        lblHobi.TabIndex = 6
        lblHobi.Text = "*Hobi"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 12F)
        lblGender.Location = New Point(502, 320)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(84, 28)
        lblGender.TabIndex = 7
        lblGender.Text = "*Gender"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        Label1.Location = New Point(347, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(429, 31)
        Label1.TabIndex = 8
        Label1.Text = "==KARTU TANDA PENGENAL=="
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        Label2.Location = New Point(463, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 31)
        Label2.TabIndex = 9
        Label2.Text = "ARYAKARTA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(358, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 10
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(358, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 28)
        Label4.TabIndex = 11
        Label4.Text = "Umur"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(358, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 28)
        Label5.TabIndex = 12
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(358, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 28)
        Label6.TabIndex = 13
        Label6.Text = "No. Telepon"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(358, 281)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 28)
        Label7.TabIndex = 14
        Label7.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(358, 320)
        Label8.Name = "Label8"
        Label8.Size = New Size(128, 28)
        Label8.TabIndex = 15
        Label8.Text = "Jenis Kelamin"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(358, 363)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 28)
        Label9.TabIndex = 16
        Label9.Text = "Hobi:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblGender)
        Controls.Add(lblHobi)
        Controls.Add(lblAlamat)
        Controls.Add(lblTelp)
        Controls.Add(lblLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pbFotoHasil)
        Name = "Form2"
        Text = "Form2"
        CType(pbFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblLahir As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
