using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FxProNS
{
	// Token: 0x020015F4 RID: 5620
	[Token(Token = "0x2000F77")]
	[Serializable]
	public class DOFHelperParams
	{
		// Token: 0x0600801C RID: 32796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A5A")]
		[Address(RVA = "0x23F6690", Offset = "0x23F6791", VA = "0x23F6690")]
		public DOFHelperParams()
		{
		}

		// Token: 0x0401C18D RID: 115085
		[Token(Token = "0x40189BE")]
		[FieldOffset(Offset = "0x10")]
		public bool UseUnityDepthBuffer;

		// Token: 0x0401C18E RID: 115086
		[Token(Token = "0x40189BF")]
		[FieldOffset(Offset = "0x11")]
		public bool AutoFocus;

		// Token: 0x0401C18F RID: 115087
		[Token(Token = "0x40189C0")]
		[FieldOffset(Offset = "0x14")]
		public LayerMask AutoFocusLayerMask;

		// Token: 0x0401C190 RID: 115088
		[Token(Token = "0x40189C1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194B70", Offset = "0x194C71")]
		public float AutoFocusSpeed;

		// Token: 0x0401C191 RID: 115089
		[Token(Token = "0x40189C2")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194B90", Offset = "0x194C91")]
		public float FocalLengthMultiplier;

		// Token: 0x0401C192 RID: 115090
		[Token(Token = "0x40189C3")]
		[FieldOffset(Offset = "0x20")]
		public float FocalDistMultiplier;

		// Token: 0x0401C193 RID: 115091
		[Token(Token = "0x40189C4")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194BB0", Offset = "0x194CB1")]
		public float DOFBlurSize;

		// Token: 0x0401C194 RID: 115092
		[Token(Token = "0x40189C5")]
		[FieldOffset(Offset = "0x28")]
		public bool BokehEnabled;

		// Token: 0x0401C195 RID: 115093
		[Token(Token = "0x40189C6")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194BD0", Offset = "0x194CD1")]
		public float DepthCompression;

		// Token: 0x0401C196 RID: 115094
		[Token(Token = "0x40189C7")]
		[FieldOffset(Offset = "0x30")]
		public Camera EffectCamera;

		// Token: 0x0401C197 RID: 115095
		[Token(Token = "0x40189C8")]
		[FieldOffset(Offset = "0x38")]
		public Transform Target;

		// Token: 0x0401C198 RID: 115096
		[Token(Token = "0x40189C9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194BF0", Offset = "0x194CF1")]
		public float BokehThreshold;

		// Token: 0x0401C199 RID: 115097
		[Token(Token = "0x40189CA")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194C10", Offset = "0x194D11")]
		public float BokehGain;

		// Token: 0x0401C19A RID: 115098
		[Token(Token = "0x40189CB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x194C30", Offset = "0x194D31")]
		public float BokehBias;

		// Token: 0x0401C19B RID: 115099
		[Token(Token = "0x40189CC")]
		[FieldOffset(Offset = "0x4C")]
		public bool DoubleIntensityBlur;
	}
}
