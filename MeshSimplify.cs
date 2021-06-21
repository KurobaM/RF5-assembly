using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UltimateGameTools.MeshSimplifier;
using UnityEngine;

// Token: 0x02000B8C RID: 2956
[Token(Token = "0x20007AB")]
public class MeshSimplify : MonoBehaviour
{
	// Token: 0x170009E5 RID: 2533
	// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x00018198 File Offset: 0x00016398
	[Token(Token = "0x170007E3")]
	public bool RecurseIntoChildren
	{
		[Token(Token = "0x6003F7D")]
		[Address(RVA = "0x1F23E80", Offset = "0x1F23F81", VA = "0x1F23E80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170009E6 RID: 2534
	// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007E4")]
	public Simplifier MeshSimplifier
	{
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x1F23E90", Offset = "0x1F23F91", VA = "0x1F23E90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x1F23EA0", Offset = "0x1F23FA1", VA = "0x1F23EA0")]
		set
		{
		}
	}

	// Token: 0x06004BC6 RID: 19398 RVA: 0x000181B0 File Offset: 0x000163B0
	[Token(Token = "0x6003F80")]
	[Address(RVA = "0x1F23EB0", Offset = "0x1F23FB1", VA = "0x1F23EB0")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	// Token: 0x06004BC7 RID: 19399 RVA: 0x000181C8 File Offset: 0x000163C8
	[Token(Token = "0x6003F81")]
	[Address(RVA = "0x1F23FA0", Offset = "0x1F240A1", VA = "0x1F23FA0")]
	public static bool IsRootOrBelongsToTree(MeshSimplify meshSimplify, MeshSimplify root)
	{
		return default(bool);
	}

	// Token: 0x06004BC8 RID: 19400 RVA: 0x000181E0 File Offset: 0x000163E0
	[Token(Token = "0x6003F82")]
	[Address(RVA = "0x1F24140", Offset = "0x1F24241", VA = "0x1F24140")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	// Token: 0x06004BC9 RID: 19401 RVA: 0x000181F8 File Offset: 0x000163F8
	[Token(Token = "0x6003F83")]
	[Address(RVA = "0x1F24150", Offset = "0x1F24251", VA = "0x1F24150")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	// Token: 0x06004BCA RID: 19402 RVA: 0x00018210 File Offset: 0x00016410
	[Token(Token = "0x6003F84")]
	[Address(RVA = "0x1F241C0", Offset = "0x1F242C1", VA = "0x1F241C0")]
	public bool HasDataDirty()
	{
		return default(bool);
	}

	// Token: 0x06004BCB RID: 19403 RVA: 0x00018228 File Offset: 0x00016428
	[Token(Token = "0x6003F85")]
	[Address(RVA = "0x1F241D0", Offset = "0x1F242D1", VA = "0x1F241D0")]
	public bool SetDataDirty(bool bDirty)
	{
		return default(bool);
	}

	// Token: 0x06004BCC RID: 19404 RVA: 0x00018240 File Offset: 0x00016440
	[Token(Token = "0x6003F86")]
	[Address(RVA = "0x1F241E0", Offset = "0x1F242E1", VA = "0x1F241E0")]
	public bool HasNonMeshSimplifyGameObjectsInTree()
	{
		return default(bool);
	}

	// Token: 0x06004BCD RID: 19405 RVA: 0x00018258 File Offset: 0x00016458
	[Token(Token = "0x6003F87")]
	[Address(RVA = "0x1F24210", Offset = "0x1F24311", VA = "0x1F24210")]
	private bool HasNonMeshSimplifyGameObjectsInTreeRecursive(MeshSimplify root, GameObject gameObject)
	{
		return default(bool);
	}

	// Token: 0x06004BCE RID: 19406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F88")]
	[Address(RVA = "0x1F24360", Offset = "0x1F24461", VA = "0x1F24360")]
	public void ConfigureSimplifier()
	{
	}

	// Token: 0x06004BCF RID: 19407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F89")]
	[Address(RVA = "0x1F24510", Offset = "0x1F24611", VA = "0x1F24510")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	// Token: 0x06004BD0 RID: 19408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0x1F24520", Offset = "0x1F24621", VA = "0x1F24520")]
	public void ComputeData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004BD1 RID: 19409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F8B")]
	[Address(RVA = "0x1F24570", Offset = "0x1F24671", VA = "0x1F24570")]
	private static void ComputeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x00018270 File Offset: 0x00016470
	[Token(Token = "0x6003F8C")]
	[Address(RVA = "0x1F24F40", Offset = "0x1F25041", VA = "0x1F24F40")]
	public bool HasData()
	{
		return default(bool);
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x00018288 File Offset: 0x00016488
	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0x1F25030", Offset = "0x1F25131", VA = "0x1F25030")]
	public bool HasSimplifiedMesh()
	{
		return default(bool);
	}

	// Token: 0x06004BD4 RID: 19412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F8E")]
	[Address(RVA = "0x1F250E0", Offset = "0x1F251E1", VA = "0x1F250E0")]
	public void ComputeMesh(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004BD5 RID: 19413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0x1F25130", Offset = "0x1F25231", VA = "0x1F25130")]
	private static void ComputeMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004BD6 RID: 19414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F90")]
	[Address(RVA = "0x1F25700", Offset = "0x1F25801", VA = "0x1F25700")]
	public void AssignSimplifiedMesh(bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BD7 RID: 19415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F91")]
	[Address(RVA = "0x1F25740", Offset = "0x1F25841", VA = "0x1F25740")]
	private static void AssignSimplifiedMeshRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BD8 RID: 19416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F92")]
	[Address(RVA = "0x1F25960", Offset = "0x1F25A61", VA = "0x1F25960")]
	public void RestoreOriginalMesh(bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BD9 RID: 19417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F93")]
	[Address(RVA = "0x1F259B0", Offset = "0x1F25AB1", VA = "0x1F259B0")]
	private static void RestoreOriginalMeshRecursive(MeshSimplify root, GameObject gameObject, bool bDeleteData, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BDA RID: 19418 RVA: 0x000182A0 File Offset: 0x000164A0
	[Token(Token = "0x6003F94")]
	[Address(RVA = "0x1F25C20", Offset = "0x1F25D21", VA = "0x1F25C20")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004BDB RID: 19419 RVA: 0x000182B8 File Offset: 0x000164B8
	[Token(Token = "0x6003F95")]
	[Address(RVA = "0x1F25C60", Offset = "0x1F25D61", VA = "0x1F25C60")]
	private static bool HasOriginalMeshActiveRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004BDC RID: 19420 RVA: 0x000182D0 File Offset: 0x000164D0
	[Token(Token = "0x6003F96")]
	[Address(RVA = "0x1F25ED0", Offset = "0x1F25FD1", VA = "0x1F25ED0")]
	public bool HasVertexData(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004BDD RID: 19421 RVA: 0x000182E8 File Offset: 0x000164E8
	[Token(Token = "0x6003F97")]
	[Address(RVA = "0x1F25F10", Offset = "0x1F26011", VA = "0x1F25F10")]
	private static bool HasVertexDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004BDE RID: 19422 RVA: 0x00018300 File Offset: 0x00016500
	[Token(Token = "0x6003F98")]
	[Address(RVA = "0x1F260C0", Offset = "0x1F261C1", VA = "0x1F260C0")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004BDF RID: 19423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F99")]
	[Address(RVA = "0x1F26110", Offset = "0x1F26211", VA = "0x1F26110")]
	private static void GetOriginalVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE0 RID: 19424 RVA: 0x00018318 File Offset: 0x00016518
	[Token(Token = "0x6003F9A")]
	[Address(RVA = "0x1F262A0", Offset = "0x1F263A1", VA = "0x1F262A0")]
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004BE1 RID: 19425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F9B")]
	[Address(RVA = "0x1F262F0", Offset = "0x1F263F1", VA = "0x1F262F0")]
	private static void GetOriginalTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE2 RID: 19426 RVA: 0x00018330 File Offset: 0x00016530
	[Token(Token = "0x6003F9C")]
	[Address(RVA = "0x1F264A0", Offset = "0x1F265A1", VA = "0x1F264A0")]
	public int GetSimplifiedVertexCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004BE3 RID: 19427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F9D")]
	[Address(RVA = "0x1F264F0", Offset = "0x1F265F1", VA = "0x1F264F0")]
	private static void GetSimplifiedVertexCountRecursive(MeshSimplify root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE4 RID: 19428 RVA: 0x00018348 File Offset: 0x00016548
	[Token(Token = "0x6003F9E")]
	[Address(RVA = "0x1F26680", Offset = "0x1F26781", VA = "0x1F26680")]
	public int GetSimplifiedTriangleCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004BE5 RID: 19429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F9F")]
	[Address(RVA = "0x1F266D0", Offset = "0x1F267D1", VA = "0x1F266D0")]
	private static void GetSimplifiedTriangleCountRecursive(MeshSimplify root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE6 RID: 19430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FA0")]
	[Address(RVA = "0x1F26880", Offset = "0x1F26981", VA = "0x1F26880")]
	public void RemoveFromTree()
	{
	}

	// Token: 0x06004BE7 RID: 19431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0x1F24F00", Offset = "0x1F25001", VA = "0x1F24F00")]
	public void FreeData(bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE8 RID: 19432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FA2")]
	[Address(RVA = "0x1F26950", Offset = "0x1F26A51", VA = "0x1F26950")]
	private static void FreeDataRecursive(MeshSimplify root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003FA3")]
	[Address(RVA = "0x1F25610", Offset = "0x1F25711", VA = "0x1F25610")]
	private static Mesh CreateNewEmptyMesh(MeshSimplify meshSimplify)
	{
		return null;
	}

	// Token: 0x06004BEA RID: 19434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FA4")]
	[Address(RVA = "0x1F26BD0", Offset = "0x1F26CD1", VA = "0x1F26BD0")]
	public MeshSimplify()
	{
	}

	// Token: 0x0400ACDD RID: 44253
	[Token(Token = "0x4008265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x175290", Offset = "0x175391")]
	public Mesh m_originalMesh;

	// Token: 0x0400ACDE RID: 44254
	[Token(Token = "0x4008266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752A0", Offset = "0x1753A1")]
	public Mesh m_simplifiedMesh;

	// Token: 0x0400ACDF RID: 44255
	[Token(Token = "0x4008267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752B0", Offset = "0x1753B1")]
	public bool m_bEnablePrefabUsage;

	// Token: 0x0400ACE0 RID: 44256
	[Token(Token = "0x4008268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752C0", Offset = "0x1753C1")]
	public float m_fVertexAmount;

	// Token: 0x0400ACE1 RID: 44257
	[Token(Token = "0x4008269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752D0", Offset = "0x1753D1")]
	public string m_strAssetPath;

	// Token: 0x0400ACE2 RID: 44258
	[Token(Token = "0x400826A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752E0", Offset = "0x1753E1")]
	public MeshSimplify m_meshSimplifyRoot;

	// Token: 0x0400ACE3 RID: 44259
	[Token(Token = "0x400826B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x1752F0", Offset = "0x1753F1")]
	public List<MeshSimplify> m_listDependentChildren;

	// Token: 0x0400ACE4 RID: 44260
	[Token(Token = "0x400826C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HideInInspector", RVA = "0x175300", Offset = "0x175401")]
	public bool m_bExpandRelevanceSpheres;

	// Token: 0x0400ACE5 RID: 44261
	[Token(Token = "0x400826D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RelevanceSphere[] m_aRelevanceSpheres;

	// Token: 0x0400ACE6 RID: 44262
	[Token(Token = "0x400826E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175310", Offset = "0x175411")]
	private Simplifier m_meshSimplifier;

	// Token: 0x0400ACE7 RID: 44263
	[Token(Token = "0x400826F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175350", Offset = "0x175451")]
	private bool m_bGenerateIncludeChildren;

	// Token: 0x0400ACE8 RID: 44264
	[Token(Token = "0x4008270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175390", Offset = "0x175491")]
	private bool m_bOverrideRootSettings;

	// Token: 0x0400ACE9 RID: 44265
	[Token(Token = "0x4008271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x1753D0", Offset = "0x1754D1")]
	private bool m_bUseEdgeLength;

	// Token: 0x0400ACEA RID: 44266
	[Token(Token = "0x4008272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175410", Offset = "0x175511")]
	private bool m_bUseCurvature;

	// Token: 0x0400ACEB RID: 44267
	[Token(Token = "0x4008273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175450", Offset = "0x175551")]
	private bool m_bProtectTexture;

	// Token: 0x0400ACEC RID: 44268
	[Token(Token = "0x4008274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175490", Offset = "0x175591")]
	private bool m_bLockBorder;

	// Token: 0x0400ACED RID: 44269
	[Token(Token = "0x4008275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x1754D0", Offset = "0x1755D1")]
	private bool m_bDataDirty;

	// Token: 0x0400ACEE RID: 44270
	[Token(Token = "0x4008276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175510", Offset = "0x175611")]
	private bool m_bExcludedFromTree;
}
