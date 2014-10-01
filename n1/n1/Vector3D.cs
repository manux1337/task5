using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace n1
{
    class Vector3D
    {
        private int x, y, z;
        public Vector3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static bool operator >(Vector3D v1, Vector3D v2)
        {
            return (v1.x > v2.x) && (v1.y > v2.y) && (v1.z > v2.z);
        }
        public static bool operator <(Vector3D v1, Vector3D v2)
        {
            return (v1.x < v2.x) && (v1.y < v2.y) && (v1.z < v2.z);
        }
        public int Length
        {
            get
            {
                return (int)Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            }
        }

        public bool CompareLength(Vector3D v1)
        {
            return this.Length > v1.Length;
        }

        public static int GetScalar(Vector3D v1, Vector3D v2)
        {
            return v1.x * v2.x + v1.y + v2.y + v1.z + v2.z;
        }
    }
}
