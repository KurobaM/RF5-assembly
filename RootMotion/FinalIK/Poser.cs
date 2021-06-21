using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D6E RID: 3438
	[Token(Token = "0x20008D2")]
	public abstract class Poser : SolverManager
	{
		// Token: 0x06005937 RID: 22839
		[Token(Token = "0x60049F9")]
		public abstract void AutoMapping();

		// Token: 0x06005938 RID: 22840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x27C7420", Offset = "0x27C7521", VA = "0x27C7420")]
		public void UpdateManual()
		{
		}

		// Token: 0x06005939 RID: 22841
		[Token(Token = "0x60049FB")]
		protected abstract void InitiatePoser();

		// Token: 0x0600593A RID: 22842
		[Token(Token = "0x60049FC")]
		protected abstract void UpdatePoser();

		// Token: 0x0600593B RID: 22843
		[Token(Token = "0x60049FD")]
		protected abstract void FixPoserTransforms();

		// Token: 0x0600593C RID: 22844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x27C7430", Offset = "0x27C7531", VA = "0x27C7430", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FF")]
		[Address(RVA = "0x27C7490", Offset = "0x27C7591", VA = "0x27C7490", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A00")]
		[Address(RVA = "0x27C74D0", Offset = "0x27C75D1", VA = "0x27C74D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x27C74F0", Offset = "0x27C75F1", VA = "0x27C74F0")]
		protected Poser()
		{
		}

		// Token: 0x0400B878 RID: 47224
		[Token(Token = "0x4008A1F")]
		[FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		// Token: 0x0400B879 RID: 47225
		[Token(Token = "0x4008A20")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B7E0", Offset = "0x17B8E1")]
		public float weight;

		// Token: 0x0400B87A RID: 47226
		[Token(Token = "0x4008A21")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B800", Offset = "0x17B901")]
		public float localRotationWeight;

		// Token: 0x0400B87B RID: 47227
		[Token(Token = "0x4008A22")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17B820", Offset = "0x17B921")]
		public float localPositionWeight;

		// Token: 0x0400B87C RID: 47228
		[Token(Token = "0x4008A23")]
		[FieldOffset(Offset = "0x4C")]
		private bool initiated;
	}
}
