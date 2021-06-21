using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UTJ
{
	// Token: 0x02000C14 RID: 3092
	[Token(Token = "0x20007F2")]
	public static class UnityComponentStringListBuilder
	{
		// Token: 0x06004EAA RID: 20138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004176")]
		[Address(RVA = "0x23B6AD0", Offset = "0x23B6BD1", VA = "0x23B6AD0")]
		public static void BuildBuilderStringList(object sourceObject, List<string> outputStrings, [Optional] IEnumerable<TypedStringToValueMap> valueMaps)
		{
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004177")]
		[Address(RVA = "0x23B28C0", Offset = "0x23B29C1", VA = "0x23B28C0")]
		public static IEnumerable<string> BuildBuilderStringList(object sourceObject, [Optional] IEnumerable<TypedStringToValueMap> valueMaps)
		{
			return null;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004178")]
		[Address(RVA = "0x23B75F0", Offset = "0x23B76F1", VA = "0x23B75F0")]
		public static IEnumerable<string> BuildBuilderStringList(object sourceObject, TypedStringToValueMap valueMap)
		{
			return null;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x23B6BD0", Offset = "0x23B6CD1", VA = "0x23B6BD0")]
		private static void ConvertFieldsToStrings(object sourceObject, Type type, IEnumerable<TypedStringToValueMap> valueMaps, List<string> outputStrings)
		{
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600417A")]
		[Address(RVA = "0x23B6CC0", Offset = "0x23B6DC1", VA = "0x23B6CC0")]
		private static void ConvertObjectToStrings(object sourceObject, Type type, IEnumerable<TypedStringToValueMap> valueMaps, List<string> outputStrings)
		{
		}

		// Token: 0x02000C15 RID: 3093
		[Token(Token = "0x200139D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595F0", Offset = "0x1596F1")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004EAF RID: 20143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007802")]
			[Address(RVA = "0x23B7700", Offset = "0x23B7801", VA = "0x23B7700")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004EB0 RID: 20144 RVA: 0x00019140 File Offset: 0x00017340
			[Token(Token = "0x6007803")]
			[Address(RVA = "0x23B7940", Offset = "0x23B7A41", VA = "0x23B7940")]
			internal bool <ConvertObjectToStrings>b__0(TypedStringToValueMap map)
			{
				return default(bool);
			}

			// Token: 0x0400AFBC RID: 44988
			[Token(Token = "0x401B7D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;
		}

		// Token: 0x02000C16 RID: 3094
		[Token(Token = "0x200139E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159600", Offset = "0x159701")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EB2 RID: 20146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007805")]
			[Address(RVA = "0x23B7780", Offset = "0x23B7881", VA = "0x23B7780")]
			public <>c()
			{
			}

			// Token: 0x06004EB3 RID: 20147 RVA: 0x00019158 File Offset: 0x00017358
			[Token(Token = "0x6007806")]
			[Address(RVA = "0x23B7790", Offset = "0x23B7891", VA = "0x23B7790")]
			internal bool <ConvertObjectToStrings>b__4_1(MethodInfo method)
			{
				return default(bool);
			}

			// Token: 0x06004EB4 RID: 20148 RVA: 0x00019170 File Offset: 0x00017370
			[Token(Token = "0x6007807")]
			[Address(RVA = "0x23B7800", Offset = "0x23B7901", VA = "0x23B7800")]
			internal bool <ConvertObjectToStrings>b__4_2(MethodInfo method)
			{
				return default(bool);
			}

			// Token: 0x0400AFBD RID: 44989
			[Token(Token = "0x401B7D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UnityComponentStringListBuilder.<>c <>9;

			// Token: 0x0400AFBE RID: 44990
			[Token(Token = "0x401B7D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__4_1;

			// Token: 0x0400AFBF RID: 44991
			[Token(Token = "0x401B7D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MethodInfo, bool> <>9__4_2;
		}
	}
}
