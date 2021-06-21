using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A18 RID: 2584
[Token(Token = "0x20006C5")]
public class FriendsMenuStatusDisp : MonoBehaviour
{
	// Token: 0x17000934 RID: 2356
	// (get) Token: 0x060043AA RID: 17322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000760")]
	public CursorLinker CharaModelCursor
	{
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x23D2B50", Offset = "0x23D2C51", VA = "0x23D2B50")]
		get
		{
			return null;
		}
	}

	// Token: 0x060043AB RID: 17323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003897")]
	[Address(RVA = "0x23D2B60", Offset = "0x23D2C61", VA = "0x23D2B60")]
	private void InitLoveGaguge()
	{
	}

	// Token: 0x060043AC RID: 17324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003898")]
	[Address(RVA = "0x23D2DF0", Offset = "0x23D2EF1", VA = "0x23D2DF0")]
	private void SetLoveGauge(int loveLv, bool isCanbeLover)
	{
	}

	// Token: 0x17000935 RID: 2357
	// (get) Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000761")]
	private UIModelLoader PlayerEquipModelLoader
	{
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x23D3000", Offset = "0x23D3101", VA = "0x23D3000")]
		get
		{
			return null;
		}
	}

	// Token: 0x060043AE RID: 17326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389A")]
	[Address(RVA = "0x23D3060", Offset = "0x23D3161", VA = "0x23D3060")]
	private void OnDisable()
	{
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389B")]
	[Address(RVA = "0x23CEFC0", Offset = "0x23CF0C1", VA = "0x23CEFC0")]
	public void SetStatusNPC(ActorID actor_id)
	{
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389C")]
	[Address(RVA = "0x23CF530", Offset = "0x23CF631", VA = "0x23CF530")]
	public void SetStatusMonster(FriendMonsterStatus FriendMonsterStatusController)
	{
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389D")]
	[Address(RVA = "0x23D1590", Offset = "0x23D1691", VA = "0x23D1590")]
	public void SetStatusMonster(HandCuffsStatus FriendMonsterStatusController, MonsterDataTable monsterDataTable)
	{
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600389E")]
	[Address(RVA = "0x23D30D0", Offset = "0x23D31D1", VA = "0x23D30D0")]
	public FriendsMenuStatusDisp()
	{
	}

	// Token: 0x0400A291 RID: 41617
	[Token(Token = "0x4007AD0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text Txt_Name;

	// Token: 0x0400A292 RID: 41618
	[Token(Token = "0x4007AD1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Txt_Discription;

	// Token: 0x0400A293 RID: 41619
	[Token(Token = "0x4007AD2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIEquipSlot[] EquipSlot;

	// Token: 0x0400A294 RID: 41620
	[Token(Token = "0x4007AD3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image LoveGauge;

	// Token: 0x0400A295 RID: 41621
	[Token(Token = "0x4007AD4")]
	[FieldOffset(Offset = "0x38")]
	private List<Image> LoveGauges;

	// Token: 0x0400A296 RID: 41622
	[Token(Token = "0x4007AD5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite NoLoveSprite;

	// Token: 0x0400A297 RID: 41623
	[Token(Token = "0x4007AD6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite LikeSprite;

	// Token: 0x0400A298 RID: 41624
	[Token(Token = "0x4007AD7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite LoveSprite;

	// Token: 0x0400A299 RID: 41625
	[Token(Token = "0x4007AD8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CursorLinker charaModelCursor;

	// Token: 0x0400A29A RID: 41626
	[Token(Token = "0x4007AD9")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<ActorID> CanbeLoverMaleList;

	// Token: 0x0400A29B RID: 41627
	[Token(Token = "0x4007ADA")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<ActorID> CanbeLoverFemaleList;
}
