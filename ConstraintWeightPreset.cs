using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Serialize;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x02000221 RID: 545
[Token(Token = "0x20001B9")]
public class ConstraintWeightPreset : MonoBehaviour
{
	// Token: 0x06000C7F RID: 3199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x20E18E0", Offset = "0x20E19E1", VA = "0x20E18E0")]
	private void Start()
	{
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B28")]
	[Address(RVA = "0x20E1970", Offset = "0x20E1A71", VA = "0x20E1970")]
	public void UpdateWeight()
	{
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B29")]
	[Address(RVA = "0x20E1C40", Offset = "0x20E1D41", VA = "0x20E1C40")]
	public void Set(ConstraintPresetID presetId)
	{
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2A")]
	[Address(RVA = "0x20E1CD0", Offset = "0x20E1DD1", VA = "0x20E1CD0")]
	public void ConstraintWeight(string name)
	{
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B2B")]
	[Address(RVA = "0x20E1DC0", Offset = "0x20E1EC1", VA = "0x20E1DC0")]
	public ConstraintWeightPreset()
	{
	}

	// Token: 0x04000764 RID: 1892
	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ConstraintWeightPreset.Constraint[] constraints;

	// Token: 0x04000765 RID: 1893
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ConstraintWeightPreset.WeightPreset weightPresets;

	// Token: 0x04000766 RID: 1894
	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float speed;

	// Token: 0x04000767 RID: 1895
	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x30")]
	private List<float> targetWeights;

	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000FF1")]
	[Serializable]
	public class Constraint
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDC")]
		public IConstraint constraint
		{
			[Token(Token = "0x6006C43")]
			[Address(RVA = "0x20E1B80", Offset = "0x20E1C81", VA = "0x20E1B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C44")]
		[Address(RVA = "0x20E1ED0", Offset = "0x20E1FD1", VA = "0x20E1ED0")]
		public Constraint()
		{
		}

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4018DDB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject constraintObject;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4018DDC")]
		[FieldOffset(Offset = "0x18")]
		private IConstraint _constraint;
	}

	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000FF2")]
	[Serializable]
	public class WeightPreset : TableBase<ConstraintPresetID, List<float>, ConstraintWeightPreset.WeightPresetPair>
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C45")]
		[Address(RVA = "0x20E1E80", Offset = "0x20E1F81", VA = "0x20E1E80")]
		public WeightPreset()
		{
		}
	}

	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000FF3")]
	[Serializable]
	public class WeightPresetPair : KeyAndValue<ConstraintPresetID, List<float>>
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C46")]
		[Address(RVA = "0x20E1EE0", Offset = "0x20E1FE1", VA = "0x20E1EE0")]
		public WeightPresetPair(ConstraintPresetID key, List<float> value)
		{
		}
	}
}
