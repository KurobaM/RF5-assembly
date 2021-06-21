using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x200084E")]
	public class SecondHandOnGun : MonoBehaviour
	{
		// Token: 0x06005380 RID: 21376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459A")]
		[Address(RVA = "0x2861AD0", Offset = "0x2861BD1", VA = "0x2861AD0")]
		private void Start()
		{
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x2861B20", Offset = "0x2861C21", VA = "0x2861B20")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x2861D80", Offset = "0x2861E81", VA = "0x2861D80")]
		public SecondHandOnGun()
		{
		}

		// Token: 0x0400B229 RID: 45609
		[Token(Token = "0x40085AE")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aim;

		// Token: 0x0400B22A RID: 45610
		[Token(Token = "0x40085AF")]
		[FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		// Token: 0x0400B22B RID: 45611
		[Token(Token = "0x40085B0")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		// Token: 0x0400B22C RID: 45612
		[Token(Token = "0x40085B1")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		// Token: 0x0400B22D RID: 45613
		[Token(Token = "0x40085B2")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		// Token: 0x0400B22E RID: 45614
		[Token(Token = "0x40085B3")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		// Token: 0x0400B22F RID: 45615
		[Token(Token = "0x40085B4")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		// Token: 0x0400B230 RID: 45616
		[Token(Token = "0x40085B5")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;
	}
}
