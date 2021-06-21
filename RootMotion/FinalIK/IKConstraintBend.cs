using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x20008B3")]
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x06005676 RID: 22134 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[Token(Token = "0x6004816")]
		[Address(RVA = "0x2C11E30", Offset = "0x2C11F31", VA = "0x2C11E30")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x0001C710 File Offset: 0x0001A910
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B8")]
		public bool initiated
		{
			[Token(Token = "0x6004817")]
			[Address(RVA = "0x2C12000", Offset = "0x2C12101", VA = "0x2C12000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB80", Offset = "0x1AAC81")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004818")]
			[Address(RVA = "0x2C12010", Offset = "0x2C12111", VA = "0x2C12010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AAB90", Offset = "0x1AAC91")]
			private set
			{
			}
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004819")]
		[Address(RVA = "0x2C12020", Offset = "0x2C12121", VA = "0x2C12020")]
		public IKConstraintBend()
		{
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481A")]
		[Address(RVA = "0x2C120B0", Offset = "0x2C121B1", VA = "0x2C120B0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481B")]
		[Address(RVA = "0x2C12180", Offset = "0x2C12281", VA = "0x2C12180")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481C")]
		[Address(RVA = "0x2C121D0", Offset = "0x2C122D1", VA = "0x2C121D0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481D")]
		[Address(RVA = "0x2C126C0", Offset = "0x2C127C1", VA = "0x2C126C0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600481E")]
		[Address(RVA = "0x2C12900", Offset = "0x2C12A01", VA = "0x2C12900")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x0001C728 File Offset: 0x0001A928
		[Token(Token = "0x600481F")]
		[Address(RVA = "0x2C12DA0", Offset = "0x2C12EA1", VA = "0x2C12DA0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x0001C740 File Offset: 0x0001A940
		[Token(Token = "0x6004820")]
		[Address(RVA = "0x2C12480", Offset = "0x2C12581", VA = "0x2C12480")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x0001C758 File Offset: 0x0001A958
		[Token(Token = "0x6004821")]
		[Address(RVA = "0x2C125A0", Offset = "0x2C126A1", VA = "0x2C125A0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x0400B5E9 RID: 46569
		[Token(Token = "0x40088BA")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone1;

		// Token: 0x0400B5EA RID: 46570
		[Token(Token = "0x40088BB")]
		[FieldOffset(Offset = "0x18")]
		public Transform bone2;

		// Token: 0x0400B5EB RID: 46571
		[Token(Token = "0x40088BC")]
		[FieldOffset(Offset = "0x20")]
		public Transform bone3;

		// Token: 0x0400B5EC RID: 46572
		[Token(Token = "0x40088BD")]
		[FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		// Token: 0x0400B5ED RID: 46573
		[Token(Token = "0x40088BE")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		// Token: 0x0400B5EE RID: 46574
		[Token(Token = "0x40088BF")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		// Token: 0x0400B5EF RID: 46575
		[Token(Token = "0x40088C0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A840", Offset = "0x17A941")]
		public float weight;

		// Token: 0x0400B5F0 RID: 46576
		[Token(Token = "0x40088C1")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		// Token: 0x0400B5F1 RID: 46577
		[Token(Token = "0x40088C2")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		// Token: 0x0400B5F2 RID: 46578
		[Token(Token = "0x40088C3")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public float clampF;

		// Token: 0x0400B5F3 RID: 46579
		[Token(Token = "0x40088C4")]
		[FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		// Token: 0x0400B5F4 RID: 46580
		[Token(Token = "0x40088C5")]
		[FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		// Token: 0x0400B5F5 RID: 46581
		[Token(Token = "0x40088C6")]
		[FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		// Token: 0x0400B5F6 RID: 46582
		[Token(Token = "0x40088C7")]
		[FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		// Token: 0x0400B5F7 RID: 46583
		[Token(Token = "0x40088C8")]
		[FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		// Token: 0x0400B5F8 RID: 46584
		[Token(Token = "0x40088C9")]
		[FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		// Token: 0x0400B5F9 RID: 46585
		[Token(Token = "0x40088CA")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17A860", Offset = "0x17A961")]
		private bool <initiated>k__BackingField;

		// Token: 0x0400B5FA RID: 46586
		[Token(Token = "0x40088CB")]
		[FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;
	}
}
