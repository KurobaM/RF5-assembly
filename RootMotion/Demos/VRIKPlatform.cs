using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x200087E")]
	public class VRIKPlatform : MonoBehaviour
	{
		// Token: 0x0600546D RID: 21613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x28663E0", Offset = "0x28664E1", VA = "0x28663E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x2866440", Offset = "0x2866541", VA = "0x2866440")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004659")]
		[Address(RVA = "0x2866660", Offset = "0x2866761", VA = "0x2866660")]
		public VRIKPlatform()
		{
		}

		// Token: 0x0400B3A2 RID: 45986
		[Token(Token = "0x40086E0")]
		[FieldOffset(Offset = "0x18")]
		public VRIK ik;

		// Token: 0x0400B3A3 RID: 45987
		[Token(Token = "0x40086E1")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		// Token: 0x0400B3A4 RID: 45988
		[Token(Token = "0x40086E2")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;
	}
}
