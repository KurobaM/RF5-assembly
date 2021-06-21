using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

namespace Field
{
	// Token: 0x0200113E RID: 4414
	[Token(Token = "0x2000B1D")]
	public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager>
	{
		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06006FBE RID: 28606 RVA: 0x000268C8 File Offset: 0x00024AC8
		[Token(Token = "0x17000B15")]
		public bool IsShowHideTreasureBox
		{
			[Token(Token = "0x6005CA9")]
			[Address(RVA = "0x1F8C910", Offset = "0x1F8CA11", VA = "0x1F8C910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B16")]
		public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet
		{
			[Token(Token = "0x6005CAA")]
			[Address(RVA = "0x1F8C980", Offset = "0x1F8CA81", VA = "0x1F8C980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CAB")]
			[Address(RVA = "0x1F8C990", Offset = "0x1F8CA91", VA = "0x1F8C990")]
			private set
			{
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FC2 RID: 28610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B17")]
		public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet
		{
			[Token(Token = "0x6005CAC")]
			[Address(RVA = "0x1F8C9A0", Offset = "0x1F8CAA1", VA = "0x1F8C9A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CAD")]
			[Address(RVA = "0x1F8C9B0", Offset = "0x1F8CAB1", VA = "0x1F8C9B0")]
			private set
			{
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06006FC3 RID: 28611 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FC4 RID: 28612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B18")]
		public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet
		{
			[Token(Token = "0x6005CAE")]
			[Address(RVA = "0x1F8C9C0", Offset = "0x1F8CAC1", VA = "0x1F8C9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CAF")]
			[Address(RVA = "0x1F8C9D0", Offset = "0x1F8CAD1", VA = "0x1F8C9D0")]
			private set
			{
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06006FC5 RID: 28613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006FC6 RID: 28614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B19")]
		public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet
		{
			[Token(Token = "0x6005CB0")]
			[Address(RVA = "0x1F8C9E0", Offset = "0x1F8CAE1", VA = "0x1F8C9E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005CB1")]
			[Address(RVA = "0x1F8C9F0", Offset = "0x1F8CAF1", VA = "0x1F8C9F0")]
			private set
			{
			}
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x1F8CA00", Offset = "0x1F8CB01", VA = "0x1F8CA00")]
		public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables()
		{
			return null;
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x1F8CA60", Offset = "0x1F8CB61", VA = "0x1F8CA60")]
		public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables()
		{
			return null;
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x1F8CAC0", Offset = "0x1F8CBC1", VA = "0x1F8CAC0")]
		public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables()
		{
			return null;
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x000268E0 File Offset: 0x00024AE0
		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x1F8CB20", Offset = "0x1F8CC21", VA = "0x1F8CB20")]
		public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return default(FieldUniqueTreasureBoxSpawnDataTable);
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x000268F8 File Offset: 0x00024AF8
		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0x1F8CBD0", Offset = "0x1F8CCD1", VA = "0x1F8CBD0")]
		public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return default(FieldRandomTreasureBoxSpawnDataTable);
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00026910 File Offset: 0x00024B10
		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0x1F8CC80", Offset = "0x1F8CD81", VA = "0x1F8CC80")]
		public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID)
		{
			return default(FieldWoodBoxSpawnDataTable);
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0x1F8CD30", Offset = "0x1F8CE31", VA = "0x1F8CD30")]
		public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x1F878C0", Offset = "0x1F879C1", VA = "0x1F878C0")]
		public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0x1F8CEB0", Offset = "0x1F8CFB1", VA = "0x1F8CEB0")]
		public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x1F899C0", Offset = "0x1F89AC1", VA = "0x1F899C0")]
		public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x1F8CFD0", Offset = "0x1F8D0D1", VA = "0x1F8CFD0")]
		public void InitializeLoad()
		{
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x1F8D0C0", Offset = "0x1F8D1C1", VA = "0x1F8D0C0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF150", Offset = "0x1AF251")]
		public IEnumerator LoadDataTable()
		{
			return null;
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0x1F8D140", Offset = "0x1F8D241", VA = "0x1F8D140")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF1C0", Offset = "0x1AF2C1")]
		public IEnumerator LoadModelDataAsync()
		{
			return null;
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0x1F8D220", Offset = "0x1F8D321", VA = "0x1F8D220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x1F8D3A0", Offset = "0x1F8D4A1", VA = "0x1F8D3A0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x1F8D3F0", Offset = "0x1F8D4F1", VA = "0x1F8D3F0")]
		private void Start()
		{
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x1F8D400", Offset = "0x1F8D501", VA = "0x1F8D400")]
		private void Update()
		{
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0x1F8D410", Offset = "0x1F8D511", VA = "0x1F8D410")]
		private void UpdateMimickMonster()
		{
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x00026928 File Offset: 0x00024B28
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0x1F8D860", Offset = "0x1F8D961", VA = "0x1F8D860")]
		private static bool Lottery(int weight)
		{
			return default(bool);
		}

		// Token: 0x06006FDA RID: 28634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0x1F8D8A0", Offset = "0x1F8D9A1", VA = "0x1F8D8A0")]
		public void OnAfterGameDataLoad()
		{
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0x1F8D9C0", Offset = "0x1F8DAC1", VA = "0x1F8D9C0")]
		public static void OnDayChangeSetFieldFlag(int elapsedDay = 1)
		{
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0x1F8DC20", Offset = "0x1F8DD21", VA = "0x1F8DC20")]
		public void OnSceneChangeSetFieldFlag()
		{
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x1F8E240", Offset = "0x1F8E341", VA = "0x1F8E240")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF230", Offset = "0x1AF331")]
		private IEnumerator CheckGateTreasureBox()
		{
			return null;
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00026940 File Offset: 0x00024B40
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x1F8E2F0", Offset = "0x1F8E3F1", VA = "0x1F8E2F0")]
		private bool ExistGateControllerUniqueBox(GateDataID gateDataID)
		{
			return default(bool);
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x1F8E410", Offset = "0x1F8E511", VA = "0x1F8E410")]
		public void RemoveRandomTreasureBox()
		{
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x1F87AB0", Offset = "0x1F87BB1", VA = "0x1F87AB0")]
		public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent)
		{
			return null;
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0x1F86C20", Offset = "0x1F86D21", VA = "0x1F86C20")]
		public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x1F8E860", Offset = "0x1F8E961", VA = "0x1F8E860")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AF2A0", Offset = "0x1AF3A1")]
		public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
			return null;
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00026958 File Offset: 0x00024B58
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x1F87C10", Offset = "0x1F87D11", VA = "0x1F87C10")]
		public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
			return default(bool);
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00026970 File Offset: 0x00024B70
		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0x1F8E930", Offset = "0x1F8EA31", VA = "0x1F8E930")]
		public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00026988 File Offset: 0x00024B88
		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x1F87F80", Offset = "0x1F88081", VA = "0x1F87F80")]
		public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x000269A0 File Offset: 0x00024BA0
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0x1F8EA10", Offset = "0x1F8EB11", VA = "0x1F8EA10")]
		public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x000269B8 File Offset: 0x00024BB8
		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0x1F8EAF0", Offset = "0x1F8EBF1", VA = "0x1F8EAF0")]
		public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x000269D0 File Offset: 0x00024BD0
		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0x1F8A980", Offset = "0x1F8AA81", VA = "0x1F8A980")]
		public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x000269E8 File Offset: 0x00024BE8
		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0x1F8EBD0", Offset = "0x1F8ECD1", VA = "0x1F8EBD0")]
		public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x00026A00 File Offset: 0x00024C00
		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0x1F86AF0", Offset = "0x1F86BF1", VA = "0x1F86AF0")]
		public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x00026A18 File Offset: 0x00024C18
		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x1F8EC70", Offset = "0x1F8ED71", VA = "0x1F8EC70")]
		public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x00026A30 File Offset: 0x00024C30
		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x1F89190", Offset = "0x1F89291", VA = "0x1F89190")]
		public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x00026A48 File Offset: 0x00024C48
		[Token(Token = "0x6005CD8")]
		[Address(RVA = "0x1F8ED10", Offset = "0x1F8EE11", VA = "0x1F8ED10")]
		public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x00026A60 File Offset: 0x00024C60
		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0x1F87600", Offset = "0x1F87701", VA = "0x1F87600")]
		public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x00026A78 File Offset: 0x00024C78
		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x1F8ED90", Offset = "0x1F8EE91", VA = "0x1F8ED90")]
		public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x00026A90 File Offset: 0x00024C90
		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0x1F898A0", Offset = "0x1F899A1", VA = "0x1F898A0")]
		public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID)
		{
			return default(bool);
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0x1F8EE10", Offset = "0x1F8EF11", VA = "0x1F8EE10")]
		public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0x1F87680", Offset = "0x1F87781", VA = "0x1F87680")]
		public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDE")]
		[Address(RVA = "0x1F8E1A0", Offset = "0x1F8E2A1", VA = "0x1F8E1A0")]
		public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x1F89920", Offset = "0x1F89A21", VA = "0x1F89920")]
		public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID)
		{
			return null;
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x1F8A140", Offset = "0x1F8A241", VA = "0x1F8A140")]
		public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x1F8EEB0", Offset = "0x1F8EFB1", VA = "0x1F8EEB0")]
		public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x1F86DE0", Offset = "0x1F86EE1", VA = "0x1F86DE0")]
		public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x1F86A10", Offset = "0x1F86B11", VA = "0x1F86A10")]
		public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x1F86E50", Offset = "0x1F86F51", VA = "0x1F86E50")]
		public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x1F86A80", Offset = "0x1F86B81", VA = "0x1F86A80")]
		public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x1F89300", Offset = "0x1F89401", VA = "0x1F89300")]
		public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x1F89120", Offset = "0x1F89221", VA = "0x1F89120")]
		public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner)
		{
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0x1F8ACB0", Offset = "0x1F8ADB1", VA = "0x1F8ACB0")]
		public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value)
		{
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00026AA8 File Offset: 0x00024CA8
		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0x1F87520", Offset = "0x1F87621", VA = "0x1F87520")]
		public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = false)
		{
			return default(bool);
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0x1F8B1B0", Offset = "0x1F8B2B1", VA = "0x1F8B1B0")]
		public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value)
		{
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x00026AC0 File Offset: 0x00024CC0
		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0x1F87720", Offset = "0x1F87821", VA = "0x1F87720")]
		public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0x1F8E0C0", Offset = "0x1F8E1C1", VA = "0x1F8E0C0")]
		public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value)
		{
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x00026AD8 File Offset: 0x00024CD8
		[Token(Token = "0x6005CED")]
		[Address(RVA = "0x1F8EF20", Offset = "0x1F8F021", VA = "0x1F8EF20")]
		public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id)
		{
			return default(bool);
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x00026AF0 File Offset: 0x00024CF0
		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0x1F874B0", Offset = "0x1F875B1", VA = "0x1F874B0")]
		public static bool IsRestrictSpawn()
		{
			return default(bool);
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x1F8F010", Offset = "0x1F8F111", VA = "0x1F8F010")]
		public void OnChangeHideDetectFlag()
		{
		}

		// Token: 0x06007005 RID: 28677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0x1F8F220", Offset = "0x1F8F321", VA = "0x1F8F220")]
		public void OnChangeHideDetectFlag(bool visible)
		{
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF1")]
		[Address(RVA = "0x1F8F340", Offset = "0x1F8F441", VA = "0x1F8F340")]
		public void SetTargetItemName(ItemDataTable targetItemDataTable)
		{
		}

		// Token: 0x06007007 RID: 28679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF2")]
		[Address(RVA = "0x1F8F350", Offset = "0x1F8F451", VA = "0x1F8F350")]
		public string GetTargetItemName()
		{
			return null;
		}

		// Token: 0x06007008 RID: 28680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x1F8F370", Offset = "0x1F8F471", VA = "0x1F8F370")]
		public string GetTargetItemCategory()
		{
			return null;
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x1F8F390", Offset = "0x1F8F491", VA = "0x1F8F390")]
		public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = FieldRewardTreasureBoxSpawnID.PoliceOrder)
		{
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x1F8F500", Offset = "0x1F8F601", VA = "0x1F8F500")]
		public void SpawnWantedRewardTreasureBox()
		{
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x1F8F670", Offset = "0x1F8F771", VA = "0x1F8F670")]
		public void SpawnFestivalRewardTreasureBox()
		{
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x00026B08 File Offset: 0x00024D08
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x1F896F0", Offset = "0x1F897F1", VA = "0x1F896F0")]
		public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId)
		{
			return 0;
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0x1F8B290", Offset = "0x1F8B391", VA = "0x1F8B290")]
		public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId)
		{
			return null;
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0x1F8F7E0", Offset = "0x1F8F8E1", VA = "0x1F8F7E0")]
		public static FieldRewardTreasureBoxData GetOrderRewardData()
		{
			return null;
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0x1F8F9C0", Offset = "0x1F8FAC1", VA = "0x1F8F9C0")]
		public static FieldRewardTreasureBoxData GetWantedRewardData()
		{
			return null;
		}

		// Token: 0x06007010 RID: 28688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0x1F8FAE0", Offset = "0x1F8FBE1", VA = "0x1F8FAE0")]
		public static FieldRewardTreasureBoxData GetFestivalRewardData()
		{
			return null;
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0x1F8FC00", Offset = "0x1F8FD01", VA = "0x1F8FC00")]
		public static void AddOrderReward(int type, int id, int amount, int level, int npcId)
		{
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0x1F8FCD0", Offset = "0x1F8FDD1", VA = "0x1F8FCD0")]
		public static void AddWantedReward(int id, int amount, int level)
		{
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0x1F8B410", Offset = "0x1F8B511", VA = "0x1F8B410")]
		public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId)
		{
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x1F8FD30", Offset = "0x1F8FE31", VA = "0x1F8FD30")]
		public void RemoveFestivalRewardTreasureBox()
		{
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D00")]
		[Address(RVA = "0x1F8FEA0", Offset = "0x1F8FFA1", VA = "0x1F8FEA0")]
		public FieldTreasureBoxManager()
		{
		}

		// Token: 0x0401826C RID: 98924
		[Token(Token = "0x4014CFA")]
		private const int GateWaitCount = 10;

		// Token: 0x0401826D RID: 98925
		[Token(Token = "0x4014CFB")]
		private const int DispDistanceSqr = 4096;

		// Token: 0x0401826E RID: 98926
		[Token(Token = "0x4014CFC")]
		[FieldOffset(Offset = "0x18")]
		private GameObject[] TreasureBoxPrefabs;

		// Token: 0x0401826F RID: 98927
		[Token(Token = "0x4014CFD")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary;

		// Token: 0x04018270 RID: 98928
		[Token(Token = "0x4014CFE")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary;

		// Token: 0x04018271 RID: 98929
		[Token(Token = "0x4014CFF")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary;

		// Token: 0x04018272 RID: 98930
		[Token(Token = "0x4014D00")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary;

		// Token: 0x04018273 RID: 98931
		[Token(Token = "0x4014D01")]
		[FieldOffset(Offset = "0x40")]
		private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray;

		// Token: 0x04018274 RID: 98932
		[Token(Token = "0x4014D02")]
		[FieldOffset(Offset = "0x48")]
		private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray;

		// Token: 0x04018275 RID: 98933
		[Token(Token = "0x4014D03")]
		[FieldOffset(Offset = "0x50")]
		private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray;

		// Token: 0x04018276 RID: 98934
		[Token(Token = "0x4014D04")]
		[FieldOffset(Offset = "0x58")]
		private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet;

		// Token: 0x04018277 RID: 98935
		[Token(Token = "0x4014D05")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet;

		// Token: 0x04018278 RID: 98936
		[Token(Token = "0x4014D06")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet;

		// Token: 0x04018279 RID: 98937
		[Token(Token = "0x4014D07")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet;

		// Token: 0x0401827A RID: 98938
		[Token(Token = "0x4014D08")]
		[FieldOffset(Offset = "0x78")]
		private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet;

		// Token: 0x0401827B RID: 98939
		[Token(Token = "0x4014D09")]
		[FieldOffset(Offset = "0x80")]
		private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet;

		// Token: 0x0401827C RID: 98940
		[Token(Token = "0x4014D0A")]
		[FieldOffset(Offset = "0x88")]
		private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet;

		// Token: 0x0401827D RID: 98941
		[Token(Token = "0x4014D0B")]
		[FieldOffset(Offset = "0x90")]
		private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet;

		// Token: 0x0401827E RID: 98942
		[Token(Token = "0x4014D0C")]
		[FieldOffset(Offset = "0x98")]
		private ItemDataTable targetItemData;

		// Token: 0x0401827F RID: 98943
		[Token(Token = "0x4014D0D")]
		[FieldOffset(Offset = "0xA0")]
		public Transform OrderRewardRootTransform;

		// Token: 0x04018280 RID: 98944
		[Token(Token = "0x4014D0E")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject OrderRewardTreasureBox;

		// Token: 0x0200113F RID: 4415
		[Token(Token = "0x200158D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A250", Offset = "0x15A351")]
		private sealed class <LoadDataTable>d__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007016 RID: 28694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC4")]
			[Address(RVA = "0x1F8D1C0", Offset = "0x1F8D2C1", VA = "0x1F8D1C0")]
			[DebuggerHidden]
			public <LoadDataTable>d__46(int <>1__state)
			{
			}

			// Token: 0x06007017 RID: 28695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC5")]
			[Address(RVA = "0x1F91030", Offset = "0x1F91131", VA = "0x1F91030", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007018 RID: 28696 RVA: 0x00026B20 File Offset: 0x00024D20
			[Token(Token = "0x6007DC6")]
			[Address(RVA = "0x1F91040", Offset = "0x1F91141", VA = "0x1F91040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E36 RID: 3638
			// (get) Token: 0x06007019 RID: 28697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED7")]
			private object Current
			{
				[Token(Token = "0x6007DC7")]
				[Address(RVA = "0x1F912F0", Offset = "0x1F913F1", VA = "0x1F912F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600701A RID: 28698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DC8")]
			[Address(RVA = "0x1F91300", Offset = "0x1F91401", VA = "0x1F91300", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E37 RID: 3639
			// (get) Token: 0x0600701B RID: 28699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED8")]
			private object Current
			{
				[Token(Token = "0x6007DC9")]
				[Address(RVA = "0x1F91360", Offset = "0x1F91461", VA = "0x1F91360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018281 RID: 98945
			[Token(Token = "0x401C17E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018282 RID: 98946
			[Token(Token = "0x401C17F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018283 RID: 98947
			[Token(Token = "0x401C180")]
			[FieldOffset(Offset = "0x20")]
			public FieldTreasureBoxManager <>4__this;
		}

		// Token: 0x02001140 RID: 4416
		[Token(Token = "0x200158E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A260", Offset = "0x15A361")]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x0600701C RID: 28700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCA")]
			[Address(RVA = "0x1F90160", Offset = "0x1F90261", VA = "0x1F90160")]
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x0600701D RID: 28701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCB")]
			[Address(RVA = "0x1F90170", Offset = "0x1F90271", VA = "0x1F90170")]
			internal void <LoadModelDataAsync>b__0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x0600701E RID: 28702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCC")]
			[Address(RVA = "0x1F90240", Offset = "0x1F90341", VA = "0x1F90240")]
			internal void <LoadModelDataAsync>b__1(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x0600701F RID: 28703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCD")]
			[Address(RVA = "0x1F90310", Offset = "0x1F90411", VA = "0x1F90310")]
			internal void <LoadModelDataAsync>b__2(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06007020 RID: 28704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCE")]
			[Address(RVA = "0x1F903E0", Offset = "0x1F904E1", VA = "0x1F903E0")]
			internal void <LoadModelDataAsync>b__3(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06007021 RID: 28705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DCF")]
			[Address(RVA = "0x1F904B0", Offset = "0x1F905B1", VA = "0x1F904B0")]
			internal void <LoadModelDataAsync>b__4(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06007022 RID: 28706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD0")]
			[Address(RVA = "0x1F90580", Offset = "0x1F90681", VA = "0x1F90580")]
			internal void <LoadModelDataAsync>b__5(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x06007023 RID: 28707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD1")]
			[Address(RVA = "0x1F90650", Offset = "0x1F90751", VA = "0x1F90650")]
			internal void <LoadModelDataAsync>b__6(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x04018284 RID: 98948
			[Token(Token = "0x401C181")]
			[FieldOffset(Offset = "0x10")]
			public int loadCount;

			// Token: 0x04018285 RID: 98949
			[Token(Token = "0x401C182")]
			[FieldOffset(Offset = "0x18")]
			public FieldTreasureBoxManager <>4__this;
		}

		// Token: 0x02001141 RID: 4417
		[Token(Token = "0x200158F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A270", Offset = "0x15A371")]
		private sealed class <LoadModelDataAsync>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007024 RID: 28708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD2")]
			[Address(RVA = "0x1F8D1F0", Offset = "0x1F8D2F1", VA = "0x1F8D1F0")]
			[DebuggerHidden]
			public <LoadModelDataAsync>d__47(int <>1__state)
			{
			}

			// Token: 0x06007025 RID: 28709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD3")]
			[Address(RVA = "0x1F91370", Offset = "0x1F91471", VA = "0x1F91370", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007026 RID: 28710 RVA: 0x00026B38 File Offset: 0x00024D38
			[Token(Token = "0x6007DD4")]
			[Address(RVA = "0x1F91380", Offset = "0x1F91481", VA = "0x1F91380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E38 RID: 3640
			// (get) Token: 0x06007027 RID: 28711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED9")]
			private object Current
			{
				[Token(Token = "0x6007DD5")]
				[Address(RVA = "0x1F916C0", Offset = "0x1F917C1", VA = "0x1F916C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007028 RID: 28712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD6")]
			[Address(RVA = "0x1F916D0", Offset = "0x1F917D1", VA = "0x1F916D0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E39 RID: 3641
			// (get) Token: 0x06007029 RID: 28713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDA")]
			private object Current
			{
				[Token(Token = "0x6007DD7")]
				[Address(RVA = "0x1F91730", Offset = "0x1F91831", VA = "0x1F91730", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018286 RID: 98950
			[Token(Token = "0x401C183")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018287 RID: 98951
			[Token(Token = "0x401C184")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018288 RID: 98952
			[Token(Token = "0x401C185")]
			[FieldOffset(Offset = "0x20")]
			public FieldTreasureBoxManager <>4__this;

			// Token: 0x04018289 RID: 98953
			[Token(Token = "0x401C186")]
			[FieldOffset(Offset = "0x28")]
			private FieldTreasureBoxManager.<>c__DisplayClass47_0 <>8__1;

			// Token: 0x0401828A RID: 98954
			[Token(Token = "0x401C187")]
			[FieldOffset(Offset = "0x30")]
			private int <count>5__2;
		}

		// Token: 0x02001142 RID: 4418
		[Token(Token = "0x2001590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A280", Offset = "0x15A381")]
		private sealed class <CheckGateTreasureBox>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600702A RID: 28714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD8")]
			[Address(RVA = "0x1F8E2C0", Offset = "0x1F8E3C1", VA = "0x1F8E2C0")]
			[DebuggerHidden]
			public <CheckGateTreasureBox>d__57(int <>1__state)
			{
			}

			// Token: 0x0600702B RID: 28715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DD9")]
			[Address(RVA = "0x1F90990", Offset = "0x1F90A91", VA = "0x1F90990", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600702C RID: 28716 RVA: 0x00026B50 File Offset: 0x00024D50
			[Token(Token = "0x6007DDA")]
			[Address(RVA = "0x1F909A0", Offset = "0x1F90AA1", VA = "0x1F909A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E3A RID: 3642
			// (get) Token: 0x0600702D RID: 28717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDB")]
			private object Current
			{
				[Token(Token = "0x6007DDB")]
				[Address(RVA = "0x1F90FB0", Offset = "0x1F910B1", VA = "0x1F90FB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600702E RID: 28718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDC")]
			[Address(RVA = "0x1F90FC0", Offset = "0x1F910C1", VA = "0x1F90FC0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E3B RID: 3643
			// (get) Token: 0x0600702F RID: 28719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDC")]
			private object Current
			{
				[Token(Token = "0x6007DDD")]
				[Address(RVA = "0x1F91020", Offset = "0x1F91121", VA = "0x1F91020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401828B RID: 98955
			[Token(Token = "0x401C188")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401828C RID: 98956
			[Token(Token = "0x401C189")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401828D RID: 98957
			[Token(Token = "0x401C18A")]
			[FieldOffset(Offset = "0x20")]
			public FieldTreasureBoxManager <>4__this;
		}

		// Token: 0x02001143 RID: 4419
		[Token(Token = "0x2001591")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A290", Offset = "0x15A391")]
		private sealed class <>c__DisplayClass62_0
		{
			// Token: 0x06007030 RID: 28720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDE")]
			[Address(RVA = "0x1F90720", Offset = "0x1F90821", VA = "0x1F90720")]
			public <>c__DisplayClass62_0()
			{
			}

			// Token: 0x06007031 RID: 28721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DDF")]
			[Address(RVA = "0x1F90730", Offset = "0x1F90831", VA = "0x1F90730")]
			internal void <SpawnMonsterBoxCoroutine>b__0(MonsterControllerBase controller)
			{
			}

			// Token: 0x0401828E RID: 98958
			[Token(Token = "0x401C18B")]
			[FieldOffset(Offset = "0x10")]
			public FieldRandomTreasureBoxSpawner treasureBoxSpawner;

			// Token: 0x0401828F RID: 98959
			[Token(Token = "0x401C18C")]
			[FieldOffset(Offset = "0x18")]
			public FieldTreasureBoxManager <>4__this;
		}

		// Token: 0x02001144 RID: 4420
		[Token(Token = "0x2001592")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A2A0", Offset = "0x15A3A1")]
		private sealed class <>c__DisplayClass62_1
		{
			// Token: 0x06007032 RID: 28722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE0")]
			[Address(RVA = "0x1F90830", Offset = "0x1F90931", VA = "0x1F90830")]
			public <>c__DisplayClass62_1()
			{
			}

			// Token: 0x06007033 RID: 28723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE1")]
			[Address(RVA = "0x1F90840", Offset = "0x1F90941", VA = "0x1F90840")]
			internal void <SpawnMonsterBoxCoroutine>b__1(EnemyBehaviorController behavior)
			{
			}

			// Token: 0x04018290 RID: 98960
			[Token(Token = "0x401C18D")]
			[FieldOffset(Offset = "0x10")]
			public MonsterControllerBase controller;

			// Token: 0x04018291 RID: 98961
			[Token(Token = "0x401C18E")]
			[FieldOffset(Offset = "0x18")]
			public FieldTreasureBoxManager.<>c__DisplayClass62_0 CS$<>8__locals1;
		}

		// Token: 0x02001145 RID: 4421
		[Token(Token = "0x2001593")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A2B0", Offset = "0x15A3B1")]
		private sealed class <SpawnMonsterBoxCoroutine>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007034 RID: 28724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE2")]
			[Address(RVA = "0x1F8E900", Offset = "0x1F8EA01", VA = "0x1F8E900")]
			[DebuggerHidden]
			public <SpawnMonsterBoxCoroutine>d__62(int <>1__state)
			{
			}

			// Token: 0x06007035 RID: 28725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE3")]
			[Address(RVA = "0x1F91740", Offset = "0x1F91841", VA = "0x1F91740", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007036 RID: 28726 RVA: 0x00026B68 File Offset: 0x00024D68
			[Token(Token = "0x6007DE4")]
			[Address(RVA = "0x1F91750", Offset = "0x1F91851", VA = "0x1F91750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E3C RID: 3644
			// (get) Token: 0x06007037 RID: 28727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDD")]
			private object Current
			{
				[Token(Token = "0x6007DE5")]
				[Address(RVA = "0x1F91A20", Offset = "0x1F91B21", VA = "0x1F91A20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007038 RID: 28728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE6")]
			[Address(RVA = "0x1F91A30", Offset = "0x1F91B31", VA = "0x1F91A30", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000E3D RID: 3645
			// (get) Token: 0x06007039 RID: 28729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EDE")]
			private object Current
			{
				[Token(Token = "0x6007DE7")]
				[Address(RVA = "0x1F91A90", Offset = "0x1F91B91", VA = "0x1F91A90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04018292 RID: 98962
			[Token(Token = "0x401C18F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04018293 RID: 98963
			[Token(Token = "0x401C190")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04018294 RID: 98964
			[Token(Token = "0x401C191")]
			[FieldOffset(Offset = "0x20")]
			public FieldRandomTreasureBoxSpawner treasureBoxSpawner;

			// Token: 0x04018295 RID: 98965
			[Token(Token = "0x401C192")]
			[FieldOffset(Offset = "0x28")]
			public FieldTreasureBoxManager <>4__this;

			// Token: 0x04018296 RID: 98966
			[Token(Token = "0x401C193")]
			[FieldOffset(Offset = "0x30")]
			private FieldTreasureBoxManager.<>c__DisplayClass62_0 <>8__1;

			// Token: 0x04018297 RID: 98967
			[Token(Token = "0x401C194")]
			[FieldOffset(Offset = "0x38")]
			public MonsterDataID monsterDataID;

			// Token: 0x04018298 RID: 98968
			[Token(Token = "0x401C195")]
			[FieldOffset(Offset = "0x3C")]
			private int <level>5__2;

			// Token: 0x04018299 RID: 98969
			[Token(Token = "0x401C196")]
			[FieldOffset(Offset = "0x40")]
			private GateController <gate>5__3;

			// Token: 0x0401829A RID: 98970
			[Token(Token = "0x401C197")]
			[FieldOffset(Offset = "0x48")]
			private int <i>5__4;
		}
	}
}
