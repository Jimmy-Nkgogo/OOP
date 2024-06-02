using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance is a relationship between two classes that allow one to inherit code
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
