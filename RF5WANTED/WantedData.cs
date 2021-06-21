using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

namespace RF5WANTED
{
	// Token: 0x02000E7F RID: 3711
	[Token(Token = "0x2000982")]
	public class WantedData
	{
		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x00020940 File Offset: 0x0001EB40
		// (set) Token: 0x06006126 RID: 24870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EA")]
		public WantedID WantedID
		{
			[Token(Token = "0x6005069")]
			[Address(RVA = "0x1F34410", Offset = "0x1F34511", VA = "0x1F34410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC770", Offset = "0x1AC871")]
			get
			{
				return WantedID.Forest1;
			}
			[Token(Token = "0x600506A")]
			[Address(RVA = "0x1F34420", Offset = "0x1F34521", VA = "0x1F34420")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC780", Offset = "0x1AC881")]
			private set
			{
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06006127 RID: 24871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006128 RID: 24872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EB")]
		public WantedDataTable.Data Data
		{
			[Token(Token = "0x600506B")]
			[Address(RVA = "0x1F34430", Offset = "0x1F34531", VA = "0x1F34430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC790", Offset = "0x1AC891")]
			get
			{
				return null;
			}
			[Token(Token = "0x600506C")]
			[Address(RVA = "0x1F34440", Offset = "0x1F34541", VA = "0x1F34440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7A0", Offset = "0x1AC8A1")]
			private set
			{
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EC")]
		public WantedDataTable.Reward Reward
		{
			[Token(Token = "0x600506D")]
			[Address(RVA = "0x1F34450", Offset = "0x1F34551", VA = "0x1F34450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7B0", Offset = "0x1AC8B1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600506E")]
			[Address(RVA = "0x1F34460", Offset = "0x1F34561", VA = "0x1F34460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7C0", Offset = "0x1AC8C1")]
			private set
			{
			}
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506F")]
		[Address(RVA = "0x1F34470", Offset = "0x1F34571", VA = "0x1F34470")]
		public WantedData(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id)
		{
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x1F34500", Offset = "0x1F34601", VA = "0x1F34500")]
		public void Init(WantedDataTable.Data _wantedData, WantedDataTable.Reward _rewardData, WantedID id)
		{
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00020958 File Offset: 0x0001EB58
		[Token(Token = "0x6005071")]
		[Address(RVA = "0x1F34570", Offset = "0x1F34671", VA = "0x1F34570")]
		public bool CheckShowFinished()
		{
			return default(bool);
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x00020970 File Offset: 0x0001EB70
		[Token(Token = "0x6005072")]
		[Address(RVA = "0x1F34630", Offset = "0x1F34731", VA = "0x1F34630")]
		public bool CheckCanAccept()
		{
			return default(bool);
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005073")]
		[Address(RVA = "0x1F34700", Offset = "0x1F34801", VA = "0x1F34700")]
		private void GetCompleted(ref int completed, ref int max)
		{
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00020988 File Offset: 0x0001EB88
		[Token(Token = "0x6005074")]
		[Address(RVA = "0x1F34920", Offset = "0x1F34A21", VA = "0x1F34920")]
		public bool isCompleted()
		{
			return default(bool);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005075")]
		[Address(RVA = "0x1F34960", Offset = "0x1F34A61", VA = "0x1F34960")]
		public string CompletedStr()
		{
			return null;
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x1F34A10", Offset = "0x1F34B11", VA = "0x1F34A10")]
		public string GroupStr()
		{
			return null;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x1F34CC0", Offset = "0x1F34DC1", VA = "0x1F34CC0")]
		public string AcceptStr()
		{
			return null;
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x1F35170", Offset = "0x1F35271", VA = "0x1F35170")]
		public string RewardStr()
		{
			return null;
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x1F35380", Offset = "0x1F35481", VA = "0x1F35380")]
		public void Accept()
		{
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x1F35450", Offset = "0x1F35551", VA = "0x1F35450")]
		public static void MonsterDestroyFailCheck()
		{
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x1F354A0", Offset = "0x1F355A1", VA = "0x1F354A0")]
		public static void Cancel()
		{
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[Token(Token = "0x600507C")]
		[Address(RVA = "0x1F354F0", Offset = "0x1F355F1", VA = "0x1F354F0")]
		public static bool UpdateData()
		{
			return default(bool);
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x1F35680", Offset = "0x1F35781", VA = "0x1F35680")]
		public static WantedData GetAcceptedData()
		{
			return null;
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x000209B8 File Offset: 0x0001EBB8
		[Token(Token = "0x170009ED")]
		public static bool isAccepted
		{
			[Token(Token = "0x600507E")]
			[Address(RVA = "0x1F35FC0", Offset = "0x1F360C1", VA = "0x1F35FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600613B RID: 24891 RVA: 0x000209D0 File Offset: 0x0001EBD0
		[Token(Token = "0x170009EE")]
		public static bool isFinished
		{
			[Token(Token = "0x600507F")]
			[Address(RVA = "0x1F35FF0", Offset = "0x1F360F1", VA = "0x1F35FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005080")]
		[Address(RVA = "0x1F36020", Offset = "0x1F36121", VA = "0x1F36020")]
		public static string GetUITargetMonsterText()
		{
			return null;
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x1F34F00", Offset = "0x1F35001", VA = "0x1F34F00")]
		private static string GetUIPlaceText(WantedFieldType wantedFieldType, int fieldId)
		{
			return null;
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005082")]
		[Address(RVA = "0x1F36150", Offset = "0x1F36251", VA = "0x1F36150")]
		public static string GetUITargetPlaceText()
		{
			return null;
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x1F361D0", Offset = "0x1F362D1", VA = "0x1F361D0")]
		public static string GetAdvTargetPlaceText()
		{
			return null;
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x1F36450", Offset = "0x1F36551", VA = "0x1F36450")]
		public static void DoFinish(MonsterControllerBase monsterController)
		{
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x1F36680", Offset = "0x1F36781", VA = "0x1F36680")]
		public static bool CheckMonster(MonsterDataID monsterDataID)
		{
			return default(bool);
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x00020A00 File Offset: 0x0001EC00
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x1F36740", Offset = "0x1F36841", VA = "0x1F36740")]
		public static bool CheckFinished()
		{
			return default(bool);
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x1F36810", Offset = "0x1F36911", VA = "0x1F36810")]
		public static void UnlockBatch(PoliceBatchId id)
		{
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x00020A18 File Offset: 0x0001EC18
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x1F36970", Offset = "0x1F36A71", VA = "0x1F36970")]
		public static bool GetReward()
		{
			return default(bool);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005089")]
		[Address(RVA = "0x1F357C0", Offset = "0x1F358C1", VA = "0x1F357C0")]
		public static List<WantedData> GetDatas(bool RefreshData = false)
		{
			return null;
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x600508A")]
		[Address(RVA = "0x1F37290", Offset = "0x1F37391", VA = "0x1F37290")]
		public static PoliceBatchId DoGetBatch()
		{
			return PoliceBatchId.None;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600508B")]
		[Address(RVA = "0x1F373A0", Offset = "0x1F374A1", VA = "0x1F373A0")]
		public static void CheckNextStep()
		{
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x600508C")]
		[Address(RVA = "0x1F37540", Offset = "0x1F37641", VA = "0x1F37540")]
		private static int GetRewardSeedPointFromRank()
		{
			return 0;
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600508D")]
		[Address(RVA = "0x1F37580", Offset = "0x1F37681", VA = "0x1F37580")]
		public static string GetCompletedRewardText()
		{
			return null;
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x00020A60 File Offset: 0x0001EC60
		[Token(Token = "0x600508E")]
		[Address(RVA = "0x1F37870", Offset = "0x1F37971", VA = "0x1F37870")]
		public static int GetNewBatchIdForScript()
		{
			return 0;
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x00020A78 File Offset: 0x0001EC78
		[Token(Token = "0x600508F")]
		[Address(RVA = "0x1F378E0", Offset = "0x1F379E1", VA = "0x1F378E0")]
		public static bool isRankup()
		{
			return default(bool);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00020A90 File Offset: 0x0001EC90
		[Token(Token = "0x6005090")]
		[Address(RVA = "0x1F37950", Offset = "0x1F37A51", VA = "0x1F37950")]
		public static bool isGetBatch()
		{
			return default(bool);
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005091")]
		[Address(RVA = "0x1F379D0", Offset = "0x1F37AD1", VA = "0x1F379D0")]
		public static void Init()
		{
		}

		// Token: 0x0400C0D9 RID: 49369
		[Token(Token = "0x4009087")]
		[FieldOffset(Offset = "0x10")]
		public int RandomDataNo;

		// Token: 0x0400C0DA RID: 49370
		[Token(Token = "0x4009088")]
		[FieldOffset(Offset = "0x14")]
		public MonsterDataID monsterDataID;

		// Token: 0x0400C0DB RID: 49371
		[Token(Token = "0x4009089")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17EC80", Offset = "0x17ED81")]
		private WantedID <WantedID>k__BackingField;

		// Token: 0x0400C0DC RID: 49372
		[Token(Token = "0x400908A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17EC90", Offset = "0x17ED91")]
		private WantedDataTable.Data <Data>k__BackingField;

		// Token: 0x0400C0DD RID: 49373
		[Token(Token = "0x400908B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17ECA0", Offset = "0x17EDA1")]
		private WantedDataTable.Reward <Reward>k__BackingField;

		// Token: 0x0400C0DE RID: 49374
		[Token(Token = "0x400908C")]
		[FieldOffset(Offset = "0x30")]
		public int FieldId;

		// Token: 0x0400C0DF RID: 49375
		[Token(Token = "0x400908D")]
		[FieldOffset(Offset = "0x34")]
		public WantedFieldType FieldType;

		// Token: 0x0400C0E0 RID: 49376
		[Token(Token = "0x400908E")]
		[FieldOffset(Offset = "0x0")]
		private static bool Completed;

		// Token: 0x0400C0E1 RID: 49377
		[Token(Token = "0x400908F")]
		[FieldOffset(Offset = "0x8")]
		private static List<PoliceBatchId> BatchIdGet;

		// Token: 0x0400C0E2 RID: 49378
		[Token(Token = "0x4009090")]
		[FieldOffset(Offset = "0x10")]
		private static bool RankupReady;

		// Token: 0x0400C0E3 RID: 49379
		[Token(Token = "0x4009091")]
		[FieldOffset(Offset = "0x14")]
		private static int AdvBatchId;

		// Token: 0x0400C0E4 RID: 49380
		[Token(Token = "0x4009092")]
		[FieldOffset(Offset = "0x18")]
		private static List<WantedData> wantedDatas;

		// Token: 0x0400C0E5 RID: 49381
		[Token(Token = "0x4009093")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] BaseScore;

		// Token: 0x02000E80 RID: 3712
		[Token(Token = "0x2001469")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599C0", Offset = "0x159AC1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006150 RID: 24912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B6C")]
			[Address(RVA = "0x1F37CC0", Offset = "0x1F37DC1", VA = "0x1F37CC0")]
			public <>c()
			{
			}

			// Token: 0x06006151 RID: 24913 RVA: 0x00020AA8 File Offset: 0x0001ECA8
			[Token(Token = "0x6007B6D")]
			[Address(RVA = "0x1F37CD0", Offset = "0x1F37DD1", VA = "0x1F37CD0")]
			internal bool <GetAcceptedData>b__35_0(WantedData a)
			{
				return default(bool);
			}

			// Token: 0x0400C0E6 RID: 49382
			[Token(Token = "0x401BC5E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WantedData.<>c <>9;

			// Token: 0x0400C0E7 RID: 49383
			[Token(Token = "0x401BC5F")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<WantedData> <>9__35_0;
		}
	}
}
