using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000DFD RID: 3581
	[Token(Token = "0x2000925")]
	[Serializable]
	public abstract class BaseShaderDefinition : IProfileDefinition
	{
		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000927")]
		public string shaderName
		{
			[Token(Token = "0x6004C25")]
			[Address(RVA = "0x23D3460", Offset = "0x23D3561", VA = "0x23D3460", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD40", Offset = "0x1ABE41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C26")]
			[Address(RVA = "0x23D3470", Offset = "0x23D3571", VA = "0x23D3470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ABD50", Offset = "0x1ABE51")]
			protected set
			{
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000928")]
		public ProfileGroupSection[] groups
		{
			[Token(Token = "0x6004C27")]
			[Address(RVA = "0x23D3480", Offset = "0x23D3581", VA = "0x23D3480", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06005C0D RID: 23565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000929")]
		public ProfileFeatureSection[] features
		{
			[Token(Token = "0x6004C28")]
			[Address(RVA = "0x23D34E0", Offset = "0x23D35E1", VA = "0x23D34E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x23D3540", Offset = "0x23D3641", VA = "0x23D3540", Slot = "7")]
		public ProfileFeatureDefinition GetFeatureDefinition(string featureKey)
		{
			return null;
		}

		// Token: 0x06005C0F RID: 23567
		[Token(Token = "0x6004C2A")]
		protected abstract ProfileFeatureSection[] ProfileFeatureSection();

		// Token: 0x06005C10 RID: 23568
		[Token(Token = "0x6004C2B")]
		protected abstract ProfileGroupSection[] ProfileDefinitionTable();

		// Token: 0x06005C11 RID: 23569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x23D3780", Offset = "0x23D3881", VA = "0x23D3780")]
		protected BaseShaderDefinition()
		{
		}

		// Token: 0x0400BC6B RID: 48235
		[Token(Token = "0x4008CD8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17D140", Offset = "0x17D241")]
		private string <shaderName>k__BackingField;

		// Token: 0x0400BC6C RID: 48236
		[Token(Token = "0x4008CD9")]
		[FieldOffset(Offset = "0x18")]
		private ProfileGroupSection[] m_ProfileDefinitions;

		// Token: 0x0400BC6D RID: 48237
		[Token(Token = "0x4008CDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProfileFeatureSection[] m_ProfileFeatures;

		// Token: 0x0400BC6E RID: 48238
		[Token(Token = "0x4008CDB")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, ProfileFeatureDefinition> m_KeyToFeature;
	}
}
