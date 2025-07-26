Public Class frmHom

    Private Sub frmHom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pConnectDB()
    End Sub

    Private Sub mnuAlrReg_Click(sender As Object, e As EventArgs) Handles mnuAlrReg.Click, mnuNewReg.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        Select Case sender.name
            Case "mnuAlrReg"
                frmCusOdr.Show()
            Case "mnuNewReg"
                frmCus.Show()
        End Select
    End Sub

    Private Sub mnuSupNew_Click(sender As Object, e As EventArgs) Handles mnuSupNew.Click, mnuSupDtl.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        Select Case sender.name
            Case "mnuSupNew"
                frmSup.Show()
            Case "mnuSupDtl"
                frmSupDtl.Show()
        End Select
    End Sub

    Private Sub mnuDelManReg_Click(sender As Object, e As EventArgs) Handles mnuDelManReg.Click, mnuToDel.Click, mnuDelDtl.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        Select Case sender.name
            Case "mnuDelManReg"
                frmDelMan.Show()
            Case "mnuToDel"
                frmDelPro.Show()
            Case "mnuDelDtl"
                frmDelDtl.Show()
        End Select
    End Sub

    Private Sub mnuMan_Click(sender As Object, e As EventArgs) Handles mnuMan.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmManRaw.Show()
    End Sub

    Private Sub btnProDtl_Click(sender As Object, e As EventArgs) Handles btnProDtl.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmPro.Show()
    End Sub

    Private Sub btnRawDtl_Click(sender As Object, e As EventArgs) Handles btnRawDtl.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmRaw.Show()
    End Sub

    Private Sub btnSupDtl_Click(sender As Object, e As EventArgs) Handles btnSupDtl.Click
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
        frmSupDtl.Show()
    End Sub
End Class
