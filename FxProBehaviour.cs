using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008D4 RID: 2260
[Token(Token = "0x20005E0")]
[Serializable]
public class FxProBehaviour : PlayableBehaviour
{
	// Token: 0x1700088E RID: 2190
	// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BA6 RID: 15270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D1")]
	public FxPro FxPro
	{
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x23F6700", Offset = "0x23F6801", VA = "0x23F6700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66C0", Offset = "0x1A67C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x23F6710", Offset = "0x23F6811", VA = "0x23F6710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66D0", Offset = "0x1A67D1")]
		set
		{
		}
	}

	// Token: 0x1700088F RID: 2191
	// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x00014DF0 File Offset: 0x00012FF0
	// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D2")]
	public bool IsChangeFocusTarget
	{
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x23F6720", Offset = "0x23F6821", VA = "0x23F6720")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66E0", Offset = "0x1A67E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x23F6730", Offset = "0x23F6831", VA = "0x23F6730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66F0", Offset = "0x1A67F1")]
		set
		{
		}
	}

	// Token: 0x17000890 RID: 2192
	// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BAA RID: 15274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D3")]
	public Transform FocusTargetStart
	{
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x23F6740", Offset = "0x23F6841", VA = "0x23F6740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6700", Offset = "0x1A6801")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x23F6750", Offset = "0x23F6851", VA = "0x23F6750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6710", Offset = "0x1A6811")]
		set
		{
		}
	}

	// Token: 0x17000891 RID: 2193
	// (get) Token: 0x06003BAB RID: 15275 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BAC RID: 15276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D4")]
	public Transform FocusTargetEnd
	{
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x23F6760", Offset = "0x23F6861", VA = "0x23F6760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6720", Offset = "0x1A6821")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x23F6770", Offset = "0x23F6871", VA = "0x23F6770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6730", Offset = "0x1A6831")]
		set
		{
		}
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003209")]
	[Address(RVA = "0x23F6780", Offset = "0x23F6881", VA = "0x23F6780", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600320A")]
	[Address(RVA = "0x23F67C0", Offset = "0x23F68C1", VA = "0x23F67C0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600320B")]
	[Address(RVA = "0x23F6800", Offset = "0x23F6901", VA = "0x23F6800")]
	public FxProBehaviour()
	{
	}

	// Token: 0x04007E52 RID: 32338
	[Token(Token = "0x4007207")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E9B0", Offset = "0x16EAB1")]
	private FxPro <FxPro>k__BackingField;

	// Token: 0x04007E53 RID: 32339
	[Token(Token = "0x4007208")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E9C0", Offset = "0x16EAC1")]
	private bool <IsChangeFocusTarget>k__BackingField;

	// Token: 0x04007E54 RID: 32340
	[Token(Token = "0x4007209")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E9D0", Offset = "0x16EAD1")]
	private Transform <FocusTargetStart>k__BackingField;

	// Token: 0x04007E55 RID: 32341
	[Token(Token = "0x400720A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E9E0", Offset = "0x16EAE1")]
	private Transform <FocusTargetEnd>k__BackingField;

	// Token: 0x04007E56 RID: 32342
	[Token(Token = "0x400720B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x16E9F0", Offset = "0x16EAF1")]
	public float FocalLengthMultiplierStart;

	// Token: 0x04007E57 RID: 32343
	[Token(Token = "0x400720C")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0x16EA10", Offset = "0x16EB11")]
	public float FocalLengthMultiplierEnd;

	// Token: 0x04007E58 RID: 32344
	[Token(Token = "0x400720D")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve FocalLengthMultiplierCurve;

	// Token: 0x04007E59 RID: 32345
	[Token(Token = "0x400720E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x16EA30", Offset = "0x16EB31")]
	public float DOFStrengthStart;

	// Token: 0x04007E5A RID: 32346
	[Token(Token = "0x400720F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0x16EA50", Offset = "0x16EB51")]
	public float DOFStrengthEnd;

	// Token: 0x04007E5B RID: 32347
	[Token(Token = "0x4007210")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve DOFStrengthCurve;
}
