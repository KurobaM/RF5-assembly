using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;

namespace Tutorial
{
	// Token: 0x02000EAD RID: 3757
	[Token(Token = "0x20009A2")]
	public class TutorialManager : SingletonMonoBehaviour<TutorialManager>
	{
		// Token: 0x06006206 RID: 25094 RVA: 0x00020E80 File Offset: 0x0001F080
		[Token(Token = "0x6005132")]
		[Address(RVA = "0x1FF8F80", Offset = "0x1FF9081", VA = "0x1FF8F80")]
		public bool IsTutorial()
		{
			return default(bool);
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00020E98 File Offset: 0x0001F098
		[Token(Token = "0x6005133")]
		[Address(RVA = "0x1FF8F90", Offset = "0x1FF9091", VA = "0x1FF8F90")]
		public bool IsBattleTutorial()
		{
			return default(bool);
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		[Token(Token = "0x6005134")]
		[Address(RVA = "0x1FF8FB0", Offset = "0x1FF90B1", VA = "0x1FF8FB0")]
		public bool IsFarmTutorial()
		{
			return default(bool);
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[Token(Token = "0x6005135")]
		[Address(RVA = "0x1FF8FD0", Offset = "0x1FF90D1", VA = "0x1FF8FD0")]
		public bool IsBlacksmithTutorial()
		{
			return default(bool);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		[Token(Token = "0x6005136")]
		[Address(RVA = "0x1FF8FF0", Offset = "0x1FF90F1", VA = "0x1FF8FF0")]
		public bool IsFarmEquipError()
		{
			return default(bool);
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		[Token(Token = "0x6005137")]
		[Address(RVA = "0x1FF9020", Offset = "0x1FF9121", VA = "0x1FF9020")]
		public TutorialManager.TutorialMaking IsMakingTutorial()
		{
			return TutorialManager.TutorialMaking.NONE;
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x00020F10 File Offset: 0x0001F110
		[Token(Token = "0x6005138")]
		[Address(RVA = "0x1FF8710", Offset = "0x1FF8811", VA = "0x1FF8710")]
		public bool IsMonsterDead()
		{
			return default(bool);
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x00020F28 File Offset: 0x0001F128
		[Token(Token = "0x6005139")]
		[Address(RVA = "0x1FF9060", Offset = "0x1FF9161", VA = "0x1FF9060")]
		public bool IsRead(int npcId)
		{
			return default(bool);
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513A")]
		[Address(RVA = "0x1FF9110", Offset = "0x1FF9211", VA = "0x1FF9110")]
		public void TutorialStart(Tutorial tuto, [Optional] Action end_action)
		{
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513B")]
		[Address(RVA = "0x1FF92E0", Offset = "0x1FF93E1", VA = "0x1FF92E0")]
		private void Start()
		{
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513C")]
		[Address(RVA = "0x1FF9370", Offset = "0x1FF9471", VA = "0x1FF9370")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513D")]
		[Address(RVA = "0x1FF9380", Offset = "0x1FF9481", VA = "0x1FF9380")]
		public void FarmInBox()
		{
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x00020F40 File Offset: 0x0001F140
		[Token(Token = "0x600513E")]
		[Address(RVA = "0x1FF9480", Offset = "0x1FF9581", VA = "0x1FF9480")]
		private int GetOnGrounditemCount()
		{
			return 0;
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513F")]
		[Address(RVA = "0x1FF9860", Offset = "0x1FF9961", VA = "0x1FF9860")]
		private void Update()
		{
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005140")]
		[Address(RVA = "0x1FFA190", Offset = "0x1FFA291", VA = "0x1FFA190")]
		private void Next()
		{
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00020F58 File Offset: 0x0001F158
		[Token(Token = "0x6005141")]
		[Address(RVA = "0x1FFA480", Offset = "0x1FFA581", VA = "0x1FFA480")]
		private bool CheckFlag(string name)
		{
			return default(bool);
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005142")]
		[Address(RVA = "0x1FFA0A0", Offset = "0x1FFA1A1", VA = "0x1FFA0A0")]
		private void FarmClearEmotion()
		{
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005143")]
		[Address(RVA = "0x1FFAC20", Offset = "0x1FFAD21", VA = "0x1FFAC20")]
		private void PlayEmotionEffect(NPCID npcId, EmotionType emotionType)
		{
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x00020F70 File Offset: 0x0001F170
		[Token(Token = "0x6005144")]
		[Address(RVA = "0x1FF9720", Offset = "0x1FF9821", VA = "0x1FF9720")]
		public bool CallScript(string script_name, [Optional] Action end_action)
		{
			return default(bool);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005145")]
		[Address(RVA = "0x1FFACD0", Offset = "0x1FFADD1", VA = "0x1FFACD0")]
		public void CallScript_Farm(string script_name)
		{
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005146")]
		[Address(RVA = "0x1FFAE60", Offset = "0x1FFAF61", VA = "0x1FFAE60")]
		public void CallScript_CarftUI(string script_name, [Optional] Action end_action)
		{
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005147")]
		[Address(RVA = "0x1FFA1B0", Offset = "0x1FFA2B1", VA = "0x1FFA1B0")]
		private void EnableKey(int buf)
		{
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005148")]
		[Address(RVA = "0x1FFB040", Offset = "0x1FFB141", VA = "0x1FFB040")]
		public void MonsterCreate(string monster, float x, float y, float z)
		{
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x00020F88 File Offset: 0x0001F188
		[Token(Token = "0x6005149")]
		[Address(RVA = "0x1FFA3B0", Offset = "0x1FFA4B1", VA = "0x1FFA3B0")]
		private bool MonsterSetup(string monster)
		{
			return default(bool);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		[Token(Token = "0x600514A")]
		[Address(RVA = "0x1FFB3A0", Offset = "0x1FFB4A1", VA = "0x1FFB3A0")]
		private bool MonsterSetup(int index)
		{
			return default(bool);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		[Token(Token = "0x600514B")]
		[Address(RVA = "0x1FFB450", Offset = "0x1FFB551", VA = "0x1FFB450")]
		private Vector3 GetPlayerPos(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514C")]
		[Address(RVA = "0x1FFB260", Offset = "0x1FFB361", VA = "0x1FFB260")]
		private void Monster(MonsterDataID monsterId, Vector3 pos, UnityAction<MonsterControllerBase> dead, int index)
		{
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514D")]
		[Address(RVA = "0x1FFB4B0", Offset = "0x1FFB5B1", VA = "0x1FFB4B0")]
		private void MocoDead(MonsterControllerBase monster)
		{
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514E")]
		[Address(RVA = "0x1FFB4C0", Offset = "0x1FFB5C1", VA = "0x1FFB4C0")]
		private void WaitStart(float time)
		{
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600514F")]
		[Address(RVA = "0x1FFB4D0", Offset = "0x1FFB5D1", VA = "0x1FFB4D0")]
		public string GetNpcTalk(int npcId)
		{
			return null;
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005150")]
		[Address(RVA = "0x1FFB790", Offset = "0x1FFB891", VA = "0x1FFB790")]
		public void GetItem1()
		{
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005151")]
		[Address(RVA = "0x1FFB820", Offset = "0x1FFB921", VA = "0x1FFB820")]
		public void GetItem2()
		{
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005152")]
		[Address(RVA = "0x1FFB8B0", Offset = "0x1FFB9B1", VA = "0x1FFB8B0")]
		public void GetItem3()
		{
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005153")]
		[Address(RVA = "0x1FFB940", Offset = "0x1FFBA41", VA = "0x1FFB940")]
		public void GetKabu1()
		{
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005154")]
		[Address(RVA = "0x1FFBA00", Offset = "0x1FFBB01", VA = "0x1FFBA00")]
		public void GetKabu9()
		{
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005155")]
		[Address(RVA = "0x1FFBAC0", Offset = "0x1FFBBC1", VA = "0x1FFBAC0")]
		public void GetIron1()
		{
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		[Token(Token = "0x6005156")]
		[Address(RVA = "0x1FF9FB0", Offset = "0x1FFA0B1", VA = "0x1FF9FB0")]
		public bool IsBox()
		{
			return default(bool);
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005157")]
		[Address(RVA = "0x1FFA590", Offset = "0x1FFA691", VA = "0x1FFA590")]
		private void CallUI()
		{
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005158")]
		[Address(RVA = "0x1FFBB60", Offset = "0x1FFBC61", VA = "0x1FFBB60")]
		private void KeepPauseProc()
		{
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x1FFA940", Offset = "0x1FFAA41", VA = "0x1FFA940")]
		private void SetFocusName(int npcId, string name)
		{
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x1FFA6E0", Offset = "0x1FFA7E1", VA = "0x1FFA6E0")]
		private void WallCreate()
		{
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x1FFAA20", Offset = "0x1FFAB21", VA = "0x1FFAA20")]
		private bool WallCreateSub()
		{
			return default(bool);
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x1FFA7D0", Offset = "0x1FFA8D1", VA = "0x1FFA7D0")]
		private void WallDelete()
		{
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x1FFBBF0", Offset = "0x1FFBCF1", VA = "0x1FFBBF0")]
		public void FarmHoe()
		{
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x1FFBC10", Offset = "0x1FFBD11", VA = "0x1FFBC10")]
		public void FarmSeed()
		{
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x1FFBC30", Offset = "0x1FFBD31", VA = "0x1FFBC30")]
		public void FarmPot()
		{
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x1FFBC50", Offset = "0x1FFBD51", VA = "0x1FFBC50")]
		public void FarmComplete()
		{
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x00021000 File Offset: 0x0001F200
		[Token(Token = "0x6005161")]
		[Address(RVA = "0x1FF8800", Offset = "0x1FF8901", VA = "0x1FF8800")]
		public bool IsFarmComplete()
		{
			return default(bool);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x00021018 File Offset: 0x0001F218
		[Token(Token = "0x6005162")]
		[Address(RVA = "0x1FF88C0", Offset = "0x1FF89C1", VA = "0x1FF88C0")]
		public bool IsBlacksmithNextStep()
		{
			return default(bool);
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005163")]
		[Address(RVA = "0x1FFBC60", Offset = "0x1FFBD61", VA = "0x1FFBC60")]
		public void BlacksmithNextStep()
		{
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x00021030 File Offset: 0x0001F230
		[Token(Token = "0x6005164")]
		[Address(RVA = "0x1FFBC70", Offset = "0x1FFBD71", VA = "0x1FFBC70")]
		public bool IsCraftUiClose()
		{
			return default(bool);
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005165")]
		[Address(RVA = "0x1FFBC80", Offset = "0x1FFBD81", VA = "0x1FFBC80")]
		public void MakingClose(bool close)
		{
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x00021048 File Offset: 0x0001F248
		[Token(Token = "0x6005166")]
		[Address(RVA = "0x1FFBC90", Offset = "0x1FFBD91", VA = "0x1FFBC90")]
		public bool IsMakingClose()
		{
			return default(bool);
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005167")]
		[Address(RVA = "0x1FFBCA0", Offset = "0x1FFBDA1", VA = "0x1FFBCA0")]
		public void MakingRuckBig()
		{
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005168")]
		[Address(RVA = "0x1FFBD50", Offset = "0x1FFBE51", VA = "0x1FFBD50")]
		public void MakingFestival()
		{
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005169")]
		[Address(RVA = "0x1FFBE00", Offset = "0x1FFBF01", VA = "0x1FFBE00")]
		public TutorialManager()
		{
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516A")]
		[Address(RVA = "0x1FFC0E0", Offset = "0x1FFC1E1", VA = "0x1FFC0E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7E0", Offset = "0x1AC8E1")]
		private void <TutorialStart>b__32_0(AssetHandle<TutorialDataTableArray> handle)
		{
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516B")]
		[Address(RVA = "0x1FFC160", Offset = "0x1FFC261", VA = "0x1FFC160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC7F0", Offset = "0x1AC8F1")]
		private void <TutorialStart>b__32_1(AssetHandle<GameObject> handle2)
		{
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516C")]
		[Address(RVA = "0x1FFC220", Offset = "0x1FFC321", VA = "0x1FFC220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC800", Offset = "0x1AC901")]
		private void <Update>b__37_0()
		{
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516D")]
		[Address(RVA = "0x1FFC2B0", Offset = "0x1FFC3B1", VA = "0x1FFC2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC810", Offset = "0x1AC911")]
		private void <CallUI>b__64_0()
		{
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x1FFC2C0", Offset = "0x1FFC3C1", VA = "0x1FFC2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC820", Offset = "0x1AC921")]
		private void <WallCreate>b__72_0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x0400C232 RID: 49714
		[Token(Token = "0x40091B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] BattleTutorialPlayerPos;

		// Token: 0x0400C233 RID: 49715
		[Token(Token = "0x40091B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Tutorial ActiveTutorial;

		// Token: 0x0400C234 RID: 49716
		[Token(Token = "0x40091B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int monster_count_;

		// Token: 0x0400C235 RID: 49717
		[Token(Token = "0x40091B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TutorialDataTableArray LoadData;

		// Token: 0x0400C236 RID: 49718
		[Token(Token = "0x40091B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cmd_index;

		// Token: 0x0400C237 RID: 49719
		[Token(Token = "0x40091BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool is_cmd;

		// Token: 0x0400C238 RID: 49720
		[Token(Token = "0x40091BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action EndAction;

		// Token: 0x0400C239 RID: 49721
		[Token(Token = "0x40091BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int TutorialStep;

		// Token: 0x0400C23A RID: 49722
		[Token(Token = "0x40091BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool is_FarmHoe;

		// Token: 0x0400C23B RID: 49723
		[Token(Token = "0x40091BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[SerializeField]
		private bool is_FarmSeed;

		// Token: 0x0400C23C RID: 49724
		[Token(Token = "0x40091BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		[SerializeField]
		private bool is_FarmPot;

		// Token: 0x0400C23D RID: 49725
		[Token(Token = "0x40091C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		[SerializeField]
		private bool is_CraftUIClose;

		// Token: 0x0400C23E RID: 49726
		[Token(Token = "0x40091C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool is_Making_RuckBig;

		// Token: 0x0400C23F RID: 49727
		[Token(Token = "0x40091C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool is_Making_Festival;

		// Token: 0x0400C240 RID: 49728
		[Token(Token = "0x40091C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool is_CloseMaking;

		// Token: 0x0400C241 RID: 49729
		[Token(Token = "0x40091C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		private bool is_BoxIn;

		// Token: 0x0400C242 RID: 49730
		[Token(Token = "0x40091C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool KeepPause;

		// Token: 0x0400C243 RID: 49731
		[Token(Token = "0x40091C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private EnemyBehaviorController[] enemyBehaviorController;

		// Token: 0x0400C244 RID: 49732
		[Token(Token = "0x40091C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject FarmBlock;

		// Token: 0x0400C245 RID: 49733
		[Token(Token = "0x40091C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool is_read;

		// Token: 0x0400C246 RID: 49734
		[Token(Token = "0x40091C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool is_read_martin;

		// Token: 0x0400C247 RID: 49735
		[Token(Token = "0x40091CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool emotion_flag;

		// Token: 0x0400C248 RID: 49736
		[Token(Token = "0x40091CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int LastKeyBuf;

		// Token: 0x0400C249 RID: 49737
		[Token(Token = "0x40091CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float wait_time_;

		// Token: 0x0400C24A RID: 49738
		[Token(Token = "0x40091CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string backup_focusName;

		// Token: 0x0400C24B RID: 49739
		[Token(Token = "0x40091CE")]
		private const int WallID = 16346;

		// Token: 0x0400C24C RID: 49740
		[Token(Token = "0x40091CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject WallPrefab;

		// Token: 0x0400C24D RID: 49741
		[Token(Token = "0x40091D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject[] Wall;

		// Token: 0x0400C24E RID: 49742
		[Token(Token = "0x40091D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int WallIndex;

		// Token: 0x0400C24F RID: 49743
		[Token(Token = "0x40091D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] WallPos;

		// Token: 0x0400C250 RID: 49744
		[Token(Token = "0x40091D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float[] WallRotY;

		// Token: 0x02000EAE RID: 3758
		[Token(Token = "0x2001477")]
		[Flags]
		public enum TutorialKey
		{
			// Token: 0x0400C252 RID: 49746
			[Token(Token = "0x401BC8A")]
			A = 1,
			// Token: 0x0400C253 RID: 49747
			[Token(Token = "0x401BC8B")]
			B = 2,
			// Token: 0x0400C254 RID: 49748
			[Token(Token = "0x401BC8C")]
			Y = 4,
			// Token: 0x0400C255 RID: 49749
			[Token(Token = "0x401BC8D")]
			X = 8,
			// Token: 0x0400C256 RID: 49750
			[Token(Token = "0x401BC8E")]
			L = 16,
			// Token: 0x0400C257 RID: 49751
			[Token(Token = "0x401BC8F")]
			R = 32,
			// Token: 0x0400C258 RID: 49752
			[Token(Token = "0x401BC90")]
			ZL = 64,
			// Token: 0x0400C259 RID: 49753
			[Token(Token = "0x401BC91")]
			ZR = 128,
			// Token: 0x0400C25A RID: 49754
			[Token(Token = "0x401BC92")]
			JU = 256,
			// Token: 0x0400C25B RID: 49755
			[Token(Token = "0x401BC93")]
			JR = 512,
			// Token: 0x0400C25C RID: 49756
			[Token(Token = "0x401BC94")]
			JD = 1024,
			// Token: 0x0400C25D RID: 49757
			[Token(Token = "0x401BC95")]
			JL = 2048,
			// Token: 0x0400C25E RID: 49758
			[Token(Token = "0x401BC96")]
			MS = 4096,
			// Token: 0x0400C25F RID: 49759
			[Token(Token = "0x401BC97")]
			PS = 8192,
			// Token: 0x0400C260 RID: 49760
			[Token(Token = "0x401BC98")]
			AL = 16384,
			// Token: 0x0400C261 RID: 49761
			[Token(Token = "0x401BC99")]
			AR = 32768,
			// Token: 0x0400C262 RID: 49762
			[Token(Token = "0x401BC9A")]
			ARU = 65536,
			// Token: 0x0400C263 RID: 49763
			[Token(Token = "0x401BC9B")]
			ARR = 131072,
			// Token: 0x0400C264 RID: 49764
			[Token(Token = "0x401BC9C")]
			ARD = 262144,
			// Token: 0x0400C265 RID: 49765
			[Token(Token = "0x401BC9D")]
			ARL = 524288,
			// Token: 0x0400C266 RID: 49766
			[Token(Token = "0x401BC9E")]
			ALU = 16777216,
			// Token: 0x0400C267 RID: 49767
			[Token(Token = "0x401BC9F")]
			ALR = 33554432,
			// Token: 0x0400C268 RID: 49768
			[Token(Token = "0x401BCA0")]
			ALD = 67108864,
			// Token: 0x0400C269 RID: 49769
			[Token(Token = "0x401BCA1")]
			ALL = 134217728,
			// Token: 0x0400C26A RID: 49770
			[Token(Token = "0x401BCA2")]
			OK = 1048576,
			// Token: 0x0400C26B RID: 49771
			[Token(Token = "0x401BCA3")]
			NG = 2097152
		}

		// Token: 0x02000EAF RID: 3759
		[Token(Token = "0x2001478")]
		public enum FarmStep
		{
			// Token: 0x0400C26D RID: 49773
			[Token(Token = "0x401BCA5")]
			NONE,
			// Token: 0x0400C26E RID: 49774
			[Token(Token = "0x401BCA6")]
			CLEAN_UP,
			// Token: 0x0400C26F RID: 49775
			[Token(Token = "0x401BCA7")]
			HOE,
			// Token: 0x0400C270 RID: 49776
			[Token(Token = "0x401BCA8")]
			SEED,
			// Token: 0x0400C271 RID: 49777
			[Token(Token = "0x401BCA9")]
			POT,
			// Token: 0x0400C272 RID: 49778
			[Token(Token = "0x401BCAA")]
			END,
			// Token: 0x0400C273 RID: 49779
			[Token(Token = "0x401BCAB")]
			COMPLETE
		}

		// Token: 0x02000EB0 RID: 3760
		[Token(Token = "0x2001479")]
		public enum TutorialMaking
		{
			// Token: 0x0400C275 RID: 49781
			[Token(Token = "0x401BCAD")]
			NONE,
			// Token: 0x0400C276 RID: 49782
			[Token(Token = "0x401BCAE")]
			RUCK_BIG,
			// Token: 0x0400C277 RID: 49783
			[Token(Token = "0x401BCAF")]
			FESTIVAL,
			// Token: 0x0400C278 RID: 49784
			[Token(Token = "0x401BCB0")]
			END
		}

		// Token: 0x02000EB1 RID: 3761
		[Token(Token = "0x200147A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A40", Offset = "0x159B41")]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06006243 RID: 25155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B83")]
			[Address(RVA = "0x1FFACC0", Offset = "0x1FFADC1", VA = "0x1FFACC0")]
			public <>c__DisplayClass43_0()
			{
			}

			// Token: 0x06006244 RID: 25156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B84")]
			[Address(RVA = "0x1FFC340", Offset = "0x1FFC441", VA = "0x1FFC340")]
			internal void <CallScript>b__0()
			{
			}

			// Token: 0x0400C279 RID: 49785
			[Token(Token = "0x401BCB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action end_action;
		}

		// Token: 0x02000EB2 RID: 3762
		[Token(Token = "0x200147B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A50", Offset = "0x159B51")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x06006245 RID: 25157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B85")]
			[Address(RVA = "0x1FFAE50", Offset = "0x1FFAF51", VA = "0x1FFAE50")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x06006246 RID: 25158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B86")]
			[Address(RVA = "0x1FFC360", Offset = "0x1FFC461", VA = "0x1FFC360")]
			internal void <CallScript_Farm>b__0()
			{
			}

			// Token: 0x0400C27A RID: 49786
			[Token(Token = "0x401BCB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int temp;

			// Token: 0x0400C27B RID: 49787
			[Token(Token = "0x401BCB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialManager <>4__this;
		}

		// Token: 0x02000EB3 RID: 3763
		[Token(Token = "0x200147C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A60", Offset = "0x159B61")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06006247 RID: 25159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B87")]
			[Address(RVA = "0x1FFB020", Offset = "0x1FFB121", VA = "0x1FFB020")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x0400C27C RID: 49788
			[Token(Token = "0x401BCB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TutorialManager <>4__this;

			// Token: 0x0400C27D RID: 49789
			[Token(Token = "0x401BCB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action end_action;
		}

		// Token: 0x02000EB4 RID: 3764
		[Token(Token = "0x200147D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A70", Offset = "0x159B71")]
		private sealed class <>c__DisplayClass45_1
		{
			// Token: 0x06006248 RID: 25160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B88")]
			[Address(RVA = "0x1FFB030", Offset = "0x1FFB131", VA = "0x1FFB030")]
			public <>c__DisplayClass45_1()
			{
			}

			// Token: 0x06006249 RID: 25161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B89")]
			[Address(RVA = "0x1FFC400", Offset = "0x1FFC501", VA = "0x1FFC400")]
			internal void <CallScript_CarftUI>b__0()
			{
			}

			// Token: 0x0400C27E RID: 49790
			[Token(Token = "0x401BCB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int temp;

			// Token: 0x0400C27F RID: 49791
			[Token(Token = "0x401BCB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialManager.<>c__DisplayClass45_0 CS$<>8__locals1;
		}

		// Token: 0x02000EB5 RID: 3765
		[Token(Token = "0x200147E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A80", Offset = "0x159B81")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x0600624A RID: 25162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B8A")]
			[Address(RVA = "0x1FFB4A0", Offset = "0x1FFB5A1", VA = "0x1FFB4A0")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x0600624B RID: 25163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B8B")]
			[Address(RVA = "0x1FFC4B0", Offset = "0x1FFC5B1", VA = "0x1FFC4B0")]
			internal void <Monster>b__0(MonsterControllerBase monsterController)
			{
			}

			// Token: 0x0400C280 RID: 49792
			[Token(Token = "0x401BCB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityAction<MonsterControllerBase> dead;

			// Token: 0x0400C281 RID: 49793
			[Token(Token = "0x401BCB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pos;

			// Token: 0x0400C282 RID: 49794
			[Token(Token = "0x401BCBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TutorialManager <>4__this;

			// Token: 0x0400C283 RID: 49795
			[Token(Token = "0x401BCBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int index;
		}

		// Token: 0x02000EB6 RID: 3766
		[Token(Token = "0x200147F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159A90", Offset = "0x159B91")]
		private sealed class <>c__DisplayClass52_1
		{
			// Token: 0x0600624C RID: 25164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B8C")]
			[Address(RVA = "0x1FFC5D0", Offset = "0x1FFC6D1", VA = "0x1FFC5D0")]
			public <>c__DisplayClass52_1()
			{
			}

			// Token: 0x0600624D RID: 25165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B8D")]
			[Address(RVA = "0x1FFC5E0", Offset = "0x1FFC6E1", VA = "0x1FFC5E0")]
			internal void <Monster>b__1(EnemyBehaviorController behavior)
			{
			}

			// Token: 0x0400C284 RID: 49796
			[Token(Token = "0x401BCBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MonsterControllerBase monsterController;

			// Token: 0x0400C285 RID: 49797
			[Token(Token = "0x401BCBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TutorialManager.<>c__DisplayClass52_0 CS$<>8__locals1;
		}
	}
}
