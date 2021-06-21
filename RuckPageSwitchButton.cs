using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A43 RID: 2627
[Token(Token = "0x20006E8")]
public class RuckPageSwitchButton : ButtonWorkBase
{
	// Token: 0x060044B0 RID: 17584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398D")]
	[Address(RVA = "0x27DD010", Offset = "0x27DD111", VA = "0x27DD010", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x060044B1 RID: 17585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398E")]
	[Address(RVA = "0x27DD0D0", Offset = "0x27DD1D1", VA = "0x27DD0D0", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x060044B2 RID: 17586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398F")]
	[Address(RVA = "0x27DD2E0", Offset = "0x27DD3E1", VA = "0x27DD2E0")]
	public RuckPageSwitchButton()
	{
	}

	// Token: 0x0400A388 RID: 41864
	[Token(Token = "0x4007BAE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CampOptionMain optionMain;

	// Token: 0x0400A389 RID: 41865
	[Token(Token = "0x4007BAF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CursorLinker linkerObj;

	// Token: 0x0400A38A RID: 41866
	[Token(Token = "0x4007BB0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> OpenObjects;

	// Token: 0x0400A38B RID: 41867
	[Token(Token = "0x4007BB1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> CloseObjects;
}
