﻿using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe internal static partial class Operator
    {
        // could simply take in a v128, but that increases code size. (full XMM data)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte2 shl_byte(sbyte2 x, int n)
        {
            sbyte2 mask = (sbyte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 shl_byte(byte2 x, int n)
        {
            byte2 mask = (byte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte3 shl_byte(sbyte3 x, int n)
        {
            sbyte4 mask = (sbyte)(0b1111_1111 >> n);

            return shl_short((v128)x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 shl_byte(byte3 x, int n)
        {
            byte4 mask = (byte)(0b1111_1111 >> n);

            return shl_short((v128)x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte4 shl_byte(sbyte4 x, int n)
        {
            sbyte4 mask = (sbyte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 shl_byte(byte4 x, int n)
        {
            byte4 mask = (byte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte8 shl_byte(sbyte8 x, int n)
        {
            sbyte8 mask = (sbyte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 shl_byte(byte8 x, int n)
        {
            byte8 mask = (byte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte16 shl_byte(sbyte16 x, int n)
        {
            sbyte16 mask = (sbyte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 shl_byte(byte16 x, int n)
        {
            byte16 mask = (byte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shl_byte(v256 x, int n)
        {
            byte32 mask = (byte)(0b1111_1111 >> n);

            return shl_short(x & mask, n);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte2 shrl_byte(sbyte2 x, int n)
        {
            sbyte2 mask = (sbyte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte2 shrl_byte(byte2 x, int n)
        {
            byte2 mask = (byte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte3 shrl_byte(sbyte3 x, int n)
        {
            sbyte4 mask = (sbyte)(0b1111_1111 << n);

            return shrl_short((v128)x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte3 shrl_byte(byte3 x, int n)
        {
            byte4 mask = (byte)(0b1111_1111 << n);

            return shrl_short((v128)x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte4 shrl_byte(sbyte4 x, int n)
        {
            sbyte4 mask = (sbyte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte4 shrl_byte(byte4 x, int n)
        {
            byte4 mask = (byte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte8 shrl_byte(sbyte8 x, int n)
        {
            sbyte8 mask = (sbyte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte8 shrl_byte(byte8 x, int n)
        {
            byte8 mask = (byte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte16 shrl_byte(sbyte16 x, int n)
        {
            sbyte16 mask = (sbyte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static byte16 shrl_byte(byte16 x, int n)
        {
            byte16 mask = (byte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shrl_byte(v256 x, int n)
        {
            byte32 mask = (byte)(0b1111_1111 << n);

            return shrl_short(x & mask, n);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static sbyte16 shra_byte(sbyte16 x, int n)
        {
            v128 even = shra_short(shl_short(x, 8), n + 8);
            v128 odd = shra_short(x, n);

            return Mask.BlendV(even, odd, new v128(0xFF00_FF00));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shra_byte(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 even = shra_short(shl_short(x, 8), n + 8);
                v256 odd = shra_short(x, n);

                return Avx2.mm256_blendv_epi8(even, odd, new v256(0xFF00_FF00));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shl_short(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.sll_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shl_short(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sll_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shrl_short(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.srl_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shrl_short(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srl_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shra_short(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.sra_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shra_short(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sra_epi16(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shra_int(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.sra_epi32(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shra_int(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sra_epi32(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shrl_int(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.srl_epi32(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shrl_int(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srl_epi32(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shl_int(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sll_epi32(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shl_long(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.sll_epi64(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shl_long(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sll_epi64(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v128 shrl_long(v128 x, int n)
        {
            if (Sse2.IsSse2Supported)
            {
                return Sse2.srl_epi64(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shrl_long(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srl_epi64(x, new v128(n, 0, 0, 0));
            }
            else throw new BurstCompilerException();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static long2 shra_long(long2 x, int n)
        {
            v128 shiftLo;
            v128 shiftHi;

            if (n <= 32)
            {
                shiftHi = shra_int(x, n);
                shiftLo = shrl_long(x, n);
            }
            else
            {
                shiftHi = shra_int(x, 31);
                shiftLo = shra_int(x, n - 32);
                shiftLo = shrl_long(shiftLo, 32);
            }

            return Mask.BlendEpi16(shiftLo, shiftHi, 0b1100_1100);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static v256 shra_long(v256 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 shiftLo;
                v256 shiftHi;

                if (n <= 32)
                {
                    shiftHi = shra_int(x, n);
                    shiftLo = shrl_long(x, n);
                }
                else
                {
                    shiftHi = shra_int(x, 31);
                    shiftLo = shra_int(x, n - 32);
                    shiftLo = shrl_long(shiftLo, 32);
                }

                return Avx2.mm256_blend_epi32(shiftLo, shiftHi, 0b1010_1010);
            }
            else throw new BurstCompilerException();
        }
    }
}