using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BF RID: 447
[Token(Token = "0x200015F")]
public abstract class CharaMotionBehaviour : StateMachineBehaviour
{
	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A7")]
	public Character Chara
	{
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1E84900", Offset = "0x1E84A01", VA = "0x1E84900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AEB0", Offset = "0x19AFB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1E84910", Offset = "0x1E84A11", VA = "0x1E84910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AEC0", Offset = "0x19AFC1")]
		set
		{
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000961 RID: 2401 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000962 RID: 2402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001A8")]
	public HumanController Human
	{
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1E84920", Offset = "0x1E84A21", VA = "0x1E84920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AED0", Offset = "0x19AFD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1E84930", Offset = "0x1E84A31", VA = "0x1E84930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AEE0", Offset = "0x19AFE1")]
		set
		{
		}
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000816")]
	[Address(RVA = "0x1E84940", Offset = "0x1E84A41", VA = "0x1E84940")]
	protected CharaMotionBehaviour()
	{
	}

	// Token: 0x040005C5 RID: 1477
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CBA0", Offset = "0x15CCA1")]
	private Character <Chara>k__BackingField;

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15CBB0", Offset = "0x15CCB1")]
	private HumanController <Human>k__BackingField;
}
