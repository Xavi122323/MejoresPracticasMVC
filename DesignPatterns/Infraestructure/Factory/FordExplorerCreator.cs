using DesignPatterns.Infraestructure.Builders;
using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factory
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetModel("Explorer")
                .SetColor("Black")
                .Build();
        }
    }
}
