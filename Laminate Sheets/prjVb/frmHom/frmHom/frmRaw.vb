Imports System.Data.OleDb
Public Class frmRaw
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim t1 As DataTable

    Private Sub frmRaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbRawMat"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvRaw.DataSource = ds.Tables(0)
        Call pAutGenRawCod()
    End Sub

    Private Sub dgvRaw_Click(sender As Object, e As EventArgs) Handles dgvRaw.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvRaw.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvRaw.CurrentRow.Index)
        txtrawCod.Text = myRow("rawCod")
        txtrawGrn.Text = myRow("rawGrn").ToString
        txtrawNam.Text = myRow("rawNam")
        txtrawPrc.Text = myRow("rawPrc")
        txtrawQty.Text = myRow("rawQty")
        txtrawShd.Text = myRow("rawShd").ToString
        txtrawSiz.Text = myRow("rawSiz")
        txtrawSubTyp.Text = myRow("rawSubTyp").ToString
        txtrawTyp.Text = myRow("rawTyp")
    End Sub
    Private Sub pAutGenRawCod()
        Dim nNxtRawCod As Integer
        cmd = New OleDbCommand("Select max(rawCod) from tbRawMat", dbcon)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) Then
            nNxtRawCod = 2001
            txtrawCod.Text = nNxtRawCod
        Else
            nNxtRawCod = dr.Item(0)
            nNxtRawCod = nNxtRawCod + 1
            txtrawCod.Text = nNxtRawCod
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sAdd As String
        sAdd = "insert into tbRawMat values(" & txtrawCod.Text & ",'" & txtrawNam.Text & "','" & txtrawTyp.Text & "','" & txtrawSubTyp.Text.ToString & "','" & txtrawGrn.Text.ToString & "','" & txtrawShd.Text.ToString & "','" & txtrawSiz.Text & "'," & txtrawQty.Text & "," & txtrawPrc.Text & ")"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("RECORD IS INSERTED")
    End Sub

    Private Sub btnUpt_Click(sender As Object, e As EventArgs) Handles btnUpt.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSql As String
        sSql = "update tbRawMat set rawNam = '" & txtrawNam.Text & "',rawTyp = '" & txtrawTyp.Text & "',rawSubTyp ='" & txtrawSubTyp.Text & "',rawGrn ='" & txtrawGrn.Text & "',rawShd ='" & txtrawShd.Text & "',rawQty = " & txtrawQty.Text & ",rawPrc = " & txtrawPrc.Text & ",rawSiz= '" & txtrawSiz.Text & "' where rawCod= " & txtrawCod.Text
        cmd = New OleDbCommand(sSql, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Updated")
        txtrawGrn.Text = ""
        txtrawNam.Text = ""
        txtrawPrc.Text = ""
        txtrawQty.Text = ""
        txtrawShd.Text = ""
        txtrawSubTyp.Text = ""
        txtrawTyp.Text = ""
        txtrawSiz.Text = ""
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        txtrawGrn.Text = ""
        txtrawNam.Text = ""
        txtrawPrc.Text = ""
        txtrawQty.Text = ""
        txtrawShd.Text = ""
        txtrawSubTyp.Text = ""
        txtrawTyp.Text = ""
        txtrawSiz.Text = ""
        Call pAutGenRawCod()
    End Sub

    Private Sub frmRaw_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class