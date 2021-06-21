using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002D4 RID: 724
[Token(Token = "0x2000235")]
public class YawnController : MonoBehaviour
{
	// Token: 0x1700036F RID: 879
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x00008A90 File Offset: 0x00006C90
	// (set) Token: 0x06001350 RID: 4944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033B")]
	public float Elapsed
	{
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x284E8B0", Offset = "0x284E9B1", VA = "0x284E8B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA80", Offset = "0x19CB81")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x284E8C0", Offset = "0x284E9C1", VA = "0x284E8C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA90", Offset = "0x19CB91")]
		protected set
		{
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x00008AA8 File Offset: 0x00006CA8
	// (set) Token: 0x06001352 RID: 4946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033C")]
	public float Duration
	{
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x284E8D0", Offset = "0x284E9D1", VA = "0x284E8D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAA0", Offset = "0x19CBA1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x284E8E0", Offset = "0x284E9E1", VA = "0x284E8E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAB0", Offset = "0x19CBB1")]
		protected set
		{
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06001353 RID: 4947 RVA: 0x00008AC0 File Offset: 0x00006CC0
	// (set) Token: 0x06001354 RID: 4948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700033D")]
	public bool IsPlaying
	{
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x284E8F0", Offset = "0x284E9F1", VA = "0x284E8F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAC0", Offset = "0x19CBC1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x284E900", Offset = "0x284EA01", VA = "0x284E900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CAD0", Offset = "0x19CBD1")]
		protected set
		{
		}
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x00008AD8 File Offset: 0x00006CD8
	[Token(Token = "0x6001198")]
	[Address(RVA = "0x284E910", Offset = "0x284EA11", VA = "0x284E910", Slot = "4")]
	public virtual bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x00008AF0 File Offset: 0x00006CF0
	[Token(Token = "0x6001199")]
	[Address(RVA = "0x284E920", Offset = "0x284EA21", VA = "0x284E920", Slot = "5")]
	public virtual bool DoPlay(float duration)
	{
		return default(bool);
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x00008B08 File Offset: 0x00006D08
	[Token(Token = "0x600119A")]
	[Address(RVA = "0x284E980", Offset = "0x284EA81", VA = "0x284E980", Slot = "6")]
	public virtual bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119B")]
	[Address(RVA = "0x284E990", Offset = "0x284EA91", VA = "0x284E990", Slot = "7")]
	public virtual void DoCancel()
	{
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0x284E9A0", Offset = "0x284EAA1", VA = "0x284E9A0", Slot = "8")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0x284EA10", Offset = "0x284EB11", VA = "0x284EA10")]
	public YawnController()
	{
	}

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F3F0", Offset = "0x15F4F1")]
	private float <Elapsed>k__BackingField;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F400", Offset = "0x15F501")]
	private float <Duration>k__BackingField;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F410", Offset = "0x15F511")]
	private bool <IsPlaying>k__BackingField;
}
