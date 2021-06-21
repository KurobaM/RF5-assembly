using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000986 RID: 2438
[Token(Token = "0x2000664")]
public class UIEMItemslot : MonoBehaviour
{
	// Token: 0x170008F1 RID: 2289
	// (get) Token: 0x06003FCB RID: 16331 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003FCC RID: 16332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000727")]
	public ItemDataLinker itemDataLinker
	{
		[Token(Token = "0x600351D")]
		[Address(RVA = "0x200C800", Offset = "0x200C901", VA = "0x200C800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A71D0", Offset = "0x1A72D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600351E")]
		[Address(RVA = "0x200C810", Offset = "0x200C911", VA = "0x200C810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A71E0", Offset = "0x1A72E1")]
		private set
		{
		}
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600351F")]
	[Address(RVA = "0x200C820", Offset = "0x200C921", VA = "0x200C820")]
	private void Awake()
	{
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003520")]
	[Address(RVA = "0x200C940", Offset = "0x200CA41", VA = "0x200C940")]
	public void SetEvent(UnityAction _action)
	{
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003521")]
	[Address(RVA = "0x200C950", Offset = "0x200CA51", VA = "0x200C950")]
	private void OnTouch()
	{
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x000159D8 File Offset: 0x00013BD8
	[Token(Token = "0x6003522")]
	[Address(RVA = "0x200C970", Offset = "0x200CA71", VA = "0x200C970")]
	private bool HoldUpItem(UIEMMainControl UIEMMainControl)
	{
		return default(bool);
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x000159F0 File Offset: 0x00013BF0
	[Token(Token = "0x6003523")]
	[Address(RVA = "0x200C1A0", Offset = "0x200C2A1", VA = "0x200C1A0")]
	public bool EquipItem(UIEMMainControl UIEMMainControl)
	{
		return default(bool);
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003524")]
	[Address(RVA = "0x200BB20", Offset = "0x200BC21", VA = "0x200BB20")]
	public void SetItem(ItemDataLinker _itemDataLinker)
	{
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003525")]
	[Address(RVA = "0x200C010", Offset = "0x200C111", VA = "0x200C010")]
	public void Focus()
	{
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003526")]
	[Address(RVA = "0x200BFB0", Offset = "0x200C0B1", VA = "0x200BFB0")]
	public void UnFocus()
	{
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003527")]
	[Address(RVA = "0x200CAF0", Offset = "0x200CBF1", VA = "0x200CAF0")]
	public UIEMItemslot()
	{
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003528")]
	[Address(RVA = "0x200CB60", Offset = "0x200CC61", VA = "0x200CB60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A71F0", Offset = "0x1A72F1")]
	private void <Awake>b__10_0(BaseEventData _data)
	{
	}

	// Token: 0x04009E23 RID: 40483
	[Token(Token = "0x400772F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image ItemImage;

	// Token: 0x04009E24 RID: 40484
	[Token(Token = "0x4007730")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ItemIconLoader ItemIconLoader;

	// Token: 0x04009E25 RID: 40485
	[Token(Token = "0x4007731")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image FocusImage;

	// Token: 0x04009E26 RID: 40486
	[Token(Token = "0x4007732")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image ItemCountImage;

	// Token: 0x04009E27 RID: 40487
	[Token(Token = "0x4007733")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite[] ItemCountSprite;

	// Token: 0x04009E28 RID: 40488
	[Token(Token = "0x4007734")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16FC30", Offset = "0x16FD31")]
	private ItemDataLinker <itemDataLinker>k__BackingField;

	// Token: 0x04009E29 RID: 40489
	[Token(Token = "0x4007735")]
	[FieldOffset(Offset = "0x48")]
	private UnityAction touchAction;
}
