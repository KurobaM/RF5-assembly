using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A46 RID: 2630
[Token(Token = "0x20006EA")]
public class SkillDispBlock : UIButtonLinkerInScrollBox
{
	// Token: 0x060044B5 RID: 17589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003992")]
	[Address(RVA = "0x1DE7A60", Offset = "0x1DE7B61", VA = "0x1DE7A60", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x060044B6 RID: 17590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003993")]
	[Address(RVA = "0x1DE7A70", Offset = "0x1DE7B71", VA = "0x1DE7A70", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060044B7 RID: 17591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003994")]
	[Address(RVA = "0x1DE7B30", Offset = "0x1DE7C31", VA = "0x1DE7B30", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x060044B8 RID: 17592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003995")]
	[Address(RVA = "0x1DE7BF0", Offset = "0x1DE7CF1", VA = "0x1DE7BF0")]
	public void Disp(PlayerSkillBase _skill)
	{
	}

	// Token: 0x060044B9 RID: 17593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003996")]
	[Address(RVA = "0x1DE7E00", Offset = "0x1DE7F01", VA = "0x1DE7E00")]
	public SkillDispBlock()
	{
	}

	// Token: 0x0400A391 RID: 41873
	[Token(Token = "0x4007BB5")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image NoSelectBorder;

	// Token: 0x0400A392 RID: 41874
	[Token(Token = "0x4007BB6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image SelectedBorder;

	// Token: 0x0400A393 RID: 41875
	[Token(Token = "0x4007BB7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text SkillNameText;

	// Token: 0x0400A394 RID: 41876
	[Token(Token = "0x4007BB8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text SkillLvText;

	// Token: 0x0400A395 RID: 41877
	[Token(Token = "0x4007BB9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image SkillGauge;

	// Token: 0x0400A396 RID: 41878
	[Token(Token = "0x4007BBA")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text SkillExpPercent;
}
