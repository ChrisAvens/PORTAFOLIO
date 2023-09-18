<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocente))
        Me.gpbDatosPDocente = New System.Windows.Forms.GroupBox()
        Me.lblDocente = New System.Windows.Forms.Label()
        Me.lblSemestre = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pictLogo = New System.Windows.Forms.PictureBox()
        Me.gpbMenuDocente = New System.Windows.Forms.GroupBox()
        Me.pictMunuAcciones = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesionD = New System.Windows.Forms.Button()
        Me.btnModiContraD = New System.Windows.Forms.Button()
        Me.btnSubirCali = New System.Windows.Forms.Button()
        Me.btnCambiarInfoD = New System.Windows.Forms.Button()
        Me.lblMenuD = New System.Windows.Forms.Label()
        Me.gpbDatosPDocente.SuspendLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbMenuDocente.SuspendLayout()
        CType(Me.pictMunuAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbDatosPDocente
        '
        Me.gpbDatosPDocente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbDatosPDocente.Controls.Add(Me.lblDocente)
        Me.gpbDatosPDocente.Controls.Add(Me.lblSemestre)
        Me.gpbDatosPDocente.Controls.Add(Me.lblGrupo)
        Me.gpbDatosPDocente.Controls.Add(Me.lblNombre)
        Me.gpbDatosPDocente.Controls.Add(Me.pictLogo)
        Me.gpbDatosPDocente.Location = New System.Drawing.Point(-1, 0)
        Me.gpbDatosPDocente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosPDocente.Name = "gpbDatosPDocente"
        Me.gpbDatosPDocente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosPDocente.Size = New System.Drawing.Size(918, 120)
        Me.gpbDatosPDocente.TabIndex = 1
        Me.gpbDatosPDocente.TabStop = False
        '
        'lblDocente
        '
        Me.lblDocente.AutoSize = True
        Me.lblDocente.Font = New System.Drawing.Font("Sylfaen", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDocente.Location = New System.Drawing.Point(248, 25)
        Me.lblDocente.Name = "lblDocente"
        Me.lblDocente.Size = New System.Drawing.Size(157, 48)
        Me.lblDocente.TabIndex = 6
        Me.lblDocente.Text = "Docente"
        '
        'lblSemestre
        '
        Me.lblSemestre.AutoSize = True
        Me.lblSemestre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSemestre.Location = New System.Drawing.Point(650, 25)
        Me.lblSemestre.Name = "lblSemestre"
        Me.lblSemestre.Size = New System.Drawing.Size(0, 25)
        Me.lblSemestre.TabIndex = 3
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrupo.Location = New System.Drawing.Point(405, 63)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(0, 25)
        Me.lblGrupo.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(578, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(83, 25)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'pictLogo
        '
        Me.pictLogo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.pictLogo.Location = New System.Drawing.Point(34, 16)
        Me.pictLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictLogo.Name = "pictLogo"
        Me.pictLogo.Size = New System.Drawing.Size(114, 81)
        Me.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictLogo.TabIndex = 0
        Me.pictLogo.TabStop = False
        '
        'gpbMenuDocente
        '
        Me.gpbMenuDocente.BackColor = System.Drawing.Color.LightGray
        Me.gpbMenuDocente.Controls.Add(Me.pictMunuAcciones)
        Me.gpbMenuDocente.Controls.Add(Me.btnCerrarSesionD)
        Me.gpbMenuDocente.Controls.Add(Me.btnModiContraD)
        Me.gpbMenuDocente.Controls.Add(Me.btnSubirCali)
        Me.gpbMenuDocente.Controls.Add(Me.btnCambiarInfoD)
        Me.gpbMenuDocente.Controls.Add(Me.lblMenuD)
        Me.gpbMenuDocente.Location = New System.Drawing.Point(-1, 128)
        Me.gpbMenuDocente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenuDocente.Name = "gpbMenuDocente"
        Me.gpbMenuDocente.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenuDocente.Size = New System.Drawing.Size(918, 473)
        Me.gpbMenuDocente.TabIndex = 2
        Me.gpbMenuDocente.TabStop = False
        '
        'pictMunuAcciones
        '
        Me.pictMunuAcciones.Image = CType(resources.GetObject("pictMunuAcciones.Image"), System.Drawing.Image)
        Me.pictMunuAcciones.Location = New System.Drawing.Point(94, 104)
        Me.pictMunuAcciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictMunuAcciones.Name = "pictMunuAcciones"
        Me.pictMunuAcciones.Size = New System.Drawing.Size(383, 312)
        Me.pictMunuAcciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictMunuAcciones.TabIndex = 11
        Me.pictMunuAcciones.TabStop = False
        '
        'btnCerrarSesionD
        '
        Me.btnCerrarSesionD.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCerrarSesionD.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesionD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarSesionD.Location = New System.Drawing.Point(523, 357)
        Me.btnCerrarSesionD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrarSesionD.Name = "btnCerrarSesionD"
        Me.btnCerrarSesionD.Size = New System.Drawing.Size(319, 72)
        Me.btnCerrarSesionD.TabIndex = 10
        Me.btnCerrarSesionD.Text = "Cerrar sesión"
        Me.btnCerrarSesionD.UseVisualStyleBackColor = False
        '
        'btnModiContraD
        '
        Me.btnModiContraD.BackColor = System.Drawing.SystemColors.Menu
        Me.btnModiContraD.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnModiContraD.Image = CType(resources.GetObject("btnModiContraD.Image"), System.Drawing.Image)
        Me.btnModiContraD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModiContraD.Location = New System.Drawing.Point(523, 277)
        Me.btnModiContraD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModiContraD.Name = "btnModiContraD"
        Me.btnModiContraD.Size = New System.Drawing.Size(319, 72)
        Me.btnModiContraD.TabIndex = 9
        Me.btnModiContraD.Text = "Modificar contraseña"
        Me.btnModiContraD.UseVisualStyleBackColor = False
        '
        'btnSubirCali
        '
        Me.btnSubirCali.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSubirCali.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubirCali.Image = CType(resources.GetObject("btnSubirCali.Image"), System.Drawing.Image)
        Me.btnSubirCali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubirCali.Location = New System.Drawing.Point(523, 197)
        Me.btnSubirCali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubirCali.Name = "btnSubirCali"
        Me.btnSubirCali.Size = New System.Drawing.Size(319, 72)
        Me.btnSubirCali.TabIndex = 8
        Me.btnSubirCali.Text = "Subir calificaciones "
        Me.btnSubirCali.UseVisualStyleBackColor = False
        '
        'btnCambiarInfoD
        '
        Me.btnCambiarInfoD.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCambiarInfoD.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCambiarInfoD.Image = CType(resources.GetObject("btnCambiarInfoD.Image"), System.Drawing.Image)
        Me.btnCambiarInfoD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarInfoD.Location = New System.Drawing.Point(523, 117)
        Me.btnCambiarInfoD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCambiarInfoD.Name = "btnCambiarInfoD"
        Me.btnCambiarInfoD.Size = New System.Drawing.Size(319, 72)
        Me.btnCambiarInfoD.TabIndex = 7
        Me.btnCambiarInfoD.Text = "Cambiar información personal"
        Me.btnCambiarInfoD.UseVisualStyleBackColor = False
        '
        'lblMenuD
        '
        Me.lblMenuD.AutoSize = True
        Me.lblMenuD.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenuD.Location = New System.Drawing.Point(371, 43)
        Me.lblMenuD.Name = "lblMenuD"
        Me.lblMenuD.Size = New System.Drawing.Size(216, 31)
        Me.lblMenuD.TabIndex = 6
        Me.lblMenuD.Text = "Menú de acciones "
        '
        'frmDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.gpbMenuDocente)
        Me.Controls.Add(Me.gpbDatosPDocente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDocente"
        Me.Text = "Docentes"
        Me.gpbDatosPDocente.ResumeLayout(False)
        Me.gpbDatosPDocente.PerformLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbMenuDocente.ResumeLayout(False)
        Me.gpbMenuDocente.PerformLayout()
        CType(Me.pictMunuAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbDatosPDocente As GroupBox
    Friend WithEvents lblSemestre As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents pictLogo As PictureBox
    Friend WithEvents gpbMenuDocente As GroupBox
    Friend WithEvents pictMunuAcciones As PictureBox
    Friend WithEvents btnCerrarSesionD As Button
    Friend WithEvents btnModiContraD As Button
    Friend WithEvents btnSubirCali As Button
    Friend WithEvents btnCambiarInfoD As Button
    Friend WithEvents lblMenuD As Label
    Friend WithEvents lblDocente As Label
End Class
