using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Movie_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection <Movie> movieList = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();
            movieListView.ItemsSource = movieList;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        { 

            Movie submittedMovie = new Movie(titleTextBox.Text, genreTextBox.Text, Double.Parse(reviewScoreTextBox.Text));

            movieList.Add(submittedMovie);
            //submittedMovie.Title = titleTextBox.Text;
            //submittedMovie.Genre = genreTextBox.Text;
            //submittedMovie.ReviewScore = Convert.ToDouble( reviewScoreTextBox.Text);
            //submittedMovie.ReviewScore = Double.Parse(reviewScoreTextBox.Text);

            submittedMovie.DisplayInformation();

            titleTextBox.Clear();
            genreTextBox.Clear();
            reviewScoreTextBox.Clear();

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
