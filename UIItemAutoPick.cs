using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009DC RID: 2524
[Token(Token = "0x200069B")]
public class UIItemAutoPick : SingletonMonoBehaviour<UIItemAutoPick>
{
	// Token: 0x06004201 RID: 16897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003722")]
	[Address(RVA = "0x2011460", Offset = "0x2011561", VA = "0x2011460")]
	private void Start()
	{
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003723")]
	[Address(RVA = "0x2011500", Offset = "0x2011601", VA = "0x2011500")]
	private void Update()
	{
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003724")]
	[Address(RVA = "0x2011860", Offset = "0x2011961", VA = "0x2011860")]
	private void StartItemAnim(ItemData _item)
	{
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003725")]
	[Address(RVA = "0x20119C0", Offset = "0x2011AC1", VA = "0x20119C0")]
	public void AddItem(ItemData _item)
	{
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003726")]
	[Address(RVA = "0x2011A30", Offset = "0x2011B31", VA = "0x2011A30")]
	public void ClearItemList()
	{
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003727")]
	[Address(RVA = "0x2011A90", Offset = "0x2011B91", VA = "0x2011A90")]
	public UIItemAutoPick()
	{
	}

	// Token: 0x0400A0E1 RID: 41185
	[Token(Token = "0x4007961")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject itemObject;

	// Token: 0x0400A0E2 RID: 41186
	[Token(Token = "0x4007962")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image itemIcon;

	// Token: 0x0400A0E3 RID: 41187
	[Token(Token = "0x4007963")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform itemNameRect;

	// Token: 0x0400A0E4 RID: 41188
	[Token(Token = "0x4007964")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text itemName;

	// Token: 0x0400A0E5 RID: 41189
	[Token(Token = "0x4007965")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve fadeCurve;

	// Token: 0x0400A0E6 RID: 41190
	[Token(Token = "0x4007966")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve slideCurve;

	// Token: 0x0400A0E7 RID: 41191
	[Token(Token = "0x4007967")]
	[FieldOffset(Offset = "0x48")]
	private CanvasGroup canvasGroup;

	// Token: 0x0400A0E8 RID: 41192
	[Token(Token = "0x4007968")]
	[FieldOffset(Offset = "0x50")]
	private Queue<ItemData> pickedItemList;

	// Token: 0x0400A0E9 RID: 41193
	[Token(Token = "0x4007969")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 itemObjectPos;

	// Token: 0x0400A0EA RID: 41194
	[Token(Token = "0x400796A")]
	[FieldOffset(Offset = "0x64")]
	private bool isPlaying;

	// Token: 0x0400A0EB RID: 41195
	[Token(Token = "0x400796B")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float animHeight;

	// Token: 0x0400A0EC RID: 41196
	[Token(Token = "0x400796C")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float curveSpeed;

	// Token: 0x0400A0ED RID: 41197
	[Token(Token = "0x400796D")]
	[FieldOffset(Offset = "0x70")]
	private float curveRate;
}
