using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Fishing
{
	// Token: 0x02001058 RID: 4184
	[Token(Token = "0x2000AA0")]
	public class FishObject : MonoBehaviour
	{
		// Token: 0x06006963 RID: 26979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D5")]
		[Address(RVA = "0x2034AD0", Offset = "0x2034BD1", VA = "0x2034AD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D6")]
		[Address(RVA = "0x2034E40", Offset = "0x2034F41", VA = "0x2034E40")]
		public FishObject()
		{
		}

		// Token: 0x04017160 RID: 94560
		[Token(Token = "0x4013DBF")]
		[FieldOffset(Offset = "0x18")]
		public int Index;

		// Token: 0x04017161 RID: 94561
		[Token(Token = "0x4013DC0")]
		[FieldOffset(Offset = "0x20")]
		public FishSwim FishSwim;
	}
}
