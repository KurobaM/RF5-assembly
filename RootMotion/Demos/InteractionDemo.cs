using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000866")]
	public class InteractionDemo : MonoBehaviour
	{
		// Token: 0x060053EF RID: 21487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x29B6AD0", Offset = "0x29B6BD1", VA = "0x29B6AD0")]
		private void OnGUI()
		{
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x29B71C0", Offset = "0x29B72C1", VA = "0x29B71C0")]
		public InteractionDemo()
		{
		}

		// Token: 0x0400B2FA RID: 45818
		[Token(Token = "0x400866E")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		// Token: 0x0400B2FB RID: 45819
		[Token(Token = "0x400866F")]
		[FieldOffset(Offset = "0x20")]
		public bool interrupt;

		// Token: 0x0400B2FC RID: 45820
		[Token(Token = "0x4008670")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		// Token: 0x0400B2FD RID: 45821
		[Token(Token = "0x4008671")]
		[FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		// Token: 0x0400B2FE RID: 45822
		[Token(Token = "0x4008672")]
		[FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		// Token: 0x0400B2FF RID: 45823
		[Token(Token = "0x4008673")]
		[FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		// Token: 0x0400B300 RID: 45824
		[Token(Token = "0x4008674")]
		[FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		// Token: 0x0400B301 RID: 45825
		[Token(Token = "0x4008675")]
		[FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		// Token: 0x0400B302 RID: 45826
		[Token(Token = "0x4008676")]
		[FieldOffset(Offset = "0x58")]
		private bool isSitting;
	}
}
