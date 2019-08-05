using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class BookInfoRepository : INotifyPropertyChanged
    {
        private ObservableCollection<BookInfo> bookInfoCollection;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<object> selectedItems;

        public ObservableCollection<BookInfo> BookInfoCollection
        {
            get { return bookInfoCollection; }
            set
            {
                this.bookInfoCollection = value;
                this.OnPropertyChanged("BookInfoCollection");
            }
        }

        public ObservableCollection<object> SelectedItems
        {
            get { return this.selectedItems; }
            set
            {
                this.selectedItems = value;
                this.OnPropertyChanged("SelectedItems");
            }
        }

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public BookInfoRepository()
        {
            GenerateNewBookInfo();
            SelectedItems = new ObservableCollection<object>();
            SelectedItems.Add(BookInfoCollection[1]);
            SelectedItems.Add(BookInfoCollection[2]);
        }

        private void GenerateNewBookInfo()
        {
            BookInfoCollection = new ObservableCollection<BookInfo>();
            BookInfoCollection.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            BookInfoCollection.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm" });
            BookInfoCollection.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions" });
        }
    }
}
