using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI
{
	// Token: 0x02000E8C RID: 3724
	[Token(Token = "0x200098A")]
	public class UIEMCustomizeCategoryBlock : UIButtonLinkerInScrollBox
	{
		// Token: 0x0600616C RID: 24940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x1F2BB50", Offset = "0x1F2BC51", VA = "0x1F2BB50", Slot = "16")]
		public override void Init()
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x1F2BB60", Offset = "0x1F2BC61", VA = "0x1F2BB60", Slot = "10")]
		public override void OnFocus()
		{
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x1F2BE90", Offset = "0x1F2BF91", VA = "0x1F2BE90", Slot = "8")]
		public override void OnNextFocus(CursorLinker nextObject)
		{
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x1F2BF60", Offset = "0x1F2C061", VA = "0x1F2BF60")]
		public void DispSelect(bool value)
		{
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x1F2C0A0", Offset = "0x1F2C1A1", VA = "0x1F2C0A0")]
		public void Disp(UIEMCustomizeSet _EMSet, Sprite SelectedSprite, Sprite NoSelectSprite, UIEMCustomizeMenu generator)
		{
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x1F2C270", Offset = "0x1F2C371", VA = "0x1F2C270")]
		internal void DoSelectX()
		{
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x1F2C380", Offset = "0x1F2C481", VA = "0x1F2C380")]
		internal void DoSubmit()
		{
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x1F2CDB0", Offset = "0x1F2CEB1", VA = "0x1F2CDB0")]
		public UIEMCustomizeCategoryBlock()
		{
		}

		// Token: 0x0400C114 RID: 49428
		[Token(Token = "0x40090B4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image NoSelectBorder;

		// Token: 0x0400C115 RID: 49429
		[Token(Token = "0x40090B5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image SelectedBorder;

		// Token: 0x0400C116 RID: 49430
		[Token(Token = "0x40090B6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image NoSelectIconImage;

		// Token: 0x0400C117 RID: 49431
		[Token(Token = "0x40090B7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image SelectedIconImage;

		// Token: 0x0400C118 RID: 49432
		[Token(Token = "0x40090B8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image NoSelectCheckImage;

		// Token: 0x0400C119 RID: 49433
		[Token(Token = "0x40090B9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image SelectedCheckImage;

		// Token: 0x0400C11A RID: 49434
		[Token(Token = "0x40090BA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image NoSelectCheckBoxImage;

		// Token: 0x0400C11B RID: 49435
		[Token(Token = "0x40090BB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image SelectedCheckBoxImage;

		// Token: 0x0400C11C RID: 49436
		[Token(Token = "0x40090BC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text NameText;

		// Token: 0x0400C11D RID: 49437
		[Token(Token = "0x40090BD")]
		[FieldOffset(Offset = "0xB8")]
		public UIEMCustomizeSet EMSet;

		// Token: 0x0400C11E RID: 49438
		[Token(Token = "0x40090BE")]
		[FieldOffset(Offset = "0xC0")]
		private UIEMCustomizeMenu MyGenerator;
	}
}
