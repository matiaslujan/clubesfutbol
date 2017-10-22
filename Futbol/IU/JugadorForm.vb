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
        'aceptar numeros, teclas de control  y . - ,
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = "-" Then

            e.Handled = True

        End If

        Dim pos As Integer = TextBox4.SelectionStart

        'cambiar . , o - por /

        If e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = "-" Then

            e.Handled = True

            SendKeys.Send("/")

        End If

        'si ingresa / en posiciones distintas a 2 o 5 no tomar

        If e.KeyChar = "/" Then

            If pos <> 2 And pos <> 5 Then

                e.Handled = True

            End If

        End If

        'si ingresa numeros en posiciones 2 o 5 no tomar

        If Char.IsNumber(e.KeyChar) Then

            If (pos = 2 Or pos = 5) Then

                e.Handled = True

            End If

        End If


        'If pos = 9 Then

        '    MsgBox("Fecha Completa")

        '    Exit Sub

        'End If

    End Sub


    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.LostFocus

        Dim fec() As String

        Dim dia, mes, anio As Integer

        If TextBox4.Text.Length < TextBox4.MaxLength Then

            LabelFecha.Visible = True

            LabelFecha.Text = "Complete la fecha"

            'MsgBox("Complete la fecha")

            Exit Sub

        End If
        'separar datos
        fec = TextBox4.Text.Split("/")
        'tomar valores
        dia = CInt(fec(0))
        mes = CInt(fec(1))
        anio = CInt(fec(2))

        'verificar año

        If anio < 1950 Or anio > 2100 Then

            LabelFecha.Visible = True

            LabelFecha.Text = "Año incorrecto"

            'MsgBox("Año incorrecto")

            Exit Sub

        End If

        'verificar mes

        If mes < 1 Or mes > 12 Then

            LabelFecha.Visible = True

            LabelFecha.Text = "Mes incorrecto"

            'MsgBox("Mes incorrecto")

            Exit Sub

        End If

        'verificar dia considrando año bisiesto y mes

        Select Case mes

            Case 1, 3, 5, 7, 8, 10, 12

                If dia < 1 Or dia > 31 Then

                    LabelFecha.Visible = True

                    LabelFecha.Text = "Dia incorrecto"

                    ' MsgBox("Dia incorrecto")

                    Exit Sub

                End If

            Case 4, 6, 9, 11

                If dia < 1 Or dia > 30 Then

                    LabelFecha.Visible = True

                    LabelFecha.Text = "Dia incorrecto"

                    'MsgBox("Dia incorrecto")

                    Exit Sub

                End If
            Case 2
                'año bisiesto
                If anio Mod 4 = 0 Then

                    'mes con 29 dias

                    If dia < 1 Or dia > 29 Then

                        LabelFecha.Visible = True

                        LabelFecha.Text = "Dia incorrecto"

                        'MsgBox("Dia incorrecto")

                        Exit Sub

                    End If
                Else

                    'mes con 28 dias

                    If dia < 1 Or dia > 28 Then

                        LabelFecha.Visible = True

                        LabelFecha.Text = "Dia incorrecto"

                        'MsgBox("Dia incorrecto")

                        Exit Sub

                    End If


                End If
        End Select
    End Sub

    
End Class