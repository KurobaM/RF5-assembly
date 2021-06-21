using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000430 RID: 1072
[Token(Token = "0x200033C")]
public class EventFestivalManager
{
	// Token: 0x060019F2 RID: 6642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001718")]
	[Address(RVA = "0x21E8DB0", Offset = "0x21E8EB1", VA = "0x21E8DB0")]
	public void SetMyScore(float value)
	{
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x21E8DC0", Offset = "0x21E8EC1", VA = "0x21E8DC0")]
	public string GetMyScoreResult()
	{
		return null;
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171A")]
	[Address(RVA = "0x21E8F60", Offset = "0x21E9061", VA = "0x21E8F60")]
	public void Start()
	{
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0000B370 File Offset: 0x00009570
	[Token(Token = "0x170003F7")]
	public bool HasFishingRod
	{
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x21E9020", Offset = "0x21E9121", VA = "0x21E9020")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x0000B388 File Offset: 0x00009588
	[Token(Token = "0x600171C")]
	[Address(RVA = "0x21E9220", Offset = "0x21E9321", VA = "0x21E9220")]
	private bool IsFishongRod(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x0000B3A0 File Offset: 0x000095A0
	[Token(Token = "0x600171D")]
	[Address(RVA = "0x21E9230", Offset = "0x21E9331", VA = "0x21E9230")]
	public bool IsSendFesPresent(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x0000B3B8 File Offset: 0x000095B8
	[Token(Token = "0x600171E")]
	[Address(RVA = "0x21E92A0", Offset = "0x21E93A1", VA = "0x21E92A0")]
	public bool IsRecvFesPresent(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600171F")]
	[Address(RVA = "0x21E9310", Offset = "0x21E9411", VA = "0x21E9310")]
	public void AddPresentSendActor(ActorID actorID)
	{
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001720")]
	[Address(RVA = "0x21E9380", Offset = "0x21E9481", VA = "0x21E9380")]
	public void AddPresentRecvActor(ActorID actorID)
	{
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x0000B3D0 File Offset: 0x000095D0
	[Token(Token = "0x6001721")]
	[Address(RVA = "0x21E9510", Offset = "0x21E9611", VA = "0x21E9510")]
	private ItemID GetPresentFlowerId(ActorID actorID)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001722")]
	[Address(RVA = "0x21E9720", Offset = "0x21E9821", VA = "0x21E9720")]
	public string GetPresentFlowerName()
	{
		return null;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x21E9810", Offset = "0x21E9911", VA = "0x21E9810")]
	public void Reset(int FesId)
	{
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x0000B3E8 File Offset: 0x000095E8
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x21E9AF0", Offset = "0x21E9BF1", VA = "0x21E9AF0")]
	public bool IsContestFes(Define.Event FesId)
	{
		return default(bool);
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0000B400 File Offset: 0x00009600
	[Token(Token = "0x6001725")]
	[Address(RVA = "0x21E9B20", Offset = "0x21E9C21", VA = "0x21E9B20")]
	public bool AcceptEventItem(Define.Event FesId, HumanController causer, int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0000B418 File Offset: 0x00009618
	[Token(Token = "0x6001726")]
	[Address(RVA = "0x21EAC00", Offset = "0x21EAD01", VA = "0x21EAC00")]
	private bool IsVeryFavoriteItem(NpcStatusData statusData, int itemId)
	{
		return default(bool);
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0000B430 File Offset: 0x00009630
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x21EAC70", Offset = "0x21EAD71", VA = "0x21EAC70")]
	private bool IsFavoriteItem(NpcStatusData statusData, int itemId)
	{
		return default(bool);
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0000B448 File Offset: 0x00009648
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x21EACE0", Offset = "0x21EADE1", VA = "0x21EACE0")]
	private bool IsNotFavoriteBadlyItem(NpcStatusData statusData, int itemId)
	{
		return default(bool);
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x0000B460 File Offset: 0x00009660
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x21EAD50", Offset = "0x21EAE51", VA = "0x21EAD50")]
	private bool IsNotFavoriteItem(NpcStatusData statusData, int itemId)
	{
		return default(bool);
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x21EA720", Offset = "0x21EA821", VA = "0x21EA720")]
	private void CalcFesScore_Sweets(int JudgeChildId, ItemData itemData)
	{
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x0000B478 File Offset: 0x00009678
	[Token(Token = "0x600172B")]
	[Address(RVA = "0x21EADC0", Offset = "0x21EAEC1", VA = "0x21EADC0")]
	private bool IsSweets(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x21EA210", Offset = "0x21EA311", VA = "0x21EA210")]
	private void CalcFesScore_Cook(ItemData itemData, bool is_sweets = false)
	{
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x0000B490 File Offset: 0x00009690
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x21EA570", Offset = "0x21EA671", VA = "0x21EA570")]
	public float CalacVegetableContest(HumanController causer)
	{
		return 0f;
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x0000B4A8 File Offset: 0x000096A8
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x21EAEA0", Offset = "0x21EAFA1", VA = "0x21EAEA0")]
	private bool IsVegetablesContest(int FesId)
	{
		return default(bool);
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0000B4C0 File Offset: 0x000096C0
	[Token(Token = "0x600172F")]
	[Address(RVA = "0x21EAEE0", Offset = "0x21EAFE1", VA = "0x21EAEE0")]
	private bool IsChild(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x0000B4D8 File Offset: 0x000096D8
	[Token(Token = "0x6001730")]
	[Address(RVA = "0x21EAEF0", Offset = "0x21EAFF1", VA = "0x21EAEF0")]
	public bool CalcFesScore()
	{
		return default(bool);
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001731")]
	[Address(RVA = "0x21ED400", Offset = "0x21ED501", VA = "0x21ED400")]
	public void CompareRivalScore(int FesId, float myScore)
	{
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x0000B4F0 File Offset: 0x000096F0
	[Token(Token = "0x6001732")]
	[Address(RVA = "0x21E8F00", Offset = "0x21E9001", VA = "0x21E8F00")]
	public Define.Event GetTodayFesEventId()
	{
		return Define.Event.NONE;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0000B508 File Offset: 0x00009708
	[Token(Token = "0x6001733")]
	[Address(RVA = "0x21EDF60", Offset = "0x21EE061", VA = "0x21EDF60")]
	public int GetPlayerRank()
	{
		return 0;
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x21EE030", Offset = "0x21EE131", VA = "0x21EE030")]
	public string GetFesSeason()
	{
		return null;
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001735")]
	[Address(RVA = "0x21EE170", Offset = "0x21EE271", VA = "0x21EE170")]
	public string GetFesName()
	{
		return null;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001736")]
	[Address(RVA = "0x21EE350", Offset = "0x21EE451", VA = "0x21EE350")]
	public string GetFesReceptionTime(int type)
	{
		return null;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001737")]
	[Address(RVA = "0x21EE5C0", Offset = "0x21EE6C1", VA = "0x21EE5C0")]
	public string GetFesPlayerItem()
	{
		return null;
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001738")]
	[Address(RVA = "0x21EE5D0", Offset = "0x21EE6D1", VA = "0x21EE5D0")]
	public string GetFesRank1Name()
	{
		return null;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001739")]
	[Address(RVA = "0x21EEB60", Offset = "0x21EEC61", VA = "0x21EEB60")]
	public string GetFesRank2Name()
	{
		return null;
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600173A")]
	[Address(RVA = "0x21EEF70", Offset = "0x21EF071", VA = "0x21EEF70")]
	public string GetFesRank3Name()
	{
		return null;
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600173B")]
	[Address(RVA = "0x21EF380", Offset = "0x21EF481", VA = "0x21EF380")]
	public string GetFesRank1Score()
	{
		return null;
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600173C")]
	[Address(RVA = "0x21EF5E0", Offset = "0x21EF6E1", VA = "0x21EF5E0")]
	public string GetFesRank2Score()
	{
		return null;
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600173D")]
	[Address(RVA = "0x21EF890", Offset = "0x21EF991", VA = "0x21EF890")]
	public string GetFesRank3Score()
	{
		return null;
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600173E")]
	[Address(RVA = "0x21EFB50", Offset = "0x21EFC51", VA = "0x21EFB50")]
	public string GetFesUnit()
	{
		return null;
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x0000B520 File Offset: 0x00009720
	[Token(Token = "0x600173F")]
	[Address(RVA = "0x21ED0F0", Offset = "0x21ED1F1", VA = "0x21ED0F0")]
	public int GetScoreIdx(int FesId)
	{
		return 0;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x21EFD40", Offset = "0x21EFE41", VA = "0x21EFD40")]
	public void AddAppealScore(int score)
	{
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x21EFD60", Offset = "0x21EFE61", VA = "0x21EFD60")]
	public void SelectHotarubiDate()
	{
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x0000B538 File Offset: 0x00009738
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x21F03C0", Offset = "0x21F04C1", VA = "0x21F03C0")]
	public int GetHotarubiNpc(int idx)
	{
		return 0;
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x21F0500", Offset = "0x21F0601", VA = "0x21F0500")]
	public void CheckHotarubiDate()
	{
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001744")]
	[Address(RVA = "0x21F0730", Offset = "0x21F0831", VA = "0x21F0730")]
	public void AddFishCount(int fishType, bool isIka)
	{
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001745")]
	[Address(RVA = "0x21F0860", Offset = "0x21F0961", VA = "0x21F0860")]
	public void JudgeChildMsg()
	{
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0000B550 File Offset: 0x00009750
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x21F0A60", Offset = "0x21F0B61", VA = "0x21F0A60")]
	public bool FesNearCandidate()
	{
		return default(bool);
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0000B568 File Offset: 0x00009768
	[Token(Token = "0x6001747")]
	[Address(RVA = "0x21F0BE0", Offset = "0x21F0CE1", VA = "0x21F0BE0")]
	public bool IsFesInNo3()
	{
		return default(bool);
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x21F0C50", Offset = "0x21F0D51", VA = "0x21F0C50")]
	public void ReturnFesItem(Vector3 pos)
	{
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001749")]
	[Address(RVA = "0x21F0CF0", Offset = "0x21F0DF1", VA = "0x21F0CF0")]
	public void SpawnFestivalTreasureBox()
	{
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600174A")]
	[Address(RVA = "0x21F1280", Offset = "0x21F1381", VA = "0x21F1280")]
	public void RemoveFestivalTreasureBox()
	{
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x0000B580 File Offset: 0x00009780
	[Token(Token = "0x600174B")]
	[Address(RVA = "0x21ED1D0", Offset = "0x21ED2D1", VA = "0x21ED1D0")]
	public bool CanJoinFestival(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x21F1300", Offset = "0x21F1401", VA = "0x21F1300")]
	public void CalcFesMemorialScore(Define.Event eventId)
	{
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x0000B598 File Offset: 0x00009798
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x21ECF50", Offset = "0x21ED051", VA = "0x21ECF50")]
	public bool IsImportantNpcOuting(int fesId)
	{
		return default(bool);
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600174E")]
	[Address(RVA = "0x21F1FB0", Offset = "0x21F20B1", VA = "0x21F1FB0")]
	public EventFestivalManager()
	{
	}

	// Token: 0x04005D0B RID: 23819
	[Token(Token = "0x4005952")]
	[FieldOffset(Offset = "0x10")]
	public FesNpcScoreTable FesNpcScoreDatas;

	// Token: 0x04005D0C RID: 23820
	[Token(Token = "0x4005953")]
	[FieldOffset(Offset = "0x18")]
	public bool IsAcceptEventItem;

	// Token: 0x04005D0D RID: 23821
	[Token(Token = "0x4005954")]
	[FieldOffset(Offset = "0x20")]
	private string myItemName;

	// Token: 0x04005D0E RID: 23822
	[Token(Token = "0x4005955")]
	[FieldOffset(Offset = "0x28")]
	public int[] Ranker;

	// Token: 0x04005D0F RID: 23823
	[Token(Token = "0x4005956")]
	[FieldOffset(Offset = "0x30")]
	public bool IsHandMadeEventItem;

	// Token: 0x04005D10 RID: 23824
	[Token(Token = "0x4005957")]
	[FieldOffset(Offset = "0x31")]
	public bool IsNotEatEventItem;

	// Token: 0x04005D11 RID: 23825
	[Token(Token = "0x4005958")]
	[FieldOffset(Offset = "0x32")]
	public bool IsArrangeEventItem;

	// Token: 0x04005D12 RID: 23826
	[Token(Token = "0x4005959")]
	[FieldOffset(Offset = "0x34")]
	public float TasteLevel;

	// Token: 0x04005D13 RID: 23827
	[Token(Token = "0x400595A")]
	[FieldOffset(Offset = "0x38")]
	public float NutritionLevel;

	// Token: 0x04005D14 RID: 23828
	[Token(Token = "0x400595B")]
	[FieldOffset(Offset = "0x3C")]
	public float EvaluationLevel;

	// Token: 0x04005D15 RID: 23829
	[Token(Token = "0x400595C")]
	[FieldOffset(Offset = "0x40")]
	public int IsLikeFood;

	// Token: 0x04005D16 RID: 23830
	[Token(Token = "0x400595D")]
	[FieldOffset(Offset = "0x44")]
	public bool IsPumpkinFood;

	// Token: 0x04005D17 RID: 23831
	[Token(Token = "0x400595E")]
	[FieldOffset(Offset = "0x45")]
	public bool IsSeasonFood;

	// Token: 0x04005D18 RID: 23832
	[Token(Token = "0x400595F")]
	[FieldOffset(Offset = "0x48")]
	public float GrowLevel;

	// Token: 0x04005D19 RID: 23833
	[Token(Token = "0x4005960")]
	[FieldOffset(Offset = "0x4C")]
	public float QualityLevel;

	// Token: 0x04005D1A RID: 23834
	[Token(Token = "0x4005961")]
	[FieldOffset(Offset = "0x50")]
	public float AppealLevel;

	// Token: 0x04005D1B RID: 23835
	[Token(Token = "0x4005962")]
	[FieldOffset(Offset = "0x54")]
	public float MaterialLevel;

	// Token: 0x04005D1C RID: 23836
	[Token(Token = "0x4005963")]
	[FieldOffset(Offset = "0x58")]
	public float ComprehensiveLevel;

	// Token: 0x04005D1D RID: 23837
	[Token(Token = "0x4005964")]
	[FieldOffset(Offset = "0x5C")]
	public float DifficultyLevel;

	// Token: 0x04005D1E RID: 23838
	[Token(Token = "0x4005965")]
	[FieldOffset(Offset = "0x60")]
	public bool IsHotarubiDateSelect;

	// Token: 0x04005D1F RID: 23839
	[Token(Token = "0x4005966")]
	[FieldOffset(Offset = "0x64")]
	public int HotarubiDateCanselNo;

	// Token: 0x04005D20 RID: 23840
	[Token(Token = "0x4005967")]
	[FieldOffset(Offset = "0x68")]
	public int HotarubiNpcId;

	// Token: 0x04005D21 RID: 23841
	[Token(Token = "0x4005968")]
	[FieldOffset(Offset = "0x6C")]
	public float MiniGameScoreF;

	// Token: 0x04005D22 RID: 23842
	[Token(Token = "0x4005969")]
	[FieldOffset(Offset = "0x70")]
	public List<ActorID> MiniGamePetRanking;

	// Token: 0x04005D23 RID: 23843
	[Token(Token = "0x400596A")]
	[FieldOffset(Offset = "0x78")]
	public List<FesNpcScore> FesMemorialNpcScoreList;

	// Token: 0x04005D24 RID: 23844
	[Token(Token = "0x400596B")]
	[FieldOffset(Offset = "0x80")]
	public List<ActorID> FesMemorialJoinActorList;

	// Token: 0x04005D25 RID: 23845
	[Token(Token = "0x400596C")]
	[FieldOffset(Offset = "0x88")]
	public List<ActorID> FesMemorialVisitorActorList;

	// Token: 0x04005D26 RID: 23846
	[Token(Token = "0x400596D")]
	[FieldOffset(Offset = "0x90")]
	public float myScore;

	// Token: 0x04005D27 RID: 23847
	[Token(Token = "0x400596E")]
	[FieldOffset(Offset = "0x98")]
	private int[,,] ScoreTableAppear;

	// Token: 0x04005D28 RID: 23848
	[Token(Token = "0x400596F")]
	[FieldOffset(Offset = "0xA0")]
	private int[,,] ScoreTable;

	// Token: 0x04005D29 RID: 23849
	[Token(Token = "0x4005970")]
	[FieldOffset(Offset = "0xA8")]
	private int[,,] WinnerScoreTable;

	// Token: 0x04005D2A RID: 23850
	[Token(Token = "0x4005971")]
	[FieldOffset(Offset = "0xB0")]
	private string[,,] FesTimeTable;

	// Token: 0x04005D2B RID: 23851
	[Token(Token = "0x4005972")]
	[FieldOffset(Offset = "0xB8")]
	private ItemID[,] FlowerPresentTable;

	// Token: 0x04005D2C RID: 23852
	[Token(Token = "0x4005973")]
	[FieldOffset(Offset = "0xC0")]
	private int[] MinigamePointTable;

	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x200107D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576C0", Offset = "0x1577C1")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x06001A29 RID: 6697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0x21ECF40", Offset = "0x21ED041", VA = "0x21ECF40")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0x21F3830", Offset = "0x21F3931", VA = "0x21F3830")]
		internal bool <CalcFesScore>b__0(ActorID id)
		{
			return default(bool);
		}

		// Token: 0x04005D2D RID: 23853
		[Token(Token = "0x401902C")]
		[FieldOffset(Offset = "0x10")]
		public ActorID victoryActorId;
	}

	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x200107E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576D0", Offset = "0x1577D1")]
	private sealed class <>c__DisplayClass59_1
	{
		// Token: 0x06001A2B RID: 6699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0x21ED3F0", Offset = "0x21ED4F1", VA = "0x21ED3F0")]
		public <>c__DisplayClass59_1()
		{
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x6006DC8")]
		[Address(RVA = "0x21F3840", Offset = "0x21F3941", VA = "0x21F3840")]
		internal bool <CalcFesScore>b__1(FesNpcScore score)
		{
			return default(bool);
		}

		// Token: 0x04005D2E RID: 23854
		[Token(Token = "0x401902D")]
		[FieldOffset(Offset = "0x10")]
		public FesNpcScoreData fesdata;
	}
}
