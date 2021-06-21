using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200047C RID: 1148
[Token(Token = "0x2000375")]
public class Shake : MonoBehaviour
{
	// Token: 0x06001BD4 RID: 7124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x1E36030", Offset = "0x1E36131", VA = "0x1E36030")]
	private void Awake()
	{
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x1E36110", Offset = "0x1E36211", VA = "0x1E36110")]
	private void Update()
	{
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x1E36350", Offset = "0x1E36451", VA = "0x1E36350")]
	public void ShakeStart(float time, int type, float size)
	{
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x1E362F0", Offset = "0x1E363F1", VA = "0x1E362F0")]
	public void ShakeEnd()
	{
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x1E361B0", Offset = "0x1E362B1", VA = "0x1E361B0")]
	public void DoShake()
	{
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x1E36390", Offset = "0x1E36491", VA = "0x1E36390")]
	public Shake()
	{
	}

	// Token: 0x04006190 RID: 24976
	[Token(Token = "0x4005D8A")]
	[FieldOffset(Offset = "0x18")]
	private bool isShake;

	// Token: 0x04006191 RID: 24977
	[Token(Token = "0x4005D8B")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 basePos;

	// Token: 0x04006192 RID: 24978
	[Token(Token = "0x4005D8C")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 shakeVec;

	// Token: 0x04006193 RID: 24979
	[Token(Token = "0x4005D8D")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform rt;

	// Token: 0x04006194 RID: 24980
	[Token(Token = "0x4005D8E")]
	[FieldOffset(Offset = "0x38")]
	private bool upper;

	// Token: 0x04006195 RID: 24981
	[Token(Token = "0x4005D8F")]
	[FieldOffset(Offset = "0x3C")]
	private float endTime;

	// Token: 0x04006196 RID: 24982
	[Token(Token = "0x4005D90")]
	[FieldOffset(Offset = "0x40")]
	private float deltaTime;

	// Token: 0x04006197 RID: 24983
	[Token(Token = "0x4005D91")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 toPos;
}
