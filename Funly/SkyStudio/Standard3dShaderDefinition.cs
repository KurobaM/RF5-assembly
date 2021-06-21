using System;
using Il2CppDummyDll;

namespace Funly.SkyStudio
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000927")]
	public class Standard3dShaderDefinition : BaseShaderDefinition
	{
		// Token: 0x06005C16 RID: 23574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x23E46D0", Offset = "0x23E47D1", VA = "0x23E46D0")]
		public Standard3dShaderDefinition()
		{
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x23E4730", Offset = "0x23E4831", VA = "0x23E4730", Slot = "8")]
		protected override ProfileFeatureSection[] ProfileFeatureSection()
		{
			return null;
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x23E6230", Offset = "0x23E6331", VA = "0x23E6230", Slot = "9")]
		protected override ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		// Token: 0x0400BC6F RID: 48239
		[Token(Token = "0x4008CDC")]
		public const float MaxStarSize = 0.2f;

		// Token: 0x0400BC70 RID: 48240
		[Token(Token = "0x4008CDD")]
		public const float MaxStarDensity = 1f;

		// Token: 0x0400BC71 RID: 48241
		[Token(Token = "0x4008CDE")]
		public const float MinEdgeFeathering = 0.0001f;

		// Token: 0x0400BC72 RID: 48242
		[Token(Token = "0x4008CDF")]
		public const float MinStarFadeBegin = -0.999f;

		// Token: 0x0400BC73 RID: 48243
		[Token(Token = "0x4008CE0")]
		public const float MaxSpriteItems = 100000f;

		// Token: 0x0400BC74 RID: 48244
		[Token(Token = "0x4008CE1")]
		public const float MinRotationSpeed = -10f;

		// Token: 0x0400BC75 RID: 48245
		[Token(Token = "0x4008CE2")]
		public const float MaxRotationSpeed = 10f;

		// Token: 0x0400BC76 RID: 48246
		[Token(Token = "0x4008CE3")]
		public const float MaxCloudRotationSpeed = 0.5f;

		// Token: 0x0400BC77 RID: 48247
		[Token(Token = "0x4008CE4")]
		public const float MaxHDRValue = 25f;
	}
}
