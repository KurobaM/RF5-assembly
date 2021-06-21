using System;
using Common;
using Il2CppDummyDll;

// Token: 0x02000681 RID: 1665
[Token(Token = "0x20004A4")]
[Serializable]
public class MonsterActionBehaviorData
{
	// Token: 0x06002913 RID: 10515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x1D830A0", Offset = "0x1D831A1", VA = "0x1D830A0")]
	public MonsterActionBehaviorData()
	{
	}

	// Token: 0x040070C8 RID: 28872
	[Token(Token = "0x40068C6")]
	[FieldOffset(Offset = "0x10")]
	public MonsterActionBehaviorDataID ActionBehaviorDataID;

	// Token: 0x040070C9 RID: 28873
	[Token(Token = "0x40068C7")]
	[FieldOffset(Offset = "0x14")]
	public bool IsAttack;

	// Token: 0x040070CA RID: 28874
	[Token(Token = "0x40068C8")]
	[FieldOffset(Offset = "0x18")]
	public int Raito;

	// Token: 0x040070CB RID: 28875
	[Token(Token = "0x40068C9")]
	[FieldOffset(Offset = "0x1C")]
	public ComparisonCharacterParameterType ComparisonCharacterParameterType;

	// Token: 0x040070CC RID: 28876
	[Token(Token = "0x40068CA")]
	[FieldOffset(Offset = "0x20")]
	public ComparisonOperatorsType ComparisonOperatorsType;

	// Token: 0x040070CD RID: 28877
	[Token(Token = "0x40068CB")]
	[FieldOffset(Offset = "0x24")]
	public int ComparisonValue;

	// Token: 0x040070CE RID: 28878
	[Token(Token = "0x40068CC")]
	[FieldOffset(Offset = "0x28")]
	public bool IsOnlyFirst;
}
