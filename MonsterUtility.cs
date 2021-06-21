using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x020007DE RID: 2014
[Token(Token = "0x2000537")]
public static class MonsterUtility
{
	// Token: 0x060034A6 RID: 13478 RVA: 0x00011E50 File Offset: 0x00010050
	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x1E730E0", Offset = "0x1E731E1", VA = "0x1E730E0")]
	public static bool ExistWoolMocomocoMonsterDataId(MonsterDataID monsterDataId)
	{
		return default(bool);
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x00011E68 File Offset: 0x00010068
	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x1E73100", Offset = "0x1E73201", VA = "0x1E73100")]
	public static bool NotExistWoolMocomocoMonsterDataId(MonsterDataID monsterDataId)
	{
		return default(bool);
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00011E80 File Offset: 0x00010080
	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x1E73120", Offset = "0x1E73221", VA = "0x1E73120")]
	public static bool IsMocomocoMonsterDataId(MonsterDataID monsterDataId)
	{
		return default(bool);
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00011E98 File Offset: 0x00010098
	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0x1E731F0", Offset = "0x1E732F1", VA = "0x1E731F0")]
	public static bool CanGrowsWoolMocomocoMonsterData(MonsterDataID monsterDataID)
	{
		return default(bool);
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0x1E73200", Offset = "0x1E73301", VA = "0x1E73200")]
	public static void UpdateSuction(Transform centerTransform, float suctionPower, float minRange, float maxRange)
	{
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x00011EB0 File Offset: 0x000100B0
	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x1E734D0", Offset = "0x1E735D1", VA = "0x1E734D0")]
	public static bool GetNavimeshPostion(Vector3 pos, int sampleRange, int areaMask, out Vector3 hitPos)
	{
		return default(bool);
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00011EC8 File Offset: 0x000100C8
	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x1E73550", Offset = "0x1E73651", VA = "0x1E73550")]
	public static Vector3 GetRandomPlanePostion(Transform targetTransform, float maxRadius, float sampleRange, int areaMask, [Optional] Func<NavMeshHit, bool> compareFlag, float minRadius = 0f)
	{
		return default(Vector3);
	}

	// Token: 0x0400785F RID: 30815
	[Token(Token = "0x4006D4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<int, Vector2Int> MakingMonsterLevelupStageDic;

	// Token: 0x04007860 RID: 30816
	[Token(Token = "0x4006D4D")]
	public const int MonsterLevelupStageMin = 0;

	// Token: 0x04007861 RID: 30817
	[Token(Token = "0x4006D4E")]
	public const int MonsterLevelupStageMax = 10;

	// Token: 0x04007862 RID: 30818
	[Token(Token = "0x4006D4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static uint MaxFarmSupportMonsterCount;

	// Token: 0x04007863 RID: 30819
	[Token(Token = "0x4006D50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly Dictionary<int, MonsterDataID> ConvertMonsterDataIdDic;
}
