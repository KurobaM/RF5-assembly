using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000286 RID: 646
[Token(Token = "0x2000201")]
public class MonsterRideManager : SingletonMonoBehaviour<MonsterRideManager>
{
	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x06001075 RID: 4213 RVA: 0x00007920 File Offset: 0x00005B20
	// (set) Token: 0x06001076 RID: 4214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C6")]
	public bool IsRiding
	{
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x1E6FEB0", Offset = "0x1E6FFB1", VA = "0x1E6FEB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3C0", Offset = "0x19C4C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x1E6FEC0", Offset = "0x1E6FFC1", VA = "0x1E6FEC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3D0", Offset = "0x19C4D1")]
		private set
		{
		}
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002C7")]
	public MonsterControllerBase Monster
	{
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x1E6FED0", Offset = "0x1E6FFD1", VA = "0x1E6FED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0x1E6FEE0", Offset = "0x1E6FFE1", VA = "0x1E6FEE0")]
	public void Init()
	{
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00007938 File Offset: 0x00005B38
	[Token(Token = "0x6000EEA")]
	[Address(RVA = "0x1E6FFA0", Offset = "0x1E700A1", VA = "0x1E6FFA0")]
	public bool InitUpdate()
	{
		return default(bool);
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0x1E700F0", Offset = "0x1E701F1", VA = "0x1E700F0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0x1E704D0", Offset = "0x1E705D1", VA = "0x1E704D0")]
	protected void Update()
	{
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x1E706E0", Offset = "0x1E707E1", VA = "0x1E706E0")]
	protected void LateUpdate()
	{
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x1E70920", Offset = "0x1E70A21", VA = "0x1E70920")]
	public void EndRide()
	{
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00007950 File Offset: 0x00005B50
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0x1E70A20", Offset = "0x1E70B21", VA = "0x1E70A20")]
	public bool DoRide(MonsterControllerBase monster, HumanController[] riders)
	{
		return default(bool);
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0x1E71220", Offset = "0x1E71321", VA = "0x1E71220")]
	public void ResetAction(MonsterControllerBase monster)
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00007968 File Offset: 0x00005B68
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0x1E70F90", Offset = "0x1E71091", VA = "0x1E70F90")]
	private bool CreateRider(HumanController human, ref RideController rider)
	{
		return default(bool);
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0x1E713D0", Offset = "0x1E714D1", VA = "0x1E713D0")]
	private void DeleteRider(ref RideController rider, bool isMoveOnNavmesh, bool onGround)
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0x1E710B0", Offset = "0x1E711B1", VA = "0x1E710B0")]
	private void CreateChair(ref RideChair chair, Transform attachPoint)
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0x1E715F0", Offset = "0x1E716F1", VA = "0x1E715F0")]
	private void DeleteChair(ref RideChair chair)
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x1E701C0", Offset = "0x1E702C1", VA = "0x1E701C0")]
	public void DoEnd(bool onGround = true)
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x1E716D0", Offset = "0x1E717D1", VA = "0x1E716D0")]
	public void OnDamage(DamageResult damageResult, Actor actor)
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x1E71980", Offset = "0x1E71A81", VA = "0x1E71980")]
	public MonsterRideManager()
	{
	}

	// Token: 0x0400093F RID: 2367
	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB30", Offset = "0x15EC31")]
	private bool <IsRiding>k__BackingField;

	// Token: 0x04000940 RID: 2368
	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x20")]
	private MonsterControllerBase m_Monster;

	// Token: 0x04000941 RID: 2369
	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x28")]
	private HumanRideSaddle m_Saddle;

	// Token: 0x04000942 RID: 2370
	[Token(Token = "0x4000750")]
	[FieldOffset(Offset = "0x30")]
	private MonsterRideAnimationType m_RidAnimationType;

	// Token: 0x04000943 RID: 2371
	[Token(Token = "0x4000751")]
	[FieldOffset(Offset = "0x38")]
	private RideController m_Rider1;

	// Token: 0x04000944 RID: 2372
	[Token(Token = "0x4000752")]
	[FieldOffset(Offset = "0x40")]
	private RideController m_Rider2;

	// Token: 0x04000945 RID: 2373
	[Token(Token = "0x4000753")]
	[FieldOffset(Offset = "0x48")]
	private RideChair m_Chair1;

	// Token: 0x04000946 RID: 2374
	[Token(Token = "0x4000754")]
	[FieldOffset(Offset = "0x50")]
	private RideChair m_Chair2;

	// Token: 0x04000947 RID: 2375
	[Token(Token = "0x4000755")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_chairObject;

	// Token: 0x04000948 RID: 2376
	[Token(Token = "0x4000756")]
	[FieldOffset(Offset = "0x60")]
	private RideChair m_chair;

	// Token: 0x04000949 RID: 2377
	[Token(Token = "0x4000757")]
	[FieldOffset(Offset = "0x68")]
	private string m_PrevTag;

	// Token: 0x0400094A RID: 2378
	[Token(Token = "0x4000758")]
	[FieldOffset(Offset = "0x70")]
	public UnityEventMonster RideOnEvent;

	// Token: 0x0400094B RID: 2379
	[Token(Token = "0x4000759")]
	[FieldOffset(Offset = "0x78")]
	public UnityEventMonster RideEndEvent;
}
