
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

using System.ComponentModel.Design;

List<Product> products = new List<Product>
{
    new Product { Name = "Trumpet", Price = 300.00m, ProductTypeId = 1 },
    new Product { Name = "Trombone", Price = 400.00m, ProductTypeId = 1 },
    new Product { Name = "Cornet", Price = 600.00m, ProductTypeId = 1 },
    new Product { Name = "Tuba", Price = 800.00m, ProductTypeId = 1 },
    new Product { Name = "The Collected Poems of Langston Hughes", Price = 18.98m, ProductTypeId = 2 },
    new Product { Name = "The Way Forward", Price = 48.59m, ProductTypeId = 2 },
    new Product { Name = "In Praise Or Mystery", Price = 45.98m, ProductTypeId = 2 },
    new Product { Name = "The Complete Tales & Poems of Edgar Allan Poe", Price = 159.00m, ProductTypeId = 2 }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType { Title = "Brass", Id = 1 },
    new ProductType { Title = "Poem", Id = 2 }
};

//put your greeting here
string greeting = "Welcome to the Brass and Poem store!";
Console.WriteLine(greeting);
Console.WriteLine();

//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            DisplayAllProducts(products, productTypes);
            break;
        case "2":
            DeleteProduct(products, productTypes);
            break;
        case "3":
            AddProduct(products, productTypes);
            break;
        case "4":
            UpdateProduct(products, productTypes);
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}


void DisplayMenu()
{
    Console.WriteLine(@"Select an option from the menu below:
    1. Display all products
    2. Delete a product
    3. Add a product
    4. Update a product
    5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    foreach (Product product in products)
    {
        ProductType productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        Console.WriteLine($"{products.IndexOf(product) + 1}. {product.Name} - {product.Price:C} ({productType.Title})");
    }
    Console.WriteLine();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }