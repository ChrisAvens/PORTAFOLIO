Public Class frmDocente
    Private Sub btnCerrarSesionD_Click(sender As Object, e As EventArgs) Handles btnCerrarSesionD.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Estas seguro que deseas cerrar sesion?", "Salir", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnModiContraD_Click(sender As Object, e As EventArgs) Handles btnModiContraD.Click
        frmCambiarContra.Show()
    End Sub

    Private Sub btnSubirCali_Click(sender As Object, e As EventArgs) Handles btnSubirCali.Click
        frmCali.Show()
    End Sub

    Private Sub btnCambiarInfoD_Click(sender As Object, e As EventArgs) Handles btnCambiarInfoD.Click
        FrmRegs.Show()
    End Sub
End Class