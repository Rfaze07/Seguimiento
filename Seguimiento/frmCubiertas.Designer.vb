<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCubiertas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCubiertas))
        Me.dgvCamiones = New System.Windows.Forms.DataGridView()
        Me.cmbCamiones = New System.Windows.Forms.ComboBox()
        Me.IdCubierta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantRecapados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPrimerMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaBaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFicha = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvCamiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCamiones
        '
        Me.dgvCamiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCamiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCubierta, Me.Ubicacion, Me.Proveedor, Me.Valor, Me.Km, Me.CantRecapados, Me.FechaPrimerMovimiento, Me.FechaBaja, Me.btnFicha})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCamiones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCamiones.Location = New System.Drawing.Point(12, 69)
        Me.dgvCamiones.Name = "dgvCamiones"
        Me.dgvCamiones.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvCamiones.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCamiones.RowTemplate.DividerHeight = 2
        Me.dgvCamiones.RowTemplate.Height = 35
        Me.dgvCamiones.Size = New System.Drawing.Size(834, 464)
        Me.dgvCamiones.TabIndex = 3
        '
        'cmbCamiones
        '
        Me.cmbCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCamiones.FormattingEnabled = True
        Me.cmbCamiones.Location = New System.Drawing.Point(350, 37)
        Me.cmbCamiones.Name = "cmbCamiones"
        Me.cmbCamiones.Size = New System.Drawing.Size(149, 26)
        Me.cmbCamiones.TabIndex = 4
        '
        'IdCubierta
        '
        Me.IdCubierta.HeaderText = "Id"
        Me.IdCubierta.Name = "IdCubierta"
        Me.IdCubierta.Width = 50
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Km
        '
        Me.Km.HeaderText = "Km"
        Me.Km.Name = "Km"
        '
        'CantRecapados
        '
        Me.CantRecapados.HeaderText = "Cantidad Recapados"
        Me.CantRecapados.Name = "CantRecapados"
        '
        'FechaPrimerMovimiento
        '
        Me.FechaPrimerMovimiento.HeaderText = "Fecha de Primer Movimiento"
        Me.FechaPrimerMovimiento.Name = "FechaPrimerMovimiento"
        '
        'FechaBaja
        '
        Me.FechaBaja.HeaderText = "Fecha Baja"
        Me.FechaBaja.Name = "FechaBaja"
        '
        'btnFicha
        '
        Me.btnFicha.HeaderText = ""
        Me.btnFicha.Image = CType(resources.GetObject("btnFicha.Image"), System.Drawing.Image)
        Me.btnFicha.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.btnFicha.Name = "btnFicha"
        Me.btnFicha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnFicha.Width = 30
        '
        'frmCubiertas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 680)
        Me.Controls.Add(Me.cmbCamiones)
        Me.Controls.Add(Me.dgvCamiones)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCubiertas"
        Me.Text = "frmCubiertas"
        CType(Me.dgvCamiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCamiones As DataGridView
    Friend WithEvents cmbCamiones As ComboBox
    Friend WithEvents IdCubierta As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents CantRecapados As DataGridViewTextBoxColumn
    Friend WithEvents FechaPrimerMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents FechaBaja As DataGridViewTextBoxColumn
    Friend WithEvents btnFicha As DataGridViewImageColumn
End Class
