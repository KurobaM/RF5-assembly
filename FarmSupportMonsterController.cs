using System;
using System.Collections.Generic;
using Define;
using Farm;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007AA RID: 1962
[Token(Token = "0x2000527")]
public class FarmSupportMonsterController
{
	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x06003279 RID: 12921 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600327A RID: 12922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000581")]
	public FarmSupportMonsterData FarmSupportMonsterData
	{
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x21AA7C0", Offset = "0x21AA8C1", VA = "0x21AA7C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D30", Offset = "0x1A4E31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x21AA7D0", Offset = "0x21AA8D1", VA = "0x21AA7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D40", Offset = "0x1A4E41")]
		private set
		{
		}
	}

	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x0600327B RID: 12923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000582")]
	private FriendMonsterStatusData FriendMonsterStatusData
	{
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x21AA7E0", Offset = "0x21AA8E1", VA = "0x21AA7E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x0600327C RID: 12924 RVA: 0x00011640 File Offset: 0x0000F840
	// (set) Token: 0x0600327D RID: 12925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000583")]
	public bool IsEndSupport
	{
		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x21AA800", Offset = "0x21AA901", VA = "0x21AA800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D50", Offset = "0x1A4E51")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x21AA810", Offset = "0x21AA911", VA = "0x21AA810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D60", Offset = "0x1A4E61")]
		private set
		{
		}
	}

	// Token: 0x0600327E RID: 12926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x21AA820", Offset = "0x21AA921", VA = "0x21AA820")]
	public FarmSupportMonsterController(FarmSupportMonsterData farmSupportMonsterData)
	{
	}

	// Token: 0x0600327F RID: 12927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x21AB160", Offset = "0x21AB261", VA = "0x21AB160")]
	private void CheckEndSupport()
	{
	}

	// Token: 0x06003280 RID: 12928 RVA: 0x00011658 File Offset: 0x0000F858
	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x21AB310", Offset = "0x21AB411", VA = "0x21AB310")]
	private bool StateAction_Wait()
	{
		return default(bool);
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x00011670 File Offset: 0x0000F870
	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x21AB3B0", Offset = "0x21AB4B1", VA = "0x21AB3B0")]
	private bool StateAction_Move(Vector3 targetPosition)
	{
		return default(bool);
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x00011688 File Offset: 0x0000F888
	[Token(Token = "0x6002A0D")]
	[Address(RVA = "0x21AB730", Offset = "0x21AB831", VA = "0x21AB730")]
	private bool StateAction_Action(bool isLookAtMovePosition = true)
	{
		return default(bool);
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0x21ABAD0", Offset = "0x21ABBD1", VA = "0x21ABAD0")]
	private void StateBehavior_Room()
	{
	}

	// Token: 0x06003284 RID: 12932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0x21ABB70", Offset = "0x21ABC71", VA = "0x21ABB70")]
	private void StateBehavior_OutHut()
	{
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A10")]
	[Address(RVA = "0x21ABCB0", Offset = "0x21ABDB1", VA = "0x21ABCB0")]
	private void StateBehavior_InHut()
	{
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A11")]
	[Address(RVA = "0x21ABDF0", Offset = "0x21ABEF1", VA = "0x21ABDF0")]
	private void StateBehavior_InRoom()
	{
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x000116A0 File Offset: 0x0000F8A0
	[Token(Token = "0x6002A12")]
	[Address(RVA = "0x21ABEE0", Offset = "0x21ABFE1", VA = "0x21ABEE0")]
	private MiningPointSaveData GetMinigPointSaveData(int index)
	{
		return default(MiningPointSaveData);
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A13")]
	[Address(RVA = "0x21ABFB0", Offset = "0x21AC0B1", VA = "0x21ABFB0")]
	private void AddLumber()
	{
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A14")]
	[Address(RVA = "0x21AC0D0", Offset = "0x21AC1D1", VA = "0x21AC0D0")]
	private void AddStone()
	{
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A15")]
	[Address(RVA = "0x21AC1F0", Offset = "0x21AC2F1", VA = "0x21AC1F0")]
	private void GetMiningPointItem(MiningManager.MINING_MONSTER_TASK task, MiningPointSaveData data)
	{
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A16")]
	[Address(RVA = "0x21AC350", Offset = "0x21AC451", VA = "0x21AC350")]
	private void StateBehavior_Clean()
	{
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x000116B8 File Offset: 0x0000F8B8
	[Token(Token = "0x6002A17")]
	[Address(RVA = "0x21AC6C0", Offset = "0x21AC7C1", VA = "0x21AC6C0")]
	private bool TryGetFarmCropData(int index, out FarmCropData farmCropData)
	{
		return default(bool);
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A18")]
	[Address(RVA = "0x21AC780", Offset = "0x21AC881", VA = "0x21AC780")]
	private void DoFarmCropCell(FarmManager.FARM_MONSTER_TASK task, FarmCropData farmCropData)
	{
	}

	// Token: 0x0600328E RID: 12942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A19")]
	[Address(RVA = "0x21AD100", Offset = "0x21AD201", VA = "0x21AD100")]
	private void UpdateFarmCropAction(FarmManager.FARM_MONSTER_TASK checkTask, FarmCropData farmCropData)
	{
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1A")]
	[Address(RVA = "0x21AD380", Offset = "0x21AD481", VA = "0x21AD380")]
	private void UpdateWanderAction()
	{
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1B")]
	[Address(RVA = "0x21AD5B0", Offset = "0x21AD6B1", VA = "0x21AD5B0")]
	private void FarmCropAction(FarmManager.FARM_MONSTER_TASK checkTask)
	{
	}

	// Token: 0x06003291 RID: 12945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1C")]
	[Address(RVA = "0x21AD720", Offset = "0x21AD821", VA = "0x21AD720")]
	private void StateBehavior_Water()
	{
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1D")]
	[Address(RVA = "0x21AD730", Offset = "0x21AD831", VA = "0x21AD730")]
	private void StateBehavior_Seed()
	{
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1E")]
	[Address(RVA = "0x21AD740", Offset = "0x21AD841", VA = "0x21AD740")]
	private void StateBehavior_Crop()
	{
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A1F")]
	[Address(RVA = "0x21AD750", Offset = "0x21AD851", VA = "0x21AD750")]
	private void ExcuteStateBehavior()
	{
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A20")]
	[Address(RVA = "0x21AAFB0", Offset = "0x21AB0B1", VA = "0x21AAFB0")]
	private void ResetStateParameter(bool IsUpdateArea = true)
	{
	}

	// Token: 0x06003296 RID: 12950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A21")]
	[Address(RVA = "0x21AD7E0", Offset = "0x21AD8E1", VA = "0x21AD7E0")]
	private void Update_Room(int time)
	{
	}

	// Token: 0x06003297 RID: 12951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A22")]
	[Address(RVA = "0x21ADB30", Offset = "0x21ADC31", VA = "0x21ADB30")]
	private void Update_OutHut(int time)
	{
	}

	// Token: 0x06003298 RID: 12952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A23")]
	[Address(RVA = "0x21ADC70", Offset = "0x21ADD71", VA = "0x21ADC70")]
	private void Update_InRoom(int time)
	{
	}

	// Token: 0x06003299 RID: 12953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A24")]
	[Address(RVA = "0x21ADDC0", Offset = "0x21ADEC1", VA = "0x21ADDC0")]
	private void Update_InHut(int time)
	{
	}

	// Token: 0x0600329A RID: 12954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A25")]
	[Address(RVA = "0x21ADE90", Offset = "0x21ADF91", VA = "0x21ADE90")]
	private void Update_Clean(int time)
	{
	}

	// Token: 0x0600329B RID: 12955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A26")]
	[Address(RVA = "0x21AE060", Offset = "0x21AE161", VA = "0x21AE060")]
	private void Update_Seed(int time)
	{
	}

	// Token: 0x0600329C RID: 12956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A27")]
	[Address(RVA = "0x21AE1C0", Offset = "0x21AE2C1", VA = "0x21AE1C0")]
	private void Update_Water(int time)
	{
	}

	// Token: 0x0600329D RID: 12957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A28")]
	[Address(RVA = "0x21AE280", Offset = "0x21AE381", VA = "0x21AE280")]
	private void Update_Crop(int time)
	{
	}

	// Token: 0x0600329E RID: 12958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x21AE2F0", Offset = "0x21AE3F1", VA = "0x21AE2F0")]
	private void UpdateState(int time)
	{
	}

	// Token: 0x0600329F RID: 12959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A2A")]
	[Address(RVA = "0x21AE590", Offset = "0x21AE691", VA = "0x21AE590")]
	public void UpdateDayWork()
	{
	}

	// Token: 0x060032A0 RID: 12960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x21AE760", Offset = "0x21AE861", VA = "0x21AE760")]
	public void UpdateFrameWork()
	{
	}

	// Token: 0x060032A1 RID: 12961 RVA: 0x000116D0 File Offset: 0x0000F8D0
	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x21AE560", Offset = "0x21AE661", VA = "0x21AE560")]
	private bool IsMonsterHutScene(FieldSceneId fieldSceneId)
	{
		return default(bool);
	}

	// Token: 0x060032A2 RID: 12962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x21AE880", Offset = "0x21AE981", VA = "0x21AE880")]
	private FarmMonsterBehaviorController GetFarmMonsterBehaviorController(ActorID actorID)
	{
		return null;
	}

	// Token: 0x060032A3 RID: 12963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x21AECA0", Offset = "0x21AEDA1", VA = "0x21AECA0")]
	public void OrderCreateCharacter()
	{
	}

	// Token: 0x060032A4 RID: 12964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x21AEAE0", Offset = "0x21AEBE1", VA = "0x21AEAE0")]
	private void DestroyCharacter()
	{
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x21AF080", Offset = "0x21AF181", VA = "0x21AF080")]
	public void OrderDestroyCharacter()
	{
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x21AF0C0", Offset = "0x21AF1C1", VA = "0x21AF0C0")]
	public void SetDisplayCharacter(bool isDisplay)
	{
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x000116E8 File Offset: 0x0000F8E8
	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x21AE430", Offset = "0x21AE531", VA = "0x21AE430")]
	private FieldSceneId GetCurrentSceneId()
	{
		return FieldSceneId.Empty;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x21AEC90", Offset = "0x21AED91", VA = "0x21AEC90")]
	private void ResetCharacterFlag()
	{
	}

	// Token: 0x060032A9 RID: 12969 RVA: 0x00011700 File Offset: 0x0000F900
	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x21AF110", Offset = "0x21AF211", VA = "0x21AF110")]
	private bool IsSameScenePlayer()
	{
		return default(bool);
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x21AE660", Offset = "0x21AE761", VA = "0x21AE660")]
	public void UpdateCharacter()
	{
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x21AF180", Offset = "0x21AF281", VA = "0x21AF180")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D70", Offset = "0x1A4E71")]
	private void <OrderCreateCharacter>b__67_1(uint id, ActorID actorId)
	{
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x21AF1B0", Offset = "0x21AF2B1", VA = "0x21AF1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4D80", Offset = "0x1A4E81")]
	private void <OrderCreateCharacter>b__67_0(uint id, ActorID actorID)
	{
	}

	// Token: 0x04007729 RID: 30505
	[Token(Token = "0x4006C92")]
	private const float ArriveDistanceMargin = 1f;

	// Token: 0x0400772A RID: 30506
	[Token(Token = "0x4006C93")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169A00", Offset = "0x169B01")]
	private FarmSupportMonsterData <FarmSupportMonsterData>k__BackingField;

	// Token: 0x0400772B RID: 30507
	[Token(Token = "0x4006C94")]
	[FieldOffset(Offset = "0x18")]
	public FriendMonsterStatus FriendMonsterStatus;

	// Token: 0x0400772C RID: 30508
	[Token(Token = "0x4006C95")]
	[FieldOffset(Offset = "0x20")]
	public CharacterMoveParam CharacterMoveParam;

	// Token: 0x0400772D RID: 30509
	[Token(Token = "0x4006C96")]
	[FieldOffset(Offset = "0x28")]
	private float ArriveDistance;

	// Token: 0x0400772E RID: 30510
	[Token(Token = "0x4006C97")]
	[FieldOffset(Offset = "0x2C")]
	private bool IsEndExcuteStateBehavior;

	// Token: 0x0400772F RID: 30511
	[Token(Token = "0x4006C98")]
	[FieldOffset(Offset = "0x30")]
	private FarmMonsterWorkState FarmMonsterWorkState;

	// Token: 0x04007730 RID: 30512
	[Token(Token = "0x4006C99")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 MoveTargetPosition;

	// Token: 0x04007731 RID: 30513
	[Token(Token = "0x4006C9A")]
	[FieldOffset(Offset = "0x40")]
	private float NotTaskWaitTimer;

	// Token: 0x04007732 RID: 30514
	[Token(Token = "0x4006C9B")]
	[FieldOffset(Offset = "0x44")]
	private FarmSupportMonsterController.BehaviorState CurrentOutHutBehaviorState;

	// Token: 0x04007733 RID: 30515
	[Token(Token = "0x4006C9C")]
	[FieldOffset(Offset = "0x48")]
	private List<MiningPointSaveData> MiningPointSaveDataList;

	// Token: 0x04007734 RID: 30516
	[Token(Token = "0x4006C9D")]
	[FieldOffset(Offset = "0x50")]
	private List<FarmCropData> FarmCropDataList;

	// Token: 0x04007735 RID: 30517
	[Token(Token = "0x4006C9E")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, Action<int>> UpdateStateDic;

	// Token: 0x04007736 RID: 30518
	[Token(Token = "0x4006C9F")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, Action> UpdateStateBehaviorDic;

	// Token: 0x04007737 RID: 30519
	[Token(Token = "0x4006CA0")]
	[FieldOffset(Offset = "0x68")]
	private FieldSceneId previousPlayerSceneId;

	// Token: 0x04007738 RID: 30520
	[Token(Token = "0x4006CA1")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169A10", Offset = "0x169B11")]
	private bool <IsEndSupport>k__BackingField;

	// Token: 0x04007739 RID: 30521
	[Token(Token = "0x4006CA2")]
	[FieldOffset(Offset = "0x70")]
	private FarmSupportMonsterController.BehaviorState WanderOutHutBehaviorState;

	// Token: 0x0400773A RID: 30522
	[Token(Token = "0x4006CA3")]
	[FieldOffset(Offset = "0x78")]
	public FarmMonsterBehaviorController FarmMonsterBehaviorController;

	// Token: 0x0400773B RID: 30523
	[Token(Token = "0x4006CA4")]
	[FieldOffset(Offset = "0x80")]
	public bool IsLoading;

	// Token: 0x0400773C RID: 30524
	[Token(Token = "0x4006CA5")]
	[FieldOffset(Offset = "0x81")]
	public bool IsEndDestroy;

	// Token: 0x0400773D RID: 30525
	[Token(Token = "0x4006CA6")]
	[FieldOffset(Offset = "0x82")]
	public bool IsDestroy;

	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x2001209")]
	private enum BehaviorState
	{
		// Token: 0x0400773F RID: 30527
		[Token(Token = "0x4019701")]
		None,
		// Token: 0x04007740 RID: 30528
		[Token(Token = "0x4019702")]
		ToRoom,
		// Token: 0x04007741 RID: 30529
		[Token(Token = "0x4019703")]
		ToFarm,
		// Token: 0x04007742 RID: 30530
		[Token(Token = "0x4019704")]
		ToHut,
		// Token: 0x04007743 RID: 30531
		[Token(Token = "0x4019705")]
		ToCrop,
		// Token: 0x04007744 RID: 30532
		[Token(Token = "0x4019706")]
		ExcuteAction
	}

	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x200120A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158990", Offset = "0x158A91")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060032AE RID: 12974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007360")]
		[Address(RVA = "0x21AF250", Offset = "0x21AF351", VA = "0x21AF250")]
		public <>c()
		{
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007361")]
		[Address(RVA = "0x21AF260", Offset = "0x21AF361", VA = "0x21AF260")]
		internal void <.ctor>b__26_0(int time)
		{
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007362")]
		[Address(RVA = "0x21AF270", Offset = "0x21AF371", VA = "0x21AF270")]
		internal void <.ctor>b__26_1()
		{
		}

		// Token: 0x04007745 RID: 30533
		[Token(Token = "0x4019707")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FarmSupportMonsterController.<>c <>9;

		// Token: 0x04007746 RID: 30534
		[Token(Token = "0x4019708")]
		[FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__26_0;

		// Token: 0x04007747 RID: 30535
		[Token(Token = "0x4019709")]
		[FieldOffset(Offset = "0x10")]
		public static Action <>9__26_1;
	}
}
