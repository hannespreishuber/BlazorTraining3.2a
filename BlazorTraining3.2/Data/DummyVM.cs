using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Data
{
    public class DummyVM
    {
        public int MyProperty { get; set; }
        public void Add()
        {
            MyProperty++;
            MyEvent.Invoke();
           
        }

      public event Action MyEvent;

    }
}
