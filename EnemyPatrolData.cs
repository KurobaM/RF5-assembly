using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Serialize;
using UnityEngine;

// Token: 0x02000780 RID: 1920
[Token(Token = "0x2000521")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1462A0", Offset = "0x1463A1")]
public class EnemyPatrolData : ScriptableObject
{
	// Token: 0x060031AD RID: 12717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x22B2F40", Offset = "0x22B3041", VA = "0x22B2F40")]
	public EnemyPatrolData.PatrolParameter GetPatrolParameter(MonsterCharacterType type)
	{
		return null;
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x22B4490", Offset = "0x22B4591", VA = "0x22B4490")]
	public EnemyPatrolData()
	{
	}

	// Token: 0x0400766F RID: 30319
	[Token(Token = "0x4006C61")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<EnemyPatrolData.PatrolParameter> PatrolParameterList;

	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x20011E6")]
	[Serializable]
	public class PatrolParameter
	{
		// Token: 0x060031AF RID: 12719 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x60072E3")]
		[Address(RVA = "0x22B4510", Offset = "0x22B4611", VA = "0x22B4510")]
		public bool ExistCharacterType(MonsterCharacterType type)
		{
			return default(bool);
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00011310 File Offset: 0x0000F510
		[Token(Token = "0x60072E4")]
		[Address(RVA = "0x22B3010", Offset = "0x22B3111", VA = "0x22B3010")]
		public PatrolBehaviorType GetLotteryPatrolType()
		{
			return PatrolBehaviorType.Wait;
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00011328 File Offset: 0x0000F528
		[Token(Token = "0x60072E5")]
		[Address(RVA = "0x22B31F0", Offset = "0x22B32F1", VA = "0x22B31F0")]
		public float GetWalkTime()
		{
			return 0f;
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00011340 File Offset: 0x0000F540
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0x22B3200", Offset = "0x22B3301", VA = "0x22B3200")]
		public float GetRunTime()
		{
			return 0f;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00011358 File Offset: 0x0000F558
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0x22B3210", Offset = "0x22B3311", VA = "0x22B3210")]
		public int GetWaitCount()
		{
			return 0;
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0x22B4580", Offset = "0x22B4681", VA = "0x22B4580")]
		public PatrolParameter()
		{
		}

		// Token: 0x04007670 RID: 30320
		[Token(Token = "0x4019677")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<MonsterCharacterType> CharacterTypeList;

		// Token: 0x04007671 RID: 30321
		[Token(Token = "0x4019678")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<EnemyPatrolData.PatrolParameter.PatrollBehaviorTypeKeyAndValue> PatrolLot;

		// Token: 0x04007672 RID: 30322
		[Token(Token = "0x4019679")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float MinWalkTime;

		// Token: 0x04007673 RID: 30323
		[Token(Token = "0x401967A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float MaxWalkTime;

		// Token: 0x04007674 RID: 30324
		[Token(Token = "0x401967B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float MinRunTime;

		// Token: 0x04007675 RID: 30325
		[Token(Token = "0x401967C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float MaxRunTime;

		// Token: 0x04007676 RID: 30326
		[Token(Token = "0x401967D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int MinWaitCount;

		// Token: 0x04007677 RID: 30327
		[Token(Token = "0x401967E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int MaxWaitCount;

		// Token: 0x02000782 RID: 1922
		[Token(Token = "0x200164C")]
		[Serializable]
		public class PatrollBehaviorTypeKeyAndValue : KeyAndValue<PatrolBehaviorType, int>
		{
			// Token: 0x060031B5 RID: 12725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600809C")]
			[Address(RVA = "0x22B4590", Offset = "0x22B4691", VA = "0x22B4590")]
			private PatrollBehaviorTypeKeyAndValue(PatrolBehaviorType key, int value)
			{
			}
		}
	}

	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x20011E7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158780", Offset = "0x158881")]
	private sealed class <>c__DisplayClass2_0
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0x22B4480", Offset = "0x22B4581", VA = "0x22B4480")]
		public <>c__DisplayClass2_0()
		{
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x60072EA")]
		[Address(RVA = "0x22B44A0", Offset = "0x22B45A1", VA = "0x22B44A0")]
		internal bool <GetPatrolParameter>b__0(EnemyPatrolData.PatrolParameter parameter)
		{
			return default(bool);
		}

		// Token: 0x04007678 RID: 30328
		[Token(Token = "0x401967F")]
		[FieldOffset(Offset = "0x10")]
		public MonsterCharacterType type;
	}
}
