using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XftWeapon
{
	// Token: 0x02000BC6 RID: 3014
	[Token(Token = "0x20007D6")]
	public class VertexPool
	{
		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F8")]
		public Mesh MyMesh
		{
			[Token(Token = "0x60040A1")]
			[Address(RVA = "0x1E58D30", Offset = "0x1E58E31", VA = "0x1E58D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x1E58E40", Offset = "0x1E58F41", VA = "0x1E58E40")]
		public void RecalculateBounds()
		{
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x1E58E60", Offset = "0x1E58F61", VA = "0x1E58E60")]
		public void SetMeshObjectActive(bool flag)
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x1E58F20", Offset = "0x1E59021", VA = "0x1E58F20")]
		private void CreateMeshObj(XWeaponTrail owner, Material material)
		{
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A5")]
		[Address(RVA = "0x1E59240", Offset = "0x1E59341", VA = "0x1E59240")]
		public void Destroy()
		{
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x1E59360", Offset = "0x1E59461", VA = "0x1E59360")]
		public VertexPool(Material material, XWeaponTrail owner)
		{
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x1E59550", Offset = "0x1E59651", VA = "0x1E59550")]
		public VertexPool.VertexSegment GetVertices(int vcount, int icount)
		{
			return null;
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x1E59460", Offset = "0x1E59561", VA = "0x1E59460")]
		protected void InitArrays()
		{
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x1E596C0", Offset = "0x1E597C1", VA = "0x1E596C0")]
		public void EnlargeArrays(int count, int icount)
		{
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x1E598B0", Offset = "0x1E599B1", VA = "0x1E598B0")]
		public void LateUpdate()
		{
		}

		// Token: 0x0400AE8D RID: 44685
		[Token(Token = "0x40083AA")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] Vertices;

		// Token: 0x0400AE8E RID: 44686
		[Token(Token = "0x40083AB")]
		[FieldOffset(Offset = "0x18")]
		public int[] Indices;

		// Token: 0x0400AE8F RID: 44687
		[Token(Token = "0x40083AC")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] UVs;

		// Token: 0x0400AE90 RID: 44688
		[Token(Token = "0x40083AD")]
		[FieldOffset(Offset = "0x28")]
		public Color[] Colors;

		// Token: 0x0400AE91 RID: 44689
		[Token(Token = "0x40083AE")]
		[FieldOffset(Offset = "0x30")]
		public bool IndiceChanged;

		// Token: 0x0400AE92 RID: 44690
		[Token(Token = "0x40083AF")]
		[FieldOffset(Offset = "0x31")]
		public bool ColorChanged;

		// Token: 0x0400AE93 RID: 44691
		[Token(Token = "0x40083B0")]
		[FieldOffset(Offset = "0x32")]
		public bool UVChanged;

		// Token: 0x0400AE94 RID: 44692
		[Token(Token = "0x40083B1")]
		[FieldOffset(Offset = "0x33")]
		public bool VertChanged;

		// Token: 0x0400AE95 RID: 44693
		[Token(Token = "0x40083B2")]
		[FieldOffset(Offset = "0x34")]
		public bool UV2Changed;

		// Token: 0x0400AE96 RID: 44694
		[Token(Token = "0x40083B3")]
		[FieldOffset(Offset = "0x38")]
		protected int VertexTotal;

		// Token: 0x0400AE97 RID: 44695
		[Token(Token = "0x40083B4")]
		[FieldOffset(Offset = "0x3C")]
		protected int VertexUsed;

		// Token: 0x0400AE98 RID: 44696
		[Token(Token = "0x40083B5")]
		[FieldOffset(Offset = "0x40")]
		protected int IndexTotal;

		// Token: 0x0400AE99 RID: 44697
		[Token(Token = "0x40083B6")]
		[FieldOffset(Offset = "0x44")]
		protected int IndexUsed;

		// Token: 0x0400AE9A RID: 44698
		[Token(Token = "0x40083B7")]
		[FieldOffset(Offset = "0x48")]
		public bool FirstUpdate;

		// Token: 0x0400AE9B RID: 44699
		[Token(Token = "0x40083B8")]
		[FieldOffset(Offset = "0x49")]
		protected bool VertCountChanged;

		// Token: 0x0400AE9C RID: 44700
		[Token(Token = "0x40083B9")]
		public const int BlockSize = 108;

		// Token: 0x0400AE9D RID: 44701
		[Token(Token = "0x40083BA")]
		[FieldOffset(Offset = "0x4C")]
		public float BoundsScheduleTime;

		// Token: 0x0400AE9E RID: 44702
		[Token(Token = "0x40083BB")]
		[FieldOffset(Offset = "0x50")]
		public float ElapsedTime;

		// Token: 0x0400AE9F RID: 44703
		[Token(Token = "0x40083BC")]
		[FieldOffset(Offset = "0x58")]
		protected XWeaponTrail _owner;

		// Token: 0x0400AEA0 RID: 44704
		[Token(Token = "0x40083BD")]
		[FieldOffset(Offset = "0x60")]
		protected MeshFilter _meshFilter;

		// Token: 0x0400AEA1 RID: 44705
		[Token(Token = "0x40083BE")]
		[FieldOffset(Offset = "0x68")]
		protected Mesh _mesh2d;

		// Token: 0x0400AEA2 RID: 44706
		[Token(Token = "0x40083BF")]
		[FieldOffset(Offset = "0x70")]
		protected Material _material;

		// Token: 0x02000BC7 RID: 3015
		[Token(Token = "0x2001370")]
		public class VertexSegment
		{
			// Token: 0x06004D14 RID: 19732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600774B")]
			[Address(RVA = "0x1E59850", Offset = "0x1E59951", VA = "0x1E59850")]
			public VertexSegment(int start, int count, int istart, int icount, VertexPool pool)
			{
			}

			// Token: 0x06004D15 RID: 19733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600774C")]
			[Address(RVA = "0x1E59AE0", Offset = "0x1E59BE1", VA = "0x1E59AE0")]
			public void ClearIndices()
			{
			}

			// Token: 0x0400AEA3 RID: 44707
			[Token(Token = "0x401B73C")]
			[FieldOffset(Offset = "0x10")]
			public int VertStart;

			// Token: 0x0400AEA4 RID: 44708
			[Token(Token = "0x401B73D")]
			[FieldOffset(Offset = "0x14")]
			public int IndexStart;

			// Token: 0x0400AEA5 RID: 44709
			[Token(Token = "0x401B73E")]
			[FieldOffset(Offset = "0x18")]
			public int VertCount;

			// Token: 0x0400AEA6 RID: 44710
			[Token(Token = "0x401B73F")]
			[FieldOffset(Offset = "0x1C")]
			public int IndexCount;

			// Token: 0x0400AEA7 RID: 44711
			[Token(Token = "0x401B740")]
			[FieldOffset(Offset = "0x20")]
			public VertexPool Pool;
		}
	}
}
