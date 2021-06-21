using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D89 RID: 3465
	[Token(Token = "0x20008DF")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		// Token: 0x060059DD RID: 23005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x2C10980", Offset = "0x2C10A81", VA = "0x2C10980", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x2C10BB0", Offset = "0x2C10CB1", VA = "0x2C10BB0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x2C10F50", Offset = "0x2C11051", VA = "0x2C10F50")]
		public HitReactionVRIK()
		{
		}

		// Token: 0x0400B90C RID: 47372
		[Token(Token = "0x4008A70")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		// Token: 0x0400B90D RID: 47373
		[Token(Token = "0x4008A71")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C210", Offset = "0x17C311")]
		public HitReactionVRIK.PositionOffset[] positionOffsets;

		// Token: 0x0400B90E RID: 47374
		[Token(Token = "0x4008A72")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C250", Offset = "0x17C351")]
		public HitReactionVRIK.RotationOffset[] rotationOffsets;

		// Token: 0x02000D8A RID: 3466
		[Token(Token = "0x200141D")]
		[Serializable]
		public abstract class Offset
		{
			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x060059E0 RID: 23008 RVA: 0x0001D970 File Offset: 0x0001BB70
			// (set) Token: 0x060059E1 RID: 23009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E45")]
			private protected float crossFader
			{
				[Token(Token = "0x6007A3E")]
				[Address(RVA = "0x2C10F60", Offset = "0x2C11061", VA = "0x2C10F60")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F30", Offset = "0x1B5031")]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x6007A3F")]
				[Address(RVA = "0x2C10F70", Offset = "0x2C11071", VA = "0x2C10F70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F40", Offset = "0x1B5041")]
				private set
				{
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x060059E2 RID: 23010 RVA: 0x0001D988 File Offset: 0x0001BB88
			// (set) Token: 0x060059E3 RID: 23011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E46")]
			private protected float timer
			{
				[Token(Token = "0x6007A40")]
				[Address(RVA = "0x2C10F80", Offset = "0x2C11081", VA = "0x2C10F80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F50", Offset = "0x1B5051")]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x6007A41")]
				[Address(RVA = "0x2C10F90", Offset = "0x2C11091", VA = "0x2C10F90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F60", Offset = "0x1B5061")]
				private set
				{
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x060059E4 RID: 23012 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
			// (set) Token: 0x060059E5 RID: 23013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E47")]
			private protected Vector3 force
			{
				[Token(Token = "0x6007A42")]
				[Address(RVA = "0x2C10FA0", Offset = "0x2C110A1", VA = "0x2C10FA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F70", Offset = "0x1B5071")]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007A43")]
				[Address(RVA = "0x2C10FB0", Offset = "0x2C110B1", VA = "0x2C10FB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F80", Offset = "0x1B5081")]
				private set
				{
				}
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x060059E6 RID: 23014 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
			// (set) Token: 0x060059E7 RID: 23015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E48")]
			private protected Vector3 point
			{
				[Token(Token = "0x6007A44")]
				[Address(RVA = "0x2C10FC0", Offset = "0x2C110C1", VA = "0x2C10FC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F90", Offset = "0x1B5091")]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007A45")]
				[Address(RVA = "0x2C10FD0", Offset = "0x2C110D1", VA = "0x2C10FD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4FA0", Offset = "0x1B50A1")]
				private set
				{
				}
			}

			// Token: 0x060059E8 RID: 23016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A46")]
			[Address(RVA = "0x2C10E00", Offset = "0x2C10F01", VA = "0x2C10E00")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			// Token: 0x060059E9 RID: 23017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A47")]
			[Address(RVA = "0x2C10A50", Offset = "0x2C10B51", VA = "0x2C10A50")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x060059EA RID: 23018
			[Token(Token = "0x6007A48")]
			protected abstract float GetLength(AnimationCurve[] curves);

			// Token: 0x060059EB RID: 23019
			[Token(Token = "0x6007A49")]
			protected abstract void CrossFadeStart();

			// Token: 0x060059EC RID: 23020
			[Token(Token = "0x6007A4A")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			// Token: 0x060059ED RID: 23021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A4B")]
			[Address(RVA = "0x2C10FE0", Offset = "0x2C110E1", VA = "0x2C10FE0")]
			protected Offset()
			{
			}

			// Token: 0x0400B90F RID: 47375
			[Token(Token = "0x401BAC4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198340", Offset = "0x198441")]
			public string name;

			// Token: 0x0400B910 RID: 47376
			[Token(Token = "0x401BAC5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198380", Offset = "0x198481")]
			public Collider collider;

			// Token: 0x0400B911 RID: 47377
			[Token(Token = "0x401BAC6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1983C0", Offset = "0x1984C1")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x0400B912 RID: 47378
			[Token(Token = "0x401BAC7")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x198410", Offset = "0x198511")]
			private float <crossFader>k__BackingField;

			// Token: 0x0400B913 RID: 47379
			[Token(Token = "0x401BAC8")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x198420", Offset = "0x198521")]
			private float <timer>k__BackingField;

			// Token: 0x0400B914 RID: 47380
			[Token(Token = "0x401BAC9")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x198430", Offset = "0x198531")]
			private Vector3 <force>k__BackingField;

			// Token: 0x0400B915 RID: 47381
			[Token(Token = "0x401BACA")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x198440", Offset = "0x198541")]
			private Vector3 <point>k__BackingField;

			// Token: 0x0400B916 RID: 47382
			[Token(Token = "0x401BACB")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			// Token: 0x0400B917 RID: 47383
			[Token(Token = "0x401BACC")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			// Token: 0x0400B918 RID: 47384
			[Token(Token = "0x401BACD")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;
		}

		// Token: 0x02000D8B RID: 3467
		[Token(Token = "0x200141E")]
		[Serializable]
		public class PositionOffset : HitReactionVRIK.Offset
		{
			// Token: 0x060059EE RID: 23022 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
			[Token(Token = "0x6007A4C")]
			[Address(RVA = "0x2C11000", Offset = "0x2C11101", VA = "0x2C11000", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x060059EF RID: 23023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A4D")]
			[Address(RVA = "0x2C11210", Offset = "0x2C11311", VA = "0x2C11210", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060059F0 RID: 23024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A4E")]
			[Address(RVA = "0x2C112A0", Offset = "0x2C113A1", VA = "0x2C112A0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x060059F1 RID: 23025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A4F")]
			[Address(RVA = "0x2C115D0", Offset = "0x2C116D1", VA = "0x2C115D0")]
			public PositionOffset()
			{
			}

			// Token: 0x0400B919 RID: 47385
			[Token(Token = "0x401BACE")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198450", Offset = "0x198551")]
			public int forceDirCurveIndex;

			// Token: 0x0400B91A RID: 47386
			[Token(Token = "0x401BACF")]
			[FieldOffset(Offset = "0x54")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198490", Offset = "0x198591")]
			public int upDirCurveIndex;

			// Token: 0x0400B91B RID: 47387
			[Token(Token = "0x401BAD0")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1984D0", Offset = "0x1985D1")]
			public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;

			// Token: 0x02000D8C RID: 3468
			[Token(Token = "0x2001660")]
			[Serializable]
			public class PositionOffsetLink
			{
				// Token: 0x060059F2 RID: 23026 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C5")]
				[Address(RVA = "0x2C114D0", Offset = "0x2C115D1", VA = "0x2C114D0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x060059F3 RID: 23027 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C6")]
				[Address(RVA = "0x2C11280", Offset = "0x2C11381", VA = "0x2C11280")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060059F4 RID: 23028 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C7")]
				[Address(RVA = "0x2C115F0", Offset = "0x2C116F1", VA = "0x2C115F0")]
				public PositionOffsetLink()
				{
				}

				// Token: 0x0400B91C RID: 47388
				[Token(Token = "0x401C43B")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1998C0", Offset = "0x1999C1")]
				public IKSolverVR.PositionOffset positionOffset;

				// Token: 0x0400B91D RID: 47389
				[Token(Token = "0x401C43C")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199900", Offset = "0x199A01")]
				public float weight;

				// Token: 0x0400B91E RID: 47390
				[Token(Token = "0x401C43D")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				// Token: 0x0400B91F RID: 47391
				[Token(Token = "0x401C43E")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;
			}
		}

		// Token: 0x02000D8D RID: 3469
		[Token(Token = "0x200141F")]
		[Serializable]
		public class RotationOffset : HitReactionVRIK.Offset
		{
			// Token: 0x060059F5 RID: 23029 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
			[Token(Token = "0x6007A50")]
			[Address(RVA = "0x2C11600", Offset = "0x2C11701", VA = "0x2C11600", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x060059F6 RID: 23030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A51")]
			[Address(RVA = "0x2C116F0", Offset = "0x2C117F1", VA = "0x2C116F0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060059F7 RID: 23031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A52")]
			[Address(RVA = "0x2C11780", Offset = "0x2C11881", VA = "0x2C11780", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x060059F8 RID: 23032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A53")]
			[Address(RVA = "0x2C11BD0", Offset = "0x2C11CD1", VA = "0x2C11BD0")]
			public RotationOffset()
			{
			}

			// Token: 0x0400B920 RID: 47392
			[Token(Token = "0x401BAD1")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198510", Offset = "0x198611")]
			public int curveIndex;

			// Token: 0x0400B921 RID: 47393
			[Token(Token = "0x401BAD2")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198550", Offset = "0x198651")]
			public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;

			// Token: 0x0400B922 RID: 47394
			[Token(Token = "0x401BAD3")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			// Token: 0x02000D8E RID: 3470
			[Token(Token = "0x2001661")]
			[Serializable]
			public class RotationOffsetLink
			{
				// Token: 0x060059F9 RID: 23033 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C8")]
				[Address(RVA = "0x2C11AA0", Offset = "0x2C11BA1", VA = "0x2C11AA0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x060059FA RID: 23034 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C9")]
				[Address(RVA = "0x2C11760", Offset = "0x2C11861", VA = "0x2C11760")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060059FB RID: 23035 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CA")]
				[Address(RVA = "0x2C11BF0", Offset = "0x2C11CF1", VA = "0x2C11BF0")]
				public RotationOffsetLink()
				{
				}

				// Token: 0x0400B923 RID: 47395
				[Token(Token = "0x401C43F")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199940", Offset = "0x199A41")]
				public IKSolverVR.RotationOffset rotationOffset;

				// Token: 0x0400B924 RID: 47396
				[Token(Token = "0x401C440")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199980", Offset = "0x199A81")]
				[Attribute(Name = "RangeAttribute", RVA = "0x199980", Offset = "0x199A81")]
				public float weight;

				// Token: 0x0400B925 RID: 47397
				[Token(Token = "0x401C441")]
				[FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				// Token: 0x0400B926 RID: 47398
				[Token(Token = "0x401C442")]
				[FieldOffset(Offset = "0x28")]
				private Quaternion current;
			}
		}
	}
}
