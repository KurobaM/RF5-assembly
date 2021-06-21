using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007FC RID: 2044
[Token(Token = "0x2000543")]
[Serializable]
public class NpcDataManager : SingletonMonoBehaviour<NpcDataManager>
{
	// Token: 0x06003669 RID: 13929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x2595A50", Offset = "0x2595B51", VA = "0x2595A50")]
	public void AddPlayerConflictCount()
	{
	}

	// Token: 0x0600366A RID: 13930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x2595A60", Offset = "0x2595B61", VA = "0x2595A60")]
	public void SubPlayerConflictCount()
	{
	}

	// Token: 0x0600366B RID: 13931 RVA: 0x00012BB8 File Offset: 0x00010DB8
	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x259E220", Offset = "0x259E321", VA = "0x259E220")]
	public bool IsConflictPlayer()
	{
		return default(bool);
	}

	// Token: 0x0600366C RID: 13932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x259E230", Offset = "0x259E331", VA = "0x259E230", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600366D RID: 13933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x259E3D0", Offset = "0x259E4D1", VA = "0x259E3D0")]
	public void BeforeSaveNpcData()
	{
	}

	// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x259E4E0", Offset = "0x259E5E1", VA = "0x259E4E0")]
	public void AfterLoadNpcData()
	{
	}

	// Token: 0x0600366F RID: 13935 RVA: 0x00012BD0 File Offset: 0x00010DD0
	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x2593370", Offset = "0x2593471", VA = "0x2593370")]
	public int GetFreeGroupIndex()
	{
		return 0;
	}

	// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x25912F0", Offset = "0x25913F1", VA = "0x25912F0")]
	public void ClearGroupIndex(int idx)
	{
	}

	// Token: 0x06003671 RID: 13937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x259E5F0", Offset = "0x259E6F1", VA = "0x259E5F0")]
	public void Init()
	{
	}

	// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x259EDC0", Offset = "0x259EEC1", VA = "0x259EDC0")]
	public void LoadAfterAdvScriptDefCount()
	{
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x259ED40", Offset = "0x259EE41", VA = "0x259ED40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A59A0", Offset = "0x1A5AA1")]
	private IEnumerator RegistOnHourCarry()
	{
		return null;
	}

	// Token: 0x06003674 RID: 13940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x259EF30", Offset = "0x259F031", VA = "0x259EF30")]
	public static void NpcDataInitializeForNewGame()
	{
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x259E290", Offset = "0x259E391", VA = "0x259E290")]
	public void NpcDataInitializeForLifeCycle()
	{
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x259EEB0", Offset = "0x259EFB1", VA = "0x259EEB0")]
	private void SetNpcDataParameter(NpcData npcdata)
	{
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x259F060", Offset = "0x259F161", VA = "0x259F060")]
	public NpcData GetNpcData(ActorID actorId)
	{
		return null;
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x259F100", Offset = "0x259F201", VA = "0x259F100")]
	public NpcData GetNpcData(NPCID NpcId)
	{
		return null;
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x2593240", Offset = "0x2593341", VA = "0x2593240")]
	public NpcData GetNpcData(int NpcId)
	{
		return null;
	}

	// Token: 0x0600367A RID: 13946 RVA: 0x00012BE8 File Offset: 0x00010DE8
	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x259F230", Offset = "0x259F331", VA = "0x259F230")]
	public bool TryGetNpcData(int NpcId, out NpcData outData)
	{
		return default(bool);
	}

	// Token: 0x0600367B RID: 13947 RVA: 0x00012C00 File Offset: 0x00010E00
	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x258A720", Offset = "0x258A821", VA = "0x258A720")]
	public bool IsMyChild(int NpcId)
	{
		return default(bool);
	}

	// Token: 0x0600367C RID: 13948 RVA: 0x00012C18 File Offset: 0x00010E18
	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x259F380", Offset = "0x259F481", VA = "0x259F380")]
	public bool IsKids(NPCID npcId)
	{
		return default(bool);
	}

	// Token: 0x0600367D RID: 13949 RVA: 0x00012C30 File Offset: 0x00010E30
	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x2596680", Offset = "0x2596781", VA = "0x2596680")]
	public bool IsLoveTarget(NPCID npcId)
	{
		return default(bool);
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x00012C48 File Offset: 0x00010E48
	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x259A770", Offset = "0x259A871", VA = "0x259A770")]
	public bool CanChangeWear(NPCID npcId)
	{
		return default(bool);
	}

	// Token: 0x0600367F RID: 13951 RVA: 0x00012C60 File Offset: 0x00010E60
	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x258A740", Offset = "0x258A841", VA = "0x258A740")]
	public int GetSpouseNpcId()
	{
		return 0;
	}

	// Token: 0x06003680 RID: 13952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x259F390", Offset = "0x259F491", VA = "0x259F390")]
	public NpcData GetSpouseNpcData()
	{
		return null;
	}

	// Token: 0x06003681 RID: 13953 RVA: 0x00012C78 File Offset: 0x00010E78
	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x259F4C0", Offset = "0x259F5C1", VA = "0x259F4C0")]
	public bool IsSpouseNpc(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06003682 RID: 13954 RVA: 0x00012C90 File Offset: 0x00010E90
	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x259F500", Offset = "0x259F601", VA = "0x259F500")]
	public bool IsExistLover(int npcid = -1)
	{
		return default(bool);
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x00012CA8 File Offset: 0x00010EA8
	[Token(Token = "0x6002D51")]
	[Address(RVA = "0x259F6C0", Offset = "0x259F7C1", VA = "0x259F6C0")]
	public int GetLoverNum()
	{
		return 0;
	}

	// Token: 0x06003684 RID: 13956 RVA: 0x00012CC0 File Offset: 0x00010EC0
	[Token(Token = "0x6002D52")]
	[Address(RVA = "0x259F7F0", Offset = "0x259F8F1", VA = "0x259F7F0")]
	public bool IsLover(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06003685 RID: 13957 RVA: 0x00012CD8 File Offset: 0x00010ED8
	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x259F940", Offset = "0x259FA41", VA = "0x259F940")]
	public bool IsMoreThanLover(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06003686 RID: 13958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x259E700", Offset = "0x259E801", VA = "0x259E700")]
	public void SetNpcStatusData()
	{
	}

	// Token: 0x06003687 RID: 13959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x259FAC0", Offset = "0x259FBC1", VA = "0x259FAC0")]
	public void UpdateBedPatrolPointName()
	{
	}

	// Token: 0x06003688 RID: 13960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x259EB80", Offset = "0x259EC81", VA = "0x259EB80")]
	public void LifeCycleLotteryInit()
	{
	}

	// Token: 0x06003689 RID: 13961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x259FE00", Offset = "0x259FF01", VA = "0x259FE00")]
	public void UpdateEventId()
	{
	}

	// Token: 0x0600368A RID: 13962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x259ECC0", Offset = "0x259EDC1", VA = "0x259ECC0")]
	public void LifeCycleLotteryStart()
	{
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x00012CF0 File Offset: 0x00010EF0
	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x25A0120", Offset = "0x25A0221", VA = "0x25A0120")]
	public bool LifeCycleLotteryUpdate()
	{
		return default(bool);
	}

	// Token: 0x0600368C RID: 13964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x25A0190", Offset = "0x25A0291", VA = "0x25A0190")]
	public List<NpcLifeCycleDataRecord> GetExtractMargineLifeCycleTimeSortList()
	{
		return null;
	}

	// Token: 0x0600368D RID: 13965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x25A05B0", Offset = "0x25A06B1", VA = "0x25A05B0")]
	public void SetScheduleData(int eventId)
	{
	}

	// Token: 0x0600368E RID: 13966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x25A05C0", Offset = "0x25A06C1", VA = "0x25A05C0")]
	private void OnHourCarry(int diff)
	{
	}

	// Token: 0x0600368F RID: 13967 RVA: 0x00012D08 File Offset: 0x00010F08
	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x25A06D0", Offset = "0x25A07D1", VA = "0x25A06D0")]
	public int GetTotalDatingCount()
	{
		return 0;
	}

	// Token: 0x06003690 RID: 13968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x25A0840", Offset = "0x25A0941", VA = "0x25A0840")]
	public void DoBecomeLover(int npcId)
	{
	}

	// Token: 0x06003691 RID: 13969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x25A09D0", Offset = "0x25A0AD1", VA = "0x25A09D0")]
	public void DoMarriage(int npcId)
	{
	}

	// Token: 0x06003692 RID: 13970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x25A0B50", Offset = "0x25A0C51", VA = "0x25A0B50")]
	public void DoPartner(int npcId, [Optional] Action<PartnerNPCBehaviorController> callBack)
	{
	}

	// Token: 0x06003693 RID: 13971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x25A0CD0", Offset = "0x25A0DD1", VA = "0x25A0CD0")]
	public void ReleasePartner(int npcId, [Optional] Action<NpcController> callBack)
	{
	}

	// Token: 0x06003694 RID: 13972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x25A0E50", Offset = "0x25A0F51", VA = "0x25A0E50")]
	public void ReleasePartnerByTime(int npcId)
	{
	}

	// Token: 0x06003695 RID: 13973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x25A0FB0", Offset = "0x25A10B1", VA = "0x25A0FB0")]
	public void SetIsDateRefrain(int npcId, bool value)
	{
	}

	// Token: 0x06003696 RID: 13974 RVA: 0x00012D20 File Offset: 0x00010F20
	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x25A10E0", Offset = "0x25A11E1", VA = "0x25A10E0")]
	public int GetDateRefrain()
	{
		return 0;
	}

	// Token: 0x06003697 RID: 13975 RVA: 0x00012D38 File Offset: 0x00010F38
	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x25A1220", Offset = "0x25A1321", VA = "0x25A1220")]
	public bool IsMarriageCandidate(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06003698 RID: 13976 RVA: 0x00012D50 File Offset: 0x00010F50
	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x25A1300", Offset = "0x25A1401", VA = "0x25A1300")]
	public bool IsHospitalPerson(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06003699 RID: 13977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x25A1310", Offset = "0x25A1411", VA = "0x25A1310")]
	public void InitializeHintTalkTime()
	{
	}

	// Token: 0x0600369A RID: 13978 RVA: 0x00012D68 File Offset: 0x00010F68
	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x25A1450", Offset = "0x25A1551", VA = "0x25A1450")]
	public bool IsPriscillaChangedStyle()
	{
		return default(bool);
	}

	// Token: 0x0600369B RID: 13979 RVA: 0x00012D80 File Offset: 0x00010F80
	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x25A1500", Offset = "0x25A1601", VA = "0x25A1500")]
	public bool IsShopOpened(int npcId)
	{
		return default(bool);
	}

	// Token: 0x0600369C RID: 13980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x25A1520", Offset = "0x25A1621", VA = "0x25A1520")]
	public void RemoveAllResources()
	{
	}

	// Token: 0x0600369D RID: 13981 RVA: 0x00012D98 File Offset: 0x00010F98
	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x2588A10", Offset = "0x2588B11", VA = "0x2588A10")]
	public bool IsSitting(NpcAnimState state)
	{
		return default(bool);
	}

	// Token: 0x0600369E RID: 13982 RVA: 0x00012DB0 File Offset: 0x00010FB0
	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x25A15D0", Offset = "0x25A16D1", VA = "0x25A15D0")]
	public bool IsSleeping(NpcAnimState state)
	{
		return default(bool);
	}

	// Token: 0x0600369F RID: 13983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x25A1600", Offset = "0x25A1701", VA = "0x25A1600")]
	public Actor CreateNpcActor(int npcId)
	{
		return null;
	}

	// Token: 0x060036A0 RID: 13984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x25A16B0", Offset = "0x25A17B1", VA = "0x25A16B0")]
	public void EnableNpcLifecycleItems(ActorID actorId, bool enable)
	{
	}

	// Token: 0x060036A1 RID: 13985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x25A1A40", Offset = "0x25A1B41", VA = "0x25A1A40")]
	public NpcDataManager()
	{
	}

	// Token: 0x04007994 RID: 31124
	[Token(Token = "0x4006E26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool NewGameInitialize;

	// Token: 0x04007995 RID: 31125
	[Token(Token = "0x4006E27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly int DatingNumTotalMax;

	// Token: 0x04007996 RID: 31126
	[Token(Token = "0x4006E28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public readonly int DatingNumMax;

	// Token: 0x04007997 RID: 31127
	[Token(Token = "0x4006E29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int MobTalkCount;

	// Token: 0x04007998 RID: 31128
	[Token(Token = "0x4006E2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool TodayMobTalked;

	// Token: 0x04007999 RID: 31129
	[Token(Token = "0x4006E2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool TodayMobEnabled;

	// Token: 0x0400799A RID: 31130
	[Token(Token = "0x4006E2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool[] NpcGroupIds;

	// Token: 0x0400799B RID: 31131
	[Token(Token = "0x4006E2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public List<NpcData> NpcDatas;

	// Token: 0x0400799C RID: 31132
	[Token(Token = "0x4006E2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool Initialize;

	// Token: 0x0400799D RID: 31133
	[Token(Token = "0x4006E2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool Standby;

	// Token: 0x0400799E RID: 31134
	[Token(Token = "0x4006E30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LovePointManager LovePointManager;

	// Token: 0x0400799F RID: 31135
	[Token(Token = "0x4006E31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int PlayerConflictCount;

	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x200123E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BE0", Offset = "0x158CE1")]
	private sealed class <RegistOnHourCarry>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060036A3 RID: 13987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600741B")]
		[Address(RVA = "0x1F45BE0", Offset = "0x1F45CE1", VA = "0x1F45BE0")]
		[DebuggerHidden]
		public <RegistOnHourCarry>d__22(int <>1__state)
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600741C")]
		[Address(RVA = "0x1F45C10", Offset = "0x1F45D11", VA = "0x1F45C10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x600741D")]
		[Address(RVA = "0x1F45C20", Offset = "0x1F45D21", VA = "0x1F45C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6E")]
		private object Current
		{
			[Token(Token = "0x600741E")]
			[Address(RVA = "0x1F45D60", Offset = "0x1F45E61", VA = "0x1F45D60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600741F")]
		[Address(RVA = "0x1F45D70", Offset = "0x1F45E71", VA = "0x1F45D70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6F")]
		private object Current
		{
			[Token(Token = "0x6007420")]
			[Address(RVA = "0x1F45DD0", Offset = "0x1F45ED1", VA = "0x1F45DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040079A0 RID: 31136
		[Token(Token = "0x40197D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040079A1 RID: 31137
		[Token(Token = "0x40197D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040079A2 RID: 31138
		[Token(Token = "0x40197D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcDataManager <>4__this;
	}
}
