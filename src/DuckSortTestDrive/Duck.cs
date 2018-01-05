using System;

namespace DuckSortTestDrive
{
    class Duck : IComparable
    {
        private readonly string _name;
        private readonly int _weight;

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public override string ToString()
        {
            return $"{_name} weighs {_weight}";
        }

        public int CompareTo(object obj)
        {
            Duck otherDuck = (Duck) obj;

            if (_weight < otherDuck.GetWeight())
            {
                return -1;
            }
            else if (_weight == otherDuck._weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
