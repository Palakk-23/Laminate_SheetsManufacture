Imports System.Data.OleDb
Public Class frmCus
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub frmCus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Call pAutGenCusCod()
    End Sub

    Private Sub frmCus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub
    Private Sub pAutGenCusCod()
        Dim nNxtCusCod As Integer
        cmd = New OleDbCommand("Select max(cusCod) from tbCus", dbcon)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) Then
            nNxtCusCod = 101
            txtcusCod.Text = nNxtCusCod
        Else
            nNxtCusCod = dr.Item(0)
            nNxtCusCod = nNxtCusCod + 1
            txtcusCod.Text = nNxtCusCod
        End If
    End Sub

    Private Sub btncusReg_Click(sender As Object, e As EventArgs) Handles btncusReg.Click
        Dim sAdd As String
        sAdd = "insert into tbCus values(" & txtcusCod.Text & ",'" & txtcusNam.Text & "','" & txtcusPhn.Text & "','" & txtcusEml.Text & "','" & txtcusAdr.Text & "','" & txtcusLoc.Text & "')"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Customer is Registered")
        txtcusCod.Text = ""
        txtcusNam.Text = ""
        txtcusEml.Text = ""
        txtcusPhn.Text = ""
        txtcusLoc.Text = ""
        txtcusAdr.Text = ""
        btnNxt.Visible = True
    End Sub

    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        Call pDisconnectDB()
        frmCusOdr.Show()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class