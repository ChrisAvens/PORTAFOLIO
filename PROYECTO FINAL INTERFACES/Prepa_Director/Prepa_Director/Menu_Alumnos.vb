Imports System.Reflection.Emit

Public Class frmSesionEstudiante
    Private Sub btnConsultarCali_Click(sender As Object, e As EventArgs) Handles btnConsultarCali.Click
        frmCali.Show()
    End Sub

    Private Sub btnCambiarInfo_Click(sender As Object, e As EventArgs) Handles btnCambiarInfo.Click
        FrmRegs.Show()
    End Sub

    Private Sub btnModiContra_Click(sender As Object, e As EventArgs) Handles btnModiContra.Click
        frmCambiarContra.Show()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Estas seguro que deseas cerrar sesion?", "Salir", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
