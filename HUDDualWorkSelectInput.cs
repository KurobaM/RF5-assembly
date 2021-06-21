using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x020009A3 RID: 2467
[Token(Token = "0x2000678")]
public class HUDDualWorkSelectInput : SingletonMonoBehaviour<HUDDualWorkSelectInput>
{
	// Token: 0x17000908 RID: 2312
	// (get) Token: 0x06004081 RID: 16513 RVA: 0x00015C78 File Offset: 0x00013E78
	[Token(Token = "0x1700073C")]
	public ActorID SelectedActor
	{
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x20482D0", Offset = "0x20483D1", VA = "0x20482D0")]
		get
		{
			return ActorID.act000;
		}
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x2044250", Offset = "0x2044351", VA = "0x2044250")]
	public void SetAddPartie(int partyNo, HUDCharactorStatus charactorStatus)
	{
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CC")]
	[Address(RVA = "0x2048400", Offset = "0x2048501", VA = "0x2048400")]
	private void removeCanDualParties(int partyNo)
	{
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CD")]
	[Address(RVA = "0x2043D70", Offset = "0x2043E71", VA = "0x2043D70")]
	public void removeParties(int partyNo)
	{
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035CE")]
	[Address(RVA = "0x2048680", Offset = "0x2048781", VA = "0x2048680")]
	private void Update()
	{
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x00015C90 File Offset: 0x00013E90
	[Token(Token = "0x60035CF")]
	[Address(RVA = "0x2049460", Offset = "0x2049561", VA = "0x2049460")]
	private bool CheckDualSkillTarget(CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x00015CA8 File Offset: 0x00013EA8
	[Token(Token = "0x60035D0")]
	[Address(RVA = "0x2049660", Offset = "0x2049761", VA = "0x2049660")]
	public bool GetDualSkillTarget(out CharacterBase outTarget)
	{
		return default(bool);
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x00015CC0 File Offset: 0x00013EC0
	[Token(Token = "0x60035D1")]
	[Address(RVA = "0x204A100", Offset = "0x204A201", VA = "0x204A100")]
	public bool CanPlayDualSkill(ActorID _actor)
	{
		return default(bool);
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x00015CD8 File Offset: 0x00013ED8
	[Token(Token = "0x60035D2")]
	[Address(RVA = "0x2049300", Offset = "0x2049401", VA = "0x2049300")]
	private bool OnPlayDualSkill()
	{
		return default(bool);
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035D3")]
	[Address(RVA = "0x204A150", Offset = "0x204A251", VA = "0x204A150")]
	public HUDDualWorkSelectInput()
	{
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x00015CF0 File Offset: 0x00013EF0
	[Token(Token = "0x60035D4")]
	[Address(RVA = "0x204A210", Offset = "0x204A311", VA = "0x204A210")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7340", Offset = "0x1A7441")]
	private bool <Update>b__10_1(HUDDualWorkSelectInput.DualSelect a)
	{
		return default(bool);
	}

	// Token: 0x04009F23 RID: 40739
	[Token(Token = "0x40077F4")]
	[FieldOffset(Offset = "0x18")]
	private List<HUDDualWorkSelectInput.DualSelect> canDualSelects;

	// Token: 0x04009F24 RID: 40740
	[Token(Token = "0x40077F5")]
	[FieldOffset(Offset = "0x20")]
	private List<HUDDualWorkSelectInput.DualSelect> dualSelects;

	// Token: 0x04009F25 RID: 40741
	[Token(Token = "0x40077F6")]
	[FieldOffset(Offset = "0x28")]
	private int selectingPartyNo;

	// Token: 0x04009F26 RID: 40742
	[Token(Token = "0x40077F7")]
	[FieldOffset(Offset = "0x2C")]
	private int selecting;

	// Token: 0x020009A4 RID: 2468
	[Token(Token = "0x20012AD")]
	private class DualSelect
	{
		// Token: 0x0600408C RID: 16524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759B")]
		[Address(RVA = "0x2048390", Offset = "0x2048491", VA = "0x2048390")]
		public DualSelect(HumanStatus _status, int _partyNo, HUDCharactorStatus _charactorStatus)
		{
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x600759C")]
		[Address(RVA = "0x2049190", Offset = "0x2049291", VA = "0x2049190")]
		public bool CheckCanDualChange()
		{
			return default(bool);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759D")]
		[Address(RVA = "0x2049230", Offset = "0x2049331", VA = "0x2049230")]
		public void UpdateGauge()
		{
		}

		// Token: 0x04009F27 RID: 40743
		[Token(Token = "0x401B392")]
		[FieldOffset(Offset = "0x10")]
		public HumanStatus status;

		// Token: 0x04009F28 RID: 40744
		[Token(Token = "0x401B393")]
		[FieldOffset(Offset = "0x18")]
		public int partyNo;

		// Token: 0x04009F29 RID: 40745
		[Token(Token = "0x401B394")]
		[FieldOffset(Offset = "0x20")]
		public HUDCharactorStatus charactorStatus;

		// Token: 0x04009F2A RID: 40746
		[Token(Token = "0x401B395")]
		[FieldOffset(Offset = "0x28")]
		public bool CanDual;

		// Token: 0x04009F2B RID: 40747
		[Token(Token = "0x401B396")]
		[FieldOffset(Offset = "0x2C")]
		public float nowGauge;
	}

	// Token: 0x020009A5 RID: 2469
	[Token(Token = "0x20012AE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158ED0", Offset = "0x158FD1")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x0600408F RID: 16527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759E")]
		[Address(RVA = "0x2048380", Offset = "0x2048481", VA = "0x2048380")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x600759F")]
		[Address(RVA = "0x204A320", Offset = "0x204A421", VA = "0x204A320")]
		internal bool <SetAddPartie>b__0(HUDDualWorkSelectInput.DualSelect a)
		{
			return default(bool);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x60075A0")]
		[Address(RVA = "0x204A350", Offset = "0x204A451", VA = "0x204A350")]
		internal bool <SetAddPartie>b__1(HUDDualWorkSelectInput.DualSelect a)
		{
			return default(bool);
		}

		// Token: 0x04009F2C RID: 40748
		[Token(Token = "0x401B397")]
		[FieldOffset(Offset = "0x10")]
		public int partyNo;
	}

	// Token: 0x020009A6 RID: 2470
	[Token(Token = "0x20012AF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158EE0", Offset = "0x158FE1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004093 RID: 16531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A2")]
		[Address(RVA = "0x204A2B0", Offset = "0x204A3B1", VA = "0x204A2B0")]
		public <>c()
		{
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x60075A3")]
		[Address(RVA = "0x204A2C0", Offset = "0x204A3C1", VA = "0x204A2C0")]
		internal int <SetAddPartie>b__7_2(HUDDualWorkSelectInput.DualSelect a, HUDDualWorkSelectInput.DualSelect b)
		{
			return 0;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x60075A4")]
		[Address(RVA = "0x204A2F0", Offset = "0x204A3F1", VA = "0x204A2F0")]
		internal int <Update>b__10_0(HUDDualWorkSelectInput.DualSelect a, HUDDualWorkSelectInput.DualSelect b)
		{
			return 0;
		}

		// Token: 0x04009F2D RID: 40749
		[Token(Token = "0x401B398")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HUDDualWorkSelectInput.<>c <>9;

		// Token: 0x04009F2E RID: 40750
		[Token(Token = "0x401B399")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<HUDDualWorkSelectInput.DualSelect> <>9__7_2;

		// Token: 0x04009F2F RID: 40751
		[Token(Token = "0x401B39A")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<HUDDualWorkSelectInput.DualSelect> <>9__10_0;
	}

	// Token: 0x020009A7 RID: 2471
	[Token(Token = "0x20012B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158EF0", Offset = "0x158FF1")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06004096 RID: 16534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A5")]
		[Address(RVA = "0x2048660", Offset = "0x2048761", VA = "0x2048660")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x60075A6")]
		[Address(RVA = "0x204A380", Offset = "0x204A481", VA = "0x204A380")]
		internal bool <removeCanDualParties>b__0(HUDDualWorkSelectInput.DualSelect a)
		{
			return default(bool);
		}

		// Token: 0x04009F30 RID: 40752
		[Token(Token = "0x401B39B")]
		[FieldOffset(Offset = "0x10")]
		public int partyNo;
	}

	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20012B1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F00", Offset = "0x159001")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06004098 RID: 16536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A7")]
		[Address(RVA = "0x2048670", Offset = "0x2048771", VA = "0x2048670")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x60075A8")]
		[Address(RVA = "0x204A3B0", Offset = "0x204A4B1", VA = "0x204A3B0")]
		internal bool <removeParties>b__0(HUDDualWorkSelectInput.DualSelect a)
		{
			return default(bool);
		}

		// Token: 0x04009F31 RID: 40753
		[Token(Token = "0x401B39C")]
		[FieldOffset(Offset = "0x10")]
		public int partyNo;
	}
}
