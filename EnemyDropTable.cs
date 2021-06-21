using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B30 RID: 2864
[Token(Token = "0x200077A")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1471C0", Offset = "0x1472C1")]
[Serializable]
public class EnemyDropTable : ScriptableObject
{
	// Token: 0x060049E6 RID: 18918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003DD8")]
	[Address(RVA = "0x22B3970", Offset = "0x22B3A71", VA = "0x22B3970")]
	public List<ItemData> GetDropItemDataByLottery()
	{
		return null;
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x00017C58 File Offset: 0x00015E58
	[Token(Token = "0x6003DD9")]
	[Address(RVA = "0x22B3C30", Offset = "0x22B3D31", VA = "0x22B3C30")]
	private static int IntKeta(int x)
	{
		return 0;
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DDA")]
	[Address(RVA = "0x22B3C90", Offset = "0x22B3D91", VA = "0x22B3C90")]
	public EnemyDropTable()
	{
	}

	// Token: 0x0400AA19 RID: 43545
	[Token(Token = "0x400803F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int digits;

	// Token: 0x0400AA1A RID: 43546
	[Token(Token = "0x4008040")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int InnerMagnification;

	// Token: 0x0400AA1B RID: 43547
	[Token(Token = "0x4008041")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int PercentageRage;

	// Token: 0x0400AA1C RID: 43548
	[Token(Token = "0x4008042")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public DropTableElement[] DropTables;
}
