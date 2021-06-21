using System;
using System.Collections.Generic;
using Define;
using Farm;
using Field;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x020007AE RID: 1966
[Token(Token = "0x2000529")]
public class FarmSupportMonsterManager : SingletonMonoBehaviour<FarmSupportMonsterManager>
{
	// Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A40")]
	[Address(RVA = "0x21AF5B0", Offset = "0x21AF6B1", VA = "0x21AF5B0")]
	public List<FarmFieldWorkArea> GetFreeFarmFieldWorkAreas(FarmManager.FARM_ID farmID)
	{
		return null;
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x00011730 File Offset: 0x0000F930
	[Token(Token = "0x6002A41")]
	[Address(RVA = "0x21AF730", Offset = "0x21AF831", VA = "0x21AF730")]
	public FarmFieldWorkArea GetFreeFarmFieldWorkArea(FarmManager.FARM_ID farmID)
	{
		return FarmFieldWorkArea.None;
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x00011748 File Offset: 0x0000F948
	[Token(Token = "0x6002A42")]
	[Address(RVA = "0x21AF7F0", Offset = "0x21AF8F1", VA = "0x21AF7F0")]
	public bool IsExistFarmSupportMonster(FarmManager.FARM_ID farmID, FarmFieldWorkArea farmFieldWorkArea)
	{
		return default(bool);
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A43")]
	[Address(RVA = "0x21AF8E0", Offset = "0x21AF9E1", VA = "0x21AF8E0")]
	public static void InitializeForNewGame()
	{
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x21AF8F0", Offset = "0x21AF9F1", VA = "0x21AF8F0")]
	public void OnAfterGameDataLoad()
	{
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x21AFB00", Offset = "0x21AFC01", VA = "0x21AFB00")]
	public void AddFarmSupportMonster(uint friendMonsterDataID)
	{
	}

	// Token: 0x060032BF RID: 12991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x21AFD20", Offset = "0x21AFE21", VA = "0x21AFD20")]
	private void UpdateData()
	{
	}

	// Token: 0x060032C0 RID: 12992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x21AFE80", Offset = "0x21AFF81", VA = "0x21AFE80")]
	private void UpdateFrame()
	{
	}

	// Token: 0x060032C1 RID: 12993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x21AFF40", Offset = "0x21B0041", VA = "0x21AFF40")]
	public void UpdateDay(int elapsedTime)
	{
	}

	// Token: 0x060032C2 RID: 12994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x21B0030", Offset = "0x21B0131", VA = "0x21B0030")]
	public void OnBeginTeleport()
	{
	}

	// Token: 0x060032C3 RID: 12995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x21B0090", Offset = "0x21B0191", VA = "0x21B0090")]
	public void OnEndTeleport()
	{
	}

	// Token: 0x060032C4 RID: 12996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x21AEF40", Offset = "0x21AF041", VA = "0x21AEF40")]
	public void OrderFarmIn(uint friendMonsterDataID, Action<uint, ActorID> callBack)
	{
	}

	// Token: 0x060032C5 RID: 12997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x21B0110", Offset = "0x21B0211", VA = "0x21B0110")]
	public void UpdateOrderFarmInList()
	{
	}

	// Token: 0x060032C6 RID: 12998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x21AFA90", Offset = "0x21AFB91", VA = "0x21AFA90")]
	public void UpdateCanBuySeedItemDataList()
	{
	}

	// Token: 0x060032C7 RID: 12999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x21ACE20", Offset = "0x21ACF21", VA = "0x21ACE20")]
	public ItemData GetPlantSeed()
	{
		return null;
	}

	// Token: 0x060032C8 RID: 13000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x21B0210", Offset = "0x21B0311", VA = "0x21B0210", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060032C9 RID: 13001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x21B03A0", Offset = "0x21B04A1", VA = "0x21B03A0")]
	private void Update()
	{
	}

	// Token: 0x060032CA RID: 13002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x21B03D0", Offset = "0x21B04D1", VA = "0x21B03D0")]
	public FarmSupportMonsterManager()
	{
	}

	// Token: 0x060032CC RID: 13004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A53")]
	[Address(RVA = "0x21B0F60", Offset = "0x21B1061", VA = "0x21B0F60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D90", Offset = "0x1A4E91")]
	private void <UpdateOrderFarmInList>b__33_0(uint u, ActorID id)
	{
	}

	// Token: 0x0400774E RID: 30542
	[Token(Token = "0x4006CAD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<int, FarmSupportMonsterManager.FarmScene> FarmIDToFarmScene;

	// Token: 0x0400774F RID: 30543
	[Token(Token = "0x4006CAE")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Vector3 HutRoomDoor;

	// Token: 0x04007750 RID: 30544
	[Token(Token = "0x4006CAF")]
	[FieldOffset(Offset = "0x18")]
	public static readonly Dictionary<int, Vector3> HutRoomPosition;

	// Token: 0x04007751 RID: 30545
	[Token(Token = "0x4006CB0")]
	[FieldOffset(Offset = "0x20")]
	public static readonly Dictionary<int, List<Vector3>> DragonFarmHutDoorDic;

	// Token: 0x04007752 RID: 30546
	[Token(Token = "0x4006CB1")]
	[FieldOffset(Offset = "0x28")]
	public static readonly float WorkTimeStart;

	// Token: 0x04007753 RID: 30547
	[Token(Token = "0x4006CB2")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly float WorkTimeStart_Seed;

	// Token: 0x04007754 RID: 30548
	[Token(Token = "0x4006CB3")]
	[FieldOffset(Offset = "0x30")]
	public static readonly float WorkTimeStart_Water;

	// Token: 0x04007755 RID: 30549
	[Token(Token = "0x4006CB4")]
	[FieldOffset(Offset = "0x34")]
	public static readonly float WorkTimeStart_Crop;

	// Token: 0x04007756 RID: 30550
	[Token(Token = "0x4006CB5")]
	[FieldOffset(Offset = "0x38")]
	public static readonly float WorkTimeEnd;

	// Token: 0x04007757 RID: 30551
	[Token(Token = "0x4006CB6")]
	[FieldOffset(Offset = "0x40")]
	public static readonly Dictionary<int, int> AreaIDToAreaNo;

	// Token: 0x04007758 RID: 30552
	[Token(Token = "0x4006CB7")]
	private const float MoneyBias = 0.005f;

	// Token: 0x04007759 RID: 30553
	[Token(Token = "0x4006CB8")]
	[FieldOffset(Offset = "0x18")]
	private List<FarmSupportMonsterController> FarmSupportMonsterControllerList;

	// Token: 0x0400775A RID: 30554
	[Token(Token = "0x4006CB9")]
	[FieldOffset(Offset = "0x20")]
	public FieldSceneId PlayerFieldSceneId;

	// Token: 0x0400775B RID: 30555
	[Token(Token = "0x4006CBA")]
	[FieldOffset(Offset = "0x28")]
	private List<FarmSupportMonsterManager.OrderFarmInParameter> FarmInOrderList;

	// Token: 0x0400775C RID: 30556
	[Token(Token = "0x4006CBB")]
	[FieldOffset(Offset = "0x30")]
	private FarmSupportMonsterManager.OrderFarmInParameter CurrentOrderFarmInParameter;

	// Token: 0x0400775D RID: 30557
	[Token(Token = "0x4006CBC")]
	[FieldOffset(Offset = "0x38")]
	private bool IsCreating;

	// Token: 0x0400775E RID: 30558
	[Token(Token = "0x4006CBD")]
	[FieldOffset(Offset = "0x40")]
	private SeedShopItemDataTable SeedShopItemDataTable;

	// Token: 0x0400775F RID: 30559
	[Token(Token = "0x4006CBE")]
	[FieldOffset(Offset = "0x48")]
	private List<SeedShopItemDataTable.SeedShopItemData> CanBuySeedList;

	// Token: 0x04007760 RID: 30560
	[Token(Token = "0x4006CBF")]
	[FieldOffset(Offset = "0x50")]
	private List<FarmSupportMonsterController> CurrentRemoveControllerList;

	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x200120B")]
	public class FarmScene
	{
		// Token: 0x060032CD RID: 13005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007363")]
		[Address(RVA = "0x21B0F50", Offset = "0x21B1051", VA = "0x21B0F50")]
		public FarmScene()
		{
		}

		// Token: 0x04007761 RID: 30561
		[Token(Token = "0x401970A")]
		[FieldOffset(Offset = "0x10")]
		public FieldSceneId FarmSceneId;

		// Token: 0x04007762 RID: 30562
		[Token(Token = "0x401970B")]
		[FieldOffset(Offset = "0x18")]
		public FieldSceneId[] MonsterHutScenes;
	}

	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x200120C")]
	public class OrderFarmInParameter
	{
		// Token: 0x060032CE RID: 13006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007364")]
		[Address(RVA = "0x21B0100", Offset = "0x21B0201", VA = "0x21B0100")]
		public OrderFarmInParameter()
		{
		}

		// Token: 0x04007763 RID: 30563
		[Token(Token = "0x401970C")]
		[FieldOffset(Offset = "0x10")]
		public uint FriendMonsterId;

		// Token: 0x04007764 RID: 30564
		[Token(Token = "0x401970D")]
		[FieldOffset(Offset = "0x18")]
		public Action<uint, ActorID> CallBack;
	}

	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x200120D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589A0", Offset = "0x158AA1")]
	private sealed class <>c__DisplayClass32_0
	{
		// Token: 0x060032CF RID: 13007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007365")]
		[Address(RVA = "0x21B00F0", Offset = "0x21B01F1", VA = "0x21B00F0")]
		public <>c__DisplayClass32_0()
		{
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6007366")]
		[Address(RVA = "0x21B10B0", Offset = "0x21B11B1", VA = "0x21B10B0")]
		internal bool <OrderFarmIn>b__0(FarmSupportMonsterManager.OrderFarmInParameter param)
		{
			return default(bool);
		}

		// Token: 0x04007765 RID: 30565
		[Token(Token = "0x401970E")]
		[FieldOffset(Offset = "0x10")]
		public uint friendMonsterDataID;
	}

	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x200120E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589B0", Offset = "0x158AB1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060032D2 RID: 13010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007368")]
		[Address(RVA = "0x21B1080", Offset = "0x21B1181", VA = "0x21B1080")]
		public <>c()
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6007369")]
		[Address(RVA = "0x21B1090", Offset = "0x21B1191", VA = "0x21B1090")]
		internal bool <GetPlantSeed>b__35_0(SeedShopItemDataTable.SeedShopItemData data)
		{
			return default(bool);
		}

		// Token: 0x04007766 RID: 30566
		[Token(Token = "0x401970F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FarmSupportMonsterManager.<>c <>9;

		// Token: 0x04007767 RID: 30567
		[Token(Token = "0x4019710")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<SeedShopItemDataTable.SeedShopItemData> <>9__35_0;
	}
}
