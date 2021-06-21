using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

namespace Farm
{
	// Token: 0x020010B2 RID: 4274
	[Token(Token = "0x2000ABA")]
	public class PlantStatus : MonoBehaviour
	{
		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06006C11 RID: 27665 RVA: 0x00025068 File Offset: 0x00023268
		// (set) Token: 0x06006C12 RID: 27666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC3")]
		public bool IsPlanted
		{
			[Token(Token = "0x60059AB")]
			[Address(RVA = "0x21A2770", Offset = "0x21A2871", VA = "0x21A2770")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE340", Offset = "0x1AE441")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60059AC")]
			[Address(RVA = "0x21A2780", Offset = "0x21A2881", VA = "0x21A2780")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE350", Offset = "0x1AE451")]
			set
			{
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06006C13 RID: 27667 RVA: 0x00025080 File Offset: 0x00023280
		// (set) Token: 0x06006C14 RID: 27668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC4")]
		public int PlantStatusLevel
		{
			[Token(Token = "0x60059AD")]
			[Address(RVA = "0x21A2790", Offset = "0x21A2891", VA = "0x21A2790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE360", Offset = "0x1AE461")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60059AE")]
			[Address(RVA = "0x21A27A0", Offset = "0x21A28A1", VA = "0x21A27A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE370", Offset = "0x1AE471")]
			set
			{
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06006C15 RID: 27669 RVA: 0x00025098 File Offset: 0x00023298
		// (set) Token: 0x06006C16 RID: 27670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC5")]
		public int PlantStatusLevelMax
		{
			[Token(Token = "0x60059AF")]
			[Address(RVA = "0x21A27B0", Offset = "0x21A28B1", VA = "0x21A27B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE380", Offset = "0x1AE481")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60059B0")]
			[Address(RVA = "0x21A27C0", Offset = "0x21A28C1", VA = "0x21A27C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE390", Offset = "0x1AE491")]
			set
			{
			}
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x21A27D0", Offset = "0x21A28D1", VA = "0x21A27D0")]
		private void Start()
		{
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x21A2890", Offset = "0x21A2991", VA = "0x21A2890")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x21A2A30", Offset = "0x21A2B31", VA = "0x21A2A30")]
		private void Update()
		{
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x21A34B0", Offset = "0x21A35B1", VA = "0x21A34B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x21A2A70", Offset = "0x21A2B71", VA = "0x21A2A70")]
		private void UpdateObj()
		{
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0x21A34D0", Offset = "0x21A35D1", VA = "0x21A34D0")]
		public void SetPlantStatusLevel(int level)
		{
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0x21A3520", Offset = "0x21A3621", VA = "0x21A3520")]
		public void StatusUpdate()
		{
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x000250B0 File Offset: 0x000232B0
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0x21A3540", Offset = "0x21A3641", VA = "0x21A3540")]
		public bool IsStatusMax()
		{
			return default(bool);
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0x21A27F0", Offset = "0x21A28F1", VA = "0x21A27F0")]
		public void StatusReset(int level = -1)
		{
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0x21A0310", Offset = "0x21A0411", VA = "0x21A0310")]
		public void ChangeSize(bool isLarge)
		{
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x21A3620", Offset = "0x21A3721", VA = "0x21A3620")]
		public void ChangeSize(float size)
		{
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BC")]
		[Address(RVA = "0x21A2F30", Offset = "0x21A3031", VA = "0x21A2F30")]
		private void UpdateSize()
		{
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x21A3670", Offset = "0x21A3771", VA = "0x21A3670")]
		public void SetPlantData(CropDataTable cropData, [Optional] UnityAction callback, bool isUpdate = true, bool isReset = true)
		{
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x21A3A00", Offset = "0x21A3B01", VA = "0x21A3A00")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE3A0", Offset = "0x1AE4A1")]
		private IEnumerator CreateCropObjectCoroutine(CropDataTable cropData, List<string> prefabNames, [Optional] UnityAction callback)
		{
			return null;
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0x21A3B10", Offset = "0x21A3C11", VA = "0x21A3B10")]
		public void ChangeWither(bool isWither)
		{
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x21A30A0", Offset = "0x21A31A1", VA = "0x21A30A0")]
		private void UpdateWither()
		{
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0x21A3B30", Offset = "0x21A3C31", VA = "0x21A3B30")]
		public void ChangeTreeFruitsCount(int count)
		{
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C2")]
		[Address(RVA = "0x21A3230", Offset = "0x21A3331", VA = "0x21A3230")]
		private void UpdateTreeFruitsCount()
		{
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x000250C8 File Offset: 0x000232C8
		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x21A3630", Offset = "0x21A3731", VA = "0x21A3630")]
		private bool CanUpdateDetail()
		{
			return default(bool);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x21A3550", Offset = "0x21A3651", VA = "0x21A3550")]
		private static void removeChildObjectsAll(Transform t)
		{
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x21A28A0", Offset = "0x21A29A1", VA = "0x21A28A0")]
		private void removePrefabs()
		{
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x21A3B40", Offset = "0x21A3C41", VA = "0x21A3B40")]
		public PlantStatus()
		{
		}

		// Token: 0x04017469 RID: 95337
		[Token(Token = "0x4013FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initData;

		// Token: 0x0401746A RID: 95338
		[Token(Token = "0x4013FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool loading;

		// Token: 0x0401746B RID: 95339
		[Token(Token = "0x4013FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EF0", Offset = "0x180FF1")]
		private bool <IsPlanted>k__BackingField;

		// Token: 0x0401746C RID: 95340
		[Token(Token = "0x4013FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F00", Offset = "0x181001")]
		private int <PlantStatusLevel>k__BackingField;

		// Token: 0x0401746D RID: 95341
		[Token(Token = "0x4013FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F10", Offset = "0x181011")]
		private int <PlantStatusLevelMax>k__BackingField;

		// Token: 0x0401746E RID: 95342
		[Token(Token = "0x4013FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _nowStatus;

		// Token: 0x0401746F RID: 95343
		[Token(Token = "0x4013FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _size;

		// Token: 0x04017470 RID: 95344
		[Token(Token = "0x4013FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _updateSize;

		// Token: 0x04017471 RID: 95345
		[Token(Token = "0x4013FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool _isWither;

		// Token: 0x04017472 RID: 95346
		[Token(Token = "0x4013FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		private bool _updateWither;

		// Token: 0x04017473 RID: 95347
		[Token(Token = "0x4013FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _treeFruitsCount;

		// Token: 0x04017474 RID: 95348
		[Token(Token = "0x4013FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool _updateTreeFruitsCount;

		// Token: 0x04017475 RID: 95349
		[Token(Token = "0x4013FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> _plantDataObjList;

		// Token: 0x04017476 RID: 95350
		[Token(Token = "0x4013FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Prefab> _loadPrefabIds;

		// Token: 0x04017477 RID: 95351
		[Token(Token = "0x4013FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject _fruitObjPrefab;

		// Token: 0x04017478 RID: 95352
		[Token(Token = "0x4013FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Prefab _fruitPrefabId;

		// Token: 0x04017479 RID: 95353
		[Token(Token = "0x4013FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject[] _fruitSockets;

		// Token: 0x0401747A RID: 95354
		[Token(Token = "0x4013FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IEnumerator _createObjectCoroutine;

		// Token: 0x020010B3 RID: 4275
		[Token(Token = "0x2001564")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FF0", Offset = "0x15A0F1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006C2E RID: 27694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D16")]
			[Address(RVA = "0x21A3CA0", Offset = "0x21A3DA1", VA = "0x21A3CA0")]
			public <>c()
			{
			}

			// Token: 0x06006C2F RID: 27695 RVA: 0x000250E0 File Offset: 0x000232E0
			[Token(Token = "0x6007D17")]
			[Address(RVA = "0x21A3CB0", Offset = "0x21A3DB1", VA = "0x21A3CB0")]
			internal bool <SetPlantData>b__39_0(string pname)
			{
				return default(bool);
			}

			// Token: 0x0401747B RID: 95355
			[Token(Token = "0x401C0D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PlantStatus.<>c <>9;

			// Token: 0x0401747C RID: 95356
			[Token(Token = "0x401C0D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<string> <>9__39_0;
		}

		// Token: 0x020010B4 RID: 4276
		[Token(Token = "0x2001565")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A000", Offset = "0x15A101")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x06006C30 RID: 27696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D18")]
			[Address(RVA = "0x21A3D10", Offset = "0x21A3E11", VA = "0x21A3D10")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x06006C31 RID: 27697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D19")]
			[Address(RVA = "0x21A3D20", Offset = "0x21A3E21", VA = "0x21A3D20")]
			internal void <CreateCropObjectCoroutine>b__0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x0401747D RID: 95357
			[Token(Token = "0x401C0D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject prefabOrg;
		}

		// Token: 0x020010B5 RID: 4277
		[Token(Token = "0x2001566")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A010", Offset = "0x15A111")]
		private sealed class <>c__DisplayClass40_1
		{
			// Token: 0x06006C32 RID: 27698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D1A")]
			[Address(RVA = "0x21A3DA0", Offset = "0x21A3EA1", VA = "0x21A3DA0")]
			public <>c__DisplayClass40_1()
			{
			}

			// Token: 0x06006C33 RID: 27699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D1B")]
			[Address(RVA = "0x21A3DB0", Offset = "0x21A3EB1", VA = "0x21A3DB0")]
			internal void <CreateCropObjectCoroutine>b__1(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x0401747E RID: 95358
			[Token(Token = "0x401C0D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject prefabOrg;
		}

		// Token: 0x020010B6 RID: 4278
		[Token(Token = "0x2001567")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A020", Offset = "0x15A121")]
		private sealed class <CreateCropObjectCoroutine>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006C34 RID: 27700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D1C")]
			[Address(RVA = "0x21A3AE0", Offset = "0x21A3BE1", VA = "0x21A3AE0")]
			[DebuggerHidden]
			public <CreateCropObjectCoroutine>d__40(int <>1__state)
			{
			}

			// Token: 0x06006C35 RID: 27701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D1D")]
			[Address(RVA = "0x21A3E30", Offset = "0x21A3F31", VA = "0x21A3E30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006C36 RID: 27702 RVA: 0x000250F8 File Offset: 0x000232F8
			[Token(Token = "0x6007D1E")]
			[Address(RVA = "0x21A3E40", Offset = "0x21A3F41", VA = "0x21A3E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06006C37 RID: 27703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB5")]
			private object Current
			{
				[Token(Token = "0x6007D1F")]
				[Address(RVA = "0x21A4720", Offset = "0x21A4821", VA = "0x21A4720", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006C38 RID: 27704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D20")]
			[Address(RVA = "0x21A4730", Offset = "0x21A4831", VA = "0x21A4730", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06006C39 RID: 27705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB6")]
			private object Current
			{
				[Token(Token = "0x6007D21")]
				[Address(RVA = "0x21A4790", Offset = "0x21A4891", VA = "0x21A4790", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401747F RID: 95359
			[Token(Token = "0x401C0D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017480 RID: 95360
			[Token(Token = "0x401C0D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017481 RID: 95361
			[Token(Token = "0x401C0D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlantStatus <>4__this;

			// Token: 0x04017482 RID: 95362
			[Token(Token = "0x401C0DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> prefabNames;

			// Token: 0x04017483 RID: 95363
			[Token(Token = "0x401C0DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private PlantStatus.<>c__DisplayClass40_0 <>8__1;

			// Token: 0x04017484 RID: 95364
			[Token(Token = "0x401C0DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CropDataTable cropData;

			// Token: 0x04017485 RID: 95365
			[Token(Token = "0x401C0DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private PlantStatus.<>c__DisplayClass40_1 <>8__2;

			// Token: 0x04017486 RID: 95366
			[Token(Token = "0x401C0DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public UnityAction callback;

			// Token: 0x04017487 RID: 95367
			[Token(Token = "0x401C0DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private List<GameObject> <objList>5__2;

			// Token: 0x04017488 RID: 95368
			[Token(Token = "0x401C0E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private GameObject[] <fruitSockets>5__3;

			// Token: 0x04017489 RID: 95369
			[Token(Token = "0x401C0E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			private int <i>5__4;

			// Token: 0x0401748A RID: 95370
			[Token(Token = "0x401C0E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private int <index>5__5;

			// Token: 0x0401748B RID: 95371
			[Token(Token = "0x401C0E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			private Prefab <prefabId>5__6;
		}
	}
}
