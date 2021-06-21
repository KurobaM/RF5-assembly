using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200098F RID: 2447
[Token(Token = "0x200066C")]
public class FocusObjectName : MonoBehaviour
{
	// Token: 0x17000900 RID: 2304
	// (get) Token: 0x0600400D RID: 16397 RVA: 0x00015B70 File Offset: 0x00013D70
	// (set) Token: 0x0600400E RID: 16398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000736")]
	public bool IsFocusing
	{
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x1ECC190", Offset = "0x1ECC291", VA = "0x1ECC190")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7270", Offset = "0x1A7371")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x1ECC1A0", Offset = "0x1ECC2A1", VA = "0x1ECC1A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7280", Offset = "0x1A7381")]
		private set
		{
		}
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003561")]
	[Address(RVA = "0x1ECC1B0", Offset = "0x1ECC2B1", VA = "0x1ECC1B0")]
	private void Awake()
	{
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003562")]
	[Address(RVA = "0x1ECC4C0", Offset = "0x1ECC5C1", VA = "0x1ECC4C0")]
	private FocusInterface GetLockOnTarget()
	{
		return null;
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003563")]
	[Address(RVA = "0x1ECC710", Offset = "0x1ECC811", VA = "0x1ECC710")]
	private FocusInterface GetInteractionTarget()
	{
		return null;
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x00015B88 File Offset: 0x00013D88
	[Token(Token = "0x6003564")]
	[Address(RVA = "0x1ECC780", Offset = "0x1ECC881", VA = "0x1ECC780")]
	private Color DefaultColor(FocusInterface focusInterface)
	{
		return default(Color);
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x00015BA0 File Offset: 0x00013DA0
	[Token(Token = "0x6003565")]
	[Address(RVA = "0x1ECC790", Offset = "0x1ECC891", VA = "0x1ECC790")]
	private Color EnemyColor(FocusInterface focusInterface)
	{
		return default(Color);
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003566")]
	[Address(RVA = "0x1ECC9C0", Offset = "0x1ECCAC1", VA = "0x1ECC9C0")]
	private void SetText(string text, Color color)
	{
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003567")]
	[Address(RVA = "0x1ECCB80", Offset = "0x1ECCC81", VA = "0x1ECCB80")]
	private void Start()
	{
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003568")]
	[Address(RVA = "0x1ECCD40", Offset = "0x1ECCE41", VA = "0x1ECCD40")]
	private void UpdateFocus(FocusInterface focusObect)
	{
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003569")]
	[Address(RVA = "0x1ECD030", Offset = "0x1ECD131", VA = "0x1ECD030")]
	private void FocusOn()
	{
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600356A")]
	[Address(RVA = "0x1ECCC80", Offset = "0x1ECCD81", VA = "0x1ECCC80")]
	private void FocusOff()
	{
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600356B")]
	[Address(RVA = "0x1ECD0A0", Offset = "0x1ECD1A1", VA = "0x1ECD0A0")]
	private void Update()
	{
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600356C")]
	[Address(RVA = "0x1ECD230", Offset = "0x1ECD331", VA = "0x1ECD230")]
	public FocusObjectName()
	{
	}

	// Token: 0x04009E56 RID: 40534
	[Token(Token = "0x400775F")]
	[FieldOffset(Offset = "0x18")]
	private readonly Color orange;

	// Token: 0x04009E57 RID: 40535
	[Token(Token = "0x4007760")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text Text;

	// Token: 0x04009E58 RID: 40536
	[Token(Token = "0x4007761")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x04009E59 RID: 40537
	[Token(Token = "0x4007762")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<FocusObjectName.BorderElement> BorderElementList;

	// Token: 0x04009E5A RID: 40538
	[Token(Token = "0x4007763")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<FocusObjectType, FocusObjectName.BorderElement> BorderElementDic;

	// Token: 0x04009E5B RID: 40539
	[Token(Token = "0x4007764")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform MyRect;

	// Token: 0x04009E5C RID: 40540
	[Token(Token = "0x4007765")]
	[FieldOffset(Offset = "0x50")]
	private RectTransform TextRect;

	// Token: 0x04009E5D RID: 40541
	[Token(Token = "0x4007766")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 StartSize;

	// Token: 0x04009E5E RID: 40542
	[Token(Token = "0x4007767")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 StartTextSize;

	// Token: 0x04009E5F RID: 40543
	[Token(Token = "0x4007768")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 OriginalTextSize;

	// Token: 0x04009E60 RID: 40544
	[Token(Token = "0x4007769")]
	[FieldOffset(Offset = "0x70")]
	private List<Func<FocusInterface>> FindFocusObectFucList;

	// Token: 0x04009E61 RID: 40545
	[Token(Token = "0x400776A")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<FocusObjectType, Func<FocusInterface, Color>> GetTextColorFuncDic;

	// Token: 0x04009E62 RID: 40546
	[Token(Token = "0x400776B")]
	[FieldOffset(Offset = "0x80")]
	private FocusInterface CurrentFocusObect;

	// Token: 0x04009E63 RID: 40547
	[Token(Token = "0x400776C")]
	[FieldOffset(Offset = "0x88")]
	private string CurrentFocusName;

	// Token: 0x04009E64 RID: 40548
	[Token(Token = "0x400776D")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16FDD0", Offset = "0x16FED1")]
	private bool <IsFocusing>k__BackingField;

	// Token: 0x04009E65 RID: 40549
	[Token(Token = "0x400776E")]
	[FieldOffset(Offset = "0x98")]
	private CharacterBase LockedTarget;

	// Token: 0x04009E66 RID: 40550
	[Token(Token = "0x400776F")]
	[FieldOffset(Offset = "0xA0")]
	private FocusInterface LockedTargetFocusInterface;

	// Token: 0x04009E67 RID: 40551
	[Token(Token = "0x4007770")]
	[FieldOffset(Offset = "0xA8")]
	private Character EnemyController;

	// Token: 0x04009E68 RID: 40552
	[Token(Token = "0x4007771")]
	[FieldOffset(Offset = "0xB0")]
	private FocusInterface EnemyFocusInterface;

	// Token: 0x04009E69 RID: 40553
	[Token(Token = "0x4007772")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Color COLOR_WHITE;

	// Token: 0x04009E6A RID: 40554
	[Token(Token = "0x4007773")]
	[FieldOffset(Offset = "0xC8")]
	private readonly Color COLOR_RED;

	// Token: 0x04009E6B RID: 40555
	[Token(Token = "0x4007774")]
	[FieldOffset(Offset = "0xD8")]
	private readonly Color COLOR_ORENGE;

	// Token: 0x02000990 RID: 2448
	[Token(Token = "0x20012A5")]
	[Serializable]
	public class BorderElement
	{
		// Token: 0x0600401B RID: 16411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007592")]
		[Address(RVA = "0x1ECD330", Offset = "0x1ECD431", VA = "0x1ECD330")]
		public BorderElement()
		{
		}

		// Token: 0x04009E6C RID: 40556
		[Token(Token = "0x401B35A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public FocusObjectType Type;

		// Token: 0x04009E6D RID: 40557
		[Token(Token = "0x401B35B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Sprite Sprite;
	}
}
