using System;
using System.Collections.Generic;
using Farm;
using Il2CppDummyDll;

namespace MonsterHut
{
	// Token: 0x02000F05 RID: 3845
	[Token(Token = "0x20009D6")]
	public class MonsterHutManager : SingletonMonoBehaviour<MonsterHutManager>
	{
		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064D7 RID: 25815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A50")]
		public MonsterHutController activeMonsterHutController
		{
			[Token(Token = "0x60053CD")]
			[Address(RVA = "0x1E64000", Offset = "0x1E64101", VA = "0x1E64000")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACCD0", Offset = "0x1ACDD1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053CE")]
			[Address(RVA = "0x1E64010", Offset = "0x1E64111", VA = "0x1E64010")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACCE0", Offset = "0x1ACDE1")]
			private set
			{
			}
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0x1E64020", Offset = "0x1E64121", VA = "0x1E64020")]
		public void OnAfterGameDataLoad()
		{
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0x1E61250", Offset = "0x1E61351", VA = "0x1E61250")]
		public void SetAccessMonsterHut(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0x1E63F30", Offset = "0x1E64031", VA = "0x1E63F30")]
		public void SetMonsterHutController(MonsterHutController monsterHutController)
		{
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D2")]
		[Address(RVA = "0x1E639E0", Offset = "0x1E63AE1", VA = "0x1E639E0")]
		public void ResetMonsterHutController()
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00021C30 File Offset: 0x0001FE30
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0x1E61CD0", Offset = "0x1E61DD1", VA = "0x1E61CD0")]
		public MonsterHutSaveData GetMonsterHutData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId)
		{
			return default(MonsterHutSaveData);
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x1E64170", Offset = "0x1E64271", VA = "0x1E64170")]
		public void SetMonsterHutData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId, MonsterHutSaveData monsterHutSaveData)
		{
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x1E642F0", Offset = "0x1E643F1", VA = "0x1E642F0")]
		public void SetMonsterHutMonsterData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId, int monsterHutAreaId, FriendMonsterStatusData friendMonsterStatusData)
		{
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D6")]
		[Address(RVA = "0x1E64690", Offset = "0x1E64791", VA = "0x1E64690")]
		public void SetMonsterHutMonsterData(FriendMonsterStatusData friendMonsterStatusData)
		{
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D7")]
		[Address(RVA = "0x1E64B70", Offset = "0x1E64C71", VA = "0x1E64B70")]
		public void ShiftMonsterHutMonsterData(FarmManager.FARM_ID id, int hutPlaceId, int areaId, FriendMonsterStatusData friendMonsterStatusData)
		{
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D8")]
		[Address(RVA = "0x1E64D70", Offset = "0x1E64E71", VA = "0x1E64D70")]
		public void RemoveMonsterHutMonsterData(FriendMonsterStatusData friendMonsterStatusData)
		{
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00021C48 File Offset: 0x0001FE48
		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x1E64FE0", Offset = "0x1E650E1", VA = "0x1E64FE0")]
		public int GetMonsterHutEmptyCountTotal()
		{
			return 0;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00021C60 File Offset: 0x0001FE60
		[Token(Token = "0x60053DA")]
		[Address(RVA = "0x1E64A20", Offset = "0x1E64B21", VA = "0x1E64A20")]
		public int GetMonsterHutEmptyCount(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
			return 0;
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00021C78 File Offset: 0x0001FE78
		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x1E64520", Offset = "0x1E64621", VA = "0x1E64520")]
		public int GetMonsterHutAreaEmptyCount(FarmManager.FARM_ID farmId, int monsterHutPlaceId, int areaId)
		{
			return 0;
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00021C90 File Offset: 0x0001FE90
		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x1E64660", Offset = "0x1E64761", VA = "0x1E64660")]
		public bool CheckReleaseMonsterHutArea(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
			return default(bool);
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x1E65140", Offset = "0x1E65241", VA = "0x1E65140")]
		public void AddMonsterHutArea(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		[Token(Token = "0x60053DE")]
		[Address(RVA = "0x1E64630", Offset = "0x1E64731", VA = "0x1E64630")]
		public bool CheckReleaseMonsterHutPlace(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
			return default(bool);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DF")]
		[Address(RVA = "0x1E652B0", Offset = "0x1E653B1", VA = "0x1E652B0")]
		public void ReleaseMonsterHutPlace(FarmManager.FARM_ID farmId, int monsterHutPlaceId)
		{
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x1E627B0", Offset = "0x1E628B1", VA = "0x1E627B0")]
		public void AddYieldItem(int roomId, FriendMonsterStatus friendMonsterStatus)
		{
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x1E65370", Offset = "0x1E65471", VA = "0x1E65370")]
		public void RemoveYieldItem(OnGroundItem onGroundItem)
		{
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x1E65520", Offset = "0x1E65621", VA = "0x1E65520")]
		public void MorningFunc()
		{
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x1E62A70", Offset = "0x1E62B71", VA = "0x1E62A70")]
		public List<int> GetYieldItem(int roomId)
		{
			return null;
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x1E656C0", Offset = "0x1E657C1", VA = "0x1E656C0")]
		private void createDebugDatas()
		{
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E5")]
		[Address(RVA = "0x1E65890", Offset = "0x1E65991", VA = "0x1E65890")]
		public MonsterHutManager()
		{
		}

		// Token: 0x0400C483 RID: 50307
		[Token(Token = "0x400930C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F580", Offset = "0x17F681")]
		private MonsterHutController <activeMonsterHutController>k__BackingField;

		// Token: 0x0400C484 RID: 50308
		[Token(Token = "0x400930D")]
		[FieldOffset(Offset = "0x20")]
		private List<MonsterHutSaveData> _monsterHutSaveDatas;

		// Token: 0x0400C485 RID: 50309
		[Token(Token = "0x400930E")]
		[FieldOffset(Offset = "0x28")]
		private FarmManager.FARM_ID activeFarmId;

		// Token: 0x0400C486 RID: 50310
		[Token(Token = "0x400930F")]
		[FieldOffset(Offset = "0x2C")]
		private int monsterHutPlaceID;

		// Token: 0x02000F06 RID: 3846
		[Token(Token = "0x200149B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B50", Offset = "0x159C51")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x060064EF RID: 25839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BB8")]
			[Address(RVA = "0x1E64160", Offset = "0x1E64261", VA = "0x1E64160")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x060064F0 RID: 25840 RVA: 0x00021CC0 File Offset: 0x0001FEC0
			[Token(Token = "0x6007BB9")]
			[Address(RVA = "0x1E658E0", Offset = "0x1E659E1", VA = "0x1E658E0")]
			internal bool <GetMonsterHutData>b__0(MonsterHutSaveData dat)
			{
				return default(bool);
			}

			// Token: 0x0400C487 RID: 50311
			[Token(Token = "0x401BD83")]
			[FieldOffset(Offset = "0x10")]
			public FarmManager.FARM_ID _farmId;

			// Token: 0x0400C488 RID: 50312
			[Token(Token = "0x401BD84")]
			[FieldOffset(Offset = "0x14")]
			public int monsterHutPlaceId;
		}

		// Token: 0x02000F07 RID: 3847
		[Token(Token = "0x200149C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B60", Offset = "0x159C61")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060064F1 RID: 25841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BBA")]
			[Address(RVA = "0x1E642E0", Offset = "0x1E643E1", VA = "0x1E642E0")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x060064F2 RID: 25842 RVA: 0x00021CD8 File Offset: 0x0001FED8
			[Token(Token = "0x6007BBB")]
			[Address(RVA = "0x1E65910", Offset = "0x1E65A11", VA = "0x1E65910")]
			internal bool <SetMonsterHutData>b__0(MonsterHutSaveData dat)
			{
				return default(bool);
			}

			// Token: 0x0400C489 RID: 50313
			[Token(Token = "0x401BD85")]
			[FieldOffset(Offset = "0x10")]
			public FarmManager.FARM_ID _farmId;

			// Token: 0x0400C48A RID: 50314
			[Token(Token = "0x401BD86")]
			[FieldOffset(Offset = "0x14")]
			public int monsterHutPlaceId;
		}

		// Token: 0x02000F08 RID: 3848
		[Token(Token = "0x200149D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B70", Offset = "0x159C71")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060064F3 RID: 25843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BBC")]
			[Address(RVA = "0x1E64B60", Offset = "0x1E64C61", VA = "0x1E64B60")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x060064F4 RID: 25844 RVA: 0x00021CF0 File Offset: 0x0001FEF0
			[Token(Token = "0x6007BBD")]
			[Address(RVA = "0x1E65940", Offset = "0x1E65A41", VA = "0x1E65940")]
			internal bool <SetMonsterHutMonsterData>b__0(FriendMonsterIDAndHouseID dat)
			{
				return default(bool);
			}

			// Token: 0x0400C48B RID: 50315
			[Token(Token = "0x401BD87")]
			[FieldOffset(Offset = "0x10")]
			public int j;
		}

		// Token: 0x02000F09 RID: 3849
		[Token(Token = "0x200149E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B80", Offset = "0x159C81")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060064F5 RID: 25845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BBE")]
			[Address(RVA = "0x1E65120", Offset = "0x1E65221", VA = "0x1E65120")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x060064F6 RID: 25846 RVA: 0x00021D08 File Offset: 0x0001FF08
			[Token(Token = "0x6007BBF")]
			[Address(RVA = "0x1E65970", Offset = "0x1E65A71", VA = "0x1E65970")]
			internal bool <GetMonsterHutEmptyCount>b__0(FriendMonsterIDAndHouseID dat)
			{
				return default(bool);
			}

			// Token: 0x0400C48C RID: 50316
			[Token(Token = "0x401BD88")]
			[FieldOffset(Offset = "0x10")]
			public int id;
		}

		// Token: 0x02000F0A RID: 3850
		[Token(Token = "0x200149F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B90", Offset = "0x159C91")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x060064F7 RID: 25847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BC0")]
			[Address(RVA = "0x1E65130", Offset = "0x1E65231", VA = "0x1E65130")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x060064F8 RID: 25848 RVA: 0x00021D20 File Offset: 0x0001FF20
			[Token(Token = "0x6007BC1")]
			[Address(RVA = "0x1E659A0", Offset = "0x1E65AA1", VA = "0x1E659A0")]
			internal bool <GetMonsterHutAreaEmptyCount>b__0(FriendMonsterIDAndHouseID dat)
			{
				return default(bool);
			}

			// Token: 0x0400C48D RID: 50317
			[Token(Token = "0x401BD89")]
			[FieldOffset(Offset = "0x10")]
			public int areaId;
		}
	}
}
