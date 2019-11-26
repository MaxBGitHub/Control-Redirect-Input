Control-Redirect-Input
======================

Redirect PreviewKeyDownEventArgs and MouseEventArg values to a DataGridView

## Description
By redirecting the PreviewKeyDownEventArgs and redirecting the values of 
the MouseEventArgs you can ensure scrolling and Up/Down/PageUp/PageDown/ etc.
functionality for the DataGridView no matter which control has focus.

This can be usefull e.g. if you still want to scroll the DataGridView while 
editing a filter input in a TextBox.


## References

* System.Windows.Forms
* System.Reflection


## Implementation

Add the code to the desired System.Windows.Forms.Form and change the name 
of **dataGridView1** to the name of your own DataGridView.


## Built With 
[Visual Studio 2017](https://visualstudio.microsoft.com)
