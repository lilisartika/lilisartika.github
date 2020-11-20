<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblInfoWaktu = New System.Windows.Forms.Label()
        Me.BtnPengembalian = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPeminjaman = New System.Windows.Forms.Button()
        Me.BtnPeminjam = New System.Windows.Forms.Button()
        Me.BtnRak = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.BtnBuku = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1/2 Perpustakaan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblInfoWaktu
        '
        Me.LblInfoWaktu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblInfoWaktu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblInfoWaktu.Location = New System.Drawing.Point(12, 230)
        Me.LblInfoWaktu.Name = "LblInfoWaktu"
        Me.LblInfoWaktu.Size = New System.Drawing.Size(316, 35)
        Me.LblInfoWaktu.TabIndex = 2
        Me.LblInfoWaktu.Text = "Informasi Waktu"
        Me.LblInfoWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnPengembalian
        '
        Me.BtnPengembalian.Image = Global.Perpustakaan.My.Resources.Resources.repeat
        Me.BtnPengembalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPengembalian.Location = New System.Drawing.Point(334, 230)
        Me.BtnPengembalian.Name = "BtnPengembalian"
        Me.BtnPengembalian.Size = New System.Drawing.Size(111, 35)
        Me.BtnPengembalian.TabIndex = 10
        Me.BtnPengembalian.Text = "Pengembalian"
        Me.BtnPengembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPengembalian.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perpustakaan.My.Resources.Resources.books_clipart
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BtnPeminjaman
        '
        Me.BtnPeminjaman.Image = Global.Perpustakaan.My.Resources.Resources.shopping_cart
        Me.BtnPeminjaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjaman.Location = New System.Drawing.Point(334, 189)
        Me.BtnPeminjaman.Name = "BtnPeminjaman"
        Me.BtnPeminjaman.Size = New System.Drawing.Size(111, 35)
        Me.BtnPeminjaman.TabIndex = 9
        Me.BtnPeminjaman.Text = "Peminjaman"
        Me.BtnPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjaman.UseVisualStyleBackColor = True
        '
        'BtnPeminjam
        '
        Me.BtnPeminjam.Image = Global.Perpustakaan.My.Resources.Resources.user
        Me.BtnPeminjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeminjam.Location = New System.Drawing.Point(334, 53)
        Me.BtnPeminjam.Name = "BtnPeminjam"
        Me.BtnPeminjam.Size = New System.Drawing.Size(111, 35)
        Me.BtnPeminjam.TabIndex = 8
        Me.BtnPeminjam.Text = "Peminjam"
        Me.BtnPeminjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPeminjam.UseVisualStyleBackColor = True
        '
        'BtnRak
        '
        Me.BtnRak.Image = Global.Perpustakaan.My.Resources.Resources.folder
        Me.BtnRak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRak.Location = New System.Drawing.Point(334, 12)
        Me.BtnRak.Name = "BtnRak"
        Me.BtnRak.Size = New System.Drawing.Size(111, 35)
        Me.BtnRak.TabIndex = 7
        Me.BtnRak.Text = "Rak"
        Me.BtnRak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRak.UseVisualStyleBackColor = True
        '
        'BtnKategori
        '
        Me.BtnKategori.Image = Global.Perpustakaan.My.Resources.Resources.tag
        Me.BtnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKategori.Location = New System.Drawing.Point(217, 53)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Size = New System.Drawing.Size(111, 35)
        Me.BtnKategori.TabIndex = 6
        Me.BtnKategori.Text = "Kategori"
        Me.BtnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKategori.UseVisualStyleBackColor = True
        '
        'BtnBuku
        '
        Me.BtnBuku.Image = Global.Perpustakaan.My.Resources.Resources.page
        Me.BtnBuku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuku.Location = New System.Drawing.Point(217, 12)
        Me.BtnBuku.Name = "BtnBuku"
        Me.BtnBuku.Size = New System.Drawing.Size(111, 35)
        Me.BtnBuku.TabIndex = 5
        Me.BtnBuku.Text = "Buku"
        Me.BtnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuku.UseVisualStyleBackColor = True
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 279)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnPengembalian)
        Me.Controls.Add(Me.BtnPeminjaman)
        Me.Controls.Add(Me.BtnPeminjam)
        Me.Controls.Add(Me.BtnRak)
        Me.Controls.Add(Me.BtnKategori)
        Me.Controls.Add(Me.BtnBuku)
        Me.Controls.Add(Me.LblInfoWaktu)
        Me.Controls.Add(Me.Label1)
        Me.MinimizeBox = False
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblInfoWaktu As System.Windows.Forms.Label
    Friend WithEvents BtnBuku As System.Windows.Forms.Button
    Friend WithEvents BtnKategori As System.Windows.Forms.Button
    Friend WithEvents BtnRak As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjam As System.Windows.Forms.Button
    Friend WithEvents BtnPeminjaman As System.Windows.Forms.Button
    Friend WithEvents BtnPengembalian As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
