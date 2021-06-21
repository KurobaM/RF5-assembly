using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D7E RID: 3454
	[Token(Token = "0x20008DB")]
	public class Amplifier : OffsetModifier
	{
		// Token: 0x060059B0 RID: 22960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A55")]
		[Address(RVA = "0x286C570", Offset = "0x286C671", VA = "0x286C570", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A56")]
		[Address(RVA = "0x286CB30", Offset = "0x286CC31", VA = "0x286CB30")]
		public Amplifier()
		{
		}

		// Token: 0x0400B8DF RID: 47327
		[Token(Token = "0x4008A66")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C050", Offset = "0x17C151")]
		public Amplifier.Body[] bodies;

		// Token: 0x02000D7F RID: 3455
		[Token(Token = "0x2001419")]
		[Serializable]
		public class Body
		{
			// Token: 0x060059B2 RID: 22962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A24")]
			[Address(RVA = "0x286C6B0", Offset = "0x286C7B1", VA = "0x286C6B0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			// Token: 0x060059B3 RID: 22963 RVA: 0x0001D898 File Offset: 0x0001BA98
			[Token(Token = "0x6007A25")]
			[Address(RVA = "0x286CB40", Offset = "0x286CC41", VA = "0x286CB40")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			// Token: 0x060059B4 RID: 22964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A26")]
			[Address(RVA = "0x286CB50", Offset = "0x286CC51", VA = "0x286CB50")]
			public Body()
			{
			}

			// Token: 0x0400B8E0 RID: 47328
			[Token(Token = "0x401BAAB")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197F70", Offset = "0x198071")]
			public Transform transform;

			// Token: 0x0400B8E1 RID: 47329
			[Token(Token = "0x401BAAC")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197FB0", Offset = "0x1980B1")]
			public Transform relativeTo;

			// Token: 0x0400B8E2 RID: 47330
			[Token(Token = "0x401BAAD")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x197FF0", Offset = "0x1980F1")]
			public Amplifier.Body.EffectorLink[] effectorLinks;

			// Token: 0x0400B8E3 RID: 47331
			[Token(Token = "0x401BAAE")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198030", Offset = "0x198131")]
			public float verticalWeight;

			// Token: 0x0400B8E4 RID: 47332
			[Token(Token = "0x401BAAF")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198070", Offset = "0x198171")]
			public float horizontalWeight;

			// Token: 0x0400B8E5 RID: 47333
			[Token(Token = "0x401BAB0")]
			[FieldOffset(Offset = "0x30")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1980B0", Offset = "0x1981B1")]
			public float speed;

			// Token: 0x0400B8E6 RID: 47334
			[Token(Token = "0x401BAB1")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			// Token: 0x0400B8E7 RID: 47335
			[Token(Token = "0x401BAB2")]
			[FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			// Token: 0x0400B8E8 RID: 47336
			[Token(Token = "0x401BAB3")]
			[FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			// Token: 0x02000D80 RID: 3456
			[Token(Token = "0x200165D")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x060059B5 RID: 22965 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080BE")]
				[Address(RVA = "0x286CB70", Offset = "0x286CC71", VA = "0x286CB70")]
				public EffectorLink()
				{
				}

				// Token: 0x0400B8E9 RID: 47337
				[Token(Token = "0x401C431")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199720", Offset = "0x199821")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400B8EA RID: 47338
				[Token(Token = "0x401C432")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199760", Offset = "0x199861")]
				public float weight;
			}
		}
	}
}
