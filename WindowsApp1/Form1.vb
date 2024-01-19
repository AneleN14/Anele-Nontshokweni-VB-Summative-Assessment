Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            ' Check if the TextBox is not empty
            If Not String.IsNullOrWhiteSpace(txtWord.Text) Then
                ' Check if the word or phrase does not already exist in the ListBox
                If Not lstWords.Items.Contains(txtWord.Text) Then
                    ' Add the word or phrase to the ListBox
                    lstWords.Items.Add(txtWord.Text)
                Else
                    MessageBox.Show("Word already exists in the list.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please enter a word or phrase.", "Empty Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub lstWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWords.SelectedIndexChanged
            ' Display the selected value from ListBox on the Label
            If lstWords.SelectedIndex <> -1 Then
                lblDisplay.Text = lstWords.SelectedItem.ToString()
                lblDisplay.BackColor = Color.White
            End If
        End Sub

        Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbToUpper.CheckedChanged, rbToLower.CheckedChanged, rbPurple.CheckedChanged, rbBlue.CheckedChanged
            ' Change the text in the Label based on the selected RadioButton
            If lstWords.SelectedIndex <> -1 Then
                Dim selectedText As String = lstWords.SelectedItem.ToString()

                If rbToUpper.Checked Then
                    lblDisplay.Text = selectedText.ToUpper()
                ElseIf rbToLower.Checked Then
                    lblDisplay.Text = selectedText.ToLower()
                ElseIf rbPurple.Checked Then
                    lblDisplay.Text = selectedText
                    lblDisplay.ForeColor = Color.Purple
                ElseIf rbBlue.Checked Then
                    lblDisplay.Text = selectedText
                    lblDisplay.ForeColor = Color.Blue
                End If
            End If
        End Sub
    End Class
