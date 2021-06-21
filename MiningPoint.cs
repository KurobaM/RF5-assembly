using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Farm;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x0200056D RID: 1389
[Token(Token = "0x20003E9")]
public class MiningPoint : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, PlowInteractionInterface, ToolInteractionInterface, SlashInteractionInterface, SmashInteractionInterface, ChopInteractionInterface
{
	// Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x1D72650", Offset = "0x1D72751", VA = "0x1D72650")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x1D726D0", Offset = "0x1D727D1", VA = "0x1D726D0", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x06002188 RID: 8584 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
	[Token(Token = "0x17000460")]
	public bool Focusable
	{
		[Token(Token = "0x6001C5C")]
		[Address(RVA = "0x1D72920", Offset = "0x1D72A21", VA = "0x1D72920", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A07E0", Offset = "0x1A08E1")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x1D72930", Offset = "0x1D72A31", VA = "0x1D72930", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x1D729B0", Offset = "0x1D72AB1", VA = "0x1D729B0", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x1D729C0", Offset = "0x1D72AC1", VA = "0x1D729C0", Slot = "22")]
	public void DoPlow(HumanController humanController)
	{
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x0000DC08 File Offset: 0x0000BE08
	[Token(Token = "0x6001C60")]
	[Address(RVA = "0x1D73680", Offset = "0x1D73781", VA = "0x1D73680", Slot = "23")]
	public bool CanPlow(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C61")]
	[Address(RVA = "0x1D73760", Offset = "0x1D73861", VA = "0x1D73760", Slot = "24")]
	public void DoSlash(HumanController humanController)
	{
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x0000DC20 File Offset: 0x0000BE20
	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x1D73A10", Offset = "0x1D73B11", VA = "0x1D73A10", Slot = "25")]
	public bool CanSlash(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x0000DC38 File Offset: 0x0000BE38
	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x1D73B50", Offset = "0x1D73C51", VA = "0x1D73B50", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x1D73B60", Offset = "0x1D73C61", VA = "0x1D73B60", Slot = "26")]
	public void DoSmash(HumanController humanController)
	{
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x0000DC50 File Offset: 0x0000BE50
	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x1D73B70", Offset = "0x1D73C71", VA = "0x1D73B70", Slot = "27")]
	public bool CanSmash(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x0000DC68 File Offset: 0x0000BE68
	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x1D73B80", Offset = "0x1D73C81", VA = "0x1D73B80", Slot = "29")]
	public bool CanBreak(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x1D73C40", Offset = "0x1D73D41", VA = "0x1D73C40", Slot = "28")]
	public void DoBreak(HumanController humanController)
	{
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x0000DC80 File Offset: 0x0000BE80
	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x1D74500", Offset = "0x1D74601", VA = "0x1D74500", Slot = "31")]
	public bool CanChop(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C69")]
	[Address(RVA = "0x1D745B0", Offset = "0x1D746B1", VA = "0x1D745B0", Slot = "30")]
	public void DoChop(HumanController humanController)
	{
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C6A")]
	[Address(RVA = "0x1D74830", Offset = "0x1D74931", VA = "0x1D74830", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x0000DC98 File Offset: 0x0000BE98
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x1D74880", Offset = "0x1D74981", VA = "0x1D74880", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x1D748D0", Offset = "0x1D749D1", VA = "0x1D748D0", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x1D74D30", Offset = "0x1D74E31", VA = "0x1D74D30", Slot = "19")]
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x1D74D40", Offset = "0x1D74E41", VA = "0x1D74D40", Slot = "20")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x1D74E10", Offset = "0x1D74F11", VA = "0x1D74E10", Slot = "21")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000461")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x1D74E20", Offset = "0x1D74F21", VA = "0x1D74E20")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x0600219D RID: 8605 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
	[Token(Token = "0x17000462")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x1D74E80", Offset = "0x1D74F81", VA = "0x1D74E80", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x0600219E RID: 8606 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
	[Token(Token = "0x17000463")]
	public int FocusPriority
	{
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x1D74E90", Offset = "0x1D74F91", VA = "0x1D74E90", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x0600219F RID: 8607 RVA: 0x0000DD10 File Offset: 0x0000BF10
	[Token(Token = "0x17000464")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x1D74EA0", Offset = "0x1D74FA1", VA = "0x1D74EA0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x1D74460", Offset = "0x1D74561", VA = "0x1D74460")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A07F0", Offset = "0x1A08F1")]
	private IEnumerator MoveAction(HumanController humanController)
	{
		return null;
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x0000DD28 File Offset: 0x0000BF28
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x1D74EE0", Offset = "0x1D74FE1", VA = "0x1D74EE0")]
	private bool IsStump()
	{
		return default(bool);
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x0000DD40 File Offset: 0x0000BF40
	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x1D74F00", Offset = "0x1D75001", VA = "0x1D74F00")]
	private bool IsOre()
	{
		return default(bool);
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x1D74F30", Offset = "0x1D75031", VA = "0x1D74F30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0860", Offset = "0x1A0961")]
	private IEnumerator MoveAction(Vector3 euler)
	{
		return null;
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x1D75000", Offset = "0x1D75101", VA = "0x1D75000")]
	public void MoveAcrtion(Vector2 euler)
	{
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x0000DD58 File Offset: 0x0000BF58
	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x1D74220", Offset = "0x1D74321", VA = "0x1D74220")]
	private ItemID dropItemLottery()
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x1D72BF0", Offset = "0x1D72CF1", VA = "0x1D72BF0")]
	private void dropItem(ItemID itemId, int skillLv, int toolLv, bool isSpread = true)
	{
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x0000DD70 File Offset: 0x0000BF70
	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x1D73460", Offset = "0x1D73561", VA = "0x1D73460")]
	public bool checkDestroyItem()
	{
		return default(bool);
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x0000DD88 File Offset: 0x0000BF88
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x1D741A0", Offset = "0x1D742A1", VA = "0x1D741A0")]
	private bool rfCalcOreKuzuCheck(int kuzu_rate, int skill_lv, int hammer_lv)
	{
		return default(bool);
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x1D742B0", Offset = "0x1D743B1", VA = "0x1D742B0")]
	private bool rfCalcOreDoubleCheck(int skill_lv, int hammer_lv)
	{
		return default(bool);
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x1D74310", Offset = "0x1D74411", VA = "0x1D74310")]
	private bool rfCalcOreRareCheck(int skill_lv, int hammer_lv)
	{
		return default(bool);
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x1D743E0", Offset = "0x1D744E1", VA = "0x1D743E0")]
	private bool rfCalcOreBreakCheck(int break_rate, int skill_lv, int hammer_lv)
	{
		return default(bool);
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x1D74A20", Offset = "0x1D74B21", VA = "0x1D74A20")]
	private void Harvest(HumanController chracter, bool isItemInteraction)
	{
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x1D738F0", Offset = "0x1D739F1", VA = "0x1D738F0")]
	private void CreateRuneBall(bool isFlower)
	{
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x1D725C0", Offset = "0x1D726C1", VA = "0x1D725C0")]
	public void CreateMiningPoint4Farm()
	{
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x1D754C0", Offset = "0x1D755C1", VA = "0x1D754C0")]
	public void CreateMiningPoint4Field()
	{
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x1D75120", Offset = "0x1D75221", VA = "0x1D75120")]
	public void CreateMiningPoint()
	{
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x1D758B0", Offset = "0x1D759B1", VA = "0x1D758B0")]
	private bool CheckMereor()
	{
		return default(bool);
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x1D75AF0", Offset = "0x1D75BF1", VA = "0x1D75AF0")]
	private void Start()
	{
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x1D75B20", Offset = "0x1D75C21", VA = "0x1D75B20")]
	private void OnEnable()
	{
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x1D75C80", Offset = "0x1D75D81", VA = "0x1D75C80")]
	private void Update()
	{
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x1D75D60", Offset = "0x1D75E61", VA = "0x1D75D60", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x0000DE00 File Offset: 0x0000C000
	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x1D75D70", Offset = "0x1D75E71", VA = "0x1D75D70", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x1D75D80", Offset = "0x1D75E81", VA = "0x1D75D80")]
	public MiningPoint()
	{
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x1D75DF0", Offset = "0x1D75EF1", VA = "0x1D75DF0", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x1D75E00", Offset = "0x1D75F01", VA = "0x1D75E00", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x0000DE18 File Offset: 0x0000C018
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x1D75E10", Offset = "0x1D75F11", VA = "0x1D75E10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A08D0", Offset = "0x1A09D1")]
	private bool <dropItem>b__54_1(RaycastHit dat)
	{
		return default(bool);
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x1D75ED0", Offset = "0x1D75FD1", VA = "0x1D75ED0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A08E0", Offset = "0x1A09E1")]
	private void <CreateMiningPoint>b__64_0(GameObject obj)
	{
	}

	// Token: 0x04006A1B RID: 27163
	[Token(Token = "0x40063DD")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x166420", Offset = "0x166521")]
	[SerializeField]
	private GameObject MiningModelObject;

	// Token: 0x04006A1C RID: 27164
	[Token(Token = "0x40063DE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CapsuleCollider capsuleCollider;

	// Token: 0x04006A1D RID: 27165
	[Token(Token = "0x40063DF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CapsuleCollider capsuleCollider_child;

	// Token: 0x04006A1E RID: 27166
	[Token(Token = "0x40063E0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem KirakiraEffect;

	// Token: 0x04006A1F RID: 27167
	[Token(Token = "0x40063E1")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x1664A0", Offset = "0x1665A1")]
	[SerializeField]
	public string MiningPointIDName;

	// Token: 0x04006A20 RID: 27168
	[Token(Token = "0x40063E2")]
	[FieldOffset(Offset = "0x40")]
	public FarmManager.FARM_ID FarmId;

	// Token: 0x04006A21 RID: 27169
	[Token(Token = "0x40063E3")]
	[FieldOffset(Offset = "0x44")]
	public int UniqueId;

	// Token: 0x04006A22 RID: 27170
	[Token(Token = "0x40063E4")]
	[FieldOffset(Offset = "0x48")]
	private MiningID miningID;

	// Token: 0x04006A23 RID: 27171
	[Token(Token = "0x40063E5")]
	[FieldOffset(Offset = "0x4C")]
	public MineTypeID mineType;

	// Token: 0x04006A24 RID: 27172
	[Token(Token = "0x40063E6")]
	[FieldOffset(Offset = "0x50")]
	public MineTypeDataTable mineTypeDataTable;

	// Token: 0x04006A25 RID: 27173
	[Token(Token = "0x40063E7")]
	[FieldOffset(Offset = "0x90")]
	public CropID cropId;

	// Token: 0x04006A26 RID: 27174
	[Token(Token = "0x40063E8")]
	[FieldOffset(Offset = "0x98")]
	private CropDataTable cropDataTable;

	// Token: 0x04006A27 RID: 27175
	[Token(Token = "0x40063E9")]
	[FieldOffset(Offset = "0x188")]
	public bool isFieldItem;

	// Token: 0x04006A28 RID: 27176
	[Token(Token = "0x40063EA")]
	[FieldOffset(Offset = "0x189")]
	private bool isInit;

	// Token: 0x04006A29 RID: 27177
	[Token(Token = "0x40063EB")]
	[FieldOffset(Offset = "0x190")]
	private GameObject miningObject;

	// Token: 0x04006A2A RID: 27178
	[Token(Token = "0x40063EC")]
	[FieldOffset(Offset = "0x198")]
	public Prefab prefabID;

	// Token: 0x04006A2B RID: 27179
	[Token(Token = "0x40063ED")]
	[FieldOffset(Offset = "0x19C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1664F0", Offset = "0x1665F1")]
	private readonly bool <Focusable>k__BackingField;

	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200110D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E90", Offset = "0x157F91")]
	private sealed class <MoveAction>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007017")]
		[Address(RVA = "0x1D74EB0", Offset = "0x1D74FB1", VA = "0x1D74EB0")]
		[DebuggerHidden]
		public <MoveAction>d__48(int <>1__state)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007018")]
		[Address(RVA = "0x1D76400", Offset = "0x1D76501", VA = "0x1D76400", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0000DE30 File Offset: 0x0000C030
		[Token(Token = "0x6007019")]
		[Address(RVA = "0x1D76410", Offset = "0x1D76511", VA = "0x1D76410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC9")]
		private object Current
		{
			[Token(Token = "0x600701A")]
			[Address(RVA = "0x1D76620", Offset = "0x1D76721", VA = "0x1D76620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701B")]
		[Address(RVA = "0x1D76630", Offset = "0x1D76731", VA = "0x1D76630", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCA")]
		private object Current
		{
			[Token(Token = "0x600701C")]
			[Address(RVA = "0x1D76690", Offset = "0x1D76791", VA = "0x1D76690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A2C RID: 27180
		[Token(Token = "0x40192B1")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A2D RID: 27181
		[Token(Token = "0x40192B2")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A2E RID: 27182
		[Token(Token = "0x40192B3")]
		[FieldOffset(Offset = "0x20")]
		public MiningPoint <>4__this;

		// Token: 0x04006A2F RID: 27183
		[Token(Token = "0x40192B4")]
		[FieldOffset(Offset = "0x28")]
		public HumanController humanController;

		// Token: 0x04006A30 RID: 27184
		[Token(Token = "0x40192B5")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 <basePos>5__2;
	}

	// Token: 0x0200056F RID: 1391
	[Token(Token = "0x200110E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157EA0", Offset = "0x157FA1")]
	private sealed class <MoveAction>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060021C2 RID: 8642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701D")]
		[Address(RVA = "0x1D74FD0", Offset = "0x1D750D1", VA = "0x1D74FD0")]
		[DebuggerHidden]
		public <MoveAction>d__51(int <>1__state)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600701E")]
		[Address(RVA = "0x1D766A0", Offset = "0x1D767A1", VA = "0x1D766A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0000DE48 File Offset: 0x0000C048
		[Token(Token = "0x600701F")]
		[Address(RVA = "0x1D766B0", Offset = "0x1D767B1", VA = "0x1D766B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCB")]
		private object Current
		{
			[Token(Token = "0x6007020")]
			[Address(RVA = "0x1D76AF0", Offset = "0x1D76BF1", VA = "0x1D76AF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007021")]
		[Address(RVA = "0x1D76B00", Offset = "0x1D76C01", VA = "0x1D76B00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCC")]
		private object Current
		{
			[Token(Token = "0x6007022")]
			[Address(RVA = "0x1D76B60", Offset = "0x1D76C61", VA = "0x1D76B60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006A31 RID: 27185
		[Token(Token = "0x40192B6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006A32 RID: 27186
		[Token(Token = "0x40192B7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006A33 RID: 27187
		[Token(Token = "0x40192B8")]
		[FieldOffset(Offset = "0x20")]
		public MiningPoint <>4__this;

		// Token: 0x04006A34 RID: 27188
		[Token(Token = "0x40192B9")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 euler;

		// Token: 0x04006A35 RID: 27189
		[Token(Token = "0x40192BA")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 <basePos>5__2;
	}

	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x200110F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157EB0", Offset = "0x157FB1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060021C9 RID: 8649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007024")]
		[Address(RVA = "0x1D760B0", Offset = "0x1D761B1", VA = "0x1D760B0")]
		public <>c()
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0000DE60 File Offset: 0x0000C060
		[Token(Token = "0x6007025")]
		[Address(RVA = "0x1D760C0", Offset = "0x1D761C1", VA = "0x1D760C0")]
		internal float <dropItem>b__54_0(RaycastHit dat)
		{
			return 0f;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0000DE78 File Offset: 0x0000C078
		[Token(Token = "0x6007026")]
		[Address(RVA = "0x1D760D0", Offset = "0x1D761D1", VA = "0x1D760D0")]
		internal bool <dropItem>b__54_2(RaycastHit dat)
		{
			return default(bool);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0000DE90 File Offset: 0x0000C090
		[Token(Token = "0x6007027")]
		[Address(RVA = "0x1D76110", Offset = "0x1D76211", VA = "0x1D76110")]
		internal bool <dropItem>b__54_3(RaycastHit dat)
		{
			return default(bool);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x6007028")]
		[Address(RVA = "0x1D76240", Offset = "0x1D76341", VA = "0x1D76240")]
		internal bool <dropItem>b__54_4(RaycastHit dat)
		{
			return default(bool);
		}

		// Token: 0x04006A36 RID: 27190
		[Token(Token = "0x40192BB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MiningPoint.<>c <>9;

		// Token: 0x04006A37 RID: 27191
		[Token(Token = "0x40192BC")]
		[FieldOffset(Offset = "0x8")]
		public static Func<RaycastHit, float> <>9__54_0;

		// Token: 0x04006A38 RID: 27192
		[Token(Token = "0x40192BD")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<RaycastHit> <>9__54_2;

		// Token: 0x04006A39 RID: 27193
		[Token(Token = "0x40192BE")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<RaycastHit> <>9__54_3;

		// Token: 0x04006A3A RID: 27194
		[Token(Token = "0x40192BF")]
		[FieldOffset(Offset = "0x20")]
		public static Func<RaycastHit, bool> <>9__54_4;
	}

	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2001110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157EC0", Offset = "0x157FC1")]
	private sealed class <>c__DisplayClass61_0
	{
		// Token: 0x060021CE RID: 8654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007029")]
		[Address(RVA = "0x1D75110", Offset = "0x1D75211", VA = "0x1D75110")]
		public <>c__DisplayClass61_0()
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702A")]
		[Address(RVA = "0x1D762E0", Offset = "0x1D763E1", VA = "0x1D762E0")]
		internal void <CreateRuneBall>b__0(GameObject obj)
		{
		}

		// Token: 0x04006A3B RID: 27195
		[Token(Token = "0x40192C0")]
		[FieldOffset(Offset = "0x10")]
		public bool isFlower;

		// Token: 0x04006A3C RID: 27196
		[Token(Token = "0x40192C1")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 position;

		// Token: 0x04006A3D RID: 27197
		[Token(Token = "0x40192C2")]
		[FieldOffset(Offset = "0x20")]
		public MiningPoint <>4__this;
	}
}
