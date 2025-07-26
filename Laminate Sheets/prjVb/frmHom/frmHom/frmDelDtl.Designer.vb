<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelDtl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelDtl))
        Me.dgvDelDtl = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdelCod = New System.Windows.Forms.TextBox()
        Me.txtcusCod = New System.Windows.Forms.TextBox()
        Me.txtproCod = New System.Windows.Forms.TextBox()
        Me.txtdelProQty = New System.Windows.Forms.TextBox()
        Me.txtdelDat = New System.Windows.Forms.TextBox()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvDelDtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDelDtl
        '
        Me.dgvDelDtl.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvDelDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelDtl.Location = New System.Drawing.Point(268, 458)
        Me.dgvDelDtl.Name = "dgvDelDtl"
        Me.dgvDelDtl.RowTemplate.Height = 24
        Me.dgvDelDtl.Size = New System.Drawing.Size(720, 144)
        Me.dgvDelDtl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(387, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DELIVERY DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(262, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delivery Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(262, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(262, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(262, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Order Quantity that is delivered"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(262, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Delivery Date"
        '
        'txtdelCod
        '
        Me.txtdelCod.BackColor = System.Drawing.Color.LightGreen
        Me.txtdelCod.Enabled = False
        Me.txtdelCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelCod.Location = New System.Drawing.Point(786, 169)
        Me.txtdelCod.Name = "txtdelCod"
        Me.txtdelCod.ReadOnly = True
        Me.txtdelCod.Size = New System.Drawing.Size(100, 38)
        Me.txtdelCod.TabIndex = 7
        '
        'txtcusCod
        '
        Me.txtcusCod.BackColor = System.Drawing.Color.LightGreen
        Me.txtcusCod.Enabled = False
        Me.txtcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusCod.Location = New System.Drawing.Point(786, 222)
        Me.txtcusCod.Name = "txtcusCod"
        Me.txtcusCod.ReadOnly = True
        Me.txtcusCod.Size = New System.Drawing.Size(100, 38)
        Me.txtcusCod.TabIndex = 8
        '
        'txtproCod
        '
        Me.txtproCod.BackColor = System.Drawing.Color.LightGreen
        Me.txtproCod.Enabled = False
        Me.txtproCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproCod.Location = New System.Drawing.Point(786, 281)
        Me.txtproCod.Name = "txtproCod"
        Me.txtproCod.ReadOnly = True
        Me.txtproCod.Size = New System.Drawing.Size(100, 38)
        Me.txtproCod.TabIndex = 9
        '
        'txtdelProQty
        '
        Me.txtdelProQty.BackColor = System.Drawing.Color.LightGreen
        Me.txtdelProQty.Enabled = False
        Me.txtdelProQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelProQty.Location = New System.Drawing.Point(786, 336)
        Me.txtdelProQty.Name = "txtdelProQty"
        Me.txtdelProQty.ReadOnly = True
        Me.txtdelProQty.Size = New System.Drawing.Size(202, 38)
        Me.txtdelProQty.TabIndex = 10
        '
        'txtdelDat
        '
        Me.txtdelDat.BackColor = System.Drawing.Color.LightGreen
        Me.txtdelDat.Enabled = False
        Me.txtdelDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelDat.Location = New System.Drawing.Point(786, 389)
        Me.txtdelDat.Name = "txtdelDat"
        Me.txtdelDat.ReadOnly = True
        Me.txtdelDat.Size = New System.Drawing.Size(202, 38)
        Me.txtdelDat.TabIndex = 11
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(1014, 551)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmDelDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1238, 716)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.txtdelDat)
        Me.Controls.Add(Me.txtdelProQty)
        Me.Controls.Add(Me.txtproCod)
        Me.Controls.Add(Me.txtcusCod)
        Me.Controls.Add(Me.txtdelCod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDelDtl)
        Me.Name = "frmDelDtl"
        Me.Text = "Delivery Details"
        CType(Me.dgvDelDtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDelDtl As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdelCod As TextBox
    Friend WithEvents txtcusCod As TextBox
    Friend WithEvents txtproCod As TextBox
    Friend WithEvents txtdelProQty As TextBox
    Friend WithEvents txtdelDat As TextBox
    Friend WithEvents btnExt As Button
End Class
