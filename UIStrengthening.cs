using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000ACF RID: 2767
[Token(Token = "0x200073F")]
public class UIStrengthening : CursorLinkConnector
{
	// Token: 0x060047DF RID: 18399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C2B")]
	[Address(RVA = "0x211F900", Offset = "0x211FA01", VA = "0x211F900")]
	private void Start()
	{
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C2C")]
	[Address(RVA = "0x211FE60", Offset = "0x211FF61", VA = "0x211FE60")]
	private void OnDestroy()
	{
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C2D")]
	[Address(RVA = "0x211FAF0", Offset = "0x211FBF1", VA = "0x211FAF0")]
	public void PreviwStrengtheningResult()
	{
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C2E")]
	[Address(RVA = "0x2120240", Offset = "0x2120341", VA = "0x2120240")]
	public void DoStrengthening()
	{
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C2F")]
	[Address(RVA = "0x2120820", Offset = "0x2120921", VA = "0x2120820")]
	private void OnResultWindow()
	{
	}

	// Token: 0x060047E4 RID: 18404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C30")]
	[Address(RVA = "0x211FEC0", Offset = "0x211FFC1", VA = "0x211FEC0")]
	private void UpdateRPText()
	{
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C31")]
	[Address(RVA = "0x211FA60", Offset = "0x211FB61", VA = "0x211FA60")]
	private void UpdatePlayerStatusOnTopMenu()
	{
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x00017700 File Offset: 0x00015900
	[Token(Token = "0x6003C32")]
	[Address(RVA = "0x2120EC0", Offset = "0x2120FC1", VA = "0x2120EC0")]
	public bool IsItemEnableStrengthening(ItemData _item_data)
	{
		return default(bool);
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C33")]
	[Address(RVA = "0x2120FA0", Offset = "0x21210A1", VA = "0x2120FA0")]
	public UIStrengthening()
	{
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C35")]
	[Address(RVA = "0x2121080", Offset = "0x2121181", VA = "0x2121080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8250", Offset = "0x1A8351")]
	private void <DoStrengthening>b__13_2()
	{
	}

	// Token: 0x0400A73F RID: 42815
	[Token(Token = "0x4007E64")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsWeapon;

	// Token: 0x0400A740 RID: 42816
	[Token(Token = "0x4007E65")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UIStrengtheningTopMenu topMenu;

	// Token: 0x0400A741 RID: 42817
	[Token(Token = "0x4007E66")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text rpCostText;

	// Token: 0x0400A742 RID: 42818
	[Token(Token = "0x4007E67")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UICraftResult strengtheningResult;

	// Token: 0x0400A743 RID: 42819
	[Token(Token = "0x4007E68")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private CursorLinker firstCursor;

	// Token: 0x0400A744 RID: 42820
	[Token(Token = "0x4007E69")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ButtonLinker confirmOKButton;

	// Token: 0x0400A745 RID: 42821
	[Token(Token = "0x4007E6A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private List<UIStrengtheningSlot> strengtheningSlot;

	// Token: 0x0400A746 RID: 42822
	[Token(Token = "0x4007E6B")]
	[FieldOffset(Offset = "0x88")]
	private bool enoughRP;

	// Token: 0x0400A747 RID: 42823
	[Token(Token = "0x4007E6C")]
	[FieldOffset(Offset = "0x8C")]
	private int cost;

	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2001312")]
	public enum SlotType
	{
		// Token: 0x0400A749 RID: 42825
		[Token(Token = "0x401B53F")]
		None = -1,
		// Token: 0x0400A74A RID: 42826
		[Token(Token = "0x401B540")]
		BaseItem,
		// Token: 0x0400A74B RID: 42827
		[Token(Token = "0x401B541")]
		Material,
		// Token: 0x0400A74C RID: 42828
		[Token(Token = "0x401B542")]
		Result
	}

	// Token: 0x02000AD1 RID: 2769
	[Token(Token = "0x2001313")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1592A0", Offset = "0x1593A1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060047EB RID: 18411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007699")]
		[Address(RVA = "0x2121100", Offset = "0x2121201", VA = "0x2121100")]
		public <>c()
		{
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769A")]
		[Address(RVA = "0x2121110", Offset = "0x2121211", VA = "0x2121110")]
		internal void <DoStrengthening>b__13_0(bool _select)
		{
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769B")]
		[Address(RVA = "0x2121120", Offset = "0x2121221", VA = "0x2121120")]
		internal void <DoStrengthening>b__13_1(bool _select)
		{
		}

		// Token: 0x0400A74D RID: 42829
		[Token(Token = "0x401B543")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStrengthening.<>c <>9;

		// Token: 0x0400A74E RID: 42830
		[Token(Token = "0x401B544")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__13_0;

		// Token: 0x0400A74F RID: 42831
		[Token(Token = "0x401B545")]
		[FieldOffset(Offset = "0x10")]
		public static UnityAction<bool> <>9__13_1;
	}
}
