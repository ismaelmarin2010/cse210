using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Donald J. Trump", "White House street", "Washington", "DC", "USA");
        Order order1Customer1 = new Order(customer1);
        order1Customer1.AddProduct("Laptop", 101, 1999.99f, 20);
        order1Customer1.AddProduct("Mouse", 102, 25.50f, 15);
        order1Customer1.AddProduct("Keyboard", 103, 45.75f, 10);
        order1Customer1.DisplayOrder();

        Order order2Customer1 = new Order(customer1);
        order2Customer1.AddProduct("Cleaner", 561, 11.99f, 67);
        order2Customer1.AddProduct("Mop", 145, 35.50f, 12);
        order2Customer1.AddProduct("Sponge", 456, 0.65f, 34);
        order2Customer1.DisplayOrder();

        Customer customer2 = new Customer("Ismael Marin", "Sierras de Pocho street", "Villa Allende", "Cordoba", "Argentina");
        Order order1Customer2 = new Order(customer2);
        order1Customer2.AddProduct("Notebook", 201, 3.50f, 50);
        order1Customer2.AddProduct("Pen", 202, 1.25f, 100);
        order1Customer2.AddProduct("Backpack", 203, 49.99f, 5);
        order1Customer2.DisplayOrder();

        Order order2Customer2 = new Order(customer2);
        order2Customer2.AddProduct("Water Bottle", 301, 12.75f, 8);
        order2Customer2.AddProduct("Lunch Box", 302, 18.40f, 6);
        order2Customer2.AddProduct("Notebook Set", 303, 9.99f, 12);
        order2Customer2.DisplayOrder();

        Order order3Customer2 = new Order(customer2);
        order3Customer2.AddProduct("Headphones", 401, 79.99f, 3);
        order3Customer2.AddProduct("Phone Charger", 402, 15.50f, 10);
        order3Customer2.AddProduct("USB Drive", 403, 22.25f, 7);
        order3Customer2.DisplayOrder();
    }
}