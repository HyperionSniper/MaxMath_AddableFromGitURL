﻿using NUnit.Framework;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

namespace MaxMath.Tests
{
    unsafe public static class __ushort8
    {
        internal const int NUM_TESTS = 4;


        internal static ushort8[] TestData_LHS => new ushort8[]
        {
            new ushort8{x0 = 18300,
					    x1 = 55,
					    x2 = 9639,
					    x3 = 763,
					    x4 = 65097,
					    x5 = 11,
					    x6 = 2131,
                        x7 = 3825},
					   
            new ushort8{x0 = 212,
					    x1 = 18892,
					    x2 = 16,
					    x3 = 2311,
					    x4 = 99,
					    x5 = 5680,
					    x6 = 549,
					    x7 = 39432},
					          
            new ushort8{x0 = 87,
					    x1 = ushort.MaxValue,
					    x2 = 17,
					    x3 = 1747,
					    x4 = 0,
					    x5 = 4127,
					    x6 = 392,
					    x7 = 21156},
					   
            new ushort8{x0 = ushort.MinValue,
					    x1 = 1563,
					    x2 = 11221,
					    x3 = 61446,
					    x4 = 1979,
					    x5 = 399,
					    x6 = 2502,
					    x7 = 121}
        };

        internal static ushort8[] TestData_RHS => new ushort8[]
        {
            new ushort8{x0 = 12,
					    x1 = 8,
					    x2 = 5383,
					    x3 = 98,
					    x4 = 4242,
					    x5 = 17996,
					    x6 = 970,
					    x7 = 44},

            TestData_LHS[1],

            new ushort8{x0 = 17955,
					    x1 = 827,
					    x2 = 9643,
					    x3 = 18862,
					    x4 = 239,
					    x5 = 435,
					    x6 = 9750,
                        x7 = 162},
					   
            new ushort8{x0 = 2,
					    x1 = 963,
					    x2 = 20540,
					    x3 = 19242,
					    x4 = 8967,
					    x5 = 26789,
					    x6 = 1862,
					    x7 = 43}
        };


        [Test]
        public static void Constructor___ushort___ushort___ushort___ushort___ushort___ushort___ushort_UShort()
        {
            ushort8 x = new ushort8(TestData_LHS[0].x0, TestData_LHS[0].x1, TestData_LHS[0].x2, TestData_LHS[0].x3, TestData_LHS[0].x4, TestData_LHS[0].x5, TestData_LHS[0].x6, TestData_LHS[0].x7);

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor_UShort()
        {
            ushort8 x = new ushort8(TestData_LHS[0].x0);

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x0 &
                   x.x2 == TestData_LHS[0].x0 &
                   x.x3 == TestData_LHS[0].x0 &
                   x.x4 == TestData_LHS[0].x0 &
                   x.x5 == TestData_LHS[0].x0 &
                   x.x6 == TestData_LHS[0].x0 &
                   x.x7 == TestData_LHS[0].x0, true);
        }

        [Test]
        public static void Constructor___ushort2___ushort2___ushort2_UShort2()
        {
            ushort8 x = new ushort8(new ushort2(TestData_LHS[0].x0, TestData_LHS[0].x1), new ushort2(TestData_LHS[0].x2, TestData_LHS[0].x3), new ushort2(TestData_LHS[0].x4, TestData_LHS[0].x5), new ushort2(TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort2___ushort3_UShort3()
        {
            ushort8 x = new ushort8(new ushort2(TestData_LHS[0].x0, TestData_LHS[0].x1), new ushort3(TestData_LHS[0].x2, TestData_LHS[0].x3, TestData_LHS[0].x4), new ushort3(TestData_LHS[0].x5, TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort3___ushort2_UShort3()
        {
            ushort8 x = new ushort8(new ushort3(TestData_LHS[0].x0, TestData_LHS[0].x1, TestData_LHS[0].x2), new ushort2(TestData_LHS[0].x3, TestData_LHS[0].x4), new ushort3(TestData_LHS[0].x5, TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort3___ushort3_UShort2()
        {
            ushort8 x = new ushort8(new ushort3(TestData_LHS[0].x0, TestData_LHS[0].x1, TestData_LHS[0].x2), new ushort3(TestData_LHS[0].x3, TestData_LHS[0].x4, TestData_LHS[0].x5), new ushort2(TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort4___ushort2_UShort2()
        {
            ushort8 x = new ushort8(new ushort4(TestData_LHS[0].x0, TestData_LHS[0].x1, TestData_LHS[0].x2, TestData_LHS[0].x3), new ushort2(TestData_LHS[0].x4, TestData_LHS[0].x5), new ushort2(TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort2___ushort4_UShort2()
        {
            ushort8 x = new ushort8(new ushort2(TestData_LHS[0].x0, TestData_LHS[0].x1), new ushort4(TestData_LHS[0].x2, TestData_LHS[0].x3, TestData_LHS[0].x4, TestData_LHS[0].x5), new ushort2(TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort2___ushort2_UShort4()
        {
            ushort8 x = new ushort8(new ushort2(TestData_LHS[0].x0, TestData_LHS[0].x1), new ushort2(TestData_LHS[0].x2, TestData_LHS[0].x3), new ushort4(TestData_LHS[0].x4, TestData_LHS[0].x5, TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }

        [Test]
        public static void Constructor___ushort4_UShort4()
        {
            ushort8 x = new ushort8(new ushort4(TestData_LHS[0].x0, TestData_LHS[0].x1, TestData_LHS[0].x2, TestData_LHS[0].x3), new ushort4(TestData_LHS[0].x4, TestData_LHS[0].x5, TestData_LHS[0].x6, TestData_LHS[0].x7));

            Assert.AreEqual(x.x0 == TestData_LHS[0].x0 &
                   x.x1 == TestData_LHS[0].x1 &
                   x.x2 == TestData_LHS[0].x2 &
                   x.x3 == TestData_LHS[0].x3 &
                   x.x4 == TestData_LHS[0].x4 &
                   x.x5 == TestData_LHS[0].x5 &
                   x.x6 == TestData_LHS[0].x6 &
                   x.x7 == TestData_LHS[0].x7, true);
        }


        [Test]
        public static void Indexer()
        {
            Assert.AreEqual(TestData_LHS[0][0] == TestData_LHS[0].x0 &
                   TestData_LHS[0][1] == TestData_LHS[0].x1 &
                   TestData_LHS[0][2] == TestData_LHS[0].x2 &
                   TestData_LHS[0][3] == TestData_LHS[0].x3 &
                   TestData_LHS[0][4] == TestData_LHS[0].x4 &
                   TestData_LHS[0][5] == TestData_LHS[0].x5 &
                   TestData_LHS[0][6] == TestData_LHS[0].x6 &
                   TestData_LHS[0][7] == TestData_LHS[0].x7, true);
        }


        [Test]
        public static void Add()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] + TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 + TestData_RHS[i].x0) & 
                          x.x1 == (ushort)(TestData_LHS[i].x1 + TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 + TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 + TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 + TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 + TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 + TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 + TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Subtract()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] - TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 - TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 - TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 - TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 - TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 - TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 - TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 - TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 - TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Multiply()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] * TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 * TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 * TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 * TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 * TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 * TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 * TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 * TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 * TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Divide()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] / TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 / TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 / TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 / TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 / TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 / TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 / TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 / TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 / TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Remainder()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] % TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 % TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 % TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 % TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 % TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 % TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 % TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 % TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 % TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void AND()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] & TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 & TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 & TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 & TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 & TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 & TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 & TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 & TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 & TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void OR()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] | TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 | TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 | TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 | TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 | TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 | TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 | TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 | TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 | TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void XOR()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i] ^ TestData_RHS[i];

                result &= x.x0 == (ushort)(TestData_LHS[i].x0 ^ TestData_RHS[i].x0) &
                          x.x1 == (ushort)(TestData_LHS[i].x1 ^ TestData_RHS[i].x1) &
                          x.x2 == (ushort)(TestData_LHS[i].x2 ^ TestData_RHS[i].x2) &
                          x.x3 == (ushort)(TestData_LHS[i].x3 ^ TestData_RHS[i].x3) &
                          x.x4 == (ushort)(TestData_LHS[i].x4 ^ TestData_RHS[i].x4) &
                          x.x5 == (ushort)(TestData_LHS[i].x5 ^ TestData_RHS[i].x5) &
                          x.x6 == (ushort)(TestData_LHS[i].x6 ^ TestData_RHS[i].x6) &
                          x.x7 == (ushort)(TestData_LHS[i].x7 ^ TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void NOT()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = ~TestData_LHS[i];

                result &= x.x0 == (ushort)(~TestData_LHS[i].x0) &
                          x.x1 == (ushort)(~TestData_LHS[i].x1) &
                          x.x2 == (ushort)(~TestData_LHS[i].x2) &
                          x.x3 == (ushort)(~TestData_LHS[i].x3) &
                          x.x4 == (ushort)(~TestData_LHS[i].x4) &
                          x.x5 == (ushort)(~TestData_LHS[i].x5) &
                          x.x6 == (ushort)(~TestData_LHS[i].x6) &
                          x.x7 == (ushort)(~TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void ShiftLeft()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    ushort8 x = TestData_LHS[i] << j;

                    result &= x.x0 == (ushort)(TestData_LHS[i].x0 << j) & 
                              x.x1 == (ushort)(TestData_LHS[i].x1 << j) &
                              x.x2 == (ushort)(TestData_LHS[i].x2 << j) &
                              x.x3 == (ushort)(TestData_LHS[i].x3 << j) &
                              x.x4 == (ushort)(TestData_LHS[i].x4 << j) &
                              x.x5 == (ushort)(TestData_LHS[i].x5 << j) &
                              x.x6 == (ushort)(TestData_LHS[i].x6 << j) &
                              x.x7 == (ushort)(TestData_LHS[i].x7 << j);
                }
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void ShiftRight()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    ushort8 x = TestData_LHS[i] >> j;

                    result &= x.x0 == (ushort)(TestData_LHS[i].x0 >> j) &
                              x.x1 == (ushort)(TestData_LHS[i].x1 >> j) &
                              x.x2 == (ushort)(TestData_LHS[i].x2 >> j) &
                              x.x3 == (ushort)(TestData_LHS[i].x3 >> j) &
                              x.x4 == (ushort)(TestData_LHS[i].x4 >> j) &
                              x.x5 == (ushort)(TestData_LHS[i].x5 >> j) &
                              x.x6 == (ushort)(TestData_LHS[i].x6 >> j) &
                              x.x7 == (ushort)(TestData_LHS[i].x7 >> j);
                }
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Equal()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] == TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 == TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 == TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 == TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 == TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 == TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 == TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 == TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 == TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void LessThan()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] < TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 < TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 < TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 < TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 < TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 < TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 < TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 < TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 < TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void GreaterThan()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] > TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 > TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 > TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 > TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 > TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 > TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 > TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 > TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 > TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void NotEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] != TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 != TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 != TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 != TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 != TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 != TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 != TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 != TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 != TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void LessThanOrEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] <= TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 <= TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 <= TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 <= TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 <= TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 <= TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 <= TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 <= TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 <= TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void GreaterThanOrEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool8 x = TestData_LHS[i] >= TestData_RHS[i];

                result &= x.Equals(new bool8(new bool4(TestData_LHS[i].x0 >= TestData_RHS[i].x0,
                                                         TestData_LHS[i].x1 >= TestData_RHS[i].x1,
                                                         TestData_LHS[i].x2 >= TestData_RHS[i].x2,
                                                         TestData_LHS[i].x3 >= TestData_RHS[i].x3),
                                               new bool4(TestData_LHS[i].x4 >= TestData_RHS[i].x4,
                                                         TestData_LHS[i].x5 >= TestData_RHS[i].x5,
                                                         TestData_LHS[i].x6 >= TestData_RHS[i].x6,
                                                         TestData_LHS[i].x7 >= TestData_RHS[i].x7)));
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void AllEqual()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                bool x = TestData_LHS[i].Equals(TestData_RHS[i]);

                result &= x == (TestData_LHS[i].x0 == TestData_RHS[i].x0 &
                                TestData_LHS[i].x1 == TestData_RHS[i].x1 &
                                TestData_LHS[i].x2 == TestData_RHS[i].x2 &
                                TestData_LHS[i].x3 == TestData_RHS[i].x3 &
                                TestData_LHS[i].x4 == TestData_RHS[i].x4 &
                                TestData_LHS[i].x5 == TestData_RHS[i].x5 &
                                TestData_LHS[i].x6 == TestData_RHS[i].x6 &
                                TestData_LHS[i].x7 == TestData_RHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void ShuffleGetter()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort4 v4_0 = TestData_LHS[i].v4_0;
                result &= v4_0.x == TestData_LHS[i].x0 &
                          v4_0.y == TestData_LHS[i].x1 &
                          v4_0.z == TestData_LHS[i].x2 &
                          v4_0.w == TestData_LHS[i].x3;

                ushort4 v4_1 = TestData_LHS[i].v4_1;
                result &= v4_1.x == TestData_LHS[i].x1 &
                          v4_1.y == TestData_LHS[i].x2 &
                          v4_1.z == TestData_LHS[i].x3 &
                          v4_1.w == TestData_LHS[i].x4;

                ushort4 v4_2 = TestData_LHS[i].v4_2;
                result &= v4_2.x == TestData_LHS[i].x2 &
                          v4_2.y == TestData_LHS[i].x3 &
                          v4_2.z == TestData_LHS[i].x4 &
                          v4_2.w == TestData_LHS[i].x5;

                ushort4 v4_3 = TestData_LHS[i].v4_3;
                result &= v4_3.x == TestData_LHS[i].x3 &
                          v4_3.y == TestData_LHS[i].x4 &
                          v4_3.z == TestData_LHS[i].x5 &
                          v4_3.w == TestData_LHS[i].x6;

                ushort4 v4_4 = TestData_LHS[i].v4_4;
                result &= v4_4.x == TestData_LHS[i].x4 &
                          v4_4.y == TestData_LHS[i].x5 &
                          v4_4.z == TestData_LHS[i].x6 &
                          v4_4.w == TestData_LHS[i].x7;


                ushort3 v3_0 = TestData_LHS[i].v3_0;
                result &= v3_0.x == TestData_LHS[i].x0 &
                          v3_0.y == TestData_LHS[i].x1 &
                          v3_0.z == TestData_LHS[i].x2;

                ushort3 v3_1 = TestData_LHS[i].v3_1;
                result &= v3_1.x == TestData_LHS[i].x1 &
                          v3_1.y == TestData_LHS[i].x2 &
                          v3_1.z == TestData_LHS[i].x3;

                ushort3 v3_2 = TestData_LHS[i].v3_2;
                result &= v3_2.x == TestData_LHS[i].x2 &
                          v3_2.y == TestData_LHS[i].x3 &
                          v3_2.z == TestData_LHS[i].x4;

                ushort3 v3_3 = TestData_LHS[i].v3_3;
                result &= v3_3.x == TestData_LHS[i].x3 &
                          v3_3.y == TestData_LHS[i].x4 &
                          v3_3.z == TestData_LHS[i].x5;

                ushort3 v3_4 = TestData_LHS[i].v3_4;
                result &= v3_4.x == TestData_LHS[i].x4 &
                          v3_4.y == TestData_LHS[i].x5 &
                          v3_4.z == TestData_LHS[i].x6;

                ushort3 v3_5 = TestData_LHS[i].v3_5;
                result &= v3_5.x == TestData_LHS[i].x5 &
                          v3_5.y == TestData_LHS[i].x6 &
                          v3_5.z == TestData_LHS[i].x7;


                ushort2 v2_0 = TestData_LHS[i].v2_0;
                result &= v2_0.x == TestData_LHS[i].x0 &
                          v2_0.y == TestData_LHS[i].x1;

                ushort2 v2_1 = TestData_LHS[i].v2_1;
                result &= v2_1.x == TestData_LHS[i].x1 &
                          v2_1.y == TestData_LHS[i].x2;

                ushort2 v2_2 = TestData_LHS[i].v2_2;
                result &= v2_2.x == TestData_LHS[i].x2 &
                          v2_2.y == TestData_LHS[i].x3;

                ushort2 v2_3 = TestData_LHS[i].v2_3;
                result &= v2_3.x == TestData_LHS[i].x3 &
                          v2_3.y == TestData_LHS[i].x4;

                ushort2 v2_4 = TestData_LHS[i].v2_4;
                result &= v2_4.x == TestData_LHS[i].x4 &
                          v2_4.y == TestData_LHS[i].x5;

                ushort2 v2_5 = TestData_LHS[i].v2_5;
                result &= v2_5.x == TestData_LHS[i].x5 &
                          v2_5.y == TestData_LHS[i].x6;

                ushort2 v2_6 = TestData_LHS[i].v2_6;
                result &= v2_6.x == TestData_LHS[i].x6 &
                          v2_6.y == TestData_LHS[i].x7;
            }


            Assert.AreEqual(true, result);
        }

        [Test]
        public static void ShuffleSetter()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 v4_0 = TestData_LHS[i];
                v4_0.v4_0 = __ushort4.TestData_LHS[i];
                result &= v4_0.x0 == __ushort4.TestData_LHS[i].x;
                result &= v4_0.x1 == __ushort4.TestData_LHS[i].y;
                result &= v4_0.x2 == __ushort4.TestData_LHS[i].z;
                result &= v4_0.x3 == __ushort4.TestData_LHS[i].w;
                result &= v4_0.x4 == TestData_LHS[i].x4;
                result &= v4_0.x5 == TestData_LHS[i].x5;
                result &= v4_0.x6 == TestData_LHS[i].x6;
                result &= v4_0.x7 == TestData_LHS[i].x7;

                ushort8 v4_1 = TestData_LHS[i];
                v4_1.v4_1 = __ushort4.TestData_LHS[i];
                result &= v4_1.x0 == TestData_LHS[i].x0;
                result &= v4_1.x1 == __ushort4.TestData_LHS[i].x;
                result &= v4_1.x2 == __ushort4.TestData_LHS[i].y;
                result &= v4_1.x3 == __ushort4.TestData_LHS[i].z;
                result &= v4_1.x4 == __ushort4.TestData_LHS[i].w;
                result &= v4_1.x5 == TestData_LHS[i].x5;
                result &= v4_1.x6 == TestData_LHS[i].x6;
                result &= v4_1.x7 == TestData_LHS[i].x7;

                ushort8 v4_2 = TestData_LHS[i];
                v4_2.v4_2 = __ushort4.TestData_LHS[i];
                result &= v4_2.x0 == TestData_LHS[i].x0;
                result &= v4_2.x1 == TestData_LHS[i].x1;
                result &= v4_2.x2 == __ushort4.TestData_LHS[i].x;
                result &= v4_2.x3 == __ushort4.TestData_LHS[i].y;
                result &= v4_2.x4 == __ushort4.TestData_LHS[i].z;
                result &= v4_2.x5 == __ushort4.TestData_LHS[i].w;
                result &= v4_2.x6 == TestData_LHS[i].x6;
                result &= v4_2.x7 == TestData_LHS[i].x7;
                
                ushort8 v4_3 = TestData_LHS[i];
                v4_3.v4_3 = __ushort4.TestData_LHS[i];
                result &= v4_3.x0 == TestData_LHS[i].x0;
                result &= v4_3.x1 == TestData_LHS[i].x1;
                result &= v4_3.x2 == TestData_LHS[i].x2;
                result &= v4_3.x3 == __ushort4.TestData_LHS[i].x;
                result &= v4_3.x4 == __ushort4.TestData_LHS[i].y;
                result &= v4_3.x5 == __ushort4.TestData_LHS[i].z;
                result &= v4_3.x6 == __ushort4.TestData_LHS[i].w;
                result &= v4_3.x7 == TestData_LHS[i].x7;
                
                ushort8 v4_4 = TestData_LHS[i];
                v4_4.v4_4 = __ushort4.TestData_LHS[i];
                result &= v4_4.x0 == TestData_LHS[i].x0;
                result &= v4_4.x1 == TestData_LHS[i].x1;
                result &= v4_4.x2 == TestData_LHS[i].x2;
                result &= v4_4.x3 == TestData_LHS[i].x3;
                result &= v4_4.x4 == __ushort4.TestData_LHS[i].x;
                result &= v4_4.x5 == __ushort4.TestData_LHS[i].y;
                result &= v4_4.x6 == __ushort4.TestData_LHS[i].z;
                result &= v4_4.x7 == __ushort4.TestData_LHS[i].w;


                ushort8 v3_0 = TestData_LHS[i];
                v3_0.v3_0 = __ushort3.TestData_LHS[i];
                result &= v3_0.x0 == __ushort3.TestData_LHS[i].x;
                result &= v3_0.x1 == __ushort3.TestData_LHS[i].y;
                result &= v3_0.x2 == __ushort3.TestData_LHS[i].z;
                result &= v3_0.x3 == TestData_LHS[i].x3;
                result &= v3_0.x4 == TestData_LHS[i].x4;
                result &= v3_0.x5 == TestData_LHS[i].x5;
                result &= v3_0.x6 == TestData_LHS[i].x6;
                result &= v3_0.x7 == TestData_LHS[i].x7;

                ushort8 v3_1 = TestData_LHS[i];
                v3_1.v3_1 = __ushort3.TestData_LHS[i];
                result &= v3_1.x0 == TestData_LHS[i].x0;
                result &= v3_1.x1 == __ushort3.TestData_LHS[i].x;
                result &= v3_1.x2 == __ushort3.TestData_LHS[i].y;
                result &= v3_1.x3 == __ushort3.TestData_LHS[i].z;
                result &= v3_1.x4 == TestData_LHS[i].x4;
                result &= v3_1.x5 == TestData_LHS[i].x5;
                result &= v3_1.x6 == TestData_LHS[i].x6;
                result &= v3_1.x7 == TestData_LHS[i].x7;

                ushort8 v3_2 = TestData_LHS[i];
                v3_2.v3_2 = __ushort3.TestData_LHS[i];
                result &= v3_2.x0 == TestData_LHS[i].x0;
                result &= v3_2.x1 == TestData_LHS[i].x1;
                result &= v3_2.x2 == __ushort3.TestData_LHS[i].x;
                result &= v3_2.x3 == __ushort3.TestData_LHS[i].y;
                result &= v3_2.x4 == __ushort3.TestData_LHS[i].z;
                result &= v3_2.x5 == TestData_LHS[i].x5;
                result &= v3_2.x6 == TestData_LHS[i].x6;
                result &= v3_2.x7 == TestData_LHS[i].x7;

                ushort8 v3_3 = TestData_LHS[i];
                v3_3.v3_3 = __ushort3.TestData_LHS[i];
                result &= v3_3.x0 == TestData_LHS[i].x0;
                result &= v3_3.x1 == TestData_LHS[i].x1;
                result &= v3_3.x2 == TestData_LHS[i].x2;
                result &= v3_3.x3 == __ushort3.TestData_LHS[i].x;
                result &= v3_3.x4 == __ushort3.TestData_LHS[i].y;
                result &= v3_3.x5 == __ushort3.TestData_LHS[i].z;
                result &= v3_3.x6 == TestData_LHS[i].x6;
                result &= v3_3.x7 == TestData_LHS[i].x7;

                ushort8 v3_4 = TestData_LHS[i];
                v3_4.v3_4 = __ushort3.TestData_LHS[i];
                result &= v3_4.x0 == TestData_LHS[i].x0;
                result &= v3_4.x1 == TestData_LHS[i].x1;
                result &= v3_4.x2 == TestData_LHS[i].x2;
                result &= v3_4.x3 == TestData_LHS[i].x3;
                result &= v3_4.x4 == __ushort3.TestData_LHS[i].x;
                result &= v3_4.x5 == __ushort3.TestData_LHS[i].y;
                result &= v3_4.x6 == __ushort3.TestData_LHS[i].z;
                result &= v3_4.x7 == TestData_LHS[i].x7;

                ushort8 v3_5 = TestData_LHS[i];
                v3_5.v3_5 = __ushort3.TestData_LHS[i];
                result &= v3_5.x0 == TestData_LHS[i].x0;
                result &= v3_5.x1 == TestData_LHS[i].x1;
                result &= v3_5.x2 == TestData_LHS[i].x2;
                result &= v3_5.x3 == TestData_LHS[i].x3;
                result &= v3_5.x4 == TestData_LHS[i].x4;
                result &= v3_5.x5 == __ushort3.TestData_LHS[i].x;
                result &= v3_5.x6 == __ushort3.TestData_LHS[i].y;
                result &= v3_5.x7 == __ushort3.TestData_LHS[i].z;


                ushort8 v2_0 = TestData_LHS[i];
                v2_0.v2_0 = __ushort2.TestData_LHS[i];
                result &= v2_0.x0 == __ushort2.TestData_LHS[i].x;
                result &= v2_0.x1 == __ushort2.TestData_LHS[i].y;
                result &= v2_0.x2 == TestData_LHS[i].x2;
                result &= v2_0.x3 == TestData_LHS[i].x3;
                result &= v2_0.x4 == TestData_LHS[i].x4;
                result &= v2_0.x5 == TestData_LHS[i].x5;
                result &= v2_0.x6 == TestData_LHS[i].x6;
                result &= v2_0.x7 == TestData_LHS[i].x7;

                ushort8 v2_1 = TestData_LHS[i];
                v2_1.v2_1 = __ushort2.TestData_LHS[i];
                result &= v2_1.x0 == TestData_LHS[i].x0;
                result &= v2_1.x1 == __ushort2.TestData_LHS[i].x;
                result &= v2_1.x2 == __ushort2.TestData_LHS[i].y;
                result &= v2_1.x3 == TestData_LHS[i].x3;
                result &= v2_1.x4 == TestData_LHS[i].x4;
                result &= v2_1.x5 == TestData_LHS[i].x5;
                result &= v2_1.x6 == TestData_LHS[i].x6;
                result &= v2_1.x7 == TestData_LHS[i].x7;

                ushort8 v2_2 = TestData_LHS[i];
                v2_2.v2_2 = __ushort2.TestData_LHS[i];
                result &= v2_2.x0 == TestData_LHS[i].x0;
                result &= v2_2.x1 == TestData_LHS[i].x1;
                result &= v2_2.x2 == __ushort2.TestData_LHS[i].x;
                result &= v2_2.x3 == __ushort2.TestData_LHS[i].y;
                result &= v2_2.x4 == TestData_LHS[i].x4;
                result &= v2_2.x5 == TestData_LHS[i].x5;
                result &= v2_2.x6 == TestData_LHS[i].x6;
                result &= v2_2.x7 == TestData_LHS[i].x7;

                ushort8 v2_3 = TestData_LHS[i];
                v2_3.v2_3 = __ushort2.TestData_LHS[i];
                result &= v2_3.x0 == TestData_LHS[i].x0;
                result &= v2_3.x1 == TestData_LHS[i].x1;
                result &= v2_3.x2 == TestData_LHS[i].x2;
                result &= v2_3.x3 == __ushort2.TestData_LHS[i].x;
                result &= v2_3.x4 == __ushort2.TestData_LHS[i].y;
                result &= v2_3.x5 == TestData_LHS[i].x5;
                result &= v2_3.x6 == TestData_LHS[i].x6;
                result &= v2_3.x7 == TestData_LHS[i].x7;

                ushort8 v2_4 = TestData_LHS[i];
                v2_4.v2_4 = __ushort2.TestData_LHS[i];
                result &= v2_4.x0 == TestData_LHS[i].x0;
                result &= v2_4.x1 == TestData_LHS[i].x1;
                result &= v2_4.x2 == TestData_LHS[i].x2;
                result &= v2_4.x3 == TestData_LHS[i].x3;
                result &= v2_4.x4 == __ushort2.TestData_LHS[i].x;
                result &= v2_4.x5 == __ushort2.TestData_LHS[i].y;
                result &= v2_4.x6 == TestData_LHS[i].x6;
                result &= v2_4.x7 == TestData_LHS[i].x7;

                ushort8 v2_5 = TestData_LHS[i];
                v2_5.v2_5 = __ushort2.TestData_LHS[i];
                result &= v2_5.x0 == TestData_LHS[i].x0;
                result &= v2_5.x1 == TestData_LHS[i].x1;
                result &= v2_5.x2 == TestData_LHS[i].x2;
                result &= v2_5.x3 == TestData_LHS[i].x3;
                result &= v2_5.x4 == TestData_LHS[i].x4;
                result &= v2_5.x5 == __ushort2.TestData_LHS[i].x;
                result &= v2_5.x6 == __ushort2.TestData_LHS[i].y;
                result &= v2_5.x7 == TestData_LHS[i].x7;

                ushort8 v2_6 = TestData_LHS[i];
                v2_6.v2_6 = __ushort2.TestData_LHS[i];
                result &= v2_6.x0 == TestData_LHS[i].x0;
                result &= v2_6.x1 == TestData_LHS[i].x1;
                result &= v2_6.x2 == TestData_LHS[i].x2;
                result &= v2_6.x3 == TestData_LHS[i].x3;
                result &= v2_6.x4 == TestData_LHS[i].x4;
                result &= v2_6.x5 == TestData_LHS[i].x5;
                result &= v2_6.x6 == __ushort2.TestData_LHS[i].x;
                result &= v2_6.x7 == __ushort2.TestData_LHS[i].y;
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Cast_ToV128()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                v128 x = TestData_LHS[i];

                result &= x.UShort0 == TestData_LHS[i].x0 &
                          x.UShort1 == TestData_LHS[i].x1 &
                          x.UShort2 == TestData_LHS[i].x2 &
                          x.UShort3 == TestData_LHS[i].x3 &
                          x.UShort4 == TestData_LHS[i].x4 &
                          x.UShort5 == TestData_LHS[i].x5 &
                          x.UShort6 == TestData_LHS[i].x6 &
                          x.UShort7 == TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Cast_FromV128()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                ushort8 x = TestData_LHS[i];
                v128 c = x;
                x = c;

                result &= x.x0 == TestData_LHS[i].x0 &
                          x.x1 == TestData_LHS[i].x1 &
                          x.x2 == TestData_LHS[i].x2 &
                          x.x3 == TestData_LHS[i].x3 &
                          x.x4 == TestData_LHS[i].x4 &
                          x.x5 == TestData_LHS[i].x5 &
                          x.x6 == TestData_LHS[i].x6 &
                          x.x7 == TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }


        [Test]
        public static void Cast_ToByte()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                byte8 x = (byte8)TestData_LHS[i];

                result &= x.x0 == (byte)TestData_LHS[i].x0 &
                          x.x1 == (byte)TestData_LHS[i].x1 &
                          x.x2 == (byte)TestData_LHS[i].x2 &
                          x.x3 == (byte)TestData_LHS[i].x3 &
                          x.x4 == (byte)TestData_LHS[i].x4 &
                          x.x5 == (byte)TestData_LHS[i].x5 &
                          x.x6 == (byte)TestData_LHS[i].x6 &
                          x.x7 == (byte)TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Cast_ToSByte()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                sbyte8 x = (sbyte8)TestData_LHS[i];

                result &= x.x0 == (sbyte)TestData_LHS[i].x0 &
                          x.x1 == (sbyte)TestData_LHS[i].x1 &
                          x.x2 == (sbyte)TestData_LHS[i].x2 &
                          x.x3 == (sbyte)TestData_LHS[i].x3 &
                          x.x4 == (sbyte)TestData_LHS[i].x4 &
                          x.x5 == (sbyte)TestData_LHS[i].x5 &
                          x.x6 == (sbyte)TestData_LHS[i].x6 &
                          x.x7 == (sbyte)TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Cast_ToInt()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                int8 x = TestData_LHS[i];

                result &= x.x0 == TestData_LHS[i].x0 &
                          x.x1 == TestData_LHS[i].x1 &
                          x.x2 == TestData_LHS[i].x2 &
                          x.x3 == TestData_LHS[i].x3 &
                          x.x4 == TestData_LHS[i].x4 &
                          x.x5 == TestData_LHS[i].x5 &
                          x.x6 == TestData_LHS[i].x6 &
                          x.x7 == TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Cast_ToUInt()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                uint8 x = TestData_LHS[i];

                result &= x.x0 == TestData_LHS[i].x0 &
                          x.x1 == TestData_LHS[i].x1 &
                          x.x2 == TestData_LHS[i].x2 &
                          x.x3 == TestData_LHS[i].x3 &
                          x.x4 == TestData_LHS[i].x4 &
                          x.x5 == TestData_LHS[i].x5 &
                          x.x6 == TestData_LHS[i].x6 &
                          x.x7 == TestData_LHS[i].x7;
            }

            Assert.AreEqual(true, result);
        }

        [Test]
        public static void Cast_ToFloat()
        {
            bool result = true;

            for (int i = 0; i < NUM_TESTS; i++)
            {
                float8 x = TestData_LHS[i];

                result &= maxmath.approx(x.x0, (float)TestData_LHS[i].x0) &
                          maxmath.approx(x.x1, (float)TestData_LHS[i].x1) &
                          maxmath.approx(x.x2, (float)TestData_LHS[i].x2) &
                          maxmath.approx(x.x3, (float)TestData_LHS[i].x3) &
                          maxmath.approx(x.x4, (float)TestData_LHS[i].x4) &
                          maxmath.approx(x.x5, (float)TestData_LHS[i].x5) &
                          maxmath.approx(x.x6, (float)TestData_LHS[i].x6) &
                          maxmath.approx(x.x7, (float)TestData_LHS[i].x7);
            }

            Assert.AreEqual(true, result);
        }
    }
}