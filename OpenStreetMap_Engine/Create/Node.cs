﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
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
using BH.oM.Geometry;
using BH.oM.Osm;
using System.ComponentModel;
using BH.oM.Reflection.Attributes;

namespace BH.Engine.Osm
{
    public static partial class Create
    {
        /***************************************************/
        /****           Public Constructors             ****/
        /***************************************************/
        [Description("Create a Node from location and id")]
        [Input("location", "Point object with longitude (X) and latitude (Y) of the location")]
        [Input("osmId", "OpenStreetMap id associated with the Node")]
        [Output("Node", "Node")]
        public static Node Node(Point location, long osmId)
        {
            return new Node()
            {
                Location = location,

                OsmID = osmId

            };
        }

        /***************************************************/
    }
}
