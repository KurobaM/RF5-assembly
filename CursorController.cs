using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200093F RID: 2367
[Token(Token = "0x2000632")]
public class CursorController : MonoBehaviour
{
	// Token: 0x170008CE RID: 2254
	// (get) Token: 0x06003E96 RID: 16022 RVA: 0x00015588 File Offset: 0x00013788
	// (set) Token: 0x06003E97 RID: 16023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700070B")]
	public bool isHide
	{
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x20EAEC0", Offset = "0x20EAFC1", VA = "0x20EAEC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6DE0", Offset = "0x1A6EE1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x20EAED0", Offset = "0x20EAFD1", VA = "0x20EAED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6DF0", Offset = "0x1A6EF1")]
		private set
		{
		}
	}

	// Token: 0x170008CF RID: 2255
	// (get) Token: 0x06003E98 RID: 16024 RVA: 0x000155A0 File Offset: 0x000137A0
	// (set) Token: 0x06003E99 RID: 16025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700070C")]
	public bool IsScrollBoxTopOrBottom
	{
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x20EAEE0", Offset = "0x20EAFE1", VA = "0x20EAEE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E00", Offset = "0x1A6F01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x20EAEF0", Offset = "0x20EAFF1", VA = "0x20EAEF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E10", Offset = "0x1A6F11")]
		set
		{
		}
	}

	// Token: 0x170008D0 RID: 2256
	// (get) Token: 0x06003E9A RID: 16026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700070D")]
	private List<CursorEvent> CursorEventList
	{
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x20EAF00", Offset = "0x20EB001", VA = "0x20EAF00")]
		get
		{
			return null;
		}
	}

	// Token: 0x170008D1 RID: 2257
	// (get) Token: 0x06003E9B RID: 16027 RVA: 0x000155B8 File Offset: 0x000137B8
	// (set) Token: 0x06003E9C RID: 16028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700070E")]
	public bool isActive
	{
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x20EAFA0", Offset = "0x20EB0A1", VA = "0x20EAFA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E20", Offset = "0x1A6F21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x20EAFB0", Offset = "0x20EB0B1", VA = "0x20EAFB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E30", Offset = "0x1A6F31")]
		private set
		{
		}
	}

	// Token: 0x06003E9D RID: 16029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340A")]
	[Address(RVA = "0x20EAFC0", Offset = "0x20EB0C1", VA = "0x20EAFC0")]
	private void InitOnStartUp()
	{
	}

	// Token: 0x06003E9E RID: 16030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340B")]
	[Address(RVA = "0x20EB0B0", Offset = "0x20EB1B1", VA = "0x20EB0B0")]
	private void ReInit()
	{
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340C")]
	[Address(RVA = "0x20EB2B0", Offset = "0x20EB3B1", VA = "0x20EB2B0")]
	private void Awake()
	{
	}

	// Token: 0x06003EA0 RID: 16032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340D")]
	[Address(RVA = "0x20EB2C0", Offset = "0x20EB3C1", VA = "0x20EB2C0")]
	public void Activate([Optional] CursorLinker firstTargetLinker)
	{
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340E")]
	[Address(RVA = "0x20EB660", Offset = "0x20EB761", VA = "0x20EB660")]
	public void Deactivate()
	{
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600340F")]
	[Address(RVA = "0x20EB7C0", Offset = "0x20EB8C1", VA = "0x20EB7C0")]
	public void SetParent(Transform parent)
	{
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003410")]
	[Address(RVA = "0x20E96A0", Offset = "0x20E97A1", VA = "0x20E96A0")]
	public void SetFocus(CursorLinker linker)
	{
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003411")]
	[Address(RVA = "0x20EB4A0", Offset = "0x20EB5A1", VA = "0x20EB4A0")]
	public void ReFocus()
	{
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003412")]
	[Address(RVA = "0x20EBA10", Offset = "0x20EBB11", VA = "0x20EBA10")]
	public void ActiveCursor([Optional] Transform parent)
	{
	}

	// Token: 0x06003EA6 RID: 16038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003413")]
	[Address(RVA = "0x20EBAD0", Offset = "0x20EBBD1", VA = "0x20EBAD0")]
	public void UnActiveCursor()
	{
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003414")]
	[Address(RVA = "0x20EBAE0", Offset = "0x20EBBE1", VA = "0x20EBAE0")]
	public void AddCursorEvent(CursorEvent cursorEvent)
	{
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003415")]
	[Address(RVA = "0x20EBC50", Offset = "0x20EBD51", VA = "0x20EBC50")]
	public void RemoveCursorEvent(CursorEvent cursorEvent)
	{
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x000155D0 File Offset: 0x000137D0
	[Token(Token = "0x6003416")]
	[Address(RVA = "0x20EBD30", Offset = "0x20EBE31", VA = "0x20EBD30")]
	private CursorLinker.InputMoveType GetInputWay()
	{
		return CursorLinker.InputMoveType.Up;
	}

	// Token: 0x06003EAA RID: 16042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003417")]
	[Address(RVA = "0x20EBF60", Offset = "0x20EC061", VA = "0x20EBF60")]
	private void InputMoveCursor()
	{
	}

	// Token: 0x06003EAB RID: 16043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003418")]
	[Address(RVA = "0x20EC090", Offset = "0x20EC191", VA = "0x20EC090")]
	private void OnChangeFocus(CursorLinker targetObj)
	{
	}

	// Token: 0x06003EAC RID: 16044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003419")]
	[Address(RVA = "0x20EB800", Offset = "0x20EB901", VA = "0x20EB800")]
	private void ChangeFocusObject(CursorLinker targetObj)
	{
	}

	// Token: 0x06003EAD RID: 16045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600341A")]
	[Address(RVA = "0x20EC340", Offset = "0x20EC441", VA = "0x20EC340")]
	private void UpdatePos()
	{
	}

	// Token: 0x06003EAE RID: 16046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600341B")]
	[Address(RVA = "0x20EC4C0", Offset = "0x20EC5C1", VA = "0x20EC4C0")]
	public void ForceMoveFocus(CursorLinker targetObj)
	{
	}

	// Token: 0x06003EAF RID: 16047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600341C")]
	[Address(RVA = "0x20EC4D0", Offset = "0x20EC5D1", VA = "0x20EC4D0")]
	public void SetCursorPoint(CursorLinker targetObj)
	{
	}

	// Token: 0x06003EB0 RID: 16048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600341D")]
	[Address(RVA = "0x20EC5D0", Offset = "0x20EC6D1", VA = "0x20EC5D0")]
	private void SetLockFocus()
	{
	}

	// Token: 0x06003EB1 RID: 16049 RVA: 0x000155E8 File Offset: 0x000137E8
	[Token(Token = "0x600341E")]
	[Address(RVA = "0x20EC800", Offset = "0x20EC901", VA = "0x20EC800", Slot = "4")]
	protected virtual bool CanUpdateCursor()
	{
		return default(bool);
	}

	// Token: 0x06003EB2 RID: 16050 RVA: 0x00015600 File Offset: 0x00013800
	[Token(Token = "0x600341F")]
	[Address(RVA = "0x20EC8B0", Offset = "0x20EC9B1", VA = "0x20EC8B0", Slot = "5")]
	protected virtual bool CheckItemIsSelecting()
	{
		return default(bool);
	}

	// Token: 0x06003EB3 RID: 16051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003420")]
	[Address(RVA = "0x20EC910", Offset = "0x20ECA11", VA = "0x20EC910")]
	private void Update()
	{
	}

	// Token: 0x06003EB4 RID: 16052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003421")]
	[Address(RVA = "0x20ED090", Offset = "0x20ED191", VA = "0x20ED090")]
	private void SetItemSprite(ItemData ItemData)
	{
	}

	// Token: 0x06003EB5 RID: 16053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003422")]
	[Address(RVA = "0x20ED130", Offset = "0x20ED231", VA = "0x20ED130")]
	public void SetHideItemSprite(bool hideFlag)
	{
	}

	// Token: 0x06003EB6 RID: 16054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003423")]
	[Address(RVA = "0x20ED160", Offset = "0x20ED261", VA = "0x20ED160")]
	private void SetItemSprite(UIItemSlot pickSlot)
	{
	}

	// Token: 0x06003EB7 RID: 16055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003424")]
	[Address(RVA = "0x20ED230", Offset = "0x20ED331", VA = "0x20ED230")]
	public void PickItem(UIItemSlot pickSlot)
	{
	}

	// Token: 0x06003EB8 RID: 16056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003425")]
	[Address(RVA = "0x20ED270", Offset = "0x20ED371", VA = "0x20ED270")]
	public void PickItem(UIItemSlotsManager.PickingItem pickItem)
	{
	}

	// Token: 0x06003EB9 RID: 16057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003426")]
	[Address(RVA = "0x20ED290", Offset = "0x20ED391", VA = "0x20ED290")]
	public void ReleaseItem()
	{
	}

	// Token: 0x06003EBA RID: 16058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003427")]
	[Address(RVA = "0x20ED390", Offset = "0x20ED491", VA = "0x20ED390")]
	public void SetFirstFocusObj(CursorLinker firstFocusObj)
	{
	}

	// Token: 0x06003EBB RID: 16059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003428")]
	[Address(RVA = "0x20ED3A0", Offset = "0x20ED4A1", VA = "0x20ED3A0")]
	public void ResetFocusObject(CursorLinker cursorLinker)
	{
	}

	// Token: 0x06003EBC RID: 16060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003429")]
	[Address(RVA = "0x20ED410", Offset = "0x20ED511", VA = "0x20ED410")]
	public void SetHide(bool val)
	{
	}

	// Token: 0x06003EBD RID: 16061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600342A")]
	[Address(RVA = "0x20ED440", Offset = "0x20ED541", VA = "0x20ED440")]
	public CursorController()
	{
	}

	// Token: 0x0400804F RID: 32847
	[Token(Token = "0x400739C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CursorController NowCursor;

	// Token: 0x04008050 RID: 32848
	[Token(Token = "0x400739D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CursorLinker NowFocusObject;

	// Token: 0x04008051 RID: 32849
	[Token(Token = "0x400739E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CursorLinker NextFocusObject;

	// Token: 0x04008052 RID: 32850
	[Token(Token = "0x400739F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CursorLinker FirstFocusObject;

	// Token: 0x04008053 RID: 32851
	[Token(Token = "0x40073A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float WaitDelayTime;

	// Token: 0x04008054 RID: 32852
	[Token(Token = "0x40073A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float WaitingDelayTime;

	// Token: 0x04008055 RID: 32853
	[Token(Token = "0x40073A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ItemData HoldedItemData;

	// Token: 0x04008056 RID: 32854
	[Token(Token = "0x40073A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ItemData HoldedDataType;

	// Token: 0x04008057 RID: 32855
	[Token(Token = "0x40073A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ItemData HoldedDataSlot;

	// Token: 0x04008058 RID: 32856
	[Token(Token = "0x40073A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UIMenuCanvasBase UIMenuCanvasBase;

	// Token: 0x04008059 RID: 32857
	[Token(Token = "0x40073A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image MyPickItemImage;

	// Token: 0x0400805A RID: 32858
	[Token(Token = "0x40073A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image CursorPointImage;

	// Token: 0x0400805B RID: 32859
	[Token(Token = "0x40073A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private RectTransform CursorRect;

	// Token: 0x0400805C RID: 32860
	[Token(Token = "0x40073A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool UsePointCursor;

	// Token: 0x0400805D RID: 32861
	[Token(Token = "0x40073AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F520", Offset = "0x16F621")]
	private bool <isHide>k__BackingField;

	// Token: 0x0400805E RID: 32862
	[Token(Token = "0x40073AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F530", Offset = "0x16F631")]
	private bool <IsScrollBoxTopOrBottom>k__BackingField;

	// Token: 0x0400805F RID: 32863
	[Token(Token = "0x40073AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private RectTransform CursorImageRectTransform;

	// Token: 0x04008060 RID: 32864
	[Token(Token = "0x40073AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<CursorEvent> _CursorEventList;

	// Token: 0x04008061 RID: 32865
	[Token(Token = "0x40073AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F540", Offset = "0x16F641")]
	private bool <isActive>k__BackingField;

	// Token: 0x04008062 RID: 32866
	[Token(Token = "0x40073AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform startParentObj;

	// Token: 0x04008063 RID: 32867
	[Token(Token = "0x40073B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool InputBlockerOnItemSortMenu;
}
