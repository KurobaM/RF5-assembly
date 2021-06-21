using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D6D RID: 3437
	[Token(Token = "0x20008D1")]
	public class HandPoser : Poser
	{
		// Token: 0x06005931 RID: 22833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x2C0EF90", Offset = "0x2C0F091", VA = "0x2C0EF90", Slot = "7")]
		public override void AutoMapping()
		{
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x2C0F060", Offset = "0x2C0F161", VA = "0x2C0F060", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F5")]
		[Address(RVA = "0x2C0F250", Offset = "0x2C0F351", VA = "0x2C0F250", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x2C0F350", Offset = "0x2C0F451", VA = "0x2C0F350", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F7")]
		[Address(RVA = "0x2C0F0D0", Offset = "0x2C0F1D1", VA = "0x2C0F0D0")]
		protected void StoreDefaultState()
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x2C0F700", Offset = "0x2C0F801", VA = "0x2C0F700")]
		public HandPoser()
		{
		}

		// Token: 0x0400B873 RID: 47219
		[Token(Token = "0x4008A1A")]
		[FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		// Token: 0x0400B874 RID: 47220
		[Token(Token = "0x4008A1B")]
		[FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		// Token: 0x0400B875 RID: 47221
		[Token(Token = "0x4008A1C")]
		[FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		// Token: 0x0400B876 RID: 47222
		[Token(Token = "0x4008A1D")]
		[FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		// Token: 0x0400B877 RID: 47223
		[Token(Token = "0x4008A1E")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;
	}
}
