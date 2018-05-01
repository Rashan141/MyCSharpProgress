using System;

namespace KeepMeTalking
{
    partial class Program
    {
        class Caste {

            private string[] _titles = new string[7]{ "Baron", "Duke", "Duchess", "Mistress", "King", "Queen", "Peasant" };
            private static Random _numOfName = new Random();
            private readonly string _name;
            private readonly string _title;

            public Caste()
            {
                _name = Char.ConvertFromUtf32(_numOfName.Next(1, 27) + 64);
                _title = _titles[_numOfName.Next(0,7)];
            }

            public string GetName() {
                return _name;
            }

            public string GetTitle()
            {
                return _title;
            }

            public string FullStatus() {
                return _title + " " + _name;
            }
        }
    }
}
