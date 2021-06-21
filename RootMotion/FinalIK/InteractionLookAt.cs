using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D59 RID: 3417
	[Token(Token = "0x20008CB")]
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x06005897 RID: 22679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497C")]
		[Address(RVA = "0x2CDC940", Offset = "0x2CDCA41", VA = "0x2CDC940")]
		public void Look(Transform target, float time)
		{
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497D")]
		[Address(RVA = "0x2CDCAD0", Offset = "0x2CDCBD1", VA = "0x2CDCAD0")]
		public void OnFixTransforms()
		{
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497E")]
		[Address(RVA = "0x2CDCB80", Offset = "0x2CDCC81", VA = "0x2CDCB80")]
		public void Update()
		{
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600497F")]
		[Address(RVA = "0x2CDCDE0", Offset = "0x2CDCEE1", VA = "0x2CDCDE0")]
		public void SolveSpine()
		{
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004980")]
		[Address(RVA = "0x2CDCEE0", Offset = "0x2CDCFE1", VA = "0x2CDCEE0")]
		public void SolveHead()
		{
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004981")]
		[Address(RVA = "0x2CDCFB0", Offset = "0x2CDD0B1", VA = "0x2CDCFB0")]
		public InteractionLookAt()
		{
		}

		// Token: 0x0400B803 RID: 47107
		[Token(Token = "0x40089E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B0D0", Offset = "0x17B1D1")]
		public LookAtIK ik;

		// Token: 0x0400B804 RID: 47108
		[Token(Token = "0x40089E6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B110", Offset = "0x17B211")]
		public float lerpSpeed;

		// Token: 0x0400B805 RID: 47109
		[Token(Token = "0x40089E7")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17B150", Offset = "0x17B251")]
		public float weightSpeed;

		// Token: 0x0400B806 RID: 47110
		[Token(Token = "0x40089E8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HideInInspector", RVA = "0x17B190", Offset = "0x17B291")]
		public bool isPaused;

		// Token: 0x0400B807 RID: 47111
		[Token(Token = "0x40089E9")]
		[FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		// Token: 0x0400B808 RID: 47112
		[Token(Token = "0x40089EA")]
		[FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		// Token: 0x0400B809 RID: 47113
		[Token(Token = "0x40089EB")]
		[FieldOffset(Offset = "0x34")]
		private float weight;

		// Token: 0x0400B80A RID: 47114
		[Token(Token = "0x40089EC")]
		[FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;
	}
}
