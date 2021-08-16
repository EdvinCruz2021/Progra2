Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If
        If tipoSeleccionado = True Then
            If CheckBox1.Checked = True Then
                montoCP.Enabled = True
            ElseIf CheckBox2.Checked = True Then
                montoCOB.Enabled = True
            ElseIf CheckBox3.Checked = True Then
                montoEF.Enabled = True
            End If
            If CheckBox1.Checked = False Then
                montoCP.Enabled = False
            ElseIf CheckBox2.Checked = False Then
                montoCOB.Enabled = False
            ElseIf CheckBox3.Checked = False Then
                montoEF.Enabled = False
            End If
        End If

        'Seleccionar opción Ahorro'
        If RadioButton3.Checked = True Then
            Select Case saldo_nuevo
                Case 1.01 To 1000.99
                    interes = 1.5 / 100
                Case 1001 To 5000.99
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100

            End Select
            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text)
            saldo_nuevo = saldo_nuevo + saldo_nuevo * interes
            saldoNuevo.Text = Str(saldo_nuevo)
        End If
        'Seleccionar opción de Monetario Premier'
        If RadioButton2.Checked = True Then
            Select Case Val(saldoAnterior.Text)
                Case 1.01 To 10000.99
                    interes = 2.5 / 100
                Case 10001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100

            End Select
            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text) * interes
        End If
        'Seleccionar opción de Monetario (sin interés)'
        If RadioButton1.Checked = True Then
            saldo_nuevo = Val(montoCP.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoAnterior.Text)
            saldoNuevo.Text = Str(saldo_nuevo)
        End If
        txtinteres.Text = Str(interes * 100) + "%"
    End Sub
    'habilita el campo'
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If
        If tipoSeleccionado = True Then
            If CheckBox1.Checked = True Then
                montoCP.Enabled = True
            End If

            If CheckBox1.Checked = False Then
                montoCP.Enabled = False
            End If
        End If

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If
        If tipoSeleccionado = True Then
            If CheckBox2.Checked = True Then
                montoCOB.Enabled = True
            End If

            If CheckBox2.Checked = False Then
                montoCOB.Enabled = False
            End If
        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If RadioButton1.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tipoSeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tipoSeleccionado = True

        End If
        If tipoSeleccionado = True Then
            If CheckBox3.Checked = True Then
                montoEF.Enabled = True
            End If

            If CheckBox3.Checked = False Then
                montoEF.Enabled = False
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        montoCP.Text = ""
        montoCOB.Text = ""
        montoEF.Text = ""
        saldoAnterior.Text = ""


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Desea salir de la aplicacion", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
