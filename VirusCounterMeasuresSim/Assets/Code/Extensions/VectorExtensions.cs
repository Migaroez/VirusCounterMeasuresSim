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
        public static bool IsSameLocation(this Code.Data.Vector2Int desired, Vector3 current)
        {
            return Math.Abs(desired.X - current.x) <= float.Epsilon && Math.Abs(desired.Y - current.z) <= float.Epsilon;
        }

        public static Vector3 RoundXZ(this Vector3 vector)
        {
            return new Vector3((int)vector.x, vector.y, (int)vector.z);
        }

        public static Code.Data.Vector2Int ToVector2Int(this Vector3 vector)
        {
            return new Code.Data.Vector2Int((int)vector.x, (int)vector.z);
        }
    }
}
