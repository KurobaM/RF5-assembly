using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x2000241")]
internal class ColliderComparer : IComparer<Collider>
{
	// Token: 0x0600139E RID: 5022 RVA: 0x00008DF0 File Offset: 0x00006FF0
	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x1EA20E0", Offset = "0x1EA21E1", VA = "0x1EA20E0", Slot = "4")]
	public int Compare(Collider a, Collider b)
	{
		return 0;
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x1EA2240", Offset = "0x1EA2341", VA = "0x1EA2240")]
	public ColliderComparer()
	{
	}

	// Token: 0x04000B02 RID: 2818
	[Token(Token = "0x400089A")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 center;
}
