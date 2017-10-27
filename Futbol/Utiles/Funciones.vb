Module Funciones

    Public Function validarFecha(ByVal Fecha As String) As Boolean

        Dim fec() As String
        Dim dia, mes, anio As Integer

        'fecha sin completar
        If Fecha.Length < 10 Then
            MsgBox("Complete la fecha.")
            Return False
        End If

        'Obtiene un array con el dia, mes y año.
        fec = CStr(Fecha).Split(CChar("/"))

        dia = CInt(fec(0))
        mes = CInt(fec(1))
        anio = CInt(fec(2))

        'Vefica que el año este entre 1900 y 2100.
        If anio < 1950 Or anio > 2100 Then

            MsgBox("El año es incorrecto.")

            Return False

        End If

        'Verifica que el año este entre 1 y 12.
        If mes < 1 Or mes > 12 Then

            MsgBox("El mes es incorrecto.")

            Return False
        End If

        'Verifica el dia considerando año bisiesto y mes.
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                'Meses con 31 días.
                If dia < 1 Or dia > 31 Then
                    MsgBox("El dia es incorrecto.")
                    Return False
                End If

            Case 4, 6, 9, 11
                'Meses con 30 días.
                If dia < 1 Or dia > 30 Then
                    MsgBox("El dia es incorrecto.")
                    Return False
                End If

            Case 2
                'Año bisiesto.
                If anio Mod 4 = 0 Then
                    'Febrero con 29 días.
                    If dia < 1 Or dia > 29 Then
                        MsgBox("El dia es incorrecto.")
                        Return False
                    End If
                Else
                    'Febrero con 28 días.
                    If dia < 1 Or dia > 28 Then
                        MsgBox("El dia es incorrecto.")
                        Return False
                    End If
                End If

        End Select

        Return True

    End Function

End Module
