using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B9B RID: 2971
[Token(Token = "0x20007B7")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1474B0", Offset = "0x1475B1")]
public class UltimateRope : MonoBehaviour
{
	// Token: 0x170009ED RID: 2541
	// (get) Token: 0x06004C1E RID: 19486 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004C1F RID: 19487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007E9")]
	[Attribute(Name = "HideInInspector", RVA = "0x1B8830", Offset = "0x1B8931")]
	public string Status
	{
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x2106650", Offset = "0x2106751", VA = "0x2106650")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x2106660", Offset = "0x2106761", VA = "0x2106660")]
		set
		{
		}
	}

	// Token: 0x06004C20 RID: 19488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD0")]
	[Address(RVA = "0x2106670", Offset = "0x2106771", VA = "0x2106670")]
	private void Awake()
	{
	}

	// Token: 0x06004C21 RID: 19489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD1")]
	[Address(RVA = "0x2109910", Offset = "0x2109A11", VA = "0x2109910")]
	private void Start()
	{
	}

	// Token: 0x06004C22 RID: 19490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD2")]
	[Address(RVA = "0x2109920", Offset = "0x2109A21", VA = "0x2109920")]
	private void OnGUI()
	{
	}

	// Token: 0x06004C23 RID: 19491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD3")]
	[Address(RVA = "0x2109930", Offset = "0x2109A31", VA = "0x2109930")]
	private void Update()
	{
	}

	// Token: 0x06004C24 RID: 19492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD4")]
	[Address(RVA = "0x2109940", Offset = "0x2109A41", VA = "0x2109940")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06004C25 RID: 19493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0x210AE30", Offset = "0x210AF31", VA = "0x210AE30")]
	public void DeleteRope(bool bResetNodePositions = false, bool bDestroySkin = true)
	{
	}

	// Token: 0x06004C26 RID: 19494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x210B660", Offset = "0x210B761", VA = "0x210B660")]
	public void DeleteRopeLinks()
	{
	}

	// Token: 0x06004C27 RID: 19495 RVA: 0x000183A8 File Offset: 0x000165A8
	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0x210BD60", Offset = "0x210BE61", VA = "0x210BD60")]
	public bool Regenerate(bool bResetNodePositions = false)
	{
		return default(bool);
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x000183C0 File Offset: 0x000165C0
	[Token(Token = "0x6003FD8")]
	[Address(RVA = "0x21114E0", Offset = "0x21115E1", VA = "0x21114E0")]
	public bool IsLastStatusError()
	{
		return default(bool);
	}

	// Token: 0x06004C29 RID: 19497 RVA: 0x000183D8 File Offset: 0x000165D8
	[Token(Token = "0x6003FD9")]
	[Address(RVA = "0x21114F0", Offset = "0x21115F1", VA = "0x21114F0")]
	public bool ChangeRopeDiameter(float fNewDiameter, float fNewScaleX, float fNewScaleY)
	{
		return default(bool);
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x000183F0 File Offset: 0x000165F0
	[Token(Token = "0x6003FDA")]
	[Address(RVA = "0x2112220", Offset = "0x2112321", VA = "0x2112220")]
	public bool ChangeRopeSegmentSides(int nNewSegmentSides)
	{
		return default(bool);
	}

	// Token: 0x06004C2B RID: 19499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FDB")]
	[Address(RVA = "0x2113540", Offset = "0x2113641", VA = "0x2113540")]
	public void SetupRopeMaterials()
	{
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FDC")]
	[Address(RVA = "0x2109120", Offset = "0x2109221", VA = "0x2109120")]
	public void SetupRopeLinks()
	{
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0x2113DD0", Offset = "0x2113ED1", VA = "0x2113DD0")]
	public void SetupRopeJoints()
	{
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0x21156B0", Offset = "0x21157B1", VA = "0x21156B0")]
	public void CheckNeedsStartExitLockZ()
	{
	}

	// Token: 0x06004C2F RID: 19503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0x210A770", Offset = "0x210A871", VA = "0x210A770")]
	public void FillLinkMeshIndicesRope(int nLinearLinkIndex, int nTotalLinks, ref int[] indices, bool bBreakable, bool bBrokenLink = false)
	{
	}

	// Token: 0x06004C30 RID: 19504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE0")]
	[Address(RVA = "0x210AA20", Offset = "0x210AB21", VA = "0x210AA20")]
	public void FillLinkMeshIndicesSections(int nLinearLinkIndex, int nTotalLinks, ref int[] indices, bool bBreakable, bool bBrokenLink = false)
	{
	}

	// Token: 0x06004C31 RID: 19505 RVA: 0x00018408 File Offset: 0x00016608
	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0x2115F50", Offset = "0x2116051", VA = "0x2115F50")]
	public bool HasDynamicSegmentNodes()
	{
		return default(bool);
	}

	// Token: 0x06004C32 RID: 19506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE2")]
	[Address(RVA = "0x2116190", Offset = "0x2116291", VA = "0x2116190")]
	public void BeforeImportedBonesObjectRespawn()
	{
	}

	// Token: 0x06004C33 RID: 19507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE3")]
	[Address(RVA = "0x2116290", Offset = "0x2116391", VA = "0x2116290")]
	public void AfterImportedBonesObjectRespawn()
	{
	}

	// Token: 0x06004C34 RID: 19508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE4")]
	[Address(RVA = "0x21163C0", Offset = "0x21164C1", VA = "0x21163C0")]
	public void ExtendRope(UltimateRope.ERopeExtensionMode eRopeExtensionMode, float fIncrement)
	{
	}

	// Token: 0x06004C35 RID: 19509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE5")]
	[Address(RVA = "0x2109900", Offset = "0x2109A01", VA = "0x2109900")]
	public void RecomputeCoil()
	{
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003FE6")]
	[Address(RVA = "0x21170B0", Offset = "0x21171B1", VA = "0x21170B0")]
	public GameObject BuildStaticMeshObject(out string strStatusMessage)
	{
		return null;
	}

	// Token: 0x06004C37 RID: 19511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE7")]
	[Address(RVA = "0x2118A40", Offset = "0x2118B41", VA = "0x2118A40")]
	public void MoveNodeUp(int nNode)
	{
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE8")]
	[Address(RVA = "0x2118B40", Offset = "0x2118C41", VA = "0x2118B40")]
	public void MoveNodeDown(int nNode)
	{
	}

	// Token: 0x06004C39 RID: 19513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FE9")]
	[Address(RVA = "0x2118C50", Offset = "0x2118D51", VA = "0x2118C50")]
	public void CreateNewNode(int nNode)
	{
	}

	// Token: 0x06004C3A RID: 19514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0x2118D20", Offset = "0x2118E21", VA = "0x2118D20")]
	public void RemoveNode(int nNode)
	{
	}

	// Token: 0x06004C3B RID: 19515 RVA: 0x00018420 File Offset: 0x00016620
	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0x2109880", Offset = "0x2109981", VA = "0x2109880")]
	public bool FirstNodeIsCoil()
	{
		return default(bool);
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FEC")]
	[Address(RVA = "0x210FB50", Offset = "0x210FC51", VA = "0x210FB50")]
	private void CheckAddCoilNode()
	{
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FED")]
	[Address(RVA = "0x210BCA0", Offset = "0x210BDA1", VA = "0x210BCA0")]
	private void CheckDelCoilNode()
	{
	}

	// Token: 0x06004C3E RID: 19518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FEE")]
	[Address(RVA = "0x2106720", Offset = "0x2106821", VA = "0x2106720")]
	private void CreateRopeJoints(bool bCheckIfBroken = false)
	{
	}

	// Token: 0x06004C3F RID: 19519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003FEF")]
	[Address(RVA = "0x2118DA0", Offset = "0x2118EA1", VA = "0x2118DA0")]
	private ConfigurableJoint CreateJoint(GameObject goObject, GameObject goConnectedTo, Vector3 v3Pivot)
	{
		return null;
	}

	// Token: 0x06004C40 RID: 19520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FF0")]
	[Address(RVA = "0x21153C0", Offset = "0x21154C1", VA = "0x21153C0")]
	private void SetupJoint(ConfigurableJoint joint)
	{
	}

	// Token: 0x06004C41 RID: 19521 RVA: 0x00018438 File Offset: 0x00016638
	[Token(Token = "0x6003FF1")]
	[Address(RVA = "0x2116F50", Offset = "0x2117051", VA = "0x2116F50")]
	private Vector3 GetAxisVector(UltimateRope.EAxis eAxis, float fLength)
	{
		return default(Vector3);
	}

	// Token: 0x06004C42 RID: 19522 RVA: 0x00018450 File Offset: 0x00016650
	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0x2116680", Offset = "0x2116781", VA = "0x2116680")]
	private float ExtendRopeLinear(float fLinearIncrement)
	{
		return 0f;
	}

	// Token: 0x06004C43 RID: 19523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0x2118EA0", Offset = "0x2118FA1", VA = "0x2118EA0")]
	private void SetExtensibleLinkToKinematic(GameObject link, bool bKinematic)
	{
	}

	// Token: 0x06004C44 RID: 19524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FF4")]
	[Address(RVA = "0x210FF50", Offset = "0x2110051", VA = "0x210FF50")]
	private void SetupCoilBones(float fCoilLength)
	{
	}

	// Token: 0x06004C45 RID: 19525 RVA: 0x00018468 File Offset: 0x00016668
	[Token(Token = "0x6003FF5")]
	[Address(RVA = "0x21110A0", Offset = "0x21111A1", VA = "0x21110A0")]
	private Quaternion GetLinkedObjectLocalRotation(float fTwistAngle = 0f)
	{
		return default(Quaternion);
	}

	// Token: 0x06004C46 RID: 19526 RVA: 0x00018480 File Offset: 0x00016680
	[Token(Token = "0x6003FF6")]
	[Address(RVA = "0x2110E60", Offset = "0x2110F61", VA = "0x2110E60")]
	private float GetLinkedObjectScale(float fSegmentLength, int nNumLinks)
	{
		return 0f;
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x00018498 File Offset: 0x00016698
	[Token(Token = "0x6003FF7")]
	[Address(RVA = "0x21136B0", Offset = "0x21137B1", VA = "0x21136B0")]
	private float GetLinkDiameter()
	{
		return 0f;
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x000184B0 File Offset: 0x000166B0
	[Token(Token = "0x6003FF8")]
	[Address(RVA = "0x210AD20", Offset = "0x210AE21", VA = "0x210AD20")]
	private Vector3 GetLinkAxisOffset(float fValue)
	{
		return default(Vector3);
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x000184C8 File Offset: 0x000166C8
	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0x2113A30", Offset = "0x2113B31", VA = "0x2113A30")]
	private int GetLinkAxisIndex()
	{
		return 0;
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x000184E0 File Offset: 0x000166E0
	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0x2113AA0", Offset = "0x2113BA1", VA = "0x2113AA0")]
	private bool GetLinkBoxColliderCenterAndSize(float fLinkLength, float fRopeDiameter, ref Vector3 v3CenterInOut, ref Vector3 v3SizeInOut)
	{
		return default(bool);
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x000184F8 File Offset: 0x000166F8
	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x210F560", Offset = "0x210F661", VA = "0x210F560")]
	private bool BuildImportedBoneList(GameObject goBoneFirst, GameObject goBoneLast, List<int> ListImportBonesStatic, List<int> ListImportBonesNoCollider, out List<UltimateRope.RopeBone> outListImportedBones, out string strErrorMessage)
	{
		return default(bool);
	}

	// Token: 0x06004C4C RID: 19532 RVA: 0x00018510 File Offset: 0x00016710
	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x21190C0", Offset = "0x21191C1", VA = "0x21190C0")]
	private bool BuildImportedBoneListTry(GameObject goRoot, string strPrefix, int nIndexFirst, int nIndexLast, int nDigitsFirst, int nDigitsLast, List<int> ListImportBonesStatic, List<int> ListImportBonesNoCollider, out List<UltimateRope.RopeBone> outListImportedBones, ref string strErrorMessage)
	{
		return default(bool);
	}

	// Token: 0x06004C4D RID: 19533 RVA: 0x00018528 File Offset: 0x00016728
	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0x2119CA0", Offset = "0x2119DA1", VA = "0x2119CA0")]
	private bool BuildBoneHashString2GameObject(GameObject goRoot, GameObject goCurrent, ref Dictionary<string, GameObject> outHashString2GameObjects, ref string strErrorMessage)
	{
		return default(bool);
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x00018540 File Offset: 0x00016740
	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0x210E8A0", Offset = "0x210E9A1", VA = "0x210E8A0")]
	private bool ParseBoneIndices(string strBoneList, out List<int> outListBoneIndices, out string strErrorMessage)
	{
		return default(bool);
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FFF")]
	[Address(RVA = "0x2119E40", Offset = "0x2119F41", VA = "0x2119E40")]
	public UltimateRope()
	{
	}

	// Token: 0x0400AD34 RID: 44340
	[Token(Token = "0x4008299")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1755C0", Offset = "0x1756C1")]
	public UltimateRope.ERopeType RopeType;

	// Token: 0x0400AD35 RID: 44341
	[Token(Token = "0x400829A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1755D0", Offset = "0x1756D1")]
	public GameObject RopeStart;

	// Token: 0x0400AD36 RID: 44342
	[Token(Token = "0x400829B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1755E0", Offset = "0x1756E1")]
	public List<UltimateRope.RopeNode> RopeNodes;

	// Token: 0x0400AD37 RID: 44343
	[Token(Token = "0x400829C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1755F0", Offset = "0x1756F1")]
	public int RopeLayer;

	// Token: 0x0400AD38 RID: 44344
	[Token(Token = "0x400829D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175600", Offset = "0x175701")]
	public PhysicMaterial RopePhysicsMaterial;

	// Token: 0x0400AD39 RID: 44345
	[Token(Token = "0x400829E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175610", Offset = "0x175711")]
	public float RopeDiameter;

	// Token: 0x0400AD3A RID: 44346
	[Token(Token = "0x400829F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175620", Offset = "0x175721")]
	public float RopeDiameterScaleX;

	// Token: 0x0400AD3B RID: 44347
	[Token(Token = "0x40082A0")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175630", Offset = "0x175731")]
	public float RopeDiameterScaleY;

	// Token: 0x0400AD3C RID: 44348
	[Token(Token = "0x40082A1")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175640", Offset = "0x175741")]
	public int RopeSegmentSides;

	// Token: 0x0400AD3D RID: 44349
	[Token(Token = "0x40082A2")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175650", Offset = "0x175751")]
	public Material RopeMaterial;

	// Token: 0x0400AD3E RID: 44350
	[Token(Token = "0x40082A3")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175660", Offset = "0x175761")]
	public float RopeTextureTileMeters;

	// Token: 0x0400AD3F RID: 44351
	[Token(Token = "0x40082A4")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175670", Offset = "0x175771")]
	public Material RopeSectionMaterial;

	// Token: 0x0400AD40 RID: 44352
	[Token(Token = "0x40082A5")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175680", Offset = "0x175781")]
	public float RopeTextureSectionTileMeters;

	// Token: 0x0400AD41 RID: 44353
	[Token(Token = "0x40082A6")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175690", Offset = "0x175791")]
	public bool IsExtensible;

	// Token: 0x0400AD42 RID: 44354
	[Token(Token = "0x40082A7")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756A0", Offset = "0x1757A1")]
	public float ExtensibleLength;

	// Token: 0x0400AD43 RID: 44355
	[Token(Token = "0x40082A8")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756B0", Offset = "0x1757B1")]
	public bool HasACoil;

	// Token: 0x0400AD44 RID: 44356
	[Token(Token = "0x40082A9")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756C0", Offset = "0x1757C1")]
	public GameObject CoilObject;

	// Token: 0x0400AD45 RID: 44357
	[Token(Token = "0x40082AA")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756D0", Offset = "0x1757D1")]
	public UltimateRope.EAxis CoilAxisRight;

	// Token: 0x0400AD46 RID: 44358
	[Token(Token = "0x40082AB")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756E0", Offset = "0x1757E1")]
	public UltimateRope.EAxis CoilAxisUp;

	// Token: 0x0400AD47 RID: 44359
	[Token(Token = "0x40082AC")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1756F0", Offset = "0x1757F1")]
	public float CoilWidth;

	// Token: 0x0400AD48 RID: 44360
	[Token(Token = "0x40082AD")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175700", Offset = "0x175801")]
	public float CoilDiameter;

	// Token: 0x0400AD49 RID: 44361
	[Token(Token = "0x40082AE")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175710", Offset = "0x175811")]
	public int CoilNumBones;

	// Token: 0x0400AD4A RID: 44362
	[Token(Token = "0x40082AF")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175720", Offset = "0x175821")]
	public GameObject LinkObject;

	// Token: 0x0400AD4B RID: 44363
	[Token(Token = "0x40082B0")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175730", Offset = "0x175831")]
	public UltimateRope.EAxis LinkAxis;

	// Token: 0x0400AD4C RID: 44364
	[Token(Token = "0x40082B1")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175740", Offset = "0x175841")]
	public float LinkOffsetObject;

	// Token: 0x0400AD4D RID: 44365
	[Token(Token = "0x40082B2")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175750", Offset = "0x175851")]
	public float LinkTwistAngleStart;

	// Token: 0x0400AD4E RID: 44366
	[Token(Token = "0x40082B3")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175760", Offset = "0x175861")]
	public float LinkTwistAngleIncrement;

	// Token: 0x0400AD4F RID: 44367
	[Token(Token = "0x40082B4")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175770", Offset = "0x175871")]
	public GameObject BoneFirst;

	// Token: 0x0400AD50 RID: 44368
	[Token(Token = "0x40082B5")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175780", Offset = "0x175881")]
	public GameObject BoneLast;

	// Token: 0x0400AD51 RID: 44369
	[Token(Token = "0x40082B6")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175790", Offset = "0x175891")]
	public string BoneListNamesStatic;

	// Token: 0x0400AD52 RID: 44370
	[Token(Token = "0x40082B7")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757A0", Offset = "0x1758A1")]
	public string BoneListNamesNoColliders;

	// Token: 0x0400AD53 RID: 44371
	[Token(Token = "0x40082B8")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757B0", Offset = "0x1758B1")]
	public UltimateRope.EAxis BoneAxis;

	// Token: 0x0400AD54 RID: 44372
	[Token(Token = "0x40082B9")]
	[FieldOffset(Offset = "0xD4")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757C0", Offset = "0x1758C1")]
	public UltimateRope.EColliderType BoneColliderType;

	// Token: 0x0400AD55 RID: 44373
	[Token(Token = "0x40082BA")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757D0", Offset = "0x1758D1")]
	public float BoneColliderDiameter;

	// Token: 0x0400AD56 RID: 44374
	[Token(Token = "0x40082BB")]
	[FieldOffset(Offset = "0xDC")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757E0", Offset = "0x1758E1")]
	public int BoneColliderSkip;

	// Token: 0x0400AD57 RID: 44375
	[Token(Token = "0x40082BC")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1757F0", Offset = "0x1758F1")]
	public float BoneColliderLength;

	// Token: 0x0400AD58 RID: 44376
	[Token(Token = "0x40082BD")]
	[FieldOffset(Offset = "0xE4")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175800", Offset = "0x175901")]
	public float BoneColliderOffset;

	// Token: 0x0400AD59 RID: 44377
	[Token(Token = "0x40082BE")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175810", Offset = "0x175911")]
	public float LinkMass;

	// Token: 0x0400AD5A RID: 44378
	[Token(Token = "0x40082BF")]
	[FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175820", Offset = "0x175921")]
	public int LinkSolverIterationCount;

	// Token: 0x0400AD5B RID: 44379
	[Token(Token = "0x40082C0")]
	[FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175830", Offset = "0x175931")]
	public float LinkJointAngularXLimit;

	// Token: 0x0400AD5C RID: 44380
	[Token(Token = "0x40082C1")]
	[FieldOffset(Offset = "0xF4")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175840", Offset = "0x175941")]
	public float LinkJointAngularYLimit;

	// Token: 0x0400AD5D RID: 44381
	[Token(Token = "0x40082C2")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175850", Offset = "0x175951")]
	public float LinkJointAngularZLimit;

	// Token: 0x0400AD5E RID: 44382
	[Token(Token = "0x40082C3")]
	[FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175860", Offset = "0x175961")]
	public float LinkJointSpringValue;

	// Token: 0x0400AD5F RID: 44383
	[Token(Token = "0x40082C4")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175870", Offset = "0x175971")]
	public float LinkJointDamperValue;

	// Token: 0x0400AD60 RID: 44384
	[Token(Token = "0x40082C5")]
	[FieldOffset(Offset = "0x104")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175880", Offset = "0x175981")]
	public float LinkJointMaxForceValue;

	// Token: 0x0400AD61 RID: 44385
	[Token(Token = "0x40082C6")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175890", Offset = "0x175991")]
	public float LinkJointBreakForce;

	// Token: 0x0400AD62 RID: 44386
	[Token(Token = "0x40082C7")]
	[FieldOffset(Offset = "0x10C")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758A0", Offset = "0x1759A1")]
	public float LinkJointBreakTorque;

	// Token: 0x0400AD63 RID: 44387
	[Token(Token = "0x40082C8")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758B0", Offset = "0x1759B1")]
	public bool LockStartEndInZAxis;

	// Token: 0x0400AD64 RID: 44388
	[Token(Token = "0x40082C9")]
	[FieldOffset(Offset = "0x111")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758C0", Offset = "0x1759C1")]
	public bool SendEvents;

	// Token: 0x0400AD65 RID: 44389
	[Token(Token = "0x40082CA")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758D0", Offset = "0x1759D1")]
	public GameObject EventsObjectReceiver;

	// Token: 0x0400AD66 RID: 44390
	[Token(Token = "0x40082CB")]
	[FieldOffset(Offset = "0x120")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758E0", Offset = "0x1759E1")]
	public string OnBreakMethodName;

	// Token: 0x0400AD67 RID: 44391
	[Token(Token = "0x40082CC")]
	[FieldOffset(Offset = "0x128")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1758F0", Offset = "0x1759F1")]
	public bool PersistAfterPlayMode;

	// Token: 0x0400AD68 RID: 44392
	[Token(Token = "0x40082CD")]
	[FieldOffset(Offset = "0x129")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175900", Offset = "0x175A01")]
	public bool EnablePrefabUsage;

	// Token: 0x0400AD69 RID: 44393
	[Token(Token = "0x40082CE")]
	[FieldOffset(Offset = "0x12A")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175910", Offset = "0x175A11")]
	public bool AutoRegenerate;

	// Token: 0x0400AD6A RID: 44394
	[Token(Token = "0x40082CF")]
	[FieldOffset(Offset = "0x12B")]
	[Attribute(Name = "HideInInspector", RVA = "0x175920", Offset = "0x175A21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175920", Offset = "0x175A21")]
	public bool Deleted;

	// Token: 0x0400AD6B RID: 44395
	[Token(Token = "0x40082D0")]
	[FieldOffset(Offset = "0x130")]
	[Attribute(Name = "HideInInspector", RVA = "0x175960", Offset = "0x175A61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175960", Offset = "0x175A61")]
	public float[] LinkLengths;

	// Token: 0x0400AD6C RID: 44396
	[Token(Token = "0x40082D1")]
	[FieldOffset(Offset = "0x138")]
	[Attribute(Name = "HideInInspector", RVA = "0x1759A0", Offset = "0x175AA1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1759A0", Offset = "0x175AA1")]
	public int TotalLinks;

	// Token: 0x0400AD6D RID: 44397
	[Token(Token = "0x40082D2")]
	[FieldOffset(Offset = "0x13C")]
	[Attribute(Name = "HideInInspector", RVA = "0x1759E0", Offset = "0x175AE1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x1759E0", Offset = "0x175AE1")]
	public float TotalRopeLength;

	// Token: 0x0400AD6E RID: 44398
	[Token(Token = "0x40082D3")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "HideInInspector", RVA = "0x175A20", Offset = "0x175B21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175A20", Offset = "0x175B21")]
	public bool m_bRopeStartInitialOrientationInitialized;

	// Token: 0x0400AD6F RID: 44399
	[Token(Token = "0x40082D4")]
	[FieldOffset(Offset = "0x144")]
	[Attribute(Name = "HideInInspector", RVA = "0x175A60", Offset = "0x175B61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175A60", Offset = "0x175B61")]
	public Vector3 m_v3InitialRopeStartLocalPos;

	// Token: 0x0400AD70 RID: 44400
	[Token(Token = "0x40082D5")]
	[FieldOffset(Offset = "0x150")]
	[Attribute(Name = "HideInInspector", RVA = "0x175AA0", Offset = "0x175BA1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175AA0", Offset = "0x175BA1")]
	public Quaternion m_qInitialRopeStartLocalRot;

	// Token: 0x0400AD71 RID: 44401
	[Token(Token = "0x40082D6")]
	[FieldOffset(Offset = "0x160")]
	[Attribute(Name = "HideInInspector", RVA = "0x175AE0", Offset = "0x175BE1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175AE0", Offset = "0x175BE1")]
	public Vector3 m_v3InitialRopeStartLocalScale;

	// Token: 0x0400AD72 RID: 44402
	[Token(Token = "0x40082D7")]
	[FieldOffset(Offset = "0x16C")]
	[Attribute(Name = "HideInInspector", RVA = "0x175B20", Offset = "0x175C21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175B20", Offset = "0x175C21")]
	public int m_nFirstNonCoilNode;

	// Token: 0x0400AD73 RID: 44403
	[Token(Token = "0x40082D8")]
	[FieldOffset(Offset = "0x170")]
	[Attribute(Name = "HideInInspector", RVA = "0x175B60", Offset = "0x175C61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175B60", Offset = "0x175C61")]
	public float[] m_afCoilBoneRadiuses;

	// Token: 0x0400AD74 RID: 44404
	[Token(Token = "0x40082D9")]
	[FieldOffset(Offset = "0x178")]
	[Attribute(Name = "HideInInspector", RVA = "0x175BA0", Offset = "0x175CA1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175BA0", Offset = "0x175CA1")]
	public float[] m_afCoilBoneAngles;

	// Token: 0x0400AD75 RID: 44405
	[Token(Token = "0x40082DA")]
	[FieldOffset(Offset = "0x180")]
	[Attribute(Name = "HideInInspector", RVA = "0x175BE0", Offset = "0x175CE1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175BE0", Offset = "0x175CE1")]
	public float[] m_afCoilBoneX;

	// Token: 0x0400AD76 RID: 44406
	[Token(Token = "0x40082DB")]
	[FieldOffset(Offset = "0x188")]
	[Attribute(Name = "HideInInspector", RVA = "0x175C20", Offset = "0x175D21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175C20", Offset = "0x175D21")]
	public float m_fCurrentCoilRopeRadius;

	// Token: 0x0400AD77 RID: 44407
	[Token(Token = "0x40082DC")]
	[FieldOffset(Offset = "0x18C")]
	[Attribute(Name = "HideInInspector", RVA = "0x175C60", Offset = "0x175D61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175C60", Offset = "0x175D61")]
	public float m_fCurrentCoilTurnsLeft;

	// Token: 0x0400AD78 RID: 44408
	[Token(Token = "0x40082DD")]
	[FieldOffset(Offset = "0x190")]
	[Attribute(Name = "HideInInspector", RVA = "0x175CA0", Offset = "0x175DA1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175CA0", Offset = "0x175DA1")]
	public float m_fCurrentCoilLength;

	// Token: 0x0400AD79 RID: 44409
	[Token(Token = "0x40082DE")]
	[FieldOffset(Offset = "0x194")]
	[Attribute(Name = "HideInInspector", RVA = "0x175CE0", Offset = "0x175DE1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175CE0", Offset = "0x175DE1")]
	public float m_fCurrentExtension;

	// Token: 0x0400AD7A RID: 44410
	[Token(Token = "0x40082DF")]
	[FieldOffset(Offset = "0x198")]
	[Attribute(Name = "HideInInspector", RVA = "0x175D20", Offset = "0x175E21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175D20", Offset = "0x175E21")]
	public float m_fCurrentExtensionInput;

	// Token: 0x0400AD7B RID: 44411
	[Token(Token = "0x40082E0")]
	[FieldOffset(Offset = "0x1A0")]
	[Attribute(Name = "HideInInspector", RVA = "0x175D60", Offset = "0x175E61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175D60", Offset = "0x175E61")]
	public UltimateRope.RopeBone[] ImportedBones;

	// Token: 0x0400AD7C RID: 44412
	[Token(Token = "0x40082E1")]
	[FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "HideInInspector", RVA = "0x175DA0", Offset = "0x175EA1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175DA0", Offset = "0x175EA1")]
	public bool m_bBonesAreImported;

	// Token: 0x0400AD7D RID: 44413
	[Token(Token = "0x40082E2")]
	[FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "HideInInspector", RVA = "0x175DE0", Offset = "0x175EE1")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175DE0", Offset = "0x175EE1")]
	public string m_strStatus;

	// Token: 0x0400AD7E RID: 44414
	[Token(Token = "0x40082E3")]
	[FieldOffset(Offset = "0x1B8")]
	[Attribute(Name = "HideInInspector", RVA = "0x175E20", Offset = "0x175F21")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175E20", Offset = "0x175F21")]
	public bool m_bLastStatusIsError;

	// Token: 0x0400AD7F RID: 44415
	[Token(Token = "0x40082E4")]
	[FieldOffset(Offset = "0x1C0")]
	[Attribute(Name = "HideInInspector", RVA = "0x175E60", Offset = "0x175F61")]
	[Attribute(Name = "RopePersistAttribute", RVA = "0x175E60", Offset = "0x175F61")]
	public string m_strAssetFile;

	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2001364")]
	public enum ERopeType
	{
		// Token: 0x0400AD81 RID: 44417
		[Token(Token = "0x401B6F5")]
		Procedural,
		// Token: 0x0400AD82 RID: 44418
		[Token(Token = "0x401B6F6")]
		LinkedObjects,
		// Token: 0x0400AD83 RID: 44419
		[Token(Token = "0x401B6F7")]
		ImportBones
	}

	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2001365")]
	public enum EAxis
	{
		// Token: 0x0400AD85 RID: 44421
		[Token(Token = "0x401B6F9")]
		MinusX,
		// Token: 0x0400AD86 RID: 44422
		[Token(Token = "0x401B6FA")]
		MinusY,
		// Token: 0x0400AD87 RID: 44423
		[Token(Token = "0x401B6FB")]
		MinusZ,
		// Token: 0x0400AD88 RID: 44424
		[Token(Token = "0x401B6FC")]
		X,
		// Token: 0x0400AD89 RID: 44425
		[Token(Token = "0x401B6FD")]
		Y,
		// Token: 0x0400AD8A RID: 44426
		[Token(Token = "0x401B6FE")]
		Z
	}

	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2001366")]
	public enum EColliderType
	{
		// Token: 0x0400AD8C RID: 44428
		[Token(Token = "0x401B700")]
		None,
		// Token: 0x0400AD8D RID: 44429
		[Token(Token = "0x401B701")]
		Capsule,
		// Token: 0x0400AD8E RID: 44430
		[Token(Token = "0x401B702")]
		Box
	}

	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2001367")]
	public enum ERopeExtensionMode
	{
		// Token: 0x0400AD90 RID: 44432
		[Token(Token = "0x401B704")]
		CoilRotationIncrement,
		// Token: 0x0400AD91 RID: 44433
		[Token(Token = "0x401B705")]
		LinearExtensionIncrement
	}

	// Token: 0x02000BA0 RID: 2976
	[Token(Token = "0x2001368")]
	[Serializable]
	public class RopeNode
	{
		// Token: 0x06004C50 RID: 19536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007732")]
		[Address(RVA = "0x1E44600", Offset = "0x1E44701", VA = "0x1E44600")]
		public RopeNode()
		{
		}

		// Token: 0x0400AD92 RID: 44434
		[Token(Token = "0x401B706")]
		[FieldOffset(Offset = "0x10")]
		public GameObject goNode;

		// Token: 0x0400AD93 RID: 44435
		[Token(Token = "0x401B707")]
		[FieldOffset(Offset = "0x18")]
		public float fLength;

		// Token: 0x0400AD94 RID: 44436
		[Token(Token = "0x401B708")]
		[FieldOffset(Offset = "0x1C")]
		public float fTotalLength;

		// Token: 0x0400AD95 RID: 44437
		[Token(Token = "0x401B709")]
		[FieldOffset(Offset = "0x20")]
		public int nNumLinks;

		// Token: 0x0400AD96 RID: 44438
		[Token(Token = "0x401B70A")]
		[FieldOffset(Offset = "0x24")]
		public int nTotalLinks;

		// Token: 0x0400AD97 RID: 44439
		[Token(Token = "0x401B70B")]
		[FieldOffset(Offset = "0x28")]
		public UltimateRope.EColliderType eColliderType;

		// Token: 0x0400AD98 RID: 44440
		[Token(Token = "0x401B70C")]
		[FieldOffset(Offset = "0x2C")]
		public int nColliderSkip;

		// Token: 0x0400AD99 RID: 44441
		[Token(Token = "0x401B70D")]
		[FieldOffset(Offset = "0x30")]
		public bool bFold;

		// Token: 0x0400AD9A RID: 44442
		[Token(Token = "0x401B70E")]
		[FieldOffset(Offset = "0x31")]
		public bool bIsCoil;

		// Token: 0x0400AD9B RID: 44443
		[Token(Token = "0x401B70F")]
		[FieldOffset(Offset = "0x32")]
		public bool bInitialOrientationInitialized;

		// Token: 0x0400AD9C RID: 44444
		[Token(Token = "0x401B710")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 v3InitialLocalPos;

		// Token: 0x0400AD9D RID: 44445
		[Token(Token = "0x401B711")]
		[FieldOffset(Offset = "0x40")]
		public Quaternion qInitialLocalRot;

		// Token: 0x0400AD9E RID: 44446
		[Token(Token = "0x401B712")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 v3InitialLocalScale;

		// Token: 0x0400AD9F RID: 44447
		[Token(Token = "0x401B713")]
		[FieldOffset(Offset = "0x5C")]
		public bool m_bExtensionInitialized;

		// Token: 0x0400ADA0 RID: 44448
		[Token(Token = "0x401B714")]
		[FieldOffset(Offset = "0x60")]
		public int m_nExtensionLinkIn;

		// Token: 0x0400ADA1 RID: 44449
		[Token(Token = "0x401B715")]
		[FieldOffset(Offset = "0x64")]
		public int m_nExtensionLinkOut;

		// Token: 0x0400ADA2 RID: 44450
		[Token(Token = "0x401B716")]
		[FieldOffset(Offset = "0x68")]
		public float m_fExtensionRemainingLength;

		// Token: 0x0400ADA3 RID: 44451
		[Token(Token = "0x401B717")]
		[FieldOffset(Offset = "0x6C")]
		public float m_fExtensionRemainderIn;

		// Token: 0x0400ADA4 RID: 44452
		[Token(Token = "0x401B718")]
		[FieldOffset(Offset = "0x70")]
		public float m_fExtensionRemainderOut;

		// Token: 0x0400ADA5 RID: 44453
		[Token(Token = "0x401B719")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 m_v3LocalDirectionForward;

		// Token: 0x0400ADA6 RID: 44454
		[Token(Token = "0x401B71A")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 m_v3LocalDirectionUp;

		// Token: 0x0400ADA7 RID: 44455
		[Token(Token = "0x401B71B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject[] segmentLinks;

		// Token: 0x0400ADA8 RID: 44456
		[Token(Token = "0x401B71C")]
		[FieldOffset(Offset = "0x98")]
		public ConfigurableJoint[] linkJoints;

		// Token: 0x0400ADA9 RID: 44457
		[Token(Token = "0x401B71D")]
		[FieldOffset(Offset = "0xA0")]
		public bool[] linkJointBreaksProcessed;

		// Token: 0x0400ADAA RID: 44458
		[Token(Token = "0x401B71E")]
		[FieldOffset(Offset = "0xA8")]
		public bool bSegmentBroken;
	}

	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2001369")]
	[Serializable]
	public class RopeBone
	{
		// Token: 0x06004C51 RID: 19537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007733")]
		[Address(RVA = "0x1E44580", Offset = "0x1E44681", VA = "0x1E44580")]
		public RopeBone()
		{
		}

		// Token: 0x0400ADAB RID: 44459
		[Token(Token = "0x401B71F")]
		[FieldOffset(Offset = "0x10")]
		public GameObject goBone;

		// Token: 0x0400ADAC RID: 44460
		[Token(Token = "0x401B720")]
		[FieldOffset(Offset = "0x18")]
		public Transform tfParent;

		// Token: 0x0400ADAD RID: 44461
		[Token(Token = "0x401B721")]
		[FieldOffset(Offset = "0x20")]
		public Transform tfNonBoneParent;

		// Token: 0x0400ADAE RID: 44462
		[Token(Token = "0x401B722")]
		[FieldOffset(Offset = "0x28")]
		public bool bCreatedCollider;

		// Token: 0x0400ADAF RID: 44463
		[Token(Token = "0x401B723")]
		[FieldOffset(Offset = "0x29")]
		public bool bIsStatic;

		// Token: 0x0400ADB0 RID: 44464
		[Token(Token = "0x401B724")]
		[FieldOffset(Offset = "0x2C")]
		public float fLength;

		// Token: 0x0400ADB1 RID: 44465
		[Token(Token = "0x401B725")]
		[FieldOffset(Offset = "0x30")]
		public bool bCreatedRigidbody;

		// Token: 0x0400ADB2 RID: 44466
		[Token(Token = "0x401B726")]
		[FieldOffset(Offset = "0x34")]
		public int nOriginalLayer;

		// Token: 0x0400ADB3 RID: 44467
		[Token(Token = "0x401B727")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 v3OriginalLocalScale;

		// Token: 0x0400ADB4 RID: 44468
		[Token(Token = "0x401B728")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 v3OriginalLocalPos;

		// Token: 0x0400ADB5 RID: 44469
		[Token(Token = "0x401B729")]
		[FieldOffset(Offset = "0x50")]
		public Quaternion qOriginalLocalRot;
	}

	// Token: 0x02000BA2 RID: 2978
	[Token(Token = "0x200136A")]
	public class RopeBreakEventInfo
	{
		// Token: 0x06004C52 RID: 19538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007734")]
		[Address(RVA = "0x1E445F0", Offset = "0x1E446F1", VA = "0x1E445F0")]
		public RopeBreakEventInfo()
		{
		}

		// Token: 0x0400ADB6 RID: 44470
		[Token(Token = "0x401B72A")]
		[FieldOffset(Offset = "0x10")]
		public UltimateRope rope;

		// Token: 0x0400ADB7 RID: 44471
		[Token(Token = "0x401B72B")]
		[FieldOffset(Offset = "0x18")]
		public GameObject link1;

		// Token: 0x0400ADB8 RID: 44472
		[Token(Token = "0x401B72C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject link2;

		// Token: 0x0400ADB9 RID: 44473
		[Token(Token = "0x401B72D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 worldPos;

		// Token: 0x0400ADBA RID: 44474
		[Token(Token = "0x401B72E")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 localLink1Pos;

		// Token: 0x0400ADBB RID: 44475
		[Token(Token = "0x401B72F")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 localLink2Pos;
	}
}
