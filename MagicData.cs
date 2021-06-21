using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000391 RID: 913
[Token(Token = "0x20002B9")]
[Serializable]
public class MagicData
{
	// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x1F125A0", Offset = "0x1F126A1", VA = "0x1F125A0")]
	public MagicData()
	{
	}

	// Token: 0x04000FFF RID: 4095
	[Token(Token = "0x4000CB3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string ActionScriptName;

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4000CB4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SkillActionID SkillActionID;

	// Token: 0x04001001 RID: 4097
	[Token(Token = "0x4000CB5")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public SkillActionType SkillActionType;

	// Token: 0x04001002 RID: 4098
	[Token(Token = "0x4000CB6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public EffectID ChargeEffectID;

	// Token: 0x04001003 RID: 4099
	[Token(Token = "0x4000CB7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public MagicSealFrag SealFrag;

	// Token: 0x04001004 RID: 4100
	[Token(Token = "0x4000CB8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public UsageType Usage;

	// Token: 0x04001005 RID: 4101
	[Token(Token = "0x4000CB9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Coexist Coexist;

	// Token: 0x04001006 RID: 4102
	[Token(Token = "0x4000CBA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public MagicTarget Target;

	// Token: 0x04001007 RID: 4103
	[Token(Token = "0x4000CBB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float MinDuration;

	// Token: 0x04001008 RID: 4104
	[Token(Token = "0x4000CBC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float MaxDuration;

	// Token: 0x04001009 RID: 4105
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float AttackRange;

	// Token: 0x0400100A RID: 4106
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float AttackAngleMin;

	// Token: 0x0400100B RID: 4107
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float AttackAngleMax;
}
