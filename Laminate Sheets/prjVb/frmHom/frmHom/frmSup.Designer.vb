<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSup))
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.txtsupNam = New System.Windows.Forms.TextBox()
        Me.txtsupPhn = New System.Windows.Forms.TextBox()
        Me.txtsupEml = New System.Windows.Forms.TextBox()
        Me.txtsupAdr = New System.Windows.Forms.TextBox()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.lblHed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsupPrc = New System.Windows.Forms.TextBox()
        Me.txtsupCod = New System.Windows.Forms.TextBox()
        Me.cborawCod = New System.Windows.Forms.ComboBox()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(248, 193)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(182, 29)
        Me.lblcusCod.TabIndex = 15
        Me.lblcusCod.Text = "Supplier Code"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(248, 245)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(82, 29)
        Me.lblcusNam.TabIndex = 16
        Me.lblcusNam.Text = "Name"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(248, 364)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(188, 29)
        Me.lblcusPhn.TabIndex = 17
        Me.lblcusPhn.Text = "Phone Number"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(248, 305)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(79, 29)
        Me.lblcusEml.TabIndex = 18
        Me.lblcusEml.Text = "Email"
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(248, 420)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(109, 29)
        Me.lblcusAdr.TabIndex = 19
        Me.lblcusAdr.Text = "Address"
        '
        'txtsupNam
        '
        Me.txtsupNam.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupNam.Location = New System.Drawing.Point(660, 241)
        Me.txtsupNam.Name = "txtsupNam"
        Me.txtsupNam.Size = New System.Drawing.Size(162, 34)
        Me.txtsupNam.TabIndex = 22
        '
        'txtsupPhn
        '
        Me.txtsupPhn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupPhn.Location = New System.Drawing.Point(660, 357)
        Me.txtsupPhn.Name = "txtsupPhn"
        Me.txtsupPhn.Size = New System.Drawing.Size(162, 34)
        Me.txtsupPhn.TabIndex = 23
        '
        'txtsupEml
        '
        Me.txtsupEml.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupEml.Location = New System.Drawing.Point(660, 298)
        Me.txtsupEml.Name = "txtsupEml"
        Me.txtsupEml.Size = New System.Drawing.Size(249, 34)
        Me.txtsupEml.TabIndex = 24
        '
        'txtsupAdr
        '
        Me.txtsupAdr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupAdr.Location = New System.Drawing.Point(660, 417)
        Me.txtsupAdr.Multiline = True
        Me.txtsupAdr.Name = "txtsupAdr"
        Me.txtsupAdr.Size = New System.Drawing.Size(284, 60)
        Me.txtsupAdr.TabIndex = 25
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(962, 498)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(138, 52)
        Me.btnSub.TabIndex = 26
        Me.btnSub.Text = "SUBMIT"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'lblHed
        '
        Me.lblHed.AutoSize = True
        Me.lblHed.BackColor = System.Drawing.Color.CadetBlue
        Me.lblHed.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHed.Image = CType(resources.GetObject("lblHed.Image"), System.Drawing.Image)
        Me.lblHed.Location = New System.Drawing.Point(392, 111)
        Me.lblHed.Name = "lblHed"
        Me.lblHed.Size = New System.Drawing.Size(351, 38)
        Me.lblHed.TabIndex = 27
        Me.lblHed.Text = "Supplier Details Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(248, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Raw Material Provided:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(248, 556)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 29)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Selling Price:"
        '
        'txtsupPrc
        '
        Me.txtsupPrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupPrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupPrc.Location = New System.Drawing.Point(660, 553)
        Me.txtsupPrc.Name = "txtsupPrc"
        Me.txtsupPrc.Size = New System.Drawing.Size(162, 34)
        Me.txtsupPrc.TabIndex = 31
        '
        'txtsupCod
        '
        Me.txtsupCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsupCod.Enabled = False
        Me.txtsupCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupCod.Location = New System.Drawing.Point(660, 189)
        Me.txtsupCod.Name = "txtsupCod"
        Me.txtsupCod.Size = New System.Drawing.Size(112, 34)
        Me.txtsupCod.TabIndex = 32
        '
        'cborawCod
        '
        Me.cborawCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cborawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborawCod.FormattingEnabled = True
        Me.cborawCod.Location = New System.Drawing.Point(660, 498)
        Me.cborawCod.Name = "cborawCod"
        Me.cborawCod.Size = New System.Drawing.Size(261, 37)
        Me.cborawCod.TabIndex = 33
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(962, 575)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(138, 51)
        Me.btnExt.TabIndex = 43
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1213, 707)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.cborawCod)
        Me.Controls.Add(Me.txtsupCod)
        Me.Controls.Add(Me.txtsupPrc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHed)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.txtsupAdr)
        Me.Controls.Add(Me.txtsupEml)
        Me.Controls.Add(Me.txtsupPhn)
        Me.Controls.Add(Me.txtsupNam)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Name = "frmSup"
        Me.Text = "Supplier Details Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcusCod As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents txtsupNam As TextBox
    Friend WithEvents txtsupPhn As TextBox
    Friend WithEvents txtsupEml As TextBox
    Friend WithEvents txtsupAdr As TextBox
    Friend WithEvents btnSub As Button
    Friend WithEvents lblHed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsupPrc As TextBox
    Friend WithEvents txtsupCod As TextBox
    Friend WithEvents cborawCod As ComboBox
    Friend WithEvents btnExt As Button
End Class
