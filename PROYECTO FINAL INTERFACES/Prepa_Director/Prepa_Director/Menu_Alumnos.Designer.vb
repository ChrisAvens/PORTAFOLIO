<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSesionEstudiante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSesionEstudiante))
        Me.gpbDatosP = New System.Windows.Forms.GroupBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblSemestre = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pictLogo = New System.Windows.Forms.PictureBox()
        Me.gpbMenu = New System.Windows.Forms.GroupBox()
        Me.pictMunuAcciones = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnModiContra = New System.Windows.Forms.Button()
        Me.btnConsultarCali = New System.Windows.Forms.Button()
        Me.btnCambiarInfo = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.gpbDatosP.SuspendLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbMenu.SuspendLayout()
        CType(Me.pictMunuAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbDatosP
        '
        Me.gpbDatosP.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbDatosP.Controls.Add(Me.lblNom)
        Me.gpbDatosP.Controls.Add(Me.lblSemestre)
        Me.gpbDatosP.Controls.Add(Me.lblGrupo)
        Me.gpbDatosP.Controls.Add(Me.lblNombre)
        Me.gpbDatosP.Controls.Add(Me.pictLogo)
        Me.gpbDatosP.Location = New System.Drawing.Point(-2, 0)
        Me.gpbDatosP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosP.Name = "gpbDatosP"
        Me.gpbDatosP.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosP.Size = New System.Drawing.Size(918, 120)
        Me.gpbDatosP.TabIndex = 0
        Me.gpbDatosP.TabStop = False
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Sylfaen", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNom.Location = New System.Drawing.Point(248, 25)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(167, 48)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "Alumnos"
        '
        'lblSemestre
        '
        Me.lblSemestre.AutoSize = True
        Me.lblSemestre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSemestre.Location = New System.Drawing.Point(744, 25)
        Me.lblSemestre.Name = "lblSemestre"
        Me.lblSemestre.Size = New System.Drawing.Size(89, 25)
        Me.lblSemestre.TabIndex = 3
        Me.lblSemestre.Text = "Semestre:"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrupo.Location = New System.Drawing.Point(520, 72)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(73, 25)
        Me.lblGrupo.TabIndex = 2
        Me.lblGrupo.Text = "Grupo: "
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(520, 25)
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
        'gpbMenu
        '
        Me.gpbMenu.BackColor = System.Drawing.Color.LightGray
        Me.gpbMenu.Controls.Add(Me.pictMunuAcciones)
        Me.gpbMenu.Controls.Add(Me.btnCerrarSesion)
        Me.gpbMenu.Controls.Add(Me.btnModiContra)
        Me.gpbMenu.Controls.Add(Me.btnConsultarCali)
        Me.gpbMenu.Controls.Add(Me.btnCambiarInfo)
        Me.gpbMenu.Controls.Add(Me.lblMenu)
        Me.gpbMenu.Location = New System.Drawing.Point(-2, 128)
        Me.gpbMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenu.Name = "gpbMenu"
        Me.gpbMenu.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbMenu.Size = New System.Drawing.Size(921, 477)
        Me.gpbMenu.TabIndex = 1
        Me.gpbMenu.TabStop = False
        '
        'pictMunuAcciones
        '
        Me.pictMunuAcciones.Location = New System.Drawing.Point(54, 113)
        Me.pictMunuAcciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictMunuAcciones.Name = "pictMunuAcciones"
        Me.pictMunuAcciones.Size = New System.Drawing.Size(383, 312)
        Me.pictMunuAcciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictMunuAcciones.TabIndex = 5
        Me.pictMunuAcciones.TabStop = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrarSesion.Location = New System.Drawing.Point(503, 353)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(319, 72)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnModiContra
        '
        Me.btnModiContra.BackColor = System.Drawing.SystemColors.Menu
        Me.btnModiContra.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnModiContra.Image = CType(resources.GetObject("btnModiContra.Image"), System.Drawing.Image)
        Me.btnModiContra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModiContra.Location = New System.Drawing.Point(503, 273)
        Me.btnModiContra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModiContra.Name = "btnModiContra"
        Me.btnModiContra.Size = New System.Drawing.Size(319, 72)
        Me.btnModiContra.TabIndex = 3
        Me.btnModiContra.Text = "Modificar contraseña"
        Me.btnModiContra.UseVisualStyleBackColor = False
        '
        'btnConsultarCali
        '
        Me.btnConsultarCali.BackColor = System.Drawing.SystemColors.Menu
        Me.btnConsultarCali.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConsultarCali.Image = CType(resources.GetObject("btnConsultarCali.Image"), System.Drawing.Image)
        Me.btnConsultarCali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarCali.Location = New System.Drawing.Point(503, 193)
        Me.btnConsultarCali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConsultarCali.Name = "btnConsultarCali"
        Me.btnConsultarCali.Size = New System.Drawing.Size(319, 72)
        Me.btnConsultarCali.TabIndex = 2
        Me.btnConsultarCali.Text = "Consultar calificaciones "
        Me.btnConsultarCali.UseVisualStyleBackColor = False
        '
        'btnCambiarInfo
        '
        Me.btnCambiarInfo.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCambiarInfo.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCambiarInfo.Image = CType(resources.GetObject("btnCambiarInfo.Image"), System.Drawing.Image)
        Me.btnCambiarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarInfo.Location = New System.Drawing.Point(503, 113)
        Me.btnCambiarInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCambiarInfo.Name = "btnCambiarInfo"
        Me.btnCambiarInfo.Size = New System.Drawing.Size(319, 72)
        Me.btnCambiarInfo.TabIndex = 1
        Me.btnCambiarInfo.Text = "Cambiar información personal"
        Me.btnCambiarInfo.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMenu.Location = New System.Drawing.Point(351, 39)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(216, 31)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menú de acciones "
        '
        'frmSesionEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.gpbMenu)
        Me.Controls.Add(Me.gpbDatosP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSesionEstudiante"
        Me.Text = "Estudiantes"
        Me.gpbDatosP.ResumeLayout(False)
        Me.gpbDatosP.PerformLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbMenu.ResumeLayout(False)
        Me.gpbMenu.PerformLayout()
        CType(Me.pictMunuAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbDatosP As GroupBox
    Friend WithEvents gpbMenu As GroupBox
    Friend WithEvents lblSemestre As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents pictLogo As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnModiContra As Button
    Friend WithEvents btnConsultarCali As Button
    Friend WithEvents btnCambiarInfo As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents pictMunuAcciones As PictureBox
    Friend WithEvents lblNom As Label
End Class
