using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000682 RID: 1666
[Token(Token = "0x20004A5")]
[Serializable]
public class MonsterActionData
{
	// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x1D83470", Offset = "0x1D83571", VA = "0x1D83470")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x1D82ED0", Offset = "0x1D82FD1", VA = "0x1D82ED0")]
	public MonsterActionInformation GetActionInformation(int actionTypeNo)
	{
		return null;
	}

	// Token: 0x06002916 RID: 10518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x1D835F0", Offset = "0x1D836F1", VA = "0x1D835F0")]
	public MonsterActionInformationBase GetActionInformationBase(int actionTypeNo)
	{
		return null;
	}

	// Token: 0x06002917 RID: 10519 RVA: 0x00010170 File Offset: 0x0000E370
	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x1D83660", Offset = "0x1D83761", VA = "0x1D83660")]
	public Master GetActionCodeArrayDataID()
	{
		return Master.NONE;
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x00010188 File Offset: 0x0000E388
	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x1D83710", Offset = "0x1D83811", VA = "0x1D83710")]
	private static Master StringToID(string idName)
	{
		return Master.NONE;
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x1D837C0", Offset = "0x1D838C1", VA = "0x1D837C0")]
	public MonsterActionData()
	{
	}

	// Token: 0x040070CF RID: 28879
	[Token(Token = "0x40068CD")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x168B00", Offset = "0x168C01")]
	public string ActionCodeArrayDataTableName;

	// Token: 0x040070D0 RID: 28880
	[Token(Token = "0x40068CE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterActionInformation[] ActionInformationArray;

	// Token: 0x040070D1 RID: 28881
	[Token(Token = "0x40068CF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public MonsterActionInformationBase[] ActionInformationBaseArray;

	// Token: 0x040070D2 RID: 28882
	[Token(Token = "0x40068D0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public MonsterActionInformation B_Button_Information;

	// Token: 0x040070D3 RID: 28883
	[Token(Token = "0x40068D1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public MonsterActionInformation X_Button_Information;

	// Token: 0x040070D4 RID: 28884
	[Token(Token = "0x40068D2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public MonsterActionInformation Y_Button_Information;

	// Token: 0x040070D5 RID: 28885
	[Token(Token = "0x40068D3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public List<MonsterActionBehaviorData> ActionBehaviorDataList;

	// Token: 0x040070D6 RID: 28886
	[Token(Token = "0x40068D4")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<int, MonsterActionInformation> ActionInformationDic;

	// Token: 0x040070D7 RID: 28887
	[Token(Token = "0x40068D5")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<int, MonsterActionInformationBase> ActionInformationBaseDic;
}
