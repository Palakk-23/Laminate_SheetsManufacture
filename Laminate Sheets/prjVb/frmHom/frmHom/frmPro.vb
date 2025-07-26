Imports System.Data.OleDb
Public Class frmPro
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim t1 As DataTable

    Private Sub frmPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbcon.State = ConnectionState.Closed Then Call pConnectDB()
        Dim sql As String
        sql = "select * from tbFinPro"
        adp = New OleDbDataAdapter(sql, dbcon)
        ds = New DataSet
        adp.Fill(ds)
        dgvPro.DataSource = ds.Tables(0)
        Call pAutGenProCod()
    End Sub

    Private Sub pAutGenProCod()
        Dim nNxtProCod As Integer
        cmd = New OleDbCommand("Select max(proCod) from tbFinPro", dbcon)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) Then
            nNxtProCod = 1001
            txtproCod.Text = nNxtProCod
        Else
            nNxtProCod = dr.Item(0)
            nNxtProCod = nNxtProCod + 1
            txtproCod.Text = nNxtProCod
        End If
    End Sub

    Private Sub btnShw_Click(sender As Object, e As EventArgs) Handles btnShw.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If dgvPro.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myRow As DataRow = t1.Rows(dgvPro.CurrentRow.Index)
        txtproNam.Text = myRow("proNam")
        txtproCod.Text = myRow("proCod")
        txtproQty.Text = myRow("proQty")
        txtproPrc.Text = myRow("proPrc")
        txtproSiz.Text = myRow("proSiz")
        txtproThk.Text = myRow("proThk")
        txtproTyp.Text = myRow("proTyp")
    End Sub

    Private Sub btnUpt_Click(sender As Object, e As EventArgs) Handles btnUpt.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sSql As String
        If txtproNam.Text = "" Or txtproCod.Text = "" Or txtproPrc.Text = "" Or txtproQty.Text = "" Or txtproSiz.Text = "" Or txtproThk.Text = "" Or txtproTyp.Text = "" Then Exit Sub
        sSql = "update tbFinPro set proNam = '" & txtproNam.Text & "',proTyp = '" & txtproTyp.Text & "',proThk ='" & txtproThk.Text & "',proSiz ='" & txtproSiz.Text & "',proPrc= " & txtproPrc.Text & ",proQty =" & txtproQty.Text & " where proCod=" & txtproCod.Text
        Try
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Invalid" & ex.Message)
        Finally
            dbcon.Close()
        End Try
        txtproCod.Text = ""
        txtproNam.Text = ""
        txtproPrc.Text = ""
        txtproQty.Text = ""
        txtproSiz.Text = ""
        txtproThk.Text = ""
        txtproTyp.Text = ""
        MessageBox.Show("Record is Updated")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dbcon.State = ConnectionState.Closed Then
            dbcon.Open()
        End If
        Dim sAdd As String
        sAdd = "insert into tbFinPro values(" & txtproCod.Text & ",'" & txtproNam.Text & "','" & txtproTyp.Text & "','" & txtproThk.Text & "','" & txtproSiz.Text & "'," & txtproQty.Text & "," & txtproPrc.Text & ")"
        cmd = New OleDbCommand(sAdd, dbcon)
        cmd.ExecuteNonQuery()
        MessageBox.Show("New Product is Added")
    End Sub

    Private Sub frmPro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call pDisconnectDB()
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        'If dbcon.State = ConnectionState.Closed Then
        '    dbcon.Open()
        'End If
        txtproCod.Text = ""
        txtproNam.Text = ""
        txtproPrc.Text = ""
        txtproQty.Text = ""
        txtproSiz.Text = ""
        txtproThk.Text = ""
        txtproTyp.Text = ""
        Call pAutGenProCod()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub
End Class