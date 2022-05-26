Imports MySql.Data.MySqlClient
Public Class DComponentes
    Inherits Conexion

    Private idComponente As Integer
    Private cantidadComponente As Integer
    Private descripcionComponente As String
    Private fechaComponente As String
    Private horaComponente As String



    Private cmd As MySqlCommand


    Public Sub New(cant As Integer, desc As String, fec As String, hor As String)

        cantidadComponente = cant
        descripcionComponente = desc
        fechaComponente = fec
        horaComponente = hor

    End Sub

    Public Sub New(id As Integer, cant As Integer, desc As String, fec As String, hor As String)

        idComponente = id
        cantidadComponente = cant
        descripcionComponente = desc
        fechaComponente = fec
        horaComponente = hor

    End Sub

    Public Sub New()
    End Sub

    Public Sub New(id As Integer)
        idComponente = id
    End Sub

    Public Sub New(desc As String)
        descripcionComponente = desc
        fechaComponente = desc

    End Sub



    Public Property Id_Componente As Integer
        Get
            Return idComponente
        End Get
        Set(value As Integer)
            idComponente = value
        End Set
    End Property
    Public Property Cantidad_Componente As Integer
        Get
            Return cantidadComponente
        End Get
        Set(value As Integer)
            cantidadComponente = value
        End Set
    End Property
    Public Property Descript_Componente As String
        Get
            Return descripcionComponente
        End Get
        Set(value As String)
            descripcionComponente = value
        End Set
    End Property

    Public Property Fecha_Componente As String
        Get
            Return fechaComponente
        End Get
        Set(value As String)
            fechaComponente = value
        End Set
    End Property

    Public Property Hora_Componente As String
        Get
            Return horaComponente
        End Get
        Set(value As String)
            horaComponente = value
        End Set
    End Property


    Public Function insertarComponente(dc As DComponentes) As Boolean

        Try
            conectar()

            Dim sql As String = "INSERT INTO componentes(CANTIDAD,DESCRIPCION,FECHA,HORA) VALUES
                                ('" & dc.Cantidad_Componente & "','" & dc.Descript_Componente & "','" & dc.Fecha_Componente & "','" & dc.Hora_Componente & "')"


            cmd = New MySqlCommand(sql, con)

            If cmd.ExecuteNonQuery() Then
                MsgBox("Componente ingresado exitosamente")
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


    Public Function consultarComponentes() As DataTable

        Try
            conectar()
            cmd = New MySqlCommand("SELECT * FROM componentes")
            cmd.Connection = con

            If cmd.ExecuteNonQuery() Then

                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Function


    Public Function encontrarPorID(dc As DComponentes) As DataTable
        Try
            conectar()
            cmd = New MySqlCommand("SELECT * FROM componentes WHERE ID=" & dc.idComponente)
            cmd.Connection = con

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function


    Public Function encontrarPorDesc(dc As DComponentes) As DataTable
        Try
            conectar()
            cmd = New MySqlCommand("SELECT * FROM componentes WHERE DESCRIPCION='" & dc.descripcionComponente & "'")
            cmd.Connection = con

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            con.Close()
        End Try

    End Function

    Public Function encotrarPorFecha(dc As DComponentes) As DataTable
        Try
            conectar()
            cmd = New MySqlCommand("SELECT * FROM componentes WHERE FECHA='" & dc.fechaComponente & "'")
            cmd.Connection = con

            If cmd.ExecuteNonQuery() Then
                Dim dt As New DataTable
                Dim adp As New MySqlDataAdapter(cmd)
                adp.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function actualizarComponente(dc As DComponentes) As Boolean
        Try
            conectar()
            cmd = New MySqlCommand("UPDATE componentes SET ID = " & dc.idComponente & ", CANTIDAD = " & dc.cantidadComponente & ", DESCRIPCION = '" & dc.descripcionComponente & "', FECHA = '" & dc.fechaComponente & "', HORA = '" & dc.horaComponente & "' WHERE ID = " & dc.idComponente)
            cmd.Connection = con
            If cmd.ExecuteNonQuery Then

                MsgBox("¡Datos actualizados correctamente!")
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

    Public Function eliminarComponente(ID As Integer) As Boolean
        Try
            conectar()
            cmd = New MySqlCommand("DELETE FROM componentes WHERE ID = " & ID)
            cmd.Connection = con
            If cmd.ExecuteNonQuery Then
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
