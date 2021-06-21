using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x020007B8 RID: 1976
[Token(Token = "0x200052F")]
public class GateController : MonoBehaviour
{
	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000585")]
	public Transform _Transform
	{
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x1F9E0C0", Offset = "0x1F9E1C1", VA = "0x1F9E0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4DA0", Offset = "0x1A4EA1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x1F9E0D0", Offset = "0x1F9E1D1", VA = "0x1F9E0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4DB0", Offset = "0x1A4EB1")]
		private set
		{
		}
	}

	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x060032DB RID: 13019 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060032DA RID: 13018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000586")]
	public GateEnemyController GateEnemy
	{
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x1F9E0F0", Offset = "0x1F9E1F1", VA = "0x1F9E0F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4DD0", Offset = "0x1A4ED1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x1F9E0E0", Offset = "0x1F9E1E1", VA = "0x1F9E0E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A4DC0", Offset = "0x1A4EC1")]
		private set
		{
		}
	}

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x060032DC RID: 13020 RVA: 0x00011790 File Offset: 0x0000F990
	[Token(Token = "0x17000587")]
	public bool IsGateStop
	{
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x1F9E100", Offset = "0x1F9E201", VA = "0x1F9E100")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x060032DD RID: 13021 RVA: 0x000117A8 File Offset: 0x0000F9A8
	[Token(Token = "0x17000588")]
	public bool IsGeteView
	{
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x1F9E110", Offset = "0x1F9E211", VA = "0x1F9E110")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x060032DE RID: 13022 RVA: 0x000117C0 File Offset: 0x0000F9C0
	[Token(Token = "0x17000589")]
	public bool IsGateOutSide
	{
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x1F9E120", Offset = "0x1F9E221", VA = "0x1F9E120")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x060032DF RID: 13023 RVA: 0x000117D8 File Offset: 0x0000F9D8
	[Token(Token = "0x1700058A")]
	public bool IsGateEnemyDead
	{
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x1F9E130", Offset = "0x1F9E231", VA = "0x1F9E130")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x060032E0 RID: 13024 RVA: 0x000117F0 File Offset: 0x0000F9F0
	[Token(Token = "0x1700058B")]
	public bool IsAllDeadEnemies
	{
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x1F9E140", Offset = "0x1F9E241", VA = "0x1F9E140")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x060032E1 RID: 13025 RVA: 0x00011808 File Offset: 0x0000FA08
	[Token(Token = "0x1700058C")]
	public int GetMaxSpawnNum
	{
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x1F9E210", Offset = "0x1F9E311", VA = "0x1F9E210")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x1F9E220", Offset = "0x1F9E321", VA = "0x1F9E220")]
	private void Awake()
	{
	}

	// Token: 0x060032E3 RID: 13027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x1F9E6F0", Offset = "0x1F9E7F1", VA = "0x1F9E6F0")]
	private void SetGateEnemyState(GateController.GateEnemyState gateState, bool isForce = false)
	{
	}

	// Token: 0x060032E4 RID: 13028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x1F9E230", Offset = "0x1F9E331", VA = "0x1F9E230")]
	private void SetupUpdateState()
	{
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x1F9E710", Offset = "0x1F9E811", VA = "0x1F9E710")]
	private void UpdateOutViewGate(float sqrMagnitudeToPlayer)
	{
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x1F9E970", Offset = "0x1F9EA71", VA = "0x1F9E970")]
	private void UpdateInViewGate(float sqrMagnitudeToPlayer)
	{
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x1F9EC30", Offset = "0x1F9ED31", VA = "0x1F9EC30")]
	private void UpdateInside(float sqrMagnitudeToPlayer)
	{
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A68")]
	[Address(RVA = "0x1F9ED80", Offset = "0x1F9EE81", VA = "0x1F9ED80")]
	private void UpdateOutside(float sqrMagnitudeToPlayer)
	{
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A69")]
	[Address(RVA = "0x1F9EDE0", Offset = "0x1F9EEE1", VA = "0x1F9EDE0")]
	private void UpdateAlive()
	{
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0x1F9EF60", Offset = "0x1F9F061", VA = "0x1F9EF60")]
	private void UpdateDead()
	{
	}

	// Token: 0x060032EB RID: 13035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0x1F9F050", Offset = "0x1F9F151", VA = "0x1F9F050")]
	private void OnDestroy()
	{
	}

	// Token: 0x060032EC RID: 13036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0x1F9F070", Offset = "0x1F9F171", VA = "0x1F9F070")]
	public void Initialize(GateDataTable gateDataTable, Action destroyCallback)
	{
	}

	// Token: 0x060032ED RID: 13037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0x1F9E750", Offset = "0x1F9E851", VA = "0x1F9E750")]
	private void CreateGateEnemy()
	{
	}

	// Token: 0x060032EE RID: 13038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0x1F9F1E0", Offset = "0x1F9F2E1", VA = "0x1F9F1E0")]
	public void MainUpdate()
	{
	}

	// Token: 0x060032EF RID: 13039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0x1F9F460", Offset = "0x1F9F561", VA = "0x1F9F460")]
	public void GateStop(bool isCallBack = false)
	{
	}

	// Token: 0x060032F0 RID: 13040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A70")]
	[Address(RVA = "0x1F9F030", Offset = "0x1F9F131", VA = "0x1F9F030")]
	public void GateRestart()
	{
	}

	// Token: 0x060032F1 RID: 13041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A71")]
	[Address(RVA = "0x1F9F770", Offset = "0x1F9F871", VA = "0x1F9F770")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4DE0", Offset = "0x1A4EE1")]
	private IEnumerator WaitRestrictInMonsterPosition()
	{
		return null;
	}

	// Token: 0x060032F2 RID: 13042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A72")]
	[Address(RVA = "0x1F9F820", Offset = "0x1F9F921", VA = "0x1F9F820")]
	public void RestrictInMonsterPosition()
	{
	}

	// Token: 0x060032F3 RID: 13043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x1F9F8B0", Offset = "0x1F9F9B1", VA = "0x1F9F8B0")]
	private void SetGateActive(bool isActive)
	{
	}

	// Token: 0x060032F4 RID: 13044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x1F9E9D0", Offset = "0x1F9EAD1", VA = "0x1F9E9D0")]
	private void DestroyGateEnemy(bool isCallback = false)
	{
	}

	// Token: 0x060032F5 RID: 13045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x1F9EB30", Offset = "0x1F9EC31", VA = "0x1F9EB30")]
	private void PlayerEnterGateArea()
	{
	}

	// Token: 0x060032F6 RID: 13046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x1F9ED10", Offset = "0x1F9EE11", VA = "0x1F9ED10")]
	private void PlayerExitGateArea()
	{
	}

	// Token: 0x060032F7 RID: 13047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x1F9FAC0", Offset = "0x1F9FBC1", VA = "0x1F9FAC0")]
	private void DeadGateEnemy(MonsterControllerBase gateEnemy)
	{
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x1F9FBC0", Offset = "0x1F9FCC1", VA = "0x1F9FBC0")]
	private void OnFinishDeadMonster(MonsterControllerBase monster)
	{
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x1F9FA40", Offset = "0x1F9FB41", VA = "0x1F9FA40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4E50", Offset = "0x1A4F51")]
	private IEnumerator SpawnEnemyMax()
	{
		return null;
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x1F9EDF0", Offset = "0x1F9EEF1", VA = "0x1F9EDF0")]
	private void SpawnEnemyInterval()
	{
	}

	// Token: 0x060032FB RID: 13051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x1F9F4F0", Offset = "0x1F9F5F1", VA = "0x1F9F4F0")]
	private void DestroyEnemyAll()
	{
	}

	// Token: 0x060032FC RID: 13052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x1F9FD50", Offset = "0x1F9FE51", VA = "0x1F9FD50")]
	public void DestoryEnemy(MonsterControllerBase enemy)
	{
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x1F9F9B0", Offset = "0x1F9FAB1", VA = "0x1F9F9B0")]
	private void CheckAllDeadEnemy(bool isCallback = true)
	{
	}

	// Token: 0x060032FE RID: 13054 RVA: 0x00011820 File Offset: 0x0000FA20
	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x1F9FFA0", Offset = "0x1FA00A1", VA = "0x1F9FFA0")]
	private int LotterySpawnIndex()
	{
		return 0;
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x1FA01B0", Offset = "0x1FA02B1", VA = "0x1FA01B0")]
	public static Vector3[] PatrollPointToVector3Array(PatrolPoint[] patrolPoints)
	{
		return null;
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x00011838 File Offset: 0x0000FA38
	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x1FA02C0", Offset = "0x1FA03C1", VA = "0x1FA02C0")]
	public static Vector3 GetTerritoryCenterPosition(Vector3[] patrolPoints)
	{
		return default(Vector3);
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x00011850 File Offset: 0x0000FA50
	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x1FA0420", Offset = "0x1FA0521", VA = "0x1FA0420")]
	public static Vector3 GetTerritoryCenterPosition(PatrolPoint[] patrolPoints)
	{
		return default(Vector3);
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x1F9F160", Offset = "0x1F9F261", VA = "0x1F9F160")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4EC0", Offset = "0x1A4FC1")]
	private static IEnumerator StaticGateEnemySpawnAsync(GateController spawner)
	{
		return null;
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x1F9FEF0", Offset = "0x1F9FFF1", VA = "0x1F9FEF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A4F30", Offset = "0x1A5031")]
	private static IEnumerator StaticSpawnEnemyAsync(GateController spawner, bool isIntervalSpawn, int spawnEnemyIndex = 0)
	{
		return null;
	}

	// Token: 0x06003304 RID: 13060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x1FA05F0", Offset = "0x1FA06F1", VA = "0x1FA05F0")]
	public GateController()
	{
	}

	// Token: 0x04007769 RID: 30569
	[Token(Token = "0x4006CC1")]
	private const float FadeInTime = 0.35f;

	// Token: 0x0400776A RID: 30570
	[Token(Token = "0x4006CC2")]
	private const float FadeOutTime = 0.2f;

	// Token: 0x0400776B RID: 30571
	[Token(Token = "0x4006CC3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float GateRevivalTime;

	// Token: 0x0400776C RID: 30572
	[Token(Token = "0x4006CC4")]
	private const float GateSpawnNormalRange = 2f;

	// Token: 0x0400776D RID: 30573
	[Token(Token = "0x4006CC5")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169A90", Offset = "0x169B91")]
	[SerializeField]
	public GateDataID GateDataID;

	// Token: 0x0400776E RID: 30574
	[Token(Token = "0x4006CC6")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169AE0", Offset = "0x169BE1")]
	[SerializeField]
	private float ViewGateRadius;

	// Token: 0x0400776F RID: 30575
	[Token(Token = "0x4006CC7")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169B30", Offset = "0x169C31")]
	[SerializeField]
	private float BattleAreaExitRadius;

	// Token: 0x04007770 RID: 30576
	[Token(Token = "0x4006CC8")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169B80", Offset = "0x169C81")]
	[SerializeField]
	private float BattleAreaEnterRadius;

	// Token: 0x04007771 RID: 30577
	[Token(Token = "0x4006CC9")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169BD0", Offset = "0x169CD1")]
	[SerializeField]
	private int MaxSpawnNum;

	// Token: 0x04007772 RID: 30578
	[Token(Token = "0x4006CCA")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169C20", Offset = "0x169D21")]
	[SerializeField]
	public EnemyPatrolPoints[] EnemyPatrolPoints;

	// Token: 0x04007773 RID: 30579
	[Token(Token = "0x4006CCB")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169C70", Offset = "0x169D71")]
	[SerializeField]
	private GateMovePoint[] GateMovePoints;

	// Token: 0x04007774 RID: 30580
	[Token(Token = "0x4006CCC")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169CC0", Offset = "0x169DC1")]
	public GateDataTable CurrentGateDataTable;

	// Token: 0x04007775 RID: 30581
	[Token(Token = "0x4006CCD")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169D00", Offset = "0x169E01")]
	public GateStatusDataTable CurrentGateStatusDataTable;

	// Token: 0x04007776 RID: 30582
	[Token(Token = "0x4006CCE")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169D40", Offset = "0x169E41")]
	private Transform <_Transform>k__BackingField;

	// Token: 0x04007777 RID: 30583
	[Token(Token = "0x4006CCF")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169D50", Offset = "0x169E51")]
	private GateEnemyController <GateEnemy>k__BackingField;

	// Token: 0x04007778 RID: 30584
	[Token(Token = "0x4006CD0")]
	[FieldOffset(Offset = "0x88")]
	public Dictionary<MonsterControllerBase, int> SpawnedEnemyMap;

	// Token: 0x04007779 RID: 30585
	[Token(Token = "0x4006CD1")]
	[FieldOffset(Offset = "0x90")]
	public OnPlayerEnterGateArea OnPlayerEnterGateArea;

	// Token: 0x0400777A RID: 30586
	[Token(Token = "0x4006CD2")]
	[FieldOffset(Offset = "0x98")]
	public OnPlayerExitGateArea OnPlayerExitGateArea;

	// Token: 0x0400777B RID: 30587
	[Token(Token = "0x4006CD3")]
	[FieldOffset(Offset = "0xA0")]
	public OnAllEnemyDead OnAllEnemyDead;

	// Token: 0x0400777C RID: 30588
	[Token(Token = "0x4006CD4")]
	[FieldOffset(Offset = "0xA8")]
	public OnGateEnemyDead OnGateEnemyDead;

	// Token: 0x0400777D RID: 30589
	[Token(Token = "0x4006CD5")]
	[FieldOffset(Offset = "0xB0")]
	public Action OnDestroyCallback;

	// Token: 0x0400777E RID: 30590
	[Token(Token = "0x4006CD6")]
	[FieldOffset(Offset = "0xB8")]
	private float CurrentEnemySpawnTimer;

	// Token: 0x0400777F RID: 30591
	[Token(Token = "0x4006CD7")]
	[FieldOffset(Offset = "0xBC")]
	private float DeadGateEnemyTime;

	// Token: 0x04007780 RID: 30592
	[Token(Token = "0x4006CD8")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine MaxSpawnCoroutine;

	// Token: 0x04007781 RID: 30593
	[Token(Token = "0x4006CD9")]
	[FieldOffset(Offset = "0xC8")]
	private int DifficultyMaxSpawnNum;

	// Token: 0x04007782 RID: 30594
	[Token(Token = "0x4006CDA")]
	[FieldOffset(Offset = "0xCC")]
	private bool IsInit;

	// Token: 0x04007783 RID: 30595
	[Token(Token = "0x4006CDB")]
	[FieldOffset(Offset = "0xD0")]
	private GateController.BetweenPlayerState BPState;

	// Token: 0x04007784 RID: 30596
	[Token(Token = "0x4006CDC")]
	[FieldOffset(Offset = "0xD4")]
	private GateController.GateEnemyState GEState;

	// Token: 0x04007785 RID: 30597
	[Token(Token = "0x4006CDD")]
	[FieldOffset(Offset = "0xD8")]
	private NavMeshHit NavMeshHit;

	// Token: 0x04007786 RID: 30598
	[Token(Token = "0x4006CDE")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<int, Action<float>> UpdateBetweenPlayerStateDic;

	// Token: 0x04007787 RID: 30599
	[Token(Token = "0x4006CDF")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<int, Action> UpdateGateEnemyStateDic;

	// Token: 0x04007788 RID: 30600
	[Token(Token = "0x4006CE0")]
	[FieldOffset(Offset = "0x110")]
	private float OutViewGateRadius;

	// Token: 0x04007789 RID: 30601
	[Token(Token = "0x4006CE1")]
	[FieldOffset(Offset = "0x118")]
	private Coroutine CreateGateCoroutine;

	// Token: 0x0400778A RID: 30602
	[Token(Token = "0x4006CE2")]
	[FieldOffset(Offset = "0x120")]
	private bool IsDestroyGate;

	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x200120F")]
	private enum BetweenPlayerState
	{
		// Token: 0x0400778C RID: 30604
		[Token(Token = "0x4019712")]
		None,
		// Token: 0x0400778D RID: 30605
		[Token(Token = "0x4019713")]
		OutViewGate,
		// Token: 0x0400778E RID: 30606
		[Token(Token = "0x4019714")]
		InViewGate,
		// Token: 0x0400778F RID: 30607
		[Token(Token = "0x4019715")]
		Outside,
		// Token: 0x04007790 RID: 30608
		[Token(Token = "0x4019716")]
		Inside
	}

	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x2001210")]
	private enum GateEnemyState
	{
		// Token: 0x04007792 RID: 30610
		[Token(Token = "0x4019718")]
		None,
		// Token: 0x04007793 RID: 30611
		[Token(Token = "0x4019719")]
		NotExist,
		// Token: 0x04007794 RID: 30612
		[Token(Token = "0x401971A")]
		Alive,
		// Token: 0x04007795 RID: 30613
		[Token(Token = "0x401971B")]
		Dead
	}

	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x2001211")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589C0", Offset = "0x158AC1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06003307 RID: 13063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736B")]
		[Address(RVA = "0x1FA0800", Offset = "0x1FA0901", VA = "0x1FA0800")]
		public <>c()
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736C")]
		[Address(RVA = "0x1FA0810", Offset = "0x1FA0911", VA = "0x1FA0810")]
		internal void <SetupUpdateState>b__56_0(float sqr)
		{
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736D")]
		[Address(RVA = "0x1FA0820", Offset = "0x1FA0921", VA = "0x1FA0820")]
		internal void <SetupUpdateState>b__56_1()
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736E")]
		[Address(RVA = "0x1FA0830", Offset = "0x1FA0931", VA = "0x1FA0830")]
		internal void <SetupUpdateState>b__56_2()
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736F")]
		[Address(RVA = "0x1FA0840", Offset = "0x1FA0941", VA = "0x1FA0840")]
		internal void <StaticSpawnEnemyAsync>b__87_2(ParticleSystem particleSystem)
		{
		}

		// Token: 0x04007796 RID: 30614
		[Token(Token = "0x401971C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GateController.<>c <>9;

		// Token: 0x04007797 RID: 30615
		[Token(Token = "0x401971D")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> <>9__56_0;

		// Token: 0x04007798 RID: 30616
		[Token(Token = "0x401971E")]
		[FieldOffset(Offset = "0x10")]
		public static Action <>9__56_1;

		// Token: 0x04007799 RID: 30617
		[Token(Token = "0x401971F")]
		[FieldOffset(Offset = "0x18")]
		public static Action <>9__56_2;

		// Token: 0x0400779A RID: 30618
		[Token(Token = "0x4019720")]
		[FieldOffset(Offset = "0x20")]
		public static UnityAction<ParticleSystem> <>9__87_2;
	}

	// Token: 0x020007BC RID: 1980
	[Token(Token = "0x2001212")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589D0", Offset = "0x158AD1")]
	private sealed class <>c__DisplayClass69_0
	{
		// Token: 0x0600330C RID: 13068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007370")]
		[Address(RVA = "0x1FA08D0", Offset = "0x1FA09D1", VA = "0x1FA08D0")]
		public <>c__DisplayClass69_0()
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007371")]
		[Address(RVA = "0x1FA08E0", Offset = "0x1FA09E1", VA = "0x1FA08E0")]
		internal void <WaitRestrictInMonsterPosition>b__0()
		{
		}

		// Token: 0x0400779B RID: 30619
		[Token(Token = "0x4019721")]
		[FieldOffset(Offset = "0x10")]
		public KeyValuePair<MonsterControllerBase, int> enemy;
	}

	// Token: 0x020007BD RID: 1981
	[Token(Token = "0x2001213")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589E0", Offset = "0x158AE1")]
	private sealed class <WaitRestrictInMonsterPosition>d__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007372")]
		[Address(RVA = "0x1F9F7F0", Offset = "0x1F9F8F1", VA = "0x1F9F7F0")]
		[DebuggerHidden]
		public <WaitRestrictInMonsterPosition>d__69(int <>1__state)
		{
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007373")]
		[Address(RVA = "0x1FA2060", Offset = "0x1FA2161", VA = "0x1FA2060", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6007374")]
		[Address(RVA = "0x1FA2070", Offset = "0x1FA2171", VA = "0x1FA2070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D43")]
		private object Current
		{
			[Token(Token = "0x6007375")]
			[Address(RVA = "0x1FA25F0", Offset = "0x1FA26F1", VA = "0x1FA25F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007376")]
		[Address(RVA = "0x1FA2600", Offset = "0x1FA2701", VA = "0x1FA2600", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D44")]
		private object Current
		{
			[Token(Token = "0x6007377")]
			[Address(RVA = "0x1FA2660", Offset = "0x1FA2761", VA = "0x1FA2660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400779C RID: 30620
		[Token(Token = "0x4019722")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400779D RID: 30621
		[Token(Token = "0x4019723")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400779E RID: 30622
		[Token(Token = "0x4019724")]
		[FieldOffset(Offset = "0x20")]
		public GateController <>4__this;
	}

	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x2001214")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1589F0", Offset = "0x158AF1")]
	private sealed class <SpawnEnemyMax>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003314 RID: 13076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007378")]
		[Address(RVA = "0x1F9FEC0", Offset = "0x1F9FFC1", VA = "0x1F9FEC0")]
		[DebuggerHidden]
		public <SpawnEnemyMax>d__77(int <>1__state)
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007379")]
		[Address(RVA = "0x1FA0B10", Offset = "0x1FA0C11", VA = "0x1FA0B10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x600737A")]
		[Address(RVA = "0x1FA0B20", Offset = "0x1FA0C21", VA = "0x1FA0B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D45")]
		private object Current
		{
			[Token(Token = "0x600737B")]
			[Address(RVA = "0x1FA0CB0", Offset = "0x1FA0DB1", VA = "0x1FA0CB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600737C")]
		[Address(RVA = "0x1FA0CC0", Offset = "0x1FA0DC1", VA = "0x1FA0CC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D46")]
		private object Current
		{
			[Token(Token = "0x600737D")]
			[Address(RVA = "0x1FA0D20", Offset = "0x1FA0E21", VA = "0x1FA0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400779F RID: 30623
		[Token(Token = "0x4019725")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040077A0 RID: 30624
		[Token(Token = "0x4019726")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040077A1 RID: 30625
		[Token(Token = "0x4019727")]
		[FieldOffset(Offset = "0x20")]
		public GateController <>4__this;

		// Token: 0x040077A2 RID: 30626
		[Token(Token = "0x4019728")]
		[FieldOffset(Offset = "0x28")]
		private int <spawnCount>5__2;

		// Token: 0x040077A3 RID: 30627
		[Token(Token = "0x4019729")]
		[FieldOffset(Offset = "0x2C")]
		private int <i>5__3;
	}

	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x2001215")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A00", Offset = "0x158B01")]
	private sealed class <>c__DisplayClass79_0
	{
		// Token: 0x0600331A RID: 13082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600737E")]
		[Address(RVA = "0x1F9FF90", Offset = "0x1FA0091", VA = "0x1F9FF90")]
		public <>c__DisplayClass79_0()
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600737F")]
		[Address(RVA = "0x1FA0940", Offset = "0x1FA0A41", VA = "0x1FA0940")]
		internal void <DestroyEnemyAll>b__0()
		{
		}

		// Token: 0x040077A4 RID: 30628
		[Token(Token = "0x401972A")]
		[FieldOffset(Offset = "0x10")]
		public KeyValuePair<MonsterControllerBase, int> enemy;
	}

	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x2001216")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A10", Offset = "0x158B11")]
	private sealed class <>c__DisplayClass86_0
	{
		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007380")]
		[Address(RVA = "0x1FA09A0", Offset = "0x1FA0AA1", VA = "0x1FA09A0")]
		public <>c__DisplayClass86_0()
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007381")]
		[Address(RVA = "0x1FA09B0", Offset = "0x1FA0AB1", VA = "0x1FA09B0")]
		internal void <StaticGateEnemySpawnAsync>b__0(MonsterControllerBase monster)
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007382")]
		[Address(RVA = "0x1FA0A50", Offset = "0x1FA0B51", VA = "0x1FA0A50")]
		internal void <StaticGateEnemySpawnAsync>b__1(MonsterControllerBase mcb)
		{
		}

		// Token: 0x040077A5 RID: 30629
		[Token(Token = "0x401972B")]
		[FieldOffset(Offset = "0x10")]
		public GateEnemyController gate;

		// Token: 0x040077A6 RID: 30630
		[Token(Token = "0x401972C")]
		[FieldOffset(Offset = "0x18")]
		public GateController spawner;
	}

	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x2001217")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A20", Offset = "0x158B21")]
	private sealed class <StaticGateEnemySpawnAsync>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600331F RID: 13087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007383")]
		[Address(RVA = "0x1FA0590", Offset = "0x1FA0691", VA = "0x1FA0590")]
		[DebuggerHidden]
		public <StaticGateEnemySpawnAsync>d__86(int <>1__state)
		{
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007384")]
		[Address(RVA = "0x1FA0D30", Offset = "0x1FA0E31", VA = "0x1FA0D30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x6007385")]
		[Address(RVA = "0x1FA0D40", Offset = "0x1FA0E41", VA = "0x1FA0D40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D47")]
		private object Current
		{
			[Token(Token = "0x6007386")]
			[Address(RVA = "0x1FA11A0", Offset = "0x1FA12A1", VA = "0x1FA11A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007387")]
		[Address(RVA = "0x1FA11B0", Offset = "0x1FA12B1", VA = "0x1FA11B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D48")]
		private object Current
		{
			[Token(Token = "0x6007388")]
			[Address(RVA = "0x1FA1210", Offset = "0x1FA1311", VA = "0x1FA1210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040077A7 RID: 30631
		[Token(Token = "0x401972D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040077A8 RID: 30632
		[Token(Token = "0x401972E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040077A9 RID: 30633
		[Token(Token = "0x401972F")]
		[FieldOffset(Offset = "0x20")]
		public GateController spawner;

		// Token: 0x040077AA RID: 30634
		[Token(Token = "0x4019730")]
		[FieldOffset(Offset = "0x28")]
		private GateController.<>c__DisplayClass86_0 <>8__1;
	}

	// Token: 0x020007C2 RID: 1986
	[Token(Token = "0x2001218")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A30", Offset = "0x158B31")]
	private sealed class <>c__DisplayClass87_0
	{
		// Token: 0x06003325 RID: 13093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007389")]
		[Address(RVA = "0x1FA0AE0", Offset = "0x1FA0BE1", VA = "0x1FA0AE0")]
		public <>c__DisplayClass87_0()
		{
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738A")]
		[Address(RVA = "0x1FA0AF0", Offset = "0x1FA0BF1", VA = "0x1FA0AF0")]
		internal void <StaticSpawnEnemyAsync>b__0(MonsterControllerBase monster)
		{
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738B")]
		[Address(RVA = "0x1FA0B00", Offset = "0x1FA0C01", VA = "0x1FA0B00")]
		internal void <StaticSpawnEnemyAsync>b__1(EnemyBehaviorController behaviorcontroller)
		{
		}

		// Token: 0x040077AB RID: 30635
		[Token(Token = "0x4019731")]
		[FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterController;

		// Token: 0x040077AC RID: 30636
		[Token(Token = "0x4019732")]
		[FieldOffset(Offset = "0x18")]
		public EnemyBehaviorController enemyBehaviorController;
	}

	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x2001219")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A40", Offset = "0x158B41")]
	private sealed class <StaticSpawnEnemyAsync>d__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003328 RID: 13096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738C")]
		[Address(RVA = "0x1FA05C0", Offset = "0x1FA06C1", VA = "0x1FA05C0")]
		[DebuggerHidden]
		public <StaticSpawnEnemyAsync>d__87(int <>1__state)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600738D")]
		[Address(RVA = "0x1FA1220", Offset = "0x1FA1321", VA = "0x1FA1220", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x600738E")]
		[Address(RVA = "0x1FA1230", Offset = "0x1FA1331", VA = "0x1FA1230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D49")]
		private object Current
		{
			[Token(Token = "0x600738F")]
			[Address(RVA = "0x1FA1FE0", Offset = "0x1FA20E1", VA = "0x1FA1FE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007390")]
		[Address(RVA = "0x1FA1FF0", Offset = "0x1FA20F1", VA = "0x1FA1FF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600332D RID: 13101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4A")]
		private object Current
		{
			[Token(Token = "0x6007391")]
			[Address(RVA = "0x1FA2050", Offset = "0x1FA2151", VA = "0x1FA2050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040077AD RID: 30637
		[Token(Token = "0x4019733")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040077AE RID: 30638
		[Token(Token = "0x4019734")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040077AF RID: 30639
		[Token(Token = "0x4019735")]
		[FieldOffset(Offset = "0x20")]
		public GateController spawner;

		// Token: 0x040077B0 RID: 30640
		[Token(Token = "0x4019736")]
		[FieldOffset(Offset = "0x28")]
		public bool isIntervalSpawn;

		// Token: 0x040077B1 RID: 30641
		[Token(Token = "0x4019737")]
		[FieldOffset(Offset = "0x2C")]
		public int spawnEnemyIndex;

		// Token: 0x040077B2 RID: 30642
		[Token(Token = "0x4019738")]
		[FieldOffset(Offset = "0x30")]
		private GateController.<>c__DisplayClass87_0 <>8__1;

		// Token: 0x040077B3 RID: 30643
		[Token(Token = "0x4019739")]
		[FieldOffset(Offset = "0x38")]
		private int <spawnIndex>5__2;

		// Token: 0x040077B4 RID: 30644
		[Token(Token = "0x401973A")]
		[FieldOffset(Offset = "0x40")]
		private PatrolPoint[] <patrolPoints>5__3;

		// Token: 0x040077B5 RID: 30645
		[Token(Token = "0x401973B")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 <position>5__4;
	}
}
