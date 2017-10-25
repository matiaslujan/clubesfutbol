Imports System.ComponentModel
Imports System.Text

Public Class JugadoresCollection


    Inherits BindingList(Of JugadorClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)

        MyBase.OnAddingNew(e)

        e.NewObject = New JugadorClass

    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean

        Get
            Return True
        End Get

    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each jugador In Me

            If prop.GetValue(jugador).Equals(key) Then

                Return Me.IndexOf(jugador)

            End If

        Next

        Return -1
    End Function



    Public Sub New()

        Me.TraerJugadores()

    End Sub

    Public Function TraerJugadores() As JugadoresCollection

        Dim objBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiJugador As JugadorClass

        objBaseDatos.objTabla = "jugadores"

        MiDataTable = objBaseDatos.Consultar

        For Each dr As DataRow In MiDataTable.Rows

            MiJugador = New JugadorClass
            MiJugador.Id = CInt(dr("Id"))
            MiJugador.Nombre = CStr(dr("Nombre"))
            MiJugador.DNI = CInt(dr("DNI"))
            MiJugador.IdEquipo = CInt(dr("IdEquipo"))
            MiJugador.FechaNac = CDate(Format(CDate(dr("FechaNac")), "dd/MM/yyyy"))
            MiJugador.IdCategoria = CInt(dr("IdCategoria"))

            Me.Add(Mijugador)

        Next

        Return Me

    End Function

    Public Function TraerJugadores(ByVal IdEquipo As Integer, ByVal IdCategoria As Integer) As JugadoresCollection

        Dim jugadores_filtro As New JugadoresCollection
        'Necesito hacer esto porque no se crea vacio ya que el New carga la lista automaticamente desde la tabla.
        jugadores_filtro.ClearItems()

        'En este caso lo cargamos de jugadores_list filtrado

        For Each jugador In jugadores_list

            'Solamente agrega (Add) el jugador para el equipo indicado indicada en IdEquipo.

            If jugador.IdEquipo = IdEquipo And jugador.IdCategoria = IdCategoria Then

                jugadores_filtro.Add(jugador)

            End If

        Next

        Return jugadores_filtro

    End Function

    Public Sub InsertarJugador(ByVal MiJugador As JugadorClass)


        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Jugadores"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("(Nombre")
        vSQL.Append(",DNI")
        vSQL.Append(",FechaNac")
        vSQL.Append(",IdEquipo")
        vSQL.Append(",Idcategoria)")
        vSQL.Append(" VALUES ")
        vSQL.Append("('" & MiJugador.Nombre & "'")
        vSQL.Append(",'" & MiJugador.DNI & "'")
        vSQL.Append(",'" & MiJugador.FechaNac & "'")
        vSQL.Append(",'" & MiJugador.IdEquipo & "'")
        vSQL.Append(",'" & MiJugador.IdCategoria & "')")

        MiJugador.Id = objBaseDatos.Insertar(vSQL.ToString)

        If MiJugador.Id = 0 Then
            MsgBox("No fue posible agregarel jugador " + MiJugador.Nombre)
            Exit Sub
        End If

        Me.Add(MiJugador)

    End Sub

    Public Sub EliminarJugador(ByVal MiJugador As JugadorClass)


        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Jugadores"

        'ejecuta el método base eliminar 
        Dim resultado As Boolean

        resultado = objBaseDatos.Eliminar(MiJugador.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible eliminar l jugador " + MiJugador.Nombre)
            Exit Sub
        End If

        'Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiJugador)

        'Sets as PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)
        Me.RemoveAt(Me.FindCore(myProperty, MiJugador.Id))

    End Sub

    Public Sub ActualizarJugador(ByVal MiJugador As JugadorClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Jugadores"
        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Nombre='" & MiJugador.Nombre & "'")
        vSQL.Append(",DNI='" & MiJugador.DNI & "'")
        vSQL.Append(",FechaNac='" & MiJugador.FechaNac & "'")
        vSQL.Append(",IdEquipo='" & MiJugador.IdEquipo & "'")
        vSQL.Append(",IdCategoria='" & MiJugador.IdCategoria & "'")


        Dim resultado As Boolean

        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiJugador.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el jugador " + MiJugador.Nombre)
            Exit Sub
        End If


        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiJugador)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", True)

        Me.Items.Item(Me.FindCore(myProperty, MiJugador.Id)) = MiJugador

    End Sub
End Class

