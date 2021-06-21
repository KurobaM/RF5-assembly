using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B6 RID: 1206
[Token(Token = "0x2000380")]
[Serializable]
public class SubEventMasterDataBase
{
	// Token: 0x06001D97 RID: 7575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x1FAA860", Offset = "0x1FAA961", VA = "0x1FAA860")]
	public void Initialize(int num = 10)
	{
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x0000CB58 File Offset: 0x0000AD58
	[Token(Token = "0x600199D")]
	[Address(RVA = "0x1FAA990", Offset = "0x1FAAA91", VA = "0x1FAA990")]
	public bool CheckOccurrenceWeather()
	{
		return default(bool);
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x0000CB70 File Offset: 0x0000AD70
	[Token(Token = "0x600199E")]
	[Address(RVA = "0x1FAAA20", Offset = "0x1FAAB21", VA = "0x1FAAA20")]
	public bool CheckDatingNum(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x0000CB88 File Offset: 0x0000AD88
	[Token(Token = "0x600199F")]
	[Address(RVA = "0x1FAAB00", Offset = "0x1FAAC01", VA = "0x1FAAB00")]
	public bool CheckOccurrenceStoryFlag()
	{
		return default(bool);
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x1FAAB10", Offset = "0x1FAAC11", VA = "0x1FAAB10")]
	public bool CheckOccurrenceScriptFlag()
	{
		return default(bool);
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x1FAAC00", Offset = "0x1FAAD01", VA = "0x1FAAC00")]
	public bool CheckScriptFlag(int eventScriptFlagID)
	{
		return default(bool);
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x1FAAC70", Offset = "0x1FAAD71", VA = "0x1FAAC70")]
	public bool CheckOppositeGender()
	{
		return default(bool);
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x1FAAD00", Offset = "0x1FAAE01", VA = "0x1FAAD00")]
	public bool CheckOccurrenceLoveProgress()
	{
		return default(bool);
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x0000CC00 File Offset: 0x0000AE00
	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x1FAAEF0", Offset = "0x1FAAFF1", VA = "0x1FAAEF0")]
	public bool CheckLoveLv()
	{
		return default(bool);
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x0000CC18 File Offset: 0x0000AE18
	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x1FAB000", Offset = "0x1FAB101", VA = "0x1FAB000")]
	public bool CheckNotAllowedNpcId(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x0000CC30 File Offset: 0x0000AE30
	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x1FAB070", Offset = "0x1FAB171", VA = "0x1FAB070")]
	public bool CheckNotAllowedNpcInPartner()
	{
		return default(bool);
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x0000CC48 File Offset: 0x0000AE48
	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x1FAB130", Offset = "0x1FAB231", VA = "0x1FAB130")]
	public bool CheckOccurrenceItemId()
	{
		return default(bool);
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x1FAB3E0", Offset = "0x1FAB4E1", VA = "0x1FAB3E0")]
	public SubEventMasterDataBase()
	{
	}

	// Token: 0x040063BF RID: 25535
	[Token(Token = "0x4005EA0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SubEventType EventType;

	// Token: 0x040063C0 RID: 25536
	[Token(Token = "0x4005EA1")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int EventId;

	// Token: 0x040063C1 RID: 25537
	[Token(Token = "0x4005EA2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int OccurrenceRate;

	// Token: 0x040063C2 RID: 25538
	[Token(Token = "0x4005EA3")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool IsRepetitionOccurrence;

	// Token: 0x040063C3 RID: 25539
	[Token(Token = "0x4005EA4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Gender OccurrenceGender;

	// Token: 0x040063C4 RID: 25540
	[Token(Token = "0x4005EA5")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int OccurrenceLoveProgress;

	// Token: 0x040063C5 RID: 25541
	[Token(Token = "0x4005EA6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Weather OccurrenceWeather;

	// Token: 0x040063C6 RID: 25542
	[Token(Token = "0x4005EA7")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int DatingNum;

	// Token: 0x040063C7 RID: 25543
	[Token(Token = "0x4005EA8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int[] TargetNpcId;

	// Token: 0x040063C8 RID: 25544
	[Token(Token = "0x4005EA9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int[] NpcLoveLv;

	// Token: 0x040063C9 RID: 25545
	[Token(Token = "0x4005EAA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int[] OccurrenceScriptFlag;

	// Token: 0x040063CA RID: 25546
	[Token(Token = "0x4005EAB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int[] OccurrenceSubEventCmpFlag;

	// Token: 0x040063CB RID: 25547
	[Token(Token = "0x4005EAC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int[] OccurrenceItemId;

	// Token: 0x040063CC RID: 25548
	[Token(Token = "0x4005EAD")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public int[] JoinNpcId;

	// Token: 0x040063CD RID: 25549
	[Token(Token = "0x4005EAE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int[] NotAllowedNpcId;
}
