using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer;

public class Customer
{
    private Shop _shop = new();

    public void OnItemChanged( Shop shop)
    {
        _shop = shop;
        _shop.Items.CollectionChanged += Items_CollectionChanged;
    }

    private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                var item = e.NewItems;
                foreach (var i in item) 
                {
                    Console.WriteLine($"Добавлен товар: {i}"); 
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