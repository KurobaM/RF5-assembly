using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000530 RID: 1328
[Token(Token = "0x20003C3")]
[Serializable]
public class PetNpcPetData
{
	// Token: 0x06002031 RID: 8241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x2141FA0", Offset = "0x21420A1", VA = "0x2141FA0")]
	public PetNpcPetData()
	{
	}

	// Token: 0x04006719 RID: 26393
	[Token(Token = "0x4006126")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID ActorID;

	// Token: 0x0400671A RID: 26394
	[Token(Token = "0x4006127")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public MonsterDataID MonsterDataID1;

	// Token: 0x0400671B RID: 26395
	[Token(Token = "0x4006128")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterDataID MonsterDataID2;

	// Token: 0x0400671C RID: 26396
	[Token(Token = "0x4006129")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Gender Gender;
}
