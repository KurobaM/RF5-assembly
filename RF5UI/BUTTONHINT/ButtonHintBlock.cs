using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RF5UI.BUTTONHINT
{
	// Token: 0x02000EA1 RID: 3745
	[Token(Token = "0x2000998")]
	public class ButtonHintBlock : MonoBehaviour
	{
		// Token: 0x060061EB RID: 25067 RVA: 0x00020D30 File Offset: 0x0001EF30
		[Token(Token = "0x6005119")]
		[Address(RVA = "0x21810F0", Offset = "0x21811F1", VA = "0x21810F0")]
		public float SetButton(Sprite sprite, int TextNo, float xPos, float paddingWidth)
		{
			return 0f;
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600511A")]
		[Address(RVA = "0x2181520", Offset = "0x2181621", VA = "0x2181520")]
		public ButtonHintBlock()
		{
		}

		// Token: 0x0400C1A7 RID: 49575
		[Token(Token = "0x400912E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text Text;

		// Token: 0x0400C1A8 RID: 49576
		[Token(Token = "0x400912F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image Image;
	}
}
