using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using DG.Tweening;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x020007CF RID: 1999
[Token(Token = "0x2000534")]
public class MonsterControllerBase : Character, GrapInterface, InteractionInterface, FocusInterface, ScissorsInteractionInterface, ToolInteractionInterface, BrushInteractionInterface, ItemInteractionInterface
{
	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x06003388 RID: 13192 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003389 RID: 13193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000591")]
	public MonsterStatusBase MonsterStatus
	{
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x1D88700", Offset = "0x1D88801", VA = "0x1D88700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5040", Offset = "0x1A5141")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x1D88710", Offset = "0x1D88811", VA = "0x1D88710")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5050", Offset = "0x1A5151")]
		set
		{
		}
	}

	// Token: 0x17000723 RID: 1827
	// (get) Token: 0x0600338A RID: 13194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000592")]
	public override CharacterStatusBase Status
	{
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x1D88720", Offset = "0x1D88821", VA = "0x1D88720", Slot = "26")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x000119B8 File Offset: 0x0000FBB8
	[Token(Token = "0x6002ACB")]
	[Address(RVA = "0x1D88730", Offset = "0x1D88831", VA = "0x1D88730", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x000119D0 File Offset: 0x0000FBD0
	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x1D887A0", Offset = "0x1D888A1", VA = "0x1D887A0", Slot = "104")]
	public virtual bool IsCanRestraint()
	{
		return default(bool);
	}

	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x0600338D RID: 13197 RVA: 0x000119E8 File Offset: 0x0000FBE8
	// (set) Token: 0x0600338E RID: 13198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000593")]
	public bool IsRestraintBehaviorTiming
	{
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x1D888B0", Offset = "0x1D889B1", VA = "0x1D888B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5060", Offset = "0x1A5161")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x1D888C0", Offset = "0x1D889C1", VA = "0x1D888C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5070", Offset = "0x1A5171")]
		set
		{
		}
	}

	// Token: 0x17000725 RID: 1829
	// (set) Token: 0x0600338F RID: 13199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000594")]
	public override bool IsShortPlay
	{
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x1D888D0", Offset = "0x1D889D1", VA = "0x1D888D0", Slot = "31")]
		set
		{
		}
	}

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x06003390 RID: 13200 RVA: 0x00011A00 File Offset: 0x0000FC00
	// (set) Token: 0x06003391 RID: 13201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000595")]
	public bool IsRotateLocomotion
	{
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x1D888E0", Offset = "0x1D889E1", VA = "0x1D888E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5080", Offset = "0x1A5181")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x1D888F0", Offset = "0x1D889F1", VA = "0x1D888F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5090", Offset = "0x1A5191")]
		set
		{
		}
	}

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x06003392 RID: 13202 RVA: 0x00011A18 File Offset: 0x0000FC18
	// (set) Token: 0x06003393 RID: 13203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000596")]
	public MonsterType MonsterType
	{
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x1D88900", Offset = "0x1D88A01", VA = "0x1D88900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50A0", Offset = "0x1A51A1")]
		get
		{
			return MonsterType.NONE;
		}
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x1D88910", Offset = "0x1D88A11", VA = "0x1D88910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50B0", Offset = "0x1A51B1")]
		private set
		{
		}
	}

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x06003395 RID: 13205 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003394 RID: 13204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000597")]
	public GameObject ModelObject
	{
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x1D88930", Offset = "0x1D88A31", VA = "0x1D88930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50D0", Offset = "0x1A51D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x1D88920", Offset = "0x1D88A21", VA = "0x1D88920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50C0", Offset = "0x1A51C1")]
		protected set
		{
		}
	}

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x06003396 RID: 13206 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003397 RID: 13207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000598")]
	public MonsterModel MonsterModel
	{
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x1D88940", Offset = "0x1D88A41", VA = "0x1D88940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50E0", Offset = "0x1A51E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x1D88950", Offset = "0x1D88A51", VA = "0x1D88950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A50F0", Offset = "0x1A51F1")]
		protected set
		{
		}
	}

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x06003398 RID: 13208 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003399 RID: 13209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000599")]
	public MonsterSoulController SoulController
	{
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x1D88960", Offset = "0x1D88A61", VA = "0x1D88960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5100", Offset = "0x1A5201")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x1D88970", Offset = "0x1D88A71", VA = "0x1D88970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5110", Offset = "0x1A5211")]
		protected set
		{
		}
	}

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x0600339A RID: 13210 RVA: 0x00011A30 File Offset: 0x0000FC30
	[Token(Token = "0x1700059A")]
	public override bool IsBattleMode
	{
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x1D88980", Offset = "0x1D88A81", VA = "0x1D88980", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x0600339B RID: 13211 RVA: 0x00011A48 File Offset: 0x0000FC48
	// (set) Token: 0x0600339C RID: 13212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700059B")]
	public float BehaviorWaitRate
	{
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x1D88990", Offset = "0x1D88A91", VA = "0x1D88990")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5120", Offset = "0x1A5221")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x1D889A0", Offset = "0x1D88AA1", VA = "0x1D889A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5130", Offset = "0x1A5231")]
		protected set
		{
		}
	}

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x0600339D RID: 13213 RVA: 0x00011A60 File Offset: 0x0000FC60
	// (set) Token: 0x0600339E RID: 13214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700059C")]
	protected MonsterControllerBase.State CurrentState
	{
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x1D889B0", Offset = "0x1D88AB1", VA = "0x1D889B0")]
		get
		{
			return MonsterControllerBase.State.None;
		}
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x1D889C0", Offset = "0x1D88AC1", VA = "0x1D889C0")]
		set
		{
		}
	}

	// Token: 0x0600339F RID: 13215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x1D88A20", Offset = "0x1D88B21", VA = "0x1D88A20", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x060033A0 RID: 13216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x1D88EC0", Offset = "0x1D88FC1", VA = "0x1D88EC0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x060033A1 RID: 13217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x1D88FC0", Offset = "0x1D890C1", VA = "0x1D88FC0", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x060033A2 RID: 13218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x1D893A0", Offset = "0x1D894A1", VA = "0x1D893A0", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x060033A3 RID: 13219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x1D89580", Offset = "0x1D89681", VA = "0x1D89580")]
	public void SetMonsterType(MonsterType monsterType)
	{
	}

	// Token: 0x060033A4 RID: 13220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x1D7F990", Offset = "0x1D7FA91", VA = "0x1D7F990")]
	public void SetModelObject(GameObject model)
	{
	}

	// Token: 0x060033A5 RID: 13221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x1D897C0", Offset = "0x1D898C1", VA = "0x1D897C0")]
	private void CreateEffectPoint()
	{
	}

	// Token: 0x060033A6 RID: 13222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x1D8A030", Offset = "0x1D8A131", VA = "0x1D8A030", Slot = "105")]
	public virtual void OnSetupBehavior(MonsterEventReceiverInterface receiver)
	{
	}

	// Token: 0x060033A7 RID: 13223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x1D8A040", Offset = "0x1D8A141", VA = "0x1D8A040", Slot = "106")]
	public virtual void SetupActionScript()
	{
	}

	// Token: 0x060033A8 RID: 13224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x1D8A1F0", Offset = "0x1D8A2F1", VA = "0x1D8A1F0", Slot = "107")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5140", Offset = "0x1A5241")]
	public virtual IEnumerator SetupAsync([Optional] Action callBack)
	{
		return null;
	}

	// Token: 0x060033A9 RID: 13225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AE9")]
	[Address(RVA = "0x1D8A290", Offset = "0x1D8A391", VA = "0x1D8A290", Slot = "108")]
	public virtual void SetupAnimator(RuntimeAnimatorController runtimeAnimatorController, Avatar avatar)
	{
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AEA")]
	[Address(RVA = "0x1D8A7F0", Offset = "0x1D8A8F1", VA = "0x1D8A7F0", Slot = "109")]
	public virtual void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x1D8AAD0", Offset = "0x1D8ABD1", VA = "0x1D8AAD0", Slot = "110")]
	public virtual void SetMonsterData(MonsterDataTable monsterDataTable)
	{
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x1D8AB20", Offset = "0x1D8AC21", VA = "0x1D8AB20")]
	public void SummonedFromEvent()
	{
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x1D8AB30", Offset = "0x1D8AC31", VA = "0x1D8AB30", Slot = "111")]
	protected virtual void SetupData()
	{
	}

	// Token: 0x060033AE RID: 13230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x1D8A870", Offset = "0x1D8A971", VA = "0x1D8A870")]
	private void SetupMovementSpeed()
	{
	}

	// Token: 0x060033AF RID: 13231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x1D8AC20", Offset = "0x1D8AD21", VA = "0x1D8AC20", Slot = "112")]
	protected virtual void OnUpdateState()
	{
	}

	// Token: 0x060033B0 RID: 13232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x1D8AD00", Offset = "0x1D8AE01", VA = "0x1D8AD00", Slot = "113")]
	protected virtual void OnTakeDamage(bool isDamage, ref DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x00011A78 File Offset: 0x0000FC78
	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x1D7EAF0", Offset = "0x1D7EBF1", VA = "0x1D7EAF0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF2")]
	[Address(RVA = "0x1D8AF20", Offset = "0x1D8B021", VA = "0x1D8AF20", Slot = "114")]
	protected virtual void OnDead(Character damageCauser, DamageResult damageResult)
	{
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x1D8B260", Offset = "0x1D8B361", VA = "0x1D8B260", Slot = "42")]
	public override void PlayMotion(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x060033B4 RID: 13236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x1D8B3B0", Offset = "0x1D8B4B1", VA = "0x1D8B3B0", Slot = "43")]
	public override void RePlayMotion(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x1D8B500", Offset = "0x1D8B601", VA = "0x1D8B500", Slot = "13")]
	public override void ResetAnimator()
	{
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF6")]
	[Address(RVA = "0x1D88F60", Offset = "0x1D89061", VA = "0x1D88F60")]
	public void ResetAnimatorParam()
	{
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x1D8B510", Offset = "0x1D8B611", VA = "0x1D8B510")]
	private void UpdateMove_CanBehindRotateAnimationParam()
	{
	}

	// Token: 0x060033B8 RID: 13240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x1D8B690", Offset = "0x1D8B791", VA = "0x1D8B690", Slot = "45")]
	protected override void UpdateLocomotion(float deltaTime)
	{
	}

	// Token: 0x060033B9 RID: 13241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x1D8B8F0", Offset = "0x1D8B9F1", VA = "0x1D8B8F0", Slot = "46")]
	protected override void SetLocomotion(float value)
	{
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AFA")]
	[Address(RVA = "0x1D892D0", Offset = "0x1D893D1", VA = "0x1D892D0")]
	private void UpdateJumpAnimation()
	{
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AFB")]
	[Address(RVA = "0x1D8B950", Offset = "0x1D8BA51", VA = "0x1D8B950", Slot = "115")]
	protected virtual void OnSetupMonsterAnimationEvent(MonsterAnimatorStateEvent monsterAnimatorStateEvent)
	{
	}

	// Token: 0x060033BC RID: 13244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x1D8A420", Offset = "0x1D8A521", VA = "0x1D8A420")]
	protected void SetupMonsterAnimationEvent()
	{
	}

	// Token: 0x060033BD RID: 13245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x1D8BB20", Offset = "0x1D8BC21", VA = "0x1D8BB20")]
	public void ResetNavMeshAgent()
	{
	}

	// Token: 0x060033BE RID: 13246 RVA: 0x00011A90 File Offset: 0x0000FC90
	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x1D8BC50", Offset = "0x1D8BD51", VA = "0x1D8BC50", Slot = "53")]
	protected override float GetMoveSpeedMax()
	{
		return 0f;
	}

	// Token: 0x060033BF RID: 13247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x1D89590", Offset = "0x1D89691", VA = "0x1D89590")]
	public void RegistCollider()
	{
	}

	// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x1D8BDD0", Offset = "0x1D8BED1", VA = "0x1D8BDD0")]
	public void SetEnableCollider(bool isEnable)
	{
	}

	// Token: 0x060033C1 RID: 13249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x1D8BFB0", Offset = "0x1D8C0B1", VA = "0x1D8BFB0")]
	public void SetAllBodyPartsCollisionOverlap(bool isCanNotPlayerOverlap)
	{
	}

	// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x1D8C0C0", Offset = "0x1D8C1C1", VA = "0x1D8C0C0")]
	private void BodyPartsOverlap(BodyPartsCollision bodyPartsCollision, Collider other)
	{
	}

	// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x1D7F610", Offset = "0x1D7F711", VA = "0x1D7F610")]
	public void EndActionScript()
	{
	}

	// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x1D89220", Offset = "0x1D89321", VA = "0x1D89220")]
	private void UpdateActionScript()
	{
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B05")]
	[Address(RVA = "0x1D8C250", Offset = "0x1D8C351", VA = "0x1D8C250", Slot = "116")]
	protected virtual void OnResetActionScriptAction()
	{
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B06")]
	[Address(RVA = "0x1D8C2E0", Offset = "0x1D8C3E1", VA = "0x1D8C2E0", Slot = "117")]
	protected virtual void OnUpdateActionScriptAction()
	{
	}

	// Token: 0x060033C7 RID: 13255 RVA: 0x00011AA8 File Offset: 0x0000FCA8
	[Token(Token = "0x6002B07")]
	[Address(RVA = "0x1D8C560", Offset = "0x1D8C661", VA = "0x1D8C560")]
	public bool DoDropHandcuffsDrop()
	{
		return default(bool);
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B08")]
	[Address(RVA = "0x1D8C6B0", Offset = "0x1D8C7B1", VA = "0x1D8C6B0", Slot = "118")]
	protected virtual MonsterControllerBase.DropItemDataParameter GetHandCuffsDropItem()
	{
		return null;
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B09")]
	[Address(RVA = "0x1D8CC00", Offset = "0x1D8CD01", VA = "0x1D8CC00", Slot = "119")]
	protected virtual void CalcDropItem()
	{
	}

	// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B0A")]
	[Address(RVA = "0x1D8D070", Offset = "0x1D8D171", VA = "0x1D8D070", Slot = "120")]
	protected virtual List<MonsterControllerBase.DropItemDataParameter> GetDoropItemList()
	{
		return null;
	}

	// Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x1D8D080", Offset = "0x1D8D181", VA = "0x1D8D080", Slot = "121")]
	protected virtual MonsterControllerBase.DropItemDataParameter GetOmakeDropItem()
	{
		return null;
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x1D8D300", Offset = "0x1D8D401", VA = "0x1D8D300", Slot = "122")]
	protected virtual void DoDropItem()
	{
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x1D8D840", Offset = "0x1D8D941", VA = "0x1D8D840", Slot = "123")]
	public virtual void ShortPlay()
	{
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x1D8D860", Offset = "0x1D8D961", VA = "0x1D8D860", Slot = "124")]
	public virtual void ShortPlayExit()
	{
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B0F")]
	[Address(RVA = "0x1D7F700", Offset = "0x1D7F801", VA = "0x1D7F700")]
	public void StartFade(MonsterControllerBase.FadeType fadeType, float duration, bool isBetween = false, [Optional] Action endCallback)
	{
	}

	// Token: 0x060033D0 RID: 13264 RVA: 0x00011AC0 File Offset: 0x0000FCC0
	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x1D8DA40", Offset = "0x1D8DB41", VA = "0x1D8DA40")]
	public bool StartDamageBlow(Vector3 direction)
	{
		return default(bool);
	}

	// Token: 0x060033D1 RID: 13265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B11")]
	[Address(RVA = "0x1D8DB90", Offset = "0x1D8DC91", VA = "0x1D8DB90")]
	public void DoJump(Vector3 endValue, float jumpPower, int numJumps, float duration, Ease ease = Ease.OutQuad, [Optional] Action setup, [Optional] Action callback, [Optional] AnimationCurve customEase)
	{
	}

	// Token: 0x060033D2 RID: 13266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B12")]
	[Address(RVA = "0x1D8ADF0", Offset = "0x1D8AEF1", VA = "0x1D8ADF0")]
	private void StartShake(float duration, float strangth, int vibrato)
	{
	}

	// Token: 0x060033D3 RID: 13267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B13")]
	[Address(RVA = "0x1D8DDB0", Offset = "0x1D8DEB1", VA = "0x1D8DDB0")]
	private void EndShake()
	{
	}

	// Token: 0x060033D4 RID: 13268 RVA: 0x00011AD8 File Offset: 0x0000FCD8
	[Token(Token = "0x6002B14")]
	[Address(RVA = "0x1D8AA00", Offset = "0x1D8AB01", VA = "0x1D8AA00")]
	protected float GetBehaviorWaitRate()
	{
		return 0f;
	}

	// Token: 0x060033D5 RID: 13269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x1D8DE00", Offset = "0x1D8DF01", VA = "0x1D8DE00", Slot = "125")]
	protected virtual void OnSetModelObject(GameObject model)
	{
	}

	// Token: 0x060033D6 RID: 13270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B16")]
	[Address(RVA = "0x1D8DE10", Offset = "0x1D8DF11", VA = "0x1D8DE10", Slot = "126")]
	protected virtual void OnSetup()
	{
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B17")]
	[Address(RVA = "0x1D8DE20", Offset = "0x1D8DF21", VA = "0x1D8DE20", Slot = "127")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A51B0", Offset = "0x1A52B1")]
	protected virtual IEnumerator OnSetupAsync()
	{
		return null;
	}

	// Token: 0x060033D8 RID: 13272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B18")]
	[Address(RVA = "0x1D8DE80", Offset = "0x1D8DF81", VA = "0x1D8DE80", Slot = "128")]
	protected virtual void OnDeadEvent()
	{
	}

	// Token: 0x060033D9 RID: 13273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B19")]
	[Address(RVA = "0x1D86020", Offset = "0x1D86121", VA = "0x1D86020")]
	public void OnDestroyBehavior()
	{
	}

	// Token: 0x060033DA RID: 13274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B1A")]
	[Address(RVA = "0x1D8E050", Offset = "0x1D8E151", VA = "0x1D8E050", Slot = "64")]
	public override void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x060033DB RID: 13275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B1B")]
	[Address(RVA = "0x1D8E1D0", Offset = "0x1D8E2D1", VA = "0x1D8E1D0", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x060033DC RID: 13276 RVA: 0x00011AF0 File Offset: 0x0000FCF0
	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x1D8E280", Offset = "0x1D8E381", VA = "0x1D8E280", Slot = "65")]
	public override bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060033DD RID: 13277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x1D8E350", Offset = "0x1D8E451", VA = "0x1D8E350", Slot = "66")]
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x060033DE RID: 13278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x1D8E710", Offset = "0x1D8E811", VA = "0x1D8E710", Slot = "67")]
	public override void OnStopDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x1D8E760", Offset = "0x1D8E861", VA = "0x1D8E760", Slot = "68")]
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x1D8EAB0", Offset = "0x1D8EBB1", VA = "0x1D8EAB0", Slot = "70")]
	public override void OnLanding()
	{
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x1D8EB70", Offset = "0x1D8EC71", VA = "0x1D8EB70")]
	private void OnEndAnimEventDeadState()
	{
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B22")]
	[Address(RVA = "0x1D8EC70", Offset = "0x1D8ED71", VA = "0x1D8EC70")]
	private void OnEndAnimEventDamageState()
	{
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B23")]
	[Address(RVA = "0x1D8ED80", Offset = "0x1D8EE81", VA = "0x1D8ED80", Slot = "129")]
	protected virtual void OnEndAnimEventGetupState()
	{
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x1D8EE90", Offset = "0x1D8EF91", VA = "0x1D8EE90")]
	private void OnEndAnimEventJumpStartState()
	{
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B25")]
	[Address(RVA = "0x1D8EFA0", Offset = "0x1D8F0A1", VA = "0x1D8EFA0")]
	private void OnEndAnimEventJumpEndState()
	{
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x1D8F0B0", Offset = "0x1D8F1B1", VA = "0x1D8F0B0")]
	protected void OnEndAnimMadnessState()
	{
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B27")]
	[Address(RVA = "0x1D8F1C0", Offset = "0x1D8F2C1", VA = "0x1D8F1C0")]
	private void OnEndHappyState()
	{
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x1D8F2D0", Offset = "0x1D8F3D1", VA = "0x1D8F2D0")]
	private void OnEndWait_2State()
	{
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B29")]
	[Address(RVA = "0x1D8F3E0", Offset = "0x1D8F4E1", VA = "0x1D8F3E0")]
	private void OnEndAnimEventSleepStartState()
	{
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2A")]
	[Address(RVA = "0x1D8F4F0", Offset = "0x1D8F5F1", VA = "0x1D8F4F0")]
	private void OnEndAnimEventSleepEndState()
	{
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2B")]
	[Address(RVA = "0x1D8F600", Offset = "0x1D8F701", VA = "0x1D8F600", Slot = "130")]
	public virtual void OnSetBodyPartsType(BodyPartsCollision bodyPartsCollision)
	{
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2C")]
	[Address(RVA = "0x1D8F610", Offset = "0x1D8F711", VA = "0x1D8F610", Slot = "131")]
	protected virtual void OnRegistCollider()
	{
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2D")]
	[Address(RVA = "0x1D8F620", Offset = "0x1D8F721", VA = "0x1D8F620", Slot = "132")]
	public virtual void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2E")]
	[Address(RVA = "0x1D8F630", Offset = "0x1D8F731", VA = "0x1D8F630", Slot = "133")]
	public virtual void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x1D8F640", Offset = "0x1D8F741", VA = "0x1D8F640")]
	protected void OnEndAction()
	{
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B30")]
	[Address(RVA = "0x1D8F760", Offset = "0x1D8F861", VA = "0x1D8F760", Slot = "134")]
	public virtual void OnRestraint()
	{
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B31")]
	[Address(RVA = "0x1D8F890", Offset = "0x1D8F991", VA = "0x1D8F890", Slot = "135")]
	public virtual void OnRelease()
	{
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B32")]
	[Address(RVA = "0x1D8F980", Offset = "0x1D8FA81", VA = "0x1D8F980", Slot = "136")]
	protected virtual void OnHit(CharacterBase characterBase, int actionIndex)
	{
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B33")]
	[Address(RVA = "0x1D8FA40", Offset = "0x1D8FB41", VA = "0x1D8FA40")]
	public void OnHearFootSteps()
	{
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B34")]
	[Address(RVA = "0x1D8FB00", Offset = "0x1D8FC01", VA = "0x1D8FB00", Slot = "57")]
	public override void StartBattleMode()
	{
	}

	// Token: 0x060033F5 RID: 13301 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B35")]
	[Address(RVA = "0x1D8FB10", Offset = "0x1D8FC11", VA = "0x1D8FB10", Slot = "58")]
	public override void EndBattleMode()
	{
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x1D8FB20", Offset = "0x1D8FC21", VA = "0x1D8FB20")]
	public void Avoid()
	{
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x1D8FB30", Offset = "0x1D8FC31", VA = "0x1D8FB30")]
	public void Attack()
	{
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B38")]
	[Address(RVA = "0x1D8FBC0", Offset = "0x1D8FCC1", VA = "0x1D8FBC0")]
	public void ChargeStart()
	{
	}

	// Token: 0x060033F9 RID: 13305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x1D8FBD0", Offset = "0x1D8FCD1", VA = "0x1D8FBD0")]
	public void ChargeEnd()
	{
	}

	// Token: 0x060033FA RID: 13306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x1D8FBE0", Offset = "0x1D8FCE1", VA = "0x1D8FBE0")]
	public void ItemHold()
	{
	}

	// Token: 0x060033FB RID: 13307 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3B")]
	[Address(RVA = "0x1D8FBF0", Offset = "0x1D8FCF1", VA = "0x1D8FBF0")]
	public void PickUpOnGroundItem(HoldableInterface item)
	{
	}

	// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3C")]
	[Address(RVA = "0x1D8FC00", Offset = "0x1D8FD01", VA = "0x1D8FC00")]
	public void PutOnGroundItem()
	{
	}

	// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3D")]
	[Address(RVA = "0x1D8FC10", Offset = "0x1D8FD11", VA = "0x1D8FC10")]
	public void ThrowItem()
	{
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x1D8FC20", Offset = "0x1D8FD21", VA = "0x1D8FC20")]
	public void PutInItem()
	{
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B3F")]
	[Address(RVA = "0x1D8FC30", Offset = "0x1D8FD31", VA = "0x1D8FC30")]
	public void UseItem()
	{
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x1D8FC40", Offset = "0x1D8FD41", VA = "0x1D8FC40")]
	public void RuneAbility(int index)
	{
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x1D8FCF0", Offset = "0x1D8FDF1", VA = "0x1D8FCF0", Slot = "137")]
	protected virtual void StartActionScript(string actionScriptName)
	{
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x1D8FD70", Offset = "0x1D8FE71", VA = "0x1D8FD70", Slot = "138")]
	public virtual void StartActionScript(int actionIndex)
	{
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x1D8FE50", Offset = "0x1D8FF51", VA = "0x1D8FE50")]
	public void StartActionBaseScript(int actionIndex)
	{
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x1D8FF30", Offset = "0x1D90031", VA = "0x1D8FF30")]
	private void DeadEvent()
	{
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x1D90090", Offset = "0x1D90191", VA = "0x1D90090", Slot = "139")]
	public virtual void OnFinishDeadEvent()
	{
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x1D86750", Offset = "0x1D86851", VA = "0x1D86750")]
	public void ExecuteOnFinishDead()
	{
	}

	// Token: 0x06003407 RID: 13319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B47")]
	[Address(RVA = "0x1D900F0", Offset = "0x1D901F1", VA = "0x1D900F0")]
	public void DeadActionEvent()
	{
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x1D90480", Offset = "0x1D90581", VA = "0x1D90480", Slot = "140")]
	protected virtual void OnStartClearFadeOut()
	{
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x1D878F0", Offset = "0x1D879F1", VA = "0x1D878F0")]
	public void StartClearFadeOut(Action callBack)
	{
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x1D90490", Offset = "0x1D90591", VA = "0x1D90490", Slot = "20")]
	public override void OnEvent(int index)
	{
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B4B")]
	[Address(RVA = "0x1D904C0", Offset = "0x1D905C1", VA = "0x1D904C0", Slot = "21")]
	public override void OnEvent(int index, int param)
	{
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x00011B08 File Offset: 0x0000FD08
	[Token(Token = "0x6002B4C")]
	[Address(RVA = "0x1D88780", Offset = "0x1D88881", VA = "0x1D88780")]
	public bool IsFadeing()
	{
		return default(bool);
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00011B20 File Offset: 0x0000FD20
	[Token(Token = "0x6002B4D")]
	[Address(RVA = "0x1D90500", Offset = "0x1D90601", VA = "0x1D90500")]
	protected bool IsFadeIn()
	{
		return default(bool);
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x00011B38 File Offset: 0x0000FD38
	[Token(Token = "0x6002B4E")]
	[Address(RVA = "0x1D90510", Offset = "0x1D90611", VA = "0x1D90510")]
	protected bool IsFadeOut()
	{
		return default(bool);
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B4F")]
	[Address(RVA = "0x1D89E50", Offset = "0x1D89F51", VA = "0x1D89E50")]
	protected void SetupFade()
	{
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B50")]
	[Address(RVA = "0x1D89480", Offset = "0x1D89581", VA = "0x1D89480")]
	protected void ClearFadeParameter()
	{
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B51")]
	[Address(RVA = "0x1D90720", Offset = "0x1D90821", VA = "0x1D90720")]
	private void InvokeEndCallback()
	{
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B52")]
	[Address(RVA = "0x1D90530", Offset = "0x1D90631", VA = "0x1D90530")]
	protected void EachMaterial(Action<Material> action)
	{
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B53")]
	[Address(RVA = "0x1D90770", Offset = "0x1D90871", VA = "0x1D90770")]
	protected void SetEnableDither(Material material, bool enable)
	{
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B54")]
	[Address(RVA = "0x1D90860", Offset = "0x1D90961", VA = "0x1D90860")]
	protected void SetEnableDitherAlpha(Material material, bool enable)
	{
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B55")]
	[Address(RVA = "0x1D8D880", Offset = "0x1D8D981", VA = "0x1D8D880")]
	protected void OnStartFade(MonsterControllerBase.FadeType fadeType, float duration, bool isBetween, [Optional] Action endCallback)
	{
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B56")]
	[Address(RVA = "0x1D890E0", Offset = "0x1D891E1", VA = "0x1D890E0")]
	protected void OnUpdateFadeing()
	{
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B57")]
	[Address(RVA = "0x1D90950", Offset = "0x1D90A51", VA = "0x1D90950")]
	private void EndFade()
	{
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x00011B50 File Offset: 0x0000FD50
	[Token(Token = "0x6002B58")]
	[Address(RVA = "0x1D909F0", Offset = "0x1D90AF1", VA = "0x1D909F0", Slot = "56")]
	public override float GetRotateSpeed()
	{
		return 0f;
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B59")]
	[Address(RVA = "0x1D909C0", Offset = "0x1D90AC1", VA = "0x1D909C0")]
	public void StopFade()
	{
	}

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600341B RID: 13339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700059D")]
	protected LookAtIK LookAtIK
	{
		[Token(Token = "0x6002B5A")]
		[Address(RVA = "0x1D90A00", Offset = "0x1D90B01", VA = "0x1D90A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5220", Offset = "0x1A5321")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B5B")]
		[Address(RVA = "0x1D90A10", Offset = "0x1D90B11", VA = "0x1D90A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5230", Offset = "0x1A5331")]
		set
		{
		}
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B5C")]
	[Address(RVA = "0x1D89FD0", Offset = "0x1D8A0D1", VA = "0x1D89FD0")]
	protected void SetupFinalIK()
	{
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B5D")]
	[Address(RVA = "0x1D89390", Offset = "0x1D89491", VA = "0x1D89390")]
	protected void UpdateFinalIK()
	{
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B5E")]
	[Address(RVA = "0x1D90A20", Offset = "0x1D90B21", VA = "0x1D90A20")]
	private void UpdateLookAtIK()
	{
	}

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x0600341F RID: 13343 RVA: 0x00011B68 File Offset: 0x0000FD68
	// (set) Token: 0x06003420 RID: 13344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700059E")]
	public bool IsCanGrapple
	{
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x1D90C40", Offset = "0x1D90D41", VA = "0x1D90C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5240", Offset = "0x1A5341")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x1D90C50", Offset = "0x1D90D51", VA = "0x1D90C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5250", Offset = "0x1A5351")]
		private set
		{
		}
	}

	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x06003421 RID: 13345 RVA: 0x00011B80 File Offset: 0x0000FD80
	// (set) Token: 0x06003422 RID: 13346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700059F")]
	public bool IsGrappled
	{
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x1D90C60", Offset = "0x1D90D61", VA = "0x1D90C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5260", Offset = "0x1A5361")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B62")]
		[Address(RVA = "0x1D90C70", Offset = "0x1D90D71", VA = "0x1D90C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5270", Offset = "0x1A5371")]
		private set
		{
		}
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B63")]
	[Address(RVA = "0x1D90C80", Offset = "0x1D90D81", VA = "0x1D90C80")]
	public void SetActiveGrappled(bool isActive)
	{
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x00011B98 File Offset: 0x0000FD98
	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x1D90CA0", Offset = "0x1D90DA1", VA = "0x1D90CA0", Slot = "141")]
	public virtual bool CanGrap(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x1D90E40", Offset = "0x1D90F41", VA = "0x1D90E40", Slot = "142")]
	public virtual void OnGrap()
	{
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x00011BB0 File Offset: 0x0000FDB0
	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x1D90FD0", Offset = "0x1D910D1", VA = "0x1D90FD0", Slot = "143")]
	public virtual bool DoGrap(HumanController humanController)
	{
		return default(bool);
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x00011BC8 File Offset: 0x0000FDC8
	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x1D91110", Offset = "0x1D91211", VA = "0x1D91110", Slot = "76")]
	public bool OnThrow(Vector3 direction, float power)
	{
		return default(bool);
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x1D91370", Offset = "0x1D91471", VA = "0x1D91370")]
	private void EndThrow()
	{
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x00011BE0 File Offset: 0x0000FDE0
	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x1D913E0", Offset = "0x1D914E1", VA = "0x1D913E0", Slot = "144")]
	public virtual bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo)
	{
		return default(bool);
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x00011BF8 File Offset: 0x0000FDF8
	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x1D916B0", Offset = "0x1D917B1", VA = "0x1D916B0", Slot = "78")]
	public bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo1, DamageInfo damageInfo2)
	{
		return default(bool);
	}

	// Token: 0x0600342B RID: 13355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x1D91870", Offset = "0x1D91971", VA = "0x1D91870", Slot = "145")]
	protected virtual void TakeThrowDamage()
	{
	}

	// Token: 0x0600342C RID: 13356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x1D91A70", Offset = "0x1D91B71", VA = "0x1D91A70")]
	private void TakeThrowImpactDamage()
	{
	}

	// Token: 0x0600342D RID: 13357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B6D")]
	[Address(RVA = "0x1D92190", Offset = "0x1D92291", VA = "0x1D92190", Slot = "80")]
	public void UpdatePosition(Vector3 position, Vector3 foward, float rate)
	{
	}

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x0600342E RID: 13358 RVA: 0x00011C10 File Offset: 0x0000FE10
	[Token(Token = "0x170005A0")]
	public Vector3 CurrentPosition
	{
		[Token(Token = "0x6002B6E")]
		[Address(RVA = "0x1D924C0", Offset = "0x1D925C1", VA = "0x1D924C0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x0600342F RID: 13359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x1D924F0", Offset = "0x1D925F1", VA = "0x1D924F0", Slot = "82")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x06003430 RID: 13360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x1D927C0", Offset = "0x1D928C1", VA = "0x1D927C0")]
	public void OnRide(ActorID actorID = ActorID.None)
	{
	}

	// Token: 0x06003431 RID: 13361 RVA: 0x00011C28 File Offset: 0x0000FE28
	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x1D92B80", Offset = "0x1D92C81", VA = "0x1D92B80", Slot = "83")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06003432 RID: 13362 RVA: 0x00011C40 File Offset: 0x0000FE40
	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x1D92E90", Offset = "0x1D92F91", VA = "0x1D92E90")]
	private bool IsParty()
	{
		return default(bool);
	}

	// Token: 0x06003433 RID: 13363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x1D92EC0", Offset = "0x1D92FC1", VA = "0x1D92EC0", Slot = "86")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06003434 RID: 13364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x1D92F10", Offset = "0x1D93011", VA = "0x1D92F10", Slot = "146")]
	public virtual string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x06003435 RID: 13365 RVA: 0x00011C58 File Offset: 0x0000FE58
	// (set) Token: 0x06003436 RID: 13366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005A1")]
	public bool Focusable
	{
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x1D92F40", Offset = "0x1D93041", VA = "0x1D92F40", Slot = "88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5280", Offset = "0x1A5381")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x1D92F50", Offset = "0x1D93051", VA = "0x1D92F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5290", Offset = "0x1A5391")]
		private set
		{
		}
	}

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x06003437 RID: 13367 RVA: 0x00011C70 File Offset: 0x0000FE70
	[Token(Token = "0x170005A2")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x1D92F60", Offset = "0x1D93061", VA = "0x1D92F60", Slot = "91")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x06003438 RID: 13368 RVA: 0x00011C88 File Offset: 0x0000FE88
	[Token(Token = "0x170005A3")]
	public int FocusPriority
	{
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x1D92F90", Offset = "0x1D93091", VA = "0x1D92F90", Slot = "92")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x06003439 RID: 13369 RVA: 0x00011CA0 File Offset: 0x0000FEA0
	[Token(Token = "0x170005A4")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x1D92FA0", Offset = "0x1D930A1", VA = "0x1D92FA0", Slot = "93")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x0600343A RID: 13370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B7A")]
	[Address(RVA = "0x1D92FB0", Offset = "0x1D930B1", VA = "0x1D92FB0", Slot = "89")]
	public void OnFocus()
	{
	}

	// Token: 0x0600343B RID: 13371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B7B")]
	[Address(RVA = "0x1D92FC0", Offset = "0x1D930C1", VA = "0x1D92FC0", Slot = "90")]
	public void OffFocus()
	{
	}

	// Token: 0x0600343C RID: 13372 RVA: 0x00011CB8 File Offset: 0x0000FEB8
	[Token(Token = "0x6002B7C")]
	[Address(RVA = "0x1D92FD0", Offset = "0x1D930D1", VA = "0x1D92FD0", Slot = "94")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600343D RID: 13373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x1D93130", Offset = "0x1D93231", VA = "0x1D93130", Slot = "84")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x0600343E RID: 13374 RVA: 0x00011CD0 File Offset: 0x0000FED0
	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x1D93140", Offset = "0x1D93241", VA = "0x1D93140", Slot = "85")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x0600343F RID: 13375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x1D93150", Offset = "0x1D93251", VA = "0x1D93150")]
	public void SetMoveAction_MaxSpeed(float speed)
	{
	}

	// Token: 0x06003440 RID: 13376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x1D93160", Offset = "0x1D93261", VA = "0x1D93160")]
	public void SetMoveAction_MinSpeed(float speed)
	{
	}

	// Token: 0x06003441 RID: 13377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B81")]
	[Address(RVA = "0x1D93170", Offset = "0x1D93271", VA = "0x1D93170")]
	protected void SetMoveSpeedActionScript(float rate = 1f)
	{
	}

	// Token: 0x06003442 RID: 13378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B82")]
	[Address(RVA = "0x1D93180", Offset = "0x1D93281", VA = "0x1D93180", Slot = "147")]
	protected virtual void OnResetMoveActionScript()
	{
	}

	// Token: 0x06003443 RID: 13379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B83")]
	[Address(RVA = "0x1D931A0", Offset = "0x1D932A1", VA = "0x1D931A0")]
	protected void OnStartMoveActionScript()
	{
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B84")]
	[Address(RVA = "0x1D8C310", Offset = "0x1D8C411", VA = "0x1D8C310")]
	protected void OnUpdateMoveActionScript()
	{
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x00011CE8 File Offset: 0x0000FEE8
	[Token(Token = "0x6002B85")]
	[Address(RVA = "0x1D93320", Offset = "0x1D93421", VA = "0x1D93320")]
	public float EaseOutExpo(float s, float e, float t)
	{
		return 0f;
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B86")]
	[Address(RVA = "0x1D934C0", Offset = "0x1D935C1", VA = "0x1D934C0")]
	public void OnEndMoveActionScript()
	{
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B87")]
	[Address(RVA = "0x1D933C0", Offset = "0x1D934C1", VA = "0x1D933C0")]
	protected void MoveNavMeshAgent(Vector3 velocity)
	{
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B88")]
	[Address(RVA = "0x1D8C2A0", Offset = "0x1D8C3A1", VA = "0x1D8C2A0")]
	protected void OnResetRotateActionScript()
	{
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B89")]
	[Address(RVA = "0x1D93570", Offset = "0x1D93671", VA = "0x1D93570", Slot = "148")]
	protected virtual void OnUpdateRotateActionScript()
	{
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x00011D00 File Offset: 0x0000FF00
	[Token(Token = "0x6002B8A")]
	[Address(RVA = "0x1D93800", Offset = "0x1D93901", VA = "0x1D93800", Slot = "149")]
	public virtual bool DoUseScissors(out float size)
	{
		return default(bool);
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x00011D18 File Offset: 0x0000FF18
	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x1D93860", Offset = "0x1D93961", VA = "0x1D93860", Slot = "150")]
	public virtual bool CanUseScissors(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x0600344C RID: 13388 RVA: 0x00011D30 File Offset: 0x0000FF30
	// (set) Token: 0x0600344D RID: 13389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005A5")]
	public bool CanReciveItemBehaviorTiming
	{
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x1D93870", Offset = "0x1D93971", VA = "0x1D93870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A52A0", Offset = "0x1A53A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x1D93880", Offset = "0x1D93981", VA = "0x1D93880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A52B0", Offset = "0x1A53B1")]
		set
		{
		}
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x00011D48 File Offset: 0x0000FF48
	[Token(Token = "0x6002B8E")]
	[Address(RVA = "0x1D93890", Offset = "0x1D93991", VA = "0x1D93890", Slot = "151")]
	protected virtual bool CanReciveItem()
	{
		return default(bool);
	}

	// Token: 0x0600344F RID: 13391 RVA: 0x00011D60 File Offset: 0x0000FF60
	[Token(Token = "0x6002B8F")]
	[Address(RVA = "0x1D938A0", Offset = "0x1D939A1", VA = "0x1D938A0", Slot = "152")]
	protected virtual bool CanFriend()
	{
		return default(bool);
	}

	// Token: 0x17000737 RID: 1847
	// (get) Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003451 RID: 13393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005A6")]
	public MonsterTameRateController MonsterTameRateController
	{
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x1D93920", Offset = "0x1D93A21", VA = "0x1D93920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A52C0", Offset = "0x1A53C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x1D93930", Offset = "0x1D93A31", VA = "0x1D93930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A52D0", Offset = "0x1A53D1")]
		protected set
		{
		}
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x1D88E30", Offset = "0x1D88F31", VA = "0x1D88E30")]
	private void SetupMonsterTameRateController()
	{
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x00011D78 File Offset: 0x0000FF78
	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x1D93940", Offset = "0x1D93A41", VA = "0x1D93940")]
	private bool CanFriendApprouch()
	{
		return default(bool);
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x1D8AF00", Offset = "0x1D8B001", VA = "0x1D8AF00")]
	public void UpdateTameRateTakeDamage(ref DamageResult result)
	{
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x00011D90 File Offset: 0x0000FF90
	[Token(Token = "0x6002B95")]
	[Address(RVA = "0x1D93AD0", Offset = "0x1D93BD1", VA = "0x1D93AD0", Slot = "100")]
	public bool CanUseBrush(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00011DA8 File Offset: 0x0000FFA8
	[Token(Token = "0x6002B96")]
	[Address(RVA = "0x1D7DF70", Offset = "0x1D7E071", VA = "0x1D7DF70")]
	protected float GetSizeRate()
	{
		return 0f;
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x00011DC0 File Offset: 0x0000FFC0
	[Token(Token = "0x6002B97")]
	[Address(RVA = "0x1D93B30", Offset = "0x1D93C31", VA = "0x1D93B30", Slot = "99")]
	public bool DoUseBrush(out float size)
	{
		return default(bool);
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B98")]
	[Address(RVA = "0x1D93F00", Offset = "0x1D94001", VA = "0x1D93F00", Slot = "153")]
	protected virtual void OnUseItem(ItemData item)
	{
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B99")]
	[Address(RVA = "0x1D93F40", Offset = "0x1D94041", VA = "0x1D93F40")]
	private void DoItemPresent(HumanStatus humanstatus, ItemData item)
	{
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B9A")]
	[Address(RVA = "0x1D94430", Offset = "0x1D94531", VA = "0x1D94430", Slot = "101")]
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002B9B")]
	[Address(RVA = "0x1D94660", Offset = "0x1D94761", VA = "0x1D94660")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A52E0", Offset = "0x1A53E1")]
	private IEnumerator WaitEffectDoFriend(HumanStatus humanStatus)
	{
		return null;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002B9C")]
	[Address(RVA = "0x1D94700", Offset = "0x1D94801", VA = "0x1D94700")]
	private void DoFriend(HumanStatus humanStatus)
	{
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x00011DD8 File Offset: 0x0000FFD8
	[Token(Token = "0x6002B9D")]
	[Address(RVA = "0x1D93120", Offset = "0x1D93221", VA = "0x1D93120", Slot = "102")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x00011DF0 File Offset: 0x0000FFF0
	[Token(Token = "0x6002B9E")]
	[Address(RVA = "0x1D948E0", Offset = "0x1D949E1", VA = "0x1D948E0", Slot = "103")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x0600345F RID: 13407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005A7")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x1D948F0", Offset = "0x1D949F1", VA = "0x1D948F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA0")]
	[Address(RVA = "0x1D94290", Offset = "0x1D94391", VA = "0x1D94290")]
	public void PlayEmotionEffect(EmotionType emotionType, [Optional] Action callBack)
	{
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA1")]
	[Address(RVA = "0x1D93EB0", Offset = "0x1D93FB1", VA = "0x1D93EB0")]
	public void PlayEmotionNoteTypeEffect([Optional] Action callBack)
	{
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA2")]
	[Address(RVA = "0x1D7F190", Offset = "0x1D7F291", VA = "0x1D7F190")]
	public MonsterControllerBase()
	{
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BA4")]
	[Address(RVA = "0x1D94990", Offset = "0x1D94A91", VA = "0x1D94990", Slot = "95")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BA5")]
	[Address(RVA = "0x1D949A0", Offset = "0x1D94AA1", VA = "0x1D949A0", Slot = "96")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x06003466 RID: 13414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA6")]
	[Address(RVA = "0x1D949B0", Offset = "0x1D94AB1", VA = "0x1D949B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5350", Offset = "0x1A5451")]
	private void <SetupFade>b__193_0(Material material)
	{
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x1D94AC0", Offset = "0x1D94BC1", VA = "0x1D94AC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5360", Offset = "0x1A5461")]
	private void <OnUpdateFadeing>b__200_0(Material material)
	{
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x1D94BA0", Offset = "0x1D94CA1", VA = "0x1D94BA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5370", Offset = "0x1A5471")]
	private void <OnUpdateFadeing>b__200_1(Material material)
	{
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x1D94C80", Offset = "0x1D94D81", VA = "0x1D94C80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5380", Offset = "0x1A5481")]
	private void <WaitEffectDoFriend>b__311_0(string name)
	{
	}

	// Token: 0x040077E8 RID: 30696
	[Token(Token = "0x4006CFD")]
	private const float SHAKE_TIME = 0.2f;

	// Token: 0x040077E9 RID: 30697
	[Token(Token = "0x4006CFE")]
	private const float SHAKE_STRANGTH = 0.1f;

	// Token: 0x040077EA RID: 30698
	[Token(Token = "0x4006CFF")]
	private const int SHAKE_VIBRATO = 115;

	// Token: 0x040077EB RID: 30699
	[Token(Token = "0x4006D00")]
	protected const float DROPITEMRANGE = 1.5f;

	// Token: 0x040077EC RID: 30700
	[Token(Token = "0x4006D01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169D90", Offset = "0x169E91")]
	private MonsterStatusBase <MonsterStatus>k__BackingField;

	// Token: 0x040077ED RID: 30701
	[Token(Token = "0x4006D02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DA0", Offset = "0x169EA1")]
	private bool <IsRestraintBehaviorTiming>k__BackingField;

	// Token: 0x040077EE RID: 30702
	[Token(Token = "0x4006D03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DB0", Offset = "0x169EB1")]
	private bool <IsRotateLocomotion>k__BackingField;

	// Token: 0x040077EF RID: 30703
	[Token(Token = "0x4006D04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DC0", Offset = "0x169EC1")]
	private MonsterType <MonsterType>k__BackingField;

	// Token: 0x040077F0 RID: 30704
	[Token(Token = "0x4006D05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DD0", Offset = "0x169ED1")]
	private GameObject <ModelObject>k__BackingField;

	// Token: 0x040077F1 RID: 30705
	[Token(Token = "0x4006D06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DE0", Offset = "0x169EE1")]
	private MonsterModel <MonsterModel>k__BackingField;

	// Token: 0x040077F2 RID: 30706
	[Token(Token = "0x4006D07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169DF0", Offset = "0x169EF1")]
	private MonsterSoulController <SoulController>k__BackingField;

	// Token: 0x040077F3 RID: 30707
	[Token(Token = "0x4006D08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E00", Offset = "0x169F01")]
	private float <BehaviorWaitRate>k__BackingField;

	// Token: 0x040077F4 RID: 30708
	[Token(Token = "0x4006D09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
	private MonsterControllerBase.State _CurrentState;

	// Token: 0x040077F5 RID: 30709
	[Token(Token = "0x4006D0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public MonsterDataTable MonsterDataTable;

	// Token: 0x040077F6 RID: 30710
	[Token(Token = "0x4006D0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public MonsterBehaviorDataTable MonsterBehaviorDataTable;

	// Token: 0x040077F7 RID: 30711
	[Token(Token = "0x4006D0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public MonsterDropItemDataTable MonsterDropItemDataTable;

	// Token: 0x040077F8 RID: 30712
	[Token(Token = "0x4006D0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public MonsterYieldItemDataTable MonsterYieldItemDataTable;

	// Token: 0x040077F9 RID: 30713
	[Token(Token = "0x4006D0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public MonsterActionScriptsController ActionScriptsController;

	// Token: 0x040077FA RID: 30714
	[Token(Token = "0x4006D0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public List<Collider> BodyColliderList;

	// Token: 0x040077FB RID: 30715
	[Token(Token = "0x4006D10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public OnDeadMonster OnFinishDead;

	// Token: 0x040077FC RID: 30716
	[Token(Token = "0x4006D11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	protected MonsterEventReceiverInterface Receiver;

	// Token: 0x040077FD RID: 30717
	[Token(Token = "0x4006D12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private Vector3 PrevTickPosition;

	// Token: 0x040077FE RID: 30718
	[Token(Token = "0x4006D13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	protected List<BodyPartsCollision> BodyPartsCollisionList;

	// Token: 0x040077FF RID: 30719
	[Token(Token = "0x4006D14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private bool ExistRotateAnimatorParam;

	// Token: 0x04007800 RID: 30720
	[Token(Token = "0x4006D15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x301")]
	private bool IsDamageActionDeadAnimation;

	// Token: 0x04007801 RID: 30721
	[Token(Token = "0x4006D16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x302")]
	private bool IsHandcuffsDroped;

	// Token: 0x04007802 RID: 30722
	[Token(Token = "0x4006D17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	private Action OnStopBlow;

	// Token: 0x04007803 RID: 30723
	[Token(Token = "0x4006D18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private Tweener shake;

	// Token: 0x04007804 RID: 30724
	[Token(Token = "0x4006D19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private List<MonsterControllerBase.DropItemDataParameter> DropItemDataParameterList;

	// Token: 0x04007805 RID: 30725
	[Token(Token = "0x4006D1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	protected string FocusName;

	// Token: 0x04007806 RID: 30726
	[Token(Token = "0x4006D1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	protected bool _IsBattleMode;

	// Token: 0x04007807 RID: 30727
	[Token(Token = "0x4006D1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	private Sequence DOJumpSequence;

	// Token: 0x04007808 RID: 30728
	[Token(Token = "0x4006D1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	protected bool IsSummonedFromEvent;

	// Token: 0x04007809 RID: 30729
	[Token(Token = "0x4006D1E")]
	private const float DeadFadeTime = 0.25f;

	// Token: 0x0400780A RID: 30730
	[Token(Token = "0x4006D1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	protected List<SkinnedMeshRenderer> SkinnedMeshRendererList;

	// Token: 0x0400780B RID: 30731
	[Token(Token = "0x4006D20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	protected List<Material> MaterialList;

	// Token: 0x0400780C RID: 30732
	[Token(Token = "0x4006D21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	private float Timer;

	// Token: 0x0400780D RID: 30733
	[Token(Token = "0x4006D22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x354")]
	private float Duration;

	// Token: 0x0400780E RID: 30734
	[Token(Token = "0x4006D23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	private float AlphaLerp;

	// Token: 0x0400780F RID: 30735
	[Token(Token = "0x4006D24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	private float FadeStartParam;

	// Token: 0x04007810 RID: 30736
	[Token(Token = "0x4006D25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private Action EndCallback;

	// Token: 0x04007811 RID: 30737
	[Token(Token = "0x4006D26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private MonsterControllerBase.FadeType _FadeType;

	// Token: 0x04007812 RID: 30738
	[Token(Token = "0x4006D27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x169E10", Offset = "0x169F11")]
	public float LookAtSpeed;

	// Token: 0x04007813 RID: 30739
	[Token(Token = "0x4006D28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private float WeightValue;

	// Token: 0x04007814 RID: 30740
	[Token(Token = "0x4006D29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	protected bool IsLookTarget;

	// Token: 0x04007815 RID: 30741
	[Token(Token = "0x4006D2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E50", Offset = "0x169F51")]
	private LookAtIK <LookAtIK>k__BackingField;

	// Token: 0x04007816 RID: 30742
	[Token(Token = "0x4006D2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	private DamageInfo m_ThrowDamageInfo1;

	// Token: 0x04007817 RID: 30743
	[Token(Token = "0x4006D2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	private DamageInfo m_ThrowDamageInfo2;

	// Token: 0x04007818 RID: 30744
	[Token(Token = "0x4006D2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E60", Offset = "0x169F61")]
	private bool <IsCanGrapple>k__BackingField;

	// Token: 0x04007819 RID: 30745
	[Token(Token = "0x4006D2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x481")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E70", Offset = "0x169F71")]
	private bool <IsGrappled>k__BackingField;

	// Token: 0x0400781A RID: 30746
	[Token(Token = "0x4006D2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	public Action<bool> OnThrowEvent;

	// Token: 0x0400781B RID: 30747
	[Token(Token = "0x4006D30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 MonsterGrappleOffset;

	// Token: 0x0400781C RID: 30748
	[Token(Token = "0x4006D31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E80", Offset = "0x169F81")]
	private bool <Focusable>k__BackingField;

	// Token: 0x0400781D RID: 30749
	[Token(Token = "0x4006D32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x494")]
	[NonSerialized]
	public MonsterControllerBase.MoveActionScriptState MoveAction_CurrentScriptState;

	// Token: 0x0400781E RID: 30750
	[Token(Token = "0x4006D33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	[NonSerialized]
	private float MoveAction_MaxSpeed;

	// Token: 0x0400781F RID: 30751
	[Token(Token = "0x4006D34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49C")]
	[NonSerialized]
	private float MoveAction_MinSpeed;

	// Token: 0x04007820 RID: 30752
	[Token(Token = "0x4006D35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	[NonSerialized]
	public float MoveAction_EasingTime;

	// Token: 0x04007821 RID: 30753
	[Token(Token = "0x4006D36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A4")]
	[NonSerialized]
	public bool MoveAction_IsNotRotate;

	// Token: 0x04007822 RID: 30754
	[Token(Token = "0x4006D37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A5")]
	[NonSerialized]
	public bool MoveAction_IsInversionVector;

	// Token: 0x04007823 RID: 30755
	[Token(Token = "0x4006D38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	private float MoveAction_T;

	// Token: 0x04007824 RID: 30756
	[Token(Token = "0x4006D39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	private float MoveAction_EasingSpeed;

	// Token: 0x04007825 RID: 30757
	[Token(Token = "0x4006D3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	protected float MoveAction_CurrentSpeed;

	// Token: 0x04007826 RID: 30758
	[Token(Token = "0x4006D3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B4")]
	protected Vector3 MoveAction_CurrentVelocity;

	// Token: 0x04007827 RID: 30759
	[Token(Token = "0x4006D3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	private Vector3 StartDirection;

	// Token: 0x04007828 RID: 30760
	[Token(Token = "0x4006D3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4CC")]
	private float Rate;

	// Token: 0x04007829 RID: 30761
	[Token(Token = "0x4006D3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[NonSerialized]
	public bool RotateAction_IsRotate;

	// Token: 0x0400782A RID: 30762
	[Token(Token = "0x4006D3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D4")]
	[NonSerialized]
	public float RatateAction_SpeedScale;

	// Token: 0x0400782B RID: 30763
	[Token(Token = "0x4006D40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	[NonSerialized]
	public bool RotateAction_IsInversionVector;

	// Token: 0x0400782C RID: 30764
	[Token(Token = "0x4006D41")]
	private const float SizeRateSmall = 0f;

	// Token: 0x0400782D RID: 30765
	[Token(Token = "0x4006D42")]
	private const float SizeRateMiddle = 0.5f;

	// Token: 0x0400782E RID: 30766
	[Token(Token = "0x4006D43")]
	private const float SizeRateLarge = 1f;

	// Token: 0x0400782F RID: 30767
	[Token(Token = "0x4006D44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169E90", Offset = "0x169F91")]
	private bool <CanReciveItemBehaviorTiming>k__BackingField;

	// Token: 0x04007830 RID: 30768
	[Token(Token = "0x4006D45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x169EA0", Offset = "0x169FA1")]
	private MonsterTameRateController <MonsterTameRateController>k__BackingField;

	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x2001220")]
	protected enum State
	{
		// Token: 0x04007832 RID: 30770
		[Token(Token = "0x4019751")]
		None,
		// Token: 0x04007833 RID: 30771
		[Token(Token = "0x4019752")]
		Create,
		// Token: 0x04007834 RID: 30772
		[Token(Token = "0x4019753")]
		Active,
		// Token: 0x04007835 RID: 30773
		[Token(Token = "0x4019754")]
		Dead
	}

	// Token: 0x020007D1 RID: 2001
	[Token(Token = "0x2001221")]
	protected enum DropItemType
	{
		// Token: 0x04007837 RID: 30775
		[Token(Token = "0x4019756")]
		Default,
		// Token: 0x04007838 RID: 30776
		[Token(Token = "0x4019757")]
		Bonus,
		// Token: 0x04007839 RID: 30777
		[Token(Token = "0x4019758")]
		HandCuffs
	}

	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x2001222")]
	protected class DropItemDataParameter
	{
		// Token: 0x0600346A RID: 13418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0x1E5E0A0", Offset = "0x1E5E1A1", VA = "0x1E5E0A0")]
		public DropItemDataParameter(MonsterControllerBase.DropItemType dropItemType, ItemData itemData)
		{
		}

		// Token: 0x0400783A RID: 30778
		[Token(Token = "0x4019759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase.DropItemType DropItemType;

		// Token: 0x0400783B RID: 30779
		[Token(Token = "0x401975A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ItemData ItemData;
	}

	// Token: 0x020007D3 RID: 2003
	[Token(Token = "0x2001223")]
	public enum FadeType
	{
		// Token: 0x0400783D RID: 30781
		[Token(Token = "0x401975C")]
		FadeIn,
		// Token: 0x0400783E RID: 30782
		[Token(Token = "0x401975D")]
		FadeIn_End,
		// Token: 0x0400783F RID: 30783
		[Token(Token = "0x401975E")]
		FadeOut,
		// Token: 0x04007840 RID: 30784
		[Token(Token = "0x401975F")]
		FadeOut_End
	}

	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x2001224")]
	public enum MoveActionScriptState
	{
		// Token: 0x04007842 RID: 30786
		[Token(Token = "0x4019761")]
		None,
		// Token: 0x04007843 RID: 30787
		[Token(Token = "0x4019762")]
		Init,
		// Token: 0x04007844 RID: 30788
		[Token(Token = "0x4019763")]
		Init_ChangeMoveSpeed,
		// Token: 0x04007845 RID: 30789
		[Token(Token = "0x4019764")]
		Update,
		// Token: 0x04007846 RID: 30790
		[Token(Token = "0x4019765")]
		End
	}

	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x2001225")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A70", Offset = "0x158B71")]
	private sealed class <SetupAsync>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600346B RID: 13419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073AA")]
		[Address(RVA = "0x1E5DC30", Offset = "0x1E5DD31", VA = "0x1E5DC30")]
		[DebuggerHidden]
		public <SetupAsync>d__80(int <>1__state)
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073AB")]
		[Address(RVA = "0x1E5DC60", Offset = "0x1E5DD61", VA = "0x1E5DC60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x60073AC")]
		[Address(RVA = "0x1E5DC70", Offset = "0x1E5DD71", VA = "0x1E5DC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4E")]
		private object Current
		{
			[Token(Token = "0x60073AD")]
			[Address(RVA = "0x1E5DD90", Offset = "0x1E5DE91", VA = "0x1E5DD90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073AE")]
		[Address(RVA = "0x1E5DDA0", Offset = "0x1E5DEA1", VA = "0x1E5DDA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D4F")]
		private object Current
		{
			[Token(Token = "0x60073AF")]
			[Address(RVA = "0x1E5DE00", Offset = "0x1E5DF01", VA = "0x1E5DE00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007847 RID: 30791
		[Token(Token = "0x4019766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007848 RID: 30792
		[Token(Token = "0x4019767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007849 RID: 30793
		[Token(Token = "0x4019768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterControllerBase <>4__this;

		// Token: 0x0400784A RID: 30794
		[Token(Token = "0x4019769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;
	}

	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x2001226")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A80", Offset = "0x158B81")]
	private sealed class <>c__DisplayClass121_0
	{
		// Token: 0x06003471 RID: 13425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B0")]
		[Address(RVA = "0x1E5D700", Offset = "0x1E5D801", VA = "0x1E5D700")]
		public <>c__DisplayClass121_0()
		{
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B1")]
		[Address(RVA = "0x1E5D710", Offset = "0x1E5D811", VA = "0x1E5D710")]
		internal void <DoJump>b__0()
		{
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B2")]
		[Address(RVA = "0x1E5D770", Offset = "0x1E5D871", VA = "0x1E5D770")]
		internal void <DoJump>b__1()
		{
		}

		// Token: 0x0400784B RID: 30795
		[Token(Token = "0x401976A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase <>4__this;

		// Token: 0x0400784C RID: 30796
		[Token(Token = "0x401976B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action callback;
	}

	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x2001227")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158A90", Offset = "0x158B91")]
	private sealed class <OnSetupAsync>d__127 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003474 RID: 13428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B3")]
		[Address(RVA = "0x1E5DB50", Offset = "0x1E5DC51", VA = "0x1E5DB50")]
		[DebuggerHidden]
		public <OnSetupAsync>d__127(int <>1__state)
		{
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x1E5DB80", Offset = "0x1E5DC81", VA = "0x1E5DB80", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x1E5DB90", Offset = "0x1E5DC91", VA = "0x1E5DB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D50")]
		private object Current
		{
			[Token(Token = "0x60073B6")]
			[Address(RVA = "0x1E5DBB0", Offset = "0x1E5DCB1", VA = "0x1E5DBB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0x1E5DBC0", Offset = "0x1E5DCC1", VA = "0x1E5DBC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D51")]
		private object Current
		{
			[Token(Token = "0x60073B8")]
			[Address(RVA = "0x1E5DC20", Offset = "0x1E5DD21", VA = "0x1E5DC20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400784D RID: 30797
		[Token(Token = "0x401976C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400784E RID: 30798
		[Token(Token = "0x401976D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x2001228")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AA0", Offset = "0x158BA1")]
	private sealed class <>c__DisplayClass176_0
	{
		// Token: 0x0600347A RID: 13434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0x1E5D7A0", Offset = "0x1E5D8A1", VA = "0x1E5D7A0")]
		public <>c__DisplayClass176_0()
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x1E5D7B0", Offset = "0x1E5D8B1", VA = "0x1E5D7B0")]
		internal void <DeadActionEvent>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x0400784F RID: 30799
		[Token(Token = "0x401976E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float deadEffctScale;

		// Token: 0x04007850 RID: 30800
		[Token(Token = "0x401976F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 createPosition;
	}

	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x2001229")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AB0", Offset = "0x158BB1")]
	private sealed class <>c__DisplayClass199_0
	{
		// Token: 0x0600347C RID: 13436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0x1E5D8A0", Offset = "0x1E5D9A1", VA = "0x1E5D8A0")]
		public <>c__DisplayClass199_0()
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BC")]
		[Address(RVA = "0x1E5D8B0", Offset = "0x1E5D9B1", VA = "0x1E5D8B0")]
		internal void <OnStartFade>b__0(Material material)
		{
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x1E5D980", Offset = "0x1E5DA81", VA = "0x1E5D980")]
		internal void <OnStartFade>b__1(Material material)
		{
		}

		// Token: 0x04007851 RID: 30801
		[Token(Token = "0x4019770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isBetween;

		// Token: 0x04007852 RID: 30802
		[Token(Token = "0x4019771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MonsterControllerBase <>4__this;
	}

	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x200122A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AC0", Offset = "0x158BC1")]
	private sealed class <>c__DisplayClass309_0
	{
		// Token: 0x0600347F RID: 13439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x1E5DA20", Offset = "0x1E5DB21", VA = "0x1E5DA20")]
		public <>c__DisplayClass309_0()
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x1E5DA30", Offset = "0x1E5DB31", VA = "0x1E5DA30")]
		internal void <DoItemPresent>b__0()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x1E5DA60", Offset = "0x1E5DB61", VA = "0x1E5DA60")]
		internal void <DoItemPresent>b__1()
		{
		}

		// Token: 0x04007853 RID: 30803
		[Token(Token = "0x4019772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonsterControllerBase <>4__this;

		// Token: 0x04007854 RID: 30804
		[Token(Token = "0x4019773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HumanStatus humanstatus;
	}

	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x200122B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158AD0", Offset = "0x158BD1")]
	private sealed class <WaitEffectDoFriend>d__311 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06003482 RID: 13442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x1E5DE10", Offset = "0x1E5DF11", VA = "0x1E5DE10")]
		[DebuggerHidden]
		public <WaitEffectDoFriend>d__311(int <>1__state)
		{
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x1E5DE40", Offset = "0x1E5DF41", VA = "0x1E5DE40", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x1E5DE50", Offset = "0x1E5DF51", VA = "0x1E5DE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D52")]
		private object Current
		{
			[Token(Token = "0x60073C4")]
			[Address(RVA = "0x1E5E020", Offset = "0x1E5E121", VA = "0x1E5E020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x1E5E030", Offset = "0x1E5E131", VA = "0x1E5E030", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D53")]
		private object Current
		{
			[Token(Token = "0x60073C6")]
			[Address(RVA = "0x1E5E090", Offset = "0x1E5E191", VA = "0x1E5E090", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007855 RID: 30805
		[Token(Token = "0x4019774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007856 RID: 30806
		[Token(Token = "0x4019775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007857 RID: 30807
		[Token(Token = "0x4019776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MonsterControllerBase <>4__this;

		// Token: 0x04007858 RID: 30808
		[Token(Token = "0x4019777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HumanStatus humanStatus;
	}
}
