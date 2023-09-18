<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCali))
        Me.gpbCalificaciones = New System.Windows.Forms.GroupBox()
        Me.gpbDatosP = New System.Windows.Forms.GroupBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblSemestre = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.pictLogo = New System.Windows.Forms.PictureBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.gpbC_Anteriores = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbM_Actuales = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Colum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCaliAnt = New System.Windows.Forms.Label()
        Me.lblMateriasAct = New System.Windows.Forms.Label()
        Me.lblCali = New System.Windows.Forms.Label()
        Me.gpbCali = New System.Windows.Forms.GroupBox()
        Me.lblAlumnos = New System.Windows.Forms.Label()
        Me.lblStre = New System.Windows.Forms.Label()
        Me.lblGrup = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pictLogoo = New System.Windows.Forms.PictureBox()
        Me.gpbCalificaciones.SuspendLayout()
        Me.gpbDatosP.SuspendLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbC_Anteriores.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbM_Actuales.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbCali.SuspendLayout()
        CType(Me.pictLogoo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbCalificaciones
        '
        Me.gpbCalificaciones.BackColor = System.Drawing.Color.LightGray
        Me.gpbCalificaciones.Controls.Add(Me.gpbDatosP)
        Me.gpbCalificaciones.Controls.Add(Me.btnRegresar)
        Me.gpbCalificaciones.Controls.Add(Me.gpbC_Anteriores)
        Me.gpbCalificaciones.Controls.Add(Me.gpbM_Actuales)
        Me.gpbCalificaciones.Controls.Add(Me.lblCaliAnt)
        Me.gpbCalificaciones.Controls.Add(Me.lblMateriasAct)
        Me.gpbCalificaciones.Controls.Add(Me.lblCali)
        Me.gpbCalificaciones.Location = New System.Drawing.Point(-1, 125)
        Me.gpbCalificaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCalificaciones.Name = "gpbCalificaciones"
        Me.gpbCalificaciones.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCalificaciones.Size = New System.Drawing.Size(921, 545)
        Me.gpbCalificaciones.TabIndex = 2
        Me.gpbCalificaciones.TabStop = False
        '
        'gpbDatosP
        '
        Me.gpbDatosP.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbDatosP.Controls.Add(Me.lblNom)
        Me.gpbDatosP.Controls.Add(Me.lblSemestre)
        Me.gpbDatosP.Controls.Add(Me.lblGrupo)
        Me.gpbDatosP.Controls.Add(Me.lblNombre)
        Me.gpbDatosP.Controls.Add(Me.pictLogo)
        Me.gpbDatosP.Location = New System.Drawing.Point(2, -125)
        Me.gpbDatosP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosP.Name = "gpbDatosP"
        Me.gpbDatosP.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbDatosP.Size = New System.Drawing.Size(918, 117)
        Me.gpbDatosP.TabIndex = 7
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
        Me.pictLogo.Location = New System.Drawing.Point(34, 16)
        Me.pictLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictLogo.Name = "pictLogo"
        Me.pictLogo.Size = New System.Drawing.Size(114, 81)
        Me.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictLogo.TabIndex = 0
        Me.pictLogo.TabStop = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.Menu
        Me.btnRegresar.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegresar.Image = CType(resources.GetObject("btnRegresar.Image"), System.Drawing.Image)
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(744, 477)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(120, 57)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'gpbC_Anteriores
        '
        Me.gpbC_Anteriores.Controls.Add(Me.DataGridView2)
        Me.gpbC_Anteriores.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gpbC_Anteriores.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.gpbC_Anteriores.Location = New System.Drawing.Point(57, 277)
        Me.gpbC_Anteriores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbC_Anteriores.Name = "gpbC_Anteriores"
        Me.gpbC_Anteriores.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbC_Anteriores.Size = New System.Drawing.Size(609, 227)
        Me.gpbC_Anteriores.TabIndex = 5
        Me.gpbC_Anteriores.TabStop = False
        Me.gpbC_Anteriores.Text = "Calificaciones Anteriores"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column5})
        Me.DataGridView2.Location = New System.Drawing.Point(46, 35)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(448, 168)
        Me.DataGridView2.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Semestre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Materia"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Calificación"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'gpbM_Actuales
        '
        Me.gpbM_Actuales.Controls.Add(Me.DataGridView1)
        Me.gpbM_Actuales.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gpbM_Actuales.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.gpbM_Actuales.Location = New System.Drawing.Point(57, 60)
        Me.gpbM_Actuales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbM_Actuales.Name = "gpbM_Actuales"
        Me.gpbM_Actuales.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbM_Actuales.Size = New System.Drawing.Size(743, 200)
        Me.gpbM_Actuales.TabIndex = 4
        Me.gpbM_Actuales.TabStop = False
        Me.gpbM_Actuales.Text = "Materias Actuales"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum1, Me.Column2, Me.DataGridViewTextBoxColumn1, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(667, 132)
        Me.DataGridView1.TabIndex = 0
        '
        'Colum1
        '
        Me.Colum1.Frozen = True
        Me.Colum1.HeaderText = "Materia"
        Me.Colum1.MinimumWidth = 6
        Me.Colum1.Name = "Colum1"
        Me.Colum1.ReadOnly = True
        Me.Colum1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre del docente"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Crédito"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'lblCaliAnt
        '
        Me.lblCaliAnt.AutoSize = True
        Me.lblCaliAnt.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCaliAnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCaliAnt.Location = New System.Drawing.Point(34, 277)
        Me.lblCaliAnt.Name = "lblCaliAnt"
        Me.lblCaliAnt.Size = New System.Drawing.Size(0, 26)
        Me.lblCaliAnt.TabIndex = 3
        '
        'lblMateriasAct
        '
        Me.lblMateriasAct.AutoSize = True
        Me.lblMateriasAct.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMateriasAct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMateriasAct.Location = New System.Drawing.Point(34, 76)
        Me.lblMateriasAct.Name = "lblMateriasAct"
        Me.lblMateriasAct.Size = New System.Drawing.Size(0, 26)
        Me.lblMateriasAct.TabIndex = 2
        '
        'lblCali
        '
        Me.lblCali.AutoSize = True
        Me.lblCali.Font = New System.Drawing.Font("Sylfaen", 13.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCali.Location = New System.Drawing.Point(346, 25)
        Me.lblCali.Name = "lblCali"
        Me.lblCali.Size = New System.Drawing.Size(211, 29)
        Me.lblCali.TabIndex = 1
        Me.lblCali.Text = "CALIFICACIONES"
        '
        'gpbCali
        '
        Me.gpbCali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gpbCali.Controls.Add(Me.lblAlumnos)
        Me.gpbCali.Controls.Add(Me.lblStre)
        Me.gpbCali.Controls.Add(Me.lblGrup)
        Me.gpbCali.Controls.Add(Me.lblName)
        Me.gpbCali.Controls.Add(Me.pictLogoo)
        Me.gpbCali.Location = New System.Drawing.Point(-1, 0)
        Me.gpbCali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCali.Name = "gpbCali"
        Me.gpbCali.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpbCali.Size = New System.Drawing.Size(921, 120)
        Me.gpbCali.TabIndex = 3
        Me.gpbCali.TabStop = False
        '
        'lblAlumnos
        '
        Me.lblAlumnos.AutoSize = True
        Me.lblAlumnos.Font = New System.Drawing.Font("Sylfaen", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAlumnos.Location = New System.Drawing.Point(248, 25)
        Me.lblAlumnos.Name = "lblAlumnos"
        Me.lblAlumnos.Size = New System.Drawing.Size(167, 48)
        Me.lblAlumnos.TabIndex = 5
        Me.lblAlumnos.Text = "Alumnos"
        '
        'lblStre
        '
        Me.lblStre.AutoSize = True
        Me.lblStre.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblStre.Location = New System.Drawing.Point(744, 25)
        Me.lblStre.Name = "lblStre"
        Me.lblStre.Size = New System.Drawing.Size(89, 25)
        Me.lblStre.TabIndex = 3
        Me.lblStre.Text = "Semestre:"
        '
        'lblGrup
        '
        Me.lblGrup.AutoSize = True
        Me.lblGrup.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGrup.Location = New System.Drawing.Point(520, 72)
        Me.lblGrup.Name = "lblGrup"
        Me.lblGrup.Size = New System.Drawing.Size(73, 25)
        Me.lblGrup.TabIndex = 2
        Me.lblGrup.Text = "Grupo: "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(520, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Nombre:"
        '
        'pictLogoo
        '
        Me.pictLogoo.Image = Global.Prepa_Director.My.Resources.Resources.logo_Baeq
        Me.pictLogoo.Location = New System.Drawing.Point(34, 16)
        Me.pictLogoo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pictLogoo.Name = "pictLogoo"
        Me.pictLogoo.Size = New System.Drawing.Size(114, 81)
        Me.pictLogoo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictLogoo.TabIndex = 0
        Me.pictLogoo.TabStop = False
        '
        'frmCali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 668)
        Me.Controls.Add(Me.gpbCali)
        Me.Controls.Add(Me.gpbCalificaciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCali"
        Me.Text = "Calificaciones"
        Me.gpbCalificaciones.ResumeLayout(False)
        Me.gpbCalificaciones.PerformLayout()
        Me.gpbDatosP.ResumeLayout(False)
        Me.gpbDatosP.PerformLayout()
        CType(Me.pictLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbC_Anteriores.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbM_Actuales.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbCali.ResumeLayout(False)
        Me.gpbCali.PerformLayout()
        CType(Me.pictLogoo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbCalificaciones As GroupBox
    Friend WithEvents lblCaliAnt As Label
    Friend WithEvents lblMateriasAct As Label
    Friend WithEvents lblCali As Label
    Friend WithEvents gpbC_Anteriores As GroupBox
    Friend WithEvents gpbM_Actuales As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Colum1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents gpbDatosP As GroupBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblSemestre As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents pictLogo As PictureBox
    Friend WithEvents gpbCali As GroupBox
    Friend WithEvents lblAlumnos As Label
    Friend WithEvents lblStre As Label
    Friend WithEvents lblGrup As Label
    Friend WithEvents lblName As Label
    Friend WithEvents pictLogoo As PictureBox
End Class
