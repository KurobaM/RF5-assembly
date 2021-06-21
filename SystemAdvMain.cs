using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020004B7 RID: 1207
[Token(Token = "0x2000381")]
public class SystemAdvMain
{
	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700040E")]
	public AdvDialogControl advDialogControl
	{
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x1FB2190", Offset = "0x1FB2291", VA = "0x1FB2190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19EB40", Offset = "0x19EC41")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x1FB21A0", Offset = "0x1FB22A1", VA = "0x1FB21A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19EB50", Offset = "0x19EC51")]
		private set
		{
		}
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x1FB21B0", Offset = "0x1FB22B1", VA = "0x1FB21B0")]
	private void Awake()
	{
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x1FB2230", Offset = "0x1FB2331", VA = "0x1FB2230")]
	private void Start()
	{
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x1FB2240", Offset = "0x1FB2341", VA = "0x1FB2240")]
	public void EventStart(string filePath)
	{
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x1FB22E0", Offset = "0x1FB23E1", VA = "0x1FB22E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19EB60", Offset = "0x19EC61")]
	private IEnumerator AdvStartCoroutine(string filePath)
	{
		return null;
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x1FB23B0", Offset = "0x1FB24B1", VA = "0x1FB23B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19EBD0", Offset = "0x19ECD1")]
	public IEnumerator AdvStart(string filePath)
	{
		return null;
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B0")]
	[Address(RVA = "0x1FB2480", Offset = "0x1FB2581", VA = "0x1FB2480")]
	public void AdvStart2(TextAsset textobj, string filePath)
	{
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B1")]
	[Address(RVA = "0x1FB29C0", Offset = "0x1FB2AC1", VA = "0x1FB29C0")]
	public void AdvEnd()
	{
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x1FB29D0", Offset = "0x1FB2AD1", VA = "0x1FB29D0")]
	public void AdvUpdate()
	{
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x0000CC60 File Offset: 0x0000AE60
	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x1FB2AE0", Offset = "0x1FB2BE1", VA = "0x1FB2AE0")]
	private SystemAdvMain.WorkList ReadCommand()
	{
		return SystemAdvMain.WorkList.WORK_NONE;
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x1FB4410", Offset = "0x1FB4511", VA = "0x1FB4410")]
	public void onPauseEnd()
	{
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x1FB4420", Offset = "0x1FB4521", VA = "0x1FB4420")]
	public void onTextWindowClick(int n)
	{
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0000CC78 File Offset: 0x0000AE78
	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x1FB44F0", Offset = "0x1FB45F1", VA = "0x1FB44F0")]
	public int OnSkip([Optional] bool? flag)
	{
		return 0;
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x0000CC90 File Offset: 0x0000AE90
	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x1FB45C0", Offset = "0x1FB46C1", VA = "0x1FB45C0")]
	public int GetSkipState()
	{
		return 0;
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x1FB2960", Offset = "0x1FB2A61", VA = "0x1FB2960")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19EC40", Offset = "0x19ED41")]
	public IEnumerator EventEndFinish(float wait)
	{
		return null;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x1FB4600", Offset = "0x1FB4701", VA = "0x1FB4600")]
	public SystemAdvMain()
	{
	}

	// Token: 0x040063CE RID: 25550
	[Token(Token = "0x4005EAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164E70", Offset = "0x164F71")]
	private AdvDialogControl <advDialogControl>k__BackingField;

	// Token: 0x040063CF RID: 25551
	[Token(Token = "0x4005EB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ScriptWork scriptwork;

	// Token: 0x040063D0 RID: 25552
	[Token(Token = "0x4005EB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action completeFunc;

	// Token: 0x040063D1 RID: 25553
	[Token(Token = "0x4005EB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ItemData BeforeEquipedTool;

	// Token: 0x040063D2 RID: 25554
	[Token(Token = "0x4005EB3")]
	private const int ScriptParamMax = 9;

	// Token: 0x040063D3 RID: 25555
	[Token(Token = "0x4005EB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool IsForceText;

	// Token: 0x040063D4 RID: 25556
	[Token(Token = "0x4005EB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private SystemAdvMain.WorkList work;

	// Token: 0x040063D5 RID: 25557
	[Token(Token = "0x4005EB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private stCommand_t cmd;

	// Token: 0x040063D6 RID: 25558
	[Token(Token = "0x4005EB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private stCommand_t rndcmd;

	// Token: 0x040063D7 RID: 25559
	[Token(Token = "0x4005EB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<stCommand_t> cmdList;

	// Token: 0x040063D8 RID: 25560
	[Token(Token = "0x4005EB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isWait;

	// Token: 0x040063D9 RID: 25561
	[Token(Token = "0x4005EBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool isAdvLoad;

	// Token: 0x040063DA RID: 25562
	[Token(Token = "0x4005EBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float waitSec;

	// Token: 0x040063DB RID: 25563
	[Token(Token = "0x4005EBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float waitStartTime;

	// Token: 0x040063DC RID: 25564
	[Token(Token = "0x4005EBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private TextWindow textWindow;

	// Token: 0x040063DD RID: 25565
	[Token(Token = "0x4005EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private NameWindow nameWindow;

	// Token: 0x040063DE RID: 25566
	[Token(Token = "0x4005EBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int isSkip;

	// Token: 0x040063DF RID: 25567
	[Token(Token = "0x4005EC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool IsCmdWait;

	// Token: 0x040063E0 RID: 25568
	[Token(Token = "0x4005EC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int SelectMenuTotalCount;

	// Token: 0x040063E1 RID: 25569
	[Token(Token = "0x4005EC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string seName;

	// Token: 0x040063E2 RID: 25570
	[Token(Token = "0x4005EC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string voiceName;

	// Token: 0x040063E3 RID: 25571
	[Token(Token = "0x4005EC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int loaderId;

	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20010BF")]
	private enum WorkList
	{
		// Token: 0x040063E5 RID: 25573
		[Token(Token = "0x4019193")]
		WORK_NONE,
		// Token: 0x040063E6 RID: 25574
		[Token(Token = "0x4019194")]
		WORK_READ_TEXT,
		// Token: 0x040063E7 RID: 25575
		[Token(Token = "0x4019195")]
		WORK_MESSAGE_WAIT,
		// Token: 0x040063E8 RID: 25576
		[Token(Token = "0x4019196")]
		WORK_BU_WAIT,
		// Token: 0x040063E9 RID: 25577
		[Token(Token = "0x4019197")]
		WORK_BG_WAIT,
		// Token: 0x040063EA RID: 25578
		[Token(Token = "0x4019198")]
		WORK_BGM_WAIT,
		// Token: 0x040063EB RID: 25579
		[Token(Token = "0x4019199")]
		WORK_BGM_STOP_WAIT,
		// Token: 0x040063EC RID: 25580
		[Token(Token = "0x401919A")]
		WORK_FADE_WAIT,
		// Token: 0x040063ED RID: 25581
		[Token(Token = "0x401919B")]
		WORK_WAIT,
		// Token: 0x040063EE RID: 25582
		[Token(Token = "0x401919C")]
		WORK_SELECT_WAIT,
		// Token: 0x040063EF RID: 25583
		[Token(Token = "0x401919D")]
		WORK_TIMELINE_WAIT,
		// Token: 0x040063F0 RID: 25584
		[Token(Token = "0x401919E")]
		WORK_TIMELINE_END_WAIT,
		// Token: 0x040063F1 RID: 25585
		[Token(Token = "0x401919F")]
		WORK_MOVIE_WAIT,
		// Token: 0x040063F2 RID: 25586
		[Token(Token = "0x40191A0")]
		WORK_PAUSE
	}

	// Token: 0x020004B9 RID: 1209
	[Token(Token = "0x20010C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A80", Offset = "0x157B81")]
	private sealed class <AdvStartCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE6")]
		[Address(RVA = "0x1FB2380", Offset = "0x1FB2481", VA = "0x1FB2380")]
		[DebuggerHidden]
		public <AdvStartCoroutine>d__29(int <>1__state)
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE7")]
		[Address(RVA = "0x1FB4BF0", Offset = "0x1FB4CF1", VA = "0x1FB4BF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x6006EE8")]
		[Address(RVA = "0x1FB4C00", Offset = "0x1FB4D01", VA = "0x1FB4C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7F")]
		private object Current
		{
			[Token(Token = "0x6006EE9")]
			[Address(RVA = "0x1FB4D10", Offset = "0x1FB4E11", VA = "0x1FB4D10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEA")]
		[Address(RVA = "0x1FB4D20", Offset = "0x1FB4E21", VA = "0x1FB4D20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C80")]
		private object Current
		{
			[Token(Token = "0x6006EEB")]
			[Address(RVA = "0x1FB4D80", Offset = "0x1FB4E81", VA = "0x1FB4D80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040063F3 RID: 25587
		[Token(Token = "0x40191A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040063F4 RID: 25588
		[Token(Token = "0x40191A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040063F5 RID: 25589
		[Token(Token = "0x40191A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SystemAdvMain <>4__this;

		// Token: 0x040063F6 RID: 25590
		[Token(Token = "0x40191A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;
	}

	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20010C1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A90", Offset = "0x157B91")]
	private sealed class <>c__DisplayClass30_0
	{
		// Token: 0x06001DBB RID: 7611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0x1FB4680", Offset = "0x1FB4781", VA = "0x1FB4680")]
		public <>c__DisplayClass30_0()
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EED")]
		[Address(RVA = "0x1FB4690", Offset = "0x1FB4791", VA = "0x1FB4690")]
		internal void <AdvStart>b__0(AssetHandle<TextAsset> handle)
		{
		}

		// Token: 0x040063F7 RID: 25591
		[Token(Token = "0x40191A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SystemAdvMain <>4__this;

		// Token: 0x040063F8 RID: 25592
		[Token(Token = "0x40191A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string filePath;
	}

	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20010C2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AA0", Offset = "0x157BA1")]
	private sealed class <AdvStart>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001DBD RID: 7613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0x1FB2450", Offset = "0x1FB2551", VA = "0x1FB2450")]
		[DebuggerHidden]
		public <AdvStart>d__30(int <>1__state)
		{
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EEF")]
		[Address(RVA = "0x1FB4710", Offset = "0x1FB4811", VA = "0x1FB4710", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0x1FB4720", Offset = "0x1FB4821", VA = "0x1FB4720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C81")]
		private object Current
		{
			[Token(Token = "0x6006EF1")]
			[Address(RVA = "0x1FB4B70", Offset = "0x1FB4C71", VA = "0x1FB4B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0x1FB4B80", Offset = "0x1FB4C81", VA = "0x1FB4B80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C82")]
		private object Current
		{
			[Token(Token = "0x6006EF3")]
			[Address(RVA = "0x1FB4BE0", Offset = "0x1FB4CE1", VA = "0x1FB4BE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040063F9 RID: 25593
		[Token(Token = "0x40191A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040063FA RID: 25594
		[Token(Token = "0x40191A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040063FB RID: 25595
		[Token(Token = "0x40191A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SystemAdvMain <>4__this;

		// Token: 0x040063FC RID: 25596
		[Token(Token = "0x40191AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filePath;

		// Token: 0x040063FD RID: 25597
		[Token(Token = "0x40191AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SystemAdvMain.<>c__DisplayClass30_0 <>8__1;

		// Token: 0x040063FE RID: 25598
		[Token(Token = "0x40191AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextAsset <result>5__2;
	}

	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20010C3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157AB0", Offset = "0x157BB1")]
	private sealed class <EventEndFinish>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0x1FB45D0", Offset = "0x1FB46D1", VA = "0x1FB45D0")]
		[DebuggerHidden]
		public <EventEndFinish>d__39(int <>1__state)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF5")]
		[Address(RVA = "0x1FB4D90", Offset = "0x1FB4E91", VA = "0x1FB4D90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x6006EF6")]
		[Address(RVA = "0x1FB4DA0", Offset = "0x1FB4EA1", VA = "0x1FB4DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C83")]
		private object Current
		{
			[Token(Token = "0x6006EF7")]
			[Address(RVA = "0x1FB4DC0", Offset = "0x1FB4EC1", VA = "0x1FB4DC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EF8")]
		[Address(RVA = "0x1FB4DD0", Offset = "0x1FB4ED1", VA = "0x1FB4DD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C84")]
		private object Current
		{
			[Token(Token = "0x6006EF9")]
			[Address(RVA = "0x1FB4E30", Offset = "0x1FB4F31", VA = "0x1FB4E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040063FF RID: 25599
		[Token(Token = "0x40191AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006400 RID: 25600
		[Token(Token = "0x40191AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
