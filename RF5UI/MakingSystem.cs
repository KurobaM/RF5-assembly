using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace RF5UI
{
	// Token: 0x02000E92 RID: 3730
	[Token(Token = "0x200098F")]
	public class MakingSystem
	{
		// Token: 0x06006188 RID: 24968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x2184000", Offset = "0x2184101", VA = "0x2184000")]
		public static void InitOnStartGame()
		{
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x21842A0", Offset = "0x21843A1", VA = "0x21842A0")]
		public static void InitOnLoadGame()
		{
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x2184110", Offset = "0x2184211", VA = "0x2184110")]
		private static void UpdateFlag()
		{
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x2184310", Offset = "0x2184411", VA = "0x2184310")]
		public static bool SetFlag(bool value, MakingID makingID)
		{
			return default(bool);
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x217B070", Offset = "0x217B171", VA = "0x217B070")]
		public static bool GetFlag(MakingID makingID)
		{
			return default(bool);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0x2185150", Offset = "0x2185251", VA = "0x2185150")]
		public static void SetLicenseSuccess(MakingID makingID)
		{
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0x2185230", Offset = "0x2185331", VA = "0x2185230")]
		public static void SetLicenseFail()
		{
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x21852B0", Offset = "0x21853B1", VA = "0x21852B0")]
		public static void CheckCalendarDate(MakingID makingID, out int day, out int season)
		{
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x00020C10 File Offset: 0x0001EE10
		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x21854B0", Offset = "0x21855B1", VA = "0x21854B0")]
		public static int CalcMonsterLevel(int monsterLevel)
		{
			return 0;
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x00020C28 File Offset: 0x0001EE28
		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x2185580", Offset = "0x2185681", VA = "0x2185580")]
		public static bool CanUpMonsterLevel()
		{
			return default(bool);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00020C40 File Offset: 0x0001EE40
		[Token(Token = "0x60050CB")]
		[Address(RVA = "0x21855B0", Offset = "0x21856B1", VA = "0x21855B0")]
		public static bool CanDownMonsterLevel()
		{
			return default(bool);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CC")]
		[Address(RVA = "0x21855E0", Offset = "0x21856E1", VA = "0x21855E0")]
		public static void AddMakingEnemyLevelupStage(int add)
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CD")]
		[Address(RVA = "0x2185690", Offset = "0x2185791", VA = "0x2185690")]
		public static void MonsterLevelUp()
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x2185700", Offset = "0x2185801", VA = "0x2185700")]
		public static void MonsterLevelDown()
		{
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x00020C58 File Offset: 0x0001EE58
		[Token(Token = "0x60050CF")]
		[Address(RVA = "0x2184520", Offset = "0x2184621", VA = "0x2184520")]
		private static bool FlagOn(MakingID makingID)
		{
			return default(bool);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Token(Token = "0x60050D0")]
		[Address(RVA = "0x2185770", Offset = "0x2185871", VA = "0x2185770")]
		public static bool CheckIdActive(MakingID makingID)
		{
			return default(bool);
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D1")]
		[Address(RVA = "0x2186620", Offset = "0x2186721", VA = "0x2186620")]
		public static void DoOpenWindow()
		{
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D2")]
		[Address(RVA = "0x21867D0", Offset = "0x21868D1", VA = "0x21867D0")]
		public static void OpenWindow()
		{
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00020C88 File Offset: 0x0001EE88
		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x2186500", Offset = "0x2186601", VA = "0x2186500")]
		public static bool CheckHadFurniture(FurnitureID id)
		{
			return default(bool);
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x2186A60", Offset = "0x2186B61", VA = "0x2186A60")]
		public MakingSystem()
		{
		}

		// Token: 0x0400C133 RID: 49459
		[Token(Token = "0x40090D2")]
		[FieldOffset(Offset = "0x0")]
		public static UIMakingMenu UIMakingMenu;

		// Token: 0x0400C134 RID: 49460
		[Token(Token = "0x40090D3")]
		[FieldOffset(Offset = "0x8")]
		private static bool Inited;

		// Token: 0x0400C135 RID: 49461
		[Token(Token = "0x40090D4")]
		[FieldOffset(Offset = "0x10")]
		private static bool[] Flags;

		// Token: 0x0400C136 RID: 49462
		[Token(Token = "0x40090D5")]
		[FieldOffset(Offset = "0x18")]
		public static int playingCountId;

		// Token: 0x0400C137 RID: 49463
		[Token(Token = "0x40090D6")]
		[FieldOffset(Offset = "0x1C")]
		public static bool isGimmick_D19flag;

		// Token: 0x0400C138 RID: 49464
		[Token(Token = "0x40090D7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Dictionary<MakingID, CalendarDataTable.FestivalId> MakingFesDic;

		// Token: 0x0400C139 RID: 49465
		[Token(Token = "0x40090D8")]
		[FieldOffset(Offset = "0x28")]
		public static UIMakingMenu playingUIMakingMenu;

		// Token: 0x02000E93 RID: 3731
		[Token(Token = "0x200146F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A00", Offset = "0x159B01")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600619E RID: 24990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B77")]
			[Address(RVA = "0x1F26CE0", Offset = "0x1F26DE1", VA = "0x1F26CE0")]
			public <>c()
			{
			}

			// Token: 0x0600619F RID: 24991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B78")]
			[Address(RVA = "0x1F26CF0", Offset = "0x1F26DF1", VA = "0x1F26CF0")]
			internal void <DoOpenWindow>b__23_0()
			{
			}

			// Token: 0x0400C13A RID: 49466
			[Token(Token = "0x401BC6D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MakingSystem.<>c <>9;

			// Token: 0x0400C13B RID: 49467
			[Token(Token = "0x401BC6E")]
			[FieldOffset(Offset = "0x8")]
			public static UnityAction <>9__23_0;
		}
	}
}
