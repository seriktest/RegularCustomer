using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer;

public class Customer
{
    private Shop _shop = new();

    public void OnItemChanged(Shop shop)
    {
        _shop = shop;
        _shop.Items.CollectionChanged += Items_CollectionChanged;
    }

    private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                var list = e.NewItems;
                foreach (var i in list)
                {
                    
                }
                break;
            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine($"Удален товар: {e.OldItems[0]}");
                break;
            default:
                Console.WriteLine("На такое не подписаны");
                break;
        }
    }
}