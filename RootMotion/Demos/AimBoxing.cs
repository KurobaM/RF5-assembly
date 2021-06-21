using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x200084C")]
	public class AimBoxing : MonoBehaviour
	{
		// Token: 0x0600537C RID: 21372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x29AB250", Offset = "0x29AB351", VA = "0x29AB250")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004597")]
		[Address(RVA = "0x29AB2E0", Offset = "0x29AB3E1", VA = "0x29AB2E0")]
		public AimBoxing()
		{
		}

		// Token: 0x0400B225 RID: 45605
		[Token(Token = "0x40085AA")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		// Token: 0x0400B226 RID: 45606
		[Token(Token = "0x40085AB")]
		[FieldOffset(Offset = "0x20")]
		public Transform pin;
	}
}
