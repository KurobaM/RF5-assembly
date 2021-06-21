using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000409 RID: 1033
[Token(Token = "0x2000327")]
[Attribute(Name = "ExecuteInEditMode", RVA = "0x145B90", Offset = "0x145C91")]
public class EmotionEffectController : MonoBehaviour
{
	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0000A4E8 File Offset: 0x000086E8
	[Token(Token = "0x170003B8")]
	public EmotionEffectState CurrentState
	{
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x22B0220", Offset = "0x22B0321", VA = "0x22B0220")]
		get
		{
			return EmotionEffectState.None;
		}
	}

	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x060017C7 RID: 6087 RVA: 0x0000A500 File Offset: 0x00008700
	[Token(Token = "0x170003B9")]
	public bool IsPlaying
	{
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x22B0230", Offset = "0x22B0331", VA = "0x22B0230")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001525")]
	[Address(RVA = "0x22B0240", Offset = "0x22B0341", VA = "0x22B0240")]
	private void Reset()
	{
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001526")]
	[Address(RVA = "0x22AF040", Offset = "0x22AF141", VA = "0x22AF040")]
	public void Open(bool plane = true)
	{
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001527")]
	[Address(RVA = "0x22AEF00", Offset = "0x22AF001", VA = "0x22AEF00")]
	public void Close()
	{
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001528")]
	[Address(RVA = "0x22B02E0", Offset = "0x22B03E1", VA = "0x22B02E0")]
	public void SetState(EmotionEffectState state)
	{
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x22B02F0", Offset = "0x22B03F1", VA = "0x22B02F0")]
	public void Update()
	{
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152A")]
	[Address(RVA = "0x22B0420", Offset = "0x22B0521", VA = "0x22B0420")]
	private void OnOpen()
	{
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152B")]
	[Address(RVA = "0x22B05A0", Offset = "0x22B06A1", VA = "0x22B05A0")]
	private void OnIdle()
	{
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x22B0660", Offset = "0x22B0761", VA = "0x22B0660")]
	private void OnClose()
	{
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x22B0090", Offset = "0x22B0191", VA = "0x22B0090")]
	public void Delete()
	{
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600152E")]
	[Address(RVA = "0x22B0850", Offset = "0x22B0951", VA = "0x22B0850")]
	public EmotionEffectController()
	{
	}

	// Token: 0x04005BD3 RID: 23507
	[Token(Token = "0x400585F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GameObject m_Plane;

	// Token: 0x04005BD4 RID: 23508
	[Token(Token = "0x4005860")]
	private const float DurationOpen = 0.15f;

	// Token: 0x04005BD5 RID: 23509
	[Token(Token = "0x4005861")]
	private const float DurationClose = 0.15f;

	// Token: 0x04005BD6 RID: 23510
	[Token(Token = "0x4005862")]
	private const float DurationIdle = 0.3f;

	// Token: 0x04005BD7 RID: 23511
	[Token(Token = "0x4005863")]
	[FieldOffset(Offset = "0x20")]
	private EmotionEffectState m_state;

	// Token: 0x04005BD8 RID: 23512
	[Token(Token = "0x4005864")]
	[FieldOffset(Offset = "0x24")]
	private float m_elapsed;
}
