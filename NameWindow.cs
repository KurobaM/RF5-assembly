using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000459 RID: 1113
[Token(Token = "0x2000356")]
public class NameWindow : MonoBehaviour
{
	// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F3")]
	[Address(RVA = "0x1E22970", Offset = "0x1E22A71", VA = "0x1E22970")]
	public void SetName(string name, bool moreThanLover = false)
	{
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x1E22A50", Offset = "0x1E22B51", VA = "0x1E22A50")]
	public void Enable(bool flag)
	{
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x1E22A90", Offset = "0x1E22B91", VA = "0x1E22A90")]
	public NameWindow()
	{
	}

	// Token: 0x04005DE8 RID: 24040
	[Token(Token = "0x40059F7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x04005DE9 RID: 24041
	[Token(Token = "0x40059F8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text nameText;

	// Token: 0x04005DEA RID: 24042
	[Token(Token = "0x40059F9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite NameWindowSpriteDefault;

	// Token: 0x04005DEB RID: 24043
	[Token(Token = "0x40059FA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite NameWindowSpriteMarried;

	// Token: 0x04005DEC RID: 24044
	[Token(Token = "0x40059FB")]
	[FieldOffset(Offset = "0x38")]
	private TextOverwriteList TextOverwriteList;
}
