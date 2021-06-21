using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B13 RID: 2835
[Token(Token = "0x2000761")]
public class FocusSwitchObjectMain : MonoBehaviour
{
	// Token: 0x06004972 RID: 18802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D6A")]
	[Address(RVA = "0x1ECD530", Offset = "0x1ECD631", VA = "0x1ECD530")]
	private void OnEnable()
	{
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D6B")]
	[Address(RVA = "0x1ECD3F0", Offset = "0x1ECD4F1", VA = "0x1ECD3F0")]
	public void OpenPage(CursorLinker newPage)
	{
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D6C")]
	[Address(RVA = "0x1ECD540", Offset = "0x1ECD641", VA = "0x1ECD540")]
	public FocusSwitchObjectMain()
	{
	}

	// Token: 0x0400A943 RID: 43331
	[Token(Token = "0x4007F7E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CursorLinker firstPage;

	// Token: 0x0400A944 RID: 43332
	[Token(Token = "0x4007F7F")]
	[FieldOffset(Offset = "0x20")]
	private CursorLinker nowPage;
}
