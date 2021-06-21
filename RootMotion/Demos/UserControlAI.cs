using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CF2 RID: 3314
	[Token(Token = "0x2000886")]
	public class UserControlAI : UserControlThirdPerson
	{
		// Token: 0x060054B1 RID: 21681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004695")]
		[Address(RVA = "0x28656E0", Offset = "0x28657E1", VA = "0x28656E0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x2865790", Offset = "0x2865891", VA = "0x2865790", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004697")]
		[Address(RVA = "0x2865A40", Offset = "0x2865B41", VA = "0x2865A40")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004698")]
		[Address(RVA = "0x2865A70", Offset = "0x2865B71", VA = "0x2865A70")]
		public UserControlAI()
		{
		}

		// Token: 0x0400B427 RID: 46119
		[Token(Token = "0x4008752")]
		[FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		// Token: 0x0400B428 RID: 46120
		[Token(Token = "0x4008753")]
		[FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		// Token: 0x0400B429 RID: 46121
		[Token(Token = "0x4008754")]
		[FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		// Token: 0x0400B42A RID: 46122
		[Token(Token = "0x4008755")]
		[FieldOffset(Offset = "0x58")]
		public Navigator navigator;
	}
}
