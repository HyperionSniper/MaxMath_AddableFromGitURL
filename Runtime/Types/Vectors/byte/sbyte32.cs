﻿using DevTools;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Explicit, Size = 32 * sizeof(sbyte))]  [DebuggerTypeProxy(typeof(sbyte32.DebuggerProxy))]
    unsafe public struct sbyte32 : IEquatable<sbyte32>, IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public sbyte x0;
            public sbyte x1;
            public sbyte x2;
            public sbyte x3;
            public sbyte x4;
            public sbyte x5;
            public sbyte x6;
            public sbyte x7;
            public sbyte x8;
            public sbyte x9;
            public sbyte x10;
            public sbyte x11;
            public sbyte x12;
            public sbyte x13;
            public sbyte x14;
            public sbyte x15;
            public sbyte x16;
            public sbyte x17;
            public sbyte x18;
            public sbyte x19;
            public sbyte x20;
            public sbyte x21;
            public sbyte x22;
            public sbyte x23;
            public sbyte x24;
            public sbyte x25;
            public sbyte x26;
            public sbyte x27;
            public sbyte x28;
            public sbyte x29;
            public sbyte x30;
            public sbyte x31;

            public DebuggerProxy(sbyte32 v)
            {
                x0  = v.x0;
                x1  = v.x1;
                x2  = v.x2;
                x3  = v.x3;
                x4  = v.x4;
                x5  = v.x5;
                x6  = v.x6;
                x7  = v.x7;
                x8  = v.x8;
                x9  = v.x9;
                x10 = v.x10;
                x11 = v.x11;
                x12 = v.x12;
                x13 = v.x13;
                x14 = v.x14;
                x15 = v.x15;
                x16 = v.x16;
                x17 = v.x17;
                x18 = v.x18;
                x19 = v.x19;
                x20 = v.x20;
                x21 = v.x21;
                x22 = v.x22;
                x23 = v.x23;
                x24 = v.x24;
                x25 = v.x25;
                x26 = v.x26;
                x27 = v.x27;
                x28 = v.x28;
                x29 = v.x29;
                x30 = v.x30;
                x31 = v.x31;
            }
        }


        [FieldOffset(0)]  private fixed sbyte asArray[32];

        [FieldOffset(0)]  internal sbyte16 _v16_0;
        [FieldOffset(16)] internal sbyte16 _v16_16;

        [FieldOffset(0)]  public sbyte x0;
        [FieldOffset(1)]  public sbyte x1;
        [FieldOffset(2)]  public sbyte x2;
        [FieldOffset(3)]  public sbyte x3;
        [FieldOffset(4)]  public sbyte x4;
        [FieldOffset(5)]  public sbyte x5;
        [FieldOffset(6)]  public sbyte x6;
        [FieldOffset(7)]  public sbyte x7;
        [FieldOffset(8)]  public sbyte x8;
        [FieldOffset(9)]  public sbyte x9;
        [FieldOffset(10)] public sbyte x10;
        [FieldOffset(11)] public sbyte x11;
        [FieldOffset(12)] public sbyte x12;
        [FieldOffset(13)] public sbyte x13;
        [FieldOffset(14)] public sbyte x14;
        [FieldOffset(15)] public sbyte x15;
        [FieldOffset(16)] public sbyte x16;
        [FieldOffset(17)] public sbyte x17;
        [FieldOffset(18)] public sbyte x18;
        [FieldOffset(19)] public sbyte x19;
        [FieldOffset(20)] public sbyte x20;
        [FieldOffset(21)] public sbyte x21;
        [FieldOffset(22)] public sbyte x22;
        [FieldOffset(23)] public sbyte x23;
        [FieldOffset(24)] public sbyte x24;
        [FieldOffset(25)] public sbyte x25;
        [FieldOffset(26)] public sbyte x26;
        [FieldOffset(27)] public sbyte x27;
        [FieldOffset(28)] public sbyte x28;
        [FieldOffset(29)] public sbyte x29;
        [FieldOffset(30)] public sbyte x30;
        [FieldOffset(31)] public sbyte x31;


        public static sbyte32 zero => default;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte x0, sbyte x1, sbyte x2, sbyte x3, sbyte x4, sbyte x5, sbyte x6, sbyte x7, sbyte x8, sbyte x9, sbyte x10, sbyte x11, sbyte x12, sbyte x13, sbyte x14, sbyte x15, sbyte x16, sbyte x17, sbyte x18, sbyte x19, sbyte x20, sbyte x21, sbyte x22, sbyte x23, sbyte x24, sbyte x25, sbyte x26, sbyte x27, sbyte x28, sbyte x29, sbyte x30, sbyte x31)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_set_epi8((byte)x31, (byte)x30, (byte)x29, (byte)x28, (byte)x27, (byte)x26, (byte)x25, (byte)x24, (byte)x23, (byte)x22, (byte)x21, (byte)x20, (byte)x19, (byte)x18, (byte)x17, (byte)x16, (byte)x15, (byte)x14, (byte)x13, (byte)x12, (byte)x11, (byte)x10, (byte)x9, (byte)x8, (byte)x7, (byte)x6, (byte)x5, (byte)x4, (byte)x3, (byte)x2, (byte)x1, (byte)x0);
            }
            else
            {
                this = new sbyte32
                {
                    _v16_0 = new sbyte16(x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15),
                    _v16_16 = new sbyte16(x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31)
                };
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte x0x32)
        {
            if (Avx.IsAvxSupported)
            {
                this = new v256(x0x32);
            }
            else
            {
                this = new sbyte32
                {
                    _v16_0 = new sbyte16(x0x32),
                    _v16_16 = new sbyte16(x0x32)
                };
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte8 v8_0, sbyte8 v8_8, sbyte8 v8_16, sbyte8 v8_24)
        {
            this = new sbyte32(new sbyte16(v8_0, v8_8), new sbyte16(v8_16, v8_24));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte16 v16_0, sbyte8 v8_16, sbyte8 v8_24)
        {
            this = new sbyte32(v16_0, new sbyte16(v8_16, v8_24));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte8 v8_0, sbyte16 v16_8, sbyte8 v8_24)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 mid = Avx2.mm256_permute4x64_epi64(Avx.mm256_castsi128_si256(v16_8), Sse.SHUFFLE(0, 1, 0, 0));
                mid = Avx.mm256_insert_epi64(mid, *(long*)&v8_0, 0);
                this = Avx.mm256_insert_epi64(mid, *(long*)&v8_24, 3);
            }
            else
            {
                this = new sbyte32(new sbyte16(v8_0, v16_8.v8_0), new sbyte16(v16_8.v8_8, v8_24));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte8 v8_0, sbyte8 v8_8, sbyte16 v16_16)
        {
            this = new sbyte32(new sbyte16(v8_0, v8_8), v16_16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte32(sbyte16 v16_0, sbyte16 v16_16)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_set_m128i(v16_16, v16_0);
            }
            else
            {
                this = new sbyte32
                {
                    _v16_0 = v16_0,
                    _v16_16 = v16_16
                };
            }
        }


        
        #region Shuffle
        public sbyte16 v16_0
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    return Avx.mm256_castsi256_si128(this);
                }
                else
                {
                    return _v16_0;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_inserti128_si256(this, value, 0);
                }
                else
                {
                    this._v16_0 = value;
                }
            }
        }
        public sbyte16 v16_1
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse4_1.insert_epi8(Sse2.bsrli_si128(v16_0, sizeof(sbyte)), (byte)Avx2.mm256_extract_epi8(this, 16), 15);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  sizeof(sbyte)), 
                                       Sse2.bslli_si128(_v16_16, 15 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                }
                else
                {
                    return new sbyte16(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, sizeof(sbyte)), Sse2.bsrli_si128(value, 15 * sizeof(sbyte)));
                    v256 mask = new v256(0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value,      sizeof(sbyte)), new v128(0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value, 15 * sizeof(sbyte)), new v128(255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x1  = value.x0;
                    this.x2  = value.x1;
                    this.x3  = value.x2;
                    this.x4  = value.x3;
                    this.x5  = value.x4;
                    this.x6  = value.x5;
                    this.x7  = value.x6;
                    this.x8  = value.x7;
                    this.x9  = value.x8;
                    this.x10 = value.x9;
                    this.x11 = value.x10;
                    this.x12 = value.x11;
                    this.x13 = value.x12;
                    this.x14 = value.x13;
                    this.x15 = value.x14;
                    this.x16 = value.x15;
                }
            }
        }
        public sbyte16 v16_2
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.insert_epi16(Sse2.bsrli_si128(v16_0, 2 * sizeof(sbyte)), (short)Avx2.mm256_extract_epi16(this, 8), 7);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(_v16_0,  2 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(_v16_16, 14 * sizeof(sbyte)),
                                           0b1000_0000);
                }
                else
                {
                    return new sbyte16(x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 2 * sizeof(sbyte)), Sse2.bsrli_si128(value, 14 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value,  2 * sizeof(sbyte)), 0b1111_1110);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value, 14 * sizeof(sbyte)), 0b0000_0001);
                }
                else
                {
                    this.x2  = value.x0;
                    this.x3  = value.x1;
                    this.x4  = value.x2;
                    this.x5  = value.x3;
                    this.x6  = value.x4;
                    this.x7  = value.x5;
                    this.x8  = value.x6;
                    this.x9  = value.x7;
                    this.x10 = value.x8;
                    this.x11 = value.x9;
                    this.x12 = value.x10;
                    this.x13 = value.x11;
                    this.x14 = value.x12;
                    this.x15 = value.x13;
                    this.x16 = value.x14;
                    this.x17 = value.x15;
                }

            }
        }
        public sbyte16 v16_3
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  3 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 13 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 3 * sizeof(sbyte)), Sse2.bsrli_si128(value, 13 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value,  3 * sizeof(sbyte)), new v128(0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value, 13 * sizeof(sbyte)), new v128(255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x3  = value.x0;
                    this.x4  = value.x1;
                    this.x5  = value.x2;
                    this.x6  = value.x3;
                    this.x7  = value.x4;
                    this.x8  = value.x5;
                    this.x9  = value.x6;
                    this.x10 = value.x7;
                    this.x11 = value.x8;
                    this.x12 = value.x9;
                    this.x13 = value.x10;
                    this.x14 = value.x11;
                    this.x15 = value.x12;
                    this.x16 = value.x13;
                    this.x17 = value.x14;
                    this.x18 = value.x15;
                }
            }
        }
        public sbyte16 v16_4
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse4_1.insert_epi32(Sse2.bsrli_si128(v16_0, 4 * sizeof(sbyte)), Avx.mm256_extract_epi32(this, 4), 3);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(_v16_0,  4 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(_v16_16, 12 * sizeof(sbyte)),
                                           0b1100_0000);
                }
                else
                {
                    return new sbyte16(x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 4 * sizeof(sbyte)), Sse2.bsrli_si128(value, 12 * sizeof(sbyte)));

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0001_1110);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value,  4 * sizeof(sbyte)), 0b1111_1100);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value, 12 * sizeof(sbyte)), 0b0000_0011);
                }
                else
                {
                    this.x4  = value.x0;
                    this.x5  = value.x1;
                    this.x6  = value.x2;
                    this.x7  = value.x3;
                    this.x8  = value.x4;
                    this.x9  = value.x5;
                    this.x10 = value.x6;
                    this.x11 = value.x7;
                    this.x12 = value.x8;
                    this.x13 = value.x9;
                    this.x14 = value.x10;
                    this.x15 = value.x11;
                    this.x16 = value.x12;
                    this.x17 = value.x13;
                    this.x18 = value.x14;
                    this.x19 = value.x15;
                }
            }
        }
        public sbyte16 v16_5
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  5 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 11 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 5 * sizeof(sbyte)), Sse2.bsrli_si128(value, 11 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value,  5 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value, 11 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x5  = value.x0;
                    this.x6  = value.x1;
                    this.x7  = value.x2;
                    this.x8  = value.x3;
                    this.x9  = value.x4;
                    this.x10 = value.x5;
                    this.x11 = value.x6;
                    this.x12 = value.x7;
                    this.x13 = value.x8;
                    this.x14 = value.x9;
                    this.x15 = value.x10;
                    this.x16 = value.x11;
                    this.x17 = value.x12;
                    this.x18 = value.x13;
                    this.x19 = value.x14;
                    this.x20 = value.x15;
                }
            }
        }
        public sbyte16 v16_6
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(v16_0,  6 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(v16_16, 10 * sizeof(sbyte)),
                                           0b1110_0000);
                }
                else
                {
                    return new sbyte16(x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 6 * sizeof(sbyte)), Sse2.bsrli_si128(value, 10 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value,  6 * sizeof(sbyte)), 0b1111_1000);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value, 10 * sizeof(sbyte)), 0b0000_0111);
                }
                else
                {
                    this.x6  = value.x0;
                    this.x7  = value.x1;
                    this.x8  = value.x2;
                    this.x9  = value.x3;
                    this.x10 = value.x4;
                    this.x11 = value.x5;
                    this.x12 = value.x6;
                    this.x13 = value.x7;
                    this.x14 = value.x8;
                    this.x15 = value.x9;
                    this.x16 = value.x10;
                    this.x17 = value.x11;
                    this.x18 = value.x12;
                    this.x19 = value.x13;
                    this.x20 = value.x14;
                    this.x21 = value.x15;
                }
            }
        }
        public sbyte16 v16_7
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  7 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 9 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 7 * sizeof(sbyte)), Sse2.bsrli_si128(value, 9 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value,  7 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value,  9 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x7  = value.x0;
                    this.x8  = value.x1;
                    this.x9  = value.x2;
                    this.x10 = value.x3;
                    this.x11 = value.x4;
                    this.x12 = value.x5;
                    this.x13 = value.x6;
                    this.x14 = value.x7;
                    this.x15 = value.x8;
                    this.x16 = value.x9;
                    this.x17 = value.x10;
                    this.x18 = value.x11;
                    this.x19 = value.x12;
                    this.x20 = value.x13;
                    this.x21 = value.x14;
                    this.x22 = value.x15;
                }
            }
        }
        public sbyte16 v16_8
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse4_1.insert_epi64(Sse2.bsrli_si128(v16_0, 8 * sizeof(sbyte)), Avx.mm256_extract_epi64(this, 2), 1);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Sse2.unpacklo_epi64(Sse2.bsrli_si128(_v16_0,  8 * sizeof(sbyte)), _v16_16);
                }
                else
                {
                    return new sbyte16(x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 8 * sizeof(sbyte)), Sse2.bsrli_si128(value, 8 * sizeof(sbyte)));

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0011_1100);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value,  8 * sizeof(sbyte)), 0b1111_0000);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value,  8 * sizeof(sbyte)), 0b0000_1111);
                }
                else
                {
                    this.x8  = value.x0;
                    this.x9  = value.x1;
                    this.x10 = value.x2;
                    this.x11 = value.x3;
                    this.x12 = value.x4;
                    this.x13 = value.x5;
                    this.x14 = value.x6;
                    this.x15 = value.x7;
                    this.x16 = value.x8;
                    this.x17 = value.x9;
                    this.x18 = value.x10;
                    this.x19 = value.x11;
                    this.x20 = value.x12;
                    this.x21 = value.x13;
                    this.x22 = value.x14;
                    this.x23 = value.x15;
                }
            }
        }
        public sbyte16 v16_9
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  9 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 7 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 9 * sizeof(sbyte)), Sse2.bsrli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value,  9 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value,  7 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x9  = value.x0;
                    this.x10 = value.x1;
                    this.x11 = value.x2;
                    this.x12 = value.x3;
                    this.x13 = value.x4;
                    this.x14 = value.x5;
                    this.x15 = value.x6;
                    this.x16 = value.x7;
                    this.x17 = value.x8;
                    this.x18 = value.x9;
                    this.x19 = value.x10;
                    this.x20 = value.x11;
                    this.x21 = value.x12;
                    this.x22 = value.x13;
                    this.x23 = value.x14;
                    this.x24 = value.x15;
                }
            }
        }
        public sbyte16 v16_10
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(v16_0,  10 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(v16_16, 6 * sizeof(sbyte)),
                                           0b1111_1000);
                }
                else
                {
                    return new sbyte16(x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 10 * sizeof(sbyte)), Sse2.bsrli_si128(value, 6 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value, 10 * sizeof(sbyte)), 0b1110_0000);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value,  6 * sizeof(sbyte)), 0b0001_1111);
                }
                else
                {
                    this.x10 = value.x0;
                    this.x11 = value.x1;
                    this.x12 = value.x2;
                    this.x13 = value.x3;
                    this.x14 = value.x4;
                    this.x15 = value.x5;
                    this.x16 = value.x6;
                    this.x17 = value.x7;
                    this.x18 = value.x8;
                    this.x19 = value.x9;
                    this.x20 = value.x10;
                    this.x21 = value.x11;
                    this.x22 = value.x12;
                    this.x23 = value.x13;
                    this.x24 = value.x14;
                    this.x25 = value.x15;
                }
            }
        }
        public sbyte16 v16_11
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  11 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 5 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 11 * sizeof(sbyte)), Sse2.bsrli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value, 11 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value,  5 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x11 = value.x0;
                    this.x12 = value.x1;
                    this.x13 = value.x2;
                    this.x14 = value.x3;
                    this.x15 = value.x4;
                    this.x16 = value.x5;
                    this.x17 = value.x6;
                    this.x18 = value.x7;
                    this.x19 = value.x8;
                    this.x20 = value.x9;
                    this.x21 = value.x10;
                    this.x22 = value.x11;
                    this.x23 = value.x12;
                    this.x24 = value.x13;
                    this.x25 = value.x14;
                    this.x26 = value.x15;
                }
            }
        }
        public sbyte16 v16_12
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse4_1.insert_epi32(Sse2.bslli_si128(v16_16, 4 * sizeof(sbyte)), Avx.mm256_extract_epi32(this, 3), 0);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(_v16_0,  12 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(_v16_16, 4 * sizeof(sbyte)),
                                           0b1111_1100);
                }
                else
                {
                    return new sbyte16(x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 12 * sizeof(sbyte)), Sse2.bsrli_si128(value, 4 * sizeof(sbyte)));

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0111_1000);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value, 12 * sizeof(sbyte)), 0b1100_0000);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value,  4 * sizeof(sbyte)), 0b0011_1111);
                }
                else
                {
                    this.x12 = value.x0;
                    this.x13 = value.x1;
                    this.x14 = value.x2;
                    this.x15 = value.x3;
                    this.x16 = value.x4;
                    this.x17 = value.x5;
                    this.x18 = value.x6;
                    this.x19 = value.x7;
                    this.x20 = value.x8;
                    this.x21 = value.x9;
                    this.x22 = value.x10;
                    this.x23 = value.x11;
                    this.x24 = value.x12;
                    this.x25 = value.x13;
                    this.x26 = value.x14;
                    this.x27 = value.x15;
                }
            }
        }
        public sbyte16 v16_13
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(v16_0,  13 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(v16_16, 3 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 13 * sizeof(sbyte)), Sse2.bsrli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value, 13 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value,  3 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0));
                }
                else
                {
                    this.x13 = value.x0;
                    this.x14 = value.x1;
                    this.x15 = value.x2;
                    this.x16 = value.x3;
                    this.x17 = value.x4;
                    this.x18 = value.x5;
                    this.x19 = value.x6;
                    this.x20 = value.x7;
                    this.x21 = value.x8;
                    this.x22 = value.x9;
                    this.x23 = value.x10;
                    this.x24 = value.x11;
                    this.x25 = value.x12;
                    this.x26 = value.x13;
                    this.x27 = value.x14;
                    this.x28 = value.x15;
                }
            }
        }
        public sbyte16 v16_14
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.insert_epi16(Sse2.bslli_si128(v16_16, 2 * sizeof(sbyte)), Avx2.mm256_extract_epi16(this, 7), 0);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(_v16_0,  14 * sizeof(sbyte)), 
                                           Sse2.bslli_si128(_v16_16, 2 * sizeof(sbyte)),
                                           0b1111_1110);
                }
                else
                {
                    return new sbyte16(x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 14 * sizeof(sbyte)), Sse2.bsrli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendEpi16(_v16_0,  Sse2.bslli_si128(value, 14 * sizeof(sbyte)), 0b1000_0000);
                    this._v16_16 = Mask.BlendEpi16(_v16_16, Sse2.bsrli_si128(value,  2 * sizeof(sbyte)), 0b0111_1111);
                }
                else
                {
                    this.x14 = value.x0;
                    this.x15 = value.x1;
                    this.x16 = value.x2;
                    this.x17 = value.x3;
                    this.x18 = value.x4;
                    this.x19 = value.x5;
                    this.x20 = value.x6;
                    this.x21 = value.x7;
                    this.x22 = value.x8;
                    this.x23 = value.x9;
                    this.x24 = value.x10;
                    this.x25 = value.x11;
                    this.x26 = value.x12;
                    this.x27 = value.x13;
                    this.x28 = value.x14;
                    this.x29 = value.x15;
                }
            }
        }
        public sbyte16 v16_15
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse4_1.insert_epi8(Sse2.bslli_si128(v16_16, sizeof(sbyte)), (byte)Avx2.mm256_extract_epi8(this, 15), 0);
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  15 * sizeof(sbyte)), 
                                       Sse2.bslli_si128(_v16_16, sizeof(sbyte)),
                                       new v128(0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte16(x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 15 * sizeof(sbyte)), Sse2.bsrli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(_v16_0,  Sse2.bslli_si128(value, 15 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                    this._v16_16 = Mask.BlendV(_v16_16, Sse2.bsrli_si128(value,      sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 0));
                }
                else
                {
                    this.x15 = value.x0;
                    this.x16 = value.x1;
                    this.x17 = value.x2;
                    this.x18 = value.x3;
                    this.x19 = value.x4;
                    this.x20 = value.x5;
                    this.x21 = value.x6;
                    this.x22 = value.x7;
                    this.x23 = value.x8;
                    this.x24 = value.x9;
                    this.x25 = value.x10;
                    this.x26 = value.x11;
                    this.x27 = value.x12;
                    this.x28 = value.x13;
                    this.x29 = value.x14;
                    this.x30 = value.x15;
                }
            }
        }
        public sbyte16 v16_16
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_extracti128_si256(this, 1);
                }
                else
                {
                    return _v16_16;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_inserti128_si256(this, value, 1);
                }
                else
                {
                    this._v16_16 = value;
                }
            }
        }

        public sbyte8 v8_0
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_0;
                }
                else
                {
                    return new sbyte8(x0, x1, x2, x3, x4, x5, x6, x7);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx.mm256_insert_epi64(this, *(long*)&value, 0);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_0 = value;
                }
                else
                {
                    this.x0  = value.x0;
                    this.x1  = value.x1;
                    this.x2  = value.x2;
                    this.x3  = value.x3;
                    this.x4  = value.x4;
                    this.x5  = value.x5;
                    this.x6  = value.x6;
                    this.x7  = value.x7;
                }
            }
        }
        public sbyte8 v8_1
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_1;
                }
                else
                {
                    return new sbyte8(x1, x2, x3, x4, x5, x6, x7, x8);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_1 = value;
                }
                else
                {
                    this.x1  = value.x0;
                    this.x2  = value.x1;
                    this.x3  = value.x2;
                    this.x4  = value.x3;
                    this.x5  = value.x4;
                    this.x6  = value.x5;
                    this.x7  = value.x6;
                    this.x8  = value.x7;
                }
            }
        }
        public sbyte8 v8_2
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_2;
                }
                else
                {
                    return new sbyte8(x2, x3, x4, x5, x6, x7, x8, x9);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_2 = value;
                }
                else
                {
                    this.x2  = value.x0;
                    this.x3  = value.x1;
                    this.x4  = value.x2;
                    this.x5  = value.x3;
                    this.x6  = value.x4;
                    this.x7  = value.x5;
                    this.x8  = value.x6;
                    this.x9  = value.x7;
                }
            }
        }
        public sbyte8 v8_3
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_3;
                }
                else
                {
                    return new sbyte8(x3, x4, x5, x6, x7, x8, x9, x10);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_3 = value;
                }
                else
                {
                    this.x3  = value.x0;
                    this.x4  = value.x1;
                    this.x5  = value.x2;
                    this.x6  = value.x3;
                    this.x7  = value.x4;
                    this.x8  = value.x5;
                    this.x9  = value.x6;
                    this.x10 = value.x7;
                }
            }
        }
        public sbyte8 v8_4
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_4;
                }
                else
                {
                    return new sbyte8(x4, x5, x6, x7, x8, x9, x10, x11);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 4 * sizeof(sbyte)));

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0000_0110);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_4 = value;
                }
                else
                {
                    this.x4  = value.x0;
                    this.x5  = value.x1;
                    this.x6  = value.x2;
                    this.x7  = value.x3;
                    this.x8  = value.x4;
                    this.x9  = value.x5;
                    this.x10 = value.x6;
                    this.x11 = value.x7;
                }
            }
        }
        public sbyte8 v8_5
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_5;
                }
                else
                {
                    return new sbyte8(x5, x6, x7, x8, x9, x10, x11, x12);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_5 = value;
                }
                else
                {
                    this.x5  = value.x0;
                    this.x6  = value.x1;
                    this.x7  = value.x2;
                    this.x8  = value.x3;
                    this.x9  = value.x4;
                    this.x10 = value.x5;
                    this.x11 = value.x6;
                    this.x12 = value.x7;
                }
            }
        }
        public sbyte8 v8_6
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_6;
                }
                else
                {
                    return new sbyte8(x6, x7, x8, x9, x10, x11, x12, x13);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 6 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_6 = value;
                }
                else
                {
                    this.x6  = value.x0;
                    this.x7  = value.x1;
                    this.x8  = value.x2;
                    this.x9  = value.x3;
                    this.x10 = value.x4;
                    this.x11 = value.x5;
                    this.x12 = value.x6;
                    this.x13 = value.x7;
                }
            }
        }
        public sbyte8 v8_7
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_7;
                }
                else
                {
                    return new sbyte8(x7, x8, x9, x10, x11, x12, x13, x14);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_7 = value;
                }
                else
                {
                    this.x7  = value.x0;
                    this.x8  = value.x1;
                    this.x9  = value.x2;
                    this.x10 = value.x3;
                    this.x11 = value.x4;
                    this.x12 = value.x5;
                    this.x13 = value.x6;
                    this.x14 = value.x7;
                }
            }
        }
        public sbyte8 v8_8
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v8_8;
                }
                else
                {
                    return new sbyte8(x8, x9, x10, x11, x12, x13, x14, x15);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx.mm256_insert_epi64(this, *(long*)&value, 1);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v8_8 = value;
                }
                else
                {
                    this.x8  = value.x0;
                    this.x9  = value.x1;
                    this.x10 = value.x2;
                    this.x11 = value.x3;
                    this.x12 = value.x4;
                    this.x13 = value.x5;
                    this.x14 = value.x6;
                    this.x15 = value.x7;
                }
            }
        }
        public sbyte8 v8_9
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  9 * sizeof(sbyte)),
                                       Sse2.bslli_si128(_v16_16, 7 * sizeof(sbyte)),
                                       new v128(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 255));
                }
                else
                {
                    return new sbyte8(x9, x10, x11, x12, x13, x14, x15, x16);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 9 * sizeof(sbyte)), Sse2.bsrli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 9 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value, 7 * sizeof(sbyte)), new v128(255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x9  = value.x0;
                    this.x10 = value.x1;
                    this.x11 = value.x2;
                    this.x12 = value.x3;
                    this.x13 = value.x4;
                    this.x14 = value.x5;
                    this.x15 = value.x6;
                    this.x16 = value.x7;
                }
            }
        }
        public sbyte8 v8_10
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, 2 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendEpi16(Sse2.bsrli_si128(_v16_0,  10 * sizeof(sbyte)),
                                           Sse2.bslli_si128(_v16_16, 6 * sizeof(sbyte)),
                                           0b1111_1000);
                }
                else
                {
                    return new sbyte8(x10, x11, x12, x13, x14, x15, x16, x17);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 10 * sizeof(sbyte)), Sse2.bsrli_si128(value, 6 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 10 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  6 * sizeof(sbyte)), new v128(255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x10 = value.x0;
                    this.x11 = value.x1;
                    this.x12 = value.x2;
                    this.x13 = value.x3;
                    this.x14 = value.x4;
                    this.x15 = value.x5;
                    this.x16 = value.x6;
                    this.x17 = value.x7;
                }
            }
        }
        public sbyte8 v8_11
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, 3 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_11.v8_0;
                }
                else
                {
                    return new sbyte8(x11, x12, x13, x14, x15, x16, x17, x18);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 11 * sizeof(sbyte)), Sse2.bsrli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 11 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  5 * sizeof(sbyte)), new v128(255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x11 = value.x0;
                    this.x12 = value.x1;
                    this.x13 = value.x2;
                    this.x14 = value.x3;
                    this.x15 = value.x4;
                    this.x16 = value.x5;
                    this.x17 = value.x6;
                    this.x18 = value.x7;
                }
            }
        }
        public sbyte8 v8_12
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permutevar8x32_epi32(this, Avx.mm256_castsi128_si256(new v128(3, 4, 0, 0))));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Sse2.unpacklo_epi32(Sse2.bsrli_si128(_v16_0, 12 * sizeof(sbyte)), _v16_16);
                }
                else
                {
                    return new sbyte8(x12, x13, x14, x15, x16, x17, x18, x19);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 12 * sizeof(sbyte)), Sse2.bsrli_si128(value, 4 * sizeof(sbyte)));

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0001_1000);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 12 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  4 * sizeof(sbyte)), new v128(255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x12 = value.x0;
                    this.x13 = value.x1;
                    this.x14 = value.x2;
                    this.x15 = value.x3;
                    this.x16 = value.x4;
                    this.x17 = value.x5;
                    this.x18 = value.x6;
                    this.x19 = value.x7;
                }
            }
        }
        public sbyte8 v8_13
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, 5 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_13.v8_0;
                }
                else
                {
                    return new sbyte8(x13, x14, x15, x16, x17, x18, x19, x20);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 13 * sizeof(sbyte)), Sse2.bsrli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 13 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  3 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x13 = value.x0;
                    this.x14 = value.x1;
                    this.x15 = value.x2;
                    this.x16 = value.x3;
                    this.x17 = value.x4;
                    this.x18 = value.x5;
                    this.x19 = value.x6;
                    this.x20 = value.x7;
                }
            }
        }
        public sbyte8 v8_14
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, 6 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_14.v8_0;
                }
                else
                {
                    return new sbyte8(x14, x15, x16, x17, x18, x19, x20, x21);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 14 * sizeof(sbyte)), Sse2.bsrli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 14 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  2 * sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x14 = value.x0;
                    this.x15 = value.x1;
                    this.x16 = value.x2;
                    this.x17 = value.x3;
                    this.x18 = value.x4;
                    this.x19 = value.x5;
                    this.x20 = value.x6;
                    this.x21 = value.x7;
                }
            }
        }
        public sbyte8 v8_15
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1)));

                    return Sse2.bsrli_si128(perm, 7 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_15.v8_0;
                }
                else
                {
                    return new sbyte8(x15, x16, x17, x18, x19, x20, x21, x22);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 15 * sizeof(sbyte)), Sse2.bsrli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 15 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,      sizeof(sbyte)), new v128(255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x15 = value.x0;
                    this.x16 = value.x1;
                    this.x17 = value.x2;
                    this.x18 = value.x3;
                    this.x19 = value.x4;
                    this.x20 = value.x5;
                    this.x21 = value.x6;
                    this.x22 = value.x7;
                }
            }
        }
        public sbyte8 v8_16
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_0;
                }
                else
                {
                    return new sbyte8(x16, x17, x18, x19, x20, x21, x22, x23);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi64(this, *(long*)&value, 2);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_0 = value;
                }
                else
                {
                    this.x16 = value.x0;
                    this.x17 = value.x1;
                    this.x18 = value.x2;
                    this.x19 = value.x3;
                    this.x20 = value.x4;
                    this.x21 = value.x5;
                    this.x22 = value.x6;
                    this.x23 = value.x7;
                }
            }
        }
        public sbyte8 v8_17
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_1;
                }
                else
                {
                    return new sbyte8(x17, x18, x19, x20, x21, x22, x23, x24);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_1 = value;
                }
                else
                {
                    this.x17 = value.x0;
                    this.x18 = value.x1;
                    this.x19 = value.x2;
                    this.x20 = value.x3;
                    this.x21 = value.x4;
                    this.x22 = value.x5;
                    this.x23 = value.x6;
                    this.x24 = value.x7;
                }
            }
        }
        public sbyte8 v8_18
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, 2 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_2;
                }
                else
                {
                    return new sbyte8(x18, x19, x20, x21, x22, x23, x24, x25);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 2 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_2 = value;
                }
                else
                {
                    this.x18 = value.x0;
                    this.x19 = value.x1;
                    this.x20 = value.x2;
                    this.x21 = value.x3;
                    this.x22 = value.x4;
                    this.x23 = value.x5;
                    this.x24 = value.x6;
                    this.x25 = value.x7;
                }
            }
        }
        public sbyte8 v8_19
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, 3 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_3;
                }
                else
                {
                    return new sbyte8(x19, x20, x21, x22, x23, x24, x25, x26);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 3 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_3 = value;
                }
                else
                {
                    this.x19 = value.x0;
                    this.x20 = value.x1;
                    this.x21 = value.x2;
                    this.x22 = value.x3;
                    this.x23 = value.x4;
                    this.x24 = value.x5;
                    this.x25 = value.x6;
                    this.x26 = value.x7;
                }
            }
        }
        public sbyte8 v8_20
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permutevar8x32_epi32(this, Avx.mm256_castsi128_si256(new v128(5, 6, 0, 0))));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_4;
                }
                else
                {
                    return new sbyte8(x20, x21, x22, x23, x24, x25, x26, x27);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 4 * sizeof(sbyte)), 1);

                    this = Avx2.mm256_blend_epi32(this, blend, 0b0110_0000);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_4 = value;
                }
                else
                {
                    this.x20 = value.x0;
                    this.x21 = value.x1;
                    this.x22 = value.x2;
                    this.x23 = value.x3;
                    this.x24 = value.x4;
                    this.x25 = value.x5;
                    this.x26 = value.x6;
                    this.x27 = value.x7;
                }
            }
        }
        public sbyte8 v8_21
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, 5 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_5;
                }
                else
                {
                    return new sbyte8(x21, x22, x23, x24, x25, x26, x27, x28);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 5 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_5 = value;
                }
                else
                {
                    this.x21 = value.x0;
                    this.x22 = value.x1;
                    this.x23 = value.x2;
                    this.x24 = value.x3;
                    this.x25 = value.x4;
                    this.x26 = value.x5;
                    this.x27 = value.x6;
                    this.x28 = value.x7;
                }
            }
        }
        public sbyte8 v8_22
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, 6 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_6;
                }
                else
                {
                    return new sbyte8(x22, x23, x24, x25, x26, x27, x28, x29);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 6 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_6 = value;
                }
                else
                {
                    this.x22 = value.x0;
                    this.x23 = value.x1;
                    this.x24 = value.x2;
                    this.x25 = value.x3;
                    this.x26 = value.x4;
                    this.x27 = value.x5;
                    this.x28 = value.x6;
                    this.x29 = value.x7;
                }
            }
        }
        public sbyte8 v8_23
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    v128 perm = Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 3, 2)));

                    return Sse2.bsrli_si128(perm, 7 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_7;
                }
                else
                {
                    return new sbyte8(x23, x24, x25, x26, x27, x28, x29, x30);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 7 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 255, 255, 255, 255, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_7 = value;
                }
                else
                {
                    this.x23 = value.x0;
                    this.x24 = value.x1;
                    this.x25 = value.x2;
                    this.x26 = value.x3;
                    this.x27 = value.x4;
                    this.x28 = value.x5;
                    this.x29 = value.x6;
                    this.x30 = value.x7;
                }
            }
        }
        public sbyte8 v8_24
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 3)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v8_8;
                }
                else
                {
                    return new sbyte8(x24, x25, x26, x27, x28, x29, x30, x31);
                }
                
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx.mm256_insert_epi64(this, *(long*)&value, 3);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v8_8 = value;
                }
                else
                {
                    this.x24 = value.x0;
                    this.x25 = value.x1;
                    this.x26 = value.x2;
                    this.x27 = value.x3;
                    this.x28 = value.x4;
                    this.x29 = value.x5;
                    this.x30 = value.x6;
                    this.x31 = value.x7;
                }
            }
        }

        public sbyte4 v4_0
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_0;
                }
                else
                {
                    return new sbyte4(x0, x1, x2, x3);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 0);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_0 = Sse4_1.insert_epi32(this._v16_0, *(int*)&value, 0);
                }
                else
                {
                    this.x0  = value.x;
                    this.x1  = value.y;
                    this.x2  = value.z;
                    this.x3  = value.w;
                }
            }
        }
        public sbyte4 v4_1
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_1;
                }
                else
                {
                    return new sbyte4(x1, x2, x3, x4);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_1 = value;
                }
                else
                {
                    this.x1  = value.x;
                    this.x2  = value.y;
                    this.x3  = value.z;
                    this.x4  = value.w;
                }
            }
        }
        public sbyte4 v4_2
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_2;
                }
                else
                {
                    return new sbyte4(x2, x3, x4, x5);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_2 = value;
                }
                else
                {
                    this.x2  = value.x;
                    this.x3  = value.y;
                    this.x4  = value.z;
                    this.x5  = value.w;
                }
            }
        }
        public sbyte4 v4_3
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_3;
                }
                else
                {
                    return new sbyte4(x3, x4, x5, x6);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_3 = value;
                }
                else
                {
                    this.x3  = value.x;
                    this.x4  = value.y;
                    this.x5  = value.z;
                    this.x6  = value.w;
                }
            }
        }
        public sbyte4 v4_4
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_4;
                }
                else
                {
                    return new sbyte4(x4, x5, x6, x7);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 1);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_0 = Sse4_1.insert_epi32(this._v16_0, *(int*)&value, 1);
                }
                else
                {
                    this.x4  = value.x;
                    this.x5  = value.y;
                    this.x6  = value.z;
                    this.x7  = value.w;
                }
            }
        }
        public sbyte4 v4_5
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_5;
                }
                else
                {
                    return new sbyte4(x5, x6, x7, x8);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_5 = value;
                }
                else
                {
                    this.x5  = value.x;
                    this.x6  = value.y;
                    this.x7  = value.z;
                    this.x8  = value.w;
                }
            }
        }
        public sbyte4 v4_6
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_6;
                }
                else
                {
                    return new sbyte4(x6, x7, x8, x9);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 6 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_6 = value;
                }
                else
                {
                    this.x6  = value.x;
                    this.x7  = value.y;
                    this.x8  = value.z;
                    this.x9  = value.w;
                }
            }
        }
        public sbyte4 v4_7
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_7;
                }
                else
                {
                    return new sbyte4(x7, x8, x9, x10);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_7 = value;
                }
                else
                {
                    this.x7  = value.x;
                    this.x8  = value.y;
                    this.x9  = value.z;
                    this.x10 = value.w;
                }
            }
        }
        public sbyte4 v4_8
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_8;
                }
                else
                {
                    return new sbyte4(x8, x9, x10, x11);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 2);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_0 = Sse4_1.insert_epi32(this._v16_0, *(int*)&value, 2);
                }
                else
                {
                    this.x8  = value.x;
                    this.x9  = value.y;
                    this.x10 = value.z;
                    this.x11 = value.w;
                }
            }
        }
        public sbyte4 v4_9
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_9;
                }
                else
                {
                    return new sbyte4(x9, x10, x11, x12);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 9 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_9 = value;
                }
                else
                {
                    this.x9  = value.x;
                    this.x10 = value.y;
                    this.x11 = value.z;
                    this.x12 = value.w;
                }

            }
        }
        public sbyte4 v4_10
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_10;
                }
                else
                {
                    return new sbyte4(x10, x11, x12, x13);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 10 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_10 = value;
                }
                else
                {
                    this.x10 = value.x;
                    this.x11 = value.y;
                    this.x12 = value.z;
                    this.x13 = value.w;
                }
            }
        }
        public sbyte4 v4_11
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_11;
                }
                else
                {
                    return new sbyte4(x11, x12, x13, x14);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 11 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v4_11 = value;
                }
                else
                {
                    this.x11 = value.x;
                    this.x12 = value.y;
                    this.x13 = value.z;
                    this.x14 = value.w;
                }
            }
        }
        public sbyte4 v4_12
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v4_12;
                }
                else
                {
                    return new sbyte4(x12, x13, x14, x15);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 3);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_0 = Sse4_1.insert_epi32(this._v16_0, *(int*)&value, 3);
                }
                else
                {
                    this.x12 = value.x;
                    this.x13 = value.y;
                    this.x14 = value.z;
                    this.x15 = value.w;
                }
            }
        }
        public sbyte4 v4_13
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 5 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  13 * sizeof(sbyte)),
                                       Sse2.bslli_si128(_v16_16, 3 * sizeof(sbyte)),
                                       new byte4(0, 0, 0, 255));
                }
                else
                {
                    return new sbyte4(x13, x14, x15, x16);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 13 * sizeof(sbyte)), Sse2.bsrli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 13 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  3 * sizeof(sbyte)), new v128(255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x13 = value.x;
                    this.x14 = value.y;
                    this.x15 = value.z;
                    this.x16 = value.w;
                }
            }
        }
        public sbyte4 v4_14
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 6 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Sse2.unpacklo_epi16(Sse2.bsrli_si128(_v16_0,  14 * sizeof(sbyte)), _v16_16);
                }
                else
                {
                    return new sbyte4(x14, x15, x16, x17);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 14 * sizeof(sbyte)), Sse2.bsrli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 14 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  2 * sizeof(sbyte)), new v128(255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x14 = value.x;
                    this.x15 = value.y;
                    this.x16 = value.z;
                    this.x17 = value.w;
                }
            }
        }
        public sbyte4 v4_15
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 7 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  15 * sizeof(sbyte)),
                                       Sse2.bslli_si128(_v16_16, sizeof(sbyte)),
                                       new byte4(0, 255, 255, 255));
                }
                else
                {
                    return new sbyte4(x15, x16, x17, x18);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 15 * sizeof(sbyte)), Sse2.bsrli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 15 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,      sizeof(sbyte)), new v128(255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x15 = value.x;
                    this.x16 = value.y;
                    this.x17 = value.z;
                    this.x18 = value.w;
                }
            }
        }
        public sbyte4 v4_16
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 2)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_0;
                }
                else
                {
                    return new sbyte4(x16, x17, x18, x19);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 4);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_16 = Sse4_1.insert_epi32(this._v16_16, *(int*)&value, 0);
                }
                else
                {
                    this.x16 = value.x;
                    this.x17 = value.y;
                    this.x18 = value.z;
                    this.x19 = value.w;
                }
            }
        }
        public sbyte4 v4_17
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_1;
                }
                else
                {
                    return new sbyte4(x17, x18, x19, x20);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_1 = value;
                }
                else
                {
                    this.x17 = value.x;
                    this.x18 = value.y;
                    this.x19 = value.z;
                    this.x20 = value.w;
                }
            }
        }
        public sbyte4 v4_18
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_2;
                }
                else
                {
                    return new sbyte4(x18, x19, x20, x21);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 2 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_2 = value;
                }
                else
                {
                    this.x18 = value.x;
                    this.x19 = value.y;
                    this.x20 = value.z;
                    this.x21 = value.w;
                }
            }
        }
        public sbyte4 v4_19
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_3;
                }
                else
                {
                    return new sbyte4(x19, x20, x21, x22);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 3 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_3 = value;
                }
                else
                {
                    this.x19 = value.x;
                    this.x20 = value.y;
                    this.x21 = value.z;
                    this.x22 = value.w;
                }
            }
        }
        public sbyte4 v4_20
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx.IsAvxSupported)
                {
                    int temp = Avx.mm256_extract_epi32(this, 5);

                    return *(sbyte4*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_4;
                }
                else
                {
                    return new sbyte4(x20, x21, x22, x23);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 5);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_16 = Sse4_1.insert_epi32(this._v16_16, *(int*)&value, 1);
                }
                else
                {
                    this.x20 = value.x;
                    this.x21 = value.y;
                    this.x22 = value.z;
                    this.x23 = value.w;
                }
            }
        }
        public sbyte4 v4_21
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_5;
                }
                else
                {
                    return new sbyte4(x21, x22, x23, x24);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 5 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_5 = value;
                }
                else
                {
                    this.x21 = value.x;
                    this.x22 = value.y;
                    this.x23 = value.z;
                    this.x24 = value.w;
                }
            }
        }
        public sbyte4 v4_22
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_6;
                }
                else
                {
                    return new sbyte4(x22, x23, x24, x25);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 6 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_6 = value;
                }
                else
                {
                    this.x22 = value.x;
                    this.x23 = value.y;
                    this.x24 = value.z;
                    this.x25 = value.w;
                }
            }
        }
        public sbyte4 v4_23
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_7;
                }
                else
                {
                    return new sbyte4(x23, x24, x25, x26);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 7 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_7 = value;
                }
                else
                {
                    this.x23 = value.x;
                    this.x24 = value.y;
                    this.x25 = value.z;
                    this.x26 = value.w;
                }
            }
        }
        public sbyte4 v4_24
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 3)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_8;
                }
                else
                {
                    return new sbyte4(x24, x25, x26, x27);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 6);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_16 = Sse4_1.insert_epi32(this._v16_16, *(int*)&value, 2);
                }
                else
                {
                    this.x24 = value.x;
                    this.x25 = value.y;
                    this.x26 = value.z;
                    this.x27 = value.w;
                }
            }
        }
        public sbyte4 v4_25
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_9;
                }
                else
                {
                    return new sbyte4(x25, x26, x27, x28);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 9 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_9 = value;
                }
                else
                {
                    this.x25 = value.x;
                    this.x26 = value.y;
                    this.x27 = value.z;
                    this.x28 = value.w;
                }
            }
        }
        public sbyte4 v4_26
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_10;
                }
                else
                {
                    return new sbyte4(x26, x27, x28, x29);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 10 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_10 = value;
                }
                else
                {
                    this.x26 = value.x;
                    this.x27 = value.y;
                    this.x28 = value.z;
                    this.x29 = value.w;
                }
            }
        }
        public sbyte4 v4_27
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_11;
                }
                else
                {
                    return new sbyte4(x27, x28, x29, x30);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 11 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v4_11 = value;
                }
                else
                {
                    this.x27 = value.x;
                    this.x28 = value.y;
                    this.x29 = value.z;
                    this.x30 = value.w;
                }
            }
        }
        public sbyte4 v4_28
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get
            {
                if (Avx.IsAvxSupported)
                {
                    int temp = Avx.mm256_extract_epi32(this, 7);

                    return *(sbyte4*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v4_12;
                }
                else
                {
                    return new sbyte4( x28, x29, x30, x31);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi32(this, *(int*)&value, 7);
                }
                else if (Sse4_1.IsSse41Supported)
                {
                    this._v16_16 = Sse4_1.insert_epi32(this._v16_16, *(int*)&value, 3);
                }
                else
                {
                    this.x28 = value.x;
                    this.x29 = value.y;
                    this.x30 = value.z;
                    this.x31 = value.w;
                }
            }
        }

        public sbyte3 v3_0
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_0;
                }
                else
                {
                    return new sbyte3(x0, x1, x2);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(value);
                    v256 mask = new v256(255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_0 = value;
                }
                else
                {
                    this.x0  = value.x;
                    this.x1  = value.y;
                    this.x2  = value.z;
                }

            }
        }
        public sbyte3 v3_1
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_1;
                }
                else
                {
                    return new sbyte3(x1, x2, x3);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_1 = value;
                }
                else
                {
                    this.x1  = value.x;
                    this.x2  = value.y;
                    this.x3  = value.z;
                }
            }
        }
        public sbyte3 v3_2
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_2;
                }
                else
                {
                    return new sbyte3(x2, x3, x4);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_2 = value;
                }
                else
                {
                    this.x2  = value.x;
                    this.x3  = value.y;
                    this.x4  = value.z;
                }
            }
        }
        public sbyte3 v3_3
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_3;
                }
                else
                {
                    return new sbyte3(x3, x4, x5);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_3 = value;
                }
                else
                {
                    this.x3  = value.x;
                    this.x4  = value.y;
                    this.x5  = value.z;
                }
            }
        }
        public sbyte3 v3_4
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_4;
                }
                else
                {
                    return new sbyte3(x4, x5, x6);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 4 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_4 = value;
                }
                else
                {
                    this.x4  = value.x;
                    this.x5  = value.y;
                    this.x6  = value.z;
                }
            }
        }
        public sbyte3 v3_5
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_5;
                }
                else
                {
                    return new sbyte3(x5, x6, x7);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_5 = value;
                }
                else
                {
                    this.x5  = value.x;
                    this.x6  = value.y;
                    this.x7  = value.z;
                }
            }
        }
        public sbyte3 v3_6
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_6;
                }
                else
                {
                    return new sbyte3(x6, x7, x8);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 6 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_6 = value;
                }
                else
                {
                    this.x6  = value.x;
                    this.x7  = value.y;
                    this.x8  = value.z;
                }
            }
        }
        public sbyte3 v3_7
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_7;
                }
                else
                {
                    return new sbyte3(x7, x8, x9);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_7 = value;
                }
                else
                {
                    this.x7  = value.x;
                    this.x8  = value.y;
                    this.x9  = value.z;
                }
            }
        }
        public sbyte3 v3_8
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_8;
                }
                else
                {
                    return new sbyte3(x8, x9, x10);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 8 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_8 = value;
                }
                else
                {
                    this.x8  = value.x;
                    this.x9  = value.y;
                    this.x10 = value.z;
                }
            }
        }
        public sbyte3 v3_9
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_9;
                }
                else
                {
                    return new sbyte3(x9, x10, x11);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 9 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_9 = value;
                }
                else
                {
                    this.x9  = value.x;
                    this.x10 = value.y;
                    this.x11 = value.z;
                }
            }
        }
        public sbyte3 v3_10
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_10;
                }
                else
                {
                    return new sbyte3(x10, x11, x12);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 10 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_10 = value;
                }
                else
                {
                    this.x10 = value.x;
                    this.x11 = value.y;
                    this.x12 = value.z;
                }
            }
        }
        public sbyte3 v3_11
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_11;
                }
                else
                {
                    return new sbyte3(x11, x12, x13);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 11 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_11 = value;
                }
                else
                {
                    this.x11 = value.x;
                    this.x12 = value.y;
                    this.x13 = value.z;
                }
            }
        }
        public sbyte3 v3_12
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_12;
                }
                else
                {
                    return new sbyte3(x12, x13, x14);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 12 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_12 = value;
                }
                else
                {
                    this.x12 = value.x;
                    this.x13 = value.y;
                    this.x14 = value.z;
                }
            }
        }
        public sbyte3 v3_13
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v3_13;
                }
                else
                {
                    return new sbyte3(x13, x14, x15);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 13 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v3_13 = value;
                }
                else
                {
                    this.x13 = value.x;
                    this.x14 = value.y;
                    this.x15 = value.z;
                }
            }
        }
        public sbyte3 v3_14
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 6 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Sse2.unpacklo_epi16(Sse2.bsrli_si128(_v16_0,  14 * sizeof(sbyte)), _v16_16);
                }
                else
                {
                    return new sbyte3(x14, x15, x16);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 14 * sizeof(sbyte)), Sse2.bsrli_si128(value, 2 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 14 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,  2 * sizeof(sbyte)), new v128(255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x14 = value.x;
                    this.x15 = value.y;
                    this.x16 = value.z;
                }
            }
        }
        public sbyte3 v3_15
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 7 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Mask.BlendV(Sse2.bsrli_si128(_v16_0,  15 * sizeof(sbyte)),
                                       Sse2.bslli_si128(_v16_16, sizeof(sbyte)),
                                       new byte4(0, 255, 255, 255));
                }
                else
                {
                    return new sbyte3(x15, x16, x17);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 15 * sizeof(sbyte)), Sse2.bsrli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 15 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,      sizeof(sbyte)), new v128(255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x15 = value.x;
                    this.x16 = value.y;
                    this.x17 = value.z;
                }
            }
        }
        public sbyte3 v3_16
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 2)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_0;
                }
                else
                {
                    return new sbyte3(x16, x17, x18);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), value, 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_0 = value;
                }
                else
                {
                    this.x16 = value.x;
                    this.x17 = value.y;
                    this.x18 = value.z;
                }
            }
        }
        public sbyte3 v3_17
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_1;
                }
                else
                {
                    return new sbyte3(x17, x18, x19);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 1 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_1 = value;
                }
                else
                {
                    this.x17 = value.x;
                    this.x18 = value.y;
                    this.x19 = value.z;
                }
            }
        }
        public sbyte3 v3_18
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_2;
                }
                else
                {
                    return new sbyte3(x18, x19, x20);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 2 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_2 = value;
                }
                else
                {
                    this.x18 = value.x;
                    this.x19 = value.y;
                    this.x20 = value.z;
                }
            }
        }
        public sbyte3 v3_19
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_3;
                }
                else
                {
                    return new sbyte3(x19, x20, x21);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 3 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_3 = value;
                }
                else
                {
                    this.x19 = value.x;
                    this.x20 = value.y;
                    this.x21 = value.z;
                }
            }
        }
        public sbyte3 v3_20
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    int temp = Avx.mm256_extract_epi32(this, 5);

                    return *(sbyte3*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_4;
                }
                else
                {
                    return new sbyte3(x20, x21, x22);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 4 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_4 = value;
                }
                else
                {
                    this.x20 = value.x;
                    this.x21 = value.y;
                    this.x22 = value.z;
                }
            }
        }
        public sbyte3 v3_21
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_5;
                }
                else
                {
                    return new sbyte3(x21, x22, x23);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 5 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_5 = value;
                }
                else
                {
                    this.x21 = value.x;
                    this.x22 = value.y;
                    this.x23 = value.z;
                }
            }
        }
        public sbyte3 v3_22
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_6;
                }
                else
                {
                    return new sbyte3(x22, x23, x24);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 6 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_6 = value;
                }
                else
                {
                    this.x22 = value.x;
                    this.x23 = value.y;
                    this.x24 = value.z;
                }
            }
        }
        public sbyte3 v3_23
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_7;
                }
                else
                {
                    return new sbyte3(x23, x24, x25);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 7 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_7 = value;
                }
                else
                {
                    this.x23 = value.x;
                    this.x24 = value.y;
                    this.x25 = value.z;
                }
            }
        }
        public sbyte3 v3_24
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 3)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_8;
                }
                else
                {
                    return new sbyte3(x24, x25, x26);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 8 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_8 = value;
                }
                else
                {
                    this.x24 = value.x;
                    this.x25 = value.y;
                    this.x26 = value.z;
                }
            }
        }
        public sbyte3 v3_25
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_9;
                }
                else
                {
                    return new sbyte3(x25, x26, x27);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 9 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_9 = value;
                }
                else
                {
                    this.x25 = value.x;
                    this.x26 = value.y;
                    this.x27 = value.z;
                }
            }
        }
        public sbyte3 v3_26
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_10;
                }
                else
                {
                    return new sbyte3(x26, x27, x28);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 10 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_10 = value;
                }
                else
                {
                    this.x26 = value.x;
                    this.x27 = value.y;
                    this.x28 = value.z;
                }
            }
        }
        public sbyte3 v3_27
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_11;
                }
                else
                {
                    return new sbyte3(x27, x28, x29);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 11 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_11 = value;
                }
                else
                {
                    this.x27 = value.x;
                    this.x28 = value.y;
                    this.x29 = value.z;
                }
            }
        }
        public sbyte3 v3_28
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    int temp = Avx.mm256_extract_epi32(this, 7);

                    return *(sbyte3*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_12;
                }
                else
                {
                    return new sbyte3(x28, x29, x30);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 12 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_12 = value;
                }
                else
                {
                    this.x28 = value.x;
                    this.x29 = value.y;
                    this.x30 = value.z;
                }
            }
        }
        public sbyte3 v3_29
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v3_13;
                }
                else
                {
                    return new sbyte3(x29, x30, x31);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default(v256), Sse2.bslli_si128(value, 13 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v3_13 = value;
                }
                else
                {
                    this.x29 = value.x;
                    this.x30 = value.y;
                    this.x31 = value.z;
                }
            }
        }

        public sbyte2 v2_0
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_0;
                }
                else
                {
                    return new sbyte2(x0, x1);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 0);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 0);
                }
                else
                {
                    this.x0  = value.x;
                    this.x1  = value.y;
                }
            }
        }
        public sbyte2 v2_1
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_1;
                }
                else
                {
                    return new sbyte2(x1, x2);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_1 = value;
                }
                else
                {
                    this.x1  = value.x;
                    this.x2  = value.y;
                }
            }
        }
        public sbyte2 v2_2
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_2;
                }
                else
                {
                    return new sbyte2(x2, x3);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 1);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 1);
                }
                else
                {
                    this.x2  = value.x;
                    this.x3  = value.y;
                }
            }
        }
        public sbyte2 v2_3
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_3;
                }
                else
                {
                    return new sbyte2(x3, x4);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 3 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_3 = value;
                }
                else
                {
                    this.x3  = value.x;
                    this.x4  = value.y;
                }
            }
        }
        public sbyte2 v2_4
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_4;
                }
                else
                {
                    return new sbyte2(x4, x5);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 2);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 2);
                }
                else
                {
                    this.x4  = value.x;
                    this.x5  = value.y;
                }
            }
        }
        public sbyte2 v2_5
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_5;
                }
                else
                {
                    return new sbyte2(x5, x6);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 5 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_5 = value;
                }
                else
                {
                    this.x5  = value.x;
                    this.x6  = value.y;
                }
            }
        }
        public sbyte2 v2_6
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_6;
                }
                else
                {
                    return new sbyte2(x6, x7);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 3);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 3);
                }
                else
                {
                    this.x6  = value.x;
                    this.x7  = value.y;
                }
            }
        }
        public sbyte2 v2_7
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_7;
                }
                else
                {
                    return new sbyte2(x7, x8);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 7 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_7 = value;
                }
                else
                {
                    this.x7  = value.x;
                    this.x8  = value.y;
                }
            }
        }
        public sbyte2 v2_8
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_8;
                }
                else
                {
                    return new sbyte2(x8, x9);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 4);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 4);
                }
                else
                {
                    this.x8  = value.x;
                    this.x9  = value.y;
                }
            }
        }
        public sbyte2 v2_9
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_9;
                }
                else
                {
                    return new sbyte2(x9, x10);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 9 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_9 = value;
                }
                else
                {
                    this.x9  = value.x;
                    this.x10 = value.y;
                }
            }
        }
        public sbyte2 v2_10
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_10;
                }
                else
                {
                    return new sbyte2(x10, x11);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 5);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 5);
                }
                else
                {
                    this.x10 = value.x;
                    this.x11 = value.y;
                }
            }
        }
        public sbyte2 v2_11
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_11;
                }
                else
                {
                    return new sbyte2(x11, x12);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 11 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_11 = value;
                }
                else
                {
                    this.x11 = value.x;
                    this.x12 = value.y;
                }
            }
        }
        public sbyte2 v2_12
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_12;
                }
                else
                {
                    return new sbyte2(x12, x13);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 6);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 6);
                }
                else
                {
                    this.x12 = value.x;
                    this.x13 = value.y;
                }
            }
        }
        public sbyte2 v2_13
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_13;
                }
                else
                {
                    return new sbyte2(x13, x14);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx.mm256_castsi128_si256(Sse2.bslli_si128(value, 13 * sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0.v2_13 = value;
                }
                else
                {
                    this.x13 = value.x;
                    this.x14 = value.y;
                }
            }
        }
        public sbyte2 v2_14
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_0.v2_14;
                }
                else
                {
                    return new sbyte2(x14, x15);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 7);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0 = Sse2.insert_epi16(this._v16_0, *(short*)&value, 7);
                }
                else
                {
                    this.x14 = value.x;
                    this.x15 = value.y;
                }
            }
        }
        public sbyte2 v2_15
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.bsrli_si128(Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1))), 7 * sizeof(sbyte));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return Sse2.unpacklo_epi8(Sse2.bsrli_si128(_v16_0, 15 * sizeof(sbyte)), _v16_16);
                }
                else
                {
                    return new sbyte2(x15, x16);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = new v256(Sse2.bslli_si128(value, 15 * sizeof(sbyte)), Sse2.bsrli_si128(value, sizeof(sbyte)));
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_0  = Mask.BlendV(this._v16_0,  Sse2.bslli_si128(value, 15 * sizeof(sbyte)), new v128(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255));
                    this._v16_16 = Mask.BlendV(this._v16_16, Sse2.bsrli_si128(value,      sizeof(sbyte)), new v128(255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));
                }
                else
                {
                    this.x15 = value.x;
                    this.x16 = value.y;
                }
            }
        }
        public sbyte2 v2_16
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 2)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_0;
                }
                else
                {
                    return new sbyte2(x16, x17);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 8);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 0);
                }
                else
                {
                    this.x16 = value.x;
                    this.x17 = value.y;
                }
            }
        }
        public sbyte2 v2_17
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_1;
                }
                else
                {
                    return new sbyte2(x17, x18);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_1 = value;
                }
                else
                {
                    this.x17 = value.x;
                    this.x18 = value.y;
                }
            }
        }
        public sbyte2 v2_18
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 9);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_2;
                }
                else
                {
                    return new sbyte2(x18, x19);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 9);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 1);
                }
                else
                {
                    this.x18 = value.x;
                    this.x19 = value.y;
                }
            }
        }
        public sbyte2 v2_19
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_3;
                }
                else
                {
                    return new sbyte2(x19, x20);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 3 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_3 = value;
                }
                else
                {
                    this.x19 = value.x;
                    this.x20 = value.y;
                }
            }
        }
        public sbyte2 v2_20
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 10);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_4;
                }
                else
                {
                    return new sbyte2(x20, x21);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 10);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 2);
                }
                else
                {
                    this.x20 = value.x;
                    this.x21 = value.y;
                }
            }
        }
        public sbyte2 v2_21
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_5;
                }
                else
                {
                    return new sbyte2(x21, x22);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 5 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_5 = value;
                }
                else
                {
                    this.x21 = value.x;
                    this.x22 = value.y;
                }
            }
        }
        public sbyte2 v2_22
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 11);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_6;
                }
                else
                {
                    return new sbyte2(x22, x23);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 11);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 3);
                }
                else
                {
                    this.x22 = value.x;
                    this.x23 = value.y;
                }
            }
        }
        public sbyte2 v2_23
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_7;
                }
                else
                {
                    return new sbyte2(x23, x24);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 7 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_7 = value;
                }
                else
                {
                    this.x23 = value.x;
                    this.x24 = value.y;
                }
            }
        }
        public sbyte2 v2_24
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx.IsAvxSupported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 3)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_8;
                }
                else
                {
                    return new sbyte2(x24, x25);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 12);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 4);
                }
                else
                {
                    this.x24 = value.x;
                    this.x25 = value.y;
                }
            }
        }
        public sbyte2 v2_25
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_9;
                }
                else
                {
                    return new sbyte2(x25, x26);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 9 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_9 = value;
                }
                else
                {
                    this.x25 = value.x;
                    this.x26 = value.y;
                }
            }
        }
        public sbyte2 v2_26
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 13);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_10;
                }
                else
                {
                    return new sbyte2(x26, x27);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 13);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 5);
                }
                else
                {
                    this.x26 = value.x;
                    this.x27 = value.y;
                }
            }
        }
        public sbyte2 v2_27
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_11;
                }
                else
                {
                    return new sbyte2(x27, x28);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 11 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0, 0, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_11 = value;
                }
                else
                {
                    this.x27 = value.x;
                    this.x28 = value.y;
                }
            }
        }
        public sbyte2 v2_28
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 14);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_12;
                }
                else
                {
                    return new sbyte2(x28, x29);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 14);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 6);
                }
                else
                {
                    this.x28 = value.x;
                    this.x29 = value.y;
                }
            }
        }
        public sbyte2 v2_29
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_13;
                }
                else
                {
                    return new sbyte2(x29, x30);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    v256 blend = Avx2.mm256_inserti128_si256(default, Sse2.bslli_si128(value, 13 * sizeof(sbyte)), 1);
                    v256 mask = new v256(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 0);

                    this = Avx2.mm256_blendv_epi8(this, blend, mask);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16.v2_13 = value;
                }
                else
                {
                    this.x29 = value.x;
                    this.x30 = value.y;
                }
            }
        }
        public sbyte2 v2_30
        { 
			[MethodImpl(MethodImplOptions.AggressiveInlining)] 
			readonly get 
			{
                if (Avx2.IsAvx2Supported)
                {
                    int temp = Avx2.mm256_extract_epi16(this, 15);

                    return *(sbyte2*)&temp;
                }
                else if (Sse2.IsSse2Supported)
                {
                    return v16_16.v2_14;
                }
                else
                {
                    return new sbyte2(x30, x31);
                }
			}

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx.IsAvxSupported)
                {
                    this = Avx.mm256_insert_epi16(this, *(short*)&value, 15);
                }
                else if (Sse2.IsSse2Supported)
                {
                    this._v16_16 = Sse2.insert_epi16(this._v16_16, *(short*)&value, 7);
                }
                else
                {
                    this.x30 = value.x;
                    this.x31 = value.y;
                }
            }
        }
        #endregion



        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Sse4_1.stream_load_si128(void* ptr)   Sse.load_ps(void* ptr)
        public static implicit operator v256(sbyte32 input) => new v256(input.x0, input.x1, input.x2, input.x3, input.x4, input.x5, input.x6, input.x7, input.x8, input.x9, input.x10, input.x11, input.x12, input.x13, input.x14, input.x15, input.x16, input.x17, input.x18, input.x19, input.x20, input.x21, input.x22, input.x23, input.x24, input.x25, input.x26, input.x27, input.x28, input.x29, input.x30, input.x31);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Sse.store_ps(void* ptr, v256 x)
        public static implicit operator sbyte32(v256 input) => new sbyte32 { x0 = input.SByte0, x1 = input.SByte1, x2 = input.SByte2, x3 = input.SByte3, x4 = input.SByte4, x5 = input.SByte5, x6 = input.SByte6, x7 = input.SByte7, x8 = input.SByte8, x9 = input.SByte9, x10 = input.SByte10, x11 = input.SByte11, x12 = input.SByte12, x13 = input.SByte13, x14 = input.SByte14, x15 = input.SByte15, x16 = input.SByte16, x17 = input.SByte17, x18 = input.SByte18, x19 = input.SByte19, x20 = input.SByte20, x21 = input.SByte21, x22 = input.SByte22, x23 = input.SByte23, x24 = input.SByte24, x25 = input.SByte25, x26 = input.SByte26, x27 = input.SByte27, x28 = input.SByte28, x29 = input.SByte29, x30 = input.SByte30, x31 = input.SByte31 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator sbyte32(sbyte input) => new sbyte32(input);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte32(byte32 input)
        {
            if (Avx.IsAvxSupported)
            {
                return (v256)input;
            }
            else if (Sse.IsSseSupported)
            {
                return new sbyte32((v128)input._v16_0, (v128)input._v16_16);
            }
            else
            {
                return *(sbyte32*)&input;
            }
        }


        public sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
Assert.IsWithinArrayBounds(index, 32);

                return asArray[index];
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 32);

                asArray[index] = value;
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator + (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_add_epi8(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 + right._v16_0, left._v16_16 + right._v16_16);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator - (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sub_epi8(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 - right._v16_0, left._v16_16 - right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator * (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.mul_byte(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 * right._v16_0, left._v16_16 * right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator / (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.vdiv_sbyte(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 / right._v16_0, left._v16_16 / right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator % (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.vrem_sbyte(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 % right._v16_0, left._v16_16 % right._v16_16);
            }
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator * (sbyte left, sbyte32 right) => right * left;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator * (sbyte32 left, sbyte right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return new sbyte32((sbyte)(left.x0 * right), (sbyte)(left.x1 * right), (sbyte)(left.x2 * right), (sbyte)(left.x3 * right), (sbyte)(left.x4 * right), (sbyte)(left.x5 * right), (sbyte)(left.x6 * right), (sbyte)(left.x7 * right), (sbyte)(left.x8 * right), (sbyte)(left.x9 * right), (sbyte)(left.x10 * right), (sbyte)(left.x11 * right), (sbyte)(left.x12 * right), (sbyte)(left.x13 * right), (sbyte)(left.x14 * right), (sbyte)(left.x15 * right), (sbyte)(left.x16 * right), (sbyte)(left.x17 * right), (sbyte)(left.x18 * right), (sbyte)(left.x19 * right), (sbyte)(left.x20 * right), (sbyte)(left.x21 * right), (sbyte)(left.x22 * right), (sbyte)(left.x23 * right), (sbyte)(left.x24 * right), (sbyte)(left.x25 * right), (sbyte)(left.x26 * right), (sbyte)(left.x27 * right), (sbyte)(left.x28 * right), (sbyte)(left.x29 * right), (sbyte)(left.x30 * right), (sbyte)(left.x31 * right));
            }
            else
            {
                return new sbyte32(left._v16_0 * right, left._v16_16 * right);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator / (sbyte32 left, sbyte right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return new sbyte32((sbyte)(left.x0 / right), (sbyte)(left.x1 / right), (sbyte)(left.x2 / right), (sbyte)(left.x3 / right), (sbyte)(left.x4 / right), (sbyte)(left.x5 / right), (sbyte)(left.x6 / right), (sbyte)(left.x7 / right), (sbyte)(left.x8 / right), (sbyte)(left.x9 / right), (sbyte)(left.x10 / right), (sbyte)(left.x11 / right), (sbyte)(left.x12 / right), (sbyte)(left.x13 / right), (sbyte)(left.x14 / right), (sbyte)(left.x15 / right), (sbyte)(left.x16 / right), (sbyte)(left.x17 / right), (sbyte)(left.x18 / right), (sbyte)(left.x19 / right), (sbyte)(left.x20 / right), (sbyte)(left.x21 / right), (sbyte)(left.x22 / right), (sbyte)(left.x23 / right), (sbyte)(left.x24 / right), (sbyte)(left.x25 / right), (sbyte)(left.x26 / right), (sbyte)(left.x27 / right), (sbyte)(left.x28 / right), (sbyte)(left.x29 / right), (sbyte)(left.x30 / right), (sbyte)(left.x31 / right));
            }
            else
            {
                return new sbyte32(left._v16_0 / right, left._v16_16 / right);
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator % (sbyte32 left, sbyte right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return new sbyte32((sbyte)(left.x0 % right), (sbyte)(left.x1 % right), (sbyte)(left.x2 % right), (sbyte)(left.x3 % right), (sbyte)(left.x4 % right), (sbyte)(left.x5 % right), (sbyte)(left.x6 % right), (sbyte)(left.x7 % right), (sbyte)(left.x8 % right), (sbyte)(left.x9 % right), (sbyte)(left.x10 % right), (sbyte)(left.x11 % right), (sbyte)(left.x12 % right), (sbyte)(left.x13 % right), (sbyte)(left.x14 % right), (sbyte)(left.x15 % right), (sbyte)(left.x16 % right), (sbyte)(left.x17 % right), (sbyte)(left.x18 % right), (sbyte)(left.x19 % right), (sbyte)(left.x20 % right), (sbyte)(left.x21 % right), (sbyte)(left.x22 % right), (sbyte)(left.x23 % right), (sbyte)(left.x24 % right), (sbyte)(left.x25 % right), (sbyte)(left.x26 % right), (sbyte)(left.x27 % right), (sbyte)(left.x28 % right), (sbyte)(left.x29 % right), (sbyte)(left.x30 % right), (sbyte)(left.x31 % right));
            }
            else
            {
                return new sbyte32(left._v16_0 % right, left._v16_16 % right);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator & (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_and_si256(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 & right._v16_0, left._v16_16 & right._v16_16);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator | (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_or_si256(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 | right._v16_0, left._v16_16 | right._v16_16);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator ^ (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_xor_si256(left, right);
            }
            else
            {
                return new sbyte32(left._v16_0 ^ right._v16_0, left._v16_16 ^ right._v16_16);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator - (sbyte32 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sub_epi8(default(v256), x);
            }
            else
            {
                return new sbyte32(-x._v16_0, -x._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator ++ (sbyte32 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_add_epi8(x, new sbyte32(1));
            }
            else
            {
                return new sbyte32(x._v16_0 + 1, x._v16_16 + 1);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator -- (sbyte32 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sub_epi8(x, new sbyte32(1));
            }
            else
            {
                return new sbyte32(x._v16_0 - 1, x._v16_16 - 1);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator ~ (sbyte32 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_andnot_si256(x, new sbyte32(-1));
            }
            else
            {
                return new sbyte32(~x._v16_0, ~x._v16_16);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator << (sbyte32 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.shl_byte(x, n);
            }
            else
            {
                return new sbyte32(x._v16_0 << n, x._v16_16 << n);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 operator >> (sbyte32 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.shra_byte(x, n);
            }
            else
            {
                return new sbyte32(x._v16_0 >> n, x._v16_16 >> n);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator == (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsTrue(Avx2.mm256_cmpeq_epi8(left, right));
            }
            else
            {
                return new bool32(left._v16_0 == right._v16_0, left._v16_16 == right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator < (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsTrue(Avx2.mm256_cmpgt_epi8(right, left));
            }
            else
            {
                return new bool32(left._v16_0 < right._v16_0, left._v16_16 < right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator > (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsTrue(Avx2.mm256_cmpgt_epi8(left, right));
            }
            else
            {
                return new bool32(left._v16_0 > right._v16_0, left._v16_16 > right._v16_16);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator != (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsFalse(Avx2.mm256_cmpeq_epi8(left, right));
            }
            else
            {
                return new bool32(left._v16_0 != right._v16_0, left._v16_16 != right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator <= (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsFalse(Avx2.mm256_cmpgt_epi8(left, right));
            }
            else
            {
                return new bool32(left._v16_0 <= right._v16_0, left._v16_16 <= right._v16_16);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool32 operator >= (sbyte32 left, sbyte32 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return TestIsFalse(Avx2.mm256_cmpgt_epi8(right, left));
            }
            else
            {
                return new bool32(left._v16_0 >= right._v16_0, left._v16_16 >= right._v16_16);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool32 TestIsTrue(v256 input)
        {
            return (v256)(-((sbyte32)input));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool32 TestIsFalse(v256 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_andnot_si256(input, new v256(0x0101_0101));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(sbyte32 other)
        {
            if (Avx2.IsAvx2Supported)
            {
                return uint.MaxValue == (uint)Avx2.mm256_movemask_epi8(Avx2.mm256_cmpeq_epi32(this, other));
            }
            else
            {
                return this._v16_0.Equals(other._v16_0) & this._v16_16.Equals(other._v16_16);
            }
        }

        public override readonly bool Equals(object obj) => Equals((sbyte32)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override readonly int GetHashCode()
        {
            if (Avx2.IsAvx2Supported)
            {
                return Hash.v256(this);
            }
            else
            {
                return _v16_0.GetHashCode() ^ _v16_16.GetHashCode();
            }
        }


        public override readonly string ToString() =>  $"sbyte32({x0}, {x1}, {x2}, {x3},    {x4}, {x5}, {x6}, {x7},    {x8}, {x9}, {x10}, {x11},    {x12}, {x13}, {x14}, {x15},    {x16}, {x17}, {x18}, {x19},    {x20}, {x21}, {x22}, {x23},    {x24}, {x25}, {x26}, {x27},    {x28}, {x29}, {x30}, {x31})";
        public readonly string ToString(string format, IFormatProvider formatProvider) => $"sbyte32({x0.ToString(format, formatProvider)}, {x1.ToString(format, formatProvider)}, {x2.ToString(format, formatProvider)}, {x3.ToString(format, formatProvider)},    {x4.ToString(format, formatProvider)}, {x5.ToString(format, formatProvider)}, {x6.ToString(format, formatProvider)}, {x7.ToString(format, formatProvider)},    {x8.ToString(format, formatProvider)}, {x9.ToString(format, formatProvider)}, {x10.ToString(format, formatProvider)}, {x11.ToString(format, formatProvider)},    {x12.ToString(format, formatProvider)}, {x13.ToString(format, formatProvider)}, {x14.ToString(format, formatProvider)}, {x15.ToString(format, formatProvider)},    {x16.ToString(format, formatProvider)}, {x17.ToString(format, formatProvider)}, {x18.ToString(format, formatProvider)}, {x19.ToString(format, formatProvider)},    {x20.ToString(format, formatProvider)}, {x21.ToString(format, formatProvider)}, {x22.ToString(format, formatProvider)}, {x23.ToString(format, formatProvider)},    {x24.ToString(format, formatProvider)}, {x25.ToString(format, formatProvider)}, {x26.ToString(format, formatProvider)}, {x27.ToString(format, formatProvider)},    {x28.ToString(format, formatProvider)}, {x29.ToString(format, formatProvider)}, {x30.ToString(format, formatProvider)}, {x31.ToString(format, formatProvider)})";
    }
}