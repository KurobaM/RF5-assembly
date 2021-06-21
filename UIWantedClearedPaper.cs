using System;
using Il2CppDummyDll;
using Loader;
using RF5WANTED;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000A7E RID: 2686
[Token(Token = "0x200070C")]
public class UIWantedClearedPaper : MonoBehaviour
{
	// Token: 0x06004607 RID: 17927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA4")]
	[Address(RVA = "0x2124FA0", Offset = "0x21250A1", VA = "0x2124FA0")]
	public void SetBlock(WantedData wantedData)
	{
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA5")]
	[Address(RVA = "0x2125110", Offset = "0x2125211", VA = "0x2125110")]
	private void Start()
	{
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA6")]
	[Address(RVA = "0x21253A0", Offset = "0x21254A1", VA = "0x21253A0")]
	public void LoadedMonsterIcon(AssetHandle<SpriteAtlas> _handle)
	{
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA7")]
	[Address(RVA = "0x2125490", Offset = "0x2125591", VA = "0x2125490")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003AA8")]
	[Address(RVA = "0x2125510", Offset = "0x2125611", VA = "0x2125510")]
	public UIWantedClearedPaper()
	{
	}

	// Token: 0x0400A50F RID: 42255
	[Token(Token = "0x4007CB6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image MonsterIcon;

	// Token: 0x0400A510 RID: 42256
	[Token(Token = "0x4007CB7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image[] StarRanks;

	// Token: 0x0400A511 RID: 42257
	[Token(Token = "0x4007CB8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite StarOn;

	// Token: 0x0400A512 RID: 42258
	[Token(Token = "0x4007CB9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite StarOff;

	// Token: 0x0400A513 RID: 42259
	[Token(Token = "0x4007CBA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text RewardText;

	// Token: 0x0400A514 RID: 42260
	[Token(Token = "0x4007CBB")]
	[FieldOffset(Offset = "0x40")]
	private int monsterSpriteId;

	// Token: 0x0400A515 RID: 42261
	[Token(Token = "0x4007CBC")]
	private const int SpriteAtlasId = 19765;

	// Token: 0x0400A516 RID: 42262
	[Token(Token = "0x4007CBD")]
	[FieldOffset(Offset = "0x48")]
	private AssetHandle<SpriteAtlas> handle;
}
