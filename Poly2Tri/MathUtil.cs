using System;
using Il2CppDummyDll;

namespace Poly2Tri
{
	// Token: 0x02000C81 RID: 3201
	[Token(Token = "0x200082E")]
	public class MathUtil
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[Token(Token = "0x600441B")]
		[Address(RVA = "0x27EFAF0", Offset = "0x27EFBF1", VA = "0x27EFAF0")]
		public static bool AreValuesEqual(double val1, double val2)
		{
			return default(bool);
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		[Token(Token = "0x600441C")]
		[Address(RVA = "0x27EFB90", Offset = "0x27EFC91", VA = "0x27EFB90")]
		public static bool AreValuesEqual(double val1, double val2, double tolerance)
		{
			return default(bool);
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x27EFBB0", Offset = "0x27EFCB1", VA = "0x27EFBB0")]
		public static bool IsValueBetween(double val, double min, double max, double tolerance)
		{
			return default(bool);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x0001AA00 File Offset: 0x00018C00
		[Token(Token = "0x600441E")]
		[Address(RVA = "0x27EFBF0", Offset = "0x27EFCF1", VA = "0x27EFBF0")]
		public static double RoundWithPrecision(double f, double precision)
		{
			return 0.0;
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x0001AA18 File Offset: 0x00018C18
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x27EFC90", Offset = "0x27EFD91", VA = "0x27EFC90")]
		public static double Clamp(double a, double low, double high)
		{
			return 0.0;
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004420")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x0001AA30 File Offset: 0x00018C30
		[Token(Token = "0x6004421")]
		[Address(RVA = "0x27EFD30", Offset = "0x27EFE31", VA = "0x27EFD30")]
		public static uint Jenkins32Hash(byte[] data, uint nInitialValue)
		{
			return 0U;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004422")]
		[Address(RVA = "0x27EFDA0", Offset = "0x27EFEA1", VA = "0x27EFDA0")]
		public MathUtil()
		{
		}

		// Token: 0x0400B156 RID: 45398
		[Token(Token = "0x4008500")]
		[FieldOffset(Offset = "0x0")]
		public static double EPSILON;
	}
}
