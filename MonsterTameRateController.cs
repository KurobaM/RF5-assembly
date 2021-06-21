using System;
using Il2CppDummyDll;

// Token: 0x020007A5 RID: 1957
[Token(Token = "0x2000525")]
public class MonsterTameRateController
{
	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x06003260 RID: 12896 RVA: 0x00011598 File Offset: 0x0000F798
	[Token(Token = "0x17000580")]
	private int PresentCount
	{
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x1E72BF0", Offset = "0x1E72CF1", VA = "0x1E72BF0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x000115B0 File Offset: 0x0000F7B0
	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x1E72C00", Offset = "0x1E72D01", VA = "0x1E72C00")]
	public float GetRate()
	{
		return 0f;
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x000115C8 File Offset: 0x0000F7C8
	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x1E72D30", Offset = "0x1E72E31", VA = "0x1E72D30")]
	public bool TryBrush()
	{
		return default(bool);
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x000115E0 File Offset: 0x0000F7E0
	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x1E72D90", Offset = "0x1E72E91", VA = "0x1E72D90")]
	public bool TryPresentItem(ItemID itemID, out bool isFavorite)
	{
		return default(bool);
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x000115F8 File Offset: 0x0000F7F8
	[Token(Token = "0x60029F5")]
	[Address(RVA = "0x1E72E40", Offset = "0x1E72F41", VA = "0x1E72E40")]
	public bool IsFavorite(ItemID itemID, out int likePoint)
	{
		return default(bool);
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x00011610 File Offset: 0x0000F810
	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x1E72F00", Offset = "0x1E73001", VA = "0x1E72F00")]
	public bool TryTakeDamageLoveAttribute()
	{
		return default(bool);
	}

	// Token: 0x06003266 RID: 12902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029F7")]
	[Address(RVA = "0x1E72F60", Offset = "0x1E73061", VA = "0x1E72F60")]
	public MonsterTameRateController(MonsterControllerBase owner)
	{
	}

	// Token: 0x0400770F RID: 30479
	[Token(Token = "0x4006C82")]
	[FieldOffset(Offset = "0x10")]
	private readonly MonsterControllerBase Owner;

	// Token: 0x04007710 RID: 30480
	[Token(Token = "0x4006C83")]
	[FieldOffset(Offset = "0x18")]
	private int BrushCount;

	// Token: 0x04007711 RID: 30481
	[Token(Token = "0x4006C84")]
	[FieldOffset(Offset = "0x1C")]
	private int PresentItemCount;

	// Token: 0x04007712 RID: 30482
	[Token(Token = "0x4006C85")]
	[FieldOffset(Offset = "0x20")]
	private int FavoritePresentItemCount;

	// Token: 0x04007713 RID: 30483
	[Token(Token = "0x4006C86")]
	[FieldOffset(Offset = "0x24")]
	private int FavoritePresentItemRate;

	// Token: 0x04007714 RID: 30484
	[Token(Token = "0x4006C87")]
	[FieldOffset(Offset = "0x28")]
	private int TakeDamageLoveAttributeCount;
}
