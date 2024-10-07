static class DataAccessFactory
{
    public static IDataAccess GetDataAccessType(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "sql":
                return new SQLDataAccess();
            
            case "list":
                return new ListDataAccess();
            
            case "mongo":
                return new MongoDataAccess();
            
            default:
                return new ListDataAccess();
        }
    }
}