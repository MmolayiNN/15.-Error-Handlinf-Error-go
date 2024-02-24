Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim num As Integer
            Dim result As Integer

            ' Attempt to perform the calculation
            On Error GoTo ErrorHandler
            num = Integer.Parse(TextBox1.Text)
            result = num * 2

            ' Display the result
            Label1.Text = "Result: " & result.ToString()
            Exit Sub

ErrorHandler:
            ' Handle any errors that occur during the calculation
            MessageBox.Show("Error: Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub



End Class
