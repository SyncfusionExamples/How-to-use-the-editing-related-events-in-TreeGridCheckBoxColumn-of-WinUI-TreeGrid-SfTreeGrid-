// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.UI.Xaml;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.DataGrid;
using Syncfusion.UI.Xaml.TreeGrid;
using System.Reflection;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SfTreeGridDemo
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //Event subscription
            this.sfTreeGrid.CurrentCellValueChanged += OnCurrentCellValueChanged;
        }

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
    }
}