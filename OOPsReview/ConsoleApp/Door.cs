﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Door
    {
        //Height, width, material (nullable), right or left swing door
        //Height and width > 0.0
        //Height has a default of 1.75, width is 1.2
        //Right or left are indicated with an R or L

        //Area and Perimeter
        //Throw exceptios for invalid data
        private string _Material;
        private decimal _Height;
        private string _RightOrLeft;
        private decimal _Width;

        public string Material
        {
            get
            {
                return _Material;
            }

            set
            {
                _Material = string.IsNullOrEmpty(value) ? null : value;
            }

        }

        public string RightOrLeft
        {
            get
            {
                return _RightOrLeft;
            }

            set
            {
                if (value.ToUpper().Equals("R") || value.ToUpper().Equals("L"))
                {
                    _RightOrLeft = value.ToUpper();
                }
                else
                {
                    throw new Exception("Door opening direction must be R or L.");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return _Height;
            }

            set
            {
                //The M indicates the value is a decimal
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less.");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        public decimal Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Width can not be 0 or less than.");
                }
                else
                {
                    _Width = value;
                }
            }
        }
       public Door()
        {
            Width = 1.2m;
            Height = 1.75m;
            RightOrLeft = "R";
        }

        public Door (decimal width, decimal height, string rightorleft, string material )
        {
            Width = width;
            Height = height;
            RightOrLeft = rightorleft;
            Material = material;

        }

        public decimal DoorArea()
        {
            return Width * Height;
        }

        public decimal DoorPerimeter()
        {
            return 2 * (Width * Height);
        }
    }
}
