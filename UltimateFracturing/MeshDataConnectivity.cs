using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UltimateFracturing
{
	// Token: 0x02000C50 RID: 3152
	[Token(Token = "0x2000805")]
	public class MeshDataConnectivity
	{
		// Token: 0x06004FDE RID: 20446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004217")]
		[Address(RVA = "0x20F2890", Offset = "0x20F2991", VA = "0x20F2890")]
		public MeshDataConnectivity()
		{
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004218")]
		[Address(RVA = "0x20F4BF0", Offset = "0x20F4CF1", VA = "0x20F4BF0")]
		public MeshDataConnectivity GetDeepCopy()
		{
			return null;
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004219")]
		[Address(RVA = "0x20F8940", Offset = "0x20F8A41", VA = "0x20F8940")]
		public void NotifyNewClippedFace(MeshData meshDataSource, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Token(Token = "0x600421A")]
		[Address(RVA = "0x20F8DA0", Offset = "0x20F8EA1", VA = "0x20F8DA0")]
		public static int GetNewHash()
		{
			return 0;
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421B")]
		[Address(RVA = "0x20F8EC0", Offset = "0x20F8FC1", VA = "0x20F8EC0")]
		public void NotifyNewCapFace(int nHash, int nSubMesh, int nFaceIndex)
		{
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600421C")]
		[Address(RVA = "0x20F7F80", Offset = "0x20F8081", VA = "0x20F7F80")]
		public void NotifyRemappedFace(MeshDataConnectivity source, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}

		// Token: 0x0400B0B2 RID: 45234
		[Token(Token = "0x4008476")]
		[FieldOffset(Offset = "0x0")]
		public static int s_CurrentSharedFaceHash;

		// Token: 0x0400B0B3 RID: 45235
		[Token(Token = "0x4008477")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, List<MeshDataConnectivity.Face>> dicHash2FaceList;

		// Token: 0x0400B0B4 RID: 45236
		[Token(Token = "0x4008478")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<MeshDataConnectivity.Face, List<int>> dicFace2HashList;

		// Token: 0x0400B0B5 RID: 45237
		[Token(Token = "0x4008479")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<MeshDataConnectivity.Face, bool> dicFace2IsClipped;

		// Token: 0x02000C51 RID: 3153
		[Token(Token = "0x20013C5")]
		public struct Face
		{
			// Token: 0x06004FE5 RID: 20453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007894")]
			[Address(RVA = "0x2E1210", Offset = "0x2E1311", VA = "0x2E1210")]
			public Face(int nSubMesh, int nFaceIndex)
			{
			}

			// Token: 0x0400B0B6 RID: 45238
			[Token(Token = "0x401B880")]
			[FieldOffset(Offset = "0x0")]
			public int nSubMesh;

			// Token: 0x0400B0B7 RID: 45239
			[Token(Token = "0x401B881")]
			[FieldOffset(Offset = "0x4")]
			public int nFaceIndex;

			// Token: 0x02000C52 RID: 3154
			[Token(Token = "0x2001659")]
			public class EqualityComparer : IEqualityComparer<MeshDataConnectivity.Face>
			{
				// Token: 0x06004FE6 RID: 20454 RVA: 0x00019AE8 File Offset: 0x00017CE8
				[Token(Token = "0x60080BA")]
				[Address(RVA = "0x20F9070", Offset = "0x20F9171", VA = "0x20F9070", Slot = "4")]
				public bool Equals(MeshDataConnectivity.Face x, MeshDataConnectivity.Face y)
				{
					return default(bool);
				}

				// Token: 0x06004FE7 RID: 20455 RVA: 0x00019B00 File Offset: 0x00017D00
				[Token(Token = "0x60080BB")]
				[Address(RVA = "0x20F9090", Offset = "0x20F9191", VA = "0x20F9090", Slot = "5")]
				public int GetHashCode(MeshDataConnectivity.Face x)
				{
					return 0;
				}

				// Token: 0x06004FE8 RID: 20456 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080BC")]
				[Address(RVA = "0x20F8930", Offset = "0x20F8A31", VA = "0x20F8930")]
				public EqualityComparer()
				{
				}
			}
		}
	}
}
