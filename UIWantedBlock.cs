using System;
using Il2CppDummyDll;
using RF5WANTED;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000A7B RID: 2683
[Token(Token = "0x200070A")]
public class UIWantedBlock : MonoBehaviour
{
	// Token: 0x060045FA RID: 17914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A97")]
	[Address(RVA = "0x2123AF0", Offset = "0x2123BF1", VA = "0x2123AF0")]
	public void SetMonsterIcon(WantedData wantedData, SpriteAtlas spriteAtlas)
	{
	}

	// Token: 0x060045FB RID: 17915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A98")]
	[Address(RVA = "0x2123C00", Offset = "0x2123D01", VA = "0x2123C00")]
	public void SetBlock(WantedData wantedData, SpriteAtlas spriteAtlas)
	{
	}

	// Token: 0x060045FC RID: 17916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A99")]
	[Address(RVA = "0x2123E10", Offset = "0x2123F11", VA = "0x2123E10")]
	public UIWantedBlock()
	{
	}

	// Token: 0x0400A4F0 RID: 42224
	[Token(Token = "0x4007C9C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image QuestionIcon;

	// Token: 0x0400A4F1 RID: 42225
	[Token(Token = "0x4007C9D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image MonsterIcon;

	// Token: 0x0400A4F2 RID: 42226
	[Token(Token = "0x4007C9E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image[] StarRanks;

	// Token: 0x0400A4F3 RID: 42227
	[Token(Token = "0x4007C9F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite StarOn;

	// Token: 0x0400A4F4 RID: 42228
	[Token(Token = "0x4007CA0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Sprite StarOff;

	// Token: 0x0400A4F5 RID: 42229
	[Token(Token = "0x4007CA1")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image CleardStamp;
}
