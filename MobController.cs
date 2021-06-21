using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000297 RID: 663
[Token(Token = "0x200020E")]
public class MobController : HumanController, InteractionInterface, FocusInterface
{
	// Token: 0x06001105 RID: 4357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x1D77DA0", Offset = "0x1D77EA1", VA = "0x1D77DA0")]
	public static void OnUpdateEvent()
	{
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x1D77E50", Offset = "0x1D77F51", VA = "0x1D77E50")]
	private static void OnUpdateTalkEvent()
	{
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00007D70 File Offset: 0x00005F70
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x1D77FB0", Offset = "0x1D780B1", VA = "0x1D77FB0")]
	public static bool PlayTalkEvent(MobController controller, Character opponent)
	{
		return default(bool);
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x1D782C0", Offset = "0x1D783C1", VA = "0x1D782C0")]
	public static MobController Get()
	{
		return null;
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x06001109 RID: 4361 RVA: 0x00007D88 File Offset: 0x00005F88
	[Token(Token = "0x170002DD")]
	public virtual bool Focusable
	{
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x1D78330", Offset = "0x1D78431", VA = "0x1D78330", Slot = "109")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x0600110A RID: 4362 RVA: 0x00007DA0 File Offset: 0x00005FA0
	[Token(Token = "0x170002DE")]
	public int FocusPriority
	{
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x1D78430", Offset = "0x1D78531", VA = "0x1D78430", Slot = "104")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x0600110B RID: 4363 RVA: 0x00007DB8 File Offset: 0x00005FB8
	[Token(Token = "0x170002DF")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x1D78440", Offset = "0x1D78541", VA = "0x1D78440", Slot = "105")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x1D78450", Offset = "0x1D78551", VA = "0x1D78450", Slot = "110")]
	public virtual string GetFocusName()
	{
		return null;
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x1D784A0", Offset = "0x1D785A1", VA = "0x1D784A0", Slot = "111")]
	public virtual void OnFocus()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x1D784B0", Offset = "0x1D785B1", VA = "0x1D784B0", Slot = "112")]
	public virtual void OffFocus()
	{
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00007DD0 File Offset: 0x00005FD0
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x1D784C0", Offset = "0x1D785C1", VA = "0x1D784C0", Slot = "113")]
	public virtual ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00007DE8 File Offset: 0x00005FE8
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x1D784D0", Offset = "0x1D785D1", VA = "0x1D784D0", Slot = "114")]
	public virtual bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x1D784E0", Offset = "0x1D785E1", VA = "0x1D784E0", Slot = "115")]
	public virtual string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x1D78530", Offset = "0x1D78631", VA = "0x1D78530", Slot = "116")]
	public virtual void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x1D785B0", Offset = "0x1D786B1", VA = "0x1D785B0", Slot = "117")]
	public virtual void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x1D78630", Offset = "0x1D78731", VA = "0x1D78630", Slot = "118")]
	public virtual bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x170002E0")]
	public override Alliance Alliance
	{
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x1D78640", Offset = "0x1D78741", VA = "0x1D78640", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x06001116 RID: 4374 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x170002E1")]
	public bool IsTalking
	{
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x1D78650", Offset = "0x1D78751", VA = "0x1D78650")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002E2")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x1D78660", Offset = "0x1D78761", VA = "0x1D78660", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x06001118 RID: 4376 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x170002E3")]
	public override bool IsDead
	{
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x1D78670", Offset = "0x1D78771", VA = "0x1D78670", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x06001119 RID: 4377 RVA: 0x00007E60 File Offset: 0x00006060
	[Token(Token = "0x170002E4")]
	public virtual FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x1D78680", Offset = "0x1D78781", VA = "0x1D78680", Slot = "119")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x1D78690", Offset = "0x1D78791", VA = "0x1D78690", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x1D788C0", Offset = "0x1D789C1", VA = "0x1D788C0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x1D78A30", Offset = "0x1D78B31", VA = "0x1D78A30", Slot = "120")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x1D78A60", Offset = "0x1D78B61", VA = "0x1D78A60", Slot = "121")]
	public virtual void SetTalkScript(string talkScriptName)
	{
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x1D78AA0", Offset = "0x1D78BA1", VA = "0x1D78AA0")]
	public void SetMobID(int id)
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x1D78AB0", Offset = "0x1D78BB1", VA = "0x1D78AB0", Slot = "76")]
	protected override void UpdateLookIK()
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x1D78D80", Offset = "0x1D78E81", VA = "0x1D78D80", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x1D78EE0", Offset = "0x1D78FE1", VA = "0x1D78EE0", Slot = "41")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x1D790A0", Offset = "0x1D791A1", VA = "0x1D790A0", Slot = "44")]
	protected override void InitAnimator()
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00007E78 File Offset: 0x00006078
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x1D791C0", Offset = "0x1D792C1", VA = "0x1D791C0", Slot = "56")]
	public override float GetRotateSpeed()
	{
		return 0f;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00007E90 File Offset: 0x00006090
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x1D791D0", Offset = "0x1D792D1", VA = "0x1D791D0", Slot = "48")]
	public override bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00007EA8 File Offset: 0x000060A8
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x1D791F0", Offset = "0x1D792F1", VA = "0x1D791F0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x1D781A0", Offset = "0x1D782A1", VA = "0x1D781A0")]
	public void DullJudg()
	{
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x1D79210", Offset = "0x1D79311", VA = "0x1D79210", Slot = "122")]
	public virtual void StartTalk(Character chara)
	{
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x1D79470", Offset = "0x1D79571", VA = "0x1D79470", Slot = "123")]
	public virtual void EndTalk()
	{
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00007EC0 File Offset: 0x000060C0
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x1D79480", Offset = "0x1D79581", VA = "0x1D79480")]
	public bool FadeIn()
	{
		return default(bool);
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00007ED8 File Offset: 0x000060D8
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x1D795C0", Offset = "0x1D796C1", VA = "0x1D795C0")]
	public bool FadeOut()
	{
		return default(bool);
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x1D79700", Offset = "0x1D79801", VA = "0x1D79700")]
	public MobController()
	{
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x1D797D0", Offset = "0x1D798D1", VA = "0x1D797D0", Slot = "107")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x1D797E0", Offset = "0x1D798E1", VA = "0x1D797E0", Slot = "108")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x0")]
	private static MobController.EventMode m_EventMode;

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x4000798")]
	[FieldOffset(Offset = "0x8")]
	private static MobController m_EventOwner;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x4000799")]
	protected const float kTalkRotateAngle = 45f;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x400079A")]
	[FieldOffset(Offset = "0x238")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15EC50", Offset = "0x15ED51")]
	[SerializeField]
	protected CharacterModel m_charaModel;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x400079B")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	protected float m_rotateSpeed;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x400079C")]
	[FieldOffset(Offset = "0x244")]
	[SerializeField]
	protected bool m_isSitting;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x400079D")]
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	protected Alliance m_alliance;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x400079E")]
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	protected string m_talkScriptName;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x400079F")]
	[FieldOffset(Offset = "0x258")]
	private string m_SavetalkScriptName;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40007A0")]
	[FieldOffset(Offset = "0x260")]
	private int mobid;

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40007A1")]
	[FieldOffset(Offset = "0x264")]
	protected MobController.TalkState m_talkState;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40007A2")]
	[FieldOffset(Offset = "0x268")]
	protected Vector3 m_talkDirection;

	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2001012")]
	private enum EventMode
	{
		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x4018E7D")]
		None,
		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x4018E7E")]
		Talk
	}

	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2001013")]
	protected enum TalkState
	{
		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x4018E80")]
		None,
		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x4018E81")]
		Rotate,
		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x4018E82")]
		Loop
	}
}
