<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaterias))
        Me.GpbMaterias = New System.Windows.Forms.GroupBox()
        Me.PcrLogo = New System.Windows.Forms.PictureBox()
        Me.LblTop = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAcc = New System.Windows.Forms.Button()
        Me.GpbMaterias.SuspendLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GpbMaterias
        '
        Me.GpbMaterias.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GpbMaterias.Controls.Add(Me.PcrLogo)
        Me.GpbMaterias.Controls.Add(Me.LblTop)
        Me.GpbMaterias.Location = New System.Drawing.Point(0, 0)
        Me.GpbMaterias.Margin = New System.Windows.Forms.Padding(4)
        Me.GpbMaterias.Name = "GpbMaterias"
        Me.GpbMaterias.Padding = New System.Windows.Forms.Padding(4)
        Me.GpbMaterias.Size = New System.Drawing.Size(671, 80)
        Me.GpbMaterias.TabIndex = 0
        Me.GpbMaterias.TabStop = False
        '
        'PcrLogo
        '
        Me.PcrLogo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.PcrLogo.Location = New System.Drawing.Point(12, 13)
        Me.PcrLogo.Name = "PcrLogo"
        Me.PcrLogo.Size = New System.Drawing.Size(100, 61)
        Me.PcrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcrLogo.TabIndex = 13
        Me.PcrLogo.TabStop = False
        '
        'LblTop
        '
        Me.LblTop.AutoSize = True
        Me.LblTop.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTop.Location = New System.Drawing.Point(218, 13)
        Me.LblTop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(255, 35)
        Me.LblTop.TabIndex = 2
        Me.LblTop.Text = "Selección de materias"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.LightGray
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Matamáticas I", "Lectura y redacción I", "Química I", "Inglés I", "Historia I", "Lógica I", "Orientación educativa", "Informática I"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(25, 49)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(190, 174)
        Me.CheckedListBox1.TabIndex = 1
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.LightGray
        Me.CheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Biología", "Matemáticas III", "Filosofía I", "Inglés III", "História III", "Laboratorio de química", "Etimolgs.  greclat. del esp"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(218, 51)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(208, 145)
        Me.CheckedListBox2.TabIndex = 2
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.BackColor = System.Drawing.Color.LightGray
        Me.CheckedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"Matemáticas V", "Inglés V", "Derecho", "Psicología", "Laboratorio de Biología", "Arte y estética", "Física II"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(438, 51)
        Me.CheckedListBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(208, 145)
        Me.CheckedListBox3.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.BtnAcc)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox3)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(671, 281)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnAcc
        '
        Me.BtnAcc.Location = New System.Drawing.Point(234, 236)
        Me.BtnAcc.Name = "BtnAcc"
        Me.BtnAcc.Size = New System.Drawing.Size(171, 30)
        Me.BtnAcc.TabIndex = 4
        Me.BtnAcc.Text = "Guarda materias"
        Me.BtnAcc.UseVisualStyleBackColor = True
        '
        'FrmMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpbMaterias)
        Me.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMaterias"
        Me.Text = "Selección de materias"
        Me.GpbMaterias.ResumeLayout(False)
        Me.GpbMaterias.PerformLayout()
        CType(Me.PcrLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GpbMaterias As GroupBox
    Friend WithEvents LblTop As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAcc As Button
    Friend WithEvents PcrLogo As PictureBox
End Class
