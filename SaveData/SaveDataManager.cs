using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace SaveData
{
	// Token: 0x02000EEF RID: 3823
	[Token(Token = "0x20009CA")]
	public class SaveDataManager : MonoBehaviour
	{
		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x00021810 File Offset: 0x0001FA10
		[Token(Token = "0x17000A20")]
		public static bool IsBusy
		{
			[Token(Token = "0x6005316")]
			[Address(RVA = "0x21D0370", Offset = "0x21D0471", VA = "0x21D0370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x00021828 File Offset: 0x0001FA28
		[Token(Token = "0x17000A21")]
		public static int CurrentSlot
		{
			[Token(Token = "0x6005317")]
			[Address(RVA = "0x21D0480", Offset = "0x21D0581", VA = "0x21D0480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600640D RID: 25613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A22")]
		public static string UserName
		{
			[Token(Token = "0x6005318")]
			[Address(RVA = "0x21D0560", Offset = "0x21D0661", VA = "0x21D0560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAE0", Offset = "0x1ACBE1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005319")]
			[Address(RVA = "0x21D05B0", Offset = "0x21D06B1", VA = "0x21D05B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACAF0", Offset = "0x1ACBF1")]
			set
			{
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600640E RID: 25614 RVA: 0x00021840 File Offset: 0x0001FA40
		[Token(Token = "0x17000A23")]
		public static ErrorCode ErrorCode
		{
			[Token(Token = "0x600531A")]
			[Address(RVA = "0x21D0610", Offset = "0x21D0711", VA = "0x21D0610")]
			get
			{
				return ErrorCode.NONE;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A24")]
		public static string ErrorResult
		{
			[Token(Token = "0x600531B")]
			[Address(RVA = "0x21D0680", Offset = "0x21D0781", VA = "0x21D0680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06006410 RID: 25616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A25")]
		public static RF5SystemData SystemSaveData
		{
			[Token(Token = "0x600531C")]
			[Address(RVA = "0x21D06F0", Offset = "0x21D07F1", VA = "0x21D06F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06006411 RID: 25617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A26")]
		public static RF5OptionData OptionData
		{
			[Token(Token = "0x600531D")]
			[Address(RVA = "0x21D0760", Offset = "0x21D0861", VA = "0x21D0760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06006412 RID: 25618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A27")]
		public static RF5ThumbnailData[] ThumbnailDatas
		{
			[Token(Token = "0x600531E")]
			[Address(RVA = "0x21D07D0", Offset = "0x21D08D1", VA = "0x21D07D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06006413 RID: 25619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A28")]
		public static RF5SaveData GameSaveData
		{
			[Token(Token = "0x600531F")]
			[Address(RVA = "0x21D04F0", Offset = "0x21D05F1", VA = "0x21D04F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06006414 RID: 25620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A29")]
		public static RF5WorldData WorldData
		{
			[Token(Token = "0x6005320")]
			[Address(RVA = "0x21D0840", Offset = "0x21D0941", VA = "0x21D0840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06006415 RID: 25621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2A")]
		public static RF5PlayerData PlayerData
		{
			[Token(Token = "0x6005321")]
			[Address(RVA = "0x21D08B0", Offset = "0x21D09B1", VA = "0x21D08B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06006416 RID: 25622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2B")]
		public static RF5BattleData BattleData
		{
			[Token(Token = "0x6005322")]
			[Address(RVA = "0x21D0920", Offset = "0x21D0A21", VA = "0x21D0920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2C")]
		public static RF5ItemData ItemData
		{
			[Token(Token = "0x6005323")]
			[Address(RVA = "0x21D0990", Offset = "0x21D0A91", VA = "0x21D0990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06006418 RID: 25624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2D")]
		public static RF5StatusData StatusData
		{
			[Token(Token = "0x6005324")]
			[Address(RVA = "0x21D0A00", Offset = "0x21D0B01", VA = "0x21D0A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06006419 RID: 25625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2E")]
		public static RF5OrderData OrderData
		{
			[Token(Token = "0x6005325")]
			[Address(RVA = "0x21D0A70", Offset = "0x21D0B71", VA = "0x21D0A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600641A RID: 25626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2F")]
		public static RF5NpcData NpcData
		{
			[Token(Token = "0x6005326")]
			[Address(RVA = "0x21D0AE0", Offset = "0x21D0BE1", VA = "0x21D0AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600641B RID: 25627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		public static RF5PoliceBatchData PoliceBatchData
		{
			[Token(Token = "0x6005327")]
			[Address(RVA = "0x21D0B50", Offset = "0x21D0C51", VA = "0x21D0B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600641C RID: 25628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A31")]
		public static RF5FarmData FarmData
		{
			[Token(Token = "0x6005328")]
			[Address(RVA = "0x21D0BC0", Offset = "0x21D0CC1", VA = "0x21D0BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600641D RID: 25629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A32")]
		public static RF5MakingData MakingData
		{
			[Token(Token = "0x6005329")]
			[Address(RVA = "0x21D0C30", Offset = "0x21D0D31", VA = "0x21D0C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x0600641E RID: 25630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A33")]
		public static RF5BuildData BuildData
		{
			[Token(Token = "0x600532A")]
			[Address(RVA = "0x21D0CA0", Offset = "0x21D0DA1", VA = "0x21D0CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532B")]
		[Address(RVA = "0x21D0D10", Offset = "0x21D0E11", VA = "0x21D0D10")]
		public static void Initialize()
		{
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532C")]
		[Address(RVA = "0x21D0E30", Offset = "0x21D0F31", VA = "0x21D0E30")]
		public static void InitializeForNewGame()
		{
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532D")]
		[Address(RVA = "0x21D1100", Offset = "0x21D1201", VA = "0x21D1100")]
		public static void SystemDataInitialize()
		{
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532E")]
		[Address(RVA = "0x21D1270", Offset = "0x21D1371", VA = "0x21D1270")]
		public static void SystemDataSave([Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532F")]
		[Address(RVA = "0x21D1330", Offset = "0x21D1431", VA = "0x21D1330")]
		public static void SystemDataLoad([Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005330")]
		[Address(RVA = "0x21D13F0", Offset = "0x21D14F1", VA = "0x21D13F0")]
		public static void GameDataSalvage([Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x21D14D0", Offset = "0x21D15D1", VA = "0x21D14D0")]
		public static void GameDataSave(int slot, [Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005332")]
		[Address(RVA = "0x21D15F0", Offset = "0x21D16F1", VA = "0x21D15F0")]
		public static void GameDataLoad(int slot, [Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005333")]
		[Address(RVA = "0x21D17F0", Offset = "0x21D18F1", VA = "0x21D17F0")]
		public static void SystemDataDelete()
		{
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005334")]
		[Address(RVA = "0x21D1870", Offset = "0x21D1971", VA = "0x21D1870")]
		public static void GameDataDelete()
		{
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005335")]
		[Address(RVA = "0x21D1940", Offset = "0x21D1A41", VA = "0x21D1940")]
		public static void GameDataDelete(int slot, [Optional] Action<ErrorCode> onComplete)
		{
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00021858 File Offset: 0x0001FA58
		[Token(Token = "0x6005336")]
		[Address(RVA = "0x21D1A10", Offset = "0x21D1B11", VA = "0x21D1A10")]
		public static bool IsSaveDataExisting(ulong applicationId = 72100543920185344UL)
		{
			return default(bool);
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A34")]
		private static SaveDataManager Instance
		{
			[Token(Token = "0x6005337")]
			[Address(RVA = "0x21D1A90", Offset = "0x21D1B91", VA = "0x21D1A90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB00", Offset = "0x1ACC01")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005338")]
			[Address(RVA = "0x21D1AE0", Offset = "0x21D1BE1", VA = "0x21D1AE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB10", Offset = "0x1ACC11")]
			set
			{
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600642E RID: 25646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A35")]
		private SaveControllerBase SaveController
		{
			[Token(Token = "0x6005339")]
			[Address(RVA = "0x21D1B40", Offset = "0x21D1C41", VA = "0x21D1B40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB20", Offset = "0x1ACC21")]
			get
			{
				return null;
			}
			[Token(Token = "0x600533A")]
			[Address(RVA = "0x21D1B50", Offset = "0x21D1C51", VA = "0x21D1B50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACB30", Offset = "0x1ACC31")]
			set
			{
			}
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533B")]
		[Address(RVA = "0x21D1B60", Offset = "0x21D1C61", VA = "0x21D1B60")]
		private void Awake()
		{
		}

		// Token: 0x06006430 RID: 25648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533C")]
		[Address(RVA = "0x21D0D70", Offset = "0x21D0E71", VA = "0x21D0D70")]
		private void Create()
		{
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533D")]
		[Address(RVA = "0x21D23B0", Offset = "0x21D24B1", VA = "0x21D23B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533E")]
		[Address(RVA = "0x21D2400", Offset = "0x21D2501", VA = "0x21D2400")]
		private void Update()
		{
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600533F")]
		[Address(RVA = "0x21D2970", Offset = "0x21D2A71", VA = "0x21D2970")]
		public SaveDataManager()
		{
		}

		// Token: 0x0400C3E9 RID: 50153
		[Token(Token = "0x40092C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SystemSaveData SystemData;

		// Token: 0x0400C3EA RID: 50154
		[Token(Token = "0x40092C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameSaveData GameData;

		// Token: 0x0400C3EB RID: 50155
		[Token(Token = "0x40092CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F390", Offset = "0x17F491")]
		private static string <UserName>k__BackingField;

		// Token: 0x0400C3EC RID: 50156
		[Token(Token = "0x40092CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F3A0", Offset = "0x17F4A1")]
		private static SaveDataManager <Instance>k__BackingField;

		// Token: 0x0400C3ED RID: 50157
		[Token(Token = "0x40092CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F3B0", Offset = "0x17F4B1")]
		private SaveControllerBase <SaveController>k__BackingField;

		// Token: 0x0400C3EE RID: 50158
		[Token(Token = "0x40092CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SaveDataManager.STATE State;

		// Token: 0x0400C3EF RID: 50159
		[Token(Token = "0x40092CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float WaitTime;

		// Token: 0x0400C3F0 RID: 50160
		[Token(Token = "0x40092CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameSaveData TargetDatas;

		// Token: 0x0400C3F1 RID: 50161
		[Token(Token = "0x40092D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<ErrorCode> OnComplete;

		// Token: 0x02000EF0 RID: 3824
		[Token(Token = "0x2001491")]
		private enum STATE
		{
			// Token: 0x0400C3F3 RID: 50163
			[Token(Token = "0x401BD2E")]
			IDLE,
			// Token: 0x0400C3F4 RID: 50164
			[Token(Token = "0x401BD2F")]
			INIT,
			// Token: 0x0400C3F5 RID: 50165
			[Token(Token = "0x401BD30")]
			SYSTEMDATA_LOAD,
			// Token: 0x0400C3F6 RID: 50166
			[Token(Token = "0x401BD31")]
			SYSTEMDATA_LOADWAIT,
			// Token: 0x0400C3F7 RID: 50167
			[Token(Token = "0x401BD32")]
			SYSTEMDATA_SAVE,
			// Token: 0x0400C3F8 RID: 50168
			[Token(Token = "0x401BD33")]
			SYSTEMDATA_SAVEWAIT,
			// Token: 0x0400C3F9 RID: 50169
			[Token(Token = "0x401BD34")]
			GAMEDATA_LOAD,
			// Token: 0x0400C3FA RID: 50170
			[Token(Token = "0x401BD35")]
			GAMEDATA_LOADWAIT,
			// Token: 0x0400C3FB RID: 50171
			[Token(Token = "0x401BD36")]
			GAMEDATA_SAVE,
			// Token: 0x0400C3FC RID: 50172
			[Token(Token = "0x401BD37")]
			GAMEDATA_SAVEWAIT,
			// Token: 0x0400C3FD RID: 50173
			[Token(Token = "0x401BD38")]
			GAMEDATA_SALVAGE,
			// Token: 0x0400C3FE RID: 50174
			[Token(Token = "0x401BD39")]
			GAMEDATA_SALVAGEWAIT,
			// Token: 0x0400C3FF RID: 50175
			[Token(Token = "0x401BD3A")]
			GAMEDATA_DELETE,
			// Token: 0x0400C400 RID: 50176
			[Token(Token = "0x401BD3B")]
			GAMEDATA_DELETEWAIT
		}
	}
}
