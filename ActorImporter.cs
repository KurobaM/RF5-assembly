using System;
using System.Collections.Generic;
using ActorReplace;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000BB")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x144CD0", Offset = "0x144DD1")]
public class ActorImporter : MonoBehaviour
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00003B28 File Offset: 0x00001D28
	// (set) Token: 0x060004AA RID: 1194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000113")]
	public ActorID ActorID
	{
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1D4ADB0", Offset = "0x1D4AEB1", VA = "0x1D4ADB0")]
		get
		{
			return ActorID.act000;
		}
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1D4ADC0", Offset = "0x1D4AEC1", VA = "0x1D4ADC0")]
		set
		{
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x060004AB RID: 1195 RVA: 0x00003B40 File Offset: 0x00001D40
	// (set) Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000114")]
	public CharID CharID
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1D4ADD0", Offset = "0x1D4AED1", VA = "0x1D4ADD0")]
		get
		{
			return CharID.ch000;
		}
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1D4ADE0", Offset = "0x1D4AEE1", VA = "0x1D4ADE0")]
		set
		{
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000115")]
	private Transform ParentBase
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1D4ADF0", Offset = "0x1D4AEF1", VA = "0x1D4ADF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1D4AE80", Offset = "0x1D4AF81", VA = "0x1D4AE80")]
	private void Awake()
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1D4B030", Offset = "0x1D4B131", VA = "0x1D4B030")]
	private void OnDestroy()
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1D4B090", Offset = "0x1D4B191", VA = "0x1D4B090")]
	private void OnEnable()
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x1D4AE90", Offset = "0x1D4AF91", VA = "0x1D4AE90")]
	private void OnInit()
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1D4B060", Offset = "0x1D4B161", VA = "0x1D4B060")]
	private void OnEnd()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1D4B0A0", Offset = "0x1D4B1A1", VA = "0x1D4B0A0")]
	private void TakeActor()
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x1D4C860", Offset = "0x1D4C961", VA = "0x1D4C860")]
	private void ReturnActor()
	{
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1D4B460", Offset = "0x1D4B561", VA = "0x1D4B460")]
	private void GetAnimationPlayableAsset()
	{
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1D4BA60", Offset = "0x1D4BB61", VA = "0x1D4BA60")]
	private void ResetElementsReplaceDatas()
	{
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1D4C950", Offset = "0x1D4CA51", VA = "0x1D4C950")]
	private void GetAnimationTrack(TrackAsset track)
	{
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1D4CEF0", Offset = "0x1D4CFF1", VA = "0x1D4CEF0")]
	private void GetChangeAvatorTrack(TrackAsset track)
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1D4D380", Offset = "0x1D4D481", VA = "0x1D4D380")]
	private void GetDialogueTrack(TrackAsset track)
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1D4D810", Offset = "0x1D4D911", VA = "0x1D4D810")]
	private void GetRfAudioTrack(TrackAsset track)
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1D4DCA0", Offset = "0x1D4DDA1", VA = "0x1D4DCA0")]
	private void GetHumanEquipTrack(TrackAsset track)
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1D4BB80", Offset = "0x1D4BC81", VA = "0x1D4BB80")]
	private void Replace(ReplaceData replaceData)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1D4E810", Offset = "0x1D4E911", VA = "0x1D4E810")]
	public ActorImporter()
	{
	}

	// Token: 0x0400028B RID: 651
	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PlayableDirector playableDirector;

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ActorID actorID;

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private CharID charID;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform BaseTransform;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ReplaceData[] replaceDatas;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x38")]
	private List<TimelineClip> animationPlayables;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x40")]
	private List<TimelineClip> changeAvatorClips;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x48")]
	private List<TimelineClip> dialogueClips;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x50")]
	private List<TimelineClip> rfAudioClips;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<ActorID, CharID> otherActors;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x60")]
	private Actor actor_;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x68")]
	private bool actorDispOn_;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x6C")]
	private ActorType actorType_;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x70")]
	private HumanModel humanModel_;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x78")]
	private bool IsInit;

	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x2000FB7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157080", Offset = "0x157181")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BB1")]
		[Address(RVA = "0x1D4E890", Offset = "0x1D4E991", VA = "0x1D4E890")]
		public <>c()
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0x1D4E8A0", Offset = "0x1D4E9A1", VA = "0x1D4E8A0")]
		internal int <Replace>b__37_0(TimelineClip a, TimelineClip b)
		{
			return 0;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0x1D4E8D0", Offset = "0x1D4E9D1", VA = "0x1D4E8D0")]
		internal int <Replace>b__37_1(TimelineClip a, TimelineClip b)
		{
			return 0;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0x1D4E900", Offset = "0x1D4EA01", VA = "0x1D4E900")]
		internal int <Replace>b__37_2(TimelineClip a, TimelineClip b)
		{
			return 0;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6006BB5")]
		[Address(RVA = "0x1D4E930", Offset = "0x1D4EA31", VA = "0x1D4E930")]
		internal int <Replace>b__37_3(TimelineClip a, TimelineClip b)
		{
			return 0;
		}

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x4018D06")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActorImporter.<>c <>9;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x4018D07")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<TimelineClip> <>9__37_0;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x4018D08")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<TimelineClip> <>9__37_1;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x4018D09")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<TimelineClip> <>9__37_2;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x4018D0A")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<TimelineClip> <>9__37_3;
	}
}
