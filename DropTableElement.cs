using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B2F RID: 2863
[Token(Token = "0x2000779")]
[Serializable]
public struct DropTableElement
{
	// Token: 0x0400AA13 RID: 43539
	[Token(Token = "0x4008039")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public ItemID ItemID;

	// Token: 0x0400AA14 RID: 43540
	[Token(Token = "0x400803A")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public int LevelMin;

	// Token: 0x0400AA15 RID: 43541
	[Token(Token = "0x400803B")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public int LevelMax;

	// Token: 0x0400AA16 RID: 43542
	[Token(Token = "0x400803C")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public int AmountMin;

	// Token: 0x0400AA17 RID: 43543
	[Token(Token = "0x400803D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int AmountMax;

	// Token: 0x0400AA18 RID: 43544
	[Token(Token = "0x400803E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int DropRate;
}
