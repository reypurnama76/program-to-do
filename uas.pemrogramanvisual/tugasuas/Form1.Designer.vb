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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.btnTambahData = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnBacaFile = New System.Windows.Forms.Button()
        Me.btnHapusData = New System.Windows.Forms.Button()
        Me.btnProcedure = New System.Windows.Forms.Button()
        Me.btnPerulangan = New System.Windows.Forms.Button()
        Me.btnPercabangan = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(23, 25)
        Me.txtinput.Multiline = True
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(617, 72)
        Me.txtinput.TabIndex = 0
        '
        'btnTambahData
        '
        Me.btnTambahData.Location = New System.Drawing.Point(657, 25)
        Me.btnTambahData.Name = "btnTambahData"
        Me.btnTambahData.Size = New System.Drawing.Size(131, 43)
        Me.btnTambahData.TabIndex = 1
        Me.btnTambahData.Text = "tambah"
        Me.btnTambahData.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(28, 119)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(611, 244)
        Me.lstOutput.TabIndex = 4
        '
        'btnBacaFile
        '
        Me.btnBacaFile.Location = New System.Drawing.Point(657, 74)
        Me.btnBacaFile.Name = "btnBacaFile"
        Me.btnBacaFile.Size = New System.Drawing.Size(131, 43)
        Me.btnBacaFile.TabIndex = 5
        Me.btnBacaFile.Text = "baca file"
        Me.btnBacaFile.UseVisualStyleBackColor = True
        '
        'btnHapusData
        '
        Me.btnHapusData.Location = New System.Drawing.Point(657, 123)
        Me.btnHapusData.Name = "btnHapusData"
        Me.btnHapusData.Size = New System.Drawing.Size(131, 43)
        Me.btnHapusData.TabIndex = 6
        Me.btnHapusData.Text = "hapus file"
        Me.btnHapusData.UseVisualStyleBackColor = True
        '
        'btnProcedure
        '
        Me.btnProcedure.Location = New System.Drawing.Point(657, 271)
        Me.btnProcedure.Name = "btnProcedure"
        Me.btnProcedure.Size = New System.Drawing.Size(131, 43)
        Me.btnProcedure.TabIndex = 9
        Me.btnProcedure.Text = "procedure"
        Me.btnProcedure.UseVisualStyleBackColor = True
        '
        'btnPerulangan
        '
        Me.btnPerulangan.Location = New System.Drawing.Point(657, 222)
        Me.btnPerulangan.Name = "btnPerulangan"
        Me.btnPerulangan.Size = New System.Drawing.Size(131, 43)
        Me.btnPerulangan.TabIndex = 8
        Me.btnPerulangan.Text = "perulangan"
        Me.btnPerulangan.UseVisualStyleBackColor = True
        '
        'btnPercabangan
        '
        Me.btnPercabangan.Location = New System.Drawing.Point(657, 173)
        Me.btnPercabangan.Name = "btnPercabangan"
        Me.btnPercabangan.Size = New System.Drawing.Size(131, 43)
        Me.btnPercabangan.TabIndex = 7
        Me.btnPercabangan.Text = "percabangan"
        Me.btnPercabangan.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProcedure)
        Me.Controls.Add(Me.btnPerulangan)
        Me.Controls.Add(Me.btnPercabangan)
        Me.Controls.Add(Me.btnHapusData)
        Me.Controls.Add(Me.btnBacaFile)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnTambahData)
        Me.Controls.Add(Me.txtinput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtinput As TextBox
    Friend WithEvents btnTambahData As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnBacaFile As Button
    Friend WithEvents btnHapusData As Button
    Friend WithEvents btnProcedure As Button
    Friend WithEvents btnPerulangan As Button
    Friend WithEvents btnPercabangan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
