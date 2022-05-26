<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarComponentes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarComponentes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInstruccion = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnBuscarFecha = New System.Windows.Forms.RadioButton()
        Me.rbtnBuscarDesc = New System.Windows.Forms.RadioButton()
        Me.rbtnBuscarID = New System.Windows.Forms.RadioButton()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.gbxCambios = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtHor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbxCambios.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar componentes"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Gold
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatAppearance.BorderSize = 2
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.Location = New System.Drawing.Point(645, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(143, 86)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtInstruccion)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarFecha)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarDesc)
        Me.GroupBox1.Controls.Add(Me.rbtnBuscarID)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(13, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtInstruccion
        '
        Me.txtInstruccion.AutoSize = True
        Me.txtInstruccion.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInstruccion.Location = New System.Drawing.Point(272, 88)
        Me.txtInstruccion.Name = "txtInstruccion"
        Me.txtInstruccion.Size = New System.Drawing.Size(25, 20)
        Me.txtInstruccion.TabIndex = 6
        Me.txtInstruccion.Text = "    "
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBuscar.Location = New System.Drawing.Point(272, 49)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(178, 29)
        Me.txtBuscar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(272, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escriba aquí:"
        '
        'rbtnBuscarFecha
        '
        Me.rbtnBuscarFecha.AutoSize = True
        Me.rbtnBuscarFecha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarFecha.Location = New System.Drawing.Point(12, 67)
        Me.rbtnBuscarFecha.Name = "rbtnBuscarFecha"
        Me.rbtnBuscarFecha.Size = New System.Drawing.Size(202, 29)
        Me.rbtnBuscarFecha.TabIndex = 4
        Me.rbtnBuscarFecha.TabStop = True
        Me.rbtnBuscarFecha.Text = "Por fecha de adición"
        Me.rbtnBuscarFecha.UseVisualStyleBackColor = True
        '
        'rbtnBuscarDesc
        '
        Me.rbtnBuscarDesc.AutoSize = True
        Me.rbtnBuscarDesc.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarDesc.Location = New System.Drawing.Point(12, 42)
        Me.rbtnBuscarDesc.Name = "rbtnBuscarDesc"
        Me.rbtnBuscarDesc.Size = New System.Drawing.Size(160, 29)
        Me.rbtnBuscarDesc.TabIndex = 3
        Me.rbtnBuscarDesc.TabStop = True
        Me.rbtnBuscarDesc.Text = "Por descripción"
        Me.rbtnBuscarDesc.UseVisualStyleBackColor = True
        '
        'rbtnBuscarID
        '
        Me.rbtnBuscarID.AutoSize = True
        Me.rbtnBuscarID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnBuscarID.Location = New System.Drawing.Point(12, 17)
        Me.rbtnBuscarID.Name = "rbtnBuscarID"
        Me.rbtnBuscarID.Size = New System.Drawing.Size(81, 29)
        Me.rbtnBuscarID.TabIndex = 2
        Me.rbtnBuscarID.TabStop = True
        Me.rbtnBuscarID.Text = "Por ID"
        Me.rbtnBuscarID.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToOrderColumns = True
        Me.dgvResultados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.BackgroundColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResultados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResultados.Location = New System.Drawing.Point(13, 210)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowTemplate.Height = 25
        Me.dgvResultados.Size = New System.Drawing.Size(804, 158)
        Me.dgvResultados.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(243, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Editar un componente"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(198, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Coloque el ID del componente que desea modificar."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 489)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 182)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(29, 61)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(75, 29)
        Me.txtID.TabIndex = 0
        '
        'gbxCambios
        '
        Me.gbxCambios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gbxCambios.Controls.Add(Me.btnActualizar)
        Me.gbxCambios.Controls.Add(Me.txtHor)
        Me.gbxCambios.Controls.Add(Me.Label8)
        Me.gbxCambios.Controls.Add(Me.txtFec)
        Me.gbxCambios.Controls.Add(Me.Label7)
        Me.gbxCambios.Controls.Add(Me.txtCant)
        Me.gbxCambios.Controls.Add(Me.Label6)
        Me.gbxCambios.Controls.Add(Me.txtDesc)
        Me.gbxCambios.Controls.Add(Me.Label5)
        Me.gbxCambios.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxCambios.Location = New System.Drawing.Point(172, 489)
        Me.gbxCambios.Name = "gbxCambios"
        Me.gbxCambios.Size = New System.Drawing.Size(649, 182)
        Me.gbxCambios.TabIndex = 7
        Me.gbxCambios.TabStop = False
        Me.gbxCambios.Text = "Cambios del componente:"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Gold
        Me.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnActualizar.FlatAppearance.BorderSize = 2
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnActualizar.Location = New System.Drawing.Point(461, 59)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(156, 96)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'txtHor
        '
        Me.txtHor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHor.Location = New System.Drawing.Point(146, 134)
        Me.txtHor.Name = "txtHor"
        Me.txtHor.Size = New System.Drawing.Size(145, 29)
        Me.txtHor.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(7, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Hora:"
        '
        'txtFec
        '
        Me.txtFec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFec.Location = New System.Drawing.Point(146, 102)
        Me.txtFec.Name = "txtFec"
        Me.txtFec.Size = New System.Drawing.Size(145, 29)
        Me.txtFec.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(7, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Fecha:"
        '
        'txtCant
        '
        Me.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCant.Location = New System.Drawing.Point(146, 70)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(73, 29)
        Me.txtCant.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(7, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cantidad:"
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDesc.Location = New System.Drawing.Point(146, 38)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(218, 29)
        Me.txtDesc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripción:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(198, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(444, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Una vez colocado, seleccione el campo a modificar."
        '
        'FrmBuscarComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(838, 749)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbxCambios)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarComponentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar y buscar componentes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxCambios.ResumeLayout(False)
        Me.gbxCambios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnBuscarFecha As RadioButton
    Friend WithEvents rbtnBuscarDesc As RadioButton
    Friend WithEvents rbtnBuscarID As RadioButton
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents txtInstruccion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbxCambios As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
