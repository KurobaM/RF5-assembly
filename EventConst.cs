using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200036F RID: 879
[Token(Token = "0x200029B")]
public class EventConst : ScriptableObject
{
	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A7")]
	public static EventConst Instance
	{
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x1DAF050", Offset = "0x1DAF151", VA = "0x1DAF050")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001428")]
	[Address(RVA = "0x1DAF160", Offset = "0x1DAF261", VA = "0x1DAF160")]
	public EventConst()
	{
	}

	// Token: 0x04000F06 RID: 3846
	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x18")]
	public int HeadNotEquip_Lottery;

	// Token: 0x04000F07 RID: 3847
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x0")]
	private static EventConst _Instance;
}
