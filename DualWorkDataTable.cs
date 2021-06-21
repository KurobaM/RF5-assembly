using System;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000368 RID: 872
[Token(Token = "0x2000295")]
[Serializable]
public class DualWorkDataTable
{
	// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x1E09620", Offset = "0x1E09721", VA = "0x1E09620")]
	public static DualWorkDataTable GetDataTable(int loveLevel)
	{
		return null;
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x1E0DE60", Offset = "0x1E0DF61", VA = "0x1E0DE60")]
	public DualWorkDataTable()
	{
	}

	// Token: 0x04000EBC RID: 3772
	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float LotteryRate;

	// Token: 0x04000EBD RID: 3773
	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float BarSpeed;

	// Token: 0x04000EBE RID: 3774
	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int SuccessGaugeBase;

	// Token: 0x04000EBF RID: 3775
	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int SynchroGaugeNice;

	// Token: 0x04000EC0 RID: 3776
	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int SynchroGaugePerfect;

	// Token: 0x04000EC1 RID: 3777
	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int SynchroGaugeBad;

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x0")]
	private static DualWorkDataTableArray _DualWorkLoveDataTableArray;
}
