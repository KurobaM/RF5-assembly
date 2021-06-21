using System;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000A6F RID: 2671
[Token(Token = "0x2000703")]
public class UILoader : UIMenuCanvasBase
{
	// Token: 0x17000968 RID: 2408
	// (get) Token: 0x060045B5 RID: 17845 RVA: 0x00017130 File Offset: 0x00015330
	// (set) Token: 0x060045B6 RID: 17846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700078E")]
	public static bool IsBlockHUD
	{
		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x201CE60", Offset = "0x201CF61", VA = "0x201CE60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C40", Offset = "0x1A7D41")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x201CED0", Offset = "0x201CFD1", VA = "0x201CED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7C50", Offset = "0x1A7D51")]
		set
		{
		}
	}

	// Token: 0x17000969 RID: 2409
	// (get) Token: 0x060045B7 RID: 17847 RVA: 0x00017148 File Offset: 0x00015348
	// (set) Token: 0x060045B8 RID: 17848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700078F")]
	public bool isLoadFinished
	{
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x201CF40", Offset = "0x201D041", VA = "0x201CF40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x201CFF0", Offset = "0x201D0F1", VA = "0x201CFF0")]
		private set
		{
		}
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A5C")]
	[Address(RVA = "0x201D000", Offset = "0x201D101", VA = "0x201D000", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A5D")]
	[Address(RVA = "0x201D130", Offset = "0x201D231", VA = "0x201D130")]
	public void DoOpenCanvas()
	{
	}

	// Token: 0x060045BB RID: 17851 RVA: 0x00017160 File Offset: 0x00015360
	[Token(Token = "0x6003A5E")]
	[Address(RVA = "0x201D2E0", Offset = "0x201D3E1", VA = "0x201D2E0")]
	private static bool Call(int objectNo)
	{
		return default(bool);
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x00017178 File Offset: 0x00015378
	[Token(Token = "0x6003A5F")]
	[Address(RVA = "0x201D6F0", Offset = "0x201D7F1", VA = "0x201D6F0")]
	public static bool Call(UILoader.ObjectNumber objectNo, [Optional] UnityAction callback, bool isAutoPause = true)
	{
		return default(bool);
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A60")]
	[Address(RVA = "0x201D790", Offset = "0x201D891", VA = "0x201D790")]
	public static void SetCloseCallback(UnityAction callback)
	{
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A61")]
	[Address(RVA = "0x201D800", Offset = "0x201D901", VA = "0x201D800")]
	public static void Close()
	{
	}

	// Token: 0x1700096A RID: 2410
	// (get) Token: 0x060045BF RID: 17855 RVA: 0x00017190 File Offset: 0x00015390
	// (set) Token: 0x060045C0 RID: 17856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000790")]
	public static bool IsLoadFinished
	{
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x201D5B0", Offset = "0x201D6B1", VA = "0x201D5B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x201DBC0", Offset = "0x201DCC1", VA = "0x201DBC0")]
		set
		{
		}
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A64")]
	[Address(RVA = "0x201DC40", Offset = "0x201DD41", VA = "0x201DC40")]
	private void AddObject(GameObject gameObject)
	{
	}

	// Token: 0x060045C2 RID: 17858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A65")]
	[Address(RVA = "0x201D1F0", Offset = "0x201D2F1", VA = "0x201D1F0")]
	private void OpenCanvas()
	{
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A66")]
	[Address(RVA = "0x201E030", Offset = "0x201E131", VA = "0x201E030")]
	private void LoadCanvas(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x060045C4 RID: 17860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A67")]
	[Address(RVA = "0x201E0B0", Offset = "0x201E1B1", VA = "0x201E0B0")]
	public void DoCloseCanvas()
	{
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A68")]
	[Address(RVA = "0x201E5D0", Offset = "0x201E6D1", VA = "0x201E5D0", Slot = "7")]
	public override void CloseCanvas()
	{
	}

	// Token: 0x060045C6 RID: 17862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A69")]
	[Address(RVA = "0x201E8D0", Offset = "0x201E9D1", VA = "0x201E8D0")]
	public static void SetGuideMapOpen(GameFlagData gameFlagData)
	{
	}

	// Token: 0x060045C7 RID: 17863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A6A")]
	[Address(RVA = "0x201EAF0", Offset = "0x201EBF1", VA = "0x201EAF0")]
	public UILoader()
	{
	}

	// Token: 0x0400A48A RID: 42122
	[Token(Token = "0x4007C6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static UILoader Instance;

	// Token: 0x0400A48B RID: 42123
	[Token(Token = "0x4007C6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UILoaderFade FadeOpenObj;

	// Token: 0x0400A48C RID: 42124
	[Token(Token = "0x4007C6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UILoaderFade FadeEndObj;

	// Token: 0x0400A48D RID: 42125
	[Token(Token = "0x4007C6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject LoadingObject;

	// Token: 0x0400A48E RID: 42126
	[Token(Token = "0x4007C70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject HeadObject;

	// Token: 0x0400A48F RID: 42127
	[Token(Token = "0x4007C71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static UnityAction CloseCallBack;

	// Token: 0x0400A490 RID: 42128
	[Token(Token = "0x4007C72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool IsAutoPause;

	// Token: 0x0400A491 RID: 42129
	[Token(Token = "0x4007C73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172D30", Offset = "0x172E31")]
	private static bool <IsBlockHUD>k__BackingField;

	// Token: 0x0400A492 RID: 42130
	[Token(Token = "0x4007C74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UIObjectLoadingCheck UIObjectLoadingCheck;

	// Token: 0x0400A493 RID: 42131
	[Token(Token = "0x4007C75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool _isLoadFinished;

	// Token: 0x0400A494 RID: 42132
	[Token(Token = "0x4007C76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int nowObjectNum;

	// Token: 0x0400A495 RID: 42133
	[Token(Token = "0x4007C77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly int[] ObjectIdList;

	// Token: 0x0400A496 RID: 42134
	[Token(Token = "0x4007C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly SoundID[] OpenSound;

	// Token: 0x0400A497 RID: 42135
	[Token(Token = "0x4007C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly SoundID[] CloseSound;

	// Token: 0x0400A498 RID: 42136
	[Token(Token = "0x4007C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly bool[] CursorUseFlag;

	// Token: 0x0400A499 RID: 42137
	[Token(Token = "0x4007C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly bool[] UseFadeOpen;

	// Token: 0x0400A49A RID: 42138
	[Token(Token = "0x4007C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly bool[] UseFadeEnd;

	// Token: 0x0400A49B RID: 42139
	[Token(Token = "0x4007C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly bool[] KillMainCamera;

	// Token: 0x0400A49C RID: 42140
	[Token(Token = "0x4007C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly bool[] BlockCursorEndCanvas;

	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x20012EE")]
	public enum ObjectNumber
	{
		// Token: 0x0400A49E RID: 42142
		[Token(Token = "0x401B482")]
		None,
		// Token: 0x0400A49F RID: 42143
		[Token(Token = "0x401B483")]
		OrderBoard,
		// Token: 0x0400A4A0 RID: 42144
		[Token(Token = "0x401B484")]
		Map,
		// Token: 0x0400A4A1 RID: 42145
		[Token(Token = "0x401B485")]
		ItemBox,
		// Token: 0x0400A4A2 RID: 42146
		[Token(Token = "0x401B486")]
		Refrigerator,
		// Token: 0x0400A4A3 RID: 42147
		[Token(Token = "0x401B487")]
		Calendar,
		// Token: 0x0400A4A4 RID: 42148
		[Token(Token = "0x401B488")]
		FarmToolBox,
		// Token: 0x0400A4A5 RID: 42149
		[Token(Token = "0x401B489")]
		WeaponBox,
		// Token: 0x0400A4A6 RID: 42150
		[Token(Token = "0x401B48A")]
		ArmorBox,
		// Token: 0x0400A4A7 RID: 42151
		[Token(Token = "0x401B48B")]
		BookShelf,
		// Token: 0x0400A4A8 RID: 42152
		[Token(Token = "0x401B48C")]
		Shop,
		// Token: 0x0400A4A9 RID: 42153
		[Token(Token = "0x401B48D")]
		Craft,
		// Token: 0x0400A4AA RID: 42154
		[Token(Token = "0x401B48E")]
		ShopBuild,
		// Token: 0x0400A4AB RID: 42155
		[Token(Token = "0x401B48F")]
		ShippingBox,
		// Token: 0x0400A4AC RID: 42156
		[Token(Token = "0x401B490")]
		MonsterNameing,
		// Token: 0x0400A4AD RID: 42157
		[Token(Token = "0x401B491")]
		BirthdaySelect,
		// Token: 0x0400A4AE RID: 42158
		[Token(Token = "0x401B492")]
		WantedBoard,
		// Token: 0x0400A4AF RID: 42159
		[Token(Token = "0x401B493")]
		MyShopBox,
		// Token: 0x0400A4B0 RID: 42160
		[Token(Token = "0x401B494")]
		MakingWindow,
		// Token: 0x0400A4B1 RID: 42161
		[Token(Token = "0x401B495")]
		ShipmentRecord,
		// Token: 0x0400A4B2 RID: 42162
		[Token(Token = "0x401B496")]
		Strengthening,
		// Token: 0x0400A4B3 RID: 42163
		[Token(Token = "0x401B497")]
		MovieRoom,
		// Token: 0x0400A4B4 RID: 42164
		[Token(Token = "0x401B498")]
		NamingWindow,
		// Token: 0x0400A4B5 RID: 42165
		[Token(Token = "0x401B499")]
		Max
	}
}
