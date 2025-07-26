Imports System.Data.OleDb
Public Class frmSup
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmSup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Call ploadRawMat()
        Call pAutGenSupCod()
    End Sub

    Private Sub frmSup_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub pAutGenSupCod()
        Dim nNxtSupCod As Integer
        cmd = New OleDbCommand("Select max(supCod) from tbSup", dbcon)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) Then
            nNxtSupCod = 201
            txtsupCod.Text = nNxtSupCod
        Else
            nNxtSupCod = dr.Item(0)
            nNxtSupCod = nNxtSupCod + 1
            txtsupCod.Text = nNxtSupCod
        End If
    End Sub

    Public Sub ploadRawMat()
        adp = New OleDbDataAdapter("Select * from tbRawMat", dbcon)
        adp.Fill(ds, "tbRawMat")
        cborawCod.DataSource = ds.Tables(0)
        cborawCod.ValueMember = "rawCod"
        cborawCod.DisplayMember = "rawNam"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim sAdd As String
        Dim rawCod As Integer
        rawCod = cborawCod.SelectedValue.ToString()
        sAdd = "insert into tbSup values(" & txtsupCod.Text & ",'" & txtsupNam.Text & "','" & txtsupPhn.Text & "','" & txtsupEml.Text & "','" & txtsupAdr.Text & "'," & rawCod & ",'" & txtsupPrc.Text & "')"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class