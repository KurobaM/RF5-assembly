using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x200083B")]
	[Serializable]
	public class BipedLimbOrientations
	{
		// Token: 0x060052D4 RID: 21204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x29A1EA0", Offset = "0x29A1FA1", VA = "0x29A1EA0")]
		public BipedLimbOrientations(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg)
		{
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088E")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60044F6")]
			[Address(RVA = "0x29A1F20", Offset = "0x29A2021", VA = "0x29A1F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088F")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60044F7")]
			[Address(RVA = "0x29A2250", Offset = "0x29A2351", VA = "0x29A2250")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400B1C1 RID: 45505
		[Token(Token = "0x4008557")]
		[FieldOffset(Offset = "0x10")]
		public BipedLimbOrientations.LimbOrientation leftArm;

		// Token: 0x0400B1C2 RID: 45506
		[Token(Token = "0x4008558")]
		[FieldOffset(Offset = "0x18")]
		public BipedLimbOrientations.LimbOrientation rightArm;

		// Token: 0x0400B1C3 RID: 45507
		[Token(Token = "0x4008559")]
		[FieldOffset(Offset = "0x20")]
		public BipedLimbOrientations.LimbOrientation leftLeg;

		// Token: 0x0400B1C4 RID: 45508
		[Token(Token = "0x400855A")]
		[FieldOffset(Offset = "0x28")]
		public BipedLimbOrientations.LimbOrientation rightLeg;

		// Token: 0x02000C92 RID: 3218
		[Token(Token = "0x20013CF")]
		[Serializable]
		public class LimbOrientation
		{
			// Token: 0x060052D7 RID: 21207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078A9")]
			[Address(RVA = "0x29A21C0", Offset = "0x29A22C1", VA = "0x29A21C0")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}

			// Token: 0x0400B1C5 RID: 45509
			[Token(Token = "0x401B8AE")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			// Token: 0x0400B1C6 RID: 45510
			[Token(Token = "0x401B8AF")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			// Token: 0x0400B1C7 RID: 45511
			[Token(Token = "0x401B8B0")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;
		}
	}
}
