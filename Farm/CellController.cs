using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace Farm
{
	// Token: 0x02001080 RID: 4224
	[Token(Token = "0x2000AB2")]
	public class CellController : MonoBehaviour, InteractionInterface, FocusInterface, ItemInteractionInterface, PlowInteractionInterface, ToolInteractionInterface, SmashInteractionInterface, PotInteractionInterface, SowInteractionInterface, SlashInteractionInterface, ChopInteractionInterface, FarmDrugInteractionInterface
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x00024720 File Offset: 0x00022920
		// (set) Token: 0x06006AB1 RID: 27313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAF")]
		public FarmManager.FARM_ID FarmId
		{
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0x21CA040", Offset = "0x21CA141", VA = "0x21CA040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADC70", Offset = "0x1ADD71")]
			get
			{
				return FarmManager.FARM_ID.RF4_FREEFARM_ID_Village;
			}
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0x21CA030", Offset = "0x21CA131", VA = "0x21CA030")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADC60", Offset = "0x1ADD61")]
			set
			{
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x00024738 File Offset: 0x00022938
		// (set) Token: 0x06006AB3 RID: 27315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB0")]
		public int CellId
		{
			[Token(Token = "0x60058D3")]
			[Address(RVA = "0x21CA060", Offset = "0x21CA161", VA = "0x21CA060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADC90", Offset = "0x1ADD91")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0x21CA050", Offset = "0x21CA151", VA = "0x21CA050")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADC80", Offset = "0x1ADD81")]
			set
			{
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x00024750 File Offset: 0x00022950
		// (set) Token: 0x06006AB6 RID: 27318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB1")]
		public Vector3Int CellSetId
		{
			[Token(Token = "0x60058D4")]
			[Address(RVA = "0x21CA070", Offset = "0x21CA171", VA = "0x21CA070")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCA0", Offset = "0x1ADDA1")]
			get
			{
				return default(Vector3Int);
			}
			[Token(Token = "0x60058D5")]
			[Address(RVA = "0x21CA080", Offset = "0x21CA181", VA = "0x21CA080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCB0", Offset = "0x1ADDB1")]
			set
			{
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06006AB7 RID: 27319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AB8 RID: 27320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB2")]
		public ItemData CropItemData
		{
			[Token(Token = "0x60058D6")]
			[Address(RVA = "0x21CA090", Offset = "0x21CA191", VA = "0x21CA090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCC0", Offset = "0x1ADDC1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058D7")]
			[Address(RVA = "0x21CA0A0", Offset = "0x21CA1A1", VA = "0x21CA0A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCD0", Offset = "0x1ADDD1")]
			set
			{
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x00024768 File Offset: 0x00022968
		// (set) Token: 0x06006ABA RID: 27322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB3")]
		public CropDataTable CropData
		{
			[Token(Token = "0x60058D8")]
			[Address(RVA = "0x21CA0B0", Offset = "0x21CA1B1", VA = "0x21CA0B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCE0", Offset = "0x1ADDE1")]
			get
			{
				return default(CropDataTable);
			}
			[Token(Token = "0x60058D9")]
			[Address(RVA = "0x21CA0C0", Offset = "0x21CA1C1", VA = "0x21CA0C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADCF0", Offset = "0x1ADDF1")]
			set
			{
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06006ABB RID: 27323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB4")]
		public CellSetController GetCellSetController
		{
			[Token(Token = "0x60058DA")]
			[Address(RVA = "0x21CA0F0", Offset = "0x21CA1F1", VA = "0x21CA0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06006ABD RID: 27325 RVA: 0x00024780 File Offset: 0x00022980
		// (set) Token: 0x06006ABC RID: 27324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB5")]
		public Vector2 CellPositionInFarm
		{
			[Token(Token = "0x60058DC")]
			[Address(RVA = "0x21CA110", Offset = "0x21CA211", VA = "0x21CA110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADD10", Offset = "0x1ADE11")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60058DB")]
			[Address(RVA = "0x21CA100", Offset = "0x21CA201", VA = "0x21CA100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADD00", Offset = "0x1ADE01")]
			set
			{
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06006ABE RID: 27326 RVA: 0x00024798 File Offset: 0x00022998
		[Token(Token = "0x17000AB6")]
		public bool Focusable
		{
			[Token(Token = "0x60058DD")]
			[Address(RVA = "0x21CA120", Offset = "0x21CA221", VA = "0x21CA120", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06006ABF RID: 27327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AC0 RID: 27328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB7")]
		public SoilStatus GetSoilStatus
		{
			[Token(Token = "0x60058DE")]
			[Address(RVA = "0x21CA130", Offset = "0x21CA231", VA = "0x21CA130")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058DF")]
			[Address(RVA = "0x21CA140", Offset = "0x21CA241", VA = "0x21CA140")]
			set
			{
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06006AC1 RID: 27329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006AC2 RID: 27330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AB8")]
		public PlantStatus GetPlantStatus
		{
			[Token(Token = "0x60058E0")]
			[Address(RVA = "0x21CA150", Offset = "0x21CA251", VA = "0x21CA150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058E1")]
			[Address(RVA = "0x21CA160", Offset = "0x21CA261", VA = "0x21CA160")]
			set
			{
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06006AC3 RID: 27331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB9")]
		public string ItemInteractionButtonHint
		{
			[Token(Token = "0x60058E2")]
			[Address(RVA = "0x21CA170", Offset = "0x21CA271", VA = "0x21CA170")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06006AC4 RID: 27332 RVA: 0x000247B0 File Offset: 0x000229B0
		[Token(Token = "0x17000ABA")]
		public FocusObjectType FocusObjectType
		{
			[Token(Token = "0x60058E3")]
			[Address(RVA = "0x21CA1D0", Offset = "0x21CA2D1", VA = "0x21CA1D0", Slot = "13")]
			get
			{
				return FocusObjectType.Default;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x000247C8 File Offset: 0x000229C8
		[Token(Token = "0x17000ABB")]
		public int FocusPriority
		{
			[Token(Token = "0x60058E4")]
			[Address(RVA = "0x21CA1E0", Offset = "0x21CA2E1", VA = "0x21CA1E0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06006AC6 RID: 27334 RVA: 0x000247E0 File Offset: 0x000229E0
		[Token(Token = "0x17000ABC")]
		public FocusPointType FocusPointType
		{
			[Token(Token = "0x60058E5")]
			[Address(RVA = "0x21CA1F0", Offset = "0x21CA2F1", VA = "0x21CA1F0", Slot = "15")]
			get
			{
				return FocusPointType.HitPoint;
			}
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E6")]
		[Address(RVA = "0x21CA200", Offset = "0x21CA301", VA = "0x21CA200")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x21CA2D0", Offset = "0x21CA3D1", VA = "0x21CA2D0")]
		public void CheckEquipedItem()
		{
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E8")]
		[Address(RVA = "0x21CA530", Offset = "0x21CA631", VA = "0x21CA530", Slot = "12")]
		public void OffFocus()
		{
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058E9")]
		[Address(RVA = "0x21CA560", Offset = "0x21CA661", VA = "0x21CA560", Slot = "11")]
		public void OnFocus()
		{
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x000247F8 File Offset: 0x000229F8
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0x21CA5D0", Offset = "0x21CA6D1", VA = "0x21CA5D0", Slot = "16")]
		public ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x06006ACC RID: 27340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0x21CA5E0", Offset = "0x21CA6E1", VA = "0x21CA5E0", Slot = "9")]
		public string GetFocusName()
		{
			return null;
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00024810 File Offset: 0x00022A10
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x21CA8D0", Offset = "0x21CA9D1", VA = "0x21CA8D0", Slot = "23")]
		public bool CanPlow(HumanController humanController)
		{
			return default(bool);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x21CAAE0", Offset = "0x21CABE1", VA = "0x21CAAE0", Slot = "22")]
		public void DoPlow(HumanController humanController)
		{
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x00024828 File Offset: 0x00022A28
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x21CB020", Offset = "0x21CB121", VA = "0x21CB020", Slot = "31")]
		public bool CanSow(HumanController human, SeedItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x21CB0E0", Offset = "0x21CB1E1", VA = "0x21CB0E0", Slot = "30")]
		public void DoSow(HumanController human, SeedItemData itemData)
		{
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00024840 File Offset: 0x00022A40
		[Token(Token = "0x60058F0")]
		[Address(RVA = "0x21CBFB0", Offset = "0x21CC0B1", VA = "0x21CBFB0", Slot = "29")]
		public bool CanUsePot(HumanController humanController, EquipItemData equipItemData, bool isRange)
		{
			return default(bool);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00024858 File Offset: 0x00022A58
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x21CC0B0", Offset = "0x21CC1B1", VA = "0x21CC0B0", Slot = "28")]
		public bool UsePot(HumanController humanController, EquipItemData equipItemData)
		{
			return default(bool);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x00024870 File Offset: 0x00022A70
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x21CC250", Offset = "0x21CC351", VA = "0x21CC250", Slot = "25")]
		public bool CanSmash(HumanController humanController)
		{
			return default(bool);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x21CC2B0", Offset = "0x21CC3B1", VA = "0x21CC2B0", Slot = "24")]
		public void DoSmash(HumanController humanController)
		{
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x21CC500", Offset = "0x21CC601", VA = "0x21CC500", Slot = "26")]
		public void DoBreak(HumanController humanController)
		{
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00024888 File Offset: 0x00022A88
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x21CC510", Offset = "0x21CC611", VA = "0x21CC510", Slot = "27")]
		public bool CanBreak(HumanController humanController)
		{
			return default(bool);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x000248A0 File Offset: 0x00022AA0
		[Token(Token = "0x60058F6")]
		[Address(RVA = "0x21CC520", Offset = "0x21CC621", VA = "0x21CC520", Slot = "33")]
		public bool CanSlash(HumanController humanController)
		{
			return default(bool);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F7")]
		[Address(RVA = "0x21CC570", Offset = "0x21CC671", VA = "0x21CC570", Slot = "32")]
		public void DoSlash(HumanController humanController)
		{
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F8")]
		[Address(RVA = "0x21CC8A0", Offset = "0x21CC9A1", VA = "0x21CC8A0", Slot = "34")]
		public void DoChop(HumanController humanController)
		{
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x000248B8 File Offset: 0x00022AB8
		[Token(Token = "0x60058F9")]
		[Address(RVA = "0x21CC9D0", Offset = "0x21CCAD1", VA = "0x21CC9D0", Slot = "35")]
		public bool CanChop(HumanController humanController)
		{
			return default(bool);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x21CCA10", Offset = "0x21CCB11", VA = "0x21CCA10", Slot = "36")]
		public void DoSpray(HumanController human, ItemData itemData)
		{
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x000248D0 File Offset: 0x00022AD0
		[Token(Token = "0x60058FB")]
		[Address(RVA = "0x21CCC40", Offset = "0x21CCD41", VA = "0x21CCC40", Slot = "37")]
		public bool CanSpray(HumanController human, ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FC")]
		[Address(RVA = "0x21CCC80", Offset = "0x21CCD81", VA = "0x21CCC80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADD20", Offset = "0x1ADE21")]
		public IEnumerator ChangeCropData(int growLv, [Optional] Action<CropDataTable> callback)
		{
			return null;
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FD")]
		[Address(RVA = "0x21CCD50", Offset = "0x21CCE51", VA = "0x21CCD50")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADD90", Offset = "0x1ADE91")]
		public IEnumerator ChangeCropData(bool isGrow)
		{
			return null;
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x21CAF30", Offset = "0x21CB031", VA = "0x21CAF30")]
		public static void playEffect(EffectID effectId, Vector3 position, float scale = 2f)
		{
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0x21CCE10", Offset = "0x21CCF11", VA = "0x21CCE10")]
		public static CellController getHittingCell(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005900")]
		[Address(RVA = "0x21CCFC0", Offset = "0x21CD0C1", VA = "0x21CCFC0")]
		private void Start()
		{
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005901")]
		[Address(RVA = "0x21CD120", Offset = "0x21CD221", VA = "0x21CD120")]
		private void OnDisable()
		{
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005902")]
		[Address(RVA = "0x21CD130", Offset = "0x21CD231", VA = "0x21CD130")]
		private void OnEnable()
		{
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005903")]
		[Address(RVA = "0x21CD140", Offset = "0x21CD241", VA = "0x21CD140")]
		private void Harvest(HumanController chracter, bool isItemInteraction)
		{
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005904")]
		[Address(RVA = "0x21CD8F0", Offset = "0x21CD9F1", VA = "0x21CD8F0", Slot = "4")]
		public void DoInteraction(HumanController character)
		{
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x000248E8 File Offset: 0x00022AE8
		[Token(Token = "0x6005905")]
		[Address(RVA = "0x21CD900", Offset = "0x21CDA01", VA = "0x21CD900", Slot = "5")]
		public bool CanInteraction(HumanController character)
		{
			return default(bool);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005906")]
		[Address(RVA = "0x21CD990", Offset = "0x21CDA91", VA = "0x21CD990", Slot = "8")]
		public string GetInteractionButtonHint()
		{
			return null;
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005907")]
		[Address(RVA = "0x21CD9E0", Offset = "0x21CDAE1", VA = "0x21CD9E0", Slot = "19")]
		public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00024900 File Offset: 0x00022B00
		[Token(Token = "0x6005908")]
		[Address(RVA = "0x21CD9F0", Offset = "0x21CDAF1", VA = "0x21CD9F0", Slot = "20")]
		public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
			return default(bool);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00024918 File Offset: 0x00022B18
		[Token(Token = "0x6005909")]
		[Address(RVA = "0x21CDB00", Offset = "0x21CDC01", VA = "0x21CDB00", Slot = "21")]
		public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590A")]
		[Address(RVA = "0x21CBF00", Offset = "0x21CC001", VA = "0x21CBF00")]
		public void ResetCell()
		{
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590B")]
		[Address(RVA = "0x21CDB10", Offset = "0x21CDC11", VA = "0x21CDB10")]
		public void DoFarmAction(FarmManager.FARM_MONSTER_TASK task, ItemData seedItemData)
		{
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590C")]
		[Address(RVA = "0x21CE380", Offset = "0x21CE481", VA = "0x21CE380", Slot = "6")]
		public void DoInteraction(MonsterControllerBase character)
		{
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00024930 File Offset: 0x00022B30
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x21CE390", Offset = "0x21CE491", VA = "0x21CE390", Slot = "7")]
		public bool CanInteraction(MonsterControllerBase character)
		{
			return default(bool);
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590E")]
		[Address(RVA = "0x21CE3A0", Offset = "0x21CE4A1", VA = "0x21CE3A0")]
		public CellController()
		{
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600590F")]
		[Address(RVA = "0x21CE3B0", Offset = "0x21CE4B1", VA = "0x21CE3B0", Slot = "17")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005910")]
		[Address(RVA = "0x21CE3C0", Offset = "0x21CE4C1", VA = "0x21CE3C0", Slot = "18")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x040172AF RID: 94895
		[Token(Token = "0x4013EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CellSetController cellSetController;

		// Token: 0x040172B0 RID: 94896
		[Token(Token = "0x4013EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SoilStatus soilStatus;

		// Token: 0x040172B1 RID: 94897
		[Token(Token = "0x4013EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PlantStatus plantStatus;

		// Token: 0x040172B2 RID: 94898
		[Token(Token = "0x4013EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _tPosition;

		// Token: 0x040172B3 RID: 94899
		[Token(Token = "0x4013EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool largeCursor;

		// Token: 0x040172B4 RID: 94900
		[Token(Token = "0x4013EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool _isEnableCells;

		// Token: 0x040172B5 RID: 94901
		[Token(Token = "0x4013EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool _isMeteor;

		// Token: 0x040172B6 RID: 94902
		[Token(Token = "0x4013EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180CB0", Offset = "0x180DB1")]
		private FarmManager.FARM_ID <FarmId>k__BackingField;

		// Token: 0x040172B7 RID: 94903
		[Token(Token = "0x4013EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180CC0", Offset = "0x180DC1")]
		private int <CellId>k__BackingField;

		// Token: 0x040172B8 RID: 94904
		[Token(Token = "0x4013EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180CD0", Offset = "0x180DD1")]
		private Vector3Int <CellSetId>k__BackingField;

		// Token: 0x040172B9 RID: 94905
		[Token(Token = "0x4013EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180CE0", Offset = "0x180DE1")]
		private ItemData <CropItemData>k__BackingField;

		// Token: 0x040172BA RID: 94906
		[Token(Token = "0x4013EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180CF0", Offset = "0x180DF1")]
		private CropDataTable <CropData>k__BackingField;

		// Token: 0x040172BB RID: 94907
		[Token(Token = "0x4013EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private GameObject FarmRunePrefab;

		// Token: 0x040172BC RID: 94908
		[Token(Token = "0x4013EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180D00", Offset = "0x180E01")]
		private Vector2 <CellPositionInFarm>k__BackingField;

		// Token: 0x02001081 RID: 4225
		[Token(Token = "0x200153A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D50", Offset = "0x159E51")]
		private sealed class <ChangeCropData>d__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006AF2 RID: 27378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C90")]
			[Address(RVA = "0x21CCD20", Offset = "0x21CCE21", VA = "0x21CCD20")]
			[DebuggerHidden]
			public <ChangeCropData>d__72(int <>1__state)
			{
			}

			// Token: 0x06006AF3 RID: 27379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C91")]
			[Address(RVA = "0x21CE3D0", Offset = "0x21CE4D1", VA = "0x21CE3D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006AF4 RID: 27380 RVA: 0x00024948 File Offset: 0x00022B48
			[Token(Token = "0x6007C92")]
			[Address(RVA = "0x21CE3E0", Offset = "0x21CE4E1", VA = "0x21CE3E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9B")]
			private object Current
			{
				[Token(Token = "0x6007C93")]
				[Address(RVA = "0x21CE630", Offset = "0x21CE731", VA = "0x21CE630", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006AF6 RID: 27382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C94")]
			[Address(RVA = "0x21CE640", Offset = "0x21CE741", VA = "0x21CE640", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9C")]
			private object Current
			{
				[Token(Token = "0x6007C95")]
				[Address(RVA = "0x21CE6A0", Offset = "0x21CE7A1", VA = "0x21CE6A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172BD RID: 94909
			[Token(Token = "0x401C014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172BE RID: 94910
			[Token(Token = "0x401C015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172BF RID: 94911
			[Token(Token = "0x401C016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CellController <>4__this;

			// Token: 0x040172C0 RID: 94912
			[Token(Token = "0x401C017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int growLv;

			// Token: 0x040172C1 RID: 94913
			[Token(Token = "0x401C018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<CropDataTable> callback;
		}

		// Token: 0x02001082 RID: 4226
		[Token(Token = "0x200153B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D60", Offset = "0x159E61")]
		private sealed class <ChangeCropData>d__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006AF8 RID: 27384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C96")]
			[Address(RVA = "0x21CCDE0", Offset = "0x21CCEE1", VA = "0x21CCDE0")]
			[DebuggerHidden]
			public <ChangeCropData>d__73(int <>1__state)
			{
			}

			// Token: 0x06006AF9 RID: 27385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C97")]
			[Address(RVA = "0x21CE6B0", Offset = "0x21CE7B1", VA = "0x21CE6B0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006AFA RID: 27386 RVA: 0x00024960 File Offset: 0x00022B60
			[Token(Token = "0x6007C98")]
			[Address(RVA = "0x21CE6C0", Offset = "0x21CE7C1", VA = "0x21CE6C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06006AFB RID: 27387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9D")]
			private object Current
			{
				[Token(Token = "0x6007C99")]
				[Address(RVA = "0x21CE7F0", Offset = "0x21CE8F1", VA = "0x21CE7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006AFC RID: 27388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C9A")]
			[Address(RVA = "0x21CE800", Offset = "0x21CE901", VA = "0x21CE800", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06006AFD RID: 27389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E9E")]
			private object Current
			{
				[Token(Token = "0x6007C9B")]
				[Address(RVA = "0x21CE860", Offset = "0x21CE961", VA = "0x21CE860", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040172C2 RID: 94914
			[Token(Token = "0x401C019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040172C3 RID: 94915
			[Token(Token = "0x401C01A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040172C4 RID: 94916
			[Token(Token = "0x401C01B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool isGrow;

			// Token: 0x040172C5 RID: 94917
			[Token(Token = "0x401C01C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CellController <>4__this;
		}
	}
}
