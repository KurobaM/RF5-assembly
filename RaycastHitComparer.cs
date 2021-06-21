using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x2000242")]
internal class RaycastHitComparer : IComparer<RaycastHit>
{
	// Token: 0x060013A0 RID: 5024 RVA: 0x00008E08 File Offset: 0x00007008
	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x1F3ACE0", Offset = "0x1F3ADE1", VA = "0x1F3ACE0", Slot = "4")]
	public int Compare(RaycastHit a, RaycastHit b)
	{
		return 0;
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x1F3AE20", Offset = "0x1F3AF21", VA = "0x1F3AE20")]
	public RaycastHitComparer()
	{
	}

	// Token: 0x04000B03 RID: 2819
	[Token(Token = "0x400089B")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 center;
}
