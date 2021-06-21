using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x20008E6")]
	public class Recoil : OffsetModifier
	{
		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[Token(Token = "0x170008F6")]
		public bool isFinished
		{
			[Token(Token = "0x6004A81")]
			[Address(RVA = "0x27C9410", Offset = "0x27C9511", VA = "0x27C9410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A82")]
		[Address(RVA = "0x27C9440", Offset = "0x27C9541", VA = "0x27C9440")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A83")]
		[Address(RVA = "0x27C9480", Offset = "0x27C9581", VA = "0x27C9480")]
		public void Fire(float magnitude)
		{
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A84")]
		[Address(RVA = "0x27C9710", Offset = "0x27C9811", VA = "0x27C9710", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A85")]
		[Address(RVA = "0x27CA790", Offset = "0x27CA891", VA = "0x27CA790")]
		private void AfterFBBIK()
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x27CA970", Offset = "0x27CAA71", VA = "0x27CA970")]
		private void AfterAimIK()
		{
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F7")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6004A87")]
			[Address(RVA = "0x27CA710", Offset = "0x27CA811", VA = "0x27CA710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06005A3B RID: 23099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F8")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6004A88")]
			[Address(RVA = "0x27CA750", Offset = "0x27CA851", VA = "0x27CA750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008F9")]
		private Transform primaryHand
		{
			[Token(Token = "0x6004A89")]
			[Address(RVA = "0x27CA670", Offset = "0x27CA771", VA = "0x27CA670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FA")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6004A8A")]
			[Address(RVA = "0x27CA6C0", Offset = "0x27CA7C1", VA = "0x27CA6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x27CA9B0", Offset = "0x27CAAB1", VA = "0x27CA9B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x27CAB80", Offset = "0x27CAC81", VA = "0x27CAB80")]
		public Recoil()
		{
		}

		// Token: 0x0400B973 RID: 47475
		[Token(Token = "0x4008A91")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C770", Offset = "0x17C871")]
		public AimIK aimIK;

		// Token: 0x0400B974 RID: 47476
		[Token(Token = "0x4008A92")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C7B0", Offset = "0x17C8B1")]
		public bool aimIKSolvedLast;

		// Token: 0x0400B975 RID: 47477
		[Token(Token = "0x4008A93")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C7F0", Offset = "0x17C8F1")]
		public Recoil.Handedness handedness;

		// Token: 0x0400B976 RID: 47478
		[Token(Token = "0x4008A94")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C830", Offset = "0x17C931")]
		public bool twoHanded;

		// Token: 0x0400B977 RID: 47479
		[Token(Token = "0x4008A95")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C870", Offset = "0x17C971")]
		public AnimationCurve recoilWeight;

		// Token: 0x0400B978 RID: 47480
		[Token(Token = "0x4008A96")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C8B0", Offset = "0x17C9B1")]
		public float magnitudeRandom;

		// Token: 0x0400B979 RID: 47481
		[Token(Token = "0x4008A97")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C8F0", Offset = "0x17C9F1")]
		public Vector3 rotationRandom;

		// Token: 0x0400B97A RID: 47482
		[Token(Token = "0x4008A98")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C930", Offset = "0x17CA31")]
		public Vector3 handRotationOffset;

		// Token: 0x0400B97B RID: 47483
		[Token(Token = "0x4008A99")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C970", Offset = "0x17CA71")]
		public float blendTime;

		// Token: 0x0400B97C RID: 47484
		[Token(Token = "0x4008A9A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "SpaceAttribute", RVA = "0x17C9B0", Offset = "0x17CAB1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17C9B0", Offset = "0x17CAB1")]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x0400B97D RID: 47485
		[Token(Token = "0x4008A9B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HideInInspector", RVA = "0x17CA00", Offset = "0x17CB01")]
		public Quaternion rotationOffset;

		// Token: 0x0400B97E RID: 47486
		[Token(Token = "0x4008A9C")]
		[FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		// Token: 0x0400B97F RID: 47487
		[Token(Token = "0x4008A9D")]
		[FieldOffset(Offset = "0x8C")]
		private float endTime;

		// Token: 0x0400B980 RID: 47488
		[Token(Token = "0x4008A9E")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		// Token: 0x0400B981 RID: 47489
		[Token(Token = "0x4008A9F")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		// Token: 0x0400B982 RID: 47490
		[Token(Token = "0x4008AA0")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		// Token: 0x0400B983 RID: 47491
		[Token(Token = "0x4008AA1")]
		[FieldOffset(Offset = "0xC0")]
		private float length;

		// Token: 0x0400B984 RID: 47492
		[Token(Token = "0x4008AA2")]
		[FieldOffset(Offset = "0xC4")]
		private bool initiated;

		// Token: 0x0400B985 RID: 47493
		[Token(Token = "0x4008AA3")]
		[FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		// Token: 0x0400B986 RID: 47494
		[Token(Token = "0x4008AA4")]
		[FieldOffset(Offset = "0xCC")]
		private float w;

		// Token: 0x0400B987 RID: 47495
		[Token(Token = "0x4008AA5")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		// Token: 0x0400B988 RID: 47496
		[Token(Token = "0x4008AA6")]
		[FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		// Token: 0x0400B989 RID: 47497
		[Token(Token = "0x4008AA7")]
		[FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		// Token: 0x02000D9E RID: 3486
		[Token(Token = "0x2001426")]
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x06005A40 RID: 23104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A6D")]
			[Address(RVA = "0x27C9660", Offset = "0x27C9761", VA = "0x27C9660")]
			public void Start()
			{
			}

			// Token: 0x06005A41 RID: 23105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A6E")]
			[Address(RVA = "0x27CA3F0", Offset = "0x27CA4F1", VA = "0x27CA3F0")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			// Token: 0x06005A42 RID: 23106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A6F")]
			[Address(RVA = "0x27CAC50", Offset = "0x27CAD51", VA = "0x27CAC50")]
			public RecoilOffset()
			{
			}

			// Token: 0x0400B98A RID: 47498
			[Token(Token = "0x401BAFE")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198BD0", Offset = "0x198CD1")]
			public Vector3 offset;

			// Token: 0x0400B98B RID: 47499
			[Token(Token = "0x401BAFF")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198C10", Offset = "0x198D11")]
			[Attribute(Name = "RangeAttribute", RVA = "0x198C10", Offset = "0x198D11")]
			public float additivity;

			// Token: 0x0400B98C RID: 47500
			[Token(Token = "0x401BB00")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198C70", Offset = "0x198D71")]
			public float maxAdditiveOffsetMag;

			// Token: 0x0400B98D RID: 47501
			[Token(Token = "0x401BB01")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198CB0", Offset = "0x198DB1")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x0400B98E RID: 47502
			[Token(Token = "0x401BB02")]
			[FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			// Token: 0x0400B98F RID: 47503
			[Token(Token = "0x401BB03")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			// Token: 0x02000D9F RID: 3487
			[Token(Token = "0x2001664")]
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06005A43 RID: 23107 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CD")]
				[Address(RVA = "0x27CAC70", Offset = "0x27CAD71", VA = "0x27CAC70")]
				public EffectorLink()
				{
				}

				// Token: 0x0400B990 RID: 47504
				[Token(Token = "0x401C447")]
				[FieldOffset(Offset = "0x10")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199AE0", Offset = "0x199BE1")]
				public FullBodyBipedEffector effector;

				// Token: 0x0400B991 RID: 47505
				[Token(Token = "0x401C448")]
				[FieldOffset(Offset = "0x14")]
				[Attribute(Name = "TooltipAttribute", RVA = "0x199B20", Offset = "0x199C21")]
				public float weight;
			}
		}

		// Token: 0x02000DA0 RID: 3488
		[Token(Token = "0x2001427")]
		[Serializable]
		public enum Handedness
		{
			// Token: 0x0400B993 RID: 47507
			[Token(Token = "0x401BB05")]
			Right,
			// Token: 0x0400B994 RID: 47508
			[Token(Token = "0x401BB06")]
			Left
		}
	}
}
