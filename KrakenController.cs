using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000723 RID: 1827
[Token(Token = "0x20004FA")]
public class KrakenController : BossMonsterContoroller
{
	// Token: 0x06002E6A RID: 11882 RVA: 0x00010D10 File Offset: 0x0000EF10
	[Token(Token = "0x6002714")]
	[Address(RVA = "0x2248F60", Offset = "0x2249061", VA = "0x2248F60", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x06002E6B RID: 11883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002715")]
	[Address(RVA = "0x2248FB0", Offset = "0x22490B1", VA = "0x2248FB0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002E6C RID: 11884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002716")]
	[Address(RVA = "0x2249090", Offset = "0x2249191", VA = "0x2249090", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002717")]
	[Address(RVA = "0x22493C0", Offset = "0x22494C1", VA = "0x22493C0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002E6E RID: 11886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002718")]
	[Address(RVA = "0x2249480", Offset = "0x2249581", VA = "0x2249480", Slot = "125")]
	protected override void OnSetModelObject(GameObject model)
	{
	}

	// Token: 0x06002E6F RID: 11887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002719")]
	[Address(RVA = "0x2249510", Offset = "0x2249611", VA = "0x2249510", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271A")]
	[Address(RVA = "0x2249750", Offset = "0x2249851", VA = "0x2249750", Slot = "46")]
	protected override void SetLocomotion(float value)
	{
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271B")]
	[Address(RVA = "0x2249820", Offset = "0x2249921", VA = "0x2249820")]
	private void AttackJump(float height, float duration)
	{
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271C")]
	[Address(RVA = "0x2249950", Offset = "0x2249A51", VA = "0x2249950")]
	private void LeaveJump(float height, float duration)
	{
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271D")]
	[Address(RVA = "0x2249BB0", Offset = "0x2249CB1", VA = "0x2249BB0")]
	private void CreateProjectile(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271E")]
	[Address(RVA = "0x2249CC0", Offset = "0x2249DC1", VA = "0x2249CC0")]
	private void CheckTiltStickOut(string nextAction, string endAction)
	{
	}

	// Token: 0x06002E75 RID: 11893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600271F")]
	[Address(RVA = "0x2249DA0", Offset = "0x2249EA1", VA = "0x2249DA0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002720")]
	[Address(RVA = "0x224A4C0", Offset = "0x224A5C1", VA = "0x224A4C0", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002721")]
	[Address(RVA = "0x224A810", Offset = "0x224A911", VA = "0x224A810")]
	public KrakenController()
	{
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002723")]
	[Address(RVA = "0x224A980", Offset = "0x224AA81", VA = "0x224A980")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3A20", Offset = "0x1A3B21")]
	private void <Start>b__18_0(ParticleSystem particle)
	{
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002724")]
	[Address(RVA = "0x224AAB0", Offset = "0x224ABB1", VA = "0x224AAB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3A30", Offset = "0x1A3B31")]
	private void <AttackJump>b__23_0()
	{
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002725")]
	[Address(RVA = "0x224AAE0", Offset = "0x224ABE1", VA = "0x224AAE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3A40", Offset = "0x1A3B41")]
	private void <LeaveJump>b__24_0()
	{
	}

	// Token: 0x04007474 RID: 29812
	[Token(Token = "0x4006B1C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE;

	// Token: 0x04007475 RID: 29813
	[Token(Token = "0x4006B1D")]
	private const float EARTHQUAKE_SCALE = 5f;

	// Token: 0x04007476 RID: 29814
	[Token(Token = "0x4006B1E")]
	[FieldOffset(Offset = "0x508")]
	private Vector3 StartPosition;

	// Token: 0x04007477 RID: 29815
	[Token(Token = "0x4006B1F")]
	[FieldOffset(Offset = "0x514")]
	private Vector3 EndPosition;

	// Token: 0x04007478 RID: 29816
	[Token(Token = "0x4006B20")]
	private const int MaxLeg = 4;

	// Token: 0x04007479 RID: 29817
	[Token(Token = "0x4006B21")]
	[FieldOffset(Offset = "0x520")]
	private List<KrakenStickController> KrakenStickList;

	// Token: 0x0400747A RID: 29818
	[Token(Token = "0x4006B22")]
	[FieldOffset(Offset = "0x528")]
	private KrakenStickController Bluefeet;

	// Token: 0x0400747B RID: 29819
	[Token(Token = "0x4006B23")]
	[FieldOffset(Offset = "0x530")]
	private KrakenStickController Yellowfeet;

	// Token: 0x0400747C RID: 29820
	[Token(Token = "0x4006B24")]
	[FieldOffset(Offset = "0x538")]
	private int StickOutCounter;

	// Token: 0x0400747D RID: 29821
	[Token(Token = "0x4006B25")]
	[FieldOffset(Offset = "0x53C")]
	private int MaxStickOut;

	// Token: 0x0400747E RID: 29822
	[Token(Token = "0x4006B26")]
	[FieldOffset(Offset = "0x540")]
	private bool IsDive;

	// Token: 0x0400747F RID: 29823
	[Token(Token = "0x4006B27")]
	[FieldOffset(Offset = "0x548")]
	private SkinnedMeshRenderer ModelSkinnedMeshRenderer;

	// Token: 0x04007480 RID: 29824
	[Token(Token = "0x4006B28")]
	[FieldOffset(Offset = "0x550")]
	public List<Transform> RandomPosList;

	// Token: 0x04007481 RID: 29825
	[Token(Token = "0x4006B29")]
	[FieldOffset(Offset = "0x558")]
	public List<Transform> SpawnPosList;

	// Token: 0x04007482 RID: 29826
	[Token(Token = "0x4006B2A")]
	[FieldOffset(Offset = "0x560")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x04007483 RID: 29827
	[Token(Token = "0x4006B2B")]
	[FieldOffset(Offset = "0x568")]
	private Tween RotateTween;
}
