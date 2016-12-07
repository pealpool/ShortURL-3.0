Imports System.Text.RegularExpressions
Public Class Form1
    Private Const zz1 = "(https|http)(://item\.taobao\.com\/item\.htm\?)"
    Private Const zz2 = "(id\=)\d*"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim yy As Long
        yy = Screen.PrimaryScreen.Bounds.Height.ToString
        Me.Left = 20
        Me.Top = yy - 170
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        WebPc()
        TextBox2.SelectAll()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        WebApp()
        TextBox3.SelectAll()
    End Sub

    Private Sub WebPc()
        Dim m1 As Match = Regex.Match(TextBox1.Text, zz1)
        Dim m2 As Match = Regex.Match(TextBox1.Text, zz2)
        Dim gg1 As Group = m1.Groups(0)
        Dim gg2 As Group = m2.Groups(0)
        If Regex.IsMatch(TextBox1.Text.Trim, zz1） Then
            TextBox2.Text = gg1.ToString() & gg2.ToString()
            Clipboard.Clear()
            Clipboard.SetText(TextBox2.Text)
        Else
            TextBox2.Text = "此处为缩减后的 PC 网址"
        End If
    End Sub

    Private Sub WebApp()
        Dim m2 As Match = Regex.Match(TextBox1.Text, zz2)
        Dim gg2 As Group = m2.Groups(0)
        If Regex.IsMatch(TextBox1.Text.Trim, zz1） Then
            TextBox3.Text = "http://h5.m.taobao.com/awp/core/detail.htm?" & gg2.ToString()
            Clipboard.Clear()
            Clipboard.SetText(TextBox3.Text)
        Else
            TextBox3.Text = "此处为缩减后的 手机 网址"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Or TextBox1.Text = "请粘贴入需要缩减的 淘宝宝贝 网址" Then
            TextBox1.Text = "请粘贴入需要缩减的 淘宝宝贝 网址"
            TextBox1.ForeColor = SystemColors.Highlight
        Else
            TextBox1.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Or TextBox2.Text = "此处为缩减后的 PC 网址" Then
            TextBox2.Text = "此处为缩减后的 PC 网址"
            TextBox2.ForeColor = SystemColors.Highlight
        Else
            TextBox2.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Or TextBox3.Text = "此处为缩减后的 手机 网址" Then
            TextBox3.Text = "此处为缩减后的 手机 网址"
            TextBox3.ForeColor = SystemColors.Highlight
        Else
            TextBox3.ForeColor = SystemColors.WindowText
        End If
    End Sub

End Class
