<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCamiones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbCamiones = New System.Windows.Forms.ComboBox()
        Me.lblCamiones = New System.Windows.Forms.Label()
        Me.dgvCamiones = New System.Windows.Forms.DataGridView()
        Me.btnCargarKm = New System.Windows.Forms.Button()
        CType(Me.dgvCamiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCamiones
        '
        Me.cmbCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCamiones.FormattingEnabled = True
        Me.cmbCamiones.Location = New System.Drawing.Point(123, 41)
        Me.cmbCamiones.Name = "cmbCamiones"
        Me.cmbCamiones.Size = New System.Drawing.Size(238, 26)
        Me.cmbCamiones.TabIndex = 0
        '
        'lblCamiones
        '
        Me.lblCamiones.AutoSize = True
        Me.lblCamiones.Location = New System.Drawing.Point(37, 44)
        Me.lblCamiones.Name = "lblCamiones"
        Me.lblCamiones.Size = New System.Drawing.Size(80, 18)
        Me.lblCamiones.TabIndex = 1
        Me.lblCamiones.Text = "Camiones"
        '
        'dgvCamiones
        '
        Me.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCamiones.Location = New System.Drawing.Point(40, 73)
        Me.dgvCamiones.Name = "dgvCamiones"
        Me.dgvCamiones.Size = New System.Drawing.Size(455, 450)
        Me.dgvCamiones.TabIndex = 2
        '
        'btnCargarKm
        '
        Me.btnCargarKm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarKm.Location = New System.Drawing.Point(501, 262)
        Me.btnCargarKm.Name = "btnCargarKm"
        Me.btnCargarKm.Size = New System.Drawing.Size(108, 62)
        Me.btnCargarKm.TabIndex = 3
        Me.btnCargarKm.Text = "Cargar Kilometraje"
        Me.btnCargarKm.UseVisualStyleBackColor = True
        '
        'frmCamiones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(886, 680)
        Me.Controls.Add(Me.btnCargarKm)
        Me.Controls.Add(Me.dgvCamiones)
        Me.Controls.Add(Me.lblCamiones)
        Me.Controls.Add(Me.cmbCamiones)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCamiones"
        CType(Me.dgvCamiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCamiones As ComboBox
    Friend WithEvents lblCamiones As Label
    Friend WithEvents dgvCamiones As DataGridView
    Friend WithEvents btnCargarKm As Button
End Class
