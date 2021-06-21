using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200037B RID: 891
[Token(Token = "0x20002A5")]
[Serializable]
public class HitSoundDataTable
{
	// Token: 0x060016D2 RID: 5842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001442")]
	[Address(RVA = "0x24F6ED0", Offset = "0x24F6FD1", VA = "0x24F6ED0")]
	public static HitSoundDataTable GetDataTable(HitSoundID id)
	{
		return null;
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001443")]
	[Address(RVA = "0x24F7060", Offset = "0x24F7161", VA = "0x24F7060")]
	public HitSoundDataTable()
	{
	}

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemCategory ItemCategory;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public HitSoundData Data;

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x0")]
	private static HitSoundDataTableArray _HitSoundDataTableArray;
}
