using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x0200075A RID: 1882
[Token(Token = "0x2000510")]
public class ReviatanController : BossMonsterContoroller
{
	// Token: 0x06003052 RID: 12370 RVA: 0x00010FE0 File Offset: 0x0000F1E0
	[Token(Token = "0x600289D")]
	[Address(RVA = "0x2490010", Offset = "0x2490111", VA = "0x2490010", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x06003053 RID: 12371 RVA: 0x00010FF8 File Offset: 0x0000F1F8
	[Token(Token = "0x600289E")]
	[Address(RVA = "0x2490060", Offset = "0x2490161", VA = "0x2490060", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x06003054 RID: 12372 RVA: 0x00011010 File Offset: 0x0000F210
	// (set) Token: 0x06003055 RID: 12373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700056F")]
	public int MaxIcePillarCount
	{
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x24900B0", Offset = "0x24901B1", VA = "0x24900B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4200", Offset = "0x1A4301")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x24900C0", Offset = "0x24901C1", VA = "0x24900C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4210", Offset = "0x1A4311")]
		set
		{
		}
	}

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x06003056 RID: 12374 RVA: 0x00011028 File Offset: 0x0000F228
	[Token(Token = "0x17000570")]
	public override Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x24900D0", Offset = "0x24901D1", VA = "0x24900D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A2")]
	[Address(RVA = "0x24901B0", Offset = "0x24902B1", VA = "0x24901B0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A3")]
	[Address(RVA = "0x24902F0", Offset = "0x24903F1", VA = "0x24902F0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028A4")]
	[Address(RVA = "0x24904D0", Offset = "0x24905D1", VA = "0x24904D0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4220", Offset = "0x1A4321")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x2490580", Offset = "0x2490681", VA = "0x2490580", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A6")]
	[Address(RVA = "0x24909A0", Offset = "0x2490AA1", VA = "0x24909A0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A7")]
	[Address(RVA = "0x2490CA0", Offset = "0x2490DA1", VA = "0x2490CA0")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A8")]
	[Address(RVA = "0x24905F0", Offset = "0x24906F1", VA = "0x24905F0")]
	private void CursorUpdate()
	{
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x24907B0", Offset = "0x24908B1", VA = "0x24907B0")]
	private void BulletPointRotateUpdate()
	{
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x2490960", Offset = "0x2490A61", VA = "0x2490960")]
	private void TsunamiPointsRotateUpdate()
	{
	}

	// Token: 0x06003060 RID: 12384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x2490F50", Offset = "0x2491051", VA = "0x2490F50", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06003061 RID: 12385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x2491720", Offset = "0x2491821", VA = "0x2491720", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06003062 RID: 12386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x2491C40", Offset = "0x2491D41", VA = "0x2491C40")]
	public ReviatanController()
	{
	}

	// Token: 0x040075B4 RID: 30132
	[Token(Token = "0x4006BEA")]
	[FieldOffset(Offset = "0x508")]
	private Transform MoveCursor;

	// Token: 0x040075B5 RID: 30133
	[Token(Token = "0x4006BEB")]
	[FieldOffset(Offset = "0x510")]
	private Transform CursorTransform;

	// Token: 0x040075B6 RID: 30134
	[Token(Token = "0x4006BEC")]
	[FieldOffset(Offset = "0x518")]
	private float SeekSpeed;

	// Token: 0x040075B7 RID: 30135
	[Token(Token = "0x4006BED")]
	[FieldOffset(Offset = "0x51C")]
	private bool IsSeek;

	// Token: 0x040075B8 RID: 30136
	[Token(Token = "0x4006BEE")]
	[FieldOffset(Offset = "0x520")]
	private int GeyserCounter;

	// Token: 0x040075B9 RID: 30137
	[Token(Token = "0x4006BEF")]
	[FieldOffset(Offset = "0x524")]
	private int GeyserPlusRound;

	// Token: 0x040075BA RID: 30138
	[Token(Token = "0x4006BF0")]
	[FieldOffset(Offset = "0x528")]
	private int GeyserRoundMax;

	// Token: 0x040075BB RID: 30139
	[Token(Token = "0x4006BF1")]
	[FieldOffset(Offset = "0x52C")]
	private int PlusGeyserCount;

	// Token: 0x040075BC RID: 30140
	[Token(Token = "0x4006BF2")]
	[FieldOffset(Offset = "0x530")]
	private Vector3 BlurOffset;

	// Token: 0x040075BD RID: 30141
	[Token(Token = "0x4006BF3")]
	[FieldOffset(Offset = "0x540")]
	private Transform HeadTransform;

	// Token: 0x040075BE RID: 30142
	[Token(Token = "0x4006BF4")]
	[FieldOffset(Offset = "0x548")]
	private Transform BulletPoint;

	// Token: 0x040075BF RID: 30143
	[Token(Token = "0x4006BF5")]
	[FieldOffset(Offset = "0x550")]
	private GameObject IcePillarPrefab;

	// Token: 0x040075C0 RID: 30144
	[Token(Token = "0x4006BF6")]
	[FieldOffset(Offset = "0x558")]
	public List<ReviatanIcePillar> IcePillarList;

	// Token: 0x040075C1 RID: 30145
	[Token(Token = "0x4006BF7")]
	[FieldOffset(Offset = "0x560")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1698F0", Offset = "0x1699F1")]
	private int <MaxIcePillarCount>k__BackingField;

	// Token: 0x040075C2 RID: 30146
	[Token(Token = "0x4006BF8")]
	[FieldOffset(Offset = "0x564")]
	private Vector3 PosOffset;

	// Token: 0x040075C3 RID: 30147
	[Token(Token = "0x4006BF9")]
	[FieldOffset(Offset = "0x570")]
	private Vector3 RotOffset;

	// Token: 0x040075C4 RID: 30148
	[Token(Token = "0x4006BFA")]
	[FieldOffset(Offset = "0x57C")]
	private Vector3 IcePillarScale;

	// Token: 0x040075C5 RID: 30149
	[Token(Token = "0x4006BFB")]
	[FieldOffset(Offset = "0x588")]
	private bool IsTsunami;

	// Token: 0x040075C6 RID: 30150
	[Token(Token = "0x4006BFC")]
	[FieldOffset(Offset = "0x589")]
	private bool IsSky;

	// Token: 0x040075C7 RID: 30151
	[Token(Token = "0x4006BFD")]
	[FieldOffset(Offset = "0x590")]
	private Transform TsunamiTransform;

	// Token: 0x040075C8 RID: 30152
	[Token(Token = "0x4006BFE")]
	[FieldOffset(Offset = "0x598")]
	private Quaternion TsunamiDirection;

	// Token: 0x040075C9 RID: 30153
	[Token(Token = "0x4006BFF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 LOCKONOFFSET;

	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x20011D1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158680", Offset = "0x158781")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x06003064 RID: 12388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0x2491E00", Offset = "0x2491F01", VA = "0x2491E00")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A1")]
		[Address(RVA = "0x2491E10", Offset = "0x2491F11", VA = "0x2491E10")]
		internal void <OnSetupAsync>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x60072A2")]
		[Address(RVA = "0x2491EF0", Offset = "0x2491FF1", VA = "0x2491EF0")]
		internal bool <OnSetupAsync>b__1()
		{
			return default(bool);
		}

		// Token: 0x040075CA RID: 30154
		[Token(Token = "0x4019633")]
		[FieldOffset(Offset = "0x10")]
		public ReviatanController <>4__this;

		// Token: 0x040075CB RID: 30155
		[Token(Token = "0x4019634")]
		[FieldOffset(Offset = "0x18")]
		public bool isComplete;
	}

	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x20011D2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158690", Offset = "0x158791")]
	private sealed class <OnSetupAsync>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003067 RID: 12391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A3")]
		[Address(RVA = "0x2490550", Offset = "0x2490651", VA = "0x2490550")]
		[DebuggerHidden]
		public <OnSetupAsync>d__31(int <>1__state)
		{
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A4")]
		[Address(RVA = "0x2491F70", Offset = "0x2492071", VA = "0x2491F70", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x60072A5")]
		[Address(RVA = "0x2491F80", Offset = "0x2492081", VA = "0x2491F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D29")]
		private object Current
		{
			[Token(Token = "0x60072A6")]
			[Address(RVA = "0x2492100", Offset = "0x2492201", VA = "0x2492100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A7")]
		[Address(RVA = "0x2492110", Offset = "0x2492211", VA = "0x2492110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2A")]
		private object Current
		{
			[Token(Token = "0x60072A8")]
			[Address(RVA = "0x2492170", Offset = "0x2492271", VA = "0x2492170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040075CC RID: 30156
		[Token(Token = "0x4019635")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040075CD RID: 30157
		[Token(Token = "0x4019636")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040075CE RID: 30158
		[Token(Token = "0x4019637")]
		[FieldOffset(Offset = "0x20")]
		public ReviatanController <>4__this;
	}

	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x20011D3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1586A0", Offset = "0x1587A1")]
	private sealed class <>c__DisplayClass39_0
	{
		// Token: 0x0600306D RID: 12397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A9")]
		[Address(RVA = "0x2491B00", Offset = "0x2491C01", VA = "0x2491B00")]
		public <>c__DisplayClass39_0()
		{
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0x2491F00", Offset = "0x2492001", VA = "0x2491F00")]
		internal void <OnUniqueProjectileActionCommandInternal>b__0()
		{
		}

		// Token: 0x040075CF RID: 30159
		[Token(Token = "0x4019638")]
		[FieldOffset(Offset = "0x10")]
		public ReviatanIcePillar icePillar;

		// Token: 0x040075D0 RID: 30160
		[Token(Token = "0x4019639")]
		[FieldOffset(Offset = "0x18")]
		public ReviatanController <>4__this;
	}
}
