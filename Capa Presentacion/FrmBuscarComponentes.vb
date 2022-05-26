Public Class FrmBuscarComponentes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim result = txtBuscar.Text
        If validarEspacioVacio(result) Then

            Try



                If rbtnBuscarID.Checked = True Then
                    Dim resultAsNumber = Convert.ToInt32(result)
                    Dim lc As New LComponentes
                    If lc.encontrarPorID(resultAsNumber).Rows.Count > 0 Then
                        Dim dt As DataTable = lc.encontrarPorID(resultAsNumber)
                        dgvResultados.DataSource = dt
                    Else
                        MsgBox("El ID especificado no existe. Verifique su digitación.")
                        txtBuscar.Clear()
                        dgvResultados.DataSource = Nothing
                    End If
                End If

                If rbtnBuscarDesc.Checked = True Then
                    Dim lc As New LComponentes
                    If lc.encontrarPorDesc(result).Rows.Count > 0 Then
                        Dim dt As DataTable = lc.encontrarPorDesc(result)
                        dgvResultados.DataSource = dt
                    Else
                        MsgBox("La descripción especificada no existe. Verifique su digitación.")
                        txtBuscar.Clear()
                        dgvResultados.DataSource = Nothing
                    End If

                End If

                If rbtnBuscarFecha.Checked = True Then
                    If validarLongitudFecha(result) Then
                        Dim dia = result.Substring(0, 2)
                        Dim mes = result.Substring(3, 2)
                        Dim anio = result.Substring(6, 4)
                        Dim resultAsDate = anio + mes + dia


                        Dim lc As New LComponentes
                        If lc.encontrarPorFecha(resultAsDate).Rows.Count > 0 Then
                            Dim dt As DataTable = lc.encontrarPorFecha(resultAsDate)
                            dgvResultados.DataSource = dt
                        Else
                            MsgBox("No se encuentra esa fecha relacionada con algún componente. Verifique su digitación.")
                            txtBuscar.Clear()
                            dgvResultados.DataSource = Nothing
                        End If

                    Else
                        MsgBox("El formato para introducir la fecha es incorrecto. Verifique su digitación.")
                    End If

                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("¡Rellene el campo correctamente!")
        End If

    End Sub


    Public Function validarEspacioVacio(str As String) As Boolean
        If str = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function validarLongitudFecha(fec As String) As Boolean
        If fec.Length = 10 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub FrmBuscarComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnBuscarID.Checked = True

    End Sub

    Private Sub rbtnBuscarID_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarID.CheckedChanged
        txtInstruccion.Text = ""
    End Sub

    Private Sub rbtnBuscarDesc_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarDesc.CheckedChanged
        txtInstruccion.Text = ""
    End Sub

    Private Sub rbtnBuscarFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarFecha.CheckedChanged
        txtInstruccion.Text = "Formato de fecha: DD/MM/AAAA"
    End Sub

    Private Sub txtID_LostFocus(sender As Object, e As EventArgs) Handles txtID.LostFocus
        Try


            If validarEspacioVacio(txtID.Text) Then

                Dim ID = Convert.ToInt32(txtID.Text)
                If ID <> 0 Then

                    Try
                        Dim lc As New LComponentes
                        Dim dt As DataTable = lc.encontrarPorID(ID)


                        If dt.Rows.Count > 0 Then


                            Dim dr As DataRow = dt.Rows.Item(0)

                            txtDesc.Text = dr.Item("DESCRIPCION")
                            txtCant.Text = dr.Item("CANTIDAD")
                            txtFec.Text = dr.Item("FECHA")
                            txtHor.Text = Convert.ToString(dr.Item("HORA"))




                        Else
                            MsgBox("El ID especificado no existe. Verifique su digitación.")
                            txtDesc.Clear()
                            txtCant.Clear()
                            txtFec.Clear()
                            txtHor.Clear()
                            txtID.Clear()
                        End If


                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Else
                    txtDesc.Clear()
                    txtCant.Clear()
                    txtFec.Clear()
                    txtHor.Clear()
                    txtID.Clear()
                End If
            Else
                txtDesc.Clear()
                txtCant.Clear()
                txtFec.Clear()
                txtHor.Clear()
                txtID.Clear()
            End If
        Catch ex As Exception
            MsgBox("¡Error! " & ex.Message & vbCrLf & "Verifique que sus datos estén correctamente colocados y tenga comunicación con la base de datos.")
            txtID.Clear()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtID.Text <> "" And txtHor.Text <> "" And txtFec.Text <> "" And txtDesc.Text <> "" And txtCant.Text <> "" Then
            Dim lc As New LComponentes
            Try
                Dim Id As Integer = Convert.ToInt32(txtID.Text)
                Dim Cant As Integer = Convert.ToInt32(txtCant.Text)
                Dim Desc = txtDesc.Text
                Dim Fec = txtFec.Text
                Dim Hor = Convert.ToString(txtHor.Text)



                If validarLongitudFecha(Fec) And validarHora(Hor) And validarTiempo(Hor) And validarEspacioVacio(Desc) And validarEspacioVacio(Fec) And validarEspacioVacio(txtID.Text) Then
                    Dim dia = Fec.Substring(0, 2)
                    Dim mes = Fec.Substring(3, 2)
                    Dim anio = Fec.Substring(6, 4)
                    Dim resultAsDate = anio + mes + dia
                    lc.actualizarComponente(Id, Cant, Desc, resultAsDate, Hor)
                    txtDesc.Clear()
                    txtCant.Clear()
                    txtFec.Clear()
                    txtHor.Clear()
                    txtID.Clear()

                Else
                    MsgBox("¡Rellene correctamente los campos!")
                    txtDesc.Clear()
                    txtCant.Clear()
                    txtFec.Clear()
                    txtHor.Clear()
                    txtID.Clear()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Por favor, rellene los campos proporcionados")
        End If

    End Sub

    Public Function validarHora(hor As String) As Boolean
        If hor.Length = 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarTiempo(hor As String) As Boolean
        Try
            Dim hora = hor.Substring(0, 2)
            Dim minuto = hor.Substring(3, 2)
            Dim segundo = hor.Substring(6, 2)

            Dim hour_int = Convert.ToInt32(hora)
            Dim min_int = Convert.ToInt32(minuto)
            Dim seg_int = Convert.ToInt32(segundo)

            If hour_int < 24 And min_int < 60 And seg_int < 60 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function


End Class