using System;
using System.Collections.Generic;
using Define;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200058D RID: 1421
[Token(Token = "0x20003FD")]
public class PlayerTeleportButton : MonoBehaviour, InteractionInterface, FocusInterface
{
	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600225F RID: 8799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000477")]
	public string FocusName
	{
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x249A1E0", Offset = "0x249A2E1", VA = "0x249A1E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x249A3C0", Offset = "0x249A4C1", VA = "0x249A3C0")]
		private set
		{
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06002260 RID: 8800 RVA: 0x0000E010 File Offset: 0x0000C210
	[Token(Token = "0x17000478")]
	public bool Focusable
	{
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x249A3D0", Offset = "0x249A4D1", VA = "0x249A3D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x249A400", Offset = "0x249A501", VA = "0x249A400", Slot = "9")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x06002262 RID: 8802 RVA: 0x0000E028 File Offset: 0x0000C228
	// (set) Token: 0x06002263 RID: 8803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000479")]
	public FieldSceneId FieldSceneId
	{
		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x249A410", Offset = "0x249A511", VA = "0x249A410")]
		get
		{
			return FieldSceneId.Empty;
		}
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x249A420", Offset = "0x249A521", VA = "0x249A420")]
		set
		{
		}
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002265 RID: 8805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700047A")]
	public string LoadSceneName
	{
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x249A430", Offset = "0x249A531", VA = "0x249A430")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x249A440", Offset = "0x249A541", VA = "0x249A440")]
		set
		{
		}
	}

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002267 RID: 8807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700047B")]
	public string PlayerTeleportName
	{
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x249A450", Offset = "0x249A551", VA = "0x249A450")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x249A460", Offset = "0x249A561", VA = "0x249A460")]
		set
		{
		}
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x249A470", Offset = "0x249A571", VA = "0x249A470", Slot = "11")]
	public void OnFocus()
	{
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x249A480", Offset = "0x249A581", VA = "0x249A480", Slot = "12")]
	public void OffFocus()
	{
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x0000E040 File Offset: 0x0000C240
	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x249A490", Offset = "0x249A591", VA = "0x249A490", Slot = "16")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x249A550", Offset = "0x249A651", VA = "0x249A550", Slot = "19")]
	public virtual void DoInteraction(HumanController character)
	{
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x0000E058 File Offset: 0x0000C258
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x249A520", Offset = "0x249A621", VA = "0x249A520", Slot = "5")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x249A8E0", Offset = "0x249A9E1", VA = "0x249A8E0", Slot = "6")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x0000E070 File Offset: 0x0000C270
	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x249A8F0", Offset = "0x249A9F1", VA = "0x249A8F0", Slot = "7")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x249A900", Offset = "0x249AA01", VA = "0x249A900", Slot = "8")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x06002270 RID: 8816 RVA: 0x0000E088 File Offset: 0x0000C288
	// (set) Token: 0x06002271 RID: 8817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700047C")]
	public bool IsCollisionTeleport
	{
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x249A950", Offset = "0x249AA51", VA = "0x249A950")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x249A960", Offset = "0x249AA61", VA = "0x249A960")]
		set
		{
		}
	}

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x06002272 RID: 8818 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
	// (set) Token: 0x06002273 RID: 8819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700047D")]
	public bool FallenTeleport
	{
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x249A970", Offset = "0x249AA71", VA = "0x249A970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x249A980", Offset = "0x249AA81", VA = "0x249A980")]
		set
		{
		}
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06002274 RID: 8820 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
	[Token(Token = "0x1700047E")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x249A990", Offset = "0x249AA91", VA = "0x249A990", Slot = "13")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06002275 RID: 8821 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
	[Token(Token = "0x1700047F")]
	public int FocusPriority
	{
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x249A9A0", Offset = "0x249AAA1", VA = "0x249A9A0", Slot = "14")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x06002276 RID: 8822 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
	[Token(Token = "0x17000480")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x249A9B0", Offset = "0x249AAB1", VA = "0x249A9B0", Slot = "15")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x0000E100 File Offset: 0x0000C300
	[Token(Token = "0x6001D10")]
	[Address(RVA = "0x249A9C0", Offset = "0x249AAC1", VA = "0x249A9C0")]
	private static bool CheckInitDictionary()
	{
		return default(bool);
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x0000E118 File Offset: 0x0000C318
	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x249AA70", Offset = "0x249AB71", VA = "0x249AA70")]
	private static bool InitDictionary()
	{
		return default(bool);
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x249A2D0", Offset = "0x249A3D1", VA = "0x249A2D0")]
	private static string GetReplaceName(int replaceNameId, string name)
	{
		return null;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x249B840", Offset = "0x249B941", VA = "0x249B840", Slot = "20")]
	protected virtual void OnTriggerEnter(Collider collision)
	{
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x249B9F0", Offset = "0x249BAF1", VA = "0x249B9F0", Slot = "21")]
	protected virtual void Awake()
	{
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x249BB00", Offset = "0x249BC01", VA = "0x249BB00", Slot = "22")]
	protected virtual void Start()
	{
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x249BE00", Offset = "0x249BF01", VA = "0x249BE00")]
	private void Update()
	{
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x249BF30", Offset = "0x249C031", VA = "0x249BF30", Slot = "23")]
	protected virtual void TeleportScene()
	{
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x249C130", Offset = "0x249C231", VA = "0x249C130")]
	private string GetTeleportSceneName()
	{
		return null;
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x0000E130 File Offset: 0x0000C330
	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x249A5A0", Offset = "0x249A6A1", VA = "0x249A5A0")]
	private bool CheckClosedHouse()
	{
		return default(bool);
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x0000E148 File Offset: 0x0000C348
	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0x249C1A0", Offset = "0x249C2A1", VA = "0x249C1A0")]
	private bool CheckClosedHouseResult(bool result)
	{
		return default(bool);
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x0000E160 File Offset: 0x0000C360
	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x249C200", Offset = "0x249C301", VA = "0x249C200")]
	private bool CheckCloseHouseByNpcs()
	{
		return default(bool);
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x0000E178 File Offset: 0x0000C378
	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x249A810", Offset = "0x249A911", VA = "0x249A810")]
	private bool CheckCloseRideIndoor()
	{
		return default(bool);
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x249C380", Offset = "0x249C481", VA = "0x249C380")]
	public PlayerTeleportButton()
	{
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D1F")]
	[Address(RVA = "0x249C420", Offset = "0x249C521", VA = "0x249C420", Slot = "17")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D20")]
	[Address(RVA = "0x249C430", Offset = "0x249C531", VA = "0x249C430", Slot = "18")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x04006A91 RID: 27281
	[Token(Token = "0x4006424")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected FieldTeleportID FieldTeleportID;

	// Token: 0x04006A92 RID: 27282
	[Token(Token = "0x4006425")]
	[FieldOffset(Offset = "0x20")]
	protected FieldTeleportDataTable Data;

	// Token: 0x04006A93 RID: 27283
	[Token(Token = "0x4006426")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected string FoucsNameTextID;

	// Token: 0x04006A94 RID: 27284
	[Token(Token = "0x4006427")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected string _FocusName;

	// Token: 0x04006A95 RID: 27285
	[Token(Token = "0x4006428")]
	[FieldOffset(Offset = "0x38")]
	protected string _FocusFlagOnName;

	// Token: 0x04006A96 RID: 27286
	[Token(Token = "0x4006429")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected GameFlagData GameFlagData;

	// Token: 0x04006A97 RID: 27287
	[Token(Token = "0x400642A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected string GameFlagDataString;

	// Token: 0x04006A98 RID: 27288
	[Token(Token = "0x400642B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected string _LoadSceneIdString;

	// Token: 0x04006A99 RID: 27289
	[Token(Token = "0x400642C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected FieldSceneId _LoadSceneId;

	// Token: 0x04006A9A RID: 27290
	[Token(Token = "0x400642D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected string _LoadSceneName;

	// Token: 0x04006A9B RID: 27291
	[Token(Token = "0x400642E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected string _PlayerTeleportName;

	// Token: 0x04006A9C RID: 27292
	[Token(Token = "0x400642F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool _IsCollisionTeleport;

	// Token: 0x04006A9D RID: 27293
	[Token(Token = "0x4006430")]
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	private bool _FallenTeleport;

	// Token: 0x04006A9E RID: 27294
	[Token(Token = "0x4006431")]
	[FieldOffset(Offset = "0x74")]
	public float FallenTeleportHeight;

	// Token: 0x04006A9F RID: 27295
	[Token(Token = "0x4006432")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected SoundID SeId;

	// Token: 0x04006AA0 RID: 27296
	[Token(Token = "0x4006433")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, Func<string>> IntaractionNameReplaceDictionary;

	// Token: 0x04006AA1 RID: 27297
	[Token(Token = "0x4006434")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private List<NPCID> _NpcIds;

	// Token: 0x04006AA2 RID: 27298
	[Token(Token = "0x4006435")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private int _OpenTime;

	// Token: 0x04006AA3 RID: 27299
	[Token(Token = "0x4006436")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private int _CloseTime;

	// Token: 0x04006AA4 RID: 27300
	[Token(Token = "0x4006437")]
	[FieldOffset(Offset = "0x90")]
	private Collider _collider;

	// Token: 0x04006AA5 RID: 27301
	[Token(Token = "0x4006438")]
	[FieldOffset(Offset = "0x98")]
	private bool _isClosed;

	// Token: 0x0200058E RID: 1422
	[Token(Token = "0x2001119")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157F50", Offset = "0x158051")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002289 RID: 8841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007053")]
		[Address(RVA = "0x249C4B0", Offset = "0x249C5B1", VA = "0x249C4B0")]
		public <>c()
		{
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007054")]
		[Address(RVA = "0x249C4C0", Offset = "0x249C5C1", VA = "0x249C4C0")]
		internal string <InitDictionary>b__52_0()
		{
			return null;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007055")]
		[Address(RVA = "0x249C530", Offset = "0x249C631", VA = "0x249C530")]
		internal string <InitDictionary>b__52_1()
		{
			return null;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007056")]
		[Address(RVA = "0x249C5A0", Offset = "0x249C6A1", VA = "0x249C5A0")]
		internal string <InitDictionary>b__52_2()
		{
			return null;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007057")]
		[Address(RVA = "0x249C610", Offset = "0x249C711", VA = "0x249C610")]
		internal string <InitDictionary>b__52_3()
		{
			return null;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007058")]
		[Address(RVA = "0x249C680", Offset = "0x249C781", VA = "0x249C680")]
		internal string <InitDictionary>b__52_4()
		{
			return null;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007059")]
		[Address(RVA = "0x249C6F0", Offset = "0x249C7F1", VA = "0x249C6F0")]
		internal string <InitDictionary>b__52_5()
		{
			return null;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705A")]
		[Address(RVA = "0x249C760", Offset = "0x249C861", VA = "0x249C760")]
		internal string <InitDictionary>b__52_6()
		{
			return null;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705B")]
		[Address(RVA = "0x249C7D0", Offset = "0x249C8D1", VA = "0x249C7D0")]
		internal string <InitDictionary>b__52_7()
		{
			return null;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705C")]
		[Address(RVA = "0x249C840", Offset = "0x249C941", VA = "0x249C840")]
		internal string <InitDictionary>b__52_8()
		{
			return null;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705D")]
		[Address(RVA = "0x249C8B0", Offset = "0x249C9B1", VA = "0x249C8B0")]
		internal string <InitDictionary>b__52_9()
		{
			return null;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705E")]
		[Address(RVA = "0x249C920", Offset = "0x249CA21", VA = "0x249C920")]
		internal string <InitDictionary>b__52_10()
		{
			return null;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600705F")]
		[Address(RVA = "0x249C990", Offset = "0x249CA91", VA = "0x249C990")]
		internal string <InitDictionary>b__52_11()
		{
			return null;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007060")]
		[Address(RVA = "0x249CA00", Offset = "0x249CB01", VA = "0x249CA00")]
		internal string <InitDictionary>b__52_12()
		{
			return null;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007061")]
		[Address(RVA = "0x249CA70", Offset = "0x249CB71", VA = "0x249CA70")]
		internal string <InitDictionary>b__52_13()
		{
			return null;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007062")]
		[Address(RVA = "0x249CAE0", Offset = "0x249CBE1", VA = "0x249CAE0")]
		internal string <InitDictionary>b__52_14()
		{
			return null;
		}

		// Token: 0x04006AA6 RID: 27302
		[Token(Token = "0x40192E0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayerTeleportButton.<>c <>9;

		// Token: 0x04006AA7 RID: 27303
		[Token(Token = "0x40192E1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string> <>9__52_0;

		// Token: 0x04006AA8 RID: 27304
		[Token(Token = "0x40192E2")]
		[FieldOffset(Offset = "0x10")]
		public static Func<string> <>9__52_1;

		// Token: 0x04006AA9 RID: 27305
		[Token(Token = "0x40192E3")]
		[FieldOffset(Offset = "0x18")]
		public static Func<string> <>9__52_2;

		// Token: 0x04006AAA RID: 27306
		[Token(Token = "0x40192E4")]
		[FieldOffset(Offset = "0x20")]
		public static Func<string> <>9__52_3;

		// Token: 0x04006AAB RID: 27307
		[Token(Token = "0x40192E5")]
		[FieldOffset(Offset = "0x28")]
		public static Func<string> <>9__52_4;

		// Token: 0x04006AAC RID: 27308
		[Token(Token = "0x40192E6")]
		[FieldOffset(Offset = "0x30")]
		public static Func<string> <>9__52_5;

		// Token: 0x04006AAD RID: 27309
		[Token(Token = "0x40192E7")]
		[FieldOffset(Offset = "0x38")]
		public static Func<string> <>9__52_6;

		// Token: 0x04006AAE RID: 27310
		[Token(Token = "0x40192E8")]
		[FieldOffset(Offset = "0x40")]
		public static Func<string> <>9__52_7;

		// Token: 0x04006AAF RID: 27311
		[Token(Token = "0x40192E9")]
		[FieldOffset(Offset = "0x48")]
		public static Func<string> <>9__52_8;

		// Token: 0x04006AB0 RID: 27312
		[Token(Token = "0x40192EA")]
		[FieldOffset(Offset = "0x50")]
		public static Func<string> <>9__52_9;

		// Token: 0x04006AB1 RID: 27313
		[Token(Token = "0x40192EB")]
		[FieldOffset(Offset = "0x58")]
		public static Func<string> <>9__52_10;

		// Token: 0x04006AB2 RID: 27314
		[Token(Token = "0x40192EC")]
		[FieldOffset(Offset = "0x60")]
		public static Func<string> <>9__52_11;

		// Token: 0x04006AB3 RID: 27315
		[Token(Token = "0x40192ED")]
		[FieldOffset(Offset = "0x68")]
		public static Func<string> <>9__52_12;

		// Token: 0x04006AB4 RID: 27316
		[Token(Token = "0x40192EE")]
		[FieldOffset(Offset = "0x70")]
		public static Func<string> <>9__52_13;

		// Token: 0x04006AB5 RID: 27317
		[Token(Token = "0x40192EF")]
		[FieldOffset(Offset = "0x78")]
		public static Func<string> <>9__52_14;
	}
}
