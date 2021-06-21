using System;
using Il2CppDummyDll;

// Token: 0x02000850 RID: 2128
[Token(Token = "0x2000576")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1463E0", Offset = "0x1464E1")]
public class FoodItemData : SynthesisItemData
{
	// Token: 0x170007D7 RID: 2007
	// (get) Token: 0x0600386A RID: 14442 RVA: 0x00013728 File Offset: 0x00011928
	[Token(Token = "0x1700061C")]
	[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x1B8680", Offset = "0x1B8781")]
	public override bool CalcCheckGomi
	{
		[Token(Token = "0x6002EEE")]
		[Address(RVA = "0x1ECD550", Offset = "0x1ECD651", VA = "0x1ECD550", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x1ECD5F0", Offset = "0x1ECD6F1", VA = "0x1ECD5F0", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x00013740 File Offset: 0x00011940
	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x1ECD680", Offset = "0x1ECD781", VA = "0x1ECD680", Slot = "18")]
	public override bool CheckIsArrenge()
	{
		return default(bool);
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x1ECD690", Offset = "0x1ECD791", VA = "0x1ECD690")]
	public FoodItemData()
	{
	}

	// Token: 0x04007B78 RID: 31608
	[Token(Token = "0x4006F9D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B6A0", Offset = "0x16B7A1")]
	public bool IsArrange;
}
