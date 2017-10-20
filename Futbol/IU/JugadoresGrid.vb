Public Class JugadoresGrid

    Private Sub JugadoresGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'DataGridView1.DataSource = jugadores_list

        'Fuente de datos la coleccion carreras_list.
        ToolStripComboBox1.ComboBox.DataSource = equipos_list
        'El miembro a mostrar de la lista es Carrera.
        ToolStripComboBox1.ComboBox.DisplayMember = "Nombre"
        'El miembro de valor es siempre el id.
        ToolStripComboBox1.ComboBox.ValueMember = "Id"
        'Como no tenemos que valor seleccionar dejo el primero.
        'ToolStripComboBox1.ComboBox.SelectedValue = 1



        Me.Text = "Jugadores"

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        JugadorForm.operacion = "Agregar"

        JugadorForm.Text = "Agregar jugador"

        JugadorForm.combo = ToolStripComboBox1.ComboBox.SelectedValue

        JugadorForm.Show()

    End Sub
    Private Sub llenarJugadorForm()

        JugadorForm.TextBox1.Text = DataGridView1.CurrentRow.Cells("Id").Value.ToString

        JugadorForm.TextBox2.Text = DataGridView1.CurrentRow.Cells("Nombre").Value.ToString

        JugadorForm.TextBox3.Text = DataGridView1.CurrentRow.Cells("DNI").Value.ToString

        JugadorForm.TextBox4.Text = CDate(DataGridView1.CurrentRow.Cells("FechaNac").Value.ToString)

        JugadorForm.combo = CInt(DataGridView1.CurrentRow.Cells("IdEquipo").Value.ToString)
    End Sub
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click

        JugadorForm.operacion = "Modificar"

        JugadorForm.Text = "Modificar jugador"

        llenarJugadorForm()

        JugadorForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        JugadorForm.operacion = "Eliminar"

        JugadorForm.Text = "Eliminar jugador"

        llenarJugadorForm()

        JugadorForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()


    End Sub
    Private Sub JugadoresGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtrar.Click

        'Obtiene el IdCarrera seleccionando en el Combobox1.
        Dim IdEquipo As Integer = CInt(ToolStripComboBox1.ComboBox.SelectedValue)

        '    'No pude aplicar filtro al bindingsource asi que lo recargue filtrado de mesas_list.
        DataGridView1.DataSource = jugadores_list.TraerJugadores(IdEquipo)

        '    'Quita la seleccion del contenido del Combobox
        ToolStripComboBox1.SelectionLength = 0

    End Sub
End Class