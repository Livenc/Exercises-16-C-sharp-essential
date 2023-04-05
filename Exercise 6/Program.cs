namespace Exercise_6
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point(double x , double y, double z)
        {
            X=x; Y=y; Z=z;
        } 
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }
        public override string ToString()
        {
            return $"{X} - {Y} - {Z}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 2, 3);
            Point point1 = new Point(1, 2, 3);
            Console.WriteLine(point+point1);
            Console.ReadKey();
        }
    }
}