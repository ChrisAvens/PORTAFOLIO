Public Class FrmRegs
    'Cancel:  Registrar  CbxCargo  lblCargo y lbl grupo  lblsem   txtgrupo  txtsem 
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCargo.SelectedIndexChanged
        Dim ptBtnCan = BtnCancel.Location, ptBtnReg = BtnReg.Location, x As Point
        Dim ptLblCar = LblCargo.Location, ptCbxCr = CbxCargo.Location, y As Point

        If (CbxCargo.Text() = "Alumno") Then
            ptLblCar.Y = 61
            ptCbxCr.Y = 58
            ptBtnCan.Y = 274
            ptBtnReg.Y = 274
            BtnMateria.Visible = False
            TxtGrup.Visible = True
            TxtSem.Visible = True
            LblGrup.Visible = True
            LblSem.Visible = True
        ElseIf (CbxCargo.Text() = "Docente") Then
            ptLblCar.Y = 101
            ptCbxCr.Y = 98
            ptBtnCan.Y = 255
            ptBtnReg.Y = 255
            BtnMateria.Visible = True
            TxtGrup.Visible = False
            TxtSem.Visible = False
            LblGrup.Visible = False
            LblSem.Visible = False
        Else
            ptLblCar.Y = 134
            ptCbxCr.Y = 131
            ptBtnCan.Y = 196
            ptBtnReg.Y = 196
            BtnMateria.Visible = False
            TxtGrup.Visible = False
            TxtSem.Visible = False
            LblGrup.Visible = False
            LblSem.Visible = False
        End If
        LblCargo.Location = ptLblCar
        CbxCargo.Location = ptCbxCr
        BtnCancel.Location = ptBtnCan
        BtnReg.Location = ptBtnReg


    End Sub

    Private Sub BtnMateria_Click(sender As Object, e As EventArgs) Handles BtnMateria.Click
        FrmMaterias.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Estas seguro que deseas cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        If CbxCargo.Text = "Alumno" Then
            frmSesionEstudiante.Show()
            Me.Visible = False
        ElseIf CbxCargo.Text = "Docente" Then
            frmDocente.Show()
        ElseIf CbxCargo.Text = "Director" Then
            Menu_Director.Show()
        End If
    End Sub
End Class