using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Vehicle
    {
        public enum DrivetrainType
        {
            Unknown,
            Gasoline,
            Diesel,
            NaturalGas,
            Hydrogen,
            Hybrid,
            Battery
        }

        public enum BodyStyle
        {
            Unknown,
            Sedan,
            Coupe,
            Hatchback,
            Convertable,
            SUV,
            CUV,
            Pickup,
            StationWagon,
            Minivan,
            Van
        }

        private string _vin;
        private decimal _msrp;

        public string VIN
        {
            get => _vin; 
            init // Equivalent to set, but only legal during construction
            {
                if (value?.Length == 17)
                {
                    _vin = value;
                }
                else
                {
                    throw new ArgumentException("VIN must be exactly 17 alphanumeric characters", nameof(VIN));
                }
            }
        }
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DrivetrainType Drivetrain { get; set; }
        public BodyStyle Style { get; set; }
        public double MPGe { get; set; }
        public decimal MSRP
        { 
            get => _msrp; 
            set
            {
                if (value > 0)
                {
                    _msrp = value;
                }
            }
        }

        public Vehicle(string vin, int year, string manufacturer, string make, string model, DrivetrainType drivetrain, BodyStyle style, double mpge, decimal msrp)
        {
            VIN = vin ?? throw new ArgumentNullException(nameof(vin));
            Year = year;
            Manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer));
            Make = make ?? throw new ArgumentNullException(nameof(make));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Drivetrain = drivetrain;
            Style = style;
            MPGe = mpge;
            MSRP = msrp;
        }

        public static string Header => $"{"VIN",-17} {"Year",-4} {"Manufacturer",-15} {"Make",-15} {"Model",-15} {"Drivetrain",-10} {"Body Style",-12} {"MSRP",12} {"MPGe",6}{Environment.NewLine}{new string('=', 114)}";
        

        public override string ToString()
        {
            return $"{VIN,-17} {Year,4} {Manufacturer,-15} {Make,-15} {Model,-15} {Drivetrain,-10} {Style,-12} {MSRP,12:C} {MPGe,6:0.0}";
        }
    }
}
