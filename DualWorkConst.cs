using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000367 RID: 871
[Token(Token = "0x2000294")]
public class DualWorkConst : ScriptableObject
{
	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A6")]
	public static DualWorkConst Instance
	{
		[Token(Token = "0x6001416")]
		[Address(RVA = "0x1E09510", Offset = "0x1E09611", VA = "0x1E09510")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001417")]
	[Address(RVA = "0x1E0DE50", Offset = "0x1E0DF51", VA = "0x1E0DE50")]
	public DualWorkConst()
	{
	}

	// Token: 0x04000EBA RID: 3770
	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x18")]
	public int EnableLevel;

	// Token: 0x04000EBB RID: 3771
	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x0")]
	private static DualWorkConst _Instance;
}
