Imports System.Windows.Forms

Public Class MenuForm


    Private Sub Jugadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jugadores.Click

        ToolStrip1.Enabled = False

        Dim gridJugadores As New JugadoresGrid

        gridJugadores.MdiParent = Me

        gridJugadores.Show()


    End Sub

    Private Sub Equipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Equipos.Click

        ToolStrip1.Enabled = False

        Dim gridEquipos As New EquiposGrid

        gridEquipos.MdiParent = Me

        gridEquipos.Show()


    End Sub
    Private Sub Categorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Categorias.Click

        ToolStrip1.Enabled = False

        Dim gridCategorias As New CategoriasGrid

        gridCategorias.MdiParent = Me

        gridCategorias.Show()


    End Sub
    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        End

    End Sub
End Class