using System;

namespace FootBallLib
{
    /// <summary>
    /// Contains properties for a footballplayer with exceptions and constraints.
    /// </summary>
    public class FootballPlayer
    {
        private string _name;
        private int _id;
        private double _price;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, double price, int shirtnumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtnumber; 
        }

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException("Name length should be more than 4 characters");
                _name = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("price", value, "price under 0");
                _price = value;
            }

        }
        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (1 <= value && value <= 100) _shirtNumber = value;
                else throw new ArgumentOutOfRangeException("shirtnumber", value, "Shirtnumber not between 1-100");
            }
        }

        public override string ToString()
        {
            return "ID: " + Id + "\nName: " + Name + "\nPrice: " + Price + "\nShirtnumber: " + ShirtNumber;
        }
    }
}
