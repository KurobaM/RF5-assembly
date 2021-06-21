using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000882")]
	[Attribute(Name = "RequireComponent", RVA = "0x147CD0", Offset = "0x147DD1")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		// Token: 0x0600547E RID: 21630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004668")]
		[Address(RVA = "0x29ADEC0", Offset = "0x29ADFC1", VA = "0x29ADEC0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0001BD20 File Offset: 0x00019F20
		[Token(Token = "0x6004669")]
		[Address(RVA = "0x29ADF50", Offset = "0x29AE051", VA = "0x29ADF50", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x0001BD38 File Offset: 0x00019F38
		[Token(Token = "0x1700089C")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600466A")]
			[Address(RVA = "0x29ADF70", Offset = "0x29AE071", VA = "0x29ADF70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466B")]
		[Address(RVA = "0x29AE070", Offset = "0x29AE171", VA = "0x29AE070", Slot = "9")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466C")]
		[Address(RVA = "0x29AE430", Offset = "0x29AE531", VA = "0x29AE430")]
		private void OnAnimatorMove()
		{
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x29AE5F0", Offset = "0x29AE6F1", VA = "0x29AE5F0")]
		public CharacterAnimationThirdPerson()
		{
		}

		// Token: 0x0400B3B7 RID: 46007
		[Token(Token = "0x40086F5")]
		[FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		// Token: 0x0400B3B8 RID: 46008
		[Token(Token = "0x40086F6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		// Token: 0x0400B3B9 RID: 46009
		[Token(Token = "0x40086F7")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		// Token: 0x0400B3BA RID: 46010
		[Token(Token = "0x40086F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		// Token: 0x0400B3BB RID: 46011
		[Token(Token = "0x40086F9")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178270", Offset = "0x178371")]
		[SerializeField]
		private float animSpeedMultiplier;

		// Token: 0x0400B3BC RID: 46012
		[Token(Token = "0x40086FA")]
		[FieldOffset(Offset = "0x78")]
		protected Animator animator;

		// Token: 0x0400B3BD RID: 46013
		[Token(Token = "0x40086FB")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		// Token: 0x0400B3BE RID: 46014
		[Token(Token = "0x40086FC")]
		private const string groundedDirectional = "Grounded Directional";

		// Token: 0x0400B3BF RID: 46015
		[Token(Token = "0x40086FD")]
		private const string groundedStrafe = "Grounded Strafe";

		// Token: 0x0400B3C0 RID: 46016
		[Token(Token = "0x40086FE")]
		[FieldOffset(Offset = "0x8C")]
		private float deltaAngle;
	}
}
