using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000C01 RID: 3073
	[Token(Token = "0x20007E8")]
	public class SpringSetupComponentDefiners
	{
		// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004127")]
		[Address(RVA = "0x23ABEB0", Offset = "0x23ABFB1", VA = "0x23ABEB0")]
		public static IEnumerable<SpringSetupComponentDefiners.ComponentDefiner> GetComponentDefiners()
		{
			return null;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004128")]
		[Address(RVA = "0x23B2700", Offset = "0x23B2801", VA = "0x23B2700")]
		public SpringSetupComponentDefiners()
		{
		}

		// Token: 0x02000C02 RID: 3074
		[Token(Token = "0x2001394")]
		public class ComponentDefiner
		{
			// Token: 0x06004E37 RID: 20023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077DC")]
			[Address(RVA = "0x23B26C0", Offset = "0x23B27C1", VA = "0x23B26C0")]
			public ComponentDefiner(Type newType)
			{
			}

			// Token: 0x06004E38 RID: 20024 RVA: 0x00018F18 File Offset: 0x00017118
			[Token(Token = "0x60077DD")]
			[Address(RVA = "0x23ABFD0", Offset = "0x23AC0D1", VA = "0x23ABFD0")]
			public bool TryToAppendDefinition(StringBuilder builder, GameObject rootObject)
			{
				return default(bool);
			}

			// Token: 0x06004E39 RID: 20025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077DE")]
			[Address(RVA = "0x23B2710", Offset = "0x23B2811", VA = "0x23B2710")]
			public void AppendDefinition(StringBuilder builder, Component component)
			{
			}

			// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077DF")]
			[Address(RVA = "0x23AEC60", Offset = "0x23AED61", VA = "0x23AEC60")]
			public Component BuildFromDefinition(GameObject owner, Queue<string> definitionItems)
			{
				return null;
			}

			// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077E0")]
			[Address(RVA = "0x23B27A0", Offset = "0x23B28A1", VA = "0x23B27A0", Slot = "4")]
			protected virtual string GetTypeToken()
			{
				return null;
			}

			// Token: 0x06004E3C RID: 20028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077E1")]
			[Address(RVA = "0x23B27C0", Offset = "0x23B28C1", VA = "0x23B27C0", Slot = "5")]
			protected virtual void AppendProperties(StringBuilder builder, Component component)
			{
			}

			// Token: 0x06004E3D RID: 20029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077E2")]
			protected static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = ',')
			{
			}

			// Token: 0x06004E3E RID: 20030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077E3")]
			[Address(RVA = "0x23B2950", Offset = "0x23B2A51", VA = "0x23B2950")]
			protected static string GetComponentName(Component component)
			{
				return null;
			}

			// Token: 0x06004E3F RID: 20031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077E4")]
			[Address(RVA = "0x23B29F0", Offset = "0x23B2AF1", VA = "0x23B29F0", Slot = "6")]
			protected virtual Component InternalBuildFromDefinition(GameObject owner, Queue<string> definitionItems)
			{
				return null;
			}

			// Token: 0x0400AF72 RID: 44914
			[Token(Token = "0x401B7BA")]
			[FieldOffset(Offset = "0x10")]
			protected Type componentType;
		}
	}
}
