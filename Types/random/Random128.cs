﻿using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;
using DevTools;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    /*[Serializable]
    unsafe public struct Random128
    {
        public v128 state;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random128(ulong seed)
        {
Assert.AreNotEqual(seed, 0ul);

            Random64 next = new Random64(seed);

            state = new v128(next.NextULong(), next.NextULong());

            NextState16();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random128(v128 seed)
        {
Assert.IsTrue(maxmath.all_dif(seed, default(ushort8)));
Assert.IsTrue(maxmath.all_dif((ushort8)seed));

            state = seed;

            NextState16();
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ushort8 NextState16()
        {
Assert.IsTrue(maxmath.all_dif((ushort8)state, default(ushort8)));
Assert.IsTrue(maxmath.all_dif((ushort8)state));

            ushort8 t = state;

            state = Sse2.xor_si128(state, Sse2.slli_epi16(state, 7));
            state = Sse2.xor_si128(state, Sse2.srli_epi16(state, 9));
            state = Sse2.xor_si128(state, Sse2.slli_epi16(state, 13));

            return t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private uint4 NextState32()
        {
Assert.IsTrue(maxmath.all_dif((ushort8)state, default(ushort8)));
Assert.IsTrue(maxmath.all_dif((ushort8)state));

            fixed (void* ptr = &this)
            {
                uint4 t = *(uint4*)ptr;
                NextState16();

                t ^= t << 13;
                t ^= t >> 7;
                t ^= t << 5;

                return t;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ulong2 NextState64()
        {
Assert.IsTrue(maxmath.all_dif((ushort8)state, default(ushort8)));
Assert.IsTrue(maxmath.all_dif((ushort8)state));

            ulong2 t = state;
            NextState16();

            t ^= t << 13;
            t ^= t >> 7;
            t ^= t << 17;

            return t;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool16 NextBool16()
        {
            ulong2 result = (ulong2)(v128)NextState16() & 0x0101_0101_0101_0101ul;

            return (v128)result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2 NextShort2()
        {
            return (short.MinValue ^ (short8)NextState16()).v2_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2 NextShort2(short2 max)
        {
Assert.IsGreater(max.x, -1);
Assert.IsGreater(max.y, -1);

            return Sse2.mulhi_epu16(NextShort2(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short2 NextShort2(short2 min, short2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;

            return Sse2.mulhi_epu16(NextShort2(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3 NextShort3()
        {
            return (short.MinValue ^ (short8)NextState16()).v3_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3 NextShort3(short3 max)
        {
Assert.IsGreater(max.x, -1);
Assert.IsGreater(max.y, -1);
Assert.IsGreater(max.z, -1);

            return Sse2.mulhi_epu16(NextShort3(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short3 NextShort3(short3 min, short3 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);

            max -= min;

            return Sse2.mulhi_epu16(NextShort3(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4 NextShort4()
        {
            return (short.MinValue ^ (short8)NextState16()).v4_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4 NextShort4(short4 max)
        {
Assert.IsGreater(max.x, -1);
Assert.IsGreater(max.y, -1);
Assert.IsGreater(max.z, -1);
Assert.IsGreater(max.w, -1);

            return Sse2.mulhi_epu16(NextShort4(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4 NextShort4(short4 min, short4 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);
Assert.IsNotSmaller(max.w, min.w);

            max -= min;

            return Sse2.mulhi_epu16(NextShort4(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short8 NextShort8()
        {
            return short.MinValue ^ (short8)NextState16();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short8 NextShort8(short8 max)
        {
Assert.IsGreater(max.x0, -1);
Assert.IsGreater(max.x1, -1);
Assert.IsGreater(max.x2, -1);
Assert.IsGreater(max.x3, -1);
Assert.IsGreater(max.x4, -1);
Assert.IsGreater(max.x5, -1);
Assert.IsGreater(max.x6, -1);
Assert.IsGreater(max.x7, -1);

            return Sse2.mulhi_epu16(NextShort8(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short8 NextShort8(short8 min, short8 max)
        {
Assert.IsNotSmaller(max.x0, min.x0);
Assert.IsNotSmaller(max.x1, min.x1);
Assert.IsNotSmaller(max.x2, min.x2);
Assert.IsNotSmaller(max.x3, min.x3);
Assert.IsNotSmaller(max.x4, min.x4);
Assert.IsNotSmaller(max.x5, min.x5);
Assert.IsNotSmaller(max.x6, min.x6);
Assert.IsNotSmaller(max.x7, min.x7);

            max -= min;

            return Sse2.mulhi_epu16(NextShort8(), max) + min;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort2 NextUShort2()
        {
            return ((ushort8)NextState16() - 1).v2_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort2 NextUShort2(ushort2 max)
        {
            return Sse2.mulhi_epu16(NextUShort2(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort2 NextUShort2(ushort2 min, ushort2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;

            return Sse2.mulhi_epu16(NextUShort2(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3 NextUShort3()
        {
            return ((ushort8)NextState16() - 1).v3_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3 NextUShort3(ushort3 max)
        {
            return Sse2.mulhi_epu16(NextUShort3(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort3 NextUShort3(ushort3 min, ushort3 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);

            max -= min;

            return Sse2.mulhi_epu16(NextUShort3(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort4 NextUShort4()
        {
            return ((ushort8)NextState16() - 1).v4_0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort4 NextUShort4(ushort4 max)
        {
            return Sse2.mulhi_epu16(NextUShort4(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort4 NextUShort4(ushort4 min, ushort4 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);
Assert.IsNotSmaller(max.w, min.w);

            max -= min;

            return Sse2.mulhi_epu16(NextUShort4(), max) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort8 NextUShort8()
        {
            return (ushort8)NextState16() - 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort8 NextUShort8(ushort8 max)
        {
            return Sse2.mulhi_epu16(NextUShort8(), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort8 NextUShort8(ushort8 min, ushort8 max)
        {
Assert.IsNotSmaller(max.x0, min.x0);
Assert.IsNotSmaller(max.x1, min.x1);
Assert.IsNotSmaller(max.x2, min.x2);
Assert.IsNotSmaller(max.x3, min.x3);
Assert.IsNotSmaller(max.x4, min.x4);
Assert.IsNotSmaller(max.x5, min.x5);
Assert.IsNotSmaller(max.x6, min.x6);
Assert.IsNotSmaller(max.x7, min.x7);

            max -= min;

            return Sse2.mulhi_epu16(NextUShort8(), max) + min;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2 NextInt2()
        {
            return (int.MinValue ^ math.asint(NextState32())).xy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2 NextInt2(long2 max)
        {
Assert.IsGreater(max.x, -1);
Assert.IsGreater(max.y, -1);

            uint4 n = NextState32();

            ulong2 t = Sse2.mul_epu32(*(v128*)&n, max);
            t = Sse2.shuffle_epi32(t >> 32, Sse.SHUFFLE(0, 0,   2, 0));

            return *(int2*)&t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2 NextInt2(long2 min, long2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;
            uint4 n = NextState32();

            ulong2 t = Sse2.mul_epu32(*(v128*)&n, max);
            t = Sse2.shuffle_epi32((long2)(t >> 32) + min, Sse.SHUFFLE(0, 0,   2, 0));

            return *(int2*)&t;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2()
        {
            return (NextState32() - 1u).xy;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2(ulong2 max)
        {
            uint4 n = NextState32();

            ulong2 t = Sse2.mul_epu32(*(v128*)&n, max);
            t = Sse2.shuffle_epi32(t >> 32, Sse.SHUFFLE(0, 0, 2, 0));

            return *(uint2*)&t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2(ulong2 min, ulong2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;

            uint4 n = NextState32();

            ulong2 t = Sse2.mul_epu32(*(v128*)&n, max);
            t = Sse2.shuffle_epi32((t >> 32) + min, Sse.SHUFFLE(0, 0,   2, 0));

            return *(uint2*)&t;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long2 NextLong2()
        {
            return long.MinValue ^ (long2)NextState64();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long2 NextLong2(long2 max)
        {
Assert.IsGreater(max.x, -1L);
Assert.IsGreater(max.y, -1L);

            ulong2 next = NextState64();

            // swapped to not allocate ANOTHER regiser
            next.x = Common.umul128(next.x, (ulong)max.y, out ulong firstResult);
            next.y = Common.umul128(next.y, (ulong)max.x, out next.x);

            next.y = firstResult;

            return (long2)next;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long2 NextLong2(long2 min, long2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;
            ulong2 next = NextState64();

            // swapped to not allocate ANOTHER regiser
            next.x = Common.umul128(next.x, (ulong)max.y, out ulong firstResult);
            next.y = Common.umul128(next.y, (ulong)max.x, out next.x);

            next.y = firstResult;

            return min + (long2)next;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2 NextULong2()
        {
            return NextState64() - 1ul;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2 NextULong2(ulong2 max)
        {
            ulong2 next = NextState64();

            // swapped to not allocate ANOTHER regiser
            next.x = Common.umul128(next.x,     max.y,  out max.y);
            next.y = Common.umul128(next.y,     max.x,  out next.x);

            next.y = max.y;

            return next;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong2 NextULong2(ulong2 min, ulong2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            max -= min;
            ulong2 next = NextState64();

            // swapped to not allocate ANOTHER regiser
            next.x = Common.umul128(next.x, max.y, out max.y);
            next.y = Common.umul128(next.y, max.x, out next.x);

            next.y = max.y;

            return min + next;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2()
        {
            return math.asfloat(0x3f800000 | (NextState32().xy >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2(float2 max)
        {
            return NextFloat2() * max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2(float2 min, float2 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            return math.mad(NextFloat2(), (max - min), min);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3()
        {
            return math.asfloat(0x3f800000 | (NextState32().xyz >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3(float3 max)
        {
            return NextFloat3() * max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3(float3 min, float3 max)
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);

            return math.mad(NextFloat3(), (max - min), min);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4()
        {
            return math.asfloat(0x3f800000 | (NextState32() >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4(float4 max)
        {
            return NextFloat4() * max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4(float4 min, float4 max) 
        {
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);
Assert.IsNotSmaller(max.z, min.z);
Assert.IsNotSmaller(max.w, min.w);

            return math.mad(NextFloat4(), (max - min), min);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2()
        {
            ulong2 asdouble = 0x3FF0_0000_0000_0000 | (NextState64() >> 12);

            return *(double2*)&asdouble - 1d;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2(double2 max) 
        { 
            return NextDouble2() * max; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2(double2 min, double2 max) 
        { 
Assert.IsNotSmaller(max.x, min.x);
Assert.IsNotSmaller(max.y, min.y);

            return math.mad(NextDouble2(), (max - min), min); 
        }
    }*/
}