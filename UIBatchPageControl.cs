using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A27 RID: 2599
[Token(Token = "0x20006D2")]
public class UIBatchPageControl : MonoBehaviour
{
	// Token: 0x06004409 RID: 17417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60038F5")]
	[Address(RVA = "0x1FFE260", Offset = "0x1FFE361", VA = "0x1FFE260")]
	public Sprite GetBatchSprite(PoliceBatchId id)
	{
		return null;
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F6")]
	[Address(RVA = "0x1FFE9B0", Offset = "0x1FFEAB1", VA = "0x1FFE9B0")]
	private void Update()
	{
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F7")]
	[Address(RVA = "0x1FFEC00", Offset = "0x1FFED01", VA = "0x1FFEC00")]
	private void OnEnable()
	{
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F8")]
	[Address(RVA = "0x1FFEC60", Offset = "0x1FFED61", VA = "0x1FFEC60")]
	private void OnDisable()
	{
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F9")]
	[Address(RVA = "0x1FFECA0", Offset = "0x1FFEDA1", VA = "0x1FFECA0")]
	public UIBatchPageControl()
	{
	}

	// Token: 0x0400A2F3 RID: 41715
	[Token(Token = "0x4007B28")]
	[FieldOffset(Offset = "0x18")]
	public UIBatchEquipSlot NowSelectingBatchEquipSlot;

	// Token: 0x0400A2F4 RID: 41716
	[Token(Token = "0x4007B29")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] BatchSprites;

	// Token: 0x0400A2F5 RID: 41717
	[Token(Token = "0x4007B2A")]
	[FieldOffset(Offset = "0x28")]
	public UIBatchSlot focusingSlot;

	// Token: 0x0400A2F6 RID: 41718
	[Token(Token = "0x4007B2B")]
	[FieldOffset(Offset = "0x30")]
	public UIBatchEquipSlot focusingEquipSlot;

	// Token: 0x0400A2F7 RID: 41719
	[Token(Token = "0x4007B2C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UIBatchEquipSlot[] EquipSlots;

	// Token: 0x0400A2F8 RID: 41720
	[Token(Token = "0x4007B2D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject uiBatchEquipSlot;
}
