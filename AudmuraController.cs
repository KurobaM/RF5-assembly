using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020006B7 RID: 1719
[Token(Token = "0x20004CF")]
public class AudmuraController : BossMonsterContoroller
{
	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x060029FE RID: 10750 RVA: 0x00010410 File Offset: 0x0000E610
	// (set) Token: 0x060029FF RID: 10751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700053F")]
	public int CrystalHP
	{
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x2447410", Offset = "0x2447511", VA = "0x2447410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2570", Offset = "0x1A2671")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x2447420", Offset = "0x2447521", VA = "0x2447420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2580", Offset = "0x1A2681")]
		set
		{
		}
	}

	// Token: 0x06002A00 RID: 10752 RVA: 0x00010428 File Offset: 0x0000E628
	[Token(Token = "0x600236B")]
	[Address(RVA = "0x2447430", Offset = "0x2447531", VA = "0x2447430", Slot = "104")]
	public override bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x06002A01 RID: 10753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600236C")]
	[Address(RVA = "0x2447480", Offset = "0x2447581", VA = "0x2447480", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600236D")]
	[Address(RVA = "0x2447540", Offset = "0x2447641", VA = "0x2447540", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600236E")]
	[Address(RVA = "0x24476E0", Offset = "0x24477E1", VA = "0x24476E0", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A2590", Offset = "0x1A2691")]
	protected override IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600236F")]
	[Address(RVA = "0x2447760", Offset = "0x2447861", VA = "0x2447760", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002A05 RID: 10757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002370")]
	[Address(RVA = "0x2447A80", Offset = "0x2447B81", VA = "0x2447A80")]
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex)
	{
	}

	// Token: 0x06002A06 RID: 10758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002371")]
	[Address(RVA = "0x24480B0", Offset = "0x24481B1", VA = "0x24480B0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002372")]
	[Address(RVA = "0x24482D0", Offset = "0x24483D1", VA = "0x24482D0")]
	private void OnEmission()
	{
	}

	// Token: 0x06002A08 RID: 10760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002373")]
	[Address(RVA = "0x24482C0", Offset = "0x24483C1", VA = "0x24482C0")]
	private void OffEmission()
	{
	}

	// Token: 0x06002A09 RID: 10761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002374")]
	[Address(RVA = "0x2447800", Offset = "0x2447901", VA = "0x2447800")]
	private void EmissionUpdate()
	{
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x00010440 File Offset: 0x0000E640
	[Token(Token = "0x6002375")]
	[Address(RVA = "0x2447F60", Offset = "0x2448061", VA = "0x2447F60")]
	public Vector3 GetLaserNextPos()
	{
		return default(Vector3);
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002376")]
	[Address(RVA = "0x24482E0", Offset = "0x24483E1", VA = "0x24482E0", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002377")]
	[Address(RVA = "0x24486C0", Offset = "0x24487C1", VA = "0x24486C0", Slot = "133")]
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002378")]
	[Address(RVA = "0x2448A30", Offset = "0x2448B31", VA = "0x2448A30")]
	public AudmuraController()
	{
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00010458 File Offset: 0x0000E658
	[Token(Token = "0x6002379")]
	[Address(RVA = "0x2448AD0", Offset = "0x2448BD1", VA = "0x2448AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A2600", Offset = "0x1A2701")]
	private bool <CreateProjectileEvent>b__20_1(NavMeshHit hit)
	{
		return default(bool);
	}

	// Token: 0x040071F7 RID: 29175
	[Token(Token = "0x40069C6")]
	private const string EMISSION_COLOR = "_EmissionColor";

	// Token: 0x040071F8 RID: 29176
	[Token(Token = "0x40069C7")]
	[FieldOffset(Offset = "0x508")]
	private AudmuraCrystal CrystalObj;

	// Token: 0x040071F9 RID: 29177
	[Token(Token = "0x40069C8")]
	[FieldOffset(Offset = "0x510")]
	private List<AudmuraCrystal> AudmuraCrystalList;

	// Token: 0x040071FA RID: 29178
	[Token(Token = "0x40069C9")]
	[FieldOffset(Offset = "0x518")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1694F0", Offset = "0x1695F1")]
	private int <CrystalHP>k__BackingField;

	// Token: 0x040071FB RID: 29179
	[Token(Token = "0x40069CA")]
	[FieldOffset(Offset = "0x51C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169500", Offset = "0x169601")]
	public float FadeInOutTime;

	// Token: 0x040071FC RID: 29180
	[Token(Token = "0x40069CB")]
	[FieldOffset(Offset = "0x520")]
	public float LoopSpeed;

	// Token: 0x040071FD RID: 29181
	[Token(Token = "0x40069CC")]
	[FieldOffset(Offset = "0x524")]
	[Attribute(Name = "RangeAttribute", RVA = "0x169540", Offset = "0x169641")]
	public float LoopRatio;

	// Token: 0x040071FE RID: 29182
	[Token(Token = "0x40069CD")]
	[FieldOffset(Offset = "0x528")]
	private AudmuraController.EmissionState _EmissionState;

	// Token: 0x040071FF RID: 29183
	[Token(Token = "0x40069CE")]
	[FieldOffset(Offset = "0x530")]
	private Material BodyMaterial;

	// Token: 0x04007200 RID: 29184
	[Token(Token = "0x40069CF")]
	[FieldOffset(Offset = "0x538")]
	private Color DefaultEmissionColor;

	// Token: 0x04007201 RID: 29185
	[Token(Token = "0x40069D0")]
	[FieldOffset(Offset = "0x548")]
	private float EmissionAlphaTimer;

	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x2001171")]
	private enum EmissionState
	{
		// Token: 0x04007203 RID: 29187
		[Token(Token = "0x40194A5")]
		None,
		// Token: 0x04007204 RID: 29188
		[Token(Token = "0x40194A6")]
		Start,
		// Token: 0x04007205 RID: 29189
		[Token(Token = "0x40194A7")]
		Loop,
		// Token: 0x04007206 RID: 29190
		[Token(Token = "0x40194A8")]
		End
	}

	// Token: 0x020006B9 RID: 1721
	[Token(Token = "0x2001172")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1582F0", Offset = "0x1583F1")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007180")]
		[Address(RVA = "0x228DAE0", Offset = "0x228DBE1", VA = "0x228DAE0")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007181")]
		[Address(RVA = "0x228DAF0", Offset = "0x228DBF1", VA = "0x228DAF0")]
		internal void <OnSetupAsync>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x6007182")]
		[Address(RVA = "0x228DD90", Offset = "0x228DE91", VA = "0x228DD90")]
		internal bool <OnSetupAsync>b__1()
		{
			return default(bool);
		}

		// Token: 0x04007207 RID: 29191
		[Token(Token = "0x40194A9")]
		[FieldOffset(Offset = "0x10")]
		public AudmuraController <>4__this;

		// Token: 0x04007208 RID: 29192
		[Token(Token = "0x40194AA")]
		[FieldOffset(Offset = "0x18")]
		public bool isComplete;
	}

	// Token: 0x020006BA RID: 1722
	[Token(Token = "0x2001173")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158300", Offset = "0x158401")]
	private sealed class <OnSetupAsync>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007183")]
		[Address(RVA = "0x228E2A0", Offset = "0x228E3A1", VA = "0x228E2A0")]
		[DebuggerHidden]
		public <OnSetupAsync>d__18(int <>1__state)
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007184")]
		[Address(RVA = "0x228E2D0", Offset = "0x228E3D1", VA = "0x228E2D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x6007185")]
		[Address(RVA = "0x228E2E0", Offset = "0x228E3E1", VA = "0x228E2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D13")]
		private object Current
		{
			[Token(Token = "0x6007186")]
			[Address(RVA = "0x228E460", Offset = "0x228E561", VA = "0x228E460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007187")]
		[Address(RVA = "0x228E470", Offset = "0x228E571", VA = "0x228E470", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D14")]
		private object Current
		{
			[Token(Token = "0x6007188")]
			[Address(RVA = "0x228E4D0", Offset = "0x228E5D1", VA = "0x228E4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007209 RID: 29193
		[Token(Token = "0x40194AB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400720A RID: 29194
		[Token(Token = "0x40194AC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400720B RID: 29195
		[Token(Token = "0x40194AD")]
		[FieldOffset(Offset = "0x20")]
		public AudmuraController <>4__this;
	}

	// Token: 0x020006BB RID: 1723
	[Token(Token = "0x2001174")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158310", Offset = "0x158411")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002A19 RID: 10777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718A")]
		[Address(RVA = "0x228D980", Offset = "0x228DA81", VA = "0x228D980")]
		public <>c()
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x600718B")]
		[Address(RVA = "0x228D990", Offset = "0x228DA91", VA = "0x228D990")]
		internal bool <CreateProjectileEvent>b__20_0(AudmuraCrystal item)
		{
			return default(bool);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x600718C")]
		[Address(RVA = "0x228DA00", Offset = "0x228DB01", VA = "0x228DA00")]
		internal bool <OnDeadEvent>b__21_0(AudmuraCrystal item)
		{
			return default(bool);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x600718D")]
		[Address(RVA = "0x228DA70", Offset = "0x228DB71", VA = "0x228DA70")]
		internal bool <GetLaserNextPos>b__25_0(AudmuraCrystal item)
		{
			return default(bool);
		}

		// Token: 0x0400720C RID: 29196
		[Token(Token = "0x40194AE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AudmuraController.<>c <>9;

		// Token: 0x0400720D RID: 29197
		[Token(Token = "0x40194AF")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AudmuraCrystal> <>9__20_0;

		// Token: 0x0400720E RID: 29198
		[Token(Token = "0x40194B0")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<AudmuraCrystal> <>9__21_0;

		// Token: 0x0400720F RID: 29199
		[Token(Token = "0x40194B1")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<AudmuraCrystal> <>9__25_0;
	}

	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x2001175")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158320", Offset = "0x158421")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718E")]
		[Address(RVA = "0x228DDA0", Offset = "0x228DEA1", VA = "0x228DDA0")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600718F")]
		[Address(RVA = "0x228DDB0", Offset = "0x228DEB1", VA = "0x228DDB0")]
		internal void <OnUniqueProjectileActionCommandInternal>b__0(AudmuraCrystal crystal, Vector3 hitPos)
		{
		}

		// Token: 0x04007210 RID: 29200
		[Token(Token = "0x40194B2")]
		[FieldOffset(Offset = "0x10")]
		public string nextActionCode;

		// Token: 0x04007211 RID: 29201
		[Token(Token = "0x40194B3")]
		[FieldOffset(Offset = "0x18")]
		public AudmuraController <>4__this;
	}
}
