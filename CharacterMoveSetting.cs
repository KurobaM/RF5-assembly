using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000353 RID: 851
[Token(Token = "0x2000282")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145AB0", Offset = "0x145BB1")]
public class CharacterMoveSetting : ScriptableObject
{
	// Token: 0x0600165F RID: 5727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x1E8FB70", Offset = "0x1E8FC71", VA = "0x1E8FB70")]
	public CharacterMoveSetting()
	{
	}

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x160EC0", Offset = "0x160FC1")]
	[SerializeField]
	public LayerMask GroundLayer;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public AnimationCurve AccelerationCurve;

	// Token: 0x04000E3C RID: 3644
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public AnimationCurve RotateSpeedCurve;

	// Token: 0x04000E3D RID: 3645
	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float SlopeMax;

	// Token: 0x04000E3E RID: 3646
	[Token(Token = "0x4000B1F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float SlopeMin;

	// Token: 0x04000E3F RID: 3647
	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float SlopeDef;

	// Token: 0x04000E40 RID: 3648
	[Token(Token = "0x4000B21")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float SlopeTimeLimit;

	// Token: 0x04000E41 RID: 3649
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public AnimationCurve SlopeRate;

	// Token: 0x04000E42 RID: 3650
	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float StepMax;

	// Token: 0x04000E43 RID: 3651
	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float AvoidancePower;

	// Token: 0x04000E44 RID: 3652
	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public AnimationCurve AvoidanceDecelRate;

	// Token: 0x04000E45 RID: 3653
	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x160FB0", Offset = "0x1610B1")]
	[SerializeField]
	public AnimationCurve KnockbackPower;

	// Token: 0x04000E46 RID: 3654
	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public AnimationCurve KnockbackDuration;

	// Token: 0x04000E47 RID: 3655
	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x161010", Offset = "0x161111")]
	[SerializeField]
	public AnimationCurve LaunchPower;
}
