using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A98 RID: 2712
[Token(Token = "0x200071B")]
public class OpenPageButton : ButtonWorkBase
{
	// Token: 0x06004684 RID: 18052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B08")]
	[Address(RVA = "0x20C6050", Offset = "0x20C6151", VA = "0x20C6050", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06004685 RID: 18053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B09")]
	[Address(RVA = "0x20C60F0", Offset = "0x20C61F1", VA = "0x20C60F0", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B0A")]
	[Address(RVA = "0x20C62E0", Offset = "0x20C63E1", VA = "0x20C62E0")]
	public OpenPageButton()
	{
	}

	// Token: 0x0400A584 RID: 42372
	[Token(Token = "0x4007D08")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CampOptionMain optionMain;

	// Token: 0x0400A585 RID: 42373
	[Token(Token = "0x4007D09")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CursorLinker linkerObj;

	// Token: 0x0400A586 RID: 42374
	[Token(Token = "0x4007D0A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> OpenObjects;

	// Token: 0x0400A587 RID: 42375
	[Token(Token = "0x4007D0B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> CloseObjects;
}
