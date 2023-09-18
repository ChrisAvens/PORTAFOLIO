<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegs))
        Me.CbxCargo = New System.Windows.Forms.ComboBox()
        Me.LblNameUsu = New System.Windows.Forms.Label()
        Me.GpbTop = New System.Windows.Forms.GroupBox()
        Me.PcrLogo = New System.Windows.Forms.PictureBox()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.GpbUsu = New System.Windows.Forms.GroupBox()
        Me.TxtCtr = New System.Windows.Forms.TextBox()
        Me.TxtNameUsu = New System.Windows.Forms.TextBox()
        Me.LblCtr = New System.Windows.Forms.Label()
        Me.GpbOtrs = New System.Windows.Forms.GroupBox()
        Me.BtnMateria = New System.Windows.Forms.Button()
        Me.TxtSem = New System.Windows.Forms.TextBox()
        Me.TxtGrup = New System.Windows.Forms.TextBox()
        Me.LblSem = New System.Windows.Forms.Label()
        Me.LblGrup = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.GpbDats = New System.Windows.Forms.GroupBox()
        Me.LblGenr = New System.Windows.Forms.Label()
        Me.CbxGenr = New System.Windows.Forms.ComboBox()
        Me.DateNac = New System.Windows.Forms.DateTimePicker()
        Me.LblNac = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtApe = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblApe = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GpbTop.SuspendLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbUsu.SuspendLayout()
        Me.GpbOtrs.SuspendLayout()
        Me.GpbDats.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbxCargo
        '
        Me.CbxCargo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxCargo.FormattingEnabled = True
        Me.CbxCargo.Items.AddRange(New Object() {"Alumno", "Docente", "Director"})
        Me.CbxCargo.Location = New System.Drawing.Point(147, 175)
        Me.CbxCargo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbxCargo.Name = "CbxCargo"
        Me.CbxCargo.Size = New System.Drawing.Size(260, 34)
        Me.CbxCargo.TabIndex = 0
        Me.CbxCargo.Text = "Seleccionar"
        '
        'LblNameUsu
        '
        Me.LblNameUsu.AutoSize = True
        Me.LblNameUsu.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNameUsu.Location = New System.Drawing.Point(17, 48)
        Me.LblNameUsu.Name = "LblNameUsu"
        Me.LblNameUsu.Size = New System.Drawing.Size(183, 26)
        Me.LblNameUsu.TabIndex = 1
        Me.LblNameUsu.Text = "Nombre de usuario:"
        '
        'GpbTop
        '
        Me.GpbTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GpbTop.Controls.Add(Me.PcrLogo)
        Me.GpbTop.Controls.Add(Me.LblTop)
        Me.GpbTop.Location = New System.Drawing.Point(2, 1)
        Me.GpbTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbTop.Name = "GpbTop"
        Me.GpbTop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbTop.Size = New System.Drawing.Size(993, 107)
        Me.GpbTop.TabIndex = 2
        Me.GpbTop.TabStop = False
        '
        'PcrLogo
        '
        Me.PcrLogo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.PcrLogo.Location = New System.Drawing.Point(22, 15)
        Me.PcrLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PcrLogo.Name = "PcrLogo"
        Me.PcrLogo.Size = New System.Drawing.Size(114, 81)
        Me.PcrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcrLogo.TabIndex = 12
        Me.PcrLogo.TabStop = False
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Sylfaen", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTop.Location = New System.Drawing.Point(371, 35)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(312, 44)
        Me.LblTop.TabIndex = 1
        Me.LblTop.Text = "Registro de usuario"
        '
        'GpbUsu
        '
        Me.GpbUsu.BackColor = System.Drawing.Color.LightGray
        Me.GpbUsu.Controls.Add(Me.TxtCtr)
        Me.GpbUsu.Controls.Add(Me.TxtNameUsu)
        Me.GpbUsu.Controls.Add(Me.LblCtr)
        Me.GpbUsu.Controls.Add(Me.LblNameUsu)
        Me.GpbUsu.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GpbUsu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GpbUsu.Location = New System.Drawing.Point(2, 112)
        Me.GpbUsu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbUsu.Name = "GpbUsu"
        Me.GpbUsu.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbUsu.Size = New System.Drawing.Size(537, 163)
        Me.GpbUsu.TabIndex = 3
        Me.GpbUsu.TabStop = False
        Me.GpbUsu.Text = "Elegir Nombre de usuario y contraseña"
        '
        'TxtCtr
        '
        Me.TxtCtr.AllowDrop = True
        Me.TxtCtr.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCtr.Location = New System.Drawing.Point(142, 97)
        Me.TxtCtr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCtr.Name = "TxtCtr"
        Me.TxtCtr.Size = New System.Drawing.Size(266, 34)
        Me.TxtCtr.TabIndex = 4
        '
        'TxtNameUsu
        '
        Me.TxtNameUsu.AllowDrop = True
        Me.TxtNameUsu.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNameUsu.Location = New System.Drawing.Point(214, 48)
        Me.TxtNameUsu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNameUsu.Name = "TxtNameUsu"
        Me.TxtNameUsu.Size = New System.Drawing.Size(194, 34)
        Me.TxtNameUsu.TabIndex = 3
        '
        'LblCtr
        '
        Me.LblCtr.AutoSize = True
        Me.LblCtr.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCtr.Location = New System.Drawing.Point(17, 97)
        Me.LblCtr.Name = "LblCtr"
        Me.LblCtr.Size = New System.Drawing.Size(115, 26)
        Me.LblCtr.TabIndex = 2
        Me.LblCtr.Text = "Contraseña:"
        '
        'GpbOtrs
        '
        Me.GpbOtrs.BackColor = System.Drawing.Color.LightGray
        Me.GpbOtrs.Controls.Add(Me.BtnMateria)
        Me.GpbOtrs.Controls.Add(Me.TxtSem)
        Me.GpbOtrs.Controls.Add(Me.TxtGrup)
        Me.GpbOtrs.Controls.Add(Me.LblSem)
        Me.GpbOtrs.Controls.Add(Me.LblGrup)
        Me.GpbOtrs.Controls.Add(Me.BtnCancel)
        Me.GpbOtrs.Controls.Add(Me.BtnReg)
        Me.GpbOtrs.Controls.Add(Me.LblCargo)
        Me.GpbOtrs.Controls.Add(Me.CbxCargo)
        Me.GpbOtrs.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GpbOtrs.Location = New System.Drawing.Point(546, 112)
        Me.GpbOtrs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbOtrs.Name = "GpbOtrs"
        Me.GpbOtrs.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbOtrs.Size = New System.Drawing.Size(449, 491)
        Me.GpbOtrs.TabIndex = 4
        Me.GpbOtrs.TabStop = False
        Me.GpbOtrs.Text = " "
        '
        'BtnMateria
        '
        Me.BtnMateria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMateria.Location = New System.Drawing.Point(134, 216)
        Me.BtnMateria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnMateria.Name = "BtnMateria"
        Me.BtnMateria.Size = New System.Drawing.Size(201, 51)
        Me.BtnMateria.TabIndex = 11
        Me.BtnMateria.Text = "Agregar materias"
        Me.BtnMateria.UseVisualStyleBackColor = True
        Me.BtnMateria.Visible = False
        '
        'TxtSem
        '
        Me.TxtSem.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtSem.Location = New System.Drawing.Point(157, 257)
        Me.TxtSem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSem.Name = "TxtSem"
        Me.TxtSem.Size = New System.Drawing.Size(103, 34)
        Me.TxtSem.TabIndex = 10
        Me.TxtSem.Visible = False
        '
        'TxtGrup
        '
        Me.TxtGrup.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtGrup.Location = New System.Drawing.Point(157, 175)
        Me.TxtGrup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGrup.Name = "TxtGrup"
        Me.TxtGrup.Size = New System.Drawing.Size(103, 34)
        Me.TxtGrup.TabIndex = 5
        Me.TxtGrup.Visible = False
        '
        'LblSem
        '
        Me.LblSem.AutoSize = True
        Me.LblSem.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblSem.Location = New System.Drawing.Point(42, 261)
        Me.LblSem.Name = "LblSem"
        Me.LblSem.Size = New System.Drawing.Size(94, 26)
        Me.LblSem.TabIndex = 9
        Me.LblSem.Text = "Semestre:"
        Me.LblSem.Visible = False
        '
        'LblGrup
        '
        Me.LblGrup.AutoSize = True
        Me.LblGrup.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblGrup.Location = New System.Drawing.Point(42, 179)
        Me.LblGrup.Name = "LblGrup"
        Me.LblGrup.Size = New System.Drawing.Size(72, 26)
        Me.LblGrup.TabIndex = 8
        Me.LblGrup.Text = "Grupo:"
        Me.LblGrup.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancel.Location = New System.Drawing.Point(303, 294)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(104, 52)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnReg
        '
        Me.BtnReg.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnReg.Location = New System.Drawing.Point(42, 294)
        Me.BtnReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(218, 52)
        Me.BtnReg.TabIndex = 6
        Me.BtnReg.Text = "Crear mi cuenta nueva"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCargo.Location = New System.Drawing.Point(42, 179)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(68, 26)
        Me.LblCargo.TabIndex = 5
        Me.LblCargo.Text = "Cargo:"
        '
        'GpbDats
        '
        Me.GpbDats.BackColor = System.Drawing.Color.LightGray
        Me.GpbDats.Controls.Add(Me.LblGenr)
        Me.GpbDats.Controls.Add(Me.CbxGenr)
        Me.GpbDats.Controls.Add(Me.DateNac)
        Me.GpbDats.Controls.Add(Me.LblNac)
        Me.GpbDats.Controls.Add(Me.TxtMail)
        Me.GpbDats.Controls.Add(Me.LblEmail)
        Me.GpbDats.Controls.Add(Me.TxtApe)
        Me.GpbDats.Controls.Add(Me.TxtNombre)
        Me.GpbDats.Controls.Add(Me.LblApe)
        Me.GpbDats.Controls.Add(Me.LblNombre)
        Me.GpbDats.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GpbDats.Location = New System.Drawing.Point(2, 283)
        Me.GpbDats.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbDats.Name = "GpbDats"
        Me.GpbDats.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbDats.Size = New System.Drawing.Size(537, 320)
        Me.GpbDats.TabIndex = 5
        Me.GpbDats.TabStop = False
        Me.GpbDats.Text = "Datos de usuario"
        '
        'LblGenr
        '
        Me.LblGenr.AutoSize = True
        Me.LblGenr.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblGenr.Location = New System.Drawing.Point(22, 243)
        Me.LblGenr.Name = "LblGenr"
        Me.LblGenr.Size = New System.Drawing.Size(79, 26)
        Me.LblGenr.TabIndex = 13
        Me.LblGenr.Text = "Genero:"
        '
        'CbxGenr
        '
        Me.CbxGenr.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxGenr.FormattingEnabled = True
        Me.CbxGenr.Items.AddRange(New Object() {"Hombre", "Mujer", "Otros"})
        Me.CbxGenr.Location = New System.Drawing.Point(206, 239)
        Me.CbxGenr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbxGenr.Name = "CbxGenr"
        Me.CbxGenr.Size = New System.Drawing.Size(277, 34)
        Me.CbxGenr.TabIndex = 12
        Me.CbxGenr.Text = "Seleccionar"
        '
        'DateNac
        '
        Me.DateNac.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateNac.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNac.Location = New System.Drawing.Point(206, 192)
        Me.DateNac.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateNac.MaxDate = New Date(2023, 5, 27, 0, 0, 0, 0)
        Me.DateNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateNac.Name = "DateNac"
        Me.DateNac.Size = New System.Drawing.Size(277, 34)
        Me.DateNac.TabIndex = 11
        Me.DateNac.Value = New Date(2023, 5, 25, 0, 0, 0, 0)
        '
        'LblNac
        '
        Me.LblNac.AutoSize = True
        Me.LblNac.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNac.Location = New System.Drawing.Point(22, 192)
        Me.LblNac.Name = "LblNac"
        Me.LblNac.Size = New System.Drawing.Size(197, 26)
        Me.LblNac.TabIndex = 10
        Me.LblNac.Text = "Fecha de nacimiento:"
        '
        'TxtMail
        '
        Me.TxtMail.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMail.Location = New System.Drawing.Point(206, 145)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(277, 34)
        Me.TxtMail.TabIndex = 9
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblEmail.Location = New System.Drawing.Point(22, 149)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(182, 26)
        Me.LblEmail.TabIndex = 8
        Me.LblEmail.Text = "Dirección de Email:"
        '
        'TxtApe
        '
        Me.TxtApe.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtApe.Location = New System.Drawing.Point(134, 99)
        Me.TxtApe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApe.Name = "TxtApe"
        Me.TxtApe.Size = New System.Drawing.Size(349, 34)
        Me.TxtApe.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNombre.Location = New System.Drawing.Point(134, 51)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(349, 34)
        Me.TxtNombre.TabIndex = 5
        '
        'LblApe
        '
        Me.LblApe.AutoSize = True
        Me.LblApe.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblApe.Location = New System.Drawing.Point(22, 103)
        Me.LblApe.Name = "LblApe"
        Me.LblApe.Size = New System.Drawing.Size(97, 26)
        Me.LblApe.TabIndex = 6
        Me.LblApe.Text = "Apellidos:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNombre.Location = New System.Drawing.Point(22, 55)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(114, 26)
        Me.LblNombre.TabIndex = 5
        Me.LblNombre.Text = "Nombre (s):"
        '
        'FrmRegs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 601)
        Me.Controls.Add(Me.GpbDats)
        Me.Controls.Add(Me.GpbOtrs)
        Me.Controls.Add(Me.GpbUsu)
        Me.Controls.Add(Me.GpbTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmRegs"
        Me.Text = "Registro de usuario"
        Me.GpbTop.ResumeLayout(False)
        Me.GpbTop.PerformLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbUsu.ResumeLayout(False)
        Me.GpbUsu.PerformLayout()
        Me.GpbOtrs.ResumeLayout(False)
        Me.GpbOtrs.PerformLayout()
        Me.GpbDats.ResumeLayout(False)
        Me.GpbDats.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CbxCargo As ComboBox
    Friend WithEvents LblNameUsu As Label
    Friend WithEvents GpbTop As GroupBox
    Friend WithEvents LblTop As Label
    Friend WithEvents GpbUsu As GroupBox
    Friend WithEvents GpbOtrs As GroupBox
    Friend WithEvents GpbDats As GroupBox
    Friend WithEvents LblCtr As Label
    Friend WithEvents TxtCtr As TextBox
    Friend WithEvents TxtNameUsu As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApe As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TxtApe As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateNac As DateTimePicker
    Friend WithEvents LblNac As Label
    Friend WithEvents LblGenr As Label
    Friend WithEvents CbxGenr As ComboBox
    Friend WithEvents LblCargo As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnReg As Button
    Friend WithEvents LblGrup As Label
    Friend WithEvents TxtGrup As TextBox
    Friend WithEvents LblSem As Label
    Friend WithEvents TxtSem As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents BtnMateria As Button
    Friend WithEvents PcrLogo As PictureBox
End Class
