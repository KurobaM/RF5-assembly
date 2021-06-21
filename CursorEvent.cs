using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000941 RID: 2369
[Token(Token = "0x2000634")]
public class CursorEvent : MonoBehaviour
{
	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x00015648 File Offset: 0x00013848
	[Token(Token = "0x1700070F")]
	public virtual bool UseCANCEL
	{
		[Token(Token = "0x600342E")]
		[Address(RVA = "0x20ED480", Offset = "0x20ED581", VA = "0x20ED480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003EC2 RID: 16066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600342F")]
	[Address(RVA = "0x20ED490", Offset = "0x20ED591", VA = "0x20ED490", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06003EC3 RID: 16067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003430")]
	[Address(RVA = "0x20ED4F0", Offset = "0x20ED5F1", VA = "0x20ED4F0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06003EC4 RID: 16068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003431")]
	[Address(RVA = "0x20ED5B0", Offset = "0x20ED6B1", VA = "0x20ED5B0", Slot = "7")]
	public virtual void OnFocusIn(CursorLinker focusObject)
	{
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003432")]
	[Address(RVA = "0x20ED5C0", Offset = "0x20ED6C1", VA = "0x20ED5C0", Slot = "8")]
	public virtual void OnFocusOut(CursorLinker outfocusObject, CursorLinker nextFocusObject)
	{
	}

	// Token: 0x06003EC6 RID: 16070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003433")]
	[Address(RVA = "0x20ED5D0", Offset = "0x20ED6D1", VA = "0x20ED5D0")]
	public CursorEvent()
	{
	}
}
