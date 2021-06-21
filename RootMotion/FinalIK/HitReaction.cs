using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D83 RID: 3459
	[Token(Token = "0x20008DE")]
	public class HitReaction : OffsetModifier
	{
		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060059BC RID: 22972 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		[Token(Token = "0x170008F2")]
		public bool inProgress
		{
			[Token(Token = "0x6004A5D")]
			[Address(RVA = "0x2C0F710", Offset = "0x2C0F811", VA = "0x2C0F710")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x2C0F7F0", Offset = "0x2C0F8F1", VA = "0x2C0F7F0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x2C0FA20", Offset = "0x2C0FB21", VA = "0x2C0FA20")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x2C0FD90", Offset = "0x2C0FE91", VA = "0x2C0FD90")]
		public HitReaction()
		{
		}

		// Token: 0x0400B8F2 RID: 47346
		[Token(Token = "0x4008A6E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C190", Offset = "0x17C291")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x0400B8F3 RID: 47347
		[Token(Token = "0x4008A6F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C1D0", Offset = "0x17C2D1")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x200141A")]
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x060059C0 RID: 22976 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
			[Token(Token = "0x17000E40")]
			public bool inProgress
			{
				[Token(Token = "0x6007A27")]
				[Address(RVA = "0x2C0F7D0", Offset = "0x2C0F8D1", VA = "0x2C0F7D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x060059C1 RID: 22977 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
			// (set) Token: 0x060059C2 RID: 22978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E41")]
			private protected float crossFader
			{
				[Token(Token = "0x6007A28")]
				[Address(RVA = "0x2C0FDA0", Offset = "0x2C0FEA1", VA = "0x2C0FDA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4EB0", Offset = "0x1B4FB1")]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x6007A29")]
				[Address(RVA = "0x2C0FDB0", Offset = "0x2C0FEB1", VA = "0x2C0FDB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4EC0", Offset = "0x1B4FC1")]
				private set
				{
				}
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x060059C3 RID: 22979 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
			// (set) Token: 0x060059C4 RID: 22980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E42")]
			private protected float timer
			{
				[Token(Token = "0x6007A2A")]
				[Address(RVA = "0x2C0FDC0", Offset = "0x2C0FEC1", VA = "0x2C0FDC0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4ED0", Offset = "0x1B4FD1")]
				protected get
				{
					return 0f;
				}
				[Token(Token = "0x6007A2B")]
				[Address(RVA = "0x2C0FDD0", Offset = "0x2C0FED1", VA = "0x2C0FDD0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4EE0", Offset = "0x1B4FE1")]
				private set
				{
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x060059C5 RID: 22981 RVA: 0x0001D910 File Offset: 0x0001BB10
			// (set) Token: 0x060059C6 RID: 22982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E43")]
			private protected Vector3 force
			{
				[Token(Token = "0x6007A2C")]
				[Address(RVA = "0x2C0FDE0", Offset = "0x2C0FEE1", VA = "0x2C0FDE0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4EF0", Offset = "0x1B4FF1")]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007A2D")]
				[Address(RVA = "0x2C0FDF0", Offset = "0x2C0FEF1", VA = "0x2C0FDF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F00", Offset = "0x1B5001")]
				private set
				{
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x060059C7 RID: 22983 RVA: 0x0001D928 File Offset: 0x0001BB28
			// (set) Token: 0x060059C8 RID: 22984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E44")]
			private protected Vector3 point
			{
				[Token(Token = "0x6007A2E")]
				[Address(RVA = "0x2C0FE00", Offset = "0x2C0FF01", VA = "0x2C0FE00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F10", Offset = "0x1B5011")]
				protected get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6007A2F")]
				[Address(RVA = "0x2C0FE10", Offset = "0x2C0FF11", VA = "0x2C0FE10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4F20", Offset = "0x1B5021")]
				private set
				{
				}
			}

			// Token: 0x060059C9 RID: 22985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A30")]
			[Address(RVA = "0x2C0FC60", Offset = "0x2C0FD61", VA = "0x2C0FC60")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			// Token: 0x060059CA RID: 22986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A31")]
			[Address(RVA = "0x2C0F8D0", Offset = "0x2C0F9D1", VA = "0x2C0F8D0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060059CB RID: 22987
			[Token(Token = "0x6007A32")]
			protected abstract float GetLength();

			// Token: 0x060059CC RID: 22988
			[Token(Token = "0x6007A33")]
			protected abstract void CrossFadeStart();

			// Token: 0x060059CD RID: 22989
			[Token(Token = "0x6007A34")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			// Token: 0x060059CE RID: 22990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A35")]
			[Address(RVA = "0x2C0FE20", Offset = "0x2C0FF21", VA = "0x2C0FE20")]
			protected HitPoint()
			{
			}

			// Token: 0x0400B8F4 RID: 47348
			[Token(Token = "0x401BAB4")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1980F0", Offset = "0x1981F1")]
			public string name;

			// Token: 0x0400B8F5 RID: 47349
			[Token(Token = "0x401BAB5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198130", Offset = "0x198231")]
			public Collider collider;

			// Token: 0x0400B8F6 RID: 47350
			[Token(Token = "0x401BAB6")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198170", Offset = "0x198271")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x0400B8F7 RID: 47351
			[Token(Token = "0x401BAB7")]
			[FieldOffset(Offset = "0x24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1981C0", Offset = "0x1982C1")]
			private float <crossFader>k__BackingField;

			// Token: 0x0400B8F8 RID: 47352
			[Token(Token = "0x401BAB8")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1981D0", Offset = "0x1982D1")]
			private float <timer>k__BackingField;

			// Token: 0x0400B8F9 RID: 47353
			[Token(Token = "0x401BAB9")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1981E0", Offset = "0x1982E1")]
			private Vector3 <force>k__BackingField;

			// Token: 0x0400B8FA RID: 47354
			[Token(Token = "0x401BABA")]
			[FieldOffset(Offset = "0x38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1981F0", Offset = "0x1982F1")]
			private Vector3 <point>k__BackingField;

			// Token: 0x0400B8FB RID: 47355
			[Token(Token = "0x401BABB")]
			[FieldOffset(Offset = "0x44")]
			private float length;

			// Token: 0x0400B8FC RID: 47356
			[Token(Token = "0x401BABC")]
			[FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			// Token: 0x0400B8FD RID: 47357
			[Token(Token = "0x401BABD")]
			[FieldOffset(Offset = "0x4C")]
			private float lastTime;
		}

		// Token: 0x02000D85 RID: 3461
		[Token(Token = "0x200141B")]
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x060059CF RID: 22991 RVA: 0x0001D940 File Offset: 0x0001BB40
			[Token(Token = "0x6007A36")]
			[Address(RVA = "0x2C10410", Offset = "0x2C10511", VA = "0x2C10410", Slot = "4")]
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x060059D0 RID: 22992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A37")]
			[Address(RVA = "0x2C10590", Offset = "0x2C10691", VA = "0x2C10590", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060059D1 RID: 22993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A38")]
			[Address(RVA = "0x2C10620", Offset = "0x2C10721", VA = "0x2C10620", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060059D2 RID: 22994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A39")]
			[Address(RVA = "0x2C10950", Offset = "0x2C10A51", VA = "0x2C10950")]
			public HitPointEffector()
			{
			}

			// Token: 0x0400B8FE RID: 47358
			[Token(Token = "0x401BABE")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198200", Offset = "0x198301")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x0400B8FF RID: 47359
			[Token(Token = "0x401BABF")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198240", Offset = "0x198341")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x0400B900 RID: 47360
			[Token(Token = "0x401BAC0")]
			[FieldOffset(Offset = "0x60")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198280", Offset = "0x198381")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x02000D86 RID: 3462
			[Token(Token = "0x200165E")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x060059D3 RID: 22995 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080BF")]
				[Address(RVA = "0x2C10820", Offset = "0x2C10921", VA = "0x2C10820")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x060059D4 RID: 22996 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C0")]
				[Address(RVA = "0x2C10600", Offset = "0x2C10701", VA = "0x2C10600")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060059D5 RID: 22997 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C1")]
				[Address(RVA = "0x2C10970", Offset = "0x2C10A71", VA = "0x2C10970")]
				public EffectorLink()
				{
				}

				// Token: 0x0400B901 RID: 47361
				[Token(Token = "0x401C433")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1997A0", Offset = "0x1998A1")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400B902 RID: 47362
				[Token(Token = "0x401C434")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x1997E0", Offset = "0x1998E1")]
				public float weight;

				// Token: 0x0400B903 RID: 47363
				[Token(Token = "0x401C435")]
				[FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				// Token: 0x0400B904 RID: 47364
				[Token(Token = "0x401C436")]
				[FieldOffset(Offset = "0x24")]
				private Vector3 current;
			}
		}

		// Token: 0x02000D87 RID: 3463
		[Token(Token = "0x200141C")]
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x060059D6 RID: 22998 RVA: 0x0001D958 File Offset: 0x0001BB58
			[Token(Token = "0x6007A3A")]
			[Address(RVA = "0x2C0FE40", Offset = "0x2C0FF41", VA = "0x2C0FE40", Slot = "4")]
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x060059D7 RID: 22999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A3B")]
			[Address(RVA = "0x2C0FEE0", Offset = "0x2C0FFE1", VA = "0x2C0FEE0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x060059D8 RID: 23000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A3C")]
			[Address(RVA = "0x2C0FF70", Offset = "0x2C10071", VA = "0x2C0FF70", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x060059D9 RID: 23001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A3D")]
			[Address(RVA = "0x2C10350", Offset = "0x2C10451", VA = "0x2C10350")]
			public HitPointBone()
			{
			}

			// Token: 0x0400B905 RID: 47365
			[Token(Token = "0x401BAC1")]
			[FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x1982C0", Offset = "0x1983C1")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x0400B906 RID: 47366
			[Token(Token = "0x401BAC2")]
			[FieldOffset(Offset = "0x58")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198300", Offset = "0x198401")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x0400B907 RID: 47367
			[Token(Token = "0x401BAC3")]
			[FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			// Token: 0x02000D88 RID: 3464
			[Token(Token = "0x200165F")]
			[Serializable]
			public class BoneLink
			{
				// Token: 0x060059DA RID: 23002 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C2")]
				[Address(RVA = "0x2C101E0", Offset = "0x2C102E1", VA = "0x2C101E0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x060059DB RID: 23003 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C3")]
				[Address(RVA = "0x2C0FF50", Offset = "0x2C10051", VA = "0x2C0FF50")]
				public void CrossFadeStart()
				{
				}

				// Token: 0x060059DC RID: 23004 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080C4")]
				[Address(RVA = "0x2C10370", Offset = "0x2C10471", VA = "0x2C10370")]
				public BoneLink()
				{
				}

				// Token: 0x0400B908 RID: 47368
				[Token(Token = "0x401C437")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199820", Offset = "0x199921")]
				public Transform bone;

				// Token: 0x0400B909 RID: 47369
				[Token(Token = "0x401C438")]
				[FieldOffset(Offset = "0x18")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199860", Offset = "0x199961")]
				[Attribute(Name = "RangeAttribute", RVA = "0x199860", Offset = "0x199961")]
				public float weight;

				// Token: 0x0400B90A RID: 47370
				[Token(Token = "0x401C439")]
				[FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				// Token: 0x0400B90B RID: 47371
				[Token(Token = "0x401C43A")]
				[FieldOffset(Offset = "0x2C")]
				private Quaternion current;
			}
		}
	}
}
