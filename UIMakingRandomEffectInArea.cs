using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A5E RID: 2654
[Token(Token = "0x20006F9")]
public class UIMakingRandomEffectInArea : MonoBehaviour
{
	// Token: 0x06004556 RID: 17750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A0C")]
	[Address(RVA = "0x2024180", Offset = "0x2024281", VA = "0x2024180")]
	private void Start()
	{
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x00017010 File Offset: 0x00015210
	[Token(Token = "0x6003A0D")]
	[Address(RVA = "0x2024250", Offset = "0x2024351", VA = "0x2024250")]
	private float ReDalayEffectTime()
	{
		return 0f;
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A0E")]
	[Address(RVA = "0x2024260", Offset = "0x2024361", VA = "0x2024260")]
	private void Update()
	{
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A0F")]
	[Address(RVA = "0x2024530", Offset = "0x2024631", VA = "0x2024530")]
	public UIMakingRandomEffectInArea()
	{
	}

	// Token: 0x0400A42B RID: 42027
	[Token(Token = "0x4007C20")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform[] PrefEffectSpawnArea;

	// Token: 0x0400A42C RID: 42028
	[Token(Token = "0x4007C21")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float Duration;

	// Token: 0x0400A42D RID: 42029
	[Token(Token = "0x4007C22")]
	[FieldOffset(Offset = "0x24")]
	private float time;

	// Token: 0x0400A42E RID: 42030
	[Token(Token = "0x4007C23")]
	[FieldOffset(Offset = "0x28")]
	private List<float> EffectSpawnDelayTimes;

	// Token: 0x0400A42F RID: 42031
	[Token(Token = "0x4007C24")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UIShopMoneyEffect UIShopMoneyEffect;

	// Token: 0x0400A430 RID: 42032
	[Token(Token = "0x4007C25")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float SpawnDelayTimeRandMin;

	// Token: 0x0400A431 RID: 42033
	[Token(Token = "0x4007C26")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float SpawnDelayTimeRandMax;
}
