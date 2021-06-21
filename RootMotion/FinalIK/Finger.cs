using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D01 RID: 3329
	[Token(Token = "0x2000893")]
	[Serializable]
	public class Finger
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A6")]
		public bool initiated
		{
			[Token(Token = "0x60046DF")]
			[Address(RVA = "0x2C01030", Offset = "0x2C01131", VA = "0x2C01030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9A80", Offset = "0x1A9B81")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046E0")]
			[Address(RVA = "0x2C01040", Offset = "0x2C01141", VA = "0x2C01040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9A90", Offset = "0x1A9B91")]
			private set
			{
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		// (set) Token: 0x060054FE RID: 21758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A7")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60046E1")]
			[Address(RVA = "0x2C01050", Offset = "0x2C01151", VA = "0x2C01050")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60046E2")]
			[Address(RVA = "0x2C01070", Offset = "0x2C01171", VA = "0x2C01070")]
			set
			{
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x0001BFF0 File Offset: 0x0001A1F0
		// (set) Token: 0x06005500 RID: 21760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A8")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60046E3")]
			[Address(RVA = "0x2C010A0", Offset = "0x2C011A1", VA = "0x2C010A0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60046E4")]
			[Address(RVA = "0x2C010C0", Offset = "0x2C011C1", VA = "0x2C010C0")]
			set
			{
			}
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x0001C008 File Offset: 0x0001A208
		[Token(Token = "0x60046E5")]
		[Address(RVA = "0x2C010F0", Offset = "0x2C011F1", VA = "0x2C010F0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x2C01210", Offset = "0x2C01311", VA = "0x2C01210")]
		public void Initiate(Transform hand, int index)
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x2C01930", Offset = "0x2C01A31", VA = "0x2C01930")]
		public void FixTransforms()
		{
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x2C01A10", Offset = "0x2C01B11", VA = "0x2C01A10")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x2C01AE0", Offset = "0x2C01BE1", VA = "0x2C01AE0")]
		public void Update(float masterWeight)
		{
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x2C022F0", Offset = "0x2C023F1", VA = "0x2C022F0")]
		public Finger()
		{
		}

		// Token: 0x0400B46D RID: 46189
		[Token(Token = "0x400878F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178820", Offset = "0x178921")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178820", Offset = "0x178921")]
		public float weight;

		// Token: 0x0400B46E RID: 46190
		[Token(Token = "0x4008790")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178880", Offset = "0x178981")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178880", Offset = "0x178981")]
		public float rotationWeight;

		// Token: 0x0400B46F RID: 46191
		[Token(Token = "0x4008791")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1788E0", Offset = "0x1789E1")]
		public Finger.DOF rotationDOF;

		// Token: 0x0400B470 RID: 46192
		[Token(Token = "0x4008792")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178920", Offset = "0x178A21")]
		public bool fixBone1Twist;

		// Token: 0x0400B471 RID: 46193
		[Token(Token = "0x4008793")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178960", Offset = "0x178A61")]
		public Transform bone1;

		// Token: 0x0400B472 RID: 46194
		[Token(Token = "0x4008794")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1789A0", Offset = "0x178AA1")]
		public Transform bone2;

		// Token: 0x0400B473 RID: 46195
		[Token(Token = "0x4008795")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1789E0", Offset = "0x178AE1")]
		public Transform bone3;

		// Token: 0x0400B474 RID: 46196
		[Token(Token = "0x4008796")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178A20", Offset = "0x178B21")]
		public Transform tip;

		// Token: 0x0400B475 RID: 46197
		[Token(Token = "0x4008797")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178A60", Offset = "0x178B61")]
		public Transform target;

		// Token: 0x0400B476 RID: 46198
		[Token(Token = "0x4008798")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x178AA0", Offset = "0x178BA1")]
		private bool <initiated>k__BackingField;

		// Token: 0x0400B477 RID: 46199
		[Token(Token = "0x4008799")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		// Token: 0x0400B478 RID: 46200
		[Token(Token = "0x400879A")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		// Token: 0x0400B479 RID: 46201
		[Token(Token = "0x400879B")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x0400B47A RID: 46202
		[Token(Token = "0x400879C")]
		[FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		// Token: 0x0400B47B RID: 46203
		[Token(Token = "0x400879D")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		// Token: 0x0400B47C RID: 46204
		[Token(Token = "0x400879E")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		// Token: 0x0400B47D RID: 46205
		[Token(Token = "0x400879F")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		// Token: 0x02000D02 RID: 3330
		[Token(Token = "0x20013E7")]
		[Serializable]
		public enum DOF
		{
			// Token: 0x0400B47F RID: 46207
			[Token(Token = "0x401B923")]
			One,
			// Token: 0x0400B480 RID: 46208
			[Token(Token = "0x401B924")]
			Three
		}
	}
}
