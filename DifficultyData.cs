using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000360 RID: 864
[Token(Token = "0x200028E")]
[Serializable]
public class DifficultyData
{
	// Token: 0x0600167F RID: 5759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x1DFB250", Offset = "0x1DFB351", VA = "0x1DFB250")]
	public DifficultyData()
	{
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x1DFB260", Offset = "0x1DFB361", VA = "0x1DFB260")]
	public DifficultyData(float damageRate, float enemyHpRate, int cost, float expRate, bool knockBack, float criticalRate, DifficultyWait enemyWaitTime, int enemyGateNum, bool poison)
	{
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x1DFB2F0", Offset = "0x1DFB3F1", VA = "0x1DFB2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003A0")]
	public static DifficultyDataTableArray DifficultyDataTableArray
	{
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x1DFB890", Offset = "0x1DFB991", VA = "0x1DFB890")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x1DFB900", Offset = "0x1DFBA01", VA = "0x1DFB900")]
	private static void LoadData()
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x1DFBA30", Offset = "0x1DFBB31", VA = "0x1DFBA30")]
	private static DifficultyData GetData(int index)
	{
		return null;
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00009F30 File Offset: 0x00008130
	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x1DFBB80", Offset = "0x1DFBC81", VA = "0x1DFBB80")]
	public static float GetDamageRate(Difficulty difficulty)
	{
		return 0f;
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00009F48 File Offset: 0x00008148
	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x1DFBC00", Offset = "0x1DFBD01", VA = "0x1DFBC00")]
	public static float GetHpRate(Difficulty difficulty)
	{
		return 0f;
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x00009F60 File Offset: 0x00008160
	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x1DFBC80", Offset = "0x1DFBD81", VA = "0x1DFBC80")]
	public static int GetCost(Difficulty difficulty)
	{
		return 0;
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x00009F78 File Offset: 0x00008178
	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x1DFBD00", Offset = "0x1DFBE01", VA = "0x1DFBD00")]
	public static float GetExpRate(Difficulty difficulty)
	{
		return 0f;
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00009F90 File Offset: 0x00008190
	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x1DFBD80", Offset = "0x1DFBE81", VA = "0x1DFBD80")]
	public static float GetKnockBack(Difficulty difficulty, float KnockbackTime, Alliance Alliance, bool IsBoss)
	{
		return 0f;
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x00009FA8 File Offset: 0x000081A8
	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x1DFBE30", Offset = "0x1DFBF31", VA = "0x1DFBE30")]
	public static float GetCriticalRate(Difficulty difficulty)
	{
		return 0f;
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00009FC0 File Offset: 0x000081C0
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x1DFBEB0", Offset = "0x1DFBFB1", VA = "0x1DFBEB0")]
	public static DifficultyWait GetWaitTime(Difficulty difficulty)
	{
		return DifficultyWait.LONG;
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00009FD8 File Offset: 0x000081D8
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x1DFBF30", Offset = "0x1DFC031", VA = "0x1DFBF30")]
	public static int GetGateNum(Difficulty difficulty)
	{
		return 0;
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x00009FF0 File Offset: 0x000081F0
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x1DFBFB0", Offset = "0x1DFC0B1", VA = "0x1DFBFB0")]
	public static bool GetPoison(Difficulty difficulty)
	{
		return default(bool);
	}

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float DamageRate;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float EnemyHpRate;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Cost;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float ExpRate;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool KnockBack;

	// Token: 0x04000E87 RID: 3719
	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float CriticalRate;

	// Token: 0x04000E88 RID: 3720
	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public DifficultyWait EnemyWaitTime;

	// Token: 0x04000E89 RID: 3721
	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int EnemyGateNum;

	// Token: 0x04000E8A RID: 3722
	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public bool Poison;

	// Token: 0x04000E8B RID: 3723
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04000E8C RID: 3724
	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x8")]
	private static DifficultyDataTableArray _DifficultyDataTableArray;
}
