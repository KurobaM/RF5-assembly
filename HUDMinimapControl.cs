using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Field;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B3 RID: 2483
[Token(Token = "0x2000681")]
public class HUDMinimapControl : SingletonMonoBehaviour<HUDMinimapControl>
{
	// Token: 0x17000909 RID: 2313
	// (get) Token: 0x060040C7 RID: 16583 RVA: 0x00015DC8 File Offset: 0x00013FC8
	// (set) Token: 0x060040C6 RID: 16582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700073D")]
	private FieldSceneId nowScene
	{
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x20502C0", Offset = "0x20503C1", VA = "0x20502C0")]
		get
		{
			return FieldSceneId.Empty;
		}
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x204CDF0", Offset = "0x204CEF1", VA = "0x204CDF0")]
		set
		{
		}
	}

	// Token: 0x060040C8 RID: 16584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003603")]
	[Address(RVA = "0x20502D0", Offset = "0x20503D1", VA = "0x20502D0")]
	private void Start()
	{
	}

	// Token: 0x060040C9 RID: 16585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003604")]
	[Address(RVA = "0x2050AC0", Offset = "0x2050BC1", VA = "0x2050AC0")]
	private void Update()
	{
	}

	// Token: 0x060040CA RID: 16586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003605")]
	[Address(RVA = "0x20518F0", Offset = "0x20519F1", VA = "0x20518F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060040CB RID: 16587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003606")]
	[Address(RVA = "0x204CE30", Offset = "0x204CF31", VA = "0x204CE30")]
	private void OnSceneChange(FieldSceneId fieldId)
	{
	}

	// Token: 0x060040CC RID: 16588 RVA: 0x00015DE0 File Offset: 0x00013FE0
	[Token(Token = "0x6003607")]
	[Address(RVA = "0x2051980", Offset = "0x2051A81", VA = "0x2051980")]
	private int getMonsterHutDataID(FieldSceneId fieldId)
	{
		return 0;
	}

	// Token: 0x060040CD RID: 16589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003608")]
	[Address(RVA = "0x20515B0", Offset = "0x20516B1", VA = "0x20515B0")]
	private void updateMapParam()
	{
	}

	// Token: 0x060040CE RID: 16590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003609")]
	[Address(RVA = "0x20520B0", Offset = "0x20521B1", VA = "0x20520B0")]
	private void updateMapIcon(Vector3 playerPos)
	{
	}

	// Token: 0x060040CF RID: 16591 RVA: 0x00015DF8 File Offset: 0x00013FF8
	[Token(Token = "0x600360A")]
	[Address(RVA = "0x2055690", Offset = "0x2055791", VA = "0x2055690")]
	private float GetDistance(Vector3 worldPos)
	{
		return 0f;
	}

	// Token: 0x060040D0 RID: 16592 RVA: 0x00015E10 File Offset: 0x00014010
	[Token(Token = "0x600360B")]
	[Address(RVA = "0x2055800", Offset = "0x2055901", VA = "0x2055800")]
	private Vector2 GetPosOnMap(Vector3 worldPos)
	{
		return default(Vector2);
	}

	// Token: 0x060040D1 RID: 16593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600360C")]
	[Address(RVA = "0x2051A60", Offset = "0x2051B61", VA = "0x2051A60")]
	private void BuildImgSet()
	{
	}

	// Token: 0x060040D2 RID: 16594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600360D")]
	[Address(RVA = "0x2052370", Offset = "0x2052471", VA = "0x2052370")]
	private void BuildSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D3 RID: 16595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600360E")]
	[Address(RVA = "0x2052A90", Offset = "0x2052B91", VA = "0x2052A90")]
	private void WarpSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D4 RID: 16596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600360F")]
	[Address(RVA = "0x20542B0", Offset = "0x20543B1", VA = "0x20542B0")]
	private void NpcSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D5 RID: 16597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003610")]
	[Address(RVA = "0x2053050", Offset = "0x2053151", VA = "0x2053050")]
	private void MobSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D6 RID: 16598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003611")]
	[Address(RVA = "0x2054A00", Offset = "0x2054B01", VA = "0x2054A00")]
	private void PartnerSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D7 RID: 16599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003612")]
	[Address(RVA = "0x2055240", Offset = "0x2055341", VA = "0x2055240")]
	private void QuestSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040D8 RID: 16600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003613")]
	[Address(RVA = "0x2055A50", Offset = "0x2055B51", VA = "0x2055A50")]
	private void CreateQuestIcon(int DataNo, int IconNo, Vector3 Scale)
	{
	}

	// Token: 0x060040D9 RID: 16601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003614")]
	[Address(RVA = "0x2055CD0", Offset = "0x2055DD1", VA = "0x2055CD0")]
	private void SetQuestIconScale(int DataNo, int IconNo, Vector3 Scale)
	{
	}

	// Token: 0x060040DA RID: 16602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003615")]
	[Address(RVA = "0x20535E0", Offset = "0x20536E1", VA = "0x20535E0")]
	private void EnemySet()
	{
	}

	// Token: 0x060040DB RID: 16603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003616")]
	[Address(RVA = "0x2053CF0", Offset = "0x2053DF1", VA = "0x2053CF0")]
	private void FriendMonsterSet(Vector3 plyPos)
	{
	}

	// Token: 0x060040DC RID: 16604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003617")]
	[Address(RVA = "0x2051DF0", Offset = "0x2051EF1", VA = "0x2051DF0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A7370", Offset = "0x1A7471")]
	private IEnumerator createMap(int id)
	{
		return null;
	}

	// Token: 0x060040DD RID: 16605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003618")]
	[Address(RVA = "0x2052180", Offset = "0x2052281", VA = "0x2052180")]
	private void mapRotate()
	{
	}

	// Token: 0x060040DE RID: 16606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003619")]
	[Address(RVA = "0x2050C40", Offset = "0x2050D41", VA = "0x2050C40")]
	private void setMapFrame()
	{
	}

	// Token: 0x060040DF RID: 16607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600361A")]
	[Address(RVA = "0x2050FC0", Offset = "0x20510C1", VA = "0x2050FC0")]
	private void SearchWarpable()
	{
	}

	// Token: 0x060040E0 RID: 16608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600361B")]
	[Address(RVA = "0x2050840", Offset = "0x2050941", VA = "0x2050840")]
	private void SearchAllWarpable()
	{
	}

	// Token: 0x060040E1 RID: 16609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600361C")]
	[Address(RVA = "0x2051970", Offset = "0x2051A71", VA = "0x2051970")]
	private void setMapData(int mapId, int floorNo)
	{
	}

	// Token: 0x060040E2 RID: 16610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600361D")]
	[Address(RVA = "0x2055E40", Offset = "0x2055F41", VA = "0x2055E40")]
	private void setMapSizeInfo(int scaleType, Vector3 pos)
	{
	}

	// Token: 0x060040E3 RID: 16611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600361E")]
	[Address(RVA = "0x2051E80", Offset = "0x2051F81", VA = "0x2051E80")]
	private void updateMapPos(Vector3 pos)
	{
	}

	// Token: 0x060040E4 RID: 16612 RVA: 0x00015E28 File Offset: 0x00014028
	[Token(Token = "0x600361F")]
	[Address(RVA = "0x2055940", Offset = "0x2055A41", VA = "0x2055940")]
	private Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos)
	{
		return default(Vector3);
	}

	// Token: 0x060040E5 RID: 16613 RVA: 0x00015E40 File Offset: 0x00014040
	[Token(Token = "0x6003620")]
	[Address(RVA = "0x2051F50", Offset = "0x2052051", VA = "0x2051F50")]
	private bool IsRoom()
	{
		return default(bool);
	}

	// Token: 0x060040E6 RID: 16614 RVA: 0x00015E58 File Offset: 0x00014058
	[Token(Token = "0x6003621")]
	[Address(RVA = "0x2051FF0", Offset = "0x20520F1", VA = "0x2051FF0")]
	private Vector3 getPlayerPos()
	{
		return default(Vector3);
	}

	// Token: 0x060040E7 RID: 16615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003622")]
	[Address(RVA = "0x2055D90", Offset = "0x2055E91", VA = "0x2055D90")]
	private void setMaskImage(Sprite spr)
	{
	}

	// Token: 0x060040E8 RID: 16616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003623")]
	[Address(RVA = "0x2055F20", Offset = "0x2056021", VA = "0x2055F20")]
	private List<QuestIconData> GetQuestIconData()
	{
		return null;
	}

	// Token: 0x060040E9 RID: 16617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003624")]
	[Address(RVA = "0x2046DB0", Offset = "0x2046EB1", VA = "0x2046DB0")]
	public void setMapSize(int sizeNo)
	{
	}

	// Token: 0x060040EA RID: 16618 RVA: 0x00015E70 File Offset: 0x00014070
	[Token(Token = "0x6003625")]
	[Address(RVA = "0x2057480", Offset = "0x2057581", VA = "0x2057480")]
	public int getWindowType()
	{
		return 0;
	}

	// Token: 0x060040EB RID: 16619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003626")]
	[Address(RVA = "0x2057490", Offset = "0x2057591", VA = "0x2057490")]
	public void setMaskBuff(byte[] maskList)
	{
	}

	// Token: 0x060040EC RID: 16620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003627")]
	[Address(RVA = "0x2051C30", Offset = "0x2051D31", VA = "0x2051C30")]
	public void updateQuestIcon()
	{
	}

	// Token: 0x060040ED RID: 16621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003628")]
	[Address(RVA = "0x2057500", Offset = "0x2057601", VA = "0x2057500")]
	public static byte[] getMaskBuff()
	{
		return null;
	}

	// Token: 0x060040EE RID: 16622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003629")]
	[Address(RVA = "0x2057570", Offset = "0x2057671", VA = "0x2057570")]
	public static List<WarpPoints.WarpPoint> getAllWarpList()
	{
		return null;
	}

	// Token: 0x060040EF RID: 16623 RVA: 0x00015E88 File Offset: 0x00014088
	[Token(Token = "0x600362A")]
	[Address(RVA = "0x2056480", Offset = "0x2056581", VA = "0x2056480")]
	public static Vector3 GetQuestIconFieldPos(FieldSceneId fieldSceneId)
	{
		return default(Vector3);
	}

	// Token: 0x060040F0 RID: 16624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600362B")]
	[Address(RVA = "0x20575E0", Offset = "0x20576E1", VA = "0x20575E0")]
	public void ChangeSeasonFieldMap(FieldSceneId fieldSceneId)
	{
	}

	// Token: 0x060040F1 RID: 16625 RVA: 0x00015EA0 File Offset: 0x000140A0
	[Token(Token = "0x600362C")]
	[Address(RVA = "0x2057650", Offset = "0x2057751", VA = "0x2057650")]
	public bool IsNotGoD2Pri()
	{
		return default(bool);
	}

	// Token: 0x060040F2 RID: 16626 RVA: 0x00015EB8 File Offset: 0x000140B8
	[Token(Token = "0x600362D")]
	[Address(RVA = "0x20577C0", Offset = "0x20578C1", VA = "0x20577C0")]
	public bool IsNotGoHuman()
	{
		return default(bool);
	}

	// Token: 0x060040F3 RID: 16627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600362E")]
	[Address(RVA = "0x2057950", Offset = "0x2057A51", VA = "0x2057950")]
	public HUDMinimapControl()
	{
	}

	// Token: 0x04009F76 RID: 40822
	[Token(Token = "0x4007835")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DispRange;

	// Token: 0x04009F77 RID: 40823
	[Token(Token = "0x4007836")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform MinimapGroupRect;

	// Token: 0x04009F78 RID: 40824
	[Token(Token = "0x4007837")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform PlayerRect;

	// Token: 0x04009F79 RID: 40825
	[Token(Token = "0x4007838")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform NpcImage;

	// Token: 0x04009F7A RID: 40826
	[Token(Token = "0x4007839")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform PartnerImage;

	// Token: 0x04009F7B RID: 40827
	[Token(Token = "0x400783A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform EnemyImage;

	// Token: 0x04009F7C RID: 40828
	[Token(Token = "0x400783B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform BuildImage;

	// Token: 0x04009F7D RID: 40829
	[Token(Token = "0x400783C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform NpcIconParent;

	// Token: 0x04009F7E RID: 40830
	[Token(Token = "0x400783D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private RectTransform IconParent;

	// Token: 0x04009F7F RID: 40831
	[Token(Token = "0x400783E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RectTransform EventIconParent;

	// Token: 0x04009F80 RID: 40832
	[Token(Token = "0x400783F")]
	[FieldOffset(Offset = "0x68")]
	private RectTransform[] NPCMapRect;

	// Token: 0x04009F81 RID: 40833
	[Token(Token = "0x4007840")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform[] PartnerMapRect;

	// Token: 0x04009F82 RID: 40834
	[Token(Token = "0x4007841")]
	[FieldOffset(Offset = "0x78")]
	private ActorID[] PartnerIconType;

	// Token: 0x04009F83 RID: 40835
	[Token(Token = "0x4007842")]
	[FieldOffset(Offset = "0x80")]
	private RectTransform[] FriMonMapRect;

	// Token: 0x04009F84 RID: 40836
	[Token(Token = "0x4007843")]
	[FieldOffset(Offset = "0x88")]
	private RectTransform[] QuestMapRect;

	// Token: 0x04009F85 RID: 40837
	[Token(Token = "0x4007844")]
	[FieldOffset(Offset = "0x90")]
	private int[] QuestIconType;

	// Token: 0x04009F86 RID: 40838
	[Token(Token = "0x4007845")]
	[FieldOffset(Offset = "0x98")]
	private RectTransform[] MobMapRect;

	// Token: 0x04009F87 RID: 40839
	[Token(Token = "0x4007846")]
	[FieldOffset(Offset = "0xA0")]
	private List<RectTransform> EnemyMapRect;

	// Token: 0x04009F88 RID: 40840
	[Token(Token = "0x4007847")]
	[FieldOffset(Offset = "0xA8")]
	private List<int> EnemyMapRectType;

	// Token: 0x04009F89 RID: 40841
	[Token(Token = "0x4007848")]
	[FieldOffset(Offset = "0xB0")]
	private RectTransform[] BuildMapRect;

	// Token: 0x04009F8A RID: 40842
	[Token(Token = "0x4007849")]
	[FieldOffset(Offset = "0xB8")]
	private List<RectTransform> WarpMapRect;

	// Token: 0x04009F8B RID: 40843
	[Token(Token = "0x400784A")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Sprite[] miniMapShdrMask;

	// Token: 0x04009F8C RID: 40844
	[Token(Token = "0x400784B")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Sprite[] miniMapBgMask;

	// Token: 0x04009F8D RID: 40845
	[Token(Token = "0x400784C")]
	[FieldOffset(Offset = "0xD0")]
	private FieldSceneId _nowScene;

	// Token: 0x04009F8E RID: 40846
	[Token(Token = "0x400784D")]
	[FieldOffset(Offset = "0xD8")]
	private List<Transform> EnemyRect;

	// Token: 0x04009F8F RID: 40847
	[Token(Token = "0x400784E")]
	[FieldOffset(Offset = "0xE0")]
	private bool RunOnScene;

	// Token: 0x04009F90 RID: 40848
	[Token(Token = "0x400784F")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private GameObject mapBg;

	// Token: 0x04009F91 RID: 40849
	[Token(Token = "0x4007850")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private GameObject[] miniMapFrame;

	// Token: 0x04009F92 RID: 40850
	[Token(Token = "0x4007851")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private GameObject[] miniMapFrameRoom;

	// Token: 0x04009F93 RID: 40851
	[Token(Token = "0x4007852")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private Image[] miniMapMaskImg;

	// Token: 0x04009F94 RID: 40852
	[Token(Token = "0x4007853")]
	[FieldOffset(Offset = "0x108")]
	private MiniMapShaderController ShaderCtrl;

	// Token: 0x04009F95 RID: 40853
	[Token(Token = "0x4007854")]
	[FieldOffset(Offset = "0x110")]
	private GameObject mapPrefab;

	// Token: 0x04009F96 RID: 40854
	[Token(Token = "0x4007855")]
	[FieldOffset(Offset = "0x118")]
	private int windowType;

	// Token: 0x04009F97 RID: 40855
	[Token(Token = "0x4007856")]
	[FieldOffset(Offset = "0x11C")]
	private HUDMinimapControl.STEP step;

	// Token: 0x04009F98 RID: 40856
	[Token(Token = "0x4007857")]
	[FieldOffset(Offset = "0x120")]
	private int mapDataId;

	// Token: 0x04009F99 RID: 40857
	[Token(Token = "0x4007858")]
	[FieldOffset(Offset = "0x124")]
	private int mapFloorNo;

	// Token: 0x04009F9A RID: 40858
	[Token(Token = "0x4007859")]
	[FieldOffset(Offset = "0x128")]
	private List<WarpPoints.WarpPoint> WarpableList;

	// Token: 0x04009F9B RID: 40859
	[Token(Token = "0x400785A")]
	[FieldOffset(Offset = "0x0")]
	private static List<WarpPoints.WarpPoint> AllWarpableList;

	// Token: 0x04009F9C RID: 40860
	[Token(Token = "0x400785B")]
	[FieldOffset(Offset = "0x130")]
	private string FieldSceneName;

	// Token: 0x04009F9D RID: 40861
	[Token(Token = "0x400785C")]
	[FieldOffset(Offset = "0x8")]
	public static byte[] maskBuff;

	// Token: 0x04009F9E RID: 40862
	[Token(Token = "0x400785D")]
	[FieldOffset(Offset = "0x138")]
	private int loadPrefabId;

	// Token: 0x04009F9F RID: 40863
	[Token(Token = "0x400785E")]
	[FieldOffset(Offset = "0x13C")]
	private int nowFileNo;

	// Token: 0x04009FA0 RID: 40864
	[Token(Token = "0x400785F")]
	[FieldOffset(Offset = "0x140")]
	private bool monsterHutFlg;

	// Token: 0x04009FA1 RID: 40865
	[Token(Token = "0x4007860")]
	[FieldOffset(Offset = "0x141")]
	private bool farmDragonFlg;

	// Token: 0x04009FA2 RID: 40866
	[Token(Token = "0x4007861")]
	[FieldOffset(Offset = "0x148")]
	private List<Vector3> BuildIconPos;

	// Token: 0x04009FA3 RID: 40867
	[Token(Token = "0x4007862")]
	[FieldOffset(Offset = "0x150")]
	private List<QuestIconData> questIconList;

	// Token: 0x04009FA4 RID: 40868
	[Token(Token = "0x4007863")]
	[FieldOffset(Offset = "0x158")]
	private Vector3 BuildIconScale;

	// Token: 0x04009FA5 RID: 40869
	[Token(Token = "0x4007864")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 NpcIconScale;

	// Token: 0x04009FA6 RID: 40870
	[Token(Token = "0x4007865")]
	[FieldOffset(Offset = "0x170")]
	private Vector3 WarpIconScale;

	// Token: 0x04009FA7 RID: 40871
	[Token(Token = "0x4007866")]
	[FieldOffset(Offset = "0x17C")]
	private Vector3 QuestIconScale;

	// Token: 0x04009FA8 RID: 40872
	[Token(Token = "0x4007867")]
	[FieldOffset(Offset = "0x188")]
	private Vector3 LoveIconScale;

	// Token: 0x04009FA9 RID: 40873
	[Token(Token = "0x4007868")]
	[FieldOffset(Offset = "0x194")]
	private Vector3 EnmIconScale;

	// Token: 0x04009FAA RID: 40874
	[Token(Token = "0x4007869")]
	[FieldOffset(Offset = "0x1A0")]
	private Vector3 BossIconScale;

	// Token: 0x04009FAB RID: 40875
	[Token(Token = "0x400786A")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector3 MobIconScale;

	// Token: 0x04009FAC RID: 40876
	[Token(Token = "0x400786B")]
	[FieldOffset(Offset = "0x1B8")]
	private Vector3 FriIconScale;

	// Token: 0x04009FAD RID: 40877
	[Token(Token = "0x400786C")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private Image smallMapNorth;

	// Token: 0x04009FAE RID: 40878
	[Token(Token = "0x400786D")]
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private Image bigMapNorth;

	// Token: 0x04009FAF RID: 40879
	[Token(Token = "0x400786E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int[] FieldPrefabIds;

	// Token: 0x020009B4 RID: 2484
	[Token(Token = "0x20012B4")]
	private enum STEP
	{
		// Token: 0x04009FB1 RID: 40881
		[Token(Token = "0x401B3A5")]
		INIT,
		// Token: 0x04009FB2 RID: 40882
		[Token(Token = "0x401B3A6")]
		LOAD,
		// Token: 0x04009FB3 RID: 40883
		[Token(Token = "0x401B3A7")]
		LOADEND,
		// Token: 0x04009FB4 RID: 40884
		[Token(Token = "0x401B3A8")]
		DATASTANDBY,
		// Token: 0x04009FB5 RID: 40885
		[Token(Token = "0x401B3A9")]
		WAIT
	}

	// Token: 0x020009B5 RID: 2485
	[Token(Token = "0x20012B5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F10", Offset = "0x159011")]
	private sealed class <>c__DisplayClass82_0
	{
		// Token: 0x060040F5 RID: 16629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A9")]
		[Address(RVA = "0x2057E10", Offset = "0x2057F11", VA = "0x2057E10")]
		public <>c__DisplayClass82_0()
		{
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x2057E20", Offset = "0x2057F21", VA = "0x2057E20")]
		internal void <createMap>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04009FB6 RID: 40886
		[Token(Token = "0x401B3AA")]
		[FieldOffset(Offset = "0x10")]
		public HUDMinimapControl <>4__this;

		// Token: 0x04009FB7 RID: 40887
		[Token(Token = "0x401B3AB")]
		[FieldOffset(Offset = "0x18")]
		public int id;
	}

	// Token: 0x020009B6 RID: 2486
	[Token(Token = "0x20012B6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158F20", Offset = "0x159021")]
	private sealed class <createMap>d__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060040F7 RID: 16631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AB")]
		[Address(RVA = "0x2055D60", Offset = "0x2055E61", VA = "0x2055D60")]
		[DebuggerHidden]
		public <createMap>d__82(int <>1__state)
		{
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AC")]
		[Address(RVA = "0x2058010", Offset = "0x2058111", VA = "0x2058010", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00015ED0 File Offset: 0x000140D0
		[Token(Token = "0x60075AD")]
		[Address(RVA = "0x2058020", Offset = "0x2058121", VA = "0x2058020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060040FA RID: 16634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D89")]
		private object Current
		{
			[Token(Token = "0x60075AE")]
			[Address(RVA = "0x20581D0", Offset = "0x20582D1", VA = "0x20581D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075AF")]
		[Address(RVA = "0x20581E0", Offset = "0x20582E1", VA = "0x20581E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8A")]
		private object Current
		{
			[Token(Token = "0x60075B0")]
			[Address(RVA = "0x2058240", Offset = "0x2058341", VA = "0x2058240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04009FB8 RID: 40888
		[Token(Token = "0x401B3AC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04009FB9 RID: 40889
		[Token(Token = "0x401B3AD")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04009FBA RID: 40890
		[Token(Token = "0x401B3AE")]
		[FieldOffset(Offset = "0x20")]
		public HUDMinimapControl <>4__this;

		// Token: 0x04009FBB RID: 40891
		[Token(Token = "0x401B3AF")]
		[FieldOffset(Offset = "0x28")]
		public int id;
	}
}
