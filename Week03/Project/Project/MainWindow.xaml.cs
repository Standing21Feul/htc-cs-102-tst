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
        public MainWindow()
        {
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

            // Add the first text cell to the Grid
            TextBlock txt1 = new TextBlock();
            txt1.Background = Brushes.Black;
            Grid.SetRow(txt1, 0);
            Grid.SetColumn(txt1, 0);

            // Add the second text cell to the Grid
            TextBlock txt2 = new TextBlock();
            txt2.Background = Brushes.Black;
            Grid.SetRow(txt2, 1);
            Grid.SetColumn(txt2, 0);

            // Add the third text cell to the Grid
            TextBlock txt3 = new TextBlock();
            txt3.Background = Brushes.Black;
            Grid.SetRow(txt3, 2);
            Grid.SetColumn(txt3, 0);

            // Add the fourth text cell to the Grid
            TextBlock txt4 = new TextBlock();
            txt4.Background = Brushes.Black;
            Grid.SetRow(txt4, 3);
            Grid.SetColumn(txt4, 0);

            // Add the sixth text cell to the Grid
            TextBlock txt5 = new TextBlock();
            txt5.Background = Brushes.Black;
            Grid.SetRow(txt5, 4);
            Grid.SetColumn(txt5, 0);

            // Add the seventh text cell to the Grid
            TextBlock txt6 = new TextBlock();
            txt6.Background = Brushes.Black;
            Grid.SetRow(txt6, 5);
            Grid.SetColumn(txt6, 0);

            // Add the final text cell to the Grid
            TextBlock txt7 = new TextBlock();
            txt7.Background = Brushes.Black;
            Grid.SetRow(txt7, 6);
            Grid.SetColumn(txt7, 0);

            TextBlock txt8 = new TextBlock();
            txt8.Background = Brushes.Black;
            Grid.SetRow(txt8, 7);
            Grid.SetColumn(txt8, 0);

            TextBlock txt9 = new TextBlock();
            txt9.Background = Brushes.Black;
            Grid.SetRow(txt9, 8);
            Grid.SetColumn(txt9, 0);

            // Total all Data and Span Three Columns


            // Add the TextBlock elements to the Grid Children collection
            myGrid.Children.Add(txt1);
            myGrid.Children.Add(txt2);
            myGrid.Children.Add(txt3);
            myGrid.Children.Add(txt4);
            myGrid.Children.Add(txt5);
            myGrid.Children.Add(txt6);
            myGrid.Children.Add(txt7);
            myGrid.Children.Add(txt8);

            List<List<TextBlock>> myLIst = new List<List<TextBlock>>();
            myLIst[3][6].Background = Brushes.Black;


        }
    }
}
