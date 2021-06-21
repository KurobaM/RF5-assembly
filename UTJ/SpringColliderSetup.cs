using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BFF RID: 3071
	[Token(Token = "0x20007E7")]
	public static class SpringColliderSetup
	{
		// Token: 0x06004E2C RID: 20012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x23B0610", Offset = "0x23B0711", VA = "0x23B0610")]
		public static IEnumerable<Type> GetColliderTypes()
		{
			return null;
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x23AFEE0", Offset = "0x23AFFE1", VA = "0x23AFEE0")]
		public static void DestroySpringColliders(GameObject colliderRoot)
		{
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004125")]
		private static void DestroyComponentsOfType<T>(GameObject rootObject) where T : Component
		{
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004126")]
		[Address(RVA = "0x23B0790", Offset = "0x23B0891", VA = "0x23B0790")]
		private static void DestroyUnityObject(UnityEngine.Object objectToDestroy)
		{
		}

		// Token: 0x02000C00 RID: 3072
		[Token(Token = "0x2001393")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159570", Offset = "0x159671")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E31 RID: 20017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077D8")]
			[Address(RVA = "0x23B0870", Offset = "0x23B0971", VA = "0x23B0870")]
			public <>c()
			{
			}

			// Token: 0x06004E32 RID: 20018 RVA: 0x00018ED0 File Offset: 0x000170D0
			[Token(Token = "0x60077D9")]
			[Address(RVA = "0x23B0880", Offset = "0x23B0981", VA = "0x23B0880")]
			internal bool <DestroySpringColliders>b__1_0(SpringSphereCollider collider)
			{
				return default(bool);
			}

			// Token: 0x06004E33 RID: 20019 RVA: 0x00018EE8 File Offset: 0x000170E8
			[Token(Token = "0x60077DA")]
			[Address(RVA = "0x23B08F0", Offset = "0x23B09F1", VA = "0x23B08F0")]
			internal bool <DestroySpringColliders>b__1_1(SpringCapsuleCollider collider)
			{
				return default(bool);
			}

			// Token: 0x06004E34 RID: 20020 RVA: 0x00018F00 File Offset: 0x00017100
			[Token(Token = "0x60077DB")]
			[Address(RVA = "0x23B0960", Offset = "0x23B0A61", VA = "0x23B0960")]
			internal bool <DestroySpringColliders>b__1_2(SpringPanelCollider collider)
			{
				return default(bool);
			}

			// Token: 0x0400AF6E RID: 44910
			[Token(Token = "0x401B7B6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpringColliderSetup.<>c <>9;

			// Token: 0x0400AF6F RID: 44911
			[Token(Token = "0x401B7B7")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpringSphereCollider, bool> <>9__1_0;

			// Token: 0x0400AF70 RID: 44912
			[Token(Token = "0x401B7B8")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpringCapsuleCollider, bool> <>9__1_1;

			// Token: 0x0400AF71 RID: 44913
			[Token(Token = "0x401B7B9")]
			[FieldOffset(Offset = "0x18")]
			public static Func<SpringPanelCollider, bool> <>9__1_2;
		}
	}
}
