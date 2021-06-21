using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E49 RID: 3657
	[Token(Token = "0x200095D")]
	[Serializable]
	public class TransformedMesh
	{
		// Token: 0x06006033 RID: 24627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA1")]
		[Address(RVA = "0x23862C0", Offset = "0x23863C1", VA = "0x23862C0")]
		public TransformedMesh()
		{
		}

		// Token: 0x0400BF33 RID: 48947
		[Token(Token = "0x4008F0C")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		// Token: 0x0400BF34 RID: 48948
		[Token(Token = "0x4008F0D")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x0400BF35 RID: 48949
		[Token(Token = "0x4008F0E")]
		[FieldOffset(Offset = "0x20")]
		public PhysicMaterial physicMaterial;

		// Token: 0x0400BF36 RID: 48950
		[Token(Token = "0x4008F0F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 translation;

		// Token: 0x0400BF37 RID: 48951
		[Token(Token = "0x4008F10")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 rotation;

		// Token: 0x0400BF38 RID: 48952
		[Token(Token = "0x4008F11")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 scale;
	}
}
