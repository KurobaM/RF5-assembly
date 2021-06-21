using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020005D8 RID: 1496
[Token(Token = "0x2000436")]
public class GimmickEffectWallController : GimmickBase
{
	// Token: 0x060024C2 RID: 9410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFC")]
	[Address(RVA = "0x1FE1B70", Offset = "0x1FE1C71", VA = "0x1FE1B70", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x1FE1B80", Offset = "0x1FE1C81", VA = "0x1FE1B80", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFE")]
	[Address(RVA = "0x1FE1F60", Offset = "0x1FE2061", VA = "0x1FE1F60", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x1FE2460", Offset = "0x1FE2561", VA = "0x1FE2460")]
	private void GoBattle()
	{
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x1FE1C00", Offset = "0x1FE1D01", VA = "0x1FE1C00")]
	private void DoneBattle()
	{
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x1FE2B40", Offset = "0x1FE2C41", VA = "0x1FE2B40")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x1FE2C70", Offset = "0x1FE2D71", VA = "0x1FE2C70")]
	private void OnDeadEnemy(MonsterControllerBase enemyControllerBase)
	{
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x1FE2D00", Offset = "0x1FE2E01", VA = "0x1FE2D00")]
	private void OnDestroyGate(GateController gateEnemy)
	{
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x0000ED00 File Offset: 0x0000CF00
	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x1FE28E0", Offset = "0x1FE29E1", VA = "0x1FE28E0")]
	private bool TargetObjectCheck()
	{
		return default(bool);
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x1FE2DA0", Offset = "0x1FE2EA1", VA = "0x1FE2DA0")]
	public GimmickEffectWallController()
	{
	}

	// Token: 0x04006C19 RID: 27673
	[Token(Token = "0x400655C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] WallObjects;

	// Token: 0x04006C1A RID: 27674
	[Token(Token = "0x400655D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GateController[] GateControllers;

	// Token: 0x04006C1B RID: 27675
	[Token(Token = "0x400655E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] AppearGameObjects;

	// Token: 0x04006C1C RID: 27676
	[Token(Token = "0x400655F")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> BattleTargetObject;

	// Token: 0x04006C1D RID: 27677
	[Token(Token = "0x4006560")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleSystem> ParticleList;

	// Token: 0x04006C1E RID: 27678
	[Token(Token = "0x4006561")]
	[FieldOffset(Offset = "0x48")]
	private List<Collider> ColliderList;

	// Token: 0x04006C1F RID: 27679
	[Token(Token = "0x4006562")]
	[FieldOffset(Offset = "0x50")]
	private List<NavMeshObstacle> NavMeshObstacleList;

	// Token: 0x04006C20 RID: 27680
	[Token(Token = "0x4006563")]
	[FieldOffset(Offset = "0x58")]
	private Collider AreaCollider;

	// Token: 0x04006C21 RID: 27681
	[Token(Token = "0x4006564")]
	[FieldOffset(Offset = "0x60")]
	private bool IsDoneBattle;

	// Token: 0x04006C22 RID: 27682
	[Token(Token = "0x4006565")]
	[FieldOffset(Offset = "0x61")]
	private bool IsAppearWall;
}
