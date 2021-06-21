using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B98 RID: 2968
[Token(Token = "0x20007B6")]
public static class RopePersistManager
{
	// Token: 0x06004C19 RID: 19481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003FCC")]
	[Address(RVA = "0x27DC090", Offset = "0x27DC191", VA = "0x27DC090")]
	private static RopePersistManager.RopeData.TransformInfo ComputeTransformInfo(UltimateRope rope, GameObject node, GameObject parent)
	{
		return null;
	}

	// Token: 0x06004C1A RID: 19482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FCD")]
	[Address(RVA = "0x27DC3F0", Offset = "0x27DC4F1", VA = "0x27DC3F0")]
	private static void SetTransformInfo(RopePersistManager.RopeData.TransformInfo transformInfo, GameObject node)
	{
	}

	// Token: 0x0400AD1A RID: 44314
	[Token(Token = "0x4008298")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, RopePersistManager.RopeData> s_hashInstanceID2RopeData;

	// Token: 0x02000B99 RID: 2969
	[Token(Token = "0x2001363")]
	private class RopeData
	{
		// Token: 0x06004C1B RID: 19483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007730")]
		[Address(RVA = "0x27DC5C0", Offset = "0x27DC6C1", VA = "0x27DC5C0")]
		public RopeData(UltimateRope rope)
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007731")]
		[Address(RVA = "0x27DC9A0", Offset = "0x27DCAA1", VA = "0x27DC9A0")]
		public static void MakeSkinDeepCopy(Vector3[] av3VerticesSource, Vector2[] av2MappingSource, Vector4[] av4TangentsSource, BoneWeight[] aBoneWeightsSource, int[] anTrianglesRopeSource, int[] anTrianglesSectionsSource, Matrix4x4[] aBindPosesSource, Vector3[] av3VerticesDestiny, Vector2[] av2MappingDestiny, Vector4[] av4TangentsDestiny, BoneWeight[] aBoneWeightsDestiny, int[] anTrianglesRopeDestiny, int[] anTrianglesSectionsDestiny, Matrix4x4[] aBindPosesDestiny)
		{
		}

		// Token: 0x0400AD1B RID: 44315
		[Token(Token = "0x401B6E3")]
		[FieldOffset(Offset = "0x10")]
		public UltimateRope m_rope;

		// Token: 0x0400AD1C RID: 44316
		[Token(Token = "0x401B6E4")]
		[FieldOffset(Offset = "0x18")]
		public bool m_bDeleted;

		// Token: 0x0400AD1D RID: 44317
		[Token(Token = "0x401B6E5")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> m_hashFieldName2Value;

		// Token: 0x0400AD1E RID: 44318
		[Token(Token = "0x401B6E6")]
		[FieldOffset(Offset = "0x28")]
		public bool m_bSkin;

		// Token: 0x0400AD1F RID: 44319
		[Token(Token = "0x401B6E7")]
		[FieldOffset(Offset = "0x30")]
		public Vector3[] m_av3SkinVertices;

		// Token: 0x0400AD20 RID: 44320
		[Token(Token = "0x401B6E8")]
		[FieldOffset(Offset = "0x38")]
		public Vector2[] m_av2SkinMapping;

		// Token: 0x0400AD21 RID: 44321
		[Token(Token = "0x401B6E9")]
		[FieldOffset(Offset = "0x40")]
		public Vector4[] m_av4SkinTangents;

		// Token: 0x0400AD22 RID: 44322
		[Token(Token = "0x401B6EA")]
		[FieldOffset(Offset = "0x48")]
		public BoneWeight[] m_aSkinBoneWeights;

		// Token: 0x0400AD23 RID: 44323
		[Token(Token = "0x401B6EB")]
		[FieldOffset(Offset = "0x50")]
		public int[] m_anSkinTrianglesRope;

		// Token: 0x0400AD24 RID: 44324
		[Token(Token = "0x401B6EC")]
		[FieldOffset(Offset = "0x58")]
		public int[] m_anSkinTrianglesSections;

		// Token: 0x0400AD25 RID: 44325
		[Token(Token = "0x401B6ED")]
		[FieldOffset(Offset = "0x60")]
		public Matrix4x4[] m_amtxSkinBindPoses;

		// Token: 0x0400AD26 RID: 44326
		[Token(Token = "0x401B6EE")]
		[FieldOffset(Offset = "0x68")]
		public RopePersistManager.RopeData.TransformInfo m_transformInfoRope;

		// Token: 0x0400AD27 RID: 44327
		[Token(Token = "0x401B6EF")]
		[FieldOffset(Offset = "0x70")]
		public RopePersistManager.RopeData.TransformInfo[] m_aLinkTransformInfo;

		// Token: 0x0400AD28 RID: 44328
		[Token(Token = "0x401B6F0")]
		[FieldOffset(Offset = "0x78")]
		public RopePersistManager.RopeData.TransformInfo m_transformInfoStart;

		// Token: 0x0400AD29 RID: 44329
		[Token(Token = "0x401B6F1")]
		[FieldOffset(Offset = "0x80")]
		public RopePersistManager.RopeData.TransformInfo[] m_transformInfoSegments;

		// Token: 0x0400AD2A RID: 44330
		[Token(Token = "0x401B6F2")]
		[FieldOffset(Offset = "0x88")]
		public bool[][] m_aaJointsProcessed;

		// Token: 0x0400AD2B RID: 44331
		[Token(Token = "0x401B6F3")]
		[FieldOffset(Offset = "0x90")]
		public bool[][] m_aaJointsBroken;

		// Token: 0x02000B9A RID: 2970
		[Token(Token = "0x2001652")]
		public class TransformInfo
		{
			// Token: 0x06004C1D RID: 19485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60080A4")]
			[Address(RVA = "0x27DC3E0", Offset = "0x27DC4E1", VA = "0x27DC3E0")]
			public TransformInfo()
			{
			}

			// Token: 0x0400AD2C RID: 44332
			[Token(Token = "0x401C402")]
			[FieldOffset(Offset = "0x10")]
			public GameObject goObject;

			// Token: 0x0400AD2D RID: 44333
			[Token(Token = "0x401C403")]
			[FieldOffset(Offset = "0x18")]
			public string strObjectName;

			// Token: 0x0400AD2E RID: 44334
			[Token(Token = "0x401C404")]
			[FieldOffset(Offset = "0x20")]
			public Transform tfParent;

			// Token: 0x0400AD2F RID: 44335
			[Token(Token = "0x401C405")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 v3LocalPosition;

			// Token: 0x0400AD30 RID: 44336
			[Token(Token = "0x401C406")]
			[FieldOffset(Offset = "0x34")]
			public Quaternion qLocalOrientation;

			// Token: 0x0400AD31 RID: 44337
			[Token(Token = "0x401C407")]
			[FieldOffset(Offset = "0x44")]
			public Vector3 v3LocalScale;

			// Token: 0x0400AD32 RID: 44338
			[Token(Token = "0x401C408")]
			[FieldOffset(Offset = "0x50")]
			public bool bLinkMarkedKinematic;

			// Token: 0x0400AD33 RID: 44339
			[Token(Token = "0x401C409")]
			[FieldOffset(Offset = "0x51")]
			public bool bExtensibleKinematic;
		}
	}
}
