# Binding SelectedItems in Listview

ListView support to select multiple items through binding the [SelectedItems](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectedItems.html) property from view model with ObservableCollection type. Set the [SelectionMode](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~SelectionMode.html) property as `Multiple`.

```
<syncfusion:SfListView x:Name="listView" 
                       SelectedItems="{Binding SelectedItems}"
                       ItemsSource="{Binding BookInfoCollection}"/>
```
```
//ViewModel.cs

public class BookInfoRepository : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private ObservableCollection<object> selectedItems;

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
        SelectedItems = new ObservableCollection<object>();
        SelectedItems.Add(BookInfoCollection[1]);
        SelectedItems.Add(BookInfoCollection[2]);
    }
}
```
To know more about MVVM in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/mvvm)