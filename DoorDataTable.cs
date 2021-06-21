using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000362 RID: 866
[Token(Token = "0x2000290")]
[Serializable]
public class DoorDataTable
{
	// Token: 0x06001690 RID: 5776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001401")]
	[Address(RVA = "0x1DFE970", Offset = "0x1DFEA71", VA = "0x1DFE970")]
	public static DoorDataTable GetDataTable(Place id)
	{
		return null;
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0000A008 File Offset: 0x00008208
	[Token(Token = "0x6001402")]
	[Address(RVA = "0x1DFEB00", Offset = "0x1DFEC01", VA = "0x1DFEB00")]
	public static bool HasDataTable(Place id)
	{
		return default(bool);
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001403")]
	[Address(RVA = "0x1DFEDF0", Offset = "0x1DFEEF1", VA = "0x1DFEDF0")]
	public DoorDataTable()
	{
	}

	// Token: 0x04000E8E RID: 3726
	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID[] CheckActors;

	// Token: 0x04000E8F RID: 3727
	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int NeedLoveLevel;

	// Token: 0x04000E90 RID: 3728
	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int OpenHour;

	// Token: 0x04000E91 RID: 3729
	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int CloseHour;

	// Token: 0x04000E92 RID: 3730
	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int Holiday_OpenHour;

	// Token: 0x04000E93 RID: 3731
	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int Holiday_CloseHour;

	// Token: 0x04000E94 RID: 3732
	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int OpenHour_Friend;

	// Token: 0x04000E95 RID: 3733
	[Token(Token = "0x4000B74")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int CloseHour_Friend;

	// Token: 0x04000E96 RID: 3734
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int Holiday_OpenHour_Friend;

	// Token: 0x04000E97 RID: 3735
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int Holiday_CloseHour_Friend;

	// Token: 0x04000E98 RID: 3736
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public GameFlagData OpenFlag;

	// Token: 0x04000E99 RID: 3737
	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x0")]
	private static DoorDataTableArray _DoorDataTableArray;
}
