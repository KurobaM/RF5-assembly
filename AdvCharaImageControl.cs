using System;
using Il2CppDummyDll;
using UIADV;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000912 RID: 2322
[Token(Token = "0x2000618")]
public class AdvCharaImageControl : MonoBehaviour
{
	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00015210 File Offset: 0x00013410
	// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006FB")]
	public StandPoint standPoint
	{
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x1D591C0", Offset = "0x1D592C1", VA = "0x1D591C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B50", Offset = "0x1A6C51")]
		get
		{
			return StandPoint.Left1;
		}
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x1D591D0", Offset = "0x1D592D1", VA = "0x1D591D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B60", Offset = "0x1A6C61")]
		private set
		{
		}
	}

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x00015228 File Offset: 0x00013428
	// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006FC")]
	public int CharactorId
	{
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x1D591E0", Offset = "0x1D592E1", VA = "0x1D591E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B70", Offset = "0x1A6C71")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x1D591F0", Offset = "0x1D592F1", VA = "0x1D591F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B80", Offset = "0x1A6C81")]
		private set
		{
		}
	}

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x00015240 File Offset: 0x00013440
	// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006FD")]
	public int VariationId
	{
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x1D59200", Offset = "0x1D59301", VA = "0x1D59200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B90", Offset = "0x1A6C91")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x1D59210", Offset = "0x1D59311", VA = "0x1D59210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BA0", Offset = "0x1A6CA1")]
		private set
		{
		}
	}

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00015258 File Offset: 0x00013458
	// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006FE")]
	public int MotionId
	{
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x1D59220", Offset = "0x1D59321", VA = "0x1D59220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BB0", Offset = "0x1A6CB1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x1D59230", Offset = "0x1D59331", VA = "0x1D59230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BC0", Offset = "0x1A6CC1")]
		private set
		{
		}
	}

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00015270 File Offset: 0x00013470
	// (set) Token: 0x06003CDA RID: 15578 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006FF")]
	public int PlayingCharactorId
	{
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x1D59240", Offset = "0x1D59341", VA = "0x1D59240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BD0", Offset = "0x1A6CD1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x1D59250", Offset = "0x1D59351", VA = "0x1D59250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BE0", Offset = "0x1A6CE1")]
		private set
		{
		}
	}

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00015288 File Offset: 0x00013488
	// (set) Token: 0x06003CDC RID: 15580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000700")]
	public int PlayingVariationId
	{
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x1D59260", Offset = "0x1D59361", VA = "0x1D59260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6BF0", Offset = "0x1A6CF1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x1D59270", Offset = "0x1D59371", VA = "0x1D59270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6C00", Offset = "0x1A6D01")]
		private set
		{
		}
	}

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06003CDD RID: 15581 RVA: 0x000152A0 File Offset: 0x000134A0
	// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000701")]
	public int PlayingMotionId
	{
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x1D59280", Offset = "0x1D59381", VA = "0x1D59280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6C10", Offset = "0x1A6D11")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x1D59290", Offset = "0x1D59391", VA = "0x1D59290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6C20", Offset = "0x1A6D21")]
		private set
		{
		}
	}

	// Token: 0x06003CDF RID: 15583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003330")]
	[Address(RVA = "0x1D592A0", Offset = "0x1D593A1", VA = "0x1D592A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06003CE0 RID: 15584 RVA: 0x000152B8 File Offset: 0x000134B8
	[Token(Token = "0x6003331")]
	[Address(RVA = "0x1D59320", Offset = "0x1D59421", VA = "0x1D59320")]
	public bool CheckCanUseSavePrefebs(int _CharactorId, int _VariationId)
	{
		return default(bool);
	}

	// Token: 0x06003CE1 RID: 15585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003332")]
	[Address(RVA = "0x1D593A0", Offset = "0x1D594A1", VA = "0x1D593A0")]
	public void InitOnCreate(StandPoint _standPoint)
	{
	}

	// Token: 0x06003CE2 RID: 15586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003333")]
	[Address(RVA = "0x1D59540", Offset = "0x1D59641", VA = "0x1D59540")]
	public void SetAppear()
	{
	}

	// Token: 0x06003CE3 RID: 15587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003334")]
	[Address(RVA = "0x1D58C10", Offset = "0x1D58D11", VA = "0x1D58C10")]
	public void SetLoadedEMA(GameObject _eyeMouthAnimatorPref, int loaderId)
	{
	}

	// Token: 0x06003CE4 RID: 15588 RVA: 0x000152D0 File Offset: 0x000134D0
	[Token(Token = "0x6003335")]
	[Address(RVA = "0x1D59780", Offset = "0x1D59881", VA = "0x1D59780")]
	private bool LoadFace(int charaId, int VariationId)
	{
		return default(bool);
	}

	// Token: 0x06003CE5 RID: 15589 RVA: 0x000152E8 File Offset: 0x000134E8
	[Token(Token = "0x6003336")]
	[Address(RVA = "0x1D598A0", Offset = "0x1D599A1", VA = "0x1D598A0")]
	private bool SetFace(int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar, int clothId = 0)
	{
		return default(bool);
	}

	// Token: 0x06003CE6 RID: 15590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003337")]
	[Address(RVA = "0x1D59CB0", Offset = "0x1D59DB1", VA = "0x1D59CB0")]
	public void SetCharaMotion(int motionId)
	{
	}

	// Token: 0x06003CE7 RID: 15591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003338")]
	[Address(RVA = "0x1D595A0", Offset = "0x1D596A1", VA = "0x1D595A0")]
	private void SetIn()
	{
	}

	// Token: 0x06003CE8 RID: 15592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003339")]
	[Address(RVA = "0x1D596B0", Offset = "0x1D597B1", VA = "0x1D596B0")]
	private void SetOut()
	{
	}

	// Token: 0x06003CE9 RID: 15593 RVA: 0x00015300 File Offset: 0x00013500
	[Token(Token = "0x600333A")]
	[Address(RVA = "0x1D59D90", Offset = "0x1D59E91", VA = "0x1D59D90")]
	private int DoMotionAnim(int motionId)
	{
		return 0;
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600333B")]
	[Address(RVA = "0x1D59F20", Offset = "0x1D5A021", VA = "0x1D59F20")]
	public void SetChara(int charaId, int variationId, int EyeVar, int EyeBrowsVar, int MouthVar, int motionId)
	{
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600333C")]
	[Address(RVA = "0x1D5A080", Offset = "0x1D5A181", VA = "0x1D5A080")]
	public void SetEndChara(int charaId, int faceId, int EyeVar, int EyeBrowsVar, int MouthVar, int motionId)
	{
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600333D")]
	[Address(RVA = "0x1D5A0D0", Offset = "0x1D5A1D1", VA = "0x1D5A0D0")]
	public void RemoveChara()
	{
	}

	// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600333E")]
	[Address(RVA = "0x1D5A220", Offset = "0x1D5A321", VA = "0x1D5A220")]
	public void StartMouth()
	{
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600333F")]
	[Address(RVA = "0x1D5A2D0", Offset = "0x1D5A3D1", VA = "0x1D5A2D0")]
	public void EndMouth()
	{
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003340")]
	[Address(RVA = "0x1D5A370", Offset = "0x1D5A471", VA = "0x1D5A370")]
	public void PlayEmocon(int no, int loop = 0)
	{
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003341")]
	[Address(RVA = "0x1D5A430", Offset = "0x1D5A531", VA = "0x1D5A430")]
	public void EndEmoconLoop(int no)
	{
	}

	// Token: 0x06003CF1 RID: 15601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003342")]
	[Address(RVA = "0x1D5A5D0", Offset = "0x1D5A6D1", VA = "0x1D5A5D0")]
	public void ForceEndEmocon()
	{
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003343")]
	[Address(RVA = "0x1D5A7F0", Offset = "0x1D5A8F1", VA = "0x1D5A7F0")]
	public void EndAllAnim()
	{
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003344")]
	[Address(RVA = "0x1D59EC0", Offset = "0x1D59FC1", VA = "0x1D59EC0")]
	public void PlayAnim(AdvCharaImageControl.CharaAnimateType type)
	{
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003345")]
	[Address(RVA = "0x1D5A8E0", Offset = "0x1D5A9E1", VA = "0x1D5A8E0")]
	public AdvCharaImageControl()
	{
	}

	// Token: 0x04007F2D RID: 32557
	[Token(Token = "0x40072CF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator CharactorAnimator;

	// Token: 0x04007F2E RID: 32558
	[Token(Token = "0x40072D0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image CharactorImages;

	// Token: 0x04007F2F RID: 32559
	[Token(Token = "0x40072D1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Animator CharactorFadeAnimator;

	// Token: 0x04007F30 RID: 32560
	[Token(Token = "0x40072D2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AdvEmoconControl LeftEmoconPrefab;

	// Token: 0x04007F31 RID: 32561
	[Token(Token = "0x40072D3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AdvEmoconControl RightEmoconPrefab;

	// Token: 0x04007F32 RID: 32562
	[Token(Token = "0x40072D4")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject AnimateMovePoint;

	// Token: 0x04007F33 RID: 32563
	[Token(Token = "0x40072D5")]
	[FieldOffset(Offset = "0x48")]
	private AdvCharaAnim[] CharaAnimate;

	// Token: 0x04007F34 RID: 32564
	[Token(Token = "0x40072D6")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EE90", Offset = "0x16EF91")]
	private StandPoint <standPoint>k__BackingField;

	// Token: 0x04007F35 RID: 32565
	[Token(Token = "0x40072D7")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EEA0", Offset = "0x16EFA1")]
	private int <CharactorId>k__BackingField;

	// Token: 0x04007F36 RID: 32566
	[Token(Token = "0x40072D8")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EEB0", Offset = "0x16EFB1")]
	private int <VariationId>k__BackingField;

	// Token: 0x04007F37 RID: 32567
	[Token(Token = "0x40072D9")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EEC0", Offset = "0x16EFC1")]
	private int <MotionId>k__BackingField;

	// Token: 0x04007F38 RID: 32568
	[Token(Token = "0x40072DA")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EED0", Offset = "0x16EFD1")]
	private int <PlayingCharactorId>k__BackingField;

	// Token: 0x04007F39 RID: 32569
	[Token(Token = "0x40072DB")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EEE0", Offset = "0x16EFE1")]
	private int <PlayingVariationId>k__BackingField;

	// Token: 0x04007F3A RID: 32570
	[Token(Token = "0x40072DC")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EEF0", Offset = "0x16EFF1")]
	private int <PlayingMotionId>k__BackingField;

	// Token: 0x04007F3B RID: 32571
	[Token(Token = "0x40072DD")]
	[FieldOffset(Offset = "0x6C")]
	private int PlayingEyeVariation;

	// Token: 0x04007F3C RID: 32572
	[Token(Token = "0x40072DE")]
	[FieldOffset(Offset = "0x70")]
	private int PlayingEyeBrowsVariation;

	// Token: 0x04007F3D RID: 32573
	[Token(Token = "0x40072DF")]
	[FieldOffset(Offset = "0x74")]
	private int PlayingMouthVariation;

	// Token: 0x04007F3E RID: 32574
	[Token(Token = "0x40072E0")]
	[FieldOffset(Offset = "0x78")]
	private EyeMouthAnimate EyeMouthAnimate;

	// Token: 0x04007F3F RID: 32575
	[Token(Token = "0x40072E1")]
	[FieldOffset(Offset = "0x80")]
	private AdvEmoconControl Emocon;

	// Token: 0x04007F40 RID: 32576
	[Token(Token = "0x40072E2")]
	[FieldOffset(Offset = "0x88")]
	private bool waitPlayMouth;

	// Token: 0x04007F41 RID: 32577
	[Token(Token = "0x40072E3")]
	[FieldOffset(Offset = "0x8C")]
	private int waitPlayEmoconType;

	// Token: 0x04007F42 RID: 32578
	[Token(Token = "0x40072E4")]
	[FieldOffset(Offset = "0x90")]
	private int waitPlayEmoconLoopStat;

	// Token: 0x04007F43 RID: 32579
	[Token(Token = "0x40072E5")]
	[FieldOffset(Offset = "0x94")]
	private int EyeVariation;

	// Token: 0x04007F44 RID: 32580
	[Token(Token = "0x40072E6")]
	[FieldOffset(Offset = "0x98")]
	private int EyeBrowsVariation;

	// Token: 0x04007F45 RID: 32581
	[Token(Token = "0x40072E7")]
	[FieldOffset(Offset = "0x9C")]
	private int MouthVariation;

	// Token: 0x04007F46 RID: 32582
	[Token(Token = "0x40072E8")]
	[FieldOffset(Offset = "0xA0")]
	private EyeMouthAnimate EyeMouthAnimatorPref;

	// Token: 0x04007F47 RID: 32583
	[Token(Token = "0x40072E9")]
	[FieldOffset(Offset = "0x0")]
	private static EyeMouthAnimate[] EyeMouthAnimates;

	// Token: 0x04007F48 RID: 32584
	[Token(Token = "0x40072EA")]
	[FieldOffset(Offset = "0xA8")]
	private int LoaderId;

	// Token: 0x04007F49 RID: 32585
	[Token(Token = "0x40072EB")]
	[FieldOffset(Offset = "0xAC")]
	private AdvCharaImageControl.AnimStat nowStat;

	// Token: 0x02000913 RID: 2323
	[Token(Token = "0x200127D")]
	public enum CharaAnimateType
	{
		// Token: 0x04007F4B RID: 32587
		[Token(Token = "0x40198C4")]
		MoveDown,
		// Token: 0x04007F4C RID: 32588
		[Token(Token = "0x40198C5")]
		MoveUp,
		// Token: 0x04007F4D RID: 32589
		[Token(Token = "0x40198C6")]
		SideStep,
		// Token: 0x04007F4E RID: 32590
		[Token(Token = "0x40198C7")]
		Reset,
		// Token: 0x04007F4F RID: 32591
		[Token(Token = "0x40198C8")]
		Jump,
		// Token: 0x04007F50 RID: 32592
		[Token(Token = "0x40198C9")]
		Shake,
		// Token: 0x04007F51 RID: 32593
		[Token(Token = "0x40198CA")]
		Max
	}

	// Token: 0x02000914 RID: 2324
	[Token(Token = "0x200127E")]
	private enum AnimStat
	{
		// Token: 0x04007F53 RID: 32595
		[Token(Token = "0x40198CC")]
		NONE,
		// Token: 0x04007F54 RID: 32596
		[Token(Token = "0x40198CD")]
		IN,
		// Token: 0x04007F55 RID: 32597
		[Token(Token = "0x40198CE")]
		IDLE,
		// Token: 0x04007F56 RID: 32598
		[Token(Token = "0x40198CF")]
		OUT,
		// Token: 0x04007F57 RID: 32599
		[Token(Token = "0x40198D0")]
		END,
		// Token: 0x04007F58 RID: 32600
		[Token(Token = "0x40198D1")]
		REMOVE
	}
}
