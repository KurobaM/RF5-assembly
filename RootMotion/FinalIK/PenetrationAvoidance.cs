using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D9A RID: 3482
	[Token(Token = "0x20008E5")]
	public class PenetrationAvoidance : OffsetModifier
	{
		// Token: 0x06005A2D RID: 23085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0x27C6D20", Offset = "0x27C6E21", VA = "0x27C6D20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x27C6FD0", Offset = "0x27C70D1", VA = "0x27C6FD0")]
		public PenetrationAvoidance()
		{
		}

		// Token: 0x0400B966 RID: 47462
		[Token(Token = "0x4008A90")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C730", Offset = "0x17C831")]
		public PenetrationAvoidance.Avoider[] avoiders;

		// Token: 0x02000D9B RID: 3483
		[Token(Token = "0x2001425")]
		[Serializable]
		public class Avoider
		{
			// Token: 0x06005A2F RID: 23087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A69")]
			[Address(RVA = "0x27C6DB0", Offset = "0x27C6EB1", VA = "0x27C6DB0")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x06005A30 RID: 23088 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
			[Token(Token = "0x6007A6A")]
			[Address(RVA = "0x27C6FE0", Offset = "0x27C70E1", VA = "0x27C6FE0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
			[Token(Token = "0x6007A6B")]
			[Address(RVA = "0x27C7180", Offset = "0x27C7281", VA = "0x27C7180")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A6C")]
			[Address(RVA = "0x27C73F0", Offset = "0x27C74F1", VA = "0x27C73F0")]
			public Avoider()
			{
			}

			// Token: 0x0400B967 RID: 47463
			[Token(Token = "0x401BAF4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1989F0", Offset = "0x198AF1")]
			public Transform[] raycastFrom;

			// Token: 0x0400B968 RID: 47464
			[Token(Token = "0x401BAF5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198A30", Offset = "0x198B31")]
			public Transform raycastTo;

			// Token: 0x0400B969 RID: 47465
			[Token(Token = "0x401BAF6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198A70", Offset = "0x198B71")]
			[Attribute(Name = "RangeAttribute", RVA = "0x198A70", Offset = "0x198B71")]
			public float raycastRadius;

			// Token: 0x0400B96A RID: 47466
			[Token(Token = "0x401BAF7")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198AD0", Offset = "0x198BD1")]
			public PenetrationAvoidance.Avoider.EffectorLink[] effectors;

			// Token: 0x0400B96B RID: 47467
			[Token(Token = "0x401BAF8")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198B10", Offset = "0x198C11")]
			public float smoothTimeIn;

			// Token: 0x0400B96C RID: 47468
			[Token(Token = "0x401BAF9")]
			[FieldOffset(Offset = "0x34")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198B50", Offset = "0x198C51")]
			public float smoothTimeOut;

			// Token: 0x0400B96D RID: 47469
			[Token(Token = "0x401BAFA")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198B90", Offset = "0x198C91")]
			public LayerMask layers;

			// Token: 0x0400B96E RID: 47470
			[Token(Token = "0x401BAFB")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			// Token: 0x0400B96F RID: 47471
			[Token(Token = "0x401BAFC")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			// Token: 0x0400B970 RID: 47472
			[Token(Token = "0x401BAFD")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			// Token: 0x02000D9C RID: 3484
			[Token(Token = "0x2001663")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06005A33 RID: 23091 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CC")]
				[Address(RVA = "0x27C7410", Offset = "0x27C7511", VA = "0x27C7410")]
				public EffectorLink()
				{
				}

				// Token: 0x0400B971 RID: 47473
				[Token(Token = "0x401C445")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199A60", Offset = "0x199B61")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400B972 RID: 47474
				[Token(Token = "0x401C446")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199AA0", Offset = "0x199BA1")]
				public float weight;
			}
		}
	}
}
