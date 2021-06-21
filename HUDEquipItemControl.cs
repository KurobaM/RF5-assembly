using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009AA RID: 2474
[Token(Token = "0x200067A")]
public class HUDEquipItemControl : MonoBehaviour
{
	// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60035D9")]
	[Address(RVA = "0x204A8E0", Offset = "0x204A9E1", VA = "0x204A8E0")]
	private string SetInteractionButtonText(HoldableInterface holdableInterface, FocusInterface currentFocus, ButtonInteractID buttonInteractID)
	{
		return null;
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DA")]
	[Address(RVA = "0x204AA80", Offset = "0x204AB81", VA = "0x204AA80")]
	private void SetHoldItemText()
	{
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DB")]
	[Address(RVA = "0x204AE20", Offset = "0x204AF21", VA = "0x204AE20")]
	private void SetFishingText()
	{
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DC")]
	[Address(RVA = "0x204AE90", Offset = "0x204AF91", VA = "0x204AE90")]
	private void Update()
	{
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x204B230", Offset = "0x204B331", VA = "0x204B230")]
	public HUDEquipItemControl()
	{
	}

	// Token: 0x04009F36 RID: 40758
	[Token(Token = "0x40077FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HUDFadeMove ItemEquip;

	// Token: 0x04009F37 RID: 40759
	[Token(Token = "0x40077FD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDFadeMove RuneEquip;

	// Token: 0x04009F38 RID: 40760
	[Token(Token = "0x40077FE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HUDFadeMove OnHandItem;

	// Token: 0x04009F39 RID: 40761
	[Token(Token = "0x40077FF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image HoldItemButtonBorder_X;

	// Token: 0x04009F3A RID: 40762
	[Token(Token = "0x4007800")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image HoldItemButtonBorder_Y;

	// Token: 0x04009F3B RID: 40763
	[Token(Token = "0x4007801")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image HoldItemButtonBorder_A;

	// Token: 0x04009F3C RID: 40764
	[Token(Token = "0x4007802")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image HoldItemButtonBorder_B;

	// Token: 0x04009F3D RID: 40765
	[Token(Token = "0x4007803")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SText HoldItemButton_X;

	// Token: 0x04009F3E RID: 40766
	[Token(Token = "0x4007804")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SText HoldItemButton_Y;

	// Token: 0x04009F3F RID: 40767
	[Token(Token = "0x4007805")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SText HoldItemButton_A;

	// Token: 0x04009F40 RID: 40768
	[Token(Token = "0x4007806")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SText HoldItemButton_B;

	// Token: 0x04009F41 RID: 40769
	[Token(Token = "0x4007807")]
	[FieldOffset(Offset = "0x70")]
	private HUDEquipItemControl.OpenStatus status;

	// Token: 0x04009F42 RID: 40770
	[Token(Token = "0x4007808")]
	[FieldOffset(Offset = "0x78")]
	private FocusInterface currentFocus;

	// Token: 0x04009F43 RID: 40771
	[Token(Token = "0x4007809")]
	[FieldOffset(Offset = "0x80")]
	private HoldableInterface _holdObj;

	// Token: 0x020009AB RID: 2475
	[Token(Token = "0x20012B2")]
	private enum OpenStatus
	{
		// Token: 0x04009F45 RID: 40773
		[Token(Token = "0x401B39E")]
		Equip,
		// Token: 0x04009F46 RID: 40774
		[Token(Token = "0x401B39F")]
		Rune,
		// Token: 0x04009F47 RID: 40775
		[Token(Token = "0x401B3A0")]
		Hand
	}
}
