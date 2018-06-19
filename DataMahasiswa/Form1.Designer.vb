<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsemester = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtuts = New System.Windows.Forms.TextBox()
        Me.txtekt2 = New System.Windows.Forms.TextBox()
        Me.txtuas = New System.Windows.Forms.TextBox()
        Me.txtekt1 = New System.Windows.Forms.TextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.txtgrade = New System.Windows.Forms.TextBox()
        Me.txtrata = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtprodi = New System.Windows.Forms.TextBox()
        Me.txtfakultas = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbkategori = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1297, 661)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btn_batal)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtsemester)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtuts)
        Me.TabPage1.Controls.Add(Me.txtekt2)
        Me.TabPage1.Controls.Add(Me.txtuas)
        Me.TabPage1.Controls.Add(Me.txtekt1)
        Me.TabPage1.Controls.Add(Me.btnproses)
        Me.TabPage1.Controls.Add(Me.txtgrade)
        Me.TabPage1.Controls.Add(Me.txtrata)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.btnkeluar)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnubah)
        Me.TabPage1.Controls.Add(Me.btntambah)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Controls.Add(Me.txtprodi)
        Me.TabPage1.Controls.Add(Me.txtfakultas)
        Me.TabPage1.Controls.Add(Me.txtnama)
        Me.TabPage1.Controls.Add(Me.txtnim)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1289, 635)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input Data"
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(769, 434)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 70
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(521, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Universitas Islam Syekh Yusuf Tangerang"
        '
        'txtsemester
        '
        Me.txtsemester.Location = New System.Drawing.Point(412, 313)
        Me.txtsemester.Name = "txtsemester"
        Me.txtsemester.Size = New System.Drawing.Size(161, 20)
        Me.txtsemester.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(288, 315)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 15)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Semester"
        '
        'txtuts
        '
        Me.txtuts.Location = New System.Drawing.Point(723, 184)
        Me.txtuts.Name = "txtuts"
        Me.txtuts.Size = New System.Drawing.Size(161, 20)
        Me.txtuts.TabIndex = 61
        '
        'txtekt2
        '
        Me.txtekt2.Location = New System.Drawing.Point(723, 224)
        Me.txtekt2.Name = "txtekt2"
        Me.txtekt2.Size = New System.Drawing.Size(161, 20)
        Me.txtekt2.TabIndex = 60
        '
        'txtuas
        '
        Me.txtuas.Location = New System.Drawing.Point(723, 268)
        Me.txtuas.Name = "txtuas"
        Me.txtuas.Size = New System.Drawing.Size(161, 20)
        Me.txtuas.TabIndex = 59
        '
        'txtekt1
        '
        Me.txtekt1.Location = New System.Drawing.Point(723, 141)
        Me.txtekt1.Name = "txtekt1"
        Me.txtekt1.Size = New System.Drawing.Size(161, 20)
        Me.txtekt1.TabIndex = 58
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(277, 434)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(80, 23)
        Me.btnproses.TabIndex = 57
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'txtgrade
        '
        Me.txtgrade.Location = New System.Drawing.Point(723, 313)
        Me.txtgrade.Name = "txtgrade"
        Me.txtgrade.Size = New System.Drawing.Size(161, 20)
        Me.txtgrade.TabIndex = 56
        '
        'txtrata
        '
        Me.txtrata.Location = New System.Drawing.Point(540, 370)
        Me.txtrata.Name = "txtrata"
        Me.txtrata.Size = New System.Drawing.Size(161, 20)
        Me.txtrata.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(615, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Grade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(458, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Rata-Rata"
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(861, 434)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(80, 23)
        Me.btnkeluar.TabIndex = 52
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(671, 434)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(80, 22)
        Me.btnhapus.TabIndex = 51
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Location = New System.Drawing.Point(571, 434)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(80, 23)
        Me.btnubah.TabIndex = 50
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(474, 434)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(80, 23)
        Me.btntambah.TabIndex = 49
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(380, 434)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 23)
        Me.btnsave.TabIndex = 48
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'txtprodi
        '
        Me.txtprodi.Location = New System.Drawing.Point(412, 270)
        Me.txtprodi.Name = "txtprodi"
        Me.txtprodi.Size = New System.Drawing.Size(161, 20)
        Me.txtprodi.TabIndex = 43
        '
        'txtfakultas
        '
        Me.txtfakultas.Location = New System.Drawing.Point(411, 228)
        Me.txtfakultas.Name = "txtfakultas"
        Me.txtfakultas.Size = New System.Drawing.Size(161, 20)
        Me.txtfakultas.TabIndex = 42
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(411, 184)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(161, 20)
        Me.txtnama.TabIndex = 41
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(411, 143)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(161, 20)
        Me.txtnim.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(613, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "UTS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(613, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "EKT-2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(614, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "UAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(614, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "EKT-1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(613, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Prodi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 15)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nim"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(484, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 32)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Data Mahasiswa"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btncari)
        Me.TabPage2.Controls.Add(Me.txtcari)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.cmbkategori)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1289, 635)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tampil Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(1126, 365)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 36
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(775, 366)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(299, 20)
        Me.txtcari.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(686, 368)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 15)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Kode Nim"
        '
        'cmbkategori
        '
        Me.cmbkategori.FormattingEnabled = True
        Me.cmbkategori.Location = New System.Drawing.Point(345, 365)
        Me.cmbkategori.Name = "cmbkategori"
        Me.cmbkategori.Size = New System.Drawing.Size(289, 21)
        Me.cmbkategori.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(268, 365)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Kategori"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1289, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 656)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Data Mahasiswa Unis"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtgrade As System.Windows.Forms.TextBox
    Friend WithEvents txtrata As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtprodi As System.Windows.Forms.TextBox
    Friend WithEvents txtfakultas As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents cmbkategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtuts As System.Windows.Forms.TextBox
    Friend WithEvents txtekt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtuas As System.Windows.Forms.TextBox
    Friend WithEvents txtekt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsemester As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_batal As System.Windows.Forms.Button

End Class
