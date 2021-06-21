using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000433 RID: 1075
[Token(Token = "0x200033D")]
public class EventFlagManager
{
	// Token: 0x06001A2D RID: 6701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x21F3870", Offset = "0x21F3971", VA = "0x21F3870")]
	public EventPointData GetEventPointData(EventPointID EventPointId)
	{
		return null;
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001750")]
	[Address(RVA = "0x21F3990", Offset = "0x21F3A91", VA = "0x21F3990")]
	public EventUnlockFlagData GetEventUnlockDataByPointOnFlag(GameFlagData pointOnFlag)
	{
		return null;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001751")]
	[Address(RVA = "0x21F3A70", Offset = "0x21F3B71", VA = "0x21F3A70")]
	public EventUnlockFlagData GetEventUnlockData(EventScriptID scriptId)
	{
		return null;
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001752")]
	[Address(RVA = "0x21F3B50", Offset = "0x21F3C51", VA = "0x21F3B50")]
	public EventUnlockFlagData GetNextEventUnlockData(EventScriptID scriptId)
	{
		return null;
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001753")]
	[Address(RVA = "0x21F3C50", Offset = "0x21F3D51", VA = "0x21F3C50")]
	public List<EventUnlockFlagData> GetActivePointData()
	{
		return null;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001754")]
	[Address(RVA = "0x21F3C60", Offset = "0x21F3D61", VA = "0x21F3C60")]
	public void Start()
	{
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001755")]
	[Address(RVA = "0x21F42F0", Offset = "0x21F43F1", VA = "0x21F42F0")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001756")]
	[Address(RVA = "0x21F4420", Offset = "0x21F4521", VA = "0x21F4420")]
	public void CheckTimeReset()
	{
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001757")]
	[Address(RVA = "0x21F4430", Offset = "0x21F4531", VA = "0x21F4430")]
	public void AllFlagReset()
	{
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001758")]
	[Address(RVA = "0x21F46E0", Offset = "0x21F47E1", VA = "0x21F46E0")]
	public void SaveEventStartPoints()
	{
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x21F4840", Offset = "0x21F4941", VA = "0x21F4840")]
	public void LoadEventStartPoints()
	{
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600175A")]
	[Address(RVA = "0x21F43F0", Offset = "0x21F44F1", VA = "0x21F43F0")]
	public void UpdateActivePointData()
	{
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600175B")]
	[Address(RVA = "0x21F4D20", Offset = "0x21F4E21", VA = "0x21F4D20")]
	private void UpdateEventPointActive()
	{
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600175C")]
	[Address(RVA = "0x21F52A0", Offset = "0x21F53A1", VA = "0x21F52A0")]
	private void EnableEventPoint(EventUnlockFlagData unlockData)
	{
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600175D")]
	[Address(RVA = "0x21F5140", Offset = "0x21F5241", VA = "0x21F5140")]
	private void DisableEventPoint(EventUnlockFlagData unlockData)
	{
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600175E")]
	[Address(RVA = "0x21F49A0", Offset = "0x21F4AA1", VA = "0x21F49A0")]
	private void CheckReserveEventEventPointList()
	{
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0000B5E0 File Offset: 0x000097E0
	[Token(Token = "0x600175F")]
	[Address(RVA = "0x21F5270", Offset = "0x21F5371", VA = "0x21F5270")]
	public bool CheckEventFlag(EventUnlockFlagData data)
	{
		return default(bool);
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0000B5F8 File Offset: 0x000097F8
	[Token(Token = "0x6001760")]
	[Address(RVA = "0x21F5780", Offset = "0x21F5881", VA = "0x21F5780")]
	public bool CheckEventFlag(EventUnlockFlagData data, out GameFlagData hitFlag)
	{
		return default(bool);
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x0000B610 File Offset: 0x00009810
	[Token(Token = "0x6001761")]
	[Address(RVA = "0x21F60F0", Offset = "0x21F61F1", VA = "0x21F60F0")]
	public bool CheckEventFlag(string scriptName)
	{
		return default(bool);
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x0000B628 File Offset: 0x00009828
	[Token(Token = "0x6001762")]
	[Address(RVA = "0x21F6290", Offset = "0x21F6391", VA = "0x21F6290")]
	public bool CheckEventFlagUnlock(GameFlagData flagId)
	{
		return default(bool);
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001763")]
	[Address(RVA = "0x21F6AF0", Offset = "0x21F6BF1", VA = "0x21F6AF0")]
	public void EventFlagOnOff(string scriptName)
	{
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x0000B640 File Offset: 0x00009840
	[Token(Token = "0x6001764")]
	[Address(RVA = "0x21F7290", Offset = "0x21F7391", VA = "0x21F7290")]
	private bool IsLoveStoryFlag(GameFlagData Flag)
	{
		return default(bool);
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001765")]
	[Address(RVA = "0x21F72A0", Offset = "0x21F73A1", VA = "0x21F72A0")]
	private void SetLoveStoryProgress(GameFlagData Flag)
	{
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001766")]
	[Address(RVA = "0x21F7560", Offset = "0x21F7661", VA = "0x21F7560")]
	public void ApplyFlagSetting(bool on, GameFlagData flagId)
	{
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001767")]
	[Address(RVA = "0x21F7AC0", Offset = "0x21F7BC1", VA = "0x21F7AC0")]
	private void NpcPartyOut(NPCID npcId)
	{
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001768")]
	[Address(RVA = "0x21F7FC0", Offset = "0x21F80C1", VA = "0x21F7FC0")]
	private void NpcPartyIn(NPCID npcId)
	{
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001769")]
	[Address(RVA = "0x21F8040", Offset = "0x21F8141", VA = "0x21F8040")]
	public void EventPointOnOff(bool on, GameFlagData flagId)
	{
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176A")]
	[Address(RVA = "0x21F8120", Offset = "0x21F8221", VA = "0x21F8120")]
	public void EventPointOnOff_Base(bool on, GameFlagData flagId)
	{
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176B")]
	[Address(RVA = "0x21F7D10", Offset = "0x21F7E11", VA = "0x21F7D10")]
	private void UpdateBossEventPoint(bool isOn, GameFlagData flagId)
	{
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x21F54B0", Offset = "0x21F55B1", VA = "0x21F54B0")]
	private void RegistActiveEventPointList(EventUnlockFlagData unlockData)
	{
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x21F8660", Offset = "0x21F8761", VA = "0x21F8660")]
	private void RemoveEventPointData(EventUnlockFlagData data)
	{
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x21F88A0", Offset = "0x21F89A1", VA = "0x21F88A0")]
	public void RemoveEventPointByPointOnFlag(GameFlagData pointOnFlag)
	{
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x0000B658 File Offset: 0x00009858
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x21F89E0", Offset = "0x21F8AE1", VA = "0x21F89E0")]
	public bool IsSameEventPointId(EventStartPoint eventStartPoint, EventUnlockFlagData eventPoint)
	{
		return default(bool);
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x0000B670 File Offset: 0x00009870
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x21F8A10", Offset = "0x21F8B11", VA = "0x21F8A10")]
	public bool IsSameScriptId(EventStartPoint eventStartPoint, EventUnlockFlagData eventPoint)
	{
		return default(bool);
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x0000B688 File Offset: 0x00009888
	[Token(Token = "0x6001771")]
	[Address(RVA = "0x21F8A40", Offset = "0x21F8B41", VA = "0x21F8A40")]
	public int GetEventFlagProgress(int npcid)
	{
		return 0;
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001772")]
	[Address(RVA = "0x21F8AC0", Offset = "0x21F8BC1", VA = "0x21F8AC0")]
	public void DEBUG_SetLoveStoryState(int idx, int state)
	{
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001773")]
	[Address(RVA = "0x21F8CA0", Offset = "0x21F8DA1", VA = "0x21F8CA0")]
	public void RequestDisableEventPoint(EventStartPoint eventStartPoint)
	{
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001774")]
	[Address(RVA = "0x21F8DA0", Offset = "0x21F8EA1", VA = "0x21F8DA0")]
	public void ExecuteDisableEventPoint()
	{
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x0000B6A0 File Offset: 0x000098A0
	[Token(Token = "0x6001775")]
	[Address(RVA = "0x21F90C0", Offset = "0x21F91C1", VA = "0x21F90C0")]
	public bool IsReqestedDisabled(EventStartPoint eventStartPoint)
	{
		return default(bool);
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x0000B6B8 File Offset: 0x000098B8
	[Token(Token = "0x6001776")]
	[Address(RVA = "0x21F91B0", Offset = "0x21F92B1", VA = "0x21F91B0")]
	public bool CheckCallTutorialScript(TutorialScriptType type)
	{
		return default(bool);
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001777")]
	[Address(RVA = "0x21F9C20", Offset = "0x21F9D21", VA = "0x21F9C20")]
	private void SetTutorialScriptCall(TutorialScriptType type, bool npcTalk = false)
	{
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001778")]
	[Address(RVA = "0x21F9DB0", Offset = "0x21F9EB1", VA = "0x21F9DB0")]
	public void LotterySubEventEventFlag()
	{
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001779")]
	[Address(RVA = "0x21FA220", Offset = "0x21FA321", VA = "0x21FA220")]
	public void SetEventFlagFromScriptDebug(string scriptName)
	{
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177A")]
	[Address(RVA = "0x21FA320", Offset = "0x21FA421", VA = "0x21FA320")]
	public void SetEventFlagFromDebug(GameFlagData SelectEventFlagId)
	{
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x0000B6D0 File Offset: 0x000098D0
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x21FAB40", Offset = "0x21FAC41", VA = "0x21FAB40")]
	public int GetCurrentMainScenarioProgress()
	{
		return 0;
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x21FABE0", Offset = "0x21FACE1", VA = "0x21FABE0")]
	public MainEventFlagProgressData GetCurrentMainScenarioData()
	{
		return null;
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600177D")]
	[Address(RVA = "0x21F4220", Offset = "0x21F4321", VA = "0x21F4220")]
	public void InitEventStartPoints()
	{
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600177E")]
	[Address(RVA = "0x21F53F0", Offset = "0x21F54F1", VA = "0x21F53F0")]
	public EventStartPoint GetEventStartPoint(EventPointID eventPointID)
	{
		return null;
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x21FAEF0", Offset = "0x21FAFF1", VA = "0x21FAEF0")]
	public EventStartPoint GetEventStartPoint(string name)
	{
		return null;
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x21F45E0", Offset = "0x21F46E1", VA = "0x21F45E0")]
	public void ResetAllEventStartPoint()
	{
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x0000B6E8 File Offset: 0x000098E8
	[Token(Token = "0x6001781")]
	[Address(RVA = "0x21FAFF0", Offset = "0x21FB0F1", VA = "0x21FAFF0")]
	public int GetStoryFlag(string scriptName)
	{
		return 0;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001782")]
	[Address(RVA = "0x21FB170", Offset = "0x21FB271", VA = "0x21FB170")]
	public EventFlagManager()
	{
	}

	// Token: 0x04005D2F RID: 23855
	[Token(Token = "0x4005974")]
	[FieldOffset(Offset = "0x10")]
	public EventUnlockFlag EventUnlockFlagDatas;

	// Token: 0x04005D30 RID: 23856
	[Token(Token = "0x4005975")]
	[FieldOffset(Offset = "0x18")]
	public EventPoint EventPointDatas;

	// Token: 0x04005D31 RID: 23857
	[Token(Token = "0x4005976")]
	[FieldOffset(Offset = "0x20")]
	public MainEventFlagProgress MainEventFlagProgressDatas;

	// Token: 0x04005D32 RID: 23858
	[Token(Token = "0x4005977")]
	[FieldOffset(Offset = "0x28")]
	public EventFlagProgress EventFlagProgressDatas;

	// Token: 0x04005D33 RID: 23859
	[Token(Token = "0x4005978")]
	[FieldOffset(Offset = "0x30")]
	public SubEventFlagProgress SubEventFlagProgressDatas;

	// Token: 0x04005D34 RID: 23860
	[Token(Token = "0x4005979")]
	[FieldOffset(Offset = "0x38")]
	public TutorialUnlockFlag TutorialUnlockFlagDatas;

	// Token: 0x04005D35 RID: 23861
	[Token(Token = "0x400597A")]
	[FieldOffset(Offset = "0x40")]
	public bool CheckPass;

	// Token: 0x04005D36 RID: 23862
	[Token(Token = "0x400597B")]
	[FieldOffset(Offset = "0x48")]
	public List<int> PointOnFlagList;

	// Token: 0x04005D37 RID: 23863
	[Token(Token = "0x400597C")]
	[FieldOffset(Offset = "0x50")]
	public List<int> StoryFlagList;

	// Token: 0x04005D38 RID: 23864
	[Token(Token = "0x400597D")]
	[FieldOffset(Offset = "0x58")]
	public List<int> DeleteFlagList;

	// Token: 0x04005D39 RID: 23865
	[Token(Token = "0x400597E")]
	[FieldOffset(Offset = "0x60")]
	public List<EventUnlockFlagData> activeEventStartPointList;

	// Token: 0x04005D3A RID: 23866
	[Token(Token = "0x400597F")]
	[FieldOffset(Offset = "0x68")]
	public List<EventUnlockFlagData> reserveEventPointList;

	// Token: 0x04005D3B RID: 23867
	[Token(Token = "0x4005980")]
	[FieldOffset(Offset = "0x70")]
	private List<EventFlagManager.RequestDisableEventPointData> ReqestDisableEventPointList;

	// Token: 0x04005D3C RID: 23868
	[Token(Token = "0x4005981")]
	[FieldOffset(Offset = "0x78")]
	private int BeforeCheckTime;

	// Token: 0x04005D3D RID: 23869
	[Token(Token = "0x4005982")]
	[FieldOffset(Offset = "0x80")]
	public EventStartPoint[] EventStartPoints;

	// Token: 0x04005D3E RID: 23870
	[Token(Token = "0x4005983")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string EventStartPointParentName;

	// Token: 0x04005D3F RID: 23871
	[Token(Token = "0x4005984")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<GameFlagData, NPCID> NpcOutingDic;

	// Token: 0x04005D40 RID: 23872
	[Token(Token = "0x4005985")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<GameFlagData, NPCID> NpcAutoPartnerDic;

	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x200107F")]
	private class RequestDisableEventPointData
	{
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x17000C2D")]
		public EventScriptID ScriptId
		{
			[Token(Token = "0x6006DC9")]
			[Address(RVA = "0x21FBA30", Offset = "0x21FBB31", VA = "0x21FBA30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0710", Offset = "0x1B0811")]
			get
			{
				return EventScriptID.None;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2E")]
		public EventStartPoint EventStartPoint
		{
			[Token(Token = "0x6006DCA")]
			[Address(RVA = "0x21FBA40", Offset = "0x21FBB41", VA = "0x21FBA40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0720", Offset = "0x1B0821")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0x21F8D50", Offset = "0x21F8E51", VA = "0x21F8D50")]
		public RequestDisableEventPointData(EventScriptID _scriptId, EventStartPoint _eventStartPoint)
		{
		}

		// Token: 0x04005D41 RID: 23873
		[Token(Token = "0x401902E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F60", Offset = "0x195061")]
		private readonly EventScriptID <ScriptId>k__BackingField;

		// Token: 0x04005D42 RID: 23874
		[Token(Token = "0x401902F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F70", Offset = "0x195071")]
		private readonly EventStartPoint <EventStartPoint>k__BackingField;
	}

	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2001080")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576E0", Offset = "0x1577E1")]
	private sealed class <>c__DisplayClass20_0
	{
		// Token: 0x06001A65 RID: 6757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0x21F3A60", Offset = "0x21F3B61", VA = "0x21F3A60")]
		public <>c__DisplayClass20_0()
		{
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0x21FB7F0", Offset = "0x21FB8F1", VA = "0x21FB7F0")]
		internal bool <GetEventUnlockDataByPointOnFlag>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D43 RID: 23875
		[Token(Token = "0x4019030")]
		[FieldOffset(Offset = "0x10")]
		public GameFlagData pointOnFlag;
	}

	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2001081")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576F0", Offset = "0x1577F1")]
	private sealed class <>c__DisplayClass21_0
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0x21F3B40", Offset = "0x21F3C41", VA = "0x21F3B40")]
		public <>c__DisplayClass21_0()
		{
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0x21FB820", Offset = "0x21FB921", VA = "0x21FB820")]
		internal bool <GetEventUnlockData>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D44 RID: 23876
		[Token(Token = "0x4019031")]
		[FieldOffset(Offset = "0x10")]
		public EventScriptID scriptId;
	}

	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2001082")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157700", Offset = "0x157801")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x06001A69 RID: 6761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0x21F3C40", Offset = "0x21F3D41", VA = "0x21F3C40")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x21FB850", Offset = "0x21FB951", VA = "0x21FB850")]
		internal bool <GetNextEventUnlockData>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D45 RID: 23877
		[Token(Token = "0x4019032")]
		[FieldOffset(Offset = "0x10")]
		public EventUnlockFlagData data;
	}

	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2001083")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157710", Offset = "0x157811")]
	private sealed class <>c__DisplayClass46_0
	{
		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0x21F8650", Offset = "0x21F8751", VA = "0x21F8650")]
		public <>c__DisplayClass46_0()
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x6006DD3")]
		[Address(RVA = "0x21FB880", Offset = "0x21FB981", VA = "0x21FB880")]
		internal bool <EventPointOnOff_Base>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D46 RID: 23878
		[Token(Token = "0x4019033")]
		[FieldOffset(Offset = "0x10")]
		public EventUnlockFlagData data;
	}

	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2001084")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157720", Offset = "0x157821")]
	private sealed class <>c__DisplayClass48_0
	{
		// Token: 0x06001A6D RID: 6765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD4")]
		[Address(RVA = "0x21F8880", Offset = "0x21F8981", VA = "0x21F8880")]
		public <>c__DisplayClass48_0()
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0x21FB8B0", Offset = "0x21FB9B1", VA = "0x21FB8B0")]
		internal bool <RegistActiveEventPointList>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D47 RID: 23879
		[Token(Token = "0x4019034")]
		[FieldOffset(Offset = "0x10")]
		public EventUnlockFlagData unlockData;
	}

	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x2001085")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157730", Offset = "0x157831")]
	private sealed class <>c__DisplayClass49_0
	{
		// Token: 0x06001A6F RID: 6767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD6")]
		[Address(RVA = "0x21F8890", Offset = "0x21F8991", VA = "0x21F8890")]
		public <>c__DisplayClass49_0()
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6006DD7")]
		[Address(RVA = "0x21FB8E0", Offset = "0x21FB9E1", VA = "0x21FB8E0")]
		internal bool <RemoveEventPointData>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6006DD8")]
		[Address(RVA = "0x21FB910", Offset = "0x21FBA11", VA = "0x21FB910")]
		internal bool <RemoveEventPointData>b__1(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D48 RID: 23880
		[Token(Token = "0x4019035")]
		[FieldOffset(Offset = "0x10")]
		public EventUnlockFlagData data;
	}

	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x2001086")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157740", Offset = "0x157841")]
	private sealed class <>c__DisplayClass50_0
	{
		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD9")]
		[Address(RVA = "0x21F89D0", Offset = "0x21F8AD1", VA = "0x21F89D0")]
		public <>c__DisplayClass50_0()
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6006DDA")]
		[Address(RVA = "0x21FB940", Offset = "0x21FBA41", VA = "0x21FB940")]
		internal bool <RemoveEventPointByPointOnFlag>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0x21FB970", Offset = "0x21FBA71", VA = "0x21FB970")]
		internal bool <RemoveEventPointByPointOnFlag>b__1(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D49 RID: 23881
		[Token(Token = "0x4019036")]
		[FieldOffset(Offset = "0x10")]
		public GameFlagData pointOnFlag;
	}

	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x2001087")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157750", Offset = "0x157851")]
	private sealed class <>c__DisplayClass56_0
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0x21F90B0", Offset = "0x21F91B1", VA = "0x21F90B0")]
		public <>c__DisplayClass56_0()
		{
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0x21FB9A0", Offset = "0x21FBAA1", VA = "0x21FB9A0")]
		internal bool <ExecuteDisableEventPoint>b__0(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6006DDE")]
		[Address(RVA = "0x21FB9D0", Offset = "0x21FBAD1", VA = "0x21FB9D0")]
		internal bool <ExecuteDisableEventPoint>b__1(EventUnlockFlagData x)
		{
			return default(bool);
		}

		// Token: 0x04005D4A RID: 23882
		[Token(Token = "0x4019037")]
		[FieldOffset(Offset = "0x10")]
		public EventFlagManager.RequestDisableEventPointData data;
	}

	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x2001088")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157760", Offset = "0x157861")]
	private sealed class <>c__DisplayClass57_0
	{
		// Token: 0x06001A78 RID: 6776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0x21F91A0", Offset = "0x21F92A1", VA = "0x21F91A0")]
		public <>c__DisplayClass57_0()
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0x21FBA00", Offset = "0x21FBB01", VA = "0x21FBA00")]
		internal bool <IsReqestedDisabled>b__0(EventFlagManager.RequestDisableEventPointData x)
		{
			return default(bool);
		}

		// Token: 0x04005D4B RID: 23883
		[Token(Token = "0x4019038")]
		[FieldOffset(Offset = "0x10")]
		public EventStartPoint eventStartPoint;
	}
}
