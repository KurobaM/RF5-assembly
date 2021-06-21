using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EF RID: 239
[Token(Token = "0x20000BF")]
public class FriendMonsterManager : MonoBehaviour
{
	// Token: 0x17000134 RID: 308
	// (get) Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012E")]
	private List<FriendMonsterStatusData> StatusDataList
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1ED9620", Offset = "0x1ED9721", VA = "0x1ED9620")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700012F")]
	public static List<FriendMonsterStatusData> FriendMonsterStatusDatas
	{
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1ED9650", Offset = "0x1ED9751", VA = "0x1ED9650")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000130")]
	public static Dictionary<uint, FriendMonsterStatus> FriendMonsters
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1ED96C0", Offset = "0x1ED97C1", VA = "0x1ED96C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1ED9720", Offset = "0x1ED9821", VA = "0x1ED9720")]
	public static void InitializeForLoadGame()
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00003DE0 File Offset: 0x00001FE0
	[Token(Token = "0x600044C")]
	[Address(RVA = "0x1ED99B0", Offset = "0x1ED9AB1", VA = "0x1ED99B0")]
	public static int EmptyCount()
	{
		return 0;
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00003DF8 File Offset: 0x00001FF8
	[Token(Token = "0x600044D")]
	[Address(RVA = "0x1ED9A10", Offset = "0x1ED9B11", VA = "0x1ED9A10")]
	public static int SameMonsterCount(MonsterID monsterID)
	{
		return 0;
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00003E10 File Offset: 0x00002010
	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1ED9B80", Offset = "0x1ED9C81", VA = "0x1ED9B80")]
	public static uint JoinIn(string name, EnemyStatusData mosterStatusData)
	{
		return 0U;
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1ED9D50", Offset = "0x1ED9E51", VA = "0x1ED9D50")]
	public static void Leave(uint id)
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1ED9F20", Offset = "0x1EDA021", VA = "0x1ED9F20")]
	public static void FarmIn(FarmManager.FARM_ID farmId, int houseId, [Optional] Action<uint, ActorID> callback)
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x1EDA370", Offset = "0x1EDA471", VA = "0x1EDA370")]
	public static void FarmOut()
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000452")]
	[Address(RVA = "0x1EDA5F0", Offset = "0x1EDA6F1", VA = "0x1EDA5F0")]
	public static void FarmIn(uint dataId, [Optional] Action<uint, ActorID> callback)
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x1EDAA40", Offset = "0x1EDAB41", VA = "0x1EDAA40")]
	public static void FarmOut(uint dataId, bool isPlayEffect = false)
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00003E28 File Offset: 0x00002028
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x1EDAD70", Offset = "0x1EDAE71", VA = "0x1EDAD70")]
	public static int OneDayEsaCost()
	{
		return 0;
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000455")]
	[Address(RVA = "0x1EDAFA0", Offset = "0x1EDB0A1", VA = "0x1EDAFA0")]
	public void Morning()
	{
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000529 RID: 1321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000131")]
	public static FriendMonsterManager Instance
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1EDB900", Offset = "0x1EDBA01", VA = "0x1EDB900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A450", Offset = "0x19A551")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1EDB950", Offset = "0x1EDBA51", VA = "0x1EDB950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A460", Offset = "0x19A561")]
		private set
		{
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x1EDB9B0", Offset = "0x1EDBAB1", VA = "0x1EDB9B0")]
	private void Awake()
	{
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1ED9780", Offset = "0x1ED9881", VA = "0x1ED9780")]
	public void LoadInit()
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00003E40 File Offset: 0x00002040
	[Token(Token = "0x600045A")]
	[Address(RVA = "0x1EDBA20", Offset = "0x1EDBB21", VA = "0x1EDBA20")]
	private uint GetNextId()
	{
		return 0U;
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x600045B")]
	[Address(RVA = "0x1ED9C00", Offset = "0x1ED9D01", VA = "0x1ED9C00")]
	private uint Create(string name, EnemyStatusData mosterStatusData)
	{
		return 0U;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x1ED9DC0", Offset = "0x1ED9EC1", VA = "0x1ED9DC0")]
	private void Release(uint dataId)
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1EDBAD0", Offset = "0x1EDBBD1", VA = "0x1EDBAD0")]
	private void CreateMonster(uint dataId, ActorID actorId)
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x1EDA670", Offset = "0x1EDA771", VA = "0x1EDA670")]
	private bool FarmInCreate(uint dataId, Action<uint, ActorID> callback)
	{
		return default(bool);
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1ED9FA0", Offset = "0x1EDA0A1", VA = "0x1ED9FA0")]
	private void FarmInCreate(FarmManager.FARM_ID farmId, int houseId, Action<uint, ActorID> callback)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1EDAAC0", Offset = "0x1EDABC1", VA = "0x1EDAAC0")]
	private void FarmOutDelete(uint dataId, bool isPlayEffect = false)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1EDA3D0", Offset = "0x1EDA4D1", VA = "0x1EDA3D0")]
	private void FarmOutDelete()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1EDBBD0", Offset = "0x1EDBCD1", VA = "0x1EDBBD0")]
	private void Update()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1EDBDE0", Offset = "0x1EDBEE1", VA = "0x1EDBDE0")]
	private void OnDayCarry(int days)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1EDBF30", Offset = "0x1EDC031", VA = "0x1EDBF30")]
	public FriendMonsterManager()
	{
	}

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<uint, FriendMonsterStatus> StatusList;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BAA0", Offset = "0x15BBA1")]
	private static FriendMonsterManager <Instance>k__BackingField;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<FriendMonsterManager.FarmInActorData> FarmInActorList;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action<uint, ActorID> FarmInCallback;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool IsBusy;

	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x2000FBA")]
	private class FarmInActorData
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBD")]
		[Address(RVA = "0x23CD600", Offset = "0x23CD701", VA = "0x23CD600")]
		public FarmInActorData()
		{
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x4018D10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint DataId;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x4018D11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ActorID actorId;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x4018D12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsLoaded;
	}

	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x2000FBB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570A0", Offset = "0x1571A1")]
	private sealed class <>c__DisplayClass30_0
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BBE")]
		[Address(RVA = "0x23CD550", Offset = "0x23CD651", VA = "0x23CD550")]
		public <>c__DisplayClass30_0()
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x6006BBF")]
		[Address(RVA = "0x23CD560", Offset = "0x23CD661", VA = "0x23CD560")]
		internal bool <Release>b__0(FriendMonsterStatusData p)
		{
			return default(bool);
		}

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x4018D13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint dataId;
	}

	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x2000FBC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1570B0", Offset = "0x1571B1")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x23CD590", Offset = "0x23CD691", VA = "0x23CD590")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BC1")]
		[Address(RVA = "0x23CD5A0", Offset = "0x23CD6A1", VA = "0x23CD5A0")]
		internal void <FarmOutDelete>b__0()
		{
		}

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x4018D14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;
	}
}
