using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using BehaviorDesigner.Runtime;
using BossData;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Token(Token = "0x20000F7")]
public class BehaviorTreeManager : SingletonMonoBehaviour<BehaviorTreeManager>
{
	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000163")]
	public EnemyPatrolData EnemyPatrolData
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x244C280", Offset = "0x244C381", VA = "0x244C280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A550", Offset = "0x19A651")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x244C290", Offset = "0x244C391", VA = "0x244C290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A560", Offset = "0x19A661")]
		private set
		{
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000164")]
	public MonsterActionBehaviorDataTable MonsterActionBehaviorDataTable
	{
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x244C2A0", Offset = "0x244C3A1", VA = "0x244C2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A570", Offset = "0x19A671")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x244C2B0", Offset = "0x244C3B1", VA = "0x244C2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A580", Offset = "0x19A681")]
		private set
		{
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000165")]
	public NPCActionBehaviorDataTable NPCActionBehaviorDataTable
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x244C2C0", Offset = "0x244C3C1", VA = "0x244C2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A590", Offset = "0x19A691")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x244C2D0", Offset = "0x244C3D1", VA = "0x244C2D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A5A0", Offset = "0x19A6A1")]
		private set
		{
		}
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000596")]
	[Address(RVA = "0x244C2E0", Offset = "0x244C3E1", VA = "0x244C2E0")]
	private void SetupEnemyPatrollData()
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000597")]
	[Address(RVA = "0x244C3A0", Offset = "0x244C4A1", VA = "0x244C3A0")]
	public void SetupMonsterActionBehaviorDataTable()
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000598")]
	[Address(RVA = "0x244C460", Offset = "0x244C561", VA = "0x244C460")]
	public void SetupNPCActionBehaviorDataTable()
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000599")]
	[Address(RVA = "0x244C520", Offset = "0x244C621", VA = "0x244C520")]
	private void LoadBossDataAsset(Master id, Action<BossDataAssetBase> callBack)
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059A")]
	[Address(RVA = "0x244C690", Offset = "0x244C791", VA = "0x244C690")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A5B0", Offset = "0x19A6B1")]
	private IEnumerator CreateAsyncEnemyBehaviorParameter(Action<BehaviorTreeManager.EnemyBehaviorParameter> callBack)
	{
		return null;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059B")]
	[Address(RVA = "0x244C760", Offset = "0x244C861", VA = "0x244C760")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A620", Offset = "0x19A721")]
	private IEnumerator GetAsyncEnemyBehavior(GameObject controller, Action<EnemyBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00004638 File Offset: 0x00002838
	[Token(Token = "0x600059C")]
	[Address(RVA = "0x244C840", Offset = "0x244C941", VA = "0x244C840")]
	private int GetUseEnemyBehaviorCount()
	{
		return 0;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059D")]
	[Address(RVA = "0x244C900", Offset = "0x244CA01", VA = "0x244C900")]
	public void ReleseEnemyBehavior(int id)
	{
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x244CA30", Offset = "0x244CB31", VA = "0x244CA30")]
	private void SetupEnemyBehaviorParameter()
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600059F")]
	[Address(RVA = "0x244CCC0", Offset = "0x244CDC1", VA = "0x244CCC0")]
	private void SetupEnemyBehavior()
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x244CD80", Offset = "0x244CE81", VA = "0x244CD80")]
	private GameObject CreateBehaviorGameObject(string name)
	{
		return null;
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x244CCD0", Offset = "0x244CDD1", VA = "0x244CCD0")]
	private void LoadEnemyBehavior()
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x244CE30", Offset = "0x244CF31", VA = "0x244CE30")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A690", Offset = "0x19A791")]
	public IEnumerator CreateAsyncEnemyBehavior(global::Character character, [Optional] Action<EnemyBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x244CF10", Offset = "0x244D011", VA = "0x244CF10")]
	public void CreateEnemyBehavior(global::Character character, [Optional] Action<EnemyBehaviorController> callBack)
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x244CF40", Offset = "0x244D041", VA = "0x244CF40")]
	private void AddBossBehavior(int id, BossBehaviorController behavior)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x244CFE0", Offset = "0x244D0E1", VA = "0x244CFE0")]
	public void RemoveBossBehavior(int id)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x244D0E0", Offset = "0x244D1E1", VA = "0x244D0E0")]
	private void RemoveAllBossBehavior()
	{
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x244D280", Offset = "0x244D381", VA = "0x244D280")]
	private void SetupBossBehavior()
	{
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x244D300", Offset = "0x244D401", VA = "0x244D300")]
	private void LoadBossBehavior()
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x244D3B0", Offset = "0x244D4B1", VA = "0x244D3B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A700", Offset = "0x19A801")]
	public IEnumerator CreateAsyncBossBehavior(MonsterControllerBase monsterController, Action<BossBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x244D490", Offset = "0x244D591", VA = "0x244D490")]
	public void CreateBossBehavior(MonsterControllerBase monsterController, Action<BossBehaviorController> callBack)
	{
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x244D4C0", Offset = "0x244D5C1", VA = "0x244D4C0")]
	private void AddPartnerNPCBehavior(int id, PartnerNPCBehaviorController behavior)
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x244D560", Offset = "0x244D661", VA = "0x244D560")]
	public PartnerNPCBehaviorController GetPartnerNPCBehavior(int id)
	{
		return null;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x244D600", Offset = "0x244D701", VA = "0x244D600")]
	public void RemovePartnerNPCBehavior(int id)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x244D6F0", Offset = "0x244D7F1", VA = "0x244D6F0")]
	private void RemoveAllPartnerBehavior()
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x244D890", Offset = "0x244D991", VA = "0x244D890")]
	private void SetupPartnerNPCBehavior()
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x244D910", Offset = "0x244DA11", VA = "0x244D910")]
	private void LoadPartnerNPCBehavior()
	{
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x244D9C0", Offset = "0x244DAC1", VA = "0x244D9C0")]
	public void CreatePartnerNPCBehavior(global::Character character, [Optional] Action<PartnerNPCBehaviorController> callBack)
	{
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x244DC10", Offset = "0x244DD11", VA = "0x244DC10")]
	public MonsterBehaviorController GetPartnerMonsterBehaviorController(int instanceID)
	{
		return null;
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x244DCB0", Offset = "0x244DDB1", VA = "0x244DCB0")]
	public void RemovePartnerMonsterBehavior(int id)
	{
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x244DDA0", Offset = "0x244DEA1", VA = "0x244DDA0")]
	private void RemoveAllPartnerMonsterBehavior()
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x244DF40", Offset = "0x244E041", VA = "0x244DF40")]
	private void SetupPartnerMonsterBehavior()
	{
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x244DFC0", Offset = "0x244E0C1", VA = "0x244DFC0")]
	private void LoadPartnerBehavior()
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x244E070", Offset = "0x244E171", VA = "0x244E070")]
	public void CreatePartnerMonsterBehavior(global::Character character, [Optional] Action<PartnerMonsterBehaviorController> callBack)
	{
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x244E2B0", Offset = "0x244E3B1", VA = "0x244E2B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A770", Offset = "0x19A871")]
	public IEnumerator CreateAsyncPetMonsterBehavior(global::Character character, [Optional] Action<PartnerMonsterBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x244E390", Offset = "0x244E491", VA = "0x244E390")]
	public void CreatePetMonsterBehavior(global::Character character, [Optional] Action<PartnerMonsterBehaviorController> callBack)
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x244E3C0", Offset = "0x244E4C1", VA = "0x244E3C0")]
	private void SetupPartnerFarmMonsterBehavior()
	{
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x244E440", Offset = "0x244E541", VA = "0x244E440")]
	private void LoadPartnerFarmBehavior()
	{
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x244E4F0", Offset = "0x244E5F1", VA = "0x244E4F0")]
	public void CreatePartnerFarmMonsterBehavior(global::Character character, [Optional] Action<FarmMonsterBehaviorController> callBack)
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005BD")]
	[Address(RVA = "0x244E730", Offset = "0x244E831", VA = "0x244E730")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19A7E0", Offset = "0x19A8E1")]
	public IEnumerator CreateAsyncSnowmanBehavior(MonsterControllerBase character, [Optional] Action<EnemyBehaviorController> callBack)
	{
		return null;
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x244E810", Offset = "0x244E911", VA = "0x244E810")]
	public void CreateSnowmanBehavior(MonsterControllerBase character, [Optional] Action<EnemyBehaviorController> callBack)
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x244E840", Offset = "0x244E941", VA = "0x244E840")]
	private void UpdateBehaviorManager()
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x244E940", Offset = "0x244EA41", VA = "0x244E940")]
	public void OnAfterGameDataLoad()
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x244EA00", Offset = "0x244EB01", VA = "0x244EA00")]
	public void OnSceneLoadComplete()
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00004650 File Offset: 0x00002850
	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x244EA10", Offset = "0x244EB11", VA = "0x244EA10")]
	public bool IsCompleted()
	{
		return default(bool);
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x244EA70", Offset = "0x244EB71", VA = "0x244EA70", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x244EC70", Offset = "0x244ED71", VA = "0x244EC70")]
	private void Update()
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x244EC80", Offset = "0x244ED81", VA = "0x244EC80")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x244ED80", Offset = "0x244EE81", VA = "0x244ED80")]
	public BehaviorTreeManager()
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x244EE40", Offset = "0x244EF41", VA = "0x244EE40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A850", Offset = "0x19A951")]
	private void <SetupEnemyBehaviorParameter>b__27_0(BehaviorTreeManager.EnemyBehaviorParameter param)
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x244EEB0", Offset = "0x244EFB1", VA = "0x244EEB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A860", Offset = "0x19A961")]
	private void <LoadEnemyBehavior>b__30_0(AssetHandle<ExternalBehavior> handle)
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x244EF30", Offset = "0x244F031", VA = "0x244EF30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A870", Offset = "0x19A971")]
	private void <LoadBossBehavior>b__39_0(AssetHandle<ExternalBehavior> handle)
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x244EFB0", Offset = "0x244F0B1", VA = "0x244EFB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A880", Offset = "0x19A981")]
	private void <LoadPartnerNPCBehavior>b__49_0(AssetHandle<ExternalBehavior> handle)
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x244F030", Offset = "0x244F131", VA = "0x244F030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A890", Offset = "0x19A991")]
	private void <LoadPartnerBehavior>b__57_0(AssetHandle<ExternalBehavior> handle)
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x244F0B0", Offset = "0x244F1B1", VA = "0x244F0B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A8A0", Offset = "0x19A9A1")]
	private void <LoadPartnerFarmBehavior>b__63_0(AssetHandle<ExternalBehavior> handle)
	{
	}

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BDE0", Offset = "0x15BEE1")]
	private EnemyPatrolData <EnemyPatrolData>k__BackingField;

	// Token: 0x040003A1 RID: 929
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BDF0", Offset = "0x15BEF1")]
	private MonsterActionBehaviorDataTable <MonsterActionBehaviorDataTable>k__BackingField;

	// Token: 0x040003A2 RID: 930
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BE00", Offset = "0x15BF01")]
	private NPCActionBehaviorDataTable <NPCActionBehaviorDataTable>k__BackingField;

	// Token: 0x040003A3 RID: 931
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<Master, BossDataAssetBase> BossDataAssetBaseDic;

	// Token: 0x040003A4 RID: 932
	[Token(Token = "0x40002ED")]
	private const int MaxEnemyBehaviorPoolCount = 20;

	// Token: 0x040003A5 RID: 933
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ExternalBehavior EnemyExternalBehavior;

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<BehaviorTreeManager.EnemyBehaviorParameter> EnemyBehaviorParameterPoolList;

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<BehaviorTreeManager.EnemyBehaviorParameter> DestroyEnemyBehaviorParameterList;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ExternalBehavior BossExternalBehavior;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<int, BossBehaviorController> BossBehaviorControllerDic;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ExternalBehavior PartnerNPCExternalBehavior;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Dictionary<int, PartnerNPCBehaviorController> PartnerNPCBehaviorControllerDic;

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ExternalBehavior PartnerMonsterExternalBehavior;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<int, MonsterBehaviorController> PartnerMonsterBehaviorControllerDic;

	// Token: 0x040003AE RID: 942
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ExternalBehavior FarmMonsterExternalBehavior;

	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000FC6")]
	public class BehaviorParameter<T> where T : AIInput
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x17000BC3")]
		public bool CanUse
		{
			[Token(Token = "0x6006BCF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x17000BC4")]
		public bool Used
		{
			[Token(Token = "0x6006BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6006BD1")]
		public bool IsOwner(int isOwnerInstanceID)
		{
			return default(bool);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD2")]
		public void SetupBehavior(string name, Transform parent, ExternalBehavior externalBehavior)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BD3")]
		public T GetController(int isOwnerInstanceID)
		{
			return null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD4")]
		public void Relese()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD5")]
		public void Destroy()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD6")]
		public BehaviorParameter()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFBE0", Offset = "0x1AFCE1")]
		private void <SetupBehavior>b__9_0(BehaviorTree behaviortree)
		{
		}

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x4018D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int OwnerInstanceID;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x4018D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected BehaviorTreeManager.BehaviorParameter<T>.State m_State;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x4018D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T Controller;

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2001649")]
		public enum State
		{
			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x401C3EC")]
			NONE,
			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x401C3ED")]
			SETUP,
			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x401C3EE")]
			CANUSE,
			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x401C3EF")]
			USED
		}
	}

	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000FC7")]
	public class EnemyBehaviorParameter : BehaviorTreeManager.BehaviorParameter<EnemyBehaviorController>
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0x244FFE0", Offset = "0x24500E1", VA = "0x244FFE0")]
		public EnemyBehaviorParameter()
		{
		}
	}

	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000FC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157100", Offset = "0x157201")]
	private sealed class <CreateAsyncEnemyBehaviorParameter>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BD9")]
		[Address(RVA = "0x244C730", Offset = "0x244C831", VA = "0x244C730")]
		[DebuggerHidden]
		public <CreateAsyncEnemyBehaviorParameter>d__23(int <>1__state)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDA")]
		[Address(RVA = "0x244FE60", Offset = "0x244FF61", VA = "0x244FE60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0x244FE70", Offset = "0x244FF71", VA = "0x244FE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC5")]
		private object Current
		{
			[Token(Token = "0x6006BDC")]
			[Address(RVA = "0x2450030", Offset = "0x2450131", VA = "0x2450030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDD")]
		[Address(RVA = "0x2450040", Offset = "0x2450141", VA = "0x2450040", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC6")]
		private object Current
		{
			[Token(Token = "0x6006BDE")]
			[Address(RVA = "0x24500A0", Offset = "0x24501A1", VA = "0x24500A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x4018D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x4018D33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x4018D34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x4018D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<BehaviorTreeManager.EnemyBehaviorParameter> callBack;
	}

	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000FC9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157110", Offset = "0x157211")]
	private sealed class <>c__DisplayClass24_0
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BDF")]
		[Address(RVA = "0x244F130", Offset = "0x244F231", VA = "0x244F130")]
		public <>c__DisplayClass24_0()
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE0")]
		[Address(RVA = "0x244F140", Offset = "0x244F241", VA = "0x244F140")]
		internal void <GetAsyncEnemyBehavior>b__0(BehaviorTreeManager.EnemyBehaviorParameter param)
		{
		}

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x4018D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviorTreeManager.EnemyBehaviorParameter enemyBehaviorParameter;
	}

	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000FCA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157120", Offset = "0x157221")]
	private sealed class <GetAsyncEnemyBehavior>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE1")]
		[Address(RVA = "0x244C810", Offset = "0x244C911", VA = "0x244C810")]
		[DebuggerHidden]
		public <GetAsyncEnemyBehavior>d__24(int <>1__state)
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE2")]
		[Address(RVA = "0x2450550", Offset = "0x2450651", VA = "0x2450550", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x6006BE3")]
		[Address(RVA = "0x2450560", Offset = "0x2450661", VA = "0x2450560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC7")]
		private object Current
		{
			[Token(Token = "0x6006BE4")]
			[Address(RVA = "0x24508B0", Offset = "0x24509B1", VA = "0x24508B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE5")]
		[Address(RVA = "0x24508C0", Offset = "0x24509C1", VA = "0x24508C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC8")]
		private object Current
		{
			[Token(Token = "0x6006BE6")]
			[Address(RVA = "0x2450920", Offset = "0x2450A21", VA = "0x2450920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x4018D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x4018D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x4018D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x4018D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BehaviorTreeManager.<>c__DisplayClass24_0 <>8__1;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x4018D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<EnemyBehaviorController> callBack;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x4018D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject controller;
	}

	// Token: 0x0200013A RID: 314
	[Token(Token = "0x2000FCB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157130", Offset = "0x157231")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE7")]
		[Address(RVA = "0x244F150", Offset = "0x244F251", VA = "0x244F150")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE8")]
		[Address(RVA = "0x244F160", Offset = "0x244F261", VA = "0x244F160")]
		internal void <CreateAsyncEnemyBehavior>b__0(EnemyBehaviorController behavior)
		{
		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x4018D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public global::Character character;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x4018D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<EnemyBehaviorController> callBack;
	}

	// Token: 0x0200013B RID: 315
	[Token(Token = "0x2000FCC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157140", Offset = "0x157241")]
	private sealed class <CreateAsyncEnemyBehavior>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BE9")]
		[Address(RVA = "0x244CEE0", Offset = "0x244CFE1", VA = "0x244CEE0")]
		[DebuggerHidden]
		public <CreateAsyncEnemyBehavior>d__31(int <>1__state)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BEA")]
		[Address(RVA = "0x244FCA0", Offset = "0x244FDA1", VA = "0x244FCA0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x6006BEB")]
		[Address(RVA = "0x244FCB0", Offset = "0x244FDB1", VA = "0x244FCB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BC9")]
		private object Current
		{
			[Token(Token = "0x6006BEC")]
			[Address(RVA = "0x244FDE0", Offset = "0x244FEE1", VA = "0x244FDE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BED")]
		[Address(RVA = "0x244FDF0", Offset = "0x244FEF1", VA = "0x244FDF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCA")]
		private object Current
		{
			[Token(Token = "0x6006BEE")]
			[Address(RVA = "0x244FE50", Offset = "0x244FF51", VA = "0x244FE50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x4018D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x4018D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x4018D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public global::Character character;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x4018D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<EnemyBehaviorController> callBack;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x4018D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviorTreeManager <>4__this;
	}

	// Token: 0x0200013C RID: 316
	[Token(Token = "0x2000FCD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157150", Offset = "0x157251")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BEF")]
		[Address(RVA = "0x244F210", Offset = "0x244F311", VA = "0x244F210")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF0")]
		[Address(RVA = "0x244F220", Offset = "0x244F321", VA = "0x244F220")]
		internal void <CreateAsyncBossBehavior>b__0(BossDataAssetBase bossDataAsset)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF1")]
		[Address(RVA = "0x244F230", Offset = "0x244F331", VA = "0x244F230")]
		internal void <CreateAsyncBossBehavior>b__1(BehaviorTree behavior)
		{
		}

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x4018D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BossDataAssetBase bossData;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x4018D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x4018D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterControllerBase monsterController;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x4018D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BossBehaviorController monsterBehaviorController;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x4018D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<BossBehaviorController> callBack;
	}

	// Token: 0x0200013D RID: 317
	[Token(Token = "0x2000FCE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157160", Offset = "0x157261")]
	private sealed class <CreateAsyncBossBehavior>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF2")]
		[Address(RVA = "0x244D460", Offset = "0x244D561", VA = "0x244D460")]
		[DebuggerHidden]
		public <CreateAsyncBossBehavior>d__40(int <>1__state)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF3")]
		[Address(RVA = "0x244F6E0", Offset = "0x244F7E1", VA = "0x244F6E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6006BF4")]
		[Address(RVA = "0x244F6F0", Offset = "0x244F7F1", VA = "0x244F6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCB")]
		private object Current
		{
			[Token(Token = "0x6006BF5")]
			[Address(RVA = "0x244FC20", Offset = "0x244FD21", VA = "0x244FC20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF6")]
		[Address(RVA = "0x244FC30", Offset = "0x244FD31", VA = "0x244FC30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCC")]
		private object Current
		{
			[Token(Token = "0x6006BF7")]
			[Address(RVA = "0x244FC90", Offset = "0x244FD91", VA = "0x244FC90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x4018D49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x4018D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x4018D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x4018D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MonsterControllerBase monsterController;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x4018D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<BossBehaviorController> callBack;
	}

	// Token: 0x0200013E RID: 318
	[Token(Token = "0x2000FCF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157170", Offset = "0x157271")]
	private sealed class <>c__DisplayClass50_0
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF8")]
		[Address(RVA = "0x244DC00", Offset = "0x244DD01", VA = "0x244DC00")]
		public <>c__DisplayClass50_0()
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF9")]
		[Address(RVA = "0x244F340", Offset = "0x244F441", VA = "0x244F340")]
		internal void <CreatePartnerNPCBehavior>b__0(BehaviorTree behaviorTree)
		{
		}

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x4018D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x4018D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public global::Character character;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x4018D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerNPCBehaviorController npcBehaviorController;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x4018D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PartnerNPCBehaviorController> callBack;
	}

	// Token: 0x0200013F RID: 319
	[Token(Token = "0x2000FD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157180", Offset = "0x157281")]
	private sealed class <>c__DisplayClass58_0
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFA")]
		[Address(RVA = "0x244E2A0", Offset = "0x244E3A1", VA = "0x244E2A0")]
		public <>c__DisplayClass58_0()
		{
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFB")]
		[Address(RVA = "0x244F440", Offset = "0x244F541", VA = "0x244F440")]
		internal void <CreatePartnerMonsterBehavior>b__0(BehaviorTree behaviorTree)
		{
		}

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x4018D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x4018D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public global::Character character;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x4018D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerMonsterBehaviorController monsterBehaviorController;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x4018D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PartnerMonsterBehaviorController> callBack;
	}

	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000FD1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157190", Offset = "0x157291")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0x244F530", Offset = "0x244F631", VA = "0x244F530")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0x244F540", Offset = "0x244F641", VA = "0x244F540")]
		internal void <CreateAsyncPetMonsterBehavior>b__0(BehaviorTree behaviorTree)
		{
		}

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x4018D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x4018D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public global::Character character;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x4018D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartnerMonsterBehaviorController monsterBehaviorController;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x4018D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PartnerMonsterBehaviorController> callBack;
	}

	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000FD2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571A0", Offset = "0x1572A1")]
	private sealed class <CreateAsyncPetMonsterBehavior>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0x244E360", Offset = "0x244E461", VA = "0x244E360")]
		[DebuggerHidden]
		public <CreateAsyncPetMonsterBehavior>d__59(int <>1__state)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BFF")]
		[Address(RVA = "0x24500B0", Offset = "0x24501B1", VA = "0x24500B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6006C00")]
		[Address(RVA = "0x24500C0", Offset = "0x24501C1", VA = "0x24500C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCD")]
		private object Current
		{
			[Token(Token = "0x6006C01")]
			[Address(RVA = "0x2450320", Offset = "0x2450421", VA = "0x2450320", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C02")]
		[Address(RVA = "0x2450330", Offset = "0x2450431", VA = "0x2450330", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCE")]
		private object Current
		{
			[Token(Token = "0x6006C03")]
			[Address(RVA = "0x2450390", Offset = "0x2450491", VA = "0x2450390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x4018D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x4018D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x4018D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x4018D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public global::Character character;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x4018D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<PartnerMonsterBehaviorController> callBack;
	}

	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000FD3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571B0", Offset = "0x1572B1")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x244E720", Offset = "0x244E821", VA = "0x244E720")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x244F630", Offset = "0x244F731", VA = "0x244F630")]
		internal void <CreatePartnerFarmMonsterBehavior>b__0(BehaviorTree behaviorTree)
		{
		}

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x4018D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x4018D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public global::Character character;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x4018D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FarmMonsterBehaviorController monsterBehaviorController;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x4018D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<FarmMonsterBehaviorController> callBack;
	}

	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000FD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1571C0", Offset = "0x1572C1")]
	private sealed class <CreateAsyncSnowmanBehavior>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x244E7E0", Offset = "0x244E8E1", VA = "0x244E7E0")]
		[DebuggerHidden]
		public <CreateAsyncSnowmanBehavior>d__65(int <>1__state)
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x24503A0", Offset = "0x24504A1", VA = "0x24503A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6006C08")]
		[Address(RVA = "0x24503B0", Offset = "0x24504B1", VA = "0x24503B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BCF")]
		private object Current
		{
			[Token(Token = "0x6006C09")]
			[Address(RVA = "0x24504D0", Offset = "0x24505D1", VA = "0x24504D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C0A")]
		[Address(RVA = "0x24504E0", Offset = "0x24505E1", VA = "0x24504E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD0")]
		private object Current
		{
			[Token(Token = "0x6006C0B")]
			[Address(RVA = "0x2450540", Offset = "0x2450641", VA = "0x2450540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x4018D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x4018D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x4018D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterControllerBase character;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x4018D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviorTreeManager <>4__this;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x4018D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<EnemyBehaviorController> callBack;
	}
}
