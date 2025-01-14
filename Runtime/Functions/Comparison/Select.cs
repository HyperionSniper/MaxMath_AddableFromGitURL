﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 select(UInt128 a, UInt128 b, bool c)
        {
            return new UInt128(math.select(a.lo, b.lo, c), math.select(a.hi, b.hi, c));
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int128 select(Int128 a, Int128 b, bool c)
        {
            return new Int128(math.select(a.intern.lo, b.intern.lo, c), math.select(a.intern.hi, b.intern.hi, c));
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte select(byte a, byte b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 select(byte2 a, byte2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 select(byte3 a, byte3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 select(byte4 a, byte4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 select(byte8 a, byte8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 select(byte16 a, byte16 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 select(byte32 a, byte32 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte select(sbyte a, sbyte b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 select(sbyte2 a, sbyte2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 select(sbyte3 a, sbyte3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 select(sbyte4 a, sbyte4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 select(sbyte8 a, sbyte8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 select(sbyte16 a, sbyte16 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 select(sbyte32 a, sbyte32 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort select(ushort a, ushort b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 select(ushort2 a, ushort2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 select(ushort3 a, ushort3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 select(ushort4 a, ushort4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 select(ushort8 a, ushort8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 select(ushort16 a, ushort16 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short select(short a, short b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 select(short2 a, short2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 select(short3 a, short3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 select(short4 a, short4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 select(short8 a, short8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 select(short16 a, short16 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 select(int8 a, int8 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 select(uint8 a, uint8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 select(long2 a, long2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 select(long3 a, long3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 select(long4 a, long4 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 select(ulong2 a, ulong2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 select(ulong3 a, ulong3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 select(ulong4 a, ulong4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter select(quarter a, quarter b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter2 select(quarter2 a, quarter2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter3 select(quarter3 a, quarter3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter4 select(quarter4 a, quarter4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter8 select(quarter8 a, quarter8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half select(half a, half b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half2 select(half2 a, half2 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 select(half3 a, half3 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 select(half4 a, half4 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half8 select(half8 a, half8 b, bool c)
        {
            return c ? b : a;
        }

        /// <summary>       Returns <paramref name="b"/> if <paramref name="c"/> is <see langword="true" />, <paramref name="a"/> otherwise.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 select(float8 a, float8 b, bool c)
        {
            return c ? b : a;
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 select(byte2 a, byte2 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.SByte2FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new byte2((byte)c, (byte)((uint)c >> 1))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 select(byte3 a, byte3 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.SByte4FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new byte3((byte)c, (byte)((uint)c >> 1), (byte)((uint)c >> 2))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 select(byte4 a, byte4 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.SByte4FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new byte4((byte)c, (byte)((uint)c >> 1), (byte)((uint)c >> 2), (byte)((uint)c >> 3))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 select(byte8 a, byte8 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.SByte8FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new byte8((byte)c, (byte)((uint)c >> 1), (byte)((uint)c >> 2), (byte)((uint)c >> 3), (byte)((uint)c >> 4), (byte)((uint)c >> 5), (byte)((uint)c >> 6), (byte)((uint)c >> 7))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte16"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 select(byte16 a, byte16 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.SByte16FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new byte16((byte)c, (byte)((uint)c >> 1), (byte)((uint)c >> 2), (byte)((uint)c >> 3), (byte)((uint)c >> 4), (byte)((uint)c >> 5), (byte)((uint)c >> 6), (byte)((uint)c >> 7), (byte)((uint)c >> 8), (byte)((uint)c >> 9), (byte)((uint)c >> 10), (byte)((uint)c >> 11), (byte)((uint)c >> 12), (byte)((uint)c >> 13), (byte)((uint)c >> 14), (byte)((uint)c >> 15))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte32"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 select(byte32 a, byte32 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(a, b, Mask.SByte32FromInt(c));
            }
            else if (Sse2.IsSse2Supported)
            {
                byte32 mask = (byte32)Mask.SByte32FromInt(c);

                return new byte32(Mask.BlendV(a._v16_0, b._v16_0, mask._v16_0), Mask.BlendV(a._v16_16, b._v16_16, mask._v16_16));
            }
            else
            {
                return new byte32(select(a.v16_0, b.v16_0, c), select(a.v16_16, b.v16_16, (int)((uint)c >> 16)));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 select(sbyte2 a, sbyte2 b, int c)
        {
            return (sbyte2)select((byte2)a, (byte2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 select(sbyte3 a, sbyte3 b, int c)
        {
            return (sbyte3)select((byte3)a, (byte3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 select(sbyte4 a, sbyte4 b, int c)
        {
            return (sbyte4)select((byte4)a, (byte4)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 select(sbyte8 a, sbyte8 b, int c)
        {
            return (sbyte8)select((byte8)a, (byte8)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte16"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 select(sbyte16 a, sbyte16 b, int c)
        {
            return (sbyte16)select((byte16)a, (byte16)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte32"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 select(sbyte32 a, sbyte32 b, int c)
        {
            return (sbyte32)select((byte32)a, (byte32)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 select(ushort2 a, ushort2 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.Short2FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new ushort2((ushort)c, (ushort)((uint)c >> 1))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 select(ushort3 a, ushort3 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.Short4FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new ushort3((ushort)c, (ushort)((uint)c >> 1), (ushort)((uint)c >> 2))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 select(ushort4 a, ushort4 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.Short4FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new ushort4((ushort)c, (ushort)((uint)c >> 1), (ushort)((uint)c >> 2), (ushort)((uint)c >> 3))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 select(ushort8 a, ushort8 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.Short8FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new ushort8((ushort)c, (ushort)((uint)c >> 1), (ushort)((uint)c >> 2), (ushort)((uint)c >> 3), (ushort)((uint)c >> 4), (ushort)((uint)c >> 5), (ushort)((uint)c >> 6), (ushort)((uint)c >> 7))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort16"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 select(ushort16 a, ushort16 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(a, b, Mask.Short16FromInt(c));
            }
            else
            {
                return new ushort16(select(a.v8_0, b.v8_0, c), select(a.v8_8, b.v8_8, (int)((uint)c >> 8)));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 select(short2 a, short2 b, int c)
        {
            return (short2)select((ushort2)a, (ushort2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 select(short3 a, short3 b, int c)
        {
            return (short3)select((ushort3)a, (ushort3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 select(short4 a, short4 b, int c)
        {
            return (short4)select((ushort4)a, (ushort4)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 select(short8 a, short8 b, int c)
        {
            return (short8)select((ushort8)a, (ushort8)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short16"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 select(short16 a, short16 b, int c)
        {
            return (short16)select((ushort16)a, (ushort16)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="int2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 select(int2 a, int2 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int2FromInt(c));

                return *(int2*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int2(c, (int)((uint)c >> 1))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="int3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 select(int3 a, int3 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c));

                return *(int3*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int3(c, (int)((uint)c >> 1), (int)((uint)c >> 2))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="int4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 select(int4 a, int4 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c));

                return *(int4*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int4(c, (int)((uint)c >> 1), (int)((uint)c >> 2), (int)((uint)c >> 3))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.int8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 select(int8 a, int8 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(a, b, Mask.Int8FromInt(c));
            }
            else
            {
                return new int8(select(a.v4_0, b.v4_0, c), select(a.v4_4, b.v4_4, (int)((uint)c >> 4)));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="uint2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 select(uint2 a, uint2 b, int c)
        {
            return (uint2)select((int2)a, (int2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="uint3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 select(uint3 a, uint3 b, int c)
        {
            return (uint3)select((int3)a, (int3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="uint4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 select(uint4 a, uint4 b, int c)
        {
            return (uint4)select((int4)a, (int4)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.uint8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 select(uint8 a, uint8 b, int c)
        {
            return (uint8)select((int8)a, (int8)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 select(long2 a, long2 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(a, b, Mask.Long2FromInt(c));
            }
            else
            {
                return select(a, b, tobool(1 & new long2(c, (uint)c >> 1)));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 select(long3 a, long3 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(a, b, Mask.Long3FromInt(c));
            }
            else
            {
                return new long3(select(a.xy, b.xy, c), tobool(((uint)c >> 2) & 1) ? b.z : a.z);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 select(long4 a, long4 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(a, b, Mask.Long4FromInt(c));
            }
            else
            {
                return new long4(select(a.xy, b.xy, c), select(a.zw, b.zw, c >> 2));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 select(ulong2 a, ulong2 b, int c)
        {
            return (ulong2)select((long2)a, (long2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 select(ulong3 a, ulong3 b, int c)
        {
            return (ulong3)select((long3)a, (long3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 select(ulong4 a, ulong4 b, int c)
        {
            return (ulong4)select((long4)a, (long4)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter2 select(quarter2 a, quarter2 b, int c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter3 select(quarter3 a, quarter3 b, int c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter4 select(quarter4 a, quarter4 b, int c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter8 select(quarter8 a, quarter8 b, int c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }


        /// <summary>       Returns a componentwise selection between two <see cref="half2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half2 select(half2 a, half2 b, int c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="half3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 select(half3 a, half3 b, int c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="half4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 select(half4 a, half4 b, int c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.half8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half8 select(half8 a, half8 b, int c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }


        /// <summary>       Returns a componentwise selection between two <see cref="double2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 select(double2 a, double2 b, int c)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Long2FromInt(c));

                return *(double2*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new long2(c, (uint)c >> 1)));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="double3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 select(double3 a, double3 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 temp = Avx.mm256_blendv_pd(UnityMathematicsLink.Tov256(a), UnityMathematicsLink.Tov256(b), Mask.Long3FromInt(c));

                return *(double3*)&temp;
            }
            else
            {
                return new double3(select(a.xy, b.xy, c), tobool(((uint)c >> 2) & 1) ? b.z : a.z);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="double4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 select(double4 a, double4 b, int c)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 temp = Avx.mm256_blendv_pd(UnityMathematicsLink.Tov256(a), UnityMathematicsLink.Tov256(b), Mask.Long4FromInt(c));

                return *(double4*)&temp;
            }
            else
            {
                return new double4(select(a.xy, b.xy, c), select(a.zw, b.zw, c >> 2));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="float2"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 select(float2 a, float2 b, int c)
        {
            if (Sse4_1.IsSse41Supported)
            {
                v128 temp = Sse4_1.blendv_ps(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int2FromInt(c));
            
                return *(float2*)&temp;
            }
            else if (Sse2.IsSse2Supported)
            { 
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int2FromInt(c), false);
            
                return *(float2*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int2(c, (int)((uint)c >> 1))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="float3"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 select(float3 a, float3 b, int c)
        {
            if (Sse4_1.IsSse41Supported)
            {
                v128 temp = Sse4_1.blendv_ps(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c));

                return *(float3*)&temp;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c), false);

                return *(float3*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int3(c, (int)((uint)c >> 1), (int)((uint)c >> 2))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="float4"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 select(float4 a, float4 b, int c)
        {
            if (Sse4_1.IsSse41Supported)
            {
                v128 temp = Sse4_1.blendv_ps(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c));
            
                return *(float4*)&temp;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 temp = Mask.BlendV(UnityMathematicsLink.Tov128(a), UnityMathematicsLink.Tov128(b), Mask.Int4FromInt(c), false);
            
                return *(float4*)&temp;
            }
            else
            {
                return math.select(a, b, tobool(1 & new int4(c, (int)((uint)c >> 1), (int)((uint)c >> 2), (int)((uint)c >> 3))));
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.float8"/>s <paramref name="a"/> and <paramref name="b"/> based on a bitmask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when the corresponding LSB order bit in <paramref name="c"/> is 1, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 select(float8 a, float8 b, int c)
        {
            if (Avx.IsAvxSupported)
            {
                return Avx.mm256_blendv_ps(a, b, Mask.Int8FromInt(c));
            }
            else
            {
                return new float8(select(a.v4_0, b.v4_0, c), select(a.v4_4, b.v4_4, (int)((uint)c >> 4)));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 select(byte2 a, byte2 b, bool2 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128)));
            }
            else
            {
                return new byte2(c.x ? b.x : a.x, c.y ? b.y : a.y);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 select(byte3 a, byte3 b, bool3 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128)));
            }
            else
            {
                return new byte3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 select(byte4 a, byte4 b, bool4 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128)));
            }
            else
            {
                return new byte4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 select(byte8 a, byte8 b, bool8 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Sse2.cmpeq_epi8(c, default(v128)));
            }
            else
            {
                return new byte8(c.x0 ? b.x0 : a.x0, c.x1 ? b.x1 : a.x1, c.x2 ? b.x2 : a.x2, c.x3 ? b.x3 : a.x3, c.x4 ? b.x4 : a.x4, c.x5 ? b.x5 : a.x5, c.x6 ? b.x6 : a.x6, c.x7 ? b.x7 : a.x7);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte16"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool16"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 select(byte16 a, byte16 b, bool16 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Sse2.cmpeq_epi8(c, default(v128)));
            }
            else
            {
                return new byte16(c.x0 ? b.x0 : a.x0, c.x1 ? b.x1 : a.x1, c.x2 ? b.x2 : a.x2, c.x3 ? b.x3 : a.x3, c.x4 ? b.x4 : a.x4, c.x5 ? b.x5 : a.x5, c.x6 ? b.x6 : a.x6, c.x7 ? b.x7 : a.x7, c.x8 ? b.x8 : a.x8, c.x9 ? b.x9 : a.x9, c.x10 ? b.x10 : a.x10, c.x11 ? b.x11 : a.x11, c.x12 ? b.x12 : a.x12, c.x13 ? b.x13 : a.x13, c.x14 ? b.x14 : a.x14, c.x15 ? b.x15 : a.x15);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.byte32"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool32"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 select(byte32 a, byte32 b, bool32 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(b, a, Avx2.mm256_cmpeq_epi8(c, default(v256)));
            }
            else
            {
                return new byte32(select(a.v16_0, b.v16_0, c.v16_0), select(a.v16_16, b.v16_16, c.v16_16));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 select(sbyte2 a, sbyte2 b, bool2 c)
        {
            return (sbyte2)select((byte2)a, (byte2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 select(sbyte3 a, sbyte3 b, bool3 c)
        {
            return (sbyte3)select((byte3)a, (byte3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 select(sbyte4 a, sbyte4 b, bool4 c)
        {
            return (sbyte4)select((byte4)a, (byte4)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 select(sbyte8 a, sbyte8 b, bool8 c)
        {
            return (sbyte8)select((byte8)a, (byte8)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte16"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool16"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 select(sbyte16 a, sbyte16 b, bool16 c)
        {
            return (sbyte16)select((byte16)a, (byte16)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.sbyte32"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool32"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 select(sbyte32 a, sbyte32 b, bool32 c)
        {
            return (sbyte32)select((byte32)a, (byte32)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 select(ushort2 a, ushort2 b, bool2 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Cast.SByteToShort(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new ushort2(c.x ? b.x : a.x, c.y ? b.y : a.y);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort3"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 select(ushort3 a, ushort3 b, bool3 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Cast.SByteToShort(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new ushort3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 select(ushort4 a, ushort4 b, bool4 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Cast.SByteToShort(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new ushort4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 select(ushort8 a, ushort8 b, bool8 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Cast.SByteToShort(Sse2.cmpeq_epi8(c, default(v128))));
            }
            else
            {
                return new ushort8(c.x0 ? b.x0 : a.x0, c.x1 ? b.x1 : a.x1, c.x2 ? b.x2 : a.x2, c.x3 ? b.x3 : a.x3, c.x4 ? b.x4 : a.x4, c.x5 ? b.x5 : a.x5, c.x6 ? b.x6 : a.x6, c.x7 ? b.x7 : a.x7);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ushort16"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool16"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 select(ushort16 a, ushort16 b, bool16 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(b, a, Avx2.mm256_cvtepi8_epi16(Sse2.cmpeq_epi8(c, default(v128))));
            }
            else
            {
                return new ushort16(select(a.v8_0, b.v8_0, c.v8_0), select(a.v8_8, b.v8_8, c.v8_8));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 select(short2 a, short2 b, bool2 c)
        {
            return (short2)select((ushort2)a, (ushort2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short3"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 select(short3 a, short3 b, bool3 c)
        {
            return (short3)select((ushort3)a, (ushort3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 select(short4 a, short4 b, bool4 c)
        {
            return (short4)select((ushort4)a, (ushort4)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 select(short8 a, short8 b, bool8 c)
        {
            return (short8)select((ushort8)a, (ushort8)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.short16"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool16"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 select(short16 a, short16 b, bool16 c)
        {
            return (short16)select((ushort16)a, (ushort16)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.int8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 select(int8 a, int8 b, bool8 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(b, a, Avx2.mm256_cvtepi8_epi32(Sse2.cmpeq_epi8(c, default(v128))));
            }
            else
            {
                return new int8(math.select(a.v4_0, b.v4_0, c.v4_0), math.select(a.v4_4, b.v4_4, c.v4_4));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.uint8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 select(uint8 a, uint8 b, bool8 c)
        {
            return (uint8)select((int8)a, (int8)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 select(long2 a, long2 b, bool2 c)
        {
            if (Sse2.IsSse2Supported)
            {
                return Mask.BlendV(b, a, Cast.SByteToLong(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new long2(c.x ? b.x : a.x, c.y ? b.y : a.y);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long3"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 select(long3 a, long3 b, bool3 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(b, a, Avx2.mm256_cvtepi8_epi64(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new long3(select(a.xy, b.xy, c.xy), c.z ? b.z : a.z);
            }
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.long4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 select(long4 a, long4 b, bool4 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_blendv_epi8(b, a, Avx2.mm256_cvtepi8_epi64(Sse2.cmpeq_epi8(UnityMathematicsLink.Tov128(c), default(v128))));
            }
            else
            {
                return new long4(select(a.xy, b.xy, c.xy), select(a.zw, b.zw, c.zw));
            }
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 select(ulong2 a, ulong2 b, bool2 c)
        {
            return (ulong2)select((long2)a, (long2)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong3"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 select(ulong3 a, ulong3 b, bool3 c)
        {
            return (ulong3)select((long3)a, (long3)b, c);
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.ulong4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 select(ulong4 a, ulong4 b, bool4 c)
        {
            return (ulong4)select((long4)a, (long4)b, c);
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter2 select(quarter2 a, quarter2 b, bool2 c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter3 select(quarter3 a, quarter3 b, bool3 c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter4 select(quarter4 a, quarter4 b, bool4 c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.quarter8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quarter8 select(quarter8 a, quarter8 b, bool8 c)
        {
            return asquarter(select(asbyte(a), asbyte(b), c));
        }


        /// <summary>       Returns a componentwise selection between two <see cref="half2"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool2"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half2 select(half2 a, half2 b, bool2 c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="half3"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool3"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half3 select(half3 a, half3 b, bool3 c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="half4"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="bool4"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half4 select(half4 a, half4 b, bool4 c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }

        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.half8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static half8 select(half8 a, half8 b, bool8 c)
        {
            return ashalf(select(asushort(a), asushort(b), c));
        }


        /// <summary>       Returns a componentwise selection between two <see cref="MaxMath.float8"/>s <paramref name="a"/> and <paramref name="b"/> based on a <see cref="MaxMath.bool8"/> selection mask <paramref name="c"/>. Per component, the component from <paramref name="b"/> is selected when <paramref name="c"/> is <see langword="true" />, otherwise the component from <paramref name="a"/> is selected.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 select(float8 a, float8 b, bool8 c)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx.mm256_blendv_ps(b, a, Avx2.mm256_cvtepi8_epi32(Sse2.cmpeq_epi8(c, default(v128))));
            }
            else if (Avx.IsAvxSupported)
            {
                return Avx.mm256_blendv_ps(b, a, (int8)((sbyte8)Sse2.cmpeq_epi8(c, default(v128))));
            }
            else
            {
                return new float8(math.select(a.v4_0, b.v4_0, c.v4_0), math.select(a.v4_4, b.v4_4, c.v4_4));
            }
        }
    }
}