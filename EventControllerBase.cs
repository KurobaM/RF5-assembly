using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Field;
using Il2CppDummyDll;
using RF5UI;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200041A RID: 1050
[Token(Token = "0x200032D")]
public class EventControllerBase : SingletonMonoBehaviour<EventControllerBase>
{
	// Token: 0x06001866 RID: 6246 RVA: 0x0000A7B8 File Offset: 0x000089B8
	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x1DAF170", Offset = "0x1DAF271", VA = "0x1DAF170")]
	public bool IsComplimentTalkOcc(int id)
	{
		return default(bool);
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x0000A7D0 File Offset: 0x000089D0
	[Token(Token = "0x60015A9")]
	[Address(RVA = "0x1DAF1E0", Offset = "0x1DAF2E1", VA = "0x1DAF1E0")]
	public int GetComplimentTalkOcc(int id)
	{
		return 0;
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x1DAFC10", Offset = "0x1DAFD11", VA = "0x1DAFC10")]
	private void RunKokuhakuScript(int npcid)
	{
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x1DB03B0", Offset = "0x1DB04B1", VA = "0x1DB03B0")]
	private void RunDateEventReserveScript(string scriptName)
	{
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x1DB04A0", Offset = "0x1DB05A1", VA = "0x1DB04A0")]
	private void DoSuppo()
	{
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x1DB05C0", Offset = "0x1DB06C1", VA = "0x1DB05C0")]
	private void OnDayCarryDate(int diff)
	{
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x1DB0720", Offset = "0x1DB0821", VA = "0x1DB0720")]
	public void OnHourCarryDate(int diff)
	{
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x1DB0900", Offset = "0x1DB0A01", VA = "0x1DB0900")]
	public void RunDateTalkScript(int npcid)
	{
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x0000A7E8 File Offset: 0x000089E8
	[Token(Token = "0x60015B0")]
	[Address(RVA = "0x1DB10A0", Offset = "0x1DB11A1", VA = "0x1DB10A0")]
	public int BythewayInviteDateResult(int playerSuggStep, int npcSuggStep, int missStep)
	{
		return 0;
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x0000A800 File Offset: 0x00008A00
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x1DB12E0", Offset = "0x1DB13E1", VA = "0x1DB12E0")]
	public int LottelyNpcSuggestionDateSpot(int spotStep, int homeStep, int fesStep)
	{
		return 0;
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0000A818 File Offset: 0x00008A18
	[Token(Token = "0x60015B2")]
	[Address(RVA = "0x1DB1540", Offset = "0x1DB1641", VA = "0x1DB1540")]
	public int GetInviteFesDateStep(int NextDayFesId, int nextStep)
	{
		return 0;
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x0000A830 File Offset: 0x00008A30
	[Token(Token = "0x60015B3")]
	[Address(RVA = "0x1DB14A0", Offset = "0x1DB15A1", VA = "0x1DB14A0")]
	public int GetInveteFesDateId()
	{
		return 0;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x0000A848 File Offset: 0x00008A48
	[Token(Token = "0x60015B4")]
	[Address(RVA = "0x1DB1560", Offset = "0x1DB1661", VA = "0x1DB1560")]
	public bool GetCanDate(int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B5")]
	[Address(RVA = "0x1DB1700", Offset = "0x1DB1801", VA = "0x1DB1700")]
	public void DateEnd(int type)
	{
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B6")]
	[Address(RVA = "0x1DB1E10", Offset = "0x1DB1F11", VA = "0x1DB1E10")]
	private void DateFlagOff()
	{
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x1DB0580", Offset = "0x1DB0681", VA = "0x1DB0580")]
	public void ResetDateReserve()
	{
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015B8")]
	[Address(RVA = "0x1DB1FA0", Offset = "0x1DB20A1", VA = "0x1DB1FA0")]
	private void ReserveQueueCheckContains(string scriptName)
	{
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x0000A860 File Offset: 0x00008A60
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x1DB2180", Offset = "0x1DB2281", VA = "0x1DB2180")]
	public int GetNpcLoveStoryProgress(int npcid)
	{
		return 0;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015BA")]
	[Address(RVA = "0x1DB22B0", Offset = "0x1DB23B1", VA = "0x1DB22B0")]
	public string BathingGiveItemName()
	{
		return null;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x1DB2330", Offset = "0x1DB2431", VA = "0x1DB2330")]
	public void HotSpringPresent(int returnStep, int baseNextStep, bool research)
	{
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x1DB2590", Offset = "0x1DB2691", VA = "0x1DB2590")]
	private void CheckHotSpringPresent()
	{
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x1DB2A80", Offset = "0x1DB2B81", VA = "0x1DB2A80")]
	public void InitPtnPresentNpcIds()
	{
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x0000A878 File Offset: 0x00008A78
	[Token(Token = "0x60015BE")]
	[Address(RVA = "0x1DB2AE0", Offset = "0x1DB2BE1", VA = "0x1DB2AE0")]
	private NpcEventType CheckTutorialAdv()
	{
		return NpcEventType.None;
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x0000A890 File Offset: 0x00008A90
	[Token(Token = "0x60015BF")]
	[Address(RVA = "0x1DB3980", Offset = "0x1DB3A81", VA = "0x1DB3980")]
	private NpcEventType GetRetentionEventType()
	{
		return NpcEventType.None;
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x0000A8A8 File Offset: 0x00008AA8
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x1DB3B20", Offset = "0x1DB3C21", VA = "0x1DB3B20")]
	private NpcEventType GetNpcTalkTypeBefore()
	{
		return NpcEventType.None;
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x0000A8C0 File Offset: 0x00008AC0
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x1DB3D40", Offset = "0x1DB3E41", VA = "0x1DB3D40")]
	private NpcEventType GetNpcTalkType(NpcTalkType startType = NpcTalkType.NONE)
	{
		return NpcEventType.None;
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x0000A8D8 File Offset: 0x00008AD8
	[Token(Token = "0x60015C2")]
	[Address(RVA = "0x1DB3E70", Offset = "0x1DB3F71", VA = "0x1DB3E70")]
	private NpcEventType GetNpcTalkType2(NpcTalkType type, NpcTalkType startType = NpcTalkType.NONE)
	{
		return NpcEventType.None;
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x0000A8F0 File Offset: 0x00008AF0
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x1DB7720", Offset = "0x1DB7821", VA = "0x1DB7720")]
	public int GetTemporaryID()
	{
		return 0;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x0000A908 File Offset: 0x00008B08
	[Token(Token = "0x60015C4")]
	[Address(RVA = "0x1DB7730", Offset = "0x1DB7831", VA = "0x1DB7730")]
	public int GetExclamationID()
	{
		return 0;
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x0000A920 File Offset: 0x00008B20
	[Token(Token = "0x60015C5")]
	[Address(RVA = "0x1DB7740", Offset = "0x1DB7841", VA = "0x1DB7740")]
	public int GetExclamationSkillIDA()
	{
		return 0;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x0000A938 File Offset: 0x00008B38
	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x1DB7750", Offset = "0x1DB7851", VA = "0x1DB7750")]
	public int GetExclamationSkillIDB()
	{
		return 0;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x1DB7760", Offset = "0x1DB7861", VA = "0x1DB7760")]
	public void DEBUG_SetExclamationSkill()
	{
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x0000A950 File Offset: 0x00008B50
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x1DB5DD0", Offset = "0x1DB5ED1", VA = "0x1DB5DD0")]
	private int ExclamationTalkType(NpcData data)
	{
		return 0;
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x1DB7780", Offset = "0x1DB7881", VA = "0x1DB7780")]
	public string GetExclamationItemName()
	{
		return null;
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CA")]
	[Address(RVA = "0x1DB77B0", Offset = "0x1DB78B1", VA = "0x1DB77B0")]
	public string GetExclamationRecipeName()
	{
		return null;
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015CB")]
	[Address(RVA = "0x1DB78F0", Offset = "0x1DB79F1", VA = "0x1DB78F0")]
	public string GetExclamationSkillName()
	{
		return null;
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x0000A968 File Offset: 0x00008B68
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x1DB5CB0", Offset = "0x1DB5DB1", VA = "0x1DB5CB0")]
	private bool CheckSickTalkType()
	{
		return default(bool);
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015CD")]
	[Address(RVA = "0x1DB75F0", Offset = "0x1DB76F1", VA = "0x1DB75F0")]
	private void SickTalkType()
	{
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x0000A980 File Offset: 0x00008B80
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x1DB7480", Offset = "0x1DB7581", VA = "0x1DB7480")]
	private bool CheckSeasonTalkType()
	{
		return default(bool);
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x0000A998 File Offset: 0x00008B98
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x1DB69E0", Offset = "0x1DB6AE1", VA = "0x1DB69E0")]
	public bool CheckRestaurantEventFinished()
	{
		return default(bool);
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x0000A9B0 File Offset: 0x00008BB0
	[Token(Token = "0x60015D0")]
	[Address(RVA = "0x1DB68C0", Offset = "0x1DB69C1", VA = "0x1DB68C0")]
	private ValueTuple<Season, int> GetDiffDay(Season season, int day)
	{
		return default(ValueTuple<Season, int>);
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x0000A9C8 File Offset: 0x00008BC8
	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x1DB7B50", Offset = "0x1DB7C51", VA = "0x1DB7B50")]
	public bool IsNpcOrderTalk(NpcData data)
	{
		return default(bool);
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x0000A9E0 File Offset: 0x00008BE0
	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x1DB7D90", Offset = "0x1DB7E91", VA = "0x1DB7D90")]
	public bool IsNpcSubEventTalk(NpcData data)
	{
		return default(bool);
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x0000A9F8 File Offset: 0x00008BF8
	[Token(Token = "0x60015D3")]
	[Address(RVA = "0x1DB6D70", Offset = "0x1DB6E71", VA = "0x1DB6D70")]
	public bool IsGuestNpc(NPCID id)
	{
		return default(bool);
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x0000AA10 File Offset: 0x00008C10
	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x1DB6970", Offset = "0x1DB6A71", VA = "0x1DB6970")]
	public bool IsWantedFinishedTalk()
	{
		return default(bool);
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x0000AA28 File Offset: 0x00008C28
	[Token(Token = "0x60015D5")]
	[Address(RVA = "0x1DB7E40", Offset = "0x1DB7F41", VA = "0x1DB7E40")]
	public bool CheckCallTutorialScript_BySkill(TutorialScriptType type, SkillID id)
	{
		return default(bool);
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0000AA40 File Offset: 0x00008C40
	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x1DB3870", Offset = "0x1DB3971", VA = "0x1DB3870")]
	public bool CheckCallTutorialScript(TutorialScriptType type)
	{
		return default(bool);
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x1DB7EE0", Offset = "0x1DB7FE1", VA = "0x1DB7EE0")]
	public void ReserveTutorialScript(string scriptName, bool onlyForceScriptName)
	{
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015D8")]
	[Address(RVA = "0x1DB8190", Offset = "0x1DB8291", VA = "0x1DB8190")]
	public void ReserveScriptBase(string scriptName, int npcid = 0)
	{
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x0000AA58 File Offset: 0x00008C58
	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x1DB83D0", Offset = "0x1DB84D1", VA = "0x1DB83D0")]
	public bool TutorialStartQueueLoad()
	{
		return default(bool);
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x1DB8910", Offset = "0x1DB8A11", VA = "0x1DB8910")]
	public void BythewayLethargy(int npcid = 0)
	{
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0000AA70 File Offset: 0x00008C70
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x1DB8C50", Offset = "0x1DB8D51", VA = "0x1DB8C50")]
	private bool BythewayFesDateScript()
	{
		return default(bool);
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x1DB8E10", Offset = "0x1DB8F11", VA = "0x1DB8E10")]
	private void RunBythewayFesDateScript(int type = 1)
	{
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DD")]
	[Address(RVA = "0x1DB93B0", Offset = "0x1DB94B1", VA = "0x1DB93B0")]
	public void RunBythewayStartScript()
	{
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x0000AA88 File Offset: 0x00008C88
	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x1DB99D0", Offset = "0x1DB9AD1", VA = "0x1DB99D0")]
	public bool GetCanPartySelect(int npcid)
	{
		return default(bool);
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x1DB9780", Offset = "0x1DB9881", VA = "0x1DB9780")]
	public void RunBythewaySelectScript()
	{
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E0")]
	[Address(RVA = "0x1DB9EA0", Offset = "0x1DB9FA1", VA = "0x1DB9EA0")]
	public void RunInvitedScript()
	{
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x1DBA240", Offset = "0x1DBA341", VA = "0x1DBA240")]
	public void RunItemPresentScript(NpcData npc, ItemData item, bool isOriginal)
	{
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x0000AAA0 File Offset: 0x00008CA0
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x1DBA5A0", Offset = "0x1DBA6A1", VA = "0x1DBA5A0")]
	public bool RunWeddingRingScript(int npcid, int type)
	{
		return default(bool);
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x0000AAB8 File Offset: 0x00008CB8
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x1DBA8E0", Offset = "0x1DBA9E1", VA = "0x1DBA8E0")]
	public bool CheckRunProposeEventScript(int npcId)
	{
		return default(bool);
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E4")]
	[Address(RVA = "0x1DBA9E0", Offset = "0x1DBAAE1", VA = "0x1DBA9E0")]
	public void SetPrevPresentItemData(ItemData item)
	{
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E5")]
	[Address(RVA = "0x1DBA9F0", Offset = "0x1DBAAF1", VA = "0x1DBA9F0")]
	public void ReleasePrevPresentItemData()
	{
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E6")]
	[Address(RVA = "0x1DBAA00", Offset = "0x1DBAB01", VA = "0x1DBAA00")]
	public void ReturnPresent(Vector3 position, int npcId = 0)
	{
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x1DBAAE0", Offset = "0x1DBABE1", VA = "0x1DBAAE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D7B0", Offset = "0x19D8B1")]
	public IEnumerator ReturnPresentCoroutine(Vector3 position, int npcId = 0)
	{
		return null;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E8")]
	[Address(RVA = "0x1DBAB90", Offset = "0x1DBAC91", VA = "0x1DBAB90")]
	public void PresentAtSeriousScript(int npcid)
	{
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x1DBAC60", Offset = "0x1DBAD61", VA = "0x1DBAC60")]
	public void RunGiveBirthScript(int type)
	{
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EA")]
	[Address(RVA = "0x1DBAC70", Offset = "0x1DBAD71", VA = "0x1DBAC70")]
	public void RunLeavePartnerScript(int npcid)
	{
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x1DBAE70", Offset = "0x1DBAF71", VA = "0x1DBAE70")]
	private void RunMakingScript(string scriptName)
	{
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x1DBB0A0", Offset = "0x1DBB1A1", VA = "0x1DBB0A0")]
	public void RunMakingLicenseScript(MakingID id)
	{
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x1DBB2B0", Offset = "0x1DBB3B1", VA = "0x1DBB2B0")]
	public void RunMakingSuccessScript()
	{
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x1DBB3C0", Offset = "0x1DBB4C1", VA = "0x1DBB3C0")]
	public void RunMakingSuccessEndScript(string scriptName)
	{
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x1DBB3D0", Offset = "0x1DBB4D1", VA = "0x1DBB3D0")]
	public void RunRiviaWantedEndShopScript()
	{
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x1DBB6B0", Offset = "0x1DBB7B1", VA = "0x1DBB6B0")]
	public void RunRiviaWantedCompleteScript()
	{
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x1DBB920", Offset = "0x1DBBA21", VA = "0x1DBB920")]
	public void RunRiviaWantedCompleteRewardScript()
	{
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x1DBBB90", Offset = "0x1DBBC91", VA = "0x1DBBB90")]
	public void RunRiviaWantedCompleteFinishScript()
	{
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x1DBBE00", Offset = "0x1DBBF01", VA = "0x1DBBE00")]
	public void RunRiviaSeedRankUpUIScript()
	{
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x1DBBEA0", Offset = "0x1DBBFA1", VA = "0x1DBBEA0")]
	public void RunRiviaSeedRankUpScript(int rank = 1)
	{
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x1DBC0A0", Offset = "0x1DBC1A1", VA = "0x1DBC0A0")]
	public void RunRiviaGetBadgeUIScript()
	{
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x1DBC140", Offset = "0x1DBC241", VA = "0x1DBC140")]
	public void RunRiviaGetBadgeScript(int type)
	{
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x1DBC250", Offset = "0x1DBC351", VA = "0x1DBC250")]
	public void RunRiviaWantedCompleteNextScript()
	{
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x1DBC2C0", Offset = "0x1DBC3C1", VA = "0x1DBC2C0")]
	public void RunEndMobRenameEndScript(int varNo)
	{
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60015F9")]
	[Address(RVA = "0x1DB89C0", Offset = "0x1DB8AC1", VA = "0x1DB89C0")]
	public string GetLethargyScriptName(int npcid)
	{
		return null;
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FA")]
	[Address(RVA = "0x1DBCCC0", Offset = "0x1DBCDC1", VA = "0x1DBCCC0")]
	public void RunOrderCompleteScript(int orderId = -1)
	{
	}

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C8")]
	public EventSaveParameter EventSaveParameters
	{
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x1DBCEE0", Offset = "0x1DBCFE1", VA = "0x1DBCEE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x1DBCF10", Offset = "0x1DBD011", VA = "0x1DBCF10")]
	public void BeforeSaveEventData()
	{
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015FD")]
	[Address(RVA = "0x1DBD000", Offset = "0x1DBD101", VA = "0x1DBD000")]
	public void AfterLoadEventData()
	{
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x060018BC RID: 6332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003C9")]
	public EventFlagManager FlagManager
	{
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x1DB2220", Offset = "0x1DB2321", VA = "0x1DB2220")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x060018BD RID: 6333 RVA: 0x0000AAD0 File Offset: 0x00008CD0
	// (set) Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CA")]
	public bool IsEventStarted
	{
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x1DBE050", Offset = "0x1DBE151", VA = "0x1DBE050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D820", Offset = "0x19D921")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x1DBE060", Offset = "0x1DBE161", VA = "0x1DBE060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D830", Offset = "0x19D931")]
		set
		{
		}
	}

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x060018BF RID: 6335 RVA: 0x0000AAE8 File Offset: 0x00008CE8
	// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CB")]
	public bool IsEventFinished
	{
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x1DBE070", Offset = "0x1DBE171", VA = "0x1DBE070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D840", Offset = "0x19D941")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x1DBE080", Offset = "0x1DBE181", VA = "0x1DBE080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D850", Offset = "0x19D951")]
		private set
		{
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0000AB00 File Offset: 0x00008D00
	// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CC")]
	public int CurrentEventId
	{
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x1DB6A50", Offset = "0x1DB6B51", VA = "0x1DB6A50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x1DB6B50", Offset = "0x1DB6C51", VA = "0x1DB6B50")]
		set
		{
		}
	}

	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0000AB18 File Offset: 0x00008D18
	// (set) Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CD")]
	public int CurrentEventStep
	{
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x1DBE090", Offset = "0x1DBE191", VA = "0x1DBE090")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x1DBE0D0", Offset = "0x1DBE1D1", VA = "0x1DBE0D0")]
		set
		{
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0000AB30 File Offset: 0x00008D30
	// (set) Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CE")]
	public bool IsTalking
	{
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x1DB8100", Offset = "0x1DB8201", VA = "0x1DB8100")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x1DBE110", Offset = "0x1DBE211", VA = "0x1DBE110")]
		set
		{
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0000AB48 File Offset: 0x00008D48
	// (set) Token: 0x060018C8 RID: 6344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003CF")]
	public int SelectMenuGroupId
	{
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x1DBE210", Offset = "0x1DBE311", VA = "0x1DBE210")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x1DBE250", Offset = "0x1DBE351", VA = "0x1DBE250")]
		set
		{
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0000AB60 File Offset: 0x00008D60
	// (set) Token: 0x060018CA RID: 6346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D0")]
	public bool IsSelectMenu
	{
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x1DBE290", Offset = "0x1DBE391", VA = "0x1DBE290")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x1DBE2D0", Offset = "0x1DBE3D1", VA = "0x1DBE2D0")]
		set
		{
		}
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x060018CB RID: 6347 RVA: 0x0000AB78 File Offset: 0x00008D78
	// (set) Token: 0x060018CC RID: 6348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D1")]
	public int TargetNpcId
	{
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x1DAFA90", Offset = "0x1DAFB91", VA = "0x1DAFA90")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x1DBE320", Offset = "0x1DBE421", VA = "0x1DBE320")]
		set
		{
		}
	}

	// Token: 0x1700043E RID: 1086
	// (get) Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D2")]
	public int[] OrderNpcIds
	{
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x1DBE360", Offset = "0x1DBE461", VA = "0x1DBE360")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x1DBE3A0", Offset = "0x1DBE4A1", VA = "0x1DBE3A0")]
		set
		{
		}
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x060018CF RID: 6351 RVA: 0x0000AB90 File Offset: 0x00008D90
	// (set) Token: 0x060018D0 RID: 6352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D3")]
	public FocusObjectID ObjectInteractionId
	{
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x1DBE3F0", Offset = "0x1DBE4F1", VA = "0x1DBE3F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D860", Offset = "0x19D961")]
		get
		{
			return FocusObjectID.EMPTY;
		}
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x1DBE400", Offset = "0x1DBE501", VA = "0x1DBE400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D870", Offset = "0x19D971")]
		private set
		{
		}
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0000ABA8 File Offset: 0x00008DA8
	// (set) Token: 0x060018D2 RID: 6354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D4")]
	public bool SP4CharaOn
	{
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x1DBE410", Offset = "0x1DBE511", VA = "0x1DBE410")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x1DBE450", Offset = "0x1DBE551", VA = "0x1DBE450")]
		set
		{
		}
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x060018D3 RID: 6355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003D5")]
	public AdvMain advMain
	{
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x1DB1D00", Offset = "0x1DB1E01", VA = "0x1DB1D00")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003D6")]
	public ShortplayAdvController ShortplayAdv
	{
		[Token(Token = "0x6001616")]
		[Address(RVA = "0x1DBE4A0", Offset = "0x1DBE5A1", VA = "0x1DBE4A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018D6 RID: 6358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D7")]
	public EventScheduleData[] EventScheduleDatas
	{
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x1DBE530", Offset = "0x1DBE631", VA = "0x1DBE530")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x1DBE570", Offset = "0x1DBE671", VA = "0x1DBE570")]
		set
		{
		}
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D8")]
	public string ForceScriptName
	{
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x1DB85B0", Offset = "0x1DB86B1", VA = "0x1DB85B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x1DB8140", Offset = "0x1DB8241", VA = "0x1DB8140")]
		set
		{
		}
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x060018D9 RID: 6361 RVA: 0x0000ABC0 File Offset: 0x00008DC0
	// (set) Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003D9")]
	public bool ForceEvent
	{
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x1DB6B90", Offset = "0x1DB6C91", VA = "0x1DB6B90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x1DB6BD0", Offset = "0x1DB6CD1", VA = "0x1DB6BD0")]
		set
		{
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x060018DB RID: 6363 RVA: 0x0000ABD8 File Offset: 0x00008DD8
	// (set) Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003DA")]
	public int orderOccuredId
	{
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x1DBE5C0", Offset = "0x1DBE6C1", VA = "0x1DBE5C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x1DB6A90", Offset = "0x1DB6B91", VA = "0x1DB6A90")]
		set
		{
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x060018DD RID: 6365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003DB")]
	public Character owner
	{
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x1DBE600", Offset = "0x1DBE701", VA = "0x1DBE600")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x060018DE RID: 6366 RVA: 0x0000ABF0 File Offset: 0x00008DF0
	// (set) Token: 0x060018DF RID: 6367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003DC")]
	public int bythewayMenuCommandNo
	{
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x1DB3C80", Offset = "0x1DB3D81", VA = "0x1DB3C80")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x1DB9AF0", Offset = "0x1DB9BF1", VA = "0x1DB9AF0")]
		set
		{
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x060018E0 RID: 6368 RVA: 0x0000AC08 File Offset: 0x00008E08
	// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003DD")]
	public int bythewayEventStep
	{
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x1DBE6D0", Offset = "0x1DBE7D1", VA = "0x1DBE6D0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x1DB9B30", Offset = "0x1DB9C31", VA = "0x1DB9B30")]
		set
		{
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x060018E2 RID: 6370 RVA: 0x0000AC20 File Offset: 0x00008E20
	// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003DE")]
	public bool Is1stBytheWay
	{
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x1DBE710", Offset = "0x1DBE811", VA = "0x1DBE710")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x1DB9360", Offset = "0x1DB9461", VA = "0x1DB9360")]
		set
		{
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x060018E4 RID: 6372 RVA: 0x0000AC38 File Offset: 0x00008E38
	// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003DF")]
	public int partnerMenuCommandNo
	{
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x1DB3D00", Offset = "0x1DB3E01", VA = "0x1DB3D00")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x1DBE750", Offset = "0x1DBE851", VA = "0x1DBE750")]
		set
		{
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0000AC50 File Offset: 0x00008E50
	// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E0")]
	public int partnerEventStep
	{
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x1DB3CC0", Offset = "0x1DB3DC1", VA = "0x1DB3CC0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x1DBE790", Offset = "0x1DBE891", VA = "0x1DBE790")]
		set
		{
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0000AC68 File Offset: 0x00008E68
	// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E1")]
	public int eventValue
	{
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x1DAFA50", Offset = "0x1DAFB51", VA = "0x1DAFA50")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x1DAFA10", Offset = "0x1DAFB11", VA = "0x1DAFA10")]
		set
		{
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x060018EA RID: 6378 RVA: 0x0000AC80 File Offset: 0x00008E80
	// (set) Token: 0x060018EB RID: 6379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E2")]
	public bool UseRetentionEventType
	{
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x1DBE7D0", Offset = "0x1DBE8D1", VA = "0x1DBE7D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x1DB3AD0", Offset = "0x1DB3BD1", VA = "0x1DB3AD0")]
		set
		{
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x060018EC RID: 6380 RVA: 0x0000AC98 File Offset: 0x00008E98
	// (set) Token: 0x060018ED RID: 6381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E3")]
	public bool IsReadable
	{
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x1DBE810", Offset = "0x1DBE911", VA = "0x1DBE810")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x1DBE820", Offset = "0x1DBE921", VA = "0x1DBE820")]
		set
		{
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E4")]
	public List<EventUnlockFlagData> ReservedEventStartPoints
	{
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x1DBE830", Offset = "0x1DBE931", VA = "0x1DBE830")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x1DBE870", Offset = "0x1DBE971", VA = "0x1DBE870")]
		set
		{
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0000ACB0 File Offset: 0x00008EB0
	// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E5")]
	public Place NowPlace
	{
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x1DB6AD0", Offset = "0x1DB6BD1", VA = "0x1DB6AD0")]
		get
		{
			return Place.Field;
		}
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x1DBE8C0", Offset = "0x1DBE9C1", VA = "0x1DBE8C0")]
		set
		{
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x060018F2 RID: 6386 RVA: 0x0000ACC8 File Offset: 0x00008EC8
	// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E6")]
	public int FlagTalkIndex
	{
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x1DBE900", Offset = "0x1DBEA01", VA = "0x1DBE900")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x1DBE940", Offset = "0x1DBEA41", VA = "0x1DBE940")]
		set
		{
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0000ACE0 File Offset: 0x00008EE0
	// (set) Token: 0x060018F5 RID: 6389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E7")]
	public bool IsSleepScriptCalled
	{
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x1DBE980", Offset = "0x1DBEA81", VA = "0x1DBE980")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x1DBE9C0", Offset = "0x1DBEAC1", VA = "0x1DBE9C0")]
		set
		{
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0000ACF8 File Offset: 0x00008EF8
	// (set) Token: 0x060018F7 RID: 6391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E8")]
	public bool IsWakeUpReserve
	{
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x1DBEA10", Offset = "0x1DBEB11", VA = "0x1DBEA10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x1DBEA50", Offset = "0x1DBEB51", VA = "0x1DBEA50")]
		set
		{
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003E9")]
	public bool[] EventCheckTypeFlag
	{
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x1DBEAA0", Offset = "0x1DBEBA1", VA = "0x1DBEAA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x1DBEAE0", Offset = "0x1DBEBE1", VA = "0x1DBEAE0")]
		set
		{
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003EA")]
	public int[] EventCheckType
	{
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x1DBEB30", Offset = "0x1DBEC31", VA = "0x1DBEB30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x1DBEB70", Offset = "0x1DBEC71", VA = "0x1DBEB70")]
		set
		{
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x060018FC RID: 6396 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003EB")]
	public List<EventCheckId> EventCheckIds
	{
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x1DBEBC0", Offset = "0x1DBECC1", VA = "0x1DBEBC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x1DBEC00", Offset = "0x1DBED01", VA = "0x1DBEC00")]
		set
		{
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x060018FE RID: 6398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EC")]
	public LoveEventTextConvertData LoveEventTextConvertData
	{
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x1DBEC50", Offset = "0x1DBED51", VA = "0x1DBEC50")]
		get
		{
			return null;
		}
	}

	// Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001641")]
	[Address(RVA = "0x1DBED50", Offset = "0x1DBEE51", VA = "0x1DBED50", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001900 RID: 6400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x1DBEDA0", Offset = "0x1DBEEA1", VA = "0x1DBEDA0")]
	private void Update()
	{
	}

	// Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x1DBFC90", Offset = "0x1DBFD91", VA = "0x1DBFC90")]
	private void FixedUpdate()
	{
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06001902 RID: 6402 RVA: 0x0000AD10 File Offset: 0x00008F10
	// (set) Token: 0x06001903 RID: 6403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003ED")]
	public bool IsInit
	{
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x1DC0460", Offset = "0x1DC0561", VA = "0x1DC0460")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D880", Offset = "0x19D981")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x1DC0470", Offset = "0x1DC0571", VA = "0x1DC0470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D890", Offset = "0x19D991")]
		private set
		{
		}
	}

	// Token: 0x06001904 RID: 6404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001646")]
	[Address(RVA = "0x1DC0480", Offset = "0x1DC0581", VA = "0x1DC0480")]
	private void LoadAsset()
	{
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001647")]
	[Address(RVA = "0x1DBF0E0", Offset = "0x1DBF1E1", VA = "0x1DBF0E0")]
	public void Init()
	{
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001648")]
	[Address(RVA = "0x1DC05A0", Offset = "0x1DC06A1", VA = "0x1DC05A0")]
	public void ClearTargetNpc()
	{
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001649")]
	[Address(RVA = "0x1DC0600", Offset = "0x1DC0701", VA = "0x1DC0600")]
	public static void EventDataInitializeForNewGame()
	{
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164A")]
	[Address(RVA = "0x1DB7170", Offset = "0x1DB7271", VA = "0x1DB7170")]
	public void SetEventIdStep(int eventId, int eventStep)
	{
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164B")]
	[Address(RVA = "0x1DC0D70", Offset = "0x1DC0E71", VA = "0x1DC0D70")]
	public void StopEvent()
	{
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164C")]
	[Address(RVA = "0x1DC0DB0", Offset = "0x1DC0EB1", VA = "0x1DC0DB0")]
	public void ResetEventStep()
	{
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600164D")]
	[Address(RVA = "0x1DC0E40", Offset = "0x1DC0F41", VA = "0x1DC0E40")]
	public void ResetFesEventStep()
	{
	}

	// Token: 0x0600190C RID: 6412 RVA: 0x0000AD28 File Offset: 0x00008F28
	[Token(Token = "0x600164E")]
	[Address(RVA = "0x1DC0EC0", Offset = "0x1DC0FC1", VA = "0x1DC0EC0")]
	public bool IsEventActive()
	{
		return default(bool);
	}

	// Token: 0x0600190D RID: 6413 RVA: 0x0000AD40 File Offset: 0x00008F40
	[Token(Token = "0x600164F")]
	[Address(RVA = "0x1DC0F00", Offset = "0x1DC1001", VA = "0x1DC0F00")]
	public bool IsEventCheck(EventTriggerType eventCheckType)
	{
		return default(bool);
	}

	// Token: 0x0600190E RID: 6414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001650")]
	[Address(RVA = "0x1DC0F70", Offset = "0x1DC1071", VA = "0x1DC0F70")]
	public void AddEventCheck(int eventCheckType, int checkTriggerId, string checkScriptName, string checkEnemyName = "")
	{
	}

	// Token: 0x0600190F RID: 6415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001651")]
	[Address(RVA = "0x1DC1250", Offset = "0x1DC1351", VA = "0x1DC1250")]
	public void ReduceEventCheck(int eventCheckType, int checkTriggerId)
	{
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EE")]
	public EventScheduleData CurrentEventScheduleData
	{
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x1DC17B0", Offset = "0x1DC18B1", VA = "0x1DC17B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003EF")]
	public EventData CurrentNpcEventData
	{
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x1DB0250", Offset = "0x1DB0351", VA = "0x1DB0250")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003F0")]
	public EventData CommonNpcEventData
	{
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x1DC1860", Offset = "0x1DC1961", VA = "0x1DC1860")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06001913 RID: 6419 RVA: 0x0000AD58 File Offset: 0x00008F58
	// (set) Token: 0x06001914 RID: 6420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F1")]
	public NpcEventType NowType
	{
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x1DB6B10", Offset = "0x1DB6C11", VA = "0x1DB6B10")]
		get
		{
			return NpcEventType.None;
		}
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x1DC1990", Offset = "0x1DC1A91", VA = "0x1DC1990")]
		set
		{
		}
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x1DC19D0", Offset = "0x1DC1AD1", VA = "0x1DC19D0")]
	public void SetEnable(bool isEnable)
	{
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x1DC19E0", Offset = "0x1DC1AE1", VA = "0x1DC19E0")]
	public void WakeUpUpdate(int diffDay)
	{
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001659")]
	[Address(RVA = "0x1DBD650", Offset = "0x1DBD751", VA = "0x1DBD650")]
	public void ResetEvent(EventPointResetType resetType)
	{
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165A")]
	[Address(RVA = "0x1DC1AB0", Offset = "0x1DC1BB1", VA = "0x1DC1AB0")]
	public void SetBossBattleStart(bool val)
	{
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x1DC04F0", Offset = "0x1DC05F1", VA = "0x1DC04F0")]
	public void LoadCanvas()
	{
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165C")]
	[Address(RVA = "0x1DC1AC0", Offset = "0x1DC1BC1", VA = "0x1DC1AC0")]
	public void ResetGreeting()
	{
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x0000AD70 File Offset: 0x00008F70
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x1DC1AD0", Offset = "0x1DC1BD1", VA = "0x1DC1AD0")]
	public bool onAdvComplete(string filePath)
	{
		return default(bool);
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x1DC3290", Offset = "0x1DC3391", VA = "0x1DC3290")]
	public void ReserveUpdateSimPosOnAdvComp(int NpcId)
	{
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x1DC2D50", Offset = "0x1DC2E51", VA = "0x1DC2D50")]
	public void EventEndCameraReset(string filePath)
	{
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x1DB99E0", Offset = "0x1DB9AE1", VA = "0x1DB99E0")]
	public void InitNpcEventType()
	{
	}

	// Token: 0x0600191F RID: 6431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x1DC43E0", Offset = "0x1DC44E1", VA = "0x1DC43E0")]
	public void InitInvitedParameter()
	{
	}

	// Token: 0x06001920 RID: 6432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001662")]
	[Address(RVA = "0x1DBCF20", Offset = "0x1DBD021", VA = "0x1DBCF20")]
	public void SaveEventStartPoints(GameObject eventStartPoints)
	{
	}

	// Token: 0x06001921 RID: 6433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001663")]
	[Address(RVA = "0x1DC4610", Offset = "0x1DC4711", VA = "0x1DC4610")]
	public void DebugPrintAll(int charaId, int faceId, int positionId, string nametext, string msgtext, string[] selmenumsg)
	{
	}

	// Token: 0x06001922 RID: 6434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x1DC4790", Offset = "0x1DC4891", VA = "0x1DC4790")]
	public void SetText(string nametext, string chattext)
	{
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x1DC47F0", Offset = "0x1DC48F1", VA = "0x1DC47F0")]
	public void SetText(string nametext, string chattext, UnityAction callBackAction)
	{
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x1DC4860", Offset = "0x1DC4961", VA = "0x1DC4860")]
	public void NpcFirstTalk()
	{
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x1DB9530", Offset = "0x1DB9631", VA = "0x1DB9530")]
	private string GetBythewayMenuText(int id)
	{
		return null;
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x1DC4920", Offset = "0x1DC4A21", VA = "0x1DC4920")]
	private string GetPartnerMenuText(int id)
	{
		return null;
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x1DB9DB0", Offset = "0x1DB9EB1", VA = "0x1DB9DB0")]
	public string GetAdvChoiceNothing()
	{
		return null;
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x0000AD88 File Offset: 0x00008F88
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x1DC4BB0", Offset = "0x1DC4CB1", VA = "0x1DC4BB0")]
	public bool EventEndFinish(float wait, string filePath = "")
	{
		return default(bool);
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x0000ADA0 File Offset: 0x00008FA0
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x1DC2C60", Offset = "0x1DC2D61", VA = "0x1DC2C60")]
	public bool IsBedScriptName(string scriptName)
	{
		return default(bool);
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x1DB8A40", Offset = "0x1DB8B41", VA = "0x1DB8A40")]
	protected void EventStart(string fileName, bool research = false)
	{
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x1DC0610", Offset = "0x1DC0711", VA = "0x1DC0610")]
	public void Resize(int npcId)
	{
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x0000ADB8 File Offset: 0x00008FB8
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x1DC5A10", Offset = "0x1DC5B11", VA = "0x1DC5A10")]
	public bool NpcEventStart()
	{
		return default(bool);
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x0000ADD0 File Offset: 0x00008FD0
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x1DC5AA0", Offset = "0x1DC5BA1", VA = "0x1DC5AA0")]
	public bool NpcEventStart(int npcId)
	{
		return default(bool);
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x0000ADE8 File Offset: 0x00008FE8
	[Token(Token = "0x6001670")]
	[Address(RVA = "0x1DC5B30", Offset = "0x1DC5C31", VA = "0x1DC5B30")]
	public bool NpcEventStart(NpcController npc, string scriptName)
	{
		return default(bool);
	}

	// Token: 0x0600192F RID: 6447 RVA: 0x0000AE00 File Offset: 0x00009000
	[Token(Token = "0x6001671")]
	[Address(RVA = "0x1DB0400", Offset = "0x1DB0501", VA = "0x1DB0400")]
	public bool ForceEventStart(string scriptName)
	{
		return default(bool);
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x0000AE18 File Offset: 0x00009018
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x1DB0340", Offset = "0x1DB0441", VA = "0x1DB0340")]
	public bool ForceEventStart(string scriptName, int npcid)
	{
		return default(bool);
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x0000AE30 File Offset: 0x00009030
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x1DC5BA0", Offset = "0x1DC5CA1", VA = "0x1DC5BA0")]
	public bool ObjectEventStart(FocusObjectID interactionId)
	{
		return default(bool);
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x0000AE48 File Offset: 0x00009048
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x1DC5BE0", Offset = "0x1DC5CE1", VA = "0x1DC5BE0")]
	public bool ObjectEventStart()
	{
		return default(bool);
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x0000AE60 File Offset: 0x00009060
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x1DBB090", Offset = "0x1DBB191", VA = "0x1DBB090")]
	public bool NpcEventStart(NpcController npc)
	{
		return default(bool);
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x0000AE78 File Offset: 0x00009078
	[Token(Token = "0x6001676")]
	[Address(RVA = "0x1DB85F0", Offset = "0x1DB86F1", VA = "0x1DB85F0")]
	public bool NpcEventStart(NpcController npc, int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x0000AE90 File Offset: 0x00009090
	[Token(Token = "0x6001677")]
	[Address(RVA = "0x1DC5C20", Offset = "0x1DC5D21", VA = "0x1DC5C20")]
	public bool CanGreeting(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x0000AEA8 File Offset: 0x000090A8
	[Token(Token = "0x6001678")]
	[Address(RVA = "0x1DC5D80", Offset = "0x1DC5E81", VA = "0x1DC5D80")]
	public bool CanGreetingWeather(int npcId, Weather weather)
	{
		return default(bool);
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x0000AEC0 File Offset: 0x000090C0
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x1DC5DE0", Offset = "0x1DC5EE1", VA = "0x1DC5DE0")]
	public bool CanGreetingPregnancy(int npcId)
	{
		return default(bool);
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x0000AED8 File Offset: 0x000090D8
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x1DC5E00", Offset = "0x1DC5F01", VA = "0x1DC5E00")]
	public bool IsTraveler(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x0000AEF0 File Offset: 0x000090F0
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x1DC5E20", Offset = "0x1DC5F21", VA = "0x1DC5E20")]
	public bool IsSerious()
	{
		return default(bool);
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x0000AF08 File Offset: 0x00009108
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x1DC5CB0", Offset = "0x1DC5DB1", VA = "0x1DC5CB0")]
	public bool IsSub(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x0000AF20 File Offset: 0x00009120
	[Token(Token = "0x600167D")]
	[Address(RVA = "0x1DC5E30", Offset = "0x1DC5F31", VA = "0x1DC5E30")]
	public bool IsScenarioSupport(int npcId, bool isTalk = false)
	{
		return default(bool);
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x0000AF38 File Offset: 0x00009138
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x1DC6160", Offset = "0x1DC6261", VA = "0x1DC6160")]
	public bool IsPartyTalk()
	{
		return default(bool);
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x0000AF50 File Offset: 0x00009150
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x1DC6170", Offset = "0x1DC6271", VA = "0x1DC6170")]
	public bool IsLongTimeTalk(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x0000AF68 File Offset: 0x00009168
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x1DC6190", Offset = "0x1DC6291", VA = "0x1DC6190")]
	public bool IsParty()
	{
		return default(bool);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x0000AF80 File Offset: 0x00009180
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x1DC61A0", Offset = "0x1DC62A1", VA = "0x1DC61A0")]
	public bool IsSlipDownTalk()
	{
		return default(bool);
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x0000AF98 File Offset: 0x00009198
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x1DC61B0", Offset = "0x1DC62B1", VA = "0x1DC61B0")]
	public bool IsLethargy(int npcid = 0)
	{
		return default(bool);
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0000AFB0 File Offset: 0x000091B0
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x1DC6230", Offset = "0x1DC6331", VA = "0x1DC6230")]
	public bool IsViewByTheWay()
	{
		return default(bool);
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x0000AFC8 File Offset: 0x000091C8
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x1DC63B0", Offset = "0x1DC64B1", VA = "0x1DC63B0")]
	private NpcEventType GetFirstTalkEventType()
	{
		return NpcEventType.None;
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x1DC6630", Offset = "0x1DC6731", VA = "0x1DC6630")]
	public void SetNpcLookPlayer()
	{
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x1DC67D0", Offset = "0x1DC68D1", VA = "0x1DC67D0")]
	public void ShopEnd()
	{
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001687")]
	[Address(RVA = "0x1DC6CB0", Offset = "0x1DC6DB1", VA = "0x1DC6CB0")]
	public void ShopEnd_Furniture()
	{
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001688")]
	[Address(RVA = "0x1DC6D20", Offset = "0x1DC6E21", VA = "0x1DC6D20")]
	public void ShopEnd_Restaurent()
	{
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001689")]
	[Address(RVA = "0x1DC6F60", Offset = "0x1DC7061", VA = "0x1DC6F60")]
	private void EatPlayTimelineAfter()
	{
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168A")]
	[Address(RVA = "0x1DBC050", Offset = "0x1DBC151", VA = "0x1DBC050")]
	public void inWantedEnd()
	{
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x0000AFE0 File Offset: 0x000091E0
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x1DBC460", Offset = "0x1DBC561", VA = "0x1DBC460")]
	public bool NpcEventNext(bool research = false)
	{
		return default(bool);
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x0000AFF8 File Offset: 0x000091F8
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x1DC7630", Offset = "0x1DC7731", VA = "0x1DC7630")]
	public bool SetNpcLookPlayerEnd()
	{
		return default(bool);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x0000B010 File Offset: 0x00009210
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x1DC7690", Offset = "0x1DC7791", VA = "0x1DC7690")]
	private bool ForceScriptEventStart()
	{
		return default(bool);
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x1DC77C0", Offset = "0x1DC78C1", VA = "0x1DC77C0")]
	public void RunScript(NpcEventType NowType)
	{
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x1DD0650", Offset = "0x1DD0751", VA = "0x1DD0650")]
	public void PlayerEventProceed(int EventId, int EventStep, int NpcId)
	{
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001690")]
	[Address(RVA = "0x1DD0890", Offset = "0x1DD0991", VA = "0x1DD0890")]
	public void FestivalJoin(string join_scriptname, string join_ng_scriptname)
	{
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001691")]
	[Address(RVA = "0x1DD0A00", Offset = "0x1DD0B01", VA = "0x1DD0A00")]
	public void EventLoad(string scriptname)
	{
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001692")]
	[Address(RVA = "0x1DD0A80", Offset = "0x1DD0B81", VA = "0x1DD0A80")]
	public void SelectedQuest(int questIdx)
	{
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001693")]
	[Address(RVA = "0x1DB6EC0", Offset = "0x1DB6FC1", VA = "0x1DB6EC0")]
	public EventScheduleData GetCurrentEventScheduleData(NpcController npc)
	{
		return null;
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001694")]
	[Address(RVA = "0x1DD0B00", Offset = "0x1DD0C01", VA = "0x1DD0B00")]
	public EventScheduleData GetCurrentEventScheduleData()
	{
		return null;
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x1DD0C50", Offset = "0x1DD0D51", VA = "0x1DD0C50")]
	public void SetEventFlagPoint(int[] FlagIndexs, bool FlagValue)
	{
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x1DD0CD0", Offset = "0x1DD0DD1", VA = "0x1DD0CD0")]
	public void CheckEventFlagPoint(int[] FlagIndexs, bool FlagValue, int thenStep, int elseStep)
	{
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001697")]
	[Address(RVA = "0x1DD0E00", Offset = "0x1DD0F01", VA = "0x1DD0E00")]
	public void NpcEventTalkReserve(int EventId, int EventStep, int[] npcIds)
	{
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x1DD0FE0", Offset = "0x1DD10E1", VA = "0x1DD0FE0")]
	public void NpcEventTalkRelease(int[] npcIds)
	{
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x1DD11C0", Offset = "0x1DD12C1", VA = "0x1DD11C0")]
	public void ContitionalJudgment(stCommand_t cmd)
	{
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x1DD51C0", Offset = "0x1DD52C1", VA = "0x1DD51C0")]
	public void CompareParam(int comparisonOperator, long value1, long value2, int thenStep, int elseStep)
	{
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169B")]
	[Address(RVA = "0x1DD52D0", Offset = "0x1DD53D1", VA = "0x1DD52D0")]
	public void AddPoint(int NpcId, int value1, string value2)
	{
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169C")]
	[Address(RVA = "0x1DD54A0", Offset = "0x1DD55A1", VA = "0x1DD54A0")]
	public void SetBossKillFlag(string bossName)
	{
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169D")]
	[Address(RVA = "0x1DD55E0", Offset = "0x1DD56E1", VA = "0x1DD55E0")]
	public void EventTriggerCheck(EventTriggerType eventTriggerType, string enemyName = "")
	{
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169E")]
	[Address(RVA = "0x1DBF7B0", Offset = "0x1DBF8B1", VA = "0x1DBF7B0")]
	private void DoEventTrigger()
	{
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600169F")]
	[Address(RVA = "0x1DD58C0", Offset = "0x1DD59C1", VA = "0x1DD58C0")]
	public void SetActiveEvent_DEBUG(int eventtype, int eventid, int eventstep, int npcid, int npcstep)
	{
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A0")]
	[Address(RVA = "0x1DBFE10", Offset = "0x1DBFF11", VA = "0x1DBFE10")]
	private void EventStartCheck()
	{
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x1DB6D90", Offset = "0x1DB6E91", VA = "0x1DB6D90")]
	public void EventScheduleProceed()
	{
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x1DBF6F0", Offset = "0x1DBF7F1", VA = "0x1DBF6F0")]
	public void EventProceed()
	{
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0000B028 File Offset: 0x00009228
	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x1DD5900", Offset = "0x1DD5A01", VA = "0x1DD5900")]
	public bool ProceedWithOrder(OrderType orderType)
	{
		return default(bool);
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x0000B040 File Offset: 0x00009240
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x1DD5A00", Offset = "0x1DD5B01", VA = "0x1DD5A00")]
	public bool ProceedWithOrder(OrderType orderType, GameObject gameObject)
	{
		return default(bool);
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x0000B058 File Offset: 0x00009258
	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x1DD5A80", Offset = "0x1DD5B81", VA = "0x1DD5A80")]
	public bool ProceedWithOrder(OrderType orderType, ItemData item)
	{
		return default(bool);
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x0000B070 File Offset: 0x00009270
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x1DD5B00", Offset = "0x1DD5C01", VA = "0x1DD5B00")]
	public bool ProceedWithOrder(OrderType orderType, int targetId)
	{
		return default(bool);
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0000B088 File Offset: 0x00009288
	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x1DD5C10", Offset = "0x1DD5D11", VA = "0x1DD5C10")]
	public bool ProceedWithOrder(OrderType orderType, int targetId, int type)
	{
		return default(bool);
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x0000B0A0 File Offset: 0x000092A0
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x1DD5970", Offset = "0x1DD5A71", VA = "0x1DD5970")]
	public bool ProceedWithOrder(OrderType orderType, int npcId, GameObject gameObject, ItemData item)
	{
		return default(bool);
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x0000B0B8 File Offset: 0x000092B8
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x1DD5B80", Offset = "0x1DD5C81", VA = "0x1DD5B80")]
	public bool ProceedWithOrder(OrderType orderType, int npcId, int targetId, GameObject gameObject, ItemData item)
	{
		return default(bool);
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x1DC5950", Offset = "0x1DC5A51", VA = "0x1DC5950")]
	public void OffChatWindow()
	{
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x1DD5C90", Offset = "0x1DD5D91", VA = "0x1DD5C90")]
	private void ChoiceListAdd(int nextStep, int answerId)
	{
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x1DD5D10", Offset = "0x1DD5E11", VA = "0x1DD5D10")]
	private void ChoiceListClear()
	{
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x1DB9B70", Offset = "0x1DB9C71", VA = "0x1DB9B70")]
	public void AppearSelectMenu(string charaName, int groupId, int answerId, string message, int nextStep, bool useCancelButton = false)
	{
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x1DD5FC0", Offset = "0x1DD60C1", VA = "0x1DD5FC0")]
	public void AppearSelectMenuWithHintMsg(string charaName, int groupId, int answerId, string message, string hintMsg, string hintName, int nextStep, bool useCancelButton = false)
	{
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x1DD5D80", Offset = "0x1DD5E81", VA = "0x1DD5D80")]
	private string SettingAppearSelectMenuMessage(int groupId, int answerId, string message)
	{
		return null;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x1DC70A0", Offset = "0x1DC71A1", VA = "0x1DC70A0")]
	public void SetCurrentNpcEventStep(int npcId, int currentStep)
	{
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x1DD6220", Offset = "0x1DD6321", VA = "0x1DD6220")]
	public void SetCurrentNpcEventStep(int currentStep)
	{
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x1DB29C0", Offset = "0x1DB2AC1", VA = "0x1DB29C0")]
	public void SetNextNpcEventStep(int npcId, int nextStep)
	{
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x1DD62A0", Offset = "0x1DD63A1", VA = "0x1DD62A0")]
	public void SetNextNpcEventStep(int nextStep)
	{
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x0000B0D0 File Offset: 0x000092D0
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x1DCF6A0", Offset = "0x1DCF7A1", VA = "0x1DCF6A0")]
	public int EventStepProceedReserve(int orderId)
	{
		return 0;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x1DD6320", Offset = "0x1DD6421", VA = "0x1DD6320")]
	public void EventStepProceed()
	{
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06001974 RID: 6516 RVA: 0x0000B0E8 File Offset: 0x000092E8
	// (set) Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003F2")]
	public int LastSelect
	{
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x1DD6370", Offset = "0x1DD6471", VA = "0x1DD6370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D8A0", Offset = "0x19D9A1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x1DD6380", Offset = "0x1DD6481", VA = "0x1DD6380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D8B0", Offset = "0x19D9B1")]
		private set
		{
		}
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x1DD6390", Offset = "0x1DD6491", VA = "0x1DD6390")]
	public void SelectedMenu(int nextStep)
	{
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x1DD7EC0", Offset = "0x1DD7FC1", VA = "0x1DD7EC0")]
	public void SelectedGender()
	{
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x1DD7F60", Offset = "0x1DD8061", VA = "0x1DD7F60")]
	public void EndNext()
	{
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x1DD7DC0", Offset = "0x1DD7EC1", VA = "0x1DD7DC0")]
	private void SelectedMenuEnd()
	{
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x1DD6950", Offset = "0x1DD6A51", VA = "0x1DD6950")]
	private void SelectedMenuGroup(int nextStep)
	{
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x1DC71F0", Offset = "0x1DC72F1", VA = "0x1DC71F0")]
	public void onEventStart()
	{
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x1DD8010", Offset = "0x1DD8111", VA = "0x1DD8010")]
	private void ResetChara(Character chara)
	{
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x1DB0240", Offset = "0x1DB0341", VA = "0x1DB0240")]
	public void onTalkEnd()
	{
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x1DC5610", Offset = "0x1DC5711", VA = "0x1DC5610")]
	public void onEventFinished(string filePath = "")
	{
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x1DD81D0", Offset = "0x1DD82D1", VA = "0x1DD81D0")]
	public void SetCameraResetFlag(EventCameraResetType value)
	{
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x1DC3330", Offset = "0x1DC3431", VA = "0x1DC3330")]
	public void CameraReset(NpcEventType eventType, NpcData npcData)
	{
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x1DD82B0", Offset = "0x1DD83B1", VA = "0x1DD82B0")]
	public void ChangePlayerCamera()
	{
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x1DD81E0", Offset = "0x1DD82E1", VA = "0x1DD81E0")]
	public void ChangePlayerCamera(bool cameraReset)
	{
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x1DAFAD0", Offset = "0x1DAFBD1", VA = "0x1DAFAD0")]
	private NpcData GetNpcData(int npcId)
	{
		return null;
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x1DD82C0", Offset = "0x1DD83C1", VA = "0x1DD82C0")]
	public void SetTargetNpc(int npcId)
	{
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x1DAFE80", Offset = "0x1DAFF81", VA = "0x1DAFE80")]
	public void SetByTheWayActive(bool value, [Optional] NpcData data)
	{
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x1DD0590", Offset = "0x1DD0691", VA = "0x1DD0590")]
	public void AdvStartByCmd(stCommand_t[] cmdList, int npcId = -1, bool resetStep = true)
	{
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0000B100 File Offset: 0x00009300
	[Token(Token = "0x60016C9")]
	[Address(RVA = "0x1DD83D0", Offset = "0x1DD84D1", VA = "0x1DD83D0")]
	public stCommand_t MakeCmd(int CmdId, int[] Arg, string[] ArgText)
	{
		return default(stCommand_t);
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0000B118 File Offset: 0x00009318
	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x1DD8440", Offset = "0x1DD8541", VA = "0x1DD8440")]
	public stCommand_t MakeCmd_Message(string charaName, int charaNameId, int faceNameId, int positionNameId, string message, string voiceName)
	{
		return default(stCommand_t);
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x0000B130 File Offset: 0x00009330
	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x1DD8820", Offset = "0x1DD8921", VA = "0x1DD8820")]
	public stCommand_t MakeCmd_SelectMessage(string charaName, int npcId, int groupId, int answerId, string message, int nextStep)
	{
		return default(stCommand_t);
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x0000B148 File Offset: 0x00009348
	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x1DD8AC0", Offset = "0x1DD8BC1", VA = "0x1DD8AC0")]
	public stCommand_t MakeCmd_GoToStepNext(int step = 1)
	{
		return default(stCommand_t);
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x0000B160 File Offset: 0x00009360
	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x1DD04C0", Offset = "0x1DD05C1", VA = "0x1DD04C0")]
	public stCommand_t MakeCmd_End(int wait = -1)
	{
		return default(stCommand_t);
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x1DD8B90", Offset = "0x1DD8C91", VA = "0x1DD8B90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D8C0", Offset = "0x19D9C1")]
	public IEnumerator LifeCycleEventEndFinish(float wait)
	{
		return null;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x0000B178 File Offset: 0x00009378
	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x1DC3450", Offset = "0x1DC3551", VA = "0x1DC3450")]
	public NpcEventType GetNpcEventTypeFromPath(string Path, bool setEventId = true)
	{
		return NpcEventType.None;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x0000B190 File Offset: 0x00009390
	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x1DB0DF0", Offset = "0x1DB0EF1", VA = "0x1DB0DF0")]
	public bool CheckQueueSameScriptType(string scriptName)
	{
		return default(bool);
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x0000B1A8 File Offset: 0x000093A8
	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x1DB6C20", Offset = "0x1DB6D21", VA = "0x1DB6C20")]
	public bool IsHintTalkNPC(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x0000B1C0 File Offset: 0x000093C0
	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x1DB66B0", Offset = "0x1DB67B1", VA = "0x1DB66B0")]
	public int GetBaybBirthTalk()
	{
		return 0;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0000B1D8 File Offset: 0x000093D8
	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x1DD8BF0", Offset = "0x1DD8CF1", VA = "0x1DD8BF0")]
	public SoundID GetCharaCalling(int npcid)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x1DD8DB0", Offset = "0x1DD8EB1", VA = "0x1DD8DB0")]
	public void DEBUG_EventFlagCancel()
	{
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x1DD8EA0", Offset = "0x1DD8FA1", VA = "0x1DD8EA0")]
	public void DEBUG_SubEventCheck(int id)
	{
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x1DD8EB0", Offset = "0x1DD8FB1", VA = "0x1DD8EB0")]
	public void DEBUG_EventPicDisplay(int value, bool onoff)
	{
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x1DD8F20", Offset = "0x1DD9021", VA = "0x1DD8F20")]
	public void DisableTextWindow()
	{
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x1DD8FC0", Offset = "0x1DD90C1", VA = "0x1DD8FC0")]
	public void SetAnimationUpdateMode(AnimatorUpdateMode mode)
	{
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x1DD8FD0", Offset = "0x1DD90D1", VA = "0x1DD8FD0")]
	public void SetAnimationUpdateMode(Character character, AnimatorUpdateMode mode)
	{
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x1DC5480", Offset = "0x1DC5581", VA = "0x1DC5480")]
	public PartyBase GetPartyBase(int npcId)
	{
		return null;
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x1DD90C0", Offset = "0x1DD91C1", VA = "0x1DD90C0")]
	public void DEBUG_SetLoveStoryProgress(int idx, int state)
	{
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x1DCF900", Offset = "0x1DCFA01", VA = "0x1DCF900")]
	public void CollectFestivalNPC()
	{
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x1DD9160", Offset = "0x1DD9261", VA = "0x1DD9160")]
	public void CallFestivalResult()
	{
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x1DD92D0", Offset = "0x1DD93D1", VA = "0x1DD92D0")]
	public void FlagPointUpdateData(bool value, GameFlagData flag)
	{
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x1DD9660", Offset = "0x1DD9761", VA = "0x1DD9660")]
	public void FlagPointUpdateVisible(bool value, GameFlagData flag)
	{
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x1DD9A60", Offset = "0x1DD9B61", VA = "0x1DD9A60")]
	public void SelectChild2Personality(bool isMan)
	{
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x1DBD190", Offset = "0x1DBD291", VA = "0x1DBD190")]
	public void AfterLoadFlagUpdateData()
	{
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x1DDA1A0", Offset = "0x1DDA2A1", VA = "0x1DDA1A0")]
	public void TimeSkipResetFlag()
	{
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x1DDA210", Offset = "0x1DDA311", VA = "0x1DDA210")]
	public EventControllerBase()
	{
	}

	// Token: 0x04005C5A RID: 23642
	[Token(Token = "0x40058B4")]
	private const int D_SKILL_TALK_LV1 = 10;

	// Token: 0x04005C5B RID: 23643
	[Token(Token = "0x40058B5")]
	private const int D_SKILL_TALK_LV2 = 35;

	// Token: 0x04005C5C RID: 23644
	[Token(Token = "0x40058B6")]
	private const int D_SKILL_TALK_LV3 = 50;

	// Token: 0x04005C5D RID: 23645
	[Token(Token = "0x40058B7")]
	private const int D_SKILL_TALK_LV4 = 99;

	// Token: 0x04005C5E RID: 23646
	[Token(Token = "0x40058B8")]
	private const int DATE_LATENESSTIME = 2;

	// Token: 0x04005C5F RID: 23647
	[Token(Token = "0x40058B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly GameFlagData[] KokuhakuCancelFlags;

	// Token: 0x04005C60 RID: 23648
	[Token(Token = "0x40058BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<int> PtnPresentNpcIds;

	// Token: 0x04005C61 RID: 23649
	[Token(Token = "0x40058BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ItemID PtnPresentItemId;

	// Token: 0x04005C62 RID: 23650
	[Token(Token = "0x40058BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int TemporaryID01;

	// Token: 0x04005C63 RID: 23651
	[Token(Token = "0x40058BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int ExclamationID;

	// Token: 0x04005C64 RID: 23652
	[Token(Token = "0x40058BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int ExclamationSkillIDA;

	// Token: 0x04005C65 RID: 23653
	[Token(Token = "0x40058BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int ExclamationSkillIDB;

	// Token: 0x04005C66 RID: 23654
	[Token(Token = "0x40058C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ItemData PrevPresentItemData;

	// Token: 0x04005C67 RID: 23655
	[Token(Token = "0x40058C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool IsPrevOriginalPresent;

	// Token: 0x04005C68 RID: 23656
	[Token(Token = "0x40058C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool IsBythewayFesDateOn;

	// Token: 0x04005C69 RID: 23657
	[Token(Token = "0x40058C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool OnTouch;

	// Token: 0x04005C6A RID: 23658
	[Token(Token = "0x40058C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public EventFlagManager _FlagManager;

	// Token: 0x04005C6B RID: 23659
	[Token(Token = "0x40058C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool FirstFadeCheck;

	// Token: 0x04005C6C RID: 23660
	[Token(Token = "0x40058C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<EventStartData> EventStartDataQueue;

	// Token: 0x04005C6D RID: 23661
	[Token(Token = "0x40058C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<EventStartData> TutorialStartDataQueue;

	// Token: 0x04005C6E RID: 23662
	[Token(Token = "0x40058C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<string> EventFlagCheckList;

	// Token: 0x04005C6F RID: 23663
	[Token(Token = "0x40058C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> talkedNpcIdList;

	// Token: 0x04005C70 RID: 23664
	[Token(Token = "0x40058CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> callLookatEndNpcIdList;

	// Token: 0x04005C71 RID: 23665
	[Token(Token = "0x40058CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public EventFestivalManager FestivalManager;

	// Token: 0x04005C72 RID: 23666
	[Token(Token = "0x40058CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool IsCallCallFestivalResult;

	// Token: 0x04005C73 RID: 23667
	[Token(Token = "0x40058CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool IsSelectShopDefalutTalk;

	// Token: 0x04005C74 RID: 23668
	[Token(Token = "0x40058CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	private bool doGreeting;

	// Token: 0x04005C75 RID: 23669
	[Token(Token = "0x40058CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	private bool doLongTimeTalk;

	// Token: 0x04005C76 RID: 23670
	[Token(Token = "0x40058D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162910", Offset = "0x162A11")]
	private bool <IsEventStarted>k__BackingField;

	// Token: 0x04005C77 RID: 23671
	[Token(Token = "0x40058D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162920", Offset = "0x162A21")]
	private bool <IsEventFinished>k__BackingField;

	// Token: 0x04005C78 RID: 23672
	[Token(Token = "0x40058D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool IsStartVegetableContestResult;

	// Token: 0x04005C79 RID: 23673
	[Token(Token = "0x40058D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x97")]
	public bool IsStartHalloweenContestResult;

	// Token: 0x04005C7A RID: 23674
	[Token(Token = "0x40058D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string CallScriptName;

	// Token: 0x04005C7B RID: 23675
	[Token(Token = "0x40058D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162930", Offset = "0x162A31")]
	private FocusObjectID <ObjectInteractionId>k__BackingField;

	// Token: 0x04005C7C RID: 23676
	[Token(Token = "0x40058D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private TimeManager timeManager;

	// Token: 0x04005C7D RID: 23677
	[Token(Token = "0x40058D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool IsCollectFestivalNPC;

	// Token: 0x04005C7E RID: 23678
	[Token(Token = "0x40058D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AdvMain _advMain;

	// Token: 0x04005C7F RID: 23679
	[Token(Token = "0x40058D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ShortplayAdvController _ShortplayAdvController;

	// Token: 0x04005C80 RID: 23680
	[Token(Token = "0x40058DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<int> listNpcId_UpdateSimPosOnAdvComp;

	// Token: 0x04005C81 RID: 23681
	[Token(Token = "0x40058DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public bool EventDebugLogOn;

	// Token: 0x04005C82 RID: 23682
	[Token(Token = "0x40058DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public NpcEventType Debug_ActiveNpcEventType;

	// Token: 0x04005C83 RID: 23683
	[Token(Token = "0x40058DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public int DEBUG_ActiveEventId;

	// Token: 0x04005C84 RID: 23684
	[Token(Token = "0x40058DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public int DEBUG_ActiveEventStep;

	// Token: 0x04005C85 RID: 23685
	[Token(Token = "0x40058DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public int DEBUG_ActiveNpcId;

	// Token: 0x04005C86 RID: 23686
	[Token(Token = "0x40058E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[SerializeField]
	public int DEBUG_ActiveNpcStep;

	// Token: 0x04005C87 RID: 23687
	[Token(Token = "0x40058E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public EventCameraResetType CameraResetFlag;

	// Token: 0x04005C88 RID: 23688
	[Token(Token = "0x40058E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int DEBUG_EventLimit;

	// Token: 0x04005C89 RID: 23689
	[Token(Token = "0x40058E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool IsBossBattleStart;

	// Token: 0x04005C8A RID: 23690
	[Token(Token = "0x40058E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Character _owner;

	// Token: 0x04005C8B RID: 23691
	[Token(Token = "0x40058E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public NpcController TargetNpc;

	// Token: 0x04005C8C RID: 23692
	[Token(Token = "0x40058E6")]
	private const int PartnerEventDailyTalkStep = 99;

	// Token: 0x04005C8D RID: 23693
	[Token(Token = "0x40058E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public PartnerAdvChoice partnerAdvSelect;

	// Token: 0x04005C8E RID: 23694
	[Token(Token = "0x40058E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Attribute(Name = "HideInInspector", RVA = "0x1629A0", Offset = "0x162AA1")]
	public SubEventManager subEventManager;

	// Token: 0x04005C8F RID: 23695
	[Token(Token = "0x40058E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private GameObject fieldEventCanvas;

	// Token: 0x04005C90 RID: 23696
	[Token(Token = "0x40058EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public bool _IsReadable;

	// Token: 0x04005C91 RID: 23697
	[Token(Token = "0x40058EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	public bool IsAssetReadable;

	// Token: 0x04005C92 RID: 23698
	[Token(Token = "0x40058EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject cameraFade;

	// Token: 0x04005C93 RID: 23699
	[Token(Token = "0x40058ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public ShopBuyState ShopOpenStep;

	// Token: 0x04005C94 RID: 23700
	[Token(Token = "0x40058EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private int ShopStep;

	// Token: 0x04005C95 RID: 23701
	[Token(Token = "0x40058EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool IsGenderSelect;

	// Token: 0x04005C96 RID: 23702
	[Token(Token = "0x40058F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	public bool FirstStepTalked;

	// Token: 0x04005C97 RID: 23703
	[Token(Token = "0x40058F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
	private bool IsEventTriggerCheck;

	// Token: 0x04005C98 RID: 23704
	[Token(Token = "0x40058F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ScenarioTalk ScenarioTalkDatas;

	// Token: 0x04005C99 RID: 23705
	[Token(Token = "0x40058F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int ScenarioSupportFlagId;

	// Token: 0x04005C9A RID: 23706
	[Token(Token = "0x40058F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private bool IsEventMultiBoys;

	// Token: 0x04005C9B RID: 23707
	[Token(Token = "0x40058F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public List<string> debugPrintStrs;

	// Token: 0x04005C9C RID: 23708
	[Token(Token = "0x40058F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int debugPrintIndex;

	// Token: 0x04005C9D RID: 23709
	[Token(Token = "0x40058F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject NavMeshObstacle;

	// Token: 0x04005C9E RID: 23710
	[Token(Token = "0x40058F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public bool IsRunScript;

	// Token: 0x04005C9F RID: 23711
	[Token(Token = "0x40058F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private BirthTalk BirthTalkDatas;

	// Token: 0x04005CA0 RID: 23712
	[Token(Token = "0x40058FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private CharacterCalling CharacterCallingDatas;

	// Token: 0x04005CA1 RID: 23713
	[Token(Token = "0x40058FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public int[] IKOffAnimState;

	// Token: 0x04005CA2 RID: 23714
	[Token(Token = "0x40058FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, GameFlagData> BossKillFlagDict;

	// Token: 0x04005CA3 RID: 23715
	[Token(Token = "0x40058FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<EventPointID, EventControllerBase.FirstMatchInfo> FirstEventPointDict;

	// Token: 0x04005CA4 RID: 23716
	[Token(Token = "0x40058FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly EventPointID[] FirstRematchOnlyEventStartPoints;

	// Token: 0x04005CA5 RID: 23717
	[Token(Token = "0x40058FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private LoveEventTextConvertData _LoveEventTextConvertData;

	// Token: 0x04005CA6 RID: 23718
	[Token(Token = "0x4005900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1629B0", Offset = "0x162AB1")]
	private bool <IsInit>k__BackingField;

	// Token: 0x04005CA7 RID: 23719
	[Token(Token = "0x4005901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private List<int> ChoiceNextStepList;

	// Token: 0x04005CA8 RID: 23720
	[Token(Token = "0x4005902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private List<int> ChoiceAnswerIdList;

	// Token: 0x04005CA9 RID: 23721
	[Token(Token = "0x4005903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1629C0", Offset = "0x162AC1")]
	private int <LastSelect>k__BackingField;

	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x2001076")]
	private class FirstMatchInfo
	{
		// Token: 0x060019A3 RID: 6563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA9")]
		[Address(RVA = "0x21E8B40", Offset = "0x21E8C41", VA = "0x21E8B40")]
		public FirstMatchInfo(EventPointID pointID, int triggerID)
		{
		}

		// Token: 0x04005CAA RID: 23722
		[Token(Token = "0x4019019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventPointID eventPointID;

		// Token: 0x04005CAB RID: 23723
		[Token(Token = "0x401901A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int eventTriggerID;
	}

	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x2001077")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157660", Offset = "0x157761")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAA")]
		[Address(RVA = "0x21E8720", Offset = "0x21E8821", VA = "0x21E8720")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAB")]
		[Address(RVA = "0x21E8730", Offset = "0x21E8831", VA = "0x21E8730")]
		internal void <DateEnd>b__0()
		{
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0x21E8760", Offset = "0x21E8861", VA = "0x21E8760")]
		internal void <DateEnd>b__1()
		{
		}

		// Token: 0x04005CAC RID: 23724
		[Token(Token = "0x401901B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NpcData npcData;
	}

	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x2001078")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157670", Offset = "0x157771")]
	private sealed class <ReturnPresentCoroutine>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0x21E8920", Offset = "0x21E8A21", VA = "0x21E8920")]
		[DebuggerHidden]
		public <ReturnPresentCoroutine>d__78(int <>1__state)
		{
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAE")]
		[Address(RVA = "0x21E8950", Offset = "0x21E8A51", VA = "0x21E8950", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6006DAF")]
		[Address(RVA = "0x21E8960", Offset = "0x21E8A61", VA = "0x21E8960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C29")]
		private object Current
		{
			[Token(Token = "0x6006DB0")]
			[Address(RVA = "0x21E8AC0", Offset = "0x21E8BC1", VA = "0x21E8AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0x21E8AD0", Offset = "0x21E8BD1", VA = "0x21E8AD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2A")]
		private object Current
		{
			[Token(Token = "0x6006DB2")]
			[Address(RVA = "0x21E8B30", Offset = "0x21E8C31", VA = "0x21E8B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04005CAD RID: 23725
		[Token(Token = "0x401901C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04005CAE RID: 23726
		[Token(Token = "0x401901D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04005CAF RID: 23727
		[Token(Token = "0x401901E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventControllerBase <>4__this;

		// Token: 0x04005CB0 RID: 23728
		[Token(Token = "0x401901F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		// Token: 0x04005CB1 RID: 23729
		[Token(Token = "0x4019020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int npcId;
	}

	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x2001079")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157680", Offset = "0x157781")]
	private sealed class <>c__DisplayClass297_0
	{
		// Token: 0x060019AD RID: 6573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0x21E8790", Offset = "0x21E8891", VA = "0x21E8790")]
		public <>c__DisplayClass297_0()
		{
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0x21E87A0", Offset = "0x21E88A1", VA = "0x21E87A0")]
		internal bool <ResetEvent>b__0(EventCheckId check)
		{
			return default(bool);
		}

		// Token: 0x04005CB2 RID: 23730
		[Token(Token = "0x4019021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventControllerBase.FirstMatchInfo firstMatchInfo;
	}

	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200107A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157690", Offset = "0x157791")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060019B0 RID: 6576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0x21E82C0", Offset = "0x21E83C1", VA = "0x21E82C0")]
		public <>c()
		{
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0x21E82D0", Offset = "0x21E83D1", VA = "0x21E82D0")]
		internal void <onAdvComplete>b__301_0(bool _select)
		{
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0x21E8340", Offset = "0x21E8441", VA = "0x21E8340")]
		internal bool <ContitionalJudgment>b__361_0(PartyBase p)
		{
			return default(bool);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0x21E8380", Offset = "0x21E8481", VA = "0x21E8380")]
		internal void <FlagPointUpdateVisible>b__435_0(string name)
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0x21E84C0", Offset = "0x21E85C1", VA = "0x21E84C0")]
		internal void <FlagPointUpdateVisible>b__435_2(int date, int season)
		{
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0x21E8550", Offset = "0x21E8651", VA = "0x21E8550")]
		internal void <FlagPointUpdateVisible>b__435_1(string name)
		{
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBC")]
		[Address(RVA = "0x21E8690", Offset = "0x21E8791", VA = "0x21E8690")]
		internal void <FlagPointUpdateVisible>b__435_3(int date, int season)
		{
		}

		// Token: 0x04005CB3 RID: 23731
		[Token(Token = "0x4019022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly EventControllerBase.<>c <>9;

		// Token: 0x04005CB4 RID: 23732
		[Token(Token = "0x4019023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static UnityAction<bool> <>9__301_0;

		// Token: 0x04005CB5 RID: 23733
		[Token(Token = "0x4019024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PartyBase, bool> <>9__361_0;

		// Token: 0x04005CB6 RID: 23734
		[Token(Token = "0x4019025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static UnityAction<int, int> <>9__435_2;

		// Token: 0x04005CB7 RID: 23735
		[Token(Token = "0x4019026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static UnityAction<string> <>9__435_0;

		// Token: 0x04005CB8 RID: 23736
		[Token(Token = "0x4019027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static UnityAction<int, int> <>9__435_3;

		// Token: 0x04005CB9 RID: 23737
		[Token(Token = "0x4019028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static UnityAction<string> <>9__435_1;
	}

	// Token: 0x02000420 RID: 1056
	[Token(Token = "0x200107B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576A0", Offset = "0x1577A1")]
	private sealed class <>c__DisplayClass350_0
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBD")]
		[Address(RVA = "0x21E87D0", Offset = "0x21E88D1", VA = "0x21E87D0")]
		public <>c__DisplayClass350_0()
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBE")]
		[Address(RVA = "0x21E87E0", Offset = "0x21E88E1", VA = "0x21E87E0")]
		internal void <RunScript>b__0()
		{
		}

		// Token: 0x04005CBA RID: 23738
		[Token(Token = "0x4019029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NpcData npcData;
	}

	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x200107C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1576B0", Offset = "0x1577B1")]
	private sealed class <LifeCycleEventEndFinish>d__418 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DBF")]
		[Address(RVA = "0x21E8800", Offset = "0x21E8901", VA = "0x21E8800")]
		[DebuggerHidden]
		public <LifeCycleEventEndFinish>d__418(int <>1__state)
		{
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC0")]
		[Address(RVA = "0x21E8830", Offset = "0x21E8931", VA = "0x21E8830", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x6006DC1")]
		[Address(RVA = "0x21E8840", Offset = "0x21E8941", VA = "0x21E8840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2B")]
		private object Current
		{
			[Token(Token = "0x6006DC2")]
			[Address(RVA = "0x21E88A0", Offset = "0x21E89A1", VA = "0x21E88A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DC3")]
		[Address(RVA = "0x21E88B0", Offset = "0x21E89B1", VA = "0x21E88B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2C")]
		private object Current
		{
			[Token(Token = "0x6006DC4")]
			[Address(RVA = "0x21E8910", Offset = "0x21E8A11", VA = "0x21E8910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04005CBB RID: 23739
		[Token(Token = "0x401902A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04005CBC RID: 23740
		[Token(Token = "0x401902B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
