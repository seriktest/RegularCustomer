using System.Collections.ObjectModel;

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
        var itemToRemove = Items.SingleOrDefault(x => x.Id == id);
        if(itemToRemove != null)
            Items.Remove(itemToRemove);
    }
}