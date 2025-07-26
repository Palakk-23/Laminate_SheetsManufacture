Imports System.Data.OleDb
Public Class frmManRaw
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim t1 As DataTable

    Private Sub frmManRaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbRawFin"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvRawFin.DataSource = ds.Tables(0)
    End Sub

    Private Sub dgvRawFin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRawFin.CellClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvRawFin.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvRawFin.CurrentRow.Index)
        txtproCod.Text = myRow("proCod")
        txtrawCod.Text = myRow("rawCod")
        txtrawQty.Text = myRow("rawQty")
        txtrawDat.Text = myRow("rawFinDat")
    End Sub

    Private Sub frmManRaw_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class