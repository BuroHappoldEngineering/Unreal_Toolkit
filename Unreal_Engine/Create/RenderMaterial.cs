/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */


using System.Drawing;
using BH.oM.External.Unreal;

namespace BH.Engine.External.Unreal
{
    public static partial class Create
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static RenderMaterial RenderMaterial(Color baseColor, double opacity, double glossiness, Color emissiveColor, double emissivity)
        {

            return new RenderMaterial
            {
                BaseColor = baseColor == null ? Color.Magenta : baseColor,
                Opacity = opacity == null ? 0 : opacity,
                Glossiness = glossiness == null ? 0 : glossiness,
                EmissiveColor = emissiveColor == null ? Color.Magenta : baseColor,
                Emissivity = emissivity == null ? 0 : emissivity,
            };
        }

        /***************************************************/

    }
}
