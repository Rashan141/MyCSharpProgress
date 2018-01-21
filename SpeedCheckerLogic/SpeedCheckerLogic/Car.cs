using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCheckerLogic
{
    class Car
    {

        private string lic_plate;
        private int demerits = 0;
        private int speed;

        public void SetLicPlate(string licPlate) {
            this.lic_plate = licPlate;
        }

        public void SetSpeed(int theSpeed) {
            this.speed = theSpeed;
        }

        public void AddDemerit(int speedLimit) {
            if (this.speed > speedLimit + 4)
            { this.demerits = (this.speed - speedLimit) / 5; }
            else {
                this.demerits = 0;
            }
        }

        public void CheckLicense()
        {
            if (this.demerits < 12)
            {
                Console.WriteLine("This license is OK.");
            }
            else
            {
                Console.WriteLine("This license: " + this.lic_plate+ " is SUSPENDED.");
            }
        }
    }
}
