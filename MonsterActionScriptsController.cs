using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x2000083")]
public class MonsterActionScriptsController : MonsterActionScriptsControllerBase
{
	// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x1D838C0", Offset = "0x1D839C1", VA = "0x1D838C0", Slot = "8")]
	protected override void Awake()
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x1D839C0", Offset = "0x1D83AC1", VA = "0x1D839C0")]
	public void SetupCollider()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x1D83B90", Offset = "0x1D83C91", VA = "0x1D83B90", Slot = "25")]
	public override void SharedProjectileControllerParameter(MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x1D83D20", Offset = "0x1D83E21", VA = "0x1D83D20", Slot = "10")]
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable)
	{
		return null;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x1D83E40", Offset = "0x1D83F41", VA = "0x1D83E40")]
	public void NextInitial(string NextActionCodeName)
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x1D83ED0", Offset = "0x1D83FD1", VA = "0x1D83ED0")]
	public void Next()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x1D83F50", Offset = "0x1D84051", VA = "0x1D83F50", Slot = "27")]
	public virtual void StartAction(string actionCodeName, int actionIndex = -1)
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x1D83FF0", Offset = "0x1D840F1", VA = "0x1D83FF0", Slot = "28")]
	public virtual void OnHitAttack(CharacterBase characterBase, Collider attackCollider, Vector3 hitPosition)
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x1D849C0", Offset = "0x1D84AC1", VA = "0x1D849C0")]
	private void OnHit(CharacterBase characterBase, int actionIndex)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x1D84A30", Offset = "0x1D84B31", VA = "0x1D84A30")]
	private void OnHitProjctile(CharacterBase characterBase, MonsterProjectileActionScriptsController controller, int index)
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x1D84AA0", Offset = "0x1D84BA1", VA = "0x1D84AA0")]
	public void OnAttackCollision(string colliderName, out AttackCollider attackCollider)
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1D84BF0", Offset = "0x1D84CF1", VA = "0x1D84BF0")]
	public MonsterActionScriptsController()
	{
	}

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	public List<AttackCollider> AttackColliderList;

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x188")]
	[NonSerialized]
	public UnityEventMonsterActionHit OnHitEvent;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x190")]
	public EffectID m_HitEffectName;

	// Token: 0x020000AA RID: 170
	[Token(Token = "0x2000FB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157050", Offset = "0x157151")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA3")]
		[Address(RVA = "0x1D84BE0", Offset = "0x1D84CE1", VA = "0x1D84BE0")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x6006BA4")]
		[Address(RVA = "0x1D84D90", Offset = "0x1D84E91", VA = "0x1D84D90")]
		internal bool <OnAttackCollision>b__0(AttackCollider collider)
		{
			return default(bool);
		}

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x4018CE5")]
		[FieldOffset(Offset = "0x10")]
		public string colliderName;
	}
}
