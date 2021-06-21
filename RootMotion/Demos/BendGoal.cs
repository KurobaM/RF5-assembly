using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x200087A")]
	public class BendGoal : MonoBehaviour
	{
		// Token: 0x06005461 RID: 21601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464D")]
		[Address(RVA = "0x29ACFF0", Offset = "0x29AD0F1", VA = "0x29ACFF0")]
		private void Start()
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464E")]
		[Address(RVA = "0x29AD060", Offset = "0x29AD161", VA = "0x29AD060")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x29AD120", Offset = "0x29AD221", VA = "0x29AD120")]
		public BendGoal()
		{
		}

		// Token: 0x0400B390 RID: 45968
		[Token(Token = "0x40086D0")]
		[FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		// Token: 0x0400B391 RID: 45969
		[Token(Token = "0x40086D1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177FE0", Offset = "0x1780E1")]
		public float weight;
	}
}
