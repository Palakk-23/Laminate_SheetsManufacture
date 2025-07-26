<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRawFin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRawFin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblProCod = New System.Windows.Forms.Label()
        Me.lblRawNam = New System.Windows.Forms.Label()
        Me.lblRawCod = New System.Windows.Forms.Label()
        Me.dtpOdrDat = New System.Windows.Forms.DateTimePicker()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.btnMan = New System.Windows.Forms.Button()
        Me.btnOdr = New System.Windows.Forms.Button()
        Me.lblRawQty = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBasRawQty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(72, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(72, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Raw Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(72, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(77, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.LightGreen
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(341, 352)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 38)
        Me.txtQty.TabIndex = 5
        '
        'lblProCod
        '
        Me.lblProCod.AutoSize = True
        Me.lblProCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProCod.Image = CType(resources.GetObject("lblProCod.Image"), System.Drawing.Image)
        Me.lblProCod.Location = New System.Drawing.Point(335, 186)
        Me.lblProCod.Name = "lblProCod"
        Me.lblProCod.Size = New System.Drawing.Size(0, 32)
        Me.lblProCod.TabIndex = 6
        '
        'lblRawNam
        '
        Me.lblRawNam.AutoSize = True
        Me.lblRawNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawNam.Image = CType(resources.GetObject("lblRawNam.Image"), System.Drawing.Image)
        Me.lblRawNam.Location = New System.Drawing.Point(335, 297)
        Me.lblRawNam.Name = "lblRawNam"
        Me.lblRawNam.Size = New System.Drawing.Size(0, 32)
        Me.lblRawNam.TabIndex = 7
        '
        'lblRawCod
        '
        Me.lblRawCod.AutoSize = True
        Me.lblRawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRawCod.Image = CType(resources.GetObject("lblRawCod.Image"), System.Drawing.Image)
        Me.lblRawCod.Location = New System.Drawing.Point(335, 242)
        Me.lblRawCod.Name = "lblRawCod"
        Me.lblRawCod.Size = New System.Drawing.Size(0, 32)
        Me.lblRawCod.TabIndex = 8
        '
        'dtpOdrDat
        '
        Me.dtpOdrDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOdrDat.Location = New System.Drawing.Point(341, 410)
        Me.dtpOdrDat.Name = "dtpOdrDat"
        Me.dtpOdrDat.Size = New System.Drawing.Size(333, 38)
        Me.dtpOdrDat.TabIndex = 9
        '
        'btnChk
        '
        Me.btnChk.BackColor = System.Drawing.Color.PaleGreen
        Me.btnChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChk.Location = New System.Drawing.Point(78, 511)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(204, 58)
        Me.btnChk.TabIndex = 10
        Me.btnChk.Text = "CHECK"
        Me.btnChk.UseVisualStyleBackColor = False
        '
        'btnMan
        '
        Me.btnMan.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMan.Location = New System.Drawing.Point(331, 511)
        Me.btnMan.Name = "btnMan"
        Me.btnMan.Size = New System.Drawing.Size(204, 58)
        Me.btnMan.TabIndex = 11
        Me.btnMan.Text = "ADD"
        Me.btnMan.UseVisualStyleBackColor = False
        Me.btnMan.Visible = False
        '
        'btnOdr
        '
        Me.btnOdr.BackColor = System.Drawing.Color.PaleGreen
        Me.btnOdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOdr.Location = New System.Drawing.Point(585, 511)
        Me.btnOdr.Name = "btnOdr"
        Me.btnOdr.Size = New System.Drawing.Size(204, 58)
        Me.btnOdr.TabIndex = 12
        Me.btnOdr.Text = "ORDER"
        Me.btnOdr.UseVisualStyleBackColor = False
        Me.btnOdr.Visible = False
        '
        'lblRawQty
        '
        Me.lblRawQty.AutoSize = True
        Me.lblRawQty.Location = New System.Drawing.Point(632, 209)
        Me.lblRawQty.Name = "lblRawQty"
        Me.lblRawQty.Size = New System.Drawing.Size(0, 17)
        Me.lblRawQty.TabIndex = 14
        Me.lblRawQty.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(72, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Raw Name"
        '
        'lblBasRawQty
        '
        Me.lblBasRawQty.AutoSize = True
        Me.lblBasRawQty.Location = New System.Drawing.Point(1055, 118)
        Me.lblBasRawQty.Name = "lblBasRawQty"
        Me.lblBasRawQty.Size = New System.Drawing.Size(0, 17)
        Me.lblBasRawQty.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.YellowGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(890, 38)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "MANUFACTURING PRODUCT USING RAW MATERIAL"
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(854, 511)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmRawFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 682)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblBasRawQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblRawQty)
        Me.Controls.Add(Me.btnOdr)
        Me.Controls.Add(Me.btnMan)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.dtpOdrDat)
        Me.Controls.Add(Me.lblRawCod)
        Me.Controls.Add(Me.lblRawNam)
        Me.Controls.Add(Me.lblProCod)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRawFin"
        Me.Text = "Manufacturing Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblProCod As Label
    Friend WithEvents lblRawNam As Label
    Friend WithEvents lblRawCod As Label
    Friend WithEvents dtpOdrDat As DateTimePicker
    Friend WithEvents btnChk As Button
    Friend WithEvents btnMan As Button
    Friend WithEvents btnOdr As Button
    Friend WithEvents lblRawQty As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBasRawQty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExt As Button
End Class
