using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000672 RID: 1650
[Token(Token = "0x2000497")]
public class DN17BossStageManager : BossStageManager, DN17BossStageInterface
{
	// Token: 0x060028F0 RID: 10480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002297")]
	[Address(RVA = "0x1D9E8D0", Offset = "0x1D9E9D1", VA = "0x1D9E8D0", Slot = "5")]
	protected override void OnSetup()
	{
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002298")]
	[Address(RVA = "0x1D9EA30", Offset = "0x1D9EB31", VA = "0x1D9EA30")]
	public void CrackStage(bool isCrack)
	{
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002299")]
	[Address(RVA = "0x1D9EAE0", Offset = "0x1D9EBE1", VA = "0x1D9EAE0", Slot = "8")]
	public void CrackStage()
	{
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229A")]
	[Address(RVA = "0x1D9ED50", Offset = "0x1D9EE51", VA = "0x1D9ED50", Slot = "6")]
	protected override void OnBeforeCreateBoss()
	{
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229B")]
	[Address(RVA = "0x1D9ED60", Offset = "0x1D9EE61", VA = "0x1D9ED60", Slot = "7")]
	protected override void OnAfterCreateBoss(BossBehaviorController controller)
	{
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600229C")]
	[Address(RVA = "0x1D9EE50", Offset = "0x1D9EF51", VA = "0x1D9EE50")]
	public DN17BossStageManager()
	{
	}

	// Token: 0x0400708B RID: 28811
	[Token(Token = "0x400688D")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject GlassStage;

	// Token: 0x0400708C RID: 28812
	[Token(Token = "0x400688E")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject CrackGlassStage;

	// Token: 0x0400708D RID: 28813
	[Token(Token = "0x400688F")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject CrackGlassCollider;

	// Token: 0x0400708E RID: 28814
	[Token(Token = "0x4006890")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject GlassStageNavmeshSurface;

	// Token: 0x0400708F RID: 28815
	[Token(Token = "0x4006891")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject CrackGlassStageNavmeshSurface;

	// Token: 0x04007090 RID: 28816
	[Token(Token = "0x4006892")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Transform ApeearMadnessBoss;

	// Token: 0x04007091 RID: 28817
	[Token(Token = "0x4006893")]
	[FieldOffset(Offset = "0xD8")]
	private GandageBehaviorController GandageBehaviorController;
}
