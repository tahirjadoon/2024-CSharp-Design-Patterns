﻿using DP.BicycleBuildBase.Enums;
using System.Drawing;

namespace DP.BicycleBuildBase;

/// <summary>
/// inherits from Bicycle abstract class
/// </summary>
public class RecumbentBike : Bicycle
{
    public RecumbentBike()
    {
        ModelName = ZBikeModelNames.BigBend;
        Suspension = ZSuspensionTypes.Front;
        Color = ZBicyclePaintColors.White;
        Geometry = ZBicycleGeometries.Recumbent;
    }
}
