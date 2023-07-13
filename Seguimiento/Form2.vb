Public Class frmCamiones
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCamiones.Items.Add("101")
        cmbCamiones.Items.Add("102")
        cmbCamiones.Items.Add("103")
        cmbCamiones.Items.Add("104")
        cmbCamiones.Items.Add("105")
        cmbCamiones.Items.Add("106")
        cmbCamiones.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCamiones.SelectedIndex = 0


        dgvCamiones.MultiSelect = False
        dgvCamiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCamiones.ReadOnly = True
        dgvCamiones.Rows.Add("DD", "124", "101", "Michellin", "50000", "1235,45", "0", "13/7/2023", "")
        dgvCamiones.Rows.Add("DI", "145", "101", "Firestone", "45000", "452,65", "1", "13/7/2023", "")
        dgvCamiones.Rows.Add("TDE", "70", "101", "Michellin", "250000", "78,98", "1", "13/7/2023", "")
        dgvCamiones.Rows.Add("TDI", "58", "101", "Bridgestone", "451245", "124535,78", "2", "13/7/2023", "")
        dgvCamiones.Rows.Add("TIE", "92", "101", "Pirelli", "456000", "12325,45", "0", "13/7/2023", "")
        dgvCamiones.Rows.Add("TII", "45", "101", "Fate", "412542", "4521,12", "2", "13/7/2023", "")


    End Sub

    Private Sub dgvCamiones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCamiones.CellContentClick
        Dim datos As String
        datos = $"{dgvCamiones.SelectedRows(0).Cells(0).Value.ToString},{dgvCamiones.SelectedRows(0).Cells(1).Value.ToString},{dgvCamiones.SelectedRows(0).Cells(2).Value.ToString},"
        MessageBox.Show($"{datos}")
    End Sub
End Class