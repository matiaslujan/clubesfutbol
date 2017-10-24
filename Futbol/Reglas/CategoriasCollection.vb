Imports System.ComponentModel
Imports System.Text
Public Class CategoriasCollection

    Inherits BindingList(Of CategoriaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        MyBase.OnAddingNew(e)

        e.NewObject = New CategoriaClass

    End Sub
    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get

            Return True

        End Get

    End Property
    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer

        For Each Categoria In Me
            If prop.GetValue(Categoria).Equals(key) Then
                Return Me.IndexOf(Categoria)
            End If
        Next

        Return -1

    End Function
    Public Sub New()

        Me.TraerCategorias()

    End Sub
    Public Function TraerCategorias() As CategoriasCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiCategoria As CategoriaClass

        objBaseDatos.objTabla = "Categorias"

        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows

            MiCategoria = New CategoriaClass
            MiCategoria.Id = CInt(dr("Id"))
            MiCategoria.Categoria = CStr(dr("Categoria"))


            Me.Add(MiCategoria)

        Next
        Return Me
    End Function

    Public Sub InsertarCategoria(ByVal MiCategoria As CategoriaClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Categorias"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Categoria)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiCategoria.Categoria & "')")



        MiCategoria.Id = objBaseDatos.Insertar(vSQL.ToString)

        'Evalúa el resultado del comando SQL.
        If MiCategoria.Id = 0 Then
            MsgBox("No fue posible agregar la Categoria " + MiCategoria.Categoria)
            Exit Sub
        End If

        Me.Add(MiCategoria)

    End Sub

    Public Sub EliminarCategoria(ByVal MiCategoria As CategoriaClass)

        Dim objBaseDatos As New BaseDatosClass

        objBaseDatos.objTabla = "Categorias"

        Dim resultado As Boolean

        resultado = objBaseDatos.Eliminar(MiCategoria.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar la Categoria " + MiCategoria.Categoria)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCategoria)
        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)

        Me.RemoveAt(Me.FindCore(myProperty, MiCategoria.Id))

    End Sub

    Public Sub ActualizarCategoria(ByVal MiCategoria As CategoriaClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Categorias"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Categoria='" & MiCategoria.Categoria & "'")


        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiCategoria.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar  la Categoria " + MiCategoria.Categoria)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCategoria)

        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)
        Me.Items.Item(Me.FindCore(myProperty, MiCategoria.Id)) = MiCategoria

    End Sub

End Class
