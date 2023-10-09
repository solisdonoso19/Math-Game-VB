Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private count_timer As Integer
    Dim random As New Random()
    Dim operation(6) As Object
    Dim operation_ans(6) As Object
    Dim btn_disable(6) As Object
    Dim position As Integer = 0
    Dim is_n1_disabled As Boolean = False
    Dim is_n2_disabled As Boolean = False
    Dim is_n3_disabled As Boolean = False
    Dim is_n4_disabled As Boolean = False
    Dim wins As Integer = 0

    'Clase calculadora
    Dim calc As New Calculator()
    'Funcion que se ejecuta al iniciar el programa
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable_operators()
        disable_numbers()
        success_count.Text = wins.ToString()
        btn_next.Visible = False
        btn_del.Enabled = False
        btn_del_all.Enabled = False
        btn_solve.Enabled = False
    End Sub

    Sub disable_init()
        btn_start.Enabled = True
        btn_del.Enabled = False
        btn_del_all.Enabled = False
        btn_solve.Enabled = False

    End Sub
    Private Sub timer_TextChanged(sender As Object, e As EventArgs) Handles timer.TextChanged

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        'Iniciando el temporizador

        txt_1.Text = Nothing
        txt_2.Text = Nothing
        txt_3.Text = Nothing
        txt_4.Text = Nothing
        txt_5.Text = Nothing
        txt_6.Text = Nothing
        txt_7.Text = Nothing

        count_timer = 60
        timer.Text = count_timer.ToString()
        Timer1.Start()

        ' Numeros Ramdon
        Dim n1_rnd As Integer = random.Next(1, 9)
        Dim n2_rnd As Integer = random.Next(1, 9)
        Dim n3_rnd As Integer = random.Next(1, 9)
        Dim n4_rnd As Integer = random.Next(1, 9)
        n1.Text = n1_rnd
        n2.Text = n2_rnd
        n3.Text = n3_rnd
        n4.Text = n4_rnd
        btn_start.Enabled = False

        generate_answer(n1_rnd, n2_rnd, n3_rnd, n4_rnd)

        btn_del.Enabled = True
        btn_del_all.Enabled = True
        btn_solve.Enabled = True
        enable_numbers()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If count_timer > 0 Then
            count_timer -= 1 ' Disminuir el contador
            timer.Text = count_timer.ToString() ' Actualizar el TextBox con el nuevo valor
        Else
            Timer1.Stop() ' Detener el temporizador si el contador llega a cero
            Dim message As String = "Juego Terminado" & vbCrLf & "Total de aciertos: " & wins.ToString()
            MessageBox.Show(message)
            restart()
        End If
    End Sub

    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        btn_disable(position) = "n1"
        assign_values(Integer.Parse(n1.Text))
        disable_numbers()
        enable_operators()
        n1.Enabled = False
        is_n1_disabled = True

    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        btn_disable(position) = "n2"
        assign_values(Integer.Parse(n2.Text))
        disable_numbers()
        enable_operators()
        n2.Enabled = False
        is_n2_disabled = True

    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        btn_disable(position) = "n3"
        assign_values(Integer.Parse(n3.Text))
        disable_numbers()
        enable_operators()
        n3.Enabled = False
        is_n3_disabled = True

    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        btn_disable(position) = "n4"
        assign_values(Integer.Parse(n4.Text))
        disable_numbers()
        enable_operators()
        n4.Enabled = False
        is_n4_disabled = True

    End Sub
    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        btn_disable(position) = "+"
        assign_values("+")
        disable_operators()
        enable_numbers()
    End Sub

    Private Sub btn_substraction_Click(sender As Object, e As EventArgs) Handles btn_substraction.Click
        btn_disable(position) = "-"
        assign_values("-")
        disable_operators()
        enable_numbers()

    End Sub

    Private Sub btn_multi_Click(sender As Object, e As EventArgs) Handles btn_multi.Click
        btn_disable(position) = "*"
        assign_values("*")
        disable_operators()
        enable_numbers()

    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        btn_disable(position) = "/"
        assign_values("/")
        disable_operators()
        enable_numbers()

    End Sub

    'Funcion que asigna los valores a los text box de la operacion
    Sub assign_values(n As Object)
        operation(position) = n
        position += 1

        txt_1.Text = operation(0)
        txt_2.Text = operation(1)
        txt_3.Text = operation(2)
        txt_4.Text = operation(3)
        txt_5.Text = operation(4)
        txt_6.Text = operation(5)
        txt_7.Text = operation(6)

        If position Mod 2 <> 0 And position > 2 Then
            get_parcial_calc()

        End If
    End Sub



    ' Funcion que deshabilita las operaciones
    Sub disable_operators()
        btn_sum.Enabled = False
        btn_substraction.Enabled = False
        btn_multi.Enabled = False
        btn_div.Enabled = False
    End Sub
    ' Funcion que deshabilita los numeros
    Sub disable_numbers()
        n1.Enabled = False
        n2.Enabled = False
        n3.Enabled = False
        n4.Enabled = False
    End Sub
    ' Funcion que habilita las operaciones
    Sub enable_operators()
        btn_sum.Enabled = True
        btn_substraction.Enabled = True
        btn_multi.Enabled = True
        btn_div.Enabled = True
    End Sub
    ' Funcion que habilita los numeros
    Sub enable_numbers()
        If is_n1_disabled = False Then
            n1.Enabled = True
        End If
        If is_n2_disabled = False Then
            n2.Enabled = True
        End If
        If is_n3_disabled = False Then
            n3.Enabled = True
        End If
        If is_n4_disabled = False Then
            n4.Enabled = True
        End If
    End Sub
    'Funcion que genera la respuesta
    Sub generate_answer(n1_rnd As Integer, n2_rnd As Integer, n3_rnd As Integer, n4_rnd As Integer)
        Dim numbers As Integer() = {n1_rnd, n2_rnd, n3_rnd, n4_rnd}
        Dim operators As String() = {"+", "-", "*", "/"}
        Dim secuencia As New List(Of Object)()

        While numbers.Length > 0
            ' Selecciona un número al azar y agrégalo a la secuencia
            Dim indiceNumero As Integer = random.Next(0, numbers.Length)
            secuencia.Add(numbers(indiceNumero))
            ' Elimina el número seleccionado para evitar repeticiones
            numbers = numbers.Where(Function(n, i) i <> indiceNumero).ToArray()

            ' Si aún quedan números, selecciona un operador al azar y agrégalo a la secuencia
            If numbers.Length > 0 Then
                Dim indiceOperador As Integer = random.Next(0, operators.Length)
                secuencia.Add(operators(indiceOperador))
            End If
        End While
        operation_ans = secuencia.ToArray()
        For Each e As Object In operation_ans
            Debug.WriteLine(e)
        Next
        get_calc()
    End Sub
    'Funciones que calculan el resultado
    Sub get_calc()
        Dim resultado As Integer = operation_ans(0)

        For i As Integer = 1 To operation_ans.Length - 1 Step 2

            Dim operador As String = DirectCast(operation_ans(i), String)
            Dim numero As Integer = operation_ans(i + 1)

            Select Case operador
                Case "+"
                    resultado = calc.Sum(resultado, numero)
                Case "-"
                    resultado = calc.Substraction(resultado, numero)
                Case "*"
                    resultado = calc.Multi(resultado, numero)
                Case "/"
                    If numero <> 0 Then
                        resultado = calc.Division(resultado, numero)
                    Else
                        Debug.WriteLine("Error: División por cero")
                        Exit For
                    End If
            End Select
        Next
        result.Text = resultado.ToString()

    End Sub

    Sub get_parcial_calc()
        Dim resultado As Integer = operation(0)

        For i As Integer = 1 To operation.Length - 1 Step 2
            Dim operador As String = DirectCast(operation(i), String)
            Dim numero As Integer = operation(i + 1)



            Select Case operador
                Case "+"
                    resultado = calc.Sum(resultado, numero)
                Case "-"
                    resultado = calc.Substraction(resultado, numero)
                Case "*"
                    resultado = calc.Multi(resultado, numero)
                Case "/"
                    If numero <> 0 Then
                        resultado = calc.Division(resultado, numero)
                    Else

                        show_error()
                        Exit For
                    End If
            End Select
        Next
        result_tmp.Text = resultado.ToString()
        If position = 7 Then
            If result_tmp.Text = result.Text Then
                Timer1.Stop()
                wins += 1
                success_count.Text = wins.ToString()
                btn_next.Visible = True
                count_timer += 40
            End If
        End If
    End Sub

    Private Sub btn_solve_Click(sender As Object, e As EventArgs) Handles btn_solve.Click
        txt_1.Text = operation_ans(0)
        txt_2.Text = operation_ans(1)
        txt_3.Text = operation_ans(2)
        txt_4.Text = operation_ans(3)
        txt_5.Text = operation_ans(4)
        txt_6.Text = operation_ans(5)
        txt_7.Text = operation_ans(6)
        Timer1.Stop()
        disable_init()
        btn_start.Enabled = False
        btn_next.Visible = True
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        position -= 1
        operation(position) = Nothing

        If btn_disable(position) = "n1" Then
            is_n1_disabled = False
        ElseIf btn_disable(position) = "n2" Then
            is_n2_disabled = False
        ElseIf btn_disable(position) = "n3" Then
            is_n3_disabled = False
        ElseIf btn_disable(position) = "n4" Then
            is_n4_disabled = False
        End If

        If position Mod 2 = 0 Then
            disable_operators()
            enable_numbers()
        Else
            disable_numbers()
            enable_operators()
        End If

        txt_1.Text = operation(0)
        txt_2.Text = operation(1)
        txt_3.Text = operation(2)
        txt_4.Text = operation(3)
        txt_5.Text = operation(4)
        txt_6.Text = operation(5)
        txt_7.Text = operation(6)
        get_parcial_calc()
    End Sub
    Private Sub btn_del_all_Click(sender As Object, e As EventArgs) Handles btn_del_all.Click
        txt_1.Text = Nothing
        txt_2.Text = Nothing
        txt_3.Text = Nothing
        txt_4.Text = Nothing
        txt_5.Text = Nothing
        txt_6.Text = Nothing
        txt_7.Text = Nothing

        is_n1_disabled = False
        is_n2_disabled = False
        is_n3_disabled = False
        is_n4_disabled = False

        disable_operators()
        enable_numbers()
        result_tmp.Text = "0"
        operation = New Object(6) {}
        position = 0
    End Sub
    Sub show_error()
        MessageBox.Show("No se admite division entre cero")
    End Sub

    Private Sub Btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        txt_1.Text = Nothing
        txt_2.Text = Nothing
        txt_3.Text = Nothing
        txt_4.Text = Nothing
        txt_5.Text = Nothing
        txt_6.Text = Nothing
        txt_7.Text = Nothing

        ' Numeros Ramdon
        Dim n1_rnd As Integer = random.Next(1, 9)
        Dim n2_rnd As Integer = random.Next(1, 9)
        Dim n3_rnd As Integer = random.Next(1, 9)
        Dim n4_rnd As Integer = random.Next(1, 9)
        n1.Text = n1_rnd
        n2.Text = n2_rnd
        n3.Text = n3_rnd
        n4.Text = n4_rnd
        btn_start.Enabled = False

        generate_answer(n1_rnd, n2_rnd, n3_rnd, n4_rnd)

        btn_del.Enabled = True
        btn_del_all.Enabled = True
        btn_solve.Enabled = True
        btn_next.Visible = False

        result_tmp.Text = "0"
        is_n1_disabled = False
        is_n2_disabled = False
        is_n3_disabled = False
        is_n4_disabled = False
        enable_numbers()
        disable_operators()
        operation = New Object(6) {}
        position = 0

        Timer1.Start()
    End Sub

    Sub restart()
        txt_1.Text = Nothing
        txt_2.Text = Nothing
        txt_3.Text = Nothing
        txt_4.Text = Nothing
        txt_5.Text = Nothing
        txt_6.Text = Nothing
        txt_7.Text = Nothing

        n1.Text = 0
        n2.Text = 0
        n3.Text = 0
        n4.Text = 0
        btn_start.Enabled = True


        btn_del.Enabled = False
        btn_del_all.Enabled = False
        btn_solve.Enabled = False
        btn_next.Visible = False
        btn_start.Enabled = True


        result_tmp.Text = "0"
        is_n1_disabled = False
        is_n2_disabled = False
        is_n3_disabled = False
        is_n4_disabled = False
        disable_numbers()
        disable_operators()
        operation = New Object(6) {}
        operation_ans = New Object(6) {}
        position = 0
    End Sub
End Class
