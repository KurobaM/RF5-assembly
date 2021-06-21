using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AE1 RID: 2785
[Token(Token = "0x200074A")]
public class TitleButton : MonoBehaviour
{
	// Token: 0x17000996 RID: 2454
	// (get) Token: 0x0600484C RID: 18508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007AE")]
	public TitleChoiceButton ChoiceButton
	{
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x206D480", Offset = "0x206D581", VA = "0x206D480")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C8C")]
	[Address(RVA = "0x206D490", Offset = "0x206D591", VA = "0x206D490")]
	private void Start()
	{
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C8D")]
	[Address(RVA = "0x206D560", Offset = "0x206D661", VA = "0x206D560")]
	private void Update()
	{
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C8E")]
	[Address(RVA = "0x206D610", Offset = "0x206D711", VA = "0x206D610")]
	public void FocusThis(bool stat)
	{
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C8F")]
	[Address(RVA = "0x206D6E0", Offset = "0x206D7E1", VA = "0x206D6E0")]
	public void OnOffColor(bool flg)
	{
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x00017808 File Offset: 0x00015A08
	[Token(Token = "0x6003C90")]
	[Address(RVA = "0x206D7F0", Offset = "0x206D8F1", VA = "0x206D7F0")]
	public TitleCanvasControl.TitleButtonType GetButtonType()
	{
		return TitleCanvasControl.TitleButtonType.StartDebugGame;
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C91")]
	[Address(RVA = "0x206D800", Offset = "0x206D901", VA = "0x206D800")]
	public TitleButton()
	{
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C92")]
	[Address(RVA = "0x206D810", Offset = "0x206D911", VA = "0x206D810")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8310", Offset = "0x1A8411")]
	private void <Start>b__7_0()
	{
	}

	// Token: 0x06004854 RID: 18516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C93")]
	[Address(RVA = "0x206DA30", Offset = "0x206DB31", VA = "0x206DA30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8320", Offset = "0x1A8421")]
	private void <Start>b__7_1()
	{
	}

	// Token: 0x0400A7BB RID: 42939
	[Token(Token = "0x4007EC7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TitleCanvasControl.TitleButtonType type;

	// Token: 0x0400A7BC RID: 42940
	[Token(Token = "0x4007EC8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TitleCanvasControl TitleCanvasControl;

	// Token: 0x0400A7BD RID: 42941
	[Token(Token = "0x4007EC9")]
	[FieldOffset(Offset = "0x28")]
	private bool OnFocus;

	// Token: 0x0400A7BE RID: 42942
	[Token(Token = "0x4007ECA")]
	[FieldOffset(Offset = "0x30")]
	private Image OffImage;

	// Token: 0x0400A7BF RID: 42943
	[Token(Token = "0x4007ECB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TitleChoiceButton choiceButton;
}
