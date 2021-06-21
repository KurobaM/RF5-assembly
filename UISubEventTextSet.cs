using System;
using Il2CppDummyDll;
using RF5UI;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A33 RID: 2611
[Token(Token = "0x20006DC")]
public class UISubEventTextSet : MonoBehaviour
{
	// Token: 0x17000945 RID: 2373
	// (get) Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000771")]
	private SubEventTextConvertData data
	{
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x2121D60", Offset = "0x2121E61", VA = "0x2121D60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000946 RID: 2374
	// (get) Token: 0x0600444D RID: 17485 RVA: 0x00016B78 File Offset: 0x00014D78
	[Token(Token = "0x17000772")]
	private int GetTextId
	{
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x2121E60", Offset = "0x2121F61", VA = "0x2121E60")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003937")]
	[Address(RVA = "0x2121EB0", Offset = "0x2121FB1", VA = "0x2121EB0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003938")]
	[Address(RVA = "0x2121FD0", Offset = "0x21220D1", VA = "0x2121FD0")]
	public UISubEventTextSet()
	{
	}

	// Token: 0x0400A33B RID: 41787
	[Token(Token = "0x4007B6A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text Topic;

	// Token: 0x0400A33C RID: 41788
	[Token(Token = "0x4007B6B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Detail;

	// Token: 0x0400A33D RID: 41789
	[Token(Token = "0x4007B6C")]
	[FieldOffset(Offset = "0x28")]
	private SubEventTextConvertData _data;
}
