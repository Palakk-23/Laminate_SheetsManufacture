<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelMan))
        Me.txtdelCod = New System.Windows.Forms.TextBox()
        Me.txtdelAdr = New System.Windows.Forms.TextBox()
        Me.txtvehNum = New System.Windows.Forms.TextBox()
        Me.txtvehTyp = New System.Windows.Forms.TextBox()
        Me.txtdelNam = New System.Windows.Forms.TextBox()
        Me.lblcusAdr = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.lblcusNam = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.lblHed = New System.Windows.Forms.Label()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtdelCod
        '
        Me.txtdelCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtdelCod.Enabled = False
        Me.txtdelCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelCod.Location = New System.Drawing.Point(623, 187)
        Me.txtdelCod.Name = "txtdelCod"
        Me.txtdelCod.Size = New System.Drawing.Size(79, 34)
        Me.txtdelCod.TabIndex = 32
        '
        'txtdelAdr
        '
        Me.txtdelAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtdelAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelAdr.Location = New System.Drawing.Point(623, 407)
        Me.txtdelAdr.Multiline = True
        Me.txtdelAdr.Name = "txtdelAdr"
        Me.txtdelAdr.Size = New System.Drawing.Size(275, 86)
        Me.txtdelAdr.TabIndex = 28
        '
        'txtvehNum
        '
        Me.txtvehNum.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtvehNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvehNum.Location = New System.Drawing.Point(623, 300)
        Me.txtvehNum.Name = "txtvehNum"
        Me.txtvehNum.Size = New System.Drawing.Size(172, 34)
        Me.txtvehNum.TabIndex = 27
        '
        'txtvehTyp
        '
        Me.txtvehTyp.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtvehTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvehTyp.Location = New System.Drawing.Point(623, 349)
        Me.txtvehTyp.Name = "txtvehTyp"
        Me.txtvehTyp.Size = New System.Drawing.Size(126, 34)
        Me.txtvehTyp.TabIndex = 26
        '
        'txtdelNam
        '
        Me.txtdelNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtdelNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelNam.Location = New System.Drawing.Point(623, 242)
        Me.txtdelNam.Name = "txtdelNam"
        Me.txtdelNam.Size = New System.Drawing.Size(126, 34)
        Me.txtdelNam.TabIndex = 25
        '
        'lblcusAdr
        '
        Me.lblcusAdr.AutoSize = True
        Me.lblcusAdr.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusAdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusAdr.Image = CType(resources.GetObject("lblcusAdr.Image"), System.Drawing.Image)
        Me.lblcusAdr.Location = New System.Drawing.Point(296, 407)
        Me.lblcusAdr.Name = "lblcusAdr"
        Me.lblcusAdr.Size = New System.Drawing.Size(119, 32)
        Me.lblcusAdr.TabIndex = 23
        Me.lblcusAdr.Text = "Address"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(294, 300)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(217, 32)
        Me.lblcusEml.TabIndex = 22
        Me.lblcusEml.Text = "Vehicle Number"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(294, 349)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(180, 32)
        Me.lblcusPhn.TabIndex = 21
        Me.lblcusPhn.Text = "Vehicle Type"
        '
        'lblcusNam
        '
        Me.lblcusNam.AutoSize = True
        Me.lblcusNam.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusNam.Image = CType(resources.GetObject("lblcusNam.Image"), System.Drawing.Image)
        Me.lblcusNam.Location = New System.Drawing.Point(294, 239)
        Me.lblcusNam.Name = "lblcusNam"
        Me.lblcusNam.Size = New System.Drawing.Size(90, 32)
        Me.lblcusNam.TabIndex = 20
        Me.lblcusNam.Text = "Name"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(294, 184)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(193, 32)
        Me.lblcusCod.TabIndex = 19
        Me.lblcusCod.Text = "Delivery Code"
        '
        'lblHed
        '
        Me.lblHed.AutoSize = True
        Me.lblHed.BackColor = System.Drawing.Color.CadetBlue
        Me.lblHed.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHed.Image = CType(resources.GetObject("lblHed.Image"), System.Drawing.Image)
        Me.lblHed.Location = New System.Drawing.Point(272, 129)
        Me.lblHed.Name = "lblHed"
        Me.lblHed.Size = New System.Drawing.Size(496, 38)
        Me.lblHed.TabIndex = 18
        Me.lblHed.Text = "DeliveryMan Registration Form"
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(302, 490)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(193, 61)
        Me.btnSub.TabIndex = 33
        Me.btnSub.Text = "SUBMIT"
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(926, 500)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmDelMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1223, 688)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.txtdelCod)
        Me.Controls.Add(Me.txtdelAdr)
        Me.Controls.Add(Me.txtvehNum)
        Me.Controls.Add(Me.txtvehTyp)
        Me.Controls.Add(Me.txtdelNam)
        Me.Controls.Add(Me.lblcusAdr)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusNam)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.lblHed)
        Me.Name = "frmDelMan"
        Me.Text = "DelivryMan Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtdelCod As TextBox
    Friend WithEvents txtdelAdr As TextBox
    Friend WithEvents txtvehNum As TextBox
    Friend WithEvents txtvehTyp As TextBox
    Friend WithEvents txtdelNam As TextBox
    Friend WithEvents lblcusAdr As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents lblcusNam As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents lblHed As Label
    Friend WithEvents btnSub As Button
    Friend WithEvents btnExt As Button
End Class
