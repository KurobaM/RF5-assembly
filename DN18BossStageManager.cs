using System;
using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000673 RID: 1651
[Token(Token = "0x2000498")]
public class DN18BossStageManager : BossStageManager
{
	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x060028F6 RID: 10486 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060028F7 RID: 10487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000533")]
	public CinemachineSmoothPath InsidePath
	{
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x1D9F380", Offset = "0x1D9F481", VA = "0x1D9F380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2240", Offset = "0x1A2341")]
		get
		{
			return null;
		}
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x1D9F390", Offset = "0x1D9F491", VA = "0x1D9F390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2250", Offset = "0x1A2351")]
		private set
		{
		}
	}

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x060028F8 RID: 10488 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000534")]
	public CinemachineSmoothPath OutsidePath
	{
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x1D9F3A0", Offset = "0x1D9F4A1", VA = "0x1D9F3A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2260", Offset = "0x1A2361")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x1D9F3B0", Offset = "0x1D9F4B1", VA = "0x1D9F3B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2270", Offset = "0x1A2371")]
		private set
		{
		}
	}

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x060028FA RID: 10490 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060028FB RID: 10491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000535")]
	public CinemachineDollyCart DollyCart
	{
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x1D9F3C0", Offset = "0x1D9F4C1", VA = "0x1D9F3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2280", Offset = "0x1A2381")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x1D9F3D0", Offset = "0x1D9F4D1", VA = "0x1D9F3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2290", Offset = "0x1A2391")]
		private set
		{
		}
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x1D9F3E0", Offset = "0x1D9F4E1", VA = "0x1D9F3E0", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x1D9F510", Offset = "0x1D9F611", VA = "0x1D9F510")]
	public void PlayWallPaper()
	{
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x1D9F570", Offset = "0x1D9F671", VA = "0x1D9F570")]
	public void SetDollyCartPos(Transform tf)
	{
	}

	// Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x1D9F730", Offset = "0x1D9F831", VA = "0x1D9F730")]
	public DN18BossStageManager()
	{
	}

	// Token: 0x04007092 RID: 28818
	[Token(Token = "0x4006894")]
	[FieldOffset(Offset = "0xA8")]
	private Animator WallPaperAnimator;

	// Token: 0x04007093 RID: 28819
	[Token(Token = "0x4006895")]
	[FieldOffset(Offset = "0xB0")]
	public List<Transform> OutsidePoints;

	// Token: 0x04007094 RID: 28820
	[Token(Token = "0x4006896")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168AA0", Offset = "0x168BA1")]
	private CinemachineSmoothPath <InsidePath>k__BackingField;

	// Token: 0x04007095 RID: 28821
	[Token(Token = "0x4006897")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168AB0", Offset = "0x168BB1")]
	private CinemachineSmoothPath <OutsidePath>k__BackingField;

	// Token: 0x04007096 RID: 28822
	[Token(Token = "0x4006898")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168AC0", Offset = "0x168BC1")]
	private CinemachineDollyCart <DollyCart>k__BackingField;

	// Token: 0x04007097 RID: 28823
	[Token(Token = "0x4006899")]
	[FieldOffset(Offset = "0xD0")]
	public Transform PlayerWarpTransform;
}
