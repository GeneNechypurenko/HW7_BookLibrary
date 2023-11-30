using HW7_BookLibrary.Model;
using HW7_BookLibrary.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace HW7_BookLibrary.ViewModel
{
    public class LibraryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private ObservableCollection<BookModel> _books;
        private BookModel _selectedBook;
        public ObservableCollection<BookModel> Books
        {
            get => _books;
            set
            {
                if (_books != value)
                {
                    _books = value;
                    OnPropertyChanged(nameof(Books));
                }
            }
        }
        public BookModel SelectedBook
        {
            get => _selectedBook;
            set
            {
                if (_selectedBook != value)
                {
                    _selectedBook = value;
                    OnPropertyChanged(nameof(SelectedBook));
                }
            }
        }
        public LibraryViewModel()
        {
            Books = new ObservableCollection<BookModel>
            {
                new BookModel { Title = "Book1", Author = "Author1", Year = 2020 },
                new BookModel { Title = "Book2", Author = "Author2", Year = 2021 },
            };
        }
    }
}
