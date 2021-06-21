using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200068A RID: 1674
[Token(Token = "0x20004AC")]
[Serializable]
public struct MonsterMoveSpeedData
{
	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x06002924 RID: 10532 RVA: 0x000101E8 File Offset: 0x0000E3E8
	[Token(Token = "0x17000537")]
	public static MonsterMoveSpeedData Default
	{
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x1E6E210", Offset = "0x1E6E311", VA = "0x1E6E210")]
		get
		{
			return default(MonsterMoveSpeedData);
		}
	}

	// Token: 0x040070EA RID: 28906
	[Token(Token = "0x40068E6")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168BC0", Offset = "0x168CC1")]
	[SerializeField]
	public MonsterMoveSpeedPair[] MoveSpeedArray;
}
