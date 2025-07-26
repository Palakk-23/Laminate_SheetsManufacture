<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManRaw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManRaw))
        Me.dgvRawFin = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtproCod = New System.Windows.Forms.TextBox()
        Me.txtrawCod = New System.Windows.Forms.TextBox()
        Me.txtrawQty = New System.Windows.Forms.TextBox()
        Me.txtrawDat = New System.Windows.Forms.TextBox()
        Me.btnExt = New System.Windows.Forms.Button()
        CType(Me.dgvRawFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRawFin
        '
        Me.dgvRawFin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRawFin.Location = New System.Drawing.Point(299, 389)
        Me.dgvRawFin.Name = "dgvRawFin"
        Me.dgvRawFin.RowTemplate.Height = 24
        Me.dgvRawFin.Size = New System.Drawing.Size(600, 235)
        Me.dgvRawFin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(359, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANUFACTURING DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(293, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(293, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Raw Code"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(293, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Raw Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(293, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Manfacturing Date"
        '
        'txtproCod
        '
        Me.txtproCod.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtproCod.Enabled = False
        Me.txtproCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproCod.Location = New System.Drawing.Point(678, 115)
        Me.txtproCod.Name = "txtproCod"
        Me.txtproCod.ReadOnly = True
        Me.txtproCod.Size = New System.Drawing.Size(100, 38)
        Me.txtproCod.TabIndex = 6
        '
        'txtrawCod
        '
        Me.txtrawCod.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtrawCod.Enabled = False
        Me.txtrawCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawCod.Location = New System.Drawing.Point(678, 171)
        Me.txtrawCod.Name = "txtrawCod"
        Me.txtrawCod.ReadOnly = True
        Me.txtrawCod.Size = New System.Drawing.Size(100, 38)
        Me.txtrawCod.TabIndex = 7
        '
        'txtrawQty
        '
        Me.txtrawQty.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtrawQty.Enabled = False
        Me.txtrawQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawQty.Location = New System.Drawing.Point(678, 227)
        Me.txtrawQty.Name = "txtrawQty"
        Me.txtrawQty.ReadOnly = True
        Me.txtrawQty.Size = New System.Drawing.Size(178, 38)
        Me.txtrawQty.TabIndex = 8
        '
        'txtrawDat
        '
        Me.txtrawDat.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtrawDat.Enabled = False
        Me.txtrawDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrawDat.Location = New System.Drawing.Point(678, 283)
        Me.txtrawDat.Name = "txtrawDat"
        Me.txtrawDat.ReadOnly = True
        Me.txtrawDat.Size = New System.Drawing.Size(178, 38)
        Me.txtrawDat.TabIndex = 9
        '
        'btnExt
        '
        Me.btnExt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExt.Location = New System.Drawing.Point(942, 573)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(159, 51)
        Me.btnExt.TabIndex = 42
        Me.btnExt.Text = "EXIT"
        Me.btnExt.UseVisualStyleBackColor = False
        '
        'frmManRaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1244, 673)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.txtrawDat)
        Me.Controls.Add(Me.txtrawQty)
        Me.Controls.Add(Me.txtrawCod)
        Me.Controls.Add(Me.txtproCod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvRawFin)
        Me.Name = "frmManRaw"
        Me.Text = "Manufacturing Details"
        CType(Me.dgvRawFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRawFin As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtproCod As TextBox
    Friend WithEvents txtrawCod As TextBox
    Friend WithEvents txtrawQty As TextBox
    Friend WithEvents txtrawDat As TextBox
    Friend WithEvents btnExt As Button
End Class
