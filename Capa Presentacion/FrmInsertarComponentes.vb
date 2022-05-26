Public Class FrmInsertarComponentes
    Private Sub btnInsertarComponente_Click(sender As Object, e As EventArgs) Handles btnInsertarComponente.Click
        Try
            Dim lc As New LComponentes()


            If validarEspaciosVacios(txtCantidad.Text, txtDescripcion.Text) And validarNumero(txtCantidad.Text) Then

                Dim cant As Integer = Convert.ToInt32(txtCantidad.Text)
                Dim fec As String = DateTime.Now.ToString("yyyyMMdd")
                Dim hor As String = DateTime.Now.ToString("HHmmss")

                lc.insertarComponente(cant, txtDescripcion.Text, fec, hor)
                limpiarCampos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiarCampos()
        txtCantidad.Clear()
        txtDescripcion.Clear()
    End Sub
    Public Function validarEspaciosVacios(nombre As String, clave As String) As Boolean
        If nombre = "" Or clave = "" Then
            MessageBox.Show("Por favor, rellene los campos.")
            limpiarCampos()
            Return False

        Else
            Return True
        End If
    End Function

    Public Function validarNumero(num As String) As Boolean
        Try
            Dim result = Convert.ToInt32(num)

            Return True
        Catch ex As Exception
            MsgBox("¡La cantidad no es válida!")
            limpiarCampos()
            Return False
        End Try

    End Function

    Private Sub FrmInsertarComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class