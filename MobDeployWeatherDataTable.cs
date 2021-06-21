using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000399 RID: 921
[Token(Token = "0x20002C1")]
[Serializable]
public class MobDeployWeatherDataTable
{
	// Token: 0x0600171A RID: 5914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x1D79A50", Offset = "0x1D79B51", VA = "0x1D79A50")]
	public static MobDeployWeatherDataTable GetDataTable(WeatherDay weather)
	{
		return null;
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x0000A290 File Offset: 0x00008490
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x1D79BF0", Offset = "0x1D79CF1", VA = "0x1D79BF0")]
	public static bool HasDataTable(WeatherDay weather)
	{
		return default(bool);
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x1D79BE0", Offset = "0x1D79CE1", VA = "0x1D79BE0")]
	public MobDeployWeatherDataTable()
	{
	}

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MobDeployWeatherData Data;

	// Token: 0x0400103D RID: 4157
	[Token(Token = "0x4000CF1")]
	[FieldOffset(Offset = "0x0")]
	private static MobDeployWeatherDataTableArray _MobDeployWeatherDataTableArray;
}
