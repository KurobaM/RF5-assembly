using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A6C RID: 2668
[Token(Token = "0x2000701")]
public class UIItemBoxMenu : CursorLinkConnector
{
	// Token: 0x060045A1 RID: 17825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A44")]
	[Address(RVA = "0x2011B50", Offset = "0x2011C51", VA = "0x2011B50")]
	private void SwitchTopicBlock()
	{
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A45")]
	[Address(RVA = "0x2011D50", Offset = "0x2011E51", VA = "0x2011D50")]
	public void ChangeStorage(StorageType _storageType)
	{
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A46")]
	[Address(RVA = "0x2012100", Offset = "0x2012201", VA = "0x2012100")]
	public void ChangeStorage(int movePage)
	{
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A47")]
	[Address(RVA = "0x2012200", Offset = "0x2012301", VA = "0x2012200")]
	public void AddSwitchButton(UIItemBoxWindowOpenButton _UIItemBoxWindowOpenButton)
	{
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A48")]
	[Address(RVA = "0x20122B0", Offset = "0x20123B1", VA = "0x20122B0")]
	private void AddAccessList(StorageType _storageType)
	{
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A49")]
	[Address(RVA = "0x2012610", Offset = "0x2012711", VA = "0x2012610", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A4A")]
	[Address(RVA = "0x20134C0", Offset = "0x20135C1", VA = "0x20134C0")]
	public void SetStorageOnLoad(StorageType _storageType)
	{
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A4B")]
	[Address(RVA = "0x20134D0", Offset = "0x20135D1", VA = "0x20134D0")]
	private void Start()
	{
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A4C")]
	[Address(RVA = "0x2013950", Offset = "0x2013A51", VA = "0x2013950")]
	private void Update()
	{
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A4D")]
	[Address(RVA = "0x2013AC0", Offset = "0x2013BC1", VA = "0x2013AC0")]
	public UIItemBoxMenu()
	{
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x00017118 File Offset: 0x00015318
	[Token(Token = "0x6003A4E")]
	[Address(RVA = "0x2013AD0", Offset = "0x2013BD1", VA = "0x2013AD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C00", Offset = "0x1A7D01")]
	private bool <ChangeStorage>b__15_0(StorageType a)
	{
		return default(bool);
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A4F")]
	[Address(RVA = "0x2013AE0", Offset = "0x2013BE1", VA = "0x2013AE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C10", Offset = "0x1A7D11")]
	private void <Start>b__20_0()
	{
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A50")]
	[Address(RVA = "0x2013B50", Offset = "0x2013C51", VA = "0x2013B50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C20", Offset = "0x1A7D21")]
	private void <Start>b__20_1()
	{
	}

	// Token: 0x0400A474 RID: 42100
	[Token(Token = "0x4007C5B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject[] ActiveOnStartObj;

	// Token: 0x0400A475 RID: 42101
	[Token(Token = "0x4007C5C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GenerateItemSlot LockedBox;

	// Token: 0x0400A476 RID: 42102
	[Token(Token = "0x4007C5D")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GenerateItemSlot SwitchBox;

	// Token: 0x0400A477 RID: 42103
	[Token(Token = "0x4007C5E")]
	[FieldOffset(Offset = "0x70")]
	public StorageType nowStorageType;

	// Token: 0x0400A478 RID: 42104
	[Token(Token = "0x4007C5F")]
	[FieldOffset(Offset = "0x78")]
	private List<StorageType> storageAccessList;

	// Token: 0x0400A479 RID: 42105
	[Token(Token = "0x4007C60")]
	[FieldOffset(Offset = "0x80")]
	private List<UIItemBoxWindowOpenButton> UIItemBoxWindowOpenButtonList;

	// Token: 0x0400A47A RID: 42106
	[Token(Token = "0x4007C61")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIOnOffAnimate BaseBoxNameTextBlock;

	// Token: 0x0400A47B RID: 42107
	[Token(Token = "0x4007C62")]
	[FieldOffset(Offset = "0x90")]
	private UIOnOffAnimate NowBoxNameTextBlock;

	// Token: 0x0400A47C RID: 42108
	[Token(Token = "0x4007C63")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text BlockNameText;

	// Token: 0x0400A47D RID: 42109
	[Token(Token = "0x4007C64")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private NonFocusButton L_Button;

	// Token: 0x0400A47E RID: 42110
	[Token(Token = "0x4007C65")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private NonFocusButton R_Button;

	// Token: 0x0400A47F RID: 42111
	[Token(Token = "0x4007C66")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UIItemBoxMenu.StorageAccessType storageAccessType;

	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x20012ED")]
	public enum StorageAccessType
	{
		// Token: 0x0400A481 RID: 42113
		[Token(Token = "0x401B47D")]
		ItemBox,
		// Token: 0x0400A482 RID: 42114
		[Token(Token = "0x401B47E")]
		Craft,
		// Token: 0x0400A483 RID: 42115
		[Token(Token = "0x401B47F")]
		Shipping,
		// Token: 0x0400A484 RID: 42116
		[Token(Token = "0x401B480")]
		MyShop
	}
}
