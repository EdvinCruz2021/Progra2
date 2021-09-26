Public Class Form1
    Private Sub Check_Efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Efectivo.CheckedChanged
        If (Check_Efectivo.Checked = "True") Then

            txt_efec.Enabled = True


        Else
            txt_efec.Enabled = False
            txt_efec.Text = ""

        End If
    End Sub

    Private Sub Check_Tarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Tarjeta.CheckedChanged
        If (Check_Tarjeta.Checked = "True") Then

            txt_tarjeta.Enabled = True


        Else
            txt_tarjeta.Enabled = False
            txt_tarjeta.Text = ""

        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        If (txt_nit.Text = "") Then

            MsgBox("Ingrese su NIT por favor", vbQuestion)

            Exit Sub

            txt_nit.Focus()
        End If

        If (combo_Marca.Text = "") Then

            MsgBox("Seleccione la marca de vehículo por favor", vbQuestion)


            Exit Sub

            txt_nit.Focus()
        End If
        If (txt_placa.Text = "") Then

            MsgBox("Ingrese su placa por favor", vbQuestion)

            Exit Sub
            txt_placa.Focus()
        End If

        If (txt_dia.Text = "") Then

            MsgBox("Ingrese los días que alquilara el vehículo por favor", vbQuestion)

            Exit Sub

            txt_dia.Focus()

        End If
        If (indice < 6) Then

            Nit(indice) = txt_nit.Text
            Placa(indice) = txt_placa.Text
            Marca(indice) = combo_Marca.SelectedItem
            Dias(indice) = txt_dia.Text

            Parcial(indice) = calcularparcial(Parcial(indice))


            If Check_Efectivo.Checked = True And Check_Tarjeta.Checked = False Then

                If Val(txt_efec.Text) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub

                ElseIf Val(txt_efec.Text) = 100 Then

                    MsgBox("Descuento aplicado por pagar en efectivo del 5%")

                    Descuento(indice) = calcularparcial(PagoParcial) * 0.05
                    Total(indice) = Math.Round((PagoParcial - Descuento(indice)), 2)

                End If

            End If

            If Check_Efectivo.Checked = False And Check_Tarjeta.Checked = True Then

                If Val(txt_tarjeta.Text) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub

                ElseIf Val(txt_tarjeta.Text) = 100 Then

                    MsgBox("Recargo aplicado por pagar con tarjeta del 2.5%")

                    Descuento(indice) = calcularparcial(PagoParcial) * 0.025
                    Total(indice) = Math.Round((PagoParcial + Descuento(indice)), 2)

                End If
            End If

            If Check_Efectivo.Checked = True And Check_Tarjeta.Checked = True Then

                If (Val(txt_tarjeta.Text) + Val(txt_efec.Text)) <> 100 Then

                    MsgBox("Error el pago no puede ser procesado si no inserta el 100% de su pago a realizar")

                    Exit Sub
                End If

                If (Val(txt_tarjeta.Text) + Val(txt_efec.Text)) = 100 Then

                    Descuento(indice) = 0
                    Total(indice) = Math.Round(calcularparcial(PagoParcial), 2)

                End If

            End If
            mostrar_resultado()
            indice = indice + 1
        End If

        If (indice >= 6) Then

            MsgBox("Limite de 6 ingresos alcanzado", vbExclamation, Title:="Sistema dice:")
        End If

    End Sub


    Public Function calcularparcial(ByRef PagoParcial As Double) As Double

        If combo_Marca.Text = "Honda" Then

            PagoParcial = Honda_dia * Val(txt_dia.Text)

        ElseIf combo_Marca.Text = "Mercedes Benz" Then

            PagoParcial = Mercedes_dia * Val(txt_dia.Text)

        ElseIf combo_Marca.Text = "Toyota" Then

            PagoParcial = Toyota_dia * Val(txt_dia.Text)

        ElseIf combo_Marca.Text = "Mazda" Then
            PagoParcial = Mazda_dia * Val(txt_dia.Text)
        End If

        Return PagoParcial

    End Function

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        Limpiar_entradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Limpiar_vectores()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        Limpiar_Listas()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
