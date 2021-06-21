using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E23 RID: 3619
	[Token(Token = "0x2000945")]
	public static class ArrayTools
	{
		// Token: 0x06005E1D RID: 24093 RVA: 0x0001F278 File Offset: 0x0001D478
		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x22BC490", Offset = "0x22BC591", VA = "0x22BC490")]
		public static int Find(this Array array, object obj)
		{
			return 0;
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x0001F290 File Offset: 0x0001D490
		[Token(Token = "0x6004E2E")]
		public static int Find<T>(T[] array, T obj) where T : class
		{
			return 0;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E2F")]
		public static void RemoveAt<T>(ref T[] array, int num)
		{
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E30")]
		public static T[] RemoveAt<T>(T[] array, int num)
		{
			return null;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E31")]
		public static void Remove<T>(ref T[] array, T obj) where T : class
		{
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E32")]
		public static T[] Remove<T>(T[] array, T obj) where T : class
		{
			return null;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E33")]
		public static void Add<T>(ref T[] array, int after, [Optional] T element)
		{
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E34")]
		public static T[] Add<T>(T[] array, int after, [Optional] T element)
		{
			return null;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E35")]
		public static T[] Add<T>(T[] array, [Optional] T element)
		{
			return null;
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E36")]
		public static void Add<T>(ref T[] array, [Optional] T element)
		{
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E37")]
		public static void Resize<T>(ref T[] array, int newSize, [Optional] T element)
		{
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E38")]
		public static T[] Resize<T>(T[] array, int newSize, [Optional] T element)
		{
			return null;
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E39")]
		public static void Append<T>(ref T[] array, T[] additional)
		{
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3A")]
		public static T[] Append<T>(T[] array, T[] additional)
		{
			return null;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3B")]
		public static void Switch<T>(T[] array, int num1, int num2)
		{
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3C")]
		public static void Switch<T>(T[] array, T obj1, T obj2) where T : class
		{
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x22BC520", Offset = "0x22BC621", VA = "0x22BC520")]
		public static void QSort(float[] array)
		{
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x22BC540", Offset = "0x22BC641", VA = "0x22BC540")]
		public static void QSort(float[] array, int l, int r)
		{
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3F")]
		public static void QSort<T>(T[] array, float[] reference)
		{
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E40")]
		public static void QSort<T>(T[] array, float[] reference, int l, int r)
		{
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E41")]
		public static void QSort<T>(List<T> list, float[] reference)
		{
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E42")]
		public static void QSort<T>(List<T> list, float[] reference, int l, int r)
		{
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x22BC660", Offset = "0x22BC761", VA = "0x22BC660")]
		public static int[] Order(int[] array, [Optional] int[] order, int max = 0, int steps = 1000000, [Optional] int[] stepsArray)
		{
			return null;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E44")]
		public static T[] Convert<T, Y>(Y[] src)
		{
			return null;
		}
	}
}
