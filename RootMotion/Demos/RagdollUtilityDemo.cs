using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000870")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		// Token: 0x06005420 RID: 21536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004627")]
		[Address(RVA = "0x28611B0", Offset = "0x28612B1", VA = "0x28611B0")]
		private void OnGUI()
		{
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x28612A0", Offset = "0x28613A1", VA = "0x28612A0")]
		private void Update()
		{
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x2861450", Offset = "0x2861551", VA = "0x2861450")]
		public RagdollUtilityDemo()
		{
		}

		// Token: 0x0400B34B RID: 45899
		[Token(Token = "0x40086A9")]
		[FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		// Token: 0x0400B34C RID: 45900
		[Token(Token = "0x40086AA")]
		[FieldOffset(Offset = "0x20")]
		public Transform root;

		// Token: 0x0400B34D RID: 45901
		[Token(Token = "0x40086AB")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;
	}
}
