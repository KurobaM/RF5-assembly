using System;
using Define;
using Il2CppDummyDll;

namespace Calc
{
	// Token: 0x020010CF RID: 4303
	[Token(Token = "0x2000AC8")]
	public static class CalcStatus
	{
		// Token: 0x06006D35 RID: 27957 RVA: 0x000258A8 File Offset: 0x00023AA8
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x219C3B0", Offset = "0x219C4B1", VA = "0x219C3B0")]
		public static int CalcBasicDamage(DamageInfo damageInfo, StatusBase status, bool isCritical, out bool isWeakAttribute, out bool isResistAttribute)
		{
			return 0;
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x000258C0 File Offset: 0x00023AC0
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x219CD20", Offset = "0x219CE21", VA = "0x219CD20")]
		private static float CalcAttackAttribute(ref DamageInfo damageInfo, StatusBase status)
		{
			return 0f;
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x000258D8 File Offset: 0x00023AD8
		[Token(Token = "0x6005A88")]
		[Address(RVA = "0x219D0E0", Offset = "0x219D1E1", VA = "0x219D0E0")]
		public static int CalcPercentDamage(DamageInfo damageInfo, StatusBase status)
		{
			return 0;
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x219D200", Offset = "0x219D301", VA = "0x219D200")]
		public static void CreateDamageInfoForChracter(CharacterStatusBase characterStatus, out DamageInfo damageInfo)
		{
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x000258F0 File Offset: 0x00023AF0
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x219D230", Offset = "0x219D331", VA = "0x219D230")]
		public static bool CheckAllilince(AttackType attackType, Alliance attacker, Alliance target)
		{
			return default(bool);
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x00025908 File Offset: 0x00023B08
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0x219D270", Offset = "0x219D371", VA = "0x219D270")]
		public static bool CalcRand(float attack, float def)
		{
			return default(bool);
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x00025920 File Offset: 0x00023B20
		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x219D340", Offset = "0x219D441", VA = "0x219D340")]
		public static int CalcHpDrain(DamageInfo damageInfo, int totalDamage, Parameter parameter)
		{
			return 0;
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x00025938 File Offset: 0x00023B38
		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x219D430", Offset = "0x219D531", VA = "0x219D430")]
		public static Parameter CalcLevelUpRatio(CharaParamDataTable charaParam, Parameter parameter, int level)
		{
			return default(Parameter);
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x00025950 File Offset: 0x00023B50
		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0x219D660", Offset = "0x219D761", VA = "0x219D660")]
		public static Parameter LevelDown(Parameter parameter)
		{
			return default(Parameter);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x00025968 File Offset: 0x00023B68
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x219D800", Offset = "0x219D901", VA = "0x219D800")]
		public static Parameter LevelUpFriendMonster(CharaParamDataTable charaParam, Parameter parameter, int level)
		{
			return default(Parameter);
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x2189AB0", Offset = "0x2189BB1", VA = "0x2189AB0")]
		public static void LevelUpEnemyMonster(CharaParamDataTable charaParam, bool levelup, StatusDataBase status, int level, bool isBoss)
		{
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x00025980 File Offset: 0x00023B80
		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x219DC20", Offset = "0x219DD21", VA = "0x219DC20")]
		public static Parameter PlayerLevel_Up_or_Down(int prevLevel, int nextLevel, Parameter parameter)
		{
			return default(Parameter);
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x00025998 File Offset: 0x00023B98
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x219DDF0", Offset = "0x219DEF1", VA = "0x219DDF0")]
		public static int GetNeedExp(int level)
		{
			return 0;
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x000259B0 File Offset: 0x00023BB0
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x219DE80", Offset = "0x219DF81", VA = "0x219DE80")]
		public static int CalcSkillActionRP(SkillActionID id, int itemLevel = 1)
		{
			return 0;
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x000259C8 File Offset: 0x00023BC8
		[Token(Token = "0x17000ADE")]
		public static DamageInfo NotEnoughRP_HPDamage
		{
			[Token(Token = "0x6005A94")]
			[Address(RVA = "0x219E390", Offset = "0x219E491", VA = "0x219E390")]
			get
			{
				return default(DamageInfo);
			}
		}

		// Token: 0x06006D44 RID: 27972 RVA: 0x000259E0 File Offset: 0x00023BE0
		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x219E3F0", Offset = "0x219E4F1", VA = "0x219E3F0")]
		public static Parameter CalcSkillEffect()
		{
			return default(Parameter);
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x000259F8 File Offset: 0x00023BF8
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x219CCB0", Offset = "0x219CDB1", VA = "0x219CCB0")]
		private static float CalcSkillAttributeReduce(SkillID skillID, AttackAttribute attribute, bool isMagic)
		{
			return 0f;
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x00025A10 File Offset: 0x00023C10
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x219CCA0", Offset = "0x219CDA1", VA = "0x219CCA0")]
		public static bool Contains(this AttackAttribute self, AttackAttribute target)
		{
			return default(bool);
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x00025A28 File Offset: 0x00023C28
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x219D0D0", Offset = "0x219D1D1", VA = "0x219D0D0")]
		public static bool IsNone(this AttackAttribute self)
		{
			return default(bool);
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x00025A40 File Offset: 0x00023C40
		[Token(Token = "0x6005A99")]
		[Address(RVA = "0x219E620", Offset = "0x219E721", VA = "0x219E620")]
		public static bool HasBadStatus(this BadStatus self, BadStatus badStatus)
		{
			return default(bool);
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x00025A58 File Offset: 0x00023C58
		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0x219E630", Offset = "0x219E731", VA = "0x219E630")]
		public static float CalcDamageKnockback(ref DamageInfo damageInfo, ref DamageResult damageResult, StatusBase status)
		{
			return 0f;
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0x219E6F0", Offset = "0x219E7F1", VA = "0x219E6F0")]
		public static void AddExpWithDestoryEnemy(int addExp, MonsterDataID monsterID)
		{
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x00025A70 File Offset: 0x00023C70
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x219EAC0", Offset = "0x219EBC1", VA = "0x219EAC0")]
		public static int GetBlowPowerByItemCategory(ItemCategory itemCategory)
		{
			return 0;
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x00025A88 File Offset: 0x00023C88
		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x219EC40", Offset = "0x219ED41", VA = "0x219EC40")]
		public static AttackAttribute GetAttackAttribute(ItemData itemData)
		{
			return (AttackAttribute)0;
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x00025AA0 File Offset: 0x00023CA0
		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x219EE30", Offset = "0x219EF31", VA = "0x219EE30")]
		public static bool GetStrengtheingItemAttribute(ItemID itemID, out AttackAttribute attribute)
		{
			return default(bool);
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x00025AB8 File Offset: 0x00023CB8
		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0x219EF30", Offset = "0x219F031", VA = "0x219EF30")]
		public static bool CalcTame(MonsterControllerBase monster)
		{
			return default(bool);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x00025AD0 File Offset: 0x00023CD0
		[Token(Token = "0x6005AA0")]
		[Address(RVA = "0x219F180", Offset = "0x219F281", VA = "0x219F180")]
		public static float CalcAddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUp)
		{
			return 0f;
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x00025AE8 File Offset: 0x00023CE8
		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0x219F230", Offset = "0x219F331", VA = "0x219F230")]
		public static DamageInfo CalcDualSkillDamage(HumanStatus main, HumanStatus sub, MagicParamID magicParamID, int loveLevel)
		{
			return default(DamageInfo);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x00025B00 File Offset: 0x00023D00
		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0x219F400", Offset = "0x219F501", VA = "0x219F400")]
		public static Parameter CalcBonusFriendMonster(FriendMonsterStatus status)
		{
			return default(Parameter);
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x00025B18 File Offset: 0x00023D18
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0x219F770", Offset = "0x219F871", VA = "0x219F770")]
		public static float CalcUseRateByLevel(float useRate, int level)
		{
			return 0f;
		}
	}
}
