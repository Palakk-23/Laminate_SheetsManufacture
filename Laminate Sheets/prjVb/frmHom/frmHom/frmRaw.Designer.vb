<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRaw))
        Me.txtrawGrn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtrawQty = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblrawNam = New System.Windows.Forms.Label()
        Me.txtrawSiz = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrawCod = New System.Windows.Forms.TextBox()
        Me.txtrawPrc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrawTyp = New System.Windows.Forms.TextBox()
        Me.txtrawSubTyp = New System.Windows.Forms.TextBox()
        Me.txtrawNam = New System.Windows.Forms.TextBox()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.btnUpt = New System.Windows.Forms.Button()
        Me.dgvRaw = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrawShd = New System.Windows.Forms.TextBox()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvRaw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrawGrn
        '
        Me.txtrawGrn.BackColor = System.Drawing.Color.LightPink
        Me.txtrawGrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawGrn.Location = New System.Drawing.Point(1014, 277)
        Me.txtrawGrn.Name = "txtrawGrn"
        Me.txtrawGrn.Size = New System.Drawing.Size(162, 34)
        Me.txtrawGrn.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(723, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 29)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Raw Grain"
        '
        'txtrawQty
        '
        Me.txtrawQty.BackColor = System.Drawing.Color.LightPink
        Me.txtrawQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawQty.Location = New System.Drawing.Point(280, 327)
        Me.txtrawQty.Name = "txtrawQty"
        Me.txtrawQty.Size = New System.Drawing.Size(180, 34)
        Me.txtrawQty.TabIndex = 99
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(66, 396)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(268, 49)
        Me.btnAdd.TabIndex = 98
        Me.btnAdd.Text = "INSERTION"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblrawNam
        '
        Me.lblrawNam.AutoSize = True
        Me.lblrawNam.Location = New System.Drawing.Point(906, 345)
        Me.lblrawNam.Name = "lblrawNam"
        Me.lblrawNam.Size = New System.Drawing.Size(0, 17)
        Me.lblrawNam.TabIndex = 97
        '
        'txtrawSiz
        '
        Me.txtrawSiz.BackColor = System.Drawing.Color.LightPink
        Me.txtrawSiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawSiz.Location = New System.Drawing.Point(1014, 163)
        Me.txtrawSiz.Name = "txtrawSiz"
        Me.txtrawSiz.Size = New System.Drawing.Size(162, 34)
        Me.txtrawSiz.TabIndex = 96
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(724, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 29)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Size"
        '
        'txtrawCod
        '
        Me.txtrawCod.BackColor = System.Drawing.Color.LightPink
        Me.txtrawCod.Enabled = False
        Me.txtrawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawCod.Location = New System.Drawing.Point(1014, 123)
        Me.txtrawCod.Name = "txtrawCod"
        Me.txtrawCod.Size = New System.Drawing.Size(76, 34)
        Me.txtrawCod.TabIndex = 93
        '
        'txtrawPrc
        '
        Me.txtrawPrc.BackColor = System.Drawing.Color.LightPink
        Me.txtrawPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawPrc.Location = New System.Drawing.Point(1014, 217)
        Me.txtrawPrc.Name = "txtrawPrc"
        Me.txtrawPrc.Size = New System.Drawing.Size(162, 34)
        Me.txtrawPrc.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(723, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 29)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Price:"
        '
        'txtrawTyp
        '
        Me.txtrawTyp.BackColor = System.Drawing.Color.LightPink
        Me.txtrawTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawTyp.Location = New System.Drawing.Point(280, 220)
        Me.txtrawTyp.Name = "txtrawTyp"
        Me.txtrawTyp.Size = New System.Drawing.Size(313, 34)
        Me.txtrawTyp.TabIndex = 90
        '
        'txtrawSubTyp
        '
        Me.txtrawSubTyp.BackColor = System.Drawing.Color.LightPink
        Me.txtrawSubTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawSubTyp.Location = New System.Drawing.Point(280, 277)
        Me.txtrawSubTyp.Name = "txtrawSubTyp"
        Me.txtrawSubTyp.Size = New System.Drawing.Size(233, 34)
        Me.txtrawSubTyp.TabIndex = 89
        '
        'txtrawNam
        '
        Me.txtrawNam.BackColor = System.Drawing.Color.LightPink
        Me.txtrawNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawNam.Location = New System.Drawing.Point(280, 166)
        Me.txtrawNam.Name = "txtrawNam"
        Me.txtrawNam.Size = New System.Drawing.Size(313, 34)
        Me.txtrawNam.TabIndex = 88
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(61, 327)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(108, 29)
        Me.lblcusAdr.TabIndex = 87
        Me.lblcusAdr.Text = "Quantity"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(58, 166)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(82, 29)
        Me.lblcusNam.TabIndex = 85
        Me.lblcusNam.Text = "Name"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(794, 123)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(134, 29)
        Me.lblcusCod.TabIndex = 84
        Me.lblcusCod.Text = "Raw Code"
        '
        'btnUpt
        '
        Me.btnUpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpt.Location = New System.Drawing.Point(340, 396)
        Me.btnUpt.Name = "btnUpt"
        Me.btnUpt.Size = New System.Drawing.Size(237, 49)
        Me.btnUpt.TabIndex = 83
        Me.btnUpt.Text = "UPDATION"
        Me.btnUpt.UseVisualStyleBackColor = False
        '
        'dgvRaw
        '
        Me.dgvRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRaw.Location = New System.Drawing.Point(63, 451)
        Me.dgvRaw.Name = "dgvRaw"
        Me.dgvRaw.RowTemplate.Height = 24
        Me.dgvRaw.Size = New System.Drawing.Size(1096, 211)
        Me.dgvRaw.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(355, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 38)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "RAW MATERIALS DETAILS"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(61, 225)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(72, 29)
        Me.lblcusEml.TabIndex = 102
        Me.lblcusEml.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(61, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Sub Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(723, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Raw Shade"
        '
        'txtrawShd
        '
        Me.txtrawShd.BackColor = System.Drawing.Color.LightPink
        Me.txtrawShd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawShd.Location = New System.Drawing.Point(1014, 324)
        Me.txtrawShd.Name = "txtrawShd"
        Me.txtrawShd.Size = New System.Drawing.Size(162, 34)
        Me.txtrawShd.TabIndex = 105
        '
        'btnClr
        '
        Me.btnClr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.Location = New System.Drawing.Point(595, 396)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(237, 49)
        Me.btnClr.TabIndex = 106
        Me.btnClr.Text = "CLEAR"
        Me.btnClr.UseVisualStyleBackColor = False
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(852, 394)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 107
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmRaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 675)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.txtrawShd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.txtrawGrn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtrawQty)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblrawNam)
        Me.Controls.Add(Me.txtrawSiz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrawCod)
        Me.Controls.Add(Me.txtrawPrc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrawTyp)
        Me.Controls.Add(Me.txtrawSubTyp)
        Me.Controls.Add(Me.txtrawNam)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.btnUpt)
        Me.Controls.Add(Me.dgvRaw)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRaw"
        Me.Text = "Raw Material Details"
        CType(Me.dgvRaw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtrawGrn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtrawQty As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblrawNam As Label
    Friend WithEvents txtrawSiz As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrawCod As TextBox
    Friend WithEvents txtrawPrc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrawTyp As TextBox
    Friend WithEvents txtrawSubTyp As TextBox
    Friend WithEvents txtrawNam As TextBox
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents btnUpt As Button
    Friend WithEvents dgvRaw As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrawShd As TextBox
    Friend WithEvents btnClr As Button
    Friend WithEvents btnExt As Button
End Class
