using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

namespace Fishing
{
	// Token: 0x02001064 RID: 4196
	[Token(Token = "0x2000AA6")]
	public class FishingManager : SingletonMonoBehaviour<FishingManager>
	{
		// Token: 0x060069B1 RID: 27057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005805")]
		[Address(RVA = "0x2039410", Offset = "0x2039511", VA = "0x2039410")]
		public void SetRecord(ItemID fish_id, int size, int stamp)
		{
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x000241F8 File Offset: 0x000223F8
		[Token(Token = "0x6005806")]
		[Address(RVA = "0x2039690", Offset = "0x2039791", VA = "0x2039690")]
		public int SetStamp(ItemID name, int size)
		{
			return 0;
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x00024210 File Offset: 0x00022410
		[Token(Token = "0x6005807")]
		[Address(RVA = "0x20397E0", Offset = "0x20398E1", VA = "0x20397E0")]
		private float GetDispScale(int disp_size_)
		{
			return 0f;
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x00024228 File Offset: 0x00022428
		[Token(Token = "0x6005808")]
		[Address(RVA = "0x2039820", Offset = "0x2039921", VA = "0x2039820")]
		private int GetDispSize(int size)
		{
			return 0;
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005809")]
		[Address(RVA = "0x2039880", Offset = "0x2039981", VA = "0x2039880")]
		private void Start()
		{
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580A")]
		[Address(RVA = "0x2039C50", Offset = "0x2039D51", VA = "0x2039C50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580B")]
		[Address(RVA = "0x203A2E0", Offset = "0x203A3E1", VA = "0x203A2E0")]
		private void Update()
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580C")]
		[Address(RVA = "0x203AA70", Offset = "0x203AB71", VA = "0x203AA70")]
		private void PointUpdate()
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580D")]
		[Address(RVA = "0x203B550", Offset = "0x203B651", VA = "0x203B550")]
		public void RemovePoint(FishingPoint point)
		{
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580E")]
		[Address(RVA = "0x203B650", Offset = "0x203B751", VA = "0x203B650")]
		private void RemoveAllFishList(int unique_id)
		{
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x00024240 File Offset: 0x00022440
		[Token(Token = "0x600580F")]
		[Address(RVA = "0x203B720", Offset = "0x203B821", VA = "0x203B720")]
		private bool CheckDayFish()
		{
			return default(bool);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005810")]
		[Address(RVA = "0x203AD90", Offset = "0x203AE91", VA = "0x203AD90")]
		private void UpdateDayFish()
		{
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x00024258 File Offset: 0x00022458
		[Token(Token = "0x6005811")]
		[Address(RVA = "0x203B8A0", Offset = "0x203B9A1", VA = "0x203B8A0")]
		public int IsDay()
		{
			return 0;
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005812")]
		[Address(RVA = "0x203B940", Offset = "0x203BA41", VA = "0x203B940")]
		public void Create(FishingPoint point, int max = 3)
		{
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005813")]
		[Address(RVA = "0x203C550", Offset = "0x203C651", VA = "0x203C550")]
		private void Respawn(FishSwim fs)
		{
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005814")]
		[Address(RVA = "0x203CA30", Offset = "0x203CB31", VA = "0x203CA30")]
		public void SetTargetFish(FishSwim target)
		{
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x00024270 File Offset: 0x00022470
		[Token(Token = "0x6005815")]
		[Address(RVA = "0x2038D40", Offset = "0x2038E41", VA = "0x2038D40")]
		public int GetTargetFishSize()
		{
			return 0;
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x00024288 File Offset: 0x00022488
		[Token(Token = "0x6005816")]
		[Address(RVA = "0x2037180", Offset = "0x2037281", VA = "0x2037180")]
		public bool IsDecideTarget(int unique_id)
		{
			return default(bool);
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x000242A0 File Offset: 0x000224A0
		[Token(Token = "0x6005817")]
		[Address(RVA = "0x2035DC0", Offset = "0x2035EC1", VA = "0x2035DC0")]
		public int GetUniqueId()
		{
			return 0;
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005818")]
		[Address(RVA = "0x2037110", Offset = "0x2037211", VA = "0x2037110")]
		public void Add(int unique_id, FishSwim target)
		{
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005819")]
		[Address(RVA = "0x203CA40", Offset = "0x203CB41", VA = "0x203CA40")]
		private void Remove(int unique_id)
		{
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x203CAB0", Offset = "0x203CBB1", VA = "0x203CAB0")]
		private void WkiBack()
		{
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581B")]
		[Address(RVA = "0x203C4C0", Offset = "0x203C5C1", VA = "0x203C4C0")]
		private void InactiveAdd(int unique_id, FishSwim target, float time = 60f)
		{
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581C")]
		[Address(RVA = "0x203CC20", Offset = "0x203CD21", VA = "0x203CC20")]
		private void InactiveRemove(int unique_id)
		{
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581D")]
		[Address(RVA = "0x203B050", Offset = "0x203B151", VA = "0x203B050")]
		private void InactiveUpdate()
		{
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581E")]
		[Address(RVA = "0x203C450", Offset = "0x203C551", VA = "0x203C450")]
		private void PointSpwanAdd(int unique_id, FishSwim target)
		{
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581F")]
		[Address(RVA = "0x203CC90", Offset = "0x203CD91", VA = "0x203CC90")]
		private void PointSpwanRemove(int unique_id)
		{
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005820")]
		[Address(RVA = "0x203CD00", Offset = "0x203CE01", VA = "0x203CD00")]
		public void PointSpwanCheck(Vector3 pos)
		{
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005821")]
		[Address(RVA = "0x2035F60", Offset = "0x2036061", VA = "0x2035F60")]
		public void DestroyFish(int unique_id)
		{
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005822")]
		[Address(RVA = "0x203CF50", Offset = "0x203D051", VA = "0x203CF50")]
		private void CreateHitFish()
		{
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005823")]
		[Address(RVA = "0x203D200", Offset = "0x203D301", VA = "0x203D200")]
		public void SpawnHitFish(Quaternion dir)
		{
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x000242B8 File Offset: 0x000224B8
		[Token(Token = "0x6005824")]
		[Address(RVA = "0x203DAF0", Offset = "0x203DBF1", VA = "0x203DAF0")]
		public float GetAim(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060069D1 RID: 27089 RVA: 0x000242D0 File Offset: 0x000224D0
		[Token(Token = "0x17000A95")]
		public Vector3 WkiPos
		{
			[Token(Token = "0x6005825")]
			[Address(RVA = "0x2037050", Offset = "0x2037151", VA = "0x2037050")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A96")]
		private HumanController _human
		{
			[Token(Token = "0x6005826")]
			[Address(RVA = "0x203DB90", Offset = "0x203DC91", VA = "0x203DB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005827")]
		[Address(RVA = "0x203DC00", Offset = "0x203DD01", VA = "0x203DC00")]
		public void WkiEntry()
		{
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005828")]
		[Address(RVA = "0x203A070", Offset = "0x203A171", VA = "0x203A070")]
		private void WkiRemove(Dictionary<EquipSlotType, HumanEquipItem> equipItemDic)
		{
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005829")]
		[Address(RVA = "0x203DE10", Offset = "0x203DF11", VA = "0x203DE10")]
		public void WkiCast(Character chara, Vector3 pos, Quaternion dir)
		{
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x000242E8 File Offset: 0x000224E8
		[Token(Token = "0x600582A")]
		[Address(RVA = "0x203E250", Offset = "0x203E351", VA = "0x203E250")]
		public bool IsWkiTopWater()
		{
			return default(bool);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00024300 File Offset: 0x00022500
		[Token(Token = "0x600582B")]
		[Address(RVA = "0x203E350", Offset = "0x203E451", VA = "0x203E350")]
		public bool IsWkiGround()
		{
			return default(bool);
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x00024318 File Offset: 0x00022518
		[Token(Token = "0x600582C")]
		[Address(RVA = "0x203E440", Offset = "0x203E541", VA = "0x203E440")]
		public bool IsReduceRp()
		{
			return default(bool);
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x00024330 File Offset: 0x00022530
		[Token(Token = "0x600582D")]
		[Address(RVA = "0x203DF10", Offset = "0x203E011", VA = "0x203DF10")]
		private bool WkiCreate()
		{
			return default(bool);
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582E")]
		[Address(RVA = "0x203E450", Offset = "0x203E551", VA = "0x203E450")]
		public void WkiDestroy()
		{
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582F")]
		[Address(RVA = "0x203E230", Offset = "0x203E331", VA = "0x203E230")]
		public void WkiAnime(WkiAnimation.FishAnime anime)
		{
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x00024348 File Offset: 0x00022548
		[Token(Token = "0x6005830")]
		[Address(RVA = "0x2036F10", Offset = "0x2037011", VA = "0x2036F10")]
		public bool IsNear(Vector3 fish_pos)
		{
			return default(bool);
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005831")]
		[Address(RVA = "0x203E5B0", Offset = "0x203E6B1", VA = "0x203E5B0")]
		private void UICreate()
		{
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005832")]
		[Address(RVA = "0x203E7B0", Offset = "0x203E8B1", VA = "0x203E7B0")]
		private void UIDestroy()
		{
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005833")]
		[Address(RVA = "0x2038B60", Offset = "0x2038C61", VA = "0x2038B60")]
		public void FishHit()
		{
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x2037330", Offset = "0x2037431", VA = "0x2037330")]
		public void Escape(bool motion_update = true)
		{
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005835")]
		[Address(RVA = "0x203EC40", Offset = "0x203ED41", VA = "0x203EC40")]
		private void WkiReturn(bool isEscape = false)
		{
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005836")]
		[Address(RVA = "0x2037370", Offset = "0x2037471", VA = "0x2037370")]
		public void Leave(FishSwim target)
		{
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x203EDC0", Offset = "0x203EEC1", VA = "0x203EDC0")]
		public void CancelCore(bool is_escape)
		{
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x203F0B0", Offset = "0x203F1B1", VA = "0x203F0B0")]
		public void WarpCancel()
		{
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005839")]
		[Address(RVA = "0x203E900", Offset = "0x203EA01", VA = "0x203E900")]
		public void PlayerAnimation(string anime)
		{
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x00024360 File Offset: 0x00022560
		[Token(Token = "0x600583A")]
		[Address(RVA = "0x203E860", Offset = "0x203E961", VA = "0x203E860")]
		public bool IsHatten()
		{
			return default(bool);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583B")]
		[Address(RVA = "0x203F2E0", Offset = "0x203F3E1", VA = "0x203F2E0")]
		public void Hatten()
		{
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583C")]
		[Address(RVA = "0x203F400", Offset = "0x203F501", VA = "0x203F400")]
		public void GetFish()
		{
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583D")]
		[Address(RVA = "0x203F5F0", Offset = "0x203F6F1", VA = "0x203F5F0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD660", Offset = "0x1AD761")]
		private IEnumerator GetFish2()
		{
			return null;
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583E")]
		[Address(RVA = "0x203F670", Offset = "0x203F771", VA = "0x203F670")]
		private void OnGroundItemInit(OnGroundItem obj, float xr, float yr, float zr)
		{
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x00024378 File Offset: 0x00022578
		[Token(Token = "0x600583F")]
		[Address(RVA = "0x203F9D0", Offset = "0x203FAD1", VA = "0x203F9D0")]
		private ItemID ReLottery(ItemID item_id)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x00024390 File Offset: 0x00022590
		[Token(Token = "0x6005840")]
		[Address(RVA = "0x203FA80", Offset = "0x203FB81", VA = "0x203FA80")]
		private ItemID ChangeFish(ItemID name)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x000243A8 File Offset: 0x000225A8
		[Token(Token = "0x6005841")]
		[Address(RVA = "0x203FB40", Offset = "0x203FC41", VA = "0x203FB40")]
		private bool CheckGomi(ItemID target)
		{
			return default(bool);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x000243C0 File Offset: 0x000225C0
		[Token(Token = "0x6005842")]
		[Address(RVA = "0x203FB80", Offset = "0x203FC81", VA = "0x203FB80")]
		private bool CheckIka(ItemID target)
		{
			return default(bool);
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x000243D8 File Offset: 0x000225D8
		[Token(Token = "0x6005843")]
		[Address(RVA = "0x203FBB0", Offset = "0x203FCB1", VA = "0x203FBB0")]
		private int CheckFishType(ItemID target)
		{
			return 0;
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005844")]
		[Address(RVA = "0x203EAC0", Offset = "0x203EBC1", VA = "0x203EAC0")]
		private void PlayStopSplashEffect(Transform trans)
		{
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005845")]
		[Address(RVA = "0x203EFD0", Offset = "0x203F0D1", VA = "0x203EFD0")]
		private void StopSplashEffect()
		{
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005846")]
		[Address(RVA = "0x203FBF0", Offset = "0x203FCF1", VA = "0x203FBF0")]
		public void PlayWaitEffect(Transform trans)
		{
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x000243F0 File Offset: 0x000225F0
		[Token(Token = "0x6005847")]
		[Address(RVA = "0x203FE30", Offset = "0x203FF31", VA = "0x203FE30")]
		public bool IsFishing()
		{
			return default(bool);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005848")]
		[Address(RVA = "0x203A3A0", Offset = "0x203A4A1", VA = "0x203A3A0")]
		private void FishingUpdate()
		{
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00024408 File Offset: 0x00022608
		[Token(Token = "0x6005849")]
		[Address(RVA = "0x20400C0", Offset = "0x20401C1", VA = "0x20400C0")]
		private bool IsIroiroTaikai()
		{
			return default(bool);
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x00024420 File Offset: 0x00022620
		[Token(Token = "0x600584A")]
		[Address(RVA = "0x203C360", Offset = "0x203C461", VA = "0x203C360")]
		private bool IsIkaTaikai()
		{
			return default(bool);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x00024438 File Offset: 0x00022638
		[Token(Token = "0x600584B")]
		[Address(RVA = "0x20401B0", Offset = "0x20402B1", VA = "0x20401B0")]
		private bool IsTaikaiEnd()
		{
			return default(bool);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600584C")]
		[Address(RVA = "0x2040240", Offset = "0x2040341", VA = "0x2040240")]
		private void Result(ItemID target)
		{
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060069FA RID: 27130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A97")]
		public string ResultName
		{
			[Token(Token = "0x600584D")]
			[Address(RVA = "0x2040660", Offset = "0x2040761", VA = "0x2040660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD6D0", Offset = "0x1AD7D1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600584E")]
			[Address(RVA = "0x2040670", Offset = "0x2040771", VA = "0x2040670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD6E0", Offset = "0x1AD7E1")]
			private set
			{
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060069FC RID: 27132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A98")]
		public string ResultSize
		{
			[Token(Token = "0x600584F")]
			[Address(RVA = "0x2040680", Offset = "0x2040781", VA = "0x2040680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD6F0", Offset = "0x1AD7F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005850")]
			[Address(RVA = "0x2040690", Offset = "0x2040791", VA = "0x2040690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD700", Offset = "0x1AD801")]
			private set
			{
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060069FD RID: 27133 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060069FE RID: 27134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A99")]
		public string ResultCount
		{
			[Token(Token = "0x6005851")]
			[Address(RVA = "0x20406A0", Offset = "0x20407A1", VA = "0x20406A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD710", Offset = "0x1AD811")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005852")]
			[Address(RVA = "0x20406B0", Offset = "0x20407B1", VA = "0x20406B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD720", Offset = "0x1AD821")]
			private set
			{
			}
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005853")]
		[Address(RVA = "0x203D920", Offset = "0x203DA21", VA = "0x203D920")]
		private string GetPointName()
		{
			return null;
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x00024450 File Offset: 0x00022650
		[Token(Token = "0x6005854")]
		[Address(RVA = "0x20406C0", Offset = "0x20407C1", VA = "0x20406C0")]
		private bool IsSunny()
		{
			return default(bool);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00024468 File Offset: 0x00022668
		[Token(Token = "0x6005855")]
		[Address(RVA = "0x203C160", Offset = "0x203C261", VA = "0x203C160")]
		private int GetSeason(string point_name)
		{
			return 0;
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06006A02 RID: 27138 RVA: 0x00024480 File Offset: 0x00022680
		// (set) Token: 0x06006A03 RID: 27139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A9A")]
		public int ChargeLevel
		{
			[Token(Token = "0x6005856")]
			[Address(RVA = "0x2040730", Offset = "0x2040831", VA = "0x2040730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD730", Offset = "0x1AD831")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005857")]
			[Address(RVA = "0x2040740", Offset = "0x2040841", VA = "0x2040740")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD740", Offset = "0x1AD841")]
			private set
			{
			}
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005858")]
		[Address(RVA = "0x2040750", Offset = "0x2040851", VA = "0x2040750")]
		public void SetChargeLevel(int level)
		{
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005859")]
		[Address(RVA = "0x203FF00", Offset = "0x2040001", VA = "0x203FF00")]
		public void FishingRodAnime(RodAnimation.RodAnime anime)
		{
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585A")]
		[Address(RVA = "0x203FE40", Offset = "0x203FF41", VA = "0x203FE40")]
		private void PlayManpu(EmotionType emotionType, float dispTime = 1000f)
		{
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585B")]
		[Address(RVA = "0x20408A0", Offset = "0x20409A1", VA = "0x20408A0")]
		public void Min2DEffect()
		{
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585C")]
		[Address(RVA = "0x20408C0", Offset = "0x20409C1", VA = "0x20408C0")]
		public void Max2DEffect()
		{
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600585D")]
		[Address(RVA = "0x20408E0", Offset = "0x20409E1", VA = "0x20408E0")]
		public void Stop2DEffect()
		{
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585E")]
		[Address(RVA = "0x2040900", Offset = "0x2040A01", VA = "0x2040900")]
		public FishingManager.ResultTwoPlay GetTwoPlayFish(string point = "HOME-P2-W")
		{
			return null;
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585F")]
		[Address(RVA = "0x2040A50", Offset = "0x2040B51", VA = "0x2040A50")]
		private string GetCmSize(int mmsize)
		{
			return null;
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005860")]
		[Address(RVA = "0x203C250", Offset = "0x203C351", VA = "0x203C250")]
		public ItemData GetRodItemData()
		{
			return null;
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005861")]
		[Address(RVA = "0x2040AE0", Offset = "0x2040BE1", VA = "0x2040AE0")]
		public FishingManager()
		{
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005862")]
		[Address(RVA = "0x2040F80", Offset = "0x2041081", VA = "0x2040F80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD750", Offset = "0x1AD851")]
		private void <Start>b__44_0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005863")]
		[Address(RVA = "0x20410B0", Offset = "0x20411B1", VA = "0x20410B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD760", Offset = "0x1AD861")]
		private void <Start>b__44_1(AssetHandle<GameObject> handle2)
		{
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005864")]
		[Address(RVA = "0x2041230", Offset = "0x2041331", VA = "0x2041230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD770", Offset = "0x1AD871")]
		private void <PlayStopSplashEffect>b__136_0(ParticleSystem par)
		{
		}

		// Token: 0x040171C2 RID: 94658
		[Token(Token = "0x4013DFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float[] dist_tbl_;

		// Token: 0x040171C3 RID: 94659
		[Token(Token = "0x4013E00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float EffectScale;

		// Token: 0x040171C4 RID: 94660
		[Token(Token = "0x4013E01")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float GetFishTime;

		// Token: 0x040171C5 RID: 94661
		[Token(Token = "0x4013E02")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 GetFishRotate;

		// Token: 0x040171C6 RID: 94662
		[Token(Token = "0x4013E03")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180850", Offset = "0x180951")]
		private float SingleFishSpawnTime;

		// Token: 0x040171C7 RID: 94663
		[Token(Token = "0x4013E04")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1808A0", Offset = "0x1809A1")]
		public float FishSwimTime;

		// Token: 0x040171C8 RID: 94664
		[Token(Token = "0x4013E05")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1808F0", Offset = "0x1809F1")]
		public float FishSpawnInterval;

		// Token: 0x040171C9 RID: 94665
		[Token(Token = "0x4013E06")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x180940", Offset = "0x180A41")]
		public float GetFishSpawnInterval;

		// Token: 0x040171CA RID: 94666
		[Token(Token = "0x4013E07")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float Depth;

		// Token: 0x040171CB RID: 94667
		[Token(Token = "0x4013E08")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float Depth2;

		// Token: 0x040171CC RID: 94668
		[Token(Token = "0x4013E09")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float NowDepth;

		// Token: 0x040171CD RID: 94669
		[Token(Token = "0x4013E0A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float PointDistance;

		// Token: 0x040171CE RID: 94670
		[Token(Token = "0x4013E0B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 Effect_FishingGet_Pos;

		// Token: 0x040171CF RID: 94671
		[Token(Token = "0x4013E0C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 Effect_FishingGetFirst_Pos;

		// Token: 0x040171D0 RID: 94672
		[Token(Token = "0x4013E0D")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 FishManpuOffset;

		// Token: 0x040171D1 RID: 94673
		[Token(Token = "0x4013E0E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HideInInspector", RVA = "0x1809F0", Offset = "0x180AF1")]
		public Vector3 OldCameraPos;

		// Token: 0x040171D2 RID: 94674
		[Token(Token = "0x4013E0F")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "HideInInspector", RVA = "0x180A00", Offset = "0x180B01")]
		public Quaternion OldCameraRot;

		// Token: 0x040171D3 RID: 94675
		[Token(Token = "0x4013E10")]
		[FieldOffset(Offset = "0x94")]
		private FishingManager.State state;

		// Token: 0x040171D4 RID: 94676
		[Token(Token = "0x4013E11")]
		[FieldOffset(Offset = "0x98")]
		private bool moyatto_effect;

		// Token: 0x040171D5 RID: 94677
		[Token(Token = "0x4013E12")]
		private const int FishID = 17040;

		// Token: 0x040171D6 RID: 94678
		[Token(Token = "0x4013E13")]
		private const int FishIDNight = 17051;

		// Token: 0x040171D7 RID: 94679
		[Token(Token = "0x4013E14")]
		[FieldOffset(Offset = "0x9C")]
		public readonly Vector3 DisableFishPos;

		// Token: 0x040171D8 RID: 94680
		[Token(Token = "0x4013E15")]
		public const float SPWAN_ADJUST = 0.45f;

		// Token: 0x040171D9 RID: 94681
		[Token(Token = "0x4013E16")]
		[FieldOffset(Offset = "0xA8")]
		private bool IsFirst;

		// Token: 0x040171DA RID: 94682
		[Token(Token = "0x4013E17")]
		[FieldOffset(Offset = "0xA9")]
		private bool IsMin;

		// Token: 0x040171DB RID: 94683
		[Token(Token = "0x4013E18")]
		[FieldOffset(Offset = "0xAA")]
		private bool IsMax;

		// Token: 0x040171DC RID: 94684
		[Token(Token = "0x4013E19")]
		[FieldOffset(Offset = "0xAB")]
		private bool IsGomi;

		// Token: 0x040171DD RID: 94685
		[Token(Token = "0x4013E1A")]
		[FieldOffset(Offset = "0xAC")]
		private bool IsIka;

		// Token: 0x040171DE RID: 94686
		[Token(Token = "0x4013E1B")]
		[FieldOffset(Offset = "0xB0")]
		private int FishType;

		// Token: 0x040171DF RID: 94687
		[Token(Token = "0x4013E1C")]
		private const float DAY_CHANGE_TIME = 1f;

		// Token: 0x040171E0 RID: 94688
		[Token(Token = "0x4013E1D")]
		[FieldOffset(Offset = "0xB4")]
		private float DayChangeCountDown;

		// Token: 0x040171E1 RID: 94689
		[Token(Token = "0x4013E1E")]
		[FieldOffset(Offset = "0xB8")]
		private List<Vector3> FishingBoxList;

		// Token: 0x040171E2 RID: 94690
		[Token(Token = "0x4013E1F")]
		[FieldOffset(Offset = "0xC0")]
		private float FishSpawnIntervalCount;

		// Token: 0x040171E3 RID: 94691
		[Token(Token = "0x4013E20")]
		[FieldOffset(Offset = "0xC8")]
		private List<KeyValuePair<int, FishSwim>> removeTargetLst;

		// Token: 0x040171E4 RID: 94692
		[Token(Token = "0x4013E21")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "HideInInspector", RVA = "0x180A10", Offset = "0x180B11")]
		public FishObjectPool FishObjectPool;

		// Token: 0x040171E5 RID: 94693
		[Token(Token = "0x4013E22")]
		[FieldOffset(Offset = "0xD8")]
		private float[] fish_scale_tbl_;

		// Token: 0x040171E6 RID: 94694
		[Token(Token = "0x4013E23")]
		[FieldOffset(Offset = "0xE0")]
		private int[] fish_size_tbl_;

		// Token: 0x040171E7 RID: 94695
		[Token(Token = "0x4013E24")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject[] FishShadow;

		// Token: 0x040171E8 RID: 94696
		[Token(Token = "0x4013E25")]
		[FieldOffset(Offset = "0xF0")]
		private Material[] FishShadowMaterial;

		// Token: 0x040171E9 RID: 94697
		[Token(Token = "0x4013E26")]
		[FieldOffset(Offset = "0xF8")]
		private List<FishingPoint> PointList;

		// Token: 0x040171EA RID: 94698
		[Token(Token = "0x4013E27")]
		[FieldOffset(Offset = "0x100")]
		private List<FishSwim> AllFishList;

		// Token: 0x040171EB RID: 94699
		[Token(Token = "0x4013E28")]
		[FieldOffset(Offset = "0x108")]
		private FishSwim targetFish;

		// Token: 0x040171EC RID: 94700
		[Token(Token = "0x4013E29")]
		[FieldOffset(Offset = "0x110")]
		private int UniqueId;

		// Token: 0x040171ED RID: 94701
		[Token(Token = "0x4013E2A")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<int, FishSwim> AimingFish;

		// Token: 0x040171EE RID: 94702
		[Token(Token = "0x4013E2B")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<int, FishSwim> InactiveFish;

		// Token: 0x040171EF RID: 94703
		[Token(Token = "0x4013E2C")]
		[FieldOffset(Offset = "0x128")]
		private Dictionary<int, FishSwim> PointSpwanFish;

		// Token: 0x040171F0 RID: 94704
		[Token(Token = "0x4013E2D")]
		[FieldOffset(Offset = "0x130")]
		private FishSwim[] hitFishSwimOrg;

		// Token: 0x040171F1 RID: 94705
		[Token(Token = "0x4013E2E")]
		[FieldOffset(Offset = "0x138")]
		private FishSwim hitFishSwim;

		// Token: 0x040171F2 RID: 94706
		[Token(Token = "0x4013E2F")]
		[FieldOffset(Offset = "0x140")]
		private int hitFishSize;

		// Token: 0x040171F3 RID: 94707
		[Token(Token = "0x4013E30")]
		[FieldOffset(Offset = "0x148")]
		private Transform wkiModel;

		// Token: 0x040171F4 RID: 94708
		[Token(Token = "0x4013E31")]
		[FieldOffset(Offset = "0x150")]
		private Transform wkiHitModel;

		// Token: 0x040171F5 RID: 94709
		[Token(Token = "0x4013E32")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 wkiTempPos;

		// Token: 0x040171F6 RID: 94710
		[Token(Token = "0x4013E33")]
		[FieldOffset(Offset = "0x168")]
		private WkiController wki;

		// Token: 0x040171F7 RID: 94711
		[Token(Token = "0x4013E34")]
		[FieldOffset(Offset = "0x170")]
		private WkiAnimation wkiAnimation;

		// Token: 0x040171F8 RID: 94712
		[Token(Token = "0x4013E35")]
		[FieldOffset(Offset = "0x178")]
		private bool wki_entry_;

		// Token: 0x040171F9 RID: 94713
		[Token(Token = "0x4013E36")]
		private const int WkiId = 17006;

		// Token: 0x040171FA RID: 94714
		[Token(Token = "0x4013E37")]
		private const int WkiHitId = 17007;

		// Token: 0x040171FB RID: 94715
		[Token(Token = "0x4013E38")]
		[FieldOffset(Offset = "0x180")]
		private GameObject wkiOya;

		// Token: 0x040171FC RID: 94716
		[Token(Token = "0x4013E39")]
		[FieldOffset(Offset = "0x188")]
		private FishingUI fishingUI;

		// Token: 0x040171FD RID: 94717
		[Token(Token = "0x4013E3A")]
		private const int UI_ID = 16328;

		// Token: 0x040171FE RID: 94718
		[Token(Token = "0x4013E3B")]
		[FieldOffset(Offset = "0x190")]
		private bool IsPrevWater;

		// Token: 0x040171FF RID: 94719
		[Token(Token = "0x4013E3C")]
		[FieldOffset(Offset = "0x198")]
		private Transform child0;

		// Token: 0x04017200 RID: 94720
		[Token(Token = "0x4013E3D")]
		[FieldOffset(Offset = "0x1A0")]
		private Transform child1;

		// Token: 0x04017201 RID: 94721
		[Token(Token = "0x4013E3E")]
		[FieldOffset(Offset = "0x1A8")]
		private Vector3 child0_pos;

		// Token: 0x04017202 RID: 94722
		[Token(Token = "0x4013E3F")]
		[FieldOffset(Offset = "0x1B4")]
		private Vector3 child1_pos;

		// Token: 0x04017203 RID: 94723
		[Token(Token = "0x4013E40")]
		[FieldOffset(Offset = "0x1C0")]
		private Quaternion child0_rot;

		// Token: 0x04017204 RID: 94724
		[Token(Token = "0x4013E41")]
		[FieldOffset(Offset = "0x1D0")]
		private Quaternion child1_rot;

		// Token: 0x04017205 RID: 94725
		[Token(Token = "0x4013E42")]
		[FieldOffset(Offset = "0x1E0")]
		private OnGroundItem FirstFishObj;

		// Token: 0x04017206 RID: 94726
		[Token(Token = "0x4013E43")]
		[FieldOffset(Offset = "0x1E8")]
		private GameObject oya;

		// Token: 0x04017207 RID: 94727
		[Token(Token = "0x4013E44")]
		[FieldOffset(Offset = "0x1F0")]
		private ParticleSystem splash_effect_hard_;

		// Token: 0x04017208 RID: 94728
		[Token(Token = "0x4013E45")]
		[FieldOffset(Offset = "0x1F8")]
		private float fishingTime;

		// Token: 0x04017209 RID: 94729
		[Token(Token = "0x4013E46")]
		[FieldOffset(Offset = "0x1FC")]
		private bool isFishSpawn;

		// Token: 0x0401720A RID: 94730
		[Token(Token = "0x4013E47")]
		[FieldOffset(Offset = "0x1FD")]
		private bool isFirstAttack;

		// Token: 0x0401720B RID: 94731
		[Token(Token = "0x4013E48")]
		[FieldOffset(Offset = "0x1FE")]
		private bool isHatten;

		// Token: 0x0401720C RID: 94732
		[Token(Token = "0x4013E49")]
		[FieldOffset(Offset = "0x200")]
		private FishingManager.FishingState fishingState;

		// Token: 0x0401720D RID: 94733
		[Token(Token = "0x4013E4A")]
		[FieldOffset(Offset = "0x208")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180A20", Offset = "0x180B21")]
		private string <ResultName>k__BackingField;

		// Token: 0x0401720E RID: 94734
		[Token(Token = "0x4013E4B")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180A30", Offset = "0x180B31")]
		private string <ResultSize>k__BackingField;

		// Token: 0x0401720F RID: 94735
		[Token(Token = "0x4013E4C")]
		[FieldOffset(Offset = "0x218")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180A40", Offset = "0x180B41")]
		private string <ResultCount>k__BackingField;

		// Token: 0x04017210 RID: 94736
		[Token(Token = "0x4013E4D")]
		[FieldOffset(Offset = "0x220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180A50", Offset = "0x180B51")]
		private int <ChargeLevel>k__BackingField;

		// Token: 0x04017211 RID: 94737
		[Token(Token = "0x4013E4E")]
		[FieldOffset(Offset = "0x224")]
		private int RodType;

		// Token: 0x04017212 RID: 94738
		[Token(Token = "0x4013E4F")]
		[FieldOffset(Offset = "0x228")]
		private ItemID EquipRod;

		// Token: 0x02001065 RID: 4197
		[Token(Token = "0x200152A")]
		private enum State
		{
			// Token: 0x04017214 RID: 94740
			[Token(Token = "0x401BFD0")]
			NONE,
			// Token: 0x04017215 RID: 94741
			[Token(Token = "0x401BFD1")]
			INIT,
			// Token: 0x04017216 RID: 94742
			[Token(Token = "0x401BFD2")]
			MAIN,
			// Token: 0x04017217 RID: 94743
			[Token(Token = "0x401BFD3")]
			NEXT
		}

		// Token: 0x02001066 RID: 4198
		[Token(Token = "0x200152B")]
		private enum FishingState
		{
			// Token: 0x04017219 RID: 94745
			[Token(Token = "0x401BFD5")]
			NONE,
			// Token: 0x0401721A RID: 94746
			[Token(Token = "0x401BFD6")]
			CAST,
			// Token: 0x0401721B RID: 94747
			[Token(Token = "0x401BFD7")]
			HIT_WAIT,
			// Token: 0x0401721C RID: 94748
			[Token(Token = "0x401BFD8")]
			HIT,
			// Token: 0x0401721D RID: 94749
			[Token(Token = "0x401BFD9")]
			GET
		}

		// Token: 0x02001067 RID: 4199
		[Token(Token = "0x200152C")]
		public class ResultTwoPlay
		{
			// Token: 0x06006A11 RID: 27153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C5B")]
			[Address(RVA = "0x1EC4460", Offset = "0x1EC4561", VA = "0x1EC4460")]
			public ResultTwoPlay(ItemID fish_id, int size, bool first, bool min, bool max)
			{
			}

			// Token: 0x0401721E RID: 94750
			[Token(Token = "0x401BFDA")]
			[FieldOffset(Offset = "0x10")]
			public ItemID FishId;

			// Token: 0x0401721F RID: 94751
			[Token(Token = "0x401BFDB")]
			[FieldOffset(Offset = "0x14")]
			public int FishSize;

			// Token: 0x04017220 RID: 94752
			[Token(Token = "0x401BFDC")]
			[FieldOffset(Offset = "0x18")]
			public bool IsFirst;

			// Token: 0x04017221 RID: 94753
			[Token(Token = "0x401BFDD")]
			[FieldOffset(Offset = "0x19")]
			public bool IsMin;

			// Token: 0x04017222 RID: 94754
			[Token(Token = "0x401BFDE")]
			[FieldOffset(Offset = "0x1A")]
			public bool IsMax;
		}

		// Token: 0x02001068 RID: 4200
		[Token(Token = "0x200152D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CB0", Offset = "0x159DB1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006A13 RID: 27155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C5D")]
			[Address(RVA = "0x1EC2D40", Offset = "0x1EC2E41", VA = "0x1EC2D40")]
			public <>c()
			{
			}

			// Token: 0x06006A14 RID: 27156 RVA: 0x00024498 File Offset: 0x00022698
			[Token(Token = "0x6007C5E")]
			[Address(RVA = "0x1EC2D50", Offset = "0x1EC2E51", VA = "0x1EC2D50")]
			internal bool <InactiveUpdate>b__70_0(KeyValuePair<int, FishSwim> kv)
			{
				return default(bool);
			}

			// Token: 0x06006A15 RID: 27157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C5F")]
			[Address(RVA = "0x1EC2DB0", Offset = "0x1EC2EB1", VA = "0x1EC2DB0")]
			internal void <PlayWaitEffect>b__138_0(ParticleSystem par)
			{
			}

			// Token: 0x04017223 RID: 94755
			[Token(Token = "0x401BFDF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly FishingManager.<>c <>9;

			// Token: 0x04017224 RID: 94756
			[Token(Token = "0x401BFE0")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<int, FishSwim>, bool> <>9__70_0;

			// Token: 0x04017225 RID: 94757
			[Token(Token = "0x401BFE1")]
			[FieldOffset(Offset = "0x10")]
			public static UnityAction<ParticleSystem> <>9__138_0;
		}

		// Token: 0x02001069 RID: 4201
		[Token(Token = "0x200152E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CC0", Offset = "0x159DC1")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x06006A16 RID: 27158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C60")]
			[Address(RVA = "0x1EC2E20", Offset = "0x1EC2F21", VA = "0x1EC2E20")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x06006A17 RID: 27159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C61")]
			[Address(RVA = "0x1EC2E30", Offset = "0x1EC2F31", VA = "0x1EC2E30")]
			internal void <GetFish2>b__0(OnGroundItem obj)
			{
			}

			// Token: 0x06006A18 RID: 27160 RVA: 0x000244B0 File Offset: 0x000226B0
			[Token(Token = "0x6007C62")]
			[Address(RVA = "0x1EC2F10", Offset = "0x1EC3011", VA = "0x1EC2F10")]
			internal bool <GetFish2>b__1()
			{
				return default(bool);
			}

			// Token: 0x04017226 RID: 94758
			[Token(Token = "0x401BFE2")]
			[FieldOffset(Offset = "0x10")]
			public FishingManager <>4__this;

			// Token: 0x04017227 RID: 94759
			[Token(Token = "0x401BFE3")]
			[FieldOffset(Offset = "0x18")]
			public FishData data;

			// Token: 0x04017228 RID: 94760
			[Token(Token = "0x401BFE4")]
			[FieldOffset(Offset = "0x20")]
			public int size;
		}

		// Token: 0x0200106A RID: 4202
		[Token(Token = "0x200152F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CD0", Offset = "0x159DD1")]
		private sealed class <GetFish2>d__128 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A19 RID: 27161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C63")]
			[Address(RVA = "0x1EC2F90", Offset = "0x1EC3091", VA = "0x1EC2F90")]
			[DebuggerHidden]
			public <GetFish2>d__128(int <>1__state)
			{
			}

			// Token: 0x06006A1A RID: 27162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C64")]
			[Address(RVA = "0x1EC2FC0", Offset = "0x1EC30C1", VA = "0x1EC2FC0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A1B RID: 27163 RVA: 0x000244C8 File Offset: 0x000226C8
			[Token(Token = "0x6007C65")]
			[Address(RVA = "0x1EC2FD0", Offset = "0x1EC30D1", VA = "0x1EC2FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x06006A1C RID: 27164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8D")]
			private object Current
			{
				[Token(Token = "0x6007C66")]
				[Address(RVA = "0x1EC43E0", Offset = "0x1EC44E1", VA = "0x1EC43E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A1D RID: 27165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C67")]
			[Address(RVA = "0x1EC43F0", Offset = "0x1EC44F1", VA = "0x1EC43F0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x06006A1E RID: 27166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8E")]
			private object Current
			{
				[Token(Token = "0x6007C68")]
				[Address(RVA = "0x1EC4450", Offset = "0x1EC4551", VA = "0x1EC4450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017229 RID: 94761
			[Token(Token = "0x401BFE5")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401722A RID: 94762
			[Token(Token = "0x401BFE6")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401722B RID: 94763
			[Token(Token = "0x401BFE7")]
			[FieldOffset(Offset = "0x20")]
			public FishingManager <>4__this;

			// Token: 0x0401722C RID: 94764
			[Token(Token = "0x401BFE8")]
			[FieldOffset(Offset = "0x28")]
			private FishingManager.<>c__DisplayClass128_0 <>8__1;

			// Token: 0x0401722D RID: 94765
			[Token(Token = "0x401BFE9")]
			[FieldOffset(Offset = "0x30")]
			private ItemID <itemId>5__2;

			// Token: 0x0401722E RID: 94766
			[Token(Token = "0x401BFEA")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <target_pos>5__3;

			// Token: 0x0401722F RID: 94767
			[Token(Token = "0x401BFEB")]
			[FieldOffset(Offset = "0x40")]
			private int <itemlevel>5__4;

			// Token: 0x04017230 RID: 94768
			[Token(Token = "0x401BFEC")]
			[FieldOffset(Offset = "0x48")]
			private ItemData <itemData>5__5;
		}
	}
}
