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

    public partial class EditBookWindow : Window
    {
        LibraryViewModel viewModel;
        public EditBookWindow(LibraryViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
        }
        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (editTitleTextBox.Text != string.Empty && editAuthorTextBox.Text != string.Empty && editYearTextBox.Text != string.Empty)
            {                
                viewModel.SelectedBook.Title = editTitleTextBox.Text;
                viewModel.SelectedBook.Author = editAuthorTextBox.Text;
                viewModel.SelectedBook.Year = int.Parse(editYearTextBox.Text);

                Close();
            }
        }
    }
}
