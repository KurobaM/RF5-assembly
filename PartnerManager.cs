using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x02000828 RID: 2088
[Token(Token = "0x2000564")]
public class PartnerManager : SingletonMonoBehaviour<PartnerManager>
{
	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x060037AF RID: 14255 RVA: 0x000132A8 File Offset: 0x000114A8
	[Token(Token = "0x17000606")]
	public Vector3 PlayerPosition
	{
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x2320AC0", Offset = "0x2320BC1", VA = "0x2320AC0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170007BE RID: 1982
	// (get) Token: 0x060037B0 RID: 14256 RVA: 0x000132C0 File Offset: 0x000114C0
	[Token(Token = "0x17000607")]
	public Vector3 PlayerForward
	{
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x2320BE0", Offset = "0x2320CE1", VA = "0x2320BE0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x060037B1 RID: 14257 RVA: 0x000132D8 File Offset: 0x000114D8
	[Token(Token = "0x17000608")]
	public Vector3 PlayerBack
	{
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x2320D00", Offset = "0x2320E01", VA = "0x2320D00")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x060037B2 RID: 14258 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060037B3 RID: 14259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000609")]
	public List<AIInput> PartnerList
	{
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x2320DA0", Offset = "0x2320EA1", VA = "0x2320DA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BE0", Offset = "0x1A5CE1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x2320DB0", Offset = "0x2320EB1", VA = "0x2320DB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BF0", Offset = "0x1A5CF1")]
		private set
		{
		}
	}

	// Token: 0x060037B4 RID: 14260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x2320DC0", Offset = "0x2320EC1", VA = "0x2320DC0")]
	public void Debug_ChangePlayerDistanceList(PartnerMovementOrderType type, float distance)
	{
	}

	// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6A")]
	[Address(RVA = "0x2320E40", Offset = "0x2320F41", VA = "0x2320E40")]
	public void Debug_ChangeBehaviorInterval(float time)
	{
	}

	// Token: 0x060037B6 RID: 14262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x2320E50", Offset = "0x2320F51", VA = "0x2320E50")]
	public void Debug_ChangeWalkMargin(float margin)
	{
	}

	// Token: 0x060037B7 RID: 14263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x2320E60", Offset = "0x2320F61", VA = "0x2320E60")]
	private void SetupPartnerList()
	{
	}

	// Token: 0x060037B8 RID: 14264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6D")]
	[Address(RVA = "0x2320EC0", Offset = "0x2320FC1", VA = "0x2320EC0")]
	public void OnAfterGameDataLoad()
	{
	}

	// Token: 0x060037B9 RID: 14265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x2320FC0", Offset = "0x23210C1", VA = "0x2320FC0")]
	public void ExcuteFriendMonsterActionScript()
	{
	}

	// Token: 0x060037BA RID: 14266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E6F")]
	[Address(RVA = "0x2321300", Offset = "0x2321401", VA = "0x2321300", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x2321420", Offset = "0x2321521", VA = "0x2321420")]
	public void AddPartner(AIInput input)
	{
	}

	// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x2321540", Offset = "0x2321641", VA = "0x2321540")]
	private void SetNavMeshAgentPriority(Character character)
	{
	}

	// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x2321630", Offset = "0x2321731", VA = "0x2321630")]
	public void RemovePartner(AIInput input)
	{
	}

	// Token: 0x060037BE RID: 14270 RVA: 0x000132F0 File Offset: 0x000114F0
	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x2321740", Offset = "0x2321841", VA = "0x2321740")]
	public bool IsPartyCompleted()
	{
		return default(bool);
	}

	// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E74")]
	[Address(RVA = "0x2320F60", Offset = "0x2321061", VA = "0x2320F60")]
	private void ResetParameterList()
	{
	}

	// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x23217C0", Offset = "0x23218C1", VA = "0x23217C0")]
	private void SetDisplayAIInput(AIInput aIInput, bool isDisplay, bool isWarpTransformPosition = false)
	{
	}

	// Token: 0x060037C1 RID: 14273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x2321D10", Offset = "0x2321E11", VA = "0x2321D10")]
	public void SetDisplayAll(bool isDisplay, bool isWarpTransformPosition = false)
	{
	}

	// Token: 0x060037C2 RID: 14274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x2321EB0", Offset = "0x2321FB1", VA = "0x2321EB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5C00", Offset = "0x1A5D01")]
	private IEnumerator AsyncAddFriendMonster(ActorID actorId, MonsterStatusBase monsterStatus, [Optional] Action<MonsterBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x060037C3 RID: 14275 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700060A")]
	public List<PartnerManager.NPCChangeBaseParameter> NPCChangeBaseParameterList
	{
		[Token(Token = "0x6002E78")]
		[Address(RVA = "0x2321F80", Offset = "0x2322081", VA = "0x2321F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5C70", Offset = "0x1A5D71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x2321F90", Offset = "0x2322091", VA = "0x2321F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5C80", Offset = "0x1A5D81")]
		private set
		{
		}
	}

	// Token: 0x060037C5 RID: 14277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x2321FA0", Offset = "0x23220A1", VA = "0x2321FA0")]
	private Actor CreateActor(ActorID id, NPCID nPCID, NpcData npcData)
	{
		return null;
	}

	// Token: 0x060037C6 RID: 14278 RVA: 0x00013308 File Offset: 0x00011508
	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x2322050", Offset = "0x2322151", VA = "0x2322050")]
	private bool TryGetNPCChangeBaseParameter(NPCID npcID, out PartnerManager.NPCChangeBaseParameter param)
	{
		return default(bool);
	}

	// Token: 0x060037C7 RID: 14279 RVA: 0x00013320 File Offset: 0x00011520
	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0x2322130", Offset = "0x2322231", VA = "0x2322130")]
	private bool TryGetPartnerNPCBehavior(ActorID id, out PartnerNPCBehaviorController partnerNPCBehaviorController)
	{
		return default(bool);
	}

	// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x23221F0", Offset = "0x23222F1", VA = "0x23221F0")]
	public void AddNPCPartner(ActorID id, NPCID npcID, [Optional] Action<PartnerNPCBehaviorController> callBack)
	{
	}

	// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0x2322600", Offset = "0x2322701", VA = "0x2322600")]
	public void RemoveNPCPartner(ActorID id, ActorType actorType, NPCID npcID, [Optional] Action<HumanController> callBack)
	{
	}

	// Token: 0x060037CA RID: 14282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E7F")]
	[Address(RVA = "0x23228B0", Offset = "0x23229B1", VA = "0x23228B0")]
	public void AddNPCPartner(ActorID id, [Optional] Action<PartnerNPCBehaviorController> callBack)
	{
	}

	// Token: 0x060037CB RID: 14283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x23229D0", Offset = "0x2322AD1", VA = "0x23229D0")]
	public void RemoveNPCPartner(ActorID id, ActorType actorType, [Optional] Action<HumanController> callBack)
	{
	}

	// Token: 0x060037CC RID: 14284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x2322B00", Offset = "0x2322C01", VA = "0x2322B00")]
	private void UpdateStatePartnerNPC()
	{
	}

	// Token: 0x060037CD RID: 14285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x23231C0", Offset = "0x23232C1", VA = "0x23231C0")]
	public void RestartNPCAI(ActorID actorID)
	{
	}

	// Token: 0x060037CE RID: 14286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x231F7B0", Offset = "0x231F8B1", VA = "0x231F7B0")]
	public void StopNPCAI(ActorID actorID)
	{
	}

	// Token: 0x060037CF RID: 14287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x2323360", Offset = "0x2323461", VA = "0x2323360")]
	public void AddMonsterPartner(ActorID actorId, MonsterStatusBase monsterStatus, [Optional] Action<MonsterBehaviorController> callBack)
	{
	}

	// Token: 0x060037D0 RID: 14288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x2323410", Offset = "0x2323511", VA = "0x2323410")]
	public void ChangeMonsterPartner(ActorID actorId, MonsterStatusBase status, MonsterControllerBase handCuffsMonster, [Optional] Action<MonsterBehaviorController> callBack)
	{
	}

	// Token: 0x060037D1 RID: 14289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x2323A10", Offset = "0x2323B11", VA = "0x2323A10")]
	public void RemoveMonsterPartner(MonsterControllerBase controller)
	{
	}

	// Token: 0x060037D2 RID: 14290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x2323B10", Offset = "0x2323C11", VA = "0x2323B10")]
	public void RestartMonsterAI(MonsterControllerBase controller)
	{
	}

	// Token: 0x060037D3 RID: 14291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x2323C10", Offset = "0x2323D11", VA = "0x2323C10")]
	public void StopMonsterAI(MonsterControllerBase controller)
	{
	}

	// Token: 0x060037D4 RID: 14292 RVA: 0x00013338 File Offset: 0x00011538
	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x2323D20", Offset = "0x2323E21", VA = "0x2323D20")]
	private bool IsPartyMonsterActor(ActorID id)
	{
		return default(bool);
	}

	// Token: 0x060037D5 RID: 14293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x2323D40", Offset = "0x2323E41", VA = "0x2323D40")]
	private void UpdatePartnerForceWarp()
	{
	}

	// Token: 0x060037D6 RID: 14294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x2324060", Offset = "0x2324161", VA = "0x2324060")]
	private void Start()
	{
	}

	// Token: 0x060037D7 RID: 14295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x2324070", Offset = "0x2324171", VA = "0x2324070")]
	private void Update()
	{
	}

	// Token: 0x060037D8 RID: 14296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x23219A0", Offset = "0x2321AA1", VA = "0x23219A0")]
	private void WarpPartner(AIInput aIInput, Vector3 targetPosition, bool isZeroDistance = false)
	{
	}

	// Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x2321CC0", Offset = "0x2321DC1", VA = "0x2321CC0")]
	public void WarpPartner(AIInput aIInput, bool isFront = false, bool isZeroDistance = false)
	{
	}

	// Token: 0x060037DA RID: 14298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x2324D70", Offset = "0x2324E71", VA = "0x2324D70")]
	public void WarpPartner(Vector3 target)
	{
	}

	// Token: 0x060037DB RID: 14299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x2324E90", Offset = "0x2324F91", VA = "0x2324E90")]
	public void WarpPartner(bool isFront = false, bool isZeroDistance = false)
	{
	}

	// Token: 0x060037DC RID: 14300 RVA: 0x00013350 File Offset: 0x00011550
	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x2321E60", Offset = "0x2321F61", VA = "0x2321E60")]
	private bool IsMonster(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x060037DD RID: 14301 RVA: 0x00013368 File Offset: 0x00011568
	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x2321E80", Offset = "0x2321F81", VA = "0x2321E80")]
	private bool IsRoom(FieldSceneId sceneId)
	{
		return default(bool);
	}

	// Token: 0x060037DE RID: 14302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x2325120", Offset = "0x2325221", VA = "0x2325120")]
	private void OnEndTeleportFriends()
	{
	}

	// Token: 0x060037DF RID: 14303 RVA: 0x00013380 File Offset: 0x00011580
	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x2323710", Offset = "0x2323811", VA = "0x2323710")]
	public bool IsInViewCamera(Vector3 position)
	{
		return default(bool);
	}

	// Token: 0x060037E0 RID: 14304 RVA: 0x00013398 File Offset: 0x00011598
	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x23238B0", Offset = "0x23239B1", VA = "0x23238B0")]
	public bool IsInRangePlayer(Vector3 position, float range)
	{
		return default(bool);
	}

	// Token: 0x060037E1 RID: 14305 RVA: 0x000133B0 File Offset: 0x000115B0
	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x2324890", Offset = "0x2324991", VA = "0x2324890")]
	private Vector3 BlurPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060037E2 RID: 14306 RVA: 0x000133C8 File Offset: 0x000115C8
	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x23245F0", Offset = "0x23246F1", VA = "0x23245F0")]
	public Vector3 GetWarpPosition(Vector3 position, Vector3 targetposition, PartnerMovementOrderType partnerMovementOder)
	{
		return default(Vector3);
	}

	// Token: 0x060037E3 RID: 14307 RVA: 0x000133E0 File Offset: 0x000115E0
	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x23239B0", Offset = "0x2323AB1", VA = "0x23239B0")]
	public Vector3 GetWarpPosition(Vector3 position, PartnerMovementOrderType partnerMovementOder)
	{
		return default(Vector3);
	}

	// Token: 0x060037E4 RID: 14308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x2325540", Offset = "0x2325641", VA = "0x2325540")]
	public PartnerNPCBehaviorController GetPartnerNPCBehaviorController(NPCID id)
	{
		return null;
	}

	// Token: 0x060037E5 RID: 14309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x2325740", Offset = "0x2325841", VA = "0x2325740")]
	public PartnerNPCController GetPartnerNPCController(NPCID id)
	{
		return null;
	}

	// Token: 0x060037E6 RID: 14310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x2325850", Offset = "0x2325951", VA = "0x2325850")]
	public HumanController GetCharacterControllerBase(NPCID id)
	{
		return null;
	}

	// Token: 0x060037E7 RID: 14311 RVA: 0x000133F8 File Offset: 0x000115F8
	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x2325960", Offset = "0x2325A61", VA = "0x2325960")]
	public bool IsExistPartner(int id)
	{
		return default(bool);
	}

	// Token: 0x060037E8 RID: 14312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x2325B50", Offset = "0x2325C51", VA = "0x2325B50")]
	public NpcData GetPartnerNpcData(NPCID id)
	{
		return null;
	}

	// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x23241A0", Offset = "0x23242A1", VA = "0x23241A0")]
	private void UpdatePartnerDirection()
	{
	}

	// Token: 0x060037EA RID: 14314 RVA: 0x00013410 File Offset: 0x00011610
	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x23249A0", Offset = "0x2324AA1", VA = "0x23249A0")]
	public Vector3 GetDistination(AIInput aIInput, bool isFront, PartnerMovementOrderType partnerMovementOder)
	{
		return default(Vector3);
	}

	// Token: 0x060037EB RID: 14315 RVA: 0x00013428 File Offset: 0x00011628
	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x2325C10", Offset = "0x2325D11", VA = "0x2325C10")]
	public int GetPartnerNum()
	{
		return 0;
	}

	// Token: 0x060037EC RID: 14316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x2325C60", Offset = "0x2325D61", VA = "0x2325C60")]
	public List<Character> CheckTargetList(PartnerNPCBehaviorController character, NPCFindTargetDataTable findData)
	{
		return null;
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x00013440 File Offset: 0x00011640
	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x23244B0", Offset = "0x23245B1", VA = "0x23244B0")]
	private bool IsOrder()
	{
		return default(bool);
	}

	// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x2324530", Offset = "0x2324631", VA = "0x2324530")]
	private void UpdateOrderOpenWindow()
	{
	}

	// Token: 0x060037EF RID: 14319 RVA: 0x00013458 File Offset: 0x00011658
	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x2326530", Offset = "0x2326631", VA = "0x2326530")]
	private bool IsOrderOpenHandCuffsLeaveADVWindow()
	{
		return default(bool);
	}

	// Token: 0x060037F0 RID: 14320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x23265A0", Offset = "0x23266A1", VA = "0x23265A0")]
	private void OpenHandCuffsLeaveADVWindow()
	{
	}

	// Token: 0x060037F1 RID: 14321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x2326CD0", Offset = "0x2326DD1", VA = "0x2326CD0")]
	private void CloseHandCuffsLeaveADVWindow(PartnerManager.LeaveHandCuffsParam param)
	{
	}

	// Token: 0x060037F2 RID: 14322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x2326D50", Offset = "0x2326E51", VA = "0x2326D50")]
	public void OrderOpenHandCuffsLeaveADVWindow(MonsterControllerBase monster, Action callBack)
	{
	}

	// Token: 0x060037F3 RID: 14323 RVA: 0x00013470 File Offset: 0x00011670
	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x2326A20", Offset = "0x2326B21", VA = "0x2326A20")]
	private bool IsOrderOpenMonsterNamingWindow()
	{
		return default(bool);
	}

	// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EA9")]
	[Address(RVA = "0x2326A80", Offset = "0x2326B81", VA = "0x2326A80")]
	private void OpenFriendMonsterNamingWindow()
	{
	}

	// Token: 0x060037F5 RID: 14325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EAA")]
	[Address(RVA = "0x2326E20", Offset = "0x2326F21", VA = "0x2326E20")]
	private void CloseFriendMonsterNamingWidnow(PartnerManager.FriendMonsterNamingParam param, string name)
	{
	}

	// Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EAB")]
	[Address(RVA = "0x2326EB0", Offset = "0x2326FB1", VA = "0x2326EB0")]
	public void OrderOpenFriendMonsterNamingWindow(MonsterControllerBase monster, Action<string> callBack)
	{
	}

	// Token: 0x060037F7 RID: 14327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EAC")]
	[Address(RVA = "0x2326F70", Offset = "0x2327071", VA = "0x2326F70")]
	public PartnerManager()
	{
	}

	// Token: 0x04007ADB RID: 31451
	[Token(Token = "0x4006F3D")]
	private const float FadeInTime = 0.35f;

	// Token: 0x04007ADC RID: 31452
	[Token(Token = "0x4006F3E")]
	private const float ForceDeadWarpDistance = 40f;

	// Token: 0x04007ADD RID: 31453
	[Token(Token = "0x4006F3F")]
	private const float ForceWarpDistance = 20f;

	// Token: 0x04007ADE RID: 31454
	[Token(Token = "0x4006F40")]
	private const float UpdatePartnerDirectionDistance = 0.01f;

	// Token: 0x04007ADF RID: 31455
	[Token(Token = "0x4006F41")]
	private const float CheckCanForceWarpTime = 1f;

	// Token: 0x04007AE0 RID: 31456
	[Token(Token = "0x4006F42")]
	private const int FriendPriorityMin = 1;

	// Token: 0x04007AE1 RID: 31457
	[Token(Token = "0x4006F43")]
	private const int FriendPriorityMax = 9;

	// Token: 0x04007AE2 RID: 31458
	[Token(Token = "0x4006F44")]
	private const float SubNavMeshSamplePositionDistance = 1f;

	// Token: 0x04007AE3 RID: 31459
	[Token(Token = "0x4006F45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float BehaviorInterval;

	// Token: 0x04007AE4 RID: 31460
	[Token(Token = "0x4006F46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float WalkMargin;

	// Token: 0x04007AE5 RID: 31461
	[Token(Token = "0x4006F47")]
	public const float WalkSpeedScale = 0.25f;

	// Token: 0x04007AE6 RID: 31462
	[Token(Token = "0x4006F48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<PartnerManager.PartnerSearchRange> SearchRangeList;

	// Token: 0x04007AE7 RID: 31463
	[Token(Token = "0x4006F49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly Dictionary<PartnerMovementOrderType, float> PartnerMovementRange;

	// Token: 0x04007AE8 RID: 31464
	[Token(Token = "0x4006F4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public readonly Dictionary<int, List<PartnerManager.DestinationAngle>> PartyDestinationAngleListDic;

	// Token: 0x04007AE9 RID: 31465
	[Token(Token = "0x4006F4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 LatestUpdatePlayerPositionByPartnerDirection;

	// Token: 0x04007AEA RID: 31466
	[Token(Token = "0x4006F4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 LatestPlayerPosition;

	// Token: 0x04007AEB RID: 31467
	[Token(Token = "0x4006F4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 LatestPlayerForward;

	// Token: 0x04007AEC RID: 31468
	[Token(Token = "0x4006F4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B1F0", Offset = "0x16B2F1")]
	private List<AIInput> <PartnerList>k__BackingField;

	// Token: 0x04007AED RID: 31469
	[Token(Token = "0x4006F4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MonsterControllerBase PlayMonster;

	// Token: 0x04007AEE RID: 31470
	[Token(Token = "0x4006F50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float ForceWarpTimer;

	// Token: 0x04007AEF RID: 31471
	[Token(Token = "0x4006F51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int NavmeshAgentPriority;

	// Token: 0x04007AF0 RID: 31472
	[Token(Token = "0x4006F52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private NavMeshHit NavMeshHit;

	// Token: 0x04007AF1 RID: 31473
	[Token(Token = "0x4006F53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int LoadingPartyMonsterCount;

	// Token: 0x04007AF2 RID: 31474
	[Token(Token = "0x4006F54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 PartnerDirection;

	// Token: 0x04007AF3 RID: 31475
	[Token(Token = "0x4006F55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool IsHandCuffsPartner;

	// Token: 0x04007AF4 RID: 31476
	[Token(Token = "0x4006F56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B200", Offset = "0x16B301")]
	private List<PartnerManager.NPCChangeBaseParameter> <NPCChangeBaseParameterList>k__BackingField;

	// Token: 0x04007AF5 RID: 31477
	[Token(Token = "0x4006F57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool IsOpenLeaveAdvWindow;

	// Token: 0x04007AF6 RID: 31478
	[Token(Token = "0x4006F58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private LinkedList<PartnerManager.LeaveHandCuffsParam> HandCuffsMonsterLeaveParamLinkedList;

	// Token: 0x04007AF7 RID: 31479
	[Token(Token = "0x4006F59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool IsOpenedNamingWindow;

	// Token: 0x04007AF8 RID: 31480
	[Token(Token = "0x4006F5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private LinkedList<PartnerManager.FriendMonsterNamingParam> FriendMonsterNamingParamLinkedList;

	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2001249")]
	public class PartnerSearchRange
	{
		// Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007434")]
		[Address(RVA = "0x2327470", Offset = "0x2327571", VA = "0x2327470")]
		public PartnerSearchRange()
		{
		}

		// Token: 0x04007AF9 RID: 31481
		[Token(Token = "0x4019803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Angle;

		// Token: 0x04007AFA RID: 31482
		[Token(Token = "0x4019804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Distance;
	}

	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200124A")]
	public class DestinationAngle
	{
		// Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007435")]
		[Address(RVA = "0x2327480", Offset = "0x2327581", VA = "0x2327480")]
		public DestinationAngle()
		{
		}

		// Token: 0x04007AFB RID: 31483
		[Token(Token = "0x4019805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Front;

		// Token: 0x04007AFC RID: 31484
		[Token(Token = "0x4019806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Back;
	}

	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200124B")]
	public enum NPCChangeBaseState
	{
		// Token: 0x04007AFE RID: 31486
		[Token(Token = "0x4019808")]
		None,
		// Token: 0x04007AFF RID: 31487
		[Token(Token = "0x4019809")]
		ChangePartnerOrder,
		// Token: 0x04007B00 RID: 31488
		[Token(Token = "0x401980A")]
		CreatePartnerBehavior,
		// Token: 0x04007B01 RID: 31489
		[Token(Token = "0x401980B")]
		ChangeNPCOrder,
		// Token: 0x04007B02 RID: 31490
		[Token(Token = "0x401980C")]
		End
	}

	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200124C")]
	public class NPCChangeBaseParameter
	{
		// Token: 0x060037FA RID: 14330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007436")]
		[Address(RVA = "0x23224F0", Offset = "0x23225F1", VA = "0x23224F0")]
		public NPCChangeBaseParameter()
		{
		}

		// Token: 0x04007B03 RID: 31491
		[Token(Token = "0x401980D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor Actor;

		// Token: 0x04007B04 RID: 31492
		[Token(Token = "0x401980E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NPCID NPCID;

		// Token: 0x04007B05 RID: 31493
		[Token(Token = "0x401980F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PartnerManager.NPCChangeBaseState State;

		// Token: 0x04007B06 RID: 31494
		[Token(Token = "0x4019810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsWarp;

		// Token: 0x04007B07 RID: 31495
		[Token(Token = "0x4019811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool IsCreateBehavior;

		// Token: 0x04007B08 RID: 31496
		[Token(Token = "0x4019812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PartnerManager.NPCChangeBaseParameter.PartyInEvent CallBackPartyIn;

		// Token: 0x04007B09 RID: 31497
		[Token(Token = "0x4019813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PartnerManager.NPCChangeBaseParameter.PartyOutEvent CallBackPartyOut;

		// Token: 0x0200082D RID: 2093
		[Token(Token = "0x200164E")]
		public class PartyInEvent : UnityEvent<PartnerNPCBehaviorController>
		{
			// Token: 0x060037FB RID: 14331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600809E")]
			[Address(RVA = "0x2328350", Offset = "0x2328451", VA = "0x2328350")]
			public PartyInEvent()
			{
			}
		}

		// Token: 0x0200082E RID: 2094
		[Token(Token = "0x200164F")]
		public class PartyOutEvent : UnityEvent<HumanController>
		{
			// Token: 0x060037FC RID: 14332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600809F")]
			[Address(RVA = "0x23283A0", Offset = "0x23284A1", VA = "0x23283A0")]
			public PartyOutEvent()
			{
			}
		}
	}

	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200124D")]
	public class LeaveHandCuffsParam
	{
		// Token: 0x060037FD RID: 14333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007437")]
		[Address(RVA = "0x2326E00", Offset = "0x2326F01", VA = "0x2326E00")]
		public LeaveHandCuffsParam()
		{
		}

		// Token: 0x04007B0A RID: 31498
		[Token(Token = "0x4019814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase Monster;

		// Token: 0x04007B0B RID: 31499
		[Token(Token = "0x4019815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action CallBack;
	}

	// Token: 0x02000830 RID: 2096
	[Token(Token = "0x200124E")]
	public class FriendMonsterNamingParam
	{
		// Token: 0x060037FE RID: 14334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007438")]
		[Address(RVA = "0x2326F60", Offset = "0x2327061", VA = "0x2326F60")]
		public FriendMonsterNamingParam()
		{
		}

		// Token: 0x04007B0C RID: 31500
		[Token(Token = "0x4019816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase Monster;

		// Token: 0x04007B0D RID: 31501
		[Token(Token = "0x4019817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<string> CallBack;
	}

	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x200124F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C30", Offset = "0x158D31")]
	private sealed class <>c__DisplayClass50_0
	{
		// Token: 0x060037FF RID: 14335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007439")]
		[Address(RVA = "0x2327660", Offset = "0x2327761", VA = "0x2327660")]
		public <>c__DisplayClass50_0()
		{
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743A")]
		[Address(RVA = "0x2327670", Offset = "0x2327771", VA = "0x2327670")]
		internal void <AsyncAddFriendMonster>b__0(MonsterControllerBase controller)
		{
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743B")]
		[Address(RVA = "0x23276F0", Offset = "0x23277F1", VA = "0x23276F0")]
		internal void <AsyncAddFriendMonster>b__1(PartnerMonsterBehaviorController behavior)
		{
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743C")]
		[Address(RVA = "0x2327880", Offset = "0x2327981", VA = "0x2327880")]
		internal void <AsyncAddFriendMonster>b__2()
		{
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743D")]
		[Address(RVA = "0x2327950", Offset = "0x2327A51", VA = "0x2327950")]
		internal void <AsyncAddFriendMonster>b__3(FarmMonsterBehaviorController behavior)
		{
		}

		// Token: 0x04007B0E RID: 31502
		[Token(Token = "0x4019818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;

		// Token: 0x04007B0F RID: 31503
		[Token(Token = "0x4019819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Actor actor;

		// Token: 0x04007B10 RID: 31504
		[Token(Token = "0x401981A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerManager <>4__this;

		// Token: 0x04007B11 RID: 31505
		[Token(Token = "0x401981B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<FarmMonsterBehaviorController> <>9__3;
	}

	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2001250")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C40", Offset = "0x158D41")]
	private sealed class <AsyncAddFriendMonster>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003804 RID: 14340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743E")]
		[Address(RVA = "0x2321F50", Offset = "0x2322051", VA = "0x2321F50")]
		[DebuggerHidden]
		public <AsyncAddFriendMonster>d__50(int <>1__state)
		{
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600743F")]
		[Address(RVA = "0x2327F30", Offset = "0x2328031", VA = "0x2327F30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x6007440")]
		[Address(RVA = "0x2327F40", Offset = "0x2328041", VA = "0x2327F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D74")]
		private object Current
		{
			[Token(Token = "0x6007441")]
			[Address(RVA = "0x23282D0", Offset = "0x23283D1", VA = "0x23282D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007442")]
		[Address(RVA = "0x23282E0", Offset = "0x23283E1", VA = "0x23282E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D75")]
		private object Current
		{
			[Token(Token = "0x6007443")]
			[Address(RVA = "0x2328340", Offset = "0x2328441", VA = "0x2328340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007B12 RID: 31506
		[Token(Token = "0x401981C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007B13 RID: 31507
		[Token(Token = "0x401981D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007B14 RID: 31508
		[Token(Token = "0x401981E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerManager <>4__this;

		// Token: 0x04007B15 RID: 31509
		[Token(Token = "0x401981F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ActorID actorId;

		// Token: 0x04007B16 RID: 31510
		[Token(Token = "0x4019820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PartnerManager.<>c__DisplayClass50_0 <>8__1;

		// Token: 0x04007B17 RID: 31511
		[Token(Token = "0x4019821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MonsterStatusBase monsterStatus;
	}

	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2001251")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C50", Offset = "0x158D51")]
	private sealed class <>c__DisplayClass60_0
	{
		// Token: 0x0600380A RID: 14346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007444")]
		[Address(RVA = "0x23224E0", Offset = "0x23225E1", VA = "0x23224E0")]
		public <>c__DisplayClass60_0()
		{
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007445")]
		[Address(RVA = "0x2327A10", Offset = "0x2327B11", VA = "0x2327A10")]
		internal void <AddNPCPartner>b__0(PartnerNPCBehaviorController partnerNPC)
		{
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007446")]
		[Address(RVA = "0x2327A80", Offset = "0x2327B81", VA = "0x2327A80")]
		internal void <AddNPCPartner>b__1(PartnerNPCBehaviorController partnerNPC)
		{
		}

		// Token: 0x04007B18 RID: 31512
		[Token(Token = "0x4019822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<PartnerNPCBehaviorController> callBack;
	}

	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2001252")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C60", Offset = "0x158D61")]
	private sealed class <>c__DisplayClass61_0
	{
		// Token: 0x0600380D RID: 14349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007447")]
		[Address(RVA = "0x23228A0", Offset = "0x23229A1", VA = "0x23228A0")]
		public <>c__DisplayClass61_0()
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007448")]
		[Address(RVA = "0x2327AF0", Offset = "0x2327BF1", VA = "0x2327AF0")]
		internal void <RemoveNPCPartner>b__0(HumanController npc)
		{
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007449")]
		[Address(RVA = "0x2327B60", Offset = "0x2327C61", VA = "0x2327B60")]
		internal void <RemoveNPCPartner>b__1(HumanController npc)
		{
		}

		// Token: 0x04007B19 RID: 31513
		[Token(Token = "0x4019823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<HumanController> callBack;
	}

	// Token: 0x02000835 RID: 2101
	[Token(Token = "0x2001253")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C70", Offset = "0x158D71")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x06003810 RID: 14352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744A")]
		[Address(RVA = "0x23231A0", Offset = "0x23232A1", VA = "0x23231A0")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x04007B1A RID: 31514
		[Token(Token = "0x4019824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PartnerManager.NPCChangeBaseParameter param;

		// Token: 0x04007B1B RID: 31515
		[Token(Token = "0x4019825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PartnerManager <>4__this;
	}

	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2001254")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C80", Offset = "0x158D81")]
	private sealed class <>c__DisplayClass64_1
	{
		// Token: 0x06003811 RID: 14353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744B")]
		[Address(RVA = "0x23231B0", Offset = "0x23232B1", VA = "0x23231B0")]
		public <>c__DisplayClass64_1()
		{
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744C")]
		[Address(RVA = "0x2327BD0", Offset = "0x2327CD1", VA = "0x2327BD0")]
		internal void <UpdateStatePartnerNPC>b__1(PartnerNPCBehaviorController behavior)
		{
		}

		// Token: 0x04007B1C RID: 31516
		[Token(Token = "0x4019826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PartnerNPCController controller;

		// Token: 0x04007B1D RID: 31517
		[Token(Token = "0x4019827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PartnerManager.<>c__DisplayClass64_0 CS$<>8__locals1;
	}

	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2001255")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158C90", Offset = "0x158D91")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003814 RID: 14356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744E")]
		[Address(RVA = "0x2327500", Offset = "0x2327601", VA = "0x2327500")]
		public <>c()
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x600744F")]
		[Address(RVA = "0x2327510", Offset = "0x2327611", VA = "0x2327510")]
		internal bool <UpdateStatePartnerNPC>b__64_0(PartnerManager.NPCChangeBaseParameter parameter)
		{
			return default(bool);
		}

		// Token: 0x04007B1E RID: 31518
		[Token(Token = "0x4019828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PartnerManager.<>c <>9;

		// Token: 0x04007B1F RID: 31519
		[Token(Token = "0x4019829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<PartnerManager.NPCChangeBaseParameter> <>9__64_0;
	}

	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2001256")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CA0", Offset = "0x158DA1")]
	private sealed class <>c__DisplayClass68_0
	{
		// Token: 0x06003816 RID: 14358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007450")]
		[Address(RVA = "0x2323700", Offset = "0x2323801", VA = "0x2323700")]
		public <>c__DisplayClass68_0()
		{
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007451")]
		[Address(RVA = "0x2327D70", Offset = "0x2327E71", VA = "0x2327D70")]
		internal void <ChangeMonsterPartner>b__0()
		{
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007452")]
		[Address(RVA = "0x2327E40", Offset = "0x2327F41", VA = "0x2327E40")]
		internal void <ChangeMonsterPartner>b__1(PartnerMonsterBehaviorController behavior)
		{
		}

		// Token: 0x04007B20 RID: 31520
		[Token(Token = "0x401982A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase handCuffsMonster;

		// Token: 0x04007B21 RID: 31521
		[Token(Token = "0x401982B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Actor actor;

		// Token: 0x04007B22 RID: 31522
		[Token(Token = "0x401982C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerManager <>4__this;

		// Token: 0x04007B23 RID: 31523
		[Token(Token = "0x401982D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PartnerMonsterBehaviorController> <>9__1;
	}

	// Token: 0x02000839 RID: 2105
	[Token(Token = "0x2001257")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CB0", Offset = "0x158DB1")]
	private sealed class <>c__DisplayClass103_0
	{
		// Token: 0x06003819 RID: 14361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007453")]
		[Address(RVA = "0x2326CC0", Offset = "0x2326DC1", VA = "0x2326CC0")]
		public <>c__DisplayClass103_0()
		{
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007454")]
		[Address(RVA = "0x2327530", Offset = "0x2327631", VA = "0x2327530")]
		internal void <OpenHandCuffsLeaveADVWindow>b__0()
		{
		}

		// Token: 0x04007B24 RID: 31524
		[Token(Token = "0x401982E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PartnerManager <>4__this;

		// Token: 0x04007B25 RID: 31525
		[Token(Token = "0x401982F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PartnerManager.LeaveHandCuffsParam param;
	}

	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x2001258")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CC0", Offset = "0x158DC1")]
	private sealed class <>c__DisplayClass110_0
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007455")]
		[Address(RVA = "0x2326E10", Offset = "0x2326F11", VA = "0x2326E10")]
		public <>c__DisplayClass110_0()
		{
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007456")]
		[Address(RVA = "0x23275C0", Offset = "0x23276C1", VA = "0x23275C0")]
		internal void <OpenFriendMonsterNamingWindow>b__0(string nickname)
		{
		}

		// Token: 0x04007B26 RID: 31526
		[Token(Token = "0x4019830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PartnerManager <>4__this;

		// Token: 0x04007B27 RID: 31527
		[Token(Token = "0x4019831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PartnerManager.FriendMonsterNamingParam param;
	}
}
