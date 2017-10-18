Option Strict On
Option Explicit Off
Imports System.IO

Module ModuloPrincipal

    Public equipos_list As EquiposCollection
    Public jugadores_list As JugadoresCollection

    Sub main()

        equipos_list = New EquiposCollection

        jugadores_list = New JugadoresCollection

        Application.Run(MenuForm)

    End Sub
End Module
