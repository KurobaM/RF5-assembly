using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B84 RID: 2948
[Token(Token = "0x20007A9")]
public class CombinedMesh : MonoBehaviour
{
	// Token: 0x06004BA5 RID: 19365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F6D")]
	[Address(RVA = "0x1EA2DB0", Offset = "0x1EA2EB1", VA = "0x1EA2DB0")]
	public void CancelCombining()
	{
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x00018150 File Offset: 0x00016350
	[Token(Token = "0x6003F6E")]
	[Address(RVA = "0x1EA2DC0", Offset = "0x1EA2EC1", VA = "0x1EA2DC0")]
	public bool CombiningCancelled()
	{
		return default(bool);
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F6F")]
	[Address(RVA = "0x1EA2DD0", Offset = "0x1EA2ED1", VA = "0x1EA2DD0")]
	public void TransformObjInfoMeshVectorsToLocal(Transform newTransform)
	{
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x00018168 File Offset: 0x00016368
	[Token(Token = "0x6003F70")]
	[Address(RVA = "0x1EA3390", Offset = "0x1EA3491", VA = "0x1EA3390")]
	public int GetObjectCount()
	{
		return 0;
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F71")]
	[Address(RVA = "0x1EA33E0", Offset = "0x1EA34E1", VA = "0x1EA33E0")]
	public CombinedMesh.ObjectInfo GetObjectInfo(int nIndex)
	{
		return null;
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F72")]
	[Address(RVA = "0x1EA3460", Offset = "0x1EA3561", VA = "0x1EA3460")]
	public void Combine(CombinedMesh.CombineProgressDelegate progress)
	{
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F73")]
	[Address(RVA = "0x1EA5BE0", Offset = "0x1EA5CE1", VA = "0x1EA5BE0")]
	public CombinedMesh()
	{
	}

	// Token: 0x0400ACA4 RID: 44196
	[Token(Token = "0x400824D")]
	[FieldOffset(Offset = "0x18")]
	public bool SaveMeshAsset;

	// Token: 0x0400ACA5 RID: 44197
	[Token(Token = "0x400824E")]
	[FieldOffset(Offset = "0x19")]
	public bool KeepPosition;

	// Token: 0x0400ACA6 RID: 44198
	[Token(Token = "0x400824F")]
	[FieldOffset(Offset = "0x1C")]
	public CombinedMesh.EPivotMode PivotMode;

	// Token: 0x0400ACA7 RID: 44199
	[Token(Token = "0x4008250")]
	[FieldOffset(Offset = "0x20")]
	public MeshFilter[] MeshObjects;

	// Token: 0x0400ACA8 RID: 44200
	[Token(Token = "0x4008251")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RootNode;

	// Token: 0x0400ACA9 RID: 44201
	[Token(Token = "0x4008252")]
	[FieldOffset(Offset = "0x30")]
	private bool m_bCancelled;

	// Token: 0x0400ACAA RID: 44202
	[Token(Token = "0x4008253")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<CombinedMesh.ObjectInfo> m_listObjectInfo;

	// Token: 0x0400ACAB RID: 44203
	[Token(Token = "0x4008254")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<Material, List<CombinedMesh.MaterialMeshInfo>> m_dicMeshEntries;

	// Token: 0x02000B85 RID: 2949
	// (Invoke) Token: 0x06004BAD RID: 19373
	[Token(Token = "0x200135C")]
	public delegate void CombineProgressDelegate(string strMessage, float fT);

	// Token: 0x02000B86 RID: 2950
	[Token(Token = "0x200135D")]
	[Serializable]
	public class ObjectInfo
	{
		// Token: 0x06004BB0 RID: 19376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771F")]
		[Address(RVA = "0x20DAC00", Offset = "0x20DAD01", VA = "0x20DAC00")]
		public ObjectInfo(Material[] aMaterials, Mesh mesh, Transform transform, Matrix4x4 mtxLocal)
		{
		}

		// Token: 0x0400ACAC RID: 44204
		[Token(Token = "0x401B6B8")]
		[FieldOffset(Offset = "0x10")]
		public Material[] aMaterials;

		// Token: 0x0400ACAD RID: 44205
		[Token(Token = "0x401B6B9")]
		[FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		// Token: 0x0400ACAE RID: 44206
		[Token(Token = "0x401B6BA")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 v3LocalPosition;

		// Token: 0x0400ACAF RID: 44207
		[Token(Token = "0x401B6BB")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion qLocalRotation;

		// Token: 0x0400ACB0 RID: 44208
		[Token(Token = "0x401B6BC")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 v3LocalScale;

		// Token: 0x0400ACB1 RID: 44209
		[Token(Token = "0x401B6BD")]
		[FieldOffset(Offset = "0x48")]
		public Matrix4x4 mtxLocal;

		// Token: 0x0400ACB2 RID: 44210
		[Token(Token = "0x401B6BE")]
		[FieldOffset(Offset = "0x88")]
		public Matrix4x4 mtxWorld;

		// Token: 0x0400ACB3 RID: 44211
		[Token(Token = "0x401B6BF")]
		[FieldOffset(Offset = "0xC8")]
		public Vector3[] av3NormalsWorld;

		// Token: 0x0400ACB4 RID: 44212
		[Token(Token = "0x401B6C0")]
		[FieldOffset(Offset = "0xD0")]
		public Vector4[] av4TangentsWorld;
	}

	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x200135E")]
	private class MaterialMeshInfo
	{
		// Token: 0x06004BB1 RID: 19377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007720")]
		[Address(RVA = "0x20DABA0", Offset = "0x20DACA1", VA = "0x20DABA0")]
		public MaterialMeshInfo(Transform transform, Mesh mesh, int nSubMesh)
		{
		}

		// Token: 0x0400ACB5 RID: 44213
		[Token(Token = "0x401B6C1")]
		[FieldOffset(Offset = "0x10")]
		public Transform transform;

		// Token: 0x0400ACB6 RID: 44214
		[Token(Token = "0x401B6C2")]
		[FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		// Token: 0x0400ACB7 RID: 44215
		[Token(Token = "0x401B6C3")]
		[FieldOffset(Offset = "0x20")]
		public int nSubMesh;
	}

	// Token: 0x02000B88 RID: 2952
	[Token(Token = "0x200135F")]
	public enum EPivotMode
	{
		// Token: 0x0400ACB9 RID: 44217
		[Token(Token = "0x401B6C5")]
		Keep,
		// Token: 0x0400ACBA RID: 44218
		[Token(Token = "0x401B6C6")]
		Center,
		// Token: 0x0400ACBB RID: 44219
		[Token(Token = "0x401B6C7")]
		BottomCenter,
		// Token: 0x0400ACBC RID: 44220
		[Token(Token = "0x401B6C8")]
		TopCenter,
		// Token: 0x0400ACBD RID: 44221
		[Token(Token = "0x401B6C9")]
		Min,
		// Token: 0x0400ACBE RID: 44222
		[Token(Token = "0x401B6CA")]
		Max
	}
}
