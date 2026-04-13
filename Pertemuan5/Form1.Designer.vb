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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKodeJenis = New TextBox()
        txtJenis = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kode Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 2
        Label3.Text = "Cari Buku"
        ' 
        ' txtKodeJenis
        ' 
        txtKodeJenis.Location = New Point(102, 12)
        txtKodeJenis.Name = "txtKodeJenis"
        txtKodeJenis.PlaceholderText = "Kode Jenis"
        txtKodeJenis.Size = New Size(393, 27)
        txtKodeJenis.TabIndex = 3
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(102, 45)
        txtJenis.Name = "txtJenis"
        txtJenis.PlaceholderText = "Jenis"
        txtJenis.Size = New Size(393, 27)
        txtJenis.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(102, 78)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Buku"
        txtSearch.Size = New Size(393, 27)
        txtSearch.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(17, 126)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(145, 126)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(271, 126)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(401, 126)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(17, 174)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.RowHeadersWidth = 51
        dgvJenis.Size = New Size(478, 264)
        dgvJenis.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 450)
        Controls.Add(dgvJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtJenis)
        Controls.Add(txtKodeJenis)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
