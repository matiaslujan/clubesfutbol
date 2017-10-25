<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Jugadores = New System.Windows.Forms.ToolStripButton
        Me.Equipos = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.Categorias = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Jugadores, Me.Equipos, Me.Salir, Me.Categorias})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(839, 47)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Jugadores
        '
        Me.Jugadores.Image = Global.Futbol.My.Resources.Resources.jugador
        Me.Jugadores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Jugadores.Name = "Jugadores"
        Me.Jugadores.Size = New System.Drawing.Size(101, 44)
        Me.Jugadores.Text = "Jugadores"
        '
        'Equipos
        '
        Me.Equipos.Image = Global.Futbol.My.Resources.Resources.club
        Me.Equipos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Equipos.Name = "Equipos"
        Me.Equipos.Size = New System.Drawing.Size(88, 44)
        Me.Equipos.Text = "Equipos"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.Image = Global.Futbol.My.Resources.Resources.salir
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(71, 44)
        Me.Salir.Text = "Salir"
        '
        'Categorias
        '
        Me.Categorias.Image = Global.Futbol.My.Resources.Resources.categoria
        Me.Categorias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Categorias.Name = "Categorias"
        Me.Categorias.Size = New System.Drawing.Size(103, 44)
        Me.Categorias.Text = "Categorias"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Futbol.My.Resources.Resources.futboll
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 537)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Jugadores As System.Windows.Forms.ToolStripButton
    Friend WithEvents Equipos As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Categorias As System.Windows.Forms.ToolStripButton
End Class
