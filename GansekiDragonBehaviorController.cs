using System;
using BehaviorDesigner.Runtime.Tasks;
using BossData;
using Il2CppDummyDll;

// Token: 0x020006F3 RID: 1779
[Token(Token = "0x20004E5")]
public class GansekiDragonBehaviorController : BossBehaviorController
{
	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000108F0 File Offset: 0x0000EAF0
	[Token(Token = "0x17000551")]
	private bool IsAccumulatedDamage
	{
		[Token(Token = "0x6002544")]
		[Address(RVA = "0x1F976C0", Offset = "0x1F977C1", VA = "0x1F976C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002545")]
	[Address(RVA = "0x1F97740", Offset = "0x1F97841", VA = "0x1F97740", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002546")]
	[Address(RVA = "0x1F9A220", Offset = "0x1F9A321", VA = "0x1F9A220", Slot = "82")]
	public override void SetBossDataAsset(BossDataAssetBase bossData)
	{
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002547")]
	[Address(RVA = "0x1F9A260", Offset = "0x1F9A361", VA = "0x1F9A260", Slot = "88")]
	public override void OnUpdateBossDataBitArray()
	{
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002548")]
	[Address(RVA = "0x1F9A330", Offset = "0x1F9A431", VA = "0x1F9A330", Slot = "57")]
	public override void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002549")]
	[Address(RVA = "0x1F9A4F0", Offset = "0x1F9A5F1", VA = "0x1F9A4F0", Slot = "84")]
	public override void OnMadness()
	{
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600254A")]
	[Address(RVA = "0x1F9A5A0", Offset = "0x1F9A6A1", VA = "0x1F9A5A0", Slot = "92")]
	protected override void UpdateRestraintBehaviorTiming()
	{
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600254B")]
	[Address(RVA = "0x1F9A690", Offset = "0x1F9A791", VA = "0x1F9A690", Slot = "93")]
	protected override void UpdateReciveItemBehaviorTiming()
	{
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600254C")]
	[Address(RVA = "0x1F9A710", Offset = "0x1F9A811", VA = "0x1F9A710", Slot = "79")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254D")]
	[Address(RVA = "0x1F97C50", Offset = "0x1F97D51", VA = "0x1F97C50")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushAttack()
	{
		return null;
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254E")]
	[Address(RVA = "0x1F97E10", Offset = "0x1F97F11", VA = "0x1F97E10")]
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleRushAttack()
	{
		return null;
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600254F")]
	[Address(RVA = "0x1F97FD0", Offset = "0x1F980D1", VA = "0x1F97FD0")]
	private MonsterBehaviorController.BehaviorActionParam CreateTramplingAttack()
	{
		return null;
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002550")]
	[Address(RVA = "0x1F981A0", Offset = "0x1F982A1", VA = "0x1F981A0")]
	private MonsterBehaviorController.BehaviorActionParam CreateHeadButtAttack()
	{
		return null;
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002551")]
	[Address(RVA = "0x1F98470", Offset = "0x1F98571", VA = "0x1F98470")]
	private MonsterBehaviorController.BehaviorActionParam CreateRockSkippingAttack()
	{
		return null;
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002552")]
	[Address(RVA = "0x1F98640", Offset = "0x1F98741", VA = "0x1F98640")]
	private MonsterBehaviorController.BehaviorActionParam CreateTiltTramplingAttack()
	{
		return null;
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002553")]
	[Address(RVA = "0x1F982B0", Offset = "0x1F983B1", VA = "0x1F982B0")]
	private MonsterBehaviorController.BehaviorActionParam CreateJumpAttack()
	{
		return null;
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002554")]
	[Address(RVA = "0x1F98D60", Offset = "0x1F98E61", VA = "0x1F98D60")]
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryAttack()
	{
		return null;
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002555")]
	[Address(RVA = "0x1F98F20", Offset = "0x1F99021", VA = "0x1F98F20")]
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryJumpAttack()
	{
		return null;
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002556")]
	[Address(RVA = "0x1F99180", Offset = "0x1F99281", VA = "0x1F99180")]
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryRushAttack()
	{
		return null;
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002557")]
	[Address(RVA = "0x1F993E0", Offset = "0x1F994E1", VA = "0x1F993E0")]
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleRockMimicryRushAttack()
	{
		return null;
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002558")]
	[Address(RVA = "0x1F99640", Offset = "0x1F99741", VA = "0x1F99640")]
	private MonsterBehaviorController.BehaviorActionParam CreateRockMimicryRelease()
	{
		return null;
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002559")]
	[Address(RVA = "0x1F98810", Offset = "0x1F98911", VA = "0x1F98810")]
	private MonsterBehaviorController.BehaviorActionParam CreateDoubleEarthSpike()
	{
		return null;
	}

	// Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255A")]
	[Address(RVA = "0x1F989D0", Offset = "0x1F98AD1", VA = "0x1F989D0")]
	private MonsterBehaviorController.BehaviorActionParam CreateTripleEarthSpike()
	{
		return null;
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255B")]
	[Address(RVA = "0x1F98B90", Offset = "0x1F98C91", VA = "0x1F98B90")]
	private MonsterBehaviorController.BehaviorActionParam CreateAvengerRock()
	{
		return null;
	}

	// Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255C")]
	[Address(RVA = "0x1F99840", Offset = "0x1F99941", VA = "0x1F99840")]
	private MonsterBehaviorController.BehaviorActionParam CreateEatRock1()
	{
		return null;
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255D")]
	[Address(RVA = "0x1F99A10", Offset = "0x1F99B11", VA = "0x1F99A10")]
	private MonsterBehaviorController.BehaviorActionParam CreateEatRock2()
	{
		return null;
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255E")]
	[Address(RVA = "0x1F99BE0", Offset = "0x1F99CE1", VA = "0x1F99BE0")]
	private MonsterBehaviorController.BehaviorActionParam CreateRushMove()
	{
		return null;
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600255F")]
	[Address(RVA = "0x1F99D20", Offset = "0x1F99E21", VA = "0x1F99D20")]
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryWait1()
	{
		return null;
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002560")]
	[Address(RVA = "0x1F99E20", Offset = "0x1F99F21", VA = "0x1F99E20")]
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryWait2()
	{
		return null;
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002561")]
	[Address(RVA = "0x1F9A020", Offset = "0x1F9A121", VA = "0x1F9A020")]
	private MonsterBehaviorController.BehaviorActionParam CreateAngry()
	{
		return null;
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002562")]
	[Address(RVA = "0x1F9A120", Offset = "0x1F9A221", VA = "0x1F9A120")]
	private MonsterBehaviorController.BehaviorActionParam CreateMimicryMagic()
	{
		return null;
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x00010908 File Offset: 0x0000EB08
	[Token(Token = "0x6002563")]
	[Address(RVA = "0x1F9A750", Offset = "0x1F9A851", VA = "0x1F9A750")]
	private TaskStatus MimicryWait()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002564")]
	[Address(RVA = "0x1F9A8F0", Offset = "0x1F9A9F1", VA = "0x1F9A8F0", Slot = "87")]
	public override string GetLotteryTypeEnumToString(int SelectType)
	{
		return null;
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002565")]
	[Address(RVA = "0x1F9AA30", Offset = "0x1F9AB31", VA = "0x1F9AA30")]
	public GansekiDragonBehaviorController()
	{
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002566")]
	[Address(RVA = "0x1F9AA40", Offset = "0x1F9AB41", VA = "0x1F9AA40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E40", Offset = "0x1A2F41")]
	private void <OnSetup>b__12_0()
	{
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002567")]
	[Address(RVA = "0x1F9AA50", Offset = "0x1F9AB51", VA = "0x1F9AA50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E50", Offset = "0x1A2F51")]
	private void <CreateRushAttack>b__20_0()
	{
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002568")]
	[Address(RVA = "0x1F9AAA0", Offset = "0x1F9ABA1", VA = "0x1F9AAA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E60", Offset = "0x1A2F61")]
	private void <CreateDoubleRushAttack>b__21_0()
	{
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002569")]
	[Address(RVA = "0x1F9AAF0", Offset = "0x1F9ABF1", VA = "0x1F9AAF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E70", Offset = "0x1A2F71")]
	private void <CreateTramplingAttack>b__22_0()
	{
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256A")]
	[Address(RVA = "0x1F9AB40", Offset = "0x1F9AC41", VA = "0x1F9AB40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E80", Offset = "0x1A2F81")]
	private void <CreateHeadButtAttack>b__23_0()
	{
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256B")]
	[Address(RVA = "0x1F9AB90", Offset = "0x1F9AC91", VA = "0x1F9AB90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2E90", Offset = "0x1A2F91")]
	private void <CreateRockSkippingAttack>b__24_0()
	{
	}

	// Token: 0x06002C4D RID: 11341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256C")]
	[Address(RVA = "0x1F9ABE0", Offset = "0x1F9ACE1", VA = "0x1F9ABE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2EA0", Offset = "0x1A2FA1")]
	private void <CreateTiltTramplingAttack>b__25_0()
	{
	}

	// Token: 0x06002C4E RID: 11342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256D")]
	[Address(RVA = "0x1F9AC30", Offset = "0x1F9AD31", VA = "0x1F9AC30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2EB0", Offset = "0x1A2FB1")]
	private void <CreateJumpAttack>b__26_0()
	{
	}

	// Token: 0x06002C4F RID: 11343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256E")]
	[Address(RVA = "0x1F9AC80", Offset = "0x1F9AD81", VA = "0x1F9AC80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2EC0", Offset = "0x1A2FC1")]
	private void <CreateRockMimicryAttack>b__27_0()
	{
	}

	// Token: 0x06002C50 RID: 11344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600256F")]
	[Address(RVA = "0x1F9ACE0", Offset = "0x1F9ADE1", VA = "0x1F9ACE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2ED0", Offset = "0x1A2FD1")]
	private void <CreateRockMimicryJumpAttack>b__28_0()
	{
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002570")]
	[Address(RVA = "0x1F9AD30", Offset = "0x1F9AE31", VA = "0x1F9AD30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2EE0", Offset = "0x1A2FE1")]
	private void <CreateRockMimicryRushAttack>b__29_0()
	{
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002571")]
	[Address(RVA = "0x1F9AD80", Offset = "0x1F9AE81", VA = "0x1F9AD80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2EF0", Offset = "0x1A2FF1")]
	private void <CreateDoubleRockMimicryRushAttack>b__30_0()
	{
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002572")]
	[Address(RVA = "0x1F9ADD0", Offset = "0x1F9AED1", VA = "0x1F9ADD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F00", Offset = "0x1A3001")]
	private void <CreateRockMimicryRelease>b__31_0()
	{
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002573")]
	[Address(RVA = "0x1F9AE20", Offset = "0x1F9AF21", VA = "0x1F9AE20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F10", Offset = "0x1A3011")]
	private void <CreateRockMimicryRelease>b__31_2()
	{
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002574")]
	[Address(RVA = "0x1F9AED0", Offset = "0x1F9AFD1", VA = "0x1F9AED0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F20", Offset = "0x1A3021")]
	private void <CreateDoubleEarthSpike>b__32_0()
	{
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002575")]
	[Address(RVA = "0x1F9AF20", Offset = "0x1F9B021", VA = "0x1F9AF20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F30", Offset = "0x1A3031")]
	private void <CreateTripleEarthSpike>b__33_0()
	{
	}

	// Token: 0x06002C57 RID: 11351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002576")]
	[Address(RVA = "0x1F9AF70", Offset = "0x1F9B071", VA = "0x1F9AF70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F40", Offset = "0x1A3041")]
	private void <CreateAvengerRock>b__34_1(int index, int type)
	{
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002577")]
	[Address(RVA = "0x1F9AFD0", Offset = "0x1F9B0D1", VA = "0x1F9AFD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F50", Offset = "0x1A3051")]
	private void <CreateEatRock1>b__35_0()
	{
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002578")]
	[Address(RVA = "0x1F9B020", Offset = "0x1F9B121", VA = "0x1F9B020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F60", Offset = "0x1A3061")]
	private void <CreateEatRock2>b__36_0()
	{
	}

	// Token: 0x06002C5A RID: 11354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002579")]
	[Address(RVA = "0x1F9B070", Offset = "0x1F9B171", VA = "0x1F9B070")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F70", Offset = "0x1A3071")]
	private void <CreateRushMove>b__37_0()
	{
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257A")]
	[Address(RVA = "0x1F9B0D0", Offset = "0x1F9B1D1", VA = "0x1F9B0D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F80", Offset = "0x1A3081")]
	private void <CreateRushMove>b__37_1(int index, int type)
	{
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257B")]
	[Address(RVA = "0x1F9B170", Offset = "0x1F9B271", VA = "0x1F9B170")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2F90", Offset = "0x1A3091")]
	private void <CreateMimicryWait1>b__38_0()
	{
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257C")]
	[Address(RVA = "0x1F9B190", Offset = "0x1F9B291", VA = "0x1F9B190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FA0", Offset = "0x1A30A1")]
	private void <CreateMimicryWait2>b__39_0()
	{
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257D")]
	[Address(RVA = "0x1F9B1B0", Offset = "0x1F9B2B1", VA = "0x1F9B1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FB0", Offset = "0x1A30B1")]
	private void <CreateMimicryWait2>b__39_2()
	{
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257E")]
	[Address(RVA = "0x1F9B1C0", Offset = "0x1F9B2C1", VA = "0x1F9B1C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FC0", Offset = "0x1A30C1")]
	private void <CreateAngry>b__40_0()
	{
	}

	// Token: 0x06002C60 RID: 11360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600257F")]
	[Address(RVA = "0x1F9B210", Offset = "0x1F9B311", VA = "0x1F9B210")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2FD0", Offset = "0x1A30D1")]
	private void <CreateMimicryMagic>b__41_0()
	{
	}

	// Token: 0x04007340 RID: 29504
	[Token(Token = "0x4006A80")]
	private const float RUSH_CLOSE_RANGE = 6f;

	// Token: 0x04007341 RID: 29505
	[Token(Token = "0x4006A81")]
	private const float DEFAULT_MOVESPEED = 0.8f;

	// Token: 0x04007342 RID: 29506
	[Token(Token = "0x4006A82")]
	private const float RUSH_MOVESPEED = 1f;

	// Token: 0x04007343 RID: 29507
	[Token(Token = "0x4006A83")]
	[FieldOffset(Offset = "0x1C0")]
	private float T;

	// Token: 0x04007344 RID: 29508
	[Token(Token = "0x4006A84")]
	[FieldOffset(Offset = "0x1C4")]
	private float AccumulatedDamageMimicryCounter;

	// Token: 0x04007345 RID: 29509
	[Token(Token = "0x4006A85")]
	[FieldOffset(Offset = "0x1C8")]
	private bool IsMimicryRelease;

	// Token: 0x04007346 RID: 29510
	[Token(Token = "0x4006A86")]
	[FieldOffset(Offset = "0x1CC")]
	private int BehaviorSkipCount;

	// Token: 0x04007347 RID: 29511
	[Token(Token = "0x4006A87")]
	[FieldOffset(Offset = "0x1D0")]
	private float AccumulatedDamageMimicry;

	// Token: 0x04007348 RID: 29512
	[Token(Token = "0x4006A88")]
	[FieldOffset(Offset = "0x1D4")]
	private float MimicryWaitTime;

	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x2001195")]
	private enum StateType
	{
		// Token: 0x0400734A RID: 29514
		[Token(Token = "0x401952A")]
		MimicryWait
	}

	// Token: 0x020006F5 RID: 1781
	[Token(Token = "0x2001196")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1583E0", Offset = "0x1584E1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002C62 RID: 11362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CD")]
		[Address(RVA = "0x1F9B2D0", Offset = "0x1F9B3D1", VA = "0x1F9B2D0")]
		public <>c()
		{
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CE")]
		[Address(RVA = "0x1F9B2E0", Offset = "0x1F9B3E1", VA = "0x1F9B2E0")]
		internal void <CreateRushAttack>b__20_1(int index, int type)
		{
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CF")]
		[Address(RVA = "0x1F9B2F0", Offset = "0x1F9B3F1", VA = "0x1F9B2F0")]
		internal void <CreateDoubleRushAttack>b__21_1(int index, int type)
		{
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D0")]
		[Address(RVA = "0x1F9B300", Offset = "0x1F9B401", VA = "0x1F9B300")]
		internal void <CreateTramplingAttack>b__22_1(int index, int type)
		{
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D1")]
		[Address(RVA = "0x1F9B310", Offset = "0x1F9B411", VA = "0x1F9B310")]
		internal void <CreateRockSkippingAttack>b__24_1(int index, int type)
		{
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D2")]
		[Address(RVA = "0x1F9B320", Offset = "0x1F9B421", VA = "0x1F9B320")]
		internal void <CreateTiltTramplingAttack>b__25_1(int index, int type)
		{
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D3")]
		[Address(RVA = "0x1F9B330", Offset = "0x1F9B431", VA = "0x1F9B330")]
		internal void <CreateJumpAttack>b__26_1(int index, int type)
		{
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D4")]
		[Address(RVA = "0x1F9B340", Offset = "0x1F9B441", VA = "0x1F9B340")]
		internal void <CreateRockMimicryAttack>b__27_1(int index, int type)
		{
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D5")]
		[Address(RVA = "0x1F9B350", Offset = "0x1F9B451", VA = "0x1F9B350")]
		internal void <CreateRockMimicryJumpAttack>b__28_1(int index, int type)
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0x1F9B360", Offset = "0x1F9B461", VA = "0x1F9B360")]
		internal void <CreateRockMimicryJumpAttack>b__28_2()
		{
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D7")]
		[Address(RVA = "0x1F9B370", Offset = "0x1F9B471", VA = "0x1F9B370")]
		internal void <CreateRockMimicryRushAttack>b__29_1(int index, int type)
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D8")]
		[Address(RVA = "0x1F9B380", Offset = "0x1F9B481", VA = "0x1F9B380")]
		internal void <CreateRockMimicryRushAttack>b__29_2()
		{
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0x1F9B390", Offset = "0x1F9B491", VA = "0x1F9B390")]
		internal void <CreateDoubleRockMimicryRushAttack>b__30_1(int index, int type)
		{
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0x1F9B3A0", Offset = "0x1F9B4A1", VA = "0x1F9B3A0")]
		internal void <CreateDoubleRockMimicryRushAttack>b__30_2()
		{
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DB")]
		[Address(RVA = "0x1F9B3B0", Offset = "0x1F9B4B1", VA = "0x1F9B3B0")]
		internal void <CreateRockMimicryRelease>b__31_1(int index, int type)
		{
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DC")]
		[Address(RVA = "0x1F9B3C0", Offset = "0x1F9B4C1", VA = "0x1F9B3C0")]
		internal void <CreateDoubleEarthSpike>b__32_1(int index, int type)
		{
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0x1F9B3D0", Offset = "0x1F9B4D1", VA = "0x1F9B3D0")]
		internal void <CreateTripleEarthSpike>b__33_1(int index, int type)
		{
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x1F9B3E0", Offset = "0x1F9B4E1", VA = "0x1F9B3E0")]
		internal void <CreateAvengerRock>b__34_0()
		{
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0x1F9B3F0", Offset = "0x1F9B4F1", VA = "0x1F9B3F0")]
		internal void <CreateEatRock1>b__35_1(int index, int type)
		{
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E0")]
		[Address(RVA = "0x1F9B400", Offset = "0x1F9B501", VA = "0x1F9B400")]
		internal void <CreateEatRock2>b__36_1(int index, int type)
		{
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E1")]
		[Address(RVA = "0x1F9B410", Offset = "0x1F9B511", VA = "0x1F9B410")]
		internal void <CreateMimicryWait2>b__39_1(int index, int type)
		{
		}

		// Token: 0x0400734B RID: 29515
		[Token(Token = "0x401952B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GansekiDragonBehaviorController.<>c <>9;

		// Token: 0x0400734C RID: 29516
		[Token(Token = "0x401952C")]
		[FieldOffset(Offset = "0x8")]
		public static Action<int, int> <>9__20_1;

		// Token: 0x0400734D RID: 29517
		[Token(Token = "0x401952D")]
		[FieldOffset(Offset = "0x10")]
		public static Action<int, int> <>9__21_1;

		// Token: 0x0400734E RID: 29518
		[Token(Token = "0x401952E")]
		[FieldOffset(Offset = "0x18")]
		public static Action<int, int> <>9__22_1;

		// Token: 0x0400734F RID: 29519
		[Token(Token = "0x401952F")]
		[FieldOffset(Offset = "0x20")]
		public static Action<int, int> <>9__24_1;

		// Token: 0x04007350 RID: 29520
		[Token(Token = "0x4019530")]
		[FieldOffset(Offset = "0x28")]
		public static Action<int, int> <>9__25_1;

		// Token: 0x04007351 RID: 29521
		[Token(Token = "0x4019531")]
		[FieldOffset(Offset = "0x30")]
		public static Action<int, int> <>9__26_1;

		// Token: 0x04007352 RID: 29522
		[Token(Token = "0x4019532")]
		[FieldOffset(Offset = "0x38")]
		public static Action<int, int> <>9__27_1;

		// Token: 0x04007353 RID: 29523
		[Token(Token = "0x4019533")]
		[FieldOffset(Offset = "0x40")]
		public static Action<int, int> <>9__28_1;

		// Token: 0x04007354 RID: 29524
		[Token(Token = "0x4019534")]
		[FieldOffset(Offset = "0x48")]
		public static System.Action <>9__28_2;

		// Token: 0x04007355 RID: 29525
		[Token(Token = "0x4019535")]
		[FieldOffset(Offset = "0x50")]
		public static Action<int, int> <>9__29_1;

		// Token: 0x04007356 RID: 29526
		[Token(Token = "0x4019536")]
		[FieldOffset(Offset = "0x58")]
		public static System.Action <>9__29_2;

		// Token: 0x04007357 RID: 29527
		[Token(Token = "0x4019537")]
		[FieldOffset(Offset = "0x60")]
		public static Action<int, int> <>9__30_1;

		// Token: 0x04007358 RID: 29528
		[Token(Token = "0x4019538")]
		[FieldOffset(Offset = "0x68")]
		public static System.Action <>9__30_2;

		// Token: 0x04007359 RID: 29529
		[Token(Token = "0x4019539")]
		[FieldOffset(Offset = "0x70")]
		public static Action<int, int> <>9__31_1;

		// Token: 0x0400735A RID: 29530
		[Token(Token = "0x401953A")]
		[FieldOffset(Offset = "0x78")]
		public static Action<int, int> <>9__32_1;

		// Token: 0x0400735B RID: 29531
		[Token(Token = "0x401953B")]
		[FieldOffset(Offset = "0x80")]
		public static Action<int, int> <>9__33_1;

		// Token: 0x0400735C RID: 29532
		[Token(Token = "0x401953C")]
		[FieldOffset(Offset = "0x88")]
		public static System.Action <>9__34_0;

		// Token: 0x0400735D RID: 29533
		[Token(Token = "0x401953D")]
		[FieldOffset(Offset = "0x90")]
		public static Action<int, int> <>9__35_1;

		// Token: 0x0400735E RID: 29534
		[Token(Token = "0x401953E")]
		[FieldOffset(Offset = "0x98")]
		public static Action<int, int> <>9__36_1;

		// Token: 0x0400735F RID: 29535
		[Token(Token = "0x401953F")]
		[FieldOffset(Offset = "0xA0")]
		public static Action<int, int> <>9__39_1;
	}
}
