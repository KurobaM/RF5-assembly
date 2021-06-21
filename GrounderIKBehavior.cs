using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008D8 RID: 2264
[Token(Token = "0x20005E4")]
[Serializable]
public class GrounderIKBehavior : PlayableBehaviour
{
	// Token: 0x17000896 RID: 2198
	// (get) Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BBE RID: 15294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D9")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x1FF7F40", Offset = "0x1FF8041", VA = "0x1FF7F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67A0", Offset = "0x1A68A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x1FF7F50", Offset = "0x1FF8051", VA = "0x1FF7F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67B0", Offset = "0x1A68B1")]
		set
		{
		}
	}

	// Token: 0x17000897 RID: 2199
	// (get) Token: 0x06003BBF RID: 15295 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BC0 RID: 15296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006DA")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x1FF7F60", Offset = "0x1FF8061", VA = "0x1FF7F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67C0", Offset = "0x1A68C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x1FF7F70", Offset = "0x1FF8071", VA = "0x1FF7F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67D0", Offset = "0x1A68D1")]
		set
		{
		}
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600321D")]
	[Address(RVA = "0x1FF7F80", Offset = "0x1FF8081", VA = "0x1FF7F80", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600321E")]
	[Address(RVA = "0x1FF8080", Offset = "0x1FF8181", VA = "0x1FF8080", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600321F")]
	[Address(RVA = "0x1FF8140", Offset = "0x1FF8241", VA = "0x1FF8140", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003220")]
	[Address(RVA = "0x1FF8260", Offset = "0x1FF8361", VA = "0x1FF8260", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003221")]
	[Address(RVA = "0x1FF8270", Offset = "0x1FF8371", VA = "0x1FF8270")]
	public GrounderIKBehavior()
	{
	}

	// Token: 0x04007E63 RID: 32355
	[Token(Token = "0x4007218")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "RangeAttribute", RVA = "0x16EAA0", Offset = "0x16EBA1")]
	public float Weight;

	// Token: 0x04007E64 RID: 32356
	[Token(Token = "0x4007219")]
	[FieldOffset(Offset = "0x14")]
	public bool ResetPosition;

	// Token: 0x04007E65 RID: 32357
	[Token(Token = "0x400721A")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EAC0", Offset = "0x16EBC1")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E66 RID: 32358
	[Token(Token = "0x400721B")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EAD0", Offset = "0x16EBD1")]
	private HumanModel <HumanModel>k__BackingField;
}
