using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x200087C")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		// Token: 0x06005468 RID: 21608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004652")]
		[Address(RVA = "0x29B5EF0", Offset = "0x29B5FF1", VA = "0x29B5EF0")]
		private void Update()
		{
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004653")]
		[Address(RVA = "0x29B60C0", Offset = "0x29B61C1", VA = "0x29B60C0")]
		private void OnGUI()
		{
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004654")]
		[Address(RVA = "0x29B62A0", Offset = "0x29B63A1", VA = "0x29B62A0")]
		public HitReactionVRIKTrigger()
		{
		}

		// Token: 0x0400B396 RID: 45974
		[Token(Token = "0x40086D4")]
		[FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		// Token: 0x0400B397 RID: 45975
		[Token(Token = "0x40086D5")]
		[FieldOffset(Offset = "0x20")]
		public float hitForce;

		// Token: 0x0400B398 RID: 45976
		[Token(Token = "0x40086D6")]
		[FieldOffset(Offset = "0x28")]
		private string colliderName;
	}
}
