using System;
using Il2CppDummyDll;

// Token: 0x02000948 RID: 2376
[Token(Token = "0x2000639")]
public abstract class UIButtonLinkerInScrollBox : ButtonLinker
{
	// Token: 0x170008DA RID: 2266
	// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x000156F0 File Offset: 0x000138F0
	// (set) Token: 0x06003EF6 RID: 16118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000715")]
	public int SlotNo
	{
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x1FFF510", Offset = "0x1FFF611", VA = "0x1FFF510")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F20", Offset = "0x1A7021")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600345D")]
		[Address(RVA = "0x1FFF520", Offset = "0x1FFF621", VA = "0x1FFF520")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F30", Offset = "0x1A7031")]
		private set
		{
		}
	}

	// Token: 0x170008DB RID: 2267
	// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x00015708 File Offset: 0x00013908
	// (set) Token: 0x06003EF8 RID: 16120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000716")]
	public bool IsTop
	{
		[Token(Token = "0x600345E")]
		[Address(RVA = "0x1FFF530", Offset = "0x1FFF631", VA = "0x1FFF530")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F40", Offset = "0x1A7041")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600345F")]
		[Address(RVA = "0x1FFF540", Offset = "0x1FFF641", VA = "0x1FFF540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F50", Offset = "0x1A7051")]
		private set
		{
		}
	}

	// Token: 0x170008DC RID: 2268
	// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x00015720 File Offset: 0x00013920
	// (set) Token: 0x06003EFA RID: 16122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000717")]
	public bool IsBottom
	{
		[Token(Token = "0x6003460")]
		[Address(RVA = "0x1FFF550", Offset = "0x1FFF651", VA = "0x1FFF550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F60", Offset = "0x1A7061")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003461")]
		[Address(RVA = "0x1FFF560", Offset = "0x1FFF661", VA = "0x1FFF560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F70", Offset = "0x1A7071")]
		private set
		{
		}
	}

	// Token: 0x170008DD RID: 2269
	// (get) Token: 0x06003EFB RID: 16123 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003EFC RID: 16124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000718")]
	private protected UIScrollBoxBase UIScrollBox
	{
		[Token(Token = "0x6003462")]
		[Address(RVA = "0x1FFF570", Offset = "0x1FFF671", VA = "0x1FFF570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F80", Offset = "0x1A7081")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x6003463")]
		[Address(RVA = "0x1FFF580", Offset = "0x1FFF681", VA = "0x1FFF580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6F90", Offset = "0x1A7091")]
		private set
		{
		}
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003464")]
	[Address(RVA = "0x1FFF590", Offset = "0x1FFF691", VA = "0x1FFF590")]
	public void Setup(int _slot_no, bool _top, bool _bottom, UIScrollBoxBase _scroll_box)
	{
	}

	// Token: 0x06003EFE RID: 16126
	[Token(Token = "0x6003465")]
	public abstract void Init();

	// Token: 0x06003EFF RID: 16127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003466")]
	[Address(RVA = "0x1FFF5B0", Offset = "0x1FFF6B1", VA = "0x1FFF5B0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003467")]
	[Address(RVA = "0x1FFF5F0", Offset = "0x1FFF6F1", VA = "0x1FFF5F0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003468")]
	[Address(RVA = "0x1FFF670", Offset = "0x1FFF771", VA = "0x1FFF670", Slot = "15")]
	public override void OnTouch()
	{
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003469")]
	[Address(RVA = "0x1FFF6B0", Offset = "0x1FFF7B1", VA = "0x1FFF6B0")]
	protected UIButtonLinkerInScrollBox()
	{
	}

	// Token: 0x04008083 RID: 32899
	[Token(Token = "0x40073C6")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F640", Offset = "0x16F741")]
	private int <SlotNo>k__BackingField;

	// Token: 0x04008084 RID: 32900
	[Token(Token = "0x40073C7")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F650", Offset = "0x16F751")]
	private bool <IsTop>k__BackingField;

	// Token: 0x04008085 RID: 32901
	[Token(Token = "0x40073C8")]
	[FieldOffset(Offset = "0x61")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F660", Offset = "0x16F761")]
	private bool <IsBottom>k__BackingField;

	// Token: 0x04008086 RID: 32902
	[Token(Token = "0x40073C9")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F670", Offset = "0x16F771")]
	private UIScrollBoxBase <UIScrollBox>k__BackingField;
}
