using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008DC RID: 2268
[Token(Token = "0x20005E8")]
public class HumanEquipBehavior : PlayableBehaviour
{
	// Token: 0x1700089A RID: 2202
	// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BCF RID: 15311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006DD")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x20A2970", Offset = "0x20A2A71", VA = "0x20A2970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6800", Offset = "0x1A6901")]
		get
		{
			return null;
		}
		[Token(Token = "0x600322B")]
		[Address(RVA = "0x20A2980", Offset = "0x20A2A81", VA = "0x20A2980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6810", Offset = "0x1A6911")]
		set
		{
		}
	}

	// Token: 0x1700089B RID: 2203
	// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BD1 RID: 15313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006DE")]
	public Transform EquipItem
	{
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x20A2990", Offset = "0x20A2A91", VA = "0x20A2990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6820", Offset = "0x1A6921")]
		get
		{
			return null;
		}
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x20A29A0", Offset = "0x20A2AA1", VA = "0x20A29A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6830", Offset = "0x1A6931")]
		set
		{
		}
	}

	// Token: 0x1700089C RID: 2204
	// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BD3 RID: 15315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006DF")]
	public Transform ReturnItem
	{
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x20A29B0", Offset = "0x20A2AB1", VA = "0x20A29B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6840", Offset = "0x1A6941")]
		get
		{
			return null;
		}
		[Token(Token = "0x600322F")]
		[Address(RVA = "0x20A29C0", Offset = "0x20A2AC1", VA = "0x20A29C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6850", Offset = "0x1A6951")]
		set
		{
		}
	}

	// Token: 0x06003BD4 RID: 15316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003230")]
	[Address(RVA = "0x20A29D0", Offset = "0x20A2AD1", VA = "0x20A29D0")]
	private void EquipOn()
	{
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003231")]
	[Address(RVA = "0x20A2B70", Offset = "0x20A2C71", VA = "0x20A2B70")]
	private void EquipOff()
	{
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003232")]
	[Address(RVA = "0x20A2D00", Offset = "0x20A2E01", VA = "0x20A2D00", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003233")]
	[Address(RVA = "0x20A2D40", Offset = "0x20A2E41", VA = "0x20A2D40", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BD8 RID: 15320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003234")]
	[Address(RVA = "0x20A2D80", Offset = "0x20A2E81", VA = "0x20A2D80")]
	public HumanEquipBehavior()
	{
	}

	// Token: 0x04007E69 RID: 32361
	[Token(Token = "0x400721E")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EAF0", Offset = "0x16EBF1")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04007E6A RID: 32362
	[Token(Token = "0x400721F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB00", Offset = "0x16EC01")]
	private Transform <EquipItem>k__BackingField;

	// Token: 0x04007E6B RID: 32363
	[Token(Token = "0x4007220")]
	[FieldOffset(Offset = "0x20")]
	public HumanAttachIDEnum attachIDEnum;

	// Token: 0x04007E6C RID: 32364
	[Token(Token = "0x4007221")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB10", Offset = "0x16EC11")]
	private Transform <ReturnItem>k__BackingField;

	// Token: 0x04007E6D RID: 32365
	[Token(Token = "0x4007222")]
	[FieldOffset(Offset = "0x30")]
	private Transform oldItem;
}
