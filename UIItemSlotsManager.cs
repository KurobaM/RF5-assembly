using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using RF5Input;

// Token: 0x020009E2 RID: 2530
[Token(Token = "0x20006A1")]
public class UIItemSlotsManager : SingletonMonoBehaviour<UIItemSlotsManager>
{
	// Token: 0x06004253 RID: 16979 RVA: 0x00016548 File Offset: 0x00014748
	[Token(Token = "0x6003774")]
	[Address(RVA = "0x201B670", Offset = "0x201B771", VA = "0x201B670")]
	public bool IsSelecting()
	{
		return default(bool);
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003775")]
	[Address(RVA = "0x201BA30", Offset = "0x201BB31", VA = "0x201BA30")]
	private void ClearItem()
	{
	}

	// Token: 0x06004255 RID: 16981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003776")]
	[Address(RVA = "0x2019C00", Offset = "0x2019D01", VA = "0x2019C00")]
	public void AddSlot(UIItemSlot itemSlot)
	{
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003777")]
	[Address(RVA = "0x2019A00", Offset = "0x2019B01", VA = "0x2019A00")]
	public void RemoveSlot(UIItemSlot itemSlot)
	{
	}

	// Token: 0x06004257 RID: 16983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003778")]
	[Address(RVA = "0x201BB60", Offset = "0x201BC61", VA = "0x201BB60")]
	public void ReDispAll()
	{
	}

	// Token: 0x06004258 RID: 16984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003779")]
	[Address(RVA = "0x201BC80", Offset = "0x201BD81", VA = "0x201BC80")]
	public void ReDispAllSelecting()
	{
	}

	// Token: 0x06004259 RID: 16985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377A")]
	[Address(RVA = "0x201BD90", Offset = "0x201BE91", VA = "0x201BD90")]
	private void SplitItem(UIItemSlot slotA)
	{
	}

	// Token: 0x0600425A RID: 16986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377B")]
	[Address(RVA = "0x201BF60", Offset = "0x201C061", VA = "0x201BF60")]
	private void RefillItemSlot(UIItemSlot slotA, UIItemSlot slotB)
	{
	}

	// Token: 0x0600425B RID: 16987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377C")]
	[Address(RVA = "0x201A7B0", Offset = "0x201A8B1", VA = "0x201A7B0")]
	public void SwapSlot(UIItemSlot slotA, UIItemSlot slotB)
	{
	}

	// Token: 0x0600425C RID: 16988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377D")]
	[Address(RVA = "0x201C060", Offset = "0x201C161", VA = "0x201C060")]
	private void SelectItemSlot()
	{
	}

	// Token: 0x0600425D RID: 16989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377E")]
	[Address(RVA = "0x201C330", Offset = "0x201C431", VA = "0x201C330")]
	private void DoEquipItemSlot()
	{
	}

	// Token: 0x0600425E RID: 16990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600377F")]
	[Address(RVA = "0x201C410", Offset = "0x201C511", VA = "0x201C410")]
	private void PushSelectSlot()
	{
	}

	// Token: 0x0600425F RID: 16991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003780")]
	[Address(RVA = "0x201C5D0", Offset = "0x201C6D1", VA = "0x201C5D0")]
	public void ReleaseItemSlot()
	{
	}

	// Token: 0x06004260 RID: 16992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003781")]
	[Address(RVA = "0x201C800", Offset = "0x201C901", VA = "0x201C800")]
	public void ReCheckFilterAll()
	{
	}

	// Token: 0x06004261 RID: 16993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003782")]
	[Address(RVA = "0x201C210", Offset = "0x201C311", VA = "0x201C210")]
	public void SetFilterGuardAllItem(UIItemSlot itemSlot)
	{
	}

	// Token: 0x06004262 RID: 16994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003783")]
	[Address(RVA = "0x201C8A0", Offset = "0x201C9A1", VA = "0x201C8A0")]
	public void SetFilterGuardAllItem(UIItemSlotsManager.PickingItem PickingItem)
	{
	}

	// Token: 0x06004263 RID: 16995 RVA: 0x00016560 File Offset: 0x00014760
	[Token(Token = "0x6003784")]
	[Address(RVA = "0x201C9F0", Offset = "0x201CAF1", VA = "0x201C9F0")]
	private bool CheckTargetSlotNoGuard()
	{
		return default(bool);
	}

	// Token: 0x06004264 RID: 16996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003785")]
	[Address(RVA = "0x201CA70", Offset = "0x201CB71", VA = "0x201CA70")]
	public void OnClosePage()
	{
	}

	// Token: 0x06004265 RID: 16997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003786")]
	[Address(RVA = "0x201AA10", Offset = "0x201AB11", VA = "0x201AA10")]
	public void PushButton(Key padId)
	{
	}

	// Token: 0x06004266 RID: 16998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003787")]
	[Address(RVA = "0x201CB20", Offset = "0x201CC21", VA = "0x201CB20")]
	public void SetFocusIn(UIItemSlot inslot)
	{
	}

	// Token: 0x06004267 RID: 16999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003788")]
	[Address(RVA = "0x201A130", Offset = "0x201A231", VA = "0x201A130")]
	public void SetFocusOut(UIItemSlot outslot)
	{
	}

	// Token: 0x06004268 RID: 17000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003789")]
	[Address(RVA = "0x201AC30", Offset = "0x201AD31", VA = "0x201AC30")]
	public void FocusingUpdate()
	{
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378A")]
	[Address(RVA = "0x201CB30", Offset = "0x201CC31", VA = "0x201CB30")]
	private void Start()
	{
	}

	// Token: 0x0600426A RID: 17002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378B")]
	[Address(RVA = "0x201CBA0", Offset = "0x201CCA1", VA = "0x201CBA0")]
	public UIItemSlotsManager()
	{
	}

	// Token: 0x0400A106 RID: 41222
	[Token(Token = "0x4007986")]
	[FieldOffset(Offset = "0x18")]
	private List<UIItemSlot> UIItemSlotList;

	// Token: 0x0400A107 RID: 41223
	[Token(Token = "0x4007987")]
	[FieldOffset(Offset = "0x20")]
	public UIItemSlot SelectSlot;

	// Token: 0x0400A108 RID: 41224
	[Token(Token = "0x4007988")]
	[FieldOffset(Offset = "0x28")]
	private UIItemSlot focusingSlot;

	// Token: 0x0400A109 RID: 41225
	[Token(Token = "0x4007989")]
	[FieldOffset(Offset = "0x30")]
	private GenerateItemSlot NowFocusGenerator;

	// Token: 0x0400A10A RID: 41226
	[Token(Token = "0x400798A")]
	[FieldOffset(Offset = "0x38")]
	public StorageType LinkingStorageType;

	// Token: 0x0400A10B RID: 41227
	[Token(Token = "0x400798B")]
	[FieldOffset(Offset = "0x40")]
	public UIItemSlotsManager.PickingItem pickItem;

	// Token: 0x020009E3 RID: 2531
	[Token(Token = "0x20012C3")]
	public class PickingItem
	{
		// Token: 0x0600426B RID: 17003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C3")]
		[Address(RVA = "0x201CE00", Offset = "0x201CF01", VA = "0x201CE00")]
		public PickingItem()
		{
		}

		// Token: 0x0400A10C RID: 41228
		[Token(Token = "0x401B3E3")]
		[FieldOffset(Offset = "0x10")]
		public ItemStorage ItemStorage;

		// Token: 0x0400A10D RID: 41229
		[Token(Token = "0x401B3E4")]
		[FieldOffset(Offset = "0x18")]
		public int inStorageNum;

		// Token: 0x0400A10E RID: 41230
		[Token(Token = "0x401B3E5")]
		[FieldOffset(Offset = "0x20")]
		public ItemData ItemData;
	}

	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20012C4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F80", Offset = "0x159081")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C5")]
		[Address(RVA = "0x201CC60", Offset = "0x201CD61", VA = "0x201CC60")]
		public <>c()
		{
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x60075C6")]
		[Address(RVA = "0x201CC70", Offset = "0x201CD71", VA = "0x201CC70")]
		internal bool <ClearItem>b__8_0(UIItemSlot item)
		{
			return default(bool);
		}

		// Token: 0x0400A10F RID: 41231
		[Token(Token = "0x401B3E6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIItemSlotsManager.<>c <>9;

		// Token: 0x0400A110 RID: 41232
		[Token(Token = "0x401B3E7")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<UIItemSlot> <>9__8_0;
	}

	// Token: 0x020009E5 RID: 2533
	[Token(Token = "0x20012C5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F90", Offset = "0x159091")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x0600426F RID: 17007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C7")]
		[Address(RVA = "0x201BB50", Offset = "0x201BC51", VA = "0x201BB50")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x60075C8")]
		[Address(RVA = "0x201CD20", Offset = "0x201CE21", VA = "0x201CD20")]
		internal bool <RemoveSlot>b__0(UIItemSlot item)
		{
			return default(bool);
		}

		// Token: 0x0400A111 RID: 41233
		[Token(Token = "0x401B3E8")]
		[FieldOffset(Offset = "0x10")]
		public UIItemSlot itemSlot;
	}
}
