Module Module1
    Public vfuncion(8)
    Public vcine(8)
    Public subtotal_a_pagar(8)
    Public vdescuento1(8)
    Public vdescuento2(8)
    Public total_a_pagar(8)
    Public num_entradas

    Public indice = 0

    'variable para retorno de calculo
    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0
    Public calculo_desc2 As Double = 0
    Public subtotal_2 As Double

    Function calcularSubtotal(funcion As String, cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40
                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 44
                End Select

            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select
        End Select



                Return calculo_subtotal
    End Function

    Function calculoDescuento1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then

            calculoDescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculoDescuento1 = 0.015
        End If

        Return calculoDescuento1
    End Function
    Function calculoDescuento2(subtotal_2 As Double) As Double

        If (calculo_subtotal >= 100 And calculo_subtotal <= 300) Then

            calculoDescuento2 = calculo_subtotal * 0.02

        ElseIf (calculo_subtotal >= 301 And calculo_subtotal <= 500) Then

            calculoDescuento2 = calculo_subtotal * 0.04

        ElseIf (calculo_subtotal >= 501 And calculo_subtotal <= 1000) Then

            calculoDescuento2 = calculo_subtotal * 0.06

        End If

        Return calculoDescuento2

    End Function
    Sub Limpiar_Listas()

        Form1.Cine.Items.Clear()
        Form1.Funcion.Items.Clear()
        Form1.SubTotal.Items.Clear()
        Form1.Descuento1.Items.Clear()
        Form1.Descuento2.Items.Clear()
        Form1.Total.Items.Clear()
        Form1.NumEntradas.Items.Clear()


        MsgBox("Se limpiaron las listas, si ya había ingresado datos anteriormente, no fueron borrados", vbExclamation)

    End Sub

    Sub Limpiar_entradas()

        Form1.ComboBox1.SelectedIndex = "-1"
        Form1.ComboBox2.SelectedIndex = "-1"
        Form1.TextBox1.Clear()

    End Sub


End Module
