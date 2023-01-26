using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseJan20
{
    public class House
    {
        private int _sections;
        public int sections
        {
            set
            {
                if (value <= 0)
                {
                    _sections = 1;
                }
                else _sections = value;
            }
            get
            {
                return _sections;
            }
        }

        private int _floors;
        public int floors
        {
            set
            {
                if (value <= 0)
                {
                    _floors = 1;
                }
                else _floors = value;
            }
            get
            {
                return _floors;
            }

        }

        private int apartmentsOnFloor
        { get; set; }

        public House (int sections, int floors)
        {
            this.sections = sections;
            this.floors = floors;
            apartmentsOnFloor = 4;
        }

        public bool IsIncluded(int apartmentNumber)
        {
            return (apartmentNumber <= (sections * floors * apartmentsOnFloor)) && apartmentNumber > 0 ? true : false;
        }

        public int WhatSection(int apartmentNumber)
        {
            int apartmentSection;

            apartmentSection = apartmentNumber / (floors * apartmentsOnFloor);

            if ((apartmentNumber % (floors * apartmentsOnFloor)) > 0)
            {
                apartmentSection++;
            }
            
            return apartmentSection;
        }

        public int WhatFloor(int apartmentSection, int apartmentNumber)
        {
            int apartmentFloor, tmp;

            tmp = apartmentNumber - (apartmentSection - 1) * floors * apartmentsOnFloor;

            apartmentFloor = tmp / apartmentsOnFloor;

            if ((tmp % apartmentsOnFloor) > 0)
            {
                apartmentFloor++;
            }

            return apartmentFloor;
        }

        public void WereOnFloor(int apartmentNumber)
        {
            int positionOnFloor;

            positionOnFloor = apartmentNumber % apartmentsOnFloor;

            //TODO switch выводит ерунду 

            switch (positionOnFloor)
            {
                case 0:
                    Console.Write("слева ближняя");
                    break;
                case 1:
                    Console.Write("слева дальняя");
                    break;
                case 2:
                    Console.Write("справа дальняя");
                    break;
                case 3:
                    Console.Write("справа ближняя");
                    break;
                default:
                    Console.Write("ОШИБКА");
                    break;
            }
        }
    }
}
