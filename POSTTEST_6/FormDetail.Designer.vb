<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
        lblNama = New Label()
        lblSeri = New Label()
        lblHarga = New Label()
        lblTahun = New Label()
        label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        pbFotoDetail = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        lblKategori = New Label()
        Label7 = New Label()
        lblStok = New Label()
        CType(pbFotoDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Black
        lblNama.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(462, 81)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(97, 28)
        lblNama.TabIndex = 0
        lblNama.Text = "Label1"
        ' 
        ' lblSeri
        ' 
        lblSeri.AutoSize = True
        lblSeri.BackColor = Color.Black
        lblSeri.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        lblSeri.ForeColor = Color.White
        lblSeri.Location = New Point(462, 141)
        lblSeri.MaximumSize = New Size(400, 0)
        lblSeri.Name = "lblSeri"
        lblSeri.Size = New Size(102, 28)
        lblSeri.TabIndex = 4
        lblSeri.Text = "Label2"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = Color.Black
        lblHarga.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        lblHarga.ForeColor = Color.White
        lblHarga.Location = New Point(514, 201)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(102, 28)
        lblHarga.TabIndex = 1
        lblHarga.Text = "Label3"
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.BackColor = Color.Black
        lblTahun.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        lblTahun.ForeColor = Color.White
        lblTahun.Location = New Point(466, 264)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(104, 28)
        lblTahun.TabIndex = 3
        lblTahun.Text = "Label4"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Black
        label1.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        label1.ForeColor = Color.White
        label1.Location = New Point(291, 81)
        label1.Name = "label1"
        label1.Size = New Size(192, 28)
        label1.TabIndex = 4
        label1.Text = "Nama           :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Black
        Label2.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(291, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 28)
        Label2.TabIndex = 5
        Label2.Text = "Seri             :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Magneto", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(291, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 28)
        Label3.TabIndex = 6
        Label3.Text = "Harga          :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(291, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 28)
        Label4.TabIndex = 7
        Label4.Text = "Tahun Rilis   :"
        ' 
        ' pbFotoDetail
        ' 
        pbFotoDetail.BackColor = Color.Gainsboro
        pbFotoDetail.Location = New Point(25, 72)
        pbFotoDetail.Name = "pbFotoDetail"
        pbFotoDetail.Size = New Size(228, 279)
        pbFotoDetail.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoDetail.TabIndex = 8
        pbFotoDetail.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(464, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 28)
        Label5.TabIndex = 9
        Label5.Text = "Rp."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Black
        Label6.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(291, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(190, 28)
        Label6.TabIndex = 10
        Label6.Text = "Kategori       :"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.BackColor = Color.Black
        lblKategori.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKategori.ForeColor = Color.White
        lblKategori.Location = New Point(462, 323)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(100, 28)
        lblKategori.TabIndex = 11
        lblKategori.Text = "Label7"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Black
        Label7.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(82, 354)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 28)
        Label7.TabIndex = 12
        Label7.Text = "Stok :"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.BackColor = Color.Black
        lblStok.Font = New Font("Magneto", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStok.ForeColor = Color.White
        lblStok.Location = New Point(163, 354)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(103, 28)
        lblStok.TabIndex = 13
        lblStok.Text = "Label8"
        ' 
        ' FormDetail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.f82402f4fcf70c4b12e3af6d65959a6f
        ClientSize = New Size(800, 450)
        Controls.Add(lblStok)
        Controls.Add(Label7)
        Controls.Add(lblKategori)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(pbFotoDetail)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(label1)
        Controls.Add(lblTahun)
        Controls.Add(lblHarga)
        Controls.Add(lblSeri)
        Controls.Add(lblNama)
        Name = "FormDetail"
        Text = "FormDetail"
        CType(pbFotoDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblSeri As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbFotoDetail As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblStok As Label
End Class
