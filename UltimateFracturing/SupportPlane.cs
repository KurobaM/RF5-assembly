using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UltimateFracturing
{
	// Token: 0x02000C56 RID: 3158
	[Token(Token = "0x2000807")]
	[Serializable]
	public class SupportPlane
	{
		// Token: 0x06004FFB RID: 20475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x20FA8D0", Offset = "0x20FA9D1", VA = "0x20FA8D0")]
		public SupportPlane(FracturedObject fracturedObject)
		{
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x20FB130", Offset = "0x20FB231", VA = "0x20FB130")]
		public Matrix4x4 GetLocalMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x20FB210", Offset = "0x20FB311", VA = "0x20FB210")]
		public Vector3[] GetBoundingBoxSegments(Bounds bounds)
		{
			return null;
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x600422F")]
		[Address(RVA = "0x20FB820", Offset = "0x20FB921", VA = "0x20FB820")]
		public bool IntersectsWith(GameObject otherGameObject, bool bBelowIsAlsoValid = false)
		{
			return default(bool);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x6004230")]
		[Address(RVA = "0x20FC2C0", Offset = "0x20FC3C1", VA = "0x20FC2C0")]
		private static bool TestSegmentVsPlane(Vector3 v1, Vector3 v2, Plane plane, Matrix4x4 mtxToPlaneLocal, float fLimitRight, float fLimitUp, float fLimitForward)
		{
			return default(bool);
		}

		// Token: 0x0400B0C6 RID: 45254
		[Token(Token = "0x4008486")]
		[FieldOffset(Offset = "0x10")]
		public bool GUIExpanded;

		// Token: 0x0400B0C7 RID: 45255
		[Token(Token = "0x4008487")]
		[FieldOffset(Offset = "0x18")]
		public string GUIName;

		// Token: 0x0400B0C8 RID: 45256
		[Token(Token = "0x4008488")]
		[FieldOffset(Offset = "0x20")]
		public bool GUIShowInScene;

		// Token: 0x0400B0C9 RID: 45257
		[Token(Token = "0x4008489")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 v3PlanePosition;

		// Token: 0x0400B0CA RID: 45258
		[Token(Token = "0x400848A")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion qPlaneRotation;

		// Token: 0x0400B0CB RID: 45259
		[Token(Token = "0x400848B")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 v3PlaneScale;

		// Token: 0x0400B0CC RID: 45260
		[Token(Token = "0x400848C")]
		[FieldOffset(Offset = "0x50")]
		public Mesh planeMesh;

		// Token: 0x0400B0CD RID: 45261
		[Token(Token = "0x400848D")]
		[FieldOffset(Offset = "0x58")]
		public FracturedObject fracturedObject;
	}
}
