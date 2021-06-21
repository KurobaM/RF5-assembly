using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009C1 RID: 2497
[Token(Token = "0x200068B")]
public class HUDTime : MonoBehaviour
{
	// Token: 0x06004129 RID: 16681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600365C")]
	[Address(RVA = "0x24E0E90", Offset = "0x24E0F91", VA = "0x24E0E90")]
	private void Awake()
	{
	}

	// Token: 0x0600412A RID: 16682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600365D")]
	[Address(RVA = "0x24E1250", Offset = "0x24E1351", VA = "0x24E1250")]
	private void UpdateTime()
	{
	}

	// Token: 0x0600412B RID: 16683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600365E")]
	[Address(RVA = "0x24E13F0", Offset = "0x24E14F1", VA = "0x24E13F0")]
	private void UpdateSeason()
	{
	}

	// Token: 0x0600412C RID: 16684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600365F")]
	[Address(RVA = "0x24E1520", Offset = "0x24E1621", VA = "0x24E1520")]
	private void UpdateDate()
	{
	}

	// Token: 0x0600412D RID: 16685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003660")]
	[Address(RVA = "0x24E1660", Offset = "0x24E1761", VA = "0x24E1660")]
	private void UpdateWeatherIcon()
	{
	}

	// Token: 0x0600412E RID: 16686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003661")]
	[Address(RVA = "0x24E17A0", Offset = "0x24E18A1", VA = "0x24E17A0")]
	private void Update()
	{
	}

	// Token: 0x0600412F RID: 16687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003662")]
	[Address(RVA = "0x24E17E0", Offset = "0x24E18E1", VA = "0x24E17E0")]
	public HUDTime()
	{
	}

	// Token: 0x04009FEC RID: 40940
	[Token(Token = "0x400789B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x04009FED RID: 40941
	[Token(Token = "0x400789C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite[] BorderSprites;

	// Token: 0x04009FEE RID: 40942
	[Token(Token = "0x400789D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text TimeText;

	// Token: 0x04009FEF RID: 40943
	[Token(Token = "0x400789E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text DateText;

	// Token: 0x04009FF0 RID: 40944
	[Token(Token = "0x400789F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text SeasonText;

	// Token: 0x04009FF1 RID: 40945
	[Token(Token = "0x40078A0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image WeatherImage;

	// Token: 0x04009FF2 RID: 40946
	[Token(Token = "0x40078A1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite[] WeatherSprites;

	// Token: 0x04009FF3 RID: 40947
	[Token(Token = "0x40078A2")]
	[FieldOffset(Offset = "0x50")]
	private int weatherSpriteId;

	// Token: 0x04009FF4 RID: 40948
	[Token(Token = "0x40078A3")]
	[FieldOffset(Offset = "0x58")]
	private string[] SeasonStr;

	// Token: 0x04009FF5 RID: 40949
	[Token(Token = "0x40078A4")]
	[FieldOffset(Offset = "0x60")]
	private string[] DateStr;

	// Token: 0x04009FF6 RID: 40950
	[Token(Token = "0x40078A5")]
	[FieldOffset(Offset = "0x68")]
	private string timeFormatText;

	// Token: 0x04009FF7 RID: 40951
	[Token(Token = "0x40078A6")]
	[FieldOffset(Offset = "0x70")]
	private string dateFormatText;

	// Token: 0x04009FF8 RID: 40952
	[Token(Token = "0x40078A7")]
	[FieldOffset(Offset = "0x78")]
	private int Hour;

	// Token: 0x04009FF9 RID: 40953
	[Token(Token = "0x40078A8")]
	[FieldOffset(Offset = "0x7C")]
	private int Minutes;

	// Token: 0x04009FFA RID: 40954
	[Token(Token = "0x40078A9")]
	[FieldOffset(Offset = "0x80")]
	private Season Season;

	// Token: 0x04009FFB RID: 40955
	[Token(Token = "0x40078AA")]
	[FieldOffset(Offset = "0x84")]
	private int Day;

	// Token: 0x04009FFC RID: 40956
	[Token(Token = "0x40078AB")]
	[FieldOffset(Offset = "0x88")]
	private Define.DayOfWeek DayOfWeek;
}
