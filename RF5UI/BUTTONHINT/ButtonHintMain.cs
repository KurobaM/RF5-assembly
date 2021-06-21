using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI.BUTTONHINT
{
	// Token: 0x02000EA5 RID: 3749
	[Token(Token = "0x200099C")]
	public class ButtonHintMain : MonoBehaviour
	{
		// Token: 0x060061ED RID: 25069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x2181530", Offset = "0x2181631", VA = "0x2181530")]
		private void InitOnStart()
		{
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511C")]
		[Address(RVA = "0x21817C0", Offset = "0x21818C1", VA = "0x21817C0")]
		public void Disp(ButtonGuideId buttonGuideId)
		{
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511D")]
		[Address(RVA = "0x2181CD0", Offset = "0x2181DD1", VA = "0x2181CD0")]
		public void AddBlock(ButtonType button, TextId textId)
		{
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511E")]
		[Address(RVA = "0x21819D0", Offset = "0x2181AD1", VA = "0x21819D0")]
		public void AddBlock(ButtonType button, int textId)
		{
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511F")]
		[Address(RVA = "0x2181990", Offset = "0x2181A91", VA = "0x2181990")]
		public void Clear()
		{
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005120")]
		[Address(RVA = "0x2181CE0", Offset = "0x2181DE1", VA = "0x2181CE0")]
		private void Update()
		{
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x00020D48 File Offset: 0x0001EF48
		[Token(Token = "0x6005121")]
		[Address(RVA = "0x2181EF0", Offset = "0x2181FF1", VA = "0x2181EF0")]
		public bool IsLoading()
		{
			return default(bool);
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005122")]
		[Address(RVA = "0x2181F60", Offset = "0x2182061", VA = "0x2181F60")]
		public ButtonHintMain()
		{
		}

		// Token: 0x0400C1FF RID: 49663
		[Token(Token = "0x4009186")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite[] ButtonSprites;

		// Token: 0x0400C200 RID: 49664
		[Token(Token = "0x4009187")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image Border;

		// Token: 0x0400C201 RID: 49665
		[Token(Token = "0x4009188")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonHintBlock prefabs;

		// Token: 0x0400C202 RID: 49666
		[Token(Token = "0x4009189")]
		[FieldOffset(Offset = "0x30")]
		private RectTransform RectTransform;

		// Token: 0x0400C203 RID: 49667
		[Token(Token = "0x400918A")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 OpenPos;

		// Token: 0x0400C204 RID: 49668
		[Token(Token = "0x400918B")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 ClosePos;

		// Token: 0x0400C205 RID: 49669
		[Token(Token = "0x400918C")]
		private const float MoveTimeMax = 0.15f;

		// Token: 0x0400C206 RID: 49670
		[Token(Token = "0x400918D")]
		[FieldOffset(Offset = "0x50")]
		private float MoveTime;

		// Token: 0x0400C207 RID: 49671
		[Token(Token = "0x400918E")]
		[FieldOffset(Offset = "0x54")]
		private bool isOpen;

		// Token: 0x0400C208 RID: 49672
		[Token(Token = "0x400918F")]
		[FieldOffset(Offset = "0x55")]
		private bool ClearFlag;

		// Token: 0x0400C209 RID: 49673
		[Token(Token = "0x4009190")]
		[FieldOffset(Offset = "0x58")]
		private float totalSize;

		// Token: 0x0400C20A RID: 49674
		[Token(Token = "0x4009191")]
		private const float paddingWidth = 15f;

		// Token: 0x0400C20B RID: 49675
		[Token(Token = "0x4009192")]
		[FieldOffset(Offset = "0x60")]
		private List<ButtonHintBlock> usingObjs;

		// Token: 0x0400C20C RID: 49676
		[Token(Token = "0x4009193")]
		[FieldOffset(Offset = "0x68")]
		private bool StartInited;

		// Token: 0x0400C20D RID: 49677
		[Token(Token = "0x4009194")]
		[FieldOffset(Offset = "0x70")]
		private ButtonGuideDataTable ButtonGuideDataTable;

		// Token: 0x0400C20E RID: 49678
		[Token(Token = "0x4009195")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<ButtonGuideId, int> DataDic;
	}
}
