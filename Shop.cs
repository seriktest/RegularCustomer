using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer;

public class Shop
{
    public readonly ObservableCollection<Item> Items = new();
    
    public void Add(int id, string name)
    {
         Items.Add(new Item(id, name));
    }

    public void Remove(int id)
    {
       
    }
}