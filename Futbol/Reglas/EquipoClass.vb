Imports System.IO

Public Class EquipoClass

    Private Id_ As Integer

    Public Property Id() As Integer
        Get

            Return Id_

        End Get

        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property
    Private Nombre_, Localidad_ As String

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)

            Nombre_ = value

        End Set
    End Property

    Public Property Localidad() As String
        Get
            Return Localidad_

        End Get
        Set(ByVal value As String)

            Localidad_ = value

        End Set
    End Property
End Class

