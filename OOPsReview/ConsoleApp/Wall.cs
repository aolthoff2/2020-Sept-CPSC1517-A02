using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Wall
    {

        //Height, Width > 0.0
        //Height has a default of 2.5, width is 4.25m
        //Area and Perimeter
        //Throw exceptios for invalid data
        private decimal _Height;
        private decimal _Width;

    

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
    public Wall()
    {
        Width = 4.25m;
        Height = 2.5m;
    }

    public Wall(decimal width, decimal height)
    {
        Width = width;
        Height = height;
    }

    public decimal WallArea()
    {
        return Width * Height;
    }

    public decimal WallPerimeter()
    {
        return 2 * (Width * Height);
    }
}
    }
}
