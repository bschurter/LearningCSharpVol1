namespace PropertiesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(7, 1, 5);
            //Console.WriteLine(p1);
            ////p1.SetX(-7);
            //p1.X = -7;
            //p1.Y = 9;
            //Console.WriteLine(p1);

            Console.WriteLine(Vehicle.Header);
            Vehicle v1 = new Vehicle("ABC12345678901234", 2021, "Happy Motors", "Gofast", "X1", Vehicle.DrivetrainType.Battery, Vehicle.BodyStyle.Convertable, 50, 47500m);
            Vehicle v2 = new Vehicle("12345678900987654", 2019, "Ford", "F-150", "King Ranch", Vehicle.DrivetrainType.Diesel, Vehicle.BodyStyle.Pickup, 15, 99999.99m);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }

    internal class Point
    {
        private double _x = 0;
        private double _y = 0;
        //private double _z = 0;

        public Point(double x, double y, double z) 
        { 
            X = x; 
            Y = y; 
            Z = z;
        }

        public double X 
        { 
            get => _x;
            set 
            {
                if (value > 0)
                {
                    _x = value;
                }
            } 
        }

        public double Y
        {
            get => _y;
            set
            {
                if (value > 0)
                {
                    _y = value;
                }
            }
        }

        public double Z { get; set; }

        //public double GetX()
        //{
        //    return X;
        //}

        //public void SetX(double value)
        //{
        //    if (value > 0)
        //    {
        //        X = value;
        //    }
        //}

        public override string ToString()
        {
            return $"({X:0.0}, {Y:0.0}, {Z:0.0})";
        }
    }
}
