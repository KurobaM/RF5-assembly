using System;
using Il2CppDummyDll;

// Token: 0x0200095D RID: 2397
[Token(Token = "0x2000649")]
public class CalendarDataTable
{
	// Token: 0x06003F84 RID: 16260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034D9")]
	[Address(RVA = "0x1E73D90", Offset = "0x1E73E91", VA = "0x1E73D90")]
	public static void GetCalendarDate(CalendarDataTable.FestivalId festivalId, out int season, out int day)
	{
	}

	// Token: 0x06003F85 RID: 16261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034DA")]
	[Address(RVA = "0x1E73F40", Offset = "0x1E74041", VA = "0x1E73F40")]
	public CalendarDataTable()
	{
	}

	// Token: 0x04008105 RID: 33029
	[Token(Token = "0x4007426")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int[,] DataTable;

	// Token: 0x04008106 RID: 33030
	[Token(Token = "0x4007427")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string[] CalendarStrTable;

	// Token: 0x0200095E RID: 2398
	[Token(Token = "0x2001296")]
	public enum FestivalId
	{
		// Token: 0x04008108 RID: 33032
		[Token(Token = "0x4019943")]
		NONE = -1,
		// Token: 0x04008109 RID: 33033
		[Token(Token = "0x4019944")]
		D_FES_ID_NEW_YEAR,
		// Token: 0x0400810A RID: 33034
		[Token(Token = "0x4019945")]
		D_FES_ID_COOKING,
		// Token: 0x0400810B RID: 33035
		[Token(Token = "0x4019946")]
		D_FES_ID_MAMEKAKI,
		// Token: 0x0400810C RID: 33036
		[Token(Token = "0x4019947")]
		D_FES_ID_FISH_COUNT,
		// Token: 0x0400810D RID: 33037
		[Token(Token = "0x4019948")]
		D_FES_ID_FLOWER,
		// Token: 0x0400810E RID: 33038
		[Token(Token = "0x4019949")]
		D_FES_ID_SPRING_CONTEST,
		// Token: 0x0400810F RID: 33039
		[Token(Token = "0x401994A")]
		D_FES_ID_SWIM,
		// Token: 0x04008110 RID: 33040
		[Token(Token = "0x401994B")]
		D_FES_ID_BAFFAMO,
		// Token: 0x04008111 RID: 33041
		[Token(Token = "0x401994C")]
		D_FES_ID_PET,
		// Token: 0x04008112 RID: 33042
		[Token(Token = "0x401994D")]
		D_FES_ID_NIGHTBEACH,
		// Token: 0x04008113 RID: 33043
		[Token(Token = "0x401994E")]
		D_FES_ID_SUMMER_CONTEST,
		// Token: 0x04008114 RID: 33044
		[Token(Token = "0x401994F")]
		D_FES_ID_KAJI,
		// Token: 0x04008115 RID: 33045
		[Token(Token = "0x4019950")]
		D_FES_ID_VALENTINE,
		// Token: 0x04008116 RID: 33046
		[Token(Token = "0x4019951")]
		D_FES_ID_EAT,
		// Token: 0x04008117 RID: 33047
		[Token(Token = "0x4019952")]
		D_FES_ID_HALLOWEEN,
		// Token: 0x04008118 RID: 33048
		[Token(Token = "0x4019953")]
		D_FES_ID_WHITE_DAY,
		// Token: 0x04008119 RID: 33049
		[Token(Token = "0x4019954")]
		D_FES_ID_FALL_CONTEST,
		// Token: 0x0400811A RID: 33050
		[Token(Token = "0x4019955")]
		D_FES_ID_SNOW_ART,
		// Token: 0x0400811B RID: 33051
		[Token(Token = "0x4019956")]
		D_FES_ID_FISH_IKA,
		// Token: 0x0400811C RID: 33052
		[Token(Token = "0x4019957")]
		D_FES_ID_HOLY,
		// Token: 0x0400811D RID: 33053
		[Token(Token = "0x4019958")]
		D_FES_ID_WINTER_CONTEST,
		// Token: 0x0400811E RID: 33054
		[Token(Token = "0x4019959")]
		D_FES_ID_LAST_YEAR,
		// Token: 0x0400811F RID: 33055
		[Token(Token = "0x401995A")]
		Max
	}
}
