using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDOperationsApp.Model
{
    interface ICRUDable
    {
        void Create();
        void Read();
        void Update();
        void Delete(); 
    }
}
