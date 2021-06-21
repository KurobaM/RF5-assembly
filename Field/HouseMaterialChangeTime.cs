using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x020010FC RID: 4348
	[Token(Token = "0x2000AF1")]
	public class HouseMaterialChangeTime : MonoBehaviour
	{
		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DD9 RID: 28121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEA")]
		public MaterialChangeTime[] MaterialChangeTimes
		{
			[Token(Token = "0x6005B21")]
			[Address(RVA = "0x2027F00", Offset = "0x2028001", VA = "0x2027F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B22")]
			[Address(RVA = "0x2027F10", Offset = "0x2028011", VA = "0x2027F10")]
			set
			{
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06006DDA RID: 28122 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DDB RID: 28123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEB")]
		public TimeParamTable[] TimeParamTables
		{
			[Token(Token = "0x6005B23")]
			[Address(RVA = "0x2027F20", Offset = "0x2028021", VA = "0x2027F20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B24")]
			[Address(RVA = "0x2027F30", Offset = "0x2028031", VA = "0x2027F30")]
			set
			{
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06006DDC RID: 28124 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DDD RID: 28125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEC")]
		public ObjectChangeTime[] ObjectChangeTimes
		{
			[Token(Token = "0x6005B25")]
			[Address(RVA = "0x2027F40", Offset = "0x2028041", VA = "0x2027F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B26")]
			[Address(RVA = "0x2027F50", Offset = "0x2028051", VA = "0x2027F50")]
			set
			{
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06006DDE RID: 28126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DDF RID: 28127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AED")]
		public TimeParamTable[] ObjectTimeParamTables
		{
			[Token(Token = "0x6005B27")]
			[Address(RVA = "0x2027F60", Offset = "0x2028061", VA = "0x2027F60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B28")]
			[Address(RVA = "0x2027F70", Offset = "0x2028071", VA = "0x2027F70")]
			set
			{
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x00025DB8 File Offset: 0x00023FB8
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEE")]
		[SerializeField]
		public bool IsSleeping
		{
			[Token(Token = "0x6005B29")]
			[Address(RVA = "0x2027F80", Offset = "0x2028081", VA = "0x2027F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEA70", Offset = "0x1AEB71")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005B2A")]
			[Address(RVA = "0x2027F90", Offset = "0x2028091", VA = "0x2027F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEA80", Offset = "0x1AEB81")]
			set
			{
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x00025DD0 File Offset: 0x00023FD0
		// (set) Token: 0x06006DE3 RID: 28131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEF")]
		public int HouseId
		{
			[Token(Token = "0x6005B2B")]
			[Address(RVA = "0x2027FA0", Offset = "0x20280A1", VA = "0x2027FA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005B2C")]
			[Address(RVA = "0x2027FB0", Offset = "0x20280B1", VA = "0x2027FB0")]
			set
			{
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x00025DE8 File Offset: 0x00023FE8
		// (set) Token: 0x06006DE5 RID: 28133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF0")]
		public HouseWindowMaterialType HouseWindowMaterialType
		{
			[Token(Token = "0x6005B2D")]
			[Address(RVA = "0x2027FC0", Offset = "0x20280C1", VA = "0x2027FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEA90", Offset = "0x1AEB91")]
			get
			{
				return HouseWindowMaterialType.Normal;
			}
			[Token(Token = "0x6005B2E")]
			[Address(RVA = "0x2027FD0", Offset = "0x20280D1", VA = "0x2027FD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEAA0", Offset = "0x1AEBA1")]
			set
			{
			}
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x2027FE0", Offset = "0x20280E1", VA = "0x2027FE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B30")]
		[Address(RVA = "0x20280E0", Offset = "0x20281E1", VA = "0x20280E0")]
		private void Awake()
		{
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B31")]
		[Address(RVA = "0x20280F0", Offset = "0x20281F1", VA = "0x20280F0")]
		private void Start()
		{
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B32")]
		[Address(RVA = "0x2028220", Offset = "0x2028321", VA = "0x2028220")]
		private void CheckHouseState(int houseId)
		{
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B33")]
		[Address(RVA = "0x2028470", Offset = "0x2028571", VA = "0x2028470")]
		private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes)
		{
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B34")]
		[Address(RVA = "0x20284F0", Offset = "0x20285F1", VA = "0x20284F0")]
		private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes)
		{
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B35")]
		[Address(RVA = "0x20286B0", Offset = "0x20287B1", VA = "0x20286B0")]
		public void OnHourChangeSetParam(int elapsedHour)
		{
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B36")]
		[Address(RVA = "0x20286C0", Offset = "0x20287C1", VA = "0x20286C0")]
		public HouseMaterialChangeTime()
		{
		}

		// Token: 0x040180B9 RID: 98489
		[Token(Token = "0x4014B99")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MaterialChangeTime[] _MaterialChangeTimes;

		// Token: 0x040180BA RID: 98490
		[Token(Token = "0x4014B9A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TimeParamTable[] _TimeParamTables;

		// Token: 0x040180BB RID: 98491
		[Token(Token = "0x4014B9B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ObjectChangeTime[] _ObjectChangeTimes;

		// Token: 0x040180BC RID: 98492
		[Token(Token = "0x4014B9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TimeParamTable[] _ObjectTimeParamTables;

		// Token: 0x040180BD RID: 98493
		[Token(Token = "0x4014B9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool IsVacant;

		// Token: 0x040180BE RID: 98494
		[Token(Token = "0x4014B9E")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181280", Offset = "0x181381")]
		private bool <IsSleeping>k__BackingField;

		// Token: 0x040180BF RID: 98495
		[Token(Token = "0x4014B9F")]
		[FieldOffset(Offset = "0x3C")]
		private int _HouseId;

		// Token: 0x040180C0 RID: 98496
		[Token(Token = "0x4014BA0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181290", Offset = "0x181391")]
		private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField;
	}
}
