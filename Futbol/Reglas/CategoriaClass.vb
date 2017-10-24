Imports System.IO

Public Class CategoriaClass
    Private Id_ As Integer

    Private Categoria_ As String

    Public Property Id() As Integer
        Get

            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property


    Public Property Categoria() As String
        Get
            Return Categoria_
        End Get

        Set(ByVal value As String)

            Categoria_ = value
        End Set

    End Property

End Class
