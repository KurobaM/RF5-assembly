using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD4 RID: 2772
[Token(Token = "0x2000742")]
public class UIStrengtheningTopMenu : MonoBehaviour
{
	// Token: 0x17000991 RID: 2449
	// (get) Token: 0x060047FF RID: 18431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007AB")]
	public SText MenuText
	{
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x2121D40", Offset = "0x2121E41", VA = "0x2121D40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C48")]
	[Address(RVA = "0x2120BA0", Offset = "0x2120CA1", VA = "0x2120BA0")]
	public void UpdateTopMenu(SkillID _skill_id)
	{
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C49")]
	[Address(RVA = "0x2121D50", Offset = "0x2121E51", VA = "0x2121D50")]
	public UIStrengtheningTopMenu()
	{
	}

	// Token: 0x0400A758 RID: 42840
	[Token(Token = "0x4007E75")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SText menuText;

	// Token: 0x0400A759 RID: 42841
	[Token(Token = "0x4007E76")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text hpText;

	// Token: 0x0400A75A RID: 42842
	[Token(Token = "0x4007E77")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image hpGauge;

	// Token: 0x0400A75B RID: 42843
	[Token(Token = "0x4007E78")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text rpText;

	// Token: 0x0400A75C RID: 42844
	[Token(Token = "0x4007E79")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image rpGauge;

	// Token: 0x0400A75D RID: 42845
	[Token(Token = "0x4007E7A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SText skillNameText;

	// Token: 0x0400A75E RID: 42846
	[Token(Token = "0x4007E7B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text skillLevelText;

	// Token: 0x0400A75F RID: 42847
	[Token(Token = "0x4007E7C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image skillGauge;

	// Token: 0x0400A760 RID: 42848
	[Token(Token = "0x4007E7D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Text skillExpText;
}
