<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrar_Director
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
        Me.gpbMenuDocente = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCerrarSesionD = New System.Windows.Forms.Button()
        Me.lblMenuD = New System.Windows.Forms.Label()
        Me.gpbDatosPDocente = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDocente = New System.Windows.Forms.Label()
        Me.pictLogo = New System.Windows.Forms.PictureBox()
        Me.gpbMenuDocente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosPDocente.SuspendLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbMenuDocente
        '
        Me.gpbMenuDocente.BackColor = System.Drawing.Color.LightGray
        Me.gpbMenuDocente.Controls.Add(Me.Button2)
        Me.gpbMenuDocente.Controls.Add(Me.Button1)
        Me.gpbMenuDocente.Controls.Add(Me.Label2)
        Me.gpbMenuDocente.Controls.Add(Me.DataGridView1)
        Me.gpbMenuDocente.Controls.Add(Me.Label1)
        Me.gpbMenuDocente.Controls.Add(Me.TextBox1)
        Me.gpbMenuDocente.Controls.Add(Me.btnCerrarSesionD)
        Me.gpbMenuDocente.Controls.Add(Me.lblMenuD)
        Me.gpbMenuDocente.Location = New System.Drawing.Point(12, 121)
        Me.gpbMenuDocente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenuDocente.Name = "gpbMenuDocente"
        Me.gpbMenuDocente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenuDocente.Size = New System.Drawing.Size(918, 468)
        Me.gpbMenuDocente.TabIndex = 6
        Me.gpbMenuDocente.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Menu
        Me.Button2.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(726, 393)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 56)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Menu
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(388, 335)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 56)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(360, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Datos Personales"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(795, 110)
        Me.DataGridView1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingresa el nombre de la persona a eliminar."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(337, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 27)
        Me.TextBox1.TabIndex = 11
        '
        'btnCerrarSesionD
        '
        Me.btnCerrarSesionD.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCerrarSesionD.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesionD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarSesionD.Location = New System.Drawing.Point(611, 87)
        Me.btnCerrarSesionD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrarSesionD.Name = "btnCerrarSesionD"
        Me.btnCerrarSesionD.Size = New System.Drawing.Size(170, 35)
        Me.btnCerrarSesionD.TabIndex = 10
        Me.btnCerrarSesionD.Text = "Buscar"
        Me.btnCerrarSesionD.UseVisualStyleBackColor = False
        '
        'lblMenuD
        '
        Me.lblMenuD.AutoSize = True
        Me.lblMenuD.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenuD.Location = New System.Drawing.Point(409, 24)
        Me.lblMenuD.Name = "lblMenuD"
        Me.lblMenuD.Size = New System.Drawing.Size(87, 31)
        Me.lblMenuD.TabIndex = 6
        Me.lblMenuD.Text = "Buscar"
        '
        'gpbDatosPDocente
        '
        Me.gpbDatosPDocente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbDatosPDocente.Controls.Add(Me.lblNombre)
        Me.gpbDatosPDocente.Controls.Add(Me.lblDocente)
        Me.gpbDatosPDocente.Controls.Add(Me.pictLogo)
        Me.gpbDatosPDocente.Location = New System.Drawing.Point(12, 13)
        Me.gpbDatosPDocente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosPDocente.Name = "gpbDatosPDocente"
        Me.gpbDatosPDocente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosPDocente.Size = New System.Drawing.Size(918, 100)
        Me.gpbDatosPDocente.TabIndex = 5
        Me.gpbDatosPDocente.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(597, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(83, 25)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDocente
        '
        Me.lblDocente.AutoSize = True
        Me.lblDocente.Font = New System.Drawing.Font("Sylfaen", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDocente.Location = New System.Drawing.Point(337, 24)
        Me.lblDocente.Name = "lblDocente"
        Me.lblDocente.Size = New System.Drawing.Size(159, 48)
        Me.lblDocente.TabIndex = 7
        Me.lblDocente.Text = "Director"
        '
        'pictLogo
        '
        Me.pictLogo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.pictLogo.Location = New System.Drawing.Point(0, 9)
        Me.pictLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictLogo.Name = "pictLogo"
        Me.pictLogo.Size = New System.Drawing.Size(124, 77)
        Me.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictLogo.TabIndex = 1
        Me.pictLogo.TabStop = False
        '
        'Borrar_Director
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 603)
        Me.Controls.Add(Me.gpbMenuDocente)
        Me.Controls.Add(Me.gpbDatosPDocente)
        Me.Name = "Borrar_Director"
        Me.Text = "Baja de personal o alumnos"
        Me.gpbMenuDocente.ResumeLayout(False)
        Me.gpbMenuDocente.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosPDocente.ResumeLayout(False)
        Me.gpbDatosPDocente.PerformLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbMenuDocente As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnCerrarSesionD As Button
    Friend WithEvents lblMenuD As Label
    Friend WithEvents gpbDatosPDocente As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDocente As Label
    Friend WithEvents pictLogo As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
