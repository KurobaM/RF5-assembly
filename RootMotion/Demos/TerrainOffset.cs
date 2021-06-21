using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAB RID: 3243
	[Token(Token = "0x2000850")]
	public class TerrainOffset : MonoBehaviour
	{
		// Token: 0x06005389 RID: 21385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x2863510", Offset = "0x2863611", VA = "0x2863510")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0001BB40 File Offset: 0x00019D40
		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x2863780", Offset = "0x2863881", VA = "0x2863780")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x28639D0", Offset = "0x2863AD1", VA = "0x28639D0")]
		public TerrainOffset()
		{
		}

		// Token: 0x0400B239 RID: 45625
		[Token(Token = "0x40085BE")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		// Token: 0x0400B23A RID: 45626
		[Token(Token = "0x40085BF")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		// Token: 0x0400B23B RID: 45627
		[Token(Token = "0x40085C0")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		// Token: 0x0400B23C RID: 45628
		[Token(Token = "0x40085C1")]
		[FieldOffset(Offset = "0x30")]
		public float min;

		// Token: 0x0400B23D RID: 45629
		[Token(Token = "0x40085C2")]
		[FieldOffset(Offset = "0x34")]
		public float max;

		// Token: 0x0400B23E RID: 45630
		[Token(Token = "0x40085C3")]
		[FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		// Token: 0x0400B23F RID: 45631
		[Token(Token = "0x40085C4")]
		[FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		// Token: 0x0400B240 RID: 45632
		[Token(Token = "0x40085C5")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 offset;
	}
}
