using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000988 RID: 2440
[Token(Token = "0x2000666")]
public class UIEMMainControl : MonoBehaviour
{
	// Token: 0x170008F2 RID: 2290
	// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x00015A08 File Offset: 0x00013C08
	[Token(Token = "0x17000728")]
	public EquipSlotType equipSlotType
	{
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x200CA20", Offset = "0x200CB21", VA = "0x200CA20")]
		get
		{
			return EquipSlotType.RuneRX;
		}
	}

	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x00015A20 File Offset: 0x00013C20
	[Token(Token = "0x17000729")]
	public UIEMDefine.CategoryDataSet NowEquipSlotData
	{
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x200B900", Offset = "0x200BA01", VA = "0x200B900")]
		get
		{
			return default(UIEMDefine.CategoryDataSet);
		}
	}

	// Token: 0x170008F4 RID: 2292
	// (get) Token: 0x06003FDA RID: 16346 RVA: 0x00015A38 File Offset: 0x00013C38
	[Token(Token = "0x1700072A")]
	private UIEMDefine.CategoryDataSet UpEquipSlotData
	{
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x200CB80", Offset = "0x200CC81", VA = "0x200CB80")]
		get
		{
			return default(UIEMDefine.CategoryDataSet);
		}
	}

	// Token: 0x170008F5 RID: 2293
	// (get) Token: 0x06003FDB RID: 16347 RVA: 0x00015A50 File Offset: 0x00013C50
	[Token(Token = "0x1700072B")]
	private UIEMDefine.CategoryDataSet DownEquipSlotData
	{
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x200CC70", Offset = "0x200CD71", VA = "0x200CC70")]
		get
		{
			return default(UIEMDefine.CategoryDataSet);
		}
	}

	// Token: 0x170008F6 RID: 2294
	// (get) Token: 0x06003FDC RID: 16348 RVA: 0x00015A68 File Offset: 0x00013C68
	[Token(Token = "0x1700072C")]
	private UIEMDefine.CategoryDataSet TopEquipSlotData
	{
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x200CD60", Offset = "0x200CE61", VA = "0x200CD60")]
		get
		{
			return default(UIEMDefine.CategoryDataSet);
		}
	}

	// Token: 0x170008F7 RID: 2295
	// (get) Token: 0x06003FDD RID: 16349 RVA: 0x00015A80 File Offset: 0x00013C80
	[Token(Token = "0x1700072D")]
	private UIEMDefine.CategoryDataSet BottomEquipSlotData
	{
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x200CE50", Offset = "0x200CF51", VA = "0x200CE50")]
		get
		{
			return default(UIEMDefine.CategoryDataSet);
		}
	}

	// Token: 0x170008F8 RID: 2296
	// (get) Token: 0x06003FDE RID: 16350 RVA: 0x00015A98 File Offset: 0x00013C98
	// (set) Token: 0x06003FDF RID: 16351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700072E")]
	public int FocusingItem
	{
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x200CF40", Offset = "0x200D041", VA = "0x200CF40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7200", Offset = "0x1A7301")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x200CF50", Offset = "0x200D051", VA = "0x200CF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7210", Offset = "0x1A7311")]
		set
		{
		}
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003532")]
	[Address(RVA = "0x200CF60", Offset = "0x200D061", VA = "0x200CF60")]
	private void Start()
	{
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x00015AB0 File Offset: 0x00013CB0
	[Token(Token = "0x6003533")]
	[Address(RVA = "0x200A1C0", Offset = "0x200A2C1", VA = "0x200A1C0")]
	public ActorID GetActorID()
	{
		return ActorID.act000;
	}

	// Token: 0x06003FE2 RID: 16354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003534")]
	[Address(RVA = "0x200CFF0", Offset = "0x200D0F1", VA = "0x200CFF0")]
	private void SetItemGroupText()
	{
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003535")]
	[Address(RVA = "0x200D650", Offset = "0x200D751", VA = "0x200D650")]
	private void UpdateStatusText()
	{
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003536")]
	[Address(RVA = "0x200D7E0", Offset = "0x200D8E1", VA = "0x200D7E0")]
	private void UpdateItemDetail()
	{
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003537")]
	[Address(RVA = "0x200D9C0", Offset = "0x200DAC1", VA = "0x200D9C0")]
	private void CloseWindow(bool isWeaponChange = false)
	{
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003538")]
	[Address(RVA = "0x200DB00", Offset = "0x200DC01", VA = "0x200DB00")]
	private void OnDisable()
	{
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003539")]
	[Address(RVA = "0x200DBD0", Offset = "0x200DCD1", VA = "0x200DBD0")]
	private ItemStorage GetItemStorage(ItemData itemData)
	{
		return null;
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600353A")]
	[Address(RVA = "0x200DCB0", Offset = "0x200DDB1", VA = "0x200DCB0")]
	public void DoOpenPage([Optional] UIQuickEquipMenuMain uiQuickEquipMenuMain)
	{
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600353B")]
	[Address(RVA = "0x2000F60", Offset = "0x2001061", VA = "0x2000F60")]
	public void DoOpenPage([Optional] UICampEquipMenuMain uiCampEquipMenuMain)
	{
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600353C")]
	[Address(RVA = "0x200DEB0", Offset = "0x200DFB1", VA = "0x200DEB0")]
	private void ReDrawItems()
	{
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x00015AC8 File Offset: 0x00013CC8
	[Token(Token = "0x600353D")]
	[Address(RVA = "0x200DF50", Offset = "0x200E051", VA = "0x200DF50")]
	private bool CheckEquipNotItemOnHand()
	{
		return default(bool);
	}

	// Token: 0x06003FEC RID: 16364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600353E")]
	[Address(RVA = "0x200DFB0", Offset = "0x200E0B1", VA = "0x200DFB0")]
	private void Update()
	{
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600353F")]
	[Address(RVA = "0x200EE00", Offset = "0x200EF01", VA = "0x200EE00")]
	private void BackToTopSlot()
	{
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003540")]
	[Address(RVA = "0x200EC50", Offset = "0x200ED51", VA = "0x200EC50")]
	private void OnChangePage()
	{
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x00015AE0 File Offset: 0x00013CE0
	[Token(Token = "0x6003541")]
	[Address(RVA = "0x200E950", Offset = "0x200EA51", VA = "0x200E950")]
	private bool PressA()
	{
		return default(bool);
	}

	// Token: 0x06003FF0 RID: 16368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003542")]
	[Address(RVA = "0x200C6C0", Offset = "0x200C7C1", VA = "0x200C6C0")]
	public void OnTouchItemSlot(int _index)
	{
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003543")]
	[Address(RVA = "0x200C3A0", Offset = "0x200C4A1", VA = "0x200C3A0")]
	public void InputLeft()
	{
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003544")]
	[Address(RVA = "0x200C510", Offset = "0x200C611", VA = "0x200C510")]
	public void InputRight()
	{
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003545")]
	[Address(RVA = "0x200EE80", Offset = "0x200EF81", VA = "0x200EE80")]
	public UIEMMainControl()
	{
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003546")]
	[Address(RVA = "0x200EE90", Offset = "0x200EF91", VA = "0x200EE90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7220", Offset = "0x1A7321")]
	private void <Start>b__42_0()
	{
	}

	// Token: 0x04009E2F RID: 40495
	[Token(Token = "0x400773B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<int> EMCategoryList;

	// Token: 0x04009E30 RID: 40496
	[Token(Token = "0x400773C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] ItemCategoryIcon;

	// Token: 0x04009E31 RID: 40497
	[Token(Token = "0x400773D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UIEMMainControl.EquipMenuType equipMenuType;

	// Token: 0x04009E32 RID: 40498
	[Token(Token = "0x400773E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UIEMEquipItemSlot TopSlot;

	// Token: 0x04009E33 RID: 40499
	[Token(Token = "0x400773F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UIEMItemsControl UIEMItemsControl;

	// Token: 0x04009E34 RID: 40500
	[Token(Token = "0x4007740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int _equipSlotType;

	// Token: 0x04009E35 RID: 40501
	[Token(Token = "0x4007741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16FC70", Offset = "0x16FD71")]
	private int <FocusingItem>k__BackingField;

	// Token: 0x04009E36 RID: 40502
	[Token(Token = "0x4007742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text UpText;

	// Token: 0x04009E37 RID: 40503
	[Token(Token = "0x4007743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text DownText;

	// Token: 0x04009E38 RID: 40504
	[Token(Token = "0x4007744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text NowText;

	// Token: 0x04009E39 RID: 40505
	[Token(Token = "0x4007745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text TopText;

	// Token: 0x04009E3A RID: 40506
	[Token(Token = "0x4007746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text BottomText;

	// Token: 0x04009E3B RID: 40507
	[Token(Token = "0x4007747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image UpIcon;

	// Token: 0x04009E3C RID: 40508
	[Token(Token = "0x4007748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image DownIcon;

	// Token: 0x04009E3D RID: 40509
	[Token(Token = "0x4007749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image NowIcon;

	// Token: 0x04009E3E RID: 40510
	[Token(Token = "0x400774A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image TopIcon;

	// Token: 0x04009E3F RID: 40511
	[Token(Token = "0x400774B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image BottomIcon;

	// Token: 0x04009E40 RID: 40512
	[Token(Token = "0x400774C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Image PadIcon;

	// Token: 0x04009E41 RID: 40513
	[Token(Token = "0x400774D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UIEMItemDetail UIEMItemDetail;

	// Token: 0x04009E42 RID: 40514
	[Token(Token = "0x400774E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private EquipStatusMenu EquipStatusMenu;

	// Token: 0x04009E43 RID: 40515
	[Token(Token = "0x400774F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UIOnOffAnimate UIOnOffAnimate;

	// Token: 0x04009E44 RID: 40516
	[Token(Token = "0x4007750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Animator CategoryAnim;

	// Token: 0x04009E45 RID: 40517
	[Token(Token = "0x4007751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool FocusOnEquip;

	// Token: 0x04009E46 RID: 40518
	[Token(Token = "0x4007752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private UIQuickEquipMenuMain UIQuickEquipMenuMain;

	// Token: 0x04009E47 RID: 40519
	[Token(Token = "0x4007753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private UICampEquipMenuMain UICampEquipMenuMain;

	// Token: 0x04009E48 RID: 40520
	[Token(Token = "0x4007754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int ItemCount;

	// Token: 0x02000989 RID: 2441
	[Token(Token = "0x20012A4")]
	private enum EquipMenuType
	{
		// Token: 0x04009E4A RID: 40522
		[Token(Token = "0x401B358")]
		Camp,
		// Token: 0x04009E4B RID: 40523
		[Token(Token = "0x401B359")]
		Quick
	}
}
