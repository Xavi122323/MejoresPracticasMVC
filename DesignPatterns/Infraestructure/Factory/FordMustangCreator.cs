using DesignPatterns.Infraestructure.Builders;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factory
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder.Build();
        }
    }
}
