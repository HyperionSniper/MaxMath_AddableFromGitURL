﻿using DevTools;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;
using Unity.Burst.CompilerServices;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    [Serializable]  [StructLayout(LayoutKind.Explicit, Size = 3 * sizeof(ulong))]  [DebuggerTypeProxy(typeof(long3.DebuggerProxy))]
    unsafe public struct ulong3 : IEquatable<ulong3>, IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public ulong x;
            public ulong y;
            public ulong z;

            public DebuggerProxy(ulong3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }


        [FieldOffset(0)]  private fixed ulong asArray[3];

        [FieldOffset(0)]  internal ulong2 _xy;

        [FieldOffset(0)]  public ulong x;
        [FieldOffset(8)]  public ulong y;
        [FieldOffset(16)] public ulong z;


        public static ulong3 zero => default;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong y, ulong z)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_set_epi64x(0L, (long)z, (long)y, (long)x);
            }
            else if (Sse2.IsSse2Supported)
            {
                this = new ulong3 { _xy = new ulong2(x, y), z = z };
            }
            else
            {
                this = new ulong3 { x = x, y = y, z = z };
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong xyz)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_set1_epi64x((long)xyz);
            }
            else if (Sse2.IsSse2Supported)
            {
                this = new ulong3 { _xy = new ulong2(xyz), z = xyz };
            }
            else
            {
                this = new ulong3 { x = xyz, y = xyz, z = xyz };
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong2 xy, ulong z)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_insert_epi64(Avx.mm256_castsi128_si256(xy), (long)z, 2);
            }
            else
            {
                this = new ulong3 { _xy = xy, z = z };
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong3(ulong x, ulong2 yz)
        {
            if (Avx.IsAvxSupported)
            {
                this = Avx.mm256_insert_epi64(yz.xxy, (long)x, 0);
            }
            else if (Sse2.IsSse2Supported)
            {
                yz = yz.yx;
                ulong z = yz.x;
                yz.x = x;

                this = new ulong3 { _xy = yz, z = z };
            }
            else
            {
                this = new ulong3 { x = x, y = yz.x, z = yz.y };
            }
        }

        
        #region Shuffle
        public ulong4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_broadcastq_epi64(Avx.mm256_castsi256_si128(this));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _xx = xx;

                    return new ulong4(_xx, _xx);
                }
                else
                {
                    return new ulong4(x, x, x, x);
                }
            }
        }
        public ulong4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, _xy);
                }
                else
                {
                    return new ulong4(x, x, x, y);
                }
            }
        }
        public ulong4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, xz);
                }
                else
                {
                    return new ulong4(x, x, x, z);
                }
            }
        }
        public ulong4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, yx);
                }
                else
                {
                    return new ulong4(x, x, y, x);
                }
            }
        }
        public ulong4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, yy);
                }
                else
                {
                    return new ulong4(x, x, y, y);
                }
            }
        }
        public ulong4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, yz);
                }
                else
                {
                    return new ulong4(x, x, y,z);
                }
            }
        }
        public ulong4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, zx);
                }
                else
                {
                    return new ulong4(x, x, z, x);
                }
            }
        }
        public ulong4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, zy);
                }
                else
                {
                    return new ulong4(x, x, z, y);
                }
            }
        }
        public ulong4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_shuffle_epi32(this, Sse.SHUFFLE(1, 0, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xx, zz);
                }
                else
                {
                    return new ulong4(x, x, z, z);
                }
            }
        }
        public ulong4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, xx);
                }
                else
                {
                    return new ulong4(x, y, x, x);
                }
            }
        }
        public ulong4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_broadcastsi128_si256(Avx.mm256_castsi256_si128(this));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, _xy);
                }
                else
                {
                    return new ulong4(x, y, x, y);
                }
            }
        }
        public ulong4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, xz);
                }
                else
                {
                    return new ulong4(x, y, x, z);
                }
            }
        }
        public ulong4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, yx);
                }
                else
                {
                    return new ulong4(x, y, y, x);
                }
            }
        }
        public ulong4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, yy);
                }
                else
                {
                    return new ulong4(x, y, y, y);
                }
            }
        }
        public ulong4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, yz);
                }
                else
                {
                    return new ulong4(x, y, y, z);
                }
            }
        }
        public ulong4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, zx);
                }
                else
                {
                    return new ulong4(x, y, z, x);
                }
            }
        }
        public ulong4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, zy);
                }
                else
                {
                    return new ulong4(x, y, z, y);
                }
            }
        }
        public ulong4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(_xy, zz);
                }
                else
                {
                    return new ulong4(x, y, z, z);
                }
            }
        }
        public ulong4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, xx);
                }
                else
                {
                    return new ulong4(x, z, x, x);
                }
            }
        }
        public ulong4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, _xy);
                }
                else
                {
                    return new ulong4(x, z, x, y);
                }
            }
        }
        public ulong4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _xz = xz;

                    return new ulong4(_xz, _xz);
                }
                else
                {
                    return new ulong4(x, z, x, z);
                }
            }
        }
        public ulong4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, yx);
                }
                else
                {
                    return new ulong4(x, z, y, x);
                }
            }
        }
        public ulong4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, yy);
                }
                else
                {
                    return new ulong4(x, z, y, y);
                }
            }
        }
        public ulong4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, yz);
                }
                else
                {
                    return new ulong4(x, z, y, z);
                }
            }
        }
        public ulong4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, zx);
                }
                else
                {
                    return new ulong4(x, z, z, x);
                }
            }
        }
        public ulong4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, zy);
                }
                else
                {
                    return new ulong4(x, z, z, y);
                }
            }
        }
        public ulong4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(xz, zz);
                }
                else
                {
                    return new ulong4(x, z, z, z);
                }
            }
        }
        public ulong4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, xx);
                }
                else
                {
                    return new ulong4(y, x, x,  x);
                }
            }
        }
        public ulong4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, _xy);
                }
                else
                {
                    return new ulong4(y, x, x, y);
                }
            }
        }
        public ulong4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, xz);
                }
                else
                {
                    return new ulong4(y, x, x, z);
                }
            }
        }
        public ulong4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _yx = yx;

                    return new ulong4(_yx, _yx);
                }
                else
                {
                    return new ulong4(y, x, y, x);
                }
            }
        }
        public ulong4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, yy);
                }
                else
                {
                    return new ulong4(y, x, y, y);
                }
            }
        }
        public ulong4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, yz);
                }
                else
                {
                    return new ulong4(y, x, y, z);
                }
            }
        }
        public ulong4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, zx);
                }
                else
                {
                    return new ulong4(y, x, z, x);
                }
            }
        }
        public ulong4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, zy);
                }
                else
                {
                    return new ulong4(y, x, z, y);
                }
            }
        }
        public ulong4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yx, zz);
                }
                else
                {
                    return new ulong4(y, x, z, z);
                }
            }
        }
        public ulong4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, xx);
                }
                else
                {
                    return new ulong4(y, y, x, x);
                }
            }
        }
        public ulong4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, _xy);
                }
                else
                {
                    return new ulong4(y, y, x, y);
                }
            }
        }
        public ulong4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, xz);
                }
                else
                {
                    return new ulong4(y, y, x, z);
                }
            }
        }
        public ulong4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, yx);
                }
                else
                {
                    return new ulong4(y, y, y, x);
                }
            }
        }
        public ulong4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _yy = yy;

                    return new ulong4(_yy, _yy);
                }
                else
                {
                    return new ulong4(y, y, y, y);
                }
            }
        }
        public ulong4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, yz);
                }
                else
                {
                    return new ulong4(y, y, y, z);
                }
            }
        }
        public ulong4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, zx);
                }
                else
                {
                    return new ulong4(y, y, z, x);
                }
            }
        }
        public ulong4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, zy);
                }
                else
                {
                    return new ulong4(y, y, z, y);
                }
            }
        }
        public ulong4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yy, zz);
                }
                else
                {
                    return new ulong4(y, y, z, z);
                }
            }
        }
        public ulong4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, xx);
                }
                else
                {
                    return new ulong4(y, z, x, x);
                }
            }
        }
        public ulong4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, _xy);
                }
                else
                {
                    return new ulong4(y, z, x, y);
                }
            }
        }
        public ulong4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, xz);
                }
                else
                {
                    return new ulong4(y, z, x, z);
                }
            }
        }
        public ulong4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, yx);
                }
                else
                {
                    return new ulong4(y, z, y, x);
                }
            }
        }
        public ulong4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, yy);
                }
                else
                {
                    return new ulong4(y, z, y, y);
                }
            }
        }
        public ulong4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _yz = yz;

                    return new ulong4(_yz, _yz);
                }
                else
                {
                    return new ulong4(y, z, y, z);
                }
            }
        }
        public ulong4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, zx);
                }
                else
                {
                    return new ulong4(y, z, z, x);
                }
            }
        }
        public ulong4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                { 
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, zy);
                }
                else
                {
                    return new ulong4(y, z, z, y);
                }
            }
        }
        public ulong4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(yz, zz);
                }
                else
                {
                    return new ulong4(y, z, z, z);
                }
            }
        }
        public ulong4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, xx);
                }
                else
                {
                    return new ulong4(z, x, x, x);
                }
            }
        }
        public ulong4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, _xy);
                }
                else
                {
                    return new ulong4(z, x, x, y);
                }
            }
        }
        public ulong4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, xz);
                }
                else
                {
                    return new ulong4(z, x, x, z);
                }
            }
        }
        public ulong4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, yx);
                }
                else
                {
                    return new ulong4(z, x, y, x);
                }
            }
        }
        public ulong4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, yy);
                }
                else
                {
                    return new ulong4(z, x, y, y);
                }
            }
        }
        public ulong4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, yz);
                }
                else
                {
                    return new ulong4(z, x, y, z);
                }
            }
        }
        public ulong4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _zx = zx;

                    return new ulong4(_zx, _zx);
                }
                else
                {
                    return new ulong4(z, x, z, x);
                }
            }
        }
        public ulong4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, zy);
                }
                else
                {
                    return new ulong4(z, x, z, y);
                }
            }
        }
        public ulong4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zx, zz);
                }
                else
                {
                    return new ulong4(z, x, z, z);
                }
            }
        }
        public ulong4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, xx);
                }
                else
                {
                    return new ulong4(z, y, x, x);
                }
            }
        }
        public ulong4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, _xy);
                }
                else
                {
                    return new ulong4(z, y, x, y);
                }
            }
        }
        public ulong4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, xz);
                }
                else
                {
                    return new ulong4(z, y, x, z);
                }
            }
        }
        public ulong4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, yx);
                }
                else
                {
                    return new ulong4(z, y, y, x);
                }
            }
        }
        public ulong4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, yy);
                }
                else
                {
                    return new ulong4(z, y, y, y);
                }
            }
        }
        public ulong4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, yz);
                }
                else
                {
                    return new ulong4(z, y, y, z);
                }
            }
        }
        public ulong4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, zx);
                }
                else
                {
                    return new ulong4(z, y, z, x);
                }
            }
        }
        public ulong4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _zy = zy;

                    return new ulong4(_zy, _zy);
                }
                else
                {
                    return new ulong4(z, y, z, y);
                }
            }
        }
        public ulong4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zy, zz);
                }
                else
                {
                    return new ulong4(z, y, z, z);
                }
            }
        }
        public ulong4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 0, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, xx);
                }
                else
                {
                    return new ulong4(z, z, x, x);
                }
            }
        }
        public ulong4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 0, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, _xy);
                }
                else
                {
                    return new ulong4(z, z, x, y);
                }
            }
        }
        public ulong4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 0, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, xz);
                }
                else
                {
                    return new ulong4(z, z, x, z);
                }
            }
        }
        public ulong4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 1, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, yx);
                }
                else
                {
                    return new ulong4(z, z, y, x);
                }
            }
        }
        public ulong4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 1, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, yy);
                }
                else
                {
                    return new ulong4(z, z, y, y);
                }
            }
        }
        public ulong4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 1, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, yz);
                }
                else
                {
                    return new ulong4(z, z, y, z);
                }
            }
        }
        public ulong4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(0, 2, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, zx);
                }
                else
                {
                    return new ulong4(z, z, z, x);
                }
            }
        }
        public ulong4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(1, 2, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong4(zz, zy);
                }
                else
                {
                    return new ulong4(z, z, z, y);
                }
            }
        }
        public ulong4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(2, 2, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _zz = zz;

                    return new ulong4(_zz, _zz);
                }
                else
                {
                    return new ulong4(z, z, z, z);
                }
            }
        }

        public ulong3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_broadcastq_epi64(Avx.mm256_castsi256_si128(this));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xx, x);
                }
                else
                {
                    return new ulong3(x, x, x);
                }
            }
        }
        public ulong3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 0, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xx, y);
                }
                else
                {
                    return new ulong3(x, x, y);
                }
            }
        }
        public ulong3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_shuffle_epi32(this, Sse.SHUFFLE(1, 0, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xx, z);
                }
                else
                {
                    return new ulong3(x, x, z);
                }
            }
        }
        public ulong3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_broadcastsi128_si256(Avx.mm256_castsi256_si128(this));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(_xy, x);
                }
                else
                {
                    return new ulong3(x, y, x);
                }
            }
        }
        public ulong3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 1, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(_xy, y);
                }
                else
                {
                    return new ulong3(x, y, y);
                }
            }
        }
        public ulong3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xz, x);
                }
                else
                {
                    return new ulong3(x, z, x);
                }
            }
        }
        public          ulong3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xz, y);
                }
                else
                {
                    return new ulong3(x, z, y);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = value.xzy;
            }
        }
        public ulong3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 2, 0));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(xz, z);
                }
                else
                {
                    return new ulong3(x, z, z);
                }
            }
        }
        public ulong3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yx, x);
                }
                else
                {
                    return new ulong3(y, x, x);
                }
            }
        }
        public ulong3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yx, y);
                }
                else
                {
                    return new ulong3(y, x, y);
                }
            }
        }
        public          ulong3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 0, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yx, z);
                }
                else
                {
                    return new ulong3(y, x, z);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = value.yxz;
            }
        }
        public ulong3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yy, x);
                }
                else
                {
                    return new ulong3(y, y, x);
                }
            }
        }
        public ulong3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yy, y);
                }
                else
                {
                    return new ulong3(y, y, y);
                }
            }
        }
        public ulong3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 1, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yy, z);
                }
                else
                {
                    return new ulong3(y, y, z);
                }
            }
        }
        public          ulong3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yz, x);
                }
                else
                {
                    return new ulong3(y, z, x);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = value.zxy;
            }
        }
        public ulong3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yz, y);
                }
                else
                {
                    return new ulong3(y, z, y);
                }
            }
        }
        public ulong3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 2, 1));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(yz, z);
                }
                else
                {
                    return new ulong3(y, z, z);
                }
            }
        }
        public ulong3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zx, x);
                }
                else
                {
                    return new ulong3(z, x, x);
                }
            }
        }
        public          ulong3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zx, y);
                }
                else
                {
                    return new ulong3(z, x, y);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = value.yzx;
            }
        }
        public ulong3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 0, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zx, z);
                }
                else
                {
                    return new ulong3(z, x, z);
                }
            }
        }
        public          ulong3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zy, x);
                }
                else
                {
                    return new ulong3(z, y, x);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                this = value.zyx;
            }
        }
        public ulong3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zy, y);
                }
                else
                {
                    return new ulong3(z, y, y);
                }
            }
        }
        public ulong3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 1, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zy, z);
                }
                else
                {
                    return new ulong3(z, y, z);
                }
            }
        }
        public ulong3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 0, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zz, x);
                }
                else
                {
                    return new ulong3(z, z, x);
                }
            }
        }
        public ulong3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 1, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zz, y);
                }
                else
                {
                    return new ulong3(z, z, y);
                }
            }
        }
        public ulong3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 2, 2, 2));
                }
                else if (Sse2.IsSse2Supported)
                {
                    return new ulong3(zz, z);
                }
                else
                {
                    return new ulong3(z, z, z);
                }
            }
        }

        public ulong2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.shuffle_epi32(Avx.mm256_castsi256_si128(this), Sse.SHUFFLE(1, 0, 1, 0));
                }
                else
                {
                    return _xy.xx;
                }
            }
        }
        public          ulong2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(this);
                }
                else
                {
                    return _xy;
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
                    this._xy = value;
                }
            }
        }
        public          ulong2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 3, 2, 0)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _xz = _xy;
                    _xz.y = z;
                    return _xz;
                }
                else
                {
                    return new ulong2(x, z);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_blend_epi32(this, value.xxyy, 0b0011_0011);
                }
                else
                {
                    this.x = value.x;
                    this.z = value.y;
                }
            }
        }
        public          ulong2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.shuffle_epi32(Avx.mm256_castsi256_si128(this), Sse.SHUFFLE(1, 0, 3, 2));
                }
                else
                {
                    return _xy.yx;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_inserti128_si256(this, value.yx, 0);
                }
                else
                {
                    this.y = value.x;
                    this.x = value.y;
                }
            }
        }
        public ulong2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Sse2.shuffle_epi32(Avx.mm256_castsi256_si128(this), Sse.SHUFFLE(3, 2, 3, 2));
                }
                else
                {
                    return _xy.yy;
                }
            }
        }
        public          ulong2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 3, 2, 1)));
                }
                else
                {
                    return new ulong2(y, z);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_blend_epi32(this, value.yxyx, 0b0011_1100);
                }
                else
                {
                    this.y = value.x;
                    this.z = value.y;
                } 
            }
        }
        public          ulong2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 3, 0, 2)));
                }
                else
                {
                    return new ulong2(z, x);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_blend_epi32(this, value.yyxx, 0b0011_0011);
                }
                else
                {
                    this.z = value.x;
                    this.x = value.y;
                }
            }
        }
        public          ulong2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 3, 1, 2)));
                }
                else if (Sse2.IsSse2Supported)
                {
                    ulong2 _zy = _xy;
                    _zy.x = z;
                    return _zy;
                }
                else
                {
                    return new ulong2(z, y);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                if (Avx2.IsAvx2Supported)
                {
                    this = Avx2.mm256_blend_epi32(this, value.yyxx, 0b0011_1100);
                }
                else
                {
                    this.z = value.x;
                    this.y = value.y;
                }
            }
        }
        public ulong2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                if (Avx2.IsAvx2Supported)
                {
                    return Avx.mm256_castsi256_si128(Avx2.mm256_permute4x64_epi64(this, Sse.SHUFFLE(3, 3, 2, 2)));
                }
                else
                {
                    return new ulong2(z, z);
                }
            }
        }
        #endregion


        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Avx2.mm256_stream_load_si256(void* ptr)   Avx.mm256_load_si256(void* ptr)
        public static implicit operator v256(ulong3 input) => new v256(input._xy, new v128(input.z, 0));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]  // Burst optimizes this;    (worse) alternatives:   Avx.mm256_storeu_si256(void* ptr, v128 x)
        public static implicit operator ulong3(v256 input) => new ulong3 { _xy = input.Lo128, z = input.ULong2 };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(ulong input) => new ulong3(input);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(long3 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                return (v256)input;
            }
            else if (Sse2.IsSse2Supported)
            {
                return new ulong3((ulong2)input._xy, (ulong)input.z);
            }
            else
            {
                return *(ulong3*)&input;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ulong3(uint3 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_cvtepu32_epi64(UnityMathematicsLink.Tov128(input));
            }
            else if (Sse2.IsSse2Supported)
            {
                return new ulong3
                {
                    _xy = (ulong2)input.xy,
                    z = (ulong)input.z
                };
            }
            else
            {
                return new ulong3((ulong)input.x, (ulong)input.y, (ulong)input.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(int3 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_cvtepi32_epi64(UnityMathematicsLink.Tov128(input));
            }
            else if (Sse2.IsSse2Supported)
            {
                return new ulong3
                {
                    _xy = (ulong2)input.xy,
                    z = (ulong)input.z
                };
            }
            else
            {
                return new ulong3((ulong)input.x, (ulong)input.y, (ulong)input.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(half3 input) => (ulong3)(int3)(float3)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(float3 input) => new ulong3((ulong2)input.xy, (ulong)input.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong3(double3 input) => new ulong3((ulong2)input.xy, (ulong)input.z);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(ulong3 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Cast.Long4ToInt4(input);

                return *(uint3*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 temp = Cast.Long2ToInt2(input._xy);

                temp = Sse4_1.insert_epi32(temp, (int)(uint)input.z, 2);

                return *(uint3*)&temp;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 temp = Cast.Long2ToInt2(input._xy);

                temp = Sse2.unpacklo_epi64(temp, Sse2.cvtsi32_si128((int)input.z));

                return *(uint3*)&temp;
            }
            else
            {
                return new uint3((uint2)input.xy, (uint)input.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(ulong3 input)
        {
            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Cast.Long4ToInt4(input);

                return *(int3*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 temp = Cast.Long2ToInt2(input._xy);

                temp = Sse4_1.insert_epi32(temp, (int)input.z, 2);

                return *(int3*)&temp;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 temp = Cast.Long2ToInt2(input._xy);

                temp = Sse2.unpacklo_epi64(temp, Sse2.cvtsi32_si128((int)input.z));

                return *(int3*)&temp;
            }
            else
            {
                return new int3((int2)input.xy, (int)input.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator half3(ulong3 input) => (half3)(float3)(uint3)input;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(ulong3 input) => new float3((float2)input._xy, (float)input.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3(ulong3 input) => new double3((double2)input._xy, (double)input.z);


        public ulong this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
Assert.IsWithinArrayBounds(index, 3);

                return asArray[index];
            }
    
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
Assert.IsWithinArrayBounds(index, 3);

                asArray[index] = value;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator + (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_add_epi64(left, right);
            }
            else
            {
                return new ulong3(left._xy + right._xy, left.z + right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator - (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sub_epi64(left, right);
            }
            else
            {
                return new ulong3(left._xy - right._xy, left.z - right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.mul_long(left, right);
            }
            else if (Sse2.IsSse2Supported)
            {
                return new ulong3(Operator.mul_long(left._xy, right._xy), left.z * right.z);
            }
            else
            {
                return new ulong3(left.x * right.x, left.y * right.y, left.z * right.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator / (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return new ulong3(left.x / right.x, left.y / right.y, left.z / right.z);
            }
            else
            {
                return new ulong3(left._xy / right._xy, left.z / right.z);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator % (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return new ulong3(left.x % right.x, left.y % right.y, left.z % right.z);
            }
            else
            {
                return new ulong3(left._xy % right._xy, left.z % right.z);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong left, ulong3 right) => right * left;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator * (ulong3 left, ulong right)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (Constant.IsConstantExpression(right))
                {
                    return (v256)((ulong4)((v256)left) * right);
                }
                else
                {
                    return new ulong3(left.x * right, left.y * right, left.z * right);
                }
            }
            else
            {
                return new ulong3(left._xy * right, left.z * right);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator / (ulong3 left, ulong right)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (Constant.IsConstantExpression(right))
                {
                    return (v256)((ulong4)((v256)left) / right);
                }
                else
                {
                    return new ulong3(left.x / right, left.y / right, left.z / right);
                }
            }
            else
            {
                return new ulong3(left._xy / right, left.z / right);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator % (ulong3 left, ulong right)
        {
            if (Avx2.IsAvx2Supported)
            {
                if (Constant.IsConstantExpression(right))
                {
                    return (v256)((ulong4)((v256)left) % right);
                }
                else
                {
                    return new ulong3(left.x % right, left.y % right, left.z % right);
                }
            }
            else
            {
                return new ulong3(left._xy % right, left.z % right);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator & (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_and_si256(left, right);
            }
            else
            {
                return new ulong3(left._xy & right._xy, left.z & right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator | (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_or_si256(left, right);
            }
            else
            {
                return new ulong3(left._xy | right._xy, left.z | right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ^ (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_xor_si256(left, right);
            }
            else
            {
                return new ulong3(left._xy ^ right._xy, left.z ^ right.z);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ++ (ulong3 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sub_epi64(x, Avx2.mm256_cmpeq_epi32(default(v256), default(v256)));
            }
            else
            {
                return new ulong3(x._xy + 1, x.z + 1);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator -- (ulong3 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_add_epi64(x, Avx2.mm256_cmpeq_epi32(default(v256), default(v256)));
            }
            else
            {
                return new ulong3(x._xy - 1, x.z - 1);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator ~ (ulong3 x)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_xor_si256(x, Avx2.mm256_cmpeq_epi32(default(v256), default(v256)));
            }
            else
            {
                return new ulong3(~x._xy, ~x.z);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator << (ulong3 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.shl_long(x, n);
            }
            else
            {
                return new ulong3(x._xy << n, x.z << n);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 operator >> (ulong3 x, int n)
        {
            if (Avx2.IsAvx2Supported)
            {
                return Operator.shrl_long(x, n);
            }
            else
            {
                return new ulong3(x._xy >> n, x.z >> n);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsTrue64(Avx2.mm256_cmpeq_epi64(left, right));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy == right._xy, left.z == right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsTrue64(Operator.greater_mask_ulong(right, left));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy < right._xy, left.z < right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsTrue64(Operator.greater_mask_ulong(left, right));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy > right._xy, left.z > right.z);
            }
        }
    
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsFalse64(Avx2.mm256_cmpeq_epi64(left, right));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy != right._xy, left.z != right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsFalse64(Operator.greater_mask_ulong(left, right));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy <= right._xy, left.z <= right.z);
            }
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (ulong3 left, ulong3 right)
        {
            if (Avx2.IsAvx2Supported)
            {
                int cvt = ConvertToBool.IsFalse64(Operator.greater_mask_ulong(right, left));

                return *(bool3*)&cvt;
            }
            else
            {
                return new bool3(left._xy >= right._xy, left.z >= right.z);
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ulong3 other)
        {
            if (Avx2.IsAvx2Supported)
            {
                return maxmath.bitmask32(24) == (maxmath.bitmask32(24) & Avx2.mm256_movemask_epi8(Avx2.mm256_cmpeq_epi64(this, other)));
            }
            else
            {
                return this._xy.Equals(other._xy) & this.z == other.z;
            }
        }

        public override bool Equals(object obj) => Equals((ulong3)obj);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            if (Avx2.IsAvx2Supported)
            {
                return Hash.v192(this);
            }
            else if (Sse2.IsSse2Supported)
            {
                return Hash.v128(_xy ^ new ulong2(z));
            }
            else
            {
                return ((x ^ z) ^ (y ^ z)).GetHashCode();
            }
        }


        public override string ToString() => $"ulong3({x}, {y}, {z})";
        public string ToString(string format, IFormatProvider formatProvider) => $"ulong3({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)}, {z.ToString(format, formatProvider)})";
    }
}