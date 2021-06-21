using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DF1 RID: 3569
	[Token(Token = "0x200091A")]
	[Serializable]
	public class ProfileFeatureDefinition
	{
		// Token: 0x06005BFB RID: 23547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x23D9FE0", Offset = "0x23DA0E1", VA = "0x23D9FE0")]
		public static ProfileFeatureDefinition CreateShaderFeature(string featureKey, string shaderKeyword, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x23DA0F0", Offset = "0x23DA1F1", VA = "0x23DA0F0")]
		public static ProfileFeatureDefinition CreateShaderFeatureDropdown(string[] featureKeys, string[] shaderKeywords, string[] labels, int selectedIndex, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x23DA210", Offset = "0x23DA311", VA = "0x23DA210")]
		public static ProfileFeatureDefinition CreateBooleanFeature(string featureKey, bool value, string name, string dependsOnFeature, bool dependsOnValue, string tooltip)
		{
			return null;
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x23DA0E0", Offset = "0x23DA1E1", VA = "0x23DA0E0")]
		public ProfileFeatureDefinition()
		{
		}

		// Token: 0x0400BB8A RID: 48010
		[Token(Token = "0x4008BFB")]
		[FieldOffset(Offset = "0x10")]
		public string featureKey;

		// Token: 0x0400BB8B RID: 48011
		[Token(Token = "0x4008BFC")]
		[FieldOffset(Offset = "0x18")]
		public string[] featureKeys;

		// Token: 0x0400BB8C RID: 48012
		[Token(Token = "0x4008BFD")]
		[FieldOffset(Offset = "0x20")]
		public ProfileFeatureDefinition.FeatureType featureType;

		// Token: 0x0400BB8D RID: 48013
		[Token(Token = "0x4008BFE")]
		[FieldOffset(Offset = "0x28")]
		public string shaderKeyword;

		// Token: 0x0400BB8E RID: 48014
		[Token(Token = "0x4008BFF")]
		[FieldOffset(Offset = "0x30")]
		public string[] shaderKeywords;

		// Token: 0x0400BB8F RID: 48015
		[Token(Token = "0x4008C00")]
		[FieldOffset(Offset = "0x38")]
		public string[] dropdownLabels;

		// Token: 0x0400BB90 RID: 48016
		[Token(Token = "0x4008C01")]
		[FieldOffset(Offset = "0x40")]
		public int dropdownSelectedIndex;

		// Token: 0x0400BB91 RID: 48017
		[Token(Token = "0x4008C02")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x0400BB92 RID: 48018
		[Token(Token = "0x4008C03")]
		[FieldOffset(Offset = "0x50")]
		public bool value;

		// Token: 0x0400BB93 RID: 48019
		[Token(Token = "0x4008C04")]
		[FieldOffset(Offset = "0x58")]
		public string tooltip;

		// Token: 0x0400BB94 RID: 48020
		[Token(Token = "0x4008C05")]
		[FieldOffset(Offset = "0x60")]
		public string dependsOnFeature;

		// Token: 0x0400BB95 RID: 48021
		[Token(Token = "0x4008C06")]
		[FieldOffset(Offset = "0x68")]
		public bool dependsOnValue;

		// Token: 0x0400BB96 RID: 48022
		[Token(Token = "0x4008C07")]
		[FieldOffset(Offset = "0x69")]
		public bool isShaderKeywordFeature;

		// Token: 0x02000DF2 RID: 3570
		[Token(Token = "0x2001444")]
		public enum FeatureType
		{
			// Token: 0x0400BB98 RID: 48024
			[Token(Token = "0x401BBA7")]
			ShaderKeyword,
			// Token: 0x0400BB99 RID: 48025
			[Token(Token = "0x401BBA8")]
			BooleanValue,
			// Token: 0x0400BB9A RID: 48026
			[Token(Token = "0x401BBA9")]
			ShaderKeywordDropdown
		}
	}
}
