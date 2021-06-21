using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000BA4 RID: 2980
[Token(Token = "0x20007B9")]
public class CameraSwitch : MonoBehaviour
{
	// Token: 0x06004C54 RID: 19540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004001")]
	[Address(RVA = "0x1E792E0", Offset = "0x1E793E1", VA = "0x1E792E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004C55 RID: 19541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004002")]
	[Address(RVA = "0x1E79360", Offset = "0x1E79461", VA = "0x1E79360")]
	public void NextCamera()
	{
	}

	// Token: 0x06004C56 RID: 19542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004003")]
	[Address(RVA = "0x1E79440", Offset = "0x1E79541", VA = "0x1E79440")]
	public CameraSwitch()
	{
	}

	// Token: 0x0400ADBD RID: 44477
	[Token(Token = "0x40082E6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] objects;

	// Token: 0x0400ADBE RID: 44478
	[Token(Token = "0x40082E7")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	// Token: 0x0400ADBF RID: 44479
	[Token(Token = "0x40082E8")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurrentActiveObject;
}
