using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020008B0 RID: 2224
[Token(Token = "0x20005C5")]
public class SymbolFieldInteractionCollider : InteractionColliderBase
{
	// Token: 0x17000875 RID: 2165
	// (get) Token: 0x06003B04 RID: 15108 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B05 RID: 15109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006BA")]
	public FocusInterface[] CurrentFocus
	{
		[Token(Token = "0x6003172")]
		[Address(RVA = "0x1FAC800", Offset = "0x1FAC901", VA = "0x1FAC800")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003173")]
		[Address(RVA = "0x1FAC810", Offset = "0x1FAC911", VA = "0x1FAC810")]
		private set
		{
		}
	}

	// Token: 0x17000876 RID: 2166
	// (get) Token: 0x06003B06 RID: 15110 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B07 RID: 15111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006BB")]
	public Collider[] CurrentFocusCollider
	{
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x1FAC830", Offset = "0x1FAC931", VA = "0x1FAC830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63E0", Offset = "0x1A64E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x1FAC840", Offset = "0x1FAC941", VA = "0x1FAC840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A63F0", Offset = "0x1A64F1")]
		private set
		{
		}
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003176")]
	[Address(RVA = "0x1FAC850", Offset = "0x1FAC951", VA = "0x1FAC850")]
	private void OnDisable()
	{
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003177")]
	[Address(RVA = "0x1FAC9F0", Offset = "0x1FACAF1", VA = "0x1FAC9F0")]
	public void AddIgnore(Collider collider)
	{
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003178")]
	[Address(RVA = "0x1FACA60", Offset = "0x1FACB61", VA = "0x1FACA60")]
	public void RemoveIgnore(Collider collider)
	{
	}

	// Token: 0x06003B0B RID: 15115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003179")]
	[Address(RVA = "0x1FACAD0", Offset = "0x1FACBD1", VA = "0x1FACAD0")]
	public void DoUpdate()
	{
	}

	// Token: 0x06003B0C RID: 15116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600317A")]
	[Address(RVA = "0x1FAC860", Offset = "0x1FAC961", VA = "0x1FAC860")]
	public void ClearFocus()
	{
	}

	// Token: 0x06003B0D RID: 15117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600317B")]
	[Address(RVA = "0x1FADC70", Offset = "0x1FADD71", VA = "0x1FADC70")]
	public SymbolFieldInteractionCollider()
	{
	}

	// Token: 0x04007DC4 RID: 32196
	[Token(Token = "0x40071B1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent OnChangeCurrentInteraction;

	// Token: 0x04007DC5 RID: 32197
	[Token(Token = "0x40071B2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Collider> m_IgnoreList;

	// Token: 0x04007DC6 RID: 32198
	[Token(Token = "0x40071B3")]
	private const int FOCUS_MAX = 10;

	// Token: 0x04007DC7 RID: 32199
	[Token(Token = "0x40071B4")]
	[FieldOffset(Offset = "0x48")]
	private FocusInterface[] _CurrentFocus;

	// Token: 0x04007DC8 RID: 32200
	[Token(Token = "0x40071B5")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E6B0", Offset = "0x16E7B1")]
	private Collider[] <CurrentFocusCollider>k__BackingField;

	// Token: 0x04007DC9 RID: 32201
	[Token(Token = "0x40071B6")]
	protected const int FocusBufferMaxSize = 256;

	// Token: 0x04007DCA RID: 32202
	[Token(Token = "0x40071B7")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16E6C0", Offset = "0x16E7C1")]
	private ValueTuple<Collider, FocusInterface, Vector3>[] m_WorkList;

	// Token: 0x04007DCB RID: 32203
	[Token(Token = "0x40071B8")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<Collider, FocusInterface> m_FocusList;

	// Token: 0x04007DCC RID: 32204
	[Token(Token = "0x40071B9")]
	[FieldOffset(Offset = "0x0")]
	private static SymbolFieldInteractionCollider.Comparer m_Comparer;

	// Token: 0x04007DCD RID: 32205
	[Token(Token = "0x40071BA")]
	[FieldOffset(Offset = "0x68")]
	private FocusInterface[] newFocus;

	// Token: 0x04007DCE RID: 32206
	[Token(Token = "0x40071BB")]
	[FieldOffset(Offset = "0x70")]
	private Collider[] newFocusCollider;

	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x200126E")]
	private class Comparer : IComparer<ValueTuple<Collider, FocusInterface, Vector3>>
	{
		// Token: 0x06003B0F RID: 15119 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x6007479")]
		[Address(RVA = "0x1FADEB0", Offset = "0x1FADFB1", VA = "0x1FADEB0", Slot = "4")]
		public int Compare([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B8150", Offset = "0x1B8251")] ValueTuple<Collider, FocusInterface, Vector3> a, [Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B8210", Offset = "0x1B8311")] ValueTuple<Collider, FocusInterface, Vector3> b)
		{
			return 0;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747A")]
		[Address(RVA = "0x1FADEA0", Offset = "0x1FADFA1", VA = "0x1FADEA0")]
		public Comparer()
		{
		}
	}
}
