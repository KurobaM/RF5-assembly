using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000339 RID: 825
[Token(Token = "0x200026A")]
[Serializable]
public class ActorData
{
	// Token: 0x0600162F RID: 5679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x1D4AB40", Offset = "0x1D4AC41", VA = "0x1D4AB40")]
	public ActorData()
	{
	}

	// Token: 0x04000CC6 RID: 3270
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID ActorId;

	// Token: 0x04000CC7 RID: 3271
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public ActorGroup Group;

	// Token: 0x04000CC8 RID: 3272
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<CharID> CharId;
}
