using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D8F RID: 3471
	[Token(Token = "0x20008E0")]
	public class Inertia : OffsetModifier
	{
		// Token: 0x060059FC RID: 23036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x2CD8920", Offset = "0x2CD8A21", VA = "0x2CD8920")]
		public void ResetBodies()
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x2CD8A80", Offset = "0x2CD8B81", VA = "0x2CD8A80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x2CD8ED0", Offset = "0x2CD8FD1", VA = "0x2CD8ED0")]
		public Inertia()
		{
		}

		// Token: 0x0400B927 RID: 47399
		[Token(Token = "0x4008A73")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C290", Offset = "0x17C391")]
		public Inertia.Body[] bodies;

		// Token: 0x0400B928 RID: 47400
		[Token(Token = "0x4008A74")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C2D0", Offset = "0x17C3D1")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x02000D90 RID: 3472
		[Token(Token = "0x2001420")]
		[Serializable]
		public class Body
		{
			// Token: 0x060059FF RID: 23039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A54")]
			[Address(RVA = "0x2CD89A0", Offset = "0x2CD8AA1", VA = "0x2CD89A0")]
			public void Reset()
			{
			}

			// Token: 0x06005A00 RID: 23040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A55")]
			[Address(RVA = "0x2CD8B40", Offset = "0x2CD8C41", VA = "0x2CD8B40")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			// Token: 0x06005A01 RID: 23041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A56")]
			[Address(RVA = "0x2CD8EE0", Offset = "0x2CD8FE1", VA = "0x2CD8EE0")]
			public Body()
			{
			}

			// Token: 0x0400B929 RID: 47401
			[Token(Token = "0x401BAD4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198590", Offset = "0x198691")]
			public Transform transform;

			// Token: 0x0400B92A RID: 47402
			[Token(Token = "0x401BAD5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1985D0", Offset = "0x1986D1")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x0400B92B RID: 47403
			[Token(Token = "0x401BAD6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198610", Offset = "0x198711")]
			public float speed;

			// Token: 0x0400B92C RID: 47404
			[Token(Token = "0x401BAD7")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198650", Offset = "0x198751")]
			public float acceleration;

			// Token: 0x0400B92D RID: 47405
			[Token(Token = "0x401BAD8")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198690", Offset = "0x198791")]
			[Attribute(Name = "RangeAttribute", RVA = "0x198690", Offset = "0x198791")]
			public float matchVelocity;

			// Token: 0x0400B92E RID: 47406
			[Token(Token = "0x401BAD9")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1986F0", Offset = "0x1987F1")]
			public float gravity;

			// Token: 0x0400B92F RID: 47407
			[Token(Token = "0x401BADA")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			// Token: 0x0400B930 RID: 47408
			[Token(Token = "0x401BADB")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			// Token: 0x0400B931 RID: 47409
			[Token(Token = "0x401BADC")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			// Token: 0x0400B932 RID: 47410
			[Token(Token = "0x401BADD")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			// Token: 0x0400B933 RID: 47411
			[Token(Token = "0x401BADE")]
			[FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			// Token: 0x02000D91 RID: 3473
			[Token(Token = "0x2001662")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06005A02 RID: 23042 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CB")]
				[Address(RVA = "0x2CD8F00", Offset = "0x2CD9001", VA = "0x2CD8F00")]
				public EffectorLink()
				{
				}

				// Token: 0x0400B934 RID: 47412
				[Token(Token = "0x401C443")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1999E0", Offset = "0x199AE1")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400B935 RID: 47413
				[Token(Token = "0x401C444")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199A20", Offset = "0x199B21")]
				public float weight;
			}
		}
	}
}
