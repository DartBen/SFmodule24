namespace AdoNetLib
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Data Source= .\DESKTOP-BC8P93V;
                                                    Database=testing; 
                                                    Connect Timeout=3; 
                                                    Trusted_Connection=True;
                                                    TrustServerCertificate=True; ";
    }
}
