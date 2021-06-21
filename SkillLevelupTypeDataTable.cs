using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C4 RID: 964
[Token(Token = "0x20002E7")]
[Serializable]
public class SkillLevelupTypeDataTable
{
	// Token: 0x06001779 RID: 6009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x1DE8490", Offset = "0x1DE8591", VA = "0x1DE8490")]
	public static SkillLevelupTypeDataTable GetDataTable(SkillLevelupType id)
	{
		return null;
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x1DE85D0", Offset = "0x1DE86D1", VA = "0x1DE85D0")]
	public SkillLevelupTypeDataTable()
	{
	}

	// Token: 0x040010BC RID: 4284
	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int[] NeedExps;

	// Token: 0x040010BD RID: 4285
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x0")]
	private static SkillLevelupTypeDataTableArray _SkillLevelupTypeDataTableArray;
}
