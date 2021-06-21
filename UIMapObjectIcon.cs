using System;
using Il2CppDummyDll;
using R5UI;
using UnityEngine;

// Token: 0x020009F0 RID: 2544
[Token(Token = "0x20006AB")]
public class UIMapObjectIcon : MonoBehaviour
{
	// Token: 0x1700092A RID: 2346
	// (get) Token: 0x060042C5 RID: 17093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000758")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x60037DA")]
		[Address(RVA = "0x20263C0", Offset = "0x20264C1", VA = "0x20263C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700092B RID: 2347
	// (get) Token: 0x060042C6 RID: 17094 RVA: 0x000166F8 File Offset: 0x000148F8
	[Token(Token = "0x17000759")]
	public Rect rect
	{
		[Token(Token = "0x60037DB")]
		[Address(RVA = "0x2026470", Offset = "0x2026571", VA = "0x2026470")]
		get
		{
			return default(Rect);
		}
	}

	// Token: 0x060042C7 RID: 17095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037DC")]
	[Address(RVA = "0x2026830", Offset = "0x2026931", VA = "0x2026830")]
	public void OnSelect()
	{
	}

	// Token: 0x060042C8 RID: 17096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037DD")]
	[Address(RVA = "0x2026AE0", Offset = "0x2026BE1", VA = "0x2026AE0")]
	public void OutSelect()
	{
	}

	// Token: 0x060042C9 RID: 17097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037DE")]
	[Address(RVA = "0x2026D70", Offset = "0x2026E71", VA = "0x2026D70")]
	public UIMapObjectIcon()
	{
	}

	// Token: 0x0400A173 RID: 41331
	[Token(Token = "0x40079E7")]
	[FieldOffset(Offset = "0x18")]
	public MAPWINDOWSTYPE type;

	// Token: 0x0400A174 RID: 41332
	[Token(Token = "0x40079E8")]
	[FieldOffset(Offset = "0x1C")]
	private bool rectSetted;

	// Token: 0x0400A175 RID: 41333
	[Token(Token = "0x40079E9")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform _rectTransform;

	// Token: 0x0400A176 RID: 41334
	[Token(Token = "0x40079EA")]
	[FieldOffset(Offset = "0x28")]
	private Rect _rect;
}
