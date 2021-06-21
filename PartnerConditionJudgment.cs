using System;
using Il2CppDummyDll;

// Token: 0x020002AE RID: 686
[Token(Token = "0x200021D")]
public class PartnerConditionJudgment
{
	// Token: 0x060011CE RID: 4558 RVA: 0x00008280 File Offset: 0x00006480
	[Token(Token = "0x6001038")]
	[Address(RVA = "0x23200A0", Offset = "0x23201A1", VA = "0x23200A0")]
	public static bool CheckPartnerConditionJudgment(int npcid, int lovelv, int eventType = -1, int eventStep1 = -1, int eventStep2 = -1)
	{
		return default(bool);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00008298 File Offset: 0x00006498
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x2320320", Offset = "0x2320421", VA = "0x2320320")]
	public static bool CheckCharacterToPartnerJudgment(int npcid)
	{
		return default(bool);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x23205D0", Offset = "0x23206D1", VA = "0x23205D0")]
	public static void CheckBeInvitedJudgment(int npcid)
	{
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x000082B0 File Offset: 0x000064B0
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x2320800", Offset = "0x2320901", VA = "0x2320800")]
	public static bool GetBeInvitedFlg()
	{
		return default(bool);
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x2320870", Offset = "0x2320971", VA = "0x2320870")]
	public static void SetBeInvitedFlg(bool value)
	{
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x23208E0", Offset = "0x23209E1", VA = "0x23208E0")]
	public PartnerConditionJudgment()
	{
	}

	// Token: 0x04000A0B RID: 2571
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x0")]
	private static bool BeInvitedFlg;
}
