using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace SaveData
{
	// Token: 0x02000EF4 RID: 3828
	[Token(Token = "0x20009CD")]
	public class RF5SystemData : SaveDataValueBase
	{
		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x00021960 File Offset: 0x0001FB60
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A3F")]
		public bool IsGameCleared
		{
			[Token(Token = "0x6005363")]
			[Address(RVA = "0x1F09120", Offset = "0x1F09221", VA = "0x1F09120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005364")]
			[Address(RVA = "0x1F09160", Offset = "0x1F09261", VA = "0x1F09160")]
			set
			{
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x00021978 File Offset: 0x0001FB78
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A40")]
		public bool IsPlayMan
		{
			[Token(Token = "0x6005365")]
			[Address(RVA = "0x1F091B0", Offset = "0x1F092B1", VA = "0x1F091B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005366")]
			[Address(RVA = "0x1F091D0", Offset = "0x1F092D1", VA = "0x1F091D0")]
			set
			{
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x00021990 File Offset: 0x0001FB90
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A41")]
		public bool IsPlayWoman
		{
			[Token(Token = "0x6005367")]
			[Address(RVA = "0x1F09200", Offset = "0x1F09301", VA = "0x1F09200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005368")]
			[Address(RVA = "0x1F09220", Offset = "0x1F09321", VA = "0x1F09220")]
			set
			{
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x000219A8 File Offset: 0x0001FBA8
		// (set) Token: 0x0600645E RID: 25694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A42")]
		public bool IsOP2Open
		{
			[Token(Token = "0x6005369")]
			[Address(RVA = "0x1F09250", Offset = "0x1F09351", VA = "0x1F09250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600536A")]
			[Address(RVA = "0x1F09270", Offset = "0x1F09371", VA = "0x1F09270")]
			set
			{
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x000219C0 File Offset: 0x0001FBC0
		// (set) Token: 0x06006460 RID: 25696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A43")]
		public bool IsMissionAllCleared
		{
			[Token(Token = "0x600536B")]
			[Address(RVA = "0x1F092A0", Offset = "0x1F093A1", VA = "0x1F092A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600536C")]
			[Address(RVA = "0x1F092C0", Offset = "0x1F093C1", VA = "0x1F092C0")]
			set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x000219D8 File Offset: 0x0001FBD8
		[Token(Token = "0x17000A44")]
		public bool IsChildBorned
		{
			[Token(Token = "0x600536D")]
			[Address(RVA = "0x1F092F0", Offset = "0x1F093F1", VA = "0x1F092F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x000219F0 File Offset: 0x0001FBF0
		[Token(Token = "0x600536E")]
		[Address(RVA = "0x1F09140", Offset = "0x1F09241", VA = "0x1F09140")]
		public bool GetSaveFlag(RF5SystemData.FLAG id)
		{
			return default(bool);
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600536F")]
		[Address(RVA = "0x1F09190", Offset = "0x1F09291", VA = "0x1F09190")]
		public void SetSaveFlag(RF5SystemData.FLAG id, bool value)
		{
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005370")]
		[Address(RVA = "0x1F093B0", Offset = "0x1F094B1", VA = "0x1F093B0")]
		public void SetMovieFlag(MovieID movieEnum)
		{
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x00021A08 File Offset: 0x0001FC08
		[Token(Token = "0x6005371")]
		[Address(RVA = "0x1F093D0", Offset = "0x1F094D1", VA = "0x1F093D0")]
		public bool GetMovieFlag(MovieID movieEnum)
		{
			return default(bool);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x00021A20 File Offset: 0x0001FC20
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x1F093F0", Offset = "0x1F094F1", VA = "0x1F093F0")]
		public bool GetDLCFlag(DLCID id)
		{
			return default(bool);
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x1F094A0", Offset = "0x1F095A1", VA = "0x1F094A0")]
		public RF5SystemData()
		{
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005374")]
		[Address(RVA = "0x1F09530", Offset = "0x1F09631", VA = "0x1F09530", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005375")]
		[Address(RVA = "0x1F09770", Offset = "0x1F09871", VA = "0x1F09770")]
		public void UpdateSaveData(int slot, RF5SaveData saveData)
		{
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005376")]
		[Address(RVA = "0x1F09A70", Offset = "0x1F09B71", VA = "0x1F09A70", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005377")]
		[Address(RVA = "0x1F09A90", Offset = "0x1F09B91", VA = "0x1F09A90", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x1F09B80", Offset = "0x1F09C81", VA = "0x1F09B80", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x1F09CA0", Offset = "0x1F09DA1", VA = "0x1F09CA0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C416 RID: 50198
		[Token(Token = "0x40092DB")]
		[FieldOffset(Offset = "0x10")]
		public short LatestSlotIndex;

		// Token: 0x0400C417 RID: 50199
		[Token(Token = "0x40092DC")]
		[FieldOffset(Offset = "0x12")]
		public ushort TimeMonth;

		// Token: 0x0400C418 RID: 50200
		[Token(Token = "0x40092DD")]
		[FieldOffset(Offset = "0x14")]
		public SystemLanguage Language;

		// Token: 0x0400C419 RID: 50201
		[Token(Token = "0x40092DE")]
		[FieldOffset(Offset = "0x18")]
		public SystemLanguage VoiceLanguage;

		// Token: 0x0400C41A RID: 50202
		[Token(Token = "0x40092DF")]
		[FieldOffset(Offset = "0x20")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x0400C41B RID: 50203
		[Token(Token = "0x40092E0")]
		[FieldOffset(Offset = "0x28")]
		public uint MovieDataFlag;

		// Token: 0x0400C41C RID: 50204
		[Token(Token = "0x40092E1")]
		[FieldOffset(Offset = "0x30")]
		public RF5OptionData OptionData;

		// Token: 0x0400C41D RID: 50205
		[Token(Token = "0x40092E2")]
		[FieldOffset(Offset = "0x38")]
		public RF5ThumbnailData[] ThumbData;

		// Token: 0x0400C41E RID: 50206
		[Token(Token = "0x40092E3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RF5SystemData.FLAG[] DLCtoSaveFlag;

		// Token: 0x02000EF5 RID: 3829
		[Token(Token = "0x2001493")]
		public enum FLAG
		{
			// Token: 0x0400C420 RID: 50208
			[Token(Token = "0x401BD48")]
			IsGameCleared,
			// Token: 0x0400C421 RID: 50209
			[Token(Token = "0x401BD49")]
			IsPlayMan,
			// Token: 0x0400C422 RID: 50210
			[Token(Token = "0x401BD4A")]
			IsPlayWoman,
			// Token: 0x0400C423 RID: 50211
			[Token(Token = "0x401BD4B")]
			IsOP2Open,
			// Token: 0x0400C424 RID: 50212
			[Token(Token = "0x401BD4C")]
			IsMissionAllCleared,
			// Token: 0x0400C425 RID: 50213
			[Token(Token = "0x401BD4D")]
			NpcLove3_act001,
			// Token: 0x0400C426 RID: 50214
			[Token(Token = "0x401BD4E")]
			NpcLove3_act002,
			// Token: 0x0400C427 RID: 50215
			[Token(Token = "0x401BD4F")]
			NpcLove3_act003,
			// Token: 0x0400C428 RID: 50216
			[Token(Token = "0x401BD50")]
			NpcLove3_act004,
			// Token: 0x0400C429 RID: 50217
			[Token(Token = "0x401BD51")]
			NpcLove3_act005,
			// Token: 0x0400C42A RID: 50218
			[Token(Token = "0x401BD52")]
			NpcLove3_act006,
			// Token: 0x0400C42B RID: 50219
			[Token(Token = "0x401BD53")]
			NpcLove3_act007,
			// Token: 0x0400C42C RID: 50220
			[Token(Token = "0x401BD54")]
			NpcLove3_act008,
			// Token: 0x0400C42D RID: 50221
			[Token(Token = "0x401BD55")]
			NpcLove3_act009,
			// Token: 0x0400C42E RID: 50222
			[Token(Token = "0x401BD56")]
			NpcLove3_act010,
			// Token: 0x0400C42F RID: 50223
			[Token(Token = "0x401BD57")]
			NpcLove3_act011,
			// Token: 0x0400C430 RID: 50224
			[Token(Token = "0x401BD58")]
			NpcLove3_act012,
			// Token: 0x0400C431 RID: 50225
			[Token(Token = "0x401BD59")]
			NpcLove3_act013,
			// Token: 0x0400C432 RID: 50226
			[Token(Token = "0x401BD5A")]
			NpcLove3_act014,
			// Token: 0x0400C433 RID: 50227
			[Token(Token = "0x401BD5B")]
			NpcLove3_act015,
			// Token: 0x0400C434 RID: 50228
			[Token(Token = "0x401BD5C")]
			NpcLove3_act016,
			// Token: 0x0400C435 RID: 50229
			[Token(Token = "0x401BD5D")]
			NpcLove3_act017,
			// Token: 0x0400C436 RID: 50230
			[Token(Token = "0x401BD5E")]
			NpcLove3_act018,
			// Token: 0x0400C437 RID: 50231
			[Token(Token = "0x401BD5F")]
			NpcLove3_act019,
			// Token: 0x0400C438 RID: 50232
			[Token(Token = "0x401BD60")]
			NpcLove3_act020,
			// Token: 0x0400C439 RID: 50233
			[Token(Token = "0x401BD61")]
			NpcLove3_act021,
			// Token: 0x0400C43A RID: 50234
			[Token(Token = "0x401BD62")]
			NpcLove3_act022,
			// Token: 0x0400C43B RID: 50235
			[Token(Token = "0x401BD63")]
			NpcLove3_act023,
			// Token: 0x0400C43C RID: 50236
			[Token(Token = "0x401BD64")]
			NpcLove3_act024,
			// Token: 0x0400C43D RID: 50237
			[Token(Token = "0x401BD65")]
			NpcLove3_act025,
			// Token: 0x0400C43E RID: 50238
			[Token(Token = "0x401BD66")]
			NpcLove3_act031,
			// Token: 0x0400C43F RID: 50239
			[Token(Token = "0x401BD67")]
			NpcLove3_act032,
			// Token: 0x0400C440 RID: 50240
			[Token(Token = "0x401BD68")]
			BoreChild_Boy1,
			// Token: 0x0400C441 RID: 50241
			[Token(Token = "0x401BD69")]
			BoreChild_Boy2,
			// Token: 0x0400C442 RID: 50242
			[Token(Token = "0x401BD6A")]
			BoreChild_Boy3,
			// Token: 0x0400C443 RID: 50243
			[Token(Token = "0x401BD6B")]
			BoreChild_Girl1,
			// Token: 0x0400C444 RID: 50244
			[Token(Token = "0x401BD6C")]
			BoreChild_Girl2,
			// Token: 0x0400C445 RID: 50245
			[Token(Token = "0x401BD6D")]
			BoreChild_Girl3,
			// Token: 0x0400C446 RID: 50246
			[Token(Token = "0x401BD6E")]
			SaveLink,
			// Token: 0x0400C447 RID: 50247
			[Token(Token = "0x401BD6F")]
			LimitedSPPack,
			// Token: 0x0400C448 RID: 50248
			[Token(Token = "0x401BD70")]
			ShopSPPack001,
			// Token: 0x0400C449 RID: 50249
			[Token(Token = "0x401BD71")]
			ShopSPPack002,
			// Token: 0x0400C44A RID: 50250
			[Token(Token = "0x401BD72")]
			ShopSPPack003,
			// Token: 0x0400C44B RID: 50251
			[Token(Token = "0x401BD73")]
			ShopSPPack004,
			// Token: 0x0400C44C RID: 50252
			[Token(Token = "0x401BD74")]
			ShopSPPack005,
			// Token: 0x0400C44D RID: 50253
			[Token(Token = "0x401BD75")]
			ShopSPPack006,
			// Token: 0x0400C44E RID: 50254
			[Token(Token = "0x401BD76")]
			Length = 64
		}
	}
}
