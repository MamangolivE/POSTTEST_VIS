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
        lblIPK = New Label()
        nilaiIPK = New Label()
        txtIP = New TextBox()
        btnTambah = New Button()
        lblPredikat = New Label()
        Label1 = New Label()
        btnReset = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(351, 134)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(41, 20)
        lblIPK.TabIndex = 0
        lblIPK.Text = "IPK : "
        ' 
        ' nilaiIPK
        ' 
        nilaiIPK.AutoSize = True
        nilaiIPK.Location = New Point(414, 134)
        nilaiIPK.Name = "nilaiIPK"
        nilaiIPK.Size = New Size(17, 20)
        nilaiIPK.TabIndex = 1
        nilaiIPK.Text = "0"
        ' 
        ' txtIP
        ' 
        txtIP.Location = New Point(411, 218)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(73, 27)
        txtIP.TabIndex = 2
        txtIP.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(411, 262)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(114, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(416, 179)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(15, 20)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "-"
        lblPredikat.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(318, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 5
        Label1.Text = "Predikat : "
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Red
        btnReset.Location = New Point(278, 262)
        btnReset.Margin = New Padding(0)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(114, 29)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseCompatibleTextRendering = True
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(298, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 7
        Label2.Text = "IP Semester : "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(btnReset)
        Controls.Add(Label1)
        Controls.Add(lblPredikat)
        Controls.Add(btnTambah)
        Controls.Add(txtIP)
        Controls.Add(nilaiIPK)
        Controls.Add(lblIPK)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPK As Label
    Friend WithEvents nilaiIPK As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblPredikat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label

End Class
