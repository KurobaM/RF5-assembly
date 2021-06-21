using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000B12 RID: 2834
[Token(Token = "0x2000760")]
public class FocusSwitchObjectButton : ButtonWorkBase
{
	// Token: 0x0600496F RID: 18799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D67")]
	[Address(RVA = "0x1ECD340", Offset = "0x1ECD441", VA = "0x1ECD340", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06004970 RID: 18800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D68")]
	[Address(RVA = "0x1ECD3D0", Offset = "0x1ECD4D1", VA = "0x1ECD3D0", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D69")]
	[Address(RVA = "0x1ECD520", Offset = "0x1ECD621", VA = "0x1ECD520")]
	public FocusSwitchObjectButton()
	{
	}

	// Token: 0x0400A941 RID: 43329
	[Token(Token = "0x4007F7C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FocusSwitchObjectMain FocusSwitchObjectMain;

	// Token: 0x0400A942 RID: 43330
	[Token(Token = "0x4007F7D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CursorLinker linkerObj;
}
