using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Field;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

namespace Farm
{
	// Token: 0x02001092 RID: 4242
	[Token(Token = "0x2000AB8")]
	public class FarmManager : SingletonMonoBehaviour<FarmManager>
	{
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x00024AB0 File Offset: 0x00022CB0
		// (set) Token: 0x06006B4E RID: 27470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC2")]
		public bool IsDataInitialize
		{
			[Token(Token = "0x6005932")]
			[Address(RVA = "0x2151B00", Offset = "0x2151C01", VA = "0x2151B00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE060", Offset = "0x1AE161")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005933")]
			[Address(RVA = "0x2151B10", Offset = "0x2151C11", VA = "0x2151B10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE070", Offset = "0x1AE171")]
			set
			{
			}
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005934")]
		[Address(RVA = "0x2151B20", Offset = "0x2151C21", VA = "0x2151B20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005935")]
		[Address(RVA = "0x2151CE0", Offset = "0x2151DE1", VA = "0x2151CE0")]
		private void Start()
		{
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005936")]
		[Address(RVA = "0x21523A0", Offset = "0x21524A1", VA = "0x21523A0")]
		private void Update()
		{
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005937")]
		[Address(RVA = "0x2151E40", Offset = "0x2151F41", VA = "0x2151E40")]
		public void FarmDataInitialize()
		{
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x214DFF0", Offset = "0x214E0F1", VA = "0x214DFF0")]
		public void ChangeFarmScene(FarmManager.FARM_ID farmId, [Optional] FarmController farmController)
		{
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005939")]
		[Address(RVA = "0x2155AA0", Offset = "0x2155BA1", VA = "0x2155AA0")]
		private void rf4FreeFarmInit()
		{
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593A")]
		[Address(RVA = "0x21578C0", Offset = "0x21579C1", VA = "0x21578C0")]
		public void CreateTutorialObstacle()
		{
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600593B")]
		[Address(RVA = "0x2157F60", Offset = "0x2158061", VA = "0x2157F60")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE080", Offset = "0x1AE181")]
		public static IEnumerator createFurniture()
		{
			return null;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593C")]
		[Address(RVA = "0x2157FC0", Offset = "0x21580C1", VA = "0x2157FC0")]
		public void FarmDataSave()
		{
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593D")]
		[Address(RVA = "0x2157030", Offset = "0x2157131", VA = "0x2157030")]
		public void FarmDataLoad()
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00024AC8 File Offset: 0x00022CC8
		[Token(Token = "0x600593E")]
		[Address(RVA = "0x2157E20", Offset = "0x2157F21", VA = "0x2157E20")]
		public static int getSerialCellId(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId = -1)
		{
			return 0;
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593F")]
		[Address(RVA = "0x2157D00", Offset = "0x2157E01", VA = "0x2157D00")]
		public static void getCellIdfromSerialId(FarmManager.FARM_ID _farmId, int serialcellid, ref Vector3Int _cellSetId, ref int _cellId)
		{
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005940")]
		[Address(RVA = "0x21584D0", Offset = "0x21585D1", VA = "0x21584D0")]
		public void FarmCropDataListUpdate(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId, [Optional] ItemData _itemData, [Optional] CropDataTable? _cropData, [Optional] SoilStatus _soilStatus, [Optional] PlantStatus _plantStatus, bool _isDataReset = false)
		{
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005941")]
		[Address(RVA = "0x2158BF0", Offset = "0x2158CF1", VA = "0x2158BF0")]
		public FarmCropData GetFarmCropCellData(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId)
		{
			return null;
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005942")]
		[Address(RVA = "0x2150510", Offset = "0x2150611", VA = "0x2150510")]
		public List<FarmCropData> GetFarmCropCellSetData(FarmManager.FARM_ID farmId, Vector3Int cellSetId)
		{
			return null;
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005943")]
		[Address(RVA = "0x2159390", Offset = "0x2159491", VA = "0x2159390")]
		public void SetFarmCropData(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId, FarmCropData farmCropData)
		{
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005944")]
		[Address(RVA = "0x2159530", Offset = "0x2159631", VA = "0x2159530")]
		private void checkFarm2Second(int elapsedSec)
		{
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005945")]
		[Address(RVA = "0x2159680", Offset = "0x2159781", VA = "0x2159680")]
		private void checkFarm2Hour(int elapsedHour)
		{
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005946")]
		[Address(RVA = "0x2159830", Offset = "0x2159931", VA = "0x2159830")]
		private void checkFarm2Day(int elapsedDay)
		{
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005947")]
		[Address(RVA = "0x2150480", Offset = "0x2150581", VA = "0x2150480")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE0F0", Offset = "0x1AE1F1")]
		public IEnumerator LoadCropPrefab(Prefab prefabId, [Optional] UnityAction<GameObject> callback)
		{
			return null;
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005948")]
		[Address(RVA = "0x21519E0", Offset = "0x2151AE1", VA = "0x21519E0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE160", Offset = "0x1AE261")]
		public IEnumerator GetMonsterHutFlags(FarmManager.FARM_ID farmId, UnityAction<bool[]> callback)
		{
			return null;
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005949")]
		[Address(RVA = "0x2159EC0", Offset = "0x2159FC1", VA = "0x2159EC0")]
		public void SetMonsterHutFlag(FarmManager.FARM_ID farmId, int monsterHutId, bool status)
		{
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594A")]
		[Address(RVA = "0x2159F90", Offset = "0x215A091", VA = "0x2159F90")]
		public void ForceGrowCrop(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId)
		{
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594B")]
		[Address(RVA = "0x215A080", Offset = "0x215A181", VA = "0x215A080")]
		public void ForceGrowCrop(ref FarmManager.RF4_CROP_STATE pCrop)
		{
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594C")]
		[Address(RVA = "0x215AA60", Offset = "0x215AB61", VA = "0x215AA60")]
		public void ForceGrowLargeCrop(FarmManager.FARM_ID farmId, Vector3Int cellSetId)
		{
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594D")]
		[Address(RVA = "0x215B990", Offset = "0x215BA91", VA = "0x215B990")]
		public void ForceChangeSeeds()
		{
		}

		// Token: 0x06006B69 RID: 27497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594E")]
		[Address(RVA = "0x215BB40", Offset = "0x215BC41", VA = "0x215BB40")]
		public void ForceChangeSeed(CellController cellController)
		{
		}

		// Token: 0x06006B6A RID: 27498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600594F")]
		[Address(RVA = "0x215C5C0", Offset = "0x215C6C1", VA = "0x215C5C0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE1D0", Offset = "0x1AE2D1")]
		public IEnumerator ForceCreateObstacle(int type)
		{
			return null;
		}

		// Token: 0x06006B6B RID: 27499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005950")]
		[Address(RVA = "0x2157670", Offset = "0x2157771", VA = "0x2157670")]
		public void ResetObstacleObject(FarmController farmController)
		{
		}

		// Token: 0x06006B6C RID: 27500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005951")]
		[Address(RVA = "0x215C630", Offset = "0x215C731", VA = "0x215C630")]
		public void ForceObstaclePickupAll()
		{
		}

		// Token: 0x06006B6D RID: 27501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x215C9A0", Offset = "0x215CAA1", VA = "0x215C9A0")]
		public void ForceHealFarmCropsAndSoils()
		{
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00024AE0 File Offset: 0x00022CE0
		[Token(Token = "0x6005953")]
		[Address(RVA = "0x215CC30", Offset = "0x215CD31", VA = "0x215CC30")]
		public int UseCrystalCount(FarmManager.FARM_ID farmID, int type)
		{
			return 0;
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00024AF8 File Offset: 0x00022CF8
		[Token(Token = "0x6005954")]
		[Address(RVA = "0x215CDA0", Offset = "0x215CEA1", VA = "0x215CDA0")]
		public bool UseCrystalCheck(FarmManager.FARM_ID farmID, int type, int hasCount)
		{
			return default(bool);
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x00024B10 File Offset: 0x00022D10
		[Token(Token = "0x6005955")]
		[Address(RVA = "0x215CF40", Offset = "0x215D041", VA = "0x215CF40")]
		public bool UseCrystal(FarmManager.FARM_ID farmID, int type)
		{
			return default(bool);
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00024B28 File Offset: 0x00022D28
		[Token(Token = "0x6005956")]
		[Address(RVA = "0x215D970", Offset = "0x215DA71", VA = "0x215D970")]
		public bool ChangeFarmSize(FarmManager.FARM_ID farmID)
		{
			return default(bool);
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005957")]
		[Address(RVA = "0x2159610", Offset = "0x2159711", VA = "0x2159610")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE240", Offset = "0x1AE341")]
		private static IEnumerator rf4WeatherWorkFunc(int elapsedSec)
		{
			return null;
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005958")]
		[Address(RVA = "0x2159700", Offset = "0x2159801", VA = "0x2159700")]
		private static void rf4FreeFarmHourFunc(int elapsedHour)
		{
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005959")]
		[Address(RVA = "0x215DC90", Offset = "0x215DD91", VA = "0x215DC90")]
		private static void rf4FreeFarmCropWater(ref FarmManager.RF4_CROP_STATE pCrop, int water)
		{
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595A")]
		[Address(RVA = "0x215E370", Offset = "0x215E471", VA = "0x215E370")]
		private void rf4FreeFarmAllWater()
		{
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595B")]
		[Address(RVA = "0x215E6D0", Offset = "0x215E7D1", VA = "0x215E6D0")]
		public void SetHoeLevelFlag(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, int hoeLevel)
		{
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x00024B40 File Offset: 0x00022D40
		[Token(Token = "0x600595C")]
		[Address(RVA = "0x215AE00", Offset = "0x215AF01", VA = "0x215AE00")]
		private static bool rf4FreeFarmCropLargeCheck(int farm_id, ref FarmManager.RF4_CROP_STATE pCrop)
		{
			return default(bool);
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595D")]
		[Address(RVA = "0x215FC20", Offset = "0x215FD21", VA = "0x215FC20")]
		public void ChangeLargeSizeCropForInactiveFarm(int farm_id, int[] cropIndexList)
		{
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595E")]
		[Address(RVA = "0x215FE30", Offset = "0x215FF31", VA = "0x215FE30")]
		private void rf4FreeFarmDayFuncCropExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, int farm_id)
		{
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600595F")]
		[Address(RVA = "0x2160F90", Offset = "0x2161091", VA = "0x2160F90")]
		private void rf4FreeFarmCropToGrassDie(FarmManager.FARM_ID farm_id, ref FarmManager.RF4_CROP_STATE pCrop)
		{
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00024B58 File Offset: 0x00022D58
		[Token(Token = "0x6005960")]
		[Address(RVA = "0x2161580", Offset = "0x2161681", VA = "0x2161580")]
		private int rf4FreeFarmDayFuncValueCalc(int now, int tag, int down_value, int up_value, int soil_state, bool compost, bool minus = false)
		{
			return 0;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005961")]
		[Address(RVA = "0x2161610", Offset = "0x2161711", VA = "0x2161610")]
		private void rf4FreeFarmDayFuncSoilExec(ref FarmManager.RF4_SOIL_INFO pSoil, bool compost)
		{
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005962")]
		[Address(RVA = "0x21599D0", Offset = "0x2159AD1", VA = "0x21599D0")]
		private void rf4FreeFarmDayFunc()
		{
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005963")]
		[Address(RVA = "0x215E7D0", Offset = "0x215E8D1", VA = "0x215E7D0")]
		private static void rf4FreeFarmPickupSoilExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, bool cut_flag = false)
		{
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005964")]
		[Address(RVA = "0x2162690", Offset = "0x2162791", VA = "0x2162690")]
		private static void rf4FreeFarmPickupSoilDamageExec(ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop, bool cut_flag = false)
		{
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005965")]
		[Address(RVA = "0x215DBE0", Offset = "0x215DCE1", VA = "0x215DBE0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE2B0", Offset = "0x1AE3B1")]
		private static IEnumerator rf4FreeFarmDamageFarm(int num, bool typhoon = false, bool init = false, bool wood = false, bool stone = false)
		{
			return null;
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005966")]
		[Address(RVA = "0x2162A80", Offset = "0x2162B81", VA = "0x2162A80")]
		public static void buildObstacle(FarmManager.FARM_ID farmId, int type, float posx, float posz, ref MineTypeID mineId, ref CropID cropId, ref ItemID itemId)
		{
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00024B70 File Offset: 0x00022D70
		[Token(Token = "0x6005967")]
		[Address(RVA = "0x21637B0", Offset = "0x21638B1", VA = "0x21637B0")]
		public static ItemID popupItemObstacleObject(FarmManager.FARM_ID farm_id, ItemID itemid, float posx, float posz)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x00024B88 File Offset: 0x00022D88
		[Token(Token = "0x6005968")]
		[Address(RVA = "0x2163B30", Offset = "0x2163C31", VA = "0x2163B30")]
		private static bool rf4FreeFarmCropCreateCheckPosGet(int farm_id, ref float x, ref float y, float r)
		{
			return default(bool);
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005969")]
		[Address(RVA = "0x21643A0", Offset = "0x21644A1", VA = "0x21643A0")]
		private static ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropSearch(int farm_id, int index)
		{
			return null;
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x00024BA0 File Offset: 0x00022DA0
		[Token(Token = "0x600596A")]
		[Address(RVA = "0x2164460", Offset = "0x2164561", VA = "0x2164460")]
		public bool rf4FreeFarmCropPickupOkCheck(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar)
		{
			return default(bool);
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596B")]
		[Address(RVA = "0x2164620", Offset = "0x2164721", VA = "0x2164620")]
		public ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropPickup(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar, ref int num, ref int cropItemLevel)
		{
			return null;
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600596C")]
		[Address(RVA = "0x2165590", Offset = "0x2165691", VA = "0x2165590")]
		private static ItemData CreateLeafWeaponData(FarmManager.FARM_ID farmId, ItemID item_id, Vector3Int cellsetid, int cellid, FarmManager.RF4_CROP_STATE pCrop, int level)
		{
			return null;
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00024BB8 File Offset: 0x00022DB8
		[Token(Token = "0x600596D")]
		[Address(RVA = "0x21660F0", Offset = "0x21661F1", VA = "0x21660F0")]
		public bool rf4FreeFarmSoilAction(int x, int y, int farm_id, ItemID item_id)
		{
			return default(bool);
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596E")]
		[Address(RVA = "0x21667F0", Offset = "0x21668F1", VA = "0x21667F0")]
		public void FarmActionChopWood(Vector3Int cellSetId, int cellId, int skill = -1, int axe_level = -1)
		{
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600596F")]
		[Address(RVA = "0x2166F60", Offset = "0x2167061", VA = "0x2166F60")]
		public static void rf4FreeFarmCultivateHeal(ItemID item_id, Vector3Int cellSetId)
		{
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005970")]
		[Address(RVA = "0x2167600", Offset = "0x2167701", VA = "0x2167600")]
		private static void rf4FreeFarmTyphoonAttack(int farm_id, int crop_index)
		{
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005971")]
		[Address(RVA = "0x2152870", Offset = "0x2152971", VA = "0x2152870")]
		public static string rf4FreeFarmLoupeDetailStrSet(FarmManager.FARM_ID _farmId, Vector3Int _cellSetId, int _cellId)
		{
			return null;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005972")]
		[Address(RVA = "0x2158CF0", Offset = "0x2158DF1", VA = "0x2158CF0")]
		private void rf4FreeFarmCropDispChange(FarmManager.RF4_CROP_STATE pCrop, bool wither = true)
		{
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005973")]
		[Address(RVA = "0x215FB30", Offset = "0x215FC31", VA = "0x215FB30")]
		public static void rf4FreeFarmCropDelete(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid)
		{
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005974")]
		[Address(RVA = "0x215C0A0", Offset = "0x215C1A1", VA = "0x215C0A0")]
		public static void rf4FreeFarmCropDelete(ref FarmManager.RF4_CROP_STATE pCrop, bool isSizeKeep = false)
		{
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005975")]
		[Address(RVA = "0x2168050", Offset = "0x2168151", VA = "0x2168050")]
		public static void rf4FreeFarmCropDeleteAll(int farm_id)
		{
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005976")]
		[Address(RVA = "0x215A360", Offset = "0x215A461", VA = "0x215A360")]
		private static void rf4FreeFarmCropInfoSetup(ref FarmManager.RF4_CROP_STATE pCrop)
		{
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00024BD0 File Offset: 0x00022DD0
		[Token(Token = "0x6005977")]
		[Address(RVA = "0x2162460", Offset = "0x2162561", VA = "0x2162460")]
		private static int rfSpdChangeSet(int lSpd, int sTargetSpd, int sSpd)
		{
			return 0;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00024BE8 File Offset: 0x00022DE8
		[Token(Token = "0x6005978")]
		[Address(RVA = "0x2168180", Offset = "0x2168281", VA = "0x2168180")]
		private static int rfCalcRandList(int[] pRand, int num)
		{
			return 0;
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005979")]
		[Address(RVA = "0x2168250", Offset = "0x2168351", VA = "0x2168250")]
		public List<CellController> GetWorkAreaCellControllers(int area)
		{
			return null;
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597A")]
		[Address(RVA = "0x21684C0", Offset = "0x21685C1", VA = "0x21684C0")]
		public List<FarmCropData> GetWorkAreaCropDatas(FarmManager.FARM_ID farmId, int area)
		{
			return null;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00024C00 File Offset: 0x00022E00
		[Token(Token = "0x600597B")]
		[Address(RVA = "0x21686D0", Offset = "0x21687D1", VA = "0x21686D0")]
		public bool CheckWorkAreaData(FarmManager.FARM_ID farmId, int area, FarmCropData farmCropData)
		{
			return default(bool);
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597C")]
		[Address(RVA = "0x2168860", Offset = "0x2168961", VA = "0x2168860")]
		private static void rf4FreeFarmPickupSoilDamageExec_Monster(FarmManager.FARM_ID id, ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop)
		{
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597D")]
		[Address(RVA = "0x2168C50", Offset = "0x2168D51", VA = "0x2168C50")]
		private static void rf4FreeFarmPickupSoilExec_Monster(FarmManager.FARM_ID farmId, ref FarmManager.RF3_FREEFARM pFarm, ref FarmManager.RF4_CROP_STATE pCrop)
		{
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600597E")]
		[Address(RVA = "0x2169630", Offset = "0x2169731", VA = "0x2169630")]
		public ref FarmManager.RF4_CROP_STATE rf4FreeFarmCropPickup_Monster(FarmManager.FARM_ID farmId, Vector3Int cellsetid, int cellid, bool isPlayerChar, ref int num, ref int cropItemLevel)
		{
			return null;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597F")]
		[Address(RVA = "0x216A1D0", Offset = "0x216A2D1", VA = "0x216A1D0")]
		public static void rf4FreeFarmCropDelete_Monster(FarmManager.FARM_ID id, Vector3Int cellsetid, int cellid)
		{
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x216A000", Offset = "0x216A101", VA = "0x216A000")]
		public static void rf4FreeFarmCropDelete_Monster(ref FarmManager.RF4_CROP_STATE pCrop, bool isSizeKeep = false)
		{
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x00024C18 File Offset: 0x00022E18
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x216A2C0", Offset = "0x216A3C1", VA = "0x216A2C0")]
		public FarmManager.FARM_MONSTER_TASK CanFarmAction(FarmCropData farmCropData)
		{
			return FarmManager.FARM_MONSTER_TASK.NONE;
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x215E000", Offset = "0x215E101", VA = "0x215E000")]
		public void DoFarmAction(FarmManager.FARM_ID farmId, FarmCropData farmCropData)
		{
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00024C30 File Offset: 0x00022E30
		[Token(Token = "0x6005983")]
		[Address(RVA = "0x2162540", Offset = "0x2162641", VA = "0x2162540")]
		public Vector3 GetFarmCropWorldPosition(FarmManager.FARM_ID farmId, Vector3Int cellSetId, int cellId)
		{
			return default(Vector3);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00024C48 File Offset: 0x00022E48
		[Token(Token = "0x6005984")]
		[Address(RVA = "0x216A330", Offset = "0x216A431", VA = "0x216A330")]
		public Vector3 GetFarmCropWorldPosition(FarmManager.FARM_ID farmId)
		{
			return default(Vector3);
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x00024C60 File Offset: 0x00022E60
		[Token(Token = "0x6005985")]
		[Address(RVA = "0x21641C0", Offset = "0x21642C1", VA = "0x21641C0")]
		private static Vector3 GetFarmCellLocalPosition(int farmId, int cellX, int cellY, int cellId)
		{
			return default(Vector3);
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x00024C78 File Offset: 0x00022E78
		[Token(Token = "0x6005986")]
		[Address(RVA = "0x215BF40", Offset = "0x215C041", VA = "0x215BF40")]
		public static int GetFreeFarmCropCurrentItemLevel(Vector3Int cellsetid, int cellid)
		{
			return 0;
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x00024C90 File Offset: 0x00022E90
		[Token(Token = "0x6005987")]
		[Address(RVA = "0x216A420", Offset = "0x216A521", VA = "0x216A420")]
		public static int CalcSlashedCropSeedLevel(HumanController human, Vector3Int cellSetId, int cellId)
		{
			return 0;
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x00024CA8 File Offset: 0x00022EA8
		[Token(Token = "0x6005988")]
		[Address(RVA = "0x216A870", Offset = "0x216A971", VA = "0x216A870")]
		private static int CalcSickleGrowRate(int cropLevel, int kamaLevel)
		{
			return 0;
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x00024CC0 File Offset: 0x00022EC0
		[Token(Token = "0x6005989")]
		[Address(RVA = "0x216A7E0", Offset = "0x216A8E1", VA = "0x216A7E0")]
		private static int CalcFreeFarmActionKamaLvUpRate(int skillLevel, int kama_level)
		{
			return 0;
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x00024CD8 File Offset: 0x00022ED8
		[Token(Token = "0x600598A")]
		[Address(RVA = "0x2160F80", Offset = "0x2161081", VA = "0x2160F80")]
		private static int FX_Mul(int val1, int val2)
		{
			return 0;
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x00024CF0 File Offset: 0x00022EF0
		[Token(Token = "0x600598B")]
		[Address(RVA = "0x2165220", Offset = "0x2165321", VA = "0x2165220")]
		private int rf3MainGoodCropNowWeek()
		{
			return 0;
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x00024D08 File Offset: 0x00022F08
		[Token(Token = "0x600598C")]
		[Address(RVA = "0x2165360", Offset = "0x2165461", VA = "0x2165360")]
		private int rf3MainBadCropNowWeek()
		{
			return 0;
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598D")]
		[Address(RVA = "0x216A960", Offset = "0x216AA61", VA = "0x216A960")]
		private List<CropDataTable> GetCropDataTableLotteryList()
		{
			return null;
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00024D20 File Offset: 0x00022F20
		[Token(Token = "0x600598E")]
		[Address(RVA = "0x216AA80", Offset = "0x216AB81", VA = "0x216AA80")]
		private int rf3MainGoodCropNextWeek()
		{
			return 0;
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00024D38 File Offset: 0x00022F38
		[Token(Token = "0x600598F")]
		[Address(RVA = "0x216AB80", Offset = "0x216AC81", VA = "0x216AB80")]
		private int rf3MainBadCropNextWeek()
		{
			return 0;
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005990")]
		[Address(RVA = "0x216AC90", Offset = "0x216AD91", VA = "0x216AC90")]
		public string GetGoodCropNowWeekName()
		{
			return null;
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005991")]
		[Address(RVA = "0x216AE70", Offset = "0x216AF71", VA = "0x216AE70")]
		public string GetBadCropNowWeekName()
		{
			return null;
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005992")]
		[Address(RVA = "0x216B050", Offset = "0x216B151", VA = "0x216B050")]
		public string GetGoodCropNextWeekName()
		{
			return null;
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005993")]
		[Address(RVA = "0x216B220", Offset = "0x216B321", VA = "0x216B220")]
		public string GetBadCropNextWeekName()
		{
			return null;
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00024D50 File Offset: 0x00022F50
		[Token(Token = "0x6005994")]
		[Address(RVA = "0x21654A0", Offset = "0x21655A1", VA = "0x21654A0")]
		public static int rf3CalcTreasureOreLevelGet(ItemID item_id, int skill, int hammer)
		{
			return 0;
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00024D68 File Offset: 0x00022F68
		[Token(Token = "0x6005995")]
		[Address(RVA = "0x216B3F0", Offset = "0x216B4F1", VA = "0x216B3F0")]
		public static int GetHammerLevel(ItemData equipItem)
		{
			return 0;
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00024D80 File Offset: 0x00022F80
		[Token(Token = "0x6005996")]
		[Address(RVA = "0x216B420", Offset = "0x216B521", VA = "0x216B420")]
		public static int GetAxeLevel(ItemData equipItem)
		{
			return 0;
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00024D98 File Offset: 0x00022F98
		[Token(Token = "0x6005997")]
		[Address(RVA = "0x216B450", Offset = "0x216B551", VA = "0x216B450")]
		public static int GetHoeLevel(ItemData equipItem)
		{
			return 0;
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00024DB0 File Offset: 0x00022FB0
		[Token(Token = "0x6005998")]
		[Address(RVA = "0x216A7B0", Offset = "0x216A8B1", VA = "0x216A7B0")]
		private static int GetSickleLevel(ItemData equipItem)
		{
			return 0;
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x00024DC8 File Offset: 0x00022FC8
		[Token(Token = "0x6005999")]
		[Address(RVA = "0x2165B60", Offset = "0x2165C61", VA = "0x2165B60")]
		private static int rf3CalcRandLevel(int difficult = 0, int skill_level = -1)
		{
			return 0;
		}

		// Token: 0x06006BB5 RID: 27573 RVA: 0x00024DE0 File Offset: 0x00022FE0
		[Token(Token = "0x600599A")]
		[Address(RVA = "0x216B480", Offset = "0x216B581", VA = "0x216B480")]
		private int rf3LengthFast(int dx, int dy)
		{
			return 0;
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x00024DF8 File Offset: 0x00022FF8
		[Token(Token = "0x600599B")]
		[Address(RVA = "0x21624C0", Offset = "0x21625C1", VA = "0x21624C0")]
		private static int CropLevelToCropItemLevel(int cropLevel)
		{
			return 0;
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00024E10 File Offset: 0x00023010
		[Token(Token = "0x600599C")]
		[Address(RVA = "0x21592D0", Offset = "0x21593D1", VA = "0x21592D0")]
		private static int CropItemLevelToCropLevel(int cropItemLevel)
		{
			return 0;
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00024E28 File Offset: 0x00023028
		[Token(Token = "0x600599D")]
		[Address(RVA = "0x2159350", Offset = "0x2159451", VA = "0x2159350")]
		public static bool IsMeteorKarekusa(ItemData cropItemData)
		{
			return default(bool);
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599E")]
		private static void removeChildObjectsSameComponent<T>(Transform transform) where T : Component
		{
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599F")]
		[Address(RVA = "0x216B580", Offset = "0x216B681", VA = "0x216B580")]
		private static void removeChildObjectsAll(Transform t)
		{
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x2167DF0", Offset = "0x2167EF1", VA = "0x2167DF0")]
		private static string strcat(ref string s1, string s2)
		{
			return null;
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00024E40 File Offset: 0x00023040
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0x2167E30", Offset = "0x2167F31", VA = "0x2167E30")]
		private static int sprintf(ref string s1, string format, params object[] args)
		{
			return 0;
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0x216B650", Offset = "0x216B751", VA = "0x216B650")]
		public FarmManager()
		{
		}

		// Token: 0x06006BBF RID: 27583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A4")]
		[Address(RVA = "0x216DB00", Offset = "0x216DC01", VA = "0x216DB00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE320", Offset = "0x1AE421")]
		private void <ChangeFarmScene>b__20_0()
		{
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A5")]
		[Address(RVA = "0x216DC20", Offset = "0x216DD21", VA = "0x216DC20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE330", Offset = "0x1AE431")]
		private void <ChangeFarmSize>b__50_0()
		{
		}

		// Token: 0x040172FE RID: 94974
		[Token(Token = "0x4013ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static FarmController ActiveFarmController;

		// Token: 0x040172FF RID: 94975
		[Token(Token = "0x4013ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FarmController villageFarmController;

		// Token: 0x04017300 RID: 94976
		[Token(Token = "0x4013ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static FarmDragonManager ActiveFarmDragonManager;

		// Token: 0x04017301 RID: 94977
		[Token(Token = "0x4013ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<List<FarmCropData>> farmCropDataList;

		// Token: 0x04017302 RID: 94978
		[Token(Token = "0x4013ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<OnGroundItem> _onGroundItems;

		// Token: 0x04017303 RID: 94979
		[Token(Token = "0x4013ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static GameObject _farmMineBasePrefab;

		// Token: 0x04017304 RID: 94980
		[Token(Token = "0x4013ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ItemID> itemHarvestIdList;

		// Token: 0x04017305 RID: 94981
		[Token(Token = "0x4013ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int[] harvestCounts;

		// Token: 0x04017306 RID: 94982
		[Token(Token = "0x4013ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180EE0", Offset = "0x180FE1")]
		private bool <IsDataInitialize>k__BackingField;

		// Token: 0x04017307 RID: 94983
		[Token(Token = "0x4013ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int[] FarmSizeLevels;

		// Token: 0x04017308 RID: 94984
		[Token(Token = "0x4013ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static GameObject FarmRunePrefab;

		// Token: 0x04017309 RID: 94985
		[Token(Token = "0x4013EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int[][] crystalUseCounts;

		// Token: 0x0401730A RID: 94986
		[Token(Token = "0x4013EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CellController cellMagnifier;

		// Token: 0x0401730B RID: 94987
		[Token(Token = "0x4013EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static FarmManager.RF3_FREEFARM _rf_free_farm;

		// Token: 0x0401730C RID: 94988
		[Token(Token = "0x4013EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static readonly Vector3Int[] FARM_SIZE;

		// Token: 0x0401730D RID: 94989
		[Token(Token = "0x4013EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static readonly Vector3[] CellIdToPosition;

		// Token: 0x0401730E RID: 94990
		[Token(Token = "0x4013EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] tutorialObstaclePoints;

		// Token: 0x0401730F RID: 94991
		[Token(Token = "0x4013EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string[] tutorialObstacleName;

		// Token: 0x04017310 RID: 94992
		[Token(Token = "0x4013EE1")]
		private const int FX32_SHIFT = 12;

		// Token: 0x04017311 RID: 94993
		[Token(Token = "0x4013EE2")]
		private const int RF3_FM_DETAIL_TXT_STR_MAX = 256;

		// Token: 0x04017312 RID: 94994
		[Token(Token = "0x4013EE3")]
		private const int RF3_CROP_STONE = 1;

		// Token: 0x04017313 RID: 94995
		[Token(Token = "0x4013EE4")]
		private const int RF3_CROP_ROCK = 2;

		// Token: 0x04017314 RID: 94996
		[Token(Token = "0x4013EE5")]
		private const int RF3_CROP_BRANCH = 3;

		// Token: 0x04017315 RID: 94997
		[Token(Token = "0x4013EE6")]
		private const int RF3_CROP_STUMP = 4;

		// Token: 0x04017316 RID: 94998
		[Token(Token = "0x4013EE7")]
		private const int RF3_CROP_PALING = 5;

		// Token: 0x04017317 RID: 94999
		[Token(Token = "0x4013EE8")]
		private const int RF3_CROP_GRASS_D = 20;

		// Token: 0x04017318 RID: 95000
		[Token(Token = "0x4013EE9")]
		private const int RF3_CROP_S_ROCK = 22;

		// Token: 0x04017319 RID: 95001
		[Token(Token = "0x4013EEA")]
		private const int RF3_ITEM_LEVELMIN = 0;

		// Token: 0x0401731A RID: 95002
		[Token(Token = "0x4013EEB")]
		private const int RF3_ITEM_LEVELMAX = 9;

		// Token: 0x0401731B RID: 95003
		[Token(Token = "0x4013EEC")]
		private const int RF4_FREE_FARM_MAX = 7;

		// Token: 0x0401731C RID: 95004
		[Token(Token = "0x4013EED")]
		private const int RF4_FREE_FARM_CROP_MAX = 76;

		// Token: 0x0401731D RID: 95005
		[Token(Token = "0x4013EEE")]
		private const int RF4_FF_SAVE_CROP_NUM = 532;

		// Token: 0x0401731E RID: 95006
		[Token(Token = "0x4013EEF")]
		private const int RF4_FF_GROW_SHIFT = 8;

		// Token: 0x0401731F RID: 95007
		[Token(Token = "0x4013EF0")]
		private const int RF4_FF_GROW_MASK = 255;

		// Token: 0x04017320 RID: 95008
		[Token(Token = "0x4013EF1")]
		private const int RF4_CROP_FRUIT_MAX = 7;

		// Token: 0x04017321 RID: 95009
		[Token(Token = "0x4013EF2")]
		private const int RF4_CROP_LV_MIN = 0;

		// Token: 0x04017322 RID: 95010
		[Token(Token = "0x4013EF3")]
		private const int RF4_CROP_LV_MAX = 4095;

		// Token: 0x04017323 RID: 95011
		[Token(Token = "0x4013EF4")]
		private const int RF4_CROP_SIZE_MIN = -256;

		// Token: 0x04017324 RID: 95012
		[Token(Token = "0x4013EF5")]
		private const int RF4_CROP_SIZE_POOR = -256;

		// Token: 0x04017325 RID: 95013
		[Token(Token = "0x4013EF6")]
		private const int RF4_CROP_SIZE_MAX = 511;

		// Token: 0x04017326 RID: 95014
		[Token(Token = "0x4013EF7")]
		private const int RF4_CROP_GROW_MIN = 0;

		// Token: 0x04017327 RID: 95015
		[Token(Token = "0x4013EF8")]
		private const int RF4_CROP_GROW_MAX = 131071;

		// Token: 0x04017328 RID: 95016
		[Token(Token = "0x4013EF9")]
		private const int RF4_CROP_NUM_MIN = -1024;

		// Token: 0x04017329 RID: 95017
		[Token(Token = "0x4013EFA")]
		private const int RF4_CROP_NUM_MAX = 1023;

		// Token: 0x0401732A RID: 95018
		[Token(Token = "0x4013EFB")]
		private const int RF4_CROP_HP_MIN = 0;

		// Token: 0x0401732B RID: 95019
		[Token(Token = "0x4013EFC")]
		private const int RF4_CROP_HP_MAX = 255;

		// Token: 0x0401732C RID: 95020
		[Token(Token = "0x4013EFD")]
		private const int RF4_CROP_LEVELUP_MAX = 3;

		// Token: 0x0401732D RID: 95021
		[Token(Token = "0x4013EFE")]
		private const int RF4_FREE_FARM_SEASON_ON = 6144;

		// Token: 0x0401732E RID: 95022
		[Token(Token = "0x4013EFF")]
		private const int RF4_FREE_FARM_SEASON_OFF = 3072;

		// Token: 0x0401732F RID: 95023
		[Token(Token = "0x4013F00")]
		private const int RF4_FREE_FARM_SEASON_ON_SIZE = 4608;

		// Token: 0x04017330 RID: 95024
		[Token(Token = "0x4013F01")]
		private const int RF4_FREE_FARM_SEASON_OFF_SIZE = 1024;

		// Token: 0x04017331 RID: 95025
		[Token(Token = "0x4013F02")]
		private const int RF4_FREE_FARM_HALF_HP_DIE = 128;

		// Token: 0x04017332 RID: 95026
		[Token(Token = "0x4013F03")]
		private const int RF4_FREE_FARM_QUARTER_HP_DIE = 32;

		// Token: 0x04017333 RID: 95027
		[Token(Token = "0x4013F04")]
		private const int RF4_FREE_FARM_QUARTER_RESS_HP_DIE = 8;

		// Token: 0x04017334 RID: 95028
		[Token(Token = "0x4013F05")]
		private const int RF4_FREE_FARM_ZERO_HP_DIE = 1;

		// Token: 0x04017335 RID: 95029
		[Token(Token = "0x4013F06")]
		private const byte RF4_FREE_FARM_HP_CARE = 8;

		// Token: 0x04017336 RID: 95030
		[Token(Token = "0x4013F07")]
		private const byte RF4_FREE_FARM_HP_CARE_BOOST = 8;

		// Token: 0x04017337 RID: 95031
		[Token(Token = "0x4013F08")]
		private const byte RF4_FREE_FARM_HP_CARE_BOOST2 = 1;

		// Token: 0x04017338 RID: 95032
		[Token(Token = "0x4013F09")]
		private const byte RF4_FREE_FARM_RP_CARE = 2;

		// Token: 0x04017339 RID: 95033
		[Token(Token = "0x4013F0A")]
		private const byte RF4_FREE_FARM_RP_CARE_BOOST = 2;

		// Token: 0x0401733A RID: 95034
		[Token(Token = "0x4013F0B")]
		private const int RF4_FREE_FARM_GROW_SPD_RETURN = 32;

		// Token: 0x0401733B RID: 95035
		[Token(Token = "0x4013F0C")]
		private const int RF4_FREE_FARM_GROW_SPD_DOWN = 10;

		// Token: 0x0401733C RID: 95036
		[Token(Token = "0x4013F0D")]
		private const int RF4_FREE_FARM_GROW_LV_RETURN = 16;

		// Token: 0x0401733D RID: 95037
		[Token(Token = "0x4013F0E")]
		private const int RF4_FREE_FARM_GROW_LV_DOWN = 8;

		// Token: 0x0401733E RID: 95038
		[Token(Token = "0x4013F0F")]
		private const int RF4_FREE_FARM_GROW_SIZE_RETURN = 8;

		// Token: 0x0401733F RID: 95039
		[Token(Token = "0x4013F10")]
		private const int RF4_FREE_FARM_GROW_SIZE_DOWN = 8;

		// Token: 0x04017340 RID: 95040
		[Token(Token = "0x4013F11")]
		private const int RF4_FREE_FARM_GROW_NUM_RETURN = 8;

		// Token: 0x04017341 RID: 95041
		[Token(Token = "0x4013F12")]
		private const int RF4_FREE_FARM_GROW_NUM_DOWN = 4;

		// Token: 0x04017342 RID: 95042
		[Token(Token = "0x4013F13")]
		private const int RF4_FREE_FARM_DAMAGE_RETURN = 1;

		// Token: 0x04017343 RID: 95043
		[Token(Token = "0x4013F14")]
		private const int RF4_FREE_FARM_DEF_RETURN = 3;

		// Token: 0x04017344 RID: 95044
		[Token(Token = "0x4013F15")]
		private const int RF4_FREE_FARM_DEF_USE = 8;

		// Token: 0x04017345 RID: 95045
		[Token(Token = "0x4013F16")]
		public const int RF4_FREE_FARM_RP_USE = 6;

		// Token: 0x04017346 RID: 95046
		[Token(Token = "0x4013F17")]
		private const int RF4_FREE_FARM_GROW_SPD_DAMAGE = 16;

		// Token: 0x04017347 RID: 95047
		[Token(Token = "0x4013F18")]
		private const int RF4_FREE_FARM_GROW_LV_DAMAGE = 8;

		// Token: 0x04017348 RID: 95048
		[Token(Token = "0x4013F19")]
		private const int RF4_FREE_FARM_GROW_SIZE_DAMAGE = 8;

		// Token: 0x04017349 RID: 95049
		[Token(Token = "0x4013F1A")]
		private const int RF4_FREE_FARM_GROW_NUM_DAMAGE = 8;

		// Token: 0x0401734A RID: 95050
		[Token(Token = "0x4013F1B")]
		private const int RFD_FF_YOUNG_CORN_CURE_HP = 150;

		// Token: 0x0401734B RID: 95051
		[Token(Token = "0x4013F1C")]
		private const int RFD_FF_GRASS_D_CURE_HP = 30;

		// Token: 0x0401734C RID: 95052
		[Token(Token = "0x4013F1D")]
		private const int RFD_FF_YOUNG_CORN_CURE_RP = 5;

		// Token: 0x0401734D RID: 95053
		[Token(Token = "0x4013F1E")]
		private const int RFD_FF_GRASS_D_CURE_RP = 1;

		// Token: 0x0401734E RID: 95054
		[Token(Token = "0x4013F1F")]
		private const int RFD_FF_YOUNG_CORN_CURE_GROW = 64;

		// Token: 0x0401734F RID: 95055
		[Token(Token = "0x4013F20")]
		private const int RFD_FF_GRASS_D_CURE_GROW = 16;

		// Token: 0x04017350 RID: 95056
		[Token(Token = "0x4013F21")]
		private const int RFD_SDRUG_D_ITEM_TYUUWA = 32;

		// Token: 0x04017351 RID: 95057
		[Token(Token = "0x4013F22")]
		private const int RFD_SDRUG_D_ITEM_GNGNGREEN = 16;

		// Token: 0x04017352 RID: 95058
		[Token(Token = "0x4013F23")]
		private const int RFD_SDRUG_D_ITEM_GNGNGREEN_HAYATE = 128;

		// Token: 0x04017353 RID: 95059
		[Token(Token = "0x4013F24")]
		private const int RFD_SDRUG_D_ITEM_YOKU_NOBIRU = 128;

		// Token: 0x04017354 RID: 95060
		[Token(Token = "0x4013F25")]
		private const int RFD_SDRUG_D_ITEM_SUBAYAKU_NOBIRU = 256;

		// Token: 0x04017355 RID: 95061
		[Token(Token = "0x4013F26")]
		private const int RFD_SDRUG_D_ITEM_HAGESHIKU_NOBIRU = 512;

		// Token: 0x04017356 RID: 95062
		[Token(Token = "0x4013F27")]
		private const int RFD_SDRUG_D_ITEM_OOKIKUNARE = 80;

		// Token: 0x04017357 RID: 95063
		[Token(Token = "0x4013F28")]
		private const int RFD_SDRUG_D_ITEM_TIISAKUNARE = -256;

		// Token: 0x04017358 RID: 95064
		[Token(Token = "0x4013F29")]
		private const int RFD_SDRUG_D_ITEM_TIISAKUNARE_HP = 60;

		// Token: 0x04017359 RID: 95065
		[Token(Token = "0x4013F2A")]
		private const int RFD_SDRUG_D_ITEM_KUSARASENAINO_A = -4;

		// Token: 0x0401735A RID: 95066
		[Token(Token = "0x4013F2B")]
		private const int RFD_SDRUG_D_ITEM_KUSARASENAINO_B = -15;

		// Token: 0x0401735B RID: 95067
		[Token(Token = "0x4013F2C")]
		private const int RFD_SDRUG_DAMAGE_HP = 12;

		// Token: 0x0401735C RID: 95068
		[Token(Token = "0x4013F2D")]
		private const int RF4_CROP_ORE = 26;

		// Token: 0x0401735D RID: 95069
		[Token(Token = "0x4013F2E")]
		private const int RF4_CROP_ORE_BIG_FX32 = 4608;

		// Token: 0x0401735E RID: 95070
		[Token(Token = "0x4013F2F")]
		private const int RF4_CROP_ORE_MINI_FX32 = 3072;

		// Token: 0x0401735F RID: 95071
		[Token(Token = "0x4013F30")]
		private const int RF4_FREE_FARM_RAND_TBL_MAX = 32;

		// Token: 0x04017360 RID: 95072
		[Token(Token = "0x4013F31")]
		private const int RF4_FREE_FARM_ORE_RAND_TBL_MAX = 16;

		// Token: 0x04017361 RID: 95073
		[Token(Token = "0x4013F32")]
		private const int RF4_FREE_FARM_ROCK_RAND_TBL_MAX = 3;

		// Token: 0x04017362 RID: 95074
		[Token(Token = "0x4013F33")]
		private const int RF4_FREE_FARM_WOOD_RAND_TBL_MAX = 3;

		// Token: 0x04017363 RID: 95075
		[Token(Token = "0x4013F34")]
		private const int RF4_FREE_FARM_FLOWER_RAND_TBL_MAX = 64;

		// Token: 0x04017364 RID: 95076
		[Token(Token = "0x4013F35")]
		private const int RF4_FREE_FARM_VEGETABLE_RAND_TBL_MAX = 64;

		// Token: 0x04017365 RID: 95077
		[Token(Token = "0x4013F36")]
		private const int RF4_FREE_FARM_ALL_CROP_MAX = 532;

		// Token: 0x04017366 RID: 95078
		[Token(Token = "0x4013F37")]
		private const int RF4_FREE_FARM_ARERU_NUM = 15;

		// Token: 0x04017367 RID: 95079
		[Token(Token = "0x4013F38")]
		private const int RF4_CROP_TYPE_GRASS = 8;

		// Token: 0x04017368 RID: 95080
		[Token(Token = "0x4013F39")]
		public const int RF4_CROP_TYPE_TREE = 512;

		// Token: 0x04017369 RID: 95081
		[Token(Token = "0x4013F3A")]
		private const int RF4_SOIL_GROW_SPD_MIN = 128;

		// Token: 0x0401736A RID: 95082
		[Token(Token = "0x4013F3B")]
		private const int RF4_SOIL_GROW_SPD_MAX = 1280;

		// Token: 0x0401736B RID: 95083
		[Token(Token = "0x4013F3C")]
		private const int RF4_SOIL_GROW_NUM_MAX = 512;

		// Token: 0x0401736C RID: 95084
		[Token(Token = "0x4013F3D")]
		private const int RF4_SOIL_GROW_LV_MIN = -512;

		// Token: 0x0401736D RID: 95085
		[Token(Token = "0x4013F3E")]
		private const int RF4_SOIL_GROW_LV_MAX = 511;

		// Token: 0x0401736E RID: 95086
		[Token(Token = "0x4013F3F")]
		private const int RF4_SOIL_GROW_SIZE_MIN = -512;

		// Token: 0x0401736F RID: 95087
		[Token(Token = "0x4013F40")]
		private const int RF4_SOIL_GROW_SIZE_MAX = 511;

		// Token: 0x04017370 RID: 95088
		[Token(Token = "0x4013F41")]
		private const int RF4_SOIL_DOPING_MIN = 0;

		// Token: 0x04017371 RID: 95089
		[Token(Token = "0x4013F42")]
		private const int RF4_SOIL_DOPING_MAX = 3;

		// Token: 0x04017372 RID: 95090
		[Token(Token = "0x4013F43")]
		private const int RF4_SOIL_DEF_MIN = 0;

		// Token: 0x04017373 RID: 95091
		[Token(Token = "0x4013F44")]
		private const int RF4_SOIL_DEF_MAX = 63;

		// Token: 0x04017374 RID: 95092
		[Token(Token = "0x4013F45")]
		private const int RF4_SOIL_HP_MIN = 0;

		// Token: 0x04017375 RID: 95093
		[Token(Token = "0x4013F46")]
		private const int RF4_SOIL_HP_MAX = 255;

		// Token: 0x04017376 RID: 95094
		[Token(Token = "0x4013F47")]
		private const int RF4_SOIL_RP_MIN = 0;

		// Token: 0x04017377 RID: 95095
		[Token(Token = "0x4013F48")]
		private const int RF4_SOIL_RP_MAX = 15;

		// Token: 0x04017378 RID: 95096
		[Token(Token = "0x4013F49")]
		private const int RF4_SOIL_ATK_MIN = 0;

		// Token: 0x04017379 RID: 95097
		[Token(Token = "0x4013F4A")]
		private const int RF4_SOIL_ATK_MAX = 31;

		// Token: 0x0401737A RID: 95098
		[Token(Token = "0x4013F4B")]
		private const int RF4_SOIL_LV_MAX = 15;

		// Token: 0x0401737B RID: 95099
		[Token(Token = "0x4013F4C")]
		private const int RF4_SOIL_EXP_MAX = 255;

		// Token: 0x0401737C RID: 95100
		[Token(Token = "0x4013F4D")]
		private const int RF3_CROP_VEGETABLE_START_ID = 38;

		// Token: 0x0401737D RID: 95101
		[Token(Token = "0x4013F4E")]
		private const int RF3_CROP_CULTIVATE = 88;

		// Token: 0x0401737E RID: 95102
		[Token(Token = "0x4013F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static uint fix_seed;

		// Token: 0x0401737F RID: 95103
		[Token(Token = "0x4013F50")]
		private const int farmGoodCropAddRangeMin = 0;

		// Token: 0x04017380 RID: 95104
		[Token(Token = "0x4013F51")]
		private const int farmGoodCropAddRangeMax = 3;

		// Token: 0x04017381 RID: 95105
		[Token(Token = "0x4013F52")]
		private const int farmBadCropSubRangeMin = 0;

		// Token: 0x04017382 RID: 95106
		[Token(Token = "0x4013F53")]
		private const int farmBadCropSubRangeMax = 3;

		// Token: 0x04017383 RID: 95107
		[Token(Token = "0x4013F54")]
		private const int farmDamageReductionHoeLevel = 3;

		// Token: 0x04017384 RID: 95108
		[Token(Token = "0x4013F55")]
		private const int farmRainWateringWait = 1;

		// Token: 0x04017385 RID: 95109
		[Token(Token = "0x4013F56")]
		private const int farmTyphoonBuildWait = 2;

		// Token: 0x04017386 RID: 95110
		[Token(Token = "0x4013F57")]
		private const int farmTyphoonBreakWait = 4;

		// Token: 0x04017387 RID: 95111
		[Token(Token = "0x4013F58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static readonly int[] RegistTyphoonBuild;

		// Token: 0x04017388 RID: 95112
		[Token(Token = "0x4013F59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static readonly int[] RegistTyphoonBreake;

		// Token: 0x04017389 RID: 95113
		[Token(Token = "0x4013F5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static readonly int[] UseCrystalCountTable;

		// Token: 0x0401738A RID: 95114
		[Token(Token = "0x4013F5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static readonly int[][] UseGroundCrystalCountTable;

		// Token: 0x0401738B RID: 95115
		[Token(Token = "0x4013F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static readonly int[] AvailableDaysCountTable;

		// Token: 0x0401738C RID: 95116
		[Token(Token = "0x4013F5D")]
		private const int boostRuneRate = 128;

		// Token: 0x0401738D RID: 95117
		[Token(Token = "0x4013F5E")]
		private const int branchBuildRate = 0;

		// Token: 0x0401738E RID: 95118
		[Token(Token = "0x4013F5F")]
		private const int StumpBuildRate = 1;

		// Token: 0x0401738F RID: 95119
		[Token(Token = "0x4013F60")]
		private const int bigStumpBuildRate = 2;

		// Token: 0x04017390 RID: 95120
		[Token(Token = "0x4013F61")]
		private const int stoneBuildRate = 3;

		// Token: 0x04017391 RID: 95121
		[Token(Token = "0x4013F62")]
		private const int RockBuildRate = 4;

		// Token: 0x04017392 RID: 95122
		[Token(Token = "0x4013F63")]
		private const int bigRockBuildRate = 5;

		// Token: 0x04017393 RID: 95123
		[Token(Token = "0x4013F64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static readonly int[] obstacleRateList;

		// Token: 0x04017394 RID: 95124
		[Token(Token = "0x4013F65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Vector3[] farmOffset;

		// Token: 0x04017395 RID: 95125
		[Token(Token = "0x4013F66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static readonly int[] rf_free_farm_spd;

		// Token: 0x04017396 RID: 95126
		[Token(Token = "0x4013F67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static readonly int[] rf_free_farm_num;

		// Token: 0x04017397 RID: 95127
		[Token(Token = "0x4013F68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static readonly int[] rf_free_farm_num_rate;

		// Token: 0x04017398 RID: 95128
		[Token(Token = "0x4013F69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static readonly int[] rf_free_farm_lv;

		// Token: 0x04017399 RID: 95129
		[Token(Token = "0x4013F6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static readonly int[] rf_free_farm_lv_rate;

		// Token: 0x0401739A RID: 95130
		[Token(Token = "0x4013F6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static readonly int[] rf_free_farm_size;

		// Token: 0x0401739B RID: 95131
		[Token(Token = "0x4013F6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static readonly int[] rf_free_farm_hp;

		// Token: 0x0401739C RID: 95132
		[Token(Token = "0x4013F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static readonly int[] rf_free_farm_rp;

		// Token: 0x0401739D RID: 95133
		[Token(Token = "0x4013F6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static readonly int[] rf_free_farm_atk;

		// Token: 0x0401739E RID: 95134
		[Token(Token = "0x4013F6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static readonly int[] rf_free_farm_def;

		// Token: 0x0401739F RID: 95135
		[Token(Token = "0x4013F70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static readonly int[] rf_free_farm_seed_rate;

		// Token: 0x040173A0 RID: 95136
		[Token(Token = "0x4013F71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static readonly int[] rf_free_farm_seed_under_rate;

		// Token: 0x040173A1 RID: 95137
		[Token(Token = "0x4013F72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static readonly int[] rf_free_farm_soil_exp;

		// Token: 0x040173A2 RID: 95138
		[Token(Token = "0x4013F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static readonly BitVector32Int.Section csi0_fruit;

		// Token: 0x040173A3 RID: 95139
		[Token(Token = "0x4013F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly BitVector32Int.Section csi0_crop_lv;

		// Token: 0x040173A4 RID: 95140
		[Token(Token = "0x4013F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static readonly BitVector32Int.Section csi0_crop_size;

		// Token: 0x040173A5 RID: 95141
		[Token(Token = "0x4013F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static readonly BitVector32Int.Section csi1_crop_grow;

		// Token: 0x040173A6 RID: 95142
		[Token(Token = "0x4013F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static readonly BitVector32Int.Section csi1_crop_num;

		// Token: 0x040173A7 RID: 95143
		[Token(Token = "0x4013F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static readonly BitVector32Int.Section csi1_water;

		// Token: 0x040173A8 RID: 95144
		[Token(Token = "0x4013F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static readonly BitVector32Int.Section csi1_crop_die;

		// Token: 0x040173A9 RID: 95145
		[Token(Token = "0x4013F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static readonly BitVector32Int.Section csi1_large;

		// Token: 0x040173AA RID: 95146
		[Token(Token = "0x4013F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static readonly BitVector32Int.Section csi2_crop_hp;

		// Token: 0x040173AB RID: 95147
		[Token(Token = "0x4013F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static readonly BitVector32Int.Section csi2_x;

		// Token: 0x040173AC RID: 95148
		[Token(Token = "0x4013F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public static readonly BitVector32Int.Section csi2_y;

		// Token: 0x040173AD RID: 95149
		[Token(Token = "0x4013F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static readonly BitVector32Int.Section csi2_levelup;

		// Token: 0x040173AE RID: 95150
		[Token(Token = "0x4013F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public static readonly BitVector32Int.Section csi2_kuwa;

		// Token: 0x040173AF RID: 95151
		[Token(Token = "0x4013F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static readonly BitVector32Int.Section csi3_crop_id;

		// Token: 0x040173B0 RID: 95152
		[Token(Token = "0x4013F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public static readonly BitVector32Int.Section si0_grow_spd;

		// Token: 0x040173B1 RID: 95153
		[Token(Token = "0x4013F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static readonly BitVector32Int.Section si0_grow_num;

		// Token: 0x040173B2 RID: 95154
		[Token(Token = "0x4013F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public static readonly BitVector32Int.Section si0_grow_lv;

		// Token: 0x040173B3 RID: 95155
		[Token(Token = "0x4013F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static readonly BitVector32Int.Section si1_grow_size;

		// Token: 0x040173B4 RID: 95156
		[Token(Token = "0x4013F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public static readonly BitVector32Int.Section si1_def;

		// Token: 0x040173B5 RID: 95157
		[Token(Token = "0x4013F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public static readonly BitVector32Int.Section si1_hp;

		// Token: 0x040173B6 RID: 95158
		[Token(Token = "0x4013F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public static readonly BitVector32Int.Section si1_atk;

		// Token: 0x040173B7 RID: 95159
		[Token(Token = "0x4013F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public static readonly BitVector32Int.Section si1_doping;

		// Token: 0x040173B8 RID: 95160
		[Token(Token = "0x4013F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static readonly BitVector32Int.Section si1_work_on_crop;

		// Token: 0x040173B9 RID: 95161
		[Token(Token = "0x4013F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public static readonly BitVector32Int.Section si2_rp;

		// Token: 0x040173BA RID: 95162
		[Token(Token = "0x4013F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public static readonly BitVector32Int.Section si2_soil_num_lv;

		// Token: 0x040173BB RID: 95163
		[Token(Token = "0x4013F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public static readonly BitVector32Int.Section si2_soil_lv_lv;

		// Token: 0x040173BC RID: 95164
		[Token(Token = "0x4013F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public static readonly BitVector32Int.Section si2_soil_size_lv;

		// Token: 0x040173BD RID: 95165
		[Token(Token = "0x4013F8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public static readonly BitVector32Int.Section si2_soil_exp;

		// Token: 0x040173BE RID: 95166
		[Token(Token = "0x4013F8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public static readonly BitVector32Int.Section si2_soil_spd_exp;

		// Token: 0x040173BF RID: 95167
		[Token(Token = "0x4013F90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public static readonly BitVector32Int.Section si3_soil_num_exp;

		// Token: 0x040173C0 RID: 95168
		[Token(Token = "0x4013F91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public static readonly BitVector32Int.Section si3_soil_lv_exp;

		// Token: 0x040173C1 RID: 95169
		[Token(Token = "0x4013F92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public static readonly BitVector32Int.Section si3_soil_size_exp;

		// Token: 0x040173C2 RID: 95170
		[Token(Token = "0x4013F93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public static readonly BitVector32Int.Section si3_soil_lv;

		// Token: 0x040173C3 RID: 95171
		[Token(Token = "0x4013F94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public static readonly BitVector32Int.Section si3_soil_spd_lv;

		// Token: 0x040173C4 RID: 95172
		[Token(Token = "0x4013F95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] monsterHutReleaseFlags;

		// Token: 0x040173C5 RID: 95173
		[Token(Token = "0x4013F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public static Dictionary<FieldSceneId, KeyValuePair<FarmManager.FARM_ID, int>> SceneIDToFarmIDAndPlaceIDDic;

		// Token: 0x040173C6 RID: 95174
		[Token(Token = "0x4013F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static readonly int[] _rf__level_rate_0;

		// Token: 0x040173C7 RID: 95175
		[Token(Token = "0x4013F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static readonly int[] _rf__level_rate_1;

		// Token: 0x040173C8 RID: 95176
		[Token(Token = "0x4013F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static readonly int[] _rf__level_rate_2;

		// Token: 0x040173C9 RID: 95177
		[Token(Token = "0x4013F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static readonly int[] _rf__level_rate_0a;

		// Token: 0x040173CA RID: 95178
		[Token(Token = "0x4013F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static readonly int[] _rf__level_rate_1a;

		// Token: 0x040173CB RID: 95179
		[Token(Token = "0x4013F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static readonly int[] _rf__level_rate_2a;

		// Token: 0x040173CC RID: 95180
		[Token(Token = "0x4013F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static readonly int[] _rf__level_rate_0b;

		// Token: 0x040173CD RID: 95181
		[Token(Token = "0x4013F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static readonly int[] _rf__level_rate_1b;

		// Token: 0x040173CE RID: 95182
		[Token(Token = "0x4013F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static readonly int[] _rf__level_rate_2b;

		// Token: 0x02001093 RID: 4243
		[Token(Token = "0x2001546")]
		public enum RF4_CROP_GROW_STATE
		{
			// Token: 0x040173D0 RID: 95184
			[Token(Token = "0x401C03C")]
			RF4_CROP_GROW_NULL,
			// Token: 0x040173D1 RID: 95185
			[Token(Token = "0x401C03D")]
			RF4_CROP_GROW_SEED,
			// Token: 0x040173D2 RID: 95186
			[Token(Token = "0x401C03E")]
			RF4_CROP_GROW_SPROUT,
			// Token: 0x040173D3 RID: 95187
			[Token(Token = "0x401C03F")]
			RF4_CROP_GROW_LEAF1,
			// Token: 0x040173D4 RID: 95188
			[Token(Token = "0x401C040")]
			RF4_CROP_GROW_LEAF2,
			// Token: 0x040173D5 RID: 95189
			[Token(Token = "0x401C041")]
			RF4_CROP_GROW_FRUIT,
			// Token: 0x040173D6 RID: 95190
			[Token(Token = "0x401C042")]
			RF4_CROP_GROW_DEAD,
			// Token: 0x040173D7 RID: 95191
			[Token(Token = "0x401C043")]
			RF4_CROP_GROW_STATE_MAX
		}

		// Token: 0x02001094 RID: 4244
		[Token(Token = "0x2001547")]
		public enum FARM_ID
		{
			// Token: 0x040173D9 RID: 95193
			[Token(Token = "0x401C045")]
			RF4_FREEFARM_ID_Village,
			// Token: 0x040173DA RID: 95194
			[Token(Token = "0x401C046")]
			RF4_FREEFARM_ID_Soil,
			// Token: 0x040173DB RID: 95195
			[Token(Token = "0x401C047")]
			RF4_FREEFARM_ID_Fire,
			// Token: 0x040173DC RID: 95196
			[Token(Token = "0x401C048")]
			RF4_FREEFARM_ID_Ice,
			// Token: 0x040173DD RID: 95197
			[Token(Token = "0x401C049")]
			RF4_FREEFARM_ID_Wind,
			// Token: 0x040173DE RID: 95198
			[Token(Token = "0x401C04A")]
			RF4_FREEFARM_ID_Ground,
			// Token: 0x040173DF RID: 95199
			[Token(Token = "0x401C04B")]
			RF4_FREEFARM_ID_Vision,
			// Token: 0x040173E0 RID: 95200
			[Token(Token = "0x401C04C")]
			RF4_FREEFARM_ID_MAX
		}

		// Token: 0x02001095 RID: 4245
		[Token(Token = "0x2001548")]
		[Flags]
		public enum FARM_MONSTER_TASK
		{
			// Token: 0x040173E2 RID: 95202
			[Token(Token = "0x401C04E")]
			NONE = 0,
			// Token: 0x040173E3 RID: 95203
			[Token(Token = "0x401C04F")]
			CULTIVATE = 1,
			// Token: 0x040173E4 RID: 95204
			[Token(Token = "0x401C050")]
			WATER = 2,
			// Token: 0x040173E5 RID: 95205
			[Token(Token = "0x401C051")]
			SEEDING = 4,
			// Token: 0x040173E6 RID: 95206
			[Token(Token = "0x401C052")]
			HARVEST = 8
		}

		// Token: 0x02001096 RID: 4246
		[Token(Token = "0x2001549")]
		private struct RF3_FREEFARM
		{
			// Token: 0x06006BC1 RID: 27585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CCA")]
			[Address(RVA = "0x2E1720", Offset = "0x2E1821", VA = "0x2E1720")]
			public RF3_FREEFARM(int id)
			{
			}

			// Token: 0x040173E7 RID: 95207
			[Token(Token = "0x401C053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int farm_id;

			// Token: 0x040173E8 RID: 95208
			[Token(Token = "0x401C054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool flag_disp;

			// Token: 0x040173E9 RID: 95209
			[Token(Token = "0x401C055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FarmManager.RF4_CROP_PARAM[] pCropParam;

			// Token: 0x040173EA RID: 95210
			[Token(Token = "0x401C056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FarmManager.RF4_CROP_STATE[][] crop;

			// Token: 0x040173EB RID: 95211
			[Token(Token = "0x401C057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FarmManager.RF4_SOIL_INFO[][] soil;

			// Token: 0x040173EC RID: 95212
			[Token(Token = "0x401C058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int[] damege_rand_tbl;

			// Token: 0x040173ED RID: 95213
			[Token(Token = "0x401C059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int[] damege_crop_rand_tbl;

			// Token: 0x040173EE RID: 95214
			[Token(Token = "0x401C05A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] rock_rand_tbl;

			// Token: 0x040173EF RID: 95215
			[Token(Token = "0x401C05B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int[] wood_rand_tbl;

			// Token: 0x040173F0 RID: 95216
			[Token(Token = "0x401C05C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string str;
		}

		// Token: 0x02001097 RID: 4247
		[Token(Token = "0x200154A")]
		[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x159E20", Offset = "0x159F21")]
		public struct RF4_MCROP_INFO
		{
			// Token: 0x040173F1 RID: 95217
			[Token(Token = "0x401C05D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199340", Offset = "0x199441")]
			public int enable;

			// Token: 0x040173F2 RID: 95218
			[Token(Token = "0x401C05E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199360", Offset = "0x199461")]
			public int mcrop_map_id;

			// Token: 0x040173F3 RID: 95219
			[Token(Token = "0x401C05F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199380", Offset = "0x199481")]
			public int mcrop_hp;
		}

		// Token: 0x02001098 RID: 4248
		[Token(Token = "0x200154B")]
		[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x159E40", Offset = "0x159F41")]
		public struct RF4_CROP_STATE_INFO
		{
			// Token: 0x040173F4 RID: 95220
			[Token(Token = "0x401C060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1993A0", Offset = "0x1994A1")]
			public BitVector32Int csi0;

			// Token: 0x040173F5 RID: 95221
			[Token(Token = "0x401C061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1993C0", Offset = "0x1994C1")]
			public BitVector32Int csi1;

			// Token: 0x040173F6 RID: 95222
			[Token(Token = "0x401C062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1993E0", Offset = "0x1994E1")]
			public BitVector32Int csi2;

			// Token: 0x040173F7 RID: 95223
			[Token(Token = "0x401C063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199400", Offset = "0x199501")]
			public BitVector32Int csi3;

			// Token: 0x040173F8 RID: 95224
			[Token(Token = "0x401C064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199420", Offset = "0x199521")]
			public int cell_id;
		}

		// Token: 0x02001099 RID: 4249
		[Token(Token = "0x200154C")]
		[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x159E60", Offset = "0x159F61")]
		public struct RF4_SOIL_INFO
		{
			// Token: 0x040173F9 RID: 95225
			[Token(Token = "0x401C065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199440", Offset = "0x199541")]
			public BitVector32Int SI0;

			// Token: 0x040173FA RID: 95226
			[Token(Token = "0x401C066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199460", Offset = "0x199561")]
			public BitVector32Int SI1;

			// Token: 0x040173FB RID: 95227
			[Token(Token = "0x401C067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199480", Offset = "0x199581")]
			public BitVector32Int SI2;

			// Token: 0x040173FC RID: 95228
			[Token(Token = "0x401C068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1994A0", Offset = "0x1995A1")]
			public BitVector32Int SI3;
		}

		// Token: 0x0200109A RID: 4250
		[Token(Token = "0x200154D")]
		[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x159E80", Offset = "0x159F81")]
		public struct RF4_CROP_STATE
		{
			// Token: 0x040173FD RID: 95229
			[Token(Token = "0x401C069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1994C0", Offset = "0x1995C1")]
			public FarmManager.RF4_CROP_STATE_INFO info;

			// Token: 0x040173FE RID: 95230
			[Token(Token = "0x401C06A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1994E0", Offset = "0x1995E1")]
			public FarmManager.RF4_MCROP_INFO pMcrop;

			// Token: 0x040173FF RID: 95231
			[Token(Token = "0x401C06B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199500", Offset = "0x199601")]
			public int pSoil;

			// Token: 0x04017400 RID: 95232
			[Token(Token = "0x401C06C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199520", Offset = "0x199621")]
			public int flag;

			// Token: 0x04017401 RID: 95233
			[Token(Token = "0x401C06D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199540", Offset = "0x199641")]
			public byte size;

			// Token: 0x04017402 RID: 95234
			[Token(Token = "0x401C06E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199560", Offset = "0x199661")]
			public FarmManager.RF4_CROP_GROW_STATE crop_grow_state;

			// Token: 0x04017403 RID: 95235
			[Token(Token = "0x401C06F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Attribute(Name = "KeyAttribute", RVA = "0x199580", Offset = "0x199681")]
			public byte die_flag;

			// Token: 0x04017404 RID: 95236
			[Token(Token = "0x401C070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1995A0", Offset = "0x1996A1")]
			public bool disp_cul;

			// Token: 0x04017405 RID: 95237
			[Token(Token = "0x401C071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1995C0", Offset = "0x1996C1")]
			public bool disp_cul_w;

			// Token: 0x04017406 RID: 95238
			[Token(Token = "0x401C072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			[Attribute(Name = "KeyAttribute", RVA = "0x1995E0", Offset = "0x1996E1")]
			public byte farm_id;
		}

		// Token: 0x0200109B RID: 4251
		[Token(Token = "0x200154E")]
		private struct RF4_CROP_PARAM
		{
			// Token: 0x04017407 RID: 95239
			[Token(Token = "0x401C073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int mItemID;

			// Token: 0x04017408 RID: 95240
			[Token(Token = "0x401C074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public byte mDay_SeedToSprout;

			// Token: 0x04017409 RID: 95241
			[Token(Token = "0x401C075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public byte mDay_SproutToLeaf1;

			// Token: 0x0401740A RID: 95242
			[Token(Token = "0x401C076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public byte mDay_Leaf1ToLeaf2;

			// Token: 0x0401740B RID: 95243
			[Token(Token = "0x401C077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public byte mDay_Leaf2ToFruits;

			// Token: 0x0401740C RID: 95244
			[Token(Token = "0x401C078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte mRepeat;

			// Token: 0x0401740D RID: 95245
			[Token(Token = "0x401C079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte mDefNum;

			// Token: 0x0401740E RID: 95246
			[Token(Token = "0x401C07A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int mHp;

			// Token: 0x0401740F RID: 95247
			[Token(Token = "0x401C07B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int mRune;

			// Token: 0x04017410 RID: 95248
			[Token(Token = "0x401C07C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int mAppRate;

			// Token: 0x04017411 RID: 95249
			[Token(Token = "0x401C07D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool mGrowTypePositiveSpring;

			// Token: 0x04017412 RID: 95250
			[Token(Token = "0x401C07E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool mGrowTypePositiveSummer;

			// Token: 0x04017413 RID: 95251
			[Token(Token = "0x401C07F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public bool mGrowTypePositiveAutumn;

			// Token: 0x04017414 RID: 95252
			[Token(Token = "0x401C080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
			public bool mGrowTypePositiveWinter;

			// Token: 0x04017415 RID: 95253
			[Token(Token = "0x401C081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool mGrowTypeNegativeSpring;

			// Token: 0x04017416 RID: 95254
			[Token(Token = "0x401C082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool mGrowTypeNegativeSummer;

			// Token: 0x04017417 RID: 95255
			[Token(Token = "0x401C083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public bool mGrowTypeNegativeAutumn;

			// Token: 0x04017418 RID: 95256
			[Token(Token = "0x401C084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
			public bool mGrowTypeNegativeWinter;

			// Token: 0x04017419 RID: 95257
			[Token(Token = "0x401C085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int mDefense;

			// Token: 0x0401741A RID: 95258
			[Token(Token = "0x401C086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int mExp;

			// Token: 0x0401741B RID: 95259
			[Token(Token = "0x401C087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int mExpSpd;

			// Token: 0x0401741C RID: 95260
			[Token(Token = "0x401C088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int mExpLevel;

			// Token: 0x0401741D RID: 95261
			[Token(Token = "0x401C089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int mExpSize;

			// Token: 0x0401741E RID: 95262
			[Token(Token = "0x401C08A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int mExpNum;

			// Token: 0x0401741F RID: 95263
			[Token(Token = "0x401C08B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int mDamageSpd;

			// Token: 0x04017420 RID: 95264
			[Token(Token = "0x401C08C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int mDamageLevel;

			// Token: 0x04017421 RID: 95265
			[Token(Token = "0x401C08D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int mDamageSize;

			// Token: 0x04017422 RID: 95266
			[Token(Token = "0x401C08E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int mDamageNum;

			// Token: 0x04017423 RID: 95267
			[Token(Token = "0x401C08F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int mDamage;

			// Token: 0x04017424 RID: 95268
			[Token(Token = "0x401C090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public int mRateSpd;

			// Token: 0x04017425 RID: 95269
			[Token(Token = "0x401C091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int mRateLevel;

			// Token: 0x04017426 RID: 95270
			[Token(Token = "0x401C092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public int mRateSize;

			// Token: 0x04017427 RID: 95271
			[Token(Token = "0x401C093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int mRateNum;

			// Token: 0x04017428 RID: 95272
			[Token(Token = "0x401C094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public int mType;
		}

		// Token: 0x0200109C RID: 4252
		[Token(Token = "0x200154F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159EA0", Offset = "0x159FA1")]
		private sealed class <createFurniture>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BC2 RID: 27586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CCB")]
			[Address(RVA = "0x21A1180", Offset = "0x21A1281", VA = "0x21A1180")]
			[DebuggerHidden]
			public <createFurniture>d__23(int <>1__state)
			{
			}

			// Token: 0x06006BC3 RID: 27587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CCC")]
			[Address(RVA = "0x21A11B0", Offset = "0x21A12B1", VA = "0x21A11B0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BC4 RID: 27588 RVA: 0x00024E58 File Offset: 0x00023058
			[Token(Token = "0x6007CCD")]
			[Address(RVA = "0x21A11C0", Offset = "0x21A12C1", VA = "0x21A11C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EA9")]
			private object Current
			{
				[Token(Token = "0x6007CCE")]
				[Address(RVA = "0x21A1410", Offset = "0x21A1511", VA = "0x21A1410", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BC6 RID: 27590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CCF")]
			[Address(RVA = "0x21A1420", Offset = "0x21A1521", VA = "0x21A1420", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAA")]
			private object Current
			{
				[Token(Token = "0x6007CD0")]
				[Address(RVA = "0x21A1480", Offset = "0x21A1581", VA = "0x21A1480", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017429 RID: 95273
			[Token(Token = "0x401C095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401742A RID: 95274
			[Token(Token = "0x401C096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}

		// Token: 0x0200109D RID: 4253
		[Token(Token = "0x2001550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159EB0", Offset = "0x159FB1")]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06006BC8 RID: 27592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD1")]
			[Address(RVA = "0x219FA70", Offset = "0x219FB71", VA = "0x219FA70")]
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x06006BC9 RID: 27593 RVA: 0x00024E70 File Offset: 0x00023070
			[Token(Token = "0x6007CD2")]
			[Address(RVA = "0x219FA80", Offset = "0x219FB81", VA = "0x219FA80")]
			internal bool <GetFarmCropCellData>b__0(FarmCropData cell)
			{
				return default(bool);
			}

			// Token: 0x0401742B RID: 95275
			[Token(Token = "0x401C097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3Int cellSetId;

			// Token: 0x0401742C RID: 95276
			[Token(Token = "0x401C098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int cellId;
		}

		// Token: 0x0200109E RID: 4254
		[Token(Token = "0x2001551")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159EC0", Offset = "0x159FC1")]
		private sealed class <>c__DisplayClass30_0
		{
			// Token: 0x06006BCA RID: 27594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD3")]
			[Address(RVA = "0x219FB20", Offset = "0x219FC21", VA = "0x219FB20")]
			public <>c__DisplayClass30_0()
			{
			}

			// Token: 0x06006BCB RID: 27595 RVA: 0x00024E88 File Offset: 0x00023088
			[Token(Token = "0x6007CD4")]
			[Address(RVA = "0x219FB30", Offset = "0x219FC31", VA = "0x219FB30")]
			internal bool <GetFarmCropCellSetData>b__0(FarmCropData cell)
			{
				return default(bool);
			}

			// Token: 0x0401742D RID: 95277
			[Token(Token = "0x401C099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3Int cellSetId;
		}

		// Token: 0x0200109F RID: 4255
		[Token(Token = "0x2001552")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159ED0", Offset = "0x159FD1")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06006BCC RID: 27596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD5")]
			[Address(RVA = "0x219FBC0", Offset = "0x219FCC1", VA = "0x219FBC0")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06006BCD RID: 27597 RVA: 0x00024EA0 File Offset: 0x000230A0
			[Token(Token = "0x6007CD6")]
			[Address(RVA = "0x219FBD0", Offset = "0x219FCD1", VA = "0x219FBD0")]
			internal bool <SetFarmCropData>b__0(FarmCropData cell)
			{
				return default(bool);
			}

			// Token: 0x0401742E RID: 95278
			[Token(Token = "0x401C09A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3Int cellSetId;

			// Token: 0x0401742F RID: 95279
			[Token(Token = "0x401C09B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int cellId;
		}

		// Token: 0x020010A0 RID: 4256
		[Token(Token = "0x2001553")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159EE0", Offset = "0x159FE1")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x06006BCE RID: 27598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD7")]
			[Address(RVA = "0x219FC70", Offset = "0x219FD71", VA = "0x219FC70")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x06006BCF RID: 27599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD8")]
			[Address(RVA = "0x219FC80", Offset = "0x219FD81", VA = "0x219FC80")]
			internal void <LoadCropPrefab>b__0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x04017430 RID: 95280
			[Token(Token = "0x401C09C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject prefabOrg;
		}

		// Token: 0x020010A1 RID: 4257
		[Token(Token = "0x2001554")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159EF0", Offset = "0x159FF1")]
		private sealed class <LoadCropPrefab>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BD0 RID: 27600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CD9")]
			[Address(RVA = "0x21A0EF0", Offset = "0x21A0FF1", VA = "0x21A0EF0")]
			[DebuggerHidden]
			public <LoadCropPrefab>d__35(int <>1__state)
			{
			}

			// Token: 0x06006BD1 RID: 27601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CDA")]
			[Address(RVA = "0x21A0F20", Offset = "0x21A1021", VA = "0x21A0F20", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BD2 RID: 27602 RVA: 0x00024EB8 File Offset: 0x000230B8
			[Token(Token = "0x6007CDB")]
			[Address(RVA = "0x21A0F30", Offset = "0x21A1031", VA = "0x21A0F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAB")]
			private object Current
			{
				[Token(Token = "0x6007CDC")]
				[Address(RVA = "0x21A1100", Offset = "0x21A1201", VA = "0x21A1100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BD4 RID: 27604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CDD")]
			[Address(RVA = "0x21A1110", Offset = "0x21A1211", VA = "0x21A1110", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAC")]
			private object Current
			{
				[Token(Token = "0x6007CDE")]
				[Address(RVA = "0x21A1170", Offset = "0x21A1271", VA = "0x21A1170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017431 RID: 95281
			[Token(Token = "0x401C09D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017432 RID: 95282
			[Token(Token = "0x401C09E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017433 RID: 95283
			[Token(Token = "0x401C09F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Prefab prefabId;

			// Token: 0x04017434 RID: 95284
			[Token(Token = "0x401C0A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FarmManager.<>c__DisplayClass35_0 <>8__1;

			// Token: 0x04017435 RID: 95285
			[Token(Token = "0x401C0A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UnityAction<GameObject> callback;
		}

		// Token: 0x020010A2 RID: 4258
		[Token(Token = "0x2001555")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F00", Offset = "0x15A001")]
		private sealed class <GetMonsterHutFlags>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BD6 RID: 27606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CDF")]
			[Address(RVA = "0x21A0CC0", Offset = "0x21A0DC1", VA = "0x21A0CC0")]
			[DebuggerHidden]
			public <GetMonsterHutFlags>d__36(int <>1__state)
			{
			}

			// Token: 0x06006BD7 RID: 27607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE0")]
			[Address(RVA = "0x21A0CF0", Offset = "0x21A0DF1", VA = "0x21A0CF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BD8 RID: 27608 RVA: 0x00024ED0 File Offset: 0x000230D0
			[Token(Token = "0x6007CE1")]
			[Address(RVA = "0x21A0D00", Offset = "0x21A0E01", VA = "0x21A0D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAD")]
			private object Current
			{
				[Token(Token = "0x6007CE2")]
				[Address(RVA = "0x21A0E70", Offset = "0x21A0F71", VA = "0x21A0E70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BDA RID: 27610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE3")]
			[Address(RVA = "0x21A0E80", Offset = "0x21A0F81", VA = "0x21A0E80", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x06006BDB RID: 27611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAE")]
			private object Current
			{
				[Token(Token = "0x6007CE4")]
				[Address(RVA = "0x21A0EE0", Offset = "0x21A0FE1", VA = "0x21A0EE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017436 RID: 95286
			[Token(Token = "0x401C0A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017437 RID: 95287
			[Token(Token = "0x401C0A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017438 RID: 95288
			[Token(Token = "0x401C0A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FarmManager <>4__this;

			// Token: 0x04017439 RID: 95289
			[Token(Token = "0x401C0A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FarmManager.FARM_ID farmId;

			// Token: 0x0401743A RID: 95290
			[Token(Token = "0x401C0A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UnityAction<bool[]> callback;

			// Token: 0x0401743B RID: 95291
			[Token(Token = "0x401C0A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool[] <flag>5__2;
		}

		// Token: 0x020010A3 RID: 4259
		[Token(Token = "0x2001556")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F10", Offset = "0x15A011")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006BDD RID: 27613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE6")]
			[Address(RVA = "0x219F810", Offset = "0x219F911", VA = "0x219F810")]
			public <>c()
			{
			}

			// Token: 0x06006BDE RID: 27614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE7")]
			[Address(RVA = "0x219F820", Offset = "0x219F921", VA = "0x219F820")]
			internal void <ForceCreateObstacle>b__43_0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06006BDF RID: 27615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE8")]
			[Address(RVA = "0x219F8B0", Offset = "0x219F9B1", VA = "0x219F8B0")]
			internal void <rf4WeatherWorkFunc>b__51_0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06006BE0 RID: 27616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CE9")]
			[Address(RVA = "0x219F940", Offset = "0x219FA41", VA = "0x219F940")]
			internal void <rf4FreeFarmDamageFarm>b__66_0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06006BE1 RID: 27617 RVA: 0x00024EE8 File Offset: 0x000230E8
			[Token(Token = "0x6007CEA")]
			[Address(RVA = "0x219F9D0", Offset = "0x219FAD1", VA = "0x219F9D0")]
			internal bool <buildObstacle>b__67_0(CropDataTable crop)
			{
				return default(bool);
			}

			// Token: 0x06006BE2 RID: 27618 RVA: 0x00024F00 File Offset: 0x00023100
			[Token(Token = "0x6007CEB")]
			[Address(RVA = "0x219F9E0", Offset = "0x219FAE1", VA = "0x219F9E0")]
			internal int <buildObstacle>b__67_1(CropDataTable crop)
			{
				return 0;
			}

			// Token: 0x06006BE3 RID: 27619 RVA: 0x00024F18 File Offset: 0x00023118
			[Token(Token = "0x6007CEC")]
			[Address(RVA = "0x219F9F0", Offset = "0x219FAF1", VA = "0x219F9F0")]
			internal bool <buildObstacle>b__67_2(CropDataTable crop)
			{
				return default(bool);
			}

			// Token: 0x06006BE4 RID: 27620 RVA: 0x00024F30 File Offset: 0x00023130
			[Token(Token = "0x6007CED")]
			[Address(RVA = "0x219FA00", Offset = "0x219FB01", VA = "0x219FA00")]
			internal int <buildObstacle>b__67_3(CropDataTable crop)
			{
				return 0;
			}

			// Token: 0x06006BE5 RID: 27621 RVA: 0x00024F48 File Offset: 0x00023148
			[Token(Token = "0x6007CEE")]
			[Address(RVA = "0x219FA10", Offset = "0x219FB11", VA = "0x219FA10")]
			internal bool <buildObstacle>b__67_4(CropDataTable crop)
			{
				return default(bool);
			}

			// Token: 0x06006BE6 RID: 27622 RVA: 0x00024F60 File Offset: 0x00023160
			[Token(Token = "0x6007CEF")]
			[Address(RVA = "0x219FA20", Offset = "0x219FB21", VA = "0x219FA20")]
			internal int <buildObstacle>b__67_5(CropDataTable crop)
			{
				return 0;
			}

			// Token: 0x06006BE7 RID: 27623 RVA: 0x00024F78 File Offset: 0x00023178
			[Token(Token = "0x6007CF0")]
			[Address(RVA = "0x219FA30", Offset = "0x219FB31", VA = "0x219FA30")]
			internal bool <GetCropDataTableLotteryList>b__301_0(CropDataTable dat)
			{
				return default(bool);
			}

			// Token: 0x0401743C RID: 95292
			[Token(Token = "0x401C0A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly FarmManager.<>c <>9;

			// Token: 0x0401743D RID: 95293
			[Token(Token = "0x401C0A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnityAction<AssetHandle<GameObject>> <>9__43_0;

			// Token: 0x0401743E RID: 95294
			[Token(Token = "0x401C0AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static UnityAction<AssetHandle<GameObject>> <>9__51_0;

			// Token: 0x0401743F RID: 95295
			[Token(Token = "0x401C0AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static UnityAction<AssetHandle<GameObject>> <>9__66_0;

			// Token: 0x04017440 RID: 95296
			[Token(Token = "0x401C0AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CropDataTable, bool> <>9__67_0;

			// Token: 0x04017441 RID: 95297
			[Token(Token = "0x401C0AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CropDataTable, int> <>9__67_1;

			// Token: 0x04017442 RID: 95298
			[Token(Token = "0x401C0AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<CropDataTable, bool> <>9__67_2;

			// Token: 0x04017443 RID: 95299
			[Token(Token = "0x401C0AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<CropDataTable, int> <>9__67_3;

			// Token: 0x04017444 RID: 95300
			[Token(Token = "0x401C0B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<CropDataTable, bool> <>9__67_4;

			// Token: 0x04017445 RID: 95301
			[Token(Token = "0x401C0B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<CropDataTable, int> <>9__67_5;

			// Token: 0x04017446 RID: 95302
			[Token(Token = "0x401C0B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Predicate<CropDataTable> <>9__301_0;
		}

		// Token: 0x020010A4 RID: 4260
		[Token(Token = "0x2001557")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F20", Offset = "0x15A021")]
		private sealed class <ForceCreateObstacle>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BE8 RID: 27624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CF1")]
			[Address(RVA = "0x21A06A0", Offset = "0x21A07A1", VA = "0x21A06A0")]
			[DebuggerHidden]
			public <ForceCreateObstacle>d__43(int <>1__state)
			{
			}

			// Token: 0x06006BE9 RID: 27625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CF2")]
			[Address(RVA = "0x21A06D0", Offset = "0x21A07D1", VA = "0x21A06D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BEA RID: 27626 RVA: 0x00024F90 File Offset: 0x00023190
			[Token(Token = "0x6007CF3")]
			[Address(RVA = "0x21A06E0", Offset = "0x21A07E1", VA = "0x21A06E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x06006BEB RID: 27627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EAF")]
			private object Current
			{
				[Token(Token = "0x6007CF4")]
				[Address(RVA = "0x21A0C40", Offset = "0x21A0D41", VA = "0x21A0C40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BEC RID: 27628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CF5")]
			[Address(RVA = "0x21A0C50", Offset = "0x21A0D51", VA = "0x21A0C50", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06006BED RID: 27629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB0")]
			private object Current
			{
				[Token(Token = "0x6007CF6")]
				[Address(RVA = "0x21A0CB0", Offset = "0x21A0DB1", VA = "0x21A0CB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017447 RID: 95303
			[Token(Token = "0x401C0B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017448 RID: 95304
			[Token(Token = "0x401C0B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017449 RID: 95305
			[Token(Token = "0x401C0B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int type;
		}

		// Token: 0x020010A5 RID: 4261
		[Token(Token = "0x2001558")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F30", Offset = "0x15A031")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06006BEE RID: 27630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CF7")]
			[Address(RVA = "0x219FD00", Offset = "0x219FE01", VA = "0x219FD00")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06006BEF RID: 27631 RVA: 0x00024FA8 File Offset: 0x000231A8
			[Token(Token = "0x6007CF8")]
			[Address(RVA = "0x219FD10", Offset = "0x219FE11", VA = "0x219FD10")]
			internal bool <ResetObstacleObject>b__0(OnGroundItem item)
			{
				return default(bool);
			}

			// Token: 0x0401744A RID: 95306
			[Token(Token = "0x401C0B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;
		}

		// Token: 0x020010A6 RID: 4262
		[Token(Token = "0x2001559")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F40", Offset = "0x15A041")]
		private sealed class <rf4WeatherWorkFunc>d__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BF0 RID: 27632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CF9")]
			[Address(RVA = "0x21A1E00", Offset = "0x21A1F01", VA = "0x21A1E00")]
			[DebuggerHidden]
			public <rf4WeatherWorkFunc>d__51(int <>1__state)
			{
			}

			// Token: 0x06006BF1 RID: 27633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CFA")]
			[Address(RVA = "0x21A1E30", Offset = "0x21A1F31", VA = "0x21A1E30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BF2 RID: 27634 RVA: 0x00024FC0 File Offset: 0x000231C0
			[Token(Token = "0x6007CFB")]
			[Address(RVA = "0x21A1E40", Offset = "0x21A1F41", VA = "0x21A1E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB1")]
			private object Current
			{
				[Token(Token = "0x6007CFC")]
				[Address(RVA = "0x21A25A0", Offset = "0x21A26A1", VA = "0x21A25A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006BF4 RID: 27636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CFD")]
			[Address(RVA = "0x21A25B0", Offset = "0x21A26B1", VA = "0x21A25B0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB2")]
			private object Current
			{
				[Token(Token = "0x6007CFE")]
				[Address(RVA = "0x21A2610", Offset = "0x21A2711", VA = "0x21A2610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401744B RID: 95307
			[Token(Token = "0x401C0B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401744C RID: 95308
			[Token(Token = "0x401C0B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401744D RID: 95309
			[Token(Token = "0x401C0B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int elapsedSec;

			// Token: 0x0401744E RID: 95310
			[Token(Token = "0x401C0BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int <startTime>5__2;

			// Token: 0x0401744F RID: 95311
			[Token(Token = "0x401C0BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Weather[] <weatherHour>5__3;
		}

		// Token: 0x020010A7 RID: 4263
		[Token(Token = "0x200155A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F50", Offset = "0x15A051")]
		private sealed class <>c__DisplayClass57_0
		{
			// Token: 0x06006BF6 RID: 27638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007CFF")]
			[Address(RVA = "0x219FDF0", Offset = "0x219FEF1", VA = "0x219FDF0")]
			public <>c__DisplayClass57_0()
			{
			}

			// Token: 0x04017450 RID: 95312
			[Token(Token = "0x401C0BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int farm_id;
		}

		// Token: 0x020010A8 RID: 4264
		[Token(Token = "0x200155B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F60", Offset = "0x15A061")]
		private sealed class <>c__DisplayClass57_1
		{
			// Token: 0x06006BF7 RID: 27639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D00")]
			[Address(RVA = "0x219FE00", Offset = "0x219FF01", VA = "0x219FE00")]
			public <>c__DisplayClass57_1()
			{
			}

			// Token: 0x06006BF8 RID: 27640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D01")]
			[Address(RVA = "0x219FE10", Offset = "0x219FF11", VA = "0x219FE10")]
			internal void <rf4FreeFarmCropLargeCheck>b__0(CropDataTable cropData)
			{
			}

			// Token: 0x04017451 RID: 95313
			[Token(Token = "0x401C0BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CellController cellController;

			// Token: 0x04017452 RID: 95314
			[Token(Token = "0x401C0BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FarmManager.<>c__DisplayClass57_0 CS$<>8__locals1;
		}

		// Token: 0x020010A9 RID: 4265
		[Token(Token = "0x200155C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F70", Offset = "0x15A071")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06006BF9 RID: 27641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D02")]
			[Address(RVA = "0x219FFC0", Offset = "0x21A00C1", VA = "0x219FFC0")]
			public <>c__DisplayClass64_0()
			{
			}

			// Token: 0x04017453 RID: 95315
			[Token(Token = "0x401C0BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CellController cellController;

			// Token: 0x04017454 RID: 95316
			[Token(Token = "0x401C0C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 lPosition;
		}

		// Token: 0x020010AA RID: 4266
		[Token(Token = "0x200155D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F80", Offset = "0x15A081")]
		private sealed class <>c__DisplayClass64_1
		{
			// Token: 0x06006BFA RID: 27642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D03")]
			[Address(RVA = "0x219FFD0", Offset = "0x21A00D1", VA = "0x219FFD0")]
			public <>c__DisplayClass64_1()
			{
			}

			// Token: 0x06006BFB RID: 27643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D04")]
			[Address(RVA = "0x219FFE0", Offset = "0x21A00E1", VA = "0x219FFE0")]
			internal void <rf4FreeFarmPickupSoilExec>b__0(GameObject obj)
			{
			}

			// Token: 0x04017455 RID: 95317
			[Token(Token = "0x401C0C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isBoost;

			// Token: 0x04017456 RID: 95318
			[Token(Token = "0x401C0C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FarmManager.<>c__DisplayClass64_0 CS$<>8__locals1;
		}

		// Token: 0x020010AB RID: 4267
		[Token(Token = "0x200155E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159F90", Offset = "0x15A091")]
		private sealed class <rf4FreeFarmDamageFarm>d__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006BFC RID: 27644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D05")]
			[Address(RVA = "0x21A1490", Offset = "0x21A1591", VA = "0x21A1490")]
			[DebuggerHidden]
			public <rf4FreeFarmDamageFarm>d__66(int <>1__state)
			{
			}

			// Token: 0x06006BFD RID: 27645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D06")]
			[Address(RVA = "0x21A14C0", Offset = "0x21A15C1", VA = "0x21A14C0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006BFE RID: 27646 RVA: 0x00024FD8 File Offset: 0x000231D8
			[Token(Token = "0x6007D07")]
			[Address(RVA = "0x21A14D0", Offset = "0x21A15D1", VA = "0x21A14D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06006BFF RID: 27647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB3")]
			private object Current
			{
				[Token(Token = "0x6007D08")]
				[Address(RVA = "0x21A1D80", Offset = "0x21A1E81", VA = "0x21A1D80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006C00 RID: 27648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D09")]
			[Address(RVA = "0x21A1D90", Offset = "0x21A1E91", VA = "0x21A1D90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06006C01 RID: 27649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB4")]
			private object Current
			{
				[Token(Token = "0x6007D0A")]
				[Address(RVA = "0x21A1DF0", Offset = "0x21A1EF1", VA = "0x21A1DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017457 RID: 95319
			[Token(Token = "0x401C0C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017458 RID: 95320
			[Token(Token = "0x401C0C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017459 RID: 95321
			[Token(Token = "0x401C0C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool wood;

			// Token: 0x0401745A RID: 95322
			[Token(Token = "0x401C0C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool stone;

			// Token: 0x0401745B RID: 95323
			[Token(Token = "0x401C0C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public bool typhoon;

			// Token: 0x0401745C RID: 95324
			[Token(Token = "0x401C0C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int num;
		}

		// Token: 0x020010AC RID: 4268
		[Token(Token = "0x200155F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FA0", Offset = "0x15A0A1")]
		private sealed class <>c__DisplayClass79_0
		{
			// Token: 0x06006C02 RID: 27650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0B")]
			[Address(RVA = "0x21A0140", Offset = "0x21A0241", VA = "0x21A0140")]
			public <>c__DisplayClass79_0()
			{
			}

			// Token: 0x0401745D RID: 95325
			[Token(Token = "0x401C0C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FarmManager <>4__this;

			// Token: 0x0401745E RID: 95326
			[Token(Token = "0x401C0CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FarmManager.RF4_CROP_STATE pCrop;
		}

		// Token: 0x020010AD RID: 4269
		[Token(Token = "0x2001560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FB0", Offset = "0x15A0B1")]
		private sealed class <>c__DisplayClass79_1
		{
			// Token: 0x06006C03 RID: 27651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0C")]
			[Address(RVA = "0x21A0150", Offset = "0x21A0251", VA = "0x21A0150")]
			public <>c__DisplayClass79_1()
			{
			}

			// Token: 0x06006C04 RID: 27652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0D")]
			[Address(RVA = "0x21A0160", Offset = "0x21A0261", VA = "0x21A0160")]
			internal void <rf4FreeFarmCropDispChange>b__0(CropDataTable cropData)
			{
			}

			// Token: 0x06006C05 RID: 27653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0E")]
			[Address(RVA = "0x21A0340", Offset = "0x21A0441", VA = "0x21A0340")]
			internal void <rf4FreeFarmCropDispChange>b__1(CropDataTable cropData)
			{
			}

			// Token: 0x0401745F RID: 95327
			[Token(Token = "0x401C0CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CellController cellController;

			// Token: 0x04017460 RID: 95328
			[Token(Token = "0x401C0CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FarmManager.<>c__DisplayClass79_0 CS$<>8__locals1;
		}

		// Token: 0x020010AE RID: 4270
		[Token(Token = "0x2001561")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FC0", Offset = "0x15A0C1")]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x06006C06 RID: 27654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D0F")]
			[Address(RVA = "0x21A04F0", Offset = "0x21A05F1", VA = "0x21A04F0")]
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x06006C07 RID: 27655 RVA: 0x00024FF0 File Offset: 0x000231F0
			[Token(Token = "0x6007D10")]
			[Address(RVA = "0x21A0500", Offset = "0x21A0601", VA = "0x21A0500")]
			internal bool <GetWorkAreaCellControllers>b__0(CellController dat)
			{
				return default(bool);
			}

			// Token: 0x04017461 RID: 95329
			[Token(Token = "0x401C0CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int offset;

			// Token: 0x04017462 RID: 95330
			[Token(Token = "0x401C0CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int separate;
		}

		// Token: 0x020010AF RID: 4271
		[Token(Token = "0x2001562")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FD0", Offset = "0x15A0D1")]
		private sealed class <>c__DisplayClass87_0
		{
			// Token: 0x06006C08 RID: 27656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D11")]
			[Address(RVA = "0x21A05A0", Offset = "0x21A06A1", VA = "0x21A05A0")]
			public <>c__DisplayClass87_0()
			{
			}

			// Token: 0x06006C09 RID: 27657 RVA: 0x00025008 File Offset: 0x00023208
			[Token(Token = "0x6007D12")]
			[Address(RVA = "0x21A05B0", Offset = "0x21A06B1", VA = "0x21A05B0")]
			internal bool <GetWorkAreaCropDatas>b__0(FarmCropData cell)
			{
				return default(bool);
			}

			// Token: 0x04017463 RID: 95331
			[Token(Token = "0x401C0CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int offset;

			// Token: 0x04017464 RID: 95332
			[Token(Token = "0x401C0D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int separate;
		}

		// Token: 0x020010B0 RID: 4272
		[Token(Token = "0x2001563")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159FE0", Offset = "0x15A0E1")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x06006C0A RID: 27658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D13")]
			[Address(RVA = "0x21A0620", Offset = "0x21A0721", VA = "0x21A0620")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x06006C0B RID: 27659 RVA: 0x00025020 File Offset: 0x00023220
			[Token(Token = "0x6007D14")]
			[Address(RVA = "0x21A0630", Offset = "0x21A0731", VA = "0x21A0630")]
			internal bool <CheckWorkAreaData>b__0(FarmCropData cell)
			{
				return default(bool);
			}

			// Token: 0x04017465 RID: 95333
			[Token(Token = "0x401C0D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int offset;

			// Token: 0x04017466 RID: 95334
			[Token(Token = "0x401C0D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int separate;
		}
	}
}
