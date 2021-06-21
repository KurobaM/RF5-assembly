using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020006A8 RID: 1704
[Token(Token = "0x20004C9")]
public class AracneController : BossMonsterContoroller
{
	// Token: 0x0600297E RID: 10622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002315")]
	[Address(RVA = "0x2438C20", Offset = "0x2438D21", VA = "0x2438C20", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002316")]
	[Address(RVA = "0x2438DC0", Offset = "0x2438EC1", VA = "0x2438DC0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A2360", Offset = "0x1A2461")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x2438E70", Offset = "0x2438F71", VA = "0x2438E70", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002318")]
	[Address(RVA = "0x2438F30", Offset = "0x2439031", VA = "0x2438F30", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002982 RID: 10626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002319")]
	[Address(RVA = "0x2439170", Offset = "0x2439271", VA = "0x2439170", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231A")]
	[Address(RVA = "0x2439210", Offset = "0x2439311", VA = "0x2439210")]
	private void UpdateBulletPointRotation()
	{
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x00010350 File Offset: 0x0000E550
	[Token(Token = "0x600231B")]
	[Address(RVA = "0x2439350", Offset = "0x2439451", VA = "0x2439350")]
	private float GetAngleX(Transform transform, float min, float max)
	{
		return 0f;
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231C")]
	[Address(RVA = "0x2439500", Offset = "0x2439601", VA = "0x2439500")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600231D")]
	[Address(RVA = "0x24399D0", Offset = "0x2439AD1", VA = "0x24399D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A23D0", Offset = "0x1A24D1")]
	private IEnumerator Spawn(int level, Vector3 offset)
	{
		return null;
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231E")]
	[Address(RVA = "0x2439AB0", Offset = "0x2439BB1", VA = "0x2439AB0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600231F")]
	[Address(RVA = "0x2439F30", Offset = "0x243A031", VA = "0x2439F30")]
	public AracneController()
	{
	}

	// Token: 0x040071AE RID: 29102
	[Token(Token = "0x40069A2")]
	private const float ROT_X_MIN = 10f;

	// Token: 0x040071AF RID: 29103
	[Token(Token = "0x40069A3")]
	private const float ROT_X_MAX = 60f;

	// Token: 0x040071B0 RID: 29104
	[Token(Token = "0x40069A4")]
	private const float JUMP_RANGE = 20f;

	// Token: 0x040071B1 RID: 29105
	[Token(Token = "0x40069A5")]
	[FieldOffset(Offset = "0x508")]
	private int MaxVenomCounter;

	// Token: 0x040071B2 RID: 29106
	[Token(Token = "0x40069A6")]
	[FieldOffset(Offset = "0x510")]
	private GameObject AracneFlatWebPrefab;

	// Token: 0x040071B3 RID: 29107
	[Token(Token = "0x40069A7")]
	[FieldOffset(Offset = "0x518")]
	private Vector3 FlatWebScale;

	// Token: 0x040071B4 RID: 29108
	[Token(Token = "0x40069A8")]
	[FieldOffset(Offset = "0x528")]
	public List<MonsterControllerBase> MonsterList;

	// Token: 0x040071B5 RID: 29109
	[Token(Token = "0x40069A9")]
	[FieldOffset(Offset = "0x530")]
	private Transform RapidVenomPoint;

	// Token: 0x040071B6 RID: 29110
	[Token(Token = "0x40069AA")]
	[FieldOffset(Offset = "0x538")]
	private Transform BulletPoint;

	// Token: 0x020006A9 RID: 1705
	[Token(Token = "0x2001168")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158260", Offset = "0x158361")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06002989 RID: 10633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007154")]
		[Address(RVA = "0x2439FE0", Offset = "0x243A0E1", VA = "0x2439FE0")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007155")]
		[Address(RVA = "0x2439FF0", Offset = "0x243A0F1", VA = "0x2439FF0")]
		internal void <OnSetupAsync>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x6007156")]
		[Address(RVA = "0x243A0D0", Offset = "0x243A1D1", VA = "0x243A0D0")]
		internal bool <OnSetupAsync>b__1()
		{
			return default(bool);
		}

		// Token: 0x040071B7 RID: 29111
		[Token(Token = "0x401947F")]
		[FieldOffset(Offset = "0x10")]
		public AracneController <>4__this;

		// Token: 0x040071B8 RID: 29112
		[Token(Token = "0x4019480")]
		[FieldOffset(Offset = "0x18")]
		public bool isComplete;
	}

	// Token: 0x020006AA RID: 1706
	[Token(Token = "0x2001169")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158270", Offset = "0x158371")]
	private sealed class <OnSetupAsync>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007157")]
		[Address(RVA = "0x2438E40", Offset = "0x2438F41", VA = "0x2438E40")]
		[DebuggerHidden]
		public <OnSetupAsync>d__10(int <>1__state)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007158")]
		[Address(RVA = "0x243A890", Offset = "0x243A991", VA = "0x243A890", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x6007159")]
		[Address(RVA = "0x243A8A0", Offset = "0x243A9A1", VA = "0x243A8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0F")]
		private object Current
		{
			[Token(Token = "0x600715A")]
			[Address(RVA = "0x243AA20", Offset = "0x243AB21", VA = "0x243AA20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x243AA30", Offset = "0x243AB31", VA = "0x243AA30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D10")]
		private object Current
		{
			[Token(Token = "0x600715C")]
			[Address(RVA = "0x243AA90", Offset = "0x243AB91", VA = "0x243AA90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040071B9 RID: 29113
		[Token(Token = "0x4019481")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040071BA RID: 29114
		[Token(Token = "0x4019482")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040071BB RID: 29115
		[Token(Token = "0x4019483")]
		[FieldOffset(Offset = "0x20")]
		public AracneController <>4__this;
	}

	// Token: 0x020006AB RID: 1707
	[Token(Token = "0x200116A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158280", Offset = "0x158381")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06002992 RID: 10642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x2439160", Offset = "0x2439261", VA = "0x2439160")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715E")]
		[Address(RVA = "0x243A0E0", Offset = "0x243A1E1", VA = "0x243A0E0")]
		internal void <OnDeadEvent>b__0()
		{
		}

		// Token: 0x040071BC RID: 29116
		[Token(Token = "0x4019484")]
		[FieldOffset(Offset = "0x10")]
		public MonsterControllerBase itm;
	}

	// Token: 0x020006AC RID: 1708
	[Token(Token = "0x200116B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158290", Offset = "0x158391")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600715F")]
		[Address(RVA = "0x24399C0", Offset = "0x2439AC1", VA = "0x24399C0")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007160")]
		[Address(RVA = "0x243A100", Offset = "0x243A201", VA = "0x243A100")]
		internal void <CreateProjectileEvent>b__0(Collider _)
		{
		}

		// Token: 0x040071BD RID: 29117
		[Token(Token = "0x4019485")]
		[FieldOffset(Offset = "0x10")]
		public MonsterProjectileActionScriptsController projectileActionScriptsController;

		// Token: 0x040071BE RID: 29118
		[Token(Token = "0x4019486")]
		[FieldOffset(Offset = "0x18")]
		public AracneController <>4__this;
	}

	// Token: 0x020006AD RID: 1709
	[Token(Token = "0x200116C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1582A0", Offset = "0x1583A1")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007161")]
		[Address(RVA = "0x243A560", Offset = "0x243A661", VA = "0x243A560")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007162")]
		[Address(RVA = "0x243A570", Offset = "0x243A671", VA = "0x243A570")]
		internal void <Spawn>b__0(MonsterControllerBase monster)
		{
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007163")]
		[Address(RVA = "0x243A6D0", Offset = "0x243A7D1", VA = "0x243A6D0")]
		internal void <Spawn>b__1(EnemyBehaviorController behaviorcontroller)
		{
		}

		// Token: 0x040071BF RID: 29119
		[Token(Token = "0x4019487")]
		[FieldOffset(Offset = "0x10")]
		public AracneController <>4__this;

		// Token: 0x040071C0 RID: 29120
		[Token(Token = "0x4019488")]
		[FieldOffset(Offset = "0x18")]
		public MonsterControllerBase controller;

		// Token: 0x040071C1 RID: 29121
		[Token(Token = "0x4019489")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;
	}

	// Token: 0x020006AE RID: 1710
	[Token(Token = "0x200116D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1582B0", Offset = "0x1583B1")]
	private sealed class <>c__DisplayClass17_1
	{
		// Token: 0x06002999 RID: 10649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007164")]
		[Address(RVA = "0x243A6C0", Offset = "0x243A7C1", VA = "0x243A6C0")]
		public <>c__DisplayClass17_1()
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007165")]
		[Address(RVA = "0x243A820", Offset = "0x243A921", VA = "0x243A820")]
		internal void <Spawn>b__2(MonsterControllerBase itm)
		{
		}

		// Token: 0x040071C2 RID: 29122
		[Token(Token = "0x401948A")]
		[FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monster;

		// Token: 0x040071C3 RID: 29123
		[Token(Token = "0x401948B")]
		[FieldOffset(Offset = "0x18")]
		public AracneController.<>c__DisplayClass17_0 CS$<>8__locals1;
	}

	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x200116E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1582C0", Offset = "0x1583C1")]
	private sealed class <Spawn>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600299B RID: 10651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007166")]
		[Address(RVA = "0x2439A80", Offset = "0x2439B81", VA = "0x2439A80")]
		[DebuggerHidden]
		public <Spawn>d__17(int <>1__state)
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007167")]
		[Address(RVA = "0x243AAA0", Offset = "0x243ABA1", VA = "0x243AAA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x6007168")]
		[Address(RVA = "0x243AAB0", Offset = "0x243ABB1", VA = "0x243AAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D11")]
		private object Current
		{
			[Token(Token = "0x6007169")]
			[Address(RVA = "0x243ACD0", Offset = "0x243ADD1", VA = "0x243ACD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600716A")]
		[Address(RVA = "0x243ACE0", Offset = "0x243ADE1", VA = "0x243ACE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D12")]
		private object Current
		{
			[Token(Token = "0x600716B")]
			[Address(RVA = "0x243AD40", Offset = "0x243AE41", VA = "0x243AD40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040071C4 RID: 29124
		[Token(Token = "0x401948C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040071C5 RID: 29125
		[Token(Token = "0x401948D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040071C6 RID: 29126
		[Token(Token = "0x401948E")]
		[FieldOffset(Offset = "0x20")]
		public AracneController <>4__this;

		// Token: 0x040071C7 RID: 29127
		[Token(Token = "0x401948F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		// Token: 0x040071C8 RID: 29128
		[Token(Token = "0x4019490")]
		[FieldOffset(Offset = "0x34")]
		public int level;

		// Token: 0x040071C9 RID: 29129
		[Token(Token = "0x4019491")]
		[FieldOffset(Offset = "0x38")]
		private AracneController.<>c__DisplayClass17_0 <>8__1;
	}
}
