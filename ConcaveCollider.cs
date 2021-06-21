using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B6C RID: 2924
[Token(Token = "0x200079D")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x1473D0", Offset = "0x1474D1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x1473D0", Offset = "0x1474D1")]
public class ConcaveCollider : MonoBehaviour
{
	// Token: 0x06004B36 RID: 19254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F09")]
	[Address(RVA = "0x20DEF90", Offset = "0x20DF091", VA = "0x20DEF90")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F0A")]
	[Address(RVA = "0x20DF1A0", Offset = "0x20DF2A1", VA = "0x20DF1A0")]
	private void Reset()
	{
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F0B")]
	[Address(RVA = "0x20DF1B0", Offset = "0x20DF2B1", VA = "0x20DF1B0")]
	private void Update()
	{
	}

	// Token: 0x06004B39 RID: 19257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F0C")]
	[Address(RVA = "0x20DEFA0", Offset = "0x20DF0A1", VA = "0x20DEFA0")]
	public void DestroyHulls()
	{
	}

	// Token: 0x06004B3A RID: 19258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0x20DF480", Offset = "0x20DF581", VA = "0x20DF480")]
	public void CancelComputation()
	{
	}

	// Token: 0x06004B3B RID: 19259 RVA: 0x000180A8 File Offset: 0x000162A8
	[Token(Token = "0x6003F0E")]
	[Address(RVA = "0x20DF560", Offset = "0x20DF661", VA = "0x20DF560")]
	public int GetLargestHullVertices()
	{
		return 0;
	}

	// Token: 0x06004B3C RID: 19260 RVA: 0x000180C0 File Offset: 0x000162C0
	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0x20DF570", Offset = "0x20DF671", VA = "0x20DF570")]
	public int GetLargestHullFaces()
	{
		return 0;
	}

	// Token: 0x06004B3D RID: 19261
	[Token(Token = "0x6003F10")]
	[Address(RVA = "0x20DF580", Offset = "0x20DF681", VA = "0x20DF580")]
	[PreserveSig]
	private static extern void DllInit(bool bUseMultithreading);

	// Token: 0x06004B3E RID: 19262
	[Token(Token = "0x6003F11")]
	[Address(RVA = "0x20DF600", Offset = "0x20DF701", VA = "0x20DF600")]
	[PreserveSig]
	private static extern void DllClose();

	// Token: 0x06004B3F RID: 19263
	[Token(Token = "0x6003F12")]
	[Address(RVA = "0x20DF670", Offset = "0x20DF771", VA = "0x20DF670")]
	[PreserveSig]
	private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog);

	// Token: 0x06004B40 RID: 19264
	[Token(Token = "0x6003F13")]
	[Address(RVA = "0x20DF6F0", Offset = "0x20DF7F1", VA = "0x20DF6F0")]
	[PreserveSig]
	private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress);

	// Token: 0x06004B41 RID: 19265
	[Token(Token = "0x6003F14")]
	[Address(RVA = "0x20DF4F0", Offset = "0x20DF5F1", VA = "0x20DF4F0")]
	[PreserveSig]
	private static extern void CancelConvexDecomposition();

	// Token: 0x06004B42 RID: 19266
	[Token(Token = "0x6003F15")]
	[Address(RVA = "0x20DF770", Offset = "0x20DF871", VA = "0x20DF770")]
	[PreserveSig]
	private static extern bool DoConvexDecomposition(ref ConcaveCollider.SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices);

	// Token: 0x06004B43 RID: 19267
	[Token(Token = "0x6003F16")]
	[Address(RVA = "0x20DF820", Offset = "0x20DF921", VA = "0x20DF820")]
	[PreserveSig]
	private static extern bool GetHullInfo(uint uHullIndex, ref ConcaveCollider.SConvexDecompositionHullInfo infoOut);

	// Token: 0x06004B44 RID: 19268
	[Token(Token = "0x6003F17")]
	[Address(RVA = "0x20DF8C0", Offset = "0x20DF9C1", VA = "0x20DF8C0")]
	[PreserveSig]
	private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut);

	// Token: 0x06004B45 RID: 19269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F18")]
	[Address(RVA = "0x20DF980", Offset = "0x20DFA81", VA = "0x20DF980")]
	public ConcaveCollider()
	{
	}

	// Token: 0x0400ABCF RID: 43983
	[Token(Token = "0x400819E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConcaveCollider.EAlgorithm Algorithm;

	// Token: 0x0400ABD0 RID: 43984
	[Token(Token = "0x400819F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int MaxHullVertices;

	// Token: 0x0400ABD1 RID: 43985
	[Token(Token = "0x40081A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MaxHulls;

	// Token: 0x0400ABD2 RID: 43986
	[Token(Token = "0x40081A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float InternalScale;

	// Token: 0x0400ABD3 RID: 43987
	[Token(Token = "0x40081A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float Precision;

	// Token: 0x0400ABD4 RID: 43988
	[Token(Token = "0x40081A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool CreateMeshAssets;

	// Token: 0x0400ABD5 RID: 43989
	[Token(Token = "0x40081A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool CreateHullMesh;

	// Token: 0x0400ABD6 RID: 43990
	[Token(Token = "0x40081A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool DebugLog;

	// Token: 0x0400ABD7 RID: 43991
	[Token(Token = "0x40081A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int LegacyDepth;

	// Token: 0x0400ABD8 RID: 43992
	[Token(Token = "0x40081A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool ShowAdvancedOptions;

	// Token: 0x0400ABD9 RID: 43993
	[Token(Token = "0x40081A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float MinHullVolume;

	// Token: 0x0400ABDA RID: 43994
	[Token(Token = "0x40081A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float BackFaceDistanceFactor;

	// Token: 0x0400ABDB RID: 43995
	[Token(Token = "0x40081AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool NormalizeInputMesh;

	// Token: 0x0400ABDC RID: 43996
	[Token(Token = "0x40081AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool ForceNoMultithreading;

	// Token: 0x0400ABDD RID: 43997
	[Token(Token = "0x40081AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PhysicMaterial PhysMaterial;

	// Token: 0x0400ABDE RID: 43998
	[Token(Token = "0x40081AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool IsTrigger;

	// Token: 0x0400ABDF RID: 43999
	[Token(Token = "0x40081AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject[] m_aGoHulls;

	// Token: 0x0400ABE0 RID: 44000
	[Token(Token = "0x40081AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PhysicMaterial LastMaterial;

	// Token: 0x0400ABE1 RID: 44001
	[Token(Token = "0x40081B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool LastIsTrigger;

	// Token: 0x0400ABE2 RID: 44002
	[Token(Token = "0x40081B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int LargestHullVertices;

	// Token: 0x0400ABE3 RID: 44003
	[Token(Token = "0x40081B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int LargestHullFaces;

	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2001350")]
	public enum EAlgorithm
	{
		// Token: 0x0400ABE5 RID: 44005
		[Token(Token = "0x401B693")]
		Normal,
		// Token: 0x0400ABE6 RID: 44006
		[Token(Token = "0x401B694")]
		Fast,
		// Token: 0x0400ABE7 RID: 44007
		[Token(Token = "0x401B695")]
		Legacy
	}

	// Token: 0x02000B6E RID: 2926
	// (Invoke) Token: 0x06004B47 RID: 19271
	[Token(Token = "0x2001351")]
	public delegate void LogDelegate(string message);

	// Token: 0x02000B6F RID: 2927
	// (Invoke) Token: 0x06004B4B RID: 19275
	[Token(Token = "0x2001352")]
	public delegate void ProgressDelegate(string message, float fPercent);

	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2001353")]
	private struct SConvexDecompositionInfoInOut
	{
		// Token: 0x0400ABE8 RID: 44008
		[Token(Token = "0x401B696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint uMaxHullVertices;

		// Token: 0x0400ABE9 RID: 44009
		[Token(Token = "0x401B697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint uMaxHulls;

		// Token: 0x0400ABEA RID: 44010
		[Token(Token = "0x401B698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fPrecision;

		// Token: 0x0400ABEB RID: 44011
		[Token(Token = "0x401B699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float fBackFaceDistanceFactor;

		// Token: 0x0400ABEC RID: 44012
		[Token(Token = "0x401B69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint uLegacyDepth;

		// Token: 0x0400ABED RID: 44013
		[Token(Token = "0x401B69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint uNormalizeInputMesh;

		// Token: 0x0400ABEE RID: 44014
		[Token(Token = "0x401B69C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint uUseFastVersion;

		// Token: 0x0400ABEF RID: 44015
		[Token(Token = "0x401B69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint uTriangleCount;

		// Token: 0x0400ABF0 RID: 44016
		[Token(Token = "0x401B69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint uVertexCount;

		// Token: 0x0400ABF1 RID: 44017
		[Token(Token = "0x401B69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int nHullsOut;
	}

	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2001354")]
	private struct SConvexDecompositionHullInfo
	{
		// Token: 0x0400ABF2 RID: 44018
		[Token(Token = "0x401B6A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nVertexCount;

		// Token: 0x0400ABF3 RID: 44019
		[Token(Token = "0x401B6A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nTriangleCount;
	}
}
