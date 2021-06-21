using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A28 RID: 2600
[Token(Token = "0x20006D3")]
public class UIBatchSlot : ButtonLinker
{
	// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FA")]
	[Address(RVA = "0x1FFECB0", Offset = "0x1FFEDB1", VA = "0x1FFECB0")]
	private void Start()
	{
	}

	// Token: 0x0600440F RID: 17423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FB")]
	[Address(RVA = "0x1FFED20", Offset = "0x1FFEE21", VA = "0x1FFED20")]
	private void OnEnable()
	{
	}

	// Token: 0x06004410 RID: 17424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FC")]
	[Address(RVA = "0x1FFEE90", Offset = "0x1FFEF91", VA = "0x1FFEE90")]
	public void DispBatch()
	{
	}

	// Token: 0x06004411 RID: 17425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FD")]
	[Address(RVA = "0x1FFEF20", Offset = "0x1FFF021", VA = "0x1FFEF20", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FE")]
	[Address(RVA = "0x1FFF310", Offset = "0x1FFF411", VA = "0x1FFF310", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038FF")]
	[Address(RVA = "0x1FFF3A0", Offset = "0x1FFF4A1", VA = "0x1FFF3A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003900")]
	[Address(RVA = "0x1FFEDC0", Offset = "0x1FFEEC1", VA = "0x1FFEDC0")]
	private void SetLinker()
	{
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003901")]
	[Address(RVA = "0x1FFF410", Offset = "0x1FFF511", VA = "0x1FFF410")]
	public UIBatchSlot()
	{
	}

	// Token: 0x0400A2F9 RID: 41721
	[Token(Token = "0x4007B2E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public PoliceBatchId PoliceBatchId;

	// Token: 0x0400A2FA RID: 41722
	[Token(Token = "0x4007B2F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image BatchImage;

	// Token: 0x0400A2FB RID: 41723
	[Token(Token = "0x4007B30")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text BatchNameText;

	// Token: 0x0400A2FC RID: 41724
	[Token(Token = "0x4007B31")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text BatchDiscriptText;

	// Token: 0x0400A2FD RID: 41725
	[Token(Token = "0x4007B32")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite OnSelectSprite;

	// Token: 0x0400A2FE RID: 41726
	[Token(Token = "0x4007B33")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite NotSelectSprite;

	// Token: 0x0400A2FF RID: 41727
	[Token(Token = "0x4007B34")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UIBatchPageControl UIBatchPageControl;

	// Token: 0x0400A300 RID: 41728
	[Token(Token = "0x4007B35")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject resetLinkerObj;
}
