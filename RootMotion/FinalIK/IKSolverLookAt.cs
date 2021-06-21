using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D48 RID: 3400
	[Token(Token = "0x20008C6")]
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		// Token: 0x060057A9 RID: 22441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x257E6C0", Offset = "0x257E7C1", VA = "0x257E6C0")]
		public void SetLookAtWeight(float weight)
		{
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x257E750", Offset = "0x257E851", VA = "0x257E750")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x257E800", Offset = "0x257E901", VA = "0x257E800")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x257E8E0", Offset = "0x257E9E1", VA = "0x257E8E0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004917")]
		[Address(RVA = "0x257E9D0", Offset = "0x257EAD1", VA = "0x257E9D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004918")]
		[Address(RVA = "0x257EAF0", Offset = "0x257EBF1", VA = "0x257EAF0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004919")]
		[Address(RVA = "0x257EC50", Offset = "0x257ED51", VA = "0x257EC50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491A")]
		[Address(RVA = "0x257EE10", Offset = "0x257EF11", VA = "0x257EE10", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		[Token(Token = "0x600491B")]
		[Address(RVA = "0x257EF50", Offset = "0x257F051", VA = "0x257EF50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491C")]
		[Address(RVA = "0x257F480", Offset = "0x257F581", VA = "0x257F480", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x257F720", Offset = "0x257F821", VA = "0x257F720", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x257F8A0", Offset = "0x257F9A1", VA = "0x257F8A0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x257FB50", Offset = "0x257FC51", VA = "0x257FB50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x257FFF0", Offset = "0x25800F1", VA = "0x257FFF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060057B7 RID: 22455 RVA: 0x0001CD10 File Offset: 0x0001AF10
		[Token(Token = "0x170008D9")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6004921")]
			[Address(RVA = "0x257F150", Offset = "0x257F251", VA = "0x257F150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x0001CD28 File Offset: 0x0001AF28
		[Token(Token = "0x170008DA")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6004922")]
			[Address(RVA = "0x257F3A0", Offset = "0x257F4A1", VA = "0x257F3A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x2580100", Offset = "0x2580201", VA = "0x2580100")]
		protected void SolveSpine()
		{
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060057BA RID: 22458 RVA: 0x0001CD40 File Offset: 0x0001AF40
		[Token(Token = "0x170008DB")]
		protected bool headIsValid
		{
			[Token(Token = "0x6004924")]
			[Address(RVA = "0x257F270", Offset = "0x257F371", VA = "0x257F270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060057BB RID: 22459 RVA: 0x0001CD58 File Offset: 0x0001AF58
		[Token(Token = "0x170008DC")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6004925")]
			[Address(RVA = "0x257F3D0", Offset = "0x257F4D1", VA = "0x257F3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x2580330", Offset = "0x2580431", VA = "0x2580330")]
		protected void SolveHead()
		{
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060057BD RID: 22461 RVA: 0x0001CD70 File Offset: 0x0001AF70
		[Token(Token = "0x170008DD")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6004927")]
			[Address(RVA = "0x257F280", Offset = "0x257F381", VA = "0x257F280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x0001CD88 File Offset: 0x0001AF88
		[Token(Token = "0x170008DE")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6004928")]
			[Address(RVA = "0x257F450", Offset = "0x257F551", VA = "0x257F450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x25805E0", Offset = "0x25806E1", VA = "0x25805E0")]
		protected void SolveEyes()
		{
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x2580B20", Offset = "0x2580C21", VA = "0x2580B20")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x257F970", Offset = "0x257FA71", VA = "0x257F970")]
		protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones)
		{
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x2580FE0", Offset = "0x25810E1", VA = "0x2580FE0")]
		public IKSolverLookAt()
		{
		}

		// Token: 0x0400B6DC RID: 46812
		[Token(Token = "0x400897A")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x0400B6DD RID: 46813
		[Token(Token = "0x400897B")]
		[FieldOffset(Offset = "0x60")]
		public IKSolverLookAt.LookAtBone[] spine;

		// Token: 0x0400B6DE RID: 46814
		[Token(Token = "0x400897C")]
		[FieldOffset(Offset = "0x68")]
		public IKSolverLookAt.LookAtBone head;

		// Token: 0x0400B6DF RID: 46815
		[Token(Token = "0x400897D")]
		[FieldOffset(Offset = "0x70")]
		public IKSolverLookAt.LookAtBone[] eyes;

		// Token: 0x0400B6E0 RID: 46816
		[Token(Token = "0x400897E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17ABD0", Offset = "0x17ACD1")]
		public float bodyWeight;

		// Token: 0x0400B6E1 RID: 46817
		[Token(Token = "0x400897F")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17ABF0", Offset = "0x17ACF1")]
		public float headWeight;

		// Token: 0x0400B6E2 RID: 46818
		[Token(Token = "0x4008980")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AC10", Offset = "0x17AD11")]
		public float eyesWeight;

		// Token: 0x0400B6E3 RID: 46819
		[Token(Token = "0x4008981")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AC30", Offset = "0x17AD31")]
		public float clampWeight;

		// Token: 0x0400B6E4 RID: 46820
		[Token(Token = "0x4008982")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AC50", Offset = "0x17AD51")]
		public float clampWeightHead;

		// Token: 0x0400B6E5 RID: 46821
		[Token(Token = "0x4008983")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AC70", Offset = "0x17AD71")]
		public float clampWeightEyes;

		// Token: 0x0400B6E6 RID: 46822
		[Token(Token = "0x4008984")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AC90", Offset = "0x17AD91")]
		public int clampSmoothing;

		// Token: 0x0400B6E7 RID: 46823
		[Token(Token = "0x4008985")]
		[FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		// Token: 0x0400B6E8 RID: 46824
		[Token(Token = "0x4008986")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		// Token: 0x0400B6E9 RID: 46825
		[Token(Token = "0x4008987")]
		[FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		// Token: 0x0400B6EA RID: 46826
		[Token(Token = "0x4008988")]
		[FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		// Token: 0x0400B6EB RID: 46827
		[Token(Token = "0x4008989")]
		[FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		// Token: 0x02000D49 RID: 3401
		[Token(Token = "0x20013FB")]
		[Serializable]
		public class LookAtBone : IKSolver.Bone
		{
			// Token: 0x060057C3 RID: 22467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007960")]
			[Address(RVA = "0x2581240", Offset = "0x2581341", VA = "0x2581240")]
			public LookAtBone()
			{
			}

			// Token: 0x060057C4 RID: 22468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007961")]
			[Address(RVA = "0x257FB20", Offset = "0x257FC21", VA = "0x257FB20")]
			public LookAtBone(Transform transform)
			{
			}

			// Token: 0x060057C5 RID: 22469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007962")]
			[Address(RVA = "0x257FEB0", Offset = "0x257FFB1", VA = "0x257FEB0")]
			public void Initiate(Transform root)
			{
			}

			// Token: 0x060057C6 RID: 22470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007963")]
			[Address(RVA = "0x2580E70", Offset = "0x2580F71", VA = "0x2580E70")]
			public void LookAt(Vector3 direction, float weight)
			{
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x060057C7 RID: 22471 RVA: 0x0001CDA0 File Offset: 0x0001AFA0
			[Token(Token = "0x17000E15")]
			public Vector3 forward
			{
				[Token(Token = "0x6007964")]
				[Address(RVA = "0x2580A50", Offset = "0x2580B51", VA = "0x2580A50")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x0400B6EC RID: 46828
			[Token(Token = "0x401B9A6")]
			[FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;
		}
	}
}
