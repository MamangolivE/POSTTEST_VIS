<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIDCard
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
        pbFoto = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblKontak = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        lblAktivitas = New Label()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.White
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(42, 89)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(195, 251)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(392, 124)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 23)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(392, 164)
        lblID.Name = "lblID"
        lblID.Size = New Size(68, 23)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        lblKomunitas.ForeColor = Color.White
        lblKomunitas.Location = New Point(392, 206)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(68, 23)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Label3"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        lblKontak.ForeColor = Color.White
        lblKontak.Location = New Point(391, 248)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(68, 23)
        lblKontak.TabIndex = 4
        lblKontak.Text = "Label4"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(280, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 5
        Label1.Text = "Nama         :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(283, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 23)
        Label2.TabIndex = 6
        Label2.Text = "ID              :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(280, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 23)
        Label3.TabIndex = 7
        Label3.Text = "Komunitas :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(282, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 23)
        Label4.TabIndex = 8
        Label4.Text = "Kontak      :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Fierce_black_stallion_logo2
        PictureBox1.Location = New Point(573, -149)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(351, 535)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(283, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 23)
        Label5.TabIndex = 10
        Label5.Text = "Aktivitas   :"
        ' 
        ' lblAktivitas
        ' 
        lblAktivitas.AutoSize = True
        lblAktivitas.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAktivitas.ForeColor = Color.White
        lblAktivitas.Location = New Point(391, 291)
        lblAktivitas.MaximumSize = New Size(400, 0)
        lblAktivitas.Name = "lblAktivitas"
        lblAktivitas.Size = New Size(68, 23)
        lblAktivitas.TabIndex = 11
        lblAktivitas.Text = "Label6"
        ' 
        ' FormIDCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(800, 450)
        Controls.Add(lblAktivitas)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblKontak)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFoto)
        Controls.Add(PictureBox1)
        Name = "FormIDCard"
        Text = "FormIDCard"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAktivitas As Label
End Class
