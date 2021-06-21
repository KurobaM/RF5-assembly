using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x020007FF RID: 2047
[Token(Token = "0x2000545")]
public class NpcLifeCycleDataManager
{
	// Token: 0x170007A5 RID: 1957
	// (get) Token: 0x060036AA RID: 13994 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060036AB RID: 13995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005F2")]
	public NpcLifeCycleData LifeCycleData
	{
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x1F47770", Offset = "0x1F47871", VA = "0x1F47770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A10", Offset = "0x1A5B11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x1F47780", Offset = "0x1F47881", VA = "0x1F47780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A20", Offset = "0x1A5B21")]
		private set
		{
		}
	}

	// Token: 0x170007A6 RID: 1958
	// (get) Token: 0x060036AC RID: 13996 RVA: 0x00012DE0 File Offset: 0x00010FE0
	// (set) Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005F3")]
	public int LifeCycleDataId
	{
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x1F47790", Offset = "0x1F47891", VA = "0x1F47790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A30", Offset = "0x1A5B31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x1F477A0", Offset = "0x1F478A1", VA = "0x1F477A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A40", Offset = "0x1A5B41")]
		set
		{
		}
	}

	// Token: 0x170007A7 RID: 1959
	// (get) Token: 0x060036AE RID: 13998 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005F4")]
	public Dictionary<Weather, int> WeatherOffset
	{
		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x1F477B0", Offset = "0x1F478B1", VA = "0x1F477B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A50", Offset = "0x1A5B51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x1F477C0", Offset = "0x1F478C1", VA = "0x1F477C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5A60", Offset = "0x1A5B61")]
		private set
		{
		}
	}

	// Token: 0x060036B0 RID: 14000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x1F477D0", Offset = "0x1F478D1", VA = "0x1F477D0")]
	public NpcLifeCycleDataManager()
	{
	}

	// Token: 0x060036B1 RID: 14001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x1F478E0", Offset = "0x1F479E1", VA = "0x1F478E0", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x060036B2 RID: 14002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x1F479B0", Offset = "0x1F47AB1", VA = "0x1F479B0")]
	public void RemoveResources()
	{
	}

	// Token: 0x060036B3 RID: 14003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x1F47860", Offset = "0x1F47961", VA = "0x1F47860")]
	public void Init()
	{
	}

	// Token: 0x060036B4 RID: 14004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0x1F47A30", Offset = "0x1F47B31", VA = "0x1F47A30")]
	public void DataSet(NpcLifeCycleData data, int loaderId)
	{
	}

	// Token: 0x060036B5 RID: 14005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D7D")]
	[Address(RVA = "0x1F47C40", Offset = "0x1F47D41", VA = "0x1F47C40")]
	public NpcLifeCycleTime GetCurrentTimeList(int time)
	{
		return null;
	}

	// Token: 0x060036B6 RID: 14006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0x1F47D90", Offset = "0x1F47E91", VA = "0x1F47D90")]
	public void ShiftTimeList(int time)
	{
	}

	// Token: 0x060036B7 RID: 14007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0x1F47EE0", Offset = "0x1F47FE1", VA = "0x1F47EE0")]
	public NpcLifeCycleTime[] GetTimeList()
	{
		return null;
	}

	// Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D80")]
	[Address(RVA = "0x1F47F00", Offset = "0x1F48001", VA = "0x1F47F00")]
	public NpcLifeCycleTimeData[] GetTimeData(Weather weather)
	{
		return null;
	}

	// Token: 0x060036B9 RID: 14009 RVA: 0x00012DF8 File Offset: 0x00010FF8
	[Token(Token = "0x6002D81")]
	[Address(RVA = "0x1F47FA0", Offset = "0x1F480A1", VA = "0x1F47FA0")]
	public int TimeToIndex(int time)
	{
		return 0;
	}

	// Token: 0x060036BA RID: 14010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x1F48060", Offset = "0x1F48161", VA = "0x1F48060")]
	public NpcLifeCycleTimeData GetTimeData(Weather weather, int time)
	{
		return null;
	}

	// Token: 0x040079A7 RID: 31143
	[Token(Token = "0x4006E36")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16AE90", Offset = "0x16AF91")]
	private NpcLifeCycleData <LifeCycleData>k__BackingField;

	// Token: 0x040079A8 RID: 31144
	[Token(Token = "0x4006E37")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16AEA0", Offset = "0x16AFA1")]
	private int <LifeCycleDataId>k__BackingField;

	// Token: 0x040079A9 RID: 31145
	[Token(Token = "0x4006E38")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16AEB0", Offset = "0x16AFB1")]
	private Dictionary<Weather, int> <WeatherOffset>k__BackingField;
}
