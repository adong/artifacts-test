 'if there's nothing in the listbox, disable the delete button...
 Private Sub Form_Load()
   If (lstTextList.ListCount = 0) Then
     cmdDelete.Enabled = False
   End If
 End Sub
Now, go back to the form design window and double-click the Add button. The code for cmdAdd_click() is as follows:
 Private Sub cmdAdd_Click()
    ' Add the string that is currently in the textBox to the List Box.
    lstTextList.AddItem txtAddText.Text

    ' delete button disabled?  enable it. :)
    If (cmdDelete.Enabled = False) Then
        cmdDelete.Enabled = True
    End If
 End Sub
Once that's done, get the form design and double-click the Delete button. cmdDelete_Click() looks like this:
 ' This method contains the code for the click event for the delete button.
 Private Sub cmdDelete_Click()
     ' if the listbox isn't empty, remove an item ... disable delete button if necessary...
     If (Not (lstTextList.ListCount = 0)) Then
         lstTextList.RemoveItem (lstTextList.ListCount - 1)
         If (lstTextList.ListCount = 0) Then
             cmdDelete.Enabled = False
         End If
     End If
 End Sub
