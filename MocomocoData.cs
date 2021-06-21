using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000538 RID: 1336
[Token(Token = "0x20003C9")]
[Serializable]
public class MocomocoData
{
	// Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x1D7FEC0", Offset = "0x1D7FFC1", VA = "0x1D7FEC0")]
	public MocomocoData()
	{
	}

	// Token: 0x04006745 RID: 26437
	[Token(Token = "0x400614A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SnowmanObjectID SnowmanObjectID;

	// Token: 0x04006746 RID: 26438
	[Token(Token = "0x400614B")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public MonsterDataID MonsterDataID;

	// Token: 0x04006747 RID: 26439
	[Token(Token = "0x400614C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Result;

	// Token: 0x04006748 RID: 26440
	[Token(Token = "0x400614D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float WaitTime;

	// Token: 0x04006749 RID: 26441
	[Token(Token = "0x400614E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float BlowRate;
}
