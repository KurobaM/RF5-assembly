using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A58 RID: 2648
[Token(Token = "0x20006F4")]
public class CraftNumButton : ButtonWorkBase
{
	// Token: 0x06004514 RID: 17684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039DE")]
	[Address(RVA = "0x20E9490", Offset = "0x20E9591", VA = "0x20E9490")]
	private void Start()
	{
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039DF")]
	[Address(RVA = "0x20E9570", Offset = "0x20E9671", VA = "0x20E9570", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E0")]
	[Address(RVA = "0x20E95A0", Offset = "0x20E96A1", VA = "0x20E95A0")]
	public CraftNumButton()
	{
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E1")]
	[Address(RVA = "0x20E95B0", Offset = "0x20E96B1", VA = "0x20E95B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AD0", Offset = "0x1A7BD1")]
	private void <Start>b__4_0()
	{
	}

	// Token: 0x0400A401 RID: 41985
	[Token(Token = "0x4007C09")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UICraftMenu UICraftMenu;

	// Token: 0x0400A402 RID: 41986
	[Token(Token = "0x4007C0A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isLeft;

	// Token: 0x0400A403 RID: 41987
	[Token(Token = "0x4007C0B")]
	[FieldOffset(Offset = "0x30")]
	private NonFocusButton nonFocusButton;

	// Token: 0x0400A404 RID: 41988
	[Token(Token = "0x4007C0C")]
	[FieldOffset(Offset = "0x38")]
	private ButtonLinker buttonLinker;
}
