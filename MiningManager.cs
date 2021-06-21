using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Farm;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200055B RID: 1371
[Token(Token = "0x20003E4")]
public class MiningManager : SingletonMonoBehaviour<MiningManager>
{
	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700045F")]
	public List<int> MeteorList
	{
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x22F6ED0", Offset = "0x22F6FD1", VA = "0x22F6ED0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x22F6F00", Offset = "0x22F7001", VA = "0x22F6F00")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x22F6FD0", Offset = "0x22F70D1", VA = "0x22F6FD0")]
	public void AddMiningPoint(MiningPointSaveData miningPointSaveData)
	{
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x22F7460", Offset = "0x22F7561", VA = "0x22F7460")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A06F0", Offset = "0x1A07F1")]
	public IEnumerator AddMiningPoint(MiningPoint miningPoint, string prefabName = "", [Optional] UnityAction<GameObject> callback)
	{
		return null;
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x22F7530", Offset = "0x22F7631", VA = "0x22F7530")]
	public List<MiningPointSaveData> GetMiningPoints(FarmManager.FARM_ID farmId)
	{
		return null;
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x0000D908 File Offset: 0x0000BB08
	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x22F7340", Offset = "0x22F7441", VA = "0x22F7340")]
	private int getMiningPointSaveDataTempIndex()
	{
		return 0;
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x22F7610", Offset = "0x22F7711", VA = "0x22F7610")]
	public void RemoveMiningPoint(MiningPoint miningPoint)
	{
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x22F7CF0", Offset = "0x22F7DF1", VA = "0x22F7CF0")]
	public void RemoveMiningPoint(MiningPointSaveData miningPointSaveData)
	{
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x22F7950", Offset = "0x22F7A51", VA = "0x22F7950")]
	private void tutorialWorking()
	{
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x0000D920 File Offset: 0x0000BB20
	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x22F83B0", Offset = "0x22F84B1", VA = "0x22F83B0")]
	public bool IsGomiZero()
	{
		return default(bool);
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x22F84D0", Offset = "0x22F85D1", VA = "0x22F84D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0760", Offset = "0x1A0861")]
	public IEnumerator LoadMiningPoint()
	{
		return null;
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x22F8550", Offset = "0x22F8651", VA = "0x22F8550")]
	public void LoadMiningPointSaveData()
	{
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x22F85F0", Offset = "0x22F86F1", VA = "0x22F85F0")]
	private void checkMiningPoint2Hour(int elapsedDay)
	{
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x22F86B0", Offset = "0x22F87B1", VA = "0x22F86B0")]
	private void checkMiningPoint2Day(int elapsedDay)
	{
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x22F87D0", Offset = "0x22F88D1", VA = "0x22F87D0")]
	private void lotteryMiningPoints()
	{
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x22F88C0", Offset = "0x22F89C1", VA = "0x22F88C0")]
	private void clearMeteorMiningPoints()
	{
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x22F8970", Offset = "0x22F8A71", VA = "0x22F8970")]
	public MiningPoint GetMiningPoint(MiningPointSaveData data)
	{
		return null;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x22F8A80", Offset = "0x22F8B81", VA = "0x22F8A80")]
	public List<MiningPoint> GetWorkAreaMiningPoints(int area)
	{
		return null;
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x22F8CA0", Offset = "0x22F8DA1", VA = "0x22F8CA0")]
	public List<MiningPointSaveData> GetWorkAreaMiningPointSaveDatas(FarmManager.FARM_ID farmID, int area)
	{
		return null;
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x0000D938 File Offset: 0x0000BB38
	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x22F8EA0", Offset = "0x22F8FA1", VA = "0x22F8EA0")]
	public bool CheckMiningPointAvailable(MiningPointSaveData miningPointSaveData)
	{
		return default(bool);
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x0000D950 File Offset: 0x0000BB50
	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x22F8FD0", Offset = "0x22F90D1", VA = "0x22F8FD0")]
	public MiningManager.MINING_MONSTER_TASK CanMiningAction(MiningPointSaveData miningPointSaveData)
	{
		return MiningManager.MINING_MONSTER_TASK.NONE;
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x0000D968 File Offset: 0x0000BB68
	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x22F9000", Offset = "0x22F9101", VA = "0x22F9000")]
	public bool DoMiningAction(MiningPointSaveData miningPointSaveData, Vector3 rotation)
	{
		return default(bool);
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x22F91C0", Offset = "0x22F92C1", VA = "0x22F91C0")]
	public void DestroyOnGroundItem(MiningPointSaveData miningPointSaveData)
	{
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x0000D980 File Offset: 0x0000BB80
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x22F71D0", Offset = "0x22F72D1", VA = "0x22F71D0")]
	public static int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x0000D998 File Offset: 0x0000BB98
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x22F8140", Offset = "0x22F8241", VA = "0x22F8140")]
	public static int PickupUniqueId(FarmManager.FARM_ID farmID, Vector3 position)
	{
		return 0;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x22F95D0", Offset = "0x22F96D1", VA = "0x22F95D0")]
	private void Start()
	{
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x22F9720", Offset = "0x22F9821", VA = "0x22F9720")]
	public MiningManager()
	{
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C55")]
	[Address(RVA = "0x22F9810", Offset = "0x22F9911", VA = "0x22F9810")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A07D0", Offset = "0x1A08D1")]
	private void <LoadMiningPoint>b__16_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x040067F0 RID: 26608
	[Token(Token = "0x40061D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<MiningPointSaveData> _miningPointSaveDatas;

	// Token: 0x040067F1 RID: 26609
	[Token(Token = "0x40061D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<MiningPoint> _farmMiningPoints;

	// Token: 0x040067F2 RID: 26610
	[Token(Token = "0x40061D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject _farmMineBasePrefab;

	// Token: 0x040067F3 RID: 26611
	[Token(Token = "0x40061D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<int, MineTypeID> FieldMiningAppearList;

	// Token: 0x040067F4 RID: 26612
	[Token(Token = "0x40061D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Weather latestWeather;

	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x2001100")]
	[Flags]
	public enum MINING_MONSTER_TASK
	{
		// Token: 0x040067F6 RID: 26614
		[Token(Token = "0x401928F")]
		NONE = 0,
		// Token: 0x040067F7 RID: 26615
		[Token(Token = "0x4019290")]
		MINE = 1,
		// Token: 0x040067F8 RID: 26616
		[Token(Token = "0x4019291")]
		CROP = 2,
		// Token: 0x040067F9 RID: 26617
		[Token(Token = "0x4019292")]
		ITEM = 4
	}

	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x2001101")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157DD0", Offset = "0x157ED1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FED")]
		[Address(RVA = "0x1D71430", Offset = "0x1D71531", VA = "0x1D71430")]
		public <>c()
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0x1D71440", Offset = "0x1D71541", VA = "0x1D71440")]
		internal int <AddMiningPoint>b__8_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0x1D71450", Offset = "0x1D71551", VA = "0x1D71450")]
		internal int <AddMiningPoint>b__9_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x1D71460", Offset = "0x1D71561", VA = "0x1D71460")]
		internal bool <getMiningPointSaveDataTempIndex>b__11_0(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x1D71490", Offset = "0x1D71591", VA = "0x1D71490")]
		internal int <RemoveMiningPoint>b__12_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x1D714A0", Offset = "0x1D715A1", VA = "0x1D714A0")]
		internal int <RemoveMiningPoint>b__13_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[Token(Token = "0x6006FF3")]
		[Address(RVA = "0x1D714B0", Offset = "0x1D715B1", VA = "0x1D714B0")]
		internal bool <IsGomiZero>b__15_0(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0x1D714D0", Offset = "0x1D715D1", VA = "0x1D714D0")]
		internal bool <GetWorkAreaMiningPoints>b__24_0(MiningPoint point)
		{
			return default(bool);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x1D71560", Offset = "0x1D71661", VA = "0x1D71560")]
		internal int <CheckMiningPointAvailable>b__26_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x1D71570", Offset = "0x1D71671", VA = "0x1D71570")]
		internal int <GetUniqueId>b__30_0(MiningPointSaveData dat)
		{
			return 0;
		}

		// Token: 0x040067FA RID: 26618
		[Token(Token = "0x4019293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MiningManager.<>c <>9;

		// Token: 0x040067FB RID: 26619
		[Token(Token = "0x4019294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MiningPointSaveData, int> <>9__8_0;

		// Token: 0x040067FC RID: 26620
		[Token(Token = "0x4019295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<MiningPointSaveData, int> <>9__9_0;

		// Token: 0x040067FD RID: 26621
		[Token(Token = "0x4019296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<MiningPointSaveData> <>9__11_0;

		// Token: 0x040067FE RID: 26622
		[Token(Token = "0x4019297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<MiningPointSaveData, int> <>9__12_0;

		// Token: 0x040067FF RID: 26623
		[Token(Token = "0x4019298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<MiningPointSaveData, int> <>9__13_0;

		// Token: 0x04006800 RID: 26624
		[Token(Token = "0x4019299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<MiningPointSaveData, bool> <>9__15_0;

		// Token: 0x04006801 RID: 26625
		[Token(Token = "0x401929A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<MiningPoint> <>9__24_0;

		// Token: 0x04006802 RID: 26626
		[Token(Token = "0x401929B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<MiningPointSaveData, int> <>9__26_0;

		// Token: 0x04006803 RID: 26627
		[Token(Token = "0x401929C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<MiningPointSaveData, int> <>9__30_0;
	}

	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x2001102")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157DE0", Offset = "0x157EE1")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x1D71970", Offset = "0x1D71A71", VA = "0x1D71970")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0x1D71980", Offset = "0x1D71A81", VA = "0x1D71980")]
		internal void <AddMiningPoint>b__1(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04006804 RID: 26628
		[Token(Token = "0x401929D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject prefabOrg;
	}

	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x2001103")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157DF0", Offset = "0x157EF1")]
	private sealed class <AddMiningPoint>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF9")]
		[Address(RVA = "0x1D71A00", Offset = "0x1D71B01", VA = "0x1D71A00")]
		[DebuggerHidden]
		public <AddMiningPoint>d__9(int <>1__state)
		{
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0x1D71A30", Offset = "0x1D71B31", VA = "0x1D71A30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x6006FFB")]
		[Address(RVA = "0x1D71A40", Offset = "0x1D71B41", VA = "0x1D71A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC5")]
		private object Current
		{
			[Token(Token = "0x6006FFC")]
			[Address(RVA = "0x1D71EF0", Offset = "0x1D71FF1", VA = "0x1D71EF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0x1D71F00", Offset = "0x1D72001", VA = "0x1D71F00", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC6")]
		private object Current
		{
			[Token(Token = "0x6006FFE")]
			[Address(RVA = "0x1D71F60", Offset = "0x1D72061", VA = "0x1D71F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006805 RID: 26629
		[Token(Token = "0x401929E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006806 RID: 26630
		[Token(Token = "0x401929F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006807 RID: 26631
		[Token(Token = "0x40192A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiningPoint miningPoint;

		// Token: 0x04006808 RID: 26632
		[Token(Token = "0x40192A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MiningManager <>4__this;

		// Token: 0x04006809 RID: 26633
		[Token(Token = "0x40192A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string prefabName;

		// Token: 0x0400680A RID: 26634
		[Token(Token = "0x40192A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MiningManager.<>c__DisplayClass9_0 <>8__1;

		// Token: 0x0400680B RID: 26635
		[Token(Token = "0x40192A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityAction<GameObject> callback;
	}

	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2001104")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E00", Offset = "0x157F01")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0x1D71580", Offset = "0x1D71681", VA = "0x1D71580")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x6007000")]
		[Address(RVA = "0x1D71590", Offset = "0x1D71691", VA = "0x1D71590")]
		internal bool <GetMiningPoints>b__0(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x0400680C RID: 26636
		[Token(Token = "0x40192A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FarmManager.FARM_ID farmId;
	}

	// Token: 0x02000561 RID: 1377
	[Token(Token = "0x2001105")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E10", Offset = "0x157F11")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x0600216C RID: 8556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007001")]
		[Address(RVA = "0x1D715E0", Offset = "0x1D716E1", VA = "0x1D715E0")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[Token(Token = "0x6007002")]
		[Address(RVA = "0x1D715F0", Offset = "0x1D716F1", VA = "0x1D715F0")]
		internal bool <RemoveMiningPoint>b__1(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		[Token(Token = "0x6007003")]
		[Address(RVA = "0x1D71620", Offset = "0x1D71721", VA = "0x1D71620")]
		internal bool <RemoveMiningPoint>b__2(MiningPoint dat)
		{
			return default(bool);
		}

		// Token: 0x0400680D RID: 26637
		[Token(Token = "0x40192A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MiningPoint miningPoint;
	}

	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2001106")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E20", Offset = "0x157F21")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x0600216F RID: 8559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007004")]
		[Address(RVA = "0x1D71650", Offset = "0x1D71751", VA = "0x1D71650")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		[Token(Token = "0x6007005")]
		[Address(RVA = "0x1D71660", Offset = "0x1D71761", VA = "0x1D71660")]
		internal bool <RemoveMiningPoint>b__1(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x6007006")]
		[Address(RVA = "0x1D71680", Offset = "0x1D71781", VA = "0x1D71680")]
		internal bool <RemoveMiningPoint>b__2(MiningPoint dat)
		{
			return default(bool);
		}

		// Token: 0x0400680E RID: 26638
		[Token(Token = "0x40192A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MiningPointSaveData miningPointSaveData;
	}

	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2001107")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E30", Offset = "0x157F31")]
	private sealed class <LoadMiningPoint>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007007")]
		[Address(RVA = "0x1D71F70", Offset = "0x1D72071", VA = "0x1D71F70")]
		[DebuggerHidden]
		public <LoadMiningPoint>d__16(int <>1__state)
		{
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007008")]
		[Address(RVA = "0x1D71FA0", Offset = "0x1D720A1", VA = "0x1D71FA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x6007009")]
		[Address(RVA = "0x1D71FB0", Offset = "0x1D720B1", VA = "0x1D71FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC7")]
		private object Current
		{
			[Token(Token = "0x600700A")]
			[Address(RVA = "0x1D725D0", Offset = "0x1D726D1", VA = "0x1D725D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700B")]
		[Address(RVA = "0x1D725E0", Offset = "0x1D726E1", VA = "0x1D725E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC8")]
		private object Current
		{
			[Token(Token = "0x600700C")]
			[Address(RVA = "0x1D72640", Offset = "0x1D72741", VA = "0x1D72640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400680F RID: 26639
		[Token(Token = "0x40192A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006810 RID: 26640
		[Token(Token = "0x40192A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006811 RID: 26641
		[Token(Token = "0x40192AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MiningManager <>4__this;
	}

	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2001108")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E40", Offset = "0x157F41")]
	private sealed class <>c__DisplayClass23_0
	{
		// Token: 0x06002178 RID: 8568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700D")]
		[Address(RVA = "0x1D716B0", Offset = "0x1D717B1", VA = "0x1D716B0")]
		public <>c__DisplayClass23_0()
		{
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x600700E")]
		[Address(RVA = "0x1D716C0", Offset = "0x1D717C1", VA = "0x1D716C0")]
		internal bool <GetMiningPoint>b__0(MiningPoint t)
		{
			return default(bool);
		}

		// Token: 0x04006812 RID: 26642
		[Token(Token = "0x40192AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MiningPointSaveData data;
	}

	// Token: 0x02000565 RID: 1381
	[Token(Token = "0x2001109")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E50", Offset = "0x157F51")]
	private sealed class <>c__DisplayClass24_0
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700F")]
		[Address(RVA = "0x1D71770", Offset = "0x1D71871", VA = "0x1D71770")]
		public <>c__DisplayClass24_0()
		{
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6007010")]
		[Address(RVA = "0x1D71780", Offset = "0x1D71881", VA = "0x1D71780")]
		internal bool <GetWorkAreaMiningPoints>b__1(MiningPoint dat)
		{
			return default(bool);
		}

		// Token: 0x04006813 RID: 26643
		[Token(Token = "0x40192AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MiningPointSaveData> miningPointSaveDatas;
	}

	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x200110A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E60", Offset = "0x157F61")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x0600217C RID: 8572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007011")]
		[Address(RVA = "0x1D718C0", Offset = "0x1D719C1", VA = "0x1D718C0")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x6007012")]
		[Address(RVA = "0x1D718D0", Offset = "0x1D719D1", VA = "0x1D718D0")]
		internal bool <GetWorkAreaMiningPointSaveDatas>b__0(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x04006814 RID: 26644
		[Token(Token = "0x40192AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float offset;

		// Token: 0x04006815 RID: 26645
		[Token(Token = "0x40192AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float separate;
	}

	// Token: 0x02000567 RID: 1383
	[Token(Token = "0x200110B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E70", Offset = "0x157F71")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x0600217E RID: 8574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007013")]
		[Address(RVA = "0x1D71900", Offset = "0x1D71A01", VA = "0x1D71900")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6007014")]
		[Address(RVA = "0x1D71910", Offset = "0x1D71A11", VA = "0x1D71910")]
		internal bool <DestroyOnGroundItem>b__0(OnGroundItem dat)
		{
			return default(bool);
		}

		// Token: 0x04006816 RID: 26646
		[Token(Token = "0x40192AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MiningPointSaveData miningPointSaveData;
	}

	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x200110C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157E80", Offset = "0x157F81")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x06002180 RID: 8576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007015")]
		[Address(RVA = "0x1D71940", Offset = "0x1D71A41", VA = "0x1D71940")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6007016")]
		[Address(RVA = "0x1D71950", Offset = "0x1D71A51", VA = "0x1D71950")]
		internal bool <PickupUniqueId>b__0(MiningPointSaveData dat)
		{
			return default(bool);
		}

		// Token: 0x04006817 RID: 26647
		[Token(Token = "0x40192B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FarmManager.FARM_ID farmID;
	}
}
