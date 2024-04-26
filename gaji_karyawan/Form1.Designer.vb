<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtJJK = New TextBox()
        txtTPJ = New TextBox()
        ListView1 = New ListView()
        btnTambah = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        textGaji = New Label()
        textTunjangan = New Label()
        btnHapus = New Button()
        Label12 = New Label()
        Label13 = New Label()
        textTotalGaji = New Label()
        Label10 = New Label()
        txtNo = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama                                     :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 25)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah Jam Kerja Per Minggu :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(248, 25)
        Label3.TabIndex = 2
        Label3.Text = "Tarif Per Jam                           :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(240, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(343, 45)
        Label4.TabIndex = 3
        Label4.Text = "Penggajian Karyawan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(299, 125)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(459, 31)
        txtNama.TabIndex = 4
        ' 
        ' txtJJK
        ' 
        txtJJK.Location = New Point(299, 166)
        txtJJK.Name = "txtJJK"
        txtJJK.Size = New Size(459, 31)
        txtJJK.TabIndex = 5
        ' 
        ' txtTPJ
        ' 
        txtTPJ.Location = New Point(299, 213)
        txtTPJ.Name = "txtTPJ"
        txtTPJ.Size = New Size(459, 31)
        txtTPJ.TabIndex = 6
        ' 
        ' ListView1
        ' 
        ListView1.Cursor = Cursors.Hand
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(33, 289)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(604, 186)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(646, 289)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(33, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 25)
        Label5.TabIndex = 9
        Label5.Text = "Data Karyawan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 526)
        Label6.Name = "Label6"
        Label6.Size = New Size(179, 25)
        Label6.TabIndex = 10
        Label6.Text = "Gaji Pokok                :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 566)
        Label7.Name = "Label7"
        Label7.Size = New Size(178, 25)
        Label7.TabIndex = 11
        Label7.Text = "Tunjangan (Lembur) :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(218, 526)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 25)
        Label8.TabIndex = 12
        Label8.Text = "Rp."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(218, 566)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 25)
        Label9.TabIndex = 13
        Label9.Text = "Rp."
        ' 
        ' textGaji
        ' 
        textGaji.AutoSize = True
        textGaji.Location = New Point(262, 526)
        textGaji.Name = "textGaji"
        textGaji.Size = New Size(33, 25)
        textGaji.TabIndex = 14
        textGaji.Text = "-,0"
        ' 
        ' textTunjangan
        ' 
        textTunjangan.AutoSize = True
        textTunjangan.Location = New Point(262, 566)
        textTunjangan.Name = "textTunjangan"
        textTunjangan.Size = New Size(33, 25)
        textTunjangan.TabIndex = 15
        textTunjangan.Text = "-,0"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(646, 329)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(262, 483)
        Label12.Name = "Label12"
        Label12.Size = New Size(221, 25)
        Label12.TabIndex = 17
        Label12.Text = "Total Seluruh Gaji              :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(477, 483)
        Label13.Name = "Label13"
        Label13.Size = New Size(38, 25)
        Label13.TabIndex = 18
        Label13.Text = "Rp."
        ' 
        ' textTotalGaji
        ' 
        textTotalGaji.AutoSize = True
        textTotalGaji.Location = New Point(521, 483)
        textTotalGaji.Name = "textTotalGaji"
        textTotalGaji.Size = New Size(33, 25)
        textTotalGaji.TabIndex = 19
        textTotalGaji.Text = "-,0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(32, 90)
        Label10.Name = "Label10"
        Label10.Size = New Size(250, 25)
        Label10.TabIndex = 20
        Label10.Text = "No                                          :"
        ' 
        ' txtNo
        ' 
        txtNo.Location = New Point(299, 84)
        txtNo.Name = "txtNo"
        txtNo.ReadOnly = True
        txtNo.Size = New Size(48, 31)
        txtNo.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 629)
        Controls.Add(txtNo)
        Controls.Add(Label10)
        Controls.Add(textTotalGaji)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(btnHapus)
        Controls.Add(textTunjangan)
        Controls.Add(textGaji)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btnTambah)
        Controls.Add(ListView1)
        Controls.Add(txtTPJ)
        Controls.Add(txtJJK)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Penggajian Karyawan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtJJK As TextBox
    Friend WithEvents txtTPJ As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents textGaji As Label
    Friend WithEvents textTunjangan As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents textTotalGaji As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNo As TextBox

End Class
