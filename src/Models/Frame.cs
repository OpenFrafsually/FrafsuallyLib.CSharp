/*
    Copyright (C) 2021 AluminiumTech

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
    USA
 */

using OpenFrafsuallyLib.Models.Definition;

using System;

namespace OpenFrafsuallyLib.Models
{
    public class Frame : IFrame
    {
        public Frame()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public double TimeMilliseconds => Math.Abs(StartTimeMilliseconds - EndTimeMilliseconds);

        /// <summary>
        /// The horizontal resolution of the frame being rendered measured in pixels.
        /// </summary>
        public int HorizontalResolutionPixels { get; set; }

        /// <summary>
        /// The vertical resolution of the frame being rendered measured in pixels.
        /// </summary>
        public int VerticalResolutionPixels {get; set;}

        /// <summary>
        /// The total number of pixels rendered in this frame, calculated by multiplying the horizontal and vertical resolutions together.
        /// </summary>
        public double TotalNumberOfPixelsRendered => Convert.ToDouble(VerticalResolutionPixels * HorizontalResolutionPixels);

        public long FrameNumber { get; set; }
        public double StartTimeMilliseconds { get; set; }
        public double EndTimeMilliseconds { get; set; }
    }
}
