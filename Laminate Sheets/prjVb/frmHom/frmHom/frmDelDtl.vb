Imports System.Data.OleDb
Public Class frmDelDtl
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim t1 As DataTable

    Private Sub frmDelDtl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbDel"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvDelDtl.DataSource = ds.Tables(0)
    End Sub

    Private Sub frmDelDtl_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub dgvDelDtl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDelDtl.CellClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvDelDtl.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvDelDtl.CurrentRow.Index)
        txtdelCod.Text = myRow("delCod")
        txtproCod.Text = myRow("proCod")
        txtcusCod.Text = myRow("cusCod")
        txtdelProQty.Text = myRow("delProQty")
        txtdelDat.Text = myRow("delDat")
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class