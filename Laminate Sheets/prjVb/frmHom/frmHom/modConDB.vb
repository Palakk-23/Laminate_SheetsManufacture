Imports System.Data.OleDb
Module modConDB
    Public dbcon As New OleDbConnection
    Public Sub pConnectDB()
        dbcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\prjVb\dbPrj.accdb"
        dbcon.Open()
    End Sub

    Public Sub pDisconnectDB()
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
        End If
    End Sub
End Module
