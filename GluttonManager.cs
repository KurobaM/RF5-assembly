using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x0200051F RID: 1311
[Token(Token = "0x20003BD")]
public class GluttonManager : SingletonMonoBehaviour<GluttonManager>
{
	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000430")]
	public Dictionary<FoodID, GluttonFood> GluttonFoods
	{
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x1FEFB10", Offset = "0x1FEFC11", VA = "0x1FEFB10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FEF0", Offset = "0x19FFF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x1FEFB20", Offset = "0x1FEFC21", VA = "0x1FEFB20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FF00", Offset = "0x1A0001")]
		private set
		{
		}
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000431")]
	public List<float> GluttonBonus
	{
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x1FEFB30", Offset = "0x1FEFC31", VA = "0x1FEFB30")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000432")]
	public GameObject Dish
	{
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x1FEFB50", Offset = "0x1FEFC51", VA = "0x1FEFB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FF10", Offset = "0x1A0011")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x1FEFB60", Offset = "0x1FEFC61", VA = "0x1FEFB60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FF20", Offset = "0x1A0021")]
		private set
		{
		}
	}

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000433")]
	public FestivalCamera Camera
	{
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x1FEFB70", Offset = "0x1FEFC71", VA = "0x1FEFB70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000434")]
	public GluttonUI GluttonUI
	{
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x1FEFB80", Offset = "0x1FEFC81", VA = "0x1FEFB80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FF30", Offset = "0x1A0031")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x1FEFB90", Offset = "0x1FEFC91", VA = "0x1FEFB90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FF40", Offset = "0x1A0041")]
		private set
		{
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B12")]
	[Address(RVA = "0x1FEFBA0", Offset = "0x1FEFCA1", VA = "0x1FEFBA0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B13")]
	[Address(RVA = "0x1FEFC10", Offset = "0x1FEFD11", VA = "0x1FEFC10")]
	private void Start()
	{
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B14")]
	[Address(RVA = "0x1FF0080", Offset = "0x1FF0181", VA = "0x1FF0080")]
	private void OnLoadingFood(int i)
	{
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B15")]
	[Address(RVA = "0x1FF01B0", Offset = "0x1FF02B1", VA = "0x1FF01B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x1FF02B0", Offset = "0x1FF03B1", VA = "0x1FF02B0")]
	private void CharaSetup()
	{
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
	[Token(Token = "0x6001B17")]
	[Address(RVA = "0x1FF05F0", Offset = "0x1FF06F1", VA = "0x1FF05F0")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B18")]
	[Address(RVA = "0x1FF0800", Offset = "0x1FF0901", VA = "0x1FF0800")]
	private void Update()
	{
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B19")]
	[Address(RVA = "0x1FF1000", Offset = "0x1FF1101", VA = "0x1FF1000")]
	public void MovePosition(bool _move_dir)
	{
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0x1FF1190", Offset = "0x1FF1291", VA = "0x1FF1190")]
	private void MovePositionNPC(GluttonTablePos _pos, int _no = 1)
	{
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0x1FF1280", Offset = "0x1FF1381", VA = "0x1FF1280")]
	public void Eat()
	{
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x1FF0F20", Offset = "0x1FF1021", VA = "0x1FF0F20")]
	private void procAI(int _no)
	{
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x1FF0E90", Offset = "0x1FF0F91", VA = "0x1FF0E90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FF50", Offset = "0x1A0051")]
	private IEnumerator GluttonGame()
	{
		return null;
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x1FF1990", Offset = "0x1FF1A91", VA = "0x1FF1990")]
	private void FoodGenerator(GluttonPlayer _player, int _term)
	{
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x1FF1F80", Offset = "0x1FF2081", VA = "0x1FF1F80")]
	public void FoodRepop(GluttonPlayer _player)
	{
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x1FF2450", Offset = "0x1FF2551", VA = "0x1FF2450")]
	public void ResetNpc()
	{
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x1FF2640", Offset = "0x1FF2741", VA = "0x1FF2640")]
	public GluttonManager()
	{
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x1FF2710", Offset = "0x1FF2811", VA = "0x1FF2710")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FFC0", Offset = "0x1A00C1")]
	private void <Start>b__30_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x040066A5 RID: 26277
	[Token(Token = "0x40060E5")]
	[FieldOffset(Offset = "0x18")]
	private readonly int[] FOOD_PREFAB_ID;

	// Token: 0x040066A6 RID: 26278
	[Token(Token = "0x40060E6")]
	private const int DISH_PREFAB_ID = 16167;

	// Token: 0x040066A7 RID: 26279
	[Token(Token = "0x40060E7")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165A20", Offset = "0x165B21")]
	private Dictionary<FoodID, GluttonFood> <GluttonFoods>k__BackingField;

	// Token: 0x040066A8 RID: 26280
	[Token(Token = "0x40060E8")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165A30", Offset = "0x165B31")]
	private GameObject <Dish>k__BackingField;

	// Token: 0x040066A9 RID: 26281
	[Token(Token = "0x40060E9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FestivalCamera gluttonCamera;

	// Token: 0x040066AA RID: 26282
	[Token(Token = "0x40060EA")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165A50", Offset = "0x165B51")]
	private GluttonUI <GluttonUI>k__BackingField;

	// Token: 0x040066AB RID: 26283
	[Token(Token = "0x40060EB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ObjectPooler objectPooler;

	// Token: 0x040066AC RID: 26284
	[Token(Token = "0x40060EC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GluttonPlayer gluttonPlayer;

	// Token: 0x040066AD RID: 26285
	[Token(Token = "0x40060ED")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GluttonPlayer[] gluttonNPC;

	// Token: 0x040066AE RID: 26286
	[Token(Token = "0x40060EE")]
	[FieldOffset(Offset = "0x58")]
	private List<ActorID> actorID;

	// Token: 0x040066AF RID: 26287
	[Token(Token = "0x40060EF")]
	[FieldOffset(Offset = "0x60")]
	private GluttonLotteryDataTable gluttonLotteryDataTable;

	// Token: 0x040066B0 RID: 26288
	[Token(Token = "0x40060F0")]
	[FieldOffset(Offset = "0x68")]
	private GluttonDataTable gluttonDataTable;

	// Token: 0x040066B1 RID: 26289
	[Token(Token = "0x40060F1")]
	[FieldOffset(Offset = "0x70")]
	private GluttonBonusDataTable gluttonBonusDataTable;

	// Token: 0x040066B2 RID: 26290
	[Token(Token = "0x40060F2")]
	[FieldOffset(Offset = "0x78")]
	private GluttonManager.State state;

	// Token: 0x040066B3 RID: 26291
	[Token(Token = "0x40060F3")]
	[FieldOffset(Offset = "0x7C")]
	private int term;

	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x20010EB")]
	private enum State
	{
		// Token: 0x040066B5 RID: 26293
		[Token(Token = "0x4019234")]
		None,
		// Token: 0x040066B6 RID: 26294
		[Token(Token = "0x4019235")]
		Begin,
		// Token: 0x040066B7 RID: 26295
		[Token(Token = "0x4019236")]
		Load,
		// Token: 0x040066B8 RID: 26296
		[Token(Token = "0x4019237")]
		CountDown,
		// Token: 0x040066B9 RID: 26297
		[Token(Token = "0x4019238")]
		Main,
		// Token: 0x040066BA RID: 26298
		[Token(Token = "0x4019239")]
		End
	}

	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x20010EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157CF0", Offset = "0x157DF1")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x06001FD5 RID: 8149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0x1FF01A0", Offset = "0x1FF02A1", VA = "0x1FF01A0")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9E")]
		[Address(RVA = "0x1FF2790", Offset = "0x1FF2891", VA = "0x1FF2790")]
		internal void <OnLoadingFood>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040066BB RID: 26299
		[Token(Token = "0x401923A")]
		[FieldOffset(Offset = "0x10")]
		public GluttonManager <>4__this;

		// Token: 0x040066BC RID: 26300
		[Token(Token = "0x401923B")]
		[FieldOffset(Offset = "0x18")]
		public int i;
	}

	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x20010ED")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D00", Offset = "0x157E01")]
	private sealed class <GluttonGame>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001FD7 RID: 8151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F9F")]
		[Address(RVA = "0x1FF1960", Offset = "0x1FF1A61", VA = "0x1FF1960")]
		[DebuggerHidden]
		public <GluttonGame>d__40(int <>1__state)
		{
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0x1FF29B0", Offset = "0x1FF2AB1", VA = "0x1FF29B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x6006FA1")]
		[Address(RVA = "0x1FF29C0", Offset = "0x1FF2AC1", VA = "0x1FF29C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAD")]
		private object Current
		{
			[Token(Token = "0x6006FA2")]
			[Address(RVA = "0x1FF2B70", Offset = "0x1FF2C71", VA = "0x1FF2B70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x1FF2B80", Offset = "0x1FF2C81", VA = "0x1FF2B80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAE")]
		private object Current
		{
			[Token(Token = "0x6006FA4")]
			[Address(RVA = "0x1FF2BE0", Offset = "0x1FF2CE1", VA = "0x1FF2BE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040066BD RID: 26301
		[Token(Token = "0x401923C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040066BE RID: 26302
		[Token(Token = "0x401923D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040066BF RID: 26303
		[Token(Token = "0x401923E")]
		[FieldOffset(Offset = "0x20")]
		public GluttonManager <>4__this;

		// Token: 0x040066C0 RID: 26304
		[Token(Token = "0x401923F")]
		[FieldOffset(Offset = "0x28")]
		private int <count>5__2;
	}
}
