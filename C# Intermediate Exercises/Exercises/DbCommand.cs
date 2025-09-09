using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate_Exercises.Exercises
{
    internal class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly String _instruction;
        public DbCommand(DbConnection dbConnection, String instruction)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException("DbConnection cannot be null");
            }
            if (instruction == null)
            {
                throw new ArgumentNullException("The Instructions are not Valied");
            }
            _dbConnection = dbConnection;
            _instruction = instruction;
        }
        public void Execute()
        {
            Console.WriteLine("Run the Instruction "+_instruction);
        }
    }
}
