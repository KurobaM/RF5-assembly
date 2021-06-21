using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x200029F")]
[Serializable]
public class FishingGomiDataTable
{
	// Token: 0x060016BF RID: 5823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001430")]
	[Address(RVA = "0x1EC7CE0", Offset = "0x1EC7DE1", VA = "0x1EC7CE0")]
	public FishingGomiDataTable()
	{
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001431")]
	[Address(RVA = "0x1EC7CF0", Offset = "0x1EC7DF1", VA = "0x1EC7CF0")]
	public FishingGomiDataTable(ItemID item_id, int akikan, int nagagutsu, int reanaakikan)
	{
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001432")]
	[Address(RVA = "0x1EC7D40", Offset = "0x1EC7E41", VA = "0x1EC7D40")]
	private static FishingGomiDataTable GetDataTable(ItemID Rod)
	{
		return null;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0000A0F8 File Offset: 0x000082F8
	[Token(Token = "0x6001433")]
	[Address(RVA = "0x1EC7F20", Offset = "0x1EC8021", VA = "0x1EC7F20")]
	public static ItemID ReLottery(ItemID rod)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001434")]
	[Address(RVA = "0x1EC7FF0", Offset = "0x1EC80F1", VA = "0x1EC7FF0")]
	public static void LoadData()
	{
	}

	// Token: 0x04000F1E RID: 3870
	[Token(Token = "0x4000BE6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID ItemID;

	// Token: 0x04000F1F RID: 3871
	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Akikan;

	// Token: 0x04000F20 RID: 3872
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Nagagutsu;

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int Reanaakikan;

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x8")]
	private static FishingGomiDataTableArray _FishingGomiDataTableArray;
}
