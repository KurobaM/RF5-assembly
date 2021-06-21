using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C3 RID: 963
[Token(Token = "0x20002E6")]
[Serializable]
public class SkillDataTable
{
	// Token: 0x06001777 RID: 6007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x1DE7910", Offset = "0x1DE7A11", VA = "0x1DE7910")]
	public static SkillDataTable GetDataTable(SkillID id)
	{
		return null;
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x1DE7A50", Offset = "0x1DE7B51", VA = "0x1DE7A50")]
	public SkillDataTable()
	{
	}

	// Token: 0x040010B7 RID: 4279
	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FloatParameter Parameter;

	// Token: 0x040010B8 RID: 4280
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	public float ReduceRp;

	// Token: 0x040010B9 RID: 4281
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public int MaxLevel;

	// Token: 0x040010BA RID: 4282
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public SkillLevelupType SkillLevelupType;

	// Token: 0x040010BB RID: 4283
	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x0")]
	private static SkillDataTableArray _SkillDataTableArray;
}
