Imports System.Data.OleDb
Public Class frmCusOdr
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmCusOdr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Call ploadcboProTyp()
        Call ploadcbocusCod()
    End Sub

    Private Sub frmCusOdr_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Public Sub ploadcbocusCod()
        Dim sSlct As String
        sSlct = "Select * from tbCus"
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cbocusCod.Items.Add(dr.Item("cusCod"))
        End While
        cbocusCod.SelectedIndex = 0
    End Sub

    Private Sub ploadcboProTyp()
        adp = New OleDbDataAdapter("Select distinct proTyp from tbFinPro", dbcon)
        adp.Fill(ds, "tbFinPro")
        cboproTyp.DataSource = ds.Tables(0)
        cboproTyp.ValueMember = "proTyp"
        cboproTyp.DisplayMember = "proTyp"
    End Sub

    Private Sub ploadcboProNam()
        Dim ds1 As New DataSet
        Dim sproTyp As String = cboproTyp.SelectedValue.ToString
        adp = New OleDbDataAdapter("Select proNam from tbFinPro where proTyp = '" & sproTyp & "'", dbcon)
        adp.Fill(ds1, "tbFinPro")
        cboproNam.DataSource = ds1.Tables(0)
        cboproNam.ValueMember = "proNam"
        cboproNam.DisplayMember = "proNam"
    End Sub

    Private Sub ploadrawTyp()
        adp = New OleDbDataAdapter("Select distinct rawTyp from tbRawMat", dbcon)
        adp.Fill(ds, "tbRawMat")
        cborawTyp.DataSource = ds.Tables(1)
        cborawTyp.ValueMember = "rawTyp"
        cborawTyp.DisplayMember = "rawTyp"
    End Sub

    Private Sub ploadrawNam()
        Dim ds1 As New DataSet
        Dim srawTyp As String = cborawTyp.SelectedValue.ToString
        adp = New OleDbDataAdapter("Select rawNam from tbRawMat where rawTyp = '" & srawTyp & "'", dbcon)
        adp.Fill(ds1, "tbRawMat")
        cborawNam.DataSource = ds1.Tables(0)
        cborawNam.ValueMember = "rawNam"
        cborawNam.DisplayMember = "rawNam"
    End Sub

    Private Sub pProCod()
        Dim slct As String
        Dim proNam As String = cboproNam.SelectedValue
        slct = "Select proCod from tbFinPro where proNam ='" & proNam & "'"
        cmd = New OleDbCommand(slct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        txtproCod.Text = dr.Item("proCod")
    End Sub

    Private Sub pProQty()
        Dim slct As String
        Dim proNam As String = cboproNam.SelectedValue
        slct = "Select proQty from tbFinPro where proNam ='" & proNam & "'"
        cmd = New OleDbCommand(slct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblProQty.Text = dr.Item("proQty")
        lblProQty.Visible = False
    End Sub

    Private Sub pUpdate()
        Dim sSql As String
        Dim iUpd As Integer
        Dim a As Integer
        Dim b As Integer
        a = lblProQty.Text
        b = txtcusOdrQty.Text
        If b > a Then
            iUpd = b - a
        Else
            iUpd = a - b
        End If
        sSql = "update tbFinPro set proQty = " & iUpd & " where proCod = " & txtproCod.Text
        cmd = New OleDbCommand(sSql, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS UPDATED")
    End Sub

    Private Sub btnOdr_Click(sender As Object, e As EventArgs) Handles btnOdr.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sAdd As String
        Dim myDate As Date
        Dim RawNam As String
        Dim proCod As Integer
        myDate = Format(dtpcusDatPur.Value, "dd/MMMM/yyyy")
        RawNam = cborawNam.SelectedValue.ToString
        proCod = txtproCod.Text
        sAdd = "insert into tbCusOdr values(" & cbocusCod.SelectedItem & "," & proCod & "," & txtcusOdrQty.Text & ",'" & RawNam & "',#" & myDate & "#)"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
        Call pUpdate()
    End Sub

    Private Sub btnChk_Click(sender As Object, e As EventArgs) Handles btnChk.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSlct As String
        Dim iProQty As Integer
        sSlct = "Select proQty from tbFinPro where proCod=" & txtproCod.Text
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        iProQty = dr("proQty")

        If txtcusOdrQty.Text < iProQty Then
            btnOdr.Visible = True
        Else
            If dbcon.State = ConnectionState.Open Then
                dbcon.Close()
            End If
            frmRawFin.Show()
        End If

    End Sub

    Private Sub cboproTyp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboproTyp.SelectedValueChanged
        Call ploadcboProNam()
    End Sub

    Private Sub cborawTyp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cborawTyp.SelectedValueChanged
        Call ploadrawNam()
    End Sub

    Private Sub cborawNam_SelectedValueChanged(sender As Object, e As EventArgs) Handles cborawNam.SelectedValueChanged
        btnChk.Visible = True
    End Sub

    Private Sub btnCfm_Click(sender As Object, e As EventArgs) Handles btnCfm.Click
        Call ploadrawTyp()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub

    Private Sub cboproNam_TextChanged(sender As Object, e As EventArgs) Handles cboproNam.TextChanged
        Call pProCod()
        Call pProQty()
    End Sub
End Class