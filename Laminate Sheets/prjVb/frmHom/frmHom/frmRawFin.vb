Imports System.Data.OleDb
Public Class frmRawFin
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmRawFin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim iproCod As Integer
        Dim irawNam As String
        iproCod = frmCusOdr.txtproCod.Text
        irawNam = frmCusOdr.cborawNam.Text
        lblProCod.Text = iproCod
        lblRawNam.Text = irawNam
        Call prawCod()
    End Sub

    Private Sub prawCod()
        Dim slct As String
        slct = "Select rawCod from tbRawMat where rawNam ='" & lblRawNam.Text & "'"
        cmd = New OleDbCommand(slct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblRawCod.Text = dr.Item("rawCod")
    End Sub

    Private Sub btnChk_Click(sender As Object, e As EventArgs) Handles btnChk.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSlct As String
        Dim iRawQty As Integer
        sSlct = "Select rawQty from tbRawMat where rawCod=" & lblRawCod.Text
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        iRawQty = dr("rawQty")
        If txtQty.Text < iRawQty Then
            btnMan.Visible = True
        ElseIf txtQty.Text > iRawQty Then
            If dbcon.State = ConnectionState.Open Then
                dbcon.Close()
                frmRawSup.Show()
            End If
        End If
        lblRawQty.Text = iRawQty
    End Sub

    Private Sub btnOdr_Click(sender As Object, e As EventArgs) Handles btnOdr.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
            frmCusOdr.Activate()
        End If
    End Sub

    Private Sub btnMan_Click(sender As Object, e As EventArgs) Handles btnMan.Click
        Dim sAdd As String
        Dim myDate As Date
        myDate = Format(dtpOdrDat.Value, "dd/MMMM/yyyy")
        sAdd = "insert into tbRawFin values(" & lblProCod.Text & "," & lblRawCod.Text & "," & txtQty.Text & ",#" & mydate & "#)"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
        Call pUpdRaw()
        Call pUpdPro()
        btnOdr.Visible = True
    End Sub

    Private Sub pUpdRaw()
        Dim sSql As String

        Dim iNewRawQty As Integer
        Dim a As Integer
        Dim b As Integer
        a = lblRawQty.Text
        b = txtQty.Text
        iNewRawQty = a - b
        sSql = "update tbRawMat set rawQty = " & iNewRawQty & " where rawCod = " & lblRawCod.Text
        cmd = New OleDbCommand(sSql, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RAW MATERIALS ARE UPDATED")

    End Sub

    Private Sub pUpdPro()
        Dim sSql As String
        Dim a As Integer
        Dim iProQty As Integer
        a = frmCusOdr.txtcusOdrQty.Text
        Dim iNewProQty As Integer
        iProQty = frmCusOdr.lblProQty.Text
        iNewProQty = a + iProQty
        sSql = "update tbFinPro set proQty = " & iNewProQty & " where proCod=" & lblProCod.Text
        cmd = New OleDbCommand(sSql, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("FINISHED GOODS ARE UPDATED")

    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class