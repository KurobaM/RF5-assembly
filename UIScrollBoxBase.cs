using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000954 RID: 2388
[Token(Token = "0x2000642")]
public abstract class UIScrollBoxBase : MonoBehaviour
{
	// Token: 0x170008E8 RID: 2280
	// (get) Token: 0x06003F4B RID: 16203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700071E")]
	protected GameObject ButtonListParent
	{
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x1EB5ED0", Offset = "0x1EB5FD1", VA = "0x1EB5ED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170008E9 RID: 2281
	// (get) Token: 0x06003F4C RID: 16204 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003F4D RID: 16205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700071F")]
	private protected UIButtonLinkerInScrollBox FocusingButton
	{
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x1EB5EE0", Offset = "0x1EB5FE1", VA = "0x1EB5EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7100", Offset = "0x1A7201")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x1EB5EF0", Offset = "0x1EB5FF1", VA = "0x1EB5EF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7110", Offset = "0x1A7211")]
		private set
		{
		}
	}

	// Token: 0x170008EA RID: 2282
	// (get) Token: 0x06003F4E RID: 16206 RVA: 0x000157F8 File Offset: 0x000139F8
	// (set) Token: 0x06003F4F RID: 16207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000720")]
	private protected int ScrollRange
	{
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x1EB5F00", Offset = "0x1EB6001", VA = "0x1EB5F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7120", Offset = "0x1A7221")]
		protected get
		{
			return 0;
		}
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x1EB5F10", Offset = "0x1EB6011", VA = "0x1EB5F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7130", Offset = "0x1A7231")]
		private set
		{
		}
	}

	// Token: 0x170008EB RID: 2283
	// (get) Token: 0x06003F50 RID: 16208 RVA: 0x00015810 File Offset: 0x00013A10
	// (set) Token: 0x06003F51 RID: 16209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000721")]
	private protected int ScrollHeadIndex
	{
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x1EB5F20", Offset = "0x1EB6021", VA = "0x1EB5F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7140", Offset = "0x1A7241")]
		protected get
		{
			return 0;
		}
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x1EB5F30", Offset = "0x1EB6031", VA = "0x1EB5F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7150", Offset = "0x1A7251")]
		private set
		{
		}
	}

	// Token: 0x170008EC RID: 2284
	// (get) Token: 0x06003F52 RID: 16210 RVA: 0x00015828 File Offset: 0x00013A28
	[Token(Token = "0x17000722")]
	protected int ScrollIndex
	{
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x1EABEA0", Offset = "0x1EABFA1", VA = "0x1EABEA0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x06003F53 RID: 16211 RVA: 0x00015840 File Offset: 0x00013A40
	// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000723")]
	private protected int ButtonMax
	{
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x1EB5F40", Offset = "0x1EB6041", VA = "0x1EB5F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7160", Offset = "0x1A7261")]
		protected get
		{
			return 0;
		}
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x1EB5F50", Offset = "0x1EB6051", VA = "0x1EB5F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7170", Offset = "0x1A7271")]
		private set
		{
		}
	}

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06003F55 RID: 16213 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003F56 RID: 16214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000724")]
	private protected List<UIButtonLinkerInScrollBox> ButtonList
	{
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x1EB5F60", Offset = "0x1EB6061", VA = "0x1EB5F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7180", Offset = "0x1A7281")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x1EB5F70", Offset = "0x1EB6071", VA = "0x1EB5F70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7190", Offset = "0x1A7291")]
		private set
		{
		}
	}

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06003F57 RID: 16215 RVA: 0x00015858 File Offset: 0x00013A58
	[Token(Token = "0x17000725")]
	protected virtual int RowMax
	{
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x1EB5F80", Offset = "0x1EB6081", VA = "0x1EB5F80", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06003F58 RID: 16216
	[Token(Token = "0x60034AF")]
	protected abstract int GetListCount();

	// Token: 0x06003F59 RID: 16217
	[Token(Token = "0x60034B0")]
	protected abstract void SetButtonDisp(UIButtonLinkerInScrollBox button);

	// Token: 0x06003F5A RID: 16218
	[Token(Token = "0x60034B1")]
	public abstract void SetFocusDetail();

	// Token: 0x06003F5B RID: 16219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x1EAAD50", Offset = "0x1EAAE51", VA = "0x1EAAD50", Slot = "8")]
	protected virtual void Start()
	{
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x1EABB10", Offset = "0x1EABC11", VA = "0x1EABB10", Slot = "9")]
	protected virtual void Update()
	{
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B4")]
	[Address(RVA = "0x1EB24A0", Offset = "0x1EB25A1", VA = "0x1EB24A0", Slot = "10")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B5")]
	[Address(RVA = "0x1EAAFE0", Offset = "0x1EAB0E1", VA = "0x1EAAFE0")]
	protected void Setup()
	{
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B6")]
	[Address(RVA = "0x1EB6160", Offset = "0x1EB6261", VA = "0x1EB6160")]
	private void SetScrollBar()
	{
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B7")]
	[Address(RVA = "0x1EB5F90", Offset = "0x1EB6091", VA = "0x1EB5F90")]
	private void UpdateInput()
	{
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x1EB63F0", Offset = "0x1EB64F1", VA = "0x1EB63F0")]
	private void InputUp()
	{
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034B9")]
	[Address(RVA = "0x1EB6750", Offset = "0x1EB6851", VA = "0x1EB6750")]
	private void InputDown()
	{
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BA")]
	[Address(RVA = "0x1EB6A50", Offset = "0x1EB6B51", VA = "0x1EB6A50")]
	private void PageUp()
	{
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x1EB6C70", Offset = "0x1EB6D71", VA = "0x1EB6C70")]
	private void PageDown()
	{
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BC")]
	[Address(RVA = "0x1EB6F10", Offset = "0x1EB7011", VA = "0x1EB6F10")]
	public void SetFocusButton(UIButtonLinkerInScrollBox _button)
	{
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BD")]
	[Address(RVA = "0x1EAB6F0", Offset = "0x1EAB7F1", VA = "0x1EAB6F0")]
	public void RedispAll()
	{
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BE")]
	[Address(RVA = "0x1EB2BB0", Offset = "0x1EB2CB1", VA = "0x1EB2BB0")]
	public void ResetScrollBox(int _index = 0)
	{
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034BF")]
	[Address(RVA = "0x1EB5D10", Offset = "0x1EB5E11", VA = "0x1EB5D10")]
	public void SetScrollbarActive(bool _flag)
	{
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C0")]
	[Address(RVA = "0x1EB6370", Offset = "0x1EB6471", VA = "0x1EB6370")]
	private void SetScrollValue()
	{
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C1")]
	[Address(RVA = "0x1EB6F20", Offset = "0x1EB7021", VA = "0x1EB6F20")]
	private void OnScrollBarDrag(float _value)
	{
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C2")]
	[Address(RVA = "0x1EAC550", Offset = "0x1EAC651", VA = "0x1EAC550")]
	protected UIScrollBoxBase()
	{
	}

	// Token: 0x040080D1 RID: 32977
	[Token(Token = "0x4007402")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Scrollbar scrollBar;

	// Token: 0x040080D2 RID: 32978
	[Token(Token = "0x4007403")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject buttonListParent;

	// Token: 0x040080D3 RID: 32979
	[Token(Token = "0x4007404")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isEnableZR;

	// Token: 0x040080D4 RID: 32980
	[Token(Token = "0x4007405")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool isEnableStick;

	// Token: 0x040080D5 RID: 32981
	[Token(Token = "0x4007406")]
	[FieldOffset(Offset = "0x2C")]
	private float startPosY;

	// Token: 0x040080D6 RID: 32982
	[Token(Token = "0x4007407")]
	[FieldOffset(Offset = "0x30")]
	private float buttonSpace;

	// Token: 0x040080D7 RID: 32983
	[Token(Token = "0x4007408")]
	[FieldOffset(Offset = "0x34")]
	private readonly float SCROLL_SPEED;

	// Token: 0x040080D8 RID: 32984
	[Token(Token = "0x4007409")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F940", Offset = "0x16FA41")]
	private UIButtonLinkerInScrollBox <FocusingButton>k__BackingField;

	// Token: 0x040080D9 RID: 32985
	[Token(Token = "0x400740A")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F950", Offset = "0x16FA51")]
	private int <ScrollRange>k__BackingField;

	// Token: 0x040080DA RID: 32986
	[Token(Token = "0x400740B")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F960", Offset = "0x16FA61")]
	private int <ScrollHeadIndex>k__BackingField;

	// Token: 0x040080DB RID: 32987
	[Token(Token = "0x400740C")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F970", Offset = "0x16FA71")]
	private int <ButtonMax>k__BackingField;

	// Token: 0x040080DC RID: 32988
	[Token(Token = "0x400740D")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F980", Offset = "0x16FA81")]
	private List<UIButtonLinkerInScrollBox> <ButtonList>k__BackingField;

	// Token: 0x040080DD RID: 32989
	[Token(Token = "0x400740E")]
	[FieldOffset(Offset = "0x58")]
	private UIButtonLinkerInScrollBox[] topButton;

	// Token: 0x040080DE RID: 32990
	[Token(Token = "0x400740F")]
	[FieldOffset(Offset = "0x60")]
	private UIButtonLinkerInScrollBox[] bottomButton;
}
