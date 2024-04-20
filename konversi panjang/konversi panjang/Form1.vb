Public Class Form1
    Sub combo()
        With ComboBox1
            .Items.Add("km")
            .Items.Add("hm")
            .Items.Add("dam")
            .Items.Add("m")
            .Items.Add("dm")
            .Items.Add("cm")
            .Items.Add("mm")
        End With
        With ComboBox2
            .Items.Add("km")
            .Items.Add("hm")
            .Items.Add("dam")
            .Items.Add("m")
            .Items.Add("dm")
            .Items.Add("cm")
            .Items.Add("mm")
        End With
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'dari km ke yang lain'
        If ComboBox1.Text = "km" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text * 10
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text * 100
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text * 1000
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text * 10000
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text * 100000
        ElseIf ComboBox1.Text = "km" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 1000000
        End If
        'dari hm untuk semua'
        If ComboBox1.Text = "hm" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text * 10
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text * 100
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text * 1000
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text * 10000
        ElseIf ComboBox1.Text = "hm" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 100000
        End If
        'dari dam untuk semua'
        If ComboBox1.Text = "dam" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 100
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text * 10
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text * 100
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text * 1000
        ElseIf ComboBox1.Text = "dam" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 10000
        End If
        'dari m untuk semua'
        If ComboBox1.Text = "m" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 1000
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text / 100
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text * 10
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text * 100
        ElseIf ComboBox1.Text = "m" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 1000
        End If
        'dari dm untuk semua' 
        If ComboBox1.Text = "dm" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 10000
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text / 1000
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text / 100
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text * 10
        ElseIf ComboBox1.Text = "dm" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 100
        End If
        'dari cm untuk semua'
        If ComboBox1.Text = "cm" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 100000
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text / 10000
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text / 1000
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text / 100
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text
        ElseIf ComboBox1.Text = "cm" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text * 10
        End If
        'dari mm untuk semua'
        If ComboBox1.Text = "mm" And ComboBox2.Text = "km" Then
            TextBox2.Text = TextBox1.Text / 1000000
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "hm" Then
            TextBox2.Text = TextBox1.Text / 100000
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "dam" Then
            TextBox2.Text = TextBox1.Text / 10000
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "m" Then
            TextBox2.Text = TextBox1.Text / 1000
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "dm" Then
            TextBox2.Text = TextBox1.Text / 100
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "cm" Then
            TextBox2.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "mm" And ComboBox2.Text = "mm" Then
            TextBox2.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo()
    End Sub
End Class
