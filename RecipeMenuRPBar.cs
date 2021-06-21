using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A41 RID: 2625
[Token(Token = "0x20006E6")]
public class RecipeMenuRPBar : CursorEvent
{
	// Token: 0x060044A7 RID: 17575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003984")]
	[Address(RVA = "0x1F3F8C0", Offset = "0x1F3F9C1", VA = "0x1F3F8C0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003985")]
	[Address(RVA = "0x1F3FA60", Offset = "0x1F3FB61", VA = "0x1F3FA60", Slot = "7")]
	public override void OnFocusIn(CursorLinker focusObject)
	{
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003986")]
	[Address(RVA = "0x1F3F8F0", Offset = "0x1F3F9F1", VA = "0x1F3F8F0")]
	private void UpdateSkillParameter()
	{
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003987")]
	[Address(RVA = "0x1F3FBD0", Offset = "0x1F3FCD1", VA = "0x1F3FBD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003988")]
	[Address(RVA = "0x1F3FE60", Offset = "0x1F3FF61", VA = "0x1F3FE60")]
	public RecipeMenuRPBar()
	{
	}

	// Token: 0x0400A37C RID: 41852
	[Token(Token = "0x4007BA2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image HPGauge;

	// Token: 0x0400A37D RID: 41853
	[Token(Token = "0x4007BA3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text HPText;

	// Token: 0x0400A37E RID: 41854
	[Token(Token = "0x4007BA4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image RPGauge;

	// Token: 0x0400A37F RID: 41855
	[Token(Token = "0x4007BA5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text RPText;

	// Token: 0x0400A380 RID: 41856
	[Token(Token = "0x4007BA6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text SkillName;

	// Token: 0x0400A381 RID: 41857
	[Token(Token = "0x4007BA7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text SkillLv;

	// Token: 0x0400A382 RID: 41858
	[Token(Token = "0x4007BA8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text SkillPercent;

	// Token: 0x0400A383 RID: 41859
	[Token(Token = "0x4007BA9")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image SkillGauge;

	// Token: 0x0400A384 RID: 41860
	[Token(Token = "0x4007BAA")]
	[FieldOffset(Offset = "0x58")]
	private SkillID setSkillID;

	// Token: 0x0400A385 RID: 41861
	[Token(Token = "0x4007BAB")]
	[FieldOffset(Offset = "0x5C")]
	private SkillID dispSkillID;
}
