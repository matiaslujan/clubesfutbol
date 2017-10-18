Imports System.ComponentModel
Imports System.Text

Public Class EquiposCollection


    Inherits BindingList(Of EquipoClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        MyBase.OnAddingNew(e)

        e.NewObject = New EquipoClass

    End Sub
    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get

            Return True

        End Get

    End Property
    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer

        For Each equipo In Me
            If prop.GetValue(equipo).Equals(key) Then
                Return Me.IndexOf(equipo)
            End If
        Next

        Return -1

    End Function
    Public Sub New()

        Me.TraerEquipos()

    End Sub
    Public Function TraerEquipos() As EquiposCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiEquipo As EquipoClass

        objBaseDatos.objTabla = "Equipos"

        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows

            MiEquipo = New EquipoClass
            MiEquipo.Id = CInt(dr("Id"))
            MiEquipo.Nombre = CStr(dr("Nombre"))
            MiEquipo.Localidad = CStr(dr("Localidad"))

            Me.Add(MiEquipo)

        Next
        Return Me
    End Function

    Public Sub InsertarEquipo(ByVal MiEquipo As EquipoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Equipos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Nombre")
        vSQL.Append(",Localidad)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiEquipo.Nombre & "'")
        vSQL.Append(",'" & MiEquipo.Localidad & "')")


        MiEquipo.Id = objBaseDatos.Insertar(vSQL.ToString)

        'Evalúa el resultado del comando SQL.
        If MiEquipo.Id = 0 Then
            MsgBox("No fue posible agregar el equipo " + MiEquipo.Nombre)
            Exit Sub
        End If

        Me.Add(MiEquipo)

    End Sub

    Public Sub EliminarEquipo(ByVal MiEquipo As EquipoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Equipos"

        Dim resultado As Boolean

        resultado = objBaseDatos.Eliminar(MiEquipo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar el equipo " + MiEquipo.Nombre)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiEquipo)
        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)

        Me.RemoveAt(Me.FindCore(myProperty, MiEquipo.Id))

    End Sub

    Public Sub ActualizarEquipo(ByVal MiEquipo As EquipoClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Equipos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Nombre='" & MiEquipo.Nombre & "'")
        vSQL.Append(",Localidad='" & MiEquipo.Localidad & "'")

        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiEquipo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar  el equipo " + MiEquipo.Nombre)
            Exit Sub
        End If

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiEquipo)

        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)
        Me.Items.Item(Me.FindCore(myProperty, MiEquipo.Id)) = MiEquipo

    End Sub
End Class
