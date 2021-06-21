using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC4 RID: 3268
	[Token(Token = "0x2000865")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		// Token: 0x060053EC RID: 21484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x29B6820", Offset = "0x29B6921", VA = "0x29B6820")]
		private void OnGUI()
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x29B6970", Offset = "0x29B6A71", VA = "0x29B6970")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004600")]
		[Address(RVA = "0x29B6AC0", Offset = "0x29B6BC1", VA = "0x29B6AC0")]
		public InteractionC2CDemo()
		{
		}

		// Token: 0x0400B2F7 RID: 45815
		[Token(Token = "0x400866B")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		// Token: 0x0400B2F8 RID: 45816
		[Token(Token = "0x400866C")]
		[FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		// Token: 0x0400B2F9 RID: 45817
		[Token(Token = "0x400866D")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;
	}
}
