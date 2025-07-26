<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCus))
        Me.lblHed = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.lblcusLoc = New System.Windows.Forms.Label()
        Me.txtcusNam = New System.Windows.Forms.TextBox()
        Me.txtcusPhn = New System.Windows.Forms.TextBox()
        Me.txtcusEml = New System.Windows.Forms.TextBox()
        Me.txtcusAdr = New System.Windows.Forms.TextBox()
        Me.txtcusLoc = New System.Windows.Forms.TextBox()
        Me.btncusReg = New System.Windows.Forms.Button()
        Me.btnNxt = New System.Windows.Forms.Button()
        Me.txtcusCod = New System.Windows.Forms.TextBox()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHed
        '
        Me.lblHed.AutoSize = True
        Me.lblHed.BackColor = System.Drawing.Color.CadetBlue
        Me.lblHed.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHed.Image = CType(resources.GetObject("lblHed.Image"), System.Drawing.Image)
        Me.lblHed.Location = New System.Drawing.Point(309, 96)
        Me.lblHed.Name = "lblHed"
        Me.lblHed.Size = New System.Drawing.Size(453, 38)
        Me.lblHed.TabIndex = 2
        Me.lblHed.Text = "Customer Registration Form"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(310, 163)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(195, 29)
        Me.lblcusCod.TabIndex = 3
        Me.lblcusCod.Text = "Customer Code"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(310, 218)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(82, 29)
        Me.lblcusNam.TabIndex = 4
        Me.lblcusNam.Text = "Name"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(310, 328)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(188, 29)
        Me.lblcusPhn.TabIndex = 5
        Me.lblcusPhn.Text = "Phone Number"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(310, 279)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(79, 29)
        Me.lblcusEml.TabIndex = 6
        Me.lblcusEml.Text = "Email"
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(312, 386)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(109, 29)
        Me.lblcusAdr.TabIndex = 7
        Me.lblcusAdr.Text = "Address"
        '
        'lblcusLoc
        '
        Me.lblcusLoc.AutoSize = True
        Me.lblcusLoc.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusLoc.Image = CType(resources.GetObject("lblcusLoc.Image"), System.Drawing.Image)
        Me.lblcusLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblcusLoc.Location = New System.Drawing.Point(312, 468)
        Me.lblcusLoc.Name = "lblcusLoc"
        Me.lblcusLoc.Size = New System.Drawing.Size(112, 29)
        Me.lblcusLoc.TabIndex = 8
        Me.lblcusLoc.Text = "Location"
        '
        'txtcusNam
        '
        Me.txtcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusNam.Location = New System.Drawing.Point(639, 216)
        Me.txtcusNam.Name = "txtcusNam"
        Me.txtcusNam.Size = New System.Drawing.Size(151, 34)
        Me.txtcusNam.TabIndex = 10
        '
        'txtcusPhn
        '
        Me.txtcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusPhn.Location = New System.Drawing.Point(639, 323)
        Me.txtcusPhn.Name = "txtcusPhn"
        Me.txtcusPhn.Size = New System.Drawing.Size(151, 34)
        Me.txtcusPhn.TabIndex = 11
        '
        'txtcusEml
        '
        Me.txtcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusEml.Location = New System.Drawing.Point(639, 274)
        Me.txtcusEml.Name = "txtcusEml"
        Me.txtcusEml.Size = New System.Drawing.Size(269, 34)
        Me.txtcusEml.TabIndex = 12
        '
        'txtcusAdr
        '
        Me.txtcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusAdr.Location = New System.Drawing.Point(639, 381)
        Me.txtcusAdr.Multiline = True
        Me.txtcusAdr.Name = "txtcusAdr"
        Me.txtcusAdr.Size = New System.Drawing.Size(267, 61)
        Me.txtcusAdr.TabIndex = 13
        '
        'txtcusLoc
        '
        Me.txtcusLoc.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusLoc.Location = New System.Drawing.Point(639, 463)
        Me.txtcusLoc.Name = "txtcusLoc"
        Me.txtcusLoc.Size = New System.Drawing.Size(151, 34)
        Me.txtcusLoc.TabIndex = 14
        '
        'btncusReg
        '
        Me.btncusReg.BackgroundImage = CType(resources.GetObject("btncusReg.BackgroundImage"), System.Drawing.Image)
        Me.btncusReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncusReg.Location = New System.Drawing.Point(317, 539)
        Me.btncusReg.Name = "btncusReg"
        Me.btncusReg.Size = New System.Drawing.Size(181, 82)
        Me.btncusReg.TabIndex = 15
        Me.btncusReg.UseVisualStyleBackColor = True
        '
        'btnNxt
        '
        Me.btnNxt.BackColor = System.Drawing.Color.White
        Me.btnNxt.BackgroundImage = CType(resources.GetObject("btnNxt.BackgroundImage"), System.Drawing.Image)
        Me.btnNxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNxt.Location = New System.Drawing.Point(639, 539)
        Me.btnNxt.Name = "btnNxt"
        Me.btnNxt.Size = New System.Drawing.Size(151, 70)
        Me.btnNxt.TabIndex = 16
        Me.btnNxt.UseVisualStyleBackColor = False
        Me.btnNxt.Visible = False
        '
        'txtcusCod
        '
        Me.txtcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtcusCod.Enabled = False
        Me.txtcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusCod.Location = New System.Drawing.Point(639, 161)
        Me.txtcusCod.Name = "txtcusCod"
        Me.txtcusCod.Size = New System.Drawing.Size(79, 34)
        Me.txtcusCod.TabIndex = 17
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(874, 536)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 70)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1182, 720)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.txtcusCod)
        Me.Controls.Add(Me.btnNxt)
        Me.Controls.Add(Me.btncusReg)
        Me.Controls.Add(Me.txtcusLoc)
        Me.Controls.Add(Me.txtcusAdr)
        Me.Controls.Add(Me.txtcusEml)
        Me.Controls.Add(Me.txtcusPhn)
        Me.Controls.Add(Me.txtcusNam)
        Me.Controls.Add(Me.lblcusLoc)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.lblHed)
        Me.Name = "frmCus"
        Me.Text = "Customer Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHed As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents lblcusLoc As Label
    Friend WithEvents txtcusNam As TextBox
    Friend WithEvents txtcusPhn As TextBox
    Friend WithEvents txtcusEml As TextBox
    Friend WithEvents txtcusAdr As TextBox
    Friend WithEvents txtcusLoc As TextBox
    Friend WithEvents btncusReg As Button
    Friend WithEvents btnNxt As Button
    Friend WithEvents txtcusCod As TextBox
    Friend WithEvents btnExt As Button
End Class
