Public Class EquipoForm

    Dim operacion_ As String

    Public MiEquipo As New EquipoClass


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

            MiEquipo.Id = CInt(TextBox1.Text)

        End If

        MiEquipo.Nombre = TextBox2.Text

        MiEquipo.Localidad = TextBox3.Text

        Select Case operacion_

            Case "Agregar"

                equipos_list.InsertarEquipo(MiEquipo)

            Case "Eliminar"

                equipos_list.EliminarEquipo(MiEquipo)

            Case "Modificar"

                equipos_list.ActualizarEquipo(MiEquipo)

                EquiposGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub





   
End Class
