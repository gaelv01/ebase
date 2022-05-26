Public Class FrmBorrarComponentes
    Dim result As Boolean
    Dim Id As Integer
    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        result = buscarComponente()
    End Sub

    Public Function validarEspacioVacio(str As String) As Boolean
        If str = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function buscarComponente() As Boolean
        Try

            If validarEspacioVacio(txtID.Text) Then

                Dim id = Convert.ToInt32(txtID.Text)

                If id Then
                    Dim lc As New LComponentes
                    Dim dt = lc.encontrarPorID(id)

                    If dt.Rows.Count > 0 Then

                        Dim dr As DataRow = dt.Rows.Item(0)

                        lblDesc.Text = dr.Item("DESCRIPCION")
                        lblCant.Text = dr.Item("CANTIDAD")
                        lblFec.Text = dr.Item("FECHA")
                        lblHor.Text = Convert.ToString(dr.Item("HORA"))
                        Return True

                    Else
                        MsgBox("El ID especificado no existe. Verifique su digitación.")
                        txtID.Clear()
                        ' si no hay resultados de búsqueda
                        lblCant.Text = ""
                        lblDesc.Text = ""
                        lblFec.Text = ""
                        lblHor.Text = ""
                        Return False
                    End If

                Else
                    'si el id es una letra o un caracter
                    MsgBox("Introduzca un ID válido.")
                    txtID.Clear()
                    lblCant.Text = ""
                    lblDesc.Text = ""
                    lblFec.Text = ""
                    lblHor.Text = ""
                    Return False
                End If


            Else
                'si el espacio esta vacio
                MsgBox("Introduzca un ID.")
                txtID.Clear()
                lblCant.Text = ""
                lblDesc.Text = ""
                lblFec.Text = ""
                lblHor.Text = ""
                Return False
            End If

        Catch ex As Exception
            MsgBox("Introduzca un ID válido.")
            txtID.Clear()
            lblCant.Text = ""
            lblDesc.Text = ""
            lblFec.Text = ""
            lblHor.Text = ""
            Return False
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Try
            If result Then
                Dim identificador = Convert.ToInt32(txtID.Text)
                Dim lc As New LComponentes
                Dim resultado = MessageBox.Show("¿Seguro que deseas borrar este componente? Esta acción no se puede deshacer.", "¿Borrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resultado = DialogResult.Yes Then
                    lc.eliminarComponente(identificador)
                    txtID.Clear()
                    lblCant.Text = ""
                    lblDesc.Text = ""
                    lblFec.Text = ""
                    lblHor.Text = ""
                Else
                End If
            Else

            End If

        Catch ex As Exception
            MsgBox("El ID es incorrecto. Verifique su marcación.")
        End Try
    End Sub

    Private Sub FrmBorrarComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class