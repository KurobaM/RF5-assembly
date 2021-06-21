using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000753 RID: 1875
[Token(Token = "0x200050C")]
public class OuroborosController : BossMonsterContoroller
{
	// Token: 0x06003018 RID: 12312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002871")]
	[Address(RVA = "0x2317950", Offset = "0x2317A51", VA = "0x2317950", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003019 RID: 12313 RVA: 0x00010F80 File Offset: 0x0000F180
	[Token(Token = "0x6002872")]
	[Address(RVA = "0x2317AA0", Offset = "0x2317BA1", VA = "0x2317AA0", Slot = "151")]
	protected override bool CanReciveItem()
	{
		return default(bool);
	}

	// Token: 0x0600301A RID: 12314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002873")]
	[Address(RVA = "0x2317AC0", Offset = "0x2317BC1", VA = "0x2317AC0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x0600301B RID: 12315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002874")]
	[Address(RVA = "0x2317B20", Offset = "0x2317C21", VA = "0x2317B20", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600301C RID: 12316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002875")]
	[Address(RVA = "0x2317C80", Offset = "0x2317D81", VA = "0x2317C80")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002876")]
	[Address(RVA = "0x2317D20", Offset = "0x2317E21", VA = "0x2317D20")]
	private void SetTornadoTarget()
	{
	}

	// Token: 0x0600301E RID: 12318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002877")]
	[Address(RVA = "0x2317F20", Offset = "0x2318021", VA = "0x2317F20")]
	private void SetTornadoTarget(Transform transform)
	{
	}

	// Token: 0x0600301F RID: 12319 RVA: 0x00010F98 File Offset: 0x0000F198
	[Token(Token = "0x6002878")]
	[Address(RVA = "0x2318040", Offset = "0x2318141", VA = "0x2318040")]
	private Vector3 GetRandomPos(Vector3 dir, float maxRange, float minRange = 0f)
	{
		return default(Vector3);
	}

	// Token: 0x06003020 RID: 12320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002879")]
	[Address(RVA = "0x23181B0", Offset = "0x23182B1", VA = "0x23181B0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600287A")]
	[Address(RVA = "0x2318BC0", Offset = "0x2318CC1", VA = "0x2318BC0", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600287B")]
	[Address(RVA = "0x2318FE0", Offset = "0x23190E1", VA = "0x2318FE0")]
	public OuroborosController()
	{
	}

	// Token: 0x0400758C RID: 30092
	[Token(Token = "0x4006BCE")]
	private const float GROUND_RANDOM_RANGE_MAX = 20f;

	// Token: 0x0400758D RID: 30093
	[Token(Token = "0x4006BCF")]
	private const float GROUND_RANDOM_RANGE_MIN = 5f;

	// Token: 0x0400758E RID: 30094
	[Token(Token = "0x4006BD0")]
	private const float GROUND_END_PLYAER_OFFSET_POS = 1f;

	// Token: 0x0400758F RID: 30095
	[Token(Token = "0x4006BD1")]
	private const float TORNADO_RANDOM_RANGE_MAX = 30f;

	// Token: 0x04007590 RID: 30096
	[Token(Token = "0x4006BD2")]
	private const float TORNADO_RANDOM_RANGE_MIN = 3f;

	// Token: 0x04007591 RID: 30097
	[Token(Token = "0x4006BD3")]
	[FieldOffset(Offset = "0x508")]
	[SerializeField]
	private Transform[] WindCutterPoints;

	// Token: 0x04007592 RID: 30098
	[Token(Token = "0x4006BD4")]
	[FieldOffset(Offset = "0x510")]
	private float Radius;

	// Token: 0x04007593 RID: 30099
	[Token(Token = "0x4006BD5")]
	[FieldOffset(Offset = "0x514")]
	private float SweepPower;

	// Token: 0x04007594 RID: 30100
	[Token(Token = "0x4006BD6")]
	[FieldOffset(Offset = "0x518")]
	private GameObject TornadoTarget1;

	// Token: 0x04007595 RID: 30101
	[Token(Token = "0x4006BD7")]
	[FieldOffset(Offset = "0x520")]
	private GameObject TornadoTarget2;

	// Token: 0x04007596 RID: 30102
	[Token(Token = "0x4006BD8")]
	[FieldOffset(Offset = "0x528")]
	private GameObject TornadoTarget3;

	// Token: 0x04007597 RID: 30103
	[Token(Token = "0x4006BD9")]
	[FieldOffset(Offset = "0x530")]
	private List<PartyBase> Parties;

	// Token: 0x04007598 RID: 30104
	[Token(Token = "0x4006BDA")]
	[FieldOffset(Offset = "0x538")]
	private bool IsUnder;

	// Token: 0x04007599 RID: 30105
	[Token(Token = "0x4006BDB")]
	[FieldOffset(Offset = "0x539")]
	private bool IsLeave;

	// Token: 0x0400759A RID: 30106
	[Token(Token = "0x4006BDC")]
	[FieldOffset(Offset = "0x540")]
	private Tweener MoveTweener;

	// Token: 0x0400759B RID: 30107
	[Token(Token = "0x4006BDD")]
	[FieldOffset(Offset = "0x548")]
	private Sequence MoveSequence;

	// Token: 0x02000754 RID: 1876
	[Token(Token = "0x20011CE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158650", Offset = "0x158751")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007293")]
		[Address(RVA = "0x2319060", Offset = "0x2319161", VA = "0x2319060")]
		public <>c()
		{
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x6007294")]
		[Address(RVA = "0x2319070", Offset = "0x2319171", VA = "0x2319070")]
		internal bool <SetTornadoTarget>b__21_0(PartyBase itm)
		{
			return default(bool);
		}

		// Token: 0x0400759C RID: 30108
		[Token(Token = "0x4019627")]
		[FieldOffset(Offset = "0x0")]
		public static readonly OuroborosController.<>c <>9;

		// Token: 0x0400759D RID: 30109
		[Token(Token = "0x4019628")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<PartyBase> <>9__21_0;
	}

	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x20011CF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158660", Offset = "0x158761")]
	private sealed class <>c__DisplayClass23_0
	{
		// Token: 0x06003026 RID: 12326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007295")]
		[Address(RVA = "0x23181A0", Offset = "0x23182A1", VA = "0x23181A0")]
		public <>c__DisplayClass23_0()
		{
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6007296")]
		[Address(RVA = "0x23190B0", Offset = "0x23191B1", VA = "0x23190B0")]
		internal bool <GetRandomPos>b__0(NavMeshHit hit)
		{
			return default(bool);
		}

		// Token: 0x0400759E RID: 30110
		[Token(Token = "0x4019629")]
		[FieldOffset(Offset = "0x10")]
		public OuroborosController <>4__this;

		// Token: 0x0400759F RID: 30111
		[Token(Token = "0x401962A")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 dir;
	}
}
