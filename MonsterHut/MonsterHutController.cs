using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

namespace MonsterHut
{
	// Token: 0x02000EFC RID: 3836
	[Token(Token = "0x20009D3")]
	public class MonsterHutController : MonoBehaviour
	{
		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060064A8 RID: 25768 RVA: 0x00021B10 File Offset: 0x0001FD10
		// (set) Token: 0x060064A7 RID: 25767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4C")]
		public FarmManager.FARM_ID FarmId
		{
			[Token(Token = "0x60053AE")]
			[Address(RVA = "0x1E619F0", Offset = "0x1E61AF1", VA = "0x1E619F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACBE0", Offset = "0x1ACCE1")]
			get
			{
				return FarmManager.FARM_ID.RF4_FREEFARM_ID_Village;
			}
			[Token(Token = "0x60053AD")]
			[Address(RVA = "0x1E619E0", Offset = "0x1E61AE1", VA = "0x1E619E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACBD0", Offset = "0x1ACCD1")]
			set
			{
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060064AA RID: 25770 RVA: 0x00021B28 File Offset: 0x0001FD28
		// (set) Token: 0x060064A9 RID: 25769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4D")]
		public int MonsterHutPlaceId
		{
			[Token(Token = "0x60053B0")]
			[Address(RVA = "0x1E61A10", Offset = "0x1E61B11", VA = "0x1E61A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACC00", Offset = "0x1ACD01")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60053AF")]
			[Address(RVA = "0x1E61A00", Offset = "0x1E61B01", VA = "0x1E61A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACBF0", Offset = "0x1ACCF1")]
			set
			{
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060064AC RID: 25772 RVA: 0x00021B40 File Offset: 0x0001FD40
		// (set) Token: 0x060064AB RID: 25771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4E")]
		public int AreaReleaseState
		{
			[Token(Token = "0x60053B2")]
			[Address(RVA = "0x1E61A30", Offset = "0x1E61B31", VA = "0x1E61A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACC20", Offset = "0x1ACD21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60053B1")]
			[Address(RVA = "0x1E61A20", Offset = "0x1E61B21", VA = "0x1E61A20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACC10", Offset = "0x1ACD11")]
			set
			{
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x00021B58 File Offset: 0x0001FD58
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4F")]
		public int CurrentPlayerArea
		{
			[Token(Token = "0x60053B3")]
			[Address(RVA = "0x1E61A40", Offset = "0x1E61B41", VA = "0x1E61A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACC30", Offset = "0x1ACD31")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0x1E61A50", Offset = "0x1E61B51", VA = "0x1E61A50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACC40", Offset = "0x1ACD41")]
			private set
			{
			}
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00021B70 File Offset: 0x0001FD70
		[Token(Token = "0x60053B5")]
		[Address(RVA = "0x1E61A60", Offset = "0x1E61B61", VA = "0x1E61A60")]
		public ActorID GetActorID(uint friendMonsterDataId)
		{
			return ActorID.act000;
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00021B88 File Offset: 0x0001FD88
		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x1E61B00", Offset = "0x1E61C01", VA = "0x1E61B00")]
		public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData)
		{
			return default(bool);
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x1E61B60", Offset = "0x1E61C61", VA = "0x1E61B60")]
		private void ResetOrderList()
		{
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x1E61BD0", Offset = "0x1E61CD1", VA = "0x1E61BD0")]
		public void Initialize()
		{
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x1E61DB0", Offset = "0x1E61EB1", VA = "0x1E61DB0")]
		public void SetAreas()
		{
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x1E62C90", Offset = "0x1E62D91", VA = "0x1E62C90")]
		private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId)
		{
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x1E62E80", Offset = "0x1E62F81", VA = "0x1E62E80")]
		private void FarmInCallBack(uint monsterId, ActorID actorId)
		{
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x1E626E0", Offset = "0x1E627E1", VA = "0x1E626E0")]
		public void SetMonsters()
		{
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0x1E63100", Offset = "0x1E63201", VA = "0x1E63100")]
		public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack)
		{
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x1E63250", Offset = "0x1E63351", VA = "0x1E63250")]
		public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack)
		{
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x1E633B0", Offset = "0x1E634B1", VA = "0x1E633B0")]
		public void UpdateOrderFarmInList()
		{
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x1E634B0", Offset = "0x1E635B1", VA = "0x1E634B0")]
		public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = true, bool isPlayEffect = false)
		{
			return default(bool);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x1E63000", Offset = "0x1E63101", VA = "0x1E63000")]
		public void ResetFarmAIs()
		{
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x1E63640", Offset = "0x1E63741", VA = "0x1E63640")]
		private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea)
		{
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x1E637F0", Offset = "0x1E638F1", VA = "0x1E637F0")]
		public void OnPlayerEnterArea(int areaIndex)
		{
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x1E638B0", Offset = "0x1E639B1", VA = "0x1E638B0")]
		private void OnBeginTeleport()
		{
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x1E639F0", Offset = "0x1E63AF1", VA = "0x1E639F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x1E63AF0", Offset = "0x1E63BF1", VA = "0x1E63AF0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ACC50", Offset = "0x1ACD51")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C7")]
		[Address(RVA = "0x1E63BA0", Offset = "0x1E63CA1", VA = "0x1E63BA0")]
		private void Update()
		{
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x1E63BB0", Offset = "0x1E63CB1", VA = "0x1E63BB0")]
		public MonsterHutController()
		{
		}

		// Token: 0x0400C464 RID: 50276
		[Token(Token = "0x40092F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GameObject> HutAreas;

		// Token: 0x0400C465 RID: 50277
		[Token(Token = "0x40092F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MonsterHutArea> MonsterAreas;

		// Token: 0x0400C466 RID: 50278
		[Token(Token = "0x40092F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> Doors;

		// Token: 0x0400C467 RID: 50279
		[Token(Token = "0x40092FA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F460", Offset = "0x17F561")]
		private FarmManager.FARM_ID <FarmId>k__BackingField;

		// Token: 0x0400C468 RID: 50280
		[Token(Token = "0x40092FB")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F470", Offset = "0x17F571")]
		private int <MonsterHutPlaceId>k__BackingField;

		// Token: 0x0400C469 RID: 50281
		[Token(Token = "0x40092FC")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F480", Offset = "0x17F581")]
		private int <AreaReleaseState>k__BackingField;

		// Token: 0x0400C46A RID: 50282
		[Token(Token = "0x40092FD")]
		[FieldOffset(Offset = "0x40")]
		private MonsterHutSaveData monsterHutSaveData;

		// Token: 0x0400C46B RID: 50283
		[Token(Token = "0x40092FE")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic;

		// Token: 0x0400C46C RID: 50284
		[Token(Token = "0x40092FF")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic;

		// Token: 0x0400C46D RID: 50285
		[Token(Token = "0x4009300")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F490", Offset = "0x17F591")]
		private int <CurrentPlayerArea>k__BackingField;

		// Token: 0x0400C46E RID: 50286
		[Token(Token = "0x4009301")]
		[FieldOffset(Offset = "0x80")]
		private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList;

		// Token: 0x0400C46F RID: 50287
		[Token(Token = "0x4009302")]
		[FieldOffset(Offset = "0x88")]
		private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam;

		// Token: 0x0400C470 RID: 50288
		[Token(Token = "0x4009303")]
		[FieldOffset(Offset = "0x90")]
		private bool IsCreating;

		// Token: 0x0400C471 RID: 50289
		[Token(Token = "0x4009304")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<OnGroundItem, int> yieldItemList;

		// Token: 0x02000EFD RID: 3837
		[Token(Token = "0x2001495")]
		public class OrderFarmInParameter
		{
			// Token: 0x060064C3 RID: 25795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA9")]
			[Address(RVA = "0x1E633A0", Offset = "0x1E634A1", VA = "0x1E633A0")]
			public OrderFarmInParameter()
			{
			}

			// Token: 0x0400C472 RID: 50290
			[Token(Token = "0x401BD79")]
			[FieldOffset(Offset = "0x10")]
			public uint FriendMonsterId;

			// Token: 0x0400C473 RID: 50291
			[Token(Token = "0x401BD7A")]
			[FieldOffset(Offset = "0x14")]
			public int RoomId;

			// Token: 0x0400C474 RID: 50292
			[Token(Token = "0x401BD7B")]
			[FieldOffset(Offset = "0x18")]
			public Action<uint, ActorID> CallBack;
		}

		// Token: 0x02000EFE RID: 3838
		[Token(Token = "0x2001496")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B00", Offset = "0x159C01")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x060064C4 RID: 25796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BAA")]
			[Address(RVA = "0x1E627A0", Offset = "0x1E628A1", VA = "0x1E627A0")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x060064C5 RID: 25797 RVA: 0x00021BB8 File Offset: 0x0001FDB8
			[Token(Token = "0x6007BAB")]
			[Address(RVA = "0x1E63CB0", Offset = "0x1E63DB1", VA = "0x1E63CB0")]
			internal bool <SetAreas>b__0(FriendMonsterIDAndHouseID id)
			{
				return default(bool);
			}

			// Token: 0x0400C475 RID: 50293
			[Token(Token = "0x401BD7C")]
			[FieldOffset(Offset = "0x10")]
			public int i;
		}

		// Token: 0x02000EFF RID: 3839
		[Token(Token = "0x2001497")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B10", Offset = "0x159C11")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x060064C6 RID: 25798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BAC")]
			[Address(RVA = "0x1E63240", Offset = "0x1E63341", VA = "0x1E63240")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x060064C7 RID: 25799 RVA: 0x00021BD0 File Offset: 0x0001FDD0
			[Token(Token = "0x6007BAD")]
			[Address(RVA = "0x1E63CE0", Offset = "0x1E63DE1", VA = "0x1E63CE0")]
			internal bool <AddMonster>b__0(FriendMonsterIDAndHouseID d)
			{
				return default(bool);
			}

			// Token: 0x0400C476 RID: 50294
			[Token(Token = "0x401BD7D")]
			[FieldOffset(Offset = "0x10")]
			public uint friendMonsterDataID;
		}

		// Token: 0x02000F00 RID: 3840
		[Token(Token = "0x2001498")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B20", Offset = "0x159C21")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x060064C8 RID: 25800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BAE")]
			[Address(RVA = "0x1E63390", Offset = "0x1E63491", VA = "0x1E63390")]
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x060064C9 RID: 25801 RVA: 0x00021BE8 File Offset: 0x0001FDE8
			[Token(Token = "0x6007BAF")]
			[Address(RVA = "0x1E63D10", Offset = "0x1E63E11", VA = "0x1E63D10")]
			internal bool <OrderFarmIn>b__0(MonsterHutController.OrderFarmInParameter param)
			{
				return default(bool);
			}

			// Token: 0x0400C477 RID: 50295
			[Token(Token = "0x401BD7E")]
			[FieldOffset(Offset = "0x10")]
			public uint friendMonsterDataID;
		}

		// Token: 0x02000F01 RID: 3841
		[Token(Token = "0x2001499")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B30", Offset = "0x159C31")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x060064CA RID: 25802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BB0")]
			[Address(RVA = "0x1E63630", Offset = "0x1E63731", VA = "0x1E63630")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x060064CB RID: 25803 RVA: 0x00021C00 File Offset: 0x0001FE00
			[Token(Token = "0x6007BB1")]
			[Address(RVA = "0x1E63D40", Offset = "0x1E63E41", VA = "0x1E63D40")]
			internal bool <RemoveMonster>b__0(FriendMonsterIDAndHouseID d)
			{
				return default(bool);
			}

			// Token: 0x0400C478 RID: 50296
			[Token(Token = "0x401BD7F")]
			[FieldOffset(Offset = "0x10")]
			public uint friendMonsterDataID;
		}

		// Token: 0x02000F02 RID: 3842
		[Token(Token = "0x200149A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159B40", Offset = "0x159C41")]
		private sealed class <Start>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060064CC RID: 25804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BB2")]
			[Address(RVA = "0x1E63B70", Offset = "0x1E63C71", VA = "0x1E63B70")]
			[DebuggerHidden]
			public <Start>d__44(int <>1__state)
			{
			}

			// Token: 0x060064CD RID: 25805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BB3")]
			[Address(RVA = "0x1E63D70", Offset = "0x1E63E71", VA = "0x1E63D70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060064CE RID: 25806 RVA: 0x00021C18 File Offset: 0x0001FE18
			[Token(Token = "0x6007BB4")]
			[Address(RVA = "0x1E63D80", Offset = "0x1E63E81", VA = "0x1E63D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x060064CF RID: 25807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7B")]
			private object Current
			{
				[Token(Token = "0x6007BB5")]
				[Address(RVA = "0x1E63F80", Offset = "0x1E64081", VA = "0x1E63F80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060064D0 RID: 25808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BB6")]
			[Address(RVA = "0x1E63F90", Offset = "0x1E64091", VA = "0x1E63F90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x060064D1 RID: 25809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7C")]
			private object Current
			{
				[Token(Token = "0x6007BB7")]
				[Address(RVA = "0x1E63FF0", Offset = "0x1E640F1", VA = "0x1E63FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400C479 RID: 50297
			[Token(Token = "0x401BD80")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400C47A RID: 50298
			[Token(Token = "0x401BD81")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400C47B RID: 50299
			[Token(Token = "0x401BD82")]
			[FieldOffset(Offset = "0x20")]
			public MonsterHutController <>4__this;
		}
	}
}
