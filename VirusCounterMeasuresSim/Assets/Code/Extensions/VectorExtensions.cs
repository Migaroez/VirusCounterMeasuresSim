using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Code.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        /// compares a Unity.Vector3 (y for height) to a top down vector 2 location
        /// </summary>
        /// <param name="desired"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        public static bool IsSameLocation(this System.Numerics.Vector2 desired, Vector3 current)
        {
            return Math.Abs(desired.X - current.x) <= float.Epsilon && Math.Abs(desired.Y - current.z) <= float.Epsilon;
        }
    }
}
