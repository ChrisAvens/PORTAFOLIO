<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIniSec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIniSec))
        Me.GpbTop = New System.Windows.Forms.GroupBox()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.GpbCont = New System.Windows.Forms.GroupBox()
        Me.LnLblCtr = New System.Windows.Forms.LinkLabel()
        Me.PcrLogo = New System.Windows.Forms.PictureBox()
        Me.BtnIniSec = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.TxtCtr = New System.Windows.Forms.TextBox()
        Me.TxtUsu = New System.Windows.Forms.TextBox()
        Me.LblNewAcc = New System.Windows.Forms.Label()
        Me.LblCtr = New System.Windows.Forms.Label()
        Me.LblUsu = New System.Windows.Forms.Label()
        Me.LblTop2 = New System.Windows.Forms.Label()
        Me.GpbTop.SuspendLayout()
        Me.GpbCont.SuspendLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpbTop
        '
        Me.GpbTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GpbTop.Controls.Add(Me.LblTop)
        Me.GpbTop.Location = New System.Drawing.Point(-6, -1)
        Me.GpbTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbTop.Name = "GpbTop"
        Me.GpbTop.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbTop.Size = New System.Drawing.Size(920, 125)
        Me.GpbTop.TabIndex = 0
        Me.GpbTop.TabStop = False
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Sylfaen", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTop.Location = New System.Drawing.Point(362, 25)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(215, 44)
        Me.LblTop.TabIndex = 0
        Me.LblTop.Text = "Portal BAEQ"
        '
        'GpbCont
        '
        Me.GpbCont.BackColor = System.Drawing.Color.LightGray
        Me.GpbCont.Controls.Add(Me.LnLblCtr)
        Me.GpbCont.Controls.Add(Me.PcrLogo)
        Me.GpbCont.Controls.Add(Me.BtnIniSec)
        Me.GpbCont.Controls.Add(Me.BtnReg)
        Me.GpbCont.Controls.Add(Me.TxtCtr)
        Me.GpbCont.Controls.Add(Me.TxtUsu)
        Me.GpbCont.Controls.Add(Me.LblNewAcc)
        Me.GpbCont.Controls.Add(Me.LblCtr)
        Me.GpbCont.Controls.Add(Me.LblUsu)
        Me.GpbCont.Controls.Add(Me.LblTop2)
        Me.GpbCont.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GpbCont.Location = New System.Drawing.Point(-6, 117)
        Me.GpbCont.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbCont.Name = "GpbCont"
        Me.GpbCont.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GpbCont.Size = New System.Drawing.Size(920, 467)
        Me.GpbCont.TabIndex = 1
        Me.GpbCont.TabStop = False
        '
        'LnLblCtr
        '
        Me.LnLblCtr.AutoSize = True
        Me.LnLblCtr.Font = New System.Drawing.Font("Sylfaen", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LnLblCtr.Location = New System.Drawing.Point(554, 265)
        Me.LnLblCtr.Name = "LnLblCtr"
        Me.LnLblCtr.Size = New System.Drawing.Size(184, 25)
        Me.LnLblCtr.TabIndex = 9
        Me.LnLblCtr.TabStop = True
        Me.LnLblCtr.Text = "Olvidé mi contraseña"
        '
        'PcrLogo
        '
        Me.PcrLogo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.PcrLogo.Location = New System.Drawing.Point(48, 67)
        Me.PcrLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PcrLogo.Name = "PcrLogo"
        Me.PcrLogo.Size = New System.Drawing.Size(315, 357)
        Me.PcrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcrLogo.TabIndex = 8
        Me.PcrLogo.TabStop = False
        '
        'BtnIniSec
        '
        Me.BtnIniSec.Location = New System.Drawing.Point(435, 207)
        Me.BtnIniSec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnIniSec.Name = "BtnIniSec"
        Me.BtnIniSec.Size = New System.Drawing.Size(393, 48)
        Me.BtnIniSec.TabIndex = 7
        Me.BtnIniSec.Text = "Iniciar sesión"
        Me.BtnIniSec.UseVisualStyleBackColor = True
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(557, 376)
        Me.BtnReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(154, 48)
        Me.BtnReg.TabIndex = 6
        Me.BtnReg.Text = "Registrate"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'TxtCtr
        '
        Me.TxtCtr.Location = New System.Drawing.Point(570, 144)
        Me.TxtCtr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCtr.Name = "TxtCtr"
        Me.TxtCtr.Size = New System.Drawing.Size(258, 39)
        Me.TxtCtr.TabIndex = 5
        '
        'TxtUsu
        '
        Me.TxtUsu.Location = New System.Drawing.Point(535, 84)
        Me.TxtUsu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtUsu.Name = "TxtUsu"
        Me.TxtUsu.Size = New System.Drawing.Size(293, 39)
        Me.TxtUsu.TabIndex = 4
        '
        'LblNewAcc
        '
        Me.LblNewAcc.AutoSize = True
        Me.LblNewAcc.Location = New System.Drawing.Point(520, 324)
        Me.LblNewAcc.Name = "LblNewAcc"
        Me.LblNewAcc.Size = New System.Drawing.Size(241, 31)
        Me.LblNewAcc.TabIndex = 3
        Me.LblNewAcc.Text = "¿No tienes una cuenta?"
        '
        'LblCtr
        '
        Me.LblCtr.AutoSize = True
        Me.LblCtr.Location = New System.Drawing.Point(435, 149)
        Me.LblCtr.Name = "LblCtr"
        Me.LblCtr.Size = New System.Drawing.Size(133, 31)
        Me.LblCtr.TabIndex = 2
        Me.LblCtr.Text = "Contraseña:"
        '
        'LblUsu
        '
        Me.LblUsu.AutoSize = True
        Me.LblUsu.Location = New System.Drawing.Point(435, 88)
        Me.LblUsu.Name = "LblUsu"
        Me.LblUsu.Size = New System.Drawing.Size(97, 31)
        Me.LblUsu.TabIndex = 1
        Me.LblUsu.Text = "Usuario:"
        '
        'LblTop2
        '
        Me.LblTop2.AutoSize = True
        Me.LblTop2.Font = New System.Drawing.Font("Sylfaen", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTop2.Location = New System.Drawing.Point(362, 11)
        Me.LblTop2.Name = "LblTop2"
        Me.LblTop2.Size = New System.Drawing.Size(219, 28)
        Me.LblTop2.TabIndex = 0
        Me.LblTop2.Text = "Acceso a la plataforma"
        '
        'FrmIniSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 580)
        Me.Controls.Add(Me.GpbCont)
        Me.Controls.Add(Me.GpbTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmIniSec"
        Me.Text = "Portal BAEQ"
        Me.GpbTop.ResumeLayout(False)
        Me.GpbTop.PerformLayout()
        Me.GpbCont.ResumeLayout(False)
        Me.GpbCont.PerformLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GpbTop As GroupBox
    Friend WithEvents GpbCont As GroupBox
    Friend WithEvents LblTop As Label
    Friend WithEvents LblCtr As Label
    Friend WithEvents LblUsu As Label
    Friend WithEvents LblTop2 As Label
    Friend WithEvents BtnIniSec As Button
    Friend WithEvents BtnReg As Button
    Friend WithEvents TxtCtr As TextBox
    Friend WithEvents TxtUsu As TextBox
    Friend WithEvents LblNewAcc As Label
    Friend WithEvents PcrLogo As PictureBox
    Friend WithEvents LnLblCtr As LinkLabel
End Class
