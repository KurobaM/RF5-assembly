using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B10 RID: 2832
[Token(Token = "0x200075F")]
public class UIMainManagerAttachObject : MonoBehaviour
{
	// Token: 0x0600496E RID: 18798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D66")]
	[Address(RVA = "0x2024000", Offset = "0x2024101", VA = "0x2024000")]
	public UIMainManagerAttachObject()
	{
	}

	// Token: 0x0400A93E RID: 43326
	[Token(Token = "0x4007F7B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<UIMainManagerAttachObject.AttachSet> AttachSets;

	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2001333")]
	[Serializable]
	public struct AttachSet
	{
		// Token: 0x0400A93F RID: 43327
		[Token(Token = "0x401B626")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public UIMainManager.AttachId id;

		// Token: 0x0400A940 RID: 43328
		[Token(Token = "0x401B627")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public GameObject gameobject;
	}
}
