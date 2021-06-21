using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB7 RID: 3255
	[Token(Token = "0x2000859")]
	[Attribute(Name = "RequireComponent", RVA = "0x147930", Offset = "0x147A31")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		// Token: 0x060053BB RID: 21435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CF")]
		[Address(RVA = "0x29AE630", Offset = "0x29AE731", VA = "0x29AE630", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D0")]
		[Address(RVA = "0x29AE6A0", Offset = "0x29AE7A1", VA = "0x29AE6A0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x29AE980", Offset = "0x29AEA81", VA = "0x29AE980")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D2")]
		[Address(RVA = "0x29AEB40", Offset = "0x29AEC41", VA = "0x29AEB40")]
		public CharacterAnimationThirdPersonIK()
		{
		}

		// Token: 0x0400B2A7 RID: 45735
		[Token(Token = "0x400861E")]
		[FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;
	}
}
