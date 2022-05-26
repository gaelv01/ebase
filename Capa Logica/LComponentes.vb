Public Class LComponentes

    Public Function insertarComponente(cant As Integer, desc As String, fec As String, hor As String)
        Dim dc As New DComponentes(cant, desc, fec, hor)

        If dc.insertarComponente(dc) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function consultarComponentes() As DataTable

        Try
            Dim dc As New DComponentes
            Dim dt As DataTable = dc.consultarComponentes()

            Return dt


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function encontrarPorID(ID As Integer) As DataTable
        Try
            Dim dc As New DComponentes(ID)
            Dim dt As DataTable = dc.encontrarPorID(dc)
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function encontrarPorDesc(desc As String) As DataTable
        Try
            Dim dc As New DComponentes(desc)
            Dim dt As DataTable = dc.encontrarPorDesc(dc)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function encontrarPorFecha(fec As String)
        Try
            Dim dc As New DComponentes(fec)
            Dim dt As DataTable = dc.encotrarPorFecha(dc)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function actualizarComponente(id As Integer, cant As Integer, desc As String, fec As String, hor As String)
        Try
            Dim dc As New DComponentes(id, cant, desc, fec, hor)
            dc.actualizarComponente(dc)
            Return True


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function eliminarComponente(ID As Integer) As Boolean
        Try
            Dim dc As New DComponentes
            dc.eliminarComponente(ID)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
