using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UltimateGameTools.MeshSimplifier;
using UnityEngine;

// Token: 0x02000B66 RID: 2918
[Token(Token = "0x200079B")]
public class AutomaticLOD : MonoBehaviour
{
	// Token: 0x170009E0 RID: 2528
	// (get) Token: 0x06004AEF RID: 19183 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004AF0 RID: 19184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007E0")]
	public static Camera UserDefinedLODCamera
	{
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x228FD70", Offset = "0x228FE71", VA = "0x228FD70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x228FDE0", Offset = "0x228FEE1", VA = "0x228FDE0")]
		set
		{
		}
	}

	// Token: 0x170009E1 RID: 2529
	// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x00017E38 File Offset: 0x00016038
	[Token(Token = "0x170007E1")]
	public AutomaticLOD.SwitchMode LODSwitchMode
	{
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x228FE50", Offset = "0x228FF51", VA = "0x228FE50")]
		get
		{
			return AutomaticLOD.SwitchMode.SwitchMesh;
		}
	}

	// Token: 0x06004AF2 RID: 19186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC7")]
	[Address(RVA = "0x228FF20", Offset = "0x2290021", VA = "0x228FF20")]
	private void Awake()
	{
	}

	// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC8")]
	[Address(RVA = "0x2290740", Offset = "0x2290841", VA = "0x2290740")]
	private void Update()
	{
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC9")]
	[Address(RVA = "0x2291080", Offset = "0x2291181", VA = "0x2291080")]
	private void OnWillRenderObject()
	{
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x00017E50 File Offset: 0x00016050
	[Token(Token = "0x6003ECA")]
	[Address(RVA = "0x22910B0", Offset = "0x22911B1", VA = "0x22910B0")]
	public static bool HasValidMeshData(GameObject go)
	{
		return default(bool);
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x00017E68 File Offset: 0x00016068
	[Token(Token = "0x6003ECB")]
	[Address(RVA = "0x22911A0", Offset = "0x22912A1", VA = "0x22911A0")]
	public static bool IsRootOrBelongsToLODTree(AutomaticLOD automaticLOD, AutomaticLOD root)
	{
		return default(bool);
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x00017E80 File Offset: 0x00016080
	[Token(Token = "0x6003ECC")]
	[Address(RVA = "0x2291340", Offset = "0x2291441", VA = "0x2291340")]
	public int GetNumberOfLevelsToGenerate()
	{
		return 0;
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x00017E98 File Offset: 0x00016098
	[Token(Token = "0x6003ECD")]
	[Address(RVA = "0x2291350", Offset = "0x2291451", VA = "0x2291350")]
	public bool IsGenerateIncludeChildrenActive()
	{
		return default(bool);
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x00017EB0 File Offset: 0x000160B0
	[Token(Token = "0x6003ECE")]
	[Address(RVA = "0x2291360", Offset = "0x2291461", VA = "0x2291360")]
	public bool IsRootAutomaticLOD()
	{
		return default(bool);
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x00017EC8 File Offset: 0x000160C8
	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0x22913D0", Offset = "0x22914D1", VA = "0x22913D0")]
	public bool HasDependentChildren()
	{
		return default(bool);
	}

	// Token: 0x06004AFB RID: 19195 RVA: 0x00017EE0 File Offset: 0x000160E0
	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0x2291440", Offset = "0x2291541", VA = "0x2291440")]
	public bool HasLODDataDirty()
	{
		return default(bool);
	}

	// Token: 0x06004AFC RID: 19196 RVA: 0x00017EF8 File Offset: 0x000160F8
	[Token(Token = "0x6003ED1")]
	[Address(RVA = "0x2291450", Offset = "0x2291551", VA = "0x2291450")]
	public bool SetLODDataDirty(bool bDirty)
	{
		return default(bool);
	}

	// Token: 0x06004AFD RID: 19197 RVA: 0x00017F10 File Offset: 0x00016110
	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0x2291460", Offset = "0x2291561", VA = "0x2291460")]
	public int GetLODLevelCount()
	{
		return 0;
	}

	// Token: 0x06004AFE RID: 19198 RVA: 0x00017F28 File Offset: 0x00016128
	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0x22914C0", Offset = "0x22915C1", VA = "0x22914C0")]
	public float ComputeScreenCoverage(Camera camera)
	{
		return 0f;
	}

	// Token: 0x06004AFF RID: 19199 RVA: 0x00017F40 File Offset: 0x00016140
	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0x2290230", Offset = "0x2290331", VA = "0x2290230")]
	public Vector3 ComputeWorldCenter()
	{
		return default(Vector3);
	}

	// Token: 0x06004B00 RID: 19200 RVA: 0x00017F58 File Offset: 0x00016158
	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0x2291F30", Offset = "0x2292031", VA = "0x2291F30")]
	public float ComputeViewSpaceBounds(Vector3 v3CameraPos, Vector3 v3CameraDir, Vector3 v3CameraUp, out Vector3 v3Min, out Vector3 v3Max, out Vector3 v3Center)
	{
		return 0f;
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0x2292680", Offset = "0x2292781", VA = "0x2292680")]
	public void SetAutomaticCameraLODSwitch(bool bEnabled)
	{
	}

	// Token: 0x06004B02 RID: 19202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ED7")]
	[Address(RVA = "0x2292710", Offset = "0x2292811", VA = "0x2292710")]
	private static void SetAutomaticCameraLODSwitchRecursive(AutomaticLOD root, GameObject gameObject, bool bEnabled)
	{
	}

	// Token: 0x06004B03 RID: 19203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0x22928A0", Offset = "0x22929A1", VA = "0x22928A0")]
	public void SetLODLevels(List<AutomaticLOD.LODLevelData> listLODLevelData, AutomaticLOD.EvalMode evalMode, float fMaxCameraDistance, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B04 RID: 19204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003ED9")]
	[Address(RVA = "0x2292A20", Offset = "0x2292B21", VA = "0x2292A20")]
	private static void SetLODLevelsRecursive(AutomaticLOD root, GameObject gameObject)
	{
	}

	// Token: 0x06004B05 RID: 19205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EDA")]
	[Address(RVA = "0x22933C0", Offset = "0x22934C1", VA = "0x22933C0")]
	public void AddLODLevel(int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B06 RID: 19206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EDB")]
	[Address(RVA = "0x2293470", Offset = "0x2293571", VA = "0x2293470")]
	public static void AddLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B07 RID: 19207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EDC")]
	[Address(RVA = "0x2294020", Offset = "0x2294121", VA = "0x2294020")]
	public void RemoveLODLevel(int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B08 RID: 19208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EDD")]
	[Address(RVA = "0x22940C0", Offset = "0x22941C1", VA = "0x22940C0")]
	public static void RemoveLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B09 RID: 19209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003EDE")]
	[Address(RVA = "0x22945E0", Offset = "0x22946E1", VA = "0x22945E0")]
	public Simplifier GetMeshSimplifier()
	{
		return null;
	}

	// Token: 0x06004B0A RID: 19210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EDF")]
	[Address(RVA = "0x22945F0", Offset = "0x22946F1", VA = "0x22945F0")]
	public void ComputeLODData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004B0B RID: 19211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0x2294640", Offset = "0x2294741", VA = "0x2294640")]
	private void ComputeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004B0C RID: 19212 RVA: 0x00017F70 File Offset: 0x00016170
	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0x2295120", Offset = "0x2295221", VA = "0x2295120")]
	public bool HasLODData()
	{
		return default(bool);
	}

	// Token: 0x06004B0D RID: 19213 RVA: 0x00017F88 File Offset: 0x00016188
	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0x2290CE0", Offset = "0x2290DE1", VA = "0x2290CE0")]
	public int GetLODLevelUsingCamera(Camera currentCamera)
	{
		return 0;
	}

	// Token: 0x06004B0E RID: 19214 RVA: 0x00017FA0 File Offset: 0x000161A0
	[Token(Token = "0x6003EE3")]
	[Address(RVA = "0x22951D0", Offset = "0x22952D1", VA = "0x22951D0")]
	public int GetCurrentLODLevel()
	{
		return 0;
	}

	// Token: 0x06004B0F RID: 19215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE4")]
	[Address(RVA = "0x2290F90", Offset = "0x2291091", VA = "0x2290F90")]
	public void SwitchToLOD(int nLevel, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B10 RID: 19216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE5")]
	[Address(RVA = "0x22951E0", Offset = "0x22952E1", VA = "0x22951E0")]
	private static void SwitchToLODRecursive(AutomaticLOD root, GameObject gameObject, int nLODLevel, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B11 RID: 19217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE6")]
	[Address(RVA = "0x2295820", Offset = "0x2295921", VA = "0x2295820")]
	public void ComputeAllLODMeshes(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004B12 RID: 19218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE7")]
	[Address(RVA = "0x22966E0", Offset = "0x22967E1", VA = "0x22966E0")]
	public void ComputeLODMesh(int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004B13 RID: 19219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0x22959C0", Offset = "0x2295AC1", VA = "0x22959C0")]
	private static void ComputeLODMeshRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
	}

	// Token: 0x06004B14 RID: 19220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EE9")]
	[Address(RVA = "0x2296790", Offset = "0x2296891", VA = "0x2296790")]
	public void RestoreOriginalMesh(bool bDeleteLODData, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B15 RID: 19221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EEA")]
	[Address(RVA = "0x2296870", Offset = "0x2296971", VA = "0x2296870")]
	private static void RestoreOriginalMeshRecursive(AutomaticLOD root, GameObject gameObject, bool bDeleteLODData, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B16 RID: 19222 RVA: 0x00017FB8 File Offset: 0x000161B8
	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0x2296CE0", Offset = "0x2296DE1", VA = "0x2296CE0")]
	public bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004B17 RID: 19223 RVA: 0x00017FD0 File Offset: 0x000161D0
	[Token(Token = "0x6003EEC")]
	[Address(RVA = "0x2296D70", Offset = "0x2296E71", VA = "0x2296D70")]
	private static bool HasOriginalMeshActiveRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004B18 RID: 19224 RVA: 0x00017FE8 File Offset: 0x000161E8
	[Token(Token = "0x6003EED")]
	[Address(RVA = "0x2297040", Offset = "0x2297141", VA = "0x2297040")]
	public bool HasVertexData(int nLevel, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004B19 RID: 19225 RVA: 0x00018000 File Offset: 0x00016200
	[Token(Token = "0x6003EEE")]
	[Address(RVA = "0x22970D0", Offset = "0x22971D1", VA = "0x22970D0")]
	private static bool HasVertexDataRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren)
	{
		return default(bool);
	}

	// Token: 0x06004B1A RID: 19226 RVA: 0x00018018 File Offset: 0x00016218
	[Token(Token = "0x6003EEF")]
	[Address(RVA = "0x22973A0", Offset = "0x22974A1", VA = "0x22973A0")]
	public int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF0")]
	[Address(RVA = "0x2297440", Offset = "0x2297541", VA = "0x2297440")]
	private static void GetOriginalVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B1C RID: 19228 RVA: 0x00018030 File Offset: 0x00016230
	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0x2297630", Offset = "0x2297731", VA = "0x2297630")]
	public int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004B1D RID: 19229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0x22976D0", Offset = "0x22977D1", VA = "0x22976D0")]
	private static void GetOriginalTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B1E RID: 19230 RVA: 0x00018048 File Offset: 0x00016248
	[Token(Token = "0x6003EF3")]
	[Address(RVA = "0x22978E0", Offset = "0x22979E1", VA = "0x22978E0")]
	public int GetCurrentVertexCount(bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004B1F RID: 19231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF4")]
	[Address(RVA = "0x2297980", Offset = "0x2297A81", VA = "0x2297980")]
	private static void GetCurrentVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B20 RID: 19232 RVA: 0x00018060 File Offset: 0x00016260
	[Token(Token = "0x6003EF5")]
	[Address(RVA = "0x2297C60", Offset = "0x2297D61", VA = "0x2297C60")]
	public int GetLODVertexCount(int nLevel, bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004B21 RID: 19233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0x2297D10", Offset = "0x2297E11", VA = "0x2297D10")]
	private static void GetLODVertexCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nVertexCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B22 RID: 19234 RVA: 0x00018078 File Offset: 0x00016278
	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0x2297FE0", Offset = "0x22980E1", VA = "0x2297FE0")]
	public int GetLODTriangleCount(int nLevel, bool bRecurseIntoChildren)
	{
		return 0;
	}

	// Token: 0x06004B23 RID: 19235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0x2298090", Offset = "0x2298191", VA = "0x2298090")]
	private static void GetLODTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B24 RID: 19236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EF9")]
	[Address(RVA = "0x2298390", Offset = "0x2298491", VA = "0x2298390")]
	public void RemoveFromLODTree()
	{
	}

	// Token: 0x06004B25 RID: 19237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EFA")]
	[Address(RVA = "0x2295090", Offset = "0x2295191", VA = "0x2295090")]
	public void FreeLODData(bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B26 RID: 19238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EFB")]
	[Address(RVA = "0x2298440", Offset = "0x2298541", VA = "0x2298440")]
	private static void FreeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
	}

	// Token: 0x06004B27 RID: 19239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003EFC")]
	[Address(RVA = "0x2292FB0", Offset = "0x22930B1", VA = "0x2292FB0")]
	private static Mesh CreateNewEmptyMesh(AutomaticLOD automaticLOD)
	{
		return null;
	}

	// Token: 0x06004B28 RID: 19240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003EFD")]
	[Address(RVA = "0x22989D0", Offset = "0x2298AD1", VA = "0x22989D0")]
	private static GameObject CreateBasicObjectCopy(GameObject gameObject, Mesh mesh, Transform parent)
	{
		return null;
	}

	// Token: 0x06004B29 RID: 19241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EFE")]
	[Address(RVA = "0x22930A0", Offset = "0x22931A1", VA = "0x22930A0")]
	private static void CheckForAdditionalLODSetup(AutomaticLOD root, AutomaticLOD automaticLOD, AutomaticLOD.LODLevelData levelData, int level)
	{
	}

	// Token: 0x06004B2A RID: 19242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EFF")]
	[Address(RVA = "0x2296350", Offset = "0x2296451", VA = "0x2296350")]
	public void SetupLODGroup()
	{
	}

	// Token: 0x06004B2B RID: 19243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F00")]
	[Address(RVA = "0x2298E60", Offset = "0x2298F61", VA = "0x2298E60")]
	private static void SetupLODGroupRecursive(AutomaticLOD root, GameObject gameObject, ref List<List<Renderer>> renderers)
	{
	}

	// Token: 0x06004B2C RID: 19244 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F01")]
	[Address(RVA = "0x2298E50", Offset = "0x2298F51", VA = "0x2298E50")]
	private static Component CopyComponent(Component original, GameObject destination)
	{
		return null;
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F02")]
	[Address(RVA = "0x2291BA0", Offset = "0x2291CA1", VA = "0x2291BA0")]
	private void BuildCornerData(ref Vector3[] av3Corners, Bounds bounds)
	{
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x00018090 File Offset: 0x00016290
	[Token(Token = "0x6003F03")]
	[Address(RVA = "0x2290680", Offset = "0x2290781", VA = "0x2290680")]
	private bool IsDependent()
	{
		return default(bool);
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F04")]
	[Address(RVA = "0x22991F0", Offset = "0x22992F1", VA = "0x22991F0")]
	public AutomaticLOD()
	{
	}

	// Token: 0x0400AB92 RID: 43922
	[Token(Token = "0x4008176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HideInInspector", RVA = "0x175000", Offset = "0x175101")]
	public Mesh m_originalMesh;

	// Token: 0x0400AB93 RID: 43923
	[Token(Token = "0x4008177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HideInInspector", RVA = "0x175010", Offset = "0x175111")]
	public AutomaticLOD.EvalMode m_evalMode;

	// Token: 0x0400AB94 RID: 43924
	[Token(Token = "0x4008178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Attribute(Name = "HideInInspector", RVA = "0x175020", Offset = "0x175121")]
	public bool m_bEnablePrefabUsage;

	// Token: 0x0400AB95 RID: 43925
	[Token(Token = "0x4008179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x175030", Offset = "0x175131")]
	public string m_strAssetPath;

	// Token: 0x0400AB96 RID: 43926
	[Token(Token = "0x400817A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x175040", Offset = "0x175141")]
	public float m_fMaxCameraDistance;

	// Token: 0x0400AB97 RID: 43927
	[Token(Token = "0x400817B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Attribute(Name = "HideInInspector", RVA = "0x175050", Offset = "0x175151")]
	public int m_nColorEditorBarNewIndex;

	// Token: 0x0400AB98 RID: 43928
	[Token(Token = "0x400817C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HideInInspector", RVA = "0x175060", Offset = "0x175161")]
	public List<AutomaticLOD.LODLevelData> m_listLODLevels;

	// Token: 0x0400AB99 RID: 43929
	[Token(Token = "0x400817D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HideInInspector", RVA = "0x175070", Offset = "0x175171")]
	public AutomaticLOD m_LODObjectRoot;

	// Token: 0x0400AB9A RID: 43930
	[Token(Token = "0x400817E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HideInInspector", RVA = "0x175080", Offset = "0x175181")]
	public List<AutomaticLOD> m_listDependentChildren;

	// Token: 0x0400AB9B RID: 43931
	[Token(Token = "0x400817F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool m_bExpandRelevanceSpheres;

	// Token: 0x0400AB9C RID: 43932
	[Token(Token = "0x4008180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RelevanceSphere[] m_aRelevanceSpheres;

	// Token: 0x0400AB9D RID: 43933
	[Token(Token = "0x4008181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Simplifier m_meshSimplifier;

	// Token: 0x0400AB9E RID: 43934
	[Token(Token = "0x4008182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool m_bGenerateIncludeChildren;

	// Token: 0x0400AB9F RID: 43935
	[Token(Token = "0x4008183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private AutomaticLOD.LevelsToGenerate m_levelsToGenerate;

	// Token: 0x0400ABA0 RID: 43936
	[Token(Token = "0x4008184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AutomaticLOD.SwitchMode m_switchMode;

	// Token: 0x0400ABA1 RID: 43937
	[Token(Token = "0x4008185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private bool m_bOverrideRootSettings;

	// Token: 0x0400ABA2 RID: 43938
	[Token(Token = "0x4008186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x1750E0", Offset = "0x1751E1")]
	private bool m_bLODDataDirty;

	// Token: 0x0400ABA3 RID: 43939
	[Token(Token = "0x4008187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175120", Offset = "0x175221")]
	private AutomaticLOD m_LODObjectRootPersist;

	// Token: 0x0400ABA4 RID: 43940
	[Token(Token = "0x4008188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x175160", Offset = "0x175261")]
	private LODGroup m_LODGroup;

	// Token: 0x0400ABA5 RID: 43941
	[Token(Token = "0x4008189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool m_bUseAutomaticCameraLODSwitch;

	// Token: 0x0400ABA6 RID: 43942
	[Token(Token = "0x400818A")]
	private const int k_MaxLODChecksPerFrame = 4;

	// Token: 0x0400ABA7 RID: 43943
	[Token(Token = "0x400818B")]
	private const int k_MaxFrameCheckLoop = 100;

	// Token: 0x0400ABA8 RID: 43944
	[Token(Token = "0x400818C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_currentCheckIndex;

	// Token: 0x0400ABA9 RID: 43945
	[Token(Token = "0x400818D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int s_currentFrameCheckIndex;

	// Token: 0x0400ABAA RID: 43946
	[Token(Token = "0x400818E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int s_checkLoopLength;

	// Token: 0x0400ABAB RID: 43947
	[Token(Token = "0x400818F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int s_lastFrameComputedModulus;

	// Token: 0x0400ABAC RID: 43948
	[Token(Token = "0x4008190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int s_currentFrameInLoop;

	// Token: 0x0400ABAD RID: 43949
	[Token(Token = "0x4008191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Camera s_userDefinedCamera;

	// Token: 0x0400ABAE RID: 43950
	[Token(Token = "0x4008192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Camera m_renderCamera;

	// Token: 0x0400ABAF RID: 43951
	[Token(Token = "0x4008193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int m_nCurrentLOD;

	// Token: 0x0400ABB0 RID: 43952
	[Token(Token = "0x4008194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<Camera, int> m_cachedFrameLODLevel;

	// Token: 0x0400ABB1 RID: 43953
	[Token(Token = "0x4008195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 m_localCenter;

	// Token: 0x0400ABB2 RID: 43954
	[Token(Token = "0x4008196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3[] _corners;

	// Token: 0x0400ABB3 RID: 43955
	[Token(Token = "0x4008197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int m_frameToCheck;

	// Token: 0x0400ABB4 RID: 43956
	[Token(Token = "0x4008198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool b_performCheck;

	// Token: 0x02000B67 RID: 2919
	[Token(Token = "0x200134C")]
	[Serializable]
	public enum EvalMode
	{
		// Token: 0x0400ABB6 RID: 43958
		[Token(Token = "0x401B67E")]
		CameraDistance,
		// Token: 0x0400ABB7 RID: 43959
		[Token(Token = "0x401B67F")]
		ScreenCoverage
	}

	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x200134D")]
	[Serializable]
	public enum LevelsToGenerate
	{
		// Token: 0x0400ABB9 RID: 43961
		[Token(Token = "0x401B681")]
		_1 = 1,
		// Token: 0x0400ABBA RID: 43962
		[Token(Token = "0x401B682")]
		_2,
		// Token: 0x0400ABBB RID: 43963
		[Token(Token = "0x401B683")]
		_3,
		// Token: 0x0400ABBC RID: 43964
		[Token(Token = "0x401B684")]
		_4,
		// Token: 0x0400ABBD RID: 43965
		[Token(Token = "0x401B685")]
		_5,
		// Token: 0x0400ABBE RID: 43966
		[Token(Token = "0x401B686")]
		_6
	}

	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x200134E")]
	[Serializable]
	public enum SwitchMode
	{
		// Token: 0x0400ABC0 RID: 43968
		[Token(Token = "0x401B688")]
		SwitchMesh,
		// Token: 0x0400ABC1 RID: 43969
		[Token(Token = "0x401B689")]
		SwitchGameObject,
		// Token: 0x0400ABC2 RID: 43970
		[Token(Token = "0x401B68A")]
		UnityLODGroup
	}

	// Token: 0x02000B6A RID: 2922
	[Token(Token = "0x200134F")]
	[Serializable]
	public class LODLevelData
	{
		// Token: 0x06004B31 RID: 19249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600770E")]
		[Address(RVA = "0x2292F10", Offset = "0x2293011", VA = "0x2292F10")]
		public AutomaticLOD.LODLevelData GetCopy()
		{
			return null;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770F")]
		[Address(RVA = "0x2294010", Offset = "0x2294111", VA = "0x2294010")]
		public LODLevelData()
		{
		}

		// Token: 0x0400ABC3 RID: 43971
		[Token(Token = "0x401B68B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m_fScreenCoverage;

		// Token: 0x0400ABC4 RID: 43972
		[Token(Token = "0x401B68C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_fMaxCameraDistance;

		// Token: 0x0400ABC5 RID: 43973
		[Token(Token = "0x401B68D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_fMeshVerticesAmount;

		// Token: 0x0400ABC6 RID: 43974
		[Token(Token = "0x401B68E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int m_nColorEditorBarIndex;

		// Token: 0x0400ABC7 RID: 43975
		[Token(Token = "0x401B68F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh m_mesh;

		// Token: 0x0400ABC8 RID: 43976
		[Token(Token = "0x401B690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_bUsesOriginalMesh;

		// Token: 0x0400ABC9 RID: 43977
		[Token(Token = "0x401B691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject m_gameObject;
	}
}
