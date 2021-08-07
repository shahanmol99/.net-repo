using System;

namespace CRUDOperationsApp.Model
{
    class InvoiceDB : ICRUDable
    {
		public void Create()
		{
			 Console.WriteLine("created invoice db");
		}
		public void Read()
		{
			Console.WriteLine("reading invoice db");
		}
		public void Update()
		{
			Console.WriteLine("updating invoice db");
		}
		public void Delete()
		{
			Console.WriteLine("deleting from invoice db");
		}
	}
}
