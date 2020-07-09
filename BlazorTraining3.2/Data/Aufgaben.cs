using Microsoft.AspNetCore.Mvc.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Data
{
    public class Aufgaben
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Datum { get; set; }
        public Boolean Erledigt { get; set; }
        [NotMapped]

        public Boolean IsEdit { get; set; }
    }
}
