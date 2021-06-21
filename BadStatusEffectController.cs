using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using RF5_Sound;
using UnityEngine;

// Token: 0x02000891 RID: 2193
[Token(Token = "0x20005AC")]
[Serializable]
public class BadStatusEffectController : MonoBehaviour
{
	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x060039B6 RID: 14774 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000645")]
	private SEController SEController
	{
		[Token(Token = "0x6003029")]
		[Address(RVA = "0x229A740", Offset = "0x229A841", VA = "0x229A740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5EB0", Offset = "0x1A5FB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600302A")]
		[Address(RVA = "0x229A750", Offset = "0x229A851", VA = "0x229A750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5EC0", Offset = "0x1A5FC1")]
		set
		{
		}
	}

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x060039B8 RID: 14776 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000646")]
	private Dictionary<BadStatus, BadStatusEffectController.ObjInfo> EffectObjectDic
	{
		[Token(Token = "0x600302B")]
		[Address(RVA = "0x229A760", Offset = "0x229A861", VA = "0x229A760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5ED0", Offset = "0x1A5FD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600302C")]
		[Address(RVA = "0x229A770", Offset = "0x229A871", VA = "0x229A770")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5EE0", Offset = "0x1A5FE1")]
		set
		{
		}
	}

	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x060039BA RID: 14778 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000647")]
	private List<BadStatus> BadStatusList
	{
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x229A780", Offset = "0x229A881", VA = "0x229A780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5EF0", Offset = "0x1A5FF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x229A790", Offset = "0x229A891", VA = "0x229A790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F00", Offset = "0x1A6001")]
		set
		{
		}
	}

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x060039BC RID: 14780 RVA: 0x00013F38 File Offset: 0x00012138
	// (set) Token: 0x060039BD RID: 14781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000648")]
	private BadStatus PrevFrameBadStatus
	{
		[Token(Token = "0x600302F")]
		[Address(RVA = "0x229A7A0", Offset = "0x229A8A1", VA = "0x229A7A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F10", Offset = "0x1A6011")]
		get
		{
			return BadStatus.None;
		}
		[Token(Token = "0x6003030")]
		[Address(RVA = "0x229A7B0", Offset = "0x229A8B1", VA = "0x229A7B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F20", Offset = "0x1A6021")]
		set
		{
		}
	}

	// Token: 0x17000804 RID: 2052
	// (get) Token: 0x060039BE RID: 14782 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039BF RID: 14783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000649")]
	private global::Character Character
	{
		[Token(Token = "0x6003031")]
		[Address(RVA = "0x229A7C0", Offset = "0x229A8C1", VA = "0x229A7C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F30", Offset = "0x1A6031")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003032")]
		[Address(RVA = "0x229A7D0", Offset = "0x229A8D1", VA = "0x229A7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F40", Offset = "0x1A6041")]
		set
		{
		}
	}

	// Token: 0x17000805 RID: 2053
	// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00013F50 File Offset: 0x00012150
	// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700064A")]
	private int CurrentBadStatusIndex
	{
		[Token(Token = "0x6003033")]
		[Address(RVA = "0x229A7E0", Offset = "0x229A8E1", VA = "0x229A7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F50", Offset = "0x1A6051")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003034")]
		[Address(RVA = "0x229A7F0", Offset = "0x229A8F1", VA = "0x229A7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F60", Offset = "0x1A6061")]
		set
		{
		}
	}

	// Token: 0x17000806 RID: 2054
	// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00013F68 File Offset: 0x00012168
	// (set) Token: 0x060039C3 RID: 14787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700064B")]
	private float ElapsedTime
	{
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x229A800", Offset = "0x229A901", VA = "0x229A800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F70", Offset = "0x1A6071")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x229A810", Offset = "0x229A911", VA = "0x229A810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F80", Offset = "0x1A6081")]
		set
		{
		}
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003037")]
	[Address(RVA = "0x229A820", Offset = "0x229A921", VA = "0x229A820")]
	private void Awake()
	{
	}

	// Token: 0x060039C5 RID: 14789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003038")]
	[Address(RVA = "0x229A880", Offset = "0x229A981", VA = "0x229A880")]
	private void Update()
	{
	}

	// Token: 0x060039C6 RID: 14790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003039")]
	[Address(RVA = "0x229B270", Offset = "0x229B371", VA = "0x229B270")]
	private void Display(BadStatus id)
	{
	}

	// Token: 0x060039C7 RID: 14791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600303A")]
	[Address(RVA = "0x229B540", Offset = "0x229B641", VA = "0x229B540")]
	private void Remove(BadStatus id)
	{
	}

	// Token: 0x060039C8 RID: 14792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600303B")]
	[Address(RVA = "0x229B640", Offset = "0x229B741", VA = "0x229B640")]
	private void SetDisplayBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x060039C9 RID: 14793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600303C")]
	[Address(RVA = "0x229B760", Offset = "0x229B861", VA = "0x229B760")]
	private void OnDestroy()
	{
	}

	// Token: 0x060039CA RID: 14794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600303D")]
	[Address(RVA = "0x229B910", Offset = "0x229BA11", VA = "0x229B910")]
	public BadStatusEffectController()
	{
	}

	// Token: 0x04007D4C RID: 32076
	[Token(Token = "0x400714A")]
	public const string PointName = "StatusEffect_Point";

	// Token: 0x04007D4D RID: 32077
	[Token(Token = "0x400714B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<BadStatus, Prefab> AssetIDs;

	// Token: 0x04007D4E RID: 32078
	[Token(Token = "0x400714C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E380", Offset = "0x16E481")]
	private SEController <SEController>k__BackingField;

	// Token: 0x04007D4F RID: 32079
	[Token(Token = "0x400714D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E390", Offset = "0x16E491")]
	private Dictionary<BadStatus, BadStatusEffectController.ObjInfo> <EffectObjectDic>k__BackingField;

	// Token: 0x04007D50 RID: 32080
	[Token(Token = "0x400714E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3A0", Offset = "0x16E4A1")]
	private List<BadStatus> <BadStatusList>k__BackingField;

	// Token: 0x04007D51 RID: 32081
	[Token(Token = "0x400714F")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3B0", Offset = "0x16E4B1")]
	private BadStatus <PrevFrameBadStatus>k__BackingField;

	// Token: 0x04007D52 RID: 32082
	[Token(Token = "0x4007150")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3C0", Offset = "0x16E4C1")]
	private global::Character <Character>k__BackingField;

	// Token: 0x04007D53 RID: 32083
	[Token(Token = "0x4007151")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3D0", Offset = "0x16E4D1")]
	private int <CurrentBadStatusIndex>k__BackingField;

	// Token: 0x04007D54 RID: 32084
	[Token(Token = "0x4007152")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3E0", Offset = "0x16E4E1")]
	private float <ElapsedTime>k__BackingField;

	// Token: 0x04007D55 RID: 32085
	[Token(Token = "0x4007153")]
	[FieldOffset(Offset = "0x48")]
	private readonly float MultiDisplayTime;

	// Token: 0x04007D56 RID: 32086
	[Token(Token = "0x4007154")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsInvisibleEffect;

	// Token: 0x02000892 RID: 2194
	[Token(Token = "0x2001268")]
	private enum ObjectState
	{
		// Token: 0x04007D58 RID: 32088
		[Token(Token = "0x4019868")]
		None,
		// Token: 0x04007D59 RID: 32089
		[Token(Token = "0x4019869")]
		Load,
		// Token: 0x04007D5A RID: 32090
		[Token(Token = "0x401986A")]
		Disp,
		// Token: 0x04007D5B RID: 32091
		[Token(Token = "0x401986B")]
		Hide
	}

	// Token: 0x02000893 RID: 2195
	[Token(Token = "0x2001269")]
	private class ObjInfo
	{
		// Token: 0x060039CC RID: 14796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007474")]
		[Address(RVA = "0x229BBD0", Offset = "0x229BCD1", VA = "0x229BBD0")]
		public ObjInfo(BadStatusEffectController.ObjectState state, GameObject obj)
		{
		}

		// Token: 0x04007D5C RID: 32092
		[Token(Token = "0x401986C")]
		[FieldOffset(Offset = "0x10")]
		public BadStatusEffectController.ObjectState State;

		// Token: 0x04007D5D RID: 32093
		[Token(Token = "0x401986D")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Obj;
	}

	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x200126A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158D70", Offset = "0x158E71")]
	private sealed class <>c__DisplayClass36_0
	{
		// Token: 0x060039CD RID: 14797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007475")]
		[Address(RVA = "0x229B630", Offset = "0x229B731", VA = "0x229B630")]
		public <>c__DisplayClass36_0()
		{
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007476")]
		[Address(RVA = "0x229BD50", Offset = "0x229BE51", VA = "0x229BD50")]
		internal void <Display>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04007D5E RID: 32094
		[Token(Token = "0x401986E")]
		[FieldOffset(Offset = "0x10")]
		public BadStatus id;

		// Token: 0x04007D5F RID: 32095
		[Token(Token = "0x401986F")]
		[FieldOffset(Offset = "0x18")]
		public BadStatusEffectController <>4__this;
	}
}
