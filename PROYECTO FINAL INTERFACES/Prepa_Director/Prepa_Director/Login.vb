Public Class FrmIniSec
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        FrmRegs.Show()
    End Sub

    Private Sub BtnIniSec_Click(sender As Object, e As EventArgs) Handles BtnIniSec.Click

    End Sub

    Private Sub LnLblCtr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnLblCtr.LinkClicked
        frmCambiarContra.Show()
    End Sub
End Class
