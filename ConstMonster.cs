using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000356 RID: 854
[Token(Token = "0x2000285")]
public class ConstMonster : ScriptableObject
{
	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06001665 RID: 5733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700039D")]
	public static ConstMonster Instance
	{
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x20E0E30", Offset = "0x20E0F31", VA = "0x20E0E30")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x20E0F40", Offset = "0x20E1041", VA = "0x20E0F40")]
	public ConstMonster()
	{
	}

	// Token: 0x04000E60 RID: 3680
	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Tame_UpRate_Brushing;

	// Token: 0x04000E61 RID: 3681
	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int Tame_MaxCount_Brushing;

	// Token: 0x04000E62 RID: 3682
	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float Tame_UpRate_Present;

	// Token: 0x04000E63 RID: 3683
	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int Tame_MaxCount_Present;

	// Token: 0x04000E64 RID: 3684
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float Tame_UpRate_SkillLevel;

	// Token: 0x04000E65 RID: 3685
	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int Tame_Max_SkillLevel;

	// Token: 0x04000E66 RID: 3686
	[Token(Token = "0x4000B47")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float Tame_UpRate_LoveAttributeAttack;

	// Token: 0x04000E67 RID: 3687
	[Token(Token = "0x4000B48")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int Tame_MaxCount_LoveAttributeAttack;

	// Token: 0x04000E68 RID: 3688
	[Token(Token = "0x4000B49")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float Tame_DownRate_DiffLevel;

	// Token: 0x04000E69 RID: 3689
	[Token(Token = "0x4000B4A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int Tame_HalfRate_Max_SameMonsterCount;

	// Token: 0x04000E6A RID: 3690
	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float Tame_Min_Rate;

	// Token: 0x04000E6B RID: 3691
	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float Tame_Boss_Max_Rate;

	// Token: 0x04000E6C RID: 3692
	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x0")]
	private static ConstMonster _Instance;
}
