using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE9 RID: 3305
	[Token(Token = "0x2000881")]
	[Attribute(Name = "RequireComponent", RVA = "0x147C60", Offset = "0x147D61")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		// Token: 0x0600547A RID: 21626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004664")]
		[Address(RVA = "0x29ADB80", Offset = "0x29ADC81", VA = "0x29ADB80", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0001BD08 File Offset: 0x00019F08
		[Token(Token = "0x6004665")]
		[Address(RVA = "0x29ADBF0", Offset = "0x29ADCF1", VA = "0x29ADBF0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004666")]
		[Address(RVA = "0x29ADD20", Offset = "0x29ADE21", VA = "0x29ADD20")]
		private void Update()
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x29ADEA0", Offset = "0x29ADFA1", VA = "0x29ADEA0")]
		public CharacterAnimationSimple()
		{
		}

		// Token: 0x0400B3B3 RID: 46003
		[Token(Token = "0x40086F1")]
		[FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		// Token: 0x0400B3B4 RID: 46004
		[Token(Token = "0x40086F2")]
		[FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		// Token: 0x0400B3B5 RID: 46005
		[Token(Token = "0x40086F3")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		// Token: 0x0400B3B6 RID: 46006
		[Token(Token = "0x40086F4")]
		[FieldOffset(Offset = "0x78")]
		private Animator animator;
	}
}
