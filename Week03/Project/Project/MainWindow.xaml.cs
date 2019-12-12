using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<List<TextBlock>> myLIst = new List<List<TextBlock>>();
        public Apple AP;
        public MainWindow()
        {
            AP = new Apple();
            AP.Row = 2;
            AP.Column = 3;

            InitializeComponent();
            myGrid.Width = 1300;
            myGrid.Height = 1000;
            myGrid.HorizontalAlignment = HorizontalAlignment.Left;
            myGrid.VerticalAlignment = VerticalAlignment.Top;
            myGrid.ShowGridLines = true;

            // Define the Columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7= new ColumnDefinition();
            ColumnDefinition colDef8 = new ColumnDefinition();
            ColumnDefinition colDef9 = new ColumnDefinition();
            ColumnDefinition colDef10 = new ColumnDefinition();
            myGrid.ColumnDefinitions.Add(colDef1);
            myGrid.ColumnDefinitions.Add(colDef2);
            myGrid.ColumnDefinitions.Add(colDef3);
            myGrid.ColumnDefinitions.Add(colDef4);
            myGrid.ColumnDefinitions.Add(colDef5);
            myGrid.ColumnDefinitions.Add(colDef6);
            myGrid.ColumnDefinitions.Add(colDef7);
            myGrid.ColumnDefinitions.Add(colDef8);
            myGrid.ColumnDefinitions.Add(colDef9);
            myGrid.ColumnDefinitions.Add(colDef10);

            // Define the Rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            RowDefinition rowDef6 = new RowDefinition();
            RowDefinition rowDef7 = new RowDefinition();
            RowDefinition rowDef8 = new RowDefinition();
            myGrid.RowDefinitions.Add(rowDef1);
            myGrid.RowDefinitions.Add(rowDef2);
            myGrid.RowDefinitions.Add(rowDef3);
            myGrid.RowDefinitions.Add(rowDef4);
            myGrid.RowDefinitions.Add(rowDef5);
            myGrid.RowDefinitions.Add(rowDef6);
            myGrid.RowDefinitions.Add(rowDef7);
            myGrid.RowDefinitions.Add(rowDef8);

            for (int i = 0; i < 8; i++)
            {
                myLIst.Add(new List<TextBlock>());
                for (int j = 0; j < 10; j++)
                {
                    TextBlock txt = new TextBlock();
                    txt.Background = Brushes.Black;
                    Grid.SetRow(txt, i);
                    Grid.SetColumn(txt, j);
                    myLIst[i].Add(txt);
                    myGrid.Children.Add(txt);
                }
            }
            myLIst[AP.Row][AP.Column].Background = Brushes.Red;

            


        }
        public void Click(int Row, int Column)
        {

        }
    }
}
