Imports System.Data.OleDb
Public Class frmSupDtl
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim t1 As DataTable

    Private Sub frmSupDtl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbSup"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvSup.DataSource = ds.Tables(0)
    End Sub

    Public Sub ploadRawMat()
        Dim sSlct As String
        sSlct = "Select * from tbRawMat"
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cborawCod.Items.Add(dr.Item("rawNam"))
        End While
    End Sub

    Private Sub btnShw_Click(sender As Object, e As EventArgs) Handles btnShw.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Call ploadRawMat()
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvSup.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvSup.CurrentRow.Index)
        txtsupNam.Text = myRow("supNam")
        txtsupCod.Text = myRow("supCod")
        txtsupPhn.Text = myRow("supPhn")
        txtsupPrc.Text = myRow("supPrc")
        txtsupEml.Text = myRow("supEml")
        txtsupAdr.Text = myRow("supAdr")
        txtrawCod.Text = myRow("rawCod")

        Dim sSlct As String
        sSlct = "Select rawNam from tbRawMat where rawCod = " & txtrawCod.Text
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblrawNam.Text = dr.Item("rawNam")
        cborawCod.SelectedItem = lblrawNam.Text
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSlct As String
        sSlct = "Delete from tbSup where supCod = " & txtsupCod.Text
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        MessageBox.Show("RECORD IS DELETED")
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmSup.Show()
    End Sub

    Private Sub btnUpt_Click(sender As Object, e As EventArgs) Handles btnUpt.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSql As String
        If txtsupNam.Text = "" Or txtsupPhn.Text = "" Or txtsupPrc.Text = "" Or txtsupEml.Text = "" Or txtsupAdr.Text = "" Or txtrawCod.Text = "" Or cborawCod.Text = "" Then Exit Sub
        sSql = "update tbSup set supNam = '" & txtsupNam.Text & "',supPhn = " & txtsupPhn.Text & ",supPrc =" & txtsupPrc.Text & ",supEml = '" & txtsupEml.Text & "',supAdr ='" & txtsupAdr.Text & "',rawCod= " & txtrawCod.Text & " where supCod=" & txtsupCod.Text
        Try
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        Finally
            dbcon.Close()
        End Try
        txtsupNam.Text = ""
        txtsupPhn.Text = ""
        txtsupPrc.Text = ""
        txtsupEml.Text = ""
        txtsupAdr.Text = ""
        txtrawCod.Text = ""
        cborawCod.Text = ""
        txtsupCod.Text = ""
        MessageBox.Show("Updated")


    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub

    Private Sub txtrawCod_LostFocus(sender As Object, e As EventArgs) Handles txtrawCod.LostFocus
        Dim sSlct As String
        sSlct = "Select rawNam from tbRawMat where rawCod = " & txtrawCod.Text
        cmd = New OleDbCommand(sSlct, dbcon)
        dr = cmd.ExecuteReader()
        dr.Read()
        lblrawNam.Text = dr.Item("rawNam")
        cborawCod.SelectedItem = lblrawNam.Text
    End Sub
End Class