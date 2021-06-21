using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001040 RID: 4160
	[Token(Token = "0x2000A8F")]
	public class BathroomBlock : FurnitureBlock
	{
		// Token: 0x06006892 RID: 26770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005716")]
		[Address(RVA = "0x2239A50", Offset = "0x2239B51", VA = "0x2239A50", Slot = "5")]
		protected override void OnStayEvent(Collider fromCollider, Collider toCollider)
		{
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005717")]
		[Address(RVA = "0x2239D10", Offset = "0x2239E11", VA = "0x2239D10")]
		public BathroomBlock()
		{
		}

		// Token: 0x040170F9 RID: 94457
		[Token(Token = "0x4013D77")]
		[FieldOffset(Offset = "0x30")]
		public bool IsMale;
	}
}
