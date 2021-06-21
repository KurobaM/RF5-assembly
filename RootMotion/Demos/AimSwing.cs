using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CA8 RID: 3240
	[Token(Token = "0x200084D")]
	public class AimSwing : MonoBehaviour
	{
		// Token: 0x0600537E RID: 21374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x29AB2F0", Offset = "0x29AB3F1", VA = "0x29AB2F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x29AB400", Offset = "0x29AB501", VA = "0x29AB400")]
		public AimSwing()
		{
		}

		// Token: 0x0400B227 RID: 45607
		[Token(Token = "0x40085AC")]
		[FieldOffset(Offset = "0x18")]
		public AimIK ik;

		// Token: 0x0400B228 RID: 45608
		[Token(Token = "0x40085AD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1774B0", Offset = "0x1775B1")]
		public Vector3 animatedSwingDirection;
	}
}
