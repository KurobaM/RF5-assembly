using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A1C RID: 2588
[Token(Token = "0x20006C9")]
public class GenerateSkillDispObject : UIScrollBoxBase
{
	// Token: 0x060043D5 RID: 17365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C1")]
	[Address(RVA = "0x1FA8070", Offset = "0x1FA8171", VA = "0x1FA8070")]
	private void OnEnable()
	{
	}

	// Token: 0x060043D6 RID: 17366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C2")]
	[Address(RVA = "0x1FA81C0", Offset = "0x1FA82C1", VA = "0x1FA81C0")]
	private void GetSkillData()
	{
	}

	// Token: 0x060043D7 RID: 17367 RVA: 0x00016A70 File Offset: 0x00014C70
	[Token(Token = "0x60038C3")]
	[Address(RVA = "0x1FA8320", Offset = "0x1FA8421", VA = "0x1FA8320", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x060043D8 RID: 17368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C4")]
	[Address(RVA = "0x1FA8370", Offset = "0x1FA8471", VA = "0x1FA8370", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x060043D9 RID: 17369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C5")]
	[Address(RVA = "0x1FA8440", Offset = "0x1FA8541", VA = "0x1FA8440", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x060043DA RID: 17370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x1FA8540", Offset = "0x1FA8641", VA = "0x1FA8540")]
	public GenerateSkillDispObject()
	{
	}

	// Token: 0x0400A2B1 RID: 41649
	[Token(Token = "0x4007AF0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject ContentsParent;

	// Token: 0x0400A2B2 RID: 41650
	[Token(Token = "0x4007AF1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject NoSkillObject;

	// Token: 0x0400A2B3 RID: 41651
	[Token(Token = "0x4007AF2")]
	[FieldOffset(Offset = "0x78")]
	private List<PlayerSkillBase> PlayerSkills;

	// Token: 0x0400A2B4 RID: 41652
	[Token(Token = "0x4007AF3")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text SkillDiscriptText;
}
