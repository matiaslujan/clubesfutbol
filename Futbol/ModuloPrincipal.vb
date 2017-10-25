Option Strict On
Option Explicit Off
Imports System.IO

Module ModuloPrincipal

    Public equipos_list As EquiposCollection
    Public jugadores_list As JugadoresCollection
    Public categorias_list As CategoriasCollection


    Sub main()

        equipos_list = New EquiposCollection

        jugadores_list = New JugadoresCollection

        categorias_list = New CategoriasCollection

        Application.Run(MenuForm)

    End Sub
End Module

