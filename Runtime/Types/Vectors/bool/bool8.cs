﻿using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Explicit, Size = 8 * sizeof(bool))]
    unsafe public struct bool8 : IEquatable<bool8>
    {
        [FieldOffset(0)] private fixed bool asArray[8];

        [FieldOffset(0)] [MarshalAs(UnmanagedType.U1)] public bool x0;
        [FieldOffset(1)] [MarshalAs(UnmanagedType.U1)] public bool x1;
        [FieldOffset(2)] [MarshalAs(UnmanagedType.U1)] public bool x2;
        [FieldOffset(3)] [MarshalAs(UnmanagedType.U1)] public bool x3;
        [FieldOffset(4)] [MarshalAs(UnmanagedType.U1)] public bool x4;
        [FieldOffset(5)] [MarshalAs(UnmanagedType.U1)] public bool x5;
        [FieldOffset(6)] [MarshalAs(UnmanagedType.U1)] public bool x6;
        [FieldOffset(7)] [MarshalAs(UnmanagedType.U1)] public bool x7;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x0), maxmath.tobyte(x1), maxmath.tobyte(x2), maxmath.tobyte(x3), maxmath.tobyte(x4), maxmath.tobyte(x5), maxmath.tobyte(x6), maxmath.tobyte(x7)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool x0x8)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x0x8)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool2 x01, bool2 x23, bool2 x45, bool2 x67)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x01), maxmath.tobyte(x23), maxmath.tobyte(x45), maxmath.tobyte(x67)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool2 x01, bool3 x234, bool3 x567)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x01), maxmath.tobyte(x234), maxmath.tobyte(x567)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool3 x012, bool2 x34, bool3 x567)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x012), maxmath.tobyte(x34), maxmath.tobyte(x567)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool3 x012, bool3 x345, bool2 x67)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x012), maxmath.tobyte(x345), maxmath.tobyte(x67)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool4 x0123, bool2 x45, bool2 x67)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x0123), maxmath.tobyte(x45), maxmath.tobyte(x67)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool2 x01, bool4 x2345, bool2 x67)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x01), maxmath.tobyte(x2345), maxmath.tobyte(x67)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool2 x01, bool2 x23, bool4 x4567)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x01), maxmath.tobyte(x23), maxmath.tobyte(x4567)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool8(bool4 x0123, bool4 x4567)
        {
            this = maxmath.tobool(new byte8(maxmath.tobyte(x0123), maxmath.tobyte(x4567)));
        }


        public bool4 v4_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v4_0); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v4_0 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool4 v4_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v4_1); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v4_1 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool4 v4_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v4_2); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v4_2 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool4 v4_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v4_3); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v4_3 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool4 v4_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v4_4); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v4_4 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }

        public bool3 v3_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_0); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_0 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool3 v3_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_1); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_1 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool3 v3_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_2); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_2 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool3 v3_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_3); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_3 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool3 v3_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_4); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_4 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool3 v3_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v3_5); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v3_5 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }

        public bool2 v2_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_0); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_0 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_1); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_1 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_2); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_2 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_3); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_3 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_4); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_4 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_5); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_5 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }
        public bool2 v2_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => maxmath.tobool(maxmath.tobyte(this).v2_6); [MethodImpl(MethodImplOptions.AggressiveInlining)] set { byte8 temp = maxmath.tobyte(this); temp.v2_6 = maxmath.tobyte(value); this = maxmath.tobool(temp); } }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator v128(bool8 input) => new v128(*(long*)&input, 0L);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool8(v128 input)
        {
#if DEBUG
            return new bool8 { x0 = maxmath.tobool(input.Byte0),
                               x1 = maxmath.tobool(input.Byte1),
                               x2 = maxmath.tobool(input.Byte2),
                               x3 = maxmath.tobool(input.Byte3),
                               x4 = maxmath.tobool(input.Byte4),
                               x5 = maxmath.tobool(input.Byte5),
                               x6 = maxmath.tobool(input.Byte6),
                               x7 = maxmath.tobool(input.Byte7) };
#else
            long x = input.SLong0;

            return *(bool8*)&x;
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool8(bool x) => new bool8(x);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator == (bool8 left, bool8 right) => maxmath.tobyte(left) == maxmath.tobyte(right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator != (bool8 left, bool8 right) => maxmath.tobyte(left) != maxmath.tobyte(right);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator & (bool8 left, bool8 right) => maxmath.tobool(maxmath.tobyte(left) & maxmath.tobyte(right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator | (bool8 left, bool8 right) => maxmath.tobool(maxmath.tobyte(left) | maxmath.tobyte(right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator ^ (bool8 left, bool8 right) => maxmath.tobool(maxmath.tobyte(left) ^ maxmath.tobyte(right));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 operator ! (bool8 val)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.andnot_si128(val, new byte8(1));
            }
            else
            {
                return new bool8(!val.x0, !val.x1, !val.x2, !val.x3, !val.x4, !val.x5, !val.x6, !val.x7);
            }
        }


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, 8);

                return asArray[index];
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 8);

                asArray[index] = value;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool8 other) => maxmath.tobyte(this).Equals(maxmath.tobyte(other));

        public override bool Equals(object obj) => Equals((bool8)obj);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => maxmath.tobyte(this).GetHashCode();

        public override string ToString() => $"bool8({x0}, {x1}, {x2}, {x3},    {x4}, {x5}, {x6}, {x7})";
    }
}