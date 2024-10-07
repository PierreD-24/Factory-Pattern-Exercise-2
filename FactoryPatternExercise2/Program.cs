namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what kind of database would you like to use? (List, SQL, Mongo)");
            string? database = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(database);

            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }
        }
    }
}
