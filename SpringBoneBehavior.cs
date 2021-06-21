using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UTJ;

// Token: 0x020008E7 RID: 2279
[Token(Token = "0x20005F3")]
public class SpringBoneBehavior : PlayableBehaviour
{
	// Token: 0x170008A9 RID: 2217
	// (get) Token: 0x06003C06 RID: 15366 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C07 RID: 15367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006EC")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x2386350", Offset = "0x2386451", VA = "0x2386350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6960", Offset = "0x1A6A61")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x2386360", Offset = "0x2386461", VA = "0x2386360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6970", Offset = "0x1A6A71")]
		set
		{
		}
	}

	// Token: 0x170008AA RID: 2218
	// (get) Token: 0x06003C08 RID: 15368 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006ED")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6003264")]
		[Address(RVA = "0x2386370", Offset = "0x2386471", VA = "0x2386370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6980", Offset = "0x1A6A81")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003265")]
		[Address(RVA = "0x2386380", Offset = "0x2386481", VA = "0x2386380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6990", Offset = "0x1A6A91")]
		set
		{
		}
	}

	// Token: 0x170008AB RID: 2219
	// (get) Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006EE")]
	public SpringManager SpringManager
	{
		[Token(Token = "0x6003266")]
		[Address(RVA = "0x2386390", Offset = "0x2386491", VA = "0x2386390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69A0", Offset = "0x1A6AA1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x23863A0", Offset = "0x23864A1", VA = "0x23863A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69B0", Offset = "0x1A6AB1")]
		set
		{
		}
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003268")]
	[Address(RVA = "0x23863B0", Offset = "0x23864B1", VA = "0x23863B0")]
	public void Initialize(GameObject bindTarget, bool start, bool end)
	{
	}

	// Token: 0x06003C0D RID: 15373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003269")]
	[Address(RVA = "0x2386400", Offset = "0x2386501", VA = "0x2386400", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600326A")]
	[Address(RVA = "0x2386550", Offset = "0x2386651", VA = "0x2386550", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C0F RID: 15375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600326B")]
	[Address(RVA = "0x2386630", Offset = "0x2386731", VA = "0x2386630", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C10 RID: 15376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600326C")]
	[Address(RVA = "0x2386710", Offset = "0x2386811", VA = "0x2386710")]
	public SpringBoneBehavior()
	{
	}

	// Token: 0x04007E8C RID: 32396
	[Token(Token = "0x4007241")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EC80", Offset = "0x16ED81")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E8D RID: 32397
	[Token(Token = "0x4007242")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EC90", Offset = "0x16ED91")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04007E8E RID: 32398
	[Token(Token = "0x4007243")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ECA0", Offset = "0x16EDA1")]
	private SpringManager <SpringManager>k__BackingField;

	// Token: 0x04007E8F RID: 32399
	[Token(Token = "0x4007244")]
	[FieldOffset(Offset = "0x28")]
	private bool StartEnable;

	// Token: 0x04007E90 RID: 32400
	[Token(Token = "0x4007245")]
	[FieldOffset(Offset = "0x29")]
	private bool EndEnable;
}
