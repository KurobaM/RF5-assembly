using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC9 RID: 3273
	[Token(Token = "0x2000869")]
	public class MotionAbsorb : OffsetModifier
	{
		// Token: 0x060053FC RID: 21500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004609")]
		[Address(RVA = "0x29BAB50", Offset = "0x29BAC51", VA = "0x29BAB50", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460A")]
		[Address(RVA = "0x29BAC40", Offset = "0x29BAD41", VA = "0x29BAC40")]
		private void OnCollisionEnter(Collision c)
		{
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460B")]
		[Address(RVA = "0x29BADD0", Offset = "0x29BAED1", VA = "0x29BADD0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460C")]
		[Address(RVA = "0x29BB070", Offset = "0x29BB171", VA = "0x29BB070")]
		private void AfterIK()
		{
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460D")]
		[Address(RVA = "0x29BB210", Offset = "0x29BB311", VA = "0x29BB210", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600460E")]
		[Address(RVA = "0x29BB340", Offset = "0x29BB441", VA = "0x29BB340")]
		public MotionAbsorb()
		{
		}

		// Token: 0x0400B315 RID: 45845
		[Token(Token = "0x400867E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177CC0", Offset = "0x177DC1")]
		public MotionAbsorb.Mode mode;

		// Token: 0x0400B316 RID: 45846
		[Token(Token = "0x400867F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177D00", Offset = "0x177E01")]
		public MotionAbsorb.Absorber[] absorbers;

		// Token: 0x0400B317 RID: 45847
		[Token(Token = "0x4008680")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177D40", Offset = "0x177E41")]
		public AnimationCurve falloff;

		// Token: 0x0400B318 RID: 45848
		[Token(Token = "0x4008681")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177D80", Offset = "0x177E81")]
		public float falloffSpeed;

		// Token: 0x0400B319 RID: 45849
		[Token(Token = "0x4008682")]
		[FieldOffset(Offset = "0x44")]
		private float timer;

		// Token: 0x0400B31A RID: 45850
		[Token(Token = "0x4008683")]
		[FieldOffset(Offset = "0x48")]
		private float w;

		// Token: 0x0400B31B RID: 45851
		[Token(Token = "0x4008684")]
		[FieldOffset(Offset = "0x4C")]
		private MotionAbsorb.Mode initialMode;

		// Token: 0x02000CCA RID: 3274
		[Token(Token = "0x20013D9")]
		[Serializable]
		public enum Mode
		{
			// Token: 0x0400B31D RID: 45853
			[Token(Token = "0x401B8DC")]
			Position,
			// Token: 0x0400B31E RID: 45854
			[Token(Token = "0x401B8DD")]
			PositionOffset
		}

		// Token: 0x02000CCB RID: 3275
		[Token(Token = "0x20013DA")]
		[Serializable]
		public class Absorber
		{
			// Token: 0x06005402 RID: 21506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BD")]
			[Address(RVA = "0x29BACD0", Offset = "0x29BADD1", VA = "0x29BACD0")]
			public void SetToBone(IKSolverFullBodyBiped solver, MotionAbsorb.Mode mode)
			{
			}

			// Token: 0x06005403 RID: 21507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BE")]
			[Address(RVA = "0x29BAF00", Offset = "0x29BB001", VA = "0x29BAF00")]
			public void UpdateEffectorWeights(float w)
			{
			}

			// Token: 0x06005404 RID: 21508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BF")]
			[Address(RVA = "0x29BAF40", Offset = "0x29BB041", VA = "0x29BAF40")]
			public void SetPosition(float w)
			{
			}

			// Token: 0x06005405 RID: 21509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C0")]
			[Address(RVA = "0x29BB100", Offset = "0x29BB201", VA = "0x29BB100")]
			public void SetRotation(float w)
			{
			}

			// Token: 0x06005406 RID: 21510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C1")]
			[Address(RVA = "0x29BB350", Offset = "0x29BB451", VA = "0x29BB350")]
			public Absorber()
			{
			}

			// Token: 0x0400B31F RID: 45855
			[Token(Token = "0x401B8DE")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195A50", Offset = "0x195B51")]
			public FullBodyBipedEffector effector;

			// Token: 0x0400B320 RID: 45856
			[Token(Token = "0x401B8DF")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195A90", Offset = "0x195B91")]
			public float weight;

			// Token: 0x0400B321 RID: 45857
			[Token(Token = "0x401B8E0")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 position;

			// Token: 0x0400B322 RID: 45858
			[Token(Token = "0x401B8E1")]
			[FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			// Token: 0x0400B323 RID: 45859
			[Token(Token = "0x401B8E2")]
			[FieldOffset(Offset = "0x38")]
			private IKEffector e;
		}
	}
}
