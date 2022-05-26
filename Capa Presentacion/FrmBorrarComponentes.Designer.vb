<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBorrarComponentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBorrarComponentes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblFec = New System.Windows.Forms.Label()
        Me.lblHor = New System.Windows.Forms.Label()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrar componentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(67, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Introduzca el ID del componente:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(67, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comprobar eliminación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(77, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(77, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(77, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(77, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 30)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hora:"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtID.Location = New System.Drawing.Point(77, 194)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 29)
        Me.txtID.TabIndex = 11
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.IndianRed
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBorrar.FlatAppearance.BorderSize = 2
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrar.Location = New System.Drawing.Point(86, 470)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(360, 49)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCant.ForeColor = System.Drawing.Color.IndianRed
        Me.lblCant.Location = New System.Drawing.Point(221, 303)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(55, 30)
        Me.lblCant.TabIndex = 13
        Me.lblCant.Text = "       "
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDesc.ForeColor = System.Drawing.Color.IndianRed
        Me.lblDesc.Location = New System.Drawing.Point(221, 334)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(55, 30)
        Me.lblDesc.TabIndex = 14
        Me.lblDesc.Text = "       "
        '
        'lblFec
        '
        Me.lblFec.AutoSize = True
        Me.lblFec.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFec.ForeColor = System.Drawing.Color.IndianRed
        Me.lblFec.Location = New System.Drawing.Point(221, 367)
        Me.lblFec.Name = "lblFec"
        Me.lblFec.Size = New System.Drawing.Size(55, 30)
        Me.lblFec.TabIndex = 15
        Me.lblFec.Text = "       "
        '
        'lblHor
        '
        Me.lblHor.AutoSize = True
        Me.lblHor.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHor.ForeColor = System.Drawing.Color.IndianRed
        Me.lblHor.Location = New System.Drawing.Point(221, 401)
        Me.lblHor.Name = "lblHor"
        Me.lblHor.Size = New System.Drawing.Size(55, 30)
        Me.lblHor.TabIndex = 16
        Me.lblHor.Text = "       "
        '
        'btnContinuar
        '
        Me.btnContinuar.BackColor = System.Drawing.Color.IndianRed
        Me.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnContinuar.FlatAppearance.BorderSize = 2
        Me.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnContinuar.Location = New System.Drawing.Point(287, 183)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(168, 44)
        Me.btnContinuar.TabIndex = 17
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.UseVisualStyleBackColor = False
        '
        'FrmBorrarComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 560)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.lblHor)
        Me.Controls.Add(Me.lblFec)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBorrarComponentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrar componentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblCant As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblFec As Label
    Friend WithEvents lblHor As Label
    Friend WithEvents btnContinuar As Button
End Class
