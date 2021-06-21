using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using SaveData;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000327 RID: 807
[Token(Token = "0x2000261")]
[Serializable]
public class TimeManager : SingletonMonoBehaviour<TimeManager>
{
	// Token: 0x06001576 RID: 5494 RVA: 0x000095A0 File Offset: 0x000077A0
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x2060F20", Offset = "0x2061021", VA = "0x2060F20")]
	public static int CalcDateDay(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x000095B8 File Offset: 0x000077B8
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x2060F70", Offset = "0x2061071", VA = "0x2060F70")]
	public static int CalcDateHour(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x000095D0 File Offset: 0x000077D0
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x2060FB0", Offset = "0x20610B1", VA = "0x2060FB0")]
	public static int CalcDateMinutes(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x000095E8 File Offset: 0x000077E8
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x2060FE0", Offset = "0x20610E1", VA = "0x2060FE0")]
	public static int CalcDateYear(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00009600 File Offset: 0x00007800
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x2061010", Offset = "0x2061111", VA = "0x2061010")]
	public static Season CalcDateSeason(int elapsedTime)
	{
		return Season.None;
	}

	// Token: 0x0600157B RID: 5499 RVA: 0x00009618 File Offset: 0x00007818
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x2061050", Offset = "0x2061151", VA = "0x2061050")]
	public static int CalcDateWeek(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x0600157C RID: 5500 RVA: 0x00009630 File Offset: 0x00007830
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x20610A0", Offset = "0x20611A1", VA = "0x20610A0")]
	public static Define.DayOfWeek CalcDateDayOfWeek(int elapsedTime)
	{
		return Define.DayOfWeek.HOLIDAY;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00009648 File Offset: 0x00007848
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x2061160", Offset = "0x2061261", VA = "0x2061160")]
	public static int CalcDateTime(int year, Season season, int day, int hour, int min)
	{
		return 0;
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00009660 File Offset: 0x00007860
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x2061240", Offset = "0x2061341", VA = "0x2061240")]
	public static int CalcDateTime(int year, int season, int day, int hour, int min)
	{
		return 0;
	}

	// Token: 0x0600157F RID: 5503 RVA: 0x00009678 File Offset: 0x00007878
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x20612B0", Offset = "0x20613B1", VA = "0x20612B0")]
	public static int CalcTimeSpan(int year, int season, int day, int hour, int min)
	{
		return 0;
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00009690 File Offset: 0x00007890
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x20612E0", Offset = "0x20613E1", VA = "0x20612E0")]
	public static int CalcElapsedDay(int elapsedTime)
	{
		return 0;
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06001581 RID: 5505 RVA: 0x000096A8 File Offset: 0x000078A8
	[Token(Token = "0x17000381")]
	public Weather SceneShowWeather
	{
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x2061310", Offset = "0x2061411", VA = "0x2061310")]
		get
		{
			return Weather.None;
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06001582 RID: 5506 RVA: 0x000096C0 File Offset: 0x000078C0
	[Token(Token = "0x17000382")]
	public Weather ShowWeather
	{
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x2061400", Offset = "0x2061501", VA = "0x2061400")]
		get
		{
			return Weather.None;
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06001583 RID: 5507 RVA: 0x000096D8 File Offset: 0x000078D8
	[Token(Token = "0x17000383")]
	public Weather Weather
	{
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x20615F0", Offset = "0x20616F1", VA = "0x20615F0")]
		get
		{
			return Weather.None;
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001585 RID: 5509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000384")]
	public Weather[] ForceWeatherHour
	{
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x20616E0", Offset = "0x20617E1", VA = "0x20616E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x20616F0", Offset = "0x20617F1", VA = "0x20616F0")]
		private set
		{
		}
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x2061700", Offset = "0x2061801", VA = "0x2061700")]
	public void SetScenarioStoppedTime(int toYear, int toSeason, int toDay, int toHour, int toMinutes)
	{
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001343")]
	[Address(RVA = "0x2061810", Offset = "0x2061911", VA = "0x2061810")]
	public void SetScenarioStoppedTimeNow()
	{
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x000096F0 File Offset: 0x000078F0
	[Token(Token = "0x6001344")]
	[Address(RVA = "0x2061880", Offset = "0x2061981", VA = "0x2061880")]
	public int GetSenarioStoppedTime()
	{
		return 0;
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001345")]
	[Address(RVA = "0x20618B0", Offset = "0x20619B1", VA = "0x20618B0")]
	public static string TimeToString(int time)
	{
		return null;
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001346")]
	[Address(RVA = "0x2061C40", Offset = "0x2061D41", VA = "0x2061C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x0600158B RID: 5515 RVA: 0x00009708 File Offset: 0x00007908
	// (set) Token: 0x0600158C RID: 5516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000385")]
	public int ElapsedTime
	{
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x2061850", Offset = "0x2061951", VA = "0x2061850")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x20635D0", Offset = "0x20636D1", VA = "0x20635D0")]
		set
		{
		}
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x00009720 File Offset: 0x00007920
	[Token(Token = "0x6001349")]
	[Address(RVA = "0x2063600", Offset = "0x2063701", VA = "0x2063600")]
	public TimeManager.RFDateTime CurrentDate()
	{
		return default(TimeManager.RFDateTime);
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x0600158E RID: 5518 RVA: 0x00009738 File Offset: 0x00007938
	[Token(Token = "0x17000386")]
	public int Year
	{
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x2062230", Offset = "0x2062331", VA = "0x2062230")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x0600158F RID: 5519 RVA: 0x00009750 File Offset: 0x00007950
	[Token(Token = "0x17000387")]
	public Season Season
	{
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x20622C0", Offset = "0x20623C1", VA = "0x20622C0")]
		get
		{
			return Season.None;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06001590 RID: 5520 RVA: 0x00009768 File Offset: 0x00007968
	[Token(Token = "0x17000388")]
	public int Week
	{
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x2062370", Offset = "0x2062471", VA = "0x2062370")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06001591 RID: 5521 RVA: 0x00009780 File Offset: 0x00007980
	[Token(Token = "0x17000389")]
	public Define.DayOfWeek DayOfWeek
	{
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x2063630", Offset = "0x2063731", VA = "0x2063630")]
		get
		{
			return Define.DayOfWeek.HOLIDAY;
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06001592 RID: 5522 RVA: 0x00009798 File Offset: 0x00007998
	[Token(Token = "0x1700038A")]
	public Define.DayOfWeek SalesDay
	{
		[Token(Token = "0x600134E")]
		[Address(RVA = "0x2063760", Offset = "0x2063861", VA = "0x2063760")]
		get
		{
			return Define.DayOfWeek.HOLIDAY;
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06001593 RID: 5523 RVA: 0x000097B0 File Offset: 0x000079B0
	[Token(Token = "0x1700038B")]
	public int ElapsedDay
	{
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x2063770", Offset = "0x2063871", VA = "0x2063770")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06001594 RID: 5524 RVA: 0x000097C8 File Offset: 0x000079C8
	[Token(Token = "0x1700038C")]
	public int ElapsedMinutesMorning
	{
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x2063800", Offset = "0x2063901", VA = "0x2063800")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06001595 RID: 5525 RVA: 0x000097E0 File Offset: 0x000079E0
	[Token(Token = "0x1700038D")]
	public int Day
	{
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x2062420", Offset = "0x2062521", VA = "0x2062420")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x06001596 RID: 5526 RVA: 0x000097F8 File Offset: 0x000079F8
	[Token(Token = "0x1700038E")]
	public int Hour
	{
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x20624E0", Offset = "0x20625E1", VA = "0x20624E0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x06001597 RID: 5527 RVA: 0x00009810 File Offset: 0x00007A10
	[Token(Token = "0x1700038F")]
	public int Minutes
	{
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x2062590", Offset = "0x2062691", VA = "0x2062590")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x06001598 RID: 5528 RVA: 0x00009828 File Offset: 0x00007A28
	[Token(Token = "0x17000390")]
	public int AMPMHour
	{
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x20638F0", Offset = "0x20639F1", VA = "0x20638F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000391")]
	public string AMPMText
	{
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x2063A40", Offset = "0x2063B41", VA = "0x2063A40")]
		get
		{
			return null;
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x0600159A RID: 5530 RVA: 0x00009840 File Offset: 0x00007A40
	[Token(Token = "0x17000392")]
	public float DailyRatio
	{
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x2063C80", Offset = "0x2063D81", VA = "0x2063C80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x00009858 File Offset: 0x00007A58
	[Token(Token = "0x6001357")]
	[Address(RVA = "0x2063D30", Offset = "0x2063E31", VA = "0x2063D30")]
	public TimeManager.DaysInfo GetAnotherDayInfo(int AddDayCount)
	{
		return default(TimeManager.DaysInfo);
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x0600159C RID: 5532 RVA: 0x00009870 File Offset: 0x00007A70
	[Token(Token = "0x17000393")]
	public Define.TimeZone TimeZone
	{
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x2062630", Offset = "0x2062731", VA = "0x2062630")]
		get
		{
			return Define.TimeZone.None;
		}
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x0600159D RID: 5533 RVA: 0x00009888 File Offset: 0x00007A88
	[Token(Token = "0x17000394")]
	public TimeManager.RFTimeInt CurrentTimeInt
	{
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x2063E30", Offset = "0x2063F31", VA = "0x2063E30")]
		get
		{
			return default(TimeManager.RFTimeInt);
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135A")]
	[Address(RVA = "0x2064100", Offset = "0x2064201", VA = "0x2064100", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135B")]
	[Address(RVA = "0x20641B0", Offset = "0x20642B1", VA = "0x20641B0")]
	public void Start()
	{
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135C")]
	[Address(RVA = "0x20641E0", Offset = "0x20642E1", VA = "0x20641E0")]
	public void Update()
	{
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600135D")]
	[Address(RVA = "0x20648A0", Offset = "0x20649A1", VA = "0x20648A0")]
	public TimeManager.JustTimerData SetJustTimer(int time, Action<TimeManager.JustTimerData> action, UnityEngine.Object callObject)
	{
		return null;
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x000098A0 File Offset: 0x00007AA0
	[Token(Token = "0x600135E")]
	[Address(RVA = "0x2064A50", Offset = "0x2064B51", VA = "0x2064A50")]
	public bool CancelTimer(TimeManager.JustTimerData timerData)
	{
		return default(bool);
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600135F")]
	[Address(RVA = "0x2064B10", Offset = "0x2064C11", VA = "0x2064B10")]
	private void CheckWithExecuteJustTimer(int time)
	{
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x2064D00", Offset = "0x2064E01", VA = "0x2064D00")]
	public void ChangeTime(int toYear, int toSeason, int toDay, int toHour, int toMinutes, bool notChangePreviousTime)
	{
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x2065080", Offset = "0x2065181", VA = "0x2065080")]
	public void ChangeTimeNextDay(int toHour, int toMinutes)
	{
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x2065200", Offset = "0x2065301", VA = "0x2065200")]
	public void ChangeTimePrevDay(int toHour, int toMinutes)
	{
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x20642C0", Offset = "0x20643C1", VA = "0x20642C0")]
	public void AdvanceTime(int addTime)
	{
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x20657B0", Offset = "0x20658B1", VA = "0x20657B0")]
	public void ToNextMorning()
	{
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x000098B8 File Offset: 0x00007AB8
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x2065A70", Offset = "0x2065B71", VA = "0x2065A70")]
	private int RandomIndex(int[] pRand, int num)
	{
		return 0;
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x000098D0 File Offset: 0x00007AD0
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x2065B70", Offset = "0x2065C71", VA = "0x2065B70")]
	public bool IsForceSunnyDay(int CheckTime = -1)
	{
		return default(bool);
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x2065CC0", Offset = "0x2065DC1", VA = "0x2065CC0")]
	public void UpdateWeatherDay()
	{
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x2066590", Offset = "0x2066691", VA = "0x2066590")]
	private void CheckWeatherDayType(TimeManager.LotteryWeatherType lotteryWeatherType, out WeatherDay weatherDay)
	{
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x20660F0", Offset = "0x20661F1", VA = "0x20660F0")]
	public void LotteryWeatherHour(WeatherDay weatherDay, ref Weather[] weatherHour, bool setPrevWeather = true, bool setPrevDay = false)
	{
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136A")]
	[Address(RVA = "0x20665C0", Offset = "0x20666C1", VA = "0x20665C0")]
	public void LotteryForceWeatherHour(WeatherDay weatherDay)
	{
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x000098E8 File Offset: 0x00007AE8
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x20665D0", Offset = "0x20666D1", VA = "0x20665D0")]
	public int GetTyphoonCount()
	{
		return 0;
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136C")]
	[Address(RVA = "0x20665E0", Offset = "0x20666E1", VA = "0x20665E0")]
	public void SetTyphoonCount(int setDayCount)
	{
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136D")]
	[Address(RVA = "0x2066680", Offset = "0x2066781", VA = "0x2066680")]
	public void AddTyphoonCount(int addDayCount)
	{
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x00009900 File Offset: 0x00007B00
	[Token(Token = "0x600136E")]
	[Address(RVA = "0x2066720", Offset = "0x2066821", VA = "0x2066720")]
	public bool CanAddTyphoonCount(int addDayCount)
	{
		return default(bool);
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x00009918 File Offset: 0x00007B18
	[Token(Token = "0x600136F")]
	[Address(RVA = "0x2066760", Offset = "0x2066861", VA = "0x2066760")]
	public int GetRoonyDayCount()
	{
		return 0;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x00009930 File Offset: 0x00007B30
	[Token(Token = "0x6001370")]
	[Address(RVA = "0x2066770", Offset = "0x2066871", VA = "0x2066770")]
	public int GetMeteorShowerDayCount()
	{
		return 0;
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x2066780", Offset = "0x2066881", VA = "0x2066780")]
	public void ChangeFieldBGMByTime(int elapsedHour)
	{
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00009948 File Offset: 0x00007B48
	[Token(Token = "0x6001372")]
	[Address(RVA = "0x20668B0", Offset = "0x20669B1", VA = "0x20668B0")]
	public BGMID GetFiledBGMId()
	{
		return BGMID.BGM_EMPTY;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x20667F0", Offset = "0x20668F1", VA = "0x20667F0")]
	public void PlayFieldBGM()
	{
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00009960 File Offset: 0x00007B60
	[Token(Token = "0x6001374")]
	[Address(RVA = "0x2066A10", Offset = "0x2066B11", VA = "0x2066A10")]
	private BGMID GetMakingBgmId()
	{
		return BGMID.BGM_EMPTY;
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001375")]
	[Address(RVA = "0x2066C00", Offset = "0x2066D01", VA = "0x2066C00")]
	public void BeforeSaveData(RF5WorldData saveData)
	{
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001376")]
	[Address(RVA = "0x2066D50", Offset = "0x2066E51", VA = "0x2066D50")]
	public void AfterLoadData(RF5WorldData saveData)
	{
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00009978 File Offset: 0x00007B78
	[Token(Token = "0x6001377")]
	[Address(RVA = "0x2066E20", Offset = "0x2066F21", VA = "0x2066E20")]
	public bool IsFestival(Define.Event eventId)
	{
		return default(bool);
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00009990 File Offset: 0x00007B90
	[Token(Token = "0x6001378")]
	[Address(RVA = "0x2067200", Offset = "0x2067301", VA = "0x2067200")]
	public int GetFestivalId(int ChkSeason, int ChkDay)
	{
		return 0;
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x000099A8 File Offset: 0x00007BA8
	[Token(Token = "0x6001379")]
	[Address(RVA = "0x20674E0", Offset = "0x20675E1", VA = "0x20674E0")]
	public Define.Event GetFestivalEventId()
	{
		return Define.Event.NONE;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x000099C0 File Offset: 0x00007BC0
	[Token(Token = "0x600137A")]
	[Address(RVA = "0x2067630", Offset = "0x2067731", VA = "0x2067630")]
	public Define.Event GetNextDayFestivalEventId()
	{
		return Define.Event.NONE;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x000099D8 File Offset: 0x00007BD8
	[Token(Token = "0x600137B")]
	[Address(RVA = "0x2067780", Offset = "0x2067881", VA = "0x2067780")]
	public Define.Event GetInsideFestivalEventId()
	{
		return Define.Event.NONE;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x000099F0 File Offset: 0x00007BF0
	[Token(Token = "0x600137C")]
	[Address(RVA = "0x2065CA0", Offset = "0x2065DA1", VA = "0x2065CA0")]
	public Define.Event GetFestivalEventId(int ChkSeason, int ChkDay)
	{
		return Define.Event.NONE;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00009A08 File Offset: 0x00007C08
	[Token(Token = "0x600137D")]
	[Address(RVA = "0x20678E0", Offset = "0x20679E1", VA = "0x20678E0")]
	public bool IsNewYear()
	{
		return default(bool);
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00009A20 File Offset: 0x00007C20
	[Token(Token = "0x600137E")]
	[Address(RVA = "0x2067A20", Offset = "0x2067B21", VA = "0x2067A20")]
	public bool IsFirstDay()
	{
		return default(bool);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00009A38 File Offset: 0x00007C38
	[Token(Token = "0x600137F")]
	[Address(RVA = "0x2065380", Offset = "0x2065481", VA = "0x2065380")]
	public int GetInsideHour(int time = -1)
	{
		return 0;
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x00009A50 File Offset: 0x00007C50
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x2065440", Offset = "0x2065541", VA = "0x2065440")]
	public int GetInsideDay(int time = -1)
	{
		return 0;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00009A68 File Offset: 0x00007C68
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x2065510", Offset = "0x2065611", VA = "0x2065510")]
	public Season GetInsideSeason(int time = -1)
	{
		return Season.None;
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x00009A80 File Offset: 0x00007C80
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x20655D0", Offset = "0x20656D1", VA = "0x20655D0")]
	public int GetInsideYear(int time = -1)
	{
		return 0;
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x00009A98 File Offset: 0x00007C98
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x2061510", Offset = "0x2061611", VA = "0x2061510")]
	public int GetWeatherHourIndex(int time = -1)
	{
		return 0;
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x2067AD0", Offset = "0x2067BD1", VA = "0x2067AD0")]
	public Weather GetWeatherHour(int time = -1)
	{
		return Weather.None;
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x2067BE0", Offset = "0x2067CE1", VA = "0x2067BE0")]
	public TimeManager()
	{
	}

	// Token: 0x04000C6B RID: 3179
	[Token(Token = "0x400097F")]
	public const int OneHour = 60;

	// Token: 0x04000C6C RID: 3180
	[Token(Token = "0x4000980")]
	public const int OneDay = 1440;

	// Token: 0x04000C6D RID: 3181
	[Token(Token = "0x4000981")]
	public const int OneWeek = 8640;

	// Token: 0x04000C6E RID: 3182
	[Token(Token = "0x4000982")]
	public const int OneSeason = 43200;

	// Token: 0x04000C6F RID: 3183
	[Token(Token = "0x4000983")]
	public const int OneYear = 172800;

	// Token: 0x04000C70 RID: 3184
	[Token(Token = "0x4000984")]
	public const int MaxMinute = 60;

	// Token: 0x04000C71 RID: 3185
	[Token(Token = "0x4000985")]
	public const int MaxHour = 24;

	// Token: 0x04000C72 RID: 3186
	[Token(Token = "0x4000986")]
	public const int MaxDay = 30;

	// Token: 0x04000C73 RID: 3187
	[Token(Token = "0x4000987")]
	public const int MaxWeek = 5;

	// Token: 0x04000C74 RID: 3188
	[Token(Token = "0x4000988")]
	public const int MaxSeason = 4;

	// Token: 0x04000C75 RID: 3189
	[Token(Token = "0x4000989")]
	public const int MaxYear = 9999;

	// Token: 0x04000C76 RID: 3190
	[Token(Token = "0x400098A")]
	public const int DayBorderHour = 6;

	// Token: 0x04000C77 RID: 3191
	[Token(Token = "0x400098B")]
	public const int WeatherChangeHourInterval = 3;

	// Token: 0x04000C78 RID: 3192
	[Token(Token = "0x400098C")]
	private const int ForceSunnyTime = 6119;

	// Token: 0x04000C79 RID: 3193
	[Token(Token = "0x400098D")]
	private const int WeatherJointMinute = 30;

	// Token: 0x04000C7A RID: 3194
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Weather[] WeatherHour;

	// Token: 0x04000C7B RID: 3195
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x20")]
	private Weather[] _ForceWeatherHour;

	// Token: 0x04000C7C RID: 3196
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public WeatherDay WeatherDay;

	// Token: 0x04000C7D RID: 3197
	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x2C")]
	public WeatherDay NextWeatherDay;

	// Token: 0x04000C7E RID: 3198
	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x30")]
	public WeatherDay ForceWeatherDay;

	// Token: 0x04000C7F RID: 3199
	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x34")]
	public int TyphoonDayCount;

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x38")]
	private int RoonyDayCount;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x3C")]
	private int MeteorShowerDayCount;

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x40")]
	private int TodayRate;

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x44")]
	private float innerElapsedSecounds;

	// Token: 0x04000C84 RID: 3204
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x48")]
	private Define.TimeZone prevTimeZone;

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x50")]
	public OnCarryTimeEvent OnSecondsCarry;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x58")]
	public OnCarryTimeEvent OnHourCarry;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x60")]
	public OnCarryTimeEvent OnDayCarry;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x68")]
	public OnCarryTimeEvent OnSeasonCarry;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x70")]
	public UnityEvent OnSleep;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, List<TimeManager.JustTimerData>> JustTimerDictionary;

	// Token: 0x04000C8B RID: 3211
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[][] _WetherBaseRate;

	// Token: 0x02000328 RID: 808
	[Token(Token = "0x200104F")]
	public struct RFDateTime
	{
		// Token: 0x060015CB RID: 5579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2F")]
		[Address(RVA = "0x2DFAB0", Offset = "0x2DFBB1", VA = "0x2DFAB0")]
		public RFDateTime(int value)
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D30")]
		[Address(RVA = "0x2DFAC0", Offset = "0x2DFBC1", VA = "0x2DFAC0")]
		public RFDateTime(int year = 1, Season season = Season.Spring, int day = 1, int hour = 0, int min = 0)
		{
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00009AC8 File Offset: 0x00007CC8
		// (set) Token: 0x060015CE RID: 5582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0D")]
		public int Year
		{
			[Token(Token = "0x6006D31")]
			[Address(RVA = "0x2DFAD0", Offset = "0x2DFBD1", VA = "0x2DFAD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D32")]
			[Address(RVA = "0x2DFB60", Offset = "0x2DFC61", VA = "0x2DFB60")]
			set
			{
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00009AE0 File Offset: 0x00007CE0
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0E")]
		public Season Season
		{
			[Token(Token = "0x6006D33")]
			[Address(RVA = "0x2DFB70", Offset = "0x2DFC71", VA = "0x2DFB70")]
			get
			{
				return Season.None;
			}
			[Token(Token = "0x6006D34")]
			[Address(RVA = "0x2DFC10", Offset = "0x2DFD11", VA = "0x2DFC10")]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00009AF8 File Offset: 0x00007CF8
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0F")]
		public int Day
		{
			[Token(Token = "0x6006D35")]
			[Address(RVA = "0x2DFC20", Offset = "0x2DFD21", VA = "0x2DFC20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D36")]
			[Address(RVA = "0x2DFCD0", Offset = "0x2DFDD1", VA = "0x2DFCD0")]
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C10")]
		public int Hour
		{
			[Token(Token = "0x6006D37")]
			[Address(RVA = "0x2DFCE0", Offset = "0x2DFDE1", VA = "0x2DFCE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D38")]
			[Address(RVA = "0x2DFD80", Offset = "0x2DFE81", VA = "0x2DFD80")]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00009B28 File Offset: 0x00007D28
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C11")]
		public int Minute
		{
			[Token(Token = "0x6006D39")]
			[Address(RVA = "0x2DFD90", Offset = "0x2DFE91", VA = "0x2DFD90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D3A")]
			[Address(RVA = "0x2DFE20", Offset = "0x2DFF21", VA = "0x2DFE20")]
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x17000C12")]
		public int ElapsedDay
		{
			[Token(Token = "0x6006D3B")]
			[Address(RVA = "0x2DFE30", Offset = "0x2DFF31", VA = "0x2DFE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x6006D3C")]
		[Address(RVA = "0x2069560", Offset = "0x2069661", VA = "0x2069560")]
		public static TimeManager.RFTimeSpan operator -(TimeManager.RFDateTime a, TimeManager.RFDateTime b)
		{
			return default(TimeManager.RFTimeSpan);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x6006D3D")]
		[Address(RVA = "0x2069570", Offset = "0x2069671", VA = "0x2069570")]
		public static TimeManager.RFDateTime operator -(TimeManager.RFDateTime a, TimeManager.RFTimeSpan b)
		{
			return default(TimeManager.RFDateTime);
		}

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4018F5F")]
		[FieldOffset(Offset = "0x0")]
		public int LowTime;
	}

	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2001050")]
	public struct RFTimeSpan
	{
		// Token: 0x060015DA RID: 5594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3E")]
		[Address(RVA = "0x2E02E0", Offset = "0x2E03E1", VA = "0x2E02E0")]
		public RFTimeSpan(int span)
		{
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D3F")]
		[Address(RVA = "0x2E02F0", Offset = "0x2E03F1", VA = "0x2E02F0")]
		public RFTimeSpan(int year = 0, int season = 0, int day = 0, int hour = 0, int min = 0)
		{
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00009B88 File Offset: 0x00007D88
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C13")]
		public int Year
		{
			[Token(Token = "0x6006D40")]
			[Address(RVA = "0x2E03B0", Offset = "0x2E04B1", VA = "0x2E03B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D41")]
			[Address(RVA = "0x2E0430", Offset = "0x2E0531", VA = "0x2E0430")]
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00009BA0 File Offset: 0x00007DA0
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C14")]
		public int TotalYear
		{
			[Token(Token = "0x6006D42")]
			[Address(RVA = "0x2E0440", Offset = "0x2E0541", VA = "0x2E0440")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D43")]
			[Address(RVA = "0x2E0470", Offset = "0x2E0571", VA = "0x2E0470")]
			set
			{
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C15")]
		public int Season
		{
			[Token(Token = "0x6006D44")]
			[Address(RVA = "0x2E0490", Offset = "0x2E0591", VA = "0x2E0490")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D45")]
			[Address(RVA = "0x2E0530", Offset = "0x2E0631", VA = "0x2E0530")]
			set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00009BD0 File Offset: 0x00007DD0
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C16")]
		public int TotalSeason
		{
			[Token(Token = "0x6006D46")]
			[Address(RVA = "0x2E0540", Offset = "0x2E0641", VA = "0x2E0540")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D47")]
			[Address(RVA = "0x2E0570", Offset = "0x2E0671", VA = "0x2E0570")]
			set
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00009BE8 File Offset: 0x00007DE8
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C17")]
		public int Day
		{
			[Token(Token = "0x6006D48")]
			[Address(RVA = "0x2E0580", Offset = "0x2E0681", VA = "0x2E0580")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D49")]
			[Address(RVA = "0x2E0630", Offset = "0x2E0731", VA = "0x2E0630")]
			set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00009C00 File Offset: 0x00007E00
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C18")]
		public int TotalDay
		{
			[Token(Token = "0x6006D4A")]
			[Address(RVA = "0x2E0640", Offset = "0x2E0741", VA = "0x2E0640")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D4B")]
			[Address(RVA = "0x2E0670", Offset = "0x2E0771", VA = "0x2E0670")]
			set
			{
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00009C18 File Offset: 0x00007E18
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C19")]
		public int Hour
		{
			[Token(Token = "0x6006D4C")]
			[Address(RVA = "0x2E0680", Offset = "0x2E0781", VA = "0x2E0680")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D4D")]
			[Address(RVA = "0x2E0720", Offset = "0x2E0821", VA = "0x2E0720")]
			set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x00009C30 File Offset: 0x00007E30
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1A")]
		public int TotalHour
		{
			[Token(Token = "0x6006D4E")]
			[Address(RVA = "0x2E0730", Offset = "0x2E0831", VA = "0x2E0730")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D4F")]
			[Address(RVA = "0x2E0760", Offset = "0x2E0861", VA = "0x2E0760")]
			set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00009C48 File Offset: 0x00007E48
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1B")]
		public int Minute
		{
			[Token(Token = "0x6006D50")]
			[Address(RVA = "0x2E0770", Offset = "0x2E0871", VA = "0x2E0770")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D51")]
			[Address(RVA = "0x2E0800", Offset = "0x2E0901", VA = "0x2E0800")]
			set
			{
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00009C60 File Offset: 0x00007E60
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1C")]
		public int TotalMinute
		{
			[Token(Token = "0x6006D52")]
			[Address(RVA = "0x2E0810", Offset = "0x2E0911", VA = "0x2E0810")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006D53")]
			[Address(RVA = "0x2E0820", Offset = "0x2E0921", VA = "0x2E0820")]
			set
			{
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6006D54")]
		[Address(RVA = "0x206ADB0", Offset = "0x206AEB1", VA = "0x206ADB0")]
		public static TimeManager.RFTimeSpan operator +(TimeManager.RFTimeSpan a, TimeManager.RFTimeSpan b)
		{
			return default(TimeManager.RFTimeSpan);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6006D55")]
		[Address(RVA = "0x206ADC0", Offset = "0x206AEC1", VA = "0x206ADC0")]
		public static TimeManager.RFTimeSpan operator -(TimeManager.RFTimeSpan a, TimeManager.RFTimeSpan b)
		{
			return default(TimeManager.RFTimeSpan);
		}

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4018F60")]
		[FieldOffset(Offset = "0x0")]
		public int Span;
	}

	// Token: 0x0200032A RID: 810
	[Token(Token = "0x2001051")]
	public enum WeatherHourType
	{
		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4018F62")]
		Hour06,
		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4018F63")]
		Hour09,
		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4018F64")]
		Hour12,
		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4018F65")]
		Hour15,
		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4018F66")]
		Hour18,
		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4018F67")]
		Hour21,
		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4018F68")]
		Hour24,
		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4018F69")]
		Hour03,
		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4018F6A")]
		OneDayMax,
		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4018F6B")]
		Prev03 = 8,
		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4018F6C")]
		Spere01,
		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4018F6D")]
		Spere02,
		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4018F6E")]
		Spere03,
		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4018F6F")]
		Max
	}

	// Token: 0x0200032B RID: 811
	[Token(Token = "0x2001052")]
	private enum LotteryWeatherType
	{
		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4018F71")]
		Sunny,
		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4018F72")]
		Cloud,
		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4018F73")]
		Rain,
		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4018F74")]
		Snow,
		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4018F75")]
		SunnyOrCloud,
		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4018F76")]
		CloudOrRain,
		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4018F77")]
		SunnyOrRain,
		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4018F78")]
		CloudOrSnow,
		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4018F79")]
		SunnyOrSnow,
		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4018F7A")]
		MAX
	}

	// Token: 0x0200032C RID: 812
	[Token(Token = "0x2001053")]
	public class JustTimerData
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D56")]
		[Address(RVA = "0x20649F0", Offset = "0x2064AF1", VA = "0x20649F0")]
		public JustTimerData(int time, Action<TimeManager.JustTimerData> callback, UnityEngine.Object callObject)
		{
		}

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4018F7B")]
		[FieldOffset(Offset = "0x10")]
		public int Time;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4018F7C")]
		[FieldOffset(Offset = "0x18")]
		public Action<TimeManager.JustTimerData> CallBack;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4018F7D")]
		[FieldOffset(Offset = "0x20")]
		public UnityEngine.Object CallObject;
	}

	// Token: 0x0200032D RID: 813
	[Token(Token = "0x2001054")]
	public struct DaysInfo
	{
		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4018F7E")]
		[FieldOffset(Offset = "0x0")]
		public int Year;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4018F7F")]
		[FieldOffset(Offset = "0x4")]
		public int Season;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4018F80")]
		[FieldOffset(Offset = "0x8")]
		public int Week;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4018F81")]
		[FieldOffset(Offset = "0xC")]
		public int Day;
	}

	// Token: 0x0200032E RID: 814
	[Token(Token = "0x2001055")]
	public struct RFTimeInt
	{
		// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D57")]
		[Address(RVA = "0x2DFEC0", Offset = "0x2DFFC1", VA = "0x2DFEC0")]
		public RFTimeInt(long time)
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D58")]
		[Address(RVA = "0x2DFED0", Offset = "0x2DFFD1", VA = "0x2DFED0")]
		public RFTimeInt(TimeManager.RFDateTime date)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D59")]
		[Address(RVA = "0x2DFEE0", Offset = "0x2DFFE1", VA = "0x2DFEE0")]
		public RFTimeInt(int year, int season, int day, int hour, int min)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x17000C1D")]
		public int Year
		{
			[Token(Token = "0x6006D5A")]
			[Address(RVA = "0x2DFF20", Offset = "0x2E0021", VA = "0x2DFF20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x17000C1E")]
		public int Season
		{
			[Token(Token = "0x6006D5B")]
			[Address(RVA = "0x2DFF50", Offset = "0x2E0051", VA = "0x2DFF50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x17000C1F")]
		public int Day
		{
			[Token(Token = "0x6006D5C")]
			[Address(RVA = "0x2DFFB0", Offset = "0x2E00B1", VA = "0x2DFFB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x17000C20")]
		public int Hour
		{
			[Token(Token = "0x6006D5D")]
			[Address(RVA = "0x2E0000", Offset = "0x2E0101", VA = "0x2E0000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x17000C21")]
		public int Min
		{
			[Token(Token = "0x6006D5E")]
			[Address(RVA = "0x2E0050", Offset = "0x2E0151", VA = "0x2E0050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x17000C22")]
		public int YearSeasonDay
		{
			[Token(Token = "0x6006D5F")]
			[Address(RVA = "0x2E0090", Offset = "0x2E0191", VA = "0x2E0090")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x20695D0", Offset = "0x20696D1", VA = "0x20695D0")]
		public static long CalcTimeInt(int year, int season, int day, int hour, int min)
		{
			return 0L;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x6006D61")]
		[Address(RVA = "0x20697A0", Offset = "0x20698A1", VA = "0x20697A0")]
		public static long CalcYearSeasonDay(int ysd)
		{
			return 0L;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6006D62")]
		[Address(RVA = "0x2E00C0", Offset = "0x2E01C1", VA = "0x2E00C0")]
		public bool IsSame_YearSeasonDay(TimeManager.RFTimeInt other)
		{
			return default(bool);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6006D63")]
		[Address(RVA = "0x2E0100", Offset = "0x2E0201", VA = "0x2E0100")]
		public TimeManager.RFDateTime CalcDateTime()
		{
			return default(TimeManager.RFDateTime);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x2E0210", Offset = "0x2E0311", VA = "0x2E0210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6006D65")]
		[Address(RVA = "0x2E02C0", Offset = "0x2E03C1", VA = "0x2E02C0")]
		public bool Equals(TimeManager.RFTimeInt p)
		{
			return default(bool);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6006D66")]
		[Address(RVA = "0x2E02D0", Offset = "0x2E03D1", VA = "0x2E02D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6006D67")]
		[Address(RVA = "0x20699D0", Offset = "0x2069AD1", VA = "0x20699D0")]
		public static bool operator ==(TimeManager.RFTimeInt lhs, TimeManager.RFTimeInt rhs)
		{
			return default(bool);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6006D68")]
		[Address(RVA = "0x20699E0", Offset = "0x2069AE1", VA = "0x20699E0")]
		public static bool operator !=(TimeManager.RFTimeInt lhs, TimeManager.RFTimeInt rhs)
		{
			return default(bool);
		}

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4018F82")]
		public const long YearOffset = 10000000L;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4018F83")]
		public const long SeasonOffset = 1000000L;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4018F84")]
		public const long DayOffset = 10000L;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4018F85")]
		public const long HourOffset = 100L;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4018F86")]
		[FieldOffset(Offset = "0x0")]
		public long Time;
	}
}
