using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000165 RID: 357
[Token(Token = "0x2000119")]
public class HateController : SearchCharacterController
{
	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000762 RID: 1890 RVA: 0x00004A28 File Offset: 0x00002C28
	// (set) Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700016F")]
	public bool IsBattleMode
	{
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x24EE4D0", Offset = "0x24EE5D1", VA = "0x24EE4D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8C0", Offset = "0x19A9C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x24EE4E0", Offset = "0x24EE5E1", VA = "0x24EE4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8D0", Offset = "0x19A9D1")]
		protected set
		{
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x24EE4F0", Offset = "0x24EE5F1", VA = "0x24EE4F0")]
	public void SetLookTargetSearchType(int lookTargetSearchType)
	{
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x24EE500", Offset = "0x24EE601", VA = "0x24EE500")]
	public void SetBattleMode(bool isBattleMode)
	{
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x24EE510", Offset = "0x24EE611", VA = "0x24EE510")]
	public void SetForceBattleMode(bool isForceBattleMode)
	{
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x24EE520", Offset = "0x24EE621", VA = "0x24EE520")]
	public void AddTargetAlliance(Alliance alliance)
	{
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x24EE5C0", Offset = "0x24EE6C1", VA = "0x24EE5C0", Slot = "4")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x24EE630", Offset = "0x24EE731", VA = "0x24EE630", Slot = "5")]
	protected override void OnBeforeTick()
	{
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x24EE810", Offset = "0x24EE911", VA = "0x24EE810", Slot = "6")]
	protected override void OnFindCharacter(Character character, int searchParameterType)
	{
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x24EED70", Offset = "0x24EEE71", VA = "0x24EED70")]
	public HateController.HateParameter GetHateParameter(Character character)
	{
		return null;
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x24EEEB0", Offset = "0x24EEFB1", VA = "0x24EEEB0")]
	public Character GetMostHateCharacter()
	{
		return null;
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x24EF170", Offset = "0x24EF271", VA = "0x24EF170")]
	public Character FindCharacter(int initValue, Func<HateController.HateParameter, int, int> func)
	{
		return null;
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x24EE9D0", Offset = "0x24EEAD1", VA = "0x24EE9D0")]
	public void AddCharacter(Character character)
	{
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x24EF370", Offset = "0x24EF471", VA = "0x24EF370")]
	public void ClearHateValueDic()
	{
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x24EF470", Offset = "0x24EF571", VA = "0x24EF470")]
	public void UpdateHateValue()
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x24EE910", Offset = "0x24EEA11", VA = "0x24EE910")]
	public int FindIndexHateParameterListByCharacter(int charactergameobjectInstanceID)
	{
		return 0;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x24EF860", Offset = "0x24EF961", VA = "0x24EF860")]
	private void AddHateValue(Character character, HateController.HateValueType hateValueType)
	{
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x24EF750", Offset = "0x24EF851", VA = "0x24EF750")]
	private void AddHateValue(HateController.HateParameter parameter, HateController.HateValueType hateValueType)
	{
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x24EF0C0", Offset = "0x24EF1C1", VA = "0x24EF0C0")]
	private bool IsDeleteHate(Character character)
	{
		return default(bool);
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x24EF360", Offset = "0x24EF461", VA = "0x24EF360")]
	public void Contact(Character character)
	{
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x24EFA30", Offset = "0x24EFB31", VA = "0x24EFA30")]
	public void Damage(Character character, bool isCritical = false)
	{
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000656")]
	[Address(RVA = "0x24EFF40", Offset = "0x24F0041", VA = "0x24EFF40")]
	public HateController()
	{
	}

	// Token: 0x0400043A RID: 1082
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0xA0")]
	private List<int> HateValueList;

	// Token: 0x0400043B RID: 1083
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0xA8")]
	private float DecreaseTime;

	// Token: 0x0400043C RID: 1084
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0xAC")]
	private float DecreaseTimeOutOfAttackRange;

	// Token: 0x0400043D RID: 1085
	[Token(Token = "0x4000348")]
	[FieldOffset(Offset = "0xB0")]
	private float DecreaseTimeCancelBattleMode;

	// Token: 0x0400043E RID: 1086
	[Token(Token = "0x4000349")]
	[FieldOffset(Offset = "0xB8")]
	private List<int> RemoveHateValueParameterIndexList;

	// Token: 0x0400043F RID: 1087
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0xC0")]
	private List<HateController.HateParameter> HateParamList;

	// Token: 0x04000440 RID: 1088
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0xC8")]
	private int LookTargetSearchType;

	// Token: 0x04000441 RID: 1089
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0xD0")]
	private List<Alliance> TargetAllianceList;

	// Token: 0x04000442 RID: 1090
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BFF0", Offset = "0x15C0F1")]
	private bool <IsBattleMode>k__BackingField;

	// Token: 0x04000443 RID: 1091
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0xD9")]
	private bool IsForceBattleMode;

	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000FD5")]
	public enum HateOverrideType
	{
		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4018D69")]
		None,
		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4018D6A")]
		LowHP,
		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4018D6B")]
		HighHP,
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4018D6C")]
		HighAttack
	}

	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000FD6")]
	public enum HateValueType
	{
		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x4018D6E")]
		Contact,
		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x4018D6F")]
		FirstDamage,
		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x4018D70")]
		Damage,
		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x4018D71")]
		CriticalDamage,
		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x4018D72")]
		Heal,
		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x4018D73")]
		Cure,
		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4018D74")]
		WorstDefence,
		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4018D75")]
		WorstMagicDefence,
		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4018D76")]
		WorstRemainHP,
		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4018D77")]
		ThreeSecondsDecrease,
		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4018D78")]
		OutofRangeTimeDecrease,
		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4018D79")]
		CancelBattleMode
	}

	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000FD7")]
	public class HateParameter
	{
		// Token: 0x06000778 RID: 1912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0C")]
		[Address(RVA = "0x24EF350", Offset = "0x24EF451", VA = "0x24EF350")]
		public HateParameter()
		{
		}

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4018D7A")]
		[FieldOffset(Offset = "0x10")]
		public bool IsDestroy;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4018D7B")]
		[FieldOffset(Offset = "0x11")]
		public bool IsOutOfAttackRange;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4018D7C")]
		[FieldOffset(Offset = "0x12")]
		public bool IsFirstDamage;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4018D7D")]
		[FieldOffset(Offset = "0x14")]
		public float DecreaseTimer;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x4018D7E")]
		[FieldOffset(Offset = "0x18")]
		public float DecreaseTimerOutOfAttackRange;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x4018D7F")]
		[FieldOffset(Offset = "0x1C")]
		public float DecreaseTimerCancelBattleMode;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x4018D80")]
		[FieldOffset(Offset = "0x20")]
		public Character Character;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x4018D81")]
		[FieldOffset(Offset = "0x28")]
		public int CharacterGameObjectInstanceID;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x4018D82")]
		[FieldOffset(Offset = "0x2C")]
		public int HateValue;
	}

	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000FD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571D0", Offset = "0x1572D1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0E")]
		[Address(RVA = "0x24F01B0", Offset = "0x24F02B1", VA = "0x24F01B0")]
		public <>c()
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x6006C0F")]
		[Address(RVA = "0x24F01C0", Offset = "0x24F02C1", VA = "0x24F01C0")]
		internal int <Damage>b__34_0(HateController.HateParameter param, int value)
		{
			return 0;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x6006C10")]
		[Address(RVA = "0x24F0250", Offset = "0x24F0351", VA = "0x24F0250")]
		internal int <Damage>b__34_1(HateController.HateParameter param, int value)
		{
			return 0;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x6006C11")]
		[Address(RVA = "0x24F02E0", Offset = "0x24F03E1", VA = "0x24F02E0")]
		internal int <Damage>b__34_2(HateController.HateParameter param, int value)
		{
			return 0;
		}

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x4018D83")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HateController.<>c <>9;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4018D84")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HateController.HateParameter, int, int> <>9__34_0;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4018D85")]
		[FieldOffset(Offset = "0x10")]
		public static Func<HateController.HateParameter, int, int> <>9__34_1;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4018D86")]
		[FieldOffset(Offset = "0x18")]
		public static Func<HateController.HateParameter, int, int> <>9__34_2;
	}
}
