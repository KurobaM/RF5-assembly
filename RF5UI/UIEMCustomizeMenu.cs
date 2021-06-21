using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI
{
	// Token: 0x02000E8F RID: 3727
	[Token(Token = "0x200098D")]
	public class UIEMCustomizeMenu : UIScrollBoxBase
	{
		// Token: 0x06006177 RID: 24951 RVA: 0x00020B98 File Offset: 0x0001ED98
		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x1F2C4F0", Offset = "0x1F2C5F1", VA = "0x1F2C4F0")]
		public int GetActivedCategorys()
		{
			return 0;
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x1F2CF50", Offset = "0x1F2D051", VA = "0x1F2CF50")]
		private void OnEnable()
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x1F2D250", Offset = "0x1F2D351", VA = "0x1F2D250", Slot = "10")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x1F2D090", Offset = "0x1F2D191", VA = "0x1F2D090")]
		private void Generate()
		{
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x1F2D420", Offset = "0x1F2D521", VA = "0x1F2D420", Slot = "5")]
		protected override int GetListCount()
		{
			return 0;
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x1F2D480", Offset = "0x1F2D581", VA = "0x1F2D480", Slot = "6")]
		protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
		{
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x1F2C590", Offset = "0x1F2C691", VA = "0x1F2C590")]
		public void SetPreview(UIEMCustomizeSet _emset, bool _is_submit = false)
		{
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x1F2BBA0", Offset = "0x1F2BCA1", VA = "0x1F2BBA0")]
		internal void SetFocusingBlock(UIEMCustomizeCategoryBlock uIEMCustomizeCategoryBlock)
		{
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x1F2C2E0", Offset = "0x1F2C3E1", VA = "0x1F2C2E0")]
		internal void DoSelectX(UIEMCustomizeCategoryBlock uIEMCustomizeCategoryBlock)
		{
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x1F2D660", Offset = "0x1F2D761", VA = "0x1F2D660", Slot = "7")]
		public override void SetFocusDetail()
		{
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x1F2D670", Offset = "0x1F2D771", VA = "0x1F2D670")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x1F2D830", Offset = "0x1F2D931", VA = "0x1F2D830")]
		public UIEMCustomizeMenu()
		{
		}

		// Token: 0x0400C122 RID: 49442
		[Token(Token = "0x40090C2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text DetailCategoryText;

		// Token: 0x0400C123 RID: 49443
		[Token(Token = "0x40090C3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text DetailTextBox;

		// Token: 0x0400C124 RID: 49444
		[Token(Token = "0x40090C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text UpText;

		// Token: 0x0400C125 RID: 49445
		[Token(Token = "0x40090C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text DownText;

		// Token: 0x0400C126 RID: 49446
		[Token(Token = "0x40090C6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text NowText;

		// Token: 0x0400C127 RID: 49447
		[Token(Token = "0x40090C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image UpIcon;

		// Token: 0x0400C128 RID: 49448
		[Token(Token = "0x40090C8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image DownIcon;

		// Token: 0x0400C129 RID: 49449
		[Token(Token = "0x40090C9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image NowIcon;

		// Token: 0x0400C12A RID: 49450
		[Token(Token = "0x40090CA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image PadIcon;

		// Token: 0x0400C12B RID: 49451
		[Token(Token = "0x40090CB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite[] OnIcon;

		// Token: 0x0400C12C RID: 49452
		[Token(Token = "0x40090CC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Sprite[] OffIcon;

		// Token: 0x0400C12D RID: 49453
		[Token(Token = "0x40090CD")]
		[FieldOffset(Offset = "0xC0")]
		private UIEMCustomizeCategoryBlock focusingBlock;

		// Token: 0x0400C12E RID: 49454
		[Token(Token = "0x40090CE")]
		[FieldOffset(Offset = "0xC8")]
		private UIEMCustomizeCategoryBlock selectingBlock;

		// Token: 0x0400C12F RID: 49455
		[Token(Token = "0x40090CF")]
		[FieldOffset(Offset = "0xD0")]
		private UIEMCustomizeSet selectingSet;

		// Token: 0x0400C130 RID: 49456
		[Token(Token = "0x40090D0")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIEMCustomizeSet> UIEMCustomizeSets;

		// Token: 0x02000E90 RID: 3728
		[Token(Token = "0x200146E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599F0", Offset = "0x159AF1")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06006183 RID: 24963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B74")]
			[Address(RVA = "0x1F2D650", Offset = "0x1F2D751", VA = "0x1F2D650")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06006184 RID: 24964 RVA: 0x00020BC8 File Offset: 0x0001EDC8
			[Token(Token = "0x6007B75")]
			[Address(RVA = "0x1F2D840", Offset = "0x1F2D941", VA = "0x1F2D840")]
			internal bool <SetPreview>b__0(UIEMCustomizeSet a)
			{
				return default(bool);
			}

			// Token: 0x0400C131 RID: 49457
			[Token(Token = "0x401BC6C")]
			[FieldOffset(Offset = "0x10")]
			public UIEMCustomizeSet _emset;
		}
	}
}
