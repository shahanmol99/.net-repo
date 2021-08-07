using System;

namespace CRUDOperationsApp.Model
{
    class CustomerDB : ICRUDable
    {
		public void Create()
		{
			Console.WriteLine("created customer db");
		}	
		public void Read()
		{
			Console.WriteLine("reading customer db");
		}
		public void Update()
		{
			Console.WriteLine("updating customer db");
		}
		public void Delete()
        {
            Console.WriteLine("deleting customer db");
        }
    }
}
