using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.Builders
{
    public class MotorcycleBuilder
    {
        protected string color = "Blue";
        protected string brand = "Harley Davidson";
        protected string model = "Street Bob 114";
        protected int year = DateTime.Now.Year;

        public MotorcycleBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public MotorcycleBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public MotorcycleBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public MotorcycleBuilder SetYear(int year)
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
