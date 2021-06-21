using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x20007DD")]
	public class SpringSphereCollider : MonoBehaviour
	{
		// Token: 0x06004D47 RID: 19783 RVA: 0x000189A8 File Offset: 0x00016BA8
		[Token(Token = "0x60040D2")]
		[Address(RVA = "0x23B2D30", Offset = "0x23B2E31", VA = "0x23B2D30")]
		public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x000189C0 File Offset: 0x00016BC0
		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x23B2F00", Offset = "0x23B3001", VA = "0x23B2F00")]
		public static SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 localHeadPosition, ref Vector3 localTailPosition, float localTailRadius, Vector3 sphereLocalOrigin, float sphereRadius)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x000189D8 File Offset: 0x00016BD8
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x23A8AD0", Offset = "0x23A8BD1", VA = "0x23A8AD0")]
		public static bool ComputeIntersection(Vector3 originA, float radiusA, Vector3 originB, float radiusB, ref Circle3 intersection)
		{
			return default(bool);
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x000189F0 File Offset: 0x00016BF0
		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x23A8D20", Offset = "0x23A8E21", VA = "0x23A8D20")]
		public static Vector3 ComputeNewTailPosition(Circle3 intersection, Vector3 tailPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040D6")]
		[Address(RVA = "0x23B31C0", Offset = "0x23B32C1", VA = "0x23B31C0")]
		public SpringSphereCollider()
		{
		}

		// Token: 0x0400AED9 RID: 44761
		[Token(Token = "0x40083E8")]
		[FieldOffset(Offset = "0x18")]
		public float radius;

		// Token: 0x0400AEDA RID: 44762
		[Token(Token = "0x40083E9")]
		[FieldOffset(Offset = "0x20")]
		public Renderer linkedRenderer;
	}
}
