using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000532 RID: 1330
[Token(Token = "0x20003C5")]
public class PetUI : FestivalUI
{
	// Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x21420F0", Offset = "0x21421F1", VA = "0x21420F0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x2140050", Offset = "0x2140151", VA = "0x2140050")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0230", Offset = "0x1A0331")]
	public IEnumerator OnImageBattle(int _battle_round)
	{
		return null;
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x2141E90", Offset = "0x2141F91", VA = "0x2141E90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A02A0", Offset = "0x1A03A1")]
	public IEnumerator OnImageResult(PetManager.Result _result)
	{
		return null;
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x21421A0", Offset = "0x21422A1", VA = "0x21421A0")]
	public PetUI()
	{
	}

	// Token: 0x0400671F RID: 26399
	[Token(Token = "0x400612C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image[] battleSprites;

	// Token: 0x04006720 RID: 26400
	[Token(Token = "0x400612D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image imageBattle;

	// Token: 0x04006721 RID: 26401
	[Token(Token = "0x400612E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image imageWin;

	// Token: 0x04006722 RID: 26402
	[Token(Token = "0x400612F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image imageLose;

	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x20010F6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D60", Offset = "0x157E61")]
	private sealed class <OnImageBattle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBE")]
		[Address(RVA = "0x2142140", Offset = "0x2142241", VA = "0x2142140")]
		[DebuggerHidden]
		public <OnImageBattle>d__5(int <>1__state)
		{
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBF")]
		[Address(RVA = "0x21421B0", Offset = "0x21422B1", VA = "0x21421B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x6006FC0")]
		[Address(RVA = "0x21421C0", Offset = "0x21422C1", VA = "0x21421C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB8")]
		private object Current
		{
			[Token(Token = "0x6006FC1")]
			[Address(RVA = "0x2142310", Offset = "0x2142411", VA = "0x2142310", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC2")]
		[Address(RVA = "0x2142320", Offset = "0x2142421", VA = "0x2142320", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB9")]
		private object Current
		{
			[Token(Token = "0x6006FC3")]
			[Address(RVA = "0x2142380", Offset = "0x2142481", VA = "0x2142380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006723 RID: 26403
		[Token(Token = "0x4019266")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006724 RID: 26404
		[Token(Token = "0x4019267")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006725 RID: 26405
		[Token(Token = "0x4019268")]
		[FieldOffset(Offset = "0x20")]
		public PetUI <>4__this;

		// Token: 0x04006726 RID: 26406
		[Token(Token = "0x4019269")]
		[FieldOffset(Offset = "0x28")]
		public int _battle_round;
	}

	// Token: 0x02000534 RID: 1332
	[Token(Token = "0x20010F7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D70", Offset = "0x157E71")]
	private sealed class <OnImageResult>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0x2142170", Offset = "0x2142271", VA = "0x2142170")]
		[DebuggerHidden]
		public <OnImageResult>d__6(int <>1__state)
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x2142390", Offset = "0x2142491", VA = "0x2142390", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x21423A0", Offset = "0x21424A1", VA = "0x21423A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBA")]
		private object Current
		{
			[Token(Token = "0x6006FC7")]
			[Address(RVA = "0x2142500", Offset = "0x2142601", VA = "0x2142500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x2142510", Offset = "0x2142611", VA = "0x2142510", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBB")]
		private object Current
		{
			[Token(Token = "0x6006FC9")]
			[Address(RVA = "0x2142570", Offset = "0x2142671", VA = "0x2142570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006727 RID: 26407
		[Token(Token = "0x401926A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006728 RID: 26408
		[Token(Token = "0x401926B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006729 RID: 26409
		[Token(Token = "0x401926C")]
		[FieldOffset(Offset = "0x20")]
		public PetManager.Result _result;

		// Token: 0x0400672A RID: 26410
		[Token(Token = "0x401926D")]
		[FieldOffset(Offset = "0x28")]
		public PetUI <>4__this;
	}
}
