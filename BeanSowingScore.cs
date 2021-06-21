using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000501 RID: 1281
[Token(Token = "0x20003A8")]
public class BeanSowingScore : MonoBehaviour, IPooledObejct
{
	// Token: 0x06001F40 RID: 8000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x220C0E0", Offset = "0x220C1E1", VA = "0x220C0E0", Slot = "4")]
	public void OnObjectSpawn()
	{
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x220C360", Offset = "0x220C461", VA = "0x220C360")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FA90", Offset = "0x19FB91")]
	private IEnumerator Animation()
	{
		return null;
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x220C0B0", Offset = "0x220C1B1", VA = "0x220C0B0")]
	public void SetScore(int _score)
	{
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x220C410", Offset = "0x220C511", VA = "0x220C410")]
	public BeanSowingScore()
	{
	}

	// Token: 0x04006630 RID: 26160
	[Token(Token = "0x4006098")]
	[FieldOffset(Offset = "0x18")]
	private readonly Vector3 DISTANCE;

	// Token: 0x04006631 RID: 26161
	[Token(Token = "0x4006099")]
	private const float ANIM_TIME = 1f;

	// Token: 0x04006632 RID: 26162
	[Token(Token = "0x400609A")]
	[FieldOffset(Offset = "0x24")]
	private bool firstBoot;

	// Token: 0x04006633 RID: 26163
	[Token(Token = "0x400609B")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rectTrans;

	// Token: 0x04006634 RID: 26164
	[Token(Token = "0x400609C")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 tarPos;

	// Token: 0x04006635 RID: 26165
	[Token(Token = "0x400609D")]
	[FieldOffset(Offset = "0x3C")]
	private float riseSpeed;

	// Token: 0x04006636 RID: 26166
	[Token(Token = "0x400609E")]
	[FieldOffset(Offset = "0x40")]
	private float riseValue;

	// Token: 0x04006637 RID: 26167
	[Token(Token = "0x400609F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private FestivalNumScore numScore;

	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x20010E2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C70", Offset = "0x157D71")]
	private sealed class <Animation>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x220C3E0", Offset = "0x220C4E1", VA = "0x220C3E0")]
		[DebuggerHidden]
		public <Animation>d__9(int <>1__state)
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x220C490", Offset = "0x220C591", VA = "0x220C490", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x6006F71")]
		[Address(RVA = "0x220C4A0", Offset = "0x220C5A1", VA = "0x220C4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9F")]
		private object Current
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0x220C630", Offset = "0x220C731", VA = "0x220C630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F73")]
		[Address(RVA = "0x220C640", Offset = "0x220C741", VA = "0x220C640", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA0")]
		private object Current
		{
			[Token(Token = "0x6006F74")]
			[Address(RVA = "0x220C6A0", Offset = "0x220C7A1", VA = "0x220C6A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006638 RID: 26168
		[Token(Token = "0x401920B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006639 RID: 26169
		[Token(Token = "0x401920C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400663A RID: 26170
		[Token(Token = "0x401920D")]
		[FieldOffset(Offset = "0x20")]
		public BeanSowingScore <>4__this;

		// Token: 0x0400663B RID: 26171
		[Token(Token = "0x401920E")]
		[FieldOffset(Offset = "0x28")]
		private float <time>5__2;
	}
}
