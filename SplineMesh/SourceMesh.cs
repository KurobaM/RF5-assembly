using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000962")]
	public struct SourceMesh
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		internal Mesh Mesh
		{
			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0x2E2FD0", Offset = "0x2E30D1", VA = "0x2E2FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC6E0", Offset = "0x1AC7E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DF")]
		internal List<MeshVertex> Vertices
		{
			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x2E2FE0", Offset = "0x2E30E1", VA = "0x2E2FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		internal int[] Triangles
		{
			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x2E3020", Offset = "0x2E3121", VA = "0x2E3020")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00020430 File Offset: 0x0001E630
		[Token(Token = "0x170009E1")]
		internal float MinX
		{
			[Token(Token = "0x6004FD0")]
			[Address(RVA = "0x2E3060", Offset = "0x2E3161", VA = "0x2E3060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x00020448 File Offset: 0x0001E648
		[Token(Token = "0x170009E2")]
		internal float Length
		{
			[Token(Token = "0x6004FD1")]
			[Address(RVA = "0x2E30A0", Offset = "0x2E31A1", VA = "0x2E30A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD2")]
		[Address(RVA = "0x2E30E0", Offset = "0x2E31E1", VA = "0x2E30E0")]
		private SourceMesh(Mesh mesh)
		{
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x2E3140", Offset = "0x2E3241", VA = "0x2E3140")]
		private SourceMesh(SourceMesh other)
		{
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00020460 File Offset: 0x0001E660
		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x237FE60", Offset = "0x237FF61", VA = "0x237FE60")]
		public static SourceMesh Build(Mesh mesh)
		{
			return default(SourceMesh);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00020478 File Offset: 0x0001E678
		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x2E31C0", Offset = "0x2E32C1", VA = "0x2E31C0")]
		public SourceMesh Translate(Vector3 translation)
		{
			return default(SourceMesh);
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00020490 File Offset: 0x0001E690
		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x2E32C0", Offset = "0x2E33C1", VA = "0x2E32C0")]
		public SourceMesh Translate(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x000204A8 File Offset: 0x0001E6A8
		[Token(Token = "0x6004FD7")]
		[Address(RVA = "0x2E33D0", Offset = "0x2E34D1", VA = "0x2E33D0")]
		public SourceMesh Rotate(Quaternion rotation)
		{
			return default(SourceMesh);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[Token(Token = "0x6004FD8")]
		[Address(RVA = "0x2E34D0", Offset = "0x2E35D1", VA = "0x2E34D0")]
		public SourceMesh Scale(Vector3 scale)
		{
			return default(SourceMesh);
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x000204D8 File Offset: 0x0001E6D8
		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x2E35D0", Offset = "0x2E36D1", VA = "0x2E35D0")]
		public SourceMesh Scale(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x2E36E0", Offset = "0x2E37E1", VA = "0x2E36E0")]
		private void BuildData()
		{
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x000204F0 File Offset: 0x0001E6F0
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x2E36F0", Offset = "0x2E37F1", VA = "0x2E36F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x00020508 File Offset: 0x0001E708
		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x2E3700", Offset = "0x2E3801", VA = "0x2E3700", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x00020520 File Offset: 0x0001E720
		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x237AB90", Offset = "0x237AC91", VA = "0x237AB90")]
		public static bool operator ==(SourceMesh sm1, SourceMesh sm2)
		{
			return default(bool);
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x00020538 File Offset: 0x0001E738
		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x2380730", Offset = "0x2380831", VA = "0x2380730")]
		public static bool operator !=(SourceMesh sm1, SourceMesh sm2)
		{
			return default(bool);
		}

		// Token: 0x0400BF6C RID: 49004
		[Token(Token = "0x4008F33")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 translation;

		// Token: 0x0400BF6D RID: 49005
		[Token(Token = "0x4008F34")]
		[FieldOffset(Offset = "0xC")]
		private Quaternion rotation;

		// Token: 0x0400BF6E RID: 49006
		[Token(Token = "0x4008F35")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 scale;

		// Token: 0x0400BF6F RID: 49007
		[Token(Token = "0x4008F36")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17E7D0", Offset = "0x17E8D1")]
		private readonly Mesh <Mesh>k__BackingField;

		// Token: 0x0400BF70 RID: 49008
		[Token(Token = "0x4008F37")]
		[FieldOffset(Offset = "0x30")]
		private List<MeshVertex> vertices;

		// Token: 0x0400BF71 RID: 49009
		[Token(Token = "0x4008F38")]
		[FieldOffset(Offset = "0x38")]
		private int[] triangles;

		// Token: 0x0400BF72 RID: 49010
		[Token(Token = "0x4008F39")]
		[FieldOffset(Offset = "0x40")]
		private float minX;

		// Token: 0x0400BF73 RID: 49011
		[Token(Token = "0x4008F3A")]
		[FieldOffset(Offset = "0x44")]
		private float length;
	}
}
