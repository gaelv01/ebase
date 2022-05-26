Imports MySql.Data.MySqlClient
Public Class FrmVerComponentes
    Private Sub FrmVerComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim lc As New LComponentes
            Dim dt As DataTable = lc.consultarComponentes()
            dgvComponentes.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Try
            Dim lc As New LComponentes
            Dim dt As DataTable = lc.consultarComponentes()
            dgvComponentes.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class