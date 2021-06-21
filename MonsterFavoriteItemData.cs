using System;
using Il2CppDummyDll;

// Token: 0x02000686 RID: 1670
[Token(Token = "0x20004A9")]
[Serializable]
public class MonsterFavoriteItemData
{
	// Token: 0x0600291C RID: 10524 RVA: 0x000101A0 File Offset: 0x0000E3A0
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x1E60BF0", Offset = "0x1E60CF1", VA = "0x1E60BF0")]
	public bool CheckLikeItem(ItemID id, out int likePoint)
	{
		return default(bool);
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022C0")]
	[Address(RVA = "0x1E60CA0", Offset = "0x1E60DA1", VA = "0x1E60CA0")]
	public MonsterFavoriteItemData()
	{
	}

	// Token: 0x040070E5 RID: 28901
	[Token(Token = "0x40068E3")]
	[FieldOffset(Offset = "0x10")]
	public ItemID[] ItemIDArray;

	// Token: 0x040070E6 RID: 28902
	[Token(Token = "0x40068E4")]
	[FieldOffset(Offset = "0x18")]
	public int[] LikePointArray;
}
