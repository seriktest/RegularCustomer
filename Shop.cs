using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer;

public class Shop
{
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
         _actions.Add(new Item(id, name));
    }

    public void Remove(int id)
    {
        _actions.RemoveAt(id);
    }
}