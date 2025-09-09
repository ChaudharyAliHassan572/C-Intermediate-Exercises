using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate_Exercises.Exercises
{
    internal abstract class DbConnection
    {
        public String ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }
        protected DbConnection(String connectionString,TimeSpan timeout)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection String Cannot be Empty");
            }
            ConnectionString = connectionString;
            Timeout = timeout;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
    class SqlConnection : DbConnection
    {
        public SqlConnection(String connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }
        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection Opened");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQL Connection Closed");
        }
    }
    class  OracleConnection : DbConnection
    {
        public OracleConnection(String connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Opened");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection Closed");
        }
    }
}
