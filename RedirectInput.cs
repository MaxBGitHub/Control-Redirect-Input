// Handler to redirect a Keys enum value to a DataGridView.
// Up/Down/PageUp/PageDown /etc. functionality 
// of DataGridView is preserved due to this handler.
void Control_RedirectKey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
{
	// Create KeyEventArgs which can be processed
	// by the ProcessDataGridViewKey method.
	// Use e.KeyCode if you wish to ignore Control keys.
	KeyEventArgs kevent = new KeyEventArgs(e.KeyData);
	dataGridView1.GetType()
		.GetMethod("ProcessDataGridViewKey",
			BindingFlags.NonPublic
			| BindingFlags.Instance)
		.Invoke(dataGridView1, new object[] { kevent });
}

// Handler to redirect mouse wheel scroll to a DataGridView.
// Bind to Form.MouseWheel to always scroll the DataGridView.
void Control_RedirectScroll_MouseWheel(object sender, MouseEventArgs e) 
{
	// No Mouse Wheel action
	if (e.Delta == 0) return;
	
	// VerticalOffset property of DataGridView which has private setter;
	var vOffsProp = dataGridView1.GetType()
		.GetProperty("VerticalOffset", 
			BindingFlags.NonPublic
			| BindingFlags.Instance);

	// New offset value
	int offset = dataGridView1.VerticalScrollingOffset + (e.Delta * -1);
	// Set value of property
	vOffsProp.SetValue(
		dataGridView1,
		offset, 
		null);
	
}
