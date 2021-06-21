using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200068E RID: 1678
[Token(Token = "0x20004B0")]
[Serializable]
public struct MonsterSearchRangeData
{
	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x06002926 RID: 10534 RVA: 0x00010200 File Offset: 0x0000E400
	[Token(Token = "0x17000538")]
	public static MonsterSearchRangeData Default
	{
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x1E71A30", Offset = "0x1E71B31", VA = "0x1E71A30")]
		get
		{
			return default(MonsterSearchRangeData);
		}
	}

	// Token: 0x040070F3 RID: 28915
	[Token(Token = "0x40068EF")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168C10", Offset = "0x168D11")]
	[SerializeField]
	public MonsterSearchRangePair[] SearchRangeArray;
}
