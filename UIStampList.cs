using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

// Token: 0x02000A30 RID: 2608
[Token(Token = "0x20006DA")]
public class UIStampList : UIScrollBoxBase
{
	// Token: 0x06004437 RID: 17463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003920")]
	[Address(RVA = "0x211D070", Offset = "0x211D171", VA = "0x211D070")]
	private void OnEnable()
	{
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003921")]
	[Address(RVA = "0x211D790", Offset = "0x211D891", VA = "0x211D790", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003922")]
	[Address(RVA = "0x211EAF0", Offset = "0x211EBF1", VA = "0x211EAF0", Slot = "10")]
	protected override void OnDisable()
	{
	}

	// Token: 0x0600443A RID: 17466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003923")]
	[Address(RVA = "0x211EC20", Offset = "0x211ED21", VA = "0x211EC20")]
	public void OnSlotTouch(UIStampSlot _slot)
	{
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003924")]
	[Address(RVA = "0x211D960", Offset = "0x211DA61", VA = "0x211D960")]
	private void UpdateFocusStampUI()
	{
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003925")]
	[Address(RVA = "0x211ED50", Offset = "0x211EE51", VA = "0x211ED50")]
	public Sprite GetStampSprite(int _index)
	{
		return null;
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003926")]
	[Address(RVA = "0x211D6F0", Offset = "0x211D7F1", VA = "0x211D6F0")]
	private void ResetStampUI()
	{
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003927")]
	[Address(RVA = "0x211D2E0", Offset = "0x211D3E1", VA = "0x211D2E0")]
	private void CheckStampRecord()
	{
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x00016B60 File Offset: 0x00014D60
	[Token(Token = "0x6003928")]
	[Address(RVA = "0x211EF90", Offset = "0x211F091", VA = "0x211EF90", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003929")]
	[Address(RVA = "0x211F010", Offset = "0x211F111", VA = "0x211F010", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x06004441 RID: 17473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392A")]
	[Address(RVA = "0x211F460", Offset = "0x211F561", VA = "0x211F460", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392B")]
	[Address(RVA = "0x211F470", Offset = "0x211F571", VA = "0x211F470")]
	public UIStampList()
	{
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600392C")]
	[Address(RVA = "0x211F480", Offset = "0x211F581", VA = "0x211F480")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7810", Offset = "0x1A7911")]
	private void <OnEnable>b__8_0(AssetHandle<SpriteAtlas> handle)
	{
	}

	// Token: 0x0400A32A RID: 41770
	[Token(Token = "0x4007B5D")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image bigStampIcon;

	// Token: 0x0400A32B RID: 41771
	[Token(Token = "0x4007B5E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text stampProgressText;

	// Token: 0x0400A32C RID: 41772
	[Token(Token = "0x4007B5F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text stampNameText;

	// Token: 0x0400A32D RID: 41773
	[Token(Token = "0x4007B60")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text stampContentText;

	// Token: 0x0400A32E RID: 41774
	[Token(Token = "0x4007B61")]
	[FieldOffset(Offset = "0x88")]
	private SpriteAtlas stampSpriteAtlas;

	// Token: 0x0400A32F RID: 41775
	[Token(Token = "0x4007B62")]
	private const int STAMP_SPRITE_ATLAS_ID = 19764;

	// Token: 0x0400A330 RID: 41776
	[Token(Token = "0x4007B63")]
	[FieldOffset(Offset = "0x90")]
	private StampDataTable stampDataTable;

	// Token: 0x0400A331 RID: 41777
	[Token(Token = "0x4007B64")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<string, Sprite> stampSpriteDict;
}
