# How to use the editing related events in TreeGridCheckBoxColumn of WinUI TreeGrid (SfTreeGrid)?

The **BeginEdit** and **EndEdit** events are not triggered when you check or uncheck the CheckBox control in [TreeGridCheckBoxColumn](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.TreeGrid.TreeGridCheckBoxColumn.html) in [WinUI TreeGrid](https://www.syncfusion.com/winui-controls/treegrid) (SfTreeGrid). However, you can get the notification while changing the CheckBox state by using the [CurrentCellValueChanged](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid.html#Syncfusion_UI_Xaml_TreeGrid_SfTreeGrid_CurrentCellValueChanged) event.

```C#

//Event subscription
this.sfTreeGrid.CurrentCellValueChanged += OnCurrentCellValueChanged;

//Event customization
private void OnCurrentCellValueChanged(object sender, TreeGridCurrentCellValueChangedEventArgs e)
{
    int columnindex = sfTreeGrid.ResolveToGridVisibleColumnIndex(e.RowColumnIndex.ColumnIndex);

    if (columnindex < 0)
        return;

    var column = sfTreeGrid.Columns[columnindex];

    if (column is TreeGridCheckBoxColumn)
    {
        var recordIndex = sfTreeGrid.ResolveToNodeIndex(e.RowColumnIndex.RowIndex);

        if (recordIndex < 0)
            return;

        TreeNode node = null;

        if (this.sfTreeGrid.View != null)
        {       
            //Get the TreeNode
            node = this.sfTreeGrid.View.Nodes[recordIndex];

            if (node != null)
            {
                //Checkbox property changed value is stored here.
                var value = (node.Item as EmployeeInfo).Availability;
            }
        }
    }
}

```

Take a moment to peruse the [WinUI TreeGrid - Column Types](https://help.syncfusion.com/winui/treegrid/columntypes) documentation, to learn more about column types with code examples.
