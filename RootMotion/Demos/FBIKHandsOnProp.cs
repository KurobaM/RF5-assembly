using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CBF RID: 3263
	[Token(Token = "0x2000860")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		// Token: 0x060053D6 RID: 21462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E8")]
		[Address(RVA = "0x29B3AC0", Offset = "0x29B3BC1", VA = "0x29B3AC0")]
		private void Awake()
		{
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E9")]
		[Address(RVA = "0x29B3B90", Offset = "0x29B3C91", VA = "0x29B3B90")]
		private void OnPreRead()
		{
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EA")]
		[Address(RVA = "0x29B3C20", Offset = "0x29B3D21", VA = "0x29B3C20")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EB")]
		[Address(RVA = "0x29B4140", Offset = "0x29B4241", VA = "0x29B4140")]
		private void OnDestroy()
		{
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x29B4260", Offset = "0x29B4361", VA = "0x29B4260")]
		public FBIKHandsOnProp()
		{
		}

		// Token: 0x0400B2D5 RID: 45781
		[Token(Token = "0x4008649")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B2D6 RID: 45782
		[Token(Token = "0x400864A")]
		[FieldOffset(Offset = "0x20")]
		public bool leftHanded;
	}
}
