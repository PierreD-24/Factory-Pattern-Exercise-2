public class SQLDataAccess : IDataAccess
{
    public static List<Product> Products = new List<Product>()
    {
        new Product (){Name = "Apple", Price = 2},
        new Product (){Name = "Bread", Price = 3},
        new Product (){Name = "Bike", Price = 200},
        new Product (){Name = "Laptop", Price = 1000}
    };
    public List<Product> LoadData()
    {
        Console.WriteLine("I am reading data from SQL data access.");
        return Products;
        
    }

    public void SaveData()
    {
        Console.WriteLine("I am saving data to a SQL database.");
    }
}