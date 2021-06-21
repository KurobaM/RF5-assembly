using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020002C6 RID: 710
[Token(Token = "0x200022C")]
public class SpcController : HumanController, InteractionInterface, FocusInterface
{
	// Token: 0x17000352 RID: 850
	// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00008838 File Offset: 0x00006A38
	[Token(Token = "0x17000328")]
	private Vector3 lookat
	{
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x225DD20", Offset = "0x225DE21", VA = "0x225DD20")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00008850 File Offset: 0x00006A50
	// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000329")]
	public bool ForceDisable
	{
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x225DD40", Offset = "0x225DE41", VA = "0x225DD40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x225DD50", Offset = "0x225DE51", VA = "0x225DD50")]
		set
		{
		}
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700032A")]
	public Transform ItemPoint_Right
	{
		[Token(Token = "0x6001114")]
		[Address(RVA = "0x225DDC0", Offset = "0x225DEC1", VA = "0x225DDC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700032B")]
	public Transform ItemPoint_Left
	{
		[Token(Token = "0x6001115")]
		[Address(RVA = "0x225DE90", Offset = "0x225DF91", VA = "0x225DE90")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700032C")]
	public Transform ItemPoint_Floor
	{
		[Token(Token = "0x6001116")]
		[Address(RVA = "0x225DF60", Offset = "0x225E061", VA = "0x225DF60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700032D")]
	public LookAtIK LookAtIK
	{
		[Token(Token = "0x6001117")]
		[Address(RVA = "0x225E080", Offset = "0x225E181", VA = "0x225E080")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000358 RID: 856
	// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700032E")]
	public override float LookIKWeight
	{
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x225E0A0", Offset = "0x225E1A1", VA = "0x225E0A0", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00008868 File Offset: 0x00006A68
	[Token(Token = "0x1700032F")]
	protected override bool KeepAnimatorControllerStateOnDisable
	{
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x225E0B0", Offset = "0x225E1B1", VA = "0x225E0B0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x225E0C0", Offset = "0x225E1C1", VA = "0x225E0C0", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x225E090", Offset = "0x225E191", VA = "0x225E090")]
	public void SetupLookAtIK()
	{
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x225E610", Offset = "0x225E711", VA = "0x225E610", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x225F1F0", Offset = "0x225F2F1", VA = "0x225F1F0")]
	public void SetShortPlayMovePosition(Vector3 _targetPosition, float _moveSpeed, float _locomotion)
	{
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x225F650", Offset = "0x225F751", VA = "0x225F650")]
	public void ShortPlay()
	{
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x225E570", Offset = "0x225E671", VA = "0x225E570")]
	public void FadeNpc()
	{
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x225F9D0", Offset = "0x225FAD1", VA = "0x225F9D0")]
	public void FadeInStandby()
	{
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x225FA70", Offset = "0x225FB71", VA = "0x225FA70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C790", Offset = "0x19C891")]
	public IEnumerator FadeInNpc([Optional] UnityAction _fadeEndAction)
	{
		return null;
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x225FB40", Offset = "0x225FC41", VA = "0x225FB40")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C800", Offset = "0x19C901")]
	public IEnumerator FadeOutNpc([Optional] UnityAction _fadeEndAction)
	{
		return null;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00008880 File Offset: 0x00006A80
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x225FC10", Offset = "0x225FD11", VA = "0x225FC10")]
	private bool CheckGrounderCanEnable()
	{
		return default(bool);
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x225FCE0", Offset = "0x225FDE1", VA = "0x225FCE0", Slot = "61")]
	public override void SetGrounderIKWeight(float weight)
	{
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001125")]
	[Address(RVA = "0x225F4C0", Offset = "0x225F5C1", VA = "0x225F4C0")]
	public void SetGrounderEnabled(bool enable)
	{
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001126")]
	[Address(RVA = "0x225F590", Offset = "0x225F691", VA = "0x225F590")]
	public void ResetGrounderPosition()
	{
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001127")]
	[Address(RVA = "0x225FCF0", Offset = "0x225FDF1", VA = "0x225FCF0", Slot = "71")]
	public override void OnFalling()
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001128")]
	[Address(RVA = "0x225FD00", Offset = "0x225FE01", VA = "0x225FD00", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001129")]
	[Address(RVA = "0x225FEF0", Offset = "0x225FFF1", VA = "0x225FEF0")]
	public void SetShortPlayAnim(bool shortplay)
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x225FF80", Offset = "0x2260081", VA = "0x225FF80")]
	public void ShortPlayExit(bool switchNpc = true)
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x225ECB0", Offset = "0x225EDB1", VA = "0x225ECB0")]
	public void UpdateMovePosition()
	{
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x22602F0", Offset = "0x22603F1", VA = "0x22602F0")]
	protected void SetAnimationState(int animIdx)
	{
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x2260330", Offset = "0x2260431", VA = "0x2260330")]
	public void SettingGrounderIK()
	{
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00008898 File Offset: 0x00006A98
	[Token(Token = "0x600112E")]
	[Address(RVA = "0x2260340", Offset = "0x2260441", VA = "0x2260340")]
	private bool CheckUseGroundIK()
	{
		return default(bool);
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600112F")]
	[Address(RVA = "0x225E650", Offset = "0x225E751", VA = "0x225E650")]
	public void UpdateOnGround()
	{
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x225E910", Offset = "0x225EA11", VA = "0x225E910")]
	private void UpdateLookAtRotation()
	{
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x2260470", Offset = "0x2260571", VA = "0x2260470")]
	public void LookAtTargetShortPlay(Quaternion q)
	{
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x22606B0", Offset = "0x22607B1", VA = "0x22606B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19C870", Offset = "0x19C971")]
	public IEnumerator LookAtTargetShortPlayEnd()
	{
		return null;
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001133")]
	[Address(RVA = "0x2260760", Offset = "0x2260861", VA = "0x2260760")]
	private void ResetGroundIK()
	{
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x225F390", Offset = "0x225F491", VA = "0x225F390")]
	public void AnimationStart(NpcAnimState animState, bool IsShortPlayCalled)
	{
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x2260810", Offset = "0x2260911", VA = "0x2260810")]
	private void StartAnimationState(NpcAnimState state)
	{
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x2260940", Offset = "0x2260A41", VA = "0x2260940")]
	public void PlaySE(UnityEngine.Object obj)
	{
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x000088B0 File Offset: 0x00006AB0
	[Token(Token = "0x6001137")]
	[Address(RVA = "0x2260A60", Offset = "0x2260B61", VA = "0x2260A60")]
	private bool CheckLookAtRotation()
	{
		return default(bool);
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001138")]
	[Address(RVA = "0x225EBF0", Offset = "0x225ECF1", VA = "0x225EBF0")]
	private void UpdateLookAtIK()
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001139")]
	[Address(RVA = "0x2260B50", Offset = "0x2260C51", VA = "0x2260B50", Slot = "76")]
	protected override void UpdateLookIK()
	{
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x225F980", Offset = "0x225FA81", VA = "0x225F980")]
	public void LookAtIKWeightReset()
	{
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x2260C50", Offset = "0x2260D51", VA = "0x2260C50")]
	public void SetShortPlayLookAtTarget(Transform tr, float speed = 1f)
	{
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x2260CD0", Offset = "0x2260DD1", VA = "0x2260CD0")]
	public void SetShortPlayLookAtTargetVector(Vector3 target, float speed = 1f)
	{
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x000088C8 File Offset: 0x00006AC8
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x2260CB0", Offset = "0x2260DB1", VA = "0x2260CB0")]
	private float GetSpeed(float speed)
	{
		return 0f;
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x000088E0 File Offset: 0x00006AE0
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000330")]
	public bool Focusable
	{
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x2260E80", Offset = "0x2260F81", VA = "0x2260E80", Slot = "100")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x2260F40", Offset = "0x2261041", VA = "0x2260F40")]
		private set
		{
		}
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001140")]
	[Address(RVA = "0x2260F50", Offset = "0x2261051", VA = "0x2260F50", Slot = "49")]
	protected override void ResetMovement()
	{
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x000088F8 File Offset: 0x00006AF8
	[Token(Token = "0x6001141")]
	[Address(RVA = "0x2260FF0", Offset = "0x22610F1", VA = "0x2260FF0", Slot = "106")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001142")]
	[Address(RVA = "0x2261000", Offset = "0x2261101", VA = "0x2261000", Slot = "99")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000331")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x2261010", Offset = "0x2261111", VA = "0x2261010")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00008910 File Offset: 0x00006B10
	[Token(Token = "0x17000332")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x2261060", Offset = "0x2261161", VA = "0x2261060", Slot = "103")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00008928 File Offset: 0x00006B28
	[Token(Token = "0x17000333")]
	public int FocusPriority
	{
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x2261070", Offset = "0x2261171", VA = "0x2261070", Slot = "104")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00008940 File Offset: 0x00006B40
	[Token(Token = "0x17000334")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x2261080", Offset = "0x2261181", VA = "0x2261080", Slot = "105")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001147")]
	[Address(RVA = "0x2261090", Offset = "0x2261191", VA = "0x2261090", Slot = "98")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001148")]
	[Address(RVA = "0x22610E0", Offset = "0x22611E1", VA = "0x22610E0", Slot = "101")]
	public void OnFocus()
	{
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001149")]
	[Address(RVA = "0x22610F0", Offset = "0x22611F1", VA = "0x22610F0", Slot = "102")]
	public void OffFocus()
	{
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00008958 File Offset: 0x00006B58
	[Token(Token = "0x600114A")]
	[Address(RVA = "0x2261100", Offset = "0x2261201", VA = "0x2261100", Slot = "95")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114B")]
	[Address(RVA = "0x2261110", Offset = "0x2261211", VA = "0x2261110", Slot = "94")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00008970 File Offset: 0x00006B70
	[Token(Token = "0x600114C")]
	[Address(RVA = "0x2261120", Offset = "0x2261221", VA = "0x2261120")]
	public Vector3 GetTargetPosition(GameObject childPoint)
	{
		return default(Vector3);
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114D")]
	[Address(RVA = "0x2261310", Offset = "0x2261411", VA = "0x2261310")]
	public void PlayEmotionEffect(EmotionType emotionType, float dispTime)
	{
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114E")]
	[Address(RVA = "0x2261510", Offset = "0x2261611", VA = "0x2261510")]
	public void SetAnimIdx(int idx)
	{
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600114F")]
	[Address(RVA = "0x2261580", Offset = "0x2261681", VA = "0x2261580")]
	public void ChangeModel(VariationNo modelType, HairType hairType)
	{
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001150")]
	[Address(RVA = "0x2261620", Offset = "0x2261721", VA = "0x2261620", Slot = "96")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x00008988 File Offset: 0x00006B88
	[Token(Token = "0x6001151")]
	[Address(RVA = "0x2261630", Offset = "0x2261731", VA = "0x2261630", Slot = "97")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001152")]
	[Address(RVA = "0x2261640", Offset = "0x2261741", VA = "0x2261640")]
	public SpcController()
	{
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001153")]
	[Address(RVA = "0x2261750", Offset = "0x2261851", VA = "0x2261750", Slot = "107")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x2261760", Offset = "0x2261861", VA = "0x2261760", Slot = "108")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[SerializeField]
	public bool IsFirstRotate;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	public Quaternion ShortPlayRotation;

	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	private bool IsGrounder;

	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private LookAtState lookAtState;

	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public Transform ShortPlayLookAtTarget;

	// Token: 0x04000A89 RID: 2697
	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private GameObject lookAtGameObject;

	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public bool IsLookTarget;

	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	[SerializeField]
	public int lookTargetNpcId;

	// Token: 0x04000A8C RID: 2700
	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public float lookAtSpeed;

	// Token: 0x04000A8D RID: 2701
	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	public bool IsWakeupAnim;

	// Token: 0x04000A8E RID: 2702
	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x275")]
	public bool IsSleepAnim;

	// Token: 0x04000A8F RID: 2703
	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private float headWeight;

	// Token: 0x04000A90 RID: 2704
	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	private float clampWeightHead;

	// Token: 0x04000A91 RID: 2705
	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private float orgClampWeightHead;

	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[SerializeField]
	public string focusName;

	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[SerializeField]
	public int NpcId;

	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	[SerializeField]
	public bool IsReached;

	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	[SerializeField]
	public Vector3 NavTargetPoint;

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	[SerializeField]
	public bool calcPath;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	[SerializeField]
	public float calcTime;

	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
	[SerializeField]
	public int pointcount;

	// Token: 0x04000A99 RID: 2713
	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	[SerializeField]
	public bool chkpointcount;

	// Token: 0x04000A9A RID: 2714
	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	[SerializeField]
	public int rndpointcount;

	// Token: 0x04000A9B RID: 2715
	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private Vector3 PrevPosition;

	// Token: 0x04000A9C RID: 2716
	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	public Vector3 lookatRotate;

	// Token: 0x04000A9D RID: 2717
	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public NpcAnimState SpcAnimState;

	// Token: 0x04000A9E RID: 2718
	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	public bool IsSlowdown;

	// Token: 0x04000A9F RID: 2719
	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D5")]
	[SerializeField]
	public bool IsStop;

	// Token: 0x04000AA0 RID: 2720
	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D6")]
	[SerializeField]
	public bool IsHurry;

	// Token: 0x04000AA1 RID: 2721
	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	[SerializeField]
	public float ShortPlayMoveSpeed;

	// Token: 0x04000AA2 RID: 2722
	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
	[SerializeField]
	public float ShortPlayLocomotion;

	// Token: 0x04000AA3 RID: 2723
	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	[SerializeField]
	public float ShortPlayTargetMoveSpeed;

	// Token: 0x04000AA4 RID: 2724
	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
	[SerializeField]
	public float ShortPlayTargetLocomotion;

	// Token: 0x04000AA5 RID: 2725
	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	private float CurrentFadeAlpha;

	// Token: 0x04000AA6 RID: 2726
	[Token(Token = "0x400085A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
	private bool IsFadeOut;

	// Token: 0x04000AA7 RID: 2727
	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2ED")]
	private bool forceDisable;

	// Token: 0x04000AA8 RID: 2728
	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	private Transform itemPoint_Right;

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	private Transform itemPoint_Left;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	private Transform itemPoint_Floor;

	// Token: 0x04000AAB RID: 2731
	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public Vector3 ItemPoint_Floor_Position;

	// Token: 0x04000AAC RID: 2732
	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	private LookAtIK lookAtIK;

	// Token: 0x04000AAD RID: 2733
	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public bool focusable;

	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x2001023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157330", Offset = "0x157431")]
	private sealed class <FadeInNpc>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8A")]
		[Address(RVA = "0x225FB10", Offset = "0x225FC11", VA = "0x225FB10")]
		[DebuggerHidden]
		public <FadeInNpc>d__65(int <>1__state)
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8B")]
		[Address(RVA = "0x2261770", Offset = "0x2261871", VA = "0x2261770", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x6006C8C")]
		[Address(RVA = "0x2261780", Offset = "0x2261881", VA = "0x2261780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE7")]
		private object Current
		{
			[Token(Token = "0x6006C8D")]
			[Address(RVA = "0x2261940", Offset = "0x2261A41", VA = "0x2261940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C8E")]
		[Address(RVA = "0x2261950", Offset = "0x2261A51", VA = "0x2261950", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE8")]
		private object Current
		{
			[Token(Token = "0x6006C8F")]
			[Address(RVA = "0x22619B0", Offset = "0x2261AB1", VA = "0x22619B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4018EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4018EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4018EC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpcController <>4__this;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4018EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _fadeEndAction;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4018EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <CharFadeTime>5__2;
	}

	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x2001024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157340", Offset = "0x157441")]
	private sealed class <FadeOutNpc>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060012FA RID: 4858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C90")]
		[Address(RVA = "0x225FBE0", Offset = "0x225FCE1", VA = "0x225FBE0")]
		[DebuggerHidden]
		public <FadeOutNpc>d__66(int <>1__state)
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C91")]
		[Address(RVA = "0x22619C0", Offset = "0x2261AC1", VA = "0x22619C0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x6006C92")]
		[Address(RVA = "0x22619D0", Offset = "0x2261AD1", VA = "0x22619D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE9")]
		private object Current
		{
			[Token(Token = "0x6006C93")]
			[Address(RVA = "0x2261B90", Offset = "0x2261C91", VA = "0x2261B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C94")]
		[Address(RVA = "0x2261BA0", Offset = "0x2261CA1", VA = "0x2261BA0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEA")]
		private object Current
		{
			[Token(Token = "0x6006C95")]
			[Address(RVA = "0x2261C00", Offset = "0x2261D01", VA = "0x2261C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4018EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4018EC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4018EC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpcController <>4__this;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4018EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityAction _fadeEndAction;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4018EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <CharFadeTime>5__2;
	}

	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x2001025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157350", Offset = "0x157451")]
	private sealed class <LookAtTargetShortPlayEnd>d__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001300 RID: 4864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C96")]
		[Address(RVA = "0x2260730", Offset = "0x2260831", VA = "0x2260730")]
		[DebuggerHidden]
		public <LookAtTargetShortPlayEnd>d__82(int <>1__state)
		{
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C97")]
		[Address(RVA = "0x2261C10", Offset = "0x2261D11", VA = "0x2261C10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x6006C98")]
		[Address(RVA = "0x2261C20", Offset = "0x2261D21", VA = "0x2261C20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEB")]
		private object Current
		{
			[Token(Token = "0x6006C99")]
			[Address(RVA = "0x2261D00", Offset = "0x2261E01", VA = "0x2261D00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0x2261D10", Offset = "0x2261E11", VA = "0x2261D10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEC")]
		private object Current
		{
			[Token(Token = "0x6006C9B")]
			[Address(RVA = "0x2261D70", Offset = "0x2261E71", VA = "0x2261D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4018EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4018ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4018ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpcController <>4__this;
	}
}
