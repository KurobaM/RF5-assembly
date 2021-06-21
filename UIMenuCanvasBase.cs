using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A73 RID: 2675
[Token(Token = "0x2000705")]
public class UIMenuCanvasBase : MonoBehaviour
{
	// Token: 0x060045CE RID: 17870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A71")]
	[Address(RVA = "0x201D080", Offset = "0x201D181", VA = "0x201D080", Slot = "4")]
	protected virtual void Start()
	{
	}

	// Token: 0x060045CF RID: 17871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A72")]
	[Address(RVA = "0x2026D80", Offset = "0x2026E81", VA = "0x2026D80", Slot = "5")]
	public virtual void StartMainCanvas()
	{
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A73")]
	[Address(RVA = "0x2026DB0", Offset = "0x2026EB1", VA = "0x2026DB0", Slot = "6")]
	public virtual void StartCanvas()
	{
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A74")]
	[Address(RVA = "0x201E4F0", Offset = "0x201E5F1", VA = "0x201E4F0", Slot = "7")]
	public virtual void CloseCanvas()
	{
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A75")]
	[Address(RVA = "0x201DB40", Offset = "0x201DC41", VA = "0x201DB40")]
	public void CloseAllCanvas()
	{
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A76")]
	[Address(RVA = "0x2026DD0", Offset = "0x2026ED1", VA = "0x2026DD0", Slot = "8")]
	public virtual void OpenMainCanvas(CursorLinker firstActiveGroup)
	{
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A77")]
	[Address(RVA = "0x201ED10", Offset = "0x201EE11", VA = "0x201ED10")]
	public UIMenuCanvasBase()
	{
	}

	// Token: 0x0400A4C2 RID: 42178
	[Token(Token = "0x4007C88")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected CursorController MyCursor;

	// Token: 0x0400A4C3 RID: 42179
	[Token(Token = "0x4007C89")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected CursorLinker FirstActiveCenterGroup;

	// Token: 0x0400A4C4 RID: 42180
	[Token(Token = "0x4007C8A")]
	[FieldOffset(Offset = "0x28")]
	protected bool MenuOpened;

	// Token: 0x0400A4C5 RID: 42181
	[Token(Token = "0x4007C8B")]
	[FieldOffset(Offset = "0x30")]
	private Animator CanvasActivateAnimator;

	// Token: 0x0400A4C6 RID: 42182
	[Token(Token = "0x4007C8C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected CursorLinker MainMenuObject;
}
