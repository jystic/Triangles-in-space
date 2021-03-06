﻿using TrianglesInSpace.Primitives;
using Math = System.Math;
using Angle =TrianglesInSpace.Primitives.Angle;
using Mogre;

namespace TrianglesInSpace.Motion
{
	public static class CoordinateConversions
	{
		public static Vector2 RadialToVector2(Angle angle, double radius)
		{
			return new Vector2((radius * Math.Cos(angle.Value)), (radius * Math.Sin(angle.Value)));
		}

        public static Vector RadialToVector(Angle angle, double radius)
        {
            return new Vector((radius * Math.Cos(angle.Value)), (radius * Math.Sin(angle.Value)));
        }
	}
}
