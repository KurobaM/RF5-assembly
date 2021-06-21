using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000815 RID: 2069
[Token(Token = "0x2000554")]
public class NpcSearchCollider : MonoBehaviour
{
	// Token: 0x0600373C RID: 14140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x1F53DE0", Offset = "0x1F53EE1", VA = "0x1F53DE0")]
	private void Awake()
	{
	}

	// Token: 0x0600373D RID: 14141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x1F53E70", Offset = "0x1F53F71", VA = "0x1F53E70")]
	private void Start()
	{
	}

	// Token: 0x0600373E RID: 14142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x1F54010", Offset = "0x1F54111", VA = "0x1F54010")]
	private void OnTriggerEnter(Collider collision)
	{
	}

	// Token: 0x0600373F RID: 14143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x1F54CB0", Offset = "0x1F54DB1", VA = "0x1F54CB0")]
	private void OnTriggerExit(Collider collision)
	{
	}

	// Token: 0x06003740 RID: 14144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x1F54F10", Offset = "0x1F55011", VA = "0x1F54F10")]
	public void OffNpcConflict()
	{
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x1F54F20", Offset = "0x1F55021", VA = "0x1F54F20")]
	private void OffCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x1F550C0", Offset = "0x1F551C1", VA = "0x1F550C0")]
	private void OffNavMeshObstacle()
	{
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x00013128 File Offset: 0x00011328
	[Token(Token = "0x6002DFC")]
	[Address(RVA = "0x1F54BB0", Offset = "0x1F54CB1", VA = "0x1F54BB0")]
	private bool JudgTalk()
	{
		return default(bool);
	}

	// Token: 0x06003744 RID: 14148 RVA: 0x00013140 File Offset: 0x00011340
	[Token(Token = "0x6002DFD")]
	[Address(RVA = "0x1F54840", Offset = "0x1F54941", VA = "0x1F54840")]
	private SoundID RandomVoice(NpcData npcData)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x06003745 RID: 14149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DFE")]
	[Address(RVA = "0x1F55190", Offset = "0x1F55291", VA = "0x1F55190")]
	public NpcSearchCollider()
	{
	}

	// Token: 0x04007A5D RID: 31325
	[Token(Token = "0x4006ECB")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x16B100", Offset = "0x16B201")]
	private List<ValueTuple<FocusInterface, Collider>> enterInteractions;

	// Token: 0x04007A5E RID: 31326
	[Token(Token = "0x4006ECC")]
	[FieldOffset(Offset = "0x20")]
	private NpcController owner;

	// Token: 0x04007A5F RID: 31327
	[Token(Token = "0x4006ECD")]
	[FieldOffset(Offset = "0x28")]
	public NavMeshObstacle NavMeshObstacle;

	// Token: 0x04007A60 RID: 31328
	[Token(Token = "0x4006ECE")]
	[FieldOffset(Offset = "0x30")]
	private bool ConflictCheck;

	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2001246")]
	private enum VoiceType
	{
		// Token: 0x04007A62 RID: 31330
		[Token(Token = "0x40197F8")]
		normal,
		// Token: 0x04007A63 RID: 31331
		[Token(Token = "0x40197F9")]
		callingName,
		// Token: 0x04007A64 RID: 31332
		[Token(Token = "0x40197FA")]
		chilling,
		// Token: 0x04007A65 RID: 31333
		[Token(Token = "0x40197FB")]
		chilling_Anxiety
	}
}
