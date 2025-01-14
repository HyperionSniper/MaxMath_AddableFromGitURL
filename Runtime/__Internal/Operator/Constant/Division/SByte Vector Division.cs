using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
	unsafe internal static partial class Operator
	{
		internal static partial class Constant
		{
			internal static v128 vdiv_sbyte(v128 vector, sbyte divisor, int vectorElementCount)
			{
				if (vectorElementCount <= 8)
				{
					if (Ssse3.IsSsse3Supported)
					{
						switch (divisor)
						{
							case -128: return Sse2.sub_epi8(Sse2.setzero_si128(), Sse2.cmpeq_epi8(new sbyte4(sbyte.MinValue), vector));
							case -127: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-130));

								return Sse2.packs_epi16(result, result);
							}
							case -126: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-131));

								return Sse2.packs_epi16(result, result);
							}
							case -125: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-132));

								return Sse2.packs_epi16(result, result);
							}
							case -124: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-133));

								return Sse2.packs_epi16(result, result);
							}
							case -123: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-134));

								return Sse2.packs_epi16(result, result);
							}
							case -122: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-135));

								return Sse2.packs_epi16(result, result);
							}
							case -121: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-136));

								return Sse2.packs_epi16(result, result);
							}
							case -120: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-137));

								return Sse2.packs_epi16(result, result);
							}
							case -119: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-138));

								return Sse2.packs_epi16(result, result);
							}
							case -118: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-140));

								return Sse2.packs_epi16(result, result);
							}
							case -117: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-141));

								return Sse2.packs_epi16(result, result);
							}
							case -116: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-142));

								return Sse2.packs_epi16(result, result);
							}
							case -115: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-143));

								return Sse2.packs_epi16(result, result);
							}
							case -114: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-144));

								return Sse2.packs_epi16(result, result);
							}
							case -113: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-146));

								return Sse2.packs_epi16(result, result);
							}
							case -112: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-147));

								return Sse2.packs_epi16(result, result);
							}
							case -111: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-148));

								return Sse2.packs_epi16(result, result);
							}
							case -110: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-150));

								return Sse2.packs_epi16(result, result);
							}
							case -109: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-151));

								return Sse2.packs_epi16(result, result);
							}
							case -108: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-153));

								return Sse2.packs_epi16(result, result);
							}
							case -107: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-154));

								return Sse2.packs_epi16(result, result);
							}
							case -106: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-156));

								return Sse2.packs_epi16(result, result);
							}
							case -105: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-157));

								return Sse2.packs_epi16(result, result);
							}
							case -104: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-159));

								return Sse2.packs_epi16(result, result);
							}
							case -103: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-160));

								return Sse2.packs_epi16(result, result);
							}
							case -102: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-162));

								return Sse2.packs_epi16(result, result);
							}
							case -101: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-163));

								return Sse2.packs_epi16(result, result);
							}
							case -100: 
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-165));

								return Sse2.packs_epi16(result, result);
							}
							case -99:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-167));

								return Sse2.packs_epi16(result, result);
							}
							case -98:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-168));

								return Sse2.packs_epi16(result, result);
							}
							case -97:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-170));

								return Sse2.packs_epi16(result, result);
							}
							case -96:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-172));

								return Sse2.packs_epi16(result, result);
							}
							case -95:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-174));

								return Sse2.packs_epi16(result, result);
							}
							case -94:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-176));

								return Sse2.packs_epi16(result, result);
							}
							case -93:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-178));

								return Sse2.packs_epi16(result, result);
							}
							case -92:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-180));

								return Sse2.packs_epi16(result, result);
							}
							case -91:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-182));

								return Sse2.packs_epi16(result, result);
							}
							case -90:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-184));

								return Sse2.packs_epi16(result, result);
							}
							case -89:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-186));

								return Sse2.packs_epi16(result, result);
							}
							case -88:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-188));

								return Sse2.packs_epi16(result, result);
							}
							case -87:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-190));

								return Sse2.packs_epi16(result, result);
							}
							case -86:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-192));

								return Sse2.packs_epi16(result, result);
							}
							case -85:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-195));

								return Sse2.packs_epi16(result, result);
							}
							case -84:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-197));

								return Sse2.packs_epi16(result, result);
							}
							case -83:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-199));

								return Sse2.packs_epi16(result, result);
							}
							case -82:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-202));

								return Sse2.packs_epi16(result, result);
							}
							case -81:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-204));

								return Sse2.packs_epi16(result, result);
							}
							case -80:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-207));

								return Sse2.packs_epi16(result, result);
							}
							case -79:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-210));

								return Sse2.packs_epi16(result, result);
							}
							case -78:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-212));

								return Sse2.packs_epi16(result, result);
							}
							case -77:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-215));

								return Sse2.packs_epi16(result, result);
							}
							case -76:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-218));

								return Sse2.packs_epi16(result, result);
							}
							case -75:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-221));

								return Sse2.packs_epi16(result, result);
							}
							case -74:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-224));

								return Sse2.packs_epi16(result, result);
							}
							case -73:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-227));

								return Sse2.packs_epi16(result, result);
							}
							case -72:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-230));

								return Sse2.packs_epi16(result, result);
							}
							case -71:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-234));

								return Sse2.packs_epi16(result, result);
							}
							case -70:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-237));

								return Sse2.packs_epi16(result, result);
							}
							case -69:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-240));

								return Sse2.packs_epi16(result, result);
							}
							case -68:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-244));

								return Sse2.packs_epi16(result, result);
							}
							case -67:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-248));

								return Sse2.packs_epi16(result, result);
							}
							case -66:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-252));

								return Sse2.packs_epi16(result, result);
							}
							case -65:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-255));

								return Sse2.packs_epi16(result, result);
							}
							case -2:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(-16383));

								return Sse2.packs_epi16(result, result);
							}
							case 2:    
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(16257));

								return Sse2.packs_epi16(result, result);
							}
							case 65:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(255));

								return Sse2.packs_epi16(result, result);
							}
							case 66:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(249));

								return Sse2.packs_epi16(result, result);
							}
							case 67:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(245));

								return Sse2.packs_epi16(result, result);
							}
							case 68:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(241));

								return Sse2.packs_epi16(result, result);
							}
							case 69:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(238));

								return Sse2.packs_epi16(result, result);
							}
							case 70:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(235));

								return Sse2.packs_epi16(result, result);
							}
							case 71:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(231));

								return Sse2.packs_epi16(result, result);
							}
							case 72:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(228));

								return Sse2.packs_epi16(result, result);
							}
							case 73:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(225));

								return Sse2.packs_epi16(result, result);
							}
							case 74:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(222));

								return Sse2.packs_epi16(result, result);
							}
							case 75:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(219));

								return Sse2.packs_epi16(result, result);
							}
							case 76:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(216));

								return Sse2.packs_epi16(result, result);
							}
							case 77:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(213));

								return Sse2.packs_epi16(result, result);
							}
							case 78:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(211));

								return Sse2.packs_epi16(result, result);
							}
							case 79:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(208));

								return Sse2.packs_epi16(result, result);
							}
							case 80:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(205));

								return Sse2.packs_epi16(result, result);
							}
							case 81:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(203));

								return Sse2.packs_epi16(result, result);
							}
							case 82:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(200));

								return Sse2.packs_epi16(result, result);
							}
							case 83:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(198));

								return Sse2.packs_epi16(result, result);
							}
							case 84:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(196));

								return Sse2.packs_epi16(result, result);
							}
							case 85:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(193));

								return Sse2.packs_epi16(result, result);
							}
							case 86:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(191));

								return Sse2.packs_epi16(result, result);
							}
							case 87:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(189));

								return Sse2.packs_epi16(result, result);
							}
							case 88:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(187));

								return Sse2.packs_epi16(result, result);
							}
							case 89:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(185));

								return Sse2.packs_epi16(result, result);
							}
							case 90:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(183));

								return Sse2.packs_epi16(result, result);
							}
							case 91:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(181));

								return Sse2.packs_epi16(result, result);
							}
							case 92:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(179));

								return Sse2.packs_epi16(result, result);
							}
							case 93:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(177));

								return Sse2.packs_epi16(result, result);
							}
							case 94:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(175));

								return Sse2.packs_epi16(result, result);
							}
							case 95:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(173));

								return Sse2.packs_epi16(result, result);
							}
							case 96:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(171));

								return Sse2.packs_epi16(result, result);
							}
							case 97:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(169));

								return Sse2.packs_epi16(result, result);
							}
							case 98:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(168));

								return Sse2.packs_epi16(result, result);
							}
							case 99:   
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(166));

								return Sse2.packs_epi16(result, result);
							}
							case 100:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(164));

								return Sse2.packs_epi16(result, result);
							}
							case 101:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(163));

								return Sse2.packs_epi16(result, result);
							}
							case 102:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(161));

								return Sse2.packs_epi16(result, result);
							}
							case 103:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(160));

								return Sse2.packs_epi16(result, result);
							}
							case 104:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(158));

								return Sse2.packs_epi16(result, result);
							}
							case 105:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(157));

								return Sse2.packs_epi16(result, result);
							}
							case 106:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(155));

								return Sse2.packs_epi16(result, result);
							}
							case 107:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(154));

								return Sse2.packs_epi16(result, result);
							}
							case 108:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(152));

								return Sse2.packs_epi16(result, result);
							}
							case 109:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(151));

								return Sse2.packs_epi16(result, result);
							}
							case 110:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(149));

								return Sse2.packs_epi16(result, result);
							}
							case 111:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(148));

								return Sse2.packs_epi16(result, result);
							}
							case 112:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(147));

								return Sse2.packs_epi16(result, result);
							}
							case 113:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(145));

								return Sse2.packs_epi16(result, result);
							}
							case 114:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(144));

								return Sse2.packs_epi16(result, result);
							}
							case 115:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(143));

								return Sse2.packs_epi16(result, result);
							}
							case 116:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(142));

								return Sse2.packs_epi16(result, result);
							}
							case 117:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(141));

								return Sse2.packs_epi16(result, result);
							}
							case 118:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(139));

								return Sse2.packs_epi16(result, result);
							}
							case 119:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(138));

								return Sse2.packs_epi16(result, result);
							}
							case 120:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(137));

								return Sse2.packs_epi16(result, result);
							}
							case 121:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(136));

								return Sse2.packs_epi16(result, result);
							}
							case 122:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(135));

								return Sse2.packs_epi16(result, result);
							}
							case 123:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(134));

								return Sse2.packs_epi16(result, result);
							}
							case 124:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(133));

								return Sse2.packs_epi16(result, result);
							}
							case 125:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(132));

								return Sse2.packs_epi16(result, result);
							}
							case 126:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(131));

								return Sse2.packs_epi16(result, result);
							}
							case 127:  
							{
								v128 result = Ssse3.mulhrs_epi16(Cast.SByteToShort(vector), new short8(130));

								return Sse2.packs_epi16(result, result);
							}
						}
					}
				}
				else
				{
					if (Ssse3.IsSsse3Supported)
					{
						switch (divisor)
						{
							case -128: return Sse2.sub_epi8(Sse2.setzero_si128(), Sse2.cmpeq_epi8(new sbyte16(sbyte.MinValue), vector));

							case -127: 
							{
								v128 MAGIC = new short8(-130);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -126: 
							{
								v128 MAGIC = new short8(-131);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -125: 
							{
								v128 MAGIC = new short8(-132);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -124: 
							{
								v128 MAGIC = new short8(-133);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -123: 
							{
								v128 MAGIC = new short8(-134);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -122: 
							{
								v128 MAGIC = new short8(-135);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -121: 
							{
								v128 MAGIC = new short8(-136);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -120: 
							{
								v128 MAGIC = new short8(-137);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -119: 
							{
								v128 MAGIC = new short8(-138);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -118: 
							{
								v128 MAGIC = new short8(-140);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -117: 
							{
								v128 MAGIC = new short8(-141);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -116: 
							{
								v128 MAGIC = new short8(-142);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -115: 
							{
								v128 MAGIC = new short8(-143);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -114: 
							{
								v128 MAGIC = new short8(-144);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -113: 
							{
								v128 MAGIC = new short8(-146);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -112: 
							{
								v128 MAGIC = new short8(-147);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -111: 
							{
								v128 MAGIC = new short8(-148);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -110: 
							{
								v128 MAGIC = new short8(-150);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -109: 
							{
								v128 MAGIC = new short8(-151);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -108: 
							{
								v128 MAGIC = new short8(-153);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -107: 
							{
								v128 MAGIC = new short8(-154);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -106: 
							{
								v128 MAGIC = new short8(-156);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -105: 
							{
								v128 MAGIC = new short8(-157);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -104: 
							{
								v128 MAGIC = new short8(-159);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -103: 
							{
								v128 MAGIC = new short8(-160);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -102: 
							{
								v128 MAGIC = new short8(-162);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -101: 
							{
								v128 MAGIC = new short8(-163);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -100: 
							{
								v128 MAGIC = new short8(-165);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -99:  
							{
								v128 MAGIC = new short8(-167);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -98:  
							{
								v128 MAGIC = new short8(-168);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -97:  
							{
								v128 MAGIC = new short8(-170);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -96:  
							{
								v128 MAGIC = new short8(-172);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -95:  
							{
								v128 MAGIC = new short8(-174);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -94:  
							{
								v128 MAGIC = new short8(-176);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -93:  
							{
								v128 MAGIC = new short8(-178);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -92:  
							{
								v128 MAGIC = new short8(-180);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -91:  
							{
								v128 MAGIC = new short8(-182);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -90:  
							{
								v128 MAGIC = new short8(-184);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -89:  
							{
								v128 MAGIC = new short8(-186);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -88:  
							{
								v128 MAGIC = new short8(-188);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -87:  
							{
								v128 MAGIC = new short8(-190);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -86:  
							{
								v128 MAGIC = new short8(-192);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -85:  
							{
								v128 MAGIC = new short8(-195);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -84:  
							{
								v128 MAGIC = new short8(-197);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -83:  
							{
								v128 MAGIC = new short8(-199);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -82:  
							{
								v128 MAGIC = new short8(-202);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -81:  
							{
								v128 MAGIC = new short8(-204);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -80:  
							{
								v128 MAGIC = new short8(-207);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -79:  
							{
								v128 MAGIC = new short8(-210);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -78:  
							{
								v128 MAGIC = new short8(-212);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -77:  
							{
								v128 MAGIC = new short8(-215);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -76:  
							{
								v128 MAGIC = new short8(-218);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -75:  
							{
								v128 MAGIC = new short8(-221);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -74:  
							{
								v128 MAGIC = new short8(-224);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -73:  
							{
								v128 MAGIC = new short8(-227);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -72:  
							{
								v128 MAGIC = new short8(-230);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -71:  
							{
								v128 MAGIC = new short8(-234);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -70:  
							{
								v128 MAGIC = new short8(-237);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -69:  
							{
								v128 MAGIC = new short8(-240);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -68:  
							{
								v128 MAGIC = new short8(-244);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -67:  
							{
								v128 MAGIC = new short8(-248);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -66:  
							{
								v128 MAGIC = new short8(-252);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -65:  
							{
								v128 MAGIC = new short8(-255);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case -2:   
							{
								v128 MAGIC = new short8(-16383);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 2:    
							{
								v128 MAGIC = new short8(16257);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 65:   
							{
								v128 MAGIC = new short8(255);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 66:   
							{
								v128 MAGIC = new short8(249);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 67:   
							{
								v128 MAGIC = new short8(245);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 68:   
							{
								v128 MAGIC = new short8(241);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 69:   
							{
								v128 MAGIC = new short8(238);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 70:   
							{
								v128 MAGIC = new short8(235);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 71:   
							{
								v128 MAGIC = new short8(231);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 72:   
							{
								v128 MAGIC = new short8(228);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 73:   
							{
								v128 MAGIC = new short8(225);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 74:   
							{
								v128 MAGIC = new short8(222);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 75:   
							{
								v128 MAGIC = new short8(219);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 76:   
							{
								v128 MAGIC = new short8(216);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 77:   
							{
								v128 MAGIC = new short8(213);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 78:   
							{
								v128 MAGIC = new short8(211);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 79:   
							{
								v128 MAGIC = new short8(208);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 80:   
							{
								v128 MAGIC = new short8(205);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 81:   
							{
								v128 MAGIC = new short8(203);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 82:   
							{
								v128 MAGIC = new short8(200);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 83:   
							{
								v128 MAGIC = new short8(198);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 84:   
							{
								v128 MAGIC = new short8(196);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 85:   
							{
								v128 MAGIC = new short8(193);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 86:   
							{
								v128 MAGIC = new short8(191);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 87:   
							{
								v128 MAGIC = new short8(189);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 88:   
							{
								v128 MAGIC = new short8(187);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 89:   
							{
								v128 MAGIC = new short8(185);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 90:   
							{
								v128 MAGIC = new short8(183);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 91:   
							{
								v128 MAGIC = new short8(181);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 92:   
							{
								v128 MAGIC = new short8(179);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 93:   
							{
								v128 MAGIC = new short8(177);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 94:   
							{
								v128 MAGIC = new short8(175);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 95:   
							{
								v128 MAGIC = new short8(173);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 96:   
							{
								v128 MAGIC = new short8(171);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 97:   
							{
								v128 MAGIC = new short8(169);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 98:   
							{
								v128 MAGIC = new short8(168);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 99:   
							{
								v128 MAGIC = new short8(166);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 100:  
							{
								v128 MAGIC = new short8(164);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 101:  
							{
								v128 MAGIC = new short8(163);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 102:  
							{
								v128 MAGIC = new short8(161);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 103:  
							{
								v128 MAGIC = new short8(160);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 104:  
							{
								v128 MAGIC = new short8(158);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 105:  
							{
								v128 MAGIC = new short8(157);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 106:  
							{
								v128 MAGIC = new short8(155);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 107:  
							{
								v128 MAGIC = new short8(154);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 108:  
							{
								v128 MAGIC = new short8(152);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 109:  
							{
								v128 MAGIC = new short8(151);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 110:  
							{
								v128 MAGIC = new short8(149);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 111:  
							{
								v128 MAGIC = new short8(148);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 112:  
							{
								v128 MAGIC = new short8(147);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 113:  
							{
								v128 MAGIC = new short8(145);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 114:  
							{
								v128 MAGIC = new short8(144);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 115:  
							{
								v128 MAGIC = new short8(143);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 116:  
							{
								v128 MAGIC = new short8(142);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 117:  
							{
								v128 MAGIC = new short8(141);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 118:  
							{
								v128 MAGIC = new short8(139);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 119:  
							{
								v128 MAGIC = new short8(138);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 120:  
							{
								v128 MAGIC = new short8(137);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 121:  
							{
								v128 MAGIC = new short8(136);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 122:  
							{
								v128 MAGIC = new short8(135);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 123:  
							{
								v128 MAGIC = new short8(134);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 124:  
							{
								v128 MAGIC = new short8(133);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 125:  
							{
								v128 MAGIC = new short8(132);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 126:  
							{
								v128 MAGIC = new short8(131);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
							case 127:  
							{
								v128 MAGIC = new short8(130);

								v128 cvtMask = Sse2.cmpgt_epi8(Sse2.setzero_si128(), vector);
								v128 lo = Ssse3.mulhrs_epi16(Sse2.unpacklo_epi8(vector, cvtMask), MAGIC);
								v128 hi = Ssse3.mulhrs_epi16(Sse2.unpackhi_epi8(vector, cvtMask), MAGIC);

								return Sse2.packs_epi16(lo, hi);
							}
						}
					}
				}

				return new v128((sbyte)(vector.SByte0 / divisor), (sbyte)(vector.SByte1 / divisor), (sbyte)(vector.SByte2 / divisor), (sbyte)(vector.SByte3 / divisor), (sbyte)(vector.SByte4 / divisor), (sbyte)(vector.SByte5 / divisor), (sbyte)(vector.SByte6 / divisor), (sbyte)(vector.SByte7 / divisor), (sbyte)(vector.SByte8 / divisor), (sbyte)(vector.SByte9 / divisor), (sbyte)(vector.SByte10 / divisor), (sbyte)(vector.SByte11 / divisor), (sbyte)(vector.SByte12 / divisor), (sbyte)(vector.SByte13 / divisor), (sbyte)(vector.SByte14 / divisor), (sbyte)(vector.SByte15 / divisor));
			}

			internal static v256 vdiv_sbyte(v256 vector, sbyte divisor)
			{
				if (Avx2.IsAvx2Supported)
				{
					switch (divisor)
					{
						case -128: return Avx2.mm256_sub_epi8(Avx.mm256_setzero_si256(), Avx2.mm256_cmpeq_epi8(new sbyte32(sbyte.MinValue), vector));

						case -127: 
						{
							v256 MAGIC = new short16(-130);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -126: 
						{
							v256 MAGIC = new short16(-131);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -125: 
						{
							v256 MAGIC = new short16(-132);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -124: 
						{
							v256 MAGIC = new short16(-133);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -123: 
						{
							v256 MAGIC = new short16(-134);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -122: 
						{
							v256 MAGIC = new short16(-135);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -121: 
						{
							v256 MAGIC = new short16(-136);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -120: 
						{
							v256 MAGIC = new short16(-137);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -119: 
						{
							v256 MAGIC = new short16(-138);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -118: 
						{
							v256 MAGIC = new short16(-140);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -117: 
						{
							v256 MAGIC = new short16(-141);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -116: 
						{
							v256 MAGIC = new short16(-142);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -115: 
						{
							v256 MAGIC = new short16(-143);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -114: 
						{
							v256 MAGIC = new short16(-144);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -113: 
						{
							v256 MAGIC = new short16(-146);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -112: 
						{
							v256 MAGIC = new short16(-147);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -111: 
						{
							v256 MAGIC = new short16(-148);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -110: 
						{
							v256 MAGIC = new short16(-150);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -109: 
						{
							v256 MAGIC = new short16(-151);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -108: 
						{
							v256 MAGIC = new short16(-153);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -107: 
						{
							v256 MAGIC = new short16(-154);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -106: 
						{
							v256 MAGIC = new short16(-156);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -105: 
						{
							v256 MAGIC = new short16(-157);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -104: 
						{
							v256 MAGIC = new short16(-159);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -103: 
						{
							v256 MAGIC = new short16(-160);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -102: 
						{
							v256 MAGIC = new short16(-162);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -101: 
						{
							v256 MAGIC = new short16(-163);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -100: 
						{
							v256 MAGIC = new short16(-165);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -99:  
						{
							v256 MAGIC = new short16(-167);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -98:  
						{
							v256 MAGIC = new short16(-168);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -97:  
						{
							v256 MAGIC = new short16(-170);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -96:  
						{
							v256 MAGIC = new short16(-172);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -95:  
						{
							v256 MAGIC = new short16(-174);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -94:  
						{
							v256 MAGIC = new short16(-176);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -93:  
						{
							v256 MAGIC = new short16(-178);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -92:  
						{
							v256 MAGIC = new short16(-180);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -91:  
						{
							v256 MAGIC = new short16(-182);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -90:  
						{
							v256 MAGIC = new short16(-184);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -89:  
						{
							v256 MAGIC = new short16(-186);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -88:  
						{
							v256 MAGIC = new short16(-188);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -87:  
						{
							v256 MAGIC = new short16(-190);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -86:  
						{
							v256 MAGIC = new short16(-192);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -85:  
						{
							v256 MAGIC = new short16(-195);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -84:  
						{
							v256 MAGIC = new short16(-197);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -83:  
						{
							v256 MAGIC = new short16(-199);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -82:  
						{
							v256 MAGIC = new short16(-202);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -81:  
						{
							v256 MAGIC = new short16(-204);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -80:  
						{
							v256 MAGIC = new short16(-207);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -79:  
						{
							v256 MAGIC = new short16(-210);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -78:  
						{
							v256 MAGIC = new short16(-212);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -77:  
						{
							v256 MAGIC = new short16(-215);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -76:  
						{
							v256 MAGIC = new short16(-218);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -75:  
						{
							v256 MAGIC = new short16(-221);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -74:  
						{
							v256 MAGIC = new short16(-224);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -73:  
						{
							v256 MAGIC = new short16(-227);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -72:  
						{
							v256 MAGIC = new short16(-230);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -71:  
						{
							v256 MAGIC = new short16(-234);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -70:  
						{
							v256 MAGIC = new short16(-237);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -69:  
						{
							v256 MAGIC = new short16(-240);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -68:  
						{
							v256 MAGIC = new short16(-244);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -67:  
						{
							v256 MAGIC = new short16(-248);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -66:  
						{
							v256 MAGIC = new short16(-252);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -65:  
						{
							v256 MAGIC = new short16(-255);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case -2:   
						{
							v256 MAGIC = new short16(-16383);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 2:    
						{
							v256 MAGIC = new short16(16257);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 65:   
						{
							v256 MAGIC = new short16(255);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 66:   
						{
							v256 MAGIC = new short16(249);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 67:   
						{
							v256 MAGIC = new short16(245);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 68:   
						{
							v256 MAGIC = new short16(241);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 69:   
						{
							v256 MAGIC = new short16(238);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 70:   
						{
							v256 MAGIC = new short16(235);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 71:   
						{
							v256 MAGIC = new short16(231);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 72:   
						{
							v256 MAGIC = new short16(228);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 73:   
						{
							v256 MAGIC = new short16(225);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 74:   
						{
							v256 MAGIC = new short16(222);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 75:   
						{
							v256 MAGIC = new short16(219);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 76:   
						{
							v256 MAGIC = new short16(216);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 77:   
						{
							v256 MAGIC = new short16(213);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 78:   
						{
							v256 MAGIC = new short16(211);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 79:   
						{
							v256 MAGIC = new short16(208);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 80:   
						{
							v256 MAGIC = new short16(205);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 81:   
						{
							v256 MAGIC = new short16(203);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 82:   
						{
							v256 MAGIC = new short16(200);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 83:   
						{
							v256 MAGIC = new short16(198);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 84:   
						{
							v256 MAGIC = new short16(196);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 85:   
						{
							v256 MAGIC = new short16(193);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 86:   
						{
							v256 MAGIC = new short16(191);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 87:   
						{
							v256 MAGIC = new short16(189);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 88:   
						{
							v256 MAGIC = new short16(187);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 89:   
						{
							v256 MAGIC = new short16(185);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 90:   
						{
							v256 MAGIC = new short16(183);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 91:   
						{
							v256 MAGIC = new short16(181);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 92:   
						{
							v256 MAGIC = new short16(179);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 93:   
						{
							v256 MAGIC = new short16(177);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 94:   
						{
							v256 MAGIC = new short16(175);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 95:   
						{
							v256 MAGIC = new short16(173);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 96:   
						{
							v256 MAGIC = new short16(171);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 97:   
						{
							v256 MAGIC = new short16(169);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 98:   
						{
							v256 MAGIC = new short16(168);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 99:   
						{
							v256 MAGIC = new short16(166);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 100:  
						{
							v256 MAGIC = new short16(164);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 101:  
						{
							v256 MAGIC = new short16(163);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 102:  
						{
							v256 MAGIC = new short16(161);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 103:  
						{
							v256 MAGIC = new short16(160);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 104:  
						{
							v256 MAGIC = new short16(158);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 105:  
						{
							v256 MAGIC = new short16(157);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 106:  
						{
							v256 MAGIC = new short16(155);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 107:  
						{
							v256 MAGIC = new short16(154);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 108:  
						{
							v256 MAGIC = new short16(152);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 109:  
						{
							v256 MAGIC = new short16(151);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 110:  
						{
							v256 MAGIC = new short16(149);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 111:  
						{
							v256 MAGIC = new short16(148);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 112:  
						{
							v256 MAGIC = new short16(147);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 113:  
						{
							v256 MAGIC = new short16(145);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 114:  
						{
							v256 MAGIC = new short16(144);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 115:  
						{
							v256 MAGIC = new short16(143);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 116:  
						{
							v256 MAGIC = new short16(142);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 117:  
						{
							v256 MAGIC = new short16(141);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 118:  
						{
							v256 MAGIC = new short16(139);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 119:  
						{
							v256 MAGIC = new short16(138);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 120:  
						{
							v256 MAGIC = new short16(137);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 121:  
						{
							v256 MAGIC = new short16(136);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 122:  
						{
							v256 MAGIC = new short16(135);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 123:  
						{
							v256 MAGIC = new short16(134);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 124:  
						{
							v256 MAGIC = new short16(133);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 125:  
						{
							v256 MAGIC = new short16(132);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 126:  
						{
							v256 MAGIC = new short16(131);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
						case 127:  
						{
							v256 MAGIC = new short16(130);
							v256 cvtMask = Avx2.mm256_cmpgt_epi8(Avx.mm256_setzero_si256(), vector);

							v256 lo = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpacklo_epi8(vector, cvtMask), MAGIC);
							v256 hi = Avx2.mm256_mulhrs_epi16(Avx2.mm256_unpackhi_epi8(vector, cvtMask), MAGIC);

							return Avx2.mm256_packs_epi16(lo, hi);
						}
					}
				}

				return new v256((sbyte)(vector.SByte0 / divisor), (sbyte)(vector.SByte1 / divisor), (sbyte)(vector.SByte2 / divisor), (sbyte)(vector.SByte3 / divisor), (sbyte)(vector.SByte4 / divisor), (sbyte)(vector.SByte5 / divisor), (sbyte)(vector.SByte6 / divisor), (sbyte)(vector.SByte7 / divisor), (sbyte)(vector.SByte8 / divisor), (sbyte)(vector.SByte9 / divisor), (sbyte)(vector.SByte10 / divisor), (sbyte)(vector.SByte11 / divisor), (sbyte)(vector.SByte12 / divisor), (sbyte)(vector.SByte13 / divisor), (sbyte)(vector.SByte14 / divisor), (sbyte)(vector.SByte15 / divisor), (sbyte)(vector.SByte16 / divisor), (sbyte)(vector.SByte17 / divisor), (sbyte)(vector.SByte18 / divisor), (sbyte)(vector.SByte19 / divisor), (sbyte)(vector.SByte20 / divisor), (sbyte)(vector.SByte21 / divisor), (sbyte)(vector.SByte22 / divisor), (sbyte)(vector.SByte23 / divisor), (sbyte)(vector.SByte24 / divisor), (sbyte)(vector.SByte25 / divisor), (sbyte)(vector.SByte26 / divisor), (sbyte)(vector.SByte27 / divisor), (sbyte)(vector.SByte28 / divisor), (sbyte)(vector.SByte29 / divisor), (sbyte)(vector.SByte30 / divisor), (sbyte)(vector.SByte31 / divisor));
			}
		}
	}
}