using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Backpack
    {

        //to be able to reach properties we need access modifiers
        //public is for outside of this class
        private string _material;
        private int _pocket;
        private string _color;
        private string _size;
        /// <summary>
        /// this is pound
        /// </summary>
        private double _weight;
        private bool _havewheels;

        //traditional way
        //getters and setters

        //_material
        public void setMaterial(string material) {
            _material = material;
        }

        public string getMaterial() {
            return _material;
        }
        //_pocket
        public void setPocket(int pocket)
        {
            _pocket = pocket;
        }

        public int getPocket()
        {
            return _pocket;
        }

        //_color
        public void setColor(string color)
        {
            _color = color;
        }

        public string getColor()
        {
            return _color;
        }

        //_size
        public void setSize(string size)
        {
            _size = size;
        }

        public string getSize()
        {
            return _size;
        }

        //_weight
        public void setWeight(double weight)
        {
            _weight = weight;
        }

        public double getWeight()
        {
            return _weight;
        }


        //_havewheels
        public void setHaveWheels(bool haveWheels)
        {
            _havewheels = haveWheels;
        }

        public bool getHaveWheels()
        {
            return _havewheels;
        }


        /// <summary>
        /// prints all object properties in a order
        /// </summary>
        public void printTheObjectProperties() {

            Console.WriteLine($" material : {getMaterial()} \n" +
                $"pocket size : {getPocket()} \n" +
                $"color : {getColor()} \n" +
                $"size : {getSize()} \n" +
                $"weight : {getWeight()} \n" +
                $"haveWheels : {getHaveWheels()} \n ");

        }



        //zip
        //carry
        //production date

    }
}
