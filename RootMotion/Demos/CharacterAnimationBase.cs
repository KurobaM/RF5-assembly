using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE8 RID: 3304
	[Token(Token = "0x2000880")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		// Token: 0x06005472 RID: 21618 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x29AD600", Offset = "0x29AD701", VA = "0x29AD600", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		[Token(Token = "0x1700089B")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600465D")]
			[Address(RVA = "0x29AD630", Offset = "0x29AD731", VA = "0x29AD630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		[Token(Token = "0x600465E")]
		[Address(RVA = "0x29AD640", Offset = "0x29AD741", VA = "0x29AD640")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return 0f;
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465F")]
		[Address(RVA = "0x29AD710", Offset = "0x29AD811", VA = "0x29AD710", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004660")]
		[Address(RVA = "0x29AD880", Offset = "0x29AD981", VA = "0x29AD880", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x29ADB50", Offset = "0x29ADC51", VA = "0x29ADB50", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004662")]
		[Address(RVA = "0x29AD890", Offset = "0x29AD991", VA = "0x29AD890")]
		private void SmoothFollow()
		{
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004663")]
		[Address(RVA = "0x29ADB60", Offset = "0x29ADC61", VA = "0x29ADB60")]
		protected CharacterAnimationBase()
		{
		}

		// Token: 0x0400B3AC RID: 45996
		[Token(Token = "0x40086EA")]
		[FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		// Token: 0x0400B3AD RID: 45997
		[Token(Token = "0x40086EB")]
		[FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		// Token: 0x0400B3AE RID: 45998
		[Token(Token = "0x40086EC")]
		[FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		// Token: 0x0400B3AF RID: 45999
		[Token(Token = "0x40086ED")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		// Token: 0x0400B3B0 RID: 46000
		[Token(Token = "0x40086EE")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		// Token: 0x0400B3B1 RID: 46001
		[Token(Token = "0x40086EF")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		// Token: 0x0400B3B2 RID: 46002
		[Token(Token = "0x40086F0")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;
	}
}
