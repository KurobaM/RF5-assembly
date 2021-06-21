using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000857")]
	[Attribute(Name = "RequireComponent", RVA = "0x147830", Offset = "0x147931")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		// Token: 0x060053AE RID: 21422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x29ABB40", Offset = "0x29ABC41", VA = "0x29ABB40", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x29ABBA0", Offset = "0x29ABCA1", VA = "0x29ABBA0")]
		private void OnAnimatorMove()
		{
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x29ABDE0", Offset = "0x29ABEE1", VA = "0x29ABDE0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x29AC040", Offset = "0x29AC141", VA = "0x29AC040")]
		public AnimatorController3rdPerson()
		{
		}

		// Token: 0x0400B293 RID: 45715
		[Token(Token = "0x400860A")]
		[FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		// Token: 0x0400B294 RID: 45716
		[Token(Token = "0x400860B")]
		[FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		// Token: 0x0400B295 RID: 45717
		[Token(Token = "0x400860C")]
		[FieldOffset(Offset = "0x20")]
		public float maxAngle;

		// Token: 0x0400B296 RID: 45718
		[Token(Token = "0x400860D")]
		[FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		// Token: 0x0400B297 RID: 45719
		[Token(Token = "0x400860E")]
		[FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		// Token: 0x0400B298 RID: 45720
		[Token(Token = "0x400860F")]
		[FieldOffset(Offset = "0x30")]
		protected Animator animator;

		// Token: 0x0400B299 RID: 45721
		[Token(Token = "0x4008610")]
		[FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		// Token: 0x0400B29A RID: 45722
		[Token(Token = "0x4008611")]
		[FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		// Token: 0x0400B29B RID: 45723
		[Token(Token = "0x4008612")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;
	}
}
