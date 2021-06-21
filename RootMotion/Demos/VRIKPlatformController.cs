using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE7 RID: 3303
	[Token(Token = "0x200087F")]
	public class VRIKPlatformController : MonoBehaviour
	{
		// Token: 0x06005470 RID: 21616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465A")]
		[Address(RVA = "0x28666E0", Offset = "0x28667E1", VA = "0x28666E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x2866C40", Offset = "0x2866D41", VA = "0x2866C40")]
		public VRIKPlatformController()
		{
		}

		// Token: 0x0400B3A5 RID: 45989
		[Token(Token = "0x40086E3")]
		[FieldOffset(Offset = "0x18")]
		public VRIK ik;

		// Token: 0x0400B3A6 RID: 45990
		[Token(Token = "0x40086E4")]
		[FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		// Token: 0x0400B3A7 RID: 45991
		[Token(Token = "0x40086E5")]
		[FieldOffset(Offset = "0x28")]
		public Transform platform;

		// Token: 0x0400B3A8 RID: 45992
		[Token(Token = "0x40086E6")]
		[FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		// Token: 0x0400B3A9 RID: 45993
		[Token(Token = "0x40086E7")]
		[FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		// Token: 0x0400B3AA RID: 45994
		[Token(Token = "0x40086E8")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		// Token: 0x0400B3AB RID: 45995
		[Token(Token = "0x40086E9")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;
	}
}
