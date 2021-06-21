using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200050B RID: 1291
[Token(Token = "0x20003AE")]
public class FestivalNumScore : MonoBehaviour
{
	// Token: 0x06001F70 RID: 8048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x1F80B90", Offset = "0x1F80C91", VA = "0x1F80B90")]
	public void SetScore(int _score)
	{
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x1F80CA0", Offset = "0x1F80DA1", VA = "0x1F80CA0")]
	public void SetScoreObtain(int _score)
	{
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x1F80DD0", Offset = "0x1F80ED1", VA = "0x1F80DD0")]
	public void SetTime(float _time)
	{
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x1F81090", Offset = "0x1F81191", VA = "0x1F81090")]
	public FestivalNumScore()
	{
	}

	// Token: 0x04006660 RID: 26208
	[Token(Token = "0x40060B1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Sprite[] sp;

	// Token: 0x04006661 RID: 26209
	[Token(Token = "0x40060B2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image[] Num;

	// Token: 0x04006662 RID: 26210
	[Token(Token = "0x40060B3")]
	private const int SCORE_MAX = 999999;
}
