using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200097B RID: 2427
[Token(Token = "0x200065C")]
public class UITextDic : ScriptableObject
{
	// Token: 0x06003F99 RID: 16281 RVA: 0x00015918 File Offset: 0x00013B18
	[Token(Token = "0x60034ED")]
	[Address(RVA = "0x2123100", Offset = "0x2123201", VA = "0x2123100")]
	public static UITextDic.DICID ParseToDICID(string textID)
	{
		return (UITextDic.DICID)0;
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034EE")]
	[Address(RVA = "0x21231A0", Offset = "0x21232A1", VA = "0x21231A0")]
	public void InitOnLoad()
	{
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034EF")]
	[Address(RVA = "0x21232D0", Offset = "0x21233D1", VA = "0x21232D0")]
	public UITextDic()
	{
	}

	// Token: 0x04008433 RID: 33843
	[Token(Token = "0x400770F")]
	[FieldOffset(Offset = "0x18")]
	public List<int> IdList;

	// Token: 0x04008434 RID: 33844
	[Token(Token = "0x4007710")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, int> SystemIdDic;

	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x20012A1")]
	public enum DICID
	{
		// Token: 0x04008436 RID: 33846
		[Token(Token = "0x4019988")]
		NONE = -1,
		// Token: 0x04008437 RID: 33847
		[Token(Token = "0x4019989")]
		ADV_BYTHEWAY_LV1 = 100,
		// Token: 0x04008438 RID: 33848
		[Token(Token = "0x401998A")]
		ADV_BYTHEWAY_LV2,
		// Token: 0x04008439 RID: 33849
		[Token(Token = "0x401998B")]
		ADV_BYTHEWAY_LV3,
		// Token: 0x0400843A RID: 33850
		[Token(Token = "0x401998C")]
		ADV_BED_NAME,
		// Token: 0x0400843B RID: 33851
		[Token(Token = "0x401998D")]
		ADV_BED_OK,
		// Token: 0x0400843C RID: 33852
		[Token(Token = "0x401998E")]
		ADV_BED_CANCEL,
		// Token: 0x0400843D RID: 33853
		[Token(Token = "0x401998F")]
		CAMPTOP_STATUS = 1000,
		// Token: 0x0400843E RID: 33854
		[Token(Token = "0x4019990")]
		CAMPTOP_RUCK,
		// Token: 0x0400843F RID: 33855
		[Token(Token = "0x4019991")]
		CAMPTOP_SKILL,
		// Token: 0x04008440 RID: 33856
		[Token(Token = "0x4019992")]
		CAMPTOP_RECIPE,
		// Token: 0x04008441 RID: 33857
		[Token(Token = "0x4019993")]
		CAMPTOP_PARTNER,
		// Token: 0x04008442 RID: 33858
		[Token(Token = "0x4019994")]
		CAMPTOP_FRIENDLY,
		// Token: 0x04008443 RID: 33859
		[Token(Token = "0x4019995")]
		CAMPTOP_POLICE,
		// Token: 0x04008444 RID: 33860
		[Token(Token = "0x4019996")]
		CAMPTOP_SAVE,
		// Token: 0x04008445 RID: 33861
		[Token(Token = "0x4019997")]
		CAMPTOP_OPTION,
		// Token: 0x04008446 RID: 33862
		[Token(Token = "0x4019998")]
		RUCK_SUBTITLE_RUCK,
		// Token: 0x04008447 RID: 33863
		[Token(Token = "0x4019999")]
		RUCK_SUBTITLE_RUNE,
		// Token: 0x04008448 RID: 33864
		[Token(Token = "0x401999A")]
		RECIPE_LIST_TITLE,
		// Token: 0x04008449 RID: 33865
		[Token(Token = "0x401999B")]
		RECIPE_LIST_NODATA,
		// Token: 0x0400844A RID: 33866
		[Token(Token = "0x401999C")]
		POLICEBOOK_TOP_QUEST,
		// Token: 0x0400844B RID: 33867
		[Token(Token = "0x401999D")]
		POLICEBOOK_TOP_SUBEVENT,
		// Token: 0x0400844C RID: 33868
		[Token(Token = "0x401999E")]
		POLICEBOOK_TOP_BATCH,
		// Token: 0x0400844D RID: 33869
		[Token(Token = "0x401999F")]
		POLICEBOOK_TOP_STAMPLIST,
		// Token: 0x0400844E RID: 33870
		[Token(Token = "0x40199A0")]
		POLICEBOOK_TOP_QUESTCANCEL_BTN,
		// Token: 0x0400844F RID: 33871
		[Token(Token = "0x40199A1")]
		POLICEBOOK_TOP_QUESTCANCEL_CHOICE,
		// Token: 0x04008450 RID: 33872
		[Token(Token = "0x40199A2")]
		FRIENDLY_AUTO,
		// Token: 0x04008451 RID: 33873
		[Token(Token = "0x40199A3")]
		FRIENDLY_MONSTER = 1022,
		// Token: 0x04008452 RID: 33874
		[Token(Token = "0x40199A4")]
		FRIENDLY_PEOPLE,
		// Token: 0x04008453 RID: 33875
		[Token(Token = "0x40199A5")]
		OPT_BRIGHTNESS,
		// Token: 0x04008454 RID: 33876
		[Token(Token = "0x40199A6")]
		OPT_CAMERAMOVE_HORIZONTAL,
		// Token: 0x04008455 RID: 33877
		[Token(Token = "0x40199A7")]
		OPT_CAMERAMOVE_NORMAL,
		// Token: 0x04008456 RID: 33878
		[Token(Token = "0x40199A8")]
		OPT_CAMERAMOVE_REVERT,
		// Token: 0x04008457 RID: 33879
		[Token(Token = "0x40199A9")]
		OPT_CAMERAMOVE_VERTICAL,
		// Token: 0x04008458 RID: 33880
		[Token(Token = "0x40199AA")]
		OPT_CAMERAROTSPD_HORIZONTAL,
		// Token: 0x04008459 RID: 33881
		[Token(Token = "0x40199AB")]
		OPT_CAMERAROTSPD_VERTICAL,
		// Token: 0x0400845A RID: 33882
		[Token(Token = "0x40199AC")]
		OPT_GUIDEBTN_DEFAULT,
		// Token: 0x0400845B RID: 33883
		[Token(Token = "0x40199AD")]
		OPT_HEADBTN_CONTROL,
		// Token: 0x0400845C RID: 33884
		[Token(Token = "0x40199AE")]
		OPT_HEADBTN_NETWORK,
		// Token: 0x0400845D RID: 33885
		[Token(Token = "0x40199AF")]
		OPT_HEADBTN_FEATURE,
		// Token: 0x0400845E RID: 33886
		[Token(Token = "0x40199B0")]
		OPT_HEADBTN_VOLUME,
		// Token: 0x0400845F RID: 33887
		[Token(Token = "0x40199B1")]
		OPT_MINIMAP,
		// Token: 0x04008460 RID: 33888
		[Token(Token = "0x40199B2")]
		OPT_MINIMAP_FIX,
		// Token: 0x04008461 RID: 33889
		[Token(Token = "0x40199B3")]
		OPT_MINIMAP_ROTATE,
		// Token: 0x04008462 RID: 33890
		[Token(Token = "0x40199B4")]
		OPT_SPD_FAST,
		// Token: 0x04008463 RID: 33891
		[Token(Token = "0x40199B5")]
		OPT_SPD_NORMAL,
		// Token: 0x04008464 RID: 33892
		[Token(Token = "0x40199B6")]
		OPT_SPD_SLOW,
		// Token: 0x04008465 RID: 33893
		[Token(Token = "0x40199B7")]
		OPT_TEXTSPEED,
		// Token: 0x04008466 RID: 33894
		[Token(Token = "0x40199B8")]
		OPT_VIBRATION,
		// Token: 0x04008467 RID: 33895
		[Token(Token = "0x40199B9")]
		OPT_VIBRATION_OFF,
		// Token: 0x04008468 RID: 33896
		[Token(Token = "0x40199BA")]
		OPT_VIBRATION_ON,
		// Token: 0x04008469 RID: 33897
		[Token(Token = "0x40199BB")]
		OPT_VOLUME_BGM,
		// Token: 0x0400846A RID: 33898
		[Token(Token = "0x40199BC")]
		OPT_VOLUME_ENVI,
		// Token: 0x0400846B RID: 33899
		[Token(Token = "0x40199BD")]
		OPT_VOLUME_SE,
		// Token: 0x0400846C RID: 33900
		[Token(Token = "0x40199BE")]
		OPT_VOLUME_VOICE,
		// Token: 0x0400846D RID: 33901
		[Token(Token = "0x40199BF")]
		OPT_VOLUME_MOVIE,
		// Token: 0x0400846E RID: 33902
		[Token(Token = "0x40199C0")]
		OPT_ON,
		// Token: 0x0400846F RID: 33903
		[Token(Token = "0x40199C1")]
		OPT_OFF,
		// Token: 0x04008470 RID: 33904
		[Token(Token = "0x40199C2")]
		OPT_CAMERA_AUTO_ROTATE,
		// Token: 0x04008471 RID: 33905
		[Token(Token = "0x40199C3")]
		OPT_AUTOLOOT,
		// Token: 0x04008472 RID: 33906
		[Token(Token = "0x40199C4")]
		OPT_SETDEFAULT_POPUP,
		// Token: 0x04008473 RID: 33907
		[Token(Token = "0x40199C5")]
		PARTNER_NOFRIEND,
		// Token: 0x04008474 RID: 33908
		[Token(Token = "0x40199C6")]
		NOLIST_SKILL,
		// Token: 0x04008475 RID: 33909
		[Token(Token = "0x40199C7")]
		POLICEBOOK_WANTED_TOPIC,
		// Token: 0x04008476 RID: 33910
		[Token(Token = "0x40199C8")]
		POLICEBOOK_WANTED_DETAIL_NPC,
		// Token: 0x04008477 RID: 33911
		[Token(Token = "0x40199C9")]
		POLICEBOOK_WANTED_DETAIL_MONSTER,
		// Token: 0x04008478 RID: 33912
		[Token(Token = "0x40199CA")]
		POLICEBOOK_WANTED_DETAIL_PLACE,
		// Token: 0x04008479 RID: 33913
		[Token(Token = "0x40199CB")]
		OPT_FARMCAMERA,
		// Token: 0x0400847A RID: 33914
		[Token(Token = "0x40199CC")]
		OPT_AUTO_TARGET,
		// Token: 0x0400847B RID: 33915
		[Token(Token = "0x40199CD")]
		OPT_SUBTITLE,
		// Token: 0x0400847C RID: 33916
		[Token(Token = "0x40199CE")]
		CAMP_BADSTATUS_PARALYSIS,
		// Token: 0x0400847D RID: 33917
		[Token(Token = "0x40199CF")]
		CAMP_BADSTATUS_SLEEP,
		// Token: 0x0400847E RID: 33918
		[Token(Token = "0x40199D0")]
		CAMP_BADSTATUS_SEAL,
		// Token: 0x0400847F RID: 33919
		[Token(Token = "0x40199D1")]
		CAMP_BADSTATUS_POISON,
		// Token: 0x04008480 RID: 33920
		[Token(Token = "0x40199D2")]
		CAMP_BADSTATUS_TIRE,
		// Token: 0x04008481 RID: 33921
		[Token(Token = "0x40199D3")]
		CAMP_BADSTATUS_SICK,
		// Token: 0x04008482 RID: 33922
		[Token(Token = "0x40199D4")]
		NOLIST_FRIENDLIST,
		// Token: 0x04008483 RID: 33923
		[Token(Token = "0x40199D5")]
		NOLIST_ORDERLIST,
		// Token: 0x04008484 RID: 33924
		[Token(Token = "0x40199D6")]
		HUDCLOCK_SPRING = 2000,
		// Token: 0x04008485 RID: 33925
		[Token(Token = "0x40199D7")]
		HUDCLOCK_SUMMER,
		// Token: 0x04008486 RID: 33926
		[Token(Token = "0x40199D8")]
		HUDCLOCK_AUTUMN,
		// Token: 0x04008487 RID: 33927
		[Token(Token = "0x40199D9")]
		HUDCLOCK_WINTER,
		// Token: 0x04008488 RID: 33928
		[Token(Token = "0x40199DA")]
		HUDCLOCK_DATE_HOL,
		// Token: 0x04008489 RID: 33929
		[Token(Token = "0x40199DB")]
		HUDCLOCK_DATE_MON,
		// Token: 0x0400848A RID: 33930
		[Token(Token = "0x40199DC")]
		HUDCLOCK_DATE_TUE,
		// Token: 0x0400848B RID: 33931
		[Token(Token = "0x40199DD")]
		HUDCLOCK_DATE_WED,
		// Token: 0x0400848C RID: 33932
		[Token(Token = "0x40199DE")]
		HUDCLOCK_DATE_THU,
		// Token: 0x0400848D RID: 33933
		[Token(Token = "0x40199DF")]
		HUDCLOCK_DATE_FRI,
		// Token: 0x0400848E RID: 33934
		[Token(Token = "0x40199E0")]
		HUD_MONEY,
		// Token: 0x0400848F RID: 33935
		[Token(Token = "0x40199E1")]
		HUD_SEEDPOINT,
		// Token: 0x04008490 RID: 33936
		[Token(Token = "0x40199E2")]
		HUDCLOCK_TIME_FORMAT,
		// Token: 0x04008491 RID: 33937
		[Token(Token = "0x40199E3")]
		HUDCLOCK_TIME_AM,
		// Token: 0x04008492 RID: 33938
		[Token(Token = "0x40199E4")]
		HUDCLOCK_TIME_PM,
		// Token: 0x04008493 RID: 33939
		[Token(Token = "0x40199E5")]
		HUDCLOCK_DATE,
		// Token: 0x04008494 RID: 33940
		[Token(Token = "0x40199E6")]
		HUDGUIDE_TAKEUP,
		// Token: 0x04008495 RID: 33941
		[Token(Token = "0x40199E7")]
		HUDGUIDE_THROW,
		// Token: 0x04008496 RID: 33942
		[Token(Token = "0x40199E8")]
		HUDGUIDE_EAT,
		// Token: 0x04008497 RID: 33943
		[Token(Token = "0x40199E9")]
		HUDGUIDE_USE,
		// Token: 0x04008498 RID: 33944
		[Token(Token = "0x40199EA")]
		HUDGUIDE_EQUIP,
		// Token: 0x04008499 RID: 33945
		[Token(Token = "0x40199EB")]
		HUDGUIDE_PUTGROUND,
		// Token: 0x0400849A RID: 33946
		[Token(Token = "0x40199EC")]
		HUDGUIDE_PUTRUCK,
		// Token: 0x0400849B RID: 33947
		[Token(Token = "0x40199ED")]
		HUDGUIDE_ACTION,
		// Token: 0x0400849C RID: 33948
		[Token(Token = "0x40199EE")]
		HUDGUIDE_TALK,
		// Token: 0x0400849D RID: 33949
		[Token(Token = "0x40199EF")]
		HUDGUIDE_GIVEITEM,
		// Token: 0x0400849E RID: 33950
		[Token(Token = "0x40199F0")]
		HUDGUIDE_FISHING,
		// Token: 0x0400849F RID: 33951
		[Token(Token = "0x40199F1")]
		CALENDER_DATE_SCHEDULE = 3000,
		// Token: 0x040084A0 RID: 33952
		[Token(Token = "0x40199F2")]
		CALENDER_DATE_FORMAT,
		// Token: 0x040084A1 RID: 33953
		[Token(Token = "0x40199F3")]
		CALENDER_YEAR_FORMAT,
		// Token: 0x040084A2 RID: 33954
		[Token(Token = "0x40199F4")]
		CALENDER_FRI,
		// Token: 0x040084A3 RID: 33955
		[Token(Token = "0x40199F5")]
		CALENDER_HOL,
		// Token: 0x040084A4 RID: 33956
		[Token(Token = "0x40199F6")]
		CALENDER_MON,
		// Token: 0x040084A5 RID: 33957
		[Token(Token = "0x40199F7")]
		CALENDER_THU,
		// Token: 0x040084A6 RID: 33958
		[Token(Token = "0x40199F8")]
		CALENDER_TUE,
		// Token: 0x040084A7 RID: 33959
		[Token(Token = "0x40199F9")]
		CALENDER_WED,
		// Token: 0x040084A8 RID: 33960
		[Token(Token = "0x40199FA")]
		CALENDER_SPRING,
		// Token: 0x040084A9 RID: 33961
		[Token(Token = "0x40199FB")]
		CALENDER_SNOWY,
		// Token: 0x040084AA RID: 33962
		[Token(Token = "0x40199FC")]
		CALENDER_SUMMER,
		// Token: 0x040084AB RID: 33963
		[Token(Token = "0x40199FD")]
		CALENDER_AUTHUM,
		// Token: 0x040084AC RID: 33964
		[Token(Token = "0x40199FE")]
		CALENDERFESTIVAL_00,
		// Token: 0x040084AD RID: 33965
		[Token(Token = "0x40199FF")]
		CALENDERFESTIVAL_01,
		// Token: 0x040084AE RID: 33966
		[Token(Token = "0x4019A00")]
		CALENDERFESTIVAL_02,
		// Token: 0x040084AF RID: 33967
		[Token(Token = "0x4019A01")]
		CALENDERFESTIVAL_03,
		// Token: 0x040084B0 RID: 33968
		[Token(Token = "0x4019A02")]
		CALENDERFESTIVAL_04,
		// Token: 0x040084B1 RID: 33969
		[Token(Token = "0x4019A03")]
		CALENDERFESTIVAL_05,
		// Token: 0x040084B2 RID: 33970
		[Token(Token = "0x4019A04")]
		CALENDERFESTIVAL_06,
		// Token: 0x040084B3 RID: 33971
		[Token(Token = "0x4019A05")]
		CALENDERFESTIVAL_07,
		// Token: 0x040084B4 RID: 33972
		[Token(Token = "0x4019A06")]
		CALENDERFESTIVAL_08,
		// Token: 0x040084B5 RID: 33973
		[Token(Token = "0x4019A07")]
		CALENDERFESTIVAL_09,
		// Token: 0x040084B6 RID: 33974
		[Token(Token = "0x4019A08")]
		CALENDERFESTIVAL_10,
		// Token: 0x040084B7 RID: 33975
		[Token(Token = "0x4019A09")]
		CALENDERFESTIVAL_11,
		// Token: 0x040084B8 RID: 33976
		[Token(Token = "0x4019A0A")]
		CALENDERFESTIVAL_12,
		// Token: 0x040084B9 RID: 33977
		[Token(Token = "0x4019A0B")]
		CALENDERFESTIVAL_13,
		// Token: 0x040084BA RID: 33978
		[Token(Token = "0x4019A0C")]
		CALENDERFESTIVAL_14,
		// Token: 0x040084BB RID: 33979
		[Token(Token = "0x4019A0D")]
		CALENDERFESTIVAL_15,
		// Token: 0x040084BC RID: 33980
		[Token(Token = "0x4019A0E")]
		CALENDERFESTIVAL_16,
		// Token: 0x040084BD RID: 33981
		[Token(Token = "0x4019A0F")]
		CALENDERFESTIVAL_17,
		// Token: 0x040084BE RID: 33982
		[Token(Token = "0x4019A10")]
		CALENDERFESTIVAL_18,
		// Token: 0x040084BF RID: 33983
		[Token(Token = "0x4019A11")]
		CALENDERFESTIVAL_19,
		// Token: 0x040084C0 RID: 33984
		[Token(Token = "0x4019A12")]
		CALENDERFESTIVAL_20,
		// Token: 0x040084C1 RID: 33985
		[Token(Token = "0x4019A13")]
		CALENDERFESTIVAL_21,
		// Token: 0x040084C2 RID: 33986
		[Token(Token = "0x4019A14")]
		NPCBIRTHDAY_NPCID_00,
		// Token: 0x040084C3 RID: 33987
		[Token(Token = "0x4019A15")]
		NPCBIRTHDAY_NPCID_02,
		// Token: 0x040084C4 RID: 33988
		[Token(Token = "0x4019A16")]
		NPCBIRTHDAY_NPCID_03,
		// Token: 0x040084C5 RID: 33989
		[Token(Token = "0x4019A17")]
		NPCBIRTHDAY_NPCID_04,
		// Token: 0x040084C6 RID: 33990
		[Token(Token = "0x4019A18")]
		NPCBIRTHDAY_NPCID_05,
		// Token: 0x040084C7 RID: 33991
		[Token(Token = "0x4019A19")]
		NPCBIRTHDAY_NPCID_06,
		// Token: 0x040084C8 RID: 33992
		[Token(Token = "0x4019A1A")]
		NPCBIRTHDAY_NPCID_07,
		// Token: 0x040084C9 RID: 33993
		[Token(Token = "0x4019A1B")]
		NPCBIRTHDAY_NPCID_08,
		// Token: 0x040084CA RID: 33994
		[Token(Token = "0x4019A1C")]
		NPCBIRTHDAY_NPCID_09,
		// Token: 0x040084CB RID: 33995
		[Token(Token = "0x4019A1D")]
		NPCBIRTHDAY_NPCID_10,
		// Token: 0x040084CC RID: 33996
		[Token(Token = "0x4019A1E")]
		NPCBIRTHDAY_NPCID_11,
		// Token: 0x040084CD RID: 33997
		[Token(Token = "0x4019A1F")]
		NPCBIRTHDAY_NPCID_12,
		// Token: 0x040084CE RID: 33998
		[Token(Token = "0x4019A20")]
		NPCBIRTHDAY_NPCID_13,
		// Token: 0x040084CF RID: 33999
		[Token(Token = "0x4019A21")]
		NPCBIRTHDAY_NPCID_14,
		// Token: 0x040084D0 RID: 34000
		[Token(Token = "0x4019A22")]
		NPCBIRTHDAY_NPCID_15,
		// Token: 0x040084D1 RID: 34001
		[Token(Token = "0x4019A23")]
		NPCBIRTHDAY_NPCID_16,
		// Token: 0x040084D2 RID: 34002
		[Token(Token = "0x4019A24")]
		NPCBIRTHDAY_NPCID_17,
		// Token: 0x040084D3 RID: 34003
		[Token(Token = "0x4019A25")]
		NPCBIRTHDAY_NPCID_18,
		// Token: 0x040084D4 RID: 34004
		[Token(Token = "0x4019A26")]
		NPCBIRTHDAY_NPCID_19,
		// Token: 0x040084D5 RID: 34005
		[Token(Token = "0x4019A27")]
		NPCBIRTHDAY_NPCID_20,
		// Token: 0x040084D6 RID: 34006
		[Token(Token = "0x4019A28")]
		NPCBIRTHDAY_NPCID_21,
		// Token: 0x040084D7 RID: 34007
		[Token(Token = "0x4019A29")]
		NPCBIRTHDAY_NPCID_22,
		// Token: 0x040084D8 RID: 34008
		[Token(Token = "0x4019A2A")]
		NPCBIRTHDAY_NPCID_23,
		// Token: 0x040084D9 RID: 34009
		[Token(Token = "0x4019A2B")]
		NPCBIRTHDAY_NPCID_24,
		// Token: 0x040084DA RID: 34010
		[Token(Token = "0x4019A2C")]
		NPCBIRTHDAY_NPCID_25,
		// Token: 0x040084DB RID: 34011
		[Token(Token = "0x4019A2D")]
		NPCBIRTHDAY_NPCID_26,
		// Token: 0x040084DC RID: 34012
		[Token(Token = "0x4019A2E")]
		NPCBIRTHDAY_NPCID_27,
		// Token: 0x040084DD RID: 34013
		[Token(Token = "0x4019A2F")]
		NPCBIRTHDAY_NPCID_28,
		// Token: 0x040084DE RID: 34014
		[Token(Token = "0x4019A30")]
		NPCBIRTHDAY_NPCID_31,
		// Token: 0x040084DF RID: 34015
		[Token(Token = "0x4019A31")]
		NPCBIRTHDAY_NPCID_32,
		// Token: 0x040084E0 RID: 34016
		[Token(Token = "0x4019A32")]
		NPCBIRTHDAY_CHILD,
		// Token: 0x040084E1 RID: 34017
		[Token(Token = "0x4019A33")]
		BIRTHDAYSELECTPOPUP,
		// Token: 0x040084E2 RID: 34018
		[Token(Token = "0x4019A34")]
		CALENDER_NOPET,
		// Token: 0x040084E3 RID: 34019
		[Token(Token = "0x4019A35")]
		CALENDER_MEMORIES_GLUTTON,
		// Token: 0x040084E4 RID: 34020
		[Token(Token = "0x4019A36")]
		CALENDER_MEMORIES_BAFFAMO,
		// Token: 0x040084E5 RID: 34021
		[Token(Token = "0x4019A37")]
		CALENDER_MEMORIES_BEANSOWING,
		// Token: 0x040084E6 RID: 34022
		[Token(Token = "0x4019A38")]
		CALENDER_MEMORIES_SNOWMAN,
		// Token: 0x040084E7 RID: 34023
		[Token(Token = "0x4019A39")]
		CALENDER_MEMORIES_PET,
		// Token: 0x040084E8 RID: 34024
		[Token(Token = "0x4019A3A")]
		CALENDAR_SELECTBIRTHDAY_POPUP,
		// Token: 0x040084E9 RID: 34025
		[Token(Token = "0x4019A3B")]
		BTNHINT_000 = 4000,
		// Token: 0x040084EA RID: 34026
		[Token(Token = "0x4019A3C")]
		BTNHINT_001,
		// Token: 0x040084EB RID: 34027
		[Token(Token = "0x4019A3D")]
		BTNHINT_002,
		// Token: 0x040084EC RID: 34028
		[Token(Token = "0x4019A3E")]
		BTNHINT_003,
		// Token: 0x040084ED RID: 34029
		[Token(Token = "0x4019A3F")]
		BTNHINT_004,
		// Token: 0x040084EE RID: 34030
		[Token(Token = "0x4019A40")]
		BTNHINT_005,
		// Token: 0x040084EF RID: 34031
		[Token(Token = "0x4019A41")]
		BTNHINT_006,
		// Token: 0x040084F0 RID: 34032
		[Token(Token = "0x4019A42")]
		BTNHINT_007,
		// Token: 0x040084F1 RID: 34033
		[Token(Token = "0x4019A43")]
		BTNHINT_008,
		// Token: 0x040084F2 RID: 34034
		[Token(Token = "0x4019A44")]
		BTNHINT_009,
		// Token: 0x040084F3 RID: 34035
		[Token(Token = "0x4019A45")]
		BTNHINT_010,
		// Token: 0x040084F4 RID: 34036
		[Token(Token = "0x4019A46")]
		BTNHINT_011,
		// Token: 0x040084F5 RID: 34037
		[Token(Token = "0x4019A47")]
		BTNHINT_012,
		// Token: 0x040084F6 RID: 34038
		[Token(Token = "0x4019A48")]
		BTNHINT_013,
		// Token: 0x040084F7 RID: 34039
		[Token(Token = "0x4019A49")]
		BTNHINT_014,
		// Token: 0x040084F8 RID: 34040
		[Token(Token = "0x4019A4A")]
		BTNHINT_015,
		// Token: 0x040084F9 RID: 34041
		[Token(Token = "0x4019A4B")]
		BTNHINT_016,
		// Token: 0x040084FA RID: 34042
		[Token(Token = "0x4019A4C")]
		BTNHINT_017,
		// Token: 0x040084FB RID: 34043
		[Token(Token = "0x4019A4D")]
		BTNHINT_018,
		// Token: 0x040084FC RID: 34044
		[Token(Token = "0x4019A4E")]
		BTNHINT_019,
		// Token: 0x040084FD RID: 34045
		[Token(Token = "0x4019A4F")]
		BTNHINT_020,
		// Token: 0x040084FE RID: 34046
		[Token(Token = "0x4019A50")]
		BTNHINT_021,
		// Token: 0x040084FF RID: 34047
		[Token(Token = "0x4019A51")]
		BTNHINT_022,
		// Token: 0x04008500 RID: 34048
		[Token(Token = "0x4019A52")]
		BTNHINT_023,
		// Token: 0x04008501 RID: 34049
		[Token(Token = "0x4019A53")]
		BTNHINT_024,
		// Token: 0x04008502 RID: 34050
		[Token(Token = "0x4019A54")]
		BTNHINT_025,
		// Token: 0x04008503 RID: 34051
		[Token(Token = "0x4019A55")]
		BTNHINT_026,
		// Token: 0x04008504 RID: 34052
		[Token(Token = "0x4019A56")]
		BTNHINT_027,
		// Token: 0x04008505 RID: 34053
		[Token(Token = "0x4019A57")]
		BTNHINT_028,
		// Token: 0x04008506 RID: 34054
		[Token(Token = "0x4019A58")]
		BTNHINT_029,
		// Token: 0x04008507 RID: 34055
		[Token(Token = "0x4019A59")]
		BTNHINT_030,
		// Token: 0x04008508 RID: 34056
		[Token(Token = "0x4019A5A")]
		BTNHINT_031,
		// Token: 0x04008509 RID: 34057
		[Token(Token = "0x4019A5B")]
		BTNHINT_032,
		// Token: 0x0400850A RID: 34058
		[Token(Token = "0x4019A5C")]
		BTNHINT_033,
		// Token: 0x0400850B RID: 34059
		[Token(Token = "0x4019A5D")]
		BTNHINT_034,
		// Token: 0x0400850C RID: 34060
		[Token(Token = "0x4019A5E")]
		BTNHINT_035,
		// Token: 0x0400850D RID: 34061
		[Token(Token = "0x4019A5F")]
		BTNHINT_036,
		// Token: 0x0400850E RID: 34062
		[Token(Token = "0x4019A60")]
		BTNHINT_037,
		// Token: 0x0400850F RID: 34063
		[Token(Token = "0x4019A61")]
		BTNHINT_038,
		// Token: 0x04008510 RID: 34064
		[Token(Token = "0x4019A62")]
		BTNHINT_039,
		// Token: 0x04008511 RID: 34065
		[Token(Token = "0x4019A63")]
		BTNHINT_040,
		// Token: 0x04008512 RID: 34066
		[Token(Token = "0x4019A64")]
		BTNHINT_041,
		// Token: 0x04008513 RID: 34067
		[Token(Token = "0x4019A65")]
		BTNHINT_042,
		// Token: 0x04008514 RID: 34068
		[Token(Token = "0x4019A66")]
		BTNHINT_043,
		// Token: 0x04008515 RID: 34069
		[Token(Token = "0x4019A67")]
		BTNHINT_044,
		// Token: 0x04008516 RID: 34070
		[Token(Token = "0x4019A68")]
		BTNHINT_045,
		// Token: 0x04008517 RID: 34071
		[Token(Token = "0x4019A69")]
		BTNHINT_046,
		// Token: 0x04008518 RID: 34072
		[Token(Token = "0x4019A6A")]
		BTNHINT_047,
		// Token: 0x04008519 RID: 34073
		[Token(Token = "0x4019A6B")]
		BTNHINT_048,
		// Token: 0x0400851A RID: 34074
		[Token(Token = "0x4019A6C")]
		BTNHINT_049,
		// Token: 0x0400851B RID: 34075
		[Token(Token = "0x4019A6D")]
		BTNHINT_050,
		// Token: 0x0400851C RID: 34076
		[Token(Token = "0x4019A6E")]
		BTNHINT_051,
		// Token: 0x0400851D RID: 34077
		[Token(Token = "0x4019A6F")]
		BTNHINT_052,
		// Token: 0x0400851E RID: 34078
		[Token(Token = "0x4019A70")]
		BTNHINT_053,
		// Token: 0x0400851F RID: 34079
		[Token(Token = "0x4019A71")]
		BTNHINT_054,
		// Token: 0x04008520 RID: 34080
		[Token(Token = "0x4019A72")]
		BTNHINT_055,
		// Token: 0x04008521 RID: 34081
		[Token(Token = "0x4019A73")]
		BTNHINT_056,
		// Token: 0x04008522 RID: 34082
		[Token(Token = "0x4019A74")]
		BTNHINT_057,
		// Token: 0x04008523 RID: 34083
		[Token(Token = "0x4019A75")]
		BTNHINT_058,
		// Token: 0x04008524 RID: 34084
		[Token(Token = "0x4019A76")]
		BTNHINT_059,
		// Token: 0x04008525 RID: 34085
		[Token(Token = "0x4019A77")]
		BTNHINT_060,
		// Token: 0x04008526 RID: 34086
		[Token(Token = "0x4019A78")]
		BTNHINT_061,
		// Token: 0x04008527 RID: 34087
		[Token(Token = "0x4019A79")]
		SHOPTXT_PurchaseConfirm = 5000,
		// Token: 0x04008528 RID: 34088
		[Token(Token = "0x4019A7A")]
		SHOP_BUYBTN,
		// Token: 0x04008529 RID: 34089
		[Token(Token = "0x4019A7B")]
		SHOP_RESET,
		// Token: 0x0400852A RID: 34090
		[Token(Token = "0x4019A7C")]
		SHOP_HADCOUNT,
		// Token: 0x0400852B RID: 34091
		[Token(Token = "0x4019A7D")]
		SHOP_TOTALPRICE,
		// Token: 0x0400852C RID: 34092
		[Token(Token = "0x4019A7E")]
		SHOPTXT_VarietyShop,
		// Token: 0x0400852D RID: 34093
		[Token(Token = "0x4019A7F")]
		SHOPTXT_BlacksmithShop,
		// Token: 0x0400852E RID: 34094
		[Token(Token = "0x4019A80")]
		SHOPTXT_Restaurent,
		// Token: 0x0400852F RID: 34095
		[Token(Token = "0x4019A81")]
		SHOPTXT_Builder,
		// Token: 0x04008530 RID: 34096
		[Token(Token = "0x4019A82")]
		SHOPTXT_Furniture,
		// Token: 0x04008531 RID: 34097
		[Token(Token = "0x4019A83")]
		SHOPTXT_CrystalShop,
		// Token: 0x04008532 RID: 34098
		[Token(Token = "0x4019A84")]
		SHOPTXT_Hospital,
		// Token: 0x04008533 RID: 34099
		[Token(Token = "0x4019A85")]
		SHOPTXT_FlowerShop,
		// Token: 0x04008534 RID: 34100
		[Token(Token = "0x4019A86")]
		SHOPCAT_BlackSmith_Wapon_00,
		// Token: 0x04008535 RID: 34101
		[Token(Token = "0x4019A87")]
		SHOPCAT_BlackSmith_Wapon_01,
		// Token: 0x04008536 RID: 34102
		[Token(Token = "0x4019A88")]
		SHOPCAT_BlackSmith_Wapon_02,
		// Token: 0x04008537 RID: 34103
		[Token(Token = "0x4019A89")]
		SHOPCAT_BlackSmith_Wapon_03,
		// Token: 0x04008538 RID: 34104
		[Token(Token = "0x4019A8A")]
		SHOPCAT_BlackSmith_Wapon_04,
		// Token: 0x04008539 RID: 34105
		[Token(Token = "0x4019A8B")]
		SHOPCAT_BlackSmith_Acce_00,
		// Token: 0x0400853A RID: 34106
		[Token(Token = "0x4019A8C")]
		SHOPCAT_BlackSmith_Acce_01,
		// Token: 0x0400853B RID: 34107
		[Token(Token = "0x4019A8D")]
		SHOPCAT_BlackSmith_Arm_00,
		// Token: 0x0400853C RID: 34108
		[Token(Token = "0x4019A8E")]
		SHOPCAT_BlackSmith_Arm_01,
		// Token: 0x0400853D RID: 34109
		[Token(Token = "0x4019A8F")]
		SHOPCAT_BlackSmith_Tool_00,
		// Token: 0x0400853E RID: 34110
		[Token(Token = "0x4019A90")]
		SHOPCAT_BlackSmith_Tool_01,
		// Token: 0x0400853F RID: 34111
		[Token(Token = "0x4019A91")]
		SHOPCAT_Blacksmith_Stone_00,
		// Token: 0x04008540 RID: 34112
		[Token(Token = "0x4019A92")]
		SHOPCAT_Variety_Seed_00,
		// Token: 0x04008541 RID: 34113
		[Token(Token = "0x4019A93")]
		SHOPCAT_Variety_Seed_01,
		// Token: 0x04008542 RID: 34114
		[Token(Token = "0x4019A94")]
		SHOPCAT_Variety_Dekiai_00,
		// Token: 0x04008543 RID: 34115
		[Token(Token = "0x4019A95")]
		SHOPCAT_Variety_Vesi_00,
		// Token: 0x04008544 RID: 34116
		[Token(Token = "0x4019A96")]
		SHOPCAT_Variety_Fish_00,
		// Token: 0x04008545 RID: 34117
		[Token(Token = "0x4019A97")]
		SHOPCAT_Restaurent_Cook_00,
		// Token: 0x04008546 RID: 34118
		[Token(Token = "0x4019A98")]
		SHOPCAT_CrystalShop_Magic_00,
		// Token: 0x04008547 RID: 34119
		[Token(Token = "0x4019A99")]
		SHOPCAT_CrystalShop_Magic_01,
		// Token: 0x04008548 RID: 34120
		[Token(Token = "0x4019A9A")]
		SHOPCAT_CrystalShop_RA_00,
		// Token: 0x04008549 RID: 34121
		[Token(Token = "0x4019A9B")]
		SHOPCAT_CrystalShop_RA_01,
		// Token: 0x0400854A RID: 34122
		[Token(Token = "0x4019A9C")]
		SHOPCAT_CrystalShop_Jem_00,
		// Token: 0x0400854B RID: 34123
		[Token(Token = "0x4019A9D")]
		SHOPCAT_CrystalShop_Koueki_00,
		// Token: 0x0400854C RID: 34124
		[Token(Token = "0x4019A9E")]
		SHOPCAT_Hospital_Drag_00,
		// Token: 0x0400854D RID: 34125
		[Token(Token = "0x4019A9F")]
		SHOPCAT_FlowerShop_Seed_00,
		// Token: 0x0400854E RID: 34126
		[Token(Token = "0x4019AA0")]
		SHOPCAT_FlowerShop_Eiyouzai_00,
		// Token: 0x0400854F RID: 34127
		[Token(Token = "0x4019AA1")]
		SHOPCAT_FlowerShop_Flower_00,
		// Token: 0x04008550 RID: 34128
		[Token(Token = "0x4019AA2")]
		SHOPCAT_Builder_00,
		// Token: 0x04008551 RID: 34129
		[Token(Token = "0x4019AA3")]
		SHOPCAT_Furniture_00,
		// Token: 0x04008552 RID: 34130
		[Token(Token = "0x4019AA4")]
		SHOPCAT_DUMMY,
		// Token: 0x04008553 RID: 34131
		[Token(Token = "0x4019AA5")]
		ShopTalk__VarietyShop_Terry_0,
		// Token: 0x04008554 RID: 34132
		[Token(Token = "0x4019AA6")]
		ShopTalk__VarietyShop_Terry_1,
		// Token: 0x04008555 RID: 34133
		[Token(Token = "0x4019AA7")]
		ShopTalk__VarietyShop_Terry_2,
		// Token: 0x04008556 RID: 34134
		[Token(Token = "0x4019AA8")]
		ShopTalk__VarietyShop_Terry_3,
		// Token: 0x04008557 RID: 34135
		[Token(Token = "0x4019AA9")]
		ShopTalk__VarietyShop_Terry_4,
		// Token: 0x04008558 RID: 34136
		[Token(Token = "0x4019AAA")]
		ShopTalk__VarietyShop_Terry_5,
		// Token: 0x04008559 RID: 34137
		[Token(Token = "0x4019AAB")]
		ShopTalk__VarietyShop_Terry_6,
		// Token: 0x0400855A RID: 34138
		[Token(Token = "0x4019AAC")]
		ShopTalk__VarietyShop_Terry_7,
		// Token: 0x0400855B RID: 34139
		[Token(Token = "0x4019AAD")]
		ShopTalk__VarietyShop_Terry_8,
		// Token: 0x0400855C RID: 34140
		[Token(Token = "0x4019AAE")]
		ShopTalk__VarietyShop_Terry_9,
		// Token: 0x0400855D RID: 34141
		[Token(Token = "0x4019AAF")]
		ShopTalk__VarietyShop_Misasagi_0,
		// Token: 0x0400855E RID: 34142
		[Token(Token = "0x4019AB0")]
		ShopTalk__VarietyShop_Misasagi_1,
		// Token: 0x0400855F RID: 34143
		[Token(Token = "0x4019AB1")]
		ShopTalk__VarietyShop_Misasagi_2,
		// Token: 0x04008560 RID: 34144
		[Token(Token = "0x4019AB2")]
		ShopTalk__VarietyShop_Misasagi_3,
		// Token: 0x04008561 RID: 34145
		[Token(Token = "0x4019AB3")]
		ShopTalk__VarietyShop_Misasagi_4,
		// Token: 0x04008562 RID: 34146
		[Token(Token = "0x4019AB4")]
		ShopTalk__VarietyShop_Misasagi_5,
		// Token: 0x04008563 RID: 34147
		[Token(Token = "0x4019AB5")]
		ShopTalk__VarietyShop_Misasagi_6,
		// Token: 0x04008564 RID: 34148
		[Token(Token = "0x4019AB6")]
		ShopTalk__VarietyShop_Misasagi_7,
		// Token: 0x04008565 RID: 34149
		[Token(Token = "0x4019AB7")]
		ShopTalk__VarietyShop_Misasagi_8,
		// Token: 0x04008566 RID: 34150
		[Token(Token = "0x4019AB8")]
		ShopTalk__VarietyShop_Misasagi_9,
		// Token: 0x04008567 RID: 34151
		[Token(Token = "0x4019AB9")]
		ShopTalk__VarietyShop_Hina_0,
		// Token: 0x04008568 RID: 34152
		[Token(Token = "0x4019ABA")]
		ShopTalk__VarietyShop_Hina_1,
		// Token: 0x04008569 RID: 34153
		[Token(Token = "0x4019ABB")]
		ShopTalk__VarietyShop_Hina_2,
		// Token: 0x0400856A RID: 34154
		[Token(Token = "0x4019ABC")]
		ShopTalk__VarietyShop_Hina_3,
		// Token: 0x0400856B RID: 34155
		[Token(Token = "0x4019ABD")]
		ShopTalk__VarietyShop_Hina_4,
		// Token: 0x0400856C RID: 34156
		[Token(Token = "0x4019ABE")]
		ShopTalk__VarietyShop_Hina_5,
		// Token: 0x0400856D RID: 34157
		[Token(Token = "0x4019ABF")]
		ShopTalk__VarietyShop_Hina_6,
		// Token: 0x0400856E RID: 34158
		[Token(Token = "0x4019AC0")]
		ShopTalk__VarietyShop_Hina_7,
		// Token: 0x0400856F RID: 34159
		[Token(Token = "0x4019AC1")]
		ShopTalk__VarietyShop_Hina_8,
		// Token: 0x04008570 RID: 34160
		[Token(Token = "0x4019AC2")]
		ShopTalk__VarietyShop_Hina_9,
		// Token: 0x04008571 RID: 34161
		[Token(Token = "0x4019AC3")]
		ShopTalk__VarietyShop_Priscilla_0,
		// Token: 0x04008572 RID: 34162
		[Token(Token = "0x4019AC4")]
		ShopTalk__VarietyShop_Priscilla_1,
		// Token: 0x04008573 RID: 34163
		[Token(Token = "0x4019AC5")]
		ShopTalk__VarietyShop_Priscilla_2,
		// Token: 0x04008574 RID: 34164
		[Token(Token = "0x4019AC6")]
		ShopTalk__VarietyShop_Priscilla_3,
		// Token: 0x04008575 RID: 34165
		[Token(Token = "0x4019AC7")]
		ShopTalk__VarietyShop_Priscilla_4,
		// Token: 0x04008576 RID: 34166
		[Token(Token = "0x4019AC8")]
		ShopTalk__VarietyShop_Priscilla_5,
		// Token: 0x04008577 RID: 34167
		[Token(Token = "0x4019AC9")]
		ShopTalk__VarietyShop_Priscilla_6,
		// Token: 0x04008578 RID: 34168
		[Token(Token = "0x4019ACA")]
		ShopTalk__VarietyShop_Priscilla_7,
		// Token: 0x04008579 RID: 34169
		[Token(Token = "0x4019ACB")]
		ShopTalk__VarietyShop_Priscilla_8,
		// Token: 0x0400857A RID: 34170
		[Token(Token = "0x4019ACC")]
		ShopTalk__VarietyShop_Priscilla_9,
		// Token: 0x0400857B RID: 34171
		[Token(Token = "0x4019ACD")]
		ShopTalk__VarietyShop_Lucy_0,
		// Token: 0x0400857C RID: 34172
		[Token(Token = "0x4019ACE")]
		ShopTalk__VarietyShop_Lucy_1,
		// Token: 0x0400857D RID: 34173
		[Token(Token = "0x4019ACF")]
		ShopTalk__VarietyShop_Lucy_2,
		// Token: 0x0400857E RID: 34174
		[Token(Token = "0x4019AD0")]
		ShopTalk__VarietyShop_Lucy_3,
		// Token: 0x0400857F RID: 34175
		[Token(Token = "0x4019AD1")]
		ShopTalk__VarietyShop_Lucy_4,
		// Token: 0x04008580 RID: 34176
		[Token(Token = "0x4019AD2")]
		ShopTalk__VarietyShop_Lucy_5,
		// Token: 0x04008581 RID: 34177
		[Token(Token = "0x4019AD3")]
		ShopTalk__VarietyShop_Lucy_6,
		// Token: 0x04008582 RID: 34178
		[Token(Token = "0x4019AD4")]
		ShopTalk__VarietyShop_Lucy_7,
		// Token: 0x04008583 RID: 34179
		[Token(Token = "0x4019AD5")]
		ShopTalk__VarietyShop_Lucy_8,
		// Token: 0x04008584 RID: 34180
		[Token(Token = "0x4019AD6")]
		ShopTalk__VarietyShop_Lucy_9,
		// Token: 0x04008585 RID: 34181
		[Token(Token = "0x4019AD7")]
		ShopTalk__BlacksmithShop_Doug_0,
		// Token: 0x04008586 RID: 34182
		[Token(Token = "0x4019AD8")]
		ShopTalk__BlacksmithShop_Doug_1,
		// Token: 0x04008587 RID: 34183
		[Token(Token = "0x4019AD9")]
		ShopTalk__BlacksmithShop_Doug_2,
		// Token: 0x04008588 RID: 34184
		[Token(Token = "0x4019ADA")]
		ShopTalk__BlacksmithShop_Doug_3,
		// Token: 0x04008589 RID: 34185
		[Token(Token = "0x4019ADB")]
		ShopTalk__BlacksmithShop_Doug_4,
		// Token: 0x0400858A RID: 34186
		[Token(Token = "0x4019ADC")]
		ShopTalk__BlacksmithShop_Doug_5,
		// Token: 0x0400858B RID: 34187
		[Token(Token = "0x4019ADD")]
		ShopTalk__BlacksmithShop_Doug_6,
		// Token: 0x0400858C RID: 34188
		[Token(Token = "0x4019ADE")]
		ShopTalk__BlacksmithShop_Doug_7,
		// Token: 0x0400858D RID: 34189
		[Token(Token = "0x4019ADF")]
		ShopTalk__BlacksmithShop_Doug_8,
		// Token: 0x0400858E RID: 34190
		[Token(Token = "0x4019AE0")]
		ShopTalk__BlacksmithShop_Doug_9,
		// Token: 0x0400858F RID: 34191
		[Token(Token = "0x4019AE1")]
		ShopTalk__BlacksmithShop_Martin_0,
		// Token: 0x04008590 RID: 34192
		[Token(Token = "0x4019AE2")]
		ShopTalk__BlacksmithShop_Martin_1,
		// Token: 0x04008591 RID: 34193
		[Token(Token = "0x4019AE3")]
		ShopTalk__BlacksmithShop_Martin_2,
		// Token: 0x04008592 RID: 34194
		[Token(Token = "0x4019AE4")]
		ShopTalk__BlacksmithShop_Martin_3,
		// Token: 0x04008593 RID: 34195
		[Token(Token = "0x4019AE5")]
		ShopTalk__BlacksmithShop_Martin_4,
		// Token: 0x04008594 RID: 34196
		[Token(Token = "0x4019AE6")]
		ShopTalk__BlacksmithShop_Martin_5,
		// Token: 0x04008595 RID: 34197
		[Token(Token = "0x4019AE7")]
		ShopTalk__BlacksmithShop_Martin_6,
		// Token: 0x04008596 RID: 34198
		[Token(Token = "0x4019AE8")]
		ShopTalk__BlacksmithShop_Martin_7,
		// Token: 0x04008597 RID: 34199
		[Token(Token = "0x4019AE9")]
		ShopTalk__BlacksmithShop_Martin_8,
		// Token: 0x04008598 RID: 34200
		[Token(Token = "0x4019AEA")]
		ShopTalk__BlacksmithShop_Martin_9,
		// Token: 0x04008599 RID: 34201
		[Token(Token = "0x4019AEB")]
		ShopTalk__Restaurent_Fuqua_0,
		// Token: 0x0400859A RID: 34202
		[Token(Token = "0x4019AEC")]
		ShopTalk__Restaurent_Fuqua_1,
		// Token: 0x0400859B RID: 34203
		[Token(Token = "0x4019AED")]
		ShopTalk__Restaurent_Fuqua_2,
		// Token: 0x0400859C RID: 34204
		[Token(Token = "0x4019AEE")]
		ShopTalk__Restaurent_Fuqua_3,
		// Token: 0x0400859D RID: 34205
		[Token(Token = "0x4019AEF")]
		ShopTalk__Restaurent_Fuqua_4,
		// Token: 0x0400859E RID: 34206
		[Token(Token = "0x4019AF0")]
		ShopTalk__Restaurent_Fuqua_5,
		// Token: 0x0400859F RID: 34207
		[Token(Token = "0x4019AF1")]
		ShopTalk__Restaurent_Fuqua_6,
		// Token: 0x040085A0 RID: 34208
		[Token(Token = "0x4019AF2")]
		ShopTalk__Restaurent_Fuqua_7,
		// Token: 0x040085A1 RID: 34209
		[Token(Token = "0x4019AF3")]
		ShopTalk__Restaurent_Fuqua_8,
		// Token: 0x040085A2 RID: 34210
		[Token(Token = "0x4019AF4")]
		ShopTalk__Restaurent_Fuqua_9,
		// Token: 0x040085A3 RID: 34211
		[Token(Token = "0x4019AF5")]
		ShopTalk__Restaurent_Elsje_0,
		// Token: 0x040085A4 RID: 34212
		[Token(Token = "0x4019AF6")]
		ShopTalk__Restaurent_Elsje_1,
		// Token: 0x040085A5 RID: 34213
		[Token(Token = "0x4019AF7")]
		ShopTalk__Restaurent_Elsje_2,
		// Token: 0x040085A6 RID: 34214
		[Token(Token = "0x4019AF8")]
		ShopTalk__Restaurent_Elsje_3,
		// Token: 0x040085A7 RID: 34215
		[Token(Token = "0x4019AF9")]
		ShopTalk__Restaurent_Elsje_4,
		// Token: 0x040085A8 RID: 34216
		[Token(Token = "0x4019AFA")]
		ShopTalk__Restaurent_Elsje_5,
		// Token: 0x040085A9 RID: 34217
		[Token(Token = "0x4019AFB")]
		ShopTalk__Restaurent_Elsje_6,
		// Token: 0x040085AA RID: 34218
		[Token(Token = "0x4019AFC")]
		ShopTalk__Restaurent_Elsje_7,
		// Token: 0x040085AB RID: 34219
		[Token(Token = "0x4019AFD")]
		ShopTalk__Restaurent_Elsje_8,
		// Token: 0x040085AC RID: 34220
		[Token(Token = "0x4019AFE")]
		ShopTalk__Restaurent_Elsje_9,
		// Token: 0x040085AD RID: 34221
		[Token(Token = "0x4019AFF")]
		ShopTalk__Builder_Palmo_0,
		// Token: 0x040085AE RID: 34222
		[Token(Token = "0x4019B00")]
		ShopTalk__Builder_Palmo_1,
		// Token: 0x040085AF RID: 34223
		[Token(Token = "0x4019B01")]
		ShopTalk__Builder_Palmo_2,
		// Token: 0x040085B0 RID: 34224
		[Token(Token = "0x4019B02")]
		ShopTalk__Builder_Palmo_3,
		// Token: 0x040085B1 RID: 34225
		[Token(Token = "0x4019B03")]
		ShopTalk__Builder_Palmo_4,
		// Token: 0x040085B2 RID: 34226
		[Token(Token = "0x4019B04")]
		ShopTalk__Builder_Palmo_5,
		// Token: 0x040085B3 RID: 34227
		[Token(Token = "0x4019B05")]
		ShopTalk__Builder_Palmo_6,
		// Token: 0x040085B4 RID: 34228
		[Token(Token = "0x4019B06")]
		ShopTalk__Builder_Palmo_7,
		// Token: 0x040085B5 RID: 34229
		[Token(Token = "0x4019B07")]
		ShopTalk__Builder_Palmo_8,
		// Token: 0x040085B6 RID: 34230
		[Token(Token = "0x4019B08")]
		ShopTalk__Builder_Palmo_9,
		// Token: 0x040085B7 RID: 34231
		[Token(Token = "0x4019B09")]
		ShopTalk__Builder_PalmoEID_01,
		// Token: 0x040085B8 RID: 34232
		[Token(Token = "0x4019B0A")]
		ShopTalk__Builder_PalmoEID_02,
		// Token: 0x040085B9 RID: 34233
		[Token(Token = "0x4019B0B")]
		ShopTalk__Builder_PalmoEID_03,
		// Token: 0x040085BA RID: 34234
		[Token(Token = "0x4019B0C")]
		ShopTalk__Builder_PalmoEID_04,
		// Token: 0x040085BB RID: 34235
		[Token(Token = "0x4019B0D")]
		ShopTalk__Builder_PalmoEID_05,
		// Token: 0x040085BC RID: 34236
		[Token(Token = "0x4019B0E")]
		ShopTalk__Builder_Lyka_0,
		// Token: 0x040085BD RID: 34237
		[Token(Token = "0x4019B0F")]
		ShopTalk__Builder_Lyka_1,
		// Token: 0x040085BE RID: 34238
		[Token(Token = "0x4019B10")]
		ShopTalk__Builder_Lyka_2,
		// Token: 0x040085BF RID: 34239
		[Token(Token = "0x4019B11")]
		ShopTalk__Builder_Lyka_3,
		// Token: 0x040085C0 RID: 34240
		[Token(Token = "0x4019B12")]
		ShopTalk__Builder_Lyka_4,
		// Token: 0x040085C1 RID: 34241
		[Token(Token = "0x4019B13")]
		ShopTalk__Builder_Lyka_5,
		// Token: 0x040085C2 RID: 34242
		[Token(Token = "0x4019B14")]
		ShopTalk__Builder_Lyka_6,
		// Token: 0x040085C3 RID: 34243
		[Token(Token = "0x4019B15")]
		ShopTalk__Builder_Lyka_7,
		// Token: 0x040085C4 RID: 34244
		[Token(Token = "0x4019B16")]
		ShopTalk__Builder_Lyka_8,
		// Token: 0x040085C5 RID: 34245
		[Token(Token = "0x4019B17")]
		ShopTalk__Builder_Lyka_9,
		// Token: 0x040085C6 RID: 34246
		[Token(Token = "0x4019B18")]
		ShopTalk__Builder_LyucaEID_01,
		// Token: 0x040085C7 RID: 34247
		[Token(Token = "0x4019B19")]
		ShopTalk__Builder_LyucaEID_02,
		// Token: 0x040085C8 RID: 34248
		[Token(Token = "0x4019B1A")]
		ShopTalk__Builder_LyucaEID_03,
		// Token: 0x040085C9 RID: 34249
		[Token(Token = "0x4019B1B")]
		ShopTalk__Builder_LyucaEID_04,
		// Token: 0x040085CA RID: 34250
		[Token(Token = "0x4019B1C")]
		ShopTalk__Builder_LyucaEID_05,
		// Token: 0x040085CB RID: 34251
		[Token(Token = "0x4019B1D")]
		ShopTalk__CrystalShop_Heinz_0,
		// Token: 0x040085CC RID: 34252
		[Token(Token = "0x4019B1E")]
		ShopTalk__CrystalShop_Heinz_1,
		// Token: 0x040085CD RID: 34253
		[Token(Token = "0x4019B1F")]
		ShopTalk__CrystalShop_Heinz_2,
		// Token: 0x040085CE RID: 34254
		[Token(Token = "0x4019B20")]
		ShopTalk__CrystalShop_Heinz_3,
		// Token: 0x040085CF RID: 34255
		[Token(Token = "0x4019B21")]
		ShopTalk__CrystalShop_Heinz_4,
		// Token: 0x040085D0 RID: 34256
		[Token(Token = "0x4019B22")]
		ShopTalk__CrystalShop_Heinz_5,
		// Token: 0x040085D1 RID: 34257
		[Token(Token = "0x4019B23")]
		ShopTalk__CrystalShop_Heinz_6,
		// Token: 0x040085D2 RID: 34258
		[Token(Token = "0x4019B24")]
		ShopTalk__CrystalShop_Heinz_7,
		// Token: 0x040085D3 RID: 34259
		[Token(Token = "0x4019B25")]
		ShopTalk__CrystalShop_Heinz_8,
		// Token: 0x040085D4 RID: 34260
		[Token(Token = "0x4019B26")]
		ShopTalk__CrystalShop_Heinz_9,
		// Token: 0x040085D5 RID: 34261
		[Token(Token = "0x4019B27")]
		ShopTalk__CrystalShop_Lucas_0,
		// Token: 0x040085D6 RID: 34262
		[Token(Token = "0x4019B28")]
		ShopTalk__CrystalShop_Lucas_1,
		// Token: 0x040085D7 RID: 34263
		[Token(Token = "0x4019B29")]
		ShopTalk__CrystalShop_Lucas_2,
		// Token: 0x040085D8 RID: 34264
		[Token(Token = "0x4019B2A")]
		ShopTalk__CrystalShop_Lucas_3,
		// Token: 0x040085D9 RID: 34265
		[Token(Token = "0x4019B2B")]
		ShopTalk__CrystalShop_Lucas_4,
		// Token: 0x040085DA RID: 34266
		[Token(Token = "0x4019B2C")]
		ShopTalk__CrystalShop_Lucas_5,
		// Token: 0x040085DB RID: 34267
		[Token(Token = "0x4019B2D")]
		ShopTalk__CrystalShop_Lucas_6,
		// Token: 0x040085DC RID: 34268
		[Token(Token = "0x4019B2E")]
		ShopTalk__CrystalShop_Lucas_7,
		// Token: 0x040085DD RID: 34269
		[Token(Token = "0x4019B2F")]
		ShopTalk__CrystalShop_Lucas_8,
		// Token: 0x040085DE RID: 34270
		[Token(Token = "0x4019B30")]
		ShopTalk__CrystalShop_Lucas_9,
		// Token: 0x040085DF RID: 34271
		[Token(Token = "0x4019B31")]
		ShopTalk__Hospital_Simone_0,
		// Token: 0x040085E0 RID: 34272
		[Token(Token = "0x4019B32")]
		ShopTalk__Hospital_Simone_1,
		// Token: 0x040085E1 RID: 34273
		[Token(Token = "0x4019B33")]
		ShopTalk__Hospital_Simone_2,
		// Token: 0x040085E2 RID: 34274
		[Token(Token = "0x4019B34")]
		ShopTalk__Hospital_Simone_3,
		// Token: 0x040085E3 RID: 34275
		[Token(Token = "0x4019B35")]
		ShopTalk__Hospital_Simone_4,
		// Token: 0x040085E4 RID: 34276
		[Token(Token = "0x4019B36")]
		ShopTalk__Hospital_Simone_5,
		// Token: 0x040085E5 RID: 34277
		[Token(Token = "0x4019B37")]
		ShopTalk__Hospital_Simone_6,
		// Token: 0x040085E6 RID: 34278
		[Token(Token = "0x4019B38")]
		ShopTalk__Hospital_Simone_7,
		// Token: 0x040085E7 RID: 34279
		[Token(Token = "0x4019B39")]
		ShopTalk__Hospital_Simone_8,
		// Token: 0x040085E8 RID: 34280
		[Token(Token = "0x4019B3A")]
		ShopTalk__Hospital_Simone_9,
		// Token: 0x040085E9 RID: 34281
		[Token(Token = "0x4019B3B")]
		ShopTalk__Hospital_Lucy_0,
		// Token: 0x040085EA RID: 34282
		[Token(Token = "0x4019B3C")]
		ShopTalk__Hospital_Lucy_1,
		// Token: 0x040085EB RID: 34283
		[Token(Token = "0x4019B3D")]
		ShopTalk__Hospital_Lucy_2,
		// Token: 0x040085EC RID: 34284
		[Token(Token = "0x4019B3E")]
		ShopTalk__Hospital_Lucy_3,
		// Token: 0x040085ED RID: 34285
		[Token(Token = "0x4019B3F")]
		ShopTalk__Hospital_Lucy_4,
		// Token: 0x040085EE RID: 34286
		[Token(Token = "0x4019B40")]
		ShopTalk__Hospital_Lucy_5,
		// Token: 0x040085EF RID: 34287
		[Token(Token = "0x4019B41")]
		ShopTalk__Hospital_Lucy_6,
		// Token: 0x040085F0 RID: 34288
		[Token(Token = "0x4019B42")]
		ShopTalk__Hospital_Lucy_7,
		// Token: 0x040085F1 RID: 34289
		[Token(Token = "0x4019B43")]
		ShopTalk__Hospital_Lucy_8,
		// Token: 0x040085F2 RID: 34290
		[Token(Token = "0x4019B44")]
		ShopTalk__Hospital_Lucy_9,
		// Token: 0x040085F3 RID: 34291
		[Token(Token = "0x4019B45")]
		ShopTalk__Hospital_Julien_0,
		// Token: 0x040085F4 RID: 34292
		[Token(Token = "0x4019B46")]
		ShopTalk__Hospital_Julien_1,
		// Token: 0x040085F5 RID: 34293
		[Token(Token = "0x4019B47")]
		ShopTalk__Hospital_Julien_2,
		// Token: 0x040085F6 RID: 34294
		[Token(Token = "0x4019B48")]
		ShopTalk__Hospital_Julien_3,
		// Token: 0x040085F7 RID: 34295
		[Token(Token = "0x4019B49")]
		ShopTalk__Hospital_Julien_4,
		// Token: 0x040085F8 RID: 34296
		[Token(Token = "0x4019B4A")]
		ShopTalk__Hospital_Julien_5,
		// Token: 0x040085F9 RID: 34297
		[Token(Token = "0x4019B4B")]
		ShopTalk__Hospital_Julien_6,
		// Token: 0x040085FA RID: 34298
		[Token(Token = "0x4019B4C")]
		ShopTalk__Hospital_Julien_7,
		// Token: 0x040085FB RID: 34299
		[Token(Token = "0x4019B4D")]
		ShopTalk__Hospital_Julien_8,
		// Token: 0x040085FC RID: 34300
		[Token(Token = "0x4019B4E")]
		ShopTalk__Hospital_Julien_9,
		// Token: 0x040085FD RID: 34301
		[Token(Token = "0x4019B4F")]
		ShopTalk__FlowerShop_Ludmila_0,
		// Token: 0x040085FE RID: 34302
		[Token(Token = "0x4019B50")]
		ShopTalk__FlowerShop_Ludmila_1,
		// Token: 0x040085FF RID: 34303
		[Token(Token = "0x4019B51")]
		ShopTalk__FlowerShop_Ludmila_2,
		// Token: 0x04008600 RID: 34304
		[Token(Token = "0x4019B52")]
		ShopTalk__FlowerShop_Ludmila_3,
		// Token: 0x04008601 RID: 34305
		[Token(Token = "0x4019B53")]
		ShopTalk__FlowerShop_Ludmila_4,
		// Token: 0x04008602 RID: 34306
		[Token(Token = "0x4019B54")]
		ShopTalk__FlowerShop_Ludmila_5,
		// Token: 0x04008603 RID: 34307
		[Token(Token = "0x4019B55")]
		ShopTalk__FlowerShop_Ludmila_6,
		// Token: 0x04008604 RID: 34308
		[Token(Token = "0x4019B56")]
		ShopTalk__FlowerShop_Ludmila_7,
		// Token: 0x04008605 RID: 34309
		[Token(Token = "0x4019B57")]
		ShopTalk__FlowerShop_Ludmila_8,
		// Token: 0x04008606 RID: 34310
		[Token(Token = "0x4019B58")]
		ShopTalk__FlowerShop_Ludmila_9,
		// Token: 0x04008607 RID: 34311
		[Token(Token = "0x4019B59")]
		SHOP_FURNITURE_NAME_01,
		// Token: 0x04008608 RID: 34312
		[Token(Token = "0x4019B5A")]
		SHOP_FURNITURE_NAME_02,
		// Token: 0x04008609 RID: 34313
		[Token(Token = "0x4019B5B")]
		SHOP_FURNITURE_NAME_03,
		// Token: 0x0400860A RID: 34314
		[Token(Token = "0x4019B5C")]
		SHOP_FURNITURE_NAME_04,
		// Token: 0x0400860B RID: 34315
		[Token(Token = "0x4019B5D")]
		SHOP_FURNITURE_NAME_05,
		// Token: 0x0400860C RID: 34316
		[Token(Token = "0x4019B5E")]
		SHOP_FURNITURE_NAME_06,
		// Token: 0x0400860D RID: 34317
		[Token(Token = "0x4019B5F")]
		SHOP_FURNITURE_NAME_07,
		// Token: 0x0400860E RID: 34318
		[Token(Token = "0x4019B60")]
		SHOP_FURNITURE_NAME_08,
		// Token: 0x0400860F RID: 34319
		[Token(Token = "0x4019B61")]
		SHOP_FURNITURE_NAME_09,
		// Token: 0x04008610 RID: 34320
		[Token(Token = "0x4019B62")]
		SHOP_FURNITURE_NAME_10,
		// Token: 0x04008611 RID: 34321
		[Token(Token = "0x4019B63")]
		SHOP_FURNITURE_NAME_11,
		// Token: 0x04008612 RID: 34322
		[Token(Token = "0x4019B64")]
		SHOP_FURNITURE_NAME_12,
		// Token: 0x04008613 RID: 34323
		[Token(Token = "0x4019B65")]
		SHOP_FURNITURE_NAME_13,
		// Token: 0x04008614 RID: 34324
		[Token(Token = "0x4019B66")]
		SHOP_FURNITURE_NAME_14,
		// Token: 0x04008615 RID: 34325
		[Token(Token = "0x4019B67")]
		SHOP_FURNITURE_NAME_15,
		// Token: 0x04008616 RID: 34326
		[Token(Token = "0x4019B68")]
		SHOP_FURNITURE_NAME_16,
		// Token: 0x04008617 RID: 34327
		[Token(Token = "0x4019B69")]
		SHOP_FURNITURE_NAME_17,
		// Token: 0x04008618 RID: 34328
		[Token(Token = "0x4019B6A")]
		SHOP_FURNITURE_NAME_18,
		// Token: 0x04008619 RID: 34329
		[Token(Token = "0x4019B6B")]
		SHOP_FURNITURE_NAME_19,
		// Token: 0x0400861A RID: 34330
		[Token(Token = "0x4019B6C")]
		SHOP_FURNITURE_NAME_20,
		// Token: 0x0400861B RID: 34331
		[Token(Token = "0x4019B6D")]
		SHOP_FURNITURE_NAME_21,
		// Token: 0x0400861C RID: 34332
		[Token(Token = "0x4019B6E")]
		SHOP_FURNITURE_NAME_22,
		// Token: 0x0400861D RID: 34333
		[Token(Token = "0x4019B6F")]
		SHOP_FURNITURE_NAME_23,
		// Token: 0x0400861E RID: 34334
		[Token(Token = "0x4019B70")]
		SHOP_FURNITURE_NAME_24,
		// Token: 0x0400861F RID: 34335
		[Token(Token = "0x4019B71")]
		SHOP_FURNITURE_NAME_25,
		// Token: 0x04008620 RID: 34336
		[Token(Token = "0x4019B72")]
		SHOP_FURNITURE_NAME_26,
		// Token: 0x04008621 RID: 34337
		[Token(Token = "0x4019B73")]
		SHOP_FURNITURE_NAME_27,
		// Token: 0x04008622 RID: 34338
		[Token(Token = "0x4019B74")]
		SHOP_FURNITURE_NAME_28,
		// Token: 0x04008623 RID: 34339
		[Token(Token = "0x4019B75")]
		SHOP_FURNITURE_NAME_29,
		// Token: 0x04008624 RID: 34340
		[Token(Token = "0x4019B76")]
		SHOP_FURNITURE_NAME_30,
		// Token: 0x04008625 RID: 34341
		[Token(Token = "0x4019B77")]
		SHOP_FURNITURE_NAME_31,
		// Token: 0x04008626 RID: 34342
		[Token(Token = "0x4019B78")]
		SHOP_FURNITURE_NAME_32,
		// Token: 0x04008627 RID: 34343
		[Token(Token = "0x4019B79")]
		SHOP_FURNITURE_NAME_33,
		// Token: 0x04008628 RID: 34344
		[Token(Token = "0x4019B7A")]
		SHOP_FURNITURE_NAME_34,
		// Token: 0x04008629 RID: 34345
		[Token(Token = "0x4019B7B")]
		SHOP_FURNITURE_NAME_35,
		// Token: 0x0400862A RID: 34346
		[Token(Token = "0x4019B7C")]
		SHOP_FURNITURE_NAME_36,
		// Token: 0x0400862B RID: 34347
		[Token(Token = "0x4019B7D")]
		SHOP_FURNITURE_NAME_37,
		// Token: 0x0400862C RID: 34348
		[Token(Token = "0x4019B7E")]
		SHOP_FURNITURE_NAME_38,
		// Token: 0x0400862D RID: 34349
		[Token(Token = "0x4019B7F")]
		SHOP_FURNITURE_NAME_39,
		// Token: 0x0400862E RID: 34350
		[Token(Token = "0x4019B80")]
		SHOP_FURNITURE_NAME_40,
		// Token: 0x0400862F RID: 34351
		[Token(Token = "0x4019B81")]
		SHOP_FURNITURE_NAME_41,
		// Token: 0x04008630 RID: 34352
		[Token(Token = "0x4019B82")]
		SHOP_FURNITURE_NAME_42,
		// Token: 0x04008631 RID: 34353
		[Token(Token = "0x4019B83")]
		SHOP_FURNITURE_NAME_43,
		// Token: 0x04008632 RID: 34354
		[Token(Token = "0x4019B84")]
		SHOP_FURNITURE_NAME_44,
		// Token: 0x04008633 RID: 34355
		[Token(Token = "0x4019B85")]
		SHOP_FURNITURE_NAME_45,
		// Token: 0x04008634 RID: 34356
		[Token(Token = "0x4019B86")]
		SHOP_FURNITURE_NAME_46,
		// Token: 0x04008635 RID: 34357
		[Token(Token = "0x4019B87")]
		SHOP_FURNITURE_NAME_47,
		// Token: 0x04008636 RID: 34358
		[Token(Token = "0x4019B88")]
		SHOP_FURNITURE_NAME_48,
		// Token: 0x04008637 RID: 34359
		[Token(Token = "0x4019B89")]
		SHOP_FURNITURE_NAME_49,
		// Token: 0x04008638 RID: 34360
		[Token(Token = "0x4019B8A")]
		SHOP_FURNITURE_NAME_50,
		// Token: 0x04008639 RID: 34361
		[Token(Token = "0x4019B8B")]
		SHOP_FURNITURE_NAME_51,
		// Token: 0x0400863A RID: 34362
		[Token(Token = "0x4019B8C")]
		SHOP_FURNITURE_NAME_52,
		// Token: 0x0400863B RID: 34363
		[Token(Token = "0x4019B8D")]
		SHOP_FURNITURE_NAME_53,
		// Token: 0x0400863C RID: 34364
		[Token(Token = "0x4019B8E")]
		SHOP_FURNITURE_NAME_54,
		// Token: 0x0400863D RID: 34365
		[Token(Token = "0x4019B8F")]
		SHOP_FURNITURE_NAME_55,
		// Token: 0x0400863E RID: 34366
		[Token(Token = "0x4019B90")]
		SHOP_FURNITURE_NAME_56,
		// Token: 0x0400863F RID: 34367
		[Token(Token = "0x4019B91")]
		SHOP_FURNITURE_NAME_57,
		// Token: 0x04008640 RID: 34368
		[Token(Token = "0x4019B92")]
		SHOP_FURNITURE_NAME_58,
		// Token: 0x04008641 RID: 34369
		[Token(Token = "0x4019B93")]
		SHOP_FURNITURE_NAME_59,
		// Token: 0x04008642 RID: 34370
		[Token(Token = "0x4019B94")]
		SHOP_FURNITURE_NAME_60,
		// Token: 0x04008643 RID: 34371
		[Token(Token = "0x4019B95")]
		SHOP_FURNITURE_NAME_61,
		// Token: 0x04008644 RID: 34372
		[Token(Token = "0x4019B96")]
		SHOP_FURNITURE_NAME_62,
		// Token: 0x04008645 RID: 34373
		[Token(Token = "0x4019B97")]
		SHOP_FURNITURE_NAME_63,
		// Token: 0x04008646 RID: 34374
		[Token(Token = "0x4019B98")]
		SHOP_FURNITURE_NAME_64,
		// Token: 0x04008647 RID: 34375
		[Token(Token = "0x4019B99")]
		SHOP_FURNITURE_NAME_65,
		// Token: 0x04008648 RID: 34376
		[Token(Token = "0x4019B9A")]
		SHOP_FURNITURE_NAME_66,
		// Token: 0x04008649 RID: 34377
		[Token(Token = "0x4019B9B")]
		SHOP_FURNITURE_NAME_67,
		// Token: 0x0400864A RID: 34378
		[Token(Token = "0x4019B9C")]
		SHOP_FURNITURE_NAME_68,
		// Token: 0x0400864B RID: 34379
		[Token(Token = "0x4019B9D")]
		SHOP_FURNITURE_NAME_69,
		// Token: 0x0400864C RID: 34380
		[Token(Token = "0x4019B9E")]
		SHOP_FURNITURE_NAME_70,
		// Token: 0x0400864D RID: 34381
		[Token(Token = "0x4019B9F")]
		SHOP_FURNITURE_NAME_71,
		// Token: 0x0400864E RID: 34382
		[Token(Token = "0x4019BA0")]
		SHOP_FURNITURE_NAME_72,
		// Token: 0x0400864F RID: 34383
		[Token(Token = "0x4019BA1")]
		SHOP_FURNITURE_NAME_73,
		// Token: 0x04008650 RID: 34384
		[Token(Token = "0x4019BA2")]
		SHOP_FURNITURE_NAME_74,
		// Token: 0x04008651 RID: 34385
		[Token(Token = "0x4019BA3")]
		SHOP_FURNITURE_NAME_75,
		// Token: 0x04008652 RID: 34386
		[Token(Token = "0x4019BA4")]
		SHOP_FURNITURE_NAME_76,
		// Token: 0x04008653 RID: 34387
		[Token(Token = "0x4019BA5")]
		SHOP_FURNITURE_NAME_77,
		// Token: 0x04008654 RID: 34388
		[Token(Token = "0x4019BA6")]
		SHOP_FURNITURE_DETAIL_01,
		// Token: 0x04008655 RID: 34389
		[Token(Token = "0x4019BA7")]
		SHOP_FURNITURE_DETAIL_02,
		// Token: 0x04008656 RID: 34390
		[Token(Token = "0x4019BA8")]
		SHOP_FURNITURE_DETAIL_03,
		// Token: 0x04008657 RID: 34391
		[Token(Token = "0x4019BA9")]
		SHOP_FURNITURE_DETAIL_04,
		// Token: 0x04008658 RID: 34392
		[Token(Token = "0x4019BAA")]
		SHOP_FURNITURE_DETAIL_05,
		// Token: 0x04008659 RID: 34393
		[Token(Token = "0x4019BAB")]
		SHOP_FURNITURE_DETAIL_06,
		// Token: 0x0400865A RID: 34394
		[Token(Token = "0x4019BAC")]
		SHOP_FURNITURE_DETAIL_07,
		// Token: 0x0400865B RID: 34395
		[Token(Token = "0x4019BAD")]
		SHOP_FURNITURE_DETAIL_08,
		// Token: 0x0400865C RID: 34396
		[Token(Token = "0x4019BAE")]
		SHOP_FURNITURE_DETAIL_09,
		// Token: 0x0400865D RID: 34397
		[Token(Token = "0x4019BAF")]
		SHOP_FURNITURE_DETAIL_10,
		// Token: 0x0400865E RID: 34398
		[Token(Token = "0x4019BB0")]
		SHOP_FURNITURE_DETAIL_11,
		// Token: 0x0400865F RID: 34399
		[Token(Token = "0x4019BB1")]
		SHOP_FURNITURE_DETAIL_12,
		// Token: 0x04008660 RID: 34400
		[Token(Token = "0x4019BB2")]
		SHOP_FURNITURE_DETAIL_13,
		// Token: 0x04008661 RID: 34401
		[Token(Token = "0x4019BB3")]
		SHOP_FURNITURE_DETAIL_14,
		// Token: 0x04008662 RID: 34402
		[Token(Token = "0x4019BB4")]
		SHOP_FURNITURE_DETAIL_15,
		// Token: 0x04008663 RID: 34403
		[Token(Token = "0x4019BB5")]
		SHOP_FURNITURE_DETAIL_16,
		// Token: 0x04008664 RID: 34404
		[Token(Token = "0x4019BB6")]
		SHOP_FURNITURE_DETAIL_17,
		// Token: 0x04008665 RID: 34405
		[Token(Token = "0x4019BB7")]
		SHOP_FURNITURE_DETAIL_18,
		// Token: 0x04008666 RID: 34406
		[Token(Token = "0x4019BB8")]
		SHOP_FURNITURE_DETAIL_19,
		// Token: 0x04008667 RID: 34407
		[Token(Token = "0x4019BB9")]
		SHOP_FURNITURE_DETAIL_20,
		// Token: 0x04008668 RID: 34408
		[Token(Token = "0x4019BBA")]
		SHOP_FURNITURE_DETAIL_21,
		// Token: 0x04008669 RID: 34409
		[Token(Token = "0x4019BBB")]
		SHOP_FURNITURE_DETAIL_22,
		// Token: 0x0400866A RID: 34410
		[Token(Token = "0x4019BBC")]
		SHOP_FURNITURE_DETAIL_23,
		// Token: 0x0400866B RID: 34411
		[Token(Token = "0x4019BBD")]
		SHOP_FURNITURE_DETAIL_24,
		// Token: 0x0400866C RID: 34412
		[Token(Token = "0x4019BBE")]
		SHOP_FURNITURE_DETAIL_25,
		// Token: 0x0400866D RID: 34413
		[Token(Token = "0x4019BBF")]
		SHOP_FURNITURE_DETAIL_26,
		// Token: 0x0400866E RID: 34414
		[Token(Token = "0x4019BC0")]
		SHOP_FURNITURE_DETAIL_27,
		// Token: 0x0400866F RID: 34415
		[Token(Token = "0x4019BC1")]
		SHOP_FURNITURE_DETAIL_28,
		// Token: 0x04008670 RID: 34416
		[Token(Token = "0x4019BC2")]
		SHOP_FURNITURE_DETAIL_29,
		// Token: 0x04008671 RID: 34417
		[Token(Token = "0x4019BC3")]
		SHOP_FURNITURE_DETAIL_30,
		// Token: 0x04008672 RID: 34418
		[Token(Token = "0x4019BC4")]
		SHOP_FURNITURE_DETAIL_31,
		// Token: 0x04008673 RID: 34419
		[Token(Token = "0x4019BC5")]
		SHOP_FURNITURE_DETAIL_32,
		// Token: 0x04008674 RID: 34420
		[Token(Token = "0x4019BC6")]
		SHOP_FURNITURE_DETAIL_33,
		// Token: 0x04008675 RID: 34421
		[Token(Token = "0x4019BC7")]
		SHOP_FURNITURE_DETAIL_34,
		// Token: 0x04008676 RID: 34422
		[Token(Token = "0x4019BC8")]
		SHOP_FURNITURE_DETAIL_35,
		// Token: 0x04008677 RID: 34423
		[Token(Token = "0x4019BC9")]
		SHOP_FURNITURE_DETAIL_36,
		// Token: 0x04008678 RID: 34424
		[Token(Token = "0x4019BCA")]
		SHOP_FURNITURE_DETAIL_37,
		// Token: 0x04008679 RID: 34425
		[Token(Token = "0x4019BCB")]
		SHOP_FURNITURE_DETAIL_38,
		// Token: 0x0400867A RID: 34426
		[Token(Token = "0x4019BCC")]
		SHOP_FURNITURE_DETAIL_39,
		// Token: 0x0400867B RID: 34427
		[Token(Token = "0x4019BCD")]
		SHOP_FURNITURE_DETAIL_40,
		// Token: 0x0400867C RID: 34428
		[Token(Token = "0x4019BCE")]
		SHOP_FURNITURE_DETAIL_41,
		// Token: 0x0400867D RID: 34429
		[Token(Token = "0x4019BCF")]
		SHOP_FURNITURE_DETAIL_42,
		// Token: 0x0400867E RID: 34430
		[Token(Token = "0x4019BD0")]
		SHOP_FURNITURE_DETAIL_43,
		// Token: 0x0400867F RID: 34431
		[Token(Token = "0x4019BD1")]
		SHOP_FURNITURE_DETAIL_44,
		// Token: 0x04008680 RID: 34432
		[Token(Token = "0x4019BD2")]
		SHOP_FURNITURE_DETAIL_45,
		// Token: 0x04008681 RID: 34433
		[Token(Token = "0x4019BD3")]
		SHOP_FURNITURE_DETAIL_46,
		// Token: 0x04008682 RID: 34434
		[Token(Token = "0x4019BD4")]
		SHOP_FURNITURE_DETAIL_47,
		// Token: 0x04008683 RID: 34435
		[Token(Token = "0x4019BD5")]
		SHOP_FURNITURE_DETAIL_48,
		// Token: 0x04008684 RID: 34436
		[Token(Token = "0x4019BD6")]
		SHOP_FURNITURE_DETAIL_49,
		// Token: 0x04008685 RID: 34437
		[Token(Token = "0x4019BD7")]
		SHOP_FURNITURE_DETAIL_50,
		// Token: 0x04008686 RID: 34438
		[Token(Token = "0x4019BD8")]
		SHOP_FURNITURE_DETAIL_51,
		// Token: 0x04008687 RID: 34439
		[Token(Token = "0x4019BD9")]
		SHOP_FURNITURE_DETAIL_52,
		// Token: 0x04008688 RID: 34440
		[Token(Token = "0x4019BDA")]
		SHOP_FURNITURE_DETAIL_53,
		// Token: 0x04008689 RID: 34441
		[Token(Token = "0x4019BDB")]
		SHOP_FURNITURE_DETAIL_54,
		// Token: 0x0400868A RID: 34442
		[Token(Token = "0x4019BDC")]
		SHOP_FURNITURE_DETAIL_55,
		// Token: 0x0400868B RID: 34443
		[Token(Token = "0x4019BDD")]
		SHOP_FURNITURE_DETAIL_56,
		// Token: 0x0400868C RID: 34444
		[Token(Token = "0x4019BDE")]
		SHOP_FURNITURE_DETAIL_57,
		// Token: 0x0400868D RID: 34445
		[Token(Token = "0x4019BDF")]
		SHOP_FURNITURE_DETAIL_58,
		// Token: 0x0400868E RID: 34446
		[Token(Token = "0x4019BE0")]
		SHOP_FURNITURE_DETAIL_59,
		// Token: 0x0400868F RID: 34447
		[Token(Token = "0x4019BE1")]
		SHOP_FURNITURE_DETAIL_60,
		// Token: 0x04008690 RID: 34448
		[Token(Token = "0x4019BE2")]
		SHOP_FURNITURE_DETAIL_61,
		// Token: 0x04008691 RID: 34449
		[Token(Token = "0x4019BE3")]
		SHOP_FURNITURE_DETAIL_62,
		// Token: 0x04008692 RID: 34450
		[Token(Token = "0x4019BE4")]
		SHOP_FURNITURE_DETAIL_63,
		// Token: 0x04008693 RID: 34451
		[Token(Token = "0x4019BE5")]
		SHOP_FURNITURE_DETAIL_64,
		// Token: 0x04008694 RID: 34452
		[Token(Token = "0x4019BE6")]
		SHOP_FURNITURE_DETAIL_65,
		// Token: 0x04008695 RID: 34453
		[Token(Token = "0x4019BE7")]
		SHOP_FURNITURE_DETAIL_66,
		// Token: 0x04008696 RID: 34454
		[Token(Token = "0x4019BE8")]
		SHOP_FURNITURE_DETAIL_67,
		// Token: 0x04008697 RID: 34455
		[Token(Token = "0x4019BE9")]
		SHOP_FURNITURE_DETAIL_68,
		// Token: 0x04008698 RID: 34456
		[Token(Token = "0x4019BEA")]
		SHOP_FURNITURE_DETAIL_69,
		// Token: 0x04008699 RID: 34457
		[Token(Token = "0x4019BEB")]
		SHOP_FURNITURE_DETAIL_70,
		// Token: 0x0400869A RID: 34458
		[Token(Token = "0x4019BEC")]
		SHOP_FURNITURE_DETAIL_71,
		// Token: 0x0400869B RID: 34459
		[Token(Token = "0x4019BED")]
		SHOP_FURNITURE_DETAIL_72,
		// Token: 0x0400869C RID: 34460
		[Token(Token = "0x4019BEE")]
		SHOP_FURNITURE_DETAIL_73,
		// Token: 0x0400869D RID: 34461
		[Token(Token = "0x4019BEF")]
		SHOP_FURNITURE_DETAIL_74,
		// Token: 0x0400869E RID: 34462
		[Token(Token = "0x4019BF0")]
		SHOP_FURNITURE_DETAIL_75,
		// Token: 0x0400869F RID: 34463
		[Token(Token = "0x4019BF1")]
		SHOP_FURNITURE_DETAIL_76,
		// Token: 0x040086A0 RID: 34464
		[Token(Token = "0x4019BF2")]
		SHOP_FURNITURE_DETAIL_77,
		// Token: 0x040086A1 RID: 34465
		[Token(Token = "0x4019BF3")]
		SHOP_BUILD_NAME_db,
		// Token: 0x040086A2 RID: 34466
		[Token(Token = "0x4019BF4")]
		SHOP_BUILD_NAME_01,
		// Token: 0x040086A3 RID: 34467
		[Token(Token = "0x4019BF5")]
		SHOP_BUILD_NAME_02,
		// Token: 0x040086A4 RID: 34468
		[Token(Token = "0x4019BF6")]
		SHOP_BUILD_NAME_03,
		// Token: 0x040086A5 RID: 34469
		[Token(Token = "0x4019BF7")]
		SHOP_BUILD_NAME_04,
		// Token: 0x040086A6 RID: 34470
		[Token(Token = "0x4019BF8")]
		SHOP_BUILD_NAME_05,
		// Token: 0x040086A7 RID: 34471
		[Token(Token = "0x4019BF9")]
		SHOP_BUILD_NAME_06,
		// Token: 0x040086A8 RID: 34472
		[Token(Token = "0x4019BFA")]
		SHOP_BUILD_NAME_07,
		// Token: 0x040086A9 RID: 34473
		[Token(Token = "0x4019BFB")]
		SHOP_BUILD_NAME_08,
		// Token: 0x040086AA RID: 34474
		[Token(Token = "0x4019BFC")]
		SHOP_BUILD_NAME_09,
		// Token: 0x040086AB RID: 34475
		[Token(Token = "0x4019BFD")]
		SHOP_BUILD_NAME_10,
		// Token: 0x040086AC RID: 34476
		[Token(Token = "0x4019BFE")]
		SHOP_BUILD_NAME_11,
		// Token: 0x040086AD RID: 34477
		[Token(Token = "0x4019BFF")]
		SHOP_BUILD_NAME_12,
		// Token: 0x040086AE RID: 34478
		[Token(Token = "0x4019C00")]
		SHOP_BUILD_NAME_13,
		// Token: 0x040086AF RID: 34479
		[Token(Token = "0x4019C01")]
		SHOP_BUILD_NAME_14,
		// Token: 0x040086B0 RID: 34480
		[Token(Token = "0x4019C02")]
		SHOP_BUILD_NAME_15,
		// Token: 0x040086B1 RID: 34481
		[Token(Token = "0x4019C03")]
		SHOP_BUILD_NAME_16,
		// Token: 0x040086B2 RID: 34482
		[Token(Token = "0x4019C04")]
		SHOP_BUILD_NAME_17,
		// Token: 0x040086B3 RID: 34483
		[Token(Token = "0x4019C05")]
		SHOP_BUILD_NAME_18,
		// Token: 0x040086B4 RID: 34484
		[Token(Token = "0x4019C06")]
		SHOP_BUILD_NAME_19,
		// Token: 0x040086B5 RID: 34485
		[Token(Token = "0x4019C07")]
		SHOP_BUILD_NAME_20,
		// Token: 0x040086B6 RID: 34486
		[Token(Token = "0x4019C08")]
		SHOP_BUILD_NAME_21,
		// Token: 0x040086B7 RID: 34487
		[Token(Token = "0x4019C09")]
		SHOP_BUILD_NAME_22,
		// Token: 0x040086B8 RID: 34488
		[Token(Token = "0x4019C0A")]
		SHOP_BUILD_NAME_23,
		// Token: 0x040086B9 RID: 34489
		[Token(Token = "0x4019C0B")]
		SHOP_BUILD_NAME_24,
		// Token: 0x040086BA RID: 34490
		[Token(Token = "0x4019C0C")]
		SHOP_BUILD_NAME_25,
		// Token: 0x040086BB RID: 34491
		[Token(Token = "0x4019C0D")]
		SHOP_BUILD_NAME_26,
		// Token: 0x040086BC RID: 34492
		[Token(Token = "0x4019C0E")]
		SHOP_BUILD_NAME_27,
		// Token: 0x040086BD RID: 34493
		[Token(Token = "0x4019C0F")]
		SHOP_BUILD_NAME_28,
		// Token: 0x040086BE RID: 34494
		[Token(Token = "0x4019C10")]
		SHOP_BUILD_NAME_29,
		// Token: 0x040086BF RID: 34495
		[Token(Token = "0x4019C11")]
		SHOP_BUILD_NAME_30,
		// Token: 0x040086C0 RID: 34496
		[Token(Token = "0x4019C12")]
		SHOP_BUILD_NAME_31,
		// Token: 0x040086C1 RID: 34497
		[Token(Token = "0x4019C13")]
		SHOP_BUILD_NAME_32,
		// Token: 0x040086C2 RID: 34498
		[Token(Token = "0x4019C14")]
		SHOP_BUILD_NAME_33,
		// Token: 0x040086C3 RID: 34499
		[Token(Token = "0x4019C15")]
		SHOP_BUILD_NAME_34,
		// Token: 0x040086C4 RID: 34500
		[Token(Token = "0x4019C16")]
		SHOP_BUILD_NAME_35,
		// Token: 0x040086C5 RID: 34501
		[Token(Token = "0x4019C17")]
		SHOP_BUILD_NAME_36,
		// Token: 0x040086C6 RID: 34502
		[Token(Token = "0x4019C18")]
		SHOP_BUILD_NAME_37,
		// Token: 0x040086C7 RID: 34503
		[Token(Token = "0x4019C19")]
		SHOP_BUILD_NAME_38,
		// Token: 0x040086C8 RID: 34504
		[Token(Token = "0x4019C1A")]
		SHOP_BUILD_NAME_39,
		// Token: 0x040086C9 RID: 34505
		[Token(Token = "0x4019C1B")]
		SHOP_BUILD_NAME_40,
		// Token: 0x040086CA RID: 34506
		[Token(Token = "0x4019C1C")]
		SHOP_BUILD_NAME_41,
		// Token: 0x040086CB RID: 34507
		[Token(Token = "0x4019C1D")]
		SHOP_BUILD_NAME_42,
		// Token: 0x040086CC RID: 34508
		[Token(Token = "0x4019C1E")]
		SHOP_BUILD_NAME_43,
		// Token: 0x040086CD RID: 34509
		[Token(Token = "0x4019C1F")]
		SHOP_BUILD_NAME_44,
		// Token: 0x040086CE RID: 34510
		[Token(Token = "0x4019C20")]
		SHOP_BUILD_NAME_45,
		// Token: 0x040086CF RID: 34511
		[Token(Token = "0x4019C21")]
		SHOP_BUILD_NAME_46,
		// Token: 0x040086D0 RID: 34512
		[Token(Token = "0x4019C22")]
		SHOP_BUILD_NAME_47,
		// Token: 0x040086D1 RID: 34513
		[Token(Token = "0x4019C23")]
		SHOP_BUILD_NAME_48,
		// Token: 0x040086D2 RID: 34514
		[Token(Token = "0x4019C24")]
		SHOP_BUILD_NAME_49,
		// Token: 0x040086D3 RID: 34515
		[Token(Token = "0x4019C25")]
		SHOP_BUILD_NAME_50,
		// Token: 0x040086D4 RID: 34516
		[Token(Token = "0x4019C26")]
		SHOP_BUILD_NAME_51,
		// Token: 0x040086D5 RID: 34517
		[Token(Token = "0x4019C27")]
		SHOP_BUILD_NAME_52,
		// Token: 0x040086D6 RID: 34518
		[Token(Token = "0x4019C28")]
		SHOP_BUILD_NAME_53,
		// Token: 0x040086D7 RID: 34519
		[Token(Token = "0x4019C29")]
		SHOP_BUILD_NAME_54,
		// Token: 0x040086D8 RID: 34520
		[Token(Token = "0x4019C2A")]
		SHOP_BUILD_NAME_55,
		// Token: 0x040086D9 RID: 34521
		[Token(Token = "0x4019C2B")]
		SHOP_BUILD_NAME_56,
		// Token: 0x040086DA RID: 34522
		[Token(Token = "0x4019C2C")]
		SHOP_BUILD_NAME_57,
		// Token: 0x040086DB RID: 34523
		[Token(Token = "0x4019C2D")]
		SHOP_BUILD_NAME_58,
		// Token: 0x040086DC RID: 34524
		[Token(Token = "0x4019C2E")]
		SHOP_BUILD_NAME_59,
		// Token: 0x040086DD RID: 34525
		[Token(Token = "0x4019C2F")]
		SHOP_BUILD_NAME_60,
		// Token: 0x040086DE RID: 34526
		[Token(Token = "0x4019C30")]
		SHOP_BUILD_NAME_61,
		// Token: 0x040086DF RID: 34527
		[Token(Token = "0x4019C31")]
		SHOP_BUILD_NAME_62,
		// Token: 0x040086E0 RID: 34528
		[Token(Token = "0x4019C32")]
		SHOP_BUILD_NAME_63,
		// Token: 0x040086E1 RID: 34529
		[Token(Token = "0x4019C33")]
		SHOP_BUILD_NAME_64,
		// Token: 0x040086E2 RID: 34530
		[Token(Token = "0x4019C34")]
		SHOP_BUILD_NAME_65,
		// Token: 0x040086E3 RID: 34531
		[Token(Token = "0x4019C35")]
		SHOP_BUILD_NAME_66,
		// Token: 0x040086E4 RID: 34532
		[Token(Token = "0x4019C36")]
		SHOP_BUILD_NAME_67,
		// Token: 0x040086E5 RID: 34533
		[Token(Token = "0x4019C37")]
		SHOP_BUILD_NAME_68,
		// Token: 0x040086E6 RID: 34534
		[Token(Token = "0x4019C38")]
		SHOP_BUILD_NAME_69,
		// Token: 0x040086E7 RID: 34535
		[Token(Token = "0x4019C39")]
		SHOP_BUILD_NAME_70,
		// Token: 0x040086E8 RID: 34536
		[Token(Token = "0x4019C3A")]
		SHOP_BUILD_NAME_71,
		// Token: 0x040086E9 RID: 34537
		[Token(Token = "0x4019C3B")]
		SHOP_BUILD_NAME_72,
		// Token: 0x040086EA RID: 34538
		[Token(Token = "0x4019C3C")]
		SHOP_BUILD_NAME_73,
		// Token: 0x040086EB RID: 34539
		[Token(Token = "0x4019C3D")]
		SHOP_BUILD_NAME_74,
		// Token: 0x040086EC RID: 34540
		[Token(Token = "0x4019C3E")]
		SHOP_BUILD_NAME_75,
		// Token: 0x040086ED RID: 34541
		[Token(Token = "0x4019C3F")]
		SHOP_BUILD_NAME_76,
		// Token: 0x040086EE RID: 34542
		[Token(Token = "0x4019C40")]
		SHOP_BUILD_NAME_77,
		// Token: 0x040086EF RID: 34543
		[Token(Token = "0x4019C41")]
		SHOP_BUILD_NAME_78,
		// Token: 0x040086F0 RID: 34544
		[Token(Token = "0x4019C42")]
		SHOP_BUILD_NAME_79,
		// Token: 0x040086F1 RID: 34545
		[Token(Token = "0x4019C43")]
		SHOP_BUILD_NAME_80,
		// Token: 0x040086F2 RID: 34546
		[Token(Token = "0x4019C44")]
		SHOP_BUILD_NAME_81,
		// Token: 0x040086F3 RID: 34547
		[Token(Token = "0x4019C45")]
		SHOP_BUILD_NAME_82,
		// Token: 0x040086F4 RID: 34548
		[Token(Token = "0x4019C46")]
		SHOP_BUILD_NAME_83,
		// Token: 0x040086F5 RID: 34549
		[Token(Token = "0x4019C47")]
		SHOP_BUILD_NAME_84,
		// Token: 0x040086F6 RID: 34550
		[Token(Token = "0x4019C48")]
		SHOP_BUILD_NAME_85,
		// Token: 0x040086F7 RID: 34551
		[Token(Token = "0x4019C49")]
		SHOP_BUILD_NAME_86,
		// Token: 0x040086F8 RID: 34552
		[Token(Token = "0x4019C4A")]
		SHOP_BUILD_NAME_87,
		// Token: 0x040086F9 RID: 34553
		[Token(Token = "0x4019C4B")]
		SHOP_BUILD_NAME_88,
		// Token: 0x040086FA RID: 34554
		[Token(Token = "0x4019C4C")]
		SHOP_BUILD_NAME_89,
		// Token: 0x040086FB RID: 34555
		[Token(Token = "0x4019C4D")]
		SHOP_BUILD_NAME_90,
		// Token: 0x040086FC RID: 34556
		[Token(Token = "0x4019C4E")]
		SHOP_BUILD_NAME_91,
		// Token: 0x040086FD RID: 34557
		[Token(Token = "0x4019C4F")]
		SHOP_BUILD_NAME_92,
		// Token: 0x040086FE RID: 34558
		[Token(Token = "0x4019C50")]
		SHOP_BUILD_NAME_93,
		// Token: 0x040086FF RID: 34559
		[Token(Token = "0x4019C51")]
		SHOP_BUILD_NAME_94,
		// Token: 0x04008700 RID: 34560
		[Token(Token = "0x4019C52")]
		SHOP_BUILD_NAME_95,
		// Token: 0x04008701 RID: 34561
		[Token(Token = "0x4019C53")]
		SHOP_BUILD_DETAIL_db,
		// Token: 0x04008702 RID: 34562
		[Token(Token = "0x4019C54")]
		SHOP_BUILD_DETAIL_01,
		// Token: 0x04008703 RID: 34563
		[Token(Token = "0x4019C55")]
		SHOP_BUILD_DETAIL_02,
		// Token: 0x04008704 RID: 34564
		[Token(Token = "0x4019C56")]
		SHOP_BUILD_DETAIL_03,
		// Token: 0x04008705 RID: 34565
		[Token(Token = "0x4019C57")]
		SHOP_BUILD_DETAIL_04,
		// Token: 0x04008706 RID: 34566
		[Token(Token = "0x4019C58")]
		SHOP_BUILD_DETAIL_05,
		// Token: 0x04008707 RID: 34567
		[Token(Token = "0x4019C59")]
		SHOP_BUILD_DETAIL_06,
		// Token: 0x04008708 RID: 34568
		[Token(Token = "0x4019C5A")]
		SHOP_BUILD_DETAIL_07,
		// Token: 0x04008709 RID: 34569
		[Token(Token = "0x4019C5B")]
		SHOP_BUILD_DETAIL_08,
		// Token: 0x0400870A RID: 34570
		[Token(Token = "0x4019C5C")]
		SHOP_BUILD_DETAIL_09,
		// Token: 0x0400870B RID: 34571
		[Token(Token = "0x4019C5D")]
		SHOP_BUILD_DETAIL_10,
		// Token: 0x0400870C RID: 34572
		[Token(Token = "0x4019C5E")]
		SHOP_BUILD_DETAIL_11,
		// Token: 0x0400870D RID: 34573
		[Token(Token = "0x4019C5F")]
		SHOP_BUILD_DETAIL_12,
		// Token: 0x0400870E RID: 34574
		[Token(Token = "0x4019C60")]
		SHOP_BUILD_DETAIL_13,
		// Token: 0x0400870F RID: 34575
		[Token(Token = "0x4019C61")]
		SHOP_BUILD_DETAIL_14,
		// Token: 0x04008710 RID: 34576
		[Token(Token = "0x4019C62")]
		SHOP_BUILD_DETAIL_15,
		// Token: 0x04008711 RID: 34577
		[Token(Token = "0x4019C63")]
		SHOP_BUILD_DETAIL_16,
		// Token: 0x04008712 RID: 34578
		[Token(Token = "0x4019C64")]
		SHOP_BUILD_DETAIL_17,
		// Token: 0x04008713 RID: 34579
		[Token(Token = "0x4019C65")]
		SHOP_BUILD_DETAIL_18,
		// Token: 0x04008714 RID: 34580
		[Token(Token = "0x4019C66")]
		SHOP_BUILD_DETAIL_19,
		// Token: 0x04008715 RID: 34581
		[Token(Token = "0x4019C67")]
		SHOP_BUILD_DETAIL_20,
		// Token: 0x04008716 RID: 34582
		[Token(Token = "0x4019C68")]
		SHOP_BUILD_DETAIL_21,
		// Token: 0x04008717 RID: 34583
		[Token(Token = "0x4019C69")]
		SHOP_BUILD_DETAIL_22,
		// Token: 0x04008718 RID: 34584
		[Token(Token = "0x4019C6A")]
		SHOP_BUILD_DETAIL_23,
		// Token: 0x04008719 RID: 34585
		[Token(Token = "0x4019C6B")]
		SHOP_BUILD_DETAIL_24,
		// Token: 0x0400871A RID: 34586
		[Token(Token = "0x4019C6C")]
		SHOP_BUILD_DETAIL_25,
		// Token: 0x0400871B RID: 34587
		[Token(Token = "0x4019C6D")]
		SHOP_BUILD_DETAIL_26,
		// Token: 0x0400871C RID: 34588
		[Token(Token = "0x4019C6E")]
		SHOP_BUILD_DETAIL_27,
		// Token: 0x0400871D RID: 34589
		[Token(Token = "0x4019C6F")]
		SHOP_BUILD_DETAIL_28,
		// Token: 0x0400871E RID: 34590
		[Token(Token = "0x4019C70")]
		SHOP_BUILD_DETAIL_29,
		// Token: 0x0400871F RID: 34591
		[Token(Token = "0x4019C71")]
		SHOP_BUILD_DETAIL_30,
		// Token: 0x04008720 RID: 34592
		[Token(Token = "0x4019C72")]
		SHOP_BUILD_DETAIL_31,
		// Token: 0x04008721 RID: 34593
		[Token(Token = "0x4019C73")]
		SHOP_BUILD_DETAIL_32,
		// Token: 0x04008722 RID: 34594
		[Token(Token = "0x4019C74")]
		SHOP_BUILD_DETAIL_33,
		// Token: 0x04008723 RID: 34595
		[Token(Token = "0x4019C75")]
		SHOP_BUILD_DETAIL_34,
		// Token: 0x04008724 RID: 34596
		[Token(Token = "0x4019C76")]
		SHOP_BUILD_DETAIL_35,
		// Token: 0x04008725 RID: 34597
		[Token(Token = "0x4019C77")]
		SHOP_BUILD_DETAIL_36,
		// Token: 0x04008726 RID: 34598
		[Token(Token = "0x4019C78")]
		SHOP_BUILD_DETAIL_37,
		// Token: 0x04008727 RID: 34599
		[Token(Token = "0x4019C79")]
		SHOP_BUILD_DETAIL_38,
		// Token: 0x04008728 RID: 34600
		[Token(Token = "0x4019C7A")]
		SHOP_BUILD_DETAIL_39,
		// Token: 0x04008729 RID: 34601
		[Token(Token = "0x4019C7B")]
		SHOP_BUILD_DETAIL_40,
		// Token: 0x0400872A RID: 34602
		[Token(Token = "0x4019C7C")]
		SHOP_BUILD_DETAIL_41,
		// Token: 0x0400872B RID: 34603
		[Token(Token = "0x4019C7D")]
		SHOP_BUILD_DETAIL_42,
		// Token: 0x0400872C RID: 34604
		[Token(Token = "0x4019C7E")]
		SHOP_BUILD_DETAIL_43,
		// Token: 0x0400872D RID: 34605
		[Token(Token = "0x4019C7F")]
		SHOP_BUILD_DETAIL_44,
		// Token: 0x0400872E RID: 34606
		[Token(Token = "0x4019C80")]
		SHOP_BUILD_DETAIL_45,
		// Token: 0x0400872F RID: 34607
		[Token(Token = "0x4019C81")]
		SHOP_BUILD_DETAIL_46,
		// Token: 0x04008730 RID: 34608
		[Token(Token = "0x4019C82")]
		SHOP_BUILD_DETAIL_47,
		// Token: 0x04008731 RID: 34609
		[Token(Token = "0x4019C83")]
		SHOP_BUILD_DETAIL_48,
		// Token: 0x04008732 RID: 34610
		[Token(Token = "0x4019C84")]
		SHOP_BUILD_DETAIL_49,
		// Token: 0x04008733 RID: 34611
		[Token(Token = "0x4019C85")]
		SHOP_BUILD_DETAIL_50,
		// Token: 0x04008734 RID: 34612
		[Token(Token = "0x4019C86")]
		SHOP_BUILD_DETAIL_51,
		// Token: 0x04008735 RID: 34613
		[Token(Token = "0x4019C87")]
		SHOP_BUILD_DETAIL_52,
		// Token: 0x04008736 RID: 34614
		[Token(Token = "0x4019C88")]
		SHOP_BUILD_DETAIL_53,
		// Token: 0x04008737 RID: 34615
		[Token(Token = "0x4019C89")]
		SHOP_BUILD_DETAIL_54,
		// Token: 0x04008738 RID: 34616
		[Token(Token = "0x4019C8A")]
		SHOP_BUILD_DETAIL_55,
		// Token: 0x04008739 RID: 34617
		[Token(Token = "0x4019C8B")]
		SHOP_BUILD_DETAIL_56,
		// Token: 0x0400873A RID: 34618
		[Token(Token = "0x4019C8C")]
		SHOP_BUILD_DETAIL_57,
		// Token: 0x0400873B RID: 34619
		[Token(Token = "0x4019C8D")]
		SHOP_BUILD_DETAIL_58,
		// Token: 0x0400873C RID: 34620
		[Token(Token = "0x4019C8E")]
		SHOP_BUILD_DETAIL_59,
		// Token: 0x0400873D RID: 34621
		[Token(Token = "0x4019C8F")]
		SHOP_BUILD_DETAIL_60,
		// Token: 0x0400873E RID: 34622
		[Token(Token = "0x4019C90")]
		SHOP_BUILD_DETAIL_61,
		// Token: 0x0400873F RID: 34623
		[Token(Token = "0x4019C91")]
		SHOP_BUILD_DETAIL_62,
		// Token: 0x04008740 RID: 34624
		[Token(Token = "0x4019C92")]
		SHOP_BUILD_DETAIL_63,
		// Token: 0x04008741 RID: 34625
		[Token(Token = "0x4019C93")]
		SHOP_BUILD_DETAIL_64,
		// Token: 0x04008742 RID: 34626
		[Token(Token = "0x4019C94")]
		SHOP_BUILD_DETAIL_65,
		// Token: 0x04008743 RID: 34627
		[Token(Token = "0x4019C95")]
		SHOP_BUILD_DETAIL_66,
		// Token: 0x04008744 RID: 34628
		[Token(Token = "0x4019C96")]
		SHOP_BUILD_DETAIL_67,
		// Token: 0x04008745 RID: 34629
		[Token(Token = "0x4019C97")]
		SHOP_BUILD_DETAIL_68,
		// Token: 0x04008746 RID: 34630
		[Token(Token = "0x4019C98")]
		SHOP_BUILD_DETAIL_69,
		// Token: 0x04008747 RID: 34631
		[Token(Token = "0x4019C99")]
		SHOP_BUILD_DETAIL_70,
		// Token: 0x04008748 RID: 34632
		[Token(Token = "0x4019C9A")]
		SHOP_BUILD_DETAIL_71,
		// Token: 0x04008749 RID: 34633
		[Token(Token = "0x4019C9B")]
		SHOP_BUILD_DETAIL_72,
		// Token: 0x0400874A RID: 34634
		[Token(Token = "0x4019C9C")]
		SHOP_BUILD_DETAIL_73,
		// Token: 0x0400874B RID: 34635
		[Token(Token = "0x4019C9D")]
		SHOP_BUILD_DETAIL_74,
		// Token: 0x0400874C RID: 34636
		[Token(Token = "0x4019C9E")]
		SHOP_BUILD_DETAIL_75,
		// Token: 0x0400874D RID: 34637
		[Token(Token = "0x4019C9F")]
		SHOP_BUILD_DETAIL_76,
		// Token: 0x0400874E RID: 34638
		[Token(Token = "0x4019CA0")]
		SHOP_BUILD_DETAIL_77,
		// Token: 0x0400874F RID: 34639
		[Token(Token = "0x4019CA1")]
		SHOP_BUILD_DETAIL_78,
		// Token: 0x04008750 RID: 34640
		[Token(Token = "0x4019CA2")]
		SHOP_BUILD_DETAIL_79,
		// Token: 0x04008751 RID: 34641
		[Token(Token = "0x4019CA3")]
		SHOP_BUILD_DETAIL_80,
		// Token: 0x04008752 RID: 34642
		[Token(Token = "0x4019CA4")]
		SHOP_BUILD_DETAIL_81,
		// Token: 0x04008753 RID: 34643
		[Token(Token = "0x4019CA5")]
		SHOP_BUILD_DETAIL_82,
		// Token: 0x04008754 RID: 34644
		[Token(Token = "0x4019CA6")]
		SHOP_BUILD_DETAIL_83,
		// Token: 0x04008755 RID: 34645
		[Token(Token = "0x4019CA7")]
		SHOP_BUILD_DETAIL_84,
		// Token: 0x04008756 RID: 34646
		[Token(Token = "0x4019CA8")]
		SHOP_BUILD_DETAIL_85,
		// Token: 0x04008757 RID: 34647
		[Token(Token = "0x4019CA9")]
		SHOP_BUILD_DETAIL_86,
		// Token: 0x04008758 RID: 34648
		[Token(Token = "0x4019CAA")]
		SHOP_BUILD_DETAIL_87,
		// Token: 0x04008759 RID: 34649
		[Token(Token = "0x4019CAB")]
		SHOP_BUILD_DETAIL_88,
		// Token: 0x0400875A RID: 34650
		[Token(Token = "0x4019CAC")]
		SHOP_BUILD_DETAIL_89,
		// Token: 0x0400875B RID: 34651
		[Token(Token = "0x4019CAD")]
		SHOP_BUILD_DETAIL_90,
		// Token: 0x0400875C RID: 34652
		[Token(Token = "0x4019CAE")]
		SHOP_BUILD_DETAIL_91,
		// Token: 0x0400875D RID: 34653
		[Token(Token = "0x4019CAF")]
		SHOP_BUILD_DETAIL_92,
		// Token: 0x0400875E RID: 34654
		[Token(Token = "0x4019CB0")]
		SHOP_BUILD_DETAIL_93,
		// Token: 0x0400875F RID: 34655
		[Token(Token = "0x4019CB1")]
		SHOP_BUILD_DETAIL_94,
		// Token: 0x04008760 RID: 34656
		[Token(Token = "0x4019CB2")]
		SHOP_BUILD_DETAIL_95,
		// Token: 0x04008761 RID: 34657
		[Token(Token = "0x4019CB3")]
		WANTED_UI_FOREST1 = 6000,
		// Token: 0x04008762 RID: 34658
		[Token(Token = "0x4019CB4")]
		WANTED_UI_FOREST2,
		// Token: 0x04008763 RID: 34659
		[Token(Token = "0x4019CB5")]
		WANTED_UI_FOREST3,
		// Token: 0x04008764 RID: 34660
		[Token(Token = "0x4019CB6")]
		WANTED_UI_FOREST4,
		// Token: 0x04008765 RID: 34661
		[Token(Token = "0x4019CB7")]
		WANTED_UI_FOREST5,
		// Token: 0x04008766 RID: 34662
		[Token(Token = "0x4019CB8")]
		WANTED_UI_VALCANO1,
		// Token: 0x04008767 RID: 34663
		[Token(Token = "0x4019CB9")]
		WANTED_UI_VALCANO2,
		// Token: 0x04008768 RID: 34664
		[Token(Token = "0x4019CBA")]
		WANTED_UI_VALCANO3,
		// Token: 0x04008769 RID: 34665
		[Token(Token = "0x4019CBB")]
		WANTED_UI_VALCANO4,
		// Token: 0x0400876A RID: 34666
		[Token(Token = "0x4019CBC")]
		WANTED_UI_VALCANO5,
		// Token: 0x0400876B RID: 34667
		[Token(Token = "0x4019CBD")]
		WANTED_UI_ICY1,
		// Token: 0x0400876C RID: 34668
		[Token(Token = "0x4019CBE")]
		WANTED_UI_ICY2,
		// Token: 0x0400876D RID: 34669
		[Token(Token = "0x4019CBF")]
		WANTED_UI_ICY3,
		// Token: 0x0400876E RID: 34670
		[Token(Token = "0x4019CC0")]
		WANTED_UI_ICY4,
		// Token: 0x0400876F RID: 34671
		[Token(Token = "0x4019CC1")]
		WANTED_UI_ICY5,
		// Token: 0x04008770 RID: 34672
		[Token(Token = "0x4019CC2")]
		WANTED_ADV_FOREST1,
		// Token: 0x04008771 RID: 34673
		[Token(Token = "0x4019CC3")]
		WANTED_ADV_FOREST2,
		// Token: 0x04008772 RID: 34674
		[Token(Token = "0x4019CC4")]
		WANTED_ADV_FOREST3,
		// Token: 0x04008773 RID: 34675
		[Token(Token = "0x4019CC5")]
		WANTED_ADV_FOREST4,
		// Token: 0x04008774 RID: 34676
		[Token(Token = "0x4019CC6")]
		WANTED_ADV_FOREST5,
		// Token: 0x04008775 RID: 34677
		[Token(Token = "0x4019CC7")]
		WATNED_ADV_VALCANO1,
		// Token: 0x04008776 RID: 34678
		[Token(Token = "0x4019CC8")]
		WATNED_ADV_VALCANO2,
		// Token: 0x04008777 RID: 34679
		[Token(Token = "0x4019CC9")]
		WATNED_ADV_VALCANO3,
		// Token: 0x04008778 RID: 34680
		[Token(Token = "0x4019CCA")]
		WATNED_ADV_VALCANO4,
		// Token: 0x04008779 RID: 34681
		[Token(Token = "0x4019CCB")]
		WATNED_ADV_VALCANO5,
		// Token: 0x0400877A RID: 34682
		[Token(Token = "0x4019CCC")]
		WATNED_ADV_ICY1,
		// Token: 0x0400877B RID: 34683
		[Token(Token = "0x4019CCD")]
		WATNED_ADV_ICY2,
		// Token: 0x0400877C RID: 34684
		[Token(Token = "0x4019CCE")]
		WATNED_ADV_ICY3,
		// Token: 0x0400877D RID: 34685
		[Token(Token = "0x4019CCF")]
		WATNED_ADV_ICY4,
		// Token: 0x0400877E RID: 34686
		[Token(Token = "0x4019CD0")]
		WATNED_ADV_ICY5,
		// Token: 0x0400877F RID: 34687
		[Token(Token = "0x4019CD1")]
		WANTED_SELECTDETAIL,
		// Token: 0x04008780 RID: 34688
		[Token(Token = "0x4019CD2")]
		WANTED_GROUP_FOREST,
		// Token: 0x04008781 RID: 34689
		[Token(Token = "0x4019CD3")]
		WANTED_GROUP_VALCANO,
		// Token: 0x04008782 RID: 34690
		[Token(Token = "0x4019CD4")]
		WANTED_GROUP_ICY,
		// Token: 0x04008783 RID: 34691
		[Token(Token = "0x4019CD5")]
		WANTED_GROUP_MASTER,
		// Token: 0x04008784 RID: 34692
		[Token(Token = "0x4019CD6")]
		WANTED_COMPLETE_HEADTEXT,
		// Token: 0x04008785 RID: 34693
		[Token(Token = "0x4019CD7")]
		WANTED_REWARD_HEADTEXT,
		// Token: 0x04008786 RID: 34694
		[Token(Token = "0x4019CD8")]
		WANTED_REWARD_SEEDPOINT,
		// Token: 0x04008787 RID: 34695
		[Token(Token = "0x4019CD9")]
		WANTED_REWARD_SCOREBONUS,
		// Token: 0x04008788 RID: 34696
		[Token(Token = "0x4019CDA")]
		MakingTopic_License = 7000,
		// Token: 0x04008789 RID: 34697
		[Token(Token = "0x4019CDB")]
		MakingTopic_FestivalOpen,
		// Token: 0x0400878A RID: 34698
		[Token(Token = "0x4019CDC")]
		MakingTopic_FestivalEnd,
		// Token: 0x0400878B RID: 34699
		[Token(Token = "0x4019CDD")]
		MakingTopic_Develop,
		// Token: 0x0400878C RID: 34700
		[Token(Token = "0x4019CDE")]
		MakingTopic_Other,
		// Token: 0x0400878D RID: 34701
		[Token(Token = "0x4019CDF")]
		MakingTopic_Extra,
		// Token: 0x0400878E RID: 34702
		[Token(Token = "0x4019CE0")]
		MakingTopic_End,
		// Token: 0x0400878F RID: 34703
		[Token(Token = "0x4019CE1")]
		MakingTopicAdv_License,
		// Token: 0x04008790 RID: 34704
		[Token(Token = "0x4019CE2")]
		MakingTopicAdv_FestivalOpen,
		// Token: 0x04008791 RID: 34705
		[Token(Token = "0x4019CE3")]
		MakingTopicAdv_FestivalEnd,
		// Token: 0x04008792 RID: 34706
		[Token(Token = "0x4019CE4")]
		MakingTopicAdv_Develop,
		// Token: 0x04008793 RID: 34707
		[Token(Token = "0x4019CE5")]
		MakingTopicAdv_Other,
		// Token: 0x04008794 RID: 34708
		[Token(Token = "0x4019CE6")]
		MakingTopicAdv_Extra,
		// Token: 0x04008795 RID: 34709
		[Token(Token = "0x4019CE7")]
		MakingTopicAdv_End,
		// Token: 0x04008796 RID: 34710
		[Token(Token = "0x4019CE8")]
		MakingChoice_MakingLicense010,
		// Token: 0x04008797 RID: 34711
		[Token(Token = "0x4019CE9")]
		MakingChoice_MakingLicense020,
		// Token: 0x04008798 RID: 34712
		[Token(Token = "0x4019CEA")]
		MakingChoice_MakingLicense030,
		// Token: 0x04008799 RID: 34713
		[Token(Token = "0x4019CEB")]
		MakingChoice_MakingLicense040,
		// Token: 0x0400879A RID: 34714
		[Token(Token = "0x4019CEC")]
		MakingChoice_MakingLicense050,
		// Token: 0x0400879B RID: 34715
		[Token(Token = "0x4019CED")]
		MakingChoice_MakingLicense060,
		// Token: 0x0400879C RID: 34716
		[Token(Token = "0x4019CEE")]
		MakingChoice_MakingFestival010_Open,
		// Token: 0x0400879D RID: 34717
		[Token(Token = "0x4019CEF")]
		MakingChoice_MakingFestival020_Open,
		// Token: 0x0400879E RID: 34718
		[Token(Token = "0x4019CF0")]
		MakingChoice_MakingFestival030_Open,
		// Token: 0x0400879F RID: 34719
		[Token(Token = "0x4019CF1")]
		MakingChoice_MakingFestival040_Open,
		// Token: 0x040087A0 RID: 34720
		[Token(Token = "0x4019CF2")]
		MakingChoice_MakingFestival050_Open,
		// Token: 0x040087A1 RID: 34721
		[Token(Token = "0x4019CF3")]
		MakingChoice_MakingFestival060_Open,
		// Token: 0x040087A2 RID: 34722
		[Token(Token = "0x4019CF4")]
		MakingChoice_MakingFestival070_Open,
		// Token: 0x040087A3 RID: 34723
		[Token(Token = "0x4019CF5")]
		MakingChoice_MakingFestival080_Open,
		// Token: 0x040087A4 RID: 34724
		[Token(Token = "0x4019CF6")]
		MakingChoice_MakingFestival090_Open,
		// Token: 0x040087A5 RID: 34725
		[Token(Token = "0x4019CF7")]
		MakingChoice_MakingFestival100_Open,
		// Token: 0x040087A6 RID: 34726
		[Token(Token = "0x4019CF8")]
		MakingChoice_MakingFestival110_Open,
		// Token: 0x040087A7 RID: 34727
		[Token(Token = "0x4019CF9")]
		MakingChoice_MakingFestival120_Open,
		// Token: 0x040087A8 RID: 34728
		[Token(Token = "0x4019CFA")]
		MakingChoice_MakingFestival130_Open,
		// Token: 0x040087A9 RID: 34729
		[Token(Token = "0x4019CFB")]
		MakingChoice_MakingFestival140_Open,
		// Token: 0x040087AA RID: 34730
		[Token(Token = "0x4019CFC")]
		MakingChoice_MakingFestival150_Open,
		// Token: 0x040087AB RID: 34731
		[Token(Token = "0x4019CFD")]
		MakingChoice_MakingFestival160_Open,
		// Token: 0x040087AC RID: 34732
		[Token(Token = "0x4019CFE")]
		MakingChoice_MakingFestival170_Open,
		// Token: 0x040087AD RID: 34733
		[Token(Token = "0x4019CFF")]
		MakingChoice_MakingFestival180_Open,
		// Token: 0x040087AE RID: 34734
		[Token(Token = "0x4019D00")]
		MakingChoice_MakingFestival190_Open,
		// Token: 0x040087AF RID: 34735
		[Token(Token = "0x4019D01")]
		MakingChoice_MakingFestival010_Close,
		// Token: 0x040087B0 RID: 34736
		[Token(Token = "0x4019D02")]
		MakingChoice_MakingFestival020_Close,
		// Token: 0x040087B1 RID: 34737
		[Token(Token = "0x4019D03")]
		MakingChoice_MakingFestival030_Close,
		// Token: 0x040087B2 RID: 34738
		[Token(Token = "0x4019D04")]
		MakingChoice_MakingFestival040_Close,
		// Token: 0x040087B3 RID: 34739
		[Token(Token = "0x4019D05")]
		MakingChoice_MakingFestival050_Close,
		// Token: 0x040087B4 RID: 34740
		[Token(Token = "0x4019D06")]
		MakingChoice_MakingFestival060_Close,
		// Token: 0x040087B5 RID: 34741
		[Token(Token = "0x4019D07")]
		MakingChoice_MakingFestival070_Close,
		// Token: 0x040087B6 RID: 34742
		[Token(Token = "0x4019D08")]
		MakingChoice_MakingFestival080_Close,
		// Token: 0x040087B7 RID: 34743
		[Token(Token = "0x4019D09")]
		MakingChoice_MakingFestival090_Close,
		// Token: 0x040087B8 RID: 34744
		[Token(Token = "0x4019D0A")]
		MakingChoice_MakingFestival100_Close,
		// Token: 0x040087B9 RID: 34745
		[Token(Token = "0x4019D0B")]
		MakingChoice_MakingFestival110_Close,
		// Token: 0x040087BA RID: 34746
		[Token(Token = "0x4019D0C")]
		MakingChoice_MakingFestival120_Close,
		// Token: 0x040087BB RID: 34747
		[Token(Token = "0x4019D0D")]
		MakingChoice_MakingFestival130_Close,
		// Token: 0x040087BC RID: 34748
		[Token(Token = "0x4019D0E")]
		MakingChoice_MakingFestival140_Close,
		// Token: 0x040087BD RID: 34749
		[Token(Token = "0x4019D0F")]
		MakingChoice_MakingFestival150_Close,
		// Token: 0x040087BE RID: 34750
		[Token(Token = "0x4019D10")]
		MakingChoice_MakingFestival160_Close,
		// Token: 0x040087BF RID: 34751
		[Token(Token = "0x4019D11")]
		MakingChoice_MakingFestival170_Close,
		// Token: 0x040087C0 RID: 34752
		[Token(Token = "0x4019D12")]
		MakingChoice_MakingFestival180_Close,
		// Token: 0x040087C1 RID: 34753
		[Token(Token = "0x4019D13")]
		MakingChoice_MakingFestival190_Close,
		// Token: 0x040087C2 RID: 34754
		[Token(Token = "0x4019D14")]
		MakingChoice_MakingOther010,
		// Token: 0x040087C3 RID: 34755
		[Token(Token = "0x4019D15")]
		MakingChoice_MakingOther020,
		// Token: 0x040087C4 RID: 34756
		[Token(Token = "0x4019D16")]
		MakingChoice_MakingOther030,
		// Token: 0x040087C5 RID: 34757
		[Token(Token = "0x4019D17")]
		MakingChoice_MakingOther040,
		// Token: 0x040087C6 RID: 34758
		[Token(Token = "0x4019D18")]
		MakingChoice_MakingOther050,
		// Token: 0x040087C7 RID: 34759
		[Token(Token = "0x4019D19")]
		MakingChoice_MakingOther060,
		// Token: 0x040087C8 RID: 34760
		[Token(Token = "0x4019D1A")]
		MakingChoice_MakingOther070,
		// Token: 0x040087C9 RID: 34761
		[Token(Token = "0x4019D1B")]
		MakingChoice_MakingOther080,
		// Token: 0x040087CA RID: 34762
		[Token(Token = "0x4019D1C")]
		MakingChoice_MakingOther090,
		// Token: 0x040087CB RID: 34763
		[Token(Token = "0x4019D1D")]
		MakingChoice_MakingOther100,
		// Token: 0x040087CC RID: 34764
		[Token(Token = "0x4019D1E")]
		MakingChoice_MakingOther110,
		// Token: 0x040087CD RID: 34765
		[Token(Token = "0x4019D1F")]
		MakingChoice_MakingOther120,
		// Token: 0x040087CE RID: 34766
		[Token(Token = "0x4019D20")]
		MakingChoice_MakingOther130,
		// Token: 0x040087CF RID: 34767
		[Token(Token = "0x4019D21")]
		MakingChoice_MakingOther140,
		// Token: 0x040087D0 RID: 34768
		[Token(Token = "0x4019D22")]
		MakingChoice_MakingOther150,
		// Token: 0x040087D1 RID: 34769
		[Token(Token = "0x4019D23")]
		MakingChoice_MakingOther160,
		// Token: 0x040087D2 RID: 34770
		[Token(Token = "0x4019D24")]
		MakingChoice_MakingOther170,
		// Token: 0x040087D3 RID: 34771
		[Token(Token = "0x4019D25")]
		MakingChoice_MakingOther180,
		// Token: 0x040087D4 RID: 34772
		[Token(Token = "0x4019D26")]
		MakingChoice_MakingOther190,
		// Token: 0x040087D5 RID: 34773
		[Token(Token = "0x4019D27")]
		MakingChoice_MakingOther200,
		// Token: 0x040087D6 RID: 34774
		[Token(Token = "0x4019D28")]
		MakingChoice_MakingOther210,
		// Token: 0x040087D7 RID: 34775
		[Token(Token = "0x4019D29")]
		MakingChoice_MakingOther220,
		// Token: 0x040087D8 RID: 34776
		[Token(Token = "0x4019D2A")]
		MakingChoice_MakingOther230,
		// Token: 0x040087D9 RID: 34777
		[Token(Token = "0x4019D2B")]
		MakingChoice_MakingOther240,
		// Token: 0x040087DA RID: 34778
		[Token(Token = "0x4019D2C")]
		MakingChoice_MakingDevelop010,
		// Token: 0x040087DB RID: 34779
		[Token(Token = "0x4019D2D")]
		MakingChoice_MakingDevelop020,
		// Token: 0x040087DC RID: 34780
		[Token(Token = "0x4019D2E")]
		MakingChoice_MakingDevelop030,
		// Token: 0x040087DD RID: 34781
		[Token(Token = "0x4019D2F")]
		MakingChoice_MakingDevelop040,
		// Token: 0x040087DE RID: 34782
		[Token(Token = "0x4019D30")]
		MakingChoice_MakingDevelop050,
		// Token: 0x040087DF RID: 34783
		[Token(Token = "0x4019D31")]
		MakingChoice_MakingDevelop060,
		// Token: 0x040087E0 RID: 34784
		[Token(Token = "0x4019D32")]
		MakingChoice_MakingDevelop070,
		// Token: 0x040087E1 RID: 34785
		[Token(Token = "0x4019D33")]
		MakingChoice_MakingDevelop080,
		// Token: 0x040087E2 RID: 34786
		[Token(Token = "0x4019D34")]
		MakingChoice_MakingDevelop090,
		// Token: 0x040087E3 RID: 34787
		[Token(Token = "0x4019D35")]
		MakingChoice_MakingDevelop100,
		// Token: 0x040087E4 RID: 34788
		[Token(Token = "0x4019D36")]
		MakingChoice_MakingDevelop110,
		// Token: 0x040087E5 RID: 34789
		[Token(Token = "0x4019D37")]
		MakingChoice_MakingDevelop120,
		// Token: 0x040087E6 RID: 34790
		[Token(Token = "0x4019D38")]
		MakingChoice_MakingDevelop130,
		// Token: 0x040087E7 RID: 34791
		[Token(Token = "0x4019D39")]
		MakingChoice_MakingDevelop140,
		// Token: 0x040087E8 RID: 34792
		[Token(Token = "0x4019D3A")]
		MakingChoice_MakingDevelop150,
		// Token: 0x040087E9 RID: 34793
		[Token(Token = "0x4019D3B")]
		MakingChoice_MakingDevelop160,
		// Token: 0x040087EA RID: 34794
		[Token(Token = "0x4019D3C")]
		MakingChoice_MakingDevelop170,
		// Token: 0x040087EB RID: 34795
		[Token(Token = "0x4019D3D")]
		MakingChoice_MakingDevelop180,
		// Token: 0x040087EC RID: 34796
		[Token(Token = "0x4019D3E")]
		MakingChoice_MakingDevelop190,
		// Token: 0x040087ED RID: 34797
		[Token(Token = "0x4019D3F")]
		MakingChoice_MakingDevelop200,
		// Token: 0x040087EE RID: 34798
		[Token(Token = "0x4019D40")]
		MakingChoice_MakingDevelop210,
		// Token: 0x040087EF RID: 34799
		[Token(Token = "0x4019D41")]
		MakingChoice_MakingDevelop220,
		// Token: 0x040087F0 RID: 34800
		[Token(Token = "0x4019D42")]
		MakingChoice_MakingDevelop230,
		// Token: 0x040087F1 RID: 34801
		[Token(Token = "0x4019D43")]
		MakingChoice_MakingDevelop240,
		// Token: 0x040087F2 RID: 34802
		[Token(Token = "0x4019D44")]
		MakingChoice_MakingDevelop250,
		// Token: 0x040087F3 RID: 34803
		[Token(Token = "0x4019D45")]
		MakingChoice_MakingDevelop260,
		// Token: 0x040087F4 RID: 34804
		[Token(Token = "0x4019D46")]
		MakingChoice_MakingDevelop270,
		// Token: 0x040087F5 RID: 34805
		[Token(Token = "0x4019D47")]
		MakingChoice_MakingDevelop280,
		// Token: 0x040087F6 RID: 34806
		[Token(Token = "0x4019D48")]
		MakingChoice_MakingDevelop290,
		// Token: 0x040087F7 RID: 34807
		[Token(Token = "0x4019D49")]
		MakingChoice_MakingDevelop300,
		// Token: 0x040087F8 RID: 34808
		[Token(Token = "0x4019D4A")]
		MakingChoice_MakingExtra010,
		// Token: 0x040087F9 RID: 34809
		[Token(Token = "0x4019D4B")]
		MakingChoice_MakingExtra020,
		// Token: 0x040087FA RID: 34810
		[Token(Token = "0x4019D4C")]
		MakingChoice_MakingExtra030,
		// Token: 0x040087FB RID: 34811
		[Token(Token = "0x4019D4D")]
		MakingChoice_MakingExtra040,
		// Token: 0x040087FC RID: 34812
		[Token(Token = "0x4019D4E")]
		MakingChoice_MakingExtra050,
		// Token: 0x040087FD RID: 34813
		[Token(Token = "0x4019D4F")]
		MakingChoice_MakingExtra060,
		// Token: 0x040087FE RID: 34814
		[Token(Token = "0x4019D50")]
		MakingChoice_MakingExtra070,
		// Token: 0x040087FF RID: 34815
		[Token(Token = "0x4019D51")]
		MakingChoice_MakingExtra080,
		// Token: 0x04008800 RID: 34816
		[Token(Token = "0x4019D52")]
		MakingChoice_MakingExtra090,
		// Token: 0x04008801 RID: 34817
		[Token(Token = "0x4019D53")]
		MakingChoice_MakingExtra100,
		// Token: 0x04008802 RID: 34818
		[Token(Token = "0x4019D54")]
		MakingChoice_MakingExtra110,
		// Token: 0x04008803 RID: 34819
		[Token(Token = "0x4019D55")]
		MakingChoice_MakingExtra120,
		// Token: 0x04008804 RID: 34820
		[Token(Token = "0x4019D56")]
		MakingChoice_MakingExtra130,
		// Token: 0x04008805 RID: 34821
		[Token(Token = "0x4019D57")]
		MakingChoice_MakingExtra140,
		// Token: 0x04008806 RID: 34822
		[Token(Token = "0x4019D58")]
		MakingChoice_MakingExtra141,
		// Token: 0x04008807 RID: 34823
		[Token(Token = "0x4019D59")]
		MakingChoice_MakingExtra150,
		// Token: 0x04008808 RID: 34824
		[Token(Token = "0x4019D5A")]
		MakingChoice_MakingExtra160,
		// Token: 0x04008809 RID: 34825
		[Token(Token = "0x4019D5B")]
		MakingChoice_MakingExtra170,
		// Token: 0x0400880A RID: 34826
		[Token(Token = "0x4019D5C")]
		MakingChoice_MakingExtra171,
		// Token: 0x0400880B RID: 34827
		[Token(Token = "0x4019D5D")]
		MakingChoice_MakingExtra172,
		// Token: 0x0400880C RID: 34828
		[Token(Token = "0x4019D5E")]
		MakingChoice_MakingExtra173,
		// Token: 0x0400880D RID: 34829
		[Token(Token = "0x4019D5F")]
		MakingChoiceAdv_MakingLicense010,
		// Token: 0x0400880E RID: 34830
		[Token(Token = "0x4019D60")]
		MakingChoiceAdv_MakingLicense020,
		// Token: 0x0400880F RID: 34831
		[Token(Token = "0x4019D61")]
		MakingChoiceAdv_MakingLicense030,
		// Token: 0x04008810 RID: 34832
		[Token(Token = "0x4019D62")]
		MakingChoiceAdv_MakingLicense040,
		// Token: 0x04008811 RID: 34833
		[Token(Token = "0x4019D63")]
		MakingChoiceAdv_MakingLicense050,
		// Token: 0x04008812 RID: 34834
		[Token(Token = "0x4019D64")]
		MakingChoiceAdv_MakingLicense060,
		// Token: 0x04008813 RID: 34835
		[Token(Token = "0x4019D65")]
		MakingChoiceAdv_MakingFestival010_Open,
		// Token: 0x04008814 RID: 34836
		[Token(Token = "0x4019D66")]
		MakingChoiceAdv_MakingFestival020_Open,
		// Token: 0x04008815 RID: 34837
		[Token(Token = "0x4019D67")]
		MakingChoiceAdv_MakingFestival030_Open,
		// Token: 0x04008816 RID: 34838
		[Token(Token = "0x4019D68")]
		MakingChoiceAdv_MakingFestival040_Open,
		// Token: 0x04008817 RID: 34839
		[Token(Token = "0x4019D69")]
		MakingChoiceAdv_MakingFestival050_Open,
		// Token: 0x04008818 RID: 34840
		[Token(Token = "0x4019D6A")]
		MakingChoiceAdv_MakingFestival060_Open,
		// Token: 0x04008819 RID: 34841
		[Token(Token = "0x4019D6B")]
		MakingChoiceAdv_MakingFestival070_Open,
		// Token: 0x0400881A RID: 34842
		[Token(Token = "0x4019D6C")]
		MakingChoiceAdv_MakingFestival080_Open,
		// Token: 0x0400881B RID: 34843
		[Token(Token = "0x4019D6D")]
		MakingChoiceAdv_MakingFestival090_Open,
		// Token: 0x0400881C RID: 34844
		[Token(Token = "0x4019D6E")]
		MakingChoiceAdv_MakingFestival100_Open,
		// Token: 0x0400881D RID: 34845
		[Token(Token = "0x4019D6F")]
		MakingChoiceAdv_MakingFestival110_Open,
		// Token: 0x0400881E RID: 34846
		[Token(Token = "0x4019D70")]
		MakingChoiceAdv_MakingFestival120_Open,
		// Token: 0x0400881F RID: 34847
		[Token(Token = "0x4019D71")]
		MakingChoiceAdv_MakingFestival130_Open,
		// Token: 0x04008820 RID: 34848
		[Token(Token = "0x4019D72")]
		MakingChoiceAdv_MakingFestival140_Open,
		// Token: 0x04008821 RID: 34849
		[Token(Token = "0x4019D73")]
		MakingChoiceAdv_MakingFestival150_Open,
		// Token: 0x04008822 RID: 34850
		[Token(Token = "0x4019D74")]
		MakingChoiceAdv_MakingFestival160_Open,
		// Token: 0x04008823 RID: 34851
		[Token(Token = "0x4019D75")]
		MakingChoiceAdv_MakingFestival170_Open,
		// Token: 0x04008824 RID: 34852
		[Token(Token = "0x4019D76")]
		MakingChoiceAdv_MakingFestival180_Open,
		// Token: 0x04008825 RID: 34853
		[Token(Token = "0x4019D77")]
		MakingChoiceAdv_MakingFestival190_Open,
		// Token: 0x04008826 RID: 34854
		[Token(Token = "0x4019D78")]
		MakingChoiceAdv_MakingFestival010_Close,
		// Token: 0x04008827 RID: 34855
		[Token(Token = "0x4019D79")]
		MakingChoiceAdv_MakingFestival020_Close,
		// Token: 0x04008828 RID: 34856
		[Token(Token = "0x4019D7A")]
		MakingChoiceAdv_MakingFestival030_Close,
		// Token: 0x04008829 RID: 34857
		[Token(Token = "0x4019D7B")]
		MakingChoiceAdv_MakingFestival040_Close,
		// Token: 0x0400882A RID: 34858
		[Token(Token = "0x4019D7C")]
		MakingChoiceAdv_MakingFestival050_Close,
		// Token: 0x0400882B RID: 34859
		[Token(Token = "0x4019D7D")]
		MakingChoiceAdv_MakingFestival060_Close,
		// Token: 0x0400882C RID: 34860
		[Token(Token = "0x4019D7E")]
		MakingChoiceAdv_MakingFestival070_Close,
		// Token: 0x0400882D RID: 34861
		[Token(Token = "0x4019D7F")]
		MakingChoiceAdv_MakingFestival080_Close,
		// Token: 0x0400882E RID: 34862
		[Token(Token = "0x4019D80")]
		MakingChoiceAdv_MakingFestival090_Close,
		// Token: 0x0400882F RID: 34863
		[Token(Token = "0x4019D81")]
		MakingChoiceAdv_MakingFestival100_Close,
		// Token: 0x04008830 RID: 34864
		[Token(Token = "0x4019D82")]
		MakingChoiceAdv_MakingFestival110_Close,
		// Token: 0x04008831 RID: 34865
		[Token(Token = "0x4019D83")]
		MakingChoiceAdv_MakingFestival120_Close,
		// Token: 0x04008832 RID: 34866
		[Token(Token = "0x4019D84")]
		MakingChoiceAdv_MakingFestival130_Close,
		// Token: 0x04008833 RID: 34867
		[Token(Token = "0x4019D85")]
		MakingChoiceAdv_MakingFestival140_Close,
		// Token: 0x04008834 RID: 34868
		[Token(Token = "0x4019D86")]
		MakingChoiceAdv_MakingFestival150_Close,
		// Token: 0x04008835 RID: 34869
		[Token(Token = "0x4019D87")]
		MakingChoiceAdv_MakingFestival160_Close,
		// Token: 0x04008836 RID: 34870
		[Token(Token = "0x4019D88")]
		MakingChoiceAdv_MakingFestival170_Close,
		// Token: 0x04008837 RID: 34871
		[Token(Token = "0x4019D89")]
		MakingChoiceAdv_MakingFestival180_Close,
		// Token: 0x04008838 RID: 34872
		[Token(Token = "0x4019D8A")]
		MakingChoiceAdv_MakingFestival190_Close,
		// Token: 0x04008839 RID: 34873
		[Token(Token = "0x4019D8B")]
		MakingChoiceAdv_MakingOther010,
		// Token: 0x0400883A RID: 34874
		[Token(Token = "0x4019D8C")]
		MakingChoiceAdv_MakingOther020,
		// Token: 0x0400883B RID: 34875
		[Token(Token = "0x4019D8D")]
		MakingChoiceAdv_MakingOther030,
		// Token: 0x0400883C RID: 34876
		[Token(Token = "0x4019D8E")]
		MakingChoiceAdv_MakingOther040,
		// Token: 0x0400883D RID: 34877
		[Token(Token = "0x4019D8F")]
		MakingChoiceAdv_MakingOther050,
		// Token: 0x0400883E RID: 34878
		[Token(Token = "0x4019D90")]
		MakingChoiceAdv_MakingOther060,
		// Token: 0x0400883F RID: 34879
		[Token(Token = "0x4019D91")]
		MakingChoiceAdv_MakingOther070,
		// Token: 0x04008840 RID: 34880
		[Token(Token = "0x4019D92")]
		MakingChoiceAdv_MakingOther080,
		// Token: 0x04008841 RID: 34881
		[Token(Token = "0x4019D93")]
		MakingChoiceAdv_MakingOther090,
		// Token: 0x04008842 RID: 34882
		[Token(Token = "0x4019D94")]
		MakingChoiceAdv_MakingOther100,
		// Token: 0x04008843 RID: 34883
		[Token(Token = "0x4019D95")]
		MakingChoiceAdv_MakingOther110,
		// Token: 0x04008844 RID: 34884
		[Token(Token = "0x4019D96")]
		MakingChoiceAdv_MakingOther120,
		// Token: 0x04008845 RID: 34885
		[Token(Token = "0x4019D97")]
		MakingChoiceAdv_MakingOther130,
		// Token: 0x04008846 RID: 34886
		[Token(Token = "0x4019D98")]
		MakingChoiceAdv_MakingOther140,
		// Token: 0x04008847 RID: 34887
		[Token(Token = "0x4019D99")]
		MakingChoiceAdv_MakingOther150,
		// Token: 0x04008848 RID: 34888
		[Token(Token = "0x4019D9A")]
		MakingChoiceAdv_MakingOther160,
		// Token: 0x04008849 RID: 34889
		[Token(Token = "0x4019D9B")]
		MakingChoiceAdv_MakingOther170,
		// Token: 0x0400884A RID: 34890
		[Token(Token = "0x4019D9C")]
		MakingChoiceAdv_MakingOther180,
		// Token: 0x0400884B RID: 34891
		[Token(Token = "0x4019D9D")]
		MakingChoiceAdv_MakingOther190,
		// Token: 0x0400884C RID: 34892
		[Token(Token = "0x4019D9E")]
		MakingChoiceAdv_MakingOther200,
		// Token: 0x0400884D RID: 34893
		[Token(Token = "0x4019D9F")]
		MakingChoiceAdv_MakingOther210,
		// Token: 0x0400884E RID: 34894
		[Token(Token = "0x4019DA0")]
		MakingChoiceAdv_MakingOther220,
		// Token: 0x0400884F RID: 34895
		[Token(Token = "0x4019DA1")]
		MakingChoiceAdv_MakingOther230,
		// Token: 0x04008850 RID: 34896
		[Token(Token = "0x4019DA2")]
		MakingChoiceAdv_MakingOther240,
		// Token: 0x04008851 RID: 34897
		[Token(Token = "0x4019DA3")]
		MakingChoiceAdv_MakingDevelop010,
		// Token: 0x04008852 RID: 34898
		[Token(Token = "0x4019DA4")]
		MakingChoiceAdv_MakingDevelop020,
		// Token: 0x04008853 RID: 34899
		[Token(Token = "0x4019DA5")]
		MakingChoiceAdv_MakingDevelop030,
		// Token: 0x04008854 RID: 34900
		[Token(Token = "0x4019DA6")]
		MakingChoiceAdv_MakingDevelop040,
		// Token: 0x04008855 RID: 34901
		[Token(Token = "0x4019DA7")]
		MakingChoiceAdv_MakingDevelop050,
		// Token: 0x04008856 RID: 34902
		[Token(Token = "0x4019DA8")]
		MakingChoiceAdv_MakingDevelop060,
		// Token: 0x04008857 RID: 34903
		[Token(Token = "0x4019DA9")]
		MakingChoiceAdv_MakingDevelop070,
		// Token: 0x04008858 RID: 34904
		[Token(Token = "0x4019DAA")]
		MakingChoiceAdv_MakingDevelop080,
		// Token: 0x04008859 RID: 34905
		[Token(Token = "0x4019DAB")]
		MakingChoiceAdv_MakingDevelop090,
		// Token: 0x0400885A RID: 34906
		[Token(Token = "0x4019DAC")]
		MakingChoiceAdv_MakingDevelop100,
		// Token: 0x0400885B RID: 34907
		[Token(Token = "0x4019DAD")]
		MakingChoiceAdv_MakingDevelop110,
		// Token: 0x0400885C RID: 34908
		[Token(Token = "0x4019DAE")]
		MakingChoiceAdv_MakingDevelop120,
		// Token: 0x0400885D RID: 34909
		[Token(Token = "0x4019DAF")]
		MakingChoiceAdv_MakingDevelop130,
		// Token: 0x0400885E RID: 34910
		[Token(Token = "0x4019DB0")]
		MakingChoiceAdv_MakingDevelop140,
		// Token: 0x0400885F RID: 34911
		[Token(Token = "0x4019DB1")]
		MakingChoiceAdv_MakingDevelop150,
		// Token: 0x04008860 RID: 34912
		[Token(Token = "0x4019DB2")]
		MakingChoiceAdv_MakingDevelop160,
		// Token: 0x04008861 RID: 34913
		[Token(Token = "0x4019DB3")]
		MakingChoiceAdv_MakingDevelop170,
		// Token: 0x04008862 RID: 34914
		[Token(Token = "0x4019DB4")]
		MakingChoiceAdv_MakingDevelop180,
		// Token: 0x04008863 RID: 34915
		[Token(Token = "0x4019DB5")]
		MakingChoiceAdv_MakingDevelop190,
		// Token: 0x04008864 RID: 34916
		[Token(Token = "0x4019DB6")]
		MakingChoiceAdv_MakingDevelop200,
		// Token: 0x04008865 RID: 34917
		[Token(Token = "0x4019DB7")]
		MakingChoiceAdv_MakingDevelop210,
		// Token: 0x04008866 RID: 34918
		[Token(Token = "0x4019DB8")]
		MakingChoiceAdv_MakingDevelop220,
		// Token: 0x04008867 RID: 34919
		[Token(Token = "0x4019DB9")]
		MakingChoiceAdv_MakingDevelop230,
		// Token: 0x04008868 RID: 34920
		[Token(Token = "0x4019DBA")]
		MakingChoiceAdv_MakingDevelop240,
		// Token: 0x04008869 RID: 34921
		[Token(Token = "0x4019DBB")]
		MakingChoiceAdv_MakingDevelop250,
		// Token: 0x0400886A RID: 34922
		[Token(Token = "0x4019DBC")]
		MakingChoiceAdv_MakingDevelop260,
		// Token: 0x0400886B RID: 34923
		[Token(Token = "0x4019DBD")]
		MakingChoiceAdv_MakingDevelop270,
		// Token: 0x0400886C RID: 34924
		[Token(Token = "0x4019DBE")]
		MakingChoiceAdv_MakingDevelop280,
		// Token: 0x0400886D RID: 34925
		[Token(Token = "0x4019DBF")]
		MakingChoiceAdv_MakingDevelop290,
		// Token: 0x0400886E RID: 34926
		[Token(Token = "0x4019DC0")]
		MakingChoiceAdv_MakingDevelop300,
		// Token: 0x0400886F RID: 34927
		[Token(Token = "0x4019DC1")]
		MakingChoiceAdv_MakingExtra010,
		// Token: 0x04008870 RID: 34928
		[Token(Token = "0x4019DC2")]
		MakingChoiceAdv_MakingExtra020,
		// Token: 0x04008871 RID: 34929
		[Token(Token = "0x4019DC3")]
		MakingChoiceAdv_MakingExtra030,
		// Token: 0x04008872 RID: 34930
		[Token(Token = "0x4019DC4")]
		MakingChoiceAdv_MakingExtra040,
		// Token: 0x04008873 RID: 34931
		[Token(Token = "0x4019DC5")]
		MakingChoiceAdv_MakingExtra050,
		// Token: 0x04008874 RID: 34932
		[Token(Token = "0x4019DC6")]
		MakingChoiceAdv_MakingExtra060,
		// Token: 0x04008875 RID: 34933
		[Token(Token = "0x4019DC7")]
		MakingChoiceAdv_MakingExtra070,
		// Token: 0x04008876 RID: 34934
		[Token(Token = "0x4019DC8")]
		MakingChoiceAdv_MakingExtra080,
		// Token: 0x04008877 RID: 34935
		[Token(Token = "0x4019DC9")]
		MakingChoiceAdv_MakingExtra090,
		// Token: 0x04008878 RID: 34936
		[Token(Token = "0x4019DCA")]
		MakingChoiceAdv_MakingExtra100,
		// Token: 0x04008879 RID: 34937
		[Token(Token = "0x4019DCB")]
		MakingChoiceAdv_MakingExtra110,
		// Token: 0x0400887A RID: 34938
		[Token(Token = "0x4019DCC")]
		MakingChoiceAdv_MakingExtra120,
		// Token: 0x0400887B RID: 34939
		[Token(Token = "0x4019DCD")]
		MakingChoiceAdv_MakingExtra130,
		// Token: 0x0400887C RID: 34940
		[Token(Token = "0x4019DCE")]
		MakingChoiceAdv_MakingExtra140,
		// Token: 0x0400887D RID: 34941
		[Token(Token = "0x4019DCF")]
		MakingChoiceAdv_MakingExtra141,
		// Token: 0x0400887E RID: 34942
		[Token(Token = "0x4019DD0")]
		MakingChoiceAdv_MakingExtra150,
		// Token: 0x0400887F RID: 34943
		[Token(Token = "0x4019DD1")]
		MakingChoiceAdv_MakingExtra160,
		// Token: 0x04008880 RID: 34944
		[Token(Token = "0x4019DD2")]
		MakingChoiceAdv_MakingExtra170,
		// Token: 0x04008881 RID: 34945
		[Token(Token = "0x4019DD3")]
		MakingChoiceAdv_MakingExtra171,
		// Token: 0x04008882 RID: 34946
		[Token(Token = "0x4019DD4")]
		MakingChoiceAdv_MakingExtra172,
		// Token: 0x04008883 RID: 34947
		[Token(Token = "0x4019DD5")]
		MakingChoiceAdv_MakingExtra173,
		// Token: 0x04008884 RID: 34948
		[Token(Token = "0x4019DD6")]
		MakingAfterAdv_MakingLicense010,
		// Token: 0x04008885 RID: 34949
		[Token(Token = "0x4019DD7")]
		MakingAfterAdv_MakingLicense020,
		// Token: 0x04008886 RID: 34950
		[Token(Token = "0x4019DD8")]
		MakingAfterAdv_MakingLicense030,
		// Token: 0x04008887 RID: 34951
		[Token(Token = "0x4019DD9")]
		MakingAfterAdv_MakingLicense040,
		// Token: 0x04008888 RID: 34952
		[Token(Token = "0x4019DDA")]
		MakingAfterAdv_MakingLicense050,
		// Token: 0x04008889 RID: 34953
		[Token(Token = "0x4019DDB")]
		MakingAfterAdv_MakingLicense060,
		// Token: 0x0400888A RID: 34954
		[Token(Token = "0x4019DDC")]
		MakingAfterAdv_MakingFestival010_Open,
		// Token: 0x0400888B RID: 34955
		[Token(Token = "0x4019DDD")]
		MakingAfterAdv_MakingFestival020_Open,
		// Token: 0x0400888C RID: 34956
		[Token(Token = "0x4019DDE")]
		MakingAfterAdv_MakingFestival030_Open,
		// Token: 0x0400888D RID: 34957
		[Token(Token = "0x4019DDF")]
		MakingAfterAdv_MakingFestival040_Open,
		// Token: 0x0400888E RID: 34958
		[Token(Token = "0x4019DE0")]
		MakingAfterAdv_MakingFestival050_Open,
		// Token: 0x0400888F RID: 34959
		[Token(Token = "0x4019DE1")]
		MakingAfterAdv_MakingFestival060_Open,
		// Token: 0x04008890 RID: 34960
		[Token(Token = "0x4019DE2")]
		MakingAfterAdv_MakingFestival070_Open,
		// Token: 0x04008891 RID: 34961
		[Token(Token = "0x4019DE3")]
		MakingAfterAdv_MakingFestival080_Open,
		// Token: 0x04008892 RID: 34962
		[Token(Token = "0x4019DE4")]
		MakingAfterAdv_MakingFestival090_Open,
		// Token: 0x04008893 RID: 34963
		[Token(Token = "0x4019DE5")]
		MakingAfterAdv_MakingFestival100_Open,
		// Token: 0x04008894 RID: 34964
		[Token(Token = "0x4019DE6")]
		MakingAfterAdv_MakingFestival110_Open,
		// Token: 0x04008895 RID: 34965
		[Token(Token = "0x4019DE7")]
		MakingAfterAdv_MakingFestival120_Open,
		// Token: 0x04008896 RID: 34966
		[Token(Token = "0x4019DE8")]
		MakingAfterAdv_MakingFestival130_Open,
		// Token: 0x04008897 RID: 34967
		[Token(Token = "0x4019DE9")]
		MakingAfterAdv_MakingFestival140_Open,
		// Token: 0x04008898 RID: 34968
		[Token(Token = "0x4019DEA")]
		MakingAfterAdv_MakingFestival150_Open,
		// Token: 0x04008899 RID: 34969
		[Token(Token = "0x4019DEB")]
		MakingAfterAdv_MakingFestival160_Open,
		// Token: 0x0400889A RID: 34970
		[Token(Token = "0x4019DEC")]
		MakingAfterAdv_MakingFestival170_Open,
		// Token: 0x0400889B RID: 34971
		[Token(Token = "0x4019DED")]
		MakingAfterAdv_MakingFestival180_Open,
		// Token: 0x0400889C RID: 34972
		[Token(Token = "0x4019DEE")]
		MakingAfterAdv_MakingFestival190_Open,
		// Token: 0x0400889D RID: 34973
		[Token(Token = "0x4019DEF")]
		MakingAfterAdv_MakingFestival010_Close,
		// Token: 0x0400889E RID: 34974
		[Token(Token = "0x4019DF0")]
		MakingAfterAdv_MakingFestival020_Close,
		// Token: 0x0400889F RID: 34975
		[Token(Token = "0x4019DF1")]
		MakingAfterAdv_MakingFestival030_Close,
		// Token: 0x040088A0 RID: 34976
		[Token(Token = "0x4019DF2")]
		MakingAfterAdv_MakingFestival040_Close,
		// Token: 0x040088A1 RID: 34977
		[Token(Token = "0x4019DF3")]
		MakingAfterAdv_MakingFestival050_Close,
		// Token: 0x040088A2 RID: 34978
		[Token(Token = "0x4019DF4")]
		MakingAfterAdv_MakingFestival060_Close,
		// Token: 0x040088A3 RID: 34979
		[Token(Token = "0x4019DF5")]
		MakingAfterAdv_MakingFestival070_Close,
		// Token: 0x040088A4 RID: 34980
		[Token(Token = "0x4019DF6")]
		MakingAfterAdv_MakingFestival080_Close,
		// Token: 0x040088A5 RID: 34981
		[Token(Token = "0x4019DF7")]
		MakingAfterAdv_MakingFestival090_Close,
		// Token: 0x040088A6 RID: 34982
		[Token(Token = "0x4019DF8")]
		MakingAfterAdv_MakingFestival100_Close,
		// Token: 0x040088A7 RID: 34983
		[Token(Token = "0x4019DF9")]
		MakingAfterAdv_MakingFestival110_Close,
		// Token: 0x040088A8 RID: 34984
		[Token(Token = "0x4019DFA")]
		MakingAfterAdv_MakingFestival120_Close,
		// Token: 0x040088A9 RID: 34985
		[Token(Token = "0x4019DFB")]
		MakingAfterAdv_MakingFestival130_Close,
		// Token: 0x040088AA RID: 34986
		[Token(Token = "0x4019DFC")]
		MakingAfterAdv_MakingFestival140_Close,
		// Token: 0x040088AB RID: 34987
		[Token(Token = "0x4019DFD")]
		MakingAfterAdv_MakingFestival150_Close,
		// Token: 0x040088AC RID: 34988
		[Token(Token = "0x4019DFE")]
		MakingAfterAdv_MakingFestival160_Close,
		// Token: 0x040088AD RID: 34989
		[Token(Token = "0x4019DFF")]
		MakingAfterAdv_MakingFestival170_Close,
		// Token: 0x040088AE RID: 34990
		[Token(Token = "0x4019E00")]
		MakingAfterAdv_MakingFestival180_Close,
		// Token: 0x040088AF RID: 34991
		[Token(Token = "0x4019E01")]
		MakingAfterAdv_MakingFestival190_Close,
		// Token: 0x040088B0 RID: 34992
		[Token(Token = "0x4019E02")]
		MakingAfterAdv_MakingOther010,
		// Token: 0x040088B1 RID: 34993
		[Token(Token = "0x4019E03")]
		MakingAfterAdv_MakingOther020,
		// Token: 0x040088B2 RID: 34994
		[Token(Token = "0x4019E04")]
		MakingAfterAdv_MakingOther030,
		// Token: 0x040088B3 RID: 34995
		[Token(Token = "0x4019E05")]
		MakingAfterAdv_MakingOther040,
		// Token: 0x040088B4 RID: 34996
		[Token(Token = "0x4019E06")]
		MakingAfterAdv_MakingOther050,
		// Token: 0x040088B5 RID: 34997
		[Token(Token = "0x4019E07")]
		MakingAfterAdv_MakingOther060,
		// Token: 0x040088B6 RID: 34998
		[Token(Token = "0x4019E08")]
		MakingAfterAdv_MakingOther070,
		// Token: 0x040088B7 RID: 34999
		[Token(Token = "0x4019E09")]
		MakingAfterAdv_MakingOther080,
		// Token: 0x040088B8 RID: 35000
		[Token(Token = "0x4019E0A")]
		MakingAfterAdv_MakingOther090,
		// Token: 0x040088B9 RID: 35001
		[Token(Token = "0x4019E0B")]
		MakingAfterAdv_MakingOther100,
		// Token: 0x040088BA RID: 35002
		[Token(Token = "0x4019E0C")]
		MakingAfterAdv_MakingOther110,
		// Token: 0x040088BB RID: 35003
		[Token(Token = "0x4019E0D")]
		MakingAfterAdv_MakingOther120,
		// Token: 0x040088BC RID: 35004
		[Token(Token = "0x4019E0E")]
		MakingAfterAdv_MakingOther130,
		// Token: 0x040088BD RID: 35005
		[Token(Token = "0x4019E0F")]
		MakingAfterAdv_MakingOther140,
		// Token: 0x040088BE RID: 35006
		[Token(Token = "0x4019E10")]
		MakingAfterAdv_MakingOther150,
		// Token: 0x040088BF RID: 35007
		[Token(Token = "0x4019E11")]
		MakingAfterAdv_MakingOther160,
		// Token: 0x040088C0 RID: 35008
		[Token(Token = "0x4019E12")]
		MakingAfterAdv_MakingOther170,
		// Token: 0x040088C1 RID: 35009
		[Token(Token = "0x4019E13")]
		MakingAfterAdv_MakingOther180,
		// Token: 0x040088C2 RID: 35010
		[Token(Token = "0x4019E14")]
		MakingAfterAdv_MakingOther190,
		// Token: 0x040088C3 RID: 35011
		[Token(Token = "0x4019E15")]
		MakingAfterAdv_MakingOther200,
		// Token: 0x040088C4 RID: 35012
		[Token(Token = "0x4019E16")]
		MakingAfterAdv_MakingOther210,
		// Token: 0x040088C5 RID: 35013
		[Token(Token = "0x4019E17")]
		MakingAfterAdv_MakingOther220,
		// Token: 0x040088C6 RID: 35014
		[Token(Token = "0x4019E18")]
		MakingAfterAdv_MakingOther230,
		// Token: 0x040088C7 RID: 35015
		[Token(Token = "0x4019E19")]
		MakingAfterAdv_MakingOther240,
		// Token: 0x040088C8 RID: 35016
		[Token(Token = "0x4019E1A")]
		MakingAfterAdv_MakingDevelop010,
		// Token: 0x040088C9 RID: 35017
		[Token(Token = "0x4019E1B")]
		MakingAfterAdv_MakingDevelop020,
		// Token: 0x040088CA RID: 35018
		[Token(Token = "0x4019E1C")]
		MakingAfterAdv_MakingDevelop030,
		// Token: 0x040088CB RID: 35019
		[Token(Token = "0x4019E1D")]
		MakingAfterAdv_MakingDevelop040,
		// Token: 0x040088CC RID: 35020
		[Token(Token = "0x4019E1E")]
		MakingAfterAdv_MakingDevelop050,
		// Token: 0x040088CD RID: 35021
		[Token(Token = "0x4019E1F")]
		MakingAfterAdv_MakingDevelop060,
		// Token: 0x040088CE RID: 35022
		[Token(Token = "0x4019E20")]
		MakingAfterAdv_MakingDevelop070,
		// Token: 0x040088CF RID: 35023
		[Token(Token = "0x4019E21")]
		MakingAfterAdv_MakingDevelop080,
		// Token: 0x040088D0 RID: 35024
		[Token(Token = "0x4019E22")]
		MakingAfterAdv_MakingDevelop090,
		// Token: 0x040088D1 RID: 35025
		[Token(Token = "0x4019E23")]
		MakingAfterAdv_MakingDevelop100,
		// Token: 0x040088D2 RID: 35026
		[Token(Token = "0x4019E24")]
		MakingAfterAdv_MakingDevelop110,
		// Token: 0x040088D3 RID: 35027
		[Token(Token = "0x4019E25")]
		MakingAfterAdv_MakingDevelop120,
		// Token: 0x040088D4 RID: 35028
		[Token(Token = "0x4019E26")]
		MakingAfterAdv_MakingDevelop130,
		// Token: 0x040088D5 RID: 35029
		[Token(Token = "0x4019E27")]
		MakingAfterAdv_MakingDevelop140,
		// Token: 0x040088D6 RID: 35030
		[Token(Token = "0x4019E28")]
		MakingAfterAdv_MakingDevelop150,
		// Token: 0x040088D7 RID: 35031
		[Token(Token = "0x4019E29")]
		MakingAfterAdv_MakingDevelop160,
		// Token: 0x040088D8 RID: 35032
		[Token(Token = "0x4019E2A")]
		MakingAfterAdv_MakingDevelop170,
		// Token: 0x040088D9 RID: 35033
		[Token(Token = "0x4019E2B")]
		MakingAfterAdv_MakingDevelop180,
		// Token: 0x040088DA RID: 35034
		[Token(Token = "0x4019E2C")]
		MakingAfterAdv_MakingDevelop190,
		// Token: 0x040088DB RID: 35035
		[Token(Token = "0x4019E2D")]
		MakingAfterAdv_MakingDevelop200,
		// Token: 0x040088DC RID: 35036
		[Token(Token = "0x4019E2E")]
		MakingAfterAdv_MakingDevelop210,
		// Token: 0x040088DD RID: 35037
		[Token(Token = "0x4019E2F")]
		MakingAfterAdv_MakingDevelop220,
		// Token: 0x040088DE RID: 35038
		[Token(Token = "0x4019E30")]
		MakingAfterAdv_MakingDevelop230,
		// Token: 0x040088DF RID: 35039
		[Token(Token = "0x4019E31")]
		MakingAfterAdv_MakingDevelop240,
		// Token: 0x040088E0 RID: 35040
		[Token(Token = "0x4019E32")]
		MakingAfterAdv_MakingDevelop250,
		// Token: 0x040088E1 RID: 35041
		[Token(Token = "0x4019E33")]
		MakingAfterAdv_MakingDevelop260,
		// Token: 0x040088E2 RID: 35042
		[Token(Token = "0x4019E34")]
		MakingAfterAdv_MakingDevelop270,
		// Token: 0x040088E3 RID: 35043
		[Token(Token = "0x4019E35")]
		MakingAfterAdv_MakingDevelop280,
		// Token: 0x040088E4 RID: 35044
		[Token(Token = "0x4019E36")]
		MakingAfterAdv_MakingDevelop290,
		// Token: 0x040088E5 RID: 35045
		[Token(Token = "0x4019E37")]
		MakingAfterAdv_MakingDevelop300,
		// Token: 0x040088E6 RID: 35046
		[Token(Token = "0x4019E38")]
		MakingAfterAdv_MakingExtra010,
		// Token: 0x040088E7 RID: 35047
		[Token(Token = "0x4019E39")]
		MakingAfterAdv_MakingExtra020,
		// Token: 0x040088E8 RID: 35048
		[Token(Token = "0x4019E3A")]
		MakingAfterAdv_MakingExtra030,
		// Token: 0x040088E9 RID: 35049
		[Token(Token = "0x4019E3B")]
		MakingAfterAdv_MakingExtra040,
		// Token: 0x040088EA RID: 35050
		[Token(Token = "0x4019E3C")]
		MakingAfterAdv_MakingExtra050,
		// Token: 0x040088EB RID: 35051
		[Token(Token = "0x4019E3D")]
		MakingAfterAdv_MakingExtra060,
		// Token: 0x040088EC RID: 35052
		[Token(Token = "0x4019E3E")]
		MakingAfterAdv_MakingExtra070,
		// Token: 0x040088ED RID: 35053
		[Token(Token = "0x4019E3F")]
		MakingAfterAdv_MakingExtra080,
		// Token: 0x040088EE RID: 35054
		[Token(Token = "0x4019E40")]
		MakingAfterAdv_MakingExtra090,
		// Token: 0x040088EF RID: 35055
		[Token(Token = "0x4019E41")]
		MakingAfterAdv_MakingExtra100,
		// Token: 0x040088F0 RID: 35056
		[Token(Token = "0x4019E42")]
		MakingAfterAdv_MakingExtra110,
		// Token: 0x040088F1 RID: 35057
		[Token(Token = "0x4019E43")]
		MakingAfterAdv_MakingExtra120,
		// Token: 0x040088F2 RID: 35058
		[Token(Token = "0x4019E44")]
		MakingAfterAdv_MakingExtra130,
		// Token: 0x040088F3 RID: 35059
		[Token(Token = "0x4019E45")]
		MakingAfterAdv_MakingExtra140,
		// Token: 0x040088F4 RID: 35060
		[Token(Token = "0x4019E46")]
		MakingAfterAdv_MakingExtra141,
		// Token: 0x040088F5 RID: 35061
		[Token(Token = "0x4019E47")]
		MakingAfterAdv_MakingExtra150,
		// Token: 0x040088F6 RID: 35062
		[Token(Token = "0x4019E48")]
		MakingAfterAdv_MakingExtra160,
		// Token: 0x040088F7 RID: 35063
		[Token(Token = "0x4019E49")]
		MakingAfterAdv_MakingExtra170,
		// Token: 0x040088F8 RID: 35064
		[Token(Token = "0x4019E4A")]
		MakingAfterAdv_MakingExtra171,
		// Token: 0x040088F9 RID: 35065
		[Token(Token = "0x4019E4B")]
		MakingAfterAdv_MakingExtra172,
		// Token: 0x040088FA RID: 35066
		[Token(Token = "0x4019E4C")]
		MakingAfterAdv_MakingExtra173,
		// Token: 0x040088FB RID: 35067
		[Token(Token = "0x4019E4D")]
		MakingChoice_End,
		// Token: 0x040088FC RID: 35068
		[Token(Token = "0x4019E4E")]
		MakingChoiceAdv_End,
		// Token: 0x040088FD RID: 35069
		[Token(Token = "0x4019E4F")]
		Making_SeedPoint,
		// Token: 0x040088FE RID: 35070
		[Token(Token = "0x4019E50")]
		Making_Stone,
		// Token: 0x040088FF RID: 35071
		[Token(Token = "0x4019E51")]
		Making_Lumber,
		// Token: 0x04008900 RID: 35072
		[Token(Token = "0x4019E52")]
		Making_Gold,
		// Token: 0x04008901 RID: 35073
		[Token(Token = "0x4019E53")]
		Making_Success,
		// Token: 0x04008902 RID: 35074
		[Token(Token = "0x4019E54")]
		Making_NoPoint,
		// Token: 0x04008903 RID: 35075
		[Token(Token = "0x4019E55")]
		Making_NotEnough,
		// Token: 0x04008904 RID: 35076
		[Token(Token = "0x4019E56")]
		Making_FestivalThisSeason,
		// Token: 0x04008905 RID: 35077
		[Token(Token = "0x4019E57")]
		Making_FestivalNextSeason,
		// Token: 0x04008906 RID: 35078
		[Token(Token = "0x4019E58")]
		Making_SPRING,
		// Token: 0x04008907 RID: 35079
		[Token(Token = "0x4019E59")]
		Making_SUMMER,
		// Token: 0x04008908 RID: 35080
		[Token(Token = "0x4019E5A")]
		Making_AUTUMN,
		// Token: 0x04008909 RID: 35081
		[Token(Token = "0x4019E5B")]
		Making_WINTER,
		// Token: 0x0400890A RID: 35082
		[Token(Token = "0x4019E5C")]
		MakingChoice_FesCost,
		// Token: 0x0400890B RID: 35083
		[Token(Token = "0x4019E5D")]
		MakingChoice_Cost,
		// Token: 0x0400890C RID: 35084
		[Token(Token = "0x4019E5E")]
		MakingSelectSave_DoSelect,
		// Token: 0x0400890D RID: 35085
		[Token(Token = "0x4019E5F")]
		MakingSelectSave_Cancel,
		// Token: 0x0400890E RID: 35086
		[Token(Token = "0x4019E60")]
		MakingAdv_OnStart,
		// Token: 0x0400890F RID: 35087
		[Token(Token = "0x4019E61")]
		MakingAdv_FesOpen,
		// Token: 0x04008910 RID: 35088
		[Token(Token = "0x4019E62")]
		MakingAdv_FesClose,
		// Token: 0x04008911 RID: 35089
		[Token(Token = "0x4019E63")]
		MakingAdv_Cancel,
		// Token: 0x04008912 RID: 35090
		[Token(Token = "0x4019E64")]
		MakingAdv_NoHat,
		// Token: 0x04008913 RID: 35091
		[Token(Token = "0x4019E65")]
		MakingAdv_ChoiceHat,
		// Token: 0x04008914 RID: 35092
		[Token(Token = "0x4019E66")]
		MakingAdv_Save01,
		// Token: 0x04008915 RID: 35093
		[Token(Token = "0x4019E67")]
		MakingAdv_Save02,
		// Token: 0x04008916 RID: 35094
		[Token(Token = "0x4019E68")]
		MakingAdv_Save03,
		// Token: 0x04008917 RID: 35095
		[Token(Token = "0x4019E69")]
		MakingAdv_Save04,
		// Token: 0x04008918 RID: 35096
		[Token(Token = "0x4019E6A")]
		MakingAdv_SelectVilla,
		// Token: 0x04008919 RID: 35097
		[Token(Token = "0x4019E6B")]
		MakingAdv_MyShop_FurnitureFull,
		// Token: 0x0400891A RID: 35098
		[Token(Token = "0x4019E6C")]
		MakingAdv_Build,
		// Token: 0x0400891B RID: 35099
		[Token(Token = "0x4019E6D")]
		MakingAdv_WhatMake,
		// Token: 0x0400891C RID: 35100
		[Token(Token = "0x4019E6E")]
		MakingAdv_Rune,
		// Token: 0x0400891D RID: 35101
		[Token(Token = "0x4019E6F")]
		MakingChoiceAdv_MakingExtra174,
		// Token: 0x0400891E RID: 35102
		[Token(Token = "0x4019E70")]
		MakingAfterAdv_MakingExtra174,
		// Token: 0x0400891F RID: 35103
		[Token(Token = "0x4019E71")]
		MakingChoice_MakingExtra174,
		// Token: 0x04008920 RID: 35104
		[Token(Token = "0x4019E72")]
		MAP_WARPHEAD = 10000,
		// Token: 0x04008921 RID: 35105
		[Token(Token = "0x4019E73")]
		MAP_WARPFLOORHEAD,
		// Token: 0x04008922 RID: 35106
		[Token(Token = "0x4019E74")]
		MAP_WARPPOPUPCHOICE_HEAD,
		// Token: 0x04008923 RID: 35107
		[Token(Token = "0x4019E75")]
		MAP_DUNGEONOPEN,
		// Token: 0x04008924 RID: 35108
		[Token(Token = "0x4019E76")]
		CRAFT_NOTFREESPACE = 11000,
		// Token: 0x04008925 RID: 35109
		[Token(Token = "0x4019E77")]
		CRAFT_USERP,
		// Token: 0x04008926 RID: 35110
		[Token(Token = "0x4019E78")]
		CRAFT_TITLE_COOK,
		// Token: 0x04008927 RID: 35111
		[Token(Token = "0x4019E79")]
		CRAFT_TITLE_DRUG,
		// Token: 0x04008928 RID: 35112
		[Token(Token = "0x4019E7A")]
		CRAFT_TITLE_SMITH,
		// Token: 0x04008929 RID: 35113
		[Token(Token = "0x4019E7B")]
		CRAFT_TITLE_ARMOR,
		// Token: 0x0400892A RID: 35114
		[Token(Token = "0x4019E7C")]
		CRAFT_BASE_RPCOST,
		// Token: 0x0400892B RID: 35115
		[Token(Token = "0x4019E7D")]
		CRAFT_DUALWORK_BLACKSMITH,
		// Token: 0x0400892C RID: 35116
		[Token(Token = "0x4019E7E")]
		CRAFT_DUALWORK_COOK,
		// Token: 0x0400892D RID: 35117
		[Token(Token = "0x4019E7F")]
		CRAFT_DUALWORK_FISHING,
		// Token: 0x0400892E RID: 35118
		[Token(Token = "0x4019E80")]
		CRAFT_NOTENOUGHRP,
		// Token: 0x0400892F RID: 35119
		[Token(Token = "0x4019E81")]
		CRAFT_NOTENOUGHHP,
		// Token: 0x04008930 RID: 35120
		[Token(Token = "0x4019E82")]
		CRAFT_NOTUSE_RECIPE,
		// Token: 0x04008931 RID: 35121
		[Token(Token = "0x4019E83")]
		CRAFT_BUTTON_OK,
		// Token: 0x04008932 RID: 35122
		[Token(Token = "0x4019E84")]
		CRAFT_DUALWORK_BLACKSMITH_CONTENTS,
		// Token: 0x04008933 RID: 35123
		[Token(Token = "0x4019E85")]
		CRAFT_DUALWORK_COOK_CONTENTS,
		// Token: 0x04008934 RID: 35124
		[Token(Token = "0x4019E86")]
		CRAFT_BUTTON_SKIP,
		// Token: 0x04008935 RID: 35125
		[Token(Token = "0x4019E87")]
		ClothShop_01_Male = 12000,
		// Token: 0x04008936 RID: 35126
		[Token(Token = "0x4019E88")]
		ClothShop_02_Male,
		// Token: 0x04008937 RID: 35127
		[Token(Token = "0x4019E89")]
		ClothShop_03_Male,
		// Token: 0x04008938 RID: 35128
		[Token(Token = "0x4019E8A")]
		ClothShop_04_Male,
		// Token: 0x04008939 RID: 35129
		[Token(Token = "0x4019E8B")]
		ClothShop_05_Male,
		// Token: 0x0400893A RID: 35130
		[Token(Token = "0x4019E8C")]
		ClothShop_06_Male,
		// Token: 0x0400893B RID: 35131
		[Token(Token = "0x4019E8D")]
		ClothShop_07_Male,
		// Token: 0x0400893C RID: 35132
		[Token(Token = "0x4019E8E")]
		ClothShop_08_Male,
		// Token: 0x0400893D RID: 35133
		[Token(Token = "0x4019E8F")]
		ClothShop_09_Male,
		// Token: 0x0400893E RID: 35134
		[Token(Token = "0x4019E90")]
		ClothShop_10_Male,
		// Token: 0x0400893F RID: 35135
		[Token(Token = "0x4019E91")]
		ClothShop_11_Male,
		// Token: 0x04008940 RID: 35136
		[Token(Token = "0x4019E92")]
		ClothShop_12_Male,
		// Token: 0x04008941 RID: 35137
		[Token(Token = "0x4019E93")]
		ClothShop_13_Male,
		// Token: 0x04008942 RID: 35138
		[Token(Token = "0x4019E94")]
		ClothShop_14_Male,
		// Token: 0x04008943 RID: 35139
		[Token(Token = "0x4019E95")]
		ClothShop_15_Male,
		// Token: 0x04008944 RID: 35140
		[Token(Token = "0x4019E96")]
		ClothShop_16_Male,
		// Token: 0x04008945 RID: 35141
		[Token(Token = "0x4019E97")]
		ClothShop_01_Female,
		// Token: 0x04008946 RID: 35142
		[Token(Token = "0x4019E98")]
		ClothShop_02_Female,
		// Token: 0x04008947 RID: 35143
		[Token(Token = "0x4019E99")]
		ClothShop_03_Female,
		// Token: 0x04008948 RID: 35144
		[Token(Token = "0x4019E9A")]
		ClothShop_04_Female,
		// Token: 0x04008949 RID: 35145
		[Token(Token = "0x4019E9B")]
		ClothShop_05_Female,
		// Token: 0x0400894A RID: 35146
		[Token(Token = "0x4019E9C")]
		ClothShop_06_Female,
		// Token: 0x0400894B RID: 35147
		[Token(Token = "0x4019E9D")]
		ClothShop_07_Female,
		// Token: 0x0400894C RID: 35148
		[Token(Token = "0x4019E9E")]
		ClothShop_08_Female,
		// Token: 0x0400894D RID: 35149
		[Token(Token = "0x4019E9F")]
		ClothShop_09_Female,
		// Token: 0x0400894E RID: 35150
		[Token(Token = "0x4019EA0")]
		ClothShop_10_Female,
		// Token: 0x0400894F RID: 35151
		[Token(Token = "0x4019EA1")]
		ClothShop_11_Female,
		// Token: 0x04008950 RID: 35152
		[Token(Token = "0x4019EA2")]
		ClothShop_12_Female,
		// Token: 0x04008951 RID: 35153
		[Token(Token = "0x4019EA3")]
		ClothShop_13_Female,
		// Token: 0x04008952 RID: 35154
		[Token(Token = "0x4019EA4")]
		ClothShop_14_Female,
		// Token: 0x04008953 RID: 35155
		[Token(Token = "0x4019EA5")]
		ClothShop_15_Female,
		// Token: 0x04008954 RID: 35156
		[Token(Token = "0x4019EA6")]
		ClothShop_16_Female,
		// Token: 0x04008955 RID: 35157
		[Token(Token = "0x4019EA7")]
		ClothShop_17_Male,
		// Token: 0x04008956 RID: 35158
		[Token(Token = "0x4019EA8")]
		ClothShop_18_Male,
		// Token: 0x04008957 RID: 35159
		[Token(Token = "0x4019EA9")]
		ClothShop_19_Male,
		// Token: 0x04008958 RID: 35160
		[Token(Token = "0x4019EAA")]
		ClothShop_20_Male,
		// Token: 0x04008959 RID: 35161
		[Token(Token = "0x4019EAB")]
		ClothShop_21_Male,
		// Token: 0x0400895A RID: 35162
		[Token(Token = "0x4019EAC")]
		ClothShop_22_Male,
		// Token: 0x0400895B RID: 35163
		[Token(Token = "0x4019EAD")]
		ClothShop_23_Male,
		// Token: 0x0400895C RID: 35164
		[Token(Token = "0x4019EAE")]
		ClothShop_17_Female,
		// Token: 0x0400895D RID: 35165
		[Token(Token = "0x4019EAF")]
		ClothShop_18_Female,
		// Token: 0x0400895E RID: 35166
		[Token(Token = "0x4019EB0")]
		ClothShop_19_Female,
		// Token: 0x0400895F RID: 35167
		[Token(Token = "0x4019EB1")]
		ClothShop_20_Female,
		// Token: 0x04008960 RID: 35168
		[Token(Token = "0x4019EB2")]
		ClothShop_21_Female,
		// Token: 0x04008961 RID: 35169
		[Token(Token = "0x4019EB3")]
		ClothShop_22_Female,
		// Token: 0x04008962 RID: 35170
		[Token(Token = "0x4019EB4")]
		ClothShop_23_Female,
		// Token: 0x04008963 RID: 35171
		[Token(Token = "0x4019EB5")]
		ClothShop_24_Female,
		// Token: 0x04008964 RID: 35172
		[Token(Token = "0x4019EB6")]
		Costume_000_Male,
		// Token: 0x04008965 RID: 35173
		[Token(Token = "0x4019EB7")]
		Costume_001_Male,
		// Token: 0x04008966 RID: 35174
		[Token(Token = "0x4019EB8")]
		Costume_002_Male,
		// Token: 0x04008967 RID: 35175
		[Token(Token = "0x4019EB9")]
		Costume_005_Male,
		// Token: 0x04008968 RID: 35176
		[Token(Token = "0x4019EBA")]
		Costume_006_Male,
		// Token: 0x04008969 RID: 35177
		[Token(Token = "0x4019EBB")]
		Costume_029_Male,
		// Token: 0x0400896A RID: 35178
		[Token(Token = "0x4019EBC")]
		Costume_030_Male,
		// Token: 0x0400896B RID: 35179
		[Token(Token = "0x4019EBD")]
		Costume_031_Male,
		// Token: 0x0400896C RID: 35180
		[Token(Token = "0x4019EBE")]
		Costume_032_Male,
		// Token: 0x0400896D RID: 35181
		[Token(Token = "0x4019EBF")]
		Costume_033_Male,
		// Token: 0x0400896E RID: 35182
		[Token(Token = "0x4019EC0")]
		Costume_034_Male,
		// Token: 0x0400896F RID: 35183
		[Token(Token = "0x4019EC1")]
		Costume_035_Male,
		// Token: 0x04008970 RID: 35184
		[Token(Token = "0x4019EC2")]
		Costume_000_Female,
		// Token: 0x04008971 RID: 35185
		[Token(Token = "0x4019EC3")]
		Costume_001_Female,
		// Token: 0x04008972 RID: 35186
		[Token(Token = "0x4019EC4")]
		Costume_002_Female,
		// Token: 0x04008973 RID: 35187
		[Token(Token = "0x4019EC5")]
		Costume_005_Female,
		// Token: 0x04008974 RID: 35188
		[Token(Token = "0x4019EC6")]
		Costume_006_Female,
		// Token: 0x04008975 RID: 35189
		[Token(Token = "0x4019EC7")]
		Costume_029_Female,
		// Token: 0x04008976 RID: 35190
		[Token(Token = "0x4019EC8")]
		Costume_030_Female,
		// Token: 0x04008977 RID: 35191
		[Token(Token = "0x4019EC9")]
		Costume_031_Female,
		// Token: 0x04008978 RID: 35192
		[Token(Token = "0x4019ECA")]
		Costume_032_Female,
		// Token: 0x04008979 RID: 35193
		[Token(Token = "0x4019ECB")]
		Costume_033_Female,
		// Token: 0x0400897A RID: 35194
		[Token(Token = "0x4019ECC")]
		Costume_034_Female,
		// Token: 0x0400897B RID: 35195
		[Token(Token = "0x4019ECD")]
		Costume_035_Female,
		// Token: 0x0400897C RID: 35196
		[Token(Token = "0x4019ECE")]
		Costume_036_Female,
		// Token: 0x0400897D RID: 35197
		[Token(Token = "0x4019ECF")]
		HotSpring_00,
		// Token: 0x0400897E RID: 35198
		[Token(Token = "0x4019ED0")]
		HotSpring_01,
		// Token: 0x0400897F RID: 35199
		[Token(Token = "0x4019ED1")]
		HotSpring_02,
		// Token: 0x04008980 RID: 35200
		[Token(Token = "0x4019ED2")]
		HotSpring_03,
		// Token: 0x04008981 RID: 35201
		[Token(Token = "0x4019ED3")]
		HotSpring_04,
		// Token: 0x04008982 RID: 35202
		[Token(Token = "0x4019ED4")]
		HotSpring_05,
		// Token: 0x04008983 RID: 35203
		[Token(Token = "0x4019ED5")]
		Vaccination_01,
		// Token: 0x04008984 RID: 35204
		[Token(Token = "0x4019ED6")]
		Vaccination_02,
		// Token: 0x04008985 RID: 35205
		[Token(Token = "0x4019ED7")]
		Vaccination_03,
		// Token: 0x04008986 RID: 35206
		[Token(Token = "0x4019ED8")]
		Vaccination_04,
		// Token: 0x04008987 RID: 35207
		[Token(Token = "0x4019ED9")]
		Vaccination_05,
		// Token: 0x04008988 RID: 35208
		[Token(Token = "0x4019EDA")]
		Vaccination_06,
		// Token: 0x04008989 RID: 35209
		[Token(Token = "0x4019EDB")]
		Vaccination_07,
		// Token: 0x0400898A RID: 35210
		[Token(Token = "0x4019EDC")]
		Crystal_01,
		// Token: 0x0400898B RID: 35211
		[Token(Token = "0x4019EDD")]
		Crystal_02,
		// Token: 0x0400898C RID: 35212
		[Token(Token = "0x4019EDE")]
		Crystal_03,
		// Token: 0x0400898D RID: 35213
		[Token(Token = "0x4019EDF")]
		Crystal_04,
		// Token: 0x0400898E RID: 35214
		[Token(Token = "0x4019EE0")]
		Crystal_05,
		// Token: 0x0400898F RID: 35215
		[Token(Token = "0x4019EE1")]
		Release_Category_Cook,
		// Token: 0x04008990 RID: 35216
		[Token(Token = "0x4019EE2")]
		Release_Category_Sword,
		// Token: 0x04008991 RID: 35217
		[Token(Token = "0x4019EE3")]
		Release_Category_DHSword,
		// Token: 0x04008992 RID: 35218
		[Token(Token = "0x4019EE4")]
		Release_Category_Spear,
		// Token: 0x04008993 RID: 35219
		[Token(Token = "0x4019EE5")]
		Release_Category_Ax,
		// Token: 0x04008994 RID: 35220
		[Token(Token = "0x4019EE6")]
		Release_Category_Hammer,
		// Token: 0x04008995 RID: 35221
		[Token(Token = "0x4019EE7")]
		Release_Category_TwinSword,
		// Token: 0x04008996 RID: 35222
		[Token(Token = "0x4019EE8")]
		Release_Category_Fist,
		// Token: 0x04008997 RID: 35223
		[Token(Token = "0x4019EE9")]
		Release_Category_Wand,
		// Token: 0x04008998 RID: 35224
		[Token(Token = "0x4019EEA")]
		Release_Category_FarmTool,
		// Token: 0x04008999 RID: 35225
		[Token(Token = "0x4019EEB")]
		Release_Category_Shield,
		// Token: 0x0400899A RID: 35226
		[Token(Token = "0x4019EEC")]
		Release_Category_Accessory,
		// Token: 0x0400899B RID: 35227
		[Token(Token = "0x4019EED")]
		Release_Category_Hat,
		// Token: 0x0400899C RID: 35228
		[Token(Token = "0x4019EEE")]
		Release_Category_Shoes,
		// Token: 0x0400899D RID: 35229
		[Token(Token = "0x4019EEF")]
		Release_Category_Armar,
		// Token: 0x0400899E RID: 35230
		[Token(Token = "0x4019EF0")]
		Release_Category_Drug,
		// Token: 0x0400899F RID: 35231
		[Token(Token = "0x4019EF1")]
		Release_Furniture_00,
		// Token: 0x040089A0 RID: 35232
		[Token(Token = "0x4019EF2")]
		Release_Furniture_01,
		// Token: 0x040089A1 RID: 35233
		[Token(Token = "0x4019EF3")]
		Release_Furniture_02,
		// Token: 0x040089A2 RID: 35234
		[Token(Token = "0x4019EF4")]
		Release_Furniture_03,
		// Token: 0x040089A3 RID: 35235
		[Token(Token = "0x4019EF5")]
		Release_Furniture_04,
		// Token: 0x040089A4 RID: 35236
		[Token(Token = "0x4019EF6")]
		Release_Furniture_05,
		// Token: 0x040089A5 RID: 35237
		[Token(Token = "0x4019EF7")]
		Release_Furniture_06,
		// Token: 0x040089A6 RID: 35238
		[Token(Token = "0x4019EF8")]
		Release_Furniture_07,
		// Token: 0x040089A7 RID: 35239
		[Token(Token = "0x4019EF9")]
		Release_Furniture_08,
		// Token: 0x040089A8 RID: 35240
		[Token(Token = "0x4019EFA")]
		Release_Furniture_09,
		// Token: 0x040089A9 RID: 35241
		[Token(Token = "0x4019EFB")]
		Release_Fail_Hint_Cook,
		// Token: 0x040089AA RID: 35242
		[Token(Token = "0x4019EFC")]
		Release_Fail_Hint_BlackSmith,
		// Token: 0x040089AB RID: 35243
		[Token(Token = "0x4019EFD")]
		Release_Fail_Hint_Deco,
		// Token: 0x040089AC RID: 35244
		[Token(Token = "0x4019EFE")]
		Release_Fail_Hint_Drug,
		// Token: 0x040089AD RID: 35245
		[Token(Token = "0x4019EFF")]
		Release_Fail_Hint_Farm,
		// Token: 0x040089AE RID: 35246
		[Token(Token = "0x4019F00")]
		HotSpring_01_tips,
		// Token: 0x040089AF RID: 35247
		[Token(Token = "0x4019F01")]
		HotSpring_02_tips,
		// Token: 0x040089B0 RID: 35248
		[Token(Token = "0x4019F02")]
		HotSpring_03_tips,
		// Token: 0x040089B1 RID: 35249
		[Token(Token = "0x4019F03")]
		HotSpring_04_tips,
		// Token: 0x040089B2 RID: 35250
		[Token(Token = "0x4019F04")]
		HotSpring_05_tips,
		// Token: 0x040089B3 RID: 35251
		[Token(Token = "0x4019F05")]
		Vaccination_01_tips,
		// Token: 0x040089B4 RID: 35252
		[Token(Token = "0x4019F06")]
		Vaccination_02_tips,
		// Token: 0x040089B5 RID: 35253
		[Token(Token = "0x4019F07")]
		Vaccination_03_tips,
		// Token: 0x040089B6 RID: 35254
		[Token(Token = "0x4019F08")]
		Vaccination_04_tips,
		// Token: 0x040089B7 RID: 35255
		[Token(Token = "0x4019F09")]
		Vaccination_05_tips,
		// Token: 0x040089B8 RID: 35256
		[Token(Token = "0x4019F0A")]
		Vaccination_06_tips,
		// Token: 0x040089B9 RID: 35257
		[Token(Token = "0x4019F0B")]
		Vaccination_07_tips,
		// Token: 0x040089BA RID: 35258
		[Token(Token = "0x4019F0C")]
		HotSpringField_01_tips,
		// Token: 0x040089BB RID: 35259
		[Token(Token = "0x4019F0D")]
		HotSpringField_02_tips,
		// Token: 0x040089BC RID: 35260
		[Token(Token = "0x4019F0E")]
		HotSpringField_03_tips,
		// Token: 0x040089BD RID: 35261
		[Token(Token = "0x4019F0F")]
		HotSpringField_04_tips,
		// Token: 0x040089BE RID: 35262
		[Token(Token = "0x4019F10")]
		OrderBorad = 13008,
		// Token: 0x040089BF RID: 35263
		[Token(Token = "0x4019F11")]
		OrderRequestNpc,
		// Token: 0x040089C0 RID: 35264
		[Token(Token = "0x4019F12")]
		OrderContent,
		// Token: 0x040089C1 RID: 35265
		[Token(Token = "0x4019F13")]
		OrderReward,
		// Token: 0x040089C2 RID: 35266
		[Token(Token = "0x4019F14")]
		Order_NoAnySpace = 13078,
		// Token: 0x040089C3 RID: 35267
		[Token(Token = "0x4019F15")]
		Order_ConfirmAccept,
		// Token: 0x040089C4 RID: 35268
		[Token(Token = "0x4019F16")]
		Order_AllAcceptedToday,
		// Token: 0x040089C5 RID: 35269
		[Token(Token = "0x4019F17")]
		SORT_ITEM_00 = 14000,
		// Token: 0x040089C6 RID: 35270
		[Token(Token = "0x4019F18")]
		SORT_ITEM_01,
		// Token: 0x040089C7 RID: 35271
		[Token(Token = "0x4019F19")]
		SORT_ITEM_02,
		// Token: 0x040089C8 RID: 35272
		[Token(Token = "0x4019F1A")]
		SORT_ITEM_03,
		// Token: 0x040089C9 RID: 35273
		[Token(Token = "0x4019F1B")]
		SORT_ITEM_04,
		// Token: 0x040089CA RID: 35274
		[Token(Token = "0x4019F1C")]
		SORT_ITEM_05,
		// Token: 0x040089CB RID: 35275
		[Token(Token = "0x4019F1D")]
		SORT_FRIENDLIST_00,
		// Token: 0x040089CC RID: 35276
		[Token(Token = "0x4019F1E")]
		SORT_FRIENDLIST_01,
		// Token: 0x040089CD RID: 35277
		[Token(Token = "0x4019F1F")]
		SORT_SHIPMENT_00,
		// Token: 0x040089CE RID: 35278
		[Token(Token = "0x4019F20")]
		SORT_SHIPMENT_01,
		// Token: 0x040089CF RID: 35279
		[Token(Token = "0x4019F21")]
		SORT_SHIPMENT_02,
		// Token: 0x040089D0 RID: 35280
		[Token(Token = "0x4019F22")]
		SORT_RECIPE_00,
		// Token: 0x040089D1 RID: 35281
		[Token(Token = "0x4019F23")]
		SORT_CANCEL,
		// Token: 0x040089D2 RID: 35282
		[Token(Token = "0x4019F24")]
		SEEDRANK_00 = 15000,
		// Token: 0x040089D3 RID: 35283
		[Token(Token = "0x4019F25")]
		SEEDRANK_01,
		// Token: 0x040089D4 RID: 35284
		[Token(Token = "0x4019F26")]
		SEEDRANK_02,
		// Token: 0x040089D5 RID: 35285
		[Token(Token = "0x4019F27")]
		SEEDRANK_03,
		// Token: 0x040089D6 RID: 35286
		[Token(Token = "0x4019F28")]
		SEEDRANK_04,
		// Token: 0x040089D7 RID: 35287
		[Token(Token = "0x4019F29")]
		SEEDRANK_05,
		// Token: 0x040089D8 RID: 35288
		[Token(Token = "0x4019F2A")]
		FURNITURE_NAME_001 = 16000,
		// Token: 0x040089D9 RID: 35289
		[Token(Token = "0x4019F2B")]
		FURNITURE_NAME_002,
		// Token: 0x040089DA RID: 35290
		[Token(Token = "0x4019F2C")]
		FURNITURE_NAME_003,
		// Token: 0x040089DB RID: 35291
		[Token(Token = "0x4019F2D")]
		FURNITURE_NAME_004,
		// Token: 0x040089DC RID: 35292
		[Token(Token = "0x4019F2E")]
		FURNITURE_NAME_005,
		// Token: 0x040089DD RID: 35293
		[Token(Token = "0x4019F2F")]
		FURNITURE_NAME_006,
		// Token: 0x040089DE RID: 35294
		[Token(Token = "0x4019F30")]
		FURNITURE_NAME_007,
		// Token: 0x040089DF RID: 35295
		[Token(Token = "0x4019F31")]
		FURNITURE_NAME_008,
		// Token: 0x040089E0 RID: 35296
		[Token(Token = "0x4019F32")]
		FURNITURE_NAME_009,
		// Token: 0x040089E1 RID: 35297
		[Token(Token = "0x4019F33")]
		FURNITURE_NAME_010,
		// Token: 0x040089E2 RID: 35298
		[Token(Token = "0x4019F34")]
		FURNITURE_NAME_011,
		// Token: 0x040089E3 RID: 35299
		[Token(Token = "0x4019F35")]
		FURNITURE_NAME_012,
		// Token: 0x040089E4 RID: 35300
		[Token(Token = "0x4019F36")]
		FURNITURE_NAME_013,
		// Token: 0x040089E5 RID: 35301
		[Token(Token = "0x4019F37")]
		FURNITURE_NAME_014,
		// Token: 0x040089E6 RID: 35302
		[Token(Token = "0x4019F38")]
		FURNITURE_NAME_015,
		// Token: 0x040089E7 RID: 35303
		[Token(Token = "0x4019F39")]
		FURNITURE_NAME_016,
		// Token: 0x040089E8 RID: 35304
		[Token(Token = "0x4019F3A")]
		FURNITURE_NAME_017,
		// Token: 0x040089E9 RID: 35305
		[Token(Token = "0x4019F3B")]
		FURNITURE_NAME_018,
		// Token: 0x040089EA RID: 35306
		[Token(Token = "0x4019F3C")]
		FURNITURE_NAME_019,
		// Token: 0x040089EB RID: 35307
		[Token(Token = "0x4019F3D")]
		FURNITURE_NAME_020,
		// Token: 0x040089EC RID: 35308
		[Token(Token = "0x4019F3E")]
		FURNITURE_NAME_021,
		// Token: 0x040089ED RID: 35309
		[Token(Token = "0x4019F3F")]
		FURNITURE_NAME_022,
		// Token: 0x040089EE RID: 35310
		[Token(Token = "0x4019F40")]
		FURNITURE_NAME_023,
		// Token: 0x040089EF RID: 35311
		[Token(Token = "0x4019F41")]
		FURNITURE_NAME_024,
		// Token: 0x040089F0 RID: 35312
		[Token(Token = "0x4019F42")]
		FURNITURE_NAME_025,
		// Token: 0x040089F1 RID: 35313
		[Token(Token = "0x4019F43")]
		FURNITURE_NAME_026,
		// Token: 0x040089F2 RID: 35314
		[Token(Token = "0x4019F44")]
		FURNITURE_NAME_027,
		// Token: 0x040089F3 RID: 35315
		[Token(Token = "0x4019F45")]
		FURNITURE_NAME_028,
		// Token: 0x040089F4 RID: 35316
		[Token(Token = "0x4019F46")]
		FURNITURE_NAME_029,
		// Token: 0x040089F5 RID: 35317
		[Token(Token = "0x4019F47")]
		FURNITURE_NAME_030,
		// Token: 0x040089F6 RID: 35318
		[Token(Token = "0x4019F48")]
		FURNITURE_NAME_031,
		// Token: 0x040089F7 RID: 35319
		[Token(Token = "0x4019F49")]
		FURNITURE_NAME_032,
		// Token: 0x040089F8 RID: 35320
		[Token(Token = "0x4019F4A")]
		FURNITURE_NAME_033,
		// Token: 0x040089F9 RID: 35321
		[Token(Token = "0x4019F4B")]
		FURNITURE_NAME_034,
		// Token: 0x040089FA RID: 35322
		[Token(Token = "0x4019F4C")]
		FURNITURE_NAME_035,
		// Token: 0x040089FB RID: 35323
		[Token(Token = "0x4019F4D")]
		FURNITURE_NAME_036,
		// Token: 0x040089FC RID: 35324
		[Token(Token = "0x4019F4E")]
		FURNITURE_NAME_037,
		// Token: 0x040089FD RID: 35325
		[Token(Token = "0x4019F4F")]
		FURNITURE_NAME_038,
		// Token: 0x040089FE RID: 35326
		[Token(Token = "0x4019F50")]
		FURNITURE_NAME_039,
		// Token: 0x040089FF RID: 35327
		[Token(Token = "0x4019F51")]
		FURNITURE_NAME_040,
		// Token: 0x04008A00 RID: 35328
		[Token(Token = "0x4019F52")]
		FURNITURE_NAME_041,
		// Token: 0x04008A01 RID: 35329
		[Token(Token = "0x4019F53")]
		FURNITURE_NAME_042,
		// Token: 0x04008A02 RID: 35330
		[Token(Token = "0x4019F54")]
		FURNITURE_NAME_043,
		// Token: 0x04008A03 RID: 35331
		[Token(Token = "0x4019F55")]
		FURNITURE_NAME_044,
		// Token: 0x04008A04 RID: 35332
		[Token(Token = "0x4019F56")]
		FURNITURE_NAME_045,
		// Token: 0x04008A05 RID: 35333
		[Token(Token = "0x4019F57")]
		FURNITURE_NAME_046,
		// Token: 0x04008A06 RID: 35334
		[Token(Token = "0x4019F58")]
		FURNITURE_NAME_047,
		// Token: 0x04008A07 RID: 35335
		[Token(Token = "0x4019F59")]
		FURNITURE_NAME_048,
		// Token: 0x04008A08 RID: 35336
		[Token(Token = "0x4019F5A")]
		FURNITURE_NAME_049,
		// Token: 0x04008A09 RID: 35337
		[Token(Token = "0x4019F5B")]
		FURNITURE_NAME_050,
		// Token: 0x04008A0A RID: 35338
		[Token(Token = "0x4019F5C")]
		FURNITURE_NAME_051,
		// Token: 0x04008A0B RID: 35339
		[Token(Token = "0x4019F5D")]
		FURNITURE_NAME_052,
		// Token: 0x04008A0C RID: 35340
		[Token(Token = "0x4019F5E")]
		FURNITURE_NAME_053,
		// Token: 0x04008A0D RID: 35341
		[Token(Token = "0x4019F5F")]
		FURNITURE_NAME_054,
		// Token: 0x04008A0E RID: 35342
		[Token(Token = "0x4019F60")]
		FURNITURE_NAME_055,
		// Token: 0x04008A0F RID: 35343
		[Token(Token = "0x4019F61")]
		FURNITURE_NAME_056,
		// Token: 0x04008A10 RID: 35344
		[Token(Token = "0x4019F62")]
		FURNITURE_NAME_057,
		// Token: 0x04008A11 RID: 35345
		[Token(Token = "0x4019F63")]
		FURNITURE_NAME_058,
		// Token: 0x04008A12 RID: 35346
		[Token(Token = "0x4019F64")]
		FURNITURE_NAME_059,
		// Token: 0x04008A13 RID: 35347
		[Token(Token = "0x4019F65")]
		FURNITURE_NAME_060,
		// Token: 0x04008A14 RID: 35348
		[Token(Token = "0x4019F66")]
		FURNITURE_NAME_061,
		// Token: 0x04008A15 RID: 35349
		[Token(Token = "0x4019F67")]
		FURNITURE_NAME_062,
		// Token: 0x04008A16 RID: 35350
		[Token(Token = "0x4019F68")]
		FURNITURE_NAME_063,
		// Token: 0x04008A17 RID: 35351
		[Token(Token = "0x4019F69")]
		FURNITURE_NAME_064,
		// Token: 0x04008A18 RID: 35352
		[Token(Token = "0x4019F6A")]
		FURNITURE_NAME_065,
		// Token: 0x04008A19 RID: 35353
		[Token(Token = "0x4019F6B")]
		FURNITURE_NAME_066,
		// Token: 0x04008A1A RID: 35354
		[Token(Token = "0x4019F6C")]
		FURNITURE_NAME_067,
		// Token: 0x04008A1B RID: 35355
		[Token(Token = "0x4019F6D")]
		FURNITURE_NAME_068,
		// Token: 0x04008A1C RID: 35356
		[Token(Token = "0x4019F6E")]
		FURNITURE_NAME_069,
		// Token: 0x04008A1D RID: 35357
		[Token(Token = "0x4019F6F")]
		FURNITURE_NAME_070,
		// Token: 0x04008A1E RID: 35358
		[Token(Token = "0x4019F70")]
		FURNITURE_NAME_071,
		// Token: 0x04008A1F RID: 35359
		[Token(Token = "0x4019F71")]
		FURNITURE_NAME_072,
		// Token: 0x04008A20 RID: 35360
		[Token(Token = "0x4019F72")]
		FURNITURE_NAME_073,
		// Token: 0x04008A21 RID: 35361
		[Token(Token = "0x4019F73")]
		FURNITURE_NAME_074,
		// Token: 0x04008A22 RID: 35362
		[Token(Token = "0x4019F74")]
		FURNITURE_NAME_075,
		// Token: 0x04008A23 RID: 35363
		[Token(Token = "0x4019F75")]
		FURNITURE_NAME_076,
		// Token: 0x04008A24 RID: 35364
		[Token(Token = "0x4019F76")]
		FURNITURE_NAME_077,
		// Token: 0x04008A25 RID: 35365
		[Token(Token = "0x4019F77")]
		FURNITURE_NAME_078,
		// Token: 0x04008A26 RID: 35366
		[Token(Token = "0x4019F78")]
		FURNITURE_NAME_079,
		// Token: 0x04008A27 RID: 35367
		[Token(Token = "0x4019F79")]
		FURNITURE_NAME_080,
		// Token: 0x04008A28 RID: 35368
		[Token(Token = "0x4019F7A")]
		FURNITURE_NAME_990,
		// Token: 0x04008A29 RID: 35369
		[Token(Token = "0x4019F7B")]
		FURNITURE_NAME_998,
		// Token: 0x04008A2A RID: 35370
		[Token(Token = "0x4019F7C")]
		FURNITURE_NAME_999,
		// Token: 0x04008A2B RID: 35371
		[Token(Token = "0x4019F7D")]
		BGM_NAME_000 = 17000,
		// Token: 0x04008A2C RID: 35372
		[Token(Token = "0x4019F7E")]
		BGM_NAME_001,
		// Token: 0x04008A2D RID: 35373
		[Token(Token = "0x4019F7F")]
		BGM_NAME_002,
		// Token: 0x04008A2E RID: 35374
		[Token(Token = "0x4019F80")]
		BGM_NAME_003,
		// Token: 0x04008A2F RID: 35375
		[Token(Token = "0x4019F81")]
		BGM_NAME_004,
		// Token: 0x04008A30 RID: 35376
		[Token(Token = "0x4019F82")]
		BGM_NAME_005,
		// Token: 0x04008A31 RID: 35377
		[Token(Token = "0x4019F83")]
		BGM_NAME_006,
		// Token: 0x04008A32 RID: 35378
		[Token(Token = "0x4019F84")]
		BGM_NAME_007,
		// Token: 0x04008A33 RID: 35379
		[Token(Token = "0x4019F85")]
		BGM_NAME_008,
		// Token: 0x04008A34 RID: 35380
		[Token(Token = "0x4019F86")]
		BGM_NAME_009,
		// Token: 0x04008A35 RID: 35381
		[Token(Token = "0x4019F87")]
		BGM_NAME_010,
		// Token: 0x04008A36 RID: 35382
		[Token(Token = "0x4019F88")]
		BGM_NAME_011,
		// Token: 0x04008A37 RID: 35383
		[Token(Token = "0x4019F89")]
		BGM_NAME_012,
		// Token: 0x04008A38 RID: 35384
		[Token(Token = "0x4019F8A")]
		BGM_NAME_014 = 17014,
		// Token: 0x04008A39 RID: 35385
		[Token(Token = "0x4019F8B")]
		BGM_NAME_015,
		// Token: 0x04008A3A RID: 35386
		[Token(Token = "0x4019F8C")]
		BGM_NAME_016,
		// Token: 0x04008A3B RID: 35387
		[Token(Token = "0x4019F8D")]
		BGM_NAME_017,
		// Token: 0x04008A3C RID: 35388
		[Token(Token = "0x4019F8E")]
		BGM_NAME_018,
		// Token: 0x04008A3D RID: 35389
		[Token(Token = "0x4019F8F")]
		BGM_NAME_019,
		// Token: 0x04008A3E RID: 35390
		[Token(Token = "0x4019F90")]
		BGM_NAME_020,
		// Token: 0x04008A3F RID: 35391
		[Token(Token = "0x4019F91")]
		BGM_NAME_021,
		// Token: 0x04008A40 RID: 35392
		[Token(Token = "0x4019F92")]
		BGM_NAME_022,
		// Token: 0x04008A41 RID: 35393
		[Token(Token = "0x4019F93")]
		BGM_NAME_023,
		// Token: 0x04008A42 RID: 35394
		[Token(Token = "0x4019F94")]
		BGM_NAME_024,
		// Token: 0x04008A43 RID: 35395
		[Token(Token = "0x4019F95")]
		BGM_NAME_025,
		// Token: 0x04008A44 RID: 35396
		[Token(Token = "0x4019F96")]
		BGM_NAME_026,
		// Token: 0x04008A45 RID: 35397
		[Token(Token = "0x4019F97")]
		BGM_NAME_027,
		// Token: 0x04008A46 RID: 35398
		[Token(Token = "0x4019F98")]
		BGM_NAME_028,
		// Token: 0x04008A47 RID: 35399
		[Token(Token = "0x4019F99")]
		BGM_NAME_029,
		// Token: 0x04008A48 RID: 35400
		[Token(Token = "0x4019F9A")]
		BGM_NAME_030,
		// Token: 0x04008A49 RID: 35401
		[Token(Token = "0x4019F9B")]
		BGM_NAME_031,
		// Token: 0x04008A4A RID: 35402
		[Token(Token = "0x4019F9C")]
		BGM_NAME_032,
		// Token: 0x04008A4B RID: 35403
		[Token(Token = "0x4019F9D")]
		BGM_NAME_033,
		// Token: 0x04008A4C RID: 35404
		[Token(Token = "0x4019F9E")]
		BGM_NAME_034,
		// Token: 0x04008A4D RID: 35405
		[Token(Token = "0x4019F9F")]
		BGM_NAME_035,
		// Token: 0x04008A4E RID: 35406
		[Token(Token = "0x4019FA0")]
		BGM_NAME_036,
		// Token: 0x04008A4F RID: 35407
		[Token(Token = "0x4019FA1")]
		BGM_NAME_037,
		// Token: 0x04008A50 RID: 35408
		[Token(Token = "0x4019FA2")]
		BGM_NAME_038,
		// Token: 0x04008A51 RID: 35409
		[Token(Token = "0x4019FA3")]
		BGM_NAME_039,
		// Token: 0x04008A52 RID: 35410
		[Token(Token = "0x4019FA4")]
		BGM_NAME_040,
		// Token: 0x04008A53 RID: 35411
		[Token(Token = "0x4019FA5")]
		BGM_NAME_041,
		// Token: 0x04008A54 RID: 35412
		[Token(Token = "0x4019FA6")]
		BGM_NAME_042,
		// Token: 0x04008A55 RID: 35413
		[Token(Token = "0x4019FA7")]
		BGM_NAME_043,
		// Token: 0x04008A56 RID: 35414
		[Token(Token = "0x4019FA8")]
		BGM_NAME_044,
		// Token: 0x04008A57 RID: 35415
		[Token(Token = "0x4019FA9")]
		BGM_NAME_045,
		// Token: 0x04008A58 RID: 35416
		[Token(Token = "0x4019FAA")]
		BGM_NAME_046,
		// Token: 0x04008A59 RID: 35417
		[Token(Token = "0x4019FAB")]
		BGM_NAME_047,
		// Token: 0x04008A5A RID: 35418
		[Token(Token = "0x4019FAC")]
		BGM_NAME_048,
		// Token: 0x04008A5B RID: 35419
		[Token(Token = "0x4019FAD")]
		BGM_NAME_049,
		// Token: 0x04008A5C RID: 35420
		[Token(Token = "0x4019FAE")]
		BGM_NAME_050,
		// Token: 0x04008A5D RID: 35421
		[Token(Token = "0x4019FAF")]
		BGM_NAME_051,
		// Token: 0x04008A5E RID: 35422
		[Token(Token = "0x4019FB0")]
		BGM_NAME_052,
		// Token: 0x04008A5F RID: 35423
		[Token(Token = "0x4019FB1")]
		BGM_NAME_053,
		// Token: 0x04008A60 RID: 35424
		[Token(Token = "0x4019FB2")]
		BGM_NAME_054,
		// Token: 0x04008A61 RID: 35425
		[Token(Token = "0x4019FB3")]
		BGM_NAME_055,
		// Token: 0x04008A62 RID: 35426
		[Token(Token = "0x4019FB4")]
		BGM_NAME_056,
		// Token: 0x04008A63 RID: 35427
		[Token(Token = "0x4019FB5")]
		BGM_NAME_057,
		// Token: 0x04008A64 RID: 35428
		[Token(Token = "0x4019FB6")]
		BGM_NAME_058,
		// Token: 0x04008A65 RID: 35429
		[Token(Token = "0x4019FB7")]
		BGM_NAME_059,
		// Token: 0x04008A66 RID: 35430
		[Token(Token = "0x4019FB8")]
		BGM_NAME_060,
		// Token: 0x04008A67 RID: 35431
		[Token(Token = "0x4019FB9")]
		BGM_NAME_061,
		// Token: 0x04008A68 RID: 35432
		[Token(Token = "0x4019FBA")]
		BGM_NAME_062,
		// Token: 0x04008A69 RID: 35433
		[Token(Token = "0x4019FBB")]
		BGM_NAME_063,
		// Token: 0x04008A6A RID: 35434
		[Token(Token = "0x4019FBC")]
		BGM_NAME_064,
		// Token: 0x04008A6B RID: 35435
		[Token(Token = "0x4019FBD")]
		BGM_NAME_065,
		// Token: 0x04008A6C RID: 35436
		[Token(Token = "0x4019FBE")]
		BGM_NAME_066,
		// Token: 0x04008A6D RID: 35437
		[Token(Token = "0x4019FBF")]
		BGM_NAME_067,
		// Token: 0x04008A6E RID: 35438
		[Token(Token = "0x4019FC0")]
		BGM_NAME_068,
		// Token: 0x04008A6F RID: 35439
		[Token(Token = "0x4019FC1")]
		BGM_NAME_069,
		// Token: 0x04008A70 RID: 35440
		[Token(Token = "0x4019FC2")]
		BGM_NAME_070,
		// Token: 0x04008A71 RID: 35441
		[Token(Token = "0x4019FC3")]
		BGM_NAME_071,
		// Token: 0x04008A72 RID: 35442
		[Token(Token = "0x4019FC4")]
		BGM_NAME_072,
		// Token: 0x04008A73 RID: 35443
		[Token(Token = "0x4019FC5")]
		BGM_NAME_073,
		// Token: 0x04008A74 RID: 35444
		[Token(Token = "0x4019FC6")]
		BGM_NAME_074,
		// Token: 0x04008A75 RID: 35445
		[Token(Token = "0x4019FC7")]
		BGM_NAME_075,
		// Token: 0x04008A76 RID: 35446
		[Token(Token = "0x4019FC8")]
		BGM_NAME_076,
		// Token: 0x04008A77 RID: 35447
		[Token(Token = "0x4019FC9")]
		BGM_NAME_077,
		// Token: 0x04008A78 RID: 35448
		[Token(Token = "0x4019FCA")]
		BGM_NAME_078,
		// Token: 0x04008A79 RID: 35449
		[Token(Token = "0x4019FCB")]
		BGM_NAME_079,
		// Token: 0x04008A7A RID: 35450
		[Token(Token = "0x4019FCC")]
		BGM_NAME_080,
		// Token: 0x04008A7B RID: 35451
		[Token(Token = "0x4019FCD")]
		BGM_NAME_081,
		// Token: 0x04008A7C RID: 35452
		[Token(Token = "0x4019FCE")]
		BGM_NAME_082,
		// Token: 0x04008A7D RID: 35453
		[Token(Token = "0x4019FCF")]
		BGM_NAME_083,
		// Token: 0x04008A7E RID: 35454
		[Token(Token = "0x4019FD0")]
		BGM_NAME_084,
		// Token: 0x04008A7F RID: 35455
		[Token(Token = "0x4019FD1")]
		BGM_NAME_085,
		// Token: 0x04008A80 RID: 35456
		[Token(Token = "0x4019FD2")]
		BGM_NAME_086,
		// Token: 0x04008A81 RID: 35457
		[Token(Token = "0x4019FD3")]
		BGM_NAME_087,
		// Token: 0x04008A82 RID: 35458
		[Token(Token = "0x4019FD4")]
		BGM_NAME_088,
		// Token: 0x04008A83 RID: 35459
		[Token(Token = "0x4019FD5")]
		BGM_NAME_089,
		// Token: 0x04008A84 RID: 35460
		[Token(Token = "0x4019FD6")]
		BGM_NAME_090,
		// Token: 0x04008A85 RID: 35461
		[Token(Token = "0x4019FD7")]
		BGM_NAME_091,
		// Token: 0x04008A86 RID: 35462
		[Token(Token = "0x4019FD8")]
		BGM_NAME_092,
		// Token: 0x04008A87 RID: 35463
		[Token(Token = "0x4019FD9")]
		BGM_NAME_093,
		// Token: 0x04008A88 RID: 35464
		[Token(Token = "0x4019FDA")]
		BGM_NAME_094,
		// Token: 0x04008A89 RID: 35465
		[Token(Token = "0x4019FDB")]
		BGM_NAME_095,
		// Token: 0x04008A8A RID: 35466
		[Token(Token = "0x4019FDC")]
		BGM_NAME_096,
		// Token: 0x04008A8B RID: 35467
		[Token(Token = "0x4019FDD")]
		BGM_NAME_097,
		// Token: 0x04008A8C RID: 35468
		[Token(Token = "0x4019FDE")]
		BGM_NAME_098,
		// Token: 0x04008A8D RID: 35469
		[Token(Token = "0x4019FDF")]
		BGM_NAME_099,
		// Token: 0x04008A8E RID: 35470
		[Token(Token = "0x4019FE0")]
		BGM_NAME_100,
		// Token: 0x04008A8F RID: 35471
		[Token(Token = "0x4019FE1")]
		BGM_NAME_101,
		// Token: 0x04008A90 RID: 35472
		[Token(Token = "0x4019FE2")]
		BGM_NAME_102,
		// Token: 0x04008A91 RID: 35473
		[Token(Token = "0x4019FE3")]
		BGM_NAME_103,
		// Token: 0x04008A92 RID: 35474
		[Token(Token = "0x4019FE4")]
		BGM_NAME_104,
		// Token: 0x04008A93 RID: 35475
		[Token(Token = "0x4019FE5")]
		BGM_NAME_105,
		// Token: 0x04008A94 RID: 35476
		[Token(Token = "0x4019FE6")]
		BGM_NAME_106,
		// Token: 0x04008A95 RID: 35477
		[Token(Token = "0x4019FE7")]
		BGM_NAME_107,
		// Token: 0x04008A96 RID: 35478
		[Token(Token = "0x4019FE8")]
		BGM_NAME_108,
		// Token: 0x04008A97 RID: 35479
		[Token(Token = "0x4019FE9")]
		BGM_NAME_109,
		// Token: 0x04008A98 RID: 35480
		[Token(Token = "0x4019FEA")]
		BGM_NAME_110,
		// Token: 0x04008A99 RID: 35481
		[Token(Token = "0x4019FEB")]
		BGM_NAME_111,
		// Token: 0x04008A9A RID: 35482
		[Token(Token = "0x4019FEC")]
		BGM_NAME_112,
		// Token: 0x04008A9B RID: 35483
		[Token(Token = "0x4019FED")]
		BGM_NAME_113,
		// Token: 0x04008A9C RID: 35484
		[Token(Token = "0x4019FEE")]
		BGM_NAME_114,
		// Token: 0x04008A9D RID: 35485
		[Token(Token = "0x4019FEF")]
		BGM_NAME_115,
		// Token: 0x04008A9E RID: 35486
		[Token(Token = "0x4019FF0")]
		BGM_NAME_116,
		// Token: 0x04008A9F RID: 35487
		[Token(Token = "0x4019FF1")]
		BGM_NAME_117,
		// Token: 0x04008AA0 RID: 35488
		[Token(Token = "0x4019FF2")]
		BGM_NAME_118,
		// Token: 0x04008AA1 RID: 35489
		[Token(Token = "0x4019FF3")]
		BGM_NAME_119,
		// Token: 0x04008AA2 RID: 35490
		[Token(Token = "0x4019FF4")]
		BGM_NAME_120,
		// Token: 0x04008AA3 RID: 35491
		[Token(Token = "0x4019FF5")]
		BGM_NAME_121,
		// Token: 0x04008AA4 RID: 35492
		[Token(Token = "0x4019FF6")]
		BGM_NAME_122,
		// Token: 0x04008AA5 RID: 35493
		[Token(Token = "0x4019FF7")]
		BGM_NAME_123,
		// Token: 0x04008AA6 RID: 35494
		[Token(Token = "0x4019FF8")]
		BGM_NAME_124,
		// Token: 0x04008AA7 RID: 35495
		[Token(Token = "0x4019FF9")]
		BGM_NAME_125,
		// Token: 0x04008AA8 RID: 35496
		[Token(Token = "0x4019FFA")]
		BGM_NAME_126,
		// Token: 0x04008AA9 RID: 35497
		[Token(Token = "0x4019FFB")]
		BGM_NAME_127,
		// Token: 0x04008AAA RID: 35498
		[Token(Token = "0x4019FFC")]
		BGM_NAME_128,
		// Token: 0x04008AAB RID: 35499
		[Token(Token = "0x4019FFD")]
		BGM_NAME_129,
		// Token: 0x04008AAC RID: 35500
		[Token(Token = "0x4019FFE")]
		BGM_NAME_130,
		// Token: 0x04008AAD RID: 35501
		[Token(Token = "0x4019FFF")]
		BGM_NAME_131,
		// Token: 0x04008AAE RID: 35502
		[Token(Token = "0x401A000")]
		BGM_NAME_132,
		// Token: 0x04008AAF RID: 35503
		[Token(Token = "0x401A001")]
		BGM_NAME_133,
		// Token: 0x04008AB0 RID: 35504
		[Token(Token = "0x401A002")]
		BGM_NAME_134,
		// Token: 0x04008AB1 RID: 35505
		[Token(Token = "0x401A003")]
		BGM_NAME_135,
		// Token: 0x04008AB2 RID: 35506
		[Token(Token = "0x401A004")]
		BGM_NAME_136,
		// Token: 0x04008AB3 RID: 35507
		[Token(Token = "0x401A005")]
		BGM_NAME_137,
		// Token: 0x04008AB4 RID: 35508
		[Token(Token = "0x401A006")]
		BGM_NAME_138,
		// Token: 0x04008AB5 RID: 35509
		[Token(Token = "0x401A007")]
		BGM_NAME_139,
		// Token: 0x04008AB6 RID: 35510
		[Token(Token = "0x401A008")]
		BGM_NAME_140,
		// Token: 0x04008AB7 RID: 35511
		[Token(Token = "0x401A009")]
		BGM_NAME_141,
		// Token: 0x04008AB8 RID: 35512
		[Token(Token = "0x401A00A")]
		BGM_NAME_142,
		// Token: 0x04008AB9 RID: 35513
		[Token(Token = "0x401A00B")]
		BGM_NAME_143,
		// Token: 0x04008ABA RID: 35514
		[Token(Token = "0x401A00C")]
		BGM_NAME_144,
		// Token: 0x04008ABB RID: 35515
		[Token(Token = "0x401A00D")]
		BGM_NAME_145,
		// Token: 0x04008ABC RID: 35516
		[Token(Token = "0x401A00E")]
		BGM_NAME_146,
		// Token: 0x04008ABD RID: 35517
		[Token(Token = "0x401A00F")]
		BGM_NAME_147,
		// Token: 0x04008ABE RID: 35518
		[Token(Token = "0x401A010")]
		BGM_NAME_148,
		// Token: 0x04008ABF RID: 35519
		[Token(Token = "0x401A011")]
		BGM_NAME_149,
		// Token: 0x04008AC0 RID: 35520
		[Token(Token = "0x401A012")]
		BGM_NAME_150,
		// Token: 0x04008AC1 RID: 35521
		[Token(Token = "0x401A013")]
		BGM_NAME_151,
		// Token: 0x04008AC2 RID: 35522
		[Token(Token = "0x401A014")]
		BGM_NAME_152,
		// Token: 0x04008AC3 RID: 35523
		[Token(Token = "0x401A015")]
		BGM_NAME_153,
		// Token: 0x04008AC4 RID: 35524
		[Token(Token = "0x401A016")]
		BGM_NAME_154,
		// Token: 0x04008AC5 RID: 35525
		[Token(Token = "0x401A017")]
		BGM_NAME_155,
		// Token: 0x04008AC6 RID: 35526
		[Token(Token = "0x401A018")]
		BGM_NAME_156,
		// Token: 0x04008AC7 RID: 35527
		[Token(Token = "0x401A019")]
		BGM_NAME_157,
		// Token: 0x04008AC8 RID: 35528
		[Token(Token = "0x401A01A")]
		BGM_NAME_158,
		// Token: 0x04008AC9 RID: 35529
		[Token(Token = "0x401A01B")]
		BGM_NAME_159,
		// Token: 0x04008ACA RID: 35530
		[Token(Token = "0x401A01C")]
		TITLE_LNGWIN_LNG_NAME = 21000,
		// Token: 0x04008ACB RID: 35531
		[Token(Token = "0x401A01D")]
		TITLE_LNGWIN_LNG_JPN,
		// Token: 0x04008ACC RID: 35532
		[Token(Token = "0x401A01E")]
		TITLE_LNGWIN_LNG_ENG,
		// Token: 0x04008ACD RID: 35533
		[Token(Token = "0x401A01F")]
		TITLE_LNGWIN_LNG_GER,
		// Token: 0x04008ACE RID: 35534
		[Token(Token = "0x401A020")]
		TITLE_LNGWIN_LNG_FRE,
		// Token: 0x04008ACF RID: 35535
		[Token(Token = "0x401A021")]
		TITLE_LNGWIN_LNG_ITA,
		// Token: 0x04008AD0 RID: 35536
		[Token(Token = "0x401A022")]
		TITLE_LNGWIN_LNG_CHS,
		// Token: 0x04008AD1 RID: 35537
		[Token(Token = "0x401A023")]
		TITLE_LNGWIN_LNG_CHT,
		// Token: 0x04008AD2 RID: 35538
		[Token(Token = "0x401A024")]
		TITLE_LNGWIN_LNG_KOR,
		// Token: 0x04008AD3 RID: 35539
		[Token(Token = "0x401A025")]
		TITLE_LNGWIN_VOICE_NAME,
		// Token: 0x04008AD4 RID: 35540
		[Token(Token = "0x401A026")]
		TITLE_LNGWIN_VOICE_JPN,
		// Token: 0x04008AD5 RID: 35541
		[Token(Token = "0x401A027")]
		TITLE_LNGWIN_VOICE_ENG,
		// Token: 0x04008AD6 RID: 35542
		[Token(Token = "0x401A028")]
		START_INFO_AUTOSAVE,
		// Token: 0x04008AD7 RID: 35543
		[Token(Token = "0x401A029")]
		START_INFO_SYSTEM_CHECK,
		// Token: 0x04008AD8 RID: 35544
		[Token(Token = "0x401A02A")]
		START_INFO_SYSTEM_LOAD,
		// Token: 0x04008AD9 RID: 35545
		[Token(Token = "0x401A02B")]
		START_INFO_SYSTEM_LOADEND,
		// Token: 0x04008ADA RID: 35546
		[Token(Token = "0x401A02C")]
		START_INFO_SYSTEM_CREATE,
		// Token: 0x04008ADB RID: 35547
		[Token(Token = "0x401A02D")]
		START_INFO_SYSTEM_CREATEEND,
		// Token: 0x04008ADC RID: 35548
		[Token(Token = "0x401A02E")]
		START_INFO_SYSTEM_CREATEERR,
		// Token: 0x04008ADD RID: 35549
		[Token(Token = "0x401A02F")]
		START_INFO_SYSTEM_CREATENOT,
		// Token: 0x04008ADE RID: 35550
		[Token(Token = "0x401A030")]
		START_INFO_SYSTEM_CONFIRM,
		// Token: 0x04008ADF RID: 35551
		[Token(Token = "0x401A031")]
		START_INFO_SYSTEM_RECONFIRM,
		// Token: 0x04008AE0 RID: 35552
		[Token(Token = "0x401A032")]
		START_INFO_SYSTEM_LOADERR,
		// Token: 0x04008AE1 RID: 35553
		[Token(Token = "0x401A033")]
		TITLE_VOICECOMMENT,
		// Token: 0x04008AE2 RID: 35554
		[Token(Token = "0x401A034")]
		TITLE_CASTLIST,
		// Token: 0x04008AE3 RID: 35555
		[Token(Token = "0x401A035")]
		TITLE_CHARA_0,
		// Token: 0x04008AE4 RID: 35556
		[Token(Token = "0x401A036")]
		TITLE_CHARA_1,
		// Token: 0x04008AE5 RID: 35557
		[Token(Token = "0x401A037")]
		TITLE_CHARA_2,
		// Token: 0x04008AE6 RID: 35558
		[Token(Token = "0x401A038")]
		TITLE_CHARA_3,
		// Token: 0x04008AE7 RID: 35559
		[Token(Token = "0x401A039")]
		TITLE_CHARA_4,
		// Token: 0x04008AE8 RID: 35560
		[Token(Token = "0x401A03A")]
		TITLE_CHARA_5,
		// Token: 0x04008AE9 RID: 35561
		[Token(Token = "0x401A03B")]
		TITLE_CHARA_6,
		// Token: 0x04008AEA RID: 35562
		[Token(Token = "0x401A03C")]
		TITLE_CHARA_7,
		// Token: 0x04008AEB RID: 35563
		[Token(Token = "0x401A03D")]
		TITLE_CHARA_8,
		// Token: 0x04008AEC RID: 35564
		[Token(Token = "0x401A03E")]
		TITLE_CHARA_9,
		// Token: 0x04008AED RID: 35565
		[Token(Token = "0x401A03F")]
		TITLE_CHARA_10,
		// Token: 0x04008AEE RID: 35566
		[Token(Token = "0x401A040")]
		TITLE_CHARA_11,
		// Token: 0x04008AEF RID: 35567
		[Token(Token = "0x401A041")]
		TITLE_CHARA_12,
		// Token: 0x04008AF0 RID: 35568
		[Token(Token = "0x401A042")]
		TITLE_CHARA_13,
		// Token: 0x04008AF1 RID: 35569
		[Token(Token = "0x401A043")]
		TITLE_CHARA_14,
		// Token: 0x04008AF2 RID: 35570
		[Token(Token = "0x401A044")]
		TITLE_CHARA_15,
		// Token: 0x04008AF3 RID: 35571
		[Token(Token = "0x401A045")]
		TITLE_CHARA_16,
		// Token: 0x04008AF4 RID: 35572
		[Token(Token = "0x401A046")]
		TITLE_CHARA_17,
		// Token: 0x04008AF5 RID: 35573
		[Token(Token = "0x401A047")]
		TITLE_CHARA_18,
		// Token: 0x04008AF6 RID: 35574
		[Token(Token = "0x401A048")]
		TITLE_CHARA_19,
		// Token: 0x04008AF7 RID: 35575
		[Token(Token = "0x401A049")]
		TITLE_CHARA_20,
		// Token: 0x04008AF8 RID: 35576
		[Token(Token = "0x401A04A")]
		TITLE_CHARA_21,
		// Token: 0x04008AF9 RID: 35577
		[Token(Token = "0x401A04B")]
		TITLE_CHARA_22,
		// Token: 0x04008AFA RID: 35578
		[Token(Token = "0x401A04C")]
		TITLE_CHARA_23,
		// Token: 0x04008AFB RID: 35579
		[Token(Token = "0x401A04D")]
		TITLE_CHARA_24,
		// Token: 0x04008AFC RID: 35580
		[Token(Token = "0x401A04E")]
		TITLE_CHARA_25,
		// Token: 0x04008AFD RID: 35581
		[Token(Token = "0x401A04F")]
		TITLE_CHARA_26,
		// Token: 0x04008AFE RID: 35582
		[Token(Token = "0x401A050")]
		TITLE_CHARA_27,
		// Token: 0x04008AFF RID: 35583
		[Token(Token = "0x401A051")]
		TITLE_CHARA_28,
		// Token: 0x04008B00 RID: 35584
		[Token(Token = "0x401A052")]
		TITLE_CHARA_29,
		// Token: 0x04008B01 RID: 35585
		[Token(Token = "0x401A053")]
		TITLE_CHARA_30,
		// Token: 0x04008B02 RID: 35586
		[Token(Token = "0x401A054")]
		TITLE_CHARA_31,
		// Token: 0x04008B03 RID: 35587
		[Token(Token = "0x401A055")]
		TITLE_CHARA_32,
		// Token: 0x04008B04 RID: 35588
		[Token(Token = "0x401A056")]
		TITLE_CHARA_33,
		// Token: 0x04008B05 RID: 35589
		[Token(Token = "0x401A057")]
		TITLE_CAST_0,
		// Token: 0x04008B06 RID: 35590
		[Token(Token = "0x401A058")]
		TITLE_CAST_1,
		// Token: 0x04008B07 RID: 35591
		[Token(Token = "0x401A059")]
		TITLE_CAST_2,
		// Token: 0x04008B08 RID: 35592
		[Token(Token = "0x401A05A")]
		TITLE_CAST_3,
		// Token: 0x04008B09 RID: 35593
		[Token(Token = "0x401A05B")]
		TITLE_CAST_4,
		// Token: 0x04008B0A RID: 35594
		[Token(Token = "0x401A05C")]
		TITLE_CAST_5,
		// Token: 0x04008B0B RID: 35595
		[Token(Token = "0x401A05D")]
		TITLE_CAST_6,
		// Token: 0x04008B0C RID: 35596
		[Token(Token = "0x401A05E")]
		TITLE_CAST_7,
		// Token: 0x04008B0D RID: 35597
		[Token(Token = "0x401A05F")]
		TITLE_CAST_8,
		// Token: 0x04008B0E RID: 35598
		[Token(Token = "0x401A060")]
		TITLE_CAST_9,
		// Token: 0x04008B0F RID: 35599
		[Token(Token = "0x401A061")]
		TITLE_CAST_10,
		// Token: 0x04008B10 RID: 35600
		[Token(Token = "0x401A062")]
		TITLE_CAST_11,
		// Token: 0x04008B11 RID: 35601
		[Token(Token = "0x401A063")]
		TITLE_CAST_12,
		// Token: 0x04008B12 RID: 35602
		[Token(Token = "0x401A064")]
		TITLE_CAST_13,
		// Token: 0x04008B13 RID: 35603
		[Token(Token = "0x401A065")]
		TITLE_CAST_14,
		// Token: 0x04008B14 RID: 35604
		[Token(Token = "0x401A066")]
		TITLE_CAST_15,
		// Token: 0x04008B15 RID: 35605
		[Token(Token = "0x401A067")]
		TITLE_CAST_16,
		// Token: 0x04008B16 RID: 35606
		[Token(Token = "0x401A068")]
		TITLE_CAST_17,
		// Token: 0x04008B17 RID: 35607
		[Token(Token = "0x401A069")]
		TITLE_CAST_18,
		// Token: 0x04008B18 RID: 35608
		[Token(Token = "0x401A06A")]
		TITLE_CAST_19,
		// Token: 0x04008B19 RID: 35609
		[Token(Token = "0x401A06B")]
		TITLE_CAST_20,
		// Token: 0x04008B1A RID: 35610
		[Token(Token = "0x401A06C")]
		TITLE_CAST_21,
		// Token: 0x04008B1B RID: 35611
		[Token(Token = "0x401A06D")]
		TITLE_CAST_22,
		// Token: 0x04008B1C RID: 35612
		[Token(Token = "0x401A06E")]
		TITLE_CAST_23,
		// Token: 0x04008B1D RID: 35613
		[Token(Token = "0x401A06F")]
		TITLE_CAST_24,
		// Token: 0x04008B1E RID: 35614
		[Token(Token = "0x401A070")]
		TITLE_CAST_25,
		// Token: 0x04008B1F RID: 35615
		[Token(Token = "0x401A071")]
		TITLE_CAST_26,
		// Token: 0x04008B20 RID: 35616
		[Token(Token = "0x401A072")]
		TITLE_CAST_27,
		// Token: 0x04008B21 RID: 35617
		[Token(Token = "0x401A073")]
		TITLE_CAST_28,
		// Token: 0x04008B22 RID: 35618
		[Token(Token = "0x401A074")]
		TITLE_CAST_29,
		// Token: 0x04008B23 RID: 35619
		[Token(Token = "0x401A075")]
		TITLE_CAST_30,
		// Token: 0x04008B24 RID: 35620
		[Token(Token = "0x401A076")]
		TITLE_CAST_31,
		// Token: 0x04008B25 RID: 35621
		[Token(Token = "0x401A077")]
		TITLE_CAST_32,
		// Token: 0x04008B26 RID: 35622
		[Token(Token = "0x401A078")]
		TITLE_CAST_33,
		// Token: 0x04008B27 RID: 35623
		[Token(Token = "0x401A079")]
		TITLE_INFO_AUTOSAVE,
		// Token: 0x04008B28 RID: 35624
		[Token(Token = "0x401A07A")]
		START_INFO_SYSTEM_CAPACITY,
		// Token: 0x04008B29 RID: 35625
		[Token(Token = "0x401A07B")]
		TITLE_INFO_ONLINEMANUAL,
		// Token: 0x04008B2A RID: 35626
		[Token(Token = "0x401A07C")]
		INFO_DUGMARGRET,
		// Token: 0x04008B2B RID: 35627
		[Token(Token = "0x401A07D")]
		TITLE_INTERLOCKING_DLC1,
		// Token: 0x04008B2C RID: 35628
		[Token(Token = "0x401A07E")]
		TITLE_INTERLOCKING_DLC2,
		// Token: 0x04008B2D RID: 35629
		[Token(Token = "0x401A07F")]
		TITLE_INTERLOCKING_DLC3,
		// Token: 0x04008B2E RID: 35630
		[Token(Token = "0x401A080")]
		TITLE_INTERLOCKING_DLC4,
		// Token: 0x04008B2F RID: 35631
		[Token(Token = "0x401A081")]
		TITLE_INTERLOCKING_DLC5,
		// Token: 0x04008B30 RID: 35632
		[Token(Token = "0x401A082")]
		TITLE_INTERLOCKING_DLC6,
		// Token: 0x04008B31 RID: 35633
		[Token(Token = "0x401A083")]
		TITLE_INTERLOCKING_DLC7,
		// Token: 0x04008B32 RID: 35634
		[Token(Token = "0x401A084")]
		TITLE_INTERLOCKING_DLC8,
		// Token: 0x04008B33 RID: 35635
		[Token(Token = "0x401A085")]
		TITLE_INTERLOCKING_DLC9,
		// Token: 0x04008B34 RID: 35636
		[Token(Token = "0x401A086")]
		TITLE_INTERLOCKING_DLC10,
		// Token: 0x04008B35 RID: 35637
		[Token(Token = "0x401A087")]
		TITLE_INTERLOCKING_DLC11,
		// Token: 0x04008B36 RID: 35638
		[Token(Token = "0x401A088")]
		TITLE_INTERLOCKING_DLC12,
		// Token: 0x04008B37 RID: 35639
		[Token(Token = "0x401A089")]
		TITLE_INTERLOCKING_DLC13,
		// Token: 0x04008B38 RID: 35640
		[Token(Token = "0x401A08A")]
		TITLE_INTERLOCKING_DLC14,
		// Token: 0x04008B39 RID: 35641
		[Token(Token = "0x401A08B")]
		MOVIE_ROOM_TOPMENU = 22000,
		// Token: 0x04008B3A RID: 35642
		[Token(Token = "0x401A08C")]
		MOVIE_LIST,
		// Token: 0x04008B3B RID: 35643
		[Token(Token = "0x401A08D")]
		MOVIE_SKIP,
		// Token: 0x04008B3C RID: 35644
		[Token(Token = "0x401A08E")]
		MOVIE_NAME1,
		// Token: 0x04008B3D RID: 35645
		[Token(Token = "0x401A08F")]
		MOVIE_NAME2,
		// Token: 0x04008B3E RID: 35646
		[Token(Token = "0x401A090")]
		MOVIE_NAME3,
		// Token: 0x04008B3F RID: 35647
		[Token(Token = "0x401A091")]
		MOVIE_NAME4,
		// Token: 0x04008B40 RID: 35648
		[Token(Token = "0x401A092")]
		MOVIE_NAME5,
		// Token: 0x04008B41 RID: 35649
		[Token(Token = "0x401A093")]
		MOVIE_NAME6,
		// Token: 0x04008B42 RID: 35650
		[Token(Token = "0x401A094")]
		MOVIE_NAME7,
		// Token: 0x04008B43 RID: 35651
		[Token(Token = "0x401A095")]
		MOVIE_NAME8,
		// Token: 0x04008B44 RID: 35652
		[Token(Token = "0x401A096")]
		MOVIE_NAME9,
		// Token: 0x04008B45 RID: 35653
		[Token(Token = "0x401A097")]
		MOVIE_NAME10,
		// Token: 0x04008B46 RID: 35654
		[Token(Token = "0x401A098")]
		MOVIE_NAME11,
		// Token: 0x04008B47 RID: 35655
		[Token(Token = "0x401A099")]
		MOVIE_NAME12,
		// Token: 0x04008B48 RID: 35656
		[Token(Token = "0x401A09A")]
		MOVIE_NAME13,
		// Token: 0x04008B49 RID: 35657
		[Token(Token = "0x401A09B")]
		MOVIE_NAME14,
		// Token: 0x04008B4A RID: 35658
		[Token(Token = "0x401A09C")]
		MOVIE_NAME15,
		// Token: 0x04008B4B RID: 35659
		[Token(Token = "0x401A09D")]
		MOVIE_NAME16,
		// Token: 0x04008B4C RID: 35660
		[Token(Token = "0x401A09E")]
		MOVIE_NAME17,
		// Token: 0x04008B4D RID: 35661
		[Token(Token = "0x401A09F")]
		MOVIE_NAME18,
		// Token: 0x04008B4E RID: 35662
		[Token(Token = "0x401A0A0")]
		MOVIE_NAME19,
		// Token: 0x04008B4F RID: 35663
		[Token(Token = "0x401A0A1")]
		MOVIE_NAME20,
		// Token: 0x04008B50 RID: 35664
		[Token(Token = "0x401A0A2")]
		MOVIE_NAME21,
		// Token: 0x04008B51 RID: 35665
		[Token(Token = "0x401A0A3")]
		MOVIE_NAME22,
		// Token: 0x04008B52 RID: 35666
		[Token(Token = "0x401A0A4")]
		MOVIE_NAME23,
		// Token: 0x04008B53 RID: 35667
		[Token(Token = "0x401A0A5")]
		MOVIE_NAME24,
		// Token: 0x04008B54 RID: 35668
		[Token(Token = "0x401A0A6")]
		MOVIE_NAME25,
		// Token: 0x04008B55 RID: 35669
		[Token(Token = "0x401A0A7")]
		MOVIE_NAME26,
		// Token: 0x04008B56 RID: 35670
		[Token(Token = "0x401A0A8")]
		MOVIE_NAME27,
		// Token: 0x04008B57 RID: 35671
		[Token(Token = "0x401A0A9")]
		MOVIE_CONTENT1,
		// Token: 0x04008B58 RID: 35672
		[Token(Token = "0x401A0AA")]
		MOVIE_CONTENT2,
		// Token: 0x04008B59 RID: 35673
		[Token(Token = "0x401A0AB")]
		MOVIE_CONTENT3,
		// Token: 0x04008B5A RID: 35674
		[Token(Token = "0x401A0AC")]
		MOVIE_CONTENT4,
		// Token: 0x04008B5B RID: 35675
		[Token(Token = "0x401A0AD")]
		MOVIE_CONTENT5,
		// Token: 0x04008B5C RID: 35676
		[Token(Token = "0x401A0AE")]
		MOVIE_CONTENT6,
		// Token: 0x04008B5D RID: 35677
		[Token(Token = "0x401A0AF")]
		MOVIE_CONTENT7,
		// Token: 0x04008B5E RID: 35678
		[Token(Token = "0x401A0B0")]
		MOVIE_CONTENT8,
		// Token: 0x04008B5F RID: 35679
		[Token(Token = "0x401A0B1")]
		MOVIE_CONTENT9,
		// Token: 0x04008B60 RID: 35680
		[Token(Token = "0x401A0B2")]
		MOVIE_CONTENT10,
		// Token: 0x04008B61 RID: 35681
		[Token(Token = "0x401A0B3")]
		MOVIE_CONTENT11,
		// Token: 0x04008B62 RID: 35682
		[Token(Token = "0x401A0B4")]
		MOVIE_CONTENT12,
		// Token: 0x04008B63 RID: 35683
		[Token(Token = "0x401A0B5")]
		MOVIE_CONTENT13,
		// Token: 0x04008B64 RID: 35684
		[Token(Token = "0x401A0B6")]
		MOVIE_CONTENT14,
		// Token: 0x04008B65 RID: 35685
		[Token(Token = "0x401A0B7")]
		MOVIE_CONTENT15,
		// Token: 0x04008B66 RID: 35686
		[Token(Token = "0x401A0B8")]
		MOVIE_CONTENT16,
		// Token: 0x04008B67 RID: 35687
		[Token(Token = "0x401A0B9")]
		MOVIE_CONTENT17,
		// Token: 0x04008B68 RID: 35688
		[Token(Token = "0x401A0BA")]
		MOVIE_CONTENT18,
		// Token: 0x04008B69 RID: 35689
		[Token(Token = "0x401A0BB")]
		MOVIE_CONTENT19,
		// Token: 0x04008B6A RID: 35690
		[Token(Token = "0x401A0BC")]
		MOVIE_CONTENT20,
		// Token: 0x04008B6B RID: 35691
		[Token(Token = "0x401A0BD")]
		MOVIE_CONTENT21,
		// Token: 0x04008B6C RID: 35692
		[Token(Token = "0x401A0BE")]
		MOVIE_CONTENT22,
		// Token: 0x04008B6D RID: 35693
		[Token(Token = "0x401A0BF")]
		MOVIE_CONTENT23,
		// Token: 0x04008B6E RID: 35694
		[Token(Token = "0x401A0C0")]
		MOVIE_CONTENT24,
		// Token: 0x04008B6F RID: 35695
		[Token(Token = "0x401A0C1")]
		MOVIE_CONTENT25,
		// Token: 0x04008B70 RID: 35696
		[Token(Token = "0x401A0C2")]
		MOVIE_CONTENT26,
		// Token: 0x04008B71 RID: 35697
		[Token(Token = "0x401A0C3")]
		MOVIE_CONTENT27,
		// Token: 0x04008B72 RID: 35698
		[Token(Token = "0x401A0C4")]
		MOVIE_NOT_OPEN,
		// Token: 0x04008B73 RID: 35699
		[Token(Token = "0x401A0C5")]
		LPOCKET_PREVIEW = 23000,
		// Token: 0x04008B74 RID: 35700
		[Token(Token = "0x401A0C6")]
		LPOCKET_STATUS_SYNC,
		// Token: 0x04008B75 RID: 35701
		[Token(Token = "0x401A0C7")]
		LPOCKET_SHOW_CATAGORY,
		// Token: 0x04008B76 RID: 35702
		[Token(Token = "0x401A0C8")]
		LPOCKET_CUSTOMIZE_TOPIC,
		// Token: 0x04008B77 RID: 35703
		[Token(Token = "0x401A0C9")]
		LPocketCustomizeDetail_Accessary,
		// Token: 0x04008B78 RID: 35704
		[Token(Token = "0x401A0CA")]
		LPocketCustomizeDetail_Body,
		// Token: 0x04008B79 RID: 35705
		[Token(Token = "0x401A0CB")]
		LPocketCustomizeDetail_Head,
		// Token: 0x04008B7A RID: 35706
		[Token(Token = "0x401A0CC")]
		LPocketCustomizeDetail_RuneRX,
		// Token: 0x04008B7B RID: 35707
		[Token(Token = "0x401A0CD")]
		LPocketCustomizeDetail_RuneRY,
		// Token: 0x04008B7C RID: 35708
		[Token(Token = "0x401A0CE")]
		LPocketCustomizeDetail_RuneRB,
		// Token: 0x04008B7D RID: 35709
		[Token(Token = "0x401A0CF")]
		LPocketCustomizeDetail_RuneRA,
		// Token: 0x04008B7E RID: 35710
		[Token(Token = "0x401A0D0")]
		LPocketCustomizeDetail_RuneA,
		// Token: 0x04008B7F RID: 35711
		[Token(Token = "0x401A0D1")]
		LPocketCustomizeDetail_RuneB,
		// Token: 0x04008B80 RID: 35712
		[Token(Token = "0x401A0D2")]
		LPocketCustomizeDetail_Shield,
		// Token: 0x04008B81 RID: 35713
		[Token(Token = "0x401A0D3")]
		LPocketCustomizeDetail_Shoes,
		// Token: 0x04008B82 RID: 35714
		[Token(Token = "0x401A0D4")]
		LPocketCustomizeDetail_Tool,
		// Token: 0x04008B83 RID: 35715
		[Token(Token = "0x401A0D5")]
		LPocketCustomizeDetail_Weapon,
		// Token: 0x04008B84 RID: 35716
		[Token(Token = "0x401A0D6")]
		LPocketCustomizeDetail_Crop,
		// Token: 0x04008B85 RID: 35717
		[Token(Token = "0x401A0D7")]
		LPocketCustomizeDetail_Fish,
		// Token: 0x04008B86 RID: 35718
		[Token(Token = "0x401A0D8")]
		LPocketCustomizeDetail_Collect,
		// Token: 0x04008B87 RID: 35719
		[Token(Token = "0x401A0D9")]
		LPocketCustomizeDetail_Food,
		// Token: 0x04008B88 RID: 35720
		[Token(Token = "0x401A0DA")]
		LPocketCustomizeDetail_Drug,
		// Token: 0x04008B89 RID: 35721
		[Token(Token = "0x401A0DB")]
		LPocketCustomizeDetail_Hand,
		// Token: 0x04008B8A RID: 35722
		[Token(Token = "0x401A0DC")]
		MONSTER_NAMING_HEAD = 24000,
		// Token: 0x04008B8B RID: 35723
		[Token(Token = "0x401A0DD")]
		MONSTER_NAMING_BUTTON_COMFIRM,
		// Token: 0x04008B8C RID: 35724
		[Token(Token = "0x401A0DE")]
		MonsterNamingHeadTopic,
		// Token: 0x04008B8D RID: 35725
		[Token(Token = "0x401A0DF")]
		Naming_Topic_PlayerMan,
		// Token: 0x04008B8E RID: 35726
		[Token(Token = "0x401A0E0")]
		Naming_Topic_PlayerWoman,
		// Token: 0x04008B8F RID: 35727
		[Token(Token = "0x401A0E1")]
		Naming_Topic_ChildA,
		// Token: 0x04008B90 RID: 35728
		[Token(Token = "0x401A0E2")]
		Naming_Topic_ChildB,
		// Token: 0x04008B91 RID: 35729
		[Token(Token = "0x401A0E3")]
		Naming_Topic_ChildC,
		// Token: 0x04008B92 RID: 35730
		[Token(Token = "0x401A0E4")]
		Naming_Topic_Farm_Soil,
		// Token: 0x04008B93 RID: 35731
		[Token(Token = "0x401A0E5")]
		Naming_Topic_Farm_Fire,
		// Token: 0x04008B94 RID: 35732
		[Token(Token = "0x401A0E6")]
		Naming_Topic_Farm_Ice,
		// Token: 0x04008B95 RID: 35733
		[Token(Token = "0x401A0E7")]
		Naming_Topic_Farm_Wind,
		// Token: 0x04008B96 RID: 35734
		[Token(Token = "0x401A0E8")]
		Naming_Topic_Farm_Ground,
		// Token: 0x04008B97 RID: 35735
		[Token(Token = "0x401A0E9")]
		Naming_Topic_FarmPet_Soil_A,
		// Token: 0x04008B98 RID: 35736
		[Token(Token = "0x401A0EA")]
		Naming_Topic_FarmPet_Soil_B,
		// Token: 0x04008B99 RID: 35737
		[Token(Token = "0x401A0EB")]
		Naming_Topic_FarmPet_Fire_A,
		// Token: 0x04008B9A RID: 35738
		[Token(Token = "0x401A0EC")]
		Naming_Topic_FarmPet_Fire_B,
		// Token: 0x04008B9B RID: 35739
		[Token(Token = "0x401A0ED")]
		Naming_Topic_FarmPet_Ice_A,
		// Token: 0x04008B9C RID: 35740
		[Token(Token = "0x401A0EE")]
		Naming_Topic_FarmPet_Ice_B,
		// Token: 0x04008B9D RID: 35741
		[Token(Token = "0x401A0EF")]
		Naming_Topic_FarmPet_Wind_A,
		// Token: 0x04008B9E RID: 35742
		[Token(Token = "0x401A0F0")]
		Naming_Topic_FarmPet_Wind_B,
		// Token: 0x04008B9F RID: 35743
		[Token(Token = "0x401A0F1")]
		Naming_Topic_FarmPet_Ground_A,
		// Token: 0x04008BA0 RID: 35744
		[Token(Token = "0x401A0F2")]
		Naming_Topic_FarmPet_Ground_B,
		// Token: 0x04008BA1 RID: 35745
		[Token(Token = "0x401A0F3")]
		Naming_Default_PlayerMan,
		// Token: 0x04008BA2 RID: 35746
		[Token(Token = "0x401A0F4")]
		Naming_Default_PlayerWoman,
		// Token: 0x04008BA3 RID: 35747
		[Token(Token = "0x401A0F5")]
		Naming_Default_ChildBoyA,
		// Token: 0x04008BA4 RID: 35748
		[Token(Token = "0x401A0F6")]
		Naming_Default_ChildBoyB,
		// Token: 0x04008BA5 RID: 35749
		[Token(Token = "0x401A0F7")]
		Naming_Default_ChildBoyC,
		// Token: 0x04008BA6 RID: 35750
		[Token(Token = "0x401A0F8")]
		Naming_Default_ChildGirlA,
		// Token: 0x04008BA7 RID: 35751
		[Token(Token = "0x401A0F9")]
		Naming_Default_ChildGirlB,
		// Token: 0x04008BA8 RID: 35752
		[Token(Token = "0x401A0FA")]
		Naming_Default_ChildGirlC,
		// Token: 0x04008BA9 RID: 35753
		[Token(Token = "0x401A0FB")]
		Naming_Default_Farm_Soil,
		// Token: 0x04008BAA RID: 35754
		[Token(Token = "0x401A0FC")]
		Naming_Default_Farm_Fire,
		// Token: 0x04008BAB RID: 35755
		[Token(Token = "0x401A0FD")]
		Naming_Default_Farm_Ice,
		// Token: 0x04008BAC RID: 35756
		[Token(Token = "0x401A0FE")]
		Naming_Default_Farm_Wind,
		// Token: 0x04008BAD RID: 35757
		[Token(Token = "0x401A0FF")]
		Naming_Default_Farm_Ground,
		// Token: 0x04008BAE RID: 35758
		[Token(Token = "0x401A100")]
		Naming_Default_FarmPet_Soil_A,
		// Token: 0x04008BAF RID: 35759
		[Token(Token = "0x401A101")]
		Naming_Default_FarmPet_Soil_B,
		// Token: 0x04008BB0 RID: 35760
		[Token(Token = "0x401A102")]
		Naming_Default_FarmPet_Fire_A,
		// Token: 0x04008BB1 RID: 35761
		[Token(Token = "0x401A103")]
		Naming_Default_FarmPet_Fire_B,
		// Token: 0x04008BB2 RID: 35762
		[Token(Token = "0x401A104")]
		Naming_Default_FarmPet_Ice_A,
		// Token: 0x04008BB3 RID: 35763
		[Token(Token = "0x401A105")]
		Naming_Default_FarmPet_Ice_B,
		// Token: 0x04008BB4 RID: 35764
		[Token(Token = "0x401A106")]
		Naming_Default_FarmPet_Wind_A,
		// Token: 0x04008BB5 RID: 35765
		[Token(Token = "0x401A107")]
		Naming_Default_FarmPet_Wind_B,
		// Token: 0x04008BB6 RID: 35766
		[Token(Token = "0x401A108")]
		Naming_Default_FarmPet_Ground_A,
		// Token: 0x04008BB7 RID: 35767
		[Token(Token = "0x401A109")]
		Naming_Default_FarmPet_Ground_B,
		// Token: 0x04008BB8 RID: 35768
		[Token(Token = "0x401A10A")]
		Naming_CancelNamePopup,
		// Token: 0x04008BB9 RID: 35769
		[Token(Token = "0x401A10B")]
		Naming_ConfirmPopup,
		// Token: 0x04008BBA RID: 35770
		[Token(Token = "0x401A10C")]
		Naming_NGPopup,
		// Token: 0x04008BBB RID: 35771
		[Token(Token = "0x401A10D")]
		MobRenameSelector_Player,
		// Token: 0x04008BBC RID: 35772
		[Token(Token = "0x401A10E")]
		MobRenameSelector_WithName,
		// Token: 0x04008BBD RID: 35773
		[Token(Token = "0x401A10F")]
		MobRenameSelector_Cancel,
		// Token: 0x04008BBE RID: 35774
		[Token(Token = "0x401A110")]
		MONSTER_DOCTOR_DEF_NORMAL = 25000,
		// Token: 0x04008BBF RID: 35775
		[Token(Token = "0x401A111")]
		MONSTER_DOCTOR_DEF_STRONG,
		// Token: 0x04008BC0 RID: 35776
		[Token(Token = "0x401A112")]
		MONSTER_DOCTOR_DEF_WEAK,
		// Token: 0x04008BC1 RID: 35777
		[Token(Token = "0x401A113")]
		MONSTER_DOCTOR_ATK_NORMAL,
		// Token: 0x04008BC2 RID: 35778
		[Token(Token = "0x401A114")]
		MONSTER_DOCTOR_ATK_GOODAT,
		// Token: 0x04008BC3 RID: 35779
		[Token(Token = "0x401A115")]
		MONSTER_DOCTOR_ATK_NOTGOODAT,
		// Token: 0x04008BC4 RID: 35780
		[Token(Token = "0x401A116")]
		SubEvent_Topic_0 = 30000,
		// Token: 0x04008BC5 RID: 35781
		[Token(Token = "0x401A117")]
		SubEvent_Detail_0,
		// Token: 0x04008BC6 RID: 35782
		[Token(Token = "0x401A118")]
		SubEvent_Topic_999,
		// Token: 0x04008BC7 RID: 35783
		[Token(Token = "0x401A119")]
		SubEvent_Detail_999,
		// Token: 0x04008BC8 RID: 35784
		[Token(Token = "0x401A11A")]
		SubEvent_Topic_20,
		// Token: 0x04008BC9 RID: 35785
		[Token(Token = "0x401A11B")]
		SubEvent_Topic_21,
		// Token: 0x04008BCA RID: 35786
		[Token(Token = "0x401A11C")]
		SubEvent_Topic_22,
		// Token: 0x04008BCB RID: 35787
		[Token(Token = "0x401A11D")]
		SubEvent_Topic_30,
		// Token: 0x04008BCC RID: 35788
		[Token(Token = "0x401A11E")]
		SubEvent_Topic_31,
		// Token: 0x04008BCD RID: 35789
		[Token(Token = "0x401A11F")]
		SubEvent_Topic_40,
		// Token: 0x04008BCE RID: 35790
		[Token(Token = "0x401A120")]
		SubEvent_Topic_41,
		// Token: 0x04008BCF RID: 35791
		[Token(Token = "0x401A121")]
		SubEvent_Topic_42,
		// Token: 0x04008BD0 RID: 35792
		[Token(Token = "0x401A122")]
		SubEvent_Topic_43,
		// Token: 0x04008BD1 RID: 35793
		[Token(Token = "0x401A123")]
		SubEvent_Topic_90,
		// Token: 0x04008BD2 RID: 35794
		[Token(Token = "0x401A124")]
		SubEvent_Topic_91,
		// Token: 0x04008BD3 RID: 35795
		[Token(Token = "0x401A125")]
		SubEvent_Topic_100,
		// Token: 0x04008BD4 RID: 35796
		[Token(Token = "0x401A126")]
		SubEvent_Topic_101,
		// Token: 0x04008BD5 RID: 35797
		[Token(Token = "0x401A127")]
		SubEvent_Topic_102,
		// Token: 0x04008BD6 RID: 35798
		[Token(Token = "0x401A128")]
		SubEvent_Topic_103,
		// Token: 0x04008BD7 RID: 35799
		[Token(Token = "0x401A129")]
		SubEvent_Topic_104,
		// Token: 0x04008BD8 RID: 35800
		[Token(Token = "0x401A12A")]
		SubEvent_Topic_105,
		// Token: 0x04008BD9 RID: 35801
		[Token(Token = "0x401A12B")]
		SubEvent_Topic_160,
		// Token: 0x04008BDA RID: 35802
		[Token(Token = "0x401A12C")]
		SubEvent_Topic_161,
		// Token: 0x04008BDB RID: 35803
		[Token(Token = "0x401A12D")]
		SubEvent_Topic_200,
		// Token: 0x04008BDC RID: 35804
		[Token(Token = "0x401A12E")]
		SubEvent_Topic_201,
		// Token: 0x04008BDD RID: 35805
		[Token(Token = "0x401A12F")]
		SubEvent_Topic_202,
		// Token: 0x04008BDE RID: 35806
		[Token(Token = "0x401A130")]
		SubEvent_Topic_220,
		// Token: 0x04008BDF RID: 35807
		[Token(Token = "0x401A131")]
		SubEvent_Topic_221,
		// Token: 0x04008BE0 RID: 35808
		[Token(Token = "0x401A132")]
		SubEvent_Topic_222,
		// Token: 0x04008BE1 RID: 35809
		[Token(Token = "0x401A133")]
		SubEvent_Topic_250,
		// Token: 0x04008BE2 RID: 35810
		[Token(Token = "0x401A134")]
		SubEvent_Topic_251,
		// Token: 0x04008BE3 RID: 35811
		[Token(Token = "0x401A135")]
		SubEvent_Topic_260,
		// Token: 0x04008BE4 RID: 35812
		[Token(Token = "0x401A136")]
		SubEvent_Topic_261,
		// Token: 0x04008BE5 RID: 35813
		[Token(Token = "0x401A137")]
		SubEvent_Topic_320,
		// Token: 0x04008BE6 RID: 35814
		[Token(Token = "0x401A138")]
		SubEvent_Topic_321,
		// Token: 0x04008BE7 RID: 35815
		[Token(Token = "0x401A139")]
		SubEvent_Topic_322,
		// Token: 0x04008BE8 RID: 35816
		[Token(Token = "0x401A13A")]
		SubEvent_Topic_323,
		// Token: 0x04008BE9 RID: 35817
		[Token(Token = "0x401A13B")]
		SubEvent_Topic_330,
		// Token: 0x04008BEA RID: 35818
		[Token(Token = "0x401A13C")]
		SubEvent_Topic_331,
		// Token: 0x04008BEB RID: 35819
		[Token(Token = "0x401A13D")]
		SubEvent_Topic_332,
		// Token: 0x04008BEC RID: 35820
		[Token(Token = "0x401A13E")]
		SubEvent_Topic_340,
		// Token: 0x04008BED RID: 35821
		[Token(Token = "0x401A13F")]
		SubEvent_Topic_341,
		// Token: 0x04008BEE RID: 35822
		[Token(Token = "0x401A140")]
		SubEvent_Topic_370,
		// Token: 0x04008BEF RID: 35823
		[Token(Token = "0x401A141")]
		SubEvent_Topic_371,
		// Token: 0x04008BF0 RID: 35824
		[Token(Token = "0x401A142")]
		SubEvent_Topic_372,
		// Token: 0x04008BF1 RID: 35825
		[Token(Token = "0x401A143")]
		SubEvent_Topic_373,
		// Token: 0x04008BF2 RID: 35826
		[Token(Token = "0x401A144")]
		SubEvent_Topic_500,
		// Token: 0x04008BF3 RID: 35827
		[Token(Token = "0x401A145")]
		SubEvent_Topic_501,
		// Token: 0x04008BF4 RID: 35828
		[Token(Token = "0x401A146")]
		SubEvent_Topic_502,
		// Token: 0x04008BF5 RID: 35829
		[Token(Token = "0x401A147")]
		SubEvent_Topic_510,
		// Token: 0x04008BF6 RID: 35830
		[Token(Token = "0x401A148")]
		SubEvent_Topic_511,
		// Token: 0x04008BF7 RID: 35831
		[Token(Token = "0x401A149")]
		SubEvent_Topic_520,
		// Token: 0x04008BF8 RID: 35832
		[Token(Token = "0x401A14A")]
		SubEvent_Topic_521,
		// Token: 0x04008BF9 RID: 35833
		[Token(Token = "0x401A14B")]
		SubEvent_Topic_530,
		// Token: 0x04008BFA RID: 35834
		[Token(Token = "0x401A14C")]
		SubEvent_Topic_531,
		// Token: 0x04008BFB RID: 35835
		[Token(Token = "0x401A14D")]
		SubEvent_Topic_540,
		// Token: 0x04008BFC RID: 35836
		[Token(Token = "0x401A14E")]
		SubEvent_Topic_541,
		// Token: 0x04008BFD RID: 35837
		[Token(Token = "0x401A14F")]
		SubEvent_Topic_550,
		// Token: 0x04008BFE RID: 35838
		[Token(Token = "0x401A150")]
		SubEvent_Topic_551,
		// Token: 0x04008BFF RID: 35839
		[Token(Token = "0x401A151")]
		SubEvent_Topic_560,
		// Token: 0x04008C00 RID: 35840
		[Token(Token = "0x401A152")]
		SubEvent_Topic_561,
		// Token: 0x04008C01 RID: 35841
		[Token(Token = "0x401A153")]
		SubEvent_Topic_570,
		// Token: 0x04008C02 RID: 35842
		[Token(Token = "0x401A154")]
		SubEvent_Topic_571,
		// Token: 0x04008C03 RID: 35843
		[Token(Token = "0x401A155")]
		SubEvent_Detail_20,
		// Token: 0x04008C04 RID: 35844
		[Token(Token = "0x401A156")]
		SubEvent_Detail_21,
		// Token: 0x04008C05 RID: 35845
		[Token(Token = "0x401A157")]
		SubEvent_Detail_22,
		// Token: 0x04008C06 RID: 35846
		[Token(Token = "0x401A158")]
		SubEvent_Detail_30,
		// Token: 0x04008C07 RID: 35847
		[Token(Token = "0x401A159")]
		SubEvent_Detail_31,
		// Token: 0x04008C08 RID: 35848
		[Token(Token = "0x401A15A")]
		SubEvent_Detail_40,
		// Token: 0x04008C09 RID: 35849
		[Token(Token = "0x401A15B")]
		SubEvent_Detail_41,
		// Token: 0x04008C0A RID: 35850
		[Token(Token = "0x401A15C")]
		SubEvent_Detail_42,
		// Token: 0x04008C0B RID: 35851
		[Token(Token = "0x401A15D")]
		SubEvent_Detail_43,
		// Token: 0x04008C0C RID: 35852
		[Token(Token = "0x401A15E")]
		SubEvent_Detail_90,
		// Token: 0x04008C0D RID: 35853
		[Token(Token = "0x401A15F")]
		SubEvent_Detail_91,
		// Token: 0x04008C0E RID: 35854
		[Token(Token = "0x401A160")]
		SubEvent_Detail_100,
		// Token: 0x04008C0F RID: 35855
		[Token(Token = "0x401A161")]
		SubEvent_Detail_101,
		// Token: 0x04008C10 RID: 35856
		[Token(Token = "0x401A162")]
		SubEvent_Detail_102,
		// Token: 0x04008C11 RID: 35857
		[Token(Token = "0x401A163")]
		SubEvent_Detail_103,
		// Token: 0x04008C12 RID: 35858
		[Token(Token = "0x401A164")]
		SubEvent_Detail_104,
		// Token: 0x04008C13 RID: 35859
		[Token(Token = "0x401A165")]
		SubEvent_Detail_105,
		// Token: 0x04008C14 RID: 35860
		[Token(Token = "0x401A166")]
		SubEvent_Detail_160,
		// Token: 0x04008C15 RID: 35861
		[Token(Token = "0x401A167")]
		SubEvent_Detail_161,
		// Token: 0x04008C16 RID: 35862
		[Token(Token = "0x401A168")]
		SubEvent_Detail_200,
		// Token: 0x04008C17 RID: 35863
		[Token(Token = "0x401A169")]
		SubEvent_Detail_201,
		// Token: 0x04008C18 RID: 35864
		[Token(Token = "0x401A16A")]
		SubEvent_Detail_202,
		// Token: 0x04008C19 RID: 35865
		[Token(Token = "0x401A16B")]
		SubEvent_Detail_220,
		// Token: 0x04008C1A RID: 35866
		[Token(Token = "0x401A16C")]
		SubEvent_Detail_221,
		// Token: 0x04008C1B RID: 35867
		[Token(Token = "0x401A16D")]
		SubEvent_Detail_222,
		// Token: 0x04008C1C RID: 35868
		[Token(Token = "0x401A16E")]
		SubEvent_Detail_250,
		// Token: 0x04008C1D RID: 35869
		[Token(Token = "0x401A16F")]
		SubEvent_Detail_251,
		// Token: 0x04008C1E RID: 35870
		[Token(Token = "0x401A170")]
		SubEvent_Detail_260,
		// Token: 0x04008C1F RID: 35871
		[Token(Token = "0x401A171")]
		SubEvent_Detail_261,
		// Token: 0x04008C20 RID: 35872
		[Token(Token = "0x401A172")]
		SubEvent_Detail_320,
		// Token: 0x04008C21 RID: 35873
		[Token(Token = "0x401A173")]
		SubEvent_Detail_321,
		// Token: 0x04008C22 RID: 35874
		[Token(Token = "0x401A174")]
		SubEvent_Detail_322,
		// Token: 0x04008C23 RID: 35875
		[Token(Token = "0x401A175")]
		SubEvent_Detail_323,
		// Token: 0x04008C24 RID: 35876
		[Token(Token = "0x401A176")]
		SubEvent_Detail_330,
		// Token: 0x04008C25 RID: 35877
		[Token(Token = "0x401A177")]
		SubEvent_Detail_331,
		// Token: 0x04008C26 RID: 35878
		[Token(Token = "0x401A178")]
		SubEvent_Detail_332,
		// Token: 0x04008C27 RID: 35879
		[Token(Token = "0x401A179")]
		SubEvent_Detail_340,
		// Token: 0x04008C28 RID: 35880
		[Token(Token = "0x401A17A")]
		SubEvent_Detail_341,
		// Token: 0x04008C29 RID: 35881
		[Token(Token = "0x401A17B")]
		SubEvent_Detail_370,
		// Token: 0x04008C2A RID: 35882
		[Token(Token = "0x401A17C")]
		SubEvent_Detail_371,
		// Token: 0x04008C2B RID: 35883
		[Token(Token = "0x401A17D")]
		SubEvent_Detail_372,
		// Token: 0x04008C2C RID: 35884
		[Token(Token = "0x401A17E")]
		SubEvent_Detail_373,
		// Token: 0x04008C2D RID: 35885
		[Token(Token = "0x401A17F")]
		SubEvent_Detail_500,
		// Token: 0x04008C2E RID: 35886
		[Token(Token = "0x401A180")]
		SubEvent_Detail_501,
		// Token: 0x04008C2F RID: 35887
		[Token(Token = "0x401A181")]
		SubEvent_Detail_502,
		// Token: 0x04008C30 RID: 35888
		[Token(Token = "0x401A182")]
		SubEvent_Detail_510,
		// Token: 0x04008C31 RID: 35889
		[Token(Token = "0x401A183")]
		SubEvent_Detail_511,
		// Token: 0x04008C32 RID: 35890
		[Token(Token = "0x401A184")]
		SubEvent_Detail_520,
		// Token: 0x04008C33 RID: 35891
		[Token(Token = "0x401A185")]
		SubEvent_Detail_521,
		// Token: 0x04008C34 RID: 35892
		[Token(Token = "0x401A186")]
		SubEvent_Detail_530,
		// Token: 0x04008C35 RID: 35893
		[Token(Token = "0x401A187")]
		SubEvent_Detail_531,
		// Token: 0x04008C36 RID: 35894
		[Token(Token = "0x401A188")]
		SubEvent_Detail_540,
		// Token: 0x04008C37 RID: 35895
		[Token(Token = "0x401A189")]
		SubEvent_Detail_541,
		// Token: 0x04008C38 RID: 35896
		[Token(Token = "0x401A18A")]
		SubEvent_Detail_550,
		// Token: 0x04008C39 RID: 35897
		[Token(Token = "0x401A18B")]
		SubEvent_Detail_551,
		// Token: 0x04008C3A RID: 35898
		[Token(Token = "0x401A18C")]
		SubEvent_Detail_560,
		// Token: 0x04008C3B RID: 35899
		[Token(Token = "0x401A18D")]
		SubEvent_Detail_561,
		// Token: 0x04008C3C RID: 35900
		[Token(Token = "0x401A18E")]
		SubEvent_Detail_570,
		// Token: 0x04008C3D RID: 35901
		[Token(Token = "0x401A18F")]
		SubEvent_Detail_571,
		// Token: 0x04008C3E RID: 35902
		[Token(Token = "0x401A190")]
		OnSave_NextTarget_000 = 31000,
		// Token: 0x04008C3F RID: 35903
		[Token(Token = "0x401A191")]
		OnSave_NextTarget_001,
		// Token: 0x04008C40 RID: 35904
		[Token(Token = "0x401A192")]
		OnSave_NextTarget_002,
		// Token: 0x04008C41 RID: 35905
		[Token(Token = "0x401A193")]
		OnSave_NextTarget_003,
		// Token: 0x04008C42 RID: 35906
		[Token(Token = "0x401A194")]
		OnSave_NextTarget_004,
		// Token: 0x04008C43 RID: 35907
		[Token(Token = "0x401A195")]
		OnSave_NextTarget_005,
		// Token: 0x04008C44 RID: 35908
		[Token(Token = "0x401A196")]
		OnSave_NextTarget_006,
		// Token: 0x04008C45 RID: 35909
		[Token(Token = "0x401A197")]
		OnSave_NextTarget_007,
		// Token: 0x04008C46 RID: 35910
		[Token(Token = "0x401A198")]
		OnSave_NextTarget_008,
		// Token: 0x04008C47 RID: 35911
		[Token(Token = "0x401A199")]
		OnSave_NextTarget_009,
		// Token: 0x04008C48 RID: 35912
		[Token(Token = "0x401A19A")]
		OnSave_NextTarget_010,
		// Token: 0x04008C49 RID: 35913
		[Token(Token = "0x401A19B")]
		OnSave_NextTarget_011,
		// Token: 0x04008C4A RID: 35914
		[Token(Token = "0x401A19C")]
		OnSave_NextTarget_012,
		// Token: 0x04008C4B RID: 35915
		[Token(Token = "0x401A19D")]
		OnSave_NextTarget_013,
		// Token: 0x04008C4C RID: 35916
		[Token(Token = "0x401A19E")]
		OnSave_NextTarget_014,
		// Token: 0x04008C4D RID: 35917
		[Token(Token = "0x401A19F")]
		OnSave_NextTarget_015,
		// Token: 0x04008C4E RID: 35918
		[Token(Token = "0x401A1A0")]
		OnSave_NextTarget_016,
		// Token: 0x04008C4F RID: 35919
		[Token(Token = "0x401A1A1")]
		OnSave_NextTarget_017,
		// Token: 0x04008C50 RID: 35920
		[Token(Token = "0x401A1A2")]
		OnSave_NextTarget_018,
		// Token: 0x04008C51 RID: 35921
		[Token(Token = "0x401A1A3")]
		OnSave_NextTarget_019,
		// Token: 0x04008C52 RID: 35922
		[Token(Token = "0x401A1A4")]
		OnSave_NextTarget_020,
		// Token: 0x04008C53 RID: 35923
		[Token(Token = "0x401A1A5")]
		OnSave_NextTarget_021,
		// Token: 0x04008C54 RID: 35924
		[Token(Token = "0x401A1A6")]
		OnSave_NextTarget_022,
		// Token: 0x04008C55 RID: 35925
		[Token(Token = "0x401A1A7")]
		OnSave_NextTarget_023,
		// Token: 0x04008C56 RID: 35926
		[Token(Token = "0x401A1A8")]
		OnSave_NextTarget_024,
		// Token: 0x04008C57 RID: 35927
		[Token(Token = "0x401A1A9")]
		OnSave_NextTarget_025,
		// Token: 0x04008C58 RID: 35928
		[Token(Token = "0x401A1AA")]
		OnSave_NextTarget_026,
		// Token: 0x04008C59 RID: 35929
		[Token(Token = "0x401A1AB")]
		OnSave_NextTarget_027,
		// Token: 0x04008C5A RID: 35930
		[Token(Token = "0x401A1AC")]
		OnSave_NextTarget_028,
		// Token: 0x04008C5B RID: 35931
		[Token(Token = "0x401A1AD")]
		OnSave_NextTarget_029,
		// Token: 0x04008C5C RID: 35932
		[Token(Token = "0x401A1AE")]
		OnSave_NextTarget_030,
		// Token: 0x04008C5D RID: 35933
		[Token(Token = "0x401A1AF")]
		OnSave_NextTarget_031,
		// Token: 0x04008C5E RID: 35934
		[Token(Token = "0x401A1B0")]
		OnSave_NextTarget_032,
		// Token: 0x04008C5F RID: 35935
		[Token(Token = "0x401A1B1")]
		OnSave_NextTarget_033,
		// Token: 0x04008C60 RID: 35936
		[Token(Token = "0x401A1B2")]
		OnSave_NextTarget_034,
		// Token: 0x04008C61 RID: 35937
		[Token(Token = "0x401A1B3")]
		MainEvent_Topic_000 = 32000,
		// Token: 0x04008C62 RID: 35938
		[Token(Token = "0x401A1B4")]
		MainEvent_Detail_000,
		// Token: 0x04008C63 RID: 35939
		[Token(Token = "0x401A1B5")]
		MainEvent_Topic_001,
		// Token: 0x04008C64 RID: 35940
		[Token(Token = "0x401A1B6")]
		MainEvent_Detail_001,
		// Token: 0x04008C65 RID: 35941
		[Token(Token = "0x401A1B7")]
		MainEvent_Topic_002,
		// Token: 0x04008C66 RID: 35942
		[Token(Token = "0x401A1B8")]
		MainEvent_Detail_002,
		// Token: 0x04008C67 RID: 35943
		[Token(Token = "0x401A1B9")]
		MainEvent_Topic_003,
		// Token: 0x04008C68 RID: 35944
		[Token(Token = "0x401A1BA")]
		MainEvent_Detail_003,
		// Token: 0x04008C69 RID: 35945
		[Token(Token = "0x401A1BB")]
		MainEvent_Topic_004,
		// Token: 0x04008C6A RID: 35946
		[Token(Token = "0x401A1BC")]
		MainEvent_Detail_004,
		// Token: 0x04008C6B RID: 35947
		[Token(Token = "0x401A1BD")]
		MainEvent_Topic_005,
		// Token: 0x04008C6C RID: 35948
		[Token(Token = "0x401A1BE")]
		MainEvent_Detail_005,
		// Token: 0x04008C6D RID: 35949
		[Token(Token = "0x401A1BF")]
		MainEvent_Topic_006,
		// Token: 0x04008C6E RID: 35950
		[Token(Token = "0x401A1C0")]
		MainEvent_Detail_006,
		// Token: 0x04008C6F RID: 35951
		[Token(Token = "0x401A1C1")]
		MainEvent_Topic_007,
		// Token: 0x04008C70 RID: 35952
		[Token(Token = "0x401A1C2")]
		MainEvent_Detail_007,
		// Token: 0x04008C71 RID: 35953
		[Token(Token = "0x401A1C3")]
		MainEvent_Topic_008,
		// Token: 0x04008C72 RID: 35954
		[Token(Token = "0x401A1C4")]
		MainEvent_Detail_008,
		// Token: 0x04008C73 RID: 35955
		[Token(Token = "0x401A1C5")]
		MainEvent_Topic_009,
		// Token: 0x04008C74 RID: 35956
		[Token(Token = "0x401A1C6")]
		MainEvent_Detail_009,
		// Token: 0x04008C75 RID: 35957
		[Token(Token = "0x401A1C7")]
		MainEvent_Topic_010,
		// Token: 0x04008C76 RID: 35958
		[Token(Token = "0x401A1C8")]
		MainEvent_Detail_010,
		// Token: 0x04008C77 RID: 35959
		[Token(Token = "0x401A1C9")]
		MainEvent_Topic_011,
		// Token: 0x04008C78 RID: 35960
		[Token(Token = "0x401A1CA")]
		MainEvent_Detail_011,
		// Token: 0x04008C79 RID: 35961
		[Token(Token = "0x401A1CB")]
		MainEvent_Topic_012,
		// Token: 0x04008C7A RID: 35962
		[Token(Token = "0x401A1CC")]
		MainEvent_Detail_012,
		// Token: 0x04008C7B RID: 35963
		[Token(Token = "0x401A1CD")]
		MainEvent_Topic_013,
		// Token: 0x04008C7C RID: 35964
		[Token(Token = "0x401A1CE")]
		MainEvent_Detail_013,
		// Token: 0x04008C7D RID: 35965
		[Token(Token = "0x401A1CF")]
		MainEvent_Topic_014,
		// Token: 0x04008C7E RID: 35966
		[Token(Token = "0x401A1D0")]
		MainEvent_Detail_014,
		// Token: 0x04008C7F RID: 35967
		[Token(Token = "0x401A1D1")]
		MainEvent_Topic_015,
		// Token: 0x04008C80 RID: 35968
		[Token(Token = "0x401A1D2")]
		MainEvent_Detail_015,
		// Token: 0x04008C81 RID: 35969
		[Token(Token = "0x401A1D3")]
		MainEvent_Topic_016,
		// Token: 0x04008C82 RID: 35970
		[Token(Token = "0x401A1D4")]
		MainEvent_Detail_016,
		// Token: 0x04008C83 RID: 35971
		[Token(Token = "0x401A1D5")]
		MainEvent_Topic_017,
		// Token: 0x04008C84 RID: 35972
		[Token(Token = "0x401A1D6")]
		MainEvent_Detail_017,
		// Token: 0x04008C85 RID: 35973
		[Token(Token = "0x401A1D7")]
		MainEvent_Topic_018,
		// Token: 0x04008C86 RID: 35974
		[Token(Token = "0x401A1D8")]
		MainEvent_Detail_018,
		// Token: 0x04008C87 RID: 35975
		[Token(Token = "0x401A1D9")]
		MainEvent_Topic_019,
		// Token: 0x04008C88 RID: 35976
		[Token(Token = "0x401A1DA")]
		MainEvent_Detail_019,
		// Token: 0x04008C89 RID: 35977
		[Token(Token = "0x401A1DB")]
		MainEvent_Topic_020,
		// Token: 0x04008C8A RID: 35978
		[Token(Token = "0x401A1DC")]
		MainEvent_Detail_020,
		// Token: 0x04008C8B RID: 35979
		[Token(Token = "0x401A1DD")]
		MainEvent_Topic_021,
		// Token: 0x04008C8C RID: 35980
		[Token(Token = "0x401A1DE")]
		MainEvent_Detail_021,
		// Token: 0x04008C8D RID: 35981
		[Token(Token = "0x401A1DF")]
		MainEvent_Topic_022,
		// Token: 0x04008C8E RID: 35982
		[Token(Token = "0x401A1E0")]
		MainEvent_Detail_022,
		// Token: 0x04008C8F RID: 35983
		[Token(Token = "0x401A1E1")]
		MainEvent_Topic_023,
		// Token: 0x04008C90 RID: 35984
		[Token(Token = "0x401A1E2")]
		MainEvent_Detail_023,
		// Token: 0x04008C91 RID: 35985
		[Token(Token = "0x401A1E3")]
		MainEvent_Topic_024,
		// Token: 0x04008C92 RID: 35986
		[Token(Token = "0x401A1E4")]
		MainEvent_Detail_024,
		// Token: 0x04008C93 RID: 35987
		[Token(Token = "0x401A1E5")]
		MainEvent_Topic_025,
		// Token: 0x04008C94 RID: 35988
		[Token(Token = "0x401A1E6")]
		MainEvent_Detail_025,
		// Token: 0x04008C95 RID: 35989
		[Token(Token = "0x401A1E7")]
		MainEvent_Topic_026,
		// Token: 0x04008C96 RID: 35990
		[Token(Token = "0x401A1E8")]
		MainEvent_Detail_026,
		// Token: 0x04008C97 RID: 35991
		[Token(Token = "0x401A1E9")]
		MainEvent_Topic_027,
		// Token: 0x04008C98 RID: 35992
		[Token(Token = "0x401A1EA")]
		MainEvent_Detail_027,
		// Token: 0x04008C99 RID: 35993
		[Token(Token = "0x401A1EB")]
		MainEvent_Topic_028,
		// Token: 0x04008C9A RID: 35994
		[Token(Token = "0x401A1EC")]
		MainEvent_Detail_028,
		// Token: 0x04008C9B RID: 35995
		[Token(Token = "0x401A1ED")]
		MainEvent_Topic_029,
		// Token: 0x04008C9C RID: 35996
		[Token(Token = "0x401A1EE")]
		MainEvent_Detail_029,
		// Token: 0x04008C9D RID: 35997
		[Token(Token = "0x401A1EF")]
		MainEvent_Topic_030,
		// Token: 0x04008C9E RID: 35998
		[Token(Token = "0x401A1F0")]
		MainEvent_Detail_030,
		// Token: 0x04008C9F RID: 35999
		[Token(Token = "0x401A1F1")]
		MainEvent_Topic_031,
		// Token: 0x04008CA0 RID: 36000
		[Token(Token = "0x401A1F2")]
		MainEvent_Detail_031,
		// Token: 0x04008CA1 RID: 36001
		[Token(Token = "0x401A1F3")]
		MainEvent_Topic_032,
		// Token: 0x04008CA2 RID: 36002
		[Token(Token = "0x401A1F4")]
		MainEvent_Detail_032,
		// Token: 0x04008CA3 RID: 36003
		[Token(Token = "0x401A1F5")]
		MainEvent_Topic_033,
		// Token: 0x04008CA4 RID: 36004
		[Token(Token = "0x401A1F6")]
		MainEvent_Detail_033,
		// Token: 0x04008CA5 RID: 36005
		[Token(Token = "0x401A1F7")]
		MainEvent_Topic_034,
		// Token: 0x04008CA6 RID: 36006
		[Token(Token = "0x401A1F8")]
		MainEvent_Detail_034,
		// Token: 0x04008CA7 RID: 36007
		[Token(Token = "0x401A1F9")]
		MainEvent_Topic_035,
		// Token: 0x04008CA8 RID: 36008
		[Token(Token = "0x401A1FA")]
		MainEvent_Detail_035,
		// Token: 0x04008CA9 RID: 36009
		[Token(Token = "0x401A1FB")]
		MainEvent_Topic_036,
		// Token: 0x04008CAA RID: 36010
		[Token(Token = "0x401A1FC")]
		MainEvent_Detail_036,
		// Token: 0x04008CAB RID: 36011
		[Token(Token = "0x401A1FD")]
		MainEvent_Topic_037,
		// Token: 0x04008CAC RID: 36012
		[Token(Token = "0x401A1FE")]
		MainEvent_Detail_037,
		// Token: 0x04008CAD RID: 36013
		[Token(Token = "0x401A1FF")]
		MainEvent_Topic_038,
		// Token: 0x04008CAE RID: 36014
		[Token(Token = "0x401A200")]
		MainEvent_Detail_038,
		// Token: 0x04008CAF RID: 36015
		[Token(Token = "0x401A201")]
		MainEvent_Topic_039,
		// Token: 0x04008CB0 RID: 36016
		[Token(Token = "0x401A202")]
		MainEvent_Detail_039,
		// Token: 0x04008CB1 RID: 36017
		[Token(Token = "0x401A203")]
		MainEvent_Topic_040,
		// Token: 0x04008CB2 RID: 36018
		[Token(Token = "0x401A204")]
		MainEvent_Detail_040,
		// Token: 0x04008CB3 RID: 36019
		[Token(Token = "0x401A205")]
		MainEvent_Topic_041,
		// Token: 0x04008CB4 RID: 36020
		[Token(Token = "0x401A206")]
		MainEvent_Detail_041,
		// Token: 0x04008CB5 RID: 36021
		[Token(Token = "0x401A207")]
		MainEvent_Topic_042,
		// Token: 0x04008CB6 RID: 36022
		[Token(Token = "0x401A208")]
		MainEvent_Detail_042,
		// Token: 0x04008CB7 RID: 36023
		[Token(Token = "0x401A209")]
		MainEvent_Topic_043,
		// Token: 0x04008CB8 RID: 36024
		[Token(Token = "0x401A20A")]
		MainEvent_Detail_043,
		// Token: 0x04008CB9 RID: 36025
		[Token(Token = "0x401A20B")]
		MainEvent_Topic_044,
		// Token: 0x04008CBA RID: 36026
		[Token(Token = "0x401A20C")]
		MainEvent_Detail_044,
		// Token: 0x04008CBB RID: 36027
		[Token(Token = "0x401A20D")]
		MainEvent_Topic_045,
		// Token: 0x04008CBC RID: 36028
		[Token(Token = "0x401A20E")]
		MainEvent_Detail_045,
		// Token: 0x04008CBD RID: 36029
		[Token(Token = "0x401A20F")]
		MainEvent_Topic_046,
		// Token: 0x04008CBE RID: 36030
		[Token(Token = "0x401A210")]
		MainEvent_Detail_046,
		// Token: 0x04008CBF RID: 36031
		[Token(Token = "0x401A211")]
		MainEvent_Topic_047,
		// Token: 0x04008CC0 RID: 36032
		[Token(Token = "0x401A212")]
		MainEvent_Detail_047,
		// Token: 0x04008CC1 RID: 36033
		[Token(Token = "0x401A213")]
		MainEvent_Topic_048,
		// Token: 0x04008CC2 RID: 36034
		[Token(Token = "0x401A214")]
		MainEvent_Detail_048,
		// Token: 0x04008CC3 RID: 36035
		[Token(Token = "0x401A215")]
		MainEvent_Topic_049,
		// Token: 0x04008CC4 RID: 36036
		[Token(Token = "0x401A216")]
		MainEvent_Detail_049,
		// Token: 0x04008CC5 RID: 36037
		[Token(Token = "0x401A217")]
		MainEvent_Topic_050,
		// Token: 0x04008CC6 RID: 36038
		[Token(Token = "0x401A218")]
		MainEvent_Detail_050,
		// Token: 0x04008CC7 RID: 36039
		[Token(Token = "0x401A219")]
		MainEvent_Topic_051,
		// Token: 0x04008CC8 RID: 36040
		[Token(Token = "0x401A21A")]
		MainEvent_Detail_051,
		// Token: 0x04008CC9 RID: 36041
		[Token(Token = "0x401A21B")]
		MainEvent_Topic_052,
		// Token: 0x04008CCA RID: 36042
		[Token(Token = "0x401A21C")]
		MainEvent_Detail_052,
		// Token: 0x04008CCB RID: 36043
		[Token(Token = "0x401A21D")]
		MainEvent_Topic_053,
		// Token: 0x04008CCC RID: 36044
		[Token(Token = "0x401A21E")]
		MainEvent_Detail_053,
		// Token: 0x04008CCD RID: 36045
		[Token(Token = "0x401A21F")]
		MainEvent_Topic_054,
		// Token: 0x04008CCE RID: 36046
		[Token(Token = "0x401A220")]
		MainEvent_Detail_054,
		// Token: 0x04008CCF RID: 36047
		[Token(Token = "0x401A221")]
		MainEvent_Topic_055,
		// Token: 0x04008CD0 RID: 36048
		[Token(Token = "0x401A222")]
		MainEvent_Detail_055,
		// Token: 0x04008CD1 RID: 36049
		[Token(Token = "0x401A223")]
		MainEvent_Topic_056,
		// Token: 0x04008CD2 RID: 36050
		[Token(Token = "0x401A224")]
		MainEvent_Detail_056,
		// Token: 0x04008CD3 RID: 36051
		[Token(Token = "0x401A225")]
		MainEvent_Topic_057,
		// Token: 0x04008CD4 RID: 36052
		[Token(Token = "0x401A226")]
		MainEvent_Detail_057,
		// Token: 0x04008CD5 RID: 36053
		[Token(Token = "0x401A227")]
		MainEvent_Topic_058,
		// Token: 0x04008CD6 RID: 36054
		[Token(Token = "0x401A228")]
		MainEvent_Detail_058,
		// Token: 0x04008CD7 RID: 36055
		[Token(Token = "0x401A229")]
		MainEvent_Topic_059,
		// Token: 0x04008CD8 RID: 36056
		[Token(Token = "0x401A22A")]
		MainEvent_Detail_059,
		// Token: 0x04008CD9 RID: 36057
		[Token(Token = "0x401A22B")]
		MainEvent_Topic_060,
		// Token: 0x04008CDA RID: 36058
		[Token(Token = "0x401A22C")]
		MainEvent_Detail_060,
		// Token: 0x04008CDB RID: 36059
		[Token(Token = "0x401A22D")]
		MainEvent_Topic_061,
		// Token: 0x04008CDC RID: 36060
		[Token(Token = "0x401A22E")]
		MainEvent_Detail_061,
		// Token: 0x04008CDD RID: 36061
		[Token(Token = "0x401A22F")]
		MainEvent_Topic_062,
		// Token: 0x04008CDE RID: 36062
		[Token(Token = "0x401A230")]
		MainEvent_Detail_062,
		// Token: 0x04008CDF RID: 36063
		[Token(Token = "0x401A231")]
		MainEvent_Topic_063,
		// Token: 0x04008CE0 RID: 36064
		[Token(Token = "0x401A232")]
		MainEvent_Detail_063,
		// Token: 0x04008CE1 RID: 36065
		[Token(Token = "0x401A233")]
		MainEvent_Topic_064,
		// Token: 0x04008CE2 RID: 36066
		[Token(Token = "0x401A234")]
		MainEvent_Detail_064,
		// Token: 0x04008CE3 RID: 36067
		[Token(Token = "0x401A235")]
		MainEvent_Topic_065,
		// Token: 0x04008CE4 RID: 36068
		[Token(Token = "0x401A236")]
		MainEvent_Detail_065,
		// Token: 0x04008CE5 RID: 36069
		[Token(Token = "0x401A237")]
		MainEvent_Topic_066,
		// Token: 0x04008CE6 RID: 36070
		[Token(Token = "0x401A238")]
		MainEvent_Detail_066,
		// Token: 0x04008CE7 RID: 36071
		[Token(Token = "0x401A239")]
		MainEvent_Topic_067,
		// Token: 0x04008CE8 RID: 36072
		[Token(Token = "0x401A23A")]
		MainEvent_Detail_067,
		// Token: 0x04008CE9 RID: 36073
		[Token(Token = "0x401A23B")]
		MainEvent_Topic_068,
		// Token: 0x04008CEA RID: 36074
		[Token(Token = "0x401A23C")]
		MainEvent_Detail_068,
		// Token: 0x04008CEB RID: 36075
		[Token(Token = "0x401A23D")]
		MainEvent_Topic_069,
		// Token: 0x04008CEC RID: 36076
		[Token(Token = "0x401A23E")]
		MainEvent_Detail_069,
		// Token: 0x04008CED RID: 36077
		[Token(Token = "0x401A23F")]
		MainEvent_Topic_070,
		// Token: 0x04008CEE RID: 36078
		[Token(Token = "0x401A240")]
		MainEvent_Detail_070,
		// Token: 0x04008CEF RID: 36079
		[Token(Token = "0x401A241")]
		MainEvent_Topic_071,
		// Token: 0x04008CF0 RID: 36080
		[Token(Token = "0x401A242")]
		MainEvent_Detail_071,
		// Token: 0x04008CF1 RID: 36081
		[Token(Token = "0x401A243")]
		MainEvent_Topic_072,
		// Token: 0x04008CF2 RID: 36082
		[Token(Token = "0x401A244")]
		MainEvent_Detail_072,
		// Token: 0x04008CF3 RID: 36083
		[Token(Token = "0x401A245")]
		MainEvent_Topic_073,
		// Token: 0x04008CF4 RID: 36084
		[Token(Token = "0x401A246")]
		MainEvent_Detail_073,
		// Token: 0x04008CF5 RID: 36085
		[Token(Token = "0x401A247")]
		MainEvent_Topic_074,
		// Token: 0x04008CF6 RID: 36086
		[Token(Token = "0x401A248")]
		MainEvent_Detail_074,
		// Token: 0x04008CF7 RID: 36087
		[Token(Token = "0x401A249")]
		MainEvent_Topic_075,
		// Token: 0x04008CF8 RID: 36088
		[Token(Token = "0x401A24A")]
		MainEvent_Detail_075,
		// Token: 0x04008CF9 RID: 36089
		[Token(Token = "0x401A24B")]
		MainEvent_Topic_076,
		// Token: 0x04008CFA RID: 36090
		[Token(Token = "0x401A24C")]
		MainEvent_Detail_076,
		// Token: 0x04008CFB RID: 36091
		[Token(Token = "0x401A24D")]
		MainEvent_Topic_077,
		// Token: 0x04008CFC RID: 36092
		[Token(Token = "0x401A24E")]
		MainEvent_Detail_077,
		// Token: 0x04008CFD RID: 36093
		[Token(Token = "0x401A24F")]
		MainEvent_Topic_078,
		// Token: 0x04008CFE RID: 36094
		[Token(Token = "0x401A250")]
		MainEvent_Detail_078,
		// Token: 0x04008CFF RID: 36095
		[Token(Token = "0x401A251")]
		MainEvent_Topic_079,
		// Token: 0x04008D00 RID: 36096
		[Token(Token = "0x401A252")]
		MainEvent_Detail_079,
		// Token: 0x04008D01 RID: 36097
		[Token(Token = "0x401A253")]
		MainEvent_Topic_080,
		// Token: 0x04008D02 RID: 36098
		[Token(Token = "0x401A254")]
		MainEvent_Detail_080,
		// Token: 0x04008D03 RID: 36099
		[Token(Token = "0x401A255")]
		MainEvent_Topic_081,
		// Token: 0x04008D04 RID: 36100
		[Token(Token = "0x401A256")]
		MainEvent_Detail_081,
		// Token: 0x04008D05 RID: 36101
		[Token(Token = "0x401A257")]
		MainEvent_Topic_082,
		// Token: 0x04008D06 RID: 36102
		[Token(Token = "0x401A258")]
		MainEvent_Detail_082,
		// Token: 0x04008D07 RID: 36103
		[Token(Token = "0x401A259")]
		MainEvent_Topic_083,
		// Token: 0x04008D08 RID: 36104
		[Token(Token = "0x401A25A")]
		MainEvent_Detail_083,
		// Token: 0x04008D09 RID: 36105
		[Token(Token = "0x401A25B")]
		MainEvent_Topic_084,
		// Token: 0x04008D0A RID: 36106
		[Token(Token = "0x401A25C")]
		MainEvent_Detail_084,
		// Token: 0x04008D0B RID: 36107
		[Token(Token = "0x401A25D")]
		MainEvent_Topic_085,
		// Token: 0x04008D0C RID: 36108
		[Token(Token = "0x401A25E")]
		MainEvent_Detail_085,
		// Token: 0x04008D0D RID: 36109
		[Token(Token = "0x401A25F")]
		MainEvent_Topic_086,
		// Token: 0x04008D0E RID: 36110
		[Token(Token = "0x401A260")]
		MainEvent_Detail_086,
		// Token: 0x04008D0F RID: 36111
		[Token(Token = "0x401A261")]
		MainEvent_Topic_087,
		// Token: 0x04008D10 RID: 36112
		[Token(Token = "0x401A262")]
		MainEvent_Detail_087,
		// Token: 0x04008D11 RID: 36113
		[Token(Token = "0x401A263")]
		MainEvent_Topic_088,
		// Token: 0x04008D12 RID: 36114
		[Token(Token = "0x401A264")]
		MainEvent_Detail_088,
		// Token: 0x04008D13 RID: 36115
		[Token(Token = "0x401A265")]
		MainEvent_Topic_089,
		// Token: 0x04008D14 RID: 36116
		[Token(Token = "0x401A266")]
		MainEvent_Detail_089,
		// Token: 0x04008D15 RID: 36117
		[Token(Token = "0x401A267")]
		MainEvent_Topic_090,
		// Token: 0x04008D16 RID: 36118
		[Token(Token = "0x401A268")]
		MainEvent_Detail_090,
		// Token: 0x04008D17 RID: 36119
		[Token(Token = "0x401A269")]
		MainEvent_Topic_091,
		// Token: 0x04008D18 RID: 36120
		[Token(Token = "0x401A26A")]
		MainEvent_Detail_091,
		// Token: 0x04008D19 RID: 36121
		[Token(Token = "0x401A26B")]
		MainEvent_Topic_092,
		// Token: 0x04008D1A RID: 36122
		[Token(Token = "0x401A26C")]
		MainEvent_Detail_092,
		// Token: 0x04008D1B RID: 36123
		[Token(Token = "0x401A26D")]
		MainEvent_Topic_093,
		// Token: 0x04008D1C RID: 36124
		[Token(Token = "0x401A26E")]
		MainEvent_Detail_093,
		// Token: 0x04008D1D RID: 36125
		[Token(Token = "0x401A26F")]
		MainEvent_Topic_094,
		// Token: 0x04008D1E RID: 36126
		[Token(Token = "0x401A270")]
		MainEvent_Detail_094,
		// Token: 0x04008D1F RID: 36127
		[Token(Token = "0x401A271")]
		MainEvent_Topic_095,
		// Token: 0x04008D20 RID: 36128
		[Token(Token = "0x401A272")]
		MainEvent_Detail_095,
		// Token: 0x04008D21 RID: 36129
		[Token(Token = "0x401A273")]
		MainEvent_Topic_096,
		// Token: 0x04008D22 RID: 36130
		[Token(Token = "0x401A274")]
		MainEvent_Detail_096,
		// Token: 0x04008D23 RID: 36131
		[Token(Token = "0x401A275")]
		MainEvent_Topic_097,
		// Token: 0x04008D24 RID: 36132
		[Token(Token = "0x401A276")]
		MainEvent_Detail_097,
		// Token: 0x04008D25 RID: 36133
		[Token(Token = "0x401A277")]
		MainEvent_Topic_098,
		// Token: 0x04008D26 RID: 36134
		[Token(Token = "0x401A278")]
		MainEvent_Detail_098,
		// Token: 0x04008D27 RID: 36135
		[Token(Token = "0x401A279")]
		MainEvent_Topic_099,
		// Token: 0x04008D28 RID: 36136
		[Token(Token = "0x401A27A")]
		MainEvent_Detail_099,
		// Token: 0x04008D29 RID: 36137
		[Token(Token = "0x401A27B")]
		MainEvent_Topic_100,
		// Token: 0x04008D2A RID: 36138
		[Token(Token = "0x401A27C")]
		MainEvent_Detail_100,
		// Token: 0x04008D2B RID: 36139
		[Token(Token = "0x401A27D")]
		MainEvent_Topic_101,
		// Token: 0x04008D2C RID: 36140
		[Token(Token = "0x401A27E")]
		MainEvent_Detail_101,
		// Token: 0x04008D2D RID: 36141
		[Token(Token = "0x401A27F")]
		MainEvent_Topic_102,
		// Token: 0x04008D2E RID: 36142
		[Token(Token = "0x401A280")]
		MainEvent_Detail_102,
		// Token: 0x04008D2F RID: 36143
		[Token(Token = "0x401A281")]
		MainEvent_Topic_103,
		// Token: 0x04008D30 RID: 36144
		[Token(Token = "0x401A282")]
		MainEvent_Detail_103,
		// Token: 0x04008D31 RID: 36145
		[Token(Token = "0x401A283")]
		MainEvent_Topic_104,
		// Token: 0x04008D32 RID: 36146
		[Token(Token = "0x401A284")]
		MainEvent_Detail_104,
		// Token: 0x04008D33 RID: 36147
		[Token(Token = "0x401A285")]
		MainEvent_Topic_105,
		// Token: 0x04008D34 RID: 36148
		[Token(Token = "0x401A286")]
		MainEvent_Detail_105,
		// Token: 0x04008D35 RID: 36149
		[Token(Token = "0x401A287")]
		MainEvent_Topic_106,
		// Token: 0x04008D36 RID: 36150
		[Token(Token = "0x401A288")]
		MainEvent_Detail_106,
		// Token: 0x04008D37 RID: 36151
		[Token(Token = "0x401A289")]
		MainEvent_Topic_999,
		// Token: 0x04008D38 RID: 36152
		[Token(Token = "0x401A28A")]
		MainEvent_Detail_999,
		// Token: 0x04008D39 RID: 36153
		[Token(Token = "0x401A28B")]
		LoveEvent_Topic_2020 = 33000,
		// Token: 0x04008D3A RID: 36154
		[Token(Token = "0x401A28C")]
		LoveEvent_Topic_2021,
		// Token: 0x04008D3B RID: 36155
		[Token(Token = "0x401A28D")]
		LoveEvent_Topic_2040,
		// Token: 0x04008D3C RID: 36156
		[Token(Token = "0x401A28E")]
		LoveEvent_Topic_2041,
		// Token: 0x04008D3D RID: 36157
		[Token(Token = "0x401A28F")]
		LoveEvent_Topic_2050,
		// Token: 0x04008D3E RID: 36158
		[Token(Token = "0x401A290")]
		LoveEvent_Topic_2060,
		// Token: 0x04008D3F RID: 36159
		[Token(Token = "0x401A291")]
		LoveEvent_Topic_2070,
		// Token: 0x04008D40 RID: 36160
		[Token(Token = "0x401A292")]
		LoveEvent_Topic_2080,
		// Token: 0x04008D41 RID: 36161
		[Token(Token = "0x401A293")]
		LoveEvent_Topic_2090,
		// Token: 0x04008D42 RID: 36162
		[Token(Token = "0x401A294")]
		LoveEvent_Topic_2091,
		// Token: 0x04008D43 RID: 36163
		[Token(Token = "0x401A295")]
		LoveEvent_Topic_2092,
		// Token: 0x04008D44 RID: 36164
		[Token(Token = "0x401A296")]
		LoveEvent_Topic_2093,
		// Token: 0x04008D45 RID: 36165
		[Token(Token = "0x401A297")]
		LoveEvent_Topic_2094,
		// Token: 0x04008D46 RID: 36166
		[Token(Token = "0x401A298")]
		LoveEvent_Topic_2095,
		// Token: 0x04008D47 RID: 36167
		[Token(Token = "0x401A299")]
		LoveEvent_Topic_2096,
		// Token: 0x04008D48 RID: 36168
		[Token(Token = "0x401A29A")]
		LoveEvent_Topic_2097,
		// Token: 0x04008D49 RID: 36169
		[Token(Token = "0x401A29B")]
		LoveEvent_Topic_3020,
		// Token: 0x04008D4A RID: 36170
		[Token(Token = "0x401A29C")]
		LoveEvent_Topic_3021,
		// Token: 0x04008D4B RID: 36171
		[Token(Token = "0x401A29D")]
		LoveEvent_Topic_3022,
		// Token: 0x04008D4C RID: 36172
		[Token(Token = "0x401A29E")]
		LoveEvent_Topic_3023,
		// Token: 0x04008D4D RID: 36173
		[Token(Token = "0x401A29F")]
		LoveEvent_Topic_3040,
		// Token: 0x04008D4E RID: 36174
		[Token(Token = "0x401A2A0")]
		LoveEvent_Topic_3041,
		// Token: 0x04008D4F RID: 36175
		[Token(Token = "0x401A2A1")]
		LoveEvent_Topic_3042,
		// Token: 0x04008D50 RID: 36176
		[Token(Token = "0x401A2A2")]
		LoveEvent_Topic_3043,
		// Token: 0x04008D51 RID: 36177
		[Token(Token = "0x401A2A3")]
		LoveEvent_Topic_3044,
		// Token: 0x04008D52 RID: 36178
		[Token(Token = "0x401A2A4")]
		LoveEvent_Topic_3050,
		// Token: 0x04008D53 RID: 36179
		[Token(Token = "0x401A2A5")]
		LoveEvent_Topic_3060,
		// Token: 0x04008D54 RID: 36180
		[Token(Token = "0x401A2A6")]
		LoveEvent_Topic_3070,
		// Token: 0x04008D55 RID: 36181
		[Token(Token = "0x401A2A7")]
		LoveEvent_Topic_3080,
		// Token: 0x04008D56 RID: 36182
		[Token(Token = "0x401A2A8")]
		LoveEvent_Topic_3090,
		// Token: 0x04008D57 RID: 36183
		[Token(Token = "0x401A2A9")]
		LoveEvent_Topic_3091,
		// Token: 0x04008D58 RID: 36184
		[Token(Token = "0x401A2AA")]
		LoveEvent_Topic_3092,
		// Token: 0x04008D59 RID: 36185
		[Token(Token = "0x401A2AB")]
		LoveEvent_Topic_3093,
		// Token: 0x04008D5A RID: 36186
		[Token(Token = "0x401A2AC")]
		LoveEvent_Topic_3094,
		// Token: 0x04008D5B RID: 36187
		[Token(Token = "0x401A2AD")]
		LoveEvent_Topic_3095,
		// Token: 0x04008D5C RID: 36188
		[Token(Token = "0x401A2AE")]
		LoveEvent_Topic_3096,
		// Token: 0x04008D5D RID: 36189
		[Token(Token = "0x401A2AF")]
		LoveEvent_Topic_3097,
		// Token: 0x04008D5E RID: 36190
		[Token(Token = "0x401A2B0")]
		LoveEvent_Topic_3098,
		// Token: 0x04008D5F RID: 36191
		[Token(Token = "0x401A2B1")]
		LoveEvent_Topic_3099,
		// Token: 0x04008D60 RID: 36192
		[Token(Token = "0x401A2B2")]
		LoveEvent_Topic_4020,
		// Token: 0x04008D61 RID: 36193
		[Token(Token = "0x401A2B3")]
		LoveEvent_Topic_4021,
		// Token: 0x04008D62 RID: 36194
		[Token(Token = "0x401A2B4")]
		LoveEvent_Topic_4040,
		// Token: 0x04008D63 RID: 36195
		[Token(Token = "0x401A2B5")]
		LoveEvent_Topic_4041,
		// Token: 0x04008D64 RID: 36196
		[Token(Token = "0x401A2B6")]
		LoveEvent_Topic_4042,
		// Token: 0x04008D65 RID: 36197
		[Token(Token = "0x401A2B7")]
		LoveEvent_Topic_4050,
		// Token: 0x04008D66 RID: 36198
		[Token(Token = "0x401A2B8")]
		LoveEvent_Topic_4060,
		// Token: 0x04008D67 RID: 36199
		[Token(Token = "0x401A2B9")]
		LoveEvent_Topic_4070,
		// Token: 0x04008D68 RID: 36200
		[Token(Token = "0x401A2BA")]
		LoveEvent_Topic_4080,
		// Token: 0x04008D69 RID: 36201
		[Token(Token = "0x401A2BB")]
		LoveEvent_Topic_4090,
		// Token: 0x04008D6A RID: 36202
		[Token(Token = "0x401A2BC")]
		LoveEvent_Topic_4091,
		// Token: 0x04008D6B RID: 36203
		[Token(Token = "0x401A2BD")]
		LoveEvent_Topic_4092,
		// Token: 0x04008D6C RID: 36204
		[Token(Token = "0x401A2BE")]
		LoveEvent_Topic_4093,
		// Token: 0x04008D6D RID: 36205
		[Token(Token = "0x401A2BF")]
		LoveEvent_Topic_4094,
		// Token: 0x04008D6E RID: 36206
		[Token(Token = "0x401A2C0")]
		LoveEvent_Topic_4095,
		// Token: 0x04008D6F RID: 36207
		[Token(Token = "0x401A2C1")]
		LoveEvent_Topic_4096,
		// Token: 0x04008D70 RID: 36208
		[Token(Token = "0x401A2C2")]
		LoveEvent_Topic_4097,
		// Token: 0x04008D71 RID: 36209
		[Token(Token = "0x401A2C3")]
		LoveEvent_Topic_4098,
		// Token: 0x04008D72 RID: 36210
		[Token(Token = "0x401A2C4")]
		LoveEvent_Topic_4099,
		// Token: 0x04008D73 RID: 36211
		[Token(Token = "0x401A2C5")]
		LoveEvent_Topic_4100,
		// Token: 0x04008D74 RID: 36212
		[Token(Token = "0x401A2C6")]
		LoveEvent_Topic_4101,
		// Token: 0x04008D75 RID: 36213
		[Token(Token = "0x401A2C7")]
		LoveEvent_Topic_4102,
		// Token: 0x04008D76 RID: 36214
		[Token(Token = "0x401A2C8")]
		LoveEvent_Topic_4103,
		// Token: 0x04008D77 RID: 36215
		[Token(Token = "0x401A2C9")]
		LoveEvent_Topic_4104,
		// Token: 0x04008D78 RID: 36216
		[Token(Token = "0x401A2CA")]
		LoveEvent_Topic_5020,
		// Token: 0x04008D79 RID: 36217
		[Token(Token = "0x401A2CB")]
		LoveEvent_Topic_5021,
		// Token: 0x04008D7A RID: 36218
		[Token(Token = "0x401A2CC")]
		LoveEvent_Topic_5022,
		// Token: 0x04008D7B RID: 36219
		[Token(Token = "0x401A2CD")]
		LoveEvent_Topic_5023,
		// Token: 0x04008D7C RID: 36220
		[Token(Token = "0x401A2CE")]
		LoveEvent_Topic_5024,
		// Token: 0x04008D7D RID: 36221
		[Token(Token = "0x401A2CF")]
		LoveEvent_Topic_5040,
		// Token: 0x04008D7E RID: 36222
		[Token(Token = "0x401A2D0")]
		LoveEvent_Topic_5041,
		// Token: 0x04008D7F RID: 36223
		[Token(Token = "0x401A2D1")]
		LoveEvent_Topic_5042,
		// Token: 0x04008D80 RID: 36224
		[Token(Token = "0x401A2D2")]
		LoveEvent_Topic_5050,
		// Token: 0x04008D81 RID: 36225
		[Token(Token = "0x401A2D3")]
		LoveEvent_Topic_5060,
		// Token: 0x04008D82 RID: 36226
		[Token(Token = "0x401A2D4")]
		LoveEvent_Topic_5070,
		// Token: 0x04008D83 RID: 36227
		[Token(Token = "0x401A2D5")]
		LoveEvent_Topic_5080,
		// Token: 0x04008D84 RID: 36228
		[Token(Token = "0x401A2D6")]
		LoveEvent_Topic_5090,
		// Token: 0x04008D85 RID: 36229
		[Token(Token = "0x401A2D7")]
		LoveEvent_Topic_5091,
		// Token: 0x04008D86 RID: 36230
		[Token(Token = "0x401A2D8")]
		LoveEvent_Topic_5092,
		// Token: 0x04008D87 RID: 36231
		[Token(Token = "0x401A2D9")]
		LoveEvent_Topic_5093,
		// Token: 0x04008D88 RID: 36232
		[Token(Token = "0x401A2DA")]
		LoveEvent_Topic_5094,
		// Token: 0x04008D89 RID: 36233
		[Token(Token = "0x401A2DB")]
		LoveEvent_Topic_5095,
		// Token: 0x04008D8A RID: 36234
		[Token(Token = "0x401A2DC")]
		LoveEvent_Topic_5096,
		// Token: 0x04008D8B RID: 36235
		[Token(Token = "0x401A2DD")]
		LoveEvent_Topic_5097,
		// Token: 0x04008D8C RID: 36236
		[Token(Token = "0x401A2DE")]
		LoveEvent_Topic_5098,
		// Token: 0x04008D8D RID: 36237
		[Token(Token = "0x401A2DF")]
		LoveEvent_Topic_5099,
		// Token: 0x04008D8E RID: 36238
		[Token(Token = "0x401A2E0")]
		LoveEvent_Topic_5100,
		// Token: 0x04008D8F RID: 36239
		[Token(Token = "0x401A2E1")]
		LoveEvent_Topic_5101,
		// Token: 0x04008D90 RID: 36240
		[Token(Token = "0x401A2E2")]
		LoveEvent_Topic_5102,
		// Token: 0x04008D91 RID: 36241
		[Token(Token = "0x401A2E3")]
		LoveEvent_Topic_5103,
		// Token: 0x04008D92 RID: 36242
		[Token(Token = "0x401A2E4")]
		LoveEvent_Topic_6020,
		// Token: 0x04008D93 RID: 36243
		[Token(Token = "0x401A2E5")]
		LoveEvent_Topic_6021,
		// Token: 0x04008D94 RID: 36244
		[Token(Token = "0x401A2E6")]
		LoveEvent_Topic_6040,
		// Token: 0x04008D95 RID: 36245
		[Token(Token = "0x401A2E7")]
		LoveEvent_Topic_6041,
		// Token: 0x04008D96 RID: 36246
		[Token(Token = "0x401A2E8")]
		LoveEvent_Topic_6042,
		// Token: 0x04008D97 RID: 36247
		[Token(Token = "0x401A2E9")]
		LoveEvent_Topic_6043,
		// Token: 0x04008D98 RID: 36248
		[Token(Token = "0x401A2EA")]
		LoveEvent_Topic_6044,
		// Token: 0x04008D99 RID: 36249
		[Token(Token = "0x401A2EB")]
		LoveEvent_Topic_6050,
		// Token: 0x04008D9A RID: 36250
		[Token(Token = "0x401A2EC")]
		LoveEvent_Topic_6060,
		// Token: 0x04008D9B RID: 36251
		[Token(Token = "0x401A2ED")]
		LoveEvent_Topic_6070,
		// Token: 0x04008D9C RID: 36252
		[Token(Token = "0x401A2EE")]
		LoveEvent_Topic_6080,
		// Token: 0x04008D9D RID: 36253
		[Token(Token = "0x401A2EF")]
		LoveEvent_Topic_6081,
		// Token: 0x04008D9E RID: 36254
		[Token(Token = "0x401A2F0")]
		LoveEvent_Topic_6090,
		// Token: 0x04008D9F RID: 36255
		[Token(Token = "0x401A2F1")]
		LoveEvent_Topic_6091,
		// Token: 0x04008DA0 RID: 36256
		[Token(Token = "0x401A2F2")]
		LoveEvent_Topic_6092,
		// Token: 0x04008DA1 RID: 36257
		[Token(Token = "0x401A2F3")]
		LoveEvent_Topic_6093,
		// Token: 0x04008DA2 RID: 36258
		[Token(Token = "0x401A2F4")]
		LoveEvent_Topic_6094,
		// Token: 0x04008DA3 RID: 36259
		[Token(Token = "0x401A2F5")]
		LoveEvent_Topic_6095,
		// Token: 0x04008DA4 RID: 36260
		[Token(Token = "0x401A2F6")]
		LoveEvent_Topic_6096,
		// Token: 0x04008DA5 RID: 36261
		[Token(Token = "0x401A2F7")]
		LoveEvent_Topic_6097,
		// Token: 0x04008DA6 RID: 36262
		[Token(Token = "0x401A2F8")]
		LoveEvent_Topic_6098,
		// Token: 0x04008DA7 RID: 36263
		[Token(Token = "0x401A2F9")]
		LoveEvent_Topic_6099,
		// Token: 0x04008DA8 RID: 36264
		[Token(Token = "0x401A2FA")]
		LoveEvent_Topic_6100,
		// Token: 0x04008DA9 RID: 36265
		[Token(Token = "0x401A2FB")]
		LoveEvent_Topic_6101,
		// Token: 0x04008DAA RID: 36266
		[Token(Token = "0x401A2FC")]
		LoveEvent_Topic_6102,
		// Token: 0x04008DAB RID: 36267
		[Token(Token = "0x401A2FD")]
		LoveEvent_Topic_6103,
		// Token: 0x04008DAC RID: 36268
		[Token(Token = "0x401A2FE")]
		LoveEvent_Topic_6104,
		// Token: 0x04008DAD RID: 36269
		[Token(Token = "0x401A2FF")]
		LoveEvent_Topic_6105,
		// Token: 0x04008DAE RID: 36270
		[Token(Token = "0x401A300")]
		LoveEvent_Topic_6106,
		// Token: 0x04008DAF RID: 36271
		[Token(Token = "0x401A301")]
		LoveEvent_Topic_6107,
		// Token: 0x04008DB0 RID: 36272
		[Token(Token = "0x401A302")]
		LoveEvent_Topic_7020,
		// Token: 0x04008DB1 RID: 36273
		[Token(Token = "0x401A303")]
		LoveEvent_Topic_7021,
		// Token: 0x04008DB2 RID: 36274
		[Token(Token = "0x401A304")]
		LoveEvent_Topic_7022,
		// Token: 0x04008DB3 RID: 36275
		[Token(Token = "0x401A305")]
		LoveEvent_Topic_7040,
		// Token: 0x04008DB4 RID: 36276
		[Token(Token = "0x401A306")]
		LoveEvent_Topic_7041,
		// Token: 0x04008DB5 RID: 36277
		[Token(Token = "0x401A307")]
		LoveEvent_Topic_7042,
		// Token: 0x04008DB6 RID: 36278
		[Token(Token = "0x401A308")]
		LoveEvent_Topic_7043,
		// Token: 0x04008DB7 RID: 36279
		[Token(Token = "0x401A309")]
		LoveEvent_Topic_7050,
		// Token: 0x04008DB8 RID: 36280
		[Token(Token = "0x401A30A")]
		LoveEvent_Topic_7060,
		// Token: 0x04008DB9 RID: 36281
		[Token(Token = "0x401A30B")]
		LoveEvent_Topic_7070,
		// Token: 0x04008DBA RID: 36282
		[Token(Token = "0x401A30C")]
		LoveEvent_Topic_7080,
		// Token: 0x04008DBB RID: 36283
		[Token(Token = "0x401A30D")]
		LoveEvent_Topic_7090,
		// Token: 0x04008DBC RID: 36284
		[Token(Token = "0x401A30E")]
		LoveEvent_Topic_7091,
		// Token: 0x04008DBD RID: 36285
		[Token(Token = "0x401A30F")]
		LoveEvent_Topic_7092,
		// Token: 0x04008DBE RID: 36286
		[Token(Token = "0x401A310")]
		LoveEvent_Topic_7093,
		// Token: 0x04008DBF RID: 36287
		[Token(Token = "0x401A311")]
		LoveEvent_Topic_7094,
		// Token: 0x04008DC0 RID: 36288
		[Token(Token = "0x401A312")]
		LoveEvent_Topic_7095,
		// Token: 0x04008DC1 RID: 36289
		[Token(Token = "0x401A313")]
		LoveEvent_Topic_7096,
		// Token: 0x04008DC2 RID: 36290
		[Token(Token = "0x401A314")]
		LoveEvent_Topic_7097,
		// Token: 0x04008DC3 RID: 36291
		[Token(Token = "0x401A315")]
		LoveEvent_Topic_7098,
		// Token: 0x04008DC4 RID: 36292
		[Token(Token = "0x401A316")]
		LoveEvent_Topic_8020,
		// Token: 0x04008DC5 RID: 36293
		[Token(Token = "0x401A317")]
		LoveEvent_Topic_8021,
		// Token: 0x04008DC6 RID: 36294
		[Token(Token = "0x401A318")]
		LoveEvent_Topic_8022,
		// Token: 0x04008DC7 RID: 36295
		[Token(Token = "0x401A319")]
		LoveEvent_Topic_8023,
		// Token: 0x04008DC8 RID: 36296
		[Token(Token = "0x401A31A")]
		LoveEvent_Topic_8024,
		// Token: 0x04008DC9 RID: 36297
		[Token(Token = "0x401A31B")]
		LoveEvent_Topic_8040,
		// Token: 0x04008DCA RID: 36298
		[Token(Token = "0x401A31C")]
		LoveEvent_Topic_8041,
		// Token: 0x04008DCB RID: 36299
		[Token(Token = "0x401A31D")]
		LoveEvent_Topic_8042,
		// Token: 0x04008DCC RID: 36300
		[Token(Token = "0x401A31E")]
		LoveEvent_Topic_8043,
		// Token: 0x04008DCD RID: 36301
		[Token(Token = "0x401A31F")]
		LoveEvent_Topic_8050,
		// Token: 0x04008DCE RID: 36302
		[Token(Token = "0x401A320")]
		LoveEvent_Topic_8060,
		// Token: 0x04008DCF RID: 36303
		[Token(Token = "0x401A321")]
		LoveEvent_Topic_8070,
		// Token: 0x04008DD0 RID: 36304
		[Token(Token = "0x401A322")]
		LoveEvent_Topic_8080,
		// Token: 0x04008DD1 RID: 36305
		[Token(Token = "0x401A323")]
		LoveEvent_Topic_8090,
		// Token: 0x04008DD2 RID: 36306
		[Token(Token = "0x401A324")]
		LoveEvent_Topic_8091,
		// Token: 0x04008DD3 RID: 36307
		[Token(Token = "0x401A325")]
		LoveEvent_Topic_8092,
		// Token: 0x04008DD4 RID: 36308
		[Token(Token = "0x401A326")]
		LoveEvent_Topic_8093,
		// Token: 0x04008DD5 RID: 36309
		[Token(Token = "0x401A327")]
		LoveEvent_Topic_8094,
		// Token: 0x04008DD6 RID: 36310
		[Token(Token = "0x401A328")]
		LoveEvent_Topic_8095,
		// Token: 0x04008DD7 RID: 36311
		[Token(Token = "0x401A329")]
		LoveEvent_Topic_8096,
		// Token: 0x04008DD8 RID: 36312
		[Token(Token = "0x401A32A")]
		LoveEvent_Topic_8097,
		// Token: 0x04008DD9 RID: 36313
		[Token(Token = "0x401A32B")]
		LoveEvent_Topic_8098,
		// Token: 0x04008DDA RID: 36314
		[Token(Token = "0x401A32C")]
		LoveEvent_Topic_9020,
		// Token: 0x04008DDB RID: 36315
		[Token(Token = "0x401A32D")]
		LoveEvent_Topic_9021,
		// Token: 0x04008DDC RID: 36316
		[Token(Token = "0x401A32E")]
		LoveEvent_Topic_9022,
		// Token: 0x04008DDD RID: 36317
		[Token(Token = "0x401A32F")]
		LoveEvent_Topic_9040,
		// Token: 0x04008DDE RID: 36318
		[Token(Token = "0x401A330")]
		LoveEvent_Topic_9041,
		// Token: 0x04008DDF RID: 36319
		[Token(Token = "0x401A331")]
		LoveEvent_Topic_9042,
		// Token: 0x04008DE0 RID: 36320
		[Token(Token = "0x401A332")]
		LoveEvent_Topic_9043,
		// Token: 0x04008DE1 RID: 36321
		[Token(Token = "0x401A333")]
		LoveEvent_Topic_9044,
		// Token: 0x04008DE2 RID: 36322
		[Token(Token = "0x401A334")]
		LoveEvent_Topic_9045,
		// Token: 0x04008DE3 RID: 36323
		[Token(Token = "0x401A335")]
		LoveEvent_Topic_9046,
		// Token: 0x04008DE4 RID: 36324
		[Token(Token = "0x401A336")]
		LoveEvent_Topic_9050,
		// Token: 0x04008DE5 RID: 36325
		[Token(Token = "0x401A337")]
		LoveEvent_Topic_9060,
		// Token: 0x04008DE6 RID: 36326
		[Token(Token = "0x401A338")]
		LoveEvent_Topic_9070,
		// Token: 0x04008DE7 RID: 36327
		[Token(Token = "0x401A339")]
		LoveEvent_Topic_9080,
		// Token: 0x04008DE8 RID: 36328
		[Token(Token = "0x401A33A")]
		LoveEvent_Topic_9090,
		// Token: 0x04008DE9 RID: 36329
		[Token(Token = "0x401A33B")]
		LoveEvent_Topic_9091,
		// Token: 0x04008DEA RID: 36330
		[Token(Token = "0x401A33C")]
		LoveEvent_Topic_9092,
		// Token: 0x04008DEB RID: 36331
		[Token(Token = "0x401A33D")]
		LoveEvent_Topic_9093,
		// Token: 0x04008DEC RID: 36332
		[Token(Token = "0x401A33E")]
		LoveEvent_Topic_9094,
		// Token: 0x04008DED RID: 36333
		[Token(Token = "0x401A33F")]
		LoveEvent_Topic_9095,
		// Token: 0x04008DEE RID: 36334
		[Token(Token = "0x401A340")]
		LoveEvent_Topic_10020,
		// Token: 0x04008DEF RID: 36335
		[Token(Token = "0x401A341")]
		LoveEvent_Topic_10021,
		// Token: 0x04008DF0 RID: 36336
		[Token(Token = "0x401A342")]
		LoveEvent_Topic_10022,
		// Token: 0x04008DF1 RID: 36337
		[Token(Token = "0x401A343")]
		LoveEvent_Topic_10040,
		// Token: 0x04008DF2 RID: 36338
		[Token(Token = "0x401A344")]
		LoveEvent_Topic_10041,
		// Token: 0x04008DF3 RID: 36339
		[Token(Token = "0x401A345")]
		LoveEvent_Topic_10042,
		// Token: 0x04008DF4 RID: 36340
		[Token(Token = "0x401A346")]
		LoveEvent_Topic_10050,
		// Token: 0x04008DF5 RID: 36341
		[Token(Token = "0x401A347")]
		LoveEvent_Topic_10060,
		// Token: 0x04008DF6 RID: 36342
		[Token(Token = "0x401A348")]
		LoveEvent_Topic_10070,
		// Token: 0x04008DF7 RID: 36343
		[Token(Token = "0x401A349")]
		LoveEvent_Topic_10080,
		// Token: 0x04008DF8 RID: 36344
		[Token(Token = "0x401A34A")]
		LoveEvent_Topic_10090,
		// Token: 0x04008DF9 RID: 36345
		[Token(Token = "0x401A34B")]
		LoveEvent_Topic_10091,
		// Token: 0x04008DFA RID: 36346
		[Token(Token = "0x401A34C")]
		LoveEvent_Topic_10092,
		// Token: 0x04008DFB RID: 36347
		[Token(Token = "0x401A34D")]
		LoveEvent_Topic_10093,
		// Token: 0x04008DFC RID: 36348
		[Token(Token = "0x401A34E")]
		LoveEvent_Topic_10094,
		// Token: 0x04008DFD RID: 36349
		[Token(Token = "0x401A34F")]
		LoveEvent_Topic_10095,
		// Token: 0x04008DFE RID: 36350
		[Token(Token = "0x401A350")]
		LoveEvent_Topic_10096,
		// Token: 0x04008DFF RID: 36351
		[Token(Token = "0x401A351")]
		LoveEvent_Topic_11020,
		// Token: 0x04008E00 RID: 36352
		[Token(Token = "0x401A352")]
		LoveEvent_Topic_11021,
		// Token: 0x04008E01 RID: 36353
		[Token(Token = "0x401A353")]
		LoveEvent_Topic_11022,
		// Token: 0x04008E02 RID: 36354
		[Token(Token = "0x401A354")]
		LoveEvent_Topic_11040,
		// Token: 0x04008E03 RID: 36355
		[Token(Token = "0x401A355")]
		LoveEvent_Topic_11041,
		// Token: 0x04008E04 RID: 36356
		[Token(Token = "0x401A356")]
		LoveEvent_Topic_11042,
		// Token: 0x04008E05 RID: 36357
		[Token(Token = "0x401A357")]
		LoveEvent_Topic_11043,
		// Token: 0x04008E06 RID: 36358
		[Token(Token = "0x401A358")]
		LoveEvent_Topic_11050,
		// Token: 0x04008E07 RID: 36359
		[Token(Token = "0x401A359")]
		LoveEvent_Topic_11060,
		// Token: 0x04008E08 RID: 36360
		[Token(Token = "0x401A35A")]
		LoveEvent_Topic_11070,
		// Token: 0x04008E09 RID: 36361
		[Token(Token = "0x401A35B")]
		LoveEvent_Topic_11080,
		// Token: 0x04008E0A RID: 36362
		[Token(Token = "0x401A35C")]
		LoveEvent_Topic_11090,
		// Token: 0x04008E0B RID: 36363
		[Token(Token = "0x401A35D")]
		LoveEvent_Topic_11091,
		// Token: 0x04008E0C RID: 36364
		[Token(Token = "0x401A35E")]
		LoveEvent_Topic_11092,
		// Token: 0x04008E0D RID: 36365
		[Token(Token = "0x401A35F")]
		LoveEvent_Topic_11093,
		// Token: 0x04008E0E RID: 36366
		[Token(Token = "0x401A360")]
		LoveEvent_Topic_11094,
		// Token: 0x04008E0F RID: 36367
		[Token(Token = "0x401A361")]
		LoveEvent_Topic_11095,
		// Token: 0x04008E10 RID: 36368
		[Token(Token = "0x401A362")]
		LoveEvent_Topic_11096,
		// Token: 0x04008E11 RID: 36369
		[Token(Token = "0x401A363")]
		LoveEvent_Topic_11097,
		// Token: 0x04008E12 RID: 36370
		[Token(Token = "0x401A364")]
		LoveEvent_Topic_11098,
		// Token: 0x04008E13 RID: 36371
		[Token(Token = "0x401A365")]
		LoveEvent_Topic_11099,
		// Token: 0x04008E14 RID: 36372
		[Token(Token = "0x401A366")]
		LoveEvent_Topic_11100,
		// Token: 0x04008E15 RID: 36373
		[Token(Token = "0x401A367")]
		LoveEvent_Topic_11101,
		// Token: 0x04008E16 RID: 36374
		[Token(Token = "0x401A368")]
		LoveEvent_Topic_11102,
		// Token: 0x04008E17 RID: 36375
		[Token(Token = "0x401A369")]
		LoveEvent_Topic_11103,
		// Token: 0x04008E18 RID: 36376
		[Token(Token = "0x401A36A")]
		LoveEvent_Topic_12020,
		// Token: 0x04008E19 RID: 36377
		[Token(Token = "0x401A36B")]
		LoveEvent_Topic_12021,
		// Token: 0x04008E1A RID: 36378
		[Token(Token = "0x401A36C")]
		LoveEvent_Topic_12022,
		// Token: 0x04008E1B RID: 36379
		[Token(Token = "0x401A36D")]
		LoveEvent_Topic_12040,
		// Token: 0x04008E1C RID: 36380
		[Token(Token = "0x401A36E")]
		LoveEvent_Topic_12041,
		// Token: 0x04008E1D RID: 36381
		[Token(Token = "0x401A36F")]
		LoveEvent_Topic_12042,
		// Token: 0x04008E1E RID: 36382
		[Token(Token = "0x401A370")]
		LoveEvent_Topic_12043,
		// Token: 0x04008E1F RID: 36383
		[Token(Token = "0x401A371")]
		LoveEvent_Topic_12050,
		// Token: 0x04008E20 RID: 36384
		[Token(Token = "0x401A372")]
		LoveEvent_Topic_12060,
		// Token: 0x04008E21 RID: 36385
		[Token(Token = "0x401A373")]
		LoveEvent_Topic_12070,
		// Token: 0x04008E22 RID: 36386
		[Token(Token = "0x401A374")]
		LoveEvent_Topic_12080,
		// Token: 0x04008E23 RID: 36387
		[Token(Token = "0x401A375")]
		LoveEvent_Topic_12090,
		// Token: 0x04008E24 RID: 36388
		[Token(Token = "0x401A376")]
		LoveEvent_Topic_12091,
		// Token: 0x04008E25 RID: 36389
		[Token(Token = "0x401A377")]
		LoveEvent_Topic_12092,
		// Token: 0x04008E26 RID: 36390
		[Token(Token = "0x401A378")]
		LoveEvent_Topic_12093,
		// Token: 0x04008E27 RID: 36391
		[Token(Token = "0x401A379")]
		LoveEvent_Topic_12094,
		// Token: 0x04008E28 RID: 36392
		[Token(Token = "0x401A37A")]
		LoveEvent_Topic_12095,
		// Token: 0x04008E29 RID: 36393
		[Token(Token = "0x401A37B")]
		LoveEvent_Topic_12096,
		// Token: 0x04008E2A RID: 36394
		[Token(Token = "0x401A37C")]
		LoveEvent_Topic_12097,
		// Token: 0x04008E2B RID: 36395
		[Token(Token = "0x401A37D")]
		LoveEvent_Topic_12098,
		// Token: 0x04008E2C RID: 36396
		[Token(Token = "0x401A37E")]
		LoveEvent_Topic_12099,
		// Token: 0x04008E2D RID: 36397
		[Token(Token = "0x401A37F")]
		LoveEvent_Topic_12100,
		// Token: 0x04008E2E RID: 36398
		[Token(Token = "0x401A380")]
		LoveEvent_Topic_12101,
		// Token: 0x04008E2F RID: 36399
		[Token(Token = "0x401A381")]
		LoveEvent_Topic_13020,
		// Token: 0x04008E30 RID: 36400
		[Token(Token = "0x401A382")]
		LoveEvent_Topic_13021,
		// Token: 0x04008E31 RID: 36401
		[Token(Token = "0x401A383")]
		LoveEvent_Topic_13022,
		// Token: 0x04008E32 RID: 36402
		[Token(Token = "0x401A384")]
		LoveEvent_Topic_13040,
		// Token: 0x04008E33 RID: 36403
		[Token(Token = "0x401A385")]
		LoveEvent_Topic_13041,
		// Token: 0x04008E34 RID: 36404
		[Token(Token = "0x401A386")]
		LoveEvent_Topic_13042,
		// Token: 0x04008E35 RID: 36405
		[Token(Token = "0x401A387")]
		LoveEvent_Topic_13043,
		// Token: 0x04008E36 RID: 36406
		[Token(Token = "0x401A388")]
		LoveEvent_Topic_13044,
		// Token: 0x04008E37 RID: 36407
		[Token(Token = "0x401A389")]
		LoveEvent_Topic_13050,
		// Token: 0x04008E38 RID: 36408
		[Token(Token = "0x401A38A")]
		LoveEvent_Topic_13060,
		// Token: 0x04008E39 RID: 36409
		[Token(Token = "0x401A38B")]
		LoveEvent_Topic_13070,
		// Token: 0x04008E3A RID: 36410
		[Token(Token = "0x401A38C")]
		LoveEvent_Topic_13080,
		// Token: 0x04008E3B RID: 36411
		[Token(Token = "0x401A38D")]
		LoveEvent_Topic_13090,
		// Token: 0x04008E3C RID: 36412
		[Token(Token = "0x401A38E")]
		LoveEvent_Topic_13091,
		// Token: 0x04008E3D RID: 36413
		[Token(Token = "0x401A38F")]
		LoveEvent_Topic_13092,
		// Token: 0x04008E3E RID: 36414
		[Token(Token = "0x401A390")]
		LoveEvent_Topic_13093,
		// Token: 0x04008E3F RID: 36415
		[Token(Token = "0x401A391")]
		LoveEvent_Topic_13094,
		// Token: 0x04008E40 RID: 36416
		[Token(Token = "0x401A392")]
		LoveEvent_Topic_13095,
		// Token: 0x04008E41 RID: 36417
		[Token(Token = "0x401A393")]
		LoveEvent_Topic_13096,
		// Token: 0x04008E42 RID: 36418
		[Token(Token = "0x401A394")]
		LoveEvent_Topic_13097,
		// Token: 0x04008E43 RID: 36419
		[Token(Token = "0x401A395")]
		LoveEvent_Topic_13098,
		// Token: 0x04008E44 RID: 36420
		[Token(Token = "0x401A396")]
		LoveEvent_Topic_13099,
		// Token: 0x04008E45 RID: 36421
		[Token(Token = "0x401A397")]
		LoveEvent_Topic_13100,
		// Token: 0x04008E46 RID: 36422
		[Token(Token = "0x401A398")]
		LoveEvent_Detail_2020,
		// Token: 0x04008E47 RID: 36423
		[Token(Token = "0x401A399")]
		LoveEvent_Detail_2021,
		// Token: 0x04008E48 RID: 36424
		[Token(Token = "0x401A39A")]
		LoveEvent_Detail_2040,
		// Token: 0x04008E49 RID: 36425
		[Token(Token = "0x401A39B")]
		LoveEvent_Detail_2041,
		// Token: 0x04008E4A RID: 36426
		[Token(Token = "0x401A39C")]
		LoveEvent_Detail_2050,
		// Token: 0x04008E4B RID: 36427
		[Token(Token = "0x401A39D")]
		LoveEvent_Detail_2060,
		// Token: 0x04008E4C RID: 36428
		[Token(Token = "0x401A39E")]
		LoveEvent_Detail_2070,
		// Token: 0x04008E4D RID: 36429
		[Token(Token = "0x401A39F")]
		LoveEvent_Detail_2080,
		// Token: 0x04008E4E RID: 36430
		[Token(Token = "0x401A3A0")]
		LoveEvent_Detail_2090,
		// Token: 0x04008E4F RID: 36431
		[Token(Token = "0x401A3A1")]
		LoveEvent_Detail_2091,
		// Token: 0x04008E50 RID: 36432
		[Token(Token = "0x401A3A2")]
		LoveEvent_Detail_2092,
		// Token: 0x04008E51 RID: 36433
		[Token(Token = "0x401A3A3")]
		LoveEvent_Detail_2093,
		// Token: 0x04008E52 RID: 36434
		[Token(Token = "0x401A3A4")]
		LoveEvent_Detail_2094,
		// Token: 0x04008E53 RID: 36435
		[Token(Token = "0x401A3A5")]
		LoveEvent_Detail_2095,
		// Token: 0x04008E54 RID: 36436
		[Token(Token = "0x401A3A6")]
		LoveEvent_Detail_2096,
		// Token: 0x04008E55 RID: 36437
		[Token(Token = "0x401A3A7")]
		LoveEvent_Detail_2097,
		// Token: 0x04008E56 RID: 36438
		[Token(Token = "0x401A3A8")]
		LoveEvent_Detail_3020,
		// Token: 0x04008E57 RID: 36439
		[Token(Token = "0x401A3A9")]
		LoveEvent_Detail_3021,
		// Token: 0x04008E58 RID: 36440
		[Token(Token = "0x401A3AA")]
		LoveEvent_Detail_3022,
		// Token: 0x04008E59 RID: 36441
		[Token(Token = "0x401A3AB")]
		LoveEvent_Detail_3023,
		// Token: 0x04008E5A RID: 36442
		[Token(Token = "0x401A3AC")]
		LoveEvent_Detail_3040,
		// Token: 0x04008E5B RID: 36443
		[Token(Token = "0x401A3AD")]
		LoveEvent_Detail_3041,
		// Token: 0x04008E5C RID: 36444
		[Token(Token = "0x401A3AE")]
		LoveEvent_Detail_3042,
		// Token: 0x04008E5D RID: 36445
		[Token(Token = "0x401A3AF")]
		LoveEvent_Detail_3043,
		// Token: 0x04008E5E RID: 36446
		[Token(Token = "0x401A3B0")]
		LoveEvent_Detail_3044,
		// Token: 0x04008E5F RID: 36447
		[Token(Token = "0x401A3B1")]
		LoveEvent_Detail_3050,
		// Token: 0x04008E60 RID: 36448
		[Token(Token = "0x401A3B2")]
		LoveEvent_Detail_3060,
		// Token: 0x04008E61 RID: 36449
		[Token(Token = "0x401A3B3")]
		LoveEvent_Detail_3070,
		// Token: 0x04008E62 RID: 36450
		[Token(Token = "0x401A3B4")]
		LoveEvent_Detail_3080,
		// Token: 0x04008E63 RID: 36451
		[Token(Token = "0x401A3B5")]
		LoveEvent_Detail_3090,
		// Token: 0x04008E64 RID: 36452
		[Token(Token = "0x401A3B6")]
		LoveEvent_Detail_3091,
		// Token: 0x04008E65 RID: 36453
		[Token(Token = "0x401A3B7")]
		LoveEvent_Detail_3092,
		// Token: 0x04008E66 RID: 36454
		[Token(Token = "0x401A3B8")]
		LoveEvent_Detail_3093,
		// Token: 0x04008E67 RID: 36455
		[Token(Token = "0x401A3B9")]
		LoveEvent_Detail_3094,
		// Token: 0x04008E68 RID: 36456
		[Token(Token = "0x401A3BA")]
		LoveEvent_Detail_3095,
		// Token: 0x04008E69 RID: 36457
		[Token(Token = "0x401A3BB")]
		LoveEvent_Detail_3096,
		// Token: 0x04008E6A RID: 36458
		[Token(Token = "0x401A3BC")]
		LoveEvent_Detail_3097,
		// Token: 0x04008E6B RID: 36459
		[Token(Token = "0x401A3BD")]
		LoveEvent_Detail_3098,
		// Token: 0x04008E6C RID: 36460
		[Token(Token = "0x401A3BE")]
		LoveEvent_Detail_3099,
		// Token: 0x04008E6D RID: 36461
		[Token(Token = "0x401A3BF")]
		LoveEvent_Detail_4020,
		// Token: 0x04008E6E RID: 36462
		[Token(Token = "0x401A3C0")]
		LoveEvent_Detail_4021,
		// Token: 0x04008E6F RID: 36463
		[Token(Token = "0x401A3C1")]
		LoveEvent_Detail_4040,
		// Token: 0x04008E70 RID: 36464
		[Token(Token = "0x401A3C2")]
		LoveEvent_Detail_4041,
		// Token: 0x04008E71 RID: 36465
		[Token(Token = "0x401A3C3")]
		LoveEvent_Detail_4042,
		// Token: 0x04008E72 RID: 36466
		[Token(Token = "0x401A3C4")]
		LoveEvent_Detail_4050,
		// Token: 0x04008E73 RID: 36467
		[Token(Token = "0x401A3C5")]
		LoveEvent_Detail_4060,
		// Token: 0x04008E74 RID: 36468
		[Token(Token = "0x401A3C6")]
		LoveEvent_Detail_4070,
		// Token: 0x04008E75 RID: 36469
		[Token(Token = "0x401A3C7")]
		LoveEvent_Detail_4080,
		// Token: 0x04008E76 RID: 36470
		[Token(Token = "0x401A3C8")]
		LoveEvent_Detail_4090,
		// Token: 0x04008E77 RID: 36471
		[Token(Token = "0x401A3C9")]
		LoveEvent_Detail_4091,
		// Token: 0x04008E78 RID: 36472
		[Token(Token = "0x401A3CA")]
		LoveEvent_Detail_4092,
		// Token: 0x04008E79 RID: 36473
		[Token(Token = "0x401A3CB")]
		LoveEvent_Detail_4093,
		// Token: 0x04008E7A RID: 36474
		[Token(Token = "0x401A3CC")]
		LoveEvent_Detail_4094,
		// Token: 0x04008E7B RID: 36475
		[Token(Token = "0x401A3CD")]
		LoveEvent_Detail_4095,
		// Token: 0x04008E7C RID: 36476
		[Token(Token = "0x401A3CE")]
		LoveEvent_Detail_4096,
		// Token: 0x04008E7D RID: 36477
		[Token(Token = "0x401A3CF")]
		LoveEvent_Detail_4097,
		// Token: 0x04008E7E RID: 36478
		[Token(Token = "0x401A3D0")]
		LoveEvent_Detail_4098,
		// Token: 0x04008E7F RID: 36479
		[Token(Token = "0x401A3D1")]
		LoveEvent_Detail_4099,
		// Token: 0x04008E80 RID: 36480
		[Token(Token = "0x401A3D2")]
		LoveEvent_Detail_4100,
		// Token: 0x04008E81 RID: 36481
		[Token(Token = "0x401A3D3")]
		LoveEvent_Detail_4101,
		// Token: 0x04008E82 RID: 36482
		[Token(Token = "0x401A3D4")]
		LoveEvent_Detail_4102,
		// Token: 0x04008E83 RID: 36483
		[Token(Token = "0x401A3D5")]
		LoveEvent_Detail_4103,
		// Token: 0x04008E84 RID: 36484
		[Token(Token = "0x401A3D6")]
		LoveEvent_Detail_4104,
		// Token: 0x04008E85 RID: 36485
		[Token(Token = "0x401A3D7")]
		LoveEvent_Detail_5020,
		// Token: 0x04008E86 RID: 36486
		[Token(Token = "0x401A3D8")]
		LoveEvent_Detail_5021,
		// Token: 0x04008E87 RID: 36487
		[Token(Token = "0x401A3D9")]
		LoveEvent_Detail_5022,
		// Token: 0x04008E88 RID: 36488
		[Token(Token = "0x401A3DA")]
		LoveEvent_Detail_5023,
		// Token: 0x04008E89 RID: 36489
		[Token(Token = "0x401A3DB")]
		LoveEvent_Detail_5024,
		// Token: 0x04008E8A RID: 36490
		[Token(Token = "0x401A3DC")]
		LoveEvent_Detail_5040,
		// Token: 0x04008E8B RID: 36491
		[Token(Token = "0x401A3DD")]
		LoveEvent_Detail_5041,
		// Token: 0x04008E8C RID: 36492
		[Token(Token = "0x401A3DE")]
		LoveEvent_Detail_5042,
		// Token: 0x04008E8D RID: 36493
		[Token(Token = "0x401A3DF")]
		LoveEvent_Detail_5050,
		// Token: 0x04008E8E RID: 36494
		[Token(Token = "0x401A3E0")]
		LoveEvent_Detail_5060,
		// Token: 0x04008E8F RID: 36495
		[Token(Token = "0x401A3E1")]
		LoveEvent_Detail_5070,
		// Token: 0x04008E90 RID: 36496
		[Token(Token = "0x401A3E2")]
		LoveEvent_Detail_5080,
		// Token: 0x04008E91 RID: 36497
		[Token(Token = "0x401A3E3")]
		LoveEvent_Detail_5090,
		// Token: 0x04008E92 RID: 36498
		[Token(Token = "0x401A3E4")]
		LoveEvent_Detail_5091,
		// Token: 0x04008E93 RID: 36499
		[Token(Token = "0x401A3E5")]
		LoveEvent_Detail_5092,
		// Token: 0x04008E94 RID: 36500
		[Token(Token = "0x401A3E6")]
		LoveEvent_Detail_5093,
		// Token: 0x04008E95 RID: 36501
		[Token(Token = "0x401A3E7")]
		LoveEvent_Detail_5094,
		// Token: 0x04008E96 RID: 36502
		[Token(Token = "0x401A3E8")]
		LoveEvent_Detail_5095,
		// Token: 0x04008E97 RID: 36503
		[Token(Token = "0x401A3E9")]
		LoveEvent_Detail_5096,
		// Token: 0x04008E98 RID: 36504
		[Token(Token = "0x401A3EA")]
		LoveEvent_Detail_5097,
		// Token: 0x04008E99 RID: 36505
		[Token(Token = "0x401A3EB")]
		LoveEvent_Detail_5098,
		// Token: 0x04008E9A RID: 36506
		[Token(Token = "0x401A3EC")]
		LoveEvent_Detail_5099,
		// Token: 0x04008E9B RID: 36507
		[Token(Token = "0x401A3ED")]
		LoveEvent_Detail_5100,
		// Token: 0x04008E9C RID: 36508
		[Token(Token = "0x401A3EE")]
		LoveEvent_Detail_5101,
		// Token: 0x04008E9D RID: 36509
		[Token(Token = "0x401A3EF")]
		LoveEvent_Detail_5102,
		// Token: 0x04008E9E RID: 36510
		[Token(Token = "0x401A3F0")]
		LoveEvent_Detail_5103,
		// Token: 0x04008E9F RID: 36511
		[Token(Token = "0x401A3F1")]
		LoveEvent_Detail_6020,
		// Token: 0x04008EA0 RID: 36512
		[Token(Token = "0x401A3F2")]
		LoveEvent_Detail_6021,
		// Token: 0x04008EA1 RID: 36513
		[Token(Token = "0x401A3F3")]
		LoveEvent_Detail_6040,
		// Token: 0x04008EA2 RID: 36514
		[Token(Token = "0x401A3F4")]
		LoveEvent_Detail_6041,
		// Token: 0x04008EA3 RID: 36515
		[Token(Token = "0x401A3F5")]
		LoveEvent_Detail_6042,
		// Token: 0x04008EA4 RID: 36516
		[Token(Token = "0x401A3F6")]
		LoveEvent_Detail_6043,
		// Token: 0x04008EA5 RID: 36517
		[Token(Token = "0x401A3F7")]
		LoveEvent_Detail_6044,
		// Token: 0x04008EA6 RID: 36518
		[Token(Token = "0x401A3F8")]
		LoveEvent_Detail_6050,
		// Token: 0x04008EA7 RID: 36519
		[Token(Token = "0x401A3F9")]
		LoveEvent_Detail_6060,
		// Token: 0x04008EA8 RID: 36520
		[Token(Token = "0x401A3FA")]
		LoveEvent_Detail_6070,
		// Token: 0x04008EA9 RID: 36521
		[Token(Token = "0x401A3FB")]
		LoveEvent_Detail_6080,
		// Token: 0x04008EAA RID: 36522
		[Token(Token = "0x401A3FC")]
		LoveEvent_Detail_6090,
		// Token: 0x04008EAB RID: 36523
		[Token(Token = "0x401A3FD")]
		LoveEvent_Detail_6091,
		// Token: 0x04008EAC RID: 36524
		[Token(Token = "0x401A3FE")]
		LoveEvent_Detail_6092,
		// Token: 0x04008EAD RID: 36525
		[Token(Token = "0x401A3FF")]
		LoveEvent_Detail_6093,
		// Token: 0x04008EAE RID: 36526
		[Token(Token = "0x401A400")]
		LoveEvent_Detail_6094,
		// Token: 0x04008EAF RID: 36527
		[Token(Token = "0x401A401")]
		LoveEvent_Detail_6095,
		// Token: 0x04008EB0 RID: 36528
		[Token(Token = "0x401A402")]
		LoveEvent_Detail_6096,
		// Token: 0x04008EB1 RID: 36529
		[Token(Token = "0x401A403")]
		LoveEvent_Detail_6097,
		// Token: 0x04008EB2 RID: 36530
		[Token(Token = "0x401A404")]
		LoveEvent_Detail_6098,
		// Token: 0x04008EB3 RID: 36531
		[Token(Token = "0x401A405")]
		LoveEvent_Detail_6099,
		// Token: 0x04008EB4 RID: 36532
		[Token(Token = "0x401A406")]
		LoveEvent_Detail_6100,
		// Token: 0x04008EB5 RID: 36533
		[Token(Token = "0x401A407")]
		LoveEvent_Detail_6101,
		// Token: 0x04008EB6 RID: 36534
		[Token(Token = "0x401A408")]
		LoveEvent_Detail_6102,
		// Token: 0x04008EB7 RID: 36535
		[Token(Token = "0x401A409")]
		LoveEvent_Detail_6103,
		// Token: 0x04008EB8 RID: 36536
		[Token(Token = "0x401A40A")]
		LoveEvent_Detail_6104,
		// Token: 0x04008EB9 RID: 36537
		[Token(Token = "0x401A40B")]
		LoveEvent_Detail_6105,
		// Token: 0x04008EBA RID: 36538
		[Token(Token = "0x401A40C")]
		LoveEvent_Detail_6106,
		// Token: 0x04008EBB RID: 36539
		[Token(Token = "0x401A40D")]
		LoveEvent_Detail_6107,
		// Token: 0x04008EBC RID: 36540
		[Token(Token = "0x401A40E")]
		LoveEvent_Detail_7020,
		// Token: 0x04008EBD RID: 36541
		[Token(Token = "0x401A40F")]
		LoveEvent_Detail_7021,
		// Token: 0x04008EBE RID: 36542
		[Token(Token = "0x401A410")]
		LoveEvent_Detail_7022,
		// Token: 0x04008EBF RID: 36543
		[Token(Token = "0x401A411")]
		LoveEvent_Detail_7040,
		// Token: 0x04008EC0 RID: 36544
		[Token(Token = "0x401A412")]
		LoveEvent_Detail_7041,
		// Token: 0x04008EC1 RID: 36545
		[Token(Token = "0x401A413")]
		LoveEvent_Detail_7042,
		// Token: 0x04008EC2 RID: 36546
		[Token(Token = "0x401A414")]
		LoveEvent_Detail_7043,
		// Token: 0x04008EC3 RID: 36547
		[Token(Token = "0x401A415")]
		LoveEvent_Detail_7050,
		// Token: 0x04008EC4 RID: 36548
		[Token(Token = "0x401A416")]
		LoveEvent_Detail_7060,
		// Token: 0x04008EC5 RID: 36549
		[Token(Token = "0x401A417")]
		LoveEvent_Detail_7070,
		// Token: 0x04008EC6 RID: 36550
		[Token(Token = "0x401A418")]
		LoveEvent_Detail_7080,
		// Token: 0x04008EC7 RID: 36551
		[Token(Token = "0x401A419")]
		LoveEvent_Detail_7090,
		// Token: 0x04008EC8 RID: 36552
		[Token(Token = "0x401A41A")]
		LoveEvent_Detail_7091,
		// Token: 0x04008EC9 RID: 36553
		[Token(Token = "0x401A41B")]
		LoveEvent_Detail_7092,
		// Token: 0x04008ECA RID: 36554
		[Token(Token = "0x401A41C")]
		LoveEvent_Detail_7093,
		// Token: 0x04008ECB RID: 36555
		[Token(Token = "0x401A41D")]
		LoveEvent_Detail_7094,
		// Token: 0x04008ECC RID: 36556
		[Token(Token = "0x401A41E")]
		LoveEvent_Detail_7095,
		// Token: 0x04008ECD RID: 36557
		[Token(Token = "0x401A41F")]
		LoveEvent_Detail_7096,
		// Token: 0x04008ECE RID: 36558
		[Token(Token = "0x401A420")]
		LoveEvent_Detail_7097,
		// Token: 0x04008ECF RID: 36559
		[Token(Token = "0x401A421")]
		LoveEvent_Detail_7098,
		// Token: 0x04008ED0 RID: 36560
		[Token(Token = "0x401A422")]
		LoveEvent_Detail_7110,
		// Token: 0x04008ED1 RID: 36561
		[Token(Token = "0x401A423")]
		LoveEvent_Detail_7111,
		// Token: 0x04008ED2 RID: 36562
		[Token(Token = "0x401A424")]
		LoveEvent_Detail_7112,
		// Token: 0x04008ED3 RID: 36563
		[Token(Token = "0x401A425")]
		LoveEvent_Detail_7113,
		// Token: 0x04008ED4 RID: 36564
		[Token(Token = "0x401A426")]
		LoveEvent_Detail_7114,
		// Token: 0x04008ED5 RID: 36565
		[Token(Token = "0x401A427")]
		LoveEvent_Detail_7115,
		// Token: 0x04008ED6 RID: 36566
		[Token(Token = "0x401A428")]
		LoveEvent_Detail_7116,
		// Token: 0x04008ED7 RID: 36567
		[Token(Token = "0x401A429")]
		LoveEvent_Detail_7117,
		// Token: 0x04008ED8 RID: 36568
		[Token(Token = "0x401A42A")]
		LoveEvent_Detail_7118,
		// Token: 0x04008ED9 RID: 36569
		[Token(Token = "0x401A42B")]
		LoveEvent_Detail_7119,
		// Token: 0x04008EDA RID: 36570
		[Token(Token = "0x401A42C")]
		LoveEvent_Detail_8020,
		// Token: 0x04008EDB RID: 36571
		[Token(Token = "0x401A42D")]
		LoveEvent_Detail_8021,
		// Token: 0x04008EDC RID: 36572
		[Token(Token = "0x401A42E")]
		LoveEvent_Detail_8022,
		// Token: 0x04008EDD RID: 36573
		[Token(Token = "0x401A42F")]
		LoveEvent_Detail_8023,
		// Token: 0x04008EDE RID: 36574
		[Token(Token = "0x401A430")]
		LoveEvent_Detail_8024,
		// Token: 0x04008EDF RID: 36575
		[Token(Token = "0x401A431")]
		LoveEvent_Detail_8040,
		// Token: 0x04008EE0 RID: 36576
		[Token(Token = "0x401A432")]
		LoveEvent_Detail_8041,
		// Token: 0x04008EE1 RID: 36577
		[Token(Token = "0x401A433")]
		LoveEvent_Detail_8042,
		// Token: 0x04008EE2 RID: 36578
		[Token(Token = "0x401A434")]
		LoveEvent_Detail_8043,
		// Token: 0x04008EE3 RID: 36579
		[Token(Token = "0x401A435")]
		LoveEvent_Detail_8050,
		// Token: 0x04008EE4 RID: 36580
		[Token(Token = "0x401A436")]
		LoveEvent_Detail_8060,
		// Token: 0x04008EE5 RID: 36581
		[Token(Token = "0x401A437")]
		LoveEvent_Detail_8070,
		// Token: 0x04008EE6 RID: 36582
		[Token(Token = "0x401A438")]
		LoveEvent_Detail_8080,
		// Token: 0x04008EE7 RID: 36583
		[Token(Token = "0x401A439")]
		LoveEvent_Detail_8090,
		// Token: 0x04008EE8 RID: 36584
		[Token(Token = "0x401A43A")]
		LoveEvent_Detail_8091,
		// Token: 0x04008EE9 RID: 36585
		[Token(Token = "0x401A43B")]
		LoveEvent_Detail_8092,
		// Token: 0x04008EEA RID: 36586
		[Token(Token = "0x401A43C")]
		LoveEvent_Detail_8093,
		// Token: 0x04008EEB RID: 36587
		[Token(Token = "0x401A43D")]
		LoveEvent_Detail_8094,
		// Token: 0x04008EEC RID: 36588
		[Token(Token = "0x401A43E")]
		LoveEvent_Detail_8095,
		// Token: 0x04008EED RID: 36589
		[Token(Token = "0x401A43F")]
		LoveEvent_Detail_8096,
		// Token: 0x04008EEE RID: 36590
		[Token(Token = "0x401A440")]
		LoveEvent_Detail_8097,
		// Token: 0x04008EEF RID: 36591
		[Token(Token = "0x401A441")]
		LoveEvent_Detail_8098,
		// Token: 0x04008EF0 RID: 36592
		[Token(Token = "0x401A442")]
		LoveEvent_Detail_8110,
		// Token: 0x04008EF1 RID: 36593
		[Token(Token = "0x401A443")]
		LoveEvent_Detail_8111,
		// Token: 0x04008EF2 RID: 36594
		[Token(Token = "0x401A444")]
		LoveEvent_Detail_8112,
		// Token: 0x04008EF3 RID: 36595
		[Token(Token = "0x401A445")]
		LoveEvent_Detail_8113,
		// Token: 0x04008EF4 RID: 36596
		[Token(Token = "0x401A446")]
		LoveEvent_Detail_8114,
		// Token: 0x04008EF5 RID: 36597
		[Token(Token = "0x401A447")]
		LoveEvent_Detail_8115,
		// Token: 0x04008EF6 RID: 36598
		[Token(Token = "0x401A448")]
		LoveEvent_Detail_8116,
		// Token: 0x04008EF7 RID: 36599
		[Token(Token = "0x401A449")]
		LoveEvent_Detail_8117,
		// Token: 0x04008EF8 RID: 36600
		[Token(Token = "0x401A44A")]
		LoveEvent_Detail_8118,
		// Token: 0x04008EF9 RID: 36601
		[Token(Token = "0x401A44B")]
		LoveEvent_Detail_8119,
		// Token: 0x04008EFA RID: 36602
		[Token(Token = "0x401A44C")]
		LoveEvent_Detail_9020,
		// Token: 0x04008EFB RID: 36603
		[Token(Token = "0x401A44D")]
		LoveEvent_Detail_9021,
		// Token: 0x04008EFC RID: 36604
		[Token(Token = "0x401A44E")]
		LoveEvent_Detail_9022,
		// Token: 0x04008EFD RID: 36605
		[Token(Token = "0x401A44F")]
		LoveEvent_Detail_9040,
		// Token: 0x04008EFE RID: 36606
		[Token(Token = "0x401A450")]
		LoveEvent_Detail_9041,
		// Token: 0x04008EFF RID: 36607
		[Token(Token = "0x401A451")]
		LoveEvent_Detail_9042,
		// Token: 0x04008F00 RID: 36608
		[Token(Token = "0x401A452")]
		LoveEvent_Detail_9043,
		// Token: 0x04008F01 RID: 36609
		[Token(Token = "0x401A453")]
		LoveEvent_Detail_9044,
		// Token: 0x04008F02 RID: 36610
		[Token(Token = "0x401A454")]
		LoveEvent_Detail_9045,
		// Token: 0x04008F03 RID: 36611
		[Token(Token = "0x401A455")]
		LoveEvent_Detail_9046,
		// Token: 0x04008F04 RID: 36612
		[Token(Token = "0x401A456")]
		LoveEvent_Detail_9050,
		// Token: 0x04008F05 RID: 36613
		[Token(Token = "0x401A457")]
		LoveEvent_Detail_9060,
		// Token: 0x04008F06 RID: 36614
		[Token(Token = "0x401A458")]
		LoveEvent_Detail_9070,
		// Token: 0x04008F07 RID: 36615
		[Token(Token = "0x401A459")]
		LoveEvent_Detail_9080,
		// Token: 0x04008F08 RID: 36616
		[Token(Token = "0x401A45A")]
		LoveEvent_Detail_9090,
		// Token: 0x04008F09 RID: 36617
		[Token(Token = "0x401A45B")]
		LoveEvent_Detail_9091,
		// Token: 0x04008F0A RID: 36618
		[Token(Token = "0x401A45C")]
		LoveEvent_Detail_9092,
		// Token: 0x04008F0B RID: 36619
		[Token(Token = "0x401A45D")]
		LoveEvent_Detail_9093,
		// Token: 0x04008F0C RID: 36620
		[Token(Token = "0x401A45E")]
		LoveEvent_Detail_9094,
		// Token: 0x04008F0D RID: 36621
		[Token(Token = "0x401A45F")]
		LoveEvent_Detail_9095,
		// Token: 0x04008F0E RID: 36622
		[Token(Token = "0x401A460")]
		LoveEvent_Detail_9110,
		// Token: 0x04008F0F RID: 36623
		[Token(Token = "0x401A461")]
		LoveEvent_Detail_9111,
		// Token: 0x04008F10 RID: 36624
		[Token(Token = "0x401A462")]
		LoveEvent_Detail_9112,
		// Token: 0x04008F11 RID: 36625
		[Token(Token = "0x401A463")]
		LoveEvent_Detail_9113,
		// Token: 0x04008F12 RID: 36626
		[Token(Token = "0x401A464")]
		LoveEvent_Detail_9114,
		// Token: 0x04008F13 RID: 36627
		[Token(Token = "0x401A465")]
		LoveEvent_Detail_9115,
		// Token: 0x04008F14 RID: 36628
		[Token(Token = "0x401A466")]
		LoveEvent_Detail_9116,
		// Token: 0x04008F15 RID: 36629
		[Token(Token = "0x401A467")]
		LoveEvent_Detail_9117,
		// Token: 0x04008F16 RID: 36630
		[Token(Token = "0x401A468")]
		LoveEvent_Detail_9118,
		// Token: 0x04008F17 RID: 36631
		[Token(Token = "0x401A469")]
		LoveEvent_Detail_9119,
		// Token: 0x04008F18 RID: 36632
		[Token(Token = "0x401A46A")]
		LoveEvent_Detail_10020,
		// Token: 0x04008F19 RID: 36633
		[Token(Token = "0x401A46B")]
		LoveEvent_Detail_10021,
		// Token: 0x04008F1A RID: 36634
		[Token(Token = "0x401A46C")]
		LoveEvent_Detail_10022,
		// Token: 0x04008F1B RID: 36635
		[Token(Token = "0x401A46D")]
		LoveEvent_Detail_10040,
		// Token: 0x04008F1C RID: 36636
		[Token(Token = "0x401A46E")]
		LoveEvent_Detail_10041,
		// Token: 0x04008F1D RID: 36637
		[Token(Token = "0x401A46F")]
		LoveEvent_Detail_10042,
		// Token: 0x04008F1E RID: 36638
		[Token(Token = "0x401A470")]
		LoveEvent_Detail_10050,
		// Token: 0x04008F1F RID: 36639
		[Token(Token = "0x401A471")]
		LoveEvent_Detail_10060,
		// Token: 0x04008F20 RID: 36640
		[Token(Token = "0x401A472")]
		LoveEvent_Detail_10070,
		// Token: 0x04008F21 RID: 36641
		[Token(Token = "0x401A473")]
		LoveEvent_Detail_10080,
		// Token: 0x04008F22 RID: 36642
		[Token(Token = "0x401A474")]
		LoveEvent_Detail_10090,
		// Token: 0x04008F23 RID: 36643
		[Token(Token = "0x401A475")]
		LoveEvent_Detail_10091,
		// Token: 0x04008F24 RID: 36644
		[Token(Token = "0x401A476")]
		LoveEvent_Detail_10092,
		// Token: 0x04008F25 RID: 36645
		[Token(Token = "0x401A477")]
		LoveEvent_Detail_10093,
		// Token: 0x04008F26 RID: 36646
		[Token(Token = "0x401A478")]
		LoveEvent_Detail_10094,
		// Token: 0x04008F27 RID: 36647
		[Token(Token = "0x401A479")]
		LoveEvent_Detail_10095,
		// Token: 0x04008F28 RID: 36648
		[Token(Token = "0x401A47A")]
		LoveEvent_Detail_10096,
		// Token: 0x04008F29 RID: 36649
		[Token(Token = "0x401A47B")]
		LoveEvent_Detail_10110,
		// Token: 0x04008F2A RID: 36650
		[Token(Token = "0x401A47C")]
		LoveEvent_Detail_10111,
		// Token: 0x04008F2B RID: 36651
		[Token(Token = "0x401A47D")]
		LoveEvent_Detail_10112,
		// Token: 0x04008F2C RID: 36652
		[Token(Token = "0x401A47E")]
		LoveEvent_Detail_10113,
		// Token: 0x04008F2D RID: 36653
		[Token(Token = "0x401A47F")]
		LoveEvent_Detail_10114,
		// Token: 0x04008F2E RID: 36654
		[Token(Token = "0x401A480")]
		LoveEvent_Detail_10115,
		// Token: 0x04008F2F RID: 36655
		[Token(Token = "0x401A481")]
		LoveEvent_Detail_10116,
		// Token: 0x04008F30 RID: 36656
		[Token(Token = "0x401A482")]
		LoveEvent_Detail_10117,
		// Token: 0x04008F31 RID: 36657
		[Token(Token = "0x401A483")]
		LoveEvent_Detail_10118,
		// Token: 0x04008F32 RID: 36658
		[Token(Token = "0x401A484")]
		LoveEvent_Detail_10119,
		// Token: 0x04008F33 RID: 36659
		[Token(Token = "0x401A485")]
		LoveEvent_Detail_11020,
		// Token: 0x04008F34 RID: 36660
		[Token(Token = "0x401A486")]
		LoveEvent_Detail_11021,
		// Token: 0x04008F35 RID: 36661
		[Token(Token = "0x401A487")]
		LoveEvent_Detail_11022,
		// Token: 0x04008F36 RID: 36662
		[Token(Token = "0x401A488")]
		LoveEvent_Detail_11040,
		// Token: 0x04008F37 RID: 36663
		[Token(Token = "0x401A489")]
		LoveEvent_Detail_11041,
		// Token: 0x04008F38 RID: 36664
		[Token(Token = "0x401A48A")]
		LoveEvent_Detail_11042,
		// Token: 0x04008F39 RID: 36665
		[Token(Token = "0x401A48B")]
		LoveEvent_Detail_11043,
		// Token: 0x04008F3A RID: 36666
		[Token(Token = "0x401A48C")]
		LoveEvent_Detail_11050,
		// Token: 0x04008F3B RID: 36667
		[Token(Token = "0x401A48D")]
		LoveEvent_Detail_11060,
		// Token: 0x04008F3C RID: 36668
		[Token(Token = "0x401A48E")]
		LoveEvent_Detail_11070,
		// Token: 0x04008F3D RID: 36669
		[Token(Token = "0x401A48F")]
		LoveEvent_Detail_11080,
		// Token: 0x04008F3E RID: 36670
		[Token(Token = "0x401A490")]
		LoveEvent_Detail_11090,
		// Token: 0x04008F3F RID: 36671
		[Token(Token = "0x401A491")]
		LoveEvent_Detail_11091,
		// Token: 0x04008F40 RID: 36672
		[Token(Token = "0x401A492")]
		LoveEvent_Detail_11092,
		// Token: 0x04008F41 RID: 36673
		[Token(Token = "0x401A493")]
		LoveEvent_Detail_11093,
		// Token: 0x04008F42 RID: 36674
		[Token(Token = "0x401A494")]
		LoveEvent_Detail_11094,
		// Token: 0x04008F43 RID: 36675
		[Token(Token = "0x401A495")]
		LoveEvent_Detail_11095,
		// Token: 0x04008F44 RID: 36676
		[Token(Token = "0x401A496")]
		LoveEvent_Detail_11096,
		// Token: 0x04008F45 RID: 36677
		[Token(Token = "0x401A497")]
		LoveEvent_Detail_11097,
		// Token: 0x04008F46 RID: 36678
		[Token(Token = "0x401A498")]
		LoveEvent_Detail_11098,
		// Token: 0x04008F47 RID: 36679
		[Token(Token = "0x401A499")]
		LoveEvent_Detail_11099,
		// Token: 0x04008F48 RID: 36680
		[Token(Token = "0x401A49A")]
		LoveEvent_Detail_11100,
		// Token: 0x04008F49 RID: 36681
		[Token(Token = "0x401A49B")]
		LoveEvent_Detail_11101,
		// Token: 0x04008F4A RID: 36682
		[Token(Token = "0x401A49C")]
		LoveEvent_Detail_11102,
		// Token: 0x04008F4B RID: 36683
		[Token(Token = "0x401A49D")]
		LoveEvent_Detail_11103,
		// Token: 0x04008F4C RID: 36684
		[Token(Token = "0x401A49E")]
		LoveEvent_Detail_11110,
		// Token: 0x04008F4D RID: 36685
		[Token(Token = "0x401A49F")]
		LoveEvent_Detail_11111,
		// Token: 0x04008F4E RID: 36686
		[Token(Token = "0x401A4A0")]
		LoveEvent_Detail_11112,
		// Token: 0x04008F4F RID: 36687
		[Token(Token = "0x401A4A1")]
		LoveEvent_Detail_11113,
		// Token: 0x04008F50 RID: 36688
		[Token(Token = "0x401A4A2")]
		LoveEvent_Detail_11114,
		// Token: 0x04008F51 RID: 36689
		[Token(Token = "0x401A4A3")]
		LoveEvent_Detail_11115,
		// Token: 0x04008F52 RID: 36690
		[Token(Token = "0x401A4A4")]
		LoveEvent_Detail_11116,
		// Token: 0x04008F53 RID: 36691
		[Token(Token = "0x401A4A5")]
		LoveEvent_Detail_11117,
		// Token: 0x04008F54 RID: 36692
		[Token(Token = "0x401A4A6")]
		LoveEvent_Detail_11118,
		// Token: 0x04008F55 RID: 36693
		[Token(Token = "0x401A4A7")]
		LoveEvent_Detail_11119,
		// Token: 0x04008F56 RID: 36694
		[Token(Token = "0x401A4A8")]
		LoveEvent_Detail_12020,
		// Token: 0x04008F57 RID: 36695
		[Token(Token = "0x401A4A9")]
		LoveEvent_Detail_12021,
		// Token: 0x04008F58 RID: 36696
		[Token(Token = "0x401A4AA")]
		LoveEvent_Detail_12022,
		// Token: 0x04008F59 RID: 36697
		[Token(Token = "0x401A4AB")]
		LoveEvent_Detail_12040,
		// Token: 0x04008F5A RID: 36698
		[Token(Token = "0x401A4AC")]
		LoveEvent_Detail_12041,
		// Token: 0x04008F5B RID: 36699
		[Token(Token = "0x401A4AD")]
		LoveEvent_Detail_12042,
		// Token: 0x04008F5C RID: 36700
		[Token(Token = "0x401A4AE")]
		LoveEvent_Detail_12043,
		// Token: 0x04008F5D RID: 36701
		[Token(Token = "0x401A4AF")]
		LoveEvent_Detail_12050,
		// Token: 0x04008F5E RID: 36702
		[Token(Token = "0x401A4B0")]
		LoveEvent_Detail_12060,
		// Token: 0x04008F5F RID: 36703
		[Token(Token = "0x401A4B1")]
		LoveEvent_Detail_12070,
		// Token: 0x04008F60 RID: 36704
		[Token(Token = "0x401A4B2")]
		LoveEvent_Detail_12080,
		// Token: 0x04008F61 RID: 36705
		[Token(Token = "0x401A4B3")]
		LoveEvent_Detail_12090,
		// Token: 0x04008F62 RID: 36706
		[Token(Token = "0x401A4B4")]
		LoveEvent_Detail_12091,
		// Token: 0x04008F63 RID: 36707
		[Token(Token = "0x401A4B5")]
		LoveEvent_Detail_12092,
		// Token: 0x04008F64 RID: 36708
		[Token(Token = "0x401A4B6")]
		LoveEvent_Detail_12093,
		// Token: 0x04008F65 RID: 36709
		[Token(Token = "0x401A4B7")]
		LoveEvent_Detail_12094,
		// Token: 0x04008F66 RID: 36710
		[Token(Token = "0x401A4B8")]
		LoveEvent_Detail_12095,
		// Token: 0x04008F67 RID: 36711
		[Token(Token = "0x401A4B9")]
		LoveEvent_Detail_12096,
		// Token: 0x04008F68 RID: 36712
		[Token(Token = "0x401A4BA")]
		LoveEvent_Detail_12097,
		// Token: 0x04008F69 RID: 36713
		[Token(Token = "0x401A4BB")]
		LoveEvent_Detail_12098,
		// Token: 0x04008F6A RID: 36714
		[Token(Token = "0x401A4BC")]
		LoveEvent_Detail_12099,
		// Token: 0x04008F6B RID: 36715
		[Token(Token = "0x401A4BD")]
		LoveEvent_Detail_12100,
		// Token: 0x04008F6C RID: 36716
		[Token(Token = "0x401A4BE")]
		LoveEvent_Detail_12101,
		// Token: 0x04008F6D RID: 36717
		[Token(Token = "0x401A4BF")]
		LoveEvent_Detail_12110,
		// Token: 0x04008F6E RID: 36718
		[Token(Token = "0x401A4C0")]
		LoveEvent_Detail_12111,
		// Token: 0x04008F6F RID: 36719
		[Token(Token = "0x401A4C1")]
		LoveEvent_Detail_12112,
		// Token: 0x04008F70 RID: 36720
		[Token(Token = "0x401A4C2")]
		LoveEvent_Detail_12113,
		// Token: 0x04008F71 RID: 36721
		[Token(Token = "0x401A4C3")]
		LoveEvent_Detail_12114,
		// Token: 0x04008F72 RID: 36722
		[Token(Token = "0x401A4C4")]
		LoveEvent_Detail_12115,
		// Token: 0x04008F73 RID: 36723
		[Token(Token = "0x401A4C5")]
		LoveEvent_Detail_12116,
		// Token: 0x04008F74 RID: 36724
		[Token(Token = "0x401A4C6")]
		LoveEvent_Detail_12117,
		// Token: 0x04008F75 RID: 36725
		[Token(Token = "0x401A4C7")]
		LoveEvent_Detail_12118,
		// Token: 0x04008F76 RID: 36726
		[Token(Token = "0x401A4C8")]
		LoveEvent_Detail_12119,
		// Token: 0x04008F77 RID: 36727
		[Token(Token = "0x401A4C9")]
		LoveEvent_Detail_13020,
		// Token: 0x04008F78 RID: 36728
		[Token(Token = "0x401A4CA")]
		LoveEvent_Detail_13021,
		// Token: 0x04008F79 RID: 36729
		[Token(Token = "0x401A4CB")]
		LoveEvent_Detail_13022,
		// Token: 0x04008F7A RID: 36730
		[Token(Token = "0x401A4CC")]
		LoveEvent_Detail_13040,
		// Token: 0x04008F7B RID: 36731
		[Token(Token = "0x401A4CD")]
		LoveEvent_Detail_13041,
		// Token: 0x04008F7C RID: 36732
		[Token(Token = "0x401A4CE")]
		LoveEvent_Detail_13042,
		// Token: 0x04008F7D RID: 36733
		[Token(Token = "0x401A4CF")]
		LoveEvent_Detail_13043,
		// Token: 0x04008F7E RID: 36734
		[Token(Token = "0x401A4D0")]
		LoveEvent_Detail_13044,
		// Token: 0x04008F7F RID: 36735
		[Token(Token = "0x401A4D1")]
		LoveEvent_Detail_13050,
		// Token: 0x04008F80 RID: 36736
		[Token(Token = "0x401A4D2")]
		LoveEvent_Detail_13060,
		// Token: 0x04008F81 RID: 36737
		[Token(Token = "0x401A4D3")]
		LoveEvent_Detail_13070,
		// Token: 0x04008F82 RID: 36738
		[Token(Token = "0x401A4D4")]
		LoveEvent_Detail_13080,
		// Token: 0x04008F83 RID: 36739
		[Token(Token = "0x401A4D5")]
		LoveEvent_Detail_13090,
		// Token: 0x04008F84 RID: 36740
		[Token(Token = "0x401A4D6")]
		LoveEvent_Detail_13091,
		// Token: 0x04008F85 RID: 36741
		[Token(Token = "0x401A4D7")]
		LoveEvent_Detail_13092,
		// Token: 0x04008F86 RID: 36742
		[Token(Token = "0x401A4D8")]
		LoveEvent_Detail_13093,
		// Token: 0x04008F87 RID: 36743
		[Token(Token = "0x401A4D9")]
		LoveEvent_Detail_13094,
		// Token: 0x04008F88 RID: 36744
		[Token(Token = "0x401A4DA")]
		LoveEvent_Detail_13095,
		// Token: 0x04008F89 RID: 36745
		[Token(Token = "0x401A4DB")]
		LoveEvent_Detail_13096,
		// Token: 0x04008F8A RID: 36746
		[Token(Token = "0x401A4DC")]
		LoveEvent_Detail_13097,
		// Token: 0x04008F8B RID: 36747
		[Token(Token = "0x401A4DD")]
		LoveEvent_Detail_13098,
		// Token: 0x04008F8C RID: 36748
		[Token(Token = "0x401A4DE")]
		LoveEvent_Detail_13099,
		// Token: 0x04008F8D RID: 36749
		[Token(Token = "0x401A4DF")]
		LoveEvent_Detail_13100,
		// Token: 0x04008F8E RID: 36750
		[Token(Token = "0x401A4E0")]
		LoveEvent_Detail_13110,
		// Token: 0x04008F8F RID: 36751
		[Token(Token = "0x401A4E1")]
		LoveEvent_Detail_13111,
		// Token: 0x04008F90 RID: 36752
		[Token(Token = "0x401A4E2")]
		LoveEvent_Detail_13112,
		// Token: 0x04008F91 RID: 36753
		[Token(Token = "0x401A4E3")]
		LoveEvent_Detail_13113,
		// Token: 0x04008F92 RID: 36754
		[Token(Token = "0x401A4E4")]
		LoveEvent_Detail_13114,
		// Token: 0x04008F93 RID: 36755
		[Token(Token = "0x401A4E5")]
		LoveEvent_Detail_13115,
		// Token: 0x04008F94 RID: 36756
		[Token(Token = "0x401A4E6")]
		LoveEvent_Detail_13116,
		// Token: 0x04008F95 RID: 36757
		[Token(Token = "0x401A4E7")]
		LoveEvent_Detail_13117,
		// Token: 0x04008F96 RID: 36758
		[Token(Token = "0x401A4E8")]
		LoveEvent_Detail_13118,
		// Token: 0x04008F97 RID: 36759
		[Token(Token = "0x401A4E9")]
		LoveEvent_Detail_13119,
		// Token: 0x04008F98 RID: 36760
		[Token(Token = "0x401A4EA")]
		NEW_YEAR_EVE = 35000,
		// Token: 0x04008F99 RID: 36761
		[Token(Token = "0x401A4EB")]
		COOKING,
		// Token: 0x04008F9A RID: 36762
		[Token(Token = "0x401A4EC")]
		MAMEMAKI,
		// Token: 0x04008F9B RID: 36763
		[Token(Token = "0x401A4ED")]
		FISHING,
		// Token: 0x04008F9C RID: 36764
		[Token(Token = "0x401A4EE")]
		FLOWER_FES,
		// Token: 0x04008F9D RID: 36765
		[Token(Token = "0x401A4EF")]
		VAGE_SPRING,
		// Token: 0x04008F9E RID: 36766
		[Token(Token = "0x401A4F0")]
		SEA_OPEN,
		// Token: 0x04008F9F RID: 36767
		[Token(Token = "0x401A4F1")]
		MONSTER_RACE,
		// Token: 0x04008FA0 RID: 36768
		[Token(Token = "0x401A4F2")]
		PET_FES,
		// Token: 0x04008FA1 RID: 36769
		[Token(Token = "0x401A4F3")]
		NIGHT_BEACH,
		// Token: 0x04008FA2 RID: 36770
		[Token(Token = "0x401A4F4")]
		VAGE_SUMMER,
		// Token: 0x04008FA3 RID: 36771
		[Token(Token = "0x401A4F5")]
		BLACKSMITH,
		// Token: 0x04008FA4 RID: 36772
		[Token(Token = "0x401A4F6")]
		VALENTINE,
		// Token: 0x04008FA5 RID: 36773
		[Token(Token = "0x401A4F7")]
		OOGUI,
		// Token: 0x04008FA6 RID: 36774
		[Token(Token = "0x401A4F8")]
		HALLOWEEN,
		// Token: 0x04008FA7 RID: 36775
		[Token(Token = "0x401A4F9")]
		WHITE_DAY,
		// Token: 0x04008FA8 RID: 36776
		[Token(Token = "0x401A4FA")]
		VAGE_AUTUMN,
		// Token: 0x04008FA9 RID: 36777
		[Token(Token = "0x401A4FB")]
		SNOW_ART,
		// Token: 0x04008FAA RID: 36778
		[Token(Token = "0x401A4FC")]
		FISHING_IKA,
		// Token: 0x04008FAB RID: 36779
		[Token(Token = "0x401A4FD")]
		HOLY_FES,
		// Token: 0x04008FAC RID: 36780
		[Token(Token = "0x401A4FE")]
		VAGE_WINTER,
		// Token: 0x04008FAD RID: 36781
		[Token(Token = "0x401A4FF")]
		LAST_YEAR_EVE,
		// Token: 0x04008FAE RID: 36782
		[Token(Token = "0x401A500")]
		BIRTHDAY,
		// Token: 0x04008FAF RID: 36783
		[Token(Token = "0x401A501")]
		COOKING_UNIT,
		// Token: 0x04008FB0 RID: 36784
		[Token(Token = "0x401A502")]
		MAMEMAKI_UNIT,
		// Token: 0x04008FB1 RID: 36785
		[Token(Token = "0x401A503")]
		FISHING_UNIT,
		// Token: 0x04008FB2 RID: 36786
		[Token(Token = "0x401A504")]
		VAGE_SPRING_UNIT,
		// Token: 0x04008FB3 RID: 36787
		[Token(Token = "0x401A505")]
		MONSTER_RACE_UNIT,
		// Token: 0x04008FB4 RID: 36788
		[Token(Token = "0x401A506")]
		PET_FES_UNIT,
		// Token: 0x04008FB5 RID: 36789
		[Token(Token = "0x401A507")]
		VAGE_SUMMER_UNIT,
		// Token: 0x04008FB6 RID: 36790
		[Token(Token = "0x401A508")]
		BLACKSMITH_UNIT,
		// Token: 0x04008FB7 RID: 36791
		[Token(Token = "0x401A509")]
		OOGUI_UNIT,
		// Token: 0x04008FB8 RID: 36792
		[Token(Token = "0x401A50A")]
		HALLOWEEN_UNIT,
		// Token: 0x04008FB9 RID: 36793
		[Token(Token = "0x401A50B")]
		VAGE_AUTUMN_UNIT,
		// Token: 0x04008FBA RID: 36794
		[Token(Token = "0x401A50C")]
		SNOW_ART_UNIT,
		// Token: 0x04008FBB RID: 36795
		[Token(Token = "0x401A50D")]
		FISHING_IKA_UNIT,
		// Token: 0x04008FBC RID: 36796
		[Token(Token = "0x401A50E")]
		VAGE_WINTER_UNIT,
		// Token: 0x04008FBD RID: 36797
		[Token(Token = "0x401A50F")]
		HOTARUBI_CANCEL,
		// Token: 0x04008FBE RID: 36798
		[Token(Token = "0x401A510")]
		FARM_TXT_CROPS_0067 = 90066,
		// Token: 0x04008FBF RID: 36799
		[Token(Token = "0x401A511")]
		FARM_TXT_CROPS_0068,
		// Token: 0x04008FC0 RID: 36800
		[Token(Token = "0x401A512")]
		FARM_TXT_CROPS_0069,
		// Token: 0x04008FC1 RID: 36801
		[Token(Token = "0x401A513")]
		FARM_TXT_CROPS_0070,
		// Token: 0x04008FC2 RID: 36802
		[Token(Token = "0x401A514")]
		FARM_TXT_CROPS_0071,
		// Token: 0x04008FC3 RID: 36803
		[Token(Token = "0x401A515")]
		FARM_TXT_CROPS_0072,
		// Token: 0x04008FC4 RID: 36804
		[Token(Token = "0x401A516")]
		FARM_TXT_GRASS_0050 = 90121,
		// Token: 0x04008FC5 RID: 36805
		[Token(Token = "0x401A517")]
		FARM_TXT_GRASS_0051,
		// Token: 0x04008FC6 RID: 36806
		[Token(Token = "0x401A518")]
		FARM_TXT_MINE_0013 = 90136,
		// Token: 0x04008FC7 RID: 36807
		[Token(Token = "0x401A519")]
		FARM_TXT_MINE_0014,
		// Token: 0x04008FC8 RID: 36808
		[Token(Token = "0x401A51A")]
		FARM_TXT_MINE_0015,
		// Token: 0x04008FC9 RID: 36809
		[Token(Token = "0x401A51B")]
		FARM_TXT_MINE_0016,
		// Token: 0x04008FCA RID: 36810
		[Token(Token = "0x401A51C")]
		FARM_TXT_MINE_0017,
		// Token: 0x04008FCB RID: 36811
		[Token(Token = "0x401A51D")]
		FARM_TXT_MINE_0018,
		// Token: 0x04008FCC RID: 36812
		[Token(Token = "0x401A51E")]
		FARM_TXT_MINE_0019,
		// Token: 0x04008FCD RID: 36813
		[Token(Token = "0x401A51F")]
		FARM_TXT_MINE_0020,
		// Token: 0x04008FCE RID: 36814
		[Token(Token = "0x401A520")]
		FARM_TXT_MINE_0021,
		// Token: 0x04008FCF RID: 36815
		[Token(Token = "0x401A521")]
		FARM_TXT_MINE_0022,
		// Token: 0x04008FD0 RID: 36816
		[Token(Token = "0x401A522")]
		FARM_TXT_MINE_0023,
		// Token: 0x04008FD1 RID: 36817
		[Token(Token = "0x401A523")]
		FARM_TXT_MINE_0024,
		// Token: 0x04008FD2 RID: 36818
		[Token(Token = "0x401A524")]
		FARM_TXT_MINE_0025,
		// Token: 0x04008FD3 RID: 36819
		[Token(Token = "0x401A525")]
		FARM_TXT_MINE_0026,
		// Token: 0x04008FD4 RID: 36820
		[Token(Token = "0x401A526")]
		FARM_TXT_MINE_0027,
		// Token: 0x04008FD5 RID: 36821
		[Token(Token = "0x401A527")]
		FARM_TXT_MINE_0028,
		// Token: 0x04008FD6 RID: 36822
		[Token(Token = "0x401A528")]
		FARM_TXT_MINE_0029,
		// Token: 0x04008FD7 RID: 36823
		[Token(Token = "0x401A529")]
		FARM_TXT_MINE_0030,
		// Token: 0x04008FD8 RID: 36824
		[Token(Token = "0x401A52A")]
		FARM_TXT_MINE_0031,
		// Token: 0x04008FD9 RID: 36825
		[Token(Token = "0x401A52B")]
		FARM_TXT_MINE_0032,
		// Token: 0x04008FDA RID: 36826
		[Token(Token = "0x401A52C")]
		FARM_TXT_MINE_0033,
		// Token: 0x04008FDB RID: 36827
		[Token(Token = "0x401A52D")]
		FARM_TXT_MINE_0034,
		// Token: 0x04008FDC RID: 36828
		[Token(Token = "0x401A52E")]
		FARM_TXT_MINE_0035,
		// Token: 0x04008FDD RID: 36829
		[Token(Token = "0x401A52F")]
		FARM_TXT_MINE_0036,
		// Token: 0x04008FDE RID: 36830
		[Token(Token = "0x401A530")]
		FARM_TXT_MINE_0037,
		// Token: 0x04008FDF RID: 36831
		[Token(Token = "0x401A531")]
		FARM_TXT_MINE_0038,
		// Token: 0x04008FE0 RID: 36832
		[Token(Token = "0x401A532")]
		FARM_TXT_MINE_0039,
		// Token: 0x04008FE1 RID: 36833
		[Token(Token = "0x401A533")]
		FARM_TXT_CRYSTAL_0001,
		// Token: 0x04008FE2 RID: 36834
		[Token(Token = "0x401A534")]
		FARM_TXT_CRYSTAL_0002,
		// Token: 0x04008FE3 RID: 36835
		[Token(Token = "0x401A535")]
		FARM_TXT_CRYSTAL_0003,
		// Token: 0x04008FE4 RID: 36836
		[Token(Token = "0x401A536")]
		FARM_TXT_CRYSTAL_0004,
		// Token: 0x04008FE5 RID: 36837
		[Token(Token = "0x401A537")]
		FARM_TXT_CRYSTAL_0005,
		// Token: 0x04008FE6 RID: 36838
		[Token(Token = "0x401A538")]
		FARM_TXT_CRYSTAL_0006,
		// Token: 0x04008FE7 RID: 36839
		[Token(Token = "0x401A539")]
		FARM_TXT_CRYSTAL_0007,
		// Token: 0x04008FE8 RID: 36840
		[Token(Token = "0x401A53A")]
		FARM_TXT_CRYSTAL_0008,
		// Token: 0x04008FE9 RID: 36841
		[Token(Token = "0x401A53B")]
		FARM_TXT_CRYSTAL_0009,
		// Token: 0x04008FEA RID: 36842
		[Token(Token = "0x401A53C")]
		FARM_TXT_DRAGON_0001,
		// Token: 0x04008FEB RID: 36843
		[Token(Token = "0x401A53D")]
		FARM_TXT_DRAGON_0002,
		// Token: 0x04008FEC RID: 36844
		[Token(Token = "0x401A53E")]
		FARM_TXT_DRAGON_0003,
		// Token: 0x04008FED RID: 36845
		[Token(Token = "0x401A53F")]
		FARM_TXT_DRAGON_0004,
		// Token: 0x04008FEE RID: 36846
		[Token(Token = "0x401A540")]
		FARM_TXT_DRAGON_0005,
		// Token: 0x04008FEF RID: 36847
		[Token(Token = "0x401A541")]
		FARM_TXT_DRAGON_0006,
		// Token: 0x04008FF0 RID: 36848
		[Token(Token = "0x401A542")]
		FARM_TXT_DRAGON_0007,
		// Token: 0x04008FF1 RID: 36849
		[Token(Token = "0x401A543")]
		FARM_TXT_STATUS_0001,
		// Token: 0x04008FF2 RID: 36850
		[Token(Token = "0x401A544")]
		FARM_TXT_STATUS_0002,
		// Token: 0x04008FF3 RID: 36851
		[Token(Token = "0x401A545")]
		FARM_TXT_STATUS_0003,
		// Token: 0x04008FF4 RID: 36852
		[Token(Token = "0x401A546")]
		FARM_TXT_STATUS_0004,
		// Token: 0x04008FF5 RID: 36853
		[Token(Token = "0x401A547")]
		FARM_TXT_STATUS_0005,
		// Token: 0x04008FF6 RID: 36854
		[Token(Token = "0x401A548")]
		FARM_TXT_STATUS_0006,
		// Token: 0x04008FF7 RID: 36855
		[Token(Token = "0x401A549")]
		FARM_TXT_STATUS_0007,
		// Token: 0x04008FF8 RID: 36856
		[Token(Token = "0x401A54A")]
		FARM_TXT_STATUS_0008,
		// Token: 0x04008FF9 RID: 36857
		[Token(Token = "0x401A54B")]
		FARM_TXT_STATUS_0009,
		// Token: 0x04008FFA RID: 36858
		[Token(Token = "0x401A54C")]
		FARM_TXT_STATUS_0010,
		// Token: 0x04008FFB RID: 36859
		[Token(Token = "0x401A54D")]
		FARM_TXT_STATUS_0011,
		// Token: 0x04008FFC RID: 36860
		[Token(Token = "0x401A54E")]
		FARM_TXT_STATUS_0012,
		// Token: 0x04008FFD RID: 36861
		[Token(Token = "0x401A54F")]
		FARM_TXT_STATUS_0013,
		// Token: 0x04008FFE RID: 36862
		[Token(Token = "0x401A550")]
		FARM_TXT_STATUS_0014,
		// Token: 0x04008FFF RID: 36863
		[Token(Token = "0x401A551")]
		FARM_TXT_STATUS_0015,
		// Token: 0x04009000 RID: 36864
		[Token(Token = "0x401A552")]
		FARM_TXT_STATUS_0016,
		// Token: 0x04009001 RID: 36865
		[Token(Token = "0x401A553")]
		FARM_TXT_STATUS_0017,
		// Token: 0x04009002 RID: 36866
		[Token(Token = "0x401A554")]
		FARM_TXT_STATUS_0018,
		// Token: 0x04009003 RID: 36867
		[Token(Token = "0x401A555")]
		FARM_TXT_STATUS_0019,
		// Token: 0x04009004 RID: 36868
		[Token(Token = "0x401A556")]
		FARM_TXT_STATUS_0020,
		// Token: 0x04009005 RID: 36869
		[Token(Token = "0x401A557")]
		FARM_TXT_MONSTERHUT_0001,
		// Token: 0x04009006 RID: 36870
		[Token(Token = "0x401A558")]
		FARM_TXT_MONSTERHUT_0002,
		// Token: 0x04009007 RID: 36871
		[Token(Token = "0x401A559")]
		FARM_TXT_MONSTERHUT_0003,
		// Token: 0x04009008 RID: 36872
		[Token(Token = "0x401A55A")]
		FARM_TXT_MONSTERHUT_0004,
		// Token: 0x04009009 RID: 36873
		[Token(Token = "0x401A55B")]
		FARM_TXT_MONSTERHUT_0005,
		// Token: 0x0400900A RID: 36874
		[Token(Token = "0x401A55C")]
		FARM_TXT_MONSTERHUT_0006,
		// Token: 0x0400900B RID: 36875
		[Token(Token = "0x401A55D")]
		FARM_TXT_MONSTERHUT_0007,
		// Token: 0x0400900C RID: 36876
		[Token(Token = "0x401A55E")]
		FARM_TXT_MONSTERHUT_0008,
		// Token: 0x0400900D RID: 36877
		[Token(Token = "0x401A55F")]
		FARM_TXT_MONSTERHUT_0009,
		// Token: 0x0400900E RID: 36878
		[Token(Token = "0x401A560")]
		FARM_TXT_MONSTERHUT_0010,
		// Token: 0x0400900F RID: 36879
		[Token(Token = "0x401A561")]
		FARM_TXT_PIECE,
		// Token: 0x04009010 RID: 36880
		[Token(Token = "0x401A562")]
		FARM_TXT_PERCENT,
		// Token: 0x04009011 RID: 36881
		[Token(Token = "0x401A563")]
		FARM_TXT_CROPS_0069_BIG = 90214,
		// Token: 0x04009012 RID: 36882
		[Token(Token = "0x401A564")]
		FARM_TXT_CROPS_0070_BIG,
		// Token: 0x04009013 RID: 36883
		[Token(Token = "0x401A565")]
		FARM_TXT_CROPS_0071_BIG,
		// Token: 0x04009014 RID: 36884
		[Token(Token = "0x401A566")]
		FARM_TXT_CROPS_0072_BIG,
		// Token: 0x04009015 RID: 36885
		[Token(Token = "0x401A567")]
		FARM_TXT_MINING_METEOR,
		// Token: 0x04009016 RID: 36886
		[Token(Token = "0x401A568")]
		SWITCH_CONTROLLER_BUTTON_CROSS = 100000,
		// Token: 0x04009017 RID: 36887
		[Token(Token = "0x401A569")]
		SWITCH_CONTROLLER_BUTTON_LEFT,
		// Token: 0x04009018 RID: 36888
		[Token(Token = "0x401A56A")]
		SWITCH_CONTROLLER_BUTTON_RIGHT,
		// Token: 0x04009019 RID: 36889
		[Token(Token = "0x401A56B")]
		SWITCH_CONTROLLER_BUTTON_UP,
		// Token: 0x0400901A RID: 36890
		[Token(Token = "0x401A56C")]
		SWITCH_CONTROLLER_BUTTON_DOWN,
		// Token: 0x0400901B RID: 36891
		[Token(Token = "0x401A56D")]
		SWITCH_CONTROLLER_BUTTON_LSTICK,
		// Token: 0x0400901C RID: 36892
		[Token(Token = "0x401A56E")]
		SWITCH_CONTROLLER_BUTTON_LSTICKBUTTON,
		// Token: 0x0400901D RID: 36893
		[Token(Token = "0x401A56F")]
		SWITCH_CONTROLLER_BUTTON_RSTICK,
		// Token: 0x0400901E RID: 36894
		[Token(Token = "0x401A570")]
		SWITCH_CONTROLLER_BUTTON_RSTICKBUTTON,
		// Token: 0x0400901F RID: 36895
		[Token(Token = "0x401A571")]
		SWITCH_CONTROLLER_BUTTON_MINUS,
		// Token: 0x04009020 RID: 36896
		[Token(Token = "0x401A572")]
		SWITCH_CONTROLLER_BUTTON_PLUS,
		// Token: 0x04009021 RID: 36897
		[Token(Token = "0x401A573")]
		SWITCH_CONTROLLER_BUTTON_A,
		// Token: 0x04009022 RID: 36898
		[Token(Token = "0x401A574")]
		SWITCH_CONTROLLER_BUTTON_B,
		// Token: 0x04009023 RID: 36899
		[Token(Token = "0x401A575")]
		SWITCH_CONTROLLER_BUTTON_X,
		// Token: 0x04009024 RID: 36900
		[Token(Token = "0x401A576")]
		SWITCH_CONTROLLER_BUTTON_Y,
		// Token: 0x04009025 RID: 36901
		[Token(Token = "0x401A577")]
		SWITCH_CONTROLLER_BUTTON_L,
		// Token: 0x04009026 RID: 36902
		[Token(Token = "0x401A578")]
		SWITCH_CONTROLLER_BUTTON_ZL,
		// Token: 0x04009027 RID: 36903
		[Token(Token = "0x401A579")]
		SWITCH_CONTROLLER_BUTTON_R,
		// Token: 0x04009028 RID: 36904
		[Token(Token = "0x401A57A")]
		SWITCH_CONTROLLER_BUTTON_ZR,
		// Token: 0x04009029 RID: 36905
		[Token(Token = "0x401A57B")]
		SWITCH_CONTROLLER_BUTTON_XY,
		// Token: 0x0400902A RID: 36906
		[Token(Token = "0x401A57C")]
		SWITCH_CONTROLLER_BUTTON_HOME,
		// Token: 0x0400902B RID: 36907
		[Token(Token = "0x401A57D")]
		SWITCH_CONTROLLER_BUTTON_CAPTURE,
		// Token: 0x0400902C RID: 36908
		[Token(Token = "0x401A57E")]
		SWITCH_CONTROLLER_BUTTON_POWER,
		// Token: 0x0400902D RID: 36909
		[Token(Token = "0x401A57F")]
		SWITCH_CONTROLLER_BUTTON_VOLUME,
		// Token: 0x0400902E RID: 36910
		[Token(Token = "0x401A580")]
		ADV_BYTHEWAY_TITLE_01 = 101000,
		// Token: 0x0400902F RID: 36911
		[Token(Token = "0x401A581")]
		ADV_BYTHEWAY_TITLE_02,
		// Token: 0x04009030 RID: 36912
		[Token(Token = "0x401A582")]
		ADV_BYTHEWAY_TITLE_03,
		// Token: 0x04009031 RID: 36913
		[Token(Token = "0x401A583")]
		ADV_BYTHEWAY_CHOICE_01,
		// Token: 0x04009032 RID: 36914
		[Token(Token = "0x401A584")]
		ADV_BYTHEWAY_CHOICE_02,
		// Token: 0x04009033 RID: 36915
		[Token(Token = "0x401A585")]
		ADV_BYTHEWAY_CHOICE_03,
		// Token: 0x04009034 RID: 36916
		[Token(Token = "0x401A586")]
		ADV_BYTHEWAY_CHOICE_04,
		// Token: 0x04009035 RID: 36917
		[Token(Token = "0x401A587")]
		ADV_PARTNER_CHOICE_01,
		// Token: 0x04009036 RID: 36918
		[Token(Token = "0x401A588")]
		ADV_PARTNER_CHOICE_02,
		// Token: 0x04009037 RID: 36919
		[Token(Token = "0x401A589")]
		ADV_PARTNER_CHOICE_03,
		// Token: 0x04009038 RID: 36920
		[Token(Token = "0x401A58A")]
		ADV_PARTNER_CHOICE_04,
		// Token: 0x04009039 RID: 36921
		[Token(Token = "0x401A58B")]
		ADV_PARTNER_CHOICE_05,
		// Token: 0x0400903A RID: 36922
		[Token(Token = "0x401A58C")]
		ADV_PARTNER_CHOICE_06,
		// Token: 0x0400903B RID: 36923
		[Token(Token = "0x401A58D")]
		ADV_PARTNER_CHOICE_07,
		// Token: 0x0400903C RID: 36924
		[Token(Token = "0x401A58E")]
		ADV_PARTNER_BATTLE_CHOICE_01,
		// Token: 0x0400903D RID: 36925
		[Token(Token = "0x401A58F")]
		ADV_PARTNER_BATTLE_CHOICE_02,
		// Token: 0x0400903E RID: 36926
		[Token(Token = "0x401A590")]
		ADV_PARTNER_BATTLE_CHOICE_03,
		// Token: 0x0400903F RID: 36927
		[Token(Token = "0x401A591")]
		ADV_PARTNER_BATTLE_CHOICE_04,
		// Token: 0x04009040 RID: 36928
		[Token(Token = "0x401A592")]
		ADV_CHOICE_NOTHING,
		// Token: 0x04009041 RID: 36929
		[Token(Token = "0x401A593")]
		ADV_MONSTER_CHOICE_01,
		// Token: 0x04009042 RID: 36930
		[Token(Token = "0x401A594")]
		ADV_MONSTER_CHOICE_02,
		// Token: 0x04009043 RID: 36931
		[Token(Token = "0x401A595")]
		ADV_MONSTER_CHOICE_03,
		// Token: 0x04009044 RID: 36932
		[Token(Token = "0x401A596")]
		ADV_MONSTER_CHOICE_04,
		// Token: 0x04009045 RID: 36933
		[Token(Token = "0x401A597")]
		ADV_MONSTER_CHOICE_05,
		// Token: 0x04009046 RID: 36934
		[Token(Token = "0x401A598")]
		ADV_MONSTER_CHOICE_06,
		// Token: 0x04009047 RID: 36935
		[Token(Token = "0x401A599")]
		ADV_MONSTER_FARM_WORK_CHOICE_01,
		// Token: 0x04009048 RID: 36936
		[Token(Token = "0x401A59A")]
		ADV_MONSTER_FARM_WORK_CHOICE_02,
		// Token: 0x04009049 RID: 36937
		[Token(Token = "0x401A59B")]
		ADV_MONSTER_FARM_WORK_CHOICE_03,
		// Token: 0x0400904A RID: 36938
		[Token(Token = "0x401A59C")]
		ADV_MONSTER_FARM_WORK_CHOICE_04,
		// Token: 0x0400904B RID: 36939
		[Token(Token = "0x401A59D")]
		ADV_MONSTER_FARM_WORK_CHOICE_05,
		// Token: 0x0400904C RID: 36940
		[Token(Token = "0x401A59E")]
		ADV_CHOICE_CONFIRM_01,
		// Token: 0x0400904D RID: 36941
		[Token(Token = "0x401A59F")]
		ADV_CHOICE_CONFIRM_02,
		// Token: 0x0400904E RID: 36942
		[Token(Token = "0x401A5A0")]
		ADV_MONSTER_SOWING_SEED_CHOICE_01,
		// Token: 0x0400904F RID: 36943
		[Token(Token = "0x401A5A1")]
		ADV_PARTNER_MONSTER_CHOICE_01,
		// Token: 0x04009050 RID: 36944
		[Token(Token = "0x401A5A2")]
		ADV_PARTNER_MONSTER_CHOICE_02,
		// Token: 0x04009051 RID: 36945
		[Token(Token = "0x401A5A3")]
		ADV_MONSTER_CHANGE_NICKNAME,
		// Token: 0x04009052 RID: 36946
		[Token(Token = "0x401A5A4")]
		ADV_MONSTER_RELEASE,
		// Token: 0x04009053 RID: 36947
		[Token(Token = "0x401A5A5")]
		ADV_HANDCUFFS_CHOICE_01,
		// Token: 0x04009054 RID: 36948
		[Token(Token = "0x401A5A6")]
		ADV_CHOICE_MONSTER_NOTHING,
		// Token: 0x04009055 RID: 36949
		[Token(Token = "0x401A5A7")]
		ADV_MONSTER_PLAYER_MESSAGE_1ST_01,
		// Token: 0x04009056 RID: 36950
		[Token(Token = "0x401A5A8")]
		ADV_MONSTER_PLAYER_MESSAGE_1ST_02,
		// Token: 0x04009057 RID: 36951
		[Token(Token = "0x401A5A9")]
		ADV_MONSTER_PLAYER_MESSAGE_FARMWORK_SELECT_01,
		// Token: 0x04009058 RID: 36952
		[Token(Token = "0x401A5AA")]
		ADV_MONSTER_PLAYER_MESSAGE_FARMWORK_CONFIRM_01,
		// Token: 0x04009059 RID: 36953
		[Token(Token = "0x401A5AB")]
		ADV_MONSTER_PLAYER_MESSAGE_NOT_FARMWORK_01,
		// Token: 0x0400905A RID: 36954
		[Token(Token = "0x401A5AC")]
		ADV_MONSTER_PLAYER_MESSAGE_SOWINGSEED_CONFIRM_01,
		// Token: 0x0400905B RID: 36955
		[Token(Token = "0x401A5AD")]
		ADV_MONSTER_PLAYER_MESSAGE_NOT_SOWINGSEED_01,
		// Token: 0x0400905C RID: 36956
		[Token(Token = "0x401A5AE")]
		ADV_MONSTER_PLAYER_MESSAGE_RELEASE_CONFIRM_01,
		// Token: 0x0400905D RID: 36957
		[Token(Token = "0x401A5AF")]
		ADV_MONSTER_PLAYER_MESSAGE_RELEASE_CONFIRM_02,
		// Token: 0x0400905E RID: 36958
		[Token(Token = "0x401A5B0")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_01,
		// Token: 0x0400905F RID: 36959
		[Token(Token = "0x401A5B1")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_02,
		// Token: 0x04009060 RID: 36960
		[Token(Token = "0x401A5B2")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_03,
		// Token: 0x04009061 RID: 36961
		[Token(Token = "0x401A5B3")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_04,
		// Token: 0x04009062 RID: 36962
		[Token(Token = "0x401A5B4")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_05,
		// Token: 0x04009063 RID: 36963
		[Token(Token = "0x401A5B5")]
		ADV_ADV_BYTHEWAY_SELECT_DATESPOT_06,
		// Token: 0x04009064 RID: 36964
		[Token(Token = "0x401A5B6")]
		ADV_CONFESSIONOFLOVE_SPOT,
		// Token: 0x04009065 RID: 36965
		[Token(Token = "0x401A5B7")]
		ADV_SKINSHIP_SELECT_01,
		// Token: 0x04009066 RID: 36966
		[Token(Token = "0x401A5B8")]
		ADV_SKINSHIP_SELECT_02,
		// Token: 0x04009067 RID: 36967
		[Token(Token = "0x401A5B9")]
		ADV_SKINSHIP_SELECT_03,
		// Token: 0x04009068 RID: 36968
		[Token(Token = "0x401A5BA")]
		ADV_SKINSHIP_SELECT_04,
		// Token: 0x04009069 RID: 36969
		[Token(Token = "0x401A5BB")]
		ADV_SKINSHIP_SELECT_05,
		// Token: 0x0400906A RID: 36970
		[Token(Token = "0x401A5BC")]
		ADV_SKINSHIP_SELECT_06,
		// Token: 0x0400906B RID: 36971
		[Token(Token = "0x401A5BD")]
		ADV_SKINSHIP_SELECT_07,
		// Token: 0x0400906C RID: 36972
		[Token(Token = "0x401A5BE")]
		ADV_CHILDGENDER_MALE_TEXT,
		// Token: 0x0400906D RID: 36973
		[Token(Token = "0x401A5BF")]
		ADV_CHILDGENDER_FEMALE_TEXT,
		// Token: 0x0400906E RID: 36974
		[Token(Token = "0x401A5C0")]
		ADV_CHILDGENDER_MALE_TEXT_FUQUA,
		// Token: 0x0400906F RID: 36975
		[Token(Token = "0x401A5C1")]
		ADV_CHILDGENDER_FEMALE_TEXT_FUQUA,
		// Token: 0x04009070 RID: 36976
		[Token(Token = "0x401A5C2")]
		ADV_MONSTER_PLAYER_MESSAGE_TAKE_OUT_01,
		// Token: 0x04009071 RID: 36977
		[Token(Token = "0x401A5C3")]
		ADV_MONSTER_PLAYER_MESSAGE_NOT_RIDE_01,
		// Token: 0x04009072 RID: 36978
		[Token(Token = "0x401A5C4")]
		ADV_MONSTER_PLAYER_MESSAGE_NOT_RIDE_02,
		// Token: 0x04009073 RID: 36979
		[Token(Token = "0x401A5C5")]
		ADV_MONSTER_RIDEON_CHOICE_01,
		// Token: 0x04009074 RID: 36980
		[Token(Token = "0x401A5C6")]
		ADV_MONSTER_RIDEON_CHOICE_02,
		// Token: 0x04009075 RID: 36981
		[Token(Token = "0x401A5C7")]
		ADV_CHILDPERSONALITY_BOY1,
		// Token: 0x04009076 RID: 36982
		[Token(Token = "0x401A5C8")]
		ADV_CHILDPERSONALITY_BOY2,
		// Token: 0x04009077 RID: 36983
		[Token(Token = "0x401A5C9")]
		ADV_CHILDPERSONALITY_BOY3,
		// Token: 0x04009078 RID: 36984
		[Token(Token = "0x401A5CA")]
		ADV_CHILDPERSONALITY_GIRL1,
		// Token: 0x04009079 RID: 36985
		[Token(Token = "0x401A5CB")]
		ADV_CHILDPERSONALITY_GIRL2,
		// Token: 0x0400907A RID: 36986
		[Token(Token = "0x401A5CC")]
		ADV_CHILDPERSONALITY_GIRL3,
		// Token: 0x0400907B RID: 36987
		[Token(Token = "0x401A5CD")]
		ADV_CHILDPERSONALITY_RANDOM,
		// Token: 0x0400907C RID: 36988
		[Token(Token = "0x401A5CE")]
		ADV_MONSTER_PLAYER_MESSAGE_RELEASE_CONFIRM_03,
		// Token: 0x0400907D RID: 36989
		[Token(Token = "0x401A5CF")]
		PLAYER_DEFAULT_NAME01 = 102000,
		// Token: 0x0400907E RID: 36990
		[Token(Token = "0x401A5D0")]
		PLAYER_DEFAULT_NAME02,
		// Token: 0x0400907F RID: 36991
		[Token(Token = "0x401A5D1")]
		CHILD1_DEFAULT_NAME01,
		// Token: 0x04009080 RID: 36992
		[Token(Token = "0x401A5D2")]
		CHILD1_DEFAULT_NAME02,
		// Token: 0x04009081 RID: 36993
		[Token(Token = "0x401A5D3")]
		CHILD2_DEFAULT_NAME01,
		// Token: 0x04009082 RID: 36994
		[Token(Token = "0x401A5D4")]
		CHILD2_DEFAULT_NAME02,
		// Token: 0x04009083 RID: 36995
		[Token(Token = "0x401A5D5")]
		SCREEN_NAME001,
		// Token: 0x04009084 RID: 36996
		[Token(Token = "0x401A5D6")]
		SCREEN_NAME002,
		// Token: 0x04009085 RID: 36997
		[Token(Token = "0x401A5D7")]
		SCREEN_NAME003,
		// Token: 0x04009086 RID: 36998
		[Token(Token = "0x401A5D8")]
		SCREEN_NAME004,
		// Token: 0x04009087 RID: 36999
		[Token(Token = "0x401A5D9")]
		SCREEN_NAME005,
		// Token: 0x04009088 RID: 37000
		[Token(Token = "0x401A5DA")]
		SCREEN_NAME006,
		// Token: 0x04009089 RID: 37001
		[Token(Token = "0x401A5DB")]
		SCREEN_NAME007,
		// Token: 0x0400908A RID: 37002
		[Token(Token = "0x401A5DC")]
		SCREEN_NAME008,
		// Token: 0x0400908B RID: 37003
		[Token(Token = "0x401A5DD")]
		SCREEN_NAME009,
		// Token: 0x0400908C RID: 37004
		[Token(Token = "0x401A5DE")]
		SCREEN_NAME010,
		// Token: 0x0400908D RID: 37005
		[Token(Token = "0x401A5DF")]
		SCREEN_NAME011,
		// Token: 0x0400908E RID: 37006
		[Token(Token = "0x401A5E0")]
		SCREEN_NAME012,
		// Token: 0x0400908F RID: 37007
		[Token(Token = "0x401A5E1")]
		SCREEN_NAME013,
		// Token: 0x04009090 RID: 37008
		[Token(Token = "0x401A5E2")]
		SCREEN_NAME014,
		// Token: 0x04009091 RID: 37009
		[Token(Token = "0x401A5E3")]
		SCREEN_NAME015,
		// Token: 0x04009092 RID: 37010
		[Token(Token = "0x401A5E4")]
		SCREEN_NAME016,
		// Token: 0x04009093 RID: 37011
		[Token(Token = "0x401A5E5")]
		SCREEN_NAME017,
		// Token: 0x04009094 RID: 37012
		[Token(Token = "0x401A5E6")]
		SCREEN_NAME018,
		// Token: 0x04009095 RID: 37013
		[Token(Token = "0x401A5E7")]
		SCREEN_NAME019,
		// Token: 0x04009096 RID: 37014
		[Token(Token = "0x401A5E8")]
		SCREEN_NAME020,
		// Token: 0x04009097 RID: 37015
		[Token(Token = "0x401A5E9")]
		SCREEN_NAME021,
		// Token: 0x04009098 RID: 37016
		[Token(Token = "0x401A5EA")]
		SCREEN_NAME022,
		// Token: 0x04009099 RID: 37017
		[Token(Token = "0x401A5EB")]
		SCREEN_NAME023,
		// Token: 0x0400909A RID: 37018
		[Token(Token = "0x401A5EC")]
		SCREEN_NAME024,
		// Token: 0x0400909B RID: 37019
		[Token(Token = "0x401A5ED")]
		SCREEN_NAME025,
		// Token: 0x0400909C RID: 37020
		[Token(Token = "0x401A5EE")]
		SCREEN_NAME026,
		// Token: 0x0400909D RID: 37021
		[Token(Token = "0x401A5EF")]
		SCREEN_NAME027,
		// Token: 0x0400909E RID: 37022
		[Token(Token = "0x401A5F0")]
		SCREEN_NAME028,
		// Token: 0x0400909F RID: 37023
		[Token(Token = "0x401A5F1")]
		SCREEN_NAME029,
		// Token: 0x040090A0 RID: 37024
		[Token(Token = "0x401A5F2")]
		SCREEN_NAME030,
		// Token: 0x040090A1 RID: 37025
		[Token(Token = "0x401A5F3")]
		SCREEN_NAME031,
		// Token: 0x040090A2 RID: 37026
		[Token(Token = "0x401A5F4")]
		SCREEN_NAME032,
		// Token: 0x040090A3 RID: 37027
		[Token(Token = "0x401A5F5")]
		SCREEN_NAME033,
		// Token: 0x040090A4 RID: 37028
		[Token(Token = "0x401A5F6")]
		SCREEN_NAME034,
		// Token: 0x040090A5 RID: 37029
		[Token(Token = "0x401A5F7")]
		SCREEN_NAME035,
		// Token: 0x040090A6 RID: 37030
		[Token(Token = "0x401A5F8")]
		SCREEN_NAME036,
		// Token: 0x040090A7 RID: 37031
		[Token(Token = "0x401A5F9")]
		SCREEN_NAME037,
		// Token: 0x040090A8 RID: 37032
		[Token(Token = "0x401A5FA")]
		SCREEN_NAME038,
		// Token: 0x040090A9 RID: 37033
		[Token(Token = "0x401A5FB")]
		SCREEN_NAME039,
		// Token: 0x040090AA RID: 37034
		[Token(Token = "0x401A5FC")]
		SCREEN_NAME040,
		// Token: 0x040090AB RID: 37035
		[Token(Token = "0x401A5FD")]
		SCREEN_NAME041,
		// Token: 0x040090AC RID: 37036
		[Token(Token = "0x401A5FE")]
		SCREEN_NAME042,
		// Token: 0x040090AD RID: 37037
		[Token(Token = "0x401A5FF")]
		SCREEN_NAME043,
		// Token: 0x040090AE RID: 37038
		[Token(Token = "0x401A600")]
		SCREEN_NAME044,
		// Token: 0x040090AF RID: 37039
		[Token(Token = "0x401A601")]
		SCREEN_NAME045,
		// Token: 0x040090B0 RID: 37040
		[Token(Token = "0x401A602")]
		SCREEN_NAME101,
		// Token: 0x040090B1 RID: 37041
		[Token(Token = "0x401A603")]
		SCREEN_NAME102,
		// Token: 0x040090B2 RID: 37042
		[Token(Token = "0x401A604")]
		SCREEN_NAME103,
		// Token: 0x040090B3 RID: 37043
		[Token(Token = "0x401A605")]
		SCREEN_NAME104,
		// Token: 0x040090B4 RID: 37044
		[Token(Token = "0x401A606")]
		SCREEN_NAME105,
		// Token: 0x040090B5 RID: 37045
		[Token(Token = "0x401A607")]
		SCREEN_NAME106,
		// Token: 0x040090B6 RID: 37046
		[Token(Token = "0x401A608")]
		SCREEN_NAME107,
		// Token: 0x040090B7 RID: 37047
		[Token(Token = "0x401A609")]
		SCREEN_NAME108,
		// Token: 0x040090B8 RID: 37048
		[Token(Token = "0x401A60A")]
		SCREEN_NAME109,
		// Token: 0x040090B9 RID: 37049
		[Token(Token = "0x401A60B")]
		SCREEN_NAME110,
		// Token: 0x040090BA RID: 37050
		[Token(Token = "0x401A60C")]
		SCREEN_NAME111,
		// Token: 0x040090BB RID: 37051
		[Token(Token = "0x401A60D")]
		SCREEN_NAME112,
		// Token: 0x040090BC RID: 37052
		[Token(Token = "0x401A60E")]
		SCREEN_NAME113,
		// Token: 0x040090BD RID: 37053
		[Token(Token = "0x401A60F")]
		SCREEN_NAME114,
		// Token: 0x040090BE RID: 37054
		[Token(Token = "0x401A610")]
		SCREEN_NAME115,
		// Token: 0x040090BF RID: 37055
		[Token(Token = "0x401A611")]
		SCREEN_NAME116,
		// Token: 0x040090C0 RID: 37056
		[Token(Token = "0x401A612")]
		SCREEN_NAME117,
		// Token: 0x040090C1 RID: 37057
		[Token(Token = "0x401A613")]
		SCREEN_NAME118,
		// Token: 0x040090C2 RID: 37058
		[Token(Token = "0x401A614")]
		SCREEN_NAME119,
		// Token: 0x040090C3 RID: 37059
		[Token(Token = "0x401A615")]
		SCREEN_NAME120,
		// Token: 0x040090C4 RID: 37060
		[Token(Token = "0x401A616")]
		SCREEN_NAME121,
		// Token: 0x040090C5 RID: 37061
		[Token(Token = "0x401A617")]
		SCREEN_NAME122,
		// Token: 0x040090C6 RID: 37062
		[Token(Token = "0x401A618")]
		SCREEN_NAME123,
		// Token: 0x040090C7 RID: 37063
		[Token(Token = "0x401A619")]
		SCREEN_NAME124,
		// Token: 0x040090C8 RID: 37064
		[Token(Token = "0x401A61A")]
		SCREEN_NAME125,
		// Token: 0x040090C9 RID: 37065
		[Token(Token = "0x401A61B")]
		SCREEN_NAME126,
		// Token: 0x040090CA RID: 37066
		[Token(Token = "0x401A61C")]
		SCREEN_NAME127,
		// Token: 0x040090CB RID: 37067
		[Token(Token = "0x401A61D")]
		SCREEN_NAME128,
		// Token: 0x040090CC RID: 37068
		[Token(Token = "0x401A61E")]
		SCREEN_NAME129,
		// Token: 0x040090CD RID: 37069
		[Token(Token = "0x401A61F")]
		SCREEN_NAME130,
		// Token: 0x040090CE RID: 37070
		[Token(Token = "0x401A620")]
		SCREEN_NAME131,
		// Token: 0x040090CF RID: 37071
		[Token(Token = "0x401A621")]
		SCREEN_NAME132,
		// Token: 0x040090D0 RID: 37072
		[Token(Token = "0x401A622")]
		SCREEN_NAME133,
		// Token: 0x040090D1 RID: 37073
		[Token(Token = "0x401A623")]
		SCREEN_NAME134,
		// Token: 0x040090D2 RID: 37074
		[Token(Token = "0x401A624")]
		SCREEN_NAME135,
		// Token: 0x040090D3 RID: 37075
		[Token(Token = "0x401A625")]
		SCREEN_NAME136,
		// Token: 0x040090D4 RID: 37076
		[Token(Token = "0x401A626")]
		SCREEN_NAME137,
		// Token: 0x040090D5 RID: 37077
		[Token(Token = "0x401A627")]
		SCREEN_NAME138,
		// Token: 0x040090D6 RID: 37078
		[Token(Token = "0x401A628")]
		SCREEN_NAME139,
		// Token: 0x040090D7 RID: 37079
		[Token(Token = "0x401A629")]
		SCREEN_NAME140,
		// Token: 0x040090D8 RID: 37080
		[Token(Token = "0x401A62A")]
		SCREEN_NAME141,
		// Token: 0x040090D9 RID: 37081
		[Token(Token = "0x401A62B")]
		SCREEN_NAME142,
		// Token: 0x040090DA RID: 37082
		[Token(Token = "0x401A62C")]
		SCREEN_NAME143,
		// Token: 0x040090DB RID: 37083
		[Token(Token = "0x401A62D")]
		SCREEN_NAME144,
		// Token: 0x040090DC RID: 37084
		[Token(Token = "0x401A62E")]
		SCREEN_NAME145,
		// Token: 0x040090DD RID: 37085
		[Token(Token = "0x401A62F")]
		SCREEN_NAME146,
		// Token: 0x040090DE RID: 37086
		[Token(Token = "0x401A630")]
		SCREEN_NAME147,
		// Token: 0x040090DF RID: 37087
		[Token(Token = "0x401A631")]
		SCREEN_NAME148,
		// Token: 0x040090E0 RID: 37088
		[Token(Token = "0x401A632")]
		SCREEN_NAME149,
		// Token: 0x040090E1 RID: 37089
		[Token(Token = "0x401A633")]
		SCREEN_NAME150,
		// Token: 0x040090E2 RID: 37090
		[Token(Token = "0x401A634")]
		SCREEN_NAME151,
		// Token: 0x040090E3 RID: 37091
		[Token(Token = "0x401A635")]
		SCREEN_NAME152,
		// Token: 0x040090E4 RID: 37092
		[Token(Token = "0x401A636")]
		SCREEN_NAME153,
		// Token: 0x040090E5 RID: 37093
		[Token(Token = "0x401A637")]
		SCREEN_NAME154,
		// Token: 0x040090E6 RID: 37094
		[Token(Token = "0x401A638")]
		SCREEN_NAME155,
		// Token: 0x040090E7 RID: 37095
		[Token(Token = "0x401A639")]
		SCREEN_NAME156,
		// Token: 0x040090E8 RID: 37096
		[Token(Token = "0x401A63A")]
		SCREEN_NAME157,
		// Token: 0x040090E9 RID: 37097
		[Token(Token = "0x401A63B")]
		SCREEN_NAME158,
		// Token: 0x040090EA RID: 37098
		[Token(Token = "0x401A63C")]
		SCREEN_NAME159,
		// Token: 0x040090EB RID: 37099
		[Token(Token = "0x401A63D")]
		SCREEN_NAME160,
		// Token: 0x040090EC RID: 37100
		[Token(Token = "0x401A63E")]
		SCREEN_NAME161,
		// Token: 0x040090ED RID: 37101
		[Token(Token = "0x401A63F")]
		SCREEN_NAME162,
		// Token: 0x040090EE RID: 37102
		[Token(Token = "0x401A640")]
		ORDER_NAME_56001 = 103000,
		// Token: 0x040090EF RID: 37103
		[Token(Token = "0x401A641")]
		ORDER_NAME_56002,
		// Token: 0x040090F0 RID: 37104
		[Token(Token = "0x401A642")]
		ORDER_NAME_56003,
		// Token: 0x040090F1 RID: 37105
		[Token(Token = "0x401A643")]
		ORDER_NAME_56004,
		// Token: 0x040090F2 RID: 37106
		[Token(Token = "0x401A644")]
		ORDER_NAME_56005,
		// Token: 0x040090F3 RID: 37107
		[Token(Token = "0x401A645")]
		ORDER_NAME_56006,
		// Token: 0x040090F4 RID: 37108
		[Token(Token = "0x401A646")]
		ORDER_NAME_56007,
		// Token: 0x040090F5 RID: 37109
		[Token(Token = "0x401A647")]
		ORDER_NAME_56008,
		// Token: 0x040090F6 RID: 37110
		[Token(Token = "0x401A648")]
		ORDER_NAME_56009,
		// Token: 0x040090F7 RID: 37111
		[Token(Token = "0x401A649")]
		ORDER_NAME_56010,
		// Token: 0x040090F8 RID: 37112
		[Token(Token = "0x401A64A")]
		ORDER_NAME_56011,
		// Token: 0x040090F9 RID: 37113
		[Token(Token = "0x401A64B")]
		ORDER_NAME_56012,
		// Token: 0x040090FA RID: 37114
		[Token(Token = "0x401A64C")]
		ORDER_NAME_56013,
		// Token: 0x040090FB RID: 37115
		[Token(Token = "0x401A64D")]
		ORDER_NAME_56014,
		// Token: 0x040090FC RID: 37116
		[Token(Token = "0x401A64E")]
		ORDER_NAME_56015,
		// Token: 0x040090FD RID: 37117
		[Token(Token = "0x401A64F")]
		ORDER_NAME_56016,
		// Token: 0x040090FE RID: 37118
		[Token(Token = "0x401A650")]
		ORDER_NAME_56017,
		// Token: 0x040090FF RID: 37119
		[Token(Token = "0x401A651")]
		ORDER_NAME_56018,
		// Token: 0x04009100 RID: 37120
		[Token(Token = "0x401A652")]
		ORDER_NAME_56019,
		// Token: 0x04009101 RID: 37121
		[Token(Token = "0x401A653")]
		ORDER_NAME_56020,
		// Token: 0x04009102 RID: 37122
		[Token(Token = "0x401A654")]
		ORDER_NAME_56021,
		// Token: 0x04009103 RID: 37123
		[Token(Token = "0x401A655")]
		ORDER_NAME_56022,
		// Token: 0x04009104 RID: 37124
		[Token(Token = "0x401A656")]
		ORDER_NAME_56023,
		// Token: 0x04009105 RID: 37125
		[Token(Token = "0x401A657")]
		ORDER_NAME_56024,
		// Token: 0x04009106 RID: 37126
		[Token(Token = "0x401A658")]
		ORDER_NAME_56025,
		// Token: 0x04009107 RID: 37127
		[Token(Token = "0x401A659")]
		ORDER_NAME_56026,
		// Token: 0x04009108 RID: 37128
		[Token(Token = "0x401A65A")]
		ORDER_NAME_56027,
		// Token: 0x04009109 RID: 37129
		[Token(Token = "0x401A65B")]
		ORDER_NAME_56028,
		// Token: 0x0400910A RID: 37130
		[Token(Token = "0x401A65C")]
		ORDER_NAME_56029,
		// Token: 0x0400910B RID: 37131
		[Token(Token = "0x401A65D")]
		ORDER_NAME_56030,
		// Token: 0x0400910C RID: 37132
		[Token(Token = "0x401A65E")]
		ORDER_NAME_56031,
		// Token: 0x0400910D RID: 37133
		[Token(Token = "0x401A65F")]
		ORDER_NAME_56032,
		// Token: 0x0400910E RID: 37134
		[Token(Token = "0x401A660")]
		ORDER_NAME_56033,
		// Token: 0x0400910F RID: 37135
		[Token(Token = "0x401A661")]
		ORDER_NAME_56034,
		// Token: 0x04009110 RID: 37136
		[Token(Token = "0x401A662")]
		ORDER_NAME_56035,
		// Token: 0x04009111 RID: 37137
		[Token(Token = "0x401A663")]
		ORDER_NAME_56036,
		// Token: 0x04009112 RID: 37138
		[Token(Token = "0x401A664")]
		ORDER_NAME_56037,
		// Token: 0x04009113 RID: 37139
		[Token(Token = "0x401A665")]
		ORDER_NAME_56038,
		// Token: 0x04009114 RID: 37140
		[Token(Token = "0x401A666")]
		ORDER_NAME_56039,
		// Token: 0x04009115 RID: 37141
		[Token(Token = "0x401A667")]
		ORDER_NAME_56040,
		// Token: 0x04009116 RID: 37142
		[Token(Token = "0x401A668")]
		ORDER_NAME_56041,
		// Token: 0x04009117 RID: 37143
		[Token(Token = "0x401A669")]
		ORDER_NAME_56042,
		// Token: 0x04009118 RID: 37144
		[Token(Token = "0x401A66A")]
		ORDER_NAME_56043,
		// Token: 0x04009119 RID: 37145
		[Token(Token = "0x401A66B")]
		ORDER_NAME_56044,
		// Token: 0x0400911A RID: 37146
		[Token(Token = "0x401A66C")]
		ORDER_NAME_56045,
		// Token: 0x0400911B RID: 37147
		[Token(Token = "0x401A66D")]
		ORDER_NAME_56046,
		// Token: 0x0400911C RID: 37148
		[Token(Token = "0x401A66E")]
		ORDER_NAME_56047,
		// Token: 0x0400911D RID: 37149
		[Token(Token = "0x401A66F")]
		ORDER_NAME_56048,
		// Token: 0x0400911E RID: 37150
		[Token(Token = "0x401A670")]
		ORDER_NAME_56049,
		// Token: 0x0400911F RID: 37151
		[Token(Token = "0x401A671")]
		ORDER_NAME_56050,
		// Token: 0x04009120 RID: 37152
		[Token(Token = "0x401A672")]
		ORDER_NAME_56051,
		// Token: 0x04009121 RID: 37153
		[Token(Token = "0x401A673")]
		ORDER_NAME_56052,
		// Token: 0x04009122 RID: 37154
		[Token(Token = "0x401A674")]
		ORDER_NAME_56053,
		// Token: 0x04009123 RID: 37155
		[Token(Token = "0x401A675")]
		ORDER_NAME_56054,
		// Token: 0x04009124 RID: 37156
		[Token(Token = "0x401A676")]
		ORDER_NAME_56055,
		// Token: 0x04009125 RID: 37157
		[Token(Token = "0x401A677")]
		ORDER_NAME_56056,
		// Token: 0x04009126 RID: 37158
		[Token(Token = "0x401A678")]
		ORDER_NAME_56057,
		// Token: 0x04009127 RID: 37159
		[Token(Token = "0x401A679")]
		ORDER_NAME_56058,
		// Token: 0x04009128 RID: 37160
		[Token(Token = "0x401A67A")]
		ORDER_NAME_56059,
		// Token: 0x04009129 RID: 37161
		[Token(Token = "0x401A67B")]
		ORDER_NAME_56060,
		// Token: 0x0400912A RID: 37162
		[Token(Token = "0x401A67C")]
		ORDER_NAME_56061,
		// Token: 0x0400912B RID: 37163
		[Token(Token = "0x401A67D")]
		ORDER_NAME_56062,
		// Token: 0x0400912C RID: 37164
		[Token(Token = "0x401A67E")]
		ORDER_NAME_56063,
		// Token: 0x0400912D RID: 37165
		[Token(Token = "0x401A67F")]
		ORDER_NAME_56064,
		// Token: 0x0400912E RID: 37166
		[Token(Token = "0x401A680")]
		ORDER_NAME_56065,
		// Token: 0x0400912F RID: 37167
		[Token(Token = "0x401A681")]
		ORDER_NAME_56066,
		// Token: 0x04009130 RID: 37168
		[Token(Token = "0x401A682")]
		ORDER_NAME_56067,
		// Token: 0x04009131 RID: 37169
		[Token(Token = "0x401A683")]
		ORDER_NAME_56068,
		// Token: 0x04009132 RID: 37170
		[Token(Token = "0x401A684")]
		ORDER_NAME_56069,
		// Token: 0x04009133 RID: 37171
		[Token(Token = "0x401A685")]
		ORDER_NAME_56070,
		// Token: 0x04009134 RID: 37172
		[Token(Token = "0x401A686")]
		ORDER_NAME_56071,
		// Token: 0x04009135 RID: 37173
		[Token(Token = "0x401A687")]
		ORDER_NAME_56072,
		// Token: 0x04009136 RID: 37174
		[Token(Token = "0x401A688")]
		ORDER_NAME_56073,
		// Token: 0x04009137 RID: 37175
		[Token(Token = "0x401A689")]
		ORDER_NAME_56074,
		// Token: 0x04009138 RID: 37176
		[Token(Token = "0x401A68A")]
		ORDER_NAME_56075,
		// Token: 0x04009139 RID: 37177
		[Token(Token = "0x401A68B")]
		ORDER_NAME_56076,
		// Token: 0x0400913A RID: 37178
		[Token(Token = "0x401A68C")]
		ORDER_NAME_56077,
		// Token: 0x0400913B RID: 37179
		[Token(Token = "0x401A68D")]
		ORDER_NAME_56078,
		// Token: 0x0400913C RID: 37180
		[Token(Token = "0x401A68E")]
		ORDER_NAME_56079,
		// Token: 0x0400913D RID: 37181
		[Token(Token = "0x401A68F")]
		ORDER_NAME_56080,
		// Token: 0x0400913E RID: 37182
		[Token(Token = "0x401A690")]
		ORDER_NAME_56081,
		// Token: 0x0400913F RID: 37183
		[Token(Token = "0x401A691")]
		ORDER_NAME_56083,
		// Token: 0x04009140 RID: 37184
		[Token(Token = "0x401A692")]
		ORDER_NAME_56084,
		// Token: 0x04009141 RID: 37185
		[Token(Token = "0x401A693")]
		ORDER_NAME_56085,
		// Token: 0x04009142 RID: 37186
		[Token(Token = "0x401A694")]
		ORDER_NAME_56086,
		// Token: 0x04009143 RID: 37187
		[Token(Token = "0x401A695")]
		ORDER_NAME_56087,
		// Token: 0x04009144 RID: 37188
		[Token(Token = "0x401A696")]
		ORDER_NAME_56088,
		// Token: 0x04009145 RID: 37189
		[Token(Token = "0x401A697")]
		ORDER_NAME_56089,
		// Token: 0x04009146 RID: 37190
		[Token(Token = "0x401A698")]
		ORDER_NAME_56090,
		// Token: 0x04009147 RID: 37191
		[Token(Token = "0x401A699")]
		ORDER_NAME_56091,
		// Token: 0x04009148 RID: 37192
		[Token(Token = "0x401A69A")]
		ORDER_NAME_56092,
		// Token: 0x04009149 RID: 37193
		[Token(Token = "0x401A69B")]
		ORDER_NAME_56093,
		// Token: 0x0400914A RID: 37194
		[Token(Token = "0x401A69C")]
		ORDER_NAME_RAN_10,
		// Token: 0x0400914B RID: 37195
		[Token(Token = "0x401A69D")]
		ORDER_NAME_RAN_20,
		// Token: 0x0400914C RID: 37196
		[Token(Token = "0x401A69E")]
		ORDER_NAME_RAN_30,
		// Token: 0x0400914D RID: 37197
		[Token(Token = "0x401A69F")]
		ORDER_NAME_RAN_40,
		// Token: 0x0400914E RID: 37198
		[Token(Token = "0x401A6A0")]
		ORDER_NAME_02001,
		// Token: 0x0400914F RID: 37199
		[Token(Token = "0x401A6A1")]
		ORDER_NAME_02002,
		// Token: 0x04009150 RID: 37200
		[Token(Token = "0x401A6A2")]
		ORDER_NAME_02003,
		// Token: 0x04009151 RID: 37201
		[Token(Token = "0x401A6A3")]
		ORDER_NAME_02004,
		// Token: 0x04009152 RID: 37202
		[Token(Token = "0x401A6A4")]
		ORDER_NAME_02005,
		// Token: 0x04009153 RID: 37203
		[Token(Token = "0x401A6A5")]
		ORDER_NAME_02006,
		// Token: 0x04009154 RID: 37204
		[Token(Token = "0x401A6A6")]
		ORDER_NAME_02007,
		// Token: 0x04009155 RID: 37205
		[Token(Token = "0x401A6A7")]
		ORDER_NAME_02008,
		// Token: 0x04009156 RID: 37206
		[Token(Token = "0x401A6A8")]
		ORDER_NAME_02009,
		// Token: 0x04009157 RID: 37207
		[Token(Token = "0x401A6A9")]
		ORDER_NAME_03001,
		// Token: 0x04009158 RID: 37208
		[Token(Token = "0x401A6AA")]
		ORDER_NAME_03002,
		// Token: 0x04009159 RID: 37209
		[Token(Token = "0x401A6AB")]
		ORDER_NAME_03003,
		// Token: 0x0400915A RID: 37210
		[Token(Token = "0x401A6AC")]
		ORDER_NAME_03004,
		// Token: 0x0400915B RID: 37211
		[Token(Token = "0x401A6AD")]
		ORDER_NAME_03005,
		// Token: 0x0400915C RID: 37212
		[Token(Token = "0x401A6AE")]
		ORDER_NAME_03006,
		// Token: 0x0400915D RID: 37213
		[Token(Token = "0x401A6AF")]
		ORDER_NAME_03007,
		// Token: 0x0400915E RID: 37214
		[Token(Token = "0x401A6B0")]
		ORDER_NAME_03008,
		// Token: 0x0400915F RID: 37215
		[Token(Token = "0x401A6B1")]
		ORDER_NAME_03009,
		// Token: 0x04009160 RID: 37216
		[Token(Token = "0x401A6B2")]
		ORDER_NAME_04001,
		// Token: 0x04009161 RID: 37217
		[Token(Token = "0x401A6B3")]
		ORDER_NAME_04002,
		// Token: 0x04009162 RID: 37218
		[Token(Token = "0x401A6B4")]
		ORDER_NAME_04003,
		// Token: 0x04009163 RID: 37219
		[Token(Token = "0x401A6B5")]
		ORDER_NAME_04004,
		// Token: 0x04009164 RID: 37220
		[Token(Token = "0x401A6B6")]
		ORDER_NAME_04005,
		// Token: 0x04009165 RID: 37221
		[Token(Token = "0x401A6B7")]
		ORDER_NAME_04006,
		// Token: 0x04009166 RID: 37222
		[Token(Token = "0x401A6B8")]
		ORDER_NAME_04007,
		// Token: 0x04009167 RID: 37223
		[Token(Token = "0x401A6B9")]
		ORDER_NAME_04008,
		// Token: 0x04009168 RID: 37224
		[Token(Token = "0x401A6BA")]
		ORDER_NAME_04009,
		// Token: 0x04009169 RID: 37225
		[Token(Token = "0x401A6BB")]
		ORDER_NAME_05001,
		// Token: 0x0400916A RID: 37226
		[Token(Token = "0x401A6BC")]
		ORDER_NAME_05002,
		// Token: 0x0400916B RID: 37227
		[Token(Token = "0x401A6BD")]
		ORDER_NAME_05003,
		// Token: 0x0400916C RID: 37228
		[Token(Token = "0x401A6BE")]
		ORDER_NAME_05004,
		// Token: 0x0400916D RID: 37229
		[Token(Token = "0x401A6BF")]
		ORDER_NAME_05005,
		// Token: 0x0400916E RID: 37230
		[Token(Token = "0x401A6C0")]
		ORDER_NAME_05006,
		// Token: 0x0400916F RID: 37231
		[Token(Token = "0x401A6C1")]
		ORDER_NAME_05007,
		// Token: 0x04009170 RID: 37232
		[Token(Token = "0x401A6C2")]
		ORDER_NAME_05008,
		// Token: 0x04009171 RID: 37233
		[Token(Token = "0x401A6C3")]
		ORDER_NAME_05009,
		// Token: 0x04009172 RID: 37234
		[Token(Token = "0x401A6C4")]
		ORDER_NAME_06001,
		// Token: 0x04009173 RID: 37235
		[Token(Token = "0x401A6C5")]
		ORDER_NAME_06002,
		// Token: 0x04009174 RID: 37236
		[Token(Token = "0x401A6C6")]
		ORDER_NAME_06003,
		// Token: 0x04009175 RID: 37237
		[Token(Token = "0x401A6C7")]
		ORDER_NAME_06004,
		// Token: 0x04009176 RID: 37238
		[Token(Token = "0x401A6C8")]
		ORDER_NAME_06005,
		// Token: 0x04009177 RID: 37239
		[Token(Token = "0x401A6C9")]
		ORDER_NAME_06006,
		// Token: 0x04009178 RID: 37240
		[Token(Token = "0x401A6CA")]
		ORDER_NAME_06007,
		// Token: 0x04009179 RID: 37241
		[Token(Token = "0x401A6CB")]
		ORDER_NAME_06008,
		// Token: 0x0400917A RID: 37242
		[Token(Token = "0x401A6CC")]
		ORDER_NAME_06009,
		// Token: 0x0400917B RID: 37243
		[Token(Token = "0x401A6CD")]
		ORDER_NAME_07001,
		// Token: 0x0400917C RID: 37244
		[Token(Token = "0x401A6CE")]
		ORDER_NAME_07002,
		// Token: 0x0400917D RID: 37245
		[Token(Token = "0x401A6CF")]
		ORDER_NAME_07003,
		// Token: 0x0400917E RID: 37246
		[Token(Token = "0x401A6D0")]
		ORDER_NAME_07004,
		// Token: 0x0400917F RID: 37247
		[Token(Token = "0x401A6D1")]
		ORDER_NAME_07005,
		// Token: 0x04009180 RID: 37248
		[Token(Token = "0x401A6D2")]
		ORDER_NAME_07006,
		// Token: 0x04009181 RID: 37249
		[Token(Token = "0x401A6D3")]
		ORDER_NAME_07007,
		// Token: 0x04009182 RID: 37250
		[Token(Token = "0x401A6D4")]
		ORDER_NAME_07008,
		// Token: 0x04009183 RID: 37251
		[Token(Token = "0x401A6D5")]
		ORDER_NAME_07009,
		// Token: 0x04009184 RID: 37252
		[Token(Token = "0x401A6D6")]
		ORDER_NAME_08001,
		// Token: 0x04009185 RID: 37253
		[Token(Token = "0x401A6D7")]
		ORDER_NAME_08002,
		// Token: 0x04009186 RID: 37254
		[Token(Token = "0x401A6D8")]
		ORDER_NAME_08003,
		// Token: 0x04009187 RID: 37255
		[Token(Token = "0x401A6D9")]
		ORDER_NAME_08004,
		// Token: 0x04009188 RID: 37256
		[Token(Token = "0x401A6DA")]
		ORDER_NAME_08005,
		// Token: 0x04009189 RID: 37257
		[Token(Token = "0x401A6DB")]
		ORDER_NAME_08006,
		// Token: 0x0400918A RID: 37258
		[Token(Token = "0x401A6DC")]
		ORDER_NAME_08007,
		// Token: 0x0400918B RID: 37259
		[Token(Token = "0x401A6DD")]
		ORDER_NAME_08008,
		// Token: 0x0400918C RID: 37260
		[Token(Token = "0x401A6DE")]
		ORDER_NAME_08009,
		// Token: 0x0400918D RID: 37261
		[Token(Token = "0x401A6DF")]
		ORDER_NAME_09001,
		// Token: 0x0400918E RID: 37262
		[Token(Token = "0x401A6E0")]
		ORDER_NAME_09002,
		// Token: 0x0400918F RID: 37263
		[Token(Token = "0x401A6E1")]
		ORDER_NAME_09003,
		// Token: 0x04009190 RID: 37264
		[Token(Token = "0x401A6E2")]
		ORDER_NAME_09004,
		// Token: 0x04009191 RID: 37265
		[Token(Token = "0x401A6E3")]
		ORDER_NAME_09005,
		// Token: 0x04009192 RID: 37266
		[Token(Token = "0x401A6E4")]
		ORDER_NAME_09006,
		// Token: 0x04009193 RID: 37267
		[Token(Token = "0x401A6E5")]
		ORDER_NAME_09007,
		// Token: 0x04009194 RID: 37268
		[Token(Token = "0x401A6E6")]
		ORDER_NAME_09008,
		// Token: 0x04009195 RID: 37269
		[Token(Token = "0x401A6E7")]
		ORDER_NAME_09009,
		// Token: 0x04009196 RID: 37270
		[Token(Token = "0x401A6E8")]
		ORDER_NAME_10001,
		// Token: 0x04009197 RID: 37271
		[Token(Token = "0x401A6E9")]
		ORDER_NAME_10002,
		// Token: 0x04009198 RID: 37272
		[Token(Token = "0x401A6EA")]
		ORDER_NAME_10003,
		// Token: 0x04009199 RID: 37273
		[Token(Token = "0x401A6EB")]
		ORDER_NAME_10004,
		// Token: 0x0400919A RID: 37274
		[Token(Token = "0x401A6EC")]
		ORDER_NAME_10005,
		// Token: 0x0400919B RID: 37275
		[Token(Token = "0x401A6ED")]
		ORDER_NAME_10006,
		// Token: 0x0400919C RID: 37276
		[Token(Token = "0x401A6EE")]
		ORDER_NAME_10007,
		// Token: 0x0400919D RID: 37277
		[Token(Token = "0x401A6EF")]
		ORDER_NAME_10008,
		// Token: 0x0400919E RID: 37278
		[Token(Token = "0x401A6F0")]
		ORDER_NAME_10009,
		// Token: 0x0400919F RID: 37279
		[Token(Token = "0x401A6F1")]
		ORDER_NAME_11001,
		// Token: 0x040091A0 RID: 37280
		[Token(Token = "0x401A6F2")]
		ORDER_NAME_11002,
		// Token: 0x040091A1 RID: 37281
		[Token(Token = "0x401A6F3")]
		ORDER_NAME_11003,
		// Token: 0x040091A2 RID: 37282
		[Token(Token = "0x401A6F4")]
		ORDER_NAME_11004,
		// Token: 0x040091A3 RID: 37283
		[Token(Token = "0x401A6F5")]
		ORDER_NAME_11005,
		// Token: 0x040091A4 RID: 37284
		[Token(Token = "0x401A6F6")]
		ORDER_NAME_11006,
		// Token: 0x040091A5 RID: 37285
		[Token(Token = "0x401A6F7")]
		ORDER_NAME_11007,
		// Token: 0x040091A6 RID: 37286
		[Token(Token = "0x401A6F8")]
		ORDER_NAME_11008,
		// Token: 0x040091A7 RID: 37287
		[Token(Token = "0x401A6F9")]
		ORDER_NAME_11009,
		// Token: 0x040091A8 RID: 37288
		[Token(Token = "0x401A6FA")]
		ORDER_NAME_12001,
		// Token: 0x040091A9 RID: 37289
		[Token(Token = "0x401A6FB")]
		ORDER_NAME_12002,
		// Token: 0x040091AA RID: 37290
		[Token(Token = "0x401A6FC")]
		ORDER_NAME_12003,
		// Token: 0x040091AB RID: 37291
		[Token(Token = "0x401A6FD")]
		ORDER_NAME_12004,
		// Token: 0x040091AC RID: 37292
		[Token(Token = "0x401A6FE")]
		ORDER_NAME_12005,
		// Token: 0x040091AD RID: 37293
		[Token(Token = "0x401A6FF")]
		ORDER_NAME_12006,
		// Token: 0x040091AE RID: 37294
		[Token(Token = "0x401A700")]
		ORDER_NAME_12007,
		// Token: 0x040091AF RID: 37295
		[Token(Token = "0x401A701")]
		ORDER_NAME_12008,
		// Token: 0x040091B0 RID: 37296
		[Token(Token = "0x401A702")]
		ORDER_NAME_12009,
		// Token: 0x040091B1 RID: 37297
		[Token(Token = "0x401A703")]
		ORDER_NAME_13001,
		// Token: 0x040091B2 RID: 37298
		[Token(Token = "0x401A704")]
		ORDER_NAME_13002,
		// Token: 0x040091B3 RID: 37299
		[Token(Token = "0x401A705")]
		ORDER_NAME_13003,
		// Token: 0x040091B4 RID: 37300
		[Token(Token = "0x401A706")]
		ORDER_NAME_13004,
		// Token: 0x040091B5 RID: 37301
		[Token(Token = "0x401A707")]
		ORDER_NAME_13005,
		// Token: 0x040091B6 RID: 37302
		[Token(Token = "0x401A708")]
		ORDER_NAME_13006,
		// Token: 0x040091B7 RID: 37303
		[Token(Token = "0x401A709")]
		ORDER_NAME_14001,
		// Token: 0x040091B8 RID: 37304
		[Token(Token = "0x401A70A")]
		ORDER_NAME_14002,
		// Token: 0x040091B9 RID: 37305
		[Token(Token = "0x401A70B")]
		ORDER_NAME_14003,
		// Token: 0x040091BA RID: 37306
		[Token(Token = "0x401A70C")]
		ORDER_NAME_14004,
		// Token: 0x040091BB RID: 37307
		[Token(Token = "0x401A70D")]
		ORDER_NAME_14005,
		// Token: 0x040091BC RID: 37308
		[Token(Token = "0x401A70E")]
		ORDER_NAME_14006,
		// Token: 0x040091BD RID: 37309
		[Token(Token = "0x401A70F")]
		ORDER_NAME_15001,
		// Token: 0x040091BE RID: 37310
		[Token(Token = "0x401A710")]
		ORDER_NAME_15002,
		// Token: 0x040091BF RID: 37311
		[Token(Token = "0x401A711")]
		ORDER_NAME_15003,
		// Token: 0x040091C0 RID: 37312
		[Token(Token = "0x401A712")]
		ORDER_NAME_15004,
		// Token: 0x040091C1 RID: 37313
		[Token(Token = "0x401A713")]
		ORDER_NAME_15005,
		// Token: 0x040091C2 RID: 37314
		[Token(Token = "0x401A714")]
		ORDER_NAME_15006,
		// Token: 0x040091C3 RID: 37315
		[Token(Token = "0x401A715")]
		ORDER_NAME_16001,
		// Token: 0x040091C4 RID: 37316
		[Token(Token = "0x401A716")]
		ORDER_NAME_16002,
		// Token: 0x040091C5 RID: 37317
		[Token(Token = "0x401A717")]
		ORDER_NAME_16003,
		// Token: 0x040091C6 RID: 37318
		[Token(Token = "0x401A718")]
		ORDER_NAME_16004,
		// Token: 0x040091C7 RID: 37319
		[Token(Token = "0x401A719")]
		ORDER_NAME_16005,
		// Token: 0x040091C8 RID: 37320
		[Token(Token = "0x401A71A")]
		ORDER_NAME_16006,
		// Token: 0x040091C9 RID: 37321
		[Token(Token = "0x401A71B")]
		ORDER_NAME_17001,
		// Token: 0x040091CA RID: 37322
		[Token(Token = "0x401A71C")]
		ORDER_NAME_17002,
		// Token: 0x040091CB RID: 37323
		[Token(Token = "0x401A71D")]
		ORDER_NAME_17003,
		// Token: 0x040091CC RID: 37324
		[Token(Token = "0x401A71E")]
		ORDER_NAME_17004,
		// Token: 0x040091CD RID: 37325
		[Token(Token = "0x401A71F")]
		ORDER_NAME_17005,
		// Token: 0x040091CE RID: 37326
		[Token(Token = "0x401A720")]
		ORDER_NAME_17006,
		// Token: 0x040091CF RID: 37327
		[Token(Token = "0x401A721")]
		ORDER_NAME_18001,
		// Token: 0x040091D0 RID: 37328
		[Token(Token = "0x401A722")]
		ORDER_NAME_18002,
		// Token: 0x040091D1 RID: 37329
		[Token(Token = "0x401A723")]
		ORDER_NAME_18003,
		// Token: 0x040091D2 RID: 37330
		[Token(Token = "0x401A724")]
		ORDER_NAME_18004,
		// Token: 0x040091D3 RID: 37331
		[Token(Token = "0x401A725")]
		ORDER_NAME_18005,
		// Token: 0x040091D4 RID: 37332
		[Token(Token = "0x401A726")]
		ORDER_NAME_18006,
		// Token: 0x040091D5 RID: 37333
		[Token(Token = "0x401A727")]
		ORDER_NAME_19001,
		// Token: 0x040091D6 RID: 37334
		[Token(Token = "0x401A728")]
		ORDER_NAME_19002,
		// Token: 0x040091D7 RID: 37335
		[Token(Token = "0x401A729")]
		ORDER_NAME_19003,
		// Token: 0x040091D8 RID: 37336
		[Token(Token = "0x401A72A")]
		ORDER_NAME_19004,
		// Token: 0x040091D9 RID: 37337
		[Token(Token = "0x401A72B")]
		ORDER_NAME_19005,
		// Token: 0x040091DA RID: 37338
		[Token(Token = "0x401A72C")]
		ORDER_NAME_19006,
		// Token: 0x040091DB RID: 37339
		[Token(Token = "0x401A72D")]
		ORDER_NAME_20001,
		// Token: 0x040091DC RID: 37340
		[Token(Token = "0x401A72E")]
		ORDER_NAME_20002,
		// Token: 0x040091DD RID: 37341
		[Token(Token = "0x401A72F")]
		ORDER_NAME_20003,
		// Token: 0x040091DE RID: 37342
		[Token(Token = "0x401A730")]
		ORDER_NAME_20004,
		// Token: 0x040091DF RID: 37343
		[Token(Token = "0x401A731")]
		ORDER_NAME_20005,
		// Token: 0x040091E0 RID: 37344
		[Token(Token = "0x401A732")]
		ORDER_NAME_20006,
		// Token: 0x040091E1 RID: 37345
		[Token(Token = "0x401A733")]
		ORDER_NAME_21001,
		// Token: 0x040091E2 RID: 37346
		[Token(Token = "0x401A734")]
		ORDER_NAME_21002,
		// Token: 0x040091E3 RID: 37347
		[Token(Token = "0x401A735")]
		ORDER_NAME_21003,
		// Token: 0x040091E4 RID: 37348
		[Token(Token = "0x401A736")]
		ORDER_NAME_21004,
		// Token: 0x040091E5 RID: 37349
		[Token(Token = "0x401A737")]
		ORDER_NAME_21005,
		// Token: 0x040091E6 RID: 37350
		[Token(Token = "0x401A738")]
		ORDER_NAME_21006,
		// Token: 0x040091E7 RID: 37351
		[Token(Token = "0x401A739")]
		ORDER_NAME_22001,
		// Token: 0x040091E8 RID: 37352
		[Token(Token = "0x401A73A")]
		ORDER_NAME_22002,
		// Token: 0x040091E9 RID: 37353
		[Token(Token = "0x401A73B")]
		ORDER_NAME_22003,
		// Token: 0x040091EA RID: 37354
		[Token(Token = "0x401A73C")]
		ORDER_NAME_22004,
		// Token: 0x040091EB RID: 37355
		[Token(Token = "0x401A73D")]
		ORDER_NAME_22005,
		// Token: 0x040091EC RID: 37356
		[Token(Token = "0x401A73E")]
		ORDER_NAME_22006,
		// Token: 0x040091ED RID: 37357
		[Token(Token = "0x401A73F")]
		ORDER_NAME_24001,
		// Token: 0x040091EE RID: 37358
		[Token(Token = "0x401A740")]
		ORDER_NAME_24002,
		// Token: 0x040091EF RID: 37359
		[Token(Token = "0x401A741")]
		ORDER_NAME_24003,
		// Token: 0x040091F0 RID: 37360
		[Token(Token = "0x401A742")]
		ORDER_NAME_24004,
		// Token: 0x040091F1 RID: 37361
		[Token(Token = "0x401A743")]
		ORDER_NAME_24005,
		// Token: 0x040091F2 RID: 37362
		[Token(Token = "0x401A744")]
		ORDER_NAME_24006,
		// Token: 0x040091F3 RID: 37363
		[Token(Token = "0x401A745")]
		ORDER_NAME_26001,
		// Token: 0x040091F4 RID: 37364
		[Token(Token = "0x401A746")]
		ORDER_NAME_26002,
		// Token: 0x040091F5 RID: 37365
		[Token(Token = "0x401A747")]
		ORDER_NAME_26003,
		// Token: 0x040091F6 RID: 37366
		[Token(Token = "0x401A748")]
		ORDER_NAME_26004,
		// Token: 0x040091F7 RID: 37367
		[Token(Token = "0x401A749")]
		ORDER_NAME_26005,
		// Token: 0x040091F8 RID: 37368
		[Token(Token = "0x401A74A")]
		ORDER_NAME_26006,
		// Token: 0x040091F9 RID: 37369
		[Token(Token = "0x401A74B")]
		ORDER_NAME_27001,
		// Token: 0x040091FA RID: 37370
		[Token(Token = "0x401A74C")]
		ORDER_NAME_27002,
		// Token: 0x040091FB RID: 37371
		[Token(Token = "0x401A74D")]
		ORDER_NAME_27003,
		// Token: 0x040091FC RID: 37372
		[Token(Token = "0x401A74E")]
		ORDER_NAME_27004,
		// Token: 0x040091FD RID: 37373
		[Token(Token = "0x401A74F")]
		ORDER_NAME_27005,
		// Token: 0x040091FE RID: 37374
		[Token(Token = "0x401A750")]
		ORDER_NAME_27006,
		// Token: 0x040091FF RID: 37375
		[Token(Token = "0x401A751")]
		ORDER_NAME_28001,
		// Token: 0x04009200 RID: 37376
		[Token(Token = "0x401A752")]
		ORDER_NAME_28002,
		// Token: 0x04009201 RID: 37377
		[Token(Token = "0x401A753")]
		ORDER_NAME_28003,
		// Token: 0x04009202 RID: 37378
		[Token(Token = "0x401A754")]
		ORDER_NAME_28004,
		// Token: 0x04009203 RID: 37379
		[Token(Token = "0x401A755")]
		ORDER_NAME_28005,
		// Token: 0x04009204 RID: 37380
		[Token(Token = "0x401A756")]
		ORDER_NAME_28006,
		// Token: 0x04009205 RID: 37381
		[Token(Token = "0x401A757")]
		ORDER_NAME_29010,
		// Token: 0x04009206 RID: 37382
		[Token(Token = "0x401A758")]
		ORDER_NAME_29011,
		// Token: 0x04009207 RID: 37383
		[Token(Token = "0x401A759")]
		ORDER_NAME_29012,
		// Token: 0x04009208 RID: 37384
		[Token(Token = "0x401A75A")]
		ORDER_NAME_29020,
		// Token: 0x04009209 RID: 37385
		[Token(Token = "0x401A75B")]
		ORDER_NAME_29021,
		// Token: 0x0400920A RID: 37386
		[Token(Token = "0x401A75C")]
		ORDER_NAME_29022,
		// Token: 0x0400920B RID: 37387
		[Token(Token = "0x401A75D")]
		ORDER_NAME_29030,
		// Token: 0x0400920C RID: 37388
		[Token(Token = "0x401A75E")]
		ORDER_NAME_29031,
		// Token: 0x0400920D RID: 37389
		[Token(Token = "0x401A75F")]
		ORDER_NAME_29032,
		// Token: 0x0400920E RID: 37390
		[Token(Token = "0x401A760")]
		ORDER_NAME_29040,
		// Token: 0x0400920F RID: 37391
		[Token(Token = "0x401A761")]
		ORDER_NAME_29041,
		// Token: 0x04009210 RID: 37392
		[Token(Token = "0x401A762")]
		ORDER_NAME_29042,
		// Token: 0x04009211 RID: 37393
		[Token(Token = "0x401A763")]
		ORDER_NAME_29050,
		// Token: 0x04009212 RID: 37394
		[Token(Token = "0x401A764")]
		ORDER_NAME_29051,
		// Token: 0x04009213 RID: 37395
		[Token(Token = "0x401A765")]
		ORDER_NAME_29052,
		// Token: 0x04009214 RID: 37396
		[Token(Token = "0x401A766")]
		ORDER_NAME_29060,
		// Token: 0x04009215 RID: 37397
		[Token(Token = "0x401A767")]
		ORDER_NAME_29061,
		// Token: 0x04009216 RID: 37398
		[Token(Token = "0x401A768")]
		ORDER_NAME_29062,
		// Token: 0x04009217 RID: 37399
		[Token(Token = "0x401A769")]
		ORDER_NAME_29110,
		// Token: 0x04009218 RID: 37400
		[Token(Token = "0x401A76A")]
		ORDER_NAME_29111,
		// Token: 0x04009219 RID: 37401
		[Token(Token = "0x401A76B")]
		ORDER_NAME_29112,
		// Token: 0x0400921A RID: 37402
		[Token(Token = "0x401A76C")]
		ORDER_NAME_29120,
		// Token: 0x0400921B RID: 37403
		[Token(Token = "0x401A76D")]
		ORDER_NAME_29121,
		// Token: 0x0400921C RID: 37404
		[Token(Token = "0x401A76E")]
		ORDER_NAME_29122,
		// Token: 0x0400921D RID: 37405
		[Token(Token = "0x401A76F")]
		ORDER_NAME_29130,
		// Token: 0x0400921E RID: 37406
		[Token(Token = "0x401A770")]
		ORDER_NAME_29131,
		// Token: 0x0400921F RID: 37407
		[Token(Token = "0x401A771")]
		ORDER_NAME_29132,
		// Token: 0x04009220 RID: 37408
		[Token(Token = "0x401A772")]
		ORDER_NAME_29140,
		// Token: 0x04009221 RID: 37409
		[Token(Token = "0x401A773")]
		ORDER_NAME_29141,
		// Token: 0x04009222 RID: 37410
		[Token(Token = "0x401A774")]
		ORDER_NAME_29142,
		// Token: 0x04009223 RID: 37411
		[Token(Token = "0x401A775")]
		ORDER_NAME_29150,
		// Token: 0x04009224 RID: 37412
		[Token(Token = "0x401A776")]
		ORDER_NAME_29151,
		// Token: 0x04009225 RID: 37413
		[Token(Token = "0x401A777")]
		ORDER_NAME_29152,
		// Token: 0x04009226 RID: 37414
		[Token(Token = "0x401A778")]
		ORDER_NAME_29160,
		// Token: 0x04009227 RID: 37415
		[Token(Token = "0x401A779")]
		ORDER_NAME_29161,
		// Token: 0x04009228 RID: 37416
		[Token(Token = "0x401A77A")]
		ORDER_NAME_29162,
		// Token: 0x04009229 RID: 37417
		[Token(Token = "0x401A77B")]
		ORDER_NAME_30010,
		// Token: 0x0400922A RID: 37418
		[Token(Token = "0x401A77C")]
		ORDER_NAME_30011,
		// Token: 0x0400922B RID: 37419
		[Token(Token = "0x401A77D")]
		ORDER_NAME_30012,
		// Token: 0x0400922C RID: 37420
		[Token(Token = "0x401A77E")]
		ORDER_NAME_30020,
		// Token: 0x0400922D RID: 37421
		[Token(Token = "0x401A77F")]
		ORDER_NAME_30021,
		// Token: 0x0400922E RID: 37422
		[Token(Token = "0x401A780")]
		ORDER_NAME_30022,
		// Token: 0x0400922F RID: 37423
		[Token(Token = "0x401A781")]
		ORDER_NAME_30030,
		// Token: 0x04009230 RID: 37424
		[Token(Token = "0x401A782")]
		ORDER_NAME_30031,
		// Token: 0x04009231 RID: 37425
		[Token(Token = "0x401A783")]
		ORDER_NAME_30032,
		// Token: 0x04009232 RID: 37426
		[Token(Token = "0x401A784")]
		ORDER_NAME_30040,
		// Token: 0x04009233 RID: 37427
		[Token(Token = "0x401A785")]
		ORDER_NAME_30041,
		// Token: 0x04009234 RID: 37428
		[Token(Token = "0x401A786")]
		ORDER_NAME_30042,
		// Token: 0x04009235 RID: 37429
		[Token(Token = "0x401A787")]
		ORDER_NAME_30050,
		// Token: 0x04009236 RID: 37430
		[Token(Token = "0x401A788")]
		ORDER_NAME_30051,
		// Token: 0x04009237 RID: 37431
		[Token(Token = "0x401A789")]
		ORDER_NAME_30052,
		// Token: 0x04009238 RID: 37432
		[Token(Token = "0x401A78A")]
		ORDER_NAME_30060,
		// Token: 0x04009239 RID: 37433
		[Token(Token = "0x401A78B")]
		ORDER_NAME_30061,
		// Token: 0x0400923A RID: 37434
		[Token(Token = "0x401A78C")]
		ORDER_NAME_30062,
		// Token: 0x0400923B RID: 37435
		[Token(Token = "0x401A78D")]
		ORDER_NAME_31010,
		// Token: 0x0400923C RID: 37436
		[Token(Token = "0x401A78E")]
		ORDER_NAME_31011,
		// Token: 0x0400923D RID: 37437
		[Token(Token = "0x401A78F")]
		ORDER_NAME_31012,
		// Token: 0x0400923E RID: 37438
		[Token(Token = "0x401A790")]
		ORDER_NAME_31020,
		// Token: 0x0400923F RID: 37439
		[Token(Token = "0x401A791")]
		ORDER_NAME_31021,
		// Token: 0x04009240 RID: 37440
		[Token(Token = "0x401A792")]
		ORDER_NAME_31022,
		// Token: 0x04009241 RID: 37441
		[Token(Token = "0x401A793")]
		ORDER_NAME_31030,
		// Token: 0x04009242 RID: 37442
		[Token(Token = "0x401A794")]
		ORDER_NAME_31031,
		// Token: 0x04009243 RID: 37443
		[Token(Token = "0x401A795")]
		ORDER_NAME_31032,
		// Token: 0x04009244 RID: 37444
		[Token(Token = "0x401A796")]
		ORDER_NAME_31040,
		// Token: 0x04009245 RID: 37445
		[Token(Token = "0x401A797")]
		ORDER_NAME_31041,
		// Token: 0x04009246 RID: 37446
		[Token(Token = "0x401A798")]
		ORDER_NAME_31042,
		// Token: 0x04009247 RID: 37447
		[Token(Token = "0x401A799")]
		ORDER_NAME_31050,
		// Token: 0x04009248 RID: 37448
		[Token(Token = "0x401A79A")]
		ORDER_NAME_31051,
		// Token: 0x04009249 RID: 37449
		[Token(Token = "0x401A79B")]
		ORDER_NAME_31052,
		// Token: 0x0400924A RID: 37450
		[Token(Token = "0x401A79C")]
		ORDER_NAME_31060,
		// Token: 0x0400924B RID: 37451
		[Token(Token = "0x401A79D")]
		ORDER_NAME_31061,
		// Token: 0x0400924C RID: 37452
		[Token(Token = "0x401A79E")]
		ORDER_NAME_31062,
		// Token: 0x0400924D RID: 37453
		[Token(Token = "0x401A79F")]
		ORDER_NAME_32001,
		// Token: 0x0400924E RID: 37454
		[Token(Token = "0x401A7A0")]
		ORDER_NAME_32002,
		// Token: 0x0400924F RID: 37455
		[Token(Token = "0x401A7A1")]
		ORDER_NAME_32003,
		// Token: 0x04009250 RID: 37456
		[Token(Token = "0x401A7A2")]
		ORDER_NAME_32004,
		// Token: 0x04009251 RID: 37457
		[Token(Token = "0x401A7A3")]
		ORDER_NAME_32005,
		// Token: 0x04009252 RID: 37458
		[Token(Token = "0x401A7A4")]
		ORDER_NAME_32006,
		// Token: 0x04009253 RID: 37459
		[Token(Token = "0x401A7A5")]
		ORDER_NAME_33001,
		// Token: 0x04009254 RID: 37460
		[Token(Token = "0x401A7A6")]
		ORDER_NAME_33002,
		// Token: 0x04009255 RID: 37461
		[Token(Token = "0x401A7A7")]
		ORDER_NAME_33003,
		// Token: 0x04009256 RID: 37462
		[Token(Token = "0x401A7A8")]
		ORDER_NAME_33004,
		// Token: 0x04009257 RID: 37463
		[Token(Token = "0x401A7A9")]
		ORDER_NAME_33005,
		// Token: 0x04009258 RID: 37464
		[Token(Token = "0x401A7AA")]
		ORDER_NAME_33006,
		// Token: 0x04009259 RID: 37465
		[Token(Token = "0x401A7AB")]
		ORDER_EXPLAIN_56001 = 104000,
		// Token: 0x0400925A RID: 37466
		[Token(Token = "0x401A7AC")]
		ORDER_EXPLAIN_56002,
		// Token: 0x0400925B RID: 37467
		[Token(Token = "0x401A7AD")]
		ORDER_EXPLAIN_56003,
		// Token: 0x0400925C RID: 37468
		[Token(Token = "0x401A7AE")]
		ORDER_EXPLAIN_56004,
		// Token: 0x0400925D RID: 37469
		[Token(Token = "0x401A7AF")]
		ORDER_EXPLAIN_56005,
		// Token: 0x0400925E RID: 37470
		[Token(Token = "0x401A7B0")]
		ORDER_EXPLAIN_56006,
		// Token: 0x0400925F RID: 37471
		[Token(Token = "0x401A7B1")]
		ORDER_EXPLAIN_56007,
		// Token: 0x04009260 RID: 37472
		[Token(Token = "0x401A7B2")]
		ORDER_EXPLAIN_56008,
		// Token: 0x04009261 RID: 37473
		[Token(Token = "0x401A7B3")]
		ORDER_EXPLAIN_56009,
		// Token: 0x04009262 RID: 37474
		[Token(Token = "0x401A7B4")]
		ORDER_EXPLAIN_56010,
		// Token: 0x04009263 RID: 37475
		[Token(Token = "0x401A7B5")]
		ORDER_EXPLAIN_56011,
		// Token: 0x04009264 RID: 37476
		[Token(Token = "0x401A7B6")]
		ORDER_EXPLAIN_56012,
		// Token: 0x04009265 RID: 37477
		[Token(Token = "0x401A7B7")]
		ORDER_EXPLAIN_56013,
		// Token: 0x04009266 RID: 37478
		[Token(Token = "0x401A7B8")]
		ORDER_EXPLAIN_56014,
		// Token: 0x04009267 RID: 37479
		[Token(Token = "0x401A7B9")]
		ORDER_EXPLAIN_56015,
		// Token: 0x04009268 RID: 37480
		[Token(Token = "0x401A7BA")]
		ORDER_EXPLAIN_56016,
		// Token: 0x04009269 RID: 37481
		[Token(Token = "0x401A7BB")]
		ORDER_EXPLAIN_56017,
		// Token: 0x0400926A RID: 37482
		[Token(Token = "0x401A7BC")]
		ORDER_EXPLAIN_56018,
		// Token: 0x0400926B RID: 37483
		[Token(Token = "0x401A7BD")]
		ORDER_EXPLAIN_56019,
		// Token: 0x0400926C RID: 37484
		[Token(Token = "0x401A7BE")]
		ORDER_EXPLAIN_56020,
		// Token: 0x0400926D RID: 37485
		[Token(Token = "0x401A7BF")]
		ORDER_EXPLAIN_56021,
		// Token: 0x0400926E RID: 37486
		[Token(Token = "0x401A7C0")]
		ORDER_EXPLAIN_56022,
		// Token: 0x0400926F RID: 37487
		[Token(Token = "0x401A7C1")]
		ORDER_EXPLAIN_56023,
		// Token: 0x04009270 RID: 37488
		[Token(Token = "0x401A7C2")]
		ORDER_EXPLAIN_56024,
		// Token: 0x04009271 RID: 37489
		[Token(Token = "0x401A7C3")]
		ORDER_EXPLAIN_56025,
		// Token: 0x04009272 RID: 37490
		[Token(Token = "0x401A7C4")]
		ORDER_EXPLAIN_56026,
		// Token: 0x04009273 RID: 37491
		[Token(Token = "0x401A7C5")]
		ORDER_EXPLAIN_56027,
		// Token: 0x04009274 RID: 37492
		[Token(Token = "0x401A7C6")]
		ORDER_EXPLAIN_56028,
		// Token: 0x04009275 RID: 37493
		[Token(Token = "0x401A7C7")]
		ORDER_EXPLAIN_56029,
		// Token: 0x04009276 RID: 37494
		[Token(Token = "0x401A7C8")]
		ORDER_EXPLAIN_56030,
		// Token: 0x04009277 RID: 37495
		[Token(Token = "0x401A7C9")]
		ORDER_EXPLAIN_56031,
		// Token: 0x04009278 RID: 37496
		[Token(Token = "0x401A7CA")]
		ORDER_EXPLAIN_56032,
		// Token: 0x04009279 RID: 37497
		[Token(Token = "0x401A7CB")]
		ORDER_EXPLAIN_56033,
		// Token: 0x0400927A RID: 37498
		[Token(Token = "0x401A7CC")]
		ORDER_EXPLAIN_56034,
		// Token: 0x0400927B RID: 37499
		[Token(Token = "0x401A7CD")]
		ORDER_EXPLAIN_56035,
		// Token: 0x0400927C RID: 37500
		[Token(Token = "0x401A7CE")]
		ORDER_EXPLAIN_56036,
		// Token: 0x0400927D RID: 37501
		[Token(Token = "0x401A7CF")]
		ORDER_EXPLAIN_56037,
		// Token: 0x0400927E RID: 37502
		[Token(Token = "0x401A7D0")]
		ORDER_EXPLAIN_56038,
		// Token: 0x0400927F RID: 37503
		[Token(Token = "0x401A7D1")]
		ORDER_EXPLAIN_56039,
		// Token: 0x04009280 RID: 37504
		[Token(Token = "0x401A7D2")]
		ORDER_EXPLAIN_56040,
		// Token: 0x04009281 RID: 37505
		[Token(Token = "0x401A7D3")]
		ORDER_EXPLAIN_56041,
		// Token: 0x04009282 RID: 37506
		[Token(Token = "0x401A7D4")]
		ORDER_EXPLAIN_56042,
		// Token: 0x04009283 RID: 37507
		[Token(Token = "0x401A7D5")]
		ORDER_EXPLAIN_56043,
		// Token: 0x04009284 RID: 37508
		[Token(Token = "0x401A7D6")]
		ORDER_EXPLAIN_56044,
		// Token: 0x04009285 RID: 37509
		[Token(Token = "0x401A7D7")]
		ORDER_EXPLAIN_56045,
		// Token: 0x04009286 RID: 37510
		[Token(Token = "0x401A7D8")]
		ORDER_EXPLAIN_56046,
		// Token: 0x04009287 RID: 37511
		[Token(Token = "0x401A7D9")]
		ORDER_EXPLAIN_56047,
		// Token: 0x04009288 RID: 37512
		[Token(Token = "0x401A7DA")]
		ORDER_EXPLAIN_56048,
		// Token: 0x04009289 RID: 37513
		[Token(Token = "0x401A7DB")]
		ORDER_EXPLAIN_56049,
		// Token: 0x0400928A RID: 37514
		[Token(Token = "0x401A7DC")]
		ORDER_EXPLAIN_56050,
		// Token: 0x0400928B RID: 37515
		[Token(Token = "0x401A7DD")]
		ORDER_EXPLAIN_56051,
		// Token: 0x0400928C RID: 37516
		[Token(Token = "0x401A7DE")]
		ORDER_EXPLAIN_56052,
		// Token: 0x0400928D RID: 37517
		[Token(Token = "0x401A7DF")]
		ORDER_EXPLAIN_56053,
		// Token: 0x0400928E RID: 37518
		[Token(Token = "0x401A7E0")]
		ORDER_EXPLAIN_56054,
		// Token: 0x0400928F RID: 37519
		[Token(Token = "0x401A7E1")]
		ORDER_EXPLAIN_56055,
		// Token: 0x04009290 RID: 37520
		[Token(Token = "0x401A7E2")]
		ORDER_EXPLAIN_56056,
		// Token: 0x04009291 RID: 37521
		[Token(Token = "0x401A7E3")]
		ORDER_EXPLAIN_56057,
		// Token: 0x04009292 RID: 37522
		[Token(Token = "0x401A7E4")]
		ORDER_EXPLAIN_56058,
		// Token: 0x04009293 RID: 37523
		[Token(Token = "0x401A7E5")]
		ORDER_EXPLAIN_56059,
		// Token: 0x04009294 RID: 37524
		[Token(Token = "0x401A7E6")]
		ORDER_EXPLAIN_56060,
		// Token: 0x04009295 RID: 37525
		[Token(Token = "0x401A7E7")]
		ORDER_EXPLAIN_56061,
		// Token: 0x04009296 RID: 37526
		[Token(Token = "0x401A7E8")]
		ORDER_EXPLAIN_56062,
		// Token: 0x04009297 RID: 37527
		[Token(Token = "0x401A7E9")]
		ORDER_EXPLAIN_56063,
		// Token: 0x04009298 RID: 37528
		[Token(Token = "0x401A7EA")]
		ORDER_EXPLAIN_56064,
		// Token: 0x04009299 RID: 37529
		[Token(Token = "0x401A7EB")]
		ORDER_EXPLAIN_56065,
		// Token: 0x0400929A RID: 37530
		[Token(Token = "0x401A7EC")]
		ORDER_EXPLAIN_56066,
		// Token: 0x0400929B RID: 37531
		[Token(Token = "0x401A7ED")]
		ORDER_EXPLAIN_56067,
		// Token: 0x0400929C RID: 37532
		[Token(Token = "0x401A7EE")]
		ORDER_EXPLAIN_56068,
		// Token: 0x0400929D RID: 37533
		[Token(Token = "0x401A7EF")]
		ORDER_EXPLAIN_56069,
		// Token: 0x0400929E RID: 37534
		[Token(Token = "0x401A7F0")]
		ORDER_EXPLAIN_56070,
		// Token: 0x0400929F RID: 37535
		[Token(Token = "0x401A7F1")]
		ORDER_EXPLAIN_56071,
		// Token: 0x040092A0 RID: 37536
		[Token(Token = "0x401A7F2")]
		ORDER_EXPLAIN_56072,
		// Token: 0x040092A1 RID: 37537
		[Token(Token = "0x401A7F3")]
		ORDER_EXPLAIN_56073,
		// Token: 0x040092A2 RID: 37538
		[Token(Token = "0x401A7F4")]
		ORDER_EXPLAIN_56074,
		// Token: 0x040092A3 RID: 37539
		[Token(Token = "0x401A7F5")]
		ORDER_EXPLAIN_56075,
		// Token: 0x040092A4 RID: 37540
		[Token(Token = "0x401A7F6")]
		ORDER_EXPLAIN_56076,
		// Token: 0x040092A5 RID: 37541
		[Token(Token = "0x401A7F7")]
		ORDER_EXPLAIN_56077,
		// Token: 0x040092A6 RID: 37542
		[Token(Token = "0x401A7F8")]
		ORDER_EXPLAIN_56078,
		// Token: 0x040092A7 RID: 37543
		[Token(Token = "0x401A7F9")]
		ORDER_EXPLAIN_56079,
		// Token: 0x040092A8 RID: 37544
		[Token(Token = "0x401A7FA")]
		ORDER_EXPLAIN_56080,
		// Token: 0x040092A9 RID: 37545
		[Token(Token = "0x401A7FB")]
		ORDER_EXPLAIN_56081,
		// Token: 0x040092AA RID: 37546
		[Token(Token = "0x401A7FC")]
		ORDER_EXPLAIN_56083,
		// Token: 0x040092AB RID: 37547
		[Token(Token = "0x401A7FD")]
		ORDER_EXPLAIN_56084,
		// Token: 0x040092AC RID: 37548
		[Token(Token = "0x401A7FE")]
		ORDER_EXPLAIN_56085,
		// Token: 0x040092AD RID: 37549
		[Token(Token = "0x401A7FF")]
		ORDER_EXPLAIN_56086,
		// Token: 0x040092AE RID: 37550
		[Token(Token = "0x401A800")]
		ORDER_EXPLAIN_56087,
		// Token: 0x040092AF RID: 37551
		[Token(Token = "0x401A801")]
		ORDER_EXPLAIN_56088,
		// Token: 0x040092B0 RID: 37552
		[Token(Token = "0x401A802")]
		ORDER_EXPLAIN_56089,
		// Token: 0x040092B1 RID: 37553
		[Token(Token = "0x401A803")]
		ORDER_EXPLAIN_56090,
		// Token: 0x040092B2 RID: 37554
		[Token(Token = "0x401A804")]
		ORDER_EXPLAIN_56091,
		// Token: 0x040092B3 RID: 37555
		[Token(Token = "0x401A805")]
		ORDER_EXPLAIN_56092,
		// Token: 0x040092B4 RID: 37556
		[Token(Token = "0x401A806")]
		ORDER_EXPLAIN_56093,
		// Token: 0x040092B5 RID: 37557
		[Token(Token = "0x401A807")]
		ORDER_EXPLAIN_RAN_10,
		// Token: 0x040092B6 RID: 37558
		[Token(Token = "0x401A808")]
		ORDER_EXPLAIN_RAN_20,
		// Token: 0x040092B7 RID: 37559
		[Token(Token = "0x401A809")]
		ORDER_EXPLAIN_RAN_30,
		// Token: 0x040092B8 RID: 37560
		[Token(Token = "0x401A80A")]
		ORDER_EXPLAIN_RAN_40,
		// Token: 0x040092B9 RID: 37561
		[Token(Token = "0x401A80B")]
		ORDER_EXPLAIN_02001,
		// Token: 0x040092BA RID: 37562
		[Token(Token = "0x401A80C")]
		ORDER_EXPLAIN_02002,
		// Token: 0x040092BB RID: 37563
		[Token(Token = "0x401A80D")]
		ORDER_EXPLAIN_02003,
		// Token: 0x040092BC RID: 37564
		[Token(Token = "0x401A80E")]
		ORDER_EXPLAIN_02004,
		// Token: 0x040092BD RID: 37565
		[Token(Token = "0x401A80F")]
		ORDER_EXPLAIN_02005,
		// Token: 0x040092BE RID: 37566
		[Token(Token = "0x401A810")]
		ORDER_EXPLAIN_02006,
		// Token: 0x040092BF RID: 37567
		[Token(Token = "0x401A811")]
		ORDER_EXPLAIN_02007,
		// Token: 0x040092C0 RID: 37568
		[Token(Token = "0x401A812")]
		ORDER_EXPLAIN_02008,
		// Token: 0x040092C1 RID: 37569
		[Token(Token = "0x401A813")]
		ORDER_EXPLAIN_02009,
		// Token: 0x040092C2 RID: 37570
		[Token(Token = "0x401A814")]
		ORDER_EXPLAIN_03001,
		// Token: 0x040092C3 RID: 37571
		[Token(Token = "0x401A815")]
		ORDER_EXPLAIN_03002,
		// Token: 0x040092C4 RID: 37572
		[Token(Token = "0x401A816")]
		ORDER_EXPLAIN_03003,
		// Token: 0x040092C5 RID: 37573
		[Token(Token = "0x401A817")]
		ORDER_EXPLAIN_03004,
		// Token: 0x040092C6 RID: 37574
		[Token(Token = "0x401A818")]
		ORDER_EXPLAIN_03005,
		// Token: 0x040092C7 RID: 37575
		[Token(Token = "0x401A819")]
		ORDER_EXPLAIN_03006,
		// Token: 0x040092C8 RID: 37576
		[Token(Token = "0x401A81A")]
		ORDER_EXPLAIN_03007,
		// Token: 0x040092C9 RID: 37577
		[Token(Token = "0x401A81B")]
		ORDER_EXPLAIN_03008,
		// Token: 0x040092CA RID: 37578
		[Token(Token = "0x401A81C")]
		ORDER_EXPLAIN_03009,
		// Token: 0x040092CB RID: 37579
		[Token(Token = "0x401A81D")]
		ORDER_EXPLAIN_04001,
		// Token: 0x040092CC RID: 37580
		[Token(Token = "0x401A81E")]
		ORDER_EXPLAIN_04002,
		// Token: 0x040092CD RID: 37581
		[Token(Token = "0x401A81F")]
		ORDER_EXPLAIN_04003,
		// Token: 0x040092CE RID: 37582
		[Token(Token = "0x401A820")]
		ORDER_EXPLAIN_04004,
		// Token: 0x040092CF RID: 37583
		[Token(Token = "0x401A821")]
		ORDER_EXPLAIN_04005,
		// Token: 0x040092D0 RID: 37584
		[Token(Token = "0x401A822")]
		ORDER_EXPLAIN_04006,
		// Token: 0x040092D1 RID: 37585
		[Token(Token = "0x401A823")]
		ORDER_EXPLAIN_04007,
		// Token: 0x040092D2 RID: 37586
		[Token(Token = "0x401A824")]
		ORDER_EXPLAIN_04008,
		// Token: 0x040092D3 RID: 37587
		[Token(Token = "0x401A825")]
		ORDER_EXPLAIN_04009,
		// Token: 0x040092D4 RID: 37588
		[Token(Token = "0x401A826")]
		ORDER_EXPLAIN_05001,
		// Token: 0x040092D5 RID: 37589
		[Token(Token = "0x401A827")]
		ORDER_EXPLAIN_05002,
		// Token: 0x040092D6 RID: 37590
		[Token(Token = "0x401A828")]
		ORDER_EXPLAIN_05003,
		// Token: 0x040092D7 RID: 37591
		[Token(Token = "0x401A829")]
		ORDER_EXPLAIN_05004,
		// Token: 0x040092D8 RID: 37592
		[Token(Token = "0x401A82A")]
		ORDER_EXPLAIN_05005,
		// Token: 0x040092D9 RID: 37593
		[Token(Token = "0x401A82B")]
		ORDER_EXPLAIN_05006,
		// Token: 0x040092DA RID: 37594
		[Token(Token = "0x401A82C")]
		ORDER_EXPLAIN_05007,
		// Token: 0x040092DB RID: 37595
		[Token(Token = "0x401A82D")]
		ORDER_EXPLAIN_05008,
		// Token: 0x040092DC RID: 37596
		[Token(Token = "0x401A82E")]
		ORDER_EXPLAIN_05009,
		// Token: 0x040092DD RID: 37597
		[Token(Token = "0x401A82F")]
		ORDER_EXPLAIN_06001,
		// Token: 0x040092DE RID: 37598
		[Token(Token = "0x401A830")]
		ORDER_EXPLAIN_06002,
		// Token: 0x040092DF RID: 37599
		[Token(Token = "0x401A831")]
		ORDER_EXPLAIN_06003,
		// Token: 0x040092E0 RID: 37600
		[Token(Token = "0x401A832")]
		ORDER_EXPLAIN_06004,
		// Token: 0x040092E1 RID: 37601
		[Token(Token = "0x401A833")]
		ORDER_EXPLAIN_06005,
		// Token: 0x040092E2 RID: 37602
		[Token(Token = "0x401A834")]
		ORDER_EXPLAIN_06006,
		// Token: 0x040092E3 RID: 37603
		[Token(Token = "0x401A835")]
		ORDER_EXPLAIN_06007,
		// Token: 0x040092E4 RID: 37604
		[Token(Token = "0x401A836")]
		ORDER_EXPLAIN_06008,
		// Token: 0x040092E5 RID: 37605
		[Token(Token = "0x401A837")]
		ORDER_EXPLAIN_06009,
		// Token: 0x040092E6 RID: 37606
		[Token(Token = "0x401A838")]
		ORDER_EXPLAIN_07001,
		// Token: 0x040092E7 RID: 37607
		[Token(Token = "0x401A839")]
		ORDER_EXPLAIN_07002,
		// Token: 0x040092E8 RID: 37608
		[Token(Token = "0x401A83A")]
		ORDER_EXPLAIN_07003,
		// Token: 0x040092E9 RID: 37609
		[Token(Token = "0x401A83B")]
		ORDER_EXPLAIN_07004,
		// Token: 0x040092EA RID: 37610
		[Token(Token = "0x401A83C")]
		ORDER_EXPLAIN_07005,
		// Token: 0x040092EB RID: 37611
		[Token(Token = "0x401A83D")]
		ORDER_EXPLAIN_07006,
		// Token: 0x040092EC RID: 37612
		[Token(Token = "0x401A83E")]
		ORDER_EXPLAIN_07007,
		// Token: 0x040092ED RID: 37613
		[Token(Token = "0x401A83F")]
		ORDER_EXPLAIN_07008,
		// Token: 0x040092EE RID: 37614
		[Token(Token = "0x401A840")]
		ORDER_EXPLAIN_07009,
		// Token: 0x040092EF RID: 37615
		[Token(Token = "0x401A841")]
		ORDER_EXPLAIN_08001,
		// Token: 0x040092F0 RID: 37616
		[Token(Token = "0x401A842")]
		ORDER_EXPLAIN_08002,
		// Token: 0x040092F1 RID: 37617
		[Token(Token = "0x401A843")]
		ORDER_EXPLAIN_08003,
		// Token: 0x040092F2 RID: 37618
		[Token(Token = "0x401A844")]
		ORDER_EXPLAIN_08004,
		// Token: 0x040092F3 RID: 37619
		[Token(Token = "0x401A845")]
		ORDER_EXPLAIN_08005,
		// Token: 0x040092F4 RID: 37620
		[Token(Token = "0x401A846")]
		ORDER_EXPLAIN_08006,
		// Token: 0x040092F5 RID: 37621
		[Token(Token = "0x401A847")]
		ORDER_EXPLAIN_08007,
		// Token: 0x040092F6 RID: 37622
		[Token(Token = "0x401A848")]
		ORDER_EXPLAIN_08008,
		// Token: 0x040092F7 RID: 37623
		[Token(Token = "0x401A849")]
		ORDER_EXPLAIN_08009,
		// Token: 0x040092F8 RID: 37624
		[Token(Token = "0x401A84A")]
		ORDER_EXPLAIN_09001,
		// Token: 0x040092F9 RID: 37625
		[Token(Token = "0x401A84B")]
		ORDER_EXPLAIN_09002,
		// Token: 0x040092FA RID: 37626
		[Token(Token = "0x401A84C")]
		ORDER_EXPLAIN_09003,
		// Token: 0x040092FB RID: 37627
		[Token(Token = "0x401A84D")]
		ORDER_EXPLAIN_09004,
		// Token: 0x040092FC RID: 37628
		[Token(Token = "0x401A84E")]
		ORDER_EXPLAIN_09005,
		// Token: 0x040092FD RID: 37629
		[Token(Token = "0x401A84F")]
		ORDER_EXPLAIN_09006,
		// Token: 0x040092FE RID: 37630
		[Token(Token = "0x401A850")]
		ORDER_EXPLAIN_09007,
		// Token: 0x040092FF RID: 37631
		[Token(Token = "0x401A851")]
		ORDER_EXPLAIN_09008,
		// Token: 0x04009300 RID: 37632
		[Token(Token = "0x401A852")]
		ORDER_EXPLAIN_09009,
		// Token: 0x04009301 RID: 37633
		[Token(Token = "0x401A853")]
		ORDER_EXPLAIN_10001,
		// Token: 0x04009302 RID: 37634
		[Token(Token = "0x401A854")]
		ORDER_EXPLAIN_10002,
		// Token: 0x04009303 RID: 37635
		[Token(Token = "0x401A855")]
		ORDER_EXPLAIN_10003,
		// Token: 0x04009304 RID: 37636
		[Token(Token = "0x401A856")]
		ORDER_EXPLAIN_10004,
		// Token: 0x04009305 RID: 37637
		[Token(Token = "0x401A857")]
		ORDER_EXPLAIN_10005,
		// Token: 0x04009306 RID: 37638
		[Token(Token = "0x401A858")]
		ORDER_EXPLAIN_10006,
		// Token: 0x04009307 RID: 37639
		[Token(Token = "0x401A859")]
		ORDER_EXPLAIN_10007,
		// Token: 0x04009308 RID: 37640
		[Token(Token = "0x401A85A")]
		ORDER_EXPLAIN_10008,
		// Token: 0x04009309 RID: 37641
		[Token(Token = "0x401A85B")]
		ORDER_EXPLAIN_10009,
		// Token: 0x0400930A RID: 37642
		[Token(Token = "0x401A85C")]
		ORDER_EXPLAIN_11001,
		// Token: 0x0400930B RID: 37643
		[Token(Token = "0x401A85D")]
		ORDER_EXPLAIN_11002,
		// Token: 0x0400930C RID: 37644
		[Token(Token = "0x401A85E")]
		ORDER_EXPLAIN_11003,
		// Token: 0x0400930D RID: 37645
		[Token(Token = "0x401A85F")]
		ORDER_EXPLAIN_11004,
		// Token: 0x0400930E RID: 37646
		[Token(Token = "0x401A860")]
		ORDER_EXPLAIN_11005,
		// Token: 0x0400930F RID: 37647
		[Token(Token = "0x401A861")]
		ORDER_EXPLAIN_11006,
		// Token: 0x04009310 RID: 37648
		[Token(Token = "0x401A862")]
		ORDER_EXPLAIN_11007,
		// Token: 0x04009311 RID: 37649
		[Token(Token = "0x401A863")]
		ORDER_EXPLAIN_11008,
		// Token: 0x04009312 RID: 37650
		[Token(Token = "0x401A864")]
		ORDER_EXPLAIN_11009,
		// Token: 0x04009313 RID: 37651
		[Token(Token = "0x401A865")]
		ORDER_EXPLAIN_12001,
		// Token: 0x04009314 RID: 37652
		[Token(Token = "0x401A866")]
		ORDER_EXPLAIN_12002,
		// Token: 0x04009315 RID: 37653
		[Token(Token = "0x401A867")]
		ORDER_EXPLAIN_12003,
		// Token: 0x04009316 RID: 37654
		[Token(Token = "0x401A868")]
		ORDER_EXPLAIN_12004,
		// Token: 0x04009317 RID: 37655
		[Token(Token = "0x401A869")]
		ORDER_EXPLAIN_12005,
		// Token: 0x04009318 RID: 37656
		[Token(Token = "0x401A86A")]
		ORDER_EXPLAIN_12006,
		// Token: 0x04009319 RID: 37657
		[Token(Token = "0x401A86B")]
		ORDER_EXPLAIN_12007,
		// Token: 0x0400931A RID: 37658
		[Token(Token = "0x401A86C")]
		ORDER_EXPLAIN_12008,
		// Token: 0x0400931B RID: 37659
		[Token(Token = "0x401A86D")]
		ORDER_EXPLAIN_12009,
		// Token: 0x0400931C RID: 37660
		[Token(Token = "0x401A86E")]
		ORDER_EXPLAIN_13001,
		// Token: 0x0400931D RID: 37661
		[Token(Token = "0x401A86F")]
		ORDER_EXPLAIN_13002,
		// Token: 0x0400931E RID: 37662
		[Token(Token = "0x401A870")]
		ORDER_EXPLAIN_13003,
		// Token: 0x0400931F RID: 37663
		[Token(Token = "0x401A871")]
		ORDER_EXPLAIN_13004,
		// Token: 0x04009320 RID: 37664
		[Token(Token = "0x401A872")]
		ORDER_EXPLAIN_13005,
		// Token: 0x04009321 RID: 37665
		[Token(Token = "0x401A873")]
		ORDER_EXPLAIN_13006,
		// Token: 0x04009322 RID: 37666
		[Token(Token = "0x401A874")]
		ORDER_EXPLAIN_14001,
		// Token: 0x04009323 RID: 37667
		[Token(Token = "0x401A875")]
		ORDER_EXPLAIN_14002,
		// Token: 0x04009324 RID: 37668
		[Token(Token = "0x401A876")]
		ORDER_EXPLAIN_14003,
		// Token: 0x04009325 RID: 37669
		[Token(Token = "0x401A877")]
		ORDER_EXPLAIN_14004,
		// Token: 0x04009326 RID: 37670
		[Token(Token = "0x401A878")]
		ORDER_EXPLAIN_14005,
		// Token: 0x04009327 RID: 37671
		[Token(Token = "0x401A879")]
		ORDER_EXPLAIN_14006,
		// Token: 0x04009328 RID: 37672
		[Token(Token = "0x401A87A")]
		ORDER_EXPLAIN_15001,
		// Token: 0x04009329 RID: 37673
		[Token(Token = "0x401A87B")]
		ORDER_EXPLAIN_15002,
		// Token: 0x0400932A RID: 37674
		[Token(Token = "0x401A87C")]
		ORDER_EXPLAIN_15003,
		// Token: 0x0400932B RID: 37675
		[Token(Token = "0x401A87D")]
		ORDER_EXPLAIN_15004,
		// Token: 0x0400932C RID: 37676
		[Token(Token = "0x401A87E")]
		ORDER_EXPLAIN_15005,
		// Token: 0x0400932D RID: 37677
		[Token(Token = "0x401A87F")]
		ORDER_EXPLAIN_15006,
		// Token: 0x0400932E RID: 37678
		[Token(Token = "0x401A880")]
		ORDER_EXPLAIN_16001,
		// Token: 0x0400932F RID: 37679
		[Token(Token = "0x401A881")]
		ORDER_EXPLAIN_16002,
		// Token: 0x04009330 RID: 37680
		[Token(Token = "0x401A882")]
		ORDER_EXPLAIN_16003,
		// Token: 0x04009331 RID: 37681
		[Token(Token = "0x401A883")]
		ORDER_EXPLAIN_16004,
		// Token: 0x04009332 RID: 37682
		[Token(Token = "0x401A884")]
		ORDER_EXPLAIN_16005,
		// Token: 0x04009333 RID: 37683
		[Token(Token = "0x401A885")]
		ORDER_EXPLAIN_16006,
		// Token: 0x04009334 RID: 37684
		[Token(Token = "0x401A886")]
		ORDER_EXPLAIN_17001,
		// Token: 0x04009335 RID: 37685
		[Token(Token = "0x401A887")]
		ORDER_EXPLAIN_17002,
		// Token: 0x04009336 RID: 37686
		[Token(Token = "0x401A888")]
		ORDER_EXPLAIN_17003,
		// Token: 0x04009337 RID: 37687
		[Token(Token = "0x401A889")]
		ORDER_EXPLAIN_17004,
		// Token: 0x04009338 RID: 37688
		[Token(Token = "0x401A88A")]
		ORDER_EXPLAIN_17005,
		// Token: 0x04009339 RID: 37689
		[Token(Token = "0x401A88B")]
		ORDER_EXPLAIN_17006,
		// Token: 0x0400933A RID: 37690
		[Token(Token = "0x401A88C")]
		ORDER_EXPLAIN_18001,
		// Token: 0x0400933B RID: 37691
		[Token(Token = "0x401A88D")]
		ORDER_EXPLAIN_18002,
		// Token: 0x0400933C RID: 37692
		[Token(Token = "0x401A88E")]
		ORDER_EXPLAIN_18003,
		// Token: 0x0400933D RID: 37693
		[Token(Token = "0x401A88F")]
		ORDER_EXPLAIN_18004,
		// Token: 0x0400933E RID: 37694
		[Token(Token = "0x401A890")]
		ORDER_EXPLAIN_18005,
		// Token: 0x0400933F RID: 37695
		[Token(Token = "0x401A891")]
		ORDER_EXPLAIN_18006,
		// Token: 0x04009340 RID: 37696
		[Token(Token = "0x401A892")]
		ORDER_EXPLAIN_19001,
		// Token: 0x04009341 RID: 37697
		[Token(Token = "0x401A893")]
		ORDER_EXPLAIN_19002,
		// Token: 0x04009342 RID: 37698
		[Token(Token = "0x401A894")]
		ORDER_EXPLAIN_19003,
		// Token: 0x04009343 RID: 37699
		[Token(Token = "0x401A895")]
		ORDER_EXPLAIN_19004,
		// Token: 0x04009344 RID: 37700
		[Token(Token = "0x401A896")]
		ORDER_EXPLAIN_19005,
		// Token: 0x04009345 RID: 37701
		[Token(Token = "0x401A897")]
		ORDER_EXPLAIN_19006,
		// Token: 0x04009346 RID: 37702
		[Token(Token = "0x401A898")]
		ORDER_EXPLAIN_20001,
		// Token: 0x04009347 RID: 37703
		[Token(Token = "0x401A899")]
		ORDER_EXPLAIN_20002,
		// Token: 0x04009348 RID: 37704
		[Token(Token = "0x401A89A")]
		ORDER_EXPLAIN_20003,
		// Token: 0x04009349 RID: 37705
		[Token(Token = "0x401A89B")]
		ORDER_EXPLAIN_20004,
		// Token: 0x0400934A RID: 37706
		[Token(Token = "0x401A89C")]
		ORDER_EXPLAIN_20005,
		// Token: 0x0400934B RID: 37707
		[Token(Token = "0x401A89D")]
		ORDER_EXPLAIN_20006,
		// Token: 0x0400934C RID: 37708
		[Token(Token = "0x401A89E")]
		ORDER_EXPLAIN_21001,
		// Token: 0x0400934D RID: 37709
		[Token(Token = "0x401A89F")]
		ORDER_EXPLAIN_21002,
		// Token: 0x0400934E RID: 37710
		[Token(Token = "0x401A8A0")]
		ORDER_EXPLAIN_21003,
		// Token: 0x0400934F RID: 37711
		[Token(Token = "0x401A8A1")]
		ORDER_EXPLAIN_21004,
		// Token: 0x04009350 RID: 37712
		[Token(Token = "0x401A8A2")]
		ORDER_EXPLAIN_21005,
		// Token: 0x04009351 RID: 37713
		[Token(Token = "0x401A8A3")]
		ORDER_EXPLAIN_21006,
		// Token: 0x04009352 RID: 37714
		[Token(Token = "0x401A8A4")]
		ORDER_EXPLAIN_22001,
		// Token: 0x04009353 RID: 37715
		[Token(Token = "0x401A8A5")]
		ORDER_EXPLAIN_22002,
		// Token: 0x04009354 RID: 37716
		[Token(Token = "0x401A8A6")]
		ORDER_EXPLAIN_22003,
		// Token: 0x04009355 RID: 37717
		[Token(Token = "0x401A8A7")]
		ORDER_EXPLAIN_22004,
		// Token: 0x04009356 RID: 37718
		[Token(Token = "0x401A8A8")]
		ORDER_EXPLAIN_22005,
		// Token: 0x04009357 RID: 37719
		[Token(Token = "0x401A8A9")]
		ORDER_EXPLAIN_22006,
		// Token: 0x04009358 RID: 37720
		[Token(Token = "0x401A8AA")]
		ORDER_EXPLAIN_24001,
		// Token: 0x04009359 RID: 37721
		[Token(Token = "0x401A8AB")]
		ORDER_EXPLAIN_24002,
		// Token: 0x0400935A RID: 37722
		[Token(Token = "0x401A8AC")]
		ORDER_EXPLAIN_24003,
		// Token: 0x0400935B RID: 37723
		[Token(Token = "0x401A8AD")]
		ORDER_EXPLAIN_24004,
		// Token: 0x0400935C RID: 37724
		[Token(Token = "0x401A8AE")]
		ORDER_EXPLAIN_24005,
		// Token: 0x0400935D RID: 37725
		[Token(Token = "0x401A8AF")]
		ORDER_EXPLAIN_24006,
		// Token: 0x0400935E RID: 37726
		[Token(Token = "0x401A8B0")]
		ORDER_EXPLAIN_26001,
		// Token: 0x0400935F RID: 37727
		[Token(Token = "0x401A8B1")]
		ORDER_EXPLAIN_26002,
		// Token: 0x04009360 RID: 37728
		[Token(Token = "0x401A8B2")]
		ORDER_EXPLAIN_26003,
		// Token: 0x04009361 RID: 37729
		[Token(Token = "0x401A8B3")]
		ORDER_EXPLAIN_26004,
		// Token: 0x04009362 RID: 37730
		[Token(Token = "0x401A8B4")]
		ORDER_EXPLAIN_26005,
		// Token: 0x04009363 RID: 37731
		[Token(Token = "0x401A8B5")]
		ORDER_EXPLAIN_26006,
		// Token: 0x04009364 RID: 37732
		[Token(Token = "0x401A8B6")]
		ORDER_EXPLAIN_27001,
		// Token: 0x04009365 RID: 37733
		[Token(Token = "0x401A8B7")]
		ORDER_EXPLAIN_27002,
		// Token: 0x04009366 RID: 37734
		[Token(Token = "0x401A8B8")]
		ORDER_EXPLAIN_27003,
		// Token: 0x04009367 RID: 37735
		[Token(Token = "0x401A8B9")]
		ORDER_EXPLAIN_27004,
		// Token: 0x04009368 RID: 37736
		[Token(Token = "0x401A8BA")]
		ORDER_EXPLAIN_27005,
		// Token: 0x04009369 RID: 37737
		[Token(Token = "0x401A8BB")]
		ORDER_EXPLAIN_27006,
		// Token: 0x0400936A RID: 37738
		[Token(Token = "0x401A8BC")]
		ORDER_EXPLAIN_28001,
		// Token: 0x0400936B RID: 37739
		[Token(Token = "0x401A8BD")]
		ORDER_EXPLAIN_28002,
		// Token: 0x0400936C RID: 37740
		[Token(Token = "0x401A8BE")]
		ORDER_EXPLAIN_28003,
		// Token: 0x0400936D RID: 37741
		[Token(Token = "0x401A8BF")]
		ORDER_EXPLAIN_28004,
		// Token: 0x0400936E RID: 37742
		[Token(Token = "0x401A8C0")]
		ORDER_EXPLAIN_28005,
		// Token: 0x0400936F RID: 37743
		[Token(Token = "0x401A8C1")]
		ORDER_EXPLAIN_28006,
		// Token: 0x04009370 RID: 37744
		[Token(Token = "0x401A8C2")]
		ORDER_EXPLAIN_29010,
		// Token: 0x04009371 RID: 37745
		[Token(Token = "0x401A8C3")]
		ORDER_EXPLAIN_29011,
		// Token: 0x04009372 RID: 37746
		[Token(Token = "0x401A8C4")]
		ORDER_EXPLAIN_29012,
		// Token: 0x04009373 RID: 37747
		[Token(Token = "0x401A8C5")]
		ORDER_EXPLAIN_29020,
		// Token: 0x04009374 RID: 37748
		[Token(Token = "0x401A8C6")]
		ORDER_EXPLAIN_29021,
		// Token: 0x04009375 RID: 37749
		[Token(Token = "0x401A8C7")]
		ORDER_EXPLAIN_29022,
		// Token: 0x04009376 RID: 37750
		[Token(Token = "0x401A8C8")]
		ORDER_EXPLAIN_29030,
		// Token: 0x04009377 RID: 37751
		[Token(Token = "0x401A8C9")]
		ORDER_EXPLAIN_29031,
		// Token: 0x04009378 RID: 37752
		[Token(Token = "0x401A8CA")]
		ORDER_EXPLAIN_29032,
		// Token: 0x04009379 RID: 37753
		[Token(Token = "0x401A8CB")]
		ORDER_EXPLAIN_29040,
		// Token: 0x0400937A RID: 37754
		[Token(Token = "0x401A8CC")]
		ORDER_EXPLAIN_29041,
		// Token: 0x0400937B RID: 37755
		[Token(Token = "0x401A8CD")]
		ORDER_EXPLAIN_29042,
		// Token: 0x0400937C RID: 37756
		[Token(Token = "0x401A8CE")]
		ORDER_EXPLAIN_29050,
		// Token: 0x0400937D RID: 37757
		[Token(Token = "0x401A8CF")]
		ORDER_EXPLAIN_29051,
		// Token: 0x0400937E RID: 37758
		[Token(Token = "0x401A8D0")]
		ORDER_EXPLAIN_29052,
		// Token: 0x0400937F RID: 37759
		[Token(Token = "0x401A8D1")]
		ORDER_EXPLAIN_29060,
		// Token: 0x04009380 RID: 37760
		[Token(Token = "0x401A8D2")]
		ORDER_EXPLAIN_29061,
		// Token: 0x04009381 RID: 37761
		[Token(Token = "0x401A8D3")]
		ORDER_EXPLAIN_29062,
		// Token: 0x04009382 RID: 37762
		[Token(Token = "0x401A8D4")]
		ORDER_EXPLAIN_29110,
		// Token: 0x04009383 RID: 37763
		[Token(Token = "0x401A8D5")]
		ORDER_EXPLAIN_29111,
		// Token: 0x04009384 RID: 37764
		[Token(Token = "0x401A8D6")]
		ORDER_EXPLAIN_29112,
		// Token: 0x04009385 RID: 37765
		[Token(Token = "0x401A8D7")]
		ORDER_EXPLAIN_29120,
		// Token: 0x04009386 RID: 37766
		[Token(Token = "0x401A8D8")]
		ORDER_EXPLAIN_29121,
		// Token: 0x04009387 RID: 37767
		[Token(Token = "0x401A8D9")]
		ORDER_EXPLAIN_29122,
		// Token: 0x04009388 RID: 37768
		[Token(Token = "0x401A8DA")]
		ORDER_EXPLAIN_29130,
		// Token: 0x04009389 RID: 37769
		[Token(Token = "0x401A8DB")]
		ORDER_EXPLAIN_29131,
		// Token: 0x0400938A RID: 37770
		[Token(Token = "0x401A8DC")]
		ORDER_EXPLAIN_29132,
		// Token: 0x0400938B RID: 37771
		[Token(Token = "0x401A8DD")]
		ORDER_EXPLAIN_29140,
		// Token: 0x0400938C RID: 37772
		[Token(Token = "0x401A8DE")]
		ORDER_EXPLAIN_29141,
		// Token: 0x0400938D RID: 37773
		[Token(Token = "0x401A8DF")]
		ORDER_EXPLAIN_29142,
		// Token: 0x0400938E RID: 37774
		[Token(Token = "0x401A8E0")]
		ORDER_EXPLAIN_29150,
		// Token: 0x0400938F RID: 37775
		[Token(Token = "0x401A8E1")]
		ORDER_EXPLAIN_29151,
		// Token: 0x04009390 RID: 37776
		[Token(Token = "0x401A8E2")]
		ORDER_EXPLAIN_29152,
		// Token: 0x04009391 RID: 37777
		[Token(Token = "0x401A8E3")]
		ORDER_EXPLAIN_29160,
		// Token: 0x04009392 RID: 37778
		[Token(Token = "0x401A8E4")]
		ORDER_EXPLAIN_29161,
		// Token: 0x04009393 RID: 37779
		[Token(Token = "0x401A8E5")]
		ORDER_EXPLAIN_29162,
		// Token: 0x04009394 RID: 37780
		[Token(Token = "0x401A8E6")]
		ORDER_EXPLAIN_30010,
		// Token: 0x04009395 RID: 37781
		[Token(Token = "0x401A8E7")]
		ORDER_EXPLAIN_30011,
		// Token: 0x04009396 RID: 37782
		[Token(Token = "0x401A8E8")]
		ORDER_EXPLAIN_30012,
		// Token: 0x04009397 RID: 37783
		[Token(Token = "0x401A8E9")]
		ORDER_EXPLAIN_30020,
		// Token: 0x04009398 RID: 37784
		[Token(Token = "0x401A8EA")]
		ORDER_EXPLAIN_30021,
		// Token: 0x04009399 RID: 37785
		[Token(Token = "0x401A8EB")]
		ORDER_EXPLAIN_30022,
		// Token: 0x0400939A RID: 37786
		[Token(Token = "0x401A8EC")]
		ORDER_EXPLAIN_30030,
		// Token: 0x0400939B RID: 37787
		[Token(Token = "0x401A8ED")]
		ORDER_EXPLAIN_30031,
		// Token: 0x0400939C RID: 37788
		[Token(Token = "0x401A8EE")]
		ORDER_EXPLAIN_30032,
		// Token: 0x0400939D RID: 37789
		[Token(Token = "0x401A8EF")]
		ORDER_EXPLAIN_30040,
		// Token: 0x0400939E RID: 37790
		[Token(Token = "0x401A8F0")]
		ORDER_EXPLAIN_30041,
		// Token: 0x0400939F RID: 37791
		[Token(Token = "0x401A8F1")]
		ORDER_EXPLAIN_30042,
		// Token: 0x040093A0 RID: 37792
		[Token(Token = "0x401A8F2")]
		ORDER_EXPLAIN_30050,
		// Token: 0x040093A1 RID: 37793
		[Token(Token = "0x401A8F3")]
		ORDER_EXPLAIN_30051,
		// Token: 0x040093A2 RID: 37794
		[Token(Token = "0x401A8F4")]
		ORDER_EXPLAIN_30052,
		// Token: 0x040093A3 RID: 37795
		[Token(Token = "0x401A8F5")]
		ORDER_EXPLAIN_30060,
		// Token: 0x040093A4 RID: 37796
		[Token(Token = "0x401A8F6")]
		ORDER_EXPLAIN_30061,
		// Token: 0x040093A5 RID: 37797
		[Token(Token = "0x401A8F7")]
		ORDER_EXPLAIN_30062,
		// Token: 0x040093A6 RID: 37798
		[Token(Token = "0x401A8F8")]
		ORDER_EXPLAIN_31010,
		// Token: 0x040093A7 RID: 37799
		[Token(Token = "0x401A8F9")]
		ORDER_EXPLAIN_31011,
		// Token: 0x040093A8 RID: 37800
		[Token(Token = "0x401A8FA")]
		ORDER_EXPLAIN_31012,
		// Token: 0x040093A9 RID: 37801
		[Token(Token = "0x401A8FB")]
		ORDER_EXPLAIN_31020,
		// Token: 0x040093AA RID: 37802
		[Token(Token = "0x401A8FC")]
		ORDER_EXPLAIN_31021,
		// Token: 0x040093AB RID: 37803
		[Token(Token = "0x401A8FD")]
		ORDER_EXPLAIN_31022,
		// Token: 0x040093AC RID: 37804
		[Token(Token = "0x401A8FE")]
		ORDER_EXPLAIN_31030,
		// Token: 0x040093AD RID: 37805
		[Token(Token = "0x401A8FF")]
		ORDER_EXPLAIN_31031,
		// Token: 0x040093AE RID: 37806
		[Token(Token = "0x401A900")]
		ORDER_EXPLAIN_31032,
		// Token: 0x040093AF RID: 37807
		[Token(Token = "0x401A901")]
		ORDER_EXPLAIN_31040,
		// Token: 0x040093B0 RID: 37808
		[Token(Token = "0x401A902")]
		ORDER_EXPLAIN_31041,
		// Token: 0x040093B1 RID: 37809
		[Token(Token = "0x401A903")]
		ORDER_EXPLAIN_31042,
		// Token: 0x040093B2 RID: 37810
		[Token(Token = "0x401A904")]
		ORDER_EXPLAIN_31050,
		// Token: 0x040093B3 RID: 37811
		[Token(Token = "0x401A905")]
		ORDER_EXPLAIN_31051,
		// Token: 0x040093B4 RID: 37812
		[Token(Token = "0x401A906")]
		ORDER_EXPLAIN_31052,
		// Token: 0x040093B5 RID: 37813
		[Token(Token = "0x401A907")]
		ORDER_EXPLAIN_31060,
		// Token: 0x040093B6 RID: 37814
		[Token(Token = "0x401A908")]
		ORDER_EXPLAIN_31061,
		// Token: 0x040093B7 RID: 37815
		[Token(Token = "0x401A909")]
		ORDER_EXPLAIN_31062,
		// Token: 0x040093B8 RID: 37816
		[Token(Token = "0x401A90A")]
		ORDER_EXPLAIN_32001,
		// Token: 0x040093B9 RID: 37817
		[Token(Token = "0x401A90B")]
		ORDER_EXPLAIN_32002,
		// Token: 0x040093BA RID: 37818
		[Token(Token = "0x401A90C")]
		ORDER_EXPLAIN_32003,
		// Token: 0x040093BB RID: 37819
		[Token(Token = "0x401A90D")]
		ORDER_EXPLAIN_32004,
		// Token: 0x040093BC RID: 37820
		[Token(Token = "0x401A90E")]
		ORDER_EXPLAIN_32005,
		// Token: 0x040093BD RID: 37821
		[Token(Token = "0x401A90F")]
		ORDER_EXPLAIN_32006,
		// Token: 0x040093BE RID: 37822
		[Token(Token = "0x401A910")]
		ORDER_EXPLAIN_33001,
		// Token: 0x040093BF RID: 37823
		[Token(Token = "0x401A911")]
		ORDER_EXPLAIN_33002,
		// Token: 0x040093C0 RID: 37824
		[Token(Token = "0x401A912")]
		ORDER_EXPLAIN_33003,
		// Token: 0x040093C1 RID: 37825
		[Token(Token = "0x401A913")]
		ORDER_EXPLAIN_33004,
		// Token: 0x040093C2 RID: 37826
		[Token(Token = "0x401A914")]
		ORDER_EXPLAIN_33005,
		// Token: 0x040093C3 RID: 37827
		[Token(Token = "0x401A915")]
		ORDER_EXPLAIN_33006,
		// Token: 0x040093C4 RID: 37828
		[Token(Token = "0x401A916")]
		ORDER_HUD_56001 = 105000,
		// Token: 0x040093C5 RID: 37829
		[Token(Token = "0x401A917")]
		ORDER_HUD_56002,
		// Token: 0x040093C6 RID: 37830
		[Token(Token = "0x401A918")]
		ORDER_HUD_56003,
		// Token: 0x040093C7 RID: 37831
		[Token(Token = "0x401A919")]
		ORDER_HUD_56004,
		// Token: 0x040093C8 RID: 37832
		[Token(Token = "0x401A91A")]
		ORDER_HUD_56005,
		// Token: 0x040093C9 RID: 37833
		[Token(Token = "0x401A91B")]
		ORDER_HUD_56006,
		// Token: 0x040093CA RID: 37834
		[Token(Token = "0x401A91C")]
		ORDER_HUD_56007,
		// Token: 0x040093CB RID: 37835
		[Token(Token = "0x401A91D")]
		ORDER_HUD_56008,
		// Token: 0x040093CC RID: 37836
		[Token(Token = "0x401A91E")]
		ORDER_HUD_56009,
		// Token: 0x040093CD RID: 37837
		[Token(Token = "0x401A91F")]
		ORDER_HUD_56010,
		// Token: 0x040093CE RID: 37838
		[Token(Token = "0x401A920")]
		ORDER_HUD_56011,
		// Token: 0x040093CF RID: 37839
		[Token(Token = "0x401A921")]
		ORDER_HUD_56012,
		// Token: 0x040093D0 RID: 37840
		[Token(Token = "0x401A922")]
		ORDER_HUD_56013,
		// Token: 0x040093D1 RID: 37841
		[Token(Token = "0x401A923")]
		ORDER_HUD_56014,
		// Token: 0x040093D2 RID: 37842
		[Token(Token = "0x401A924")]
		ORDER_HUD_56015,
		// Token: 0x040093D3 RID: 37843
		[Token(Token = "0x401A925")]
		ORDER_HUD_56016,
		// Token: 0x040093D4 RID: 37844
		[Token(Token = "0x401A926")]
		ORDER_HUD_56017,
		// Token: 0x040093D5 RID: 37845
		[Token(Token = "0x401A927")]
		ORDER_HUD_56018,
		// Token: 0x040093D6 RID: 37846
		[Token(Token = "0x401A928")]
		ORDER_HUD_56019,
		// Token: 0x040093D7 RID: 37847
		[Token(Token = "0x401A929")]
		ORDER_HUD_56020,
		// Token: 0x040093D8 RID: 37848
		[Token(Token = "0x401A92A")]
		ORDER_HUD_56021,
		// Token: 0x040093D9 RID: 37849
		[Token(Token = "0x401A92B")]
		ORDER_HUD_56022,
		// Token: 0x040093DA RID: 37850
		[Token(Token = "0x401A92C")]
		ORDER_HUD_56023,
		// Token: 0x040093DB RID: 37851
		[Token(Token = "0x401A92D")]
		ORDER_HUD_56024,
		// Token: 0x040093DC RID: 37852
		[Token(Token = "0x401A92E")]
		ORDER_HUD_56025,
		// Token: 0x040093DD RID: 37853
		[Token(Token = "0x401A92F")]
		ORDER_HUD_56026,
		// Token: 0x040093DE RID: 37854
		[Token(Token = "0x401A930")]
		ORDER_HUD_56027,
		// Token: 0x040093DF RID: 37855
		[Token(Token = "0x401A931")]
		ORDER_HUD_56028,
		// Token: 0x040093E0 RID: 37856
		[Token(Token = "0x401A932")]
		ORDER_HUD_56029,
		// Token: 0x040093E1 RID: 37857
		[Token(Token = "0x401A933")]
		ORDER_HUD_56030,
		// Token: 0x040093E2 RID: 37858
		[Token(Token = "0x401A934")]
		ORDER_HUD_56031,
		// Token: 0x040093E3 RID: 37859
		[Token(Token = "0x401A935")]
		ORDER_HUD_56032,
		// Token: 0x040093E4 RID: 37860
		[Token(Token = "0x401A936")]
		ORDER_HUD_56033,
		// Token: 0x040093E5 RID: 37861
		[Token(Token = "0x401A937")]
		ORDER_HUD_56034,
		// Token: 0x040093E6 RID: 37862
		[Token(Token = "0x401A938")]
		ORDER_HUD_56035,
		// Token: 0x040093E7 RID: 37863
		[Token(Token = "0x401A939")]
		ORDER_HUD_56036,
		// Token: 0x040093E8 RID: 37864
		[Token(Token = "0x401A93A")]
		ORDER_HUD_56037,
		// Token: 0x040093E9 RID: 37865
		[Token(Token = "0x401A93B")]
		ORDER_HUD_56038,
		// Token: 0x040093EA RID: 37866
		[Token(Token = "0x401A93C")]
		ORDER_HUD_56039,
		// Token: 0x040093EB RID: 37867
		[Token(Token = "0x401A93D")]
		ORDER_HUD_56040,
		// Token: 0x040093EC RID: 37868
		[Token(Token = "0x401A93E")]
		ORDER_HUD_56041,
		// Token: 0x040093ED RID: 37869
		[Token(Token = "0x401A93F")]
		ORDER_HUD_56042,
		// Token: 0x040093EE RID: 37870
		[Token(Token = "0x401A940")]
		ORDER_HUD_56043,
		// Token: 0x040093EF RID: 37871
		[Token(Token = "0x401A941")]
		ORDER_HUD_56044,
		// Token: 0x040093F0 RID: 37872
		[Token(Token = "0x401A942")]
		ORDER_HUD_56045,
		// Token: 0x040093F1 RID: 37873
		[Token(Token = "0x401A943")]
		ORDER_HUD_56046,
		// Token: 0x040093F2 RID: 37874
		[Token(Token = "0x401A944")]
		ORDER_HUD_56047,
		// Token: 0x040093F3 RID: 37875
		[Token(Token = "0x401A945")]
		ORDER_HUD_56048,
		// Token: 0x040093F4 RID: 37876
		[Token(Token = "0x401A946")]
		ORDER_HUD_56049,
		// Token: 0x040093F5 RID: 37877
		[Token(Token = "0x401A947")]
		ORDER_HUD_56050,
		// Token: 0x040093F6 RID: 37878
		[Token(Token = "0x401A948")]
		ORDER_HUD_56051,
		// Token: 0x040093F7 RID: 37879
		[Token(Token = "0x401A949")]
		ORDER_HUD_56052,
		// Token: 0x040093F8 RID: 37880
		[Token(Token = "0x401A94A")]
		ORDER_HUD_56053,
		// Token: 0x040093F9 RID: 37881
		[Token(Token = "0x401A94B")]
		ORDER_HUD_56054,
		// Token: 0x040093FA RID: 37882
		[Token(Token = "0x401A94C")]
		ORDER_HUD_56055,
		// Token: 0x040093FB RID: 37883
		[Token(Token = "0x401A94D")]
		ORDER_HUD_56056,
		// Token: 0x040093FC RID: 37884
		[Token(Token = "0x401A94E")]
		ORDER_HUD_56057,
		// Token: 0x040093FD RID: 37885
		[Token(Token = "0x401A94F")]
		ORDER_HUD_56058,
		// Token: 0x040093FE RID: 37886
		[Token(Token = "0x401A950")]
		ORDER_HUD_56059,
		// Token: 0x040093FF RID: 37887
		[Token(Token = "0x401A951")]
		ORDER_HUD_56060,
		// Token: 0x04009400 RID: 37888
		[Token(Token = "0x401A952")]
		ORDER_HUD_56061,
		// Token: 0x04009401 RID: 37889
		[Token(Token = "0x401A953")]
		ORDER_HUD_56062,
		// Token: 0x04009402 RID: 37890
		[Token(Token = "0x401A954")]
		ORDER_HUD_56063,
		// Token: 0x04009403 RID: 37891
		[Token(Token = "0x401A955")]
		ORDER_HUD_56064,
		// Token: 0x04009404 RID: 37892
		[Token(Token = "0x401A956")]
		ORDER_HUD_56065,
		// Token: 0x04009405 RID: 37893
		[Token(Token = "0x401A957")]
		ORDER_HUD_56066,
		// Token: 0x04009406 RID: 37894
		[Token(Token = "0x401A958")]
		ORDER_HUD_56067,
		// Token: 0x04009407 RID: 37895
		[Token(Token = "0x401A959")]
		ORDER_HUD_56068,
		// Token: 0x04009408 RID: 37896
		[Token(Token = "0x401A95A")]
		ORDER_HUD_56069,
		// Token: 0x04009409 RID: 37897
		[Token(Token = "0x401A95B")]
		ORDER_HUD_56070,
		// Token: 0x0400940A RID: 37898
		[Token(Token = "0x401A95C")]
		ORDER_HUD_56071,
		// Token: 0x0400940B RID: 37899
		[Token(Token = "0x401A95D")]
		ORDER_HUD_56072,
		// Token: 0x0400940C RID: 37900
		[Token(Token = "0x401A95E")]
		ORDER_HUD_56073,
		// Token: 0x0400940D RID: 37901
		[Token(Token = "0x401A95F")]
		ORDER_HUD_56074,
		// Token: 0x0400940E RID: 37902
		[Token(Token = "0x401A960")]
		ORDER_HUD_56075,
		// Token: 0x0400940F RID: 37903
		[Token(Token = "0x401A961")]
		ORDER_HUD_56076,
		// Token: 0x04009410 RID: 37904
		[Token(Token = "0x401A962")]
		ORDER_HUD_56077,
		// Token: 0x04009411 RID: 37905
		[Token(Token = "0x401A963")]
		ORDER_HUD_56078,
		// Token: 0x04009412 RID: 37906
		[Token(Token = "0x401A964")]
		ORDER_HUD_56079,
		// Token: 0x04009413 RID: 37907
		[Token(Token = "0x401A965")]
		ORDER_HUD_56080,
		// Token: 0x04009414 RID: 37908
		[Token(Token = "0x401A966")]
		ORDER_HUD_56081,
		// Token: 0x04009415 RID: 37909
		[Token(Token = "0x401A967")]
		ORDER_HUD_56083,
		// Token: 0x04009416 RID: 37910
		[Token(Token = "0x401A968")]
		ORDER_HUD_56084,
		// Token: 0x04009417 RID: 37911
		[Token(Token = "0x401A969")]
		ORDER_HUD_56085,
		// Token: 0x04009418 RID: 37912
		[Token(Token = "0x401A96A")]
		ORDER_HUD_56086,
		// Token: 0x04009419 RID: 37913
		[Token(Token = "0x401A96B")]
		ORDER_HUD_56087,
		// Token: 0x0400941A RID: 37914
		[Token(Token = "0x401A96C")]
		ORDER_HUD_56088,
		// Token: 0x0400941B RID: 37915
		[Token(Token = "0x401A96D")]
		ORDER_HUD_56089,
		// Token: 0x0400941C RID: 37916
		[Token(Token = "0x401A96E")]
		ORDER_HUD_56090,
		// Token: 0x0400941D RID: 37917
		[Token(Token = "0x401A96F")]
		ORDER_HUD_56091,
		// Token: 0x0400941E RID: 37918
		[Token(Token = "0x401A970")]
		ORDER_HUD_56092,
		// Token: 0x0400941F RID: 37919
		[Token(Token = "0x401A971")]
		ORDER_HUD_56093,
		// Token: 0x04009420 RID: 37920
		[Token(Token = "0x401A972")]
		ORDER_HUD_RAN_10,
		// Token: 0x04009421 RID: 37921
		[Token(Token = "0x401A973")]
		ORDER_HUD_RAN_20,
		// Token: 0x04009422 RID: 37922
		[Token(Token = "0x401A974")]
		ORDER_HUD_RAN_30,
		// Token: 0x04009423 RID: 37923
		[Token(Token = "0x401A975")]
		ORDER_HUD_RAN_40,
		// Token: 0x04009424 RID: 37924
		[Token(Token = "0x401A976")]
		ORDER_HUD_02001,
		// Token: 0x04009425 RID: 37925
		[Token(Token = "0x401A977")]
		ORDER_HUD_02002,
		// Token: 0x04009426 RID: 37926
		[Token(Token = "0x401A978")]
		ORDER_HUD_02003,
		// Token: 0x04009427 RID: 37927
		[Token(Token = "0x401A979")]
		ORDER_HUD_02004,
		// Token: 0x04009428 RID: 37928
		[Token(Token = "0x401A97A")]
		ORDER_HUD_02005,
		// Token: 0x04009429 RID: 37929
		[Token(Token = "0x401A97B")]
		ORDER_HUD_02006,
		// Token: 0x0400942A RID: 37930
		[Token(Token = "0x401A97C")]
		ORDER_HUD_02007,
		// Token: 0x0400942B RID: 37931
		[Token(Token = "0x401A97D")]
		ORDER_HUD_02008,
		// Token: 0x0400942C RID: 37932
		[Token(Token = "0x401A97E")]
		ORDER_HUD_02009,
		// Token: 0x0400942D RID: 37933
		[Token(Token = "0x401A97F")]
		ORDER_HUD_03001,
		// Token: 0x0400942E RID: 37934
		[Token(Token = "0x401A980")]
		ORDER_HUD_03002,
		// Token: 0x0400942F RID: 37935
		[Token(Token = "0x401A981")]
		ORDER_HUD_03003,
		// Token: 0x04009430 RID: 37936
		[Token(Token = "0x401A982")]
		ORDER_HUD_03004,
		// Token: 0x04009431 RID: 37937
		[Token(Token = "0x401A983")]
		ORDER_HUD_03005,
		// Token: 0x04009432 RID: 37938
		[Token(Token = "0x401A984")]
		ORDER_HUD_03006,
		// Token: 0x04009433 RID: 37939
		[Token(Token = "0x401A985")]
		ORDER_HUD_03007,
		// Token: 0x04009434 RID: 37940
		[Token(Token = "0x401A986")]
		ORDER_HUD_03008,
		// Token: 0x04009435 RID: 37941
		[Token(Token = "0x401A987")]
		ORDER_HUD_03009,
		// Token: 0x04009436 RID: 37942
		[Token(Token = "0x401A988")]
		ORDER_HUD_04001,
		// Token: 0x04009437 RID: 37943
		[Token(Token = "0x401A989")]
		ORDER_HUD_04002,
		// Token: 0x04009438 RID: 37944
		[Token(Token = "0x401A98A")]
		ORDER_HUD_04003,
		// Token: 0x04009439 RID: 37945
		[Token(Token = "0x401A98B")]
		ORDER_HUD_04004,
		// Token: 0x0400943A RID: 37946
		[Token(Token = "0x401A98C")]
		ORDER_HUD_04005,
		// Token: 0x0400943B RID: 37947
		[Token(Token = "0x401A98D")]
		ORDER_HUD_04006,
		// Token: 0x0400943C RID: 37948
		[Token(Token = "0x401A98E")]
		ORDER_HUD_04007,
		// Token: 0x0400943D RID: 37949
		[Token(Token = "0x401A98F")]
		ORDER_HUD_04008,
		// Token: 0x0400943E RID: 37950
		[Token(Token = "0x401A990")]
		ORDER_HUD_04009,
		// Token: 0x0400943F RID: 37951
		[Token(Token = "0x401A991")]
		ORDER_HUD_05001,
		// Token: 0x04009440 RID: 37952
		[Token(Token = "0x401A992")]
		ORDER_HUD_05002,
		// Token: 0x04009441 RID: 37953
		[Token(Token = "0x401A993")]
		ORDER_HUD_05003,
		// Token: 0x04009442 RID: 37954
		[Token(Token = "0x401A994")]
		ORDER_HUD_05004,
		// Token: 0x04009443 RID: 37955
		[Token(Token = "0x401A995")]
		ORDER_HUD_05005,
		// Token: 0x04009444 RID: 37956
		[Token(Token = "0x401A996")]
		ORDER_HUD_05006,
		// Token: 0x04009445 RID: 37957
		[Token(Token = "0x401A997")]
		ORDER_HUD_05007,
		// Token: 0x04009446 RID: 37958
		[Token(Token = "0x401A998")]
		ORDER_HUD_05008,
		// Token: 0x04009447 RID: 37959
		[Token(Token = "0x401A999")]
		ORDER_HUD_05009,
		// Token: 0x04009448 RID: 37960
		[Token(Token = "0x401A99A")]
		ORDER_HUD_06001,
		// Token: 0x04009449 RID: 37961
		[Token(Token = "0x401A99B")]
		ORDER_HUD_06002,
		// Token: 0x0400944A RID: 37962
		[Token(Token = "0x401A99C")]
		ORDER_HUD_06003,
		// Token: 0x0400944B RID: 37963
		[Token(Token = "0x401A99D")]
		ORDER_HUD_06004,
		// Token: 0x0400944C RID: 37964
		[Token(Token = "0x401A99E")]
		ORDER_HUD_06005,
		// Token: 0x0400944D RID: 37965
		[Token(Token = "0x401A99F")]
		ORDER_HUD_06006,
		// Token: 0x0400944E RID: 37966
		[Token(Token = "0x401A9A0")]
		ORDER_HUD_06007,
		// Token: 0x0400944F RID: 37967
		[Token(Token = "0x401A9A1")]
		ORDER_HUD_06008,
		// Token: 0x04009450 RID: 37968
		[Token(Token = "0x401A9A2")]
		ORDER_HUD_06009,
		// Token: 0x04009451 RID: 37969
		[Token(Token = "0x401A9A3")]
		ORDER_HUD_07001,
		// Token: 0x04009452 RID: 37970
		[Token(Token = "0x401A9A4")]
		ORDER_HUD_07002,
		// Token: 0x04009453 RID: 37971
		[Token(Token = "0x401A9A5")]
		ORDER_HUD_07003,
		// Token: 0x04009454 RID: 37972
		[Token(Token = "0x401A9A6")]
		ORDER_HUD_07004,
		// Token: 0x04009455 RID: 37973
		[Token(Token = "0x401A9A7")]
		ORDER_HUD_07005,
		// Token: 0x04009456 RID: 37974
		[Token(Token = "0x401A9A8")]
		ORDER_HUD_07006,
		// Token: 0x04009457 RID: 37975
		[Token(Token = "0x401A9A9")]
		ORDER_HUD_07007,
		// Token: 0x04009458 RID: 37976
		[Token(Token = "0x401A9AA")]
		ORDER_HUD_07008,
		// Token: 0x04009459 RID: 37977
		[Token(Token = "0x401A9AB")]
		ORDER_HUD_07009,
		// Token: 0x0400945A RID: 37978
		[Token(Token = "0x401A9AC")]
		ORDER_HUD_08001,
		// Token: 0x0400945B RID: 37979
		[Token(Token = "0x401A9AD")]
		ORDER_HUD_08002,
		// Token: 0x0400945C RID: 37980
		[Token(Token = "0x401A9AE")]
		ORDER_HUD_08003,
		// Token: 0x0400945D RID: 37981
		[Token(Token = "0x401A9AF")]
		ORDER_HUD_08004,
		// Token: 0x0400945E RID: 37982
		[Token(Token = "0x401A9B0")]
		ORDER_HUD_08005,
		// Token: 0x0400945F RID: 37983
		[Token(Token = "0x401A9B1")]
		ORDER_HUD_08006,
		// Token: 0x04009460 RID: 37984
		[Token(Token = "0x401A9B2")]
		ORDER_HUD_08007,
		// Token: 0x04009461 RID: 37985
		[Token(Token = "0x401A9B3")]
		ORDER_HUD_08008,
		// Token: 0x04009462 RID: 37986
		[Token(Token = "0x401A9B4")]
		ORDER_HUD_08009,
		// Token: 0x04009463 RID: 37987
		[Token(Token = "0x401A9B5")]
		ORDER_HUD_09001,
		// Token: 0x04009464 RID: 37988
		[Token(Token = "0x401A9B6")]
		ORDER_HUD_09002,
		// Token: 0x04009465 RID: 37989
		[Token(Token = "0x401A9B7")]
		ORDER_HUD_09003,
		// Token: 0x04009466 RID: 37990
		[Token(Token = "0x401A9B8")]
		ORDER_HUD_09004,
		// Token: 0x04009467 RID: 37991
		[Token(Token = "0x401A9B9")]
		ORDER_HUD_09005,
		// Token: 0x04009468 RID: 37992
		[Token(Token = "0x401A9BA")]
		ORDER_HUD_09006,
		// Token: 0x04009469 RID: 37993
		[Token(Token = "0x401A9BB")]
		ORDER_HUD_09007,
		// Token: 0x0400946A RID: 37994
		[Token(Token = "0x401A9BC")]
		ORDER_HUD_09008,
		// Token: 0x0400946B RID: 37995
		[Token(Token = "0x401A9BD")]
		ORDER_HUD_09009,
		// Token: 0x0400946C RID: 37996
		[Token(Token = "0x401A9BE")]
		ORDER_HUD_10001,
		// Token: 0x0400946D RID: 37997
		[Token(Token = "0x401A9BF")]
		ORDER_HUD_10002,
		// Token: 0x0400946E RID: 37998
		[Token(Token = "0x401A9C0")]
		ORDER_HUD_10003,
		// Token: 0x0400946F RID: 37999
		[Token(Token = "0x401A9C1")]
		ORDER_HUD_10004,
		// Token: 0x04009470 RID: 38000
		[Token(Token = "0x401A9C2")]
		ORDER_HUD_10005,
		// Token: 0x04009471 RID: 38001
		[Token(Token = "0x401A9C3")]
		ORDER_HUD_10006,
		// Token: 0x04009472 RID: 38002
		[Token(Token = "0x401A9C4")]
		ORDER_HUD_10007,
		// Token: 0x04009473 RID: 38003
		[Token(Token = "0x401A9C5")]
		ORDER_HUD_10008,
		// Token: 0x04009474 RID: 38004
		[Token(Token = "0x401A9C6")]
		ORDER_HUD_10009,
		// Token: 0x04009475 RID: 38005
		[Token(Token = "0x401A9C7")]
		ORDER_HUD_11001,
		// Token: 0x04009476 RID: 38006
		[Token(Token = "0x401A9C8")]
		ORDER_HUD_11002,
		// Token: 0x04009477 RID: 38007
		[Token(Token = "0x401A9C9")]
		ORDER_HUD_11003,
		// Token: 0x04009478 RID: 38008
		[Token(Token = "0x401A9CA")]
		ORDER_HUD_11004,
		// Token: 0x04009479 RID: 38009
		[Token(Token = "0x401A9CB")]
		ORDER_HUD_11005,
		// Token: 0x0400947A RID: 38010
		[Token(Token = "0x401A9CC")]
		ORDER_HUD_11006,
		// Token: 0x0400947B RID: 38011
		[Token(Token = "0x401A9CD")]
		ORDER_HUD_11007,
		// Token: 0x0400947C RID: 38012
		[Token(Token = "0x401A9CE")]
		ORDER_HUD_11008,
		// Token: 0x0400947D RID: 38013
		[Token(Token = "0x401A9CF")]
		ORDER_HUD_11009,
		// Token: 0x0400947E RID: 38014
		[Token(Token = "0x401A9D0")]
		ORDER_HUD_12001,
		// Token: 0x0400947F RID: 38015
		[Token(Token = "0x401A9D1")]
		ORDER_HUD_12002,
		// Token: 0x04009480 RID: 38016
		[Token(Token = "0x401A9D2")]
		ORDER_HUD_12003,
		// Token: 0x04009481 RID: 38017
		[Token(Token = "0x401A9D3")]
		ORDER_HUD_12004,
		// Token: 0x04009482 RID: 38018
		[Token(Token = "0x401A9D4")]
		ORDER_HUD_12005,
		// Token: 0x04009483 RID: 38019
		[Token(Token = "0x401A9D5")]
		ORDER_HUD_12006,
		// Token: 0x04009484 RID: 38020
		[Token(Token = "0x401A9D6")]
		ORDER_HUD_12007,
		// Token: 0x04009485 RID: 38021
		[Token(Token = "0x401A9D7")]
		ORDER_HUD_12008,
		// Token: 0x04009486 RID: 38022
		[Token(Token = "0x401A9D8")]
		ORDER_HUD_12009,
		// Token: 0x04009487 RID: 38023
		[Token(Token = "0x401A9D9")]
		ORDER_HUD_13001,
		// Token: 0x04009488 RID: 38024
		[Token(Token = "0x401A9DA")]
		ORDER_HUD_13002,
		// Token: 0x04009489 RID: 38025
		[Token(Token = "0x401A9DB")]
		ORDER_HUD_13003,
		// Token: 0x0400948A RID: 38026
		[Token(Token = "0x401A9DC")]
		ORDER_HUD_13004,
		// Token: 0x0400948B RID: 38027
		[Token(Token = "0x401A9DD")]
		ORDER_HUD_13005,
		// Token: 0x0400948C RID: 38028
		[Token(Token = "0x401A9DE")]
		ORDER_HUD_13006,
		// Token: 0x0400948D RID: 38029
		[Token(Token = "0x401A9DF")]
		ORDER_HUD_14001,
		// Token: 0x0400948E RID: 38030
		[Token(Token = "0x401A9E0")]
		ORDER_HUD_14002,
		// Token: 0x0400948F RID: 38031
		[Token(Token = "0x401A9E1")]
		ORDER_HUD_14003,
		// Token: 0x04009490 RID: 38032
		[Token(Token = "0x401A9E2")]
		ORDER_HUD_14004,
		// Token: 0x04009491 RID: 38033
		[Token(Token = "0x401A9E3")]
		ORDER_HUD_14005,
		// Token: 0x04009492 RID: 38034
		[Token(Token = "0x401A9E4")]
		ORDER_HUD_14006,
		// Token: 0x04009493 RID: 38035
		[Token(Token = "0x401A9E5")]
		ORDER_HUD_15001,
		// Token: 0x04009494 RID: 38036
		[Token(Token = "0x401A9E6")]
		ORDER_HUD_15002,
		// Token: 0x04009495 RID: 38037
		[Token(Token = "0x401A9E7")]
		ORDER_HUD_15003,
		// Token: 0x04009496 RID: 38038
		[Token(Token = "0x401A9E8")]
		ORDER_HUD_15004,
		// Token: 0x04009497 RID: 38039
		[Token(Token = "0x401A9E9")]
		ORDER_HUD_15005,
		// Token: 0x04009498 RID: 38040
		[Token(Token = "0x401A9EA")]
		ORDER_HUD_15006,
		// Token: 0x04009499 RID: 38041
		[Token(Token = "0x401A9EB")]
		ORDER_HUD_16001,
		// Token: 0x0400949A RID: 38042
		[Token(Token = "0x401A9EC")]
		ORDER_HUD_16002,
		// Token: 0x0400949B RID: 38043
		[Token(Token = "0x401A9ED")]
		ORDER_HUD_16003,
		// Token: 0x0400949C RID: 38044
		[Token(Token = "0x401A9EE")]
		ORDER_HUD_16004,
		// Token: 0x0400949D RID: 38045
		[Token(Token = "0x401A9EF")]
		ORDER_HUD_16005,
		// Token: 0x0400949E RID: 38046
		[Token(Token = "0x401A9F0")]
		ORDER_HUD_16006,
		// Token: 0x0400949F RID: 38047
		[Token(Token = "0x401A9F1")]
		ORDER_HUD_17001,
		// Token: 0x040094A0 RID: 38048
		[Token(Token = "0x401A9F2")]
		ORDER_HUD_17002,
		// Token: 0x040094A1 RID: 38049
		[Token(Token = "0x401A9F3")]
		ORDER_HUD_17003,
		// Token: 0x040094A2 RID: 38050
		[Token(Token = "0x401A9F4")]
		ORDER_HUD_17004,
		// Token: 0x040094A3 RID: 38051
		[Token(Token = "0x401A9F5")]
		ORDER_HUD_17005,
		// Token: 0x040094A4 RID: 38052
		[Token(Token = "0x401A9F6")]
		ORDER_HUD_17006,
		// Token: 0x040094A5 RID: 38053
		[Token(Token = "0x401A9F7")]
		ORDER_HUD_18001,
		// Token: 0x040094A6 RID: 38054
		[Token(Token = "0x401A9F8")]
		ORDER_HUD_18002,
		// Token: 0x040094A7 RID: 38055
		[Token(Token = "0x401A9F9")]
		ORDER_HUD_18003,
		// Token: 0x040094A8 RID: 38056
		[Token(Token = "0x401A9FA")]
		ORDER_HUD_18004,
		// Token: 0x040094A9 RID: 38057
		[Token(Token = "0x401A9FB")]
		ORDER_HUD_18005,
		// Token: 0x040094AA RID: 38058
		[Token(Token = "0x401A9FC")]
		ORDER_HUD_18006,
		// Token: 0x040094AB RID: 38059
		[Token(Token = "0x401A9FD")]
		ORDER_HUD_19001,
		// Token: 0x040094AC RID: 38060
		[Token(Token = "0x401A9FE")]
		ORDER_HUD_19002,
		// Token: 0x040094AD RID: 38061
		[Token(Token = "0x401A9FF")]
		ORDER_HUD_19003,
		// Token: 0x040094AE RID: 38062
		[Token(Token = "0x401AA00")]
		ORDER_HUD_19004,
		// Token: 0x040094AF RID: 38063
		[Token(Token = "0x401AA01")]
		ORDER_HUD_19005,
		// Token: 0x040094B0 RID: 38064
		[Token(Token = "0x401AA02")]
		ORDER_HUD_19006,
		// Token: 0x040094B1 RID: 38065
		[Token(Token = "0x401AA03")]
		ORDER_HUD_20001,
		// Token: 0x040094B2 RID: 38066
		[Token(Token = "0x401AA04")]
		ORDER_HUD_20002,
		// Token: 0x040094B3 RID: 38067
		[Token(Token = "0x401AA05")]
		ORDER_HUD_20003,
		// Token: 0x040094B4 RID: 38068
		[Token(Token = "0x401AA06")]
		ORDER_HUD_20004,
		// Token: 0x040094B5 RID: 38069
		[Token(Token = "0x401AA07")]
		ORDER_HUD_20005,
		// Token: 0x040094B6 RID: 38070
		[Token(Token = "0x401AA08")]
		ORDER_HUD_20006,
		// Token: 0x040094B7 RID: 38071
		[Token(Token = "0x401AA09")]
		ORDER_HUD_21001,
		// Token: 0x040094B8 RID: 38072
		[Token(Token = "0x401AA0A")]
		ORDER_HUD_21002,
		// Token: 0x040094B9 RID: 38073
		[Token(Token = "0x401AA0B")]
		ORDER_HUD_21003,
		// Token: 0x040094BA RID: 38074
		[Token(Token = "0x401AA0C")]
		ORDER_HUD_21004,
		// Token: 0x040094BB RID: 38075
		[Token(Token = "0x401AA0D")]
		ORDER_HUD_21005,
		// Token: 0x040094BC RID: 38076
		[Token(Token = "0x401AA0E")]
		ORDER_HUD_21006,
		// Token: 0x040094BD RID: 38077
		[Token(Token = "0x401AA0F")]
		ORDER_HUD_22001,
		// Token: 0x040094BE RID: 38078
		[Token(Token = "0x401AA10")]
		ORDER_HUD_22002,
		// Token: 0x040094BF RID: 38079
		[Token(Token = "0x401AA11")]
		ORDER_HUD_22003,
		// Token: 0x040094C0 RID: 38080
		[Token(Token = "0x401AA12")]
		ORDER_HUD_22004,
		// Token: 0x040094C1 RID: 38081
		[Token(Token = "0x401AA13")]
		ORDER_HUD_22005,
		// Token: 0x040094C2 RID: 38082
		[Token(Token = "0x401AA14")]
		ORDER_HUD_22006,
		// Token: 0x040094C3 RID: 38083
		[Token(Token = "0x401AA15")]
		ORDER_HUD_24001,
		// Token: 0x040094C4 RID: 38084
		[Token(Token = "0x401AA16")]
		ORDER_HUD_24002,
		// Token: 0x040094C5 RID: 38085
		[Token(Token = "0x401AA17")]
		ORDER_HUD_24003,
		// Token: 0x040094C6 RID: 38086
		[Token(Token = "0x401AA18")]
		ORDER_HUD_24004,
		// Token: 0x040094C7 RID: 38087
		[Token(Token = "0x401AA19")]
		ORDER_HUD_24005,
		// Token: 0x040094C8 RID: 38088
		[Token(Token = "0x401AA1A")]
		ORDER_HUD_24006,
		// Token: 0x040094C9 RID: 38089
		[Token(Token = "0x401AA1B")]
		ORDER_HUD_26001,
		// Token: 0x040094CA RID: 38090
		[Token(Token = "0x401AA1C")]
		ORDER_HUD_26002,
		// Token: 0x040094CB RID: 38091
		[Token(Token = "0x401AA1D")]
		ORDER_HUD_26003,
		// Token: 0x040094CC RID: 38092
		[Token(Token = "0x401AA1E")]
		ORDER_HUD_26004,
		// Token: 0x040094CD RID: 38093
		[Token(Token = "0x401AA1F")]
		ORDER_HUD_26005,
		// Token: 0x040094CE RID: 38094
		[Token(Token = "0x401AA20")]
		ORDER_HUD_26006,
		// Token: 0x040094CF RID: 38095
		[Token(Token = "0x401AA21")]
		ORDER_HUD_27001,
		// Token: 0x040094D0 RID: 38096
		[Token(Token = "0x401AA22")]
		ORDER_HUD_27002,
		// Token: 0x040094D1 RID: 38097
		[Token(Token = "0x401AA23")]
		ORDER_HUD_27003,
		// Token: 0x040094D2 RID: 38098
		[Token(Token = "0x401AA24")]
		ORDER_HUD_27004,
		// Token: 0x040094D3 RID: 38099
		[Token(Token = "0x401AA25")]
		ORDER_HUD_27005,
		// Token: 0x040094D4 RID: 38100
		[Token(Token = "0x401AA26")]
		ORDER_HUD_27006,
		// Token: 0x040094D5 RID: 38101
		[Token(Token = "0x401AA27")]
		ORDER_HUD_28001,
		// Token: 0x040094D6 RID: 38102
		[Token(Token = "0x401AA28")]
		ORDER_HUD_28002,
		// Token: 0x040094D7 RID: 38103
		[Token(Token = "0x401AA29")]
		ORDER_HUD_28003,
		// Token: 0x040094D8 RID: 38104
		[Token(Token = "0x401AA2A")]
		ORDER_HUD_28004,
		// Token: 0x040094D9 RID: 38105
		[Token(Token = "0x401AA2B")]
		ORDER_HUD_28005,
		// Token: 0x040094DA RID: 38106
		[Token(Token = "0x401AA2C")]
		ORDER_HUD_28006,
		// Token: 0x040094DB RID: 38107
		[Token(Token = "0x401AA2D")]
		ORDER_HUD_29010,
		// Token: 0x040094DC RID: 38108
		[Token(Token = "0x401AA2E")]
		ORDER_HUD_29011,
		// Token: 0x040094DD RID: 38109
		[Token(Token = "0x401AA2F")]
		ORDER_HUD_29012,
		// Token: 0x040094DE RID: 38110
		[Token(Token = "0x401AA30")]
		ORDER_HUD_29020,
		// Token: 0x040094DF RID: 38111
		[Token(Token = "0x401AA31")]
		ORDER_HUD_29021,
		// Token: 0x040094E0 RID: 38112
		[Token(Token = "0x401AA32")]
		ORDER_HUD_29022,
		// Token: 0x040094E1 RID: 38113
		[Token(Token = "0x401AA33")]
		ORDER_HUD_29030,
		// Token: 0x040094E2 RID: 38114
		[Token(Token = "0x401AA34")]
		ORDER_HUD_29031,
		// Token: 0x040094E3 RID: 38115
		[Token(Token = "0x401AA35")]
		ORDER_HUD_29032,
		// Token: 0x040094E4 RID: 38116
		[Token(Token = "0x401AA36")]
		ORDER_HUD_29040,
		// Token: 0x040094E5 RID: 38117
		[Token(Token = "0x401AA37")]
		ORDER_HUD_29041,
		// Token: 0x040094E6 RID: 38118
		[Token(Token = "0x401AA38")]
		ORDER_HUD_29042,
		// Token: 0x040094E7 RID: 38119
		[Token(Token = "0x401AA39")]
		ORDER_HUD_29050,
		// Token: 0x040094E8 RID: 38120
		[Token(Token = "0x401AA3A")]
		ORDER_HUD_29051,
		// Token: 0x040094E9 RID: 38121
		[Token(Token = "0x401AA3B")]
		ORDER_HUD_29052,
		// Token: 0x040094EA RID: 38122
		[Token(Token = "0x401AA3C")]
		ORDER_HUD_29060,
		// Token: 0x040094EB RID: 38123
		[Token(Token = "0x401AA3D")]
		ORDER_HUD_29061,
		// Token: 0x040094EC RID: 38124
		[Token(Token = "0x401AA3E")]
		ORDER_HUD_29062,
		// Token: 0x040094ED RID: 38125
		[Token(Token = "0x401AA3F")]
		ORDER_HUD_29110,
		// Token: 0x040094EE RID: 38126
		[Token(Token = "0x401AA40")]
		ORDER_HUD_29111,
		// Token: 0x040094EF RID: 38127
		[Token(Token = "0x401AA41")]
		ORDER_HUD_29112,
		// Token: 0x040094F0 RID: 38128
		[Token(Token = "0x401AA42")]
		ORDER_HUD_29120,
		// Token: 0x040094F1 RID: 38129
		[Token(Token = "0x401AA43")]
		ORDER_HUD_29121,
		// Token: 0x040094F2 RID: 38130
		[Token(Token = "0x401AA44")]
		ORDER_HUD_29122,
		// Token: 0x040094F3 RID: 38131
		[Token(Token = "0x401AA45")]
		ORDER_HUD_29130,
		// Token: 0x040094F4 RID: 38132
		[Token(Token = "0x401AA46")]
		ORDER_HUD_29131,
		// Token: 0x040094F5 RID: 38133
		[Token(Token = "0x401AA47")]
		ORDER_HUD_29132,
		// Token: 0x040094F6 RID: 38134
		[Token(Token = "0x401AA48")]
		ORDER_HUD_29140,
		// Token: 0x040094F7 RID: 38135
		[Token(Token = "0x401AA49")]
		ORDER_HUD_29141,
		// Token: 0x040094F8 RID: 38136
		[Token(Token = "0x401AA4A")]
		ORDER_HUD_29142,
		// Token: 0x040094F9 RID: 38137
		[Token(Token = "0x401AA4B")]
		ORDER_HUD_29150,
		// Token: 0x040094FA RID: 38138
		[Token(Token = "0x401AA4C")]
		ORDER_HUD_29151,
		// Token: 0x040094FB RID: 38139
		[Token(Token = "0x401AA4D")]
		ORDER_HUD_29152,
		// Token: 0x040094FC RID: 38140
		[Token(Token = "0x401AA4E")]
		ORDER_HUD_29160,
		// Token: 0x040094FD RID: 38141
		[Token(Token = "0x401AA4F")]
		ORDER_HUD_29161,
		// Token: 0x040094FE RID: 38142
		[Token(Token = "0x401AA50")]
		ORDER_HUD_29162,
		// Token: 0x040094FF RID: 38143
		[Token(Token = "0x401AA51")]
		ORDER_HUD_30010,
		// Token: 0x04009500 RID: 38144
		[Token(Token = "0x401AA52")]
		ORDER_HUD_30011,
		// Token: 0x04009501 RID: 38145
		[Token(Token = "0x401AA53")]
		ORDER_HUD_30012,
		// Token: 0x04009502 RID: 38146
		[Token(Token = "0x401AA54")]
		ORDER_HUD_30020,
		// Token: 0x04009503 RID: 38147
		[Token(Token = "0x401AA55")]
		ORDER_HUD_30021,
		// Token: 0x04009504 RID: 38148
		[Token(Token = "0x401AA56")]
		ORDER_HUD_30022,
		// Token: 0x04009505 RID: 38149
		[Token(Token = "0x401AA57")]
		ORDER_HUD_30030,
		// Token: 0x04009506 RID: 38150
		[Token(Token = "0x401AA58")]
		ORDER_HUD_30031,
		// Token: 0x04009507 RID: 38151
		[Token(Token = "0x401AA59")]
		ORDER_HUD_30032,
		// Token: 0x04009508 RID: 38152
		[Token(Token = "0x401AA5A")]
		ORDER_HUD_30040,
		// Token: 0x04009509 RID: 38153
		[Token(Token = "0x401AA5B")]
		ORDER_HUD_30041,
		// Token: 0x0400950A RID: 38154
		[Token(Token = "0x401AA5C")]
		ORDER_HUD_30042,
		// Token: 0x0400950B RID: 38155
		[Token(Token = "0x401AA5D")]
		ORDER_HUD_30050,
		// Token: 0x0400950C RID: 38156
		[Token(Token = "0x401AA5E")]
		ORDER_HUD_30051,
		// Token: 0x0400950D RID: 38157
		[Token(Token = "0x401AA5F")]
		ORDER_HUD_30052,
		// Token: 0x0400950E RID: 38158
		[Token(Token = "0x401AA60")]
		ORDER_HUD_30060,
		// Token: 0x0400950F RID: 38159
		[Token(Token = "0x401AA61")]
		ORDER_HUD_30061,
		// Token: 0x04009510 RID: 38160
		[Token(Token = "0x401AA62")]
		ORDER_HUD_30062,
		// Token: 0x04009511 RID: 38161
		[Token(Token = "0x401AA63")]
		ORDER_HUD_31010,
		// Token: 0x04009512 RID: 38162
		[Token(Token = "0x401AA64")]
		ORDER_HUD_31011,
		// Token: 0x04009513 RID: 38163
		[Token(Token = "0x401AA65")]
		ORDER_HUD_31012,
		// Token: 0x04009514 RID: 38164
		[Token(Token = "0x401AA66")]
		ORDER_HUD_31020,
		// Token: 0x04009515 RID: 38165
		[Token(Token = "0x401AA67")]
		ORDER_HUD_31021,
		// Token: 0x04009516 RID: 38166
		[Token(Token = "0x401AA68")]
		ORDER_HUD_31022,
		// Token: 0x04009517 RID: 38167
		[Token(Token = "0x401AA69")]
		ORDER_HUD_31030,
		// Token: 0x04009518 RID: 38168
		[Token(Token = "0x401AA6A")]
		ORDER_HUD_31031,
		// Token: 0x04009519 RID: 38169
		[Token(Token = "0x401AA6B")]
		ORDER_HUD_31032,
		// Token: 0x0400951A RID: 38170
		[Token(Token = "0x401AA6C")]
		ORDER_HUD_31040,
		// Token: 0x0400951B RID: 38171
		[Token(Token = "0x401AA6D")]
		ORDER_HUD_31041,
		// Token: 0x0400951C RID: 38172
		[Token(Token = "0x401AA6E")]
		ORDER_HUD_31042,
		// Token: 0x0400951D RID: 38173
		[Token(Token = "0x401AA6F")]
		ORDER_HUD_31050,
		// Token: 0x0400951E RID: 38174
		[Token(Token = "0x401AA70")]
		ORDER_HUD_31051,
		// Token: 0x0400951F RID: 38175
		[Token(Token = "0x401AA71")]
		ORDER_HUD_31052,
		// Token: 0x04009520 RID: 38176
		[Token(Token = "0x401AA72")]
		ORDER_HUD_31060,
		// Token: 0x04009521 RID: 38177
		[Token(Token = "0x401AA73")]
		ORDER_HUD_31061,
		// Token: 0x04009522 RID: 38178
		[Token(Token = "0x401AA74")]
		ORDER_HUD_31062,
		// Token: 0x04009523 RID: 38179
		[Token(Token = "0x401AA75")]
		ORDER_HUD_32001,
		// Token: 0x04009524 RID: 38180
		[Token(Token = "0x401AA76")]
		ORDER_HUD_32002,
		// Token: 0x04009525 RID: 38181
		[Token(Token = "0x401AA77")]
		ORDER_HUD_32003,
		// Token: 0x04009526 RID: 38182
		[Token(Token = "0x401AA78")]
		ORDER_HUD_32004,
		// Token: 0x04009527 RID: 38183
		[Token(Token = "0x401AA79")]
		ORDER_HUD_32005,
		// Token: 0x04009528 RID: 38184
		[Token(Token = "0x401AA7A")]
		ORDER_HUD_32006,
		// Token: 0x04009529 RID: 38185
		[Token(Token = "0x401AA7B")]
		ORDER_HUD_33001,
		// Token: 0x0400952A RID: 38186
		[Token(Token = "0x401AA7C")]
		ORDER_HUD_33002,
		// Token: 0x0400952B RID: 38187
		[Token(Token = "0x401AA7D")]
		ORDER_HUD_33003,
		// Token: 0x0400952C RID: 38188
		[Token(Token = "0x401AA7E")]
		ORDER_HUD_33004,
		// Token: 0x0400952D RID: 38189
		[Token(Token = "0x401AA7F")]
		ORDER_HUD_33005,
		// Token: 0x0400952E RID: 38190
		[Token(Token = "0x401AA80")]
		ORDER_HUD_33006,
		// Token: 0x0400952F RID: 38191
		[Token(Token = "0x401AA81")]
		ORDER_REWARD_56001 = 106000,
		// Token: 0x04009530 RID: 38192
		[Token(Token = "0x401AA82")]
		ORDER_REWARD_56002,
		// Token: 0x04009531 RID: 38193
		[Token(Token = "0x401AA83")]
		ORDER_REWARD_56003,
		// Token: 0x04009532 RID: 38194
		[Token(Token = "0x401AA84")]
		ORDER_REWARD_56004,
		// Token: 0x04009533 RID: 38195
		[Token(Token = "0x401AA85")]
		ORDER_REWARD_56005,
		// Token: 0x04009534 RID: 38196
		[Token(Token = "0x401AA86")]
		ORDER_REWARD_56006,
		// Token: 0x04009535 RID: 38197
		[Token(Token = "0x401AA87")]
		ORDER_REWARD_56007,
		// Token: 0x04009536 RID: 38198
		[Token(Token = "0x401AA88")]
		ORDER_REWARD_56008,
		// Token: 0x04009537 RID: 38199
		[Token(Token = "0x401AA89")]
		ORDER_REWARD_56009,
		// Token: 0x04009538 RID: 38200
		[Token(Token = "0x401AA8A")]
		ORDER_REWARD_56010,
		// Token: 0x04009539 RID: 38201
		[Token(Token = "0x401AA8B")]
		ORDER_REWARD_56011,
		// Token: 0x0400953A RID: 38202
		[Token(Token = "0x401AA8C")]
		ORDER_REWARD_56012,
		// Token: 0x0400953B RID: 38203
		[Token(Token = "0x401AA8D")]
		ORDER_REWARD_56013,
		// Token: 0x0400953C RID: 38204
		[Token(Token = "0x401AA8E")]
		ORDER_REWARD_56014,
		// Token: 0x0400953D RID: 38205
		[Token(Token = "0x401AA8F")]
		ORDER_REWARD_56015,
		// Token: 0x0400953E RID: 38206
		[Token(Token = "0x401AA90")]
		ORDER_REWARD_56016,
		// Token: 0x0400953F RID: 38207
		[Token(Token = "0x401AA91")]
		ORDER_REWARD_56017,
		// Token: 0x04009540 RID: 38208
		[Token(Token = "0x401AA92")]
		ORDER_REWARD_56018,
		// Token: 0x04009541 RID: 38209
		[Token(Token = "0x401AA93")]
		ORDER_REWARD_56019,
		// Token: 0x04009542 RID: 38210
		[Token(Token = "0x401AA94")]
		ORDER_REWARD_56020,
		// Token: 0x04009543 RID: 38211
		[Token(Token = "0x401AA95")]
		ORDER_REWARD_56021,
		// Token: 0x04009544 RID: 38212
		[Token(Token = "0x401AA96")]
		ORDER_REWARD_56022,
		// Token: 0x04009545 RID: 38213
		[Token(Token = "0x401AA97")]
		ORDER_REWARD_56023,
		// Token: 0x04009546 RID: 38214
		[Token(Token = "0x401AA98")]
		ORDER_REWARD_56024,
		// Token: 0x04009547 RID: 38215
		[Token(Token = "0x401AA99")]
		ORDER_REWARD_56025,
		// Token: 0x04009548 RID: 38216
		[Token(Token = "0x401AA9A")]
		ORDER_REWARD_56026,
		// Token: 0x04009549 RID: 38217
		[Token(Token = "0x401AA9B")]
		ORDER_REWARD_56027,
		// Token: 0x0400954A RID: 38218
		[Token(Token = "0x401AA9C")]
		ORDER_REWARD_56028,
		// Token: 0x0400954B RID: 38219
		[Token(Token = "0x401AA9D")]
		ORDER_REWARD_56029,
		// Token: 0x0400954C RID: 38220
		[Token(Token = "0x401AA9E")]
		ORDER_REWARD_56030,
		// Token: 0x0400954D RID: 38221
		[Token(Token = "0x401AA9F")]
		ORDER_REWARD_56031,
		// Token: 0x0400954E RID: 38222
		[Token(Token = "0x401AAA0")]
		ORDER_REWARD_56032,
		// Token: 0x0400954F RID: 38223
		[Token(Token = "0x401AAA1")]
		ORDER_REWARD_56033,
		// Token: 0x04009550 RID: 38224
		[Token(Token = "0x401AAA2")]
		ORDER_REWARD_56034,
		// Token: 0x04009551 RID: 38225
		[Token(Token = "0x401AAA3")]
		ORDER_REWARD_56035,
		// Token: 0x04009552 RID: 38226
		[Token(Token = "0x401AAA4")]
		ORDER_REWARD_56036,
		// Token: 0x04009553 RID: 38227
		[Token(Token = "0x401AAA5")]
		ORDER_REWARD_56037,
		// Token: 0x04009554 RID: 38228
		[Token(Token = "0x401AAA6")]
		ORDER_REWARD_56038,
		// Token: 0x04009555 RID: 38229
		[Token(Token = "0x401AAA7")]
		ORDER_REWARD_56039,
		// Token: 0x04009556 RID: 38230
		[Token(Token = "0x401AAA8")]
		ORDER_REWARD_56040,
		// Token: 0x04009557 RID: 38231
		[Token(Token = "0x401AAA9")]
		ORDER_REWARD_56041,
		// Token: 0x04009558 RID: 38232
		[Token(Token = "0x401AAAA")]
		ORDER_REWARD_56042,
		// Token: 0x04009559 RID: 38233
		[Token(Token = "0x401AAAB")]
		ORDER_REWARD_56043,
		// Token: 0x0400955A RID: 38234
		[Token(Token = "0x401AAAC")]
		ORDER_REWARD_56044,
		// Token: 0x0400955B RID: 38235
		[Token(Token = "0x401AAAD")]
		ORDER_REWARD_56045,
		// Token: 0x0400955C RID: 38236
		[Token(Token = "0x401AAAE")]
		ORDER_REWARD_56046,
		// Token: 0x0400955D RID: 38237
		[Token(Token = "0x401AAAF")]
		ORDER_REWARD_56047,
		// Token: 0x0400955E RID: 38238
		[Token(Token = "0x401AAB0")]
		ORDER_REWARD_56048,
		// Token: 0x0400955F RID: 38239
		[Token(Token = "0x401AAB1")]
		ORDER_REWARD_56049,
		// Token: 0x04009560 RID: 38240
		[Token(Token = "0x401AAB2")]
		ORDER_REWARD_56050,
		// Token: 0x04009561 RID: 38241
		[Token(Token = "0x401AAB3")]
		ORDER_REWARD_56051,
		// Token: 0x04009562 RID: 38242
		[Token(Token = "0x401AAB4")]
		ORDER_REWARD_56052,
		// Token: 0x04009563 RID: 38243
		[Token(Token = "0x401AAB5")]
		ORDER_REWARD_56053,
		// Token: 0x04009564 RID: 38244
		[Token(Token = "0x401AAB6")]
		ORDER_REWARD_56054,
		// Token: 0x04009565 RID: 38245
		[Token(Token = "0x401AAB7")]
		ORDER_REWARD_56055,
		// Token: 0x04009566 RID: 38246
		[Token(Token = "0x401AAB8")]
		ORDER_REWARD_56056,
		// Token: 0x04009567 RID: 38247
		[Token(Token = "0x401AAB9")]
		ORDER_REWARD_56057,
		// Token: 0x04009568 RID: 38248
		[Token(Token = "0x401AABA")]
		ORDER_REWARD_56058,
		// Token: 0x04009569 RID: 38249
		[Token(Token = "0x401AABB")]
		ORDER_REWARD_56059,
		// Token: 0x0400956A RID: 38250
		[Token(Token = "0x401AABC")]
		ORDER_REWARD_56060,
		// Token: 0x0400956B RID: 38251
		[Token(Token = "0x401AABD")]
		ORDER_REWARD_56061,
		// Token: 0x0400956C RID: 38252
		[Token(Token = "0x401AABE")]
		ORDER_REWARD_56062,
		// Token: 0x0400956D RID: 38253
		[Token(Token = "0x401AABF")]
		ORDER_REWARD_56063,
		// Token: 0x0400956E RID: 38254
		[Token(Token = "0x401AAC0")]
		ORDER_REWARD_56064,
		// Token: 0x0400956F RID: 38255
		[Token(Token = "0x401AAC1")]
		ORDER_REWARD_56065,
		// Token: 0x04009570 RID: 38256
		[Token(Token = "0x401AAC2")]
		ORDER_REWARD_56066,
		// Token: 0x04009571 RID: 38257
		[Token(Token = "0x401AAC3")]
		ORDER_REWARD_56067,
		// Token: 0x04009572 RID: 38258
		[Token(Token = "0x401AAC4")]
		ORDER_REWARD_56068,
		// Token: 0x04009573 RID: 38259
		[Token(Token = "0x401AAC5")]
		ORDER_REWARD_56069,
		// Token: 0x04009574 RID: 38260
		[Token(Token = "0x401AAC6")]
		ORDER_REWARD_56070,
		// Token: 0x04009575 RID: 38261
		[Token(Token = "0x401AAC7")]
		ORDER_REWARD_56071,
		// Token: 0x04009576 RID: 38262
		[Token(Token = "0x401AAC8")]
		ORDER_REWARD_56072,
		// Token: 0x04009577 RID: 38263
		[Token(Token = "0x401AAC9")]
		ORDER_REWARD_56073,
		// Token: 0x04009578 RID: 38264
		[Token(Token = "0x401AACA")]
		ORDER_REWARD_56074,
		// Token: 0x04009579 RID: 38265
		[Token(Token = "0x401AACB")]
		ORDER_REWARD_56075,
		// Token: 0x0400957A RID: 38266
		[Token(Token = "0x401AACC")]
		ORDER_REWARD_56076,
		// Token: 0x0400957B RID: 38267
		[Token(Token = "0x401AACD")]
		ORDER_REWARD_56077,
		// Token: 0x0400957C RID: 38268
		[Token(Token = "0x401AACE")]
		ORDER_REWARD_56078,
		// Token: 0x0400957D RID: 38269
		[Token(Token = "0x401AACF")]
		ORDER_REWARD_56079,
		// Token: 0x0400957E RID: 38270
		[Token(Token = "0x401AAD0")]
		ORDER_REWARD_56080,
		// Token: 0x0400957F RID: 38271
		[Token(Token = "0x401AAD1")]
		ORDER_REWARD_56081,
		// Token: 0x04009580 RID: 38272
		[Token(Token = "0x401AAD2")]
		ORDER_REWARD_56083,
		// Token: 0x04009581 RID: 38273
		[Token(Token = "0x401AAD3")]
		ORDER_REWARD_56084,
		// Token: 0x04009582 RID: 38274
		[Token(Token = "0x401AAD4")]
		ORDER_REWARD_56085,
		// Token: 0x04009583 RID: 38275
		[Token(Token = "0x401AAD5")]
		ORDER_REWARD_56086,
		// Token: 0x04009584 RID: 38276
		[Token(Token = "0x401AAD6")]
		ORDER_REWARD_56087,
		// Token: 0x04009585 RID: 38277
		[Token(Token = "0x401AAD7")]
		ORDER_REWARD_56088,
		// Token: 0x04009586 RID: 38278
		[Token(Token = "0x401AAD8")]
		ORDER_REWARD_56089,
		// Token: 0x04009587 RID: 38279
		[Token(Token = "0x401AAD9")]
		ORDER_REWARD_56090,
		// Token: 0x04009588 RID: 38280
		[Token(Token = "0x401AADA")]
		ORDER_REWARD_56091,
		// Token: 0x04009589 RID: 38281
		[Token(Token = "0x401AADB")]
		ORDER_REWARD_56092,
		// Token: 0x0400958A RID: 38282
		[Token(Token = "0x401AADC")]
		ORDER_REWARD_56093,
		// Token: 0x0400958B RID: 38283
		[Token(Token = "0x401AADD")]
		ORDER_REWARD_RAN_10,
		// Token: 0x0400958C RID: 38284
		[Token(Token = "0x401AADE")]
		ORDER_REWARD_RAN_20,
		// Token: 0x0400958D RID: 38285
		[Token(Token = "0x401AADF")]
		ORDER_REWARD_RAN_30,
		// Token: 0x0400958E RID: 38286
		[Token(Token = "0x401AAE0")]
		ORDER_REWARD_RAN_40,
		// Token: 0x0400958F RID: 38287
		[Token(Token = "0x401AAE1")]
		ORDER_REWARD_02001,
		// Token: 0x04009590 RID: 38288
		[Token(Token = "0x401AAE2")]
		ORDER_REWARD_02002,
		// Token: 0x04009591 RID: 38289
		[Token(Token = "0x401AAE3")]
		ORDER_REWARD_02003,
		// Token: 0x04009592 RID: 38290
		[Token(Token = "0x401AAE4")]
		ORDER_REWARD_02004,
		// Token: 0x04009593 RID: 38291
		[Token(Token = "0x401AAE5")]
		ORDER_REWARD_02005,
		// Token: 0x04009594 RID: 38292
		[Token(Token = "0x401AAE6")]
		ORDER_REWARD_02006,
		// Token: 0x04009595 RID: 38293
		[Token(Token = "0x401AAE7")]
		ORDER_REWARD_02007,
		// Token: 0x04009596 RID: 38294
		[Token(Token = "0x401AAE8")]
		ORDER_REWARD_02008,
		// Token: 0x04009597 RID: 38295
		[Token(Token = "0x401AAE9")]
		ORDER_REWARD_02009,
		// Token: 0x04009598 RID: 38296
		[Token(Token = "0x401AAEA")]
		ORDER_REWARD_03001,
		// Token: 0x04009599 RID: 38297
		[Token(Token = "0x401AAEB")]
		ORDER_REWARD_03002,
		// Token: 0x0400959A RID: 38298
		[Token(Token = "0x401AAEC")]
		ORDER_REWARD_03003,
		// Token: 0x0400959B RID: 38299
		[Token(Token = "0x401AAED")]
		ORDER_REWARD_03004,
		// Token: 0x0400959C RID: 38300
		[Token(Token = "0x401AAEE")]
		ORDER_REWARD_03005,
		// Token: 0x0400959D RID: 38301
		[Token(Token = "0x401AAEF")]
		ORDER_REWARD_03006,
		// Token: 0x0400959E RID: 38302
		[Token(Token = "0x401AAF0")]
		ORDER_REWARD_03007,
		// Token: 0x0400959F RID: 38303
		[Token(Token = "0x401AAF1")]
		ORDER_REWARD_03008,
		// Token: 0x040095A0 RID: 38304
		[Token(Token = "0x401AAF2")]
		ORDER_REWARD_03009,
		// Token: 0x040095A1 RID: 38305
		[Token(Token = "0x401AAF3")]
		ORDER_REWARD_04001,
		// Token: 0x040095A2 RID: 38306
		[Token(Token = "0x401AAF4")]
		ORDER_REWARD_04002,
		// Token: 0x040095A3 RID: 38307
		[Token(Token = "0x401AAF5")]
		ORDER_REWARD_04003,
		// Token: 0x040095A4 RID: 38308
		[Token(Token = "0x401AAF6")]
		ORDER_REWARD_04004,
		// Token: 0x040095A5 RID: 38309
		[Token(Token = "0x401AAF7")]
		ORDER_REWARD_04005,
		// Token: 0x040095A6 RID: 38310
		[Token(Token = "0x401AAF8")]
		ORDER_REWARD_04006,
		// Token: 0x040095A7 RID: 38311
		[Token(Token = "0x401AAF9")]
		ORDER_REWARD_04007,
		// Token: 0x040095A8 RID: 38312
		[Token(Token = "0x401AAFA")]
		ORDER_REWARD_04008,
		// Token: 0x040095A9 RID: 38313
		[Token(Token = "0x401AAFB")]
		ORDER_REWARD_04009,
		// Token: 0x040095AA RID: 38314
		[Token(Token = "0x401AAFC")]
		ORDER_REWARD_05001,
		// Token: 0x040095AB RID: 38315
		[Token(Token = "0x401AAFD")]
		ORDER_REWARD_05002,
		// Token: 0x040095AC RID: 38316
		[Token(Token = "0x401AAFE")]
		ORDER_REWARD_05003,
		// Token: 0x040095AD RID: 38317
		[Token(Token = "0x401AAFF")]
		ORDER_REWARD_05004,
		// Token: 0x040095AE RID: 38318
		[Token(Token = "0x401AB00")]
		ORDER_REWARD_05005,
		// Token: 0x040095AF RID: 38319
		[Token(Token = "0x401AB01")]
		ORDER_REWARD_05006,
		// Token: 0x040095B0 RID: 38320
		[Token(Token = "0x401AB02")]
		ORDER_REWARD_05007,
		// Token: 0x040095B1 RID: 38321
		[Token(Token = "0x401AB03")]
		ORDER_REWARD_05008,
		// Token: 0x040095B2 RID: 38322
		[Token(Token = "0x401AB04")]
		ORDER_REWARD_05009,
		// Token: 0x040095B3 RID: 38323
		[Token(Token = "0x401AB05")]
		ORDER_REWARD_06001,
		// Token: 0x040095B4 RID: 38324
		[Token(Token = "0x401AB06")]
		ORDER_REWARD_06002,
		// Token: 0x040095B5 RID: 38325
		[Token(Token = "0x401AB07")]
		ORDER_REWARD_06003,
		// Token: 0x040095B6 RID: 38326
		[Token(Token = "0x401AB08")]
		ORDER_REWARD_06004,
		// Token: 0x040095B7 RID: 38327
		[Token(Token = "0x401AB09")]
		ORDER_REWARD_06005,
		// Token: 0x040095B8 RID: 38328
		[Token(Token = "0x401AB0A")]
		ORDER_REWARD_06006,
		// Token: 0x040095B9 RID: 38329
		[Token(Token = "0x401AB0B")]
		ORDER_REWARD_06007,
		// Token: 0x040095BA RID: 38330
		[Token(Token = "0x401AB0C")]
		ORDER_REWARD_06008,
		// Token: 0x040095BB RID: 38331
		[Token(Token = "0x401AB0D")]
		ORDER_REWARD_06009,
		// Token: 0x040095BC RID: 38332
		[Token(Token = "0x401AB0E")]
		ORDER_REWARD_07001,
		// Token: 0x040095BD RID: 38333
		[Token(Token = "0x401AB0F")]
		ORDER_REWARD_07002,
		// Token: 0x040095BE RID: 38334
		[Token(Token = "0x401AB10")]
		ORDER_REWARD_07003,
		// Token: 0x040095BF RID: 38335
		[Token(Token = "0x401AB11")]
		ORDER_REWARD_07004,
		// Token: 0x040095C0 RID: 38336
		[Token(Token = "0x401AB12")]
		ORDER_REWARD_07005,
		// Token: 0x040095C1 RID: 38337
		[Token(Token = "0x401AB13")]
		ORDER_REWARD_07006,
		// Token: 0x040095C2 RID: 38338
		[Token(Token = "0x401AB14")]
		ORDER_REWARD_07007,
		// Token: 0x040095C3 RID: 38339
		[Token(Token = "0x401AB15")]
		ORDER_REWARD_07008,
		// Token: 0x040095C4 RID: 38340
		[Token(Token = "0x401AB16")]
		ORDER_REWARD_07009,
		// Token: 0x040095C5 RID: 38341
		[Token(Token = "0x401AB17")]
		ORDER_REWARD_08001,
		// Token: 0x040095C6 RID: 38342
		[Token(Token = "0x401AB18")]
		ORDER_REWARD_08002,
		// Token: 0x040095C7 RID: 38343
		[Token(Token = "0x401AB19")]
		ORDER_REWARD_08003,
		// Token: 0x040095C8 RID: 38344
		[Token(Token = "0x401AB1A")]
		ORDER_REWARD_08004,
		// Token: 0x040095C9 RID: 38345
		[Token(Token = "0x401AB1B")]
		ORDER_REWARD_08005,
		// Token: 0x040095CA RID: 38346
		[Token(Token = "0x401AB1C")]
		ORDER_REWARD_08006,
		// Token: 0x040095CB RID: 38347
		[Token(Token = "0x401AB1D")]
		ORDER_REWARD_08007,
		// Token: 0x040095CC RID: 38348
		[Token(Token = "0x401AB1E")]
		ORDER_REWARD_08008,
		// Token: 0x040095CD RID: 38349
		[Token(Token = "0x401AB1F")]
		ORDER_REWARD_08009,
		// Token: 0x040095CE RID: 38350
		[Token(Token = "0x401AB20")]
		ORDER_REWARD_09001,
		// Token: 0x040095CF RID: 38351
		[Token(Token = "0x401AB21")]
		ORDER_REWARD_09002,
		// Token: 0x040095D0 RID: 38352
		[Token(Token = "0x401AB22")]
		ORDER_REWARD_09003,
		// Token: 0x040095D1 RID: 38353
		[Token(Token = "0x401AB23")]
		ORDER_REWARD_09004,
		// Token: 0x040095D2 RID: 38354
		[Token(Token = "0x401AB24")]
		ORDER_REWARD_09005,
		// Token: 0x040095D3 RID: 38355
		[Token(Token = "0x401AB25")]
		ORDER_REWARD_09006,
		// Token: 0x040095D4 RID: 38356
		[Token(Token = "0x401AB26")]
		ORDER_REWARD_09007,
		// Token: 0x040095D5 RID: 38357
		[Token(Token = "0x401AB27")]
		ORDER_REWARD_09008,
		// Token: 0x040095D6 RID: 38358
		[Token(Token = "0x401AB28")]
		ORDER_REWARD_09009,
		// Token: 0x040095D7 RID: 38359
		[Token(Token = "0x401AB29")]
		ORDER_REWARD_10001,
		// Token: 0x040095D8 RID: 38360
		[Token(Token = "0x401AB2A")]
		ORDER_REWARD_10002,
		// Token: 0x040095D9 RID: 38361
		[Token(Token = "0x401AB2B")]
		ORDER_REWARD_10003,
		// Token: 0x040095DA RID: 38362
		[Token(Token = "0x401AB2C")]
		ORDER_REWARD_10004,
		// Token: 0x040095DB RID: 38363
		[Token(Token = "0x401AB2D")]
		ORDER_REWARD_10005,
		// Token: 0x040095DC RID: 38364
		[Token(Token = "0x401AB2E")]
		ORDER_REWARD_10006,
		// Token: 0x040095DD RID: 38365
		[Token(Token = "0x401AB2F")]
		ORDER_REWARD_10007,
		// Token: 0x040095DE RID: 38366
		[Token(Token = "0x401AB30")]
		ORDER_REWARD_10008,
		// Token: 0x040095DF RID: 38367
		[Token(Token = "0x401AB31")]
		ORDER_REWARD_10009,
		// Token: 0x040095E0 RID: 38368
		[Token(Token = "0x401AB32")]
		ORDER_REWARD_11001,
		// Token: 0x040095E1 RID: 38369
		[Token(Token = "0x401AB33")]
		ORDER_REWARD_11002,
		// Token: 0x040095E2 RID: 38370
		[Token(Token = "0x401AB34")]
		ORDER_REWARD_11003,
		// Token: 0x040095E3 RID: 38371
		[Token(Token = "0x401AB35")]
		ORDER_REWARD_11004,
		// Token: 0x040095E4 RID: 38372
		[Token(Token = "0x401AB36")]
		ORDER_REWARD_11005,
		// Token: 0x040095E5 RID: 38373
		[Token(Token = "0x401AB37")]
		ORDER_REWARD_11006,
		// Token: 0x040095E6 RID: 38374
		[Token(Token = "0x401AB38")]
		ORDER_REWARD_11007,
		// Token: 0x040095E7 RID: 38375
		[Token(Token = "0x401AB39")]
		ORDER_REWARD_11008,
		// Token: 0x040095E8 RID: 38376
		[Token(Token = "0x401AB3A")]
		ORDER_REWARD_11009,
		// Token: 0x040095E9 RID: 38377
		[Token(Token = "0x401AB3B")]
		ORDER_REWARD_12001,
		// Token: 0x040095EA RID: 38378
		[Token(Token = "0x401AB3C")]
		ORDER_REWARD_12002,
		// Token: 0x040095EB RID: 38379
		[Token(Token = "0x401AB3D")]
		ORDER_REWARD_12003,
		// Token: 0x040095EC RID: 38380
		[Token(Token = "0x401AB3E")]
		ORDER_REWARD_12004,
		// Token: 0x040095ED RID: 38381
		[Token(Token = "0x401AB3F")]
		ORDER_REWARD_12005,
		// Token: 0x040095EE RID: 38382
		[Token(Token = "0x401AB40")]
		ORDER_REWARD_12006,
		// Token: 0x040095EF RID: 38383
		[Token(Token = "0x401AB41")]
		ORDER_REWARD_12007,
		// Token: 0x040095F0 RID: 38384
		[Token(Token = "0x401AB42")]
		ORDER_REWARD_12008,
		// Token: 0x040095F1 RID: 38385
		[Token(Token = "0x401AB43")]
		ORDER_REWARD_12009,
		// Token: 0x040095F2 RID: 38386
		[Token(Token = "0x401AB44")]
		ORDER_REWARD_13001,
		// Token: 0x040095F3 RID: 38387
		[Token(Token = "0x401AB45")]
		ORDER_REWARD_13002,
		// Token: 0x040095F4 RID: 38388
		[Token(Token = "0x401AB46")]
		ORDER_REWARD_13003,
		// Token: 0x040095F5 RID: 38389
		[Token(Token = "0x401AB47")]
		ORDER_REWARD_13004,
		// Token: 0x040095F6 RID: 38390
		[Token(Token = "0x401AB48")]
		ORDER_REWARD_13005,
		// Token: 0x040095F7 RID: 38391
		[Token(Token = "0x401AB49")]
		ORDER_REWARD_13006,
		// Token: 0x040095F8 RID: 38392
		[Token(Token = "0x401AB4A")]
		ORDER_REWARD_14001,
		// Token: 0x040095F9 RID: 38393
		[Token(Token = "0x401AB4B")]
		ORDER_REWARD_14002,
		// Token: 0x040095FA RID: 38394
		[Token(Token = "0x401AB4C")]
		ORDER_REWARD_14003,
		// Token: 0x040095FB RID: 38395
		[Token(Token = "0x401AB4D")]
		ORDER_REWARD_14004,
		// Token: 0x040095FC RID: 38396
		[Token(Token = "0x401AB4E")]
		ORDER_REWARD_14005,
		// Token: 0x040095FD RID: 38397
		[Token(Token = "0x401AB4F")]
		ORDER_REWARD_14006,
		// Token: 0x040095FE RID: 38398
		[Token(Token = "0x401AB50")]
		ORDER_REWARD_15001,
		// Token: 0x040095FF RID: 38399
		[Token(Token = "0x401AB51")]
		ORDER_REWARD_15002,
		// Token: 0x04009600 RID: 38400
		[Token(Token = "0x401AB52")]
		ORDER_REWARD_15003,
		// Token: 0x04009601 RID: 38401
		[Token(Token = "0x401AB53")]
		ORDER_REWARD_15004,
		// Token: 0x04009602 RID: 38402
		[Token(Token = "0x401AB54")]
		ORDER_REWARD_15005,
		// Token: 0x04009603 RID: 38403
		[Token(Token = "0x401AB55")]
		ORDER_REWARD_15006,
		// Token: 0x04009604 RID: 38404
		[Token(Token = "0x401AB56")]
		ORDER_REWARD_16001,
		// Token: 0x04009605 RID: 38405
		[Token(Token = "0x401AB57")]
		ORDER_REWARD_16002,
		// Token: 0x04009606 RID: 38406
		[Token(Token = "0x401AB58")]
		ORDER_REWARD_16003,
		// Token: 0x04009607 RID: 38407
		[Token(Token = "0x401AB59")]
		ORDER_REWARD_16004,
		// Token: 0x04009608 RID: 38408
		[Token(Token = "0x401AB5A")]
		ORDER_REWARD_16005,
		// Token: 0x04009609 RID: 38409
		[Token(Token = "0x401AB5B")]
		ORDER_REWARD_16006,
		// Token: 0x0400960A RID: 38410
		[Token(Token = "0x401AB5C")]
		ORDER_REWARD_17001,
		// Token: 0x0400960B RID: 38411
		[Token(Token = "0x401AB5D")]
		ORDER_REWARD_17002,
		// Token: 0x0400960C RID: 38412
		[Token(Token = "0x401AB5E")]
		ORDER_REWARD_17003,
		// Token: 0x0400960D RID: 38413
		[Token(Token = "0x401AB5F")]
		ORDER_REWARD_17004,
		// Token: 0x0400960E RID: 38414
		[Token(Token = "0x401AB60")]
		ORDER_REWARD_17005,
		// Token: 0x0400960F RID: 38415
		[Token(Token = "0x401AB61")]
		ORDER_REWARD_17006,
		// Token: 0x04009610 RID: 38416
		[Token(Token = "0x401AB62")]
		ORDER_REWARD_18001,
		// Token: 0x04009611 RID: 38417
		[Token(Token = "0x401AB63")]
		ORDER_REWARD_18002,
		// Token: 0x04009612 RID: 38418
		[Token(Token = "0x401AB64")]
		ORDER_REWARD_18003,
		// Token: 0x04009613 RID: 38419
		[Token(Token = "0x401AB65")]
		ORDER_REWARD_18004,
		// Token: 0x04009614 RID: 38420
		[Token(Token = "0x401AB66")]
		ORDER_REWARD_18005,
		// Token: 0x04009615 RID: 38421
		[Token(Token = "0x401AB67")]
		ORDER_REWARD_18006,
		// Token: 0x04009616 RID: 38422
		[Token(Token = "0x401AB68")]
		ORDER_REWARD_19001,
		// Token: 0x04009617 RID: 38423
		[Token(Token = "0x401AB69")]
		ORDER_REWARD_19002,
		// Token: 0x04009618 RID: 38424
		[Token(Token = "0x401AB6A")]
		ORDER_REWARD_19003,
		// Token: 0x04009619 RID: 38425
		[Token(Token = "0x401AB6B")]
		ORDER_REWARD_19004,
		// Token: 0x0400961A RID: 38426
		[Token(Token = "0x401AB6C")]
		ORDER_REWARD_19005,
		// Token: 0x0400961B RID: 38427
		[Token(Token = "0x401AB6D")]
		ORDER_REWARD_19006,
		// Token: 0x0400961C RID: 38428
		[Token(Token = "0x401AB6E")]
		ORDER_REWARD_20001,
		// Token: 0x0400961D RID: 38429
		[Token(Token = "0x401AB6F")]
		ORDER_REWARD_20002,
		// Token: 0x0400961E RID: 38430
		[Token(Token = "0x401AB70")]
		ORDER_REWARD_20003,
		// Token: 0x0400961F RID: 38431
		[Token(Token = "0x401AB71")]
		ORDER_REWARD_20004,
		// Token: 0x04009620 RID: 38432
		[Token(Token = "0x401AB72")]
		ORDER_REWARD_20005,
		// Token: 0x04009621 RID: 38433
		[Token(Token = "0x401AB73")]
		ORDER_REWARD_20006,
		// Token: 0x04009622 RID: 38434
		[Token(Token = "0x401AB74")]
		ORDER_REWARD_21001,
		// Token: 0x04009623 RID: 38435
		[Token(Token = "0x401AB75")]
		ORDER_REWARD_21002,
		// Token: 0x04009624 RID: 38436
		[Token(Token = "0x401AB76")]
		ORDER_REWARD_21003,
		// Token: 0x04009625 RID: 38437
		[Token(Token = "0x401AB77")]
		ORDER_REWARD_21004,
		// Token: 0x04009626 RID: 38438
		[Token(Token = "0x401AB78")]
		ORDER_REWARD_21005,
		// Token: 0x04009627 RID: 38439
		[Token(Token = "0x401AB79")]
		ORDER_REWARD_21006,
		// Token: 0x04009628 RID: 38440
		[Token(Token = "0x401AB7A")]
		ORDER_REWARD_22001,
		// Token: 0x04009629 RID: 38441
		[Token(Token = "0x401AB7B")]
		ORDER_REWARD_22002,
		// Token: 0x0400962A RID: 38442
		[Token(Token = "0x401AB7C")]
		ORDER_REWARD_22003,
		// Token: 0x0400962B RID: 38443
		[Token(Token = "0x401AB7D")]
		ORDER_REWARD_22004,
		// Token: 0x0400962C RID: 38444
		[Token(Token = "0x401AB7E")]
		ORDER_REWARD_22005,
		// Token: 0x0400962D RID: 38445
		[Token(Token = "0x401AB7F")]
		ORDER_REWARD_22006,
		// Token: 0x0400962E RID: 38446
		[Token(Token = "0x401AB80")]
		ORDER_REWARD_24001,
		// Token: 0x0400962F RID: 38447
		[Token(Token = "0x401AB81")]
		ORDER_REWARD_24002,
		// Token: 0x04009630 RID: 38448
		[Token(Token = "0x401AB82")]
		ORDER_REWARD_24003,
		// Token: 0x04009631 RID: 38449
		[Token(Token = "0x401AB83")]
		ORDER_REWARD_24004,
		// Token: 0x04009632 RID: 38450
		[Token(Token = "0x401AB84")]
		ORDER_REWARD_24005,
		// Token: 0x04009633 RID: 38451
		[Token(Token = "0x401AB85")]
		ORDER_REWARD_24006,
		// Token: 0x04009634 RID: 38452
		[Token(Token = "0x401AB86")]
		ORDER_REWARD_26001,
		// Token: 0x04009635 RID: 38453
		[Token(Token = "0x401AB87")]
		ORDER_REWARD_26002,
		// Token: 0x04009636 RID: 38454
		[Token(Token = "0x401AB88")]
		ORDER_REWARD_26003,
		// Token: 0x04009637 RID: 38455
		[Token(Token = "0x401AB89")]
		ORDER_REWARD_26004,
		// Token: 0x04009638 RID: 38456
		[Token(Token = "0x401AB8A")]
		ORDER_REWARD_26005,
		// Token: 0x04009639 RID: 38457
		[Token(Token = "0x401AB8B")]
		ORDER_REWARD_26006,
		// Token: 0x0400963A RID: 38458
		[Token(Token = "0x401AB8C")]
		ORDER_REWARD_27001,
		// Token: 0x0400963B RID: 38459
		[Token(Token = "0x401AB8D")]
		ORDER_REWARD_27002,
		// Token: 0x0400963C RID: 38460
		[Token(Token = "0x401AB8E")]
		ORDER_REWARD_27003,
		// Token: 0x0400963D RID: 38461
		[Token(Token = "0x401AB8F")]
		ORDER_REWARD_27004,
		// Token: 0x0400963E RID: 38462
		[Token(Token = "0x401AB90")]
		ORDER_REWARD_27005,
		// Token: 0x0400963F RID: 38463
		[Token(Token = "0x401AB91")]
		ORDER_REWARD_27006,
		// Token: 0x04009640 RID: 38464
		[Token(Token = "0x401AB92")]
		ORDER_REWARD_28001,
		// Token: 0x04009641 RID: 38465
		[Token(Token = "0x401AB93")]
		ORDER_REWARD_28002,
		// Token: 0x04009642 RID: 38466
		[Token(Token = "0x401AB94")]
		ORDER_REWARD_28003,
		// Token: 0x04009643 RID: 38467
		[Token(Token = "0x401AB95")]
		ORDER_REWARD_28004,
		// Token: 0x04009644 RID: 38468
		[Token(Token = "0x401AB96")]
		ORDER_REWARD_28005,
		// Token: 0x04009645 RID: 38469
		[Token(Token = "0x401AB97")]
		ORDER_REWARD_28006,
		// Token: 0x04009646 RID: 38470
		[Token(Token = "0x401AB98")]
		ORDER_REWARD_29010,
		// Token: 0x04009647 RID: 38471
		[Token(Token = "0x401AB99")]
		ORDER_REWARD_29011,
		// Token: 0x04009648 RID: 38472
		[Token(Token = "0x401AB9A")]
		ORDER_REWARD_29012,
		// Token: 0x04009649 RID: 38473
		[Token(Token = "0x401AB9B")]
		ORDER_REWARD_29020,
		// Token: 0x0400964A RID: 38474
		[Token(Token = "0x401AB9C")]
		ORDER_REWARD_29021,
		// Token: 0x0400964B RID: 38475
		[Token(Token = "0x401AB9D")]
		ORDER_REWARD_29022,
		// Token: 0x0400964C RID: 38476
		[Token(Token = "0x401AB9E")]
		ORDER_REWARD_29030,
		// Token: 0x0400964D RID: 38477
		[Token(Token = "0x401AB9F")]
		ORDER_REWARD_29031,
		// Token: 0x0400964E RID: 38478
		[Token(Token = "0x401ABA0")]
		ORDER_REWARD_29032,
		// Token: 0x0400964F RID: 38479
		[Token(Token = "0x401ABA1")]
		ORDER_REWARD_29040,
		// Token: 0x04009650 RID: 38480
		[Token(Token = "0x401ABA2")]
		ORDER_REWARD_29041,
		// Token: 0x04009651 RID: 38481
		[Token(Token = "0x401ABA3")]
		ORDER_REWARD_29042,
		// Token: 0x04009652 RID: 38482
		[Token(Token = "0x401ABA4")]
		ORDER_REWARD_29050,
		// Token: 0x04009653 RID: 38483
		[Token(Token = "0x401ABA5")]
		ORDER_REWARD_29051,
		// Token: 0x04009654 RID: 38484
		[Token(Token = "0x401ABA6")]
		ORDER_REWARD_29052,
		// Token: 0x04009655 RID: 38485
		[Token(Token = "0x401ABA7")]
		ORDER_REWARD_29060,
		// Token: 0x04009656 RID: 38486
		[Token(Token = "0x401ABA8")]
		ORDER_REWARD_29061,
		// Token: 0x04009657 RID: 38487
		[Token(Token = "0x401ABA9")]
		ORDER_REWARD_29062,
		// Token: 0x04009658 RID: 38488
		[Token(Token = "0x401ABAA")]
		ORDER_REWARD_29110,
		// Token: 0x04009659 RID: 38489
		[Token(Token = "0x401ABAB")]
		ORDER_REWARD_29111,
		// Token: 0x0400965A RID: 38490
		[Token(Token = "0x401ABAC")]
		ORDER_REWARD_29112,
		// Token: 0x0400965B RID: 38491
		[Token(Token = "0x401ABAD")]
		ORDER_REWARD_29120,
		// Token: 0x0400965C RID: 38492
		[Token(Token = "0x401ABAE")]
		ORDER_REWARD_29121,
		// Token: 0x0400965D RID: 38493
		[Token(Token = "0x401ABAF")]
		ORDER_REWARD_29122,
		// Token: 0x0400965E RID: 38494
		[Token(Token = "0x401ABB0")]
		ORDER_REWARD_29130,
		// Token: 0x0400965F RID: 38495
		[Token(Token = "0x401ABB1")]
		ORDER_REWARD_29131,
		// Token: 0x04009660 RID: 38496
		[Token(Token = "0x401ABB2")]
		ORDER_REWARD_29132,
		// Token: 0x04009661 RID: 38497
		[Token(Token = "0x401ABB3")]
		ORDER_REWARD_29140,
		// Token: 0x04009662 RID: 38498
		[Token(Token = "0x401ABB4")]
		ORDER_REWARD_29141,
		// Token: 0x04009663 RID: 38499
		[Token(Token = "0x401ABB5")]
		ORDER_REWARD_29142,
		// Token: 0x04009664 RID: 38500
		[Token(Token = "0x401ABB6")]
		ORDER_REWARD_29150,
		// Token: 0x04009665 RID: 38501
		[Token(Token = "0x401ABB7")]
		ORDER_REWARD_29151,
		// Token: 0x04009666 RID: 38502
		[Token(Token = "0x401ABB8")]
		ORDER_REWARD_29152,
		// Token: 0x04009667 RID: 38503
		[Token(Token = "0x401ABB9")]
		ORDER_REWARD_29160,
		// Token: 0x04009668 RID: 38504
		[Token(Token = "0x401ABBA")]
		ORDER_REWARD_29161,
		// Token: 0x04009669 RID: 38505
		[Token(Token = "0x401ABBB")]
		ORDER_REWARD_29162,
		// Token: 0x0400966A RID: 38506
		[Token(Token = "0x401ABBC")]
		ORDER_REWARD_30010,
		// Token: 0x0400966B RID: 38507
		[Token(Token = "0x401ABBD")]
		ORDER_REWARD_30011,
		// Token: 0x0400966C RID: 38508
		[Token(Token = "0x401ABBE")]
		ORDER_REWARD_30012,
		// Token: 0x0400966D RID: 38509
		[Token(Token = "0x401ABBF")]
		ORDER_REWARD_30020,
		// Token: 0x0400966E RID: 38510
		[Token(Token = "0x401ABC0")]
		ORDER_REWARD_30021,
		// Token: 0x0400966F RID: 38511
		[Token(Token = "0x401ABC1")]
		ORDER_REWARD_30022,
		// Token: 0x04009670 RID: 38512
		[Token(Token = "0x401ABC2")]
		ORDER_REWARD_30030,
		// Token: 0x04009671 RID: 38513
		[Token(Token = "0x401ABC3")]
		ORDER_REWARD_30031,
		// Token: 0x04009672 RID: 38514
		[Token(Token = "0x401ABC4")]
		ORDER_REWARD_30032,
		// Token: 0x04009673 RID: 38515
		[Token(Token = "0x401ABC5")]
		ORDER_REWARD_30040,
		// Token: 0x04009674 RID: 38516
		[Token(Token = "0x401ABC6")]
		ORDER_REWARD_30041,
		// Token: 0x04009675 RID: 38517
		[Token(Token = "0x401ABC7")]
		ORDER_REWARD_30042,
		// Token: 0x04009676 RID: 38518
		[Token(Token = "0x401ABC8")]
		ORDER_REWARD_30050,
		// Token: 0x04009677 RID: 38519
		[Token(Token = "0x401ABC9")]
		ORDER_REWARD_30051,
		// Token: 0x04009678 RID: 38520
		[Token(Token = "0x401ABCA")]
		ORDER_REWARD_30052,
		// Token: 0x04009679 RID: 38521
		[Token(Token = "0x401ABCB")]
		ORDER_REWARD_30060,
		// Token: 0x0400967A RID: 38522
		[Token(Token = "0x401ABCC")]
		ORDER_REWARD_30061,
		// Token: 0x0400967B RID: 38523
		[Token(Token = "0x401ABCD")]
		ORDER_REWARD_30062,
		// Token: 0x0400967C RID: 38524
		[Token(Token = "0x401ABCE")]
		ORDER_REWARD_31010,
		// Token: 0x0400967D RID: 38525
		[Token(Token = "0x401ABCF")]
		ORDER_REWARD_31011,
		// Token: 0x0400967E RID: 38526
		[Token(Token = "0x401ABD0")]
		ORDER_REWARD_31012,
		// Token: 0x0400967F RID: 38527
		[Token(Token = "0x401ABD1")]
		ORDER_REWARD_31020,
		// Token: 0x04009680 RID: 38528
		[Token(Token = "0x401ABD2")]
		ORDER_REWARD_31021,
		// Token: 0x04009681 RID: 38529
		[Token(Token = "0x401ABD3")]
		ORDER_REWARD_31022,
		// Token: 0x04009682 RID: 38530
		[Token(Token = "0x401ABD4")]
		ORDER_REWARD_31030,
		// Token: 0x04009683 RID: 38531
		[Token(Token = "0x401ABD5")]
		ORDER_REWARD_31031,
		// Token: 0x04009684 RID: 38532
		[Token(Token = "0x401ABD6")]
		ORDER_REWARD_31032,
		// Token: 0x04009685 RID: 38533
		[Token(Token = "0x401ABD7")]
		ORDER_REWARD_31040,
		// Token: 0x04009686 RID: 38534
		[Token(Token = "0x401ABD8")]
		ORDER_REWARD_31041,
		// Token: 0x04009687 RID: 38535
		[Token(Token = "0x401ABD9")]
		ORDER_REWARD_31042,
		// Token: 0x04009688 RID: 38536
		[Token(Token = "0x401ABDA")]
		ORDER_REWARD_31050,
		// Token: 0x04009689 RID: 38537
		[Token(Token = "0x401ABDB")]
		ORDER_REWARD_31051,
		// Token: 0x0400968A RID: 38538
		[Token(Token = "0x401ABDC")]
		ORDER_REWARD_31052,
		// Token: 0x0400968B RID: 38539
		[Token(Token = "0x401ABDD")]
		ORDER_REWARD_31060,
		// Token: 0x0400968C RID: 38540
		[Token(Token = "0x401ABDE")]
		ORDER_REWARD_31061,
		// Token: 0x0400968D RID: 38541
		[Token(Token = "0x401ABDF")]
		ORDER_REWARD_31062,
		// Token: 0x0400968E RID: 38542
		[Token(Token = "0x401ABE0")]
		ORDER_REWARD_32001,
		// Token: 0x0400968F RID: 38543
		[Token(Token = "0x401ABE1")]
		ORDER_REWARD_32002,
		// Token: 0x04009690 RID: 38544
		[Token(Token = "0x401ABE2")]
		ORDER_REWARD_32003,
		// Token: 0x04009691 RID: 38545
		[Token(Token = "0x401ABE3")]
		ORDER_REWARD_32004,
		// Token: 0x04009692 RID: 38546
		[Token(Token = "0x401ABE4")]
		ORDER_REWARD_32005,
		// Token: 0x04009693 RID: 38547
		[Token(Token = "0x401ABE5")]
		ORDER_REWARD_32006,
		// Token: 0x04009694 RID: 38548
		[Token(Token = "0x401ABE6")]
		ORDER_REWARD_33001,
		// Token: 0x04009695 RID: 38549
		[Token(Token = "0x401ABE7")]
		ORDER_REWARD_33002,
		// Token: 0x04009696 RID: 38550
		[Token(Token = "0x401ABE8")]
		ORDER_REWARD_33003,
		// Token: 0x04009697 RID: 38551
		[Token(Token = "0x401ABE9")]
		ORDER_REWARD_33004,
		// Token: 0x04009698 RID: 38552
		[Token(Token = "0x401ABEA")]
		ORDER_REWARD_33005,
		// Token: 0x04009699 RID: 38553
		[Token(Token = "0x401ABEB")]
		ORDER_REWARD_33006,
		// Token: 0x0400969A RID: 38554
		[Token(Token = "0x401ABEC")]
		FIELD_FOCUS_OBJECT_NAME_00001 = 111000,
		// Token: 0x0400969B RID: 38555
		[Token(Token = "0x401ABED")]
		FIELD_FOCUS_OBJECT_NAME_00002,
		// Token: 0x0400969C RID: 38556
		[Token(Token = "0x401ABEE")]
		FIELD_FOCUS_OBJECT_NAME_00003,
		// Token: 0x0400969D RID: 38557
		[Token(Token = "0x401ABEF")]
		FIELD_FOCUS_OBJECT_NAME_00004,
		// Token: 0x0400969E RID: 38558
		[Token(Token = "0x401ABF0")]
		FIELD_FOCUS_OBJECT_NAME_00005,
		// Token: 0x0400969F RID: 38559
		[Token(Token = "0x401ABF1")]
		FIELD_FOCUS_OBJECT_NAME_00006,
		// Token: 0x040096A0 RID: 38560
		[Token(Token = "0x401ABF2")]
		FIELD_FOCUS_OBJECT_NAME_00007,
		// Token: 0x040096A1 RID: 38561
		[Token(Token = "0x401ABF3")]
		FIELD_FOCUS_OBJECT_NAME_00008,
		// Token: 0x040096A2 RID: 38562
		[Token(Token = "0x401ABF4")]
		FIELD_FOCUS_OBJECT_NAME_00009,
		// Token: 0x040096A3 RID: 38563
		[Token(Token = "0x401ABF5")]
		FIELD_FOCUS_OBJECT_NAME_00010,
		// Token: 0x040096A4 RID: 38564
		[Token(Token = "0x401ABF6")]
		FIELD_FOCUS_OBJECT_NAME_00011,
		// Token: 0x040096A5 RID: 38565
		[Token(Token = "0x401ABF7")]
		FIELD_FOCUS_OBJECT_NAME_00012,
		// Token: 0x040096A6 RID: 38566
		[Token(Token = "0x401ABF8")]
		FIELD_FOCUS_OBJECT_NAME_00013,
		// Token: 0x040096A7 RID: 38567
		[Token(Token = "0x401ABF9")]
		FIELD_FOCUS_OBJECT_NAME_00014,
		// Token: 0x040096A8 RID: 38568
		[Token(Token = "0x401ABFA")]
		FIELD_FOCUS_OBJECT_NAME_00015,
		// Token: 0x040096A9 RID: 38569
		[Token(Token = "0x401ABFB")]
		FIELD_FOCUS_OBJECT_NAME_00016,
		// Token: 0x040096AA RID: 38570
		[Token(Token = "0x401ABFC")]
		FIELD_FOCUS_OBJECT_NAME_00017,
		// Token: 0x040096AB RID: 38571
		[Token(Token = "0x401ABFD")]
		FIELD_FOCUS_OBJECT_NAME_00018,
		// Token: 0x040096AC RID: 38572
		[Token(Token = "0x401ABFE")]
		FIELD_FOCUS_OBJECT_NAME_00019,
		// Token: 0x040096AD RID: 38573
		[Token(Token = "0x401ABFF")]
		FIELD_FOCUS_OBJECT_NAME_00020,
		// Token: 0x040096AE RID: 38574
		[Token(Token = "0x401AC00")]
		FIELD_FOCUS_OBJECT_NAME_00021,
		// Token: 0x040096AF RID: 38575
		[Token(Token = "0x401AC01")]
		FIELD_FOCUS_OBJECT_NAME_00022,
		// Token: 0x040096B0 RID: 38576
		[Token(Token = "0x401AC02")]
		FIELD_FOCUS_OBJECT_NAME_00023,
		// Token: 0x040096B1 RID: 38577
		[Token(Token = "0x401AC03")]
		FIELD_FOCUS_OBJECT_NAME_00024,
		// Token: 0x040096B2 RID: 38578
		[Token(Token = "0x401AC04")]
		FIELD_FOCUS_OBJECT_NAME_00025,
		// Token: 0x040096B3 RID: 38579
		[Token(Token = "0x401AC05")]
		FIELD_FOCUS_OBJECT_NAME_00026,
		// Token: 0x040096B4 RID: 38580
		[Token(Token = "0x401AC06")]
		MONSTERNAME_000 = 200000,
		// Token: 0x040096B5 RID: 38581
		[Token(Token = "0x401AC07")]
		MONSTERNAME_001,
		// Token: 0x040096B6 RID: 38582
		[Token(Token = "0x401AC08")]
		MONSTERNAME_002,
		// Token: 0x040096B7 RID: 38583
		[Token(Token = "0x401AC09")]
		MONSTERNAME_003,
		// Token: 0x040096B8 RID: 38584
		[Token(Token = "0x401AC0A")]
		MONSTERNAME_004,
		// Token: 0x040096B9 RID: 38585
		[Token(Token = "0x401AC0B")]
		MONSTERNAME_005,
		// Token: 0x040096BA RID: 38586
		[Token(Token = "0x401AC0C")]
		MONSTERNAME_006,
		// Token: 0x040096BB RID: 38587
		[Token(Token = "0x401AC0D")]
		MONSTERNAME_007,
		// Token: 0x040096BC RID: 38588
		[Token(Token = "0x401AC0E")]
		MONSTERNAME_008,
		// Token: 0x040096BD RID: 38589
		[Token(Token = "0x401AC0F")]
		MONSTERNAME_009,
		// Token: 0x040096BE RID: 38590
		[Token(Token = "0x401AC10")]
		MONSTERNAME_010,
		// Token: 0x040096BF RID: 38591
		[Token(Token = "0x401AC11")]
		MONSTERNAME_011,
		// Token: 0x040096C0 RID: 38592
		[Token(Token = "0x401AC12")]
		MONSTERNAME_012,
		// Token: 0x040096C1 RID: 38593
		[Token(Token = "0x401AC13")]
		MONSTERNAME_013,
		// Token: 0x040096C2 RID: 38594
		[Token(Token = "0x401AC14")]
		MONSTERNAME_014,
		// Token: 0x040096C3 RID: 38595
		[Token(Token = "0x401AC15")]
		MONSTERNAME_015,
		// Token: 0x040096C4 RID: 38596
		[Token(Token = "0x401AC16")]
		MONSTERNAME_016,
		// Token: 0x040096C5 RID: 38597
		[Token(Token = "0x401AC17")]
		MONSTERNAME_017,
		// Token: 0x040096C6 RID: 38598
		[Token(Token = "0x401AC18")]
		MONSTERNAME_018,
		// Token: 0x040096C7 RID: 38599
		[Token(Token = "0x401AC19")]
		MONSTERNAME_019,
		// Token: 0x040096C8 RID: 38600
		[Token(Token = "0x401AC1A")]
		MONSTERNAME_020,
		// Token: 0x040096C9 RID: 38601
		[Token(Token = "0x401AC1B")]
		MONSTERNAME_021,
		// Token: 0x040096CA RID: 38602
		[Token(Token = "0x401AC1C")]
		MONSTERNAME_022,
		// Token: 0x040096CB RID: 38603
		[Token(Token = "0x401AC1D")]
		MONSTERNAME_023,
		// Token: 0x040096CC RID: 38604
		[Token(Token = "0x401AC1E")]
		MONSTERNAME_024,
		// Token: 0x040096CD RID: 38605
		[Token(Token = "0x401AC1F")]
		MONSTERNAME_025,
		// Token: 0x040096CE RID: 38606
		[Token(Token = "0x401AC20")]
		MONSTERNAME_026,
		// Token: 0x040096CF RID: 38607
		[Token(Token = "0x401AC21")]
		MONSTERNAME_027,
		// Token: 0x040096D0 RID: 38608
		[Token(Token = "0x401AC22")]
		MONSTERNAME_028,
		// Token: 0x040096D1 RID: 38609
		[Token(Token = "0x401AC23")]
		MONSTERNAME_029,
		// Token: 0x040096D2 RID: 38610
		[Token(Token = "0x401AC24")]
		MONSTERNAME_030,
		// Token: 0x040096D3 RID: 38611
		[Token(Token = "0x401AC25")]
		MONSTERNAME_031,
		// Token: 0x040096D4 RID: 38612
		[Token(Token = "0x401AC26")]
		MONSTERNAME_032,
		// Token: 0x040096D5 RID: 38613
		[Token(Token = "0x401AC27")]
		MONSTERNAME_033,
		// Token: 0x040096D6 RID: 38614
		[Token(Token = "0x401AC28")]
		MONSTERNAME_034,
		// Token: 0x040096D7 RID: 38615
		[Token(Token = "0x401AC29")]
		MONSTERNAME_035,
		// Token: 0x040096D8 RID: 38616
		[Token(Token = "0x401AC2A")]
		MONSTERNAME_036,
		// Token: 0x040096D9 RID: 38617
		[Token(Token = "0x401AC2B")]
		MONSTERNAME_037,
		// Token: 0x040096DA RID: 38618
		[Token(Token = "0x401AC2C")]
		MONSTERNAME_038,
		// Token: 0x040096DB RID: 38619
		[Token(Token = "0x401AC2D")]
		MONSTERNAME_039,
		// Token: 0x040096DC RID: 38620
		[Token(Token = "0x401AC2E")]
		MONSTERNAME_040,
		// Token: 0x040096DD RID: 38621
		[Token(Token = "0x401AC2F")]
		MONSTERNAME_041,
		// Token: 0x040096DE RID: 38622
		[Token(Token = "0x401AC30")]
		MONSTERNAME_042,
		// Token: 0x040096DF RID: 38623
		[Token(Token = "0x401AC31")]
		MONSTERNAME_043,
		// Token: 0x040096E0 RID: 38624
		[Token(Token = "0x401AC32")]
		MONSTERNAME_044,
		// Token: 0x040096E1 RID: 38625
		[Token(Token = "0x401AC33")]
		MONSTERNAME_045,
		// Token: 0x040096E2 RID: 38626
		[Token(Token = "0x401AC34")]
		MONSTERNAME_046,
		// Token: 0x040096E3 RID: 38627
		[Token(Token = "0x401AC35")]
		MONSTERNAME_047,
		// Token: 0x040096E4 RID: 38628
		[Token(Token = "0x401AC36")]
		MONSTERNAME_048,
		// Token: 0x040096E5 RID: 38629
		[Token(Token = "0x401AC37")]
		MONSTERNAME_049,
		// Token: 0x040096E6 RID: 38630
		[Token(Token = "0x401AC38")]
		MONSTERNAME_050,
		// Token: 0x040096E7 RID: 38631
		[Token(Token = "0x401AC39")]
		MONSTERNAME_051,
		// Token: 0x040096E8 RID: 38632
		[Token(Token = "0x401AC3A")]
		MONSTERNAME_052,
		// Token: 0x040096E9 RID: 38633
		[Token(Token = "0x401AC3B")]
		MONSTERNAME_053,
		// Token: 0x040096EA RID: 38634
		[Token(Token = "0x401AC3C")]
		MONSTERNAME_054,
		// Token: 0x040096EB RID: 38635
		[Token(Token = "0x401AC3D")]
		MONSTERNAME_055,
		// Token: 0x040096EC RID: 38636
		[Token(Token = "0x401AC3E")]
		MONSTERNAME_056,
		// Token: 0x040096ED RID: 38637
		[Token(Token = "0x401AC3F")]
		MONSTERNAME_057,
		// Token: 0x040096EE RID: 38638
		[Token(Token = "0x401AC40")]
		MONSTERNAME_058,
		// Token: 0x040096EF RID: 38639
		[Token(Token = "0x401AC41")]
		MONSTERNAME_059,
		// Token: 0x040096F0 RID: 38640
		[Token(Token = "0x401AC42")]
		MONSTERNAME_060,
		// Token: 0x040096F1 RID: 38641
		[Token(Token = "0x401AC43")]
		MONSTERNAME_061,
		// Token: 0x040096F2 RID: 38642
		[Token(Token = "0x401AC44")]
		MONSTERNAME_062,
		// Token: 0x040096F3 RID: 38643
		[Token(Token = "0x401AC45")]
		MONSTERNAME_063,
		// Token: 0x040096F4 RID: 38644
		[Token(Token = "0x401AC46")]
		MONSTERNAME_064,
		// Token: 0x040096F5 RID: 38645
		[Token(Token = "0x401AC47")]
		MONSTERNAME_065,
		// Token: 0x040096F6 RID: 38646
		[Token(Token = "0x401AC48")]
		MONSTERNAME_066,
		// Token: 0x040096F7 RID: 38647
		[Token(Token = "0x401AC49")]
		MONSTERNAME_067,
		// Token: 0x040096F8 RID: 38648
		[Token(Token = "0x401AC4A")]
		MONSTERNAME_068,
		// Token: 0x040096F9 RID: 38649
		[Token(Token = "0x401AC4B")]
		MONSTERNAME_069,
		// Token: 0x040096FA RID: 38650
		[Token(Token = "0x401AC4C")]
		MONSTERNAME_070,
		// Token: 0x040096FB RID: 38651
		[Token(Token = "0x401AC4D")]
		MONSTERNAME_071,
		// Token: 0x040096FC RID: 38652
		[Token(Token = "0x401AC4E")]
		MONSTERNAME_072,
		// Token: 0x040096FD RID: 38653
		[Token(Token = "0x401AC4F")]
		MONSTERNAME_073,
		// Token: 0x040096FE RID: 38654
		[Token(Token = "0x401AC50")]
		MONSTERNAME_074,
		// Token: 0x040096FF RID: 38655
		[Token(Token = "0x401AC51")]
		MONSTERNAME_075,
		// Token: 0x04009700 RID: 38656
		[Token(Token = "0x401AC52")]
		MONSTERNAME_076,
		// Token: 0x04009701 RID: 38657
		[Token(Token = "0x401AC53")]
		MONSTERNAME_077,
		// Token: 0x04009702 RID: 38658
		[Token(Token = "0x401AC54")]
		MONSTERNAME_078,
		// Token: 0x04009703 RID: 38659
		[Token(Token = "0x401AC55")]
		MONSTERNAME_079,
		// Token: 0x04009704 RID: 38660
		[Token(Token = "0x401AC56")]
		MONSTERNAME_080,
		// Token: 0x04009705 RID: 38661
		[Token(Token = "0x401AC57")]
		MONSTERNAME_081,
		// Token: 0x04009706 RID: 38662
		[Token(Token = "0x401AC58")]
		MONSTERNAME_082,
		// Token: 0x04009707 RID: 38663
		[Token(Token = "0x401AC59")]
		MONSTERNAME_083,
		// Token: 0x04009708 RID: 38664
		[Token(Token = "0x401AC5A")]
		MONSTERNAME_084,
		// Token: 0x04009709 RID: 38665
		[Token(Token = "0x401AC5B")]
		MONSTERNAME_085,
		// Token: 0x0400970A RID: 38666
		[Token(Token = "0x401AC5C")]
		MONSTERNAME_086,
		// Token: 0x0400970B RID: 38667
		[Token(Token = "0x401AC5D")]
		MONSTERNAME_087,
		// Token: 0x0400970C RID: 38668
		[Token(Token = "0x401AC5E")]
		MONSTERNAME_088,
		// Token: 0x0400970D RID: 38669
		[Token(Token = "0x401AC5F")]
		MONSTERNAME_089,
		// Token: 0x0400970E RID: 38670
		[Token(Token = "0x401AC60")]
		MONSTERNAME_090,
		// Token: 0x0400970F RID: 38671
		[Token(Token = "0x401AC61")]
		MONSTERNAME_091,
		// Token: 0x04009710 RID: 38672
		[Token(Token = "0x401AC62")]
		MONSTERNAME_092,
		// Token: 0x04009711 RID: 38673
		[Token(Token = "0x401AC63")]
		MONSTERNAME_093,
		// Token: 0x04009712 RID: 38674
		[Token(Token = "0x401AC64")]
		MONSTERNAME_094,
		// Token: 0x04009713 RID: 38675
		[Token(Token = "0x401AC65")]
		MONSTERNAME_095,
		// Token: 0x04009714 RID: 38676
		[Token(Token = "0x401AC66")]
		MONSTERNAME_096,
		// Token: 0x04009715 RID: 38677
		[Token(Token = "0x401AC67")]
		MONSTERNAME_097,
		// Token: 0x04009716 RID: 38678
		[Token(Token = "0x401AC68")]
		MONSTERNAME_098,
		// Token: 0x04009717 RID: 38679
		[Token(Token = "0x401AC69")]
		MONSTERNAME_099,
		// Token: 0x04009718 RID: 38680
		[Token(Token = "0x401AC6A")]
		MONSTERNAME_100,
		// Token: 0x04009719 RID: 38681
		[Token(Token = "0x401AC6B")]
		MONSTERNAME_101,
		// Token: 0x0400971A RID: 38682
		[Token(Token = "0x401AC6C")]
		MONSTERNAME_102,
		// Token: 0x0400971B RID: 38683
		[Token(Token = "0x401AC6D")]
		MONSTERNAME_103,
		// Token: 0x0400971C RID: 38684
		[Token(Token = "0x401AC6E")]
		MONSTERNAME_104,
		// Token: 0x0400971D RID: 38685
		[Token(Token = "0x401AC6F")]
		MONSTERNAME_105,
		// Token: 0x0400971E RID: 38686
		[Token(Token = "0x401AC70")]
		MONSTERNAME_106,
		// Token: 0x0400971F RID: 38687
		[Token(Token = "0x401AC71")]
		MONSTERNAME_107,
		// Token: 0x04009720 RID: 38688
		[Token(Token = "0x401AC72")]
		MONSTERNAME_108,
		// Token: 0x04009721 RID: 38689
		[Token(Token = "0x401AC73")]
		MONSTERNAME_109,
		// Token: 0x04009722 RID: 38690
		[Token(Token = "0x401AC74")]
		MONSTERNAME_110,
		// Token: 0x04009723 RID: 38691
		[Token(Token = "0x401AC75")]
		MONSTERNAME_111,
		// Token: 0x04009724 RID: 38692
		[Token(Token = "0x401AC76")]
		MONSTERNAME_112,
		// Token: 0x04009725 RID: 38693
		[Token(Token = "0x401AC77")]
		MONSTERNAME_113,
		// Token: 0x04009726 RID: 38694
		[Token(Token = "0x401AC78")]
		MONSTERNAME_114,
		// Token: 0x04009727 RID: 38695
		[Token(Token = "0x401AC79")]
		MONSTERNAME_115,
		// Token: 0x04009728 RID: 38696
		[Token(Token = "0x401AC7A")]
		MONSTERNAME_116,
		// Token: 0x04009729 RID: 38697
		[Token(Token = "0x401AC7B")]
		MONSTERNAME_117,
		// Token: 0x0400972A RID: 38698
		[Token(Token = "0x401AC7C")]
		MONSTERNAME_118,
		// Token: 0x0400972B RID: 38699
		[Token(Token = "0x401AC7D")]
		MONSTERNAME_119,
		// Token: 0x0400972C RID: 38700
		[Token(Token = "0x401AC7E")]
		MONSTERNAME_120,
		// Token: 0x0400972D RID: 38701
		[Token(Token = "0x401AC7F")]
		MONSTERNAME_121,
		// Token: 0x0400972E RID: 38702
		[Token(Token = "0x401AC80")]
		MONSTERNAME_122,
		// Token: 0x0400972F RID: 38703
		[Token(Token = "0x401AC81")]
		MONSTERNAME_123,
		// Token: 0x04009730 RID: 38704
		[Token(Token = "0x401AC82")]
		MONSTERNAME_124,
		// Token: 0x04009731 RID: 38705
		[Token(Token = "0x401AC83")]
		MONSTERNAME_125,
		// Token: 0x04009732 RID: 38706
		[Token(Token = "0x401AC84")]
		MONSTERNAME_126,
		// Token: 0x04009733 RID: 38707
		[Token(Token = "0x401AC85")]
		MONSTERNAME_127,
		// Token: 0x04009734 RID: 38708
		[Token(Token = "0x401AC86")]
		MONSTERNAME_128,
		// Token: 0x04009735 RID: 38709
		[Token(Token = "0x401AC87")]
		MONSTERNAME_129,
		// Token: 0x04009736 RID: 38710
		[Token(Token = "0x401AC88")]
		MONSTERNAME_130,
		// Token: 0x04009737 RID: 38711
		[Token(Token = "0x401AC89")]
		MONSTERNAME_131,
		// Token: 0x04009738 RID: 38712
		[Token(Token = "0x401AC8A")]
		MONSTERNAME_132,
		// Token: 0x04009739 RID: 38713
		[Token(Token = "0x401AC8B")]
		MONSTERNAME_133,
		// Token: 0x0400973A RID: 38714
		[Token(Token = "0x401AC8C")]
		MONSTERNAME_134,
		// Token: 0x0400973B RID: 38715
		[Token(Token = "0x401AC8D")]
		MONSTERNAME_135,
		// Token: 0x0400973C RID: 38716
		[Token(Token = "0x401AC8E")]
		MONSTERNAME_136,
		// Token: 0x0400973D RID: 38717
		[Token(Token = "0x401AC8F")]
		MONSTERNAME_137,
		// Token: 0x0400973E RID: 38718
		[Token(Token = "0x401AC90")]
		MONSTERNAME_138,
		// Token: 0x0400973F RID: 38719
		[Token(Token = "0x401AC91")]
		MONSTERNAME_139,
		// Token: 0x04009740 RID: 38720
		[Token(Token = "0x401AC92")]
		MONSTERNAME_140,
		// Token: 0x04009741 RID: 38721
		[Token(Token = "0x401AC93")]
		MONSTERNAME_141,
		// Token: 0x04009742 RID: 38722
		[Token(Token = "0x401AC94")]
		MONSTERNAME_142,
		// Token: 0x04009743 RID: 38723
		[Token(Token = "0x401AC95")]
		MONSTERNAME_143,
		// Token: 0x04009744 RID: 38724
		[Token(Token = "0x401AC96")]
		MONSTERNAME_144,
		// Token: 0x04009745 RID: 38725
		[Token(Token = "0x401AC97")]
		MONSTERNAME_145,
		// Token: 0x04009746 RID: 38726
		[Token(Token = "0x401AC98")]
		MONSTERNAME_146,
		// Token: 0x04009747 RID: 38727
		[Token(Token = "0x401AC99")]
		MONSTERNAME_147,
		// Token: 0x04009748 RID: 38728
		[Token(Token = "0x401AC9A")]
		MONSTERNAME_148,
		// Token: 0x04009749 RID: 38729
		[Token(Token = "0x401AC9B")]
		MONSTERNAME_149,
		// Token: 0x0400974A RID: 38730
		[Token(Token = "0x401AC9C")]
		MONSTERNAME_150,
		// Token: 0x0400974B RID: 38731
		[Token(Token = "0x401AC9D")]
		MONSTERNAME_151,
		// Token: 0x0400974C RID: 38732
		[Token(Token = "0x401AC9E")]
		MONSTERNAME_152,
		// Token: 0x0400974D RID: 38733
		[Token(Token = "0x401AC9F")]
		MONSTERNAME_153,
		// Token: 0x0400974E RID: 38734
		[Token(Token = "0x401ACA0")]
		MONSTERNAME_154,
		// Token: 0x0400974F RID: 38735
		[Token(Token = "0x401ACA1")]
		MONSTERNAME_155,
		// Token: 0x04009750 RID: 38736
		[Token(Token = "0x401ACA2")]
		MONSTERNAME_156,
		// Token: 0x04009751 RID: 38737
		[Token(Token = "0x401ACA3")]
		MONSTERNAME_157,
		// Token: 0x04009752 RID: 38738
		[Token(Token = "0x401ACA4")]
		MONSTERNAME_158,
		// Token: 0x04009753 RID: 38739
		[Token(Token = "0x401ACA5")]
		MONSTERNAME_159,
		// Token: 0x04009754 RID: 38740
		[Token(Token = "0x401ACA6")]
		MONSTERNAME_160,
		// Token: 0x04009755 RID: 38741
		[Token(Token = "0x401ACA7")]
		MONSTERNAME_161,
		// Token: 0x04009756 RID: 38742
		[Token(Token = "0x401ACA8")]
		MONSTERNAME_162,
		// Token: 0x04009757 RID: 38743
		[Token(Token = "0x401ACA9")]
		MONSTERNAME_163,
		// Token: 0x04009758 RID: 38744
		[Token(Token = "0x401ACAA")]
		MONSTERNAME_164,
		// Token: 0x04009759 RID: 38745
		[Token(Token = "0x401ACAB")]
		MONSTERNAME_165,
		// Token: 0x0400975A RID: 38746
		[Token(Token = "0x401ACAC")]
		MONSTERNAME_166,
		// Token: 0x0400975B RID: 38747
		[Token(Token = "0x401ACAD")]
		MONSTERNAME_167,
		// Token: 0x0400975C RID: 38748
		[Token(Token = "0x401ACAE")]
		MONSTERNAME_168,
		// Token: 0x0400975D RID: 38749
		[Token(Token = "0x401ACAF")]
		MONSTERNAME_169,
		// Token: 0x0400975E RID: 38750
		[Token(Token = "0x401ACB0")]
		MONSTERNAME_170,
		// Token: 0x0400975F RID: 38751
		[Token(Token = "0x401ACB1")]
		MONSTERNAME_171,
		// Token: 0x04009760 RID: 38752
		[Token(Token = "0x401ACB2")]
		MONSTERNAME_172,
		// Token: 0x04009761 RID: 38753
		[Token(Token = "0x401ACB3")]
		MONSTERNAME_173,
		// Token: 0x04009762 RID: 38754
		[Token(Token = "0x401ACB4")]
		MONSTERNAME_174,
		// Token: 0x04009763 RID: 38755
		[Token(Token = "0x401ACB5")]
		MONSTERNAME_175,
		// Token: 0x04009764 RID: 38756
		[Token(Token = "0x401ACB6")]
		MONSTERNAME_176,
		// Token: 0x04009765 RID: 38757
		[Token(Token = "0x401ACB7")]
		MONSTERNAME_177,
		// Token: 0x04009766 RID: 38758
		[Token(Token = "0x401ACB8")]
		MONSTERNAME_178,
		// Token: 0x04009767 RID: 38759
		[Token(Token = "0x401ACB9")]
		MONSTERNAME_179,
		// Token: 0x04009768 RID: 38760
		[Token(Token = "0x401ACBA")]
		MONSTERNAME_180,
		// Token: 0x04009769 RID: 38761
		[Token(Token = "0x401ACBB")]
		MONSTERNAME_181,
		// Token: 0x0400976A RID: 38762
		[Token(Token = "0x401ACBC")]
		MONSTERNAME_182,
		// Token: 0x0400976B RID: 38763
		[Token(Token = "0x401ACBD")]
		MONSTERNAME_183,
		// Token: 0x0400976C RID: 38764
		[Token(Token = "0x401ACBE")]
		MONSTERNAME_184,
		// Token: 0x0400976D RID: 38765
		[Token(Token = "0x401ACBF")]
		MONSTERNAME_185,
		// Token: 0x0400976E RID: 38766
		[Token(Token = "0x401ACC0")]
		MONSTERNAME_186,
		// Token: 0x0400976F RID: 38767
		[Token(Token = "0x401ACC1")]
		MONSTERNAME_187,
		// Token: 0x04009770 RID: 38768
		[Token(Token = "0x401ACC2")]
		MONSTERNAME_188,
		// Token: 0x04009771 RID: 38769
		[Token(Token = "0x401ACC3")]
		MONSTERNAME_189,
		// Token: 0x04009772 RID: 38770
		[Token(Token = "0x401ACC4")]
		MONSTERNAME_190,
		// Token: 0x04009773 RID: 38771
		[Token(Token = "0x401ACC5")]
		MONSTERNAME_191,
		// Token: 0x04009774 RID: 38772
		[Token(Token = "0x401ACC6")]
		MONSTERNAME_192,
		// Token: 0x04009775 RID: 38773
		[Token(Token = "0x401ACC7")]
		MONSTERNAME_195,
		// Token: 0x04009776 RID: 38774
		[Token(Token = "0x401ACC8")]
		MONSTERNAME_196,
		// Token: 0x04009777 RID: 38775
		[Token(Token = "0x401ACC9")]
		MONSTERNAME_197,
		// Token: 0x04009778 RID: 38776
		[Token(Token = "0x401ACCA")]
		MONSTERNAME_198,
		// Token: 0x04009779 RID: 38777
		[Token(Token = "0x401ACCB")]
		MONSTERNAME_199,
		// Token: 0x0400977A RID: 38778
		[Token(Token = "0x401ACCC")]
		MONSTERNAME_200,
		// Token: 0x0400977B RID: 38779
		[Token(Token = "0x401ACCD")]
		MONSTERNAME_201,
		// Token: 0x0400977C RID: 38780
		[Token(Token = "0x401ACCE")]
		MONSTERNAME_202,
		// Token: 0x0400977D RID: 38781
		[Token(Token = "0x401ACCF")]
		MONSTERNAME_203,
		// Token: 0x0400977E RID: 38782
		[Token(Token = "0x401ACD0")]
		MONSTERNAME_204,
		// Token: 0x0400977F RID: 38783
		[Token(Token = "0x401ACD1")]
		MONSTERNAME_205,
		// Token: 0x04009780 RID: 38784
		[Token(Token = "0x401ACD2")]
		MONSTERNAME_206,
		// Token: 0x04009781 RID: 38785
		[Token(Token = "0x401ACD3")]
		MONSTERNAME_207,
		// Token: 0x04009782 RID: 38786
		[Token(Token = "0x401ACD4")]
		MONSTERNAME_208,
		// Token: 0x04009783 RID: 38787
		[Token(Token = "0x401ACD5")]
		MONSTERNAME_209,
		// Token: 0x04009784 RID: 38788
		[Token(Token = "0x401ACD6")]
		MONSTERNAME_210,
		// Token: 0x04009785 RID: 38789
		[Token(Token = "0x401ACD7")]
		MONSTERNAME_211,
		// Token: 0x04009786 RID: 38790
		[Token(Token = "0x401ACD8")]
		MONSTERNAME_212,
		// Token: 0x04009787 RID: 38791
		[Token(Token = "0x401ACD9")]
		MONSTERNAME_213,
		// Token: 0x04009788 RID: 38792
		[Token(Token = "0x401ACDA")]
		MONSTERNAME_214,
		// Token: 0x04009789 RID: 38793
		[Token(Token = "0x401ACDB")]
		MONSTERNAME_215,
		// Token: 0x0400978A RID: 38794
		[Token(Token = "0x401ACDC")]
		MONSTERNAME_216,
		// Token: 0x0400978B RID: 38795
		[Token(Token = "0x401ACDD")]
		MONSTERNAME_217,
		// Token: 0x0400978C RID: 38796
		[Token(Token = "0x401ACDE")]
		MONSTERNAME_218,
		// Token: 0x0400978D RID: 38797
		[Token(Token = "0x401ACDF")]
		MONSTERNAME_219,
		// Token: 0x0400978E RID: 38798
		[Token(Token = "0x401ACE0")]
		MONSTERNAME_220,
		// Token: 0x0400978F RID: 38799
		[Token(Token = "0x401ACE1")]
		MONSTERNAME_221,
		// Token: 0x04009790 RID: 38800
		[Token(Token = "0x401ACE2")]
		MONSTERNAME_222,
		// Token: 0x04009791 RID: 38801
		[Token(Token = "0x401ACE3")]
		MONSTERNAME_223,
		// Token: 0x04009792 RID: 38802
		[Token(Token = "0x401ACE4")]
		MONSTERNAME_224,
		// Token: 0x04009793 RID: 38803
		[Token(Token = "0x401ACE5")]
		MONSTERNAME_225,
		// Token: 0x04009794 RID: 38804
		[Token(Token = "0x401ACE6")]
		MONSTERNAME_226,
		// Token: 0x04009795 RID: 38805
		[Token(Token = "0x401ACE7")]
		MONSTERNAME_227,
		// Token: 0x04009796 RID: 38806
		[Token(Token = "0x401ACE8")]
		MONSTERNAME_228,
		// Token: 0x04009797 RID: 38807
		[Token(Token = "0x401ACE9")]
		MONSTERNAME_229,
		// Token: 0x04009798 RID: 38808
		[Token(Token = "0x401ACEA")]
		MONSTERNAME_230,
		// Token: 0x04009799 RID: 38809
		[Token(Token = "0x401ACEB")]
		MONSTERNAME_231,
		// Token: 0x0400979A RID: 38810
		[Token(Token = "0x401ACEC")]
		MONSTERNAME_232,
		// Token: 0x0400979B RID: 38811
		[Token(Token = "0x401ACED")]
		MONSTERNAME_233,
		// Token: 0x0400979C RID: 38812
		[Token(Token = "0x401ACEE")]
		MONSTERNAME_234,
		// Token: 0x0400979D RID: 38813
		[Token(Token = "0x401ACEF")]
		MONSTERNAME_235,
		// Token: 0x0400979E RID: 38814
		[Token(Token = "0x401ACF0")]
		MONSTERNAME_236,
		// Token: 0x0400979F RID: 38815
		[Token(Token = "0x401ACF1")]
		MONSTERNAME_237,
		// Token: 0x040097A0 RID: 38816
		[Token(Token = "0x401ACF2")]
		MONSTERDETAIL_000,
		// Token: 0x040097A1 RID: 38817
		[Token(Token = "0x401ACF3")]
		MONSTERDETAIL_001,
		// Token: 0x040097A2 RID: 38818
		[Token(Token = "0x401ACF4")]
		MONSTERDETAIL_002,
		// Token: 0x040097A3 RID: 38819
		[Token(Token = "0x401ACF5")]
		MONSTERDETAIL_003,
		// Token: 0x040097A4 RID: 38820
		[Token(Token = "0x401ACF6")]
		MONSTERDETAIL_004,
		// Token: 0x040097A5 RID: 38821
		[Token(Token = "0x401ACF7")]
		MONSTERDETAIL_005,
		// Token: 0x040097A6 RID: 38822
		[Token(Token = "0x401ACF8")]
		MONSTERDETAIL_006,
		// Token: 0x040097A7 RID: 38823
		[Token(Token = "0x401ACF9")]
		MONSTERDETAIL_007,
		// Token: 0x040097A8 RID: 38824
		[Token(Token = "0x401ACFA")]
		MONSTERDETAIL_008,
		// Token: 0x040097A9 RID: 38825
		[Token(Token = "0x401ACFB")]
		MONSTERDETAIL_009,
		// Token: 0x040097AA RID: 38826
		[Token(Token = "0x401ACFC")]
		MONSTERDETAIL_010,
		// Token: 0x040097AB RID: 38827
		[Token(Token = "0x401ACFD")]
		MONSTERDETAIL_011,
		// Token: 0x040097AC RID: 38828
		[Token(Token = "0x401ACFE")]
		MONSTERDETAIL_012,
		// Token: 0x040097AD RID: 38829
		[Token(Token = "0x401ACFF")]
		MONSTERDETAIL_013,
		// Token: 0x040097AE RID: 38830
		[Token(Token = "0x401AD00")]
		MONSTERDETAIL_014,
		// Token: 0x040097AF RID: 38831
		[Token(Token = "0x401AD01")]
		MONSTERDETAIL_015,
		// Token: 0x040097B0 RID: 38832
		[Token(Token = "0x401AD02")]
		MONSTERDETAIL_016,
		// Token: 0x040097B1 RID: 38833
		[Token(Token = "0x401AD03")]
		MONSTERDETAIL_017,
		// Token: 0x040097B2 RID: 38834
		[Token(Token = "0x401AD04")]
		MONSTERDETAIL_018,
		// Token: 0x040097B3 RID: 38835
		[Token(Token = "0x401AD05")]
		MONSTERDETAIL_019,
		// Token: 0x040097B4 RID: 38836
		[Token(Token = "0x401AD06")]
		MONSTERDETAIL_020,
		// Token: 0x040097B5 RID: 38837
		[Token(Token = "0x401AD07")]
		MONSTERDETAIL_021,
		// Token: 0x040097B6 RID: 38838
		[Token(Token = "0x401AD08")]
		MONSTERDETAIL_022,
		// Token: 0x040097B7 RID: 38839
		[Token(Token = "0x401AD09")]
		MONSTERDETAIL_023,
		// Token: 0x040097B8 RID: 38840
		[Token(Token = "0x401AD0A")]
		MONSTERDETAIL_024,
		// Token: 0x040097B9 RID: 38841
		[Token(Token = "0x401AD0B")]
		MONSTERDETAIL_025,
		// Token: 0x040097BA RID: 38842
		[Token(Token = "0x401AD0C")]
		MONSTERDETAIL_026,
		// Token: 0x040097BB RID: 38843
		[Token(Token = "0x401AD0D")]
		MONSTERDETAIL_027,
		// Token: 0x040097BC RID: 38844
		[Token(Token = "0x401AD0E")]
		MONSTERDETAIL_028,
		// Token: 0x040097BD RID: 38845
		[Token(Token = "0x401AD0F")]
		MONSTERDETAIL_029,
		// Token: 0x040097BE RID: 38846
		[Token(Token = "0x401AD10")]
		MONSTERDETAIL_030,
		// Token: 0x040097BF RID: 38847
		[Token(Token = "0x401AD11")]
		MONSTERDETAIL_031,
		// Token: 0x040097C0 RID: 38848
		[Token(Token = "0x401AD12")]
		MONSTERDETAIL_032,
		// Token: 0x040097C1 RID: 38849
		[Token(Token = "0x401AD13")]
		MONSTERDETAIL_033,
		// Token: 0x040097C2 RID: 38850
		[Token(Token = "0x401AD14")]
		MONSTERDETAIL_034,
		// Token: 0x040097C3 RID: 38851
		[Token(Token = "0x401AD15")]
		MONSTERDETAIL_035,
		// Token: 0x040097C4 RID: 38852
		[Token(Token = "0x401AD16")]
		MONSTERDETAIL_036,
		// Token: 0x040097C5 RID: 38853
		[Token(Token = "0x401AD17")]
		MONSTERDETAIL_037,
		// Token: 0x040097C6 RID: 38854
		[Token(Token = "0x401AD18")]
		MONSTERDETAIL_038,
		// Token: 0x040097C7 RID: 38855
		[Token(Token = "0x401AD19")]
		MONSTERDETAIL_039,
		// Token: 0x040097C8 RID: 38856
		[Token(Token = "0x401AD1A")]
		MONSTERDETAIL_040,
		// Token: 0x040097C9 RID: 38857
		[Token(Token = "0x401AD1B")]
		MONSTERDETAIL_041,
		// Token: 0x040097CA RID: 38858
		[Token(Token = "0x401AD1C")]
		MONSTERDETAIL_042,
		// Token: 0x040097CB RID: 38859
		[Token(Token = "0x401AD1D")]
		MONSTERDETAIL_043,
		// Token: 0x040097CC RID: 38860
		[Token(Token = "0x401AD1E")]
		MONSTERDETAIL_044,
		// Token: 0x040097CD RID: 38861
		[Token(Token = "0x401AD1F")]
		MONSTERDETAIL_045,
		// Token: 0x040097CE RID: 38862
		[Token(Token = "0x401AD20")]
		MONSTERDETAIL_046,
		// Token: 0x040097CF RID: 38863
		[Token(Token = "0x401AD21")]
		MONSTERDETAIL_047,
		// Token: 0x040097D0 RID: 38864
		[Token(Token = "0x401AD22")]
		MONSTERDETAIL_048,
		// Token: 0x040097D1 RID: 38865
		[Token(Token = "0x401AD23")]
		MONSTERDETAIL_049,
		// Token: 0x040097D2 RID: 38866
		[Token(Token = "0x401AD24")]
		MONSTERDETAIL_050,
		// Token: 0x040097D3 RID: 38867
		[Token(Token = "0x401AD25")]
		MONSTERDETAIL_051,
		// Token: 0x040097D4 RID: 38868
		[Token(Token = "0x401AD26")]
		MONSTERDETAIL_052,
		// Token: 0x040097D5 RID: 38869
		[Token(Token = "0x401AD27")]
		MONSTERDETAIL_053,
		// Token: 0x040097D6 RID: 38870
		[Token(Token = "0x401AD28")]
		MONSTERDETAIL_054,
		// Token: 0x040097D7 RID: 38871
		[Token(Token = "0x401AD29")]
		MONSTERDETAIL_055,
		// Token: 0x040097D8 RID: 38872
		[Token(Token = "0x401AD2A")]
		MONSTERDETAIL_056,
		// Token: 0x040097D9 RID: 38873
		[Token(Token = "0x401AD2B")]
		MONSTERDETAIL_057,
		// Token: 0x040097DA RID: 38874
		[Token(Token = "0x401AD2C")]
		MONSTERDETAIL_058,
		// Token: 0x040097DB RID: 38875
		[Token(Token = "0x401AD2D")]
		MONSTERDETAIL_059,
		// Token: 0x040097DC RID: 38876
		[Token(Token = "0x401AD2E")]
		MONSTERDETAIL_060,
		// Token: 0x040097DD RID: 38877
		[Token(Token = "0x401AD2F")]
		MONSTERDETAIL_061,
		// Token: 0x040097DE RID: 38878
		[Token(Token = "0x401AD30")]
		MONSTERDETAIL_062,
		// Token: 0x040097DF RID: 38879
		[Token(Token = "0x401AD31")]
		MONSTERDETAIL_063,
		// Token: 0x040097E0 RID: 38880
		[Token(Token = "0x401AD32")]
		MONSTERDETAIL_064,
		// Token: 0x040097E1 RID: 38881
		[Token(Token = "0x401AD33")]
		MONSTERDETAIL_065,
		// Token: 0x040097E2 RID: 38882
		[Token(Token = "0x401AD34")]
		MONSTERDETAIL_066,
		// Token: 0x040097E3 RID: 38883
		[Token(Token = "0x401AD35")]
		MONSTERDETAIL_067,
		// Token: 0x040097E4 RID: 38884
		[Token(Token = "0x401AD36")]
		MONSTERDETAIL_068,
		// Token: 0x040097E5 RID: 38885
		[Token(Token = "0x401AD37")]
		MONSTERDETAIL_069,
		// Token: 0x040097E6 RID: 38886
		[Token(Token = "0x401AD38")]
		MONSTERDETAIL_070,
		// Token: 0x040097E7 RID: 38887
		[Token(Token = "0x401AD39")]
		MONSTERDETAIL_071,
		// Token: 0x040097E8 RID: 38888
		[Token(Token = "0x401AD3A")]
		MONSTERDETAIL_072,
		// Token: 0x040097E9 RID: 38889
		[Token(Token = "0x401AD3B")]
		MONSTERDETAIL_073,
		// Token: 0x040097EA RID: 38890
		[Token(Token = "0x401AD3C")]
		MONSTERDETAIL_074,
		// Token: 0x040097EB RID: 38891
		[Token(Token = "0x401AD3D")]
		MONSTERDETAIL_075,
		// Token: 0x040097EC RID: 38892
		[Token(Token = "0x401AD3E")]
		MONSTERDETAIL_076,
		// Token: 0x040097ED RID: 38893
		[Token(Token = "0x401AD3F")]
		MONSTERDETAIL_077,
		// Token: 0x040097EE RID: 38894
		[Token(Token = "0x401AD40")]
		MONSTERDETAIL_078,
		// Token: 0x040097EF RID: 38895
		[Token(Token = "0x401AD41")]
		MONSTERDETAIL_079,
		// Token: 0x040097F0 RID: 38896
		[Token(Token = "0x401AD42")]
		MONSTERDETAIL_080,
		// Token: 0x040097F1 RID: 38897
		[Token(Token = "0x401AD43")]
		MONSTERDETAIL_081,
		// Token: 0x040097F2 RID: 38898
		[Token(Token = "0x401AD44")]
		MONSTERDETAIL_082,
		// Token: 0x040097F3 RID: 38899
		[Token(Token = "0x401AD45")]
		MONSTERDETAIL_083,
		// Token: 0x040097F4 RID: 38900
		[Token(Token = "0x401AD46")]
		MONSTERDETAIL_084,
		// Token: 0x040097F5 RID: 38901
		[Token(Token = "0x401AD47")]
		MONSTERDETAIL_085,
		// Token: 0x040097F6 RID: 38902
		[Token(Token = "0x401AD48")]
		MONSTERDETAIL_086,
		// Token: 0x040097F7 RID: 38903
		[Token(Token = "0x401AD49")]
		MONSTERDETAIL_087,
		// Token: 0x040097F8 RID: 38904
		[Token(Token = "0x401AD4A")]
		MONSTERDETAIL_088,
		// Token: 0x040097F9 RID: 38905
		[Token(Token = "0x401AD4B")]
		MONSTERDETAIL_089,
		// Token: 0x040097FA RID: 38906
		[Token(Token = "0x401AD4C")]
		MONSTERDETAIL_090,
		// Token: 0x040097FB RID: 38907
		[Token(Token = "0x401AD4D")]
		MONSTERDETAIL_091,
		// Token: 0x040097FC RID: 38908
		[Token(Token = "0x401AD4E")]
		MONSTERDETAIL_092,
		// Token: 0x040097FD RID: 38909
		[Token(Token = "0x401AD4F")]
		MONSTERDETAIL_093,
		// Token: 0x040097FE RID: 38910
		[Token(Token = "0x401AD50")]
		MONSTERDETAIL_094,
		// Token: 0x040097FF RID: 38911
		[Token(Token = "0x401AD51")]
		MONSTERDETAIL_095,
		// Token: 0x04009800 RID: 38912
		[Token(Token = "0x401AD52")]
		MONSTERDETAIL_096,
		// Token: 0x04009801 RID: 38913
		[Token(Token = "0x401AD53")]
		MONSTERDETAIL_097,
		// Token: 0x04009802 RID: 38914
		[Token(Token = "0x401AD54")]
		MONSTERDETAIL_098,
		// Token: 0x04009803 RID: 38915
		[Token(Token = "0x401AD55")]
		MONSTERDETAIL_099,
		// Token: 0x04009804 RID: 38916
		[Token(Token = "0x401AD56")]
		MONSTERDETAIL_100,
		// Token: 0x04009805 RID: 38917
		[Token(Token = "0x401AD57")]
		MONSTERDETAIL_101,
		// Token: 0x04009806 RID: 38918
		[Token(Token = "0x401AD58")]
		MONSTERDETAIL_102,
		// Token: 0x04009807 RID: 38919
		[Token(Token = "0x401AD59")]
		MONSTERDETAIL_103,
		// Token: 0x04009808 RID: 38920
		[Token(Token = "0x401AD5A")]
		MONSTERDETAIL_104,
		// Token: 0x04009809 RID: 38921
		[Token(Token = "0x401AD5B")]
		MONSTERDETAIL_105,
		// Token: 0x0400980A RID: 38922
		[Token(Token = "0x401AD5C")]
		MONSTERDETAIL_106,
		// Token: 0x0400980B RID: 38923
		[Token(Token = "0x401AD5D")]
		MONSTERDETAIL_107,
		// Token: 0x0400980C RID: 38924
		[Token(Token = "0x401AD5E")]
		MONSTERDETAIL_108,
		// Token: 0x0400980D RID: 38925
		[Token(Token = "0x401AD5F")]
		MONSTERDETAIL_109,
		// Token: 0x0400980E RID: 38926
		[Token(Token = "0x401AD60")]
		MONSTERDETAIL_110,
		// Token: 0x0400980F RID: 38927
		[Token(Token = "0x401AD61")]
		MONSTERDETAIL_111,
		// Token: 0x04009810 RID: 38928
		[Token(Token = "0x401AD62")]
		MONSTERDETAIL_112,
		// Token: 0x04009811 RID: 38929
		[Token(Token = "0x401AD63")]
		MONSTERDETAIL_113,
		// Token: 0x04009812 RID: 38930
		[Token(Token = "0x401AD64")]
		MONSTERDETAIL_114,
		// Token: 0x04009813 RID: 38931
		[Token(Token = "0x401AD65")]
		MONSTERDETAIL_115,
		// Token: 0x04009814 RID: 38932
		[Token(Token = "0x401AD66")]
		MONSTERDETAIL_116,
		// Token: 0x04009815 RID: 38933
		[Token(Token = "0x401AD67")]
		MONSTERDETAIL_117,
		// Token: 0x04009816 RID: 38934
		[Token(Token = "0x401AD68")]
		MONSTERDETAIL_118,
		// Token: 0x04009817 RID: 38935
		[Token(Token = "0x401AD69")]
		MONSTERDETAIL_119,
		// Token: 0x04009818 RID: 38936
		[Token(Token = "0x401AD6A")]
		MONSTERDETAIL_120,
		// Token: 0x04009819 RID: 38937
		[Token(Token = "0x401AD6B")]
		MONSTERDETAIL_121,
		// Token: 0x0400981A RID: 38938
		[Token(Token = "0x401AD6C")]
		MONSTERDETAIL_122,
		// Token: 0x0400981B RID: 38939
		[Token(Token = "0x401AD6D")]
		MONSTERDETAIL_123,
		// Token: 0x0400981C RID: 38940
		[Token(Token = "0x401AD6E")]
		MONSTERDETAIL_124,
		// Token: 0x0400981D RID: 38941
		[Token(Token = "0x401AD6F")]
		MONSTERDETAIL_125,
		// Token: 0x0400981E RID: 38942
		[Token(Token = "0x401AD70")]
		MONSTERDETAIL_126,
		// Token: 0x0400981F RID: 38943
		[Token(Token = "0x401AD71")]
		MONSTERDETAIL_127,
		// Token: 0x04009820 RID: 38944
		[Token(Token = "0x401AD72")]
		MONSTERDETAIL_128,
		// Token: 0x04009821 RID: 38945
		[Token(Token = "0x401AD73")]
		MONSTERDETAIL_129,
		// Token: 0x04009822 RID: 38946
		[Token(Token = "0x401AD74")]
		MONSTERDETAIL_130,
		// Token: 0x04009823 RID: 38947
		[Token(Token = "0x401AD75")]
		MONSTERDETAIL_131,
		// Token: 0x04009824 RID: 38948
		[Token(Token = "0x401AD76")]
		MONSTERDETAIL_132,
		// Token: 0x04009825 RID: 38949
		[Token(Token = "0x401AD77")]
		MONSTERDETAIL_133,
		// Token: 0x04009826 RID: 38950
		[Token(Token = "0x401AD78")]
		MONSTERDETAIL_134,
		// Token: 0x04009827 RID: 38951
		[Token(Token = "0x401AD79")]
		MONSTERDETAIL_135,
		// Token: 0x04009828 RID: 38952
		[Token(Token = "0x401AD7A")]
		MONSTERDETAIL_136,
		// Token: 0x04009829 RID: 38953
		[Token(Token = "0x401AD7B")]
		MONSTERDETAIL_137,
		// Token: 0x0400982A RID: 38954
		[Token(Token = "0x401AD7C")]
		MONSTERDETAIL_138,
		// Token: 0x0400982B RID: 38955
		[Token(Token = "0x401AD7D")]
		MONSTERDETAIL_139,
		// Token: 0x0400982C RID: 38956
		[Token(Token = "0x401AD7E")]
		MONSTERDETAIL_140,
		// Token: 0x0400982D RID: 38957
		[Token(Token = "0x401AD7F")]
		MONSTERDETAIL_141,
		// Token: 0x0400982E RID: 38958
		[Token(Token = "0x401AD80")]
		MONSTERDETAIL_142,
		// Token: 0x0400982F RID: 38959
		[Token(Token = "0x401AD81")]
		MONSTERDETAIL_143,
		// Token: 0x04009830 RID: 38960
		[Token(Token = "0x401AD82")]
		MONSTERDETAIL_144,
		// Token: 0x04009831 RID: 38961
		[Token(Token = "0x401AD83")]
		MONSTERDETAIL_145,
		// Token: 0x04009832 RID: 38962
		[Token(Token = "0x401AD84")]
		MONSTERDETAIL_146,
		// Token: 0x04009833 RID: 38963
		[Token(Token = "0x401AD85")]
		MONSTERDETAIL_147,
		// Token: 0x04009834 RID: 38964
		[Token(Token = "0x401AD86")]
		MONSTERDETAIL_148,
		// Token: 0x04009835 RID: 38965
		[Token(Token = "0x401AD87")]
		MONSTERDETAIL_149,
		// Token: 0x04009836 RID: 38966
		[Token(Token = "0x401AD88")]
		MONSTERDETAIL_150,
		// Token: 0x04009837 RID: 38967
		[Token(Token = "0x401AD89")]
		MONSTERDETAIL_151,
		// Token: 0x04009838 RID: 38968
		[Token(Token = "0x401AD8A")]
		MONSTERDETAIL_152,
		// Token: 0x04009839 RID: 38969
		[Token(Token = "0x401AD8B")]
		MONSTERDETAIL_153,
		// Token: 0x0400983A RID: 38970
		[Token(Token = "0x401AD8C")]
		MONSTERDETAIL_154,
		// Token: 0x0400983B RID: 38971
		[Token(Token = "0x401AD8D")]
		MONSTERDETAIL_155,
		// Token: 0x0400983C RID: 38972
		[Token(Token = "0x401AD8E")]
		MONSTERDETAIL_156,
		// Token: 0x0400983D RID: 38973
		[Token(Token = "0x401AD8F")]
		MONSTERDETAIL_157,
		// Token: 0x0400983E RID: 38974
		[Token(Token = "0x401AD90")]
		MONSTERDETAIL_158,
		// Token: 0x0400983F RID: 38975
		[Token(Token = "0x401AD91")]
		MONSTERDETAIL_159,
		// Token: 0x04009840 RID: 38976
		[Token(Token = "0x401AD92")]
		MONSTERDETAIL_160,
		// Token: 0x04009841 RID: 38977
		[Token(Token = "0x401AD93")]
		MONSTERDETAIL_161,
		// Token: 0x04009842 RID: 38978
		[Token(Token = "0x401AD94")]
		MONSTERDETAIL_162,
		// Token: 0x04009843 RID: 38979
		[Token(Token = "0x401AD95")]
		MONSTERDETAIL_163,
		// Token: 0x04009844 RID: 38980
		[Token(Token = "0x401AD96")]
		MONSTERDETAIL_164,
		// Token: 0x04009845 RID: 38981
		[Token(Token = "0x401AD97")]
		MONSTERDETAIL_165,
		// Token: 0x04009846 RID: 38982
		[Token(Token = "0x401AD98")]
		MONSTERDETAIL_166,
		// Token: 0x04009847 RID: 38983
		[Token(Token = "0x401AD99")]
		MONSTERDETAIL_169,
		// Token: 0x04009848 RID: 38984
		[Token(Token = "0x401AD9A")]
		MONSTERDETAIL_170,
		// Token: 0x04009849 RID: 38985
		[Token(Token = "0x401AD9B")]
		MONSTERDETAIL_171,
		// Token: 0x0400984A RID: 38986
		[Token(Token = "0x401AD9C")]
		MONSTERDETAIL_172,
		// Token: 0x0400984B RID: 38987
		[Token(Token = "0x401AD9D")]
		MONSTERDETAIL_173,
		// Token: 0x0400984C RID: 38988
		[Token(Token = "0x401AD9E")]
		MONSTERDETAIL_174,
		// Token: 0x0400984D RID: 38989
		[Token(Token = "0x401AD9F")]
		MONSTERDETAIL_177,
		// Token: 0x0400984E RID: 38990
		[Token(Token = "0x401ADA0")]
		MONSTERDETAIL_178,
		// Token: 0x0400984F RID: 38991
		[Token(Token = "0x401ADA1")]
		MONSTERDETAIL_179,
		// Token: 0x04009850 RID: 38992
		[Token(Token = "0x401ADA2")]
		MONSTERDETAIL_180,
		// Token: 0x04009851 RID: 38993
		[Token(Token = "0x401ADA3")]
		MONSTERDETAIL_181,
		// Token: 0x04009852 RID: 38994
		[Token(Token = "0x401ADA4")]
		MONSTERDETAIL_182,
		// Token: 0x04009853 RID: 38995
		[Token(Token = "0x401ADA5")]
		MONSTERDETAIL_183,
		// Token: 0x04009854 RID: 38996
		[Token(Token = "0x401ADA6")]
		MONSTERDETAIL_184,
		// Token: 0x04009855 RID: 38997
		[Token(Token = "0x401ADA7")]
		MONSTERDETAIL_191,
		// Token: 0x04009856 RID: 38998
		[Token(Token = "0x401ADA8")]
		MONSTERDETAIL_192,
		// Token: 0x04009857 RID: 38999
		[Token(Token = "0x401ADA9")]
		MONSTERDETAIL_195,
		// Token: 0x04009858 RID: 39000
		[Token(Token = "0x401ADAA")]
		MONSTERDETAIL_196,
		// Token: 0x04009859 RID: 39001
		[Token(Token = "0x401ADAB")]
		MONSTERDETAIL_197,
		// Token: 0x0400985A RID: 39002
		[Token(Token = "0x401ADAC")]
		MONSTERDETAIL_198,
		// Token: 0x0400985B RID: 39003
		[Token(Token = "0x401ADAD")]
		MONSTERDETAIL_202,
		// Token: 0x0400985C RID: 39004
		[Token(Token = "0x401ADAE")]
		MONSTERNAME_000_1,
		// Token: 0x0400985D RID: 39005
		[Token(Token = "0x401ADAF")]
		MONSTERNAME_000_2,
		// Token: 0x0400985E RID: 39006
		[Token(Token = "0x401ADB0")]
		MONSTERNAME_000_3,
		// Token: 0x0400985F RID: 39007
		[Token(Token = "0x401ADB1")]
		MONSTERNAME_000_4,
		// Token: 0x04009860 RID: 39008
		[Token(Token = "0x401ADB2")]
		MONSTERNAME_001_1,
		// Token: 0x04009861 RID: 39009
		[Token(Token = "0x401ADB3")]
		MONSTERNAME_001_2,
		// Token: 0x04009862 RID: 39010
		[Token(Token = "0x401ADB4")]
		MONSTERNAME_001_3,
		// Token: 0x04009863 RID: 39011
		[Token(Token = "0x401ADB5")]
		MONSTERNAME_001_4,
		// Token: 0x04009864 RID: 39012
		[Token(Token = "0x401ADB6")]
		MONSTERNAME_002_1,
		// Token: 0x04009865 RID: 39013
		[Token(Token = "0x401ADB7")]
		MONSTERNAME_002_2,
		// Token: 0x04009866 RID: 39014
		[Token(Token = "0x401ADB8")]
		MONSTERNAME_002_3,
		// Token: 0x04009867 RID: 39015
		[Token(Token = "0x401ADB9")]
		MONSTERNAME_002_4,
		// Token: 0x04009868 RID: 39016
		[Token(Token = "0x401ADBA")]
		MONSTERNAME_003_1,
		// Token: 0x04009869 RID: 39017
		[Token(Token = "0x401ADBB")]
		MONSTERNAME_003_2,
		// Token: 0x0400986A RID: 39018
		[Token(Token = "0x401ADBC")]
		MONSTERNAME_003_3,
		// Token: 0x0400986B RID: 39019
		[Token(Token = "0x401ADBD")]
		MONSTERNAME_003_4,
		// Token: 0x0400986C RID: 39020
		[Token(Token = "0x401ADBE")]
		MONSTERNAME_004_1,
		// Token: 0x0400986D RID: 39021
		[Token(Token = "0x401ADBF")]
		MONSTERNAME_004_2,
		// Token: 0x0400986E RID: 39022
		[Token(Token = "0x401ADC0")]
		MONSTERNAME_004_3,
		// Token: 0x0400986F RID: 39023
		[Token(Token = "0x401ADC1")]
		MONSTERNAME_004_4,
		// Token: 0x04009870 RID: 39024
		[Token(Token = "0x401ADC2")]
		MONSTERNAME_005_1,
		// Token: 0x04009871 RID: 39025
		[Token(Token = "0x401ADC3")]
		MONSTERNAME_005_2,
		// Token: 0x04009872 RID: 39026
		[Token(Token = "0x401ADC4")]
		MONSTERNAME_005_3,
		// Token: 0x04009873 RID: 39027
		[Token(Token = "0x401ADC5")]
		MONSTERNAME_005_4,
		// Token: 0x04009874 RID: 39028
		[Token(Token = "0x401ADC6")]
		MONSTERNAME_006_1,
		// Token: 0x04009875 RID: 39029
		[Token(Token = "0x401ADC7")]
		MONSTERNAME_006_2,
		// Token: 0x04009876 RID: 39030
		[Token(Token = "0x401ADC8")]
		MONSTERNAME_006_3,
		// Token: 0x04009877 RID: 39031
		[Token(Token = "0x401ADC9")]
		MONSTERNAME_006_4,
		// Token: 0x04009878 RID: 39032
		[Token(Token = "0x401ADCA")]
		MONSTERNAME_007_1,
		// Token: 0x04009879 RID: 39033
		[Token(Token = "0x401ADCB")]
		MONSTERNAME_007_2,
		// Token: 0x0400987A RID: 39034
		[Token(Token = "0x401ADCC")]
		MONSTERNAME_007_3,
		// Token: 0x0400987B RID: 39035
		[Token(Token = "0x401ADCD")]
		MONSTERNAME_007_4,
		// Token: 0x0400987C RID: 39036
		[Token(Token = "0x401ADCE")]
		MONSTERNAME_009_1,
		// Token: 0x0400987D RID: 39037
		[Token(Token = "0x401ADCF")]
		MONSTERNAME_009_2,
		// Token: 0x0400987E RID: 39038
		[Token(Token = "0x401ADD0")]
		MONSTERNAME_009_3,
		// Token: 0x0400987F RID: 39039
		[Token(Token = "0x401ADD1")]
		MONSTERNAME_009_4,
		// Token: 0x04009880 RID: 39040
		[Token(Token = "0x401ADD2")]
		MONSTERNAME_010_1,
		// Token: 0x04009881 RID: 39041
		[Token(Token = "0x401ADD3")]
		MONSTERNAME_010_2,
		// Token: 0x04009882 RID: 39042
		[Token(Token = "0x401ADD4")]
		MONSTERNAME_010_3,
		// Token: 0x04009883 RID: 39043
		[Token(Token = "0x401ADD5")]
		MONSTERNAME_010_4,
		// Token: 0x04009884 RID: 39044
		[Token(Token = "0x401ADD6")]
		MONSTERNAME_011_1,
		// Token: 0x04009885 RID: 39045
		[Token(Token = "0x401ADD7")]
		MONSTERNAME_011_2,
		// Token: 0x04009886 RID: 39046
		[Token(Token = "0x401ADD8")]
		MONSTERNAME_011_3,
		// Token: 0x04009887 RID: 39047
		[Token(Token = "0x401ADD9")]
		MONSTERNAME_011_4,
		// Token: 0x04009888 RID: 39048
		[Token(Token = "0x401ADDA")]
		MONSTERNAME_012_1,
		// Token: 0x04009889 RID: 39049
		[Token(Token = "0x401ADDB")]
		MONSTERNAME_012_2,
		// Token: 0x0400988A RID: 39050
		[Token(Token = "0x401ADDC")]
		MONSTERNAME_012_3,
		// Token: 0x0400988B RID: 39051
		[Token(Token = "0x401ADDD")]
		MONSTERNAME_012_4,
		// Token: 0x0400988C RID: 39052
		[Token(Token = "0x401ADDE")]
		MONSTERNAME_013_1,
		// Token: 0x0400988D RID: 39053
		[Token(Token = "0x401ADDF")]
		MONSTERNAME_013_2,
		// Token: 0x0400988E RID: 39054
		[Token(Token = "0x401ADE0")]
		MONSTERNAME_013_3,
		// Token: 0x0400988F RID: 39055
		[Token(Token = "0x401ADE1")]
		MONSTERNAME_013_4,
		// Token: 0x04009890 RID: 39056
		[Token(Token = "0x401ADE2")]
		MONSTERNAME_014_1,
		// Token: 0x04009891 RID: 39057
		[Token(Token = "0x401ADE3")]
		MONSTERNAME_014_2,
		// Token: 0x04009892 RID: 39058
		[Token(Token = "0x401ADE4")]
		MONSTERNAME_014_3,
		// Token: 0x04009893 RID: 39059
		[Token(Token = "0x401ADE5")]
		MONSTERNAME_014_4,
		// Token: 0x04009894 RID: 39060
		[Token(Token = "0x401ADE6")]
		MONSTERNAME_015_1,
		// Token: 0x04009895 RID: 39061
		[Token(Token = "0x401ADE7")]
		MONSTERNAME_015_2,
		// Token: 0x04009896 RID: 39062
		[Token(Token = "0x401ADE8")]
		MONSTERNAME_015_3,
		// Token: 0x04009897 RID: 39063
		[Token(Token = "0x401ADE9")]
		MONSTERNAME_015_4,
		// Token: 0x04009898 RID: 39064
		[Token(Token = "0x401ADEA")]
		MONSTERNAME_016_1,
		// Token: 0x04009899 RID: 39065
		[Token(Token = "0x401ADEB")]
		MONSTERNAME_016_2,
		// Token: 0x0400989A RID: 39066
		[Token(Token = "0x401ADEC")]
		MONSTERNAME_016_3,
		// Token: 0x0400989B RID: 39067
		[Token(Token = "0x401ADED")]
		MONSTERNAME_016_4,
		// Token: 0x0400989C RID: 39068
		[Token(Token = "0x401ADEE")]
		MONSTERNAME_017_1,
		// Token: 0x0400989D RID: 39069
		[Token(Token = "0x401ADEF")]
		MONSTERNAME_017_2,
		// Token: 0x0400989E RID: 39070
		[Token(Token = "0x401ADF0")]
		MONSTERNAME_017_3,
		// Token: 0x0400989F RID: 39071
		[Token(Token = "0x401ADF1")]
		MONSTERNAME_017_4,
		// Token: 0x040098A0 RID: 39072
		[Token(Token = "0x401ADF2")]
		MONSTERNAME_018_1,
		// Token: 0x040098A1 RID: 39073
		[Token(Token = "0x401ADF3")]
		MONSTERNAME_018_2,
		// Token: 0x040098A2 RID: 39074
		[Token(Token = "0x401ADF4")]
		MONSTERNAME_018_3,
		// Token: 0x040098A3 RID: 39075
		[Token(Token = "0x401ADF5")]
		MONSTERNAME_018_4,
		// Token: 0x040098A4 RID: 39076
		[Token(Token = "0x401ADF6")]
		MONSTERNAME_019_1,
		// Token: 0x040098A5 RID: 39077
		[Token(Token = "0x401ADF7")]
		MONSTERNAME_019_2,
		// Token: 0x040098A6 RID: 39078
		[Token(Token = "0x401ADF8")]
		MONSTERNAME_019_3,
		// Token: 0x040098A7 RID: 39079
		[Token(Token = "0x401ADF9")]
		MONSTERNAME_019_4,
		// Token: 0x040098A8 RID: 39080
		[Token(Token = "0x401ADFA")]
		MONSTERNAME_020_1,
		// Token: 0x040098A9 RID: 39081
		[Token(Token = "0x401ADFB")]
		MONSTERNAME_020_2,
		// Token: 0x040098AA RID: 39082
		[Token(Token = "0x401ADFC")]
		MONSTERNAME_020_3,
		// Token: 0x040098AB RID: 39083
		[Token(Token = "0x401ADFD")]
		MONSTERNAME_020_4,
		// Token: 0x040098AC RID: 39084
		[Token(Token = "0x401ADFE")]
		MONSTERNAME_021_1,
		// Token: 0x040098AD RID: 39085
		[Token(Token = "0x401ADFF")]
		MONSTERNAME_021_2,
		// Token: 0x040098AE RID: 39086
		[Token(Token = "0x401AE00")]
		MONSTERNAME_021_3,
		// Token: 0x040098AF RID: 39087
		[Token(Token = "0x401AE01")]
		MONSTERNAME_021_4,
		// Token: 0x040098B0 RID: 39088
		[Token(Token = "0x401AE02")]
		MONSTERNAME_022_1,
		// Token: 0x040098B1 RID: 39089
		[Token(Token = "0x401AE03")]
		MONSTERNAME_022_2,
		// Token: 0x040098B2 RID: 39090
		[Token(Token = "0x401AE04")]
		MONSTERNAME_022_3,
		// Token: 0x040098B3 RID: 39091
		[Token(Token = "0x401AE05")]
		MONSTERNAME_022_4,
		// Token: 0x040098B4 RID: 39092
		[Token(Token = "0x401AE06")]
		MONSTERNAME_023_1,
		// Token: 0x040098B5 RID: 39093
		[Token(Token = "0x401AE07")]
		MONSTERNAME_023_2,
		// Token: 0x040098B6 RID: 39094
		[Token(Token = "0x401AE08")]
		MONSTERNAME_023_3,
		// Token: 0x040098B7 RID: 39095
		[Token(Token = "0x401AE09")]
		MONSTERNAME_023_4,
		// Token: 0x040098B8 RID: 39096
		[Token(Token = "0x401AE0A")]
		MONSTERNAME_024_1,
		// Token: 0x040098B9 RID: 39097
		[Token(Token = "0x401AE0B")]
		MONSTERNAME_024_2,
		// Token: 0x040098BA RID: 39098
		[Token(Token = "0x401AE0C")]
		MONSTERNAME_024_3,
		// Token: 0x040098BB RID: 39099
		[Token(Token = "0x401AE0D")]
		MONSTERNAME_024_4,
		// Token: 0x040098BC RID: 39100
		[Token(Token = "0x401AE0E")]
		MONSTERNAME_025_1,
		// Token: 0x040098BD RID: 39101
		[Token(Token = "0x401AE0F")]
		MONSTERNAME_025_2,
		// Token: 0x040098BE RID: 39102
		[Token(Token = "0x401AE10")]
		MONSTERNAME_025_3,
		// Token: 0x040098BF RID: 39103
		[Token(Token = "0x401AE11")]
		MONSTERNAME_025_4,
		// Token: 0x040098C0 RID: 39104
		[Token(Token = "0x401AE12")]
		MONSTERNAME_026_1,
		// Token: 0x040098C1 RID: 39105
		[Token(Token = "0x401AE13")]
		MONSTERNAME_026_2,
		// Token: 0x040098C2 RID: 39106
		[Token(Token = "0x401AE14")]
		MONSTERNAME_026_3,
		// Token: 0x040098C3 RID: 39107
		[Token(Token = "0x401AE15")]
		MONSTERNAME_026_4,
		// Token: 0x040098C4 RID: 39108
		[Token(Token = "0x401AE16")]
		MONSTERNAME_027_1,
		// Token: 0x040098C5 RID: 39109
		[Token(Token = "0x401AE17")]
		MONSTERNAME_027_2,
		// Token: 0x040098C6 RID: 39110
		[Token(Token = "0x401AE18")]
		MONSTERNAME_027_3,
		// Token: 0x040098C7 RID: 39111
		[Token(Token = "0x401AE19")]
		MONSTERNAME_027_4,
		// Token: 0x040098C8 RID: 39112
		[Token(Token = "0x401AE1A")]
		MONSTERNAME_028_1,
		// Token: 0x040098C9 RID: 39113
		[Token(Token = "0x401AE1B")]
		MONSTERNAME_028_2,
		// Token: 0x040098CA RID: 39114
		[Token(Token = "0x401AE1C")]
		MONSTERNAME_028_3,
		// Token: 0x040098CB RID: 39115
		[Token(Token = "0x401AE1D")]
		MONSTERNAME_028_4,
		// Token: 0x040098CC RID: 39116
		[Token(Token = "0x401AE1E")]
		MONSTERNAME_029_1,
		// Token: 0x040098CD RID: 39117
		[Token(Token = "0x401AE1F")]
		MONSTERNAME_029_2,
		// Token: 0x040098CE RID: 39118
		[Token(Token = "0x401AE20")]
		MONSTERNAME_029_3,
		// Token: 0x040098CF RID: 39119
		[Token(Token = "0x401AE21")]
		MONSTERNAME_029_4,
		// Token: 0x040098D0 RID: 39120
		[Token(Token = "0x401AE22")]
		MONSTERNAME_030_1,
		// Token: 0x040098D1 RID: 39121
		[Token(Token = "0x401AE23")]
		MONSTERNAME_030_2,
		// Token: 0x040098D2 RID: 39122
		[Token(Token = "0x401AE24")]
		MONSTERNAME_030_3,
		// Token: 0x040098D3 RID: 39123
		[Token(Token = "0x401AE25")]
		MONSTERNAME_030_4,
		// Token: 0x040098D4 RID: 39124
		[Token(Token = "0x401AE26")]
		MONSTERNAME_031_1,
		// Token: 0x040098D5 RID: 39125
		[Token(Token = "0x401AE27")]
		MONSTERNAME_031_2,
		// Token: 0x040098D6 RID: 39126
		[Token(Token = "0x401AE28")]
		MONSTERNAME_031_3,
		// Token: 0x040098D7 RID: 39127
		[Token(Token = "0x401AE29")]
		MONSTERNAME_031_4,
		// Token: 0x040098D8 RID: 39128
		[Token(Token = "0x401AE2A")]
		MONSTERNAME_032_1,
		// Token: 0x040098D9 RID: 39129
		[Token(Token = "0x401AE2B")]
		MONSTERNAME_032_2,
		// Token: 0x040098DA RID: 39130
		[Token(Token = "0x401AE2C")]
		MONSTERNAME_032_3,
		// Token: 0x040098DB RID: 39131
		[Token(Token = "0x401AE2D")]
		MONSTERNAME_032_4,
		// Token: 0x040098DC RID: 39132
		[Token(Token = "0x401AE2E")]
		MONSTERNAME_033_1,
		// Token: 0x040098DD RID: 39133
		[Token(Token = "0x401AE2F")]
		MONSTERNAME_033_2,
		// Token: 0x040098DE RID: 39134
		[Token(Token = "0x401AE30")]
		MONSTERNAME_033_3,
		// Token: 0x040098DF RID: 39135
		[Token(Token = "0x401AE31")]
		MONSTERNAME_033_4,
		// Token: 0x040098E0 RID: 39136
		[Token(Token = "0x401AE32")]
		MONSTERNAME_034_1,
		// Token: 0x040098E1 RID: 39137
		[Token(Token = "0x401AE33")]
		MONSTERNAME_034_2,
		// Token: 0x040098E2 RID: 39138
		[Token(Token = "0x401AE34")]
		MONSTERNAME_034_3,
		// Token: 0x040098E3 RID: 39139
		[Token(Token = "0x401AE35")]
		MONSTERNAME_034_4,
		// Token: 0x040098E4 RID: 39140
		[Token(Token = "0x401AE36")]
		MONSTERNAME_035_1,
		// Token: 0x040098E5 RID: 39141
		[Token(Token = "0x401AE37")]
		MONSTERNAME_035_2,
		// Token: 0x040098E6 RID: 39142
		[Token(Token = "0x401AE38")]
		MONSTERNAME_035_3,
		// Token: 0x040098E7 RID: 39143
		[Token(Token = "0x401AE39")]
		MONSTERNAME_035_4,
		// Token: 0x040098E8 RID: 39144
		[Token(Token = "0x401AE3A")]
		MONSTERNAME_036_1,
		// Token: 0x040098E9 RID: 39145
		[Token(Token = "0x401AE3B")]
		MONSTERNAME_036_2,
		// Token: 0x040098EA RID: 39146
		[Token(Token = "0x401AE3C")]
		MONSTERNAME_036_3,
		// Token: 0x040098EB RID: 39147
		[Token(Token = "0x401AE3D")]
		MONSTERNAME_036_4,
		// Token: 0x040098EC RID: 39148
		[Token(Token = "0x401AE3E")]
		MONSTERNAME_037_1,
		// Token: 0x040098ED RID: 39149
		[Token(Token = "0x401AE3F")]
		MONSTERNAME_037_2,
		// Token: 0x040098EE RID: 39150
		[Token(Token = "0x401AE40")]
		MONSTERNAME_037_3,
		// Token: 0x040098EF RID: 39151
		[Token(Token = "0x401AE41")]
		MONSTERNAME_037_4,
		// Token: 0x040098F0 RID: 39152
		[Token(Token = "0x401AE42")]
		MONSTERNAME_038_1,
		// Token: 0x040098F1 RID: 39153
		[Token(Token = "0x401AE43")]
		MONSTERNAME_038_2,
		// Token: 0x040098F2 RID: 39154
		[Token(Token = "0x401AE44")]
		MONSTERNAME_038_3,
		// Token: 0x040098F3 RID: 39155
		[Token(Token = "0x401AE45")]
		MONSTERNAME_038_4,
		// Token: 0x040098F4 RID: 39156
		[Token(Token = "0x401AE46")]
		MONSTERNAME_039_1,
		// Token: 0x040098F5 RID: 39157
		[Token(Token = "0x401AE47")]
		MONSTERNAME_039_2,
		// Token: 0x040098F6 RID: 39158
		[Token(Token = "0x401AE48")]
		MONSTERNAME_039_3,
		// Token: 0x040098F7 RID: 39159
		[Token(Token = "0x401AE49")]
		MONSTERNAME_039_4,
		// Token: 0x040098F8 RID: 39160
		[Token(Token = "0x401AE4A")]
		MONSTERNAME_040_1,
		// Token: 0x040098F9 RID: 39161
		[Token(Token = "0x401AE4B")]
		MONSTERNAME_040_2,
		// Token: 0x040098FA RID: 39162
		[Token(Token = "0x401AE4C")]
		MONSTERNAME_040_3,
		// Token: 0x040098FB RID: 39163
		[Token(Token = "0x401AE4D")]
		MONSTERNAME_040_4,
		// Token: 0x040098FC RID: 39164
		[Token(Token = "0x401AE4E")]
		MONSTERNAME_041_1,
		// Token: 0x040098FD RID: 39165
		[Token(Token = "0x401AE4F")]
		MONSTERNAME_041_2,
		// Token: 0x040098FE RID: 39166
		[Token(Token = "0x401AE50")]
		MONSTERNAME_041_3,
		// Token: 0x040098FF RID: 39167
		[Token(Token = "0x401AE51")]
		MONSTERNAME_041_4,
		// Token: 0x04009900 RID: 39168
		[Token(Token = "0x401AE52")]
		MONSTERNAME_042_1,
		// Token: 0x04009901 RID: 39169
		[Token(Token = "0x401AE53")]
		MONSTERNAME_042_2,
		// Token: 0x04009902 RID: 39170
		[Token(Token = "0x401AE54")]
		MONSTERNAME_042_3,
		// Token: 0x04009903 RID: 39171
		[Token(Token = "0x401AE55")]
		MONSTERNAME_042_4,
		// Token: 0x04009904 RID: 39172
		[Token(Token = "0x401AE56")]
		MONSTERNAME_043_1,
		// Token: 0x04009905 RID: 39173
		[Token(Token = "0x401AE57")]
		MONSTERNAME_043_2,
		// Token: 0x04009906 RID: 39174
		[Token(Token = "0x401AE58")]
		MONSTERNAME_043_3,
		// Token: 0x04009907 RID: 39175
		[Token(Token = "0x401AE59")]
		MONSTERNAME_043_4,
		// Token: 0x04009908 RID: 39176
		[Token(Token = "0x401AE5A")]
		MONSTERNAME_044_1,
		// Token: 0x04009909 RID: 39177
		[Token(Token = "0x401AE5B")]
		MONSTERNAME_044_2,
		// Token: 0x0400990A RID: 39178
		[Token(Token = "0x401AE5C")]
		MONSTERNAME_044_3,
		// Token: 0x0400990B RID: 39179
		[Token(Token = "0x401AE5D")]
		MONSTERNAME_044_4,
		// Token: 0x0400990C RID: 39180
		[Token(Token = "0x401AE5E")]
		MONSTERNAME_045_1,
		// Token: 0x0400990D RID: 39181
		[Token(Token = "0x401AE5F")]
		MONSTERNAME_045_2,
		// Token: 0x0400990E RID: 39182
		[Token(Token = "0x401AE60")]
		MONSTERNAME_045_3,
		// Token: 0x0400990F RID: 39183
		[Token(Token = "0x401AE61")]
		MONSTERNAME_045_4,
		// Token: 0x04009910 RID: 39184
		[Token(Token = "0x401AE62")]
		MONSTERNAME_046_1,
		// Token: 0x04009911 RID: 39185
		[Token(Token = "0x401AE63")]
		MONSTERNAME_046_2,
		// Token: 0x04009912 RID: 39186
		[Token(Token = "0x401AE64")]
		MONSTERNAME_046_3,
		// Token: 0x04009913 RID: 39187
		[Token(Token = "0x401AE65")]
		MONSTERNAME_046_4,
		// Token: 0x04009914 RID: 39188
		[Token(Token = "0x401AE66")]
		MONSTERNAME_047_1,
		// Token: 0x04009915 RID: 39189
		[Token(Token = "0x401AE67")]
		MONSTERNAME_047_2,
		// Token: 0x04009916 RID: 39190
		[Token(Token = "0x401AE68")]
		MONSTERNAME_047_3,
		// Token: 0x04009917 RID: 39191
		[Token(Token = "0x401AE69")]
		MONSTERNAME_047_4,
		// Token: 0x04009918 RID: 39192
		[Token(Token = "0x401AE6A")]
		MONSTERNAME_048_1,
		// Token: 0x04009919 RID: 39193
		[Token(Token = "0x401AE6B")]
		MONSTERNAME_048_2,
		// Token: 0x0400991A RID: 39194
		[Token(Token = "0x401AE6C")]
		MONSTERNAME_048_3,
		// Token: 0x0400991B RID: 39195
		[Token(Token = "0x401AE6D")]
		MONSTERNAME_048_4,
		// Token: 0x0400991C RID: 39196
		[Token(Token = "0x401AE6E")]
		MONSTERNAME_049_1,
		// Token: 0x0400991D RID: 39197
		[Token(Token = "0x401AE6F")]
		MONSTERNAME_049_2,
		// Token: 0x0400991E RID: 39198
		[Token(Token = "0x401AE70")]
		MONSTERNAME_049_3,
		// Token: 0x0400991F RID: 39199
		[Token(Token = "0x401AE71")]
		MONSTERNAME_049_4,
		// Token: 0x04009920 RID: 39200
		[Token(Token = "0x401AE72")]
		MONSTERNAME_050_1,
		// Token: 0x04009921 RID: 39201
		[Token(Token = "0x401AE73")]
		MONSTERNAME_050_2,
		// Token: 0x04009922 RID: 39202
		[Token(Token = "0x401AE74")]
		MONSTERNAME_050_3,
		// Token: 0x04009923 RID: 39203
		[Token(Token = "0x401AE75")]
		MONSTERNAME_050_4,
		// Token: 0x04009924 RID: 39204
		[Token(Token = "0x401AE76")]
		MONSTERNAME_051_1,
		// Token: 0x04009925 RID: 39205
		[Token(Token = "0x401AE77")]
		MONSTERNAME_051_2,
		// Token: 0x04009926 RID: 39206
		[Token(Token = "0x401AE78")]
		MONSTERNAME_051_3,
		// Token: 0x04009927 RID: 39207
		[Token(Token = "0x401AE79")]
		MONSTERNAME_051_4,
		// Token: 0x04009928 RID: 39208
		[Token(Token = "0x401AE7A")]
		MONSTERNAME_053_1,
		// Token: 0x04009929 RID: 39209
		[Token(Token = "0x401AE7B")]
		MONSTERNAME_053_2,
		// Token: 0x0400992A RID: 39210
		[Token(Token = "0x401AE7C")]
		MONSTERNAME_053_3,
		// Token: 0x0400992B RID: 39211
		[Token(Token = "0x401AE7D")]
		MONSTERNAME_053_4,
		// Token: 0x0400992C RID: 39212
		[Token(Token = "0x401AE7E")]
		MONSTERNAME_054_1,
		// Token: 0x0400992D RID: 39213
		[Token(Token = "0x401AE7F")]
		MONSTERNAME_054_2,
		// Token: 0x0400992E RID: 39214
		[Token(Token = "0x401AE80")]
		MONSTERNAME_054_3,
		// Token: 0x0400992F RID: 39215
		[Token(Token = "0x401AE81")]
		MONSTERNAME_054_4,
		// Token: 0x04009930 RID: 39216
		[Token(Token = "0x401AE82")]
		MONSTERNAME_055_1,
		// Token: 0x04009931 RID: 39217
		[Token(Token = "0x401AE83")]
		MONSTERNAME_055_2,
		// Token: 0x04009932 RID: 39218
		[Token(Token = "0x401AE84")]
		MONSTERNAME_055_3,
		// Token: 0x04009933 RID: 39219
		[Token(Token = "0x401AE85")]
		MONSTERNAME_055_4,
		// Token: 0x04009934 RID: 39220
		[Token(Token = "0x401AE86")]
		MONSTERNAME_056_1,
		// Token: 0x04009935 RID: 39221
		[Token(Token = "0x401AE87")]
		MONSTERNAME_056_2,
		// Token: 0x04009936 RID: 39222
		[Token(Token = "0x401AE88")]
		MONSTERNAME_056_3,
		// Token: 0x04009937 RID: 39223
		[Token(Token = "0x401AE89")]
		MONSTERNAME_056_4,
		// Token: 0x04009938 RID: 39224
		[Token(Token = "0x401AE8A")]
		MONSTERNAME_057_1,
		// Token: 0x04009939 RID: 39225
		[Token(Token = "0x401AE8B")]
		MONSTERNAME_057_2,
		// Token: 0x0400993A RID: 39226
		[Token(Token = "0x401AE8C")]
		MONSTERNAME_057_3,
		// Token: 0x0400993B RID: 39227
		[Token(Token = "0x401AE8D")]
		MONSTERNAME_057_4,
		// Token: 0x0400993C RID: 39228
		[Token(Token = "0x401AE8E")]
		MONSTERNAME_058_1,
		// Token: 0x0400993D RID: 39229
		[Token(Token = "0x401AE8F")]
		MONSTERNAME_058_2,
		// Token: 0x0400993E RID: 39230
		[Token(Token = "0x401AE90")]
		MONSTERNAME_058_3,
		// Token: 0x0400993F RID: 39231
		[Token(Token = "0x401AE91")]
		MONSTERNAME_058_4,
		// Token: 0x04009940 RID: 39232
		[Token(Token = "0x401AE92")]
		MONSTERNAME_059_1,
		// Token: 0x04009941 RID: 39233
		[Token(Token = "0x401AE93")]
		MONSTERNAME_059_2,
		// Token: 0x04009942 RID: 39234
		[Token(Token = "0x401AE94")]
		MONSTERNAME_059_3,
		// Token: 0x04009943 RID: 39235
		[Token(Token = "0x401AE95")]
		MONSTERNAME_059_4,
		// Token: 0x04009944 RID: 39236
		[Token(Token = "0x401AE96")]
		MONSTERNAME_060_1,
		// Token: 0x04009945 RID: 39237
		[Token(Token = "0x401AE97")]
		MONSTERNAME_060_2,
		// Token: 0x04009946 RID: 39238
		[Token(Token = "0x401AE98")]
		MONSTERNAME_060_3,
		// Token: 0x04009947 RID: 39239
		[Token(Token = "0x401AE99")]
		MONSTERNAME_060_4,
		// Token: 0x04009948 RID: 39240
		[Token(Token = "0x401AE9A")]
		MONSTERNAME_061_1,
		// Token: 0x04009949 RID: 39241
		[Token(Token = "0x401AE9B")]
		MONSTERNAME_061_2,
		// Token: 0x0400994A RID: 39242
		[Token(Token = "0x401AE9C")]
		MONSTERNAME_061_3,
		// Token: 0x0400994B RID: 39243
		[Token(Token = "0x401AE9D")]
		MONSTERNAME_061_4,
		// Token: 0x0400994C RID: 39244
		[Token(Token = "0x401AE9E")]
		MONSTERNAME_062_1,
		// Token: 0x0400994D RID: 39245
		[Token(Token = "0x401AE9F")]
		MONSTERNAME_062_2,
		// Token: 0x0400994E RID: 39246
		[Token(Token = "0x401AEA0")]
		MONSTERNAME_062_3,
		// Token: 0x0400994F RID: 39247
		[Token(Token = "0x401AEA1")]
		MONSTERNAME_062_4,
		// Token: 0x04009950 RID: 39248
		[Token(Token = "0x401AEA2")]
		MONSTERNAME_063_1,
		// Token: 0x04009951 RID: 39249
		[Token(Token = "0x401AEA3")]
		MONSTERNAME_063_2,
		// Token: 0x04009952 RID: 39250
		[Token(Token = "0x401AEA4")]
		MONSTERNAME_063_3,
		// Token: 0x04009953 RID: 39251
		[Token(Token = "0x401AEA5")]
		MONSTERNAME_063_4,
		// Token: 0x04009954 RID: 39252
		[Token(Token = "0x401AEA6")]
		MONSTERNAME_064_1,
		// Token: 0x04009955 RID: 39253
		[Token(Token = "0x401AEA7")]
		MONSTERNAME_064_2,
		// Token: 0x04009956 RID: 39254
		[Token(Token = "0x401AEA8")]
		MONSTERNAME_064_3,
		// Token: 0x04009957 RID: 39255
		[Token(Token = "0x401AEA9")]
		MONSTERNAME_064_4,
		// Token: 0x04009958 RID: 39256
		[Token(Token = "0x401AEAA")]
		MONSTERNAME_065_1,
		// Token: 0x04009959 RID: 39257
		[Token(Token = "0x401AEAB")]
		MONSTERNAME_065_2,
		// Token: 0x0400995A RID: 39258
		[Token(Token = "0x401AEAC")]
		MONSTERNAME_065_3,
		// Token: 0x0400995B RID: 39259
		[Token(Token = "0x401AEAD")]
		MONSTERNAME_065_4,
		// Token: 0x0400995C RID: 39260
		[Token(Token = "0x401AEAE")]
		MONSTERNAME_066_1,
		// Token: 0x0400995D RID: 39261
		[Token(Token = "0x401AEAF")]
		MONSTERNAME_066_2,
		// Token: 0x0400995E RID: 39262
		[Token(Token = "0x401AEB0")]
		MONSTERNAME_066_3,
		// Token: 0x0400995F RID: 39263
		[Token(Token = "0x401AEB1")]
		MONSTERNAME_066_4,
		// Token: 0x04009960 RID: 39264
		[Token(Token = "0x401AEB2")]
		MONSTERNAME_067_1,
		// Token: 0x04009961 RID: 39265
		[Token(Token = "0x401AEB3")]
		MONSTERNAME_067_2,
		// Token: 0x04009962 RID: 39266
		[Token(Token = "0x401AEB4")]
		MONSTERNAME_067_3,
		// Token: 0x04009963 RID: 39267
		[Token(Token = "0x401AEB5")]
		MONSTERNAME_067_4,
		// Token: 0x04009964 RID: 39268
		[Token(Token = "0x401AEB6")]
		MONSTERNAME_068_1,
		// Token: 0x04009965 RID: 39269
		[Token(Token = "0x401AEB7")]
		MONSTERNAME_068_2,
		// Token: 0x04009966 RID: 39270
		[Token(Token = "0x401AEB8")]
		MONSTERNAME_068_3,
		// Token: 0x04009967 RID: 39271
		[Token(Token = "0x401AEB9")]
		MONSTERNAME_068_4,
		// Token: 0x04009968 RID: 39272
		[Token(Token = "0x401AEBA")]
		MONSTERNAME_069_1,
		// Token: 0x04009969 RID: 39273
		[Token(Token = "0x401AEBB")]
		MONSTERNAME_069_2,
		// Token: 0x0400996A RID: 39274
		[Token(Token = "0x401AEBC")]
		MONSTERNAME_069_3,
		// Token: 0x0400996B RID: 39275
		[Token(Token = "0x401AEBD")]
		MONSTERNAME_069_4,
		// Token: 0x0400996C RID: 39276
		[Token(Token = "0x401AEBE")]
		MONSTERNAME_070_1,
		// Token: 0x0400996D RID: 39277
		[Token(Token = "0x401AEBF")]
		MONSTERNAME_070_2,
		// Token: 0x0400996E RID: 39278
		[Token(Token = "0x401AEC0")]
		MONSTERNAME_070_3,
		// Token: 0x0400996F RID: 39279
		[Token(Token = "0x401AEC1")]
		MONSTERNAME_070_4,
		// Token: 0x04009970 RID: 39280
		[Token(Token = "0x401AEC2")]
		MONSTERNAME_071_1,
		// Token: 0x04009971 RID: 39281
		[Token(Token = "0x401AEC3")]
		MONSTERNAME_071_2,
		// Token: 0x04009972 RID: 39282
		[Token(Token = "0x401AEC4")]
		MONSTERNAME_071_3,
		// Token: 0x04009973 RID: 39283
		[Token(Token = "0x401AEC5")]
		MONSTERNAME_071_4,
		// Token: 0x04009974 RID: 39284
		[Token(Token = "0x401AEC6")]
		MONSTERNAME_072_1,
		// Token: 0x04009975 RID: 39285
		[Token(Token = "0x401AEC7")]
		MONSTERNAME_072_2,
		// Token: 0x04009976 RID: 39286
		[Token(Token = "0x401AEC8")]
		MONSTERNAME_072_3,
		// Token: 0x04009977 RID: 39287
		[Token(Token = "0x401AEC9")]
		MONSTERNAME_072_4,
		// Token: 0x04009978 RID: 39288
		[Token(Token = "0x401AECA")]
		MONSTERNAME_073_1,
		// Token: 0x04009979 RID: 39289
		[Token(Token = "0x401AECB")]
		MONSTERNAME_073_2,
		// Token: 0x0400997A RID: 39290
		[Token(Token = "0x401AECC")]
		MONSTERNAME_073_3,
		// Token: 0x0400997B RID: 39291
		[Token(Token = "0x401AECD")]
		MONSTERNAME_073_4,
		// Token: 0x0400997C RID: 39292
		[Token(Token = "0x401AECE")]
		MONSTERNAME_074_1,
		// Token: 0x0400997D RID: 39293
		[Token(Token = "0x401AECF")]
		MONSTERNAME_074_2,
		// Token: 0x0400997E RID: 39294
		[Token(Token = "0x401AED0")]
		MONSTERNAME_074_3,
		// Token: 0x0400997F RID: 39295
		[Token(Token = "0x401AED1")]
		MONSTERNAME_074_4,
		// Token: 0x04009980 RID: 39296
		[Token(Token = "0x401AED2")]
		MONSTERNAME_075_1,
		// Token: 0x04009981 RID: 39297
		[Token(Token = "0x401AED3")]
		MONSTERNAME_075_2,
		// Token: 0x04009982 RID: 39298
		[Token(Token = "0x401AED4")]
		MONSTERNAME_075_3,
		// Token: 0x04009983 RID: 39299
		[Token(Token = "0x401AED5")]
		MONSTERNAME_075_4,
		// Token: 0x04009984 RID: 39300
		[Token(Token = "0x401AED6")]
		MONSTERNAME_076_1,
		// Token: 0x04009985 RID: 39301
		[Token(Token = "0x401AED7")]
		MONSTERNAME_076_2,
		// Token: 0x04009986 RID: 39302
		[Token(Token = "0x401AED8")]
		MONSTERNAME_076_3,
		// Token: 0x04009987 RID: 39303
		[Token(Token = "0x401AED9")]
		MONSTERNAME_076_4,
		// Token: 0x04009988 RID: 39304
		[Token(Token = "0x401AEDA")]
		MONSTERNAME_077_1,
		// Token: 0x04009989 RID: 39305
		[Token(Token = "0x401AEDB")]
		MONSTERNAME_077_2,
		// Token: 0x0400998A RID: 39306
		[Token(Token = "0x401AEDC")]
		MONSTERNAME_077_3,
		// Token: 0x0400998B RID: 39307
		[Token(Token = "0x401AEDD")]
		MONSTERNAME_077_4,
		// Token: 0x0400998C RID: 39308
		[Token(Token = "0x401AEDE")]
		MONSTERNAME_078_1,
		// Token: 0x0400998D RID: 39309
		[Token(Token = "0x401AEDF")]
		MONSTERNAME_078_2,
		// Token: 0x0400998E RID: 39310
		[Token(Token = "0x401AEE0")]
		MONSTERNAME_078_3,
		// Token: 0x0400998F RID: 39311
		[Token(Token = "0x401AEE1")]
		MONSTERNAME_078_4,
		// Token: 0x04009990 RID: 39312
		[Token(Token = "0x401AEE2")]
		MONSTERNAME_079_1,
		// Token: 0x04009991 RID: 39313
		[Token(Token = "0x401AEE3")]
		MONSTERNAME_079_2,
		// Token: 0x04009992 RID: 39314
		[Token(Token = "0x401AEE4")]
		MONSTERNAME_079_3,
		// Token: 0x04009993 RID: 39315
		[Token(Token = "0x401AEE5")]
		MONSTERNAME_079_4,
		// Token: 0x04009994 RID: 39316
		[Token(Token = "0x401AEE6")]
		MONSTERNAME_080_1,
		// Token: 0x04009995 RID: 39317
		[Token(Token = "0x401AEE7")]
		MONSTERNAME_080_2,
		// Token: 0x04009996 RID: 39318
		[Token(Token = "0x401AEE8")]
		MONSTERNAME_080_3,
		// Token: 0x04009997 RID: 39319
		[Token(Token = "0x401AEE9")]
		MONSTERNAME_080_4,
		// Token: 0x04009998 RID: 39320
		[Token(Token = "0x401AEEA")]
		MONSTERNAME_081_1,
		// Token: 0x04009999 RID: 39321
		[Token(Token = "0x401AEEB")]
		MONSTERNAME_081_2,
		// Token: 0x0400999A RID: 39322
		[Token(Token = "0x401AEEC")]
		MONSTERNAME_081_3,
		// Token: 0x0400999B RID: 39323
		[Token(Token = "0x401AEED")]
		MONSTERNAME_081_4,
		// Token: 0x0400999C RID: 39324
		[Token(Token = "0x401AEEE")]
		MONSTERNAME_082_1,
		// Token: 0x0400999D RID: 39325
		[Token(Token = "0x401AEEF")]
		MONSTERNAME_082_2,
		// Token: 0x0400999E RID: 39326
		[Token(Token = "0x401AEF0")]
		MONSTERNAME_082_3,
		// Token: 0x0400999F RID: 39327
		[Token(Token = "0x401AEF1")]
		MONSTERNAME_082_4,
		// Token: 0x040099A0 RID: 39328
		[Token(Token = "0x401AEF2")]
		MONSTERNAME_083_1,
		// Token: 0x040099A1 RID: 39329
		[Token(Token = "0x401AEF3")]
		MONSTERNAME_083_2,
		// Token: 0x040099A2 RID: 39330
		[Token(Token = "0x401AEF4")]
		MONSTERNAME_083_3,
		// Token: 0x040099A3 RID: 39331
		[Token(Token = "0x401AEF5")]
		MONSTERNAME_083_4,
		// Token: 0x040099A4 RID: 39332
		[Token(Token = "0x401AEF6")]
		MONSTERNAME_084_1,
		// Token: 0x040099A5 RID: 39333
		[Token(Token = "0x401AEF7")]
		MONSTERNAME_084_2,
		// Token: 0x040099A6 RID: 39334
		[Token(Token = "0x401AEF8")]
		MONSTERNAME_084_3,
		// Token: 0x040099A7 RID: 39335
		[Token(Token = "0x401AEF9")]
		MONSTERNAME_084_4,
		// Token: 0x040099A8 RID: 39336
		[Token(Token = "0x401AEFA")]
		MONSTERNAME_085_1,
		// Token: 0x040099A9 RID: 39337
		[Token(Token = "0x401AEFB")]
		MONSTERNAME_085_2,
		// Token: 0x040099AA RID: 39338
		[Token(Token = "0x401AEFC")]
		MONSTERNAME_085_3,
		// Token: 0x040099AB RID: 39339
		[Token(Token = "0x401AEFD")]
		MONSTERNAME_085_4,
		// Token: 0x040099AC RID: 39340
		[Token(Token = "0x401AEFE")]
		MONSTERNAME_086_1,
		// Token: 0x040099AD RID: 39341
		[Token(Token = "0x401AEFF")]
		MONSTERNAME_086_2,
		// Token: 0x040099AE RID: 39342
		[Token(Token = "0x401AF00")]
		MONSTERNAME_086_3,
		// Token: 0x040099AF RID: 39343
		[Token(Token = "0x401AF01")]
		MONSTERNAME_086_4,
		// Token: 0x040099B0 RID: 39344
		[Token(Token = "0x401AF02")]
		MONSTERNAME_087_1,
		// Token: 0x040099B1 RID: 39345
		[Token(Token = "0x401AF03")]
		MONSTERNAME_087_2,
		// Token: 0x040099B2 RID: 39346
		[Token(Token = "0x401AF04")]
		MONSTERNAME_087_3,
		// Token: 0x040099B3 RID: 39347
		[Token(Token = "0x401AF05")]
		MONSTERNAME_087_4,
		// Token: 0x040099B4 RID: 39348
		[Token(Token = "0x401AF06")]
		MONSTERNAME_088_1,
		// Token: 0x040099B5 RID: 39349
		[Token(Token = "0x401AF07")]
		MONSTERNAME_088_2,
		// Token: 0x040099B6 RID: 39350
		[Token(Token = "0x401AF08")]
		MONSTERNAME_088_3,
		// Token: 0x040099B7 RID: 39351
		[Token(Token = "0x401AF09")]
		MONSTERNAME_088_4,
		// Token: 0x040099B8 RID: 39352
		[Token(Token = "0x401AF0A")]
		MONSTERNAME_089_1,
		// Token: 0x040099B9 RID: 39353
		[Token(Token = "0x401AF0B")]
		MONSTERNAME_089_2,
		// Token: 0x040099BA RID: 39354
		[Token(Token = "0x401AF0C")]
		MONSTERNAME_089_3,
		// Token: 0x040099BB RID: 39355
		[Token(Token = "0x401AF0D")]
		MONSTERNAME_089_4,
		// Token: 0x040099BC RID: 39356
		[Token(Token = "0x401AF0E")]
		MONSTERNAME_090_1,
		// Token: 0x040099BD RID: 39357
		[Token(Token = "0x401AF0F")]
		MONSTERNAME_090_2,
		// Token: 0x040099BE RID: 39358
		[Token(Token = "0x401AF10")]
		MONSTERNAME_090_3,
		// Token: 0x040099BF RID: 39359
		[Token(Token = "0x401AF11")]
		MONSTERNAME_090_4,
		// Token: 0x040099C0 RID: 39360
		[Token(Token = "0x401AF12")]
		MONSTERNAME_091_1,
		// Token: 0x040099C1 RID: 39361
		[Token(Token = "0x401AF13")]
		MONSTERNAME_091_2,
		// Token: 0x040099C2 RID: 39362
		[Token(Token = "0x401AF14")]
		MONSTERNAME_091_3,
		// Token: 0x040099C3 RID: 39363
		[Token(Token = "0x401AF15")]
		MONSTERNAME_091_4,
		// Token: 0x040099C4 RID: 39364
		[Token(Token = "0x401AF16")]
		MONSTERNAME_092_1,
		// Token: 0x040099C5 RID: 39365
		[Token(Token = "0x401AF17")]
		MONSTERNAME_092_2,
		// Token: 0x040099C6 RID: 39366
		[Token(Token = "0x401AF18")]
		MONSTERNAME_092_3,
		// Token: 0x040099C7 RID: 39367
		[Token(Token = "0x401AF19")]
		MONSTERNAME_092_4,
		// Token: 0x040099C8 RID: 39368
		[Token(Token = "0x401AF1A")]
		MONSTERNAME_093_1,
		// Token: 0x040099C9 RID: 39369
		[Token(Token = "0x401AF1B")]
		MONSTERNAME_093_2,
		// Token: 0x040099CA RID: 39370
		[Token(Token = "0x401AF1C")]
		MONSTERNAME_093_3,
		// Token: 0x040099CB RID: 39371
		[Token(Token = "0x401AF1D")]
		MONSTERNAME_093_4,
		// Token: 0x040099CC RID: 39372
		[Token(Token = "0x401AF1E")]
		MONSTERNAME_094_1,
		// Token: 0x040099CD RID: 39373
		[Token(Token = "0x401AF1F")]
		MONSTERNAME_094_2,
		// Token: 0x040099CE RID: 39374
		[Token(Token = "0x401AF20")]
		MONSTERNAME_094_3,
		// Token: 0x040099CF RID: 39375
		[Token(Token = "0x401AF21")]
		MONSTERNAME_094_4,
		// Token: 0x040099D0 RID: 39376
		[Token(Token = "0x401AF22")]
		MONSTERNAME_095_1,
		// Token: 0x040099D1 RID: 39377
		[Token(Token = "0x401AF23")]
		MONSTERNAME_095_2,
		// Token: 0x040099D2 RID: 39378
		[Token(Token = "0x401AF24")]
		MONSTERNAME_095_3,
		// Token: 0x040099D3 RID: 39379
		[Token(Token = "0x401AF25")]
		MONSTERNAME_095_4,
		// Token: 0x040099D4 RID: 39380
		[Token(Token = "0x401AF26")]
		MONSTERNAME_096_1,
		// Token: 0x040099D5 RID: 39381
		[Token(Token = "0x401AF27")]
		MONSTERNAME_096_2,
		// Token: 0x040099D6 RID: 39382
		[Token(Token = "0x401AF28")]
		MONSTERNAME_096_3,
		// Token: 0x040099D7 RID: 39383
		[Token(Token = "0x401AF29")]
		MONSTERNAME_096_4,
		// Token: 0x040099D8 RID: 39384
		[Token(Token = "0x401AF2A")]
		MONSTERNAME_097_1,
		// Token: 0x040099D9 RID: 39385
		[Token(Token = "0x401AF2B")]
		MONSTERNAME_097_2,
		// Token: 0x040099DA RID: 39386
		[Token(Token = "0x401AF2C")]
		MONSTERNAME_097_3,
		// Token: 0x040099DB RID: 39387
		[Token(Token = "0x401AF2D")]
		MONSTERNAME_097_4,
		// Token: 0x040099DC RID: 39388
		[Token(Token = "0x401AF2E")]
		MONSTERNAME_098_1,
		// Token: 0x040099DD RID: 39389
		[Token(Token = "0x401AF2F")]
		MONSTERNAME_098_2,
		// Token: 0x040099DE RID: 39390
		[Token(Token = "0x401AF30")]
		MONSTERNAME_098_3,
		// Token: 0x040099DF RID: 39391
		[Token(Token = "0x401AF31")]
		MONSTERNAME_098_4,
		// Token: 0x040099E0 RID: 39392
		[Token(Token = "0x401AF32")]
		MONSTERNAME_099_1,
		// Token: 0x040099E1 RID: 39393
		[Token(Token = "0x401AF33")]
		MONSTERNAME_099_2,
		// Token: 0x040099E2 RID: 39394
		[Token(Token = "0x401AF34")]
		MONSTERNAME_099_3,
		// Token: 0x040099E3 RID: 39395
		[Token(Token = "0x401AF35")]
		MONSTERNAME_099_4,
		// Token: 0x040099E4 RID: 39396
		[Token(Token = "0x401AF36")]
		MONSTERNAME_100_1,
		// Token: 0x040099E5 RID: 39397
		[Token(Token = "0x401AF37")]
		MONSTERNAME_100_2,
		// Token: 0x040099E6 RID: 39398
		[Token(Token = "0x401AF38")]
		MONSTERNAME_100_3,
		// Token: 0x040099E7 RID: 39399
		[Token(Token = "0x401AF39")]
		MONSTERNAME_100_4,
		// Token: 0x040099E8 RID: 39400
		[Token(Token = "0x401AF3A")]
		MONSTERNAME_102_1,
		// Token: 0x040099E9 RID: 39401
		[Token(Token = "0x401AF3B")]
		MONSTERNAME_102_2,
		// Token: 0x040099EA RID: 39402
		[Token(Token = "0x401AF3C")]
		MONSTERNAME_102_3,
		// Token: 0x040099EB RID: 39403
		[Token(Token = "0x401AF3D")]
		MONSTERNAME_102_4,
		// Token: 0x040099EC RID: 39404
		[Token(Token = "0x401AF3E")]
		MONSTERNAME_103_1,
		// Token: 0x040099ED RID: 39405
		[Token(Token = "0x401AF3F")]
		MONSTERNAME_103_2,
		// Token: 0x040099EE RID: 39406
		[Token(Token = "0x401AF40")]
		MONSTERNAME_103_3,
		// Token: 0x040099EF RID: 39407
		[Token(Token = "0x401AF41")]
		MONSTERNAME_103_4,
		// Token: 0x040099F0 RID: 39408
		[Token(Token = "0x401AF42")]
		MONSTERNAME_104_1,
		// Token: 0x040099F1 RID: 39409
		[Token(Token = "0x401AF43")]
		MONSTERNAME_104_2,
		// Token: 0x040099F2 RID: 39410
		[Token(Token = "0x401AF44")]
		MONSTERNAME_104_3,
		// Token: 0x040099F3 RID: 39411
		[Token(Token = "0x401AF45")]
		MONSTERNAME_104_4,
		// Token: 0x040099F4 RID: 39412
		[Token(Token = "0x401AF46")]
		MONSTERNAME_105_1,
		// Token: 0x040099F5 RID: 39413
		[Token(Token = "0x401AF47")]
		MONSTERNAME_105_2,
		// Token: 0x040099F6 RID: 39414
		[Token(Token = "0x401AF48")]
		MONSTERNAME_105_3,
		// Token: 0x040099F7 RID: 39415
		[Token(Token = "0x401AF49")]
		MONSTERNAME_105_4,
		// Token: 0x040099F8 RID: 39416
		[Token(Token = "0x401AF4A")]
		MONSTERNAME_106_1,
		// Token: 0x040099F9 RID: 39417
		[Token(Token = "0x401AF4B")]
		MONSTERNAME_106_2,
		// Token: 0x040099FA RID: 39418
		[Token(Token = "0x401AF4C")]
		MONSTERNAME_106_3,
		// Token: 0x040099FB RID: 39419
		[Token(Token = "0x401AF4D")]
		MONSTERNAME_106_4,
		// Token: 0x040099FC RID: 39420
		[Token(Token = "0x401AF4E")]
		MONSTERNAME_107_1,
		// Token: 0x040099FD RID: 39421
		[Token(Token = "0x401AF4F")]
		MONSTERNAME_107_2,
		// Token: 0x040099FE RID: 39422
		[Token(Token = "0x401AF50")]
		MONSTERNAME_107_3,
		// Token: 0x040099FF RID: 39423
		[Token(Token = "0x401AF51")]
		MONSTERNAME_107_4,
		// Token: 0x04009A00 RID: 39424
		[Token(Token = "0x401AF52")]
		MONSTERNAME_108_1,
		// Token: 0x04009A01 RID: 39425
		[Token(Token = "0x401AF53")]
		MONSTERNAME_108_2,
		// Token: 0x04009A02 RID: 39426
		[Token(Token = "0x401AF54")]
		MONSTERNAME_108_3,
		// Token: 0x04009A03 RID: 39427
		[Token(Token = "0x401AF55")]
		MONSTERNAME_108_4,
		// Token: 0x04009A04 RID: 39428
		[Token(Token = "0x401AF56")]
		MONSTERNAME_109_1,
		// Token: 0x04009A05 RID: 39429
		[Token(Token = "0x401AF57")]
		MONSTERNAME_109_2,
		// Token: 0x04009A06 RID: 39430
		[Token(Token = "0x401AF58")]
		MONSTERNAME_109_3,
		// Token: 0x04009A07 RID: 39431
		[Token(Token = "0x401AF59")]
		MONSTERNAME_109_4,
		// Token: 0x04009A08 RID: 39432
		[Token(Token = "0x401AF5A")]
		MONSTERNAME_110_1,
		// Token: 0x04009A09 RID: 39433
		[Token(Token = "0x401AF5B")]
		MONSTERNAME_110_2,
		// Token: 0x04009A0A RID: 39434
		[Token(Token = "0x401AF5C")]
		MONSTERNAME_110_3,
		// Token: 0x04009A0B RID: 39435
		[Token(Token = "0x401AF5D")]
		MONSTERNAME_110_4,
		// Token: 0x04009A0C RID: 39436
		[Token(Token = "0x401AF5E")]
		MONSTERNAME_111_1,
		// Token: 0x04009A0D RID: 39437
		[Token(Token = "0x401AF5F")]
		MONSTERNAME_111_2,
		// Token: 0x04009A0E RID: 39438
		[Token(Token = "0x401AF60")]
		MONSTERNAME_111_3,
		// Token: 0x04009A0F RID: 39439
		[Token(Token = "0x401AF61")]
		MONSTERNAME_111_4,
		// Token: 0x04009A10 RID: 39440
		[Token(Token = "0x401AF62")]
		MONSTERNAME_112_1,
		// Token: 0x04009A11 RID: 39441
		[Token(Token = "0x401AF63")]
		MONSTERNAME_112_2,
		// Token: 0x04009A12 RID: 39442
		[Token(Token = "0x401AF64")]
		MONSTERNAME_112_3,
		// Token: 0x04009A13 RID: 39443
		[Token(Token = "0x401AF65")]
		MONSTERNAME_112_4,
		// Token: 0x04009A14 RID: 39444
		[Token(Token = "0x401AF66")]
		MONSTERNAME_113_1,
		// Token: 0x04009A15 RID: 39445
		[Token(Token = "0x401AF67")]
		MONSTERNAME_113_2,
		// Token: 0x04009A16 RID: 39446
		[Token(Token = "0x401AF68")]
		MONSTERNAME_113_3,
		// Token: 0x04009A17 RID: 39447
		[Token(Token = "0x401AF69")]
		MONSTERNAME_113_4,
		// Token: 0x04009A18 RID: 39448
		[Token(Token = "0x401AF6A")]
		MONSTERNAME_114_1,
		// Token: 0x04009A19 RID: 39449
		[Token(Token = "0x401AF6B")]
		MONSTERNAME_114_2,
		// Token: 0x04009A1A RID: 39450
		[Token(Token = "0x401AF6C")]
		MONSTERNAME_114_3,
		// Token: 0x04009A1B RID: 39451
		[Token(Token = "0x401AF6D")]
		MONSTERNAME_114_4,
		// Token: 0x04009A1C RID: 39452
		[Token(Token = "0x401AF6E")]
		MONSTERNAME_115_1,
		// Token: 0x04009A1D RID: 39453
		[Token(Token = "0x401AF6F")]
		MONSTERNAME_115_2,
		// Token: 0x04009A1E RID: 39454
		[Token(Token = "0x401AF70")]
		MONSTERNAME_115_3,
		// Token: 0x04009A1F RID: 39455
		[Token(Token = "0x401AF71")]
		MONSTERNAME_115_4,
		// Token: 0x04009A20 RID: 39456
		[Token(Token = "0x401AF72")]
		MONSTERNAME_116_1,
		// Token: 0x04009A21 RID: 39457
		[Token(Token = "0x401AF73")]
		MONSTERNAME_116_2,
		// Token: 0x04009A22 RID: 39458
		[Token(Token = "0x401AF74")]
		MONSTERNAME_116_3,
		// Token: 0x04009A23 RID: 39459
		[Token(Token = "0x401AF75")]
		MONSTERNAME_116_4,
		// Token: 0x04009A24 RID: 39460
		[Token(Token = "0x401AF76")]
		MONSTERNAME_117_1,
		// Token: 0x04009A25 RID: 39461
		[Token(Token = "0x401AF77")]
		MONSTERNAME_117_2,
		// Token: 0x04009A26 RID: 39462
		[Token(Token = "0x401AF78")]
		MONSTERNAME_117_3,
		// Token: 0x04009A27 RID: 39463
		[Token(Token = "0x401AF79")]
		MONSTERNAME_117_4,
		// Token: 0x04009A28 RID: 39464
		[Token(Token = "0x401AF7A")]
		MONSTERNAME_118_1,
		// Token: 0x04009A29 RID: 39465
		[Token(Token = "0x401AF7B")]
		MONSTERNAME_118_2,
		// Token: 0x04009A2A RID: 39466
		[Token(Token = "0x401AF7C")]
		MONSTERNAME_118_3,
		// Token: 0x04009A2B RID: 39467
		[Token(Token = "0x401AF7D")]
		MONSTERNAME_118_4,
		// Token: 0x04009A2C RID: 39468
		[Token(Token = "0x401AF7E")]
		MONSTERNAME_119_1,
		// Token: 0x04009A2D RID: 39469
		[Token(Token = "0x401AF7F")]
		MONSTERNAME_119_2,
		// Token: 0x04009A2E RID: 39470
		[Token(Token = "0x401AF80")]
		MONSTERNAME_119_3,
		// Token: 0x04009A2F RID: 39471
		[Token(Token = "0x401AF81")]
		MONSTERNAME_119_4,
		// Token: 0x04009A30 RID: 39472
		[Token(Token = "0x401AF82")]
		MONSTERNAME_120_1,
		// Token: 0x04009A31 RID: 39473
		[Token(Token = "0x401AF83")]
		MONSTERNAME_120_2,
		// Token: 0x04009A32 RID: 39474
		[Token(Token = "0x401AF84")]
		MONSTERNAME_120_3,
		// Token: 0x04009A33 RID: 39475
		[Token(Token = "0x401AF85")]
		MONSTERNAME_120_4,
		// Token: 0x04009A34 RID: 39476
		[Token(Token = "0x401AF86")]
		MONSTERNAME_121_1,
		// Token: 0x04009A35 RID: 39477
		[Token(Token = "0x401AF87")]
		MONSTERNAME_121_2,
		// Token: 0x04009A36 RID: 39478
		[Token(Token = "0x401AF88")]
		MONSTERNAME_121_3,
		// Token: 0x04009A37 RID: 39479
		[Token(Token = "0x401AF89")]
		MONSTERNAME_121_4,
		// Token: 0x04009A38 RID: 39480
		[Token(Token = "0x401AF8A")]
		MONSTERNAME_122_1,
		// Token: 0x04009A39 RID: 39481
		[Token(Token = "0x401AF8B")]
		MONSTERNAME_122_2,
		// Token: 0x04009A3A RID: 39482
		[Token(Token = "0x401AF8C")]
		MONSTERNAME_122_3,
		// Token: 0x04009A3B RID: 39483
		[Token(Token = "0x401AF8D")]
		MONSTERNAME_122_4,
		// Token: 0x04009A3C RID: 39484
		[Token(Token = "0x401AF8E")]
		MONSTERNAME_123_1,
		// Token: 0x04009A3D RID: 39485
		[Token(Token = "0x401AF8F")]
		MONSTERNAME_123_2,
		// Token: 0x04009A3E RID: 39486
		[Token(Token = "0x401AF90")]
		MONSTERNAME_123_3,
		// Token: 0x04009A3F RID: 39487
		[Token(Token = "0x401AF91")]
		MONSTERNAME_123_4,
		// Token: 0x04009A40 RID: 39488
		[Token(Token = "0x401AF92")]
		MONSTERNAME_124_1,
		// Token: 0x04009A41 RID: 39489
		[Token(Token = "0x401AF93")]
		MONSTERNAME_124_2,
		// Token: 0x04009A42 RID: 39490
		[Token(Token = "0x401AF94")]
		MONSTERNAME_124_3,
		// Token: 0x04009A43 RID: 39491
		[Token(Token = "0x401AF95")]
		MONSTERNAME_124_4,
		// Token: 0x04009A44 RID: 39492
		[Token(Token = "0x401AF96")]
		MONSTERNAME_125_1,
		// Token: 0x04009A45 RID: 39493
		[Token(Token = "0x401AF97")]
		MONSTERNAME_125_2,
		// Token: 0x04009A46 RID: 39494
		[Token(Token = "0x401AF98")]
		MONSTERNAME_125_3,
		// Token: 0x04009A47 RID: 39495
		[Token(Token = "0x401AF99")]
		MONSTERNAME_125_4,
		// Token: 0x04009A48 RID: 39496
		[Token(Token = "0x401AF9A")]
		MONSTERNAME_126_1,
		// Token: 0x04009A49 RID: 39497
		[Token(Token = "0x401AF9B")]
		MONSTERNAME_126_2,
		// Token: 0x04009A4A RID: 39498
		[Token(Token = "0x401AF9C")]
		MONSTERNAME_126_3,
		// Token: 0x04009A4B RID: 39499
		[Token(Token = "0x401AF9D")]
		MONSTERNAME_126_4,
		// Token: 0x04009A4C RID: 39500
		[Token(Token = "0x401AF9E")]
		MONSTERNAME_127_1,
		// Token: 0x04009A4D RID: 39501
		[Token(Token = "0x401AF9F")]
		MONSTERNAME_127_2,
		// Token: 0x04009A4E RID: 39502
		[Token(Token = "0x401AFA0")]
		MONSTERNAME_127_3,
		// Token: 0x04009A4F RID: 39503
		[Token(Token = "0x401AFA1")]
		MONSTERNAME_127_4,
		// Token: 0x04009A50 RID: 39504
		[Token(Token = "0x401AFA2")]
		MONSTERNAME_128_1,
		// Token: 0x04009A51 RID: 39505
		[Token(Token = "0x401AFA3")]
		MONSTERNAME_128_2,
		// Token: 0x04009A52 RID: 39506
		[Token(Token = "0x401AFA4")]
		MONSTERNAME_128_3,
		// Token: 0x04009A53 RID: 39507
		[Token(Token = "0x401AFA5")]
		MONSTERNAME_128_4,
		// Token: 0x04009A54 RID: 39508
		[Token(Token = "0x401AFA6")]
		MONSTERNAME_129_1,
		// Token: 0x04009A55 RID: 39509
		[Token(Token = "0x401AFA7")]
		MONSTERNAME_129_2,
		// Token: 0x04009A56 RID: 39510
		[Token(Token = "0x401AFA8")]
		MONSTERNAME_129_3,
		// Token: 0x04009A57 RID: 39511
		[Token(Token = "0x401AFA9")]
		MONSTERNAME_129_4,
		// Token: 0x04009A58 RID: 39512
		[Token(Token = "0x401AFAA")]
		MONSTERNAME_130_1,
		// Token: 0x04009A59 RID: 39513
		[Token(Token = "0x401AFAB")]
		MONSTERNAME_130_2,
		// Token: 0x04009A5A RID: 39514
		[Token(Token = "0x401AFAC")]
		MONSTERNAME_130_3,
		// Token: 0x04009A5B RID: 39515
		[Token(Token = "0x401AFAD")]
		MONSTERNAME_130_4,
		// Token: 0x04009A5C RID: 39516
		[Token(Token = "0x401AFAE")]
		MONSTERNAME_131_1,
		// Token: 0x04009A5D RID: 39517
		[Token(Token = "0x401AFAF")]
		MONSTERNAME_131_2,
		// Token: 0x04009A5E RID: 39518
		[Token(Token = "0x401AFB0")]
		MONSTERNAME_131_3,
		// Token: 0x04009A5F RID: 39519
		[Token(Token = "0x401AFB1")]
		MONSTERNAME_131_4,
		// Token: 0x04009A60 RID: 39520
		[Token(Token = "0x401AFB2")]
		MONSTERNAME_132_1,
		// Token: 0x04009A61 RID: 39521
		[Token(Token = "0x401AFB3")]
		MONSTERNAME_132_2,
		// Token: 0x04009A62 RID: 39522
		[Token(Token = "0x401AFB4")]
		MONSTERNAME_132_3,
		// Token: 0x04009A63 RID: 39523
		[Token(Token = "0x401AFB5")]
		MONSTERNAME_132_4,
		// Token: 0x04009A64 RID: 39524
		[Token(Token = "0x401AFB6")]
		MONSTERNAME_133_1,
		// Token: 0x04009A65 RID: 39525
		[Token(Token = "0x401AFB7")]
		MONSTERNAME_133_2,
		// Token: 0x04009A66 RID: 39526
		[Token(Token = "0x401AFB8")]
		MONSTERNAME_133_3,
		// Token: 0x04009A67 RID: 39527
		[Token(Token = "0x401AFB9")]
		MONSTERNAME_133_4,
		// Token: 0x04009A68 RID: 39528
		[Token(Token = "0x401AFBA")]
		MONSTERNAME_134_1,
		// Token: 0x04009A69 RID: 39529
		[Token(Token = "0x401AFBB")]
		MONSTERNAME_134_2,
		// Token: 0x04009A6A RID: 39530
		[Token(Token = "0x401AFBC")]
		MONSTERNAME_134_3,
		// Token: 0x04009A6B RID: 39531
		[Token(Token = "0x401AFBD")]
		MONSTERNAME_134_4,
		// Token: 0x04009A6C RID: 39532
		[Token(Token = "0x401AFBE")]
		MONSTERNAME_135_1,
		// Token: 0x04009A6D RID: 39533
		[Token(Token = "0x401AFBF")]
		MONSTERNAME_135_2,
		// Token: 0x04009A6E RID: 39534
		[Token(Token = "0x401AFC0")]
		MONSTERNAME_135_3,
		// Token: 0x04009A6F RID: 39535
		[Token(Token = "0x401AFC1")]
		MONSTERNAME_135_4,
		// Token: 0x04009A70 RID: 39536
		[Token(Token = "0x401AFC2")]
		MONSTERNAME_136_1,
		// Token: 0x04009A71 RID: 39537
		[Token(Token = "0x401AFC3")]
		MONSTERNAME_136_2,
		// Token: 0x04009A72 RID: 39538
		[Token(Token = "0x401AFC4")]
		MONSTERNAME_136_3,
		// Token: 0x04009A73 RID: 39539
		[Token(Token = "0x401AFC5")]
		MONSTERNAME_136_4,
		// Token: 0x04009A74 RID: 39540
		[Token(Token = "0x401AFC6")]
		MONSTERNAME_137_1,
		// Token: 0x04009A75 RID: 39541
		[Token(Token = "0x401AFC7")]
		MONSTERNAME_137_2,
		// Token: 0x04009A76 RID: 39542
		[Token(Token = "0x401AFC8")]
		MONSTERNAME_137_3,
		// Token: 0x04009A77 RID: 39543
		[Token(Token = "0x401AFC9")]
		MONSTERNAME_137_4,
		// Token: 0x04009A78 RID: 39544
		[Token(Token = "0x401AFCA")]
		MONSTERNAME_138_1,
		// Token: 0x04009A79 RID: 39545
		[Token(Token = "0x401AFCB")]
		MONSTERNAME_138_2,
		// Token: 0x04009A7A RID: 39546
		[Token(Token = "0x401AFCC")]
		MONSTERNAME_138_3,
		// Token: 0x04009A7B RID: 39547
		[Token(Token = "0x401AFCD")]
		MONSTERNAME_138_4,
		// Token: 0x04009A7C RID: 39548
		[Token(Token = "0x401AFCE")]
		MONSTERNAME_139_1,
		// Token: 0x04009A7D RID: 39549
		[Token(Token = "0x401AFCF")]
		MONSTERNAME_139_2,
		// Token: 0x04009A7E RID: 39550
		[Token(Token = "0x401AFD0")]
		MONSTERNAME_139_3,
		// Token: 0x04009A7F RID: 39551
		[Token(Token = "0x401AFD1")]
		MONSTERNAME_139_4,
		// Token: 0x04009A80 RID: 39552
		[Token(Token = "0x401AFD2")]
		MONSTERNAME_140_1,
		// Token: 0x04009A81 RID: 39553
		[Token(Token = "0x401AFD3")]
		MONSTERNAME_140_2,
		// Token: 0x04009A82 RID: 39554
		[Token(Token = "0x401AFD4")]
		MONSTERNAME_140_3,
		// Token: 0x04009A83 RID: 39555
		[Token(Token = "0x401AFD5")]
		MONSTERNAME_140_4,
		// Token: 0x04009A84 RID: 39556
		[Token(Token = "0x401AFD6")]
		MONSTERNAME_141_1,
		// Token: 0x04009A85 RID: 39557
		[Token(Token = "0x401AFD7")]
		MONSTERNAME_141_2,
		// Token: 0x04009A86 RID: 39558
		[Token(Token = "0x401AFD8")]
		MONSTERNAME_141_3,
		// Token: 0x04009A87 RID: 39559
		[Token(Token = "0x401AFD9")]
		MONSTERNAME_141_4,
		// Token: 0x04009A88 RID: 39560
		[Token(Token = "0x401AFDA")]
		MONSTERNAME_142_1,
		// Token: 0x04009A89 RID: 39561
		[Token(Token = "0x401AFDB")]
		MONSTERNAME_142_2,
		// Token: 0x04009A8A RID: 39562
		[Token(Token = "0x401AFDC")]
		MONSTERNAME_142_3,
		// Token: 0x04009A8B RID: 39563
		[Token(Token = "0x401AFDD")]
		MONSTERNAME_142_4,
		// Token: 0x04009A8C RID: 39564
		[Token(Token = "0x401AFDE")]
		MONSTERNAME_143_1,
		// Token: 0x04009A8D RID: 39565
		[Token(Token = "0x401AFDF")]
		MONSTERNAME_143_2,
		// Token: 0x04009A8E RID: 39566
		[Token(Token = "0x401AFE0")]
		MONSTERNAME_143_3,
		// Token: 0x04009A8F RID: 39567
		[Token(Token = "0x401AFE1")]
		MONSTERNAME_143_4,
		// Token: 0x04009A90 RID: 39568
		[Token(Token = "0x401AFE2")]
		MONSTERNAME_144_1,
		// Token: 0x04009A91 RID: 39569
		[Token(Token = "0x401AFE3")]
		MONSTERNAME_144_2,
		// Token: 0x04009A92 RID: 39570
		[Token(Token = "0x401AFE4")]
		MONSTERNAME_144_3,
		// Token: 0x04009A93 RID: 39571
		[Token(Token = "0x401AFE5")]
		MONSTERNAME_144_4,
		// Token: 0x04009A94 RID: 39572
		[Token(Token = "0x401AFE6")]
		MONSTERNAME_145_1,
		// Token: 0x04009A95 RID: 39573
		[Token(Token = "0x401AFE7")]
		MONSTERNAME_145_2,
		// Token: 0x04009A96 RID: 39574
		[Token(Token = "0x401AFE8")]
		MONSTERNAME_145_3,
		// Token: 0x04009A97 RID: 39575
		[Token(Token = "0x401AFE9")]
		MONSTERNAME_145_4,
		// Token: 0x04009A98 RID: 39576
		[Token(Token = "0x401AFEA")]
		MONSTERNAME_146_1,
		// Token: 0x04009A99 RID: 39577
		[Token(Token = "0x401AFEB")]
		MONSTERNAME_146_2,
		// Token: 0x04009A9A RID: 39578
		[Token(Token = "0x401AFEC")]
		MONSTERNAME_146_3,
		// Token: 0x04009A9B RID: 39579
		[Token(Token = "0x401AFED")]
		MONSTERNAME_146_4,
		// Token: 0x04009A9C RID: 39580
		[Token(Token = "0x401AFEE")]
		MONSTERNAME_147_1,
		// Token: 0x04009A9D RID: 39581
		[Token(Token = "0x401AFEF")]
		MONSTERNAME_147_2,
		// Token: 0x04009A9E RID: 39582
		[Token(Token = "0x401AFF0")]
		MONSTERNAME_147_3,
		// Token: 0x04009A9F RID: 39583
		[Token(Token = "0x401AFF1")]
		MONSTERNAME_147_4,
		// Token: 0x04009AA0 RID: 39584
		[Token(Token = "0x401AFF2")]
		MONSTERNAME_148_1,
		// Token: 0x04009AA1 RID: 39585
		[Token(Token = "0x401AFF3")]
		MONSTERNAME_148_2,
		// Token: 0x04009AA2 RID: 39586
		[Token(Token = "0x401AFF4")]
		MONSTERNAME_148_3,
		// Token: 0x04009AA3 RID: 39587
		[Token(Token = "0x401AFF5")]
		MONSTERNAME_148_4,
		// Token: 0x04009AA4 RID: 39588
		[Token(Token = "0x401AFF6")]
		MONSTERNAME_149_1,
		// Token: 0x04009AA5 RID: 39589
		[Token(Token = "0x401AFF7")]
		MONSTERNAME_149_2,
		// Token: 0x04009AA6 RID: 39590
		[Token(Token = "0x401AFF8")]
		MONSTERNAME_149_3,
		// Token: 0x04009AA7 RID: 39591
		[Token(Token = "0x401AFF9")]
		MONSTERNAME_149_4,
		// Token: 0x04009AA8 RID: 39592
		[Token(Token = "0x401AFFA")]
		MONSTERNAME_150_1,
		// Token: 0x04009AA9 RID: 39593
		[Token(Token = "0x401AFFB")]
		MONSTERNAME_150_2,
		// Token: 0x04009AAA RID: 39594
		[Token(Token = "0x401AFFC")]
		MONSTERNAME_150_3,
		// Token: 0x04009AAB RID: 39595
		[Token(Token = "0x401AFFD")]
		MONSTERNAME_150_4,
		// Token: 0x04009AAC RID: 39596
		[Token(Token = "0x401AFFE")]
		MONSTERNAME_151_1,
		// Token: 0x04009AAD RID: 39597
		[Token(Token = "0x401AFFF")]
		MONSTERNAME_151_2,
		// Token: 0x04009AAE RID: 39598
		[Token(Token = "0x401B000")]
		MONSTERNAME_151_3,
		// Token: 0x04009AAF RID: 39599
		[Token(Token = "0x401B001")]
		MONSTERNAME_151_4,
		// Token: 0x04009AB0 RID: 39600
		[Token(Token = "0x401B002")]
		MONSTERNAME_152_1,
		// Token: 0x04009AB1 RID: 39601
		[Token(Token = "0x401B003")]
		MONSTERNAME_152_2,
		// Token: 0x04009AB2 RID: 39602
		[Token(Token = "0x401B004")]
		MONSTERNAME_152_3,
		// Token: 0x04009AB3 RID: 39603
		[Token(Token = "0x401B005")]
		MONSTERNAME_152_4,
		// Token: 0x04009AB4 RID: 39604
		[Token(Token = "0x401B006")]
		MONSTERNAME_153_1,
		// Token: 0x04009AB5 RID: 39605
		[Token(Token = "0x401B007")]
		MONSTERNAME_153_2,
		// Token: 0x04009AB6 RID: 39606
		[Token(Token = "0x401B008")]
		MONSTERNAME_153_3,
		// Token: 0x04009AB7 RID: 39607
		[Token(Token = "0x401B009")]
		MONSTERNAME_153_4,
		// Token: 0x04009AB8 RID: 39608
		[Token(Token = "0x401B00A")]
		MONSTERNAME_154_1,
		// Token: 0x04009AB9 RID: 39609
		[Token(Token = "0x401B00B")]
		MONSTERNAME_154_2,
		// Token: 0x04009ABA RID: 39610
		[Token(Token = "0x401B00C")]
		MONSTERNAME_154_3,
		// Token: 0x04009ABB RID: 39611
		[Token(Token = "0x401B00D")]
		MONSTERNAME_154_4,
		// Token: 0x04009ABC RID: 39612
		[Token(Token = "0x401B00E")]
		MONSTERNAME_155_1,
		// Token: 0x04009ABD RID: 39613
		[Token(Token = "0x401B00F")]
		MONSTERNAME_155_2,
		// Token: 0x04009ABE RID: 39614
		[Token(Token = "0x401B010")]
		MONSTERNAME_155_3,
		// Token: 0x04009ABF RID: 39615
		[Token(Token = "0x401B011")]
		MONSTERNAME_155_4,
		// Token: 0x04009AC0 RID: 39616
		[Token(Token = "0x401B012")]
		MONSTERNAME_156_1,
		// Token: 0x04009AC1 RID: 39617
		[Token(Token = "0x401B013")]
		MONSTERNAME_156_2,
		// Token: 0x04009AC2 RID: 39618
		[Token(Token = "0x401B014")]
		MONSTERNAME_156_3,
		// Token: 0x04009AC3 RID: 39619
		[Token(Token = "0x401B015")]
		MONSTERNAME_156_4,
		// Token: 0x04009AC4 RID: 39620
		[Token(Token = "0x401B016")]
		MONSTERNAME_157_1,
		// Token: 0x04009AC5 RID: 39621
		[Token(Token = "0x401B017")]
		MONSTERNAME_157_2,
		// Token: 0x04009AC6 RID: 39622
		[Token(Token = "0x401B018")]
		MONSTERNAME_157_3,
		// Token: 0x04009AC7 RID: 39623
		[Token(Token = "0x401B019")]
		MONSTERNAME_157_4,
		// Token: 0x04009AC8 RID: 39624
		[Token(Token = "0x401B01A")]
		MONSTERNAME_158_1,
		// Token: 0x04009AC9 RID: 39625
		[Token(Token = "0x401B01B")]
		MONSTERNAME_158_2,
		// Token: 0x04009ACA RID: 39626
		[Token(Token = "0x401B01C")]
		MONSTERNAME_158_3,
		// Token: 0x04009ACB RID: 39627
		[Token(Token = "0x401B01D")]
		MONSTERNAME_158_4,
		// Token: 0x04009ACC RID: 39628
		[Token(Token = "0x401B01E")]
		MONSTERNAME_159_1,
		// Token: 0x04009ACD RID: 39629
		[Token(Token = "0x401B01F")]
		MONSTERNAME_159_2,
		// Token: 0x04009ACE RID: 39630
		[Token(Token = "0x401B020")]
		MONSTERNAME_159_3,
		// Token: 0x04009ACF RID: 39631
		[Token(Token = "0x401B021")]
		MONSTERNAME_159_4,
		// Token: 0x04009AD0 RID: 39632
		[Token(Token = "0x401B022")]
		MONSTERNAME_160_1,
		// Token: 0x04009AD1 RID: 39633
		[Token(Token = "0x401B023")]
		MONSTERNAME_161_1,
		// Token: 0x04009AD2 RID: 39634
		[Token(Token = "0x401B024")]
		MONSTERNAME_162_1,
		// Token: 0x04009AD3 RID: 39635
		[Token(Token = "0x401B025")]
		MONSTERNAME_163_1,
		// Token: 0x04009AD4 RID: 39636
		[Token(Token = "0x401B026")]
		MONSTERNAME_164_1,
		// Token: 0x04009AD5 RID: 39637
		[Token(Token = "0x401B027")]
		MONSTERNAME_165_1,
		// Token: 0x04009AD6 RID: 39638
		[Token(Token = "0x401B028")]
		MONSTERNAME_166_1,
		// Token: 0x04009AD7 RID: 39639
		[Token(Token = "0x401B029")]
		MONSTERNAME_169_1,
		// Token: 0x04009AD8 RID: 39640
		[Token(Token = "0x401B02A")]
		MONSTERNAME_170_1,
		// Token: 0x04009AD9 RID: 39641
		[Token(Token = "0x401B02B")]
		MONSTERNAME_171_1,
		// Token: 0x04009ADA RID: 39642
		[Token(Token = "0x401B02C")]
		MONSTERNAME_172_1,
		// Token: 0x04009ADB RID: 39643
		[Token(Token = "0x401B02D")]
		MONSTERNAME_173_1,
		// Token: 0x04009ADC RID: 39644
		[Token(Token = "0x401B02E")]
		MONSTERNAME_174_1,
		// Token: 0x04009ADD RID: 39645
		[Token(Token = "0x401B02F")]
		MONSTERNAME_177_1,
		// Token: 0x04009ADE RID: 39646
		[Token(Token = "0x401B030")]
		MONSTERNAME_178_1,
		// Token: 0x04009ADF RID: 39647
		[Token(Token = "0x401B031")]
		MONSTERNAME_179_1,
		// Token: 0x04009AE0 RID: 39648
		[Token(Token = "0x401B032")]
		MONSTERNAME_180_1,
		// Token: 0x04009AE1 RID: 39649
		[Token(Token = "0x401B033")]
		MONSTERNAME_181_1,
		// Token: 0x04009AE2 RID: 39650
		[Token(Token = "0x401B034")]
		MONSTERNAME_182_1,
		// Token: 0x04009AE3 RID: 39651
		[Token(Token = "0x401B035")]
		MONSTERNAME_183_1,
		// Token: 0x04009AE4 RID: 39652
		[Token(Token = "0x401B036")]
		MONSTERNAME_184_1,
		// Token: 0x04009AE5 RID: 39653
		[Token(Token = "0x401B037")]
		MONSTERNAME_191_1,
		// Token: 0x04009AE6 RID: 39654
		[Token(Token = "0x401B038")]
		MONSTERNAME_192_1,
		// Token: 0x04009AE7 RID: 39655
		[Token(Token = "0x401B039")]
		MONSTERNAME_195_1,
		// Token: 0x04009AE8 RID: 39656
		[Token(Token = "0x401B03A")]
		MONSTERNAME_196_1,
		// Token: 0x04009AE9 RID: 39657
		[Token(Token = "0x401B03B")]
		MONSTERNAME_197_1,
		// Token: 0x04009AEA RID: 39658
		[Token(Token = "0x401B03C")]
		MONSTERNAME_198_1,
		// Token: 0x04009AEB RID: 39659
		[Token(Token = "0x401B03D")]
		MONSTERNAME_202_1,
		// Token: 0x04009AEC RID: 39660
		[Token(Token = "0x401B03E")]
		FIELD_LAYOUT_OBJECT_NAME_00001 = 300000,
		// Token: 0x04009AED RID: 39661
		[Token(Token = "0x401B03F")]
		FIELD_LAYOUT_OBJECT_NAME_00002,
		// Token: 0x04009AEE RID: 39662
		[Token(Token = "0x401B040")]
		FIELD_LAYOUT_OBJECT_NAME_00003,
		// Token: 0x04009AEF RID: 39663
		[Token(Token = "0x401B041")]
		FIELD_LAYOUT_OBJECT_NAME_00004,
		// Token: 0x04009AF0 RID: 39664
		[Token(Token = "0x401B042")]
		FIELD_LAYOUT_OBJECT_NAME_00005,
		// Token: 0x04009AF1 RID: 39665
		[Token(Token = "0x401B043")]
		FIELD_LAYOUT_OBJECT_NAME_00006,
		// Token: 0x04009AF2 RID: 39666
		[Token(Token = "0x401B044")]
		FIELD_LAYOUT_OBJECT_NAME_00007,
		// Token: 0x04009AF3 RID: 39667
		[Token(Token = "0x401B045")]
		FIELD_LAYOUT_OBJECT_NAME_00008,
		// Token: 0x04009AF4 RID: 39668
		[Token(Token = "0x401B046")]
		FIELD_LAYOUT_OBJECT_NAME_00009,
		// Token: 0x04009AF5 RID: 39669
		[Token(Token = "0x401B047")]
		FIELD_LAYOUT_OBJECT_NAME_00010,
		// Token: 0x04009AF6 RID: 39670
		[Token(Token = "0x401B048")]
		WARPPOINTNAME_99,
		// Token: 0x04009AF7 RID: 39671
		[Token(Token = "0x401B049")]
		FIELD_LAYOUT_OBJECT_NAME_00201,
		// Token: 0x04009AF8 RID: 39672
		[Token(Token = "0x401B04A")]
		FIELD_LAYOUT_OBJECT_NAME_00202,
		// Token: 0x04009AF9 RID: 39673
		[Token(Token = "0x401B04B")]
		WARPPOINTNAME_Town_01,
		// Token: 0x04009AFA RID: 39674
		[Token(Token = "0x401B04C")]
		WARPPOINTNAME_Town_02,
		// Token: 0x04009AFB RID: 39675
		[Token(Token = "0x401B04D")]
		WARPPOINTNAME_Town_04,
		// Token: 0x04009AFC RID: 39676
		[Token(Token = "0x401B04E")]
		FIELD_LAYOUT_OBJECT_NAME_00400,
		// Token: 0x04009AFD RID: 39677
		[Token(Token = "0x401B04F")]
		WARPPOINTNAME_F1_front,
		// Token: 0x04009AFE RID: 39678
		[Token(Token = "0x401B050")]
		WARPPOINTNAME_F2_front,
		// Token: 0x04009AFF RID: 39679
		[Token(Token = "0x401B051")]
		WARPPOINTNAME_F3_front,
		// Token: 0x04009B00 RID: 39680
		[Token(Token = "0x401B052")]
		MAPNAME_SCENE_FieldMap,
		// Token: 0x04009B01 RID: 39681
		[Token(Token = "0x401B053")]
		MAPNAME_FIELD_Town,
		// Token: 0x04009B02 RID: 39682
		[Token(Token = "0x401B054")]
		MAPNAME_FIELD_F1_01,
		// Token: 0x04009B03 RID: 39683
		[Token(Token = "0x401B055")]
		MAPNAME_FIELD_F1_02,
		// Token: 0x04009B04 RID: 39684
		[Token(Token = "0x401B056")]
		MAPNAME_FIELD_F1_03,
		// Token: 0x04009B05 RID: 39685
		[Token(Token = "0x401B057")]
		MAPNAME_SCENE_RF5Room_01_Lv1_police,
		// Token: 0x04009B06 RID: 39686
		[Token(Token = "0x401B058")]
		MAPNAME_SCENE_RF5Room_01_Lv2_police,
		// Token: 0x04009B07 RID: 39687
		[Token(Token = "0x401B059")]
		MAPNAME_SCENE_RF5Room_01_Lv3_police,
		// Token: 0x04009B08 RID: 39688
		[Token(Token = "0x401B05A")]
		MAPNAME_SCENE_RF5Room_02_Hospital,
		// Token: 0x04009B09 RID: 39689
		[Token(Token = "0x401B05B")]
		MAPNAME_SCENE_RF5Room_03_Blacksmith,
		// Token: 0x04009B0A RID: 39690
		[Token(Token = "0x401B05C")]
		MAPNAME_SCENE_RF5Room_04_Shop,
		// Token: 0x04009B0B RID: 39691
		[Token(Token = "0x401B05D")]
		MAPNAME_SCENE_RF5Room_05_Restaurant_2,
		// Token: 0x04009B0C RID: 39692
		[Token(Token = "0x401B05E")]
		MAPNAME_SCENE_RF5Room_06_Hotel,
		// Token: 0x04009B0D RID: 39693
		[Token(Token = "0x401B05F")]
		MAPNAME_SCENE_RF5Room_07_Bakery,
		// Token: 0x04009B0E RID: 39694
		[Token(Token = "0x401B060")]
		MAPNAME_SCENE_RF5Room_08_Carpenter,
		// Token: 0x04009B0F RID: 39695
		[Token(Token = "0x401B061")]
		MAPNAME_SCENE_RF5Room_09_Detective,
		// Token: 0x04009B10 RID: 39696
		[Token(Token = "0x401B062")]
		MAPNAME_SCENE_RF5Room_10_CrystalShop,
		// Token: 0x04009B11 RID: 39697
		[Token(Token = "0x401B063")]
		MAPNAME_SCENE_RF5Room_11_Monsterhut,
		// Token: 0x04009B12 RID: 39698
		[Token(Token = "0x401B064")]
		MAPNAME_SCENE_RF5Room_13_FlowerShop,
		// Token: 0x04009B13 RID: 39699
		[Token(Token = "0x401B065")]
		MAPNAME_SCENE_RF5Room_14_Relics,
		// Token: 0x04009B14 RID: 39700
		[Token(Token = "0x401B066")]
		MAPNAME_SCENE_RF5Room_17_home01,
		// Token: 0x04009B15 RID: 39701
		[Token(Token = "0x401B067")]
		MAPNAME_SCENE_RF5Room_18_home02,
		// Token: 0x04009B16 RID: 39702
		[Token(Token = "0x401B068")]
		MAPNAME_SCENE_RF5Room_19_home03,
		// Token: 0x04009B17 RID: 39703
		[Token(Token = "0x401B069")]
		MAPNAME_SCENE_RF5Room_20_home04,
		// Token: 0x04009B18 RID: 39704
		[Token(Token = "0x401B06A")]
		MAPNAME_SCENE_RF5Room_21_home_empty,
		// Token: 0x04009B19 RID: 39705
		[Token(Token = "0x401B06B")]
		MAPNAME_SCENE_RF5Room_22_villa01,
		// Token: 0x04009B1A RID: 39706
		[Token(Token = "0x401B06C")]
		MAPNAME_SCENE_RF5Room_22_villa02,
		// Token: 0x04009B1B RID: 39707
		[Token(Token = "0x401B06D")]
		MAPNAME_SCENE_RF5Room_22_villa03,
		// Token: 0x04009B1C RID: 39708
		[Token(Token = "0x401B06E")]
		MAPNAME_SCENE_FarmDragon_01_soil,
		// Token: 0x04009B1D RID: 39709
		[Token(Token = "0x401B06F")]
		MAPNAME_SCENE_FarmDragon_02_fire,
		// Token: 0x04009B1E RID: 39710
		[Token(Token = "0x401B070")]
		MAPNAME_SCENE_FarmDragon_03_ice,
		// Token: 0x04009B1F RID: 39711
		[Token(Token = "0x401B071")]
		MAPNAME_SCENE_FarmDragon_04_wind,
		// Token: 0x04009B20 RID: 39712
		[Token(Token = "0x401B072")]
		MAPNAME_SCENE_FarmDragon_05_ground,
		// Token: 0x04009B21 RID: 39713
		[Token(Token = "0x401B073")]
		MAPNAME_SCENE_DN01_01,
		// Token: 0x04009B22 RID: 39714
		[Token(Token = "0x401B074")]
		MAPNAME_SCENE_DN01_02,
		// Token: 0x04009B23 RID: 39715
		[Token(Token = "0x401B075")]
		MAPNAME_SCENE_DN02_01,
		// Token: 0x04009B24 RID: 39716
		[Token(Token = "0x401B076")]
		MAPNAME_SCENE_DN02_02,
		// Token: 0x04009B25 RID: 39717
		[Token(Token = "0x401B077")]
		MAPNAME_SCENE_DN02_03,
		// Token: 0x04009B26 RID: 39718
		[Token(Token = "0x401B078")]
		MAPNAME_SCENE_DN03_01,
		// Token: 0x04009B27 RID: 39719
		[Token(Token = "0x401B079")]
		MAPNAME_SCENE_DN03_02,
		// Token: 0x04009B28 RID: 39720
		[Token(Token = "0x401B07A")]
		MAPNAME_SCENE_DN03_03,
		// Token: 0x04009B29 RID: 39721
		[Token(Token = "0x401B07B")]
		MAPNAME_SCENE_DN04_01,
		// Token: 0x04009B2A RID: 39722
		[Token(Token = "0x401B07C")]
		MAPNAME_SCENE_DN04_02,
		// Token: 0x04009B2B RID: 39723
		[Token(Token = "0x401B07D")]
		MAPNAME_SCENE_DN04_03,
		// Token: 0x04009B2C RID: 39724
		[Token(Token = "0x401B07E")]
		MAPNAME_SCENE_DN05_01,
		// Token: 0x04009B2D RID: 39725
		[Token(Token = "0x401B07F")]
		MAPNAME_SCENE_DN05_02,
		// Token: 0x04009B2E RID: 39726
		[Token(Token = "0x401B080")]
		MAPNAME_SCENE_DN05_03,
		// Token: 0x04009B2F RID: 39727
		[Token(Token = "0x401B081")]
		MAPNAME_SCENE_DN05_04,
		// Token: 0x04009B30 RID: 39728
		[Token(Token = "0x401B082")]
		MAPNAME_SCENE_DN06_01,
		// Token: 0x04009B31 RID: 39729
		[Token(Token = "0x401B083")]
		MAPNAME_SCENE_DN06_02,
		// Token: 0x04009B32 RID: 39730
		[Token(Token = "0x401B084")]
		MAPNAME_SCENE_DN07_01,
		// Token: 0x04009B33 RID: 39731
		[Token(Token = "0x401B085")]
		MAPNAME_SCENE_DN07_02,
		// Token: 0x04009B34 RID: 39732
		[Token(Token = "0x401B086")]
		MAPNAME_SCENE_DN07_03,
		// Token: 0x04009B35 RID: 39733
		[Token(Token = "0x401B087")]
		MAPNAME_SCENE_DN08_01,
		// Token: 0x04009B36 RID: 39734
		[Token(Token = "0x401B088")]
		MAPNAME_SCENE_DN08_02,
		// Token: 0x04009B37 RID: 39735
		[Token(Token = "0x401B089")]
		MAPNAME_SCENE_DN08_03,
		// Token: 0x04009B38 RID: 39736
		[Token(Token = "0x401B08A")]
		MAPNAME_SCENE_DN09_01,
		// Token: 0x04009B39 RID: 39737
		[Token(Token = "0x401B08B")]
		MAPNAME_SCENE_DN09_02,
		// Token: 0x04009B3A RID: 39738
		[Token(Token = "0x401B08C")]
		MAPNAME_SCENE_DN10_01,
		// Token: 0x04009B3B RID: 39739
		[Token(Token = "0x401B08D")]
		MAPNAME_SCENE_DN10_02,
		// Token: 0x04009B3C RID: 39740
		[Token(Token = "0x401B08E")]
		MAPNAME_SCENE_DN11_01,
		// Token: 0x04009B3D RID: 39741
		[Token(Token = "0x401B08F")]
		MAPNAME_SCENE_DN11_02,
		// Token: 0x04009B3E RID: 39742
		[Token(Token = "0x401B090")]
		MAPNAME_SCENE_DN11_03,
		// Token: 0x04009B3F RID: 39743
		[Token(Token = "0x401B091")]
		MAPNAME_SCENE_DN12_01,
		// Token: 0x04009B40 RID: 39744
		[Token(Token = "0x401B092")]
		MAPNAME_SCENE_DN12_02,
		// Token: 0x04009B41 RID: 39745
		[Token(Token = "0x401B093")]
		MAPNAME_SCENE_DN12_03,
		// Token: 0x04009B42 RID: 39746
		[Token(Token = "0x401B094")]
		MAPNAME_SCENE_DN12_04,
		// Token: 0x04009B43 RID: 39747
		[Token(Token = "0x401B095")]
		MAPNAME_SCENE_DN13_01,
		// Token: 0x04009B44 RID: 39748
		[Token(Token = "0x401B096")]
		MAPNAME_SCENE_DN13_02,
		// Token: 0x04009B45 RID: 39749
		[Token(Token = "0x401B097")]
		MAPNAME_SCENE_DN13_03,
		// Token: 0x04009B46 RID: 39750
		[Token(Token = "0x401B098")]
		MAPNAME_SCENE_DN14_01,
		// Token: 0x04009B47 RID: 39751
		[Token(Token = "0x401B099")]
		MAPNAME_SCENE_DN14_02,
		// Token: 0x04009B48 RID: 39752
		[Token(Token = "0x401B09A")]
		MAPNAME_SCENE_DN14_03,
		// Token: 0x04009B49 RID: 39753
		[Token(Token = "0x401B09B")]
		MAPNAME_SCENE_DN15_01,
		// Token: 0x04009B4A RID: 39754
		[Token(Token = "0x401B09C")]
		MAPNAME_SCENE_DN15_02,
		// Token: 0x04009B4B RID: 39755
		[Token(Token = "0x401B09D")]
		MAPNAME_SCENE_DN15_03,
		// Token: 0x04009B4C RID: 39756
		[Token(Token = "0x401B09E")]
		MAPNAME_SCENE_DN16_01,
		// Token: 0x04009B4D RID: 39757
		[Token(Token = "0x401B09F")]
		MAPNAME_SCENE_DN16_02,
		// Token: 0x04009B4E RID: 39758
		[Token(Token = "0x401B0A0")]
		MAPNAME_SCENE_DN16_03,
		// Token: 0x04009B4F RID: 39759
		[Token(Token = "0x401B0A1")]
		MAPNAME_SCENE_DN17_01,
		// Token: 0x04009B50 RID: 39760
		[Token(Token = "0x401B0A2")]
		MAPNAME_SCENE_DN17_02,
		// Token: 0x04009B51 RID: 39761
		[Token(Token = "0x401B0A3")]
		MAPNAME_SCENE_DN18_01,
		// Token: 0x04009B52 RID: 39762
		[Token(Token = "0x401B0A4")]
		MAPNAME_SCENE_DN19_01,
		// Token: 0x04009B53 RID: 39763
		[Token(Token = "0x401B0A5")]
		MAPNAME_SCENE_DN19_02,
		// Token: 0x04009B54 RID: 39764
		[Token(Token = "0x401B0A6")]
		MAPNAME_SCENE_DN19_03,
		// Token: 0x04009B55 RID: 39765
		[Token(Token = "0x401B0A7")]
		MAPNAME_SCENE_DN19_04,
		// Token: 0x04009B56 RID: 39766
		[Token(Token = "0x401B0A8")]
		MAPNAME_SCENE_DN19_05,
		// Token: 0x04009B57 RID: 39767
		[Token(Token = "0x401B0A9")]
		MAPNAME_SCENE_DN19_06,
		// Token: 0x04009B58 RID: 39768
		[Token(Token = "0x401B0AA")]
		MAPNAME_SCENE_DN19_07,
		// Token: 0x04009B59 RID: 39769
		[Token(Token = "0x401B0AB")]
		MAPNAME_SCENE_DN19_08,
		// Token: 0x04009B5A RID: 39770
		[Token(Token = "0x401B0AC")]
		MAPNAME_SCENE_DN19_09,
		// Token: 0x04009B5B RID: 39771
		[Token(Token = "0x401B0AD")]
		MAPNAME_SCENE_DN19_10,
		// Token: 0x04009B5C RID: 39772
		[Token(Token = "0x401B0AE")]
		MAPNAME_SCENE_DN19_11,
		// Token: 0x04009B5D RID: 39773
		[Token(Token = "0x401B0AF")]
		MAPNAME_SCENE_DN19_12,
		// Token: 0x04009B5E RID: 39774
		[Token(Token = "0x401B0B0")]
		MAPNAME_SCENE_DN19_13,
		// Token: 0x04009B5F RID: 39775
		[Token(Token = "0x401B0B1")]
		MAPNAME_SCENE_DN19_14,
		// Token: 0x04009B60 RID: 39776
		[Token(Token = "0x401B0B2")]
		MAPNAME_SCENE_DN19_15,
		// Token: 0x04009B61 RID: 39777
		[Token(Token = "0x401B0B3")]
		MAPNAME_SCENE_DN19_16,
		// Token: 0x04009B62 RID: 39778
		[Token(Token = "0x401B0B4")]
		MAPNAME_SCENE_DN19_17,
		// Token: 0x04009B63 RID: 39779
		[Token(Token = "0x401B0B5")]
		MAPNAME_SCENE_DN19_18,
		// Token: 0x04009B64 RID: 39780
		[Token(Token = "0x401B0B6")]
		MAPNAME_SCENE_DN19_19,
		// Token: 0x04009B65 RID: 39781
		[Token(Token = "0x401B0B7")]
		MAPNAME_SCENE_DN19_20,
		// Token: 0x04009B66 RID: 39782
		[Token(Token = "0x401B0B8")]
		MAPNAME_SCENE_DN20_01,
		// Token: 0x04009B67 RID: 39783
		[Token(Token = "0x401B0B9")]
		MAPNAME_SCENE_DN20_02,
		// Token: 0x04009B68 RID: 39784
		[Token(Token = "0x401B0BA")]
		MAPNAME_SCENE_DN20_03,
		// Token: 0x04009B69 RID: 39785
		[Token(Token = "0x401B0BB")]
		MAPNAME_SCENE_DN20_04,
		// Token: 0x04009B6A RID: 39786
		[Token(Token = "0x401B0BC")]
		MAPNAME_SCENE_DN20_05,
		// Token: 0x04009B6B RID: 39787
		[Token(Token = "0x401B0BD")]
		MAPNAME_SCENE_DN20_06,
		// Token: 0x04009B6C RID: 39788
		[Token(Token = "0x401B0BE")]
		WARPPOINTNAME_D01,
		// Token: 0x04009B6D RID: 39789
		[Token(Token = "0x401B0BF")]
		WARPPOINTNAME_D01_front,
		// Token: 0x04009B6E RID: 39790
		[Token(Token = "0x401B0C0")]
		WARPPOINTNAME_D02,
		// Token: 0x04009B6F RID: 39791
		[Token(Token = "0x401B0C1")]
		WARPPOINTNAME_D03,
		// Token: 0x04009B70 RID: 39792
		[Token(Token = "0x401B0C2")]
		WARPPOINTNAME_D03_front,
		// Token: 0x04009B71 RID: 39793
		[Token(Token = "0x401B0C3")]
		WARPPOINTNAME_D04,
		// Token: 0x04009B72 RID: 39794
		[Token(Token = "0x401B0C4")]
		WARPPOINTNAME_D04_front,
		// Token: 0x04009B73 RID: 39795
		[Token(Token = "0x401B0C5")]
		WARPPOINTNAME_D05,
		// Token: 0x04009B74 RID: 39796
		[Token(Token = "0x401B0C6")]
		WARPPOINTNAME_D05_front,
		// Token: 0x04009B75 RID: 39797
		[Token(Token = "0x401B0C7")]
		WARPPOINTNAME_D06,
		// Token: 0x04009B76 RID: 39798
		[Token(Token = "0x401B0C8")]
		WARPPOINTNAME_D06_front,
		// Token: 0x04009B77 RID: 39799
		[Token(Token = "0x401B0C9")]
		WARPPOINTNAME_D07,
		// Token: 0x04009B78 RID: 39800
		[Token(Token = "0x401B0CA")]
		WARPPOINTNAME_D07_front,
		// Token: 0x04009B79 RID: 39801
		[Token(Token = "0x401B0CB")]
		WARPPOINTNAME_D08,
		// Token: 0x04009B7A RID: 39802
		[Token(Token = "0x401B0CC")]
		WARPPOINTNAME_D09,
		// Token: 0x04009B7B RID: 39803
		[Token(Token = "0x401B0CD")]
		WARPPOINTNAME_D10,
		// Token: 0x04009B7C RID: 39804
		[Token(Token = "0x401B0CE")]
		WARPPOINTNAME_D11,
		// Token: 0x04009B7D RID: 39805
		[Token(Token = "0x401B0CF")]
		WARPPOINTNAME_D12,
		// Token: 0x04009B7E RID: 39806
		[Token(Token = "0x401B0D0")]
		WARPPOINTNAME_D13,
		// Token: 0x04009B7F RID: 39807
		[Token(Token = "0x401B0D1")]
		WARPPOINTNAME_D13_front,
		// Token: 0x04009B80 RID: 39808
		[Token(Token = "0x401B0D2")]
		WARPPOINTNAME_D14,
		// Token: 0x04009B81 RID: 39809
		[Token(Token = "0x401B0D3")]
		WARPPOINTNAME_D14_front,
		// Token: 0x04009B82 RID: 39810
		[Token(Token = "0x401B0D4")]
		WARPPOINTNAME_D15,
		// Token: 0x04009B83 RID: 39811
		[Token(Token = "0x401B0D5")]
		WARPPOINTNAME_D16,
		// Token: 0x04009B84 RID: 39812
		[Token(Token = "0x401B0D6")]
		WARPPOINTNAME_D17,
		// Token: 0x04009B85 RID: 39813
		[Token(Token = "0x401B0D7")]
		WARPPOINTNAME_D18,
		// Token: 0x04009B86 RID: 39814
		[Token(Token = "0x401B0D8")]
		WARPPOINTNAME_D19,
		// Token: 0x04009B87 RID: 39815
		[Token(Token = "0x401B0D9")]
		WARPPOINTNAME_D19_front,
		// Token: 0x04009B88 RID: 39816
		[Token(Token = "0x401B0DA")]
		WARPPOINTNAME_D20,
		// Token: 0x04009B89 RID: 39817
		[Token(Token = "0x401B0DB")]
		MAPNAME_03,
		// Token: 0x04009B8A RID: 39818
		[Token(Token = "0x401B0DC")]
		MAPNAME_04,
		// Token: 0x04009B8B RID: 39819
		[Token(Token = "0x401B0DD")]
		MAPNAME_05,
		// Token: 0x04009B8C RID: 39820
		[Token(Token = "0x401B0DE")]
		MAPNAME_06,
		// Token: 0x04009B8D RID: 39821
		[Token(Token = "0x401B0DF")]
		MAPNAME_07,
		// Token: 0x04009B8E RID: 39822
		[Token(Token = "0x401B0E0")]
		MAPNAME_08,
		// Token: 0x04009B8F RID: 39823
		[Token(Token = "0x401B0E1")]
		MAPNAME_09,
		// Token: 0x04009B90 RID: 39824
		[Token(Token = "0x401B0E2")]
		MAPNAME_10,
		// Token: 0x04009B91 RID: 39825
		[Token(Token = "0x401B0E3")]
		MAPNAME_11,
		// Token: 0x04009B92 RID: 39826
		[Token(Token = "0x401B0E4")]
		MAPNAME_12,
		// Token: 0x04009B93 RID: 39827
		[Token(Token = "0x401B0E5")]
		MAPNAME_13,
		// Token: 0x04009B94 RID: 39828
		[Token(Token = "0x401B0E6")]
		MAPNAME_14,
		// Token: 0x04009B95 RID: 39829
		[Token(Token = "0x401B0E7")]
		MAPNAME_15,
		// Token: 0x04009B96 RID: 39830
		[Token(Token = "0x401B0E8")]
		MAPNAME_16,
		// Token: 0x04009B97 RID: 39831
		[Token(Token = "0x401B0E9")]
		MAPNAME_17,
		// Token: 0x04009B98 RID: 39832
		[Token(Token = "0x401B0EA")]
		MAPNAME_18,
		// Token: 0x04009B99 RID: 39833
		[Token(Token = "0x401B0EB")]
		MAPNAME_19,
		// Token: 0x04009B9A RID: 39834
		[Token(Token = "0x401B0EC")]
		MAPNAME_20,
		// Token: 0x04009B9B RID: 39835
		[Token(Token = "0x401B0ED")]
		MAPNAME_21,
		// Token: 0x04009B9C RID: 39836
		[Token(Token = "0x401B0EE")]
		MAPNAME_22,
		// Token: 0x04009B9D RID: 39837
		[Token(Token = "0x401B0EF")]
		MAPNAME_23,
		// Token: 0x04009B9E RID: 39838
		[Token(Token = "0x401B0F0")]
		MAPNAME_24,
		// Token: 0x04009B9F RID: 39839
		[Token(Token = "0x401B0F1")]
		MAPNAME_25,
		// Token: 0x04009BA0 RID: 39840
		[Token(Token = "0x401B0F2")]
		MAPNAME_26,
		// Token: 0x04009BA1 RID: 39841
		[Token(Token = "0x401B0F3")]
		MAPNAME_27,
		// Token: 0x04009BA2 RID: 39842
		[Token(Token = "0x401B0F4")]
		MAPNAME_28,
		// Token: 0x04009BA3 RID: 39843
		[Token(Token = "0x401B0F5")]
		MAPNAME_29,
		// Token: 0x04009BA4 RID: 39844
		[Token(Token = "0x401B0F6")]
		MAPNAME_30,
		// Token: 0x04009BA5 RID: 39845
		[Token(Token = "0x401B0F7")]
		MAPNAME_31,
		// Token: 0x04009BA6 RID: 39846
		[Token(Token = "0x401B0F8")]
		MAPNAME_32,
		// Token: 0x04009BA7 RID: 39847
		[Token(Token = "0x401B0F9")]
		MAPNAME_33,
		// Token: 0x04009BA8 RID: 39848
		[Token(Token = "0x401B0FA")]
		MAPNAME_34,
		// Token: 0x04009BA9 RID: 39849
		[Token(Token = "0x401B0FB")]
		MAPNAME_35,
		// Token: 0x04009BAA RID: 39850
		[Token(Token = "0x401B0FC")]
		MAPNAME_36,
		// Token: 0x04009BAB RID: 39851
		[Token(Token = "0x401B0FD")]
		MAPNAME_37,
		// Token: 0x04009BAC RID: 39852
		[Token(Token = "0x401B0FE")]
		MAPNAME_38,
		// Token: 0x04009BAD RID: 39853
		[Token(Token = "0x401B0FF")]
		MAPNAME_39,
		// Token: 0x04009BAE RID: 39854
		[Token(Token = "0x401B100")]
		MAPNAME_40,
		// Token: 0x04009BAF RID: 39855
		[Token(Token = "0x401B101")]
		MAPNAME_41,
		// Token: 0x04009BB0 RID: 39856
		[Token(Token = "0x401B102")]
		MAPNAME_42,
		// Token: 0x04009BB1 RID: 39857
		[Token(Token = "0x401B103")]
		MAPNAME_43,
		// Token: 0x04009BB2 RID: 39858
		[Token(Token = "0x401B104")]
		MAPNAME_44,
		// Token: 0x04009BB3 RID: 39859
		[Token(Token = "0x401B105")]
		MAPNAME_45,
		// Token: 0x04009BB4 RID: 39860
		[Token(Token = "0x401B106")]
		MAPNAME_46,
		// Token: 0x04009BB5 RID: 39861
		[Token(Token = "0x401B107")]
		MAPNAME_47,
		// Token: 0x04009BB6 RID: 39862
		[Token(Token = "0x401B108")]
		MAPNAME_48,
		// Token: 0x04009BB7 RID: 39863
		[Token(Token = "0x401B109")]
		MAPNAME_49,
		// Token: 0x04009BB8 RID: 39864
		[Token(Token = "0x401B10A")]
		MAPNAME_50,
		// Token: 0x04009BB9 RID: 39865
		[Token(Token = "0x401B10B")]
		MAPNAME_51,
		// Token: 0x04009BBA RID: 39866
		[Token(Token = "0x401B10C")]
		MAPNAME_52,
		// Token: 0x04009BBB RID: 39867
		[Token(Token = "0x401B10D")]
		MAPNAME_53,
		// Token: 0x04009BBC RID: 39868
		[Token(Token = "0x401B10E")]
		MAPNAME_54,
		// Token: 0x04009BBD RID: 39869
		[Token(Token = "0x401B10F")]
		MAPNAME_55,
		// Token: 0x04009BBE RID: 39870
		[Token(Token = "0x401B110")]
		MAPNAME_56,
		// Token: 0x04009BBF RID: 39871
		[Token(Token = "0x401B111")]
		MAPNAME_57,
		// Token: 0x04009BC0 RID: 39872
		[Token(Token = "0x401B112")]
		MAPNAME_58,
		// Token: 0x04009BC1 RID: 39873
		[Token(Token = "0x401B113")]
		MAPNAME_59,
		// Token: 0x04009BC2 RID: 39874
		[Token(Token = "0x401B114")]
		MAPNAME_60,
		// Token: 0x04009BC3 RID: 39875
		[Token(Token = "0x401B115")]
		MAPNAME_61,
		// Token: 0x04009BC4 RID: 39876
		[Token(Token = "0x401B116")]
		MAPNAME_62,
		// Token: 0x04009BC5 RID: 39877
		[Token(Token = "0x401B117")]
		MAPNAME_63,
		// Token: 0x04009BC6 RID: 39878
		[Token(Token = "0x401B118")]
		MAPNAME_64,
		// Token: 0x04009BC7 RID: 39879
		[Token(Token = "0x401B119")]
		MAPNAME_65,
		// Token: 0x04009BC8 RID: 39880
		[Token(Token = "0x401B11A")]
		MAPNAME_66,
		// Token: 0x04009BC9 RID: 39881
		[Token(Token = "0x401B11B")]
		MAPNAME_67,
		// Token: 0x04009BCA RID: 39882
		[Token(Token = "0x401B11C")]
		MAPNAME_68,
		// Token: 0x04009BCB RID: 39883
		[Token(Token = "0x401B11D")]
		MAPNAME_69,
		// Token: 0x04009BCC RID: 39884
		[Token(Token = "0x401B11E")]
		MAPNAME_70,
		// Token: 0x04009BCD RID: 39885
		[Token(Token = "0x401B11F")]
		MAPNAME_71,
		// Token: 0x04009BCE RID: 39886
		[Token(Token = "0x401B120")]
		MAPNAME_72,
		// Token: 0x04009BCF RID: 39887
		[Token(Token = "0x401B121")]
		MAPNAME_73,
		// Token: 0x04009BD0 RID: 39888
		[Token(Token = "0x401B122")]
		MAPNAME_74,
		// Token: 0x04009BD1 RID: 39889
		[Token(Token = "0x401B123")]
		MAPNAME_75,
		// Token: 0x04009BD2 RID: 39890
		[Token(Token = "0x401B124")]
		MAPNAME_76,
		// Token: 0x04009BD3 RID: 39891
		[Token(Token = "0x401B125")]
		MAPNAME_77,
		// Token: 0x04009BD4 RID: 39892
		[Token(Token = "0x401B126")]
		MAPNAME_78,
		// Token: 0x04009BD5 RID: 39893
		[Token(Token = "0x401B127")]
		MAPNAME_79,
		// Token: 0x04009BD6 RID: 39894
		[Token(Token = "0x401B128")]
		MAPNAME_80,
		// Token: 0x04009BD7 RID: 39895
		[Token(Token = "0x401B129")]
		MAPNAME_81,
		// Token: 0x04009BD8 RID: 39896
		[Token(Token = "0x401B12A")]
		MAPNAME_82,
		// Token: 0x04009BD9 RID: 39897
		[Token(Token = "0x401B12B")]
		WARPPOINTNAME_Town_05,
		// Token: 0x04009BDA RID: 39898
		[Token(Token = "0x401B12C")]
		WARPPOINTNAME_Town_06,
		// Token: 0x04009BDB RID: 39899
		[Token(Token = "0x401B12D")]
		FIELD_FOCUS_OBJECT_SAVEPOINT,
		// Token: 0x04009BDC RID: 39900
		[Token(Token = "0x401B12E")]
		MAPNAME_RESTAURANT_FRONT,
		// Token: 0x04009BDD RID: 39901
		[Token(Token = "0x401B12F")]
		MAPNAME_MYROOM,
		// Token: 0x04009BDE RID: 39902
		[Token(Token = "0x401B130")]
		POLICEBATCH_NAME_1 = 400000,
		// Token: 0x04009BDF RID: 39903
		[Token(Token = "0x401B131")]
		POLICEBATCH_NAME_2,
		// Token: 0x04009BE0 RID: 39904
		[Token(Token = "0x401B132")]
		POLICEBATCH_NAME_3,
		// Token: 0x04009BE1 RID: 39905
		[Token(Token = "0x401B133")]
		POLICEBATCH_NAME_4,
		// Token: 0x04009BE2 RID: 39906
		[Token(Token = "0x401B134")]
		POLICEBATCH_NAME_5,
		// Token: 0x04009BE3 RID: 39907
		[Token(Token = "0x401B135")]
		POLICEBATCH_NAME_6,
		// Token: 0x04009BE4 RID: 39908
		[Token(Token = "0x401B136")]
		POLICEBATCH_NAME_7,
		// Token: 0x04009BE5 RID: 39909
		[Token(Token = "0x401B137")]
		POLICEBATCH_NAME_8,
		// Token: 0x04009BE6 RID: 39910
		[Token(Token = "0x401B138")]
		POLICEBATCH_NAME_9,
		// Token: 0x04009BE7 RID: 39911
		[Token(Token = "0x401B139")]
		POLICEBATCH_NAME_10,
		// Token: 0x04009BE8 RID: 39912
		[Token(Token = "0x401B13A")]
		POLICEBATCH_DISCRIPT_1,
		// Token: 0x04009BE9 RID: 39913
		[Token(Token = "0x401B13B")]
		POLICEBATCH_DISCRIPT_2,
		// Token: 0x04009BEA RID: 39914
		[Token(Token = "0x401B13C")]
		POLICEBATCH_DISCRIPT_3,
		// Token: 0x04009BEB RID: 39915
		[Token(Token = "0x401B13D")]
		POLICEBATCH_DISCRIPT_4,
		// Token: 0x04009BEC RID: 39916
		[Token(Token = "0x401B13E")]
		POLICEBATCH_DISCRIPT_5,
		// Token: 0x04009BED RID: 39917
		[Token(Token = "0x401B13F")]
		POLICEBATCH_DISCRIPT_6,
		// Token: 0x04009BEE RID: 39918
		[Token(Token = "0x401B140")]
		POLICEBATCH_DISCRIPT_7,
		// Token: 0x04009BEF RID: 39919
		[Token(Token = "0x401B141")]
		POLICEBATCH_DISCRIPT_8,
		// Token: 0x04009BF0 RID: 39920
		[Token(Token = "0x401B142")]
		POLICEBATCH_DISCRIPT_9,
		// Token: 0x04009BF1 RID: 39921
		[Token(Token = "0x401B143")]
		POLICEBATCH_DISCRIPT_10,
		// Token: 0x04009BF2 RID: 39922
		[Token(Token = "0x401B144")]
		STAMPLIST_LISTNAME = 401000,
		// Token: 0x04009BF3 RID: 39923
		[Token(Token = "0x401B145")]
		STAMPLIST_NONE_01,
		// Token: 0x04009BF4 RID: 39924
		[Token(Token = "0x401B146")]
		STAMPLIST_NONE_02,
		// Token: 0x04009BF5 RID: 39925
		[Token(Token = "0x401B147")]
		STAMPLIST_STAMPNAME_0,
		// Token: 0x04009BF6 RID: 39926
		[Token(Token = "0x401B148")]
		STAMPLIST_STAMPNAME_1,
		// Token: 0x04009BF7 RID: 39927
		[Token(Token = "0x401B149")]
		STAMPLIST_STAMPNAME_2,
		// Token: 0x04009BF8 RID: 39928
		[Token(Token = "0x401B14A")]
		STAMPLIST_STAMPNAME_3,
		// Token: 0x04009BF9 RID: 39929
		[Token(Token = "0x401B14B")]
		STAMPLIST_STAMPNAME_4,
		// Token: 0x04009BFA RID: 39930
		[Token(Token = "0x401B14C")]
		STAMPLIST_STAMPNAME_5,
		// Token: 0x04009BFB RID: 39931
		[Token(Token = "0x401B14D")]
		STAMPLIST_STAMPNAME_6,
		// Token: 0x04009BFC RID: 39932
		[Token(Token = "0x401B14E")]
		STAMPLIST_STAMPNAME_7,
		// Token: 0x04009BFD RID: 39933
		[Token(Token = "0x401B14F")]
		STAMPLIST_STAMPNAME_8,
		// Token: 0x04009BFE RID: 39934
		[Token(Token = "0x401B150")]
		STAMPLIST_STAMPNAME_9,
		// Token: 0x04009BFF RID: 39935
		[Token(Token = "0x401B151")]
		STAMPLIST_STAMPNAME_10,
		// Token: 0x04009C00 RID: 39936
		[Token(Token = "0x401B152")]
		STAMPLIST_STAMPNAME_11,
		// Token: 0x04009C01 RID: 39937
		[Token(Token = "0x401B153")]
		STAMPLIST_STAMPNAME_12,
		// Token: 0x04009C02 RID: 39938
		[Token(Token = "0x401B154")]
		STAMPLIST_STAMPNAME_13,
		// Token: 0x04009C03 RID: 39939
		[Token(Token = "0x401B155")]
		STAMPLIST_STAMPNAME_14,
		// Token: 0x04009C04 RID: 39940
		[Token(Token = "0x401B156")]
		STAMPLIST_STAMPNAME_15,
		// Token: 0x04009C05 RID: 39941
		[Token(Token = "0x401B157")]
		STAMPLIST_STAMPNAME_16,
		// Token: 0x04009C06 RID: 39942
		[Token(Token = "0x401B158")]
		STAMPLIST_STAMPNAME_17,
		// Token: 0x04009C07 RID: 39943
		[Token(Token = "0x401B159")]
		STAMPLIST_STAMPNAME_18,
		// Token: 0x04009C08 RID: 39944
		[Token(Token = "0x401B15A")]
		STAMPLIST_STAMPNAME_19,
		// Token: 0x04009C09 RID: 39945
		[Token(Token = "0x401B15B")]
		STAMPLIST_STAMPNAME_20,
		// Token: 0x04009C0A RID: 39946
		[Token(Token = "0x401B15C")]
		STAMPLIST_STAMPNAME_21,
		// Token: 0x04009C0B RID: 39947
		[Token(Token = "0x401B15D")]
		STAMPLIST_STAMPNAME_22,
		// Token: 0x04009C0C RID: 39948
		[Token(Token = "0x401B15E")]
		STAMPLIST_STAMPNAME_23,
		// Token: 0x04009C0D RID: 39949
		[Token(Token = "0x401B15F")]
		STAMPLIST_STAMPNAME_24,
		// Token: 0x04009C0E RID: 39950
		[Token(Token = "0x401B160")]
		STAMPLIST_STAMPNAME_25,
		// Token: 0x04009C0F RID: 39951
		[Token(Token = "0x401B161")]
		STAMPLIST_STAMPNAME_26,
		// Token: 0x04009C10 RID: 39952
		[Token(Token = "0x401B162")]
		STAMPLIST_STAMPNAME_27,
		// Token: 0x04009C11 RID: 39953
		[Token(Token = "0x401B163")]
		STAMPLIST_STAMPNAME_28,
		// Token: 0x04009C12 RID: 39954
		[Token(Token = "0x401B164")]
		STAMPLIST_STAMPNAME_29,
		// Token: 0x04009C13 RID: 39955
		[Token(Token = "0x401B165")]
		STAMPLIST_STAMPNAME_30,
		// Token: 0x04009C14 RID: 39956
		[Token(Token = "0x401B166")]
		STAMPLIST_STAMPNAME_31,
		// Token: 0x04009C15 RID: 39957
		[Token(Token = "0x401B167")]
		STAMPLIST_STAMPNAME_32,
		// Token: 0x04009C16 RID: 39958
		[Token(Token = "0x401B168")]
		STAMPLIST_STAMPNAME_33,
		// Token: 0x04009C17 RID: 39959
		[Token(Token = "0x401B169")]
		STAMPLIST_STAMPNAME_34,
		// Token: 0x04009C18 RID: 39960
		[Token(Token = "0x401B16A")]
		STAMPLIST_STAMPNAME_35,
		// Token: 0x04009C19 RID: 39961
		[Token(Token = "0x401B16B")]
		STAMPLIST_STAMPNAME_36,
		// Token: 0x04009C1A RID: 39962
		[Token(Token = "0x401B16C")]
		STAMPLIST_STAMPNAME_37,
		// Token: 0x04009C1B RID: 39963
		[Token(Token = "0x401B16D")]
		STAMPLIST_STAMPNAME_38,
		// Token: 0x04009C1C RID: 39964
		[Token(Token = "0x401B16E")]
		STAMPLIST_STAMPNAME_39,
		// Token: 0x04009C1D RID: 39965
		[Token(Token = "0x401B16F")]
		STAMPLIST_STAMPNAME_40,
		// Token: 0x04009C1E RID: 39966
		[Token(Token = "0x401B170")]
		STAMPLIST_STAMPNAME_41,
		// Token: 0x04009C1F RID: 39967
		[Token(Token = "0x401B171")]
		STAMPLIST_STAMPNAME_42,
		// Token: 0x04009C20 RID: 39968
		[Token(Token = "0x401B172")]
		STAMPLIST_STAMPNAME_43,
		// Token: 0x04009C21 RID: 39969
		[Token(Token = "0x401B173")]
		STAMPLIST_STAMPNAME_44,
		// Token: 0x04009C22 RID: 39970
		[Token(Token = "0x401B174")]
		STAMPLIST_STAMPNAME_45,
		// Token: 0x04009C23 RID: 39971
		[Token(Token = "0x401B175")]
		STAMPLIST_STAMPNAME_46,
		// Token: 0x04009C24 RID: 39972
		[Token(Token = "0x401B176")]
		STAMPLIST_STAMPNAME_47,
		// Token: 0x04009C25 RID: 39973
		[Token(Token = "0x401B177")]
		STAMPLIST_STAMPNAME_48,
		// Token: 0x04009C26 RID: 39974
		[Token(Token = "0x401B178")]
		STAMPLIST_STAMPNAME_49,
		// Token: 0x04009C27 RID: 39975
		[Token(Token = "0x401B179")]
		STAMPLIST_STAMPNAME_50,
		// Token: 0x04009C28 RID: 39976
		[Token(Token = "0x401B17A")]
		STAMPLIST_STAMPNAME_51,
		// Token: 0x04009C29 RID: 39977
		[Token(Token = "0x401B17B")]
		STAMPLIST_STAMPNAME_52,
		// Token: 0x04009C2A RID: 39978
		[Token(Token = "0x401B17C")]
		STAMPLIST_STAMPNAME_53,
		// Token: 0x04009C2B RID: 39979
		[Token(Token = "0x401B17D")]
		STAMPLIST_STAMPNAME_54,
		// Token: 0x04009C2C RID: 39980
		[Token(Token = "0x401B17E")]
		STAMPLIST_STAMPNAME_55,
		// Token: 0x04009C2D RID: 39981
		[Token(Token = "0x401B17F")]
		STAMPLIST_STAMPNAME_56,
		// Token: 0x04009C2E RID: 39982
		[Token(Token = "0x401B180")]
		STAMPLIST_STAMPNAME_57,
		// Token: 0x04009C2F RID: 39983
		[Token(Token = "0x401B181")]
		STAMPLIST_STAMPNAME_58,
		// Token: 0x04009C30 RID: 39984
		[Token(Token = "0x401B182")]
		STAMPLIST_STAMPNAME_59,
		// Token: 0x04009C31 RID: 39985
		[Token(Token = "0x401B183")]
		STAMPLIST_STAMPNAME_60,
		// Token: 0x04009C32 RID: 39986
		[Token(Token = "0x401B184")]
		STAMPLIST_STAMPNAME_61,
		// Token: 0x04009C33 RID: 39987
		[Token(Token = "0x401B185")]
		STAMPLIST_STAMPNAME_62,
		// Token: 0x04009C34 RID: 39988
		[Token(Token = "0x401B186")]
		STAMPLIST_STAMPNAME_63,
		// Token: 0x04009C35 RID: 39989
		[Token(Token = "0x401B187")]
		STAMPLIST_STAMPNAME_64,
		// Token: 0x04009C36 RID: 39990
		[Token(Token = "0x401B188")]
		STAMPLIST_STAMPNAME_65,
		// Token: 0x04009C37 RID: 39991
		[Token(Token = "0x401B189")]
		STAMPLIST_STAMPNAME_66,
		// Token: 0x04009C38 RID: 39992
		[Token(Token = "0x401B18A")]
		STAMPLIST_STAMPNAME_67,
		// Token: 0x04009C39 RID: 39993
		[Token(Token = "0x401B18B")]
		STAMPLIST_STAMPNAME_68,
		// Token: 0x04009C3A RID: 39994
		[Token(Token = "0x401B18C")]
		STAMPLIST_STAMPNAME_69,
		// Token: 0x04009C3B RID: 39995
		[Token(Token = "0x401B18D")]
		STAMPLIST_STAMPNAME_70,
		// Token: 0x04009C3C RID: 39996
		[Token(Token = "0x401B18E")]
		STAMPLIST_STAMPNAME_71,
		// Token: 0x04009C3D RID: 39997
		[Token(Token = "0x401B18F")]
		STAMPLIST_STAMPNAME_72,
		// Token: 0x04009C3E RID: 39998
		[Token(Token = "0x401B190")]
		STAMPLIST_STAMPNAME_73,
		// Token: 0x04009C3F RID: 39999
		[Token(Token = "0x401B191")]
		STAMPLIST_STAMPNAME_74,
		// Token: 0x04009C40 RID: 40000
		[Token(Token = "0x401B192")]
		STAMPLIST_STAMPNAME_75,
		// Token: 0x04009C41 RID: 40001
		[Token(Token = "0x401B193")]
		STAMPLIST_STAMPNAME_76,
		// Token: 0x04009C42 RID: 40002
		[Token(Token = "0x401B194")]
		STAMPLIST_STAMPNAME_77,
		// Token: 0x04009C43 RID: 40003
		[Token(Token = "0x401B195")]
		STAMPLIST_STAMPNAME_78,
		// Token: 0x04009C44 RID: 40004
		[Token(Token = "0x401B196")]
		STAMPLIST_STAMPNAME_79,
		// Token: 0x04009C45 RID: 40005
		[Token(Token = "0x401B197")]
		STAMPLIST_STAMPNAME_80,
		// Token: 0x04009C46 RID: 40006
		[Token(Token = "0x401B198")]
		STAMPLIST_CONDITION_0,
		// Token: 0x04009C47 RID: 40007
		[Token(Token = "0x401B199")]
		STAMPLIST_CONDITION_1,
		// Token: 0x04009C48 RID: 40008
		[Token(Token = "0x401B19A")]
		STAMPLIST_CONDITION_2,
		// Token: 0x04009C49 RID: 40009
		[Token(Token = "0x401B19B")]
		STAMPLIST_CONDITION_3,
		// Token: 0x04009C4A RID: 40010
		[Token(Token = "0x401B19C")]
		STAMPLIST_CONDITION_4,
		// Token: 0x04009C4B RID: 40011
		[Token(Token = "0x401B19D")]
		STAMPLIST_CONDITION_5,
		// Token: 0x04009C4C RID: 40012
		[Token(Token = "0x401B19E")]
		STAMPLIST_CONDITION_6,
		// Token: 0x04009C4D RID: 40013
		[Token(Token = "0x401B19F")]
		STAMPLIST_CONDITION_7,
		// Token: 0x04009C4E RID: 40014
		[Token(Token = "0x401B1A0")]
		STAMPLIST_CONDITION_8,
		// Token: 0x04009C4F RID: 40015
		[Token(Token = "0x401B1A1")]
		STAMPLIST_CONDITION_9,
		// Token: 0x04009C50 RID: 40016
		[Token(Token = "0x401B1A2")]
		STAMPLIST_CONDITION_10,
		// Token: 0x04009C51 RID: 40017
		[Token(Token = "0x401B1A3")]
		STAMPLIST_CONDITION_11,
		// Token: 0x04009C52 RID: 40018
		[Token(Token = "0x401B1A4")]
		STAMPLIST_CONDITION_12,
		// Token: 0x04009C53 RID: 40019
		[Token(Token = "0x401B1A5")]
		STAMPLIST_CONDITION_13,
		// Token: 0x04009C54 RID: 40020
		[Token(Token = "0x401B1A6")]
		STAMPLIST_CONDITION_14,
		// Token: 0x04009C55 RID: 40021
		[Token(Token = "0x401B1A7")]
		STAMPLIST_CONDITION_15,
		// Token: 0x04009C56 RID: 40022
		[Token(Token = "0x401B1A8")]
		STAMPLIST_CONDITION_16,
		// Token: 0x04009C57 RID: 40023
		[Token(Token = "0x401B1A9")]
		STAMPLIST_CONDITION_17,
		// Token: 0x04009C58 RID: 40024
		[Token(Token = "0x401B1AA")]
		STAMPLIST_CONDITION_18,
		// Token: 0x04009C59 RID: 40025
		[Token(Token = "0x401B1AB")]
		STAMPLIST_CONDITION_19,
		// Token: 0x04009C5A RID: 40026
		[Token(Token = "0x401B1AC")]
		STAMPLIST_CONDITION_20,
		// Token: 0x04009C5B RID: 40027
		[Token(Token = "0x401B1AD")]
		STAMPLIST_CONDITION_21,
		// Token: 0x04009C5C RID: 40028
		[Token(Token = "0x401B1AE")]
		STAMPLIST_CONDITION_22,
		// Token: 0x04009C5D RID: 40029
		[Token(Token = "0x401B1AF")]
		STAMPLIST_CONDITION_23,
		// Token: 0x04009C5E RID: 40030
		[Token(Token = "0x401B1B0")]
		STAMPLIST_CONDITION_24,
		// Token: 0x04009C5F RID: 40031
		[Token(Token = "0x401B1B1")]
		STAMPLIST_CONDITION_25,
		// Token: 0x04009C60 RID: 40032
		[Token(Token = "0x401B1B2")]
		STAMPLIST_CONDITION_26,
		// Token: 0x04009C61 RID: 40033
		[Token(Token = "0x401B1B3")]
		STAMPLIST_CONDITION_27,
		// Token: 0x04009C62 RID: 40034
		[Token(Token = "0x401B1B4")]
		STAMPLIST_CONDITION_28,
		// Token: 0x04009C63 RID: 40035
		[Token(Token = "0x401B1B5")]
		STAMPLIST_CONDITION_29,
		// Token: 0x04009C64 RID: 40036
		[Token(Token = "0x401B1B6")]
		STAMPLIST_CONDITION_30,
		// Token: 0x04009C65 RID: 40037
		[Token(Token = "0x401B1B7")]
		STAMPLIST_CONDITION_31,
		// Token: 0x04009C66 RID: 40038
		[Token(Token = "0x401B1B8")]
		STAMPLIST_CONDITION_32,
		// Token: 0x04009C67 RID: 40039
		[Token(Token = "0x401B1B9")]
		STAMPLIST_CONDITION_33,
		// Token: 0x04009C68 RID: 40040
		[Token(Token = "0x401B1BA")]
		STAMPLIST_CONDITION_34,
		// Token: 0x04009C69 RID: 40041
		[Token(Token = "0x401B1BB")]
		STAMPLIST_CONDITION_35,
		// Token: 0x04009C6A RID: 40042
		[Token(Token = "0x401B1BC")]
		STAMPLIST_CONDITION_36,
		// Token: 0x04009C6B RID: 40043
		[Token(Token = "0x401B1BD")]
		STAMPLIST_CONDITION_37,
		// Token: 0x04009C6C RID: 40044
		[Token(Token = "0x401B1BE")]
		STAMPLIST_CONDITION_38,
		// Token: 0x04009C6D RID: 40045
		[Token(Token = "0x401B1BF")]
		STAMPLIST_CONDITION_39,
		// Token: 0x04009C6E RID: 40046
		[Token(Token = "0x401B1C0")]
		STAMPLIST_CONDITION_40,
		// Token: 0x04009C6F RID: 40047
		[Token(Token = "0x401B1C1")]
		STAMPLIST_CONDITION_41,
		// Token: 0x04009C70 RID: 40048
		[Token(Token = "0x401B1C2")]
		STAMPLIST_CONDITION_42,
		// Token: 0x04009C71 RID: 40049
		[Token(Token = "0x401B1C3")]
		STAMPLIST_CONDITION_43,
		// Token: 0x04009C72 RID: 40050
		[Token(Token = "0x401B1C4")]
		STAMPLIST_CONDITION_44,
		// Token: 0x04009C73 RID: 40051
		[Token(Token = "0x401B1C5")]
		STAMPLIST_CONDITION_45,
		// Token: 0x04009C74 RID: 40052
		[Token(Token = "0x401B1C6")]
		STAMPLIST_CONDITION_46,
		// Token: 0x04009C75 RID: 40053
		[Token(Token = "0x401B1C7")]
		STAMPLIST_CONDITION_47,
		// Token: 0x04009C76 RID: 40054
		[Token(Token = "0x401B1C8")]
		STAMPLIST_CONDITION_48,
		// Token: 0x04009C77 RID: 40055
		[Token(Token = "0x401B1C9")]
		STAMPLIST_CONDITION_49,
		// Token: 0x04009C78 RID: 40056
		[Token(Token = "0x401B1CA")]
		STAMPLIST_CONDITION_50,
		// Token: 0x04009C79 RID: 40057
		[Token(Token = "0x401B1CB")]
		STAMPLIST_CONDITION_51,
		// Token: 0x04009C7A RID: 40058
		[Token(Token = "0x401B1CC")]
		STAMPLIST_CONDITION_52,
		// Token: 0x04009C7B RID: 40059
		[Token(Token = "0x401B1CD")]
		STAMPLIST_CONDITION_53,
		// Token: 0x04009C7C RID: 40060
		[Token(Token = "0x401B1CE")]
		STAMPLIST_CONDITION_54,
		// Token: 0x04009C7D RID: 40061
		[Token(Token = "0x401B1CF")]
		STAMPLIST_CONDITION_55,
		// Token: 0x04009C7E RID: 40062
		[Token(Token = "0x401B1D0")]
		STAMPLIST_CONDITION_56,
		// Token: 0x04009C7F RID: 40063
		[Token(Token = "0x401B1D1")]
		STAMPLIST_CONDITION_57,
		// Token: 0x04009C80 RID: 40064
		[Token(Token = "0x401B1D2")]
		STAMPLIST_CONDITION_58,
		// Token: 0x04009C81 RID: 40065
		[Token(Token = "0x401B1D3")]
		STAMPLIST_CONDITION_59,
		// Token: 0x04009C82 RID: 40066
		[Token(Token = "0x401B1D4")]
		STAMPLIST_CONDITION_60,
		// Token: 0x04009C83 RID: 40067
		[Token(Token = "0x401B1D5")]
		STAMPLIST_CONDITION_61,
		// Token: 0x04009C84 RID: 40068
		[Token(Token = "0x401B1D6")]
		STAMPLIST_CONDITION_62,
		// Token: 0x04009C85 RID: 40069
		[Token(Token = "0x401B1D7")]
		STAMPLIST_CONDITION_63,
		// Token: 0x04009C86 RID: 40070
		[Token(Token = "0x401B1D8")]
		STAMPLIST_CONDITION_64,
		// Token: 0x04009C87 RID: 40071
		[Token(Token = "0x401B1D9")]
		STAMPLIST_CONDITION_65,
		// Token: 0x04009C88 RID: 40072
		[Token(Token = "0x401B1DA")]
		STAMPLIST_CONDITION_66,
		// Token: 0x04009C89 RID: 40073
		[Token(Token = "0x401B1DB")]
		STAMPLIST_CONDITION_67,
		// Token: 0x04009C8A RID: 40074
		[Token(Token = "0x401B1DC")]
		STAMPLIST_CONDITION_68,
		// Token: 0x04009C8B RID: 40075
		[Token(Token = "0x401B1DD")]
		STAMPLIST_CONDITION_69,
		// Token: 0x04009C8C RID: 40076
		[Token(Token = "0x401B1DE")]
		STAMPLIST_CONDITION_70,
		// Token: 0x04009C8D RID: 40077
		[Token(Token = "0x401B1DF")]
		STAMPLIST_CONDITION_71,
		// Token: 0x04009C8E RID: 40078
		[Token(Token = "0x401B1E0")]
		STAMPLIST_CONDITION_72,
		// Token: 0x04009C8F RID: 40079
		[Token(Token = "0x401B1E1")]
		STAMPLIST_CONDITION_73,
		// Token: 0x04009C90 RID: 40080
		[Token(Token = "0x401B1E2")]
		STAMPLIST_CONDITION_74,
		// Token: 0x04009C91 RID: 40081
		[Token(Token = "0x401B1E3")]
		STAMPLIST_CONDITION_75,
		// Token: 0x04009C92 RID: 40082
		[Token(Token = "0x401B1E4")]
		STAMPLIST_CONDITION_76,
		// Token: 0x04009C93 RID: 40083
		[Token(Token = "0x401B1E5")]
		STAMPLIST_CONDITION_77,
		// Token: 0x04009C94 RID: 40084
		[Token(Token = "0x401B1E6")]
		STAMPLIST_CONDITION_78,
		// Token: 0x04009C95 RID: 40085
		[Token(Token = "0x401B1E7")]
		STAMPLIST_CONDITION_79,
		// Token: 0x04009C96 RID: 40086
		[Token(Token = "0x401B1E8")]
		STAMPLIST_CONDITION_80,
		// Token: 0x04009C97 RID: 40087
		[Token(Token = "0x401B1E9")]
		STAMPLIST_FISHRECORD,
		// Token: 0x04009C98 RID: 40088
		[Token(Token = "0x401B1EA")]
		STAMPLIST_EVENTRECORD,
		// Token: 0x04009C99 RID: 40089
		[Token(Token = "0x401B1EB")]
		MOB_NAME_MEN_1 = 500000,
		// Token: 0x04009C9A RID: 40090
		[Token(Token = "0x401B1EC")]
		MOB_NAME_MEN_2,
		// Token: 0x04009C9B RID: 40091
		[Token(Token = "0x401B1ED")]
		MOB_NAME_MEN_3,
		// Token: 0x04009C9C RID: 40092
		[Token(Token = "0x401B1EE")]
		MOB_NAME_MEN_4,
		// Token: 0x04009C9D RID: 40093
		[Token(Token = "0x401B1EF")]
		MOB_NAME_MEN_5,
		// Token: 0x04009C9E RID: 40094
		[Token(Token = "0x401B1F0")]
		MOB_NAME_MEN_6,
		// Token: 0x04009C9F RID: 40095
		[Token(Token = "0x401B1F1")]
		MOB_NAME_MEN_7,
		// Token: 0x04009CA0 RID: 40096
		[Token(Token = "0x401B1F2")]
		MOB_NAME_MEN_8,
		// Token: 0x04009CA1 RID: 40097
		[Token(Token = "0x401B1F3")]
		MOB_NAME_MEN_9,
		// Token: 0x04009CA2 RID: 40098
		[Token(Token = "0x401B1F4")]
		MOB_NAME_MEN_10,
		// Token: 0x04009CA3 RID: 40099
		[Token(Token = "0x401B1F5")]
		MOB_NAME_MEN_11,
		// Token: 0x04009CA4 RID: 40100
		[Token(Token = "0x401B1F6")]
		MOB_NAME_MEN_12,
		// Token: 0x04009CA5 RID: 40101
		[Token(Token = "0x401B1F7")]
		MOB_NAME_MEN_13,
		// Token: 0x04009CA6 RID: 40102
		[Token(Token = "0x401B1F8")]
		MOB_NAME_MEN_14,
		// Token: 0x04009CA7 RID: 40103
		[Token(Token = "0x401B1F9")]
		MOB_NAME_MEN_15,
		// Token: 0x04009CA8 RID: 40104
		[Token(Token = "0x401B1FA")]
		MOB_NAME_MEN_16,
		// Token: 0x04009CA9 RID: 40105
		[Token(Token = "0x401B1FB")]
		MOB_NAME_MEN_17,
		// Token: 0x04009CAA RID: 40106
		[Token(Token = "0x401B1FC")]
		MOB_NAME_MEN_18,
		// Token: 0x04009CAB RID: 40107
		[Token(Token = "0x401B1FD")]
		MOB_NAME_MEN_19,
		// Token: 0x04009CAC RID: 40108
		[Token(Token = "0x401B1FE")]
		MOB_NAME_MEN_20,
		// Token: 0x04009CAD RID: 40109
		[Token(Token = "0x401B1FF")]
		MOB_NAME_MEN_21,
		// Token: 0x04009CAE RID: 40110
		[Token(Token = "0x401B200")]
		MOB_NAME_MEN_22,
		// Token: 0x04009CAF RID: 40111
		[Token(Token = "0x401B201")]
		MOB_NAME_MEN_23,
		// Token: 0x04009CB0 RID: 40112
		[Token(Token = "0x401B202")]
		MOB_NAME_MEN_24,
		// Token: 0x04009CB1 RID: 40113
		[Token(Token = "0x401B203")]
		MOB_NAME_MEN_25,
		// Token: 0x04009CB2 RID: 40114
		[Token(Token = "0x401B204")]
		MOB_NAME_MEN_26,
		// Token: 0x04009CB3 RID: 40115
		[Token(Token = "0x401B205")]
		MOB_NAME_MEN_27,
		// Token: 0x04009CB4 RID: 40116
		[Token(Token = "0x401B206")]
		MOB_NAME_MEN_28,
		// Token: 0x04009CB5 RID: 40117
		[Token(Token = "0x401B207")]
		MOB_NAME_MEN_29,
		// Token: 0x04009CB6 RID: 40118
		[Token(Token = "0x401B208")]
		MOB_NAME_MEN_30,
		// Token: 0x04009CB7 RID: 40119
		[Token(Token = "0x401B209")]
		MOB_NAME_MEN_31,
		// Token: 0x04009CB8 RID: 40120
		[Token(Token = "0x401B20A")]
		MOB_NAME_MEN_32,
		// Token: 0x04009CB9 RID: 40121
		[Token(Token = "0x401B20B")]
		MOB_NAME_MEN_33,
		// Token: 0x04009CBA RID: 40122
		[Token(Token = "0x401B20C")]
		MOB_NAME_MEN_34,
		// Token: 0x04009CBB RID: 40123
		[Token(Token = "0x401B20D")]
		MOB_NAME_MEN_35,
		// Token: 0x04009CBC RID: 40124
		[Token(Token = "0x401B20E")]
		MOB_NAME_MEN_36,
		// Token: 0x04009CBD RID: 40125
		[Token(Token = "0x401B20F")]
		MOB_NAME_MEN_37,
		// Token: 0x04009CBE RID: 40126
		[Token(Token = "0x401B210")]
		MOB_NAME_MEN_38,
		// Token: 0x04009CBF RID: 40127
		[Token(Token = "0x401B211")]
		MOB_NAME_MEN_39,
		// Token: 0x04009CC0 RID: 40128
		[Token(Token = "0x401B212")]
		MOB_NAME_MEN_40,
		// Token: 0x04009CC1 RID: 40129
		[Token(Token = "0x401B213")]
		MOB_NAME_MEN_41,
		// Token: 0x04009CC2 RID: 40130
		[Token(Token = "0x401B214")]
		MOB_NAME_MEN_42,
		// Token: 0x04009CC3 RID: 40131
		[Token(Token = "0x401B215")]
		MOB_NAME_MEN_43,
		// Token: 0x04009CC4 RID: 40132
		[Token(Token = "0x401B216")]
		MOB_NAME_MEN_44,
		// Token: 0x04009CC5 RID: 40133
		[Token(Token = "0x401B217")]
		MOB_NAME_MEN_45,
		// Token: 0x04009CC6 RID: 40134
		[Token(Token = "0x401B218")]
		MOB_NAME_MEN_46,
		// Token: 0x04009CC7 RID: 40135
		[Token(Token = "0x401B219")]
		MOB_NAME_MEN_47,
		// Token: 0x04009CC8 RID: 40136
		[Token(Token = "0x401B21A")]
		MOB_NAME_MEN_48,
		// Token: 0x04009CC9 RID: 40137
		[Token(Token = "0x401B21B")]
		MOB_NAME_MEN_49,
		// Token: 0x04009CCA RID: 40138
		[Token(Token = "0x401B21C")]
		MOB_NAME_MEN_50,
		// Token: 0x04009CCB RID: 40139
		[Token(Token = "0x401B21D")]
		MOB_NAME_MEN_51,
		// Token: 0x04009CCC RID: 40140
		[Token(Token = "0x401B21E")]
		MOB_NAME_MEN_52,
		// Token: 0x04009CCD RID: 40141
		[Token(Token = "0x401B21F")]
		MOB_NAME_MEN_53,
		// Token: 0x04009CCE RID: 40142
		[Token(Token = "0x401B220")]
		MOB_NAME_MEN_54,
		// Token: 0x04009CCF RID: 40143
		[Token(Token = "0x401B221")]
		MOB_NAME_MEN_55,
		// Token: 0x04009CD0 RID: 40144
		[Token(Token = "0x401B222")]
		MOB_NAME_MEN_56,
		// Token: 0x04009CD1 RID: 40145
		[Token(Token = "0x401B223")]
		MOB_NAME_MEN_57,
		// Token: 0x04009CD2 RID: 40146
		[Token(Token = "0x401B224")]
		MOB_NAME_MEN_58,
		// Token: 0x04009CD3 RID: 40147
		[Token(Token = "0x401B225")]
		MOB_NAME_MEN_59,
		// Token: 0x04009CD4 RID: 40148
		[Token(Token = "0x401B226")]
		MOB_NAME_MEN_60,
		// Token: 0x04009CD5 RID: 40149
		[Token(Token = "0x401B227")]
		MOB_NAME_MEN_61,
		// Token: 0x04009CD6 RID: 40150
		[Token(Token = "0x401B228")]
		MOB_NAME_MEN_62,
		// Token: 0x04009CD7 RID: 40151
		[Token(Token = "0x401B229")]
		MOB_NAME_MEN_63,
		// Token: 0x04009CD8 RID: 40152
		[Token(Token = "0x401B22A")]
		MOB_NAME_MEN_64,
		// Token: 0x04009CD9 RID: 40153
		[Token(Token = "0x401B22B")]
		MOB_NAME_MEN_65,
		// Token: 0x04009CDA RID: 40154
		[Token(Token = "0x401B22C")]
		MOB_NAME_MEN_66,
		// Token: 0x04009CDB RID: 40155
		[Token(Token = "0x401B22D")]
		MOB_NAME_MEN_67,
		// Token: 0x04009CDC RID: 40156
		[Token(Token = "0x401B22E")]
		MOB_NAME_MEN_68,
		// Token: 0x04009CDD RID: 40157
		[Token(Token = "0x401B22F")]
		MOB_NAME_MEN_69,
		// Token: 0x04009CDE RID: 40158
		[Token(Token = "0x401B230")]
		MOB_NAME_MEN_70,
		// Token: 0x04009CDF RID: 40159
		[Token(Token = "0x401B231")]
		MOB_NAME_MEN_71,
		// Token: 0x04009CE0 RID: 40160
		[Token(Token = "0x401B232")]
		MOB_NAME_MEN_72,
		// Token: 0x04009CE1 RID: 40161
		[Token(Token = "0x401B233")]
		MOB_NAME_MEN_73,
		// Token: 0x04009CE2 RID: 40162
		[Token(Token = "0x401B234")]
		MOB_NAME_WOM_1,
		// Token: 0x04009CE3 RID: 40163
		[Token(Token = "0x401B235")]
		MOB_NAME_WOM_2,
		// Token: 0x04009CE4 RID: 40164
		[Token(Token = "0x401B236")]
		MOB_NAME_WOM_3,
		// Token: 0x04009CE5 RID: 40165
		[Token(Token = "0x401B237")]
		MOB_NAME_WOM_4,
		// Token: 0x04009CE6 RID: 40166
		[Token(Token = "0x401B238")]
		MOB_NAME_WOM_5,
		// Token: 0x04009CE7 RID: 40167
		[Token(Token = "0x401B239")]
		MOB_NAME_WOM_6,
		// Token: 0x04009CE8 RID: 40168
		[Token(Token = "0x401B23A")]
		MOB_NAME_WOM_7,
		// Token: 0x04009CE9 RID: 40169
		[Token(Token = "0x401B23B")]
		MOB_NAME_WOM_8,
		// Token: 0x04009CEA RID: 40170
		[Token(Token = "0x401B23C")]
		MOB_NAME_WOM_9,
		// Token: 0x04009CEB RID: 40171
		[Token(Token = "0x401B23D")]
		MOB_NAME_WOM_10,
		// Token: 0x04009CEC RID: 40172
		[Token(Token = "0x401B23E")]
		MOB_NAME_WOM_11,
		// Token: 0x04009CED RID: 40173
		[Token(Token = "0x401B23F")]
		MOB_NAME_WOM_12,
		// Token: 0x04009CEE RID: 40174
		[Token(Token = "0x401B240")]
		MOB_NAME_WOM_13,
		// Token: 0x04009CEF RID: 40175
		[Token(Token = "0x401B241")]
		MOB_NAME_WOM_14,
		// Token: 0x04009CF0 RID: 40176
		[Token(Token = "0x401B242")]
		MOB_NAME_WOM_15,
		// Token: 0x04009CF1 RID: 40177
		[Token(Token = "0x401B243")]
		MOB_NAME_WOM_16,
		// Token: 0x04009CF2 RID: 40178
		[Token(Token = "0x401B244")]
		MOB_NAME_WOM_17,
		// Token: 0x04009CF3 RID: 40179
		[Token(Token = "0x401B245")]
		MOB_NAME_WOM_18,
		// Token: 0x04009CF4 RID: 40180
		[Token(Token = "0x401B246")]
		MOB_NAME_WOM_19,
		// Token: 0x04009CF5 RID: 40181
		[Token(Token = "0x401B247")]
		MOB_NAME_WOM_20,
		// Token: 0x04009CF6 RID: 40182
		[Token(Token = "0x401B248")]
		MOB_NAME_WOM_21,
		// Token: 0x04009CF7 RID: 40183
		[Token(Token = "0x401B249")]
		MOB_NAME_WOM_22,
		// Token: 0x04009CF8 RID: 40184
		[Token(Token = "0x401B24A")]
		MOB_NAME_WOM_23,
		// Token: 0x04009CF9 RID: 40185
		[Token(Token = "0x401B24B")]
		MOB_NAME_WOM_24,
		// Token: 0x04009CFA RID: 40186
		[Token(Token = "0x401B24C")]
		MOB_NAME_WOM_25,
		// Token: 0x04009CFB RID: 40187
		[Token(Token = "0x401B24D")]
		MOB_NAME_WOM_26,
		// Token: 0x04009CFC RID: 40188
		[Token(Token = "0x401B24E")]
		MOB_NAME_WOM_27,
		// Token: 0x04009CFD RID: 40189
		[Token(Token = "0x401B24F")]
		MOB_NAME_WOM_28,
		// Token: 0x04009CFE RID: 40190
		[Token(Token = "0x401B250")]
		MOB_NAME_WOM_29,
		// Token: 0x04009CFF RID: 40191
		[Token(Token = "0x401B251")]
		MOB_NAME_WOM_30,
		// Token: 0x04009D00 RID: 40192
		[Token(Token = "0x401B252")]
		MOB_NAME_WOM_31,
		// Token: 0x04009D01 RID: 40193
		[Token(Token = "0x401B253")]
		MOB_NAME_WOM_32,
		// Token: 0x04009D02 RID: 40194
		[Token(Token = "0x401B254")]
		MOB_NAME_WOM_33,
		// Token: 0x04009D03 RID: 40195
		[Token(Token = "0x401B255")]
		MOB_NAME_WOM_34,
		// Token: 0x04009D04 RID: 40196
		[Token(Token = "0x401B256")]
		MOB_NAME_WOM_35,
		// Token: 0x04009D05 RID: 40197
		[Token(Token = "0x401B257")]
		MOB_NAME_WOM_36,
		// Token: 0x04009D06 RID: 40198
		[Token(Token = "0x401B258")]
		MOB_NAME_WOM_37,
		// Token: 0x04009D07 RID: 40199
		[Token(Token = "0x401B259")]
		MOB_NAME_WOM_38,
		// Token: 0x04009D08 RID: 40200
		[Token(Token = "0x401B25A")]
		MOB_NAME_WOM_39,
		// Token: 0x04009D09 RID: 40201
		[Token(Token = "0x401B25B")]
		MOB_NAME_WOM_40,
		// Token: 0x04009D0A RID: 40202
		[Token(Token = "0x401B25C")]
		MOB_NAME_WOM_41,
		// Token: 0x04009D0B RID: 40203
		[Token(Token = "0x401B25D")]
		MOB_NAME_WOM_42,
		// Token: 0x04009D0C RID: 40204
		[Token(Token = "0x401B25E")]
		MOB_NAME_WOM_43,
		// Token: 0x04009D0D RID: 40205
		[Token(Token = "0x401B25F")]
		MOB_NAME_WOM_44,
		// Token: 0x04009D0E RID: 40206
		[Token(Token = "0x401B260")]
		MOB_NAME_WOM_45,
		// Token: 0x04009D0F RID: 40207
		[Token(Token = "0x401B261")]
		MOB_NAME_WOM_46,
		// Token: 0x04009D10 RID: 40208
		[Token(Token = "0x401B262")]
		MOB_NAME_WOM_47,
		// Token: 0x04009D11 RID: 40209
		[Token(Token = "0x401B263")]
		MOB_NAME_WOM_48,
		// Token: 0x04009D12 RID: 40210
		[Token(Token = "0x401B264")]
		MOB_NAME_WOM_49,
		// Token: 0x04009D13 RID: 40211
		[Token(Token = "0x401B265")]
		MOB_NAME_WOM_50,
		// Token: 0x04009D14 RID: 40212
		[Token(Token = "0x401B266")]
		MOB_NAME_WOM_51,
		// Token: 0x04009D15 RID: 40213
		[Token(Token = "0x401B267")]
		MOB_NAME_WOM_52,
		// Token: 0x04009D16 RID: 40214
		[Token(Token = "0x401B268")]
		MOB_NAME_WOM_53,
		// Token: 0x04009D17 RID: 40215
		[Token(Token = "0x401B269")]
		MOB_NAME_WOM_54,
		// Token: 0x04009D18 RID: 40216
		[Token(Token = "0x401B26A")]
		MOB_NAME_WOM_55,
		// Token: 0x04009D19 RID: 40217
		[Token(Token = "0x401B26B")]
		MOB_NAME_WOM_56,
		// Token: 0x04009D1A RID: 40218
		[Token(Token = "0x401B26C")]
		MOB_NAME_WOM_57,
		// Token: 0x04009D1B RID: 40219
		[Token(Token = "0x401B26D")]
		MOB_NAME_WOM_58,
		// Token: 0x04009D1C RID: 40220
		[Token(Token = "0x401B26E")]
		MOB_NAME_WOM_59,
		// Token: 0x04009D1D RID: 40221
		[Token(Token = "0x401B26F")]
		MOB_NAME_WOM_60,
		// Token: 0x04009D1E RID: 40222
		[Token(Token = "0x401B270")]
		MOB_NAME_WOM_61,
		// Token: 0x04009D1F RID: 40223
		[Token(Token = "0x401B271")]
		MOB_NAME_WOM_62,
		// Token: 0x04009D20 RID: 40224
		[Token(Token = "0x401B272")]
		MOB_NAME_WOM_63,
		// Token: 0x04009D21 RID: 40225
		[Token(Token = "0x401B273")]
		MOB_NAME_WOM_64,
		// Token: 0x04009D22 RID: 40226
		[Token(Token = "0x401B274")]
		MOB_NAME_WOM_65,
		// Token: 0x04009D23 RID: 40227
		[Token(Token = "0x401B275")]
		MOB_NAME_WOM_66,
		// Token: 0x04009D24 RID: 40228
		[Token(Token = "0x401B276")]
		MOB_NAME_WOM_67,
		// Token: 0x04009D25 RID: 40229
		[Token(Token = "0x401B277")]
		MOB_NAME_WOM_68,
		// Token: 0x04009D26 RID: 40230
		[Token(Token = "0x401B278")]
		MOB_NAME_WOM_69,
		// Token: 0x04009D27 RID: 40231
		[Token(Token = "0x401B279")]
		TWONAMES_1,
		// Token: 0x04009D28 RID: 40232
		[Token(Token = "0x401B27A")]
		TWONAMES_2,
		// Token: 0x04009D29 RID: 40233
		[Token(Token = "0x401B27B")]
		TWONAMES_3,
		// Token: 0x04009D2A RID: 40234
		[Token(Token = "0x401B27C")]
		TWONAMES_4,
		// Token: 0x04009D2B RID: 40235
		[Token(Token = "0x401B27D")]
		TWONAMES_5,
		// Token: 0x04009D2C RID: 40236
		[Token(Token = "0x401B27E")]
		TWONAMES_6,
		// Token: 0x04009D2D RID: 40237
		[Token(Token = "0x401B27F")]
		TWONAMES_7,
		// Token: 0x04009D2E RID: 40238
		[Token(Token = "0x401B280")]
		TWONAMES_8,
		// Token: 0x04009D2F RID: 40239
		[Token(Token = "0x401B281")]
		TWONAMES_9,
		// Token: 0x04009D30 RID: 40240
		[Token(Token = "0x401B282")]
		TWONAMES_10,
		// Token: 0x04009D31 RID: 40241
		[Token(Token = "0x401B283")]
		TWONAMES_11,
		// Token: 0x04009D32 RID: 40242
		[Token(Token = "0x401B284")]
		TWONAMES_12,
		// Token: 0x04009D33 RID: 40243
		[Token(Token = "0x401B285")]
		TWONAMES_13,
		// Token: 0x04009D34 RID: 40244
		[Token(Token = "0x401B286")]
		TWONAMES_14,
		// Token: 0x04009D35 RID: 40245
		[Token(Token = "0x401B287")]
		TWONAMES_15,
		// Token: 0x04009D36 RID: 40246
		[Token(Token = "0x401B288")]
		TWONAMES_16,
		// Token: 0x04009D37 RID: 40247
		[Token(Token = "0x401B289")]
		TWONAMES_17,
		// Token: 0x04009D38 RID: 40248
		[Token(Token = "0x401B28A")]
		TWONAMES_18,
		// Token: 0x04009D39 RID: 40249
		[Token(Token = "0x401B28B")]
		TWONAMES_19,
		// Token: 0x04009D3A RID: 40250
		[Token(Token = "0x401B28C")]
		TWONAMES_20,
		// Token: 0x04009D3B RID: 40251
		[Token(Token = "0x401B28D")]
		TWONAMES_21,
		// Token: 0x04009D3C RID: 40252
		[Token(Token = "0x401B28E")]
		TWONAMES_22,
		// Token: 0x04009D3D RID: 40253
		[Token(Token = "0x401B28F")]
		TWONAMES_23,
		// Token: 0x04009D3E RID: 40254
		[Token(Token = "0x401B290")]
		TWONAMES_24,
		// Token: 0x04009D3F RID: 40255
		[Token(Token = "0x401B291")]
		TWONAMES_25,
		// Token: 0x04009D40 RID: 40256
		[Token(Token = "0x401B292")]
		TWONAMES_26,
		// Token: 0x04009D41 RID: 40257
		[Token(Token = "0x401B293")]
		TWONAMES_27,
		// Token: 0x04009D42 RID: 40258
		[Token(Token = "0x401B294")]
		TWONAMES_28,
		// Token: 0x04009D43 RID: 40259
		[Token(Token = "0x401B295")]
		TWONAMES_29,
		// Token: 0x04009D44 RID: 40260
		[Token(Token = "0x401B296")]
		TWONAMES_30,
		// Token: 0x04009D45 RID: 40261
		[Token(Token = "0x401B297")]
		TWONAMES_31,
		// Token: 0x04009D46 RID: 40262
		[Token(Token = "0x401B298")]
		TWONAMES_32,
		// Token: 0x04009D47 RID: 40263
		[Token(Token = "0x401B299")]
		TWONAMES_33,
		// Token: 0x04009D48 RID: 40264
		[Token(Token = "0x401B29A")]
		TWONAMES_34,
		// Token: 0x04009D49 RID: 40265
		[Token(Token = "0x401B29B")]
		TWONAMES_35,
		// Token: 0x04009D4A RID: 40266
		[Token(Token = "0x401B29C")]
		TWONAMES_36,
		// Token: 0x04009D4B RID: 40267
		[Token(Token = "0x401B29D")]
		TWONAMES_37,
		// Token: 0x04009D4C RID: 40268
		[Token(Token = "0x401B29E")]
		TWONAMES_38,
		// Token: 0x04009D4D RID: 40269
		[Token(Token = "0x401B29F")]
		TWONAMES_39,
		// Token: 0x04009D4E RID: 40270
		[Token(Token = "0x401B2A0")]
		TWONAMES_40,
		// Token: 0x04009D4F RID: 40271
		[Token(Token = "0x401B2A1")]
		TWONAMES_41,
		// Token: 0x04009D50 RID: 40272
		[Token(Token = "0x401B2A2")]
		TWONAMES_42,
		// Token: 0x04009D51 RID: 40273
		[Token(Token = "0x401B2A3")]
		TWONAMES_43,
		// Token: 0x04009D52 RID: 40274
		[Token(Token = "0x401B2A4")]
		TWONAMES_44,
		// Token: 0x04009D53 RID: 40275
		[Token(Token = "0x401B2A5")]
		TWONAMES_45,
		// Token: 0x04009D54 RID: 40276
		[Token(Token = "0x401B2A6")]
		TWONAMES_46,
		// Token: 0x04009D55 RID: 40277
		[Token(Token = "0x401B2A7")]
		TWONAMES_47,
		// Token: 0x04009D56 RID: 40278
		[Token(Token = "0x401B2A8")]
		TWONAMES_48,
		// Token: 0x04009D57 RID: 40279
		[Token(Token = "0x401B2A9")]
		TWONAMES_49,
		// Token: 0x04009D58 RID: 40280
		[Token(Token = "0x401B2AA")]
		TWONAMES_50,
		// Token: 0x04009D59 RID: 40281
		[Token(Token = "0x401B2AB")]
		TWONAMES_51,
		// Token: 0x04009D5A RID: 40282
		[Token(Token = "0x401B2AC")]
		TWONAMES_52,
		// Token: 0x04009D5B RID: 40283
		[Token(Token = "0x401B2AD")]
		TWONAMES_53,
		// Token: 0x04009D5C RID: 40284
		[Token(Token = "0x401B2AE")]
		TWONAMES_54,
		// Token: 0x04009D5D RID: 40285
		[Token(Token = "0x401B2AF")]
		TWONAMES_55,
		// Token: 0x04009D5E RID: 40286
		[Token(Token = "0x401B2B0")]
		TWONAMES_56,
		// Token: 0x04009D5F RID: 40287
		[Token(Token = "0x401B2B1")]
		TWONAMES_57,
		// Token: 0x04009D60 RID: 40288
		[Token(Token = "0x401B2B2")]
		TWONAMES_58,
		// Token: 0x04009D61 RID: 40289
		[Token(Token = "0x401B2B3")]
		TWONAMES_59,
		// Token: 0x04009D62 RID: 40290
		[Token(Token = "0x401B2B4")]
		TWONAMES_60,
		// Token: 0x04009D63 RID: 40291
		[Token(Token = "0x401B2B5")]
		TWONAMES_61,
		// Token: 0x04009D64 RID: 40292
		[Token(Token = "0x401B2B6")]
		TWONAMES_62,
		// Token: 0x04009D65 RID: 40293
		[Token(Token = "0x401B2B7")]
		TWONAMES_63,
		// Token: 0x04009D66 RID: 40294
		[Token(Token = "0x401B2B8")]
		TWONAMES_64,
		// Token: 0x04009D67 RID: 40295
		[Token(Token = "0x401B2B9")]
		TWONAMES_65,
		// Token: 0x04009D68 RID: 40296
		[Token(Token = "0x401B2BA")]
		INTERACTION_NAME_1,
		// Token: 0x04009D69 RID: 40297
		[Token(Token = "0x401B2BB")]
		INTERACTION_NAME_2,
		// Token: 0x04009D6A RID: 40298
		[Token(Token = "0x401B2BC")]
		INTERACTION_NAME_3,
		// Token: 0x04009D6B RID: 40299
		[Token(Token = "0x401B2BD")]
		INTERACTION_NAME_4,
		// Token: 0x04009D6C RID: 40300
		[Token(Token = "0x401B2BE")]
		INTERACTION_NAME_5,
		// Token: 0x04009D6D RID: 40301
		[Token(Token = "0x401B2BF")]
		INTERACTION_NAME_6,
		// Token: 0x04009D6E RID: 40302
		[Token(Token = "0x401B2C0")]
		INTERACTION_NAME_7,
		// Token: 0x04009D6F RID: 40303
		[Token(Token = "0x401B2C1")]
		INTERACTION_NAME_8,
		// Token: 0x04009D70 RID: 40304
		[Token(Token = "0x401B2C2")]
		INTERACTION_NAME_9,
		// Token: 0x04009D71 RID: 40305
		[Token(Token = "0x401B2C3")]
		FUQ_LOVERCALL_SELECT_1 = 600001,
		// Token: 0x04009D72 RID: 40306
		[Token(Token = "0x401B2C4")]
		FUQ_LOVERCALL_SELECT_2,
		// Token: 0x04009D73 RID: 40307
		[Token(Token = "0x401B2C5")]
		FUQ_LOVERCALL_SELECT_3,
		// Token: 0x04009D74 RID: 40308
		[Token(Token = "0x401B2C6")]
		FUQ_LOVERCALL_SELECT_4,
		// Token: 0x04009D75 RID: 40309
		[Token(Token = "0x401B2C7")]
		FUQ_LOVERCALL_SELECT_5,
		// Token: 0x04009D76 RID: 40310
		[Token(Token = "0x401B2C8")]
		FUQ_LOVERCALL_SELECT_6,
		// Token: 0x04009D77 RID: 40311
		[Token(Token = "0x401B2C9")]
		FUQ_LOVERCALL_SELECT_7,
		// Token: 0x04009D78 RID: 40312
		[Token(Token = "0x401B2CA")]
		STATUS_LOVEPOINT = 900000,
		// Token: 0x04009D79 RID: 40313
		[Token(Token = "0x401B2CB")]
		STATUSGAUGE_NEXT,
		// Token: 0x04009D7A RID: 40314
		[Token(Token = "0x401B2CC")]
		STATUSHEAD_LV,
		// Token: 0x04009D7B RID: 40315
		[Token(Token = "0x401B2CD")]
		STATUSHEAD_ATK,
		// Token: 0x04009D7C RID: 40316
		[Token(Token = "0x401B2CE")]
		STATUSHEAD_DEF,
		// Token: 0x04009D7D RID: 40317
		[Token(Token = "0x401B2CF")]
		STATUSHEAD_MATK,
		// Token: 0x04009D7E RID: 40318
		[Token(Token = "0x401B2D0")]
		STATUSHEAD_MDEF,
		// Token: 0x04009D7F RID: 40319
		[Token(Token = "0x401B2D1")]
		STATUSHEAD_STR,
		// Token: 0x04009D80 RID: 40320
		[Token(Token = "0x401B2D2")]
		STATUSHEAD_VIT,
		// Token: 0x04009D81 RID: 40321
		[Token(Token = "0x401B2D3")]
		STATUSHEAD_INT,
		// Token: 0x04009D82 RID: 40322
		[Token(Token = "0x401B2D4")]
		STATUSHEAD_LOVEPOINT,
		// Token: 0x04009D83 RID: 40323
		[Token(Token = "0x401B2D5")]
		ITEMDISC_SHIPPED = 901000,
		// Token: 0x04009D84 RID: 40324
		[Token(Token = "0x401B2D6")]
		ITEMDISC_UNSHIPPED,
		// Token: 0x04009D85 RID: 40325
		[Token(Token = "0x401B2D7")]
		ITEMDISC_BUY,
		// Token: 0x04009D86 RID: 40326
		[Token(Token = "0x401B2D8")]
		ITEMDISC_SELL,
		// Token: 0x04009D87 RID: 40327
		[Token(Token = "0x401B2D9")]
		ITEMDISC_Lv,
		// Token: 0x04009D88 RID: 40328
		[Token(Token = "0x401B2DA")]
		ITEMBOX_STORAGETYPE_00,
		// Token: 0x04009D89 RID: 40329
		[Token(Token = "0x401B2DB")]
		ITEMBOX_STORAGETYPE_01,
		// Token: 0x04009D8A RID: 40330
		[Token(Token = "0x401B2DC")]
		ITEMBOX_STORAGETYPE_02,
		// Token: 0x04009D8B RID: 40331
		[Token(Token = "0x401B2DD")]
		ITEMBOX_STORAGETYPE_03,
		// Token: 0x04009D8C RID: 40332
		[Token(Token = "0x401B2DE")]
		ITEMBOX_STORAGETYPE_04,
		// Token: 0x04009D8D RID: 40333
		[Token(Token = "0x401B2DF")]
		ITEMBOX_STORAGETYPE_05,
		// Token: 0x04009D8E RID: 40334
		[Token(Token = "0x401B2E0")]
		ITEMBOX_STORAGETYPE_06,
		// Token: 0x04009D8F RID: 40335
		[Token(Token = "0x401B2E1")]
		ITEMBOX_STORAGETYPE_07,
		// Token: 0x04009D90 RID: 40336
		[Token(Token = "0x401B2E2")]
		ITEMBOX_STORAGETYPE_08,
		// Token: 0x04009D91 RID: 40337
		[Token(Token = "0x401B2E3")]
		ITEMBOX_STORAGETYPE_09,
		// Token: 0x04009D92 RID: 40338
		[Token(Token = "0x401B2E4")]
		EQUIPMENU_SLOT__Accessary = 902000,
		// Token: 0x04009D93 RID: 40339
		[Token(Token = "0x401B2E5")]
		EQUIPMENU_SLOT__Body,
		// Token: 0x04009D94 RID: 40340
		[Token(Token = "0x401B2E6")]
		EQUIPMENU_SLOT__Hand,
		// Token: 0x04009D95 RID: 40341
		[Token(Token = "0x401B2E7")]
		EQUIPMENU_SLOT__Head,
		// Token: 0x04009D96 RID: 40342
		[Token(Token = "0x401B2E8")]
		EQUIPMENU_SLOT__RuneA,
		// Token: 0x04009D97 RID: 40343
		[Token(Token = "0x401B2E9")]
		EQUIPMENU_SLOT__RuneB,
		// Token: 0x04009D98 RID: 40344
		[Token(Token = "0x401B2EA")]
		EQUIPMENU_SLOT__RuneRA,
		// Token: 0x04009D99 RID: 40345
		[Token(Token = "0x401B2EB")]
		EQUIPMENU_SLOT__RuneRB,
		// Token: 0x04009D9A RID: 40346
		[Token(Token = "0x401B2EC")]
		EQUIPMENU_SLOT__RuneRX,
		// Token: 0x04009D9B RID: 40347
		[Token(Token = "0x401B2ED")]
		EQUIPMENU_SLOT__RuneRY,
		// Token: 0x04009D9C RID: 40348
		[Token(Token = "0x401B2EE")]
		EQUIPMENU_SLOT__Shield,
		// Token: 0x04009D9D RID: 40349
		[Token(Token = "0x401B2EF")]
		EQUIPMENU_SLOT__Shoes,
		// Token: 0x04009D9E RID: 40350
		[Token(Token = "0x401B2F0")]
		EQUIPMENU_SLOT__Tool,
		// Token: 0x04009D9F RID: 40351
		[Token(Token = "0x401B2F1")]
		EQUIPMENU_SLOT__Weapon,
		// Token: 0x04009DA0 RID: 40352
		[Token(Token = "0x401B2F2")]
		EQUIPMENU_SLOT__Crop,
		// Token: 0x04009DA1 RID: 40353
		[Token(Token = "0x401B2F3")]
		EQUIPMENU_SLOT__Fish,
		// Token: 0x04009DA2 RID: 40354
		[Token(Token = "0x401B2F4")]
		EQUIPMENU_SLOT__Collect,
		// Token: 0x04009DA3 RID: 40355
		[Token(Token = "0x401B2F5")]
		EQUIPMENU_SLOT__Food,
		// Token: 0x04009DA4 RID: 40356
		[Token(Token = "0x401B2F6")]
		EQUIPMENU_SLOT__Drug,
		// Token: 0x04009DA5 RID: 40357
		[Token(Token = "0x401B2F7")]
		SAVE_TOP_SAVE = 903000,
		// Token: 0x04009DA6 RID: 40358
		[Token(Token = "0x401B2F8")]
		SAVE_TOP_LOAD,
		// Token: 0x04009DA7 RID: 40359
		[Token(Token = "0x401B2F9")]
		SAVE_AUTOSAVEDATAID,
		// Token: 0x04009DA8 RID: 40360
		[Token(Token = "0x401B2FA")]
		SAVE_SAVEDATAID,
		// Token: 0x04009DA9 RID: 40361
		[Token(Token = "0x401B2FB")]
		SAVE_SAVE_NOWPLACE_HEAD,
		// Token: 0x04009DAA RID: 40362
		[Token(Token = "0x401B2FC")]
		SAVE_SAVE_NEXTPLACE_HEAD,
		// Token: 0x04009DAB RID: 40363
		[Token(Token = "0x401B2FD")]
		SAVE_DOSAVE_CONFIRM,
		// Token: 0x04009DAC RID: 40364
		[Token(Token = "0x401B2FE")]
		SAVE_DOLOAD_CONFIRM,
		// Token: 0x04009DAD RID: 40365
		[Token(Token = "0x401B2FF")]
		SAVE_NOWSAVING,
		// Token: 0x04009DAE RID: 40366
		[Token(Token = "0x401B300")]
		SAVE_COMPLETED,
		// Token: 0x04009DAF RID: 40367
		[Token(Token = "0x401B301")]
		SAVE_BLOCKINGPOPUP,
		// Token: 0x04009DB0 RID: 40368
		[Token(Token = "0x401B302")]
		SAVE_TOP_INHERIT,
		// Token: 0x04009DB1 RID: 40369
		[Token(Token = "0x401B303")]
		SAVE_INHERIT_CONFIRM,
		// Token: 0x04009DB2 RID: 40370
		[Token(Token = "0x401B304")]
		DIFFICULTY_EASY,
		// Token: 0x04009DB3 RID: 40371
		[Token(Token = "0x401B305")]
		DIFFICULTY_NORMAL,
		// Token: 0x04009DB4 RID: 40372
		[Token(Token = "0x401B306")]
		DIFFICULTY_HARD,
		// Token: 0x04009DB5 RID: 40373
		[Token(Token = "0x401B307")]
		DIFFICULTY_HELL,
		// Token: 0x04009DB6 RID: 40374
		[Token(Token = "0x401B308")]
		SAVE_TIMEFORMAT,
		// Token: 0x04009DB7 RID: 40375
		[Token(Token = "0x401B309")]
		SAVE_FAILED,
		// Token: 0x04009DB8 RID: 40376
		[Token(Token = "0x401B30A")]
		LOAD_FAILED,
		// Token: 0x04009DB9 RID: 40377
		[Token(Token = "0x401B30B")]
		SAVE_DELETE_CONFIRM,
		// Token: 0x04009DBA RID: 40378
		[Token(Token = "0x401B30C")]
		SAVE_DELETING,
		// Token: 0x04009DBB RID: 40379
		[Token(Token = "0x401B30D")]
		SAVE_DELETED,
		// Token: 0x04009DBC RID: 40380
		[Token(Token = "0x401B30E")]
		SAVE_DELETE_FAIL,
		// Token: 0x04009DBD RID: 40381
		[Token(Token = "0x401B30F")]
		SAVE_OVERWRITE,
		// Token: 0x04009DBE RID: 40382
		[Token(Token = "0x401B310")]
		SAVE_NOWLOADING,
		// Token: 0x04009DBF RID: 40383
		[Token(Token = "0x401B311")]
		SAVE_LOADERROR,
		// Token: 0x04009DC0 RID: 40384
		[Token(Token = "0x401B312")]
		SAVE_NODELETEDATA,
		// Token: 0x04009DC1 RID: 40385
		[Token(Token = "0x401B313")]
		SAVE_NODATA,
		// Token: 0x04009DC2 RID: 40386
		[Token(Token = "0x401B314")]
		SAVE_CANTSAVE,
		// Token: 0x04009DC3 RID: 40387
		[Token(Token = "0x401B315")]
		RECIPE_DOWNSORT = 904000,
		// Token: 0x04009DC4 RID: 40388
		[Token(Token = "0x401B316")]
		RECIPE_NEED_MATERIAL,
		// Token: 0x04009DC5 RID: 40389
		[Token(Token = "0x401B317")]
		RECIPE_USE_MATERIAL,
		// Token: 0x04009DC6 RID: 40390
		[Token(Token = "0x401B318")]
		RECIPE_SKILL_DOWNSORT,
		// Token: 0x04009DC7 RID: 40391
		[Token(Token = "0x401B319")]
		RECIPE_SKILL_UPSORT,
		// Token: 0x04009DC8 RID: 40392
		[Token(Token = "0x401B31A")]
		RECIPE_UPSORT,
		// Token: 0x04009DC9 RID: 40393
		[Token(Token = "0x401B31B")]
		RECIPE_NAME_LIST_FORMAT,
		// Token: 0x04009DCA RID: 40394
		[Token(Token = "0x401B31C")]
		STRENGTHENING_MATERIAL = 904009,
		// Token: 0x04009DCB RID: 40395
		[Token(Token = "0x401B31D")]
		STRENGTHENING_BASEITEM,
		// Token: 0x04009DCC RID: 40396
		[Token(Token = "0x401B31E")]
		STRENGTHENING_RESULT,
		// Token: 0x04009DCD RID: 40397
		[Token(Token = "0x401B31F")]
		DIRECTIONSIGN_ADV = 905000,
		// Token: 0x04009DCE RID: 40398
		[Token(Token = "0x401B320")]
		DIRECTIONSIGN_SELECT_MONSTER,
		// Token: 0x04009DCF RID: 40399
		[Token(Token = "0x401B321")]
		DIRECTIONSIGN_SELECT_ITEM,
		// Token: 0x04009DD0 RID: 40400
		[Token(Token = "0x401B322")]
		DIRECTIONSIGN_SELECT_END,
		// Token: 0x04009DD1 RID: 40401
		[Token(Token = "0x401B323")]
		SHIPPINGREC_CAT_HEAD = 910000,
		// Token: 0x04009DD2 RID: 40402
		[Token(Token = "0x401B324")]
		SHIPPINGREC_CAT_RECORD,
		// Token: 0x04009DD3 RID: 40403
		[Token(Token = "0x401B325")]
		SHIPPINGREC_ALL_HEAD,
		// Token: 0x04009DD4 RID: 40404
		[Token(Token = "0x401B326")]
		SHIPPINGREC_CAT_COMPLETEDRATE,
		// Token: 0x04009DD5 RID: 40405
		[Token(Token = "0x401B327")]
		SHIPPINGREC_NEXT_INCOME,
		// Token: 0x04009DD6 RID: 40406
		[Token(Token = "0x401B328")]
		SHIPPINGREC_ALL_COMPLETEDRATE,
		// Token: 0x04009DD7 RID: 40407
		[Token(Token = "0x401B329")]
		SHIPPINGREC_TYPE_CROP,
		// Token: 0x04009DD8 RID: 40408
		[Token(Token = "0x401B32A")]
		SHIPPINGREC_TYPE_DRUG,
		// Token: 0x04009DD9 RID: 40409
		[Token(Token = "0x401B32B")]
		SHIPPINGREC_TYPE_WEAPON,
		// Token: 0x04009DDA RID: 40410
		[Token(Token = "0x401B32C")]
		SHIPPINGREC_TYPE_ARMOR,
		// Token: 0x04009DDB RID: 40411
		[Token(Token = "0x401B32D")]
		SHIPPINGREC_TYPE_ACC,
		// Token: 0x04009DDC RID: 40412
		[Token(Token = "0x401B32E")]
		SHIPPINGREC_TYPE_FOOD,
		// Token: 0x04009DDD RID: 40413
		[Token(Token = "0x401B32F")]
		SHIPPINGREC_TYPE_SEA,
		// Token: 0x04009DDE RID: 40414
		[Token(Token = "0x401B330")]
		SHIPPINGREC_TYPE_ETC,
		// Token: 0x04009DDF RID: 40415
		[Token(Token = "0x401B331")]
		SHIPPINGREC_NOREC_CROP,
		// Token: 0x04009DE0 RID: 40416
		[Token(Token = "0x401B332")]
		SHIPPINGREC_NOREC_DRUG,
		// Token: 0x04009DE1 RID: 40417
		[Token(Token = "0x401B333")]
		SHIPPINGREC_NOREC_WEAPON,
		// Token: 0x04009DE2 RID: 40418
		[Token(Token = "0x401B334")]
		SHIPPINGREC_NOREC_ARMOR,
		// Token: 0x04009DE3 RID: 40419
		[Token(Token = "0x401B335")]
		SHIPPINGREC_NOREC_ACC,
		// Token: 0x04009DE4 RID: 40420
		[Token(Token = "0x401B336")]
		SHIPPINGREC_NOREC_FOOD,
		// Token: 0x04009DE5 RID: 40421
		[Token(Token = "0x401B337")]
		SHIPPINGREC_NOREC_SEA,
		// Token: 0x04009DE6 RID: 40422
		[Token(Token = "0x401B338")]
		SHIPPINGREC_NOREC_ETC,
		// Token: 0x04009DE7 RID: 40423
		[Token(Token = "0x401B339")]
		SEASON_1 = 999000,
		// Token: 0x04009DE8 RID: 40424
		[Token(Token = "0x401B33A")]
		SEASON_2,
		// Token: 0x04009DE9 RID: 40425
		[Token(Token = "0x401B33B")]
		SEASON_3,
		// Token: 0x04009DEA RID: 40426
		[Token(Token = "0x401B33C")]
		SEASON_4,
		// Token: 0x04009DEB RID: 40427
		[Token(Token = "0x401B33D")]
		RF3TXTSTATUSSCREN_ITEMDETAIL_MUSHROOM,
		// Token: 0x04009DEC RID: 40428
		[Token(Token = "0x401B33E")]
		POPUP_CHOICE_YES,
		// Token: 0x04009DED RID: 40429
		[Token(Token = "0x401B33F")]
		POPUP_CHOICE_NO,
		// Token: 0x04009DEE RID: 40430
		[Token(Token = "0x401B340")]
		POPUP_CHOICE_OK
	}
}
