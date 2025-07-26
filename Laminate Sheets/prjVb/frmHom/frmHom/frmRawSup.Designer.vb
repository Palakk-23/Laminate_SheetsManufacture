<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRawSup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRawSup))
        Me.dgvSup = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSupCod = New System.Windows.Forms.TextBox()
        Me.txtRawCod = New System.Windows.Forms.TextBox()
        Me.txtRawNam = New System.Windows.Forms.TextBox()
        Me.txtRawQty = New System.Windows.Forms.TextBox()
        Me.txtTotPri = New System.Windows.Forms.TextBox()
        Me.dtpPurDat = New System.Windows.Forms.DateTimePicker()
        Me.txtSupPri = New System.Windows.Forms.TextBox()
        Me.txtRawQtySup = New System.Windows.Forms.TextBox()
        Me.btnSupOdr = New System.Windows.Forms.Button()
        Me.btnMan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSup
        '
        Me.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSup.Location = New System.Drawing.Point(83, 383)
        Me.dgvSup.Name = "dgvSup"
        Me.dgvSup.RowTemplate.Height = 24
        Me.dgvSup.Size = New System.Drawing.Size(1020, 288)
        Me.dgvSup.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(683, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Supplier Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(43, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Raw Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(41, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Raw Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(41, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Raw Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(686, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(683, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total price"
        '
        'txtSupCod
        '
        Me.txtSupCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCod.Location = New System.Drawing.Point(949, 122)
        Me.txtSupCod.Name = "txtSupCod"
        Me.txtSupCod.Size = New System.Drawing.Size(100, 34)
        Me.txtSupCod.TabIndex = 7
        '
        'txtRawCod
        '
        Me.txtRawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawCod.Location = New System.Drawing.Point(420, 134)
        Me.txtRawCod.Name = "txtRawCod"
        Me.txtRawCod.Size = New System.Drawing.Size(104, 34)
        Me.txtRawCod.TabIndex = 8
        '
        'txtRawNam
        '
        Me.txtRawNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawNam.Location = New System.Drawing.Point(420, 174)
        Me.txtRawNam.Name = "txtRawNam"
        Me.txtRawNam.Size = New System.Drawing.Size(222, 34)
        Me.txtRawNam.TabIndex = 9
        '
        'txtRawQty
        '
        Me.txtRawQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawQty.Location = New System.Drawing.Point(420, 219)
        Me.txtRawQty.Name = "txtRawQty"
        Me.txtRawQty.Size = New System.Drawing.Size(104, 34)
        Me.txtRawQty.TabIndex = 10
        '
        'txtTotPri
        '
        Me.txtTotPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotPri.Location = New System.Drawing.Point(949, 216)
        Me.txtTotPri.Name = "txtTotPri"
        Me.txtTotPri.Size = New System.Drawing.Size(185, 34)
        Me.txtTotPri.TabIndex = 11
        '
        'dtpPurDat
        '
        Me.dtpPurDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurDat.Location = New System.Drawing.Point(949, 171)
        Me.dtpPurDat.Name = "dtpPurDat"
        Me.dtpPurDat.Size = New System.Drawing.Size(265, 34)
        Me.dtpPurDat.TabIndex = 12
        '
        'txtSupPri
        '
        Me.txtSupPri.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupPri.Location = New System.Drawing.Point(949, 275)
        Me.txtSupPri.Name = "txtSupPri"
        Me.txtSupPri.Size = New System.Drawing.Size(123, 34)
        Me.txtSupPri.TabIndex = 14
        Me.txtSupPri.Visible = False
        '
        'txtRawQtySup
        '
        Me.txtRawQtySup.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawQtySup.Location = New System.Drawing.Point(420, 273)
        Me.txtRawQtySup.Name = "txtRawQtySup"
        Me.txtRawQtySup.Size = New System.Drawing.Size(104, 34)
        Me.txtRawQtySup.TabIndex = 15
        '
        'btnSupOdr
        '
        Me.btnSupOdr.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSupOdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupOdr.Location = New System.Drawing.Point(48, 322)
        Me.btnSupOdr.Name = "btnSupOdr"
        Me.btnSupOdr.Size = New System.Drawing.Size(182, 46)
        Me.btnSupOdr.TabIndex = 16
        Me.btnSupOdr.Text = "ORDER"
        Me.btnSupOdr.UseVisualStyleBackColor = False
        '
        'btnMan
        '
        Me.btnMan.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMan.Location = New System.Drawing.Point(691, 322)
        Me.btnMan.Name = "btnMan"
        Me.btnMan.Size = New System.Drawing.Size(293, 55)
        Me.btnMan.TabIndex = 17
        Me.btnMan.Text = "MANUFACTURE"
        Me.btnMan.UseVisualStyleBackColor = False
        Me.btnMan.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(41, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 29)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Raw Quantity to Order"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.YellowGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(717, 38)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Purchase Order For Supplying Raw Materials"
        '
        'frmRawSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1269, 683)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnMan)
        Me.Controls.Add(Me.btnSupOdr)
        Me.Controls.Add(Me.txtRawQtySup)
        Me.Controls.Add(Me.txtSupPri)
        Me.Controls.Add(Me.dtpPurDat)
        Me.Controls.Add(Me.txtTotPri)
        Me.Controls.Add(Me.txtRawQty)
        Me.Controls.Add(Me.txtRawNam)
        Me.Controls.Add(Me.txtRawCod)
        Me.Controls.Add(Me.txtSupCod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSup)
        Me.Name = "frmRawSup"
        Me.Text = "Supplying Raw materials"
        CType(Me.dgvSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSup As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSupCod As TextBox
    Friend WithEvents txtRawCod As TextBox
    Friend WithEvents txtRawNam As TextBox
    Friend WithEvents txtRawQty As TextBox
    Friend WithEvents txtTotPri As TextBox
    Friend WithEvents dtpPurDat As DateTimePicker
    Friend WithEvents txtSupPri As TextBox
    Friend WithEvents txtRawQtySup As TextBox
    Friend WithEvents btnSupOdr As Button
    Friend WithEvents btnMan As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
