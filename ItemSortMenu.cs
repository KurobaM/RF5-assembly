using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009D5 RID: 2517
[Token(Token = "0x2000696")]
public class ItemSortMenu : MonoBehaviour
{
	// Token: 0x060041D4 RID: 16852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F8")]
	[Address(RVA = "0x223A4D0", Offset = "0x223A5D1", VA = "0x223A4D0")]
	public void OnInstantiate(GenerateItemSlot _MyGenerator)
	{
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036F9")]
	[Address(RVA = "0x223A5B0", Offset = "0x223A6B1", VA = "0x223A5B0")]
	private void SetCursorPos()
	{
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FA")]
	[Address(RVA = "0x223A6A0", Offset = "0x223A7A1", VA = "0x223A6A0")]
	private void Start()
	{
	}

	// Token: 0x060041D7 RID: 16855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FB")]
	[Address(RVA = "0x223A730", Offset = "0x223A831", VA = "0x223A730")]
	private void Update()
	{
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FC")]
	[Address(RVA = "0x223A980", Offset = "0x223AA81", VA = "0x223A980")]
	private void CloseWindows()
	{
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036FD")]
	[Address(RVA = "0x223AA40", Offset = "0x223AB41", VA = "0x223AA40")]
	public ItemSortMenu()
	{
	}

	// Token: 0x0400A0B7 RID: 41143
	[Token(Token = "0x4007940")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject ItemBlock;

	// Token: 0x0400A0B8 RID: 41144
	[Token(Token = "0x4007941")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject RuneBlock;

	// Token: 0x0400A0B9 RID: 41145
	[Token(Token = "0x4007942")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform MenuItemParent;

	// Token: 0x0400A0BA RID: 41146
	[Token(Token = "0x4007943")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform MenuRuneParent;

	// Token: 0x0400A0BB RID: 41147
	[Token(Token = "0x4007944")]
	[FieldOffset(Offset = "0x38")]
	private Image[] MenuItem;

	// Token: 0x0400A0BC RID: 41148
	[Token(Token = "0x4007945")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite selectedBorderSprite;

	// Token: 0x0400A0BD RID: 41149
	[Token(Token = "0x4007946")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite NonSelectBorderSprite;

	// Token: 0x0400A0BE RID: 41150
	[Token(Token = "0x4007947")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite selectedLastBorderSprite;

	// Token: 0x0400A0BF RID: 41151
	[Token(Token = "0x4007948")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Sprite NonSelectLastBorderSprite;

	// Token: 0x0400A0C0 RID: 41152
	[Token(Token = "0x4007949")]
	[FieldOffset(Offset = "0x60")]
	private GenerateItemSlot MyGenerator;

	// Token: 0x0400A0C1 RID: 41153
	[Token(Token = "0x400794A")]
	[FieldOffset(Offset = "0x68")]
	private int selectingtItem;

	// Token: 0x0400A0C2 RID: 41154
	[Token(Token = "0x400794B")]
	[FieldOffset(Offset = "0x70")]
	private readonly SubSortType[] ItemTypeTable;

	// Token: 0x0400A0C3 RID: 41155
	[Token(Token = "0x400794C")]
	[FieldOffset(Offset = "0x78")]
	private readonly SubSortType[] RuneTypeTable;
}
