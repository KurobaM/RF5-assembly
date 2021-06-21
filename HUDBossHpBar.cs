using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000996 RID: 2454
[Token(Token = "0x2000671")]
public class HUDBossHpBar : MonoBehaviour
{
	// Token: 0x06004034 RID: 16436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003585")]
	[Address(RVA = "0x2042230", Offset = "0x2042331", VA = "0x2042230")]
	private void Awake()
	{
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003586")]
	[Address(RVA = "0x20422D0", Offset = "0x20423D1", VA = "0x20422D0")]
	private void SetActive()
	{
	}

	// Token: 0x06004036 RID: 16438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003587")]
	[Address(RVA = "0x2042400", Offset = "0x2042501", VA = "0x2042400")]
	public void SetHpBar(float hp, float hpMax, CharacterStatusBase status)
	{
	}

	// Token: 0x06004037 RID: 16439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003588")]
	[Address(RVA = "0x2042580", Offset = "0x2042681", VA = "0x2042580")]
	public void OnHPBar()
	{
	}

	// Token: 0x06004038 RID: 16440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003589")]
	[Address(RVA = "0x2042590", Offset = "0x2042691", VA = "0x2042590")]
	public void OffHpBar()
	{
	}

	// Token: 0x06004039 RID: 16441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358A")]
	[Address(RVA = "0x20425A0", Offset = "0x20426A1", VA = "0x20425A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600403A RID: 16442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600358B")]
	[Address(RVA = "0x20426D0", Offset = "0x20427D1", VA = "0x20426D0")]
	public HUDBossHpBar()
	{
	}

	// Token: 0x04009E99 RID: 40601
	[Token(Token = "0x4007797")]
	[FieldOffset(Offset = "0x0")]
	public static HUDBossHpBar Instance;

	// Token: 0x04009E9A RID: 40602
	[Token(Token = "0x4007798")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject GaugeAllObject;

	// Token: 0x04009E9B RID: 40603
	[Token(Token = "0x4007799")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HUDBossHpDispGauge[] HpGauges;

	// Token: 0x04009E9C RID: 40604
	[Token(Token = "0x400779A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HUDBadStatusIconDisp HUDBadStatusIconDisp;

	// Token: 0x04009E9D RID: 40605
	[Token(Token = "0x400779B")]
	[FieldOffset(Offset = "0x30")]
	private bool realAppearStat;

	// Token: 0x04009E9E RID: 40606
	[Token(Token = "0x400779C")]
	[FieldOffset(Offset = "0x31")]
	private bool nowAllHideStat;
}
