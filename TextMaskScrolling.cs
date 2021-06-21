using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD8 RID: 2776
[Token(Token = "0x2000746")]
public class TextMaskScrolling : MonoBehaviour
{
	// Token: 0x06004812 RID: 18450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5A")]
	[Address(RVA = "0x1F6CBB0", Offset = "0x1F6CCB1", VA = "0x1F6CBB0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5B")]
	[Address(RVA = "0x1F6CD90", Offset = "0x1F6CE91", VA = "0x1F6CD90")]
	private void Awake()
	{
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5C")]
	[Address(RVA = "0x1F6CF50", Offset = "0x1F6D051", VA = "0x1F6CF50")]
	private void Update()
	{
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5D")]
	[Address(RVA = "0x1F6CBC0", Offset = "0x1F6CCC1", VA = "0x1F6CBC0")]
	private void SetText()
	{
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5E")]
	[Address(RVA = "0x1F6D0B0", Offset = "0x1F6D1B1", VA = "0x1F6D0B0")]
	private void ScrollMove()
	{
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C5F")]
	[Address(RVA = "0x1F6D1F0", Offset = "0x1F6D2F1", VA = "0x1F6D1F0")]
	private void OnScrollBarDrag(float _value)
	{
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C60")]
	[Address(RVA = "0x1F6D3B0", Offset = "0x1F6D4B1", VA = "0x1F6D3B0")]
	public void SetScrollBarActive(bool _flag)
	{
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C61")]
	[Address(RVA = "0x1F6D480", Offset = "0x1F6D581", VA = "0x1F6D480")]
	public TextMaskScrolling()
	{
	}

	// Token: 0x0400A774 RID: 42868
	[Token(Token = "0x4007E91")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float scrollSpd;

	// Token: 0x0400A775 RID: 42869
	[Token(Token = "0x4007E92")]
	[FieldOffset(Offset = "0x20")]
	private Scrollbar scrollBar;

	// Token: 0x0400A776 RID: 42870
	[Token(Token = "0x4007E93")]
	[FieldOffset(Offset = "0x28")]
	private Text childText;

	// Token: 0x0400A777 RID: 42871
	[Token(Token = "0x4007E94")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform rect;

	// Token: 0x0400A778 RID: 42872
	[Token(Token = "0x4007E95")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform childRect;

	// Token: 0x0400A779 RID: 42873
	[Token(Token = "0x4007E96")]
	[FieldOffset(Offset = "0x40")]
	private float maxHeight;

	// Token: 0x0400A77A RID: 42874
	[Token(Token = "0x4007E97")]
	[FieldOffset(Offset = "0x44")]
	private float textHeight;

	// Token: 0x0400A77B RID: 42875
	[Token(Token = "0x4007E98")]
	[FieldOffset(Offset = "0x48")]
	private float scrollSpace;

	// Token: 0x0400A77C RID: 42876
	[Token(Token = "0x4007E99")]
	[FieldOffset(Offset = "0x4C")]
	private float scrolling;

	// Token: 0x0400A77D RID: 42877
	[Token(Token = "0x4007E9A")]
	[FieldOffset(Offset = "0x50")]
	private string textChecker;

	// Token: 0x0400A77E RID: 42878
	[Token(Token = "0x4007E9B")]
	[FieldOffset(Offset = "0x58")]
	private bool isScrollActive;
}
