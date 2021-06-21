using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x020006A0 RID: 1696
[Token(Token = "0x20004C2")]
[Serializable]
public class MonsterModelData
{
	// Token: 0x06002944 RID: 10564 RVA: 0x000102C0 File Offset: 0x0000E4C0
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x1E6C370", Offset = "0x1E6C471", VA = "0x1E6C370")]
	public Prefab GetModelLoaderID(bool isEnemy)
	{
		return Prefab.NONE;
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x000102D8 File Offset: 0x0000E4D8
	[Token(Token = "0x60022E5")]
	[Address(RVA = "0x1E6B710", Offset = "0x1E6B811", VA = "0x1E6B710")]
	public float GetScale(bool isEnemy)
	{
		return 0f;
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x000102F0 File Offset: 0x0000E4F0
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x1E6DEC0", Offset = "0x1E6DFC1", VA = "0x1E6DEC0")]
	public float GetEmotionScale(bool isEnemy)
	{
		return 0f;
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x1E6DEE0", Offset = "0x1E6DFE1", VA = "0x1E6DEE0")]
	public static MonsterModelData GetDataTable(MonsterModelDataID dataID)
	{
		return null;
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x1E6E040", Offset = "0x1E6E141", VA = "0x1E6E040")]
	public MonsterModelData()
	{
	}

	// Token: 0x04007180 RID: 29056
	[Token(Token = "0x400697C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MonsterModelDataID DataID;

	// Token: 0x04007181 RID: 29057
	[Token(Token = "0x400697D")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public Prefab MonsterControllerLoaderID;

	// Token: 0x04007182 RID: 29058
	[Token(Token = "0x400697E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Prefab EnemyModelLoaderID;

	// Token: 0x04007183 RID: 29059
	[Token(Token = "0x400697F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Prefab FriendModelLoaderID;

	// Token: 0x04007184 RID: 29060
	[Token(Token = "0x4006980")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float EnemyPrefabScale;

	// Token: 0x04007185 RID: 29061
	[Token(Token = "0x4006981")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float FriendPrefabScale;

	// Token: 0x04007186 RID: 29062
	[Token(Token = "0x4006982")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float EnemyEmotionScale;

	// Token: 0x04007187 RID: 29063
	[Token(Token = "0x4006983")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float FriendEmotionScale;

	// Token: 0x04007188 RID: 29064
	[Token(Token = "0x4006984")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float UIPrefabScale;

	// Token: 0x04007189 RID: 29065
	[Token(Token = "0x4006985")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public HeightSizeType HeightSize;

	// Token: 0x0400718A RID: 29066
	[Token(Token = "0x4006986")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterModelDataTable _MonsterModelDataTable;
}
