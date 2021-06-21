using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000285 RID: 645
[Token(Token = "0x2000200")]
public class MobTravelerManager : SingletonMonoBehaviour<MobTravelerManager>
{
	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x0600104F RID: 4175 RVA: 0x000077B8 File Offset: 0x000059B8
	[Token(Token = "0x170002BB")]
	public bool Show
	{
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x1D7BEF0", Offset = "0x1D7BFF1", VA = "0x1D7BEF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x06001050 RID: 4176 RVA: 0x000077D0 File Offset: 0x000059D0
	// (set) Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002BC")]
	private int MaleNum
	{
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x1D7BF00", Offset = "0x1D7C001", VA = "0x1D7BF00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C320", Offset = "0x19C421")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x1D7BF10", Offset = "0x1D7C011", VA = "0x1D7BF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C330", Offset = "0x19C431")]
		set
		{
		}
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x06001052 RID: 4178 RVA: 0x000077E8 File Offset: 0x000059E8
	// (set) Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002BD")]
	private int FemaleNum
	{
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x1D7BF20", Offset = "0x1D7C021", VA = "0x1D7BF20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C340", Offset = "0x19C441")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x1D7BF30", Offset = "0x1D7C031", VA = "0x1D7BF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C350", Offset = "0x19C451")]
		set
		{
		}
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x06001054 RID: 4180 RVA: 0x00007800 File Offset: 0x00005A00
	[Token(Token = "0x170002BE")]
	private int TotalNum
	{
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x1D7BF40", Offset = "0x1D7C041", VA = "0x1D7BF40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x06001055 RID: 4181 RVA: 0x00007818 File Offset: 0x00005A18
	// (set) Token: 0x06001056 RID: 4182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002BF")]
	public bool IsBaseCreated
	{
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x1D7BF50", Offset = "0x1D7C051", VA = "0x1D7BF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C360", Offset = "0x19C461")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x1D7BF60", Offset = "0x1D7C061", VA = "0x1D7BF60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C370", Offset = "0x19C471")]
		protected set
		{
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x06001057 RID: 4183 RVA: 0x00007830 File Offset: 0x00005A30
	// (set) Token: 0x06001058 RID: 4184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C0")]
	public bool IsModelCreated
	{
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x1D7BF70", Offset = "0x1D7C071", VA = "0x1D7BF70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C380", Offset = "0x19C481")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x1D7BF80", Offset = "0x1D7C081", VA = "0x1D7BF80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C390", Offset = "0x19C491")]
		protected set
		{
		}
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x06001059 RID: 4185 RVA: 0x00007848 File Offset: 0x00005A48
	// (set) Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002C1")]
	public bool IsInTown
	{
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x1D7BF90", Offset = "0x1D7C091", VA = "0x1D7BF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3A0", Offset = "0x19C4A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x1D7BFA0", Offset = "0x1D7C0A1", VA = "0x1D7BFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C3B0", Offset = "0x19C4B1")]
		protected set
		{
		}
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x0600105B RID: 4187 RVA: 0x00007860 File Offset: 0x00005A60
	[Token(Token = "0x170002C2")]
	public bool IsAvailable
	{
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x1D7BFB0", Offset = "0x1D7C0B1", VA = "0x1D7BFB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x0600105C RID: 4188 RVA: 0x00007878 File Offset: 0x00005A78
	[Token(Token = "0x170002C3")]
	public bool IsActivityTime
	{
		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x1D7C090", Offset = "0x1D7C191", VA = "0x1D7C090")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x0600105D RID: 4189 RVA: 0x00007890 File Offset: 0x00005A90
	[Token(Token = "0x170002C4")]
	public bool IsTimeOver
	{
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x1D7C180", Offset = "0x1D7C281", VA = "0x1D7C180")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x0600105E RID: 4190 RVA: 0x000078A8 File Offset: 0x00005AA8
	[Token(Token = "0x170002C5")]
	public float MoveSpeedRate
	{
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x1D7C270", Offset = "0x1D7C371", VA = "0x1D7C270")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x000078C0 File Offset: 0x00005AC0
	[Token(Token = "0x6000ED0")]
	[Address(RVA = "0x1D7B700", Offset = "0x1D7B801", VA = "0x1D7B700")]
	public bool Regist(ActorID actorID, MobTravelerController controller)
	{
		return default(bool);
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x000078D8 File Offset: 0x00005AD8
	[Token(Token = "0x6000ED1")]
	[Address(RVA = "0x1D7BA20", Offset = "0x1D7BB21", VA = "0x1D7BA20")]
	public bool Remove(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ED2")]
	[Address(RVA = "0x1D7C630", Offset = "0x1D7C731", VA = "0x1D7C630")]
	public MobTravelerController Get(ActorID actorID)
	{
		return null;
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x1D7A2B0", Offset = "0x1D7A3B1", VA = "0x1D7A2B0")]
	public void OnUpdate()
	{
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x1D7C6F0", Offset = "0x1D7C7F1", VA = "0x1D7C6F0")]
	public void Init()
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x000078F0 File Offset: 0x00005AF0
	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x1D7CC40", Offset = "0x1D7CD41", VA = "0x1D7CC40")]
	private bool IsFemale(CharID charID)
	{
		return default(bool);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x1D7C7F0", Offset = "0x1D7C8F1", VA = "0x1D7C7F0")]
	public void ResetAll()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x1D7CE60", Offset = "0x1D7CF61", VA = "0x1D7CE60")]
	public void ResetNames()
	{
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x1D7D1A0", Offset = "0x1D7D2A1", VA = "0x1D7D1A0")]
	public void CreateAll()
	{
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x1D7CC60", Offset = "0x1D7CD61", VA = "0x1D7CC60")]
	public void DeleteAll()
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDA")]
	[Address(RVA = "0x1D7D3B0", Offset = "0x1D7D4B1", VA = "0x1D7D3B0")]
	public void DeleteModelAll()
	{
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDB")]
	[Address(RVA = "0x1D7CA90", Offset = "0x1D7CB91", VA = "0x1D7CA90")]
	public void ShowAll()
	{
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x1D7D680", Offset = "0x1D7D781", VA = "0x1D7D680")]
	public void HideAll()
	{
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDD")]
	[Address(RVA = "0x1D7D810", Offset = "0x1D7D911", VA = "0x1D7D810")]
	public void ResetPositionAll()
	{
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EDE")]
	[Address(RVA = "0x1D7C280", Offset = "0x1D7C381", VA = "0x1D7C280")]
	private void SetPosition(ActorID actorID)
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDF")]
	[Address(RVA = "0x1D7B590", Offset = "0x1D7B691", VA = "0x1D7B590")]
	public string GetName(ActorID actorID)
	{
		return null;
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00007908 File Offset: 0x00005B08
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x1D7BC10", Offset = "0x1D7BD11", VA = "0x1D7BC10")]
	public float GetSpeedRate(ActorID actorID)
	{
		return 0f;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x1D7DB60", Offset = "0x1D7DC61", VA = "0x1D7DB60")]
	public void OnResetPlaceID()
	{
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x1D7AB50", Offset = "0x1D7AC51", VA = "0x1D7AB50")]
	public void OnDayCarry(int days)
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x1D7D5B0", Offset = "0x1D7D6B1", VA = "0x1D7D5B0")]
	public void DoCheck()
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE4")]
	[Address(RVA = "0x1D7DB70", Offset = "0x1D7DC71", VA = "0x1D7DB70")]
	public MobTravelerManager()
	{
	}

	// Token: 0x0400092E RID: 2350
	[Token(Token = "0x400073C")]
	private const int ArrayNum = 16;

	// Token: 0x0400092F RID: 2351
	[Token(Token = "0x400073D")]
	private const ActorID ActorStartID = ActorID.act033;

	// Token: 0x04000930 RID: 2352
	[Token(Token = "0x400073E")]
	private const float m_ActivateDistance = 40f;

	// Token: 0x04000931 RID: 2353
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x18")]
	private Register<ActorID, MobTravelerController> m_Register;

	// Token: 0x04000932 RID: 2354
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x15E9B0", Offset = "0x15EAB1")]
	private List<ValueTuple<CharID, VariationNo, HairType>> m_CharaList;

	// Token: 0x04000933 RID: 2355
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<CharID, float> m_MoveSpeedRateDic;

	// Token: 0x04000934 RID: 2356
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_isShow;

	// Token: 0x04000935 RID: 2357
	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Transform> m_StartPointList;

	// Token: 0x04000936 RID: 2358
	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15EA90", Offset = "0x15EB91")]
	private float m_BaseMoveSpeedRate;

	// Token: 0x04000937 RID: 2359
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<ActorID, MobTravelerName> m_NameDictionary;

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x48")]
	private int m_PositionIndex;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x4C")]
	private int m_PositionIndexInc;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x4000748")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EAE0", Offset = "0x15EBE1")]
	private int <MaleNum>k__BackingField;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EAF0", Offset = "0x15EBF1")]
	private int <FemaleNum>k__BackingField;

	// Token: 0x0400093C RID: 2364
	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB00", Offset = "0x15EC01")]
	private bool <IsBaseCreated>k__BackingField;

	// Token: 0x0400093D RID: 2365
	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x59")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB10", Offset = "0x15EC11")]
	private bool <IsModelCreated>k__BackingField;

	// Token: 0x0400093E RID: 2366
	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x5A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EB20", Offset = "0x15EC21")]
	private bool <IsInTown>k__BackingField;
}
