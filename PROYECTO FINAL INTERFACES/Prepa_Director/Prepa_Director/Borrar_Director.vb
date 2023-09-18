Public Class Borrar_Director
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Estas seguro que deseas eliminar a la persona? Es una accion irreversible", "Eliminar", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opc = MessageBox.Show("¿Estas seguro que deseas cancelar la accion?", "Salir", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class