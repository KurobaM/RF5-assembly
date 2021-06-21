using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;

// Token: 0x020004AF RID: 1199
[Token(Token = "0x200037B")]
public class SubEventManager
{
	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
	// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700040C")]
	public bool IsSelectDating
	{
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x238FB40", Offset = "0x238FC41", VA = "0x238FB40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19EA40", Offset = "0x19EB41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x238FB50", Offset = "0x238FC51", VA = "0x238FB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19EA50", Offset = "0x19EB51")]
		private set
		{
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
	[Token(Token = "0x1700040D")]
	public bool IsOccurrenceSubEvent
	{
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x238FB60", Offset = "0x238FC61", VA = "0x238FB60")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194D")]
	[Address(RVA = "0x238FBC0", Offset = "0x238FCC1", VA = "0x238FBC0")]
	public SubEventManager()
	{
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x238FD30", Offset = "0x238FE31", VA = "0x238FD30")]
	private void Initialize()
	{
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x238FDA0", Offset = "0x238FEA1", VA = "0x238FDA0")]
	public void AdvUpdate()
	{
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001950")]
	[Address(RVA = "0x238FDC0", Offset = "0x238FEC1", VA = "0x238FDC0")]
	private void InitializeSaveData()
	{
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x238FEA0", Offset = "0x238FFA1", VA = "0x238FEA0")]
	public void UpdateSubEventSaveData()
	{
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001952")]
	[Address(RVA = "0x238FEB0", Offset = "0x238FFB1", VA = "0x238FEB0")]
	public void ApplySubEventSaveData()
	{
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001953")]
	[Address(RVA = "0x238FF20", Offset = "0x2390021", VA = "0x238FF20")]
	public void SubEventDataInitializeForNewGame()
	{
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x238FFA0", Offset = "0x23900A1", VA = "0x238FFA0")]
	private void RegistOnHourCarry()
	{
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x2390080", Offset = "0x2390181", VA = "0x2390080")]
	private void RegistOnSecondCarry()
	{
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001956")]
	[Address(RVA = "0x2390160", Offset = "0x2390261", VA = "0x2390160")]
	private void OnHourCarry(int diffHour)
	{
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x23901C0", Offset = "0x23902C1", VA = "0x23901C0")]
	public void WakeUpUpdateSubEventData(int diffDay)
	{
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x23901E0", Offset = "0x23902E1", VA = "0x23901E0")]
	private void AddAcceptSubEventData()
	{
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001959")]
	[Address(RVA = "0x23909C0", Offset = "0x2390AC1", VA = "0x23909C0")]
	private void AcceptSubEventData(SubEventMasterDataBase eventData)
	{
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600195A")]
	[Address(RVA = "0x2390DB0", Offset = "0x2390EB1", VA = "0x2390DB0")]
	private void SubEventStartScript(SubEventMasterDataBase eventData, int step = 0)
	{
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195B")]
	[Address(RVA = "0x2390FE0", Offset = "0x23910E1", VA = "0x2390FE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19EA60", Offset = "0x19EB61")]
	private IEnumerator RunBirthChildScript()
	{
		return null;
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x2390C50", Offset = "0x2390D51", VA = "0x2390C50")]
	private SubEventData CreateAddEventData(SubEventMasterDataBase masterData)
	{
		return null;
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x2390220", Offset = "0x2390321", VA = "0x2390220")]
	private SubEventMasterDataBase GetOccurringSubEventData()
	{
		return null;
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x2391260", Offset = "0x2391361", VA = "0x2391260")]
	private int OccurrenceLottely(List<SubEventMasterDataBase> datas)
	{
		return 0;
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x0000C810 File Offset: 0x0000AA10
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x2391470", Offset = "0x2391571", VA = "0x2391470")]
	private bool CheckAssistOccurrencePeriod()
	{
		return default(bool);
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x0000C828 File Offset: 0x0000AA28
	[Token(Token = "0x6001960")]
	[Address(RVA = "0x23914E0", Offset = "0x23915E1", VA = "0x23914E0")]
	public bool CheckInviteToDating()
	{
		return default(bool);
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x0000C840 File Offset: 0x0000AA40
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x2391550", Offset = "0x2391651", VA = "0x2391550")]
	private bool NonOccurringPeriodByEvent()
	{
		return default(bool);
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x0000C858 File Offset: 0x0000AA58
	[Token(Token = "0x6001962")]
	[Address(RVA = "0x23910D0", Offset = "0x23911D1", VA = "0x23910D0")]
	private bool NonOccurringPeriod()
	{
		return default(bool);
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x0000C870 File Offset: 0x0000AA70
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x2391360", Offset = "0x2391461", VA = "0x2391360")]
	private bool CheckForceOvvurrence()
	{
		return default(bool);
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x2391560", Offset = "0x2391661", VA = "0x2391560")]
	private void ProceedSubEventStepNextDay(int diffDay)
	{
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x2391730", Offset = "0x2391831", VA = "0x2391730")]
	private void ProceedSubEventStepNextTime(int diffSec)
	{
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x0000C888 File Offset: 0x0000AA88
	[Token(Token = "0x6001966")]
	[Address(RVA = "0x2391060", Offset = "0x2391161", VA = "0x2391060")]
	private bool CheckNoGenerateSubEventByMaking()
	{
		return default(bool);
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x23919B0", Offset = "0x2391AB1", VA = "0x23919B0")]
	public SubEventMasterDataBase GetSubEventData(int eventId)
	{
		return null;
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001968")]
	[Address(RVA = "0x2391AD0", Offset = "0x2391BD1", VA = "0x2391AD0")]
	public SubEventData GetOccurrenceSubEventData()
	{
		return null;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x2391BF0", Offset = "0x2391CF1", VA = "0x2391BF0")]
	public int GetOccurrenceSubEventId()
	{
		return 0;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
	[Token(Token = "0x600196A")]
	[Address(RVA = "0x2391D30", Offset = "0x2391E31", VA = "0x2391D30")]
	public int GetOccurrenceLoveEventId()
	{
		return 0;
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x2391EC0", Offset = "0x2391FC1", VA = "0x2391EC0")]
	public int GetNpcJoinAdvSubEventId(int npcid)
	{
		return 0;
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x2392050", Offset = "0x2392151", VA = "0x2392050")]
	public bool CheckNpcJoinSubEvent(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x0000C900 File Offset: 0x0000AB00
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x2392200", Offset = "0x2392301", VA = "0x2392200")]
	public bool CheckNpcJoinSubEventAdv(int npcid, bool isLovEvent = false)
	{
		return default(bool);
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x0000C918 File Offset: 0x0000AB18
	[Token(Token = "0x600196E")]
	[Address(RVA = "0x23924A0", Offset = "0x23925A1", VA = "0x23924A0")]
	public int GetOccurrenceSubEventStep(int eventid, int npcid = -1)
	{
		return 0;
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600196F")]
	[Address(RVA = "0x2392710", Offset = "0x2392811", VA = "0x2392710")]
	public void ProceedOccurrenceSubEventNpcAdvStep(int eventid, int npcid)
	{
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x0000C930 File Offset: 0x0000AB30
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x2392480", Offset = "0x2392581", VA = "0x2392480")]
	public bool IsLovEvent(SubEventType type)
	{
		return default(bool);
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x0000C948 File Offset: 0x0000AB48
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x2392900", Offset = "0x2392A01", VA = "0x2392900")]
	public bool IsDatEvent(SubEventType type)
	{
		return default(bool);
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x0000C960 File Offset: 0x0000AB60
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x2392910", Offset = "0x2392A11", VA = "0x2392910")]
	public SubEventType GetSubEventType(int eventid)
	{
		return SubEventType.None;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x0000C978 File Offset: 0x0000AB78
	[Token(Token = "0x6001973")]
	[Address(RVA = "0x2392A30", Offset = "0x2392B31", VA = "0x2392A30")]
	public SubEventType GetOccurrenceSubEventType(int eventid)
	{
		return SubEventType.None;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x0000C990 File Offset: 0x0000AB90
	[Token(Token = "0x6001974")]
	[Address(RVA = "0x2392B70", Offset = "0x2392C71", VA = "0x2392B70")]
	public bool CheckNotAllowedNpcId(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
	[Token(Token = "0x6001975")]
	[Address(RVA = "0x23911C0", Offset = "0x23912C1", VA = "0x23911C0")]
	private bool CheckOccurrenceSubEventComplete(SubEventMasterDataBase data)
	{
		return default(bool);
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
	[Token(Token = "0x6001976")]
	[Address(RVA = "0x2392CD0", Offset = "0x2392DD1", VA = "0x2392CD0")]
	public bool CheckSubEventComplete(int eventId)
	{
		return default(bool);
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x2392E30", Offset = "0x2392F31", VA = "0x2392E30")]
	private bool CheckOccurrencedSubEvent(int eventid)
	{
		return default(bool);
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
	[Token(Token = "0x6001978")]
	[Address(RVA = "0x2392F60", Offset = "0x2393061", VA = "0x2392F60")]
	public bool CheckCanMarriage_ThrowRing(NpcData data)
	{
		return default(bool);
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x0000CA08 File Offset: 0x0000AC08
	[Token(Token = "0x6001979")]
	[Address(RVA = "0x2393070", Offset = "0x2393171", VA = "0x2393070")]
	public bool CheckCanMarriage(NpcData data)
	{
		return default(bool);
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x0000CA20 File Offset: 0x0000AC20
	[Token(Token = "0x600197A")]
	[Address(RVA = "0x23931C0", Offset = "0x23932C1", VA = "0x23931C0")]
	public bool CheckCanMarriage_Event(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x0000CA38 File Offset: 0x0000AC38
	[Token(Token = "0x600197B")]
	[Address(RVA = "0x2393360", Offset = "0x2393461", VA = "0x2393360")]
	public int GetProposalEventId(int npcid)
	{
		return 0;
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x0000CA50 File Offset: 0x0000AC50
	[Token(Token = "0x600197C")]
	[Address(RVA = "0x23934F0", Offset = "0x23935F1", VA = "0x23934F0")]
	public int GetKokuhakuEventID(int npcId)
	{
		return 0;
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x0000CA68 File Offset: 0x0000AC68
	[Token(Token = "0x600197D")]
	[Address(RVA = "0x2393510", Offset = "0x2393611", VA = "0x2393510")]
	public int GetProposeEventID(int npcId)
	{
		return 0;
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x0000CA80 File Offset: 0x0000AC80
	[Token(Token = "0x600197E")]
	[Address(RVA = "0x2393530", Offset = "0x2393631", VA = "0x2393530")]
	public int GetLoveDateEventID(int npcId, int dateNum = 1)
	{
		return 0;
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x0000CA98 File Offset: 0x0000AC98
	[Token(Token = "0x600197F")]
	[Address(RVA = "0x2393340", Offset = "0x2393441", VA = "0x2393340")]
	public int GetPreMarriageEventID(int npcId)
	{
		return 0;
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001980")]
	[Address(RVA = "0x2393570", Offset = "0x2393671", VA = "0x2393570")]
	public void KeepNpcEventStep(int npcid, int eventid, int step)
	{
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001981")]
	[Address(RVA = "0x2393760", Offset = "0x2393861", VA = "0x2393760")]
	public void ReleaseNpcEventStep(int npcid, int eventid)
	{
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001982")]
	[Address(RVA = "0x2393770", Offset = "0x2393871", VA = "0x2393770")]
	public void ChangeSubEventStep(int id, int step, int day, int time, bool config)
	{
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001983")]
	[Address(RVA = "0x2393A50", Offset = "0x2393B51", VA = "0x2393A50")]
	public void CompleteSubEvent(int id, bool complete = true)
	{
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001984")]
	[Address(RVA = "0x2393DB0", Offset = "0x2393EB1", VA = "0x2393DB0")]
	private void DoCompleted(SubEventData data)
	{
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001985")]
	[Address(RVA = "0x2393E40", Offset = "0x2393F41", VA = "0x2393E40")]
	public void NpcJoinSubEventAdv(int npcid, int eventid, int step = -1)
	{
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x2394030", Offset = "0x2394131", VA = "0x2394030")]
	public void NpcLeaveSubEventAdv(int npcid, int eventid)
	{
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x2394210", Offset = "0x2394311", VA = "0x2394210")]
	public bool CanReservationDatingEvent(int npcid, SubEventType type = SubEventType.DatNormal)
	{
		return default(bool);
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x2394570", Offset = "0x2394671", VA = "0x2394570")]
	public void ReservationDatingEvent(int npcid, int eventid)
	{
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x23943F0", Offset = "0x23944F1", VA = "0x23943F0")]
	private bool CheckReserveDatingEvent(SubEventMasterDataBase data, int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x2394670", Offset = "0x2394771", VA = "0x2394670")]
	public int GetReservationDatingEventID(int npcId)
	{
		return 0;
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x2393DA0", Offset = "0x2393EA1", VA = "0x2393DA0")]
	public void ReleaseReservationDatingEvent(int EventId)
	{
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600198C")]
	[Address(RVA = "0x2394680", Offset = "0x2394781", VA = "0x2394680")]
	public ReservationEventParameter GetReservationDatingData(int npcId)
	{
		return null;
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198D")]
	[Address(RVA = "0x2394690", Offset = "0x2394791", VA = "0x2394690")]
	public void SetReservationDatingProgressByNpcId(int npcId, DatProgressType type)
	{
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198E")]
	[Address(RVA = "0x2393E30", Offset = "0x2393F31", VA = "0x2393E30")]
	public void SetReservationDatingProgressByEventId(int EventId, DatProgressType type)
	{
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x23946A0", Offset = "0x23947A1", VA = "0x23946A0")]
	public void LifeCycleLottery()
	{
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001990")]
	[Address(RVA = "0x2394700", Offset = "0x2394801", VA = "0x2394700")]
	public void DEBUG_AddOccurrenceSubEvent(int eventid)
	{
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001991")]
	[Address(RVA = "0x2394B10", Offset = "0x2394C11", VA = "0x2394B10")]
	public void DEBUG_CompleteOccurrenceSubEvent(int eventid)
	{
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001992")]
	[Address(RVA = "0x2394D20", Offset = "0x2394E21", VA = "0x2394D20")]
	public void DEBUG_ViewOccurrenceSubEventList()
	{
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x2394D30", Offset = "0x2394E31", VA = "0x2394D30")]
	public void DEBUG_ViewReservationList()
	{
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x2394D40", Offset = "0x2394E41", VA = "0x2394D40")]
	public void DEBUG_ClearOccurrenceSubEvent()
	{
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x2394DC0", Offset = "0x2394EC1", VA = "0x2394DC0")]
	public int GetSubEventDatasCount()
	{
		return 0;
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x0000CB10 File Offset: 0x0000AD10
	[Token(Token = "0x6001996")]
	[Address(RVA = "0x2394E10", Offset = "0x2394F11", VA = "0x2394E10")]
	public int GetSubEventIdByIndex(int idx)
	{
		return 0;
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001997")]
	[Address(RVA = "0x2394EF0", Offset = "0x2394FF1", VA = "0x2394EF0")]
	public string DEBUG_CheckOccurrenceSubEvent(int id)
	{
		return null;
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001998")]
	[Address(RVA = "0x2394F40", Offset = "0x2395041", VA = "0x2394F40")]
	public void DebugRunBirthChildScript(int npcid = -1, int type = -1)
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x2395020", Offset = "0x2395121", VA = "0x2395020")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19EAD0", Offset = "0x19EBD1")]
	private IEnumerator _DebugRunBirthChildScript(int npcid, int type)
	{
		return null;
	}

	// Token: 0x040062D7 RID: 25303
	[Token(Token = "0x4005DC0")]
	private const int GIVEBIRTH_BBY_ID_BASE = 1;

	// Token: 0x040062D8 RID: 25304
	[Token(Token = "0x4005DC1")]
	[FieldOffset(Offset = "0x10")]
	private List<SubEventMasterDataBase> SubEventDatas;

	// Token: 0x040062D9 RID: 25305
	[Token(Token = "0x4005DC2")]
	[FieldOffset(Offset = "0x18")]
	private List<SubEventData> OccurrenceSubEventDatas;

	// Token: 0x040062DA RID: 25306
	[Token(Token = "0x4005DC3")]
	[FieldOffset(Offset = "0x20")]
	private SystemAdvMain SubEventAdvMain;

	// Token: 0x040062DB RID: 25307
	[Token(Token = "0x4005DC4")]
	[FieldOffset(Offset = "0x28")]
	public GiveBirthController BirthController;

	// Token: 0x040062DC RID: 25308
	[Token(Token = "0x4005DC5")]
	[FieldOffset(Offset = "0x30")]
	public int LastOccurrenceTime;

	// Token: 0x040062DD RID: 25309
	[Token(Token = "0x4005DC6")]
	[FieldOffset(Offset = "0x34")]
	private int LastProceedAdvEventId;

	// Token: 0x040062DE RID: 25310
	[Token(Token = "0x4005DC7")]
	[FieldOffset(Offset = "0x38")]
	private bool IsRegistOnHourCarry;

	// Token: 0x040062DF RID: 25311
	[Token(Token = "0x4005DC8")]
	[FieldOffset(Offset = "0x39")]
	private bool IsRegistOnSecondCarry;

	// Token: 0x040062E0 RID: 25312
	[Token(Token = "0x4005DC9")]
	[FieldOffset(Offset = "0x3A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164D70", Offset = "0x164E71")]
	private bool <IsSelectDating>k__BackingField;

	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20010BD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A60", Offset = "0x157B61")]
	private sealed class <RunBirthChildScript>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D89 RID: 7561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDA")]
		[Address(RVA = "0x1FAA060", Offset = "0x1FAA161", VA = "0x1FAA060")]
		[DebuggerHidden]
		public <RunBirthChildScript>d__29(int <>1__state)
		{
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDB")]
		[Address(RVA = "0x1FAA090", Offset = "0x1FAA191", VA = "0x1FAA090", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6006EDC")]
		[Address(RVA = "0x1FAA0A0", Offset = "0x1FAA1A1", VA = "0x1FAA0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7B")]
		private object Current
		{
			[Token(Token = "0x6006EDD")]
			[Address(RVA = "0x1FAA390", Offset = "0x1FAA491", VA = "0x1FAA390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDE")]
		[Address(RVA = "0x1FAA3A0", Offset = "0x1FAA4A1", VA = "0x1FAA3A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7C")]
		private object Current
		{
			[Token(Token = "0x6006EDF")]
			[Address(RVA = "0x1FAA400", Offset = "0x1FAA501", VA = "0x1FAA400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040062E1 RID: 25313
		[Token(Token = "0x401918A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040062E2 RID: 25314
		[Token(Token = "0x401918B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040062E3 RID: 25315
		[Token(Token = "0x401918C")]
		[FieldOffset(Offset = "0x20")]
		public SubEventManager <>4__this;
	}

	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20010BE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157A70", Offset = "0x157B71")]
	private sealed class <_DebugRunBirthChildScript>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001D8F RID: 7567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE0")]
		[Address(RVA = "0x1FAA410", Offset = "0x1FAA511", VA = "0x1FAA410")]
		[DebuggerHidden]
		public <_DebugRunBirthChildScript>d__91(int <>1__state)
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE1")]
		[Address(RVA = "0x1FAA440", Offset = "0x1FAA541", VA = "0x1FAA440", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6006EE2")]
		[Address(RVA = "0x1FAA450", Offset = "0x1FAA551", VA = "0x1FAA450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7D")]
		private object Current
		{
			[Token(Token = "0x6006EE3")]
			[Address(RVA = "0x1FAA7D0", Offset = "0x1FAA8D1", VA = "0x1FAA7D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE4")]
		[Address(RVA = "0x1FAA7E0", Offset = "0x1FAA8E1", VA = "0x1FAA7E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7E")]
		private object Current
		{
			[Token(Token = "0x6006EE5")]
			[Address(RVA = "0x1FAA840", Offset = "0x1FAA941", VA = "0x1FAA840", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040062E4 RID: 25316
		[Token(Token = "0x401918D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040062E5 RID: 25317
		[Token(Token = "0x401918E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040062E6 RID: 25318
		[Token(Token = "0x401918F")]
		[FieldOffset(Offset = "0x20")]
		public SubEventManager <>4__this;

		// Token: 0x040062E7 RID: 25319
		[Token(Token = "0x4019190")]
		[FieldOffset(Offset = "0x28")]
		public int type;

		// Token: 0x040062E8 RID: 25320
		[Token(Token = "0x4019191")]
		[FieldOffset(Offset = "0x2C")]
		public int npcid;
	}
}
