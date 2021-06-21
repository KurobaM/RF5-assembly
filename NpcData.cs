using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x020007EE RID: 2030
[Token(Token = "0x2000541")]
[Serializable]
public class NpcData
{
	// Token: 0x1700074D RID: 1869
	// (get) Token: 0x06003508 RID: 13576 RVA: 0x00012108 File Offset: 0x00010308
	// (set) Token: 0x06003509 RID: 13577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B0")]
	public bool forceDisabled
	{
		[Token(Token = "0x6002C16")]
		[Address(RVA = "0x25884D0", Offset = "0x25885D1", VA = "0x25884D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C17")]
		[Address(RVA = "0x25885A0", Offset = "0x25886A1", VA = "0x25885A0")]
		set
		{
		}
	}

	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x0600350A RID: 13578 RVA: 0x00012120 File Offset: 0x00010320
	// (set) Token: 0x0600350B RID: 13579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B1")]
	public bool IsShortPlay
	{
		[Token(Token = "0x6002C18")]
		[Address(RVA = "0x25885D0", Offset = "0x25886D1", VA = "0x25885D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C19")]
		[Address(RVA = "0x25885F0", Offset = "0x25886F1", VA = "0x25885F0")]
		set
		{
		}
	}

	// Token: 0x1700074F RID: 1871
	// (get) Token: 0x0600350C RID: 13580 RVA: 0x00012138 File Offset: 0x00010338
	// (set) Token: 0x0600350D RID: 13581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B2")]
	public bool IsStop
	{
		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0x2588630", Offset = "0x2588731", VA = "0x2588630")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x2588640", Offset = "0x2588741", VA = "0x2588640")]
		set
		{
		}
	}

	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x0600350E RID: 13582 RVA: 0x00012150 File Offset: 0x00010350
	// (set) Token: 0x0600350F RID: 13583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B3")]
	public bool IsSlowDown
	{
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x2588780", Offset = "0x2588881", VA = "0x2588780")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x2588790", Offset = "0x2588891", VA = "0x2588790")]
		set
		{
		}
	}

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06003510 RID: 13584 RVA: 0x00012168 File Offset: 0x00010368
	// (set) Token: 0x06003511 RID: 13585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B4")]
	public NpcAnimState AnimationState
	{
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x25888D0", Offset = "0x25889D1", VA = "0x25888D0")]
		get
		{
			return NpcAnimState.Idle;
		}
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x25888F0", Offset = "0x25889F1", VA = "0x25888F0")]
		set
		{
		}
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06003512 RID: 13586 RVA: 0x00012180 File Offset: 0x00010380
	// (set) Token: 0x06003513 RID: 13587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B5")]
	public bool AnimationSitting
	{
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x2588A80", Offset = "0x2588B81", VA = "0x2588A80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x2588A50", Offset = "0x2588B51", VA = "0x2588A50")]
		set
		{
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06003514 RID: 13588 RVA: 0x00012198 File Offset: 0x00010398
	// (set) Token: 0x06003515 RID: 13589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B6")]
	public Vector3 SavePosition
	{
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x2588AA0", Offset = "0x2588BA1", VA = "0x2588AA0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x2588AD0", Offset = "0x2588BD1", VA = "0x2588AD0")]
		set
		{
		}
	}

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06003516 RID: 13590 RVA: 0x000121B0 File Offset: 0x000103B0
	// (set) Token: 0x06003517 RID: 13591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B7")]
	public Quaternion SaveRotation
	{
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x2588B20", Offset = "0x2588C21", VA = "0x2588B20")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x2588B50", Offset = "0x2588C51", VA = "0x2588B50")]
		set
		{
		}
	}

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06003518 RID: 13592 RVA: 0x000121C8 File Offset: 0x000103C8
	// (set) Token: 0x06003519 RID: 13593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B8")]
	public int NpcGroupId
	{
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x2588BA0", Offset = "0x2588CA1", VA = "0x2588BA0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x2588BC0", Offset = "0x2588CC1", VA = "0x2588BC0")]
		set
		{
		}
	}

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x0600351A RID: 13594 RVA: 0x000121E0 File Offset: 0x000103E0
	// (set) Token: 0x0600351B RID: 13595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005B9")]
	public bool IsReached
	{
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x2588BF0", Offset = "0x2588CF1", VA = "0x2588BF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x2588C00", Offset = "0x2588D01", VA = "0x2588C00")]
		set
		{
		}
	}

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x0600351C RID: 13596 RVA: 0x000121F8 File Offset: 0x000103F8
	// (set) Token: 0x0600351D RID: 13597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BA")]
	public Weather HomeBackWeather
	{
		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x2588D40", Offset = "0x2588E41", VA = "0x2588D40")]
		get
		{
			return Weather.None;
		}
		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x2588D50", Offset = "0x2588E51", VA = "0x2588D50")]
		set
		{
		}
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x0600351E RID: 13598 RVA: 0x00012210 File Offset: 0x00010410
	// (set) Token: 0x0600351F RID: 13599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BB")]
	public FieldPlaceId CurrentFieldPlaceId
	{
		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x2588D60", Offset = "0x2588E61", VA = "0x2588D60")]
		get
		{
			return FieldPlaceId.None;
		}
		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x2588D80", Offset = "0x2588E81", VA = "0x2588D80")]
		set
		{
		}
	}

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x06003520 RID: 13600 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003521 RID: 13601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BC")]
	public GameObject NextPatrolPoint
	{
		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x2588DB0", Offset = "0x2588EB1", VA = "0x2588DB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x2588DC0", Offset = "0x2588EC1", VA = "0x2588DC0")]
		set
		{
		}
	}

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x06003522 RID: 13602 RVA: 0x00012228 File Offset: 0x00010428
	// (set) Token: 0x06003523 RID: 13603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BD")]
	public int CurrentLifecycleTime
	{
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x2588DD0", Offset = "0x2588ED1", VA = "0x2588DD0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x2588DE0", Offset = "0x2588EE1", VA = "0x2588DE0")]
		set
		{
		}
	}

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06003524 RID: 13604 RVA: 0x00012240 File Offset: 0x00010440
	// (set) Token: 0x06003525 RID: 13605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BE")]
	public LifecycleState CurrentLifecycleState
	{
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x2588DF0", Offset = "0x2588EF1", VA = "0x2588DF0")]
		get
		{
			return LifecycleState.NONE;
		}
		[Token(Token = "0x6002C33")]
		[Address(RVA = "0x2588E10", Offset = "0x2588F11", VA = "0x2588E10")]
		set
		{
		}
	}

	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06003526 RID: 13606 RVA: 0x00012258 File Offset: 0x00010458
	// (set) Token: 0x06003527 RID: 13607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005BF")]
	public Place CurrentPlace
	{
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x2588E50", Offset = "0x2588F51", VA = "0x2588E50")]
		get
		{
			return Place.Field;
		}
		[Token(Token = "0x6002C35")]
		[Address(RVA = "0x2588E70", Offset = "0x2588F71", VA = "0x2588E70")]
		set
		{
		}
	}

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06003528 RID: 13608 RVA: 0x00012270 File Offset: 0x00010470
	// (set) Token: 0x06003529 RID: 13609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C0")]
	public Place TargetPlace
	{
		[Token(Token = "0x6002C36")]
		[Address(RVA = "0x2588EA0", Offset = "0x2588FA1", VA = "0x2588EA0")]
		get
		{
			return Place.Field;
		}
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x2588EB0", Offset = "0x2588FB1", VA = "0x2588EB0")]
		set
		{
		}
	}

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x0600352A RID: 13610 RVA: 0x00012288 File Offset: 0x00010488
	// (set) Token: 0x0600352B RID: 13611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C1")]
	public int RotatePatternNumber
	{
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x2588EC0", Offset = "0x2588FC1", VA = "0x2588EC0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x2588EE0", Offset = "0x2588FE1", VA = "0x2588EE0")]
		set
		{
		}
	}

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x0600352C RID: 13612 RVA: 0x000122A0 File Offset: 0x000104A0
	// (set) Token: 0x0600352D RID: 13613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C2")]
	public float walkSpeed
	{
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x2588F10", Offset = "0x2589011", VA = "0x2588F10")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x2588F20", Offset = "0x2589021", VA = "0x2588F20")]
		set
		{
		}
	}

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x0600352E RID: 13614 RVA: 0x000122B8 File Offset: 0x000104B8
	// (set) Token: 0x0600352F RID: 13615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C3")]
	public LookAtState lookAtState
	{
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x2588F30", Offset = "0x2589031", VA = "0x2588F30")]
		get
		{
			return LookAtState.None;
		}
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x2588F40", Offset = "0x2589041", VA = "0x2588F40")]
		set
		{
		}
	}

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x06003530 RID: 13616 RVA: 0x000122D0 File Offset: 0x000104D0
	// (set) Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C4")]
	public bool IsTalking
	{
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x2588F50", Offset = "0x2589051", VA = "0x2588F50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x2588F70", Offset = "0x2589071", VA = "0x2588F70")]
		set
		{
		}
	}

	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x06003532 RID: 13618 RVA: 0x000122E8 File Offset: 0x000104E8
	// (set) Token: 0x06003533 RID: 13619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C5")]
	public int TodayTalkCount
	{
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x2588FB0", Offset = "0x25890B1", VA = "0x2588FB0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C41")]
		[Address(RVA = "0x2588FD0", Offset = "0x25890D1", VA = "0x2588FD0")]
		set
		{
		}
	}

	// Token: 0x17000763 RID: 1891
	// (get) Token: 0x06003534 RID: 13620 RVA: 0x00012300 File Offset: 0x00010500
	// (set) Token: 0x06003535 RID: 13621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C6")]
	public int NowEventId
	{
		[Token(Token = "0x6002C42")]
		[Address(RVA = "0x2589000", Offset = "0x2589101", VA = "0x2589000")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C43")]
		[Address(RVA = "0x2589020", Offset = "0x2589121", VA = "0x2589020")]
		set
		{
		}
	}

	// Token: 0x17000764 RID: 1892
	// (get) Token: 0x06003536 RID: 13622 RVA: 0x00012318 File Offset: 0x00010518
	// (set) Token: 0x06003537 RID: 13623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C7")]
	public Place Home
	{
		[Token(Token = "0x6002C44")]
		[Address(RVA = "0x2589050", Offset = "0x2589151", VA = "0x2589050")]
		get
		{
			return Place.Field;
		}
		[Token(Token = "0x6002C45")]
		[Address(RVA = "0x2589070", Offset = "0x2589171", VA = "0x2589070")]
		set
		{
		}
	}

	// Token: 0x17000765 RID: 1893
	// (get) Token: 0x06003538 RID: 13624 RVA: 0x00012330 File Offset: 0x00010530
	// (set) Token: 0x06003539 RID: 13625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005C8")]
	public Place Job
	{
		[Token(Token = "0x6002C46")]
		[Address(RVA = "0x25890A0", Offset = "0x25891A1", VA = "0x25890A0")]
		get
		{
			return Place.Field;
		}
		[Token(Token = "0x6002C47")]
		[Address(RVA = "0x25890C0", Offset = "0x25891C1", VA = "0x25890C0")]
		set
		{
		}
	}

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x0600353A RID: 13626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005C9")]
	private Place[] FavoritePlace
	{
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x25890F0", Offset = "0x25891F1", VA = "0x25890F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x0600353B RID: 13627 RVA: 0x00012348 File Offset: 0x00010548
	// (set) Token: 0x0600353C RID: 13628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005CA")]
	public bool IsSetInitialPose
	{
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x25891A0", Offset = "0x25892A1", VA = "0x25891A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x25891B0", Offset = "0x25892B1", VA = "0x25891B0")]
		set
		{
		}
	}

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x0600353D RID: 13629 RVA: 0x00012360 File Offset: 0x00010560
	// (set) Token: 0x0600353E RID: 13630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005CB")]
	public bool IsDateReserved
	{
		[Token(Token = "0x6002C4B")]
		[Address(RVA = "0x25891C0", Offset = "0x25892C1", VA = "0x25891C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C4C")]
		[Address(RVA = "0x25891E0", Offset = "0x25892E1", VA = "0x25891E0")]
		set
		{
		}
	}

	// Token: 0x17000769 RID: 1897
	// (get) Token: 0x0600353F RID: 13631 RVA: 0x00012378 File Offset: 0x00010578
	// (set) Token: 0x06003540 RID: 13632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005CC")]
	public int dateDay
	{
		[Token(Token = "0x6002C4D")]
		[Address(RVA = "0x2589210", Offset = "0x2589311", VA = "0x2589210")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C4E")]
		[Address(RVA = "0x2589230", Offset = "0x2589331", VA = "0x2589230")]
		set
		{
		}
	}

	// Token: 0x1700076A RID: 1898
	// (get) Token: 0x06003541 RID: 13633 RVA: 0x00012390 File Offset: 0x00010590
	[Token(Token = "0x170005CD")]
	public bool CheckNpcSaveParameters
	{
		[Token(Token = "0x6002C4F")]
		[Address(RVA = "0x2589260", Offset = "0x2589361", VA = "0x2589260")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700076B RID: 1899
	// (get) Token: 0x06003542 RID: 13634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005CE")]
	public NpcSaveParameter NpcSaveParameters
	{
		[Token(Token = "0x6002C50")]
		[Address(RVA = "0x25884F0", Offset = "0x25885F1", VA = "0x25884F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x06003543 RID: 13635 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003544 RID: 13636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005CF")]
	public List<LovePointManager.FavoriteType> PresentItemTypes
	{
		[Token(Token = "0x6002C51")]
		[Address(RVA = "0x2589320", Offset = "0x2589421", VA = "0x2589320")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002C52")]
		[Address(RVA = "0x2589340", Offset = "0x2589441", VA = "0x2589340")]
		set
		{
		}
	}

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x06003545 RID: 13637 RVA: 0x000123A8 File Offset: 0x000105A8
	// (set) Token: 0x06003546 RID: 13638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D0")]
	public bool IsPartner
	{
		[Token(Token = "0x6002C53")]
		[Address(RVA = "0x2589370", Offset = "0x2589471", VA = "0x2589370")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C54")]
		[Address(RVA = "0x2589390", Offset = "0x2589491", VA = "0x2589390")]
		set
		{
		}
	}

	// Token: 0x1700076E RID: 1902
	// (get) Token: 0x06003547 RID: 13639 RVA: 0x000123C0 File Offset: 0x000105C0
	// (set) Token: 0x06003548 RID: 13640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D1")]
	public bool IsSpouses
	{
		[Token(Token = "0x6002C55")]
		[Address(RVA = "0x25893C0", Offset = "0x25894C1", VA = "0x25893C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C56")]
		[Address(RVA = "0x25893E0", Offset = "0x25894E1", VA = "0x25893E0")]
		set
		{
		}
	}

	// Token: 0x1700076F RID: 1903
	// (get) Token: 0x06003549 RID: 13641 RVA: 0x000123D8 File Offset: 0x000105D8
	// (set) Token: 0x0600354A RID: 13642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D2")]
	public bool IsLover
	{
		[Token(Token = "0x6002C57")]
		[Address(RVA = "0x2589410", Offset = "0x2589511", VA = "0x2589410")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C58")]
		[Address(RVA = "0x2589430", Offset = "0x2589531", VA = "0x2589430")]
		set
		{
		}
	}

	// Token: 0x17000770 RID: 1904
	// (get) Token: 0x0600354B RID: 13643 RVA: 0x000123F0 File Offset: 0x000105F0
	// (set) Token: 0x0600354C RID: 13644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D3")]
	public bool IsRefused
	{
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x2589460", Offset = "0x2589561", VA = "0x2589460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x2589480", Offset = "0x2589581", VA = "0x2589480")]
		set
		{
		}
	}

	// Token: 0x17000771 RID: 1905
	// (get) Token: 0x0600354D RID: 13645 RVA: 0x00012408 File Offset: 0x00010608
	// (set) Token: 0x0600354E RID: 13646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D4")]
	public bool IsJealousy
	{
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x25894B0", Offset = "0x25895B1", VA = "0x25894B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C5C")]
		[Address(RVA = "0x25894D0", Offset = "0x25895D1", VA = "0x25894D0")]
		set
		{
		}
	}

	// Token: 0x17000772 RID: 1906
	// (get) Token: 0x0600354F RID: 13647 RVA: 0x00012420 File Offset: 0x00010620
	// (set) Token: 0x06003550 RID: 13648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D5")]
	public bool IsDateRefrain
	{
		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0x2589500", Offset = "0x2589601", VA = "0x2589500")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0x2589520", Offset = "0x2589621", VA = "0x2589520")]
		set
		{
		}
	}

	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x06003551 RID: 13649 RVA: 0x00012438 File Offset: 0x00010638
	// (set) Token: 0x06003552 RID: 13650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D6")]
	public bool IsExclamation
	{
		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0x2589550", Offset = "0x2589651", VA = "0x2589550")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C60")]
		[Address(RVA = "0x2589570", Offset = "0x2589671", VA = "0x2589570")]
		set
		{
		}
	}

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x06003553 RID: 13651 RVA: 0x00012450 File Offset: 0x00010650
	// (set) Token: 0x06003554 RID: 13652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D7")]
	public int AngryStep
	{
		[Token(Token = "0x6002C61")]
		[Address(RVA = "0x25895A0", Offset = "0x25896A1", VA = "0x25895A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C62")]
		[Address(RVA = "0x25895C0", Offset = "0x25896C1", VA = "0x25895C0")]
		set
		{
		}
	}

	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x06003555 RID: 13653 RVA: 0x00012468 File Offset: 0x00010668
	// (set) Token: 0x06003556 RID: 13654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D8")]
	public int LovePoint
	{
		[Token(Token = "0x6002C63")]
		[Address(RVA = "0x25895F0", Offset = "0x25896F1", VA = "0x25895F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C64")]
		[Address(RVA = "0x2589610", Offset = "0x2589711", VA = "0x2589610")]
		set
		{
		}
	}

	// Token: 0x17000776 RID: 1910
	// (get) Token: 0x06003557 RID: 13655 RVA: 0x00012480 File Offset: 0x00010680
	// (set) Token: 0x06003558 RID: 13656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005D9")]
	public int DatingNum
	{
		[Token(Token = "0x6002C65")]
		[Address(RVA = "0x2589640", Offset = "0x2589741", VA = "0x2589640")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C66")]
		[Address(RVA = "0x2589660", Offset = "0x2589761", VA = "0x2589660")]
		set
		{
		}
	}

	// Token: 0x17000777 RID: 1911
	// (get) Token: 0x06003559 RID: 13657 RVA: 0x00012498 File Offset: 0x00010698
	// (set) Token: 0x0600355A RID: 13658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DA")]
	public int PresentCount
	{
		[Token(Token = "0x6002C67")]
		[Address(RVA = "0x2589720", Offset = "0x2589821", VA = "0x2589720")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C68")]
		[Address(RVA = "0x2589740", Offset = "0x2589841", VA = "0x2589740")]
		set
		{
		}
	}

	// Token: 0x17000778 RID: 1912
	// (get) Token: 0x0600355B RID: 13659 RVA: 0x000124B0 File Offset: 0x000106B0
	// (set) Token: 0x0600355C RID: 13660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DB")]
	public int NickNameToPlayerId
	{
		[Token(Token = "0x6002C69")]
		[Address(RVA = "0x2589770", Offset = "0x2589871", VA = "0x2589770")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x2589790", Offset = "0x2589891", VA = "0x2589790")]
		set
		{
		}
	}

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x0600355D RID: 13661 RVA: 0x000124C8 File Offset: 0x000106C8
	// (set) Token: 0x0600355E RID: 13662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DC")]
	public int NickNameFromPlayerId
	{
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x25897C0", Offset = "0x25898C1", VA = "0x25897C0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x25897E0", Offset = "0x25898E1", VA = "0x25897E0")]
		set
		{
		}
	}

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x0600355F RID: 13663 RVA: 0x000124E0 File Offset: 0x000106E0
	// (set) Token: 0x06003560 RID: 13664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DD")]
	public int WeddingAnniversary
	{
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x2589810", Offset = "0x2589911", VA = "0x2589810")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x2589830", Offset = "0x2589931", VA = "0x2589830")]
		set
		{
		}
	}

	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x06003561 RID: 13665 RVA: 0x000124F8 File Offset: 0x000106F8
	// (set) Token: 0x06003562 RID: 13666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DE")]
	public bool IsVoiceSleepPlayed
	{
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x2589860", Offset = "0x2589961", VA = "0x2589860")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x2589880", Offset = "0x2589981", VA = "0x2589880")]
		set
		{
		}
	}

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x06003563 RID: 13667 RVA: 0x00012510 File Offset: 0x00010710
	// (set) Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005DF")]
	public bool IsVoiceGreeted
	{
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x25898B0", Offset = "0x25899B1", VA = "0x25898B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x25898D0", Offset = "0x25899D1", VA = "0x25898D0")]
		set
		{
		}
	}

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x06003565 RID: 13669 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003566 RID: 13670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E0")]
	public long[] TalkedTime
	{
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x2589900", Offset = "0x2589A01", VA = "0x2589900")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x2589920", Offset = "0x2589A21", VA = "0x2589920")]
		set
		{
		}
	}

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x06003567 RID: 13671 RVA: 0x00012528 File Offset: 0x00010728
	// (set) Token: 0x06003568 RID: 13672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E1")]
	public int FriendlyMilestoneTalk
	{
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x2589950", Offset = "0x2589A51", VA = "0x2589950")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x2589970", Offset = "0x2589A71", VA = "0x2589970")]
		set
		{
		}
	}

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x06003569 RID: 13673 RVA: 0x00012540 File Offset: 0x00010740
	// (set) Token: 0x0600356A RID: 13674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E2")]
	public int ChatTalkLv
	{
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x25899A0", Offset = "0x2589AA1", VA = "0x25899A0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x25899C0", Offset = "0x2589AC1", VA = "0x25899C0")]
		set
		{
		}
	}

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x0600356B RID: 13675 RVA: 0x00012558 File Offset: 0x00010758
	// (set) Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E3")]
	public int ChatTalkCount
	{
		[Token(Token = "0x6002C79")]
		[Address(RVA = "0x25899F0", Offset = "0x2589AF1", VA = "0x25899F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x2589A10", Offset = "0x2589B11", VA = "0x2589A10")]
		set
		{
		}
	}

	// Token: 0x17000781 RID: 1921
	// (get) Token: 0x0600356D RID: 13677 RVA: 0x00012570 File Offset: 0x00010770
	// (set) Token: 0x0600356E RID: 13678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E4")]
	public int ChatTalkLotteryType
	{
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x2589A40", Offset = "0x2589B41", VA = "0x2589A40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x2589A60", Offset = "0x2589B61", VA = "0x2589A60")]
		set
		{
		}
	}

	// Token: 0x17000782 RID: 1922
	// (get) Token: 0x0600356F RID: 13679 RVA: 0x00012588 File Offset: 0x00010788
	// (set) Token: 0x06003570 RID: 13680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E5")]
	public int ChatTalkLotteryID
	{
		[Token(Token = "0x6002C7D")]
		[Address(RVA = "0x2589A90", Offset = "0x2589B91", VA = "0x2589A90")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C7E")]
		[Address(RVA = "0x2589AB0", Offset = "0x2589BB1", VA = "0x2589AB0")]
		set
		{
		}
	}

	// Token: 0x17000783 RID: 1923
	// (get) Token: 0x06003571 RID: 13681 RVA: 0x000125A0 File Offset: 0x000107A0
	// (set) Token: 0x06003572 RID: 13682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E6")]
	public int HomeTalkedLv
	{
		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x2589AE0", Offset = "0x2589BE1", VA = "0x2589AE0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C80")]
		[Address(RVA = "0x2589B00", Offset = "0x2589C01", VA = "0x2589B00")]
		set
		{
		}
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x06003573 RID: 13683 RVA: 0x000125B8 File Offset: 0x000107B8
	// (set) Token: 0x06003574 RID: 13684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005E7")]
	public int LoveStroyState
	{
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x2589B30", Offset = "0x2589C31", VA = "0x2589B30")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x2589B50", Offset = "0x2589C51", VA = "0x2589B50")]
		set
		{
		}
	}

	// Token: 0x06003575 RID: 13685 RVA: 0x000125D0 File Offset: 0x000107D0
	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x2589B80", Offset = "0x2589C81", VA = "0x2589B80")]
	private bool IsTalked(TimeManager.RFTimeInt talkTime)
	{
		return default(bool);
	}

	// Token: 0x06003576 RID: 13686 RVA: 0x000125E8 File Offset: 0x000107E8
	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x2589CB0", Offset = "0x2589DB1", VA = "0x2589CB0")]
	private bool IsTodayTalked(TimeManager.RFTimeInt talkTime)
	{
		return default(bool);
	}

	// Token: 0x06003577 RID: 13687 RVA: 0x00012600 File Offset: 0x00010800
	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x2589D40", Offset = "0x2589E41", VA = "0x2589D40")]
	public bool IsLongtimeTalk()
	{
		return default(bool);
	}

	// Token: 0x06003578 RID: 13688 RVA: 0x00012618 File Offset: 0x00010818
	[Token(Token = "0x6002C86")]
	[Address(RVA = "0x2589E50", Offset = "0x2589F51", VA = "0x2589E50")]
	public bool IsTalked(NpcTalkedType type)
	{
		return default(bool);
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x00012630 File Offset: 0x00010830
	[Token(Token = "0x6002C87")]
	[Address(RVA = "0x2589EA0", Offset = "0x2589FA1", VA = "0x2589EA0")]
	public bool IsTodayTalked(NpcTalkedType type)
	{
		return default(bool);
	}

	// Token: 0x0600357A RID: 13690 RVA: 0x00012648 File Offset: 0x00010848
	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x2589F60", Offset = "0x258A061", VA = "0x2589F60")]
	public bool IsTalkedOne(NpcTalkedType type)
	{
		return default(bool);
	}

	// Token: 0x0600357B RID: 13691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x2589FC0", Offset = "0x258A0C1", VA = "0x2589FC0")]
	public void SetTalkedTime(NpcTalkedType type, TimeManager.RFTimeInt timeInt)
	{
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x0600357C RID: 13692 RVA: 0x00012660 File Offset: 0x00010860
	[Token(Token = "0x170005E8")]
	public bool IsWeddingAnniversary
	{
		[Token(Token = "0x6002C8A")]
		[Address(RVA = "0x258A020", Offset = "0x258A121", VA = "0x258A020")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x0600357D RID: 13693 RVA: 0x00012678 File Offset: 0x00010878
	[Token(Token = "0x170005E9")]
	public bool IsShopOpend
	{
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x258A110", Offset = "0x258A211", VA = "0x258A110")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000787 RID: 1927
	// (get) Token: 0x0600357E RID: 13694 RVA: 0x00012690 File Offset: 0x00010890
	[Token(Token = "0x170005EA")]
	public bool IsMob
	{
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x258A450", Offset = "0x258A551", VA = "0x258A450")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000788 RID: 1928
	// (get) Token: 0x0600357F RID: 13695 RVA: 0x000126A8 File Offset: 0x000108A8
	[Token(Token = "0x170005EB")]
	public bool IsHomeBack
	{
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x258A460", Offset = "0x258A561", VA = "0x258A460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000789 RID: 1929
	// (get) Token: 0x06003580 RID: 13696 RVA: 0x000126C0 File Offset: 0x000108C0
	[Token(Token = "0x170005EC")]
	public bool IsAlreadySleep
	{
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x258A470", Offset = "0x258A571", VA = "0x258A470")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700078A RID: 1930
	// (get) Token: 0x06003581 RID: 13697 RVA: 0x000126D8 File Offset: 0x000108D8
	[Token(Token = "0x170005ED")]
	public HairType HairType
	{
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x258A4B0", Offset = "0x258A5B1", VA = "0x258A4B0")]
		get
		{
			return HairType.HAIR00_00;
		}
	}

	// Token: 0x1700078B RID: 1931
	// (get) Token: 0x06003582 RID: 13698 RVA: 0x000126F0 File Offset: 0x000108F0
	[Token(Token = "0x170005EE")]
	public bool IconEnabled
	{
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x258A870", Offset = "0x258A971", VA = "0x258A870")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700078C RID: 1932
	// (get) Token: 0x06003583 RID: 13699 RVA: 0x00012708 File Offset: 0x00010908
	[Token(Token = "0x170005EF")]
	public bool IsExsitNpc
	{
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x258AAE0", Offset = "0x258ABE1", VA = "0x258AAE0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x06003584 RID: 13700 RVA: 0x00012720 File Offset: 0x00010920
	[Token(Token = "0x170005F0")]
	public bool IsOuting
	{
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x258AA50", Offset = "0x258AB51", VA = "0x258AA50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700078E RID: 1934
	// (get) Token: 0x06003585 RID: 13701 RVA: 0x00012738 File Offset: 0x00010938
	[Token(Token = "0x170005F1")]
	public bool IsInHospital
	{
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x258AC00", Offset = "0x258AD01", VA = "0x258AC00")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06003586 RID: 13702 RVA: 0x00012750 File Offset: 0x00010950
	[Token(Token = "0x6002C94")]
	[Address(RVA = "0x258AC90", Offset = "0x258AD91", VA = "0x258AC90")]
	public bool CanTalkEndRotation()
	{
		return default(bool);
	}

	// Token: 0x06003587 RID: 13703 RVA: 0x00012768 File Offset: 0x00010968
	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x258AE80", Offset = "0x258AF81", VA = "0x258AE80")]
	public bool CheckAnimationStateTurnAround()
	{
		return default(bool);
	}

	// Token: 0x06003588 RID: 13704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x258AEE0", Offset = "0x258AFE1", VA = "0x258AEE0")]
	public Actor CreateActor()
	{
		return null;
	}

	// Token: 0x06003589 RID: 13705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C97")]
	[Address(RVA = "0x258AF90", Offset = "0x258B091", VA = "0x258AF90")]
	public void DeleteNpc()
	{
	}

	// Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C98")]
	[Address(RVA = "0x258B370", Offset = "0x258B471", VA = "0x258B370")]
	public void ResetDateAction()
	{
	}

	// Token: 0x0600358B RID: 13707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C99")]
	[Address(RVA = "0x258B470", Offset = "0x258B571", VA = "0x258B470")]
	public void ResetAction()
	{
	}

	// Token: 0x0600358C RID: 13708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x258B5F0", Offset = "0x258B6F1", VA = "0x258B5F0")]
	public void SetStandbyPositionRotation(Transform srcTrans)
	{
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x258B650", Offset = "0x258B751", VA = "0x258B650")]
	public void SetStandbyAnimationState()
	{
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x258B680", Offset = "0x258B781", VA = "0x258B680")]
	public void SaveNpcPositionData()
	{
	}

	// Token: 0x0600358F RID: 13711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x258B820", Offset = "0x258B921", VA = "0x258B820")]
	public void BeforeSaveNpcData()
	{
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x258B8A0", Offset = "0x258B9A1", VA = "0x258B8A0")]
	public void AfterLoadNpcData()
	{
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002C9F")]
	[Address(RVA = "0x258B920", Offset = "0x258BA21", VA = "0x258B920")]
	public void SetRotatePointForUpdateSimulatePosition(GameObject npcPatrolPoints)
	{
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA0")]
	[Address(RVA = "0x258BC40", Offset = "0x258BD41", VA = "0x258BC40")]
	public void SetLifedycleForUpdateSimulatePosition()
	{
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA1")]
	[Address(RVA = "0x258D020", Offset = "0x258D121", VA = "0x258D020")]
	public void InitializeForLifeCycle(GameObject npcDataGameObject)
	{
	}

	// Token: 0x06003594 RID: 13716 RVA: 0x00012780 File Offset: 0x00010980
	[Token(Token = "0x6002CA2")]
	[Address(RVA = "0x258D250", Offset = "0x258D351", VA = "0x258D250")]
	private bool IsRotateWalk()
	{
		return default(bool);
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA3")]
	[Address(RVA = "0x258D280", Offset = "0x258D381", VA = "0x258D280")]
	public void RemoveResources()
	{
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA4")]
	[Address(RVA = "0x258D2A0", Offset = "0x258D3A1", VA = "0x258D2A0")]
	public void FadeInStandby()
	{
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA5")]
	[Address(RVA = "0x258D350", Offset = "0x258D451", VA = "0x258D350")]
	public void SetFadeState(NpcFadeState _fadeState)
	{
	}

	// Token: 0x06003598 RID: 13720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CA6")]
	[Address(RVA = "0x258D360", Offset = "0x258D461", VA = "0x258D360")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5540", Offset = "0x1A5641")]
	public IEnumerator FadeInOutNpc([Optional] UnityAction _fadeEndAction)
	{
		return null;
	}

	// Token: 0x06003599 RID: 13721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA7")]
	[Address(RVA = "0x258D430", Offset = "0x258D531", VA = "0x258D430")]
	public void RefreshNpcFadeIn()
	{
	}

	// Token: 0x0600359A RID: 13722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA8")]
	[Address(RVA = "0x258D500", Offset = "0x258D601", VA = "0x258D500")]
	public void ForceNpcFadeIn()
	{
	}

	// Token: 0x0600359B RID: 13723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CA9")]
	[Address(RVA = "0x258D510", Offset = "0x258D611", VA = "0x258D510")]
	public void UpdateMoveSpeed()
	{
	}

	// Token: 0x0600359C RID: 13724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CAA")]
	[Address(RVA = "0x258D6D0", Offset = "0x258D7D1", VA = "0x258D6D0")]
	public void CalcMoveSpeed()
	{
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x00012798 File Offset: 0x00010998
	[Token(Token = "0x6002CAB")]
	[Address(RVA = "0x258DBF0", Offset = "0x258DCF1", VA = "0x258DBF0")]
	public bool CheckObjectEnabled()
	{
		return default(bool);
	}

	// Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CAC")]
	[Address(RVA = "0x258E160", Offset = "0x258E261", VA = "0x258E160")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A55B0", Offset = "0x1A56B1")]
	public IEnumerator WalkStop(float waitMinutes, int targetNpcId, bool firstMotion)
	{
		return null;
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CAD")]
	[Address(RVA = "0x258E240", Offset = "0x258E341", VA = "0x258E240")]
	public void SlowDown(float waitMinutes)
	{
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CAE")]
	[Address(RVA = "0x258E2E0", Offset = "0x258E3E1", VA = "0x258E2E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5620", Offset = "0x1A5721")]
	public IEnumerator SlowDownStart(float waitMinutes)
	{
		return null;
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CAF")]
	[Address(RVA = "0x258E3A0", Offset = "0x258E4A1", VA = "0x258E3A0")]
	public void SlowDownStart(ActorController character)
	{
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CB0")]
	[Address(RVA = "0x258E720", Offset = "0x258E821", VA = "0x258E720")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5690", Offset = "0x1A5791")]
	public IEnumerator SlowDownEndStart()
	{
		return null;
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0x258E7D0", Offset = "0x258E8D1", VA = "0x258E7D0")]
	public void SlowDownEnd()
	{
	}

	// Token: 0x060035A4 RID: 13732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB2")]
	[Address(RVA = "0x258E960", Offset = "0x258EA61", VA = "0x258E960")]
	public void Update()
	{
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB3")]
	[Address(RVA = "0x258F1B0", Offset = "0x258F2B1", VA = "0x258F1B0")]
	public void SetNextState(LifecycleState nextState)
	{
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x000127B0 File Offset: 0x000109B0
	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0x258ECB0", Offset = "0x258EDB1", VA = "0x258ECB0")]
	private bool ValidateTransition()
	{
		return default(bool);
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB5")]
	[Address(RVA = "0x258EFD0", Offset = "0x258F0D1", VA = "0x258EFD0")]
	private void OnStateExit()
	{
	}

	// Token: 0x060035A8 RID: 13736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB6")]
	[Address(RVA = "0x258EFF0", Offset = "0x258F0F1", VA = "0x258EFF0")]
	private void OnStateEnter()
	{
	}

	// Token: 0x060035A9 RID: 13737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0x258F1E0", Offset = "0x258F2E1", VA = "0x258F1E0")]
	private void OnEnterMove()
	{
	}

	// Token: 0x060035AA RID: 13738 RVA: 0x000127C8 File Offset: 0x000109C8
	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0x258F720", Offset = "0x258F821", VA = "0x258F720")]
	private bool isSwimWearPlace(Place place)
	{
		return default(bool);
	}

	// Token: 0x060035AB RID: 13739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0x258F250", Offset = "0x258F351", VA = "0x258F250")]
	private void OnEnterReach()
	{
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0x258F1C0", Offset = "0x258F2C1", VA = "0x258F1C0")]
	private void OnExitMove()
	{
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0x258F1D0", Offset = "0x258F2D1", VA = "0x258F1D0")]
	private void OnExitReach()
	{
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0x258F300", Offset = "0x258F401", VA = "0x258F300")]
	private void StandUpAction()
	{
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0x2590D20", Offset = "0x2590E21", VA = "0x2590D20")]
	private void CheckNpcHurry(bool IsDoorOut = false)
	{
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x000127E0 File Offset: 0x000109E0
	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x2590160", Offset = "0x2590261", VA = "0x2590160")]
	private LifecycleState GetMovingLifeCycle(LifecycleState lifecycleState)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060035B1 RID: 13745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x2590FF0", Offset = "0x25910F1", VA = "0x2590FF0")]
	public void StandupFadeOutEnd()
	{
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x25910D0", Offset = "0x25911D1", VA = "0x25910D0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5700", Offset = "0x1A5801")]
	private IEnumerator StandupFadeIn()
	{
		return null;
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0x258AFA0", Offset = "0x258B0A1", VA = "0x258AFA0")]
	public void ItemClear()
	{
	}

	// Token: 0x060035B4 RID: 13748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC2")]
	[Address(RVA = "0x258F0A0", Offset = "0x258F1A1", VA = "0x258F0A0")]
	private void UpdateLifeCycle()
	{
	}

	// Token: 0x060035B5 RID: 13749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC3")]
	[Address(RVA = "0x258F770", Offset = "0x258F871", VA = "0x258F770")]
	public void InitAction()
	{
	}

	// Token: 0x060035B6 RID: 13750 RVA: 0x000127F8 File Offset: 0x000109F8
	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0x258D9C0", Offset = "0x258DAC1", VA = "0x258D9C0")]
	public bool CanMove()
	{
		return default(bool);
	}

	// Token: 0x060035B7 RID: 13751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0x25906B0", Offset = "0x25907B1", VA = "0x25906B0")]
	private void StartPoint()
	{
	}

	// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CC6")]
	[Address(RVA = "0x2591790", Offset = "0x2591891", VA = "0x2591790")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5770", Offset = "0x1A5871")]
	private IEnumerator OpenDoor()
	{
		return null;
	}

	// Token: 0x060035B9 RID: 13753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x258DB00", Offset = "0x258DC01", VA = "0x258DB00")]
	private void ResetMotionSpeed()
	{
	}

	// Token: 0x060035BA RID: 13754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0x2591840", Offset = "0x2591941", VA = "0x2591840")]
	private void ArrivePoint()
	{
	}

	// Token: 0x060035BB RID: 13755 RVA: 0x00012810 File Offset: 0x00010A10
	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0x2592700", Offset = "0x2592801", VA = "0x2592700")]
	public bool CheckHotelStairs()
	{
		return default(bool);
	}

	// Token: 0x060035BC RID: 13756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CCA")]
	[Address(RVA = "0x2590630", Offset = "0x2590731", VA = "0x2590630")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A57E0", Offset = "0x1A58E1")]
	private IEnumerator ArriveAction()
	{
		return null;
	}

	// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CCB")]
	[Address(RVA = "0x258BF00", Offset = "0x258C001", VA = "0x258BF00")]
	public void ChangeArriveState()
	{
	}

	// Token: 0x060035BE RID: 13758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CCC")]
	[Address(RVA = "0x2592B10", Offset = "0x2592C11", VA = "0x2592B10")]
	private void FadeOutEnd()
	{
	}

	// Token: 0x060035BF RID: 13759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CCD")]
	[Address(RVA = "0x258C990", Offset = "0x258CA91", VA = "0x258C990")]
	public void SetLookAtWithNpc()
	{
	}

	// Token: 0x060035C0 RID: 13760 RVA: 0x00012828 File Offset: 0x00010A28
	[Token(Token = "0x6002CCE")]
	[Address(RVA = "0x2590EF0", Offset = "0x2590FF1", VA = "0x2590EF0")]
	public bool CheckWeatherRain()
	{
		return default(bool);
	}

	// Token: 0x060035C1 RID: 13761 RVA: 0x00012840 File Offset: 0x00010A40
	[Token(Token = "0x6002CCF")]
	[Address(RVA = "0x2593650", Offset = "0x2593751", VA = "0x2593650")]
	public bool CheckWeatherSunny()
	{
		return default(bool);
	}

	// Token: 0x060035C2 RID: 13762 RVA: 0x00012858 File Offset: 0x00010A58
	[Token(Token = "0x6002CD0")]
	[Address(RVA = "0x25936C0", Offset = "0x25937C1", VA = "0x25936C0")]
	public bool CheckWeatherSnow()
	{
		return default(bool);
	}

	// Token: 0x060035C3 RID: 13763 RVA: 0x00012870 File Offset: 0x00010A70
	[Token(Token = "0x6002CD1")]
	[Address(RVA = "0x2590F60", Offset = "0x2591061", VA = "0x2590F60")]
	public bool CheckWeatherTyphoon()
	{
		return default(bool);
	}

	// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x2591180", Offset = "0x2591281", VA = "0x2591180")]
	private void UpdateMoveAction()
	{
	}

	// Token: 0x060035C5 RID: 13765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x25912E0", Offset = "0x25913E1", VA = "0x25912E0")]
	private void UpdateReachAction()
	{
	}

	// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x258FF30", Offset = "0x2590031", VA = "0x258FF30")]
	private void CheckReachPoint()
	{
	}

	// Token: 0x060035C7 RID: 13767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x258EDB0", Offset = "0x258EEB1", VA = "0x258EDB0")]
	private void ShiftNextSimulateState()
	{
	}

	// Token: 0x060035C8 RID: 13768 RVA: 0x00012888 File Offset: 0x00010A88
	[Token(Token = "0x6002CD6")]
	[Address(RVA = "0x258EB20", Offset = "0x258EC21", VA = "0x258EB20")]
	private LifecycleState GetNextSimulateState(int NpcId)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060035C9 RID: 13769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CD7")]
	[Address(RVA = "0x258F8D0", Offset = "0x258F9D1", VA = "0x258F8D0")]
	public NpcTimeAction GetCurrentTimeAction(int hour, int minutes)
	{
		return null;
	}

	// Token: 0x060035CA RID: 13770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CD8")]
	[Address(RVA = "0x2594500", Offset = "0x2594601", VA = "0x2594500")]
	public NpcTimeAction CreateLastTimeAction()
	{
		return null;
	}

	// Token: 0x060035CB RID: 13771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CD9")]
	[Address(RVA = "0x25947E0", Offset = "0x25948E1", VA = "0x25947E0")]
	public NpcTimeAction GetNextTimeAction(int hour, int minutes)
	{
		return null;
	}

	// Token: 0x060035CC RID: 13772 RVA: 0x000128A0 File Offset: 0x00010AA0
	[Token(Token = "0x6002CDA")]
	[Address(RVA = "0x2594930", Offset = "0x2594A31", VA = "0x2594930")]
	public int GetPrevTime(int hour, int minutes)
	{
		return 0;
	}

	// Token: 0x060035CD RID: 13773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CDB")]
	[Address(RVA = "0x2594AD0", Offset = "0x2594BD1", VA = "0x2594AD0")]
	public NpcTimeAction CreateUnscheduledTimeAction(int hour, int minutes, Weather weather)
	{
		return null;
	}

	// Token: 0x060035CE RID: 13774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CDC")]
	[Address(RVA = "0x258FC30", Offset = "0x258FD31", VA = "0x258FC30")]
	public NpcTimeAction GetUnscheduledCurrentTimeAction(int hour, int minutes)
	{
		return null;
	}

	// Token: 0x060035CF RID: 13775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CDD")]
	[Address(RVA = "0x2593730", Offset = "0x2593831", VA = "0x2593730")]
	private void UpdateLifeCycleMoving()
	{
	}

	// Token: 0x060035D0 RID: 13776 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x2593D10", Offset = "0x2593E11", VA = "0x2593D10")]
	private void UpdateAvoidConflict()
	{
	}

	// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x258C2D0", Offset = "0x258C3D1", VA = "0x258C2D0")]
	public void SetSeatRotation()
	{
	}

	// Token: 0x060035D2 RID: 13778 RVA: 0x000128B8 File Offset: 0x00010AB8
	[Token(Token = "0x6002CE0")]
	[Address(RVA = "0x2595A70", Offset = "0x2595B71", VA = "0x2595A70")]
	public Place WakeUpAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D3 RID: 13779 RVA: 0x000128D0 File Offset: 0x00010AD0
	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x2595C20", Offset = "0x2595D21", VA = "0x2595C20")]
	public Place EatAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x000128E8 File Offset: 0x00010AE8
	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x2595F20", Offset = "0x2596021", VA = "0x2595F20")]
	public Place WorkingAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D5 RID: 13781 RVA: 0x00012900 File Offset: 0x00010B00
	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x2596090", Offset = "0x2596191", VA = "0x2596090")]
	public Place BathTimeAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D6 RID: 13782 RVA: 0x00012918 File Offset: 0x00010B18
	[Token(Token = "0x6002CE4")]
	[Address(RVA = "0x25962F0", Offset = "0x25963F1", VA = "0x25962F0")]
	public Place FreeTimeAction(int EventId, int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D7 RID: 13783 RVA: 0x00012930 File Offset: 0x00010B30
	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x2596690", Offset = "0x2596791", VA = "0x2596690")]
	public Place HomeTimeAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D8 RID: 13784 RVA: 0x00012948 File Offset: 0x00010B48
	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x2596750", Offset = "0x2596851", VA = "0x2596750")]
	public Place SleepAction(int hour, int minutes)
	{
		return Place.Field;
	}

	// Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x25954C0", Offset = "0x25955C1", VA = "0x25954C0")]
	public NpcPatrolPoint GetBathPoint()
	{
		return null;
	}

	// Token: 0x060035DA RID: 13786 RVA: 0x00012960 File Offset: 0x00010B60
	[Token(Token = "0x6002CE8")]
	[Address(RVA = "0x25968F0", Offset = "0x25969F1", VA = "0x25968F0")]
	public bool DecideSimulateTargetRoute()
	{
		return default(bool);
	}

	// Token: 0x060035DB RID: 13787 RVA: 0x00012978 File Offset: 0x00010B78
	[Token(Token = "0x6002CE9")]
	[Address(RVA = "0x25901D0", Offset = "0x25902D1", VA = "0x25901D0")]
	public bool DecideTargetRoute()
	{
		return default(bool);
	}

	// Token: 0x060035DC RID: 13788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CEA")]
	[Address(RVA = "0x2591500", Offset = "0x2591601", VA = "0x2591500")]
	public string GetTargetPointName(string TargetSeatName)
	{
		return null;
	}

	// Token: 0x060035DD RID: 13789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CEB")]
	[Address(RVA = "0x2592610", Offset = "0x2592711", VA = "0x2592610")]
	public NpcPatrolPoint GetTargetPoint()
	{
		return null;
	}

	// Token: 0x060035DE RID: 13790 RVA: 0x00012990 File Offset: 0x00010B90
	[Token(Token = "0x6002CEC")]
	[Address(RVA = "0x258BE00", Offset = "0x258BF01", VA = "0x258BE00")]
	public LifecycleState GetNextState(int hour, int minutes)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060035DF RID: 13791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CED")]
	[Address(RVA = "0x2596D70", Offset = "0x2596E71", VA = "0x2596D70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5850", Offset = "0x1A5951")]
	public IEnumerator TyphoonAction()
	{
		return null;
	}

	// Token: 0x060035E0 RID: 13792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x2593E00", Offset = "0x2593F01", VA = "0x2593E00")]
	public void CheckWeatherAction(HomeBackType homeBackType)
	{
	}

	// Token: 0x060035E1 RID: 13793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CEF")]
	[Address(RVA = "0x2596E20", Offset = "0x2596F21", VA = "0x2596E20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A58C0", Offset = "0x1A59C1")]
	private IEnumerator RainBackWaitAction(HomeBackType homeBackType)
	{
		return null;
	}

	// Token: 0x060035E2 RID: 13794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x2596EE0", Offset = "0x2596FE1", VA = "0x2596EE0")]
	public void RainBackAction(HomeBackType homeBackType)
	{
	}

	// Token: 0x060035E3 RID: 13795 RVA: 0x000129A8 File Offset: 0x00010BA8
	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x25922F0", Offset = "0x25923F1", VA = "0x25922F0")]
	private bool SwitchNextPatrolPointForRotate()
	{
		return default(bool);
	}

	// Token: 0x060035E4 RID: 13796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x2597050", Offset = "0x2597151", VA = "0x2597050")]
	private string[] ChangeRouteToNextTargetPoint(NpcTimeAction NpcTimeAction)
	{
		return null;
	}

	// Token: 0x060035E5 RID: 13797 RVA: 0x000129C0 File Offset: 0x00010BC0
	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x25974A0", Offset = "0x25975A1", VA = "0x25974A0")]
	public int GetCurrentStateRemainingTime(int hour, int minutes)
	{
		return 0;
	}

	// Token: 0x060035E6 RID: 13798 RVA: 0x000129D8 File Offset: 0x00010BD8
	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x25974B0", Offset = "0x25975B1", VA = "0x25974B0")]
	public LifecycleState GetCurrentState(int hour, int minutes)
	{
		return LifecycleState.NONE;
	}

	// Token: 0x060035E7 RID: 13799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x25974C0", Offset = "0x25975C1", VA = "0x25974C0")]
	public void SetStartPoint()
	{
	}

	// Token: 0x060035E8 RID: 13800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x258FA40", Offset = "0x258FB41", VA = "0x258FA40")]
	public void SetCurrentTimeAction(NpcTimeAction npcCurrentTimeAction)
	{
	}

	// Token: 0x060035E9 RID: 13801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x2597AE0", Offset = "0x2597BE1", VA = "0x2597AE0")]
	public void releasePoint()
	{
	}

	// Token: 0x060035EA RID: 13802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x2597DA0", Offset = "0x2597EA1", VA = "0x2597DA0")]
	public void WakeupParamSetting()
	{
	}

	// Token: 0x060035EB RID: 13803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x258DBD0", Offset = "0x258DCD1", VA = "0x258DBD0")]
	public void NavMeshStop(bool stop)
	{
	}

	// Token: 0x060035EC RID: 13804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x2598040", Offset = "0x2598141", VA = "0x2598040")]
	public void NavMeshIdle()
	{
	}

	// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x258DA90", Offset = "0x258DB91", VA = "0x258DA90")]
	public void NavMeshSetDestination(Vector3 position)
	{
	}

	// Token: 0x060035EE RID: 13806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x25916D0", Offset = "0x25917D1", VA = "0x25916D0")]
	public void SetTargetPosition(Vector3 position)
	{
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x2595620", Offset = "0x2595721", VA = "0x2595620")]
	public void MoveNavTarget()
	{
	}

	// Token: 0x060035F0 RID: 13808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x2595710", Offset = "0x2595811", VA = "0x2595710")]
	public void MovePatrolPoint(NpcController npc)
	{
	}

	// Token: 0x060035F1 RID: 13809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x25980C0", Offset = "0x25981C1", VA = "0x25980C0")]
	public void SetOutdoorNavTarget()
	{
	}

	// Token: 0x060035F2 RID: 13810 RVA: 0x000129F0 File Offset: 0x00010BF0
	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x25986D0", Offset = "0x25987D1", VA = "0x25986D0")]
	public float DistanceXZ(Vector3 src, Vector3 dst)
	{
		return 0f;
	}

	// Token: 0x060035F3 RID: 13811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x2598780", Offset = "0x2598881", VA = "0x2598780")]
	public void ChatTalked(int r)
	{
	}

	// Token: 0x060035F4 RID: 13812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x2598850", Offset = "0x2598951", VA = "0x2598850")]
	public void ChatTalkLvUp()
	{
	}

	// Token: 0x060035F5 RID: 13813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x2598890", Offset = "0x2598991", VA = "0x2598890")]
	public void SetChatTalkLv(int lv, bool force = false)
	{
	}

	// Token: 0x060035F6 RID: 13814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x2597F70", Offset = "0x2598071", VA = "0x2597F70")]
	public void ChatTalkLottery()
	{
	}

	// Token: 0x060035F7 RID: 13815 RVA: 0x00012A08 File Offset: 0x00010C08
	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x2598940", Offset = "0x2598A41", VA = "0x2598940")]
	private bool CheckChatTalkLv(int lv, int randnum)
	{
		return default(bool);
	}

	// Token: 0x060035F8 RID: 13816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x2598B10", Offset = "0x2598C11", VA = "0x2598B10")]
	public void UpdateTalking(float deltaTime)
	{
	}

	// Token: 0x060035F9 RID: 13817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x2598BF0", Offset = "0x2598CF1", VA = "0x2598BF0")]
	public void ChangeModel(int modelType, bool isSpc = false)
	{
	}

	// Token: 0x060035FA RID: 13818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x2597C80", Offset = "0x2597D81", VA = "0x2597C80")]
	public void SetCurrentPlaceId(FieldPlaceId FieldPlaceId)
	{
	}

	// Token: 0x060035FB RID: 13819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x2598F60", Offset = "0x2599061", VA = "0x2598F60")]
	public void AnimationIdle()
	{
	}

	// Token: 0x060035FC RID: 13820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x2598F70", Offset = "0x2599071", VA = "0x2598F70")]
	public void AnimationForceIdle()
	{
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x2599080", Offset = "0x2599181", VA = "0x2599080")]
	public void AnimIdxIdle()
	{
	}

	// Token: 0x060035FE RID: 13822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x25952F0", Offset = "0x25953F1", VA = "0x25952F0")]
	public NpcLifeCycleTimeData GetNpcLifeCycleTimeData(int hour, int minutes, Weather weather = Weather.None)
	{
		return null;
	}

	// Token: 0x060035FF RID: 13823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x258CC10", Offset = "0x258CD11", VA = "0x258CC10")]
	public NpcLifeCycleTime GetCurrentTimeList(int hour, int minutes)
	{
		return null;
	}

	// Token: 0x06003600 RID: 13824 RVA: 0x00012A20 File Offset: 0x00010C20
	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x25953F0", Offset = "0x25954F1", VA = "0x25953F0")]
	public Place ConvertPlaceTag(Place TargetPlace)
	{
		return Place.Field;
	}

	// Token: 0x06003601 RID: 13825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x2599140", Offset = "0x2599241", VA = "0x2599140")]
	public void PlayLoopAction()
	{
	}

	// Token: 0x06003602 RID: 13826 RVA: 0x00012A38 File Offset: 0x00010C38
	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x2592B70", Offset = "0x2592C71", VA = "0x2592B70")]
	public bool PlayLifecycleScript(bool IsStartScript)
	{
		return default(bool);
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x2599150", Offset = "0x2599251", VA = "0x2599150")]
	public void ItemClearAction(bool motionReset = true)
	{
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D12")]
	[Address(RVA = "0x2599430", Offset = "0x2599531", VA = "0x2599430")]
	public void DoPartner([Optional] Action<PartnerNPCBehaviorController> callBack)
	{
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D13")]
	[Address(RVA = "0x2599620", Offset = "0x2599721", VA = "0x2599620")]
	public void ReleasePartner([Optional] Action<NpcController> callBack)
	{
	}

	// Token: 0x06003606 RID: 13830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x25997C0", Offset = "0x25998C1", VA = "0x25997C0")]
	public void ReleasePartnerNpc(ActorID actorId, [Optional] Action<NpcController> callBack)
	{
	}

	// Token: 0x06003607 RID: 13831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x25999D0", Offset = "0x2599AD1", VA = "0x25999D0")]
	public void ReleasePartnerByTime()
	{
	}

	// Token: 0x06003608 RID: 13832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x2599A30", Offset = "0x2599B31", VA = "0x2599A30")]
	private void CallAfterLeavePartner(NpcController npc, [Optional] UnityAction callBack)
	{
	}

	// Token: 0x06003609 RID: 13833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x2599AE0", Offset = "0x2599BE1", VA = "0x2599AE0")]
	public void DoBecomeLover()
	{
	}

	// Token: 0x0600360A RID: 13834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x2599B30", Offset = "0x2599C31", VA = "0x2599B30")]
	public void DoMarriage()
	{
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x2599DB0", Offset = "0x2599EB1", VA = "0x2599DB0")]
	public void SetAngryStep(int step = -1)
	{
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x2597EF0", Offset = "0x2597FF1", VA = "0x2597EF0")]
	private void WakeUpAngryStepProceed()
	{
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x00012A50 File Offset: 0x00010C50
	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x2599DF0", Offset = "0x2599EF1", VA = "0x2599DF0")]
	public bool IsAngry()
	{
		return default(bool);
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x00012A68 File Offset: 0x00010C68
	[Token(Token = "0x6002D1C")]
	[Address(RVA = "0x2599E20", Offset = "0x2599F21", VA = "0x2599E20")]
	public bool Isjealous()
	{
		return default(bool);
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x2592960", Offset = "0x2592A61", VA = "0x2592960")]
	public void SetLifeCycleTransfromPosition(Vector3 pos)
	{
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x2592A20", Offset = "0x2592B21", VA = "0x2592A20")]
	public void SetLifeCycleTransfromRotation(Quaternion rot)
	{
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x2599E40", Offset = "0x2599F41", VA = "0x2599E40")]
	public void ReserveFesDate(Define.Event eventId)
	{
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x259A230", Offset = "0x259A331", VA = "0x259A230")]
	public void ReserveLoveStoryDate(bool isKokuhaku, EventScriptID reserveScriptId, DateSpotID dateSpot, int dateTime)
	{
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x259A470", Offset = "0x259A571", VA = "0x259A470")]
	public void ReserveNomalDate(DateSpotID dateSpot)
	{
	}

	// Token: 0x06003614 RID: 13844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x259A0F0", Offset = "0x259A1F1", VA = "0x259A0F0")]
	private void ReserveDate(DateType dateType, DateSpotID dateSpot, int dateStartTime, int limitTime, GameFlagData flag, bool doSuupo)
	{
	}

	// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x259A550", Offset = "0x259A651", VA = "0x259A550")]
	public void AddFlowerFesDateNum()
	{
	}

	// Token: 0x06003616 RID: 13846 RVA: 0x00012A80 File Offset: 0x00010C80
	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x259A5F0", Offset = "0x259A6F1", VA = "0x259A5F0")]
	public bool IsDateStandby()
	{
		return default(bool);
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x259A620", Offset = "0x259A721", VA = "0x259A620")]
	public void ResetDateReserve()
	{
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D26")]
	[Address(RVA = "0x258CCA0", Offset = "0x258CDA1", VA = "0x258CCA0")]
	public void CheckWear()
	{
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x258F730", Offset = "0x258F831", VA = "0x258F730")]
	public void ChangeToNomalWear()
	{
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x00012A98 File Offset: 0x00010C98
	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x2598DA0", Offset = "0x2598EA1", VA = "0x2598DA0")]
	public VariationNo GetNormalWearVariationNo()
	{
		return VariationNo.VARIA_000;
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D29")]
	[Address(RVA = "0x258F760", Offset = "0x258F861", VA = "0x258F760")]
	public void ChangeToSwimWear()
	{
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x259A670", Offset = "0x259A771", VA = "0x259A670")]
	public void ChangeToPajama()
	{
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x259A680", Offset = "0x259A781", VA = "0x259A680")]
	private void ChangeWear(VariationNo targetVariationNo)
	{
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D2C")]
	[Address(RVA = "0x259A790", Offset = "0x259A891", VA = "0x259A790")]
	public void RotateLookAtTarget(global::Character character)
	{
	}

	// Token: 0x0600361F RID: 13855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D2D")]
	[Address(RVA = "0x259AC10", Offset = "0x259AD11", VA = "0x259AC10")]
	public void LookAtTarget()
	{
	}

	// Token: 0x06003620 RID: 13856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002D2E")]
	[Address(RVA = "0x259AD70", Offset = "0x259AE71", VA = "0x259AD70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5930", Offset = "0x1A5A31")]
	public IEnumerator LookAtTargetRotationEnd(bool IsTalkStart)
	{
		return null;
	}

	// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D2F")]
	[Address(RVA = "0x259AE00", Offset = "0x259AF01", VA = "0x259AE00")]
	public void TalkEnd(bool setIdle = true)
	{
	}

	// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x259AF90", Offset = "0x259B091", VA = "0x259AF90")]
	public void LookAtEnd()
	{
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x00012AB0 File Offset: 0x00010CB0
	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x25955D0", Offset = "0x25956D1", VA = "0x25955D0")]
	private bool HasArrived()
	{
		return default(bool);
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x259B2D0", Offset = "0x259B3D1", VA = "0x259B2D0")]
	private void SleepChangeEquip()
	{
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x259B600", Offset = "0x259B701", VA = "0x259B600")]
	public void HeadChangeModel()
	{
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x259B650", Offset = "0x259B751", VA = "0x259B650")]
	public NpcData()
	{
	}

	// Token: 0x040078E2 RID: 30946
	[Token(Token = "0x4006DA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AB90", Offset = "0x16AC91")]
	public ActorID actorId;

	// Token: 0x040078E3 RID: 30947
	[Token(Token = "0x4006DA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int NpcId;

	// Token: 0x040078E4 RID: 30948
	[Token(Token = "0x4006DA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 StandbyPosition;

	// Token: 0x040078E5 RID: 30949
	[Token(Token = "0x4006DA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Quaternion StandbyRotation;

	// Token: 0x040078E6 RID: 30950
	[Token(Token = "0x4006DA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public NpcAnimState StandbyAnimState;

	// Token: 0x040078E7 RID: 30951
	[Token(Token = "0x4006DA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16ABD0", Offset = "0x16ACD1")]
	public GameFlagData LifecycleStartFlag;

	// Token: 0x040078E8 RID: 30952
	[Token(Token = "0x4006DA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool ObjectEnabled;

	// Token: 0x040078E9 RID: 30953
	[Token(Token = "0x4006DA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool FadeDistance;

	// Token: 0x040078EA RID: 30954
	[Token(Token = "0x4006DAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[SerializeField]
	public bool _isShortPlay;

	// Token: 0x040078EB RID: 30955
	[Token(Token = "0x4006DAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool IsShortPlayMove;

	// Token: 0x040078EC RID: 30956
	[Token(Token = "0x4006DAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool Initialized;

	// Token: 0x040078ED RID: 30957
	[Token(Token = "0x4006DAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool InDoor;

	// Token: 0x040078EE RID: 30958
	[Token(Token = "0x4006DAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool _IsStop;

	// Token: 0x040078EF RID: 30959
	[Token(Token = "0x4006DAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	public bool _IsSlowDown;

	// Token: 0x040078F0 RID: 30960
	[Token(Token = "0x4006DB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AC20", Offset = "0x16AD21")]
	private bool IsMotion;

	// Token: 0x040078F1 RID: 30961
	[Token(Token = "0x4006DB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public NpcAnimState _AnimationState;

	// Token: 0x040078F2 RID: 30962
	[Token(Token = "0x4006DB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool IsSetAnimationState;

	// Token: 0x040078F3 RID: 30963
	[Token(Token = "0x4006DB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public NpcAnimState SpcAnimationState;

	// Token: 0x040078F4 RID: 30964
	[Token(Token = "0x4006DB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AC60", Offset = "0x16AD61")]
	public NpcMoveType NpcMoveType;

	// Token: 0x040078F5 RID: 30965
	[Token(Token = "0x4006DB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transform;

	// Token: 0x040078F6 RID: 30966
	[Token(Token = "0x4006DB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float AnimRunSpeed;

	// Token: 0x040078F7 RID: 30967
	[Token(Token = "0x4006DB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Attribute(Name = "HideInInspector", RVA = "0x16ACA0", Offset = "0x16ADA1")]
	private Vector3 PrevTickPosition;

	// Token: 0x040078F8 RID: 30968
	[Token(Token = "0x4006DB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16ACB0", Offset = "0x16ADB1")]
	public bool UseNavMesh;

	// Token: 0x040078F9 RID: 30969
	[Token(Token = "0x4006DB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<NpcTimeAction> NpcTimeActions;

	// Token: 0x040078FA RID: 30970
	[Token(Token = "0x4006DBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool _IsReached;

	// Token: 0x040078FB RID: 30971
	[Token(Token = "0x4006DBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	public bool IsDoneRaycast;

	// Token: 0x040078FC RID: 30972
	[Token(Token = "0x4006DBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
	public bool IsLateness;

	// Token: 0x040078FD RID: 30973
	[Token(Token = "0x4006DBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
	public bool IsHurry;

	// Token: 0x040078FE RID: 30974
	[Token(Token = "0x4006DBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool IsCheckRainHomeBack;

	// Token: 0x040078FF RID: 30975
	[Token(Token = "0x4006DBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Weather _HomeBackWeather;

	// Token: 0x04007900 RID: 30976
	[Token(Token = "0x4006DC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool IsWaitNextAction;

	// Token: 0x04007901 RID: 30977
	[Token(Token = "0x4006DC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public NpcPatrolPoint CurrentPatrolPoint;

	// Token: 0x04007902 RID: 30978
	[Token(Token = "0x4006DC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject _NextPatrolPoint;

	// Token: 0x04007903 RID: 30979
	[Token(Token = "0x4006DC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LifecycleState PrevLifecycleState;

	// Token: 0x04007904 RID: 30980
	[Token(Token = "0x4006DC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public int _CurrentLifecycleTime;

	// Token: 0x04007905 RID: 30981
	[Token(Token = "0x4006DC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public LifecycleState _CurrentLifecycleState;

	// Token: 0x04007906 RID: 30982
	[Token(Token = "0x4006DC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public LifecycleState NextLifecycleState;

	// Token: 0x04007907 RID: 30983
	[Token(Token = "0x4006DC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LifecycleState BeforeResetLifecycleState;

	// Token: 0x04007908 RID: 30984
	[Token(Token = "0x4006DC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16ACF0", Offset = "0x16ADF1")]
	public Place PrevPlace;

	// Token: 0x04007909 RID: 30985
	[Token(Token = "0x4006DC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Place _TargetPlace;

	// Token: 0x0400790A RID: 30986
	[Token(Token = "0x4006DCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public NpcPatrolPoint SeatPatrolPoint;

	// Token: 0x0400790B RID: 30987
	[Token(Token = "0x4006DCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public NpcPatrolPoint JobPatrolPoint;

	// Token: 0x0400790C RID: 30988
	[Token(Token = "0x4006DCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public string BedPatrolPointName;

	// Token: 0x0400790D RID: 30989
	[Token(Token = "0x4006DCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public NpcPatrolPoint BedPatrolPoint;

	// Token: 0x0400790E RID: 30990
	[Token(Token = "0x4006DCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public string DoorPatrolPointName;

	// Token: 0x0400790F RID: 30991
	[Token(Token = "0x4006DCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string TargetDoorPatrolPointName;

	// Token: 0x04007910 RID: 30992
	[Token(Token = "0x4006DD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject targetDoor;

	// Token: 0x04007911 RID: 30993
	[Token(Token = "0x4006DD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Vector3 targetPosition;

	// Token: 0x04007912 RID: 30994
	[Token(Token = "0x4006DD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public int CurrentPositionIndex;

	// Token: 0x04007913 RID: 30995
	[Token(Token = "0x4006DD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public string[] PatrolPoints;

	// Token: 0x04007914 RID: 30996
	[Token(Token = "0x4006DD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3[] positions;

	// Token: 0x04007915 RID: 30997
	[Token(Token = "0x4006DD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public string[] pointNames;

	// Token: 0x04007916 RID: 30998
	[Token(Token = "0x4006DD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public bool IsWarp;

	// Token: 0x04007917 RID: 30999
	[Token(Token = "0x4006DD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AD30", Offset = "0x16AE31")]
	public int hour;

	// Token: 0x04007918 RID: 31000
	[Token(Token = "0x4006DD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public int minutes;

	// Token: 0x04007919 RID: 31001
	[Token(Token = "0x4006DD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public int currentTimeListExtractTime;

	// Token: 0x0400791A RID: 31002
	[Token(Token = "0x4006DDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float ElapsedTime;

	// Token: 0x0400791B RID: 31003
	[Token(Token = "0x4006DDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float WaitTime;

	// Token: 0x0400791C RID: 31004
	[Token(Token = "0x4006DDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int ArriveTime;

	// Token: 0x0400791D RID: 31005
	[Token(Token = "0x4006DDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float _walkSpeed;

	// Token: 0x0400791E RID: 31006
	[Token(Token = "0x4006DDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public ConflictSpeedType conflictSpeedType;

	// Token: 0x0400791F RID: 31007
	[Token(Token = "0x4006DDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public float arriveDistance;

	// Token: 0x04007920 RID: 31008
	[Token(Token = "0x4006DE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public int StayStartTime;

	// Token: 0x04007921 RID: 31009
	[Token(Token = "0x4006DE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public int NpcStayTime;

	// Token: 0x04007922 RID: 31010
	[Token(Token = "0x4006DE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public float StoppingTime;

	// Token: 0x04007923 RID: 31011
	[Token(Token = "0x4006DE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public bool IsStandup;

	// Token: 0x04007924 RID: 31012
	[Token(Token = "0x4006DE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x155")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AD70", Offset = "0x16AE71")]
	public bool IsConflict;

	// Token: 0x04007925 RID: 31013
	[Token(Token = "0x4006DE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x156")]
	public bool IsNpcConflict;

	// Token: 0x04007926 RID: 31014
	[Token(Token = "0x4006DE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x157")]
	public bool IsAlreadyNpcConflict;

	// Token: 0x04007927 RID: 31015
	[Token(Token = "0x4006DE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public List<CharacterBase> ConflictCharacters;

	// Token: 0x04007928 RID: 31016
	[Token(Token = "0x4006DE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public float TotalConflictTime;

	// Token: 0x04007929 RID: 31017
	[Token(Token = "0x4006DE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public float NpcConflictTime;

	// Token: 0x0400792A RID: 31018
	[Token(Token = "0x4006DEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public LookAtTargetType LookAtTargetType;

	// Token: 0x0400792B RID: 31019
	[Token(Token = "0x4006DEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	[Attribute(Name = "HideInInspector", RVA = "0x16ADB0", Offset = "0x16AEB1")]
	private Vector3 avoidPosition;

	// Token: 0x0400792C RID: 31020
	[Token(Token = "0x4006DEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16ADC0", Offset = "0x16AEC1")]
	public bool MotionCancel;

	// Token: 0x0400792D RID: 31021
	[Token(Token = "0x4006DED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public LookAtState _lookAtState;

	// Token: 0x0400792E RID: 31022
	[Token(Token = "0x4006DEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public bool _IsTalking;

	// Token: 0x0400792F RID: 31023
	[Token(Token = "0x4006DEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
	public bool IsFirstRotate;

	// Token: 0x04007930 RID: 31024
	[Token(Token = "0x4006DF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
	public bool IsFirstMoveRotate;

	// Token: 0x04007931 RID: 31025
	[Token(Token = "0x4006DF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x183")]
	public bool IsLookTarget;

	// Token: 0x04007932 RID: 31026
	[Token(Token = "0x4006DF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	public bool IsLookNearPlayer;

	// Token: 0x04007933 RID: 31027
	[Token(Token = "0x4006DF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16AE00", Offset = "0x16AF01")]
	public Place CurrentEatPlace;

	// Token: 0x04007934 RID: 31028
	[Token(Token = "0x4006DF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public NpcStatusData statusData;

	// Token: 0x04007935 RID: 31029
	[Token(Token = "0x4006DF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private NpcPatrolPointMotionData npcPatrolPointMotionData;

	// Token: 0x04007936 RID: 31030
	[Token(Token = "0x4006DF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Weather CheckedWeather;

	// Token: 0x04007937 RID: 31031
	[Token(Token = "0x4006DF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public int CheckedNpcTimeActionTime;

	// Token: 0x04007938 RID: 31032
	[Token(Token = "0x4006DF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public bool IsTimeShiftLoopAction;

	// Token: 0x04007939 RID: 31033
	[Token(Token = "0x4006DF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	public float TargetNaviSpeed;

	// Token: 0x0400793A RID: 31034
	[Token(Token = "0x4006DFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public float CurrentNaviSpeed;

	// Token: 0x0400793B RID: 31035
	[Token(Token = "0x4006DFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	public float diffSpeed;

	// Token: 0x0400793C RID: 31036
	[Token(Token = "0x4006DFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public int SlowDownTime;

	// Token: 0x0400793D RID: 31037
	[Token(Token = "0x4006DFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	public bool IsDeletedModel;

	// Token: 0x0400793E RID: 31038
	[Token(Token = "0x4006DFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
	public bool standby;

	// Token: 0x0400793F RID: 31039
	[Token(Token = "0x4006DFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
	public bool IsSettingInitialPose;

	// Token: 0x04007940 RID: 31040
	[Token(Token = "0x4006E00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
	public bool _IsSetInitialPose;

	// Token: 0x04007941 RID: 31041
	[Token(Token = "0x4006E01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public NpcFadeState fadeState;

	// Token: 0x04007942 RID: 31042
	[Token(Token = "0x4006E02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	public float CurrentFadeAlpha;

	// Token: 0x04007943 RID: 31043
	[Token(Token = "0x4006E03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[Attribute(Name = "HideInInspector", RVA = "0x16AE40", Offset = "0x16AF41")]
	private IEnumerator iEnumerator;

	// Token: 0x04007944 RID: 31044
	[Token(Token = "0x4006E04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "HideInInspector", RVA = "0x16AE50", Offset = "0x16AF51")]
	public bool IsPartnerToNpcSettingCalled;

	// Token: 0x04007945 RID: 31045
	[Token(Token = "0x4006E05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public NpcLifeCycleDataManager LifeCycleData;

	// Token: 0x04007946 RID: 31046
	[Token(Token = "0x4006E06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool IsReady;

	// Token: 0x04007947 RID: 31047
	[Token(Token = "0x4006E07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private IEnumerator iEnumeratorSlowDown;

	// Token: 0x04007948 RID: 31048
	[Token(Token = "0x4006E08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public NpcMoveControl TargetActor;

	// Token: 0x04007949 RID: 31049
	[Token(Token = "0x4006E09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private SpeedData[] MoveSpeedTable;

	// Token: 0x0400794A RID: 31050
	[Token(Token = "0x4006E0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private SPEED MoveSpeed;

	// Token: 0x0400794B RID: 31051
	[Token(Token = "0x4006E0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public bool IsShortPlayFromCommonDate;

	// Token: 0x0400794C RID: 31052
	[Token(Token = "0x4006E0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x205")]
	public bool IsShortPlayFromPartner;

	// Token: 0x0400794D RID: 31053
	[Token(Token = "0x4006E0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public VariationNo variationNo;

	// Token: 0x0400794E RID: 31054
	[Token(Token = "0x4006E0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public VariationNo changeVariationNo;

	// Token: 0x0400794F RID: 31055
	[Token(Token = "0x4006E0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private NavMeshPath path;

	// Token: 0x04007950 RID: 31056
	[Token(Token = "0x4006E10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private Vector3[] corners;

	// Token: 0x04007951 RID: 31057
	[Token(Token = "0x4006E11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public bool pathPending;

	// Token: 0x04007952 RID: 31058
	[Token(Token = "0x4006E12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public LifeCycleAdvMain lifeCycleAdvMain;

	// Token: 0x04007953 RID: 31059
	[Token(Token = "0x4006E13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private bool IsOpenDoor;

	// Token: 0x04007954 RID: 31060
	[Token(Token = "0x4006E14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x231")]
	public bool HaveItemFailed;

	// Token: 0x04007955 RID: 31061
	[Token(Token = "0x4006E15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<ActorID, Master> patrolPointLoadIds;

	// Token: 0x04007956 RID: 31062
	[Token(Token = "0x4006E16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x232")]
	public bool ForceEnable;

	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x2001232")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B20", Offset = "0x158C21")]
	private sealed class <FadeInOutNpc>d__326 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003628 RID: 13864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DB")]
		[Address(RVA = "0x258D400", Offset = "0x258D501", VA = "0x258D400")]
		[DebuggerHidden]
		public <FadeInOutNpc>d__326(int <>1__state)
		{
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DC")]
		[Address(RVA = "0x259C750", Offset = "0x259C851", VA = "0x259C750", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x60073DD")]
		[Address(RVA = "0x259C760", Offset = "0x259C861", VA = "0x259C760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5A")]
		private object Current
		{
			[Token(Token = "0x60073DE")]
			[Address(RVA = "0x259C940", Offset = "0x259CA41", VA = "0x259C940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073DF")]
		[Address(RVA = "0x259C950", Offset = "0x259CA51", VA = "0x259C950", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5B")]
		private object Current
		{
			[Token(Token = "0x60073E0")]
			[Address(RVA = "0x259C9B0", Offset = "0x259CAB1", VA = "0x259C9B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007957 RID: 31063
		[Token(Token = "0x40197A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007958 RID: 31064
		[Token(Token = "0x40197A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007959 RID: 31065
		[Token(Token = "0x40197A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;

		// Token: 0x0400795A RID: 31066
		[Token(Token = "0x40197A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _fadeEndAction;

		// Token: 0x0400795B RID: 31067
		[Token(Token = "0x40197A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <CharFadeTime>5__2;

		// Token: 0x0400795C RID: 31068
		[Token(Token = "0x40197AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private NpcFadeState <loopInFadeState>5__3;
	}

	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x2001233")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B30", Offset = "0x158C31")]
	private sealed class <>c__DisplayClass332_0
	{
		// Token: 0x0600362E RID: 13870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E1")]
		[Address(RVA = "0x258E150", Offset = "0x258E251", VA = "0x258E150")]
		public <>c__DisplayClass332_0()
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E2")]
		[Address(RVA = "0x259BAE0", Offset = "0x259BBE1", VA = "0x259BAE0")]
		internal void <CheckObjectEnabled>b__0()
		{
		}

		// Token: 0x0400795D RID: 31069
		[Token(Token = "0x40197AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NpcController npc;

		// Token: 0x0400795E RID: 31070
		[Token(Token = "0x40197AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F1 RID: 2033
	[Token(Token = "0x2001234")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B40", Offset = "0x158C41")]
	private sealed class <WalkStop>d__333 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003630 RID: 13872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E3")]
		[Address(RVA = "0x258E210", Offset = "0x258E311", VA = "0x258E210")]
		[DebuggerHidden]
		public <WalkStop>d__333(int <>1__state)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E4")]
		[Address(RVA = "0x259DDF0", Offset = "0x259DEF1", VA = "0x259DDF0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x60073E5")]
		[Address(RVA = "0x259DE00", Offset = "0x259DF01", VA = "0x259DE00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5C")]
		private object Current
		{
			[Token(Token = "0x60073E6")]
			[Address(RVA = "0x259E1A0", Offset = "0x259E2A1", VA = "0x259E1A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E7")]
		[Address(RVA = "0x259E1B0", Offset = "0x259E2B1", VA = "0x259E1B0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5D")]
		private object Current
		{
			[Token(Token = "0x60073E8")]
			[Address(RVA = "0x259E210", Offset = "0x259E311", VA = "0x259E210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400795F RID: 31071
		[Token(Token = "0x40197AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007960 RID: 31072
		[Token(Token = "0x40197AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007961 RID: 31073
		[Token(Token = "0x40197AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;

		// Token: 0x04007962 RID: 31074
		[Token(Token = "0x40197B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int targetNpcId;

		// Token: 0x04007963 RID: 31075
		[Token(Token = "0x40197B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float waitMinutes;

		// Token: 0x04007964 RID: 31076
		[Token(Token = "0x40197B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool firstMotion;

		// Token: 0x04007965 RID: 31077
		[Token(Token = "0x40197B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NpcController <npc>5__2;

		// Token: 0x04007966 RID: 31078
		[Token(Token = "0x40197B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NpcController <targetNpc>5__3;
	}

	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x2001235")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B50", Offset = "0x158C51")]
	private sealed class <SlowDownStart>d__335 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003636 RID: 13878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E9")]
		[Address(RVA = "0x258E370", Offset = "0x258E471", VA = "0x258E370")]
		[DebuggerHidden]
		public <SlowDownStart>d__335(int <>1__state)
		{
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EA")]
		[Address(RVA = "0x259D470", Offset = "0x259D571", VA = "0x259D470", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x60073EB")]
		[Address(RVA = "0x259D480", Offset = "0x259D581", VA = "0x259D480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5E")]
		private object Current
		{
			[Token(Token = "0x60073EC")]
			[Address(RVA = "0x259D8B0", Offset = "0x259D9B1", VA = "0x259D8B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073ED")]
		[Address(RVA = "0x259D8C0", Offset = "0x259D9C1", VA = "0x259D8C0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D5F")]
		private object Current
		{
			[Token(Token = "0x60073EE")]
			[Address(RVA = "0x259D920", Offset = "0x259DA21", VA = "0x259D920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007967 RID: 31079
		[Token(Token = "0x40197B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007968 RID: 31080
		[Token(Token = "0x40197B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007969 RID: 31081
		[Token(Token = "0x40197B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;

		// Token: 0x0400796A RID: 31082
		[Token(Token = "0x40197B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float waitMinutes;

		// Token: 0x0400796B RID: 31083
		[Token(Token = "0x40197B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NpcController <npc>5__2;
	}

	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x2001236")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B60", Offset = "0x158C61")]
	private sealed class <SlowDownEndStart>d__337 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600363C RID: 13884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EF")]
		[Address(RVA = "0x258E7A0", Offset = "0x258E8A1", VA = "0x258E7A0")]
		[DebuggerHidden]
		public <SlowDownEndStart>d__337(int <>1__state)
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F0")]
		[Address(RVA = "0x259D140", Offset = "0x259D241", VA = "0x259D140", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x60073F1")]
		[Address(RVA = "0x259D150", Offset = "0x259D251", VA = "0x259D150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D60")]
		private object Current
		{
			[Token(Token = "0x60073F2")]
			[Address(RVA = "0x259D3F0", Offset = "0x259D4F1", VA = "0x259D3F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F3")]
		[Address(RVA = "0x259D400", Offset = "0x259D501", VA = "0x259D400", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D61")]
		private object Current
		{
			[Token(Token = "0x60073F4")]
			[Address(RVA = "0x259D460", Offset = "0x259D561", VA = "0x259D460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400796C RID: 31084
		[Token(Token = "0x40197BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400796D RID: 31085
		[Token(Token = "0x40197BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400796E RID: 31086
		[Token(Token = "0x40197BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x2001237")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B70", Offset = "0x158C71")]
	private sealed class <StandupFadeIn>d__353 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003642 RID: 13890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F5")]
		[Address(RVA = "0x2591150", Offset = "0x2591251", VA = "0x2591150")]
		[DebuggerHidden]
		public <StandupFadeIn>d__353(int <>1__state)
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F6")]
		[Address(RVA = "0x259D930", Offset = "0x259DA31", VA = "0x259D930", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00012B28 File Offset: 0x00010D28
		[Token(Token = "0x60073F7")]
		[Address(RVA = "0x259D940", Offset = "0x259DA41", VA = "0x259D940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D62")]
		private object Current
		{
			[Token(Token = "0x60073F8")]
			[Address(RVA = "0x259DA90", Offset = "0x259DB91", VA = "0x259DA90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F9")]
		[Address(RVA = "0x259DAA0", Offset = "0x259DBA1", VA = "0x259DAA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D63")]
		private object Current
		{
			[Token(Token = "0x60073FA")]
			[Address(RVA = "0x259DB00", Offset = "0x259DC01", VA = "0x259DB00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400796F RID: 31087
		[Token(Token = "0x40197BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007970 RID: 31088
		[Token(Token = "0x40197BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007971 RID: 31089
		[Token(Token = "0x40197BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x2001238")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B80", Offset = "0x158C81")]
	private sealed class <OpenDoor>d__359 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003648 RID: 13896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FB")]
		[Address(RVA = "0x2591810", Offset = "0x2591911", VA = "0x2591810")]
		[DebuggerHidden]
		public <OpenDoor>d__359(int <>1__state)
		{
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FC")]
		[Address(RVA = "0x259CC30", Offset = "0x259CD31", VA = "0x259CC30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x60073FD")]
		[Address(RVA = "0x259CC40", Offset = "0x259CD41", VA = "0x259CC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D64")]
		private object Current
		{
			[Token(Token = "0x60073FE")]
			[Address(RVA = "0x259CD60", Offset = "0x259CE61", VA = "0x259CD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FF")]
		[Address(RVA = "0x259CD70", Offset = "0x259CE71", VA = "0x259CD70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D65")]
		private object Current
		{
			[Token(Token = "0x6007400")]
			[Address(RVA = "0x259CDD0", Offset = "0x259CED1", VA = "0x259CDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007972 RID: 31090
		[Token(Token = "0x40197C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007973 RID: 31091
		[Token(Token = "0x40197C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007974 RID: 31092
		[Token(Token = "0x40197C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x2001239")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158B90", Offset = "0x158C91")]
	private sealed class <ArriveAction>d__363 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600364E RID: 13902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007401")]
		[Address(RVA = "0x2592AE0", Offset = "0x2592BE1", VA = "0x2592AE0")]
		[DebuggerHidden]
		public <ArriveAction>d__363(int <>1__state)
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007402")]
		[Address(RVA = "0x259BB60", Offset = "0x259BC61", VA = "0x259BB60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00012B58 File Offset: 0x00010D58
		[Token(Token = "0x6007403")]
		[Address(RVA = "0x259BB70", Offset = "0x259BC71", VA = "0x259BB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D66")]
		private object Current
		{
			[Token(Token = "0x6007404")]
			[Address(RVA = "0x259C6D0", Offset = "0x259C7D1", VA = "0x259C6D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007405")]
		[Address(RVA = "0x259C6E0", Offset = "0x259C7E1", VA = "0x259C6E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D67")]
		private object Current
		{
			[Token(Token = "0x6007406")]
			[Address(RVA = "0x259C740", Offset = "0x259C841", VA = "0x259C740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007975 RID: 31093
		[Token(Token = "0x40197C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007976 RID: 31094
		[Token(Token = "0x40197C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007977 RID: 31095
		[Token(Token = "0x40197C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x200123A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BA0", Offset = "0x158CA1")]
	private sealed class <TyphoonAction>d__398 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003654 RID: 13908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007407")]
		[Address(RVA = "0x2596DF0", Offset = "0x2596EF1", VA = "0x2596DF0")]
		[DebuggerHidden]
		public <TyphoonAction>d__398(int <>1__state)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007408")]
		[Address(RVA = "0x259DB10", Offset = "0x259DC11", VA = "0x259DB10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x6007409")]
		[Address(RVA = "0x259DB20", Offset = "0x259DC21", VA = "0x259DB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D68")]
		private object Current
		{
			[Token(Token = "0x600740A")]
			[Address(RVA = "0x259DD70", Offset = "0x259DE71", VA = "0x259DD70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740B")]
		[Address(RVA = "0x259DD80", Offset = "0x259DE81", VA = "0x259DD80", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D69")]
		private object Current
		{
			[Token(Token = "0x600740C")]
			[Address(RVA = "0x259DDE0", Offset = "0x259DEE1", VA = "0x259DDE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007978 RID: 31096
		[Token(Token = "0x40197C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007979 RID: 31097
		[Token(Token = "0x40197C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400797A RID: 31098
		[Token(Token = "0x40197C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x200123B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BB0", Offset = "0x158CB1")]
	private sealed class <RainBackWaitAction>d__400 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740D")]
		[Address(RVA = "0x2596EB0", Offset = "0x2596FB1", VA = "0x2596EB0")]
		[DebuggerHidden]
		public <RainBackWaitAction>d__400(int <>1__state)
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740E")]
		[Address(RVA = "0x259CDE0", Offset = "0x259CEE1", VA = "0x259CDE0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x600740F")]
		[Address(RVA = "0x259CDF0", Offset = "0x259CEF1", VA = "0x259CDF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6A")]
		private object Current
		{
			[Token(Token = "0x6007410")]
			[Address(RVA = "0x259D0C0", Offset = "0x259D1C1", VA = "0x259D0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007411")]
		[Address(RVA = "0x259D0D0", Offset = "0x259D1D1", VA = "0x259D0D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6B")]
		private object Current
		{
			[Token(Token = "0x6007412")]
			[Address(RVA = "0x259D130", Offset = "0x259D231", VA = "0x259D130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400797B RID: 31099
		[Token(Token = "0x40197C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400797C RID: 31100
		[Token(Token = "0x40197CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400797D RID: 31101
		[Token(Token = "0x40197CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HomeBackType homeBackType;

		// Token: 0x0400797E RID: 31102
		[Token(Token = "0x40197CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NpcData <>4__this;
	}

	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x200123C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BC0", Offset = "0x158CC1")]
	private sealed class <>c__DisplayClass436_0
	{
		// Token: 0x06003660 RID: 13920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007413")]
		[Address(RVA = "0x25997B0", Offset = "0x25998B1", VA = "0x25997B0")]
		public <>c__DisplayClass436_0()
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007414")]
		[Address(RVA = "0x259BB30", Offset = "0x259BC31", VA = "0x259BB30")]
		internal void <ReleasePartner>b__0()
		{
		}

		// Token: 0x0400797F RID: 31103
		[Token(Token = "0x40197CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NpcData <>4__this;

		// Token: 0x04007980 RID: 31104
		[Token(Token = "0x40197CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<NpcController> callBack;
	}

	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x200123D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158BD0", Offset = "0x158CD1")]
	private sealed class <LookAtTargetRotationEnd>d__463 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007415")]
		[Address(RVA = "0x259AF60", Offset = "0x259B061", VA = "0x259AF60")]
		[DebuggerHidden]
		public <LookAtTargetRotationEnd>d__463(int <>1__state)
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007416")]
		[Address(RVA = "0x259C9C0", Offset = "0x259CAC1", VA = "0x259C9C0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x6007417")]
		[Address(RVA = "0x259C9D0", Offset = "0x259CAD1", VA = "0x259C9D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6C")]
		private object Current
		{
			[Token(Token = "0x6007418")]
			[Address(RVA = "0x259CBB0", Offset = "0x259CCB1", VA = "0x259CBB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007419")]
		[Address(RVA = "0x259CBC0", Offset = "0x259CCC1", VA = "0x259CBC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D6D")]
		private object Current
		{
			[Token(Token = "0x600741A")]
			[Address(RVA = "0x259CC20", Offset = "0x259CD21", VA = "0x259CC20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007981 RID: 31105
		[Token(Token = "0x40197CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007982 RID: 31106
		[Token(Token = "0x40197D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007983 RID: 31107
		[Token(Token = "0x40197D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcData <>4__this;

		// Token: 0x04007984 RID: 31108
		[Token(Token = "0x40197D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsTalkStart;
	}
}
