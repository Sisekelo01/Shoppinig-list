Public Class Form1
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        ListBox1.Items.Add(txtadd.Text)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MsgBox(ListBox1.SelectedItem.ToString)
    End Sub
End Class
