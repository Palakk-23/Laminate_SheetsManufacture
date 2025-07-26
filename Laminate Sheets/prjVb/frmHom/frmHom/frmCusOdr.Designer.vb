<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCusOdr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusOdr))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcusCod = New System.Windows.Forms.Label()
        Me.lblcusEml = New System.Windows.Forms.Label()
        Me.lblcusPhn = New System.Windows.Forms.Label()
        Me.txtcusOdrQty = New System.Windows.Forms.TextBox()
        Me.dtpcusDatPur = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOdr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboproTyp = New System.Windows.Forms.ComboBox()
        Me.cboproNam = New System.Windows.Forms.ComboBox()
        Me.btnCfm = New System.Windows.Forms.Button()
        Me.cbocusCod = New System.Windows.Forms.ComboBox()
        Me.cborawTyp = New System.Windows.Forms.ComboBox()
        Me.cborawNam = New System.Windows.Forms.ComboBox()
        Me.txtproCod = New System.Windows.Forms.TextBox()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.lblProQty = New System.Windows.Forms.Label()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(201, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ORDER FORM"
        '
        'lblcusCod
        '
        Me.lblcusCod.AutoSize = True
        Me.lblcusCod.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusCod.Image = CType(resources.GetObject("lblcusCod.Image"), System.Drawing.Image)
        Me.lblcusCod.Location = New System.Drawing.Point(263, 114)
        Me.lblcusCod.Name = "lblcusCod"
        Me.lblcusCod.Size = New System.Drawing.Size(225, 32)
        Me.lblcusCod.TabIndex = 4
        Me.lblcusCod.Text = "Customer Code"
        '
        'lblcusEml
        '
        Me.lblcusEml.AutoSize = True
        Me.lblcusEml.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusEml.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusEml.Image = CType(resources.GetObject("lblcusEml.Image"), System.Drawing.Image)
        Me.lblcusEml.Location = New System.Drawing.Point(368, 166)
        Me.lblcusEml.Name = "lblcusEml"
        Me.lblcusEml.Size = New System.Drawing.Size(120, 32)
        Me.lblcusEml.TabIndex = 11
        Me.lblcusEml.Text = "Product"
        '
        'lblcusPhn
        '
        Me.lblcusPhn.AutoSize = True
        Me.lblcusPhn.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblcusPhn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusPhn.Image = CType(resources.GetObject("lblcusPhn.Image"), System.Drawing.Image)
        Me.lblcusPhn.Location = New System.Drawing.Point(279, 215)
        Me.lblcusPhn.Name = "lblcusPhn"
        Me.lblcusPhn.Size = New System.Drawing.Size(215, 32)
        Me.lblcusPhn.TabIndex = 13
        Me.lblcusPhn.Text = "Order Quantity"
        '
        'txtcusOdrQty
        '
        Me.txtcusOdrQty.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtcusOdrQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusOdrQty.Location = New System.Drawing.Point(614, 215)
        Me.txtcusOdrQty.Name = "txtcusOdrQty"
        Me.txtcusOdrQty.Size = New System.Drawing.Size(198, 30)
        Me.txtcusOdrQty.TabIndex = 14
        '
        'dtpcusDatPur
        '
        Me.dtpcusDatPur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcusDatPur.Location = New System.Drawing.Point(615, 269)
        Me.dtpcusDatPur.Name = "dtpcusDatPur"
        Me.dtpcusDatPur.Size = New System.Drawing.Size(223, 30)
        Me.dtpcusDatPur.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(290, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date Of Order"
        '
        'btnOdr
        '
        Me.btnOdr.BackColor = System.Drawing.Color.GreenYellow
        Me.btnOdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOdr.Location = New System.Drawing.Point(615, 578)
        Me.btnOdr.Name = "btnOdr"
        Me.btnOdr.Size = New System.Drawing.Size(160, 66)
        Me.btnOdr.TabIndex = 17
        Me.btnOdr.Text = "ORDER"
        Me.btnOdr.UseVisualStyleBackColor = False
        Me.btnOdr.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(279, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 32)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Customization"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(175, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(313, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Choose Raw Material:"
        '
        'cboproTyp
        '
        Me.cboproTyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboproTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproTyp.FormattingEnabled = True
        Me.cboproTyp.Location = New System.Drawing.Point(614, 165)
        Me.cboproTyp.Name = "cboproTyp"
        Me.cboproTyp.Size = New System.Drawing.Size(308, 33)
        Me.cboproTyp.TabIndex = 21
        '
        'cboproNam
        '
        Me.cboproNam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboproNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproNam.FormattingEnabled = True
        Me.cboproNam.Location = New System.Drawing.Point(935, 165)
        Me.cboproNam.Name = "cboproNam"
        Me.cboproNam.Size = New System.Drawing.Size(299, 33)
        Me.cboproNam.TabIndex = 22
        '
        'btnCfm
        '
        Me.btnCfm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCfm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCfm.Location = New System.Drawing.Point(614, 314)
        Me.btnCfm.Name = "btnCfm"
        Me.btnCfm.Size = New System.Drawing.Size(159, 51)
        Me.btnCfm.TabIndex = 28
        Me.btnCfm.Text = "CONFIRM"
        Me.btnCfm.UseVisualStyleBackColor = False
        '
        'cbocusCod
        '
        Me.cbocusCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbocusCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocusCod.FormattingEnabled = True
        Me.cbocusCod.Location = New System.Drawing.Point(615, 117)
        Me.cbocusCod.Name = "cbocusCod"
        Me.cbocusCod.Size = New System.Drawing.Size(121, 33)
        Me.cbocusCod.TabIndex = 29
        '
        'cborawTyp
        '
        Me.cborawTyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cborawTyp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborawTyp.FormattingEnabled = True
        Me.cborawTyp.Location = New System.Drawing.Point(614, 436)
        Me.cborawTyp.Name = "cborawTyp"
        Me.cborawTyp.Size = New System.Drawing.Size(308, 33)
        Me.cborawTyp.TabIndex = 34
        '
        'cborawNam
        '
        Me.cborawNam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cborawNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cborawNam.FormattingEnabled = True
        Me.cborawNam.Location = New System.Drawing.Point(935, 436)
        Me.cborawNam.Name = "cborawNam"
        Me.cborawNam.Size = New System.Drawing.Size(299, 33)
        Me.cborawNam.TabIndex = 35
        '
        'txtproCod
        '
        Me.txtproCod.Enabled = False
        Me.txtproCod.Location = New System.Drawing.Point(209, 9)
        Me.txtproCod.Name = "txtproCod"
        Me.txtproCod.Size = New System.Drawing.Size(100, 22)
        Me.txtproCod.TabIndex = 37
        Me.txtproCod.Visible = False
        '
        'btnChk
        '
        Me.btnChk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChk.Location = New System.Drawing.Point(613, 502)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(177, 51)
        Me.btnChk.TabIndex = 39
        Me.btnChk.Text = "CHECK"
        Me.btnChk.UseVisualStyleBackColor = False
        Me.btnChk.Visible = False
        '
        'lblProQty
        '
        Me.lblProQty.AutoSize = True
        Me.lblProQty.Location = New System.Drawing.Point(35, 96)
        Me.lblProQty.Name = "lblProQty"
        Me.lblProQty.Size = New System.Drawing.Size(0, 17)
        Me.lblProQty.TabIndex = 40
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(1061, 593)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 41
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmCusOdr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1255, 676)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.lblProQty)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.cborawNam)
        Me.Controls.Add(Me.cborawTyp)
        Me.Controls.Add(Me.cbocusCod)
        Me.Controls.Add(Me.btnCfm)
        Me.Controls.Add(Me.cboproNam)
        Me.Controls.Add(Me.cboproTyp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnOdr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpcusDatPur)
        Me.Controls.Add(Me.txtcusOdrQty)
        Me.Controls.Add(Me.lblcusPhn)
        Me.Controls.Add(Me.lblcusEml)
        Me.Controls.Add(Me.lblcusCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproCod)
        Me.Name = "frmCusOdr"
        Me.Text = "Customer Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcusCod As Label
    Friend WithEvents lblcusEml As Label
    Friend WithEvents lblcusPhn As Label
    Friend WithEvents txtcusOdrQty As TextBox
    Friend WithEvents dtpcusDatPur As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOdr As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboproTyp As ComboBox
    Friend WithEvents cboproNam As ComboBox
    Friend WithEvents btnCfm As Button
    Friend WithEvents cbocusCod As ComboBox
    Friend WithEvents cborawTyp As ComboBox
    Friend WithEvents cborawNam As ComboBox
    Friend WithEvents txtproCod As TextBox
    Friend WithEvents btnChk As Button
    Friend WithEvents lblProQty As Label
    Friend WithEvents btnExt As Button
End Class
