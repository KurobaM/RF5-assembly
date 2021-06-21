using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000898 RID: 2200
[Token(Token = "0x20005B0")]
public class EquipSubAttributeCollection
{
	// Token: 0x060039D9 RID: 14809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003049")]
	[Address(RVA = "0x22BBFD0", Offset = "0x22BC0D1", VA = "0x22BBFD0")]
	public void Add(ItemData itemData)
	{
	}

	// Token: 0x060039DA RID: 14810 RVA: 0x00013FB0 File Offset: 0x000121B0
	[Token(Token = "0x600304A")]
	[Address(RVA = "0x22BC280", Offset = "0x22BC381", VA = "0x22BC280")]
	private static bool CheckAdd(EquipItemData equipItemData, EquipSubAttribute subAttribute, bool isArrange)
	{
		return default(bool);
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x00013FC8 File Offset: 0x000121C8
	[Token(Token = "0x600304B")]
	[Address(RVA = "0x22B86D0", Offset = "0x22B87D1", VA = "0x22B86D0")]
	public static bool CheckGenre(EquipSubAttributeDataTable.AttributeGenre genre, ItemCategory category)
	{
		return default(bool);
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x00013FE0 File Offset: 0x000121E0
	[Token(Token = "0x600304C")]
	[Address(RVA = "0x22BC380", Offset = "0x22BC481", VA = "0x22BC380")]
	public bool HasSubAttribute(EquipSubAttribute subAttribute)
	{
		return default(bool);
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600304D")]
	[Address(RVA = "0x22BC3F0", Offset = "0x22BC4F1", VA = "0x22BC3F0")]
	public EquipSubAttributeCollection()
	{
	}

	// Token: 0x04007D6B RID: 32107
	[Token(Token = "0x4007160")]
	[FieldOffset(Offset = "0x10")]
	private HashSet<EquipSubAttribute> SubAttributes;
}
