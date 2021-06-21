using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008E0 RID: 2272
[Token(Token = "0x20005EC")]
public class HumanIKBehavior : PlayableBehaviour
{
	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E3")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003240")]
		[Address(RVA = "0x20A7020", Offset = "0x20A7121", VA = "0x20A7020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68A0", Offset = "0x1A69A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003241")]
		[Address(RVA = "0x20A7030", Offset = "0x20A7131", VA = "0x20A7030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68B0", Offset = "0x1A69B1")]
		set
		{
		}
	}

	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E4")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6003242")]
		[Address(RVA = "0x20A7040", Offset = "0x20A7141", VA = "0x20A7040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68C0", Offset = "0x1A69C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x20A7050", Offset = "0x20A7151", VA = "0x20A7050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68D0", Offset = "0x1A69D1")]
		set
		{
		}
	}

	// Token: 0x170008A2 RID: 2210
	// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x00014EE0 File Offset: 0x000130E0
	// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E5")]
	public bool StartIK
	{
		[Token(Token = "0x6003244")]
		[Address(RVA = "0x20A7060", Offset = "0x20A7161", VA = "0x20A7060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68E0", Offset = "0x1A69E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x20A7070", Offset = "0x20A7171", VA = "0x20A7070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A68F0", Offset = "0x1A69F1")]
		set
		{
		}
	}

	// Token: 0x170008A3 RID: 2211
	// (get) Token: 0x06003BEA RID: 15338 RVA: 0x00014EF8 File Offset: 0x000130F8
	// (set) Token: 0x06003BEB RID: 15339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E6")]
	public bool EndIK
	{
		[Token(Token = "0x6003246")]
		[Address(RVA = "0x20A7080", Offset = "0x20A7181", VA = "0x20A7080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6900", Offset = "0x1A6A01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x20A7090", Offset = "0x20A7191", VA = "0x20A7090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6910", Offset = "0x1A6A11")]
		set
		{
		}
	}

	// Token: 0x06003BEC RID: 15340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003248")]
	[Address(RVA = "0x20A70A0", Offset = "0x20A71A1", VA = "0x20A70A0", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003BED RID: 15341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003249")]
	[Address(RVA = "0x20A71A0", Offset = "0x20A72A1", VA = "0x20A71A0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BEE RID: 15342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600324A")]
	[Address(RVA = "0x20A7280", Offset = "0x20A7381", VA = "0x20A7280", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BEF RID: 15343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600324B")]
	[Address(RVA = "0x20A7360", Offset = "0x20A7461", VA = "0x20A7360")]
	public HumanIKBehavior()
	{
	}

	// Token: 0x04007E75 RID: 32373
	[Token(Token = "0x400722A")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB70", Offset = "0x16EC71")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E76 RID: 32374
	[Token(Token = "0x400722B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB80", Offset = "0x16EC81")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04007E77 RID: 32375
	[Token(Token = "0x400722C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EB90", Offset = "0x16EC91")]
	private bool <StartIK>k__BackingField;

	// Token: 0x04007E78 RID: 32376
	[Token(Token = "0x400722D")]
	[FieldOffset(Offset = "0x21")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EBA0", Offset = "0x16ECA1")]
	private bool <EndIK>k__BackingField;
}
