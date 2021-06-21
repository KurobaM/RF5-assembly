using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000384 RID: 900
[Token(Token = "0x20002AE")]
public class ItemConst : ScriptableObject
{
	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003AB")]
	public static ItemConst Instance
	{
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x22366D0", Offset = "0x22367D1", VA = "0x22366D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600145E")]
	[Address(RVA = "0x22367E0", Offset = "0x22368E1", VA = "0x22367E0")]
	public ItemConst()
	{
	}

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x18")]
	public GameFlagData HideFurnitureFlag;

	// Token: 0x04000FA1 RID: 4001
	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x1C")]
	public int LevelMin;

	// Token: 0x04000FA2 RID: 4002
	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x20")]
	public int LevelMax;

	// Token: 0x04000FA3 RID: 4003
	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x0")]
	private static ItemConst _Instance;
}
