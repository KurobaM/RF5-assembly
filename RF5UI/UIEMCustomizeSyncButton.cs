using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI
{
	// Token: 0x02000E91 RID: 3729
	[Token(Token = "0x200098E")]
	public class UIEMCustomizeSyncButton : ButtonWorkBase
	{
		// Token: 0x06006185 RID: 24965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x1F2D850", Offset = "0x1F2D951", VA = "0x1F2D850", Slot = "5")]
		public override void ButtonWork(Key btnType)
		{
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x1F2D970", Offset = "0x1F2DA71", VA = "0x1F2D970")]
		private void OnEnable()
		{
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x1F2D9C0", Offset = "0x1F2DAC1", VA = "0x1F2D9C0")]
		public UIEMCustomizeSyncButton()
		{
		}

		// Token: 0x0400C132 RID: 49458
		[Token(Token = "0x40090D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image CheckImage;
	}
}
