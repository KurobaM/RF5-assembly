using System;
using Il2CppDummyDll;

// Token: 0x020006BF RID: 1727
[Token(Token = "0x20004D2")]
public class BaffamoController : MonsterControllerBase
{
	// Token: 0x06002A32 RID: 10802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238D")]
	[Address(RVA = "0x229BF30", Offset = "0x229C031", VA = "0x229BF30", Slot = "116")]
	protected override void OnResetActionScriptAction()
	{
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238E")]
	[Address(RVA = "0x229BF70", Offset = "0x229C071", VA = "0x229BF70", Slot = "117")]
	protected override void OnUpdateActionScriptAction()
	{
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600238F")]
	[Address(RVA = "0x229C340", Offset = "0x229C441", VA = "0x229C340")]
	private void OnStopBaffamoCharge()
	{
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002390")]
	[Address(RVA = "0x229C3B0", Offset = "0x229C4B1", VA = "0x229C3B0", Slot = "154")]
	protected virtual void OnResetCharge()
	{
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002391")]
	[Address(RVA = "0x229C440", Offset = "0x229C541", VA = "0x229C440")]
	private void OnStartCharge()
	{
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002392")]
	[Address(RVA = "0x229BFA0", Offset = "0x229C0A1", VA = "0x229BFA0")]
	private void OnUpdateCharge()
	{
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002393")]
	[Address(RVA = "0x229C400", Offset = "0x229C501", VA = "0x229C400")]
	private void OnEndCharge()
	{
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002394")]
	[Address(RVA = "0x229C450", Offset = "0x229C551", VA = "0x229C450")]
	public BaffamoController()
	{
	}

	// Token: 0x04007219 RID: 29209
	[Token(Token = "0x40069D8")]
	[FieldOffset(Offset = "0x4E8")]
	[NonSerialized]
	public BaffamoController.ChargeActionScriptState Baffamo_ChargeActionScriptState;

	// Token: 0x0400721A RID: 29210
	[Token(Token = "0x40069D9")]
	[FieldOffset(Offset = "0x4EC")]
	[NonSerialized]
	public float Baffamo_MaxChargeCurve;

	// Token: 0x0400721B RID: 29211
	[Token(Token = "0x40069DA")]
	[FieldOffset(Offset = "0x4F0")]
	[NonSerialized]
	public float Baffamo_ChargeSpeed;

	// Token: 0x020006C0 RID: 1728
	[Token(Token = "0x2001176")]
	public enum ChargeActionScriptState
	{
		// Token: 0x0400721D RID: 29213
		[Token(Token = "0x40194B5")]
		None,
		// Token: 0x0400721E RID: 29214
		[Token(Token = "0x40194B6")]
		Start,
		// Token: 0x0400721F RID: 29215
		[Token(Token = "0x40194B7")]
		Update,
		// Token: 0x04007220 RID: 29216
		[Token(Token = "0x40194B8")]
		End
	}
}
