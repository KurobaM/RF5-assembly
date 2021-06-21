using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B7C RID: 2940
[Token(Token = "0x20007A7")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x147420", Offset = "0x147521")]
[Serializable]
public class FracturedChunk : MonoBehaviour
{
	// Token: 0x06004B6F RID: 19311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F3A")]
	[Address(RVA = "0x1ED1BB0", Offset = "0x1ED1CB1", VA = "0x1ED1BB0")]
	private void Awake()
	{
	}

	// Token: 0x06004B70 RID: 19312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F3B")]
	[Address(RVA = "0x1ED1CC0", Offset = "0x1ED1DC1", VA = "0x1ED1CC0")]
	private void Update()
	{
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F3C")]
	[Address(RVA = "0x1ED1E00", Offset = "0x1ED1F01", VA = "0x1ED1E00")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0x1ED2910", Offset = "0x1ED2A11", VA = "0x1ED2910")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0x1ED1F00", Offset = "0x1ED2001", VA = "0x1ED1F00")]
	private void HandleCollision(Collider other, Vector3 v3CollisionPos, float relativeSpeed)
	{
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x000180D8 File Offset: 0x000162D8
	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0x1ED2A90", Offset = "0x1ED2B91", VA = "0x1ED2A90")]
	public bool IsDestructibleChunk()
	{
		return default(bool);
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F40")]
	[Address(RVA = "0x1ED3390", Offset = "0x1ED3491", VA = "0x1ED3390")]
	public void ResetChunk(FracturedObject fracturedObjectSource)
	{
	}

	// Token: 0x06004B76 RID: 19318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x1ED3540", Offset = "0x1ED3641", VA = "0x1ED3540")]
	public void Impact(Vector3 v3Position, float fExplosionForce, float fRadius, bool bAlsoImpactFreeChunks)
	{
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F42")]
	[Address(RVA = "0x1ED4070", Offset = "0x1ED4171", VA = "0x1ED4070")]
	public void OnCreateFromFracturedObject(FracturedObject fracturedComponent, int nSplitSubMeshIndex)
	{
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F43")]
	[Address(RVA = "0x1ED4180", Offset = "0x1ED4281", VA = "0x1ED4180")]
	public void UpdatePreviewDecompositionPosition()
	{
	}

	// Token: 0x06004B79 RID: 19321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F44")]
	[Address(RVA = "0x1ED42E0", Offset = "0x1ED43E1", VA = "0x1ED42E0")]
	public void ConnectTo(FracturedChunk chunk, float fArea)
	{
	}

	// Token: 0x06004B7A RID: 19322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F45")]
	[Address(RVA = "0x1ED46C0", Offset = "0x1ED47C1", VA = "0x1ED46C0")]
	public void DisconnectFrom(FracturedChunk chunk)
	{
	}

	// Token: 0x06004B7B RID: 19323 RVA: 0x000180F0 File Offset: 0x000162F0
	[Token(Token = "0x6003F46")]
	[Address(RVA = "0x1ED4440", Offset = "0x1ED4541", VA = "0x1ED4440")]
	public bool IsConnectedTo(FracturedChunk chunk)
	{
		return default(bool);
	}

	// Token: 0x06004B7C RID: 19324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F47")]
	[Address(RVA = "0x1ED2D70", Offset = "0x1ED2E71", VA = "0x1ED2D70")]
	public void DetachFromObject(bool bCheckStructureIntegrity = true)
	{
	}

	// Token: 0x06004B7D RID: 19325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F48")]
	[Address(RVA = "0x1ED48B0", Offset = "0x1ED49B1", VA = "0x1ED48B0")]
	private void RemoveConnectionInfo()
	{
	}

	// Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F49")]
	[Address(RVA = "0x1ED2CA0", Offset = "0x1ED2DA1", VA = "0x1ED2CA0")]
	public List<FracturedChunk> ComputeRandomConnectionBreaks()
	{
		return null;
	}

	// Token: 0x06004B7F RID: 19327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0x1ED5010", Offset = "0x1ED5111", VA = "0x1ED5010")]
	private static void ComputeRandomConnectionBreaksRecursive(FracturedChunk chunk, List<FracturedChunk> listBreaksOut, int nLevel)
	{
	}

	// Token: 0x06004B80 RID: 19328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F4B")]
	[Address(RVA = "0x1ED5360", Offset = "0x1ED5461", VA = "0x1ED5360")]
	public static FracturedChunk ChunkRaycast(Vector3 v3Pos, Vector3 v3Forward, out RaycastHit hitInfo)
	{
		return null;
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F4C")]
	[Address(RVA = "0x1ED5500", Offset = "0x1ED5601", VA = "0x1ED5500")]
	public FracturedChunk()
	{
	}

	// Token: 0x0400AC1E RID: 44062
	[Token(Token = "0x40081DA")]
	[FieldOffset(Offset = "0x18")]
	public FracturedObject FracturedObjectSource;

	// Token: 0x0400AC1F RID: 44063
	[Token(Token = "0x40081DB")]
	[FieldOffset(Offset = "0x20")]
	public int SplitSubMeshIndex;

	// Token: 0x0400AC20 RID: 44064
	[Token(Token = "0x40081DC")]
	[FieldOffset(Offset = "0x24")]
	public bool DontDeleteAfterBroken;

	// Token: 0x0400AC21 RID: 44065
	[Token(Token = "0x40081DD")]
	[FieldOffset(Offset = "0x25")]
	public bool IsSupportChunk;

	// Token: 0x0400AC22 RID: 44066
	[Token(Token = "0x40081DE")]
	[FieldOffset(Offset = "0x26")]
	public bool IsNonSupportedChunk;

	// Token: 0x0400AC23 RID: 44067
	[Token(Token = "0x40081DF")]
	[FieldOffset(Offset = "0x27")]
	public bool IsDetachedChunk;

	// Token: 0x0400AC24 RID: 44068
	[Token(Token = "0x40081E0")]
	[FieldOffset(Offset = "0x28")]
	public float RelativeVolume;

	// Token: 0x0400AC25 RID: 44069
	[Token(Token = "0x40081E1")]
	[FieldOffset(Offset = "0x2C")]
	public float Volume;

	// Token: 0x0400AC26 RID: 44070
	[Token(Token = "0x40081E2")]
	[FieldOffset(Offset = "0x30")]
	public bool HasConcaveCollider;

	// Token: 0x0400AC27 RID: 44071
	[Token(Token = "0x40081E3")]
	[FieldOffset(Offset = "0x34")]
	public float PreviewDecompositionValue;

	// Token: 0x0400AC28 RID: 44072
	[Token(Token = "0x40081E4")]
	[FieldOffset(Offset = "0x38")]
	public Color RandomMaterialColor;

	// Token: 0x0400AC29 RID: 44073
	[Token(Token = "0x40081E5")]
	[FieldOffset(Offset = "0x48")]
	public bool Visited;

	// Token: 0x0400AC2A RID: 44074
	[Token(Token = "0x40081E6")]
	[FieldOffset(Offset = "0x50")]
	public List<FracturedChunk.AdjacencyInfo> ListAdjacentChunks;

	// Token: 0x0400AC2B RID: 44075
	[Token(Token = "0x40081E7")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Vector3 m_v3InitialLocalPosition;

	// Token: 0x0400AC2C RID: 44076
	[Token(Token = "0x40081E8")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Quaternion m_qInitialLocalRotation;

	// Token: 0x0400AC2D RID: 44077
	[Token(Token = "0x40081E9")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private Vector3 m_v3InitialLocalScale;

	// Token: 0x0400AC2E RID: 44078
	[Token(Token = "0x40081EA")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool m_bInitialLocalRotScaleInitialized;

	// Token: 0x0400AC2F RID: 44079
	[Token(Token = "0x40081EB")]
	[FieldOffset(Offset = "0x88")]
	private List<FracturedChunk.AdjacencyInfo> ListAdjacentChunksCopy;

	// Token: 0x0400AC30 RID: 44080
	[Token(Token = "0x40081EC")]
	[FieldOffset(Offset = "0x90")]
	private float m_fInvisibleTimer;

	// Token: 0x0400AC31 RID: 44081
	[Token(Token = "0x40081ED")]
	[FieldOffset(Offset = "0x94")]
	private bool m_bNonSupportedChunkStored;

	// Token: 0x02000B7D RID: 2941
	[Token(Token = "0x2001356")]
	[Serializable]
	public class AdjacencyInfo
	{
		// Token: 0x06004B82 RID: 19330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007718")]
		[Address(RVA = "0x1ED4670", Offset = "0x1ED4771", VA = "0x1ED4670")]
		public AdjacencyInfo(FracturedChunk chunk, float fArea)
		{
		}

		// Token: 0x0400AC32 RID: 44082
		[Token(Token = "0x401B6A5")]
		[FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		// Token: 0x0400AC33 RID: 44083
		[Token(Token = "0x401B6A6")]
		[FieldOffset(Offset = "0x18")]
		public float fArea;
	}

	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2001357")]
	public class CollisionInfo
	{
		// Token: 0x06004B83 RID: 19331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007719")]
		[Address(RVA = "0x1ED2B40", Offset = "0x1ED2C41", VA = "0x1ED2B40")]
		public CollisionInfo(FracturedChunk chunk, Vector3 collisionPoint, bool bIsMain)
		{
		}

		// Token: 0x0400AC34 RID: 44084
		[Token(Token = "0x401B6A7")]
		[FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		// Token: 0x0400AC35 RID: 44085
		[Token(Token = "0x401B6A8")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 collisionPoint;

		// Token: 0x0400AC36 RID: 44086
		[Token(Token = "0x401B6A9")]
		[FieldOffset(Offset = "0x24")]
		public bool bIsMain;

		// Token: 0x0400AC37 RID: 44087
		[Token(Token = "0x401B6AA")]
		[FieldOffset(Offset = "0x25")]
		public bool bCancelCollisionEvent;
	}
}
