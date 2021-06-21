using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace SplineMesh
{
	// Token: 0x02000E48 RID: 3656
	[Token(Token = "0x200095C")]
	[Serializable]
	public class TrackSegment
	{
		// Token: 0x06006032 RID: 24626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA0")]
		[Address(RVA = "0x2386240", Offset = "0x2386341", VA = "0x2386240")]
		public TrackSegment()
		{
		}

		// Token: 0x0400BF32 RID: 48946
		[Token(Token = "0x4008F0B")]
		[FieldOffset(Offset = "0x10")]
		public List<TransformedMesh> transformedMeshes;
	}
}
