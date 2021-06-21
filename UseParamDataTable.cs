using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CE RID: 974
[Token(Token = "0x20002F0")]
[Serializable]
public class UseParamDataTable
{
	// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x1E46980", Offset = "0x1E46A81", VA = "0x1E46980")]
	public static UseParamDataTable GetDataTable(ItemID itemID)
	{
		return null;
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x0000A428 File Offset: 0x00008628
	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x1E46B20", Offset = "0x1E46C21", VA = "0x1E46B20")]
	public static bool HasDataTable(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x1E46B10", Offset = "0x1E46C11", VA = "0x1E46B10")]
	public UseParamDataTable()
	{
	}

	// Token: 0x040010E5 RID: 4325
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public UseMotionType UseMotionType;

	// Token: 0x040010E6 RID: 4326
	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public UseParameter UseParameter;

	// Token: 0x040010E7 RID: 4327
	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int BuffTimeHour;

	// Token: 0x040010E8 RID: 4328
	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int LevelRate;

	// Token: 0x040010E9 RID: 4329
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public EffectID UseEffect;

	// Token: 0x040010EA RID: 4330
	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0x0")]
	private static UseParamDataTableArray _UseParamDataTableArray;
}
