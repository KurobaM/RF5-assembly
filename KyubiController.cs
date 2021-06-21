using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000734 RID: 1844
[Token(Token = "0x2000501")]
public class KyubiController : BossMonsterContoroller
{
	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06002EEC RID: 12012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700056A")]
	private Transform TailTransform
	{
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x22F9AC0", Offset = "0x22F9BC1", VA = "0x22F9AC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002789")]
	[Address(RVA = "0x22F9BD0", Offset = "0x22F9CD1", VA = "0x22F9BD0", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278A")]
	[Address(RVA = "0x22F9BE0", Offset = "0x22F9CE1", VA = "0x22F9BE0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278B")]
	[Address(RVA = "0x22F9BF0", Offset = "0x22F9CF1", VA = "0x22F9BF0", Slot = "115")]
	protected override void OnSetupMonsterAnimationEvent(MonsterAnimatorStateEvent monsterAnimatorStateEvent)
	{
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278C")]
	[Address(RVA = "0x22F9C00", Offset = "0x22F9D01", VA = "0x22F9C00", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278D")]
	[Address(RVA = "0x22F9D60", Offset = "0x22F9E61", VA = "0x22F9D60")]
	private void StartJumpEvent()
	{
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278E")]
	[Address(RVA = "0x22F9DC0", Offset = "0x22F9EC1", VA = "0x22F9DC0")]
	private void EndJumpEvent()
	{
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600278F")]
	[Address(RVA = "0x22F9DD0", Offset = "0x22F9ED1", VA = "0x22F9DD0")]
	private void Attack2SE01()
	{
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002790")]
	[Address(RVA = "0x22F9E30", Offset = "0x22F9F31", VA = "0x22F9E30")]
	private void Attack3SE01()
	{
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002791")]
	[Address(RVA = "0x22F9E90", Offset = "0x22F9F91", VA = "0x22F9E90")]
	private void Attack3SE02()
	{
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002792")]
	[Address(RVA = "0x22F9EF0", Offset = "0x22F9FF1", VA = "0x22F9EF0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A3C30", Offset = "0x1A3D31")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002793")]
	[Address(RVA = "0x22F9C30", Offset = "0x22F9D31", VA = "0x22F9C30")]
	private void RemoveFireBallPrefab()
	{
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002794")]
	[Address(RVA = "0x22F9FA0", Offset = "0x22FA0A1", VA = "0x22F9FA0")]
	private void FireballSpawn(Vector3 readyAttackPosition)
	{
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002795")]
	[Address(RVA = "0x22FA4A0", Offset = "0x22FA5A1", VA = "0x22FA4A0")]
	public void CreateProjectile()
	{
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002796")]
	[Address(RVA = "0x22FAAD0", Offset = "0x22FABD1", VA = "0x22FAAD0")]
	private void UpdateCreateFireBall()
	{
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002797")]
	[Address(RVA = "0x22FAC90", Offset = "0x22FAD91", VA = "0x22FAC90")]
	public void StartJump()
	{
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002798")]
	[Address(RVA = "0x22FAD50", Offset = "0x22FAE51", VA = "0x22FAD50")]
	public void StartForcus()
	{
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002799")]
	[Address(RVA = "0x22FAEB0", Offset = "0x22FAFB1", VA = "0x22FAEB0")]
	public void StartAttack()
	{
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279A")]
	[Address(RVA = "0x22FAFD0", Offset = "0x22FB0D1", VA = "0x22FAFD0")]
	private void StartBrake()
	{
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279B")]
	[Address(RVA = "0x22FB030", Offset = "0x22FB131", VA = "0x22FB030")]
	private void UpdateJumpState()
	{
	}

	// Token: 0x06002F00 RID: 12032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279C")]
	[Address(RVA = "0x22FB1B0", Offset = "0x22FB2B1", VA = "0x22FB1B0")]
	private void UpdateFocusState()
	{
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279D")]
	[Address(RVA = "0x22FB310", Offset = "0x22FB411", VA = "0x22FB310")]
	private void UpdateAttackState()
	{
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279E")]
	[Address(RVA = "0x22FB5D0", Offset = "0x22FB6D1", VA = "0x22FB5D0")]
	private void UpdateBrakeState()
	{
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600279F")]
	[Address(RVA = "0x22FB6D0", Offset = "0x22FB7D1", VA = "0x22FB6D0")]
	private void UpdateJumpAttack()
	{
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x22FB940", Offset = "0x22FBA41", VA = "0x22FB940")]
	private void UpdateGroundHeight()
	{
	}

	// Token: 0x06002F05 RID: 12037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x22FBB10", Offset = "0x22FBC11", VA = "0x22FBB10")]
	private void EndJumpAttack()
	{
	}

	// Token: 0x06002F06 RID: 12038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x22FBBB0", Offset = "0x22FBCB1", VA = "0x22FBBB0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A3")]
	[Address(RVA = "0x22FBBE0", Offset = "0x22FBCE1", VA = "0x22FBBE0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x22FBD60", Offset = "0x22FBE61", VA = "0x22FBD60", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x22FBD90", Offset = "0x22FBE91", VA = "0x22FBD90")]
	public KyubiController()
	{
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x22FBF60", Offset = "0x22FC061", VA = "0x22FBF60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3CA0", Offset = "0x1A3DA1")]
	private void <OnSetupAsync>b__35_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x22FBFF0", Offset = "0x22FC0F1", VA = "0x22FBFF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3CB0", Offset = "0x1A3DB1")]
	private void <OnSetupAsync>b__35_1(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x22FC080", Offset = "0x22FC181", VA = "0x22FC080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3CC0", Offset = "0x1A3DC1")]
	[DebuggerHidden]
	private IEnumerator <>n__0()
	{
		return null;
	}

	// Token: 0x040074B3 RID: 29875
	[Token(Token = "0x4006B43")]
	[FieldOffset(Offset = "0x508")]
	private List<KyubiController.FireballParameter> CreateFireBallParameterList;

	// Token: 0x040074B4 RID: 29876
	[Token(Token = "0x4006B44")]
	[FieldOffset(Offset = "0x510")]
	private List<float> AttackReadyPositionZList;

	// Token: 0x040074B5 RID: 29877
	[Token(Token = "0x4006B45")]
	[FieldOffset(Offset = "0x518")]
	private List<float> AttackReadyAngleList;

	// Token: 0x040074B6 RID: 29878
	[Token(Token = "0x4006B46")]
	[FieldOffset(Offset = "0x520")]
	private float AddAttackReadyAngle;

	// Token: 0x040074B7 RID: 29879
	[Token(Token = "0x4006B47")]
	[FieldOffset(Offset = "0x528")]
	private List<float> AttackReadyLengthList;

	// Token: 0x040074B8 RID: 29880
	[Token(Token = "0x4006B48")]
	[FieldOffset(Offset = "0x530")]
	private float FireBallTimer;

	// Token: 0x040074B9 RID: 29881
	[Token(Token = "0x4006B49")]
	[FieldOffset(Offset = "0x538")]
	private Transform _TailTransform;

	// Token: 0x040074BA RID: 29882
	[Token(Token = "0x4006B4A")]
	[FieldOffset(Offset = "0x540")]
	private Vector3 GroundPosition;

	// Token: 0x040074BB RID: 29883
	[Token(Token = "0x4006B4B")]
	[FieldOffset(Offset = "0x54C")]
	private KyubiController.JumpAttackState CurrentJumpAttackState;

	// Token: 0x040074BC RID: 29884
	[Token(Token = "0x4006B4C")]
	[FieldOffset(Offset = "0x550")]
	private Vector3 MoveDirection;

	// Token: 0x040074BD RID: 29885
	[Token(Token = "0x4006B4D")]
	[FieldOffset(Offset = "0x55C")]
	private float MoveSpeed;

	// Token: 0x040074BE RID: 29886
	[Token(Token = "0x4006B4E")]
	[FieldOffset(Offset = "0x560")]
	private float JumpSpeed;

	// Token: 0x040074BF RID: 29887
	[Token(Token = "0x4006B4F")]
	[FieldOffset(Offset = "0x564")]
	private float ForcusSpeed;

	// Token: 0x040074C0 RID: 29888
	[Token(Token = "0x4006B50")]
	[FieldOffset(Offset = "0x568")]
	private float AttackSpeed;

	// Token: 0x040074C1 RID: 29889
	[Token(Token = "0x4006B51")]
	[FieldOffset(Offset = "0x56C")]
	private float T;

	// Token: 0x040074C2 RID: 29890
	[Token(Token = "0x4006B52")]
	[FieldOffset(Offset = "0x570")]
	private int BlueCount;

	// Token: 0x040074C3 RID: 29891
	[Token(Token = "0x4006B53")]
	[FieldOffset(Offset = "0x574")]
	private int MaxBlueCount;

	// Token: 0x040074C4 RID: 29892
	[Token(Token = "0x4006B54")]
	[FieldOffset(Offset = "0x578")]
	private string RedFireActionScriptName;

	// Token: 0x040074C5 RID: 29893
	[Token(Token = "0x4006B55")]
	[FieldOffset(Offset = "0x580")]
	private string BlueFireActionScriptName;

	// Token: 0x040074C6 RID: 29894
	[Token(Token = "0x4006B56")]
	[FieldOffset(Offset = "0x588")]
	private GameObject FireBlueBall;

	// Token: 0x040074C7 RID: 29895
	[Token(Token = "0x4006B57")]
	[FieldOffset(Offset = "0x590")]
	private GameObject FireRedBall;

	// Token: 0x040074C8 RID: 29896
	[Token(Token = "0x4006B58")]
	[FieldOffset(Offset = "0x598")]
	private int LoadCount;

	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x20011BA")]
	public class FireballParameter
	{
		// Token: 0x06002F0D RID: 12045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600724F")]
		[Address(RVA = "0x22FAAC0", Offset = "0x22FABC1", VA = "0x22FAAC0")]
		public FireballParameter()
		{
		}

		// Token: 0x040074C9 RID: 29897
		[Token(Token = "0x40195D9")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 ReadyAttackPosition;

		// Token: 0x040074CA RID: 29898
		[Token(Token = "0x40195DA")]
		[FieldOffset(Offset = "0x1C")]
		public float CreateTime;
	}

	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x20011BB")]
	private enum JumpAttackState
	{
		// Token: 0x040074CC RID: 29900
		[Token(Token = "0x40195DC")]
		None,
		// Token: 0x040074CD RID: 29901
		[Token(Token = "0x40195DD")]
		Jump,
		// Token: 0x040074CE RID: 29902
		[Token(Token = "0x40195DE")]
		Focus,
		// Token: 0x040074CF RID: 29903
		[Token(Token = "0x40195DF")]
		Attack,
		// Token: 0x040074D0 RID: 29904
		[Token(Token = "0x40195E0")]
		Brake
	}

	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x20011BC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158550", Offset = "0x158651")]
	private sealed class <OnSetupAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002F0E RID: 12046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007250")]
		[Address(RVA = "0x22F9F70", Offset = "0x22FA071", VA = "0x22F9F70")]
		[DebuggerHidden]
		public <OnSetupAsync>d__35(int <>1__state)
		{
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007251")]
		[Address(RVA = "0x22FC120", Offset = "0x22FC221", VA = "0x22FC120", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		[Token(Token = "0x6007252")]
		[Address(RVA = "0x22FC130", Offset = "0x22FC231", VA = "0x22FC130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D23")]
		private object Current
		{
			[Token(Token = "0x6007253")]
			[Address(RVA = "0x22FC350", Offset = "0x22FC451", VA = "0x22FC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007254")]
		[Address(RVA = "0x22FC360", Offset = "0x22FC461", VA = "0x22FC360", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D24")]
		private object Current
		{
			[Token(Token = "0x6007255")]
			[Address(RVA = "0x22FC3C0", Offset = "0x22FC4C1", VA = "0x22FC3C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040074D1 RID: 29905
		[Token(Token = "0x40195E1")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040074D2 RID: 29906
		[Token(Token = "0x40195E2")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040074D3 RID: 29907
		[Token(Token = "0x40195E3")]
		[FieldOffset(Offset = "0x20")]
		public KyubiController <>4__this;
	}

	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x20011BD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158560", Offset = "0x158661")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002F15 RID: 12053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007257")]
		[Address(RVA = "0x22FC100", Offset = "0x22FC201", VA = "0x22FC100")]
		public <>c()
		{
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		[Token(Token = "0x6007258")]
		[Address(RVA = "0x22FC110", Offset = "0x22FC211", VA = "0x22FC110")]
		internal bool <UpdateCreateFireBall>b__39_0(KyubiController.FireballParameter createParameter)
		{
			return default(bool);
		}

		// Token: 0x040074D4 RID: 29908
		[Token(Token = "0x40195E4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly KyubiController.<>c <>9;

		// Token: 0x040074D5 RID: 29909
		[Token(Token = "0x40195E5")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<KyubiController.FireballParameter> <>9__39_0;
	}
}
