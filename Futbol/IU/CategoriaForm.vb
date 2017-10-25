Public Class CategoriaForm

    Dim operacion_ As String

    Public MiCategoria As New CategoriaClass


    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If operacion_ <> "Agregar" Then

            MiCategoria.Id = CInt(TextBox1.Text)

        End If

        MiCategoria.Categoria = TextBox2.Text



        Select Case operacion_

            Case "Agregar"

                categorias_list.InsertarCategoria(MiCategoria)

            Case "Eliminar"

                categorias_list.EliminarCategoria(MiCategoria)

            Case "Modificar"

                categorias_list.ActualizarCategoria(MiCategoria)

                CategoriasGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub

End Class