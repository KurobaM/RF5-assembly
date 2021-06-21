using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace DualWork
{
	// Token: 0x020010C1 RID: 4289
	[Token(Token = "0x2000AC1")]
	public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame>
	{
		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06006CD8 RID: 27864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CD9 RID: 27865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD6")]
		private DualWorkSetup DualWorkSetup
		{
			[Token(Token = "0x6005A4A")]
			[Address(RVA = "0x1E09E30", Offset = "0x1E09F31", VA = "0x1E09E30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE540", Offset = "0x1AE641")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A4B")]
			[Address(RVA = "0x1E09E40", Offset = "0x1E09F41", VA = "0x1E09E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE550", Offset = "0x1AE651")]
			set
			{
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CDB RID: 27867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD7")]
		private DualWorkTimelineLinker DualWorkTimelineLinker
		{
			[Token(Token = "0x6005A4C")]
			[Address(RVA = "0x1E09E50", Offset = "0x1E09F51", VA = "0x1E09E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE560", Offset = "0x1AE661")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A4D")]
			[Address(RVA = "0x1E09E60", Offset = "0x1E09F61", VA = "0x1E09E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE570", Offset = "0x1AE671")]
			set
			{
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06006CDC RID: 27868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CDD RID: 27869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD8")]
		private UIDualWork UIDualWork
		{
			[Token(Token = "0x6005A4E")]
			[Address(RVA = "0x1E09E70", Offset = "0x1E09F71", VA = "0x1E09E70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE580", Offset = "0x1AE681")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A4F")]
			[Address(RVA = "0x1E09E80", Offset = "0x1E09F81", VA = "0x1E09E80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE590", Offset = "0x1AE691")]
			set
			{
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06006CDE RID: 27870 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CDF RID: 27871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD9")]
		private Transform CanvasTransform
		{
			[Token(Token = "0x6005A50")]
			[Address(RVA = "0x1E09E90", Offset = "0x1E09F91", VA = "0x1E09E90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5A0", Offset = "0x1AE6A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A51")]
			[Address(RVA = "0x1E09EA0", Offset = "0x1E09FA1", VA = "0x1E09EA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5B0", Offset = "0x1AE6B1")]
			set
			{
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CE1 RID: 27873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADA")]
		private Transform ObjectTransform
		{
			[Token(Token = "0x6005A52")]
			[Address(RVA = "0x1E09EB0", Offset = "0x1E09FB1", VA = "0x1E09EB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5C0", Offset = "0x1AE6C1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A53")]
			[Address(RVA = "0x1E09EC0", Offset = "0x1E09FC1", VA = "0x1E09EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5D0", Offset = "0x1AE6D1")]
			set
			{
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x00025728 File Offset: 0x00023928
		// (set) Token: 0x06006CE3 RID: 27875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADB")]
		public ActorID SubActor
		{
			[Token(Token = "0x6005A54")]
			[Address(RVA = "0x1E09ED0", Offset = "0x1E09FD1", VA = "0x1E09ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5E0", Offset = "0x1AE6E1")]
			get
			{
				return ActorID.act000;
			}
			[Token(Token = "0x6005A55")]
			[Address(RVA = "0x1E09EE0", Offset = "0x1E09FE1", VA = "0x1E09EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE5F0", Offset = "0x1AE6F1")]
			set
			{
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06006CE4 RID: 27876 RVA: 0x00025740 File Offset: 0x00023940
		// (set) Token: 0x06006CE5 RID: 27877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADC")]
		public bool IsMiniGame
		{
			[Token(Token = "0x6005A56")]
			[Address(RVA = "0x1E09EF0", Offset = "0x1E09FF1", VA = "0x1E09EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE600", Offset = "0x1AE701")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A57")]
			[Address(RVA = "0x1E09F00", Offset = "0x1E0A001", VA = "0x1E09F00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE610", Offset = "0x1AE711")]
			set
			{
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x00025758 File Offset: 0x00023958
		// (set) Token: 0x06006CE7 RID: 27879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADD")]
		public bool IsMiniGameSuccess
		{
			[Token(Token = "0x6005A58")]
			[Address(RVA = "0x1E09F10", Offset = "0x1E0A011", VA = "0x1E09F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE620", Offset = "0x1AE721")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A59")]
			[Address(RVA = "0x1E09F20", Offset = "0x1E0A021", VA = "0x1E09F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE630", Offset = "0x1AE731")]
			private set
			{
			}
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5A")]
		[Address(RVA = "0x1E07C60", Offset = "0x1E07D61", VA = "0x1E07C60")]
		public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack)
		{
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0x1E09FC0", Offset = "0x1E0A0C1", VA = "0x1E09FC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE640", Offset = "0x1AE741")]
		private IEnumerator LoadWithContinueMiniGame()
		{
			return null;
		}

		// Token: 0x06006CEA RID: 27882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0x1E0A070", Offset = "0x1E0A171", VA = "0x1E0A070")]
		private void LoadAssetsAfterStart()
		{
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0x1E0B090", Offset = "0x1E0B191", VA = "0x1E0B090")]
		private void StartTimeline(PlayableDirector director)
		{
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0x1E0B100", Offset = "0x1E0B201", VA = "0x1E0B100")]
		public void EndTimeline()
		{
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0x1E0B980", Offset = "0x1E0BA81", VA = "0x1E0B980")]
		public void Update()
		{
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A60")]
		[Address(RVA = "0x1E0B610", Offset = "0x1E0B711", VA = "0x1E0B610")]
		public void DispResultWindow()
		{
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A61")]
		[Address(RVA = "0x1E0B110", Offset = "0x1E0B211", VA = "0x1E0B110")]
		private void EndDualwork()
		{
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A62")]
		[Address(RVA = "0x1E0BD80", Offset = "0x1E0BE81", VA = "0x1E0BD80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE6B0", Offset = "0x1AE7B1")]
		private IEnumerator RebindNextFrame(Animator animator)
		{
			return null;
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00025770 File Offset: 0x00023970
		[Token(Token = "0x6005A63")]
		[Address(RVA = "0x1E0BE30", Offset = "0x1E0BF31", VA = "0x1E0BE30")]
		private DualWorkMiniGame.PushResult CheckPush(float position)
		{
			return DualWorkMiniGame.PushResult.Critical;
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A64")]
		[Address(RVA = "0x1E09F30", Offset = "0x1E0A031", VA = "0x1E09F30")]
		private void InitMiniGame(int loveLevel)
		{
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A65")]
		[Address(RVA = "0x1E0B9C0", Offset = "0x1E0BAC1", VA = "0x1E0B9C0")]
		private void UpdateMiniGame(float deltaTime)
		{
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x1E0BE80", Offset = "0x1E0BF81", VA = "0x1E0BE80")]
		private void OnMiniGameEnd(bool isSkip)
		{
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x1E0C700", Offset = "0x1E0C801", VA = "0x1E0C700")]
		private void Start()
		{
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x1E0C7B0", Offset = "0x1E0C8B1", VA = "0x1E0C7B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x1E0C8C0", Offset = "0x1E0C9C1", VA = "0x1E0C8C0")]
		private void OnCarryDay(int day)
		{
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x1E0C970", Offset = "0x1E0CA71", VA = "0x1E0C970")]
		public DualWorkMiniGame()
		{
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x1E0CAA0", Offset = "0x1E0CBA1", VA = "0x1E0CAA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE720", Offset = "0x1AE821")]
		private void <DispResultWindow>b__44_0()
		{
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x1E0CAB0", Offset = "0x1E0CBB1", VA = "0x1E0CAB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE730", Offset = "0x1AE831")]
		private void <OnMiniGameEnd>b__72_0()
		{
		}

		// Token: 0x040174E1 RID: 95457
		[Token(Token = "0x4013FE6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FF0", Offset = "0x1810F1")]
		private DualWorkSetup <DualWorkSetup>k__BackingField;

		// Token: 0x040174E2 RID: 95458
		[Token(Token = "0x4013FE7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181000", Offset = "0x181101")]
		private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField;

		// Token: 0x040174E3 RID: 95459
		[Token(Token = "0x4013FE8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181010", Offset = "0x181111")]
		private UIDualWork <UIDualWork>k__BackingField;

		// Token: 0x040174E4 RID: 95460
		[Token(Token = "0x4013FE9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181020", Offset = "0x181121")]
		private Transform <CanvasTransform>k__BackingField;

		// Token: 0x040174E5 RID: 95461
		[Token(Token = "0x4013FEA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181030", Offset = "0x181131")]
		private Transform <ObjectTransform>k__BackingField;

		// Token: 0x040174E6 RID: 95462
		[Token(Token = "0x4013FEB")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181040", Offset = "0x181141")]
		private ActorID <SubActor>k__BackingField;

		// Token: 0x040174E7 RID: 95463
		[Token(Token = "0x4013FEC")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181050", Offset = "0x181151")]
		private bool <IsMiniGame>k__BackingField;

		// Token: 0x040174E8 RID: 95464
		[Token(Token = "0x4013FED")]
		[FieldOffset(Offset = "0x45")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181060", Offset = "0x181161")]
		private bool <IsMiniGameSuccess>k__BackingField;

		// Token: 0x040174E9 RID: 95465
		[Token(Token = "0x4013FEE")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID;

		// Token: 0x040174EA RID: 95466
		[Token(Token = "0x4013FEF")]
		[FieldOffset(Offset = "0x50")]
		private UnityAction<bool> EndCallBack;

		// Token: 0x040174EB RID: 95467
		[Token(Token = "0x4013FF0")]
		[FieldOffset(Offset = "0x58")]
		private bool IsSwitchSPCBase;

		// Token: 0x040174EC RID: 95468
		[Token(Token = "0x4013FF1")]
		[FieldOffset(Offset = "0x60")]
		private PlayableDirector Director;

		// Token: 0x040174ED RID: 95469
		[Token(Token = "0x4013FF2")]
		[FieldOffset(Offset = "0x68")]
		private UICraftSuccess ResultWindow;

		// Token: 0x040174EE RID: 95470
		[Token(Token = "0x4013FF3")]
		[FieldOffset(Offset = "0x70")]
		private DualWorkMiniGame.PushResult LastPushResult;

		// Token: 0x040174EF RID: 95471
		[Token(Token = "0x4013FF4")]
		[FieldOffset(Offset = "0x74")]
		private float MiniGameTimeLimit;

		// Token: 0x040174F0 RID: 95472
		[Token(Token = "0x4013FF5")]
		[FieldOffset(Offset = "0x78")]
		private int Count;

		// Token: 0x040174F1 RID: 95473
		[Token(Token = "0x4013FF6")]
		[FieldOffset(Offset = "0x7C")]
		private int CurrentSynchroGauge;

		// Token: 0x040174F2 RID: 95474
		[Token(Token = "0x4013FF7")]
		[FieldOffset(Offset = "0x80")]
		private int SynchroGaugeMax;

		// Token: 0x040174F3 RID: 95475
		[Token(Token = "0x4013FF8")]
		[FieldOffset(Offset = "0x84")]
		private int SynchroGaugePerfect;

		// Token: 0x040174F4 RID: 95476
		[Token(Token = "0x4013FF9")]
		[FieldOffset(Offset = "0x88")]
		private int SynchroGaugeNice;

		// Token: 0x040174F5 RID: 95477
		[Token(Token = "0x4013FFA")]
		[FieldOffset(Offset = "0x8C")]
		private int SynchroGaugeBad;

		// Token: 0x040174F6 RID: 95478
		[Token(Token = "0x4013FFB")]
		[FieldOffset(Offset = "0x90")]
		private int SuccessGaugeBase;

		// Token: 0x040174F7 RID: 95479
		[Token(Token = "0x4013FFC")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int CriticalGaugeBase;

		// Token: 0x040174F8 RID: 95480
		[Token(Token = "0x4013FFD")]
		[FieldOffset(Offset = "0x98")]
		private float BarPosition;

		// Token: 0x040174F9 RID: 95481
		[Token(Token = "0x4013FFE")]
		[FieldOffset(Offset = "0x9C")]
		private bool BarDirectionLeft;

		// Token: 0x040174FA RID: 95482
		[Token(Token = "0x4013FFF")]
		[FieldOffset(Offset = "0xA0")]
		private float SuccessGauge;

		// Token: 0x040174FB RID: 95483
		[Token(Token = "0x4014000")]
		[FieldOffset(Offset = "0xA4")]
		private float CriticalGauge;

		// Token: 0x040174FC RID: 95484
		[Token(Token = "0x4014001")]
		[FieldOffset(Offset = "0xA8")]
		private float SuccessGauge_Rand_L;

		// Token: 0x040174FD RID: 95485
		[Token(Token = "0x4014002")]
		[FieldOffset(Offset = "0xAC")]
		private float SuccessGauge_Rand_R;

		// Token: 0x040174FE RID: 95486
		[Token(Token = "0x4014003")]
		[FieldOffset(Offset = "0xB0")]
		private float SuccessGauge_Position;

		// Token: 0x040174FF RID: 95487
		[Token(Token = "0x4014004")]
		[FieldOffset(Offset = "0xB4")]
		private float CriticalGauge_Position;

		// Token: 0x04017500 RID: 95488
		[Token(Token = "0x4014005")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float BarSpeed;

		// Token: 0x04017501 RID: 95489
		[Token(Token = "0x4014006")]
		[FieldOffset(Offset = "0xBC")]
		private float CurrentTimeLimit;

		// Token: 0x04017502 RID: 95490
		[Token(Token = "0x4014007")]
		[FieldOffset(Offset = "0xC0")]
		private float CurrentCoolTime;

		// Token: 0x04017503 RID: 95491
		[Token(Token = "0x4014008")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float CoolTimeMax;

		// Token: 0x020010C2 RID: 4290
		[Token(Token = "0x200156C")]
		private enum PushResult
		{
			// Token: 0x04017505 RID: 95493
			[Token(Token = "0x401C108")]
			Critical,
			// Token: 0x04017506 RID: 95494
			[Token(Token = "0x401C109")]
			Nice,
			// Token: 0x04017507 RID: 95495
			[Token(Token = "0x401C10A")]
			Bad
		}

		// Token: 0x020010C3 RID: 4291
		[Token(Token = "0x200156D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A060", Offset = "0x15A161")]
		private sealed class <LoadWithContinueMiniGame>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006CFB RID: 27899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3D")]
			[Address(RVA = "0x1E0A040", Offset = "0x1E0A141", VA = "0x1E0A040")]
			[DebuggerHidden]
			public <LoadWithContinueMiniGame>d__36(int <>1__state)
			{
			}

			// Token: 0x06006CFC RID: 27900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3E")]
			[Address(RVA = "0x1E0CAF0", Offset = "0x1E0CBF1", VA = "0x1E0CAF0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006CFD RID: 27901 RVA: 0x00025788 File Offset: 0x00023988
			[Token(Token = "0x6007D3F")]
			[Address(RVA = "0x1E0CB00", Offset = "0x1E0CC01", VA = "0x1E0CB00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x06006CFE RID: 27902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB7")]
			private object Current
			{
				[Token(Token = "0x6007D40")]
				[Address(RVA = "0x1E0CF50", Offset = "0x1E0D051", VA = "0x1E0CF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006CFF RID: 27903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D41")]
			[Address(RVA = "0x1E0CF60", Offset = "0x1E0D061", VA = "0x1E0CF60", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB8")]
			private object Current
			{
				[Token(Token = "0x6007D42")]
				[Address(RVA = "0x1E0CFC0", Offset = "0x1E0D0C1", VA = "0x1E0CFC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017508 RID: 95496
			[Token(Token = "0x401C10B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017509 RID: 95497
			[Token(Token = "0x401C10C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401750A RID: 95498
			[Token(Token = "0x401C10D")]
			[FieldOffset(Offset = "0x20")]
			public DualWorkMiniGame <>4__this;

			// Token: 0x0401750B RID: 95499
			[Token(Token = "0x401C10E")]
			[FieldOffset(Offset = "0x28")]
			private Actor <subActor>5__2;
		}

		// Token: 0x020010C4 RID: 4292
		[Token(Token = "0x200156E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A070", Offset = "0x15A171")]
		private sealed class <RebindNextFrame>d__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006D01 RID: 27905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D43")]
			[Address(RVA = "0x1E0BE00", Offset = "0x1E0BF01", VA = "0x1E0BE00")]
			[DebuggerHidden]
			public <RebindNextFrame>d__46(int <>1__state)
			{
			}

			// Token: 0x06006D02 RID: 27906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D44")]
			[Address(RVA = "0x1E0CFD0", Offset = "0x1E0D0D1", VA = "0x1E0CFD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006D03 RID: 27907 RVA: 0x000257A0 File Offset: 0x000239A0
			[Token(Token = "0x6007D45")]
			[Address(RVA = "0x1E0CFE0", Offset = "0x1E0D0E1", VA = "0x1E0CFE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x06006D04 RID: 27908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EB9")]
			private object Current
			{
				[Token(Token = "0x6007D46")]
				[Address(RVA = "0x1E0D0D0", Offset = "0x1E0D1D1", VA = "0x1E0D0D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006D05 RID: 27909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D47")]
			[Address(RVA = "0x1E0D0E0", Offset = "0x1E0D1E1", VA = "0x1E0D0E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x06006D06 RID: 27910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBA")]
			private object Current
			{
				[Token(Token = "0x6007D48")]
				[Address(RVA = "0x1E0D140", Offset = "0x1E0D241", VA = "0x1E0D140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401750C RID: 95500
			[Token(Token = "0x401C10F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401750D RID: 95501
			[Token(Token = "0x401C110")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401750E RID: 95502
			[Token(Token = "0x401C111")]
			[FieldOffset(Offset = "0x20")]
			public Animator animator;
		}
	}
}
