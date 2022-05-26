Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub btnConectar_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            Dim lu As New LUsuarios()
            Dim usuario As String = txtUsuario.Text
            Dim clave As String = txtContrasena.Text

            If validarEspaciosVacios(usuario, clave) = True Then
                If lu.consultarUsuario(usuario, clave) = True Then

                    Me.Hide()
                    Index.Show()

                Else
                    MessageBox.Show("¡El nombre de usuario o la contraseña son incorrectos!")
                    vaciarEspacios()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function validarEspaciosVacios(nombre As String, clave As String) As Boolean
        If nombre = "" Or clave = "" Then
            MessageBox.Show("Por favor, rellene los campos.")
            Return False

        Else
            Return True
        End If
    End Function

    Public Sub vaciarEspacios()
        txtUsuario.Clear()
        txtContrasena.Clear()
    End Sub


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim retry As DialogResult
        Dim cn As New Conexion

        Do
            If cn.conectar() = False Then
                btnIniciarSesion.Enabled = False
                retry = MessageBox.Show("No se tiene conexión a la base de datos. Revise su conexión y vuelva a intentarlo.", "No hay conexión", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                If retry = DialogResult.Cancel Then
                    Me.Close()
                    Exit Do
                Else
                    'El resultado es retry
                End If
            Else
                ' La conexión si existe y funciona.
                btnIniciarSesion.Enabled = True
                Exit Do
            End If
        Loop While retry = DialogResult.Retry

    End Sub



    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
    End Sub

End Class