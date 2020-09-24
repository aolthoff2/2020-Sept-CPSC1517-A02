using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //A class represents the defined characteristic of an item.
    //An item can be a physical thing (cell-phone), a concept (student), collection of data
    //Visual Studio creates your class without a specific access type.
    //The default type for a class is private.
    //Code outside of a private class cannot use the contents of the private class.
    //For the class to be used by an outside user (code), it MUST be public.
    public class Window
    {
        //Private Data Members
        //There are variables that are known ONLY within the class.
        //Will be used for Fully Implemented Properties
        //Will be used for local class only data
        private string _Manufacturer;


        //Public Data Members
        //There are variables that are known within the class AND outside of the class.
        //Public Data Members can be altered by code within AND without side the class.
        //It is preferred to use Properties instead of Public Data Members

        //Properties
        //OPTIONAL.
        //Properties can be implemented in two ways:
        //A) Fully Implemented Property
        //Used because there is additional code/logic use in processing the data.
        //B) Auto Implemented Property
        //Used when there is no need for additional code/logic when data is simply saved/stored.

        //Fully Implemented Property
        public string Manufacturer
        {
            //Assume the Manufacturer is a nullable string
            //3 Possibilities
            //A)There are characters
            //B)String has no data (NULL)
            //C)There is a physical string BUT NO characters.
            //There will be additional code/logic to ensure ONLY A and B exists for the data.
            //This requires a private data member to hold the data and a property to manage the data content.
            get
            {
                //Returns data via the property to the outside user of the property.
                //A get operates on the right side of an equal sign (Assignment Statement)
                return _Manufacturer;

            }

            set
            {
                //The set takes incoming data and places that data into a private data member.
                //Internal to the property, incoming data will be placed in a common variable called VALUE.
                //A property is associated with a single data member.
                //A property has NO parameter list.
                //A set operates on the LEFT side of an equal sign (Assignment Statement)
                if (string.IsNullOrEmpty(value))
                {
                    //Ensure a null is stored in the Private Data Member
                    //Eliminate the C possibility.
                    _Manufacturer = null; //CASE B

                }
                else
                {
                    //Ensure the value is stored in the Private Data Member
                    _Manufacturer = value; //CASE A 
                }

                //Alternative Coding:
                //Syntax receiving field = condition(s) ? true value : false;
                //_Manufacturer = string.IsNullOrEmpty(value) ? null : value;


        public decimal Height
        {
            //Height must be greater than 0.
            get { return _Height; }
            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Height can NOT be 0 or less than 0.");
                }
                else
                {
                    _Height = value;
                }
            }
        }




        //Auto Implemented Property
        //Auto Implemented Properties can be used when there is NO NEED for additional processing against the incoming data.
        //NO internal Private Data Member is required for this property.
        //The system WILL internally generate a date rea for the data.
        //Accessing the stored data (get, set) CAN ONLY be done via the property.
        public decimal Width { get; set; }

        //One can still code auto implemented properties as Fully Implemented Properties
        //private decimal _Width;
        //public decimal Width
        //{
        //  get {return _Width; }
        //  set {_Width = value; }
        //}

        //What about nullable Numerics?
        //Do we need to test for a null value to be used for mssing incoming data?
        //NO. You do not have to code a Fully Implemented Property for a nullable numeric.
        //Numerics have a default of zero.
        //Numerics CAN ONLY store a numeric (unless nullable)
        //Numerics CAN BE NULL if declared as nullable.
        //IF the numeric has additional criteria THEN you can code the properties as a Fully Implemented Property.
        public int? NumberOfPanes { get; set; }
        //Constructors
        //A constructor is a "method" that guarantees that the newly created instance of this class will ALWAYS be created in a "known state".
        //Syntax
        //PUBLIC constructorname([list of parameters])
        //{
        //      your code
        //}

        //Constructors are OPTIONAL.
        //IF a class DOES NOT have a constructor, then the system will generate the class instance using the datatype defaults for your private data members and auto implemented properties
        //This situation of no constructor(s) is often referred to as using a "system" constructor.

        //IF you code a constructor, you MUST code any and all constructor(s) needed by your class.

        //There are two common types of constructors
        //DEFAULT and GREEDY

        //Default   
        //This takes NO parameters, and usually similates the 'system' constructor
        //You can if you wish assign values to your class data members/properties that are NOT the system default
        //Callled on your behave when an instance of the class is requested by the outside user.
        //You can NOT call a constructor directly like a method.

        public Window()
        {
            //technically numerics are set to zero when they are declared
            //Logically in this class, the numeric fields should NOT be zero
            //Therefore we will set the numeric fields to a literal not equal to zero.

            //One could assign value directly to private data member within the class
            //A preffered method is to usee the properties instead of the private data members
            //Why? Is that the properties MAY have validation to ensure acceptable values exists for the data
            //Also, auto implemtented propertie have no direct pivate data members

            Height = 0.9m; //the assumed window height is 0.9 meters
            Width = 1.2m;
            NumberOfPanes = 1;
        }


        //Greedy
        //takes in a value for each data member/property in the class
        //each data member/property is assigned the appropriate incoming parametr value


        public Window(decimal width, decimal height, int? numberofpanes, string manufacturer)

        {
            Width = width;
            Height = height;
            NumberOfPanes = numberofpanes;
            Manufacturer = manufacturer;
        }

        //Behaviours
        //are also known as methods
        //Optional!

        //Area of a Window
        public decimal WindowArea()
        {
            return Height * Width;
        }

        //Perimeter of a Window
        public decimal WindowPerimeter()
        {
            return 2 * (Height * Width);
        }
    } 
}
