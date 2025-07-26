Imports System.Data.OleDb
Public Class frmRawSup
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub frmRawSup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbSup"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvSup.DataSource = ds.Tables(0)
        txtRawCod.Text = frmRawFin.lblRawCod.Text
        txtRawNam.Text = frmRawFin.lblRawNam.Text
        txtRawQty.Text = frmRawFin.txtQty.Text
        Call prawQty()
    End Sub

    Private Sub prawQty()
        Dim slct As String
        Dim iRawQtySup As Integer
        slct = "Select rawQty from tbRawMat where rawCod =" & txtRawCod.Text
        cmd = New OleDbCommand(slct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        iRawQtySup = dr.Item("rawQty")
        txtRawQtySup.Text = frmRawFin.txtQty.Text - iRawQtySup
    End Sub

    Private Sub ploadDgv()
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvSup.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvSup.CurrentRow.Index)
    End Sub

    Private Sub btnSupOdr_Click(sender As Object, e As EventArgs) Handles btnSupOdr.Click
        Dim sAdd As String
        Dim myDate As Date
        myDate = Format(dtpPurDat.Value, "dd/MMMM/yyyy")
        sAdd = "insert into tbRawSup values(" & txtSupCod.Text & "," & txtRawCod.Text & ",'" & txtRawNam.Text & "'," & txtRawQtySup.Text & ",#" & myDate & "#," & txtTotPri.Text & ")"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
        Call pUpd()
        btnMan.Visible = True
    End Sub

    Private Sub btnMan_Click(sender As Object, e As EventArgs) Handles btnMan.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmRawFin.Activate()
    End Sub

    Private Sub dgvSup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSup.CellClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvSup.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvSup.CurrentRow.Index)
        txtSupCod.Text = myRow("supCod")
        txtSupPri.Text = myRow("supPrc")
        Dim iTotPri As Integer
        Dim iSupPri As Integer
        Dim iRawQty As Integer
        iSupPri = txtSupPri.Text
        iRawQty = txtRawQtySup.Text
        iTotPri = iSupPri * iRawQty
        txtTotPri.Text = iTotPri
    End Sub

    Private Sub pUpd()
        Dim sSql As String
        Dim iNewRawQty As Integer
        Dim a As Integer
        Dim b As Integer
        a = txtRawQty.Text
        b = txtRawQtySup.Text

        iNewRawQty = a + b
        sSql = "update tbRawMat set rawQty = " & iNewRawQty & " where rawCod = " & txtRawCod.Text
        cmd = New OleDbCommand(sSql, dbcon)
        cmd.ExecuteNonQuery()
        btnMan.Visible = True
        MessageBox.Show("RECORD IS UPDATED")
    End Sub
End Class