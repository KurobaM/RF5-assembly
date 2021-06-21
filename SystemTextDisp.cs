using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A67 RID: 2663
[Token(Token = "0x20006FE")]
public class SystemTextDisp : MonoBehaviour
{
	// Token: 0x17000964 RID: 2404
	// (get) Token: 0x0600457C RID: 17788 RVA: 0x000170E8 File Offset: 0x000152E8
	// (set) Token: 0x0600457D RID: 17789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700078C")]
	public Vector2 TextSize
	{
		[Token(Token = "0x6003A28")]
		[Address(RVA = "0x1FB4F00", Offset = "0x1FB5001", VA = "0x1FB4F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B50", Offset = "0x1A7C51")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x1FB4F10", Offset = "0x1FB5011", VA = "0x1FB4F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B60", Offset = "0x1A7C61")]
		private set
		{
		}
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A2A")]
	[Address(RVA = "0x1FB4F20", Offset = "0x1FB5021", VA = "0x1FB4F20")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0x1FB5050", Offset = "0x1FB5151", VA = "0x1FB5050")]
	public void SetTextOnCreate(string text)
	{
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A2C")]
	[Address(RVA = "0x1FB5250", Offset = "0x1FB5351", VA = "0x1FB5250")]
	public void AddPos(Vector3 addPos)
	{
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A2D")]
	[Address(RVA = "0x1FB5320", Offset = "0x1FB5421", VA = "0x1FB5320")]
	public SystemTextDisp()
	{
	}

	// Token: 0x0400A450 RID: 42064
	[Token(Token = "0x4007C3D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image Border;

	// Token: 0x0400A451 RID: 42065
	[Token(Token = "0x4007C3E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Text;

	// Token: 0x0400A452 RID: 42066
	[Token(Token = "0x4007C3F")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 startPos;

	// Token: 0x0400A453 RID: 42067
	[Token(Token = "0x4007C40")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172B80", Offset = "0x172C81")]
	private Vector2 <TextSize>k__BackingField;
}
