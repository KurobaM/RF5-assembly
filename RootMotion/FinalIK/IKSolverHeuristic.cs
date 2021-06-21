using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D43 RID: 3395
	[Token(Token = "0x20008C3")]
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x06005780 RID: 22400 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x257ADA0", Offset = "0x257AEA1", VA = "0x257ADA0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x257AF60", Offset = "0x257B061", VA = "0x257AF60")]
		public void AddBone(Transform bone)
		{
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x257B0E0", Offset = "0x257B1E1", VA = "0x257B0E0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x257B190", Offset = "0x257B291", VA = "0x257B190", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x257B210", Offset = "0x257B311", VA = "0x257B210", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x257B5A0", Offset = "0x257B6A1", VA = "0x257B5A0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x257B5B0", Offset = "0x257B6B1", VA = "0x257B5B0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		[Token(Token = "0x170008D3")]
		protected virtual int minBones
		{
			[Token(Token = "0x60048F2")]
			[Address(RVA = "0x257B6B0", Offset = "0x257B7B1", VA = "0x257B6B0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06005788 RID: 22408 RVA: 0x0001CC08 File Offset: 0x0001AE08
		[Token(Token = "0x170008D4")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60048F3")]
			[Address(RVA = "0x257B6C0", Offset = "0x257B7C1", VA = "0x257B6C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x0001CC20 File Offset: 0x0001AE20
		[Token(Token = "0x170008D5")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60048F4")]
			[Address(RVA = "0x257B6D0", Offset = "0x257B7D1", VA = "0x257B6D0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x257B6E0", Offset = "0x257B7E1", VA = "0x257B6E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x257B6F0", Offset = "0x257B7F1", VA = "0x257B6F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x25709F0", Offset = "0x2570AF1", VA = "0x25709F0")]
		protected void InitiateBones()
		{
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x0001CC38 File Offset: 0x0001AE38
		[Token(Token = "0x170008D6")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60048F8")]
			[Address(RVA = "0x257B700", Offset = "0x257B801", VA = "0x257B700", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x0001CC50 File Offset: 0x0001AE50
		[Token(Token = "0x170008D7")]
		protected float positionOffset
		{
			[Token(Token = "0x60048F9")]
			[Address(RVA = "0x2571600", Offset = "0x2571701", VA = "0x2571600")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x0001CC68 File Offset: 0x0001AE68
		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x2571270", Offset = "0x2571371", VA = "0x2571270")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x0001CC80 File Offset: 0x0001AE80
		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x257B840", Offset = "0x257B941", VA = "0x257B840")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048FC")]
		[Address(RVA = "0x256F5C0", Offset = "0x256F6C1", VA = "0x256F5C0")]
		public IKSolverHeuristic()
		{
		}

		// Token: 0x0400B6B0 RID: 46768
		[Token(Token = "0x4008957")]
		[FieldOffset(Offset = "0x58")]
		public Transform target;

		// Token: 0x0400B6B1 RID: 46769
		[Token(Token = "0x4008958")]
		[FieldOffset(Offset = "0x60")]
		public float tolerance;

		// Token: 0x0400B6B2 RID: 46770
		[Token(Token = "0x4008959")]
		[FieldOffset(Offset = "0x64")]
		public int maxIterations;

		// Token: 0x0400B6B3 RID: 46771
		[Token(Token = "0x400895A")]
		[FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		// Token: 0x0400B6B4 RID: 46772
		[Token(Token = "0x400895B")]
		[FieldOffset(Offset = "0x69")]
		public bool XY;

		// Token: 0x0400B6B5 RID: 46773
		[Token(Token = "0x400895C")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Bone[] bones;

		// Token: 0x0400B6B6 RID: 46774
		[Token(Token = "0x400895D")]
		[FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		// Token: 0x0400B6B7 RID: 46775
		[Token(Token = "0x400895E")]
		[FieldOffset(Offset = "0x84")]
		protected float chainLength;
	}
}
