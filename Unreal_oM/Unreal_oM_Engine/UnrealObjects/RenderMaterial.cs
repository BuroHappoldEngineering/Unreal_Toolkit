﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;

namespace BH.oM.Graphics.MaterialFragments
{
    public class RenderMaterial : BHoMObject 
    {
        public Color BaseColor { get; set; } = new Color();
        public double Opacity { get; set; } = 1;
        public double Glossiness { get; set; } = 0;
        public Color EmissiveColor { get; set; } = new Color();
        public double Emissivity { get; set; } = 0;
    }

    public class Color : BHoMObject
    {
        public double R { get; set; } = 1;
        public double G { get; set; } = 1;
        public double B { get; set; } = 1;
    }
}