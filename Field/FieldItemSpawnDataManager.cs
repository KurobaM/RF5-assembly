using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001120 RID: 4384
	[Token(Token = "0x2000B08")]
	public class FieldItemSpawnDataManager : SingletonMonoBehaviour<FieldItemSpawnDataManager>
	{
		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EC7 RID: 28359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFF")]
		public HashSet<FieldItemSpawnID> ExistSpawnIDHashSet
		{
			[Token(Token = "0x6005BD4")]
			[Address(RVA = "0x1F833B0", Offset = "0x1F834B1", VA = "0x1F833B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BD5")]
			[Address(RVA = "0x1F833C0", Offset = "0x1F834C1", VA = "0x1F833C0")]
			private set
			{
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B00")]
		public HashSet<FieldHideItemSpawnID> ExistHideSpawnIDHashSet
		{
			[Token(Token = "0x6005BD6")]
			[Address(RVA = "0x1F833D0", Offset = "0x1F834D1", VA = "0x1F833D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BD7")]
			[Address(RVA = "0x1F833E0", Offset = "0x1F834E1", VA = "0x1F833E0")]
			private set
			{
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x000260E8 File Offset: 0x000242E8
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B01")]
		public bool IsSceneChangeCheckEnd
		{
			[Token(Token = "0x6005BD8")]
			[Address(RVA = "0x1F833F0", Offset = "0x1F834F1", VA = "0x1F833F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE40", Offset = "0x1AEF41")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005BD9")]
			[Address(RVA = "0x1F83400", Offset = "0x1F83501", VA = "0x1F83400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE50", Offset = "0x1AEF51")]
			private set
			{
			}
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00026100 File Offset: 0x00024300
		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x1F83410", Offset = "0x1F83511", VA = "0x1F83410")]
		public bool IsDetectHideItemParties(int index = 0)
		{
			return default(bool);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x1F83450", Offset = "0x1F83551", VA = "0x1F83450")]
		public static FieldItemSpawnDataTableArray GetDataTableArray()
		{
			return null;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x1F834B0", Offset = "0x1F835B1", VA = "0x1F834B0")]
		public static FieldItemSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x00026118 File Offset: 0x00024318
		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x1F83510", Offset = "0x1F83611", VA = "0x1F83510")]
		public static FieldItemSpawnDataTable GetDataTable(FieldItemSpawnID id)
		{
			return default(FieldItemSpawnDataTable);
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00026130 File Offset: 0x00024330
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x1F82EE0", Offset = "0x1F82FE1", VA = "0x1F82EE0")]
		public static FieldHideItemSpawnDataTable GetDataTable(FieldHideItemSpawnID id)
		{
			return default(FieldHideItemSpawnDataTable);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x1F835D0", Offset = "0x1F836D1", VA = "0x1F835D0")]
		public void InitializeLoad()
		{
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x1F83660", Offset = "0x1F83761", VA = "0x1F83660")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEE60", Offset = "0x1AEF61")]
		public IEnumerator LoadDataTable()
		{
			return null;
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x1F83710", Offset = "0x1F83811", VA = "0x1F83710")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0x1F83AE0", Offset = "0x1F83BE1", VA = "0x1F83AE0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x1F83BB0", Offset = "0x1F83CB1", VA = "0x1F83BB0")]
		private void Update()
		{
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00026148 File Offset: 0x00024348
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x1F83F70", Offset = "0x1F84071", VA = "0x1F83F70")]
		private static bool Lottery(int weight)
		{
			return default(bool);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x1F83FB0", Offset = "0x1F840B1", VA = "0x1F83FB0")]
		public void OnAfterGameDataLoad()
		{
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x1F84150", Offset = "0x1F84251", VA = "0x1F84150")]
		public static void OnDayChangeSetFieldFlag(int elapsedDay = 1)
		{
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x1F84260", Offset = "0x1F84361", VA = "0x1F84260")]
		public void OnSceneChangeSetFieldFlag()
		{
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x1F84330", Offset = "0x1F84431", VA = "0x1F84330")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AEED0", Offset = "0x1AEFD1")]
		private IEnumerator CheckSceneItem()
		{
			return null;
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00026160 File Offset: 0x00024360
		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x1F843E0", Offset = "0x1F844E1", VA = "0x1F843E0")]
		public bool AddOnGroundItem(OnGroundItem onGroundItem, FieldItemSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00026178 File Offset: 0x00024378
		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x1F844C0", Offset = "0x1F845C1", VA = "0x1F844C0")]
		public bool RemoveOnGroundItem(OnGroundItem onGroundItem, bool setFlag = false)
		{
			return default(bool);
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00026190 File Offset: 0x00024390
		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x1F84860", Offset = "0x1F84961", VA = "0x1F84860")]
		public bool OnGroundItemExists(OnGroundItem onGroundItem)
		{
			return default(bool);
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x000261A8 File Offset: 0x000243A8
		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x1F82F70", Offset = "0x1F83071", VA = "0x1F82F70")]
		public bool AddHideOnGroundItem(OnGroundItem onGroundItem, FieldHideItemSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x000261C0 File Offset: 0x000243C0
		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x1F846D0", Offset = "0x1F847D1", VA = "0x1F846D0")]
		public bool RemoveHideOnGroundItem(OnGroundItem onGroundItem, bool setFlag = false)
		{
			return default(bool);
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x000261D8 File Offset: 0x000243D8
		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x1F84A10", Offset = "0x1F84B11", VA = "0x1F84A10")]
		public bool HideOnGroundItemExists(OnGroundItem onGroundItem)
		{
			return default(bool);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x000261F0 File Offset: 0x000243F0
		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x1F84B80", Offset = "0x1F84C81", VA = "0x1F84B80")]
		public bool FieldItemSpawnIDExists(FieldItemSpawnID fieldItemSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x00026208 File Offset: 0x00024408
		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0x1F82D70", Offset = "0x1F82E71", VA = "0x1F82D70")]
		public bool FieldHideItemSpawnIDExists(FieldHideItemSpawnID spawnID)
		{
			return default(bool);
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0x1F842F0", Offset = "0x1F843F1", VA = "0x1F842F0")]
		public static void SetFieldItemSpawnFlag(FieldItemSpawnID id, bool value)
		{
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x00026220 File Offset: 0x00024420
		[Token(Token = "0x6005BF2")]
		[Address(RVA = "0x1F84C00", Offset = "0x1F84D01", VA = "0x1F84C00")]
		public static bool GetFieldItemSpawnFlag(FieldItemSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF3")]
		[Address(RVA = "0x1F84930", Offset = "0x1F84A31", VA = "0x1F84930")]
		public static void SetFieldHideItemSpawnFlag(FieldHideItemSpawnID id, bool value)
		{
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x00026238 File Offset: 0x00024438
		[Token(Token = "0x6005BF4")]
		[Address(RVA = "0x1F82DF0", Offset = "0x1F82EF1", VA = "0x1F82DF0")]
		public static bool GetFieldHideItemSpawnFlag(FieldHideItemSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x00026250 File Offset: 0x00024450
		[Token(Token = "0x6005BF5")]
		[Address(RVA = "0x1F82D00", Offset = "0x1F82E01", VA = "0x1F82D00")]
		public static bool IsRestrictSpawn()
		{
			return default(bool);
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x00026268 File Offset: 0x00024468
		[Token(Token = "0x6005BF6")]
		[Address(RVA = "0x1F84C40", Offset = "0x1F84D41", VA = "0x1F84C40")]
		public bool AddItemSpawner(FieldItemSpawner itemSpawner)
		{
			return default(bool);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x00026280 File Offset: 0x00024480
		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x1F84D00", Offset = "0x1F84E01", VA = "0x1F84D00")]
		public bool RemoveItemSpawner(FieldItemSpawner itemSpawner)
		{
			return default(bool);
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x00026298 File Offset: 0x00024498
		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x1F828B0", Offset = "0x1F829B1", VA = "0x1F828B0")]
		public bool AddHideSpawner(FieldHideItemSpawner hideItemSpawner)
		{
			return default(bool);
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x000262B0 File Offset: 0x000244B0
		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x1F826A0", Offset = "0x1F827A1", VA = "0x1F826A0")]
		public bool RemoveHideSpawner(FieldHideItemSpawner hideItemSpawner)
		{
			return default(bool);
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x1F84DC0", Offset = "0x1F84EC1", VA = "0x1F84DC0")]
		public void OnChangeHideDetectFlag(bool enable)
		{
		}

		// Token: 0x06006EED RID: 28397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x1F84ED0", Offset = "0x1F84FD1", VA = "0x1F84ED0")]
		public FieldItemSpawnDataManager()
		{
		}

		// Token: 0x040181E1 RID: 98785
		[Token(Token = "0x4014C84")]
		[FieldOffset(Offset = "0x18")]
		private FieldItemSpawnDataTableArray _FieldItemSpawnDataTableArray;

		// Token: 0x040181E2 RID: 98786
		[Token(Token = "0x4014C85")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<FieldItemSpawnID> _ExistSpawnIDHashSet;

		// Token: 0x040181E3 RID: 98787
		[Token(Token = "0x4014C86")]
		[FieldOffset(Offset = "0x28")]
		private FieldHideItemSpawnDataTableArray _FieldHideItemSpawnDataTableArray;

		// Token: 0x040181E4 RID: 98788
		[Token(Token = "0x4014C87")]
		[FieldOffset(Offset = "0x30")]
		private HashSet<FieldHideItemSpawnID> _ExistHideSpawnIDHashSet;

		// Token: 0x040181E5 RID: 98789
		[Token(Token = "0x4014C88")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814F0", Offset = "0x1815F1")]
		private bool <IsSceneChangeCheckEnd>k__BackingField;

		// Token: 0x040181E6 RID: 98790
		[Token(Token = "0x4014C89")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<FieldItemSpawner> ExistItemSpawnerHashSet;

		// Token: 0x040181E7 RID: 98791
		[Token(Token = "0x4014C8A")]
		[FieldOffset(Offset = "0x48")]
		private HashSet<FieldHideItemSpawner> ExistHideItemSpawnerHashSet;

		// Token: 0x040181E8 RID: 98792
		[Token(Token = "0x4014C8B")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, OnGroundItem> ExistItemDictionary;

		// Token: 0x040181E9 RID: 98793
		[Token(Token = "0x4014C8C")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<int, OnGroundItem> ExistHideItemDictionary;

		// Token: 0x040181EA RID: 98794
		[Token(Token = "0x4014C8D")]
		[FieldOffset(Offset = "0x60")]
		private bool IsInit;

		// Token: 0x040181EB RID: 98795
		[Token(Token = "0x4014C8E")]
		[FieldOffset(Offset = "0x68")]
		private bool[] CanDetectParties;

		// Token: 0x040181EC RID: 98796
		[Token(Token = "0x4014C8F")]
		[FieldOffset(Offset = "0x70")]
		private bool[] IsDetectParties;

		// Token: 0x02001121 RID: 4385
		[Token(Token = "0x2001584")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1C0", Offset = "0x15A2C1")]
		private sealed class <LoadDataTable>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006EEE RID: 28398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA1")]
			[Address(RVA = "0x1F836E0", Offset = "0x1F837E1", VA = "0x1F836E0")]
			[DebuggerHidden]
			public <LoadDataTable>d__27(int <>1__state)
			{
			}

			// Token: 0x06006EEF RID: 28399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA2")]
			[Address(RVA = "0x1F85A80", Offset = "0x1F85B81", VA = "0x1F85A80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006EF0 RID: 28400 RVA: 0x000262C8 File Offset: 0x000244C8
			[Token(Token = "0x6007DA3")]
			[Address(RVA = "0x1F85A90", Offset = "0x1F85B91", VA = "0x1F85A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ECF")]
			private object Current
			{
				[Token(Token = "0x6007DA4")]
				[Address(RVA = "0x1F85CB0", Offset = "0x1F85DB1", VA = "0x1F85CB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006EF2 RID: 28402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA5")]
			[Address(RVA = "0x1F85CC0", Offset = "0x1F85DC1", VA = "0x1F85CC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED0")]
			private object Current
			{
				[Token(Token = "0x6007DA6")]
				[Address(RVA = "0x1F85D20", Offset = "0x1F85E21", VA = "0x1F85D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040181ED RID: 98797
			[Token(Token = "0x401C169")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040181EE RID: 98798
			[Token(Token = "0x401C16A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040181EF RID: 98799
			[Token(Token = "0x401C16B")]
			[FieldOffset(Offset = "0x20")]
			public FieldItemSpawnDataManager <>4__this;
		}

		// Token: 0x02001122 RID: 4386
		[Token(Token = "0x2001585")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1D0", Offset = "0x15A2D1")]
		private sealed class <CheckSceneItem>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006EF4 RID: 28404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA7")]
			[Address(RVA = "0x1F843B0", Offset = "0x1F844B1", VA = "0x1F843B0")]
			[DebuggerHidden]
			public <CheckSceneItem>d__35(int <>1__state)
			{
			}

			// Token: 0x06006EF5 RID: 28405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DA8")]
			[Address(RVA = "0x1F85220", Offset = "0x1F85321", VA = "0x1F85220", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006EF6 RID: 28406 RVA: 0x000262E0 File Offset: 0x000244E0
			[Token(Token = "0x6007DA9")]
			[Address(RVA = "0x1F85230", Offset = "0x1F85331", VA = "0x1F85230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x06006EF7 RID: 28407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED1")]
			private object Current
			{
				[Token(Token = "0x6007DAA")]
				[Address(RVA = "0x1F85A00", Offset = "0x1F85B01", VA = "0x1F85A00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006EF8 RID: 28408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAB")]
			[Address(RVA = "0x1F85A10", Offset = "0x1F85B11", VA = "0x1F85A10", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E19 RID: 3609
			// (get) Token: 0x06006EF9 RID: 28409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED2")]
			private object Current
			{
				[Token(Token = "0x6007DAC")]
				[Address(RVA = "0x1F85A70", Offset = "0x1F85B71", VA = "0x1F85A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040181F0 RID: 98800
			[Token(Token = "0x401C16C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040181F1 RID: 98801
			[Token(Token = "0x401C16D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040181F2 RID: 98802
			[Token(Token = "0x401C16E")]
			[FieldOffset(Offset = "0x20")]
			public FieldItemSpawnDataManager <>4__this;
		}

		// Token: 0x02001123 RID: 4387
		[Token(Token = "0x2001586")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1E0", Offset = "0x15A2E1")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06006EFA RID: 28410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAD")]
			[Address(RVA = "0x1F846C0", Offset = "0x1F847C1", VA = "0x1F846C0")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x06006EFB RID: 28411 RVA: 0x000262F8 File Offset: 0x000244F8
			[Token(Token = "0x6007DAE")]
			[Address(RVA = "0x1F850A0", Offset = "0x1F851A1", VA = "0x1F850A0")]
			internal bool <RemoveOnGroundItem>b__0(KeyValuePair<int, OnGroundItem> p)
			{
				return default(bool);
			}

			// Token: 0x040181F3 RID: 98803
			[Token(Token = "0x401C16F")]
			[FieldOffset(Offset = "0x10")]
			public OnGroundItem onGroundItem;
		}

		// Token: 0x02001124 RID: 4388
		[Token(Token = "0x2001587")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A1F0", Offset = "0x15A2F1")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x06006EFC RID: 28412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DAF")]
			[Address(RVA = "0x1F84920", Offset = "0x1F84A21", VA = "0x1F84920")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x06006EFD RID: 28413 RVA: 0x00026310 File Offset: 0x00024510
			[Token(Token = "0x6007DB0")]
			[Address(RVA = "0x1F85120", Offset = "0x1F85221", VA = "0x1F85120")]
			internal bool <RemoveHideOnGroundItem>b__0(KeyValuePair<int, OnGroundItem> p)
			{
				return default(bool);
			}

			// Token: 0x040181F4 RID: 98804
			[Token(Token = "0x401C170")]
			[FieldOffset(Offset = "0x10")]
			public OnGroundItem onGroundItem;
		}

		// Token: 0x02001125 RID: 4389
		[Token(Token = "0x2001588")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A200", Offset = "0x15A301")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06006EFE RID: 28414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB1")]
			[Address(RVA = "0x1F84B70", Offset = "0x1F84C71", VA = "0x1F84B70")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06006EFF RID: 28415 RVA: 0x00026328 File Offset: 0x00024528
			[Token(Token = "0x6007DB2")]
			[Address(RVA = "0x1F851A0", Offset = "0x1F852A1", VA = "0x1F851A0")]
			internal bool <HideOnGroundItemExists>b__0(KeyValuePair<int, OnGroundItem> p)
			{
				return default(bool);
			}

			// Token: 0x040181F5 RID: 98805
			[Token(Token = "0x401C171")]
			[FieldOffset(Offset = "0x10")]
			public OnGroundItem onGroundItem;
		}
	}
}
