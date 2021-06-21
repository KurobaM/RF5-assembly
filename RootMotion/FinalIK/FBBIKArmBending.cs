using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D26 RID: 3366
	[Token(Token = "0x20008B0")]
	public class FBBIKArmBending : MonoBehaviour
	{
		// Token: 0x06005644 RID: 22084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x2873110", Offset = "0x2873211", VA = "0x2873110")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F1")]
		[Address(RVA = "0x2873690", Offset = "0x2873791", VA = "0x2873690")]
		private void OnPostFBBIK()
		{
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x2873850", Offset = "0x2873951", VA = "0x2873850")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x2873970", Offset = "0x2873A71", VA = "0x2873970")]
		public FBBIKArmBending()
		{
		}

		// Token: 0x0400B58B RID: 46475
		[Token(Token = "0x400886D")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B58C RID: 46476
		[Token(Token = "0x400886E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		// Token: 0x0400B58D RID: 46477
		[Token(Token = "0x400886F")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		// Token: 0x0400B58E RID: 46478
		[Token(Token = "0x4008870")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		// Token: 0x0400B58F RID: 46479
		[Token(Token = "0x4008871")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		// Token: 0x0400B590 RID: 46480
		[Token(Token = "0x4008872")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		// Token: 0x0400B591 RID: 46481
		[Token(Token = "0x4008873")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		// Token: 0x0400B592 RID: 46482
		[Token(Token = "0x4008874")]
		[FieldOffset(Offset = "0x70")]
		private bool initiated;
	}
}
