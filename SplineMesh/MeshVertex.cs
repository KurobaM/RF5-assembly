using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E51 RID: 3665
	[Token(Token = "0x2000961")]
	[Serializable]
	public class MeshVertex
	{
		// Token: 0x0600606C RID: 24684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x237DAF0", Offset = "0x237DBF1", VA = "0x237DAF0")]
		public MeshVertex(Vector3 position, Vector3 normal, Vector2 uv)
		{
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCC")]
		[Address(RVA = "0x237DB80", Offset = "0x237DC81", VA = "0x237DB80")]
		public MeshVertex(Vector3 position, Vector3 normal)
		{
		}

		// Token: 0x0400BF69 RID: 49001
		[Token(Token = "0x4008F30")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x0400BF6A RID: 49002
		[Token(Token = "0x4008F31")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		// Token: 0x0400BF6B RID: 49003
		[Token(Token = "0x4008F32")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 uv;
	}
}
