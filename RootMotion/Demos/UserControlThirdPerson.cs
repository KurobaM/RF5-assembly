using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CF3 RID: 3315
	[Token(Token = "0x2000887")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		// Token: 0x060054B5 RID: 21685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004699")]
		[Address(RVA = "0x2865750", Offset = "0x2865851", VA = "0x2865750", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469A")]
		[Address(RVA = "0x2865BC0", Offset = "0x2865CC1", VA = "0x2865BC0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469B")]
		[Address(RVA = "0x2865A90", Offset = "0x2865B91", VA = "0x2865A90")]
		public UserControlThirdPerson()
		{
		}

		// Token: 0x0400B42B RID: 46123
		[Token(Token = "0x4008756")]
		[FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		// Token: 0x0400B42C RID: 46124
		[Token(Token = "0x4008757")]
		[FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		// Token: 0x0400B42D RID: 46125
		[Token(Token = "0x4008758")]
		[FieldOffset(Offset = "0x1A")]
		public bool canJump;

		// Token: 0x0400B42E RID: 46126
		[Token(Token = "0x4008759")]
		[FieldOffset(Offset = "0x1C")]
		public UserControlThirdPerson.State state;

		// Token: 0x0400B42F RID: 46127
		[Token(Token = "0x400875A")]
		[FieldOffset(Offset = "0x40")]
		protected Transform cam;

		// Token: 0x02000CF4 RID: 3316
		[Token(Token = "0x20013E5")]
		public struct State
		{
			// Token: 0x0400B430 RID: 46128
			[Token(Token = "0x401B919")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 move;

			// Token: 0x0400B431 RID: 46129
			[Token(Token = "0x401B91A")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			// Token: 0x0400B432 RID: 46130
			[Token(Token = "0x401B91B")]
			[FieldOffset(Offset = "0x18")]
			public bool crouch;

			// Token: 0x0400B433 RID: 46131
			[Token(Token = "0x401B91C")]
			[FieldOffset(Offset = "0x19")]
			public bool jump;

			// Token: 0x0400B434 RID: 46132
			[Token(Token = "0x401B91D")]
			[FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}
	}
}
