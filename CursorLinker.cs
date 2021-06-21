using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000943 RID: 2371
[Token(Token = "0x2000636")]
public class CursorLinker : MonoBehaviour
{
	// Token: 0x170008D3 RID: 2259
	// (get) Token: 0x06003ECB RID: 16075 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003ECC RID: 16076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000710")]
	public ButtonWorkBase ButtonWork
	{
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x20ED750", Offset = "0x20ED851", VA = "0x20ED750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E40", Offset = "0x1A6F41")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x20ED760", Offset = "0x20ED861", VA = "0x20ED760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E50", Offset = "0x1A6F51")]
		set
		{
		}
	}

	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x06003ECD RID: 16077 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003ECE RID: 16078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000711")]
	public UIItemSlot ItemSlot
	{
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x20ED770", Offset = "0x20ED871", VA = "0x20ED770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x20ED820", Offset = "0x20ED921", VA = "0x20ED820")]
		set
		{
		}
	}

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x06003ECF RID: 16079 RVA: 0x00015660 File Offset: 0x00013860
	// (set) Token: 0x06003ED0 RID: 16080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000712")]
	public bool IsFocusing
	{
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x20ED830", Offset = "0x20ED931", VA = "0x20ED830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E60", Offset = "0x1A6F61")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x20ED840", Offset = "0x20ED941", VA = "0x20ED840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6E70", Offset = "0x1A6F71")]
		private set
		{
		}
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600343E")]
	[Address(RVA = "0x20ED850", Offset = "0x20ED951", VA = "0x20ED850", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06003ED2 RID: 16082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600343F")]
	[Address(RVA = "0x20ED930", Offset = "0x20EDA31", VA = "0x20ED930")]
	private void OnDestroy()
	{
	}

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003ED4 RID: 16084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000713")]
	public CursorLinker BackLink
	{
		[Token(Token = "0x6003440")]
		[Address(RVA = "0x20ECED0", Offset = "0x20ECFD1", VA = "0x20ECED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003441")]
		[Address(RVA = "0x20ED940", Offset = "0x20EDA41", VA = "0x20ED940")]
		set
		{
		}
	}

	// Token: 0x06003ED5 RID: 16085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003442")]
	[Address(RVA = "0x20ED950", Offset = "0x20EDA51", VA = "0x20ED950", Slot = "5")]
	public virtual CursorLinker GetMyCursorLinker()
	{
		return null;
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003443")]
	[Address(RVA = "0x20ED960", Offset = "0x20EDA61", VA = "0x20ED960", Slot = "6")]
	public virtual CursorLinker GetNextObject(CursorLinker.InputMoveType _InType)
	{
		return null;
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x00015678 File Offset: 0x00013878
	[Token(Token = "0x6003444")]
	[Address(RVA = "0x20EB1A0", Offset = "0x20EB2A1", VA = "0x20EB1A0")]
	public Vector2 GetFocusPos()
	{
		return default(Vector2);
	}

	// Token: 0x06003ED8 RID: 16088 RVA: 0x00015690 File Offset: 0x00013890
	[Token(Token = "0x6003445")]
	[Address(RVA = "0x20ED970", Offset = "0x20EDA71", VA = "0x20ED970", Slot = "7")]
	public virtual Vector2 GetImageSize()
	{
		return default(Vector2);
	}

	// Token: 0x06003ED9 RID: 16089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003446")]
	[Address(RVA = "0x20EDA40", Offset = "0x20EDB41", VA = "0x20EDA40", Slot = "8")]
	public virtual void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x06003EDA RID: 16090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003447")]
	[Address(RVA = "0x20EDA50", Offset = "0x20EDB51", VA = "0x20EDA50", Slot = "9")]
	public virtual void InComingFocus(CursorLinker prevObject)
	{
	}

	// Token: 0x06003EDB RID: 16091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003448")]
	[Address(RVA = "0x20EDA60", Offset = "0x20EDB61", VA = "0x20EDA60", Slot = "10")]
	public virtual void OnFocus()
	{
	}

	// Token: 0x06003EDC RID: 16092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003449")]
	[Address(RVA = "0x20EDA80", Offset = "0x20EDB81", VA = "0x20EDA80", Slot = "11")]
	public virtual void EndFocus()
	{
	}

	// Token: 0x06003EDD RID: 16093 RVA: 0x000156A8 File Offset: 0x000138A8
	[Token(Token = "0x600344A")]
	[Address(RVA = "0x20EDAA0", Offset = "0x20EDBA1", VA = "0x20EDAA0", Slot = "12")]
	protected virtual bool CanUpdateCursor()
	{
		return default(bool);
	}

	// Token: 0x06003EDE RID: 16094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600344B")]
	[Address(RVA = "0x20EDB30", Offset = "0x20EDC31", VA = "0x20EDB30", Slot = "13")]
	protected virtual void InitInputLayer()
	{
	}

	// Token: 0x06003EDF RID: 16095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600344C")]
	[Address(RVA = "0x20EDC30", Offset = "0x20EDD31", VA = "0x20EDC30", Slot = "14")]
	protected virtual void ClearInputLayer()
	{
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600344D")]
	[Address(RVA = "0x20EDD20", Offset = "0x20EDE21", VA = "0x20EDD20")]
	protected void UpdateCursor()
	{
	}

	// Token: 0x06003EE1 RID: 16097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600344E")]
	[Address(RVA = "0x20EE020", Offset = "0x20EE121", VA = "0x20EE020", Slot = "15")]
	public virtual void OnTouch()
	{
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600344F")]
	[Address(RVA = "0x20EE1B0", Offset = "0x20EE2B1", VA = "0x20EE1B0")]
	private void Update()
	{
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003450")]
	[Address(RVA = "0x20ED740", Offset = "0x20ED841", VA = "0x20ED740")]
	public CursorLinker()
	{
	}

	// Token: 0x04008065 RID: 32869
	[Token(Token = "0x40073B2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CursorLinker _BackLink;

	// Token: 0x04008066 RID: 32870
	[Token(Token = "0x40073B3")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F570", Offset = "0x16F671")]
	private ButtonWorkBase <ButtonWork>k__BackingField;

	// Token: 0x04008067 RID: 32871
	[Token(Token = "0x40073B4")]
	[FieldOffset(Offset = "0x28")]
	private UIItemSlot _ItemSlot;

	// Token: 0x04008068 RID: 32872
	[Token(Token = "0x40073B5")]
	[FieldOffset(Offset = "0x30")]
	private CursorLinker WorkLink;

	// Token: 0x04008069 RID: 32873
	[Token(Token = "0x40073B6")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform rect;

	// Token: 0x0400806A RID: 32874
	[Token(Token = "0x40073B7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool TouchSelector;

	// Token: 0x0400806B RID: 32875
	[Token(Token = "0x40073B8")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool SubmitOnTouch;

	// Token: 0x0400806C RID: 32876
	[Token(Token = "0x40073B9")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private INPUTLAYER inputLayer;

	// Token: 0x0400806D RID: 32877
	[Token(Token = "0x40073BA")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16F5B0", Offset = "0x16F6B1")]
	private bool <IsFocusing>k__BackingField;

	// Token: 0x02000944 RID: 2372
	[Token(Token = "0x200128F")]
	public enum InputMoveType
	{
		// Token: 0x0400806F RID: 32879
		[Token(Token = "0x4019917")]
		Up,
		// Token: 0x04008070 RID: 32880
		[Token(Token = "0x4019918")]
		Down,
		// Token: 0x04008071 RID: 32881
		[Token(Token = "0x4019919")]
		Left,
		// Token: 0x04008072 RID: 32882
		[Token(Token = "0x401991A")]
		Right,
		// Token: 0x04008073 RID: 32883
		[Token(Token = "0x401991B")]
		None
	}
}
