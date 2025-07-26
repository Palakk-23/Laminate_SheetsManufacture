Imports System.Data.OleDb
Public Class frmDelMan
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub frmDelMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Call pAutGenDelCod()
    End Sub

    Private Sub frmDelMan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub pAutGenDelCod()
        Dim nNxtDelCod As Integer
        cmd = New OleDbCommand("Select max(delCod) from tbDelMan", dbcon)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) Then
            nNxtDelCod = 301
            txtdelCod.Text = nNxtDelCod
        Else
            nNxtDelCod = dr.Item(0)
            nNxtDelCod = nNxtDelCod + 1
            txtdelCod.Text = nNxtDelCod
        End If
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim sAdd As String
        sAdd = "insert into tbDelMan values(" & txtdelCod.Text & ",'" & txtdelNam.Text & "','" & txtvehNum.Text & "','" & txtvehTyp.Text & "','" & txtdelAdr.Text & "')"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
        txtdelCod.Text = ""
        txtdelNam.Text = ""
        txtvehNum.Text = ""
        txtvehTyp.Text = ""
        txtdelAdr.Text = ""
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class