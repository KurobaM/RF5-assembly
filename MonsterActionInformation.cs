using System;
using Il2CppDummyDll;

// Token: 0x0200067E RID: 1662
[Token(Token = "0x20004A1")]
[Serializable]
public class MonsterActionInformation : MonsterActionInformationBase
{
	// Token: 0x0600290F RID: 10511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B2")]
	[Address(RVA = "0x1D837D0", Offset = "0x1D838D1", VA = "0x1D837D0")]
	public MonsterActionInformation()
	{
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x1D837F0", Offset = "0x1D838F1", VA = "0x1D837F0")]
	public MonsterActionInformation(MonsterActionInformation information)
	{
	}

	// Token: 0x040070BB RID: 28859
	[Token(Token = "0x40068B9")]
	[FieldOffset(Offset = "0x1C")]
	public MonsterActionCategory Category;

	// Token: 0x040070BC RID: 28860
	[Token(Token = "0x40068BA")]
	[FieldOffset(Offset = "0x20")]
	public bool IsFavorite;

	// Token: 0x040070BD RID: 28861
	[Token(Token = "0x40068BB")]
	[FieldOffset(Offset = "0x24")]
	public float MinRange;

	// Token: 0x040070BE RID: 28862
	[Token(Token = "0x40068BC")]
	[FieldOffset(Offset = "0x28")]
	public float MaxRange;

	// Token: 0x040070BF RID: 28863
	[Token(Token = "0x40068BD")]
	[FieldOffset(Offset = "0x2C")]
	public float MinInterval;

	// Token: 0x040070C0 RID: 28864
	[Token(Token = "0x40068BE")]
	[FieldOffset(Offset = "0x30")]
	public float MaxInterval;
}
