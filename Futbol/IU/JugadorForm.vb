Public Class JugadorForm
    Dim operacion_ As String

    Public MiJugador As New JugadorClass


    Public Property operacion() As String
        Get

            Return operacion_

        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set

    End Property

    Dim combo_ As Integer

    Public Property combo() As Integer
        Get
            Return combo_

        End Get
        Set(ByVal value As Integer)
            combo_ = value

        End Set
    End Property


    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If operacion_ <> "Agregar" Then

            MiJugador.Id = CInt(TextBox1.Text)

        End If

        MiJugador.Nombre = TextBox2.Text

        MiJugador.DNI = CInt(TextBox3.Text)

        MiJugador.FechaNac = CDate(TextBox4.Text)

        MiJugador.IdEquipo = CInt(ComboBox1.SelectedValue)

        Select Case operacion_

            Case "Agregar"

                If ComboBox1.SelectedIndex = -1 Then Exit Sub

                jugadores_list.InsertarJugador(MiJugador)

            Case "Eliminar"

                jugadores_list.EliminarJugador(MiJugador)

            Case "Modificar"

                jugadores_list.ActualizarJugador(MiJugador)

                JugadoresGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub

    Private Sub JugadorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ComboBox1.DataSource = equipos_list

        ComboBox1.DisplayMember = "Nombre"

        ComboBox1.ValueMember = "Id"

        ComboBox1.SelectedValue = combo

    End Sub

    'textbox DNI
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If


    End Sub

    'textbox FechaNac

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = "-" Then

            e.Handled = True

        End If

        Dim pos As Integer = TextBox4.SelectionStart

        If e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = "-" Then

            e.Handled = True

            SendKeys.Send("/")

        End If

        If e.KeyChar = "/" Then

            If pos <> 2 And pos <> 5 Then

                e.Handled = True

            End If

        End If

        If Char.IsNumber(e.KeyChar) Then

            If (pos = 2 Or pos = 5) Then

                e.Handled = True

            End If

        End If

    End Sub


End Class