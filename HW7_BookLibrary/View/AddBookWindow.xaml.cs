using HW7_BookLibrary.Model;
using HW7_BookLibrary.ViewModel;
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
using System.Windows.Shapes;

namespace HW7_BookLibrary.View
{
    public partial class AddBookWindow : Window
    {
        LibraryViewModel viewModel;
        public AddBookWindow(LibraryViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
        }
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (newTitleTextBox.Text != string.Empty && newAuthorTextBox.Text != string.Empty && newYearTextBox.Text != string.Empty)
            {
                BookModel newBook = new BookModel
                {
                    Title = newTitleTextBox.Text,
                    Author = newAuthorTextBox.Text,
                    Year = int.Parse(newYearTextBox.Text)
                };
                viewModel.Books.Add(newBook);

                Close();
            }
        }
    }
}
