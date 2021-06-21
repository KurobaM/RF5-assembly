using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UltimateFracturing;
using UnityEngine;

// Token: 0x02000B7F RID: 2943
[Token(Token = "0x20007A8")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x147430", Offset = "0x147531")]
public class FracturedObject : MonoBehaviour
{
	// Token: 0x170009E2 RID: 2530
	// (get) Token: 0x06004B84 RID: 19332 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004B85 RID: 19333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007E2")]
	public Material GizmosMaterial
	{
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x1ED55A0", Offset = "0x1ED56A1", VA = "0x1ED55A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x1ED5670", Offset = "0x1ED5771", VA = "0x1ED5670")]
		set
		{
		}
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F4F")]
	[Address(RVA = "0x1ED5680", Offset = "0x1ED5781", VA = "0x1ED5680")]
	private void Awake()
	{
	}

	// Token: 0x06004B87 RID: 19335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F50")]
	[Address(RVA = "0x1ED5690", Offset = "0x1ED5791", VA = "0x1ED5690")]
	private void Start()
	{
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F51")]
	[Address(RVA = "0x1ED5AF0", Offset = "0x1ED5BF1", VA = "0x1ED5AF0")]
	private void Update()
	{
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F52")]
	[Address(RVA = "0x1ED6660", Offset = "0x1ED6761", VA = "0x1ED6660")]
	private void OnRenderObject()
	{
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F53")]
	[Address(RVA = "0x1ED6670", Offset = "0x1ED6771", VA = "0x1ED6670")]
	public void OnCreateFracturedObject()
	{
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F54")]
	[Address(RVA = "0x1ED58D0", Offset = "0x1ED59D1", VA = "0x1ED58D0")]
	public void SetSingleMeshVisibility(bool bEnabled)
	{
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x00018108 File Offset: 0x00016308
	[Token(Token = "0x6003F55")]
	[Address(RVA = "0x1ED6770", Offset = "0x1ED6871", VA = "0x1ED6770")]
	public bool ResetChunks()
	{
		return default(bool);
	}

	// Token: 0x06004B8D RID: 19341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F56")]
	[Address(RVA = "0x1ED3970", Offset = "0x1ED3A71", VA = "0x1ED3970")]
	public List<FracturedChunk> GetDestructibleChunksInRadius(Vector3 v3Position, float fRadius, bool bAlsoIncludeFreeChunks)
	{
		return null;
	}

	// Token: 0x06004B8E RID: 19342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F57")]
	[Address(RVA = "0x1ED69B0", Offset = "0x1ED6AB1", VA = "0x1ED69B0")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce)
	{
	}

	// Token: 0x06004B8F RID: 19343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F58")]
	[Address(RVA = "0x1ED6F20", Offset = "0x1ED7021", VA = "0x1ED6F20")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce, float fRadius, bool bPlayExplosionSound, bool bInstanceExplosionPrefabs, bool bAlsoExplodeFree, bool bCheckStructureIntegrityAfter)
	{
	}

	// Token: 0x06004B90 RID: 19344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F59")]
	[Address(RVA = "0x1ED7520", Offset = "0x1ED7621", VA = "0x1ED7520")]
	public void DeleteChunks()
	{
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F5A")]
	[Address(RVA = "0x1ED7740", Offset = "0x1ED7841", VA = "0x1ED7740")]
	public void CollapseChunks()
	{
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0x1ED7990", Offset = "0x1ED7A91", VA = "0x1ED7990")]
	public void ExplodeChunks(float fExplosionForce, Vector3 v3ExplosionPosition, float fUpwardsModifier)
	{
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0x1ED7C70", Offset = "0x1ED7D71", VA = "0x1ED7C70")]
	public void ComputeChunksRelativeVolume()
	{
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x1ED83C0", Offset = "0x1ED84C1", VA = "0x1ED83C0")]
	public void ComputeChunksMass(float fTotalMass)
	{
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x00018120 File Offset: 0x00016320
	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0x1ED85E0", Offset = "0x1ED86E1", VA = "0x1ED85E0")]
	public bool HasDetachedChunks()
	{
		return default(bool);
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0x1ED4C20", Offset = "0x1ED4D21", VA = "0x1ED4C20")]
	public void NotifyChunkDetach(FracturedChunk chunk)
	{
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F60")]
	[Address(RVA = "0x1ED2BC0", Offset = "0x1ED2CC1", VA = "0x1ED2BC0")]
	public void NotifyDetachChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F61")]
	[Address(RVA = "0x1ED85F0", Offset = "0x1ED86F1", VA = "0x1ED85F0")]
	public void NotifyDetachChunkCollision(Vector3 v3Position, bool bIsMain)
	{
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F62")]
	[Address(RVA = "0x1ED2FD0", Offset = "0x1ED30D1", VA = "0x1ED2FD0")]
	public void NotifyFreeChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	// Token: 0x06004B9A RID: 19354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F63")]
	[Address(RVA = "0x1ED3E50", Offset = "0x1ED3F51", VA = "0x1ED3E50")]
	public void NotifyImpact(Vector3 v3Position)
	{
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F64")]
	[Address(RVA = "0x1ED4EC0", Offset = "0x1ED4FC1", VA = "0x1ED4EC0")]
	public void ResetAllChunkVisitedFlags()
	{
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F65")]
	[Address(RVA = "0x1ED4EA0", Offset = "0x1ED4FA1", VA = "0x1ED4EA0")]
	public void CheckDetachNonSupportedChunks(bool bForceImmediate = false)
	{
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F66")]
	[Address(RVA = "0x1ED8820", Offset = "0x1ED8921", VA = "0x1ED8820")]
	public void MarkNonSupportedChunks()
	{
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F67")]
	[Address(RVA = "0x1ED5C70", Offset = "0x1ED5D71", VA = "0x1ED5C70")]
	private void CheckDetachNonSupportedChunksInternal(bool bOnlyMarkThem = false)
	{
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x00018138 File Offset: 0x00016338
	[Token(Token = "0x6003F68")]
	[Address(RVA = "0x1ED8980", Offset = "0x1ED8A81", VA = "0x1ED8980")]
	private static bool AreSupportedChunksRecursive(FracturedChunk chunk, List<FracturedChunk> listChunksVisited, List<FracturedChunk> listChunksSupport)
	{
		return default(bool);
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F69")]
	[Address(RVA = "0x1ED8C60", Offset = "0x1ED8D61", VA = "0x1ED8C60")]
	public void AddSupportPlane()
	{
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F6A")]
	[Address(RVA = "0x1ED8D30", Offset = "0x1ED8E31", VA = "0x1ED8D30")]
	public void ComputeSupportPlaneIntersections()
	{
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F6B")]
	[Address(RVA = "0x1ED9030", Offset = "0x1ED9131", VA = "0x1ED9030")]
	public FracturedObject()
	{
	}

	// Token: 0x0400AC38 RID: 44088
	[Token(Token = "0x40081EE")]
	[FieldOffset(Offset = "0x18")]
	public bool GUIExpandMain;

	// Token: 0x0400AC39 RID: 44089
	[Token(Token = "0x40081EF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SourceObject;

	// Token: 0x0400AC3A RID: 44090
	[Token(Token = "0x40081F0")]
	[FieldOffset(Offset = "0x28")]
	public bool GenerateIslands;

	// Token: 0x0400AC3B RID: 44091
	[Token(Token = "0x40081F1")]
	[FieldOffset(Offset = "0x29")]
	public bool GenerateChunkConnectionInfo;

	// Token: 0x0400AC3C RID: 44092
	[Token(Token = "0x40081F2")]
	[FieldOffset(Offset = "0x2A")]
	public bool StartStatic;

	// Token: 0x0400AC3D RID: 44093
	[Token(Token = "0x40081F3")]
	[FieldOffset(Offset = "0x2C")]
	public float ChunkConnectionMinArea;

	// Token: 0x0400AC3E RID: 44094
	[Token(Token = "0x40081F4")]
	[FieldOffset(Offset = "0x30")]
	public float ChunkConnectionStrength;

	// Token: 0x0400AC3F RID: 44095
	[Token(Token = "0x40081F5")]
	[FieldOffset(Offset = "0x34")]
	public float ChunkHorizontalRadiusSupportStrength;

	// Token: 0x0400AC40 RID: 44096
	[Token(Token = "0x40081F6")]
	[FieldOffset(Offset = "0x38")]
	public bool SupportChunksAreIndestructible;

	// Token: 0x0400AC41 RID: 44097
	[Token(Token = "0x40081F7")]
	[FieldOffset(Offset = "0x3C")]
	public float ChunkIslandConnectionMaxDistance;

	// Token: 0x0400AC42 RID: 44098
	[Token(Token = "0x40081F8")]
	[FieldOffset(Offset = "0x40")]
	public float TotalMass;

	// Token: 0x0400AC43 RID: 44099
	[Token(Token = "0x40081F9")]
	[FieldOffset(Offset = "0x48")]
	public PhysicMaterial ChunkPhysicMaterial;

	// Token: 0x0400AC44 RID: 44100
	[Token(Token = "0x40081FA")]
	[FieldOffset(Offset = "0x50")]
	public float MinColliderVolumeForBox;

	// Token: 0x0400AC45 RID: 44101
	[Token(Token = "0x40081FB")]
	[FieldOffset(Offset = "0x54")]
	public float CapPrecisionFix;

	// Token: 0x0400AC46 RID: 44102
	[Token(Token = "0x40081FC")]
	[FieldOffset(Offset = "0x58")]
	public bool InvertCapNormals;

	// Token: 0x0400AC47 RID: 44103
	[Token(Token = "0x40081FD")]
	[FieldOffset(Offset = "0x5C")]
	public FracturedObject.ColliderType ChunkColliderType;

	// Token: 0x0400AC48 RID: 44104
	[Token(Token = "0x40081FE")]
	[FieldOffset(Offset = "0x60")]
	public bool GUIExpandSplits;

	// Token: 0x0400AC49 RID: 44105
	[Token(Token = "0x40081FF")]
	[FieldOffset(Offset = "0x64")]
	public FracturedObject.EFracturePattern FracturePattern;

	// Token: 0x0400AC4A RID: 44106
	[Token(Token = "0x4008200")]
	[FieldOffset(Offset = "0x68")]
	public bool VoronoiVolumeOptimization;

	// Token: 0x0400AC4B RID: 44107
	[Token(Token = "0x4008201")]
	[FieldOffset(Offset = "0x69")]
	public bool VoronoiProximityOptimization;

	// Token: 0x0400AC4C RID: 44108
	[Token(Token = "0x4008202")]
	[FieldOffset(Offset = "0x6A")]
	public bool VoronoiMultithreading;

	// Token: 0x0400AC4D RID: 44109
	[Token(Token = "0x4008203")]
	[FieldOffset(Offset = "0x6C")]
	public int VoronoiCellsXCount;

	// Token: 0x0400AC4E RID: 44110
	[Token(Token = "0x4008204")]
	[FieldOffset(Offset = "0x70")]
	public int VoronoiCellsYCount;

	// Token: 0x0400AC4F RID: 44111
	[Token(Token = "0x4008205")]
	[FieldOffset(Offset = "0x74")]
	public int VoronoiCellsZCount;

	// Token: 0x0400AC50 RID: 44112
	[Token(Token = "0x4008206")]
	[FieldOffset(Offset = "0x78")]
	public float VoronoiCellsXSizeVariation;

	// Token: 0x0400AC51 RID: 44113
	[Token(Token = "0x4008207")]
	[FieldOffset(Offset = "0x7C")]
	public float VoronoiCellsYSizeVariation;

	// Token: 0x0400AC52 RID: 44114
	[Token(Token = "0x4008208")]
	[FieldOffset(Offset = "0x80")]
	public float VoronoiCellsZSizeVariation;

	// Token: 0x0400AC53 RID: 44115
	[Token(Token = "0x4008209")]
	[FieldOffset(Offset = "0x84")]
	public int GenerateNumChunks;

	// Token: 0x0400AC54 RID: 44116
	[Token(Token = "0x400820A")]
	[FieldOffset(Offset = "0x88")]
	public bool SplitsWorldSpace;

	// Token: 0x0400AC55 RID: 44117
	[Token(Token = "0x400820B")]
	[FieldOffset(Offset = "0x89")]
	public bool SplitRegularly;

	// Token: 0x0400AC56 RID: 44118
	[Token(Token = "0x400820C")]
	[FieldOffset(Offset = "0x8C")]
	public float SplitXProbability;

	// Token: 0x0400AC57 RID: 44119
	[Token(Token = "0x400820D")]
	[FieldOffset(Offset = "0x90")]
	public float SplitYProbability;

	// Token: 0x0400AC58 RID: 44120
	[Token(Token = "0x400820E")]
	[FieldOffset(Offset = "0x94")]
	public float SplitZProbability;

	// Token: 0x0400AC59 RID: 44121
	[Token(Token = "0x400820F")]
	[FieldOffset(Offset = "0x98")]
	public float SplitSizeVariation;

	// Token: 0x0400AC5A RID: 44122
	[Token(Token = "0x4008210")]
	[FieldOffset(Offset = "0x9C")]
	public float SplitXVariation;

	// Token: 0x0400AC5B RID: 44123
	[Token(Token = "0x4008211")]
	[FieldOffset(Offset = "0xA0")]
	public float SplitYVariation;

	// Token: 0x0400AC5C RID: 44124
	[Token(Token = "0x4008212")]
	[FieldOffset(Offset = "0xA4")]
	public float SplitZVariation;

	// Token: 0x0400AC5D RID: 44125
	[Token(Token = "0x4008213")]
	[FieldOffset(Offset = "0xA8")]
	public Material SplitMaterial;

	// Token: 0x0400AC5E RID: 44126
	[Token(Token = "0x4008214")]
	[FieldOffset(Offset = "0xB0")]
	public float SplitMappingTileU;

	// Token: 0x0400AC5F RID: 44127
	[Token(Token = "0x4008215")]
	[FieldOffset(Offset = "0xB4")]
	public float SplitMappingTileV;

	// Token: 0x0400AC60 RID: 44128
	[Token(Token = "0x4008216")]
	[FieldOffset(Offset = "0xB8")]
	public bool GUIExpandEvents;

	// Token: 0x0400AC61 RID: 44129
	[Token(Token = "0x4008217")]
	[FieldOffset(Offset = "0xBC")]
	public float EventDetachMinMass;

	// Token: 0x0400AC62 RID: 44130
	[Token(Token = "0x4008218")]
	[FieldOffset(Offset = "0xC0")]
	public float EventDetachMinVelocity;

	// Token: 0x0400AC63 RID: 44131
	[Token(Token = "0x4008219")]
	[FieldOffset(Offset = "0xC4")]
	public float EventDetachExitForce;

	// Token: 0x0400AC64 RID: 44132
	[Token(Token = "0x400821A")]
	[FieldOffset(Offset = "0xC8")]
	public float EventDetachUpwardsModifier;

	// Token: 0x0400AC65 RID: 44133
	[Token(Token = "0x400821B")]
	[FieldOffset(Offset = "0xD0")]
	public AudioClip EventDetachSound;

	// Token: 0x0400AC66 RID: 44134
	[Token(Token = "0x400821C")]
	[FieldOffset(Offset = "0xD8")]
	public FracturedObject.PrefabInfo[] EventDetachPrefabsArray;

	// Token: 0x0400AC67 RID: 44135
	[Token(Token = "0x400821D")]
	[FieldOffset(Offset = "0xE0")]
	public string EventDetachCollisionCallMethod;

	// Token: 0x0400AC68 RID: 44136
	[Token(Token = "0x400821E")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject EventDetachCollisionCallGameObject;

	// Token: 0x0400AC69 RID: 44137
	[Token(Token = "0x400821F")]
	[FieldOffset(Offset = "0xF0")]
	public float EventDetachedMinLifeTime;

	// Token: 0x0400AC6A RID: 44138
	[Token(Token = "0x4008220")]
	[FieldOffset(Offset = "0xF4")]
	public float EventDetachedMaxLifeTime;

	// Token: 0x0400AC6B RID: 44139
	[Token(Token = "0x4008221")]
	[FieldOffset(Offset = "0xF8")]
	public float EventDetachedOffscreenLifeTime;

	// Token: 0x0400AC6C RID: 44140
	[Token(Token = "0x4008222")]
	[FieldOffset(Offset = "0xFC")]
	public float EventDetachedMinMass;

	// Token: 0x0400AC6D RID: 44141
	[Token(Token = "0x4008223")]
	[FieldOffset(Offset = "0x100")]
	public float EventDetachedMinVelocity;

	// Token: 0x0400AC6E RID: 44142
	[Token(Token = "0x4008224")]
	[FieldOffset(Offset = "0x104")]
	public int EventDetachedMaxSounds;

	// Token: 0x0400AC6F RID: 44143
	[Token(Token = "0x4008225")]
	[FieldOffset(Offset = "0x108")]
	public AudioClip[] EventDetachedSoundArray;

	// Token: 0x0400AC70 RID: 44144
	[Token(Token = "0x4008226")]
	[FieldOffset(Offset = "0x110")]
	public int EventDetachedMaxPrefabs;

	// Token: 0x0400AC71 RID: 44145
	[Token(Token = "0x4008227")]
	[FieldOffset(Offset = "0x118")]
	public FracturedObject.PrefabInfo[] EventDetachedPrefabsArray;

	// Token: 0x0400AC72 RID: 44146
	[Token(Token = "0x4008228")]
	[FieldOffset(Offset = "0x120")]
	public string EventDetachedCollisionCallMethod;

	// Token: 0x0400AC73 RID: 44147
	[Token(Token = "0x4008229")]
	[FieldOffset(Offset = "0x128")]
	public GameObject EventDetachedCollisionCallGameObject;

	// Token: 0x0400AC74 RID: 44148
	[Token(Token = "0x400822A")]
	[FieldOffset(Offset = "0x130")]
	public AudioClip EventExplosionSound;

	// Token: 0x0400AC75 RID: 44149
	[Token(Token = "0x400822B")]
	[FieldOffset(Offset = "0x138")]
	public int EventExplosionPrefabsInstanceCount;

	// Token: 0x0400AC76 RID: 44150
	[Token(Token = "0x400822C")]
	[FieldOffset(Offset = "0x140")]
	public FracturedObject.PrefabInfo[] EventExplosionPrefabsArray;

	// Token: 0x0400AC77 RID: 44151
	[Token(Token = "0x400822D")]
	[FieldOffset(Offset = "0x148")]
	public AudioClip EventImpactSound;

	// Token: 0x0400AC78 RID: 44152
	[Token(Token = "0x400822E")]
	[FieldOffset(Offset = "0x150")]
	public FracturedObject.PrefabInfo[] EventImpactPrefabsArray;

	// Token: 0x0400AC79 RID: 44153
	[Token(Token = "0x400822F")]
	[FieldOffset(Offset = "0x158")]
	public string EventDetachedAnyCallMethod;

	// Token: 0x0400AC7A RID: 44154
	[Token(Token = "0x4008230")]
	[FieldOffset(Offset = "0x160")]
	public GameObject EventDetachedAnyCallGameObject;

	// Token: 0x0400AC7B RID: 44155
	[Token(Token = "0x4008231")]
	[FieldOffset(Offset = "0x168")]
	public bool GUIExpandSupportPlanes;

	// Token: 0x0400AC7C RID: 44156
	[Token(Token = "0x4008232")]
	[FieldOffset(Offset = "0x16C")]
	public int RandomSeed;

	// Token: 0x0400AC7D RID: 44157
	[Token(Token = "0x4008233")]
	[FieldOffset(Offset = "0x170")]
	public float DecomposePreview;

	// Token: 0x0400AC7E RID: 44158
	[Token(Token = "0x4008234")]
	[FieldOffset(Offset = "0x174")]
	public bool AlwaysComputeColliders;

	// Token: 0x0400AC7F RID: 44159
	[Token(Token = "0x4008235")]
	[FieldOffset(Offset = "0x175")]
	public bool ShowChunkConnectionLines;

	// Token: 0x0400AC80 RID: 44160
	[Token(Token = "0x4008236")]
	[FieldOffset(Offset = "0x176")]
	public bool ShowChunkColoredState;

	// Token: 0x0400AC81 RID: 44161
	[Token(Token = "0x4008237")]
	[FieldOffset(Offset = "0x177")]
	public bool ShowChunkColoredRandomly;

	// Token: 0x0400AC82 RID: 44162
	[Token(Token = "0x4008238")]
	[FieldOffset(Offset = "0x178")]
	public bool SaveMeshDataToAsset;

	// Token: 0x0400AC83 RID: 44163
	[Token(Token = "0x4008239")]
	[FieldOffset(Offset = "0x180")]
	public string MeshAssetDataFile;

	// Token: 0x0400AC84 RID: 44164
	[Token(Token = "0x400823A")]
	[FieldOffset(Offset = "0x188")]
	public bool Verbose;

	// Token: 0x0400AC85 RID: 44165
	[Token(Token = "0x400823B")]
	[FieldOffset(Offset = "0x189")]
	public bool IntegrateWithConcaveCollider;

	// Token: 0x0400AC86 RID: 44166
	[Token(Token = "0x400823C")]
	[FieldOffset(Offset = "0x18C")]
	public FracturedObject.ECCAlgorithm ConcaveColliderAlgorithm;

	// Token: 0x0400AC87 RID: 44167
	[Token(Token = "0x400823D")]
	[FieldOffset(Offset = "0x190")]
	public int ConcaveColliderMaxHulls;

	// Token: 0x0400AC88 RID: 44168
	[Token(Token = "0x400823E")]
	[FieldOffset(Offset = "0x194")]
	public int ConcaveColliderMaxHullVertices;

	// Token: 0x0400AC89 RID: 44169
	[Token(Token = "0x400823F")]
	[FieldOffset(Offset = "0x198")]
	public int ConcaveColliderLegacySteps;

	// Token: 0x0400AC8A RID: 44170
	[Token(Token = "0x4008240")]
	[FieldOffset(Offset = "0x1A0")]
	[Attribute(Name = "HideInInspector", RVA = "0x175230", Offset = "0x175331")]
	public List<SupportPlane> ListSupportPlanes;

	// Token: 0x0400AC8B RID: 44171
	[Token(Token = "0x4008241")]
	[FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "HideInInspector", RVA = "0x175240", Offset = "0x175341")]
	public List<FracturedChunk> ListFracturedChunks;

	// Token: 0x0400AC8C RID: 44172
	[Token(Token = "0x4008242")]
	[FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "HideInInspector", RVA = "0x175250", Offset = "0x175351")]
	public GameObject SingleMeshObject;

	// Token: 0x0400AC8D RID: 44173
	[Token(Token = "0x4008243")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "HideInInspector", RVA = "0x175260", Offset = "0x175361")]
	public bool IsUsingSingleMeshObjectDraw;

	// Token: 0x0400AC8E RID: 44174
	[Token(Token = "0x4008244")]
	[FieldOffset(Offset = "0x1BC")]
	[Attribute(Name = "HideInInspector", RVA = "0x175270", Offset = "0x175371")]
	public float DecomposeRadius;

	// Token: 0x0400AC8F RID: 44175
	[Token(Token = "0x4008245")]
	[FieldOffset(Offset = "0x0")]
	public static Color GizmoColorSupport;

	// Token: 0x0400AC90 RID: 44176
	[Token(Token = "0x4008246")]
	[FieldOffset(Offset = "0x10")]
	public static Color GizmoColorNonSupport;

	// Token: 0x0400AC91 RID: 44177
	[Token(Token = "0x4008247")]
	[FieldOffset(Offset = "0x1C0")]
	private bool m_bCheckDetachNonSupportedChunkds;

	// Token: 0x0400AC92 RID: 44178
	[Token(Token = "0x4008248")]
	[FieldOffset(Offset = "0x1C1")]
	private bool m_bExploded;

	// Token: 0x0400AC93 RID: 44179
	[Token(Token = "0x4008249")]
	[FieldOffset(Offset = "0x1C2")]
	private bool m_bDetached;

	// Token: 0x0400AC94 RID: 44180
	[Token(Token = "0x400824A")]
	[FieldOffset(Offset = "0x1C8")]
	private float[] m_afFreeChunkSoundTimers;

	// Token: 0x0400AC95 RID: 44181
	[Token(Token = "0x400824B")]
	[FieldOffset(Offset = "0x1D0")]
	private float[] m_afFreeChunkPrefabTimers;

	// Token: 0x0400AC96 RID: 44182
	[Token(Token = "0x400824C")]
	[FieldOffset(Offset = "0x1D8")]
	private Material m_GizmosMaterial;

	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2001358")]
	public enum EFracturePattern
	{
		// Token: 0x0400AC98 RID: 44184
		[Token(Token = "0x401B6AC")]
		BSP,
		// Token: 0x0400AC99 RID: 44185
		[Token(Token = "0x401B6AD")]
		Voronoi
	}

	// Token: 0x02000B81 RID: 2945
	[Token(Token = "0x2001359")]
	public enum ColliderType
	{
		// Token: 0x0400AC9B RID: 44187
		[Token(Token = "0x401B6AF")]
		Collider,
		// Token: 0x0400AC9C RID: 44188
		[Token(Token = "0x401B6B0")]
		Trigger
	}

	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x200135A")]
	[Serializable]
	public class PrefabInfo
	{
		// Token: 0x06004BA4 RID: 19364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771A")]
		[Address(RVA = "0x1ED9320", Offset = "0x1ED9421", VA = "0x1ED9320")]
		public PrefabInfo()
		{
		}

		// Token: 0x0400AC9D RID: 44189
		[Token(Token = "0x401B6B1")]
		[FieldOffset(Offset = "0x10")]
		public float MinLifeTime;

		// Token: 0x0400AC9E RID: 44190
		[Token(Token = "0x401B6B2")]
		[FieldOffset(Offset = "0x14")]
		public float MaxLifeTime;

		// Token: 0x0400AC9F RID: 44191
		[Token(Token = "0x401B6B3")]
		[FieldOffset(Offset = "0x18")]
		public GameObject GameObject;
	}

	// Token: 0x02000B83 RID: 2947
	[Token(Token = "0x200135B")]
	public enum ECCAlgorithm
	{
		// Token: 0x0400ACA1 RID: 44193
		[Token(Token = "0x401B6B5")]
		Fast,
		// Token: 0x0400ACA2 RID: 44194
		[Token(Token = "0x401B6B6")]
		Normal,
		// Token: 0x0400ACA3 RID: 44195
		[Token(Token = "0x401B6B7")]
		Legacy
	}
}
