using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer;

public class Shop
{
    private List<Item> _items = new();
    private readonly ObservableCollection<Item> _actions = new();

    public Shop()
    {
        _actions.CollectionChanged += ItemsChanged;
    }

    private void ItemsChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine($"Добавлен новый товар {e.NewItems}");
                break;
            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine($"Удален товар {e.OldItems}");
                break;
        }
        
    }

    public void Add(int id, string name)
    {
         _items.Add(new Item(id, name));
    }

    public void Remove(int id)
    {
        _items.RemoveAt(id);
    }
}