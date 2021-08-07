using System;

namespace CRUDOperationsApp.Model
{
    class DepartmentDB : ICRUDable
    {
		public void Create()
		{
			Console.WriteLine("created department db");
		}

		public void Read()
		{
			Console.WriteLine("reading department db");
		}
		public void Update()
		{
			Console.WriteLine("updating department db");
		}
		public void Delete()
		{
			Console.WriteLine("deleting department db");
		}
	}
}
