using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FxProNS
{
	// Token: 0x020015F2 RID: 5618
	[Token(Token = "0x2000F75")]
	[Serializable]
	public class BloomHelperParams
	{
		// Token: 0x06008012 RID: 32786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0x23F6630", Offset = "0x23F6731", VA = "0x23F6630")]
		public BloomHelperParams()
		{
		}

		// Token: 0x0401C184 RID: 115076
		[Token(Token = "0x40189B5")]
		[FieldOffset(Offset = "0x10")]
		public EffectsQuality Quality;

		// Token: 0x0401C185 RID: 115077
		[Token(Token = "0x40189B6")]
		[FieldOffset(Offset = "0x14")]
		public Color BloomTint;

		// Token: 0x0401C186 RID: 115078
		[Token(Token = "0x40189B7")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194B10", Offset = "0x194C11")]
		public float BloomThreshold;

		// Token: 0x0401C187 RID: 115079
		[Token(Token = "0x40189B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194B30", Offset = "0x194C31")]
		public float BloomIntensity;

		// Token: 0x0401C188 RID: 115080
		[Token(Token = "0x40189B9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194B50", Offset = "0x194C51")]
		public float BloomSoftness;
	}
}
