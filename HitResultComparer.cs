using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E5 RID: 741
[Token(Token = "0x2000243")]
internal class HitResultComparer : IComparer<HitResult>
{
	// Token: 0x060013A2 RID: 5026 RVA: 0x00008E20 File Offset: 0x00007020
	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x24F6D40", Offset = "0x24F6E41", VA = "0x24F6D40", Slot = "4")]
	public int Compare(HitResult a, HitResult b)
	{
		return 0;
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x24F4F00", Offset = "0x24F5001", VA = "0x24F4F00")]
	public HitResultComparer()
	{
	}

	// Token: 0x04000B04 RID: 2820
	[Token(Token = "0x400089C")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 center;
}
