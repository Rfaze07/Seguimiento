Public Class frmCubiertas
    Private Sub frmCubiertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCamiones.Items.Add("Pirelli")
        cmbCamiones.Items.Add("Firestone")
        cmbCamiones.Items.Add("Michellin")
        cmbCamiones.Items.Add("Fate")
        cmbCamiones.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCamiones.SelectedIndex = 0

        dgvCamiones.MultiSelect = False
        dgvCamiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCamiones.ReadOnly = True
        dgvCamiones.Rows.Add("124", "101, TDE", "Michellin", "50000", "1235,45", "0", "13/7/2023", "")
        dgvCamiones.Rows.Add( "145", "En Recapadora", "Firestone", "45000", "452,65", "1", "13/7/2023", "")
        dgvCamiones.Rows.Add("70", "Pañol", "Michellin", "250000", "78,98", "1", "13/7/2023", "")
        dgvCamiones.Rows.Add("58", "Disponible", "Bridgestone", "451245", "124535,78", "2", "13/7/2023", "")
        dgvCamiones.Rows.Add("92", "103, DD", "Pirelli", "456000", "12325,45", "0", "13/7/2023", "")
        dgvCamiones.Rows.Add("45", "Disponible", "Fate", "412542", "4521,12", "2", "13/7/2023", "")
    End Sub

    Private Sub dgvCamiones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCamiones.CellContentClick
        Dim datos As String
        datos = $"{dgvCamiones.SelectedRows(0).Cells(0).Value.ToString},{dgvCamiones.SelectedRows(0).Cells(1).Value.ToString},{dgvCamiones.SelectedRows(0).Cells(2).Value.ToString},"
        MessageBox.Show($"{datos}")
    End Sub
End Class