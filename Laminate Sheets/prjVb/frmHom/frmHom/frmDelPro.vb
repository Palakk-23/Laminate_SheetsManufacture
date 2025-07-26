Imports System.Data.OleDb
Public Class frmDelPro
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub frmDelPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Call ploadcbocusCod()
        Dim sql As String
        sql = "select * from tbDelMan"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvDel.DataSource = ds.Tables(0)
    End Sub

    Public Sub ploadcbocusCod()
        Dim sSlct As String
        sSlct = "Select * from tbCusOdr"
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cboCusCod.Items.Add(dr.Item("cusCod"))
        End While
    End Sub

    Private Sub frmDelPro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Public Sub pShow()
        Dim slct As String
        Dim cusCod As Integer
        cusCod = cboCusCod.SelectedItem
        slct = "Select * from tbCusOdr where cusCod =" & cusCod
        cmd = New OleDbCommand(slct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        txtProCod.Text = dr.Item("proCod")
        txtDelQty.Text = dr.Item("cusOdrQty")
    End Sub

    Private Sub cboCusCod_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCusCod.SelectedValueChanged
        Call pShow()
    End Sub

    Private Sub dgvDel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDel.CellClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvDel.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvDel.CurrentRow.Index)
        txtDelCod.Text = myRow("delCod")
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim sAdd As String
        Dim myDate As Date
        myDate = Format(dtpDelDat.Value, "dd/MMMM/yyyy")
        sAdd = "insert into tbDel values(" & txtDelCod.Text & "," & cboCusCod.SelectedItem & "," & txtProCod.Text & "," & txtDelQty.Text & ",#" & myDate & "#)"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class