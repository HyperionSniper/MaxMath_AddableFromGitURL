﻿using DevTools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.CompilerServices;
using Unity.Mathematics;
using Unity.Burst;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    [Serializable]   [StructLayout(LayoutKind.Sequential, Size = 16)]
    unsafe public struct bool16 : IEquatable<bool16>
    {
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x0;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x1;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x2;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x3;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x4;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x5;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x6;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x7;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x8;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x9;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x10;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x11;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x12;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x13;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x14;
        [NoAlias] [MarshalAs(UnmanagedType.U1)] public bool x15;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15)
        {
            this = Sse2.set_epi8(maxmath.toint8(x15),
                                 maxmath.toint8(x14),
                                 maxmath.toint8(x13),
                                 maxmath.toint8(x12),
                                 maxmath.toint8(x11),
                                 maxmath.toint8(x10),
                                 maxmath.toint8(x9),
                                 maxmath.toint8(x8),
                                 maxmath.toint8(x7),
                                 maxmath.toint8(x6),
                                 maxmath.toint8(x5),
                                 maxmath.toint8(x4),
                                 maxmath.toint8(x3),
                                 maxmath.toint8(x2),
                                 maxmath.toint8(x1),
                                 maxmath.toint8(x0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool x0x16)
        {
            this = new v128(maxmath.touint8(x0x16));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool2 x01, bool2 x23, bool2 x45, bool2 x67, bool2 x89, bool2 x10_11, bool2 x12_13, bool2 x14_15)
        {
            this = (v128)new byte16(*(byte2*)&x01, *(byte2*)&x23, *(byte2*)&x45, *(byte2*)&x67, *(byte2*)&x89, *(byte2*)&x10_11, *(byte2*)&x12_13, *(byte2*)&x14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool4 x0123, bool4 x4567, bool4 x8_9_10_11, bool4 x12_13_14_15)
        {
            this = (v128)new byte16(*(byte4*)&x0123, *(byte4*)&x4567, *(byte4*)&x8_9_10_11, *(byte4*)&x12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool4 x0123, bool3 x456, bool3 x789, bool3 x10_11_12, bool3 x13_14_15)
        {
            this = (v128)new byte16(*(byte4*)&x0123, *(byte3*)&x456, *(byte3*)&x789, *(byte3*)&x10_11_12, *(byte3*)&x13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool3 x012, bool4 x3456, bool3 x789, bool3 x10_11_12, bool3 x13_14_15)
        {
            this = (v128)new byte16(*(byte3*)&x012, *(byte4*)&x3456, *(byte3*)&x789, *(byte3*)&x10_11_12, *(byte3*)&x13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool3 x012, bool3 x345, bool4 x6789, bool3 x10_11_12, bool3 x13_14_15)
        {
            this = (v128)new byte16(*(byte3*)&x012, *(byte3*)&x345, *(byte4*)&x6789, *(byte3*)&x10_11_12, *(byte3*)&x13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool3 x012, bool3 x345, bool3 x678, bool4 x9_10_11_12, bool3 x13_14_15)
        {
            this = (v128)new byte16(*(byte3*)&x012, *(byte3*)&x345, *(byte3*)&x678, *(byte4*)&x9_10_11_12, *(byte3*)&x13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool3 x012, bool3 x345, bool3 x678, bool3 x9_10_11, bool4 x12_13_14_15)
        {
            this = (v128)new byte16(*(byte3*)&x012, *(byte3*)&x345, *(byte3*)&x678, *(byte3*)&x9_10_11, *(byte4*)&x12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool8 x01234567, bool4 x8_9_10_11, bool4 x12_13_14_15)
        {
            this = (v128)new byte16((v128)x01234567, *(byte4*)&x8_9_10_11, *(byte4*)&x12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool4 x0123, bool8 x4_5_6_7_8_9_10_11, bool4 x12_13_14_15)
        {
            this = (v128)new byte16(*(byte4*)&x0123, (v128)x4_5_6_7_8_9_10_11, *(byte4*)&x12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool4 x0123, bool4 x4567, bool8 x8_9_10_11_12_13_14_15)
        {
            this = (v128)new byte16(*(byte4*)&x0123, *(byte4*)&x4567, (v128)x8_9_10_11_12_13_14_15);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16(bool8 x01234567, bool8 x8_9_10_11_12_13_14_15)
        {
            this = (v128)new byte16(*(byte8*)&x01234567, (v128)x8_9_10_11_12_13_14_15);
        }


        public bool8 v8_0 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)this; }
        public bool8 v8_1 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_1; }
        public bool8 v8_2 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_2; }
        public bool8 v8_3 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_3; }
        public bool8 v8_4 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_4; }
        public bool8 v8_5 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_5; }
        public bool8 v8_6 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_6; }
        public bool8 v8_7 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_7; }
        public bool8 v8_8 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (v128)((byte16)(v128)this).v8_8; }
               
        public bool4 v4_0  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { bool16 t = this; return *(bool4*)&t; } }
        public bool4 v4_1  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_1;  return *(bool4*)&t; } }
        public bool4 v4_2  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_2;  return *(bool4*)&t; } }
        public bool4 v4_3  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_3;  return *(bool4*)&t; } }
        public bool4 v4_4  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_4;  return *(bool4*)&t; } }
        public bool4 v4_5  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_5;  return *(bool4*)&t; } }
        public bool4 v4_6  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_6;  return *(bool4*)&t; } }
        public bool4 v4_7  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_7;  return *(bool4*)&t; } }
        public bool4 v4_8  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_8;  return *(bool4*)&t; } }
        public bool4 v4_9  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_9;  return *(bool4*)&t; } }
        public bool4 v4_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_10; return *(bool4*)&t; } } 
        public bool4 v4_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_11; return *(bool4*)&t; } } 
        public bool4 v4_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte4 t = ((byte16)(v128)this).v4_12; return *(bool4*)&t; } }

        public bool3 v3_0  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { bool16 t = this; return *(bool3*)&t; } }
        public bool3 v3_1  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_1;  return *(bool3*)&t; } }
        public bool3 v3_2  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_2;  return *(bool3*)&t; } }
        public bool3 v3_3  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_3;  return *(bool3*)&t; } }
        public bool3 v3_4  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_4;  return *(bool3*)&t; } }
        public bool3 v3_5  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_5;  return *(bool3*)&t; } }
        public bool3 v3_6  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_6;  return *(bool3*)&t; } }
        public bool3 v3_7  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_7;  return *(bool3*)&t; } }
        public bool3 v3_8  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_8;  return *(bool3*)&t; } }
        public bool3 v3_9  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_9;  return *(bool3*)&t; } }
        public bool3 v3_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_10; return *(bool3*)&t; } } 
        public bool3 v3_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_11; return *(bool3*)&t; } } 
        public bool3 v3_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_12; return *(bool3*)&t; } }
        public bool3 v3_13 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte3 t = ((byte16)(v128)this).v3_13; return *(bool3*)&t; } }
                                                                                 
        public bool2 v2_0  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { bool16 t = this; return *(bool2*)&t; } }
        public bool2 v2_1  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_1;  return *(bool2*)&t; } }
        public bool2 v2_2  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_2;  return *(bool2*)&t; } }
        public bool2 v2_3  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_3;  return *(bool2*)&t; } }
        public bool2 v2_4  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_4;  return *(bool2*)&t; } }
        public bool2 v2_5  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_5;  return *(bool2*)&t; } }
        public bool2 v2_6  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_6;  return *(bool2*)&t; } }
        public bool2 v2_7  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_7;  return *(bool2*)&t; } }
        public bool2 v2_8  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_8;  return *(bool2*)&t; } }
        public bool2 v2_9  { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_9;  return *(bool2*)&t; } }
        public bool2 v2_10 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_10; return *(bool2*)&t; } } 
        public bool2 v2_11 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_11; return *(bool2*)&t; } } 
        public bool2 v2_12 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_12; return *(bool2*)&t; } }
        public bool2 v2_13 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_13; return *(bool2*)&t; } }
        public bool2 v2_14 { [MethodImpl(MethodImplOptions.AggressiveInlining)] get { byte2 t = ((byte16)(v128)this).v2_14; return *(bool2*)&t; } }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Sse4_1.stream_load_si128(void* ptr)   Sse.load_ps(void* ptr)
        public static implicit operator v128(bool16 input) => new v128(*(byte*)&input.x0, *(byte*)&input.x1, *(byte*)&input.x2, *(byte*)&input.x3, *(byte*)&input.x4, *(byte*)&input.x5, *(byte*)&input.x6, *(byte*)&input.x7, *(byte*)&input.x8, *(byte*)&input.x9, *(byte*)&input.x10, *(byte*)&input.x11, *(byte*)&input.x12, *(byte*)&input.x13, *(byte*)&input.x14, *(byte*)&input.x15);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Sse.store_ps(void* ptr, v128 x)
        public static implicit operator bool16(v128 input) => new bool16 { x0 = maxmath.tobool(input.Byte0), x1 = maxmath.tobool(input.Byte1), x2 = maxmath.tobool(input.Byte2), x3 = maxmath.tobool(input.Byte3), x4 = maxmath.tobool(input.Byte4), x5 = maxmath.tobool(input.Byte5), x6 = maxmath.tobool(input.Byte6), x7 = maxmath.tobool(input.Byte7), x8 = maxmath.tobool(input.Byte8), x9 = maxmath.tobool(input.Byte9), x10 = maxmath.tobool(input.Byte10), x11 = maxmath.tobool(input.Byte11), x12 = maxmath.tobool(input.Byte12), x13 = maxmath.tobool(input.Byte13), x14 = maxmath.tobool(input.Byte14), x15 = maxmath.tobool(input.Byte15)};

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool16(bool x) => new bool16(x);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator == (bool16 left, bool16 right) => Sse2.and_si128(new v128((byte)1), Sse2.cmpeq_epi8(left, right));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator != (bool16 left, bool16 right) => Sse2.andnot_si128(Sse2.cmpeq_epi8(left, right), new v128((byte)1));


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator & (bool16 left, bool16 right) => Sse2.and_si128(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator | (bool16 left, bool16 right) => Sse2.or_si128(left, right);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator ^ (bool16 left, bool16 right) => Sse2.xor_si128(left, right);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool16 operator ! (bool16 val) => Sse2.andnot_si128(val, new v128((byte)1));


        public bool this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, 16);
                
                fixed (void* ptr = &this)
                {
                    return ((bool*)ptr)[index];
                }
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 16);

                fixed (void* ptr = &this)
                {
                    ((bool*)ptr)[index] = value;
                }
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool16 other) => maxmath.bitmask32(16 * sizeof(bool)) == Sse2.movemask_epi8(Sse2.cmpeq_epi8(this, other));

        public override bool Equals(object obj) => Equals((bool16)obj);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() => Sse2.movemask_epi8(Sse2.slli_epi16(this, 7));

        public override string ToString() => $"bool16({x0}, {x1}, {x2}, {x3},    {x4}, {x5}, {x6}, {x7},    {x8}, {x9}, {x10}, {x11},    {x12}, {x13}, {x14}, {x15})";
    }
}