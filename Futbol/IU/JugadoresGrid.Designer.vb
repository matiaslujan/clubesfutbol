<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadoresGrid
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
        Me.components = New System.ComponentModel.Container
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.Filtrar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetalleCat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetalleEq = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JugadorClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JugadorClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.Modificar, Me.Eliminar, Me.Salir, Me.Filtrar, Me.ToolStripComboBox1, Me.ToolStripComboBox2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.Image = Global.Futbol.My.Resources.Resources.agregar
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(80, 34)
        Me.Agregar.Text = "Agregar"
        '
        'Modificar
        '
        Me.Modificar.Image = Global.Futbol.My.Resources.Resources.Actualizar__1_
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(84, 34)
        Me.Modificar.Text = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.Futbol.My.Resources.Resources.eliminar
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(77, 34)
        Me.Eliminar.Text = "Eliminar"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.Image = Global.Futbol.My.Resources.Resources.salir
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(61, 34)
        Me.Salir.Text = "Salir"
        '
        'Filtrar
        '
        Me.Filtrar.Image = Global.Futbol.My.Resources.Resources.filtro
        Me.Filtrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Filtrar.Name = "Filtrar"
        Me.Filtrar.Size = New System.Drawing.Size(69, 34)
        Me.Filtrar.Text = "Filtrar"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(225, 37)
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 21)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdCategoria, Me.DNI, Me.IdEquipo, Me.Nombre, Me.FechaNac, Me.DetalleEq, Me.DetalleCat})
        Me.DataGridView1.DataSource = Me.JugadorClassBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(647, 239)
        Me.DataGridView1.TabIndex = 1
        '
        'IdCategoria
        '
        Me.IdCategoria.DataPropertyName = "IdCategoria"
        Me.IdCategoria.HeaderText = "IdCategoria"
        Me.IdCategoria.Name = "IdCategoria"
        Me.IdCategoria.ReadOnly = True
        Me.IdCategoria.Visible = False
        '
        'DetalleCat
        '
        Me.DetalleCat.DataPropertyName = "DetalleCat"
        Me.DetalleCat.HeaderText = "DetalleCat"
        Me.DetalleCat.Name = "DetalleCat"
        Me.DetalleCat.ReadOnly = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'IdEquipo
        '
        Me.IdEquipo.DataPropertyName = "IdEquipo"
        Me.IdEquipo.HeaderText = "IdEquipo"
        Me.IdEquipo.Name = "IdEquipo"
        Me.IdEquipo.ReadOnly = True
        Me.IdEquipo.Visible = False
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'FechaNac
        '
        Me.FechaNac.DataPropertyName = "FechaNac"
        Me.FechaNac.HeaderText = "FechaNac"
        Me.FechaNac.Name = "FechaNac"
        Me.FechaNac.ReadOnly = True
        '
        'DetalleEq
        '
        Me.DetalleEq.DataPropertyName = "DetalleEq"
        Me.DetalleEq.HeaderText = "DetalleEq"
        Me.DetalleEq.Name = "DetalleEq"
        Me.DetalleEq.ReadOnly = True
        '
        'JugadorClassBindingSource
        '
        Me.JugadorClassBindingSource.DataSource = GetType(Futbol.JugadorClass)
        '
        'JugadoresGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 276)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "JugadoresGrid"
        Me.Text = "JugadoresGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JugadorClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Filtrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents JugadorClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEquipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleEq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleCat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
