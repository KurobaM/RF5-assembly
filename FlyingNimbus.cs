using System;
using Define;
using Il2CppDummyDll;
using SplineMesh;
using UnityEngine;

// Token: 0x020005C5 RID: 1477
[Token(Token = "0x2000427")]
public class FlyingNimbus : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E84")]
	[Address(RVA = "0x1ECA540", Offset = "0x1ECA641", VA = "0x1ECA540")]
	private void Awake()
	{
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x1ECA640", Offset = "0x1ECA741", VA = "0x1ECA640")]
	private void Start()
	{
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x1ECA650", Offset = "0x1ECA751", VA = "0x1ECA650")]
	private void Update()
	{
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x1ECA7E0", Offset = "0x1ECA8E1", VA = "0x1ECA7E0")]
	private void Update0()
	{
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E88")]
	[Address(RVA = "0x1ECAB10", Offset = "0x1ECAC11", VA = "0x1ECAB10")]
	private void Update1()
	{
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E89")]
	[Address(RVA = "0x1ECAD10", Offset = "0x1ECAE11", VA = "0x1ECAD10")]
	public void SetDirection()
	{
	}

	// Token: 0x170005E6 RID: 1510
	// (get) Token: 0x06002444 RID: 9284 RVA: 0x0000EA90 File Offset: 0x0000CC90
	[Token(Token = "0x170004B8")]
	public bool Focusable
	{
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x1ECAD40", Offset = "0x1ECAE41", VA = "0x1ECAD40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170005E7 RID: 1511
	// (get) Token: 0x06002445 RID: 9285 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
	[Token(Token = "0x170004B9")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x1ECAD50", Offset = "0x1ECAE51", VA = "0x1ECAD50", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x170005E8 RID: 1512
	// (get) Token: 0x06002446 RID: 9286 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
	[Token(Token = "0x170004BA")]
	public int FocusPriority
	{
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x1ECAD60", Offset = "0x1ECAE61", VA = "0x1ECAD60", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x06002447 RID: 9287 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
	[Token(Token = "0x170004BB")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x1ECAD70", Offset = "0x1ECAE71", VA = "0x1ECAD70", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x1ECAD80", Offset = "0x1ECAE81", VA = "0x1ECAD80", Slot = "4")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x1ECAEC0", Offset = "0x1ECAFC1", VA = "0x1ECAEC0", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x1ECAFD0", Offset = "0x1ECB0D1", VA = "0x1ECAFD0", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x1ECB020", Offset = "0x1ECB121", VA = "0x1ECB020", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x1ECB110", Offset = "0x1ECB211", VA = "0x1ECB110", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x1ECB120", Offset = "0x1ECB221", VA = "0x1ECB120", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x0000EB08 File Offset: 0x0000CD08
	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x1ECB130", Offset = "0x1ECB231", VA = "0x1ECB130", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x0000EB20 File Offset: 0x0000CD20
	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x1ECB1B0", Offset = "0x1ECB2B1", VA = "0x1ECB1B0")]
	public ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID)
	{
		return ButtonInteractType.None;
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x0000EB38 File Offset: 0x0000CD38
	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x1ECB1C0", Offset = "0x1ECB2C1", VA = "0x1ECB1C0")]
	private bool CanPuton()
	{
		return default(bool);
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E97")]
	[Address(RVA = "0x1ECADD0", Offset = "0x1ECAED1", VA = "0x1ECADD0")]
	protected void CallScript(string script_name)
	{
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x1ECB1D0", Offset = "0x1ECB2D1", VA = "0x1ECB1D0")]
	public void EnableCollider(bool enable)
	{
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x1ECB280", Offset = "0x1ECB381", VA = "0x1ECB280", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x0000EB50 File Offset: 0x0000CD50
	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x1ECB290", Offset = "0x1ECB391", VA = "0x1ECB290", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E9B")]
	[Address(RVA = "0x1ECB2A0", Offset = "0x1ECB3A1", VA = "0x1ECB2A0")]
	public FlyingNimbus()
	{
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x1ECB380", Offset = "0x1ECB481", VA = "0x1ECB380", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x1ECB390", Offset = "0x1ECB491", VA = "0x1ECB390", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006BB3 RID: 27571
	[Token(Token = "0x400650A")]
	[FieldOffset(Offset = "0x18")]
	public string SpawnerName;

	// Token: 0x04006BB4 RID: 27572
	[Token(Token = "0x400650B")]
	[FieldOffset(Offset = "0x20")]
	public Spline Spline;

	// Token: 0x04006BB5 RID: 27573
	[Token(Token = "0x400650C")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve animationCurve;

	// Token: 0x04006BB6 RID: 27574
	[Token(Token = "0x400650D")]
	[FieldOffset(Offset = "0x30")]
	public FlyingNimbus.MoveType moveType;

	// Token: 0x04006BB7 RID: 27575
	[Token(Token = "0x400650E")]
	[FieldOffset(Offset = "0x34")]
	public float TotalTime;

	// Token: 0x04006BB8 RID: 27576
	[Token(Token = "0x400650F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float CurrentTime;

	// Token: 0x04006BB9 RID: 27577
	[Token(Token = "0x4006510")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x166D30", Offset = "0x166E31")]
	public float LerpValue;

	// Token: 0x04006BBA RID: 27578
	[Token(Token = "0x4006511")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public Vector3 Rotation;

	// Token: 0x04006BBB RID: 27579
	[Token(Token = "0x4006512")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "HideInInspector", RVA = "0x166D90", Offset = "0x166E91")]
	public FlyingNimbus.Status IsStart;

	// Token: 0x04006BBC RID: 27580
	[Token(Token = "0x4006513")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "HideInInspector", RVA = "0x166DA0", Offset = "0x166EA1")]
	public Vector3 ReturnPos;

	// Token: 0x04006BBD RID: 27581
	[Token(Token = "0x4006514")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "HideInInspector", RVA = "0x166DB0", Offset = "0x166EB1")]
	public FlyingNimbusEnter In0;

	// Token: 0x04006BBE RID: 27582
	[Token(Token = "0x4006515")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "HideInInspector", RVA = "0x166DC0", Offset = "0x166EC1")]
	public FlyingNimbusEnter In1;

	// Token: 0x04006BBF RID: 27583
	[Token(Token = "0x4006516")]
	[FieldOffset(Offset = "0x70")]
	public int EnterNo;

	// Token: 0x04006BC0 RID: 27584
	[Token(Token = "0x4006517")]
	[FieldOffset(Offset = "0x74")]
	private float MovedDistance;

	// Token: 0x04006BC1 RID: 27585
	[Token(Token = "0x4006518")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 PrebPoint;

	// Token: 0x04006BC2 RID: 27586
	[Token(Token = "0x4006519")]
	[FieldOffset(Offset = "0x84")]
	private CurveSample Sample;

	// Token: 0x04006BC3 RID: 27587
	[Token(Token = "0x400651A")]
	[FieldOffset(Offset = "0xCC")]
	private Quaternion target_rot;

	// Token: 0x04006BC4 RID: 27588
	[Token(Token = "0x400651B")]
	[FieldOffset(Offset = "0xDC")]
	[Attribute(Name = "HideInInspector", RVA = "0x166DD0", Offset = "0x166ED1")]
	public float MoveSign;

	// Token: 0x04006BC5 RID: 27589
	[Token(Token = "0x400651C")]
	[FieldOffset(Offset = "0xE0")]
	private SphereCollider SphereCollider;

	// Token: 0x04006BC6 RID: 27590
	[Token(Token = "0x400651D")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Vector3 Offset;

	// Token: 0x020005C6 RID: 1478
	[Token(Token = "0x2001127")]
	public enum MoveType
	{
		// Token: 0x04006BC8 RID: 27592
		[Token(Token = "0x401931D")]
		LOOP,
		// Token: 0x04006BC9 RID: 27593
		[Token(Token = "0x401931E")]
		ROUNDTRIP
	}

	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x2001128")]
	public enum Status
	{
		// Token: 0x04006BCB RID: 27595
		[Token(Token = "0x4019320")]
		NONE,
		// Token: 0x04006BCC RID: 27596
		[Token(Token = "0x4019321")]
		START,
		// Token: 0x04006BCD RID: 27597
		[Token(Token = "0x4019322")]
		STOP
	}
}
