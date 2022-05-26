Public Class LUsuarios
    Public Function consultarUsuario(nombre As String, clave As String)
        Dim du As New DUsuarios(nombre, clave)

        If du.consultarUsuario(du) = True Then
            Return True
        Else
            Return False
        End If


    End Function
End Class
