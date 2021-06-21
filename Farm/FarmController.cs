using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

namespace Farm
{
	// Token: 0x02001085 RID: 4229
	[Token(Token = "0x2000AB5")]
	public class FarmController : MonoBehaviour
	{
		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x000249A8 File Offset: 0x00022BA8
		[Token(Token = "0x17000ABD")]
		public FarmManager.FARM_ID ThisFarmId
		{
			[Token(Token = "0x6005918")]
			[Address(RVA = "0x214D970", Offset = "0x214DA71", VA = "0x214D970")]
			get
			{
				return FarmManager.FARM_ID.RF4_FREEFARM_ID_Village;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x000249C0 File Offset: 0x00022BC0
		// (set) Token: 0x06006B07 RID: 27399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABE")]
		public float XCount
		{
			[Token(Token = "0x6005919")]
			[Address(RVA = "0x214D980", Offset = "0x214DA81", VA = "0x214D980")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600591A")]
			[Address(RVA = "0x214D990", Offset = "0x214DA91", VA = "0x214D990")]
			set
			{
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06006B08 RID: 27400 RVA: 0x000249D8 File Offset: 0x00022BD8
		// (set) Token: 0x06006B09 RID: 27401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ABF")]
		public float ZCount
		{
			[Token(Token = "0x600591B")]
			[Address(RVA = "0x214D9A0", Offset = "0x214DAA1", VA = "0x214D9A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600591C")]
			[Address(RVA = "0x214D9B0", Offset = "0x214DAB1", VA = "0x214D9B0")]
			set
			{
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06006B0A RID: 27402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC0")]
		public List<CellController> CellControllers
		{
			[Token(Token = "0x600591D")]
			[Address(RVA = "0x214D9C0", Offset = "0x214DAC1", VA = "0x214D9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x000249F0 File Offset: 0x00022BF0
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC1")]
		public bool NeedReloadOnEnable
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0x214D9D0", Offset = "0x214DAD1", VA = "0x214D9D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADE00", Offset = "0x1ADF01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600591F")]
			[Address(RVA = "0x214D9E0", Offset = "0x214DAE1", VA = "0x214D9E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADE10", Offset = "0x1ADF11")]
			set
			{
			}
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005920")]
		[Address(RVA = "0x214D9F0", Offset = "0x214DAF1", VA = "0x214D9F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADE20", Offset = "0x1ADF21")]
		public IEnumerator CreateFarmCells(UnityAction callback)
		{
			return null;
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x214DAC0", Offset = "0x214DBC1", VA = "0x214DAC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADE90", Offset = "0x1ADF91")]
		private IEnumerator LoadTexture(string texName, UnityAction<UnityEngine.Texture> callback)
		{
			return null;
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005922")]
		[Address(RVA = "0x214DBA0", Offset = "0x214DCA1", VA = "0x214DBA0")]
		private void RemoveTextures()
		{
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005923")]
		[Address(RVA = "0x214DCF0", Offset = "0x214DDF1", VA = "0x214DCF0")]
		public CellController GetCellController(Vector3Int cellSetId, int cellId)
		{
			return null;
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005924")]
		[Address(RVA = "0x214DDE0", Offset = "0x214DEE1", VA = "0x214DDE0")]
		public CellSetController GetCellSetController(Vector3Int cellSetId)
		{
			return null;
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005925")]
		[Address(RVA = "0x214DED0", Offset = "0x214DFD1", VA = "0x214DED0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADF00", Offset = "0x1AE001")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005926")]
		[Address(RVA = "0x214DF80", Offset = "0x214E081", VA = "0x214DF80")]
		private void OnEnable()
		{
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005927")]
		[Address(RVA = "0x214E4C0", Offset = "0x214E5C1", VA = "0x214E4C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005928")]
		[Address(RVA = "0x214E5C0", Offset = "0x214E6C1", VA = "0x214E5C0")]
		public FarmController()
		{
		}

		// Token: 0x040172CB RID: 94923
		[Token(Token = "0x4013EBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _XCount;

		// Token: 0x040172CC RID: 94924
		[Token(Token = "0x4013EBB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _ZCount;

		// Token: 0x040172CD RID: 94925
		[Token(Token = "0x4013EBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FarmManager.FARM_ID FarmId;

		// Token: 0x040172CE RID: 94926
		[Token(Token = "0x4013EBD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject FarmEdge;

		// Token: 0x040172CF RID: 94927
		[Token(Token = "0x4013EBE")]
		[FieldOffset(Offset = "0x30")]
		private List<CellController> _cellControllers;

		// Token: 0x040172D0 RID: 94928
		[Token(Token = "0x4013EBF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180D70", Offset = "0x180E71")]
		private bool <NeedReloadOnEnable>k__BackingField;

		// Token: 0x040172D1 RID: 94929
		[Token(Token = "0x4013EC0")]
		[FieldOffset(Offset = "0x40")]
		private GameObject CultivateSetPrefab;

		// Token: 0x040172D2 RID: 94930
		[Token(Token = "0x4013EC1")]
		[FieldOffset(Offset = "0x48")]
		private List<Loader.ID.Texture> LoadTextureIds;

		// Token: 0x02001086 RID: 4230
		[Token(Token = "0x200153C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D70", Offset = "0x159E71")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06006B16 RID: 27414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C9C")]
			[Address(RVA = "0x214E7F0", Offset = "0x214E8F1", VA = "0x214E7F0")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C9D")]
			[Address(RVA = "0x214E800", Offset = "0x214E901", VA = "0x214E800")]
			internal void <CreateFarmCells>b__0(GameObject obj)
			{
			}

			// Token: 0x06006B18 RID: 27416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C9E")]
			[Address(RVA = "0x214E810", Offset = "0x214E911", VA = "0x214E810")]
			internal void <CreateFarmCells>b__1(UnityEngine.Texture obj)
			{
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C9F")]
			[Address(RVA = "0x214E880", Offset = "0x214E981", VA = "0x214E880")]
			internal void <CreateFarmCells>b__2(UnityEngine.Texture obj)
			{
			}

			// Token: 0x06006B1A RID: 27418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA0")]
			[Address(RVA = "0x214E8F0", Offset = "0x214E9F1", VA = "0x214E8F0")]
			internal void <CreateFarmCells>b__3(UnityEngine.Texture obj)
			{
			}

			// Token: 0x06006B1B RID: 27419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA1")]
			[Address(RVA = "0x214E960", Offset = "0x214EA61", VA = "0x214E960")]
			internal void <CreateFarmCells>b__4(UnityEngine.Texture obj)
			{
			}

			// Token: 0x06006B1C RID: 27420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA2")]
			[Address(RVA = "0x214E9D0", Offset = "0x214EAD1", VA = "0x214E9D0")]
			internal void <CreateFarmCells>b__5(UnityEngine.Texture obj)
			{
			}

			// Token: 0x040172D3 RID: 94931
			[Token(Token = "0x401C01D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject cultivateset;

			// Token: 0x040172D4 RID: 94932
			[Token(Token = "0x401C01E")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Texture[] tex;
		}

		// Token: 0x02001087 RID: 4231
		[Token(Token = "0x200153D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D80", Offset = "0x159E81")]
		private sealed class <CreateFarmCells>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B1D RID: 27421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA3")]
			[Address(RVA = "0x214DA90", Offset = "0x214DB91", VA = "0x214DA90")]
			[DebuggerHidden]
			public <CreateFarmCells>d__21(int <>1__state)
			{
			}

			// Token: 0x06006B1E RID: 27422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA4")]
			[Address(RVA = "0x214EC30", Offset = "0x214ED31", VA = "0x214EC30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B1F RID: 27423 RVA: 0x00024A08 File Offset: 0x00022C08
			[Token(Token = "0x6007CA5")]
			[Address(RVA = "0x214EC40", Offset = "0x214ED41", VA = "0x214EC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x06006B20 RID: 27424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9F")]
			private object Current
			{
				[Token(Token = "0x6007CA6")]
				[Address(RVA = "0x2150610", Offset = "0x2150711", VA = "0x2150610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B21 RID: 27425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA7")]
			[Address(RVA = "0x2150620", Offset = "0x2150721", VA = "0x2150620", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06006B22 RID: 27426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA0")]
			private object Current
			{
				[Token(Token = "0x6007CA8")]
				[Address(RVA = "0x2150680", Offset = "0x2150781", VA = "0x2150680", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172D5 RID: 94933
			[Token(Token = "0x401C01F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172D6 RID: 94934
			[Token(Token = "0x401C020")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172D7 RID: 94935
			[Token(Token = "0x401C021")]
			[FieldOffset(Offset = "0x20")]
			private FarmController.<>c__DisplayClass21_0 <>8__1;

			// Token: 0x040172D8 RID: 94936
			[Token(Token = "0x401C022")]
			[FieldOffset(Offset = "0x28")]
			public FarmController <>4__this;

			// Token: 0x040172D9 RID: 94937
			[Token(Token = "0x401C023")]
			[FieldOffset(Offset = "0x30")]
			public UnityAction callback;

			// Token: 0x040172DA RID: 94938
			[Token(Token = "0x401C024")]
			[FieldOffset(Offset = "0x38")]
			private string <texNo>5__2;
		}

		// Token: 0x02001088 RID: 4232
		[Token(Token = "0x200153E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D90", Offset = "0x159E91")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06006B23 RID: 27427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CA9")]
			[Address(RVA = "0x214EA40", Offset = "0x214EB41", VA = "0x214EA40")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06006B24 RID: 27428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CAA")]
			[Address(RVA = "0x214EA50", Offset = "0x214EB51", VA = "0x214EA50")]
			internal void <LoadTexture>b__0(AssetHandle<UnityEngine.Texture> handle)
			{
			}

			// Token: 0x040172DB RID: 94939
			[Token(Token = "0x401C025")]
			[FieldOffset(Offset = "0x10")]
			public UnityEngine.Texture texture;
		}

		// Token: 0x02001089 RID: 4233
		[Token(Token = "0x200153F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DA0", Offset = "0x159EA1")]
		private sealed class <LoadTexture>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B25 RID: 27429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CAB")]
			[Address(RVA = "0x214DB70", Offset = "0x214DC71", VA = "0x214DB70")]
			[DebuggerHidden]
			public <LoadTexture>d__22(int <>1__state)
			{
			}

			// Token: 0x06006B26 RID: 27430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CAC")]
			[Address(RVA = "0x2150690", Offset = "0x2150791", VA = "0x2150690", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B27 RID: 27431 RVA: 0x00024A20 File Offset: 0x00022C20
			[Token(Token = "0x6007CAD")]
			[Address(RVA = "0x21506A0", Offset = "0x21507A1", VA = "0x21506A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06006B28 RID: 27432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA1")]
			private object Current
			{
				[Token(Token = "0x6007CAE")]
				[Address(RVA = "0x2150930", Offset = "0x2150A31", VA = "0x2150930", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B29 RID: 27433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CAF")]
			[Address(RVA = "0x2150940", Offset = "0x2150A41", VA = "0x2150940", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06006B2A RID: 27434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA2")]
			private object Current
			{
				[Token(Token = "0x6007CB0")]
				[Address(RVA = "0x21509A0", Offset = "0x2150AA1", VA = "0x21509A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172DC RID: 94940
			[Token(Token = "0x401C026")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172DD RID: 94941
			[Token(Token = "0x401C027")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172DE RID: 94942
			[Token(Token = "0x401C028")]
			[FieldOffset(Offset = "0x20")]
			public string texName;

			// Token: 0x040172DF RID: 94943
			[Token(Token = "0x401C029")]
			[FieldOffset(Offset = "0x28")]
			private FarmController.<>c__DisplayClass22_0 <>8__1;

			// Token: 0x040172E0 RID: 94944
			[Token(Token = "0x401C02A")]
			[FieldOffset(Offset = "0x30")]
			public FarmController <>4__this;

			// Token: 0x040172E1 RID: 94945
			[Token(Token = "0x401C02B")]
			[FieldOffset(Offset = "0x38")]
			public UnityAction<UnityEngine.Texture> callback;

			// Token: 0x040172E2 RID: 94946
			[Token(Token = "0x401C02C")]
			[FieldOffset(Offset = "0x40")]
			private Loader.ID.Texture <textureId>5__2;
		}

		// Token: 0x0200108A RID: 4234
		[Token(Token = "0x2001540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DB0", Offset = "0x159EB1")]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06006B2B RID: 27435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB1")]
			[Address(RVA = "0x214DDD0", Offset = "0x214DED1", VA = "0x214DDD0")]
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x06006B2C RID: 27436 RVA: 0x00024A38 File Offset: 0x00022C38
			[Token(Token = "0x6007CB2")]
			[Address(RVA = "0x214EAD0", Offset = "0x214EBD1", VA = "0x214EAD0")]
			internal bool <GetCellController>b__0(CellController cell)
			{
				return default(bool);
			}

			// Token: 0x040172E3 RID: 94947
			[Token(Token = "0x401C02D")]
			[FieldOffset(Offset = "0x10")]
			public Vector3Int cellSetId;

			// Token: 0x040172E4 RID: 94948
			[Token(Token = "0x401C02E")]
			[FieldOffset(Offset = "0x1C")]
			public int cellId;
		}

		// Token: 0x0200108B RID: 4235
		[Token(Token = "0x2001541")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DC0", Offset = "0x159EC1")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x06006B2D RID: 27437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB3")]
			[Address(RVA = "0x214DEC0", Offset = "0x214DFC1", VA = "0x214DEC0")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x06006B2E RID: 27438 RVA: 0x00024A50 File Offset: 0x00022C50
			[Token(Token = "0x6007CB4")]
			[Address(RVA = "0x214EB90", Offset = "0x214EC91", VA = "0x214EB90")]
			internal bool <GetCellSetController>b__0(CellController cell)
			{
				return default(bool);
			}

			// Token: 0x040172E5 RID: 94949
			[Token(Token = "0x401C02F")]
			[FieldOffset(Offset = "0x10")]
			public Vector3Int cellSetId;
		}

		// Token: 0x0200108C RID: 4236
		[Token(Token = "0x2001542")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DD0", Offset = "0x159ED1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006B30 RID: 27440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB6")]
			[Address(RVA = "0x214E6F0", Offset = "0x214E7F1", VA = "0x214E6F0")]
			public <>c()
			{
			}

			// Token: 0x06006B31 RID: 27441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB7")]
			[Address(RVA = "0x214E700", Offset = "0x214E801", VA = "0x214E700")]
			internal void <Start>b__26_0()
			{
			}

			// Token: 0x040172E6 RID: 94950
			[Token(Token = "0x401C030")]
			[FieldOffset(Offset = "0x0")]
			public static readonly FarmController.<>c <>9;

			// Token: 0x040172E7 RID: 94951
			[Token(Token = "0x401C031")]
			[FieldOffset(Offset = "0x8")]
			public static UnityAction <>9__26_0;
		}

		// Token: 0x0200108D RID: 4237
		[Token(Token = "0x2001543")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159DE0", Offset = "0x159EE1")]
		private sealed class <Start>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B32 RID: 27442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB8")]
			[Address(RVA = "0x214DF50", Offset = "0x214E051", VA = "0x214DF50")]
			[DebuggerHidden]
			public <Start>d__26(int <>1__state)
			{
			}

			// Token: 0x06006B33 RID: 27443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CB9")]
			[Address(RVA = "0x21509B0", Offset = "0x2150AB1", VA = "0x21509B0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B34 RID: 27444 RVA: 0x00024A68 File Offset: 0x00022C68
			[Token(Token = "0x6007CBA")]
			[Address(RVA = "0x21509C0", Offset = "0x2150AC1", VA = "0x21509C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06006B35 RID: 27445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA3")]
			private object Current
			{
				[Token(Token = "0x6007CBB")]
				[Address(RVA = "0x2151200", Offset = "0x2151301", VA = "0x2151200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B36 RID: 27446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CBC")]
			[Address(RVA = "0x2151210", Offset = "0x2151311", VA = "0x2151210", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06006B37 RID: 27447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA4")]
			private object Current
			{
				[Token(Token = "0x6007CBD")]
				[Address(RVA = "0x2151270", Offset = "0x2151371", VA = "0x2151270", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172E8 RID: 94952
			[Token(Token = "0x401C032")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172E9 RID: 94953
			[Token(Token = "0x401C033")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172EA RID: 94954
			[Token(Token = "0x401C034")]
			[FieldOffset(Offset = "0x20")]
			public FarmController <>4__this;
		}
	}
}
