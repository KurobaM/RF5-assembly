using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x20007DB")]
	public class SpringCapsuleCollider : MonoBehaviour
	{
		// Token: 0x06004D40 RID: 19776 RVA: 0x00018930 File Offset: 0x00016B30
		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x23A84D0", Offset = "0x23A85D1", VA = "0x23A84D0")]
		public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 moverHeadPosition, ref Vector3 moverPosition, float moverRadius, ref Vector3 hitNormal)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00018948 File Offset: 0x00016B48
		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x23A8EC0", Offset = "0x23A8FC1", VA = "0x23A8EC0")]
		private SpringBone.CollisionStatus CheckForCylinderCollisionAndReact(Vector3 localHeadPosition, ref Vector3 worldMoverPosition, float localMoverRadius, Vector3 localSpherePosition, ref Vector3 hitNormal)
		{
			return SpringBone.CollisionStatus.NoCollision;
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x23A90C0", Offset = "0x23A91C1", VA = "0x23A90C0")]
		public SpringCapsuleCollider()
		{
		}

		// Token: 0x0400AECE RID: 44750
		[Token(Token = "0x40083E2")]
		[FieldOffset(Offset = "0x18")]
		public float radius;

		// Token: 0x0400AECF RID: 44751
		[Token(Token = "0x40083E3")]
		[FieldOffset(Offset = "0x1C")]
		public float height;

		// Token: 0x0400AED0 RID: 44752
		[Token(Token = "0x40083E4")]
		[FieldOffset(Offset = "0x20")]
		public Renderer linkedRenderer;
	}
}
