using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E8 RID: 1512
[Token(Token = "0x2000441")]
public class GimmickSingleSwitch : GimmickBase, InteractionInterface, FocusInterface
{
	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600252A RID: 9514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C8")]
	public GimmickLayoutID[] TargetGimmickLayoutIDs
	{
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x1FE8C30", Offset = "0x1FE8D31", VA = "0x1FE8C30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x1FE8C40", Offset = "0x1FE8D41", VA = "0x1FE8C40")]
		set
		{
		}
	}

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x0600252B RID: 9515 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600252C RID: 9516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004C9")]
	public bool[] TargetValueInverts
	{
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x1FE8C50", Offset = "0x1FE8D51", VA = "0x1FE8C50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x1FE8C60", Offset = "0x1FE8D61", VA = "0x1FE8C60")]
		private set
		{
		}
	}

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x0600252D RID: 9517 RVA: 0x0000EE08 File Offset: 0x0000D008
	// (set) Token: 0x0600252E RID: 9518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004CA")]
	public bool Appear
	{
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x1FE8C70", Offset = "0x1FE8D71", VA = "0x1FE8C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A16A0", Offset = "0x1A17A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x1FE8C80", Offset = "0x1FE8D81", VA = "0x1FE8C80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A16B0", Offset = "0x1A17B1")]
		private set
		{
		}
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F57")]
	[Address(RVA = "0x1FE8C90", Offset = "0x1FE8D91", VA = "0x1FE8C90", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F58")]
	[Address(RVA = "0x1FE8CA0", Offset = "0x1FE8DA1", VA = "0x1FE8CA0", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x06002531 RID: 9521 RVA: 0x0000EE20 File Offset: 0x0000D020
	[Token(Token = "0x170004CB")]
	public bool Focusable
	{
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x1FE9570", Offset = "0x1FE9671", VA = "0x1FE9570", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x06002532 RID: 9522 RVA: 0x0000EE38 File Offset: 0x0000D038
	[Token(Token = "0x170004CC")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x1FE95A0", Offset = "0x1FE96A1", VA = "0x1FE95A0", Slot = "20")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x06002533 RID: 9523 RVA: 0x0000EE50 File Offset: 0x0000D050
	[Token(Token = "0x170004CD")]
	public int FocusPriority
	{
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x1FE95B0", Offset = "0x1FE96B1", VA = "0x1FE95B0", Slot = "21")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x06002534 RID: 9524 RVA: 0x0000EE68 File Offset: 0x0000D068
	[Token(Token = "0x170004CE")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x1FE95C0", Offset = "0x1FE96C1", VA = "0x1FE95C0", Slot = "22")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x0000EE80 File Offset: 0x0000D080
	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x1FE95D0", Offset = "0x1FE96D1", VA = "0x1FE95D0", Slot = "12")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x1FE9640", Offset = "0x1FE9741", VA = "0x1FE9640", Slot = "11")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x1FE96E0", Offset = "0x1FE97E1", VA = "0x1FE96E0", Slot = "16")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x1FE96F0", Offset = "0x1FE97F1", VA = "0x1FE96F0", Slot = "15")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x1FE9700", Offset = "0x1FE9801", VA = "0x1FE9700", Slot = "19")]
	public void OffFocus()
	{
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x1FE9710", Offset = "0x1FE9811", VA = "0x1FE9710", Slot = "18")]
	public void OnFocus()
	{
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x0000EE98 File Offset: 0x0000D098
	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x1FE9720", Offset = "0x1FE9821", VA = "0x1FE9720", Slot = "23")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F64")]
	[Address(RVA = "0x1FE9730", Offset = "0x1FE9831", VA = "0x1FE9730", Slot = "7")]
	public override void SetGimmickState(bool newState)
	{
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x1FE9270", Offset = "0x1FE9371", VA = "0x1FE9270")]
	public void SetSwitchState(bool newState, bool setFlag, bool immediate)
	{
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F66")]
	[Address(RVA = "0x1FE9770", Offset = "0x1FE9871", VA = "0x1FE9770")]
	private void OnDestroyGate(GateController gateEnemy)
	{
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F67")]
	[Address(RVA = "0x1FE9930", Offset = "0x1FE9A31", VA = "0x1FE9930")]
	private void OnDestroyStageEnemy(BossStageManager bossStage)
	{
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F68")]
	[Address(RVA = "0x1FE9800", Offset = "0x1FE9901", VA = "0x1FE9800")]
	private void DecrementWithCheck()
	{
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F69")]
	[Address(RVA = "0x1FE99C0", Offset = "0x1FE9AC1", VA = "0x1FE99C0")]
	private void ApperSwitch()
	{
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x1FE9AD0", Offset = "0x1FE9BD1", VA = "0x1FE9AD0", Slot = "13")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x1FE9AE0", Offset = "0x1FE9BE1", VA = "0x1FE9AE0", Slot = "14")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x1FE9AF0", Offset = "0x1FE9BF1", VA = "0x1FE9AF0")]
	public GimmickSingleSwitch()
	{
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x1FE9C00", Offset = "0x1FE9D01", VA = "0x1FE9C00", Slot = "24")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x1FE9C10", Offset = "0x1FE9D11", VA = "0x1FE9C10", Slot = "25")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x1FE9C20", Offset = "0x1FE9D21", VA = "0x1FE9C20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A16C0", Offset = "0x1A17C1")]
	private void <ApperSwitch>b__45_0()
	{
	}

	// Token: 0x04006C81 RID: 27777
	[Token(Token = "0x40065AD")]
	[FieldOffset(Offset = "0x1E")]
	[SerializeField]
	private bool IsOnce;

	// Token: 0x04006C82 RID: 27778
	[Token(Token = "0x40065AE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject OnVisible;

	// Token: 0x04006C83 RID: 27779
	[Token(Token = "0x40065AF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject OffVisible;

	// Token: 0x04006C84 RID: 27780
	[Token(Token = "0x40065B0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GimmickLayoutID[] _TargetGimmickLayoutIDs;

	// Token: 0x04006C85 RID: 27781
	[Token(Token = "0x40065B1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool[] _TargetValueInverts;

	// Token: 0x04006C86 RID: 27782
	[Token(Token = "0x40065B2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GateController[] TriggerGateControllers;

	// Token: 0x04006C87 RID: 27783
	[Token(Token = "0x40065B3")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> TriggerObjects;

	// Token: 0x04006C88 RID: 27784
	[Token(Token = "0x40065B4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BossStageManager[] TriggerStageManagers;

	// Token: 0x04006C89 RID: 27785
	[Token(Token = "0x40065B5")]
	[FieldOffset(Offset = "0x58")]
	public OnChangeGimmickSwitch OnChangeGimmickSwitch;

	// Token: 0x04006C8A RID: 27786
	[Token(Token = "0x40065B6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected string FoucsNameTextID;

	// Token: 0x04006C8B RID: 27787
	[Token(Token = "0x40065B7")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected string ButtonHintNameTextID;

	// Token: 0x04006C8C RID: 27788
	[Token(Token = "0x40065B8")]
	[FieldOffset(Offset = "0x70")]
	protected string FocusName;

	// Token: 0x04006C8D RID: 27789
	[Token(Token = "0x40065B9")]
	[FieldOffset(Offset = "0x78")]
	protected string ButtonHintName;

	// Token: 0x04006C8E RID: 27790
	[Token(Token = "0x40065BA")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x167600", Offset = "0x167701")]
	private bool <Appear>k__BackingField;
}
