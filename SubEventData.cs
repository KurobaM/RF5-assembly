using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x020004AD RID: 1197
[Token(Token = "0x2000379")]
public class SubEventData
{
	// Token: 0x06001D30 RID: 7472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001941")]
	[Address(RVA = "0x238F5D0", Offset = "0x238F6D1", VA = "0x238F5D0")]
	public SubEventData()
	{
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001942")]
	[Address(RVA = "0x238F6D0", Offset = "0x238F7D1", VA = "0x238F6D0")]
	private void NpcAdvStepOff()
	{
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001943")]
	[Address(RVA = "0x238F930", Offset = "0x238FA31", VA = "0x238F930")]
	public void ChangeStep(int step, [Optional] Action<SubEventMasterDataBase, int> call)
	{
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001944")]
	[Address(RVA = "0x238F9F0", Offset = "0x238FAF1", VA = "0x238F9F0")]
	public void InitializeNpcAdvSteps()
	{
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x238FAA0", Offset = "0x238FBA1", VA = "0x238FAA0")]
	public void UpdateNpcAdvSteps()
	{
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001946")]
	[Address(RVA = "0x238FAB0", Offset = "0x238FBB1", VA = "0x238FAB0")]
	public void ApplyNpcAdvSteps()
	{
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001947")]
	[Address(RVA = "0x238FAC0", Offset = "0x238FBC1", VA = "0x238FAC0")]
	public void ApplyText()
	{
	}

	// Token: 0x040062CE RID: 25294
	[Token(Token = "0x4005DB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SubEventMasterDataBase MasterData;

	// Token: 0x040062CF RID: 25295
	[Token(Token = "0x4005DB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SubEventSaveParameter SaveParameter;

	// Token: 0x040062D0 RID: 25296
	[Token(Token = "0x4005DB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<int, int> NpcAdvSteps;

	// Token: 0x040062D1 RID: 25297
	[Token(Token = "0x4005DBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string Title;

	// Token: 0x040062D2 RID: 25298
	[Token(Token = "0x4005DBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string Explain;

	// Token: 0x040062D3 RID: 25299
	[Token(Token = "0x4005DBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[NonSerialized]
	private List<int> tempList;
}
