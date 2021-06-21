using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008E9 RID: 2281
[Token(Token = "0x20005F5")]
public class SpringBoneInitBehavior : PlayableBehaviour
{
	// Token: 0x170008AE RID: 2222
	// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C17 RID: 15383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F1")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003272")]
		[Address(RVA = "0x2386900", Offset = "0x2386A01", VA = "0x2386900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69E0", Offset = "0x1A6AE1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003273")]
		[Address(RVA = "0x2386910", Offset = "0x2386A11", VA = "0x2386910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69F0", Offset = "0x1A6AF1")]
		set
		{
		}
	}

	// Token: 0x170008AF RID: 2223
	// (get) Token: 0x06003C18 RID: 15384 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C19 RID: 15385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F2")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6003274")]
		[Address(RVA = "0x2386920", Offset = "0x2386A21", VA = "0x2386920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6A00", Offset = "0x1A6B01")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x2386930", Offset = "0x2386A31", VA = "0x2386930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6A10", Offset = "0x1A6B11")]
		set
		{
		}
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003276")]
	[Address(RVA = "0x2386940", Offset = "0x2386A41", VA = "0x2386940")]
	public void Initialize(GameObject bindTarget, bool isKeep)
	{
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003277")]
	[Address(RVA = "0x2386980", Offset = "0x2386A81", VA = "0x2386980", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003278")]
	[Address(RVA = "0x2386A80", Offset = "0x2386B81", VA = "0x2386A80", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003279")]
	[Address(RVA = "0x2386B20", Offset = "0x2386C21", VA = "0x2386B20", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600327A")]
	[Address(RVA = "0x2386B70", Offset = "0x2386C71", VA = "0x2386B70", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C1F RID: 15391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600327B")]
	[Address(RVA = "0x2386B80", Offset = "0x2386C81", VA = "0x2386B80")]
	public SpringBoneInitBehavior()
	{
	}

	// Token: 0x04007E95 RID: 32405
	[Token(Token = "0x400724A")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ECE0", Offset = "0x16EDE1")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E96 RID: 32406
	[Token(Token = "0x400724B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ECF0", Offset = "0x16EDF1")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04007E97 RID: 32407
	[Token(Token = "0x400724C")]
	[FieldOffset(Offset = "0x20")]
	private bool IsKeepInit;
}
