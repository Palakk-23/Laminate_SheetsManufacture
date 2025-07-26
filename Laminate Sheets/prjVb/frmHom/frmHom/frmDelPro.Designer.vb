<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelPro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvDel = New System.Windows.Forms.DataGridView()
        Me.cboCusCod = New System.Windows.Forms.ComboBox()
        Me.dtpDelDat = New System.Windows.Forms.DateTimePicker()
        Me.txtProCod = New System.Windows.Forms.TextBox()
        Me.txtDelQty = New System.Windows.Forms.TextBox()
        Me.txtDelCod = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(127, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delivery of Product to the Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(128, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(128, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(128, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 36)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(128, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Delivery"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(128, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 36)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DeliveryMan Code"
        '
        'dgvDel
        '
        Me.dgvDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDel.Location = New System.Drawing.Point(134, 459)
        Me.dgvDel.Name = "dgvDel"
        Me.dgvDel.RowTemplate.Height = 24
        Me.dgvDel.Size = New System.Drawing.Size(724, 180)
        Me.dgvDel.TabIndex = 6
        '
        'cboCusCod
        '
        Me.cboCusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCusCod.FormattingEnabled = True
        Me.cboCusCod.Location = New System.Drawing.Point(520, 176)
        Me.cboCusCod.Name = "cboCusCod"
        Me.cboCusCod.Size = New System.Drawing.Size(88, 37)
        Me.cboCusCod.TabIndex = 7
        '
        'dtpDelDat
        '
        Me.dtpDelDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDelDat.Location = New System.Drawing.Point(520, 321)
        Me.dtpDelDat.Name = "dtpDelDat"
        Me.dtpDelDat.Size = New System.Drawing.Size(244, 34)
        Me.dtpDelDat.TabIndex = 8
        '
        'txtProCod
        '
        Me.txtProCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProCod.Location = New System.Drawing.Point(520, 233)
        Me.txtProCod.Name = "txtProCod"
        Me.txtProCod.Size = New System.Drawing.Size(125, 34)
        Me.txtProCod.TabIndex = 9
        '
        'txtDelQty
        '
        Me.txtDelQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelQty.Location = New System.Drawing.Point(520, 273)
        Me.txtDelQty.Name = "txtDelQty"
        Me.txtDelQty.Size = New System.Drawing.Size(125, 34)
        Me.txtDelQty.TabIndex = 10
        '
        'txtDelCod
        '
        Me.txtDelCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelCod.Location = New System.Drawing.Point(520, 377)
        Me.txtDelCod.Name = "txtDelCod"
        Me.txtDelCod.Size = New System.Drawing.Size(144, 34)
        Me.txtDelCod.TabIndex = 11
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(824, 347)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(174, 66)
        Me.btnDel.TabIndex = 12
        Me.btnDel.Text = "DELIVER"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(824, 278)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(174, 51)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmDelPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1243, 706)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtDelCod)
        Me.Controls.Add(Me.txtDelQty)
        Me.Controls.Add(Me.txtProCod)
        Me.Controls.Add(Me.dtpDelDat)
        Me.Controls.Add(Me.cboCusCod)
        Me.Controls.Add(Me.dgvDel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDelPro"
        Me.Text = "Delivery of Product to Customer"
        CType(Me.dgvDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvDel As DataGridView
    Friend WithEvents cboCusCod As ComboBox
    Friend WithEvents dtpDelDat As DateTimePicker
    Friend WithEvents txtProCod As TextBox
    Friend WithEvents txtDelQty As TextBox
    Friend WithEvents txtDelCod As TextBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnExt As Button
End Class
