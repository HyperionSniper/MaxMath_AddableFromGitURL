using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 4)]
    unsafe public struct byte2x2 : IEquatable<byte2x2>, IFormattable
    {
        public byte2 c0;
        public byte2 c1;


        public static byte2x2 identity => new byte2x2(1, 0,   0, 1);

        public static byte2x2 zero => default(byte2x2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x2(byte2 c0, byte2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x2(byte m00, byte m01,
                       byte m10, byte m11)
        {
            this.c0 = new byte2(m00, m10);
            this.c1 = new byte2(m01, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x2(byte v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte2x2(byte v) => new byte2x2(v);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(sbyte2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(short2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(ushort2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(int2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(uint2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(long2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(ulong2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(float2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x2(double2x2 input) => new byte2x2((byte2)input.c0, (byte2)input.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2x2(byte2x2 input) => new short2x2((short2)input.c0, (short2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort2x2(byte2x2 input) => new ushort2x2((ushort2)input.c0, (ushort2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x2(byte2x2 input) => new int2x2((int2)input.c0, (int2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x2(byte2x2 input) => new uint2x2((uint2)input.c0, (uint2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2x2(byte2x2 input) => new long2x2((long2)input.c0, (long2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2x2(byte2x2 input) => new ulong2x2((ulong2)input.c0, (ulong2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(byte2x2 input) => new float2x2((float2)input.c0, (float2)input.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(byte2x2 input) => new double2x2((double2)input.c0, (double2)input.c1);


        public ref byte2 this[[AssumeRange(0, 1)] int index]
        {
            get
            {
Assert.IsWithinArrayBounds(index, 2);

                fixed (void* ptr = &this)
                {
                    return ref ((byte2*)ptr)[index];
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator + (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator - (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator * (byte2x2 lhs, byte2x2 rhs) => new byte2x2(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator / (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator % (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator * (byte2x2 lhs, byte rhs) => rhs * lhs;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator * (byte lhs, byte2x2 rhs) => new byte2x2 (lhs * rhs.c0, lhs * rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator / (byte2x2 lhs, byte rhs) => new byte2x2 (lhs.c0 / rhs, lhs.c1 / rhs);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator % (byte2x2 lhs, byte rhs) => new byte2x2 (lhs.c0 % rhs, lhs.c1 % rhs);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator & (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator | (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator ^ (byte2x2 lhs, byte2x2 rhs) => new byte2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator ++ (byte2x2 val) => new byte2x2 (++val.c0, ++val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator -- (byte2x2 val) => new byte2x2 (--val.c0, --val.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator ~ (byte2x2 val) => new byte2x2 (~val.c0, ~val.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator << (byte2x2 x, int n) => new byte2x2 (x.c0 << n, x.c1 << n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x2 operator >> (byte2x2 x, int n) => new byte2x2 (x.c0 >> n, x.c1 >> n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (byte2x2 lhs, byte2x2 rhs) => new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(byte2x2 other) => this.c0.Equals(other.c0) & this.c1.Equals(other.c1);
        public override bool Equals(object obj) => Equals((byte2x2)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => c0.GetHashCode() | (c1.GetHashCode() << 16);


        public override string ToString() => $"byte2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";
        public string ToString(string format, IFormatProvider formatProvider) => $"byte2x2({c0.x.ToString(format, formatProvider)}, {c1.x.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.y.ToString(format, formatProvider)})";
    }
}