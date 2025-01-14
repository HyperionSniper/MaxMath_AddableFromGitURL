﻿using NUnit.Framework;

namespace MaxMath.Tests
{
    /// __float/__double implicitly tested by testing Int/__long
    unsafe public static class cprod
    {
        [Test]
        public static void Byte2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte2.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte2.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte2.TestData_LHS[i].x *
                                (uint)Tests.__byte2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Byte3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte3.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte3.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte3.TestData_LHS[i].x *
                                (uint)Tests.__byte3.TestData_LHS[i].y *
                                (uint)Tests.__byte3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Byte4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte4.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte4.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte4.TestData_LHS[i].x *
                                (uint)Tests.__byte4.TestData_LHS[i].y *
                                (uint)Tests.__byte4.TestData_LHS[i].z *
                                (uint)Tests.__byte4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Byte8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte8.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte8.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte8.TestData_LHS[i].x0 *
                                (uint)Tests.__byte8.TestData_LHS[i].x1 *
                                (uint)Tests.__byte8.TestData_LHS[i].x2 *
                                (uint)Tests.__byte8.TestData_LHS[i].x3 *
                                (uint)Tests.__byte8.TestData_LHS[i].x4 *
                                (uint)Tests.__byte8.TestData_LHS[i].x5 *
                                (uint)Tests.__byte8.TestData_LHS[i].x6 *
                                (uint)Tests.__byte8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Byte16()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte16.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte16.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte16.TestData_LHS[i].x0 *
                                (uint)Tests.__byte16.TestData_LHS[i].x1 *
                                (uint)Tests.__byte16.TestData_LHS[i].x2 *
                                (uint)Tests.__byte16.TestData_LHS[i].x3 *
                                (uint)Tests.__byte16.TestData_LHS[i].x4 *
                                (uint)Tests.__byte16.TestData_LHS[i].x5 *
                                (uint)Tests.__byte16.TestData_LHS[i].x6 *
                                (uint)Tests.__byte16.TestData_LHS[i].x7 *
                                (uint)Tests.__byte16.TestData_LHS[i].x8 *
                                (uint)Tests.__byte16.TestData_LHS[i].x9 *
                                (uint)Tests.__byte16.TestData_LHS[i].x10 *
                                (uint)Tests.__byte16.TestData_LHS[i].x11 *
                                (uint)Tests.__byte16.TestData_LHS[i].x12 *
                                (uint)Tests.__byte16.TestData_LHS[i].x13 *
                                (uint)Tests.__byte16.TestData_LHS[i].x14 *
                                (uint)Tests.__byte16.TestData_LHS[i].x15);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Byte32()
        {
            bool result = true;

            for (int i = 0; i < Tests.__byte32.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__byte32.TestData_LHS[i]);

                result &= x == ((uint)Tests.__byte32.TestData_LHS[i].x0 *
                                (uint)Tests.__byte32.TestData_LHS[i].x1 *
                                (uint)Tests.__byte32.TestData_LHS[i].x2 *
                                (uint)Tests.__byte32.TestData_LHS[i].x3 *
                                (uint)Tests.__byte32.TestData_LHS[i].x4 *
                                (uint)Tests.__byte32.TestData_LHS[i].x5 *
                                (uint)Tests.__byte32.TestData_LHS[i].x6 *
                                (uint)Tests.__byte32.TestData_LHS[i].x7 *
                                (uint)Tests.__byte32.TestData_LHS[i].x8 *
                                (uint)Tests.__byte32.TestData_LHS[i].x9 *
                                (uint)Tests.__byte32.TestData_LHS[i].x10 *
                                (uint)Tests.__byte32.TestData_LHS[i].x11 *
                                (uint)Tests.__byte32.TestData_LHS[i].x12 *
                                (uint)Tests.__byte32.TestData_LHS[i].x13 *
                                (uint)Tests.__byte32.TestData_LHS[i].x14 *
                                (uint)Tests.__byte32.TestData_LHS[i].x15 *
                                (uint)Tests.__byte32.TestData_LHS[i].x16 *
                                (uint)Tests.__byte32.TestData_LHS[i].x17 *
                                (uint)Tests.__byte32.TestData_LHS[i].x18 *
                                (uint)Tests.__byte32.TestData_LHS[i].x19 *
                                (uint)Tests.__byte32.TestData_LHS[i].x20 *
                                (uint)Tests.__byte32.TestData_LHS[i].x21 *
                                (uint)Tests.__byte32.TestData_LHS[i].x22 *
                                (uint)Tests.__byte32.TestData_LHS[i].x23 *
                                (uint)Tests.__byte32.TestData_LHS[i].x24 *
                                (uint)Tests.__byte32.TestData_LHS[i].x25 *
                                (uint)Tests.__byte32.TestData_LHS[i].x26 *
                                (uint)Tests.__byte32.TestData_LHS[i].x27 *
                                (uint)Tests.__byte32.TestData_LHS[i].x28 *
                                (uint)Tests.__byte32.TestData_LHS[i].x29 *
                                (uint)Tests.__byte32.TestData_LHS[i].x30 *
                                (uint)Tests.__byte32.TestData_LHS[i].x31);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void SByte2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte2.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte2.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte2.TestData_LHS[i].x *
                                (int)Tests.__sbyte2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void SByte3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte3.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte3.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte3.TestData_LHS[i].x *
                                (int)Tests.__sbyte3.TestData_LHS[i].y *
                                (int)Tests.__sbyte3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void SByte4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte4.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte4.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte4.TestData_LHS[i].x *
                                (int)Tests.__sbyte4.TestData_LHS[i].y *
                                (int)Tests.__sbyte4.TestData_LHS[i].z *
                                (int)Tests.__sbyte4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void SByte8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte8.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte8.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte8.TestData_LHS[i].x0 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x1 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x2 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x3 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x4 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x5 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x6 *
                                (int)Tests.__sbyte8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void SByte16()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte16.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte16.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte16.TestData_LHS[i].x0 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x1 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x2 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x3 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x4 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x5 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x6 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x7 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x8 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x9 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x10 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x11 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x12 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x13 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x14 *
                                (int)Tests.__sbyte16.TestData_LHS[i].x15);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void SByte32()
        {
            bool result = true;

            for (int i = 0; i < Tests.__sbyte32.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__sbyte32.TestData_LHS[i]);

                result &= x == ((int)Tests.__sbyte32.TestData_LHS[i].x0 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x1 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x2 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x3 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x4 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x5 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x6 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x7 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x8 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x9 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x10 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x11 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x12 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x13 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x14 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x15 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x16 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x17 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x18 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x19 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x20 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x21 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x22 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x23 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x24 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x25 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x26 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x27 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x28 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x29 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x30 *
                                (int)Tests.__sbyte32.TestData_LHS[i].x31);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void UShort2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ushort2.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__ushort2.TestData_LHS[i]);

                result &= x == ((uint)Tests.__ushort2.TestData_LHS[i].x *
                                (uint)Tests.__ushort2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UShort3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ushort3.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__ushort3.TestData_LHS[i]);

                result &= x == ((uint)Tests.__ushort3.TestData_LHS[i].x *
                                (uint)Tests.__ushort3.TestData_LHS[i].y *
                                (uint)Tests.__ushort3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UShort4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ushort4.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__ushort4.TestData_LHS[i]);

                result &= x == ((uint)Tests.__ushort4.TestData_LHS[i].x *
                                (uint)Tests.__ushort4.TestData_LHS[i].y *
                                (uint)Tests.__ushort4.TestData_LHS[i].z *
                                (uint)Tests.__ushort4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UShort8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ushort8.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__ushort8.TestData_LHS[i]);

                result &= x == ((uint)Tests.__ushort8.TestData_LHS[i].x0 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x1 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x2 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x3 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x4 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x5 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x6 *
                                (uint)Tests.__ushort8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UShort16()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ushort16.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__ushort16.TestData_LHS[i]);

                result &= x == ((uint)Tests.__ushort16.TestData_LHS[i].x0 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x1 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x2 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x3 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x4 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x5 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x6 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x7 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x8 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x9 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x10 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x11 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x12 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x13 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x14 *
                                (uint)Tests.__ushort16.TestData_LHS[i].x15);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Short2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__short2.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__short2.TestData_LHS[i]);

                result &= x == ((int)Tests.__short2.TestData_LHS[i].x *
                                (int)Tests.__short2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Short3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__short3.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__short3.TestData_LHS[i]);

                result &= x == ((int)Tests.__short3.TestData_LHS[i].x *
                                (int)Tests.__short3.TestData_LHS[i].y *
                                (int)Tests.__short3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Short4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__short4.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__short4.TestData_LHS[i]);

                result &= x == ((int)Tests.__short4.TestData_LHS[i].x *
                                (int)Tests.__short4.TestData_LHS[i].y *
                                (int)Tests.__short4.TestData_LHS[i].z *
                                (int)Tests.__short4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Short8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__short8.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__short8.TestData_LHS[i]);

                result &= x == ((int)Tests.__short8.TestData_LHS[i].x0 *
                                (int)Tests.__short8.TestData_LHS[i].x1 *
                                (int)Tests.__short8.TestData_LHS[i].x2 *
                                (int)Tests.__short8.TestData_LHS[i].x3 *
                                (int)Tests.__short8.TestData_LHS[i].x4 *
                                (int)Tests.__short8.TestData_LHS[i].x5 *
                                (int)Tests.__short8.TestData_LHS[i].x6 *
                                (int)Tests.__short8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Short16()
        {
            bool result = true;

            for (int i = 0; i < Tests.__short16.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__short16.TestData_LHS[i]);

                result &= x == ((int)Tests.__short16.TestData_LHS[i].x0 *
                                (int)Tests.__short16.TestData_LHS[i].x1 *
                                (int)Tests.__short16.TestData_LHS[i].x2 *
                                (int)Tests.__short16.TestData_LHS[i].x3 *
                                (int)Tests.__short16.TestData_LHS[i].x4 *
                                (int)Tests.__short16.TestData_LHS[i].x5 *
                                (int)Tests.__short16.TestData_LHS[i].x6 *
                                (int)Tests.__short16.TestData_LHS[i].x7 *
                                (int)Tests.__short16.TestData_LHS[i].x8 *
                                (int)Tests.__short16.TestData_LHS[i].x9 *
                                (int)Tests.__short16.TestData_LHS[i].x10 *
                                (int)Tests.__short16.TestData_LHS[i].x11 *
                                (int)Tests.__short16.TestData_LHS[i].x12 *
                                (int)Tests.__short16.TestData_LHS[i].x13 *
                                (int)Tests.__short16.TestData_LHS[i].x14 *
                                (int)Tests.__short16.TestData_LHS[i].x15);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Int2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__int2.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__int2.TestData_LHS[i]);

                result &= x == (Tests.__int2.TestData_LHS[i].x *
                                Tests.__int2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Int3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__int3.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__int3.TestData_LHS[i]);

                result &= x == (Tests.__int3.TestData_LHS[i].x *
                                Tests.__int3.TestData_LHS[i].y *
                                Tests.__int3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Int4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__int4.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__int4.TestData_LHS[i]);

                result &= x == (Tests.__int4.TestData_LHS[i].x *
                                Tests.__int4.TestData_LHS[i].y *
                                Tests.__int4.TestData_LHS[i].z *
                                Tests.__int4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Int8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__int8.NUM_TESTS; i++)
            {
                int x = maxmath.cprod(Tests.__int8.TestData_LHS[i]);

                result &= x == (Tests.__int8.TestData_LHS[i].x0 *
                                Tests.__int8.TestData_LHS[i].x1 *
                                Tests.__int8.TestData_LHS[i].x2 *
                                Tests.__int8.TestData_LHS[i].x3 *
                                Tests.__int8.TestData_LHS[i].x4 *
                                Tests.__int8.TestData_LHS[i].x5 *
                                Tests.__int8.TestData_LHS[i].x6 *
                                Tests.__int8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void UInt2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__uint2.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__uint2.TestData_LHS[i]);

                result &= x == (Tests.__uint2.TestData_LHS[i].x *
                                Tests.__uint2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UInt3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__uint3.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__uint3.TestData_LHS[i]);

                result &= x == (Tests.__uint3.TestData_LHS[i].x *
                                Tests.__uint3.TestData_LHS[i].y *
                                Tests.__uint3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UInt4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__uint4.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__uint4.TestData_LHS[i]);

                result &= x == (Tests.__uint4.TestData_LHS[i].x *
                                Tests.__uint4.TestData_LHS[i].y *
                                Tests.__uint4.TestData_LHS[i].z *
                                Tests.__uint4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void UInt8()
        {
            bool result = true;

            for (int i = 0; i < Tests.__uint8.NUM_TESTS; i++)
            {
                uint x = maxmath.cprod(Tests.__uint8.TestData_LHS[i]);

                result &= x == (Tests.__uint8.TestData_LHS[i].x0 *
                                Tests.__uint8.TestData_LHS[i].x1 *
                                Tests.__uint8.TestData_LHS[i].x2 *
                                Tests.__uint8.TestData_LHS[i].x3 *
                                Tests.__uint8.TestData_LHS[i].x4 *
                                Tests.__uint8.TestData_LHS[i].x5 *
                                Tests.__uint8.TestData_LHS[i].x6 *
                                Tests.__uint8.TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Long2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__long2.NUM_TESTS; i++)
            {
                long x = maxmath.cprod(Tests.__long2.TestData_LHS[i]);

                result &= x == (Tests.__long2.TestData_LHS[i].x *
                                Tests.__long2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Long3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__long3.NUM_TESTS; i++)
            {
                long x = maxmath.cprod(Tests.__long3.TestData_LHS[i]);

                result &= x == (Tests.__long3.TestData_LHS[i].x *
                                Tests.__long3.TestData_LHS[i].y *
                                Tests.__long3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Long4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__long4.NUM_TESTS; i++)
            {
                long x = maxmath.cprod(Tests.__long4.TestData_LHS[i]);

                result &= x == (Tests.__long4.TestData_LHS[i].x *
                                Tests.__long4.TestData_LHS[i].y *
                                Tests.__long4.TestData_LHS[i].z *
                                Tests.__long4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void ULong2()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ulong2.NUM_TESTS; i++)
            {
                ulong x = maxmath.cprod(Tests.__ulong2.TestData_LHS[i]);

                result &= x == (Tests.__ulong2.TestData_LHS[i].x *
                                Tests.__ulong2.TestData_LHS[i].y);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void ULong3()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ulong3.NUM_TESTS; i++)
            {
                ulong x = maxmath.cprod(Tests.__ulong3.TestData_LHS[i]);

                result &= x == (Tests.__ulong3.TestData_LHS[i].x *
                                Tests.__ulong3.TestData_LHS[i].y *
                                Tests.__ulong3.TestData_LHS[i].z);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void ULong4()
        {
            bool result = true;

            for (int i = 0; i < Tests.__ulong4.NUM_TESTS; i++)
            {
                ulong x = maxmath.cprod(Tests.__ulong4.TestData_LHS[i]);

                result &= x == (Tests.__ulong4.TestData_LHS[i].x *
                                Tests.__ulong4.TestData_LHS[i].y *
                                Tests.__ulong4.TestData_LHS[i].z *
                                Tests.__ulong4.TestData_LHS[i].w);
            }

            Assert.AreEqual(true, result);
        }
    }
}