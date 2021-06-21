using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A25 RID: 2597
[Token(Token = "0x20006D0")]
public class UIBatchEquipSlot : ButtonLinker
{
	// Token: 0x17000941 RID: 2369
	// (get) Token: 0x060043F8 RID: 17400 RVA: 0x00016B00 File Offset: 0x00014D00
	// (set) Token: 0x060043F9 RID: 17401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700076D")]
	public PoliceBatchId PoliceBatchId
	{
		[Token(Token = "0x60038E4")]
		[Address(RVA = "0x1FFDC50", Offset = "0x1FFDD51", VA = "0x1FFDC50")]
		get
		{
			return PoliceBatchId.None;
		}
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x1FFDCD0", Offset = "0x1FFDDD1", VA = "0x1FFDCD0")]
		set
		{
		}
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x00016B18 File Offset: 0x00014D18
	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x1FFDC90", Offset = "0x1FFDD91", VA = "0x1FFDC90")]
	private PoliceBatchId GetBatch(int slot)
	{
		return PoliceBatchId.None;
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038E7")]
	[Address(RVA = "0x1FFDCE0", Offset = "0x1FFDDE1", VA = "0x1FFDCE0")]
	private void SetBatch(int slot, PoliceBatchId value)
	{
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038E8")]
	[Address(RVA = "0x1FFDF90", Offset = "0x1FFE091", VA = "0x1FFDF90")]
	public void DoEquip(PoliceBatchId policeBatchId)
	{
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038E9")]
	[Address(RVA = "0x1FFE060", Offset = "0x1FFE161", VA = "0x1FFE060")]
	public void DoUnEquip()
	{
	}

	// Token: 0x060043FE RID: 17406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038EA")]
	[Address(RVA = "0x1FFE120", Offset = "0x1FFE221", VA = "0x1FFE120")]
	private void OnEnable()
	{
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038EB")]
	[Address(RVA = "0x1FFDE80", Offset = "0x1FFDF81", VA = "0x1FFDE80")]
	public void DispBatch()
	{
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038EC")]
	[Address(RVA = "0x1FFE2B0", Offset = "0x1FFE3B1", VA = "0x1FFE2B0")]
	public void EndSelect()
	{
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038ED")]
	[Address(RVA = "0x1FFE320", Offset = "0x1FFE421", VA = "0x1FFE320", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038EE")]
	[Address(RVA = "0x1FFE6F0", Offset = "0x1FFE7F1", VA = "0x1FFE6F0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038EF")]
	[Address(RVA = "0x1FFE700", Offset = "0x1FFE801", VA = "0x1FFE700", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F0")]
	[Address(RVA = "0x1FFE810", Offset = "0x1FFE911", VA = "0x1FFE810")]
	private void OnDisable()
	{
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F1")]
	[Address(RVA = "0x1FFE160", Offset = "0x1FFE261", VA = "0x1FFE160")]
	private void SetLinker()
	{
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038F2")]
	[Address(RVA = "0x1FFE880", Offset = "0x1FFE981", VA = "0x1FFE880")]
	public UIBatchEquipSlot()
	{
	}

	// Token: 0x0400A2EA RID: 41706
	[Token(Token = "0x4007B1F")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x171D50", Offset = "0x171E51")]
	private int SlotId;

	// Token: 0x0400A2EB RID: 41707
	[Token(Token = "0x4007B20")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image BatchImage;

	// Token: 0x0400A2EC RID: 41708
	[Token(Token = "0x4007B21")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text BatchNameText;

	// Token: 0x0400A2ED RID: 41709
	[Token(Token = "0x4007B22")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text BatchDiscriptText;

	// Token: 0x0400A2EE RID: 41710
	[Token(Token = "0x4007B23")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite OnSelectSprite;

	// Token: 0x0400A2EF RID: 41711
	[Token(Token = "0x4007B24")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite NotSelectSprite;

	// Token: 0x0400A2F0 RID: 41712
	[Token(Token = "0x4007B25")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIBatchPageControl UIBatchPageControl;

	// Token: 0x0400A2F1 RID: 41713
	[Token(Token = "0x4007B26")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private CursorLinkConnector BatchEquipSlotConnector;

	// Token: 0x0400A2F2 RID: 41714
	[Token(Token = "0x4007B27")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject resetLinkerObj;
}
