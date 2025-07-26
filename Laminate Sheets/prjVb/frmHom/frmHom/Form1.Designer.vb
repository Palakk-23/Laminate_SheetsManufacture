<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHom
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHom))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProDtl = New System.Windows.Forms.Button()
        Me.btnRawDtl = New System.Windows.Forms.Button()
        Me.btnSupDtl = New System.Windows.Forms.Button()
        Me.mnuHom = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupDtl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlrReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelManReg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelDtl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMan = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuHom.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(302, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(905, 496)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label2.Location = New System.Drawing.Point(396, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(601, 69)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LAMINATE SHEETS"
        '
        'btnProDtl
        '
        Me.btnProDtl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProDtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProDtl.Location = New System.Drawing.Point(302, 570)
        Me.btnProDtl.Name = "btnProDtl"
        Me.btnProDtl.Size = New System.Drawing.Size(218, 102)
        Me.btnProDtl.TabIndex = 5
        Me.btnProDtl.Text = "Products"
        Me.btnProDtl.UseVisualStyleBackColor = False
        '
        'btnRawDtl
        '
        Me.btnRawDtl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnRawDtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRawDtl.Location = New System.Drawing.Point(657, 570)
        Me.btnRawDtl.Name = "btnRawDtl"
        Me.btnRawDtl.Size = New System.Drawing.Size(218, 102)
        Me.btnRawDtl.TabIndex = 6
        Me.btnRawDtl.Text = "Raw Materials"
        Me.btnRawDtl.UseVisualStyleBackColor = False
        '
        'btnSupDtl
        '
        Me.btnSupDtl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSupDtl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupDtl.Location = New System.Drawing.Point(989, 570)
        Me.btnSupDtl.Name = "btnSupDtl"
        Me.btnSupDtl.Size = New System.Drawing.Size(218, 102)
        Me.btnSupDtl.TabIndex = 7
        Me.btnSupDtl.Text = "Suppliers"
        Me.btnSupDtl.UseVisualStyleBackColor = False
        '
        'mnuHom
        '
        Me.mnuHom.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuHom.Dock = System.Windows.Forms.DockStyle.Left
        Me.mnuHom.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHom.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuHom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.mnuToBuy, Me.mnuSup, Me.mnuDel, Me.mnuMan})
        Me.mnuHom.Location = New System.Drawing.Point(0, 0)
        Me.mnuHom.Name = "mnuHom"
        Me.mnuHom.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.mnuHom.Size = New System.Drawing.Size(254, 704)
        Me.mnuHom.TabIndex = 8
        Me.mnuHom.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(241, 49)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'mnuSup
        '
        Me.mnuSup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSupNew, Me.mnuSupDtl})
        Me.mnuSup.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSup.ForeColor = System.Drawing.Color.Firebrick
        Me.mnuSup.Name = "mnuSup"
        Me.mnuSup.Size = New System.Drawing.Size(241, 49)
        Me.mnuSup.Text = "Suppliers"
        '
        'mnuSupNew
        '
        Me.mnuSupNew.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuSupNew.Name = "mnuSupNew"
        Me.mnuSupNew.Size = New System.Drawing.Size(268, 50)
        Me.mnuSupNew.Text = "New Entry"
        '
        'mnuSupDtl
        '
        Me.mnuSupDtl.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuSupDtl.Name = "mnuSupDtl"
        Me.mnuSupDtl.Size = New System.Drawing.Size(268, 50)
        Me.mnuSupDtl.Text = "Details"
        '
        'mnuToBuy
        '
        Me.mnuToBuy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAlrReg, Me.mnuNewReg})
        Me.mnuToBuy.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuToBuy.ForeColor = System.Drawing.Color.Firebrick
        Me.mnuToBuy.Name = "mnuToBuy"
        Me.mnuToBuy.Size = New System.Drawing.Size(241, 49)
        Me.mnuToBuy.Text = "To Buy"
        '
        'mnuAlrReg
        '
        Me.mnuAlrReg.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuAlrReg.Name = "mnuAlrReg"
        Me.mnuAlrReg.Size = New System.Drawing.Size(399, 50)
        Me.mnuAlrReg.Text = "Already Registered"
        '
        'mnuNewReg
        '
        Me.mnuNewReg.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuNewReg.Name = "mnuNewReg"
        Me.mnuNewReg.Size = New System.Drawing.Size(399, 50)
        Me.mnuNewReg.Text = "New Registration"
        '
        'mnuDel
        '
        Me.mnuDel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDelManReg, Me.mnuToDel, Me.mnuDelDtl})
        Me.mnuDel.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDel.ForeColor = System.Drawing.Color.Firebrick
        Me.mnuDel.Name = "mnuDel"
        Me.mnuDel.Size = New System.Drawing.Size(241, 49)
        Me.mnuDel.Text = "Delivery"
        '
        'mnuDelManReg
        '
        Me.mnuDelManReg.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuDelManReg.Name = "mnuDelManReg"
        Me.mnuDelManReg.Size = New System.Drawing.Size(396, 50)
        Me.mnuDelManReg.Text = "DeliveryMan Entry"
        '
        'mnuToDel
        '
        Me.mnuToDel.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuToDel.Name = "mnuToDel"
        Me.mnuToDel.Size = New System.Drawing.Size(396, 50)
        Me.mnuToDel.Text = "To Deliver"
        '
        'mnuDelDtl
        '
        Me.mnuDelDtl.BackColor = System.Drawing.Color.NavajoWhite
        Me.mnuDelDtl.Name = "mnuDelDtl"
        Me.mnuDelDtl.Size = New System.Drawing.Size(396, 50)
        Me.mnuDelDtl.Text = "Delivery Details"
        '
        'mnuMan
        '
        Me.mnuMan.ForeColor = System.Drawing.Color.Firebrick
        Me.mnuMan.Name = "mnuMan"
        Me.mnuMan.Size = New System.Drawing.Size(241, 49)
        Me.mnuMan.Text = "Manufaturing"
        '
        'frmHom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1244, 704)
        Me.Controls.Add(Me.mnuHom)
        Me.Controls.Add(Me.btnSupDtl)
        Me.Controls.Add(Me.btnRawDtl)
        Me.Controls.Add(Me.btnProDtl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmHom"
        Me.Text = "frmHom"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuHom.ResumeLayout(False)
        Me.mnuHom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProDtl As Button
    Friend WithEvents btnRawDtl As Button
    Friend WithEvents btnSupDtl As Button
    Friend WithEvents mnuHom As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuToBuy As ToolStripMenuItem
    Friend WithEvents mnuSup As ToolStripMenuItem
    Friend WithEvents mnuAlrReg As ToolStripMenuItem
    Friend WithEvents mnuNewReg As ToolStripMenuItem
    Friend WithEvents mnuDel As ToolStripMenuItem
    Friend WithEvents mnuSupNew As ToolStripMenuItem
    Friend WithEvents mnuSupDtl As ToolStripMenuItem
    Friend WithEvents mnuDelManReg As ToolStripMenuItem
    Friend WithEvents mnuMan As ToolStripMenuItem
    Friend WithEvents mnuToDel As ToolStripMenuItem
    Friend WithEvents mnuDelDtl As ToolStripMenuItem
End Class
