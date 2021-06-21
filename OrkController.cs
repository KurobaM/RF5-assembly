using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200074C RID: 1868
[Token(Token = "0x200050A")]
public class OrkController : MonsterControllerBase
{
	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x00010ED8 File Offset: 0x0000F0D8
	[Token(Token = "0x1700056E")]
	private bool IsRidingWolf
	{
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x2314230", Offset = "0x2314331", VA = "0x2314230")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002846")]
	[Address(RVA = "0x23142A0", Offset = "0x23143A1", VA = "0x23142A0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3FB0", Offset = "0x1A40B1")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x00010EF0 File Offset: 0x0000F0F0
	[Token(Token = "0x6002847")]
	[Address(RVA = "0x2314350", Offset = "0x2314451", VA = "0x2314350")]
	private bool IsRiderOrk()
	{
		return default(bool);
	}

	// Token: 0x06002FD5 RID: 12245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002848")]
	[Address(RVA = "0x2314390", Offset = "0x2314491", VA = "0x2314390", Slot = "105")]
	public override void OnSetupBehavior(MonsterEventReceiverInterface receiver)
	{
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002849")]
	[Address(RVA = "0x23147B0", Offset = "0x23148B1", VA = "0x23147B0", Slot = "66")]
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x00010F08 File Offset: 0x0000F108
	[Token(Token = "0x600284A")]
	[Address(RVA = "0x2314D10", Offset = "0x2314E11", VA = "0x2314D10", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600284B")]
	[Address(RVA = "0x2314F00", Offset = "0x2315001", VA = "0x2314F00", Slot = "64")]
	public override void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x06002FD9 RID: 12249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600284C")]
	[Address(RVA = "0x2314FD0", Offset = "0x23150D1", VA = "0x2314FD0", Slot = "134")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x00010F20 File Offset: 0x0000F120
	[Token(Token = "0x600284D")]
	[Address(RVA = "0x2315060", Offset = "0x2315161", VA = "0x2315060", Slot = "141")]
	public override bool CanGrap(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002FDB RID: 12251 RVA: 0x00010F38 File Offset: 0x0000F138
	[Token(Token = "0x600284E")]
	[Address(RVA = "0x2315120", Offset = "0x2315221", VA = "0x2315120", Slot = "143")]
	public override bool DoGrap(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002FDC RID: 12252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600284F")]
	[Address(RVA = "0x2315310", Offset = "0x2315411", VA = "0x2315310", Slot = "145")]
	protected override void TakeThrowDamage()
	{
	}

	// Token: 0x06002FDD RID: 12253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002850")]
	[Address(RVA = "0x23153A0", Offset = "0x23154A1", VA = "0x23153A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4020", Offset = "0x1A4121")]
	private static IEnumerator CreateRideMonster(OrkController orkController)
	{
		return null;
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002851")]
	[Address(RVA = "0x2314660", Offset = "0x2314761", VA = "0x2314660")]
	private void SetupRideMonster()
	{
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002852")]
	[Address(RVA = "0x2315450", Offset = "0x2315551", VA = "0x2315450")]
	private void RideStart()
	{
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002853")]
	[Address(RVA = "0x2315840", Offset = "0x2315941", VA = "0x2315840")]
	private void OnEndThrow(bool isDamage)
	{
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002854")]
	[Address(RVA = "0x23148A0", Offset = "0x23149A1", VA = "0x23148A0")]
	private void RideEnd()
	{
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002855")]
	[Address(RVA = "0x23155A0", Offset = "0x23156A1", VA = "0x23155A0")]
	private void SetSkinningListEnable(bool isEnable, bool isEnableWeapon)
	{
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002856")]
	[Address(RVA = "0x2315680", Offset = "0x2315781", VA = "0x2315680")]
	private void SetRidePoint()
	{
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002857")]
	[Address(RVA = "0x2315860", Offset = "0x2315961", VA = "0x2315860", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002858")]
	[Address(RVA = "0x23159A0", Offset = "0x2315AA1", VA = "0x23159A0", Slot = "41")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002859")]
	[Address(RVA = "0x2315A30", Offset = "0x2315B31", VA = "0x2315A30")]
	public OrkController()
	{
	}

	// Token: 0x06002FE7 RID: 12263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285A")]
	[Address(RVA = "0x2315AD0", Offset = "0x2315BD1", VA = "0x2315AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4090", Offset = "0x1A4191")]
	[DebuggerHidden]
	private IEnumerator <>n__0()
	{
		return null;
	}

	// Token: 0x04007564 RID: 30052
	[Token(Token = "0x4006BC5")]
	[FieldOffset(Offset = "0x4E8")]
	private MonsterControllerBase m_RideMonster;

	// Token: 0x04007565 RID: 30053
	[Token(Token = "0x4006BC6")]
	[FieldOffset(Offset = "0x4F0")]
	private Transform m_Saddle;

	// Token: 0x04007566 RID: 30054
	[Token(Token = "0x4006BC7")]
	[FieldOffset(Offset = "0x4F8")]
	private Transform m_Hips;

	// Token: 0x04007567 RID: 30055
	[Token(Token = "0x4006BC8")]
	[FieldOffset(Offset = "0x500")]
	private List<SkinnedMeshRenderer> m_SkinningList;

	// Token: 0x04007568 RID: 30056
	[Token(Token = "0x4006BC9")]
	[FieldOffset(Offset = "0x508")]
	private ValueTuple<float, float> CashColliderParam;

	// Token: 0x04007569 RID: 30057
	[Token(Token = "0x4006BCA")]
	[FieldOffset(Offset = "0x510")]
	private EnemyBehaviorController m_BehaviorController;

	// Token: 0x0400756A RID: 30058
	[Token(Token = "0x4006BCB")]
	[FieldOffset(Offset = "0x518")]
	private EnemyBehaviorController m_RideBehaviorController;

	// Token: 0x0400756B RID: 30059
	[Token(Token = "0x4006BCC")]
	[FieldOffset(Offset = "0x520")]
	private OrkController.CashNavMeshAgent cashNavMeshAgent;

	// Token: 0x0400756C RID: 30060
	[Token(Token = "0x4006BCD")]
	[FieldOffset(Offset = "0x554")]
	private bool IsSetupRide;

	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x20011C9")]
	public struct CashNavMeshAgent
	{
		// Token: 0x0400756D RID: 30061
		[Token(Token = "0x4019608")]
		[FieldOffset(Offset = "0x0")]
		public int AgentTypeID;

		// Token: 0x0400756E RID: 30062
		[Token(Token = "0x4019609")]
		[FieldOffset(Offset = "0x4")]
		public float BaseOffset;

		// Token: 0x0400756F RID: 30063
		[Token(Token = "0x401960A")]
		[FieldOffset(Offset = "0x8")]
		public float Speed;

		// Token: 0x04007570 RID: 30064
		[Token(Token = "0x401960B")]
		[FieldOffset(Offset = "0xC")]
		public float AngularSpeed;

		// Token: 0x04007571 RID: 30065
		[Token(Token = "0x401960C")]
		[FieldOffset(Offset = "0x10")]
		public float Acceleration;

		// Token: 0x04007572 RID: 30066
		[Token(Token = "0x401960D")]
		[FieldOffset(Offset = "0x14")]
		public float StoppingDistance;

		// Token: 0x04007573 RID: 30067
		[Token(Token = "0x401960E")]
		[FieldOffset(Offset = "0x18")]
		public bool AutoBraking;

		// Token: 0x04007574 RID: 30068
		[Token(Token = "0x401960F")]
		[FieldOffset(Offset = "0x1C")]
		public float Radius;

		// Token: 0x04007575 RID: 30069
		[Token(Token = "0x4019610")]
		[FieldOffset(Offset = "0x20")]
		public float Height;

		// Token: 0x04007576 RID: 30070
		[Token(Token = "0x4019611")]
		[FieldOffset(Offset = "0x24")]
		public ObstacleAvoidanceType ObstacleAvoidanceType;

		// Token: 0x04007577 RID: 30071
		[Token(Token = "0x4019612")]
		[FieldOffset(Offset = "0x28")]
		public int Priority;

		// Token: 0x04007578 RID: 30072
		[Token(Token = "0x4019613")]
		[FieldOffset(Offset = "0x2C")]
		public bool AutoTraverseOffMeshLink;

		// Token: 0x04007579 RID: 30073
		[Token(Token = "0x4019614")]
		[FieldOffset(Offset = "0x2D")]
		public bool AutoRepath;

		// Token: 0x0400757A RID: 30074
		[Token(Token = "0x4019615")]
		[FieldOffset(Offset = "0x30")]
		public int AreaMask;
	}

	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x20011CA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158610", Offset = "0x158711")]
	private sealed class <OnSetupAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007278")]
		[Address(RVA = "0x2314320", Offset = "0x2314421", VA = "0x2314320")]
		[DebuggerHidden]
		public <OnSetupAsync>d__12(int <>1__state)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007279")]
		[Address(RVA = "0x2316090", Offset = "0x2316191", VA = "0x2316090", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x600727A")]
		[Address(RVA = "0x23160A0", Offset = "0x23161A1", VA = "0x23160A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002FEB RID: 12267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D25")]
		private object Current
		{
			[Token(Token = "0x600727B")]
			[Address(RVA = "0x2316220", Offset = "0x2316321", VA = "0x2316220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727C")]
		[Address(RVA = "0x2316230", Offset = "0x2316331", VA = "0x2316230", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D26")]
		private object Current
		{
			[Token(Token = "0x600727D")]
			[Address(RVA = "0x2316290", Offset = "0x2316391", VA = "0x2316290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400757B RID: 30075
		[Token(Token = "0x4019616")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400757C RID: 30076
		[Token(Token = "0x4019617")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400757D RID: 30077
		[Token(Token = "0x4019618")]
		[FieldOffset(Offset = "0x20")]
		public OrkController <>4__this;
	}

	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x20011CB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158620", Offset = "0x158721")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x06002FEE RID: 12270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727E")]
		[Address(RVA = "0x2315AE0", Offset = "0x2315BE1", VA = "0x2315AE0")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600727F")]
		[Address(RVA = "0x2315AF0", Offset = "0x2315BF1", VA = "0x2315AF0")]
		internal void <CreateRideMonster>b__0(MonsterControllerBase controller)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007280")]
		[Address(RVA = "0x2315B10", Offset = "0x2315C11", VA = "0x2315B10")]
		internal void <CreateRideMonster>b__1(MonsterControllerBase _)
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007281")]
		[Address(RVA = "0x2315B30", Offset = "0x2315C31", VA = "0x2315B30")]
		internal void <CreateRideMonster>b__2(EnemyBehaviorController behaviorcontroller)
		{
		}

		// Token: 0x0400757E RID: 30078
		[Token(Token = "0x4019619")]
		[FieldOffset(Offset = "0x10")]
		public OrkController orkController;
	}

	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x20011CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158630", Offset = "0x158731")]
	private sealed class <CreateRideMonster>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002FF2 RID: 12274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007282")]
		[Address(RVA = "0x2315420", Offset = "0x2315521", VA = "0x2315420")]
		[DebuggerHidden]
		public <CreateRideMonster>d__22(int <>1__state)
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007283")]
		[Address(RVA = "0x2315B50", Offset = "0x2315C51", VA = "0x2315B50", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x6007284")]
		[Address(RVA = "0x2315B60", Offset = "0x2315C61", VA = "0x2315B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002FF5 RID: 12277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D27")]
		private object Current
		{
			[Token(Token = "0x6007285")]
			[Address(RVA = "0x2316010", Offset = "0x2316111", VA = "0x2316010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007286")]
		[Address(RVA = "0x2316020", Offset = "0x2316121", VA = "0x2316020", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D28")]
		private object Current
		{
			[Token(Token = "0x6007287")]
			[Address(RVA = "0x2316080", Offset = "0x2316181", VA = "0x2316080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400757F RID: 30079
		[Token(Token = "0x401961A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007580 RID: 30080
		[Token(Token = "0x401961B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007581 RID: 30081
		[Token(Token = "0x401961C")]
		[FieldOffset(Offset = "0x20")]
		public OrkController orkController;

		// Token: 0x04007582 RID: 30082
		[Token(Token = "0x401961D")]
		[FieldOffset(Offset = "0x28")]
		private OrkController.<>c__DisplayClass22_0 <>8__1;
	}
}
