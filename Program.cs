
using RegularCustomer;

var shop = new Shop();
var customer = new Customer();

shop.Add(1, "Товар1");
shop.Add(2, "Товар2");
shop.Add(3, "Товар3");
shop.Add(4, "Товар4");
shop.Add(5, "Товар5");

customer.OnItemChanged(shop);
