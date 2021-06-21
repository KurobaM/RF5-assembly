using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000786 RID: 1926
[Token(Token = "0x2000524")]
public class MonsterManager : SingletonMonoBehaviour<MonsterManager>
{
	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x060031B8 RID: 12728 RVA: 0x00011388 File Offset: 0x0000F588
	// (set) Token: 0x060031B9 RID: 12729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700057F")]
	public bool IsUpdateResourceList
	{
		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x1E66660", Offset = "0x1E66761", VA = "0x1E66660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A47D0", Offset = "0x1A48D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029B8")]
		[Address(RVA = "0x1E66670", Offset = "0x1E66771", VA = "0x1E66670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A47E0", Offset = "0x1A48E1")]
		private set
		{
		}
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x1E66680", Offset = "0x1E66781", VA = "0x1E66680")]
	public void OnAfterGameDataLoad()
	{
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x1E67230", Offset = "0x1E67331", VA = "0x1E67230", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x1E673A0", Offset = "0x1E674A1", VA = "0x1E673A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x1E675A0", Offset = "0x1E676A1", VA = "0x1E675A0")]
	private void Update()
	{
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x1E676F0", Offset = "0x1E677F1", VA = "0x1E676F0")]
	private void OnCarryDay(int carryDay)
	{
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x1E67720", Offset = "0x1E67821", VA = "0x1E67720")]
	private void OnBeginTeleport()
	{
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x1E67730", Offset = "0x1E67831", VA = "0x1E67730")]
	private void OnEndTeleport()
	{
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x1E67780", Offset = "0x1E67881", VA = "0x1E67780")]
	public GateController GetGateController(GateDataID gateDataID)
	{
		return null;
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x1E66CE0", Offset = "0x1E66DE1", VA = "0x1E66CE0")]
	private void FindGateAndBossStage()
	{
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x1E66EE0", Offset = "0x1E66FE1", VA = "0x1E66EE0")]
	private void GateInit()
	{
	}

	// Token: 0x060031C4 RID: 12740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x1E67040", Offset = "0x1E67141", VA = "0x1E67040")]
	private void BossStageInit()
	{
	}

	// Token: 0x060031C5 RID: 12741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x1E67820", Offset = "0x1E67921", VA = "0x1E67820")]
	private void InitializeGateController(GateController gateController)
	{
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x1E675D0", Offset = "0x1E676D1", VA = "0x1E675D0")]
	public void UpdateGateControllers()
	{
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x000113A0 File Offset: 0x0000F5A0
	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x1E67AC0", Offset = "0x1E67BC1", VA = "0x1E67AC0")]
	public GateStatusDataTable GetLotteryGateStatusDataTable(GateDataTable gateDataTable)
	{
		return default(GateStatusDataTable);
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x000113B8 File Offset: 0x0000F5B8
	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x1E67F50", Offset = "0x1E68051", VA = "0x1E67F50")]
	public GateStatusDataTable GetSelcetGateStattusDataTable(GateDataTable gateDataTable, int eventIndex)
	{
		return default(GateStatusDataTable);
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x000113D0 File Offset: 0x0000F5D0
	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x1E67B50", Offset = "0x1E67C51", VA = "0x1E67B50")]
	public GateStatusDataID GetLottryGateStatusDataID(GateDataTable gateDataTable)
	{
		return GateStatusDataID.GateStatusData_EMPTY;
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x000113E8 File Offset: 0x0000F5E8
	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x1E68030", Offset = "0x1E68131", VA = "0x1E68030")]
	public MonsterDataID GetLotterySpawnMonsterDataID(GateStatusDataTable gateStatusDataTable, int spawnPoint = -1)
	{
		return MonsterDataID.MonsterData_EMPTY;
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x1E667D0", Offset = "0x1E668D1", VA = "0x1E667D0")]
	public void SetEnableGateControllers(bool isEnable, bool isCallback = false)
	{
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x1E67970", Offset = "0x1E67A71", VA = "0x1E67970")]
	public void UpdateGateState()
	{
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x1E684B0", Offset = "0x1E685B1", VA = "0x1E684B0")]
	public BossStageManager GetBossStageManager(int stageIndex)
	{
		return null;
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x1E67A20", Offset = "0x1E67B21", VA = "0x1E67A20")]
	private void InitializeBossStageManager(BossStageManager bossStage)
	{
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x1E68550", Offset = "0x1E68651", VA = "0x1E68550")]
	public void BossStagePlay(int stageIndex = 0, int eventIndex = 0, [Optional] Action<BossBehaviorController> callBack)
	{
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x1E68610", Offset = "0x1E68711", VA = "0x1E68610")]
	public void BossStageDestroyInstanceBoss(int stageIndex = 0)
	{
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x1E686C0", Offset = "0x1E687C1", VA = "0x1E686C0")]
	public string GetBossStageEmergenceBossName(int stageIndex, int eventIndex)
	{
		return null;
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x00011400 File Offset: 0x0000F600
	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x1E68780", Offset = "0x1E68881", VA = "0x1E68780")]
	public bool CheckBattleBossNow()
	{
		return default(bool);
	}

	// Token: 0x060031D3 RID: 12755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D2")]
	[Address(RVA = "0x1E688A0", Offset = "0x1E689A1", VA = "0x1E688A0")]
	private void AddEnemyMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x1E68AC0", Offset = "0x1E68BC1", VA = "0x1E68AC0")]
	public void RemoveEnemyMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x1E68B30", Offset = "0x1E68C31", VA = "0x1E68B30")]
	public void DestroyEnemyMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D5")]
	[Address(RVA = "0x1E669E0", Offset = "0x1E66AE1", VA = "0x1E669E0")]
	public void DestroyAllEnemyMonster()
	{
	}

	// Token: 0x060031D7 RID: 12759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D6")]
	[Address(RVA = "0x1E68DC0", Offset = "0x1E68EC1", VA = "0x1E68DC0")]
	public void SetDisplayEnemy(bool isDisplay)
	{
	}

	// Token: 0x060031D8 RID: 12760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x1E68EF0", Offset = "0x1E68FF1", VA = "0x1E68EF0")]
	public void AddFriendMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x1E69080", Offset = "0x1E69181", VA = "0x1E69080")]
	private void RemoveFriendMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031DA RID: 12762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029D9")]
	[Address(RVA = "0x1E690F0", Offset = "0x1E691F1", VA = "0x1E690F0")]
	public void DestroyFriendMonster(MonsterControllerBase controller)
	{
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x1E66B70", Offset = "0x1E66C71", VA = "0x1E66B70")]
	public void DestroyAllFriendMonster()
	{
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x1E69320", Offset = "0x1E69421", VA = "0x1E69320")]
	public MonsterStatusBase CreateMonsterStatus(MonsterType type, int level, MonsterDataID id)
	{
		return null;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x1E69420", Offset = "0x1E69521", VA = "0x1E69420")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A47F0", Offset = "0x1A48F1")]
	public IEnumerator GetAsyncControllerModel(MonsterDataID id, MonsterType monsterType, int level, Action<MonsterControllerBase> callBack)
	{
		return null;
	}

	// Token: 0x060031DE RID: 12766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x1E69510", Offset = "0x1E69611", VA = "0x1E69510")]
	public void GetControllerModel(MonsterDataID id, MonsterType monsterType, int level, Action<MonsterControllerBase> callBack)
	{
	}

	// Token: 0x060031DF RID: 12767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x1E695D0", Offset = "0x1E696D1", VA = "0x1E695D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4860", Offset = "0x1A4961")]
	private IEnumerator GetAsyncControllerModel(MonsterDataID id, bool isEnemy, Action<GameObject, MonsterControllerBase> callBack)
	{
		return null;
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x1E696C0", Offset = "0x1E697C1", VA = "0x1E696C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A48D0", Offset = "0x1A49D1")]
	public IEnumerator GetAsyncControllerModel(MonsterStatusBase status, MonsterType monsterType, Action<MonsterControllerBase> callBack)
	{
		return null;
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x1E697B0", Offset = "0x1E698B1", VA = "0x1E697B0")]
	public void GetControllerModel(MonsterStatusBase status, MonsterType monsterType, Action<MonsterControllerBase> callBack)
	{
	}

	// Token: 0x060031E2 RID: 12770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x1E697E0", Offset = "0x1E698E1", VA = "0x1E697E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4940", Offset = "0x1A4A41")]
	private IEnumerator GetAsyncSpcControllerModel(MonsterDataID id, bool isEnemy, Action<GameObject, SpcMonsterController> callBack)
	{
		return null;
	}

	// Token: 0x060031E3 RID: 12771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x1E698D0", Offset = "0x1E699D1", VA = "0x1E698D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A49B0", Offset = "0x1A4AB1")]
	private IEnumerator GetAsyncSpcControllerModel(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callBack)
	{
		return null;
	}

	// Token: 0x060031E4 RID: 12772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x1E699C0", Offset = "0x1E69AC1", VA = "0x1E699C0")]
	public void GetSpcControllerModel(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callBack)
	{
	}

	// Token: 0x060031E5 RID: 12773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x1E672E0", Offset = "0x1E673E1", VA = "0x1E672E0")]
	private void SetupMonsterModel()
	{
	}

	// Token: 0x060031E6 RID: 12774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x1E69C30", Offset = "0x1E69D31", VA = "0x1E69C30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4A20", Offset = "0x1A4B21")]
	private IEnumerator LoadModel(Prefab id, [Optional] Action<GameObject> callback)
	{
		return null;
	}

	// Token: 0x060031E7 RID: 12775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x1E69D00", Offset = "0x1E69E01", VA = "0x1E69D00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4A90", Offset = "0x1A4B91")]
	public IEnumerator GetAsyncModel(MonsterModelDataID id, bool isEnemy, bool isChangeUIScale = false, int layer = -1, [Optional] Action<GameObject> callback)
	{
		return null;
	}

	// Token: 0x060031E8 RID: 12776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x1E69E00", Offset = "0x1E69F01", VA = "0x1E69E00")]
	public void GetModel(MonsterModelDataID id, bool isEnemy, bool isChangeScale = false, int layer = -1, [Optional] Action<MonsterModelDataID, GameObject> callback)
	{
	}

	// Token: 0x060031E9 RID: 12777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x1E69F80", Offset = "0x1E6A081", VA = "0x1E69F80")]
	public void GetModel(MonsterDataID id, bool isEnemy, bool isChangeScale = false, int layer = -1, [Optional] Action<MonsterDataID, GameObject> callback)
	{
	}

	// Token: 0x060031EA RID: 12778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x1E6A120", Offset = "0x1E6A221", VA = "0x1E6A120")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4B00", Offset = "0x1A4C01")]
	private IEnumerator LoadAsyncController(Prefab id, Action<MonsterControllerBase> callback)
	{
		return null;
	}

	// Token: 0x060031EB RID: 12779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x1E6A1F0", Offset = "0x1E6A2F1", VA = "0x1E6A1F0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4B70", Offset = "0x1A4C71")]
	private IEnumerator LoaderAsyncActionCodeData(Master actionCodeDataID, Action<MonsterActionCodeDataTableArray> callBack)
	{
		return null;
	}

	// Token: 0x060031EC RID: 12780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029EB")]
	[Address(RVA = "0x1E6A2C0", Offset = "0x1E6A3C1", VA = "0x1E6A2C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4BE0", Offset = "0x1A4CE1")]
	private IEnumerator LoadAsyncSpcController(Action<SpcMonsterController> callback)
	{
		return null;
	}

	// Token: 0x060031ED RID: 12781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029EC")]
	[Address(RVA = "0x1E6A390", Offset = "0x1E6A491", VA = "0x1E6A390")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4C50", Offset = "0x1A4D51")]
	private IEnumerator GetAsyncController(MonsterDataID id, bool isEnemy, Action<MonsterControllerBase> callback)
	{
		return null;
	}

	// Token: 0x060031EE RID: 12782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029ED")]
	[Address(RVA = "0x1E6A480", Offset = "0x1E6A581", VA = "0x1E6A480")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4CC0", Offset = "0x1A4DC1")]
	private IEnumerator GetAsyncSpcController(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callback)
	{
		return null;
	}

	// Token: 0x060031EF RID: 12783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029EE")]
	[Address(RVA = "0x1E6A570", Offset = "0x1E6A671", VA = "0x1E6A570")]
	public void GetSpcController(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callback)
	{
	}

	// Token: 0x060031F0 RID: 12784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60029EF")]
	[Address(RVA = "0x1E6A630", Offset = "0x1E6A731", VA = "0x1E6A630")]
	public MonsterManager()
	{
	}

	// Token: 0x04007689 RID: 30345
	[Token(Token = "0x4006C72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 LoadSpwanPoint;

	// Token: 0x0400768A RID: 30346
	[Token(Token = "0x4006C73")]
	private const string AssetPath = "Assets/AssetBundleDatas/";

	// Token: 0x0400768B RID: 30347
	[Token(Token = "0x4006C74")]
	private const string DogBehaviorName = "BossBehavior";

	// Token: 0x0400768C RID: 30348
	[Token(Token = "0x4006C75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnknownTask task;

	// Token: 0x0400768D RID: 30349
	[Token(Token = "0x4006C76")]
	private const int EnemyPriorityMax = 99;

	// Token: 0x0400768E RID: 30350
	[Token(Token = "0x4006C77")]
	private const int EnemyPriorityMin = 10;

	// Token: 0x0400768F RID: 30351
	[Token(Token = "0x4006C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<GateDataID, GateController> GateControllerDic;

	// Token: 0x04007690 RID: 30352
	[Token(Token = "0x4006C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, BossStageManager> BossStageManagerDic;

	// Token: 0x04007691 RID: 30353
	[Token(Token = "0x4006C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<MonsterControllerBase> CreatedEnemyControllerList;

	// Token: 0x04007692 RID: 30354
	[Token(Token = "0x4006C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<MonsterControllerBase> CreatedFriendControllerList;

	// Token: 0x04007693 RID: 30355
	[Token(Token = "0x4006C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1699F0", Offset = "0x169AF1")]
	private bool <IsUpdateResourceList>k__BackingField;

	// Token: 0x04007694 RID: 30356
	[Token(Token = "0x4006C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UnityEvent OnEndUpdateResourceList;

	// Token: 0x04007695 RID: 30357
	[Token(Token = "0x4006C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private WantedMonsterManager WantedMonsterManager;

	// Token: 0x04007696 RID: 30358
	[Token(Token = "0x4006C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int NavmeshPriority;

	// Token: 0x04007697 RID: 30359
	[Token(Token = "0x4006C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MonsterModelDataTable MonsterModelDataTable;

	// Token: 0x04007698 RID: 30360
	[Token(Token = "0x4006C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<Master, MonsterActionCodeDataTableArray> LoadActionCodeDataDic;

	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x20011E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158790", Offset = "0x158891")]
	private sealed class <>c__DisplayClass28_0
	{
		// Token: 0x060031F2 RID: 12786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0x1E67AB0", Offset = "0x1E67BB1", VA = "0x1E67AB0")]
		public <>c__DisplayClass28_0()
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0x1E6A850", Offset = "0x1E6A951", VA = "0x1E6A850")]
		internal void <InitializeGateController>b__0()
		{
		}

		// Token: 0x04007699 RID: 30361
		[Token(Token = "0x4019680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterManager <>4__this;

		// Token: 0x0400769A RID: 30362
		[Token(Token = "0x4019681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GateController gateController;
	}

	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x20011E9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587A0", Offset = "0x1588A1")]
	private sealed class <>c__DisplayClass42_0
	{
		// Token: 0x060031F4 RID: 12788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072ED")]
		[Address(RVA = "0x1E68AB0", Offset = "0x1E68BB1", VA = "0x1E68AB0")]
		public <>c__DisplayClass42_0()
		{
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x60072EE")]
		[Address(RVA = "0x1E6A8C0", Offset = "0x1E6A9C1", VA = "0x1E6A8C0")]
		internal bool <AddEnemyMonster>b__0(MonsterControllerBase listController)
		{
			return default(bool);
		}

		// Token: 0x0400769B RID: 30363
		[Token(Token = "0x4019682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase controller;
	}

	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x20011EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587B0", Offset = "0x1588B1")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x060031F6 RID: 12790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EF")]
		[Address(RVA = "0x1E68DB0", Offset = "0x1E68EB1", VA = "0x1E68DB0")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00011430 File Offset: 0x0000F630
		[Token(Token = "0x60072F0")]
		[Address(RVA = "0x1E6A940", Offset = "0x1E6AA41", VA = "0x1E6A940")]
		internal bool <DestroyEnemyMonster>b__0(MonsterControllerBase listController)
		{
			return default(bool);
		}

		// Token: 0x0400769C RID: 30364
		[Token(Token = "0x4019683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase controller;
	}

	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x20011EB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587C0", Offset = "0x1588C1")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x060031F8 RID: 12792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0x1E69070", Offset = "0x1E69171", VA = "0x1E69070")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00011448 File Offset: 0x0000F648
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0x1E6A9C0", Offset = "0x1E6AAC1", VA = "0x1E6A9C0")]
		internal bool <AddFriendMonster>b__0(MonsterControllerBase listController)
		{
			return default(bool);
		}

		// Token: 0x0400769D RID: 30365
		[Token(Token = "0x4019684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase controller;
	}

	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x20011EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587D0", Offset = "0x1588D1")]
	private sealed class <>c__DisplayClass49_0
	{
		// Token: 0x060031FA RID: 12794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0x1E69310", Offset = "0x1E69411", VA = "0x1E69310")]
		public <>c__DisplayClass49_0()
		{
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00011460 File Offset: 0x0000F660
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0x1E6AA40", Offset = "0x1E6AB41", VA = "0x1E6AA40")]
		internal bool <DestroyFriendMonster>b__0(MonsterControllerBase listController)
		{
			return default(bool);
		}

		// Token: 0x0400769E RID: 30366
		[Token(Token = "0x4019685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase controller;
	}

	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x20011ED")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587E0", Offset = "0x1588E1")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x060031FC RID: 12796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F5")]
		[Address(RVA = "0x1E6AAC0", Offset = "0x1E6ABC1", VA = "0x1E6AAC0")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F6")]
		[Address(RVA = "0x1E6AAD0", Offset = "0x1E6ABD1", VA = "0x1E6AAD0")]
		internal void <GetAsyncControllerModel>b__0(MonsterControllerBase monsterController)
		{
		}

		// Token: 0x0400769F RID: 30367
		[Token(Token = "0x4019686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<MonsterControllerBase> callBack;
	}

	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x20011EE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1587F0", Offset = "0x1588F1")]
	private sealed class <GetAsyncControllerModel>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060031FE RID: 12798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F7")]
		[Address(RVA = "0x1E694E0", Offset = "0x1E695E1", VA = "0x1E694E0")]
		[DebuggerHidden]
		public <GetAsyncControllerModel>d__52(int <>1__state)
		{
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F8")]
		[Address(RVA = "0x1E6B7B0", Offset = "0x1E6B8B1", VA = "0x1E6B7B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00011478 File Offset: 0x0000F678
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0x1E6B7C0", Offset = "0x1E6B8C1", VA = "0x1E6B7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2B")]
		private object Current
		{
			[Token(Token = "0x60072FA")]
			[Address(RVA = "0x1E6B8E0", Offset = "0x1E6B9E1", VA = "0x1E6B8E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FB")]
		[Address(RVA = "0x1E6B8F0", Offset = "0x1E6B9F1", VA = "0x1E6B8F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2C")]
		private object Current
		{
			[Token(Token = "0x60072FC")]
			[Address(RVA = "0x1E6B950", Offset = "0x1E6BA51", VA = "0x1E6B950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076A0 RID: 30368
		[Token(Token = "0x4019687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076A1 RID: 30369
		[Token(Token = "0x4019688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076A2 RID: 30370
		[Token(Token = "0x4019689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<MonsterControllerBase> callBack;

		// Token: 0x040076A3 RID: 30371
		[Token(Token = "0x401968A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076A4 RID: 30372
		[Token(Token = "0x401968B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MonsterType monsterType;

		// Token: 0x040076A5 RID: 30373
		[Token(Token = "0x401968C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int level;

		// Token: 0x040076A6 RID: 30374
		[Token(Token = "0x401968D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MonsterDataID id;
	}

	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x20011EF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158800", Offset = "0x158901")]
	private sealed class <>c__DisplayClass54_0
	{
		// Token: 0x06003204 RID: 12804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FD")]
		[Address(RVA = "0x1E6AB50", Offset = "0x1E6AC51", VA = "0x1E6AB50")]
		public <>c__DisplayClass54_0()
		{
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FE")]
		[Address(RVA = "0x1E6AB60", Offset = "0x1E6AC61", VA = "0x1E6AB60")]
		internal void <GetAsyncControllerModel>b__0(GameObject instance)
		{
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FF")]
		[Address(RVA = "0x1E6AB70", Offset = "0x1E6AC71", VA = "0x1E6AB70")]
		internal void <GetAsyncControllerModel>b__1(MonsterControllerBase instance)
		{
		}

		// Token: 0x040076A7 RID: 30375
		[Token(Token = "0x401968E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject model;

		// Token: 0x040076A8 RID: 30376
		[Token(Token = "0x401968F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MonsterControllerBase controller;
	}

	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x20011F0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158810", Offset = "0x158911")]
	private sealed class <GetAsyncControllerModel>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003207 RID: 12807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007300")]
		[Address(RVA = "0x1E69690", Offset = "0x1E69791", VA = "0x1E69690")]
		[DebuggerHidden]
		public <GetAsyncControllerModel>d__54(int <>1__state)
		{
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007301")]
		[Address(RVA = "0x1E6B960", Offset = "0x1E6BA61", VA = "0x1E6B960", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x00011490 File Offset: 0x0000F690
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x1E6B970", Offset = "0x1E6BA71", VA = "0x1E6B970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2D")]
		private object Current
		{
			[Token(Token = "0x6007303")]
			[Address(RVA = "0x1E6BC40", Offset = "0x1E6BD41", VA = "0x1E6BC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007304")]
		[Address(RVA = "0x1E6BC50", Offset = "0x1E6BD51", VA = "0x1E6BC50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2E")]
		private object Current
		{
			[Token(Token = "0x6007305")]
			[Address(RVA = "0x1E6BCB0", Offset = "0x1E6BDB1", VA = "0x1E6BCB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076A9 RID: 30377
		[Token(Token = "0x4019690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076AA RID: 30378
		[Token(Token = "0x4019691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076AB RID: 30379
		[Token(Token = "0x4019692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterDataID id;

		// Token: 0x040076AC RID: 30380
		[Token(Token = "0x4019693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076AD RID: 30381
		[Token(Token = "0x4019694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isEnemy;

		// Token: 0x040076AE RID: 30382
		[Token(Token = "0x4019695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MonsterManager.<>c__DisplayClass54_0 <>8__1;

		// Token: 0x040076AF RID: 30383
		[Token(Token = "0x4019696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<GameObject, MonsterControllerBase> callBack;
	}

	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x20011F1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158820", Offset = "0x158921")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x0600320D RID: 12813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x1E6AB80", Offset = "0x1E6AC81", VA = "0x1E6AB80")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007307")]
		[Address(RVA = "0x1E6AB90", Offset = "0x1E6AC91", VA = "0x1E6AB90")]
		internal void <GetAsyncControllerModel>b__0(GameObject model, MonsterControllerBase controller)
		{
		}

		// Token: 0x040076B0 RID: 30384
		[Token(Token = "0x4019697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;

		// Token: 0x040076B1 RID: 30385
		[Token(Token = "0x4019698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject modelObject;
	}

	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x20011F2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158830", Offset = "0x158931")]
	private sealed class <GetAsyncControllerModel>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600320F RID: 12815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007308")]
		[Address(RVA = "0x1E69780", Offset = "0x1E69881", VA = "0x1E69780")]
		[DebuggerHidden]
		public <GetAsyncControllerModel>d__55(int <>1__state)
		{
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007309")]
		[Address(RVA = "0x1E6BCC0", Offset = "0x1E6BDC1", VA = "0x1E6BCC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000114A8 File Offset: 0x0000F6A8
		[Token(Token = "0x600730A")]
		[Address(RVA = "0x1E6BCD0", Offset = "0x1E6BDD1", VA = "0x1E6BCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D2F")]
		private object Current
		{
			[Token(Token = "0x600730B")]
			[Address(RVA = "0x1E6BFD0", Offset = "0x1E6C0D1", VA = "0x1E6BFD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730C")]
		[Address(RVA = "0x1E6BFE0", Offset = "0x1E6C0E1", VA = "0x1E6BFE0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D30")]
		private object Current
		{
			[Token(Token = "0x600730D")]
			[Address(RVA = "0x1E6C040", Offset = "0x1E6C141", VA = "0x1E6C040", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076B2 RID: 30386
		[Token(Token = "0x4019699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076B3 RID: 30387
		[Token(Token = "0x401969A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076B4 RID: 30388
		[Token(Token = "0x401969B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterType monsterType;

		// Token: 0x040076B5 RID: 30389
		[Token(Token = "0x401969C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076B6 RID: 30390
		[Token(Token = "0x401969D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MonsterStatusBase status;

		// Token: 0x040076B7 RID: 30391
		[Token(Token = "0x401969E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MonsterManager.<>c__DisplayClass55_0 <>8__1;

		// Token: 0x040076B8 RID: 30392
		[Token(Token = "0x401969F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<MonsterControllerBase> callBack;
	}

	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x20011F3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158840", Offset = "0x158941")]
	private sealed class <>c__DisplayClass57_0
	{
		// Token: 0x06003215 RID: 12821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730E")]
		[Address(RVA = "0x1E6ABD0", Offset = "0x1E6ACD1", VA = "0x1E6ABD0")]
		public <>c__DisplayClass57_0()
		{
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730F")]
		[Address(RVA = "0x1E6ABE0", Offset = "0x1E6ACE1", VA = "0x1E6ABE0")]
		internal void <GetAsyncSpcControllerModel>b__0(GameObject instance)
		{
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007310")]
		[Address(RVA = "0x1E6ABF0", Offset = "0x1E6ACF1", VA = "0x1E6ABF0")]
		internal void <GetAsyncSpcControllerModel>b__1(SpcMonsterController instance)
		{
		}

		// Token: 0x040076B9 RID: 30393
		[Token(Token = "0x40196A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject model;

		// Token: 0x040076BA RID: 30394
		[Token(Token = "0x40196A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpcMonsterController controller;
	}

	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x20011F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158850", Offset = "0x158951")]
	private sealed class <GetAsyncSpcControllerModel>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003218 RID: 12824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007311")]
		[Address(RVA = "0x1E698A0", Offset = "0x1E699A1", VA = "0x1E698A0")]
		[DebuggerHidden]
		public <GetAsyncSpcControllerModel>d__57(int <>1__state)
		{
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007312")]
		[Address(RVA = "0x1E6C7A0", Offset = "0x1E6C8A1", VA = "0x1E6C7A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x6007313")]
		[Address(RVA = "0x1E6C7B0", Offset = "0x1E6C8B1", VA = "0x1E6C7B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D31")]
		private object Current
		{
			[Token(Token = "0x6007314")]
			[Address(RVA = "0x1E6CA80", Offset = "0x1E6CB81", VA = "0x1E6CA80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007315")]
		[Address(RVA = "0x1E6CA90", Offset = "0x1E6CB91", VA = "0x1E6CA90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D32")]
		private object Current
		{
			[Token(Token = "0x6007316")]
			[Address(RVA = "0x1E6CAF0", Offset = "0x1E6CBF1", VA = "0x1E6CAF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076BB RID: 30395
		[Token(Token = "0x40196A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076BC RID: 30396
		[Token(Token = "0x40196A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076BD RID: 30397
		[Token(Token = "0x40196A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterDataID id;

		// Token: 0x040076BE RID: 30398
		[Token(Token = "0x40196A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076BF RID: 30399
		[Token(Token = "0x40196A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isEnemy;

		// Token: 0x040076C0 RID: 30400
		[Token(Token = "0x40196A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MonsterManager.<>c__DisplayClass57_0 <>8__1;

		// Token: 0x040076C1 RID: 30401
		[Token(Token = "0x40196A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<GameObject, SpcMonsterController> callBack;
	}

	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x20011F5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158860", Offset = "0x158961")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x0600321E RID: 12830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007317")]
		[Address(RVA = "0x1E6AC00", Offset = "0x1E6AD01", VA = "0x1E6AC00")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007318")]
		[Address(RVA = "0x1E6AC10", Offset = "0x1E6AD11", VA = "0x1E6AC10")]
		internal void <GetAsyncSpcControllerModel>b__0(GameObject model, SpcMonsterController controller)
		{
		}

		// Token: 0x040076C2 RID: 30402
		[Token(Token = "0x40196A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpcMonsterController monsterController;

		// Token: 0x040076C3 RID: 30403
		[Token(Token = "0x40196AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject modelObject;
	}

	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x20011F6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158870", Offset = "0x158971")]
	private sealed class <GetAsyncSpcControllerModel>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007319")]
		[Address(RVA = "0x1E69990", Offset = "0x1E69A91", VA = "0x1E69990")]
		[DebuggerHidden]
		public <GetAsyncSpcControllerModel>d__58(int <>1__state)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731A")]
		[Address(RVA = "0x1E6CB00", Offset = "0x1E6CC01", VA = "0x1E6CB00", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x600731B")]
		[Address(RVA = "0x1E6CB10", Offset = "0x1E6CC11", VA = "0x1E6CB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D33")]
		private object Current
		{
			[Token(Token = "0x600731C")]
			[Address(RVA = "0x1E6CD90", Offset = "0x1E6CE91", VA = "0x1E6CD90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731D")]
		[Address(RVA = "0x1E6CDA0", Offset = "0x1E6CEA1", VA = "0x1E6CDA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D34")]
		private object Current
		{
			[Token(Token = "0x600731E")]
			[Address(RVA = "0x1E6CE00", Offset = "0x1E6CF01", VA = "0x1E6CE00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076C4 RID: 30404
		[Token(Token = "0x40196AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076C5 RID: 30405
		[Token(Token = "0x40196AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076C6 RID: 30406
		[Token(Token = "0x40196AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076C7 RID: 30407
		[Token(Token = "0x40196AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterDataID id;

		// Token: 0x040076C8 RID: 30408
		[Token(Token = "0x40196AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isEnemy;

		// Token: 0x040076C9 RID: 30409
		[Token(Token = "0x40196B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass58_0 <>8__1;

		// Token: 0x040076CA RID: 30410
		[Token(Token = "0x40196B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<SpcMonsterController> callBack;
	}

	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x20011F7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158880", Offset = "0x158981")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x06003226 RID: 12838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731F")]
		[Address(RVA = "0x1E6AD30", Offset = "0x1E6AE31", VA = "0x1E6AD30")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007320")]
		[Address(RVA = "0x1E6AD40", Offset = "0x1E6AE41", VA = "0x1E6AD40")]
		internal void <LoadModel>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040076CB RID: 30411
		[Token(Token = "0x40196B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject instanceModel;

		// Token: 0x040076CC RID: 30412
		[Token(Token = "0x40196B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prefab id;

		// Token: 0x040076CD RID: 30413
		[Token(Token = "0x40196B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076CE RID: 30414
		[Token(Token = "0x40196B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isCompleted;
	}

	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x20011F8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158890", Offset = "0x158991")]
	private sealed class <LoadModel>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003228 RID: 12840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007321")]
		[Address(RVA = "0x1E69CD0", Offset = "0x1E69DD1", VA = "0x1E69CD0")]
		[DebuggerHidden]
		public <LoadModel>d__62(int <>1__state)
		{
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007322")]
		[Address(RVA = "0x1E6D2B0", Offset = "0x1E6D3B1", VA = "0x1E6D2B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[Token(Token = "0x6007323")]
		[Address(RVA = "0x1E6D2C0", Offset = "0x1E6D3C1", VA = "0x1E6D2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D35")]
		private object Current
		{
			[Token(Token = "0x6007324")]
			[Address(RVA = "0x1E6D490", Offset = "0x1E6D591", VA = "0x1E6D490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007325")]
		[Address(RVA = "0x1E6D4A0", Offset = "0x1E6D5A1", VA = "0x1E6D4A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600322D RID: 12845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D36")]
		private object Current
		{
			[Token(Token = "0x6007326")]
			[Address(RVA = "0x1E6D500", Offset = "0x1E6D601", VA = "0x1E6D500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076CF RID: 30415
		[Token(Token = "0x40196B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076D0 RID: 30416
		[Token(Token = "0x40196B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076D1 RID: 30417
		[Token(Token = "0x40196B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Prefab id;

		// Token: 0x040076D2 RID: 30418
		[Token(Token = "0x40196B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076D3 RID: 30419
		[Token(Token = "0x40196BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass62_0 <>8__1;

		// Token: 0x040076D4 RID: 30420
		[Token(Token = "0x40196BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<GameObject> callback;
	}

	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x20011F9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588A0", Offset = "0x1589A1")]
	private sealed class <>c__DisplayClass63_0
	{
		// Token: 0x0600322E RID: 12846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007327")]
		[Address(RVA = "0x1E6AEE0", Offset = "0x1E6AFE1", VA = "0x1E6AEE0")]
		public <>c__DisplayClass63_0()
		{
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x1E6AEF0", Offset = "0x1E6AFF1", VA = "0x1E6AEF0")]
		internal void <GetAsyncModel>b__0(GameObject prefab)
		{
		}

		// Token: 0x040076D5 RID: 30421
		[Token(Token = "0x40196BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject instantiate;
	}

	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x20011FA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588B0", Offset = "0x1589B1")]
	private sealed class <GetAsyncModel>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003230 RID: 12848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007329")]
		[Address(RVA = "0x1E69DD0", Offset = "0x1E69ED1", VA = "0x1E69DD0")]
		[DebuggerHidden]
		public <GetAsyncModel>d__63(int <>1__state)
		{
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732A")]
		[Address(RVA = "0x1E6C050", Offset = "0x1E6C151", VA = "0x1E6C050", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x600732B")]
		[Address(RVA = "0x1E6C060", Offset = "0x1E6C161", VA = "0x1E6C060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D37")]
		private object Current
		{
			[Token(Token = "0x600732C")]
			[Address(RVA = "0x1E6C390", Offset = "0x1E6C491", VA = "0x1E6C390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732D")]
		[Address(RVA = "0x1E6C3A0", Offset = "0x1E6C4A1", VA = "0x1E6C3A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D38")]
		private object Current
		{
			[Token(Token = "0x600732E")]
			[Address(RVA = "0x1E6C400", Offset = "0x1E6C501", VA = "0x1E6C400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076D6 RID: 30422
		[Token(Token = "0x40196BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076D7 RID: 30423
		[Token(Token = "0x40196BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076D8 RID: 30424
		[Token(Token = "0x40196BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076D9 RID: 30425
		[Token(Token = "0x40196C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterModelDataID id;

		// Token: 0x040076DA RID: 30426
		[Token(Token = "0x40196C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isEnemy;

		// Token: 0x040076DB RID: 30427
		[Token(Token = "0x40196C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass63_0 <>8__1;

		// Token: 0x040076DC RID: 30428
		[Token(Token = "0x40196C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isChangeUIScale;

		// Token: 0x040076DD RID: 30429
		[Token(Token = "0x40196C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int layer;

		// Token: 0x040076DE RID: 30430
		[Token(Token = "0x40196C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<GameObject> callback;

		// Token: 0x040076DF RID: 30431
		[Token(Token = "0x40196C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <scale>5__2;
	}

	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x20011FB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588C0", Offset = "0x1589C1")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x06003236 RID: 12854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732F")]
		[Address(RVA = "0x1E69F70", Offset = "0x1E6A071", VA = "0x1E69F70")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007330")]
		[Address(RVA = "0x1E6AF50", Offset = "0x1E6B051", VA = "0x1E6AF50")]
		internal void <GetModel>b__0(GameObject model)
		{
		}

		// Token: 0x040076E0 RID: 30432
		[Token(Token = "0x40196C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<MonsterModelDataID, GameObject> callback;

		// Token: 0x040076E1 RID: 30433
		[Token(Token = "0x40196C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MonsterModelDataID id;
	}

	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x20011FC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588D0", Offset = "0x1589D1")]
	private sealed class <>c__DisplayClass65_0
	{
		// Token: 0x06003238 RID: 12856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007331")]
		[Address(RVA = "0x1E6A110", Offset = "0x1E6A211", VA = "0x1E6A110")]
		public <>c__DisplayClass65_0()
		{
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007332")]
		[Address(RVA = "0x1E6AFD0", Offset = "0x1E6B0D1", VA = "0x1E6AFD0")]
		internal void <GetModel>b__0(GameObject model)
		{
		}

		// Token: 0x040076E2 RID: 30434
		[Token(Token = "0x40196C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<MonsterDataID, GameObject> callback;

		// Token: 0x040076E3 RID: 30435
		[Token(Token = "0x40196CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MonsterDataID id;
	}

	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x20011FD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588E0", Offset = "0x1589E1")]
	private sealed class <>c__DisplayClass67_0
	{
		// Token: 0x0600323A RID: 12858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007333")]
		[Address(RVA = "0x1E6B050", Offset = "0x1E6B151", VA = "0x1E6B050")]
		public <>c__DisplayClass67_0()
		{
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007334")]
		[Address(RVA = "0x1E6B060", Offset = "0x1E6B161", VA = "0x1E6B060")]
		internal void <LoadAsyncController>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040076E4 RID: 30436
		[Token(Token = "0x40196CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase instanceMonster;

		// Token: 0x040076E5 RID: 30437
		[Token(Token = "0x40196CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Prefab id;

		// Token: 0x040076E6 RID: 30438
		[Token(Token = "0x40196CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076E7 RID: 30439
		[Token(Token = "0x40196CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isCompleted;
	}

	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x20011FE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1588F0", Offset = "0x1589F1")]
	private sealed class <LoadAsyncController>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600323C RID: 12860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007335")]
		[Address(RVA = "0x1E6A1C0", Offset = "0x1E6A2C1", VA = "0x1E6A1C0")]
		[DebuggerHidden]
		public <LoadAsyncController>d__67(int <>1__state)
		{
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007336")]
		[Address(RVA = "0x1E6CE10", Offset = "0x1E6CF11", VA = "0x1E6CE10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x6007337")]
		[Address(RVA = "0x1E6CE20", Offset = "0x1E6CF21", VA = "0x1E6CE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D39")]
		private object Current
		{
			[Token(Token = "0x6007338")]
			[Address(RVA = "0x1E6CFF0", Offset = "0x1E6D0F1", VA = "0x1E6CFF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007339")]
		[Address(RVA = "0x1E6D000", Offset = "0x1E6D101", VA = "0x1E6D000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003241 RID: 12865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3A")]
		private object Current
		{
			[Token(Token = "0x600733A")]
			[Address(RVA = "0x1E6D060", Offset = "0x1E6D161", VA = "0x1E6D060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076E8 RID: 30440
		[Token(Token = "0x40196CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076E9 RID: 30441
		[Token(Token = "0x40196D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076EA RID: 30442
		[Token(Token = "0x40196D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Prefab id;

		// Token: 0x040076EB RID: 30443
		[Token(Token = "0x40196D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x040076EC RID: 30444
		[Token(Token = "0x40196D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass67_0 <>8__1;

		// Token: 0x040076ED RID: 30445
		[Token(Token = "0x40196D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<MonsterControllerBase> callback;
	}

	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x20011FF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158900", Offset = "0x158A01")]
	private sealed class <LoaderAsyncActionCodeData>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003242 RID: 12866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733B")]
		[Address(RVA = "0x1E6A290", Offset = "0x1E6A391", VA = "0x1E6A290")]
		[DebuggerHidden]
		public <LoaderAsyncActionCodeData>d__68(int <>1__state)
		{
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733C")]
		[Address(RVA = "0x1E6D510", Offset = "0x1E6D611", VA = "0x1E6D510", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x600733D")]
		[Address(RVA = "0x1E6D520", Offset = "0x1E6D621", VA = "0x1E6D520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3B")]
		private object Current
		{
			[Token(Token = "0x600733E")]
			[Address(RVA = "0x1E6D730", Offset = "0x1E6D831", VA = "0x1E6D730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733F")]
		[Address(RVA = "0x1E6D740", Offset = "0x1E6D841", VA = "0x1E6D740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3C")]
		private object Current
		{
			[Token(Token = "0x6007340")]
			[Address(RVA = "0x1E6D7A0", Offset = "0x1E6D8A1", VA = "0x1E6D7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076EE RID: 30446
		[Token(Token = "0x40196D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076EF RID: 30447
		[Token(Token = "0x40196D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076F0 RID: 30448
		[Token(Token = "0x40196D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076F1 RID: 30449
		[Token(Token = "0x40196D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Master actionCodeDataID;

		// Token: 0x040076F2 RID: 30450
		[Token(Token = "0x40196D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<MonsterActionCodeDataTableArray> callBack;
	}

	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x2001200")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158910", Offset = "0x158A11")]
	private sealed class <>c__DisplayClass69_0
	{
		// Token: 0x06003248 RID: 12872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007341")]
		[Address(RVA = "0x1E6B220", Offset = "0x1E6B321", VA = "0x1E6B220")]
		public <>c__DisplayClass69_0()
		{
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007342")]
		[Address(RVA = "0x1E6B230", Offset = "0x1E6B331", VA = "0x1E6B230")]
		internal void <LoadAsyncSpcController>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040076F3 RID: 30451
		[Token(Token = "0x40196DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpcMonsterController spcMonsterController;

		// Token: 0x040076F4 RID: 30452
		[Token(Token = "0x40196DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MonsterManager <>4__this;

		// Token: 0x040076F5 RID: 30453
		[Token(Token = "0x40196DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isCompleted;
	}

	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x2001201")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158920", Offset = "0x158A21")]
	private sealed class <LoadAsyncSpcController>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007343")]
		[Address(RVA = "0x1E6A360", Offset = "0x1E6A461", VA = "0x1E6A360")]
		[DebuggerHidden]
		public <LoadAsyncSpcController>d__69(int <>1__state)
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007344")]
		[Address(RVA = "0x1E6D070", Offset = "0x1E6D171", VA = "0x1E6D070", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x6007345")]
		[Address(RVA = "0x1E6D080", Offset = "0x1E6D181", VA = "0x1E6D080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3D")]
		private object Current
		{
			[Token(Token = "0x6007346")]
			[Address(RVA = "0x1E6D230", Offset = "0x1E6D331", VA = "0x1E6D230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007347")]
		[Address(RVA = "0x1E6D240", Offset = "0x1E6D341", VA = "0x1E6D240", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3E")]
		private object Current
		{
			[Token(Token = "0x6007348")]
			[Address(RVA = "0x1E6D2A0", Offset = "0x1E6D3A1", VA = "0x1E6D2A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076F6 RID: 30454
		[Token(Token = "0x40196DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076F7 RID: 30455
		[Token(Token = "0x40196DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076F8 RID: 30456
		[Token(Token = "0x40196DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterManager <>4__this;

		// Token: 0x040076F9 RID: 30457
		[Token(Token = "0x40196E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MonsterManager.<>c__DisplayClass69_0 <>8__1;

		// Token: 0x040076FA RID: 30458
		[Token(Token = "0x40196E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<SpcMonsterController> callback;
	}

	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x2001202")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158930", Offset = "0x158A31")]
	private sealed class <>c__DisplayClass70_0
	{
		// Token: 0x06003250 RID: 12880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007349")]
		[Address(RVA = "0x1E6B340", Offset = "0x1E6B441", VA = "0x1E6B340")]
		public <>c__DisplayClass70_0()
		{
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734A")]
		[Address(RVA = "0x1E6B350", Offset = "0x1E6B451", VA = "0x1E6B350")]
		internal void <GetAsyncController>b__0(MonsterControllerBase controller)
		{
		}

		// Token: 0x040076FB RID: 30459
		[Token(Token = "0x40196E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;
	}

	// Token: 0x020007A2 RID: 1954
	[Token(Token = "0x2001203")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158940", Offset = "0x158A41")]
	private sealed class <GetAsyncController>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734B")]
		[Address(RVA = "0x1E6A450", Offset = "0x1E6A551", VA = "0x1E6A450")]
		[DebuggerHidden]
		public <GetAsyncController>d__70(int <>1__state)
		{
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734C")]
		[Address(RVA = "0x1E6B380", Offset = "0x1E6B481", VA = "0x1E6B380", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x600734D")]
		[Address(RVA = "0x1E6B390", Offset = "0x1E6B491", VA = "0x1E6B390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3F")]
		private object Current
		{
			[Token(Token = "0x600734E")]
			[Address(RVA = "0x1E6B730", Offset = "0x1E6B831", VA = "0x1E6B730", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734F")]
		[Address(RVA = "0x1E6B740", Offset = "0x1E6B841", VA = "0x1E6B740", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D40")]
		private object Current
		{
			[Token(Token = "0x6007350")]
			[Address(RVA = "0x1E6B7A0", Offset = "0x1E6B8A1", VA = "0x1E6B7A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040076FC RID: 30460
		[Token(Token = "0x40196E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040076FD RID: 30461
		[Token(Token = "0x40196E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040076FE RID: 30462
		[Token(Token = "0x40196E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterDataID id;

		// Token: 0x040076FF RID: 30463
		[Token(Token = "0x40196E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x04007700 RID: 30464
		[Token(Token = "0x40196E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass70_0 <>8__1;

		// Token: 0x04007701 RID: 30465
		[Token(Token = "0x40196E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isEnemy;

		// Token: 0x04007702 RID: 30466
		[Token(Token = "0x40196E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<MonsterControllerBase> callback;

		// Token: 0x04007703 RID: 30467
		[Token(Token = "0x40196EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MonsterDataTable <monsterData>5__2;

		// Token: 0x04007704 RID: 30468
		[Token(Token = "0x40196EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MonsterModelData <modelData>5__3;
	}

	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x2001204")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158950", Offset = "0x158A51")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x06003258 RID: 12888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007351")]
		[Address(RVA = "0x1E6B360", Offset = "0x1E6B461", VA = "0x1E6B360")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007352")]
		[Address(RVA = "0x1E6B370", Offset = "0x1E6B471", VA = "0x1E6B370")]
		internal void <GetAsyncSpcController>b__0(SpcMonsterController controller)
		{
		}

		// Token: 0x04007705 RID: 30469
		[Token(Token = "0x40196EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpcMonsterController monsterController;
	}

	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x2001205")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158960", Offset = "0x158A61")]
	private sealed class <GetAsyncSpcController>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600325A RID: 12890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007353")]
		[Address(RVA = "0x1E6A540", Offset = "0x1E6A641", VA = "0x1E6A540")]
		[DebuggerHidden]
		public <GetAsyncSpcController>d__71(int <>1__state)
		{
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007354")]
		[Address(RVA = "0x1E6C410", Offset = "0x1E6C511", VA = "0x1E6C410", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x6007355")]
		[Address(RVA = "0x1E6C420", Offset = "0x1E6C521", VA = "0x1E6C420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D41")]
		private object Current
		{
			[Token(Token = "0x6007356")]
			[Address(RVA = "0x1E6C720", Offset = "0x1E6C821", VA = "0x1E6C720", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007357")]
		[Address(RVA = "0x1E6C730", Offset = "0x1E6C831", VA = "0x1E6C730", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D42")]
		private object Current
		{
			[Token(Token = "0x6007358")]
			[Address(RVA = "0x1E6C790", Offset = "0x1E6C891", VA = "0x1E6C790", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007706 RID: 30470
		[Token(Token = "0x40196ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007707 RID: 30471
		[Token(Token = "0x40196EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007708 RID: 30472
		[Token(Token = "0x40196EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterDataID id;

		// Token: 0x04007709 RID: 30473
		[Token(Token = "0x40196F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterManager <>4__this;

		// Token: 0x0400770A RID: 30474
		[Token(Token = "0x40196F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonsterManager.<>c__DisplayClass71_0 <>8__1;

		// Token: 0x0400770B RID: 30475
		[Token(Token = "0x40196F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isEnemy;

		// Token: 0x0400770C RID: 30476
		[Token(Token = "0x40196F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<SpcMonsterController> callback;

		// Token: 0x0400770D RID: 30477
		[Token(Token = "0x40196F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MonsterDataTable <monsterData>5__2;

		// Token: 0x0400770E RID: 30478
		[Token(Token = "0x40196F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MonsterModelData <modelData>5__3;
	}
}
