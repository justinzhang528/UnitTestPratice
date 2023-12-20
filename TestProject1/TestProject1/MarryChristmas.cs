using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class MarryChristmas
    {
        DateTime _today;
        public MarryChristmas(DateTime today)
        {
            _today = today;
        }
        public MarryChristmas()
        {
            
        }

        public string IsMarryChristmas()
        {
            if (_today.Month == 12 && _today.Day == 25)
                return "Today is Marry Christmas";
            else
                return "Today isn't Marry Christmas";
        }
    }
}
