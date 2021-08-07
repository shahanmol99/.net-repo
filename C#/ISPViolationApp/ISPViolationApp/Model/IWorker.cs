using System;
using System.Collections.Generic;
using System.Text;

namespace ISPViolationApp.Model
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();

    }
}
