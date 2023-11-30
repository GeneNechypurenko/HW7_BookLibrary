using HW7_BookLibrary.Model;
using HW7_BookLibrary.View;
using HW7_BookLibrary.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW7_BookLibrary
{
    public partial class MainWindow : Window
    {
        LibraryViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new LibraryViewModel();
            DataContext = viewModel;
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow(viewModel);
            addBookWindow.Owner = this;
            addBookWindow.ShowDialog();
        }

        private void showBookInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (outputListBox.SelectedItem != null)
            {
                viewModel.SelectedBook = (BookModel)outputListBox.SelectedItem;
                MessageBox.Show($"{viewModel.SelectedBook.Title}, {viewModel.SelectedBook.Author}, {viewModel.SelectedBook.Year}");
            }
        }
        private void editBookInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (outputListBox.SelectedItem != null)
            {
                EditBookWindow editBookWindow = new EditBookWindow(viewModel);
                editBookWindow.Owner = this;
                editBookWindow.ShowDialog();
            }
        }
        private void removeBookInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (outputListBox.SelectedItem != null)
            {
                viewModel.Books.Remove((BookModel)outputListBox.SelectedItem);
            }
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(searchTextBox.Text))
            {
                var foundBook = viewModel.Books.FirstOrDefault(book => searchTextBox.Text.Equals(book.Title));

                if (foundBook != null)
                {
                    MessageBox.Show($"Found Book:\n{foundBook.Title}, {foundBook.Author}, {foundBook.Year}");
                }
                else
                {
                    MessageBox.Show("Book not found");
                }
            }
        }
    }
}