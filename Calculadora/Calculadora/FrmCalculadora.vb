﻿Public Class FrmCalculadora

    Sub efectuo(operacion As String)
        Dim num1, num2, resultado As Double 'Decimal mas grande en visual basic
        Dim operok As Boolean = True
        num1 = numero(txtNum1.Text)
        num2 = numero(txtNum2.Text)
        txtNum1.Text = num1 'Cambia o no la caja de texto al valor q utilizo para hacer la operacion (1.1 a 11)
        txtNum2.Text = num2 ' igual
        Select Case operacion
            Case "+"
                resultado = num1 + num2
            Case "-"
                resultado = num1 - num2
            Case "*"
                resultado = num1 * num2
            Case "/"
                If num2 <> 0 Then
                    resultado = num1 / num2
                Else
                    operok = False
                End If
        End Select
        If operok = False Then
            lblResultado.Text = "Error"
        Else
            lblResultado.Text = resultado 'Muestro el resultado
        End If
    End Sub
    Function numero(ByVal valor As String) As Double
        Dim retorno As Double
        If IsNumeric(valor) Then
            retorno = valor
        Else
            retorno = 0
        End If
        Return (retorno)
    End Function


    Private Sub cmdResta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResta.Click
        efectuo("-")
    End Sub

    Private Sub cmdMultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiplicacion.Click
        efectuo("*")
    End Sub

    Private Sub cmdDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivision.Click
        efectuo("/")
    End Sub

    Private Sub cmdSuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuma.Click
        efectuo("+")
    End Sub
End Class
