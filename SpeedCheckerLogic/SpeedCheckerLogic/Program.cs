using System;

namespace SpeedCheckerLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 40;
            Car Hyundai = new Car();

            Hyundai.SetLicPlate("DFC 45FG");
            Hyundai.SetSpeed(100);
            Hyundai.AddDemerit(speedLimit);
            Hyundai.CheckLicense();

        }
    }
}
