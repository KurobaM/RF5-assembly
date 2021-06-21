using System;
using System.Collections.Generic;
using Define;
using Fishing;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x2000046")]
public abstract class AS_ToolController : ActionScriptControllerBase
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000E")]
	public override Character Character
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1FC7D50", Offset = "0x1FC7E51", VA = "0x1FC7D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000113 RID: 275 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x1700000F")]
	public override float Speed
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1FC7E00", Offset = "0x1FC7F01", VA = "0x1FC7E00", Slot = "7")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00002568 File Offset: 0x00000768
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000010")]
	public override float MotionSpeed
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1FC7EF0", Offset = "0x1FC7FF1", VA = "0x1FC7EF0", Slot = "5")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1FC7F00", Offset = "0x1FC8001", VA = "0x1FC7F00", Slot = "6")]
		set
		{
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000011")]
	public virtual HumanController Human
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1FC7F10", Offset = "0x1FC8011", VA = "0x1FC7F10", Slot = "24")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000012")]
	protected string NextActionCodeNameSP
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1FC7FA0", Offset = "0x1FC80A1", VA = "0x1FC7FA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199BB0", Offset = "0x199CB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1FC7FB0", Offset = "0x1FC80B1", VA = "0x1FC7FB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199BC0", Offset = "0x199CC1")]
		set
		{
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000119 RID: 281 RVA: 0x00002580 File Offset: 0x00000780
	// (set) Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000013")]
	public EquipSlotType CurrentSlotType
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1FC7FC0", Offset = "0x1FC80C1", VA = "0x1FC7FC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199BD0", Offset = "0x199CD1")]
		get
		{
			return EquipSlotType.RuneRX;
		}
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1FC7FD0", Offset = "0x1FC80D1", VA = "0x1FC7FD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199BE0", Offset = "0x199CE1")]
		set
		{
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000014")]
	public AS_ToolController.ToolActionData CurrentEquipData
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1FC7FE0", Offset = "0x1FC80E1", VA = "0x1FC7FE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00002598 File Offset: 0x00000798
	// (set) Token: 0x0600011D RID: 285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000015")]
	public ToolChargeLevel CurrentChargeLevel
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1FC8060", Offset = "0x1FC8161", VA = "0x1FC8060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199BF0", Offset = "0x199CF1")]
		get
		{
			return ToolChargeLevel.Level0;
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1FC8070", Offset = "0x1FC8171", VA = "0x1FC8070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C00", Offset = "0x199D01")]
		protected set
		{
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000016")]
	public Func<bool> CanNextCondition
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1FC8080", Offset = "0x1FC8181", VA = "0x1FC8080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C10", Offset = "0x199D11")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1FC8090", Offset = "0x1FC8191", VA = "0x1FC8090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C20", Offset = "0x199D21")]
		set
		{
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000121 RID: 289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000017")]
	public ToolInteractionInterface FarmApproachTarget
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1FC80A0", Offset = "0x1FC81A1", VA = "0x1FC80A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C30", Offset = "0x199D31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1FC80B0", Offset = "0x1FC81B1", VA = "0x1FC80B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C40", Offset = "0x199D41")]
		protected set
		{
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1FC80C0", Offset = "0x1FC81C1", VA = "0x1FC80C0", Slot = "8")]
	protected override void Awake()
	{
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1FC8570", Offset = "0x1FC8671", VA = "0x1FC8570", Slot = "25")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1FC86A0", Offset = "0x1FC87A1", VA = "0x1FC86A0")]
	protected void InitEquipData(EquipSlotType equipSlotType, ItemData itemData, List<ItemEquip> itemEquips)
	{
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1FC8C30", Offset = "0x1FC8D31", VA = "0x1FC8C30")]
	protected void UnEquipData(EquipSlotType equipSlotType)
	{
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1FC8D70", Offset = "0x1FC8E71", VA = "0x1FC8D70", Slot = "10")]
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable)
	{
		return null;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1FC93A0", Offset = "0x1FC94A1", VA = "0x1FC93A0")]
	public void DoMove()
	{
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1FC9480", Offset = "0x1FC9581", VA = "0x1FC9480")]
	private void DoAction(EquipSlotType equipSlotType, string scriptName)
	{
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1FC95A0", Offset = "0x1FC96A1", VA = "0x1FC95A0")]
	public void DoSlotAction(int no)
	{
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1FC9800", Offset = "0x1FC9901", VA = "0x1FC9800", Slot = "12")]
	public override void DoAction(ActionCode actionCode)
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1FCA460", Offset = "0x1FCA561", VA = "0x1FCA460", Slot = "14")]
	public override void GoNext()
	{
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1FCA760", Offset = "0x1FCA861", VA = "0x1FCA760")]
	public void DoActionByFishing(string nextActionCodeName)
	{
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1FCA820", Offset = "0x1FCA921", VA = "0x1FCA820")]
	private void FishingRodAnime(RodAnimation.RodAnime anime)
	{
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1FCA8E0", Offset = "0x1FCA9E1", VA = "0x1FCA8E0")]
	public void DoUniqueActionNPC(string actionscriptName)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1FCA9A0", Offset = "0x1FCAAA1", VA = "0x1FCA9A0", Slot = "13")]
	public override void StopAction()
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1FCB0E0", Offset = "0x1FCB1E1", VA = "0x1FCB0E0")]
	public void DoAvoid(EquipSlotType equipSlotType)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1FCB1C0", Offset = "0x1FCB2C1", VA = "0x1FCB1C0")]
	private void StopCharge()
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1FC85A0", Offset = "0x1FC86A1", VA = "0x1FC85A0")]
	public void ClearAllPush()
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1FCB6E0", Offset = "0x1FCB7E1", VA = "0x1FCB6E0")]
	public int ChargeCount(AS_ToolController.ToolActionData toolActionData)
	{
		return 0;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1FCB7E0", Offset = "0x1FCB8E1", VA = "0x1FCB7E0")]
	public void OnPush(EquipSlotType equipSlotType)
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1FCBE00", Offset = "0x1FCBF01", VA = "0x1FCBE00")]
	public ASExecuteType OnRelease(EquipSlotType equipSlotType)
	{
		return ASExecuteType.NotCharge;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1FCC280", Offset = "0x1FCC381", VA = "0x1FCC280")]
	public bool CheckSkillLevel(ItemCategory itemCategory, int level)
	{
		return default(bool);
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1FCC420", Offset = "0x1FCC521", VA = "0x1FCC420")]
	public void DoMagicRA(EquipSlotType equipSlotType)
	{
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1FCC7A0", Offset = "0x1FCC8A1", VA = "0x1FCC7A0")]
	public void CanNextInitial(CanNextCommand canNextCommand)
	{
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1FCC7B0", Offset = "0x1FCC8B1", VA = "0x1FCC7B0")]
	public void CanNext(CanNextCommand canNextCommand)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1FCCB10", Offset = "0x1FCCC11", VA = "0x1FCCB10")]
	public void MagicCanNextInitial(string nextActionCode)
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1FCCB20", Offset = "0x1FCCC21", VA = "0x1FCCB20")]
	public void MagicCanNext(int slot, string nextActionCode)
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x1FCCDE0", Offset = "0x1FCCEE1", VA = "0x1FCCDE0")]
	public void DoMagicMotion(HumanMagicMotionType motionType, int slot)
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x1FCCFE0", Offset = "0x1FCD0E1", VA = "0x1FCCFE0")]
	public void InputStart()
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1FCD060", Offset = "0x1FCD161", VA = "0x1FCD060")]
	public void InputEnd(InputEndCommand canNextCommand)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1FCD120", Offset = "0x1FCD221", VA = "0x1FCD120")]
	public void CanMove(CanMoveCommand canMoveCommand)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1FCD130", Offset = "0x1FCD231", VA = "0x1FCD130")]
	public void ClearHitList(ClearHitListCommand clearHitListCommand)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1FCD190", Offset = "0x1FCD291", VA = "0x1FCD190")]
	public void OnCollisionTool(OnCollisionToolCommand onCollisionToolCommand)
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1FCD320", Offset = "0x1FCD421", VA = "0x1FCD320")]
	public void OffCollisionTool(OnCollisionToolCommand onCollisionCommand)
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1FCD500", Offset = "0x1FCD601", VA = "0x1FCD500")]
	public void OffCollisionTool(OffCollisionToolCommand offCollisionCommand)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1FCAC50", Offset = "0x1FCAD51", VA = "0x1FCAC50")]
	private void OffCollisionToolForce()
	{
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1FCD760", Offset = "0x1FCD861", VA = "0x1FCD760")]
	public void OnCollisionBox(OnCollisionBoxCommand onCollisionBoxCommand)
	{
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1FCDD20", Offset = "0x1FCDE21", VA = "0x1FCDD20")]
	public void OnCollisionSphere(OnCollisionSphereCommand onCollisionSphereCommand)
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1FCD6A0", Offset = "0x1FCD7A1", VA = "0x1FCD6A0")]
	public void OffCollision()
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1FCE280", Offset = "0x1FCE381", VA = "0x1FCE280")]
	public void PlayToolEffect(int slot, float scale)
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1FCE640", Offset = "0x1FCE741", VA = "0x1FCE640")]
	public void OnPlayToolEffect(int slot)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1FCE650", Offset = "0x1FCE751", VA = "0x1FCE650")]
	public void StopToolEffect(int slot)
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1FCAEB0", Offset = "0x1FCAFB1", VA = "0x1FCAEB0")]
	public void StopToolEffectAll()
	{
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1FCE8A0", Offset = "0x1FCE9A1", VA = "0x1FCE8A0")]
	public void ReleaseNext(SetReleaseNextCommand releaseNextCommand)
	{
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1FCE8F0", Offset = "0x1FCE9F1", VA = "0x1FCE8F0")]
	public void DoFarmAction(FarmActionCommand farmActionCommand)
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1FD18E0", Offset = "0x1FD19E1", VA = "0x1FD18E0")]
	private void SetFarmRange(FarmAction farmAction, FarmRange farmRange)
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1FD1990", Offset = "0x1FD1A91", VA = "0x1FD1990")]
	public void SetFarmRange(SetFarmRangeCommand setFarmRangeCommand)
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1FD1A70", Offset = "0x1FD1B71", VA = "0x1FD1A70")]
	public bool IsFarmTool()
	{
		return default(bool);
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1FD1BB0", Offset = "0x1FD1CB1", VA = "0x1FD1BB0")]
	public bool IsHammer()
	{
		return default(bool);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1FC9BC0", Offset = "0x1FC9CC1", VA = "0x1FC9BC0")]
	public ToolInteractionInterface CheckAndSetFarmRapidActionTarget()
	{
		return null;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1FD1CC0", Offset = "0x1FD1DC1", VA = "0x1FD1CC0")]
	public void OnUseBrush(BrushToolCommand BrushToolCommand)
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1FD1F30", Offset = "0x1FD2031", VA = "0x1FD1F30")]
	public void OnUseScissors(ScissorsToolCommand ScissorsToolCommand)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1FD21A0", Offset = "0x1FD22A1", VA = "0x1FD21A0")]
	public void DamageCheckStart(DamageCheckStartCommand damageCheckStartCommand)
	{
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1FD2320", Offset = "0x1FD2421", VA = "0x1FD2320")]
	public bool DamageCheck(DamageInfo damageInfo)
	{
		return default(bool);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1FD2770", Offset = "0x1FD2871", VA = "0x1FD2770")]
	public void DamageCheckEnd(DamageCheckEndCommand damageCheckEndCommand)
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1FD2830", Offset = "0x1FD2931", VA = "0x1FD2830")]
	public void HitCheckStart(HitCheckStartCommand hitCheckStartCommand)
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1FD2CC0", Offset = "0x1FD2DC1", VA = "0x1FD2CC0")]
	public void HitNext()
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1FD2DB0", Offset = "0x1FD2EB1", VA = "0x1FD2DB0")]
	public void HitCheckEnd(HitCheckEndCommand hitCheckEndCommand)
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1FD2E30", Offset = "0x1FD2F31", VA = "0x1FD2E30", Slot = "23")]
	protected override void Update()
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x1FCB460", Offset = "0x1FCB561", VA = "0x1FCB460")]
	private void StopChargeEffect()
	{
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1FD3B20", Offset = "0x1FD3C21", VA = "0x1FD3B20")]
	private void StopChargeEffect(ToolChargeLevel level)
	{
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1FD38F0", Offset = "0x1FD39F1", VA = "0x1FD38F0")]
	private void PlayChargeEffect(EffectID effectID, ToolChargeLevel level)
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1FCB640", Offset = "0x1FCB741", VA = "0x1FCB640")]
	private void StopChargeSound()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1FD39F0", Offset = "0x1FD3AF1", VA = "0x1FD39F0")]
	private void PlayChargeSound(SoundID soundID)
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1FCBCD0", Offset = "0x1FCBDD1", VA = "0x1FCBCD0")]
	private void ReloadWaterPod()
	{
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1FD3C20", Offset = "0x1FD3D21", VA = "0x1FD3C20")]
	protected AS_ToolController()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1FD3FA0", Offset = "0x1FD40A1", VA = "0x1FD3FA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C50", Offset = "0x199D51")]
	private void <HitCheckStart>b__101_0(Collider other, Vector3 point)
	{
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1FD4060", Offset = "0x1FD4161", VA = "0x1FD4060")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199C60", Offset = "0x199D61")]
	private void <Update>b__104_0(ParticleSystem effect)
	{
	}

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x140")]
	protected Character _Charactor;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x148")]
	protected bool InfluenceActionSpeed;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x14C")]
	private float _MotionSpeed;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x150")]
	public bool IsCanMove;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x158")]
	[Attribute(Name = "HideInInspector", RVA = "0x15B360", Offset = "0x15B461")]
	public List<CharacterBase> m_HitList;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x160")]
	private GameObject m_ColliderObject;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x168")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B370", Offset = "0x15B471")]
	private string <NextActionCodeNameSP>k__BackingField;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x170")]
	public Dictionary<EquipSlotType, AS_ToolController.ToolActionData> m_EquipDatas;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x178")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B380", Offset = "0x15B481")]
	private EquipSlotType <CurrentSlotType>k__BackingField;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x17C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B390", Offset = "0x15B491")]
	private ToolChargeLevel <CurrentChargeLevel>k__BackingField;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x180")]
	private Dictionary<ToolChargeLevel, ParticleSystem> m_ChargeEffects;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x188")]
	private SEController m_ChargeSound;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B3A0", Offset = "0x15B4A1")]
	private Func<bool> <CanNextCondition>k__BackingField;

	// Token: 0x0400011E RID: 286
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x198")]
	protected FocusInterface singleTarget;

	// Token: 0x0400011F RID: 287
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x1A0")]
	protected List<ToolInteractionInterface> multiTargets;

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B3B0", Offset = "0x15B4B1")]
	private ToolInteractionInterface <FarmApproachTarget>k__BackingField;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<FarmAction, SkillActionID[]> ChargeFarmActionDic;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x1B0")]
	private FarmRange SelectedFarmRange;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x1B8")]
	private ToolInteractionInterface RapidFocusedObject;

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x2000F9E")]
	public struct ChargeInfo
	{
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4018CAC")]
		[FieldOffset(Offset = "0x0")]
		public float ChargeSec;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4018CAD")]
		[FieldOffset(Offset = "0x8")]
		public string ScriptName;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4018CAE")]
		[FieldOffset(Offset = "0x10")]
		public EffectID EffectID;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4018CAF")]
		[FieldOffset(Offset = "0x14")]
		public FarmRange FarmRange;
	}

	// Token: 0x0200005C RID: 92
	[Token(Token = "0x2000F9F")]
	public class ToolActionData
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBD")]
		public bool IsPush
		{
			[Token(Token = "0x6006B1C")]
			[Address(RVA = "0x1FD4910", Offset = "0x1FD4A11", VA = "0x1FD4910")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFB70", Offset = "0x1AFC71")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006B1D")]
			[Address(RVA = "0x1FD4920", Offset = "0x1FD4A21", VA = "0x1FD4920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFB80", Offset = "0x1AFC81")]
			set
			{
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1E")]
		[Address(RVA = "0x1FC8460", Offset = "0x1FC8561", VA = "0x1FC8460")]
		public ToolActionData()
		{
		}

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4018CB0")]
		[FieldOffset(Offset = "0x10")]
		public bool IsEnable;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4018CB1")]
		[FieldOffset(Offset = "0x18")]
		public ItemData itemData;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x4018CB2")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemEquip> itemEquips;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x4018CB3")]
		[FieldOffset(Offset = "0x28")]
		public List<AS_ToolController.ChargeInfo> chargeInfoList;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x4018CB4")]
		[FieldOffset(Offset = "0x30")]
		public FarmAction chargeFarmAction;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x4018CB5")]
		[FieldOffset(Offset = "0x34")]
		public float chargeTime;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x4018CB6")]
		[FieldOffset(Offset = "0x38")]
		public ToolChargeLevel ActionChargeLevel;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x4018CB7")]
		[FieldOffset(Offset = "0x40")]
		public string actScriptName;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4018CB8")]
		[FieldOffset(Offset = "0x48")]
		public string avoidScriptName;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4018CB9")]
		[FieldOffset(Offset = "0x50")]
		public MagicID[] magicIDs;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4018CBA")]
		[FieldOffset(Offset = "0x58")]
		public HumanMotionType HumanMotionType;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4018CBB")]
		[FieldOffset(Offset = "0x5C")]
		public int ComboNum;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4018CBC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194DB0", Offset = "0x194EB1")]
		private bool <IsPush>k__BackingField;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4018CBD")]
		[FieldOffset(Offset = "0x61")]
		public bool IsCanNext;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4018CBE")]
		[FieldOffset(Offset = "0x62")]
		public bool IsInputAccept;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4018CBF")]
		[FieldOffset(Offset = "0x64")]
		public int NextPressCount;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4018CC0")]
		[FieldOffset(Offset = "0x68")]
		public int RequestPressCount;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4018CC1")]
		[FieldOffset(Offset = "0x6C")]
		public bool IsDamageCheckAccept;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x4018CC2")]
		[FieldOffset(Offset = "0x6D")]
		public bool IsDamageCheckAcceptAngle;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x4018CC3")]
		[FieldOffset(Offset = "0x70")]
		public float DamageCheckAcceptAngle;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x4018CC4")]
		[FieldOffset(Offset = "0x74")]
		public bool IsHitCheckAccept;
	}

	// Token: 0x0200005D RID: 93
	[Token(Token = "0x2000FA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FC0", Offset = "0x1570C1")]
	private sealed class <>c__DisplayClass107_0
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B1F")]
		[Address(RVA = "0x1FD3C10", Offset = "0x1FD3D11", VA = "0x1FD3C10")]
		public <>c__DisplayClass107_0()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B20")]
		[Address(RVA = "0x1FD4430", Offset = "0x1FD4531", VA = "0x1FD4430")]
		internal void <PlayChargeEffect>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x4018CC5")]
		[FieldOffset(Offset = "0x10")]
		public AS_ToolController <>4__this;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x4018CC6")]
		[FieldOffset(Offset = "0x18")]
		public ToolChargeLevel level;
	}
}
