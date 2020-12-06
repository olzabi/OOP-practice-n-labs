using System;

namespace Lab8.Class
{
    public class Person
    {
        const int LName = 30;
        private string _name;
        private int _birthYear;
        private double _pay;

        public Person()
        {
            _name = "John Doe";
            _birthYear = 0;
            _pay = 0;
        }    

        public Person(string s)
        {
            _name = s.Substring(0, LName);
            _birthYear = Convert.ToInt32(s.Substring(LName, 4));
            _pay = Convert.ToDouble(s.Substring(LName + 4));
            
            if (_birthYear < 0) throw new FormatException();
            if (_pay < 0) throw new FormatException();
        }        

        public override string ToString()
        {
            return string.Format("name: {0,30} \n birth: {1} \n payment: {2:F2}", _name, _birthYear, _pay);
        }

        public int Compare(string name)
        {
            return (string.Compare(this._name, 0,name + " ", 0, name.Length +
                                                               1,StringComparison.OrdinalIgnoreCase));
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }           

        public int BirthYear
        {
            get => _birthYear;
            set
            {
                if (value > 0) _birthYear = value;
                else throw new FormatException();
            }
        }

        public double Pay
        {
            get => _pay;
            set
            {
                if (value > 0) _pay = value;
                else throw new FormatException();
            }
        }
        
        public static double operator +(Person person, double a)
        {
            person._pay += a;
            return person._pay;
        }
        public static double operator +(double a, Person person)
        {
            person._pay += a;
            return person._pay;
        }
        public static double operator -(Person person, double a)
        {
            person._pay -= a;
            if (person._pay < 0) throw new FormatException();
            return person._pay;
        }
    };
}