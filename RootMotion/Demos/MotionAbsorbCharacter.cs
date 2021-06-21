using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CCC RID: 3276
	[Token(Token = "0x200086A")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		// Token: 0x06005407 RID: 21511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460F")]
		[Address(RVA = "0x29BB3E0", Offset = "0x29BB4E1", VA = "0x29BB3E0")]
		private void Start()
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004610")]
		[Address(RVA = "0x29BB460", Offset = "0x29BB561", VA = "0x29BB460")]
		private void Update()
		{
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004611")]
		[Address(RVA = "0x29BB520", Offset = "0x29BB621", VA = "0x29BB520")]
		private void SwingStart()
		{
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004612")]
		[Address(RVA = "0x29BB680", Offset = "0x29BB781", VA = "0x29BB680")]
		public MotionAbsorbCharacter()
		{
		}

		// Token: 0x0400B324 RID: 45860
		[Token(Token = "0x4008685")]
		[FieldOffset(Offset = "0x18")]
		public Animator animator;

		// Token: 0x0400B325 RID: 45861
		[Token(Token = "0x4008686")]
		[FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		// Token: 0x0400B326 RID: 45862
		[Token(Token = "0x4008687")]
		[FieldOffset(Offset = "0x28")]
		public Transform cube;

		// Token: 0x0400B327 RID: 45863
		[Token(Token = "0x4008688")]
		[FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		// Token: 0x0400B328 RID: 45864
		[Token(Token = "0x4008689")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		// Token: 0x0400B329 RID: 45865
		[Token(Token = "0x400868A")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		// Token: 0x0400B32A RID: 45866
		[Token(Token = "0x400868B")]
		[FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		// Token: 0x0400B32B RID: 45867
		[Token(Token = "0x400868C")]
		[FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;
	}
}
