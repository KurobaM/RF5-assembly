using System;
using Define;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x20000D0")]
public class HumanFootSteps : CharaFootSteps<HumanController>
{
	// Token: 0x17000159 RID: 345
	// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00004188 File Offset: 0x00002388
	[Token(Token = "0x17000153")]
	protected override FootStepType FootStepType
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x20A5380", Offset = "0x20A5481", VA = "0x20A5380", Slot = "4")]
		get
		{
			return FootStepType.Human;
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x20A5390", Offset = "0x20A5491", VA = "0x20A5390", Slot = "7")]
	protected override void Awake()
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x20982A0", Offset = "0x20983A1", VA = "0x20982A0")]
	public void ResetTransform(Animator animator)
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x000041A0 File Offset: 0x000023A0
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x20A5410", Offset = "0x20A5511", VA = "0x20A5410", Slot = "9")]
	public override SoundID GetStepSoundID(GroundType groundType)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x000041B8 File Offset: 0x000023B8
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x20A5500", Offset = "0x20A5601", VA = "0x20A5500", Slot = "10")]
	public override SoundID GetLandingSoundID(GroundType groundType)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x20A55F0", Offset = "0x20A56F1", VA = "0x20A55F0", Slot = "11")]
	public override void OnFootSteps(GroundType groundType, Collider hitCollider)
	{
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x20A59F0", Offset = "0x20A5AF1", VA = "0x20A59F0", Slot = "12")]
	public override void OnLanding(GroundType groundType, Collider hitCollider)
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x20A5890", Offset = "0x20A5991", VA = "0x20A5890")]
	private void DoPlow(CellController cell)
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x20A5740", Offset = "0x20A5841", VA = "0x20A5740")]
	private void DoSlash(CellController cell)
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x20A5A00", Offset = "0x20A5B01", VA = "0x20A5A00")]
	public HumanFootSteps()
	{
	}

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private HumanBodyBones[] m_TargetBones;
}
