using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Sequential, Size = 2 * 3 * sizeof(byte))]
    unsafe public struct byte2x3 : IEquatable<byte2x3>, IFormattable
    {
        public byte2 c0;
        public byte2 c1;
        public byte2 c2;


        public static byte2x3 zero => default;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x3(byte2 c0, byte2 c1, byte2 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x3(byte m00, byte m01, byte m02,
                       byte m10, byte m11, byte m12)
        {
            this.c0 = new byte2(m00, m10);
            this.c1 = new byte2(m01, m11);
            this.c2 = new byte2(m02, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2x3(byte v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte2x3(byte v) => new byte2x3(v);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(sbyte2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(short2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(ushort2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(int2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(uint2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(long2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(ulong2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(float2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2x3(double2x3 input) => new byte2x3((byte2)input.c0, (byte2)input.c1, (byte2)input.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short2x3(byte2x3 input) => new short2x3((short2)input.c0, (short2)input.c1, (short2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ushort2x3(byte2x3 input) => new ushort2x3((ushort2)input.c0, (ushort2)input.c1, (ushort2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x3(byte2x3 input) => new int2x3((int2)input.c0, (int2)input.c1, (int2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x3(byte2x3 input) => new uint2x3((uint2)input.c0, (uint2)input.c1, (uint2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator long2x3(byte2x3 input) => new long2x3((long2)input.c0, (long2)input.c1, (long2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong2x3(byte2x3 input) => new ulong2x3((ulong2)input.c0, (ulong2)input.c1, (ulong2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(byte2x3 input) => new float2x3((float2)input.c0, (float2)input.c1, (float2)input.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(byte2x3 input) => new double2x3((double2)input.c0, (double2)input.c1, (double2)input.c2);


        public ref byte2 this[int index]
        {
            get
            {
Assert.IsWithinArrayBounds(index, 3);

                fixed (void* ptr = &this)
                {
                    return ref ((byte2*)ptr)[index];
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator + (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 + right.c0, left.c1 + right.c1, left.c2 + right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator - (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 - right.c0, left.c1 - right.c1, left.c2 - right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator * (byte2x3 left, byte2x3 right) => new byte2x3(left.c0 * right.c0, left.c1 * right.c1, left.c2 * right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator / (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 / right.c0, left.c1 / right.c1, left.c2 / right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator % (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 % right.c0, left.c1 % right.c1, left.c2 % right.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator * (byte2x3 left, byte right) => right * left;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator * (byte left, byte2x3 right) => new byte2x3 (left * right.c0, left * right.c1, left * right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator / (byte2x3 left, byte right) => new byte2x3 (left.c0 / right, left.c1 / right, left.c2 / right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator % (byte2x3 left, byte right) => new byte2x3 (left.c0 % right, left.c1 % right, left.c2 % right);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator & (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 & right.c0, left.c1 & right.c1, left.c2 & right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator | (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 | right.c0, left.c1 | right.c1, left.c2 | right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator ^ (byte2x3 left, byte2x3 right) => new byte2x3 (left.c0 ^ right.c0, left.c1 ^ right.c1, left.c2 ^ right.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator ++ (byte2x3 val) => new byte2x3 (++val.c0, ++val.c1, ++val.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator -- (byte2x3 val) => new byte2x3 (--val.c0, --val.c1, --val.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator ~ (byte2x3 val) => new byte2x3 (~val.c0, ~val.c1, ~val.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator << (byte2x3 x, int n) => new byte2x3 (x.c0 << n, x.c1 << n, x.c2 << n);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2x3 operator >> (byte2x3 x, int n) => new byte2x3 (x.c0 >> n, x.c1 >> n, x.c2 >> n);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 == right.c0, left.c1 == right.c1, left.c2 == right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 < right.c0, left.c1 < right.c1, left.c2 < right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 > right.c0, left.c1 > right.c1, left.c2 > right.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 != right.c0, left.c1 != right.c1, left.c2 != right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 <= right.c0, left.c1 <= right.c1, left.c2 <= right.c2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (byte2x3 left, byte2x3 right) => new bool2x3 (left.c0 >= right.c0, left.c1 >= right.c1, left.c2 >= right.c2);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(byte2x3 other) => this.c0.Equals(other.c0) & this.c1.Equals(other.c1) & this.c2.Equals(other.c2);
        public override readonly bool Equals(object obj) => Equals((byte2x3)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode() => (c2.x ^ c0.GetHashCode() | (c2.y ^ (c1.GetHashCode() << 16)));


        public override readonly string ToString() => $"byte2x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y})";
        public readonly string ToString(string format, IFormatProvider formatProvider) => $"byte2x3({c0.x.ToString(format, formatProvider)}, {c1.x.ToString(format, formatProvider)}, {c2.x.ToString(format, formatProvider)},  {c0.y.ToString(format, formatProvider)}, {c1.y.ToString(format, formatProvider)}, {c2.y.ToString(format, formatProvider)})";
    }
}