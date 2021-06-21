using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Field;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

namespace ItemFurniture
{
	// Token: 0x02001046 RID: 4166
	[Token(Token = "0x2000A95")]
	public class FurnitureManager : SingletonMonoBehaviour<FurnitureManager>
	{
		// Token: 0x060068AB RID: 26795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572F")]
		[Address(RVA = "0x20781E0", Offset = "0x20782E1", VA = "0x20781E0")]
		public void ClearGramophoneBgmPlay()
		{
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x00023D00 File Offset: 0x00021F00
		[Token(Token = "0x6005730")]
		[Address(RVA = "0x20781F0", Offset = "0x20782F1", VA = "0x20781F0")]
		public bool IsGramophone()
		{
			return default(bool);
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A7F")]
		private string GetZenin
		{
			[Token(Token = "0x6005731")]
			[Address(RVA = "0x20783F0", Offset = "0x20784F1", VA = "0x20783F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A80")]
		private string GetYameru
		{
			[Token(Token = "0x6005732")]
			[Address(RVA = "0x20784E0", Offset = "0x20785E1", VA = "0x20784E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005733")]
		[Address(RVA = "0x20785D0", Offset = "0x20786D1", VA = "0x20785D0")]
		private string GetCharaterName(ActorID actorID)
		{
			return null;
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060068B0 RID: 26800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A81")]
		public FurnitureShadow FurnitureShadow
		{
			[Token(Token = "0x6005734")]
			[Address(RVA = "0x2078750", Offset = "0x2078851", VA = "0x2078750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060068B2 RID: 26802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A82")]
		public PlayerItemFurniture2 PlayerItemFurniture2
		{
			[Token(Token = "0x6005735")]
			[Address(RVA = "0x2078760", Offset = "0x2078861", VA = "0x2078760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005736")]
			[Address(RVA = "0x2078770", Offset = "0x2078871", VA = "0x2078770")]
			set
			{
			}
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005737")]
		[Address(RVA = "0x2078780", Offset = "0x2078881", VA = "0x2078780")]
		public void SetFurnitureBlock(FurnitureBlock block)
		{
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005738")]
		[Address(RVA = "0x2078790", Offset = "0x2078891", VA = "0x2078790")]
		public void SetFlyingNimbus(FlyingNimbus nimbus)
		{
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00023D18 File Offset: 0x00021F18
		[Token(Token = "0x6005739")]
		[Address(RVA = "0x20787A0", Offset = "0x20788A1", VA = "0x20787A0")]
		public bool IsFlyingNimbusRide()
		{
			return default(bool);
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573A")]
		[Address(RVA = "0x2078840", Offset = "0x2078941", VA = "0x2078840")]
		private void WarpFlyingNimbus()
		{
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573B")]
		[Address(RVA = "0x2078A30", Offset = "0x2078B31", VA = "0x2078A30")]
		private void FlyingNimbusSaveBlock(bool enable)
		{
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573C")]
		[Address(RVA = "0x2078B10", Offset = "0x2078C11", VA = "0x2078B10")]
		private void Start()
		{
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573D")]
		[Address(RVA = "0x2078C30", Offset = "0x2078D31", VA = "0x2078C30")]
		private void OnSceneLoadComplete()
		{
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600573E")]
		[Address(RVA = "0x2078CC0", Offset = "0x2078DC1", VA = "0x2078CC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD2A0", Offset = "0x1AD3A1")]
		private IEnumerator OnSceneLoad()
		{
			return null;
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573F")]
		[Address(RVA = "0x2078D70", Offset = "0x2078E71", VA = "0x2078D70")]
		private void Update()
		{
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005740")]
		[Address(RVA = "0x2078E20", Offset = "0x2078F21", VA = "0x2078E20")]
		private void UpdateHide()
		{
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005741")]
		[Address(RVA = "0x2078F30", Offset = "0x2079031", VA = "0x2078F30")]
		public void AddObject(PlayerItemFurniture2 furniture)
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005742")]
		[Address(RVA = "0x2078FA0", Offset = "0x20790A1", VA = "0x2078FA0")]
		public void RemoveObject(PlayerItemFurniture2 furniture)
		{
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00023D30 File Offset: 0x00021F30
		[Token(Token = "0x6005743")]
		[Address(RVA = "0x2079010", Offset = "0x2079111", VA = "0x2079010")]
		private bool IsCreate(string guid)
		{
			return default(bool);
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00023D48 File Offset: 0x00021F48
		[Token(Token = "0x6005744")]
		[Address(RVA = "0x2079140", Offset = "0x2079241", VA = "0x2079140")]
		public int Count()
		{
			return 0;
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x00023D60 File Offset: 0x00021F60
		[Token(Token = "0x6005745")]
		[Address(RVA = "0x2079170", Offset = "0x2079271", VA = "0x2079170")]
		public bool IsBreak()
		{
			return default(bool);
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x20791A0", Offset = "0x20792A1", VA = "0x20791A0")]
		private void SetFurniture(FurnitureSaveData newdata, bool is_reserve = false)
		{
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00023D78 File Offset: 0x00021F78
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x20791F0", Offset = "0x20792F1", VA = "0x20791F0")]
		public bool IsMax()
		{
			return default(bool);
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x00023D90 File Offset: 0x00021F90
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x2079220", Offset = "0x2079321", VA = "0x2079220")]
		public bool IsCreate(FurnitureCreatePoint point)
		{
			return default(bool);
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005749")]
		[Address(RVA = "0x2079260", Offset = "0x2079361", VA = "0x2079260")]
		public void Send(FurnitureCreatePoint point, FurnitureID id, bool create = true, bool is_reserve = false)
		{
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574A")]
		[Address(RVA = "0x2079800", Offset = "0x2079901", VA = "0x2079800")]
		public void Create(FurnitureID id)
		{
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574B")]
		[Address(RVA = "0x2079A30", Offset = "0x2079B31", VA = "0x2079A30")]
		public void Create(FurnitureID id, Vector3 pos, float ry, FieldSceneId fieldSceneId, bool create = false, bool effect = false, bool is_reserve = false)
		{
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574C")]
		[Address(RVA = "0x2079D00", Offset = "0x2079E01", VA = "0x2079D00")]
		public void CreateHave(FurnitureID id)
		{
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574D")]
		[Address(RVA = "0x2079FF0", Offset = "0x207A0F1", VA = "0x2079FF0")]
		public void HaveFanitureReload()
		{
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574E")]
		[Address(RVA = "0x207A2A0", Offset = "0x207A3A1", VA = "0x207A2A0")]
		public void HaveSaveData(string guid)
		{
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574F")]
		[Address(RVA = "0x207A2E0", Offset = "0x207A3E1", VA = "0x207A2E0")]
		public void RemoveSave(string guid)
		{
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x207A360", Offset = "0x207A461", VA = "0x207A360")]
		public int GetFurnitureCount(FurnitureID furnitureId)
		{
			return 0;
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005751")]
		[Address(RVA = "0x207A3A0", Offset = "0x207A4A1", VA = "0x207A3A0")]
		public void AllBreak()
		{
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005752")]
		[Address(RVA = "0x207A500", Offset = "0x207A601", VA = "0x207A500")]
		public void OnPutSave(string guid, Vector3 pos, Quaternion rot)
		{
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005753")]
		[Address(RVA = "0x2079690", Offset = "0x2079791", VA = "0x2079690")]
		private void Create(int PrefabId, Vector3 pos, Quaternion rot, string unique_id, int hp, [Optional] Action<PlayerItemFurniture2> callback, bool effect = false)
		{
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005754")]
		[Address(RVA = "0x207A5B0", Offset = "0x207A6B1", VA = "0x207A5B0")]
		private void Craft(CraftCategoryId category)
		{
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005755")]
		[Address(RVA = "0x207A790", Offset = "0x207A891", VA = "0x207A790")]
		private void OpenStorage(UILoader.ObjectNumber storage)
		{
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005756")]
		[Address(RVA = "0x207A8E0", Offset = "0x207A9E1", VA = "0x207A8E0")]
		public void Command(int cmd_id, int para1, int para2, Action callback)
		{
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005757")]
		[Address(RVA = "0x207CF20", Offset = "0x207D021", VA = "0x207CF20")]
		private void SekizaiMokuzaiPopAll()
		{
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005758")]
		[Address(RVA = "0x207D150", Offset = "0x207D251", VA = "0x207D150")]
		private void WeedPopAll()
		{
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005759")]
		[Address(RVA = "0x207D340", Offset = "0x207D441", VA = "0x207D340")]
		private void GrassPopAll()
		{
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x207D710", Offset = "0x207D811", VA = "0x207D710")]
		public void SetHaveCostume()
		{
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x207DB20", Offset = "0x207DC21", VA = "0x207DB20")]
		private void CostumeChange(ActorID actorId = ActorID.act000, ActorType actorType = ActorType.PlayerBase, CharID charId = CharID.ch000, VariationNo variationNo = VariationNo.VARIA_000, HairType hairType = HairType.HAIR00_00)
		{
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x207CB80", Offset = "0x207CC81", VA = "0x207CB80")]
		private void PlayerCostumeChange(VariationNo variationNo = VariationNo.VARIA_000)
		{
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575D")]
		[Address(RVA = "0x207CC10", Offset = "0x207CD11", VA = "0x207CC10")]
		private void PartyCostumeChange(int num, VariationNo variationNo = VariationNo.VARIA_000)
		{
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575E")]
		[Address(RVA = "0x207DBC0", Offset = "0x207DCC1", VA = "0x207DBC0")]
		private void GetList(CharID charId, HairType hairType = HairType.HAIR00_00)
		{
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575F")]
		[Address(RVA = "0x207C710", Offset = "0x207C811", VA = "0x207C710")]
		private void GetCostumeListString(CharID charID = CharID.ch000, HairType hairType = HairType.HAIR00_00)
		{
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x00023DC0 File Offset: 0x00021FC0
		[Token(Token = "0x6005760")]
		[Address(RVA = "0x2078A40", Offset = "0x2078B41", VA = "0x2078A40")]
		private int GetPartyNum_Nimbus()
		{
			return 0;
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x00023DD8 File Offset: 0x00021FD8
		[Token(Token = "0x6005761")]
		[Address(RVA = "0x207C980", Offset = "0x207CA81", VA = "0x207C980")]
		private int GetPartyNum()
		{
			return 0;
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005762")]
		[Address(RVA = "0x207C3D0", Offset = "0x207C4D1", VA = "0x207C3D0")]
		private void GetPartyString()
		{
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x00023DF0 File Offset: 0x00021FF0
		[Token(Token = "0x6005763")]
		[Address(RVA = "0x207CA70", Offset = "0x207CB71", VA = "0x207CA70")]
		private CharID GetPartyCharID(int num)
		{
			return CharID.ch000;
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x00023E08 File Offset: 0x00022008
		[Token(Token = "0x6005764")]
		[Address(RVA = "0x207DE00", Offset = "0x207DF01", VA = "0x207DE00")]
		private bool CheckAndCreateWardrobe(FieldSceneId sceneId)
		{
			return default(bool);
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x00023E20 File Offset: 0x00022020
		[Token(Token = "0x6005765")]
		[Address(RVA = "0x207DF80", Offset = "0x207E081", VA = "0x207DF80")]
		private static bool CheckDLCWithDLCCosutume()
		{
			return default(bool);
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00023E38 File Offset: 0x00022038
		[Token(Token = "0x6005766")]
		[Address(RVA = "0x207E230", Offset = "0x207E331", VA = "0x207E230")]
		public bool CreateWardrobe(FurnitureCreatePoint point = FurnitureCreatePoint.MyHome, FurnitureID id = FurnitureID.Item_Furniture_020, bool create = false)
		{
			return default(bool);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005767")]
		[Address(RVA = "0x207C5E0", Offset = "0x207C6E1", VA = "0x207C5E0")]
		private void SelectList(List<string> selectList, int select_jump_no, int return_jump_no)
		{
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005768")]
		[Address(RVA = "0x207CE70", Offset = "0x207CF71", VA = "0x207CE70")]
		private void PlayBgm(BGMID id)
		{
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005769")]
		[Address(RVA = "0x207E2F0", Offset = "0x207E3F1", VA = "0x207E2F0")]
		private void ReturnScript(string script_name)
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576A")]
		[Address(RVA = "0x207E370", Offset = "0x207E471", VA = "0x207E370")]
		private void CallScript(string script_name)
		{
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x00023E50 File Offset: 0x00022050
		[Token(Token = "0x600576B")]
		[Address(RVA = "0x207DF40", Offset = "0x207E041", VA = "0x207DF40")]
		public static bool CheckHadFurniture(FurnitureID id)
		{
			return default(bool);
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576C")]
		[Address(RVA = "0x207E410", Offset = "0x207E511", VA = "0x207E410")]
		public List<GameObject> GetSameRoomFurniture(FieldSceneId fieldSceneId)
		{
			return null;
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576D")]
		[Address(RVA = "0x207E740", Offset = "0x207E841", VA = "0x207E740")]
		public void UpdateMeshShadow(Func<float, bool> checkEnableShadowFunc)
		{
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576E")]
		[Address(RVA = "0x207EA60", Offset = "0x207EB61", VA = "0x207EA60")]
		public void ResetMeshShadow()
		{
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576F")]
		[Address(RVA = "0x207EC20", Offset = "0x207ED21", VA = "0x207EC20")]
		public void ShippingBoxShake()
		{
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005770")]
		[Address(RVA = "0x207EE50", Offset = "0x207EF51", VA = "0x207EE50")]
		public FurnitureManager()
		{
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005771")]
		[Address(RVA = "0x207F350", Offset = "0x207F451", VA = "0x207F350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD310", Offset = "0x1AD411")]
		private void <Send>b__39_0(PlayerItemFurniture2 obj)
		{
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005772")]
		[Address(RVA = "0x207F3C0", Offset = "0x207F4C1", VA = "0x207F3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD320", Offset = "0x1AD421")]
		private void <Create>b__41_0(PlayerItemFurniture2 obj)
		{
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005773")]
		[Address(RVA = "0x207F430", Offset = "0x207F531", VA = "0x207F430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD330", Offset = "0x1AD431")]
		private void <CreateHave>b__42_0(PlayerItemFurniture2 obj)
		{
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005774")]
		[Address(RVA = "0x207F550", Offset = "0x207F651", VA = "0x207F550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD340", Offset = "0x1AD441")]
		private void <HaveFanitureReload>b__43_0(PlayerItemFurniture2 obj)
		{
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x207F5D0", Offset = "0x207F6D1", VA = "0x207F5D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD350", Offset = "0x1AD451")]
		private void <Command>b__52_2()
		{
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x207F620", Offset = "0x207F721", VA = "0x207F620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD360", Offset = "0x1AD461")]
		private void <Command>b__52_3()
		{
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005777")]
		[Address(RVA = "0x207F670", Offset = "0x207F771", VA = "0x207F670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD370", Offset = "0x1AD471")]
		private void <Command>b__52_4()
		{
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005778")]
		[Address(RVA = "0x207F710", Offset = "0x207F811", VA = "0x207F710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD380", Offset = "0x1AD481")]
		private void <Command>b__52_5()
		{
		}

		// Token: 0x04017108 RID: 94472
		[Token(Token = "0x4013D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NotEntryPetIndex;

		// Token: 0x04017109 RID: 94473
		[Token(Token = "0x4013D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool GramophoneBgmPlay;

		// Token: 0x0401710A RID: 94474
		[Token(Token = "0x4013D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FurnitureShadow furnitureShadow;

		// Token: 0x0401710B RID: 94475
		[Token(Token = "0x4013D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerItemFurniture2 playerItemFurniture2;

		// Token: 0x0401710C RID: 94476
		[Token(Token = "0x4013D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FurnitureBlock furnitureBlock;

		// Token: 0x0401710D RID: 94477
		[Token(Token = "0x4013D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HideInInspector", RVA = "0x180430", Offset = "0x180531")]
		public FlyingNimbus flyingNimbus;

		// Token: 0x0401710E RID: 94478
		[Token(Token = "0x4013D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<PlayerItemFurniture2> FurnitureObjectList;

		// Token: 0x0401710F RID: 94479
		[Token(Token = "0x4013D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FurnitureManager.SendPos[] sendpos_tbl_;

		// Token: 0x04017110 RID: 94480
		[Token(Token = "0x4013D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<VariationNo> CostumeList;

		// Token: 0x04017111 RID: 94481
		[Token(Token = "0x4013D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<string> SelectStringList;

		// Token: 0x04017112 RID: 94482
		[Token(Token = "0x4013D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int WhoCostumeChange;

		// Token: 0x04017113 RID: 94483
		[Token(Token = "0x4013D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool[] HaveCostume;

		// Token: 0x04017114 RID: 94484
		[Token(Token = "0x4013D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<BgmList> RecordList;

		// Token: 0x04017115 RID: 94485
		[Token(Token = "0x4013D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FurnitureID CreateId;

		// Token: 0x04017116 RID: 94486
		[Token(Token = "0x4013D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<GameObject> SameRoomFurnitureList;

		// Token: 0x04017117 RID: 94487
		[Token(Token = "0x4013D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180440", Offset = "0x180541")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x180440", Offset = "0x180541")]
		public float ShadowHeight;

		// Token: 0x04017118 RID: 94488
		[Token(Token = "0x4013D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1804B0", Offset = "0x1805B1")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1804B0", Offset = "0x1805B1")]
		public float ShadowStep;

		// Token: 0x04017119 RID: 94489
		[Token(Token = "0x4013D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180520", Offset = "0x180621")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x180520", Offset = "0x180621")]
		public float Thunderbolt_Short_or_Long;

		// Token: 0x0401711A RID: 94490
		[Token(Token = "0x4013D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180590", Offset = "0x180691")]
		public float Thunderbolt_Damage_Interval;

		// Token: 0x02001047 RID: 4167
		[Token(Token = "0x200151D")]
		private struct SendPos
		{
			// Token: 0x060068F5 RID: 26869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C2B")]
			[Address(RVA = "0x2E0830", Offset = "0x2E0931", VA = "0x2E0830")]
			public SendPos(Vector3 pos, float rot_y, FieldSceneId scene_id)
			{
			}

			// Token: 0x0401711B RID: 94491
			[Token(Token = "0x401BF8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 Pos;

			// Token: 0x0401711C RID: 94492
			[Token(Token = "0x401BF8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float RotY;

			// Token: 0x0401711D RID: 94493
			[Token(Token = "0x401BF90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldSceneId SceneId;
		}

		// Token: 0x02001048 RID: 4168
		[Token(Token = "0x200151E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C20", Offset = "0x159D21")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x060068F6 RID: 26870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C2C")]
			[Address(RVA = "0x207F9B0", Offset = "0x207FAB1", VA = "0x207F9B0")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x060068F7 RID: 26871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C2D")]
			[Address(RVA = "0x207F9C0", Offset = "0x207FAC1", VA = "0x207F9C0")]
			internal void <OnSceneLoad>b__0(PlayerItemFurniture2 obj)
			{
			}

			// Token: 0x0401711E RID: 94494
			[Token(Token = "0x401BF91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FurnitureManager <>4__this;

			// Token: 0x0401711F RID: 94495
			[Token(Token = "0x401BF92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int create;

			// Token: 0x04017120 RID: 94496
			[Token(Token = "0x401BF93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<PlayerItemFurniture2> <>9__0;
		}

		// Token: 0x02001049 RID: 4169
		[Token(Token = "0x200151F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C30", Offset = "0x159D31")]
		private sealed class <OnSceneLoad>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060068F8 RID: 26872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C2E")]
			[Address(RVA = "0x2078D40", Offset = "0x2078E41", VA = "0x2078D40")]
			[DebuggerHidden]
			public <OnSceneLoad>d__25(int <>1__state)
			{
			}

			// Token: 0x060068F9 RID: 26873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C2F")]
			[Address(RVA = "0x207FDC0", Offset = "0x207FEC1", VA = "0x207FDC0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060068FA RID: 26874 RVA: 0x00023E68 File Offset: 0x00022068
			[Token(Token = "0x6007C30")]
			[Address(RVA = "0x207FDD0", Offset = "0x207FED1", VA = "0x207FDD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x060068FB RID: 26875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E81")]
			private object Current
			{
				[Token(Token = "0x6007C31")]
				[Address(RVA = "0x20801B0", Offset = "0x20802B1", VA = "0x20801B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060068FC RID: 26876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C32")]
			[Address(RVA = "0x20801C0", Offset = "0x20802C1", VA = "0x20801C0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D4A RID: 3402
			// (get) Token: 0x060068FD RID: 26877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E82")]
			private object Current
			{
				[Token(Token = "0x6007C33")]
				[Address(RVA = "0x2080220", Offset = "0x2080321", VA = "0x2080220", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017121 RID: 94497
			[Token(Token = "0x401BF94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017122 RID: 94498
			[Token(Token = "0x401BF95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017123 RID: 94499
			[Token(Token = "0x401BF96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FurnitureManager <>4__this;

			// Token: 0x04017124 RID: 94500
			[Token(Token = "0x401BF97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private FurnitureManager.<>c__DisplayClass25_0 <>8__1;

			// Token: 0x04017125 RID: 94501
			[Token(Token = "0x401BF98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <count>5__2;
		}

		// Token: 0x0200104A RID: 4170
		[Token(Token = "0x2001520")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C40", Offset = "0x159D41")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x060068FE RID: 26878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C34")]
			[Address(RVA = "0x207A5A0", Offset = "0x207A6A1", VA = "0x207A5A0")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C35")]
			[Address(RVA = "0x207FA40", Offset = "0x207FB41", VA = "0x207FA40")]
			internal void <Create>b__0(AssetHandle<GameObject> handle)
			{
			}

			// Token: 0x04017126 RID: 94502
			[Token(Token = "0x401BF99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 pos;

			// Token: 0x04017127 RID: 94503
			[Token(Token = "0x401BF9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion rot;

			// Token: 0x04017128 RID: 94504
			[Token(Token = "0x401BF9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string unique_id;

			// Token: 0x04017129 RID: 94505
			[Token(Token = "0x401BF9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int hp;

			// Token: 0x0401712A RID: 94506
			[Token(Token = "0x401BF9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int PrefabId;

			// Token: 0x0401712B RID: 94507
			[Token(Token = "0x401BF9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool effect;

			// Token: 0x0401712C RID: 94508
			[Token(Token = "0x401BF9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action<PlayerItemFurniture2> callback;
		}

		// Token: 0x0200104B RID: 4171
		[Token(Token = "0x2001521")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159C50", Offset = "0x159D51")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006901 RID: 26881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C37")]
			[Address(RVA = "0x207F7D0", Offset = "0x207F8D1", VA = "0x207F7D0")]
			public <>c()
			{
			}

			// Token: 0x06006902 RID: 26882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C38")]
			[Address(RVA = "0x207F7E0", Offset = "0x207F8E1", VA = "0x207F7E0")]
			internal void <Craft>b__50_0()
			{
			}

			// Token: 0x06006903 RID: 26883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C39")]
			[Address(RVA = "0x207F850", Offset = "0x207F951", VA = "0x207F850")]
			internal void <OpenStorage>b__51_0()
			{
			}

			// Token: 0x06006904 RID: 26884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C3A")]
			[Address(RVA = "0x207F8C0", Offset = "0x207F9C1", VA = "0x207F8C0")]
			internal void <Command>b__52_0()
			{
			}

			// Token: 0x06006905 RID: 26885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C3B")]
			[Address(RVA = "0x207F930", Offset = "0x207FA31", VA = "0x207F930")]
			internal void <Command>b__52_1()
			{
			}

			// Token: 0x06006906 RID: 26886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C3C")]
			[Address(RVA = "0x207F9A0", Offset = "0x207FAA1", VA = "0x207F9A0")]
			internal void <Command>b__52_6()
			{
			}

			// Token: 0x0401712D RID: 94509
			[Token(Token = "0x401BFA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly FurnitureManager.<>c <>9;

			// Token: 0x0401712E RID: 94510
			[Token(Token = "0x401BFA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static UnityAction <>9__50_0;

			// Token: 0x0401712F RID: 94511
			[Token(Token = "0x401BFA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static UnityAction <>9__51_0;

			// Token: 0x04017130 RID: 94512
			[Token(Token = "0x401BFA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static UnityAction <>9__52_0;

			// Token: 0x04017131 RID: 94513
			[Token(Token = "0x401BFA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static UnityAction <>9__52_1;

			// Token: 0x04017132 RID: 94514
			[Token(Token = "0x401BFA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Action <>9__52_6;
		}
	}
}
