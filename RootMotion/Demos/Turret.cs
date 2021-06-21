using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x200087B")]
	public class Turret : MonoBehaviour
	{
		// Token: 0x06005464 RID: 21604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004650")]
		[Address(RVA = "0x2864E80", Offset = "0x2864F81", VA = "0x2864E80")]
		private void Update()
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004651")]
		[Address(RVA = "0x2865040", Offset = "0x2865141", VA = "0x2865040")]
		public Turret()
		{
		}

		// Token: 0x0400B392 RID: 45970
		[Token(Token = "0x40086D2")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x0400B393 RID: 45971
		[Token(Token = "0x40086D3")]
		[FieldOffset(Offset = "0x20")]
		public Turret.Part[] parts;

		// Token: 0x02000CE3 RID: 3299
		[Token(Token = "0x20013E0")]
		[Serializable]
		public class Part
		{
			// Token: 0x06005466 RID: 21606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078DE")]
			[Address(RVA = "0x2864F00", Offset = "0x2865001", VA = "0x2864F00")]
			public void AimAt(Transform target)
			{
			}

			// Token: 0x06005467 RID: 21607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078DF")]
			[Address(RVA = "0x2865050", Offset = "0x2865151", VA = "0x2865050")]
			public Part()
			{
			}

			// Token: 0x0400B394 RID: 45972
			[Token(Token = "0x401B904")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			// Token: 0x0400B395 RID: 45973
			[Token(Token = "0x401B905")]
			[FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;
		}
	}
}
