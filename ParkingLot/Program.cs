using System;

namespace ParkingLot
{
    class Program
    {

        class ParkingLot
        {
            private int largeParkingSpots;
            private int mediumParkingSpots;
            private int smallParkingSpots;

            public ParkingLot(int largeSpots, int mediumSpots, int smallSpots)
            {
                SetLargeSpots(largeSpots);
                SetMediumSpots(mediumSpots);
                SetSmallSpots(smallSpots);
            }

            public bool AddCar(string carType)
            {
                carType = carType.ToLower();
                if (carType == "large")
                {
                    if (this.GetlargeSpots() == 0)
                    {
                        return false;
                    }
                    else
                    {
                        SetLargeSpots(largeParkingSpots-1);
                        return true;
                    }

                }

                if (carType == "medium")
                {
                    if (this.GetMediumSpots() == 0) 
                    {

                        return false; 
                    }
                    else
                    {
                        SetMediumSpots(mediumParkingSpots-1);
                        return true;
                    }

                }
               
                if (carType == "small")
                {
                    if (this.GetSmallSpots() == 0)
                    {
                        return false;
                    }
                    else
                    {
                        SetSmallSpots(smallParkingSpots-1);
                        return true;
                    }
                }

                return false;

            }

            public int GetlargeSpots()
            {
                return largeParkingSpots;
            }
            public void SetLargeSpots(int size)
            {
                largeParkingSpots = size;
            }
            public int GetMediumSpots()
            {
                return mediumParkingSpots;
            }
            public void SetMediumSpots(int size)
            {
                mediumParkingSpots = size;
            }
            public int GetSmallSpots()
            {
                return smallParkingSpots;
            }
            public void SetSmallSpots(int size)
            {
                smallParkingSpots = size;
            }

            static void Main(string[] args)
            {


                bool result;
                ParkingLot kingSupers = new ParkingLot(5, 5, 5);

                result = kingSupers.AddCar("medium");
                result = kingSupers.AddCar("medium");
                Console.WriteLine(result);
                result = kingSupers.AddCar("medium");
                result = kingSupers.AddCar("medium");
                Console.WriteLine(result);
                result = kingSupers.AddCar("medium");
                result = kingSupers.AddCar("medium");

                Console.WriteLine(result);

            }
        }
    }
}


