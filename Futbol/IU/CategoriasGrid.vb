Public Class CategoriasGrid

  


    Private Sub CategoriasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = categorias_list

        Me.Text = "Categorias"

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        CategoriaForm.operacion = "Agregar"

        CategoriaForm.Text = "Agregar categoria"

        CategoriaForm.Show()

    End Sub
    Private Sub llenarCategoriaForm()

        CategoriaForm.TextBox1.Text = DataGridView1.CurrentRow.Cells("Id").Value.ToString

        CategoriaForm.TextBox2.Text = DataGridView1.CurrentRow.Cells("Categoria").Value.ToString


    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click


        If DataGridView1.SelectedRows.Count = 0 Then

            MessageBox.Show("Seleccione un categoria para modificar")

            Exit Sub

        End If

        CategoriaForm.operacion = "Modificar"

        CategoriaForm.Text = "Modificar Categoria"

        llenarCategoriaForm()

        CategoriaForm.Show()

    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If DataGridView1.SelectedRows.Count = 0 Then

            MessageBox.Show("Seleccione un categoria para eliminar")

            Exit Sub

        End If

        CategoriaForm.operacion = "Eliminar"

        CategoriaForm.Text = "Eliminar Categoria"

        llenarCategoriaForm()

        CategoriaForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub CategoriasGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub
End Class