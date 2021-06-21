using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000876")]
	public class TwoHandedProp : MonoBehaviour
	{
		// Token: 0x0600544A RID: 21578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x2865060", Offset = "0x2865161", VA = "0x2865060")]
		private void Start()
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463D")]
		[Address(RVA = "0x2865240", Offset = "0x2865341", VA = "0x2865240")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463E")]
		[Address(RVA = "0x28654E0", Offset = "0x28655E1", VA = "0x28654E0")]
		private void AfterFBBIK()
		{
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463F")]
		[Address(RVA = "0x28655B0", Offset = "0x28656B1", VA = "0x28655B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004640")]
		[Address(RVA = "0x28656D0", Offset = "0x28657D1", VA = "0x28656D0")]
		public TwoHandedProp()
		{
		}

		// Token: 0x0400B378 RID: 45944
		[Token(Token = "0x40086BB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177FA0", Offset = "0x1780A1")]
		public Transform leftHandTarget;

		// Token: 0x0400B379 RID: 45945
		[Token(Token = "0x40086BC")]
		[FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		// Token: 0x0400B37A RID: 45946
		[Token(Token = "0x40086BD")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		// Token: 0x0400B37B RID: 45947
		[Token(Token = "0x40086BE")]
		[FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;
	}
}
