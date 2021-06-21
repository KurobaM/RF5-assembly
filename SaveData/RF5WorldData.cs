using System;
using System.Collections.Generic;
using BinaryStream;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

namespace SaveData
{
	// Token: 0x02000EE1 RID: 3809
	[Token(Token = "0x20009C0")]
	public class RF5WorldData : SaveDataValueBase
	{
		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x000215B8 File Offset: 0x0001F7B8
		// (set) Token: 0x06006395 RID: 25493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0D")]
		public Difficulty Difficulty
		{
			[Token(Token = "0x60052A5")]
			[Address(RVA = "0x1F0A180", Offset = "0x1F0A281", VA = "0x1F0A180")]
			get
			{
				return Difficulty.Easy;
			}
			[Token(Token = "0x60052A6")]
			[Address(RVA = "0x1F0A190", Offset = "0x1F0A291", VA = "0x1F0A190")]
			set
			{
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06006396 RID: 25494 RVA: 0x000215D0 File Offset: 0x0001F7D0
		// (set) Token: 0x06006397 RID: 25495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0E")]
		public Weather Weather
		{
			[Token(Token = "0x60052A7")]
			[Address(RVA = "0x1F0A1A0", Offset = "0x1F0A2A1", VA = "0x1F0A1A0")]
			get
			{
				return Weather.None;
			}
			[Token(Token = "0x60052A8")]
			[Address(RVA = "0x1F0A1B0", Offset = "0x1F0A2B1", VA = "0x1F0A1B0")]
			set
			{
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x000215E8 File Offset: 0x0001F7E8
		// (set) Token: 0x06006399 RID: 25497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0F")]
		public WeatherDay WeatherDay
		{
			[Token(Token = "0x60052A9")]
			[Address(RVA = "0x1F0A1C0", Offset = "0x1F0A2C1", VA = "0x1F0A1C0")]
			get
			{
				return WeatherDay.None;
			}
			[Token(Token = "0x60052AA")]
			[Address(RVA = "0x1F0A1D0", Offset = "0x1F0A2D1", VA = "0x1F0A1D0")]
			set
			{
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x00021600 File Offset: 0x0001F800
		// (set) Token: 0x0600639B RID: 25499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A10")]
		public byte TodayRate
		{
			[Token(Token = "0x60052AB")]
			[Address(RVA = "0x1F0A1E0", Offset = "0x1F0A2E1", VA = "0x1F0A1E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60052AC")]
			[Address(RVA = "0x1F0A1F0", Offset = "0x1F0A2F1", VA = "0x1F0A1F0")]
			set
			{
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x00021618 File Offset: 0x0001F818
		// (set) Token: 0x0600639D RID: 25501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A11")]
		public byte TyphoonDayCount
		{
			[Token(Token = "0x60052AD")]
			[Address(RVA = "0x1F0A200", Offset = "0x1F0A301", VA = "0x1F0A200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60052AE")]
			[Address(RVA = "0x1F0A210", Offset = "0x1F0A311", VA = "0x1F0A210")]
			set
			{
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x00021630 File Offset: 0x0001F830
		// (set) Token: 0x0600639F RID: 25503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A12")]
		public byte RuneyDayCount
		{
			[Token(Token = "0x60052AF")]
			[Address(RVA = "0x1F0A220", Offset = "0x1F0A321", VA = "0x1F0A220")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60052B0")]
			[Address(RVA = "0x1F0A230", Offset = "0x1F0A331", VA = "0x1F0A230")]
			set
			{
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060063A0 RID: 25504 RVA: 0x00021648 File Offset: 0x0001F848
		// (set) Token: 0x060063A1 RID: 25505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A13")]
		public byte MeteorShowerDayCount
		{
			[Token(Token = "0x60052B1")]
			[Address(RVA = "0x1F0A240", Offset = "0x1F0A341", VA = "0x1F0A240")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60052B2")]
			[Address(RVA = "0x1F0A250", Offset = "0x1F0A351", VA = "0x1F0A250")]
			set
			{
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x00021660 File Offset: 0x0001F860
		// (set) Token: 0x060063A3 RID: 25507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A14")]
		public byte NextWeatherDayId
		{
			[Token(Token = "0x60052B3")]
			[Address(RVA = "0x1F0A260", Offset = "0x1F0A361", VA = "0x1F0A260")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60052B4")]
			[Address(RVA = "0x1F0A270", Offset = "0x1F0A371", VA = "0x1F0A270")]
			set
			{
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060063A4 RID: 25508 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060063A5 RID: 25509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A15")]
		public byte[] WeatherHour
		{
			[Token(Token = "0x60052B5")]
			[Address(RVA = "0x1F0A280", Offset = "0x1F0A381", VA = "0x1F0A280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60052B6")]
			[Address(RVA = "0x1F0A290", Offset = "0x1F0A391", VA = "0x1F0A290")]
			set
			{
			}
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x00021678 File Offset: 0x0001F878
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0x1F0A2A0", Offset = "0x1F0A3A1", VA = "0x1F0A2A0")]
		public bool GetItemSpawnFlag(FieldItemSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B8")]
		[Address(RVA = "0x1F0A2C0", Offset = "0x1F0A3C1", VA = "0x1F0A2C0")]
		public void SetItemSpawnFlag(FieldItemSpawnID id, bool value)
		{
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x00021690 File Offset: 0x0001F890
		[Token(Token = "0x60052B9")]
		[Address(RVA = "0x1F0A2E0", Offset = "0x1F0A3E1", VA = "0x1F0A2E0")]
		public bool GetTreasureFlag(FieldUniqueTreasureBoxSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0x1F0A300", Offset = "0x1F0A401", VA = "0x1F0A300")]
		public void SetTreasureFlag(FieldUniqueTreasureBoxSpawnID id, bool value)
		{
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x000216A8 File Offset: 0x0001F8A8
		[Token(Token = "0x60052BB")]
		[Address(RVA = "0x1F0A320", Offset = "0x1F0A421", VA = "0x1F0A320")]
		public bool GetGimmickFlag(GimmickLayoutID id)
		{
			return default(bool);
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x1F0A340", Offset = "0x1F0A441", VA = "0x1F0A340")]
		public void SetGimmickFlag(GimmickLayoutID id, bool value)
		{
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x1F05D70", Offset = "0x1F05E71", VA = "0x1F05D70")]
		public RF5WorldData()
		{
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x1F0A360", Offset = "0x1F0A461", VA = "0x1F0A360", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BF")]
		[Address(RVA = "0x1F0A5F0", Offset = "0x1F0A6F1", VA = "0x1F0A5F0")]
		public void InitPunchCount()
		{
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x1F0A600", Offset = "0x1F0A701", VA = "0x1F0A600", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x1F0A7C0", Offset = "0x1F0A8C1", VA = "0x1F0A7C0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x1F0A7D0", Offset = "0x1F0A8D1", VA = "0x1F0A7D0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x1F06A20", Offset = "0x1F06B21", VA = "0x1F06A20")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x1F073F0", Offset = "0x1F074F1", VA = "0x1F073F0")]
		public void Reader0001(BinaryReader reader)
		{
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x1F07870", Offset = "0x1F07971", VA = "0x1F07870")]
		public void Reader0002(BinaryReader reader)
		{
		}

		// Token: 0x0400C38A RID: 50058
		[Token(Token = "0x400927F")]
		[FieldOffset(Offset = "0x10")]
		private byte DifficultyValue;

		// Token: 0x0400C38B RID: 50059
		[Token(Token = "0x4009280")]
		[FieldOffset(Offset = "0x14")]
		public int SenarioStoppedTime;

		// Token: 0x0400C38C RID: 50060
		[Token(Token = "0x4009281")]
		[FieldOffset(Offset = "0x18")]
		public int MapId;

		// Token: 0x0400C38D RID: 50061
		[Token(Token = "0x4009282")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Position;

		// Token: 0x0400C38E RID: 50062
		[Token(Token = "0x4009283")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 RotationEuler;

		// Token: 0x0400C38F RID: 50063
		[Token(Token = "0x4009284")]
		[FieldOffset(Offset = "0x34")]
		public int InGameTimeElapsedTime;

		// Token: 0x0400C390 RID: 50064
		[Token(Token = "0x4009285")]
		[FieldOffset(Offset = "0x38")]
		public WeatherData WeatherData;

		// Token: 0x0400C391 RID: 50065
		[Token(Token = "0x4009286")]
		[FieldOffset(Offset = "0x48")]
		public uint ShopRandSeedFix;

		// Token: 0x0400C392 RID: 50066
		[Token(Token = "0x4009287")]
		[FieldOffset(Offset = "0x4C")]
		public uint ShopRandSeed;

		// Token: 0x0400C393 RID: 50067
		[Token(Token = "0x4009288")]
		[FieldOffset(Offset = "0x50")]
		public int ShopSeedGenerateDay;

		// Token: 0x0400C394 RID: 50068
		[Token(Token = "0x4009289")]
		[FieldOffset(Offset = "0x54")]
		public int LastShippingDay;

		// Token: 0x0400C395 RID: 50069
		[Token(Token = "0x400928A")]
		[FieldOffset(Offset = "0x58")]
		public int LastPlaceId;

		// Token: 0x0400C396 RID: 50070
		[Token(Token = "0x400928B")]
		[FieldOffset(Offset = "0x5C")]
		public int LastSleepTime;

		// Token: 0x0400C397 RID: 50071
		[Token(Token = "0x400928C")]
		[FieldOffset(Offset = "0x60")]
		public MiningPointSaveData[] MiningPointSaveDatas;

		// Token: 0x0400C398 RID: 50072
		[Token(Token = "0x400928D")]
		[FieldOffset(Offset = "0x68")]
		public RewardBoxSaveData RewardBoxSaveData;

		// Token: 0x0400C399 RID: 50073
		[Token(Token = "0x400928E")]
		[FieldOffset(Offset = "0x70")]
		public SaveFlagStorage ItemSpawnFlag;

		// Token: 0x0400C39A RID: 50074
		[Token(Token = "0x400928F")]
		[FieldOffset(Offset = "0x78")]
		public SaveFlagStorage TreasureFlag;

		// Token: 0x0400C39B RID: 50075
		[Token(Token = "0x4009290")]
		[FieldOffset(Offset = "0x80")]
		public SaveFlagStorage GimmickFlag;

		// Token: 0x0400C39C RID: 50076
		[Token(Token = "0x4009291")]
		[FieldOffset(Offset = "0x88")]
		public int SeedPointElapsedDay;

		// Token: 0x0400C39D RID: 50077
		[Token(Token = "0x4009292")]
		[FieldOffset(Offset = "0x8C")]
		public int SeedPointMonsterAddedCount;

		// Token: 0x0400C39E RID: 50078
		[Token(Token = "0x4009293")]
		[FieldOffset(Offset = "0x90")]
		public float SeedSupportCoolTime;

		// Token: 0x0400C39F RID: 50079
		[Token(Token = "0x4009294")]
		[FieldOffset(Offset = "0x98")]
		public List<int> MeteorPosition;

		// Token: 0x0400C3A0 RID: 50080
		[Token(Token = "0x4009295")]
		[FieldOffset(Offset = "0xA0")]
		public int OffsetFiveYearAgo;

		// Token: 0x0400C3A1 RID: 50081
		[Token(Token = "0x4009296")]
		[FieldOffset(Offset = "0xA4")]
		public int PunchCount;
	}
}
