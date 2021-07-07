using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Syncfusion.SfDataGrid;

namespace NavigateOnCellTap
{
    public class MyViewController:UIViewController
    {
        SfDataGrid dataGrid;
        ViewModel viewModel;
        public MyViewController()
        {
            dataGrid = new SfDataGrid();
            viewModel = new ViewModel();
            dataGrid.ItemsSource = viewModel.OrdersInfo;
            dataGrid.GridTapped += DataGrid_GridTapped;
            View.AddSubview(dataGrid);
        }

        private void DataGrid_GridTapped(object sender, GridTappedEventsArgs e)
        {
            if(e.RowColumnIndex.RowIndex==1 && e.RowColumnIndex.ColumnIndex==0)
            {
                UIApplication.SharedApplication.OpenUrl(new Foundation.NSUrl("https://help.syncfusion.com/"));
            }
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            dataGrid.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Width, View.Frame.Height);
        }
    }
}