using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000610 RID: 1552
[Token(Token = "0x200045E")]
public class InputLayerManager : SingletonMonoBehaviour<InputLayerManager>
{
	// Token: 0x06002661 RID: 9825 RVA: 0x0000F258 File Offset: 0x0000D458
	[Token(Token = "0x6002065")]
	[Address(RVA = "0x22311E0", Offset = "0x22312E1", VA = "0x22311E0")]
	public bool GetPermit(INPUTLAYER layer)
	{
		return default(bool);
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002066")]
	[Address(RVA = "0x2231290", Offset = "0x2231391", VA = "0x2231290")]
	public void AddObjectLayer(GameObject obj, INPUTLAYER layer = INPUTLAYER.Default)
	{
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002067")]
	[Address(RVA = "0x2231380", Offset = "0x2231481", VA = "0x2231380")]
	public void RemoveObjectLayer(GameObject obj, INPUTLAYER layer = INPUTLAYER.None)
	{
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002068")]
	[Address(RVA = "0x2231440", Offset = "0x2231541", VA = "0x2231440")]
	public void CleanObjectLayer(INPUTLAYER layer)
	{
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002069")]
	[Address(RVA = "0x2230AA0", Offset = "0x2230BA1", VA = "0x2230AA0")]
	public void CleanObjectLayers()
	{
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600206A")]
	[Address(RVA = "0x2231580", Offset = "0x2231681", VA = "0x2231580", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600206B")]
	[Address(RVA = "0x2231690", Offset = "0x2231791", VA = "0x2231690")]
	private void Update()
	{
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600206C")]
	[Address(RVA = "0x22316A0", Offset = "0x22317A1", VA = "0x22316A0")]
	public InputLayerManager()
	{
	}

	// Token: 0x04006D96 RID: 28054
	[Token(Token = "0x4006696")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject>[] InputLayers;

	// Token: 0x04006D97 RID: 28055
	[Token(Token = "0x4006697")]
	[FieldOffset(Offset = "0x20")]
	private bool CheckCleanLayer;

	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x200113B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580E0", Offset = "0x1581E1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070E8")]
		[Address(RVA = "0x2231790", Offset = "0x2231891", VA = "0x2231790")]
		public <>c()
		{
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x60070E9")]
		[Address(RVA = "0x22317A0", Offset = "0x22318A1", VA = "0x22317A0")]
		internal bool <CleanObjectLayer>b__5_0(GameObject a)
		{
			return default(bool);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x60070EA")]
		[Address(RVA = "0x2231850", Offset = "0x2231951", VA = "0x2231850")]
		internal bool <CleanObjectLayers>b__6_0(GameObject a)
		{
			return default(bool);
		}

		// Token: 0x04006D98 RID: 28056
		[Token(Token = "0x4019373")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InputLayerManager.<>c <>9;

		// Token: 0x04006D99 RID: 28057
		[Token(Token = "0x4019374")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<GameObject> <>9__5_0;

		// Token: 0x04006D9A RID: 28058
		[Token(Token = "0x4019375")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<GameObject> <>9__6_0;
	}
}
