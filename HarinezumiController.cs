using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x02000701 RID: 1793
[Token(Token = "0x20004EC")]
public class HarinezumiController : BossMonsterContoroller
{
	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700055C")]
	private SkinnedMeshRenderer NeedleSkinnedMeshRenderer
	{
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x24E8100", Offset = "0x24E8201", VA = "0x24E8100")]
		get
		{
			return null;
		}
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x00010A88 File Offset: 0x0000EC88
	// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700055D")]
	private MonsterControllerBase.FadeType NeedleFadeType
	{
		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x24E81F0", Offset = "0x24E82F1", VA = "0x24E81F0")]
		get
		{
			return MonsterControllerBase.FadeType.FadeIn;
		}
		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x24E8200", Offset = "0x24E8301", VA = "0x24E8200")]
		set
		{
		}
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00010AA0 File Offset: 0x0000ECA0
	[Token(Token = "0x1700055E")]
	public bool ExistNeedle
	{
		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x24E84B0", Offset = "0x24E85B1", VA = "0x24E84B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002CE7 RID: 11495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x24E8220", Offset = "0x24E8321", VA = "0x24E8220")]
	private void SetEnableNeedleColliderList(bool enable)
	{
	}

	// Token: 0x06002CE8 RID: 11496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x24E84C0", Offset = "0x24E85C1", VA = "0x24E84C0", Slot = "126")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06002CE9 RID: 11497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x24E8AB0", Offset = "0x24E8BB1", VA = "0x24E8AB0")]
	public void SetDOTweenNeedle(bool isDisplay, float fadeTime)
	{
	}

	// Token: 0x06002CEA RID: 11498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x24E8580", Offset = "0x24E8681", VA = "0x24E8580")]
	public void SetupNeedle()
	{
	}

	// Token: 0x06002CEB RID: 11499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x24E8D90", Offset = "0x24E8E91", VA = "0x24E8D90", Slot = "109")]
	public override void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x06002CEC RID: 11500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x24E7A20", Offset = "0x24E7B21", VA = "0x24E7A20")]
	public void StartFadeNeedle(MonsterControllerBase.FadeType fadeType, float fadeTime = 0.5f)
	{
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x06002CED RID: 11501 RVA: 0x00010AB8 File Offset: 0x0000ECB8
	// (set) Token: 0x06002CEE RID: 11502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700055F")]
	public bool Needle
	{
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x24E8F00", Offset = "0x24E9001", VA = "0x24E8F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3240", Offset = "0x1A3341")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x24E8F10", Offset = "0x24E9011", VA = "0x24E8F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3250", Offset = "0x1A3351")]
		private set
		{
		}
	}

	// Token: 0x06002CEF RID: 11503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x24E8F20", Offset = "0x24E9021", VA = "0x24E8F20")]
	private void DisplayNeedle(bool isDisplay, float fadeTime)
	{
	}

	// Token: 0x06002CF0 RID: 11504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x24E8FC0", Offset = "0x24E90C1", VA = "0x24E8FC0")]
	public void OnHitAttack(CharacterBase characterBase, Collider attackCollider, Vector3 hitPosition)
	{
	}

	// Token: 0x06002CF1 RID: 11505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x24E9770", Offset = "0x24E9871", VA = "0x24E9770", Slot = "132")]
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData)
	{
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x24E9FE0", Offset = "0x24EA0E1", VA = "0x24E9FE0", Slot = "116")]
	protected override void OnResetActionScriptAction()
	{
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x24EA010", Offset = "0x24EA111", VA = "0x24EA010")]
	private void UpdateNavmeshReflection()
	{
	}

	// Token: 0x06002CF4 RID: 11508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x24EA270", Offset = "0x24EA371", VA = "0x24EA270", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002CF5 RID: 11509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x24EA3D0", Offset = "0x24EA4D1", VA = "0x24EA3D0", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06002CF6 RID: 11510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x24EA480", Offset = "0x24EA581", VA = "0x24EA480", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x24E9C90", Offset = "0x24E9D91", VA = "0x24E9C90")]
	private void SetJumpPoint()
	{
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x24E9E70", Offset = "0x24E9F71", VA = "0x24E9E70")]
	private void EraseJumpPoint()
	{
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x24E9EA0", Offset = "0x24E9FA1", VA = "0x24E9EA0")]
	private void Dive(float speed)
	{
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F4")]
	[Address(RVA = "0x24E9F10", Offset = "0x24EA011", VA = "0x24E9F10")]
	private void ReleaseLockon()
	{
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x24E9F20", Offset = "0x24EA021", VA = "0x24E9F20")]
	private void StartJumpAttack(float jumpPower, float duration)
	{
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x00010AD0 File Offset: 0x0000ECD0
	[Token(Token = "0x60025F6")]
	[Address(RVA = "0x24EA560", Offset = "0x24EA661", VA = "0x24EA560", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x24E9FC0", Offset = "0x24EA0C1", VA = "0x24E9FC0")]
	private void StartLaser()
	{
	}

	// Token: 0x06002CFE RID: 11518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F8")]
	[Address(RVA = "0x24E9FD0", Offset = "0x24EA0D1", VA = "0x24E9FD0")]
	private void EndLaser()
	{
	}

	// Token: 0x06002CFF RID: 11519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025F9")]
	[Address(RVA = "0x24EA3B0", Offset = "0x24EA4B1", VA = "0x24EA3B0")]
	private void UpdateLaser()
	{
	}

	// Token: 0x06002D00 RID: 11520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025FA")]
	[Address(RVA = "0x24EA5B0", Offset = "0x24EA6B1", VA = "0x24EA5B0", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002D01 RID: 11521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025FB")]
	[Address(RVA = "0x24EA5F0", Offset = "0x24EA6F1", VA = "0x24EA5F0", Slot = "129")]
	protected override void OnEndAnimEventGetupState()
	{
	}

	// Token: 0x06002D02 RID: 11522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x24EA640", Offset = "0x24EA741", VA = "0x24EA640")]
	public HarinezumiController()
	{
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x00010AE8 File Offset: 0x0000ECE8
	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x24EA7B0", Offset = "0x24EA8B1", VA = "0x24EA7B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3260", Offset = "0x1A3361")]
	private float <SetDOTweenNeedle>b__23_0()
	{
		return 0f;
	}

	// Token: 0x06002D05 RID: 11525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x24EA810", Offset = "0x24EA911", VA = "0x24EA810")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3270", Offset = "0x1A3371")]
	private void <SetDOTweenNeedle>b__23_1(float value)
	{
	}

	// Token: 0x06002D06 RID: 11526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002600")]
	[Address(RVA = "0x24EA8A0", Offset = "0x24EA9A1", VA = "0x24EA8A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3280", Offset = "0x1A3381")]
	private void <SetDOTweenNeedle>b__23_2()
	{
	}

	// Token: 0x06002D07 RID: 11527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002601")]
	[Address(RVA = "0x24EA8C0", Offset = "0x24EA9C1", VA = "0x24EA8C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3290", Offset = "0x1A3391")]
	private void <SetDOTweenNeedle>b__23_3()
	{
	}

	// Token: 0x06002D08 RID: 11528 RVA: 0x00010B00 File Offset: 0x0000ED00
	[Token(Token = "0x6002602")]
	[Address(RVA = "0x24EA940", Offset = "0x24EAA41", VA = "0x24EA940")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32A0", Offset = "0x1A33A1")]
	private float <SetDOTweenNeedle>b__23_4()
	{
		return 0f;
	}

	// Token: 0x06002D09 RID: 11529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002603")]
	[Address(RVA = "0x24EA9A0", Offset = "0x24EAAA1", VA = "0x24EA9A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32B0", Offset = "0x1A33B1")]
	private void <SetDOTweenNeedle>b__23_5(float value)
	{
	}

	// Token: 0x06002D0A RID: 11530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002604")]
	[Address(RVA = "0x24EAA30", Offset = "0x24EAB31", VA = "0x24EAA30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32C0", Offset = "0x1A33C1")]
	private void <SetDOTweenNeedle>b__23_6()
	{
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002605")]
	[Address(RVA = "0x24EAA50", Offset = "0x24EAB51", VA = "0x24EAA50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32D0", Offset = "0x1A33D1")]
	private void <SetDOTweenNeedle>b__23_7()
	{
	}

	// Token: 0x06002D0C RID: 11532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002606")]
	[Address(RVA = "0x24EAAA0", Offset = "0x24EABA1", VA = "0x24EAAA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32E0", Offset = "0x1A33E1")]
	private void <OnUniqueActionCommandInternal>b__33_0()
	{
	}

	// Token: 0x06002D0D RID: 11533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002607")]
	[Address(RVA = "0x24EAAD0", Offset = "0x24EABD1", VA = "0x24EAAD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A32F0", Offset = "0x1A33F1")]
	private void <Start>b__44_0(ParticleSystem particle)
	{
	}

	// Token: 0x040073AA RID: 29610
	[Token(Token = "0x4006ABA")]
	private const float NavmeshEdgeHitRange = 3f;

	// Token: 0x040073AB RID: 29611
	[Token(Token = "0x4006ABB")]
	private const float ReflectionTargetCorrection = 0.15f;

	// Token: 0x040073AC RID: 29612
	[Token(Token = "0x4006ABC")]
	private const float EscapeRange = 10f;

	// Token: 0x040073AD RID: 29613
	[Token(Token = "0x4006ABD")]
	[FieldOffset(Offset = "0x508")]
	private SkinnedMeshRenderer _NeedleSkinnedMeshRenderer;

	// Token: 0x040073AE RID: 29614
	[Token(Token = "0x4006ABE")]
	[FieldOffset(Offset = "0x510")]
	private GameObject TogeGameObject;

	// Token: 0x040073AF RID: 29615
	[Token(Token = "0x4006ABF")]
	[FieldOffset(Offset = "0x518")]
	private MaterialPropertyBlock MaterialPropertyBlock;

	// Token: 0x040073B0 RID: 29616
	[Token(Token = "0x4006AC0")]
	[FieldOffset(Offset = "0x520")]
	private Tweener FadeTweener;

	// Token: 0x040073B1 RID: 29617
	[Token(Token = "0x4006AC1")]
	[FieldOffset(Offset = "0x528")]
	private bool IsActiveNeedle;

	// Token: 0x040073B2 RID: 29618
	[Token(Token = "0x4006AC2")]
	[FieldOffset(Offset = "0x529")]
	private bool IsReflectionNavmeshEdge;

	// Token: 0x040073B3 RID: 29619
	[Token(Token = "0x4006AC3")]
	[FieldOffset(Offset = "0x52C")]
	private NavMeshHit NavMeshHit;

	// Token: 0x040073B4 RID: 29620
	[Token(Token = "0x4006AC4")]
	[FieldOffset(Offset = "0x550")]
	private MonsterControllerBase.FadeType _NeedleFadeType;

	// Token: 0x040073B5 RID: 29621
	[Token(Token = "0x4006AC5")]
	[FieldOffset(Offset = "0x558")]
	private DamageInfo NeedleDamageInfo;

	// Token: 0x040073B6 RID: 29622
	[Token(Token = "0x4006AC6")]
	[FieldOffset(Offset = "0x5D8")]
	private Dictionary<int, HarinezumiController.NeedleController> NeedleEnableTimeSequenceDic;

	// Token: 0x040073B7 RID: 29623
	[Token(Token = "0x4006AC7")]
	[FieldOffset(Offset = "0x5E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1697B0", Offset = "0x1698B1")]
	private bool <Needle>k__BackingField;

	// Token: 0x040073B8 RID: 29624
	[Token(Token = "0x4006AC8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE;

	// Token: 0x040073B9 RID: 29625
	[Token(Token = "0x4006AC9")]
	[FieldOffset(Offset = "0xC")]
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE_VAR;

	// Token: 0x040073BA RID: 29626
	[Token(Token = "0x4006ACA")]
	[FieldOffset(Offset = "0x5E4")]
	private Vector3 JumpPosition;

	// Token: 0x040073BB RID: 29627
	[Token(Token = "0x4006ACB")]
	[FieldOffset(Offset = "0x5F0")]
	private ParticleSystem JumpPointEffect;

	// Token: 0x040073BC RID: 29628
	[Token(Token = "0x4006ACC")]
	[FieldOffset(Offset = "0x5F8")]
	private bool IsDive;

	// Token: 0x040073BD RID: 29629
	[Token(Token = "0x4006ACD")]
	[FieldOffset(Offset = "0x5FC")]
	private float DiveSpeed;

	// Token: 0x040073BE RID: 29630
	[Token(Token = "0x4006ACE")]
	[FieldOffset(Offset = "0x600")]
	private bool CanLockon;

	// Token: 0x040073BF RID: 29631
	[Token(Token = "0x4006ACF")]
	[FieldOffset(Offset = "0x604")]
	private HarinezumiController.Laser LaserState;

	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x200119C")]
	private class NeedleController
	{
		// Token: 0x06002D0E RID: 11534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F1")]
		[Address(RVA = "0x24E8D80", Offset = "0x24E8E81", VA = "0x24E8D80")]
		public NeedleController()
		{
		}

		// Token: 0x040073C0 RID: 29632
		[Token(Token = "0x4019559")]
		[FieldOffset(Offset = "0x10")]
		public AttackCollider AttackCollider;

		// Token: 0x040073C1 RID: 29633
		[Token(Token = "0x401955A")]
		[FieldOffset(Offset = "0x18")]
		public Sequence Sequence;
	}

	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x200119D")]
	private enum Laser
	{
		// Token: 0x040073C3 RID: 29635
		[Token(Token = "0x401955C")]
		None,
		// Token: 0x040073C4 RID: 29636
		[Token(Token = "0x401955D")]
		Start,
		// Token: 0x040073C5 RID: 29637
		[Token(Token = "0x401955E")]
		End
	}

	// Token: 0x02000704 RID: 1796
	[Token(Token = "0x200119E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158420", Offset = "0x158521")]
	private sealed class <>c__DisplayClass24_0
	{
		// Token: 0x06002D0F RID: 11535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F2")]
		[Address(RVA = "0x24E8D70", Offset = "0x24E8E71", VA = "0x24E8D70")]
		public <>c__DisplayClass24_0()
		{
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F3")]
		[Address(RVA = "0x24EAE40", Offset = "0x24EAF41", VA = "0x24EAE40")]
		internal void <SetupNeedle>b__1()
		{
		}

		// Token: 0x040073C6 RID: 29638
		[Token(Token = "0x401955F")]
		[FieldOffset(Offset = "0x10")]
		public AttackCollider collider;

		// Token: 0x040073C7 RID: 29639
		[Token(Token = "0x4019560")]
		[FieldOffset(Offset = "0x18")]
		public HarinezumiController <>4__this;
	}

	// Token: 0x02000705 RID: 1797
	[Token(Token = "0x200119F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158430", Offset = "0x158531")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002D12 RID: 11538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F5")]
		[Address(RVA = "0x24EAD40", Offset = "0x24EAE41", VA = "0x24EAD40")]
		public <>c()
		{
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x60071F6")]
		[Address(RVA = "0x24EAD50", Offset = "0x24EAE51", VA = "0x24EAD50")]
		internal bool <SetupNeedle>b__24_0(AttackCollider collider)
		{
			return default(bool);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F7")]
		[Address(RVA = "0x24EADD0", Offset = "0x24EAED1", VA = "0x24EADD0")]
		internal void <OnHitAttack>b__32_0(ParticleSystem effect)
		{
		}

		// Token: 0x040073C8 RID: 29640
		[Token(Token = "0x4019561")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HarinezumiController.<>c <>9;

		// Token: 0x040073C9 RID: 29641
		[Token(Token = "0x4019562")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AttackCollider> <>9__24_0;

		// Token: 0x040073CA RID: 29642
		[Token(Token = "0x4019563")]
		[FieldOffset(Offset = "0x10")]
		public static UnityAction<ParticleSystem> <>9__32_0;
	}
}
