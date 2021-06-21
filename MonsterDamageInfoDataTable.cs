using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000697 RID: 1687
[Token(Token = "0x20004B9")]
[Serializable]
public class MonsterDamageInfoDataTable
{
	// Token: 0x06002936 RID: 10550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x1E5E0F0", Offset = "0x1E5E1F1", VA = "0x1E5E0F0")]
	public static MonsterDamageInfoDataTable GetDataTable(MonsterDamageInfoID monsterDamageInfoID)
	{
		return null;
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D7")]
	[Address(RVA = "0x1E5E240", Offset = "0x1E5E341", VA = "0x1E5E240")]
	public MonsterDamageInfoDataTable()
	{
	}

	// Token: 0x0400711D RID: 28957
	[Token(Token = "0x4006919")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public bool SealFlag;

	// Token: 0x0400711E RID: 28958
	[Token(Token = "0x400691A")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public AttackType AttackType;

	// Token: 0x0400711F RID: 28959
	[Token(Token = "0x400691B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float MotionPower;

	// Token: 0x04007120 RID: 28960
	[Token(Token = "0x400691C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float FriendlyMotionPower;

	// Token: 0x04007121 RID: 28961
	[Token(Token = "0x400691D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float KnockbackPower;

	// Token: 0x04007122 RID: 28962
	[Token(Token = "0x400691E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int BlowAttackPower;

	// Token: 0x04007123 RID: 28963
	[Token(Token = "0x400691F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Vector3 Direction;

	// Token: 0x04007124 RID: 28964
	[Token(Token = "0x4006920")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int PercentDamage;

	// Token: 0x04007125 RID: 28965
	[Token(Token = "0x4006921")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int TrueDamage;

	// Token: 0x04007126 RID: 28966
	[Token(Token = "0x4006922")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public bool Attribute_Fire;

	// Token: 0x04007127 RID: 28967
	[Token(Token = "0x4006923")]
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	public bool Attribute_Water;

	// Token: 0x04007128 RID: 28968
	[Token(Token = "0x4006924")]
	[FieldOffset(Offset = "0x3E")]
	[SerializeField]
	public bool Attribute_Earth;

	// Token: 0x04007129 RID: 28969
	[Token(Token = "0x4006925")]
	[FieldOffset(Offset = "0x3F")]
	[SerializeField]
	public bool Attribute_Wind;

	// Token: 0x0400712A RID: 28970
	[Token(Token = "0x4006926")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public bool Attribute_Shine;

	// Token: 0x0400712B RID: 28971
	[Token(Token = "0x4006927")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	public bool Attribute_Dark;

	// Token: 0x0400712C RID: 28972
	[Token(Token = "0x4006928")]
	[FieldOffset(Offset = "0x42")]
	[SerializeField]
	public bool Attribute_Love;

	// Token: 0x0400712D RID: 28973
	[Token(Token = "0x4006929")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float AttackStun;

	// Token: 0x0400712E RID: 28974
	[Token(Token = "0x400692A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float AttackPoison;

	// Token: 0x0400712F RID: 28975
	[Token(Token = "0x400692B")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float AttackParalysis;

	// Token: 0x04007130 RID: 28976
	[Token(Token = "0x400692C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float AttackSleep;

	// Token: 0x04007131 RID: 28977
	[Token(Token = "0x400692D")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public float AttackTire;

	// Token: 0x04007132 RID: 28978
	[Token(Token = "0x400692E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public float AttackSick;

	// Token: 0x04007133 RID: 28979
	[Token(Token = "0x400692F")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public float AttackDeath;

	// Token: 0x04007134 RID: 28980
	[Token(Token = "0x4006930")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float AttackHpDrain;

	// Token: 0x04007135 RID: 28981
	[Token(Token = "0x4006931")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float AttackSeal;

	// Token: 0x04007136 RID: 28982
	[Token(Token = "0x4006932")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public bool HealStun;

	// Token: 0x04007137 RID: 28983
	[Token(Token = "0x4006933")]
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	public bool HealPoison;

	// Token: 0x04007138 RID: 28984
	[Token(Token = "0x4006934")]
	[FieldOffset(Offset = "0x6A")]
	[SerializeField]
	public bool HealParalysis;

	// Token: 0x04007139 RID: 28985
	[Token(Token = "0x4006935")]
	[FieldOffset(Offset = "0x6B")]
	[SerializeField]
	public bool HealSleep;

	// Token: 0x0400713A RID: 28986
	[Token(Token = "0x4006936")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public bool HealTire;

	// Token: 0x0400713B RID: 28987
	[Token(Token = "0x4006937")]
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	public bool HealSick;

	// Token: 0x0400713C RID: 28988
	[Token(Token = "0x4006938")]
	[FieldOffset(Offset = "0x6E")]
	[SerializeField]
	public bool HealDeath;

	// Token: 0x0400713D RID: 28989
	[Token(Token = "0x4006939")]
	[FieldOffset(Offset = "0x6F")]
	[SerializeField]
	public bool HealSeal;

	// Token: 0x0400713E RID: 28990
	[Token(Token = "0x400693A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public bool IsHideDamageText;

	// Token: 0x0400713F RID: 28991
	[Token(Token = "0x400693B")]
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	public bool IsHideDamageEffect;

	// Token: 0x04007140 RID: 28992
	[Token(Token = "0x400693C")]
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	public bool IsNotJustAvoid;

	// Token: 0x04007141 RID: 28993
	[Token(Token = "0x400693D")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterDamageInfoDataTableArray _MonsterDamageInfoTableArray;
}
