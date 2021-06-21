using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x200088B")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x147E40", Offset = "0x147F41")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x147E40", Offset = "0x147F41")]
	public class BipedIK : SolverManager
	{
		// Token: 0x060054C9 RID: 21705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x286CD50", Offset = "0x286CE51", VA = "0x286CD50")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9980", Offset = "0x1A9A81")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x286CDA0", Offset = "0x286CEA1", VA = "0x286CDA0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A99C0", Offset = "0x1A9AC1")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x286CDF0", Offset = "0x286CEF1", VA = "0x286CDF0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9A00", Offset = "0x1A9B01")]
		private void SupportGroup()
		{
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x286CE40", Offset = "0x286CF41", VA = "0x286CE40")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9A40", Offset = "0x1A9B41")]
		private void ASThread()
		{
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x0001BF00 File Offset: 0x0001A100
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x286CE90", Offset = "0x286CF91", VA = "0x286CE90")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x0001BF18 File Offset: 0x0001A118
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x286CFC0", Offset = "0x286D0C1", VA = "0x286CFC0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return 0f;
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x286D060", Offset = "0x286D161", VA = "0x286D060")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B4")]
		[Address(RVA = "0x286D0F0", Offset = "0x286D1F1", VA = "0x286D0F0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B5")]
		[Address(RVA = "0x286D180", Offset = "0x286D281", VA = "0x286D180")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B6")]
		[Address(RVA = "0x286D220", Offset = "0x286D321", VA = "0x286D220")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x0001BF30 File Offset: 0x0001A130
		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x286D2C0", Offset = "0x286D3C1", VA = "0x286D2C0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x0001BF48 File Offset: 0x0001A148
		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x286D350", Offset = "0x286D451", VA = "0x286D350")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x286D3F0", Offset = "0x286D4F1", VA = "0x286D3F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x286D420", Offset = "0x286D521", VA = "0x286D420")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x286D450", Offset = "0x286D551", VA = "0x286D450")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x286D480", Offset = "0x286D581", VA = "0x286D480")]
		public void SetSpineWeight(float weight)
		{
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x286CF30", Offset = "0x286D031", VA = "0x286CF30")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x286D4B0", Offset = "0x286D5B1", VA = "0x286D4B0")]
		public void InitiateBipedIK()
		{
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x286D4C0", Offset = "0x286D5C1", VA = "0x286D4C0")]
		public void UpdateBipedIK()
		{
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x286D4D0", Offset = "0x286D5D1", VA = "0x286D4D0")]
		public void SetToDefaults()
		{
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x286D820", Offset = "0x286D921", VA = "0x286D820", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x286D8D0", Offset = "0x286D9D1", VA = "0x286D8D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x286DC70", Offset = "0x286DD71", VA = "0x286DC70", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x286E1B0", Offset = "0x286E2B1", VA = "0x286E1B0")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x286E1F0", Offset = "0x286E2F1", VA = "0x286E1F0")]
		public BipedIK()
		{
		}

		// Token: 0x0400B44B RID: 46155
		[Token(Token = "0x400876D")]
		[FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		// Token: 0x0400B44C RID: 46156
		[Token(Token = "0x400876E")]
		[FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;
	}
}
