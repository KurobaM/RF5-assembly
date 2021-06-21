using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000994 RID: 2452
[Token(Token = "0x2000670")]
public class HUDBadStatusIconDisp : MonoBehaviour
{
	// Token: 0x0600402F RID: 16431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003580")]
	[Address(RVA = "0x2041C30", Offset = "0x2041D31", VA = "0x2041C30")]
	private void Redraw(uint flagStat)
	{
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003581")]
	[Address(RVA = "0x2041F80", Offset = "0x2042081", VA = "0x2041F80")]
	public void UpdateBadStatus(CharacterStatusBase statusController)
	{
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003582")]
	[Address(RVA = "0x2042070", Offset = "0x2042171", VA = "0x2042070")]
	public void SetCharacter(CharacterStatusBase statusController)
	{
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003583")]
	[Address(RVA = "0x2042140", Offset = "0x2042241", VA = "0x2042140")]
	public HUDBadStatusIconDisp()
	{
	}

	// Token: 0x04009E89 RID: 40585
	[Token(Token = "0x4007790")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BadStatus[] BadStatusConvertTable;

	// Token: 0x04009E8A RID: 40586
	[Token(Token = "0x4007791")]
	[FieldOffset(Offset = "0x18")]
	private List<BadStatus> badStatuses;

	// Token: 0x04009E8B RID: 40587
	[Token(Token = "0x4007792")]
	[FieldOffset(Offset = "0x20")]
	public Image[] BadStatusIconImage;

	// Token: 0x04009E8C RID: 40588
	[Token(Token = "0x4007793")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite[] BadStatusIconSprites;

	// Token: 0x04009E8D RID: 40589
	[Token(Token = "0x4007794")]
	[FieldOffset(Offset = "0x30")]
	private List<HUDBadStatusIconDisp.BadStatusIconList> badStatusIconLists;

	// Token: 0x04009E8E RID: 40590
	[Token(Token = "0x4007795")]
	[FieldOffset(Offset = "0x38")]
	private List<Image> BadStatusIcons;

	// Token: 0x04009E8F RID: 40591
	[Token(Token = "0x4007796")]
	[FieldOffset(Offset = "0x40")]
	private uint NowFlagStatus;

	// Token: 0x02000995 RID: 2453
	[Token(Token = "0x20012A6")]
	private enum BadStatusIconList
	{
		// Token: 0x04009E91 RID: 40593
		[Token(Token = "0x401B35D")]
		Posion,
		// Token: 0x04009E92 RID: 40594
		[Token(Token = "0x401B35E")]
		Seal,
		// Token: 0x04009E93 RID: 40595
		[Token(Token = "0x401B35F")]
		Paralysis,
		// Token: 0x04009E94 RID: 40596
		[Token(Token = "0x401B360")]
		Sleep,
		// Token: 0x04009E95 RID: 40597
		[Token(Token = "0x401B361")]
		Tier,
		// Token: 0x04009E96 RID: 40598
		[Token(Token = "0x401B362")]
		Sick,
		// Token: 0x04009E97 RID: 40599
		[Token(Token = "0x401B363")]
		Max,
		// Token: 0x04009E98 RID: 40600
		[Token(Token = "0x401B364")]
		None
	}
}
