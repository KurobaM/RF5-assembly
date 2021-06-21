using System;
using System.Text.RegularExpressions;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine.Events;

// Token: 0x02000930 RID: 2352
[Token(Token = "0x2000626")]
public class TextOverwriteList
{
	// Token: 0x06003D77 RID: 15735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x1F6D900", Offset = "0x1F6DA01", VA = "0x1F6D900")]
	public static string GetDayOfWeekStr(int day)
	{
		return null;
	}

	// Token: 0x06003D78 RID: 15736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033AC")]
	[Address(RVA = "0x1F6DC10", Offset = "0x1F6DD11", VA = "0x1F6DC10")]
	public static string GetMonthText(int Season)
	{
		return null;
	}

	// Token: 0x06003D79 RID: 15737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x1F6DE90", Offset = "0x1F6DF91", VA = "0x1F6DE90")]
	public static string GetMonthText_SeasonOnly(int Season)
	{
		return null;
	}

	// Token: 0x06003D7A RID: 15738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x1F6E110", Offset = "0x1F6E211", VA = "0x1F6E110")]
	public static string GetNumberWideText(string s)
	{
		return null;
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033AF")]
	[Address(RVA = "0x1F6E230", Offset = "0x1F6E331", VA = "0x1F6E230")]
	public static string TransformText(string text, int speakerId = -1)
	{
		return null;
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B0")]
	[Address(RVA = "0x1F6F3D0", Offset = "0x1F6F4D1", VA = "0x1F6F3D0")]
	public static string TransformText_Localize(string text)
	{
		return null;
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x1F6FD20", Offset = "0x1F6FE21", VA = "0x1F6FD20")]
	public static byte[] TransformUnicode(string text)
	{
		return null;
	}

	// Token: 0x06003D7E RID: 15742 RVA: 0x00015480 File Offset: 0x00013680
	[Token(Token = "0x60033B2")]
	[Address(RVA = "0x1F6FD60", Offset = "0x1F6FE61", VA = "0x1F6FD60")]
	public static int TransformToInt(byte[] byteList)
	{
		return 0;
	}

	// Token: 0x06003D7F RID: 15743 RVA: 0x00015498 File Offset: 0x00013698
	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x1F6FA70", Offset = "0x1F6FB71", VA = "0x1F6FA70")]
	public static bool IsPatchim()
	{
		return default(bool);
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x000154B0 File Offset: 0x000136B0
	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x1F6FB40", Offset = "0x1F6FC41", VA = "0x1F6FB40")]
	public static bool IsGender()
	{
		return default(bool);
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B5")]
	[Address(RVA = "0x1F6FDD0", Offset = "0x1F6FED1", VA = "0x1F6FDD0")]
	public string TransformName(string text)
	{
		return null;
	}

	// Token: 0x06003D82 RID: 15746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B6")]
	[Address(RVA = "0x1F6FFE0", Offset = "0x1F700E1", VA = "0x1F6FFE0")]
	public static string GetPlayerName()
	{
		return null;
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B7")]
	[Address(RVA = "0x1F70160", Offset = "0x1F70261", VA = "0x1F70160")]
	public static string Get1stChildName()
	{
		return null;
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x1F701D0", Offset = "0x1F702D1", VA = "0x1F701D0")]
	public static string Get2ndChildName(Gender gender)
	{
		return null;
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x1F70290", Offset = "0x1F70391", VA = "0x1F70290")]
	public static string GetChild1GenderText()
	{
		return null;
	}

	// Token: 0x06003D86 RID: 15750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033BA")]
	[Address(RVA = "0x1F70490", Offset = "0x1F70591", VA = "0x1F70490")]
	public static string GetChildPersonality(int type)
	{
		return null;
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x1F6EF80", Offset = "0x1F6F081", VA = "0x1F6EF80")]
	public static string OverwriteNameDefine(string text)
	{
		return null;
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033BC")]
	[Address(RVA = "0x1F70860", Offset = "0x1F70961", VA = "0x1F70860")]
	public static string GetCharacterName(int npcid, string nameTextID)
	{
		return null;
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x1F6F2A0", Offset = "0x1F6F3A1", VA = "0x1F6F2A0")]
	public static string OverwriteFirstPersonDefine(string text)
	{
		return null;
	}

	// Token: 0x06003D8A RID: 15754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x1F6E5F0", Offset = "0x1F6E6F1", VA = "0x1F6E5F0")]
	private static string OverwriteNickName(string text, int speakerNpcId = -1)
	{
		return null;
	}

	// Token: 0x06003D8B RID: 15755 RVA: 0x000154C8 File Offset: 0x000136C8
	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x1F71190", Offset = "0x1F71291", VA = "0x1F71190")]
	private static int GetCrystalNum(ItemID itemID)
	{
		return 0;
	}

	// Token: 0x06003D8C RID: 15756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x1F71210", Offset = "0x1F71311", VA = "0x1F71210")]
	private static string GetBathMissRank(int blockedNum)
	{
		return null;
	}

	// Token: 0x06003D8D RID: 15757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x1F713B0", Offset = "0x1F714B1", VA = "0x1F713B0")]
	public TextOverwriteList()
	{
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x000154E0 File Offset: 0x000136E0
	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x1F713C0", Offset = "0x1F714C1", VA = "0x1F713C0")]
	private static PlayerCallingNameTextData.Data GetPlayerCallingNameTextData(int id)
	{
		return default(PlayerCallingNameTextData.Data);
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x1F70FA0", Offset = "0x1F710A1", VA = "0x1F70FA0")]
	public static string GetLoverNameTextFromPlayer(int npcId, int nameId)
	{
		return null;
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C4")]
	[Address(RVA = "0x1F70E00", Offset = "0x1F70F01", VA = "0x1F70E00")]
	public static string GetLoverNameTextToPlayer(int npcId, int nameId)
	{
		return null;
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C5")]
	[Address(RVA = "0x1F714F0", Offset = "0x1F715F1", VA = "0x1F714F0")]
	public static string GetLoverNameTextToPlayerForSelector(int npcId, int nameId)
	{
		return null;
	}

	// Token: 0x06003D92 RID: 15762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C6")]
	[Address(RVA = "0x1F710C0", Offset = "0x1F711C1", VA = "0x1F710C0")]
	public static string GetMarriageNameTextFromPlayer(int npcId, int nameId)
	{
		return null;
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x1F70ED0", Offset = "0x1F70FD1", VA = "0x1F70ED0")]
	public static string GetMarriageNameTextToPlayer(int npcId, int nameId)
	{
		return null;
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x000154F8 File Offset: 0x000136F8
	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x1F71640", Offset = "0x1F71741", VA = "0x1F71640")]
	private static NPCCallingNameTextData.Data GetNPCCallingNameTextData(int id)
	{
		return default(NPCCallingNameTextData.Data);
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x1F70D40", Offset = "0x1F70E41", VA = "0x1F70D40")]
	public static string GetNPCCallingNameText(int chId, int targetId)
	{
		return null;
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60033CA")]
	[Address(RVA = "0x1F71760", Offset = "0x1F71861", VA = "0x1F71760")]
	public static void LoadAsset()
	{
	}

	// Token: 0x04007FF7 RID: 32759
	[Token(Token = "0x4007351")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] PlayerNameDefineList;

	// Token: 0x04007FF8 RID: 32760
	[Token(Token = "0x4007352")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] PlayerFirstPersonDefineList;

	// Token: 0x04007FF9 RID: 32761
	[Token(Token = "0x4007353")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string[] ChildNameDefineList;

	// Token: 0x04007FFA RID: 32762
	[Token(Token = "0x4007354")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int[] BathMissRankNumList;

	// Token: 0x04007FFB RID: 32763
	[Token(Token = "0x4007355")]
	[FieldOffset(Offset = "0x20")]
	private static readonly string SpouseNameDefine;

	// Token: 0x04007FFC RID: 32764
	[Token(Token = "0x4007356")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16F160", Offset = "0x16F261")]
	private static readonly ValueTuple<string, Func<string>>[] ReplaceParamList;

	// Token: 0x04007FFD RID: 32765
	[Token(Token = "0x4007357")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16F200", Offset = "0x16F301")]
	private static readonly ValueTuple<string, Func<string>>[] ReplaceButtonList;

	// Token: 0x04007FFE RID: 32766
	[Token(Token = "0x4007358")]
	[FieldOffset(Offset = "0x38")]
	private static readonly string[] ReplaceLocalizeList;

	// Token: 0x04007FFF RID: 32767
	[Token(Token = "0x4007359")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int PatchimBase;

	// Token: 0x04008000 RID: 32768
	[Token(Token = "0x400735A")]
	private const int ChildPersonalityBase = 36;

	// Token: 0x04008001 RID: 32769
	[Token(Token = "0x400735B")]
	public const int NpcCallingNameIDMax = 42;

	// Token: 0x04008002 RID: 32770
	[Token(Token = "0x400735C")]
	[FieldOffset(Offset = "0x44")]
	private static int SpeakerNpcId;

	// Token: 0x04008003 RID: 32771
	[Token(Token = "0x400735D")]
	[FieldOffset(Offset = "0x48")]
	private static PlayerCallingNameTextData playerCallingNameTextData;

	// Token: 0x04008004 RID: 32772
	[Token(Token = "0x400735E")]
	[FieldOffset(Offset = "0x50")]
	private static NPCCallingNameTextData npcCallingNameTextData;

	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x200128C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158E50", Offset = "0x158F51")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003D99 RID: 15769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B1")]
		[Address(RVA = "0x1F779A0", Offset = "0x1F77AA1", VA = "0x1F779A0")]
		public <>c()
		{
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B2")]
		[Address(RVA = "0x1F779B0", Offset = "0x1F77AB1", VA = "0x1F779B0")]
		internal string <GetNumberWideText>b__15_0(Match p)
		{
			return null;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B3")]
		[Address(RVA = "0x1F77A10", Offset = "0x1F77B11", VA = "0x1F77A10")]
		internal void <LoadAsset>b__45_0(AssetHandle<PlayerCallingNameTextData> handle)
		{
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B4")]
		[Address(RVA = "0x1F77AA0", Offset = "0x1F77BA1", VA = "0x1F77AA0")]
		internal void <LoadAsset>b__45_1(AssetHandle<NPCCallingNameTextData> handle)
		{
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B5")]
		[Address(RVA = "0x1F77B30", Offset = "0x1F77C31", VA = "0x1F77B30")]
		internal string <.cctor>b__46_0()
		{
			return null;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B6")]
		[Address(RVA = "0x1F77BB0", Offset = "0x1F77CB1", VA = "0x1F77BB0")]
		internal string <.cctor>b__46_1()
		{
			return null;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0x1F77C20", Offset = "0x1F77D21", VA = "0x1F77C20")]
		internal string <.cctor>b__46_2()
		{
			return null;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B8")]
		[Address(RVA = "0x1F77CA0", Offset = "0x1F77DA1", VA = "0x1F77CA0")]
		internal string <.cctor>b__46_3()
		{
			return null;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B9")]
		[Address(RVA = "0x1F77D20", Offset = "0x1F77E21", VA = "0x1F77D20")]
		internal string <.cctor>b__46_4()
		{
			return null;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BA")]
		[Address(RVA = "0x1F77DA0", Offset = "0x1F77EA1", VA = "0x1F77DA0")]
		internal string <.cctor>b__46_5()
		{
			return null;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BB")]
		[Address(RVA = "0x1F77E00", Offset = "0x1F77F01", VA = "0x1F77E00")]
		internal string <.cctor>b__46_6()
		{
			return null;
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BC")]
		[Address(RVA = "0x1F77E60", Offset = "0x1F77F61", VA = "0x1F77E60")]
		internal string <.cctor>b__46_7()
		{
			return null;
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BD")]
		[Address(RVA = "0x1F77EC0", Offset = "0x1F77FC1", VA = "0x1F77EC0")]
		internal string <.cctor>b__46_8()
		{
			return null;
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BE")]
		[Address(RVA = "0x1F77F30", Offset = "0x1F78031", VA = "0x1F77F30")]
		internal string <.cctor>b__46_9()
		{
			return null;
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BF")]
		[Address(RVA = "0x1F77F90", Offset = "0x1F78091", VA = "0x1F77F90")]
		internal string <.cctor>b__46_10()
		{
			return null;
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C0")]
		[Address(RVA = "0x1F78010", Offset = "0x1F78111", VA = "0x1F78010")]
		internal string <.cctor>b__46_11()
		{
			return null;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C1")]
		[Address(RVA = "0x1F78080", Offset = "0x1F78181", VA = "0x1F78080")]
		internal string <.cctor>b__46_12()
		{
			return null;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C2")]
		[Address(RVA = "0x1F780E0", Offset = "0x1F781E1", VA = "0x1F780E0")]
		internal string <.cctor>b__46_13()
		{
			return null;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C3")]
		[Address(RVA = "0x1F78140", Offset = "0x1F78241", VA = "0x1F78140")]
		internal string <.cctor>b__46_14()
		{
			return null;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C4")]
		[Address(RVA = "0x1F781A0", Offset = "0x1F782A1", VA = "0x1F781A0")]
		internal string <.cctor>b__46_15()
		{
			return null;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C5")]
		[Address(RVA = "0x1F78200", Offset = "0x1F78301", VA = "0x1F78200")]
		internal string <.cctor>b__46_16()
		{
			return null;
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C6")]
		[Address(RVA = "0x1F78240", Offset = "0x1F78341", VA = "0x1F78240")]
		internal string <.cctor>b__46_17()
		{
			return null;
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C7")]
		[Address(RVA = "0x1F78310", Offset = "0x1F78411", VA = "0x1F78310")]
		internal string <.cctor>b__46_18()
		{
			return null;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C8")]
		[Address(RVA = "0x1F78350", Offset = "0x1F78451", VA = "0x1F78350")]
		internal string <.cctor>b__46_19()
		{
			return null;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C9")]
		[Address(RVA = "0x1F78420", Offset = "0x1F78521", VA = "0x1F78420")]
		internal string <.cctor>b__46_20()
		{
			return null;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CA")]
		[Address(RVA = "0x1F784C0", Offset = "0x1F785C1", VA = "0x1F784C0")]
		internal string <.cctor>b__46_21()
		{
			return null;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CB")]
		[Address(RVA = "0x1F78540", Offset = "0x1F78641", VA = "0x1F78540")]
		internal string <.cctor>b__46_22()
		{
			return null;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CC")]
		[Address(RVA = "0x1F785B0", Offset = "0x1F786B1", VA = "0x1F785B0")]
		internal string <.cctor>b__46_23()
		{
			return null;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CD")]
		[Address(RVA = "0x1F78620", Offset = "0x1F78721", VA = "0x1F78620")]
		internal string <.cctor>b__46_24()
		{
			return null;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CE")]
		[Address(RVA = "0x1F78690", Offset = "0x1F78791", VA = "0x1F78690")]
		internal string <.cctor>b__46_25()
		{
			return null;
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074CF")]
		[Address(RVA = "0x1F78700", Offset = "0x1F78801", VA = "0x1F78700")]
		internal string <.cctor>b__46_26()
		{
			return null;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D0")]
		[Address(RVA = "0x1F78770", Offset = "0x1F78871", VA = "0x1F78770")]
		internal string <.cctor>b__46_27()
		{
			return null;
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D1")]
		[Address(RVA = "0x1F787E0", Offset = "0x1F788E1", VA = "0x1F787E0")]
		internal string <.cctor>b__46_28()
		{
			return null;
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D2")]
		[Address(RVA = "0x1F78850", Offset = "0x1F78951", VA = "0x1F78850")]
		internal string <.cctor>b__46_29()
		{
			return null;
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D3")]
		[Address(RVA = "0x1F788C0", Offset = "0x1F789C1", VA = "0x1F788C0")]
		internal string <.cctor>b__46_30()
		{
			return null;
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D4")]
		[Address(RVA = "0x1F78930", Offset = "0x1F78A31", VA = "0x1F78930")]
		internal string <.cctor>b__46_31()
		{
			return null;
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D5")]
		[Address(RVA = "0x1F789B0", Offset = "0x1F78AB1", VA = "0x1F789B0")]
		internal string <.cctor>b__46_32()
		{
			return null;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D6")]
		[Address(RVA = "0x1F78A20", Offset = "0x1F78B21", VA = "0x1F78A20")]
		internal string <.cctor>b__46_33()
		{
			return null;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D7")]
		[Address(RVA = "0x1F78AA0", Offset = "0x1F78BA1", VA = "0x1F78AA0")]
		internal string <.cctor>b__46_34()
		{
			return null;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D8")]
		[Address(RVA = "0x1F78B20", Offset = "0x1F78C21", VA = "0x1F78B20")]
		internal string <.cctor>b__46_35()
		{
			return null;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074D9")]
		[Address(RVA = "0x1F78B90", Offset = "0x1F78C91", VA = "0x1F78B90")]
		internal string <.cctor>b__46_36()
		{
			return null;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DA")]
		[Address(RVA = "0x1F78C00", Offset = "0x1F78D01", VA = "0x1F78C00")]
		internal string <.cctor>b__46_37()
		{
			return null;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DB")]
		[Address(RVA = "0x1F78C70", Offset = "0x1F78D71", VA = "0x1F78C70")]
		internal string <.cctor>b__46_38()
		{
			return null;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DC")]
		[Address(RVA = "0x1F78CE0", Offset = "0x1F78DE1", VA = "0x1F78CE0")]
		internal string <.cctor>b__46_39()
		{
			return null;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DD")]
		[Address(RVA = "0x1F78D60", Offset = "0x1F78E61", VA = "0x1F78D60")]
		internal string <.cctor>b__46_40()
		{
			return null;
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DE")]
		[Address(RVA = "0x1F78DE0", Offset = "0x1F78EE1", VA = "0x1F78DE0")]
		internal string <.cctor>b__46_41()
		{
			return null;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074DF")]
		[Address(RVA = "0x1F78E50", Offset = "0x1F78F51", VA = "0x1F78E50")]
		internal string <.cctor>b__46_42()
		{
			return null;
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E0")]
		[Address(RVA = "0x1F78EC0", Offset = "0x1F78FC1", VA = "0x1F78EC0")]
		internal string <.cctor>b__46_43()
		{
			return null;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E1")]
		[Address(RVA = "0x1F78F30", Offset = "0x1F79031", VA = "0x1F78F30")]
		internal string <.cctor>b__46_44()
		{
			return null;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E2")]
		[Address(RVA = "0x1F78FA0", Offset = "0x1F790A1", VA = "0x1F78FA0")]
		internal string <.cctor>b__46_45()
		{
			return null;
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E3")]
		[Address(RVA = "0x1F79010", Offset = "0x1F79111", VA = "0x1F79010")]
		internal string <.cctor>b__46_46()
		{
			return null;
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x1F79090", Offset = "0x1F79191", VA = "0x1F79090")]
		internal string <.cctor>b__46_47()
		{
			return null;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E5")]
		[Address(RVA = "0x1F790C0", Offset = "0x1F791C1", VA = "0x1F790C0")]
		internal string <.cctor>b__46_48()
		{
			return null;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E6")]
		[Address(RVA = "0x1F79120", Offset = "0x1F79221", VA = "0x1F79120")]
		internal string <.cctor>b__46_49()
		{
			return null;
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x1F79180", Offset = "0x1F79281", VA = "0x1F79180")]
		internal string <.cctor>b__46_50()
		{
			return null;
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E8")]
		[Address(RVA = "0x1F791E0", Offset = "0x1F792E1", VA = "0x1F791E0")]
		internal string <.cctor>b__46_51()
		{
			return null;
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074E9")]
		[Address(RVA = "0x1F79240", Offset = "0x1F79341", VA = "0x1F79240")]
		internal string <.cctor>b__46_52()
		{
			return null;
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074EA")]
		[Address(RVA = "0x1F792A0", Offset = "0x1F793A1", VA = "0x1F792A0")]
		internal string <.cctor>b__46_53()
		{
			return null;
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074EB")]
		[Address(RVA = "0x1F79300", Offset = "0x1F79401", VA = "0x1F79300")]
		internal string <.cctor>b__46_54()
		{
			return null;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074EC")]
		[Address(RVA = "0x1F79360", Offset = "0x1F79461", VA = "0x1F79360")]
		internal string <.cctor>b__46_55()
		{
			return null;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074ED")]
		[Address(RVA = "0x1F793C0", Offset = "0x1F794C1", VA = "0x1F793C0")]
		internal string <.cctor>b__46_56()
		{
			return null;
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074EE")]
		[Address(RVA = "0x1F79420", Offset = "0x1F79521", VA = "0x1F79420")]
		internal string <.cctor>b__46_57()
		{
			return null;
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074EF")]
		[Address(RVA = "0x1F79480", Offset = "0x1F79581", VA = "0x1F79480")]
		internal string <.cctor>b__46_58()
		{
			return null;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F0")]
		[Address(RVA = "0x1F794E0", Offset = "0x1F795E1", VA = "0x1F794E0")]
		internal string <.cctor>b__46_59()
		{
			return null;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F1")]
		[Address(RVA = "0x1F79540", Offset = "0x1F79641", VA = "0x1F79540")]
		internal string <.cctor>b__46_60()
		{
			return null;
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0x1F795A0", Offset = "0x1F796A1", VA = "0x1F795A0")]
		internal string <.cctor>b__46_61()
		{
			return null;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F3")]
		[Address(RVA = "0x1F79600", Offset = "0x1F79701", VA = "0x1F79600")]
		internal string <.cctor>b__46_62()
		{
			return null;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F4")]
		[Address(RVA = "0x1F79670", Offset = "0x1F79771", VA = "0x1F79670")]
		internal string <.cctor>b__46_63()
		{
			return null;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F5")]
		[Address(RVA = "0x1F796F0", Offset = "0x1F797F1", VA = "0x1F796F0")]
		internal string <.cctor>b__46_64()
		{
			return null;
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0x1F79760", Offset = "0x1F79861", VA = "0x1F79760")]
		internal string <.cctor>b__46_65()
		{
			return null;
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F7")]
		[Address(RVA = "0x1F797D0", Offset = "0x1F798D1", VA = "0x1F797D0")]
		internal string <.cctor>b__46_66()
		{
			return null;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F8")]
		[Address(RVA = "0x1F79840", Offset = "0x1F79941", VA = "0x1F79840")]
		internal string <.cctor>b__46_67()
		{
			return null;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F9")]
		[Address(RVA = "0x1F798B0", Offset = "0x1F799B1", VA = "0x1F798B0")]
		internal string <.cctor>b__46_68()
		{
			return null;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FA")]
		[Address(RVA = "0x1F79920", Offset = "0x1F79A21", VA = "0x1F79920")]
		internal string <.cctor>b__46_69()
		{
			return null;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FB")]
		[Address(RVA = "0x1F79990", Offset = "0x1F79A91", VA = "0x1F79990")]
		internal string <.cctor>b__46_70()
		{
			return null;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FC")]
		[Address(RVA = "0x1F79A90", Offset = "0x1F79B91", VA = "0x1F79A90")]
		internal string <.cctor>b__46_71()
		{
			return null;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FD")]
		[Address(RVA = "0x1F79AF0", Offset = "0x1F79BF1", VA = "0x1F79AF0")]
		internal string <.cctor>b__46_72()
		{
			return null;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FE")]
		[Address(RVA = "0x1F79B50", Offset = "0x1F79C51", VA = "0x1F79B50")]
		internal string <.cctor>b__46_73()
		{
			return null;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FF")]
		[Address(RVA = "0x1F79BB0", Offset = "0x1F79CB1", VA = "0x1F79BB0")]
		internal string <.cctor>b__46_74()
		{
			return null;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007500")]
		[Address(RVA = "0x1F79C10", Offset = "0x1F79D11", VA = "0x1F79C10")]
		internal string <.cctor>b__46_75()
		{
			return null;
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007501")]
		[Address(RVA = "0x1F79C70", Offset = "0x1F79D71", VA = "0x1F79C70")]
		internal string <.cctor>b__46_76()
		{
			return null;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007502")]
		[Address(RVA = "0x1F79CD0", Offset = "0x1F79DD1", VA = "0x1F79CD0")]
		internal string <.cctor>b__46_77()
		{
			return null;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007503")]
		[Address(RVA = "0x1F79CE0", Offset = "0x1F79DE1", VA = "0x1F79CE0")]
		internal string <.cctor>b__46_78()
		{
			return null;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007504")]
		[Address(RVA = "0x1F79D50", Offset = "0x1F79E51", VA = "0x1F79D50")]
		internal string <.cctor>b__46_79()
		{
			return null;
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007505")]
		[Address(RVA = "0x1F79DC0", Offset = "0x1F79EC1", VA = "0x1F79DC0")]
		internal string <.cctor>b__46_80()
		{
			return null;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007506")]
		[Address(RVA = "0x1F79E30", Offset = "0x1F79F31", VA = "0x1F79E30")]
		internal string <.cctor>b__46_81()
		{
			return null;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007507")]
		[Address(RVA = "0x1F79EA0", Offset = "0x1F79FA1", VA = "0x1F79EA0")]
		internal string <.cctor>b__46_82()
		{
			return null;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007508")]
		[Address(RVA = "0x1F79F10", Offset = "0x1F7A011", VA = "0x1F79F10")]
		internal string <.cctor>b__46_83()
		{
			return null;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007509")]
		[Address(RVA = "0x1F79F80", Offset = "0x1F7A081", VA = "0x1F79F80")]
		internal string <.cctor>b__46_84()
		{
			return null;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750A")]
		[Address(RVA = "0x1F79FF0", Offset = "0x1F7A0F1", VA = "0x1F79FF0")]
		internal string <.cctor>b__46_85()
		{
			return null;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750B")]
		[Address(RVA = "0x1F7A060", Offset = "0x1F7A161", VA = "0x1F7A060")]
		internal string <.cctor>b__46_86()
		{
			return null;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750C")]
		[Address(RVA = "0x1F7A0D0", Offset = "0x1F7A1D1", VA = "0x1F7A0D0")]
		internal string <.cctor>b__46_87()
		{
			return null;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750D")]
		[Address(RVA = "0x1F7A140", Offset = "0x1F7A241", VA = "0x1F7A140")]
		internal string <.cctor>b__46_88()
		{
			return null;
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750E")]
		[Address(RVA = "0x1F7A1B0", Offset = "0x1F7A2B1", VA = "0x1F7A1B0")]
		internal string <.cctor>b__46_89()
		{
			return null;
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750F")]
		[Address(RVA = "0x1F7A220", Offset = "0x1F7A321", VA = "0x1F7A220")]
		internal string <.cctor>b__46_90()
		{
			return null;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007510")]
		[Address(RVA = "0x1F7A290", Offset = "0x1F7A391", VA = "0x1F7A290")]
		internal string <.cctor>b__46_91()
		{
			return null;
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007511")]
		[Address(RVA = "0x1F7A300", Offset = "0x1F7A401", VA = "0x1F7A300")]
		internal string <.cctor>b__46_92()
		{
			return null;
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007512")]
		[Address(RVA = "0x1F7A370", Offset = "0x1F7A471", VA = "0x1F7A370")]
		internal string <.cctor>b__46_93()
		{
			return null;
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007513")]
		[Address(RVA = "0x1F7A3E0", Offset = "0x1F7A4E1", VA = "0x1F7A3E0")]
		internal string <.cctor>b__46_94()
		{
			return null;
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007514")]
		[Address(RVA = "0x1F7A450", Offset = "0x1F7A551", VA = "0x1F7A450")]
		internal string <.cctor>b__46_95()
		{
			return null;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007515")]
		[Address(RVA = "0x1F7A4C0", Offset = "0x1F7A5C1", VA = "0x1F7A4C0")]
		internal string <.cctor>b__46_96()
		{
			return null;
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007516")]
		[Address(RVA = "0x1F7A530", Offset = "0x1F7A631", VA = "0x1F7A530")]
		internal string <.cctor>b__46_97()
		{
			return null;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007517")]
		[Address(RVA = "0x1F7A5A0", Offset = "0x1F7A6A1", VA = "0x1F7A5A0")]
		internal string <.cctor>b__46_98()
		{
			return null;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007518")]
		[Address(RVA = "0x1F7A610", Offset = "0x1F7A711", VA = "0x1F7A610")]
		internal string <.cctor>b__46_99()
		{
			return null;
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007519")]
		[Address(RVA = "0x1F7A680", Offset = "0x1F7A781", VA = "0x1F7A680")]
		internal string <.cctor>b__46_100()
		{
			return null;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751A")]
		[Address(RVA = "0x1F7A6F0", Offset = "0x1F7A7F1", VA = "0x1F7A6F0")]
		internal string <.cctor>b__46_101()
		{
			return null;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751B")]
		[Address(RVA = "0x1F7A760", Offset = "0x1F7A861", VA = "0x1F7A760")]
		internal string <.cctor>b__46_102()
		{
			return null;
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751C")]
		[Address(RVA = "0x1F7A7D0", Offset = "0x1F7A8D1", VA = "0x1F7A7D0")]
		internal string <.cctor>b__46_103()
		{
			return null;
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751D")]
		[Address(RVA = "0x1F7A840", Offset = "0x1F7A941", VA = "0x1F7A840")]
		internal string <.cctor>b__46_104()
		{
			return null;
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751E")]
		[Address(RVA = "0x1F7A8C0", Offset = "0x1F7A9C1", VA = "0x1F7A8C0")]
		internal string <.cctor>b__46_105()
		{
			return null;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751F")]
		[Address(RVA = "0x1F7A940", Offset = "0x1F7AA41", VA = "0x1F7A940")]
		internal string <.cctor>b__46_106()
		{
			return null;
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007520")]
		[Address(RVA = "0x1F7A9C0", Offset = "0x1F7AAC1", VA = "0x1F7A9C0")]
		internal string <.cctor>b__46_107()
		{
			return null;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007521")]
		[Address(RVA = "0x1F7AA40", Offset = "0x1F7AB41", VA = "0x1F7AA40")]
		internal string <.cctor>b__46_108()
		{
			return null;
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007522")]
		[Address(RVA = "0x1F7AAC0", Offset = "0x1F7ABC1", VA = "0x1F7AAC0")]
		internal string <.cctor>b__46_109()
		{
			return null;
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007523")]
		[Address(RVA = "0x1F7AB40", Offset = "0x1F7AC41", VA = "0x1F7AB40")]
		internal string <.cctor>b__46_110()
		{
			return null;
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007524")]
		[Address(RVA = "0x1F7ABC0", Offset = "0x1F7ACC1", VA = "0x1F7ABC0")]
		internal string <.cctor>b__46_111()
		{
			return null;
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007525")]
		[Address(RVA = "0x1F7AC40", Offset = "0x1F7AD41", VA = "0x1F7AC40")]
		internal string <.cctor>b__46_112()
		{
			return null;
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007526")]
		[Address(RVA = "0x1F7ACC0", Offset = "0x1F7ADC1", VA = "0x1F7ACC0")]
		internal string <.cctor>b__46_113()
		{
			return null;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007527")]
		[Address(RVA = "0x1F7AD40", Offset = "0x1F7AE41", VA = "0x1F7AD40")]
		internal string <.cctor>b__46_114()
		{
			return null;
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007528")]
		[Address(RVA = "0x1F7ADC0", Offset = "0x1F7AEC1", VA = "0x1F7ADC0")]
		internal string <.cctor>b__46_115()
		{
			return null;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007529")]
		[Address(RVA = "0x1F7AE40", Offset = "0x1F7AF41", VA = "0x1F7AE40")]
		internal string <.cctor>b__46_116()
		{
			return null;
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752A")]
		[Address(RVA = "0x1F7AEC0", Offset = "0x1F7AFC1", VA = "0x1F7AEC0")]
		internal string <.cctor>b__46_117()
		{
			return null;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752B")]
		[Address(RVA = "0x1F7AF40", Offset = "0x1F7B041", VA = "0x1F7AF40")]
		internal string <.cctor>b__46_118()
		{
			return null;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752C")]
		[Address(RVA = "0x1F7AFC0", Offset = "0x1F7B0C1", VA = "0x1F7AFC0")]
		internal string <.cctor>b__46_119()
		{
			return null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752D")]
		[Address(RVA = "0x1F7B040", Offset = "0x1F7B141", VA = "0x1F7B040")]
		internal string <.cctor>b__46_120()
		{
			return null;
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752E")]
		[Address(RVA = "0x1F7B0C0", Offset = "0x1F7B1C1", VA = "0x1F7B0C0")]
		internal string <.cctor>b__46_121()
		{
			return null;
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752F")]
		[Address(RVA = "0x1F7B140", Offset = "0x1F7B241", VA = "0x1F7B140")]
		internal string <.cctor>b__46_122()
		{
			return null;
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007530")]
		[Address(RVA = "0x1F7B1C0", Offset = "0x1F7B2C1", VA = "0x1F7B1C0")]
		internal string <.cctor>b__46_123()
		{
			return null;
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007531")]
		[Address(RVA = "0x1F7B240", Offset = "0x1F7B341", VA = "0x1F7B240")]
		internal string <.cctor>b__46_124()
		{
			return null;
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007532")]
		[Address(RVA = "0x1F7B2C0", Offset = "0x1F7B3C1", VA = "0x1F7B2C0")]
		internal string <.cctor>b__46_125()
		{
			return null;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007533")]
		[Address(RVA = "0x1F7B340", Offset = "0x1F7B441", VA = "0x1F7B340")]
		internal string <.cctor>b__46_126()
		{
			return null;
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007534")]
		[Address(RVA = "0x1F7B3C0", Offset = "0x1F7B4C1", VA = "0x1F7B3C0")]
		internal string <.cctor>b__46_127()
		{
			return null;
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007535")]
		[Address(RVA = "0x1F7B440", Offset = "0x1F7B541", VA = "0x1F7B440")]
		internal string <.cctor>b__46_128()
		{
			return null;
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007536")]
		[Address(RVA = "0x1F7B4C0", Offset = "0x1F7B5C1", VA = "0x1F7B4C0")]
		internal string <.cctor>b__46_129()
		{
			return null;
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007537")]
		[Address(RVA = "0x1F7B540", Offset = "0x1F7B641", VA = "0x1F7B540")]
		internal string <.cctor>b__46_130()
		{
			return null;
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007538")]
		[Address(RVA = "0x1F7B5C0", Offset = "0x1F7B6C1", VA = "0x1F7B5C0")]
		internal string <.cctor>b__46_131()
		{
			return null;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007539")]
		[Address(RVA = "0x1F7B640", Offset = "0x1F7B741", VA = "0x1F7B640")]
		internal string <.cctor>b__46_132()
		{
			return null;
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753A")]
		[Address(RVA = "0x1F7B6C0", Offset = "0x1F7B7C1", VA = "0x1F7B6C0")]
		internal string <.cctor>b__46_133()
		{
			return null;
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753B")]
		[Address(RVA = "0x1F7B740", Offset = "0x1F7B841", VA = "0x1F7B740")]
		internal string <.cctor>b__46_134()
		{
			return null;
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753C")]
		[Address(RVA = "0x1F7B7C0", Offset = "0x1F7B8C1", VA = "0x1F7B7C0")]
		internal string <.cctor>b__46_135()
		{
			return null;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753D")]
		[Address(RVA = "0x1F7B840", Offset = "0x1F7B941", VA = "0x1F7B840")]
		internal string <.cctor>b__46_136()
		{
			return null;
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753E")]
		[Address(RVA = "0x1F7B8B0", Offset = "0x1F7B9B1", VA = "0x1F7B8B0")]
		internal string <.cctor>b__46_137()
		{
			return null;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600753F")]
		[Address(RVA = "0x1F7B920", Offset = "0x1F7BA21", VA = "0x1F7B920")]
		internal string <.cctor>b__46_138()
		{
			return null;
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007540")]
		[Address(RVA = "0x1F7B9A0", Offset = "0x1F7BAA1", VA = "0x1F7B9A0")]
		internal string <.cctor>b__46_139()
		{
			return null;
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007541")]
		[Address(RVA = "0x1F7BA20", Offset = "0x1F7BB21", VA = "0x1F7BA20")]
		internal string <.cctor>b__46_140()
		{
			return null;
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007542")]
		[Address(RVA = "0x1F7BAA0", Offset = "0x1F7BBA1", VA = "0x1F7BAA0")]
		internal string <.cctor>b__46_141()
		{
			return null;
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007543")]
		[Address(RVA = "0x1F7BB20", Offset = "0x1F7BC21", VA = "0x1F7BB20")]
		internal string <.cctor>b__46_142()
		{
			return null;
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007544")]
		[Address(RVA = "0x1F7BB50", Offset = "0x1F7BC51", VA = "0x1F7BB50")]
		internal string <.cctor>b__46_143()
		{
			return null;
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007545")]
		[Address(RVA = "0x1F7BBC0", Offset = "0x1F7BCC1", VA = "0x1F7BBC0")]
		internal string <.cctor>b__46_144()
		{
			return null;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007546")]
		[Address(RVA = "0x1F7BC30", Offset = "0x1F7BD31", VA = "0x1F7BC30")]
		internal string <.cctor>b__46_145()
		{
			return null;
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007547")]
		[Address(RVA = "0x1F7BCA0", Offset = "0x1F7BDA1", VA = "0x1F7BCA0")]
		internal string <.cctor>b__46_146()
		{
			return null;
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007548")]
		[Address(RVA = "0x1F7BD10", Offset = "0x1F7BE11", VA = "0x1F7BD10")]
		internal string <.cctor>b__46_147()
		{
			return null;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007549")]
		[Address(RVA = "0x1F7BD80", Offset = "0x1F7BE81", VA = "0x1F7BD80")]
		internal string <.cctor>b__46_148()
		{
			return null;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754A")]
		[Address(RVA = "0x1F7BE70", Offset = "0x1F7BF71", VA = "0x1F7BE70")]
		internal string <.cctor>b__46_149()
		{
			return null;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754B")]
		[Address(RVA = "0x1F7BF60", Offset = "0x1F7C061", VA = "0x1F7BF60")]
		internal string <.cctor>b__46_150()
		{
			return null;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754C")]
		[Address(RVA = "0x1F7C050", Offset = "0x1F7C151", VA = "0x1F7C050")]
		internal string <.cctor>b__46_151()
		{
			return null;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754D")]
		[Address(RVA = "0x1F7C140", Offset = "0x1F7C241", VA = "0x1F7C140")]
		internal string <.cctor>b__46_152()
		{
			return null;
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754E")]
		[Address(RVA = "0x1F7C230", Offset = "0x1F7C331", VA = "0x1F7C230")]
		internal string <.cctor>b__46_153()
		{
			return null;
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754F")]
		[Address(RVA = "0x1F7C2B0", Offset = "0x1F7C3B1", VA = "0x1F7C2B0")]
		internal string <.cctor>b__46_154()
		{
			return null;
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007550")]
		[Address(RVA = "0x1F7C330", Offset = "0x1F7C431", VA = "0x1F7C330")]
		internal string <.cctor>b__46_155()
		{
			return null;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007551")]
		[Address(RVA = "0x1F7C3B0", Offset = "0x1F7C4B1", VA = "0x1F7C3B0")]
		internal string <.cctor>b__46_156()
		{
			return null;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007552")]
		[Address(RVA = "0x1F7C430", Offset = "0x1F7C531", VA = "0x1F7C430")]
		internal string <.cctor>b__46_157()
		{
			return null;
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007553")]
		[Address(RVA = "0x1F7C4B0", Offset = "0x1F7C5B1", VA = "0x1F7C4B0")]
		internal string <.cctor>b__46_158()
		{
			return null;
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007554")]
		[Address(RVA = "0x1F7C500", Offset = "0x1F7C601", VA = "0x1F7C500")]
		internal string <.cctor>b__46_159()
		{
			return null;
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007555")]
		[Address(RVA = "0x1F7C580", Offset = "0x1F7C681", VA = "0x1F7C580")]
		internal string <.cctor>b__46_160()
		{
			return null;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007556")]
		[Address(RVA = "0x1F7C620", Offset = "0x1F7C721", VA = "0x1F7C620")]
		internal string <.cctor>b__46_161()
		{
			return null;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007557")]
		[Address(RVA = "0x1F7C680", Offset = "0x1F7C781", VA = "0x1F7C680")]
		internal string <.cctor>b__46_162()
		{
			return null;
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007558")]
		[Address(RVA = "0x1F7C6B0", Offset = "0x1F7C7B1", VA = "0x1F7C6B0")]
		internal string <.cctor>b__46_163()
		{
			return null;
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007559")]
		[Address(RVA = "0x1F7C6C0", Offset = "0x1F7C7C1", VA = "0x1F7C6C0")]
		internal string <.cctor>b__46_164()
		{
			return null;
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755A")]
		[Address(RVA = "0x1F7C6D0", Offset = "0x1F7C7D1", VA = "0x1F7C6D0")]
		internal string <.cctor>b__46_165()
		{
			return null;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755B")]
		[Address(RVA = "0x1F7C6E0", Offset = "0x1F7C7E1", VA = "0x1F7C6E0")]
		internal string <.cctor>b__46_166()
		{
			return null;
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755C")]
		[Address(RVA = "0x1F7C6F0", Offset = "0x1F7C7F1", VA = "0x1F7C6F0")]
		internal string <.cctor>b__46_167()
		{
			return null;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755D")]
		[Address(RVA = "0x1F7C700", Offset = "0x1F7C801", VA = "0x1F7C700")]
		internal string <.cctor>b__46_168()
		{
			return null;
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755E")]
		[Address(RVA = "0x1F7C710", Offset = "0x1F7C811", VA = "0x1F7C710")]
		internal string <.cctor>b__46_169()
		{
			return null;
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755F")]
		[Address(RVA = "0x1F7C720", Offset = "0x1F7C821", VA = "0x1F7C720")]
		internal string <.cctor>b__46_170()
		{
			return null;
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007560")]
		[Address(RVA = "0x1F7C730", Offset = "0x1F7C831", VA = "0x1F7C730")]
		internal string <.cctor>b__46_171()
		{
			return null;
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007561")]
		[Address(RVA = "0x1F7C740", Offset = "0x1F7C841", VA = "0x1F7C740")]
		internal string <.cctor>b__46_172()
		{
			return null;
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007562")]
		[Address(RVA = "0x1F7C750", Offset = "0x1F7C851", VA = "0x1F7C750")]
		internal string <.cctor>b__46_173()
		{
			return null;
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007563")]
		[Address(RVA = "0x1F7C760", Offset = "0x1F7C861", VA = "0x1F7C760")]
		internal string <.cctor>b__46_174()
		{
			return null;
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007564")]
		[Address(RVA = "0x1F7C770", Offset = "0x1F7C871", VA = "0x1F7C770")]
		internal string <.cctor>b__46_175()
		{
			return null;
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007565")]
		[Address(RVA = "0x1F7C780", Offset = "0x1F7C881", VA = "0x1F7C780")]
		internal string <.cctor>b__46_176()
		{
			return null;
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007566")]
		[Address(RVA = "0x1F7C790", Offset = "0x1F7C891", VA = "0x1F7C790")]
		internal string <.cctor>b__46_177()
		{
			return null;
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007567")]
		[Address(RVA = "0x1F7C7A0", Offset = "0x1F7C8A1", VA = "0x1F7C7A0")]
		internal string <.cctor>b__46_178()
		{
			return null;
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007568")]
		[Address(RVA = "0x1F7C7B0", Offset = "0x1F7C8B1", VA = "0x1F7C7B0")]
		internal string <.cctor>b__46_179()
		{
			return null;
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007569")]
		[Address(RVA = "0x1F7C7C0", Offset = "0x1F7C8C1", VA = "0x1F7C7C0")]
		internal string <.cctor>b__46_180()
		{
			return null;
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756A")]
		[Address(RVA = "0x1F7C7D0", Offset = "0x1F7C8D1", VA = "0x1F7C7D0")]
		internal string <.cctor>b__46_181()
		{
			return null;
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756B")]
		[Address(RVA = "0x1F7C7E0", Offset = "0x1F7C8E1", VA = "0x1F7C7E0")]
		internal string <.cctor>b__46_182()
		{
			return null;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756C")]
		[Address(RVA = "0x1F7C7F0", Offset = "0x1F7C8F1", VA = "0x1F7C7F0")]
		internal string <.cctor>b__46_183()
		{
			return null;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756D")]
		[Address(RVA = "0x1F7C800", Offset = "0x1F7C901", VA = "0x1F7C800")]
		internal string <.cctor>b__46_184()
		{
			return null;
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756E")]
		[Address(RVA = "0x1F7C810", Offset = "0x1F7C911", VA = "0x1F7C810")]
		internal string <.cctor>b__46_185()
		{
			return null;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756F")]
		[Address(RVA = "0x1F7C820", Offset = "0x1F7C921", VA = "0x1F7C820")]
		internal string <.cctor>b__46_186()
		{
			return null;
		}

		// Token: 0x04008005 RID: 32773
		[Token(Token = "0x4019909")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextOverwriteList.<>c <>9;

		// Token: 0x04008006 RID: 32774
		[Token(Token = "0x401990A")]
		[FieldOffset(Offset = "0x8")]
		public static MatchEvaluator <>9__15_0;

		// Token: 0x04008007 RID: 32775
		[Token(Token = "0x401990B")]
		[FieldOffset(Offset = "0x10")]
		public static UnityAction<AssetHandle<PlayerCallingNameTextData>> <>9__45_0;

		// Token: 0x04008008 RID: 32776
		[Token(Token = "0x401990C")]
		[FieldOffset(Offset = "0x18")]
		public static UnityAction<AssetHandle<NPCCallingNameTextData>> <>9__45_1;
	}
}
