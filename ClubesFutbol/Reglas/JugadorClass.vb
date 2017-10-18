Imports System.IO

Public Class JugadorClass

    Private Id_, DNI_, IdEquipo_ As Integer

    Public Property Id() As Integer
        Get

            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property DNI() As Integer
        Get

            Return DNI_

        End Get
        Set(ByVal value As Integer)

            DNI_ = value

        End Set
    End Property

    Public Property IdEquipo() As Integer
        Get

            Return IdEquipo_

        End Get
        Set(ByVal value As Integer)

            IdEquipo_ = value

        End Set
    End Property

    Private Nombre_, DetalleEq_ As String

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)

            Nombre_ = value
        End Set
    End Property

    Public ReadOnly Property DetalleEq() As String
        Get

            For Each equipo In equipos_list

                If equipo.Id = IdEquipo_ Then

                    DetalleEq_ = equipo.Nombre

                End If
            Next

            Return DetalleEq_

        End Get


    End Property

    Private FechaNac_ As Date

    Public Property FechaNac() As Date
        Get
            Return FechaNac_

        End Get
        Set(ByVal value As Date)
            FechaNac_ = value

        End Set
    End Property
End Class
