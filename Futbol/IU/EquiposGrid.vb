Public Class EquiposGrid

    Private Sub EquiposGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = equipos_list

        Me.Text = "Equipos"

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        EquipoForm.operacion = "Agregar"

        EquipoForm.Text = "Agregar equipo"

        EquipoForm.Show()


    End Sub

    Private Sub llenarEquipoForm()

        EquipoForm.TextBox1.Text = DataGridView1.CurrentRow.Cells("Id").Value.ToString

        EquipoForm.TextBox2.Text = DataGridView1.CurrentRow.Cells("Nombre").Value.ToString

        EquipoForm.TextBox3.Text = DataGridView1.CurrentRow.Cells("Localidad").Value.ToString

    End Sub
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click

        EquipoForm.operacion = "Modificar"

        EquipoForm.Text = "Modificar equipo"

        llenarEquipoForm()

        EquipoForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        EquipoForm.operacion = "Eliminar"

        EquipoForm.Text = "Eliminar equipo"

        llenarEquipoForm()

        EquipoForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub
    Private Sub EquiposGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub
End Class