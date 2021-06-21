using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x0200069A RID: 1690
[Token(Token = "0x20004BC")]
[Serializable]
public struct MonsterDataTable
{
	// Token: 0x0600293A RID: 10554 RVA: 0x00010260 File Offset: 0x0000E460
	[Token(Token = "0x60022DA")]
	[Address(RVA = "0x1E5E2E0", Offset = "0x1E5E3E1", VA = "0x1E5E2E0")]
	public static MonsterDataTable GetDataTable(MonsterDataID monsterDataID)
	{
		return default(MonsterDataTable);
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x00010278 File Offset: 0x0000E478
	[Token(Token = "0x60022DB")]
	[Address(RVA = "0x1E5E470", Offset = "0x1E5E571", VA = "0x1E5E470")]
	public static MonsterDataTable GetDataTable(int index)
	{
		return default(MonsterDataTable);
	}

	// Token: 0x04007143 RID: 28995
	[Token(Token = "0x400693F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public MonsterDataID DataID;

	// Token: 0x04007144 RID: 28996
	[Token(Token = "0x4006940")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public MonsterID MonsterId;

	// Token: 0x04007145 RID: 28997
	[Token(Token = "0x4006941")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public MonsterModelDataID ModelDataID;

	// Token: 0x04007146 RID: 28998
	[Token(Token = "0x4006942")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public FootStepType FootStepType;

	// Token: 0x04007147 RID: 28999
	[Token(Token = "0x4006943")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MonsterFootStepEventDataID MonsterFootStepEventDataID;

	// Token: 0x04007148 RID: 29000
	[Token(Token = "0x4006944")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public MonsterCharacterType CharacterType;

	// Token: 0x04007149 RID: 29001
	[Token(Token = "0x4006945")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MoveParamID MoveParamID;

	// Token: 0x0400714A RID: 29002
	[Token(Token = "0x4006946")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public MoveParamID FriendMoveParamID;

	// Token: 0x0400714B RID: 29003
	[Token(Token = "0x4006947")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float RideMaxSpeedRate;

	// Token: 0x0400714C RID: 29004
	[Token(Token = "0x4006948")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int RideCount;

	// Token: 0x0400714D RID: 29005
	[Token(Token = "0x4006949")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public MonsterRideAnimationType RideAnimationType;

	// Token: 0x0400714E RID: 29006
	[Token(Token = "0x400694A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float RideCameraYOffset;

	// Token: 0x0400714F RID: 29007
	[Token(Token = "0x400694B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float RideCameraDistanceOffset;

	// Token: 0x04007150 RID: 29008
	[Token(Token = "0x400694C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int DefeatBonus_HP;

	// Token: 0x04007151 RID: 29009
	[Token(Token = "0x400694D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int DefeatBonus_STR;

	// Token: 0x04007152 RID: 29010
	[Token(Token = "0x400694E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int DefeatBonus_INT;

	// Token: 0x04007153 RID: 29011
	[Token(Token = "0x400694F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int DefeatBonus_VIT;

	// Token: 0x04007154 RID: 29012
	[Token(Token = "0x4006950")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public bool CanFriend;

	// Token: 0x04007155 RID: 29013
	[Token(Token = "0x4006951")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int CanFriendInitPercent;

	// Token: 0x04007156 RID: 29014
	[Token(Token = "0x4006952")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float FriendMovementOrderCloseRange;

	// Token: 0x04007157 RID: 29015
	[Token(Token = "0x4006953")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float FriendMovementOrderLeaveRange;

	// Token: 0x04007158 RID: 29016
	[Token(Token = "0x4006954")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public float FriendBehaviorWaitRate;

	// Token: 0x04007159 RID: 29017
	[Token(Token = "0x4006955")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public float EnemyBehaviorWaitRate_Easy;

	// Token: 0x0400715A RID: 29018
	[Token(Token = "0x4006956")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public float EnemyBehaviorWaitRate_Normal;

	// Token: 0x0400715B RID: 29019
	[Token(Token = "0x4006957")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int DefenceRestraint;

	// Token: 0x0400715C RID: 29020
	[Token(Token = "0x4006958")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public int ReleaseRestraintRate;

	// Token: 0x0400715D RID: 29021
	[Token(Token = "0x4006959")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public int HandcuffsEffectSize;

	// Token: 0x0400715E RID: 29022
	[Token(Token = "0x400695A")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public float HandcuffsEffectOffsetY;

	// Token: 0x0400715F RID: 29023
	[Token(Token = "0x400695B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public bool CanCatch;

	// Token: 0x04007160 RID: 29024
	[Token(Token = "0x400695C")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public int CanCatchInitPercent;

	// Token: 0x04007161 RID: 29025
	[Token(Token = "0x400695D")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float GrappleRotationY;

	// Token: 0x04007162 RID: 29026
	[Token(Token = "0x400695E")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public Vector3 GrappleHorizontalOffset;

	// Token: 0x04007163 RID: 29027
	[Token(Token = "0x400695F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public Vector3 GrappleVerticalOffset;

	// Token: 0x04007164 RID: 29028
	[Token(Token = "0x4006960")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public MonsterFavoriteItemData FavoriteItemData;

	// Token: 0x04007165 RID: 29029
	[Token(Token = "0x4006961")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public int YieldPercent;

	// Token: 0x04007166 RID: 29030
	[Token(Token = "0x4006962")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public ItemID[] YieldItemIDArray;

	// Token: 0x04007167 RID: 29031
	[Token(Token = "0x4006963")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public MonsterBehaviorDataID BehaviorDataID;

	// Token: 0x04007168 RID: 29032
	[Token(Token = "0x4006964")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	public MonsterDropItemDataID DropItemDataID;

	// Token: 0x04007169 RID: 29033
	[Token(Token = "0x4006965")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public Master BossDataAssetID;

	// Token: 0x0400716A RID: 29034
	[Token(Token = "0x4006966")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	public bool BossColorVariation;

	// Token: 0x0400716B RID: 29035
	[Token(Token = "0x4006967")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public CharaParamDataTable CharaParam;

	// Token: 0x0400716C RID: 29036
	[Token(Token = "0x4006968")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterDataTableArray _MonsterDataTableArray;
}
