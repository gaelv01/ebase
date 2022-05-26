Imports MySql.Data.MySqlClient

Public Class DUsuarios
    Inherits Conexion

    Private nombreUsuario As String
    Private claveUsuario As String

    Private cmd As MySqlCommand
    Private dr As MySqlDataReader

    Public Sub New(nombre As String, clave As String)
        nombreUsuario = nombre
        claveUsuario = clave
    End Sub

    Public Property Nombre_Usuario As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property Clave_Usuario As String
        Get
            Return claveUsuario
        End Get
        Set(ByVal value As String)
            claveUsuario = value
        End Set
    End Property

    Public Function consultarUsuario(du As DUsuarios) As Boolean
        Try
            conectar()
            cmd = New MySqlCommand("SELECT NOMBRE, CLAVE FROM usuarios WHERE NOMBRE ='" & du.Nombre_Usuario & "' AND CLAVE = '" & du.Clave_Usuario & "'")
            cmd.Connection = con
            dr = cmd.ExecuteReader()

            If dr.Read Then

                Return True

            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()
        End Try
    End Function






End Class
