using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 24)]
    unsafe public struct ushort3x4 : IEquatable<ushort3x4>, IFormattable
    {
        public ushort3 c0;
        public ushort3 c1;
        public ushort3 c2;
        public ushort3 c3;


        public static ushort3x4 zero => default(ushort3x4);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3x4(ushort3 c0, ushort3 c1, ushort3 c2, ushort3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3x4(ushort m00, ushort m01, ushort m02, ushort m03,
                         ushort m10, ushort m11, ushort m12, ushort m13,
                         ushort m20, ushort m21, ushort m22, ushort m23)
        {
            this.c0 = new ushort3(m00, m10, m20);
            this.c1 = new ushort3(m01, m11, m21);
            this.c2 = new ushort3(m02, m12, m22);
            this.c3 = new ushort3(m03, m13, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3x4(ushort v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort3x4(ushort v) => new ushort3x4(v);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(short3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(int3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(uint3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(long3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(ulong3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(float3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort3x4(double3x4 input) => new ushort3x4((ushort3)input.c0, (ushort3)input.c1, (ushort3)input.c2, (ushort3)input.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3x4(ushort3x4 input) => new int3x4((int3)input.c0, (int3)input.c1, (int3)input.c2, (int3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3x4(ushort3x4 input) => new uint3x4((uint3)input.c0, (uint3)input.c1, (uint3)input.c2, (uint3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long3x4(ushort3x4 input) => new long3x4((long3)input.c0, (long3)input.c1, (long3)input.c2, (long3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3x4(ushort3x4 input) => new ulong3x4((ulong3)input.c0, (ulong3)input.c1, (ulong3)input.c2, (ulong3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(ushort3x4 input) => new float3x4((float3)input.c0, (float3)input.c1, (float3)input.c2, (float3)input.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(ushort3x4 input) => new double3x4((double3)input.c0, (double3)input.c1, (double3)input.c2, (double3)input.c3);


        public ref ushort3 this[[AssumeRange(0, 3)] int index]
        {
            get
            {
Assert.IsWithinArrayBounds(index, 4);

                fixed (void* ptr = &this)
                {
                    return ref ((ushort3*)ptr)[index];
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator + (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator - (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator * (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator / (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator % (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator * (ushort3x4 lhs, ushort rhs) => rhs * lhs;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator * (ushort lhs, ushort3x4 rhs) => new ushort3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator / (ushort3x4 lhs, ushort rhs) => new ushort3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator % (ushort3x4 lhs, ushort rhs) => new ushort3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator & (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator | (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator ^ (ushort3x4 lhs, ushort3x4 rhs) => new ushort3x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator ++ (ushort3x4 val) => new ushort3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator -- (ushort3x4 val) => new ushort3x4 (--val.c0, --val.c1, --val.c2, --val.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator ~ (ushort3x4 val) => new ushort3x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator << (ushort3x4 x, int n) => new ushort3x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3x4 operator >> (ushort3x4 x, int n) => new ushort3x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (ushort3x4 lhs, ushort3x4 rhs) => new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ushort3x4 other) => (this.c0.Equals(other.c0) & this.c1.Equals(other.c1)) & (this.c2.Equals(other.c2) & this.c3.Equals(other.c3));
        public override bool Equals(object obj) => Equals((ushort3x4)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => (c0.GetHashCode() ^ c1.GetHashCode()) ^ (c2.GetHashCode() ^ c3.GetHashCode());


        public override string ToString() => $"ushort3x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z})";
        public string ToString(string format, IFormatProvider formatProvider) => $"ushort3x4({c0.x.ToString(format, formatProvider)}, {c1.x.ToString(format, formatProvider)}, {c2.x.ToString(format, formatProvider)}, {c3.x.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.y.ToString(format, formatProvider)}, {c2.z.ToString(format, formatProvider)}, {c3.y.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.z.ToString(format, formatProvider)}, {c2.z.ToString(format, formatProvider)}, {c3.z.ToString(format, formatProvider)})";
    }
}