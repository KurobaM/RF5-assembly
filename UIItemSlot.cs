using System;
using Define;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009DE RID: 2526
[Token(Token = "0x200069D")]
public class UIItemSlot : UIButtonLinkerInScrollBox
{
	// Token: 0x1700091C RID: 2332
	// (get) Token: 0x06004213 RID: 16915 RVA: 0x00016440 File Offset: 0x00014640
	// (set) Token: 0x06004214 RID: 16916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700074C")]
	public StorageType StorageType
	{
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x2018470", Offset = "0x2018571", VA = "0x2018470")]
		get
		{
			return StorageType.Rucksack;
		}
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x20184E0", Offset = "0x20185E1", VA = "0x20184E0")]
		set
		{
		}
	}

	// Token: 0x1700091D RID: 2333
	// (get) Token: 0x06004215 RID: 16917 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004216 RID: 16918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700074D")]
	public ItemStorage ItemStorage
	{
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x2018550", Offset = "0x2018651", VA = "0x2018550")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x20186C0", Offset = "0x20187C1", VA = "0x20186C0")]
		set
		{
		}
	}

	// Token: 0x1700091E RID: 2334
	// (get) Token: 0x06004217 RID: 16919 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004218 RID: 16920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700074E")]
	public ItemDataLinker ItemDataLinker
	{
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x2018750", Offset = "0x2018851", VA = "0x2018750")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x2018760", Offset = "0x2018861", VA = "0x2018760")]
		protected set
		{
		}
	}

	// Token: 0x1700091F RID: 2335
	// (get) Token: 0x06004219 RID: 16921 RVA: 0x00016458 File Offset: 0x00014658
	[Token(Token = "0x1700074F")]
	public virtual bool IsEquipItemSlot
	{
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x2018770", Offset = "0x2018871", VA = "0x2018770", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000920 RID: 2336
	// (get) Token: 0x0600421A RID: 16922 RVA: 0x00016470 File Offset: 0x00014670
	[Token(Token = "0x17000750")]
	public virtual EquipSlotType EquipSlotType
	{
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x2018780", Offset = "0x2018881", VA = "0x2018780", Slot = "18")]
		get
		{
			return EquipSlotType.RuneRX;
		}
	}

	// Token: 0x17000921 RID: 2337
	// (get) Token: 0x0600421B RID: 16923 RVA: 0x00016488 File Offset: 0x00014688
	[Token(Token = "0x17000751")]
	public virtual bool isCraftSlot
	{
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x2018790", Offset = "0x2018891", VA = "0x2018790", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000922 RID: 2338
	// (get) Token: 0x0600421C RID: 16924 RVA: 0x000164A0 File Offset: 0x000146A0
	[Token(Token = "0x17000752")]
	public virtual bool isStrengtheningSlot
	{
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x20187A0", Offset = "0x20188A1", VA = "0x20187A0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000923 RID: 2339
	// (get) Token: 0x0600421D RID: 16925 RVA: 0x000164B8 File Offset: 0x000146B8
	// (set) Token: 0x0600421E RID: 16926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000753")]
	public int SlotNum
	{
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x20187B0", Offset = "0x20188B1", VA = "0x20187B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7550", Offset = "0x1A7651")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x20187C0", Offset = "0x20188C1", VA = "0x20187C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7560", Offset = "0x1A7661")]
		private set
		{
		}
	}

	// Token: 0x17000924 RID: 2340
	// (get) Token: 0x0600421F RID: 16927 RVA: 0x000164D0 File Offset: 0x000146D0
	// (set) Token: 0x06004220 RID: 16928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000754")]
	public bool SlotSelecting
	{
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x20187D0", Offset = "0x20188D1", VA = "0x20187D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7570", Offset = "0x1A7671")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x20187E0", Offset = "0x20188E1", VA = "0x20187E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7580", Offset = "0x1A7681")]
		private set
		{
		}
	}

	// Token: 0x17000925 RID: 2341
	// (get) Token: 0x06004221 RID: 16929 RVA: 0x000164E8 File Offset: 0x000146E8
	// (set) Token: 0x06004222 RID: 16930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000755")]
	public bool FilterGuard
	{
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x20187F0", Offset = "0x20188F1", VA = "0x20187F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7590", Offset = "0x1A7691")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x2018800", Offset = "0x2018901", VA = "0x2018800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A75A0", Offset = "0x1A76A1")]
		private set
		{
		}
	}

	// Token: 0x17000926 RID: 2342
	// (get) Token: 0x06004223 RID: 16931 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004224 RID: 16932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000756")]
	public GenerateItemSlot MyGenerator
	{
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x2018810", Offset = "0x2018911", VA = "0x2018810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A75B0", Offset = "0x1A76B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x2018820", Offset = "0x2018921", VA = "0x2018820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A75C0", Offset = "0x1A76C1")]
		private set
		{
		}
	}

	// Token: 0x06004225 RID: 16933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003746")]
	[Address(RVA = "0x2018830", Offset = "0x2018931", VA = "0x2018830", Slot = "21")]
	public virtual void SwapSlotA(UIItemSlot slotB)
	{
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003747")]
	[Address(RVA = "0x2018860", Offset = "0x2018961", VA = "0x2018860", Slot = "22")]
	public virtual void SwapSlotB(UIItemSlot slotA)
	{
	}

	// Token: 0x06004227 RID: 16935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003748")]
	[Address(RVA = "0x2018910", Offset = "0x2018A11", VA = "0x2018910")]
	public UIItemSlot CloneDummy(Transform parent)
	{
		return null;
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x00016500 File Offset: 0x00014700
	[Token(Token = "0x6003749")]
	[Address(RVA = "0x2018A20", Offset = "0x2018B21", VA = "0x2018A20")]
	public bool CheckSameSlot(UIItemSlot targetSlot)
	{
		return default(bool);
	}

	// Token: 0x17000927 RID: 2343
	// (get) Token: 0x06004229 RID: 16937 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600422A RID: 16938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000757")]
	public ItemData ItemData
	{
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x20188F0", Offset = "0x20189F1", VA = "0x20188F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x2018900", Offset = "0x2018A01", VA = "0x2018900")]
		set
		{
		}
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600374C")]
	[Address(RVA = "0x2018BE0", Offset = "0x2018CE1", VA = "0x2018BE0", Slot = "23")]
	protected virtual ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600374D")]
	[Address(RVA = "0x2018C00", Offset = "0x2018D01", VA = "0x2018C00", Slot = "24")]
	protected virtual void SetItemData(ItemData itemData)
	{
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600374E")]
	[Address(RVA = "0x2018C20", Offset = "0x2018D21", VA = "0x2018C20")]
	public void SetSlotType(int slotNum, ItemStorage storage)
	{
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600374F")]
	[Address(RVA = "0x2018D00", Offset = "0x2018E01", VA = "0x2018D00")]
	public void SetSlotType(int slotNum, StorageType storageType)
	{
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003750")]
	[Address(RVA = "0x2018E40", Offset = "0x2018F41", VA = "0x2018E40")]
	public void CheckToCursorTakedItem()
	{
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003751")]
	[Address(RVA = "0x2018EF0", Offset = "0x2018FF1", VA = "0x2018EF0", Slot = "25")]
	public virtual void ReDisp()
	{
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003752")]
	[Address(RVA = "0x2019430", Offset = "0x2019531", VA = "0x2019430")]
	public void CheckSelecting()
	{
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003753")]
	[Address(RVA = "0x2019390", Offset = "0x2019491", VA = "0x2019390")]
	private void SetFilterImage()
	{
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003754")]
	[Address(RVA = "0x2019590", Offset = "0x2019691", VA = "0x2019590")]
	private void SetSelectingImage()
	{
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x00016518 File Offset: 0x00014718
	[Token(Token = "0x6003755")]
	[Address(RVA = "0x2019630", Offset = "0x2019731", VA = "0x2019630", Slot = "26")]
	public virtual bool FilterCheck(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003756")]
	[Address(RVA = "0x20196A0", Offset = "0x20197A1", VA = "0x20196A0")]
	public void SetFilter(UIItemSlot itemSlot)
	{
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003757")]
	[Address(RVA = "0x2019800", Offset = "0x2019901", VA = "0x2019800")]
	public void ReleaseFilter()
	{
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003758")]
	[Address(RVA = "0x2018F90", Offset = "0x2019091", VA = "0x2018F90")]
	private void SetItemImage()
	{
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003759")]
	[Address(RVA = "0x20198A0", Offset = "0x20199A1", VA = "0x20198A0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375A")]
	[Address(RVA = "0x2019930", Offset = "0x2019A31", VA = "0x2019930")]
	private void OnDisable()
	{
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375B")]
	[Address(RVA = "0x2019B10", Offset = "0x2019C11", VA = "0x2019B10", Slot = "27")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375C")]
	[Address(RVA = "0x2019CA0", Offset = "0x2019DA1", VA = "0x2019CA0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375D")]
	[Address(RVA = "0x2019D60", Offset = "0x2019E61", VA = "0x2019D60")]
	private void Start()
	{
	}

	// Token: 0x0600423D RID: 16957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375E")]
	[Address(RVA = "0x2019D80", Offset = "0x2019E81", VA = "0x2019D80", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600375F")]
	[Address(RVA = "0x201A040", Offset = "0x201A141", VA = "0x201A040", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x0600423F RID: 16959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003760")]
	[Address(RVA = "0x2019E00", Offset = "0x2019F01", VA = "0x2019E00")]
	public void SetButtonHint()
	{
	}

	// Token: 0x06004240 RID: 16960 RVA: 0x00016530 File Offset: 0x00014730
	[Token(Token = "0x6003761")]
	[Address(RVA = "0x201A220", Offset = "0x201A321", VA = "0x201A220")]
	protected EquipSlotType GetSlotType(ItemID itemID)
	{
		return EquipSlotType.RuneRX;
	}

	// Token: 0x06004241 RID: 16961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003762")]
	[Address(RVA = "0x201A270", Offset = "0x201A371", VA = "0x201A270", Slot = "28")]
	public virtual void DoEquipInput(ActorID actorId, StorageType storageType)
	{
	}

	// Token: 0x06004242 RID: 16962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003763")]
	[Address(RVA = "0x201A8E0", Offset = "0x201A9E1", VA = "0x201A8E0")]
	private void Update()
	{
	}

	// Token: 0x06004243 RID: 16963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003764")]
	[Address(RVA = "0x201A9A0", Offset = "0x201AAA1", VA = "0x201A9A0")]
	public UIItemSlot()
	{
	}

	// Token: 0x0400A0F0 RID: 41200
	[Token(Token = "0x4007970")]
	[FieldOffset(Offset = "0x70")]
	private StorageType ItemStorageType;

	// Token: 0x0400A0F1 RID: 41201
	[Token(Token = "0x4007971")]
	[FieldOffset(Offset = "0x78")]
	private ItemDataLinker _ItemDataLinker;

	// Token: 0x0400A0F2 RID: 41202
	[Token(Token = "0x4007972")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Image ItemImage;

	// Token: 0x0400A0F3 RID: 41203
	[Token(Token = "0x4007973")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public TextMeshProUGUI ItemAmountText;

	// Token: 0x0400A0F4 RID: 41204
	[Token(Token = "0x4007974")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public Image ItemAmountImage;

	// Token: 0x0400A0F5 RID: 41205
	[Token(Token = "0x4007975")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject ItemSelectingImgObj;

	// Token: 0x0400A0F6 RID: 41206
	[Token(Token = "0x4007976")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject BlockFilterImageObj;

	// Token: 0x0400A0F7 RID: 41207
	[Token(Token = "0x4007977")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170BD0", Offset = "0x170CD1")]
	private int <SlotNum>k__BackingField;

	// Token: 0x0400A0F8 RID: 41208
	[Token(Token = "0x4007978")]
	[FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170BE0", Offset = "0x170CE1")]
	private bool <SlotSelecting>k__BackingField;

	// Token: 0x0400A0F9 RID: 41209
	[Token(Token = "0x4007979")]
	[FieldOffset(Offset = "0xAD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170BF0", Offset = "0x170CF1")]
	private bool <FilterGuard>k__BackingField;

	// Token: 0x0400A0FA RID: 41210
	[Token(Token = "0x400797A")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x170C00", Offset = "0x170D01")]
	private GenerateItemSlot <MyGenerator>k__BackingField;

	// Token: 0x0400A0FB RID: 41211
	[Token(Token = "0x400797B")]
	[FieldOffset(Offset = "0xB8")]
	public ItemID LastDrawItemId;

	// Token: 0x0400A0FC RID: 41212
	[Token(Token = "0x400797C")]
	[FieldOffset(Offset = "0xBC")]
	public int LastDrawAmount;

	// Token: 0x0400A0FD RID: 41213
	[Token(Token = "0x400797D")]
	[FieldOffset(Offset = "0xC0")]
	protected UIItemSlot baseSlot;

	// Token: 0x0400A0FE RID: 41214
	[Token(Token = "0x400797E")]
	[FieldOffset(Offset = "0xC8")]
	public bool isDummySlot;

	// Token: 0x0400A0FF RID: 41215
	[Token(Token = "0x400797F")]
	[FieldOffset(Offset = "0xCC")]
	public int CraftSlotNo;

	// Token: 0x0400A100 RID: 41216
	[Token(Token = "0x4007980")]
	[FieldOffset(Offset = "0xD0")]
	public int StrengtheningSlotNo;
}
