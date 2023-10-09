<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btn_start = New Button()
        btn_del = New Button()
        btn_del_all = New Button()
        btn_solve = New Button()
        txt_4 = New TextBox()
        txt_5 = New TextBox()
        txt_6 = New TextBox()
        txt_7 = New TextBox()
        txt_1 = New TextBox()
        txt_2 = New TextBox()
        txt_3 = New TextBox()
        result = New TextBox()
        result_tmp = New TextBox()
        Label1 = New Label()
        btn_sum = New Button()
        btn_substraction = New Button()
        btn_div = New Button()
        btn_multi = New Button()
        n3 = New Button()
        n4 = New Button()
        n2 = New Button()
        n1 = New Button()
        Label2 = New Label()
        timer = New TextBox()
        Label3 = New Label()
        success_count = New TextBox()
        Timer1 = New Timer(components)
        btn_next = New Button()
        SuspendLayout()
        ' 
        ' btn_start
        ' 
        btn_start.BackColor = Color.SeaGreen
        btn_start.Font = New Font("ShureTechMono NFM", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_start.ForeColor = Color.Snow
        btn_start.Location = New Point(643, 132)
        btn_start.Name = "btn_start"
        btn_start.Size = New Size(145, 61)
        btn_start.TabIndex = 0
        btn_start.Text = "Inicio"
        btn_start.UseVisualStyleBackColor = False
        ' 
        ' btn_del
        ' 
        btn_del.BackColor = Color.Goldenrod
        btn_del.Font = New Font("ShureTechMono NFM", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_del.ForeColor = Color.Snow
        btn_del.Location = New Point(643, 199)
        btn_del.Name = "btn_del"
        btn_del.Size = New Size(145, 61)
        btn_del.TabIndex = 1
        btn_del.Text = "Borrar"
        btn_del.UseVisualStyleBackColor = False
        ' 
        ' btn_del_all
        ' 
        btn_del_all.BackColor = Color.Maroon
        btn_del_all.Font = New Font("ShureTechMono NFM", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_del_all.ForeColor = Color.Snow
        btn_del_all.Location = New Point(643, 266)
        btn_del_all.Name = "btn_del_all"
        btn_del_all.Size = New Size(145, 83)
        btn_del_all.TabIndex = 2
        btn_del_all.Text = "Borrar Todo"
        btn_del_all.UseVisualStyleBackColor = False
        ' 
        ' btn_solve
        ' 
        btn_solve.BackColor = Color.MidnightBlue
        btn_solve.Font = New Font("ShureTechMono NFM", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_solve.ForeColor = Color.Snow
        btn_solve.Location = New Point(643, 355)
        btn_solve.Name = "btn_solve"
        btn_solve.Size = New Size(145, 83)
        btn_solve.TabIndex = 3
        btn_solve.Text = "Resolver"
        btn_solve.UseVisualStyleBackColor = False
        ' 
        ' txt_4
        ' 
        txt_4.BackColor = SystemColors.Window
        txt_4.BorderStyle = BorderStyle.FixedSingle
        txt_4.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_4.Location = New Point(195, 12)
        txt_4.Multiline = True
        txt_4.Name = "txt_4"
        txt_4.ReadOnly = True
        txt_4.RightToLeft = RightToLeft.No
        txt_4.Size = New Size(55, 55)
        txt_4.TabIndex = 4
        txt_4.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_5
        ' 
        txt_5.BackColor = SystemColors.Window
        txt_5.BorderStyle = BorderStyle.FixedSingle
        txt_5.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_5.Location = New Point(256, 12)
        txt_5.Multiline = True
        txt_5.Name = "txt_5"
        txt_5.ReadOnly = True
        txt_5.RightToLeft = RightToLeft.No
        txt_5.Size = New Size(55, 55)
        txt_5.TabIndex = 5
        txt_5.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_6
        ' 
        txt_6.BackColor = SystemColors.Window
        txt_6.BorderStyle = BorderStyle.FixedSingle
        txt_6.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_6.Location = New Point(317, 12)
        txt_6.Multiline = True
        txt_6.Name = "txt_6"
        txt_6.ReadOnly = True
        txt_6.RightToLeft = RightToLeft.No
        txt_6.Size = New Size(55, 55)
        txt_6.TabIndex = 6
        txt_6.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_7
        ' 
        txt_7.BackColor = SystemColors.Window
        txt_7.BorderStyle = BorderStyle.FixedSingle
        txt_7.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_7.Location = New Point(378, 12)
        txt_7.Multiline = True
        txt_7.Name = "txt_7"
        txt_7.ReadOnly = True
        txt_7.RightToLeft = RightToLeft.No
        txt_7.Size = New Size(55, 55)
        txt_7.TabIndex = 7
        txt_7.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_1
        ' 
        txt_1.BackColor = SystemColors.Window
        txt_1.BorderStyle = BorderStyle.FixedSingle
        txt_1.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_1.Location = New Point(12, 12)
        txt_1.Multiline = True
        txt_1.Name = "txt_1"
        txt_1.ReadOnly = True
        txt_1.RightToLeft = RightToLeft.No
        txt_1.Size = New Size(55, 55)
        txt_1.TabIndex = 8
        txt_1.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_2
        ' 
        txt_2.BackColor = SystemColors.Window
        txt_2.BorderStyle = BorderStyle.FixedSingle
        txt_2.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_2.Location = New Point(73, 12)
        txt_2.Multiline = True
        txt_2.Name = "txt_2"
        txt_2.ReadOnly = True
        txt_2.RightToLeft = RightToLeft.No
        txt_2.Size = New Size(55, 55)
        txt_2.TabIndex = 9
        txt_2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_3
        ' 
        txt_3.BackColor = SystemColors.Window
        txt_3.BorderStyle = BorderStyle.FixedSingle
        txt_3.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        txt_3.Location = New Point(134, 12)
        txt_3.Multiline = True
        txt_3.Name = "txt_3"
        txt_3.ReadOnly = True
        txt_3.RightToLeft = RightToLeft.No
        txt_3.Size = New Size(55, 55)
        txt_3.TabIndex = 10
        txt_3.TextAlign = HorizontalAlignment.Center
        ' 
        ' result
        ' 
        result.BackColor = SystemColors.Window
        result.BorderStyle = BorderStyle.FixedSingle
        result.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        result.Location = New Point(475, 12)
        result.Multiline = True
        result.Name = "result"
        result.ReadOnly = True
        result.RightToLeft = RightToLeft.No
        result.Size = New Size(93, 55)
        result.TabIndex = 11
        result.TextAlign = HorizontalAlignment.Center
        ' 
        ' result_tmp
        ' 
        result_tmp.BackColor = SystemColors.Window
        result_tmp.BorderStyle = BorderStyle.FixedSingle
        result_tmp.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        result_tmp.Location = New Point(475, 73)
        result_tmp.Multiline = True
        result_tmp.Name = "result_tmp"
        result_tmp.ReadOnly = True
        result_tmp.RightToLeft = RightToLeft.No
        result_tmp.Size = New Size(93, 55)
        result_tmp.TabIndex = 12
        result_tmp.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(439, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(33, 36)
        Label1.TabIndex = 13
        Label1.Text = "="
        ' 
        ' btn_sum
        ' 
        btn_sum.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_sum.Location = New Point(102, 138)
        btn_sum.Name = "btn_sum"
        btn_sum.Size = New Size(55, 55)
        btn_sum.TabIndex = 14
        btn_sum.Text = "+"
        btn_sum.UseVisualStyleBackColor = True
        ' 
        ' btn_substraction
        ' 
        btn_substraction.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_substraction.Location = New Point(163, 138)
        btn_substraction.Name = "btn_substraction"
        btn_substraction.Size = New Size(55, 55)
        btn_substraction.TabIndex = 15
        btn_substraction.Text = "-"
        btn_substraction.UseVisualStyleBackColor = True
        ' 
        ' btn_div
        ' 
        btn_div.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_div.Location = New Point(285, 138)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(55, 55)
        btn_div.TabIndex = 16
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = True
        ' 
        ' btn_multi
        ' 
        btn_multi.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_multi.Location = New Point(224, 138)
        btn_multi.Name = "btn_multi"
        btn_multi.Size = New Size(55, 55)
        btn_multi.TabIndex = 17
        btn_multi.Text = "x"
        btn_multi.UseVisualStyleBackColor = True
        ' 
        ' n3
        ' 
        n3.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        n3.Location = New Point(224, 77)
        n3.Name = "n3"
        n3.Size = New Size(55, 55)
        n3.TabIndex = 21
        n3.Text = ChrW(55358) & ChrW(56609)
        n3.UseVisualStyleBackColor = True
        ' 
        ' n4
        ' 
        n4.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        n4.Location = New Point(285, 77)
        n4.Name = "n4"
        n4.Size = New Size(55, 55)
        n4.TabIndex = 20
        n4.Text = ChrW(55358) & ChrW(56609)
        n4.UseVisualStyleBackColor = True
        ' 
        ' n2
        ' 
        n2.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        n2.Location = New Point(163, 77)
        n2.Name = "n2"
        n2.Size = New Size(55, 55)
        n2.TabIndex = 19
        n2.Text = ChrW(55358) & ChrW(56609)
        n2.UseVisualStyleBackColor = True
        ' 
        ' n1
        ' 
        n1.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Bold, GraphicsUnit.Point)
        n1.Location = New Point(102, 77)
        n1.Name = "n1"
        n1.Size = New Size(55, 55)
        n1.TabIndex = 18
        n1.Text = ChrW(55358) & ChrW(56609)
        n1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(616, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 28)
        Label2.TabIndex = 23
        Label2.Text = "Tiempo"
        ' 
        ' timer
        ' 
        timer.BackColor = SystemColors.Window
        timer.BorderStyle = BorderStyle.FixedSingle
        timer.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        timer.Location = New Point(718, 12)
        timer.Multiline = True
        timer.Name = "timer"
        timer.ReadOnly = True
        timer.RightToLeft = RightToLeft.No
        timer.Size = New Size(70, 36)
        timer.TabIndex = 22
        timer.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("ShureTechMono NFM", 18.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(574, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 28)
        Label3.TabIndex = 25
        Label3.Text = "Resueltos"
        ' 
        ' success_count
        ' 
        success_count.BackColor = SystemColors.Window
        success_count.BorderStyle = BorderStyle.FixedSingle
        success_count.Font = New Font("ShureTechMono NFM", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        success_count.Location = New Point(718, 58)
        success_count.Multiline = True
        success_count.Name = "success_count"
        success_count.ReadOnly = True
        success_count.RightToLeft = RightToLeft.No
        success_count.Size = New Size(70, 36)
        success_count.TabIndex = 24
        success_count.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' btn_next
        ' 
        btn_next.BackColor = Color.SeaGreen
        btn_next.Font = New Font("ShureTechMono NFM", 19.0F, FontStyle.Bold, GraphicsUnit.Point)
        btn_next.ForeColor = Color.Snow
        btn_next.Location = New Point(166, 277)
        btn_next.Name = "btn_next"
        btn_next.Size = New Size(174, 72)
        btn_next.TabIndex = 26
        btn_next.Text = "Siguiente"
        btn_next.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_next)
        Controls.Add(Label3)
        Controls.Add(success_count)
        Controls.Add(Label2)
        Controls.Add(timer)
        Controls.Add(n3)
        Controls.Add(n4)
        Controls.Add(n2)
        Controls.Add(n1)
        Controls.Add(btn_multi)
        Controls.Add(btn_div)
        Controls.Add(btn_substraction)
        Controls.Add(btn_sum)
        Controls.Add(Label1)
        Controls.Add(result_tmp)
        Controls.Add(result)
        Controls.Add(txt_3)
        Controls.Add(txt_2)
        Controls.Add(txt_1)
        Controls.Add(txt_7)
        Controls.Add(txt_6)
        Controls.Add(txt_5)
        Controls.Add(txt_4)
        Controls.Add(btn_solve)
        Controls.Add(btn_del_all)
        Controls.Add(btn_del)
        Controls.Add(btn_start)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_del_all As Button
    Friend WithEvents btn_solve As Button
    Friend WithEvents txt_4 As TextBox
    Friend WithEvents txt_5 As TextBox
    Friend WithEvents txt_6 As TextBox
    Friend WithEvents txt_7 As TextBox
    Friend WithEvents txt_1 As TextBox
    Friend WithEvents txt_2 As TextBox
    Friend WithEvents txt_3 As TextBox
    Friend WithEvents result As TextBox
    Friend WithEvents result_tmp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_sum As Button
    Friend WithEvents btn_substraction As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_multi As Button
    Friend WithEvents n3 As Button
    Friend WithEvents n4 As Button
    Friend WithEvents n2 As Button
    Friend WithEvents n1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents timer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents success_count As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_next As Button
End Class
