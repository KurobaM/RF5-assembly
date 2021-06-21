using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;

// Token: 0x0200046F RID: 1135
[Token(Token = "0x200036B")]
public class PartnerAdvChoice
{
	// Token: 0x06001BA4 RID: 7076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x231C6A0", Offset = "0x231C7A1", VA = "0x231C6A0")]
	public void InitializeStep()
	{
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x231C730", Offset = "0x231C831", VA = "0x231C730")]
	public void NickNameChangeEnd(string name)
	{
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x231C7A0", Offset = "0x231C8A1", VA = "0x231C7A0")]
	public void NickNameChangeStart()
	{
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x231C850", Offset = "0x231C951", VA = "0x231C850")]
	private string GetPartnerMenuText(int id)
	{
		return null;
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x231CAA0", Offset = "0x231CBA1", VA = "0x231CAA0")]
	private string GetAdvChoiceNothing()
	{
		return null;
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x231CB90", Offset = "0x231CC91", VA = "0x231CB90")]
	private string GetAdvChoiceRelease()
	{
		return null;
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x231CC80", Offset = "0x231CD81", VA = "0x231CC80")]
	private string GetPartnerMonsterMenuText(int id)
	{
		return null;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x231D1B0", Offset = "0x231D2B1", VA = "0x231D1B0")]
	private string GetAdvChoiceChangeNickName()
	{
		return null;
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018B3")]
	[Address(RVA = "0x231D2A0", Offset = "0x231D3A1", VA = "0x231D2A0")]
	private string GetAdvChoiceMonsterNothing()
	{
		return null;
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B4")]
	[Address(RVA = "0x231D390", Offset = "0x231D491", VA = "0x231D390")]
	public void SetMonsterSelectMenu_Partner(FriendMonsterStatus friend, int rideCount, [Optional] Action<ActorID> onRide)
	{
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B5")]
	[Address(RVA = "0x231D740", Offset = "0x231D841", VA = "0x231D740")]
	public void SetMonsterSelectMenu_Wait(FriendMonsterStatus friend)
	{
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x231D760", Offset = "0x231D861", VA = "0x231D760")]
	public void SetMonsterSelectMenu_HandCuffs(HandCuffsStatus handCuffs)
	{
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x231D3B0", Offset = "0x231D4B1", VA = "0x231D3B0")]
	private void SetMonsterSelectMenuBase(PartnerAdvChoice.PartnerEventStep step, FriendMonsterStatus friend, int rideCount = 0, [Optional] Action<ActorID> onRide)
	{
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x231E010", Offset = "0x231E111", VA = "0x231E010")]
	public void AppearSelectMenu(string message, int nextStep)
	{
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x231E130", Offset = "0x231E231", VA = "0x231E130")]
	public void AdvSelectStart()
	{
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x231E1C0", Offset = "0x231E2C1", VA = "0x231E1C0")]
	public void SelectedMenu(int nextStep)
	{
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x231F940", Offset = "0x231FA41", VA = "0x231F940")]
	private void FriendMonsterPartyOut(FriendMonsterStatusData StatusData)
	{
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x231FAC0", Offset = "0x231FBC1", VA = "0x231FAC0")]
	private void SelectEnd()
	{
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x231D890", Offset = "0x231D991", VA = "0x231D890")]
	public void SetNextPartnerMonsterChoice(uint targetId)
	{
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x231FC50", Offset = "0x231FD51", VA = "0x231FC50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D950", Offset = "0x19DA51")]
	private IEnumerator GoPause()
	{
		return null;
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x231FD00", Offset = "0x231FE01", VA = "0x231FD00")]
	public PartnerAdvChoice()
	{
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x231FDC0", Offset = "0x231FEC1", VA = "0x231FDC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D9C0", Offset = "0x19DAC1")]
	private void <NickNameChangeStart>b__13_0()
	{
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x231FE80", Offset = "0x231FF81", VA = "0x231FE80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D9D0", Offset = "0x19DAD1")]
	private void <NickNameChangeStart>b__13_1(string str)
	{
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x231FEF0", Offset = "0x231FFF1", VA = "0x231FEF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D9E0", Offset = "0x19DAE1")]
	private void <SelectedMenu>b__26_1()
	{
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x231FF00", Offset = "0x2320001", VA = "0x231FF00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D9F0", Offset = "0x19DAF1")]
	private void <SelectedMenu>b__26_2()
	{
	}

	// Token: 0x04006071 RID: 24689
	[Token(Token = "0x4005C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private PartnerAdvChoice.PartnerEventStep partnerEventStep;

	// Token: 0x04006072 RID: 24690
	[Token(Token = "0x4005C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<stCommand_t> cmdList;

	// Token: 0x04006073 RID: 24691
	[Token(Token = "0x4005C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int ChoiceSelect;

	// Token: 0x04006074 RID: 24692
	[Token(Token = "0x4005C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool NickNameChanging;

	// Token: 0x04006075 RID: 24693
	[Token(Token = "0x4005C82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint TalkingID;

	// Token: 0x04006076 RID: 24694
	[Token(Token = "0x4005C83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int PartyNo;

	// Token: 0x04006077 RID: 24695
	[Token(Token = "0x4005C84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int RideCount;

	// Token: 0x04006078 RID: 24696
	[Token(Token = "0x4005C85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private FriendMonsterStatus friendMob;

	// Token: 0x04006079 RID: 24697
	[Token(Token = "0x4005C86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<int> ChoiceNextStepList;

	// Token: 0x0400607A RID: 24698
	[Token(Token = "0x4005C87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action<ActorID> m_onRide;

	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x200108D")]
	public enum PartnerEventStep
	{
		// Token: 0x0400607C RID: 24700
		[Token(Token = "0x4019067")]
		None,
		// Token: 0x0400607D RID: 24701
		[Token(Token = "0x4019068")]
		Partner,
		// Token: 0x0400607E RID: 24702
		[Token(Token = "0x4019069")]
		Battle,
		// Token: 0x0400607F RID: 24703
		[Token(Token = "0x401906A")]
		Mob_Partner = 11,
		// Token: 0x04006080 RID: 24704
		[Token(Token = "0x401906B")]
		Mob_Partner_Battle,
		// Token: 0x04006081 RID: 24705
		[Token(Token = "0x401906C")]
		Mob_Wait,
		// Token: 0x04006082 RID: 24706
		[Token(Token = "0x401906D")]
		Mob_FarmWork,
		// Token: 0x04006083 RID: 24707
		[Token(Token = "0x401906E")]
		Mob_Confirm,
		// Token: 0x04006084 RID: 24708
		[Token(Token = "0x401906F")]
		Mob_SowingSeed,
		// Token: 0x04006085 RID: 24709
		[Token(Token = "0x4019070")]
		Mob_Release,
		// Token: 0x04006086 RID: 24710
		[Token(Token = "0x4019071")]
		Mob_RideOn,
		// Token: 0x04006087 RID: 24711
		[Token(Token = "0x4019072")]
		Mob_RideOnNpc,
		// Token: 0x04006088 RID: 24712
		[Token(Token = "0x4019073")]
		Mob_HandCuffs = 51
	}

	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x200108E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157780", Offset = "0x157881")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE4")]
		[Address(RVA = "0x231F7A0", Offset = "0x231F8A1", VA = "0x231F7A0")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE5")]
		[Address(RVA = "0x231FF10", Offset = "0x2320011", VA = "0x231FF10")]
		internal void <SelectedMenu>b__0()
		{
		}

		// Token: 0x04006089 RID: 24713
		[Token(Token = "0x4019074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FriendMonsterStatusData StatusData;

		// Token: 0x0400608A RID: 24714
		[Token(Token = "0x4019075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PartnerAdvChoice <>4__this;
	}

	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x200108F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157790", Offset = "0x157891")]
	private sealed class <GoPause>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0x231FCD0", Offset = "0x231FDD1", VA = "0x231FCD0")]
		[DebuggerHidden]
		public <GoPause>d__30(int <>1__state)
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0x231FF30", Offset = "0x2320031", VA = "0x231FF30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0x231FF40", Offset = "0x2320041", VA = "0x231FF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2F")]
		private object Current
		{
			[Token(Token = "0x6006DE9")]
			[Address(RVA = "0x2320010", Offset = "0x2320111", VA = "0x2320010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0x2320020", Offset = "0x2320121", VA = "0x2320020", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C30")]
		private object Current
		{
			[Token(Token = "0x6006DEB")]
			[Address(RVA = "0x2320080", Offset = "0x2320181", VA = "0x2320080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400608B RID: 24715
		[Token(Token = "0x4019076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400608C RID: 24716
		[Token(Token = "0x4019077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400608D RID: 24717
		[Token(Token = "0x4019078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerAdvChoice <>4__this;
	}
}
