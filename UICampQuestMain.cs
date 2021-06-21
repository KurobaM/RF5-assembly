using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A29 RID: 2601
[Token(Token = "0x20006D4")]
public class UICampQuestMain : MonoBehaviour
{
	// Token: 0x06004416 RID: 17430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003902")]
	[Address(RVA = "0x2001330", Offset = "0x2001431", VA = "0x2001330")]
	public void CancelQuest()
	{
	}

	// Token: 0x06004417 RID: 17431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003903")]
	[Address(RVA = "0x2001C70", Offset = "0x2001D71", VA = "0x2001C70")]
	public void SetFocusingSlot(UIQuestSlotInPoliceBook _slot)
	{
	}

	// Token: 0x06004418 RID: 17432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003904")]
	[Address(RVA = "0x2001ED0", Offset = "0x2001FD1", VA = "0x2001ED0")]
	private void SetOpenDetail(bool doopen)
	{
	}

	// Token: 0x06004419 RID: 17433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003905")]
	[Address(RVA = "0x2001440", Offset = "0x2001541", VA = "0x2001440")]
	private void DispAll()
	{
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003906")]
	[Address(RVA = "0x2002150", Offset = "0x2002251", VA = "0x2002150")]
	public void ChangeFocus(int _slot_no)
	{
	}

	// Token: 0x0600441B RID: 17435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003907")]
	[Address(RVA = "0x20021C0", Offset = "0x20022C1", VA = "0x20021C0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600441C RID: 17436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003908")]
	[Address(RVA = "0x20021D0", Offset = "0x20022D1", VA = "0x20021D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003909")]
	[Address(RVA = "0x2002300", Offset = "0x2002401", VA = "0x2002300")]
	public UICampQuestMain()
	{
	}

	// Token: 0x0400A301 RID: 41729
	[Token(Token = "0x4007B36")]
	[FieldOffset(Offset = "0x18")]
	private UIQuestSlotInPoliceBook focusingSlot;

	// Token: 0x0400A302 RID: 41730
	[Token(Token = "0x4007B37")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ButtonLinker TopButton;

	// Token: 0x0400A303 RID: 41731
	[Token(Token = "0x4007B38")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image QuestClearedImage;

	// Token: 0x0400A304 RID: 41732
	[Token(Token = "0x4007B39")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject QuestDetail;

	// Token: 0x0400A305 RID: 41733
	[Token(Token = "0x4007B3A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject NoAnyQuest;

	// Token: 0x0400A306 RID: 41734
	[Token(Token = "0x4007B3B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AdvCharaImageControl AdvCharaImageControl;

	// Token: 0x0400A307 RID: 41735
	[Token(Token = "0x4007B3C")]
	[FieldOffset(Offset = "0x48")]
	private AdvCharaImageControl NowAdvCharaImageControl;

	// Token: 0x0400A308 RID: 41736
	[Token(Token = "0x4007B3D")]
	[FieldOffset(Offset = "0x50")]
	private UIQuestSlotInPoliceBook[] questSlots;

	// Token: 0x0400A309 RID: 41737
	[Token(Token = "0x4007B3E")]
	[FieldOffset(Offset = "0x58")]
	private List<OrderData> AcceptOrderDatas;

	// Token: 0x0400A30A RID: 41738
	[Token(Token = "0x4007B3F")]
	[FieldOffset(Offset = "0x60")]
	private int OpenedNpcRequester;

	// Token: 0x0400A30B RID: 41739
	[Token(Token = "0x4007B40")]
	[FieldOffset(Offset = "0x64")]
	private int currentDispNo;

	// Token: 0x02000A2A RID: 2602
	[Token(Token = "0x20012D7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159050", Offset = "0x159151")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600441F RID: 17439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075F9")]
		[Address(RVA = "0x2002380", Offset = "0x2002481", VA = "0x2002380")]
		public <>c()
		{
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00016B30 File Offset: 0x00014D30
		[Token(Token = "0x60075FA")]
		[Address(RVA = "0x2002390", Offset = "0x2002491", VA = "0x2002390")]
		internal bool <DispAll>b__14_0(OrderData order)
		{
			return default(bool);
		}

		// Token: 0x0400A30C RID: 41740
		[Token(Token = "0x401B42E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UICampQuestMain.<>c <>9;

		// Token: 0x0400A30D RID: 41741
		[Token(Token = "0x401B42F")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<OrderData> <>9__14_0;
	}
}
