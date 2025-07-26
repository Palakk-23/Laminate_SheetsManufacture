<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPro))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblrawNam = New System.Windows.Forms.Label()
        Me.txtproSiz = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShw = New System.Windows.Forms.Button()
        Me.txtproCod = New System.Windows.Forms.TextBox()
        Me.txtproPrc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtproTyp = New System.Windows.Forms.TextBox()
        Me.txtproThk = New System.Windows.Forms.TextBox()
        Me.txtproNam = New System.Windows.Forms.TextBox()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.btnUpt = New System.Windows.Forms.Button()
        Me.dgvPro = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproQty = New System.Windows.Forms.TextBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(305, 388)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(286, 49)
        Me.btnAdd.TabIndex = 76
        Me.btnAdd.Text = "INSERTION"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblrawNam
        '
        Me.lblrawNam.AutoSize = True
        Me.lblrawNam.Location = New System.Drawing.Point(987, 350)
        Me.lblrawNam.Name = "lblrawNam"
        Me.lblrawNam.Size = New System.Drawing.Size(0, 17)
        Me.lblrawNam.TabIndex = 75
        '
        'txtproSiz
        '
        Me.txtproSiz.BackColor = System.Drawing.Color.LightPink
        Me.txtproSiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproSiz.Location = New System.Drawing.Point(1015, 168)
        Me.txtproSiz.Name = "txtproSiz"
        Me.txtproSiz.Size = New System.Drawing.Size(162, 34)
        Me.txtproSiz.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(725, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 29)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Size"
        '
        'btnShw
        '
        Me.btnShw.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnShw.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShw.Location = New System.Drawing.Point(67, 388)
        Me.btnShw.Name = "btnShw"
        Me.btnShw.Size = New System.Drawing.Size(195, 49)
        Me.btnShw.TabIndex = 72
        Me.btnShw.Text = "SHOW"
        Me.btnShw.UseVisualStyleBackColor = False
        '
        'txtproCod
        '
        Me.txtproCod.BackColor = System.Drawing.Color.LightPink
        Me.txtproCod.Enabled = False
        Me.txtproCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproCod.Location = New System.Drawing.Point(1015, 116)
        Me.txtproCod.Name = "txtproCod"
        Me.txtproCod.Size = New System.Drawing.Size(76, 34)
        Me.txtproCod.TabIndex = 70
        '
        'txtproPrc
        '
        Me.txtproPrc.BackColor = System.Drawing.Color.LightPink
        Me.txtproPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproPrc.Location = New System.Drawing.Point(1015, 222)
        Me.txtproPrc.Name = "txtproPrc"
        Me.txtproPrc.Size = New System.Drawing.Size(162, 34)
        Me.txtproPrc.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(724, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Price:"
        '
        'txtproTyp
        '
        Me.txtproTyp.BackColor = System.Drawing.Color.LightPink
        Me.txtproTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproTyp.Location = New System.Drawing.Point(305, 225)
        Me.txtproTyp.Name = "txtproTyp"
        Me.txtproTyp.Size = New System.Drawing.Size(313, 34)
        Me.txtproTyp.TabIndex = 65
        '
        'txtproThk
        '
        Me.txtproThk.BackColor = System.Drawing.Color.LightPink
        Me.txtproThk.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproThk.Location = New System.Drawing.Point(305, 282)
        Me.txtproThk.Name = "txtproThk"
        Me.txtproThk.Size = New System.Drawing.Size(233, 34)
        Me.txtproThk.TabIndex = 64
        '
        'txtproNam
        '
        Me.txtproNam.BackColor = System.Drawing.Color.LightPink
        Me.txtproNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproNam.Location = New System.Drawing.Point(305, 171)
        Me.txtproNam.Name = "txtproNam"
        Me.txtproNam.Size = New System.Drawing.Size(313, 34)
        Me.txtproNam.TabIndex = 63
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(62, 332)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(108, 29)
        Me.lblcusAdr.TabIndex = 62
        Me.lblcusAdr.Text = "Quantity"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(62, 225)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(72, 29)
        Me.lblcusEml.TabIndex = 61
        Me.lblcusEml.Text = "Type"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(61, 282)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(132, 29)
        Me.lblcusPhn.TabIndex = 60
        Me.lblcusPhn.Text = "Thickness"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(59, 171)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(82, 29)
        Me.lblcusNam.TabIndex = 59
        Me.lblcusNam.Text = "Name"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(724, 116)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(173, 29)
        Me.lblcusCod.TabIndex = 58
        Me.lblcusCod.Text = "Product Code"
        '
        'btnUpt
        '
        Me.btnUpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpt.Location = New System.Drawing.Point(631, 388)
        Me.btnUpt.Name = "btnUpt"
        Me.btnUpt.Size = New System.Drawing.Size(247, 49)
        Me.btnUpt.TabIndex = 57
        Me.btnUpt.Text = "UPDATION"
        Me.btnUpt.UseVisualStyleBackColor = False
        '
        'dgvPro
        '
        Me.dgvPro.BackgroundColor = System.Drawing.Color.Salmon
        Me.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPro.Location = New System.Drawing.Point(64, 460)
        Me.dgvPro.Name = "dgvPro"
        Me.dgvPro.RowTemplate.Height = 24
        Me.dgvPro.Size = New System.Drawing.Size(1027, 211)
        Me.dgvPro.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(356, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 38)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "PRODUCT DETAILS"
        '
        'txtproQty
        '
        Me.txtproQty.BackColor = System.Drawing.Color.LightPink
        Me.txtproQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproQty.Location = New System.Drawing.Point(305, 332)
        Me.txtproQty.Name = "txtproQty"
        Me.txtproQty.Size = New System.Drawing.Size(180, 34)
        Me.txtproQty.TabIndex = 77
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.Location = New System.Drawing.Point(896, 388)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(237, 49)
        Me.btnClr.TabIndex = 107
        Me.btnClr.Text = "CLEAR"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(1097, 594)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(130, 77)
        Me.btnExt.TabIndex = 108
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmPro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1245, 695)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.txtproQty)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblrawNam)
        Me.Controls.Add(Me.txtproSiz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnShw)
        Me.Controls.Add(Me.txtproCod)
        Me.Controls.Add(Me.txtproPrc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtproTyp)
        Me.Controls.Add(Me.txtproThk)
        Me.Controls.Add(Me.txtproNam)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.btnUpt)
        Me.Controls.Add(Me.dgvPro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPro"
        Me.Text = "Product Details"
        CType(Me.dgvPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblrawNam As Label
    Friend WithEvents txtproSiz As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShw As Button
    Friend WithEvents txtproCod As TextBox
    Friend WithEvents txtproPrc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtproTyp As TextBox
    Friend WithEvents txtproThk As TextBox
    Friend WithEvents txtproNam As TextBox
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents btnUpt As Button
    Friend WithEvents dgvPro As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtproQty As TextBox
    Friend WithEvents btnClr As Button
    Friend WithEvents btnExt As Button
End Class
