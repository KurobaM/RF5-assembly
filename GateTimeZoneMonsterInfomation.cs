using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200067A RID: 1658
[Token(Token = "0x200049D")]
[Serializable]
public class GateTimeZoneMonsterInfomation
{
	// Token: 0x0600290D RID: 10509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x1FA4230", Offset = "0x1FA4331", VA = "0x1FA4230")]
	public GateTimeZoneMonsterInfomation()
	{
	}

	// Token: 0x040070AB RID: 28843
	[Token(Token = "0x40068A9")]
	[FieldOffset(Offset = "0x10")]
	public int HourMin;

	// Token: 0x040070AC RID: 28844
	[Token(Token = "0x40068AA")]
	[FieldOffset(Offset = "0x14")]
	public int HourMax;

	// Token: 0x040070AD RID: 28845
	[Token(Token = "0x40068AB")]
	[FieldOffset(Offset = "0x18")]
	public Weather Weather;

	// Token: 0x040070AE RID: 28846
	[Token(Token = "0x40068AC")]
	[FieldOffset(Offset = "0x1C")]
	public int Selectivity;

	// Token: 0x040070AF RID: 28847
	[Token(Token = "0x40068AD")]
	[FieldOffset(Offset = "0x20")]
	public MonsterDataID MonsterDataID;

	// Token: 0x040070B0 RID: 28848
	[Token(Token = "0x40068AE")]
	[FieldOffset(Offset = "0x24")]
	public int SpawnPoint;
}
