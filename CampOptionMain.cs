using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A97 RID: 2711
[Token(Token = "0x200071A")]
public class CampOptionMain : MonoBehaviour
{
	// Token: 0x0600467F RID: 18047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B03")]
	[Address(RVA = "0x1E7BAA0", Offset = "0x1E7BBA1", VA = "0x1E7BAA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B04")]
	[Address(RVA = "0x1E7BAB0", Offset = "0x1E7BBB1", VA = "0x1E7BAB0")]
	public void OpenPage(CursorLinker newPage)
	{
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B05")]
	[Address(RVA = "0x1E7BBE0", Offset = "0x1E7BCE1", VA = "0x1E7BBE0")]
	private void Update()
	{
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B06")]
	[Address(RVA = "0x1E7BDE0", Offset = "0x1E7BEE1", VA = "0x1E7BDE0")]
	public CampOptionMain()
	{
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B07")]
	[Address(RVA = "0x1E7BDF0", Offset = "0x1E7BEF1", VA = "0x1E7BDF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7EB0", Offset = "0x1A7FB1")]
	private void <Update>b__6_0(bool select)
	{
	}

	// Token: 0x0400A580 RID: 42368
	[Token(Token = "0x4007D04")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CursorLinker firstPage;

	// Token: 0x0400A581 RID: 42369
	[Token(Token = "0x4007D05")]
	[FieldOffset(Offset = "0x20")]
	private CursorLinker lastCursorLinker;

	// Token: 0x0400A582 RID: 42370
	[Token(Token = "0x4007D06")]
	[FieldOffset(Offset = "0x28")]
	private CursorLinker nowPage;

	// Token: 0x0400A583 RID: 42371
	[Token(Token = "0x4007D07")]
	[FieldOffset(Offset = "0x30")]
	private bool openedSetDefault;
}
