using System.Net.Http.Headers;

namespace Exercise_3
{
    public class House
    {
        private string _address ;
        private int _numRooms ;
        

        public House(string address, int numRooms)
        {
            _address = address;
            _numRooms = numRooms;
        }

        public House()
        {
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int NumRooms
        {
            get { return _numRooms; }
            set { _numRooms = value; }
        }
        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }

        public House DeepClone()
        {
            return this;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House("dfs",1);
            Console.WriteLine(house.Address + " " + house.NumRooms);
            House clone1 = house.Clone();
            Console.WriteLine(clone1.Address + " " + clone1.NumRooms);
            //clone1.Address = "Akil";
            //Console.WriteLine(clone1.Address + " " + clone1.NumRooms);
            //Console.WriteLine(house.Address + " " + house.NumRooms);

            House clone2 = house.DeepClone();
            Console.WriteLine(clone2.Address + " " + clone2.NumRooms);
            clone2.Address = "Liven";
            Console.WriteLine(house.Address + " " + house.NumRooms);
            Console.WriteLine(clone2.Address + " " + clone2.NumRooms);
            Console.ReadKey();

        }
    }
}