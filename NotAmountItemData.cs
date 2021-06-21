using System;
using Il2CppDummyDll;

// Token: 0x02000855 RID: 2133
[Token(Token = "0x200057A")]
public abstract class NotAmountItemData : ItemData
{
	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x0600388C RID: 14476 RVA: 0x00013860 File Offset: 0x00011A60
	[Token(Token = "0x1700062B")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8770", Offset = "0x1B8871")]
	public override int Amount
	{
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x1E25210", Offset = "0x1E25311", VA = "0x1E25210", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x0600388D RID: 14477 RVA: 0x00013878 File Offset: 0x00011A78
	[Token(Token = "0x1700062C")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8780", Offset = "0x1B8881")]
	public override int ItemLevel
	{
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x1E25220", Offset = "0x1E25321", VA = "0x1E25220", Slot = "5")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x0600388E RID: 14478 RVA: 0x00013890 File Offset: 0x00011A90
	[Token(Token = "0x1700062D")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8790", Offset = "0x1B8891")]
	public override int FreeSpace
	{
		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x1E25230", Offset = "0x1E25331", VA = "0x1E25230", Slot = "6")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x0600388F RID: 14479 RVA: 0x000138A8 File Offset: 0x00011AA8
	[Token(Token = "0x1700062E")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B87A0", Offset = "0x1B88A1")]
	public override int SortValue
	{
		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x1E25240", Offset = "0x1E25341", VA = "0x1E25240", Slot = "7")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003890 RID: 14480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F14")]
	[Address(RVA = "0x1E25250", Offset = "0x1E25351", VA = "0x1E25250", Slot = "8")]
	public override void AppendMigrate(ItemData ItemData)
	{
	}

	// Token: 0x06003891 RID: 14481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F15")]
	[Address(RVA = "0x1E25260", Offset = "0x1E25361", VA = "0x1E25260", Slot = "9")]
	public override ItemData Pop(int amount)
	{
		return null;
	}

	// Token: 0x06003892 RID: 14482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F16")]
	[Address(RVA = "0x1E25290", Offset = "0x1E25391", VA = "0x1E25290", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x06003893 RID: 14483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F17")]
	protected static void CopyTo<T>(T[] source, out T[] to)
	{
	}

	// Token: 0x06003894 RID: 14484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F18")]
	[Address(RVA = "0x1E25330", Offset = "0x1E25431", VA = "0x1E25330")]
	protected NotAmountItemData()
	{
	}

	// Token: 0x04007B80 RID: 31616
	[Token(Token = "0x4006FA0")]
	[FieldOffset(Offset = "0x14")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B700", Offset = "0x16B801")]
	public int Level;

	// Token: 0x04007B81 RID: 31617
	[Token(Token = "0x4006FA1")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x16B720", Offset = "0x16B821")]
	private bool Poped;
}
