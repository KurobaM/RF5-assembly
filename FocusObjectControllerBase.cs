using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200098E RID: 2446
[Token(Token = "0x200066B")]
public abstract class FocusObjectControllerBase
{
	// Token: 0x170008FE RID: 2302
	// (get) Token: 0x06004009 RID: 16393 RVA: 0x00015B40 File Offset: 0x00013D40
	[Token(Token = "0x17000734")]
	public virtual FocusObjectType FocusObjectType
	{
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x1ECC100", Offset = "0x1ECC201", VA = "0x1ECC100", Slot = "4")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170008FF RID: 2303
	// (get) Token: 0x0600400A RID: 16394 RVA: 0x00015B58 File Offset: 0x00013D58
	[Token(Token = "0x17000735")]
	public virtual Color TextColor
	{
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x1ECC110", Offset = "0x1ECC211", VA = "0x1ECC110", Slot = "5")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x0600400B RID: 16395
	[Token(Token = "0x600355D")]
	public abstract FocusInterface GetFocus();

	// Token: 0x0600400C RID: 16396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600355E")]
	[Address(RVA = "0x1ECC120", Offset = "0x1ECC221", VA = "0x1ECC120")]
	protected FocusObjectControllerBase()
	{
	}
}
