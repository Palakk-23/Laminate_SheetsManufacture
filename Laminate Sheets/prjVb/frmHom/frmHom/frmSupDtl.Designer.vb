<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupDtl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupDtl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSup = New System.Windows.Forms.DataGridView()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpt = New System.Windows.Forms.Button()
        Me.cborawCod = New System.Windows.Forms.ComboBox()
        Me.txtsupCod = New System.Windows.Forms.TextBox()
        Me.txtsupPrc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsupAdr = New System.Windows.Forms.TextBox()
        Me.txtsupEml = New System.Windows.Forms.TextBox()
        Me.txtsupPhn = New System.Windows.Forms.TextBox()
        Me.txtsupNam = New System.Windows.Forms.TextBox()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.btnShw = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrawCod = New System.Windows.Forms.TextBox()
        Me.lblrawNam = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvSup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(411, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUPPLIER's DETAILS"
        '
        'dgvSup
        '
        Me.dgvSup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSup.Location = New System.Drawing.Point(47, 475)
        Me.dgvSup.Name = "dgvSup"
        Me.dgvSup.RowTemplate.Height = 24
        Me.dgvSup.Size = New System.Drawing.Size(1021, 211)
        Me.dgvSup.TabIndex = 1
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(601, 400)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(266, 49)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "DELETION"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnUpt
        '
        Me.btnUpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpt.Location = New System.Drawing.Point(897, 400)
        Me.btnUpt.Name = "btnUpt"
        Me.btnUpt.Size = New System.Drawing.Size(257, 49)
        Me.btnUpt.TabIndex = 4
        Me.btnUpt.Text = "UPDATION"
        Me.btnUpt.UseVisualStyleBackColor = False
        '
        'cborawCod
        '
        Me.cborawCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cborawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborawCod.FormattingEnabled = True
        Me.cborawCod.Location = New System.Drawing.Point(957, 210)
        Me.cborawCod.Name = "cborawCod"
        Me.cborawCod.Size = New System.Drawing.Size(276, 37)
        Me.cborawCod.TabIndex = 47
        '
        'txtsupCod
        '
        Me.txtsupCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupCod.Enabled = False
        Me.txtsupCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupCod.Location = New System.Drawing.Point(957, 119)
        Me.txtsupCod.Name = "txtsupCod"
        Me.txtsupCod.Size = New System.Drawing.Size(79, 34)
        Me.txtsupCod.TabIndex = 46
        '
        'txtsupPrc
        '
        Me.txtsupPrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupPrc.Location = New System.Drawing.Point(957, 267)
        Me.txtsupPrc.Name = "txtsupPrc"
        Me.txtsupPrc.Size = New System.Drawing.Size(129, 34)
        Me.txtsupPrc.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(582, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Selling Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(582, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 29)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Raw Material Provided:"
        '
        'txtsupAdr
        '
        Me.txtsupAdr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupAdr.Location = New System.Drawing.Point(299, 269)
        Me.txtsupAdr.Multiline = True
        Me.txtsupAdr.Name = "txtsupAdr"
        Me.txtsupAdr.Size = New System.Drawing.Size(277, 86)
        Me.txtsupAdr.TabIndex = 42
        '
        'txtsupEml
        '
        Me.txtsupEml.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupEml.Location = New System.Drawing.Point(299, 165)
        Me.txtsupEml.Name = "txtsupEml"
        Me.txtsupEml.Size = New System.Drawing.Size(213, 34)
        Me.txtsupEml.TabIndex = 41
        '
        'txtsupPhn
        '
        Me.txtsupPhn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupPhn.Location = New System.Drawing.Point(299, 222)
        Me.txtsupPhn.Name = "txtsupPhn"
        Me.txtsupPhn.Size = New System.Drawing.Size(139, 34)
        Me.txtsupPhn.TabIndex = 40
        '
        'txtsupNam
        '
        Me.txtsupNam.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupNam.Location = New System.Drawing.Point(299, 111)
        Me.txtsupNam.Name = "txtsupNam"
        Me.txtsupNam.Size = New System.Drawing.Size(139, 34)
        Me.txtsupNam.TabIndex = 39
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(21, 272)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(109, 29)
        Me.lblcusAdr.TabIndex = 38
        Me.lblcusAdr.Text = "Address"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(21, 165)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(79, 29)
        Me.lblcusEml.TabIndex = 37
        Me.lblcusEml.Text = "Email"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(20, 222)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(188, 29)
        Me.lblcusPhn.TabIndex = 36
        Me.lblcusPhn.Text = "Phone Number"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(18, 111)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(82, 29)
        Me.lblcusNam.TabIndex = 35
        Me.lblcusNam.Text = "Name"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(582, 115)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(182, 29)
        Me.lblcusCod.TabIndex = 34
        Me.lblcusCod.Text = "Supplier Code"
        '
        'btnShw
        '
        Me.btnShw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShw.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShw.Location = New System.Drawing.Point(47, 400)
        Me.btnShw.Name = "btnShw"
        Me.btnShw.Size = New System.Drawing.Size(195, 49)
        Me.btnShw.TabIndex = 48
        Me.btnShw.Text = "SHOW"
        Me.btnShw.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(582, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 29)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Raw Code"
        '
        'txtrawCod
        '
        Me.txtrawCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawCod.Location = New System.Drawing.Point(957, 162)
        Me.txtrawCod.Name = "txtrawCod"
        Me.txtrawCod.Size = New System.Drawing.Size(79, 34)
        Me.txtrawCod.TabIndex = 50
        '
        'lblrawNam
        '
        Me.lblrawNam.AutoSize = True
        Me.lblrawNam.Location = New System.Drawing.Point(954, 314)
        Me.lblrawNam.Name = "lblrawNam"
        Me.lblrawNam.Size = New System.Drawing.Size(0, 17)
        Me.lblrawNam.TabIndex = 51
        Me.lblrawNam.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(281, 400)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(280, 49)
        Me.btnAdd.TabIndex = 53
        Me.btnAdd.Text = "INSERTION"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(1074, 625)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 54
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmSupDtl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 698)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblrawNam)
        Me.Controls.Add(Me.txtrawCod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnShw)
        Me.Controls.Add(Me.cborawCod)
        Me.Controls.Add(Me.txtsupCod)
        Me.Controls.Add(Me.txtsupPrc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsupAdr)
        Me.Controls.Add(Me.txtsupEml)
        Me.Controls.Add(Me.txtsupPhn)
        Me.Controls.Add(Me.txtsupNam)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.btnUpt)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.dgvSup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSupDtl"
        Me.Text = "Supplier Info Show"
        CType(Me.dgvSup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSup As DataGridView
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpt As Button
    Friend WithEvents cborawCod As ComboBox
    Friend WithEvents txtsupCod As TextBox
    Friend WithEvents txtsupPrc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsupAdr As TextBox
    Friend WithEvents txtsupEml As TextBox
    Friend WithEvents txtsupPhn As TextBox
    Friend WithEvents txtsupNam As TextBox
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents btnShw As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrawCod As TextBox
    Friend WithEvents lblrawNam As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExt As Button
End Class
