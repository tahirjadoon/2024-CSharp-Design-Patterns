using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.BicycleBuildBase.Enums;
public enum ZBikeTypes
{
    [Description("Mountain Bike")]
    Mountainbike,

    [Description("Crusier Bike")]
    Cruiser,

    [Description("Recumbent Bike")]
    Recumbent,

    [Description("Road Bike")]
    Roadbike
}
