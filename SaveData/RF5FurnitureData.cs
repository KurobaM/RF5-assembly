using System;
using System.Collections.Generic;
using BinaryStream;
using Field;
using Il2CppDummyDll;
using ItemFurniture;
using UnityEngine;

namespace SaveData
{
	// Token: 0x02000ECE RID: 3790
	[Token(Token = "0x20009B2")]
	public class RF5FurnitureData : SaveDataValueBase
	{
		// Token: 0x06006307 RID: 25351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600521A")]
		[Address(RVA = "0x1F003E0", Offset = "0x1F004E1", VA = "0x1F003E0")]
		public void OnPutSave(string guid, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x00021360 File Offset: 0x0001F560
		[Token(Token = "0x600521B")]
		[Address(RVA = "0x1F005E0", Offset = "0x1F006E1", VA = "0x1F005E0")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x00021378 File Offset: 0x0001F578
		[Token(Token = "0x600521C")]
		[Address(RVA = "0x1F006F0", Offset = "0x1F007F1", VA = "0x1F006F0")]
		public int EmptyCount()
		{
			return 0;
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x00021390 File Offset: 0x0001F590
		[Token(Token = "0x600521D")]
		[Address(RVA = "0x1F00800", Offset = "0x1F00901", VA = "0x1F00800")]
		public int ReserveCount()
		{
			return 0;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600521E")]
		[Address(RVA = "0x1F00910", Offset = "0x1F00A11", VA = "0x1F00910")]
		public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = false)
		{
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x000213A8 File Offset: 0x0001F5A8
		[Token(Token = "0x600521F")]
		[Address(RVA = "0x1F00B40", Offset = "0x1F00C41", VA = "0x1F00B40")]
		public bool IsMax()
		{
			return default(bool);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x000213C0 File Offset: 0x0001F5C0
		[Token(Token = "0x6005220")]
		[Address(RVA = "0x1F00C50", Offset = "0x1F00D51", VA = "0x1F00C50")]
		public bool IsCreate(FurnitureCreatePoint point)
		{
			return default(bool);
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005221")]
		[Address(RVA = "0x1F00D90", Offset = "0x1F00E91", VA = "0x1F00D90")]
		public void HaveSaveData(string guid)
		{
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x000213D8 File Offset: 0x0001F5D8
		[Token(Token = "0x6005222")]
		[Address(RVA = "0x1F00EC0", Offset = "0x1F00FC1", VA = "0x1F00EC0")]
		public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot)
		{
			return default(bool);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005223")]
		[Address(RVA = "0x1F010C0", Offset = "0x1F011C1", VA = "0x1F010C0")]
		public void RemoveSave(string guid)
		{
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x000213F0 File Offset: 0x0001F5F0
		[Token(Token = "0x6005224")]
		[Address(RVA = "0x1F01210", Offset = "0x1F01311", VA = "0x1F01210")]
		public int GetFurnitureCount(FurnitureID furnitureId)
		{
			return 0;
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x00021408 File Offset: 0x0001F608
		[Token(Token = "0x6005225")]
		[Address(RVA = "0x1F01330", Offset = "0x1F01431", VA = "0x1F01330")]
		public bool CheckHadFurniture(FurnitureID id)
		{
			return default(bool);
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005226")]
		[Address(RVA = "0x1F01450", Offset = "0x1F01551", VA = "0x1F01450")]
		public void AllBreak()
		{
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x00021420 File Offset: 0x0001F620
		[Token(Token = "0x6005227")]
		[Address(RVA = "0x1F01540", Offset = "0x1F01641", VA = "0x1F01540")]
		public bool IsBreak()
		{
			return default(bool);
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005228")]
		[Address(RVA = "0x1F01680", Offset = "0x1F01781", VA = "0x1F01680")]
		public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId)
		{
			return null;
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005229")]
		[Address(RVA = "0x1F01760", Offset = "0x1F01861", VA = "0x1F01760")]
		public RF5FurnitureData()
		{
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522A")]
		[Address(RVA = "0x1F01790", Offset = "0x1F01891", VA = "0x1F01790", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522B")]
		[Address(RVA = "0x1F018B0", Offset = "0x1F019B1", VA = "0x1F018B0", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522C")]
		[Address(RVA = "0x1F018C0", Offset = "0x1F019C1", VA = "0x1F018C0", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522D")]
		[Address(RVA = "0x1F018D0", Offset = "0x1F019D1", VA = "0x1F018D0", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600522E")]
		[Address(RVA = "0x1F01B70", Offset = "0x1F01C71", VA = "0x1F01B70")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C2F4 RID: 49908
		[Token(Token = "0x4009217")]
		private const int FURNITURE_MAX = 90;

		// Token: 0x0400C2F5 RID: 49909
		[Token(Token = "0x4009218")]
		private const int FURNITURE_EMPTY2_MAX = 30;

		// Token: 0x0400C2F6 RID: 49910
		[Token(Token = "0x4009219")]
		[FieldOffset(Offset = "0x10")]
		public List<FurnitureSaveData> FurnitureSaveData;

		// Token: 0x02000ECF RID: 3791
		[Token(Token = "0x2001488")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AE0", Offset = "0x159BE1")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600631C RID: 25372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B9C")]
			[Address(RVA = "0x1F01750", Offset = "0x1F01851", VA = "0x1F01750")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x0600631D RID: 25373 RVA: 0x00021438 File Offset: 0x0001F638
			[Token(Token = "0x6007B9D")]
			[Address(RVA = "0x1F01E00", Offset = "0x1F01F01", VA = "0x1F01E00")]
			internal bool <GetFurnitureSaveDataList>b__0(FurnitureSaveData dat)
			{
				return default(bool);
			}

			// Token: 0x0400C2F7 RID: 49911
			[Token(Token = "0x401BCE9")]
			[FieldOffset(Offset = "0x10")]
			public FieldSceneId fieldSceneId;
		}
	}
}
