using System;
using System.Collections.Generic;
using BinaryStream;
using Farm;
using Il2CppDummyDll;
using MonsterHut;

namespace SaveData
{
	// Token: 0x02000EC7 RID: 3783
	[Token(Token = "0x20009AF")]
	public class RF5FarmData : SaveDataValueBase
	{
		// Token: 0x060062DD RID: 25309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x1EFDDD0", Offset = "0x1EFDED1", VA = "0x1EFDDD0")]
		public RF5FarmData()
		{
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x1EFDE90", Offset = "0x1EFDF91", VA = "0x1EFDE90", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x1EFF0A0", Offset = "0x1EFF1A1", VA = "0x1EFF0A0")]
		public void InitializeForNewGame()
		{
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x1EFF110", Offset = "0x1EFF211", VA = "0x1EFF110", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x1EFF120", Offset = "0x1EFF221", VA = "0x1EFF120", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005201")]
		[Address(RVA = "0x1EFF240", Offset = "0x1EFF341", VA = "0x1EFF240", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005202")]
		[Address(RVA = "0x1EFF3B0", Offset = "0x1EFF4B1", VA = "0x1EFF3B0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005203")]
		private void _writer<T>(BinaryWriter writer, T data) where T : new()
		{
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005204")]
		private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) where T : new()
		{
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005205")]
		private T _reader<T>(BinaryReader reader) where T : new()
		{
			return null;
		}

		// Token: 0x060062E7 RID: 25319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005206")]
		private T[] _reader_array<T>(BinaryReader reader) where T : new()
		{
			return null;
		}

		// Token: 0x0400C2DF RID: 49887
		[Token(Token = "0x400920A")]
		[FieldOffset(Offset = "0x10")]
		public bool[] FirstVisitFarm;

		// Token: 0x0400C2E0 RID: 49888
		[Token(Token = "0x400920B")]
		[FieldOffset(Offset = "0x18")]
		public int[] FarmSizeLevels;

		// Token: 0x0400C2E1 RID: 49889
		[Token(Token = "0x400920C")]
		[FieldOffset(Offset = "0x20")]
		public FarmCropData[] FarmCropDatas;

		// Token: 0x0400C2E2 RID: 49890
		[Token(Token = "0x400920D")]
		[FieldOffset(Offset = "0x28")]
		public int[] CrystalUseCounts;

		// Token: 0x0400C2E3 RID: 49891
		[Token(Token = "0x400920E")]
		[FieldOffset(Offset = "0x30")]
		public FarmManager.RF4_CROP_STATE[] Crop;

		// Token: 0x0400C2E4 RID: 49892
		[Token(Token = "0x400920F")]
		[FieldOffset(Offset = "0x38")]
		public FarmManager.RF4_SOIL_INFO[] Soil;

		// Token: 0x0400C2E5 RID: 49893
		[Token(Token = "0x4009210")]
		[FieldOffset(Offset = "0x40")]
		public int[] HarvestCount;

		// Token: 0x0400C2E6 RID: 49894
		[Token(Token = "0x4009211")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemID> ItemHarvestIdList;

		// Token: 0x0400C2E7 RID: 49895
		[Token(Token = "0x4009212")]
		[FieldOffset(Offset = "0x50")]
		public bool[] MonsterHutReleaseFlags;

		// Token: 0x0400C2E8 RID: 49896
		[Token(Token = "0x4009213")]
		[FieldOffset(Offset = "0x58")]
		public MonsterHutSaveData[] MonsterHutSaveDatas;

		// Token: 0x02000EC8 RID: 3784
		[Token(Token = "0x2001484")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159AA0", Offset = "0x159BA1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060062E9 RID: 25321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B91")]
			[Address(RVA = "0x1EFF5F0", Offset = "0x1EFF6F1", VA = "0x1EFF5F0")]
			public <>c()
			{
			}

			// Token: 0x060062EA RID: 25322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B92")]
			[Address(RVA = "0x1EFF600", Offset = "0x1EFF701", VA = "0x1EFF600")]
			internal IEnumerable<FarmManager.RF4_CROP_STATE> <Initialize>b__11_0(FarmManager.RF4_CROP_STATE[] x)
			{
				return null;
			}

			// Token: 0x060062EB RID: 25323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B93")]
			[Address(RVA = "0x1EFF610", Offset = "0x1EFF711", VA = "0x1EFF610")]
			internal IEnumerable<FarmManager.RF4_SOIL_INFO> <Initialize>b__11_1(FarmManager.RF4_SOIL_INFO[] x)
			{
				return null;
			}

			// Token: 0x060062EC RID: 25324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B94")]
			[Address(RVA = "0x1EFF620", Offset = "0x1EFF721", VA = "0x1EFF620")]
			internal IEnumerable<int> <Initialize>b__11_2(int[] cnt)
			{
				return null;
			}

			// Token: 0x0400C2E9 RID: 49897
			[Token(Token = "0x401BCE1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RF5FarmData.<>c <>9;

			// Token: 0x0400C2EA RID: 49898
			[Token(Token = "0x401BCE2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<FarmManager.RF4_CROP_STATE[], IEnumerable<FarmManager.RF4_CROP_STATE>> <>9__11_0;

			// Token: 0x0400C2EB RID: 49899
			[Token(Token = "0x401BCE3")]
			[FieldOffset(Offset = "0x10")]
			public static Func<FarmManager.RF4_SOIL_INFO[], IEnumerable<FarmManager.RF4_SOIL_INFO>> <>9__11_1;

			// Token: 0x0400C2EC RID: 49900
			[Token(Token = "0x401BCE4")]
			[FieldOffset(Offset = "0x18")]
			public static Func<int[], IEnumerable<int>> <>9__11_2;
		}
	}
}
