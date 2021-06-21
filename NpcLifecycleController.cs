using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x02000808 RID: 2056
[Token(Token = "0x200054E")]
public class NpcLifecycleController : SingletonMonoBehaviour<NpcLifecycleController>
{
	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x060036C4 RID: 14020 RVA: 0x00012E40 File Offset: 0x00011040
	[Token(Token = "0x170005F6")]
	private bool IsWakeupTime
	{
		[Token(Token = "0x6002D8C")]
		[Address(RVA = "0x1F481B0", Offset = "0x1F482B1", VA = "0x1F481B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x1F48240", Offset = "0x1F48341", VA = "0x1F48240")]
	public NpcData GetNpcData(int NpcId)
	{
		return null;
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x1F48300", Offset = "0x1F48401", VA = "0x1F48300")]
	public NpcController GetNpc(int NpcId)
	{
		return null;
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x00012E58 File Offset: 0x00011058
	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x1F48420", Offset = "0x1F48521", VA = "0x1F48420")]
	public int GetHour()
	{
		return 0;
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x00012E70 File Offset: 0x00011070
	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x1F48430", Offset = "0x1F48531", VA = "0x1F48430")]
	public int GetMinutes()
	{
		return 0;
	}

	// Token: 0x060036C9 RID: 14025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x1F48440", Offset = "0x1F48541", VA = "0x1F48440")]
	public void RemoveNpcs()
	{
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D92")]
	[Address(RVA = "0x1F48450", Offset = "0x1F48551", VA = "0x1F48450")]
	public void AddNpc(NpcController addnpc)
	{
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D93")]
	[Address(RVA = "0x1F485D0", Offset = "0x1F486D1", VA = "0x1F485D0")]
	public void RemoveNpc(NpcController removeNpc)
	{
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x00012E88 File Offset: 0x00011088
	[Token(Token = "0x6002D94")]
	[Address(RVA = "0x1F48640", Offset = "0x1F48741", VA = "0x1F48640")]
	public bool IsExistNpc(int NpcId)
	{
		return default(bool);
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D95")]
	[Address(RVA = "0x1F48650", Offset = "0x1F48751", VA = "0x1F48650")]
	private void RegistOnDayCarry()
	{
	}

	// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D96")]
	[Address(RVA = "0x1F48760", Offset = "0x1F48861", VA = "0x1F48760")]
	private void WakeUpUpdate(int diffDay)
	{
	}

	// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D97")]
	[Address(RVA = "0x1F48AD0", Offset = "0x1F48BD1", VA = "0x1F48AD0")]
	public void SetLifeCyclePause(bool pause)
	{
	}

	// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D98")]
	[Address(RVA = "0x1F48AE0", Offset = "0x1F48BE1", VA = "0x1F48AE0")]
	protected void OnLoadAsync()
	{
	}

	// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D99")]
	[Address(RVA = "0x1F49650", Offset = "0x1F49751", VA = "0x1F49650", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D9A")]
	[Address(RVA = "0x1F49720", Offset = "0x1F49821", VA = "0x1F49720")]
	public void Update()
	{
	}

	// Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D9B")]
	[Address(RVA = "0x1F49B20", Offset = "0x1F49C21", VA = "0x1F49B20")]
	private void UpdateDeleteModel()
	{
	}

	// Token: 0x060036D4 RID: 14036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D9C")]
	[Address(RVA = "0x1F4B530", Offset = "0x1F4B631", VA = "0x1F4B530")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D9D")]
	[Address(RVA = "0x1F4BB60", Offset = "0x1F4BC61", VA = "0x1F4BB60")]
	public void RefreshAreaPoints()
	{
	}

	// Token: 0x060036D6 RID: 14038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D9E")]
	[Address(RVA = "0x1F4BAD0", Offset = "0x1F4BBD1", VA = "0x1F4BAD0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5A70", Offset = "0x1A5B71")]
	public IEnumerator PlayNewYearVoice(int playedIdx)
	{
		return null;
	}

	// Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D9F")]
	[Address(RVA = "0x1F4A9E0", Offset = "0x1F4AAE1", VA = "0x1F4A9E0")]
	public void SimulateNpcSchedules()
	{
	}

	// Token: 0x060036D8 RID: 14040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA0")]
	[Address(RVA = "0x1F4BE10", Offset = "0x1F4BF11", VA = "0x1F4BE10")]
	private void SimulateAction(NpcData npcData)
	{
	}

	// Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x1F4C3F0", Offset = "0x1F4C4F1", VA = "0x1F4C3F0")]
	private void SimulateArrive(NpcData npcData)
	{
	}

	// Token: 0x060036DA RID: 14042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x1F4C540", Offset = "0x1F4C641", VA = "0x1F4C540")]
	private void SimulateNextAction(NpcData npcData)
	{
	}

	// Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x1F4BFB0", Offset = "0x1F4C0B1", VA = "0x1F4BFB0")]
	public void SimulateArrivePoint(NpcData npcData)
	{
	}

	// Token: 0x060036DC RID: 14044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x1F4C970", Offset = "0x1F4CA71", VA = "0x1F4C970")]
	private NpcTimeAction CreateNpcTimeAction(NpcData npcData)
	{
		return null;
	}

	// Token: 0x060036DD RID: 14045 RVA: 0x00012EA0 File Offset: 0x000110A0
	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x1F4D320", Offset = "0x1F4D421", VA = "0x1F4D320")]
	public bool DeteriorationWeather()
	{
		return default(bool);
	}

	// Token: 0x060036DE RID: 14046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x1F48AB0", Offset = "0x1F48BB1", VA = "0x1F48AB0")]
	public void UpdateSimulatePositionFromTimeShiftStart(bool forceUpdate = false, bool IsChangeTime = false)
	{
	}

	// Token: 0x060036DF RID: 14047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x1F4A870", Offset = "0x1F4A971", VA = "0x1F4A870")]
	private void DoSimulate(bool IsChangeTime = false)
	{
	}

	// Token: 0x060036E0 RID: 14048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x1F4A3C0", Offset = "0x1F4A4C1", VA = "0x1F4A3C0")]
	private void UpdateSimulatePositionFromTimeShift()
	{
	}

	// Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x1F4D3B0", Offset = "0x1F4D4B1", VA = "0x1F4D3B0")]
	public void UpdateWear()
	{
	}

	// Token: 0x060036E2 RID: 14050 RVA: 0x00012EB8 File Offset: 0x000110B8
	[Token(Token = "0x6002DAA")]
	[Address(RVA = "0x1F4D4C0", Offset = "0x1F4D5C1", VA = "0x1F4D4C0")]
	public bool IsLucusContisionsToWearGlasses()
	{
		return default(bool);
	}

	// Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DAB")]
	[Address(RVA = "0x1F4AEA0", Offset = "0x1F4AFA1", VA = "0x1F4AEA0")]
	public void UpdateSimulatePosition()
	{
	}

	// Token: 0x060036E4 RID: 14052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x1F4E540", Offset = "0x1F4E641", VA = "0x1F4E540")]
	public void UpdateSimulatePosition(int NpcId)
	{
	}

	// Token: 0x060036E5 RID: 14053 RVA: 0x00012ED0 File Offset: 0x000110D0
	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x1F4D640", Offset = "0x1F4D741", VA = "0x1F4D640")]
	public Vector3 GetSimulatePosition(int NpcId)
	{
		return default(Vector3);
	}

	// Token: 0x060036E6 RID: 14054 RVA: 0x00012EE8 File Offset: 0x000110E8
	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x1F4E720", Offset = "0x1F4E821", VA = "0x1F4E720")]
	public Vector3 GetSimulatePositionFromXls(int NpcId)
	{
		return default(Vector3);
	}

	// Token: 0x060036E7 RID: 14055 RVA: 0x00012F00 File Offset: 0x00011100
	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x1F4EF70", Offset = "0x1F4F071", VA = "0x1F4EF70")]
	private LifecycleState GetSimulateState(int NpcId)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060036E8 RID: 14056 RVA: 0x00012F18 File Offset: 0x00011118
	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x1F4F0E0", Offset = "0x1F4F1E1", VA = "0x1F4F0E0")]
	public LifecycleState GetNpcState(int NpcId)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x1F4F0F0", Offset = "0x1F4F1F1", VA = "0x1F4F0F0")]
	public void ByePartnerAction(NpcData npcData)
	{
	}

	// Token: 0x060036EA RID: 14058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x1F49E80", Offset = "0x1F49F81", VA = "0x1F49E80")]
	private void UpdatingObjectDisabled()
	{
	}

	// Token: 0x060036EB RID: 14059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x1F4B410", Offset = "0x1F4B511", VA = "0x1F4B410")]
	private void UpdatingObjectEnabled()
	{
	}

	// Token: 0x060036EC RID: 14060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x1F4F220", Offset = "0x1F4F321", VA = "0x1F4F220")]
	private void UpdatingObjectEnabled(NpcController npc)
	{
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x1F4CF00", Offset = "0x1F4D001", VA = "0x1F4CF00")]
	private string[] DecideRouteToNextTargetPoint(NpcData npcData, Place currentPlace, Place targetPlace, NpcPatrolPoint target)
	{
		return null;
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x1F4CB90", Offset = "0x1F4CC91", VA = "0x1F4CB90")]
	public void SetNextPlacePatrolPoints(NpcData npcData, Place nextPlace, NpcPatrolPoint nextPoint)
	{
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x00012F30 File Offset: 0x00011130
	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x1F4F640", Offset = "0x1F4F741", VA = "0x1F4F640")]
	public bool CheckWeatherRain()
	{
		return default(bool);
	}

	// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002DB8")]
	[Address(RVA = "0x1F4F6B0", Offset = "0x1F4F7B1", VA = "0x1F4F6B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5AE0", Offset = "0x1A5BE1")]
	public IEnumerator StayingMotion(NpcData npcData, NpcAnimState AnimState, float StayingSec, float StayingMotionSec)
	{
		return null;
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x00012F48 File Offset: 0x00011148
	[Token(Token = "0x6002DB9")]
	[Address(RVA = "0x1F4F7A0", Offset = "0x1F4F8A1", VA = "0x1F4F7A0")]
	public float DistanceXZ(Vector3 src, Vector3 dst)
	{
		return 0f;
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x00012F60 File Offset: 0x00011160
	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x1F4F850", Offset = "0x1F4F951", VA = "0x1F4F850")]
	public bool IsFieldMap(Place place)
	{
		return default(bool);
	}

	// Token: 0x060036F3 RID: 14067 RVA: 0x00012F78 File Offset: 0x00011178
	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x1F4F890", Offset = "0x1F4F991", VA = "0x1F4F890")]
	public bool IsOutdoor(Place place)
	{
		return default(bool);
	}

	// Token: 0x060036F4 RID: 14068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x1F4F8C0", Offset = "0x1F4F9C1", VA = "0x1F4F8C0")]
	public void ChangeActiveSelf_AllNpc(bool active)
	{
	}

	// Token: 0x060036F5 RID: 14069 RVA: 0x00012F90 File Offset: 0x00011190
	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x1F49220", Offset = "0x1F49321", VA = "0x1F49220")]
	public bool AllNpcStanby()
	{
		return default(bool);
	}

	// Token: 0x060036F6 RID: 14070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x1F49640", Offset = "0x1F49741", VA = "0x1F49640")]
	public void CreateMobs()
	{
	}

	// Token: 0x060036F7 RID: 14071 RVA: 0x00012FA8 File Offset: 0x000111A8
	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x1F4FCA0", Offset = "0x1F4FDA1", VA = "0x1F4FCA0")]
	public bool IsMobActive(Actor act)
	{
		return default(bool);
	}

	// Token: 0x060036F8 RID: 14072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x1F4A3A0", Offset = "0x1F4A4A1", VA = "0x1F4A3A0")]
	public void DispMobs()
	{
	}

	// Token: 0x060036F9 RID: 14073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x1F4FCD0", Offset = "0x1F4FDD1", VA = "0x1F4FCD0")]
	public NpcLifecycleController()
	{
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x1F4FED0", Offset = "0x1F4FFD1", VA = "0x1F4FED0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5B50", Offset = "0x1A5C51")]
	private void <OnLoadAsync>b__59_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x040079DA RID: 31194
	[Token(Token = "0x4006E69")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int[] DebugTargetNpcIds;

	// Token: 0x040079DB RID: 31195
	[Token(Token = "0x4006E6A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool Debug_UseNavMesh;

	// Token: 0x040079DC RID: 31196
	[Token(Token = "0x4006E6B")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool Debug_UseRoomNavMesh;

	// Token: 0x040079DD RID: 31197
	[Token(Token = "0x4006E6C")]
	[FieldOffset(Offset = "0x22")]
	public bool LifeCyclePause;

	// Token: 0x040079DE RID: 31198
	[Token(Token = "0x4006E6D")]
	[FieldOffset(Offset = "0x23")]
	public bool LifeCycleActive;

	// Token: 0x040079DF RID: 31199
	[Token(Token = "0x4006E6E")]
	[FieldOffset(Offset = "0x24")]
	public NpcLoadState IsNpcLoading;

	// Token: 0x040079E0 RID: 31200
	[Token(Token = "0x4006E6F")]
	[FieldOffset(Offset = "0x28")]
	public bool Debug_DrawNavMesh;

	// Token: 0x040079E1 RID: 31201
	[Token(Token = "0x4006E70")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int RotateRouteMaxNpcNum;

	// Token: 0x040079E2 RID: 31202
	[Token(Token = "0x4006E71")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float ForceWalkSpeed;

	// Token: 0x040079E3 RID: 31203
	[Token(Token = "0x4006E72")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<NpcController> NpcList;

	// Token: 0x040079E4 RID: 31204
	[Token(Token = "0x4006E73")]
	[FieldOffset(Offset = "0x40")]
	private int hour;

	// Token: 0x040079E5 RID: 31205
	[Token(Token = "0x4006E74")]
	[FieldOffset(Offset = "0x44")]
	private int minutes;

	// Token: 0x040079E6 RID: 31206
	[Token(Token = "0x4006E75")]
	[FieldOffset(Offset = "0x48")]
	private int prev_hour;

	// Token: 0x040079E7 RID: 31207
	[Token(Token = "0x4006E76")]
	[FieldOffset(Offset = "0x4C")]
	private int prev_minutes;

	// Token: 0x040079E8 RID: 31208
	[Token(Token = "0x4006E77")]
	[FieldOffset(Offset = "0x50")]
	public int ElapsedTime;

	// Token: 0x040079E9 RID: 31209
	[Token(Token = "0x4006E78")]
	[FieldOffset(Offset = "0x58")]
	public GameObject npcPatrolPoints;

	// Token: 0x040079EA RID: 31210
	[Token(Token = "0x4006E79")]
	[FieldOffset(Offset = "0x60")]
	public bool IsDecidedNpcSchedule;

	// Token: 0x040079EB RID: 31211
	[Token(Token = "0x4006E7A")]
	[FieldOffset(Offset = "0x61")]
	public bool IsLotteryReStart;

	// Token: 0x040079EC RID: 31212
	[Token(Token = "0x4006E7B")]
	[FieldOffset(Offset = "0x62")]
	public bool IsUpdateSimulatePosition;

	// Token: 0x040079ED RID: 31213
	[Token(Token = "0x4006E7C")]
	[FieldOffset(Offset = "0x63")]
	public bool IsFirstUpdateNpcs;

	// Token: 0x040079EE RID: 31214
	[Token(Token = "0x4006E7D")]
	private const int EnabledSqrMagnitude = 9216;

	// Token: 0x040079EF RID: 31215
	[Token(Token = "0x4006E7E")]
	private const float EnabledViewportPointZ = 32f;

	// Token: 0x040079F0 RID: 31216
	[Token(Token = "0x4006E7F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Rect ViewportRect;

	// Token: 0x040079F1 RID: 31217
	[Token(Token = "0x4006E80")]
	[FieldOffset(Offset = "0x64")]
	private int PrevLifeCycleEventId;

	// Token: 0x040079F2 RID: 31218
	[Token(Token = "0x4006E81")]
	[FieldOffset(Offset = "0x68")]
	private int CurrentLifeCycleEventId;

	// Token: 0x040079F3 RID: 31219
	[Token(Token = "0x4006E82")]
	[FieldOffset(Offset = "0x6C")]
	public int SimulateDay;

	// Token: 0x040079F4 RID: 31220
	[Token(Token = "0x4006E83")]
	[FieldOffset(Offset = "0x70")]
	public int NextSimulateDay;

	// Token: 0x040079F5 RID: 31221
	[Token(Token = "0x4006E84")]
	[FieldOffset(Offset = "0x74")]
	public Weather SimulateWeather;

	// Token: 0x040079F6 RID: 31222
	[Token(Token = "0x4006E85")]
	[FieldOffset(Offset = "0x78")]
	private bool IsStandbyPatrolPoints;

	// Token: 0x040079F7 RID: 31223
	[Token(Token = "0x4006E86")]
	[FieldOffset(Offset = "0x79")]
	private bool IsStandbyNpcDatas;

	// Token: 0x040079F8 RID: 31224
	[Token(Token = "0x4006E87")]
	[FieldOffset(Offset = "0x7A")]
	private bool IsStandbyNpcs;

	// Token: 0x040079F9 RID: 31225
	[Token(Token = "0x4006E88")]
	[FieldOffset(Offset = "0x7B")]
	public bool IsStandbyAllNpcs;

	// Token: 0x040079FA RID: 31226
	[Token(Token = "0x4006E89")]
	[FieldOffset(Offset = "0x7C")]
	public bool IsDestroyAllNpcs;

	// Token: 0x040079FB RID: 31227
	[Token(Token = "0x4006E8A")]
	[FieldOffset(Offset = "0x7D")]
	public bool IsCreatedMobs;

	// Token: 0x040079FC RID: 31228
	[Token(Token = "0x4006E8B")]
	[FieldOffset(Offset = "0x7E")]
	public bool IsStandbyMobs;

	// Token: 0x040079FD RID: 31229
	[Token(Token = "0x4006E8C")]
	[FieldOffset(Offset = "0x7F")]
	public bool IsNotCreatedMobs;

	// Token: 0x040079FE RID: 31230
	[Token(Token = "0x4006E8D")]
	[FieldOffset(Offset = "0x80")]
	private Actor[] mobActor;

	// Token: 0x040079FF RID: 31231
	[Token(Token = "0x4006E8E")]
	[FieldOffset(Offset = "0x88")]
	private List<int> NewYearVoceActorIdList;

	// Token: 0x04007A00 RID: 31232
	[Token(Token = "0x4006E8F")]
	[FieldOffset(Offset = "0x90")]
	private bool IsChangeLifeCycle;

	// Token: 0x04007A01 RID: 31233
	[Token(Token = "0x4006E90")]
	[FieldOffset(Offset = "0x98")]
	protected AnimationCurve m_RotateSpeedCurve;

	// Token: 0x04007A02 RID: 31234
	[Token(Token = "0x4006E91")]
	[FieldOffset(Offset = "0xA0")]
	private bool IsRegistOnDayCarry;

	// Token: 0x04007A03 RID: 31235
	[Token(Token = "0x4006E92")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ShortPlayItems;

	// Token: 0x04007A04 RID: 31236
	[Token(Token = "0x4006E93")]
	[FieldOffset(Offset = "0xB0")]
	private bool IsNewYear;

	// Token: 0x04007A05 RID: 31237
	[Token(Token = "0x4006E94")]
	[FieldOffset(Offset = "0xB1")]
	private bool IsReservedSimulate;

	// Token: 0x04007A06 RID: 31238
	[Token(Token = "0x4006E95")]
	[FieldOffset(Offset = "0xB8")]
	private List<int> deleteNpcIDList;

	// Token: 0x04007A07 RID: 31239
	[Token(Token = "0x4006E96")]
	[FieldOffset(Offset = "0xC0")]
	private List<int> removeList;

	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x200123F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BF0", Offset = "0x158CF1")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x060036FC RID: 14076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007421")]
		[Address(RVA = "0x1F49210", Offset = "0x1F49311", VA = "0x1F49210")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007422")]
		[Address(RVA = "0x1F50070", Offset = "0x1F50171", VA = "0x1F50070")]
		internal void <OnLoadAsync>b__1(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04007A08 RID: 31240
		[Token(Token = "0x40197D6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject NpcDatas;

		// Token: 0x04007A09 RID: 31241
		[Token(Token = "0x40197D7")]
		[FieldOffset(Offset = "0x18")]
		public NpcLifecycleController <>4__this;
	}

	// Token: 0x0200080A RID: 2058
	[Token(Token = "0x2001240")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C00", Offset = "0x158D01")]
	private sealed class <PlayNewYearVoice>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007423")]
		[Address(RVA = "0x1F4BDE0", Offset = "0x1F4BEE1", VA = "0x1F4BDE0")]
		[DebuggerHidden]
		public <PlayNewYearVoice>d__65(int <>1__state)
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007424")]
		[Address(RVA = "0x1F501E0", Offset = "0x1F502E1", VA = "0x1F501E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x6007425")]
		[Address(RVA = "0x1F501F0", Offset = "0x1F502F1", VA = "0x1F501F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D70")]
		private object Current
		{
			[Token(Token = "0x6007426")]
			[Address(RVA = "0x1F50460", Offset = "0x1F50561", VA = "0x1F50460", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007427")]
		[Address(RVA = "0x1F50470", Offset = "0x1F50571", VA = "0x1F50470", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D71")]
		private object Current
		{
			[Token(Token = "0x6007428")]
			[Address(RVA = "0x1F504D0", Offset = "0x1F505D1", VA = "0x1F504D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007A0A RID: 31242
		[Token(Token = "0x40197D8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007A0B RID: 31243
		[Token(Token = "0x40197D9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007A0C RID: 31244
		[Token(Token = "0x40197DA")]
		[FieldOffset(Offset = "0x20")]
		public NpcLifecycleController <>4__this;

		// Token: 0x04007A0D RID: 31245
		[Token(Token = "0x40197DB")]
		[FieldOffset(Offset = "0x28")]
		public int playedIdx;
	}

	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x2001241")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C10", Offset = "0x158D11")]
	private sealed class <StayingMotion>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007429")]
		[Address(RVA = "0x1F4F770", Offset = "0x1F4F871", VA = "0x1F4F770")]
		[DebuggerHidden]
		public <StayingMotion>d__91(int <>1__state)
		{
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742A")]
		[Address(RVA = "0x1F504E0", Offset = "0x1F505E1", VA = "0x1F504E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x600742B")]
		[Address(RVA = "0x1F504F0", Offset = "0x1F505F1", VA = "0x1F504F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D72")]
		private object Current
		{
			[Token(Token = "0x600742C")]
			[Address(RVA = "0x1F506C0", Offset = "0x1F507C1", VA = "0x1F506C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742D")]
		[Address(RVA = "0x1F506D0", Offset = "0x1F507D1", VA = "0x1F506D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D73")]
		private object Current
		{
			[Token(Token = "0x600742E")]
			[Address(RVA = "0x1F50730", Offset = "0x1F50831", VA = "0x1F50730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007A0E RID: 31246
		[Token(Token = "0x40197DC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007A0F RID: 31247
		[Token(Token = "0x40197DD")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007A10 RID: 31248
		[Token(Token = "0x40197DE")]
		[FieldOffset(Offset = "0x20")]
		public NpcData npcData;

		// Token: 0x04007A11 RID: 31249
		[Token(Token = "0x40197DF")]
		[FieldOffset(Offset = "0x28")]
		public float StayingSec;

		// Token: 0x04007A12 RID: 31250
		[Token(Token = "0x40197E0")]
		[FieldOffset(Offset = "0x30")]
		public NpcLifecycleController <>4__this;

		// Token: 0x04007A13 RID: 31251
		[Token(Token = "0x40197E1")]
		[FieldOffset(Offset = "0x38")]
		public NpcAnimState AnimState;

		// Token: 0x04007A14 RID: 31252
		[Token(Token = "0x40197E2")]
		[FieldOffset(Offset = "0x3C")]
		public float StayingMotionSec;
	}
}
