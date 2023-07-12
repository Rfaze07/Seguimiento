<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnCubiertas = New System.Windows.Forms.Button()
        Me.btnCamiones = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelMenu.BackgroundImage = CType(resources.GetObject("PanelMenu.BackgroundImage"), System.Drawing.Image)
        Me.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.btnCubiertas)
        Me.PanelMenu.Controls.Add(Me.btnCamiones)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 701)
        Me.PanelMenu.TabIndex = 1
        '
        'btnCubiertas
        '
        Me.btnCubiertas.BackColor = System.Drawing.Color.Black
        Me.btnCubiertas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCubiertas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCubiertas.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCubiertas.FlatAppearance.BorderSize = 2
        Me.btnCubiertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCubiertas.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCubiertas.Location = New System.Drawing.Point(0, 204)
        Me.btnCubiertas.Name = "btnCubiertas"
        Me.btnCubiertas.Size = New System.Drawing.Size(228, 55)
        Me.btnCubiertas.TabIndex = 2
        Me.btnCubiertas.Text = "Cubiertas"
        Me.btnCubiertas.UseVisualStyleBackColor = False
        '
        'btnCamiones
        '
        Me.btnCamiones.BackColor = System.Drawing.Color.Black
        Me.btnCamiones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCamiones.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCamiones.FlatAppearance.BorderSize = 2
        Me.btnCamiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamiones.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamiones.Location = New System.Drawing.Point(0, 149)
        Me.btnCamiones.Name = "btnCamiones"
        Me.btnCamiones.Size = New System.Drawing.Size(228, 55)
        Me.btnCamiones.TabIndex = 1
        Me.btnCamiones.Text = "Camiones"
        Me.btnCamiones.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.pbLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(228, 149)
        Me.PanelLogo.TabIndex = 0
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(228, 149)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(279, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 30)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "LISTADO DE CAMIONES"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1144, 701)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnCubiertas As Button
    Friend WithEvents btnCamiones As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
