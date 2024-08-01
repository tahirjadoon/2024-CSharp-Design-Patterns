using DP.BicycleBuildBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.P015.BikeBuild_Structural_DecoratorPattern.ConsoleApp;

public class DecoratorDocumentedBicycle : AbstractBicycleDecorator
{
    private IDocumentor _documentor;

    public DecoratorDocumentedBicycle(IBicycle bicycle, IDocumentor manualPrinter) : base(bicycle)
    {
        _documentor = manualPrinter;
    }

    public override void Build()
    {
        base._undecoratedBicycle.Build();
        _documentor.PrintManual();
    }
}
