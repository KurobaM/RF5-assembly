using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Field;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020009C4 RID: 2500
[Token(Token = "0x200068E")]
public class MapControl : MonoBehaviour
{
	// Token: 0x1700090C RID: 2316
	// (get) Token: 0x06004139 RID: 16697 RVA: 0x00015F90 File Offset: 0x00014190
	// (set) Token: 0x0600413A RID: 16698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700073E")]
	public bool IsActiveInput
	{
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x1F18630", Offset = "0x1F18731", VA = "0x1F18630")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A73E0", Offset = "0x1A74E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x1F18640", Offset = "0x1F18741", VA = "0x1F18640")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A73F0", Offset = "0x1A74F1")]
		set
		{
		}
	}

	// Token: 0x1700090D RID: 2317
	// (get) Token: 0x0600413B RID: 16699 RVA: 0x00015FA8 File Offset: 0x000141A8
	// (set) Token: 0x0600413C RID: 16700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700073F")]
	public bool IsEndFirstInput
	{
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x1F18650", Offset = "0x1F18751", VA = "0x1F18650")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7400", Offset = "0x1A7501")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x1F18660", Offset = "0x1F18761", VA = "0x1F18660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7410", Offset = "0x1A7511")]
		set
		{
		}
	}

	// Token: 0x1700090E RID: 2318
	// (get) Token: 0x0600413D RID: 16701 RVA: 0x00015FC0 File Offset: 0x000141C0
	// (set) Token: 0x0600413E RID: 16702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000740")]
	public bool IsWarpHold
	{
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x1F18670", Offset = "0x1F18771", VA = "0x1F18670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7420", Offset = "0x1A7521")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x1F18680", Offset = "0x1F18781", VA = "0x1F18680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7430", Offset = "0x1A7531")]
		set
		{
		}
	}

	// Token: 0x1700090F RID: 2319
	// (get) Token: 0x0600413F RID: 16703 RVA: 0x00015FD8 File Offset: 0x000141D8
	// (set) Token: 0x06004140 RID: 16704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000741")]
	public static int MapGuideID
	{
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x1F18690", Offset = "0x1F18791", VA = "0x1F18690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7440", Offset = "0x1A7541")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x1F18700", Offset = "0x1F18801", VA = "0x1F18700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7450", Offset = "0x1A7551")]
		set
		{
		}
	}

	// Token: 0x17000910 RID: 2320
	// (get) Token: 0x06004141 RID: 16705 RVA: 0x00015FF0 File Offset: 0x000141F0
	// (set) Token: 0x06004142 RID: 16706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000742")]
	private int MapInfoID
	{
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x1F18770", Offset = "0x1F18871", VA = "0x1F18770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7460", Offset = "0x1A7561")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x1F18780", Offset = "0x1F18881", VA = "0x1F18780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7470", Offset = "0x1A7571")]
		set
		{
		}
	}

	// Token: 0x06004143 RID: 16707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003676")]
	[Address(RVA = "0x1F18790", Offset = "0x1F18891", VA = "0x1F18790")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7480", Offset = "0x1A7581")]
	private IEnumerator createMap(int id)
	{
		return null;
	}

	// Token: 0x06004144 RID: 16708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003677")]
	[Address(RVA = "0x1F18850", Offset = "0x1F18951", VA = "0x1F18850")]
	private void LoadMap(FieldSceneId fieldId)
	{
	}

	// Token: 0x06004145 RID: 16709 RVA: 0x00016008 File Offset: 0x00014208
	[Token(Token = "0x6003678")]
	[Address(RVA = "0x1F19720", Offset = "0x1F19821", VA = "0x1F19720")]
	private int getMonsterHutDataID(FieldSceneId fieldId)
	{
		return 0;
	}

	// Token: 0x06004146 RID: 16710 RVA: 0x00016020 File Offset: 0x00014220
	[Token(Token = "0x6003679")]
	[Address(RVA = "0x1F195E0", Offset = "0x1F196E1", VA = "0x1F195E0")]
	private int getFieldMapId()
	{
		return 0;
	}

	// Token: 0x06004147 RID: 16711 RVA: 0x00016038 File Offset: 0x00014238
	[Token(Token = "0x600367A")]
	[Address(RVA = "0x1F19BC0", Offset = "0x1F19CC1", VA = "0x1F19BC0")]
	private Vector3 getPlayerMapPos(FieldSceneId fieldId)
	{
		return default(Vector3);
	}

	// Token: 0x06004148 RID: 16712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600367B")]
	[Address(RVA = "0x1F1A150", Offset = "0x1F1A251", VA = "0x1F1A150")]
	private void Start()
	{
	}

	// Token: 0x06004149 RID: 16713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600367C")]
	[Address(RVA = "0x1F1AF00", Offset = "0x1F1B001", VA = "0x1F1AF00")]
	private void Update()
	{
	}

	// Token: 0x0600414A RID: 16714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600367D")]
	[Address(RVA = "0x1F1E5A0", Offset = "0x1F1E6A1", VA = "0x1F1E5A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600414B RID: 16715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600367E")]
	[Address(RVA = "0x1F1CB10", Offset = "0x1F1CC11", VA = "0x1F1CB10")]
	private void NpcSet()
	{
	}

	// Token: 0x0600414C RID: 16716 RVA: 0x00016050 File Offset: 0x00014250
	[Token(Token = "0x600367F")]
	[Address(RVA = "0x1F1F0D0", Offset = "0x1F1F1D1", VA = "0x1F1F0D0")]
	private bool IsNPCIcon(int type, NpcData npcdata)
	{
		return default(bool);
	}

	// Token: 0x0600414D RID: 16717 RVA: 0x00016068 File Offset: 0x00014268
	[Token(Token = "0x6003680")]
	[Address(RVA = "0x1F1EE70", Offset = "0x1F1EF71", VA = "0x1F1EE70")]
	private bool CheckNpcIcon(NpcData npcData)
	{
		return default(bool);
	}

	// Token: 0x0600414E RID: 16718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003681")]
	[Address(RVA = "0x1F1E700", Offset = "0x1F1E801", VA = "0x1F1E700")]
	private void DestroyNpcIcon()
	{
	}

	// Token: 0x0600414F RID: 16719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003682")]
	[Address(RVA = "0x1F1C1D0", Offset = "0x1F1C2D1", VA = "0x1F1C1D0")]
	private void MobSet()
	{
	}

	// Token: 0x06004150 RID: 16720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003683")]
	[Address(RVA = "0x1F1E810", Offset = "0x1F1E911", VA = "0x1F1E810")]
	private void DestroyMobIcon()
	{
	}

	// Token: 0x06004151 RID: 16721 RVA: 0x00016080 File Offset: 0x00014280
	[Token(Token = "0x6003684")]
	[Address(RVA = "0x1F1F1D0", Offset = "0x1F1F2D1", VA = "0x1F1F1D0")]
	private bool IsNpcField(NpcData npcdata)
	{
		return default(bool);
	}

	// Token: 0x06004152 RID: 16722 RVA: 0x00016098 File Offset: 0x00014298
	[Token(Token = "0x6003685")]
	[Address(RVA = "0x1F1F2E0", Offset = "0x1F1F3E1", VA = "0x1F1F2E0")]
	private bool IsNpcRoom(NpcData npcdata)
	{
		return default(bool);
	}

	// Token: 0x06004153 RID: 16723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003686")]
	[Address(RVA = "0x1F1DA10", Offset = "0x1F1DB11", VA = "0x1F1DA10")]
	private void SetPlayerIcon()
	{
	}

	// Token: 0x06004154 RID: 16724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003687")]
	[Address(RVA = "0x1F1D110", Offset = "0x1F1D211", VA = "0x1F1D110")]
	private void PartnerSet()
	{
	}

	// Token: 0x06004155 RID: 16725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003688")]
	[Address(RVA = "0x1F1E920", Offset = "0x1F1EA21", VA = "0x1F1E920")]
	private void DestroyPartnerIcon()
	{
	}

	// Token: 0x06004156 RID: 16726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003689")]
	[Address(RVA = "0x1F1C7B0", Offset = "0x1F1C8B1", VA = "0x1F1C7B0")]
	private void FriendMonsterSet()
	{
	}

	// Token: 0x06004157 RID: 16727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600368A")]
	[Address(RVA = "0x1F1EA30", Offset = "0x1F1EB31", VA = "0x1F1EA30")]
	private void DestroyFriMonsIcon()
	{
	}

	// Token: 0x06004158 RID: 16728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600368B")]
	[Address(RVA = "0x1F1D750", Offset = "0x1F1D851", VA = "0x1F1D750")]
	private void QuestSet()
	{
	}

	// Token: 0x06004159 RID: 16729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600368C")]
	[Address(RVA = "0x1F1F4B0", Offset = "0x1F1F5B1", VA = "0x1F1F4B0")]
	private List<QuestIconData> GetQuestIconData()
	{
		return null;
	}

	// Token: 0x0600415A RID: 16730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600368D")]
	[Address(RVA = "0x1F1FAD0", Offset = "0x1F1FBD1", VA = "0x1F1FAD0")]
	private void CreateQuestIcon(int DataNo, int iconType, Vector3 iconScale)
	{
	}

	// Token: 0x0600415B RID: 16731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600368E")]
	[Address(RVA = "0x1F1EB40", Offset = "0x1F1EC41", VA = "0x1F1EB40")]
	private void DestroyQuestIcon()
	{
	}

	// Token: 0x0600415C RID: 16732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600368F")]
	[Address(RVA = "0x1F1B3E0", Offset = "0x1F1B4E1", VA = "0x1F1B3E0")]
	private void BuildSet()
	{
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003690")]
	[Address(RVA = "0x1F1EC50", Offset = "0x1F1ED51", VA = "0x1F1EC50")]
	private void DestroyBuildIcon()
	{
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003691")]
	[Address(RVA = "0x1F1B900", Offset = "0x1F1BA01", VA = "0x1F1B900")]
	private void WarpIconSet()
	{
	}

	// Token: 0x0600415F RID: 16735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003692")]
	[Address(RVA = "0x1F1ED60", Offset = "0x1F1EE61", VA = "0x1F1ED60")]
	private void DestroyWarpIcon()
	{
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003693")]
	[Address(RVA = "0x1F1A460", Offset = "0x1F1A561", VA = "0x1F1A460")]
	private void SearchWarpable()
	{
	}

	// Token: 0x06004161 RID: 16737 RVA: 0x000160B0 File Offset: 0x000142B0
	[Token(Token = "0x6003694")]
	[Address(RVA = "0x1F1FF60", Offset = "0x1F20061", VA = "0x1F1FF60")]
	private bool checkHit(Vector2 cursorPos, Vector2 rectPos, Vector2 rectSize)
	{
		return default(bool);
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x000160C8 File Offset: 0x000142C8
	[Token(Token = "0x6003695")]
	[Address(RVA = "0x1F1FFA0", Offset = "0x1F200A1", VA = "0x1F1FFA0")]
	private int checkHitBuild(Vector2 cursorPos, int winPosType)
	{
		return 0;
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x000160E0 File Offset: 0x000142E0
	[Token(Token = "0x6003696")]
	[Address(RVA = "0x1F204F0", Offset = "0x1F205F1", VA = "0x1F204F0")]
	private int checkHitWarp(Vector2 cursorPos)
	{
		return 0;
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003697")]
	[Address(RVA = "0x1F20A90", Offset = "0x1F20B91", VA = "0x1F20A90")]
	private void checkHitIcon()
	{
	}

	// Token: 0x06004165 RID: 16741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003698")]
	[Address(RVA = "0x1F1B1B0", Offset = "0x1F1B2B1", VA = "0x1F1B1B0")]
	private void setBuildNPCList()
	{
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003699")]
	[Address(RVA = "0x1F195D0", Offset = "0x1F196D1", VA = "0x1F195D0")]
	private void setMapData(int mapId, int floorNo)
	{
	}

	// Token: 0x06004167 RID: 16743 RVA: 0x000160F8 File Offset: 0x000142F8
	[Token(Token = "0x600369A")]
	[Address(RVA = "0x1F1DC30", Offset = "0x1F1DD31", VA = "0x1F1DC30")]
	private float getStartScale()
	{
		return 0f;
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x00016110 File Offset: 0x00014310
	[Token(Token = "0x600369B")]
	[Address(RVA = "0x1F20ED0", Offset = "0x1F20FD1", VA = "0x1F20ED0")]
	private float getScalePoint(int no)
	{
		return 0f;
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600369C")]
	[Address(RVA = "0x1F1DE80", Offset = "0x1F1DF81", VA = "0x1F1DE80")]
	private void InitGuidStatus()
	{
	}

	// Token: 0x0600416A RID: 16746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600369D")]
	[Address(RVA = "0x1F1E1C0", Offset = "0x1F1E2C1", VA = "0x1F1E1C0")]
	private void UpdateGuidStatus()
	{
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600369E")]
	[Address(RVA = "0x1F20F70", Offset = "0x1F21071", VA = "0x1F20F70")]
	private void NewSet(Vector3 pos)
	{
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600369F")]
	[Address(RVA = "0x1F1E3E0", Offset = "0x1F1E4E1", VA = "0x1F1E3E0")]
	private void UpdateNewIcon()
	{
	}

	// Token: 0x0600416D RID: 16749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A0")]
	[Address(RVA = "0x1F21080", Offset = "0x1F21181", VA = "0x1F21080")]
	private void CheckMapScrollMax()
	{
	}

	// Token: 0x0600416E RID: 16750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A1")]
	[Address(RVA = "0x1F211B0", Offset = "0x1F212B1", VA = "0x1F211B0")]
	public void updateInput()
	{
	}

	// Token: 0x0600416F RID: 16751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A2")]
	[Address(RVA = "0x1F211F0", Offset = "0x1F212F1", VA = "0x1F211F0")]
	public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06004170 RID: 16752 RVA: 0x00016128 File Offset: 0x00014328
	[Token(Token = "0x60036A3")]
	[Address(RVA = "0x1F21270", Offset = "0x1F21371", VA = "0x1F21270")]
	public MapControl.MapCntlStep GetStep()
	{
		return MapControl.MapCntlStep.LOAD;
	}

	// Token: 0x06004171 RID: 16753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A4")]
	[Address(RVA = "0x1F1DD00", Offset = "0x1F1DE01", VA = "0x1F1DD00")]
	public void SetScroll(Vector2 addScroll)
	{
	}

	// Token: 0x06004172 RID: 16754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A5")]
	[Address(RVA = "0x1F21280", Offset = "0x1F21381", VA = "0x1F21280")]
	public void SetCursorPos(Vector3 setPos)
	{
	}

	// Token: 0x06004173 RID: 16755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A6")]
	[Address(RVA = "0x1F21290", Offset = "0x1F21391", VA = "0x1F21290")]
	public void updateScale(float addScale, bool touchFlg)
	{
	}

	// Token: 0x06004174 RID: 16756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036A7")]
	[Address(RVA = "0x1F1DCA0", Offset = "0x1F1DDA1", VA = "0x1F1DCA0")]
	public void setScale(float scale)
	{
	}

	// Token: 0x06004175 RID: 16757 RVA: 0x00016140 File Offset: 0x00014340
	[Token(Token = "0x60036A8")]
	[Address(RVA = "0x1F21550", Offset = "0x1F21651", VA = "0x1F21550")]
	public float getScale()
	{
		return 0f;
	}

	// Token: 0x06004176 RID: 16758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036A9")]
	[Address(RVA = "0x1F21560", Offset = "0x1F21661", VA = "0x1F21560")]
	public int[,] getBuildNPCList()
	{
		return null;
	}

	// Token: 0x06004177 RID: 16759 RVA: 0x00016158 File Offset: 0x00014358
	[Token(Token = "0x60036AA")]
	[Address(RVA = "0x1F21570", Offset = "0x1F21671", VA = "0x1F21570")]
	public int getHitObjNo()
	{
		return 0;
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036AB")]
	[Address(RVA = "0x1F21580", Offset = "0x1F21681", VA = "0x1F21580")]
	public void setHitObjNo(int hitNo)
	{
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x00016170 File Offset: 0x00014370
	[Token(Token = "0x60036AC")]
	[Address(RVA = "0x1F21590", Offset = "0x1F21691", VA = "0x1F21590")]
	public int getOldHitObjNo()
	{
		return 0;
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x00016188 File Offset: 0x00014388
	[Token(Token = "0x60036AD")]
	[Address(RVA = "0x1F215A0", Offset = "0x1F216A1", VA = "0x1F215A0")]
	public Vector3 getHitObjPos()
	{
		return default(Vector3);
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x000161A0 File Offset: 0x000143A0
	[Token(Token = "0x60036AE")]
	[Address(RVA = "0x1F215B0", Offset = "0x1F216B1", VA = "0x1F215B0")]
	public int getWarpObjVal()
	{
		return 0;
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036AF")]
	[Address(RVA = "0x1F215C0", Offset = "0x1F216C1", VA = "0x1F215C0")]
	public List<WarpPoints.WarpPoint> getWarpableList()
	{
		return null;
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036B0")]
	[Address(RVA = "0x1F215D0", Offset = "0x1F216D1", VA = "0x1F215D0")]
	public List<WarpPoints.WarpPoint> getWarpableFloorList()
	{
		return null;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60036B1")]
	[Address(RVA = "0x1F215E0", Offset = "0x1F216E1", VA = "0x1F215E0")]
	public static byte[] getMaskBuff()
	{
		return null;
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036B2")]
	[Address(RVA = "0x1F21650", Offset = "0x1F21751", VA = "0x1F21650")]
	public void InitInfoStatus(int infoID)
	{
	}

	// Token: 0x06004180 RID: 16768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036B3")]
	[Address(RVA = "0x1F217C0", Offset = "0x1F218C1", VA = "0x1F217C0")]
	public void UpdateInfoStatus()
	{
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036B4")]
	[Address(RVA = "0x1F219F0", Offset = "0x1F21AF1", VA = "0x1F219F0")]
	public void changeWarpIcon(int iconNo)
	{
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x000161B8 File Offset: 0x000143B8
	[Token(Token = "0x60036B5")]
	[Address(RVA = "0x1F21CC0", Offset = "0x1F21DC1", VA = "0x1F21CC0")]
	public bool getFieldFlg()
	{
		return default(bool);
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036B6")]
	[Address(RVA = "0x1F21CD0", Offset = "0x1F21DD1", VA = "0x1F21CD0")]
	public MapControl()
	{
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60036B8")]
	[Address(RVA = "0x1F22270", Offset = "0x1F22371", VA = "0x1F22270")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A74F0", Offset = "0x1A75F1")]
	private void <UpdateGuidStatus>b__144_0(bool select)
	{
	}

	// Token: 0x0400A007 RID: 40967
	[Token(Token = "0x40078B6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform MapObjectsRect;

	// Token: 0x0400A008 RID: 40968
	[Token(Token = "0x40078B7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform MainMap;

	// Token: 0x0400A009 RID: 40969
	[Token(Token = "0x40078B8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform PlayerIcon;

	// Token: 0x0400A00A RID: 40970
	[Token(Token = "0x40078B9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform NPCIconParents;

	// Token: 0x0400A00B RID: 40971
	[Token(Token = "0x40078BA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform IconParents;

	// Token: 0x0400A00C RID: 40972
	[Token(Token = "0x40078BB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform EventIconParents;

	// Token: 0x0400A00D RID: 40973
	[Token(Token = "0x40078BC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform NpcImage;

	// Token: 0x0400A00E RID: 40974
	[Token(Token = "0x40078BD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform PartnerImage;

	// Token: 0x0400A00F RID: 40975
	[Token(Token = "0x40078BE")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject BuildImage;

	// Token: 0x0400A010 RID: 40976
	[Token(Token = "0x40078BF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject WarpImage;

	// Token: 0x0400A011 RID: 40977
	[Token(Token = "0x40078C0")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UIObjectLoadingCheck checkLoad;

	// Token: 0x0400A012 RID: 40978
	[Token(Token = "0x40078C1")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text MapNameText;

	// Token: 0x0400A013 RID: 40979
	[Token(Token = "0x40078C2")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image MapNameImg;

	// Token: 0x0400A014 RID: 40980
	[Token(Token = "0x40078C3")]
	[FieldOffset(Offset = "0x80")]
	private RectTransform[] MapNPCPoitnList;

	// Token: 0x0400A015 RID: 40981
	[Token(Token = "0x40078C4")]
	[FieldOffset(Offset = "0x88")]
	private RectTransform[] NPCMapRect;

	// Token: 0x0400A016 RID: 40982
	[Token(Token = "0x40078C5")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform[] PartnerMapRect;

	// Token: 0x0400A017 RID: 40983
	[Token(Token = "0x40078C6")]
	[FieldOffset(Offset = "0x98")]
	private RectTransform[] FriMonMapRect;

	// Token: 0x0400A018 RID: 40984
	[Token(Token = "0x40078C7")]
	[FieldOffset(Offset = "0xA0")]
	private RectTransform[] QuestMapRect;

	// Token: 0x0400A019 RID: 40985
	[Token(Token = "0x40078C8")]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform[] MobMapRect;

	// Token: 0x0400A01A RID: 40986
	[Token(Token = "0x40078C9")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject[] BuildMapObj;

	// Token: 0x0400A01B RID: 40987
	[Token(Token = "0x40078CA")]
	[FieldOffset(Offset = "0xB8")]
	private RectTransform[] BuildObjRect;

	// Token: 0x0400A01C RID: 40988
	[Token(Token = "0x40078CB")]
	[FieldOffset(Offset = "0xC0")]
	private BuildIconControl[] BuildMapIconCtrl;

	// Token: 0x0400A01D RID: 40989
	[Token(Token = "0x40078CC")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject[] WarpMapObj;

	// Token: 0x0400A01E RID: 40990
	[Token(Token = "0x40078CD")]
	[FieldOffset(Offset = "0xD0")]
	private RectTransform[] WarpObjRect;

	// Token: 0x0400A01F RID: 40991
	[Token(Token = "0x40078CE")]
	[FieldOffset(Offset = "0xD8")]
	private WarpIconControl[] WarpMapIconCtrl;

	// Token: 0x0400A020 RID: 40992
	[Token(Token = "0x40078CF")]
	[FieldOffset(Offset = "0xE0")]
	private List<WarpPoints.WarpPoint> WarpableList;

	// Token: 0x0400A021 RID: 40993
	[Token(Token = "0x40078D0")]
	[FieldOffset(Offset = "0xE8")]
	private List<WarpPoints.WarpPoint> WarpableFloorList;

	// Token: 0x0400A022 RID: 40994
	[Token(Token = "0x40078D1")]
	[FieldOffset(Offset = "0xF0")]
	private List<WarpPoints.WarpPoint> WarpableGuideList;

	// Token: 0x0400A023 RID: 40995
	[Token(Token = "0x40078D2")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private BuildWindowController buildWindowController;

	// Token: 0x0400A024 RID: 40996
	[Token(Token = "0x40078D3")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Sprite homeIcon;

	// Token: 0x0400A025 RID: 40997
	[Token(Token = "0x40078D4")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private RectTransform NewMapRect;

	// Token: 0x0400A026 RID: 40998
	[Token(Token = "0x40078D5")]
	[FieldOffset(Offset = "0x110")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170810", Offset = "0x170911")]
	private bool <IsActiveInput>k__BackingField;

	// Token: 0x0400A027 RID: 40999
	[Token(Token = "0x40078D6")]
	[FieldOffset(Offset = "0x111")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170820", Offset = "0x170921")]
	private bool <IsEndFirstInput>k__BackingField;

	// Token: 0x0400A028 RID: 41000
	[Token(Token = "0x40078D7")]
	[FieldOffset(Offset = "0x112")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170830", Offset = "0x170931")]
	private bool <IsWarpHold>k__BackingField;

	// Token: 0x0400A029 RID: 41001
	[Token(Token = "0x40078D8")]
	[FieldOffset(Offset = "0x118")]
	private MapShaderController ShaderCtrl;

	// Token: 0x0400A02A RID: 41002
	[Token(Token = "0x40078D9")]
	[FieldOffset(Offset = "0x120")]
	private GameObject mapPrefab;

	// Token: 0x0400A02B RID: 41003
	[Token(Token = "0x40078DA")]
	[FieldOffset(Offset = "0x128")]
	private MapControl.MapCntlStep step;

	// Token: 0x0400A02C RID: 41004
	[Token(Token = "0x40078DB")]
	[FieldOffset(Offset = "0x12C")]
	private float MapScale;

	// Token: 0x0400A02D RID: 41005
	[Token(Token = "0x40078DC")]
	[FieldOffset(Offset = "0x130")]
	private Vector2 MapScaleSize;

	// Token: 0x0400A02E RID: 41006
	[Token(Token = "0x40078DD")]
	[FieldOffset(Offset = "0x138")]
	private Vector2 MaxMapPos;

	// Token: 0x0400A02F RID: 41007
	[Token(Token = "0x40078DE")]
	[FieldOffset(Offset = "0x140")]
	private float mapBaseSize;

	// Token: 0x0400A030 RID: 41008
	[Token(Token = "0x40078DF")]
	[FieldOffset(Offset = "0x144")]
	private Vector2 ScreenSize;

	// Token: 0x0400A031 RID: 41009
	[Token(Token = "0x40078E0")]
	private const int BuildMax = 25;

	// Token: 0x0400A032 RID: 41010
	[Token(Token = "0x40078E1")]
	[FieldOffset(Offset = "0x150")]
	private string currentSceneName;

	// Token: 0x0400A033 RID: 41011
	[Token(Token = "0x40078E2")]
	[FieldOffset(Offset = "0x158")]
	private FieldSceneId currentFieldId;

	// Token: 0x0400A034 RID: 41012
	[Token(Token = "0x40078E3")]
	[FieldOffset(Offset = "0x160")]
	private string FieldSceneName;

	// Token: 0x0400A035 RID: 41013
	[Token(Token = "0x40078E4")]
	[FieldOffset(Offset = "0x168")]
	private MapControl.MapMode mapMode;

	// Token: 0x0400A036 RID: 41014
	[Token(Token = "0x40078E5")]
	[FieldOffset(Offset = "0x16C")]
	private bool fieldFlg;

	// Token: 0x0400A037 RID: 41015
	[Token(Token = "0x40078E6")]
	[FieldOffset(Offset = "0x170")]
	private Vector3 cursorPos;

	// Token: 0x0400A038 RID: 41016
	[Token(Token = "0x40078E7")]
	[FieldOffset(Offset = "0x0")]
	private static int NPCMax;

	// Token: 0x0400A039 RID: 41017
	[Token(Token = "0x40078E8")]
	[FieldOffset(Offset = "0x180")]
	private int[,] buildNPCList;

	// Token: 0x0400A03A RID: 41018
	[Token(Token = "0x40078E9")]
	[FieldOffset(Offset = "0x188")]
	private int[] buildNPCCnt;

	// Token: 0x0400A03B RID: 41019
	[Token(Token = "0x40078EA")]
	[FieldOffset(Offset = "0x190")]
	private int warpObjVal;

	// Token: 0x0400A03C RID: 41020
	[Token(Token = "0x40078EB")]
	[FieldOffset(Offset = "0x194")]
	private int OldHitObjNo;

	// Token: 0x0400A03D RID: 41021
	[Token(Token = "0x40078EC")]
	[FieldOffset(Offset = "0x198")]
	private int HitObjNo;

	// Token: 0x0400A03E RID: 41022
	[Token(Token = "0x40078ED")]
	[FieldOffset(Offset = "0x19C")]
	private int isWarpHoldNo;

	// Token: 0x0400A03F RID: 41023
	[Token(Token = "0x40078EE")]
	[FieldOffset(Offset = "0x1A0")]
	private Vector3 HitObjPos;

	// Token: 0x0400A040 RID: 41024
	[Token(Token = "0x40078EF")]
	[FieldOffset(Offset = "0x8")]
	public static byte[] maskBuff;

	// Token: 0x0400A041 RID: 41025
	[Token(Token = "0x40078F0")]
	[FieldOffset(Offset = "0x1AC")]
	private int mapDataId;

	// Token: 0x0400A042 RID: 41026
	[Token(Token = "0x40078F1")]
	[FieldOffset(Offset = "0x1B0")]
	private int mapFloorNo;

	// Token: 0x0400A043 RID: 41027
	[Token(Token = "0x40078F2")]
	[FieldOffset(Offset = "0x1B4")]
	private int loadPrefabId;

	// Token: 0x0400A044 RID: 41028
	[Token(Token = "0x40078F3")]
	[FieldOffset(Offset = "0x1B8")]
	private int nowFileNo;

	// Token: 0x0400A045 RID: 41029
	[Token(Token = "0x40078F4")]
	[FieldOffset(Offset = "0x1BC")]
	private bool monsterHutFlg;

	// Token: 0x0400A046 RID: 41030
	[Token(Token = "0x40078F5")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170840", Offset = "0x170941")]
	private static int <MapGuideID>k__BackingField;

	// Token: 0x0400A047 RID: 41031
	[Token(Token = "0x40078F6")]
	[FieldOffset(Offset = "0x1C0")]
	private string guideSystemTextId;

	// Token: 0x0400A048 RID: 41032
	[Token(Token = "0x40078F7")]
	[FieldOffset(Offset = "0x1C8")]
	private float guideTime;

	// Token: 0x0400A049 RID: 41033
	[Token(Token = "0x40078F8")]
	[FieldOffset(Offset = "0x1CC")]
	private bool guideNewFlg;

	// Token: 0x0400A04A RID: 41034
	[Token(Token = "0x40078F9")]
	[FieldOffset(Offset = "0x1D0")]
	private float guideNewTime;

	// Token: 0x0400A04B RID: 41035
	[Token(Token = "0x40078FA")]
	[FieldOffset(Offset = "0x1D4")]
	private float guideNewScale;

	// Token: 0x0400A04C RID: 41036
	[Token(Token = "0x40078FB")]
	[FieldOffset(Offset = "0x1D8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170850", Offset = "0x170951")]
	private int <MapInfoID>k__BackingField;

	// Token: 0x0400A04D RID: 41037
	[Token(Token = "0x40078FC")]
	[FieldOffset(Offset = "0x1DC")]
	private float infoMoveSpeed;

	// Token: 0x0400A04E RID: 41038
	[Token(Token = "0x40078FD")]
	[FieldOffset(Offset = "0x1E0")]
	private Vector2 infoStartPoint;

	// Token: 0x0400A04F RID: 41039
	[Token(Token = "0x40078FE")]
	[FieldOffset(Offset = "0x1E8")]
	private Vector2 infoEndPoint;

	// Token: 0x0400A050 RID: 41040
	[Token(Token = "0x40078FF")]
	[FieldOffset(Offset = "0x1F0")]
	private float infoDistance;

	// Token: 0x0400A051 RID: 41041
	[Token(Token = "0x4007900")]
	[FieldOffset(Offset = "0x1F4")]
	private float infoStartTime;

	// Token: 0x0400A052 RID: 41042
	[Token(Token = "0x4007901")]
	[FieldOffset(Offset = "0x1F8")]
	private float infoScrollTime;

	// Token: 0x0400A053 RID: 41043
	[Token(Token = "0x4007902")]
	[FieldOffset(Offset = "0x200")]
	private List<QuestIconData> questIconList;

	// Token: 0x0400A054 RID: 41044
	[Token(Token = "0x4007903")]
	[FieldOffset(Offset = "0x208")]
	private Vector3 NpcIconScale;

	// Token: 0x0400A055 RID: 41045
	[Token(Token = "0x4007904")]
	[FieldOffset(Offset = "0x214")]
	private Vector3 FriIconScale;

	// Token: 0x0400A056 RID: 41046
	[Token(Token = "0x4007905")]
	[FieldOffset(Offset = "0x220")]
	private Vector3 MobIconScale;

	// Token: 0x0400A057 RID: 41047
	[Token(Token = "0x4007906")]
	[FieldOffset(Offset = "0x22C")]
	private Vector3 PlyrIconScale;

	// Token: 0x0400A058 RID: 41048
	[Token(Token = "0x4007907")]
	[FieldOffset(Offset = "0x238")]
	private Vector3 WarpIconScale;

	// Token: 0x0400A059 RID: 41049
	[Token(Token = "0x4007908")]
	[FieldOffset(Offset = "0x244")]
	private Vector3 WarpDiaIconScale;

	// Token: 0x0400A05A RID: 41050
	[Token(Token = "0x4007909")]
	[FieldOffset(Offset = "0x250")]
	private Vector3 WarpFDIconScale;

	// Token: 0x0400A05B RID: 41051
	[Token(Token = "0x400790A")]
	[FieldOffset(Offset = "0x25C")]
	private Vector3 BuildIconScale;

	// Token: 0x0400A05C RID: 41052
	[Token(Token = "0x400790B")]
	[FieldOffset(Offset = "0x268")]
	private Vector3 QuestIconScale;

	// Token: 0x0400A05D RID: 41053
	[Token(Token = "0x400790C")]
	[FieldOffset(Offset = "0x274")]
	private Vector3 NewIconScale;

	// Token: 0x0400A05E RID: 41054
	[Token(Token = "0x400790D")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int[] FieldPrefabIds;

	// Token: 0x020009C5 RID: 2501
	[Token(Token = "0x20012B8")]
	public enum MapCntlStep
	{
		// Token: 0x0400A060 RID: 41056
		[Token(Token = "0x401B3B5")]
		LOAD,
		// Token: 0x0400A061 RID: 41057
		[Token(Token = "0x401B3B6")]
		LOADEND,
		// Token: 0x0400A062 RID: 41058
		[Token(Token = "0x401B3B7")]
		SET_END,
		// Token: 0x0400A063 RID: 41059
		[Token(Token = "0x401B3B8")]
		GUIDE,
		// Token: 0x0400A064 RID: 41060
		[Token(Token = "0x401B3B9")]
		GUIDE_,
		// Token: 0x0400A065 RID: 41061
		[Token(Token = "0x401B3BA")]
		GUIDE_INPUT,
		// Token: 0x0400A066 RID: 41062
		[Token(Token = "0x401B3BB")]
		INPUT
	}

	// Token: 0x020009C6 RID: 2502
	[Token(Token = "0x20012B9")]
	private enum MapMode
	{
		// Token: 0x0400A068 RID: 41064
		[Token(Token = "0x401B3BD")]
		InMap,
		// Token: 0x0400A069 RID: 41065
		[Token(Token = "0x401B3BE")]
		InRoom,
		// Token: 0x0400A06A RID: 41066
		[Token(Token = "0x401B3BF")]
		InGuide
	}

	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20012BA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F30", Offset = "0x159031")]
	private sealed class <>c__DisplayClass105_0
	{
		// Token: 0x06004186 RID: 16774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0x1F22280", Offset = "0x1F22381", VA = "0x1F22280")]
		public <>c__DisplayClass105_0()
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0x1F22290", Offset = "0x1F22391", VA = "0x1F22290")]
		internal void <createMap>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x0400A06B RID: 41067
		[Token(Token = "0x401B3C0")]
		[FieldOffset(Offset = "0x10")]
		public MapControl <>4__this;

		// Token: 0x0400A06C RID: 41068
		[Token(Token = "0x401B3C1")]
		[FieldOffset(Offset = "0x18")]
		public int id;
	}

	// Token: 0x020009C8 RID: 2504
	[Token(Token = "0x20012BB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F40", Offset = "0x159041")]
	private sealed class <createMap>d__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004188 RID: 16776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0x1F18820", Offset = "0x1F18921", VA = "0x1F18820")]
		[DebuggerHidden]
		public <createMap>d__105(int <>1__state)
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B4")]
		[Address(RVA = "0x1F22490", Offset = "0x1F22591", VA = "0x1F22490", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x60075B5")]
		[Address(RVA = "0x1F224A0", Offset = "0x1F225A1", VA = "0x1F224A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8B")]
		private object Current
		{
			[Token(Token = "0x60075B6")]
			[Address(RVA = "0x1F22650", Offset = "0x1F22751", VA = "0x1F22650", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x1F22660", Offset = "0x1F22761", VA = "0x1F22660", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8C")]
		private object Current
		{
			[Token(Token = "0x60075B8")]
			[Address(RVA = "0x1F226C0", Offset = "0x1F227C1", VA = "0x1F226C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A06D RID: 41069
		[Token(Token = "0x401B3C2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A06E RID: 41070
		[Token(Token = "0x401B3C3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A06F RID: 41071
		[Token(Token = "0x401B3C4")]
		[FieldOffset(Offset = "0x20")]
		public MapControl <>4__this;

		// Token: 0x0400A070 RID: 41072
		[Token(Token = "0x401B3C5")]
		[FieldOffset(Offset = "0x28")]
		public int id;
	}
}
