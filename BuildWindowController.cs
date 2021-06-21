using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009EB RID: 2539
[Token(Token = "0x20006A7")]
public class BuildWindowController : MonoBehaviour
{
	// Token: 0x0600428A RID: 17034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A5")]
	[Address(RVA = "0x218CA70", Offset = "0x218CB71", VA = "0x218CA70")]
	private void Awake()
	{
	}

	// Token: 0x0600428B RID: 17035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A6")]
	[Address(RVA = "0x218CE70", Offset = "0x218CF71", VA = "0x218CE70")]
	private void OnEnable()
	{
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60037A7")]
	[Address(RVA = "0x218CF00", Offset = "0x218D001", VA = "0x218CF00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A75E0", Offset = "0x1A76E1")]
	private IEnumerator OnEnableAnim()
	{
		return null;
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A8")]
	[Address(RVA = "0x218CFB0", Offset = "0x218D0B1", VA = "0x218CFB0")]
	private void Start()
	{
	}

	// Token: 0x0600428E RID: 17038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037A9")]
	[Address(RVA = "0x218CFC0", Offset = "0x218D0C1", VA = "0x218CFC0")]
	private void Update()
	{
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AA")]
	[Address(RVA = "0x218CAB0", Offset = "0x218CBB1", VA = "0x218CAB0")]
	private void FineObject()
	{
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AB")]
	[Address(RVA = "0x218CFD0", Offset = "0x218D0D1", VA = "0x218CFD0")]
	private void setBuildName(int buildNo)
	{
	}

	// Token: 0x06004291 RID: 17041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AC")]
	[Address(RVA = "0x218D2B0", Offset = "0x218D3B1", VA = "0x218D2B0")]
	private void setWindowSize(int buildNo)
	{
	}

	// Token: 0x06004292 RID: 17042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AD")]
	[Address(RVA = "0x218D590", Offset = "0x218D691", VA = "0x218D590")]
	private void setPosition(int type)
	{
	}

	// Token: 0x06004293 RID: 17043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AE")]
	[Address(RVA = "0x218D3F0", Offset = "0x218D4F1", VA = "0x218D3F0")]
	private void setNPCIcon(int buildNo)
	{
	}

	// Token: 0x06004294 RID: 17044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037AF")]
	[Address(RVA = "0x218D680", Offset = "0x218D781", VA = "0x218D680")]
	private void setBuildPhoto(int buildNo)
	{
	}

	// Token: 0x06004295 RID: 17045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B0")]
	[Address(RVA = "0x218D930", Offset = "0x218DA31", VA = "0x218D930")]
	private void setBuildIcon(int buildNo)
	{
	}

	// Token: 0x06004296 RID: 17046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x218DAC0", Offset = "0x218DBC1", VA = "0x218DAC0")]
	public void setBuildWindow(int buildNo, int posType)
	{
	}

	// Token: 0x06004297 RID: 17047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B2")]
	[Address(RVA = "0x218DB50", Offset = "0x218DC51", VA = "0x218DB50")]
	public BuildWindowController()
	{
	}

	// Token: 0x0400A12F RID: 41263
	[Token(Token = "0x40079A9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform parentRect;

	// Token: 0x0400A130 RID: 41264
	[Token(Token = "0x40079AA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform windowRect;

	// Token: 0x0400A131 RID: 41265
	[Token(Token = "0x40079AB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject iconParent;

	// Token: 0x0400A132 RID: 41266
	[Token(Token = "0x40079AC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image PhotoImg;

	// Token: 0x0400A133 RID: 41267
	[Token(Token = "0x40079AD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text buildName;

	// Token: 0x0400A134 RID: 41268
	[Token(Token = "0x40079AE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Image IconImg;

	// Token: 0x0400A135 RID: 41269
	[Token(Token = "0x40079AF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite[] BuildPhoto_Before;

	// Token: 0x0400A136 RID: 41270
	[Token(Token = "0x40079B0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite[] BuildPhoto_After;

	// Token: 0x0400A137 RID: 41271
	[Token(Token = "0x40079B1")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private string[] BuildName_Before;

	// Token: 0x0400A138 RID: 41272
	[Token(Token = "0x40079B2")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private string[] BuildName_After;

	// Token: 0x0400A139 RID: 41273
	[Token(Token = "0x40079B3")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite[] BuildIcon;

	// Token: 0x0400A13A RID: 41274
	[Token(Token = "0x40079B4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private MapControl mapCntl;

	// Token: 0x0400A13B RID: 41275
	[Token(Token = "0x40079B5")]
	[FieldOffset(Offset = "0x78")]
	private Image[] iconList;

	// Token: 0x0400A13C RID: 41276
	[Token(Token = "0x40079B6")]
	[FieldOffset(Offset = "0x80")]
	private GameObject[] photoList;

	// Token: 0x0400A13D RID: 41277
	[Token(Token = "0x40079B7")]
	[FieldOffset(Offset = "0x88")]
	private int[,] buildList;

	// Token: 0x020009EC RID: 2540
	[Token(Token = "0x20012C6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158FA0", Offset = "0x1590A1")]
	private sealed class <OnEnableAnim>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004298 RID: 17048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C9")]
		[Address(RVA = "0x218CF80", Offset = "0x218D081", VA = "0x218CF80")]
		[DebuggerHidden]
		public <OnEnableAnim>d__17(int <>1__state)
		{
		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CA")]
		[Address(RVA = "0x218DB60", Offset = "0x218DC61", VA = "0x218DB60", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0x218DB70", Offset = "0x218DC71", VA = "0x218DB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8D")]
		private object Current
		{
			[Token(Token = "0x60075CC")]
			[Address(RVA = "0x218DD60", Offset = "0x218DE61", VA = "0x218DD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CD")]
		[Address(RVA = "0x218DD70", Offset = "0x218DE71", VA = "0x218DD70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600429D RID: 17053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8E")]
		private object Current
		{
			[Token(Token = "0x60075CE")]
			[Address(RVA = "0x218DDD0", Offset = "0x218DED1", VA = "0x218DDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A13E RID: 41278
		[Token(Token = "0x401B3E9")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A13F RID: 41279
		[Token(Token = "0x401B3EA")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A140 RID: 41280
		[Token(Token = "0x401B3EB")]
		[FieldOffset(Offset = "0x20")]
		public BuildWindowController <>4__this;

		// Token: 0x0400A141 RID: 41281
		[Token(Token = "0x401B3EC")]
		[FieldOffset(Offset = "0x28")]
		private float <ANIMTIME>5__2;

		// Token: 0x0400A142 RID: 41282
		[Token(Token = "0x401B3ED")]
		[FieldOffset(Offset = "0x2C")]
		private float <speed>5__3;

		// Token: 0x0400A143 RID: 41283
		[Token(Token = "0x401B3EE")]
		[FieldOffset(Offset = "0x30")]
		private float <timeCount>5__4;
	}
}
