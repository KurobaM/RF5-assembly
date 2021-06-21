using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200066D RID: 1645
[Token(Token = "0x2000495")]
public class BossStageManager : MonoBehaviour
{
	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000100C8 File Offset: 0x0000E2C8
	[Token(Token = "0x17000531")]
	public int StageIndex
	{
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x218A450", Offset = "0x218A551", VA = "0x218A450")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000100E0 File Offset: 0x0000E2E0
	// (set) Token: 0x060028CA RID: 10442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000532")]
	public bool CheckBattleNow
	{
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x218A460", Offset = "0x218A561", VA = "0x218A460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x218A470", Offset = "0x218A571", VA = "0x218A470")]
		protected set
		{
		}
	}

	// Token: 0x060028CB RID: 10443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002281")]
	[Address(RVA = "0x218A480", Offset = "0x218A581", VA = "0x218A480")]
	private void SetCheckForceActiveWallFlag(bool isCheck)
	{
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002282")]
	[Address(RVA = "0x218A4A0", Offset = "0x218A5A1", VA = "0x218A4A0", Slot = "4")]
	protected virtual void Start()
	{
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002283")]
	[Address(RVA = "0x218A4B0", Offset = "0x218A5B1", VA = "0x218A4B0")]
	private void UpdateActiveWallFlag()
	{
	}

	// Token: 0x060028CE RID: 10446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002284")]
	[Address(RVA = "0x218A7A0", Offset = "0x218A8A1", VA = "0x218A7A0")]
	private void Update()
	{
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002285")]
	[Address(RVA = "0x218A870", Offset = "0x218A971", VA = "0x218A870")]
	public void Setup(GateDataTable gateDataTable)
	{
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002286")]
	[Address(RVA = "0x218A8E0", Offset = "0x218A9E1", VA = "0x218A8E0")]
	public void Play(int eventStatusIndex = 0, [Optional] Action<BossBehaviorController> callBack)
	{
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002287")]
	[Address(RVA = "0x218A990", Offset = "0x218AA91", VA = "0x218A990")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A2160", Offset = "0x1A2261")]
	private IEnumerator AsyncPlay(int eventStatusIndex = 0, [Optional] Action<BossBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002288")]
	[Address(RVA = "0x218AA60", Offset = "0x218AB61", VA = "0x218AA60", Slot = "5")]
	protected virtual void OnSetup()
	{
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002289")]
	[Address(RVA = "0x218AA70", Offset = "0x218AB71", VA = "0x218AA70", Slot = "6")]
	protected virtual void OnBeforeCreateBoss()
	{
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600228A")]
	[Address(RVA = "0x218AA80", Offset = "0x218AB81", VA = "0x218AA80", Slot = "7")]
	protected virtual void OnAfterCreateBoss(BossBehaviorController controller)
	{
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600228B")]
	[Address(RVA = "0x218AA90", Offset = "0x218AB91", VA = "0x218AA90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A21D0", Offset = "0x1A22D1")]
	private IEnumerator CreateBoss(int eventStatusIndex, [Optional] Action<BossBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600228C")]
	[Address(RVA = "0x218AB60", Offset = "0x218AC61", VA = "0x218AB60")]
	public void DestroyBoss()
	{
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600228D")]
	[Address(RVA = "0x218AC20", Offset = "0x218AD21", VA = "0x218AC20")]
	private void OnDeadBoss(MonsterControllerBase monsterControllerBase)
	{
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600228E")]
	[Address(RVA = "0x218A570", Offset = "0x218A671", VA = "0x218A570")]
	private void SetActiveWalls(bool isActive)
	{
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600228F")]
	[Address(RVA = "0x218ACB0", Offset = "0x218ADB1", VA = "0x218ACB0")]
	public string GetEmergenceBossName(int eventStatusIndex)
	{
		return null;
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002290")]
	[Address(RVA = "0x218AE00", Offset = "0x218AF01", VA = "0x218AE00")]
	private void UpdateRematchObjectDisplayFlag()
	{
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x000100F8 File Offset: 0x0000E2F8
	[Token(Token = "0x6002291")]
	[Address(RVA = "0x218AF00", Offset = "0x218B001", VA = "0x218AF00")]
	private bool CheckRematchDisplayFlag(int RematchDisplayFlag, string objectName)
	{
		return default(bool);
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002292")]
	[Address(RVA = "0x218A6C0", Offset = "0x218A7C1", VA = "0x218A6C0")]
	private void SetDisplayRematchObject(bool isDisplay)
	{
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002293")]
	[Address(RVA = "0x218B030", Offset = "0x218B131", VA = "0x218B030")]
	public void WarpPartnerPosition()
	{
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002294")]
	[Address(RVA = "0x218B110", Offset = "0x218B211", VA = "0x218B110")]
	public BossStageManager()
	{
	}

	// Token: 0x0400706B RID: 28779
	[Token(Token = "0x400687A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1687B0", Offset = "0x1688B1")]
	[SerializeField]
	public GateDataID GateDataID;

	// Token: 0x0400706C RID: 28780
	[Token(Token = "0x400687B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168800", Offset = "0x168901")]
	[SerializeField]
	private int _StageIndex;

	// Token: 0x0400706D RID: 28781
	[Token(Token = "0x400687C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GateDataTable CurrentGateDataTable;

	// Token: 0x0400706E RID: 28782
	[Token(Token = "0x400687D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GateStatusDataTable CurrentGateStatusDataTable;

	// Token: 0x0400706F RID: 28783
	[Token(Token = "0x400687E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MonsterControllerBase InstantiateBoss;

	// Token: 0x04007070 RID: 28784
	[Token(Token = "0x400687F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public Transform AppearBossTransform;

	// Token: 0x04007071 RID: 28785
	[Token(Token = "0x4006880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Transform WarpFriendlyTransform;

	// Token: 0x04007072 RID: 28786
	[Token(Token = "0x4006881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> Walls;

	// Token: 0x04007073 RID: 28787
	[Token(Token = "0x4006882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168880", Offset = "0x168981")]
	[SerializeField]
	public GameFlagData FirstKill_Boss_Flag;

	// Token: 0x04007074 RID: 28788
	[Token(Token = "0x4006883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1688D0", Offset = "0x1689D1")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1688D0", Offset = "0x1689D1")]
	[SerializeField]
	private GameObject RematchObject;

	// Token: 0x04007075 RID: 28789
	[Token(Token = "0x4006884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168950", Offset = "0x168A51")]
	[SerializeField]
	public GameFlagData RematchDisplayFlag;

	// Token: 0x04007076 RID: 28790
	[Token(Token = "0x4006885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1689B0", Offset = "0x168AB1")]
	[SerializeField]
	public GameFlagData RematchNotDisplayFlag;

	// Token: 0x04007077 RID: 28791
	[Token(Token = "0x4006886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168A10", Offset = "0x168B11")]
	[SerializeField]
	public GameFlagData ForceActiveWallFlag;

	// Token: 0x04007078 RID: 28792
	[Token(Token = "0x4006887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool CheckForceActiveWallFlag;

	// Token: 0x04007079 RID: 28793
	[Token(Token = "0x4006888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	private bool IsForceActiveWall;

	// Token: 0x0400707A RID: 28794
	[Token(Token = "0x4006889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	private bool IsActiveRematchObject;

	// Token: 0x0400707B RID: 28795
	[Token(Token = "0x400688A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public OnDeadEventBossStage OnDeadEventBossStage;

	// Token: 0x0400707C RID: 28796
	[Token(Token = "0x400688B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected bool _IsBattleNow;

	// Token: 0x0400707D RID: 28797
	[Token(Token = "0x400688C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, GameFlagData> BossRematchObjectInActiveFlagDict;

	// Token: 0x0200066E RID: 1646
	[Token(Token = "0x2001161")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158200", Offset = "0x158301")]
	private sealed class <AsyncPlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060028E0 RID: 10464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007135")]
		[Address(RVA = "0x218AA30", Offset = "0x218AB31", VA = "0x218AA30")]
		[DebuggerHidden]
		public <AsyncPlay>d__30(int <>1__state)
		{
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007136")]
		[Address(RVA = "0x218B340", Offset = "0x218B441", VA = "0x218B340", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6007137")]
		[Address(RVA = "0x218B350", Offset = "0x218B451", VA = "0x218B350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0B")]
		private object Current
		{
			[Token(Token = "0x6007138")]
			[Address(RVA = "0x218B450", Offset = "0x218B551", VA = "0x218B450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007139")]
		[Address(RVA = "0x218B460", Offset = "0x218B561", VA = "0x218B460", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0C")]
		private object Current
		{
			[Token(Token = "0x600713A")]
			[Address(RVA = "0x218B4C0", Offset = "0x218B5C1", VA = "0x218B4C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400707E RID: 28798
		[Token(Token = "0x4019464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400707F RID: 28799
		[Token(Token = "0x4019465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007080 RID: 28800
		[Token(Token = "0x4019466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossStageManager <>4__this;

		// Token: 0x04007081 RID: 28801
		[Token(Token = "0x4019467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int eventStatusIndex;

		// Token: 0x04007082 RID: 28802
		[Token(Token = "0x4019468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<BossBehaviorController> callBack;
	}

	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x2001162")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158210", Offset = "0x158311")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x060028E6 RID: 10470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713B")]
		[Address(RVA = "0x218B270", Offset = "0x218B371", VA = "0x218B270")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713C")]
		[Address(RVA = "0x218B280", Offset = "0x218B381", VA = "0x218B280")]
		internal void <CreateBoss>b__0(MonsterControllerBase instantiate)
		{
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713D")]
		[Address(RVA = "0x218B2A0", Offset = "0x218B3A1", VA = "0x218B2A0")]
		internal void <CreateBoss>b__1(BossBehaviorController bosscontroller)
		{
		}

		// Token: 0x04007083 RID: 28803
		[Token(Token = "0x4019469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BossStageManager <>4__this;

		// Token: 0x04007084 RID: 28804
		[Token(Token = "0x401946A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BossBehaviorController controller;
	}

	// Token: 0x02000670 RID: 1648
	[Token(Token = "0x2001163")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158220", Offset = "0x158321")]
	private sealed class <CreateBoss>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060028E9 RID: 10473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713E")]
		[Address(RVA = "0x218AB30", Offset = "0x218AC31", VA = "0x218AB30")]
		[DebuggerHidden]
		public <CreateBoss>d__34(int <>1__state)
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600713F")]
		[Address(RVA = "0x218B4D0", Offset = "0x218B5D1", VA = "0x218B4D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6007140")]
		[Address(RVA = "0x218B4E0", Offset = "0x218B5E1", VA = "0x218B4E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0D")]
		private object Current
		{
			[Token(Token = "0x6007141")]
			[Address(RVA = "0x218B930", Offset = "0x218BA31", VA = "0x218B930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007142")]
		[Address(RVA = "0x218B940", Offset = "0x218BA41", VA = "0x218B940", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0E")]
		private object Current
		{
			[Token(Token = "0x6007143")]
			[Address(RVA = "0x218B9A0", Offset = "0x218BAA1", VA = "0x218B9A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007085 RID: 28805
		[Token(Token = "0x401946B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007086 RID: 28806
		[Token(Token = "0x401946C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007087 RID: 28807
		[Token(Token = "0x401946D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossStageManager <>4__this;

		// Token: 0x04007088 RID: 28808
		[Token(Token = "0x401946E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int eventStatusIndex;

		// Token: 0x04007089 RID: 28809
		[Token(Token = "0x401946F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BossStageManager.<>c__DisplayClass34_0 <>8__1;

		// Token: 0x0400708A RID: 28810
		[Token(Token = "0x4019470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<BossBehaviorController> callBack;
	}
}
