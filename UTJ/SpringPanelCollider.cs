using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x20007DC")]
	public class SpringPanelCollider : MonoBehaviour
	{
		// Token: 0x06004D43 RID: 19779 RVA: 0x00018960 File Offset: 0x00016B60
		[Token(Token = "0x60040CE")]
		[Address(RVA = "0x23B1DF0", Offset = "0x23B1EF1", VA = "0x23B1DF0")]
		public Vector3 GetPlaneNormal()
		{
			return default(Vector3);
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00018978 File Offset: 0x00016B78
		[Token(Token = "0x60040CF")]
		[Address(RVA = "0x23B1E20", Offset = "0x23B1F21", VA = "0x23B1E20")]
		public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, float length, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00018990 File Offset: 0x00016B90
		[Token(Token = "0x60040D0")]
		[Address(RVA = "0x23B2390", Offset = "0x23B2491", VA = "0x23B2390")]
		public static SpringBone.CollisionStatus CheckForCollisionWithAlignedPlaneAndReact(Vector3 localHeadPosition, float localLength, ref Vector3 localTailPosition, float localTailRadius, SpringPanelCollider.Axis upAxis)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D1")]
		[Address(RVA = "0x23B26A0", Offset = "0x23B27A1", VA = "0x23B26A0")]
		public SpringPanelCollider()
		{
		}

		// Token: 0x0400AED1 RID: 44753
		[Token(Token = "0x40083E5")]
		[FieldOffset(Offset = "0x18")]
		public float width;

		// Token: 0x0400AED2 RID: 44754
		[Token(Token = "0x40083E6")]
		[FieldOffset(Offset = "0x1C")]
		public float height;

		// Token: 0x0400AED3 RID: 44755
		[Token(Token = "0x40083E7")]
		[FieldOffset(Offset = "0x20")]
		public Renderer linkedRenderer;

		// Token: 0x02000BD0 RID: 3024
		[Token(Token = "0x2001373")]
		public enum Axis
		{
			// Token: 0x0400AED5 RID: 44757
			[Token(Token = "0x401B746")]
			X,
			// Token: 0x0400AED6 RID: 44758
			[Token(Token = "0x401B747")]
			Y,
			// Token: 0x0400AED7 RID: 44759
			[Token(Token = "0x401B748")]
			Z,
			// Token: 0x0400AED8 RID: 44760
			[Token(Token = "0x401B749")]
			AxisCount
		}
	}
}
