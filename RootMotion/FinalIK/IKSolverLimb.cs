using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D45 RID: 3397
	[Token(Token = "0x20008C5")]
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x0600579E RID: 22430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x257CE10", Offset = "0x257CF11", VA = "0x257CE10")]
		public void MaintainRotation()
		{
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x257CE60", Offset = "0x257CF61", VA = "0x257CE60")]
		public void MaintainBend()
		{
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x257CF80", Offset = "0x257D081", VA = "0x257CF80", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490C")]
		[Address(RVA = "0x257D640", Offset = "0x257D741", VA = "0x257D640", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x257E260", Offset = "0x257E361", VA = "0x257E260", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490E")]
		[Address(RVA = "0x257E3D0", Offset = "0x257E4D1", VA = "0x257E3D0")]
		public IKSolverLimb()
		{
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490F")]
		[Address(RVA = "0x257E590", Offset = "0x257E691", VA = "0x257E590")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D8")]
		private IKSolverLimb.AxisDirection[] axisDirections
		{
			[Token(Token = "0x6004910")]
			[Address(RVA = "0x257E630", Offset = "0x257E731", VA = "0x257E630")]
			get
			{
				return null;
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x257D2F0", Offset = "0x257D3F1", VA = "0x257D2F0")]
		private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections)
		{
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x0001CCC8 File Offset: 0x0001AEC8
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x257D790", Offset = "0x257D891", VA = "0x257D790")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}

		// Token: 0x0400B6C3 RID: 46787
		[Token(Token = "0x400896A")]
		[FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		// Token: 0x0400B6C4 RID: 46788
		[Token(Token = "0x400896B")]
		[FieldOffset(Offset = "0xAC")]
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x0400B6C5 RID: 46789
		[Token(Token = "0x400896C")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AB90", Offset = "0x17AC91")]
		public float maintainRotationWeight;

		// Token: 0x0400B6C6 RID: 46790
		[Token(Token = "0x400896D")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17ABB0", Offset = "0x17ACB1")]
		public float bendModifierWeight;

		// Token: 0x0400B6C7 RID: 46791
		[Token(Token = "0x400896E")]
		[FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		// Token: 0x0400B6C8 RID: 46792
		[Token(Token = "0x400896F")]
		[FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		// Token: 0x0400B6C9 RID: 46793
		[Token(Token = "0x4008970")]
		[FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		// Token: 0x0400B6CA RID: 46794
		[Token(Token = "0x4008971")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		// Token: 0x0400B6CB RID: 46795
		[Token(Token = "0x4008972")]
		[FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		// Token: 0x0400B6CC RID: 46796
		[Token(Token = "0x4008973")]
		[FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x0400B6CD RID: 46797
		[Token(Token = "0x4008974")]
		[FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		// Token: 0x0400B6CE RID: 46798
		[Token(Token = "0x4008975")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		// Token: 0x0400B6CF RID: 46799
		[Token(Token = "0x4008976")]
		[FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		// Token: 0x0400B6D0 RID: 46800
		[Token(Token = "0x4008977")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		// Token: 0x0400B6D1 RID: 46801
		[Token(Token = "0x4008978")]
		[FieldOffset(Offset = "0x130")]
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft;

		// Token: 0x0400B6D2 RID: 46802
		[Token(Token = "0x4008979")]
		[FieldOffset(Offset = "0x138")]
		private IKSolverLimb.AxisDirection[] axisDirectionsRight;

		// Token: 0x02000D46 RID: 3398
		[Token(Token = "0x20013F9")]
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x0400B6D4 RID: 46804
			[Token(Token = "0x401B99E")]
			Animation,
			// Token: 0x0400B6D5 RID: 46805
			[Token(Token = "0x401B99F")]
			Target,
			// Token: 0x0400B6D6 RID: 46806
			[Token(Token = "0x401B9A0")]
			Parent,
			// Token: 0x0400B6D7 RID: 46807
			[Token(Token = "0x401B9A1")]
			Arm,
			// Token: 0x0400B6D8 RID: 46808
			[Token(Token = "0x401B9A2")]
			Goal
		}

		// Token: 0x02000D47 RID: 3399
		[Token(Token = "0x20013FA")]
		[Serializable]
		public struct AxisDirection
		{
			// Token: 0x060057A8 RID: 22440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600795F")]
			[Address(RVA = "0x30C960", Offset = "0x30CA61", VA = "0x30C960")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}

			// Token: 0x0400B6D9 RID: 46809
			[Token(Token = "0x401B9A3")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			// Token: 0x0400B6DA RID: 46810
			[Token(Token = "0x401B9A4")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			// Token: 0x0400B6DB RID: 46811
			[Token(Token = "0x401B9A5")]
			[FieldOffset(Offset = "0x18")]
			public float dot;
		}
	}
}
