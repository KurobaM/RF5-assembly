using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000862")]
	[Attribute(Name = "RequireComponent", RVA = "0x147A10", Offset = "0x147B11")]
	[Attribute(Name = "RequireComponent", RVA = "0x147A10", Offset = "0x147B11")]
	public class FPSCharacter : MonoBehaviour
	{
		// Token: 0x060053E2 RID: 21474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F4")]
		[Address(RVA = "0x29B53F0", Offset = "0x29B54F1", VA = "0x29B53F0")]
		private void Start()
		{
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x29B5480", Offset = "0x29B5581", VA = "0x29B5480")]
		private void Update()
		{
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x29B55A0", Offset = "0x29B56A1", VA = "0x29B55A0")]
		private void OnGUI()
		{
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x29B5650", Offset = "0x29B5751", VA = "0x29B5650")]
		public FPSCharacter()
		{
		}

		// Token: 0x0400B2E8 RID: 45800
		[Token(Token = "0x400865C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177C20", Offset = "0x177D21")]
		public float walkSpeed;

		// Token: 0x0400B2E9 RID: 45801
		[Token(Token = "0x400865D")]
		[FieldOffset(Offset = "0x1C")]
		private float sVel;

		// Token: 0x0400B2EA RID: 45802
		[Token(Token = "0x400865E")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		// Token: 0x0400B2EB RID: 45803
		[Token(Token = "0x400865F")]
		[FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;
	}
}
