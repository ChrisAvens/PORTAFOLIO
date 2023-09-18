<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContra))
        Me.gpbNomPortal = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pictLogo = New System.Windows.Forms.PictureBox()
        Me.gpbCambio_Contra = New System.Windows.Forms.GroupBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.gpbDatosCambio = New System.Windows.Forms.GroupBox()
        Me.pictContra = New System.Windows.Forms.PictureBox()
        Me.txtConfirmarContra = New System.Windows.Forms.TextBox()
        Me.txtNuevaContra = New System.Windows.Forms.TextBox()
        Me.txtContraActual = New System.Windows.Forms.TextBox()
        Me.lblConfirmarContra = New System.Windows.Forms.Label()
        Me.lblNuevaContra = New System.Windows.Forms.Label()
        Me.lblContraActual = New System.Windows.Forms.Label()
        Me.gpbNomPortal.SuspendLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbCambio_Contra.SuspendLayout()
        Me.gpbDatosCambio.SuspendLayout()
        CType(Me.pictContra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbNomPortal
        '
        Me.gpbNomPortal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbNomPortal.Controls.Add(Me.lblNombre)
        Me.gpbNomPortal.Controls.Add(Me.pictLogo)
        Me.gpbNomPortal.Location = New System.Drawing.Point(-1, 0)
        Me.gpbNomPortal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbNomPortal.Name = "gpbNomPortal"
        Me.gpbNomPortal.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbNomPortal.Size = New System.Drawing.Size(918, 120)
        Me.gpbNomPortal.TabIndex = 2
        Me.gpbNomPortal.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Sylfaen", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(379, 37)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(215, 44)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Portal BAEQ"
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
        'gpbCambio_Contra
        '
        Me.gpbCambio_Contra.BackColor = System.Drawing.Color.LightGray
        Me.gpbCambio_Contra.Controls.Add(Me.btnRegresar)
        Me.gpbCambio_Contra.Controls.Add(Me.gpbDatosCambio)
        Me.gpbCambio_Contra.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gpbCambio_Contra.Location = New System.Drawing.Point(-1, 128)
        Me.gpbCambio_Contra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCambio_Contra.Name = "gpbCambio_Contra"
        Me.gpbCambio_Contra.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCambio_Contra.Size = New System.Drawing.Size(918, 472)
        Me.gpbCambio_Contra.TabIndex = 3
        Me.gpbCambio_Contra.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.Menu
        Me.btnRegresar.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(402, 399)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(183, 57)
        Me.btnRegresar.TabIndex = 8
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'gpbDatosCambio
        '
        Me.gpbDatosCambio.Controls.Add(Me.pictContra)
        Me.gpbDatosCambio.Controls.Add(Me.txtConfirmarContra)
        Me.gpbDatosCambio.Controls.Add(Me.txtNuevaContra)
        Me.gpbDatosCambio.Controls.Add(Me.txtContraActual)
        Me.gpbDatosCambio.Controls.Add(Me.lblConfirmarContra)
        Me.gpbDatosCambio.Controls.Add(Me.lblNuevaContra)
        Me.gpbDatosCambio.Controls.Add(Me.lblContraActual)
        Me.gpbDatosCambio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gpbDatosCambio.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.gpbDatosCambio.Location = New System.Drawing.Point(34, 51)
        Me.gpbDatosCambio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosCambio.Name = "gpbDatosCambio"
        Me.gpbDatosCambio.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosCambio.Size = New System.Drawing.Size(839, 336)
        Me.gpbDatosCambio.TabIndex = 0
        Me.gpbDatosCambio.TabStop = False
        Me.gpbDatosCambio.Text = "Cambio de contraseña"
        '
        'pictContra
        '
        Me.pictContra.Image = Global.Prepa_Director.My.Resources.Resources.Cambiarcontra
        Me.pictContra.Location = New System.Drawing.Point(559, 37)
        Me.pictContra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictContra.Name = "pictContra"
        Me.pictContra.Size = New System.Drawing.Size(242, 279)
        Me.pictContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictContra.TabIndex = 6
        Me.pictContra.TabStop = False
        '
        'txtConfirmarContra
        '
        Me.txtConfirmarContra.Location = New System.Drawing.Point(271, 260)
        Me.txtConfirmarContra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConfirmarContra.Name = "txtConfirmarContra"
        Me.txtConfirmarContra.Size = New System.Drawing.Size(242, 34)
        Me.txtConfirmarContra.TabIndex = 5
        '
        'txtNuevaContra
        '
        Me.txtNuevaContra.Location = New System.Drawing.Point(271, 161)
        Me.txtNuevaContra.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNuevaContra.Name = "txtNuevaContra"
        Me.txtNuevaContra.Size = New System.Drawing.Size(242, 34)
        Me.txtNuevaContra.TabIndex = 4
        '
        'txtContraActual
        '
        Me.txtContraActual.Location = New System.Drawing.Point(271, 61)
        Me.txtContraActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContraActual.Name = "txtContraActual"
        Me.txtContraActual.Size = New System.Drawing.Size(242, 34)
        Me.txtContraActual.TabIndex = 3
        '
        'lblConfirmarContra
        '
        Me.lblConfirmarContra.AutoSize = True
        Me.lblConfirmarContra.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmarContra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConfirmarContra.Location = New System.Drawing.Point(45, 269)
        Me.lblConfirmarContra.Name = "lblConfirmarContra"
        Me.lblConfirmarContra.Size = New System.Drawing.Size(202, 26)
        Me.lblConfirmarContra.TabIndex = 2
        Me.lblConfirmarContra.Text = "Confirmar contraseña"
        '
        'lblNuevaContra
        '
        Me.lblNuevaContra.AutoSize = True
        Me.lblNuevaContra.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNuevaContra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNuevaContra.Location = New System.Drawing.Point(45, 171)
        Me.lblNuevaContra.Name = "lblNuevaContra"
        Me.lblNuevaContra.Size = New System.Drawing.Size(167, 26)
        Me.lblNuevaContra.TabIndex = 1
        Me.lblNuevaContra.Text = "Nueva contraseña"
        '
        'lblContraActual
        '
        Me.lblContraActual.AutoSize = True
        Me.lblContraActual.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContraActual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblContraActual.Location = New System.Drawing.Point(45, 71)
        Me.lblContraActual.Name = "lblContraActual"
        Me.lblContraActual.Size = New System.Drawing.Size(169, 26)
        Me.lblContraActual.TabIndex = 0
        Me.lblContraActual.Text = "Contraseña actual"
        '
        'frmCambiarContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.gpbCambio_Contra)
        Me.Controls.Add(Me.gpbNomPortal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCambiarContra"
        Me.Text = "Cambiar contraseña"
        Me.gpbNomPortal.ResumeLayout(False)
        Me.gpbNomPortal.PerformLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbCambio_Contra.ResumeLayout(False)
        Me.gpbDatosCambio.ResumeLayout(False)
        Me.gpbDatosCambio.PerformLayout()
        CType(Me.pictContra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbNomPortal As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents pictLogo As PictureBox
    Friend WithEvents gpbCambio_Contra As GroupBox
    Friend WithEvents gpbDatosCambio As GroupBox
    Friend WithEvents txtConfirmarContra As TextBox
    Friend WithEvents txtNuevaContra As TextBox
    Friend WithEvents txtContraActual As TextBox
    Friend WithEvents lblConfirmarContra As Label
    Friend WithEvents lblNuevaContra As Label
    Friend WithEvents lblContraActual As Label
    Friend WithEvents pictContra As PictureBox
    Friend WithEvents btnRegresar As Button
End Class
