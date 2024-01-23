using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.Builders
{
    public class CarBuilder
    {
        protected string color = "Red";
        protected string brand = "Ford";
        protected string model = "Mustang";
        protected int year = DateTime.Now.Year; 

        public CarBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }

        public Vehicle Build()
        {
            return new Car(color, brand, model, year);
        }
    }
}
