﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        ///<summary>        Returns a bool8 indicating for each component of a float8 whether it is a finite floating point value.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 isfinite(float8 x) 
        { 
            return abs(x) < float.PositiveInfinity; 
        }
        
        ///<summary>        Returns a bool8 indicating for each component of a float8 whether it is an infinite floating point value.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 isinf(float8 x) 
        { 
            return abs(x) == float.PositiveInfinity; 
        }
        
        ///<summary>        Returns a bool8 indicating for each component of a float8 whether it is a NaN (not a number) floating point value.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool8 isnan(float8 x) 
        { 
            return (asint(x) & bitmask32(31)) > 0x7F80_0000; 
        }

        /// <summary>       Returns the componentwise reciprocal a float8 vector.       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 rcp(float8 x)
        {
            if (Avx.IsAvxSupported)
            {
                return Avx.mm256_rcp_ps(x);
            }
            else
            {
                return new float8(math.rcp(x.v4_0), math.rcp(x.v4_4));
            }
        }

        /// <summary>       Returns the componentwise fractional parts of a float8 vector.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 frac(float8 x)
        {
            return x - floor(x);
        }

        /// <summary>       Performs a componentwise split of a float8 vector into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 modf(float8 x, out float8 i)
        {
            return x - (i = trunc(x));
        }


        /// <summary>       Returns the result of a componentwise conversion of a float8 vector from degrees to radians.        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 radians(float8 x) 
        { 
            return x * 0.0174532925f; 
        }
        
        /// <summary>       Returns the result of a componentwise conversion of a float8 vector from radians to degrees.        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 degrees(float8 x) 
        { 
            return x * 57.295779513f; 
        }


        /// <summary>       Returns the componentwise square root of a float8 vector.       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 sqrt(float8 x)
        {
            if (Avx.IsAvxSupported)
            {
                return Avx.mm256_sqrt_ps(x);
            }
            else
            {
                return new float8(math.sqrt(x.v4_0), math.sqrt(x.v4_4));
            }
        }

        /// <summary>       Returns the componentwise reciprocal square root of a float8 vector     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 rsqrt(float8 x)
        {
            if (Avx.IsAvxSupported)
            {
                return Avx.mm256_rsqrt_ps(x);
            }
            else
            {
                return new float8(math.rsqrt(x.v4_0), math.rsqrt(x.v4_4));
            }
        }

        /// <summary>       Returns the result of a componentwise linear interpolation from x to y using the corresponding components of the interpolation parameter s.     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 lerp(float8 x, float8 y, float8 s) 
        { 
            return mad(s, y - x, x);
        }

        /// <summary>       Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 unlerp(float8 a, float8 b, float8 x) 
        {
            return (x - a) / (b - a); 
        }

        ///<summary>        Returns the componentwise result of a non-clamping linear remapping of a value x from [a, b] to [c, d].     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 remap(float8 a, float8 b, float8 c, float8 d, float8 x) 
        {
            return lerp(c, d, unlerp(a, b, x)); 
        }

        /// <summary>       Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 smoothstep(float8 a, float8 b, float8 x)
        {
            float8 temp = saturate(unlerp(a, b, x));

            return (temp * temp) * mad(-2f, temp, 3f);
        }

        /// <summary>       Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 step(float8 y, float8 x)
        {
            if (Avx.IsAvxSupported)
            {
                return Avx.mm256_blendv_ps(default(float8), new float8(1f), Avx.mm256_cmp_ps(x, y, (int)Avx.CMP.GE_OS));
            }
            else
            {
                return new float8(math.step(x.v4_0, y.v4_0), math.step(x.v4_4, y.v4_4));
            }
        }


        /// <summary>       Returns the squared length of a float8 vector.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float lengthsq(float8 x) 
        { 
            return dot(x, x); 
        }

        /// <summary>       Returns the squared length of a float8 vector.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(float8 x)
        {
            return math.sqrt(lengthsq(x));
        }

        /// <summary>       Returns a normalized version of the float8 vector x by scaling it by 1 / length(x).     </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 normalize(float8 x) 
        {
            return x * rsqrt(dot(x, x)); 
        }

        /// <summary>       Returns a safe normalized version of the float3 vector x by scaling it by 1 / length(x). Returns the given default value when 1 / length(x) does not produce a finite number.       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public float8 normalizesafe(float8 x, float8 defaultvalue = default(float8))
        {
            float len = dot(x, x);

            return select(defaultvalue, x * math.rsqrt(len), len > math.FLT_MIN_NORMAL);
        }

        /// <summary>       Returns the distance between two float8 vectors.        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float distance(float8 x, float8 y) 
        { 
            return length(y - x);
        }

        /// <summary        >Returns the distance between two float8 vectors.       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float distancesq(float8 x, float8 y) 
        { 
            return lengthsq(y - x); 
        }
    }
}