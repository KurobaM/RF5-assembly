using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000863 RID: 2147
[Token(Token = "0x2000587")]
[Serializable]
public class UseParameter : ICloneable
{
	// Token: 0x060038CF RID: 14543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F53")]
	[Address(RVA = "0x1E46C60", Offset = "0x1E46D61", VA = "0x1E46C60")]
	public UseParameter()
	{
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F54")]
	[Address(RVA = "0x1E46C70", Offset = "0x1E46D71", VA = "0x1E46C70")]
	public UseParameter(UseParameter other)
	{
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F55")]
	[Address(RVA = "0x1E46D20", Offset = "0x1E46E21", VA = "0x1E46D20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002F56")]
	[Address(RVA = "0x1E46E00", Offset = "0x1E46F01", VA = "0x1E46E00")]
	public UseParameter Copy()
	{
		return null;
	}

	// Token: 0x060038D3 RID: 14547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x1E46F40", Offset = "0x1E47041", VA = "0x1E46F40")]
	public void Add(UseParameter other)
	{
	}

	// Token: 0x060038D4 RID: 14548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x1E470D0", Offset = "0x1E471D1", VA = "0x1E470D0")]
	public void Multi(float value)
	{
	}

	// Token: 0x04007C2A RID: 31786
	[Token(Token = "0x400703D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int HealHp;

	// Token: 0x04007C2B RID: 31787
	[Token(Token = "0x400703E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int HealRp;

	// Token: 0x04007C2C RID: 31788
	[Token(Token = "0x400703F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool Levelup;

	// Token: 0x04007C2D RID: 31789
	[Token(Token = "0x4007040")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float PercentHealHp;

	// Token: 0x04007C2E RID: 31790
	[Token(Token = "0x4007041")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float PercentHealRp;

	// Token: 0x04007C2F RID: 31791
	[Token(Token = "0x4007042")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Parameter Buff;

	// Token: 0x04007C30 RID: 31792
	[Token(Token = "0x4007043")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public FloatParameter BuffPercent;

	// Token: 0x04007C31 RID: 31793
	[Token(Token = "0x4007044")]
	[FieldOffset(Offset = "0x19C")]
	[SerializeField]
	public BadStatus HealBadStatus;

	// Token: 0x04007C32 RID: 31794
	[Token(Token = "0x4007045")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	public BadStatus AddBadStatus;

	// Token: 0x04007C33 RID: 31795
	[Token(Token = "0x4007046")]
	[FieldOffset(Offset = "0x1A4")]
	[SerializeField]
	public Parameter Persistent;
}
