using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC2 RID: 3266
	[Token(Token = "0x2000863")]
	public class HitReactionTrigger : MonoBehaviour
	{
		// Token: 0x060053E6 RID: 21478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x29B5B30", Offset = "0x29B5C31", VA = "0x29B5B30")]
		private void Update()
		{
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x29B5D00", Offset = "0x29B5E01", VA = "0x29B5D00")]
		private void OnGUI()
		{
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x29B5EE0", Offset = "0x29B5FE1", VA = "0x29B5EE0")]
		public HitReactionTrigger()
		{
		}

		// Token: 0x0400B2EC RID: 45804
		[Token(Token = "0x4008660")]
		[FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		// Token: 0x0400B2ED RID: 45805
		[Token(Token = "0x4008661")]
		[FieldOffset(Offset = "0x20")]
		public float hitForce;

		// Token: 0x0400B2EE RID: 45806
		[Token(Token = "0x4008662")]
		[FieldOffset(Offset = "0x28")]
		private string colliderName;
	}
}
