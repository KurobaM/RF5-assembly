using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001063 RID: 4195
	[Token(Token = "0x2000AA5")]
	[Serializable]
	public class FishRecord
	{
		// Token: 0x060069B0 RID: 27056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005804")]
		[Address(RVA = "0x20356F0", Offset = "0x20357F1", VA = "0x20356F0")]
		public FishRecord(ItemID id, int min, int max, int stamp)
		{
		}

		// Token: 0x040171C0 RID: 94656
		[Token(Token = "0x4013DFD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ItemID Id;

		// Token: 0x040171C1 RID: 94657
		[Token(Token = "0x4013DFE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public Vector3Int Size;
	}
}
