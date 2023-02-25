namespace AdoNetLib
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Data Source= .\SQLEXPRESS;
                                                    Database=testing; 
                                                    Trusted_Connection=True;
                                                    Connect Timeout=3; ";
    }
}
