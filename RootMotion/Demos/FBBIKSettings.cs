using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CBB RID: 3259
	[Token(Token = "0x200085D")]
	public class FBBIKSettings : MonoBehaviour
	{
		// Token: 0x060053CA RID: 21450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DE")]
		[Address(RVA = "0x29B3490", Offset = "0x29B3591", VA = "0x29B3490")]
		public void UpdateSettings()
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DF")]
		[Address(RVA = "0x29B3670", Offset = "0x29B3771", VA = "0x29B3670")]
		private void Start()
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E0")]
		[Address(RVA = "0x29B3710", Offset = "0x29B3811", VA = "0x29B3710")]
		private void Update()
		{
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E1")]
		[Address(RVA = "0x29B3720", Offset = "0x29B3821", VA = "0x29B3720")]
		public FBBIKSettings()
		{
		}

		// Token: 0x0400B2BF RID: 45759
		[Token(Token = "0x4008636")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B2C0 RID: 45760
		[Token(Token = "0x4008637")]
		[FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		// Token: 0x0400B2C1 RID: 45761
		[Token(Token = "0x4008638")]
		[FieldOffset(Offset = "0x28")]
		public FBBIKSettings.Limb leftArm;

		// Token: 0x0400B2C2 RID: 45762
		[Token(Token = "0x4008639")]
		[FieldOffset(Offset = "0x30")]
		public FBBIKSettings.Limb rightArm;

		// Token: 0x0400B2C3 RID: 45763
		[Token(Token = "0x400863A")]
		[FieldOffset(Offset = "0x38")]
		public FBBIKSettings.Limb leftLeg;

		// Token: 0x0400B2C4 RID: 45764
		[Token(Token = "0x400863B")]
		[FieldOffset(Offset = "0x40")]
		public FBBIKSettings.Limb rightLeg;

		// Token: 0x0400B2C5 RID: 45765
		[Token(Token = "0x400863C")]
		[FieldOffset(Offset = "0x48")]
		public float rootPin;

		// Token: 0x0400B2C6 RID: 45766
		[Token(Token = "0x400863D")]
		[FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		// Token: 0x02000CBC RID: 3260
		[Token(Token = "0x20013D7")]
		[Serializable]
		public class Limb
		{
			// Token: 0x060053CE RID: 21454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B6")]
			[Address(RVA = "0x29B35E0", Offset = "0x29B36E1", VA = "0x29B35E0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			// Token: 0x060053CF RID: 21455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B7")]
			[Address(RVA = "0x29B3730", Offset = "0x29B3831", VA = "0x29B3730")]
			public Limb()
			{
			}

			// Token: 0x0400B2C7 RID: 45767
			[Token(Token = "0x401B8CD")]
			[FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			// Token: 0x0400B2C8 RID: 45768
			[Token(Token = "0x401B8CE")]
			[FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			// Token: 0x0400B2C9 RID: 45769
			[Token(Token = "0x401B8CF")]
			[FieldOffset(Offset = "0x18")]
			public float mappingWeight;
		}
	}
}
