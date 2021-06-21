using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ.StringQueueExtensions
{
	// Token: 0x02000C1E RID: 3102
	[Token(Token = "0x20007F6")]
	public static class ObjectBuilder
	{
		// Token: 0x06004EDE RID: 20190 RVA: 0x000192D8 File Offset: 0x000174D8
		[Token(Token = "0x6004193")]
		[Address(RVA = "0x23B31E0", Offset = "0x23B32E1", VA = "0x23B31E0")]
		public static float DequeueFloat(this Queue<string> queue)
		{
			return 0f;
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x000192F0 File Offset: 0x000174F0
		[Token(Token = "0x6004194")]
		[Address(RVA = "0x23B3240", Offset = "0x23B3341", VA = "0x23B3240")]
		public static int DequeueInt(this Queue<string> queue)
		{
			return 0;
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x00019308 File Offset: 0x00017508
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x23B32A0", Offset = "0x23B33A1", VA = "0x23B32A0")]
		public static Vector3 DequeueVector3(this Queue<string> queue)
		{
			return default(Vector3);
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x23B3370", Offset = "0x23B3471", VA = "0x23B3370")]
		public static Transform DequeueTransform(this Queue<string> queue, GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x00019320 File Offset: 0x00017520
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x23B2B60", Offset = "0x23B2C61", VA = "0x23B2B60")]
		public static bool DequeueComponent(this Queue<string> queue, Component component, [Optional] GameObject rootObject, [Optional] IEnumerable<TypedStringToValueMap> valueMaps)
		{
			return default(bool);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004198")]
		[Address(RVA = "0x23B36E0", Offset = "0x23B37E1", VA = "0x23B36E0")]
		public static void DequeueFields(this Queue<string> queue, Type classType, object item, [Optional] GameObject rootObject, [Optional] IEnumerable<TypedStringToValueMap> valueMaps)
		{
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004199")]
		public static void DequeueFields<T>(this Queue<string> queue, T item, [Optional] string firstOptionalField) where T : class
		{
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600419A")]
		[Address(RVA = "0x23B3C20", Offset = "0x23B3D21", VA = "0x23B3C20")]
		public static void DequeueFields(this Queue<string> queue, Type classType, object item, [Optional] string firstOptionalField)
		{
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419B")]
		public static T DequeueObject<T>(this Queue<string> queue, [Optional] string firstOptionalField) where T : class, new()
		{
			return null;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419C")]
		[Address(RVA = "0x23B3D80", Offset = "0x23B3E81", VA = "0x23B3D80")]
		public static object DequeueObject(this Queue<string> queue, Type type, [Optional] string firstOptionalField)
		{
			return null;
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419D")]
		[Address(RVA = "0x23B3DE0", Offset = "0x23B3EE1", VA = "0x23B3DE0")]
		private static object ParsePrimitiveType(Type type, string valueSource)
		{
			return null;
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419E")]
		[Address(RVA = "0x23B4020", Offset = "0x23B4121", VA = "0x23B4020")]
		private static object ParseEnum(Type type, string valueSource)
		{
			return null;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600419F")]
		[Address(RVA = "0x23B37D0", Offset = "0x23B38D1", VA = "0x23B37D0")]
		private static object GetValueByType(this Queue<string> queue, Type type, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps)
		{
			return null;
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A0")]
		[Address(RVA = "0x23B4800", Offset = "0x23B4901", VA = "0x23B4800")]
		private static Array BuildArray(this Queue<string> queue, Type elementType, GameObject rootObject, IEnumerable<TypedStringToValueMap> valueMaps)
		{
			return null;
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041A1")]
		[Address(RVA = "0x23B4480", Offset = "0x23B4581", VA = "0x23B4480")]
		private static Component FindComponent(Type type, GameObject root, string objectName)
		{
			return null;
		}

		// Token: 0x02000C1F RID: 3103
		[Token(Token = "0x20013A3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159640", Offset = "0x159741")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004EED RID: 20205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007819")]
			[Address(RVA = "0x23B36C0", Offset = "0x23B37C1", VA = "0x23B36C0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0400AFC7 RID: 44999
			[Token(Token = "0x401B7DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string parentName;
		}

		// Token: 0x02000C20 RID: 3104
		[Token(Token = "0x20013A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159650", Offset = "0x159751")]
		private sealed class <>c__DisplayClass3_1
		{
			// Token: 0x06004EEE RID: 20206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600781A")]
			[Address(RVA = "0x23B36D0", Offset = "0x23B37D1", VA = "0x23B36D0")]
			public <>c__DisplayClass3_1()
			{
			}

			// Token: 0x06004EEF RID: 20207 RVA: 0x00019338 File Offset: 0x00017538
			[Token(Token = "0x600781B")]
			[Address(RVA = "0x23B4C40", Offset = "0x23B4D41", VA = "0x23B4C40")]
			internal bool <DequeueTransform>b__0(Transform item)
			{
				return default(bool);
			}

			// Token: 0x0400AFC8 RID: 45000
			[Token(Token = "0x401B7E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform[] children;

			// Token: 0x0400AFC9 RID: 45001
			[Token(Token = "0x401B7E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ObjectBuilder.<>c__DisplayClass3_0 CS$<>8__locals1;
		}

		// Token: 0x02000C21 RID: 3105
		[Token(Token = "0x20013A5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159660", Offset = "0x159761")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EF1 RID: 20209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600781D")]
			[Address(RVA = "0x23B4980", Offset = "0x23B4A81", VA = "0x23B4980")]
			public <>c()
			{
			}

			// Token: 0x06004EF2 RID: 20210 RVA: 0x00019350 File Offset: 0x00017550
			[Token(Token = "0x600781E")]
			[Address(RVA = "0x23B4990", Offset = "0x23B4A91", VA = "0x23B4990")]
			internal bool <ParsePrimitiveType>b__10_0(MethodInfo method)
			{
				return default(bool);
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600781F")]
			[Address(RVA = "0x23B4A60", Offset = "0x23B4B61", VA = "0x23B4A60")]
			internal Component <FindComponent>b__14_0(UnityEngine.Object item)
			{
				return null;
			}

			// Token: 0x06004EF4 RID: 20212 RVA: 0x00019368 File Offset: 0x00017568
			[Token(Token = "0x6007820")]
			[Address(RVA = "0x23B4B00", Offset = "0x23B4C01", VA = "0x23B4B00")]
			internal bool <FindComponent>b__14_1(Component item)
			{
				return default(bool);
			}

			// Token: 0x0400AFCA RID: 45002
			[Token(Token = "0x401B7E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ObjectBuilder.<>c <>9;

			// Token: 0x0400AFCB RID: 45003
			[Token(Token = "0x401B7E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<MethodInfo, bool> <>9__10_0;

			// Token: 0x0400AFCC RID: 45004
			[Token(Token = "0x401B7E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, Component> <>9__14_0;

			// Token: 0x0400AFCD RID: 45005
			[Token(Token = "0x401B7E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Component, bool> <>9__14_1;
		}

		// Token: 0x02000C22 RID: 3106
		[Token(Token = "0x20013A6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159670", Offset = "0x159771")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004EF5 RID: 20213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007821")]
			[Address(RVA = "0x23B43A0", Offset = "0x23B44A1", VA = "0x23B43A0")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06004EF6 RID: 20214 RVA: 0x00019380 File Offset: 0x00017580
			[Token(Token = "0x6007822")]
			[Address(RVA = "0x23B4B70", Offset = "0x23B4C71", VA = "0x23B4B70")]
			internal bool <GetValueByType>b__0(TypedStringToValueMap map)
			{
				return default(bool);
			}

			// Token: 0x0400AFCE RID: 45006
			[Token(Token = "0x401B7E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type type;
		}

		// Token: 0x02000C23 RID: 3107
		[Token(Token = "0x20013A7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159680", Offset = "0x159781")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x06004EF7 RID: 20215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007823")]
			[Address(RVA = "0x23B4900", Offset = "0x23B4A01", VA = "0x23B4900")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x06004EF8 RID: 20216 RVA: 0x00019398 File Offset: 0x00017598
			[Token(Token = "0x6007824")]
			[Address(RVA = "0x23B4C00", Offset = "0x23B4D01", VA = "0x23B4C00")]
			internal bool <FindComponent>b__2(Component child)
			{
				return default(bool);
			}

			// Token: 0x0400AFCF RID: 45007
			[Token(Token = "0x401B7E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string objectName;
		}
	}
}
