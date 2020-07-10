using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Data
{

    public class ChatVM
    {
        public event Action OnUpdate;
        public ChatVM()
        {
            Nachrichten = new List<string>();

        }
        public List<String> Nachrichten { get; set; }
        public void Add(string msg)
        {
            Nachrichten.Add(msg);
            OnUpdate.Invoke();
        }
    }
}
