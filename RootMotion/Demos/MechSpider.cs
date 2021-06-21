using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAD RID: 3245
	[Token(Token = "0x2000852")]
	public class MechSpider : MonoBehaviour
	{
		// Token: 0x0600538E RID: 21390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x29B7F00", Offset = "0x29B8001", VA = "0x29B7F00")]
		private void Update()
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x0001BB58 File Offset: 0x00019D58
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x29B8960", Offset = "0x29B8A61", VA = "0x29B8960")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0001BB70 File Offset: 0x00019D70
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x29B8620", Offset = "0x29B8721", VA = "0x29B8620")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x29B8B40", Offset = "0x29B8C41", VA = "0x29B8B40")]
		public MechSpider()
		{
		}

		// Token: 0x0400B254 RID: 45652
		[Token(Token = "0x40085D9")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		// Token: 0x0400B255 RID: 45653
		[Token(Token = "0x40085DA")]
		[FieldOffset(Offset = "0x1C")]
		public float scale;

		// Token: 0x0400B256 RID: 45654
		[Token(Token = "0x40085DB")]
		[FieldOffset(Offset = "0x20")]
		public Transform body;

		// Token: 0x0400B257 RID: 45655
		[Token(Token = "0x40085DC")]
		[FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		// Token: 0x0400B258 RID: 45656
		[Token(Token = "0x40085DD")]
		[FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		// Token: 0x0400B259 RID: 45657
		[Token(Token = "0x40085DE")]
		[FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		// Token: 0x0400B25A RID: 45658
		[Token(Token = "0x40085DF")]
		[FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		// Token: 0x0400B25B RID: 45659
		[Token(Token = "0x40085E0")]
		[FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		// Token: 0x0400B25C RID: 45660
		[Token(Token = "0x40085E1")]
		[FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		// Token: 0x0400B25D RID: 45661
		[Token(Token = "0x40085E2")]
		[FieldOffset(Offset = "0x44")]
		public float height;

		// Token: 0x0400B25E RID: 45662
		[Token(Token = "0x40085E3")]
		[FieldOffset(Offset = "0x48")]
		public float minHeight;

		// Token: 0x0400B25F RID: 45663
		[Token(Token = "0x40085E4")]
		[FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		// Token: 0x0400B260 RID: 45664
		[Token(Token = "0x40085E5")]
		[FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		// Token: 0x0400B261 RID: 45665
		[Token(Token = "0x40085E6")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		// Token: 0x0400B262 RID: 45666
		[Token(Token = "0x40085E7")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		// Token: 0x0400B263 RID: 45667
		[Token(Token = "0x40085E8")]
		[FieldOffset(Offset = "0x6C")]
		private float sine;

		// Token: 0x0400B264 RID: 45668
		[Token(Token = "0x40085E9")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;
	}
}
