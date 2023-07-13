Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private formActual As Form = Nothing
    Private Sub AbrirFormHijo(formHijo As Form)
        If formActual IsNot Nothing Then formActual = Nothing
        formActual = formHijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        panelFormHijo.Controls.Add(formHijo)
        panelFormHijo.Tag = formHijo
        formHijo.BringToFront()
        formHijo.Show()

    End Sub

    Private Sub btnCamiones_Click(sender As Object, e As EventArgs) Handles btnCamiones.Click
        AbrirFormHijo(frmCamiones)
    End Sub
End Class
