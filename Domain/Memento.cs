using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Memento
    {
        public int Salud {  get;private set; }
        public Memento(int salud)
        {
            Salud = salud; 
        }
    }
}
