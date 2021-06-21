using System;
using Define;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x200021B")]
[Serializable]
public class NpcController : HumanController, InteractionInterface, FocusInterface, ItemInteractionInterface
{
	// Token: 0x06001161 RID: 4449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x1E254E0", Offset = "0x1E255E1", VA = "0x1E254E0", Slot = "99")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x06001162 RID: 4450 RVA: 0x00007FB0 File Offset: 0x000061B0
	// (set) Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E9")]
	public bool Focusable
	{
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x1E254F0", Offset = "0x1E255F1", VA = "0x1E254F0", Slot = "100")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x1E256B0", Offset = "0x1E257B1", VA = "0x1E256B0")]
		private set
		{
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x06001164 RID: 4452 RVA: 0x00007FC8 File Offset: 0x000061C8
	[Token(Token = "0x170002EA")]
	public int FocusPriority
	{
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x1E256C0", Offset = "0x1E257C1", VA = "0x1E256C0", Slot = "104")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x06001165 RID: 4453 RVA: 0x00007FE0 File Offset: 0x000061E0
	[Token(Token = "0x170002EB")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x1E256D0", Offset = "0x1E257D1", VA = "0x1E256D0", Slot = "105")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x1E256E0", Offset = "0x1E257E1", VA = "0x1E256E0", Slot = "98")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06001167 RID: 4455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002EC")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x1E25730", Offset = "0x1E25831", VA = "0x1E25730")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06001168 RID: 4456 RVA: 0x00007FF8 File Offset: 0x000061F8
	// (set) Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002ED")]
	public int NpcTalkStep
	{
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x1E25780", Offset = "0x1E25881", VA = "0x1E25780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C540", Offset = "0x19C641")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x1E25790", Offset = "0x1E25891", VA = "0x1E25790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C550", Offset = "0x19C651")]
		private set
		{
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x0600116A RID: 4458 RVA: 0x00008010 File Offset: 0x00006210
	// (set) Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002EE")]
	public bool IsMotion
	{
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x1E257A0", Offset = "0x1E258A1", VA = "0x1E257A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C560", Offset = "0x19C661")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x1E257B0", Offset = "0x1E258B1", VA = "0x1E257B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C570", Offset = "0x19C671")]
		private set
		{
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x0600116C RID: 4460 RVA: 0x00008028 File Offset: 0x00006228
	// (set) Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002EF")]
	public float CameraDistance
	{
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x1E257C0", Offset = "0x1E258C1", VA = "0x1E257C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C580", Offset = "0x19C681")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x1E257D0", Offset = "0x1E258D1", VA = "0x1E257D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C590", Offset = "0x19C691")]
		private set
		{
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x0600116E RID: 4462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F0")]
	public Transform ItemPoint_Right
	{
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x1E257E0", Offset = "0x1E258E1", VA = "0x1E257E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x0600116F RID: 4463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F1")]
	public Transform ItemPoint_Left
	{
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x1E258B0", Offset = "0x1E259B1", VA = "0x1E258B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F2")]
	public Transform ItemPoint_Floor
	{
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x1E25980", Offset = "0x1E25A81", VA = "0x1E25980")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002F3")]
	public LookAtIK LookAtIK
	{
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x1E25AA0", Offset = "0x1E25BA1", VA = "0x1E25AA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x06001172 RID: 4466 RVA: 0x00008040 File Offset: 0x00006240
	// (set) Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002F4")]
	private NpcController.CVState ChangeVariationState
	{
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x1E25C20", Offset = "0x1E25D21", VA = "0x1E25C20")]
		get
		{
			return NpcController.CVState.WAIT;
		}
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x1E25C30", Offset = "0x1E25D31", VA = "0x1E25C30")]
		set
		{
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06001174 RID: 4468 RVA: 0x00008058 File Offset: 0x00006258
	[Token(Token = "0x170002F5")]
	protected override bool EnableEquipWeaponAndTool
	{
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x1E25C40", Offset = "0x1E25D41", VA = "0x1E25C40", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06001175 RID: 4469 RVA: 0x00008070 File Offset: 0x00006270
	[Token(Token = "0x170002F6")]
	public int AnimIdx
	{
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x1E25C50", Offset = "0x1E25D51", VA = "0x1E25C50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x1E25D00", Offset = "0x1E25E01", VA = "0x1E25D00")]
	public NpcData GetNpcData(int NpcId)
	{
		return null;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x1E25DA0", Offset = "0x1E25EA1", VA = "0x1E25DA0")]
	private void RegistLifecyle()
	{
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x1E25F20", Offset = "0x1E26021", VA = "0x1E25F20", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x1E26200", Offset = "0x1E26301", VA = "0x1E26200", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x1E26610", Offset = "0x1E26711", VA = "0x1E26610", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x1E26640", Offset = "0x1E26741", VA = "0x1E26640")]
	public void InitStandby(int npcId, bool updateSavePosition = true)
	{
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x1E26B00", Offset = "0x1E26C01", VA = "0x1E26B00", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x1E26BC0", Offset = "0x1E26CC1", VA = "0x1E26BC0")]
	public void RunSpeedUp()
	{
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x1E26BD0", Offset = "0x1E26CD1", VA = "0x1E26BD0")]
	public void RunSpeedOrigin()
	{
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x1E26BE0", Offset = "0x1E26CE1", VA = "0x1E26BE0", Slot = "101")]
	public void OnFocus()
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x1E26D20", Offset = "0x1E26E21", VA = "0x1E26D20", Slot = "102")]
	public void OffFocus()
	{
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00008088 File Offset: 0x00006288
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x1E26D30", Offset = "0x1E26E31", VA = "0x1E26D30", Slot = "106")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06001182 RID: 4482 RVA: 0x000080A0 File Offset: 0x000062A0
	// (set) Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002F7")]
	public override bool IsShortPlay
	{
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x1E272A0", Offset = "0x1E273A1", VA = "0x1E272A0", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x1E27360", Offset = "0x1E27461", VA = "0x1E27360", Slot = "31")]
		set
		{
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06001184 RID: 4484 RVA: 0x000080B8 File Offset: 0x000062B8
	// (set) Token: 0x06001185 RID: 4485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002F8")]
	public override bool IsShortPlayMove
	{
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x1E27430", Offset = "0x1E27531", VA = "0x1E27430", Slot = "32")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x1E274D0", Offset = "0x1E275D1", VA = "0x1E274D0", Slot = "33")]
		set
		{
		}
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x1E27570", Offset = "0x1E27671", VA = "0x1E27570")]
	public void InitAction(LifecycleState nextState)
	{
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06001187 RID: 4487 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x170002F9")]
	public Vector3 NpcEyePosition
	{
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x1E27580", Offset = "0x1E27681", VA = "0x1E27580")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06001188 RID: 4488 RVA: 0x000080E8 File Offset: 0x000062E8
	[Token(Token = "0x170002FA")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x1E27660", Offset = "0x1E27761", VA = "0x1E27660", Slot = "103")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x1E27670", Offset = "0x1E27771", VA = "0x1E27670", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x1E26560", Offset = "0x1E26661", VA = "0x1E26560")]
	public void AwakeSpringBone()
	{
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x1E29030", Offset = "0x1E29131", VA = "0x1E29030", Slot = "41")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x1E29B10", Offset = "0x1E29C11", VA = "0x1E29B10", Slot = "40")]
	protected override void LateUpdate()
	{
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x1E29B40", Offset = "0x1E29C41", VA = "0x1E29B40")]
	private void UpdateModelFade()
	{
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x1E29C20", Offset = "0x1E29D21", VA = "0x1E29C20")]
	private void UpdateChangeVariation()
	{
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x1E29EB0", Offset = "0x1E29FB1", VA = "0x1E29EB0")]
	public void FadeNpc(float fadeAlpha)
	{
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x1E28260", Offset = "0x1E28361", VA = "0x1E28260")]
	private void UpdateWithNpcTalk()
	{
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x1E29EC0", Offset = "0x1E29FC1", VA = "0x1E29EC0", Slot = "61")]
	public override void SetGrounderIKWeight(float weight)
	{
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x1E29F80", Offset = "0x1E2A081", VA = "0x1E29F80")]
	public void SetGrounderEnabled(bool enable)
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x1E2A050", Offset = "0x1E2A151", VA = "0x1E2A050")]
	public void ResetGrounderPosition()
	{
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x1E28D00", Offset = "0x1E28E01", VA = "0x1E28D00")]
	private void UpdateLookAtRotation()
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00008100 File Offset: 0x00006300
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x1E2A110", Offset = "0x1E2A211", VA = "0x1E2A110")]
	private bool CheckUpdateFaceAnimationMepati()
	{
		return default(bool);
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x1E28BF0", Offset = "0x1E28CF1", VA = "0x1E28BF0")]
	private void UpdateEyesAnimation()
	{
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x1E293E0", Offset = "0x1E294E1", VA = "0x1E293E0")]
	public void UpdateNpcOnGround()
	{
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00008118 File Offset: 0x00006318
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x1E2A2C0", Offset = "0x1E2A3C1", VA = "0x1E2A2C0")]
	private float GetRaycastHitPointY(Vector3 npcPos)
	{
		return 0f;
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00008130 File Offset: 0x00006330
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x1E2A1E0", Offset = "0x1E2A2E1", VA = "0x1E2A1E0")]
	private float GetDeltaY()
	{
		return 0f;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x1E29270", Offset = "0x1E29371", VA = "0x1E29270")]
	private void UpdateLifeCycleMoving()
	{
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x1E2A460", Offset = "0x1E2A561", VA = "0x1E2A460")]
	public void OverridePositionWithNpcModelPosition()
	{
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x1E27E90", Offset = "0x1E27F91", VA = "0x1E27E90")]
	private void UpdateLocomotionAnimation()
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x1E29E70", Offset = "0x1E29F71", VA = "0x1E29E70")]
	protected void SetAnimationState(int animIdx)
	{
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x1E2A560", Offset = "0x1E2A661", VA = "0x1E2A560")]
	public void OnOrder()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100C")]
	[Address(RVA = "0x1E2A570", Offset = "0x1E2A671", VA = "0x1E2A570")]
	public void OffOrder()
	{
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00008148 File Offset: 0x00006348
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x1E2A580", Offset = "0x1E2A681", VA = "0x1E2A580")]
	public bool CanGrabed(HumanController causer)
	{
		return default(bool);
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00008160 File Offset: 0x00006360
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x1E27060", Offset = "0x1E27161", VA = "0x1E27060", Slot = "95")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x1E2A590", Offset = "0x1E2A691", VA = "0x1E2A590", Slot = "94")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x1E2A900", Offset = "0x1E2AA01", VA = "0x1E2A900")]
	public void RequestChangeModel(VariationNo variationNo)
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x1E26A20", Offset = "0x1E26B21", VA = "0x1E26A20")]
	public void AnimationStart(NpcAnimState animState, bool IsShortPlayCalled)
	{
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x1E2AB20", Offset = "0x1E2AC21", VA = "0x1E2AB20")]
	public void AnimationIdle()
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x1E2A910", Offset = "0x1E2AA11", VA = "0x1E2A910")]
	private void StartAnimationState(NpcAnimState state)
	{
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x1E26BF0", Offset = "0x1E26CF1", VA = "0x1E26BF0")]
	public void PlaySleepVoice()
	{
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00008178 File Offset: 0x00006378
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x1E26E10", Offset = "0x1E26F11", VA = "0x1E26E10", Slot = "110")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x1E2ABC0", Offset = "0x1E2ACC1", VA = "0x1E2ABC0")]
	public void AnimationBlessing()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x1E2AC70", Offset = "0x1E2AD71", VA = "0x1E2AC70", Slot = "112")]
	public virtual void OnCollisionEvent(string str)
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x1E2AC80", Offset = "0x1E2AD81", VA = "0x1E2AC80")]
	public void OnIdle(string str)
	{
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x1E2AD30", Offset = "0x1E2AE31", VA = "0x1E2AD30")]
	private void OnAnimatorIK(int layorIndex)
	{
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x1E2AD40", Offset = "0x1E2AE41", VA = "0x1E2AD40")]
	public void StartWithNpcTalk(NpcData npcData, NpcData targetNpcData)
	{
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x1E2AF00", Offset = "0x1E2B001", VA = "0x1E2AF00")]
	public void Stay(int staySec)
	{
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00008190 File Offset: 0x00006390
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x1E2B020", Offset = "0x1E2B121", VA = "0x1E2B020")]
	public static bool ReceivePresent(int npcId, HumanController reciever, HumanController causer, ItemData itemData, bool isThrow, bool _script = false)
	{
		return default(bool);
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x1E2BB50", Offset = "0x1E2BC51", VA = "0x1E2BB50")]
	private static void RecieveEquipSlot(HumanController reciever, EquipSlotType equipSlotType, ItemData item)
	{
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x1E2C070", Offset = "0x1E2C171", VA = "0x1E2C070")]
	public void ItemConsumption(ItemData itemData, int npcId)
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101F")]
	[Address(RVA = "0x1E2C2E0", Offset = "0x1E2C3E1", VA = "0x1E2C2E0")]
	public void AddLovePoint(int npcID, int itemID, bool isOriginal)
	{
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001020")]
	[Address(RVA = "0x1E2C4D0", Offset = "0x1E2C5D1", VA = "0x1E2C4D0", Slot = "109")]
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x000081A8 File Offset: 0x000063A8
	[Token(Token = "0x6001021")]
	[Address(RVA = "0x1E2C8E0", Offset = "0x1E2C9E1", VA = "0x1E2C8E0")]
	public bool CheckFesPresent(ItemData item)
	{
		return default(bool);
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x000081C0 File Offset: 0x000063C0
	[Token(Token = "0x6001022")]
	[Address(RVA = "0x1E2D220", Offset = "0x1E2D321", VA = "0x1E2D220")]
	private bool CheckLookAtRotation()
	{
		return default(bool);
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x1E28580", Offset = "0x1E28681", VA = "0x1E28580")]
	private void UpdateLookAtIK()
	{
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x1E2D360", Offset = "0x1E2D461", VA = "0x1E2D360")]
	public void ResetLookAtIK()
	{
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x1E2D370", Offset = "0x1E2D471", VA = "0x1E2D370")]
	public void LookAtIKWeightReset()
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x1E2D300", Offset = "0x1E2D401", VA = "0x1E2D300")]
	public void SetNpcLookAtTarget(Transform tr, float speed = 1f)
	{
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x1E2D3F0", Offset = "0x1E2D4F1", VA = "0x1E2D3F0")]
	public void SetNpcLookAtTargetVector(Vector3 target, float speed = 1f)
	{
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000081D8 File Offset: 0x000063D8
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x1E2D3D0", Offset = "0x1E2D4D1", VA = "0x1E2D3D0")]
	private float GetSpeed(float speed)
	{
		return 0f;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x000081F0 File Offset: 0x000063F0
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x1E2D4B0", Offset = "0x1E2D5B1", VA = "0x1E2D4B0", Slot = "111")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x1E2D4C0", Offset = "0x1E2D5C1", VA = "0x1E2D4C0")]
	public void SetModel(GameObject model)
	{
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x1E2D6D0", Offset = "0x1E2D7D1", VA = "0x1E2D6D0")]
	public void SetAnimationUpdateMode(AnimatorUpdateMode mode)
	{
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00008208 File Offset: 0x00006408
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x1E2A500", Offset = "0x1E2A601", VA = "0x1E2A500")]
	private bool IsHighHeight()
	{
		return default(bool);
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00008220 File Offset: 0x00006420
	[Token(Token = "0x600102D")]
	[Address(RVA = "0x1E2A540", Offset = "0x1E2A641", VA = "0x1E2A540")]
	private bool IsLowHeight()
	{
		return default(bool);
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00008238 File Offset: 0x00006438
	[Token(Token = "0x600102E")]
	[Address(RVA = "0x1E2D790", Offset = "0x1E2D891", VA = "0x1E2D790")]
	private float LocomitonDifference()
	{
		return 0f;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600102F")]
	[Address(RVA = "0x1E2BE70", Offset = "0x1E2BF71", VA = "0x1E2BE70")]
	public void PlayEmotionEffect(EmotionType emotionType, float dispTime)
	{
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001030")]
	[Address(RVA = "0x1E2D7F0", Offset = "0x1E2D8F1", VA = "0x1E2D7F0", Slot = "96")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00008250 File Offset: 0x00006450
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x1E2DAD0", Offset = "0x1E2DBD1", VA = "0x1E2DAD0", Slot = "97")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x1E2DC90", Offset = "0x1E2DD91", VA = "0x1E2DC90")]
	public NpcController()
	{
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x1E2DDF0", Offset = "0x1E2DEF1", VA = "0x1E2DDF0", Slot = "107")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x1E2DE00", Offset = "0x1E2DF01", VA = "0x1E2DE00", Slot = "108")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x238")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15ED50", Offset = "0x15EE51")]
	[SerializeField]
	public NPCID m_CharaID;

	// Token: 0x040009CA RID: 2506
	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x23C")]
	[SerializeField]
	public int lookTargetNpcId;

	// Token: 0x040009CB RID: 2507
	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x240")]
	public string focusName;

	// Token: 0x040009CC RID: 2508
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x248")]
	public bool focusable;

	// Token: 0x040009CD RID: 2509
	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x250")]
	[SerializeField]
	private GameObject FocusIcon;

	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x258")]
	[SerializeField]
	public int NpcId;

	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x260")]
	[SerializeField]
	public Transform NpcLookAtTarget;

	// Token: 0x040009D0 RID: 2512
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x268")]
	public Quaternion ShortPlayRotation;

	// Token: 0x040009D1 RID: 2513
	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	public bool animchk;

	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x27C")]
	private float m_Elapsed;

	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x280")]
	private bool Mepati;

	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x284")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EDF0", Offset = "0x15EEF1")]
	private int <NpcTalkStep>k__BackingField;

	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x288")]
	private bool IsOrder;

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x289")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EE00", Offset = "0x15EF01")]
	private bool <IsMotion>k__BackingField;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x28C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EE10", Offset = "0x15EF11")]
	private float <CameraDistance>k__BackingField;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x290")]
	public bool IsFirstTalk;

	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x294")]
	public float RaycastHitPointY;

	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x298")]
	private Transform itemPoint_Right;

	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x2A0")]
	private Transform itemPoint_Left;

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x2A8")]
	private Transform itemPoint_Floor;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x2B0")]
	public Vector3 ItemPoint_Floor_Position;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x2BC")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15EE20", Offset = "0x15EF21")]
	public float HurryMoveSpeed;

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x2C0")]
	public float ShortPlayMoveSpeed;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x2C4")]
	public float ShortPlayLocomotion;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x2C8")]
	public float ShortPlayTargetMoveSpeed;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x2CC")]
	public float ShortPlayTargetLocomotion;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x2D0")]
	public bool IsReached;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x2D1")]
	public bool IsRotate;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	public float lookAtSpeed;

	// Token: 0x040009E6 RID: 2534
	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x2D8")]
	private LookAtIK lookAtIK;

	// Token: 0x040009E7 RID: 2535
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x2E0")]
	private float headWeight;

	// Token: 0x040009E8 RID: 2536
	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0x2E4")]
	private float clampWeightHead;

	// Token: 0x040009E9 RID: 2537
	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x2E8")]
	private Vector3 m_Offset;

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x2F8")]
	private GameObject lookAtGameObject;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x300")]
	public Vector3 lookat;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40007D5")]
	[FieldOffset(Offset = "0x30C")]
	public Vector3 BeforeTransformForward;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40007D6")]
	[FieldOffset(Offset = "0x318")]
	private float EmotionTime;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40007D7")]
	[FieldOffset(Offset = "0x31C")]
	private bool emotion;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40007D8")]
	[FieldOffset(Offset = "0x320")]
	public float npcAnimatorSpeed;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x324")]
	public bool IsHurry;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40007DA")]
	[FieldOffset(Offset = "0x328")]
	private NpcController.CVState _CVState;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40007DB")]
	[FieldOffset(Offset = "0x32C")]
	private VariationNo RequestVariationNo;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40007DC")]
	[FieldOffset(Offset = "0x330")]
	private VariationNo ChangingVariationNo;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x338")]
	private MaterialPropertyBlock materialPropertyBlock;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x340")]
	private SkinnedMeshRenderer[] SkinnedMeshRenderers;

	// Token: 0x040009F6 RID: 2550
	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x348")]
	private float RequestFadeAlpha;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40007E0")]
	[FieldOffset(Offset = "0x34C")]
	public bool Standby;

	// Token: 0x040009F8 RID: 2552
	[Token(Token = "0x40007E1")]
	[FieldOffset(Offset = "0x350")]
	public Vector3 PrevTickPosition;

	// Token: 0x040009F9 RID: 2553
	[Token(Token = "0x40007E2")]
	private const string ANIMIDX_NAME = "AnimIdx";

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x360")]
	private NpcData npcData;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x368")]
	private float SpringBoneSleepTimer;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40007E5")]
	private const float SpringBoneSleepDuration = 1f;

	// Token: 0x040009FD RID: 2557
	[Token(Token = "0x40007E6")]
	private const float SpringBoneAwakeDistance = 400f;

	// Token: 0x040009FE RID: 2558
	[Token(Token = "0x40007E7")]
	[FieldOffset(Offset = "0x36C")]
	private Vector3 m_PrevPosition;

	// Token: 0x040009FF RID: 2559
	[Token(Token = "0x40007E8")]
	[FieldOffset(Offset = "0x378")]
	private Quaternion m_PrevRotation;

	// Token: 0x020002AA RID: 682
	[Token(Token = "0x2001017")]
	private enum CVState
	{
		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4018E8B")]
		WAIT,
		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4018E8C")]
		CHANGING
	}

	// Token: 0x020002AB RID: 683
	[Token(Token = "0x2001018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157300", Offset = "0x157401")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C7F")]
		[Address(RVA = "0x2588450", Offset = "0x2588551", VA = "0x2588450")]
		public <>c()
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C80")]
		[Address(RVA = "0x2588460", Offset = "0x2588561", VA = "0x2588460")]
		internal void <ReceivePresent>b__152_0()
		{
		}

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4018E8D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NpcController.<>c <>9;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4018E8E")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction <>9__152_0;
	}
}
