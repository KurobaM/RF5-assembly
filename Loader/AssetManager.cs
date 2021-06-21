using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Loader
{
	// Token: 0x0200101B RID: 4123
	[Token(Token = "0x2000A72")]
	[Attribute(Name = "DefaultExecutionOrder", RVA = "0x149F60", Offset = "0x14A061")]
	public class AssetManager : MonoBehaviour
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060067DA RID: 26586 RVA: 0x00023790 File Offset: 0x00021990
		// (set) Token: 0x060067DB RID: 26587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5B")]
		public static bool UnloadDone
		{
			[Token(Token = "0x6005673")]
			[Address(RVA = "0x2312130", Offset = "0x2312231", VA = "0x2312130")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACE20", Offset = "0x1ACF21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005674")]
			[Address(RVA = "0x23121A0", Offset = "0x23122A1", VA = "0x23121A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACE30", Offset = "0x1ACF31")]
			private set
			{
			}
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005675")]
		[Address(RVA = "0x2312210", Offset = "0x2312311", VA = "0x2312210")]
		public static void CleanUp()
		{
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005676")]
		[Address(RVA = "0x23123F0", Offset = "0x23124F1", VA = "0x23123F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ACE40", Offset = "0x1ACF41")]
		private IEnumerator UnloadOperation()
		{
			return null;
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060067DE RID: 26590 RVA: 0x000237A8 File Offset: 0x000219A8
		// (set) Token: 0x060067DF RID: 26591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5C")]
		public static bool IsReady
		{
			[Token(Token = "0x6005677")]
			[Address(RVA = "0x2312450", Offset = "0x2312551", VA = "0x2312450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACEB0", Offset = "0x1ACFB1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005678")]
			[Address(RVA = "0x23124C0", Offset = "0x23125C1", VA = "0x23124C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACEC0", Offset = "0x1ACFC1")]
			private set
			{
			}
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005679")]
		[Address(RVA = "0x2311910", Offset = "0x2311A11", VA = "0x2311910")]
		public static string Key(int id, SystemLanguage lang)
		{
			return null;
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567A")]
		public static void Entry<T>(int id, SystemLanguage language, [Optional] UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = false) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567B")]
		public static void Entry<T>(int id, [Optional] UnityAction<AssetHandle<T>> callback, int priority = 0, bool scene_only = false) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x000237C0 File Offset: 0x000219C0
		[Token(Token = "0x600567C")]
		public static AsyncOperationHandle<T> Entry<T>(string key, [Optional] UnityAction<T> callback) where T : UnityEngine.Object
		{
			return default(AsyncOperationHandle<T>);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567D")]
		[Address(RVA = "0x230C6F0", Offset = "0x230C7F1", VA = "0x230C6F0")]
		public static void Remove(int id)
		{
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567E")]
		public static void Remove<T>(int id) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567F")]
		[Address(RVA = "0x23125F0", Offset = "0x23126F1", VA = "0x23125F0")]
		public static void RemoveAll()
		{
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005680")]
		public static T GetResult<T>(int id) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x000237D8 File Offset: 0x000219D8
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5D")]
		public static SystemLanguage Language
		{
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x2312870", Offset = "0x2312971", VA = "0x2312870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACED0", Offset = "0x1ACFD1")]
			get
			{
				return SystemLanguage.Afrikaans;
			}
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x23128E0", Offset = "0x23129E1", VA = "0x23128E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACEE0", Offset = "0x1ACFE1")]
			set
			{
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x000237F0 File Offset: 0x000219F0
		// (set) Token: 0x060067EB RID: 26603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5E")]
		public static bool IsLoading
		{
			[Token(Token = "0x6005683")]
			[Address(RVA = "0x2312950", Offset = "0x2312A51", VA = "0x2312950")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACEF0", Offset = "0x1ACFF1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005684")]
			[Address(RVA = "0x23129C0", Offset = "0x2312AC1", VA = "0x23129C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF00", Offset = "0x1AD001")]
			protected set
			{
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060067EC RID: 26604 RVA: 0x00023808 File Offset: 0x00021A08
		// (set) Token: 0x060067ED RID: 26605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5F")]
		public static bool LoadingOn
		{
			[Token(Token = "0x6005685")]
			[Address(RVA = "0x2312A30", Offset = "0x2312B31", VA = "0x2312A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF10", Offset = "0x1AD011")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005686")]
			[Address(RVA = "0x2312AA0", Offset = "0x2312BA1", VA = "0x2312AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF20", Offset = "0x1AD021")]
			private set
			{
			}
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005687")]
		[Address(RVA = "0x2312B10", Offset = "0x2312C11", VA = "0x2312B10")]
		public static void LoadingStart()
		{
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005688")]
		[Address(RVA = "0x2312CC0", Offset = "0x2312DC1", VA = "0x2312CC0")]
		public static void LoadingEnd()
		{
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060067F0 RID: 26608 RVA: 0x00023820 File Offset: 0x00021A20
		[Token(Token = "0x17000A60")]
		public static int LoadingMax
		{
			[Token(Token = "0x6005689")]
			[Address(RVA = "0x2312E60", Offset = "0x2312F61", VA = "0x2312E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x00023838 File Offset: 0x00021A38
		// (set) Token: 0x060067F2 RID: 26610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A61")]
		public static int LoadingCount
		{
			[Token(Token = "0x600568A")]
			[Address(RVA = "0x2312F50", Offset = "0x2313051", VA = "0x2312F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF30", Offset = "0x1AD031")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600568B")]
			[Address(RVA = "0x2312FC0", Offset = "0x23130C1", VA = "0x2312FC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF40", Offset = "0x1AD041")]
			protected set
			{
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067F4 RID: 26612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A62")]
		public static AssetDataTable AssetKeys
		{
			[Token(Token = "0x600568C")]
			[Address(RVA = "0x2313030", Offset = "0x2313131", VA = "0x2313030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF50", Offset = "0x1AD051")]
			get
			{
				return null;
			}
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x23130A0", Offset = "0x23131A1", VA = "0x23130A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF60", Offset = "0x1AD061")]
			private set
			{
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060067F6 RID: 26614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A63")]
		public static AssetManager Instance
		{
			[Token(Token = "0x600568E")]
			[Address(RVA = "0x2313110", Offset = "0x2313211", VA = "0x2313110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF70", Offset = "0x1AD071")]
			get
			{
				return null;
			}
			[Token(Token = "0x600568F")]
			[Address(RVA = "0x2313180", Offset = "0x2313281", VA = "0x2313180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACF80", Offset = "0x1AD081")]
			private set
			{
			}
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005690")]
		private void LoadEntry<T>(int id, SystemLanguage language, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005691")]
		private void LoadEntry<T>(int id, UnityAction<AssetHandle<T>> callback, int priority, bool scene_only) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005692")]
		[Address(RVA = "0x2312530", Offset = "0x2312631", VA = "0x2312530")]
		private void RemoveEntry(int id)
		{
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005693")]
		private void RemoveEntry<T>(int id) where T : UnityEngine.Object
		{
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005694")]
		[Address(RVA = "0x2312790", Offset = "0x2312891", VA = "0x2312790")]
		private void RemoveAllAssets()
		{
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x00023850 File Offset: 0x00021A50
		[Token(Token = "0x6005695")]
		[Address(RVA = "0x23131F0", Offset = "0x23132F1", VA = "0x23131F0")]
		private int GetLoadingCount()
		{
			return 0;
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005696")]
		[Address(RVA = "0x23132A0", Offset = "0x23133A1", VA = "0x23132A0")]
		private void Awake()
		{
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005697")]
		[Address(RVA = "0x23134F0", Offset = "0x23135F1", VA = "0x23134F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ACF90", Offset = "0x1AD091")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005698")]
		[Address(RVA = "0x2313570", Offset = "0x2313671", VA = "0x2313570")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005699")]
		[Address(RVA = "0x23136C0", Offset = "0x23137C1", VA = "0x23136C0")]
		private void Update()
		{
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569A")]
		[Address(RVA = "0x23140E0", Offset = "0x23141E1", VA = "0x23140E0")]
		public AssetManager()
		{
		}

		// Token: 0x0400C759 RID: 51033
		[Token(Token = "0x40093F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180140", Offset = "0x180241")]
		private static bool <UnloadDone>k__BackingField;

		// Token: 0x0400C75A RID: 51034
		[Token(Token = "0x40093F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180150", Offset = "0x180251")]
		private static bool <IsReady>k__BackingField;

		// Token: 0x0400C75B RID: 51035
		[Token(Token = "0x40093F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180160", Offset = "0x180261")]
		private static SystemLanguage <Language>k__BackingField;

		// Token: 0x0400C75C RID: 51036
		[Token(Token = "0x40093F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180170", Offset = "0x180271")]
		private static bool <IsLoading>k__BackingField;

		// Token: 0x0400C75D RID: 51037
		[Token(Token = "0x40093F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180180", Offset = "0x180281")]
		private static bool <LoadingOn>k__BackingField;

		// Token: 0x0400C75E RID: 51038
		[Token(Token = "0x40093F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180190", Offset = "0x180291")]
		private static int <LoadingCount>k__BackingField;

		// Token: 0x0400C75F RID: 51039
		[Token(Token = "0x40093F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssetReference AssetTableReference;

		// Token: 0x0400C760 RID: 51040
		[Token(Token = "0x40093F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1801B0", Offset = "0x1802B1")]
		private static AssetDataTable <AssetKeys>k__BackingField;

		// Token: 0x0400C761 RID: 51041
		[Token(Token = "0x40093F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1801C0", Offset = "0x1802C1")]
		private static AssetManager <Instance>k__BackingField;

		// Token: 0x0400C762 RID: 51042
		[Token(Token = "0x40093FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AssetHandle> LoadList;

		// Token: 0x0400C763 RID: 51043
		[Token(Token = "0x40093FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<int> LoadCountList;

		// Token: 0x0400C764 RID: 51044
		[Token(Token = "0x40093FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<AssetHandle> EntryList;

		// Token: 0x0400C765 RID: 51045
		[Token(Token = "0x40093FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<AssetHandle> RemoveList;

		// Token: 0x0400C766 RID: 51046
		[Token(Token = "0x40093FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<AssetHandle> CompList;

		// Token: 0x0400C767 RID: 51047
		[Token(Token = "0x40093FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1801D0", Offset = "0x1802D1")]
		private int UPDATE_LOADING_MAX;

		// Token: 0x0400C768 RID: 51048
		[Token(Token = "0x4009400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int LoadMax;

		// Token: 0x0400C769 RID: 51049
		[Token(Token = "0x4009401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int LoadCount;

		// Token: 0x0400C76A RID: 51050
		[Token(Token = "0x4009402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Attribute(Name = "HeaderAttribute", RVA = "0x180220", Offset = "0x180321")]
		private int PLAYABLE_LOADING_MAX;

		// Token: 0x0200101C RID: 4124
		[Token(Token = "0x2001515")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BE0", Offset = "0x159CE1")]
		private sealed class <UnloadOperation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006803 RID: 26627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C16")]
			[Address(RVA = "0x1F0B0F0", Offset = "0x1F0B1F1", VA = "0x1F0B0F0")]
			[DebuggerHidden]
			public <UnloadOperation>d__5(int <>1__state)
			{
			}

			// Token: 0x06006804 RID: 26628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C17")]
			[Address(RVA = "0x1F0B120", Offset = "0x1F0B221", VA = "0x1F0B120", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006805 RID: 26629 RVA: 0x00023868 File Offset: 0x00021A68
			[Token(Token = "0x6007C18")]
			[Address(RVA = "0x1F0B130", Offset = "0x1F0B231", VA = "0x1F0B130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x06006806 RID: 26630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7D")]
			private object Current
			{
				[Token(Token = "0x6007C19")]
				[Address(RVA = "0x1F0B3B0", Offset = "0x1F0B4B1", VA = "0x1F0B3B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006807 RID: 26631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C1A")]
			[Address(RVA = "0x1F0B3C0", Offset = "0x1F0B4C1", VA = "0x1F0B3C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x06006808 RID: 26632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7E")]
			private object Current
			{
				[Token(Token = "0x6007C1B")]
				[Address(RVA = "0x1F0B420", Offset = "0x1F0B521", VA = "0x1F0B420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400C76B RID: 51051
			[Token(Token = "0x401BF74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400C76C RID: 51052
			[Token(Token = "0x401BF75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}

		// Token: 0x0200101D RID: 4125
		[Token(Token = "0x2001516")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159BF0", Offset = "0x159CF1")]
		private sealed class <>c__DisplayClass13_0<T> where T : UnityEngine.Object
		{
			// Token: 0x06006809 RID: 26633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C1C")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x0600680A RID: 26634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C1D")]
			internal void <Entry>b__0(AsyncOperationHandle<T> aoh)
			{
			}

			// Token: 0x0400C76D RID: 51053
			[Token(Token = "0x401BF76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnityAction<T> callback;
		}

		// Token: 0x0200101E RID: 4126
		[Token(Token = "0x2001517")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C00", Offset = "0x159D01")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600680C RID: 26636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C1F")]
			[Address(RVA = "0x1F0ABC0", Offset = "0x1F0ACC1", VA = "0x1F0ABC0")]
			public <>c()
			{
			}

			// Token: 0x0600680D RID: 26637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C20")]
			[Address(RVA = "0x1F0ABD0", Offset = "0x1F0ACD1", VA = "0x1F0ABD0")]
			internal void <Start>b__63_0(AsyncOperationHandle<AssetDataTable> op)
			{
			}

			// Token: 0x0400C76E RID: 51054
			[Token(Token = "0x401BF77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly AssetManager.<>c <>9;

			// Token: 0x0400C76F RID: 51055
			[Token(Token = "0x401BF78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<AsyncOperationHandle<AssetDataTable>> <>9__63_0;
		}

		// Token: 0x0200101F RID: 4127
		[Token(Token = "0x2001518")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C10", Offset = "0x159D11")]
		private sealed class <Start>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600680E RID: 26638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C21")]
			[Address(RVA = "0x1F0AE50", Offset = "0x1F0AF51", VA = "0x1F0AE50")]
			[DebuggerHidden]
			public <Start>d__63(int <>1__state)
			{
			}

			// Token: 0x0600680F RID: 26639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C22")]
			[Address(RVA = "0x1F0AE80", Offset = "0x1F0AF81", VA = "0x1F0AE80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006810 RID: 26640 RVA: 0x00023880 File Offset: 0x00021A80
			[Token(Token = "0x6007C23")]
			[Address(RVA = "0x1F0AE90", Offset = "0x1F0AF91", VA = "0x1F0AE90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x06006811 RID: 26641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E7F")]
			private object Current
			{
				[Token(Token = "0x6007C24")]
				[Address(RVA = "0x1F0B070", Offset = "0x1F0B171", VA = "0x1F0B070", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006812 RID: 26642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C25")]
			[Address(RVA = "0x1F0B080", Offset = "0x1F0B181", VA = "0x1F0B080", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x06006813 RID: 26643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E80")]
			private object Current
			{
				[Token(Token = "0x6007C26")]
				[Address(RVA = "0x1F0B0E0", Offset = "0x1F0B1E1", VA = "0x1F0B0E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400C770 RID: 51056
			[Token(Token = "0x401BF79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400C771 RID: 51057
			[Token(Token = "0x401BF7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400C772 RID: 51058
			[Token(Token = "0x401BF7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetManager <>4__this;
		}
	}
}
