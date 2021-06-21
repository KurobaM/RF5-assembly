using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC6 RID: 3270
	[Token(Token = "0x2000867")]
	[Attribute(Name = "RequireComponent", RVA = "0x147AA0", Offset = "0x147BA1")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		// Token: 0x060053F1 RID: 21489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x29B71D0", Offset = "0x29B72D1", VA = "0x29B71D0")]
		private void Awake()
		{
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x29B7230", Offset = "0x29B7331", VA = "0x29B7230")]
		private void OnGUI()
		{
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x29B7540", Offset = "0x29B7641", VA = "0x29B7540")]
		public InteractionSystemTestGUI()
		{
		}

		// Token: 0x0400B303 RID: 45827
		[Token(Token = "0x4008677")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177C40", Offset = "0x177D41")]
		public InteractionObject interactionObject;

		// Token: 0x0400B304 RID: 45828
		[Token(Token = "0x4008678")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177C80", Offset = "0x177D81")]
		public FullBodyBipedEffector[] effectors;

		// Token: 0x0400B305 RID: 45829
		[Token(Token = "0x4008679")]
		[FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;
	}
}
