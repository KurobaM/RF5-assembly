using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using RF5SHOP;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000ABA RID: 2746
[Token(Token = "0x2000737")]
public class UIShopController : MonoBehaviour
{
	// Token: 0x1700097F RID: 2431
	// (get) Token: 0x06004756 RID: 18262 RVA: 0x000174D8 File Offset: 0x000156D8
	// (set) Token: 0x06004757 RID: 18263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A1")]
	private NpcShopType shopType
	{
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x1EBBF50", Offset = "0x1EBC051", VA = "0x1EBBF50")]
		get
		{
			return NpcShopType.VarietyShop;
		}
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x1EBBFC0", Offset = "0x1EBC0C1", VA = "0x1EBBFC0")]
		set
		{
		}
	}

	// Token: 0x17000980 RID: 2432
	// (get) Token: 0x06004758 RID: 18264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A2")]
	private NpcShopTable NpcShopTable
	{
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x1EBC030", Offset = "0x1EBC131", VA = "0x1EBC030")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000981 RID: 2433
	// (get) Token: 0x06004759 RID: 18265 RVA: 0x000174F0 File Offset: 0x000156F0
	// (set) Token: 0x0600475A RID: 18266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A3")]
	public NPCID npcId
	{
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x1EBD340", Offset = "0x1EBD441", VA = "0x1EBD340")]
		get
		{
			return NPCID.Ares;
		}
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x1EBD3B0", Offset = "0x1EBD4B1", VA = "0x1EBD3B0")]
		set
		{
		}
	}

	// Token: 0x17000982 RID: 2434
	// (get) Token: 0x0600475B RID: 18267 RVA: 0x00017508 File Offset: 0x00015708
	// (set) Token: 0x0600475C RID: 18268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A4")]
	public static ItemID RestaurantBuyItemId
	{
		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x1EBD420", Offset = "0x1EBD521", VA = "0x1EBD420")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FB0", Offset = "0x1A80B1")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x1EBD490", Offset = "0x1EBD591", VA = "0x1EBD490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FC0", Offset = "0x1A80C1")]
		private set
		{
		}
	}

	// Token: 0x17000983 RID: 2435
	// (get) Token: 0x0600475D RID: 18269 RVA: 0x00017520 File Offset: 0x00015720
	// (set) Token: 0x0600475E RID: 18270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A5")]
	public static bool IsBuyFist
	{
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x1EBD500", Offset = "0x1EBD601", VA = "0x1EBD500")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FD0", Offset = "0x1A80D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x1EBD570", Offset = "0x1EBD671", VA = "0x1EBD570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FE0", Offset = "0x1A80E1")]
		private set
		{
		}
	}

	// Token: 0x17000984 RID: 2436
	// (get) Token: 0x0600475F RID: 18271 RVA: 0x00017538 File Offset: 0x00015738
	// (set) Token: 0x06004760 RID: 18272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A6")]
	public static bool IsBuyRAorMagic
	{
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x1EBD5E0", Offset = "0x1EBD6E1", VA = "0x1EBD5E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7FF0", Offset = "0x1A80F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x1EBD650", Offset = "0x1EBD751", VA = "0x1EBD650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8000", Offset = "0x1A8101")]
		private set
		{
		}
	}

	// Token: 0x17000985 RID: 2437
	// (get) Token: 0x06004761 RID: 18273 RVA: 0x00017550 File Offset: 0x00015750
	// (set) Token: 0x06004762 RID: 18274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007A7")]
	public static bool IsBuyCrystal
	{
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x1EBD6C0", Offset = "0x1EBD7C1", VA = "0x1EBD6C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8010", Offset = "0x1A8111")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x1EBD730", Offset = "0x1EBD831", VA = "0x1EBD730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8020", Offset = "0x1A8121")]
		private set
		{
		}
	}

	// Token: 0x17000986 RID: 2438
	// (get) Token: 0x06004763 RID: 18275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007A8")]
	private string PlayerName
	{
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x1EBD7A0", Offset = "0x1EBD8A1", VA = "0x1EBD7A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000987 RID: 2439
	// (get) Token: 0x06004764 RID: 18276 RVA: 0x00017568 File Offset: 0x00015768
	[Token(Token = "0x170007A9")]
	public static BuilderId LastBounghtBuildId
	{
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x1EBD920", Offset = "0x1EBDA21", VA = "0x1EBD920")]
		get
		{
			return BuilderId.None;
		}
	}

	// Token: 0x06004765 RID: 18277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BDB")]
	[Address(RVA = "0x1EBD990", Offset = "0x1EBDA91", VA = "0x1EBD990")]
	public static void LoadedAtlas(AssetHandle<SpriteAtlas> handle)
	{
	}

	// Token: 0x06004766 RID: 18278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BDC")]
	[Address(RVA = "0x1EBDC90", Offset = "0x1EBDD91", VA = "0x1EBDC90")]
	public static void OpenShop(NPCID _npcId, NpcShopType npcShopType, [Optional] UnityAction EndCallback)
	{
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BDD")]
	[Address(RVA = "0x1EBE230", Offset = "0x1EBE331", VA = "0x1EBE230")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004768 RID: 18280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BDE")]
	[Address(RVA = "0x1EBE430", Offset = "0x1EBE531", VA = "0x1EBE430")]
	private void Start()
	{
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BDF")]
	[Address(RVA = "0x1EBE780", Offset = "0x1EBE881", VA = "0x1EBE780")]
	public void SwitchItemDetailToStatusParameter()
	{
	}

	// Token: 0x0600476A RID: 18282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE0")]
	[Address(RVA = "0x1EBE7E0", Offset = "0x1EBE8E1", VA = "0x1EBE7E0")]
	private void SetStatusParameter()
	{
	}

	// Token: 0x0600476B RID: 18283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE1")]
	[Address(RVA = "0x1EBE990", Offset = "0x1EBEA91", VA = "0x1EBE990")]
	public void SetFocusBlock(UIShopItemBlock onFocusBlock)
	{
	}

	// Token: 0x0600476C RID: 18284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE2")]
	[Address(RVA = "0x1EBEF10", Offset = "0x1EBF011", VA = "0x1EBEF10")]
	public void ClearFocusBlock()
	{
	}

	// Token: 0x0600476D RID: 18285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE3")]
	[Address(RVA = "0x1EBEF20", Offset = "0x1EBF021", VA = "0x1EBEF20")]
	public void SetShopType(NpcShopType _shopType)
	{
	}

	// Token: 0x0600476E RID: 18286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE4")]
	[Address(RVA = "0x1EBDB40", Offset = "0x1EBDC41", VA = "0x1EBDB40")]
	public void SetBuildIcon()
	{
	}

	// Token: 0x0600476F RID: 18287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE5")]
	[Address(RVA = "0x1EBEF90", Offset = "0x1EBF091", VA = "0x1EBEF90")]
	private void SetItemFromTable(int itemPage)
	{
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE6")]
	[Address(RVA = "0x1EBE440", Offset = "0x1EBE541", VA = "0x1EBE440")]
	public void OpenShop()
	{
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE7")]
	[Address(RVA = "0x1EBFBB0", Offset = "0x1EBFCB1", VA = "0x1EBFBB0")]
	private void EndDelayCloseShop()
	{
	}

	// Token: 0x06004772 RID: 18290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE8")]
	[Address(RVA = "0x1EBFC50", Offset = "0x1EBFD51", VA = "0x1EBFC50")]
	private void UpdateCloseShop()
	{
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BE9")]
	[Address(RVA = "0x1EBFCB0", Offset = "0x1EBFDB1", VA = "0x1EBFCB0")]
	private void CloseShop()
	{
	}

	// Token: 0x06004774 RID: 18292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003BEA")]
	[Address(RVA = "0x1EBFD50", Offset = "0x1EBFE51", VA = "0x1EBFD50")]
	private ItemStorage GetItemStorage(ItemID id)
	{
		return null;
	}

	// Token: 0x06004775 RID: 18293 RVA: 0x00017580 File Offset: 0x00015780
	[Token(Token = "0x6003BEB")]
	[Address(RVA = "0x1EBFE30", Offset = "0x1EBFF31", VA = "0x1EBFE30")]
	private ItemID GetNowFocusItemId()
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x06004776 RID: 18294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BEC")]
	[Address(RVA = "0x1EBFEE0", Offset = "0x1EBFFE1", VA = "0x1EBFEE0")]
	public void AddItemInBasket()
	{
	}

	// Token: 0x06004777 RID: 18295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BED")]
	[Address(RVA = "0x1EC0020", Offset = "0x1EC0121", VA = "0x1EC0020")]
	private void AddItemToBasket()
	{
	}

	// Token: 0x06004778 RID: 18296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BEE")]
	[Address(RVA = "0x1EC0530", Offset = "0x1EC0631", VA = "0x1EC0530")]
	private void ResetBasket()
	{
	}

	// Token: 0x06004779 RID: 18297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BEF")]
	[Address(RVA = "0x1EC07A0", Offset = "0x1EC08A1", VA = "0x1EC07A0")]
	private void BuyItemFromBasket()
	{
	}

	// Token: 0x0600477A RID: 18298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF0")]
	[Address(RVA = "0x1EBF6C0", Offset = "0x1EBF7C1", VA = "0x1EBF6C0")]
	private void ChangePage()
	{
	}

	// Token: 0x0600477B RID: 18299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF1")]
	[Address(RVA = "0x1EBA080", Offset = "0x1EBA181", VA = "0x1EBA080")]
	public void ChangePage(int plusPage)
	{
	}

	// Token: 0x0600477C RID: 18300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF2")]
	[Address(RVA = "0x1EC0FE0", Offset = "0x1EC10E1", VA = "0x1EC0FE0")]
	private void SetNpcBustup(NPCID npcId, int variationId, int eyeId, int EyeBrowsId, int MouthId)
	{
	}

	// Token: 0x0600477D RID: 18301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF3")]
	[Address(RVA = "0x1EBFBA0", Offset = "0x1EBFCA1", VA = "0x1EBFBA0")]
	public void SetTalkBox(UIShopController.ShopTalkType talkType)
	{
	}

	// Token: 0x0600477E RID: 18302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF4")]
	[Address(RVA = "0x1EC1010", Offset = "0x1EC1111", VA = "0x1EC1010")]
	private void SetTalkBox(int talkType)
	{
	}

	// Token: 0x0600477F RID: 18303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF5")]
	[Address(RVA = "0x1EC19B0", Offset = "0x1EC1AB1", VA = "0x1EC19B0")]
	private void SetTalkCantBuy(string TextId)
	{
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF6")]
	[Address(RVA = "0x1EC1E00", Offset = "0x1EC1F01", VA = "0x1EC1E00")]
	private void Update()
	{
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x00017598 File Offset: 0x00015798
	[Token(Token = "0x6003BF7")]
	[Address(RVA = "0x1EC2720", Offset = "0x1EC2821", VA = "0x1EC2720")]
	private uint rf3MainBigSellLimitU32(ulong rand_seed, uint limit, uint shop_id)
	{
		return 0U;
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF8")]
	[Address(RVA = "0x1EBC0C0", Offset = "0x1EBC1C1", VA = "0x1EBC0C0")]
	private void SetShopTable()
	{
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BF9")]
	[Address(RVA = "0x1EC2810", Offset = "0x1EC2911", VA = "0x1EC2810")]
	public UIShopController()
	{
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BFB")]
	[Address(RVA = "0x1EC2920", Offset = "0x1EC2A21", VA = "0x1EC2920")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8030", Offset = "0x1A8131")]
	private void <Update>b__114_0(bool selector)
	{
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003BFC")]
	[Address(RVA = "0x1EC2AE0", Offset = "0x1EC2BE1", VA = "0x1EC2AE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8040", Offset = "0x1A8141")]
	private void <Update>b__114_1(bool selector)
	{
	}

	// Token: 0x0400A691 RID: 42641
	[Token(Token = "0x4007DF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static NpcShopType _shopType;

	// Token: 0x0400A692 RID: 42642
	[Token(Token = "0x4007DFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UIItemDetailDisp UIItemDetailDisp;

	// Token: 0x0400A693 RID: 42643
	[Token(Token = "0x4007DFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text UIBuildNameText;

	// Token: 0x0400A694 RID: 42644
	[Token(Token = "0x4007DFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text UIBuildDetailText;

	// Token: 0x0400A695 RID: 42645
	[Token(Token = "0x4007DFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text CategoryPageText;

	// Token: 0x0400A696 RID: 42646
	[Token(Token = "0x4007DFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject ChangePagesGroup;

	// Token: 0x0400A697 RID: 42647
	[Token(Token = "0x4007DFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image DiscountImage;

	// Token: 0x0400A698 RID: 42648
	[Token(Token = "0x4007E00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite Discount10Sprite;

	// Token: 0x0400A699 RID: 42649
	[Token(Token = "0x4007E01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite Discount20Sprite;

	// Token: 0x0400A69A RID: 42650
	[Token(Token = "0x4007E02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AdvCharaImageControl AdvCharaImageControl;

	// Token: 0x0400A69B RID: 42651
	[Token(Token = "0x4007E03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private NpcShopTable _NpcShopTable;

	// Token: 0x0400A69C RID: 42652
	[Token(Token = "0x4007E04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<BuildItemData> BuildItemList;

	// Token: 0x0400A69D RID: 42653
	[Token(Token = "0x4007E05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UIShopItemBlock[] shopItemBlocks;

	// Token: 0x0400A69E RID: 42654
	[Token(Token = "0x4007E06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UIShopControl UIShopControl;

	// Token: 0x0400A69F RID: 42655
	[Token(Token = "0x4007E07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private RectTransform NPCTalkBorder;

	// Token: 0x0400A6A0 RID: 42656
	[Token(Token = "0x4007E08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text NPCTalkText;

	// Token: 0x0400A6A1 RID: 42657
	[Token(Token = "0x4007E09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ShopParameterCalc ShopParameterCalc;

	// Token: 0x0400A6A2 RID: 42658
	[Token(Token = "0x4007E0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float NowMouthTime;

	// Token: 0x0400A6A3 RID: 42659
	[Token(Token = "0x4007E0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float WaitTalkDelay;

	// Token: 0x0400A6A4 RID: 42660
	[Token(Token = "0x4007E0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int LastTalkType;

	// Token: 0x0400A6A5 RID: 42661
	[Token(Token = "0x4007E0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private UIShopItemBlock focusingBlock;

	// Token: 0x0400A6A6 RID: 42662
	[Token(Token = "0x4007E0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private UIShopItemBlock buildSelectingBlock;

	// Token: 0x0400A6A7 RID: 42663
	[Token(Token = "0x4007E0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private ShopItem selectingShopItem;

	// Token: 0x0400A6A8 RID: 42664
	[Token(Token = "0x4007E10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int pageNum;

	// Token: 0x0400A6A9 RID: 42665
	[Token(Token = "0x4007E11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int pageMax;

	// Token: 0x0400A6AA RID: 42666
	[Token(Token = "0x4007E12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int buyNum;

	// Token: 0x0400A6AB RID: 42667
	[Token(Token = "0x4007E13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int totalPrice;

	// Token: 0x0400A6AC RID: 42668
	[Token(Token = "0x4007E14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int myShopLv;

	// Token: 0x0400A6AD RID: 42669
	[Token(Token = "0x4007E15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static NPCID _NPCID;

	// Token: 0x0400A6AE RID: 42670
	[Token(Token = "0x4007E16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Image BGR;

	// Token: 0x0400A6AF RID: 42671
	[Token(Token = "0x4007E17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Sprite[] BGRSprites;

	// Token: 0x0400A6B0 RID: 42672
	[Token(Token = "0x4007E18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Sprite[] MokSprites;

	// Token: 0x0400A6B1 RID: 42673
	[Token(Token = "0x4007E19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Image[] MokImage;

	// Token: 0x0400A6B2 RID: 42674
	[Token(Token = "0x4007E1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private ItemMoveToBasket ItemMoveToBasket;

	// Token: 0x0400A6B3 RID: 42675
	[Token(Token = "0x4007E1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<ItemMoveToBasket> UsingItemMoveToBaskets;

	// Token: 0x0400A6B4 RID: 42676
	[Token(Token = "0x4007E1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private UIShopCoinGen UIShopCoinGen;

	// Token: 0x0400A6B5 RID: 42677
	[Token(Token = "0x4007E1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private UIShopCoinGen usingUIShopCoinGen;

	// Token: 0x0400A6B6 RID: 42678
	[Token(Token = "0x4007E1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private int addedInCartNum;

	// Token: 0x0400A6B7 RID: 42679
	[Token(Token = "0x4007E1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private UIShopItemSplash UIShopItemSplash;

	// Token: 0x0400A6B8 RID: 42680
	[Token(Token = "0x4007E20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool Purchased;

	// Token: 0x0400A6B9 RID: 42681
	[Token(Token = "0x4007E21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private float idelTime;

	// Token: 0x0400A6BA RID: 42682
	[Token(Token = "0x4007E22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ShopMenuType ShopMenuType;

	// Token: 0x0400A6BB RID: 42683
	[Token(Token = "0x4007E23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool EndShop;

	// Token: 0x0400A6BC RID: 42684
	[Token(Token = "0x4007E24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float DelayCloseShop;

	// Token: 0x0400A6BD RID: 42685
	[Token(Token = "0x4007E25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	[SerializeField]
	private float CloseShopDelayTime;

	// Token: 0x0400A6BE RID: 42686
	[Token(Token = "0x4007E26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool buildSelecting;

	// Token: 0x0400A6BF RID: 42687
	[Token(Token = "0x4007E27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173B30", Offset = "0x173C31")]
	private static ItemID <RestaurantBuyItemId>k__BackingField;

	// Token: 0x0400A6C0 RID: 42688
	[Token(Token = "0x4007E28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173B40", Offset = "0x173C41")]
	private static bool <IsBuyFist>k__BackingField;

	// Token: 0x0400A6C1 RID: 42689
	[Token(Token = "0x4007E29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173B50", Offset = "0x173C51")]
	private static bool <IsBuyRAorMagic>k__BackingField;

	// Token: 0x0400A6C2 RID: 42690
	[Token(Token = "0x4007E2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x173B60", Offset = "0x173C61")]
	private static bool <IsBuyCrystal>k__BackingField;

	// Token: 0x0400A6C3 RID: 42691
	[Token(Token = "0x4007E2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static UIShopController shopController;

	// Token: 0x0400A6C4 RID: 42692
	[Token(Token = "0x4007E2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static SpriteAtlas BuildIconAtlas;

	// Token: 0x0400A6C5 RID: 42693
	[Token(Token = "0x4007E2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static SpriteAtlas FurnitureIconAtlas;

	// Token: 0x0400A6C6 RID: 42694
	[Token(Token = "0x4007E2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
	[SerializeField]
	private bool useEquipStatusMenu;

	// Token: 0x0400A6C7 RID: 42695
	[Token(Token = "0x4007E2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
	private bool isOpenedStatusWindow;

	// Token: 0x0400A6C8 RID: 42696
	[Token(Token = "0x4007E30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private EquipStatusMenu EquipStatusMenu;

	// Token: 0x0400A6C9 RID: 42697
	[Token(Token = "0x4007E31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private NonFocusButton ZR_Button;

	// Token: 0x0400A6CA RID: 42698
	[Token(Token = "0x4007E32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	private NonFocusButton L_Button;

	// Token: 0x0400A6CB RID: 42699
	[Token(Token = "0x4007E33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private NonFocusButton R_Button;

	// Token: 0x0400A6CC RID: 42700
	[Token(Token = "0x4007E34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int lastBounghtBuildId;

	// Token: 0x0400A6CD RID: 42701
	[Token(Token = "0x4007E35")]
	private const float SellDiscountRate = 0.9f;

	// Token: 0x0400A6CE RID: 42702
	[Token(Token = "0x4007E36")]
	private const float BigSellDiscountRate = 0.8f;

	// Token: 0x02000ABB RID: 2747
	[Token(Token = "0x2001305")]
	public enum ShopTalkType
	{
		// Token: 0x0400A6D0 RID: 42704
		[Token(Token = "0x401B4FC")]
		Welcome,
		// Token: 0x0400A6D1 RID: 42705
		[Token(Token = "0x401B4FD")]
		NoItemSelecting_10s,
		// Token: 0x0400A6D2 RID: 42706
		[Token(Token = "0x401B4FE")]
		EndNoBuyTalk,
		// Token: 0x0400A6D3 RID: 42707
		[Token(Token = "0x401B4FF")]
		ThanksToBuy,
		// Token: 0x0400A6D4 RID: 42708
		[Token(Token = "0x401B500")]
		EndBuyTalk,
		// Token: 0x0400A6D5 RID: 42709
		[Token(Token = "0x401B501")]
		InventoryOver,
		// Token: 0x0400A6D6 RID: 42710
		[Token(Token = "0x401B502")]
		NowSales,
		// Token: 0x0400A6D7 RID: 42711
		[Token(Token = "0x401B503")]
		PushInBusket,
		// Token: 0x0400A6D8 RID: 42712
		[Token(Token = "0x401B504")]
		ClearBusket,
		// Token: 0x0400A6D9 RID: 42713
		[Token(Token = "0x401B505")]
		NotEnoughMoney,
		// Token: 0x0400A6DA RID: 42714
		[Token(Token = "0x401B506")]
		Max,
		// Token: 0x0400A6DB RID: 42715
		[Token(Token = "0x401B507")]
		CantBuy
	}

	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2001306")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159210", Offset = "0x159311")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004788 RID: 18312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766F")]
		[Address(RVA = "0x2119FC0", Offset = "0x211A0C1", VA = "0x2119FC0")]
		public <>c()
		{
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x000175B0 File Offset: 0x000157B0
		[Token(Token = "0x6007670")]
		[Address(RVA = "0x2119FD0", Offset = "0x211A0D1", VA = "0x2119FD0")]
		internal bool <AddItemToBasket>b__104_0(ItemMoveToBasket a)
		{
			return default(bool);
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000175C8 File Offset: 0x000157C8
		[Token(Token = "0x6007671")]
		[Address(RVA = "0x211A040", Offset = "0x211A141", VA = "0x211A040")]
		internal bool <AddItemToBasket>b__104_1(ItemMoveToBasket a)
		{
			return default(bool);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007672")]
		[Address(RVA = "0x211A0B0", Offset = "0x211A1B1", VA = "0x211A0B0")]
		internal void <BuyItemFromBasket>b__106_0()
		{
		}

		// Token: 0x0400A6DC RID: 42716
		[Token(Token = "0x401B508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UIShopController.<>c <>9;

		// Token: 0x0400A6DD RID: 42717
		[Token(Token = "0x401B509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<ItemMoveToBasket> <>9__104_0;

		// Token: 0x0400A6DE RID: 42718
		[Token(Token = "0x401B50A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<ItemMoveToBasket> <>9__104_1;

		// Token: 0x0400A6DF RID: 42719
		[Token(Token = "0x401B50B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static UnityAction <>9__106_0;
	}

	// Token: 0x02000ABD RID: 2749
	[Token(Token = "0x2001307")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159220", Offset = "0x159321")]
	private sealed class <>c__DisplayClass116_0
	{
		// Token: 0x0600478C RID: 18316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007673")]
		[Address(RVA = "0x211A300", Offset = "0x211A401", VA = "0x211A300")]
		public <>c__DisplayClass116_0()
		{
		}

		// Token: 0x0400A6E0 RID: 42720
		[Token(Token = "0x401B50C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<BuildItemData> datas;
	}

	// Token: 0x02000ABE RID: 2750
	[Token(Token = "0x2001308")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159230", Offset = "0x159331")]
	private sealed class <>c__DisplayClass116_1
	{
		// Token: 0x0600478D RID: 18317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007674")]
		[Address(RVA = "0x211A310", Offset = "0x211A411", VA = "0x211A310")]
		public <>c__DisplayClass116_1()
		{
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x000175E0 File Offset: 0x000157E0
		[Token(Token = "0x6007675")]
		[Address(RVA = "0x211A320", Offset = "0x211A421", VA = "0x211A320")]
		internal bool <SetShopTable>b__0(BuildItemData a)
		{
			return default(bool);
		}

		// Token: 0x0400A6E1 RID: 42721
		[Token(Token = "0x401B50D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x0400A6E2 RID: 42722
		[Token(Token = "0x401B50E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIShopController.<>c__DisplayClass116_0 CS$<>8__locals1;
	}
}
