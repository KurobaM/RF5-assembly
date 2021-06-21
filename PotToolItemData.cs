using System;
using Il2CppDummyDll;

// Token: 0x02000856 RID: 2134
[Token(Token = "0x200057B")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x1465B0", Offset = "0x1466B1")]
public class PotToolItemData : EquipItemData
{
	// Token: 0x06003895 RID: 14485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F19")]
	[Address(RVA = "0x280A560", Offset = "0x280A661", VA = "0x280A560", Slot = "10")]
	public override ItemData Copy()
	{
		return null;
	}

	// Token: 0x06003896 RID: 14486 RVA: 0x000138C0 File Offset: 0x00011AC0
	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x280A5F0", Offset = "0x280A6F1", VA = "0x280A5F0")]
	public int GetMaxCapacityByDataTable()
	{
		return 0;
	}

	// Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x280A6F0", Offset = "0x280A7F1", VA = "0x280A6F0")]
	public PotToolItemData()
	{
	}

	// Token: 0x04007B82 RID: 31618
	[Token(Token = "0x4006FA2")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B730", Offset = "0x16B831")]
	public int Capacity;
}
